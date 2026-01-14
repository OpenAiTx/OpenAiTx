# brainrot.nvim

Vine boom when a new error appears. Phonk + dim overlay + meme image when you clear the last error.


https://github.com/user-attachments/assets/e68578ee-69e5-4fc6-b45a-493a98e8d225


## Requirements
- Neovim 0.9+
- Audio player
  - Linux: `paplay`, `ffplay`, or `mpv`
  - macOS/Windows: `ffplay`, or `mpv`
- [image.nvim](https://github.com/3rd/image.nvim) (Optional, for images)

## Install (lazy.nvim)
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

## What it does
- New error detected: plays Vine Boom once.
- Went from "had errors" to "no errors": plays a random phonk track and shows a random PNG, with a dim fullscreen overlay (optionally blocking inputs) for `phonk_time` seconds.
- Only triggers in Normal mode (won't fire while you're typing). It updates on `DiagnosticChanged` and on mode changes into/out of Normal.

### lsp_wide mode
When `lsp_wide = true`, it tracks ALL errors in the workspace, not just the current buffer (if your lsp supports it)
- Phonk only plays when **ALL** errors in the workspace are cleared, not just the current file.
- Vine boom plays when a new error appears anywhere in the workspace.

## Commands
- `:Brainrot boom`: trigger the vine boom sound now
- `:Brainrot boom toggle`: toggle boom sounds on/off
- `:Brainrot boom enable`: enable boom sounds
- `:Brainrot boom disable`: disable boom sounds
- `:Brainrot phonk`: trigger the overlay + random phonk now
- `:Brainrot phonk toggle`: toggle auto-phonk on/off
- `:Brainrot phonk enable`: enable auto-phonk
- `:Brainrot phonk disable`: disable auto-phonk

## API Usage
You can use brainrot's functions directly in your config or other plugins. Get the module and call any of these:

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

### Example: Phonk on file save
```lua
-- inside init.lua
vim.api.nvim_create_autocmd('BufWritePost', {
  callback = function()
    require('brainrot').phonk()
  end,
})
```

## Known Issues
- When pressing `<CR>` (Enter) inside a bracket pair like `{|}` to auto-expand into a block (when using an autopair plugin), it will detect errors and play vine boom. Workaround is to disable the auto-expand (eg: `map_cr = false` in `nvim-autopairs`).

## ...WHY?
[coz why not](https://x.com/sahaj__b/status/1981749009350811966)

## License
MIT
