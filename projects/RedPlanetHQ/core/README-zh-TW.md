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
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### CORE：Claude、Cursor、ChatGPT 及所有 AI 工具的統一記憶層

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>文件說明</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 研究亮點

CORE 記憶在 Locomo 資料集所有推理任務中達到 **88.24%** 平均準確率，顯著超越其他記憶提供者。更多資訊請參考這篇 [部落格](https://blog.heysol.ai/we-built-memory-for-individuals-and-achieved-sota-on-locomo-benchmark/)。

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) 單跳問題需要依據單一會話來回答；(2) 多跳問題需整合多個不同會話的資訊來作答；(3) 開放領域知識問題可透過結合講者提供的資訊與外部知識（如常識或世界事實）來回答；(4) 時序推理問題則可透過時序推理並捕捉對話中的時間相關資料線索來作答；

## 概述

**問題** 

開發者常因需向 AI 工具重複解釋背景而浪費時間。在 Claude 達到 token 限制？必須重新開始，所有內容都消失。從 ChatGPT/Claude 切換到 Cursor？又得重新解釋你的背景。你的對話、決策和洞見在每次會話間消失。每換一個 AI 工具，情境切換的成本就更高。

**解決方案** - **CORE**（**Contextual Observation & Recall Engine**）

CORE 是一個開源、統一、持久的記憶層，適用於所有你的 AI 工具。你的情境可從 Cursor 到 Claude 到 ChatGPT 到 Claude Code 都能跟隨。單一知識圖譜記得誰說了什麼、何時、為何。一次連接，處處記憶。停止管理情境，開始創造價值。

## 🚀 快速開始
**5 分鐘建立你的統一記憶圖譜：**

1. **註冊帳號**，前往 [core.heysol.ai](https://core.heysol.ai) 並建立你的帳戶
2. **新增第一個記憶** - 分享有關自己的情境

    <img width="2088" height="1212" alt="first-memory" src="https://github.com/user-attachments/assets/ecfab88e-e91a-474d-9ef5-fc6c19b655a8" />


3. **視覺化你的記憶圖譜**，查看 CORE 如何自動建立事實間的連結
5. **測試看看** - 在對話區詢問「你對我知道什麼？」
6. 連接到你的工具：
   - [Claude](https://docs.heysol.ai/providers/claude) 及 [Cursor](https://docs.heysol.ai/providers/cursor) - 支援情境的程式開發
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) 及 [Gemini CLI](https://docs.heysol.ai/providers/claude-code) - 終端機記憶式程式開發
   - [安裝瀏覽器擴充功能](https://docs.heysol.ai/providers/browser-extension) - 讓你的記憶隨時應用於各網站
   - [Linear](https://docs.heysol.ai/integrations/linear)、[Github](https://docs.heysol.ai/integrations/github) - 自動新增專案背景資訊

## 🧩 主要功能

### 🧠 **統一且可攜式記憶體**：
透過 MCP，可在 **Cursor、Windsurf、Claude Desktop、Claude Code、Gemini CLI、AWS 的 Kiro、VS Code 以及 Roo Code** 中新增並調用你的記憶

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)

### 🕸️ **時間性 + 具體化知識圖譜**：

記住每個事實背後的故事——完整追蹤是誰、何時、為何說了什麼，並以豐富關聯與完整溯源記錄，而非僅僅平面儲存

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)

### 🌐 **瀏覽器擴充功能**：

將 ChatGPT、Grok、Gemini、Twitter、YouTube、部落格文章及任何網頁上的對話和內容直接儲存到你的 CORE 記憶體中。

**如何使用擴充功能**
1. 從 Chrome 線上應用程式商店 [下載擴充功能](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc)。
2. 登入 [CORE 控制台](https://core.heysol.ai)
   - 前往設定（左下方）
   - 進入 API 金鑰 → 產生新金鑰 → 命名為「extension」。
3. 開啟擴充功能，貼上你的 API 金鑰並儲存。

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a

### 💬 **記憶體對話**：
可詢問如「我的寫作偏好是什麼？」等問題，並即時獲得來自已連接知識的洞察

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)

### ⚡ **應用程式自動同步**：

自動從 Linear、Slack、Notion、GitHub 及其他連接的應用程式擷取相關背景資訊到你的 CORE 記憶體





📖 **[檢視所有整合](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - 支援服務及其功能的完整列表

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP整合中心**： 

只需將 Linear、Slack、GitHub、Notion 一次連接至 CORE，便能在 Claude、Cursor 或任何 MCP 客戶端中以單一網址使用所有工具


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## CORE如何建立記憶

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

CORE 的資料擷取流程分為四個階段，旨在捕捉不斷演變的情境：

1. **標準化**：將新資訊連結到最近的情境，將長文件拆分成有條理的片段並保留交叉引用，並統一術語，因此在 CORE 擷取知識時，所處理的是乾淨且具情境的輸入，而非凌亂文字。
2. **擷取**：從標準化後的文字中提取意義，識別實體（人物、工具、專案、概念），將其轉化為帶有情境、來源與時間的陳述，並映射其關係。例如，「我們用 Next.js 開發了 CORE」會變成：實體（CORE、Next.js）、陳述（CORE 是用 Next.js 開發的）、關係（使用 Next.js 開發）。
3. **解析**：偵測矛盾，追蹤偏好如何演變，並保留多元觀點及其來源，不會覆寫原有記憶，確保記憶反映完整歷程，而非僅是最新快照。
4. **圖譜整合**：將實體、陳述與事件串連成時序知識圖，將事實與其情境及歷史連結，讓孤立的資料化為可供智能代理真正使用的知識網。

成果：CORE 提供的不僅是平面的資料庫，而是隨你成長、改變的記憶——保留情境、演變與歸屬，讓代理能真正利用。


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## CORE如何從記憶中回憶

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

當你向 CORE 提問時，它不僅僅查找文字——而是深入你的整個知識圖，尋找最有用的答案。

1. **搜尋**：CORE 會從多個角度同時搜尋記憶——關鍵字搜尋用於精確匹配，語意搜尋可找到用不同說法表達的相關概念，圖譜遍歷則追蹤彼此連結的概念。
2. **重新排序**：檢索到的結果會重新排序，突出最相關且多元的內容，確保你看到的不僅是明顯的匹配，也包括更深層的連結。
3. **篩選**：CORE 依據時間、可靠性及關係強度套用智慧型篩選，讓最具意義的知識浮現。
4. **輸出**：你可以同時獲得事實（明確陳述）和事件（它們原始的上下文），因此召回總是有上下文、時間和故事作為依據。

結果：CORE不只是召回事實——它能在正確的上下文、時間和故事中召回事實，讓代理能以你記憶的方式回應。

## 文件

瀏覽我們的文件，充分發揮CORE的效能

- [基本概念](https://docs.heysol.ai/concepts/memory_graph)
- [自我託管](https://docs.heysol.ai/self-hosting/overview)
- [將Core MCP連接到Claude](https://docs.heysol.ai/providers/claude)
- [將Core MCP連接到Cursor](https://docs.heysol.ai/providers/cursor)

- [基本概念](https://docs.heysol.ai/overview)
- [API參考](https://docs.heysol.ai/local-setup)

## 🔒 安全性

CORE非常重視安全。我們實施業界標準的安全措施來保護你的資料：

- **資料加密**：所有傳輸中的資料（TLS 1.3）與靜態資料（AES-256）
- **認證**：OAuth 2.0與魔法連結認證
- **存取控制**：以工作區為基礎的隔離與角色權限管理
- **漏洞回報**：請回報安全問題至 harshith@tegon.ai

詳細安全資訊，請參閱我們的 [安全政策](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)。

## 🧑‍💻 支援

有疑問或反饋嗎？我們隨時為你服務：

- Discord：[加入core-support頻道](https://discord.gg/YGUZcvDjUa)
- 文件：[docs.heysol.ai](https://docs.heysol.ai)
- 電子郵件：manik@poozle.dev

## 使用指引

**儲存：**

- 對話歷史
- 使用者偏好
- 任務背景
- 參考資料

**請勿儲存：**

- 敏感資料（個人識別資訊，PII）
- 憑證
- 系統日誌
- 臨時資料

## 👥 貢獻者

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---