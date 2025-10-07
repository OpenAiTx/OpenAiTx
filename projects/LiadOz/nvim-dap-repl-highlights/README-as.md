<div align="right">
  <details>
    <summary >🌐 Language</summary>
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
[nvim-dap](https://github.com/mfussenegger/nvim-dap) REPL বাফাৰত ট্ৰি-চিটার ব্যৱহাৰ কৰি সিন্টেক্স হাইলাইটিং যোগ কৰক।
| আগতে                                                                                                           | পিছত                                                                                                          |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## requirements
* Neovim 0.9 বা তাৰ পাছৰ সংস্কৰণ

* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## ছেটআপ
আপোনাৰ প্ৰিয় পদ্ধতি ব্যৱহাৰ কৰি প্লাগিন আৰু প্ৰয়োজনীয়তাসমূহ ইনষ্টল কৰক। ইনষ্টল কৰাৰ পাছত, নিশ্চিত কৰক যে আপুনি treesitter [হাইলাইটিং](https://github.com/nvim-treesitter/nvim-treesitter#modules) কনফিগাৰ কৰিছে, তাৰ পিছত তলত দিয়া কোডটো আপোনাৰ lua কনফিগত যোগ কৰক।
```lua
require('nvim-dap-repl-highlights').setup()
```
প্ৰাথমিকভাৱে প্লাগিনটো ছেট আপ কৰাৰ পিছত dap_repl পাৰ্ছাৰ ইনষ্টল কৰিব লাগিব, এইটো `:TSInstall dap_repl` চলাই হাতেৰে কৰিব পাৰি।

অথবা Treesitter কনফিগাৰেচনৰ জৰিয়তে স্বচালিতভাৱে:

**`ensure_installed` ব্যৱহাৰ কৰি (nvim-treesitter master শাখা)**
> ⚠️ **টোকা:** আপোনিয়ে Treesitter ৰ আগতে nvim-dap-repl-highlights.setup() কল কৰিব লাগিব, নহ'লে dap_repl পাৰ্ছাৰ পোৱা নাযাব।
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
**`nvim-treesitter.install` ব্যৱহাৰ কৰি (nvim-treesitter মূল শাখা)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ যদি এইটো কেতিয়াবা বন্ধ হৈ যায় বা API পৰিবৰ্তন হয়, তেন্তে সবাতোকৈ নতুন সংস্থাপন পদ্ধতিৰ বাবে Treesitter-ৰ চৰকাৰী নথিপত্র চাওক:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## ব্যৱহাৰ
অন্তৰ্গতভাৱে, প্লাগিনে REPL-ত ব্যৱহাৰ কৰিবলগীয়া ভাষাটো চিনাক্ত কৰে **filetype**-ৰ আধাৰত যি dap আৰম্ভ কৰিবলৈ ব্যৱহাৰ কৰা হয়। নিশ্চয়, নিৰ্দিষ্ট ভাষাৰ বাবে syntax highlighting পাবলৈ, সেই ভাষাৰ বাবে এটা treesitter parser থকা প্ৰয়োজন, লগতে `dap_repl` parserটোও। এইটো সকলো ব্যৱহাৰ ক্ষেত্ৰৰ বাবে উপযুক্ত নোহোৱা হ’ব পাৰে।

আপুনি ইয়াৰ পৰিৱৰ্তে `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` আজ্ঞাটো ব্যৱহাৰ কৰিব পাৰে, যি বৰ্তমান repl buffer-ত python highlights স্থাপন কৰে। 
বিকল্পভাৱে, এই ফাংচনটো ভাষা উল্লেখ নকৰাকৈও কল কৰিব পাৰি, এইটো ব্যৱহাৰকাৰীক ভাষাৰ বাবে prompt কৰিব।

উল্টাকৈ, আপুনি **dap** কনফিগাৰেচনত repl ভাষা উল্লেখ কৰিব পাৰে, উদাহৰণস্বৰূপে যদি আপুনি আপোনাৰ python repl-ত javascript highlighting বিচাৰে:

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
repl_lang বিকল্পটো filetype-ৰ ওপৰত অগ্ৰাধিকাৰ লয়।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---