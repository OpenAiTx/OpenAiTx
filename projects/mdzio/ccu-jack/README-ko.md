# CCU-Jack

CCU-Jack은 [eQ-3](http://www.eq-3.de/)사의 [홈 자동화 시스템](http://de.wikipedia.org/wiki/Hausautomation) HomeMatic의 중앙 제어기(CCU)의 데이터 포인트에 대한 간단하고 안전한 **REST** 및 **MQTT** 기반 접근을 제공합니다. 이를 위해 많은 프로그래밍 언어에서 쉽게 사용할 수 있는 [Very Easy Automation Protocol](https://github.com/mdzio/veap)과 사물인터넷에서 널리 사용되는 [MQTT 프로토콜](https://de.wikipedia.org/wiki/MQTT)을 구현합니다. 또한, 언급된 프로토콜을 통해 외부 장치들도 CCU에 연결할 수 있습니다.

CCU-Jack이 추구하는 목표는 다음과 같습니다:

**CCU-Jack은 다른 애플리케이션들이 CCU의 데이터 포인트에 쉽게 접근할 수 있도록 해야 합니다.** 예를 들어 HM-, HM-Wired-, HM-IP 장치가 혼재된 CCU에 접근하기 위해 총 9개의 네트워크 연결이 필요하며, 일부는 역방향 채널이고 서로 다른 프로토콜을 사용합니다. 또한 CCU의 네트워크 인터페이스는 암호화되어 있지 않아 CCU 방화벽에서 열리지 않아야 합니다. CCU-Jack은 모든 장치와 시스템 변수를 단일 프로토콜과 암호화된 연결로 표준화하여 접근합니다.

**또한 외부 장치(예: WLAN 콘센트)를 CCU에 가능한 한 쉽게 연결하고 자동화할 수 있어야 합니다.** 연결된 외부 장치는 CCU에서 원래 HM 장치처럼 표시됩니다. CCU의 웹 UI를 통해 동일하게 제어 및 모니터링할 수 있으며, CCU 프로그램에서도 제한 없이 사용할 수 있습니다.

**여러 CCU와 MQTT 서버를 가진 다른 자동화 장치들은 CCU-Jack을 통해 상호 연결되어 값 변경을 교환할 수 있습니다.** 이를 위해 CCU-Jack은 MQTT 브리지를 제공합니다. CCU는 클라우드의 MQTT 서버와도 연결할 수 있습니다.

기능적으로 CCU-Jack은 [XML-API Add-On](https://github.com/jens-maus/XML-API)의 대안입니다. XML-API Add-On은 오랜 기간 개발이 중단되었고 수정되지 않은 버그와 보안 취약점을 포함하고 있습니다. 또한 CCU-Jack은 두 Add-On인 [hm2mqtt](https://github.com/owagner/hm2mqtt)와 [Mosquitto](https://github.com/hobbyquaker/ccu-addon-mosquitto)의 조합을 대체할 수 있습니다. hm2mqtt Add-On 역시 오랜 기간 개발이 중단되었습니다.

외부 장치 연결과 관련하여 CCU-Jack은 복잡하고 번거로운 여러 솔루션을 대체하며 동시에 더 많은 기능을 제공합니다.

# 사용자 매뉴얼

사용자(예: 설치, 설정)를 위한 모든 정보는 [**사용자 매뉴얼**](https://github.com/mdzio/ccu-jack/wiki)에서 확인할 수 있습니다. 설치 전에 반드시 읽어야 합니다!

# 다운로드

CCU-Jack의 공식 배포 버전은 오른쪽의 [Releases](https://github.com/mdzio/ccu-jack/releases)에서 찾을 수 있습니다.

최근 개발 상태에 해당하는 사전 버전은 [Actions](https://github.com/mdzio/ccu-jack/actions)에서 확인할 수 있습니다. 워크플로우를 선택하면 모든 플랫폼용 다운로드가 _Artifacts_ 아래에 있습니다. 이 버전들은 새로운 기능이나 버그 수정이 조기에 포함되어 있으나, 테스트되지 않았습니다!

# CCU-Jack 주변 환경

CCU-Jack과 관련하여 다른 프로젝트가 개발되었습니다:
* [CCU-Jack to HomeAssistant](https://github.com/kaistraube/ccujack_homeassistant) (CCU-Jack을 통한 HomeMatic CCU와 HomeAssistant 연결)
* [node-red-contrib-ccu-jack](https://github.com/ptweety/node-red-contrib-ccu-jack) (CCU-Jack을 통한 HomeMatic CCU와 Node-RED 연결)
* [ngx-ccu-jack-client](https://github.com/pottio/ngx-ccu-jack-client) (Angular 애플리케이션 내 CCU-Jack 통합)

# 개발

## 소스에서 빌드하기

CCU-Jack은 [Go 프로그래밍 언어](https://golang.org/)로 작성되었습니다. 모든 CCU-Jack 배포판은 다양한 플랫폼(Windows, Linux, MacOS 등)에서 매우 쉽고 빠르게 빌드할 수 있습니다. 원하는 디렉토리에서 Git 저장소를 클론하거나 소스를 복사한 후, 해당 디렉토리에서 명령줄을 열고 다음 명령어를 입력하세요:
```
cd build
go run .
```
주 디렉토리에서는 모든 배포판이 빌드됩니다.

개발을 위해서는 개발 환경으로 [Visual Studio Code](https://code.visualstudio.com/)를 사용하는 것이 좋습니다. 주 디렉토리를 열기만 하면 됩니다. 필요한 확장 기능이 자동으로 설치 제안됩니다.

## 참여

참여자는 언제나 환영합니다. 문서 작성, 테스트, [HomeMatic 포럼](https://homematic-forum.de/forum/viewtopic.php?f=41&t=53553)에서의 지원, 버그 수정 또는 새로운 기능 구현 등 어떤 분야든 가능합니다. 코드 기여 시 라이선스(GPL v3)를 준수해야 합니다. 코드 기여는 항상 `master` 브랜치와 별도로 새 브랜치에서 개발되어야 합니다.

## 저자

* [Mathias Dz.](https://github.com/mdzio)
* [martgras](https://github.com/martgras) (라즈베리 파이 4, 인증서 처리)
* [twendt](https://github.com/twendt) (CUxD용 BIN-RPC)
* [Theta Gamma](https://github.com/ThetaGamma) (도커 이미지)

## 라이선스 및 책임 제한

라이선스 및 책임 제한은 [LICENSE.txt](https://raw.githubusercontent.com/mdzio/ccu-jack/master/LICENSE.txt) 파일에서 확인할 수 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---