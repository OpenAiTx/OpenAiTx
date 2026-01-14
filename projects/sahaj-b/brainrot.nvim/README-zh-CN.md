# brainrot.nvim

当出现新错误时播放藤蔓爆炸音效。清除最后一个错误时播放Phonk音乐 + 暗色遮罩 + 搞笑图片。


https://github.com/user-attachments/assets/e68578ee-69e5-4fc6-b45a-493a98e8d225


## 要求
- Neovim 0.9+
- 音频播放器
  - Linux: `paplay`，`ffplay`，或 `mpv`
  - macOS/Windows: `ffplay`，或 `mpv`
- [image.nvim](https://github.com/3rd/image.nvim)（可选，用于显示图片）

## 安装 (lazy.nvim)
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
## 它的功能
- 检测到新错误：播放 Vine Boom 一次。
- 从“有错误”变为“无错误”：播放随机 phonk 曲目并显示随机 PNG，带有全屏暗色覆盖（可选阻止输入），持续 `phonk_time` 秒。
- 仅在普通模式下触发（输入时不会触发）。它在 `DiagnosticChanged` 事件和普通模式切换时更新。

### lsp_wide 模式
当 `lsp_wide = true` 时，它跟踪工作区中的所有错误，而不仅仅是当前缓冲区（如果你的 lsp 支持）。
- 只有当工作区中的**所有**错误被清除时才播放 Phonk，而不仅仅是当前文件。
- 当工作区中任何地方出现新错误时播放 Vine Boom。

## 命令
- `:Brainrot boom`：立即触发 vine boom 声音
- `:Brainrot boom toggle`：切换 boom 声音开/关
- `:Brainrot boom enable`：启用 boom 声音
- `:Brainrot boom disable`：禁用 boom 声音
- `:Brainrot phonk`：立即触发覆盖层 + 随机 phonk
- `:Brainrot phonk toggle`：切换自动 phonk 开/关
- `:Brainrot phonk enable`：启用自动 phonk
- `:Brainrot phonk disable`：禁用自动 phonk

## API 使用
你可以在配置或其他插件中直接使用 brainrot 的函数。获取模块并调用以下任意函数：


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

### 示例：保存文件时播放Phonk
```lua
-- inside init.lua
vim.api.nvim_create_autocmd('BufWritePost', {
  callback = function()
    require('brainrot').phonk()
  end,
})
```

## 已知问题
- 当在括号对内按下 `<CR>`（回车）以自动展开为代码块（使用自动配对插件时），会检测到错误并播放爆炸声。解决方法是禁用自动展开（例如：在 `nvim-autopairs` 中设置 `map_cr = false`）。

## ...为什么？
[因为为什么不呢](https://x.com/sahaj__b/status/1981749009350811966)

## 许可协议
MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---