
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Jimmy's Blog

一個基於 Next.js 15+ 構建的簡約個人部落格系統。

## 技術棧

- **框架**: Next.js 13+ (App Router)
- **樣式**: Tailwind CSS
- **圖標**: Lucide Icons
- **主題**: 支援深色／淺色模式切換
- **部署**: Vercel

## 功能特色

- 📝 支援 Markdown 文章
- 🌓 深色／淺色主題切換
- 📱 響應式設計
- ⚡ 快速載入
- 📅 文章時間軸展示
- 🔐 線上管理後台（透過 GitHub API 直接建立文章）

## 專案結構

```
.
├── app/
│   ├── lib/           # 工具函数和数据处理
│   ├── posts/         # 博客文章
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## 安裝與執行

1. 複製專案

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. 安裝依賴

```bash
npm install
```

3. 執行開發伺服器

```bash
npm run dev
```

4. 建構生產版本

```bash
npm run build
```

## 新增文章

### 方式一：線上管理後台（推薦）

1. 訪問 `/admin` 頁面
2. 使用管理員密碼登入
3. 填寫文章資訊並提交
4. 文章會自動通過 GitHub API 創建，Vercel 會自動重新部署

### 方式二：手動新增檔案

1. 在 `content/posts` 目錄下建立新的 Markdown 檔案
2. 檔案命名格式：xxx.md`
3. 在檔案開頭新增中繼資料：

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## 新增隨筆

1. 在 `content/notes` 目錄下建立新的 Markdown 檔案
2. 檔案命名格式：`YYYY-MM-DD-title.md`
3. 在檔案開頭加入中繼資料：

```markdown
---
date: YYYY-MM-DD
---
```

## 配置管理後台

管理後台使用 GitHub OAuth 進行身份驗證，只有倉庫所有者或協作者才能訪問。

### 1. 創建 GitHub OAuth App

1. 訪問 [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. 點擊 "New OAuth App"
3. 填寫信息：
   - **Application name**: `Jimmy Blog Admin`（或任意名稱）
   - **Homepage URL**: `https://你的網域.com`（生產環境）或 `http://localhost:3000`（本地開發）
   - **Authorization callback URL**: 
     - 生產環境: `https://你的網域.com/api/auth/github/callback`
     - 本地開發: `http://localhost:3000/api/auth/github/callback`
4. 點擊 "Register application"
5. 記錄 **Client ID**
6. 點擊 "Generate a new client secret"，記錄 **Client secret**

### 2. 配置環境變數

在 Vercel 項目設置中添加以下環境變數：

- `GITHUB_CLIENT_ID`: 你的 GitHub OAuth App Client ID
- `GITHUB_CLIENT_SECRET`: 你的 GitHub OAuth App Client Secret
- `GITHUB_OWNER`: GitHub 使用者名稱（預設: `Lily-404`，用於驗證使用者權限）
- `GITHUB_REPO`: 倉庫名稱（預設: `blog`）
- `GITHUB_REDIRECT_URI`: OAuth 回調 URL（可選，預設自動生成）
- `NEXT_PUBLIC_BASE_URL`: 你的网站 URL（用於生成回調 URL，生產環境必須設置）
  - 生產環境: `https://www.jimmy-blog.top`
  - 本地開發: `http://localhost:3000`

### 3. 本地開發配置

在項目根目錄建立 `.env.local` 檔案：

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. 生產環境配置（Vercel）

在 Vercel 專案設定中，請確保設定：

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```
⚠️ **注意**:
- `.env.local` 檔案已加入 `.gitignore`，不會被提交到 Git
- 本地開發時，請確保 OAuth App 的回調 URL 設定為 `http://localhost:3000/api/auth/github/callback`
- **生產環境必須將 `NEXT_PUBLIC_BASE_URL` 設定為 `https://www.jimmy-blog.top`**
- 生產環境的 OAuth App 回調 URL 應設定為: `https://www.jimmy-blog.top/api/auth/github/callback`

## 部署

本專案已配置 Vercel 部署，支援自動部署。只需將程式碼推送至 GitHub 倉庫，Vercel 會自動構建並部署。

### 使用管理後台的優勢

- ✅ 無需本地開發環境
- ✅ 隨時隨地新增文章
- ✅ 自動觸發 Vercel 重新部署
- ✅ 完全免費（GitHub OAuth 與 Vercel 均在免費額度內）
- ✅ 安全（GitHub OAuth 驗證，僅倉庫擁有者/協作者可訪問）
- ✅ 無需管理密碼，使用 GitHub 帳號即可登入

## 貢獻

歡迎提交 Issue 與 Pull Request！

## 授權條款

MIT License



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---