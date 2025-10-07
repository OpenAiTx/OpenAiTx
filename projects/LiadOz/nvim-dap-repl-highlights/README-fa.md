
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# nvim-dap-repl-highlights
افزودن برجسته‌سازی نحوی به بافر REPL افزونه [nvim-dap](https://github.com/mfussenegger/nvim-dap) با استفاده از treesitter.
| قبل                                                                                                              | بعد                                                                                                           |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## پیش‌نیازها
* نئوویم نسخه ۰.۹ یا بالاتر
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## راه‌اندازی
افزونه و پیش‌نیازها را با روش مورد علاقه خود نصب کنید. پس از نصب، مطمئن شوید که هایلایتینگ treesitter را [پیکربندی](https://github.com/nvim-treesitter/nvim-treesitter#modules) کرده‌اید، سپس موارد زیر را به پیکربندی lua خود اضافه کنید.
```lua
require('nvim-dap-repl-highlights').setup()
```
پس از راه‌اندازی اولیه افزونه، پارسر dap_repl باید نصب شود، این کار را می‌توان به صورت دستی با اجرای `:TSInstall dap_repl` انجام داد.

یا به صورت خودکار از طریق پیکربندی Treesitter:

**استفاده از `ensure_installed` (شاخه master nvim-treesitter)**
> ⚠️ **توجه:** باید قبل از Treesitter، تابع nvim-dap-repl-highlights.setup() را فراخوانی کنید، در غیر این صورت پارسر dap_repl پیدا نخواهد شد.
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter.configs').setup {
  highlight = {
    enable = true,
  },
  ensure_installed = { 'dap_repl', ... },
  ...
}
```
**استفاده از `nvim-treesitter.install` (شاخه اصلی nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ اگر این افزونه دیگر کار نکرد یا API تغییر کرد، به مستندات رسمی Treesitter برای جدیدترین روش نصب مراجعه کنید:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## استفاده
به طور پیش‌فرض، افزونه زبان مورد استفاده در REPL را با بررسی **filetype** که برای اجرای dap استفاده شده تشخیص می‌دهد. بدیهی است که برای داشتن برجسته‌سازی نحوی برای یک زبان خاص باید parser treesitter برای آن زبان را به همراه parser `dap_repl` داشته باشید.
این موضوع ممکن است برای همه موارد کاربرد مناسب نباشد.

در عوض می‌توانید از دستور `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` استفاده کنید که برجسته‌سازی پایتون را در buffer repl فعلی تنظیم می‌کند.
همچنین این تابع را می‌توان بدون مشخص کردن زبان فراخوانی کرد، که در این صورت از کاربر زبان مورد نظر را می‌پرسد.

علاوه بر این می‌توانید در پیکربندی **dap** زبان repl مورد استفاده را مشخص کنید، برای مثال اگر بخواهید REPL پایتون شما برجسته‌سازی جاوااسکریپت داشته باشد:
```lua
local dap = require('dap')
dap.configurations.python = {
  {
    name = "Python with javascript repl because I like to watch the world burn 🔥🔥🔥",
    type = "python",
    request = "launch",
    program = "${file}",
    repl_lang = "javascript"
  },
}
```
گزینه repl_lang نسبت به نوع فایل اولویت دارد.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---