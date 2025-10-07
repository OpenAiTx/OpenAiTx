# nvim-dap-repl-highlights
使用 treesitter 为 [nvim-dap](https://github.com/mfussenegger/nvim-dap) REPL 缓冲区添加语法高亮。
| 之前                                                                                                            | 之后                                                                                                            |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png) |

## 要求
* Neovim 0.9 或更高版本
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## 设置
使用你喜欢的方法安装插件和依赖。安装完成后，确保你已配置 treesitter 的[高亮](https://github.com/nvim-treesitter/nvim-treesitter#modules)，然后将以下内容添加到你的 lua 配置中
```lua
require('nvim-dap-repl-highlights').setup()
```
在初次设置插件后，需要安装 dap_repl 解析器，这可以通过运行 `:TSInstall dap_repl` 手动完成。

或者通过 Treesitter 配置自动完成：

**使用 `ensure_installed`（nvim-treesitter 主分支）**
> ⚠️ **注意：** 你必须在调用 Treesitter 之前先调用 nvim-dap-repl-highlights.setup()，否则无法找到 dap_repl 解析器。
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
> ⚠️ 如果此功能停止工作或 API 发生变化，请查看官方 Treesitter 文档以获取最新的安装方法：
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## 使用方法
默认情况下，插件通过查看用于启动 dap 的 **文件类型** 来检测 REPL 中使用的语言。显然，为了让某些语言具有语法高亮，您需要为该语言安装对应的 treesitter 解析器，以及 `dap_repl` 解析器。
这可能不适用于所有用例。

您也可以使用命令 `:lua require('nvim-dap-repl-highlights').setup_highlights('python')`，这将在当前 repl 缓冲区设置 Python 高亮。
或者该函数也可以在不指定语言的情况下调用，这将提示用户输入语言。

另外，您还可以在 **dap** 配置中指定 repl 使用的语言，例如如果您想让 Python repl 使用 JavaScript 高亮：
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
repl_lang 选项优先于文件类型。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---