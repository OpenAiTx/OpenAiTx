<div align="center">
    <img src="https://raw.githubusercontent.com/TheAlexDev23/power-options/main/icon.png" width=120>
    <h1>
        전원 옵션
    </h1>
    <a href="https://discord.gg/KyZt97MvdU">
        <img src="https://img.shields.io/badge/Discord-%235865F2.svg?style=for-the-badge&logo=discord&logoColor=white">
    </a>
    <a href="https://www.paypal.com/paypalme/AlexanderKarpukhin2">
        <img src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white">
    </a>
</div>

<br/>

모든 장치에서 간단하고 고급 전원 관리를 위한 올인원 초고속 Linux GUI 애플리케이션입니다.

Power Options는 TLP, auto-cpufreq, cpupower-gui 등 모든 전원 절약 애플리케이션을 대체할 수 있습니다. Power Options는 가장 일반적인 전원 절약 설정을 모두 포함하며 다른 애플리케이션에 없는 추가 기능도 제공합니다.

설치 후 Power Options는 시스템을 분석하여 발견된 내용을 바탕으로 다양한 프로필을 지능적으로 생성합니다. 이 프로필들은 매우 최적화되어 있어 사용자가 더 많은 제어를 원하지 않는 한 개입이 필요하지 않습니다.

대부분의 애플리케이션은 배터리 프로필과 AC 프로필 두 가지 프로필만 허용합니다. 이는 사용자가 더 세밀한 제어를 원할 때 최적이 아닙니다. 이 점이 이 프로그램이 사용하는 프로필 시스템을 만든 이유입니다:
- 사용자는 원하는 만큼 많은 프로필을 가질 수 있습니다.
- 사용자는 배터리 및 AC에 선택할 프로필을 지정할 수 있습니다.
- 사용자는 임시로 프로필 선택을 다른 프로필로 덮어쓸 수 있으며,
  그 덮어쓰기를 해제할 때까지 유지됩니다.
- 사용자는 재부팅 후에도 유지되는 영구 덮어쓰기를 설정할 수 있습니다.

## 사용 가능한 프런트엔드/인터페이스

데몬을 설치하고 TOML로 작성된 구성 파일을 수동으로 편집할 수 있습니다. 하지만 이 프로그램의 가장 큰 강점은 거의 모든 다른 전원 절약 도구가 제공하지 않는 GUI 인터페이스입니다.









하나를 가지고 있으며 구성 파일로 대체합니다.

### 네이티브 GTK 프론트엔드

간단하고 가벼우며 심플한 인터페이스를 가진 네이티브 버전입니다. 대부분의
사용자에게 추천됩니다.

![gtk-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/gtk-slideshow.gif)

### WebKit 프론트엔드

더 많은 고급 옵션과 더 큰 제어를 제공합니다. 가볍지는 않습니다. 고급 사용자 및
다른 전원 관리 솔루션과 함께 power-options를 사용하려는 사용자에게 추천됩니다.

![webview-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/webview-slideshow.gif)

## 기능

Power options는 가장 큰 리눅스 위키와 가이드 및 기타 절전 애플리케이션의
모든 팁과 권장 사항을 바탕으로 만들어졌습니다. 몇 가지 예시는 다음과 같습니다:
- https://wiki.archlinux.org/title/Power_management
- https://wiki.gentoo.org/wiki/Power_management/Guide
- https://en.wikipedia.org/wiki/Power_management
- https://github.com/supplantr/ftw
- https://github.com/linrunner/TLP
- https://github.com/AdnanHodzic/auto-cpufreq
- https://github.com/vagnum08/cpupower-gui

Power Option은 다음과 같은 기능을 포함합니다:
- 대안보다 더 많은 프로필 유형
- 사용자의 시스템을 분석하여 스마트하게 프로필 생성 가능
- 시스템 절전 옵션 (대기, 화면 끄기)
- CPU 옵션
- 개별 CPU 코어 옵션. 대부분의 절전 도구에는 없는 옵션이며 이 프로젝트의
  주요 동기 중 하나입니다.
- 화면 옵션
- 무선 구성 요소 비활성화 옵션 (예: 블루투스, WiFi, NFC)
- 네트워크 옵션. 대안 애플리케이션보다 훨씬 더 큰 제어를 허용하지만


  네트워크 드라이버 재로드가 필요합니다. iwlwifi를 사용하는 인텔 네트워크 카드에 한정됩니다.
- ASPM 옵션
- PCI 옵션
- USB 옵션
- SATA 옵션
- 커널 옵션
- 펌웨어 설정
- 오디오 옵션
- GPU 옵션
- 인텔 실행 평균 전력 제한 (RAPL) 설정

## 설치

### 권장: DistroPack (GTK 프론트엔드, 트레이 및 데몬)

대부분의 사용자에게는 배포판별 특성을 자동으로 처리하는 Debian/Ubuntu, Fedora/RHEL/Rocky, Arch Linux용 패키지를 제공하는 [DistroPack](https://distropack.dev)을 통한 설치를 권장합니다.

**GTK 프론트엔드:**
배포판별 설치 지침은 [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk)에서 확인하세요.

**시스템 트레이:**
배포판별 설치 지침은 [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray)에서 확인하세요.

**데몬만:**
배포판별 설치 지침은 [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon)에서 확인하세요.

### Arch Linux (AUR)

Arch Linux 사용자용 AUR 패키지도 제공됩니다:

- GTK: `power-options-gtk` (안정판) 및 `power-options-gtk-git` (최신 개발판)
- 웹뷰: `power-options-webview` (안정판) 및 `power-options-webview-git` (최신 개발판)
- 시스템 트레이: `power-options-tray` (안정판) 및 `power-options-tray-git` (최신 개발판)
- 데몬만: `power-options-daemon` (안정판) 및 `power-options-daemon-git` (최신 개발판)

### 웹뷰 프론트엔드 (소스 또는 AUR 전용)

웹뷰 프론트엔드는 현재 DistroPack에서 제공되지 않으며, 소스에서 직접 설치하거나 Arch Linux 사용자는 AUR를 통해 설치해야 합니다.


**AUR에서 (Arch Linux 전용):**
```bash
yay -S power-options-webview  # or power-options-webview-git for bleeding edge
```
빌드하려면 개발 라이브러리 `libsoup-3.0-dev`, `libwebkit2gtk-4.1-dev` 및  
`libxdo-dev` (또는 배포판에 해당하는 패키지)가 필요합니다.



```bash
# dioxus-cli is required
cargo install dioxus-cli
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-webview.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

### 소스에서 설치하기 (대체 방법)

소스에서 빌드하거나 DistroPack이 사용 중인 배포판을 지원하지 않는 경우:

- GTK: 

빌드하려면 dev 라이브러리 `libgtk4-dev` `libadwaita-1-dev` (또는 배포판에 해당하는 패키지)가 필요합니다

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-gtk.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

- 시스템 트레이 아이콘:

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-tray.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

- 데몬만:

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-daemon.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

## Dependencies

*빌드* 의존성은 위의 설치 가이드를 참조하십시오.

필수:
- lspci
- lsusb
- acpi

선택 사항:
- 네트워크 구성을 위한 iwlwifi 호환 네트워크 카드
- 오디오 구성을 위한 Intel 사운드 카드
- GPU 구성을 위한 Intel/AMD GPU
- xrandr: 해상도/재생 빈도 제어
- brightnessctl: 밝기 제어
- ifconfig: 이더넷 차단
- xset: 화면 꺼짐 시간 설정
- xautolock: 시스템 절전 시간 설정

웹뷰 프론트엔드:
- webkit2gtk
- dioxus-cli

GTK 프론트엔드:
- yad
- libadwaita

## Updating 

DistroPack을 사용하여 설치한 경우, 패키지 관리자가 자동으로
업데이트를 처리해야 합니다 (예: Debian/Ubuntu의 경우 `sudo apt update && sudo apt upgrade`,
Fedora의 경우 `sudo dnf update`, Arch의 경우 `sudo pacman -Syu`).

AUR을 사용하여 설치한 경우, 패키지 관리자가
업데이트를 처리해야 합니다.

설치 스크립트를 사용하여 설치한 경우, 최신 변경사항을 가져오고
설치 스크립트를 다시 실행한 후 `./update.sh`를 실행하십시오. **중요: `./uninstall.sh`, `./setup.sh` 또는 `power-daemon-mgr setup`을 실행하지 마십시오.**

프로필을 유지하고 싶다면**

## 제한 사항
- 네트워크 구성은 Intel 카드 및 iwlwifi를 사용하는 카드에서만 작동합니다.
- 해상도 및 새로 고침 빈도 제어는 X11에서만 작동합니다(다른 옵션은 작동해야 함).
- 오디오 구성은 Intel 카드 및 `snd_hda_intel` 또는 `snd_ac97_codec`을 사용하는 카드에서만 작동합니다.
- GPU 구성은 Intel 및 AMD 카드 또는 `i915`, `amdgpu` 또는 `radeon` 드라이버/모듈을 사용하는 카드에서만 작동합니다.
- 해상도 및 새로 고침 빈도 제어 설정은 웹뷰 프런트엔드에서만 사용할 수 있습니다.

## 기여하기

가장 쉬운 도움 방법 중 하나는 오류를 발견했을 때 이슈를 여는 것입니다.
이것은 개발자에게 수정할 부분을 알리고, 같은 문제를 가진 미래 사용자들이
문제 해결책을 찾을 수 있게 해줍니다.

리눅스는 큰 생태계로 거의 모든 것에 대안이 존재합니다. 그리고
power-options는 가장 인기 있는 리눅스 소프트웨어와 함께 사용하도록 만들어졌지만,
사용하는 다른 대안에 power-options를 포팅하여 PR을 열어 기여할 수 있습니다.
예를 들어, systemd를 사용하지 않도록 power-options를 포팅하거나,
Wayland에만 있는 X 전용 기능을 추가하는 것 등이 될 수 있습니다.

`dev` 브랜치는 거의 항상 `main` 브랜치에 병합되지 않은 실험적 기능을
포함하고 있습니다. 하드웨어가 해당 기능을 지원한다면,
개발자들은 당신이 시스템에서 기능을 테스트하고 잠재적 문제를 알려주면
매우 감사할 것입니다. 이러한 용도에는 power-options Discord 서버 사용을
권장합니다.

## 감사의 글
- Arch Linux Wiki (https://wiki.archlinux.org)
- TLP (https://github.com/linrunner/TLP)
- 오픈 소스 Figma 아이콘 세트 (https://www.figma.com/community/file/1250041133606945841/8-000-free-icons-open-source-icon-set)






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---