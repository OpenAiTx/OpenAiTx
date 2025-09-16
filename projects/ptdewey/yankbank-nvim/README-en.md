# YankBank

A Neovim plugin for keeping track of more recent yanks and deletions and exposing them in a quick access menu.

## What it Does

YankBank stores the N recent yanks into the unnamed register ("), then populates a popup window with these recent yanks, allowing for quick access to recent yank history.
Upon opening the popup menu, the current contents of the unnamedplus (+) register are also added to the menu (if they are different from the current contents of the unnamed register).

Choosing an entry from the menu (by hitting enter) will paste it into the currently open buffer at the cursor position.

YankBank also offers persistence between sessions, meaning that you won't lose your yanks after closing and reopening a session (see [persistence](#Persistence)).

### Screenshots

![YankBank popup window zoomed](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/assets/screenshot-2.png)

The menu is specific to the current session, and will only contain the contents of the current unnamedplus register upon opening in a completely new session.
It will be populated further for each yank or deletion in that session.

## Installation and Setup

#### With Persistence (Recommended)

Using lazy.nvim
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

#### Without persistence:

Using lazy.nvim
```lua
{
    "ptdewey/yankbank-nvim",
    cmd = { "YankBank" },
    config = function()
        require('yankbank').setup()
    end,
}
```

#### Lazy loading

According to [best practices](https://github.com/nvim-neorocks/nvim-best-practices?tab=readme-ov-file#sleeping_bed-lazy-loading), YankBank's initialization footprint is very minimal, and functionalities are only loaded when they are needed. As such, I set `lazy=false` in my config, and get a startup time of <1ms.

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
If you don't want to load YankBank on startup, I previously loaded it on keypresses that yank text (`y`, `Y`, `d`, `D`, `x`), the `FocusGained` event, and the `YankBank` command.

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


### Setup Options

The setup function also supports taking in a table of options:
| Option | Type | Default |
|-------------|--------------------------------------------|----------------|
| max_entries | integer number of entries to show in popup | `10` |
| sep | string separator to show between table entries | `"-----"` |
| keymaps | table containing keymap overrides | `{}` |
| keymaps.navigation_next | string | `"j"` |
| keymaps.navigation_prev | string | `"k"` |
| keymaps.paste | string | `"<CR>"` |
| keymaps.paste_back | string | `"P"` |
| keymaps.yank | string | `"yy"` |
| keymaps.close | table of strings | `{ "<Esc>", "<C-c>", "q" }` |
| num_behavior | string defining jump behavior "prefix" or "jump" | `"prefix"` |
| focus_gain_poll | boolean | `false` |
| registers | table container for register overrides | `{ }` |
| registers.yank_register | default register to yank from popup to | `"+"` |
| persist_type | string defining persistence type "sqlite" or nil | `nil` |
| db_path | string defining database file path for use with sqlite persistence | plugin install directory |
| bind_indices | optional string to be used for keybind prefix for pasting by index number (i.e. "<leader>p") | `nil` |


#### Example Configuration

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
If no separator is desired, pass in an empty string for `sep`

The 'num_behavior' option defines in-popup navigation behavior when hitting number keys.
- `num_behavior = "prefix"` works similar to traditional vim navigation with '3j' moving down 3 entries in the bank.
- `num_behavior = "jump"` jumps to entry matching the pressed number key (i.e. '3' jumps to entry 3)
    - Note: If 'max_entries' is a two-digit number, there will be a delay upon pressing numbers that prefix a valid entry.

The 'focus_gain_poll' option allows for enabling an additional autocommand that watches for focus gains (refocusing Neovim window), and checks for changes in the unnamedplus ('+') register, adding to yankbank when new contents are found. This allows for automatically adding text copied from other sources (like a browser) to the yankbank without the bank opening trigger. Off by default, but I highly recommend enabling it with `focus_gain_poll = true`.

### Persistence
For the best experience with YankBank, enabling persistence is highly recommended.
If persistence is enabled, sqlite.lua will be used to create a persistent store for recent yanks in the plugin root directory.
To utilize sqlite persistence, `"kkharji/sqlite.lua"` must be added as a dependency in your config, and `persist_type` must be set to `"sqlite"`:


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

Note: The database can be cleared with the `:YankBankClearDB` command or by deleting the db file (found in the plugin install directory by default).

If you run into any SQL related issues, please file an issue on GitHub. (As a temporary fix, you can also try clearing the database)


If you run into permissions issues when creating the db file (i.e. when installing using Nix), use the `db_path` option to change the default file path. (`vim.fn.stdpath("data")` should work)

## Usage

The popup menu can be opened with the command:`:YankBank`, an entry is pasted at the current cursor position by hitting enter, and the menu can be closed by hitting escape, ctrl-c, or q.
An entry from the menu can also be yanked into the unnamedplus register by hitting yy.

I would personally also recommend setting a keybind to open the menu.
```lua
-- map to '<leader>y'
vim.keymap.set("n", "<leader>y", "<cmd>YankBank<CR>", { noremap = true })
```

---

## API (WIP)

Some plugin internals are also accessible via the YankBank API.

Examples:
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

For more details about the API see [lua/yankbank/api.lua](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/lua/yankbank/api.lua)

---

## Potential Improvements
- nvim-cmp integration
- fzf integration
- telescope integration

## Alternatives

- [nvim-neoclip](https://github.com/AckslD/nvim-neoclip.lua)
- [yanky.nvim](https://github.com/gbprod/yanky.nvim)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---