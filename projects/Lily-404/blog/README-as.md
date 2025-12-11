
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
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Jimmy'ৰ ব্লগ

Next.js 15+ ৰ আধাৰত নিৰ্মিত এটা সহজ ব্যক্তিগত ব্লগ ব্যৱস্থা।

## প্ৰযুক্তি ধৰা

- **ফ্ৰেমৱৰ্ক**: Next.js 13+ (App Router)
- **ষ্টাইলিং**: Tailwind CSS
- **আইকন**: Lucide Icons
- **থিম**: গাঢ় ৰং/হালকা ৰং মোডৰ সমৰ্থন
- **ডিপ্লয়মেন্ট**: Vercel

## ফিচাৰ বৈশিষ্ট্যসমূহ

- 📝 Markdown প্ৰবন্ধ সমৰ্থিত
- 🌓 গাঢ় ৰং/হালকা ৰং থিম পৰিবৰ্তন
- 📱 প্ৰতিক্ৰিয়াশীল ডিজাইন
- ⚡ দ্ৰুত লোডিং
- 📅 প্ৰবন্ধ টাইমলাইন প্ৰদৰ্শন

## প্ৰকল্পৰ গঠন

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

## সংস্থাপন আৰু চলোৱা

1. প্ৰকল্পটো ক্লোন কৰক

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. নিৰ্ভৰশীলতা সমূহ স্থাপন কৰক

```bash
npm install
```

3. উন্নয়ন চাৰ্ভাৰ চলাও

```bash
npm run dev
```

4. উৎপাদন সংস্কৰণ নিৰ্মাণ কৰক

```bash
npm run build
```

## নতুন প্ৰবন্ধ যোগ কৰক

1. `content/posts` ডাইৰেক্টৰীত নতুন Markdown ফাইল সৃষ্টি কৰক
2. ফাইল নামকৰণৰ ফৰ্মেট: xxx.md`
3. ফাইলৰ মূৰত মেটাডাটা যোগ কৰক:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## স্মৰণী যোগ কৰক

1. `content/notes` ডিৰেক্টৰীত নতুন Markdown ফাইল সৃষ্টি কৰক
2. ফাইল নামাকৰণৰ ধৰণ: `YYYY-MM-DD-title.md`
3. ফাইলৰ মুৰত মেটাডাটা যোগ কৰক:

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