<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## 介紹

Tauri 是一個用於為所有主流桌面平台構建極小、極快二進位檔的框架。開發者可以整合任何可編譯成 HTML、JS 和 CSS 的前端框架來建立使用者介面。應用程式的後端是一個以 Rust 撰寫的二進位檔，並提供 API 讓前端進行互動。

Tauri 應用程式的使用者介面目前在 macOS、Windows、Linux、Android 和 iOS 上利用 [`tao`](https://docs.rs/tao) 作為視窗處理函式庫。為了呈現您的應用程式，Tauri 使用 [WRY](https://github.com/tauri-apps/wry)，這是一個提供統一介面給系統 WebView 的函式庫，分別在 macOS & iOS 使用 WKWebView、在 Windows 使用 WebView2、在 Linux 使用 WebKitGTK，以及在 Android 使用 Android System WebView。

如需了解這些組件如何整合，請參閱此 [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) 文件。

## 快速開始

如果您有興趣開發 tauri 應用程式，請造訪[官方文件網站](https://tauri.app)。

最快的入門方式是先為您的系統安裝[必要條件](https://v2.tauri.app/start/prerequisites/)，然後使用 [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage) 建立新專案。例如使用 `npm`：

```sh
npm create tauri-app@latest
```

## 功能特色

Tauri 的功能包含但不限於：

- 內建應用程式打包工具，可產生 `.app`、`.dmg`、`.deb`、`.rpm`、`.AppImage` 等格式的應用程式包，以及 Windows 安裝程式如 `.exe`（透過 NSIS）和 `.msi`（透過 WiX）。
- 內建自動更新功能（僅限桌面）
- 系統匣圖示
- 原生通知
- 原生 WebView 協定（tauri 不會建立 localhost http(s) 伺服器來提供 WebView 內容）
- GitHub Action 以優化 CI 流程
- VS Code 擴充功能

### 支援平台

Tauri 目前支援在以下平台進行開發與發佈：

| 平台       | 版本                                                                                                              |
| :--------- | :---------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 及以上                                                                                                          |
| macOS      | 10.15 及以上                                                                                                      |
| Linux      | Tauri v1 需 webkit2gtk 4.0（例如 Ubuntu 18.04）。Tauri v2 需 webkit2gtk 4.1（例如 Ubuntu 22.04）。                |
| iOS/iPadOS | 9 及以上                                                                                                          |
| Android    | 7 及以上（目前為 8 及以上）                                                                                       |

## 貢獻指南

在開始進行開發之前，建議先檢查是否已存在相關議題。也建議先到 Discord 伺服器與團隊確認想法是否合理，或是否已有其他人正在進行。

請在送出 pull request 前務必閱讀 [貢獻指南](./.github/CONTRIBUTING.md)。

感謝所有為 Tauri 做出貢獻的人！

### 文件

在多語系系統中維護文件是一項挑戰。為此，我們傾向於盡可能在 Rust 及 JS 原始碼中使用內嵌文件。欲知更多資訊，請參閱文件網站的主存放庫：<https://github.com/tauri-apps/tauri-docs>

## 合作夥伴

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

完整贊助者名單請參閱我們的[網站](https://tauri.app#sponsors)及 [Open Collective](https://opencollective.com/tauri)。

## 組織

Tauri 旨在成為一個以[可持續自由及開源軟體社群](https://sfosc.org)原則為指導的永續集體。為此，Tauri 已成為 [Commons Conservancy](https://commonsconservancy.org/) 計畫的一部分，您也可以透過 [Open Collective](https://opencollective.com/tauri) 進行財務支持。

## 授權

程式碼： (c) 2015 - 現在 - The Commons Conservancy 內的 Tauri 計畫。

MIT 或 MIT/Apache 2.0（視情況適用）。

標誌：CC-BY-NC-ND

- 原始 Tauri 標誌設計者：[Alve Larsson](https://alve.io/)、[Daniel Thompson-Yvetot](https://github.com/nothingismagick) 及 [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---