# 咒术师 TUI
[![nix](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml/badge.svg)](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml)

咒术版本控制系统的 TUI
我们的关注点是：
- **性能**：jj_tui 启动快速，永远不会拖慢你的速度，浏览提交和文件时应感觉极其流畅
- **直观**：快捷键应易于记忆，快速形成肌肉记忆，无需不必要的弹窗
- **交互性**：jj_tui 完全重新实现了 jj 的渲染器，因此我们可以在你规划变基时实时显示图形预览（使用 `r`ebase `p`review 试试！）

![jj_tui-ezgif com-optimize](https://github.com/faldor20/jj_tui/assets/26968035/fb053320-484a-4d6f-9b66-e5b9d0d49e5d)


按 `?` 显示帮助。（图形和文件视图的命令不同）。
用 `方向键` 或 `hjkl` 导航窗口/项目
按 `空格` 选择/取消选择修订（图形视图支持多选）
按 `回车` 展开差异并滚动查看

## 主要功能

### 常规 jj 操作
- `c` 提交
- `r` 变基
- `g` Git 推送和拉取
- 添加、移动和删除 `b` 书签
- `s` 合并和 `s` 拆分提交
- `空格` 可用于多选提交以复制、变基等，在其上启动 `n` 新提交等

### 从文件视图创建提交：
- `空格` 可用于选择文件以单独 `c` 提交或 `m` 移动到不同提交
- 文件可以发送到 `N` 下一次或 `P` 上一次提交

### 按修订集过滤
- `f` 按你喜欢的任何修订集过滤

图形命令列表：

![jj_tui commands](https://github.com/user-attachments/assets/1e446a3d-1736-4207-b311-29d8e4bdc333)

## 安装
`linux`：下载最新版本。它是静态链接的，应该可以在任何 Linux 机器上运行。
`mac`：获取一个预构建版本。如果你遇到任何问题，请告诉我，因为我无法在 Mac 上测试。

在 nix 上使用 jj_tui 打开 shell：`nix shell github:faldor20/jj_tui`

## 依赖项
jujutsu CLI（最低版本 0.30.0）
我尚未在 Windows 或 Mac 上测试。
我认为它在 Unix 以外无法工作，因此 Windows 用户目前必须使用 wsl。

# 配置文件：
你可以在以下目录中创建一个 `config.yaml` 配置文件，以自定义按键输入
`linux`：$XDG_CONFIG_HOME/jj_tui/
`macos`：~/Library/preferences/jj_tui/
请参见 `./jj_tui/lib/key_map.ml` 中的键映射规范和 `./jj_tui/lib/config.ml` 中的配置
键映射配置允许你完全自定义所有命令及其子菜单，并重新映射箭头键。

例如：

``` yaml
key_map:
  remap:
   h: "left"
   j: "down"
   k: "up"
   l: "right"
  graph:
    #Simple mapping from key to command_id
    p: prev
    #Command sub menu
    s:
      title: "Squash"
      sub:
        # sub menu command
        s: "squash_into_parent"
# If the terminal is smaller than this width, the UI will change to a single pane view
single_pane_width_threshold: 110
# Sets the limit to how many commits are ever rendered in jj_tui. Usefull for not slowing down too much when viewing 'all()' revest.
max_commits: 100
```
完整的命令 ID 列表请参见 [`jj_tui/bin/graph_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/graph_commands.ml) 和 [`jj_tui/bin/file_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/file_commands.ml)

# 日志：
`linux`：$XDG_STATE_HOME/jj_tui/
`macos`：~/Library/logs/jj_tui/

# 开发
可以通过 nix 构建 `nix build` 或使用 `nix develop` 打开 nix shell
注意：如果您使用 nix 开发 shell 并希望使用 dune 构建，请使用 `dune build --pkg disabled` 以使用 nix 提供的依赖进行构建
也可以直接通过 Dune 包管理使用 `dune build` 构建。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-23

---