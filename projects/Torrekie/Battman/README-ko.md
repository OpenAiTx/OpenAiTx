# Battman
Strayers' 현대적인 배터리 관리자, 그들의 오래된 iOS 기기를 위해.

### 🌍
[简体中文](https://raw.githubusercontent.com/Torrekie/Battman/master/docs/README-zh_CN.md)

## 스크린샷
<div style="width:20%; margin: auto;" align="middle">
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Main.png?raw=true" alt="Battman Main Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge.png?raw=true" alt="Battman Gas Gauge Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge-1.png?raw=true" alt="Battman Gas Gauge Demo 2" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Adapter.png?raw=true" alt="Battman Adapter Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive.png?raw=true" alt="Battman Inductive Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive-1.png?raw=true" alt="Battman Inductive Demo 2" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Serial.png?raw=true" alt="Battman Serial Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Temperature.png?raw=true" alt="Battman Temperature Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingMgmt.png?raw=true" alt="Battman Charging Management Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingLimit.png?raw=true" alt="Battman Charging Limit Demo" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Thermal.png?raw=true" alt="Battman Thermal Demo" width="25%" height="25%" />
</div>

$${\color{grey}진정한 \space 소프트웨어의 \space 우아함은 \space 피상적인 \space 디자인보다는 \space 코드의 \space 예술성에 \space 있습니다.}$$

<br />

### 장점
- [x] 순수 Objective-C 및 C로 구성
- [x] 훌륭한 Objective-C 코드로 UI 완전 작성
- [x] 스토리보드 없음, 추가 바이너리 없음, Xcode 에셋 없음
- [x] Swift 및 SwiftUI 미사용
- [x] CocoaPods, Swift 패키지, 외부 코드 요구사항, 서드파티 프레임워크 없음
- [x] Xcode 사용 유무에 상관없이 컴파일 가능
- [x] 리눅스에서 빌드 가능 (네, "iOS 앱을 만들려면 Mac이 필요하다"는 애플의 선전입니다)
- [x] 가장 깊은 원시 데이터를 통해 하드웨어에서 직접 획득 및 작동
- [x] 아이폰, 아이패드, 아이팟, Xcode 시뮬레이터, 애플 실리콘 맥 지원 (기기 기부 시 애플 워치 및 애플 TV도 코딩 가능)
- [x] 텍사스 인스트루먼트가 제조한 배터리 가스 게이지 IC와 고도로 통합
- [x] IOPS 및 PowerManagement가 제공하는 것보다 더 많은 전력 정보 표시
- [x] 전원 어댑터, 무선 충전기, 심지어 MagSafe 액세서리까지 식별

### Battman만이 할 수 있는 일
iOS용으로 제작된 다른 배터리 유틸리티가 하지 못한 것들  
(2025년 3월 9일 일요일 UTC+0 기준)  
- [x] NotChargingReason 완전 디코딩 (참조: [not_charging_reason.h](https://raw.githubusercontent.com/Torrekie/Battman/master/Battman/battery_utils/not_charging_reason.h))  
- [x] Texas Instruments Impedance Track™ 정보 수집  
- [x] 실시간 충전 전류/전압 읽기  
- [x] Xcode 시뮬레이터에서 완벽하게 작동 (다른 앱들은 IOPS를 사용하여 시뮬레이터에서 작동하지 않음)  
- [x] 스마트 충전 (최적화된 배터리 충전) 통신  
- [x] 저전력 모드 동작 제어  
- [x] 연결된 MagSafe 액세서리에 대한 상세 정보  
- [x] 연결된 Lightning 케이블 및 액세서리에 대한 상세 정보  
- [x] 모든 하드웨어 온도 센서 읽기  

### 요구 사항  

- 탈옥 또는 TrollStore를 통한 설치  
- iOS 12 이상 / macOS 11 이상 (백포트 환영)  
- arm64 (이론상 A7 이상 / M1 이상)  
- Gettext libintl (선택 사항, 현지화용)  
- GTK+ 3 (선택 사항, GTK+ 기반 WM에서 실행용)  

### 다운로드  

최신 [릴리즈](https://github.com/Torrekie/Battman/releases/latest)에서 사전 빌드된 패키지를 확인하세요.  

또는 직접 빌드하려면:


```bash
# On macOS, install Xcode and directly build in it
# On Linux or BSD, make sure a LLVM cross toolchain and iPhoneOS.sdk is prepared, modify Battman/Makefile if needed
# On iOS, when you using Torrekie/Comdartiwerk as bootstrap
apt install git odcctools bash clang make sed grep ld64 ldid libintl-dev iphoneos.sdk
git clone https://github.com/Torrekie/Battman
cd Battman
# If Targeting iOS 12 or ealier, download SF-Pro-Display-Regular.otf somewhere, and put it under Battman/
wget <https://LINK/OF/SF-Pro-Display-Regular.otf> -O Battman/SF-Pro-Display-Regular.otf
make -C Battman all
# Produced Battman.ipa will under $(CWD)/Battman/build/Battman.ipa
```
### 알려진 문제

- Battman은 A7에서 A10까지의 기기에서 실행할 때 실제 하드웨어와 통합되어 있지 않습니다. AppleSMC가 없고 대신 AppleHPM을 사용하기 때문에 테스트할 수 없습니다.

### 테스트된 기기
- iPhone 12 시리즈 (D52)
- iPad Pro 2021 3세대 (J51)
- iPhone XR
- iPad Air 2

Battman이 기기에서 제대로 작동하지 않는 경우 [이슈](../../issues/new)를 등록해 주세요.

### 해야 할 일
- [ ] macOS용 AppKit/Cocoa UI
- [ ] iOS/macOS용 GTK+/X11 UI
- [ ] 가스 게이지 IC 자동 식별
- [ ] 선택적 데이터 수집 (현재 알 수 없는 매개변수 디코딩용)
- [x] 고급 기능 (AppleSMC/ApplePMGR 인터페이스)
- [x] 열 제어
- [ ] CLI로 실행
- [ ] 데몬으로 실행
- [x] 충전 제한
- [x] 무선/MagSafe 통합
- [ ] 앱 속도 제한
- [ ] Jetsam 제어
- [ ] 팬 제어
- [ ] 블루투스 액세서리 (AirPods 등)

### 라이선스

2025년 9월 27일 토요일 UTC+0 기준으로, Battman은 MIT 대신 [비무료 라이선스](https://raw.githubusercontent.com/Torrekie/Battman/master/LICENSE/LICENSE.md)를 사용합니다. 이로 인해 제가 생계를 유지하려는 것을 탓하지 마세요, 알겠죠?

## 면책 조항

생산 환경에서 사용하지 마십시오. 보증이 없으며, 모든 사용은 본인 책임입니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-23

---