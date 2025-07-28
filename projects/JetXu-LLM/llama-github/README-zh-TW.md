
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[詳細文件] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI 版本](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![下載量](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![授權](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github 是一個強大的工具，可協助你根據查詢（基於 Agentic RAG）從 GitHub 檢索最相關的程式碼片段、議題和倉庫資訊，並將其轉化為有價值的知識上下文。它賦能 LLM 聊天機器人、AI 代理與自動開發代理，協助解決複雜的編碼任務。無論你是尋求快速解決方案的開發者，還是實現先進自動開發 AI 代理的工程師，llama-github 都能讓流程更簡單高效。

如果你喜歡這個專案或認為它具有潛力，請給我們一個 ⭐️。你的支持是我們最大的動力！

## 架構
![高階架構圖](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## 安裝
```
pip install llama-github
```

## 使用方法

以下是一個如何使用 llama-github 的簡單範例：

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
如需更進階的用法與範例，請參閱[文件說明](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md)。

## 主要特色

- **🔍 智慧型 GitHub 擷取**：利用 llama-github 的強大功能，根據使用者查詢自 GitHub 擷取高度相關的程式碼片段、議題與倉庫資訊。我們先進的擷取技術能讓您迅速且高效地找到最相關的資訊。

- **⚡ 倉庫池快取**：Llama-github 採用創新性的倉庫池快取機制。透過跨執行緒快取倉庫（包括 README、結構、程式碼及議題），llama-github 顯著加快 GitHub 搜尋擷取效率並大幅減少 GitHub API token 的消耗。您可以放心在多執行緒生產環境中部署 llama-github，確保最佳效能並節省寶貴資源。

- **🧠 LLM 驅動的問題分析**：運用最先進的語言模型分析使用者問題，並產生高效的搜尋策略與條件。llama-github 能智慧地拆解複雜查詢，確保從龐大的 GitHub 倉庫網絡中擷取最相關的資訊。

- **📚 完整的上下文生成**：透過結合自 GitHub 擷取的資訊與先進語言模型的推理能力，生成豐富且具情境相關性的答案。llama-github 擅長處理最複雜與冗長的問題，提供詳盡且具洞見的回應，包含完整上下文以支援您的開發需求。

- **🚀 卓越的非同步處理**：llama-github 從零開始建構以充分發揮非同步程式設計的潛力。細緻實作的非同步機制貫穿整個程式碼庫，使 llama-github 能同時處理多個請求，大幅提升整體效能。讓您體驗 llama-github 在高負載下依然高效管理請求，速度與品質兼具。

- **🔧 彈性的 LLM 整合**：可輕鬆將 llama-github 與各種 LLM 供應商、嵌入模型及重排序模型整合，根據您的特定需求調整函式庫功能。我們的可擴充架構讓您自訂並提升 llama-github 的功能，確保其能無縫適應您獨特的開發環境。

- **🔒 強健的認證選項**：llama-github 支援個人存取權杖與 GitHub App 認證，為您提供整合至不同開發環境的彈性。不論您是個人開發者還是組織內部使用者，llama-github 都能以安全且可靠的認證機制滿足您的需求。

- **🛠️ 日誌與錯誤處理**：我們了解順暢運作與便捷除錯的重要性。llama-github 內建完整的日誌與錯誤處理機制，讓您深入了解函式庫行為、快速診斷問題，並維持穩定可靠的開發流程。

## 🤖 試用我們的 AI PR 審查助理：LlamaPReview

如果您覺得 llama-github 有幫助，也歡迎體驗我們的 AI GitHub PR 審查助理 LlamaPReview。它專為輔助您的開發流程設計，進一步提升程式碼品質。

### LlamaPReview 的主要功能：
- 🚀 一鍵安裝，零設定，自動運行
- 💯 目前免費使用－無需信用卡或付款資訊
- 🧠 AI 驅動，自動 PR 審查，深度理解程式碼
- 🌐 支援多種程式語言

**LlamaPReview 結合 llama-github 的先進上下文擷取與 LLM 驅動分析**，提供智慧且具情境感知的程式碼審查。就像有一位資深開發者，帶著您完整倉庫脈絡，為每個 PR 自動審查！

👉 [立即安裝 LlamaPReview](https://github.com/marketplace/llamapreview/)（免費）

結合 llama-github 的上下文擷取及 LlamaPReview 的程式碼審查，您能打造強大且 AI 強化的開發環境。

## 願景與發展藍圖

### 願景

我們的願景是成為未來 AI 驅動開發解決方案的重要模組，無縫整合 GitHub，協助 LLM 自動解決複雜的程式設計任務。

![願景架構](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### 發展藍圖

如需檢視我們專案的詳細藍圖，請參閱[專案藍圖](https://github.com/users/JetXu-LLM/projects/2)。

## 鳴謝

我們感謝以下開源專案的支持與貢獻：

- **[LangChain](https://github.com/langchain-ai/langchain)**：為 llama-github 提供 LLM 提示與處理能力的基礎架構。
- **[Jina.ai](https://github.com/jina-ai/reader)**：提供 s.jina.ai API 及開源重排序與嵌入模型，提升 llama-github 生成上下文的準確性與相關性。

他們的貢獻對 llama-github 的開發至關重要，我們強烈推薦您參考他們的專案，尋找更多創新解決方案。

## 貢獻指南

歡迎貢獻 llama-github！請參閱我們的[貢獻指南](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md)以獲取更多資訊。

## 授權

本專案依據 Apache 2.0 授權條款發布。詳情請參閱 [LICENSE](LICENSE) 檔案。

## 聯絡方式

如有任何疑問、建議或回饋，歡迎透過[Jet Xu 的電子郵件](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com)與我們聯繫。

---

感謝您選擇 llama-github！我們希望此函式庫能提升您的 AI 開發體驗，協助您輕鬆打造強大應用程式。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---