# AutoGPT：构建、部署和运行AI代理

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** 是一个强大的平台，可用于创建、部署和管理持续运行的AI代理，从而实现复杂工作流的自动化。

## 托管选项
   - 下载并自托管
   - [加入云端托管测试版候补名单](https://bit.ly/3ZDijAI)

## 自托管搭建指南
> [!NOTE]
> 自行搭建和托管AutoGPT平台是一个技术性较强的过程。
> 如果你希望使用开箱即用的方案，建议[加入云端托管测试版候补名单](https://bit.ly/3ZDijAI)。

### 系统要求

在继续安装之前，请确保你的系统满足以下要求：

#### 硬件要求
- CPU：建议4核及以上
- 内存：至少8GB，建议16GB
- 存储：至少10GB可用空间

#### 软件要求
- 操作系统：
  - Linux（建议Ubuntu 20.04或更新版本）
  - macOS（10.15或更新版本）
  - Windows 10/11（需WSL2支持）
- 必需软件（最低版本）：
  - Docker Engine（20.10.0或更新版本）
  - Docker Compose（2.0.0或更新版本）
  - Git（2.30或更新版本）
  - Node.js（16.x或更新版本）
  - npm（8.x或更新版本）
  - VSCode（1.60或更新版本）或任意现代代码编辑器

#### 网络要求
- 稳定的互联网连接
- 能访问所需端口（将在Docker中配置）
- 能够进行HTTPS外部连接

### 最新搭建说明：
我们已迁移至全面维护并定期更新的文档站点。

👉 [请按此处官方自托管指南操作](https://docs.agpt.co/platform/getting-started/)

本教程假定你已安装Docker、VSCode、git和npm。

### 🧱 AutoGPT 前端

AutoGPT前端是用户与我们强大AI自动化平台交互的界面。它为用户提供多种方式与AI代理互动并加以利用。你将在此界面实现AI自动化创意：

   **代理生成器：** 对于需要自定义的用户，我们提供直观的低代码界面，可设计和配置专属AI代理。
   
   **工作流管理：** 轻松构建、修改和优化自动化工作流。你可以通过连接不同模块构建代理，每个模块执行一个动作。
   
   **部署控制：** 管理代理的生命周期，从测试到生产环境。
   
   **即用型代理：** 不想自己搭建？直接从我们的预设代理库中选择并立即投入使用。
   
   **代理交互：** 无论是自建代理还是预设代理，都可通过友好的界面轻松运行和交互。

   **监控与分析：** 实时跟踪代理性能，获得洞察，持续优化自动化流程。

[阅读本指南](https://docs.agpt.co/platform/new_blocks/) 了解如何自定义构建模块。

### 💽 AutoGPT 服务器

AutoGPT服务器是平台的核心引擎，也是代理实际运行的地方。代理部署后可由外部触发，并持续运行。服务器包含保证AutoGPT平稳运行的所有核心组件。

   **源代码：** 驱动代理与自动化流程的核心逻辑。
   
   **基础设施：** 提供可靠与可扩展性能的强大系统。
   
   **应用市场：** 综合市场，可查找和部署各类预构建代理。

### 🐙 示例代理

以下是你可以用AutoGPT实现的两个示例：

1. **基于热门话题生成爆款短视频**
   - 该代理会读取Reddit上的话题。
   - 自动识别热门话题。
   - 基于内容自动生成短视频。

2. **为社交媒体提取视频金句**
   - 该代理订阅你的YouTube频道。
   - 每当你发布新视频，它会自动转录内容。
   - 利用AI提取最具影响力的金句生成摘要。
   - 自动生成并发布社交媒体推文。

这些示例仅展示了AutoGPT的部分能力！你可以自定义工作流，构建适用于任意场景的代理。

---
### 使命与许可
我们的使命是为你提供工具，让你专注于真正重要的事情：

- 🏗️ **构建** - 为惊人的事物奠定基础。
- 🧪 **测试** - 调优你的代理，做到极致。
- 🤝 **委托** - 让AI为你工作，将你的创意变为现实。

加入革新！**AutoGPT** 将始终站在AI创新前沿。

**📖 [文档](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [贡献指南](CONTRIBUTING.md)**

**许可：**

MIT 许可证：AutoGPT代码仓库的大部分采用MIT许可协议。

Polyform Shield 许可证：适用于 autogpt_platform 文件夹。

更多信息请见 https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT 经典版
> 以下为AutoGPT经典版相关信息。

**🛠️ [快速搭建专属代理](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**锻造你的专属代理！** &ndash; Forge是一套现成的工具包，可用于构建专属代理应用。它处理了大部分样板代码，让你将全部精力投入到让*你的*代理与众不同的创新中。所有教程都在[这里](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec)。[`forge`](/classic/forge/)中的组件也可单独使用，加快开发速度，减少重复代码。

🚀 [**Forge 入门指南**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
本指南将引导你创建代理并使用基准测试与用户界面。

📘 [了解更多](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) 关于 Forge

### 🎯 基准测试

**衡量你的代理性能！** `agbenchmark` 可用于任何支持代理协议的代理，并与项目的 [CLI] 集成，极大提升了与AutoGPT及基于forge代理的兼容性。基准测试提供严格的测试环境。我们的框架实现自动化、客观的性能评估，确保你的代理能够胜任真实场景。

<!-- TODO: 插入基准测试可视化示意 -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) on Pypi
&ensp;|&ensp;
📘 [了解更多](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) 关于基准测试

### 💻 前端界面

**让代理更易用！** `frontend` 为你提供一个用户友好的界面，用于控制和监控代理。它通过 [agent protocol](#-agent-protocol) 连接代理，确保与本生态及外部众多代理兼容。

<!-- TODO: 插入前端界面截图 -->

前端可直接用于本仓库所有代理。只需用 [CLI] 运行你选择的代理即可！

📘 [了解更多](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) 关于前端界面

### ⌨️ CLI

[CLI]: #-cli

为了让你尽可能便捷地使用本仓库的全部工具，仓库根目录下集成了CLI：

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      创建、启动和停止代理的相关命令
  benchmark  启动基准测试并列出测试及类别的相关命令
  setup      安装系统所需依赖。
```

只需克隆仓库，使用 `./run setup` 安装依赖，即可快速上手！

## 🤔 有问题？遇到困难？有建议？

### 获取帮助 - [Discord 💬](https://discord.gg/autogpt)

[![加入我们的Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

如需报告BUG或提出新功能请求，请创建 [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose)。请确保没有重复话题。

## 🤝 相关项目

### 🔄 Agent 协议

为保持统一标准、确保与现有及未来应用的无缝兼容，AutoGPT采用了由 AI Engineer Foundation 推出的 [agent protocol](https://agentprotocol.ai/) 标准。该标准规范了代理到前端和基准测试的通信路径。

---

## Stars 统计

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>


## ⚡ 贡献者

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---