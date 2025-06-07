# EmuReady

一個由社群驅動的平台，用於追蹤不同裝置與模擬器的相容性。

造訪我們的網站：[https://emuready.com](https://emuready.com)

---

**首頁截圖**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**相容性清單頁面截圖**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**遊戲頁面截圖**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## 概覽

EmuReady 協助使用者分享並探索不同硬體與軟體組合的模擬器相容性資訊。使用者可以貢獻相容性報告、對清單進行投票，並討論特定遊戲/裝置/模擬器組合。

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## 功能

- **完整的相容性資料庫**：追蹤遊戲在不同模擬器與裝置上的運行情況
- **用戶貢獻**：社群驅動的報告與投票系統
- **討論系統**：具備讚/踩功能的留言串
- **管理後台**：管理用戶、清單與內容審核
- **響應式設計**：支援手機、平板與桌機

## 最近改進

程式碼庫已大幅改善，包含以下增強內容：

### UI 元件

- 建立 **ErrorBoundary** 元件，用於更好的錯誤處理與恢復
- 新增 **OptimizedImage** 元件，利用 Next.js Image 元件提升效能
- 改進 **Pagination**，增加無障礙功能、鍵盤導航與更佳 UX
- 強化 **Badge** 元件，提供更多樣式、尺寸與膠囊選項
- 新增 **ThemeToggle** 元件，可切換亮色、暗色與系統主題
- 實作 **SortableHeader**，表格排序具備視覺指示

### 快取與效能

- 改善 React Query 設定，預設更佳的快取、過期時間與重試邏輯
- 為裝置圖片新增圖像優化
- 全站實作正確的錯誤處理

### 無障礙

- 強化互動元素的鍵盤導航
- 新增正確的 ARIA 標籤與角色
- 改善焦點管理
- UI 元件提升色彩對比

### 安全性

- 多層級（前端、後端、資料庫）資料驗證與淨化
- 實作內容安全政策（CSP）
- 防範 XSS 及 CSRF 攻擊
- 以 NextAuth.js 進行安全認證
- 檔案上傳驗證與安全機制
- 輸入長度限制與正確的淨化處理
- UUID 驗證，防止參數竄改

### 開發體驗

- 新增更多 npm 腳本以優化開發流程
- 更佳的專案結構與一致的匯出
- 使用自訂 ErrorBoundary 強化錯誤回饋
- 改善 404 頁面，提供有用的導覽選項

### 主題設計

- 新增系統主題偏好偵測
- 建立多種 UI 選項的主題切換
- 全站改進暗色模式效果

## 快速開始

### 先決條件

- Node.js 20+
- `npm`
- PostgreSQL（或開發用 SQLite）

### 安裝

1. 複製儲存庫

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. 安裝依賴

```bash
npm install
```

3. 設定環境變數

```bash
cp .env.example .env
```

然後編輯 `.env` 檔，填入你的資料庫帳號和其他設定。

4. 設定資料庫

```bash
npx prisma generate
npx prisma db push
```

5. 啟動開發伺服器

```bash
npm run dev
```

6. 在瀏覽器開啟 [http://localhost:3000](http://localhost:3000)

## 可用指令

- `npm run dev` - 啟動開發伺服器
- `npm run dev:strict` - 以 React 嚴格模式啟動
- `npm run build` - 建置生產版本
- `npm run start` - 啟動生產伺服器
- `npm run test` - 執行測試
- `npm run lint` - 執行 ESLint
- `npm run lint:fix` - 修正 lint 問題
- `npm run format` - 用 Prettier 格式化程式碼
- `npm run typecheck` - 檢查 TypeScript 型別
- `npm run analyze` - 分析 bundle 大小
- `npm run clean` - 清除建置快取
- `npm run prepare-deploy` - 部署前準備（lint、型別檢查、測試、建置）

### Prisma 指令

- `npx prisma db seed` - 填充資料庫種子資料
- `npx prisma studio` - 開啟 Prisma Studio
- `npx prisma db pull` - 取得資料庫結構
- `npx prisma db push` - 推送資料庫結構

詳細資訊請參閱 [Prisma Cli Reference](https://www.prisma.io/docs/orm/reference/prisma-cli-reference)。

## 技術棧

- **框架**：Next.js 15
- **資料庫 ORM**：Prisma
- **API**：tRPC
- **認證**：NextAuth.js
- **樣式**：Tailwind CSS
- **狀態管理**：React Query
- **型別檢查**：TypeScript
- **動畫**：Framer Motion
- **驗證**：Zod、內容安全政策、輸入驗證

## 貢獻

歡迎貢獻！請參閱我們的 [貢獻指南](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) 以獲得更多資訊。

## 授權

本專案採用 MIT 授權，詳見 [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) 文件。

## 行為準則（待辦）

請注意，本專案遵循[行為準則](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md)。參與本專案即表示你同意遵守其條款。

## 安全性（待辦）

若你發現安全漏洞，請依照我們的[安全政策](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) 進行回報。

## 鳴謝

- 所有的[貢獻者](https://github.com/Producdevity/emuready/graphs/contributors)
- 模擬器社群的啟發與支持

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---