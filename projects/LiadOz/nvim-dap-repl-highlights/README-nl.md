
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# nvim-dap-repl-highlights
Voegt syntaxis-highlighting toe aan de [nvim-dap](https://github.com/mfussenegger/nvim-dap) REPL-buffer met behulp van treesitter.
| Voor                                                                                                            | Na                                                                                                             |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![voor](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png)  | ![afbeelding](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Vereisten
* Neovim 0.9 of nieuwer
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Installatie
Installeer de plugin en de vereisten met je favoriete methode. Zodra geïnstalleerd, zorg ervoor dat je treesitter [highlighting](https://github.com/nvim-treesitter/nvim-treesitter#modules) hebt geconfigureerd en voeg dan het volgende toe aan je lua-config
```lua
require('nvim-dap-repl-highlights').setup()
```
Na de initiële installatie van de plugin moet de dap_repl parser worden geïnstalleerd. Dit kan handmatig gedaan worden door `:TSInstall dap_repl` uit te voeren.

Of automatisch via de Treesitter-configuratie:

**Gebruik van `ensure_installed` (nvim-treesitter master branch)**
> ⚠️ **LET OP:** Je moet nvim-dap-repl-highlights.setup() aanroepen vóór Treesitter, anders wordt de dap_repl parser niet gevonden.
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
**Gebruik van `nvim-treesitter.install` (nvim-treesitter hoofdbranch)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Als dit ooit niet meer werkt of de API verandert, raadpleeg dan de officiële Treesitter-documentatie voor de nieuwste installatiemethode:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Gebruik
Standaard detecteert de plugin de te gebruiken taal in de REPL door te kijken naar het **bestandstype** dat wordt gebruikt om dap te starten. Uiteraard heb je om syntax highlighting voor een bepaalde taal te krijgen een treesitter-parser voor die taal nodig, naast de `dap_repl` parser.
Dit is mogelijk niet geschikt voor alle gebruikssituaties.

Je kunt in plaats daarvan het commando `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` gebruiken, waarmee python-highlighting wordt ingesteld in de huidige repl-buffer.
Als alternatief kan de functie worden aangeroepen zonder een taal te specificeren, dit zal de gebruiker om een taal vragen.

Daarnaast kun je in de **dap** configuratie de repl-taal specificeren die je wilt gebruiken, bijvoorbeeld als je wilt dat je python-repl javascript-highlighting krijgt:
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
De optie repl_lang heeft voorrang boven het bestandstype.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---