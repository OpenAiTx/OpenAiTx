<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>一次学习，到处编写：</strong><br>
  使用 React 构建移动应用。
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React Native 以 MIT 协议发布。" />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="当前 npm 包版本。" />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="欢迎 PR！" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="关注 @reactnative" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">快速开始</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">学习基础</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">案例展示</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">贡献指南</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">社区</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">支持</a>
</h3>

React Native 将 [**React**][r] 声明式 UI 框架引入 iOS 和 Android。使用 React Native，您可以使用原生 UI 控件，并完全访问原生平台。

- **声明式。** React 让创建交互式 UI 变得轻松。声明式视图让你的代码更可预测，也更易于调试。
- **基于组件。** 构建封装了自身状态的组件，然后组合它们以创建复杂的 UI。
- **开发者效率。** 本地更改秒级可见。对 JavaScript 代码的更改可直接热重载，无需重新构建原生应用。
- **可移植性。** 可在 iOS、Android 及[其他平台][p]复用代码。

React Native 由众多公司及核心个人贡献者共同开发和支持。更多内容请参阅我们的[生态系统概览][e]。

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## 目录

- [系统要求](#-requirements)
- [构建你的第一个 React Native 应用](#-building-your-first-react-native-app)
- [文档](#-documentation)
- [升级](#-upgrading)
- [如何贡献](#-how-to-contribute)
- [行为准则](#code-of-conduct)
- [许可证](#-license)

## 📋 系统要求

React Native 应用可面向 iOS 15.1 及 Android 7.0（API 24）或更高版本。你可以使用 Windows、macOS 或 Linux 作为开发操作系统，但构建和运行 iOS 应用仅限于 macOS。可使用 [Expo](https://expo.dev) 等工具绕过此限制。

## 🎉 构建你的第一个 React Native 应用

请按照[快速开始指南](https://reactnative.dev/docs/getting-started)操作。推荐的 React Native 安装方式取决于你的项目。以下是最常见场景的简要指南：

- [试用 React Native][hello-world]
- [创建新应用][new-app]
- [将 React Native 添加到现有应用][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 文档

React Native 的完整文档可在我们的[官网][docs]查阅。

React Native 文档涵盖了组件、API 及 React Native 特有的话题。关于 React Native 与 React DOM 共享的 React API，请参考 [React 文档][r-docs]。

React Native 文档及网站源码托管在独立的仓库 [**@facebook/react-native-website**][repo-website]。

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 升级

升级到新版本的 React Native 可获得更多 API、视图、开发者工具及其他新特性。具体操作请参见[升级指南][u]。

React Native 版本发布相关讨论见 [此讨论仓库](https://github.com/reactwg/react-native-releases/discussions)。

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 如何贡献

本仓库的主要目的是持续推进 React Native 核心的发展。我们希望让贡献过程尽可能简单和透明，感谢社区为我们带来的 bug 修复和改进。请阅读以下内容，了解你如何参与改进 React Native。

### [行为准则][code]

Facebook 制定了行为准则，期望项目参与者遵守。
请阅读[全文][code]，以便了解哪些行为可被接受，哪些不可被容忍。

[code]: https://code.fb.com/codeofconduct/

### [贡献指南][contribute]

阅读我们的[**贡献指南**][contribute]，了解开发流程、如何提交 bug 修复和改进建议，以及如何构建和测试你对 React Native 的更改。

[contribute]: https://reactnative.dev/docs/contributing

### [开源路线图][roadmap]

你可以在[**路线图**][roadmap]中了解 React Native 的愿景。

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### Good First Issues

我们有一份[适合新手的问题][gfi]列表，包含范围相对有限的 bug。这是一个很好的起点，可以积累经验、熟悉我们的贡献流程。

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### 讨论

更大范围的讨论和提案在 [**@react-native-community/discussions-and-proposals**][repo-meta] 进行。

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 许可证

React Native 采用 MIT 许可证，详见 [LICENSE][l] 文件。

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---