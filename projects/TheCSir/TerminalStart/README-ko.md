

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/extension/icon128.png" width="72" alt="TerminalStart 아이콘">
</p>

<h1 align="center">TerminalStart</h1>

<p align="center">
  집중과 속도를 위해 제작된 레트로 영감의 모듈형 새 탭 대시보드입니다.
</p>

<p align="center">
  <a href="https://thecsir.github.io/TerminalStart/">라이브 데모</a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/mainPage.png" width="900" alt="TerminalStart 미리보기">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/settingsPage.png" width="900" alt="TerminalStart 설정">
</p>

---


## Edge / Chrome에 설치하기

1. `edge://extensions` (또는 `chrome://extensions`) 열기
2. **개발자 모드** 활성화
3. **압축 해제된 확장 프로그램 로드** 클릭
4. `extension` 폴더 선택


## Todoist 연동

개인 API 토큰을 사용하여 투두 위젯을 Todoist와 동기화하세요.

1. **설정 > 고급 > 투두 위젯**으로 이동
2. **Todoist와 동기화 활성화**  
3. API 토큰 붙여넣기 (설정 > 통합 > 개발자, [todoist.com](https://todoist.com))  
4. 요청 시 호스트 권한 부여  

**마감일** — 작업 생성 시 자연어 날짜 추가:

| 입력 | 작업 | 마감일 |
|---|---|---|
| `meet john tomorrow at 2pm` | meet john | 내일 오후 2시 |
| `buy groceries next monday` | buy groceries | 다음 주 월요일 |
| `call mom every friday` | call mom | 매주 금요일 |
| `submit report jan 15` | submit report | 1월 15일 |

Todoist의 자연어 처리(NLP)가 구문 분석을 처리합니다. 로컬 모드에서는 시간만 지정하는 구문(e.g. `standup 9am`)도 지원합니다.

## 빌드

### 요구 사항

* Node.js v16 이상  
* Python 3  

### 단계

1. 의존성 설치:

```
npm install
```

2. 빌드:

```
npm run build
```
빌드 스크립트는 자산을 자동으로 `extension/` 폴더에 동기화합니다.

3. 패키지:


```
python scripts/package_addon.py
```
출력: `terminal-start-v1.0.0.zip`

### 테스트


```
npx playwright test
```
Chromium을 사용하여 확장 프로그램에 대해 e2e 테스트를 실행합니다.

## 참고사항

- 설정은 오른쪽 상단 영역에 마우스를 올려 확인하세요.
- API 토큰은 로컬 브라우저에 저장되며 Todoist API 외에는 절대 전송되지 않습니다.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---