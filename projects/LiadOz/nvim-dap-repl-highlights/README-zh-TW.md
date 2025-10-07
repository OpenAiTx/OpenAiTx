
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">簡體中文</a>
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
使用 treesitter 為 [nvim-dap](https://github.com/mfussenegger/nvim-dap) REPL 緩衝區添加語法高亮顯示。
| 前                                                                                                               | 後                                                                                                               |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## 需求
* Neovim 0.9 或更高版本
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## 設定
使用你最喜歡的方法安裝這個插件及其需求。安裝完成後，請確保你已配置好 treesitter 的[語法高亮](https://github.com/nvim-treesitter/nvim-treesitter#modules)，然後將以下內容新增到你的 lua 設定中。
```lua
require('nvim-dap-repl-highlights').setup()
```
在最初設定插件後，需要安裝 dap_repl 解析器，可以通過執行 `:TSInstall dap_repl` 手動完成。

或者通過 Treesitter 配置自動完成：

**使用 `ensure_installed`（nvim-treesitter 主分支）**
> ⚠️ **注意：** 必須在 Treesitter 之前呼叫 nvim-dap-repl-highlights.setup()，否則找不到 dap_repl 解析器。
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
**使用 `nvim-treesitter.install`（nvim-treesitter 主分支）**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ 如果這個方法停止運作或 API 有變動，請查閱官方 Treesitter 文件以獲取最新的安裝方法：
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## 使用方式
預設情況下，此插件會透過啟動 dap 時所使用的 **filetype** 來偵測 REPL 應使用的語言。顯然，若要為某些語言啟用語法高亮，您需要安裝該語言的 treesitter parser，以及 `dap_repl` 的 parser。
這可能無法符合所有使用情境。

您可以改用命令 `:lua require('nvim-dap-repl-highlights').setup_highlights('python')`，這會在目前的 repl 緩衝區設置 Python 高亮。
或者，也可以在未指定語言的情況下呼叫該函式，這會提示使用者輸入語言。

此外，您也可以在 **dap** 設定中指定 repl 要使用的語言，例如若想讓您的 Python repl 使用 JavaScript 高亮：
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
repl_lang 選項優先於檔案類型。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---