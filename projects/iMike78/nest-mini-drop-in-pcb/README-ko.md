
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

# Google Nest Mini용 MiciMike 드롭인 PCB 교체

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb)는 ["Google Nest Mini"(배럴 커넥터 충전 포트가 있는 구글의 2세대 스마트 스피커)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))용 드롭인 PCB 교체품으로, 오픈소스 펌웨어를 실행하기 위해 ESP32 및 XMOS 마이크로컨트롤러 기반으로 제작되었습니다.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

팁! 만약 "Google Home Mini"(마이크로-USB 충전 포트가 있는 구글 1세대 스마트 스피커 하드웨어)용 유사한 드롭인 PCB 교체품을 찾고 있다면, 자매 프로젝트 https://github.com/iMike78/home-mini-v1-drop-in-pcb 를 확인해 보세요.

이 두 프로젝트 모두 완전히 오픈소스 하드웨어 프로젝트로, [Onju Voice](https://github.com/justLV/onju-voice)에서 일부 개념적 영감을 받았지만, PCB 설계 및 사양을 위해 [Open Home Foundation의 오픈 보이스 어시스턴트 표준 및 Home Assistant Voice Preview Edition을 참조](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)하는 것을 목표로 하고 있습니다.

# 프로젝트 범위

이 프로젝트 및 저장소의 목표([Onju Voice](https://github.com/justLV/onju-voice)와 유사하지만 완전히 오픈소스 하드웨어 라이선스 하에)는 누구나 직접 제작/조립하거나 원스톱 PCB 제조업체에서 주문할 수 있는 Google Nest Mini(2세대) 맞춤형 드롭인 교체용 PCB(인쇄회로기판)와 하드웨어 회로도를 설계하는 것입니다.

이 프로젝트는 주로 [Home Assistant의 음성 제어](https://www.home-assistant.io/voice_control/) 및/또는 [Music Assistant](https://www.music-assistant.io)를 위한 미디어 플레이어 스피커 출력(하드웨어는 인기 있는 Espressif ESP32 플랫폼 기반이므로 다른 펌웨어와 함께 다른 애플리케이션에서도 사용 가능)에 맞춰 구글 Nest Mini 스마트 스피커를 오픈소스 하드웨어로 전환/재활용하려는 사용자를 대상으로 합니다.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

하드웨어 설계는 [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)과 유사하게 WiFi, BLE, [온보드 웨이크워드 감지](https://www.home-assistant.io/voice_control/about_wake_word/)(노코드 [ESPHome 펌웨어](https://esphome.io/) 사용)를 위한 ESP32-S3 SoC + 고급 오디오 처리를 위한 XMOS xCORE XU316 칩(마이크 노이즈 클린업을 위한 맞춤형 펌웨어로, 노이즈 억제, 음향 에코 제거, 간섭 제거, 자동 이득 제어 등 로컬 알고리즘을 사용하여 음성 인식 성능 개선)을 통합할 예정입니다.

기능적으로는 [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 참조 디자인(이 디자인은 Open Home Foundation과 Nabu Casa 협력으로 오픈소스 하드웨어로 공개됨)과 대부분 하드웨어 호환성을 가지도록 제작됩니다. 주요 차이점은 Google Nest Mini의 케이스 및 부품에 의해 정의된 제약 때문이며, 즉 nest-mini-drop-in-pcb 프로젝트의 하드웨어 설계는 Google의 기존 하드웨어와 동일한 물리적 입력 용량에 제한됩니다.

따라서 이 프로젝트/저장소의 범위는 ESPHome 펌웨어의 새로운 기능/기능 개발이 아니므로, 해당 기능 개발을 원한다면 Home Assistant Voice Preview Edition의 펌웨어 개발과 상류 ESPHome 메인라인 코드에 기여해야 합니다:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 협업 요청

PCB 레이아웃 설계(특히 PCB 라우팅, 그라운드 포어링, 노이즈 민감한 디지털+아날로그 레이아웃) 경험이 있으시다면, **여러분의 도움이 매우 필요합니다**! 새로운 이슈를 열거나, 제안/요청을 제출하고, 기존 이슈에 의견/피드백을 추가하거나, 이 저장소를 포크하셔도 좋습니다.

해당 개념/아이디어에 대한 자세한 정보와 관련 토론에 참여하려면 Home Assistant 커뮤니티 포럼 쓰레드도 참고하세요:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 현재 상태

- ✅ 회로도 완성
- ✅ 부품 배치 완료
- ✅ 라우팅 완료
- ✅ 그라운드 포어, 쉴딩 전략, EMI 고려 완료
- ⚠️ 1차 테스트 배치에서 오류 두 개 발생 – 수정됨
- 🕓 2차 테스트 배치 대기 중

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## 사용된 도구

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC에서 풋프린트 소싱

## 알려진 하드웨어 사양

- 4층 PCB
- ESP32-S3R8 베어 칩 (WiFi, BLE, 온보드 웨이크워드 감지를 위한 ESP32-S3)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP 오디오 처리)
- 듀얼 SPI 플래시
- 듀얼 I²S 버스 (동시에 I2S 인터페이스 사용 가능, 즉 오디오 출력과 입력을 동시에 지원)
- MAX98357 스피커 출력용 (I2S 클래스-D 모노 오디오 앰프)
- 2x MEMS 마이크로폰 (MSM261DHP)
- SK6812 LED
- 커스텀 USB-C 및 14V 전원 입력

---

> ⚠️ USB-C를 통한 플래싱은 메인 14V 전원 입력을 분리해야 합니다. 자세한 내용은 PCB의 실크스크린 노트를 참조하세요.

## 참고 자료

### Home Assistant Voice Preview Edition 리소스 및 PCB 설계 파일
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/ko/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE용 ESPHome 펌웨어 (동일한 ESP32-S3 + XMOS XU316 조합 사용):

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
이 하드웨어의 수정된 버전도 동일한 라이선스 하에 배포되어야 합니다.

☕ 이 프로젝트를 후원하고 싶다면 [Ko-fi에서 커피 한 잔 사주세요](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---