
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# TTS-Vue Web版本

🎤 微軟語音合成工具，Web版本，使用 `Vue` + `ElementPlus` + `Vite` 構建。

## 網站示例

https://web.tts88.top
### 新版本介面
![image](https://github.com/user-attachments/assets/177c8c0d-33d1-48e7-81e3-778f36d8fedd)

### 舊版本介面
![image](https://github.com/user-attachments/assets/67cafd2c-7b0f-4b0d-b14b-bf402aaff0cd)

## 功能特色

- 🌐 完全Web化，無需安裝桌面應用程式
- 🔊 支援微軟多種語音合成
- 🚀 支援TTS88 API整合
- 🆓 支援免費TTS調用，每日免費額度
- 🧠 支援OpenAI文字生成
- 🌍 支援多語言：中文、英文、西班牙語
- 🔐 瀏覽器指紋識別，提供更安全的使用者體驗

## 最新更新

### 介面重構與功能增強 (v2.2.0)

- 📱 **UI重構**：固定頂部導航，文字框採用吸頂模式，優化行動端適配
- 🔤 **SSML增強**：新增SSML格式化功能，設定變更時自動更新SSML
- 🎵 **播放器優化**：整合播放器至主介面，改進音訊播放及下載體驗
- 🎞️ **字幕功能**：新增線上產生字幕功能，提升內容創作效率
- 🌓 **主題優化**：改善深色模式下介面表現，新增全域主題切換
- 🛠️ **進階設定**：優化免費TTS服務介面，新增語速和音調配置
- 💡 **互動體驗**：新增工具提示功能，增強使用者操作指引
- 🔄 **依賴升級**：Vue升級至3.5.11，ElementPlus升級至2.9.9
- 🌐 **連結更新**：更新GitHub倉庫地址

### 免費TTS服務整合 (v2.1.0)

- 🆕 **免費TTS功能**：無需API密鑰，每日享有免費額度
- 👤 **瀏覽器指紋識別**：確保每位使用者公平使用免費額度
- 🔄 **額度狀態顯示**：即時顯示剩餘免費字元數及重置時間
- 🌐 **伺服器狀態檢測**：自動檢測免費TTS伺服器連線狀態
- 🛡️ **強化錯誤處理**：更友善的錯誤提示及狀態回饋
- 🎛️ **免費TTS設定面板**：方便使用者配置及查詢額度資訊

### 介面與使用者體驗優化 (v2.0.0)

- ✨ **設定區域優化**：設定面板支援摺疊，點擊「語音設定」標題即可展開/摺疊
- 🔘 **智慧按鈕位置**：「開始轉換」按鈕移至頂部，無需捲動即可點擊
- 💬 **狀態提示增強**：新增直觀的轉換狀態提示文字
- 🎨 **視覺效果改進**：按鈕加入光效動畫，提升使用者體驗
- 📱 **響應式佈局優化**：改善在不同螢幕尺寸下的顯示效果

這些改進大大提升了使用效率，特別是解決了傳統設計中用戶需要捲動到頁面底部才能點擊「開始轉換」按鈕的問題。現在，無論用戶在頁面的哪個位置，都可以輕鬆啟動轉換流程。

## 開發計劃

> **📢 重要通知：桌面版本正在開發中！**
> 我們正在開發跨平台桌面應用版本，將支援更多功能和更佳的用戶體驗。
> 敬請期待後續更新，請關注專案動態取得最新資訊。

## 快速開始

### 開發環境

```bash
# 克隆仓库
git clone https://github.com/henryhu55/tts-web-vue.git

# 安装依赖
yarn install

# 启动开发服务器
yarn dev
```

### 生產構建

```bash
# 构建生产版本
yarn build

# 预览生产版本
yarn preview
```

## 部署

構建完成後，將 `dist` 目錄的內容部署到任何靜態 Web 伺服器上即可。

## API 設定

本網頁版目前支援免費 TTS 服務、TTS88 API 及 OpenAI API：

### 免費 TTS 服務設定

1. 在設定頁面中找到「免費 TTS 服務」選項
2. 系統預設已配置免費 TTS 伺服器地址
3. 您可以查看當日剩餘免費額度及重置時間
4. 每個瀏覽器客戶端擁有獨立的免費額度

### TTS88 API 設定

1. 在設定頁面中找到「第三方 API URL」設定選項
2. 輸入您的 TTS88 API 地址
3. 若有 API 密鑰，請輸入至「TTS88 API 密鑰」欄位

### OpenAI API 設定

1. 在設定頁面中找到 OpenAI 設定選項
2. 輸入您的 OpenAI API 密鑰
3. 選擇要使用的模型（預設為 gpt-3.5-turbo）
4. 若使用自托管或代理，可設定自訂 API Base URL

## 注意事項

- 資料僅儲存於瀏覽器本地儲存空間，刷新或清除快取不會影響其他使用者
- 轉換後的音訊檔案可直接於瀏覽器中播放或下載至本機
- 免費 TTS 服務每日有使用額度限制，超過需等候次日重置

## 技術堆疊

- Vue 3.2
- Pinia
- ElementPlus
- Vite

## 许可证

MIT 授權條款

## 開始使用

- [專案簡介](https://docs.tts88.top//guide/intro.html)
- [安裝運行](https://docs.tts88.top//guide/install.html)
- [功能介紹](https://docs.tts88.top/guide/features.html)
- [常見問題](https://docs.tts88.top//guide/qa.html)
- [更新日誌](https://docs.tts88.top//guide/update.html)

## 注意

本軟體及其程式碼僅供個人學習與測試之用，請於下載後24小時內刪除，不得用於商業用途，否則後果自負。任何違規使用所造成的法律後果與本人無關。本軟體永遠不會收費，如您於使用前曾支付額外費用，或付費獲取原始碼或成品軟體，則必定為詐騙！

**轉載請註明出處。禁止以加群、私信等方式誘導他人獲取軟體倉庫、下載地址及安裝包。**

### 意見問題回饋、版本發布企鵝群：

`【tts-web-vue問題反饋群1】279895662`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---