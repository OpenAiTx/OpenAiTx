# YankBank

Neovim 플러그인으로 최근에 복사한 내용과 삭제한 내용을 추적하고 빠른 액세스 메뉴에 표시합니다.

## 기능

YankBank는 최근 N개의 복사 내용을 이름 없는 레지스터(")에 저장한 다음, 팝업 창에 이 최근 복사 내용을 표시하여 최근 복사 기록에 빠르게 접근할 수 있게 합니다.
팝업 메뉴를 열면, 이름 없는 플러스 레지스터(+)의 현재 내용도 메뉴에 추가됩니다(이 내용이 이름 없는 레지스터의 현재 내용과 다를 경우).

메뉴에서 항목을 선택(엔터 키를 눌러)하면 현재 열린 버퍼의 커서 위치에 붙여넣기 됩니다.

YankBank는 세션 간 지속성을 제공하여 세션을 닫았다가 다시 열어도 복사 내용이 사라지지 않습니다 ([persistence](#Persistence) 참고).

### 스크린샷

![YankBank popup window zoomed](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/assets/screenshot-2.png)

이 메뉴는 현재 세션에 한정되며, 완전히 새로운 세션에서 열 때는 현재 이름 없는 플러스 레지스터의 내용만 포함됩니다.
세션 내에서 복사나 삭제가 발생할 때마다 메뉴가 추가로 채워집니다.

## 설치 및 설정

#### 지속성 포함 (권장)

lazy.nvim 사용
```lua
{
    "ptdewey/yankbank-nvim",
    dependencies = "kkharji/sqlite.lua",
    cmd = { "YankBank" },
    config = function()
        require('yankbank').setup({
            persist_type = "sqlite",
        })
    end,
}
```

#### 지속성 없이:

lazy.nvim 사용하기
```lua
{
    "ptdewey/yankbank-nvim",
    cmd = { "YankBank" },
    config = function()
        require('yankbank').setup()
    end,
}
```
#### 지연 로딩

[모범 사례](https://github.com/nvim-neorocks/nvim-best-practices?tab=readme-ov-file#sleeping_bed-lazy-loading)에 따르면, YankBank의 초기화 발자국은 매우 작으며 기능은 필요할 때만 로드됩니다. 따라서 제 설정에서는 `lazy=false`로 설정하여 시작 시간을 1ms 미만으로 유지합니다.


```lua
-- plugins/yankbank.lua
return {
    {
        "ptdewey/yankbank-nvim",
        lazy = false,
        config = function()
            -- ...
        end,
    },
    {
        "kkharji/sqlite.lua",
        lazy = true,
    },
}
```
시작 시 YankBank를 로드하고 싶지 않다면, 이전에는 텍스트를 복사하는 키 입력(`y`, `Y`, `d`, `D`, `x`), `FocusGained` 이벤트, 그리고 `YankBank` 명령어에서 로드하도록 설정했습니다.

```lua
{
    "ptdewey/yankbank-nvim",
    dependencies = "kkharji/sqlite.lua",
    keys = {
        { "y" },
        { "Y", "y$" }, -- redefine Y behavior to y$ to avoid breaking lazy
        { "D" },
        { "d" },
        { "x" },
        { "<leader>p", desc = "Open YankBank" },
    },
    cmd = { "YankBank" },
    event = { "FocusGained" },
    config = function()
        require("yankbank").setup({
            -- ...
        })
    end
}
```


### 설정 옵션

설정 함수는 옵션 테이블을 인수로 받을 수도 있습니다:
| 옵션 | 유형 | 기본값 |
|-------------|--------------------------------------------|----------------|
| max_entries | 팝업에 표시할 항목 수 정수 | `10` |
| sep | 테이블 항목 사이에 표시할 구분 문자열 | `"-----"` |
| keymaps | 키맵 재정의를 포함하는 테이블 | `{}` |
| keymaps.navigation_next | 문자열 | `"j"` |
| keymaps.navigation_prev | 문자열 | `"k"` |
| keymaps.paste | 문자열 | `"<CR>"` |
| keymaps.paste_back | 문자열 | `"P"` |
| keymaps.yank | 문자열 | `"yy"` |
| keymaps.close | 문자열 테이블 | `{ "<Esc>", "<C-c>", "q" }` |
| num_behavior | 점프 동작 정의 문자열 "prefix" 또는 "jump" | `"prefix"` |
| focus_gain_poll | 불리언 | `false` |
| registers | 레지스터 재정의를 위한 테이블 컨테이너 | `{ }` |
| registers.yank_register | 팝업에서 복사할 기본 레지스터 | `"+"` |
| persist_type | 지속성 유형 정의 문자열 "sqlite" 또는 nil | `nil` |
| db_path | sqlite 지속성 사용 시 데이터베이스 파일 경로 문자열 | 플러그인 설치 디렉터리 |
| bind_indices | 인덱스 번호로 붙여넣기할 때 키바인드 접두사로 사용할 선택적 문자열 (예: "<leader>p") | `nil` |


#### 예제 구성

```lua
{
    "ptdewey/yankbank-nvim",
    config = function()
        require('yankbank').setup({
            max_entries = 9,
            sep = "-----",
            num_behavior = "jump",
            focus_gain_poll = true,
            persist_type = "sqlite",
            keymaps = {
                paste = "<CR>",
                paste_back = "P",
            },
            registers = {
                yank_register = "+",
            },
            bind_indices = "<leader>p"
        })
    end,
}
```
구분자가 필요하지 않은 경우 `sep`에 빈 문자열을 전달하세요.

'num_behavior' 옵션은 숫자 키를 눌렀을 때 팝업 내 탐색 동작을 정의합니다.
- `num_behavior = "prefix"`는 전통적인 vim 탐색과 유사하게 작동하며 '3j'는 뱅크 내에서 3개의 항목을 아래로 이동합니다.
- `num_behavior = "jump"`는 눌린 숫자 키에 해당하는 항목으로 점프합니다(예: '3'은 3번 항목으로 점프).
    - 참고: 'max_entries'가 두 자리 숫자인 경우, 유효한 항목의 접두사인 숫자를 누를 때 지연이 발생할 수 있습니다.

'focus_gain_poll' 옵션은 추가 자동 명령을 활성화하여 포커스 획득(Neovim 창 재포커싱)을 감지하고, unnamedplus('+') 레지스터의 변경 사항을 확인하여 새로운 내용이 발견되면 yankbank에 추가합니다. 이를 통해 뱅크 열기 트리거 없이도 브라우저 등 다른 소스에서 복사한 텍스트를 자동으로 yankbank에 추가할 수 있습니다. 기본적으로 비활성화되어 있지만 `focus_gain_poll = true`로 활성화하는 것을 강력히 권장합니다.

### 지속성
YankBank를 최상의 경험으로 사용하려면 지속성 활성화를 강력히 권장합니다.
지속성이 활성화되면 sqlite.lua가 플러그인 루트 디렉토리에 최근 yank을 위한 영구 저장소를 생성하는 데 사용됩니다.
sqlite 지속성을 사용하려면 설정에 `"kkharji/sqlite.lua"`를 의존성으로 추가해야 하며, `persist_type`을 `"sqlite"`로 설정해야 합니다:


```lua
-- lazy
return {
    "ptdewey/yankbank-nvim",
    dependencies = "kkharji/sqlite.lua",
    config = function()
        require('yankbank').setup({
            -- other options...
            persist_type = "sqlite"
        })
    end,
}
```
참고: 데이터베이스는 `:YankBankClearDB` 명령어를 사용하거나 db 파일을 삭제하여 지울 수 있습니다(기본적으로 플러그인 설치 디렉토리에 위치).

SQL 관련 문제가 발생하면 GitHub에 이슈를 등록해 주세요. (임시 해결책으로 데이터베이스를 지우는 것도 시도할 수 있습니다)


db 파일 생성 시 권한 문제가 발생하면(예: Nix 사용 시) `db_path` 옵션을 사용하여 기본 파일 경로를 변경하세요. (`vim.fn.stdpath("data")`가 작동할 것입니다)

## 사용법

팝업 메뉴는 `:YankBank` 명령어로 열 수 있으며, 엔트리는 현재 커서 위치에 Enter 키로 붙여넣기 할 수 있고, 메뉴는 Escape, Ctrl-C, 또는 q 키로 닫을 수 있습니다.
메뉴에서 선택한 항목은 yy 키를 눌러 unnamedplus 레지스터에 복사할 수도 있습니다.

개인적으로 메뉴를 열기 위한 키바인드를 설정하는 것을 권장합니다.

```lua
-- map to '<leader>y'
vim.keymap.set("n", "<leader>y", "<cmd>YankBank<CR>", { noremap = true })
```

---

## API (작업 중)

일부 플러그인 내부 기능은 YankBank API를 통해서도 접근할 수 있습니다.

예시:
```lua
-- get the ith entry in the bank
---@param i integer index to get
-- output format: { yank_text = "entry", reg_type = "v" }
local e = require("yankbank.api").get_entry(i)

-- add an entry to the bank
---@param yank_text string yank text to add to YANKS table
---@param reg_type string register type "v", "V", or "^V" (visual, v-line, v-block respectively)
require("yankbank.api").add_entry("yank_text", "reg_type")

-- remove an entry from the bank by index
---@param i integer index to remove
require("yankbank.api").remove_entry(i)

--- pin entry to yankbank so that it won't be removed when its position exceeds the max number of entries
---@param i integer index to pin
require("yankbank.api").pin_entry(i)


--- unpin bank entry
---@param i integer index to unpin
require("yankbank.api").unpin_entry(i)
```

API에 대한 자세한 내용은 [lua/yankbank/api.lua](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/lua/yankbank/api.lua)에서 확인하십시오.

---

## 잠재적 개선 사항
- nvim-cmp 통합
- fzf 통합
- telescope 통합

## 대안

- [nvim-neoclip](https://github.com/AckslD/nvim-neoclip.lua)
- [yanky.nvim](https://github.com/gbprod/yanky.nvim)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---