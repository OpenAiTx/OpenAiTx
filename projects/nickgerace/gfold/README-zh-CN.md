# gfold

[![latest release tag](https://img.shields.io/github/v/tag/nickgerace/gfold?sort=semver&logo=git&logoColor=white&label=version&style=for-the-badge&color=blue)](https://github.com/nickgerace/gfold/releases/latest)
[![crates.io version](https://img.shields.io/crates/v/gfold?style=for-the-badge&logo=rust&color=orange)](https://crates.io/crates/gfold)
[![build status](https://img.shields.io/github/actions/workflow/status/nickgerace/gfold/ci.yml?branch=main&style=for-the-badge&logo=github&logoColor=white)](https://github.com/nickgerace/gfold/actions)
[![calver](https://img.shields.io/badge/calver-YYYY.MM.MICRO-cyan.svg?style=for-the-badge)](https://calver.org)

`gfold` 是一个帮助你跟踪多个 Git 仓库的命令行工具。

[![A GIF showcasing gfold in action](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)

如果你希望默认使用经典显示模式，避免每次都设置标志，可以在配置文件中设置（见 **用法** 部分）。

## 公告（2025 年 2 月）

所有版本现在遵循 [CalVer](https://calver.org/) 版本控制方案，从 `2025.2.1` 开始。
此更改与之前从首个版本到 `4.6.0` 版本采用的 [语义化版本控制](https://semver.org/spec/v2.0.0.html) 方案兼容，既向前也向后兼容。

*针对版本控制方案的更改，终端用户无需执行任何操作。*

此公告最终会从此 [README](https://raw.githubusercontent.com/nickgerace/gfold/main/./README.md) 中移除，并最终移入 [CHANGELOG](https://raw.githubusercontent.com/nickgerace/gfold/main/./CHANGELOG.md)。

## 描述

该应用在一个或多个目录中显示多个 Git 仓库的相关信息。
它仅从文件系统读取数据，绝不会写入数据。
尽管此工具的范围和用途看似有限，但这是有意为之。

默认情况下，`gfold` 从当前工作目录开始遍历，查看每个 Git 仓库。
如果你想指定其他目录，可以将其路径（相对或绝对）作为第一个参数传入，或在配置文件中更改默认路径。

遍历完成后，`gfold` 利用 [rayon](https://github.com/rayon-rs/rayon) 并发执行对所有检测到的 Git 仓库的只读分析。
分析通过调用 [git2-rs](https://github.com/rust-lang/git2-rs) 库完成。

## 用法

提供 `-h/--help` 标志以查看使用此应用程序的所有选项。

```shell
# Operate in the current working directory or in the location provided by a config file, if one exists.
gfold

# Operate in the parent directory.
gfold ..

# Operate in the home directory (first method).
gfold $HOME

# Operate in the home directory (second method).
gfold ~/

# Operate with an absolute path.
gfold /this/is/an/absolute/path

# Operate with a relative path.
gfold ../../this/is/a/relative/path

# Operate with three paths.
gfold ~/src ~/projects ~/code
```

### 配置文件

如果您发现自己经常提供相同的参数，可以创建并使用配置文件。  
`gfold` 默认不带配置文件，配置文件完全是可选的。

它是如何工作的？  
执行时，`gfold` 会按以下路径（顺序）查找配置文件：

- `$XDG_CONFIG_HOME/gfold.toml`  
- `$XDG_CONFIG_HOME/gfold/config.toml`  
- `$HOME/.config/gfold.toml`  

`$XDG_CONFIG_HOME` 指的是字面上的 `XDG_CONFIG_HOME` 环境变量，但如果未设置，则默认为适合操作系统的特定路径（详见 [`user_dirs`](https://github.com/uncenter/user_dirs)）。

如果找到配置文件，`gfold` 会读取并使用其中指定的选项。

要创建配置文件，可以使用 `--dry-run` 标志打印有效的 TOML。  
下面是在 macOS、Linux 及类似平台上创建配置文件的示例工作流程：

```shell
gfold -d classic -c never ~/ --dry-run > $HOME/.config/gfold.toml
```
以下是生成的配置文件内容：


```toml
paths = ['/home/neloth']
display_mode = 'Classic'
color_mode = 'Never'
```

假设你创建了一个配置文件，但想用完全不同的设置执行 `gfold`，并且你想确保
不会意外继承配置文件中的选项。
在这种情况下，你可以使用 `-i` 标志来忽略你的配置文件。

```shell
gfold -i
```
您可以使用相同的标志将配置文件恢复为默认设置。


```shell
gfold -i > $HOME/.config/gfold.toml
```
此外，您可以忽略现有的配置文件，配置特定选项，并对未指定的选项使用默认值，一次性完成。  
以下是一个示例，我们想使用经典显示模式，并将所有其他设置覆盖为其默认值：  


```shell
gfold -i -d classic > $HOME/.config/gfold.toml
```
你可以备份配置文件并使用 `git` 跟踪其历史。  
在 macOS、Linux 以及大多数系统上，你可以将该文件链接回一个 `git` 仓库。


```shell
ln -s <path-to-repository>/gfold.toml $HOME/.config/gfold.toml
```
现在，您可以更新存储库中的配置文件，并将链接作为环境设置工作流程的一部分。

## 安装

[![打包状态](https://repology.org/badge/vertical-allrepos/gfold.svg)](https://repology.org/project/gfold/versions)

### Homebrew（macOS 和 Linux）

您可以使用 [Homebrew](https://brew.sh) 通过 [核心配方](https://formulae.brew.sh/formula/gfold) 安装 `gfold`。

但是，如果通过 `brew` 安装了 [coreutils](https://formulae.brew.sh/formula/coreutils)，在 macOS 上可能会遇到命名冲突。
有关解决方法和更多信息，请参见[故障排除](#troubleshooting-and-known-issues)部分。


```shell
brew install gfold
```

### Arch Linux

您可以使用 [pacman](https://wiki.archlinux.org/title/Pacman) 从 [extra 仓库](https://archlinux.org/packages/extra/x86_64/gfold/) 安装 `gfold`。

```shell
pacman -S gfold
```

### Nix 与 NixOS

您可以从 [nixpkgs](https://github.com/NixOS/nixpkgs/blob/master/pkgs/applications/version-management/gfold/default.nix) 安装 `gfold`：

```shell
nix-env --install gfold
```

如果您正在使用 [flakes](https://nixos.wiki/wiki/Flakes)，可以直接使用 `nix` 命令进行安装。

```shell
nix profile install "nixpkgs#gfold"
```

### Cargo

你可以使用 [cargo](https://crates.io) 在几乎任何平台上安装该 [crate](https://crates.io/crates/gfold)。

```shell
cargo install gfold
```

如果您希望 Cargo 使用 `Cargo.lock`，请使用 `--locked` 标志。

```shell
cargo install --locked gfold
```
保持该 crate 最新非常简单，只需使用 [cargo-update](https://crates.io/crates/cargo-update)。


```shell
cargo install cargo-update
cargo install-update -a
```

### 下载二进制文件

如果您不想使用上述安装方法之一，也不想克隆仓库，可以从[发布页面](https://github.com/nickgerace/gfold/releases)下载二进制文件。  
有关如何操作的示例，请参考[手动安装](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md)指南。

### 从源码构建

如果您想了解如何从源码构建的示例，请参考[手动安装](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md)指南。

### 已弃用：Homebrew Tap（仅限 macOS）

位于 nickgerace/homebrew-nickgerace 的[tap](https://github.com/nickgerace/homebrew-nickgerace/blob/main/Formula/gfold.rb)已被弃用。  
请改用上述的核心 Homebrew 软件包。

### 未列出首选安装方法？

请[提交问题](https://github.com/nickgerace/gfold/issues/new)！

## 兼容性

`gfold` 旨在运行于 _任何_ Rust 🦀 第一梯队目标。  
如果您的平台不受支持，请[提交问题](https://github.com/nickgerace/gfold/issues)。

## 故障排除及已知问题

如果您遇到意外行为或错误并希望查看更多细节，请以更高详细级别运行。

```shell
gfold -vvv
```

如果问题仍然存在，请[提交问题](https://github.com/nickgerace/gfold/issues)。
请附上执行时的相关日志，_敏感信息已脱敏_，以帮助解决您的问题。

### macOS 上的 Coreutils 冲突

如果通过 `brew` 在 macOS 上安装了来自 [GNU Coreutils](https://www.gnu.org/software/coreutils/) 的 `fold`，它将被命名为 `gfold`。
您可以通过 shell 别名、shell 函数和/或更改 `PATH` 来避免此冲突。
以下是去掉 `gfold` 中的字母 `o` 的示例：

```shell
alias gfld=$HOME/.cargo/bin/gfold
```

## 社区

有关更多信息以及对用户和广大“社区”的感谢，请参阅 **[社区感谢](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/COMMUNITY_THANKS.md)** 文件。

- [NixOS、Arch Linux 等的软件包](https://repology.org/project/gfold/versions)
- [“一百个 Rust 二进制文件”](https://www.wezm.net/v2/posts/2020/100-rust-binaries/page2/)，一篇介绍 `gfold` 的文章
- [nvim-gfold.lua](https://github.com/AckslD/nvim-gfold.lua)，一个 `gfold` 的 `neovim` 插件 _([Reddit 发布公告](https://www.reddit.com/r/neovim/comments/t209wy/introducing_nvimgfoldlua/))_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-04

---