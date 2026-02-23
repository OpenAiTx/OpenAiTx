# 크롬 디블로트

Chromium 기반 브라우저(Chrome, Brave, Edge)를 위한 정책을 생성하는 도구로, 불필요한 기능, 텔레메트리 및 불필요한 소프트웨어를 비활성화하고 일부 편의 기능을 활성화합니다.

## 기능

- 텔레메트리 및 사용 보고 비활성화 시도
- 불필요한 기능 및 사전 설치된 불필요한 소프트웨어 제거
- 홍보 콘텐츠 및 불필요한 UI 요소 차단
- 브라우저 기능을 유지하면서 자원 사용량 감소
- 필수 확장 프로그램 사전 구성:
  - uBlock Origin
  - Cookie AutoDelete
  - Don't f*** with paste
  - I still don't care about cookies
  - SponsorBlock
  - BlockTube
  - BlankTab
  - Decentraleyes

### 지원되는 브라우저

| 브라우저 | 윈도우 | macOS | 리눅스 |
|---------|---------|-------|-------|
| 구글 크롬 | ✅ | ✅ | ✅ |
| 마이크로소프트 엣지 | ✅ | ✅ | ✅ |
| 브레이브 | ✅ | ✅ | ✅ |

## 빠른 시작

### 윈도우
1.  [`generated/windows/`](./generated/windows/)에서 브라우저용 `.reg` 파일을 다운로드합니다.
2.  다운로드한 `.reg` 파일을 열어 Windows 레지스트리에 설정을 추가합니다.
3.  브라우저를 재시작하거나 `chrome://policy` (또는 `edge://policy`, `brave://policy`)로 이동하여 "정책 다시 불러오기"를 클릭합니다.

### macOS
1.  [`generated/macos/`](./generated/macos/)에서 브라우저용 `.mobileconfig` 파일을 다운로드합니다.
2.  다운로드한 `.mobileconfig` 파일을 열어 프로필 설치를 시작합니다.
3.  `시스템 설정` > `개인 정보 및 보안` > `프로필`로 이동하여 새 프로필을 승인합니다.
4.  브라우저를 재시작하거나 `chrome://policy` (또는 `edge://policy`, `brave://policy`)로 이동하여 "정책 다시 불러오기"를 클릭합니다.
### 리눅스
1.  브라우저에 해당하는 `.json` 파일을 [`generated/linux/`](./generated/linux/)에서 다운로드합니다.
2.  다운로드한 파일을 올바른 정책 디렉토리로 이동합니다 (필요시 생성):
    *   **크롬:** `/etc/opt/chrome/policies/managed/chrome.json`
    *   **엣지:** `/etc/opt/edge/policies/managed/edge.json`
    *   **브레이브:** `/etc/brave/policies/managed/brave.json`
    *   *참고: 이 작업을 위해 `sudo` 권한이 필요할 수 있습니다.*
3.  브라우저를 재시작하거나 `chrome://policy` (또는 `edge://policy`, `brave://policy`)로 이동하여 "정책 다시 불러오기"를 클릭합니다.

## 사용자 정의 구성

정책을 사용자 정의하려면:

1. 이 저장소를 클론합니다
2. 의존성을 설치합니다:

   ```bash
   uv sync
   ```
3. 필요에 따라 `policies.yaml` 파일을 수정하세요  
4. 새 구성 파일을 생성하세요:
   ```bash
   uv run main.py
   ```
5. `generated/` 디렉터리에서 생성된 파일을 찾으세요


### 정책 제거

**Windows:**
1.  이 저장소의 [`uninstall/windows/`](./uninstall/) 디렉터리로 이동합니다.
2.  사용 중인 브라우저에 해당하는 `.reg` 파일(예: `uninstall_chrome.reg`)을 실행합니다. 이렇게 하면 설치 중 추가된 레지스트리 키가 제거됩니다.
3.  브라우저를 재시작하거나 `chrome://policy` (또는 `edge://policy`, `brave://policy`)로 이동해 "Reload policies"를 클릭합니다.

**macOS:**
1.  `시스템 설정` > `개인정보 보호 및 보안` > `프로파일`로 이동합니다.
2.  브라우저와 관련된 프로파일을 선택합니다(예: "Chrome Debloat Policies").
3.  '-' (빼기) 버튼을 클릭하여 프로파일을 제거합니다.
4.  브라우저를 재시작하거나 `chrome://policy` (또는 `edge://policy`, `brave://policy`)로 이동해 "Reload policies"를 클릭합니다.

**Linux:**
1.  브라우저별 디렉터리에서 정책 JSON 파일을 제거합니다(권한이 필요할 수 있음):
    *   **Chrome:** `sudo rm /etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `sudo rm /etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `sudo rm /etc/brave/policies/managed/brave.json`
2.  브라우저를 재시작하거나 `chrome://policy` (또는 `edge://policy`, `brave://policy`)로 이동해 "Reload policies"를 클릭합니다.

## 정책 문서

- [Chrome Enterprise Policies](https://chromeenterprise.google/policies/)
- [Brave Policies](https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy)
- [Microsoft Edge Policies](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies)

## 라이선스

[Apache 2.0](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---