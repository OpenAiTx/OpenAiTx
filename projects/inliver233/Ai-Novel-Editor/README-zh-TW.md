<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">簡體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# AI小說編輯器

基於PyQt6的AI輔助小說編輯器，提供智慧補全、項目管理、概念組織等專業寫作工具。

## 安裝

1. 克隆專案
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. 建立虛擬環境
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
使用uv
```bash
uv venv -p 3.11
```
3. 安裝依賴
```bash
pip install -r requirements.txt
```
使用uv
```bash
uv sync
```


4. 運行程式
```bash
python -m src
```

## 主要功能

### 專案管理
- 層次化文件結構（作品 > 章節 > 場景）
- 專案匯入匯出（支援TEXT、MARKDOWN、DOCX、PDF、HTML格式）
- 自動備份與版本控制
- 多專案管理
### AI補全功能
- 三種補全模式：自動補全、手動補全（推薦 按一次tab觸發一次 再按一次tab應用補全）、禁用補全
- 三種上下文模式：
  - 快速模式：輕量級上下文，快速響應
  - 平衡模式：中等上下文，質量與速度平衡
  - 全域模式：完整專案上下文，最佳效果
- 支援多種AI服務：OpenAI、Claude、通義千問、智譜AI、DeepSeek、Groq等

### 大綱管理
- 視覺化大綱樹結構
- 拖曳排序和層級調整
- 文件快速導覽
- 大綱分析和優化建議

### API配置
- 統一的AI配置中心
- 多服務商預設配置
- 連線測試功能
- 配置方案儲存和匯入匯出
### 智能補全設定
- 可調節的觸發延遲
- 補全長度限制
- 上下文長度配置
- 流式回應支援

### 提示詞編輯
- 內建多種寫作模板
- 自訂提示詞模板
- 模板分類管理
- 模式特定模板配置

### 介面功能
- 明暗雙主題
- 三欄式佈局（項目樹、編輯器、概念面板）
- 可摺疊側邊欄
- 全螢幕寫作模式
- 專注模式（句子、段落、打字機、禪模式、沉浸模式）

### 搜尋與取代
- 全專案文本搜尋
- 正則表達式支援
- 批次替換功能
- 進階搜尋選項

### 概念管理
- 自動偵測角色、地點、物品
- 概念關係管理
- 標籤與分類系統
- 概念快速插入

## 快捷鍵

- `Ctrl+N`: 新建專案
- `Ctrl+O`: 開啟專案
- `Ctrl+S`: 儲存文件
- `F11`: 全螢幕模式
- `Tab`: 手動觸發AI補全（手動模式下）
- `Ctrl+F`: 查找
- `Ctrl+H`: 查找取代
- `Ctrl+Shift+H`: 進階查找取代
## 系統要求

- Python 3.8+
- PyQt6
- 作業系統：Windows、macOS、Linux

## 作者

**inliver**
- 電子郵件：inliverapi@outlook.com  
- GitHub：https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---