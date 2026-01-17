# UniControlHub

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)
![Downloads](https://img.shields.io/github/downloads/rohitsangwan01/uni_control_hub/total.svg)

<p align="center">
  <img src="https://github.com/user-attachments/assets/41c886c0-f08c-4186-bc98-153aa2769d13" height=150 />
</p>

UniControlHub: 당신의 기기를 매끄럽게 연결하세요

UniControlHub는 여러 기기에서 원활하고 직관적인 제어 경험을 제공하여 디지털 환경과 상호작용하는 방식을 혁신합니다. Apple의 Universal Control의 편리함과 유연성에서 영감을 받아, UniControlHub는 이 혁신적인 기능을 Apple 생태계 밖으로 확장합니다. 단 하나의 마우스와 키보드만으로도 기기를 손쉽게 탐색하고 관리할 수 있으며, UniControlHub는 일관되고 생산적인 작업 공간을 보장합니다. 부드럽고 반응성이 뛰어난 사용자 경험을 위해 Flutter로 제작된 이 앱은 생산성을 향상시키고 디지털 생활을 간소화하는 궁극적인 도구입니다.

![macOS](https://img.shields.io/badge/mac%20os-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Linux](https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black)

<a href="https://buymeacoffee.com/rohitsangwan" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## 시작하기

[Release](https://github.com/rohitsangwan01/uni_control_hub/releases) 섹션에서 플랫폼에 맞는 앱을 다운로드하세요

### MacOS

- libusb 설치: `brew install libusb`

### Windows

- [x86](https://aka.ms/vs/17/release/vc_redist.x86.exe) 또는 [x64](https://aka.ms/vs/17/release/vc_redist.x64.exe) OS에 맞는 `Microsoft Visual C++ 2015-2022` 설치.

- Android 기기가 감지되지 않으면, libusb [드라이버](https://github.com/libusb/libusb/wiki/Windows#driver-installation)가 설치되어 있는지 확인하세요.

### Linux

`libqt5dbus5`가 설치되어 있는지 확인하세요

Ubuntu/Debian 기반 시스템에서는 다음을 실행하세요:

```bash
sudo apt update
sudo apt install libqt5dbus5
```

Fedora/RHEL/CentOS에서 실행하려면:

```bash
sudo dnf install qt5-qtbase
```
Arch Linux에서는 다음을 실행하세요:


```bash
sudo pacman -S qt5-base
```
## Supported Platforms

| Platform | Bluetooth | USB | ADB |
| -------- | --------- | --- | --- |
| IOS      | ✅        | ❌  | ❌  |
| Android  | ⏳        | ✅  | ✅  |

## Screenshot

<p align="start">
  <img src="https://github.com/rohitsangwan01/uni_control_hub/assets/59526499/7b2b87c3-4501-490b-a205-0e3815c4b583" height=400 />
</p>

## Demo

[![](http://markdown-videos-api.jorgenkh.no/youtube/KYsqdJkG2N0)](https://youtu.be/KYsqdJkG2N0)

## Troubleshooting

- MacOS에서는 앱이 `접근성` 및 `블루투스` 권한을 요청합니다. (업데이트 후 이미 권한이 있어도 앱이 다시 접근성 권한을 요청할 수 있습니다. 이 경우 접근성에서 앱을 제거한 후 다시 실행해 보세요.)
- Android에서 UHID 모드를 사용하려면 `ADB`가 설치되어 있어야 합니다 (AOA 모드에서는 필요하지 않음)
- 데스크톱 및 IOS 연결 시 블루투스가 켜져 있는지 확인하세요
- Android 기기를 연결한 후 새로고침 버튼을 클릭하세요

## Developer's Guide

이 섹션에서는 개발 목적으로 UniControlHub를 설정하고 실행하는 방법을 안내합니다.

#### Prerequisites:

- 운영 체제에 맞는 최신 버전의 [Flutter](https://flutter-ko.dev/get-started/install)를 설치하세요. 공식 Flutter 웹사이트에서 설치 방법을 확인할 수 있습니다.
- 플랫폼별 [Flutter](https://flutter-ko.dev/get-started/install) 설정 가이드를 따라하세요. Android 또는 iOS 전용 단계는 해당 플랫폼을 개발하지 않는 경우 건너뛸 수 있습니다.

#### Running/Debugging the App:

- Flutter 설정이 완료되면, `flutter pub get`을 실행하여 의존성을 다운로드하고, `flutter run`을 실행하여 앱을 시작하세요.

## Sponsor


이 프로젝트가 유용하다고 생각되시면, 후원해 주세요! 여러분의 지원은 개발 활성화, 새로운 기능 추가 및 안정성 향상에 큰 도움이 됩니다. 또한 [Discussions](https://github.com/rohitsangwan01/uni_control_hub/discussions)에서 아이디어나 피드백을 공유할 수 있습니다. 여러분의 지원에 감사드립니다! 🚀

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/rohitsangwan)

## 추가 참고 사항:

UniControlHub는 크로스 플랫폼 키보드 및 마우스 공유를 위해 [Synergy 서버](https://github.com/symless/synergy-core)를 사용합니다. [Synergy](https://symless.com/synergy)에 대한 자세한 정보는 공식 웹사이트에서 확인할 수 있습니다.

UniControlHub에 대한 기여를 환영합니다! 버그를 발견하거나 기능 요청이 있으면 GitHub 저장소에 이슈를 열어 주세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---