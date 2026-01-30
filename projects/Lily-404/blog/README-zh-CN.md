
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

# Jimmy的博客

一个基于 Next.js 15+ 构建的极简个人博客系统。

## 技术栈

- **框架**: Next.js 13+（App Router）
- **样式**: Tailwind CSS
- **Icon**: Lucide Icons
- **Theme**: Supports dark/light mode switching
- **Deployment**: Vercel

## Features

- 📝 Markdown article support
- 🌓 Dark/light theme switching
- 📱 Responsive design
- ⚡ Fast loading
- 📅 Article timeline display
- 🔐 Online management dashboard (create articles directly via GitHub API)

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

## 安装与运行

1. 克隆项目

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. 安装依赖

```bash
npm install
```
3. 运行开发服务器


```bash
npm run dev
```

4. 构建生产版本

```bash
npm run build
```

## 添加新文章

### 方式一：在线管理后台（推荐）

1. 访问 `/admin` 页面
2. 使用管理员密码登录
3. 填写文章信息并提交
4. 文章会自动通过 GitHub API 创建，Vercel 会自动重新部署

### 方式二：手动添加文件

1. 在 `content/posts` 目录下创建新的 Markdown 文件
2. 文件命名格式：xxx.md`
3. 在文件头部添加元数据：

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## 添加随笔

1. 在 `content/notes` 目录下创建新的 Markdown 文件
2. 文件命名格式：`YYYY-MM-DD-title.md`
3. 在文件头部添加元数据：

```markdown
---
date: YYYY-MM-DD
---
```

## 配置管理后台

管理后台使用 GitHub OAuth 进行身份验证，只有仓库所有者或协作者才能访问。

### 1. 创建 GitHub OAuth 应用

1. 访问 [GitHub 设置 > 开发者设置 > OAuth 应用](https://github.com/settings/developers)
2. 点击 "New OAuth App"
3. 填写信息：
   - **Application name**：`Jimmy Blog Admin`（或任意名称）
   - **Homepage URL**：`https://你的域名.com`（生产环境）或 `http://localhost:3000`（本地开发）
   - **Authorization callback URL**：
     - 生产环境: `https://你的域名.com/api/auth/github/callback`
     - 本地开发: `http://localhost:3000/api/auth/github/callback`
4. 点击 "Register application"
5. 记录 **Client ID**
6. 点击 "Generate a new client secret"，记录 **Client secret**

### 2. 配置环境变量

在 Vercel 项目设置中添加以下环境变量：

- `GITHUB_CLIENT_ID`：你的 GitHub OAuth App Client ID
- `GITHUB_CLIENT_SECRET`：你的 GitHub OAuth App Client Secret
- `GITHUB_OWNER`：GitHub 用户名（默认：`Lily-404`，用于验证用户权限）
- `GITHUB_REPO`：仓库名称（默认：`blog`）
- `GITHUB_REDIRECT_URI`：OAuth 回调 URL（可选，默认自动生成）
- `NEXT_PUBLIC_BASE_URL`：你的网站 URL（用于生成回调 URL，生产环境必须设置）
  - 生产环境: `https://www.jimmy-blog.top`
  - 本地开发: `http://localhost:3000`

### 3. 本地开发配置

在项目根目录创建 `.env.local` 文件：

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. 生产环境配置（Vercel）

在 Vercel 项目设置中，确保设置：

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **注意**:
- `.env.local` 文件已被添加到 `.gitignore`，不会被提交到 Git
- 本地开发时，请确保 OAuth 应用的回调 URL 设置为 `http://localhost:3000/api/auth/github/callback`
- **生产环境必须将 `NEXT_PUBLIC_BASE_URL` 设置为 `https://www.jimmy-blog.top`**
- 生产环境下的 OAuth 应用回调 URL 应设置为：`https://www.jimmy-blog.top/api/auth/github/callback`

## 部署

项目已配置 Vercel 部署，支持自动化部署。只需将代码推送到 GitHub 仓库，Vercel 会自动构建并部署。

### 使用管理后台的优势

- ✅ 无需本地开发环境
- ✅ 可以随时随地添加文章
- ✅ 自动触发 Vercel 重新部署
- ✅ 完全免费（GitHub OAuth 和 Vercel 均在免费额度内）
- ✅ 安全（GitHub OAuth 验证，仅仓库所有者/协作者可访问）
- ✅ 无需管理密码，直接用 GitHub 账号登录

## 贡献

欢迎提交 Issue 和 Pull Request！

## 许可证

MIT 许可证


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---