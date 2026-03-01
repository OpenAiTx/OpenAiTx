# <p align="center"> *NEOMODERN*.nvim </p>

<p align="center">
モダン — シンプル — 控えめ
</p>

<p align="center">
<img src="https://img.shields.io/github/v/tag/cdmill/neomodern.nvim?style=flat&label=RELEASE&labelColor=%23212123&color=%238a88db" />
<img src="https://img.shields.io/badge/BUILT_WITH_LUA-blue?style=flat&color=%23629da3" />
<img src="https://img.shields.io/badge/NEOVIM-0.9-blue?style=flat&logo=Neovim&labelColor=%23212123&color=%238a88db" />
</p>

## 目次

- [ギャラリー](#gallery)
- [インストール](#installation)
- [設定](#configuration)
- [カスタマイズ](#customization)
- [レシピ](#recipes)
- [貢献](#contributing)
- [インスピレーション](inspiration)

## ギャラリー

### 🌚 MOON

月の色から着想を得た、暗く宇宙的なテーマ

<details open>
<summary>ダークバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-dark.png)

</details>

<details closed>
<summary>ライトバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-light.png)

</details>

### ❄️ *アイスクライマー*

任天堂のアイスクライマーキャラクターにインスパイアされた色のテーマ

<details open>
<summary>ダークバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-dark.png)

</details>

<details closed>
<summary>ライトバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-light.png)

</details>

### 🌱 *玉露*

新鮮な緑茶にインスパイアされたテーマ

<details open>
<summary>ダークバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-dark.png)

</details>

<details closed>
<summary>ライトバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-light.png)

</details>

### 🍂 *ほうじ茶*

焙煎された緑茶にインスパイアされたテーマ

<details open>
<summary>ダークバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-dark.png)

</details>

<details closed>
<summary>ライトバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-light.png)

</details>

### 🌷 *ROSEPRIME*

[ThePrimeagen](https://github.com/ThePrimeagen)による[Rosé-Pine](https://github.com/rose-pine/neovim)テーマの使用に触発されました

<details open>
<summary>ダークバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-dark.png)

</details>

<details closed>
<summary>ライトバリアント</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-light.png)

</details>

## インストール

vim.packを使用：

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").setup({
-- optional configuration
})
require("neomodern").load()
```

注意：デフォルトのオプションを上書きする場合にのみsetupを呼び出す必要があります。  
テーマを設定するだけの場合は、代わりに以下を使用できます：  

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").load("iceclimber")
```

## 設定

5つのテーマが含まれており、それぞれにライトとダークのバリアントがあります。
ライトテーマは `vim.o.background = "light"` の時に使用されます。

デフォルトのオプションは以下の通りです：

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

## カスタマイズ

Neomodernはユーザー定義の色の上書きをサポートしています。ユーザーは
デフォルトの色を上書きするか、特定のハイライトグループのハイライトを変更
できます。ハイライトグループを上書きする際は、色名の先頭にドル記号を付けて
neomodernの色を使用してください（例：`$keyword`）。詳細な引数やデフォルトの
色名については、`:h highlight-args`および`:h neomodern-types`を参照してください。

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

## レシピ

### Treesitter ハイライトを優先する

ハイライトを lsp-semantic ハイライトよりも treesitter に偏らせたい場合は、
設定のどこかに次を使用してください:

```lua
vim.highlight.priorities.semantic_tokens = 95
```

### ライト/ダークバリアント間を切り替えるキーマップ

Neomodernはどのバリアントを読み込むかを決定するために`vim.opt.background`を使用するので、
バリアント間を切り替えるには単に`vim.opt.background`を切り替えればよい。

```lua
vim.keymap.set("n", "<leader>uc", function()
    if vim.opt.background == "light" then
        vim.opt.background = "dark"
    else
        vim.opt.background = "light"
    end
end, { desc = "Toggle between light/dark mode" })
```

## 貢献について

プラグインやエクストラのサポートを希望される場合は、Issueを開くか
PRを提出してください。

## インスピレーション

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