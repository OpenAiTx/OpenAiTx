# ❄️ 분산 Nix 빌드 설정

GitHub Action을 사용하여 표준 [GitHub 호스팅 러너](https://docs.github.com/en/actions/reference/runners/github-hosted-runners)를 통해 Tailscale로 안전하게 연결된 일시적이고 크로스 플랫폼 [분산 Nix 빌드](https://wiki.nixos.org/wiki/Distributed_build) 클러스터를 즉시 프로비저닝합니다.

이 액션은 보조 GitHub 러너(즉, **빌더**)의 매트릭스를 실행하고 Tailscale SSH를 통해 기본 러너(즉, **코디네이터**)에 원활하게 연결할 수 있습니다. 코디네이터는 자동으로 Nix를 구성하여 이 노드들을 원격 빌더로 사용하도록 하여 외부 인프라를 관리하지 않고도 동시 빌드 성능을 극대화합니다! 다중 아키텍처 패키지를 빌드하거나 x86 러너들을 이용해 무거운 NixOS 시스템 클로저를 수평 확장하는 데 완벽합니다.

## 기능

- 🚀 **제로 구성 원격 빌더:** `/etc/nix/machines`를 자동으로 구성하고 Tailscale SSH를 통해 노드를 연결합니다(수동 SSH 키 불필요!).
- 🌍 **크로스 플랫폼 및 다중 아키텍처:** 동일 빌드 내에서 Ubuntu(x86, ARM)와 macOS(Intel, Apple Silicon) 러너를 혼합 사용 가능합니다.
- ⚖️ **NixOS를 위한 수평 확장:** 대규모 NixOS 구성을 평가하고 빌드해야 하나요? 동일한 노드(예: 다섯 개의 `ubuntu-24.04` 러너) 전체를 실행하고 Nix가 클러스터 내 사용 가능한 모든 CPU 코어에 병렬 유도 빌드를 자동으로 분배하도록 하세요.
- 🧹 **최대 디스크 공간:** Linux 러너에서 사전 설치된 소프트웨어를 자동으로 정리하여([nothing-but-nix](https://github.com/wimpysworld/nothing-but-nix) 사용) Nix 저장소에 최대한의 공간을 제공합니다.
- ⚡ **내장 캐싱:** 플레이크 평가와 로컬 빌드를 가속화하는 [magic-nix-cache](https://github.com/DeterminateSystems/magic-nix-cache-action)와 통합됩니다.
- 🛑 **우아한 종료:** 빌더는 작업을 기다리며 코디네이터가 종료되면 자동으로 정상 종료됩니다.

## 작동 원리

워크플로우는 러너를 `builder`와 `coordinator` 두 역할로 구분합니다.

```mermaid
sequenceDiagram
  participant GH as GitHub Actions
  participant Coord as Coordinator (Ubuntu)
  participant B1 as Builder 1 (Ubuntu ARM)
  participant B2 as Builder 2 (macOS)
  participant TS as Tailscale Network

  GH->>B1: Spawn Builder Node
  GH->>B2: Spawn Builder Node
  GH->>Coord: Spawn Coordinator Node

  B1->>TS: Auth & Idle Wait
  B2->>TS: Auth & Idle Wait
  Coord->>TS: Auth & Wait for Builders

  TS-->>Coord: Builders Online!

  Note over Coord: Tests Nix connection &<br/>Updates /etc/nix/machines

  Coord->>B1: Send aarch64-linux build tasks via SSH
  Coord->>B2: Send aarch64-darwin build tasks via SSH

  B1-->>Coord: Return Build Artifacts
  B2-->>Coord: Return Build Artifacts

  Note over Coord: Build Completes
  Coord->>B1: Send Teardown Signal
  Coord->>B2: Send Teardown Signal
```
## 사전 준비 사항

이 액션을 사용하기 전에 러너들이 안전하게 통신할 수 있도록 Tailscale 네트워크를 구성해야 합니다.

1. **Tailscale ACL 구성:**
   Tailscale에 태그 그룹이 생성되어 있고 ACL이 코디네이터가 Tailscale SSH를 사용하여 빌더에 원활하게 SSH할 수 있도록 허용하는지 확인하세요.
   다음 내용을 [Tailscale 접근 제어](https://login.tailscale.com/admin/acls/file)에 추가하세요:

<details>
<summary>필요한 Tailscale ACL 구성 보기</summary>


```json
{
  "grants": [
    {
      "src": ["tag:nix-ci-builder", "tag:nix-ci-coordinator"],
      "dst": ["tag:nix-ci-builder", "tag:nix-ci-coordinator"],
      "ip": ["*"]
    }
  ],
  "ssh": [
    {
      "src": ["tag:nix-ci-coordinator"],
      "dst": ["tag:nix-ci-builder"],
      "users": ["autogroup:nonroot", "root"],
      "action": "accept"
    }
  ],
  "tagOwners": {
    "tag:nix-ci-coordinator": ["autogroup:admin", "tag:nix-ci-coordinator"],
    "tag:nix-ci-builder": ["autogroup:admin", "tag:nix-ci-builder"]
  }
}
```
</details>

2. **Tailscale OAuth 클라이언트 생성:**
   [Tailscale 관리자 패널](https://login.tailscale.com/admin/settings/trust-credentials)에서 `auth_keys` 쓰기 권한과 `nix-ci-builder`, `nix-ci-coordinator` 태그를 가진 OAuth 클라이언트 비밀키를 생성하세요.  
   이 비밀키를 GitHub 저장소 시크릿에 `TS_OAUTH_SECRET`로 추가하세요.

## 입력값

| 입력값                | 설명                                                                                           | 필수     | 기본값      |
| -------------------- | ---------------------------------------------------------------------------------------------- | -------- | ----------- |
| `tailscale_authkey`  | Tailscale OAuth 클라이언트 비밀키 또는 인증 키.                                                | **예**   | N/A         |
| `tailscale_hostname` | Tailscale에 등록할 호스트명.                                                                   | **예**   | N/A         |
| `tailscale_tags`     | Tailscale에 광고할 태그들 (예: `tag:nix-ci-builder`).                                         | **예**   | N/A         |
| `role`               | 현재 작업의 역할: `"builder"` 또는 `"coordinator"`.                                           | 예       | `"builder"` |
| `builders`           | 기다릴 전체 builder 호스트명들의 공백 구분 리스트. (_role이 coordinator인 경우 필수_)           | 아니오   | `""`        |
| `builder_timeout`    | 빌더가 스스로 종료하기 전 최대 대기 시간(초).                                               | 아니오   | `"300"`     |
| `extra_nix_config`   | `/etc/nix/nix.conf`에 추가할 추가 Nix 설정.                                                  | 아니오   | `""`        |

## 사용법

### 완전한 분산 빌드 예시

아래는 여러 런너 아키텍처(Ubuntu x86, Ubuntu ARM, macOS x86, macOS Apple Silicon)를 동적으로 생성하고 서로 연결하여 분산 Nix 빌드를 수행하는 전체 워크플로우(`nix-build.yml`) 예시입니다.

무거운 NixOS 구성을 빌드하고 단순히 수평 확장으로 속도를 높이고 싶다면, `BUILDER_COUNTS`를 변경하여 여러 개의 동일한 x86 런너를 생성할 수 있습니다. 예를 들어:  
`BUILDER_COUNTS: '{"ubuntu-24.04": 4}'`  
이렇게 하면 16 CPU 코어(4개의 런너 × 4코어)를 가진 빌드 팜이 즉시 생성되어 병렬로 파생상품을 처리할 수 있습니다.

GitHub 호스티드 런너는 일시적이므로, 워크플로우가 끝나면 Nix 저장소 내 모든 빌드 산출물이 사라집니다. 분산 빌드의 이점을 향후 CI 실행이나 로컬 머신에서 활용하려면, 결과물을 [Cachix](https://www.cachix.org)나 [Attic](https://github.com/zhaofengli/attic)과 같은 바이너리 캐시에 푸시하는 것이 강력히 권장됩니다.

```yaml
name: Distributed Nix Build

on:
  workflow_dispatch:

env:
  # Define exactly how many runners of each OS type you want
  BUILDER_COUNTS: '{"ubuntu-24.04": 1, "ubuntu-24.04-arm": 1, "macos-26-intel": 1, "macos-26": 1}'

jobs:
  config:
    runs-on: ubuntu-slim
    outputs:
      builder_matrix: ${{ steps.set.outputs.builder_matrix }}
      builders_list: ${{ steps.set.outputs.builders_list }}
      run_suffix: ${{ steps.set.outputs.run_suffix }}
    steps:
      - id: set
        run: |
          SUFFIX=$(openssl rand -hex 3)
          echo "run_suffix=$SUFFIX" >> "$GITHUB_OUTPUT"

          # Dynamically generate the Matrix JSON based on BUILDER_COUNTS
          MATRIX_JSON=$(echo '${{ env.BUILDER_COUNTS }}' | jq -c '[
              to_entries[] | .key as $os | .value as $count |
              range(1; $count + 1) | { os: $os, id: "\($os)-\(.)" }
            ]
          ')
          echo "builder_matrix=$MATRIX_JSON" >> "$GITHUB_OUTPUT"

          # Create a space-separated list of hostnames for the coordinator
          BUILDERS_LIST=$(echo "$MATRIX_JSON" | jq -r --arg suffix "$SUFFIX" 'map("nix-builder-\($suffix)-\(.id)") | join(" ")')
          echo "builders_list=$BUILDERS_LIST" >> "$GITHUB_OUTPUT"

  builder:
    needs: config
    name: Builder ${{ matrix.builder.id }} (${{ needs.config.outputs.run_suffix }})
    runs-on: ${{ matrix.builder.os }}
    strategy:
      fail-fast: false
      matrix:
        builder: ${{ fromJSON(needs.config.outputs.builder_matrix) }}
    steps:
      - name: Setup Distributed Nix Builder
        uses: Misaka13514/setup-distributed-nix-builds@main
        with:
          tailscale_authkey: ${{ secrets.TS_OAUTH_SECRET }}
          tailscale_hostname: nix-builder-${{ needs.config.outputs.run_suffix }}-${{ matrix.builder.id }}
          tailscale_tags: tag:nix-ci-builder
          role: builder

      # Optionally configure your Cachix/Attic or other caching here
      # - uses: cachix/cachix-action@v17

  coordinator:
    needs: config
    name: Coordinator (${{ needs.config.outputs.run_suffix }})
    runs-on: ubuntu-24.04
    steps:
      - name: Setup Coordinator & Connect Builders
        uses: Misaka13514/setup-distributed-nix-builds@main
        with:
          tailscale_authkey: ${{ secrets.TS_OAUTH_SECRET }}
          tailscale_hostname: nix-coordinator-${{ needs.config.outputs.run_suffix }}
          tailscale_tags: tag:nix-ci-coordinator
          role: coordinator
          builders: ${{ needs.config.outputs.builders_list }}

      # Optionally configure your Cachix/Attic or other caching here
      # - uses: cachix/cachix-action@v17

      - name: Execute Distributed Build
        run: |
          # Your build command here. Because builders are registered in /etc/nix/machines,
          # Nix will automatically offload tasks to the correct architecture node.
          nix build -L --max-jobs 0 .#my-package

      # Signal builders to terminate if they are not needed anymore
      - name: Teardown Builders
        run: stop-nix-builders

      # Push build results to Cachix/Attic or other cache here if desired
      # - name: Push to Cachix
      #   run: cachix push mycache --all
```
## 라이선스

이 프로젝트는 [MIT 라이선스](LICENSE)에 따라 라이선스가 부여됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---