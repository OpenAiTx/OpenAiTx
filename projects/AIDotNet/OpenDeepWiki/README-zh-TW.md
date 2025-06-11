# OpenDeepWiki

[中文](README.zh-CN.md) | [English](README.md)

<div align="center">
  <img src="https://raw.githubusercontent.com/AIDotNet/OpenDeepWiki/main/img/favicon.png" alt="OpenDeepWiki Logo" width="200" />
  <h3>AI 驅動的程式碼知識庫</h3>
</div>

# 贊助商

[![image](https://github.com/user-attachments/assets/b1bcb56e-38cb-47bf-adfe-7a21d83774b4)](https://share.302.ai/jXcaTv)

[302.AI](https://share.302.ai/jXcaTv) 是一個按需付費、一站式企業級 AI 應用平台。它提供開放平台和開源生態系統，讓 AI 能為各類需求尋找解決方案。點擊[這裡](https://share.302.ai/jXcaTv)即可獲得 $1 免費體驗金！

## 功能

- **快速轉換：** 所有 Github、Gitlab、Gitee、Gitea 等程式碼倉庫，僅需幾分鐘即可轉換為知識庫。
- **多語言支援：** 支援所有程式語言的程式碼分析與文檔生成。
- **程式碼結構：** 自動生成 Mermaid 圖，幫助理解程式碼結構。
- **自定義模型：** 支援自定義模型與自定義 API，按需擴展。
- **AI 智能分析：** 基於 AI 的程式碼分析與程式碼關係理解。
- **輕鬆 SEO：** 使用 Next.js 生成對 SEO 友好的文檔與知識庫，易於搜索引擎收錄。
- **對話式互動：** 支援與 AI 進行對話式互動，獲取程式碼詳細信息及使用方法，深入理解程式碼。

功能列表：
- [x] 支援多種程式碼倉庫（Github、Gitlab、Gitee、Gitea 等）
- [x] 支援多種程式語言（Python、Java、C#、JavaScript 等）
- [x] 支援倉庫管理，提供新增、刪除、修改、查詢倉庫的功能
- [x] 支援多家 AI 提供商（OpenAI、AzureOpenAI、Anthropic 等）
- [x] 支援多種資料庫（SQLite、PostgreSQL、SqlServer 等）
- [x] 支援多語言（中文、英文、法文等）
- [x] 支援上傳 ZIP 壓縮包、上傳本地文件
- [x] 提供資料微調平台，可生成微調數據集
- [x] 支援倉庫目錄級管理，可自定義目錄生成與動態文檔創建
- [x] 支援倉庫目錄管理，可對倉庫目錄進行修改
- [x] 支援用戶級管理，提供新增、刪除、修改、查詢用戶的功能
- [ ] 支援用戶權限管理，提供新增、刪除、修改、查詢用戶權限的功能
- [x] 支援倉庫級別生成不同微調框架數據集

# 項目介紹

OpenDeepWiki 是一個受 [DeepWiki](https://deepwiki.com/) 啟發、基於 .NET 9 與 Semantic Kernel 開發的開源項目。旨在通過程式碼分析、文檔生成、知識圖譜等功能，幫助開發者更好地理解和利用程式碼倉庫。
- 分析程式碼結構
- 理解倉庫核心概念
- 生成程式碼文檔
- 自動為程式碼創建 README.md
  MCP 支援

OpenDeepWiki 支援 MCP (Model Context Protocol)
- 支援為單個倉庫提供 MCPServer，並針對單倉庫進行分析。

用法：以下為 cursor 的用法：
```json
{
  "mcpServers": {
    "OpenDeepWiki":{
      "url": "http://Your OpenDeepWiki service IP:port/sse?owner=AIDotNet&name=OpenDeepWiki"
    }
  }
}
```
- owner：為倉庫所屬組織或所有者名稱。
- name：為倉庫名稱。

添加倉庫後，測試詢問一個問題（請注意，執行此操作前需先處理倉庫）：What is OpenDeepWiki? 效果如下圖所示：![](https://raw.githubusercontent.com/AIDotNet/OpenDeepWiki/main/img/mcp.png)

如此，即可將 OpenDeepWiki 作為 MCPServer，供其他 AI 模型調用，便於對開源項目進行分析與理解。

## 🚀 快速開始

1. 克隆倉庫
```bash
git clone https://github.com/AIDotNet/OpenDeepWiki.git
cd OpenDeepWiki
```

2. 打開 `docker-compose.yml` 文件，修改以下環境變數：

Ollama：
```yaml
services:
  koalawiki:
    environment:
      - KOALAWIKI_REPOSITORIES=/repositories
      - TASK_MAX_SIZE_PER_USER=5 # 每位用戶 AI 併發生成文檔最大任務數
      - CHAT_MODEL=qwen2.5:32b # 模型需支援 functions
      - ANALYSIS_MODEL=qwen2.5:32b # 用於生成倉庫目錄結構的分析模型
      - CHAT_API_KEY=sk-xxxxx # 您的 API 金鑰
      - LANGUAGE= # 設置默認生成語言為「Chinese」
      - ENDPOINT=https://Your Ollama's IP: Port/v1
      - DB_TYPE=sqlite
      - MODEL_PROVIDER=OpenAI # 模型提供商，預設為 OpenAI，支援 AzureOpenAI 和 Anthropic
      - DB_CONNECTION_STRING=Data Source=/data/KoalaWiki.db
      - EnableSmartFilter=true # 是否啟用智能過濾，可能影響 AI 獲取倉庫文件目錄的方式
      - UPDATE_INTERVAL # 倉庫增量更新間隔，單位：天
      - MAX_FILE_LIMIT=100 # 上傳文件最大限制，單位 MB
      - DEEP_RESEARCH_MODEL= # 對模型進行深度研究，為空則用 CHAT_MODEL
      - ENABLE_INCREMENTAL_UPDATE=true # 是否啟用增量更新
      - ENABLE_CODED_DEPENDENCY_ANALYSIS=false # 是否啟用程式碼依賴分析，可能影響程式碼質量
      - ENABLE_WAREHOUSE_FUNCTION_PROMPT_TASK=false # 是否啟用 MCP Prompt 生成
      - ENABLE_WAREHOUSE_DESCRIPTION_TASK=false # 是否啟用倉庫描述生成
```

OpenAI：
```yaml
services:
  koalawiki:
    environment:
      - KOALAWIKI_REPOSITORIES=/repositories
      - TASK_MAX_SIZE_PER_USER=5 # 每位用戶 AI 併發生成文檔最大任務數
      - CHAT_MODEL=DeepSeek-V3 # 模型需支援 functions
      - ANALYSIS_MODEL= # 用於生成倉庫目錄結構的分析模型
      - CHAT_API_KEY= # 您的 API 金鑰
      - LANGUAGE= # 設置默認生成語言為「Chinese」
      - ENDPOINT=https://api.token-ai.cn/v1
      - DB_TYPE=sqlite
      - MODEL_PROVIDER=OpenAI # 模型提供商，預設為 OpenAI，支援 AzureOpenAI 和 Anthropic
      - DB_CONNECTION_STRING=Data Source=/data/KoalaWiki.db
      - EnableSmartFilter=true # 是否啟用智能過濾，可能影響 AI 獲取倉庫文件目錄的方式
      - UPDATE_INTERVAL # 倉庫增量更新間隔，單位：天
      - MAX_FILE_LIMIT=100 # 上傳文件最大限制，單位 MB
      - DEEP_RESEARCH_MODEL= # 對模型進行深度研究，為空則用 CHAT_MODEL
      - ENABLE_INCREMENTAL_UPDATE=true # 是否啟用增量更新
      - ENABLE_CODED_DEPENDENCY_ANALYSIS=false # 是否啟用程式碼依賴分析，可能影響程式碼質量
      - ENABLE_WAREHOUSE_FUNCTION_PROMPT_TASK=false # 是否啟用 MCP Prompt 生成
      - ENABLE_WAREHOUSE_DESCRIPTION_TASK=false # 是否啟用倉庫描述生成
```

AzureOpenAI：
```yaml
services:
  koalawiki:
    environment:
      - KOALAWIKI_REPOSITORIES=/repositories
      - TASK_MAX_SIZE_PER_USER=5 # 每位用戶 AI 併發生成文檔最大任務數
      - CHAT_MODEL=DeepSeek-V3 # 模型需支援 functions
      - ANALYSIS_MODEL= # 用於生成倉庫目錄結構的分析模型
      - CHAT_API_KEY= # 您的 API 金鑰
      - LANGUAGE= # 設置默認生成語言為「Chinese」
      - ENDPOINT=https://your-azure-address.openai.azure.com/
      - DB_TYPE=sqlite
      - MODEL_PROVIDER=AzureOpenAI # 模型提供商，預設為 OpenAI，支援 AzureOpenAI 和 Anthropic
      - DB_CONNECTION_STRING=Data Source=/data/KoalaWiki.db
      - EnableSmartFilter=true # 是否啟用智能過濾，可能影響 AI 獲取倉庫文件目錄的方式
      - UPDATE_INTERVAL # 倉庫增量更新間隔，單位：天
      - MAX_FILE_LIMIT=100 # 上傳文件最大限制，單位 MB
      - DEEP_RESEARCH_MODEL= # 對模型進行深度研究，為空則用 CHAT_MODEL
      - ENABLE_INCREMENTAL_UPDATE=true # 是否啟用增量更新
      - ENABLE_CODED_DEPENDENCY_ANALYSIS=false # 是否啟用程式碼依賴分析，可能影響程式碼質量
      - ENABLE_WAREHOUSE_FUNCTION_PROMPT_TASK=false # 是否啟用 MCP Prompt 生成
      - ENABLE_WAREHOUSE_DESCRIPTION_TASK=false # 是否啟用倉庫描述生成
```

Anthropic：
```yaml
services:
  koalawiki:
    environment:
      - KOALAWIKI_REPOSITORIES=/repositories
      - TASK_MAX_SIZE_PER_USER=5 # 每位用戶 AI 併發生成文檔最大任務數
      - CHAT_MODEL=DeepSeek-V3 # 模型需支援 functions
      - ANALYSIS_MODEL= # 用於生成倉庫目錄結構的分析模型
      - CHAT_API_KEY= # 您的 API 金鑰
      - LANGUAGE= # 設置默認生成語言為「Chinese」
      - ENDPOINT=https://api.anthropic.com/
      - DB_TYPE=sqlite
      - MODEL_PROVIDER=Anthropic # 模型提供商，預設為 OpenAI，支援 AzureOpenAI 和 Anthropic
      - DB_CONNECTION_STRING=Data Source=/data/KoalaWiki.db
      - EnableSmartFilter=true # 是否啟用智能過濾，可能影響 AI 獲取倉庫文件目錄的方式
      - UPDATE_INTERVAL # 倉庫增量更新間隔，單位：天
      - MAX_FILE_LIMIT=100 # 上傳文件最大限制，單位 MB
      - DEEP_RESEARCH_MODEL= # 對模型進行深度研究，為空則用 CHAT_MODEL
      - ENABLE_INCREMENTAL_UPDATE=true # 是否啟用增量更新
      - ENABLE_CODED_DEPENDENCY_ANALYSIS=false # 是否啟用程式碼依賴分析，可能影響程式碼質量
      - ENABLE_WAREHOUSE_FUNCTION_PROMPT_TASK=false # 是否啟用 MCP Prompt 生成
      - ENABLE_WAREHOUSE_DESCRIPTION_TASK=false # 是否啟用倉庫描述生成
```

> 💡 **如何獲取 API 金鑰：**
> - 申請 Google API 金鑰 [Google AI Studio](https://makersuite.google.com/app/apikey)
> - 申請 OpenAI API 金鑰 [OpenAI Platform](https://platform.openai.com/api-keys)
> - 申請 CoresHub [CoresHub](https://console.coreshub.cn/xb3/maas/global-keys) [點擊領取 5000 萬免費 Token](https://account.coreshub.cn/signup?invite=ZmpMQlZxYVU=)
> - 申請 TokenAI [TokenAI](https://api.token-ai.cn/)

3. 啟動服務

您可以使用提供的 Makefile 命令輕鬆管理應用：

```bash
# 構建所有 Docker 映像
make build

# 以後台模式啟動所有服務
make up

# 或以開發模式啟動（可見日誌）
```
make dev
```

然後造訪 http://localhost:8090 以存取知識庫。

更多指令請參考：
```bash
make help
```

### Windows 用戶（無 make 指令）

如果你使用 Windows 且沒有安裝 `make`，可以直接使用這些 Docker Compose 指令：

```bash
# 建立所有 Docker 映像檔
docker-compose build

# 背景模式啟動所有服務
docker-compose up -d

# 開發模式啟動（可見日誌）
docker-compose up

# 停止所有服務
docker-compose down

# 檢視日誌
docker-compose logs -f
```

若需針對特定架構或服務建置，請使用：

```bash
# 僅建置後端
docker-compose build koalawiki

# 僅建置前端
docker-compose build koalawiki-web

# 使用架構參數進行建置
docker-compose build --build-arg ARCH=arm64
docker-compose build --build-arg ARCH=amd64
```


### 部署到 Sealos 並公開網路存取
[![](https://raw.githubusercontent.com/labring-actions/templates/main/Deploy-on-Sealos.svg)](https://bja.sealos.run/?openapp=system-template%3FtemplateName%3DOpenDeepWiki)
詳細步驟請參考：[使用模板一鍵部署 OpenDeepWiki 為公開網絡可訪問的 Sealos 應用](scripts/sealos/README.zh-CN.md)

## 🔍 運作方式說明

OpenDeepWiki 使用 AI 來：
 - 將程式碼倉庫複製到本地
 - 根據倉庫中的 README.md 進行分析
 - 分析程式碼結構並根據需要讀取程式碼檔案，然後生成目錄 json 資料
 - 按目錄處理任務，每個任務為一份文檔
 - 讀取程式碼檔案、分析程式碼檔案、生成程式碼說明文件，並建立代表程式碼結構依賴關係的 Mermaid 圖表
 - 生成最終的知識庫文檔
 - 透過對話互動分析倉庫並回應用戶查詢

```mermaid
graph TD
    A[Clone code repository] --> B[Analyze README.md]
    B --> C[Analyze code structure]
    C --> D[Generate directory json data]
    D --> E[Process multiple tasks]
    E --> F[Read code files]
    F --> G[Analyze code files]
    G --> H[Generate code documentation]
    H --> I[Create Mermaid charts]
    I --> J[Generate knowledge base document]
    J --> K[Conversational interaction]
```
## 進階設定

### 環境變數
  - KOALAWIKI_REPOSITORIES  倉庫儲存路徑
  - TASK_MAX_SIZE_PER_USER  每個用戶 AI 文件生成最大並行任務數
  - CHAT_MODEL  必須支援 functions 的模型
  - ENDPOINT  API 端點
  - ANALYSIS_MODEL  用於生成倉庫目錄結構的分析模型
  - CHAT_API_KEY  你的 API 金鑰
  - LANGUAGE  更改生成文件的語言
  - DB_TYPE  資料庫類型，預設為 sqlite
  - MODEL_PROVIDER  模型提供者，預設為 OpenAI，支援 Azure、OpenAI 及 Anthropic
  - DB_CONNECTION_STRING  資料庫連線字串
  - EnableSmartFilter 是否啟用智能過濾，可能會影響 AI 獲取倉庫文件目錄的方式
  - UPDATE_INTERVAL 倉庫增量更新間隔，單位：天
  - MAX_FILE_LIMIT 上傳檔案的最大限制，單位：MB
  - DEEP_RESEARCH_MODEL 針對模型進行深入研究，若為空則使用 CHAT_MODEL
  - ENABLE_INCREMENTAL_UPDATE 是否啟用增量更新
  - ENABLE_CODED_DEPENDENCY_ANALYSIS 是否啟用程式碼依賴分析，這可能會影響程式碼品質
  - ENABLE_WAREHOUSE_FUNCTION_PROMPT_TASK  # 是否啟用 MCP Prompt 生成
  - ENABLE_WAREHOUSE_DESCRIPTION_TASK # 是否啟用倉庫描述生成

### 不同架構下的建置
Makefile 提供不同 CPU 架構的建置指令：

```bash
# 為 ARM 架構建置
make build-arm

# 為 AMD 架構建置
make build-amd

# 僅建置 ARM 後端
make build-backend-arm

# 僅建置 AMD 前端
make build-frontend-amd
```

## Discord

[加入我們](https://discord.gg/8sxUNacv)

## 微信 

![b62354e40046f409b88528dd5631ed45](https://github.com/user-attachments/assets/2bb0055f-9e45-4db2-b9c9-f1e251996e01)

## 📄 授權條款
本專案採用 MIT 授權條款，詳情請見 [LICENSE](./LICENSE) 檔案。

## Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=AIDotNet/OpenDeepWiki&type=Date)](https://www.star-history.com/#AIDotNet/OpenDeepWiki&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---