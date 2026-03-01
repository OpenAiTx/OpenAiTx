# <p align="center"> *NEOMODERN*.nvim </p>

<p align="center">
모던 — 심플 — 방해되지 않는
</p>

<p align="center">
<img src="https://img.shields.io/github/v/tag/cdmill/neomodern.nvim?style=flat&label=RELEASE&labelColor=%23212123&color=%238a88db" />
<img src="https://img.shields.io/badge/BUILT_WITH_LUA-blue?style=flat&color=%23629da3" />
<img src="https://img.shields.io/badge/NEOVIM-0.9-blue?style=flat&logo=Neovim&labelColor=%23212123&color=%238a88db" />
</p>

## 목차

- [갤러리](#gallery)
- [설치](#installation)
- [설정](#configuration)
- [사용자화](#customization)
- [레시피](#recipes)
- [기여](#contributing)
- [영감](inspiration)

## 갤러리

### 🌚 문

달의 색상에서 영감을 받은 어둡고 우주적인 테마

<details open>
<summary>다크 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-dark.png)

</details>

<details closed>
<summary>라이트 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/moon-light.png)

</details>

### ❄️ *ICECLIMBER*

닌텐도의 아이스 클라이머 캐릭터에서 영감을 받은 색상 테마

<details open>
<summary>다크 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-dark.png)

</details>

<details closed>
<summary>라이트 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/iceclimber-light.png)

</details>

### 🌱 *GYOKURO*

신선한 녹차에서 영감을 받은 테마

<details open>
<summary>다크 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-dark.png)

</details>

<details closed>
<summary>라이트 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/gyokuro-light.png)

</details>

### 🍂 *HOJICHA*

볶은 녹차에서 영감을 받은 테마

<details open>
<summary>다크 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-dark.png)

</details>

<details closed>
<summary>라이트 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/hojicha-light.png)

</details>

### 🌷 *ROSEPRIME*

[ThePrimeagen](https://github.com/ThePrimeagen)이 [Rosé-Pine](https://github.com/rose-pine/neovim) 테마를 사용한 데서 영감을 받음

<details open>
<summary>다크 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-dark.png)

</details>

<details closed>
<summary>라이트 버전</summary>

![image](https://github.com/cdmill/neomodern.nvim/blob/assets/roseprime-light.png)

</details>

## 설치

vim.pack 사용:

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").setup({
-- optional configuration
})
require("neomodern").load()
```

참고로, 기본 옵션을 재정의하는 경우에만 setup을 호출하면 됩니다. 만약
테마 설정만 하려는 경우에는 다음과 같은 방법을 사용할 수 있습니다:

```lua
vim.pack.add({"https://github.com/casedami/neomodern.nvim"})
require("neomodern").load("iceclimber")
```

## 구성

총 5개의 테마가 포함되어 있으며, 각각 밝은 버전과 어두운 버전이 있습니다.
`vim.o.background = "light"`일 때 밝은 테마가 사용됩니다.

기본 옵션은 아래와 같습니다:

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

## 사용자 정의

Neomodern은 사용자 정의 색상 재정의를 지원합니다. 사용자는 기본 색상을 재정의하거나 특정 하이라이트 그룹의 하이라이트를 변경할 수 있습니다.  
하이라이트 그룹을 재정의할 때는 색상 이름 앞에 달러 기호를 붙여 neomodern의 색상을 사용하세요(예: `$keyword`). `:h highlight-args` 및 `:h  
neomodern-types`에서 예상 인자, 기본 색상 이름 등을 확인할 수 있습니다.



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

## 레시피

### 트리시터 하이라이트 선호

하이라이트를 lsp-시맨틱 하이라이트보다 트리시터 쪽으로 편향시키고 싶다면,
설정 파일 어딘가에 다음을 사용하세요:

```lua
vim.highlight.priorities.semantic_tokens = 95
```

### 라이트/다크 변형 간 전환 키맵

Neomodern은 어떤 변형을 로드할지 결정하기 위해 `vim.opt.background`를 사용하므로,
변형 간 전환은 단순히 `vim.opt.background`를 토글하면 됩니다.

```lua
vim.keymap.set("n", "<leader>uc", function()
    if vim.opt.background == "light" then
        vim.opt.background = "dark"
    else
        vim.opt.background = "light"
    end
end, { desc = "Toggle between light/dark mode" })
```
## 기여하기

플러그인이나 추가 기능에 대한 지원을 원하시면 이슈를 열거나
PR을 제출해 주세요.

## 영감

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