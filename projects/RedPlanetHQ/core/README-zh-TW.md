<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://getcore.me">
    <img width="200px" alt="CORE 標誌" src="https://github.com/user-attachments/assets/bd4e5e79-05b8-4d40-9aff-f1cf9e5d70de" />
  </a>

# 你的個人 AI 作業系統。

**運行你的作業系統。** 監控你的工作。記住重要的事。跨越你的工具和代理執行操作。開源、自架設、永遠屬於你。

<p align="center">
    <a href="https://getcore.me">
        <img src="https://img.shields.io/badge/Website-getcore.me-c15e50?style=for-the-badge&logo=safari&logoColor=white" alt="網站" />
    </a>
    <a href="https://docs.getcore.me">
        <img src="https://img.shields.io/badge/Docs-docs.getcore.me-22C55E?style=for-the-badge&logo=readthedocs&logoColor=white" alt="文件" />
    </a>
    <a href="https://discord.gg/YGUZcvDjUa">
        <img src="https://img.shields.io/badge/Discord-community-5865F2?style=for-the-badge&logo=discord&logoColor=white" alt="Discord 社群" />
    </a>
    <a href="https://github.com/RedPlanetHQ/core/blob/main/LICENSE">
        <img src="https://img.shields.io/badge/License-AGPL%203.0-blue?style=for-the-badge" alt="授權條款：AGPL 3.0" />
    </a>
</p>
</div>

---

## 實際運作展示

觀看 CORE 全程處理兩項程式任務：

[![CORE Demo](https://img.youtube.com/vi/7y_kt_UTYQs/maxresdefault.jpg)](https://www.youtube.com/watch?v=7y_kt_UTYQs)

---

## CORE 是什麼

CORE 是為 AI 原生工作打造的開源作業層。

你可以在草稿區寫下要做的事情。CORE 會接收任務、從記憶和連接的應用程式載入上下文、擬定計畫、透過閘道運行合適的代理、處理阻礙，並於需要人工判斷時回報。

它不是一個要你反覆提示的聊天機器人。它是能記住、協調、執行並升級的作業層。

### 架構

| | |
|---|---|
| **監控** | 來自 MCP 的 AI 對話上下文、50+ 連接應用，以及在 Mac 上，你明確授權存取的任何應用程式。 |
| **記憶** | 一個知識圖譜，不只記錄你說了什麼，更追蹤你決定了什麼、何時及為何，在每一個工具及對話中。 |
| **執行** | 在你連接的應用程式中直接執行操作，並透過閘道將較長的工作委派給程式與瀏覽器代理。 |
| **政策** | 核准流程、升級規則、計劃和稽核日誌，讓自主性同時保持問責。 |

CORE 決定能安全執行的事項，遇到敏感操作會事先請示，並留下可供審查的紀錄。

---

## CORE 實際運作

### 委派程式任務，回來就是一個 PR。

告訴 CORE 需要做什麼。它會從你的程式庫、應用程式和記憶中收集上下文、擬定計劃、啟動 Claude Code 或 Codex 工作階段，遇到阻礙時盡力解決，最後帶回一個 PR。你只需在完成後審查。

`[ ] 修正 issue #312 結帳流程的競爭條件問題`

### 睡覺時清空待辦清單。

設定定期任務，讓它在指定時間從待辦清單拉取工作。CORE 在你離線時自動執行。順利完成的作業早上等你審查，卡住的會帶著明確問題回來，而不是讓分頁停滯。

`[ ] 今晚 11 點開始清理待辦清單`

### 在警報變成打擾前先行調查。

設定定期任務監控 Sentry、日誌或任何警報來源。當有警報觸發時，CORE 會調查、收集相關追蹤和過往事件，然後決定處理或升級。

凌晨 2 點 Sentry 警報觸發。CORE 進行調查，提出修正建議，並在 Slack 上通知你審查。

### 早晨簡報，貼合你的工作。

設定定期任務，每天早上從 email、GitHub、Linear 和 Slack 拉取訊息。CORE 會摘要需要關注的重點，跳過不重要的，並自動將後續行動轉為任務。

### 隨時隨地委派任務。

可從 Slack、WhatsApp、Telegram、email 或網頁創建任務。閘道持續在 Docker 或 Railway 執行，即使筆電闔上，CORE 也能接收任務。

---

## CORE 內部架構

| | |
|---|---|
| **記憶體** | 追蹤你的偏好、決策、目標與指令，跨越每個工具與對話，讓每個任務都能帶著完整脈絡啟動。 |
| **任務** | 一次性或週期性工作單元，包含你的規格、CORE 的計畫、即時狀態，以及專屬聊天室。每個任務皆可衍生程式編輯或瀏覽器工作階段。 |
| **便條本** | 每日頁面記錄任務、想法與進行中工作。任何地方輸入 `[ ]`，CORE 會在 3 分鐘內自動擷取。 |
| **連接器** | 透過單一 MCP 端點整合 50+ 應用，支援 webhook 觸發主動自動化。包含 GitHub、Linear、Jira、Slack、Gmail、Calendar、Sentry、Granola、Todoist 等。 |
| **技能** | 100+ 可重用指令根據情境自動應用。可用內建技能，也可自訂，打造可重複流程。 |
| **閘道** | 執行 Claude Code、Codex、瀏覽器代理與本地指令，可在你的機器或 Docker/Railway 上運作，讓 CORE 即使筆電闔上也能持續運作。 |
| **模型中立** | 支援自選供應商：Anthropic、OpenAI 或開源權重模型。可自行架設完整堆疊，確保隔離。 |

---

## CORE 不是什麼

| | |
|---|---|
| **不是 RAG 包裝器。** | 記憶體不只是嵌入片段，而是一套知識圖譜，記錄你何時、為何、做了什麼決定。 |
| **不是工作流程編輯器。** | 沒有拖拉式 DAG。你只需寫下要做什麼，CORE 會推斷流程，遇需判斷時會詢問你。 |
| **不是另一個 Devin。** | CORE 提出計劃，由你審核。CORE 請求解鎖，由你決定。CORE 回報 PR，由你審查。代理不會自行合併。 |
| **不是封閉雲端助理。** | CORE 是開源、自主部署、模型中立且圍繞你的基礎設施設計。 |

---

## 快速開始

開源且可自架。你的資料僅留存在你的基礎設施中。

**安裝並啟動 CORE：**

```bash
npm install -g @redplanethq/corebrain && corebrain setup
```

安裝精靈會要求輸入安裝目錄、AI 提供者、API 金鑰以及聊天模型。它會產生密鑰、啟動堆疊，並開啟 `http://localhost:3033`。

大多數本地安裝在 Docker 運行後只需幾分鐘。

**或者在 Railway 部署：**

[![Deploy on Railway](https://railway.app/button.svg)](https://railway.com/deploy/core)

**連接閘道**，讓 CORE 可以操作您的瀏覽器、執行程式代理以及存取本地資料夾：

```bash
corebrain login
corebrain gateway setup
```

**需求條件：** Docker 20.10+、Docker Compose 2.20+、4 vCPU / 8GB RAM

[完整自我託管指南](https://docs.getcore.me/self-hosting/setup)

> 想要 Mac 應用程式？請至 [getcore.me](https://www.getcore.me/) 加入候補名單。

---

## 基準測試

CORE 在 [LoCoMo 基準測試](https://github.com/RedPlanetHQ/core-benchmark) 中，於單跳、多跳、開放領域及時序推理場景下，平均正確率達 **88.24%**。

---

## 我們的信念

- 對話是介面，不是作業系統。
- 沒有記憶的智能只是瑣事。
- 你的 AI 應該能在每個工具中了解你，而不僅是當前分頁。
- 工作應該能從意圖自動流向行動，而不需你親自充當「膠水」。
- 沒有責任追蹤的自動化只會造成混亂。

---

## 文件

- [**記憶體**](https://docs.getcore.me/memory/overview) - 時序知識圖、事實分類、意圖驅動檢索
- [**記事本**](https://docs.getcore.me/concepts/scratchpad) - 任務與想法的每日起點
- [**任務**](https://docs.getcore.me/concepts/tasks) - 計畫、狀態、重複性工作與任務範圍上下文
- [**工具箱**](https://docs.getcore.me/concepts/toolkit) - 經由 MCP 整合 50+ 應用、1000+ 動作
- [**CORE 代理人**](https://docs.getcore.me/concepts/meta-agent) - 觸發器、記憶體、工具與執行
- [**閘道**](https://docs.getcore.me/access-core/overview) - 支援 WhatsApp、Slack、Telegram、電子郵件、網頁及 API 存取
- [**技能**](https://docs.getcore.me/skills/overview) - 可重複使用的工作流程指令
- [**自我託管**](https://docs.getcore.me/self-hosting/setup) - 完整部署指南
- [**更新日誌**](https://docs.getcore.me/opensource/changelog) - 已發佈內容

---

## 安全性

- CASA 第二級認證
- 傳輸中採用 TLS 1.3
- 靜態資料採用 AES-256
- 您的資料絕不會被用於模型訓練
- 支援自我託管以實現完全隔離
- [安全性政策](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)
- 漏洞回報：harshith@poozle.dev

---

## 社群

我們正在公開打造 CORE。

我們公開分享產品路線圖和架構決策，因為打造個人作業系統最難的問題，往往需要使用者一起參與解決。請給我們一顆星、自我託管、分享您的成果，並針對故障或缺失提出 issue。

- [Discord](https://discord.gg/YGUZcvDjUa) - 問題、想法、展示與分享
- [貢獻文件](https://docs.getcore.me/opensource/contributing) - 如何貢獻 CORE
- [`good-first-issue`](https://github.com/RedPlanetHQ/core/labels/good-first-issue) - 從這裡開始

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>

---

<div align="center">

**自我託管您的個人 AI 作業系統。**

[給本專案一顆星](https://github.com/RedPlanetHQ/core) · [閱讀文件](https://docs.getcore.me) · [加入 Discord](https://discord.gg/YGUZcvDjUa)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---