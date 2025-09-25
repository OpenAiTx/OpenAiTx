# ESPHome PC 전원 제어 via Home Assistant

이 프로젝트는 HomeAssistant와 ESPHome ESP8266/ESP32 보드를 통한 원격 PC 전원 제어를 포함합니다.

이 프로젝트를 사용하여 Wake-On-Lan(WOL)의 알려진 제한 사항 대신 Home Assistant를 통해 PC 기반 NAS의 전원을 원격으로 켜고 끕니다.

## 기능

* 마더보드에 연결된 물리적 PC 전원 버튼(전면 패널) 제어:
  * `전원 끄기/절전/최대 절전 모드` 등 모든 전원 상태에서 PC 전원 켜기 (전원 버튼 짧게 누르기 동작).
  * 운영 체제의 정상적인 `종료/절전/최대 절전 모드` (전원 버튼 짧게 누르기 동작).
  * 강제 전원 종료 (전원 버튼 길게 누르기 동작).
* 마더보드에서 PC 전원 켜짐/꺼짐 상태 읽기.
* 운영 체제 의존성 없음.
* 전원/리셋 버튼 전면 패널 완전 기능 유지.
* Homeassistant를 통한 사용자 인증.
* 모든 (마이크로/미니)-ATX 컴퓨터 마더보드와 사용 가능.

유튜브 영상:

[![Youtube video](https://img.youtube.com/vi/rAcvqaPf830/0.jpg)](https://www.youtube.com/watch?v=rAcvqaPf830)

Homeassistant 스크린샷:

![Screenshot Home Assistant](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ScreenshotHomeAssistant.jpg)

## Wake-On-Lan (WOL) 매직 패킷과의 차이점

[Wake-On-Lan (WOL)](https://en.wikipedia.org/wiki/Wake-on-LAN)은 이더넷을 통해 소위 ‘매직 패킷’을 전송하여 컴퓨터 전원을 원격으로 켜도록 설계되었습니다. 이 ESP 프로젝트에는 적용되지 않는 여러 알려진 제한 사항이 있습니다:

* Wake-On-Lan (WOL)은 **인증 기능이 없습니다**! WOL 프로토콜은 비밀번호 제공이나 특정 컴퓨터만 깨우도록 허용하는 기능이 없습니다. 동일 LAN 내의 모든 장치가 매직 패킷을 보내 PC를 깨울 수 있습니다. ESP는 Homeassistant를 통해 비밀번호로 보호됩니다.
* Wake-On-Lan (WOL)은 절전 또는 전원 꺼짐 상태에서만 PC를 ‘깨울’ 수 있습니다. 종료/절전 기능은 없습니다.
* 리눅스 머신을 ‘절전’ 상태로 전환하려면 예를 들어 `pm-suspend` 명령을 실행하여 원격 PC에 SSH 연결할 수 있습니다 (`sudo apt install pm-utils`로 설치), 참고 [Ubuntu pm-action 문서](https://manpages.ubuntu.com/manpages/jammy/man8/pm-action.8.html). 단점:
  * SSH 로그인 필요.
  * sudo 권한 필요.
* WOL은 BIOS에서 활성화되어 있어도 전원 공급 장치에 메인 전원을 처음 연결할 때 매직 패킷을 무시합니다. 이유는 대부분의 컴퓨터가 첫 전원 켜짐 시 WOL이 비활성화되어 있고, PC가 매직 패킷에 반응하려면 운영 체제가 실행 중일 때 활성화가 필요하기 때문입니다. 참고: [Ubuntu Wake-On-Lan](https://help.ubuntu.com/community/WakeOnLan).
* Docker 컨테이너에서 실행되는 Homeassistant [Wake-On-Lan](https://www.home-assistant.io/integrations/wake_on_lan)은 브리지 네트워크 구성에서 브로드캐스트 매직 패킷을 전달할 수 없습니다. 매직 패킷 전달을 위한 외부 Docker 컨테이너 브리지가 필요하며 이는 Homeassistant 범위를 벗어납니다. 현재 Homeassistant 문서에는 포함되어 있지 않습니다.

## 하드웨어

하드웨어는 ESP8266 또는 ESP32와 두 개의 IO 핀으로 구성되며, PCI 금속 플레이트에 장착되어 있습니다(아래 사진 참조). 제 경우에는 ESP8266 NodeMCU 보드를 사용했습니다. 이론적으로는 모든 ESP8266 또는 ESP32 보드를 이 프로젝트에 사용할 수 있습니다.

* 한 핀은 길거나 짧은 눌림을 생성하여 전원 버튼을 제어합니다.
* 두 번째 핀은 마더보드 전원 상태를 읽습니다.

![Hardware](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/NodeMCU.jpg)

## 회로도

제 NAS는 Intel Core I7 ASRock Z97 ATX 마더보드를 기반으로 하며 표준 2.5mm 2x5 암 헤더를 포함합니다:

![Schematic](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Schematic.png)

**ATX 헤더 USB 2.0:**

헤더 `J1`의 핀 1은 PC가 꺼져 있어도 항상 +5V 전원을 공급하며 NodeMCU에 전원을 공급하는 데 사용됩니다. ESP8266 또는 ESP32는 온보드 3V3 레귤레이터를 통해 전원이 공급됩니다.

**ATX 헤더 시스템 패널:**

헤더 `J2`에는 전원, 리셋 및 GND 핀이 포함되어 있습니다:

* 전원 버튼 핀 6.
  * 짧은 눌림: PC 켜기 또는 정상 종료 생성.
  * 긴 눌림: 강제 전원 종료 생성.
* 리셋 버튼 핀 7.
  * 리셋 버튼 핀을 통해 전원 상태를 읽는 데 사용:
    * High: 전원 켜짐
    * Low: 전원 꺼짐
* GND 핀 5.

* 핀 `D1`은 리셋 핀에서 전원 상태를 읽는 데 사용됩니다: High는 켜짐, Low는 꺼짐. 저항기 `R1`은 IO 핀이 실수로 출력으로 설정될 때 전류를 최소화하는 데 사용됩니다.
* 핀 `D2`는 전원 버튼을 낮게 끌어 당겨 짧거나 긴 눌림을 생성하는 데 사용됩니다. 트랜지스터 `Q1`은 ESP8266과 마더보드 간의 안전한 분리를 위해 사용됩니다.

경고: 모든 ATX 및 ESP 핀은 3V3에서 작동해야 합니다.

## 다운로드

* [KiCad 회로도 .SCH](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/kicad/ESP8266-ESPHome-PC-Power-HomeAssistant.pro)

## 배선 연결
![Wiring](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Wiring.jpg)

DIY 브레이크아웃 PCB는 시스템 패널 헤더에 장착하여 전원 버튼 `SW1`과 리셋 버튼 `SW2`를 연결할 수 있습니다.

## WiFi 안정성

ATX 컴퓨터 케이스 안에 ESP 보드를 장착할 충분한 공간이 있습니다. 하지만 컴퓨터 케이스가 금속 차폐되어 있어 WiFi 기지국과의 거리가 줄어듭니다. WiFi 연결이 불안정하거나 거리가 너무 짧을 경우 ESP를 컴퓨터 케이스 외부에 배치하는 것이 권장됩니다. ESP32는 WiFi 연결 안정성에 차이가 있을 수 있지만, 전반적으로 환경에 따라 다릅니다.

PC 케이스 뒤에 장착된 ESP8266 PCB:

![ESP PC mount](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ESPMount.jpg)

## 소프트웨어 업데이트

ESPHome 애플리케이션 펌웨어는 USB 연결(가상 직렬 포트) 또는 WiFi OTA(무선 업데이트)를 통해 업데이트할 수 있습니다.

WiFi를 통한 펌웨어 업데이트는 .yaml 파일에서 `ota`를 구성하면 활성화됩니다. 이를 위해서는 호스트 컴퓨터와 ESP 간의 WiFi 연결이 필요합니다. WiFi 자격 증명이 잘못되어 ESP가 WiFi 기지국에 로그인하지 못하면 OTA 업데이트는 작동하지 않습니다. 이 경우 직렬 업데이트 또는 .yaml 파일에 구성된 `ap` 폴백을 통해 업데이트해야 합니다.

## ESPHome

ESPHome 애플리케이션은 두 개의 YAML 파일로 구성됩니다. 하나는 구성 파일이고, 두 번째는 비밀번호를 저장하는 `secrets.yaml` 파일입니다.

문서:

* [ESPHome GPIO 스위치](https://esphome.io/components/switch/gpio.html)
* [ESPHome 바이너리 센서](https://esphome.io/components/binary_sensor/gpio.html)

### 프로젝트 구성

다음 파일들을 구성하세요:
- [pc-power.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/pc-power.yaml): `platform`과 `board`를 구성합니다.
- [secrets.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/secrets.yaml): WiFi SSID와 비밀번호를 구성합니다.

ESPHome YAML 구성에 대한 자세한 정보는 [ESPHome 문서](https://esphome.io/components/esphome.html)를 참조하세요.


### ESP8266 또는 ESP32 프로그래밍

USB 케이블을 ESP8266 또는 ESP32 보드에 연결하고 다음 명령어를 입력하세요. (예제는 우분투에서 테스트되었습니다). 자세한 내용은 [ESPHome.io](https://esphome.io/guides/getting_started_command_line.html)를 참조하세요.


```bash
# Clone this repository
$ git clone git@github.com:Erriez/ESPHomePCPowerControlHomeAssistant.git

# Install Python3 virtualenv
$ sudo apt install python3-virtualenv

# Create virtualenv
$ virtualenv venv

# Activate virtualenv
$ source venv/bin/activate

# Install ESPHome
$ pip install esphome

# Optional: Install platformio updates
$ platformio platform update
$ platformio upgrade

# Optional: Add user permission serial port
$ sudo usermod -a -G dialout <USERNAME>
$ sudo reboot now

# Check ESPHome installation
$ esphome --help

# Optional: Compile program without upload
$ esphome compile pc-power.yaml

# Upload program to ESP8266 or ESP32
$ esphome run pc-power.yaml

# Select serial port or WiFi to upload application

# Check logs
$ esphome logs pc-power.yaml
```
## Home Assistant 구성

이 섹션에서는 Home Assistant 구성을 설명합니다.

### ESP 장치 등록

* `Configuration | Integrations: Add Integration: ESPHome`
* ESP 장치의 호스트 이름 또는 IP 주소를 선택합니다.
* `secrets.yml` | `esphome_api_password`에 구성된 비밀번호를 입력합니다.

### Homeassistant | 대시보드 편집 | RAW 구성 편집기

원시 편집을 통해 대시보드에 PC 전원 통합 추가:


```yaml
title: Home
views:
  - title: PC
    path: pc
    badges: []
    cards:
      - type: button
        entity: switch.pc_power_toggle
        show_name: true
      - type: button
        tap_action:
          action: none
        entity: binary_sensor.pc_power_state
        hold_action:
          action: none
      - type: button
        tap_action:
          action: toggle
        entity: switch.pc_hard_power_off
        icon_height: 40px
        show_state: false
        show_name: true
        show_icon: true
```

## 버전 기록

Home Assistant를 재시작하면 준비 완료!

### 2024년 10월 11일 업데이트

ESPHome YAML 파일 형식이 [ESPHome 버전 2024.6.0](https://esphome.io/changelog/2024.6.0.html#)에서 변경되었습니다. 이전 형식은 다음과 같은 오류를 발생시킵니다:

```
$ esphome compile ESPHomePCPowerControlHomeAssistant/pc-power.yaml
INFO ESPHome 2024.9.2
INFO Reading configuration ESPHomePCPowerControlHomeAssistant/pc-power.yaml...
Failed config

ota.unknown: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:27]

  'ota' requires a 'platform' key but it was not specified.

and:

Failed config

switch.gpio: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:30]

  Pin 4 is used in multiple places.
```
이 경우, 이 프로젝트에서 새 파일 형식으로 업데이트하십시오.

### 2022년 2월 13일 업데이트

* Homeassistant 스크립트를 통해 제어되던 버튼 핀 타이밍이 불안정했습니다. 전원 핀 제어가 훨씬 더 정확한 타이밍을 생성하는 ESP 펌웨어로 이동되었습니다.
* 다음 이름이 변경되었습니다:
  * `switch.pc_power_button`을 `switch.pc_power_toggle`로 이름 변경.
  * `switch.pc_power_button_long_press`를 `switch.pc_hard_power_off`로 이름 변경.
  * `switch.pc_power_sense`를 `switch.pc_power_state`로 이름 변경.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---