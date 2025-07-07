<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>오픈 소스 이력서 빌더, 링크를 붙여넣고, 직접 수정하며, AI가 이력서 다듬기, 업데이트, 맞춤화 작업을 도와줍니다.</b>
</p>

---

### 어떻게 사용하나요?

[미디엄 블로그 링크](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

블로그는 사용자 인터페이스와 사용된 템플릿 측면에서 최신 정보가 아닙니다.

## 주요 기능

- <b>간편한 링크 가져오기:</b> 웹사이트에서 링크를 붙여넣고, PDF 이력서를 빠르게 만드세요.
- <b>수동 편집기 포함:</b> 내장 코드 편집기를 통해 이력서를 세밀하게 다듬거나 처음부터 작성할 수 있습니다.
- <b>스마트 제안:</b> 피드백이나 새로운 링크를 공유하면, smartedits가 이력서를 개선 및 업데이트하는 데 도움을 줍니다.
- <b>채용 맞춤화:</b> 채용 공고를 붙여넣으면, 이력서에 맞는 추천 사항을 제공합니다.
- <b>LaTeX 품질:</b> 모든 이력서는 LaTeX를 사용하여 깔끔하고 전문적인 레이아웃으로 생성됩니다.
- <b>즉각적인 미리보기:</b> 이력서를 실시간 PDF로 확인할 수 있습니다.
- <b>간편 초기화:</b> 클릭 한 번으로 이력서를 초기화하고 다시 시작할 수 있습니다.
- <b>로컬 실행:</b> Docker를 사용하여 내 컴퓨터에서 완전히 실행됩니다.

---

## 시작하기

### 사전 준비
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### 설치 방법

1. 저장소를 클론합니다:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. 앱을 빌드하고 시작합니다:
   ```bash
   docker compose up --build
   ```
3. 앱에 접속합니다:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## 사용법

1. 브라우저에서 autoResume을 엽니다.
2. :gear: 아이콘을 클릭하고, [GOOGLE API KEY](https://aistudio.google.com/)와 이메일을 입력합니다.
3. Github, 개인 웹사이트 등 본인 정보를 담은 링크를 붙여넣습니다.
4. 선택적으로, 추가 맞춤화를 위해 피드백이나 채용 공고 링크를 추가할 수 있습니다.
5. <b>이력서 생성</b>을 클릭하면 AI가 나머지를 처리합니다!

---

## 라이선스

이 프로젝트는 Apache 2.0 라이선스 하에 배포됩니다.

## 기여 안내

### 프론트엔드
- `frontend/src/components/` 폴더에 React 컴포넌트를 구현합니다.
- 컴포넌트 구현에 Chakra UI를 사용합니다.
- `frontend/src/App.jsx`에서 컴포넌트를 임포트하고 사용합니다.

### 백엔드
- `backend/src/routes/` 디렉터리에 API 라우트를 구현합니다.
- `backend/src/ai/` 디렉터리에 AI 기능을 추가합니다.
- Python 코드는 `black` 코드 포매터를 사용합니다.
- 라우트 핸들러는 깔끔하게 유지하고, 로직은 분리합니다.

### 일반 가이드라인
- 새로운 기능/수정 사항은 별도의 브랜치에서 작업하세요: `git checkout -b your-branch-name`
- 명확한 커밋 메시지를 작성하세요.
- PR 제출 전에 변경 사항을 테스트하세요.

### 변경 사항 제출
1. Pull Request를 생성하세요.
2. PR 설명에 아래 내용을 포함하세요:
   - 변경한 내용
   - 변경한 이유
   - 관련 스크린샷이나 테스트 결과
   - 주요 변경점이나 필요한 마이그레이션 단계

여러분의 기여를 환영하며, 가능한 한 빨리 PR을 검토하겠습니다!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---