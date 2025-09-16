# mcp-chat

<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

開源通用 MCP 用戶端，用於測試與評估 mcp 伺服器及代理

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>


## 快速入門

請確保已將 `ANTHROPIC_API_KEY` 匯出至您的環境變數，或是在專案根目錄的 .env 檔案中設定。您可以在 [Anthropic 控制台金鑰頁面](https://console.anthropic.com/settings/keys) 註冊以取得 API 金鑰。

以下是一個簡單範例，從 CLI 啟動與檔案系統 MCP 伺服器的互動式聊天提示：

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

這將會開啟一個聊天提示，您可以用來與伺服器互動並與 LLM 聊天。

## 設定

您也可以直接指定您的 claude_desktop_config.json（Mac）：

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

或（Windows）：

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```
在網頁模式下，您可以開始新的聊天、向模型發送訊息，並可透過 UI 動態配置 mcp 伺服器——無需在命令列中指定。此外，透過 Web UI 建立的聊天也會儲存至 ~/.mcpchats/chats，與 CLI 建立的聊天方式相同。

## 功能特色

- [x] 透過 CLI 以互動模式運行，或直接使用 `-p` 傳送提示詞
- [x] 網頁模式，透過網頁介面與模型對話 `--web`
- [x] 可連線至任何 MCP 伺服器（JS、Python、Docker），無論是正式環境或開發期間
- [x] 可使用 `-m` 選擇不同模型
- [x] 使用 `--system` 自訂系統提示詞
- [x] 聊天記錄及設定儲存於 `~/.mcpchat/chats`，包含網頁聊天
- [x] 指令儲存與還原於 `~/.mcpchat/history`
- [x] 在聊天中直接查看工具呼叫結果與參數，協助偵錯 mcp 伺服器

## CLI 使用方式

使用 `-p` 旗標透過 CLI 傳送提示詞：


```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

這會在 kubernetes mcp-server 上執行提示，並在收到回應後從標準輸出退出。

使用 `-m` 旗標選擇要在 CLI 上聊天的模型：

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

使用模型 `claude-3.5` 進行聊天。請注意，目前僅支援 Anthropic 的模型。

自訂系統提示：

可以使用 `--system` 旗標來指定系統提示：

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## 環境變數

Mcp-chat 支援將環境變數傳遞給 mcp 伺服器。不過，這在 mcp 規範中並未標準化，其他客戶端也可能不會使用動態環境變數值——請參考[這裡](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) 以了解標準 stdio mcp 客戶端的更多資訊。

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## 給 mcp-servers 開發人員

您可以傳入本地建置的 python 或 node mcp-server，以便與 mcp-chat 進行測試：

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python：

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## 開發

安裝依賴項並執行 CLI：

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```
要在連接到 mcp-server 的同時開發 mcp-chat，請進行建置並使用 server 參數運行 CLI：


```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

測試：

```shell
bun run test
```
建築：


```shell
bun run build
```
發佈：


```shell
bun run publish
```

發布 Docker：

```shell
bun run dockerbuild
```

### 專案結構

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## 發佈新版本

前往 [releases](https://github.com/Flux159/mcp-chat/releases) 頁面，點擊「Draft New Release」，點擊「Choose a tag」並透過輸入新版本號（使用 "v{major}.{minor}.{patch}" semver 格式）來建立新標籤。然後，寫上發佈標題 "Release v{major}.{minor}.{patch}"，並在必要時填寫說明 / 更新日誌，最後點擊「Publish Release」。

這將建立一個新標籤，並透過 cd.yml 工作流程觸發新的發佈建構。成功後，新的版本將會發佈到 npm。請注意，不需要手動更新 package.json 版本號，因為工作流程會自動更新 package.json 中的版本號並推送提交到 main。

## 授權條款

[MIT 授權條款](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---