
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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
إضافة تمييز الصياغة إلى [nvim-dap](https://github.com/mfussenegger/nvim-dap) في نافذة REPL باستخدام treesitter.
| قبل                                                                                                             | بعد                                                                                                            |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## المتطلبات
* نيفيم 0.9 أو أحدث
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## الإعداد
قم بتثبيت الإضافة والمتطلبات باستخدام طريقتك المفضلة. بمجرد التثبيت، تأكد من أنك قمت بتكوين [تسليط الضوء](https://github.com/nvim-treesitter/nvim-treesitter#modules) في treesitter ثم أضف التالي إلى إعدادات lua الخاصة بك.
```lua
require('nvim-dap-repl-highlights').setup()
```
بعد إعداد الإضافة في البداية، يجب تثبيت محلل dap_repl، ويمكن القيام بذلك يدويًا عبر تشغيل الأمر `:TSInstall dap_repl`.

أو تلقائيًا من خلال إعدادات Treesitter:

**باستخدام `ensure_installed` (فرع master لـ nvim-treesitter)**
> ⚠️ **ملاحظة:** يجب عليك استدعاء ()nvim-dap-repl-highlights.setup قبل Treesitter، وإلا لن يتم العثور على محلل dap_repl.
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
**استخدام `nvim-treesitter.install` (الفرع الرئيسي لـ nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ إذا توقف هذا عن العمل أو تغيرت واجهة برمجة التطبيقات (API)، تحقق من وثائق Treesitter الرسمية لأحدث طريقة تثبيت:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## الاستخدام
افتراضياً، يكتشف الإضافة اللغة المستخدمة في REPL من خلال النظر إلى **نوع الملف** المستخدم لإطلاق dap. من الواضح أنه للحصول على إبراز الصياغة للغة معينة، ستحتاج إلى وجود محلل treesitter لتلك اللغة، بالإضافة إلى محلل `dap_repl`.
قد لا يناسب هذا جميع الحالات.

يمكنك بدلاً من ذلك استخدام الأمر `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` والذي سيحدد إبرازات لغة بايثون في نافذة REPL الحالية.
بدلاً من ذلك، يمكن استدعاء الدالة بدون تحديد اللغة، وسيطلب ذلك من المستخدم اختيار اللغة.

بالإضافة إلى ذلك، يمكنك تحديد لغة REPL المراد استخدامها في إعدادات **dap**، على سبيل المثال إذا أردت أن يكون REPL الخاص ببايثون بإبراز صياغة جافاسكريبت:
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
تأخذ خيار repl_lang الأولوية على نوع الملف.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---