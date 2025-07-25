<!-- LTeX: language=en-US -->
# gitignore.nvim
![gitignore.nvim 标志横幅](https://github.com/wintermute-cell/gitignore.nvim/blob/resources/_resources/banner.webp)

一个用于快速生成 .gitignore 文件的 neovim 插件，允许你
从大量不同的技术中进行选择。

该插件在功能上与
[gitignore.io](https://www.toptal.com/developers/gitignore/) 提供的服务
完全相同，但能够离线生成 `.gitignore` 文件，并且直接在 neovim 中完成。

1. [安装](#installation--dependencies)
2. [使用](#usage)
3. [演示](#demo)
4. [致谢](#credits)

## 安装与依赖
**`gitignore.nvim` 可选依赖于
[telescope.nvim](https://github.com/nvim-telescope/telescope.nvim) 来提供
[多选功能](#selecting-multiple-items)。如果不[安装
telescope](https://github.com/nvim-telescope/telescope.nvim#installation)，
你将无法选择多个技术。**

安装 `telescope.nvim` 后，可以这样安装 `gitignore.nvim`：

使用 [lazy.nvim](https://github.com/folke/lazy.nvim)
```lua
{"wintermute-cell/gitignore.nvim",
    config = function()
        require('gitignore')
    end,
}
```

使用 [packer.nvim](https://github.com/wbthomason/packer.nvim)：
```lua
use({
     "wintermute-cell/gitignore.nvim",
     requires = {
        "nvim-telescope/telescope.nvim" -- optional: for multi-select
     }
})
```

## 用法
该插件只包含一个命令，运行时，
它将创建一个包含 `.gitignore` 内容的缓冲区：
```
:Gitignore [path]
```
如果找到现有的 `.gitignore`，生成的内容将附加到现有行的末尾。缓冲区不会自动保存，因此不会有覆盖现有 `.gitignore` 的风险。

您可以**可选地**传递一个 `path` 参数来指向特定目录（例如，如果您有嵌套的 `.gitignore` 文件）。

或者，您可以直接使用相应的 `lua` 函数，例如用于创建键映射：




```lua
local gitignore = require("gitignore")
vim.keymap.set("n", "<leader>gi", gitignore.generate)
```
或者带路径的：

```lua
local gitignore = require("gitignore")
local my_path = "./some/path"
vim.keymap.set("n", "<leader>gi",
    function ()
        gitignore.generate(my_path)
    end
)
```
### 选择多个项目
没有 telescope，`gitignore.nvim` 不允许你为你的 `.gitignore` 选择多个
技术，因为回退选择器 `vim.ui.select()` 只能选择一个项目。
因此，如果你想能够选择多个技术，你必须
要么[安装
telescope.nvim](https://github.com/nvim-telescope/telescope.nvim#installation)
（你可以在
[安装](#installation--dependencies) 部分找到使用 `packer.nvim` 的示例），
要么用你自己的实现覆盖提供的
`generate` 方法（[参见下面的部分](#custom-picker)）。

`gitignore.nvim` 会检测是否安装了 `telescope.nvim` 并自动使用，
无需进一步配置。

### 安装 telescope.nvim 后选择多个项目
`gitignore.nvim` 利用 `telescope.nvim` 的多选快捷键绑定。
这意味着默认情况下，你可以用 `<Tab>` （取消）选择多个关键字，
并用 `<CR>`（回车）确认选择。
如果选择了多个关键字，你按 `<CR>` 时高亮的关键字 **不会** 被加入选择！

为了方便起见，当未做多选而直接按 `<CR>` 时，
`<CR>` 会将高亮项目加入选择，并为该单个关键字创建 `.gitignore` 文件。

## 配置
如果你希望 `:Gitignore` 命令覆盖当前的 `.gitignore`，
而不是追加，可以设置：




```lua
vim.g.gitignore_nvim_overwrite = true
```
如果此变量设置为 `false`，或根本未设置，`:Gitignore` 将考虑现有的 `.gitignore`。

或者，您也可以使用感叹号调用该命令，如下所示：

```
:Gitignore! [path]
```
这将与为单次调用设置 `vim.g.gitignore_nvim_overwrite = true` 具有相同的效果。

### 自定义选择器

您可以不使用 `telescope.nvim` 或原生的 `vim.ui.select()`，  
而是根据以下约定实现自己的解决方案：
1. `gitignore.nvim` 提供模板名称列表以及两个方法 `generate` 和 `createGitignoreBuffer`。
2. `generate` 方法的第一个参数是一个包含 `.gitignore` 目标路径的 `opts` 表，路径位于 `opts.args` 中。
3. 必须将 `opts.args` 和选中的模板名称列表传递给 `createGitignoreBuffer`。

以下是使用 fzf-lua 的示例实现：
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
> 请注意，上述操作不会覆盖 `:Gitignore` 命令。
> 若要覆盖该命令，请在定义完你的生成函数后重新创建该命令，方法如下：
> 
```lua
vim.api.nvim_create_user_command("Gitignore", gitignore.generate, { nargs = "?", complete = "file" })
```

## 演示
[![asciicast](https://asciinema.org/a/GOHXDt4kYsR8pzrxTEOIridTf.svg)](https://asciinema.org/a/GOHXDt4kYsR8pzrxTEOIridTf)

## 致谢
感谢 [Toptal](https://github.com/toptal/gitignore) 提供了大量的忽略模板列表！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---