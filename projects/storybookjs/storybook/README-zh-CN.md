<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">更快构建坚如磐石的 UI 组件</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook 是一个用于在隔离环境下构建 UI 组件和页面的前端工作台。数千个团队使用它进行 UI 开发、测试和文档编写。访问 https://storybook.js.org 了解更多！
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  查看以下版本的 README：<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## 目录

- 🚀 [快速开始](#getting-started)
- 📒 [项目](#projects)
  - 🛠 [支持的框架与示例](#supported-frameworks)
  - 🔗[插件](#addons)
- 🏅 [徽章与演示资料](#badges--presentation-materials)
- 👥 [社区](#community)
- 👏 [贡献](#contributing)
  - 👨‍💻 [开发脚本](#development-scripts)
  - 💸 [赞助商](#sponsors)
  - 💵 [支持者](#backers)
- :memo: [许可证](#license)

## 快速开始

访问 [Storybook 官网](https://storybook.js.org) 了解 Storybook 并开始使用。

### 文档

文档可在 [Storybook 文档站点](https://storybook.js.org/docs) 找到。

### 示例

查看 [组件百科全书](https://storybook.js.org/showcase) 了解领先团队如何使用 Storybook。

使用 [storybook.new](https://storybook.new) 可在 Stackblitz 上快速创建示例项目。

Storybook 提供大量[插件](https://storybook.js.org/docs/configure/user-interface/storybook-addons)，用于组件设计、文档、测试、交互等。Storybook 的 API 支持多种配置和扩展方式。甚至已经扩展支持 React Native、Android、iOS 和 Flutter 等移动端开发。

### 社区

如需帮助，请在[仓库的 GitHub Discussions](https://github.com/storybookjs/storybook/discussions/new?category=help)中提出你的问题。

## 项目

### 支持的框架

| 渲染器                                                        | 示例演示                                                                                                                                                                      |                                                                                                                                                        |
| ------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [React](code/renderers/react)                                 | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)           | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                           |
| [Angular](code/frameworks/angular/)                           | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)         | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                   |
| [Vue 3](code/renderers/vue3)                                 | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)            | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                            |
| [Web components](code/renderers/web-components)               | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                        |
| [React Native](https://github.com/storybookjs/react-native)   | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                      | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)      |
| [HTML](code/renderers/html)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)            | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                              |
| [Ember](code/frameworks/ember/)                               | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                             | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                         |
| [Svelte](code/renderers/svelte)                               | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)          | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                        |
| [Preact](code/renderers/preact)                               | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)          | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                        |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                     | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik)  |
| [SolidJS](https://github.com/storybookjs/solidjs)             | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                            | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                      |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                        |

### 插件

| 插件                                                                       | 简介                                                                      |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------ |
| [a11y](code/addons/a11y/)                                                 | 在 Storybook 中测试组件的可访问性                                        |
| [actions](code/core/src/actions/)                                         | 当用户与组件交互时，在 Storybook UI 中记录操作                           |
| [backgrounds](code/core/src/backgrounds)                                  | 允许用户在 Storybook UI 中选择背景                                       |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | 动态为组件 iframe 添加/移除 CSS 资源                                     |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | 在故事旁边查看图片、视频和网页链接                                       |
| [docs](code/addons/docs/)                                                 | 为你的组件添加高质量的文档                                               |
| [events](https://github.com/storybookjs/addon-events)                     | 交互式地向响应 EventEmitter 的组件触发事件                               |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | 在故事中报告 Google Analytics 数据                                       |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | 在 Storybook 故事中查询 GraphQL 服务器                                   |
| [jest](code/addons/jest/)                                                 | 在 Storybook 中查看组件单元测试结果                                      |
| [links](code/addons/links/)                                               | 在故事之间创建链接                                                       |
| [measure](code/core/src/measure/)                                         | 在 Storybook UI 中可视化检查布局和盒模型                                 |
| [outline](code/core/src/outline/)                                         | 在 Storybook UI 中可视化调试 CSS 布局和对齐                              |
| [query params](https://github.com/storybookjs/addon-queryparams)          | 模拟查询参数                                                             |
| [viewport](code/core/src/viewport/)                                       | 使用 Storybook 更改组件的显示尺寸和布局以适配响应式                      |

详见 [插件/框架支持表](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

为持续优化你的体验，我们最终会弃用或移除某些插件，以支持更新更好的工具。

如果你正在使用 info/notes 插件，强烈建议迁移到 [docs](code/addons/docs/)，[这里有迁移指南](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons)。

如果你正在使用 contexts 插件，强烈建议迁移到 [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars)，[这里有迁移指南](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts)。

如果你正在使用 addon-storyshots，强烈建议迁移到 Storybook [test-runner](https://github.com/storybookjs/test-runner)，[这里有迁移指南](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide)。

## 徽章与演示资料

我们有徽章！可将其链接到你的 Storybook 示例页面。

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](link to site)
```

如果你在做 Storybook 演示，需要徽标、视频素材或我们使用的配色等资料，可在我们的 [品牌仓库](https://github.com/storybookjs/brand) 获取。

## 社区

- 在 [@storybookjs](https://x.com/storybookjs) 上推文
- 在 [storybook.js.org](https://storybook.js.org/blog/) 和 [Medium](https://medium.com/storybookjs) 撰写博客
- 在 [Discord](https://discord.gg/storybook) 聊天
- 在 [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg) 看视频与直播

## 贡献

欢迎为 Storybook 做贡献！

- 📥 欢迎 Pull Request 和 🌟 Star。
- 阅读我们的 [贡献指南](CONTRIBUTING.md) 开始参与，
  或在 [Discord](https://discord.gg/storybook) 联系我们，我们会耐心指导你。

想找第一个适合入门的问题？

- 我们用 [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) 标签标记了适合新手或 OSS 新人的问题。
- [联系我们](https://discord.gg/storybook)，我们会帮你找到适合你技能和兴趣的问题。

### 开发脚本

Storybook 采用 monorepo 组织。常用脚本包括：

#### `yarn start`

> 运行带有测试故事的沙盒模板 storybook

#### `yarn task`

> 同上，但可自定义沙盒（如选择其他框架）

#### `yarn lint`

> 检查代码是否符合 lint 规则 - 使用 remark & eslint

- `yarn lint:js` - 检查 js
- `yarn lint:md` - 检查 markdown 和代码示例
- `yarn lint:js --fix` - 自动修复 js

#### `yarn test`

> 检查所有单元测试是否通过 - 使用 jest

- `yarn run test --core --watch` - 以 watch 模式运行核心测试

### 赞助商

成为赞助商，你的 Logo 和网站链接将显示在我们的 Github README 上。 \[[成为赞助商](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### 支持者

通过持续捐赠，你可以支持我们和我们的工作。 \[[成为支持者](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## 许可证

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-the end-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---