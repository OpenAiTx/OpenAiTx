
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# nvim-dap-repl-highlights
Fügt Syntaxhervorhebung zum [nvim-dap](https://github.com/mfussenegger/nvim-dap) REPL-Puffer mit Treesitter hinzu.
| Vorher                                                                                                          | Nachher                                                                                                       |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Voraussetzungen
* Neovim 0.9 oder neuer
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Einrichtung
Installieren Sie das Plugin und die erforderlichen Abhängigkeiten mit Ihrer bevorzugten Methode. Sobald die Installation abgeschlossen ist, stellen Sie sicher, dass Sie das Treesitter-[Highlighting](https://github.com/nvim-treesitter/nvim-treesitter#modules) konfiguriert haben und fügen Sie dann Folgendes zu Ihrer Lua-Konfiguration hinzu.
```lua
require('nvim-dap-repl-highlights').setup()
```
Nachdem das Plugin initial eingerichtet wurde, muss der dap_repl-Parser installiert werden. Dies kann manuell durch Ausführen von `:TSInstall dap_repl` erfolgen.

Oder automatisch über die Treesitter-Konfiguration:

**Verwendung von `ensure_installed` (nvim-treesitter Hauptzweig)**
> ⚠️ **HINWEIS:** Sie müssen nvim-dap-repl-highlights.setup() vor Treesitter aufrufen, sonst wird der dap_repl-Parser nicht gefunden.
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
**Verwendung von `nvim-treesitter.install` (nvim-treesitter Hauptzweig)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Falls dies jemals nicht mehr funktioniert oder sich die API ändert, schaue in die offiziellen Treesitter-Dokumente für die neueste Installationsmethode:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Verwendung
Standardmäßig erkennt das Plugin die Sprache, die im REPL verwendet werden soll, indem es auf den **filetype** achtet, mit dem dap gestartet wurde. Natürlich benötigst du für Syntaxhervorhebung bestimmter Sprachen einen Treesitter-Parser für diese Sprache sowie den `dap_repl`-Parser.
Das passt möglicherweise nicht für alle Anwendungsfälle.

Du kannst stattdessen den Befehl `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` verwenden, der Python-Hervorhebungen im aktuellen REPL-Puffer setzt.
Alternativ kann die Funktion ohne Angabe einer Sprache aufgerufen werden, dann wird der Benutzer nach einer Sprache gefragt.

Zusätzlich könntest du in der **dap**-Konfiguration die REPL-Sprache angeben, die verwendet werden soll, zum Beispiel wenn du möchtest, dass dein Python-REPL JavaScript-Hervorhebung verwendet:
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
Die Option repl_lang hat Vorrang vor dem Dateityp.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---