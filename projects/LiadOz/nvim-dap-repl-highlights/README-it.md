
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
Aggiungi evidenziazione della sintassi al buffer REPL di [nvim-dap](https://github.com/mfussenegger/nvim-dap) usando treesitter.
| Prima                                                                                                           | Dopo                                                                                                           |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Requisiti
* Neovim 0.9 o successivo
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Configurazione
Installa il plugin e i requisiti usando il tuo metodo preferito. Una volta installato, assicurati di aver configurato l’evidenziazione di treesitter [highlighting](https://github.com/nvim-treesitter/nvim-treesitter#modules) quindi aggiungi quanto segue alla tua configurazione lua
```lua
require('nvim-dap-repl-highlights').setup()
```
Dopo aver inizialmente configurato il plugin, è necessario installare il parser dap_repl, questo può essere fatto manualmente eseguendo `:TSInstall dap_repl`.

Oppure automaticamente tramite la configurazione di Treesitter:

**Utilizzando `ensure_installed` (ramo master di nvim-treesitter)**
> ⚠️ **NOTA:** Devi chiamare nvim-dap-repl-highlights.setup() prima di Treesitter, altrimenti il parser dap_repl non verrà trovato.
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
**Utilizzo di `nvim-treesitter.install` (ramo principale di nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Se questo smette di funzionare o l'API cambia, consulta la documentazione ufficiale di Treesitter per il metodo di installazione più aggiornato:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Utilizzo
Per impostazione predefinita, il plugin rileva la lingua da utilizzare nel REPL controllando il **filetype** usato per avviare dap. Ovviamente, per avere l'evidenziazione della sintassi per una determinata lingua, è necessario avere un parser treesitter per quella lingua, oltre al parser `dap_repl`.
Questo potrebbe non adattarsi a tutti gli scenari d'uso.

In alternativa, puoi usare il comando `:lua require('nvim-dap-repl-highlights').setup_highlights('python')`, che imposterà l'evidenziazione python nel buffer repl corrente.
In alternativa, la funzione può essere chiamata senza specificare la lingua, in questo caso verrà richiesto all'utente di scegliere una lingua.

Inoltre, puoi specificare nella configurazione di **dap** la lingua del repl da utilizzare, ad esempio se vuoi che il tuo repl python abbia l'evidenziazione javascript:
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
L'opzione repl_lang ha la precedenza sul tipo di file.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---