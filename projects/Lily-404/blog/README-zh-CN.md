# Jimmy's Blog

A minimalist personal blog system built with Next.js 15+.

## 技术栈

- **框架**: Next.js 13+ (App Router)
- **样式**: Tailwind CSS
- **图标**: Lucide Icons
- **主题**: Supports dark/light mode toggle
- **部署**: Vercel

## 功能特点

- 📝 Markdown article support
- 🌓 Dark/light theme toggle
- 📱 Responsive design
- ⚡ Fast loading
- 📅 Article timeline display

## 项目结构

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

## 部署

项目已配置 Vercel 部署，支持自动部署。只需将代码推送到 GitHub 仓库，Vercel 会自动构建和部署。

## 贡献

欢迎提交 Issue 和 Pull Request！

## 许可证

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---