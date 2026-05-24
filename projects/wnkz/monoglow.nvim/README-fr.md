# 🎆 Mono Glow

Un schéma de couleurs principalement monochrome avec une touche de lueur.

![Capture d’écran Monoglow Z](https://github.com/user-attachments/assets/4f4052be-def8-43b0-99f2-5c6f2ec2d502)
![Mode insertion](https://github.com/user-attachments/assets/1d4239b3-4e3e-4b57-9462-877d9de809c1)
![Mode visuel](https://github.com/user-attachments/assets/0c53b594-7351-4dd9-89de-326675d8020d)
<img src="https://github.com/user-attachments/assets/ecd5cf8d-ccfa-41be-a965-ddeb55687caa" alt="Monoglow Z (par défaut) Palette" width="100%">

> [!NOTE]
> Plus de 📷 [captures d’écran ici](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/SCREENSHOTS.md)

## ✨ Fonctionnalités

- Prend en charge les dernières fonctionnalités de [Neovim](https://github.com/neovim/neovim)
  [0.9.0](https://github.com/neovim/neovim/releases/tag/v0.9.0).
- Couleurs pour le terminal.
- Prise en charge de ~tous les principaux~ plugins (voir ci-dessous).

> [!NOTE]
> Les plugins et extras actuellement disponibles sont principalement basés sur ce que j’utilise, mais n’hésitez pas
> à ouvrir un ticket ou une PR pour en suggérer un nouveau !

<details>
<summary>🎨 Plugins pris en charge</summary>

| Plugin                                                             | Source                                                             |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| [blink.cmp](https://github.com/Saghen/blink.cmp)                   | [`blink-cmp`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/blink-cmp.lua)                   |
| [dashboard-nvim](https://github.com/nvimdev/dashboard-nvim)        | [`dashboard`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/dashboard.lua)                   |
| [flash.nvim](https://github.com/folke/flash.nvim)                  | [`flash`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/flash.lua)                           |
| [gitsigns.nvim](https://github.com/lewis6991/gitsigns.nvim)        | [`gitsigns`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/gitsigns.lua)                     |
| [markview.nvim](https://github.com/OXY2DEV/markview.nvim)          | [`markview`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/markview.lua)                     |
| [mason.nvim](https://github.com/williamboman/mason.nvim)           | [`mason`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/mason.lua)                           |
| [neo-tree.nvim](https://github.com/nvim-neo-tree/neo-tree.nvim)    | [`neo-tree`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/neo-tree.lua)                     |
| [nvim-cmp](https://github.com/hrsh7th/nvim-cmp)                    | [`cmp`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/cmp.lua)                               |
| [nvim-window-picker](https://github.com/s1n7ax/nvim-window-picker) | [`nvim-window-picker`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/nvim-window-picker.lua) |
| [oil.nvim](https://github.com/stevearc/oil.nvim)                   | [`oil`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/oil.lua)                               |
| [telescope.nvim](https://github.com/nvim-telescope/telescope.nvim) | [`telescope`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/telescope.lua)                   |
| [which-key.nvim](https://github.com/folke/which-key.nvim)          | [`which-key`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/which-key.lua)                   |

</details>

<details>
<summary>🍭 Extras</summary>

| Outil                                              | Extra                            |
| -------------------------------------------------- | -------------------------------- |
| [Ghostty](https://ghostty.org/docs/features/theme) | [extras/ghostty](extras/ghostty) |
| [Helix](https://helix-editor.com/)                 | [extras/helix](extras/helix)     |
| [Kitty](https://sw.kovidgoyal.net/kitty/conf.html) | [extras/kitty](extras/kitty)     |
| [Vim](https://vimhelp.org/)                        | [extras/vim](extras/vim)         |
| [VS Code](https://code.visualstudio.com/)          | [extras/vscode](extras/vscode)   |
| [WezTerm](https://wezterm.org/)                    | [extras/wezterm](extras/wezterm) |
| [Zed](https://zed.dev/)                            | [extras/zed](extras/zed)         |

</details>

## 📦 Installation

Installez le thème avec votre gestionnaire de paquets préféré, tel que
[folke/lazy.nvim](https://github.com/folke/lazy.nvim) :

```lua
{
  "wnkz/monoglow.nvim",
  lazy = false,
  priority = 1000,
  opts = {},
}
```

## 🚀 Utilisation

```lua
vim.cmd[[colorscheme monoglow]]
```

```vim
colorscheme monoglow

" There are also colorschemes for the different styles.
colorscheme monoglow-z
colorscheme monoglow-lack
colorscheme monoglow-void
colorscheme monoglow-light
```

## 🎨 Palette

> Voir [PALETTE.md](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/PALETTE.md) pour tous les styles (z, lack, void, light) avec les ratios de contraste WCAG.

## 🪓 Surcharge des Couleurs & Groupes de Mise en Évidence

Comment les groupes de mise en évidence sont calculés :

1. Les `colors` sont déterminées en fonction de votre configuration, avec la possibilité
   de les surcharger via `config.on_colors(colors)`.
1. Ces `colors` sont utilisées pour générer les groupes de mise en évidence.
1. `config.on_highlights(highlights, colors)` peut être utilisé pour surcharger les
   groupes de mise en évidence.

Pour les valeurs par défaut des `colors` et `highlights`, veuillez consulter les
palettes [z](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/z.lua),
[lack](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/lack.lua),
[void](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/void.lua), et
[light](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/light.lua), ainsi que les
[mises en évidence de base](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua).

<details open>
  <summary>Changer les Couleurs</summary>

```lua
require("monoglow").setup({
  -- Change the "glow" color
  on_colors = function(colors)
    colors.glow = "#fd1b7c"
  end
})
```

![Monoglow Rose Lumineux](https://github.com/user-attachments/assets/47ff0e2b-735c-48c8-8a98-90fad6aae114)

</details>

<details>
  <summary>Modification des styles de surlignage</summary>

Vous pouvez personnaliser les styles (italique, gras, etc.) pour n'importe quel groupe de surlignage en utilisant `on_highlights`.

> **Remarque :** `on_highlights` remplace la définition entière du surlignage. Pour conserver
> les propriétés existantes (comme `fg`), incluez-les dans votre remplacement ou utilisez `vim.tbl_extend`.

```lua
require("monoglow").setup({
  on_highlights = function(hl, c)
    -- Override with full definition (recommended)
    hl["@function"] = { fg = c.syntax.func_def, italic = true, bold = true }
    hl.Boolean = { fg = c.syntax.boolean, bold = true, italic = true }
    hl["@keyword"] = { fg = c.syntax.keyword, italic = true }

    -- Or use vim.tbl_extend for partial overrides
    hl.Comment = vim.tbl_extend("force", hl.Comment, { bold = true })
  end,
})
```

Voir [`lua/monoglow/groups/base.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua) et
[`lua/monoglow/groups/treesitter.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/treesitter.lua) pour
tous les groupes de surlignage disponibles.

</details>

## 🍭 Extras

Configurations de couleurs supplémentaires pour [Ghostty](extras/ghostty/), [Kitty](extras/kitty/), [Helix](extras/helix/), [Vim](extras/vim/), [VS Code](extras/vscode/), [WezTerm](extras/wezterm/), et [Zed](extras/zed/) sont disponibles dans [extras/](extras/).
Pour les utiliser, référez-vous à leur documentation respective.

### Couleurs du terminal

![Couleurs du terminal](https://github.com/user-attachments/assets/1663931f-7c6e-4502-b7a0-7ff6a24cad06)

## ☀️ Thème clair

Une variante claire est également disponible pour ceux qui la préfèrent.

![Capture d’écran de Monoglow Light](https://github.com/user-attachments/assets/2df72af5-5107-43da-a3c2-e03e7aefd772)

## 🔥 Contribution

Les pull requests sont les bienvenues.

## À propos

Pour créer ce schéma de couleurs, j’ai pris tout ce que j’aimais dans les « couleurs » de [slugbyte/lackluster.nvim](https://github.com/slugbyte/lackluster.nvim),
j’ai ajouté la touche incroyable de lueur et d’opérateurs lumineux de [Aliqyan-21/darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim),
et j’ai utilisé [folke/tokyonight.nvim](https://github.com/folke/tokyonight.nvim) pour la structure du code.

## Licence

Ce projet est sous licence Apache, version 2.0. Voir le fichier [LICENSE](LICENSE) pour plus de détails.

### Remerciements tiers

- Des parties de ce projet incluent du code dérivé de [tokyonight.nvim](https://github.com/folke/tokyonight.nvim), qui est sous licence Apache, version 2.0.
- L’inspiration pour les couleurs et la disposition vient de [lackluster.nvim](https://github.com/slugbyte/lackluster.nvim) et [darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim), tous deux sous licence MIT.
Voir le fichier [NOTICE](NOTICE) pour les attributions et les détails.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---