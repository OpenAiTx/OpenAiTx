## Create React App [![构建与测试](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![欢迎 PR](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## 已弃用
>
> Create React App 曾是 2017-2021 年启动 React 项目的关键工具之一，现在已进入长期维护阶段，我们建议你迁移到 [开始新的 React 项目](https://react.dev/learn/start-a-new-react-project) 文档中列出的某个 React 框架。
>
> 如果你正在跟随教程学习 React，继续完成你的教程依然有价值，但我们不建议基于 Create React App 启动生产级应用。

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

无需构建配置即可创建 React 应用。

- [创建应用](#creating-an-app) – 如何创建一个新应用。
- [用户指南](https://facebook.github.io/create-react-app/) – 如何开发通过 Create React App 引导的应用。

Create React App 可在 macOS、Windows 和 Linux 上运行。<br>
如果遇到问题，请[提交 Issue](https://github.com/facebook/create-react-app/issues/new)。<br>
如有疑问或需要帮助，请在 [GitHub Discussions](https://github.com/facebook/create-react-app/discussions) 中提问。

## 快速概览

```sh
npx create-react-app my-app
cd my-app
npm start
```

如果你之前通过 `npm install -g create-react-app` 全局安装过 `create-react-app`，我们建议你使用 `npm uninstall -g create-react-app` 或 `yarn global remove create-react-app` 卸载该包，以确保 npx 始终使用最新版本。

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) 随 npm 5.2+ 及更高版本提供，旧版 npm 请参考[说明](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

然后打开 [http://localhost:3000/](http://localhost:3000/) 查看你的应用。<br>
当你准备将应用部署到生产环境时，可使用 `npm run build` 生成压缩包。

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### 立即开始

你**无需**安装或配置 webpack 或 Babel 等工具。<br>
这些工具已预先配置并隐藏起来，让你专注于编写代码。

创建一个项目，你就可以直接开始开发。

## 创建应用

**你需要在本地开发机器上安装 Node 14.0.0 或更高版本**（服务器端不要求）。我们建议使用最新的 LTS 版本。你可以使用 [nvm](https://github.com/creationix/nvm#installation)（macOS/Linux）或 [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) 在不同项目间切换 Node 版本。

创建新应用，你可以选择以下方法之一：

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) 是随 npm 5.2+ 及更高版本提供的软件包运行工具，旧版 npm 请参考[说明](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` 适用于 npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) 适用于 Yarn 0.25+_

这将在当前文件夹下创建名为 `my-app` 的目录。<br>
在该目录下，它将生成初始项目结构并安装所有依赖：

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

无需配置或复杂的文件夹结构，只有构建应用所需的文件。<br>
安装完成后，你可以打开项目文件夹：

```sh
cd my-app
```

在新建项目内，可以运行一些内置命令：

### `npm start` 或 `yarn start`

以开发模式运行应用。<br>
打开 [http://localhost:3000](http://localhost:3000) 在浏览器中查看。

如对代码做出更改，页面会自动刷新。<br>
你将在控制台看到构建错误和 lint 警告。

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` 或 `yarn test`

以交互模式运行测试监视器。<br>
默认情况下，仅运行自上次提交以来更改过的文件相关的测试。

[了解更多测试内容。](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` 或 `yarn build`

将应用构建到 `build` 文件夹用于生产环境。<br>
它会以生产模式正确打包 React，并对构建进行优化以获得最佳性能。

构建后的文件已压缩，文件名包含哈希值。<br>

你的应用已可以部署。

## 用户指南

你可以在[官方文档](https://facebook.github.io/create-react-app/)中找到关于使用 Create React App 的详细说明和许多技巧。

## 如何升级到新版本？

请参考[用户指南](https://facebook.github.io/create-react-app/docs/updating-to-new-releases)获取相关信息。

## 设计理念

- **单一依赖：** 只有一个构建依赖。它使用 webpack、Babel、ESLint 及其他优秀项目，但在这些工具之上提供统一的体验。

- **无需配置：** 你无需进行任何配置。合理的开发和生产构建配置已为你准备好，让你专注于编写代码。

- **无锁定：** 你可以随时“弹出”到自定义设置。只需运行一条命令，所有配置和构建依赖会直接移入你的项目，你可以从原来的地方继续开发。

## 包含内容

你的开发环境将拥有构建现代单页 React 应用所需的一切：

- 支持 React、JSX、ES6、TypeScript 和 Flow 语法。
- 超越 ES6 的语法特性，如对象扩展运算符。
- 自动添加 CSS 前缀，无需手动写 `-webkit-` 等前缀。
- 具备内置覆盖率报告的快速交互式单元测试运行器。
- 可提示常见错误的实时开发服务器。
- 打包 JS、CSS 和图片的生产构建脚本，支持哈希和 sourcemap。
- 支持离线优先的 [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) 和 [web app manifest](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/)，符合所有 [渐进式 Web 应用](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app) 标准。（_注意：自 `react-scripts@2.0.0` 起，service worker 为可选功能_）
- 上述工具均可便捷升级，仅需一个依赖。

查看[本指南](https://github.com/nitishdayal/cra_closer_look)以了解这些工具如何协同工作。

需要权衡的是，**这些工具已预先按特定方式配置好**。如果项目需要更多自定义，你可以["弹出"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject)并自行定制，但之后需要你自己维护配置。

## 常见替代方案

Create React App 非常适合：

- **舒适且功能丰富的开发环境中学习 React。**
- **启动新的单页 React 应用。**
- **为你的库和组件创建 React 示例。**

以下几种常见场景你可能需要尝试其他方案：

- 如果你想**尝试 React**，但不希望引入大量构建工具依赖，建议[使用单个 HTML 文件或在线沙盒](https://reactjs.org/docs/getting-started.html#try-react)。

- 如果你需要将 React 代码**集成到 Rails、Django 或 Symfony 等服务端模板框架**，或你**不在构建单页应用**，可考虑使用更灵活的 [nwb](https://github.com/insin/nwb) 或 [Neutrino](https://neutrino.js.org/)。针对 Rails，可用 [Rails Webpacker](https://github.com/rails/webpacker)；Symfony 可试用 [Symfony 的 webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html)。

- 如果你要**发布 React 组件**，可用 [nwb](https://github.com/insin/nwb) [实现此功能](https://github.com/insin/nwb#react-components-and-libraries)，也可用 [Neutrino 的 react-components 预设](https://neutrino.js.org/packages/react-components/)。

- 如需用 React 和 Node.js 实现**服务端渲染**，请查看 [Next.js](https://nextjs.org/) 或 [Razzle](https://github.com/jaredpalmer/razzle)。Create React App 与后端无关，仅生成静态 HTML/JS/CSS 包。

- 如果你的网站**主要是静态内容**（如作品集或博客），可考虑 [Gatsby](https://www.gatsbyjs.org/) 或 [Next.js](https://nextjs.org/)。与 Create React App 不同，Gatsby 在构建时预渲染为 HTML，Next.js 同时支持服务端渲染和预渲染。

- 最后，如果你需要**更多自定义**，请查看 [Neutrino](https://neutrino.js.org/) 及其 [React 预设](https://neutrino.js.org/packages/react/)。

以上所有工具均可通过极少或无需配置使用。

如果你喜欢自行配置构建，[请参考本指南](https://reactjs.org/docs/add-react-to-a-website.html)。

## React Native

想要类似工具但用于 React Native？<br>
请查看 [Expo CLI](https://github.com/expo/expo-cli)。

## 参与贡献

我们非常欢迎你为 `create-react-app` 贡献力量！更多信息请参见 [CONTRIBUTING.md](CONTRIBUTING.md)。

## 支持 Create React App

Create React App 是社区维护项目，所有贡献者均为志愿者。如果你希望支持 Create React App 的未来开发，请考虑向我们的 [Open Collective](https://opencollective.com/create-react-app) 捐赠。

## 鸣谢

本项目得以存在，感谢所有[贡献者](CONTRIBUTING.md)。<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

感谢 [Netlify](https://www.netlify.com/) 为我们的文档提供托管服务。

## 致谢

感谢相关现有项目的作者们的思想和协作：

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## 许可协议

Create React App 是开源软件，采用 [MIT 许可](https://github.com/facebook/create-react-app/blob/main/LICENSE)。Create React App 标志采用 [知识共享署名 4.0 国际许可协议](https://creativecommons.org/licenses/by/4.0/)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---