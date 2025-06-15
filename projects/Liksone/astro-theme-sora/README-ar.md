<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>سمة مدونة Astro</p>
<p>Sora تعني "القبة"، وترمز إلى الإمكانيات اللامحدودة والإبداع الواسع</p>
<p>إذا أعجبتك هذه السمة، لا تتردد في وضع 🌟نجمة!</p>
<p><strong>中文 مبسط</strong> | <a href="/README.en.md">English</a></p>
</div>

# المعاينة

[مدونتي](https://blog.liks.space)

## من يستخدم

مرحباً بك في تقديم [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) لعرض موقعك الخاص.

# البدء

1. تثبيت السمة

   - تثبيت [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - ادخل إلى مجلد المشروع، ثم شغّل `pnpm dev` لبدء المشروع

2. ضبط السمة

   قم بتعديل ملف الإعدادات `theme.config.ts` لتخصيص السمة. لمزيد من التفاصيل راجع [الإعدادات](#配置).

3. تحرير المقالات

   حرر في مجلد `src/content/`، ويدعم صيغة Markdown.

4. نشر الموقع

   شغّل `pnpm build` لبناء الموقع، حيث يتم حفظ الملفات الناتجة في مجلد `dist/`. يمكنك تشغيل `pnpm preview` لمعاينة الموقع محلياً.

   يمكنك نشر الموقع على الخادم الخاص بك، أو الرجوع إلى [دليل Astro](https://docs.astro.build/en/guides/deploy/) للنشر على Vercel أو Netlify أو GitHub Pages أو منصات الاستضافة الأخرى.

<!-- # الوثائق -->

# الإعدادات

ملف الإعدادات هو `theme.config.ts`.

## معلومات الموقع

```typescript
site: {
  // عنوان الموقع
  url: "https://blog.liks.space",
  // عنوان الموقع
  title: "Sora",
  // اسم صاحب الموقع
  author: "Liks",
  // وصف الموقع
  description: "سمة مدونة مبنية بـ Astro",
  // أيقونة الموقع
  // يدعم SVG، PNG، ICO
  // مسار الملف المحلي داخل مجلد public/
  favicon: "/images/favicon.ico",
}
```

## الإعدادات العامة

```typescript
global: {
  // الصورة الرمزية
  // مسار الملف المحلي داخل مجلد src/images/
  avatar: "avatar.jpg",
  // تفعيل RSS
  rss: true,
  // تفعيل دعم اللغات المتعددة (تحت التطوير)
  i18n: true,
}
```

## شريط التنقل

```typescript
nav: [
  {
    // اسم الصفحة
    name: "الأرشيف",
    // رابط الصفحة
    url: "/archives",
  },
  {
    name: "التصنيفات",
    url: "/categories",
  },
  {
    name: "الوسوم",
    url: "/tags",
  },
  {
    name: "حول",
    url: "/about",
  },
  ...
];
```

## تذييل الصفحة

```typescript
footer: {
  // حقوق النشر
  copyright: {
    // تاريخ إنشاء الموقع
    time: "2024 - 2025",
    // مالك الحقوق
    owner: "Liks",
  },
  // السجل (خاص بالصين)
  beian: {
    // سجل ICP
    icp: {
      // تفعيل
      enabled: false,
      // رقم السجل
      number: "京 ICP 备 12345678 号",
    },
    // سجل الشرطة
    police: {
      // تفعيل
      enabled: false,
      // رقم السجل
      number: "京公网安备 12345678901234 号",
      // رابط السجل
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## الصفحة الرئيسية

```typescript
index: {
  // وسائل التواصل الاجتماعي
  social: [
    {
      // الاسم
      name: "GitHub",
      // تفعيل
      enabled: true,
      // الرابط
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

يدعم BiliBili، البريد الإلكتروني، Facebook، GitHub، Instagram، QQ، Telegram، Twitter/X، YouTube، Weibo، Xiaohongshu، Zhihu.

## صفحة المقالة

```typescript
post: {
  // ترخيص حقوق النشر
  copyright: {
    // ترخيص CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // رابط الترخيص
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## الدعم المالي

```typescript
sponsor: {
  // تفعيل
  enabled: true,
  // رمز الاستجابة السريع لـ Alipay
  alipay: {
    // تفعيل
    enabled: true,
    // مسار الملف المحلي داخل مجلد src/images/
    image: "alipay.png",
  },
  // رمز الاستجابة السريع لـ WeChat
  wechat: {
    enabled: false,
  },
  // عرض قائمة الداعمين
  list: true,
}
```

## التعليقات

```typescript
comment: {
  // التفعيل
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // عنوان خادم الخلفية
    server: "https://artalk.example.com",
    // اسم الموقع
    site: "Sora",
  },
}
```

## الأدوات

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // التفعيل
    enabled: false,
    // عنوان الخادم
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```

# الترخيص

[رخصة جنو العمومية العامة الإصدار 3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# الشكر والتقدير

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [مدونة زيلو](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---