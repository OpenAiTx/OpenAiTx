## 新功能：使用 Gemini 閱讀，使用 Claude 編輯 + 差異比較

<div align="center">
  <img width="400" alt="2025-07-13 07 09 45 截圖"
       src="https://github.com/user-attachments/assets/5fccba53-71ce-4546-8aed-b1095c5a1ca8" />
</div>

---

> **注意：**  
> - 如果您的 Gemini CLI 安裝已包含其他 MCP 工具，它們可能會與 gemini-mcp-tool 發生互動，導致衝突或當這些 MCP 直接寫入 stdout 時產生意外的控制台輸出。  
> - 您可以透過讓 Gemini 自我呼叫來巢狀提示（例如，`ask gemini to ask gemini`），但若請求超出配額，它不會自動回退。  
> - 若要使用更快且成本較低的 flash 模型，請在命令後加上 `flash`（例如，`... using flash ...`）。

> 🚀 **分享您的使用心得！** [告訴我們您的經驗](https://github.com/jamubc/gemini-mcp-tool/discussions/2) 並協助社群成長！

> 📚 [維基文件](https://github.com/jamubc/gemini-mcp-tool/wiki) 提供更多指南與範例。  
>  
> 貢獻框架目前正在測試中。我們的目標是利用 Gemini 創建 gemini-mcp-tool 擴充功能，自動化工具創建，並提供基於 TUI 的工具生成器。

# Gemini MCP 工具

<div align="center">

[![GitHub 發行版本](https://img.shields.io/github/v/release/jamubc/gemini-mcp-tool?logo=github&label=GitHub)](https://github.com/jamubc/gemini-mcp-tool/releases)
[![npm 版本](https://img.shields.io/npm/v/gemini-mcp-tool)](https://www.npmjs.com/package/gemini-mcp-tool)
[![npm 下載次數](https://img.shields.io/npm/dt/gemini-mcp-tool)](https://www.npmjs.com/package/gemini-mcp-tool)
[![授權：MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![開源專案](https://img.shields.io/badge/Open%20Source-❤️-red.svg)](https://github.com/jamubc/gemini-mcp-tool)

</div>

<a href="https://glama.ai/mcp/servers/@jamubc/gemini-mcp-tool">
  <img width="380" height="200" src="https://glama.ai/mcp/servers/@jamubc/gemini-mcp-tool/badge" alt="Gemini 工具 MCP 伺服器" />
</a>

> 📚 **[查看完整文件](https://jamubc.github.io/gemini-mcp-tool/)** - 搜尋我！、範例、常見問題、疑難排解、最佳實踐

這是一個簡單的模型上下文協定（MCP）伺服器，允許 AI 助手與 [Gemini CLI](https://github.com/google-gemini/gemini-cli) 互動。它使 AI 能夠利用 Gemini 巨大 token 視窗的強大功能進行大型分析，特別是針對使用 `@` 語法指示的大型檔案和程式碼庫。

## 簡述： [![Claude](https://img.shields.io/badge/Claude-D97757?logo=claude&logoColor=fff)](#) + [![Google Gemini](https://img.shields.io/badge/Google%20Gemini-886FBF?logo=googlegemini&logoColor=fff)](#)

**目標**：直接在 Claude Code 中使用 Gemini 強大的分析能力，以節省 token 並分析大型檔案。

### 一行設定



```bash
claude mcp add gemini-cli -- npx -y gemini-mcp-tool
```
### 驗證安裝

在 Claude Code 中輸入 `/mcp` 以驗證 gemini-cli MCP 是否啟動。

---

### 替代方案：從 Claude 桌面版匯入

如果您已在 Claude 桌面版中設定：

1. 新增至您的 Claude 桌面版設定：

```json
"gemini-cli": {
  "command": "npx",
  "args": ["-y", "gemini-mcp-tool"]
}
```
2. 匯入至 Claude 程式碼：

```bash
claude mcp add-from-claude-desktop
```
## 先決條件

在使用此工具之前，請確保您已具備：

1. **[Node.js](https://nodejs.org/)**（版本16.0.0或更高）
2. **[Google Gemini CLI](https://github.com/google-gemini/gemini-cli)** 已安裝並配置

## 安裝選項

### 選項1：NPX（推薦）
無需安裝 - 工具可直接透過 `npx` 執行。

### 選項2：全域安裝

```bash
npm install -g gemini-mcp-tool
```
## 配置

使用您的 MCP 客戶端註冊 MCP 伺服器：

### NPX 使用方式（推薦）

將此配置添加到您的 Claude Desktop 配置文件中：


```json
{
  "mcpServers": {
    "gemini-cli": {
      "command": "npx",
      "args": ["-y", "gemini-mcp-tool"]
    }
  }
}
```
### 全域安裝使用

如果您是全域安裝，請改用此設定：


```json
{
  "mcpServers": {
    "gemini-cli": {
      "command": "gemini-mcp"
    }
  }
}
```
**設定檔位置：**

- **Claude 桌面版**：
  - **macOS**：`~/Library/Application Support/Claude/claude_desktop_config.json`
  - **Windows**：`%APPDATA%\Claude\claude_desktop_config.json`
  - **Linux**：`~/.config/claude/claude_desktop_config.json`

更新設定後，請重新啟動終端機會話。

## 可用指令

- **自然語言**： "use gemini to explain index.html", "understand the massive project using gemini", "ask gemini to search for latest news"
- **Claude 程式碼**：輸入 `/gemini-cli`，指令會出現在 Claude 程式碼介面中。

## 使用範例

### 使用檔案參考（使用 @ 語法）

- `ask gemini to analyze @src/main.js and explain what it does`
- `use gemini to summarize @. the current directory`
- `analyze @package.json and tell me about dependencies`

### 一般問題（無檔案）

- `ask gemini to search for the latest tech news`
- `use gemini to explain div centering`
- `ask gemini about best practices for React development related to @file_im_confused_about`

### 使用 Gemini CLI 的 Sandbox 模式 (-s)

Sandbox 模式讓你能在隔離環境中安全測試程式碼變更、執行腳本或執行可能有風險的操作。

- `use gemini sandbox to create and run a Python script that processes data`
- `ask gemini to safely test @script.py and explain what it does`
- `use gemini sandbox to install numpy and create a data visualization`
- `test this code safely: Create a script that makes HTTP requests to an API`

### 工具（供 AI 使用）

這些工具設計供 AI 助手使用。

- **`ask-gemini`**：向 Google Gemini 詢問觀點。可用於一般問題或檔案的複雜分析。
  - **`prompt`**（必填）：分析請求。使用 `@` 語法包含檔案或目錄參考（例如 `@src/main.js explain this code`），或詢問一般問題（例如 `Please use a web search to find the latest news stories`）。
  - **`model`**（選填）：使用的 Gemini 模型。預設為 `gemini-2.5-flash`。
  - **`sandbox`**（選填）：設為 `true` 以啟用 sandbox 模式，安全執行程式碼。
- **`sandbox-test`**：在 Gemini 的 sandbox 環境安全執行程式碼或指令。始終以 sandbox 模式執行。
  - **`prompt`**（必填）：程式碼測試請求（例如 `Create and run a Python script that...` 或 `@script.py Run this safely`）。
  - **`model`**（選填）：使用的 Gemini 模型。
- **`Ping`**：簡單的測試工具，回傳訊息。
- **`Help`**：顯示 Gemini CLI 的說明文字。

### 斜線指令（供使用者）

你可以直接在 Claude 程式碼介面中使用這些指令（尚未測試其他客戶端的相容性）。

- **/analyze**：使用 Gemini 分析檔案或目錄，或詢問一般問題。
  - **`prompt`**（必填）：分析提示。使用 `@` 語法包含檔案（例如 `/analyze prompt:@src/ summarize this directory`）或詢問一般問題（例如 `/analyze prompt:Please use a web search to find the latest news stories`）。
- **/sandbox**：在 Gemini 的 sandbox 環境中安全測試程式碼或腳本。
  - **`prompt`**（必填）：程式碼測試請求（例如 `/sandbox prompt:Create and run a Python script that processes CSV data` 或 `/sandbox prompt:@script.py Test this script safely`）。
- **/help**：顯示 Gemini CLI 的說明資訊。
- **/ping**：測試與伺服器的連線。
  - **`message`**（選填）：回傳的訊息。

## 貢獻

歡迎貢獻！請參閱我們的[貢獻指南](https://raw.githubusercontent.com/jamubc/gemini-mcp-tool/main/CONTRIBUTING.md)了解如何提交 Pull Request、回報問題及參與專案。

## 授權條款

本專案採用 MIT 授權條款。詳細資訊請參閱 [LICENSE](LICENSE) 檔案。

**免責聲明：** 這是非官方第三方工具，與 Google 無關，亦未獲 Google 認可或贊助。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---