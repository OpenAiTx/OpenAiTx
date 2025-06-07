<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  精致、直观且强大的前端框架，让网页开发更快更简单。
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>探索 Bootstrap 文档 »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">报告 Bug</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">请求新功能</a>
  ·
  <a href="https://themes.getbootstrap.com/">主题</a>
  ·
  <a href="https://blog.getbootstrap.com/">博客</a>
</p>


## Bootstrap 5

我们的默认分支用于 Bootstrap 5 版本的开发。请前往 [`v4-dev` 分支](https://github.com/twbs/bootstrap/tree/v4-dev) 查看 Bootstrap 4 的自述文件、文档及源代码。


## 目录

- [快速开始](#quick-start)
- [状态](#status)
- [包含内容](#whats-included)
- [Bug 和功能请求](#bugs-and-feature-requests)
- [文档](#documentation)
- [参与贡献](#contributing)
- [社区](#community)
- [版本管理](#versioning)
- [创作者](#creators)
- [致谢](#thanks)
- [版权和许可](#copyright-and-license)


## 快速开始

提供多种快速开始方式：

- [下载最新发布版本](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- 克隆仓库：`git clone https://github.com/twbs/bootstrap.git`
- 使用 [npm](https://www.npmjs.com/) 安装：`npm install bootstrap@v5.3.6`
- 使用 [yarn](https://yarnpkg.com/) 安装：`yarn add bootstrap@v5.3.6`
- 使用 [Bun](https://bun.sh/) 安装：`bun add bootstrap@v5.3.6`
- 使用 [Composer](https://getcomposer.org/) 安装：`composer require twbs/bootstrap:5.3.6`
- 使用 [NuGet](https://www.nuget.org/) 安装：CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

阅读 [入门页面](https://getbootstrap.com/docs/5.3/getting-started/introduction/)，了解框架内容、模板、示例等信息。


## 状态

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## 包含内容

在下载包中，你会看到如下目录和文件，对常用资源进行了逻辑分组，并同时提供了编译和压缩后的版本。

<details>
  <summary>下载内容</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

我们提供了已编译的 CSS 和 JS 文件（`bootstrap.*`），以及编译和压缩后的 CSS 和 JS 文件（`bootstrap.min.*`）。[Source map](https://web.dev/articles/source-maps) 文件（`bootstrap.*.map`）可与部分浏览器开发者工具配合使用。捆绑的 JS 文件（`bootstrap.bundle.js` 及其压缩版 `bootstrap.bundle.min.js`）包含了 [Popper](https://popper.js.org/docs/v2/)。


## Bug 和功能请求

有 Bug 或功能请求？请先阅读 [问题提交指南](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) 并搜索现有和已关闭的问题。如果你的问题或想法尚未被解决，[请新建一个 issue](https://github.com/twbs/bootstrap/issues/new/choose)。


## 文档

Bootstrap 的文档包含在本仓库根目录下，使用 [Astro](https://astro.build/) 构建，并托管在 GitHub Pages 上：<https://getbootstrap.com/>。文档也可以在本地运行。

文档搜索由 [Algolia 的 DocSearch](https://docsearch.algolia.com/) 提供支持。

### 本地运行文档

1. 执行 `npm install` 安装 Node.js 依赖，包括站点生成器 Astro。
2. 执行 `npm run test`（或指定 npm 脚本）以重新构建分发的 CSS 和 JavaScript 文件，以及文档资源。
3. 在 `/bootstrap` 根目录下，命令行运行 `npm run docs-serve`。
4. 在浏览器中打开 `http://localhost:9001/`，即可访问。

阅读 Astro 的 [文档](https://docs.astro.build/en/getting-started/)，了解更多用法。

### 历史版本文档

所有历史版本文档可在 <https://getbootstrap.com/docs/versions/> 查找。

[历史发布版本](https://github.com/twbs/bootstrap/releases)及其文档也可下载。


## 参与贡献

请阅读我们的 [贡献指南](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md)。其中包括提交 issue、编码规范和开发说明。

此外，如果你的 Pull Request 包含 JavaScript 补丁或新功能，必须包含[相关单元测试](https://github.com/twbs/bootstrap/tree/main/js/tests)。所有 HTML 和 CSS 应遵循 [代码规范指南](https://github.com/mdo/code-guide)，由 [Mark Otto](https://github.com/mdo) 维护。

编辑器偏好设置详见 [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig)，便于在常见文本编辑器中使用。更多信息及插件下载请访问 <https://editorconfig.org/>。


## 社区

关注 Bootstrap 开发动态，与项目维护者和社区成员交流。

- 关注 [@getbootstrap on X](https://x.com/getbootstrap)。
- 阅读并订阅 [官方 Bootstrap 博客](https://blog.getbootstrap.com/)。
- 提问与交流请访问 [我们的 GitHub Discussions](https://github.com/twbs/bootstrap/discussions)。
- 在 [社区 Discord](https://discord.gg/bZUvakRU3M) 或 [Bootstrap subreddit](https://www.reddit.com/r/bootstrap/) 讨论、提问等。
- 在 IRC 与其他 Bootstrappers 聊天。服务器：`irc.libera.chat`，频道：`#bootstrap`。
- 可在 Stack Overflow（标签为 [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)）寻求实现帮助。
- 开发者在通过 [npm](https://www.npmjs.com/browse/keyword/bootstrap) 或类似分发机制发布扩展或增强 Bootstrap 功能的软件包时，请使用 `bootstrap` 关键字，以便被更好地发现。


## 版本管理

为确保发布周期透明并努力保持向后兼容性，Bootstrap 遵循 [语义化版本号规范](https://semver.org/)。有时我们也会犯错，但会尽量遵守这些规则。

各版本的变更日志请参见 [GitHub 项目的 Releases 区域](https://github.com/twbs/bootstrap/releases)。每次发布的要点总结会在 [官方 Bootstrap 博客](https://blog.getbootstrap.com/) 公布。


## 创作者

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## 致谢

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

感谢 [BrowserStack](https://www.browserstack.com/) 提供的基础设施，助力我们在真实浏览器中进行测试！

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

感谢 [Netlify](https://www.netlify.com/) 为我们提供部署预览！


## 赞助商

通过成为赞助商支持本项目。您的 Logo 将显示在此，并链接至您的网站。[[成为赞助商](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## 支持者

感谢所有支持者！🙏 [[成为支持者](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## 版权和许可

代码和文档版权归 2011-2025 [Bootstrap 作者](https://github.com/twbs/bootstrap/graphs/contributors) 所有。代码遵循 [MIT 许可协议](https://github.com/twbs/bootstrap/blob/main/LICENSE) 发布。文档遵循 [知识共享协议](https://creativecommons.org/licenses/by/3.0/) 发布。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---