# 🎆 Mono Glow

Un esquema de colores mayormente monocromático con un toque de brillo.

![Monoglow Z screenshot](https://github.com/user-attachments/assets/4f4052be-def8-43b0-99f2-5c6f2ec2d502)
![Insert mode](https://github.com/user-attachments/assets/1d4239b3-4e3e-4b57-9462-877d9de809c1)
![Visual mode](https://github.com/user-attachments/assets/0c53b594-7351-4dd9-89de-326675d8020d)
<img src="https://github.com/user-attachments/assets/ecd5cf8d-ccfa-41be-a965-ddeb55687caa" alt="Monoglow Z (default) Palette" width="100%">

> [!NOTE]
> Más 📷 [capturas aquí](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/SCREENSHOTS.md)

## ✨ Características

- Soporta las últimas características de [Neovim](https://github.com/neovim/neovim)
  [0.9.0](https://github.com/neovim/neovim/releases/tag/v0.9.0).
- Colores para terminal.
- Soporta ~casi todos los~ plugins principales (ver más abajo).

> [!NOTE]
> Los Plugins y Extras disponibles actualmente están mayormente basados en lo que uso, pero siéntete libre
> de abrir un issue o un PR para sugerir uno nuevo.

<details>
<summary>🎨 Plugins Soportados</summary>

| Plugin                                                             | Fuente                                                             |
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

| Herramienta                                        | Extra                            |
| -------------------------------------------------- | -------------------------------- |
| [Ghostty](https://ghostty.org/docs/features/theme) | [extras/ghostty](extras/ghostty) |
| [Helix](https://helix-editor.com/)                 | [extras/helix](extras/helix)     |
| [Kitty](https://sw.kovidgoyal.net/kitty/conf.html) | [extras/kitty](extras/kitty)     |
| [Vim](https://vimhelp.org/)                        | [extras/vim](extras/vim)         |
| [VS Code](https://code.visualstudio.com/)          | [extras/vscode](extras/vscode)   |
| [WezTerm](https://wezterm.org/)                    | [extras/wezterm](extras/wezterm) |
| [Zed](https://zed.dev/)                            | [extras/zed](extras/zed)         |

</details>

## 📦 Instalación

Instala el tema con tu gestor de paquetes preferido, como
[folke/lazy.nvim](https://github.com/folke/lazy.nvim):

```lua
{
  "wnkz/monoglow.nvim",
  lazy = false,
  priority = 1000,
  opts = {},
}
```

## 🚀 Uso

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

## 🎨 Paleta

> Consulte [PALETTE.md](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/PALETTE.md) para todos los estilos (z, lack, void, light) con ratios de contraste WCAG.

## 🪓 Sobrescribir Colores y Grupos de Resaltado

Cómo se calculan los grupos de resaltado:

1. Los `colors` se determinan según su configuración, con la capacidad de
   sobrescribirlos usando `config.on_colors(colors)`.
1. Estos `colors` se utilizan para generar los grupos de resaltado.
1. `config.on_highlights(highlights, colors)` puede usarse para sobrescribir los grupos de resaltado.

Para los valores predeterminados de `colors` y `highlights`, por favor consulte las
paletas [z](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/z.lua),
[lack](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/lack.lua),
[void](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/void.lua), y
[light](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/light.lua), así como los
[resaltados base](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua).

<details open>
  <summary>Cambiar Colores</summary>


```lua
require("monoglow").setup({
  -- Change the "glow" color
  on_colors = function(colors)
    colors.glow = "#fd1b7c"
  end
})
```

![Monoglow Resplandor Rosa](https://github.com/user-attachments/assets/47ff0e2b-735c-48c8-8a98-90fad6aae114)

</details>

<details>
  <summary>Cambiar Estilos de Resaltado</summary>

Puedes personalizar estilos (cursiva, negrita, etc.) para cualquier grupo de resaltado usando `on_highlights`.

> **Nota:** `on_highlights` reemplaza toda la definición del resaltado. Para preservar
> propiedades existentes (como `fg`), inclúyelas en tu anulación o usa `vim.tbl_extend`.

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

Vea [`lua/monoglow/groups/base.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua) y
[`lua/monoglow/groups/treesitter.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/treesitter.lua) para
todos los grupos de resaltado disponibles.

</details>

## 🍭 Extras

Configuraciones de color extra para [Ghostty](extras/ghostty/), [Kitty](extras/kitty/), [Helix](extras/helix/), [Vim](extras/vim/), [VS Code](extras/vscode/), [WezTerm](extras/wezterm/) y [Zed](extras/zed/) se pueden encontrar en [extras/](extras/).
Para usarlos, consulte su documentación respectiva.

### Colores de Terminal

![Colores de Terminal](https://github.com/user-attachments/assets/1663931f-7c6e-4502-b7a0-7ff6a24cad06)

## ☀️ Tema Claro

También está disponible una variante clara para quienes la prefieran.

![Captura de pantalla de Monoglow Light](https://github.com/user-attachments/assets/2df72af5-5107-43da-a3c2-e03e7aefd772)

## 🔥 Contribuir

Se aceptan solicitudes de extracción.

## Acerca de

Para construir el esquema de colores, tomé todo lo que me gustaba de los "colores" de [slugbyte/lackluster.nvim](https://github.com/slugbyte/lackluster.nvim),
añadí el increíble toque de brillo y operadores destacados de [Aliqyan-21/darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim),
y usé [folke/tokyonight.nvim](https://github.com/folke/tokyonight.nvim) para la estructura del código.

## Licencia

Este proyecto está licenciado bajo la Licencia Apache, Versión 2.0. Consulte el archivo [LICENSE](LICENSE) para más detalles.

### Reconocimientos a Terceros

- Porciones de este proyecto incluyen código derivado de [tokyonight.nvim](https://github.com/folke/tokyonight.nvim), que está licenciado bajo la Licencia Apache, Versión 2.0.
- La inspiración para los colores y la disposición proviene de [lackluster.nvim](https://github.com/slugbyte/lackluster.nvim) y [darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim), ambos licenciados bajo la Licencia MIT.

Consulte el archivo [NOTICE](NOTICE) para atribuciones y detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---