# Tome - 魔法 AI 咒語書

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>一個神奇的桌面應用程式，讓每個人都能掌握 LLMs 和 MCP 的力量</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 下載 Tome 桌面應用程式：<a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome 是一款桌面應用程式，讓**任何人**都能利用 LLMs 和 MCP 的魔法。下載 Tome，連接任何本地或遠端 LLM，並將其串接到成千上萬的 MCP 伺服器，打造屬於你自己的 AI 魔法咒語書。

🫥 想要 100% 本地化、100% 私密？只需使用 Ollama 和 Qwen3，並僅搭配本地 MCP 伺服器，就能在屬於你的口袋宇宙中施展魔法。⚡ 想用最先進的雲端模型和最新的遠端 MCP 伺服器？你也可以這麼做。一切由你決定！

🏗️ 這是一個技術預覽版，因此請注意目前仍有許多地方尚未完善。[加入我們的 Discord](https://discord.gg/9CH6us29YA)，分享你的技巧、經驗以及遇到的問題。給本專案加星，隨時掌握最新更新與功能發佈！

## 🪄 特色

- 🧙 **簡化、適合新手的體驗**
  - 只需下載並安裝 Tome，連接你選擇的 LLM
  - 無需折騰 JSON、Docker、python 或 node
- 🤖 **支援多種 AI 模型**
  - **遠端**：Google Gemini、OpenAI、任何相容 OpenAI API 的端點
  - **本地**：Ollama、LM Studio、Cortex、任何相容 OpenAI API 的端點
- 🔮 **強化 MCP 支援**
  - 介面可安裝、移除、啟用/停用 MCP 伺服器
  - 原生支援 npm、uvx、node、python MCP 伺服器
- 🏪 **整合至 [Smithery.ai](https://smithery.ai) 註冊表**
  - 成千上萬個 MCP 伺服器可一鍵安裝
- ✏️ **可自訂 context window 和 temperature**
- 🧰 **原生支援工具呼叫與推理模型**
  - 介面優化，明確區分工具呼叫與思考訊息

## Demo

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# 入門指南

## 系統需求

- MacOS 或 Windows（Linux 即將推出！）
- 任選一個 LLM 供應商：[Ollama](https://ollama.com/) 或 [Gemini API key](https://aistudio.google.com/app/apikey) 皆簡單且免費
- [下載 Tome 最新版本](https://github.com/runebookai/tome/releases)

## 快速開始

1. 安裝 [Tome](https://github.com/runebookai/tome/releases)
2. 連接你偏好的 LLM 供應商 —— OpenAI、Ollama 和 Gemini 已預設提供，你也可以透過 http://localhost:1234/v1 加入像 LM Studio 這樣的供應商
3. 在 Tome 中開啟 MCP 分頁，安裝你的第一個 [MCP 伺服器](https://github.com/modelcontextprotocol/servers)（Fetch 是入門的好選擇，只需將 `uvx mcp-server-fetch` 貼到伺服器欄位）
4. 與你的 MCP 驅動模型聊天！請它抓取 Hacker News 的頭條新聞。

# 願景

我們希望讓本地 LLM 和 MCP 對每個人都變得易於使用。我們正在打造一個工具，讓你即使不是工程師、玩家、愛好者，或任何身份，都能發揮 LLM 的創意潛能。

## 核心原則

- **Tome 以本地為優先：** 你能掌控你的資料流向。
- **Tome 為所有人打造：** 你不需要管理程式語言、套件管理器或 json 設定檔。

## 下一步計畫

自 Tome 發布以來這幾週，我們已收到許多寶貴回饋，未來我們有更多宏大計畫。我們希望將 LLM 從對話框中釋放出來，並將推出更多功能協助大家實現這個目標。

- 排程任務：即使你不在電腦前，LLM 也能自動執行有用的工作。
- 原生整合：MCP 伺服器是存取工具與資訊的絕佳方式，但我們希望加入更強大的整合，讓你能以獨特方式與 LLM 互動。
- 應用程式建構器：我們相信長遠來看，最佳體驗不會侷限於對話介面。我們計劃推出更多工具，協助你建立強大的應用與工作流程。
- ??? 告訴我們你想要什麼！歡迎透過下方連結加入我們的社群，我們很樂意聽取你的意見。

# 社群

[Discord](https://discord.gg/9CH6us29YA) [部落格](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---