<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">簡體中文</a>
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
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE 標誌" />
  </a>

### CORE：AI 應用的個人記憶層

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki 徽章" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>文件說明</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 研究亮點

CORE 記憶在 Locomo 數據集的所有推理任務中達到 **88.24%** 的平均準確率，顯著優於其他記憶提供者。詳情請參閱這篇[部落格](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/)。

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) 單跳問題需要根據單一會話作答；(2) 多跳問題需綜合多個不同會話中的資訊；(3) 開放領域知識問題可透過結合講者提供資訊與外部知識（如常識或世界事實）回答；(4) 時序推理問題可通過時序推理和捕捉對話中的時間線索作答；

## 概述

**問題** 

開發者浪費時間重複向 AI 工具解釋背景。Claude 遇到 Token 限制？重啟就什麼都沒了。從 ChatGPT/Claude 換到 Cursor？又要重新解釋背景。你的對話、決策和洞察力在各次會話間消失。每更換一個 AI 工具，背景切換的成本就增加。

**解決方案** - **CORE**（**Contextual Observation & Recall Engine**）

CORE 是一個開源、統一且持久的記憶層，適用於所有 AI 工具。你的背景資訊能從 Cursor 到 Claude、再到 ChatGPT、Claude Code都能同步。單一知識圖記錄誰說了什麼、何時、為何。只需連接一次，處處都能記得。不再需要管理背景，專注於創建。

## 🚀 CORE 自主架設
想在自己的基礎設施上運行 CORE？自主架設可讓你完全掌控資料與部署。

**先決條件**：

- 已安裝 Docker（20.10.0 以上）和 Docker Compose（2.20.0 以上）
- OpenAI API 金鑰

> **關於開源模型的說明：** 我們已測試 Ollama 和 GPT 等開源選擇，但其事實提取和圖譜品質不足。我們正在積極尋找更好的選項。

### 安裝

1. 複製此儲存庫：
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. 在 `core/.env` 中配置環境變數：
```
OPENAI_API_KEY=your_openai_api_key
```
3. 啟動服務
```
docker-compose up -d
```

部署完成後，您可以設定您的 AI 供應商（OpenAI、Anthropic），並開始建立您的記憶圖譜。

👉 [檢視完整自我託管指南](https://docs.heysol.ai/self-hosting/docker)

注意：我們曾嘗試如 Ollama 或 GPT OSS 等開源模型，但事實生成效果不佳，我們仍在研究如何改進，之後也會支援 OSS 模型。

## 🚀 CORE 雲端
**五分鐘內建立您的統一記憶圖譜：**

不想管理基礎設施？CORE 雲端讓您即刻建立個人記憶系統——無需設置、無需伺服器，只需可用的記憶。

1. **註冊** [core.heysol.ai](https://core.heysol.ai) 並創建您的帳戶
2. **視覺化您的記憶圖譜**，觀看 CORE 如何自動連接事實之間的關係
3. **試用看看**——在對話區詢問「你知道我什麼？」
4. 連接您的工具：
   - [Claude](https://docs.heysol.ai/providers/claude) 與 [Cursor](https://docs.heysol.ai/providers/cursor)——情境式編碼
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) 與 [Codex CLI](https://docs.heysol.ai/providers/codex)——終端機記憶式編碼
   - [新增瀏覽器擴充套件](https://docs.heysol.ai/providers/browser-extension)——將您的記憶帶到任何網站
   - [Linear](https://docs.heysol.ai/integrations/linear)、[Github](https://docs.heysol.ai/integrations/github)——自動新增專案情境

## 🧩 主要功能

### 🧠 **統一且可攜式記憶**： 
透過 MCP 可於 **Cursor、Windsurf、Claude Desktop、Claude Code、Gemini CLI、AWS 的 Kiro、VS Code 和 Roo Code** 新增及回溯您的記憶

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **時間性 + 具體化知識圖譜**： 

記住每個事實背後的故事——追蹤誰、何時、為何說了什麼，擁有豐富關聯與完整來源，而非僅平面儲存

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **瀏覽器擴充套件**： 

將 ChatGPT、Grok、Gemini、Twitter、YouTube、部落格文章及任何網頁上的對話與內容直接儲存至您的 CORE 記憶中。

**如何使用擴充功能**
1. 從 [Chrome 線上應用程式商店](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) 下載擴充功能。
2. 登入 [CORE 控制台](https://core.heysol.ai)
   - 點選左下方的設定
   - 前往 API Key → 產生新金鑰 → 命名為「extension」。
3. 開啟擴充功能，貼上你的 API 金鑰並儲存。

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **記憶聊天**： 
詢問如「我的寫作偏好是什麼？」等問題，立即獲取來自已連接知識的洞察

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **應用程式自動同步**：

自動從 Linear、Slack、Notion、GitHub 及其他已連接應用程式擷取相關情境至你的 CORE 記憶

📖 **[檢視所有整合](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - 支援服務與功能的完整列表

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP 整合中心**： 

只需一次將 Linear、Slack、GitHub、Notion 連接至 CORE—即可在 Claude、Cursor 或任何 MCP 客戶端中，透過單一網址使用所有工具


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## CORE 如何創建記憶

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

CORE 的資料擷取流程分為四個階段，以捕捉持續變化的情境：

1. **標準化**：將新資訊連結到最近的上下文，將長文件切割成有條理的段落並保持交叉參照，並統一術語，使 CORE 在抽取知識時能處理乾淨、具上下文的輸入，而不是雜亂的文本。
2. **抽取**：從標準化後的文本中提取意義，識別實體（人物、工具、專案、概念），並將其轉化為帶有上下文、來源及時間的陳述，並建立關聯。例如，「我們用 Next.js 寫了 CORE」會變成：實體（CORE、Next.js）、陳述（CORE 是用 Next.js 開發的）、關係（是用…開發的）。
3. **解析**：偵測矛盾，追蹤偏好如何演變，並以來源保存多元觀點，而非覆蓋它們，讓記憶反映你的完整歷程，而不僅僅是最新快照。
4. **圖整合**：將實體、陳述與事件連接成一個時間性的知識圖，將事實連結到其上下文與歷史，讓孤立資料變成代理能實際使用的活知識網絡。

成果：CORE 不再只是扁平資料庫，而是給你隨著成長與變化而演進的記憶——保留上下文、演化和歸屬，讓代理真正能夠運用。

![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## CORE 如何從記憶中回憶

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

當你向 CORE 提問時，它不只是查找文字——它會深入整個知識圖，尋找最有用的答案。

1. **搜尋**：CORE 會同時從多個角度搜尋記憶——關鍵字搜尋尋找精確匹配，語義搜尋尋找即使表述不同也相關的想法，還有圖遍歷以追蹤連結概念間的關係。
2. **重新排序**：檢索到的結果會重新排序，突顯最相關且多元的結果，確保你不只看到明顯的匹配，還能發現更深層的關聯。
3. **過濾**：CORE 根據時間、可靠性和關係強度應用智慧過濾，讓最有意義的知識浮現。
4. **輸出**：你會同時獲得事實（明確陳述）和事件（原始上下文），讓回憶始終根植於脈絡、時間與故事。

成果：CORE 不只是回憶事實——它會以正確的脈絡、時間與故事回憶，讓代理能像你記得的方式回應。

## 文件

探索我們的文件，發揮 CORE 的最大效益

- [基本概念](https://docs.heysol.ai/concepts/memory_graph)
- [自架設](https://docs.heysol.ai/self-hosting/overview)
- [連接 Core MCP 與 Claude](https://docs.heysol.ai/providers/claude)
- [連接 Core MCP 與 Cursor](https://docs.heysol.ai/providers/cursor)
- [連接 Core MCP 與 Claude Code](https://docs.heysol.ai/providers/claude-code)
- [連接 Core MCP 與 Codex](https://docs.heysol.ai/providers/codex) 

- [基本概念](https://docs.heysol.ai/overview)
- [API 參考](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 安全性

CORE 非常重視安全。我們採用業界標準的安全措施來保護您的資料：

- **資料加密**：所有傳輸中的資料（TLS 1.3）及靜態資料（AES-256）
- **驗證**：OAuth 2.0 及魔法連結驗證
- **存取控制**：以工作區為基礎的隔離及角色為基礎的權限
- **漏洞回報**：請將安全性問題回報至 harshith@poozle.dev

如需詳細安全資訊，請參閱我們的 [安全政策](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)。

## 🧑‍💻 支援

有疑問或回饋嗎？我們隨時為您服務：

- Discord： [加入 core-support 頻道](https://discord.gg/YGUZcvDjUa)
- 文件： [docs.heysol.ai](https://docs.heysol.ai)
- 電子郵件：manik@poozle.dev

## 使用指南

**請儲存：**

- 對話歷史
- 使用者偏好設定
- 任務內容
- 參考資料

**請勿儲存：**

- 敏感資料（PII）
- 認證資訊
- 系統紀錄
- 暫存資料

## 👥 貢獻者

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>
















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---