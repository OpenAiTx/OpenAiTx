
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
이 두 프로젝트 모두 완전한 오픈소스 하드웨어 프로젝트로, [Onju Voice](https://github.com/justLV/onju-voice)에서 개념적 영감을 얻었으나 [Open Home Foundation의 오픈 보이스 어시스턴트 표준 및 Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)을 참조하여 PCB 설계와 사양을 따르는 것을 목표로 합니다.

# 프로젝트 범위

이 프로젝트와 저장소의 목표는 (이는 [Onju Voice](https://github.com/justLV/onju-voice)와 유사하지만 완전히 오픈소스 하드웨어 라이선스 하에 진행됩니다) 누구나 직접 제작하거나 원스톱 PCB 제조사에 주문할 수 있도록 Google Nest Mini (2세대)용 커스텀 교체용 PCB(인쇄회로기판)와 하드웨어 회로도를 설계하는 것입니다.

이 프로젝트는 주로 구글 Nest Mini 스마트 스피커를 [Home Assistant의 음성 제어](https://www.home-assistant.io/voice_control/) 및/또는 [Music Assistant](https://www.music-assistant.io) 미디어 플레이어 스피커 출력용 오픈소스 하드웨어로 변환/재활용하고자 하는 사람들을 대상으로 합니다. (단, 하드웨어는 인기 있는 Espressif ESP32 플랫폼 기반이므로 다른 펌웨어와 함께 다양한 용도로도 사용할 수 있습니다).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

하드웨어 설계는 ([Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)과 유사하게) WiFi, BLE, [온보드 웨이크워드 감지](https://www.home-assistant.io/voice_control/about_wake_word/)를 위한 ESP32-S3 SoC(코드 없는 [ESPHome 펌웨어](https://esphome.io/) 사용) + 고급 오디오 처리를 위한 XMOS xCORE XU316 칩(마이크 클린업 오프로드를 위한 커스텀 펌웨어로, 노이즈 억제, 음향 에코 캔슬링, 간섭 억제, 자동 게인 제어 등 로컬 알고리즘 기반 음성 인식 능력 향상)을 통합합니다.

기능적으로는 [Home Assistant Voice Preview Edition(일명 Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 레퍼런스 디자인(오픈 홈 재단과 Nabu Casa가 협력하여 오픈소스 하드웨어로 공개한 것)과 대부분 하드웨어 호환이 되도록 설계되었습니다. 주요 차이점은 Google Nest Mini 케이스와 부품이 정의하는 제한 때문입니다. 즉, nest-mini-drop-in-pcb 프로젝트의 하드웨어 설계는 Google의 원래 하드웨어와 동일한 유형의 물리적 용량 입력으로 제한됩니다.

따라서 이 프로젝트/저장소의 범위는 ESPHome 펌웨어의 새로운 기능/기능을 개발하는 것이 아니며, 그 부분을 원한다면 Home Assistant Voice Preview Edition의 펌웨어 개발 및 ESPHome 메인라인 코드 개발로 전환해야 합니다:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 협업 요청

PCB 레이아웃 설계(특히 PCB 라우팅, 그라운드 포어링, 노이즈에 민감한 디지털+아날로그 레이아웃)에 경험이 있으시다면, **여러분의 도움이 매우 필요합니다!** 새로운 이슈를 열거나, 제안/요청을 제출하고, 기존 이슈에 의견/피드백을 추가하거나, 저장소를 포크해 주시기 바랍니다.

개념/아이디어에 대한 자세한 정보 및 관련 토론에 기여하고 싶으시면 Home Assistant 커뮤니티 포럼의 해당 스레드를 참고하세요:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 현재 상태

- ✅ 회로도 완성
- ✅ 부품 배치 완료
- ✅ 라우팅 완료
- ✅ 그라운드 포어, 실딩 전략, EMI 고려사항 완료
- ⚠️ 1차 테스트 배치에서 두 가지 오류 발견 - 수정 완료
- 🕓 2차 테스트 배치 대기 중

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## 사용된 도구

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC 풋프린트 소싱용

## 알려진 하드웨어 사양

- 4-레이어 PCB
- ESP32-S3R8 베어 칩 (ESP32-S3: WiFi, BLE 및 온보드 웨이크워드 감지용)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP 오디오 프로세싱)
- 듀얼 SPI 플래시 (ESP32와 XMOS 각각 자체 SPI 플래시 사용)
- 듀얼 I²S 버스 (동시에 I2S 인터페이스 허용, 즉 오디오 출력 및 입력 동시 지원)
- MAX98357 스피커 출력용 (I2S 클래스-D 모노 오디오 증폭기)
- 2x MEMS 마이크 (듀얼 MMICT390200012, 마이크 간격 68mm)
- 6x SK6812 RGB LED
- 커스텀 USB-C 및 14V 전원 입력 (참고! USB-C와 배럴 커넥터는 동시에 연결 불가)

---

> ⚠️ USB-C를 통한 플래싱은 메인 14V 전원 입력을 분리해야 합니다. 세부 사항은 PCB 실크스크린 노트를 참조하세요.

## 참고 자료

### Home Assistant Voice Preview Edition 리소스 및 PCB 설계 파일
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE용 ESPHome 펌웨어 (동일 ESP32-S3 + XMOS XU316 조합 사용):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC 칩

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Edition 하드웨어를 위한 ESPHome 프로젝트의 XMOS 펌웨어:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## 라이선스

이 프로젝트는 [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]에 따라 라이선스가 부여되었습니다.
이 하드웨어의 수정된 버전도 동일한 라이선스 하에 배포되어야 합니다.

☕ 이 프로젝트를 후원하고 싶다면 [Ko-fi에서 커피 한잔 사주세요](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---