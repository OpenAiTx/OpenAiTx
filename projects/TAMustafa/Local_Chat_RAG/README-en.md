<translate-content># Local Chat RAG

A **local, privacy-first Retrieval-Augmented Generation (RAG) chat app**. Upload documents, ask questions, and get answers with sources—powered by open-source LLMs running on your own machine.

---

## Features

- **Local RAG Pipeline**: No cloud, no data leaks—everything runs on your machine.
- **File Upload & Parsing**: Supports DOCX, PDF, and more (via `unstructured`, `python-docx`, `pdfplumber`).
- **Modern UI**: Gemini-style, minimal, and accessible. Built with Vite, React, TypeScript, Zustand, Chakra UI.
- **Chat with Sources**: Ask questions and see which documents/sections the answer comes from.
- **FastAPI Backend**: Robust API, clean separation from frontend, `/api` route organization.
- **Ollama LLM Integration**: Use open-source models (Mistral, Llama2, etc.) locally via Ollama.
- **Extensible & Documented**: Modular, testable code with strict documentation and change management policies.

---

## Quick Start

### 1. **Requirements**
- Python 3.9+
- Node.js 18+
- [Ollama](https://ollama.com/) (for local LLMs and embeddings)

---

## 🚀 Quick Setup Checklist

1. **Install Ollama** (for local LLM and embeddings)
2. **Pull required models**: `mistral` (chat) and `nomic-embed-text` (embeddings)
3. **Start the Ollama server**: `ollama serve` (must be running for backend to work)
4. **Set up backend** (Python, FastAPI)
5. **Set up frontend** (Node.js, Vite)
6. **Open the app** in your browser: [http://localhost:5173](http://localhost:5173)

---

### 2. Install Ollama and Required Models
- **Download Ollama:** [ollama.com/download](https://ollama.com/download) (macOS, Windows, Linux)
- **Or via Homebrew (macOS):**
  ```bash
  brew install ollama
  ```
- **Start the Ollama server:** (must be running for backend to work)
  ```bash
  ollama serve
  ```
- **Pull required models:**
  ```bash
  ollama pull mistral
  ollama pull nomic-embed-text
  ```
  - `mistral`: Used for chat and answering questions
  - `nomic-embed-text`: Used for document embeddings
  > You can substitute `mistral` with any compatible model (e.g. `llama3`, `llama2`), but the backend defaults to `mistral`.

### 3. Backend Setup (FastAPI)
- **Create and activate a virtual environment:**
  ```bash
  cd backend
  python -m venv .venv
  source .venv/bin/activate
  ```
- **Install Python dependencies:**
  ```bash
  pip install --upgrade pip
  pip install -r requirements.txt
  ```
- **Start the backend server:**
  ```bash
  uvicorn app.main:app --reload
  ```
- The backend API will be available at: [http://localhost:8000/api](http://localhost:8000/api)

### 4. Frontend Setup (Vite)
- **Install Node.js dependencies:**
  ```bash
  cd frontend
  npm install
  ```
- **Start the frontend dev server:**
  ```bash
  npm run dev
  ```
- The frontend app will be available at: [http://localhost:5173](http://localhost:5173)

---

## ✅ Quick Setup Checklist
- [ ] Ollama installed
- [ ] `mistral` and `nomic-embed-text` models pulled
- [ ] `ollama serve` running
- [ ] Backend running at [http://localhost:8000/api](http://localhost:8000/api)
- [ ] Frontend running at [http://localhost:5173](http://localhost:5173)

---

## How to Use the App
- Open [http://localhost:5173](http://localhost:5173) in your browser.
- Upload your files using the sidebar.
- Ask questions in the chat box; answers will cite document sources.
- All processing is local—your data never leaves your device.

---

## Troubleshooting & Tips
- **Ollama not running or model errors:**
  - Make sure `ollama serve` is running in a terminal window **before** starting the backend.
  - Ensure you have pulled both `llama3` and `nomic-embed-text` models.
  - You can check running models with `ollama list`.
- **Python dependency errors:**
  - Make sure your virtual environment is activated and `pip` is up to date.
- **Node/npm errors:**
  - Use Node.js 18+ and delete/reinstall `node_modules` if issues persist.
- **PDF/DOCX parsing errors:**
  - Install `libmagic` and `poppler-utils` (see backend gotchas).
- **For more help:**
  - See [`backend/gotchas.md`](https://raw.githubusercontent.com/TAMustafa/Local_Chat_RAG/main/backend/app/gotchas.md) and [`backend/implementation_details.md`](https://raw.githubusercontent.com/TAMustafa/Local_Chat_RAG/main/backend/app/implementation_details.md).

---

## Usage
- **Upload files** in the sidebar.
- **Ask questions** in the chat—answers are generated using your documents as context.
- **Sources** are shown for every answer (deduplicated by file).
- **All processing is local**—your data never leaves your device.

---

## Architecture

- **Frontend**: Vite + React + TypeScript + Zustand + Chakra UI
- **Backend**: FastAPI + SQLAlchemy + LangChain + ChromaDB + Unstructured
- **LLM**: Ollama (Mistral, Llama2, etc.) via `langchain-ollama`
- **RAG Pipeline**: Chunking, embedding, retrieval, and chat with sources

### Folder Structure
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

## Customization
- **Change LLM Model:** Edit the model name in `backend/app/main.py` (`OllamaLLM(model="mistral")`).
- **Add File Types:** Extend file parsing in the backend pipeline.
- **UI/UX:** Tweak Chakra UI theme or component structure in `frontend/src/components`.

---

## Documentation & Policies
- All operational quirks, architecture decisions, and gotchas are logged in `backend/implementation_details.md`, `gotchas.md`, and `quick_reference.md`.
- Strict documentation and code quality policies are followed—see project docs for details.

---

## Credits
- Built by Tarek Adam Mustafa and contributors.
- Powered by open-source: [Ollama](https://ollama.com/), [LangChain](https://github.com/langchain-ai/langchain), [ChromaDB](https://www.trychroma.com/), [Unstructured](https://unstructured.io/), [Chakra UI](https://chakra-ui.com/), [Vite](https://vitejs.dev/).

---

## License
[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---