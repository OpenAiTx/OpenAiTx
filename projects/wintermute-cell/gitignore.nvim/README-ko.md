<!-- LTeX: language=en-US -->
# gitignore.nvim
![gitignore.nvim 로고 배너](https://github.com/wintermute-cell/gitignore.nvim/blob/resources/_resources/banner.webp)

수많은 다양한 기술 중에서 선택하여 몇 초 만에 .gitignore 파일을 생성할 수 있는 네오빔 플러그인입니다.

이 플러그인은 [gitignore.io](https://www.toptal.com/developers/gitignore/)에서 제공하는 서비스와 기능적으로 동일하지만, 오프라인에서 그리고 네오빔 내부에서 직접 `.gitignore` 파일을 생성할 수 있습니다.

1. [설치](#installation--dependencies)
2. [사용법](#usage)
3. [데모](#demo)
4. [크레딧](#credits)

## 설치 및 의존성
**`gitignore.nvim`은 선택적으로 [telescope.nvim](https://github.com/nvim-telescope/telescope.nvim)에 의존하여 [다중 선택](#selecting-multiple-items)을 제공합니다. [telescope](https://github.com/nvim-telescope/telescope.nvim#installation)를 설치하지 않으면 여러 기술을 선택할 수 없습니다.**

`telescope.nvim`을 설치한 후, 다음과 같이 `gitignore.nvim`을 설치할 수 있습니다:

[lazy.nvim](https://github.com/folke/lazy.nvim) 사용하기







```lua
{"wintermute-cell/gitignore.nvim",
    config = function()
        require('gitignore')
    end,
}
```

[packer.nvim](https://github.com/wbthomason/packer.nvim) 사용:
```lua
use({
     "wintermute-cell/gitignore.nvim",
     requires = {
        "nvim-telescope/telescope.nvim" -- optional: for multi-select
     }
})
```

## 사용법
이 플러그인은 하나의 명령어만 제공하며 실행 시,
`.gitignore` 내용이 담긴 버퍼를 생성합니다:
```
:Gitignore [path]
```
기존 `.gitignore` 파일이 발견되면, 생성된 내용은 기존 줄 뒤에 추가됩니다. 버퍼는 자동으로 저장되지 않으므로 기존 `.gitignore` 파일이 덮어써질 위험이 없습니다.

명령어에 `path` 인수를 **선택적으로** 전달하여 특정 디렉토리를 지정할 수 있습니다 (예: 중첩된 `.gitignore` 파일이 있는 경우).

또는 대응하는 `lua` 함수를 직접 사용할 수도 있습니다. 예를 들어 키맵을 생성하려면:




```lua
local gitignore = require("gitignore")
vim.keymap.set("n", "<leader>gi", gitignore.generate)
```
또는 경로와 함께:

```lua
local gitignore = require("gitignore")
local my_path = "./some/path"
vim.keymap.set("n", "<leader>gi",
    function ()
        gitignore.generate(my_path)
    end
)
```
### 여러 항목 선택하기
텔레스코프 없이 `gitignore.nvim`은 `.gitignore`에 대해 여러
기술을 선택할 수 없습니다. 이는 대체 선택기인 `vim.ui.select()`가
한 항목만 선택할 수 있기 때문입니다.
따라서 여러 기술을 선택하려면
[telescope.nvim을 설치](https://github.com/nvim-telescope/telescope.nvim#installation)
해야 하며(예시는
[설치](#installation--dependencies) 섹션에서 `packer.nvim`을 사용하는 예를 찾을 수 있습니다),
또는 제공된 `generate` 메서드를 직접 구현으로
재정의해야 합니다([아래 섹션 참조](#custom-picker)).

`gitignore.nvim`은 `telescope.nvim`이 설치되어 있으면 자동으로 감지하여
사용하므로 추가 구성이 필요 없습니다.

### telescope.nvim 설치 시 여러 항목 선택하기
`gitignore.nvim`은 `telescope.nvim`의 다중 선택 키 바인딩을 사용합니다.
즉, 기본적으로 `<Tab>`으로 여러 키워드를 (선택/선택 해제)할 수 있고,
`<CR>`(엔터)로 선택을 확정할 수 있습니다.
여러 키워드가 선택된 경우, `<CR>`을 누른 강조 표시된 키워드는
선택에 **추가되지 않습니다**!

편의를 위해 `<CR>`을 누르기 전 다중 선택이 없으면,
`<CR>`이 강조된 항목을 선택에 추가하고 단일 키워드에 대한
`.gitignore` 파일을 생성합니다.

## 설정
`:Gitignore` 명령어가 현재 `.gitignore`에 덧붙이는 대신
덮어쓰기를 하도록 하려면 다음을 설정할 수 있습니다:


```lua
vim.g.gitignore_nvim_overwrite = true
```
이 변수가 `false`로 설정되었거나 전혀 설정되지 않은 경우, `:Gitignore`는  
기존 `.gitignore`를 고려합니다.  

또는, 명령어를 느낌표와 함께 호출할 수도 있습니다, 다음과 같이:
```
:Gitignore! [path]
```
이것은 단일 호출에 대해 `vim.g.gitignore_nvim_overwrite = true`를 설정하는 것과 동일한 효과를 가집니다.

### 사용자 지정 선택기

`telescope.nvim` 또는 기본 `vim.ui.select()` 대신,
다음 계약에 따라 자신의 솔루션을 구현할 수 있습니다:
1. `gitignore.nvim`은 템플릿 이름 목록과 두 가지 메서드 `generate` 및 `createGitignoreBuffer`를 제공합니다.
2. `generate` 메서드는 첫 번째 매개변수로 `.gitignore`의 대상 경로가 `opts.args`에 포함된 `opts` 테이블을 받습니다.
3. `createGitignoreBuffer`에는 `opts.args`와 선택된 템플릿 이름 목록을 전달해야 합니다.

다음은 fzf-lua를 사용한 예제 구현입니다:
```lua
local gitignore = require("gitignore")
local fzf = require("fzf-lua")

gitignore.generate = function(opts)
    local picker_opts = {
        -- the content of opts.args may also be displayed here for example.
        prompt = "Select templates for gitignore file> ",
        winopts = {
            width = 0.4,
            height = 0.3,
        },
        actions = {
            default = function(selected, _)
                -- as stated in point (3) of the contract above, opts.args and
                -- a list of selected templateNames are passed.
                gitignore.createGitignoreBuffer(opts.args, selected)
            end,
        },
    }
    fzf.fzf_exec(function(fzf_cb)
        for _, prefix in ipairs(gitignore.templateNames) do
            fzf_cb(prefix)
        end
        fzf_cb()
    end, picker_opts)
end
```
> __참고__
> 위의 방법은 `:Gitignore` 명령어를 덮어쓰지 않습니다.
> 그렇게 하려면, generate 함수를 정의한 후에 명령어를 다시 생성하세요.
> 다음과 같이:
```lua
vim.api.nvim_create_user_command("Gitignore", gitignore.generate, { nargs = "?", complete = "file" })
```

## 데모
[![asciicast](https://asciinema.org/a/GOHXDt4kYsR8pzrxTEOIridTf.svg)](https://asciinema.org/a/GOHXDt4kYsR8pzrxTEOIridTf)

## 크레딧
거대한 무시 템플릿 목록을 제공해 주신 [Toptal](https://github.com/toptal/gitignore) 에 감사드립니다!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---