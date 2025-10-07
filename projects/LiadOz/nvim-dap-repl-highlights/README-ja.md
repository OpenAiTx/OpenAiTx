# nvim-dap-repl-highlights
treesitterを使用して、[nvim-dap](https://github.com/mfussenegger/nvim-dap)のREPLバッファに構文ハイライトを追加します。
| Before                                                                                                          | After                                                                                                          |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Requirements
* Neovim 0.9以降
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Setup
お好みの方法でプラグインと要件をインストールします。インストール後、treesitterの[ハイライト](https://github.com/nvim-treesitter/nvim-treesitter#modules)を設定し、次の内容をlua設定に追加してください。
```lua
require('nvim-dap-repl-highlights').setup()
```
プラグインの初期設定後、dap_repl パーサーをインストールする必要があります。これは `:TSInstall dap_repl` を実行して手動で行うことができます。

または、Treesitter の設定を通じて自動的に行うことも可能です。

**`ensure_installed` を使用する場合（nvim-treesitter マスターブランチ）**
> ⚠️ **注意:** Treesitter の前に必ず nvim-dap-repl-highlights.setup() を呼び出してください。そうしないと dap_repl パーサーが見つかりません。
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter.configs').setup {
  highlight = {
    enable = true,
  },
  ensure_installed = { 'dap_repl', ... },
  ...
}
```
**`nvim-treesitter.install` の使用（nvim-treesitter メインブランチ）**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ もしこれが動かなくなったりAPIが変更された場合は、最新のインストール方法について公式Treesitterドキュメントを確認してください：
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## 使用方法
デフォルトでは、プラグインはdapを起動する際に使用される**filetype**を見てREPLで使う言語を検出します。特定の言語の構文ハイライトを有効にするには、その言語のtreesitterパーサーと`dap_repl`パーサーが必要です。
これはすべてのユースケースに合うとは限りません。

代わりに、コマンド`:lua require('nvim-dap-repl-highlights').setup_highlights('python')`を使うと、現在のreplバッファでpythonのハイライトを設定できます。
また、言語を指定せずに関数を呼び出すと、ユーザーに言語の入力を促します。

さらに、**dap**の設定で使用するrepl言語を指定することも可能です。例えば、pythonのreplにjavascriptのハイライトを適用したい場合：
```lua
local dap = require('dap')
dap.configurations.python = {
  {
    name = "Python with javascript repl because I like to watch the world burn 🔥🔥🔥",
    type = "python",
    request = "launch",
    program = "${file}",
    repl_lang = "javascript"
  },
}
```
repl_lang オプションは filetype よりも優先されます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---