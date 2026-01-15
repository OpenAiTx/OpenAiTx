
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

# AI 夥伴聊天

一個 Claude Skills 項目，讓 AI 成為你的個人化對話夥伴。

## 項目簡介

AI 夥伴聊天透過整合用戶画像、AI 画像以及向量化的個人筆記，提供個人化且具上下文感知的對話體驗。此技能使 AI 能夠記住並引用你過去的想法、偏好與知識庫，創造更加連貫且個人化的互動體驗。

## 核心功能

### 🎭 雙画像系統
- **用戶画像**：定義你的背景、專長、興趣和溝通偏好
- **AI 画像**：自訂 AI 的角色定位、溝通風格和互動方式

### 📝 智能筆記檢索
- 自動索引你的 Markdown 筆記
- 根據對話內容智能檢索相關歷史記錄
- 在對話中自然引用你的過往想法和筆記

### 💬 個性化對話
- 基於你的画像和筆記生成個性化回應
- 保持對話的上下文連貫性
- 像朋友一樣自然地引用你的想法，而非機械地「根據記錄」

## 使用場景

當你需要：
- 個性化交流，而非通用回覆
- 上下文感知的回應，AI 能記住你的背景
- AI 記住並引用你之前的想法和筆記
- 持續性的對話體驗，而非每次都是全新開始

## 安裝與使用

### 安裝技能

將此專案複製到你的工作目錄下的 `.claude/skills/` 資料夾中：

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### 使用技能

在 Claude Code 中，發送以下指令即可啟用此技能：

```
遵循 ai-partner-chat 对话
```

AI agent 會自動：
- 讀取技能配置和指引
- 建立必要的目錄結構（`notes/`、`config/`、`vector_db/` 等）
- 根據你的需求進行初始化

### 初始化流程

#### 方式一：讓 AI 自動創建並配置

首次使用時，直接告訴 AI：

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```
AI agent 會：
1. 分析 `notes/` 目錄中的筆記內容
2. 根據筆記格式智能分塊並建立向量資料庫
3. 基於筆記內容推測你的背景和偏好
4. 自動生成並更新 `config/user-persona.md`
5. 根據你的特點推薦並建立 `config/ai-persona.md`

#### 方式二：手動配置画像

如果你想自己定義画像：
1. AI agent 會自動從模板建立画像檔案到 `config/` 目錄
2. 你可以手動編輯這些檔案來自訂画像
3. 然後告訴 AI 進行向量化處理

### 開始對話

配置完成後，每次使用只需發送：


```
遵循 ai-partner-chat 对话
```
AI 將會：
- 讀取你的個人檔案以了解你的背景
- 檢索相關的歷史筆記
- 生成個人化且具備情境感知的回應

## 專案結構

### 技能包結構（位於 `.claude/skills/ai-partner-chat/`）


```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### 使用者資料目錄（位於專案根目錄）

AI agent 會在你的專案根目錄下建立以下結構：

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**重要**：用戶資料與技能包分離，方便備份與移轉。

## 工作流程

1. **載入画像**：讀取用戶画像與 AI 画像，理解互動背景
2. **檢索筆記**：根據用戶查詢，從向量資料庫中檢索最相關的筆記
3. **建構上下文**：整合画像資訊、相關筆記與對話歷史
4. **生成回應**：依據上下文生成個性化、自然的回應

## 特色亮點

### 🤖 AI Agent 智慧分塊
系統會分析每篇筆記的實際格式，動態生成最適合的分塊策略，而非使用預設範本。這代表無論你的筆記格式為何，都能獲得最佳處理。

### 🎯 自然引用
AI 會像回憶一樣自然地融入你的過往資訊，不會生硬地說「根據記錄」，而是流暢地融合於對話中。

### 📦 資料獨立
你的所有資料（筆記、画像、向量庫）都儲存在專案根目錄，易於備份、移轉或在不同技能間共享。

## 最佳實踐

### 画像設計
- **具體明確**：模糊的画像會導致通用回應
- **包含範例**：在 AI 画像中展現期望的互動模式
- **定期更新**：根據對話品質持續優化画像

### 筆記管理
- **格式自由**：系統可適應任何筆記結構
- **內容豐富**：有深度的筆記能帶來更佳的檢索效果
- **即時更新**：新筆記記得加入索引中

### 對話體驗
- **自然引用**：僅在真正相關時才引用筆記
- **保持流暢**：不要讓引用打斷對話的自然節奏
- **重視品質**：優先考慮有意義的連結，而非數量

## 維護與更新

### 新增筆記
將新筆記放入 `notes/` 目錄後，告訴 AI：

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

AI agent 會自動分析新筆記並更新索引。

### 更新画像
你可以直接編輯 `config/` 目錄下的画像檔案，或者告訴 AI：

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### 重建索引
當筆記結構發生重大變化時，告訴 AI：

```
请重新初始化向量数据库
```

AI agent 會重新分析所有筆記並重建索引。

## 注意事項

- **首次運行**：AI agent 首次建立向量資料庫時會自動下載嵌入模型（約 4.3GB），請耐心等候
- **Python 環境**：AI agent 會自動建立虛擬環境並安裝所需依賴
- **資料儲存**：所有資料（筆記、畫像、向量庫）儲存在專案根目錄，而非技能包目錄內
- **技能位置**：請確保技能包位於 `.claude/skills/ai-partner-chat/` 目錄下

## 更多資訊

詳細的技術文件和使用說明請參考 `SKILL.md` 文件。

---

讓 AI 成為真正了解你的對話夥伴，而不僅僅是一個工具。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---