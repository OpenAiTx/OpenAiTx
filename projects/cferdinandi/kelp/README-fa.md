# Kelp

یک کتابخانه رابط کاربری برای افرادی که عاشق HTML هستند، با قدرت CSS مدرن و Web Components.

**[مطالعه مستندات &rarr;](https://kelpui.com)**

_**توجه:** Kelp در حال حاضر در مرحله توسعه آلفا قرار دارد. لطفاً احساس راحتی کنید که از آن استفاده کنید، آزمایش نمایید و اشکالات را گزارش دهید، اما درک کنید که ممکن است مواردی در طول زمان تغییر کنند._



## شروع سریع

Kelp بدون نیاز به هیچ مرحله ساخت (build) کار می‌کند.

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) سریع‌ترین و ساده‌ترین راه برای شروع است، اما اگر ترجیح می‌دهید می‌توانید [فایل‌ها را از GitHub دانلود کنید](https://github.com/cferdinandi/kelp).

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp از نسخه‌بندی معنایی استفاده می‌کند. شما می‌توانید نسخه اصلی، فرعی یا وصله‌ای را با استفاده از سینتکس `@1.2.3` از CDN دریافت کنید. همه نسخه‌های موجود را می‌توانید [در بخش انتشارها](https://github.com/cferdinandi/kelp/tags) پیدا کنید.



## دموی نمونه

فایل `index.html` موجود، یک دموی کامل از Kelp است. این فایل شامل هر ویژگی و کامپوننت در یک فایل بزرگ است.

در حالی که Kelp در نسخه بتا است، هیچ مرحله کامپایل ندارد. Web Componentها از ES import استفاده می‌کنند و برای اجرا نیاز به یک سرور محلی دارند.

از سرور دلخواه خود استفاده کنید یا با اجرای دستور `npm run dev` از `http-server` موجود استفاده نمایید.

```bash
npm install
npm run dev
```

زمانی که Kelp به نسخه v1 نزدیک می‌شود، از یک مرحله کامپایل استفاده خواهد کرد تا این مورد ضروری نباشد.



## تست‌ها

Kelp از ...

- [Playwright](https://playwright.dev) برای تست‌ها
- [Biome](https://biomejs.dev) برای lint و فرمت‌دهی
- یک فرایند ادغام مستمر (CI) برای استقرارها و Pull Requestها

```bash
# اجرای تست‌ها
npm run test

# اجرای lint
npm run lint
```



## مجوز

استفاده رایگان تحت [مجوز Kelp Commons](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). همچنین [گزینه‌های مجوز تجاری](/license/) نیز در دسترس هستند.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---