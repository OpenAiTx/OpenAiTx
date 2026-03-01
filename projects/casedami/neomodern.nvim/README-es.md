# <p align="center"> *NEOMODERN*.nvim </p>

<p align="center">
moderno — simple — no intrusivo
</p>

<p align="center">
<img src="https://img.shields.io/github/v/tag/cdmill/neomodern.nvim?style=flat&label=RELEASE&labelColor=%23212123&color=%238a88db" />
<img src="https://img.shields.io/badge/BUILT_WITH_LUA-blue?style=flat&color=%23629da3" />
<img src="https://img.shields.io/badge/NEOVIM-0.9-blue?style=flat&logo=Neovim&labelColor=%23212123&color=%238a88db" />
</p>

## Tabla de Contenidos

- [Galería](#gallery)
- [Instalación](#installation)
- [Configuración](#configuration)
- [Personalización](#customization)
- [Recetas](#recipes)
- [Contribuir](#contributing)
- [Inspiración](inspiration)

## Galería

### 🌚 LUNA

Un tema oscuro y espacial inspirado en los colores de la luna

<details open>
<summary>Variante Oscura</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-dark.png)

</details>

<details closed>
<summary>Variante Clara</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-light.png)

</details>

### ❄️ *ICECLIMBER*

Un tema con colores inspirados en los personajes de Ice Climbers de Nintendo

<details open>
<summary>Variante Oscura</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-dark.png)

</details>

<details closed>
<summary>Variante Clara</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-light.png)

</details>

### 🌱 *GYOKURO*

Un tema inspirado en el té verde fresco

<details open>
<summary>Variante Oscura</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-dark.png)

</details>

<details closed>
<summary>Variante Clara</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-light.png)

</details>

### 🍂 *HOJICHA*

Un tema inspirado en el té verde tostado

<details open>
<summary>Variante Oscura</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-dark.png)

</details>

<details closed>
<summary>Variante Clara</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-light.png)

</details>

### 🌷 *ROSEPRIME*

Inspirado en el uso de [ThePrimeagen](https://github.com/ThePrimeagen) del tema [Rosé-Pine](https://github.com/rose-pine/neovim)

<details open>
<summary>Variante Oscura</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-dark.png)

</details>

<details closed>
<summary>Variante Clara</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-light.png)

</details>

## Instalación

Usando vim.pack:

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").setup({
-- optional configuration
})
require("neomodern").load()
```

Tenga en cuenta que solo necesita llamar a setup si está sobrescribiendo alguna opción predeterminada. Si
solo lo está usando para configurar el tema, podría usar lo siguiente en su lugar:

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").load("iceclimber")
```

## Configuración

Se incluyen 5 temas, cada uno con una variante clara y oscura.  
El tema claro se usa cuando `vim.o.background = "light"`.  

Las opciones predeterminadas se muestran a continuación:  

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

## Personalización

Neomodern soporta sobrescrituras de color definidas por el usuario. El usuario puede
sobrescribir los colores por defecto o modificar los resaltados de un grupo de
resaltado específico. Al sobrescribir grupos de resaltado, use los colores de
neomodern anteponiendo el nombre del color con un signo de dólar (ej. `$keyword`).
Consulte `:h highlight-args` y `:h neomodern-types` para los argumentos esperados,
nombres de colores por defecto, etc.
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

## Recetas

### Preferir resaltados de Treesitter

Si prefieres dar prioridad a los resaltados de treesitter (en lugar de
los resaltados semánticos de lsp), usa esto en algún lugar de tu configuración:

```lua
vim.highlight.priorities.semantic_tokens = 95
```

### Mapa de teclas para alternar entre variantes Claro/Oscuro

Neomodern usa `vim.opt.background` para decidir qué variante cargar, así que para
alternar entre variantes simplemente alterna `vim.opt.background`.

```lua
vim.keymap.set("n", "<leader>uc", function()
    if vim.opt.background == "light" then
        vim.opt.background = "dark"
    else
        vim.opt.background = "light"
    end
end, { desc = "Toggle between light/dark mode" })
```

## Contribuyendo

Si deseas soporte para un plugin o un extra, por favor abre un issue o
envía un PR.

## Inspiración

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