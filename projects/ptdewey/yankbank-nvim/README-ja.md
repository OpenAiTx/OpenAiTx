# YankBank

Neovimのプラグインで、最近のヤンクや削除を記録し、クイックアクセスメニューで表示します。

## 何をするか

YankBankは最近のN回のヤンクを無名レジスタ（"）に保存し、これらの最近のヤンクをポップアップウィンドウに表示して、ヤンク履歴に素早くアクセスできるようにします。  
ポップアップメニューを開くと、現在の無名プラスレジスタ（+）の内容も（無名レジスタの現在の内容と異なる場合に限り）メニューに追加されます。

メニューからエントリを選択（Enterキーを押す）すると、カーソル位置の現在開いているバッファに貼り付けられます。

YankBankはセッション間の永続性も提供しており、セッションを閉じて再開してもヤンクを失うことはありません（[永続性](#Persistence)を参照）。

### スクリーンショット

![YankBank popup window zoomed](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/assets/screenshot-2.png)

メニューは現在のセッションに特有であり、まったく新しいセッションで開くときは、現在の無名プラスレジスタの内容のみが含まれます。  
そのセッションでヤンクまたは削除が行われるごとに、さらにメニューが追加されます。

## インストールと設定

#### 永続性あり（推奨）

lazy.nvimを使用して
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

#### 永続化なし:

lazy.nvimを使用する
```lua
{
    "ptdewey/yankbank-nvim",
    cmd = { "YankBank" },
    config = function()
        require('yankbank').setup()
    end,
}
```
#### レイジーロード

[ベストプラクティス](https://github.com/nvim-neorocks/nvim-best-practices?tab=readme-ov-file#sleeping_bed-lazy-loading)によると、YankBankの初期化フットプリントは非常に小さく、機能は必要なときにのみ読み込まれます。したがって、私は設定で`lazy=false`を設定し、起動時間を1ms未満にしています。


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

起動時にYankBankを読み込みたくない場合、以前はテキストをヤンクするキー押下時（`y`、`Y`、`d`、`D`、`x`）、`FocusGained`イベント、および`YankBank`コマンドで読み込んでいました。
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


### セットアップオプション

setup関数はオプションのテーブルを受け取ることもサポートしています：
| オプション | 型 | デフォルト |
|-------------|--------------------------------------------|----------------|
| max_entries | ポップアップに表示するエントリの最大数（整数） | `10` |
| sep | テーブルエントリ間に表示する区切り文字列 | `"-----"` |
| keymaps | キーマップのオーバーライドを含むテーブル | `{}` |
| keymaps.navigation_next | 文字列 | `"j"` |
| keymaps.navigation_prev | 文字列 | `"k"` |
| keymaps.paste | 文字列 | `"<CR>"` |
| keymaps.paste_back | 文字列 | `"P"` |
| keymaps.yank | 文字列 | `"yy"` |
| keymaps.close | 文字列のテーブル | `{ "<Esc>", "<C-c>", "q" }` |
| num_behavior | ジャンプ動作を定義する文字列 "prefix" または "jump" | `"prefix"` |
| focus_gain_poll | ブール値 | `false` |
| registers | レジスタのオーバーライド用テーブル | `{ }` |
| registers.yank_register | ポップアップからヤンクするデフォルトのレジスタ | `"+"` |
| persist_type | 永続化タイプを定義する文字列 "sqlite" または nil | `nil` |
| db_path | sqlite永続化で使用するデータベースファイルのパス文字列 | プラグインインストールディレクトリ |
| bind_indices | インデックス番号によるペースト用のキーバインドプレフィックスとして使用するオプションの文字列（例："<leader>p"） | `nil` |


#### 設定例

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

区切り文字を使用しない場合は、`sep` に空文字列を渡してください

'num_behavior' オプションは、数字キーを押したときのポップアップ内のナビゲーション動作を定義します。
- `num_behavior = "prefix"` は、従来のvimナビゲーションと同様に動作し、'3j' はバンク内の3つ下のエントリに移動します。
- `num_behavior = "jump"` は、押された数字キーに一致するエントリにジャンプします（例：'3' はエントリ3にジャンプ）
    - 注意：'max_entries' が2桁の数字の場合、有効なエントリのプレフィックスとなる数字を押すと遅延が発生します。

'focus_gain_poll' オプションは、フォーカス獲得（Neovimウィンドウの再フォーカス）を監視する追加のautocommandを有効にし、unnamedplus ('+') レジスタの変化をチェックして、新しい内容が見つかるとyankbankに追加します。これにより、ブラウザなど他のソースからコピーしたテキストをバンクの起動トリガーなしに自動的にyankbankに追加できます。デフォルトはオフですが、`focus_gain_poll = true` での有効化を強く推奨します。

### 永続化
YankBankを最高の体験で利用するために、永続化の有効化を強く推奨します。
永続化が有効な場合、sqlite.lua がプラグインのルートディレクトリに最近のヤンクの永続ストアを作成するために使用されます。
sqlite永続化を利用するには、設定に `"kkharji/sqlite.lua"` を依存関係として追加し、`persist_type` を `"sqlite"` に設定する必要があります。

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

注意：データベースは `:YankBankClearDB` コマンドでクリアするか、（デフォルトではプラグインのインストールディレクトリにある）dbファイルを削除することでクリアできます。

SQLに関連する問題が発生した場合は、GitHubで問題を報告してください。（一時的な対処として、データベースをクリアすることも試せます）


dbファイルの作成時に権限の問題が発生した場合（例：Nixでインストールした場合）は、`db_path` オプションを使ってデフォルトのファイルパスを変更してください。（`vim.fn.stdpath("data")` が有効です）

## 使い方

ポップアップメニューはコマンド `:YankBank` で開くことができ、エントリはEnterキーで現在のカーソル位置に貼り付けられ、メニューはEsc、Ctrl-C、またはqキーで閉じられます。
メニューのエントリはyyキーでunnamedplusレジスタにヤンクすることもできます。

個人的には、メニューを開くためのキー割り当ても設定することをお勧めします。
```lua
-- map to '<leader>y'
vim.keymap.set("n", "<leader>y", "<cmd>YankBank<CR>", { noremap = true })
```

---

## API（作業中）

いくつかのプラグイン内部もYankBank APIを通じてアクセス可能です。

例：
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

APIの詳細については[ lua/yankbank/api.lua](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/lua/yankbank/api.lua)を参照してください。

---

## 改善の可能性
- nvim-cmpとの統合
- fzfとの統合
- telescopeとの統合

## 代替案

- [nvim-neoclip](https://github.com/AckslD/nvim-neoclip.lua)
- [yanky.nvim](https://github.com/gbprod/yanky.nvim)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---