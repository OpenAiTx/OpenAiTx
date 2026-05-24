# 🎆 모노 글로우

대부분 단색 계열에 빛나는 효과를 더한 색상 테마입니다.

![Monoglow Z 스크린샷](https://github.com/user-attachments/assets/4f4052be-def8-43b0-99f2-5c6f2ec2d502)
![삽입 모드](https://github.com/user-attachments/assets/1d4239b3-4e3e-4b57-9462-877d9de809c1)
![비주얼 모드](https://github.com/user-attachments/assets/0c53b594-7351-4dd9-89de-326675d8020d)
<img src="https://github.com/user-attachments/assets/ecd5cf8d-ccfa-41be-a965-ddeb55687caa" alt="Monoglow Z (기본) 팔레트" width="100%">

> [!NOTE]
> 더 많은 📷 [스크린샷 보기](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/SCREENSHOTS.md)

## ✨ 특징

- 최신 [Neovim](https://github.com/neovim/neovim)
  [0.9.0](https://github.com/neovim/neovim/releases/tag/v0.9.0) 기능 지원.
- 터미널 컬러 지원.
- ~대부분 주요~ 플러그인 지원 (아래 참조).

> [!NOTE]
> 현재 제공되는 플러그인 및 추가 기능은 주로 제가 사용하는 것들이지만,
> 새 플러그인 제안이 있으면 이슈나 PR을 열어주세요!

<details>
<summary>🎨 지원하는 플러그인</summary>

| 플러그인                                                           | 출처                                                               |
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
<summary>🍭 추가 기능</summary>

| 도구                                               | 추가 기능                          |
| -------------------------------------------------- | -------------------------------- |
| [Ghostty](https://ghostty.org/docs/features/theme) | [extras/ghostty](extras/ghostty) |
| [Helix](https://helix-editor.com/)                 | [extras/helix](extras/helix)     |
| [Kitty](https://sw.kovidgoyal.net/kitty/conf.html) | [extras/kitty](extras/kitty)     |
| [Vim](https://vimhelp.org/)                        | [extras/vim](extras/vim)         |
| [VS Code](https://code.visualstudio.com/)          | [extras/vscode](extras/vscode)   |
| [WezTerm](https://wezterm.org/)                    | [extras/wezterm](extras/wezterm) |
| [Zed](https://zed.dev/)                            | [extras/zed](extras/zed)         |

</details>

## 📦 설치

원하는 패키지 관리자, 예를 들어
[folke/lazy.nvim](https://github.com/folke/lazy.nvim)를 사용하여 테마를 설치하세요:


```lua
{
  "wnkz/monoglow.nvim",
  lazy = false,
  priority = 1000,
  opts = {},
}
```
## 🚀 사용법


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
## 🎨 팔레트

> 모든 스타일(z, lack, void, light)과 WCAG 대비 비율은 [PALETTE.md](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/PALETTE.md)를 참조하세요.

## 🪓 색상 및 하이라이트 그룹 재정의

하이라이트 그룹이 계산되는 방법:

1. `colors`는 구성에 따라 결정되며, `config.on_colors(colors)`를 사용해 재정의할 수 있습니다.
1. 이 `colors`를 사용하여 하이라이트 그룹이 생성됩니다.
1. `config.on_highlights(highlights, colors)`를 사용해 하이라이트 그룹을 재정의할 수 있습니다.

`colors`와 `highlights`의 기본 값은
[z](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/z.lua),
[lack](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/lack.lua),
[void](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/void.lua), 및
[light](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/colors/light.lua) 팔레트와
[기본 하이라이트](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua)를 참조하세요.

<details open>
  <summary>색상 변경하기</summary>




```lua
require("monoglow").setup({
  -- Change the "glow" color
  on_colors = function(colors)
    colors.glow = "#fd1b7c"
  end
})
```

![모노글로우 핑크 글로우](https://github.com/user-attachments/assets/47ff0e2b-735c-48c8-8a98-90fad6aae114)

</details>

<details>
  <summary>하이라이트 스타일 변경</summary>

`on_highlights`를 사용하여 모든 하이라이트 그룹에 대해 스타일(이탤릭, 볼드 등)을 사용자화할 수 있습니다.

> **참고:** `on_highlights`는 전체 하이라이트 정의를 대체합니다.  
> 기존 속성(예: `fg`)을 유지하려면 오버라이드에 포함시키거나 `vim.tbl_extend`를 사용하세요.

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

모든 사용 가능한 하이라이트 그룹은 [`lua/monoglow/groups/base.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/base.lua) 및
[`lua/monoglow/groups/treesitter.lua`](https://raw.githubusercontent.com/wnkz/monoglow.nvim/main/lua/monoglow/groups/treesitter.lua)를 참조하세요.

</details>

## 🍭 추가 기능

[Ghostty](extras/ghostty/), [Kitty](extras/kitty/), [Helix](extras/helix/), [Vim](extras/vim/), [VS Code](extras/vscode/), [WezTerm](extras/wezterm/), [Zed](extras/zed/)용 추가 색상 설정은 [extras/](extras/)에서 확인할 수 있습니다.
사용하려면 각 문서를 참조하세요.

### 터미널 색상

![터미널 색상](https://github.com/user-attachments/assets/1663931f-7c6e-4502-b7a0-7ff6a24cad06)

## ☀️ 라이트 테마

선호하는 사용자를 위해 라이트 버전도 제공됩니다.

![Monoglow 라이트 스크린샷](https://github.com/user-attachments/assets/2df72af5-5107-43da-a3c2-e03e7aefd772)

## 🔥 기여

풀 리퀘스트는 환영합니다.

## 소개

이 색상 테마를 만들기 위해 [slugbyte/lackluster.nvim](https://github.com/slugbyte/lackluster.nvim)의 "색상" 중 마음에 드는 모든 것을 가져왔고,
[Aliqyan-21/darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim)의 빛나는 효과와 밝은 연산자들을 추가했으며,
[folke/tokyonight.nvim](https://github.com/folke/tokyonight.nvim)을 코드 구조에 활용했습니다.

## 라이선스

이 프로젝트는 Apache License, Version 2.0에 따라 라이선스가 부여되었습니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

### 제3자 감사

- 이 프로젝트의 일부 코드는 Apache License, Version 2.0 하에 라이선스된 [tokyonight.nvim](https://github.com/folke/tokyonight.nvim)에서 파생되었습니다.
- 색상 및 배열에 대한 영감은 MIT 라이선스 하에 있는 [lackluster.nvim](https://github.com/slugbyte/lackluster.nvim)과 [darkvoid.nvim](https://github.com/Aliqyan-21/darkvoid.nvim)에서 받았습니다.


자세한 내용과 저작권 표시는 [NOTICE](NOTICE) 파일을 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---