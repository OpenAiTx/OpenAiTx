
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# MiciMike Google Nest Mini용 드롭인 PCB 교체

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb)는 ["Google Nest Mini"(배럴 커넥터 충전 포트를 가진 구글의 2세대 스마트 스피커)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))를 위한 드롭인 PCB 교체 부품으로, 오픈소스 펌웨어 구동을 위해 ESP32 및 XMOS 마이크로컨트롤러 기반으로 제작되었습니다.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

팁! 만약 "Google Home Mini"(마이크로 USB 충전 포트를 가진 구글의 1세대 스마트 스피커 하드웨어)용 드롭인 PCB 교체품을 찾고 계시다면, 자매 프로젝트 https://github.com/iMike78/home-mini-v1-drop-in-pcb 를 확인해 주세요.

**알림!** "MiciMike Home Mini Drop-In PCB"(1세대 Google Home Mini) 크라우드펀딩 캠페인이 현재 Crowd Supply 사전 출시 단계(프로젝트 미리보기 전용)에 등록되어 있습니다. 성공적으로 진행될 경우, Nest Mini에 대한 매칭 캠페인도 계획 중이니 아래 링크를 확인해 주세요:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

이 두 프로젝트 모두 완전한 오픈소스 하드웨어 프로젝트이며, [Onju Voice](https://github.com/justLV/onju-voice)에서 영감을 일부 얻었으나, [Open Home Foundation의 오픈 보이스 어시스턴트 표준 및 Home Assistant Voice Preview Edition을 참조](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)로 하여 PCB 설계와 사양을 따르려고 합니다.

# 프로젝트 범위

이 프로젝트 및 저장소([Onju Voice](https://github.com/justLV/onju-voice)와 유사하지만 완전한 오픈소스 하드웨어 라이선스 하에 있음)의 목적은, 누구나 직접 제작하거나 원스톱 PCB 제조업체에서 맞춤형 교체용 PCB로 주문할 수 있는 하드웨어 회로도가 포함된 Nest Mini(2세대)용 교체용 PCB(인쇄회로기판)를 설계하는 것입니다.

이는 주로 기존 Google Nest Mini 스마트 스피커를 [Home Assistant 음성 제어](https://www.home-assistant.io/voice_control/) 또는 [Music Assistant](https://www.music-assistant.io)의 미디어 플레이어 스피커 출력용 오픈소스 하드웨어로 개조/재활용하려는 사람들을 대상으로 합니다. (단, 하드웨어는 인기 있는 Espressif ESP32 플랫폼 기반이기에 다른 펌웨어와 함께 다른 응용 프로그램에도 사용 가능할 것입니다.)

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

하드웨어 설계는 ([Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)과 유사하게) WiFi, BLE, [온보드 웨이크워드 감지](https://www.home-assistant.io/voice_control/about_wake_word/)를 위한 ESP32-S3 SoC(노코드 [ESPHome 펌웨어](https://esphome.io/) 사용)와 고급 오디오 처리를 위한 XMOS xCORE XU316 칩(마이크 정리 오프로딩을 위한 커스텀 펌웨어 탑재, 로컬 실행 알고리즘으로 잡음 억제, 음향 에코 제거, 간섭 제거, 자동 이득 제어 등)으로 통합될 예정입니다.

기능적으로는 [Home Assistant Voice Preview Edition(일명 Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 참조 설계(오픈소스 하드웨어로 Open Home Foundation과 Nabu Casa가 협력하여 공개)와 대부분 하드웨어 호환되도록 제작됩니다. 주된 차이점은 Google Nest Mini 인클로저 및 구성품에 의해 정의된 제약에 따른 것(즉, nest-mini-drop-in-pcb 프로젝트 하드웨어 설계는 Google의 원래 하드웨어와 동일한 유형의 물리적 용량 입력으로 제한됨)입니다.

따라서 이 프로젝트/저장소의 범위는 ESPHome 펌웨어의 새로운 기능/기능 개발이 아니므로, 해당 개발을 원한다면 Home Assistant Voice Preview Edition의 펌웨어 개발 및 상위 ESPHome 메인라인 코드로 문의해야 합니다:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 협업 요청

PCB 레이아웃 설계(특히 PCB 라우팅, 그라운드 포어링, 노이즈 민감 디지털+아날로그 레이아웃)에 경험이 있다면, **여러분의 도움이 매우 필요합니다**! 새로운 이슈를 등록하거나 제안/요청을 제출하고, 기존 이슈에 의견/피드백을 추가하거나 이 저장소를 포크해 주세요.

개념/아이디어에 대한 자세한 내용 및 토론 참여는 Home Assistant 커뮤니티 포럼 스레드를 확인해 주세요:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 현재 상태

- ✅ 회로도 완성
- ✅ 부품 배치 완료
- ✅ 라우팅 완료
- ✅ 그라운드 포어, 쉴딩 전략, EMI 고려 완료
- ⚠️ 1차 테스트 배치에서 두 가지 오류로 실패 - 수정됨
- 🕓 두 번째 테스트 배치를 기다리는 중

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 사용된 도구

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC를 이용한 풋프린트 소싱

## 알려진 하드웨어 사양

- 4-레이어 PCB
- ESP32-S3R8 베어 칩(ESP32-S3로 WiFi, BLE, 온보드 웨이크-워드 감지 지원)
- XMOS XU316-1024-QF60B-C24(XMOS XU316 xCORE DSP 오디오 처리)
- 듀얼 SPI 플래시(ESP32와 XMOS가 각각의 SPI 플래시 사용)
- 듀얼 I²S 버스(동시에 I2S 인터페이스 지원, 즉 오디오 출력 및 입력 동시 가능)
- TAS5805M(TAS5805MPWPR) 스피커 출력용(I2S 클래스-D 모노 오디오 앰프, I2C를 통한 DSP 구성)
- 2x MEMS 마이크(듀얼 MMICT390200012, 마이크 간 거리 68mm)
- 6x SK6812 RGB LED
- 커스텀 USB-C 및 14V 전원 입력(참고! USB-C와 배럴 커넥터는 동시에 연결 불가)

---

> ⚠️ USB-C를 통한 플래싱 시 메인 14V 전원 입력을 분리해야 합니다. 자세한 내용은 PCB의 실크스크린 참고.

## 참고 자료

### Home Assistant Voice Preview Edition 자료(PCB 설계 파일 포함)
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE용 ESPHome 펌웨어(동일 ESP32-S3 + XMOS XU316 조합 사용):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC 칩

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Edition 하드웨어용 ESPHome 프로젝트의 XMOS 펌웨어:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 라이선스

이 프로젝트는 [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]에 따라 라이선스가 부여됩니다.
이 하드웨어의 수정된 버전도 동일한 라이선스하에 배포되어야 합니다.

☕ 이 프로젝트를 후원하고 싶으시다면 [Ko-fi에서 커피 한 잔을 사주세요](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---