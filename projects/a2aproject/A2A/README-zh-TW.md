# Agent2Agent (A2A) 協議

[![PyPI - 版本](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache 授權](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 語言</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) 協議</h1>
  </div>
</div>

**一個開放協議，促進不透明代理應用程式間的通訊與互操作性。**

Agent2Agent (A2A) 協議針對 AI 領域中一個關鍵挑戰：使以不同框架建構、由不同公司運行於獨立伺服器上的生成式 AI 代理能以代理身分有效溝通與協作，而非僅僅作為工具。A2A 致力於為代理提供共通語言，促進更互聯、更強大、更具創新性的 AI 生態系統。

透過 A2A，代理能夠：

- 發掘彼此的能力。
- 協商互動方式（文字、表單、媒體）。
- 安全地協作處理長時間運行的任務。
- 操作時無需暴露其內部狀態、記憶或工具。

## DeepLearning.AI 課程

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

參加這個關於 [A2A: Agent2Agent 協議](https://goo.gle/dlai-a2a) 的短期課程，由 Google Cloud 和 IBM Research 合作開發，由 [Holt Skinner](https://github.com/holtskinner)、[Ivan Nardini](https://github.com/inardini)、[Sandi Besen](https://github.com/sandijean90) 授課。

**你將學習到：**

- **讓代理符合 A2A 標準：** 將用如 Google ADK、LangGraph 或 BeeAI 框架建構的代理公開為 A2A 伺服器。
- **連接代理：** 從零開始建立 A2A 客戶端或利用整合連接至符合 A2A 標準的代理。
- **協調工作流程：** 建立符合 A2A 標準代理的順序與階層工作流程。
- **多代理系統：** 使用不同框架建構醫療多代理系統，見證 A2A 如何促進協作。
- **A2A 與 MCP：** 學習 A2A 如何補足 MCP，使代理能彼此協作。

## 為什麼選擇 A2A？

隨著 AI 代理日益普及，其互操作能力對於建立複雜、多功能應用至關重要。A2A 致力於：

- **打破孤島：** 連接不同生態系中的代理。
- **促進複雜協作：** 讓專業代理共同完成單一代理無法獨立處理的任務。
- **推動開放標準：** 促進社群驅動的代理通訊方式，鼓勵創新與廣泛採用。
- **維持不透明性：** 代理協作時無需共享內部記憶、專有邏輯或特定工具實現，增強安全並保護智慧財產權。

### 主要功能

- **標準化通訊：** JSON-RPC 2.0 透過 HTTP(S)。
- **代理發現：** 通過「代理卡」提供能力和連線資訊。
- **彈性互動：** 支援同步請求/回應、串流（SSE）、及非同步推播通知。
- **豐富資料交換：** 處理文字、檔案及結構化 JSON 資料。
- **企業級設計：** 考慮安全性、認證及可觀察性。

## 快速上手

- 📚 **瀏覽文件：** 前往 [Agent2Agent 協議文件網站](https://a2a-protocol.org) 以獲得完整概覽、協議規範、教學和指南。
- 📝 **查看規範：** [A2A 協議規範](https://a2a-protocol.org/latest/specification/)
- 使用 SDK：
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) 使用 maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) 使用 [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 使用我們的 [範例](https://github.com/a2aproject/a2a-samples) 來體驗 A2A

## 貢獻指南

我們歡迎社群貢獻來增強與發展 A2A 協議！

- **問題 & 討論：** 加入我們的 [GitHub 討論區](https://github.com/a2aproject/A2A/discussions)。
- **問題回報 & 意見：** 透過 [GitHub 問題](https://github.com/a2aproject/A2A/issues) 回報問題或提出建議。
- **貢獻指南：** 請參閱我們的 [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) 了解貢獻方式。
- **私密回饋：** 使用此 [Google 表單](https://goo.gle/a2a-feedback)。
- **合作夥伴計畫：** Google Cloud 客戶可透過此 [表單](https://goo.gle/a2a-partner) 加入合作夥伴計畫。

## 下一步

### 協議增強

- **代理發現：**
    - 正式將授權方案及選擇性憑證直接納入 `AgentCard`。
- **代理協作：**
    - 研究 `QuerySkill()` 方法，用於動態檢查不支援或預期外技能。
- **任務生命週期與使用者體驗：**
    - 支援在任務內進行動態 UX 協商（例如代理人在對話中途新增音訊/視訊）。
- **用戶端方法與傳輸：**
    - 探討擴展對用戶端發起方法（不限於任務管理）的支援。
    - 改善串流可靠性與推播通知機制。

## 關於

A2A 協定是一個由 Linux 基金會管理的開源專案，由 Google 貢獻。該專案採用 [Apache License 2.0](LICENSE) 授權，並歡迎社群貢獻。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---