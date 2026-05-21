# Agent2Agent (A2A) 範例

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="在 Firebase Studio 中試用"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 語言</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">簡體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-tw">繁體中文</a>
    </div>
  </details>
</div>

歡迎來到 [Agent2Agent (A2A) 協議](https://goo.gle/a2a) 的官方程式碼範例與演示頁面。

我們很高興您來到這裡！無論您是首次探索多代理架構，還是正在構建先進的可互操作代理網路，本儲存庫都提供簡單、啟發性且易於學習的資源，加速您的開發。

## 為什麼選擇 Agent2Agent？

在多元的 AI 框架和生態系中，代理需要一種共通語言，來安全地通訊、協作與分派任務。A2A 協議建立了一套標準化的開放標準，實現多代理互操作性。

我們的範例展示了如何輕鬆地跨語言與主機應用解決複雜的多代理問題。

## 快速開始

立即啟動並運行，通過我們的 Python CLI 主機與 Helloworld 代理進行通訊。

1. **啟動代理伺服器**：
   開啟終端機並啟動 Helloworld 代理伺服器：

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **執行主機客戶端**：
   打開第二個終端並運行 CLI 客戶端，將任務發送給代理程式：

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## 資料庫結構

本資料庫依據語言分為數個主要目錄：

| 目錄 | 說明 |
| --- | --- |
| [samples](/samples) | 依程式語言分類的核心 A2A 範例。 |
| [samples/python](/samples/python) | 使用 A2A Python SDK 展示 Python agent 的實作。 |
| [samples/go](/samples/go) | 使用 A2A Go SDK 展示 Go agent 的實作。 |
| [samples/dotnet](/samples/dotnet) | 使用 A2A .NET SDK 展示 C# agent 的實作。 |
| [samples/java](/samples/java) | 使用 A2A Java SDK 展示 Java agent 的實作。 |
| [samples/js](/samples/js) | 使用 A2A JavaScript SDK 展示 Node.js agent 的實作。 |

## 貢獻方式

我們歡迎並鼓勵各種技能層級的貢獻！如果您有新的範例想法、錯誤修正或文件改進，請參閱我們的 [貢獻指南](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)。

## 尋求協助

我們致力於提供友善且支持性的社群。如果您有任何問題、回饋或遇到困難，請在我們的 [問題頁面](https://github.com/a2aproject/a2a-samples/issues) 聯絡我們。

## 相關資料庫

| 資料庫 | 類別 | 說明 |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | 核心規範 | A2A 規範及文件。 |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | 工具 | 用於檢查 A2A agent 的 UI 工具。 |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | 測試 | 用於驗證 A2A 協議相容性的測試套件。 |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | 測試 | 使用多跳傳輸模型及多種傳輸協議，驗證各種 A2A SDK 實作及版本相容性的工具包。 |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | 官方 A2A Python SDK。 |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | 官方 A2A Go SDK。 |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | 官方 A2A Java SDK。 |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | 官方 A2A Node.js/JavaScript SDK。 |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | 官方 A2A C#/.NET SDK。 |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | 官方 A2A Rust SDK。 |

## 免責聲明

**重要：** 提供的範例程式碼僅供展示用途，並說明其運作機制。
代理對代理（A2A）協議。在構建生產應用程式時，將任何不受您直接控制的代理視為潛在的不受信任實體至關重要。

從外部代理收到的所有資料——包括但不限於其 AgentCard、訊息、產物和任務狀態——都應被視為不受信任的輸入進行處理。例如，惡意代理可能在其 AgentCard 的欄位（如描述、名稱、skills.description）中提供經過設計的資料。如果這些資料未經過濾就用於構建大型語言模型（LLM）的提示，可能會讓您的應用程式暴露於提示注入攻擊之下。未能在使用前正確驗證與過濾這些資料，可能會為您的應用程式帶來安全漏洞。

> 開發人員有責任實施適當的安全措施，例如輸入驗證以及憑證的安全處理，以保護其系統與使用者。










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---