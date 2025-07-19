<translate-content># 로컬 챗 RAG

**로컬, 프라이버시 우선 검색 증강 생성(RAG) 채팅 앱**입니다. 문서를 업로드하고 질문을 하면 출처와 함께 답변을 받을 수 있습니다—오픈 소스 LLM이 사용자의 기기에서 실행됩니다.

---

## 기능

- **로컬 RAG 파이프라인**: 클라우드 없음, 데이터 유출 없음—모든 것이 사용자의 기기에서 실행됩니다.
- **파일 업로드 및 파싱**: DOCX, PDF 등 지원 (`unstructured`, `python-docx`, `pdfplumber` 사용).
- **모던 UI**: Gemini 스타일, 미니멀하고 접근성 우수. Vite, React, TypeScript, Zustand, Chakra UI로 제작됨.
- **출처와 함께 채팅**: 질문하고 답변이 어떤 문서/섹션에서 왔는지 확인 가능.
- **FastAPI 백엔드**: 견고한 API, 프론트엔드와 깔끔한 분리, `/api` 경로 구성.
- **Ollama LLM 통합**: Ollama를 통해 로컬에서 오픈 소스 모델(Mistral, Llama2 등) 사용 가능.
- **확장 가능 & 문서화됨**: 모듈화, 테스트 가능 코드와 엄격한 문서 및 변경 관리 정책.

---

## 빠른 시작

### 1. **요구 사항**
- Python 3.9 이상
- Node.js 18 이상
- [Ollama](https://ollama.com/) (로컬 LLM 및 임베딩용)

---

## 🚀 빠른 설정 체크리스트

1. **Ollama 설치** (로컬 LLM 및 임베딩용)
2. **필요한 모델 다운로드**: `mistral` (챗), `nomic-embed-text` (임베딩)
3. **Ollama 서버 시작**: `ollama serve` (백엔드 작동을 위해 실행 중이어야 함)
4. **백엔드 설정** (Python, FastAPI)
5. **프론트엔드 설정** (Node.js, Vite)
6. **브라우저에서 앱 열기**: [http://localhost:5173](http://localhost:5173)

---

### 2. Ollama 및 필수 모델 설치
- **Ollama 다운로드:** [ollama.com/download](https://ollama.com/download) (macOS, Windows, Linux)
- **또는 Homebrew(macos)로 설치:**
  ```bash
  brew install ollama
  ```
- **Ollama 서버 시작:** (백엔드 작동을 위해 반드시 실행 중이어야 함)</translate-content>
  ```bash
  ollama serve
  ```
- **필요한 모델 가져오기:**
  ```bash
  ollama pull mistral
  ollama pull nomic-embed-text
  ```
  - `mistral`: 채팅 및 질문 응답에 사용  
  - `nomic-embed-text`: 문서 임베딩에 사용  
  > `mistral`은 호환 가능한 다른 모델(e.g. `llama3`, `llama2`)로 대체할 수 있으나, 백엔드는 기본적으로 `mistral`을 사용합니다.  

### 3. 백엔드 설정 (FastAPI)  
- **가상 환경 생성 및 활성화:**
  ```bash
  cd backend
  python -m venv .venv
  source .venv/bin/activate
  ```
- **파이썬 의존성 설치:**
  ```bash
  pip install --upgrade pip
  pip install -r requirements.txt
  ```
- **백엔드 서버 시작:**
  ```bash
  uvicorn app.main:app --reload
  ```
- 백엔드 API는 다음에서 사용 가능합니다: [http://localhost:8000/api](http://localhost:8000/api)

### 4. 프론트엔드 설정 (Vite)
- **Node.js 의존성 설치:**
  ```bash
  cd frontend
  npm install
  ```
- **프론트엔드 개발 서버 시작:**
  ```bash
  npm run dev
  ```
- 프런트엔드 앱은 다음에서 사용 가능합니다: [http://localhost:5173](http://localhost:5173)

---

## ✅ 빠른 설정 체크리스트
- [ ] Ollama 설치 완료
- [ ] `mistral` 및 `nomic-embed-text` 모델 다운로드 완료
- [ ] `ollama serve` 실행 중
- [ ] 백엔드가 [http://localhost:8000/api](http://localhost:8000/api) 에서 실행 중
- [ ] 프런트엔드가 [http://localhost:5173](http://localhost:5173) 에서 실행 중

---

## 앱 사용 방법
- 브라우저에서 [http://localhost:5173](http://localhost:5173) 를 엽니다.
- 사이드바를 사용해 파일을 업로드합니다.
- 채팅 박스에 질문을 입력하세요; 답변은 문서 출처를 인용합니다.
- 모든 처리는 로컬에서 이루어지며, 데이터가 장치를 벗어나지 않습니다.

---

## 문제 해결 및 팁
- **Ollama가 실행 중이 아니거나 모델 오류 발생 시:**
  - 백엔드를 시작하기 **전에** 터미널 창에서 `ollama serve`가 실행 중인지 확인하세요.
  - `llama3`와 `nomic-embed-text` 모델을 모두 다운로드했는지 확인하세요.
  - 실행 중인 모델은 `ollama list`로 확인할 수 있습니다.
- **Python 의존성 오류:**
  - 가상 환경이 활성화되어 있고 `pip`가 최신인지 확인하세요.
- **Node/npm 오류:**
  - Node.js 18 이상을 사용하고 문제가 지속되면 `node_modules`를 삭제 후 재설치하세요.
- **PDF/DOCX 파싱 오류:**
  - `libmagic`과 `poppler-utils`를 설치하세요 (백엔드 주의사항 참고).
- **추가 도움말:**
  - [`backend/gotchas.md`](https://raw.githubusercontent.com/TAMustafa/Local_Chat_RAG/main/backend/app/gotchas.md) 및 [`backend/implementation_details.md`](https://raw.githubusercontent.com/TAMustafa/Local_Chat_RAG/main/backend/app/implementation_details.md) 문서를 참고하세요.

---

## 사용법
- 사이드바에서 **파일 업로드**.
- 채팅에서 **질문하기** — 답변은 문서를 참고하여 생성됩니다.
- 모든 답변에 **출처 표시** (파일별 중복 제거).
- **모든 처리는 로컬에서 진행** — 데이터가 장치를 벗어나지 않습니다.

---

## 아키텍처

- **프런트엔드**: Vite + React + TypeScript + Zustand + Chakra UI
- **백엔드**: FastAPI + SQLAlchemy + LangChain + ChromaDB + Unstructured
- **LLM**: Ollama (Mistral, Llama2 등) via `langchain-ollama`
- **RAG 파이프라인**: 청킹, 임베딩, 검색 및 출처가 포함된 채팅

### 폴더 구조
```
ChatRAG/
  backend/
    app/
      main.py           # FastAPI app & API endpoints
      db/               # Database models & session
      rag/              # RAG pipeline logic
    requirements.txt
    ...
  frontend/
    src/
      components/       # UI components (Chat, Files, Layout)
      state/            # Zustand stores
      ...
    vite.config.ts
    ...
```
---

## 사용자 정의
- **LLM 모델 변경:** `backend/app/main.py`에서 모델 이름을 편집하세요 (`OllamaLLM(model="mistral")`).
- **파일 유형 추가:** 백엔드 파이프라인에서 파일 파싱을 확장하세요.
- **UI/UX:** `frontend/src/components`에서 Chakra UI 테마 또는 컴포넌트 구조를 조정하세요.

---

## 문서 및 정책
- 모든 운영 특이사항, 아키텍처 결정 및 주의사항은 `backend/implementation_details.md`, `gotchas.md`, `quick_reference.md`에 기록되어 있습니다.
- 엄격한 문서 및 코드 품질 정책을 준수합니다 — 자세한 내용은 프로젝트 문서를 참조하세요.

---

## 크레딧
- Tarek Adam Mustafa 및 기여자들이 구축했습니다.
- 오픈 소스 기반: [Ollama](https://ollama.com/), [LangChain](https://github.com/langchain-ai/langchain), [ChromaDB](https://www.trychroma.com/), [Unstructured](https://unstructured.io/), [Chakra UI](https://chakra-ui.com/), [Vite](https://vitejs.dev/).

---

## 라이선스
[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---