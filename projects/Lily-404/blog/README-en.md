
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

## Add New Article

1. Create a new Markdown file in the `content/posts` directory  
2. File naming format: xxx.md`  
3. Add metadata at the beginning of the file:  

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

## 部署

项目已配置 Vercel 部署，支持自动部署。只需将代码推送到 GitHub 仓库，Vercel 会自动构建和部署。

## 贡献

欢迎提交 Issue 和 Pull Request！

## 许可证

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---