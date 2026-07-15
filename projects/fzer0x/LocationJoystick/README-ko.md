# Location Joystick

## English

Location Joystick는 위치 시뮬레이션을 위해 설계된 Xposed 모듈입니다. 조이스틱 오버레이와 다양한 위치 관련 설정을 제공하여 시뮬레이션 경험을 향상시킵니다.

⚠️ **[NEW] 루트/Xposed 없이 기능 제공 (가짜 위치)** ⚠️

# 최신 릴리스: https://github.com/fzer0x/LocationJoystick_V4/releases

<div align="center">

## 🚀 커뮤니티에 참여하세요 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_CLICK_HERE_TO_JOIN-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 참여하고 지원 및 업데이트를 받으세요!

</div>

![스크린샷](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## 기능

- **조이스틱 오버레이:** 사용자 정의 가능한 조이스틱으로 실시간 네비게이션 가능.
- **위치 시뮬레이션:** 정확한 GPS 위치 가짜 설정.
- **GNSS 모킹:** 위성 수, SVID, C/N0 등 완전한 GNSS 상태 시뮬레이션으로 현실적인 위치 동작 구현.
- **무작위화:** 보다 자연스러운 이동을 위해 위치에 무작위 오프셋 반경 추가.
- **즐겨찾기:** 빠른 전환을 위한 즐겨찾는 위치 저장 및 관리.
- **사용자 정의 UI:**
    - 조이스틱과 미니맵 투명도(알파) 조절 가능.
    - 조이스틱 속도 설정 가능.
    - 조이스틱 위치 지속 저장.

## 요구 사항

- **안드로이드:** 10 이상 (최소 SDK 30)
- **루트:** Xposed 프레임워크 사용 시 필요.
- **Xposed 프레임워크:** LSPosed 사용을 권장합니다.
- **[신규] 루트/Xposed 불필요 기능 (모의 위치)**

## 설치 및 LSPosed 범위 설정

1. Location Joystick APK를 설치하세요.
2. Xposed 관리자(예: LSPosed)를 엽니다.
3. **Location Joystick** 모듈을 활성화하세요.
4. **중요:** LSPosed에서 범위를 설정하세요:
    - **Android-System** (GNSS 및 시스템 전반 모의 위해 필수 활성화).
    - **대상 앱** (예: Pokémon GO, Maps).
5. 기기를 재부팅하거나 LSPosed 사용 시 대상 앱과 시스템 UI를 강제 종료하세요.
6. Location Joystick을 열고 필요한 권한(오버레이, 위치)을 허용하세요.

## 사용법

1. 앱을 열고 지도에서 원하는 시작 위치를 설정하세요.
2. 시뮬레이션 설정(속도, 정확도 등)을 구성하세요.
3. 조이스틱 오버레이를 표시하려면 서비스를 시작하세요.
4. 대상 앱을 열고 조이스틱으로 이동하세요.

## 면책 조항

이 도구는 교육 및 개발 목적으로만 사용됩니다. 사용 시 책임은 본인에게 있습니다.

## 라이선스

자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

---

# Location Joystick

## 中文

Location Joystick 是一款用于模拟定位的 Xposed 模块。它提供了一个虚拟摇杆悬浮窗以及多种与定位相关的设置，以增强模拟体验。

⚠️ **[新功能] 无需 Root 或 Xposed 的模拟定位功能** ⚠️


<div align="center">

## 🚀 우리 커뮤니티에 참여하세요 🚀

<a href="https://t.me/+LTsF8mOwkRE3YzYy">
  <img src="https://img.shields.io/badge/👉_클릭하여_참여-FF0000?style=for-the-badge&logo=telegram&logoColor=white" />
</a>

🔥 참여 즉시 무료 혜택과 최신 업데이트를 받으세요!

# 최신 릴리스: https://github.com/fzer0x/LocationJoystick_V4/releases

</div>

![스크린샷](https://github.com/fzer0x/LocationJoystick/blob/main/screenshot3.jpg?raw=true)

## 기능

- **가상 조이스틱 플로팅 윈도우:** 사용자 정의 가능한 조이스틱으로 실시간 이동 가능.
- **위치 모의:** GPS 위치를 정밀하게 모의.
- **GNSS 모의:** GNSS 상태(위성 수, SVID, C/N0 등)를 완벽하게 모의하여 고급 위치 검출 메커니즘 대응 가능.
- **무작위화:** 위치에 무작위 오프셋 범위를 추가하여 이동 경로를 더욱 자연스럽게 만듦.
- **즐겨찾기:** 자주 사용하는 위치를 저장하고 관리하여 빠른 전환 가능.
- **사용자 정의 인터페이스:**
    - 조이스틱과 미니맵 투명도(Alpha) 조절.
    - 조이스틱 이동 속도 설정 가능.
    - 조이스틱 위치 자동 저장.

## 시스템 요구사항

- **Android:** 10 이상 (최소 SDK 30)
- **Root:** Xposed 프레임워크 사용 시 Root 권한 필요.
- **Xposed 프레임워크:** LSPosed 사용 권장.
- **[신기능] Root/Xposed 없이 위치 모의 기능 지원**

## 설치 및 LSPosed 범위 설정

1. Location Joystick APK 설치.
2. Xposed 관리자(예: LSPosed) 실행.

3. **Location Joystick** 모듈을 활성화합니다.  
4. **중요:** LSPosed에서 Scope를 설정합니다:  
    - **Android-System** (GNSS 및 시스템 수준 위치 모의에 반드시 체크).  
    - **대상 애플리케이션** (예: Pokémon GO, 지도 앱 등).  
5. 기기를 재부팅합니다 (LSPosed 사용 시 대상 앱과 System UI를 강제 종료해도 무방).  
6. Location Joystick을 열고 필요한 권한(오버레이, 위치)을 허용합니다.  

## 사용 방법  

1. 앱을 열고 지도에서 시작 위치를 설정합니다.  
2. 모의 매개변수(속도, 정확도 등)를 설정합니다.  
3. 서비스를 시작하여 조이스틱 오버레이를 표시합니다.  
4. 대상 앱을 열고 조이스틱을 사용해 이동합니다.  

## 면책 조항  

이 도구는 학습 및 개발 용도로만 제공되며, 사용에 따른 위험은 사용자 책임입니다.  

## 라이선스  

라이선스 세부 정보는 [LICENSE](LICENSE) 파일을 참조하십시오.  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-15

---