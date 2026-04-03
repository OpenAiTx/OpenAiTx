
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Jimmy's Blog

A minimalist personal blog system built with Next.js 15+, supporting online creation and static deployment.

## Tech Stack

- **Framework**: Next.js 15+ (App Router)
- **Language**: TypeScript
- **Style**: Tailwind CSS
- **Icons**: Lucide Icons
- **Content**: Markdown + Gray Matter + Remark
- **Authentication**: GitHub OAuth
- **Deployment**: Vercel

## Features

### Reader Side

- 📝 Markdown + GFM article rendering (including math formula display)
- 🏷️ Tag filtering, pagination, archiving (by year/tag)
- 📚 Article Table of Contents (TOC) and one-click code block copy
- 📱 Responsive layout and dark/light theme switching
- 🔥 Floating creative calendar heatmap (articles + essays)
- 📡 RSS feed output (`/rss.xml`)

### Creation Side (Admin Panel)

- 🔐 GitHub OAuth login (owner/collaborator permission verification)
- ✍️ Online creation, editing, and deletion of articles/essays
- 🆔 Custom file ID + automatic conflict avoidance
- 👀 Edit / Preview / Split-screen writing modes
- 📊 Creation statistics dashboard (total, weekly/monthly output, popular tags)

### Engineering Side

- ⚡ Multi-page static output (`force-static`) for enhanced performance and stability
- 🧭 Built-in sitemap and robots
- 🧩 Content read cache and modular API architecture

## Project Structure

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## Installation and Running

1. Clone the project

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Install Dependencies

```bash
npm install
```

3. Running the Development Server

```bash
npm run dev
```

4. Building the Production Version

```bash
npm run build
```

## Add a New Article

### Method 1: Online Admin Panel (Recommended)

1. Visit the `/admin` page
2. Log in using GitHub OAuth
3. Fill in the article information and submit
4. The article will be automatically created via the GitHub API, and Vercel will redeploy automatically

### Method 2: Manually Add Files

1. Create a new Markdown file in the `content/posts` directory
2. File naming format: `xxx.md`
3. Add metadata at the top of the file:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Add Essays

1. Create a new Markdown file in the `content/notes` directory
2. File naming format: `YYYY-MM-DD-title.md`
3. Add metadata at the beginning of the file:

```markdown
---
date: YYYY-MM-DD
---
```

## Configure Admin Dashboard

The admin dashboard uses GitHub OAuth for authentication, and only repository owners or collaborators can access it.

### 1. Create a GitHub OAuth App

1. Visit [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Click "New OAuth App"
3. Fill in the information:
   - **Application name**: `Jimmy Blog Admin` (or any name)
   - **Homepage URL**: `https://your-domain.com` (production) or `http://localhost:3000` (local development)
   - **Authorization callback URL**:
     - Production: `https://your-domain.com/api/auth/github/callback`
     - Local development: `http://localhost:3000/api/auth/github/callback`
4. Click "Register application"
5. Record the **Client ID**
6. Click "Generate a new client secret" and record the **Client secret**

### 2. Configure Environment Variables

Add the following environment variables in Vercel project settings:

- `GITHUB_CLIENT_ID`: Your GitHub OAuth App Client ID
- `GITHUB_CLIENT_SECRET`: Your GitHub OAuth App Client Secret
- `GITHUB_OWNER`: GitHub username (default: `Lily-404`, used to verify user permissions)
- `GITHUB_REPO`: Repository name (default: `blog`)
- `GITHUB_REDIRECT_URI`: OAuth callback URL (optional, auto-generated by default)
- `NEXT_PUBLIC_BASE_URL`: Your website URL (used to generate callback URL; must be set in production)
  - Production: `https://www.jimmy-blog.top`
  - Local development: `http://localhost:3000`

### 3. Local Development Configuration

Create a `.env.local` file in the project root directory:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Production Environment Configuration (Vercel)

In the Vercel project settings, make sure to set:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Note**: 
- The `.env.local` file has been added to `.gitignore` and will not be committed to Git
- For local development, make sure the OAuth App callback URL is set to `http://localhost:3000/api/auth/github/callback`
- **In production, you must set `NEXT_PUBLIC_BASE_URL` to `https://www.jimmy-blog.top`**
- The OAuth App callback URL for production should be set to: `https://www.jimmy-blog.top/api/auth/github/callback`

## Deployment

The project is configured for deployment on Vercel and supports automatic deployment. Simply push the code to the GitHub repository and Vercel will automatically build and deploy.

### Advantages of Using the Admin Panel

- ✅ No need for a local development environment
- ✅ Add articles anytime, anywhere
- ✅ Automatically trigger Vercel redeployment
- ✅ Completely free (GitHub OAuth and Vercel are within the free tier)
- ✅ Secure (GitHub OAuth authentication; only repo owners/collaborators can access)
- ✅ No password management needed, log in with your GitHub account
- ✅ Supports online editing of existing content (not just new posts)
- ✅ Automatically handles file ID conflicts to avoid overwriting and manual renaming
- ✅ Built-in creation statistics in the admin panel for continuous content operation

## Project Analysis & Future Roadmap

- Project analysis document: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Future roadmap document: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## Contribution

Issues and Pull Requests are welcome!

## License

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---