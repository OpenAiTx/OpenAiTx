# i3-quickterm

[![Packaging status](https://repology.org/badge/vertical-allrepos/python:i3-quickterm.svg)](https://repology.org/project/python:i3-quickterm/versions)

一个适用于 [i3wm](https://i3wm.org/) 和 [sway](https://swaywm.org/) 的小型下拉终端

## 功能

* 使用你喜欢的终端模拟器
* 可通过 [dmenu](http://tools.suckless.org/dmenu/) / [rofi](https://github.com/DaveDavenport/rofi) 选择 shell
* 适应屏幕宽度
* 支持多显示器

## 安装

通过 pip 安装：

```
pip install i3-quickterm
```

或者查看上方的 repology 徽章，确认是否由您的发行版打包。

## 使用方法

启动时，如果当前屏幕上有 quickterm，则会将其最小化。否则，它会提示用户选择要打开的 shell，或者使用参数中提供的 shell。

如果请求的 shell 已经在另一个屏幕上打开，则会将其移动到当前屏幕。

建议将其映射到 i3 快捷键：

```
# with prompt
bindsym $mod+p exec i3-quickterm
# always bring up standard shell, without the menu
bindsym $mod+b exec i3-quickterm shell
```

## 配置

配置文件从 `~/.config/i3-quickterm/config.json` 或 `~/.config/i3/i3-quickterm.json` 中读取。

* `menu`：用于选择 shell 的兼容 dmenu 的应用程序
* `term`：首选的终端模拟器
* `history`：保存最近使用的 shell 顺序的文件，若设置为 null 则禁用最近使用顺序
* `width`：使用的屏幕宽度百分比
* `height`：使用的屏幕高度百分比
* `pos`：终端弹出的位置（`top` 或 `bottom`）
* `shells`：注册的 shell（`{ name: command }`）

`term` 可以是：
- 来自[支持列表](#supported-terminals)的终端名称。
- `auto`，选择上述列表中第一个存在的终端（仅用于提供更友好的默认值，否则不推荐）
- 格式字符串，如：`urxvt -t {title} -e {expanded}`，需符合你的终端正确的参数格式。有些终端，如 xfce4-terminal，需要将命令参数作为字符串传递，此时将 `{expanded}` 替换为 `{string}`

`menu`、`term`、`history` 和 `shell` 可以包含环境变量占位符：`{$var}`。

未指定的键继承默认值：

```
{
    "menu": "rofi -dmenu -p 'quickterm: ' -no-custom -auto-select",
    "term": "auto",
    "history": "{$HOME}/.cache/i3-quickterm/shells.order",
    "width": 1.0,
    "height": 0.25,
    "pos": "top",
    "shells": {
        "js": "node",
        "python": "ipython3 --no-banner",
        "shell": "{$SHELL}"
    }
}
```

## 支持的终端

* alacritty
* foot
* gnome-terminal
* kitty
* roxterm
* st
* terminator
* termite
* urxvt
* urxvtc
* xfce4-terminal
* xterm

如果您想添加其他终端（或更正错误），请提交拉取请求。

## 要求

* python >= 3.8
* i3 >= v3.11 或 sway >= 1.2
* [i3ipc-python](https://i3ipc-python.readthedocs.io/en/latest/) >= v2.0.1
* dmenu 或 rofi（可选）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---