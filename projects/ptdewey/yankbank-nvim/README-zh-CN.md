# YankBank

一个 Neovim 插件，用于跟踪最近的复制和删除，并在快速访问菜单中展示它们。

## 功能介绍

YankBank 将最近的 N 次复制存入无名寄存器（"），然后用这些最近的复制内容填充弹出窗口，允许快速访问最近的复制历史。
打开弹出菜单时，当前无名加寄存器（+）的内容也会被加入菜单（如果它们与无名寄存器的当前内容不同）。

从菜单中选择一个条目（按回车）会将其粘贴到当前打开的缓冲区的光标位置。

YankBank 还支持会话间的持久化，这意味着关闭并重新打开会话后，你的复制内容不会丢失（参见 [持久化](#Persistence)）。

### 截图

![YankBank 弹出窗口放大图](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/assets/screenshot-2.png)

该菜单针对当前会话，且在全新会话中打开时仅包含当前无名加寄存器的内容。
在该会话中的每次复制或删除操作后，菜单会进一步填充。

## 安装与设置

#### 支持持久化（推荐）

使用 lazy.nvim
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

#### 无持久化：

使用 lazy.nvim
```lua
{
    "ptdewey/yankbank-nvim",
    cmd = { "YankBank" },
    config = function()
        require('yankbank').setup()
    end,
}
```
#### 延迟加载

根据[最佳实践](https://github.com/nvim-neorocks/nvim-best-practices?tab=readme-ov-file#sleeping_bed-lazy-loading)，YankBank 的初始化占用非常小，功能仅在需要时才加载。因此，我在配置中将 `lazy=false`，启动时间不到1毫秒。


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
如果你不想在启动时加载 YankBank，我之前是在按下复制文本的按键（`y`、`Y`、`d`、`D`、`x`）、`FocusGained` 事件和 `YankBank` 命令时加载它的。

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


### 设置选项

setup 函数还支持接受一个选项表：
| 选项 | 类型 | 默认值 |
|-------------|--------------------------------------------|----------------|
| max_entries | 弹出窗口中显示的条目数整数 | `10` |
| sep | 表条目间显示的字符串分隔符 | `"-----"` |
| keymaps | 包含键位映射覆盖的表 | `{}` |
| keymaps.navigation_next | 字符串 | `"j"` |
| keymaps.navigation_prev | 字符串 | `"k"` |
| keymaps.paste | 字符串 | `"<CR>"` |
| keymaps.paste_back | 字符串 | `"P"` |
| keymaps.yank | 字符串 | `"yy"` |
| keymaps.close | 字符串表 | `{ "<Esc>", "<C-c>", "q" }` |
| num_behavior | 定义跳转行为的字符串 "prefix" 或 "jump" | `"prefix"` |
| focus_gain_poll | 布尔值 | `false` |
| registers | 注册表覆盖的表容器 | `{ }` |
| registers.yank_register | 默认从弹出窗口复制到的寄存器 | `"+"` |
| persist_type | 定义持久化类型的字符串 "sqlite" 或 nil | `nil` |
| db_path | 用于 sqlite 持久化的数据库文件路径字符串 | 插件安装目录 |
| bind_indices | 用于按索引号粘贴的键绑定前缀可选字符串（例如 "<leader>p"） | `nil` |


#### 示例配置

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
如果不需要分隔符，请传入空字符串作为 `sep`

'num_behavior' 选项定义了按数字键时弹出窗口内的导航行为。
- `num_behavior = "prefix"` 类似于传统的 vim 导航，使用 '3j' 向下移动银行中 3 个条目。
- `num_behavior = "jump"` 跳转到与按下的数字键匹配的条目（即 '3' 跳转到第 3 个条目）
    - 注意：如果 'max_entries' 是两位数，按下以有效条目为前缀的数字时会有延迟。

'focus_gain_poll' 选项允许启用一个额外的自动命令，监听焦点获得事件（重新聚焦 Neovim 窗口），并检查 unnamedplus（'+'）寄存器的变化，在发现新内容时添加到 yankbank。这样可以自动将从其他来源（如浏览器）复制的文本添加到 yankbank，而无需触发银行打开。默认关闭，但我强烈建议启用 `focus_gain_poll = true`。

### 持久化
为了获得最佳的 YankBank 体验，强烈建议启用持久化。
启用持久化后，sqlite.lua 将被用于在插件根目录创建最近复制内容的持久存储。
要使用 sqlite 持久化，必须在配置中添加 `"kkharji/sqlite.lua"` 作为依赖，并将 `persist_type` 设置为 `"sqlite"`：


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
注意：可以使用 `:YankBankClearDB` 命令清除数据库，或者删除数据库文件（默认位于插件安装目录中）。

如果遇到任何与 SQL 相关的问题，请在 GitHub 上提交 issue。（作为临时解决方案，也可以尝试清除数据库）


如果在创建数据库文件时遇到权限问题（例如使用 Nix 安装时），请使用 `db_path` 选项更改默认文件路径。（`vim.fn.stdpath("data")` 应该可用）

## 使用方法

可以使用命令 `:YankBank` 打开弹出菜单，按回车键将在当前光标位置粘贴条目，按 Esc、Ctrl-C 或 q 可以关闭菜单。
也可以通过按 yy 将菜单中的条目复制到 unnamedplus 寄存器。

我个人也建议绑定一个快捷键来打开菜单。

```lua
-- map to '<leader>y'
vim.keymap.set("n", "<leader>y", "<cmd>YankBank<CR>", { noremap = true })
```

---

## API（开发中）

某些插件内部功能也可通过 YankBank API 访问。

示例：
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

有关 API 的更多详细信息，请参见 [lua/yankbank/api.lua](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/lua/yankbank/api.lua)

---

## 潜在改进
- nvim-cmp 集成
- fzf 集成
- telescope 集成

## 替代方案

- [nvim-neoclip](https://github.com/AckslD/nvim-neoclip.lua)
- [yanky.nvim](https://github.com/gbprod/yanky.nvim)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---