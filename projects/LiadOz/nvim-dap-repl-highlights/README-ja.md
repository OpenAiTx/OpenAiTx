
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# nvim-dap-repl-highlights
[nvim-dap](https://github.com/mfussenegger/nvim-dap) の REPL バッファに treesitter を使用して構文ハイライトを追加します。
| Before                                                                                                          | After                                                                                                          |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## 必要条件
* Neovim 0.9 以降
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## セットアップ
お気に入りの方法でプラグインと必要な要件をインストールしてください。インストール後、treesitterの[ハイライト](https://github.com/nvim-treesitter/nvim-treesitter#modules)を設定し、以下をlua設定に追加してください。
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