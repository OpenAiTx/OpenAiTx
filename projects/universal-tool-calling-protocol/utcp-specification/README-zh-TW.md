# 通用工具調用協議（UTCP）規範

本儲存庫包含通用工具調用協議（UTCP）的官方規範文件。UTCP 是一個現代化、靈活且可擴展的標準，用於跨不同通信協議定義與交互工具。

## 什麼是 UTCP？

UTCP 為 AI 系統及其他客戶端提供了一種標準化方式，可從不同供應商發現並調用工具，無論使用的是何種底層協議（HTTP、WebSocket、CLI 等）。此規範定義了：

- 工具發現機制
- 工具調用格式
- 供應商配置
- 驗證方法
- 回應處理

## 參與規範貢獻

我們歡迎對 UTCP 規範的貢獻！您可以這樣參與：

1. **Fork 此儲存庫**：建立您自己的規範儲存庫分支
2. **進行修改**：根據需要更新或新增文件
3. **提交拉取請求**：開啟 PR 提交您的更改以供審查
4. **參與討論**：加入對建議更改的討論

貢獻時，請遵循以下指南：

- 確保您的更改與 UTCP 的整體願景和目標一致
- 遵循既定的文件結構和格式
- 在新增功能或概念時附上範例
- 更新相關章節以保持文件一致性

## 在本地構建文件

### 先決條件

要在本地構建和預覽文件網站，您需要：

- Ruby 2.5.0 或更高版本
- RubyGems
- Bundler

### 設定

1. 複製此儲存庫：
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. 安裝相依套件：

   ```bash
   bundle install
   ```
### 執行文件網站

要在本地建置並啟動網站：


```bash
bundle exec jekyll serve
```
這將會在 `http://localhost:4000` 啟動一個本地網頁伺服器，你可以在此預覽文件。

## 文件結構

UTCP 文件的組織方式如下：

- `index.md`：UTCP 首頁與簡介
- `docs/`
  - `introduction.md`：詳細介紹與核心概念
  - `for-tool-providers.md`：工具提供者實作指南
  - `for-tool-callers.md`：工具呼叫者實作指南
  - `providers/`：各類提供者的文件
    - `http.md`：HTTP 提供者
    - `websocket.md`：WebSocket 提供者
    - `cli.md`：CLI 提供者
    - `sse.md`：伺服器推送事件（SSE）提供者
    - 等等
  - `implementation.md`：實作指引與最佳實踐

## 規範作業方式

### 修改文件

文件以 Markdown 格式及 Jekyll 前置資料編寫。進行修改時：

1. 確保你的 Markdown 遵循既定風格
2. 提交 PR 前請先在本地預覽變更
3. 例子需與最新規範保持同步
4. 如新增頁面，請更新 `_config.yml` 中的導覽項目

### 檔案組織

新增文件時：

- 請將特定提供者的文件放在 `docs/providers/` 目錄下
- 使用一致的前置資料並適當排序於導覽中
- 加入標籤以提升 GitHub Pages 搜尋性

## 版本控制

UTCP 規範遵循語意化版本控制：

- 主版本（1.0、2.0）：協議有破壞性變更
- 次版本（1.1、1.2）：向下相容的新功能
- 修補版本（1.0.1、1.0.2）：向下相容的錯誤修正與說明

## 授權條款

本規範依 Mozilla Public License 2.0（MPL-2.0）發佈。

## 其他資源

- [UTCP GitHub 組織](https://github.com/universal-tool-calling-protocol)
- [UTCP 官方網站](https://utcp.io)
- [參考實作](https://github.com/universal-tool-calling-protocol/python-utcp)
- [社群討論區](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---