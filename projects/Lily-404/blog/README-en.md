
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# Jimmy's Blog

A minimalist personal blog system built with Next.js 15+.

## Technology Stack

- **Framework**: Next.js 13+ (App Router)
- **Style**: Tailwind CSS
- **Icon**: Lucide Icons
- **Theme**: Supports dark/light mode switching
- **Deployment**: Vercel

## Features

- 📝 Markdown article support
- 🌓 Dark/light theme switching
- 📱 Responsive design
- ⚡ Fast loading
- 📅 Article timeline display
- 🔐 Online admin dashboard (direct article creation via GitHub API)

## Project Structure

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

## Adding a New Article

### Method 1: Online Admin Panel (Recommended)

1. Visit the `/admin` page
2. Log in using the admin password
3. Fill in the article information and submit
4. The article will be automatically created via the GitHub API, and Vercel will redeploy automatically

### Method 2: Manually Add Files

1. Create a new Markdown file in the `content/posts` directory
2. File naming format: xxx.md
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
- For local development, make sure the OAuth App's callback URL is set to `http://localhost:3000/api/auth/github/callback`
- **In production, `NEXT_PUBLIC_BASE_URL` must be set to `https://www.jimmy-blog.top`**
- The OAuth App callback URL for production should be set to: `https://www.jimmy-blog.top/api/auth/github/callback`

## Deployment

The project is configured for Vercel deployment and supports automatic deployment. Simply push your code to the GitHub repository, and Vercel will automatically build and deploy it.

### Advantages of Using the Admin Panel

- ✅ No need for a local development environment
- ✅ Add articles anytime, anywhere
- ✅ Automatically trigger Vercel redeployment
- ✅ Completely free (both GitHub OAuth and Vercel are within the free tier)
- ✅ Secure (GitHub OAuth authentication, only repository owners/collaborators can access)
- ✅ No need to manage passwords, log in with your GitHub account

## Contribution

Issues and Pull Requests are welcome!

## License

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---