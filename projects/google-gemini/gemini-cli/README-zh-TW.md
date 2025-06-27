# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI 截圖](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

此儲存庫包含 Gemini CLI，一個命令列 AI 工作流程工具，可連接您的工具、理解您的程式碼並加速您的工作流程。

使用 Gemini CLI，您可以：

- 在 Gemini 的 1M token 上下文視窗內外查詢和編輯大型程式碼庫。
- 利用 Gemini 的多模態功能，從 PDF 或草圖生成新應用程式。
- 自動化操作任務，如查詢 pull request 或處理複雜的 rebase。
- 使用工具和 MCP 伺服器連接新功能，包括[使用 Imagen、Veo 或 Lyria 進行媒體生成](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)。
- 使用內建於 Gemini 的 [Google 搜尋](https://ai.google.dev/gemini-api/docs/grounding) 工具為您的查詢提供依據。

## 快速開始

1. **先決條件：** 請確保您已安裝 [Node.js 18 版](https://nodejs.org/en/download)或更高版本。
2. **執行 CLI：** 在終端機中執行以下命令：

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   或者使用以下方式安裝：

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **選擇顏色主題**
4. **驗證身分：** 根據提示，以您的個人 Google 帳戶登入。這將允許您每分鐘最多 60 次模型請求，以及每天 1,000 次模型請求，使用 Gemini。

您現在已經可以使用 Gemini CLI 了！

### 進階使用或提高限制：

如果您需要使用特定模型或更高的請求容量，可以使用 API 金鑰：

1. 從 [Google AI Studio](https://aistudio.google.com/apikey) 生成一個金鑰。
2. 將其設為終端機的環境變數。請將 `YOUR_API_KEY` 替換為您生成的金鑰。

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

如需其他驗證方式，包括 Google Workspace 帳戶，請參閱[驗證指南](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md)。

## 範例

當 CLI 執行後，您可以直接從 shell 與 Gemini 互動。

您可以從新目錄開始一個專案：

```sh
cd new-project/
gemini
> 幫我寫一個 Gemini Discord 機器人，能根據我提供的 FAQ.md 檔案回答問題
```

或處理現有專案：

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> 給我昨天所有更動的摘要
```

### 下一步

- 學習如何[參與貢獻或從原始碼建構](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md)。
- 探索可用的**[CLI 指令](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**。
- 如果遇到任何問題，請參閱**[疑難排解指南](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**。
- 欲獲得更完整的文件，請參閱[完整文件](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md)。
- 參考一些[熱門任務](#popular-tasks)獲取更多靈感。

### 疑難排解

如果您遇到問題，請前往[疑難排解指南](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)。

## 熱門任務

### 探索新程式碼庫

首先 `cd` 進入現有或新複製的儲存庫並執行 `gemini`。

```text
> 請描述此系統架構的主要組成部分。
```

```text
> 現有的安全機制有哪些？
```

### 處理現有程式碼

```text
> 實作 GitHub issue #123 的初稿。
```

```text
> 幫我將這個程式碼庫移轉到最新版 Java，請先擬定計畫。
```

### 自動化您的工作流程

利用 MCP 伺服器，將本地系統工具與企業協作套件整合。

```text
> 幫我做一份簡報，顯示過去 7 天的 git 歷史，依功能和團隊成員分組。
```

```text
> 製作一個全螢幕網頁應用，展示最常互動的 GitHub issue 以供牆面展示。
```

### 與您的系統互動

```text
> 將此目錄下所有圖片轉為 png，並以 exif 資料中的日期重新命名。
```

```text
> 依支出月份整理我的 PDF 發票。
```

## 服務條款與隱私權聲明

有關您使用 Gemini CLI 適用的服務條款與隱私權聲明，請參閱[服務條款與隱私權聲明](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---