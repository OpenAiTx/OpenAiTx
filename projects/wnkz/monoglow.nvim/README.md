# 🎆 Mono Glow

A mostly monochrome colorscheme with a touch of glowing.

![Monoglow Z screenshot](https://github.com/user-attachments/assets/4f4052be-def8-43b0-99f2-5c6f2ec2d502)
![Insert mode](https://github.com/user-attachments/assets/1d4239b3-4e3e-4b57-9462-877d9de809c1)
![Visual mode](https://github.com/user-attachments/assets/0c53b594-7351-4dd9-89de-326675d8020d)
<img src="https://github.com/user-attachments/assets/ecd5cf8d-ccfa-41be-a965-ddeb55687caa" alt="Monoglow Z (default) Palette" width="100%">

> [!NOTE]
> More 📷 [screenshots here](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/SCREENSHOTS.md)

## ✨ Features

- Supports the latest [Neovim](https://github.com/neovim/neovim)
  [0.9.0](https://github.com/neovim/neovim/releases/tag/v0.9.0) features.
- Terminal colors.
- Supports ~all major~ plugins (see below).

> [!NOTE]
> Currently available Plugins and Extras are mostly based on what I use, but feel free
> to open an issue or a PR to suggest a new one!

<details>
<summary>🎨 Supported Plugins</summary>

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

| Tool                                               | Extra                            |
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

Install the theme with your preferred package manager, such as
[folke/lazy.nvim](https://github.com/folke/lazy.nvim):

```lua
{
  "wnkz/monoglow.nvim",
  lazy = false,
  priority = 1000,
  opts = {},
}
```

## 🚀 Usage

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

> See [PALETTE.md](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/PALETTE.md) for all styles (z, lack, void, light) with WCAG contrast ratios.

## 🪓 Overriding Colors & Highlight Groups

How the highlight groups are calculated:

1. `colors` are determined based on your configuration, with the ability to
   override them using `config.on_colors(colors)`.
1. These `colors` are utilized to generate the highlight groups.
1. `config.on_highlights(highlights, colors)` can be used to override highlight
   groups.

For default values of `colors` and `highlights`, please consult the
[z](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/z.lua),
[lack](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/lack.lua),
[void](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/void.lua), and
[light](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/light.lua) palettes, as well as the
[base highlights](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua).

<details open>
  <summary>Changing Colors</summary>

```lua
require("monoglow").setup({
  -- Change the "glow" color
  on_colors = function(colors)
    colors.glow = "#fd1b7c"
  end
})
```

![Monoglow Pink Glow](https://github.com/user-attachments/assets/47ff0e2b-735c-48c8-8a98-90fad6aae114)

</details>

<details>
  <summary>Changing Highlight Styles</summary>

You can customize styles (italic, bold, etc.) for any highlight group using `on_highlights`.

> **Note:** `on_highlights` replaces the entire highlight definition. To preserve
> existing properties (like `fg`), include them in your override or use `vim.tbl_extend`.

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

See [`lua/monoglow/groups/base.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua) and
[`lua/monoglow/groups/treesitter.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/treesitter.lua) for
all available highlight groups.

</details>

## 🍭 Extras

Extra color configs for [Ghostty](extras/ghostty/), [Kitty](extras/kitty/), [Helix](extras/helix/), [Vim](extras/vim/), [VS Code](extras/vscode/), [WezTerm](extras/wezterm/), and [Zed](extras/zed/) can be found in [extras/](extras/).
To use them, refer to their respective documentation.

### Terminal Colors

![Terminal Colors](https://github.com/user-attachments/assets/1663931f-7c6e-4502-b7a0-7ff6a24cad06)

## ☀️ Light Theme

A light variant is also available for those who prefer it.

![Monoglow Light screenshot](https://github.com/user-attachments/assets/2df72af5-5107-43da-a3c2-e03e7aefd772)

## 🔥 Contributing

Pull requests are welcome.

## About

To build the colorscheme, I took everything I liked about the "colors" of [slugbyte/lackluster.nvim](https://github.com/slugbyte/lackluster.nvim),
I added the amazing touch of glow and bright operators from [Aliqyan-21/darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim),
and I used [folke/tokyonight.nvim](https://github.com/folke/tokyonight.nvim) for the code structure.

## License

This project is licensed under the Apache License, Version 2.0. See the [LICENSE](LICENSE) file for details.

### Third-Party Acknowledgments

- Portions of this project include code derived from [tokyonight.nvim](https://github.com/folke/tokyonight.nvim), which is licensed under the Apache License, Version 2.0.
- Inspiration for colors and arrangement comes from [lackluster.nvim](https://github.com/slugbyte/lackluster.nvim) and [darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim), both licensed under the MIT License.

See the [NOTICE](NOTICE) file for attributions and details.
