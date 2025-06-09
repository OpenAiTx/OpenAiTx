# به‌روزرسانی پایگاه داده Browserslist

<img width="120" height="120" alt="Browserslist logo by Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

ابزار خط فرمان برای به‌روزرسانی `caniuse-lite` با پایگاه داده مرورگرها
از پیکربندی [Browserslist](https://github.com/browserslist/browserslist/).

برخی کوئری‌ها مانند `last 2 versions` یا `>1%` به داده‌های واقعی
از `caniuse-lite` وابسته هستند.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsored by Evil Martians" width="236" height="54">
</a>

## چرا باید آن را به طور منظم اجرا کنید

`npx update-browserslist-db@latest` نسخه `caniuse-lite` را
در فایل قفل npm، yarn یا pnpm شما به‌روزرسانی می‌کند.

این به‌روزرسانی داده‌های مربوط به مرورگرهای جدید را برای ابزارهای polyfill
مانند Autoprefixer یا Babel فراهم می‌کند و polyfillهای غیرضروری را کاهش می‌دهد.

شما باید به طور منظم این کار را به سه دلیل انجام دهید:

1. برای استفاده از آخرین نسخه‌های مرورگر و آمارها در کوئری‌هایی مانند
   `last 2 versions` یا `>1%`. به عنوان مثال، اگر پروژه خود را
   ۲ سال پیش ایجاد کرده‌اید و وابستگی‌های خود را به‌روزرسانی نکرده‌اید، `last 1 version`
   مرورگرهای ۲ سال پیش را بازمی‌گرداند.
2. داده‌های واقعی مرورگر باعث استفاده کمتر از polyfill می‌شود. این کار اندازه
   فایل‌های JS و CSS را کاهش داده و عملکرد وب‌سایت را بهبود می‌بخشد.
3. حذف داده‌های تکراری `caniuse-lite`: برای همگام‌سازی نسخه‌ها در ابزارهای مختلف.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---