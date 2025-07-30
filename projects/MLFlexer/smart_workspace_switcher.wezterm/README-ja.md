# smart_workspace_switcher.wezterm

[t-smart-tmux-session-manager](https://github.com/joshmedeski/t-smart-tmux-session-manager) とその後継である [sesh](https://github.com/joshmedeski/sesh) に触発されたスマートな Wezterm ワークスペーススイッチャー

## 使用方法

💨 1️⃣ キー操作、ファジーファインディングと zoxide の力でワークスペース間を ⚡ ***超高速*** ⚡ に切り替えてワークフローをレベルアップしよう！💨

![デモgif](https://github.com/MLFlexer/smart_workspace_switcher.wezterm/assets/75012728/a4f82fcf-5304-4891-a1e2-346767678dc6)

## 依存関係

* zoxide

### セットアップ

1. プラグインを読み込む:

    ```lua
    local wezterm = require("wezterm")
    local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
    ```

2. デフォルトのキー割り当てを設定に適用します：

    ```lua
    workspace_switcher.apply_to_config(config)
    ```

または独自のキーバインディングを作成するには、[設定 - キーバインディング](#Keybinding)を参照してください。

### 設定：
#### キーバインディング
カスタムキーバインディングを追加するには：

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

#### デフォルトのワークスペース名の変更
デフォルトのワークスペース名を設定できます：

```lua
config.default_workspace = "~"
```

#### 追加フィルタリング

`switch_workspace` の呼び出しに `extra_args` を含めることで、zoxide クエリの結果をさらにフィルタリングできます。`extra_args` はコマンドに連結される文字列で、次のように使います：`zoxide query -l <extra_args>`。例えば、`~/.projects` にある事前定義リストからプロジェクトを選択するには、プラグインを次のように呼び出します：

  ```lua
  workspace_switcher.switch_workspace({ extra_args = " | rg -Fxf ~/.projects" })
  ```

#### ファジーファインダーの要素を変更する

`get_choices` に新しい関数を設定することで、ファジーファインダーの要素リストを変更できます。次のように:

```lua
local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
workspace_switcher.get_choices = function(opts)
  -- this will ONLY show the workspace elements, NOT the Zoxide results
  return workspace_switcher.choices.get_workspace_elements({})
end
```
デフォルトでは、関数は次の関数を使用してリストを作成します：


```lua
workspace_switcher.choices.get_workspace_elements({ id: string, label: string }[])
workspace_switcher.choices.get_zoxide_elements({ id: string, label: string }[], {extra_args?: string, workspace_ids?: workspace_ids}?)
```

#### パスで右側のステータスを更新する

選択したパスを右側のステータスバーに追加するには、ワークスペースを選択したときに発行される `smart_workspace_switcher.workspace_switcher.chosen` イベントを使用します：

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
#### イベント

以下のイベントが利用可能で、カスタム動作のトリガーとして使用できます:

* `smart_workspace_switcher.workspace_switcher.start` - ファジーファインダーが開始されたときにトリガーされます。
* `smart_workspace_switcher.workspace_switcher.canceled` - 要素が選択されなかった場合にトリガーされます。
* `smart_workspace_switcher.workspace_switcher.selected` - 要素が選択されたときにトリガーされます。
* `smart_workspace_switcher.workspace_switcher.created` - 新しいワークスペースを作成して切り替えた後にトリガーされます。
* `smart_workspace_switcher.workspace_switcher.chosen` - ワークスペースに切り替えた後にトリガーされます。
* `smart_workspace_switcher.workspace_switcher.switched_to_prev` - 前のワークスペースに切り替えた後にトリガーされます。

> [!注意]
> `created` と `chosen` イベントは [MuxWindow](https://wezfurlong.org/wezterm/config/lua/mux-window/) オブジェクトを発行し、他のイベントは [GuiWindow](https://wezfurlong.org/wezterm/config/lua/window/index.html) オブジェクトを発行します。 

使用例:


  ```lua
  wezterm.on("smart_workspace_switcher.workspace_switcher.chosen", function(window, workspace)
    wezterm.log_info("THIS IS EMITTED FROM THE CALLBACK")
  end)
  ```

#### ワークスペースフォーマッター

以下の例を使用してカスタムワークスペースフォーマッターを設定します。詳細については、[Weztermフォーマットドキュメント](https://wezfurlong.org/wezterm/config/lua/wezterm/format.html)を参照してください:

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

#### Zoxide パス

`zoxide`へのカスタムパスを定義するには:

  ```lua
  workspace_switcher.zoxide_path = "/path/to/zoxide"
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---