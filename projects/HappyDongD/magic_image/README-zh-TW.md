
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 魔法AI繪畫

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

一個基於 Next.js 開發的 AI 繪圖應用，具有以下主要功能：
- 🎨 支援多種 AI 模型（Sora、DALL-E、GPT、GEMINI 等）及自訂模型新增
- 🖼️ 提供文字生成圖片及圖片生成圖片功能，支援多圖參考與區域編輯
- 🔐 所有資料與 API 金鑰本地儲存，保障隱私安全
- 💻 支援網頁版及桌面應用程式封裝，跨平台使用

## 線上體驗

訪問地址：[https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### 應用截圖

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="應用截圖4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="應用截圖4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="應用截圖1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="應用截圖2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="應用截圖3" width="800" style="margin-bottom: 20px"/>
</div>

## 功能特色

- 🎨 支援多種 AI 模型
  - GPT Sora_Image 模型
  - GPT 4o_Image 模型
  - GPT Image 1 模型
  - DALL-E 3 模型
  - GEMINI 模型
  - 🆕 自訂模型（支援新增私有模型）
- 🔄 多模型切換
  - 支援在不同模型間快速切換
  - 每個模型皆有獨立設定選項
- ✍️ 文字生成圖片功能
  - 支援自訂提示詞
  - 可選擇圖片比例
  - 支援多種圖片尺寸
- 🖼️ 圖片生成圖片功能
  - 支援圖片編輯
  - 支援區域遮罩編輯
  - 支援圖片品質調整
  - 支援多圖參考（可同時上傳多張圖片）
- 🔒 資料安全
  - 所有生成的圖片和歷史記錄僅保存在本地瀏覽器中
  - 支援自訂 API 代理地址
  - 支援 API Key 設定
- 📱 UI設計
  - 現代化的使用者介面
  - 流暢的互動體驗
  - Markdown 格式展示
  - 程式碼高亮支援
- 🖥️ 跨平台支援
  - 支援打包為桌面應用程式（Windows、macOS、Linux）
  - 支援離線使用（需設定API介面）

## 技術堆疊

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri（桌面應用打包）

## 本地開發

1. 複製專案
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. 安裝依賴

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. 啟動開發伺服器

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. 訪問 [http://localhost:3000](http://localhost:3000)

## 桌面應用打包

本專案使用 Tauri 進行桌面應用打包，支援 Windows、macOS 和 Linux 系統。

### 環境準備

在打包桌面應用前，需要安裝以下相依套件：

1. **安裝 Rust**：
   - 訪問 [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - 按照指引安裝 Rust 和 Cargo

2. **系統相依套件**：
   - **Windows**: 安裝 [Visual Studio C++ 建置工具](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: 安裝 Xcode 命令列工具 (`xcode-select --install`)
   - **Linux**: 安裝相關相依套件，詳見 [Tauri 文件](https://tauri.app/v1/guides/getting-started/prerequisites)

### 開發模式


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### 建構桌面應用程式


```bash
# 构建桌面应用安装包
npm run desktop
```
構建完成後，可以在 `src-tauri/target/release/bundle` 目錄找到對應系統的安裝包。

## Vercel 部署

1. Fork 本項目到你的 GitHub 帳號

2. 在 [Vercel](https://vercel.com) 上建立新項目

3. 匯入你的 GitHub 倉庫

4. 點擊部署

## 使用說明

1. 首次使用需要配置 API 金鑰
   - 點擊右上角的「金鑰設置」
   - 輸入 API 金鑰和基礎地址
   - 點擊儲存
   - 也可以通過 URL 參數快速配置：

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     注意：URL 中的特殊字元需要進行 URL 編碼

2. 選擇生成模式
   - 文生圖：透過文字描述生成圖片
   - 圖生圖：上傳圖片進行編輯

3. 設定生成參數
   - 選擇 AI 模型（內建模型或自訂模型）
   - 設定圖片比例
   - 調整圖片品質（圖生圖模式）

4. 自訂模型管理
   - 點擊模型選擇框旁的設定圖示
   - 新增模型：輸入模型名稱、模型值並選擇模型類型
   - 編輯模型：點擊現有模型的編輯按鈕
   - 刪除模型：點擊現有模型的刪除按鈕
   - 選擇模型：點擊模型的加號按鈕立即選擇使用該模型

5. 模型類型說明
   - DALL-E 格式：使用圖像生成介面（/v1/images/generations）
   - OpenAI 格式：使用聊天介面（/v1/chat/completions）

6. 生成圖片
   - 輸入提示詞
   - 點擊「生成圖片」按鈕
   - 等待生成完成

7. 圖片管理
   - 檢視歷史紀錄
   - 下載生成的圖片
   - 編輯現有圖片

## 注意事項

- 所有生成的圖片和歷史紀錄僅保存於本地瀏覽器中
- 使用隱私模式或更換裝置會導致資料遺失
- 請及時下載並備份重要圖片
- API 設定將安全地儲存在您的瀏覽器，不會上傳至伺服器
- HTTPS 網站載入 HTTP 資源會被瀏覽器阻擋，應用程式會自動將 HTTP 介面轉換為 HTTPS

## 貢獻指南

歡迎提交 Issue 和 Pull Request 來協助改進本專案。

## 授權條款

本專案採用 [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0) 授權條款。

根據授權條款，您可以：
- ✅ 商業用途：可將軟體用於商業用途
- ✅ 修改：可修改軟體原始碼
- ✅ 分發：可分發軟體
- ✅ 私人使用：可私人使用軟體
- ✅ 專利授權：本授權條款亦提供專利授權

但必須遵守以下條件：
- 📝 授權及版權聲明：必須保留原始授權與版權聲明
- 📝 變更聲明：須聲明對原始程式碼的重大變更
- 📝 商標聲明：不得使用貢獻者的商標

---

## 請我喝杯咖啡

如果這個專案對你有幫助，歡迎請我喝杯咖啡 ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="微信收款碼" width="300" />
  <p>請我喝杯咖啡</p>
</div>

## 聯絡方式

如果您有任何問題或建議，歡迎透過微信聯繫我：

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="微信聯絡方式" width="300" />
  <p>掃描二維碼添加微信</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---