
# 本地聊天RAG

一个**本地的、以隐私为先的检索增强生成（RAG）聊天应用**。上传文档，提问，并获得带有来源的答案——由运行在您自己机器上的开源大型语言模型驱动。

---

## 功能

- **本地RAG流水线**：无云端，无数据泄露——所有操作均在您的机器上运行。
- **文件上传与解析**：支持DOCX、PDF等格式（通过`unstructured`、`python-docx`、`pdfplumber`）。
- **现代界面**：类Gemini风格，简约且易用。使用Vite、React、TypeScript、Zustand、Chakra UI构建。
- **带来源的聊天**：提问时可查看答案来源于哪些文档/章节。
- **FastAPI后端**：强健的API，与前端清晰分离，`/api`路由组织。
- **Ollama大型语言模型集成**：通过Ollama本地使用开源模型（Mistral、Llama2等）。
- **可扩展且有文档支持**：模块化、可测试代码，严格的文档和变更管理策略。

---

## 快速开始

### 1. **要求**
- Python 3.9+
- Node.js 18+
- [Ollama](https://ollama.com/)（用于本地大型语言模型和向量嵌入）

---

## 🚀 快速设置清单

1. **安装Ollama**（用于本地大型语言模型和向量嵌入）
2. **拉取所需模型**：`mistral`（聊天）和`nomic-embed-text`（嵌入）
3. **启动Ollama服务器**：`ollama serve`（后端运行必须启动）
4. **设置后端**（Python，FastAPI）
5. **设置前端**（Node.js，Vite）
6. **在浏览器中打开应用**：[http://localhost:5173](http://localhost:5173)

---

### 2. 安装Ollama及所需模型
- **下载Ollama：** [ollama.com/download](https://ollama.com/download)（支持macOS、Windows、Linux）
- **或通过Homebrew（macOS）：**
  ```bash
  brew install ollama
  ```
- **启动 Ollama 服务器：**（后台运行必需）
  ```bash
  ollama serve
  ```
- **拉取所需模型：**
  ```bash
  ollama pull mistral
  ollama pull nomic-embed-text
  ```

  - `mistral`：用于聊天和回答问题
  - `nomic-embed-text`：用于文档嵌入
  > 你可以用任何兼容的模型（例如 `llama3`、`llama2`）替代 `mistral`，但后端默认使用 `mistral`。

### 3. 后端设置（FastAPI）
- **创建并激活虚拟环境：**

  ```bash
  cd backend
  python -m venv .venv
  source .venv/bin/activate
  ```
- **安装 Python 依赖项：**
  ```bash
  pip install --upgrade pip
  pip install -r requirements.txt
  ```
- **启动后端服务器：**
  ```bash
  uvicorn app.main:app --reload
  ```
- 后端 API 将在以下地址提供：[http://localhost:8000/api](http://localhost:8000/api)

### 4. 前端设置（Vite）
- **安装 Node.js 依赖：**
  ```bash
  cd frontend
  npm install
  ```
- **启动前端开发服务器：**
  ```bash
  npm run dev
  ```
  - 前端应用将可通过以下地址访问：[http://localhost:5173](http://localhost:5173)

---

## ✅ 快速设置清单
- [ ] 安装 Ollama
- [ ] 下载 `mistral` 和 `nomic-embed-text` 模型
- [ ] 运行 `ollama serve`
- [ ] 后端运行在 [http://localhost:8000/api](http://localhost:8000/api)
- [ ] 前端运行在 [http://localhost:5173](http://localhost:5173)

---

## 如何使用该应用
- 在浏览器中打开 [http://localhost:5173](http://localhost:5173)。
- 使用侧边栏上传文件。
- 在聊天框中提问；回答会引用文档来源。
- 所有处理均在本地进行——您的数据绝不会离开您的设备。

---

## 故障排除与提示
- **Ollama 未运行或模型错误：**
  - 确保在启动后端之前，在终端窗口运行了 `ollama serve`。
  - 确认已下载 `llama3` 和 `nomic-embed-text` 两个模型。
  - 可用 `ollama list` 检查正在运行的模型。
- **Python 依赖错误：**
  - 确保虚拟环境已激活且 `pip` 已更新。
- **Node/npm 错误：**
  - 使用 Node.js 18 及以上版本，若有问题请删除并重新安装 `node_modules`。
- **PDF/DOCX 解析错误：**
  - 安装 `libmagic` 和 `poppler-utils`（见后端注意事项）。
- **获取更多帮助：**
  - 参见 [`backend/gotchas.md`](https://raw.githubusercontent.com/TAMustafa/Local_Chat_RAG/main/backend/app/gotchas.md) 和 [`backend/implementation_details.md`](https://raw.githubusercontent.com/TAMustafa/Local_Chat_RAG/main/backend/app/implementation_details.md)。

---

## 使用说明
- **在侧边栏上传文件**。
- **在聊天中提问**——答案是基于您的文档上下文生成的。
- **每个答案都会显示来源**（按文件去重）。
- **所有处理均在本地进行**——您的数据绝不会离开您的设备。

---

## 架构

- **前端**：Vite + React + TypeScript + Zustand + Chakra UI
- **后端**：FastAPI + SQLAlchemy + LangChain + ChromaDB + Unstructured
- **大语言模型（LLM）**：通过 `langchain-ollama` 使用 Ollama（Mistral、Llama2 等）
- **RAG 流水线**：分块、嵌入、检索及带来源的聊天

### 文件夹结构
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

## 自定义
- **更改 LLM 模型：** 编辑 `backend/app/main.py` 中的模型名称（`OllamaLLM(model="mistral")`）。
- **添加文件类型：** 在后端流水线中扩展文件解析功能。
- **UI/UX：** 调整 `frontend/src/components` 中 Chakra UI 主题或组件结构。

---

## 文档与政策
- 所有操作细节、架构决策和注意事项均记录在 `backend/implementation_details.md`、`gotchas.md` 和 `quick_reference.md` 中。
- 遵循严格的文档和代码质量政策—详情见项目文档。

---

## 致谢
- 由 Tarek Adam Mustafa 和贡献者构建。
- 基于开源项目驱动：[Ollama](https://ollama.com/)、[LangChain](https://github.com/langchain-ai/langchain)、[ChromaDB](https://www.trychroma.com/)、[Unstructured](https://unstructured.io/)、[Chakra UI](https://chakra-ui.com/)、[Vite](https://vitejs.dev/)。

---

## 许可证
[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---