<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="LangChain 標誌" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![發佈說明](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - 授權](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - 下載量](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHub 星標圖](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![未解決問題](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Dev Containers 開啟](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="在 Github Codespace 開啟" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> 尋找 JS/TS 函式庫嗎？請參考 [LangChain.js](https://github.com/langchain-ai/langchainjs)。

LangChain 是一個構建以 LLM 為核心應用的框架。它幫助你將可互操作的組件與第三方整合串連起來，簡化 AI 應用開發流程——同時在底層技術演進時保護你的決策不會過時。

```bash
pip install -U langchain
```

想進一步了解 LangChain，請參閱
[官方文件](https://python.langchain.com/docs/introduction/)。如果你需要更進階的自定義或代理協作，請參考
[LangGraph](https://langchain-ai.github.io/langgraph/)，這是我們用於構建可控代理流程的框架。

## 為什麼要使用 LangChain？

LangChain 透過為模型、嵌入、向量儲存等提供標準介面，協助開發者打造以 LLM 為核心的應用。

使用 LangChain 的場景包括：
- **即時資料增強**。輕鬆連接 LLM 到多樣的資料來源及內外部系統，利用 LangChain 豐富的整合庫，涵蓋模型供應商、工具、向量儲存、檢索器等。
- **模型互通性**。當你的工程團隊在尋找最適合應用需求的模型時，可隨時切換模型。隨著產業前沿不斷演進，LangChain 的抽象設計讓你能快速調整，持續推進而不失動力。

## LangChain 生態系統
LangChain 框架可獨立使用，也能無縫整合至任何 LangChain 產品，為開發者構建 LLM 應用時提供完整工具組。

為提升你的 LLM 應用開發效率，建議搭配：

- [LangSmith](http://www.langchain.com/langsmith) - 有助於代理評估與可觀察性。除錯 LLM 應用執行表現不佳的情況，評估代理軌跡，提升生產環境可視性並隨時間優化效能。
- [LangGraph](https://langchain-ai.github.io/langgraph/) - 透過 LangGraph（我們的低階代理協作框架）打造能可靠處理複雜任務的代理。LangGraph 提供可自訂架構、長期記憶與人機協作流程——LinkedIn、Uber、Klarna 和 GitLab 等公司都已在生產環境中採用。
- [LangGraph 平台](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - 利用專為長時間運行、具狀態流程設計的部署平台，輕鬆部署與擴展代理。跨團隊發現、重用、設定與分享代理，並能在
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/) 中快速進行視覺化原型設計與迭代。

## 其他資源
- [教學課程](https://python.langchain.com/docs/tutorials/): 提供循序漸進的範例，協助新手快速上手 LangChain。
- [操作指南](https://python.langchain.com/docs/how_to/): 涵蓋工具調用、RAG 應用案例等主題的快速、實用程式碼片段。
- [概念導覽](https://python.langchain.com/docs/concepts/): 解釋 LangChain 框架背後的關鍵概念。
- [API 參考](https://python.langchain.com/api_reference/): 詳細說明 LangChain 基礎套件與整合的 API 參考文件。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---