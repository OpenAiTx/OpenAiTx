<translate-content># DeckTap (LAN MVP)

<a href="https://youtu.be/pNgNUWSf7C4" title="링크 제목"><img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/hero.png" alt="대체 텍스트" width="600"/></a>

📡 DeckTap은 프레젠테이션 제어를 위한 경량 로컬 네트워크 리모컨입니다.  
앱 설치 없이 휴대폰으로 PowerPoint, Keynote, PDF 슬라이드쇼를 무선으로 제어하세요.

---

## ✨ 기능

- 📱 휴대폰 브라우저로 슬라이드 제어
- 🌐 로컬 Wi-Fi/핫스팟 네트워크에서 작동
- 🖥 키보드 방향키를 시뮬레이션하여 슬라이드 탐색
- 🚀 최소한의 설정: 로컬 Node.js 서버 실행 후 QR 코드 스캔
- 🔒 인터넷 불필요, **안전**하고 **개인 정보 보호**

---

## 📦 프로젝트 구조</translate-content>
```yaml
decktap/
├── client/            # Computer side agent
│    ├── lan.js        # LAN control
│    ├── cloud.js      # Connect cloud relay server in the future
│    └── config.js
│
├── controller/        # Mobile phone controller web page
│    └── index.html
│
├── server-cloud/      # Cloud server for remote control in the future
│    └── server.js
│
├── README.md
├── LICENSE
├── package.json
└── .gitignore
```
---

## 🔧 사전 요구사항

### macOS 권한 설정
DeckTap은 키보드 이벤트를 시뮬레이션하기 위해 `@nut-tree/nut-js`를 사용합니다. macOS에서는 터미널에 접근성 권한을 부여해야 합니다:

1. **시스템 설정** > **개인정보 보호 및 보안** > **손쉬운 사용**을 엽니다
2. 변경하려면 자물쇠 아이콘 🔒를 클릭합니다
3. **+** 버튼을 클릭합니다
4. `Terminal.app` (또는 사용하는 iTerm, VS Code 등)을 선택합니다
5. 터미널 앱 옆의 체크박스를 선택합니다

> **참고**: 이 권한 없이는 DeckTap이 프레젠테이션을 제어할 수 없습니다.

---

## 🚀 시작하기 (LAN 모드)
1. 의존성 설치:
   ```bash
   cd decktap-web && npm install && npm run build
   cd .. && npm install
   ```
2. 접근성 권한 부여 (macOS 전용):
   - [macOS 권한](#macos-permissions)의 단계를 따르세요
   - 권한 부여 후 터미널을 재시작하세요

3. 서버 시작:

   ```bash
   npm start
   ```
4. 휴대폰과 연결하기:
   - 휴대폰을 컴퓨터와 동일한 WiFi 네트워크(개인 WiFi만 지원, VLAN 불가, 캠퍼스 네트워크에서는 작동 안 함)에 연결하세요.
   - 휴대폰 브라우저에서 표시된 URL을 열거나 QR 코드를 스캔하세요.
   - <img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/computer-client.png" width="600">
   - 프레젠테이션 제어를 시작하세요 (왼손과 오른손 모드 전환은 👉 사용)
   - <img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/phone-controller.png" width="300" >
  

---

## ~🖱️ 독립 실행형 배포 빠른 시작~ (아직 사용 불가, 추후 Electron 클라이언트 개발 예정)

DeckTap의 **독립 실행형 실행 파일**(예: `decktap-macos`, `decktap-win.exe`, `decktap-linux`)을 받았다면 Node.js나 기타 의존성 설치 없이 바로 실행할 수 있습니다.

### 단계
1. **macOS / Linux 사용자:**
   - 첫 실행 전에 실행 권한을 부여하세요 (한 번만 필요):

     ```bash
     chmod +x decktap-macos
     ```
   - Run:
     ```bash
     ./decktap-macos
     ```
2. **윈도우 사용자:**
   - 명령 프롬프트에서 실행하세요:</translate-content>
     ```bat
     decktap-win.exe
     ```
3. **macOS에서 처음 실행하기:** 터미널 안내에 따라 접근성 권한을 부여해 주세요(위 [macOS 권한](#macos-permissions) 참조).

4. **QR 코드를 스캔하거나 휴대폰에서 표시된 URL을 열어 프레젠테이션 제어를 시작하세요!**

---

> 실행 실패, 권한 부족, 페이지 접근 불가 등의 문제가 발생하면 터미널 오류 메시지를 개발자에게 보내 도움을 받으세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---