<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>یک قالب بلاگ Astro</p>
<p>Sora به معنای «آسمان»، نمادی از بی‌نهایت بودن امکان‌ها و خلاقیت وسیع است</p>
<p>اگر از این قالب خوشتان آمد، یک 🌟Star بدهید!</p>
<p><strong>فارسی</strong> | <a href="/README.en.md">English</a></p>
</div>

# پیش‌نمایش

[وبلاگ من](https://blog.liks.space)

## چه کسانی استفاده می‌کنند

خوشحال می‌شویم [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) ارسال کنید تا وب‌سایت خود را معرفی نمایید.

# شروع

1. نصب قالب

   - نصب [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - وارد پوشه پروژه شوید و با اجرای `pnpm dev` پروژه را اجرا کنید

2. پیکربندی قالب

   فایل پیکربندی `theme.config.ts` را برای شخصی‌سازی قالب ویرایش کنید. جزییات بیشتر در [پیکربندی](#پیکربندی).

3. ویرایش نوشته‌ها

   در پوشه `src/content/` ویرایش کنید، فرمت Markdown پشتیبانی می‌شود.

4. انتشار سایت

   با اجرای `pnpm build` سایت را بسازید، خروجی در پوشه `dist/` قرار می‌گیرد. می‌توانید با `pnpm preview` سایت را به صورت محلی پیش‌نمایش کنید.

   سایت را به سرور خود منتقل کنید، یا مطابق [مستندات Astro](https://docs.astro.build/en/guides/deploy/) در سرویس‌هایی مثل Vercel، Netlify، GitHub Pages و غیره منتشر نمایید.

<!-- # مستندات -->

# پیکربندی

فایل پیکربندی `theme.config.ts` است.

## اطلاعات سایت

```typescript
site: {
  // آدرس سایت
  url: "https://blog.liks.space",
  // عنوان سایت
  title: "Sora",
  // نام مدیر سایت
  author: "Liks",
  // توضیح سایت
  description: "یک قالب بلاگ ساخته شده با Astro",
  // آیکون سایت
  // پشتیبانی از فرمت SVG، PNG، ICO
  // مسیر فایل محلی در پوشه public/
  favicon: "/images/favicon.ico",
}
```

## تنظیمات کلی

```typescript
global: {
  // تصویر پروفایل
  // مسیر فایل محلی در پوشه src/images/
  avatar: "avatar.jpg",
  // فعال‌سازی RSS
  rss: true,
  // فعال‌سازی پشتیبانی چندزبانه (در حال توسعه)
  i18n: true,
}
```

## نوار ناوبری

```typescript
nav: [
  {
    // نام صفحه
    name: "بایگانی",
    // آدرس صفحه
    url: "/archives",
  },
  {
    name: "دسته‌بندی",
    url: "/categories",
  },
  {
    name: "برچسب‌ها",
    url: "/tags",
  },
  {
    name: "درباره",
    url: "/about",
  },
  ...
];
```

## پاورقی

```typescript
footer: {
  // کپی‌رایت
  copyright: {
    // سال شروع سایت
    time: "2024 - 2025",
    // مالک حقوقی
    owner: "Liks",
  },
  // مجوزها (ویژه چین)
  beian: {
    // مجوز ICP
    icp: {
      // فعال‌سازی
      enabled: false,
      // شماره مجوز
      number: "京 ICP 备 12345678 号",
    },
    // مجوز پلیس
    police: {
      // فعال‌سازی
      enabled: false,
      // شماره مجوز
      number: "京公网安备 12345678901234 号",
      // وب‌سایت مجوز
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## صفحه اصلی

```typescript
index: {
  // شبکه‌های اجتماعی
  social: [
    {
      // نام
      name: "GitHub",
      // فعال‌سازی
      enabled: true,
      // آدرس
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

پشتیبانی از BiliBili، ایمیل، Facebook، GitHub، Instagram، QQ، Telegram، Twitter/X، YouTube، Weibo، Xiaohongshu، Zhihu.

## صفحه نوشته

```typescript
post: {
  // مجوز کپی‌رایت
  copyright: {
    // مجوز CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // آدرس مجوز
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## حمایت مالی

```typescript
sponsor: {
  // فعال‌سازی
  enabled: true,
  // کد QR پرداخت با Alipay
  alipay: {
    // فعال‌سازی
    enabled: true,
    // مسیر فایل محلی در پوشه src/images/
    image: "alipay.png",
  },
  // کد QR وی‌چت
  wechat: {
    enabled: false,
  },
  // نمایش لیست حامیان
  list: true,
```
}
```

## نظرات

```typescript
comment: {
  // فعال‌سازی
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // آدرس سرور پشتیبان
    server: "https://artalk.example.com",
    // نام سایت
    site: "Sora",
  },
}
```

## ابزارها

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // فعال‌سازی
    enabled: false,
    // آدرس سرور
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# مجوز

[مجوز عمومی همگانی گنو نسخه ۳.۰](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# تقدیر و تشکر

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [纸鹿摸鱼处](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---