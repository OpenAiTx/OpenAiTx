# smart_workspace_switcher.wezterm

[t-smart-tmux-session-manager](https://github.com/joshmedeski/t-smart-tmux-session-manager)와 그 후속작 [sesh](https://github.com/joshmedeski/sesh)에서 영감을 받은 스마트한 Wezterm 작업 공간 전환기

## 사용법

💨 퍼지 찾기와 zoxide의 힘으로 1️⃣번의 키 입력만으로 작업 공간을 ⚡ ***눈부시게 빠르게*** ⚡ 전환하여 워크플로우를 향상시키세요! 💨

![데모 gif](https://github.com/MLFlexer/smart_workspace_switcher.wezterm/assets/75012728/a4f82fcf-5304-4891-a1e2-346767678dc6)

## 의존성

* zoxide

### 설치

1. 플러그인 요구:

    ```lua
    local wezterm = require("wezterm")
    local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
    ```
2. 기본 키 바인딩을 설정에 적용합니다:


    ```lua
    workspace_switcher.apply_to_config(config)
    ```

또는 직접 키 바인딩을 생성하려면, [설정 - 키 바인딩](#Keybinding)을 참조하세요.

### 설정:
#### 키 바인딩
사용자 정의 키 바인딩을 추가하려면:

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
#### 기본 작업 공간 이름 변경
기본 작업 공간 이름을 설정할 수 있습니다:


```lua
config.default_workspace = "~"
```

#### 추가 필터링

`switch_workspace` 호출 시 `extra_args`를 포함하여 zoxide 쿼리 결과를 추가로 필터링할 수 있습니다. `extra_args`는 명령어에 문자열로 연결되는 형태로, 예를 들어 `zoxide query -l <extra_args>`와 같습니다. 예를 들어, `~/.projects`에 미리 정의된 목록에서 프로젝트를 선택하려면 다음과 같이 플러그인을 호출합니다:

  ```lua
  workspace_switcher.switch_workspace({ extra_args = " | rg -Fxf ~/.projects" })
  ```
#### 퍼지 파인더의 요소 변경하기

`get_choices`에 새로운 함수를 설정하여 퍼지 파인더의 요소 목록을 다음과 같이 변경할 수 있습니다:


```lua
local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
workspace_switcher.get_choices = function(opts)
  -- this will ONLY show the workspace elements, NOT the Zoxide results
  return workspace_switcher.choices.get_workspace_elements({})
end
```
기본적으로 이 함수는 다음 함수를 사용하여 목록을 생성합니다:


```lua
workspace_switcher.choices.get_workspace_elements({ id: string, label: string }[])
workspace_switcher.choices.get_zoxide_elements({ id: string, label: string }[], {extra_args?: string, workspace_ids?: workspace_ids}?)
```

#### 경로로 우측 상태 업데이트하기

선택한 경로를 우측 상태 표시줄에 추가하려면, 작업 공간을 선택할 때 발생하는 `smart_workspace_switcher.workspace_switcher.chosen` 이벤트를 사용하세요:

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
#### 이벤트

다음 이벤트들이 제공되며 사용자 정의 동작을 트리거하는 데 사용할 수 있습니다:

* `smart_workspace_switcher.workspace_switcher.start` - 퍼지 파인더가 시작될 때 트리거됩니다.
* `smart_workspace_switcher.workspace_switcher.canceled` - 요소가 선택되지 않았을 때 트리거됩니다.
* `smart_workspace_switcher.workspace_switcher.selected` - 요소가 선택되었을 때 트리거됩니다.
* `smart_workspace_switcher.workspace_switcher.created` - 새 워크스페이스를 생성하고 전환한 후 트리거됩니다.
* `smart_workspace_switcher.workspace_switcher.chosen` - 워크스페이스로 전환한 후 트리거됩니다.
* `smart_workspace_switcher.workspace_switcher.switched_to_prev` - 이전 워크스페이스로 전환한 후 트리거됩니다.

> [!NOTE]
> `created`와 `chosen` 이벤트는 [MuxWindow](https://wezfurlong.org/wezterm/config/lua/mux-window/) 객체를 방출하며, 나머지 이벤트들은 [GuiWindow](https://wezfurlong.org/wezterm/config/lua/window/index.html) 객체를 방출합니다. 

예제 사용법:


  ```lua
  wezterm.on("smart_workspace_switcher.workspace_switcher.chosen", function(window, workspace)
    wezterm.log_info("THIS IS EMITTED FROM THE CALLBACK")
  end)
  ```

#### 작업 공간 포매터

다음 예제를 사용하여 사용자 지정 작업 공간 포매터를 설정하세요. 자세한 내용은 [Wezterm 포매팅 문서](https://wezfurlong.org/wezterm/config/lua/wezterm/format.html)를 참조하세요:

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

#### Zoxide 경로

`zoxide`에 대한 사용자 정의 경로를 설정하려면:

  ```lua
  workspace_switcher.zoxide_path = "/path/to/zoxide"
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---