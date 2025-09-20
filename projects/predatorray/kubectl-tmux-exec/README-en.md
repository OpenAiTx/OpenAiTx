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

## Installation 

### Homebrew

> **Note**: This is for Mac users only.

1. Install [Homebrew](https://brew.sh/).

2. `brew install predatorray/brew/kubectl-tmux-exec`

Finally, ensure `/usr/local/bin/kubectl-tmux_exec` is in your `$PATH`.

### Krew

> **Note**: It is recommended for Linux users.
> 
> Although it works both on Mac and Linux, it is not recommended for Mac users, since you still may need to install the dependency `gnu-getopt` with the help of Homebrew.

1. Install [Krew](https://krew.sigs.k8s.io/) by following [the user guide](https://krew.sigs.k8s.io/docs/user-guide/setup/install/).

2. `kubectl krew install tmux-exec`

3. Install the dependencies. ([Wiki: How-to-Install-Dependencies](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

### Manually

1. Download the [latest release](https://github.com/predatorray/kubectl-tmux-exec/releases/latest).

2. Unpack the kubectl-tmux-exec-*.tar.gz file and copy all the files to a directory, `/usr/local/kubectl-tmux-exec` for instance.

3. Add the `bin/` directory to your `$PATH`. For example, add this line to your rc file: `export PATH="$PATH:/usr/local/kubectl-tmux-exec/bin"`.

4. Install the dependencies. ([Wiki: How-to-Install-Dependencies](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

## Usage

Make sure you have `kubectl` ≥ 1.12 ([plugin support]), ideally latest.

Otherwise, execute the script directly: `kubectl-tmux_exec [...ARGS]`.
Check if the script has been successfully added by:


```sh
kubectl plugin list
```
The output should be like


```txt
The following compatible plugins are available:

/usr/local/bin/kubectl-tmux_exec
```

If it does not show in the list, check the `$PATH` environment variable again.

You can use the command below to get the usage of the script.

```sh
kubectl tmux-exec --help

# or
kubectl-tmux_exec --help
```

### Options

| Flag                            | Usage                                                                                                                                                       |
|---------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `-V`<br>`--version`             | Print the version information                                                                                                                               |
| `-l`<br>`--selector`            | Selector (label query) to filter on, supports '=', '==', and '!='.(e.g. -l key1=value1,key2=value2)<br>You must either use `--selector` or `--file` option. |
| `-f`<br>`--file`                | Read pod names line-by-line from a file.<br>You must either use `--selector` or `--file` option.                                                            |
| `-c`<br>`--container`           | Container name. If omitted, the first container in the pod will be chosen                                                                                   |
| `-i`<br>`--stdin`               | Pass stdin to the container (**deprecated**, since it's enabled by default)                                                                                 |
| `-t`<br>`--tty`                 | Stdin is a TTY (**deprecated**, since it's enabled by default)                                                                                              |
| `-d`<br>`--detach`              | Make the Tmux session detached                                                                                                                              |
| `-n`<br>`--namespace=`          | The namespace scope for this CLI request (can be applied multiple times)                                                                                    |
| `--context`                     | The name of the kubeconfig context to use (can be applied multiple times)                                                                                   |
| `-A`<br>`--all-namespaces`      | If present, list and execute the requested object(s) across all namespaces. Namespace in current context is ignored even if specified with --namespace.     |
| `-C`<br>`--enable-control-mode` | Start tmux in control mode and echo is disabled. (See: [iTerm2 Integration](#iterm2-integration))                                                           |
| `--remain-on-exit`              | Remain Tmux window on exit                                                                                                                                  |
| `--select-layout`               | One of the five Tmux preset layouts: even-horizontal, even-vertical, main-horizontal, main-vertical, or tiled.                                              |
| `--session-mode`                | Where tmux is opened: auto, new-session, current-session                                                                                                    |

The usage of these options is also available by `--help`.

### Example

The `tmux-exec` is similar to `exec`, except that it requires label selectors while `exec` requires a pod name.

To `bash` into all pod containers that share some common labels, `foo=bar` for instance.

```sh
kubectl tmux-exec -l foo=bar /bin/bash
```
After you have successfully `bash`-ed into your selected containers, a Tmux window is opened actually, where each pane displays the execution result of each pod's container. Your keyboard inputs will be synchronized to all those panes.

If you are not familar with Tmux, you can have a look at tmux's man page or online tutorials. Or you can see the [cheatsheet](#tmux-cheatsheet) below, which will be sufficient I think.

### iTerm2 Integration

With `-C` or `--enable-control-mode`, it runs in control mode and delegates pane input to [iTerm2]'s "Broadcast Input" feature,
no need for tmux key bindings.

Use <kbd>⌘</kbd> + <kbd>⌥</kbd> + <kbd>i</kbd> to toggle broadcasting in iTerm2. (`synchronize-panes` will be disabled automatically in this mode.)

(see: [tmux Integration](https://iterm2.com/documentation-tmux-integration.html) for more information)

#### Example


```sh
kubectl tmux-exec -C -l app=nginx /bin/bash
```

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot-iterm2-integration.png?raw=true)

### Shell Auto-completion

Please check [this wiki](https://github.com/predatorray/kubectl-tmux-exec/wiki/Shell-Auto-completion) for more information.

### Tmux Cheatsheet

All Tmux commands start with a `PREFIX`. By default the `PREFIX` is <kbd>Ctrl</kbd> + <kbd>b</kbd>. I will use `C-b` below to stand for it.

`C-b d`, detach from the session. After that, Tmux will be running in the background. You can type `tmux a` to re-attach.

`C-b :setw synchronize-panes off`, turn off synchronizing inputs to all panes.

`C-b :setw synchronize-panes on`, turn on synchronizing inputs to all panes.

`C-b <ARROW-KEY>`, move cursor between panes.

`C-b xy`, close the current pane.

`C-b &y`, close the window including all panes.

## Community & Support

- File issues or feature requests via [GitHub Issues]((https://github.com/predatorray/kubectl-tmux-exec/issues/new))
- Join the [Google Group](https://groups.google.com/g/kubectl-tmux-exec) for discussions

## Other plugins

[kubectl-alias](https://github.com/predatorray/kubectl-alias): the missing alias command for kubectl.

## Buy Me a Coffee

If it saves you time, feel free to [buy me a coffee] 🙌

[![](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)][buy me a coffee]

[buy me a coffee]: https://buymeacoffee.com/predatorray
[iTerm2]: https://iterm2.com/index.html
[plugin support]: https://kubernetes.io/docs/tasks/extend-kubectl/kubectl-plugins/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---