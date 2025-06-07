<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">更快打造堅不可摧的 UI 元件</p>

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
Storybook 是一個前端工作坊，用於在隔離環境下構建 UI 元件與頁面。成千上萬的團隊使用它來進行 UI 開發、測試與文件撰寫。更多資訊請參見 https://storybook.js.org！
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  查看 README 以獲取：<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## 目錄

- 🚀 [快速開始](#getting-started)
- 📒 [專案](#projects)
  - 🛠 [支援框架與範例](#supported-frameworks)
  - 🔗[外掛](#addons)
- 🏅 [徽章與簡報素材](#badges--presentation-materials)
- 👥 [社群](#community)
- 👏 [貢獻](#contributing)
  - 👨‍💻 [開發腳本](#development-scripts)
  - 💸 [贊助商](#sponsors)
  - 💵 [支持者](#backers)
- :memo: [授權條款](#license)

## 快速開始

請造訪 [Storybook 官方網站](https://storybook.js.org) 以了解更多 Storybook 資訊及開始使用。

### 文件

文件可於 [Storybook 文件網站](https://storybook.js.org/docs) 查閱。

### 範例

瀏覽 [元件百科全書](https://storybook.js.org/showcase) 以查看領先團隊如何使用 Storybook。

使用 [storybook.new](https://storybook.new) 可在 Stackblitz 上快速建立範例專案。

Storybook 附帶了大量用於元件設計、文件、測試、互動等的 [外掛](https://storybook.js.org/docs/configure/user-interface/storybook-addons)。Storybook 的 API 允許以多種方式進行配置和擴展。它甚至已擴展至支援 React Native、Android、iOS 及 Flutter 行動端開發。

### 社群

如需更多協助，請在 [本倉庫的 GitHub Discussions](https://github.com/storybookjs/storybook/discussions/new?category=help) 發問。

## 專案

### 支援框架

| 渲染器                                                         | 範例                                                                                                                                                                            |                                                                                                                                                           |
| -------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)             | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                              |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)           | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                      |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)              | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                               |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/)    | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                           |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                        | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)         |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)              | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                                 |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                               | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                            |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)            | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                           |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)            | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                           |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                       | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik)     |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                              | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                         |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                              | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                           |

### 外掛

| 外掛                                                                         | 說明                                                                         |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                  | 在 Storybook 中測試元件的無障礙性                                            |
| [actions](code/core/src/actions/)                                          | 當用戶與元件互動時記錄動作                                                  |
| [backgrounds](code/core/src/backgrounds)                                   | 讓用戶可在 Storybook UI 中選擇背景                                           |
| [cssresources](https://github.com/storybookjs/addon-cssresources)          | 動態為元件 iframe 增減 CSS 資源                                             |
| [design assets](https://github.com/storybookjs/addon-design-assets)        | 與您的故事一同查看圖片、影片及網頁連結                                       |
| [docs](code/addons/docs/)                                                  | 為元件添加高品質文件                                                        |
| [events](https://github.com/storybookjs/addon-events)                      | 互動觸發可回應 EventEmitter 的元件事件                                       |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics)  | 提供故事的 Google Analytics 報告                                             |
| [graphql](https://github.com/storybookjs/addon-graphql)                    | 在 Storybook 故事中查詢 GraphQL 伺服器                                       |
| [jest](code/addons/jest/)                                                  | 在 Storybook 中查看元件單元測試結果                                          |
| [links](code/addons/links/)                                                | 在故事間建立連結                                                            |
| [measure](code/core/src/measure/)                                          | 在 Storybook UI 中視覺化檢查版面與盒模型                                     |
| [outline](code/core/src/outline/)                                          | 在 Storybook UI 中視覺化除錯 CSS 版面與對齊                                  |
| [query params](https://github.com/storybookjs/addon-queryparams)           | 模擬查詢參數                                                                |
| [viewport](code/core/src/viewport/)                                        | 變更顯示尺寸與版面以測試響應式元件                                           |

請參閱 [外掛／框架支援表](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

為了持續優化您的體驗，我們最終將淘汰或移除部分外掛，以支持新的更佳工具。

如果您正在使用 info/notes，我們強烈建議您遷移到 [docs](code/addons/docs/)，[這裡有指引](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) 可協助您。

如果您正在使用 contexts，強烈建議遷移至 [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars)，[指引請參閱這裡](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts)。

如果您正在使用 addon-storyshots，建議您遷移至 Storybook 的 [test-runner](https://github.com/storybookjs/test-runner)，[這裡有指引](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) 可協助您。

## 徽章與簡報素材

我們有專屬徽章！將它連結至您的 Storybook 線上範例。

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](連結到您的網站)
```

若您需要 Storybook 簡報素材，如標誌、影片素材及配色，可在我們的 [品牌倉庫](https://github.com/storybookjs/brand) 找到。

## 社群

- 在 [@storybookjs](https://x.com/storybookjs) 發推文
- 在 [storybook.js.org](https://storybook.js.org/blog/) 及 [Medium](https://medium.com/storybookjs) 撰寫部落格
- 於 [Discord](https://discord.gg/storybook) 即時聊天
- 在 [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg) 看影片與直播

## 貢獻

我們歡迎所有對 Storybook 的貢獻！

- 📥 歡迎 Pull requests 與 🌟 Star。
- 請參閱 [貢獻指南](CONTRIBUTING.md) 開始貢獻，
  或加入 [Discord](https://discord.gg/storybook) 與我們聯繫，我們會指導您。

想找第一個適合著手的議題？

- 當我們認為某議題適合新手或初次參與開源專案時，會加上 [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) 標籤。
- [聯繫我們](https://discord.gg/storybook)，我們會協助您找到合適的議題。

### 開發腳本

Storybook 採用 monorepo 組織。常用腳本包含：

#### `yarn start`

> 執行沙盒模板 Storybook，內含測試故事

#### `yarn task`

> 同上，但可自訂沙盒選項（如選擇其他框架）

#### `yarn lint`

> 布林檢查程式碼是否符合 lint 規則－使用 remark 與 eslint

- `yarn lint:js` - 檢查 js
- `yarn lint:md` - 檢查 markdown + 程式碼範例
- `yarn lint:js --fix` - 自動修復 js

#### `yarn test`

> 布林檢查所有單元測試是否通過－使用 jest

- `yarn run test --core --watch` - 以 watch 模式執行核心測試

### 贊助商

成為贊助商，您的徽標與網站網址將顯示於我們的 Github README。 \[[成為贊助商](https://opencollective.com/storybook#sponsor)]

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

透過定期捐款，您可以支持我們與我們的工作。 \[[成為支持者](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## 授權條款

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-the end-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---