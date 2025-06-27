<p align="right">
   <strong>English</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### 通过一个快速且友好的 API 路由到 250+ 大语言模型

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[文档](https://portkey.wiki/gh-1) | [企业版](https://portkey.wiki/gh-2) | [托管网关](https://portkey.wiki/gh-3) | [更新日志](https://portkey.wiki/gh-4) | [API 参考](https://portkey.wiki/gh-5)


[![许可证](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm 版本](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10) 旨在实现对 1600+ 语言、视觉、音频和图像模型的快速、可靠与安全路由。它是一款轻量级、开源、企业级就绪的解决方案，可让你在 2 分钟内集成任何语言模型。

- [x] **极致快速**（<1ms 延迟），体积极小（122kb）
- [x] **生产验证**，每天处理超过 100 亿 token
- [x] **企业级就绪**，提升安全、可扩展性和支持自定义部署

<br>

#### 使用 AI Gateway 能做什么？
- 2 分钟内集成任何大语言模型 - [快速开始](#quickstart-2-mins)
- 通过 **[自动重试](https://portkey.wiki/gh-11)** 和 **[故障转移](https://portkey.wiki/gh-12)** 防止停机
- 使用 **[负载均衡](https://portkey.wiki/gh-13)** 和 **[条件路由](https://portkey.wiki/gh-14)** 扩展 AI 应用
- 利用 **[防护栏](https://portkey.wiki/gh-15)** 保护你的 AI 部署
- 借助 **[多模态能力](https://portkey.wiki/gh-16)** 实现文本之外的更多功能
- 深入探索 **[智能体工作流](https://portkey.wiki/gh-17)** 集成

<br><br>

> [!TIP]
> 点亮 Star 可以让更多开发者发现 AI Gateway 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## 快速开始（2 分钟完成）

### 1. 安装并启动你的 AI Gateway

```bash
# 本地运行网关（需 Node.js 和 npm 支持）
npx @portkey-ai/gateway
```
> 网关运行在 `http://localhost:8787/v1`
> 
> 网关控制台运行在 `http://localhost:8787/public/`

<sup>
部署指南：
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud（推荐）</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> 其他...</a>

</sup>

### 2. 发起你的第一个请求

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# OpenAI 兼容客户端
client = Portkey(
    provider="openai", # 可选 'anthropic'、'bedrock'、'groq' 等
    Authorization="sk-***" # 你的模型 API 密钥
)

# 通过 AI Gateway 发起请求
client.chat.completions.create(
    messages=[{"role": "user", "content": "What's the weather like?"}],
    model="gpt-4o-mini"
)
```



<sup>支持的库：
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [更多..](https://portkey.wiki/gh-26)
</sup>

在 Gateway 控制台（`http://localhost:8787/public/`）中，你可以查看所有本地日志。

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. 路由与防护栏
LLM 网关中的 `Configs` 可让你创建路由规则，增强可靠性并设置防护栏。
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# 将 config 附加到客户端
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Reply randomly with Apple or Bat"}]
)

# 所有包含 "Apple" 的回复都会被防护栏拒绝，因此总是返回 "Bat"。重试配置会在放弃前最多重试 5 次。
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Request flow through Portkey's AI gateway with retries and guardrails" alt="Request flow through Portkey's AI gateway with retries and guardrails"/>
</div>

你可以通过配置实现更多高级功能。[跳转查看示例 →](https://portkey.wiki/gh-27)

<br/>

### 企业版（私有部署）

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

LLM Gateway 的 [企业版](https://portkey.wiki/gh-86) 内置强大的 **组织管理**、**治理**、**安全**等能力，[更多功能](https://portkey.wiki/gh-87) 一应俱全。[查看功能对比 →](https://portkey.wiki/gh-32)

各大平台的企业私有云部署架构见此 - [**企业私有云部署**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Book an enterprise AI gateway demo" /></a><br/>


<br>

<hr>

### AI 工程开放日

每周五（太平洋时间上午 8 点）参与社区线上会议，助力你的 AI Gateway 落地！[每周五定期举办](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

会议纪要 [发布在此](https://portkey.wiki/gh-36)。


<hr>

### LLMs in Prod'25

基于 2 万亿+ token、90+ 区域和 650+ 团队生产实践的深入分析。报告内容包括：
- 推动 AI 采用及大模型服务商增长的趋势
- 优化速度、成本与可靠性的基准
- 构建生产级 AI 系统的扩展策略

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**获取报告**</a>
<hr>


## 核心特性
### 可靠路由
- <a href="https://portkey.wiki/gh-37">**故障转移**</a>：当请求失败时，使用 LLM 网关自动切换到另一个提供商或模型。您可以指定在哪些错误情况下触发故障转移，提高应用的可靠性。
- <a href="https://portkey.wiki/gh-38">**自动重试**</a>：自动重试失败的请求，最多可达 5 次。采用指数退避策略，间隔重试以防止网络过载。
- <a href="https://portkey.wiki/gh-39">**负载均衡**</a>：通过加权分配，将 LLM 请求分散到多个 API 密钥或 AI 提供商上，确保高可用性和最佳性能。
- <a href="https://portkey.wiki/gh-40">**请求超时**</a>：通过设置精细的请求超时时间，管理不稳定的 LLM 和延迟，自动终止超时请求。
- <a href="https://portkey.wiki/gh-41">**多模态 LLM 网关**</a>：以熟悉的 OpenAI 接口调用来自多个供应商的视觉、音频（文本转语音 & 语音转文本）及图像生成模型。
- <a href="https://portkey.wiki/gh-42">**实时 API**</a>：通过集成 websockets 服务器，调用 OpenAI 推出的实时 API。

### 安全与准确性
- <a href="https://portkey.wiki/gh-88">**安全防护措施**</a>：验证您的 LLM 输入输出，确保符合您指定的检测标准。从 40 多种预构建防护措施中选择，以确保符合安全与准确性标准。您可以<a href="https://portkey.wiki/gh-43">自定义防护措施</a>或选择我们的<a href="https://portkey.wiki/gh-44">众多合作伙伴</a>。
- [**安全密钥管理**](https://portkey.wiki/gh-45)：使用您自己的密钥，或即时生成虚拟密钥。
- [**基于角色的访问控制**](https://portkey.wiki/gh-46)：为您的用户、工作空间和 API 密钥提供精细化访问控制。
- <a href="https://portkey.wiki/gh-47">**合规性与数据隐私**</a>：AI 网关符合 SOC2、HIPAA、GDPR 和 CCPA 标准。

### 成本管理
- [**智能缓存**](https://portkey.wiki/gh-48)：缓存 LLM 的响应以降低成本并提升延迟表现。支持简单与语义*缓存。
- [**使用分析**](https://portkey.wiki/gh-49)：监控和分析您的 AI 与 LLM 用量，包括请求量、延迟、成本和错误率。
- [**供应商优化***](https://portkey.wiki/gh-89)：根据使用模式和价格模型，自动切换到性价比最高的供应商。

### 协作与工作流
- <a href="https://portkey.ai/docs/integrations/agents">**代理支持**</a>：无缝集成流行的代理框架，构建复杂的 AI 应用。网关可与 [Autogen](https://portkey.wiki/gh-50)、[CrewAI](https://portkey.wiki/gh-51)、[LangChain](https://portkey.wiki/gh-52)、[LlamaIndex](https://portkey.wiki/gh-53)、[Phidata](https://portkey.wiki/gh-54)、[Control Flow](https://portkey.wiki/gh-55) 及 [自定义代理](https://portkey.wiki/gh-56) 深度集成。
- [**提示模板管理***](https://portkey.wiki/gh-57)：通过通用提示广场，协作创建、管理和版本化您的提示模板。
<br/><br/>

<sup>
*&nbsp;功能在托管版和企业版中提供
</sup>

<br>

## Cookbooks

### ☄️ 热门示例
- 使用 [Nvidia NIM](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/providers/nvidia.ipynb) 与 AI Gateway 集成
- 通过 Portkey 监控 [CrewAI Agents](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb)！
- 对比 [LMSYS Top 10 模型](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb) 在 AI Gateway 上的表现。

### 🚨 最新示例
* [使用 Nemotron 创建合成数据集](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [将 LLM Gateway 与 Vercel 的 AI SDK 集成](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/integrations/vercel-ai.md)
* [通过 Portkey 的 LLM Gateway 监控 Llama Agents](https://raw.githubusercontent.com/Portkey-AI/gateway/main/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[查看全部 cookbook →](https://portkey.wiki/gh-58)
<br/><br/>

## 支持的服务商

探索 Gateway 与 [45+ 服务商](https://portkey.wiki/gh-59) 及 [8+ 代理框架](https://portkey.wiki/gh-90) 的集成。

|                                                                                                                            | 服务商                                                                                          | 支持 | 流式 |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
| <img src="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [在此查看支持的 200+ 模型完整列表](https://portkey.wiki/gh-74)
<br>

<br>

## 代理
Gateway 可无缝集成主流代理框架。[阅读文档](https://portkey.wiki/gh-75)。

| 框架 | 调用 200+ LLM | 高级路由 | 缓存 | 日志与追踪* | 可观测性* | 提示管理* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [自定义代理](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*功能可在[托管应用](https://portkey.wiki/gh-76)中使用。详细文档请[点击此处](https://portkey.wiki/gh-100)。

## Gateway 企业版
让您的 AI 应用更<ins>可靠</ins>，更<ins>前向兼容</ins>，同时确保<ins>数据安全</ins>与<ins>隐私</ins>。

✅&nbsp; 安全密钥管理 - 支持基于角色的访问控制及追踪 <br>
✅&nbsp; 简单及语义缓存 - 快速响应重复查询并节省成本 <br>
✅&nbsp; 访问控制与入站规则 - 控制哪些 IP 和地区可以访问您的部署 <br>
✅&nbsp; PII 脱敏 - 自动移除请求中的敏感数据，防止数据泄露 <br>
✅&nbsp; SOC2、ISO、HIPAA、GDPR 合规 - 最佳安全实践 <br>
✅&nbsp; 专业支持 - 并可优先定制功能 <br>

[预约沟通企业部署](https://portkey.sh/demo-13)

<br>


## 参与贡献

最简单的参与方式是挑选带有 `good first issue` 标签的问题 💪。请阅读[贡献指南](/.github/CONTRIBUTING.md)。

发现 Bug？[提交这里](https://portkey.wiki/gh-78) | 新功能请求？[提交这里](https://portkey.wiki/gh-78)


### 社区入门
每周五（上午 8 点 PT）加入我们的 AI 工程小时活动：

- 结识其他贡献者与社区成员
- 学习 Gateway 的高级特性与实现模式
- 分享经验并寻求帮助
- 获取最新开发动态

[报名下次活动 →](https://portkey.wiki/gh-101) | [会议记录](https://portkey.wiki/gh-102)

<br>

## 社区

加入我们不断壮大的全球社区，获取帮助、灵感与 AI 相关讨论。

- 查看我们的官方 [博客](https://portkey.wiki/gh-78)
- 在 [Discord](https://portkey.wiki/community) 与我们交流
- 关注我们的 [Twitter](https://portkey.wiki/gh-79)
- 在 [LinkedIn](https://portkey.wiki/gh-80) 关注我们
- 阅读[日文文档](https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md)
- 访问我们的 [YouTube](https://portkey.wiki/gh-103)
- 加入我们的 [开发者社区](https://portkey.wiki/gh-82)
<!-- - 在 [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) 查找带有 #portkey 标签的问题 -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---