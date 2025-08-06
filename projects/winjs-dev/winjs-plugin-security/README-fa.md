
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# winjs-plugin-security

یک افزونه برای پروژه‌های WinJS که قابلیت‌های امنیتی را افزایش می‌دهد و عمدتاً برای تولید ویژگی SRI (یکپارچگی زیرمنبع) استفاده می‌شود.

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## ویژگی‌ها

- به طور خودکار ویژگی SRI را برای تگ‌های `<script>` و `<link>` در فایل‌های HTML تولید می‌کند
- پشتیبانی از الگوریتم‌های هش SHA-256، SHA-384 و SHA-512 (قابل پیکربندی)
- به طور خودکار ویژگی `crossorigin="anonymous"` را برای اطمینان از عملکرد صحیح SRI اضافه می‌کند
- فقط در محیط تولید فعال است و در محیط توسعه به طور خودکار نادیده گرفته می‌شود

## نصب

```bash
pnpm add @winner-fed/plugin-security
```
## روش استفاده

پیکربندی افزونه را به فایل پیکربندی `.winrc.ts` خود اضافه کنید:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## گزینه‌های پیکربندی

### `sri`

- **نوع**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **مقدار پیش‌فرض**: باید به صورت دستی تنظیم شود
- **توضیح**: فعال یا غیرفعال کردن قابلیت SRI (یکپارچگی زیرمنابع) و همچنین پیکربندی اختیاری الگوریتم هش

زمانی که مقدار `true` یا `{}` تنظیم شود، افزونه اقدامات زیر را انجام می‌دهد:

1. فایل‌های HTML ساخته شده را اسکن می‌کند
2. به تمام تگ‌های `<script>` که ویژگی `src` دارند، ویژگی `integrity` اضافه می‌کند
3. به تمام تگ‌های `<link>` که ویژگی `href` دارند، ویژگی `integrity` اضافه می‌کند
4. به طور خودکار ویژگی `crossorigin="anonymous"` را اضافه می‌کند (در صورت عدم وجود)

همچنین می‌توانید الگوریتم هش را به صورت شیء تعیین کنید:


```typescript
security: {
  sri: {
    algorithm: 'sha512' // 可选 'sha256' | 'sha384' | 'sha512'，默认 'sha512'
  }
}
```

## 示例

### 输入 HTML

```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css">
</head>
<body>
  <script src="/assets/app.js"></script>
</body>
</html>
```
### خروجی HTML (پس از فعال‌سازی SRI)


```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css" integrity="sha512-ABC123..." crossorigin="anonymous">
</head>
<body>
  <script src="/assets/app.js" integrity="sha512-XYZ789..." crossorigin="anonymous"></script>
</body>
</html>
```
## توضیحات ایمنی

SRI (یکپارچگی زیرمنبع) یک ویژگی امنیتی است که به مرورگر اجازه می‌دهد اطمینان حاصل کند که منابع دریافت‌شده (مانند منابع دریافت‌شده از CDN) به صورت مخرب تغییر داده نشده‌اند. هنگامی که مرورگر یک منبع را بارگذاری می‌کند، مقدار هش منبع را محاسبه کرده و با مقدار هش مشخص‌شده در ویژگی `integrity` مقایسه می‌کند. اگر مقدار هش مطابقت نداشته باشد، مرورگر بارگذاری آن منبع را رد می‌کند.

برای تگ `<script>`، نتیجه این خواهد بود که اجرای کد داخل آن رد می‌شود؛ برای لینک‌های CSS، نتیجه این است که استایل‌های درون آن بارگذاری نمی‌شوند.

برای اطلاعات بیشتر درباره SRI می‌توانید به [یکپارچگی زیرمنبع - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity) مراجعه کنید.

## نکات مهم

1. این افزونه فقط در زمان ساخت نسخه تولیدی فعال است و در محیط توسعه به طور خودکار رد می‌شود
2. لازم است اطمینان حاصل کنید که فایل‌های منبع در پوشه خروجی ساخت قابل دسترسی باشند
3. ویژگی `integrity` باید همراه با ویژگی `crossorigin` استفاده شود تا به درستی کار کند

## مجوز

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---