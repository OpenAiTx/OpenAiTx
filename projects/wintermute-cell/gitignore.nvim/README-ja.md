<!-- LTeX: language=en-US -->
# gitignore.nvim
![gitignore.nvim ロゴバナー](https://github.com/wintermute-cell/gitignore.nvim/blob/resources/_resources/banner.webp)

数多くの異なる技術から選択できることで、数秒で .gitignore ファイルを生成する
neovim プラグインです。

このプラグインは、[gitignore.io](https://www.toptal.com/developers/gitignore/)
が提供するサービスと機能的に同一ですが、オフラインで、かつ neovim 内部から
直接 `.gitignore` ファイルを生成可能です。

1. [インストール](#installation--dependencies)
2. [使い方](#usage)
3. [デモ](#demo)
4. [クレジット](#credits)

## インストールと依存関係
**`gitignore.nvim` はオプションで
[telescope.nvim](https://github.com/nvim-telescope/telescope.nvim) に依存しており、
[multi-selection](#selecting-multiple-items) を提供します。**
[telescope をインストール](https://github.com/nvim-telescope/telescope.nvim#installation)
しない場合、複数の技術を選択することはできません。

`telescope.nvim` をインストールした後、`gitignore.nvim` は以下のようにインストールできます。

[lazy.nvim](https://github.com/folke/lazy.nvim) を使用して
```lua
{"wintermute-cell/gitignore.nvim",
    config = function()
        require('gitignore')
    end,
}
```

[packer.nvim](https://github.com/wbthomason/packer.nvim) を使用する場合：
```lua
use({
     "wintermute-cell/gitignore.nvim",
     requires = {
        "nvim-telescope/telescope.nvim" -- optional: for multi-select
     }
})
```

## 使用法
このプラグインには1つのコマンドだけが搭載されており、実行すると、
`.gitignore`の内容を持つバッファを作成します：
```
:Gitignore [path]
```
既存の `.gitignore` が見つかった場合、生成された内容は既存の行に追記されます。バッファは自動的に保存されないため、既存の `.gitignore` を上書きするリスクはありません。

コマンドに `path` 引数を **任意で** 渡して、特定のディレクトリを指定することもできます（例えば、ネストされた `.gitignore` ファイルがある場合など）。

あるいは、対応する `lua` 関数を直接使用することも可能です。例えば、キーマップを作成する場合など：




```lua
local gitignore = require("gitignore")
vim.keymap.set("n", "<leader>gi", gitignore.generate)
```
またはパスを指定して:

```lua
local gitignore = require("gitignore")
local my_path = "./some/path"
vim.keymap.set("n", "<leader>gi",
    function ()
        gitignore.generate(my_path)
    end
)
```
### 複数アイテムの選択  
telescope がない場合、`gitignore.nvim` は `.gitignore` 用の複数の  
技術を選択できません。フォールバックのピッカーである `vim.ui.select()` は  
1つのアイテムしか選択できないためです。  
したがって、複数の技術を選択したい場合は、  
[telescope.nvim をインストールする](https://github.com/nvim-telescope/telescope.nvim#installation)  
必要があります（`packer.nvim` を使った例は  
[インストール](#installation--dependencies) セクションにあります）、または提供された  
`generate` メソッドを独自実装でオーバーライドしてください（[下記セクション参照](#custom-picker)）。  

`gitignore.nvim` は `telescope.nvim` のインストールを検知し、  
自動的にそれを使用するため、追加の設定は不要です。  

### telescope.nvim インストール時の複数アイテム選択  
`gitignore.nvim` は `telescope.nvim` のマルチセレクション用キーバインドを利用します。  
つまりデフォルトで `<Tab>` で複数のキーワードの選択・解除ができ、  
`<CR>`（Enter）で選択を確定できます。  
複数のキーワードが選択されている場合、`<CR>` を押したときにハイライトされているキーワードは  
**選択に追加されません**！  

利便性のため、複数選択せずに `<CR>` を押した場合は、  
ハイライト中のアイテムが選択に追加され、単一キーワードの `.gitignore` ファイルが作成されます。  

## 設定  
`:Gitignore` コマンドで現在の `.gitignore` に追記するのではなく、  
上書きしたい場合は以下を設定してください：




```lua
vim.g.gitignore_nvim_overwrite = true
```
この変数が`false`に設定されているか、まったく設定されていない場合、`:Gitignore`は既存の`.gitignore`を考慮します。

あるいは、次のようにビックリマーク付きでコマンドを呼び出すこともできます。

```
:Gitignore! [path]
```
これは、単一の呼び出しに対して `vim.g.gitignore_nvim_overwrite = true` を設定するのと同じ効果があります。

### カスタムピッカー

`telescope.nvim` やネイティブの `vim.ui.select()` の代わりに、
以下の契約に従って独自のソリューションを実装できます：
1. `gitignore.nvim` はテンプレート名のリストと2つのメソッド `generate` と `createGitignoreBuffer` を提供します。
2. `generate` メソッドの最初のパラメータとして、`.gitignore` の対象パスを含む `opts` テーブルが `opts.args` に渡されます。
3. `opts.args` と選択されたテンプレート名のリストを `createGitignoreBuffer` に渡す必要があります。

以下は fzf-lua を使った実装例です：
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
> __注意__
> 上記は `:Gitignore` コマンドを上書きしないことに注意してください。
> それを行うには、生成関数を定義した後にコマンドを以下のように再作成します:
> 次のように:
```lua
vim.api.nvim_create_user_command("Gitignore", gitignore.generate, { nargs = "?", complete = "file" })
```

## デモ
[![asciicast](https://asciinema.org/a/GOHXDt4kYsR8pzrxTEOIridTf.svg)](https://asciinema.org/a/GOHXDt4kYsR8pzrxTEOIridTf)

## クレジット
大量の無視テンプレートリストを提供してくれた[Toptal](https://github.com/toptal/gitignore)に感謝します！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---