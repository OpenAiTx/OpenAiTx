<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">AstroNvim 커뮤니티 저장소</h1>

AstroNvim의 커뮤니티 저장소는 플러그인 구성 사양을 포함하고 있습니다 — AstroNvim, 즉 NeoVim 구성용으로 커뮤니티가 기여한 플러그인 모음입니다. 이 사양은 AstroNvim에서 사용되는 다양한 플러그인 관리를 돕습니다.

## 📦 설정

커뮤니티 플러그인을 통합하려면 제공된 구성을 `plugins` 설정에 추가하세요. 자신의 플러그인을 불러오기 전에 추가하는 것이 좋으며, 이렇게 하면 모든 AstroCommunity 변경 사항이 자신의 오버라이드보다 먼저 로드됩니다. [AstroNvim 템플릿](https://github.com/AstroNvim/template)을 사용하는 경우, 이는 `lua/community.lua` 파일에서 할 수 있습니다. 플러그인 구성에 익숙하지 않다면, [AstroNvim 문서](https://docs.astronvim.com/configuration/customizing_plugins/)를 참고하시길 권장합니다.

### AstroCommunity 플러그인 가져오기

`lua/community.lua` 파일 내에 다음 내용을 통합하세요:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "astrocommunity.colorscheme.catppuccin" },
  -- ... 여기에서 커뮤니티가 기여한 플러그인을 추가로 가져오기
}
```

### AstroCommunity 설치 사용자화

`lua/community.lua`에 AstroCommunity 가져오기를 정의한 후, 자신의 플러그인 정의(보통 `lua/plugins/` 디렉토리에서)에서 설치를 추가로 사용자화할 수 있습니다. 아래 예시는 위에서 Catppuccin을 설치한 경우입니다.

```lua
return {
  { -- 커뮤니티가 설정한 옵션을 추가로 사용자화
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**참고:**

- 가져오기를 비활성화하려면 `enabled` 옵션을 `false`로 설정하세요. 기존 플러그인을 수정하는 방법은 두 가지가 있습니다: 전체 저장소 이름 사용(예: "m4xshen/smartcolumn.nvim") 또는 모듈 이름 사용(예: "catppuccin"). 모듈 이름은 폴더 이름과 다를 수 있음을 기억하세요.
- 플러그인을 사용자화할 때는 저장소 이름만 간략하게 쓰지 말고 전체 가져오기 경로를 사용하는 것이 권장됩니다.
- 커뮤니티 플러그인의 설정, 의존성, 버전 등 많은 부분을 재정의할 수 있습니다. 사용 가능한 옵션에 대한 자세한 내용은 [lazy.nvim 문서](https://lazy.folke.io/)를 참고하세요.

## 기여하기

플러그인 구성을 작성했고 이를 AstroCommunity 저장소에 추가하고 싶다면, [기여 가이드라인](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md)을 따라 풀 리퀘스트를 제출해 주세요. 제출 전에 변경 사항을 철저히 테스트했는지 확인하세요. 이 저장소는 공식 저장소가 아니므로 안정성은 커뮤니티 기여에 달려 있습니다. 이 프로젝트가 어떻게 성장하고 발전하는지 기대합니다!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---