
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>
# 增強型 PubChem MCP 伺服器適用於 AI 助理

🧪 一個先進、強大且重視隱私的 MCP 伺服器，使 AI 助理能夠智能搜尋並存取 PubChem 的化合物資訊。

此 PubChem MCP 伺服器是 AI 助理（如 AnythingLLM 中的助理）與 PubChem 廣大化學資料庫之間的強大橋樑。它利用 Model Context Protocol（MCP），讓 AI 模型能夠進行智能且有韌性的化合物搜尋，並以程式化方式擷取詳細性質。

---

## ✨ 核心特色

這不只是一個普通的 PubChem 包裝器。這個伺服器是從零開始重建，具備高度韌性與智能：

-   **🧠 智能備援搜尋**：若以常見名稱（如「維生素 D」）搜尋失敗，伺服器會自動在 PubChem Substance 資料庫進行更深入搜尋以找到正確化合物。這大幅提升了模糊查詢的成功率。
-   **🛡️ 強健錯誤處理與重試**：伺服器能優雅地處理 API 錯誤。若遇到 PubChem 的「伺服器忙碌」錯誤，會自動等待並重試請求，確保你的查詢即使在高負載下也能成功。
-   **🔒 選用 Tor 代理支援**：你完全掌握隱私權。只需簡單的 `config.ini` 設定檔，即可將所有請求經由 Tor 網路（SOCKS5 或 HTTP 代理）傳送，防止你的 IP 位址被暴露。伺服器預設即安全，若代理連線失敗，**絕不**洩漏你的 IP。
-   **🔎 單一與多重化合物搜尋**：可輕鬆處理一次查詢一個或多個化合物的需求。
-   **🧪 詳細性質擷取**：可存取重要化學性質，如 IUPAC 名稱、分子式、分子量，以及極為重要的**單同位素質量**。

---

---

### 🚀 無需安裝：在 Smithery.ai 線上試用

若你是 MCP 伺服器新手，或只想在本地無需安裝即可測試本工具，Smithery.ai 提供即時託管版，讓你可直接於瀏覽器與代理人對話。

[**<-- 在 Smithery.ai 體驗線上 PubChem Agent -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**開始使用方法：**

1.  點選上方連結前往伺服器頁面。
2.  使用你的 **GitHub** 或 **Google** 帳號登入。
3.  點選 **「探索功能」**按鈕，開啟聊天介面並開始測試！

> **✅ 最佳效果推薦模型**
>
> 為獲得最高精準度，特別是處理長小數點數時，強烈建議使用高效能模型。以下模型已實測，與本工具表現極佳：
>
> *   **Anthropic 的 Claude 3 Sonnet**

> *   **OpenAI 的 GPT-4 Turbo**（或更新版本如 GPT-4o）
>
> 我們已確認這兩個模型都能正確處理工具返回的十進位數字的完整精度，未出現任何四捨五入。

---

## 🚀 快速開始與安裝

此伺服器設計為本地運行，可在您的桌面或 AnythingLLM 的 Docker 環境中執行。

### 1. 相依套件

此專案依賴幾個 Python 套件，請確保它們已安裝於您的環境中。

建立一個 `requirements.txt` 檔案，內容如下：
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```
使用 `uv` 或 `pip` 安裝它們：

```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(注意：僅當您打算使用 Tor SOCKS5 代理功能時才需要安裝 `PySocks`。)*

### 2. 設定

伺服器透過一個 `config.ini` 檔案進行設定，該檔案會在您第一次執行時**自動建立**。這個檔案會出現在與 `pubchem_server.py` 腳本相同的目錄下。

**預設的 `config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. 與 AnythingLLM 的整合

請依照官方文件將此作為自訂 MCP 伺服器新增。重點是將 `command` 指向你的 Python 執行檔以及 `pubchem_server.py` 腳本。

**AnythingLLM 桌面版範例（`plugins/anythingllm_mcp_servers.json`）：**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```
### 3.1 使用 AnythingLLM 的實作範例

以下是一些與代理互動的範例。這些測試是使用 AnythingLLM Desktop 進行的，並透過 OpenRouter 連接到各種大型語言模型。

我們測試中的一個重要發現是所選模型的重要性。我們**強烈不建議使用小型或本地模型**來執行此任務。小型模型通常難以正確解析工具回傳的資料，容易產生錯誤，例如幻覺值、格式錯誤，或更嚴重的是**將小數點數值四捨五入**，這會破壞高精度工具的設計初衷。

為了確保結果的完整性，建議您始終驗證 MCP 回傳的原始數據。您可以在下一節學習如何操作：[3.2 如何在日誌中驗證 MCP 輸出](#32-how-to-verify-mcp-outputs-in-the-logs)。

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

另一方面，有幾款模型展現了極佳的表現。我們在 **Google 的 `Gemini 2.5 Flash lite`** 上取得了傑出成果，其在處理長小數點數字與最終 Markdown 表格格式化上展現了卓越精度。

Google gemini 2.5 flash lite 無提示與有提示時皆能完美保留小數（在範例中使用 0.6 的 temperature）

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

針對此項任務，我個人最推薦的是 **`Gemini 2.5 Flash lite`**，因為它在準確性和可靠性上持續表現優異。

### 3.2 如何在日誌中驗證 MCP 輸出

確認代理接收到正確資料以及 LLM 未發生錯誤的最佳方式，是檢查 MCP 伺服器所產生的除錯日誌檔案。

該伺服器已設定會在您的專案目錄下的子資料夾自動建立日誌檔案。其位置如下：



```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

在 `mcp_debug.log` 中，你將找到該工具在模型處理前回傳給 LLM 的完整 JSON 資料。你可以手動檢查此 JSON，以驗證任何數值，尤其是像 `monoisotopic_mass` 這類屬性中的長小數點數，確保 LLM 在最終答案中未引入任何四捨五入錯誤或幻覺。

---

## 📊 使用方式

整合後，當詢問化學資訊時，你的 AI 助理會自動使用此工具。主要開放的工具為 `search_compounds_by_name`。

### 範例提示

此提示展示了工具處理具有不同名稱類型的化合物列表並擷取多個屬性的能力。

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```
代理會呼叫 `search_compounds_by_name` 工具，該工具會智能地尋找每個化合物，擷取其資料，並將其回傳給 LLM 進行格式化。

---

## 🛠 MCP 工具公開

### `search_compounds_by_name`

使用智能後備策略，逐一搜尋多個化合物名稱，並採用暫停和重試機制以確保最大可靠性。

**參數：**
-   `names` (List[str]): 化合物名稱列表。範例：`["Aspirin", "Ibuprofen"]`

**回傳：** 一個字典列表，每個字典包含找到的化合物資訊，或是詳細說明該特定化合物搜尋失敗原因的錯誤訊息。

---

## 🙏 致謝

本專案大量受到原始 [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) 之啟發，該專案由 **JackKuo666** 創建。

儘管本倉庫並非直接分支，原始專案仍是關鍵的起點。此版本在原理念上加以強化，著重極致強韌性、智能搜尋策略，以及透過選用 Tor 整合 🧅 來保障用戶隱私。

感謝原作者的卓越貢獻，並將成果分享給社群。

---

## ⚠️ 免責聲明

本工具僅供研究與教育用途。請尊重 PubChem 的服務條款並負責任地使用本工具。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---