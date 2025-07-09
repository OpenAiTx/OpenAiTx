# c4 GenAI Suite

一款具備模型上下文提供者（MCP）整合的 AI 聊天機器人應用程式，採用 Langchain 驅動，並兼容所有主流大型語言模型（LLMs）及嵌入模型。

管理員可以透過新增擴充功能（例如 RAG（檢索增強生成）服務或 MCP 伺服器）來建立具備不同能力的助手。此應用程式採用現代技術組合構建，包括 React、NestJS 以及用於 REI-S 服務的 Python FastAPI。

使用者可透過友善的介面與助手互動。根據助手的設定，使用者可能可以提問、上傳自己的檔案，或使用其他功能。助手會依據所配置的擴充功能，與各種 LLM 供應商互動，並提供回應。由擴充功能提供的情境資訊，讓助手能夠回答特定領域的問題並提供相關資訊。

本應用程式設計為模組化且可擴充，允許使用者透過新增擴充功能來建立具備不同能力的助手。

![short demo video of basic usage](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## 功能特色

### 大型語言模型（LLM）及多模態模型

c4 GenAI Suite 已直接支援多種模型。若您的首選模型尚未支援，亦可輕鬆撰寫擴充功能以支援。

* 相容 OpenAI 的模型
* Azure OpenAI 模型
* Bedrock 模型
* Google GenAI 模型
* 相容 Ollama 的模型
### 檢索增強生成（RAG）

c4 GenAI 套件包括 REI-S，一個用於為 LLM 準備檔案的伺服器。

* REI-S，自訂整合的 RAG 伺服器
  * 向量儲存
    * pgvector
    * Azure AI Search
  * 嵌入模型
    * 相容於 OpenAI 的嵌入
    * Azure OpenAI 嵌入
    * 相容於 Ollama 的嵌入
  * 檔案格式：
    * pdf、docx、pptx、xlsx，...
    * 音訊檔語音轉錄（透過 Whisper）

### 擴充功能

c4 GenAI 套件設計具有可擴充性。撰寫擴充功能非常容易，使用現有的 MCP 伺服器也同樣簡單。

* 模型上下文協議（MCP）伺服器
* 自訂 systemprompt
* Bing 搜尋
* 計算機
## 入門指南

### 使用 Docker-Compose

- 在專案根目錄執行 `docker compose up`。
- 在瀏覽器中打開[應用程式](http://localhost:3333)。預設登入憑證為使用者名稱 `admin@example.com` 和密碼 `secret`。

![展示助理設定的影片](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### 使用 Helm 與 Kubernetes

若要在 Kubernetes 環境中部署，請參閱我們 [Helm Chart 的 README](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md)。

### 設定助理與擴充套件

c4 GenAI Suite 以*助理*為核心。
每個助理由一組擴充套件組成，這些擴充套件決定了 LLM 模型以及可使用的工具。

- 進入管理區（點擊左下方的使用者名稱），前往 [助理區段](http://localhost:3333/admin/assistants)。
- 點擊區段標題旁的綠色 `+` 按鈕新增助理。輸入名稱和描述。
- 選取剛建立的助理並點擊綠色的 `+ 新增擴充套件`。
- 選擇模型並填寫憑證。
- 使用 `測試` 按鈕檢查是否可用，然後點擊 `儲存`。

現在你可以返回[聊天頁面](http://localhost:3333/chat)（點擊左上角的 `c4 GenAI Suite`），用你的新助理開始新對話。

> [!TIP]
> 我們的 `docker-compose` 內建本地 Ollama，會在 CPU 上執行。你可以用它進行快速測試，但速度會比較慢，而且你可能會想要使用其他模型。如果你要使用它，只需在你的助理中建立下列模型擴充套件即可。
> * 擴充套件：`Dev: Ollama`
> * 端點：`http://ollama:11434`
> * 模型：`llama3.2`

### 模型上下文協定（MCP） [可選]

使用任何提供 `sse` 介面的 MCP 伺服器，並搭配 `MCP Tools` 擴充套件（或使用我們的 `mcp-tool-as-server` 作為 `stdio` MCP 伺服器前端的代理伺服器）。
每個 MCP 伺服器都可以作為擴充套件進行詳細配置。

### 檢索增強生成（RAG）／檔案搜尋 [可選]

使用我們的 RAG 伺服器 `REI-S` 來搜尋使用者提供的檔案。只需為助手配置一個 `搜尋檔案` 擴充套件即可。
此過程在 [ `services/reis` 子目錄](services/reis/#example-configuration-in-c4) 中有詳細描述。

## 貢獻與開發

* 請參閱 [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) 以瞭解如何貢獻的指引。
* 關於開發人員入門，請查閱 [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md)。

## 主要組件

本應用程式包含 **前端**、**後端** 和 **REI-S** 服務。

```
┌──────────┐
│   使用者  │
└─────┬────┘
      │ 存取
      ▼
┌──────────┐
│ 前端介面 │
└─────┬────┘
      │ 存取
      ▼
┌──────────┐     ┌─────────────────┐
│ 後端服務 │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ 存取
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ 嵌入模型        │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│ 向量儲存庫      │
└──────────┘     └─────────────────┘
```
### 前端

前端使用 React 和 TypeScript 構建，提供了一個用戶友善的介面，用於與後端和 REI-S 服務互動。它包含了管理助手、擴充功能以及聊天功能的介面。

> 原始碼位置：`/frontend`

### 後端

後端採用 NestJS 和 TypeScript 開發，作為應用程式的主要 API 層。它處理來自前端的請求，並與 llm 提供者互動以實現聊天功能。後端同時管理助手及其擴充功能，讓使用者可以配置並使用各種 AI 模型進行聊天。

此外，後端還負責用戶驗證，並與 REI-S 服務進行檔案索引與檢索的通訊。

為了資料持久化，後端使用 **PostgreSQL** 資料庫。

> 原始碼位置：`/backend`

### REI-S

REI-S（**R**etrieval **E**xtraction **I**ngestion **S**erver）是一個以 Python 為基礎的伺服器，提供基本的 RAG（檢索增強生成）能力。它支援檔案內容擷取、索引與查詢，使應用程式能有效處理大量資料集。REI-S 服務設計上能與後端無縫協作，為聊天功能和檔案搜尋提供所需資料。

REI-S 支援 Azure AI Search 及 pgvector 作為向量儲存，提供彈性且可擴充的資料檢索選項。該服務可以透過環境變數進行配置，以指定向量儲存的類型及連線細節。

> 原始碼位置：`/services/reis`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---