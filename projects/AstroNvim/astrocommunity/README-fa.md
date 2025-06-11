<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">مخزن جامعه AstroNvim</h1>

مخزن جامعه AstroNvim شامل مشخصات پیکربندی پلاگین‌ها است — مجموعه‌ای از پلاگین‌ها که توسط جامعه برای AstroNvim، یک پیکربندی NeoVim، ارائه شده‌اند. این مشخصات به مدیریت تنوع پلاگین‌های استفاده شده در AstroNvim کمک می‌کنند.

## 📦 راه‌اندازی

برای ادغام پلاگین‌های جامعه، پیکربندی‌های ارائه شده را به تنظیمات `plugins` خود اضافه کنید، ترجیحاً قبل از اینکه پلاگین‌های خود را وارد کنید تا اطمینان حاصل شود که همه تغییرات AstroCommunity قبل از بازنویسی‌های شما بارگذاری شده‌اند. اگر از [قالب AstroNvim](https://github.com/AstroNvim/template) استفاده می‌کنید، این کار می‌تواند در فایل `lua/community.lua` شما انجام شود. اگر با پیکربندی پلاگین‌ها آشنایی ندارید، توصیه می‌کنیم به [مستندات AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/) مراجعه کنید.

### وارد کردن پلاگین‌های AstroCommunity

محتوای زیر را در فایل `lua/community.lua` خود وارد کنید:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... هر پلاگین ارائه شده توسط جامعه را اینجا وارد کنید
}
```

### سفارشی‌سازی نصب‌های AstroCommunity

پس از تعریف واردات AstroCommunity در `lua/community.lua` خود، می‌توانید نصب‌ها را در تعریف‌های پلاگین خود (معمولاً در دایرکتوری `lua/plugins/`) بیشتر سفارشی کنید. در اینجا یک مثال فرض می‌کنیم که Catppuccin مانند بالا نصب شده است.

```lua
return {
  { -- سفارشی‌سازی بیشتر گزینه‌های تعیین شده توسط جامعه
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**یادداشت‌ها:**

- برای غیرفعال کردن واردات، گزینه `enabled` را روی `false` تنظیم کنید. دو روش برای تغییر پلاگین موجود دارید: استفاده از نام کامل مخزن (مثلاً "m4xshen/smartcolumn.nvim") یا نام ماژول (مثلاً "catppuccin"). به یاد داشته باشید که نام ماژول ممکن است با نام پوشه متفاوت باشد.
- توصیه می‌شود هنگام سفارشی‌سازی یک پلاگین، از مسیر کامل واردات استفاده کنید و از علامت اختصاری فقط نام مخزن استفاده نکنید.
- شما می‌توانید بسیاری از جنبه‌های پلاگین‌های جامعه از جمله تنظیمات، وابستگی‌ها و نسخه‌ها را بازنویسی کنید. برای جزئیات بیشتر درباره گزینه‌های موجود، به [مستندات lazy.nvim](https://lazy.folke.io/) مراجعه کنید.

## مشارکت

اگر پیکربندی پلاگینی نوشته‌اید و می‌خواهید آن را به مخزن AstroCommunity اضافه کنید، لطفاً دستورالعمل‌های [مشارکت](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) ما را دنبال کنید و درخواست کشش ارسال کنید. اطمینان حاصل کنید که تغییرات خود را به دقت قبل از ارسال آزمایش کرده‌اید. این یک مخزن رسمی نیست، بنابراین پایداری آن به مشارکت‌های جامعه بستگی دارد. ما مشتاقیم ببینیم این پروژه چگونه رشد و توسعه می‌یابد!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---