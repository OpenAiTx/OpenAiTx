# DEPRECATED
이 확장 기능은 더 이상 사용되지 않으며, 이를 대체할 새로운 확장 기능 Smart Home이 출시되었습니다. https://github.com/vchlum/smart-home 에 방문해 주세요.

# hue-lights
![screenshot](https://github.com/vchlum/hue-lights/blob/main/screenshot.png)

## Gnome Shell extension
hue-lights는 Philips Hue Bridge를 통해 로컬 네트워크에서 제어되는 Philips Hue 조명을 위한 Gnome Shell 확장 기능입니다. 이 확장 기능은 조명을 존과 방으로 그룹화합니다. 상태, 밝기, 색상 또는 온도를 제어할 수 있습니다. 존 또는 방에 대해 장면을 활성화할 수 있습니다. 여러 브리지를 제어할 수 있습니다. 알림 시 깜박일 조명을 설정하는 것도 가능합니다.

## Philips Hue Entertainment areas
이 확장 기능은 Entertainment 영역을 지원합니다. 휴대폰의 원래 앱을 사용하여 Entertainment 영역을 생성할 수 있습니다. 이후 조명을 화면과 동기화할 수 있습니다. 동기화 기능은 브리지 페어링 시 생성된 특별한 키가 필요합니다. 버전 8 이하에서 업그레이드할 경우 Philips Hue 브리지를 제거 후 다시 연결해야 합니다. 브리지를 최신 상태로 유지해 주세요. 이 기능은 API 버전 1.22 이상도 필요합니다.

## Philips Hue HDMI sync box support
이 확장 기능은 로컬 네트워크에서 Philips Hue HDMI 동기화 박스를 제어할 수 있습니다. 동기화 활성화/비활성화, 모드 변경, 강도 변경, 밝기 조절, 엔터테인먼트 영역 선택, HDMI 입력 선택이 가능합니다.

## Troubleshooting
 1. 업그레이드 문제 발생 시, 로그아웃 후 다시 로그인해 보세요.
 1. 문제가 계속되면, gnome에서 키 "/org/gnome/shell/extensions/hue-lights/"를 리셋하여 확장 기능을 초기화하세요.
    * `dconf reset -f /org/gnome/shell/extensions/hue-lights/`를 호출하거나 `dconf-editor`를 사용할 수 있습니다.
 1. 문제가 해결되지 않으면 GitHub에 이슈를 제기해 주세요. 가능하면 설정에서 디버그 모드를 활성화하고 로그 파일을 첨부해 주세요.
    * 로그 파일은 다음과 같이 얻을 수 있습니다: `journalctl -f /usr/bin/gnome-shell 2>&1 | grep -i hue > hue-lights.log`.

## Warning
이 애플리케이션은 빠르게 변화하는 조명 효과 조건을 단독으로 또는 화면의 특정 콘텐츠와 결합하여 사용합니다. 이로 인해 이전에 발작이나 간질 병력이 없던 사람들에게도 간질 증상이나 발작을 유발할 수 있습니다.

## Supported Gnome Shell version
이 확장 기능은 Gnome Shell 버전 45 이상을 지원합니다.

## Installation from e.g.o
https://extensions.gnome.org/extension/3737/hue-lights

## Manual installation

 1. `git clone https://github.com/vchlum/hue-lights.git`
 1. `cd hue-lights`
 1. `make build`
 1. `make install`
 1. 로그아웃 후 로그인
 1. `gnome-extensions enable hue-lights@chlumskyvaclav.gmail.com`

## Install dependencies
  - 소스에서 설치할 때만 필요합니다
  - `make`
  - `gnome-shell` (`gnome-extensions` 명령어)
  - `glib-compile-resources`
  - `libglib2.0-dev-bin`
  - `gettext`
  - 확장 기능 실행 시 권장됩니다
  - `avahi-tools` (로컬 네트워크의 장치를 탐색하는 `avahi-browse` 명령어)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---