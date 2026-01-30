
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# مدونة جيمي

نظام مدونة شخصية بسيط مبني باستخدام Next.js 15+.

## حزمة التقنيات

- **الإطار**: Next.js 13+ (App Router)
- **الأنماط**: Tailwind CSS
- **الأيقونات**: Lucide Icons
- **السمة**: دعم التبديل بين الوضع الداكن/الفاتح
- **النشر**: Vercel

## الميزات الرئيسية

- 📝 دعم مقالات Markdown
- 🌓 تبديل السمة بين الوضع الداكن/الفاتح
- 📱 تصميم متجاوب
- ⚡ تحميل سريع
- 📅 عرض الجدول الزمني للمقالات
- 🔐 لوحة إدارة عبر الإنترنت (إنشاء المقالات مباشرةً عبر GitHub API)

## هيكل المشروع

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

## التثبيت والتشغيل

1. استنساخ المشروع

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. تثبيت الاعتمادات

```bash
npm install
```

3. تشغيل خادم التطوير

```bash
npm run dev
```

4. بناء إصدار الإنتاج

```bash
npm run build
```

## إضافة مقال جديد

### الطريقة الأولى: لوحة الإدارة الإلكترونية (موصى بها)

1. قم بزيارة صفحة `/admin`
2. سجل الدخول باستخدام كلمة مرور المدير
3. أدخل معلومات المقالة ثم أرسلها
4. سيتم إنشاء المقالة تلقائيًا عبر GitHub API، وستقوم Vercel بإعادة النشر تلقائيًا

### الطريقة الثانية: الإضافة اليدوية للملفات

1. أنشئ ملف Markdown جديد في مجلد `content/posts`
2. تنسيق اسم الملف: xxx.md`
3. أضف بيانات التعريف في بداية الملف:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## إضافة مقالة

1. أنشئ ملف Markdown جديد في دليل `content/notes`
2. تنسيق اسم الملف: `YYYY-MM-DD-title.md`
3. أضف بيانات التعريف في رأس الملف:

```markdown
---
date: YYYY-MM-DD
---
```

## إعداد لوحة الإدارة

تستخدم لوحة الإدارة مصادقة GitHub OAuth، ولا يمكن الوصول إليها إلا من قبل مالك المستودع أو المتعاونين.

### 1. إنشاء تطبيق GitHub OAuth

1. انتقل إلى [إعدادات GitHub > إعدادات المطور > تطبيقات OAuth](https://github.com/settings/developers)
2. انقر على "تطبيق OAuth جديد"
3. أدخل المعلومات التالية:
   - **اسم التطبيق**: `Jimmy Blog Admin` (أو أي اسم تختاره)
   - **رابط الصفحة الرئيسية**: `https://اسم-نطاقك.com` (بيئة الإنتاج) أو `http://localhost:3000` (للتطوير المحلي)
   - **رابط استدعاء التصريح**: 
     - بيئة الإنتاج: `https://اسم-نطاقك.com/api/auth/github/callback`
     - التطوير المحلي: `http://localhost:3000/api/auth/github/callback`
4. انقر على "تسجيل التطبيق"
5. سجل **معرّف العميل (Client ID)**
6. انقر على "إنشاء سر عميل جديد"، وسجل **سر العميل (Client secret)**

### 2. إعداد متغيرات البيئة

أضف متغيرات البيئة التالية في إعدادات مشروع Vercel:

- `GITHUB_CLIENT_ID`: معرف تطبيق GitHub OAuth الخاص بك
- `GITHUB_CLIENT_SECRET`: سر تطبيق GitHub OAuth الخاص بك
- `GITHUB_OWNER`: اسم مستخدم GitHub (الافتراضي: `Lily-404`، للتحقق من صلاحية المستخدم)
- `GITHUB_REPO`: اسم المستودع (الافتراضي: `blog`)
- `GITHUB_REDIRECT_URI`: رابط استدعاء OAuth (اختياري، يتم إنشاؤه تلقائياً افتراضياً)
- `NEXT_PUBLIC_BASE_URL`: رابط موقعك الإلكتروني (لإنشاء رابط الاستدعاء، يجب ضبطه في بيئة الإنتاج)
  - بيئة الإنتاج: `https://www.jimmy-blog.top`
  - التطوير المحلي: `http://localhost:3000`

### 3. إعداد التطوير المحلي

أنشئ ملف `.env.local` في جذر المشروع:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. إعدادات بيئة الإنتاج (Vercel)

في إعدادات مشروع Vercel، تأكد من ضبط:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```
⚠️ **تنبيه**: 
- تمت إضافة ملف `.env.local` إلى `.gitignore`، ولن يتم رفعه إلى Git
- عند التطوير المحلي، تأكد من ضبط رابط إعادة التوجيه لتطبيق OAuth إلى `http://localhost:3000/api/auth/github/callback`
- **يجب ضبط متغير `NEXT_PUBLIC_BASE_URL` في بيئة الإنتاج ليكون `https://www.jimmy-blog.top`**
- يجب ضبط رابط إعادة التوجيه لتطبيق OAuth في بيئة الإنتاج ليكون: `https://www.jimmy-blog.top/api/auth/github/callback`

## النشر

المشروع معد مسبقًا للنشر على Vercel ويدعم النشر التلقائي. فقط قم بدفع الكود إلى مستودع GitHub، وسيقوم Vercel ببنائه ونشره تلقائيًا.

### مزايا استخدام لوحة الإدارة

- ✅ لا حاجة لبيئة تطوير محلية
- ✅ إضافة المقالات في أي وقت ومن أي مكان
- ✅ إعادة نشر تلقائية عبر Vercel
- ✅ مجاني بالكامل (GitHub OAuth وVercel ضمن الباقة المجانية)
- ✅ آمن (توثيق GitHub OAuth، فقط مالك/متعاونو المستودع يمكنهم الوصول)
- ✅ لا حاجة لإدارة كلمات المرور، فقط سجل دخولك بحساب GitHub

## المساهمة

نرحب بإرسال المشاكل (Issue) وطلبات الدمج (Pull Request)!

## الترخيص

رخصة MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---