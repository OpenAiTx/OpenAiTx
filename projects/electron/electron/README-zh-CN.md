[![Electron Logo](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions Build Status](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord Invite](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: 可用翻译版本：🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪。
在我们的 [Crowdin](https://crowdin.com/project/electron) 项目中以其他语言查看这些文档。

Electron 框架允许您使用 JavaScript、HTML 和 CSS 编写跨平台桌面应用程序。它基于 [Node.js](https://nodejs.org/) 和 [Chromium](https://www.chromium.org)，并被 [Visual Studio Code](https://github.com/Microsoft/vscode/) 以及许多其他 [应用](https://electronjs.org/apps) 所使用。

在 Twitter 上关注 [@electronjs](https://twitter.com/electronjs) 以获取重要公告。

本项目遵循 Contributor Covenant 的[行为准则](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md)。参与时，您需要遵守该准则。如遇不可接受的行为，请报告至 [coc@electronjs.org](mailto:coc@electronjs.org)。

## 安装

要安装预编译的 Electron 二进制文件，请使用 [`npm`](https://docs.npmjs.com/)。推荐的方法是在您的应用中将 Electron 作为开发依赖安装：

```sh
npm install electron --save-dev
```

有关更多安装选项和故障排除建议，请参阅[安装说明](docs/tutorial/installation.md)。关于如何在您的应用中管理 Electron 版本的信息，请参阅[Electron 版本管理](docs/tutorial/electron-versioning.md)。

## 平台支持

每个 Electron 版本都为 macOS、Windows 和 Linux 提供二进制文件。

* macOS（Big Sur 及以上）：Electron 为 macOS 提供 64 位 Intel 及 Apple Silicon / ARM 二进制文件。
* Windows（Windows 10 及以上）：Electron 为 Windows 提供 `ia32`（`x86`）、`x64`（`amd64`）和 `arm64` 二进制文件。Windows on ARM 支持从 Electron 5.0.8 开始添加。对 Windows 7、8 和 8.1 的支持已在 Electron 23 中[移除，符合 Chromium 的 Windows 弃用政策](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice)。
* Linux：Electron 的预编译二进制文件基于 Ubuntu 20.04 构建。经过验证也可在以下系统运行：
  * Ubuntu 18.04 及以上
  * Fedora 32 及以上
  * Debian 10 及以上

## Electron Fiddle

使用 [`Electron Fiddle`](https://github.com/electron/fiddle) 来构建、运行和打包小型 Electron 实验，查看所有 Electron API 的代码示例，并尝试不同版本的 Electron。它旨在让您更轻松地开始 Electron 之旅。

## 学习 Electron 的资源

* [electronjs.org/docs](https://electronjs.org/docs) - Electron 全部文档
* [electron/fiddle](https://github.com/electron/fiddle) - 构建、运行和打包小型 Electron 实验的工具
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - 由社区创建的示例启动应用

## 编程方式使用

大多数人通过命令行使用 Electron，但如果您在**Node 应用**（而非 Electron 应用）中 require `electron`，它会返回二进制文件路径。可以用它在 Node 脚本中启动 Electron：

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// 会打印类似于 /Users/maf/.../Electron 的内容
console.log(electron)

// 启动 Electron
const child = proc.spawn(electron)
```

### 镜像

* [中国](https://npmmirror.com/mirrors/electron/)

查看[高级安装说明](https://www.electronjs.org/docs/latest/tutorial/installation#mirror)以了解如何使用自定义镜像。

## 文档翻译

我们通过 [Crowdin](https://crowdin.com/project/electron) 众包方式为我们的文档进行翻译。目前我们接受简体中文、法语、德语、日语、葡萄牙语、俄语和西班牙语的翻译。

## 贡献

如果您有兴趣报告/修复问题并直接为代码库做出贡献，请参阅 [CONTRIBUTING.md](CONTRIBUTING.md) 以获取我们所需内容及如何开始的更多信息。

## 社区

关于报告 bug、获取帮助、查找第三方工具和示例应用等信息，请访问[社区页面](https://www.electronjs.org/community)。

## 许可证

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

使用 Electron 标志时，请确保遵守 [OpenJS 基金会商标政策](https://trademark-policy.openjsf.org/)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---