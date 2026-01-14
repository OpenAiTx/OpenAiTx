# brainrot.nvim

新しいエラーが発生したときにヴァインブーム。最後のエラーをクリアすると、フォンク＋暗いオーバーレイ＋ミーム画像が表示されます。


https://github.com/user-attachments/assets/e68578ee-69e5-4fc6-b45a-493a98e8d225


## 要件
- Neovim 0.9+
- オーディオプレーヤー
  - Linux: `paplay`、`ffplay`、または `mpv`
  - macOS/Windows: `ffplay`、または `mpv`
- [image.nvim](https://github.com/3rd/image.nvim)（オプション、画像用）

## インストール (lazy.nvim)
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
## 何をするか
- 新しいエラーが検出されると：Vine Boomを一度再生します。
- 「エラーあり」から「エラーなし」になった場合：ランダムなphonkトラックを再生し、ランダムなPNGを表示し、`phonk_time`秒間の薄暗い全画面オーバーレイ（オプションで入力をブロック）を表示します。
- 通常モードでのみトリガーされます（入力中は発火しません）。`DiagnosticChanged`および通常モードへの/からのモード変更時に更新されます。

### lsp_wideモード
`lsp_wide = true`の場合、現在のバッファだけでなくワークスペース内のすべてのエラーを追跡します（lspが対応していれば）
- phonkはワークスペース内の**すべて**のエラーがクリアされたときのみ再生され、現在のファイルだけではありません。
- 新しいエラーがワークスペースのどこかに現れたときにVine boomが再生されます。

## コマンド
- `:Brainrot boom`: 今すぐvine boomサウンドを再生
- `:Brainrot boom toggle`: boomサウンドのオン/オフを切り替え
- `:Brainrot boom enable`: boomサウンドを有効化
- `:Brainrot boom disable`: boomサウンドを無効化
- `:Brainrot phonk`: 今すぐオーバーレイ＋ランダムphonkを再生
- `:Brainrot phonk toggle`: 自動phonkのオン/オフを切り替え
- `:Brainrot phonk enable`: 自動phonkを有効化
- `:Brainrot phonk disable`: 自動phonkを無効化

## APIの使い方
brainrotの関数を直接設定や他のプラグイン内で使用できます。モジュールを取得して以下のいずれかを呼び出してください：


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
### 例：ファイル保存時のPhonk

```lua
-- inside init.lua
vim.api.nvim_create_autocmd('BufWritePost', {
  callback = function()
    require('brainrot').phonk()
  end,
})
```

## 既知の問題
- `{|}` のような括弧のペア内で `<CR>`（Enter）を押して自動展開（autopairプラグイン使用時）すると、エラーを検出してビーンブーム音が鳴ります。回避策は自動展開を無効にすることです（例：`nvim-autopairs` の `map_cr = false`）。

## ...なぜ？
[だってそうでしょ](https://x.com/sahaj__b/status/1981749009350811966)

## ライセンス
MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---