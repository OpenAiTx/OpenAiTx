
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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
Ajoutez la coloration syntaxique au buffer REPL de [nvim-dap](https://github.com/mfussenegger/nvim-dap) en utilisant treesitter.
| Avant                                                                                                           | Après                                                                                                          |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Prérequis
* Neovim 0.9 ou version ultérieure
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Installation
Installez le plugin et les dépendances en utilisant votre méthode préférée. Une fois installé, assurez-vous de configurer la [mise en surbrillance](https://github.com/nvim-treesitter/nvim-treesitter#modules) de treesitter, puis ajoutez ce qui suit à votre configuration lua
```lua
require('nvim-dap-repl-highlights').setup()
```
Après avoir configuré le plugin initialement, le parseur dap_repl doit être installé, cela peut être fait manuellement en exécutant `:TSInstall dap_repl`.

Ou automatiquement via la configuration de Treesitter :

**Utilisation de `ensure_installed` (branche master de nvim-treesitter)**
> ⚠️ **NOTE :** Vous devez appeler nvim-dap-repl-highlights.setup() avant Treesitter, sinon le parseur dap_repl ne sera pas trouvé.
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
**Utilisation de `nvim-treesitter.install` (branche principale de nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Si cela cesse de fonctionner ou si l'API change, consultez la documentation officielle de Treesitter pour la dernière méthode d'installation :
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Utilisation
Par défaut, le plugin détecte la langue à utiliser dans le REPL en regardant le **filetype** utilisé pour lancer dap. Évidemment, pour avoir la coloration syntaxique d'un certain langage, vous devrez avoir un parseur treesitter pour ce langage, ainsi que le parseur `dap_repl`.
Cela peut ne pas convenir à tous les cas d'utilisation.

Vous pouvez aussi utiliser la commande `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` qui appliquera la coloration Python dans le buffer REPL courant.
Alternativement, la fonction peut être appelée sans spécifier la langue, ce qui invitera l'utilisateur à en choisir une.

De plus, vous pouvez spécifier dans la configuration **dap** la langue du REPL à utiliser, par exemple si vous voulez que votre REPL Python ait la coloration JavaScript :
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
L'option repl_lang a la priorité sur le type de fichier.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---