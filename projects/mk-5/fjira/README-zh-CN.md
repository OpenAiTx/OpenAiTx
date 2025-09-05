# Fjira - 用于 Jira 的模糊查找器和 TUI 应用程序。

<img src="https://raw.githubusercontent.com/mk-5/fjira/master/fjira.png" alt="drawing" width="256"/>

[![Mentioned in Awesome Go](https://awesome.re/badge-flat.svg)](https://github.com/avelino/awesome-go)
![Test](https://github.com/mk-5/fjira/actions/workflows/tests.yml/badge.svg)
[![License: AGPL v3](https://img.shields.io/badge/License-AGPL%20v3-blue.svg)](https://github.com/mk-5/fjira/blob/master/LICENSE)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/mk-5/fjira)
[![Go Report Card](https://goreportcard.com/badge/github.com/mk-5/fjira)](https://goreportcard.com/report/github.com/mk-5/fjira)
[![Go Reference](https://pkg.go.dev/badge/github.com/mk-5/fjira.svg)](https://pkg.go.dev/github.com/mk-5/fjira)
[![codecov](https://codecov.io/gh/mk-5/fjira/branch/master/graph/badge.svg?token=MJBTMYGQQW)](https://codecov.io/gh/mk-5/fjira)

## 介绍

Fjira 是一款功能强大的命令行工具，旨在简化您与 Jira 的交互。无论您是开发人员、项目经理，还是仅仅是 Jira 爱好者，Fjira 都能简化您的工作流程，使 Jira 任务比以往更加高效。

![Fjira Demo](https://raw.githubusercontent.com/mk-5/fjira/master/demo.gif)

## 主要功能

- **模糊查找界面：** 轻松搜索 Jira 项目和问题。
- **指派控制：** 快速更改问题指派人，无需导航 Jira 界面。
- **状态更新：** 直接从终端更新 Jira 问题状态。
- **高效评论：** 轻松向 Jira 问题添加评论。
- **多工作区支持：** 轻松管理多个 Jira 工作区。
- **自定义搜索：** 使用 Jira 查询语言（JQL）进行定制搜索。
- **直接命令行访问：** 直接从命令行访问 Jira 问题。
- **跨平台兼容：** 在 macOS、Linux 和 Windows 上无缝运行。

## 安装

### macOS



```shell
brew tap mk-5/mk-5
brew install fjira
```

### Linux

#### Ubuntu/Snap

```shell
snap install fjira
```

#### Deb

访问 [https://github.com/mk-5/fjira/releases/latest](https://github.com/mk-5/fjira/releases/latest)，并获取最新的发布版本。


```shell
sudo dpkg -i fjira_0.4.0_linux_amd64.deb
```

#### AUR

```sh
yay -S fjira
```

#### 二进制

```shell
tar -xvzf fjira_0.4.0_Linux_x86_64.tar.gz
cp fjira /usr/local/bin/fjira
```

### Windows

```shell
choco install fjira
```

### 从源码构建

```shell
make
./out/bin/fjira
```

## 使用方法

```text
Usage:
  fjira [flags]
  fjira [command]

Available Commands:
  [issueKey]  Open a Jira issue directly from the CLI
  completion  Generate the autocompletion script for the specified shell
  filters     Search using Jira filters
  help        Help about any command
  jql         Search using custom JQL queries
  version     Print the version number of fjira
  workspace   Switch to a different workspace

Flags:
  -h, --help             help for fjira
  -p, --project string   Open a project directly from CLI

Additional help topics:
  fjira            Open a fuzzy finder for projects as a default action

Use "fjira [command] --help" for more information about a command.
```

## 入门指南

使用 Fjira CLI 非常简单。只需在终端中运行 fjira 即可。

```shell
fjira
```

## 工作区

首次运行 Fjira 时，它会提示您输入 Jira API URL 和令牌。

![Fjira 首次运行](https://raw.githubusercontent.com/mk-5/fjira/master/demo_first_run.gif)

Fjira 工作区将 Jira 配置数据存储在位于 `~/.fjira` 的简单 YAML 文件中。您可以使用 `fjira workspace` 命令在多个工作区之间切换。


```shell
fjira workspace
```

要创建一个新的工作区，请使用以下命令：

```shell
fjira workspace --new abc
```

您可以使用 `--edit` 标志编辑现有工作区：

```shell
fjira workspace --edit abc
```

### Jira 令牌类型

Fjira 支持 Jira Server 和 Jira Cloud，两者使用不同的令牌类型进行授权。该工具将在工作区配置期间提示
您选择合适的令牌类型。

```shell
? Jira Token Type:

1. api token
2. personal token

Enter a number (Default is 1):
```

### YAML 配置

如果您更喜欢手动方式，可以通过在 `~/.fjira/` 目录下创建 `fjira.yaml` 文件来添加工作区配置。  
为了方便您，示例配置文件在这里：[fjira.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/fjira.yaml)

## 项目搜索

运行 `fjira` 时的默认视图是项目搜索界面。

```shell
fjira
```

## 打开特定项目

您可以直接从命令行界面打开一个项目：

```shell
fjira --project=PROJ
```
这将跳过项目搜索屏幕，直接进入问题搜索屏幕。

## 直接打开问题

要直接从命令行界面打开问题：


```shell
fjira PROJ-123
```
Fjira 将跳过所有中间屏幕，直接带您进入问题视图。

![Fjira Issue View](https://raw.githubusercontent.com/mk-5/fjira/master/demo_issue.png)

## 看板视图

Fjira 还提供类似看板的视图。打开项目后，按 F4 进入该视图。

![Fjira Board View](https://raw.githubusercontent.com/mk-5/fjira/master/demo_board_view.png)

## 自定义 JQL 查询

您可以使用 Fjira 创建和执行自定义的 JQL 查询：


```shell
fjira jql
```

![Fjira Custom JQL](https://raw.githubusercontent.com/mk-5/fjira/master/demo_custom_jql.png)

## My Jira Filters

You can search using your stored (favourites) Jira Filters:

```shell
fjira filters
```

![Fjira 过滤器](https://raw.githubusercontent.com/mk-5/fjira/master/demo_filters.png)

## 自定义配色方案

通过创建自定义的 `~/.fjira/colors.yml` 文件来调整 fjira 颜色方案以匹配您的偏好。该文件
允许您根据个人风格个性化颜色。
请参考示例文件，位于此处：[colors.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/colors.yml)

## 路线图（待办）

- 扩展文档
- 创建和删除 Jira 过滤器
- 支持更多的 Linux 包管理器（Apt、AUR、YUM）
- 引入更多 Jira 功能

## 动机

Fjira 是为个人便利而设计，源于对效率的追求和对终端工具的热爱。
我们经常遇到“我只需要把问题 123 转到下一个状态。”虽然打开 Jira、在看板上定位
工单以及导航 Jira 问题模态都没问题，但确实消耗了不少时间。

Fjira 让您能够直接从终端执行此类任务，而终端很可能就是您正在工作的地方！😄

如果 Fjira 像提升我一样提升了您的 Jira 体验，请考虑在 GitHub 上为它点赞。🌟 这将激励我
未来的工作。

欢迎为该项目做出贡献，帮助塑造其未来！非常感谢您的反馈和贡献。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---