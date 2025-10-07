
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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
Dodaj podświetlanie składni do bufora REPL [nvim-dap](https://github.com/mfussenegger/nvim-dap) przy użyciu treesitter.
| Przed                                                                                                           | Po                                                                                                             |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Wymagania
* Neovim 0.9 lub nowszy
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Instalacja
Zainstaluj wtyczkę oraz wymagane zależności wybraną przez siebie metodą. Po instalacji upewnij się, że skonfigurowałeś [podświetlanie](https://github.com/nvim-treesitter/nvim-treesitter#modules) treesitter, a następnie dodaj poniższy kod do swojej konfiguracji lua
```lua
require('nvim-dap-repl-highlights').setup()
```
Po początkowej konfiguracji wtyczki należy zainstalować parser dap_repl, co można zrobić ręcznie poprzez uruchomienie `:TSInstall dap_repl`.

Lub automatycznie poprzez konfigurację Treesitter:

**Używając `ensure_installed` (gałąź master nvim-treesitter)**
> ⚠️ **UWAGA:** Musisz wywołać nvim-dap-repl-highlights.setup() przed Treesitter, w przeciwnym razie parser dap_repl nie zostanie znaleziony.
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
**Użycie `nvim-treesitter.install` (główna gałąź nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Jeśli przestanie to działać lub API się zmieni, sprawdź oficjalną dokumentację Treesitter, aby uzyskać najnowszą metodę instalacji:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Użytkowanie
Domyślnie wtyczka wykrywa język do użycia w REPL, patrząc na **filetype** użyty do uruchomienia dap. Oczywiście, aby mieć podświetlanie składni dla danego języka, musisz mieć parser treesitter dla tego języka, wraz z parserem `dap_repl`.
Może to nie pasować do wszystkich przypadków użycia.

Możesz zamiast tego użyć komendy `:lua require('nvim-dap-repl-highlights').setup_highlights('python')`, która ustawi podświetlanie dla pythona w bieżącym buforze repl.
Alternatywnie funkcję można wywołać bez określania języka, wtedy użytkownik zostanie poproszony o wybór języka.

Dodatkowo możesz określić w konfiguracji **dap** język repl do użycia, na przykład jeśli chcesz, aby twój python repl miał podświetlanie javascript:
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
Opcja repl_lang ma priorytet nad typem pliku.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---