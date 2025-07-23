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

### C.O.R.E: AI時代的數位大腦

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>文件</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**情境觀察與回憶引擎**

C.O.R.E 是一套可攜式記憶圖譜，根據您的 LLM 互動與個人資料構建，讓所有情境與工作流程歷史都能供任何 AI 工具存取，就像一顆數位大腦。這消除了重複分享上下文的需求。其目標是提供：

- **統一且可攜式的記憶**：無縫新增與回憶情境，並可將您的記憶串接至如 Claude、Cursor、Windsurf 等多款應用。
- **關聯式而非僅平面事實**：CORE 組織您的知識，儲存事實與關係，打造如同大腦般更深層且豐富的記憶。
- **用戶擁有**：您可自行決定保留、更新、刪除哪些記憶，並能於所需工具間分享，擺脫廠商綁定。

## 🎥 示範影片

[觀看 C.O.R.E 示範](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Core dashboard" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  主要功能

- **記憶圖譜**：可視化您的事實和偏好如何相互串連
- **記憶對話**：詢問記憶內容，立即獲得洞察與理解
- **即插即用**：可立即於 Cursor、Claude 等應用中使用 CORE 記憶

## ☁️ C.O.R.E 雲端安裝指南

1. 註冊 [Core Cloud](https://core.heysol.ai)，開始建立您的記憶圖譜。
2. 新增您想儲存在記憶中的文本。點擊 `+ Add` 按鈕後將自動生成記憶圖譜。
3. [將 Core 記憶 MCP 與 Cursor 連接](#connecting-core-mcp-with-cursor)

## 💻 C.O.R.E 本地安裝指南

#### 先決條件

1. Docker
2. OpenAI API 金鑰


> **注意：**我們正積極改進對 Llama 模型的支援。目前 C.O.R.E 與 Llama 基礎模型尚未達到最佳效果，但我們正努力提升相容性與未來輸出品質。
> 
#### 本地執行 C.O.R.E

1. **複製環境變數**

   將範例環境檔案複製為 `.env`：


   ```bash
   cp .env.example .env
   ```
2. **啟動應用程式**

   使用 Docker Compose 啟動所有所需的服務：


   ```bash
   docker-compose up
   ```
3. **存取應用程式**

   當容器運行後，請打開瀏覽器並前往 [http://localhost:3000](http://localhost:3000)。

4. **使用魔法連結建立帳戶**

   - 若要建立帳戶，請點擊 `Continue with email` 按鈕

     <img width="865" height="490" alt="Create account" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - 輸入你的電子郵件並點擊 `Send a Magic Link` 按鈕

     <img width="824" height="429" alt="Enter email" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `從終端機日誌複製魔法連結` 並在瀏覽器中開啟

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **建立你的私人空間並新增資料**

   - 在儀表板的右上方區域輸入訊息，例如 `我喜歡打羽毛球`，然後點擊 `+Add`。
   - 你的記憶將被排入處理隊列；你可以在 `Logs` 區域監控其狀態。
     
     <img width="1496" height="691" alt="Core memory logs" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - 處理完成後，節點將被加入你的私人知識圖譜並顯示於儀表板上。
   - 你之後可以選擇將這段記憶連接到其他工具，或保持其私有。

6. **搜尋你的記憶**

   - 使用儀表板的搜尋功能，在你的私人空間中查詢已匯入的資料。


## 將 CORE MCP 與 Cursor 連接

1. 開啟 CORE 儀表板並進入 API 區段以產生新的 API token。
2. 在 Cursor 中，前往：Settings → Tools & Integrations → New MCP Server。
3. 依照下方設定格式新增 CORE MCP 伺服器，並確保將 API_TOKEN 值替換為步驟 1 產生的 token。

   MCP 設定範例，需加入至 Cursor


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. 前往設定-> 使用者規則 -> 新增規則 -> 並新增以下規則以確保您所有的聊天互動都會被儲存在 CORE 記憶體中


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## 文件說明

瀏覽我們的文件，以充分發揮 CORE 的效能
- [基本概念](https://docs.heysol.ai/core/overview)
- [API 參考](https://docs.heysol.ai/core/local-setup)
- [將 Core Memory MCP 與 Cursor 連接](#connecting-core-mcp-with-cursor)


## 🧑‍💻 支援
有疑問或回饋嗎？我們隨時為您提供協助：
- Discord: [加入 core-support 頻道](https://discord.gg/YGUZcvDjUa)
- 文件: [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- 電子郵件: manik@poozle.dev

## 使用指引

**可儲存：**

- 對話歷史
- 使用者偏好
- 任務上下文
- 參考資料

**不可儲存：**

- 敏感資料（個人識別資訊）
- 憑證
- 系統日誌
- 暫存資料

## 👥 貢獻者

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---