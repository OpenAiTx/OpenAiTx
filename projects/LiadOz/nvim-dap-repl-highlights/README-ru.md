
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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
Добавляет подсветку синтаксиса в буфер REPL [nvim-dap](https://github.com/mfussenegger/nvim-dap) с помощью treesitter.
| До                                                                                                              | После                                                                                                         |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Требования
* Neovim 0.9 или новее
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Установка
Установите плагин и необходимые зависимости любым удобным способом. После установки убедитесь, что вы настроили treesitter [подсветку](https://github.com/nvim-treesitter/nvim-treesitter#modules), затем добавьте следующее в ваш lua-конфиг
```lua
require('nvim-dap-repl-highlights').setup()
```
После первоначальной настройки плагина необходимо установить парсер dap_repl, это можно сделать вручную, выполнив команду `:TSInstall dap_repl`.

Или автоматически через конфигурацию Treesitter:

**Использование `ensure_installed` (основная ветка nvim-treesitter)**
> ⚠️ **ПРИМЕЧАНИЕ:** Вы должны вызвать nvim-dap-repl-highlights.setup() до Treesitter, иначе парсер dap_repl не будет найден.
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
**Использование `nvim-treesitter.install` (основная ветка nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Если это когда-либо перестанет работать или API изменится, ознакомьтесь с официальной документацией Treesitter для получения актуального метода установки:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Использование
По умолчанию плагин определяет язык для использования в REPL, основываясь на **filetype**, с которым был запущен dap. Очевидно, чтобы получить подсветку синтаксиса для определённого языка, вам потребуется парсер treesitter для этого языка, а также парсер `dap_repl`.
Это может не подойти для всех сценариев.

Вместо этого вы можете использовать команду `:lua require('nvim-dap-repl-highlights').setup_highlights('python')`, которая установит подсветку python в текущем буфере repl.
Альтернативно функцию можно вызвать без указания языка, тогда пользователю будет предложено выбрать язык.

Дополнительно вы можете указать в конфигурации **dap** язык repl, например, если вы хотите, чтобы ваш python repl имел подсветку javascript:
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
Опция repl_lang имеет приоритет над типом файла.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---