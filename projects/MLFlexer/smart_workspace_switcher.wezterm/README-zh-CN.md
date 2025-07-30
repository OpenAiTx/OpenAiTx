# smart_workspace_switcher.wezterm

一个智能的 Wezterm 工作区切换器，灵感来自 [t-smart-tmux-session-manager](https://github.com/joshmedeski/t-smart-tmux-session-manager) 及其继任者 [sesh](https://github.com/joshmedeski/sesh)

## 使用方法

💨 通过 1️⃣ 次按键、模糊查找和 zoxide 的强大功能，⚡ ***极速*** ⚡ 切换工作区，提升你的工作流效率！💨

![演示 gif](https://github.com/MLFlexer/smart_workspace_switcher.wezterm/assets/75012728/a4f82fcf-5304-4891-a1e2-346767678dc6)

## 依赖项

* zoxide

### 设置

1. 引入该插件：

    ```lua
    local wezterm = require("wezterm")
    local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
    ```
2. 将默认按键绑定应用到配置：


    ```lua
    workspace_switcher.apply_to_config(config)
    ```
或者创建您自己的快捷键绑定，参见 [配置 - 快捷键绑定](#Keybinding)。

### 配置：
#### 快捷键绑定
添加自定义快捷键绑定：


  ```lua
  config.keys = {
    -- ...
    -- your other keybindings
    {
      key = "s",
      mods = "LEADER",
      action = workspace_switcher.switch_workspace(),
    },
    {
      key = "S",
      mods = "LEADER",
      action = workspace_switcher.switch_to_prev_workspace(),
    }
  }
  ```

#### 更改默认工作区名称
您可以设置一个默认的工作区名称：

```lua
config.default_workspace = "~"
```

#### 额外过滤

您可以在调用 `switch_workspace` 时包含 `extra_args` 来进一步过滤 zoxide 查询的结果。`extra_args` 只是一个字符串，拼接到命令中，如：`zoxide query -l <extra_args>`。例如，要从预定义的 `~/.projects` 列表中选择项目，可以这样调用插件：

  ```lua
  workspace_switcher.switch_workspace({ extra_args = " | rg -Fxf ~/.projects" })
  ```

#### 更改模糊查找器的元素

您可以通过为 `get_choices` 设置一个新函数来更改模糊查找器的元素列表，如下所示：

```lua
local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
workspace_switcher.get_choices = function(opts)
  -- this will ONLY show the workspace elements, NOT the Zoxide results
  return workspace_switcher.choices.get_workspace_elements({})
end
```
默认情况下，该函数使用以下函数来创建列表：


```lua
workspace_switcher.choices.get_workspace_elements({ id: string, label: string }[])
workspace_switcher.choices.get_zoxide_elements({ id: string, label: string }[], {extra_args?: string, workspace_ids?: workspace_ids}?)
```

#### 使用路径更新右侧状态

要将所选路径添加到右侧状态栏，请使用选择工作区时发出的 `smart_workspace_switcher.workspace_switcher.chosen` 事件：

  ```lua
  wezterm.on("smart_workspace_switcher.workspace_switcher.chosen", function(window, workspace)
    local gui_win = window:gui_window()
    local base_path = string.gsub(workspace, "(.*[/\\])(.*)", "%2")
    gui_win:set_right_status(wezterm.format({
      { Foreground = { Color = "green" } },
      { Text = base_path .. "  " },
    }))
  end)

  wezterm.on("smart_workspace_switcher.workspace_switcher.created", function(window, workspace)
    local gui_win = window:gui_window()
    local base_path = string.gsub(workspace, "(.*[/\\])(.*)", "%2")
    gui_win:set_right_status(wezterm.format({
      { Foreground = { Color = "green" } },
      { Text = base_path .. "  " },
    }))
  end)
  ```

#### 事件

以下事件可用，可用于触发自定义行为：

* `smart_workspace_switcher.workspace_switcher.start` - 当模糊查找器启动时触发。
* `smart_workspace_switcher.workspace_switcher.canceled` - 如果未选择任何元素，则触发。
* `smart_workspace_switcher.workspace_switcher.selected` - 当选择一个元素时触发。
* `smart_workspace_switcher.workspace_switcher.created` - 创建并切换到新工作区后触发。
* `smart_workspace_switcher.workspace_switcher.chosen` - 切换到工作区后触发。
* `smart_workspace_switcher.workspace_switcher.switched_to_prev` - 切换到上一个工作区后触发。

> [!注意]
> `created` 和 `chosen` 事件会发出 [MuxWindow](https://wezfurlong.org/wezterm/config/lua/mux-window/) 对象，而其他事件会发出 [GuiWindow](https://wezfurlong.org/wezterm/config/lua/window/index.html) 对象。

示例用法：

  ```lua
  wezterm.on("smart_workspace_switcher.workspace_switcher.chosen", function(window, workspace)
    wezterm.log_info("THIS IS EMITTED FROM THE CALLBACK")
  end)
  ```

#### 工作区格式化程序

使用以下示例设置自定义工作区格式化程序。欲了解更多信息，请参阅[Wezterm格式化文档](https://wezfurlong.org/wezterm/config/lua/wezterm/format.html)：

  ```lua
  workspace_switcher.workspace_formatter = function(label)
    return wezterm.format({
      { Attribute = { Italic = true } },
      { Foreground = { Color = "green" } },
      { Background = { Color = "black" } },
      { Text = "󱂬: " .. label },
    })
  end
  ```

#### Zoxide 路径

要定义 `zoxide` 的自定义路径：

  ```lua
  workspace_switcher.zoxide_path = "/path/to/zoxide"
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---