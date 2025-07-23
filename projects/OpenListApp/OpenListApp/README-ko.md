
# OpenList 앱
### AList, OpenList 크로스 플랫폼 클라이언트로, 현재 내장된 OpenList 서버를 사용하여 별도의 서버 연결이 필요 없으며, iOS, macOS, Windows, Android, Linux를 지원합니다.

### 내장된 [DDNS-GO(MIT)](https://github.com/jeessy2/ddns-go)를 통해, 기기가 **공인 IP를 가지고 있을 경우** DDNS-GO를 이용해 원격 접속이 가능하며, 휴대폰을 원격 서버로 사용할 수 있습니다.

### 내장된 [GATEWAY-GO(MIT)](https://github.com/OpenIoTHub/gateway-go)를 통해, 기기가 **공인 IP가 없을 경우** GATEWAY-GO를 이용해 원격 접속이 가능하며, 휴대폰을 원격 서버로 사용할 수 있습니다.

### CI를 통해 빌드되며, 본 프로젝트는 API 서버를 제공하지 않고, 서버는 상위 OpenList 등 커뮤니티에서 제공합니다.
### 프로젝트는 두 가지 UI를 제공하며, 하나는 기존 웹 인터페이스를 직접 로드하는 방식이고, 다른 하나는 현재 핵심 기능이 완성된 네이티브 인터페이스입니다. 기본적으로 Linux는 네이티브 인터페이스를 사용하고 나머지는 웹 인터페이스를 사용합니다.

### 본 프로젝트는 프론트엔드 프로젝트로 AList 프론트엔드 프로젝트를 참고하여 느슨한 [MIT](LICENSE) 코드 라이선스로 배포하며, 패키지명 변경 후 앱 마켓(특히 iOS)에 배포하는 것을 환영합니다. 반드시 본 프로젝트를 기반으로 개발되었음을 명시해야 합니다(본 프로젝트 주소 포함).

#### 프로젝트 컴파일 관련:
* 컴파일을 위해 [OpenListLib](https://github.com/OpenListApp/OpenListLib/releases)에서 관련 라이브러리를 다운로드해야 합니다.

### QQ 그룹:251405953
![QQGroup.jpg](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/contact/QQGroup.jpg)
### 프로젝트 구조
* [openlist](/lib/main.dart) 앱 진입점 프로젝트
* [openlist_api](/openlist_api) 핵심 API 래퍼
* [openlist_utils](/openlist_utils) 유틸리티
* [openlist_background_service](/openlist_background_service) openlist(AList) 라이브러리 래퍼
* [openlist_global](/openlist_global) 전역 공유 코드
* [openlist_config](/openlist_config) 설정 파일
* [openlist_native_ui](/openlist_native_ui) 네이티브 UI 코드
* [openlist_web_ui](/openlist_web_ui) 웹 UI 코드(현재 기본 사용)

![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/android/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/macos/storages.png) ![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/macos/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/ios/storages.png) ![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/ios/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/windows/storages.png)

### 주의사항:
* 초기 사용자는 상위 프로젝트 기본 권한을 따르며, 기본적으로 webdav가 활성화되어 있지 않으니 주의하세요.
* 기타


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---