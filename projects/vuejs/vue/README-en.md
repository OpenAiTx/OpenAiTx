## Vue 2 已经停止维护

**您正在查看 Vue 2 的非活跃仓库。Vue 最新版本的活跃维护仓库为 [vuejs/core](https://github.com/vuejs/core)。**

Vue 于 2023 年 12 月 31 日停止维护。不再接收新特性、更新或修复。但它仍然可通过所有现有分发渠道（CDN、包管理器、Github 等）获取。

如果您要启动新项目，请使用 Vue 的最新版本（3.x）。我们也强烈建议现有 Vue 2 用户升级（[升级指南](https://v3-migration.vuejs.org/)），但我们也理解并非所有用户都有精力或动力进行升级。如果您必须继续使用 Vue 2，并且有关于未维护软件的合规或安全要求，请参考 [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme)。

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## 赞助商

Vue.js 是一个遵循 MIT 许可的开源项目，其持续开发完全得益于这些出色的 [支持者](https://github.com/vuejs/core/blob/main/BACKERS.md)。如果您希望加入他们，请考虑[赞助 Vue 的开发](https://vuejs.org/sponsor/)。

<p align="center">
  <h3 align="center">特别赞助商</h3>
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

## 简介

Vue（发音为 `/vjuː/`，类似于 view）是一个用于构建用户界面的**渐进式框架**。它从一开始就被设计为可以逐步采用，并且可以根据不同的使用场景，在库和框架之间灵活扩展。它包含一个只关注视图层的易上手核心库，以及一个帮助您应对大型单页应用复杂性的配套库生态系统。

#### 浏览器兼容性

Vue.js 支持所有[符合 ES5 标准](https://compat-table.github.io/compat-table/es5/)的浏览器（不支持 IE8 及以下）。

## 生态系统

| 项目                   | 状态                                                           | 描述                                                     |
| --------------------- | ------------------------------------------------------------ | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | 单页应用路由                                             |
| [vuex]                | [![vuex-status]][vuex-package]                               | 大型项目状态管理                                         |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | 项目脚手架                                               |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | webpack 的单文件组件（`*.vue` 文件）加载器               |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | 服务端渲染支持                                           |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | 基于类的 TypeScript 装饰器 API                          |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | RxJS 集成                                               |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | 浏览器开发者工具扩展                                     |

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

## 文档

要查看[在线示例](https://v2.vuejs.org/v2/examples/)和文档，请访问 [vuejs.org](https://v2.vuejs.org)。

## 问题答疑

如需提问和获得支持，请使用[官方论坛](https://forum.vuejs.org)或[社区聊天](https://chat.vuejs.org/)。本仓库的 issue 列表**仅限**于 bug 报告和新特性请求。

## 问题反馈

在提交 issue 前，请务必阅读 [Issue 报告检查表](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines)。不符合规范的问题可能会被立即关闭。

## 更新日志

每个版本的详细更改记录在[发布说明](https://github.com/vuejs/vue/releases)中。

## 保持联系

- [Twitter](https://twitter.com/vuejs)
- [博客](https://medium.com/the-vue-point)
- [招聘板](https://vuejobs.com/?ref=vuejs)

## 贡献

在发起 Pull Request 前，请务必阅读[贡献指南](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md)。如果你有与 Vue 相关的项目/组件/工具，请通过 Pull Request 把它添加到[这个精选列表](https://github.com/vuejs/awesome-vue)！

感谢所有已经为 Vue 做出贡献的人！

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## 许可证

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-present, Yuxi (Evan) You

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---