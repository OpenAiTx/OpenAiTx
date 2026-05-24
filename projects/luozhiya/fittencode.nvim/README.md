# fittencode.nvim

The refactored `fittencode.nvim` is ready.

## ✨ Features
- 🚀 Fast completion thanks to Fitten Code
- ⚡️ Asynchronous I/O for enhanced performance
- ✏️ Enhanced inline completion
  - ✨ Inline completion
  - ✂️ Edit completion
- 📂 Project Completion
  - 🧩 C/C++
- 🔄 Accept/Revoke by range
  - 📝 Char
  - 📖 Word
  - 📜 Line
  - 📋 All
- 🀄️ Enhanced Chinese completion with support for character segmentation
- 🔌 Sources for `blink.cmp` and native Neovim LSP server

## ⚡️ Requirements
- Neovim 0.11+
- curl

## 📦 Installation

Install the plugin with your preferred package manager:

For example with `lazy.nvim`:

```lua
{
  'luozhiya/fittencode.nvim',
  opts = {},
}
```

## ⚙️ Configuration

> This version does not support chat functionality.

```lua
    server = {
        -- Avaiable options:
        -- * 'default'
        -- * 'standard'
        -- * 'enterprise'
        fitten_version = 'default',
        -- The server URL for Fitten Code.
        -- You can also change it to your own server URL if you have a private server.
        -- Default server URL: 'https://api.fittentech.com'
        server_url = '',
    },
    action = {
        document_code = {
            -- Show "Fitten Code - Document Code" in the editor context menu, when you right-click on the code.
            show_in_editor_context_menu = true,
        },
        edit_code = {
            -- Show "Fitten Code - Edit Code" in the editor context menu, when you right-click on the code.
            show_in_editor_context_menu = true,
        },
        explain_code = {
            -- Show "Fitten Code - Explain Code" in the editor context menu, when you right-click on the code.
            show_in_editor_context_menu = true,
        },
        find_bugs = {
            -- Show "Fitten Code - Find Bugs" in the editor context menu, when you right-click on the code.
            show_in_editor_context_menu = true,
        },
        generate_unit_test = {
            -- Show "Fitten Code - Generate UnitTest" in the editor context menu, when you right-click on the code.
            show_in_editor_context_menu = true,
        },
        optimize_code = {
            -- Show "Fitten Code - Optimize Code" in the editor context menu, when you right-click on the code.
            show_in_editor_context_menu = true,
        },
        start_chat = {
            -- Show "Fitten Code - Start Chat" in the editor context menu, when you right-click on the code.
            show_in_editor_context_menu = true,
        },
    },
    -- Add Certain Type to Commit Message
    add_type_to_commit_message = {
        -- Avaiable options:
        -- * 'auto'
        -- * 'concise'  Concise Commit Message
        -- * 'detailed' Detailed Commit Message
        open = 'auto',
    },
    agent = {
        -- Simplify Agent's Thinking Output
        -- Avaiable options:
        -- * 'auto'
        -- * 'on'
        -- * 'off'
        simple_thinking = 'auto',
    },
    delay_completion = {
        -- Delay time for inline completion (in milliseconds).
        ---@type integer
        delaytime = 0,
    },
    disable_specific_inline_completion = {
        -- Disable auto-completion for some specific file suffixes by entering them below
        -- For instances, `suffixes = {'lua', 'cpp'}`
        suffixes = {},
    },
    inline_completion = {
        -- Enable inline code completion.
        ---@type boolean
        enable = true,
        -- Auto triggering completion
        ---@type boolean
        auto_triggering_completion = true,
        -- Disable auto completion when the cursor is within the line.
        ---@type boolean
        disable_completion_within_the_line = false,
        -- Disable auto completion when pressing Backspace or Delete.
        ---@type boolean
        disable_completion_when_delete = false,
        -- Disable auto completion when entering Insert mode `InsertEnter`.
        disable_completion_when_insert_enter = true,
        -- Disable auto completion when the popup menu is changed `CompleteChanged`.
        disable_completion_when_pumcmp_changed = false,
        -- Disable auto completion when the buffer is not a file.
        disable_completion_when_nofile_buffer = true,
    },
    integrations = {
        completion = {
            -- Enable completion as an LSP server.
            ---@type boolean
            lsp_server = false,
            -- Enable completion as an `blink.cmp` source
            blink = false
        },
        commit_message = false,
        filetype = false,
    },
    language_preference = {
        -- Language preference for display and responses in Fitten Code (excluding "Fitten Code - Document Code" function).
        -- Lower case of the BCP 47 language tag.
        -- Avaiable options:
        -- * 'en'
        -- * 'zh-cn'
        -- * 'auto'
        display_preference = 'zh-cn',
        -- Language preference when using function "Fitten Code - Document Code".
        -- Lower case of the BCP 47 language tag.
        -- Avaiable options:
        -- * 'en'
        -- * 'zh-cn'
        -- * 'auto'
        comment_preference = 'auto',
        -- Language preference for commit message.
        -- Lower case of the BCP 47 language tag.
        -- Avaiable options:
        -- * 'en'
        -- * 'zh-cn'
        -- * 'auto'
        commit_message_preference = 'auto',
    },
    -- Show menu as submenu in the editor context menu, when you right-click on the code.
    show_submenu = false,
    snippet = {
        -- The comment / document snippet as the style reference for Fitten Code's Document Code function.
        comment = '',
    },
    unit_test_framework = {
        -- Unit Test Framework for C/C++
        -- Avaiable options:
        -- * 'gmock',
        -- * 'gtest'
        ['C/C++'] = 'Not specified',
        -- Unit Test Framework for Go
        -- Avaiable options:
        -- * 'gomock'
        -- * 'gotests'
        -- * 'testify'
        -- * 'monkey'
        -- * 'sqlmock'
        -- * 'httptest'
        ['Go'] = 'Not specified',
        -- Unit Test Framework for Java
        -- Avaiable options:
        -- * 'mockito'
        -- * 'junit4'
        -- * 'junit5'
        -- * 'testNG'
        -- * 'spock'
        -- * 'jmockit'
        ['Java'] = 'Not specified',
        -- Unit Test Framework for JavaScript/TypeScript
        -- Avaiable options:
        -- * 'mock'
        -- * 'jest'
        -- * 'tape'
        -- * 'mocha'
        ['JavaScript/Typescript'] = 'Not specified',
        -- Unit Test Framework for Python
        -- Avaiable options:
        -- * 'mock'
        -- * 'pytest'
        -- * 'doctest'
        -- * 'unittest'
        ['Python'] = 'Not specified',
    },
    -- Intelligent Triggered Edit Completion
    use_auto_edit_completion = {
        -- Avaiable options:
        -- * 'auto'
        -- * 'on'
        -- * 'off'
        open = 'auto',
    },
    -- Automatic Project Index Creation
    use_auto_upload_project = {
        -- Avaiable options:
        -- * 'auto'
        -- * 'on'
        -- * 'off'
        open = 'auto',
    },
    -- Entire Project Perception based Completion
    use_project_completion = {
        -- Avaiable options:
        -- * 'auto'
        -- * 'on'
        -- * 'off'
        open = 'auto',
    },
    -- Use default keymaps for Fitten Code.
    -- If set to false, all defaults keymaps will be removed.
    use_default_keymaps = true,
    -- Default keymaps for Fitten Code.
    keymaps = {
        inline = {
            inccmp = {
                ['inline_completion'] = '<A-\\>',
                ['accept_all'] = '<Tab>',
                ['accept_next_line'] = '<C-Down>',
                ['accept_next_word'] = '<C-Right>',
                ['revoke'] = { '<C-Left>', '<C-Up>' },
                -- ['cancel'] = '<Esc>',
            },
            editcmp = {
                ['edit_completion'] = '<A-o>',
                ['accept_all'] = '<Tab>',
                ['accept_next_hunk'] = '<C-Down>',
                ['revoke'] = { '<C-Left>', '<C-Up>' },
                ['cancel'] = '<Esc>',
            }
        },
        chat = {
            ['add_selection_context_to_input'] = 'A-X',
            ['document_code'] = '',
            ['edit_code'] = '',
            ['explain_code'] = '',
            ['find_bugs'] = '',
            ['generate_unit_test'] = '',
            ['optimize_code'] = '',
            ['start_chat'] = '',
        }
    },
    log = {
        level = vim.log.levels.WARN,
        -- Notify when log errors occur.
        notify_on_errors = false,
        trace = false,
    },
    colors = {
        -- { fg = '#ffffff', bg = '#000000', style = 'bold' }
        ['Suggestion'] = {},
        ['InfoNotify'] = {},
        ['Commit'] = {},
    },
```

## 🚀 Usage

| Command Name      | Description           |
|-------------------|-----------------------|
| register          | Register account      |
| login             | Login account         |
| login3rd          | Third-party login     |
| logout            | Logout account        |
| ask_question      | Ask question          |
| user_guide        | User guide            |
| enable_completions| Enable completions    |
| disable_completions| Disable completions   |
| onlyenable_completions| Enable completions for specific files|
| onlydisable_completions| Disable completions for specific files|

## ✏️ API

| Function | Description |
|----------|-------------|
| `has_completions()` | Check if there are completion suggestions available |
| `accept(scope)` | Accept the current completion suggestion |
| `revoke()` | Undo the last completion operation |
| `completion_cancel()` | Cancel the current completion suggestion |
| `get_status()` | Get the current status of the completion system |

## 🎉 Special Thanks

https://github.com/FittenTech/fittencode.vim

