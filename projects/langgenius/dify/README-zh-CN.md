![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Dify Workflow 文件上传功能介绍：重现 Google NotebookLM 播客</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify 云</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">自托管部署</a> ·
  <a href="https://docs.dify.ai">文档</a> ·
  <a href="https://dify.ai/pricing">Dify 版本总览</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat on Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="join Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="follow on X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="follow on LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits last month" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues closed" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Discussion posts" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify 是一个开源的大语言模型应用开发平台。其直观的界面融合了智能体 AI 工作流、RAG 管道、Agent 能力、模型管理、可观测性等功能，助您快速从原型到生产环境。

## 快速开始

> 在安装 Dify 之前，请确保您的设备满足以下最低系统要求：
>
> - CPU >= 2 核
> - 内存 >= 4 GiB

</br>

启动 Dify 服务器最简单的方法是通过 [docker compose](docker/docker-compose.yaml)。在执行以下命令运行 Dify 前，请确保您的设备已安装 [Docker](https://docs.docker.com/get-docker/) 和 [Docker Compose](https://docs.docker.com/compose/install/)：

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

运行完成后，您可以在浏览器中访问 [http://localhost/install](http://localhost/install) 并开始初始化流程。

#### 寻求帮助

如果在搭建 Dify 过程中遇到问题，请参考我们的 [常见问题](https://docs.dify.ai/getting-started/install-self-hosted/faqs)。如仍有疑问，请联系[社区及我们](#community--contact)。

> 如果您希望为 Dify 贡献代码或进行二次开发，请参考我们的[源码部署指南](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## 核心功能

**1. 工作流**：
在可视化画布上构建和测试强大的 AI 工作流，利用以下所有特性及更多。

**2. 全面模型支持**：
无缝集成数百种来自几十家推理服务商及自托管方案的专有/开源大语言模型，覆盖 GPT、Mistral、Llama3 及所有兼容 OpenAI API 的模型。完整支持模型列表见[此处](https://docs.dify.ai/getting-started/readme/model-providers)。

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**：
直观的界面用于编写提示词，比较模型性能，并为基于聊天的应用添加文本转语音等附加功能。

**4. RAG 管道**：
全面的 RAG 能力，覆盖从文档导入到检索的全过程，原生支持 PDF、PPT 及其它常见文档格式的文本抽取。

**5. Agent 能力**：
您可以基于 LLM Function Calling 或 ReAct 定义智能体，并为其添加内置或自定义工具。Dify 为 AI Agent 提供 50+ 内置工具，如 Google 搜索、DALL·E、Stable Diffusion 和 WolframAlpha。

**6. LLMOps**：
监控并分析应用日志和性能表现。您可以基于生产数据和标注持续优化提示词、数据集和模型。

**7. 后端即服务**：
Dify 所有能力均有对应 API，可便捷集成进您的业务逻辑。

## 功能对比

<table style="width: 100%;">
  <tr>
    <th align="center">功能</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">编程方式</td>
    <td align="center">API + 面向应用</td>
    <td align="center">Python 代码</td>
    <td align="center">面向应用</td>
    <td align="center">面向 API</td>
  </tr>
  <tr>
    <td align="center">支持的大模型</td>
    <td align="center">种类丰富</td>
    <td align="center">种类丰富</td>
    <td align="center">种类丰富</td>
    <td align="center">仅 OpenAI</td>
  </tr>
  <tr>
    <td align="center">RAG 引擎</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agent</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">工作流</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">可观测性</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">企业特性（SSO/权限管理）</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">本地部署</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## 使用 Dify

- **云服务 </br>**
  我们提供了 [Dify Cloud](https://dify.ai) 云服务，零配置即可体验。其功能等同于自部署版本，沙盒计划内包含 200 次免费 GPT-4 调用。

- **自托管 Dify 社区版</br>**
  通过[快速开始指南](#quick-start)在您的环境中快速运行 Dify。
  更多说明和深入使用请参考我们的[文档](https://docs.dify.ai)。

- **企业/组织版 Dify</br>**
  我们提供更多面向企业的功能。[可通过此聊天机器人提交您的需求](https://udify.app/chat/22L1zSxg6yW1cWQg) 或 [发送邮件](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) 与我们沟通。 </br>
  > 针对使用 AWS 的初创企业和小型企业，可在 [AWS Marketplace 选购 Dify Premium](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6)，一键部署到您的 AWS VPC。支持自定义 Logo 和品牌，价格亲民。

## 保持领先

在 GitHub 上为 Dify 加星，即可第一时间收到新版本通知。

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## 高级部署

如需自定义配置，请参考我们 [.env.example](docker/.env.example) 文件中的注释，并在 `.env` 文件中更新对应参数。此外，您还可能需要根据具体部署环境和需求，调整 `docker-compose.yaml` 文件，例如更改镜像版本、端口映射或挂载卷。所有变更完成后，请重新执行 `docker-compose up -d`。完整环境变量列表见[此处](https://docs.dify.ai/getting-started/install-self-hosted/environments)。

如需高可用部署，社区贡献了 [Helm Charts](https://helm.sh/) 和 YAML 文件，可助您将 Dify 部署到 Kubernetes。

- [@LeoQuote 提供的 Helm Chart](https://github.com/douban/charts/tree/master/charts/dify)
- [@BorisPolonsky 提供的 Helm Chart](https://github.com/BorisPolonsky/dify-helm)
- [@magicsong 提供的 Helm Chart](https://github.com/magicsong/ai-charts)
- [@Winson-030 提供的 YAML 文件](https://github.com/Winson-030/dify-kubernetes)
- [@wyy-holding 提供的 YAML 文件](https://github.com/wyy-holding/dify-k8s)

#### 使用 Terraform 部署

通过 [terraform](https://www.terraform.io/) 一键部署 Dify 至云平台

##### Azure 全球版

- [@nikawang 提供的 Azure Terraform](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [@sotazum 提供的 Google Cloud Terraform](https://github.com/DeNA/dify-google-cloud-terraform)

#### 使用 AWS CDK 部署

通过 [CDK](https://aws.amazon.com/cdk/) 部署 Dify 至 AWS

##### AWS

- [@KevinZhao 提供的 AWS CDK](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## 贡献

如希望贡献代码，请参阅我们的[贡献指南](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)。
同时，欢迎通过社交网络、活动和会议传播 Dify，支持我们的发展。

> 我们正在寻找愿意将 Dify 翻译成非中文或英文语言的贡献者。如有意愿，请参见 [i18n 说明文档](https://github.com/langgenius/dify/blob/main/web/i18n/README.md)，并在我们 [Discord 社区服务器](https://discord.gg/8Tpq4AcN9c) 的 `global-users` 频道留言。

## 社区与联系

- [GitHub Discussion](https://github.com/langgenius/dify/discussions)。适合：反馈交流与问题咨询。
- [GitHub Issues](https://github.com/langgenius/dify/issues)。适合：使用 Dify.AI 时遇到的 BUG 及功能建议。详情见[贡献指南](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)。
- [Discord](https://discord.gg/FngNHpbcY7)。适合：展示您的应用并加入社区互动。
- [X(Twitter)](https://twitter.com/dify_ai)。适合：展示您的应用并加入社区互动。

**贡献者**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Star 记录

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## 安全披露

为保护您的隐私，请勿在 GitHub 上发布安全问题。请将您的问题发送至 security@dify.ai，我们会为您提供详细解答。

## 许可证

本仓库遵循 [Dify 开源协议](LICENSE)，其本质为 Apache 2.0 协议并有少量附加限制。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---