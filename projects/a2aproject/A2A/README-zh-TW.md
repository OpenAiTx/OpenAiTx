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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) 協議</h1>
  </div>
</div>

**一個開放協議，能夠促進不透明代理應用之間的通訊與互操作性。**

Agent2Agent (A2A) 協議解決了 AI 領域中的關鍵挑戰：讓由不同公司、基於多種框架、運行於不同伺服器上的生成式 AI 代理能夠有效地通訊與協作——作為代理，而不僅僅是工具。A2A 旨在為代理提供一種共通語言，促進更互聯、強大且創新的 AI 生態系統。

有了 A2A，代理能夠：

- 發現彼此的能力。
- 協商互動方式（文字、表單、多媒體）。
- 安全地協作處理長時間運行的任務。
- 在不暴露其內部狀態、記憶或工具的情況下運作。

## DeepLearning.AI 課程

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

加入此短期課程：[A2A：Agent2Agent 協議](https://goo.gle/dlai-a2a)，由 Google Cloud 與 IBM Research 合作開發，並由 [Holt Skinner](https://github.com/holtskinner)、[Ivan Nardini](https://github.com/inardini) 和 [Sandi Besen](https://github.com/sandijean90) 授課。

**你將學到：**

- **讓代理符合 A2A 標準：** 將使用 Google ADK、LangGraph 或 BeeAI 等框架建構的代理公開為 A2A 伺服器。
- **連接代理：** 從零開始建立 A2A 客戶端，或使用整合方式連接到符合 A2A 標準的代理。
- **協調工作流程：** 建構順序與階層式的 A2A 代理工作流程。
- **多代理系統：** 利用不同框架建構醫療多代理系統，並了解 A2A 如何促進協作。
- **A2A 與 MCP：** 學習 A2A 如何補足 MCP，讓代理彼此協作。

## 為什麼選擇 A2A？

隨著 AI 代理日益普及，他們的互操作能力對於構建複雜、多功能的應用至關重要。A2A 目標包括：

- **打破壁壘：** 連接不同生態系統的代理。
- **促進複雜協作：** 讓專業代理協作完成單一代理無法獨立處理的任務。
- **推動開放標準：** 鼓勵代理通訊的社群驅動方式，促進創新與廣泛採用。
- **維持不透明性：** 允許代理協作而無需共享內部記憶、專有邏輯或特定工具實現，提升安全性並保護智慧財產權。
### 主要功能

- **標準化通訊：** 透過 HTTP(S) 上的 JSON-RPC 2.0。
- **代理發現：** 透過「代理卡」提供功能與連線資訊。
- **彈性互動：** 支援同步請求/回應、串流（SSE）及非同步推播通知。
- **豐富資料交換：** 處理文字、檔案與結構化 JSON 資料。
- **企業級設計：** 兼顧安全性、驗證與可觀測性。

## 快速開始

- 📚 **瀏覽文件：** 參見 [Agent2Agent Protocol Documentation Site](https://a2a-protocol.org) 取得完整總覽、協議規格、教學與指南。
- 📝 **檢視規格書：** [A2A 協議規格](https://a2a-protocol.org/latest/specification/)
- 使用 SDK：
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) 透過 maven 使用
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) 透過 [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 使用我們的 [範例](https://github.com/a2aproject/a2a-samples) 了解 A2A 的實際應用

## 貢獻指南

我們歡迎社群貢獻，共同完善與發展 A2A 協議！

- **提問與討論：** 歡迎加入我們的 [GitHub 討論區](https://github.com/a2aproject/A2A/discussions)。
- **問題回報與建議：** 透過 [GitHub 問題追蹤](https://github.com/a2aproject/A2A/issues) 回報問題或提出改進建議。
- **貢獻指南：** 詳細貢獻說明請見 [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md)。
- **私下回饋：** 請使用這個 [Google 表單](https://goo.gle/a2a-feedback)。
- **合作夥伴計劃：** Google Cloud 客戶可透過此 [表單](https://goo.gle/a2a-partner) 加入我們的合作夥伴計劃。

## 下一步

### 協議增強

- **代理發現：**
    - 正式納入授權機制與可選憑證，直接包含於 `AgentCard` 內。
- **代理協作：**
    - 研究新增 `QuerySkill()` 方法，以動態查詢不支援或未預期的技能。

- **任務生命週期與用戶體驗：**
    - 支援在任務內進行動態用戶體驗協商（例如代理在對話中途新增音訊/視訊）。
- **用戶端方法與傳輸：**
    - 探索擴展對用戶端發起方法的支援（不限於任務管理）。
    - 改進串流可靠性與推播通知機制。

## 關於

A2A 協議是一個由 Linux 基金會主導的開源專案，由 Google 貢獻。該專案採用 [Apache License 2.0](LICENSE) 授權，並開放社群貢獻。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---