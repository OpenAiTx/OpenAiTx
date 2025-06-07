<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## 简介

Tauri 是一个用于为所有主流桌面平台构建小巧、极快二进制文件的框架。开发者可以集成任何可编译为 HTML、JS 和 CSS 的前端框架来构建用户界面。应用程序的后端是一个由 Rust 编写的二进制文件，并提供前端可以交互的 API。

Tauri 应用的用户界面目前使用 [`tao`](https://docs.rs/tao) 作为 macOS、Windows、Linux、Android 和 iOS 的窗口处理库。为了渲染应用程序，Tauri 使用 [WRY](https://github.com/tauri-apps/wry) 库，该库为系统 webview 提供统一接口，在 macOS 和 iOS 上使用 WKWebView，在 Windows 上使用 WebView2，在 Linux 上使用 WebKitGTK，在 Android 上使用 Android System WebView。

要了解这些组件如何协同工作的详细信息，请参阅此 [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) 文档。

## 入门

如果你有兴趣开发 tauri 应用，请访问 [文档网站](https://tauri.app)。

最快的入门方式是为你的系统安装 [前置条件](https://v2.tauri.app/start/prerequisites/)，并使用 [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage) 创建新项目。例如，使用 `npm`：

```sh
npm create tauri-app@latest
```

## 功能

Tauri 的功能列表包括但不限于：

- 内置应用打包工具，可生成 `.app`、`.dmg`、`.deb`、`.rpm`、`.AppImage` 等格式的应用包，以及 Windows 安装包如 `.exe`（通过 NSIS）和 `.msi`（通过 WiX）。
- 内置自更新功能（仅限桌面端）
- 系统托盘图标
- 原生通知
- 原生 WebView 协议（tauri 不会创建 localhost http(s) 服务器来服务 WebView 内容）
- 用于简化 CI 的 GitHub Action
- VS Code 扩展

### 支持平台

Tauri 目前支持在以下平台上开发和分发：

| 平台       | 版本                                                                                              |
| :--------- | :------------------------------------------------------------------------------------------------ |
| Windows    | 7 及以上                                                                                           |
| macOS      | 10.15 及以上                                                                                       |
| Linux      | Tauri v1 需 webkit2gtk 4.0（如 Ubuntu 18.04），Tauri v2 需 webkit2gtk 4.1（如 Ubuntu 22.04）        |
| iOS/iPadOS | 9 及以上                                                                                           |
| Android    | 7 及以上（目前为 8 及以上）                                                                       |

## 贡献

在你开始进行开发之前，最好先检查是否已经有相关的 issue。也建议先到 Discord 服务器与团队确认你的想法是否合理，或者是否已有其他人正在进行相关工作。

在提交 pull request 之前，请务必阅读 [贡献指南](./.github/CONTRIBUTING.md)。

感谢所有为 Tauri 做出贡献的人！

### 文档

在多语言系统中编写文档是一项挑战。为此，我们倾向于尽可能在 Rust 和 JS 源代码中使用内联文档。更多信息请访问文档站点的托管仓库：<https://github.com/tauri-apps/tauri-docs>

## 合作伙伴

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

完整赞助商名单请访问我们的 [网站](https://tauri.app#sponsors) 和 [Open Collective](https://opencollective.com/tauri)。

## 组织

Tauri 致力于成为一个可持续发展的集体，遵循 [可持续自由与开源软件社区](https://sfosc.org) 的原则。为此，它已成为 [Commons Conservancy](https://commonsconservancy.org/) 下的一个项目，你可以通过 [Open Collective](https://opencollective.com/tauri) 进行资金支持。

## 许可证

代码：(c) 2015 - 至今 - The Commons Conservancy 下的 Tauri Programme。

MIT 或在适用情况下 MIT/Apache 2.0。

Logo：CC-BY-NC-ND

- 原始 Tauri Logo 设计由 [Alve Larsson](https://alve.io/)、[Daniel Thompson-Yvetot](https://github.com/nothingismagick) 和 [Guillaume Chau](https://github.com/akryum) 创作

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---