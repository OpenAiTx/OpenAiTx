# 🎆 Mono Glow

一个主要以单色为主，带有一点发光效果的配色方案。

![Monoglow Z screenshot](https://github.com/user-attachments/assets/4f4052be-def8-43b0-99f2-5c6f2ec2d502)
![Insert mode](https://github.com/user-attachments/assets/1d4239b3-4e3e-4b57-9462-877d9de809c1)
![Visual mode](https://github.com/user-attachments/assets/0c53b594-7351-4dd9-89de-326675d8020d)
<img src="https://github.com/user-attachments/assets/ecd5cf8d-ccfa-41be-a965-ddeb55687caa" alt="Monoglow Z (default) Palette" width="100%">

> [!NOTE]
> 更多 📷 [截图在这里](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/SCREENSHOTS.md)

## ✨ 功能特点

- 支持最新的 [Neovim](https://github.com/neovim/neovim)
  [0.9.0](https://github.com/neovim/neovim/releases/tag/v0.9.0) 功能。
- 终端颜色支持。
- 支持 ~几乎所有主流~ 插件（见下文）。

> [!NOTE]
> 当前可用的插件和附加功能主要基于我个人使用，但欢迎
> 提交 issue 或 PR 来建议新的插件！

<details>
<summary>🎨 支持的插件</summary>

| 插件                                                              | 来源                                                               |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- |
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
<summary>🍭 额外内容</summary>

| 工具                                               | 额外内容                          |
| -------------------------------------------------- | -------------------------------- |
| [Ghostty](https://ghostty.org/docs/features/theme) | [extras/ghostty](extras/ghostty) |
| [Helix](https://helix-editor.com/)                 | [extras/helix](extras/helix)     |
| [Kitty](https://sw.kovidgoyal.net/kitty/conf.html) | [extras/kitty](extras/kitty)     |
| [Vim](https://vimhelp.org/)                        | [extras/vim](extras/vim)         |
| [VS Code](https://code.visualstudio.com/)          | [extras/vscode](extras/vscode)   |
| [WezTerm](https://wezterm.org/)                    | [extras/wezterm](extras/wezterm) |
| [Zed](https://zed.dev/)                            | [extras/zed](extras/zed)         |

</details>

## 📦 安装

使用你喜欢的包管理器安装主题，例如
[folke/lazy.nvim](https://github.com/folke/lazy.nvim)：


```lua
{
  "wnkz/monoglow.nvim",
  lazy = false,
  priority = 1000,
  opts = {},
}
```

## 🚀 使用方法

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

## 🎨 调色板

> 请参阅 [PALETTE.md](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/PALETTE.md) 获取所有样式（z、lack、void、light）及其 WCAG 对比度比率。

## 🪓 覆盖颜色和高亮组

高亮组的计算方式：

1. `colors` 根据您的配置确定，并可以通过 `config.on_colors(colors)` 进行覆盖。
1. 这些 `colors` 用于生成高亮组。
1. 可以使用 `config.on_highlights(highlights, colors)` 来覆盖高亮组。

有关 `colors` 和 `highlights` 的默认值，请参阅
[z](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/z.lua),
[lack](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/lack.lua),
[void](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/void.lua) 和
[light](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/light.lua) 调色板，以及
[基础高亮](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua)。

<details open>
  <summary>更改颜色</summary>



```lua
require("monoglow").setup({
  -- Change the "glow" color
  on_colors = function(colors)
    colors.glow = "#fd1b7c"
  end
})
```

![Monoglow 粉色光晕](https://github.com/user-attachments/assets/47ff0e2b-735c-48c8-8a98-90fad6aae114)

</details>

<details>
  <summary>更改高亮样式</summary>

您可以使用 `on_highlights` 自定义任何高亮组的样式（斜体、粗体等）。

> **注意：** `on_highlights` 会替换整个高亮定义。要保留
> 现有属性（如 `fg`），请在覆盖中包含它们或使用 `vim.tbl_extend`。

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

请参阅 [`lua/monoglow/groups/base.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua) 和
[`lua/monoglow/groups/treesitter.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/treesitter.lua) 获取
所有可用的高亮组。

</details>

## 🍭 额外内容

[Ghostty](extras/ghostty/)、[Kitty](extras/kitty/)、[Helix](extras/helix/)、[Vim](extras/vim/)、[VS Code](extras/vscode/)、[WezTerm](extras/wezterm/) 和 [Zed](extras/zed/) 的额外颜色配置可在 [extras/](extras/) 中找到。
使用时，请参考各自的文档。

### 终端颜色

![终端颜色](https://github.com/user-attachments/assets/1663931f-7c6e-4502-b7a0-7ff6a24cad06)

## ☀️ 亮色主题

也提供了适合喜欢亮色主题的用户的亮色变体。

![Monoglow 亮色截图](https://github.com/user-attachments/assets/2df72af5-5107-43da-a3c2-e03e7aefd772)

## 🔥 贡献

欢迎提交拉取请求。

## 关于

为了构建该配色方案，我采纳了我喜欢的 [slugbyte/lackluster.nvim](https://github.com/slugbyte/lackluster.nvim) 中“颜色”的所有优点，
加入了 [Aliqyan-21/darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim) 中惊艳的发光效果和明亮操作符，
并且使用了 [folke/tokyonight.nvim](https://github.com/folke/tokyonight.nvim) 的代码结构。

## 许可证

本项目采用 Apache 许可证 2.0 版本授权。详情请参见 [LICENSE](LICENSE) 文件。

### 第三方鸣谢

- 本项目部分代码源自 [tokyonight.nvim](https://github.com/folke/tokyonight.nvim)，其采用 Apache 许可证 2.0 版本授权。
- 颜色和布局灵感来自 [lackluster.nvim](https://github.com/slugbyte/lackluster.nvim) 和 [darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim)，两者均采用 MIT 许可证授权。
请参阅[NOTICE](NOTICE) 文件以获取归属和详细信息。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---