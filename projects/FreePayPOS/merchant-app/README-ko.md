# NFC 결제 단말기

5개 블록체인 네트워크에서 암호화폐 결제를 처리하며, 실시간 거래 모니터링과 포괄적인 내역 추적 기능을 제공하는 멀티체인 NFC 결제 단말기입니다.

## 🌐 지원 네트워크

- **이더리움(Ethereum)**
- **베이스(Base)**
- **아비트럼(Arbitrum)**
- **옵티미즘(Optimism)**
- **폴리곤(Polygon)**

### 🎯 **스마트 결제 우선순위**

상인과 체인/토큰 조합을 협상하는 대신, 결제 단말기가 이를 자동으로 처리합니다. 우선적으로 상인이 지원하고 사용자가 자금이 있는 체인을 찾아낸 뒤, 다음 우선순위에 따라 ETH 또는 ERC-20 토큰으로 거래를 전송합니다:

```
L2 스테이블코인 > L2 기타 > L2 ETH > L1 스테이블코인 > L1 기타 > L1 ETH
```
## 🚀 빠른 시작

1. **의존성 설치:**
   ```bash
   npm install
   ```

2. **환경 설정:**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **터미널 실행:**
   ```bash
   npm start
   ```

4. **인터페이스 열기:**
   `http://localhost:3000`로 이동하세요.
## 🏗️ 아키텍처

```
src/
├── server.ts                   # Express 서버 & WebSocket 핸들러
├── app.ts                      # 메인 애플리케이션 오케스트레이터
├── web/index.html              # 결제 단말기 UI
├── config/index.ts             # 멀티체인 구성
└── services/
    ├── nfcService.ts           # NFC 리더 & 지갑 스캔
    ├── alchemyService.ts       # 멀티체인 잔액 & 모니터링
    ├── paymentService.ts       # 결제 선택 & EIP-681 생성
    ├── ethereumService.ts      # 주소 유효성 검사 유틸리티
    └── addressProcessor.ts     # 중복 처리 방지
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # 라즈베리 파이 이미지 빌드를 위한 의존성 설치
    └── build-pi-image-osx.sh       # 라즈베리 파이 이미지 빌드
```
## 💡 사용법

### **결제 처리**
1. 키패드를 사용하여 금액 입력 (센트 단위: "150" = 1.50달러)
2. "결제"를 눌러 결제 시작
3. 고객이 NFC 기기로 결제 전송
4. 실시간 모니터링으로 거래 확인
5. "승인" 메시지와 블록 탐색기 링크 제공

### **거래 내역**
1. 키패드의 📜 내역 버튼 탭
2. 모든 거래 내역 보기 또는 특정 지갑의 내역 조회
3. "📱 지갑 스캔하여 내역 확인"을 탭하고 고객이 기기를 태그하도록 안내
4. 해당 지갑의 필터링된 거래 내역 탐색


## 🔄 결제 흐름

1. **NFC 감지** → 고객이 기기 태그
2. **멀티체인 조회** → 6개 체인 전체 포트폴리오 분석
3. **스마트 선택** → 우선순위 시스템 기반 최적 결제 토큰 선택
4. **EIP-681 생성** → 체인 ID 포함 결제 요청
5. **실시간 모니터링** → WebSocket/폴링으로 거래 확인
6. **내역 기록** → 전체 메타데이터와 함께 거래 저장
## 🛡️ 트랜잭션 모니터링

- 이더리움, 베이스, 아비트럼, 옵티미즘, 폴리곤용 **WebSocket 모니터링**
- **폴링 기반 모니터링** 폴백
- **5분 후 자동 타임아웃**
- 트랜잭션 검증을 위한 **블록 익스플로러 연동**
- **상태 추적**: 감지됨 → 확인됨 → 실패

## 🍓 라즈베리 파이 배포

이 NFC 결제 단말기는 **플러그 앤 플레이 키오스크**로 라즈베리 파이 하드웨어에 배포하여 실제 환경에서 사용할 수 있습니다.

### **하드웨어 요구 사항**
- 라즈베리 파이 4B (4GB 이상 RAM 권장)
- 7인치 공식 라즈베리 파이 터치스크린
- **ACR1252U-M1 NFC 리더기** (특별히 지원됨)
- 32GB 이상 MicroSD 카드

### **배포 기능**
- **원커맨드 빌드**로 부팅 가능한 SD 카드 이미지 생성
- **사전 설정된 WiFi** 및 API 자격 증명
- **자동 시작** 및 전체화면 키오스크 모드
- **안전성 검증**으로 테스트 주소 배포 방지
- **macOS 및 Linux** 빌드 지원
### **빠른 배포**
```bash
# 배포 스크립트 디렉토리로 이동
cd scripts/rpi-deploy

# 배포 환경 설정
cp build-config.env.template build-config.env
# build-config.env 파일을 열어 WiFi, API 키, 가맹점 주소를 입력하세요

# 부팅 가능한 이미지 빌드 (macOS)
./build-pi-image-osx.sh

# 생성된 nfc-terminal-<date>.img.gz 파일을 Raspberry Pi Imager로 SD 카드에 플래시한 후 부팅하세요!
```

📖 **[전체 배포 가이드](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---