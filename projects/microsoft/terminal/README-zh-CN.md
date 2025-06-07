![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# 欢迎来到 Windows Terminal、控制台和命令行仓库

<details>
  <summary><strong>目录</strong></summary>

- [安装和运行 Windows Terminal](#installing-and-running-windows-terminal)
  - [Microsoft Store【推荐】](#microsoft-store-recommended)
  - [其他安装方法](#other-install-methods)
    - [通过 GitHub](#via-github)
    - [通过 Windows 包管理器 CLI（即 winget）](#via-windows-package-manager-cli-aka-winget)
    - [通过 Chocolatey（非官方）](#via-chocolatey-unofficial)
    - [通过 Scoop（非官方）](#via-scoop-unofficial)
- [安装 Windows Terminal Canary（金丝雀版）](#installing-windows-terminal-canary)
- [Windows Terminal 路线图](#windows-terminal-roadmap)
- [终端与控制台概述](#terminal--console-overview)
  - [Windows Terminal](#windows-terminal)
  - [Windows 控制台主机](#the-windows-console-host)
  - [共享组件](#shared-components)
  - [创建新的 Windows Terminal](#creating-the-new-windows-terminal)
- [资源](#resources)
- [常见问题](#faq)
  - [我编译并运行了新终端，但它看起来和旧控制台一样](#i-built-and-ran-the-new-terminal-but-it-looks-just-like-the-old-console)
- [文档](#documentation)
- [参与贡献](#contributing)
- [与团队沟通](#communicating-with-the-team)
- [开发者指南](#developer-guidance)
- [先决条件](#prerequisites)
- [编译代码](#building-the-code)
  - [在 PowerShell 中编译](#building-in-powershell)
  - [在 Cmd 中编译](#building-in-cmd)
- [运行与调试](#running--debugging)
  - [编码指南](#coding-guidance)
- [行为准则](#code-of-conduct)

</details>

<br />

本仓库包含以下源代码：

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal 预览版](https://aka.ms/terminal-preview)
* Windows 控制台主机 (`conhost.exe`)
* 两个项目间的共享组件
* [ColorTool](./src/tools/ColorTool)
* [示例项目](./samples)
  展示如何使用 Windows 控制台 API

相关仓库包括：

* [Windows Terminal 文档](https://docs.microsoft.com/windows/terminal)
  ([文档贡献仓库](https://github.com/MicrosoftDocs/terminal))
* [控制台 API 文档](https://github.com/MicrosoftDocs/Console-Docs)
* [Cascadia Code 字体](https://github.com/Microsoft/Cascadia-Code)

## 安装和运行 Windows Terminal

> [!NOTE]
> Windows Terminal 需要 Windows 10 2004（构建 19041）或更高版本

### Microsoft Store【推荐】

通过 [Microsoft Store 安装 Windows Terminal][store-install-link]。
这样可以确保在我们发布新版本时，您始终保持最新版本，并自动升级。

这是我们推荐的方法。

### 其他安装方法

#### 通过 GitHub

对于无法通过 Microsoft Store 安装 Windows Terminal 的用户，可以从本仓库的 [Releases 页面](https://github.com/microsoft/terminal/releases) 手动下载已发布的版本。

从 **Assets** 部分下载 `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` 文件。要安装应用，您只需双击 `.msixbundle` 文件，应用安装程序会自动运行。如果安装失败，可以在 PowerShell 提示符下尝试以下命令：

```powershell
# 注意：如果您使用的是 PowerShell 7+，请先运行
# Import-Module Appx -UseWindowsPowerShell
# 然后再使用 Add-AppxPackage。

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> 如果您手动安装 Terminal：
>
> * 可能需要安装 [VC++ v14 桌面框架包](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages)。
>   这仅在较旧的 Windows 10 版本上且提示缺少框架包时才需要。
> * Terminal 不会在新版本发布时自动更新，因此您需要定期手动安装最新版 Terminal 以获得最新修复和改进！

#### 通过 Windows 包管理器 CLI（即 winget）

[winget](https://github.com/microsoft/winget-cli) 用户可以通过安装 `Microsoft.WindowsTerminal` 包来下载并安装最新版 Terminal：

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> 依赖项支持在 WinGet 版本 [1.6.2631 或更高版本](https://github.com/microsoft/winget-cli/releases) 中可用。要安装 Terminal 稳定版 1.18 或更高版本，请确保您的 WinGet 客户端已更新。

#### 通过 Chocolatey（非官方）

[Chocolatey](https://chocolatey.org) 用户可以通过安装 `microsoft-windows-terminal` 包来下载并安装最新版 Terminal：

```powershell
choco install microsoft-windows-terminal
```

使用 Chocolatey 升级 Windows Terminal，请运行以下命令：

```powershell
choco upgrade microsoft-windows-terminal
```

如果在安装/升级软件包时遇到任何问题，请访问 [Windows Terminal 软件包页面](https://chocolatey.org/packages/microsoft-windows-terminal) 并遵循 [Chocolatey 问题处理流程](https://chocolatey.org/docs/package-triage-process)。

#### 通过 Scoop（非官方）

[Scoop](https://scoop.sh) 用户可以通过安装 `windows-terminal` 包来下载并安装最新版 Terminal：

```powershell
scoop bucket add extras
scoop install windows-terminal
```

使用 Scoop 更新 Windows Terminal，请运行以下命令：

```powershell
scoop update windows-terminal
```

如在安装/升级软件包时遇到问题，请在 Scoop Extras bucket 仓库的 [issues 页面](https://github.com/lukesampson/scoop-extras/issues) 搜索或报告相应问题。

---

## 安装 Windows Terminal Canary（金丝雀版）
Windows Terminal Canary 是 Windows Terminal 的夜间构建版本。此版本包含我们 `main` 分支上的最新代码，您可以在功能正式进入 Windows Terminal 预览版之前抢先体验。

Windows Terminal Canary 是我们最不稳定的版本，因此您可能会遇到我们尚未发现的 bug。

Windows Terminal Canary 提供 App Installer 分发版和便携式 ZIP 分发版。

App Installer 分发版支持自动更新。由于平台限制，此安装程序仅适用于 Windows 11。

便携式 ZIP 分发版是便携应用程序。它不会自动更新，也不会自动检查更新。此便携 ZIP 版本适用于 Windows 10（19041+）和 Windows 11。

| 分发方式      | 架构           | 链接                                                    |
|---------------|:---------------:|---------------------------------------------------------|
| App Installer | x64, arm64, x86 | [下载](https://aka.ms/terminal-canary-installer)        |
| 便携 ZIP      | x64             | [下载](https://aka.ms/terminal-canary-zip-x64)          |
| 便携 ZIP      | ARM64           | [下载](https://aka.ms/terminal-canary-zip-arm64)        |
| 便携 ZIP      | x86             | [下载](https://aka.ms/terminal-canary-zip-x86)          |

_了解更多 [Windows Terminal 分发类型](https://learn.microsoft.com/windows/terminal/distributions)。_

---

## Windows Terminal 路线图

Windows Terminal 的计划[详见此处](/doc/roadmap-2023.md)，项目进展时会持续更新。

## 终端与控制台概述

在深入代码之前，请先花几分钟时间阅读下面的概述：

### Windows Terminal

Windows Terminal 是一款新型、现代、功能丰富、高效的终端应用，专为命令行用户打造。它包含了 Windows 命令行社区最常请求的许多功能，包括标签页、富文本、本地化、可配置性、主题和样式等。

Terminal 还需满足我们的性能目标和标准，确保其保持快速高效，不会消耗过多内存或电量。

### Windows 控制台主机

Windows 控制台主机 `conhost.exe` 是 Windows 最初的命令行用户体验。它还承载着 Windows 的命令行基础设施和 Windows 控制台 API 服务器、输入引擎、渲染引擎、用户偏好设置等。本仓库中的控制台主机代码就是 Windows 系统中 `conhost.exe` 的实际源码。

自 2014 年负责 Windows 命令行以来，团队为控制台增加了多项新功能，包括背景透明、基于行的选择、支持 [ANSI / 虚拟终端序列](https://en.wikipedia.org/wiki/ANSI_escape_code)、[24 位色彩](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/)、[伪控制台（ConPTY）](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)等。

但由于 Windows 控制台的首要目标是保持向后兼容，我们一直无法增加社区（和团队）这些年来一直想要的许多新特性，包括标签页、Unicode 文本和表情符号等。

这些限制促使我们创建了新的 Windows Terminal。

> 您可以在命令行团队博客的[相关系列博文](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)中了解命令行的演变，特别是 Windows 命令行的发展。

### 共享组件

在重构 Windows 控制台的过程中，我们大幅现代化了其代码库，将逻辑实体整洁地划分为模块和类，引入了一些关键的可扩展点，用更安全、更高效的 [STL 容器](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) 替换了部分旧有的数据结构，并通过微软的 [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) 让代码更简单更安全。

这次重构使得控制台的多个关键组件可以被任何 Windows 终端实现所复用。这些组件包括基于 DirectWrite 的新文本布局与渲染引擎、能同时存储 UTF-16 和 UTF-8 的文本缓冲区、VT 解析器/发射器等。

### 创建新的 Windows Terminal

在规划新 Windows Terminal 应用时，我们探索并评估了多种方法和技术栈。最终我们决定，继续投资于 C++ 代码库能最好地实现我们的目标，这样不仅可以复用上述多个现代化组件于现有控制台和新终端，还能将 Terminal 的核心构建为可复用的 UI 控件，便于其他开发者集成到自己的应用中。

本仓库即包含了这些工作的成果，您可以通过 Microsoft Store 下载 Windows Terminal 应用，或[直接从本仓库 releases](https://github.com/microsoft/terminal/releases) 下载。

---

## 资源

关于 Windows Terminal 的更多信息，您可以参考以下资源：

* [命令行博客](https://devblogs.microsoft.com/commandline)
* [命令行背景系列博客](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Windows Terminal 发布： [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Windows Terminal 发布： [Build 2019 Session](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal with Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [第 54 期 - Kayla Cinnamon 和 Rich Turner 谈 DevOps 及 Windows Terminal 团队](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session: [现代 Windows 命令行：Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## 常见问题

### 我编译并运行了新终端，但它看起来和旧控制台一样

原因：您在 Visual Studio 中启动了错误的解决方案。

解决方法：请确保在 Visual Studio 中编译并部署的是 `CascadiaPackage` 项目。

> [!NOTE]
> `OpenConsole.exe` 只是本地编译的 `conhost.exe`，即经典的 Windows 控制台主机。OpenConsole 被 Windows Terminal 用于连接和与命令行应用通信（通过 [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)）。

---

## 文档

所有项目文档均位于 [aka.ms/terminal-docs](https://aka.ms/terminal-docs)。如果您希望参与文档编写，请在 [Windows Terminal 文档仓库](https://github.com/MicrosoftDocs/terminal) 提交 Pull Request。

---

## 参与贡献

我们非常期待与您——我们出色的社区——一起共建和完善 Windows Terminal！

***在您开始开发新功能/修复前***，请务必阅读并遵循我们的[贡献者指南](./CONTRIBUTING.md)，以避免重复或无效的工作。

## 与团队沟通

与团队沟通的最简单方式是通过 GitHub Issues。

请提交新问题、功能请求和建议，但**务必在创建新 Issue 前先搜索是否已存在类似的开放/关闭 Issue。**

如果您有不适合提 Issue（暂时）的疑问，可以通过 Twitter 联系我们：

* Christopher Nguyen，产品经理：
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett，工程负责人：[ @dhowett](https://twitter.com/DHowett)
* Mike Griese，高级开发者：[ @zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora，开发者：[ @cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani，开发者
* Leonard Hecker，开发者：[ @LeonardHecker](https://twitter.com/LeonardHecker)

## 开发者指南

## 先决条件

您可以通过以下两种方式之一配置您的环境以编译 Terminal：

### 使用 WinGet 配置文件

克隆仓库后，可以使用 [WinGet 配置文件](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine) 设置环境。[默认配置文件](.config/configuration.winget) 会安装 Visual Studio 2022 Community 及其它所需工具。`.config` 目录下还提供了适用于企业版和专业版 Visual Studio 2022 的其它配置文件。运行默认配置文件，您可以在资源管理器中双击文件，或运行以下命令：

```powershell
winget configure .config\configuration.winget
```

### 手动配置

* 必须运行 Windows 10 2004（构建 >= 10.0.19041.0）或更高版本才能运行 Windows Terminal
* 必须在 Windows 设置应用中[启用开发者模式](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)以本地安装和运行 Windows Terminal
* 必须安装 [PowerShell 7 或更高版本](https://github.com/PowerShell/PowerShell/releases/latest)
* 必须安装 [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
* 必须安装 [VS 2022](https://visualstudio.microsoft.com/downloads/)
* 必须通过 VS 安装器安装以下工作负载。注意：在 VS 2022 中打开解决方案时会[自动提示安装缺失组件](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/)：
  * 使用 C++ 的桌面开发
  * 通用 Windows 平台开发
  * **以下单独组件**
    * C++ (v143) 通用 Windows 平台工具
* 必须安装 [.NET Framework 目标包](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) 以编译测试项目

## 编译代码

OpenConsole.sln 可以在 Visual Studio 内编译，也可以使用 **/tools** 目录下的一组便捷脚本和工具在命令行编译：

### 在 PowerShell 中编译

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### 在 Cmd 中编译

```shell
.\tools\razzle.cmd
bcz
```

## 运行与调试

要在 VS 中调试 Windows Terminal，请右键点击 `CascadiaPackage`（在解决方案资源管理器中），进入属性。在调试菜单中，将“应用程序进程”和“后台任务进程”都改为“仅本机”。

然后您就可以通过 <kbd>F5</kbd> 构建并调试 Terminal 项目。请确保选择 "x64" 或 "x86" 平台 —— Terminal 不支持 "Any Cpu"（因为 Terminal 是 C++ 应用，而不是 C# 应用）。

> 👉 您**无法**直接运行 WindowsTerminal.exe 启动 Terminal。详情请参阅
> [#926](https://github.com/microsoft/terminal/issues/926)、
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### 编码指南

请阅读以下简要文档，了解我们的编码规范。

> 👉 如果您发现文档中缺少某些内容，欢迎在仓库任意位置为我们的文档文件贡献内容（或编写新文档）！

我们会根据需要不断完善，以便为本项目的贡献者提供有效的支持。

* [编码风格](./doc/STYLE.md)
* [代码组织](./doc/ORGANIZATION.md)
* [遗留代码库中的异常处理](./doc/EXCEPTIONS.md)
* [WIL 中与 Windows 交互的智能指针和宏](./doc/WIL.md)

---

## 行为准则

本项目采用了[Microsoft 开源行为准则][conduct-code]。详情请参见[行为准则 FAQ][conduct-FAQ]，或通过 [opencode@microsoft.com][conduct-email] 联系我们提出其他问题或建议。

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---