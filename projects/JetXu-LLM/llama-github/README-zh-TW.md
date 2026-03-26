
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">簡體中文</a>
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
      </div>
    </div>
  </details>
</div>

# llama-github

[詳細文件] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI 版本](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![下載次數](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![授權條款](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github 是一個強大的工具，能夠根據您的查詢，通過 Agentic RAG 技術，從 GitHub 檢索最相關的程式碼片段、議題及倉庫資訊，並將其轉化為有價值的知識內容。它賦能於 LLM 聊天機器人、AI 代理和自動開發代理，協助解決複雜的程式設計任務。無論您是尋找快速解決方案的開發者，還是實作先進自動開發 AI 代理的工程師，llama-github 都能讓您的工作變得簡單高效。
如果你喜歡這個專案或認為它有潛力，請給它一個⭐️。您的支持是我們最大的動力！

## 架構
![高階架構](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## 安裝

```
pip install llama-github
```

目前維護的運行時目標：Python `3.10+`。

## 使用方法

以下是如何使用 llama-github 的簡單範例：

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
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` 會返回一個上下文字典的列表。每個項目至少包含 `context` 和 `url`。

如需更進階的用法和範例，請參閱[文件](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md)。可執行且低成本的範例亦可在 [`examples/`](examples) 找到。

## 主要功能

- **🔍 智能 GitHub 檢索**：利用 llama-github 的強大功能，根據用戶查詢從 GitHub 檢索高度相關的程式碼片段、議題和倉庫資訊。我們的先進檢索技術確保您能快速、高效地找到最重要的資訊。

- **⚡ 倉庫池快取**：Llama-github 擁有創新的倉庫池快取機制。通過跨執行緒快取倉庫（包括 README、結構、程式碼和議題），llama-github 可大幅提升 GitHub 搜尋檢索效率並減少 GitHub API 權杖的消耗。

- **🧠 LLM 驅動的問題分析**：利用最先進的語言模型分析用戶問題，並生成極具效果的搜尋策略與條件。llama-github 能智能拆解複雜查詢，確保您能從 GitHub 廣大倉庫網絡中檢索到最相關的資訊。

- **📚 全面性上下文生成**：通過無縫結合從 GitHub 檢索到的資訊與先進語言模型的推理能力，生成豐富且具上下文關聯性的答案。llama-github 擅長處理最複雜和冗長的問題，提供完整且具洞察力的回應，包含支援開發需求的廣泛上下文。

- **🚀 非同步處理卓越**：llama-github 從零開始即針對非同步程式設計徹底優化。全程實作精密的非同步機制，llama-github 能同時處理多個請求，大幅提升整體效能。

- **🔧 彈性 LLM 整合**：可輕鬆將 llama-github 整合至多種 LLM 供應商、嵌入模型、重排序模型，或注入支援 LangChain 的聊天模型，靈活調整函式庫功能以滿足您的具體需求。

- **🔒 強大認證選項**：llama-github 支援個人存取權杖和 GitHub App 認證，讓您可靈活整合至不同開發場景。無論是個人開發者或組織環境，llama-github 均提供安全可靠的認證機制。

- **🛠️ 日誌與錯誤處理**：我們深知順暢操作與簡易除錯的重要性。llama-github 內建完整的日誌與錯誤處理機制，助您深入瞭解函式庫行為、快速診斷問題，並維持穩定可靠的開發流程。

## 🤖 試用我們的 AI PR 審查助手：LlamaPReview

如果您覺得 llama-github 有幫助，也許會對我們的 AI GitHub PR 審查助手 LlamaPReview 感興趣。它旨在補強您的開發流程，進一步提升程式碼品質。

### LlamaPReview 主要功能：
- 🚀 一鍵安裝，零配置，完全自動運行
- 💯 目前免費使用 — 無需信用卡或付款資料
- 🧠 AI 驅動，具備深層程式理解的自動 PR 審查
- 🌐 支援多種程式語言

**LlamaPReview 採用 llama-github 的先進上下文檢索與 LLM 分析**，提供智能、具上下文意識的程式碼審查。就像一位資深開發者，掌握您倉庫全貌，自動審查每一次 PR！

👉 [立即安裝 LlamaPReview](https://github.com/marketplace/llamapreview/)（免費）

結合 llama-github 進行上下文檢索與 LlamaPReview 進行程式碼審查，您可打造強大且 AI 強化的開發環境。

## 願景與路線圖


### 願景

我們的願景是成為未來以 AI 為驅動的開發解決方案中的關鍵模組，無縫整合至 GitHub，賦能大型語言模型（LLM）自動解決複雜的程式任務。

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### 路線圖

如需查看早期路線圖的歷史版本，請參閱 [Vision and Roadmap](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md)。

## 致謝

我們要感謝以下開源項目對本計畫的支持與貢獻：

- **[LangChain](https://github.com/langchain-ai/langchain)**：為 llama-github 提供支持 LLM 提示與處理能力的基礎框架。
- **[Jina.ai](https://github.com/jina-ai/reader)**：提供 s.jina.ai API 及開源重排序與嵌入模型，提升 llama-github 生成內容的精確度與相關性。

他們的貢獻對於 llama-github 的開發至關重要，我們強烈建議您參考他們的專案以獲得更多創新解決方案。

## 貢獻指南

我們歡迎您對 llama-github 進行貢獻！請參閱我們的 [貢獻指南](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) 以獲得更多資訊。

## 授權

本專案依據 Apache 2.0 授權條款釋出。詳情請參閱 [LICENSE](LICENSE) 文件。

## 聯絡方式

如有任何問題、建議或反饋，歡迎透過 [Jet Xu 的郵件](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com) 與我們聯繫。

---

感謝您選擇 llama-github！我們希望本套件能提升您的 AI 開發體驗，幫助您輕鬆打造強大的應用程式。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---