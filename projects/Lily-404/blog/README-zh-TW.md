
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
- **主題**: 支援深色/淺色模式切換
- **部署**: Vercel

## 功能特色

- 📝 支援 Markdown 文章
- 🌓 深色/淺色主題切換
- 📱 響應式設計
- ⚡ 快速載入
- 📅 文章時間軸展示

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

1. 在 `content/posts` 目錄下建立新的 Markdown 檔案
2. 檔案命名格式：xxx.md`
3. 在檔案開頭加入中繼資料：

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

## 部署

项目已配置 Vercel 部署，支持自动部署。只需将代码推送到 GitHub 仓库，Vercel 会自动构建和部署。

## 贡献

欢迎提交 Issue 和 Pull Request！

## 许可证

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---