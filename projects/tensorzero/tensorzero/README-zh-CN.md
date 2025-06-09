<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero 为 LLM 应用创建了一个反馈循环 —— 将生产数据转化为更智能、更快、更低成本的模型。**

1. 集成我们的模型网关
2. 发送指标或反馈
3. 优化提示词、模型和推理策略
4. 见证你的 LLM 随时间不断提升

它通过统一以下内容，为 LLM 提供了一个**数据与学习飞轮**：

- [x] **推理（Inference）：** 一个 API 连接所有 LLM，P99 延迟 <1ms
- [x] **可观测性（Observability）：** 推理与反馈 → 你的数据库
- [x] **优化（Optimization）：** 从提示词到微调与强化学习
- [x] **评测（Evaluations）：** 对比提示词、模型、推理策略
- [x] **实验（Experimentation）：** 内置 A/B 测试、路由、回退

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">官网</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">文档</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">推特</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">快速开始（5分钟）</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">综合教程</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">部署指南</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API 参考</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">配置参考</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>什么是 TensorZero？</b></td>
    <td width="70%" valign="top">TensorZero 是一个用于构建生产级 LLM 应用的开源框架。它统一了 LLM 网关、可观测性、优化、评测和实验功能。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero 与其他 LLM 框架有何不同？</b></td>
    <td width="70%" valign="top">
      1. TensorZero 允许你基于生产指标和人工反馈优化复杂的 LLM 应用。<br>
      2. TensorZero 满足工业级 LLM 应用的需求：低延迟、高吞吐、类型安全、自托管、GitOps、自定义等。<br>
      3. TensorZero 统一了整个 LLMOps 技术栈，带来复合效益。例如，LLM 评测可与 AI 裁判结合用于模型微调。
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>我可以用 TensorZero 搭配 ___ 吗？</b></td>
    <td width="70%" valign="top">可以。支持所有主流编程语言。你可以使用我们的 Python 客户端、任何 OpenAI SDK，或我们的 HTTP API。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero 适合生产环境吗？</b></td>
    <td width="70%" valign="top">是的。这里有一个案例研究：<b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">使用 LLM 自动生成大型银行代码变更日志</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero 多少钱？</b></td>
    <td width="70%" valign="top">完全免费。TensorZero 100% 自托管且开源。没有任何付费功能。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>谁在开发 TensorZero？</b></td>
    <td width="70%" valign="top">我们的技术团队包括前 Rust 编译器维护者、机器学习研究员（斯坦福、CMU、牛津、哥伦比亚）拥有数千引用，以及一家独角兽初创公司的首席产品官。我们获得了领先开源项目（如 ClickHouse、CockroachDB）和 AI 实验室（如 OpenAI、Anthropic）投资人的支持。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>如何开始使用？</b></td>
    <td width="70%" valign="top">你可以逐步采用 TensorZero。我们的 <b><a href="https://www.tensorzero.com/docs/quickstart">快速开始</a></b> 从原生 OpenAI 封装到集成可观测性与微调的生产级 LLM 应用只需 5 分钟。</td>
  </tr>
</table>

---

## 功能特性

### 🌐 LLM 网关

> **只需一次集成 TensorZero，即可访问所有主流 LLM 服务商。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>模型服务商</b></td>
    <td width="50%" align="center" valign="middle"><b>功能特性</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero 网关原生支持：
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/anthropic">Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-bedrock">AWS Bedrock</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-sagemaker">AWS SageMaker</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/azure">Azure OpenAI Service</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/deepseek">DeepSeek</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/fireworks">Fireworks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-anthropic">GCP Vertex AI Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-gemini">GCP Vertex AI Gemini</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/google-ai-studio-gemini">Google AI Studio (Gemini API)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/hyperbolic">Hyperbolic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/mistral">Mistral</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai">OpenAI</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/together">Together</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/vllm">vLLM</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/xai">xAI</a></b></li>
      </ul>
      <p>
        <em>
          需要其他服务商？
          你的服务商很可能已支持，因为 TensorZero 可集成 <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">任何 OpenAI 兼容 API（如 Ollama）</a></b>。
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero 网关支持诸多高级功能：
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">重试与回退</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">推理时优化</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">提示词模板与模式</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">实验（A/B 测试）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">代码即配置（GitOps）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">批量推理</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">多模态推理（VLMs）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">推理缓存</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">指标与反馈</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">多步 LLM 工作流（Episodes）</a></b></li>
        <li><em>以及更多……</em></li>
      </ul>
      <p>
        TensorZero 网关使用 Rust 🦀 编写，<b>专注性能</b>（10k QPS 下 P99 延迟 <1ms）。
        查看 <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">性能基准</a></b>。<br>
      </p>
      <p>
        你可以通过 <b>TensorZero 客户端</b>（推荐）、<b>OpenAI 客户端</b> 或 <b>HTTP API</b> 进行推理。
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>用法：Python —— TensorZero 客户端（推荐）</b></summary>

你可以通过 TensorZero Python 客户端访问任意服务商。

1. `pip install tensorzero`
2. 可选：配置 TensorZero。
3. 运行推理：

```python
from tensorzero import TensorZeroGateway  # 或 AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # 可轻松尝试其他服务商："anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "写一首关于人工智能的俳句。",
                }
            ]
        },
    )
```

详见 **[快速开始](https://www.tensorzero.com/docs/quickstart)**。

</details>

<details>
<summary><b>用法：Python —— OpenAI 客户端</b></summary>

你可以通过 OpenAI Python 客户端配合 TensorZero 访问任意服务商。

1. `pip install tensorzero`
2. 可选：配置 TensorZero。
3. 运行推理：

```python
from openai import OpenAI  # 或 AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # 轻松尝试其他提供商: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "写一首关于人工智能的俳句。",
        }
    ],
)
```

查看更多信息请参见 **[快速开始](https://www.tensorzero.com/docs/quickstart)**。

</details>

<details>
<summary><b>用法：JavaScript / TypeScript (Node) &mdash; OpenAI 客户端</b></summary>

您可以通过 TensorZero 使用 OpenAI Node 客户端访问任意模型提供商。

1. 使用 Docker 部署 `tensorzero/gateway`。
   **[详细部署说明 →](https://www.tensorzero.com/docs/gateway/deployment)**
2. 配置 TensorZero。
3. 运行推理：

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // 轻松尝试其他提供商: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "写一首关于人工智能的俳句。",
    },
  ],
});
```

查看更多信息请参见 **[快速开始](https://www.tensorzero.com/docs/quickstart)**。

</details>

<details>
<summary><b>用法：其他语言 & 平台 &mdash; HTTP API</b></summary>

TensorZero 通过其 HTTP API 支持几乎所有编程语言或平台。

1. 使用 Docker 部署 `tensorzero/gateway`。
   **[详细部署说明 →](https://www.tensorzero.com/docs/gateway/deployment)**
2. 可选：配置 TensorZero。
3. 运行推理：

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "写一首关于人工智能的俳句。"
        }
      ]
    }
  }'
```

查看更多信息请参见 **[快速开始](https://www.tensorzero.com/docs/quickstart)**。

</details>

<br>

### 📈 LLM 优化

> **发送生产指标和人工反馈，轻松优化你的提示词、模型和推理策略——可通过 UI 或编程方式实现。**

#### 模型优化

通过监督微调（SFT）和偏好微调（DPO）优化闭源和开源模型。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>监督微调 &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>偏好微调（DPO）&mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### 推理时优化

通过动态更新提示词相关示例、组合多次推理的响应等方式提升性能。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N 采样</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N 采样</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">动态上下文学习（DICL）</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">思维链（CoT）</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_更多内容即将推出..._

<br>

#### 提示词优化

使用基于研究的优化技术以编程方式优化你的提示词。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy 集成</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero 提供了多种优化方案，你也可以轻松自定义自己的方案。
      此示例展示了如何用任意工具（如自动提示工程流行库 DSPy）优化 TensorZero 函数。
    </td>
  </tr>
</table>

_更多内容即将推出..._

<br>

### 🔍 LLM 可观测性

> **放大调试单个 API 调用，或缩小监控不同模型与提示词的长期指标——全部可通过开源 TensorZero UI 实现。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>可观测性 » 推理</b></td>
    <td width="50%" align="center" valign="middle"><b>可观测性 » 函数</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 LLM 评测

> **使用 TensorZero 评测对比不同的提示词、模型和推理策略——支持启发式和大模型评审。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>评测 » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>评测 » CLI</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/f4bf54e3-1b63-46c8-be12-2eaabf615699"></td>
    <td width="50%" align="left" valign="middle">
<pre><code class="language-bash">docker compose run --rm evaluations \
  --evaluation-name extract_data \
  --dataset-name hard_test_cases \
  --variant-name gpt_4o \
  --concurrency 5</code></pre>
<pre><code class="language-bash">Run ID: 01961de9-c8a4-7c60-ab8d-15491a9708e4
Number of datapoints: 100
██████████████████████████████████████ 100/100
exact_match: 0.83 ± 0.03
semantic_match: 0.98 ± 0.01  
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## 演示

> **观看 LLM 在 TensorZero 上实时提升数据提取能力！**
>
> **[动态上下文学习（DICL）](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** 是 TensorZero 原生支持的一种强大推理时优化功能。
> 它通过自动将相关的历史示例纳入提示，无需模型微调，即可提升 LLM 性能。

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## 使用 TensorZero 进行 LLM 工程

<br>
<p align="center" >
  <a href="https://www.tensorzero.com/docs">
    <picture>
      <source media="(prefers-color-scheme: light)" srcset="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6">
      <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/e8bc699b-6378-4c2a-9cc1-6d189025e270">
      <img alt="TensorZero Flywheel" src="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6" width=720>
    </picture>
  </a>
</p>
<br>

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** 是一个用 Rust 🦀 编写的高性能模型网关，为所有主流 LLM 提供统一 API 接口，实现无缝的跨平台集成与回退。
2. 它支持基于结构化 schema 的推理，P99 延迟开销小于 1 毫秒（参见 **[基准测试](https://www.tensorzero.com/docs/gateway/benchmarks)**），并内置可观测性、实验和**[推理时优化](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**。
3. 还会收集与推理相关的下游指标和反馈，原生支持多步 LLM 系统。
4. 所有数据都存储在你自己控制的 ClickHouse 数据仓库中，实现实时、可扩展且对开发者友好的分析。
5. 随着时间推移，**[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** 利用这些结构化数据集优化你的提示词和模型：可运行常见工作流的预设 Recipe 进行微调，或用任意语言和平台完全自定义你的工作流。
6. 最后，网关的实验功能和 GitOps 编排让你能够自信地迭代和部署，无论是一台 LLM 还是上千台 LLM。

我们的目标是帮助工程师构建、管理和优化下一代 LLM 应用系统，让系统能从真实世界经验中持续学习。  
详细了解我们的**[愿景与路线图](https://www.tensorzero.com/docs/vision-roadmap/)**。

## 快速开始

**立即开始构建。**  
**[快速入门](https://www.tensorzero.com/docs/quickstart)** 展示了用 TensorZero 搭建 LLM 应用是多么简单。  
如果想深入学习，**[教程](https://www.tensorzero.com/docs/gateway/tutorial)** 将指导你构建一个简单的聊天机器人、邮件助手、天气 RAG 系统和结构化数据提取流水线。

**有疑问？**  
欢迎在 **[Slack](https://www.tensorzero.com/slack)** 或 **[Discord](https://www.tensorzero.com/discord)** 上与我们交流。

**在工作中使用 TensorZero？**  
发邮件至 **[hello@tensorzero.com](mailto:hello@tensorzero.com)**，我们可以协助你和团队（免费）建立 Slack 或 Teams 频道。

**加入我们。**  
我们正在**[纽约招聘](https://www.tensorzero.com/jobs)**。  
也欢迎你**[参与开源贡献](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**！

## 示例

我们正在制作一系列**完整可运行的示例**，展示 TensorZero 的数据与学习飞轮。

> **[使用 TensorZero 优化数据提取（NER）](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/data-extraction-ner)**
>
> 本示例展示如何使用 TensorZero 优化数据提取流水线。
> 我们演示了微调和动态上下文学习（DICL）等技术。
> 最终，经过优化的 GPT-4o Mini 模型在此任务中的表现超越了 GPT-4o，成本和延迟却只是其一小部分，仅需极少量训练数据。

> **[Agentic RAG — 基于 LLM 的多跳问答](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> 本示例展示如何使用 TensorZero 构建多跳检索智能体。
> 该智能体可迭代地搜索维基百科收集信息，并判断何时拥有足够上下文回答复杂问题。

> **[为隐藏偏好的评委创作俳句](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/haiku-hidden-preferences)**
>
> 本示例对 GPT-4o Mini 进行微调，以生成满足特定品味的俳句。
> 你将看到 TensorZero“数据飞轮盒”在实际运行：更好的变体带来更好的数据，更好的数据又带来更优的变体。
> 你会通过多次微调 LLM 看到持续进步。

> **[通过 N 选优法提升 LLM 国际象棋能力](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/chess-puzzles/)**
>
> 本示例展示了如何通过 N 选优采样法，显著提升 LLM 下棋能力，从多个备选方案中选出最优落子。

> **[用自动化提示工程自定义 Recipe 提升数学推理能力（DSPy）](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero 提供了许多内置优化 Recipe，涵盖常见 LLM 工程工作流。
> 你也可以轻松自定义属于自己的 Recipe 和工作流！
> 本示例展示了如何借助任意工具（此处为 DSPy）优化 TensorZero 函数。

_还有更多示例即将上线！_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---