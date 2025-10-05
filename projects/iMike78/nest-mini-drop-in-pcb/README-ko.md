# MiciMike 구글 Nest Mini 교체용 드롭인 PCB

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb)는 ["Google Nest Mini"(구글의 2세대 스마트 스피커, 배럴 커넥터 충전 포트 사용)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))용 드롭인 PCB 교체품이며, 오픈 소스 펌웨어 구동을 위해 ESP32와 XMOS 마이크로컨트롤러를 기반으로 합니다.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

팁! 만약 "Google Home Mini"(구글의 1세대 스마트 스피커 하드웨어, 마이크로 USB 충전 포트 사용)용 유사한 드롭인 PCB 교체품을 찾고 있다면, 자매 프로젝트 https://github.com/iMike78/home-mini-v1-drop-in-pcb를 확인해 보세요.

이 두 프로젝트 모두 완전한 오픈 소스 하드웨어 프로젝트로, [Onju Voice](https://github.com/justLV/onju-voice)에서 일부 개념을 차용했으나 [Open Home Foundation의 오픈 보이스 어시스턴트 표준과 Home Assistant Voice Preview Edition을 참고](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)하여 PCB 설계와 사양을 따르는 것을 목표로 합니다.

# 프로젝트 범위

이 프로젝트와 저장소의 목표는 (Onju Voice와 유사하지만 완전한 오픈 소스 하드웨어 라이선스 하에) 구글 Nest Mini (2세대)용 맞춤 드롭인 교체 PCB를 누구나 제작/주문할 수 있도록 하드웨어 회로도와 함께 설계하는 것입니다.

주로 기존 구글 Nest Mini 스마트 스피커를 [Home Assistant 음성 제어](https://www.home-assistant.io/voice_control/)와/또는 [Music Assistant](https://www.music-assistant.io) 미디어 플레이어 스피커 출력용 오픈 소스 하드웨어로 전환/재활용하려는 사람들을 대상으로 합니다. (이 하드웨어는 인기 있는 Espressif ESP32 플랫폼 기반이므로 다른 펌웨어를 사용하여 다른 용도로도 사용 가능할 수 있습니다.)

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

하드웨어 설계는 ([Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)과 유사하게) WiFi, BLE, 그리고 [내장 웨이크 워드 감지](https://www.home-assistant.io/voice_control/about_wake_word/)를 위한 ESP32-S3 SoC (무코드 [ESPHome 펌웨어](https://esphome.io/) 사용)와 고급 오디오 처리를 위한 XMOS xCORE XU316 칩 (노이즈 억제, 음향 에코 제거, 간섭 제거, 자동 이득 제어를 위한 로컬 알고리즘으로 마이크 클린업 오프로딩을 수행하는 맞춤 펌웨어 포함)을 통합합니다.

기능적으로는 주로 [Home Assistant Voice Preview Edition (Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) 참조 설계와 하드웨어 호환성을 목표로 합니다(해당 설계는 Open Home Foundation과 Nabu Casa의 협업으로 오픈 소스 하드웨어 디자인으로 출시됨). 주요 차이점은 구글 Nest Mini 외함과 부품의 제약에 따르며, 즉 nest-mini-drop-in-pcb 프로젝트 하드웨어 설계는 구글 원래 하드웨어와 동일한 물리적 제약 내에서 설계됩니다.

따라서 이 프로젝트/저장소의 범위는 ESPHome 펌웨어의 새로운 기능/기능 개발이 아니며, 이를 원한다면 Home Assistant Voice Preview Edition 펌웨어 개발과 ESPHome 주류 코드로 이동해야 합니다:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## 협업 요청

PCB 레이아웃 설계 경험, 특히 PCB 라우팅, 그라운드 포어링, 노이즈에 민감한 디지털+아날로그 레이아웃 경험이 있다면, **여러분의 도움이 절실히 필요합니다**! 새 이슈를 열거나 제안/요청을 제출하고, 기존 이슈에 의견/피드백을 추가하거나 이 저장소를 포크해 주세요.

컨셉/아이디어에 대한 자세한 정보와 관련 토론에 참여하려면 이 Home Assistant 커뮤니티 포럼 쓰레드를 참조하세요:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### 현재 상태

- ✅ 회로도 완료  
- ✅ 부품 배치 완료
- ✅ 라우팅 완료  
- ✅ 그라운드 레이어, 쉴딩 전략 및 EMI 고려 완료  
- ⚠️ 1차 테스트 배치에서 두 가지 오류 발생 - 수정 완료  
- 🕓 2차 테스트 배치 대기 중  

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">  

## 사용 도구  

- 🛠️ KiCad 9  
- 🧰 SnapEDA / LCSC에서 풋프린트 소싱  

## 알려진 하드웨어 사양  

- 4층 PCB  
- ESP32-S3R8 벌크 칩 (ESP32-S3로 WiFi, BLE 및 온보드 웨이크워드 감지 지원)  
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP 오디오 처리)  
- 듀얼 SPI 플래시  
- 듀얼 I²S 버스 (동시 오디오 출력 및 입력을 위한 I2S 인터페이스 지원)  
- MAX98357 스피커 출력용 (I2S Class-D 모노 오디오 앰프)  
- 2x MEMS 마이크로폰 (MSM261DHP)  
- SK6812 LED  
- 맞춤형 USB-C 및 14V 전원 입력  

---  

> ⚠️ USB-C를 통한 플래싱 시 메인 14V 전원 입력을 분리해야 합니다. 자세한 내용은 PCB 실크스크린 주석을 참고하세요.  

## 참고 자료  

### Home Assistant Voice Preview Edition 리소스 및 PCB 설계 파일  
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/  
  - https://voice-pe.home-assistant.io/resources/  
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files  
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

이 프로젝트는 [CERN 오픈 하드웨어 라이선스 버전 2 - 강력한 상호호환성 (CERN-OHL-S v2)] 하에 라이선스가 부여되었습니다.
이 하드웨어의 수정된 버전도 동일한 라이선스 하에 배포되어야 합니다.

☕ 이 프로젝트를 지원하고 싶으시다면, [Ko-fi에서 커피 한 잔 사주기](https://ko-fi.com/imike78)를 이용해 주세요!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---