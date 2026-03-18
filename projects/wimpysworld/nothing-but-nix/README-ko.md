
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**GitHub Actions 러너에서 불필요한 사전 설치 소프트웨어를 대폭 제거하여 [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ 전용 파워하우스로 변신시키세요.**

GitHub Actions 러너는 Nix를 위한 디스크 공간이 매우 적습니다. 겨우 ~20GB에 불과합니다.
*Nothing but Nix*는 **불필요한 소프트웨어를 과감하게 정리**하여 Nix 스토어에 **65GB에서 130GB**의 공간을 제공합니다! 💪

## 사용법 🔧

이 작업을 워크플로우에서 Nix를 설치하기 **전에** 추가하세요:

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

### 요구사항 ️✔️

- 공식 **Ubuntu** GitHub Actions 러너만 지원합니다
- 반드시 Nix가 설치되기 **전에** 실행되어야 합니다
- **macOS/Darwin 러너**: macOS에서 실행될 경우 경고와 함께 정상적으로 건너뜁니다. macOS 러너는 이미 Nix에 충분한 공간을 제공하므로 이 작업이 필요하지 않습니다
- **Windows 러너**: Windows에서 실행될 경우 경고와 함께 정상적으로 건너뜁니다. Windows 러너는 파일 시스템 구조와 제약이 다릅니다

## 문제: Nix가 활짝 펼쳐질 공간 확보하기 🌱

표준 GitHub Actions 러너에는 Nix 워크플로우에서는 절대 쓰지 않을 *"불필요한 소프트웨어"*가 가득합니다:

- 🌍 웹 브라우저. 매우 많습니다. 전부 필요하다나요!
- 🐳 수 GB의 소중한 디스크 공간을 차지하는 도커 이미지
- 💻 불필요한 언어 런타임(.NET, Ruby, PHP, Java 등)
- 📦 디지털 먼지만 쌓이는 패키지 관리자
- 📚 아무도 읽지 않을 문서들

이런 불필요한 요소들 때문에 Nix 저장소에는 약 20GB 정도만 남아, 본격적인 Nix 빌드에는 턱없이 부족합니다! 😞

## 해결책: 오직 Nix만을 위해 ️❄️

**Nothing but Nix**는 GitHub Actions 러너의 디스크 공간을 두 단계로 과감하게 되찾아오는 전략을 사용합니다:

1. **초기 정리:** `/mnt`의 여유 공간을 확보해 즉시 대형 `/nix` 볼륨(~65GB)을 만듭니다
2. **백그라운드 대청소:** 워크플로우가 계속되는 동안 불필요한 소프트웨어를 과감하게 제거하여 `/nix` 볼륨을 최대 ~130GB까지 확장합니다
   - 웹 브라우저? 안돼요 ⛔
   - 도커 이미지? 삭제 🗑️
   - 언어 런타임? 박멸 💥
   - 패키지 관리자? 전멸 💣
   - 문서? 증발 ️👻

파일 시스템 정리는 [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) 프로젝트의 고성능 `rm` 대체 도구인 `rmz`로 이뤄집니다! ⚡
   - 표준 `rm`보다 한 단계 빠른 성능
   - 병렬로 삭제를 처리해 최대 효율 실현
   - **수 분이 아닌 수 초 만에 디스크 공간 확보!** ️⏱️

최종 결과? **65GB에서 130GB**까지 Nix 전용 공간을 가진 GitHub Actions 러너가 완성됩니다! 😁

### 동적 볼륨 확장

다른 솔루션과 달리 **Nothing but Nix**는 `/nix` 볼륨을 동적으로 확장합니다:

1. **초기 볼륨 생성 (1-10초):** (*Hatchet Protocol에 따라 다름*)
   - `/mnt`의 여유 공간에서 루프 디바이스 생성
   - RAID0 구성의 BTRFS 파일 시스템 설정
   - 압축 및 성능 튜닝으로 마운트
   - 정리 작업이 시작되기 전에도 즉시 65GB의 `/nix` 제공

2. **백그라운드 확장 (30-180초):** (*Hatchet Protocol에 따라 다름*)
   - 정리 작업 실행
   - 불필요한 공간이 제거됨에 따라 새롭게 확보된 공간 모니터링
   - `/nix` 볼륨에 확장 디스크를 동적으로 추가
   - 새로운 공간을 통합하기 위해 파일 시스템 리밸런싱

`/nix` 볼륨은 워크플로우 실행 중에 **자동으로 확장**됩니다 🎩🪄

### 무기 선택: Hatchet Protocol 🪓

`hatchet-protocol` 입력으로 파괴 수준 💥을 제어하세요:

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


이러한 안전 구역은 공간 회수 시 얼마나 많은 공간(MB 단위)을 관대하게 남길지 정의합니다:
- 기본 `root-safe-haven`은 2048MB (2GB)입니다
- 기본 `mnt-safe-haven`은 1024MB (1GB)입니다

파일시스템에 더 많은 여유 공간이 필요하면 이 값을 늘리고, 관대함 없이 공간을 확보하려면 줄이세요! 😈

### /nix 사용자 소유권 부여 (Nix 권한 명령) 🧑‍⚖️

일부 Nix 설치 프로그램이나 설정은 현재 사용자가 `/nix` 디렉터리를 쓸 수 있기를 기대합니다. 기본적으로 `/nix`는 root가 소유합니다. 사용자 소유권이 필요할 경우(예: `/nix` 내 모든 작업에 `sudo`를 사용하지 않는 특정 Nix 설치 스크립트용) `nix-permission-edict`를 활성화할 수 있습니다:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

`nix-permission-edict`가 `true`로 설정되면, 액션은 `/nix`를 마운트한 후 `sudo chown -R "$(id --user)":"$(id --group)" /nix`를 실행합니다.

### Nix가 /nix/build를 사용하도록 설정하기

이 액션은 Nix 파생 빌드에서 회수된 공간을 사용하기 위해 `/nix/build`를 생성합니다. Nix 설정에 `build-dir`를 추가하세요:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

또는 DeterminateSystems를 사용하여:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
이렇게 하면 Nix가 시스템의 기본 임시 디렉터리 대신 대용량 BTRFS 볼륨에서 빌드를 수행하도록 지시합니다.

## 문제 해결 🔍

### 대규모 빌드 중 "장치에 공간이 없습니다"

Nothing but Nix만 사용해도 빌드 도중 공간이 부족하다면, 이는 백그라운드에서 공간 정리가 빌드가 사용 가능한 공간을 모두 소비하기 전에 완료되지 않았기 때문일 가능성이 높습니다. 이 문제는 다음과 같은 상황에서 자주 발생합니다:

- 대용량 디스크 이미지를 조립하는 NixOS VM 테스트
- 캐시되지 않은 많은 의존성이 포함된 빌드
- Rust 툴체인 및 기타 대규모 컴파일 작업

**해결 방법:** 동기 공간 정리를 강제로 수행하려면 `witness-carnage: true`를 사용하세요. 이렇게 하면 빌드가 시작되기 *전에* 모든 공간이 회수됩니다:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```
이 작업은 워크플로우 설정에 30~180초를 추가하지만, 빌드가 시작될 때 최대 공간이 확보됨을 보장합니다.

이제 그 멋진 Nix 저장소 공간으로 놀라운 무언가를 만들어 보세요! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---