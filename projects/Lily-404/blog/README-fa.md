
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
- **تم**: پشتیبانی از تغییر حالت تاریک/روشن
- **استقرار**: Vercel

## ویژگی‌ها

- 📝 پشتیبانی از مقالات Markdown
- 🌓 تغییر حالت تم تاریک/روشن
- 📱 طراحی واکنش‌گرا
- ⚡ بارگذاری سریع
- 📅 نمایش تایم‌لاین مقالات
- 🔐 پنل مدیریت آنلاین (ایجاد مقاله مستقیم از طریق GitHub API)

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

### روش اول: پنل مدیریت آنلاین (توصیه می‌شود)

1. به صفحه `/admin` مراجعه کنید
2. با رمز عبور مدیر وارد شوید
3. اطلاعات مقاله را وارد کرده و ارسال کنید
4. مقاله به صورت خودکار از طریق GitHub API ایجاد می‌شود و Vercel به طور خودکار دوباره مستقر می‌شود

### روش دوم: افزودن دستی فایل

1. یک فایل مارک‌داون جدید در پوشه `content/posts` ایجاد کنید
2. قالب نام‌گذاری فایل: xxx.md`
3. در ابتدای فایل، فراداده‌ها را اضافه کنید:

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

## پیکربندی پنل مدیریت

پنل مدیریت از GitHub OAuth برای احراز هویت استفاده می‌کند و فقط مالک مخزن یا همکاران می‌توانند به آن دسترسی داشته باشند.

### ۱. ایجاد GitHub OAuth App

1. به [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers) مراجعه کنید
2. روی "New OAuth App" کلیک کنید
3. اطلاعات را وارد کنید:
   - **Application name**: `Jimmy Blog Admin` (یا هر نام دلخواه)
   - **Homepage URL**: `https://دامنه-شما.com` (محیط تولید) یا `http://localhost:3000` (توسعه محلی)
   - **Authorization callback URL**: 
     - محیط تولید: `https://دامنه-شما.com/api/auth/github/callback`
     - توسعه محلی: `http://localhost:3000/api/auth/github/callback`
4. روی "Register application" کلیک کنید
5. **Client ID** را یادداشت کنید
6. روی "Generate a new client secret" کلیک کرده و **Client secret** را یادداشت کنید

### ۲. پیکربندی متغیرهای محیطی

در تنظیمات پروژه Vercel متغیرهای محیطی زیر را اضافه کنید:

- `GITHUB_CLIENT_ID`: Client ID مربوط به GitHub OAuth App شما
- `GITHUB_CLIENT_SECRET`: Client Secret مربوط به GitHub OAuth App شما
- `GITHUB_OWNER`: نام کاربری GitHub (پیش‌فرض: `Lily-404` برای اعتبارسنجی دسترسی کاربر)
- `GITHUB_REPO`: نام مخزن (پیش‌فرض: `blog`)
- `GITHUB_REDIRECT_URI`: آدرس بازگشت OAuth (اختیاری، به طور پیش‌فرض خودکار تولید می‌شود)
- `NEXT_PUBLIC_BASE_URL`: آدرس سایت شما (برای تولید آدرس بازگشت، باید در محیط تولید تنظیم شود)
  - محیط تولید: `https://www.jimmy-blog.top`
  - توسعه محلی: `http://localhost:3000`

### ۳. پیکربندی توسعه محلی

در ریشه پروژه یک فایل به نام `.env.local` ایجاد کنید:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. پیکربندی محیط تولید (Vercel)

در تنظیمات پروژه Vercel، اطمینان حاصل کنید که موارد زیر را تنظیم کنید:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```
⚠️ **توجه**:
- فایل `.env.local` به `.gitignore` اضافه شده و به Git ارسال نخواهد شد
- هنگام توسعه محلی، مطمئن شوید URL بازگشت OAuth App روی `http://localhost:3000/api/auth/github/callback` تنظیم شده باشد
- **در محیط تولید باید `NEXT_PUBLIC_BASE_URL` را روی `https://www.jimmy-blog.top` تنظیم کنید**
- URL بازگشت OAuth App در محیط تولید باید این باشد: `https://www.jimmy-blog.top/api/auth/github/callback`

## استقرار

پروژه برای استقرار روی Vercel پیکربندی شده و از استقرار خودکار پشتیبانی می‌کند. کافی است کد را به مخزن GitHub پوش کنید تا Vercel به طور خودکار آن را بسازد و مستقر کند.

### مزایای استفاده از پنل مدیریت

- ✅ بدون نیاز به محیط توسعه محلی
- ✅ افزودن مقاله در هر زمان و مکان
- ✅ فعال‌سازی خودکار استقرار مجدد Vercel
- ✅ کاملاً رایگان (GitHub OAuth و Vercel هر دو در سهمیه رایگان قرار دارند)
- ✅ ایمن (احراز هویت GitHub OAuth، فقط مالک/همکاران مخزن دسترسی دارند)
- ✅ بدون نیاز به مدیریت رمز عبور، ورود با حساب GitHub

## مشارکت

ارسال Issue و Pull Request خوش‌آمد است!

## مجوز

MIT License



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---