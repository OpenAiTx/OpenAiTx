# <p align="center"> *NEOMODERN*.nvim </p>

<p align="center">
现代 — 简约 — 不显眼
</p>

<p align="center">
<img src="https://img.shields.io/github/v/tag/cdmill/neomodern.nvim?style=flat&label=RELEASE&labelColor=%23212123&color=%238a88db" />
<img src="https://img.shields.io/badge/BUILT_WITH_LUA-blue?style=flat&color=%23629da3" />
<img src="https://img.shields.io/badge/NEOVIM-0.9-blue?style=flat&logo=Neovim&labelColor=%23212123&color=%238a88db" />
</p>

## 目录

- [画廊](#gallery)
- [安装](#installation)
- [配置](#configuration)
- [自定义](#customization)
- [示例](#recipes)
- [贡献](#contributing)
- [灵感来源](inspiration)

## 画廊

### 🌚 月亮

一个暗色、空间感主题，灵感来自月球的颜色

<details open>
<summary>暗色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-dark.png)

</details>

<details closed>
<summary>亮色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-light.png)

</details>

### ❄️ *冰登山者*

一个以任天堂冰登山者角色色彩为灵感的主题

<details open>
<summary>暗色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-dark.png)

</details>

<details closed>
<summary>亮色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-light.png)

</details>

### 🌱 *玉露*

一个以新鲜绿茶为灵感的主题

<details open>
<summary>暗色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-dark.png)

</details>

<details closed>
<summary>亮色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-light.png)

</details>

### 🍂 *焙茶*

烘焙绿茶灵感主题

<details open>
<summary>暗色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-dark.png)

</details>

<details closed>
<summary>亮色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-light.png)

</details>

### 🌷 *ROSEPRIME*

灵感来自 [ThePrimeagen](https://github.com/ThePrimeagen) 对 [Rosé-Pine](https://github.com/rose-pine/neovim) 主题的使用

<details open>
<summary>暗色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-dark.png)

</details>

<details closed>
<summary>亮色变体</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-light.png)

</details>

## 安装

使用 vim.pack:

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").setup({
-- optional configuration
})
require("neomodern").load()
```
请注意，只有当您覆盖任何默认选项时才需要调用 setup。  
如果您只是用它来设置主题，可以改用以下方法：  


```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").load("iceclimber")
```

## 配置

包含了5个主题，每个主题都有明亮和暗黑两种变体。
当 `vim.o.background = "light"` 时使用明亮主题。

默认选项如下：

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

## 自定义

Neomodern 支持用户定义的颜色覆盖。用户可以覆盖默认颜色，或修改特定高亮组的高亮。  
在覆盖高亮组时，通过在颜色名称前加美元符号来使用 neomodern 的颜色（例如 `$keyword`）。  
有关预期参数、默认颜色名称等信息，请参见 `:h highlight-args` 和 `:h neomodern-types`。



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

## 方案

### 优先使用 Treesitter 高亮

如果你更倾向于偏向使用 treesitter 的高亮（而不是
lsp-semantic 高亮），请在配置中使用以下内容：

```lua
vim.highlight.priorities.semantic_tokens = 95
```

### 切换明暗主题的键位映射

Neomodern 使用 `vim.opt.background` 来决定加载哪个主题变体，因此
要切换变体，只需切换 `vim.opt.background` 即可。

```lua
vim.keymap.set("n", "<leader>uc", function()
    if vim.opt.background == "light" then
        vim.opt.background = "dark"
    else
        vim.opt.background = "light"
    end
end, { desc = "Toggle between light/dark mode" })
```

## 贡献

如果您想要插件或额外功能的支持，请打开一个 issue 或提交一个 PR。

## 灵感来源

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