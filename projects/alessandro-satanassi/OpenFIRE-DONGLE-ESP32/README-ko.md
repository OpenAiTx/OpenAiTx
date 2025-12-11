## EPS32용 OpenFIRE-DONGLE


![foto_dongle](https://github.com/user-attachments/assets/a38d7390-f7e7-42d7-844c-ad8388670f6d)



https://github.com/user-attachments/assets/70a193a0-686e-4da3-8d30-f0067de6b63c



이 저장소는 ESP32S3 마이크로컨트롤러에서 작동하도록 조정된 TeamOpenFIRE의 원본 'OpenFIRE-firmware' 프로젝트의 포팅인 OpenFIRE-Firmware-ESP32 프로젝트 코드와 함께 사용하기 위해 생성되었습니다.
이 프로젝트는 PlatformIO를 사용하여 개발되었으며, PC에 연결된 동글로 사용되는 ESP32S3용 펌웨어를 나타내며 ESP32의 ESP-NOW 프로토콜을 통해 무선 연결을 활성화합니다. 이 동글은 라이트건에 설치되는 'OpenFIRE-Firmware-ESP32' 펌웨어와 함께 사용하도록 설계되었습니다.
코드는 라이트건을 자동으로 감지하고 독립적으로 구성되도록 구조화되어 있습니다.
라이트건과 동글 간의 통신은 양방향이며, 라이트건을 PC에 USB로 직접 연결한 것처럼 사용할 수 있습니다.
PC는 USB 직접 연결과 동글을 통한 무선 연결 간의 차이를 전혀 인식하지 못합니다.
'OpenFIRE' 프로젝트를 만든 TeamOpenFIRE에 진심으로 감사드리며 모든 공로와 깊은 감사를 전합니다.
코드의 일부는 "SerialTransfer" 저장소(https://github.com/PowerBroker2/SerialTransfer.git)에서 가져와 수정한 것입니다.
따라서 이 코드의 작성자인 PowerBroker2에게도 감사의 뜻을 전합니다.


이 저장소는 TeamOpenFIRE의 원본 'OpenFIRE-firmware' 프로젝트를 ESP32S3 마이크로컨트롤러에서 작동하도록 조정한 OpenFIRE-Firmware-ESP32 프로젝트 코드와 함께 사용하기 위해 생성되었습니다.
이 프로젝트는 PlatformIO를 사용하여 개발되었으며, PC에 연결된 동글로 사용되는 ESP32S3용 펌웨어 역할을 하며 ESP32의 ESP-NOW 프로토콜을 통한 무선 연결을 가능하게 합니다. 이 동글은 라이트건에 설치되는 'OpenFIRE-Firmware-ESP32' 펌웨어와 함께 사용하도록 설계되었습니다.
코드는 라이트건을 자동으로 감지하고 스스로 구성되도록 설계되어 있습니다.
라이트건과 동글 간의 통신은 양방향으로 이루어져, 라이트건이 마치 USB로 PC에 직접 연결된 것처럼 작동할 수 있습니다.
PC는 USB 직접 연결과 동글을 통한 무선 연결 간의 차이를 전혀 인식하지 못합니다.
'OpenFIRE' 프로젝트를 만든 TeamOpenFIRE에 진심으로 감사드리며 모든 공로와 깊은 감사를 전합니다.
코드의 일부는 "SerialTransfer" 저장소(https://github.com/PowerBroker2/SerialTransfer.git)에서 가져와 수정한 것입니다.
따라서 이 코드의 작성자인 PowerBroker2에게도 감사의 뜻을 전합니다.


## ... TeamOpenFIRE의 원본 'OpenFIRE-firmware' 프로젝트 페이지 계속
## ... TeamOpenFIRE의 원본 'OpenFIRE-firmware' 프로젝트 페이지 계속

### 우리의 작업이 마음에 드시나요? [개발자들을 지원하는 것을 잊지 마세요!](https://github.com/TeamOpenFIRE/.github/blob/main/profile/README.md)

![BannerDark](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerLoD.png#gh-dark-mode-only)![BannerLight](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-DONGLE-ESP32/main/docs/of_bannerDoL.png#gh-light-mode-only)
# OpenFIRE - 오픈 *포 인파-레드 발광기* 라이트 건 시스템
###### [IR-GUN4ALL](http://github.com/SeongGino/ir-light-gun-plus)의 후속 프로젝트이며, 이는 [Prow Enhanced fork](https://github.com/Prow7/ir-light-gun)를 기반으로 하고, 다시 4IR Beta "Big Code Update" [SAMCO 프로젝트](https://github.com/samuelballantyne/IR-Light-Gun)를 기반으로 합니다.

## 특징:
- **완전한 기능의 주변기기**, 솔레노이드 및 럼블 포스 피드백부터 TMP36 온도 모니터링 등 앞으로 추가될 기능들 포함.
- **다중 IR 레이아웃 지원**, 실시간 원근 조정 추적을 지원하며 더블 라이트바(권장!)와 Xwiigun 스타일 다이아몬드 레이아웃(다른 시스템과 호환) 모두 가능.
- **유연한 입력 시스템**, 키보드, 5버튼 ABS(절대 위치 지정) 마우스, D-패드 지원 듀얼 스틱 게임패드 출력 가능하며, **견고한 버튼 매핑 시스템**으로 필요에 맞게 조정 가능!
- **간편 설치**를 위해 *.UF2* 바이너리를 RP2040 기반 마이크로컨트롤러에 드래그 앤 드롭 가능.
- **휴대 가능한 내장 설정**으로 교정 프로필, 토글, 설정, USB 식별자 등을 저장.
- **[OpenFIRE 앱](https://github.com/TeamOpenFIRE/OpenFIRE-App)**과 통합되어 사용자 친화적이고 크로스 플랫폼 즉석 구성 가능.
- **RP2040에 최적화**, 두 번째 코어를 입력 폴링 및 큐잉과 직렬 처리에 사용하고, 메인 코어는 가능한 경우 카메라 및 주변기기 처리에 사용.
- [Mame Hooker](https://dragonking.arcadecontrols.com/static.php?page=aboutmamehooker), [The Hook Of The Reaper](https://github.com/6Bolt/Hook-Of-The-Reaper), [QMamehook](https://github.com/SeongGino/QMamehook) 등 PC 포스 피드백 핸들러와 호환.
- *SSD1306 I2C 디스플레이*용 통합 OLED 출력 지원, 메뉴 탐색 및 생명력과 현재 탄약 수 등 게임 요소 시각 피드백 제공.
- MiSTer FPGA 생태계와 호환되며, 사용자 경험을 최대한 간소화하기 위한 전용 매핑 포함.
- 라이트건 커뮤니티를 위해 영원히 무료 및 오픈 소스!

___
## 감사:
* Samuel Ballantyne, 원래 SAMCO 프로젝트, 멋진 OpenFIRE 브랜딩과 원근 기반 추적 시스템에 감사.
* Prow7, 일시 정지 모드 및 저장 서브시스템의 기초를 제공한 향상된 SAMCO 포크에 감사.
* Odwalla-J, mrkylegp, RG2020 & lemmingDev, 사전 릴리스 상담, 버그 테스트 및 피드백에 감사.
* IR-GUN4ALL 테스터들, 초기 피드백과 기능 요청에 감사 - 여러분 없이는 불가능했을 것임!
* Chris Young, TinyUSB 호환 라이브러리(현재 `TinyUSB_Devices`의 일부)에 감사.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---