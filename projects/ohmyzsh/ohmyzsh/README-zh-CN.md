<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh 是一个开源的、社区驱动的框架，用于管理你的 [zsh](https://www.zsh.org/) 配置。

听起来很无聊。让我们再试一次。

**Oh My Zsh 并不会让你成为 10 倍开发者……但你可能会有那种感觉。**

一旦安装完成，你的终端 shell 将成为众人谈论的焦点，_否则退款！_ 在命令提示符下的每一次敲击中，你都能利用数百个强大的插件和精美的主题。陌生人会在咖啡馆走过来问你：“太酷了！你是天才吗？”

最终，你将开始获得你一直觉得理应得到的关注。……或者你会用省下的时间去更勤快地用牙线。😬

了解更多，请访问 [ohmyz.sh](https://ohmyz.sh)，在 X（前身为 Twitter）关注 [@ohmyzsh](https://x.com/ohmyzsh)，并加入我们的 [Discord](https://discord.gg/ohmyzsh)。

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>目录</summary>

- [快速入门](#getting-started)
  - [操作系统兼容性](#operating-system-compatibility)
  - [先决条件](#prerequisites)
  - [基础安装](#basic-installation)
    - [手动检查](#manual-inspection)
- [使用 Oh My Zsh](#using-oh-my-zsh)
  - [插件](#plugins)
    - [启用插件](#enabling-plugins)
    - [使用插件](#using-plugins)
  - [主题](#themes)
    - [选择主题](#selecting-a-theme)
  - [常见问题](#faq)
- [高级主题](#advanced-topics)
  - [高级安装](#advanced-installation)
    - [自定义目录](#custom-directory)
    - [无人值守安装](#unattended-install)
    - [从分叉仓库安装](#installing-from-a-forked-repository)
    - [手动安装](#manual-installation)
  - [安装问题](#installation-problems)
  - [自定义插件和主题](#custom-plugins-and-themes)
  - [在 macOS 和 freeBSD 系统启用 GNU ls](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [跳过别名](#skip-aliases)
  - [异步 git 提示](#async-git-prompt)
- [获取更新](#getting-updates)
  - [更新详细程度](#updates-verbosity)
  - [手动更新](#manual-updates)
- [卸载 Oh My Zsh](#uninstalling-oh-my-zsh)
- [如何为 Oh My Zsh 贡献力量？](#how-do-i-contribute-to-oh-my-zsh)
  - [不要向我们提交主题](#do-not-send-us-themes)
- [贡献者](#contributors)
- [关注我们](#follow-us)
- [周边商品](#merchandise)
- [许可证](#license)
- [关于 Planet Argon](#about-planet-argon)

</details>

## 快速入门

### 操作系统兼容性

| 操作系统         | 状态 |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### 先决条件

- 已安装 [Zsh](https://www.zsh.org)（v4.3.9 或更高版本即可，但建议使用 5.0.8 及以上）。如果未预装（运行 `zsh --version` 确认），请参考此 Wiki 指南：[安装 ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- 已安装 `curl` 或 `wget`
- 已安装 `git`（建议 v2.4.11 或更高）

### 基础安装

在你的终端中运行以下任一命令即可安装 Oh My Zsh。你可以通过 `curl`、`wget` 或其他类似工具在命令行中安装。

| 方法    | 命令                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

此外，安装程序也在 GitHub 以外进行镜像。如果你在中国或印度等某些国家（或部分 ISP）无法访问 `raw.githubusercontent.com`，请使用以下地址：

| 方法    | 命令                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_注意，任何之前的 `.zshrc` 文件将被重命名为 `.zshrc.pre-oh-my-zsh`。安装完成后，你可以将需要保留的配置移动到新的 `.zshrc` 文件中。_

#### 手动检查

对于你还不熟悉的项目，建议先检查安装脚本。你可以先下载脚本，浏览无误后再运行：

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

如果上述 URL 超时或失败，你可以替换为 `https://install.ohmyz.sh` 来获取脚本。

## 使用 Oh My Zsh

### 插件

Oh My Zsh 内置了大量插件供你使用。你可以在 [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) 目录和/或 [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) 中查看当前可用的插件。

#### 启用插件

找到想要使用的插件后，需要在 `.zshrc` 文件中启用它们。你可以在 `$HOME` 目录下找到 zshrc 文件。用你喜欢的文本编辑器打开，找到插件列表的位置。

```sh
vi ~/.zshrc
```

例如，插件列表可能如下所示：

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_注意插件之间用空白字符（空格、制表符、换行等）分隔。**不要**用逗号，否则会出错。_

#### 使用插件

每个内置插件都包含一个 **README**，文档中会说明该插件包含的别名（如果有）及其他额外功能。

### 主题

我们承认，Oh My Zsh 早期有点过度热衷于主题。现在我们已经内置了 150 多个主题。大部分主题在 wiki 上都有 [截图](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes)（我们正在持续更新！）。快去看看吧！

#### 选择主题

_Robby 的主题是默认主题。它不是最炫的，也不是最简的。只是对他来说刚刚好。_

找到想用的主题后，需要编辑 `~/.zshrc` 文件。你会看到一个环境变量（全大写），类似如下：

```sh
ZSH_THEME="robbyrussell"
```

要使用其他主题，只需将值改为你想要的主题名。例如：

```sh
ZSH_THEME="agnoster" # （这是一个很炫的主题）
# 见 https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> 你可能会看到某个 zsh 主题的截图，尝试之后发现显示效果不一致。
>
> 这是因为许多主题需要安装 [Powerline Font](https://github.com/powerline/fonts) 或 [Nerd Font](https://github.com/ryanoasis/nerd-fonts) 才能正确显示。否则会出现奇怪的提示符号。更多信息请查看 [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt)。
>
> 另外，请注意，主题只控制你的提示符外观，也就是光标前后显示的文本，不包括终端窗口的颜色（即 _配色方案_）或字体。这些可以在你的终端模拟器中设置。详见 [什么是 zsh 主题](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme)。
<!-- prettier-ignore-end -->

打开新的终端窗口，提示符应该会有类似如下的效果：

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

如果没有找到合适的主题，请前往 wiki 查看 [更多主题](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes)。

如果你想尝试新鲜感，可以让电脑每次随机选择一个主题：

```sh
ZSH_THEME="random" # （……请抽到 pie……一定是 pie……）
```

如果你只想从自己喜欢的主题列表中随机选择：

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

如果你只知道自己不喜欢哪些主题，可以用如下方式将它们加入忽略列表：

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### 常见问题

有更多问题或疑问，可以在我们的 [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ) 中找到解决方案。

## 高级主题

如果你喜欢动手，以下部分可能适合你。

### 高级安装

有些用户可能想手动安装 Oh My Zsh，或更改默认路径和其他安装参数（这些设置也在安装脚本顶部有说明）。

#### 自定义目录

默认位置为 `~/.oh-my-zsh`（在你的主目录下，使用 `cd ~/.oh-my-zsh` 进入）

如果你想通过 `ZSH` 环境变量更改安装目录，可以在安装前运行 `export ZSH=/your/path`，或者像下面这样在安装命令结尾设置：

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### 无人值守安装

如果你将 Oh My Zsh 的安装脚本作为自动化安装的一部分运行，可以向 `install.sh` 脚本传递 `--unattended` 参数。这样不会尝试更改默认 shell，安装完成后也不会自动运行 `zsh`。

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

如果你在中国、印度等无法访问 `raw.githubusercontent.com` 的国家，请将 URL 替换为 `https://install.ohmyz.sh`。

#### 从分叉仓库安装

安装脚本也接受以下变量，以支持从不同仓库安装：

- `REPO`（默认：`ohmyzsh/ohmyzsh`）：格式为 `owner/repository`。设置后，安装程序会访问 `https://github.com/{owner}/{repository}`。
- `REMOTE`（默认：`https://github.com/${REPO}.git`）：git 仓库完整克隆地址。如果你想从非 GitHub 平台（如 GitLab、Bitbucket）或使用 SSH 克隆，可以用这个设置。
  
  _注意：与设置 `REPO` 变量不兼容，该设置优先生效。_

- `BRANCH`（默认：`master`）：指定克隆仓库时要检出的分支。适用于测试 Pull Request 或使用非 master 分支。

例如：

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### 手动安装

##### 1. 克隆仓库 <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _可选_，备份你现有的 `~/.zshrc` 文件 <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. 创建新的 Zsh 配置文件 <!-- omit in toc -->

你可以通过拷贝我们为你准备的模板来创建新的 zsh 配置文件。

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. 更改你的默认 shell <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

你需要退出当前用户会话并重新登录以生效。

##### 5. 初始化新的 Zsh 配置 <!-- omit in toc -->

打开新的终端窗口后，应该会加载带有 Oh My Zsh 配置的 zsh。

### 安装问题

如果安装过程中遇到问题，这里有一些常见的解决办法。

- 切换到 oh-my-zsh 后，如果有些命令找不到，_可能_ 需要在 `~/.zshrc` 中修改 `PATH`。
- 如果你是手动安装或更改了安装路径，请检查 `~/.zshrc` 中的 `ZSH` 环境变量。

### 自定义插件和主题

如需覆盖默认行为，只需在 `custom/` 目录下添加一个以 `.zsh` 结尾的新文件。

如果你有多个相关功能，可以将它们作为 `XYZ.plugin.zsh` 文件放到 `custom/plugins/` 目录下，然后启用该插件。

如需覆盖 Oh My Zsh 内置插件的功能，在 `custom/plugins/` 目录下创建同名插件即可，优先加载你的插件。

### 在 macOS 和 freeBSD 系统启用 GNU ls

<a name="enable-gnu-ls"></a>

Oh My Zsh 默认在 macOS 和 FreeBSD 系统中使用 BSD `ls`。如果已安装 GNU `ls`（命令为 `gls`），可以选择使用它。在 `oh-my-zsh.sh` 加载前，通过 zstyle 配置：

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_注意：这与 `DISABLE_LS_COLORS=true` 不兼容_

### 跳过别名

<a name="remove-directories-aliases"></a>

如需跳过默认 Oh My Zsh 别名（定义在 `lib/*` 文件中）或插件别名，可以在 `~/.zshrc` 文件中（**在加载 Oh My Zsh 之前**）使用以下设置。可根据需要选择不同跳过方式。

```sh
# 跳过所有别名（lib 文件和启用的插件）
zstyle ':omz:*' aliases no

# 跳过所有 lib 文件中的别名
zstyle ':omz:lib:*' aliases no
# 仅跳过 directories.zsh lib 文件中定义的别名
zstyle ':omz:lib:directories' aliases no

# 跳过所有插件别名
zstyle ':omz:plugins:*' aliases no
# 仅跳过 git 插件的别名
zstyle ':omz:plugins:git' aliases no
```

你还可以按优先级组合使用这些设置：

```sh
# 跳过所有插件别名，除了 git 插件
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

旧版本的设置方式如下，现已移除：

```sh
zstyle ':omz:directories' aliases no
```

请改用以下方式：

```sh
zstyle ':omz:lib:directories' aliases no
```

#### 注意 <!-- omit in toc -->

> 此功能目前处于测试阶段，未来可能变更。它也暂时与如 zpm、zinit 这样的插件管理器不兼容，因为这些不会加载实现该功能的初始化脚本（`oh-my-zsh.sh`）。
>
> 该功能目前也无法识别以函数形式定义的“别名”。如 git 插件的 `gccd`、`ggf` 或 `ggl` 等函数。

### 异步 git 提示

异步提示功能是实验性特性（2024 年 4 月 3 日加入），允许 Oh My Zsh 异步渲染提示信息。这可以提升提示符的渲染性能，但在部分环境下可能不兼容。如遇到相关问题，可在 .zshrc 文件中（在 Oh My Zsh 加载前）关闭此功能：

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

如果你的问题是 git 提示不再显示，可以尝试在 `oh-my-zsh.sh` 加载前强制启用。如果仍有问题，请提交 issue 并说明你的情况。

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## 获取更新

默认情况下，每 2 周会提示检查更新。你可以通过在 `~/.zshrc` 文件中（**在加载 Oh My Zsh 之前**）添加以下行，选择其他更新模式：

1. 自动更新，无需确认提示：

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. 只在有更新时每隔几天提醒一次：

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. 完全禁用自动更新：

   ```sh
   zstyle ':omz:update' mode disabled
   ```

注意：你可以通过以下设置控制 Oh My Zsh 检查更新的频率：

```sh
# 每 7 天检查一次更新
zstyle ':omz:update' frequency 7
# 每次打开终端都检查更新（不推荐）
zstyle ':omz:update' frequency 0
```

### 更新详细程度

你还可以通过以下设置限制更新提示的详细程度：

```sh
zstyle ':omz:update' verbose default # 默认更新提示

zstyle ':omz:update' verbose minimal # 只显示少量信息

zstyle ':omz:update' verbose silent # 只显示错误
```

### 手动更新

如果你想随时更新（比如刚发布了新插件，不想等一周？）只需运行：

```sh
omz update
```

> [!NOTE]
> 如果你想在脚本中自动化这个过程，应该直接调用 `upgrade` 脚本，如下：
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> 更多选项见 [FAQ: 如何更新 Oh My Zsh？](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh)。
>
> **`omz update --unattended` 已被移除，因为存在副作用**。

神奇！🎉

## 卸载 Oh My Zsh

Oh My Zsh 并不适合每个人。如果你要卸载 Oh My Zsh，只需在命令行运行 `uninstall_oh_my_zsh`。它会自动卸载，并恢复你之前的 bash 或 zsh 配置。

## 如何为 Oh My Zsh 贡献力量？

在参与我们可爱的社区之前，请阅读 [行为准则](CODE_OF_CONDUCT.md)。

我并不是 [Zsh](https://www.zsh.org/) 专家，相信还有很多改进空间——如果你有让配置更易维护（并且更快）的想法，欢迎 fork 并提交 pull request！

我们也需要大家帮忙测试 pull request。欢迎浏览 [开放的问题](https://github.com/ohmyzsh/ohmyzsh/issues)，提供你的帮助。

更多细节见 [贡献指南](CONTRIBUTING.md)。

### 不要向我们提交主题

我们目前（远远）有足够多的主题。请将你的主题添加到 [external themes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) wiki 页面。

## 贡献者

Oh My Zsh 拥有充满活力的用户社区和可爱的贡献者。没有大家的时间和帮助，就不会有今天的 Oh My Zsh。

非常感谢！

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## 关注我们

我们在社交媒体上：

- 在 X（前身为 Twitter）关注 [@ohmyzsh](https://x.com/ohmyzsh)。
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) 上戳我们一下。
- [Instagram](https://www.instagram.com/_ohmyzsh/) 晒出你的 Oh My Zsh，记得@我们！
- 加入 [Discord](https://discord.gg/ohmyzsh) 与我们交流！

## 周边商品

我们有
[贴纸、T 恤和咖啡杯](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github)
供你展示对 Oh My Zsh 的热爱。你将再次成为众人谈论的焦点！

## 许可证

Oh My Zsh 以 [MIT 许可证](LICENSE.txt) 发布。

## 关于 Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh 由 [Planet Argon](https://www.planetargon.com/?utm_source=github) 团队发起，
是一家 [Ruby on Rails 开发代理商](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github)。
欢迎查看我们的 [其他开源项目](https://www.planetargon.com/open-source?utm_source=github)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---