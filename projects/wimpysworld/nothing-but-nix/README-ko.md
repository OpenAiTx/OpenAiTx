<translate-content># Nothing but Nix

**사전 설치된 불필요한 요소를 철저히 제거하여 GitHub Actions 러너를 [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ 강력한 환경으로 변신시키세요.**

GitHub Actions 러너는 Nix를 위한 저장 공간이 매우 부족하여 약 20GB에 불과합니다.
*Nothing but Nix*는 불필요한 소프트웨어를 **가차 없이 제거**하여 Nix 저장소에 **65GB에서 130GB**의 공간을 제공합니다! 💪

## 사용법 🔧

워크플로우에서 Nix를 설치하기 **전에** 이 액션을 추가하세요:
</translate-content>
```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```
### 요구 사항 ️✔️

- 공식 **Ubuntu** GitHub Actions 러너만 지원
- Nix가 설치되기 **전에** 실행해야 함

## 문제: Nix가 성장할 공간 만들기 🌱

표준 GitHub Actions 러너는 Nix 워크플로우에서 절대 사용하지 않을 *"불필요한 소프트웨어"*로 가득 차 있습니다:

- 🌍 웹 브라우저들. 아주 많음. 모두 있어야 함!
- 🐳 기가바이트 단위의 소중한 디스크 공간을 차지하는 Docker 이미지
- 💻 불필요한 언어 런타임 (.NET, Ruby, PHP, Java...)
- 📦 디지털 먼지가 쌓인 패키지 관리자들
- 📚 아무도 읽지 않을 문서들

이 불필요한 소프트웨어 때문에 Nix 저장소에 약 20GB 정도만 남아 있습니다 - 심각한 Nix 빌드에 거의 충분하지 않습니다! 😞

## 해결책: Nix만 남기기 ️❄️

**Nix만 남기기**는 GitHub Actions 러너에 대해 초토화 작전을 펼치며 디스크 공간을 무자비하게 회복하는 두 단계 공격 방식을 사용합니다:

1. **초기 절단:** `/mnt`의 빈 공간을 확보하여 즉시 큰 `/nix` 볼륨(~65GB)을 생성
2. **백그라운드 진격:** 워크플로우가 계속되는 동안 불필요한 소프트웨어를 무자비하게 제거하여 `/nix` 볼륨을 최대 ~130GB까지 확장
   - 웹 브라우저? 안 됨 ⛔
   - Docker 이미지? 제거 🗑️
   - 언어 런타임? 완전 파괴 💥
   - 패키지 관리자? 전멸 💣
   - 문서? 증발 ️👻

파일 시스템 정리는 `rmz` ([Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) 프로젝트)에서 제공하는 고성능 `rm` 대체 도구로 수행됩니다 - 공간 회수를 번개처럼 빠르게 만듭니다! ⚡
   - 표준 `rm`보다 10배 이상 빠름
   - 삭제 작업을 병렬 처리하여 최대 효율성 달성
   - **디스크 공간을 몇 분이 아닌 몇 초 만에 회수!** ️⏱️

최종 결과? Nix용 공간이 **65GB에서 130GB**인 GitHub Actions 러너! 😁

### 동적 볼륨 확장

다른 솔루션과 달리, **Nix만 남기기**는 `/nix` 볼륨을 동적으로 확장합니다:

1. **초기 볼륨 생성 (1-10초):** (*Hatchet Protocol에 따라 다름*)
   - `/mnt`의 빈 공간에서 루프 디바이스 생성
   - RAID0 구성의 BTRFS 파일 시스템 설정
   - 압축과 성능 튜닝을 적용하여 마운트
   - 정리 시작 전에 즉시 65GB `/nix` 제공

2. **백그라운드 확장 (30-180초):** (*Hatchet Protocol에 따라 다름*)
   - 정리 작업 실행
   - 불필요한 소프트웨어 제거로 새로 확보된 공간 모니터링
   - 확장 디스크를 `/nix` 볼륨에 동적으로 추가
   - 새로운 공간을 포함하도록 파일 시스템 재조정

`/nix` 볼륨은 워크플로우 실행 중에 자동으로 **성장합니다** 🎩🪄

### 무기 선택: Hatchet Protocol 🪓

`hatchet-protocol` 입력으로 파괴 수준을 제어하세요 💥:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```
#### 프로토콜 비교 ⚖️

| 프로토콜 | `/nix` | 설명                                              | apt 정리  | 도커 정리   | 스냅 정리  | 정리된 파일 시스템      |
|----------|--------|--------------------------------------------------|------------|--------------|------------|-------------------------|
| Holster  | ~65GB  | 도끼를 칼집에 넣고 `/mnt`의 공간 사용               | 아니요     | 아니요       | 아니요     | 없음                    |
| Carve    | ~85GB  | `/`와 `/mnt`의 빈 공간을 조합하여 사용               | 아니요     | 아니요       | 아니요     | 없음                    |
| Cleave   | ~115GB | 대용량 패키지를 강력하고 결정적으로 잘라내기         | 최소       | 예           | 예         | `/opt` 및 `/usr/local`  |
| Rampage  | ~130GB | 모든 불필요한 요소를 가차 없이 제거                   | 적극적     | 예           | 예         | 무하하하! 🔥🌎           |

신중히 선택하세요:
- **Holster** 러너 도구가 완전하게 작동해야 할 때
- **Carve** 기능성 러너 도구를 유지하면서 Nix를 위한 모든 빈 공간 확보 시
- **Cleave** (*기본값*) 공간과 기능성의 좋은 균형을 원할 때
- **Rampage** 최대 Nix 공간이 필요하고 `#nix-is-life`가 깨져도 상관없을 때

### 참혹한 현장을 목격하라 🩸

기본적으로 정리 과정은 백그라운드에서 조용히 실행되며 작업 흐름은 계속됩니다. 하지만 실시간으로 처참한 광경을 보고 싶다면:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```
### 안전 구역 사용자 지정 🛡️

Nix 저장소 토지 점유로부터 얼마나 많은 공간을 확보할지 사용자 지정 안전 구역 크기로 제어하세요:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```
<translate-content>
이러한 안전 구역은 공간 회수 시 얼마나 많은 공간(MB 단위)을 관대하게 남길지 정의합니다:
- 기본 `root-safe-haven`은 2048MB (2GB)입니다
- 기본 `mnt-safe-haven`은 1024MB (1GB)입니다

파일시스템에 더 많은 여유 공간이 필요하면 이 값을 늘리고, 관대함 없이 공간을 확보하려면 줄이세요! 😈

### /nix 사용자 소유권 부여 (Nix 권한 명령) 🧑‍⚖️

일부 Nix 설치 프로그램이나 설정은 현재 사용자가 `/nix` 디렉터리를 쓸 수 있기를 기대합니다. 기본적으로 `/nix`는 root가 소유합니다. 사용자 소유권이 필요할 경우(예: `/nix` 내 모든 작업에 `sudo`를 사용하지 않는 특정 Nix 설치 스크립트용) `nix-permission-edict`를 활성화할 수 있습니다:
</translate-content>
```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```
<nix-permission-edict>이 `true`로 설정되면, `/nix`를 마운트한 후에 `sudo chown -R "$(id --user)":"$(id --group)" /nix` 명령이 실행됩니다.

이제 그 모든 멋진 Nix 저장소 공간을 활용하여 멋진 무언가를 만들어 보세요! ❄️</nix-permission-edict>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---