
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Claude Code 以 bash 腳本重寫。約 1,500 行。完全不使用 npm 套件。

## 為什麼

原始 Claude Code 有約 380,000 行 TypeScript 和 266 個 npm 依賴。本專案以 bash 實現相同核心功能，只需 `curl` 與 `jq`。

## 功能

- **即時串流**透過 FIFO 管道 — 文字會隨 Claude 生成即時顯示
- **6 種工具**：Bash、Read、Edit、Write、Glob、Grep
- **工具鏈結** — 每回合最多可串連 25 次工具呼叫
- **權限提示** — 執行非安全指令前會詢問 (`y/n/a`)
- **CLAUDE.md 載入** — 可從目錄樹上層讀取 CLAUDE.md 的專案指示
- **Git 感知上下文** — 在系統提示中包含分支、狀態與近期提交
- **會話儲存/恢復** — 離開時自動儲存，使用 `--resume <id>` 恢復
- **退避重試** — 針對 429/529 限流錯誤進行指數型退避重試
- **成本追蹤** — 每回合及整個會話的總成本
- **轉圈動畫** — 使用原創轉圈動詞（Clauding、Flibbertigibbeting 等）
- **斜線指令** — `/help`、`/cost`、`/model`、`/clear`、`/save`、`/resume`、`/commit`、`/diff`
- **管道模式** — `echo "explain this" | ./claude.sh`

## 安裝

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## 依賴項

- `curl`
- `jq`
- 選用：`rg`（ripgrep）用於更好的搜尋
- 選用：`python3` 用於編輯工具

執行時版本已固定於 `.tool-versions`。請使用 [mise](https://mise.jdx.dev/) 安裝：

```bash
mise install
```

## 使用方法

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### 環境變數

| 變數 | 預設值 | 說明 |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | （必填） | 您的 Anthropic API 金鑰 |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | 使用的模型 |
| `CLAUDE_MAX_TOKENS` | `8192` | 最大輸出字元數 |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | API 基礎網址 |
| `CLAUDE_SH_PERMISSIONS` | `ask` | 權限模式：`ask`、`allow` 或 `deny` |

### 指令

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### 恢復工作階段

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## 架構

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## 工作原理

1. 讀取使用者輸入
2. 使用 `jq` 建立 JSON 請求（訊息、工具、系統提示）
3. 透過 FIFO 管道以 `curl` 串流回應
4. 逐行解析 SSE 事件，實時列印文字增量
5. 當 tool_use 區塊抵達時，執行工具
6. 將工具結果回饋為訊息
7. 迴圈直到 Claude 停止呼叫工具

## 比較

| | claude.sh | Claude Code（TypeScript） |
| --- | --- | --- |
| 程式碼行數 | 約 1,500 | 約 380,000 |
| 相依套件 | curl, jq | 266 個 npm 套件 |
| 二進位檔大小 | 0（腳本） | 約 200MB node_modules |
| 啟動時間 | 即時 | 約 500ms |

### 測試

測試使用 [bats](https://github.com/bats-core/bats-core)（Bash 自動化測試系統）：

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---