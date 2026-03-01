# <p align="center"> *NEOMODERN*.nvim </p>

<p align="center">
moderne — simple — discret
</p>

<p align="center">
<img src="https://img.shields.io/github/v/tag/cdmill/neomodern.nvim?style=flat&label=RELEASE&labelColor=%23212123&color=%238a88db" />
<img src="https://img.shields.io/badge/BUILT_WITH_LUA-blue?style=flat&color=%23629da3" />
<img src="https://img.shields.io/badge/NEOVIM-0.9-blue?style=flat&logo=Neovim&labelColor=%23212123&color=%238a88db" />
</p>

## Table des matières

- [Galerie](#gallery)
- [Installation](#installation)
- [Configuration](#configuration)
- [Personnalisation](#customization)
- [Recettes](#recipes)
- [Contribuer](#contributing)
- [Inspiration](inspiration)

## Galerie

### 🌚 LUNE

Un thème sombre et spatial inspiré par les couleurs de la lune

<details open>
<summary>Variante Sombre</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-dark.png)

</details>

<details closed>
<summary>Variante Claire</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-light.png)

</details>

### ❄️ *ICECLIMBER*

Un thème avec des couleurs inspirées des personnages d’Ice Climbers de Nintendo

<details open>
<summary>Variante Sombre</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-dark.png)

</details>

<details closed>
<summary>Variante Claire</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-light.png)

</details>

### 🌱 *GYOKURO*

Un thème inspiré du thé vert frais

<details open>
<summary>Variante Sombre</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-dark.png)

</details>

<details closed>
<summary>Variante Claire</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-light.png)

</details>

### 🍂 *HOJICHA*

Un thème inspiré du thé vert torréfié

<details open>
<summary>Variante Sombre</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-dark.png)

</details>

<details closed>
<summary>Variante Claire</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-light.png)

</details>

### 🌷 *ROSEPRIME*

Inspiré par l'utilisation de [ThePrimeagen](https://github.com/ThePrimeagen) du thème [Rosé-Pine](https://github.com/rose-pine/neovim)

<details open>
<summary>Variante Sombre</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-dark.png)

</details>

<details closed>
<summary>Variante Claire</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-light.png)

</details>

## Installation

Avec vim.pack :

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").setup({
-- optional configuration
})
require("neomodern").load()
```

Notez que vous n'avez besoin d'appeler setup que si vous remplacez des options par défaut. Si
vous l'utilisez uniquement pour définir le thème, vous pouvez utiliser ce qui suit à la place :

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").load("iceclimber")
```

## Configuration

Il y a 5 thèmes inclus, chacun avec une variante claire et sombre.
Le thème clair est utilisé lorsque `vim.o.background = "light"`.

Les options par défaut sont données ci-dessous :

```lua
require("neomodern").setup({
  -- 'default' default background
  -- 'alt' darker background
  -- 'transparent' background is not set
  bg = "default",

  theme = "moon", -- 'moon' | 'iceclimber' | 'gyokuro' | 'hojicha' | 'roseprime'

  gutter = {
    cursorline = false, -- highlight the cursorline in the gutter
    dark = false, -- highlight gutter darker than the Normal bg
  },

  diagnostics = {
    darker = true, -- use darker colors for diagnostics
    undercurl = true, -- use undercurl for diagnostics
    background = true, -- use a background color for diagnostics
  },

  -- override colors, see #Customization below
  overrides = {
    default = {},
    hlgroups = {}
  }
})
-- Call `load` after `setup`
require("neomodern").load()
```

## Personnalisation

Neomodern prend en charge les surcharges de couleurs définies par l'utilisateur. L'utilisateur peut soit remplacer
les couleurs par défaut, soit modifier les surlignages d'un groupe de surlignage spécifique. Lors
de la surcharge des groupes de surlignage, utilisez les couleurs de neomodern en préfixant le nom de la couleur
par un signe dollar (par exemple `$keyword`). Voir `:h highlight-args` et `:h
neomodern-types` pour les arguments attendus, les noms de couleurs par défaut, etc.

```lua
require("neomodern").setup {
  overrides = {
    default = {
      keyword = '#817faf', -- redefine neomodern's `keyword` color
    }
    hlgroups = {
      ["@keyword.return"] = { gui = 'italic' },
      ["@keyword"] = { guifg = "$keyword", gui = 'bold' },
      ["@function"] = { guibg = "#ffffff" },
      ["String"] = { link = "Todo" },
    }
  },
}
```

## Recettes

### Préférer les surlignages Treesitter

Si vous préférez privilégier les surlignages basés sur treesitter (plutôt que
les surlignages sémantiques LSP), utilisez ceci quelque part dans votre configuration :

```lua
vim.highlight.priorities.semantic_tokens = 95
```

### Raccourci pour basculer entre les variantes Clair/Sombre

Neomodern utilise `vim.opt.background` pour décider quelle variante charger, donc pour
basculer entre les variantes, il suffit de basculer `vim.opt.background`.

```lua
vim.keymap.set("n", "<leader>uc", function()
    if vim.opt.background == "light" then
        vim.opt.background = "dark"
    else
        vim.opt.background = "light"
    end
end, { desc = "Toggle between light/dark mode" })
```

## Contribution

Si vous souhaitez un support pour un plugin ou un extra, veuillez ouvrir un ticket ou
soumettre une PR.

## Inspiration

- [OneDark.nvim](https://github.com/navarasu/onedark.nvim)
- [Bamboo.nvim](https://github.com/ribru17/bamboo.nvim)
- [Catppuccin](https://github.com/catppuccin/nvim)
- [Everforest](https://github.com/sainnhe/everforest)
- [Rosé-Pine](https://github.com/rose-pine/neovim)
- [TokyoNight](https://github.com/folke/tokyonight.nvim)
- [No Clown Fiesta](https://github.com/aktersnurra/no-clown-fiesta.nvim)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-01

---