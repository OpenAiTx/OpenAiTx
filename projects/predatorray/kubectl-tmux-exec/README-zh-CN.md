# kubectl-tmux-exec

![GitHub release version](https://img.shields.io/github/v/release/predatorray/kubectl-tmux-exec)
![License](https://img.shields.io/github/license/predatorray/kubectl-tmux-exec)
![Build Status](https://img.shields.io/github/actions/workflow/status/predatorray/kubectl-tmux-exec/ci.yml?branch=master)
![GitHub all releases](https://img.shields.io/github/downloads/predatorray/kubectl-tmux-exec/total)

A **kubectl** plugin for executing commands interactively across multiple pods or containers using [**tmux**](https://github.com/tmux/tmux),
like `csshX` or `pssh` but for **Kubernetes**.

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot.png?raw=true)

To execute command across all the Nginx containers using `bash` for example, run:

```sh
kubectl tmux-exec -l app=nginx /bin/bash
```
## 安装

### Homebrew

> **注意**：此方法仅适用于 Mac 用户。

1. 安装 [Homebrew](https://brew.sh/)。

2. `brew install predatorray/brew/kubectl-tmux-exec`

最后，确保 `/usr/local/bin/kubectl-tmux_exec` 在你的 `$PATH` 中。

### Krew

> **注意**：推荐给 Linux 用户。
> 
> 虽然它在 Mac 和 Linux 上都可用，但不推荐 Mac 用户使用，因为你仍可能需要借助 Homebrew 安装依赖 `gnu-getopt`。

1. 按照 [用户指南](https://krew.sigs.k8s.io/docs/user-guide/setup/install/) 安装 [Krew](https://krew.sigs.k8s.io/)。

2. `kubectl krew install tmux-exec`

3. 安装依赖。（[Wiki: 如何安装依赖](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies)）

### 手动安装

1. 下载 [最新版本](https://github.com/predatorray/kubectl-tmux-exec/releases/latest)。

2. 解压 kubectl-tmux-exec-*.tar.gz 文件，并将所有文件复制到某个目录，例如 `/usr/local/kubectl-tmux-exec`。

3. 将 `bin/` 目录添加到你的 `$PATH`。例如，在你的 rc 文件中添加这一行：`export PATH="$PATH:/usr/local/kubectl-tmux-exec/bin"`。

4. 安装依赖。（[Wiki: 如何安装依赖](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies)）

## 使用

确保你的 `kubectl` 版本 ≥ 1.12（[插件支持]），最好是最新版本。

否则，直接执行脚本：`kubectl-tmux_exec [...ARGS]`。


通过以下方式检查脚本是否已成功添加：

```sh
kubectl plugin list
```
输出应如下所示


```txt
The following compatible plugins are available:

/usr/local/bin/kubectl-tmux_exec
```

如果它未显示在列表中，请再次检查 `$PATH` 环境变量。

您可以使用以下命令来获取脚本的用法。

```sh
kubectl tmux-exec --help

# or
kubectl-tmux_exec --help
```
### 选项

| 标志                            | 用法                                                                                                                                                       |
|---------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `-V`<br>`--version`             | 打印版本信息                                                                                                                               |
| `-l`<br>`--selector`            | 用于过滤的选择器（标签查询），支持 '=', '==', 和 '!='。(例如 -l key1=value1,key2=value2)<br>必须使用 `--selector` 或 `--file` 选项之一。 |
| `-f`<br>`--file`                | 从文件中逐行读取 Pod 名称。<br>必须使用 `--selector` 或 `--file` 选项之一。                                                            |
| `-c`<br>`--container`           | 容器名称。如果省略，将选择 Pod 中的第一个容器。                                                                                   |
| `-i`<br>`--stdin`               | 将标准输入传递给容器（**已弃用**，因为默认已启用）                                                                                 |
| `-t`<br>`--tty`                 | 标准输入为 TTY（**已弃用**，因为默认已启用）                                                                                              |
| `-d`<br>`--detach`              | 使 Tmux 会话分离                                                                                                                              |
| `-n`<br>`--namespace=`          | 此 CLI 请求的命名空间范围（可多次使用）                                                                                    |
| `--context`                     | 使用的 kubeconfig 上下文名称（可多次使用）                                                                                   |
| `-A`<br>`--all-namespaces`      | 如果存在，列出并执行所有命名空间中的请求对象。即使使用了 --namespace，当前上下文的命名空间也会被忽略。     |
| `-C`<br>`--enable-control-mode` | 以控制模式启动 tmux 并禁用回显。（参见：[iTerm2 集成](#iterm2-integration)）                                                           |
| `--remain-on-exit`              | 退出时保留 Tmux 窗口                                                                                                                                  |
| `--select-layout`               | 五种 Tmux 预设布局之一：even-horizontal, even-vertical, main-horizontal, main-vertical, 或 tiled。                                              |
| `--session-mode`                | 打开 tmux 的方式：auto, new-session, current-session                                                                                                    |

这些选项的使用方法也可通过 `--help` 获取。

### 示例

`tmux-exec` 类似于 `exec`，不同之处在于它需要标签选择器，而 `exec` 需要 Pod 名称。

例如，要进入所有具有某些公共标签（如 foo=bar）的 Pod 容器的 bash。


```sh
kubectl tmux-exec -l foo=bar /bin/bash
```
成功进入所选容器的 `bash` 后，实际上会打开一个 Tmux 窗口，每个窗格显示各个 Pod 容器的执行结果。你的键盘输入将同步到所有这些窗格。

如果你不熟悉 Tmux，可以查看 tmux 的手册页或在线教程。或者你可以参阅下面的 [快捷键表](#tmux-cheatsheet)，我认为这已经足够了。

### iTerm2 集成

使用 `-C` 或 `--enable-control-mode`，它以控制模式运行，并将窗格输入委托给 [iTerm2] 的“广播输入”功能，
无需 tmux 键绑定。

使用 <kbd>⌘</kbd> + <kbd>⌥</kbd> + <kbd>i</kbd> 在 iTerm2 中切换广播。 （此模式下会自动禁用 `synchronize-panes`。）

（详见：[tmux 集成](https://iterm2.com/documentation-tmux-integration.html)）

#### 示例


```sh
kubectl tmux-exec -C -l app=nginx /bin/bash
```

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot-iterm2-integration.png?raw=true)

### Shell 自动补全

请查看 [此维基](https://github.com/predatorray/kubectl-tmux-exec/wiki/Shell-Auto-completion) 了解更多信息。

### Tmux 速查表

所有 Tmux 命令都以 `PREFIX` 开头。默认的 `PREFIX` 是 <kbd>Ctrl</kbd> + <kbd>b</kbd>。下面我将用 `C-b` 表示它。

`C-b d`，从会话中分离。之后，Tmux 将在后台运行。你可以输入 `tmux a` 重新连接。

`C-b :setw synchronize-panes off`，关闭同步输入到所有窗格。

`C-b :setw synchronize-panes on`，开启同步输入到所有窗格。

`C-b <方向键>`，在窗格之间移动光标。

`C-b xy`，关闭当前窗格。

`C-b &y`，关闭包含所有窗格的窗口。

## 社区与支持

- 通过 [GitHub Issues]((https://github.com/predatorray/kubectl-tmux-exec/issues/new)) 提交问题或功能请求
- 加入 [Google 群组](https://groups.google.com/g/kubectl-tmux-exec) 进行讨论

## 其他插件

[kubectl-alias](https://github.com/predatorray/kubectl-alias)：kubectl 缺失的别名命令。

## 请我喝杯咖啡

如果它节省了你的时间，欢迎 [请我喝杯咖啡] 🙌

[![](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)][buy me a coffee]

[buy me a coffee]: https://buymeacoffee.com/predatorray
[iTerm2]: https://iterm2.com/index.html
[插件支持]: https://kubernetes.io/docs/tasks/extend-kubectl/kubectl-plugins/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---