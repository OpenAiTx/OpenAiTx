# PrivacyFlip

**Android 기기를 위한 자동 잠금/잠금 해제 개인 정보 보호 제어 🔐📱✨**

**PrivacyFlip**은 잠금/잠금 해제 상태에 따라 Android 기기의 개인 정보 보호 기능을 자동으로 관리합니다. 기기를 잠그면 **Wi-Fi**, **Bluetooth**, **모바일 데이터**, **위치** 서비스, **NFC**, 심지어 **카메라/마이크 센서**까지 비활성화할 수 있습니다. 잠금 해제 시에는 원하는 기능을 지능적으로 다시 활성화합니다.

**Shizuku 또는 Root와 함께 작동** - 원하는 권한 방식을 선택하세요!

<div>
  <a href="https://f-droid.org/en/packages/io.github.dorumrr.privacyflip/" target="_blank" rel="noopener"><img height="50" src="https://f-droid.org/badge/get-it-on.png"></a> 
  <a href="https://apt.izzysoft.de/fdroid/index/apk/io.github.dorumrr.privacyflip" target="_blank" rel="noopener"><img height="50" src="https://gitlab.com/IzzyOnDroid/repo/-/raw/master/assets/IzzyOnDroid.png"></a> 
  <a href="https://www.buymeacoffee.com/ossdev"><img height="50" src="https://cdn.buymeacoffee.com/buttons/v2/arial-yellow.png" /></a>
</div>

## 📸 스크린샷

<div align="center">
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" alt="PrivacyFlip by Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" alt="PrivacyFlip by Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
</div>

## 🔒 주요 기능

### **자동 개인 정보 보호 제어**
- **잠금 감지**: 화면 잠금 시 즉시 개인 정보 보호 기능 비활성화
- **잠금 해제 감지**: 적절한 인증 대기 (단순 화면 켜짐 아님)
- **스마트 복원**: 잠금 해제 시 기능 재활성화 설정 가능

### **제어 가능한 개인 정보 보호 기능**
- 📶 **Wi-Fi** - 무선 연결 비활성화/활성화
- 📱 **Bluetooth** - 블루투스 라디오 제어
- 📡 **모바일 데이터** - 셀룰러 데이터 연결 관리
- 📍 **위치 서비스** - GPS 및 위치 추적 제어
- 📳 **NFC** - 근거리 무선 통신 센서 제어
- 📷 **카메라** - 카메라 센서 개인 정보 보호 비활성화/활성화 (Android 12 이상)
- 🎤 **마이크로폰** - 마이크 센서 개인 정보 보호 비활성화/활성화 (Android 12 이상)
- ✈️ **비행기 모드** - 잠금 시 비행기 모드 활성화 (선택 사항, 모든 라디오 비활성화)
- 🔋 **배터리 절약 모드** - 잠금 시 배터리 절약 모드 활성화 (선택 사항)

### **고급 기능**
- **스마트 비활성화 옵션**:
  - **"사용 중이거나 연결된 경우에만 제외"** - WiFi, 블루투스 또는 위치가 활성 사용 중일 때 비활성화하지 않음
  - **"이미 활성화된 경우에만 제외"** - 이미 켜져 있는 기능은 다시 활성화하지 않아 연결 재설정을 방지
  - **"수동 설정된 경우에만 제외"** - 잠금 해제 시 수동으로 활성화된 보호 모드를 존중함

- **앱 제외** - 포그라운드 상태일 때 특정 앱을 개인정보 보호 조치에서 제외
- **삼성 NFC 자동 재시도** - 삼성 결제 프레임워크 NFC 오버라이드를 대응하는 선택적 기능 (Galaxy S, Note, Z 시리즈용)
- **접근성 서비스** - 측면/전원 버튼 즉시 잠금 실험적 지원 (선택적, 접근성 권한 필요)
- **고급 감지** - 다중 단계 블루투스 연결 감지로 원치 않는 헤드폰 연결 해제를 방지

### **사용자 정의 타이밍**
- **잠금 지연**: 개인정보 보호 조치가 실행되기 전 0-60초(세분화), 2분, 또는 5분 설정 가능
- **잠금 해제 지연**: 기능 복구 전에 0-60초(세분화), 2분, 또는 5분 설정 가능
- **즉시 모드**: 지연 시간을 0으로 설정하여 즉시 조치 실행
- **참고**: 카메라 및 마이크는 Android 제한으로 인해 사용자 정의 지연을 무시하고 즉시 작동함

## 📱 요구 사항

**최소:** Android 7.0+ (API 레벨 24)
**카메라/마이크 기능:** Android 12+ (API 레벨 31)

**권한 부여 방법 선택:**

### **옵션 1: Shizuku** (루트 불필요!)
- **Shizuku** 앱 설치 및 실행
- **USB 디버깅 또는 무선 ADB**를 통한 ADB 권한
- **루트 불필요** - ADB 수준 권한으로 작동

### **옵션 2: 루트 액세스** (루팅 기기 권장)
- Magisk, SuperSU 또는 유사 도구를 통한 **루트 액세스**
- UID 0 권한으로 **최상의 성능**

### **옵션 3: Dhizuku** (디바이스 오너 방식)
- **디바이스 오너** 또는 **프로필 오너** 상태
- 초기 설정 후 **루트 및 ADB 불필요**
- **영구 권한 유지** - 재부팅 후에도 유지
- **추천 대상**: 기업용 기기, 작업 프로필, 개인정보 보호 중심 설정

### **옵션 4: Sui** (두 가지 장점 결합)
- Magisk가 설치된 **루팅 기기**
- **Sui Magisk** 모듈 설치됨  
- **최고의 사용자 경험** - 권한 요청 없음, 자동 시작

### **권한 감지 우선순위**  
1. **Sui** - 루트 권한으로 Shizuku API를 제공하는 Magisk 모듈 (최상의 UX)  
2. **Root** - Magisk/SuperSU를 통한 전통적인 루트 접근  
3. **Dhizuku** - 디바이스 오너 방식 (설정 후 루트나 ADB 불필요)  
4. **Shizuku** - Shizuku 앱을 통한 ADB 권한

## 🤝 기여하기

이 앱을 더 좋게 만드는데 도움을 주세요. 어떤 기여도 작지 않습니다!

### 기여 방법

1. **레포지토리 포크하기**  
2. **기능 브랜치 생성하기** (`git checkout -b feature/amazing-feature`)  
3. **변경사항 적용하기**  
4. **변경사항 커밋하기** (`git commit -m 'Add some amazing feature'`)  
5. **브랜치에 푸시하기** (`git push origin feature/amazing-feature`)  
6. **풀 리퀘스트 열기**

모든 기여는 **소중하며** **감사합니다**!

## 📄 라이선스

이 프로젝트는 MIT 라이선스하에 배포됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 💖 개발 지원

PrivacyFlip은 여러분의 개인정보를 보호합니다. 미래도 지킬 수 있습니다!

[![DONATE](https://img.shields.io/badge/DONATE-FFD700?style=for-the-badge&logoColor=white)](https://buymeacoffee.com/ossdev)

---

*더 밝은 날을 위한 늦은 밤 작업*

만든이: Doru Moraru


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-17

---