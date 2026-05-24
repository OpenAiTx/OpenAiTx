# 🎆 Mono Glow

ほぼモノクロのカラースキームに輝きのアクセントを加えました。

![Monoglow Z screenshot](https://github.com/user-attachments/assets/4f4052be-def8-43b0-99f2-5c6f2ec2d502)
![Insert mode](https://github.com/user-attachments/assets/1d4239b3-4e3e-4b57-9462-877d9de809c1)
![Visual mode](https://github.com/user-attachments/assets/0c53b594-7351-4dd9-89de-326675d8020d)
<img src="https://github.com/user-attachments/assets/ecd5cf8d-ccfa-41be-a965-ddeb55687caa" alt="Monoglow Z (default) Palette" width="100%">

> [!NOTE]
> さらに 📷 [スクリーンショットはこちら](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/SCREENSHOTS.md)

## ✨ 特徴

- 最新の [Neovim](https://github.com/neovim/neovim)
  [0.9.0](https://github.com/neovim/neovim/releases/tag/v0.9.0) の機能をサポート。
- ターミナルカラー対応。
- ~ほぼすべての~ 主要プラグインをサポート（下記参照）。

> [!NOTE]
> 現在利用可能なプラグインおよびエクストラは主に私の使用に基づいていますが、
> 新しいものを提案したい場合はIssueやPRを自由にお送りください！

<details>
<summary>🎨 対応プラグイン</summary>

| プラグイン                                                         | ソース                                                             |
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
<summary>🍭 エクストラ</summary>

| ツール                                              | エクストラ                        |
| -------------------------------------------------- | -------------------------------- |
| [Ghostty](https://ghostty.org/docs/features/theme) | [extras/ghostty](extras/ghostty) |
| [Helix](https://helix-editor.com/)                 | [extras/helix](extras/helix)     |
| [Kitty](https://sw.kovidgoyal.net/kitty/conf.html) | [extras/kitty](extras/kitty)     |
| [Vim](https://vimhelp.org/)                        | [extras/vim](extras/vim)         |
| [VS Code](https://code.visualstudio.com/)          | [extras/vscode](extras/vscode)   |
| [WezTerm](https://wezterm.org/)                    | [extras/wezterm](extras/wezterm) |
| [Zed](https://zed.dev/)                            | [extras/zed](extras/zed)         |

</details>

## 📦 インストール

お好みのパッケージマネージャーでテーマをインストールしてください。例：
[folke/lazy.nvim](https://github.com/folke/lazy.nvim):

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
## 🎨 パレット

> すべてのスタイル（z、lack、void、light）とWCAGコントラスト比については[PALETTE.md](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/PALETTE.md)をご覧ください。

## 🪓 色およびハイライトグループの上書き

ハイライトグループの計算方法:

1. `colors` は設定に基づいて決定され、`config.on_colors(colors)`を使って上書きすることが可能です。
1. これらの `colors` がハイライトグループの生成に利用されます。
1. `config.on_highlights(highlights, colors)` を使用してハイライトグループを上書きできます。

`colors` と `highlights` のデフォルト値については、
[z](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/z.lua)、
[lack](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/lack.lua)、
[void](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/void.lua)、
[light](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/light.lua) のパレットと、
[base highlights](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua) を参照してください。

<details open>
  <summary>色の変更</summary>




```lua
require("monoglow").setup({
  -- Change the "glow" color
  on_colors = function(colors)
    colors.glow = "#fd1b7c"
  end
})
```

![Monoglow ピンクグロー](https://github.com/user-attachments/assets/47ff0e2b-735c-48c8-8a98-90fad6aae114)

</details>

<details>
  <summary>ハイライトスタイルの変更</summary>

`on_highlights` を使用して、任意のハイライトグループのスタイル（イタリック、ボールドなど）をカスタマイズできます。

> **注意:** `on_highlights` はハイライト定義全体を置き換えます。  
> 既存のプロパティ（例えば `fg`）を維持するには、オーバーライドに含めるか `vim.tbl_extend` を使用してください。

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

[`lua/monoglow/groups/base.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua) および
[`lua/monoglow/groups/treesitter.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/treesitter.lua) を参照してください。
利用可能なすべてのハイライトグループが記載されています。

</details>

## 🍭 エクストラ

[Ghostty](extras/ghostty/)、[Kitty](extras/kitty/)、[Helix](extras/helix/)、[Vim](extras/vim/)、[VS Code](extras/vscode/)、[WezTerm](extras/wezterm/)、および[Zed](extras/zed/)向けの追加カラ―設定は[extras/](extras/)にあります。
使用するには、それぞれのドキュメントを参照してください。

### ターミナルカラー

![Terminal Colors](https://github.com/user-attachments/assets/1663931f-7c6e-4502-b7a0-7ff6a24cad06)

## ☀️ ライトテーマ

ライトバリアントも用意しており、好みの方におすすめです。

![Monoglow Light screenshot](https://github.com/user-attachments/assets/2df72af5-5107-43da-a3c2-e03e7aefd772)

## 🔥 コントリビュート

プルリクエストは歓迎します。

## 概要

カラースキームの構築にあたり、[slugbyte/lackluster.nvim](https://github.com/slugbyte/lackluster.nvim) の「色」で気に入った部分を取り入れ、
[Aliqyan-21/darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim) の素晴らしいグローと明るい演算子の要素を加え、
コード構造には [folke/tokyonight.nvim](https://github.com/folke/tokyonight.nvim) を使用しました。

## ライセンス

本プロジェクトは Apache License, Version 2.0 の下でライセンスされています。詳細は [LICENSE](LICENSE) ファイルを参照してください。

### サードパーティーに関する謝辞

- 本プロジェクトの一部は Apache License, Version 2.0 の下でライセンスされている [tokyonight.nvim](https://github.com/folke/tokyonight.nvim) のコードを含みます。
- 色や配置のインスピレーションは MIT License の [lackluster.nvim](https://github.com/slugbyte/lackluster.nvim) と [darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim) から得ています。

帰属および詳細については、[NOTICE](NOTICE) ファイルをご参照ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---