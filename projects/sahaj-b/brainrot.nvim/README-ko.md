# brainrot.nvim

새로운 오류가 나타날 때 Vine 붐. 마지막 오류를 지우면 Phonk + 어두운 오버레이 + 밈 이미지.

https://github.com/user-attachments/assets/e68578ee-69e5-4fc6-b45a-493a98e8d225

## 요구사항
- Neovim 0.9+
- 오디오 플레이어
  - 리눅스: `paplay`, `ffplay`, 또는 `mpv`
  - macOS/윈도우: `ffplay`, 또는 `mpv`
- [image.nvim](https://github.com/3rd/image.nvim) (선택 사항, 이미지용)

## 설치 (lazy.nvim)


```lua
{
  'sahaj-b/brainrot.nvim',
  event = 'VeryLazy',
  opts = {
    -- defaults:

    disable_phonk = false,    -- skip phonk/overlay on "no errors"
    phonk_time = 2.5,         -- seconds the phonk/image overlay stays
    min_error_duration = 0.5, -- minimum seconds errors must exist before phonk triggers (0 = instant)
    block_input = true,       -- block input during phonk/overlay
    dim_level = 60,           -- phonk overlay darkness 0..100

    sound_enabled = true,     -- enable sounds
    image_enabled = true,     -- enable images (needs image.nvim)

    boom_volume = 50,         -- volume for vine boom sound (0..100)
    phonk_volume = 50,        -- volume for phonk sound (0..100)

    boom_sound = nil,         -- custom boom sound path (e.g., "~/sounds/boom.ogg")
    phonk_dir = nil,          -- custom phonk folder path (e.g., "~/sounds/phonks")
    image_dir = nil,          -- custom image folder path (e.g., "~/memes/images")

    lsp_wide = false,         -- track errors workspace-wide(get ALL lsp errors)

  },
}
```

## 기능 설명
- 새로운 오류가 감지되면: Vine Boom을 한 번 재생합니다.
- "오류 있음"에서 "오류 없음"으로 변경되면: 무작위 phonk 트랙을 재생하고 무작위 PNG를 표시하며, `phonk_time` 초 동안 희미한 전체 화면 오버레이를 표시합니다 (선택적으로 입력 차단).
- 정상 모드에서만 작동합니다 (입력 중에는 실행되지 않음). `DiagnosticChanged` 이벤트와 정상 모드 진입/이탈 시 업데이트합니다.

### lsp_wide 모드
`lsp_wide = true`일 때, 현재 버퍼뿐 아니라 작업 공간 내 모든 오류를 추적합니다 (LSP가 지원하는 경우).
- phonk는 작업 공간 내 **모든** 오류가 해결되었을 때만 재생됩니다, 현재 파일만이 아닙니다.
- Vine boom은 작업 공간 어디에서든 새로운 오류가 나타날 때 재생됩니다.

## 명령어
- `:Brainrot boom`: 즉시 vine boom 사운드를 재생합니다.
- `:Brainrot boom toggle`: boom 사운드 켜기/끄기 토글합니다.
- `:Brainrot boom enable`: boom 사운드를 활성화합니다.
- `:Brainrot boom disable`: boom 사운드를 비활성화합니다.
- `:Brainrot phonk`: 즉시 오버레이와 무작위 phonk를 재생합니다.
- `:Brainrot phonk toggle`: 자동 phonk 켜기/끄기 토글합니다.
- `:Brainrot phonk enable`: 자동 phonk를 활성화합니다.
- `:Brainrot phonk disable`: 자동 phonk를 비활성화합니다.

## API 사용법
brainrot의 기능을 설정 파일이나 다른 플러그인에서 직접 사용할 수 있습니다. 모듈을 가져와서 다음 함수 중 하나를 호출하세요:

```lua
local brainrot = require('brainrot')

-- Trigger the phonk overlay + random phonk sound
brainrot.phonk()

-- Trigger vine boom sound
brainrot.boom()

-- Toggle/enable/disable boom sounds
brainrot.toggle_boom()
brainrot.enable_boom()
brainrot.disable_boom()

-- Toggle/enable/disable auto-phonk
brainrot.toggle_phonk()
brainrot.enable_phonk()
brainrot.disable_phonk()
```

### 예시: 파일 저장 시 Phonk 실행
```lua
-- inside init.lua
vim.api.nvim_create_autocmd('BufWritePost', {
  callback = function()
    require('brainrot').phonk()
  end,
})
```
## 알려진 문제점
- `{|}`와 같은 괄호 쌍 안에서 `<CR>`(엔터)를 눌러 블록으로 자동 확장(autopair 플러그인 사용 시)할 때 오류가 감지되어 vine boom 소리가 납니다. 해결 방법은 자동 확장 기능을 비활성화하는 것입니다(예: `nvim-autopairs`에서 `map_cr = false`).

## ...왜?
[그냥 왜냐하면](https://x.com/sahaj__b/status/1981749009350811966)

## 라이선스
MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---