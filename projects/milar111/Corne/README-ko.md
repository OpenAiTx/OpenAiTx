# 예산형 무선 코른 키보드 제작

약 25달러(USD)로 제작한 코른 레이아웃 기반 DIY 무선 분할 키보드입니다. 이 프로젝트는 nrf52840 칩이 탑재된 ProMicro 클론을 사용하여 기존 무선 분할 키보드 제작에 비해 비용 효율적인 대안을 제공합니다.

## 기능
- 블루투스 완전 무선
- 분할 인체공학적 디자인 (코른 레이아웃)
- 휴대성을 위한 저프로파일 디자인
- 전원 스위치가 있는 배터리 구동
- ZMK 펌웨어
- 예상 배터리 수명: 1개월 이상

## 부품 목록

| 부품 | 수량 | 비용 (USD) | 링크 |
|-----------|----------|------------|------|
| 컨트롤러 보드 (ProMicro nrf52840) | 2 | 6.82 | [AliExpress](https://a.aliexpress.com/_EIV3vwY) |
| 배터리 | 2 | 4.20 | [AliExpress](https://a.aliexpress.com/_Eynt9TK) |
| 기계식 스위치 | 50 | 7.47 | [AliExpress](https://a.aliexpress.com/_EGhMxEC) |
| 키캡 | 세트 | 3.79 | [옵션 1](https://a.aliexpress.com/_EzQyNtA) / [옵션 2](https://a.aliexpress.com/_EH8mNqs) |
| 다이오드 (1N4148) | 100 | 0.85 | [AliExpress](https://a.aliexpress.com/_EwZoG2G) |
| 슬라이드 스위치 | 2 | 0.11 | |
| 3D 프린팅 부품 | 세트 | 1.80 | 파일 제공 |

**총 비용**: $25.04 (배선 및 나사 제외)

## 현재 키맵

![image](https://github.com/user-attachments/assets/362ff580-5528-4f7a-ad09-1fa24acbc6c7)
![image](https://github.com/user-attachments/assets/3da97ceb-8e2a-43c5-a241-cf9ad4206688)
![image](https://github.com/user-attachments/assets/e262846d-57bf-43b6-b32c-b7e37d3ebb8c)
![image](https://github.com/user-attachments/assets/2a8999cc-e58c-4d51-a142-067cb7ca768c)
![image](https://github.com/user-attachments/assets/06909fd8-bb4d-4956-88a1-f5d6a8b80e5f)

## 제작 지침

### 사전 준비 사항
- 기본 납땜 기술
- 3D 프린터 접근 가능
- 키보드 펌웨어에 대한 기본 이해
### 케이스 조립  
1. 케이스 파일 인쇄 (`3DFiles` 디렉토리에 제공된 STL 파일)  
2. 참고: 다음을 조정해야 할 수 있습니다:  
   - 배터리 구획 크기  
   - 슬라이드 스위치 구멍  

### 배선  
1. 스위치를 매트릭스 구성으로 배선  
2. 다이오드 연결:  
   - 방향이 중요함 (검은 선은 캐소드 표시)  
   - 행에는 다이오드 다리를 사용  
   - 열에는 별도의 선 사용  
3. 배선이 나사 구멍과 겹치지 않도록 주의  
4. 배터리 연결:  
   - GND를 GND 핀에 연결  
   - 양극은 슬라이드 스위치의 한쪽 다리에 연결  
   - 슬라이드 스위치의 가운데 핀은 RAW 핀에 연결  

### 행과 열의 핀 연결  
매트릭스 구성은 nRF52840 Pro Micro 클론의 GPIO 핀을 사용합니다. 아래는 연결 정보입니다:  

![pinout](https://github.com/user-attachments/assets/ae1bf9eb-8071-4a8f-8cac-c95a39f61f9e)  

#### 행과 열의 번호 매기기 방법  

- **행**: 양쪽 절반 모두에서 행은 항상 위에서 아래로 번호가 매겨집니다.  
- **열**: 열은 항상 (배선이 이루어지는 판의 뒷면에서 본 방향으로) 왼쪽에서 오른쪽으로 번호가 매겨집니다.  

⚠️ **참고**: 행이나 열을 잘못된 핀에 납땜했더라도 납땜을 제거할 필요는 없습니다. 펌웨어 구성 파일에서 매핑을 수정할 수 있습니다:  
- `corne.dtsi`: 양쪽 절반의 행 정의  
- `corne_left.overlay`: 왼쪽 절반의 열 정의  
- `corne_right.overlay`: 오른쪽 절반의 열 정의  

#### 왼쪽 절반 핀 할당  
- **행 (`row-gpios`에 연결됨)**:  
  - 행 0: 핀 21  
  - 행 1: 핀 20  
  - 행 2: 핀 19  
  - 행 3: 핀 18

- **열 (`col-gpios`에 연결됨)**:
  - 열 0: 핀 2
  - 열 1: 핀 7
  - 열 2: 핀 6
  - 열 3: 핀 5
  - 열 4: 핀 4
  - 열 5: 핀 3

#### 오른쪽 절반 핀 할당
- **행 (`row-gpios`)**:
  - 행 0: 핀 21
  - 행 1: 핀 20
  - 행 2: 핀 19
  - 행 3: 핀 18
- **열 (`col-gpios`)**:
  - 열 0: 핀 3
  - 열 1: 핀 4
  - 열 2: 핀 5
  - 열 3: 핀 6
  - 열 4: 핀 7
  - 열 5: 핀 2

### 펌웨어 설정
이 키보드는 ZMK 펌웨어를 사용합니다. 왼쪽 절반은 장치에 연결되는 메인 컨트롤러 역할을 합니다.

펌웨어를 플래시하려면:
1. 리셋 버튼을 두 번 누릅니다
2. 보드가 대용량 저장 장치로 나타납니다
3. 적절한 펌웨어 파일을 플래시합니다

장치에서 키보드를 잊어버려 다시 연결할 수 없는 경우:
1. `settings_reset-nice_nano_v2-zmk.uf2` 파일을 플래시합니다
2. 일반 펌웨어를 다시 플래시합니다
3. 페어링합니다

## 저장소 구조
```
├── .github/workflows/
│   └── build.yml
├── 3DFiles/
│   ├── STEP/
│   │   └── CorneSTEP.step
│   ├── STL/
│   │   ├── Case_Left.stl
│   │   ├── Case_Right.stl
│   │   └── PlateCorne.stl
├── config/
│   ├── boards/shields/corne/
│   │   ├── corne_left.conf
│   │   ├── corne_left.overlay
│   │   ├── corne_right.conf
│   │   ├── corne_right.overlay
│   │   ├── corne.conf
│   │   ├── corne.dtsi
│   │   ├── Kconfig.defconfig
│   │   └── Kconfig.shield
│   ├── corne.keymap
│   └── west.yml
├── firmware/
│   ├── corne_left-nice_nano_v2-zmk.uf2
│   ├── corne_right-nice_nano_v2-zmk.uf2
│   └── settings_reset-nice_nano_v2-zmk.uf2
└── zephyr/
    ├── module.yml
    └── build.yaml
```
## 알려진 문제점
- 배터리가 부풀면 왼쪽 케이스에 뒤틀림 문제가 발생할 수 있습니다
- 슬라이드 스위치 구멍은 부품에 따라 조정이 필요할 수 있습니다

## 최종 결과
![im1](https://github.com/user-attachments/assets/f57abe5a-585d-4f4e-b741-5c103c7af887)
![im3](https://github.com/user-attachments/assets/1ed52801-5bc1-44b9-8378-1a5e53600e92)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-17

---