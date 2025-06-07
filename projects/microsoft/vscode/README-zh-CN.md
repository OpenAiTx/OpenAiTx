# Visual Studio Code - 开源版（“Code - OSS”）

[![功能请求](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![缺陷](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter 聊天](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## 代码仓库

本仓库（“`Code - OSS`”）是我们（微软）与社区共同开发 [Visual Studio Code](https://code.visualstudio.com) 产品的地方。我们不仅在这里开发代码和跟踪问题，还发布我们的[开发路线图](https://github.com/microsoft/vscode/wiki/Roadmap)、[每月迭代计划](https://github.com/microsoft/vscode/wiki/Iteration-Plans)以及[最终发布计划](https://github.com/microsoft/vscode/wiki/Running-the-Endgame)。本源代码以标准的 [MIT 许可证](https://github.com/microsoft/vscode/blob/main/LICENSE.txt)向所有人开放。

## Visual Studio Code

<p align="center">
  <img alt="VS Code 使用场景" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) 是基于 `Code - OSS` 仓库的发行版，包含微软专有定制，并以传统的[微软产品许可协议](https://code.visualstudio.com/License/)发布。

[Visual Studio Code](https://code.visualstudio.com) 结合了代码编辑器的简洁性与开发者核心编辑-构建-调试循环所需的功能。它提供了全面的代码编辑、导航和理解支持，同时具备轻量级调试、丰富的可扩展性模型，以及与现有工具的轻量级集成。

Visual Studio Code 每月都会发布新功能和缺陷修复。你可以在 [Visual Studio Code 官网](https://code.visualstudio.com/Download) 下载适用于 Windows、macOS 和 Linux 的版本。如需每天获取最新版本，请安装 [Insiders 版本](https://code.visualstudio.com/insiders)。

## 参与贡献

你可以通过多种方式参与本项目，例如：

* [提交缺陷与功能请求](https://github.com/microsoft/vscode/issues)，并协助我们进行验证
* 审查[源代码更改](https://github.com/microsoft/vscode/pulls)
* 审阅[文档](https://github.com/microsoft/vscode-docs)，从拼写错误到新增内容都可提交拉取请求

如果你有兴趣修复问题并直接为代码库贡献代码，
请参阅[如何贡献](https://github.com/microsoft/vscode/wiki/How-to-Contribute)文档，内容涵盖：

* [如何从源代码构建和运行](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [开发流程，包括调试和运行测试](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [编码规范](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [提交拉取请求](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [如何找到可参与的问题](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [参与翻译贡献](https://aka.ms/vscodeloc)

## 反馈

* 在 [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode) 提问
* [请求新功能](CONTRIBUTING.md)
* 为[热门功能请求点赞](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [提交问题](https://github.com/microsoft/vscode/issues)
* 在 [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) 或 [Slack](https://aka.ms/vscode-dev-community) 与扩展作者社区交流
* 关注 [@code](https://twitter.com/code) 并告诉我们你的想法！

更多渠道的说明及其他社区驱动的渠道信息，请参见我们的[维基](https://github.com/microsoft/vscode/wiki/Feedback-Channels)。

## 相关项目

VS Code 的许多核心组件和扩展都在 GitHub 上独立的仓库中。例如，[node 调试适配器](https://github.com/microsoft/vscode-node-debug) 和 [mono 调试适配器](https://github.com/microsoft/vscode-mono-debug) 分别拥有各自的仓库。完整列表请访问我们[维基](https://github.com/microsoft/vscode/wiki)的[相关项目](https://github.com/microsoft/vscode/wiki/Related-Projects)页面。

## 内置扩展

VS Code 包含一组位于 [extensions](extensions) 文件夹中的内置扩展，其中包括多种语言的语法和代码片段。为某种语言提供丰富语言支持（代码补全、转到定义）的扩展会以 `language-features` 作为后缀。例如，`json` 扩展为 `JSON` 提供高亮显示，而 `json-language-features` 扩展为 `JSON` 提供丰富的语言支持。

## 开发容器

本仓库包含一个 Visual Studio Code Dev Containers / GitHub Codespaces 开发容器。

* 对于 [Dev Containers](https://aka.ms/vscode-remote/download/containers)，使用 **Dev Containers: Clone Repository in Container Volume...** 命令，在 macOS 和 Windows 上创建 Docker 卷以获得更好的磁盘 I/O 性能。
  * 如果你已安装 VS Code 和 Docker，也可以点击[这里](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode)开始。这将自动安装 Dev Containers 扩展（如有需要），将源代码克隆到容器卷中，并启动可用的开发容器。

* 对于 Codespaces，请在 VS Code 中安装 [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) 扩展，并使用 **Codespaces: Create New Codespace** 命令。

Docker / Codespace 至少需要 **4 核心和 6 GB 内存（推荐 8 GB）** 才能完成完整构建。更多信息请参阅[开发容器自述文件](.devcontainer/README.md)。

## 行为准则

本项目采纳了[微软开源行为准则](https://opensource.microsoft.com/codeofconduct/)。更多信息请参阅[行为准则常见问题](https://opensource.microsoft.com/codeofconduct/faq/)，或通过 [opencode@microsoft.com](mailto:opencode@microsoft.com) 联系我们提出其他问题或建议。

## 许可证

版权所有 (c) Microsoft Corporation。保留所有权利。

根据 [MIT](LICENSE.txt) 许可证授权。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---