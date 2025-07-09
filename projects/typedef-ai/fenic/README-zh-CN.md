<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic：为LLM推理（重）构的数据框架

[![PyPI version](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Python versions](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![License](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **文档**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic 是 typedef.ai 推出的一个具有主见、受 PySpark 启发的数据框架，用于构建 AI 和智能体应用。通过增强了语义智能的熟悉 DataFrame 操作，将非结构化和结构化数据转化为洞见。原生支持 markdown、转录文本和语义操作符，并可在任意模型提供商上高效批量推理。
## 安装

fenic 支持 Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### LLM 提供商设置

fenic 需要至少一个 LLM 提供商的 API 密钥。请为你选择的提供商设置相应的环境变量：

```bash
# 对于 OpenAI
export OPENAI_API_KEY="your-openai-api-key"

# 对于 Anthropic
export ANTHROPIC_API_KEY="your-anthropic-api-key"

# 对于 Google
export GEMINI_API_KEY="your-google-api-key"
```

## 快速入门

了解 fenic 的最快方式是查看示例。

以下是本仓库中的示例快速列表：

| 示例                                                                      | 描述                                                                                                                           |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------ |
| [Hello World!](examples/hello_world)                                      | 通过错误日志分析，介绍如何使用 fenic 的核心操作符进行语义抽取与分类。                                                          |
| [Enrichment](examples/enrichment)                                         | 通过日志丰富演示基于模板的文本抽取、多阶段 DataFrame、连接和 LLM 驱动的转换。                                                  |
| [会议记录处理](examples/meeting_transcript_processing)                    | 通过会议分析展示原生转录解析、Pydantic 模式集成和复杂聚合操作。                                                                |
| [新闻分析](examples/news_analysis)                                        | 使用语义操作符和结构化数据处理，对新闻文章进行分析并提取见解。                                                                  |
| [播客摘要](examples/podcast_summarization)                                | 处理和总结播客转录，进行基于说话人的分析和要点提取。                                                                            |
| [语义连接](examples/semantic_joins)                                       | 不仅仅是简单的模糊匹配，使用 fenic 强大的语义连接功能实现跨表数据匹配。                                                        |
| [命名实体识别](examples/named_entity_recognition)                         | 通过语义抽取与分类从文本中提取和识别命名实体。                                                                                 |
| [Markdown 处理](examples/markdown_processing)                             | 通过结构化数据抽取与格式转换，处理和转换 Markdown 文档。                                                                       |
| [JSON 处理](examples/json_processing)                                     | 通过语义操作和模式校验处理复杂的 JSON 数据结构。                                                                                |
| [反馈聚类](examples/feedback_clustering)                                  | 利用语义相似性和聚类操作对反馈进行分组与分析。                                                                                 |
| [文档抽取](examples/document_extraction)                                  | 使用语义操作符从各种文档格式中提取结构化信息。                                                                                 |

（欢迎点击上方任意示例，直接跳转到对应文件夹。）
## 为什么使用 fenic？

fenic 是一个具有主观性的、受 PySpark 启发的数据框架，专为构建生产级 AI 和智能体应用而设计。

与为 LLMs 改造的传统数据工具不同，fenic 的查询引擎自底向上为推理场景而构建。

使用增强了语义智能的熟悉 DataFrame 操作，将结构化和非结构化数据转化为洞察。对 markdown、转录文本和语义操作符提供一流支持，并能高效地跨任意模型提供商进行批量推理。

fenic 为 AI 工作负载带来了传统数据管道的可靠性。

### 主要特性

#### 为 LLM 推理专门构建

- 查询引擎从零开始为 AI 工作负载设计，而非后期改造
- API 调用的自动批量优化
- 内置重试逻辑和速率限制
- Token 计数和成本追踪

#### 语义操作符作为一等公民
- `semantic.analyze_sentiment` - 内置情感分析
- `semantic.classify` - 使用少量示例对文本进行分类
- `semantic.extract` - 通过模式将非结构化文本转化为结构化数据
- `semantic.group_by` - 按语义相似性对数据进行分组
- `semantic.join` - 基于语义（不仅仅是数值）进行 DataFrame 连接
- `semantic.map` - 应用自然语言转换
- `semantic.predicate` - 使用自然语言创建谓词以过滤行
- `semantic.reduce` - 使用 LLM 操作对分组数据进行聚合

#### 原生非结构化数据支持

不仅仅支持常见的多模态数据类型（音频、图像），还为以文本为主的工作负载创建了专用类型：

- 作为一等数据类型的 Markdown 解析与提取
- 支持说话人和时间戳识别的转录处理（SRT、通用格式）
- 使用 JQ 表达式对嵌套数据进行 JSON 操作
- 针对长文档的自动文本分块，并可配置重叠部分

#### 生产级基础设施
- 多提供商支持（OpenAI、Anthropic、Gemini）
- 本地和云端执行后端
- 全面的错误处理和日志记录
- 集成 Pydantic 实现类型安全

#### 熟悉的 DataFrame API

- 兼容 PySpark 的操作
- 惰性求值与查询优化
- 支持复杂查询的 SQL
- 与现有数据管道的无缝集成

### 为什么为 LLM 和 Agentic 应用选择 DataFrame？

AI 和 Agentic 应用本质上是管道和工作流——这正是 DataFrame API 的设计初衷。fenic 没有重新发明数据转换、过滤和聚合的模式，而是利用了几十年来经过验证的工程实践。

#### 为更优代理提供解耦架构

fenic 在重型推理任务与实时代理交互之间建立了清晰的分离。通过将批处理移出代理运行时，您将获得：

- 更可预测和响应迅速的代理
- 通过批量 LLM 调用实现更优的资源利用
- 规划/编排与执行之间更清晰的分离
#### 为所有工程师而打造

DataFrame 不仅仅适用于数据从业者。流畅、可组合的 API 设计让任何工程师都能轻松上手：

- 自然地链式操作：`df.filter(...).semantic.group_by(...)`
- 无缝混合命令式和声明式风格
- 借助 pandas/PySpark 或 SQL 的熟悉模式快速上手

## 支持

欢迎加入我们的 [Discord 社区](https://discord.gg/GdqF3J7huR)，在这里你可以与其他用户交流、提问，并获得 fenic 项目的帮助。我们的社区始终欢迎新成员的加入！

如果你觉得 fenic 有用，请考虑在本仓库顶部为我们点一个 ⭐。你的支持有助于我们不断发展和完善这个框架，惠及更多人！

## 贡献

我们欢迎各种形式的贡献！无论你是想编写代码、完善文档、测试功能，还是提出新想法，你的帮助对我们都非常宝贵。

对于计划提交代码更改的开发者，我们建议你先提交 issue 讨论你的想法，再创建 Pull Request。这有助于确保与项目方向一致，并避免重复劳动。

请参阅我们的[贡献指南](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md)，了解开发流程和项目配置的详细信息。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---