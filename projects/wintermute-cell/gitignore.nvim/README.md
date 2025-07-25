<!-- LTeX: language=en-US -->
# gitignore.nvim
![gitignore.nvim logo banner](https://github.com/wintermute-cell/gitignore.nvim/blob/resources/_resources/banner.webp)

A neovim plugin for generating .gitignore files in seconds, by allowing you to
select from a huge number of different technologies.

This plugin is functionally identical to the service offered by
[gitignore.io](https://www.toptal.com/developers/gitignore/), but capable of
generating `.gitignore` files offline, and directly from within neovim.

1. [Installation](#installation--dependencies)
2. [Usage](#usage)
3. [Demo](#demo)
4. [Credits](#credits)

## Installation & Dependencies
**`gitignore.nvim` optionally depends on
[telescope.nvim](https://github.com/nvim-telescope/telescope.nvim) to provide
[multi-selection](#selecting-multiple-items). Without [installing
telescope](https://github.com/nvim-telescope/telescope.nvim#installation) you
will not be able to select multiple technologies.**

After installing `telescope.nvim`, you can install `gitignore.nvim` like this:

Using [lazy.nvim](https://github.com/folke/lazy.nvim)
```lua
{"wintermute-cell/gitignore.nvim",
    config = function()
        require('gitignore')
    end,
}
```

Using [packer.nvim](https://github.com/wbthomason/packer.nvim):
```lua
use({
     "wintermute-cell/gitignore.nvim",
     requires = {
        "nvim-telescope/telescope.nvim" -- optional: for multi-select
     }
})
```

## Usage
This plugin ships with only one command which when run,
it will create a buffer with the `.gitignore` contents:
```
:Gitignore [path]
```
If an existing `.gitignore` is found, the generated contents will be appended
to the existing lines. The buffer will not save automatically, so there is no
risk of overwriting an existing `.gitignore`.

You can **optionally** pass a `path` argument to point the command to a
specific directory (for example if you have nested `.gitignore` files).

Alternatively, you can use the corresponding `lua` function directly, for
example to create a keymap:
```lua
local gitignore = require("gitignore")
vim.keymap.set("n", "<leader>gi", gitignore.generate)
```

Or with a path:
```lua
local gitignore = require("gitignore")
local my_path = "./some/path"
vim.keymap.set("n", "<leader>gi",
    function ()
        gitignore.generate(my_path)
    end
)
```

### Selecting multiple items
Without telescope, `gitignore.nvim` does not allow you to select multiple
technologies for your `.gitignore`, since the fallback picker, `vim.ui.select()`,
can only select one item.
Therefore, if you want to be able to select multiple technologies, you must
either [install
telescope.nvim](https://github.com/nvim-telescope/telescope.nvim#installation)
(you may find an example using `packer.nvim` in the
[Installation](#installation--dependencies) section), or override the provided
`generate` method with your own implementation ([see section
below](#custom-picker)).

`gitignore.nvim` will detect if `telescope.nvim` is installed and use it
automatically, there is no further configuration required.

### Selecting multiple items with telescope.nvim installed
`gitignore.nvim` makes use of `telescope.nvim`'s multi-selection keybinds.
This means that by default, you can (de-)select multiple keywords with `<Tab>`,
and confirm your selection with `<CR>` (Enter).
In case of multiple selected keywords, the keyword highlighted you press `<CR>`
on will **not** be added to the selection!

For convenience, when no multi-selection is made before pressing `<CR>`,
`<CR>` will actually add the highlighted item to the selection, and create
a `.gitignore` file for the single keyword.

## Configuration
If you want the `:Gitignore` command to overwrite your current `.gitignore`
instead of appending to it, you can set:
```lua
vim.g.gitignore_nvim_overwrite = true
```
If this variable is set to `false`, or not set at all, `:Gitignore` will take
into account an existing `.gitignore`.

Alternatively, you may call the command with a bang, like this:
```
:Gitignore! [path]
```
This will have the same effect as setting `vim.g.gitignore_nvim_overwrite = true` for a single call.

### Custom Picker

Instead of using `telescope.nvim` or the native `vim.ui.select()`, you may
implement your own solution according to the following contract:
1. `gitignore.nvim` provides list of templateNames and two methods `generate` and `createGititnoreBuffer`.
2. As its first parameter, the `generate` method will receive an `opts` table, containing the target path for the `.gitignore` in `opts.args`.
3. One must pass on `opts.args`, and a list of selected templateNames to `createGitignoreBuffer`.

Here's an example implementation using fzf-lua:
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
> __Note__
> Note that the above will not overwrite the `:Gitignore` command.
> To do that, recreate the command after defining your generate function as
> follows:
```lua
vim.api.nvim_create_user_command("Gitignore", gitignore.generate, { nargs = "?", complete = "file" })
```

## Demo
[![asciicast](https://asciinema.org/a/GOHXDt4kYsR8pzrxTEOIridTf.svg)](https://asciinema.org/a/GOHXDt4kYsR8pzrxTEOIridTf)

## Credits
Thanks to [Toptal](https://github.com/toptal/gitignore) for providing a huge
list of ignore-templates!
