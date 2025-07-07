<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>開源履歷建立器，貼上你的連結、手動編輯，並讓 AI 協助潤飾、更新及客製化你的履歷。</b>
</p>

---

### 如何使用？

[Medium 部落格連結](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

部落格內容與目前的使用者介面及模板有所不同，已過時。

## 功能特色

- <b>簡易連結匯入：</b> 從網站貼上連結，快速建立 PDF 履歷。
- <b>內建手動編輯器：</b> 使用內嵌程式碼編輯器微調或從零開始建立你的履歷。
- <b>智慧建議：</b> 分享回饋或新連結，智慧編輯功能協助優化並更新你的履歷。
- <b>職缺量身打造：</b> 貼上職缺描述，獲得履歷調整建議。
- <b>LaTeX 高品質：</b> 所有履歷均以 LaTeX 產生，版面乾淨、專業。
- <b>即時預覽：</b> 即時以 PDF 預覽你的履歷。
- <b>快速重置：</b> 一鍵清除並重新開始編輯履歷。
- <b>本地運行：</b> 完全在本機端以 Docker 執行。

---

## 開始使用

### 先決條件
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### 安裝步驟

1. 複製本專案儲存庫：
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. 建置並啟動應用程式：
   ```bash
   docker compose up --build
   ```
3. 訪問應用程式：
   
   [_http://localhost:5173_](http://localhost:5173)
---

## 使用方式

1. 在瀏覽器中開啟 autoResume。
2. 點擊 :gear: 圖示，貼上你的 [GOOGLE API KEY](https://aistudio.google.com/) 和電子郵件。
3. 貼上你的專業資訊連結（如 Github、個人網站等）。
4. 可選擇性新增回饋或職缺連結以進一步客製化。
5. 點選 <b>產生履歷</b>，讓 AI 幫你完成後續！

---

## 授權條款

本專案採用 Apache 2.0 授權條款。

## 貢獻指南

### 前端
- 在 `frontend/src/components/` 資料夾內實作 React 元件
- 我們使用 Chakra UI 製作元件
- 在 `frontend/src/App.jsx` 匯入及使用你的元件

### 後端
- 在 `backend/src/routes/` 目錄內實作 API 路由
- 在 `backend/src/ai/` 目錄加入 AI 功能
- Python 代碼使用 `black` 格式化工具
- 請將路由處理與邏輯分離，保持程式碼整潔

### 一般指引
- 為你的功能/修正建立新分支：`git checkout -b your-branch-name`
- 撰寫清晰的提交訊息
- 在提交 PR 前測試你的修改

### 提交修改
1. 建立 Pull Request
2. 在你的 PR 描述中包含：
   - 你所做的更動
   - 進行更動的原因
   - 相關截圖或測試結果
   - 是否有破壞性更動或需要遷移的步驟

我們感謝你的貢獻，會儘快審查你的 PR！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---