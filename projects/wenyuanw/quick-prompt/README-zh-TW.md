# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

一款強大的瀏覽器擴充功能，專注於提示詞管理與快速輸入。協助使用者建立、管理並組織提示詞庫，並可在任意網頁輸入框中快速插入預設的 Prompt 內容，提升工作效率。

> 由於瀏覽器插件僅能用於網頁端，因此開源了一個功能相同的 [Raycast 插件](https://github.com/wenyuanw/quick-prompt-raycast)，相容於瀏覽器插件資料格式，支援透過相同 JSON 資料無縫遷移。

## ✨ 功能特色

- 📚 **提示詞管理**：便捷地建立、編輯與管理你的提示詞庫
- 🚀 **快速輸入**：在任何網頁輸入框中通過 `/p` 快速觸發提示詞選擇器
- ⌨️ 支援設定快捷鍵開啟提示詞選擇器 & 儲存選中文本為提示詞
- 📑 支援右鍵選單直接儲存選中文本為提示詞
- 🎯 支援自訂提示詞，包括分類、標題、內容、標籤與變數
- 🧑‍💻 **變數支援**：提示詞中可使用 `{{變數名}}` 格式的變數，使用時可填入具體數值
- 💾 **資料備份**：支援提示詞庫的匯出與匯入，方便跨裝置遷移與備份
- 🔗 **Notion 同步**：支援將提示詞庫與 Notion 資料庫同步
- 🔍 支援搜尋與過濾提示詞功能
- 🌙 自動適應系統的明暗主題

## ⚠️ 已知問題

- 在豆包（doubao.com）網頁中，使用 `/p` 觸發提示詞選擇器後部分輸入框會出現未清除 `/p` 的問題。不過別擔心，我與我的老搭檔 Cursor 正在日以繼夜地尋找解決方案，爭取早日修復！

## 🚀 使用方式

1. **快速觸發**：於任意網頁的文字輸入框中輸入 `/p` 以觸發提示詞選擇器
2. **快捷鍵開啟選擇器**：使用 `Ctrl+Shift+P`（Windows/Linux）或 `Command+Shift+P`（macOS）開啟提示詞選擇器
3. **選擇提示詞**：從彈出的選擇器中點選所需提示詞，將自動插入目前輸入框
4. **快速儲存提示詞**：選中任意文本後，使用 `Ctrl+Shift+S`（Windows/Linux）或 `Command+Shift+S`（macOS）快速儲存為提示詞
5. **右鍵選單儲存**：選中任意文本後，右鍵點擊並選擇「儲存該提示詞」，將選取內容儲存為提示詞
6. **匯出提示詞庫**：於管理頁面點擊「匯出」按鈕，將所有提示詞匯出為 JSON 檔案並儲存至本地
7. **匯入提示詞庫**：於管理頁面點擊「匯入」按鈕，從本地 JSON 檔案匯入提示詞（支援合併或覆蓋現有提示詞）

## 📸 介面預覽

Quick Prompt 提供直覺友善的使用介面，讓你輕鬆管理與使用提示詞。

### 提示詞選擇器

![提示詞選擇器](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![提示詞選擇器](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

使用 `/p` 快捷指令或快捷鍵可在任意輸入框中快速喚出提示詞選擇器，方便挑選並插入所需提示詞。

### 提示詞管理頁面

![提示詞管理](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

於管理頁面中，你可以建立新的提示詞、編輯現有提示詞、加入標籤以及進行分類管理。介面簡潔明瞭，操作便利。

### 右鍵選單儲存

![右鍵選單保存](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

只需選取網頁中任意文字，右鍵點擊即可將其快速儲存為提示詞，提升工作效率。

### 提示詞變數輸入

![提示詞變數彈窗](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

提示詞支援設定變數，選取後彈窗輸入對應變數值。

## ⚙️ 自訂設定

1. 點擊擴充圖示，然後點選「管理提示詞」按鈕
2. 在管理頁面，你可以:
   - 新增新的提示詞
   - 編輯現有提示詞
   - 刪除不需要的提示詞
   - 為提示詞新增標籤進行分類
   - 匯出提示詞庫進行備份
   - 匯入之前備份的提示詞庫

## 📦 安裝指南

### 從應用商店安裝

現已上架Chrome應用商店！[點擊此處下載安裝](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### 從 GitHub Releases 取得

1. 造訪 [GitHub Releases 頁面](https://github.com/wenyuanw/quick-prompt/releases)
2. 下載最新版本的已建構插件包
3. 解壓縮下載的檔案
4. 依照下方說明安裝已建構的擴充功能

### 從原始碼建構

1. 複製（clone）倉庫
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. 安裝相依套件
   ```bash
   pnpm install
   ```
3. 開發與建構

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### 安裝已建構的擴充功能

#### Chrome / Edge
1. 打開擴充功能管理頁面（`chrome://extensions` 或 `edge://extensions`）
2. 啟用「開發者模式」
3. 點擊「載入未封裝的擴充功能」
4. 選擇專案的 `.output/chrome-mv3/` 目錄

#### Firefox
1. 打開 `about:debugging`
2. 點擊「此 Firefox」
3. 點擊「臨時載入附加元件」
4. 選擇專案 `.output/firefox-mv2/` 目錄中的 `manifest.json` 檔案

## 📄 授權條款

MIT

## 🤝 貢獻指南

歡迎提交 Pull Requests 和 Issues！

1. Fork 此儲存庫
2. 建立你的功能分支（`git checkout -b feature/amazing-feature`）
3. 提交你的更改（`git commit -m 'Add some amazing feature'`）
4. 推送到分支（`git push origin feature/amazing-feature`）
5. 開啟一個 Pull Request

## 👏 貢獻者名單

感謝所有為本專案做出貢獻的開發者！

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---