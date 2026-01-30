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

**一個開放協議，促進不透明代理應用間的通訊與互操作性。**

Agent2Agent (A2A) 協議解決了 AI 領域中的一項關鍵挑戰：讓由不同公司、基於多種框架並運行於不同伺服器上的生成式 AI 代理能以「代理」身份有效通訊與協作，而不僅僅是工具。A2A 致力於為代理提供共通語言，促進更互聯、更強大、更具創新的 AI 生態系。

透過 A2A，代理能夠：

- 發現彼此的能力。
- 協商互動方式（文字、表單、多媒體）。
- 安全地協作執行長時間任務。
- 運作時無需暴露其內部狀態、記憶或工具。

## A2A 介紹影片

[![A2A Intro Video](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## 為何選擇 A2A？

隨著 AI 代理日益普及，其互操作能力對構建複雜、多功能應用至關重要。A2A 的目標包括：

- **打破壁壘：** 連接不同生態系的代理。
- **促進複雜協作：** 讓專業代理共同完成單一代理無法處理的任務。
- **推動開放標準：** 以社群驅動的方式促進代理通訊，鼓勵創新與廣泛採用。
- **維持不透明性：** 代理能協作而無需分享內部記憶、專有邏輯或具體工具實現，提升安全性並保護智慧財產。

### 主要特點

- **標準化通訊：** 以 JSON-RPC 2.0 透過 HTTP(S) 傳輸。
- **代理發現：** 透過「代理卡」揭示能力與連線資訊。
- **彈性互動：** 支援同步請求／回應、串流（SSE）、非同步推播通知。
- **豐富資料交換：** 支援文字、檔案及結構化 JSON 資料。
- **企業等級：** 具備安全性、驗證與可觀測性設計。

## 快速開始
- 📚 **探索文件：** 請造訪 [Agent2Agent 協議文件網站](https://a2a-protocol.org) 以獲取完整概述、全套協議規格、教學及指南。
- 📝 **檢視規格說明：** [A2A 協議規格](https://a2a-protocol.org/latest/specification/)
- 使用 SDK：
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) 使用 maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) 使用 [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 使用我們的 [範例](https://github.com/a2aproject/a2a-samples) 來了解 A2A 的實際運作

## 貢獻指南

我們歡迎社群共同協作，持續強化與發展 A2A 協議！

- **問題與討論：** 歡迎加入我們的 [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)。
- **議題與回饋：** 透過 [GitHub Issues](https://github.com/a2aproject/A2A/issues) 回報問題或提出改進建議。
- **貢獻指南：** 詳細參閱我們的 [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) 了解如何參與貢獻。
- **私人回饋：** 請使用此 [Google 表單](https://goo.gle/a2a-feedback)。
- **合作夥伴計畫：** Google Cloud 客戶可透過此 [表單](https://goo.gle/a2a-partner) 申請加入合作夥伴計畫。

## 後續計畫

### 協議增強

- **代理發現：**
    - 正式納入授權機制及選用憑證於 `AgentCard` 內。
- **代理協作：**
    - 研究 `QuerySkill()` 方法，以動態檢查未支援或預期外之技能。
- **任務生命週期與 UX：**
    - 支援任務內動態 UX 協商（如代理於對話中新增音訊／視訊）。
- **用戶端方法與傳輸：**
    - 探討擴充用戶端發起方法（不限於任務管理）。
    - 改進串流可靠性與推播通知機制。

## 關於

A2A 協議是一個由 Google 貢獻、隸屬於 Linux 基金會的開源專案。其採用 [Apache License 2.0](LICENSE) 授權，並歡迎社群共同參與貢獻。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---