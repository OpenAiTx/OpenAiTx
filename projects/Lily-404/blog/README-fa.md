
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

# وبلاگ جیمی

یک سیستم وبلاگ شخصی مینیمال که بر پایه Next.js 15+ ساخته شده است.

## تکنولوژی‌های مورد استفاده

- **فریمورک**: Next.js 13+ (App Router)
- **استایل**: Tailwind CSS
- **آیکون‌ها**: Lucide Icons
- **تم**: پشتیبانی از تغییر حالت تیره/روشن
- **استقرار**: Vercel

## ویژگی‌های کلیدی

- 📝 پشتیبانی از مقالات Markdown
- 🌓 تغییر حالت تم تیره/روشن
- 📱 طراحی واکنش‌گرا
- ⚡ بارگذاری سریع
- 📅 نمایش خط زمانی مقالات

## ساختار پروژه

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

## نصب و اجرا

1. کلون کردن پروژه

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. نصب وابستگی‌ها

```bash
npm install
```

3. اجرای سرور توسعه

```bash
npm run dev
```

۴. ساخت نسخه تولیدی

```bash
npm run build
```

## افزودن مقاله جدید

1. یک فایل Markdown جدید در پوشه `content/posts` ایجاد کنید
2. فرمت نام‌گذاری فایل: xxx.md`
3. در ابتدای فایل، متادیتا را اضافه کنید:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## افزودن یادداشت

1. در پوشه `content/notes` یک فایل Markdown جدید بسازید
2. قالب نام‌گذاری فایل: `YYYY-MM-DD-title.md`
3. در ابتدای فایل، فراداده را اضافه کنید:

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