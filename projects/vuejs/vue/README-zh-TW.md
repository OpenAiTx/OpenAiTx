## Vue 2 已達到生命週期終止（End of Life）

**您目前正在查看 Vue 2 的非活躍倉庫。Vue 最新版本的活躍維護倉庫為 [vuejs/core](https://github.com/vuejs/core)。**

Vue 已於 2023 年 12 月 31 日達到生命週期終止。它不再接收新功能、更新或修復。然而，現有的所有發佈管道（CDN、套件管理器、Github 等）仍可取得。

如果您正開始新的專案，請直接使用 Vue 的最新版本（3.x）。我們也強烈建議目前的 Vue 2 用戶升級（[升級指南](https://v3-migration.vuejs.org/)），但我們也理解並非所有用戶都有升級的時間或動機。如果您必須繼續使用 Vue 2，且對於未維護軟體有合規或安全需求，請參考 [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme)。

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## 贊助商

Vue.js 是一個採用 MIT 授權的開源專案，持續開發完全仰賴這些出色的 [贊助者](https://github.com/vuejs/core/blob/main/BACKERS.md) 支持。如果您願意加入他們的行列，請考慮[贊助 Vue 的發展](https://vuejs.org/sponsor/)。

<p align="center">
  <h3 align="center">特別贊助</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## 介紹

Vue（發音為 `/vjuː/`，同 view）是一個**漸進式框架**，用於構建使用者介面。它從零開始設計，易於逐步採用，並可根據不同使用場景，在函式庫與框架之間輕鬆擴展。它由一個專注於視圖層的易上手核心函式庫，以及一組輔助函式庫生態系所組成，協助您處理大型單頁應用（SPA）的複雜性。

#### 瀏覽器相容性

Vue.js 支援所有 [ES5 相容](https://compat-table.github.io/compat-table/es5/) 的瀏覽器（不支援 IE8 及以下版本）。

## 生態系

| 專案                   | 狀態                                                       | 說明                                                        |
| --------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                 | 單頁應用的路由處理                                          |
| [vuex]                | [![vuex-status]][vuex-package]                             | 大型狀態管理                                                |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                       | 專案腳手架                                                  |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                 | webpack 專用的單檔組件（`*.vue` 檔案）載入器                |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | 伺服器端渲染支援                                            |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | 基於類別 API 的 TypeScript 裝飾器                          |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                         | RxJS 整合                                                   |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]             | 瀏覽器開發者工具擴充套件                                    |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## 文件

如需查看[線上範例](https://v2.vuejs.org/v2/examples/)及文件，請造訪 [vuejs.org](https://v2.vuejs.org)。

## 問題討論

如有疑問或需支援，請使用[官方論壇](https://forum.vuejs.org)或[社群聊天室](https://chat.vuejs.org/)。本倉庫的 issues 僅用於回報錯誤與功能請求。

## 問題回報

請務必在提出 Issue 前閱讀 [問題回報檢查清單](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines)。不符合指引的 Issue 可能會被立即關閉。

## 更新日誌

每個版本的詳細變更記錄請參見 [發佈說明](https://github.com/vuejs/vue/releases)。

## 保持聯絡

- [Twitter](https://twitter.com/vuejs)
- [部落格](https://medium.com/the-vue-point)
- [職缺公告板](https://vuejobs.com/?ref=vuejs)

## 貢獻

請務必在提交 Pull Request 前閱讀 [貢獻指南](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md)。如果您有 Vue 相關的專案、組件或工具，歡迎透過 Pull Request 加入[這份精選清單](https://github.com/vuejs/awesome-vue)！

感謝所有已經為 Vue 作出貢獻的朋友！

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## 授權

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-present, Yuxi (Evan) You

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---