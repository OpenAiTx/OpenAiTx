
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

**알림!** "MiciMike Home Mini Drop-In PCB" (1세대 Google Home Mini)용 크라우드펀딩 캠페인이 현재 Crowd Supply에서 사전판매 단계(프로젝트 미리보기 전용)로 진행 중이며, 성공할 경우 최신 Nest Mini(2세대)용 일치하는 캠페인도 계획하고 있으니 아래 링크를 확인하고 가능하다면 후원으로 간접적으로 이 프로젝트를 지원해 주세요:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

이 두 프로젝트 모두 완전 오픈소스 하드웨어 프로젝트로, [Onju Voice](https://github.com/justLV/onju-voice)의 컨셉에서 영감을 받았지만 [Open Home Foundation의 오픈 보이스 어시스턴트 표준과 Home Assistant Voice Preview Edition을 참고](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)하여 PCB 설계 및 사양을 따르려고 합니다.

# 프로젝트 범위

이 프로젝트와 저장소의 목표(이는 [Onju Voice](https://github.com/justLV/onju-voice)와 유사하지만 완전 오픈소스 하드웨어 라이선스 하에 진행됨)는 누구나 제작/조립하거나 일체형 PCB 제조업체에서 주문할 수 있는 Google Nest Mini(2세대)용 맞춤형 Drop-In 교체 PCB(인쇄회로기판)와 하드웨어 회로도를 설계하는 것입니다.

이는 주로 [Home Assistant의 음성 제어](https://www.home-assistant.io/voice_control/) 및/또는 [Music Assistant](https://www.music-assistant.io)의 미디어 플레이어 스피커 출력용으로 기존 Google Nest Mini 스마트 스피커를 오픈소스 하드웨어로 변환/재활용하려는 사용자들을 대상으로 합니다. (하드웨어는 인기 있는 Espressif ESP32 플랫폼 기반이므로 다른 펌웨어와 함께 다양한 애플리케이션에도 사용할 수 있습니다).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

하드웨어 설계는 ([Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)과 유사하게) WiFi, BLE, [온보드 웨이크 워드 감지](https://www.home-assistant.io/voice_control/about_wake_word/)용 ESP32-S3 SoC(코드 없이 [ESPHome 펌웨어](https://esphome.io/) 사용)와 고급 오디오 처리를 위한 XMOS xCORE XU316 칩(마이크 청소 오프로드를 위한 맞춤형 펌웨어, 로컬 알고리즘을 사용한 노이즈 억제, 음향 에코 제거, 간섭 제거, 자동 게인 제어 등)을 통합할 예정입니다.

기능적으로는 [Home Assistant Voice Preview Edition(또는 Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 참조 설계(이 설계는 Open Home Foundation과 Nabu Casa의 협업으로 공개된 오픈소스 하드웨어 설계)와 거의 하드웨어 호환되도록 제작됩니다. 주요 차이점은 Google Nest Mini 케이스 및 부품이 정의한 제약 때문이며, 즉 nest-mini-drop-in-pcb 프로젝트 하드웨어 설계는 Google의 기존 하드웨어와 동일한 물리적 입력 용량의 제한을 받습니다.

따라서 이 프로젝트/저장소의 범위는 ESPHome 펌웨어의 새로운 기능/기능 개발이 아니므로, 해당 기능 개발을 원한다면 Home Assistant Voice Preview Edition의 펌웨어 개발과 상위 ESPHome 메인라인 코드로 이동해야 합니다:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 협업 요청

PCB 레이아웃 설계 경험이 있으시다면(특히 PCB 라우팅, 그라운드 포어링, 또는 노이즈 민감한 디지털+아날로그 레이아웃), **여러분의 도움이 매우 필요합니다**! 새로운 이슈를 열거나 제안/요청을 제출하고 기존 이슈에 의견/피드백을 자유롭게 추가하거나 저장소를 포크해 주세요.

컨셉/아이디어에 대한 자세한 정보는 관련 토론을 확인하고 아래 Home Assistant 커뮤니티 포럼 스레드에 참여해 주세요:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 현재 상태

- ✅ 회로도 완성
- ✅ 부품 배치 완료
- ✅ 라우팅 완료
- ✅ 그라운드 포어, 실드 전략, EMI 고려 완료
- ⛔ 1차 테스트 배치에서 두 가지 오류로 실패 - 수정됨
- ⚠️ 두 번째 테스트 배치는 부분적으로 작동함
- ✅ 다음 배치에 XTAG4 디버그 옵션 추가됨

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## 사용된 도구

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC에서 풋프린트 소싱

## 알려진 하드웨어 사양

- 4층 PCB
- ESP32-S3R8 베어 칩 (WiFi, BLE, 온보드 웨이크 워드 감지를 위한 ESP32-S3)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP 오디오 처리)
- 16 MB SPI 플래시 (ESP32-S3용)
- 4 MB SPI 플래시 (XMOS XU316용)
- 듀얼 I²S 버스 (동시 오디오 입력 및 출력)
- TAS5805M (TAS5805MPWPR) 스테레오 클래스-D 앰프 및 통합 DSP (I2S 오디오, I2C 제어), 모노 BTL 스피커 출력으로 구성
- 3x MEMS 마이크(MMICT390200012) 34mm 반지름 호에 배치 - 현재 펌웨어는 2개 마이크 사용, 3마이크 어레이 하드웨어 지원 이미 탑재
- 6x SK6812 RGB LED
- 커스텀 USB-C 및 14V 전원 입력 (참고! USB-C와 배럴 커넥터는 동시에 연결 불가)
- MPR121 정전식 터치 컨트롤러 (ESP32-S3의 기본 터치 감지 대신 터치 입력에 사용)

---

> ⚠️ USB-C를 통한 플래싱 시 메인 14V 전원 입력을 분리해야 합니다. 자세한 내용은 PCB 실크스크린 주석을 참조하세요.

## 참고 자료

### Home Assistant Voice Preview Edition 리소스(PCB 설계 파일 포함)
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE용 ESPHome 펌웨어(동일한 ESP32-S3 + XMOS XU316 조합 사용):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) MCU IC 칩

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

이 프로젝트는 [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]에 따라 라이선스가 부여되어 있습니다.
이 하드웨어의 수정된 버전도 동일한 라이선스 하에 배포되어야 합니다.

☕ 이 프로젝트를 지원하고 싶으시면 [Ko-fi에서 커피 한 잔을 사주세요](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---