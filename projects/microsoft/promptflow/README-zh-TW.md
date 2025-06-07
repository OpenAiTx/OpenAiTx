# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> 歡迎加入我們，通過參與[討論](https://github.com/microsoft/promptflow/discussions)、提交[問題](https://github.com/microsoft/promptflow/issues/new/choose)、貢獻[PRs](https://github.com/microsoft/promptflow/pulls)來讓 prompt flow 變得更好。

**Prompt flow** 是一套開發工具，旨在簡化以 LLM 為基礎的 AI 應用的端到端開發週期，從構思、原型設計、測試、評估，到生產部署與監控。它大幅簡化了提示工程（prompt engineering）流程，讓你能建立具備生產等級品質的 LLM 應用。

使用 prompt flow，你將能：

- **創建並反覆開發 flow**
    - 創建可執行的 [flow](https://microsoft.github.io/promptflow/concepts/concept-flows.html)，將 LLM、prompts、Python 程式碼及其他[工具](https://microsoft.github.io/promptflow/concepts/concept-tools.html)串接起來。
    - 除錯並反覆優化你的 flow，特別是[追蹤 LLM 互動](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html)更加輕鬆。
- **評估 flow 的品質與效能**
    - 使用大規模資料集評估 flow 的品質與效能。
    - 將測試與評估流程整合進 CI/CD 系統，確保 flow 品質。
- **為生產環境優化的開發週期**
    - 將 flow 部署到你選擇的服務平台，或輕鬆整合進應用程式程式碼庫。
    - （可選但強烈建議）透過雲端版 [Azure AI 上的 Prompt flow](https://learn.microsoft.com/zh-tw/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2) 與團隊協作。

------

## 安裝

要快速開始，你可以使用預建的開發環境。**點擊下方按鈕**，在 GitHub Codespaces 開啟此倉庫，然後繼續閱讀說明文件！

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

如果你想在本地環境開始，請先安裝套件：

請確保你有 Python 環境，建議版本為 `python>=3.9, <=3.11`。

```sh
pip install promptflow promptflow-tools
```

## 快速開始 ⚡

**使用 prompt flow 建立聊天機器人**

執行指令，從聊天範本初始化一個 prompt flow，會建立名為 `my_chatbot` 的資料夾並產生所需檔案：

```sh
pf flow init --flow ./my_chatbot --type chat
```

**設定 API 金鑰連線**

若使用 OpenAI 金鑰，請執行以下指令建立連線，使用 `my_chatbot` 資料夾中的 `openai.yaml` 檔案儲存你的 OpenAI 金鑰（可用 --set 覆蓋金鑰與名稱，以避免變動 yaml 檔案）：

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

若使用 Azure OpenAI 金鑰，請執行以下指令並使用 `azure_openai.yaml` 檔案：

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**與你的 flow 互動聊天**

在 `my_chatbot` 資料夾中，有個 `flow.dag.yaml` 檔案，描述了 flow 的結構，包括輸入/輸出、節點、連線與 LLM 模型等。

> 請注意，在 `chat` 節點中，我們使用名為 `open_ai_connection` 的連線（於 `connection` 欄位指定），以及 `gpt-35-turbo` 模型（於 `deployment_name` 欄位指定）。`deployment_name` 用於指定 OpenAI 模型或 Azure OpenAI 的部署資源。

執行以下指令與聊天機器人互動：（按 `Ctrl + C` 結束會話）

```sh
pf flow test --flow ./my_chatbot --interactive
```

**核心價值：從原型到生產確保「高品質」**

探索我們的[**15 分鐘教學**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md)，引導你進行提示調校 ➡ 批量測試 ➡ 評估，確保達到生產等級的高品質。

下一步！繼續閱讀 **教學** 👇 章節，深入了解 prompt flow。

## 教學 🏃‍♂️

Prompt flow 是一款用於**打造高品質 LLM 應用**的工具，其開發流程包含：開發 flow、提升 flow 品質、將 flow 部署至生產環境。

### 開發你自己的 LLM 應用

#### VS Code 擴充套件

我們也提供 VS Code 擴充套件（flow 設計器），可讓你以 UI 互動式體驗 flow 開發。

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

你可以從<a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">visualstudio marketplace</a> 安裝。

#### 深入了解 flow 開發

[快速開始 prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md)：逐步指引你執行第一次 flow。

### 從應用案例學習

[教學：與 PDF 聊天](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/e2e-development/chat-with-pdf.md)：完整教學如何用 prompt flow 打造高品質聊天應用，包括 flow 開發及指標化評估。
> 更多範例可見於[這裡](https://microsoft.github.io/promptflow/tutorials/index.html#samples)。歡迎貢獻新的應用案例！

### 貢獻者設定

有興趣貢獻的話，請參考我們的開發環境設定指南：[dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md)。

下一步！繼續閱讀 **貢獻**👇 章節，參與 prompt flow 貢獻。

## 貢獻

本專案歡迎各種貢獻與建議。大多數貢獻需你同意一份貢獻者授權協議（CLA），聲明你有權並實際授權我們使用你的貢獻。詳情請見 https://cla.opensource.microsoft.com。

當你提交 Pull Request 時，CLA 機器人會自動判斷你是否需要提供 CLA，並適當標註 PR（例如狀態檢查、留言說明）。請依照機器人指示操作。所有使用我們 CLA 的倉庫只需做一次。

本專案已採用 [Microsoft 開源行為準則](https://opensource.microsoft.com/codeofconduct/)。更多資訊請見[行為準則 FAQ](https://opensource.microsoft.com/codeofconduct/faq/)或聯繫 [opencode@microsoft.com](mailto:opencode@microsoft.com)。

## 商標

本專案可能包含專案、產品或服務的商標或標誌。經授權使用 Microsoft 商標或標誌需遵守並符合
[Microsoft 商標與品牌指南](https://www.microsoft.com/zh-tw/legal/intellectualproperty/trademarks/usage/general)。
在本專案的修改版本中使用 Microsoft 商標或標誌不得造成混淆或暗示 Microsoft 贊助。
任何第三方商標或標誌的使用均須遵守該第三方政策。

## 行為準則

本專案已採用
[Microsoft 開源行為準則](https://opensource.microsoft.com/codeofconduct/)。
如需更多資訊，請參閱
[行為準則 FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
或聯繫 [opencode@microsoft.com](mailto:opencode@microsoft.com)
有任何進一步問題或意見。

## 資料收集

本軟體在啟用遙測（telemetry）時，可能收集有關你及你的使用資訊並傳送至 Microsoft。
Microsoft 可能會利用這些資訊來提供服務並改進我們的產品與服務。
你可依據本倉庫說明設定是否啟用遙測。
此外，軟體中也可能有功能可讓你與 Microsoft 蒐集應用程式使用者的資料。若你使用這些功能，
你必須遵守相關法律，包括向應用程式使用者提供適當通知，並附上 Microsoft 隱私權聲明副本。
我們的隱私權聲明位於 https://go.microsoft.com/fwlink/?LinkID=824704。你可在說明文件及隱私權聲明中了解更多資料收集與使用方式。你使用本軟體即表示同意這些做法。

### 遙測設定

遙測預設為啟用。

若要停用，請執行 `pf config set telemetry.enabled=false` 關閉。

## 授權

Copyright (c) Microsoft Corporation. All rights reserved.

依 [MIT](LICENSE) 授權條款授權。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---