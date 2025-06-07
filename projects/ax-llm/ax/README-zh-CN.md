# Ax，TypeScript 的 DSPy

与 LLM 协作很复杂——它们并不总是按你的意愿行事。DSPy 让基于 LLM 的创新变得更简单。你只需定义输入和输出（签名），即可自动生成高效提示并使用。将不同签名连接起来，搭建基于 LLM 的复杂系统和工作流。

为了让你真正能在生产环境中用好这些，我们还提供了观测性、流式处理、支持多模态（图像、音频等）、错误修正、多步函数调用、MCP、RAG 等完整能力。

[![NPM Package](https://img.shields.io/npm/v/@ax-llm/ax?style=for-the-badge&color=green)](https://www.npmjs.com/package/@ax-llm/ax)
[![Discord Chat](https://dcbadge.vercel.app/api/server/DSHg3dU7dW?style=for-the-badge)](https://discord.gg/DSHg3dU7dW)
[![Twitter](https://img.shields.io/twitter/follow/dosco?style=for-the-badge&color=red)](https://twitter.com/dosco)

<!-- header -->

## 为什么选择 Ax？

- 所有主流 LLM 的标准接口
- 由简单签名自动生成提示词
- 完全原生的端到端流式处理
- 支持思考预算和思考 Token
- 构建可调用其他 Agent 的智能体
- 内置 MCP（模型上下文协议）支持
- 任意格式文档转文本
- RAG、智能分块、嵌入、查询
- 可与 Vercel AI SDK 配合使用
- 流式输出校验
- 支持多模态 DSPy
- 自动使用优化器调整提示
- OpenTelemetry 追踪/观测性
- 生产级 TypeScript 代码
- 轻量、零依赖

## 生产可用

- 小版本无破坏性变更
- 大量测试覆盖
- 内置 Open Telemetry `gen_ai` 支持
- 已被创业公司广泛用于生产环境

## 什么是提示签名？

<img width="860" alt="shapes at 24-03-31 00 05 55" src="https://raw.githubusercontent.com/ax-llm/ax/main/https://github.com/dosco/llm-client/assets/832235/0f0306ea-1812-4a0a-9ed5-76cd908cd26b">

高效且类型安全的提示词由简单签名自动生成。提示签名由 `"任务描述" 输入字段:类型 "字段描述" -> 输出字段:类型` 组成。提示签名的理念源自 “Demonstrate-Search-Predict” 论文。

你可以有多个输入和输出字段，每个字段类型可以为 `string`、`number`、`boolean`、`date`、`datetime`、`class "class1, class2"`、`JSON` 或这些类型的数组（如 `string[]`）。未定义类型时默认是 `string`。后缀 `?` 表示字段可选（默认必填），`!` 表示内部字段，适用于推理等用途。

## 输出字段类型

| 类型                      | 描述                              | 用法                      | 输出示例                                               |
| ------------------------- | --------------------------------- | ------------------------- | ------------------------------------------------------ |
| `string`                  | 字符串序列                        | `fullName:string`         | `"example"`                                            |
| `number`                  | 数值                              | `price:number`            | `42`                                                   |
| `boolean`                 | 布尔值                            | `isEvent:boolean`         | `true`, `false`                                        |
| `date`                    | 日期                              | `startDate:date`          | `"2023-10-01"`                                         |
| `datetime`                | 日期和时间                        | `createdAt:datetime`      | `"2023-10-01T12:00:00Z"`                               |
| `class "class1,class2"`   | 类别分类                          | `category:class`          | `["class1", "class2", "class3"]`                       |
| `string[]`                | 字符串数组                        | `tags:string[]`           | `["example1", "example2"]`                             |
| `number[]`                | 数字数组                          | `scores:number[]`         | `[1, 2, 3]`                                            |
| `boolean[]`               | 布尔值数组                        | `permissions:boolean[]`   | `[true, false, true]`                                  |
| `date[]`                  | 日期数组                          | `holidayDates:date[]`     | `["2023-10-01", "2023-10-02"]`                         |
| `datetime[]`              | 日期时间数组                      | `logTimestamps:datetime[]`| `["2023-10-01T12:00:00Z", "2023-10-02T12:00:00Z"]`     |
| `class[] "class1,class2"` | 多类别                            | `categories:class[]`      | `["class1", "class2", "class3"]`                       |
| `code "language"`         | 指定语言代码块                    | `code:code "python"`      | `print('Hello, world!')`                               |

## 支持的 LLM

`Google Gemini`、`OpenAI`、`Azure OpenAI`、`Anthropic`、`X Grok`、`TogetherAI`、`Cohere`、`Mistral`、`Groq`、`DeepSeek`、`Ollama`、`Reka`、`Hugging Face`

## 安装

```bash
npm install @ax-llm/ax
# 或
yarn add @ax-llm/ax
```

## 示例：用 chain-of-thought 摘要文本

```typescript
import { AxAI, AxChainOfThought } from '@ax-llm/ax'

const textToSummarize = `
The technological singularity—or simply the singularity[1]—is a hypothetical future point in time at which technological growth becomes uncontrollable and irreversible, resulting in unforeseeable changes to human civilization.[2][3] ...`

const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY as string,
})

const gen = new AxChainOfThought(
  `textToSummarize -> textType:class "note, email, reminder", shortSummary "summarize in 5 to 10 words"`
)

const res = await gen.forward(ai, { textToSummarize })

console.log('>', res)
```

## 示例：构建 Agent

通过 Agent 提示（框架）创建可与其他 Agent 协作完成任务的 Agent。使用提示签名创建 Agent 十分简单。试试下面的例子。

```typescript
# npm run tsx ./src/examples/agent.ts

const researcher = new AxAgent({
  name: 'researcher',
  description: 'Researcher agent',
  signature: `physicsQuestion "physics questions" -> answer "reply in bullet points"`
});

const summarizer = new AxAgent({
  name: 'summarizer',
  description: 'Summarizer agent',
  signature: `text "text so summarize" -> shortSummary "summarize in 5 to 10 words"`
});

const agent = new AxAgent({
  name: 'agent',
  description: 'A an agent to research complex topics',
  signature: `question -> answer`,
  agents: [researcher, summarizer]
});

agent.forward(ai, { questions: "How many atoms are there in the universe" })
```

## 思考模型支持

Ax 原生支持具备思考能力的模型，可控制思考 Token 预算并访问模型思考过程，有助于理解模型推理并优化 Token 使用。

```typescript
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY as string,
  config: {
    model: AxAIGoogleGeminiModel.Gemini25Flash,
    thinking: { includeThoughts: true },
  },
})

// 或按请求控制思考预算
const gen = new AxChainOfThought(`question -> answer`)
const res = await gen.forward(
  ai,
  { question: 'What is quantum entanglement?' },
  { thinkingTokenBudget: 'medium' } // 'minimal', 'low', 'medium', 'high'
)

// 在响应中访问思考过程
console.log(res.thoughts) // 显示模型推理过程
```

## 支持的向量数据库

向量数据库对搭建 LLM 工作流至关重要。Ax 提供对主流向量数据库的抽象，以及自有的内存型向量数据库。

| 提供商      | 测试覆盖 |
| ----------- | -------- |
| 内存        | 🟢 100%  |
| Weaviate    | 🟢 100%  |
| Cloudflare  | 🟡 50%   |
| Pinecone    | 🟡 50%   |

```typescript
// 使用 LLM 从文本生成 embedding
const ret = await this.ai.embed({ texts: 'hello world' })

// 创建内存向量数据库
const db = new axDB('memory')

// 插入向量数据库
await this.db.upsert({
  id: 'abc',
  table: 'products',
  values: ret.embeddings[0],
})

// 使用 embedding 查询相似项
const matches = await this.db.query({
  table: 'products',
  values: embeddings[0],
})
```

你也可以用 `AxDBManager`，它自动处理分块、嵌入和查询，极其简便。

```typescript
const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query(
  'John von Neumann on human intelligence and singularity.'
)
console.log(matches)
```

## RAG 文档

用 LLM 处理 PDF、DOCX、PPT、XLS 等文档很繁琐。我们借助 Apache Tika（一款开源文档处理引擎）让这一切变得简单。

启动 Apache Tika

```shell
docker run -p 9998:9998 apache/tika
```

用 `AxDBManager` 将文档转为文本并嵌入用于检索，同时支持 reranker 和 query rewriter。默认实现有 `AxDefaultResultReranker` 和 `AxDefaultQueryRewriter`。

```typescript
const tika = new AxApacheTika()
const text = await tika.convert('/path/to/document.pdf')

const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query('Find some text')
console.log(matches)
```

## 多模态 DSPy

对于支持多模态提示的模型（如 `GPT-4o`、`Gemini`），我们支持图像字段，并可与整个 DSP 流水线协同工作。

```typescript
const image = fs
  .readFileSync('./src/examples/assets/kitten.jpeg')
  .toString('base64')

const gen = new AxChainOfThought(`question, animalImage:image -> answer`)

const res = await gen.forward(ai, {
  question: 'What family does this animal belong to?',
  animalImage: { mimeType: 'image/jpeg', data: image },
})
```

对于支持音频的多模态模型（如 `gpt-4o-audio-preview`），也支持音频字段，兼容 DSP 流水线。

```typescript
const audio = fs
  .readFileSync('./src/examples/assets/comment.wav')
  .toString('base64')

const gen = new AxGen(`question, commentAudio:audio -> answer`)

const res = await gen.forward(ai, {
  question: 'What family does this animal belong to?',
  commentAudio: { format: 'wav', data: audio },
})
```

## DSPy 聊天接口

受 DSPy 演示编织启发，Ax 提供 `AxMessage` 用于无缝管理会话历史。可构建上下文连贯的聊天机器人和对话代理，同时利用提示签名全部能力。详情见示例。

```shell
GOOGLE_APIKEY=api-key npm run tsx ./src/examples/chat.ts
```

```typescript
const chatBot = new AxGen<
  { message: string } | ReadonlyArray<ChatMessage>,
  { reply: string }
>(
  `message:string "A casual message from the user" -> reply:string "A friendly, casual response"`
)

await chatBot.forward(ai, [
  {
    role: 'user',
    values: { message: 'Hi! How are you doing today?' },
  },
  {
    role: 'assistant',
    values: { reply: 'I am doing great! How about you?' },
  },
  {
    role: 'user',
    values: { message: 'Thats great!' },
  },
])
```

会话历史自动编织进提示词，模型可保持上下文，输出连贯。这与 Ax 的所有特性（如流式、函数调用、chain-of-thought）无缝协作。

## 流式处理

### 断言

我们支持流式解析输出字段和函数执行。这样可快速失败和纠错，无需等待全部输出，节省 Token、降低延迟和成本。断言可确保输出符合要求，流式处理同样有效。

```typescript
// 设置提示程序
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

// 添加断言，确保输出字段不包含数字 5
gen.addAssert(({ next10Numbers }: Readonly<{ next10Numbers: number[] }>) => {
  return next10Numbers ? !next10Numbers.includes(5) : undefined
}, 'Numbers 5 is not allowed')

// 启用流式执行
const res = await gen.forward({ startNumber: 1 }, { stream: true })

// 或端到端流式执行
const generator = await gen.streamingForward(
  { startNumber: 1 },
  {
    stream: true,
  }
)
for await (const res of generator) {
}
```

上述例子支持在流入时验证整个输出字段。该校验既适用于流式，也适用于非流式，完整字段值可用时触发。要在流式过程中真正逐步校验，请参考下例。这将极大提升性能并节省生产 Token 成本。

```typescript
// 添加流式断言，确保所有行以数字加点开头
gen.addStreamingAssert(
  'answerInPoints',
  (value: string) => {
    const re = /^\d+\./

    // 按行分割，修剪，过滤空行，检查每行是否匹配正则
    return value
      .split('\n')
      .map((x) => x.trim())
      .filter((x) => x.length > 0)
      .every((x) => re.test(x))
  },
  'Lines must start with a number and a dot. Eg: 1. This is a line.'
)

// 启用流式执行
const res = await gen.forward(
  {
    question: 'Provide a list of optimizations to speedup LLM inference.',
  },
  { stream: true, debug: true }
)
```

### 字段处理器

字段处理器可对提示中的字段进行处理，在发送给 LLM 之前处理字段。

```typescript
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

const streamValue = false

const processorFunction = (value) => {
  return value.map((x) => x + 1)
}

// 添加字段处理器
const processor = new AxFieldProcessor(
  gen,
  'next10Numbers',
  processorFunction,
  streamValue
)

const res = await gen.forward({ startNumber: 1 })
```

## 模型上下文协议（MCP）

Ax 无缝集成 MCP（Model Context Protocol），让你的 Agent 可通过标准接口访问外部工具和资源。

### 使用 AxMCPClient

`AxMCPClient` 允许你连接任何 MCP 兼容服务器，并在 Ax Agent 中使用其能力：

```typescript
import { AxMCPClient, AxMCPStdioTransport } from '@ax-llm/ax'

// 用指定传输方式初始化 MCP 客户端
const transport = new AxMCPStdioTransport({
  command: 'npx',
  args: ['-y', '@modelcontextprotocol/server-memory'],
})

// 可选调试模式创建客户端
const client = new AxMCPClient(transport, { debug: true })

// 初始化连接
await client.init()

// 在 Agent 中使用客户端功能
const memoryAgent = new AxAgent({
  name: 'MemoryAssistant',
  description: 'An assistant with persistent memory',
  signature: 'input, userId -> response',
  functions: [client], // 作为函数提供者传递客户端
})

// 或与 AxGen 配合
const memoryGen = new AxGen('input, userId -> response', {
  functions: [client],
})
```

### 远程 MCP 服务器示例

调用远程 MCP 服务器很简单。比如，使用 DeepWiki MCP 服务器查询公开 GitHub 仓库。DeepWiki MCP 服务器地址：`https://mcp.deepwiki.com/mcp`。

```typescript
import {
  AxAgent,
  AxAI,
  AxAIOpenAIModel,
  AxMCPClient,
  AxMCPStreambleHTTPTransport,
} from '@ax-llm/ax'

// 1. 连接 DeepWiki 服务器
const transport = new AxMCPStreambleHTTPTransport(
  'https://mcp.deepwiki.com/mcp'
)

// 2. 创建 MCP 客户端
const mcpClient = new AxMCPClient(transport, { debug: false })
await mcpClient.init() // 初始化连接

// 3. 初始化 AI 模型（如 OpenAI）
// 确保 OPENAI_APIKEY 环境变量已设置
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY as string,
})

// 4. 创建使用 MCP 客户端的 Agent
const deepwikiAgent = new AxAgent<
  {
    // 输入类型定义，匹配 DeepWiki 函数
    questionAboutRepo: string
    githubRepositoryUrl: string
  },
  {
    answer: string
  }
>({
  name: 'DeepWikiQueryAgent',
  description: 'Agent to query public GitHub repositories via DeepWiki MCP.',
  signature: 'questionAboutRepo, githubRepositoryUrl -> answer',
  functions: [mcpClient], // 提供 MCP 客户端
})

// 5. 提问并调用 Agent
const result = await deepwikiAgent.forward(ai, {
  questionAboutRepo: 'What is the main purpose of this library?',
  githubRepositoryUrl: 'https://github.com/dosco/ax', // 例：Ax 库本身
})
console.log('DeepWiki Answer:', result.answer)
```

该示例展示如何连接公开 MCP 服务器并在 Ax Agent 中使用。Agent 的签名（`questionAboutRepo, githubRepositoryUrl -> answer`）是对 DeepWiki 服务接口的假设，实际可通过 MCP 服务器（如 `mcp.getFunctions` 或文档）获知接口详情。

更复杂示例（如认证、定制 Header）请参考本仓库 `src/examples/mcp-client-pipedream.ts`。

## AI 路由与负载均衡

Ax 提供两种强大多 AI 服务协作方式：负载均衡（高可用）与路由（模型路由）。

### 负载均衡

负载均衡器根据性能与可用性自动分配请求。如遇服务故障自动切换。

```typescript
import { AxAI, AxBalancer } from '@ax-llm/ax'

// 设置多个 AI 服务
const openai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
})

const ollama = new AxAI({
  name: 'ollama',
  config: { model: 'nous-hermes2' },
})

const gemini = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY,
})

// 创建负载均衡器
const balancer = new AxBalancer([openai, ollama, gemini])

// 像普通 AI 服务一样使用——自动选择最优服务
const response = await balancer.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
})

// 或配合 AxGen 使用
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(balancer, { question: 'Hello!' })
```

### 多服务路由

路由器让你通过统一接口使用多个 AI 服务，自动按模型选择合适服务。

```typescript
import { AxAI, AxAIOpenAIModel, AxMultiServiceRouter } from '@ax-llm/ax'

// 配置 OpenAI 模型列表
const openai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
  models: [
    {
      key: 'basic',
      model: AxAIOpenAIModel.GPT4OMini,
      description:
        'Model for very simple tasks such as answering quick short questions',
    },
    {
      key: 'medium',
      model: AxAIOpenAIModel.GPT4O,
      description:
        'Model for semi-complex tasks such as summarizing text, writing code, and more',
    },
  ],
})

// 配置 Gemini 模型列表
const gemini = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY,
  models: [
    {
      key: 'deep-thinker',
      model: 'gemini-2.0-flash-thinking',
      description:
        'Model that can think deeply about a task, best for tasks that require planning',
    },
    {
      key: 'expert',
      model: 'gemini-2.0-pro',
      description:
        'Model that is the best for very complex tasks such as writing large essays, complex coding, and more',
    },
  ],
})

const ollama = new AxAI({
  name: 'ollama',
  config: { model: 'nous-hermes2' },
})

const secretService = {
  key: 'sensitive-secret',
  service: ollama,
  description: 'Model for sensitive secrets tasks',
}

// 创建路由器
const router = new AxMultiServiceRouter([openai, gemini, secretService])

// 路由到 OpenAI 的 expert 模型
const openaiResponse = await router.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
  model: 'expert',
})

// 或配合 AxGen 使用
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(router, { question: 'Hello!' })
```

负载均衡适合高可用，路由适合按任务精准匹配模型。二者均支持 Ax 所有特性（流式、函数调用、chain-of-thought 等）。

你可将负载均衡与路由结合使用，路由内含多个均衡器或反之。

## OpenTelemetry 支持

可追踪和观测 LLM 工作流对生产环境至关重要。OpenTelemetry 是行业标准，我们支持新 `gen_ai` 属性命名空间。详情见 `src/examples/telemetry.ts`。

```typescript
import { trace } from '@opentelemetry/api'
import {
  BasicTracerProvider,
  ConsoleSpanExporter,
  SimpleSpanProcessor,
} from '@opentelemetry/sdk-trace-base'

const provider = new BasicTracerProvider()
provider.addSpanProcessor(new SimpleSpanProcessor(new ConsoleSpanExporter()))
trace.setGlobalTracerProvider(provider)

const tracer = trace.getTracer('test')

const ai = new AxAI({
  name: 'ollama',
  config: { model: 'nous-hermes2' },
  options: { tracer },
})

const gen = new AxChainOfThought(
  ai,
  `text -> shortSummary "summarize in 5 to 10 words"`
)

const res = await gen.forward({ text })
```

```json
{
  "traceId": "ddc7405e9848c8c884e53b823e120845",
  "name": "Chat Request",
  "id": "d376daad21da7a3c",
  "kind": "SERVER",
  "timestamp": 1716622997025000,
  "duration": 14190456.542,
  "attributes": {
    "gen_ai.system": "Ollama",
    "gen_ai.request.model": "nous-hermes2",
    "gen_ai.request.max_tokens": 500,
    "gen_ai.request.temperature": 0.1,
    "gen_ai.request.top_p": 0.9,
    "gen_ai.request.frequency_penalty": 0.5,
    "gen_ai.request.llm_is_streaming": false,
    "http.request.method": "POST",
    "url.full": "http://localhost:11434/v1/chat/completions",
    "gen_ai.usage.completion_tokens": 160,
    "gen_ai.usage.prompt_tokens": 290
  }
}
```

## 提示调整（基础）

你可以用更大的模型优化提示词，提高效率和效果。比如用 `AxBootstrapFewShot` 优化器和 HotPotQA 数据集示例。优化器会生成演示 `demos`，配合提示提升效率。

```typescript
// 从 huggingface 下载 HotPotQA 数据集
const hf = new AxHFDataLoader({
  dataset: 'hotpot_qa',
  split: 'train',
})

const examples = await hf.getData<{ question: string; answer: string }>({
  count: 100,
  fields: ['question', 'answer'],
})

const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY as string,
})

// 待优化程序
const program = new AxChainOfThought<{ question: string }, { answer: string }>(
  ai,
  `question -> answer "in short 2 or 3 words"`
)

// 配置 Bootstrap Few Shot 优化器
const optimize = new AxBootstrapFewShot<
  { question: string },
  { answer: string }
>({
  program,
  examples,
})

// 设置评估指标 em，f1 等
const metricFn: AxMetricFn = ({ prediction, example }) =>
  emScore(prediction.answer as string, example.answer as string)

// 执行优化，并保存结果
const result = await optimize.compile(metricFn);

// 保存演示到文件
// import fs from 'fs'; // 实际脚本中需引入 fs
fs.writeFileSync('bootstrap-demos.json', JSON.stringify(result.demos, null, 2));
console.log('Demos saved to bootstrap-demos.json');
```

<img width="853" alt="tune-prompt" src="https://raw.githubusercontent.com/ax-llm/ax/main/https://github.com/dosco/llm-client/assets/832235/f924baa7-8922-424c-9c2c-f8b2018d8d74">
```

## 提示调整（进阶，Mipro v2）

MiPRO v2 是一款高级提示优化框架，基于贝叶斯优化自动寻找最佳指令、演示和示例组合，无需手工调优最大化 LLM 程序性能。

### 主要特性

- **指令优化**：自动生成并测试多种指令候选
- **Few-shot 示例筛选**：自动选取最优演示
- **智能贝叶斯优化**：UCB（上置信界）策略高效探索
- **提前终止**：提升停滞时自动停止，节省算力
- **程序/数据感知**：结合程序结构与数据集特征

### 工作原理

1. 生成多种指令候选
2. 从数据自举 few-shot 示例
3. 直接从数据集中选择标注示例
4. 贝叶斯优化找最佳组合
5. 应用最优配置到程序

### 基本用法

```typescript
import { AxAI, AxChainOfThought, AxMiPRO } from '@ax-llm/ax'

// 1. 配置 AI 服务
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY,
})

// 2. 创建程序
const program = new AxChainOfThought(`input -> output`)

// 3. 配置优化器
const optimizer = new AxMiPRO({
  ai,
  program,
  examples: trainingData, // 你的训练样本
  options: {
    numTrials: 20, // 尝试的配置数
    auto: 'medium', // 优化级别
  },
})

// 4. 定义评估指标
const metricFn = ({ prediction, example }) => {
  return prediction.output === example.output
}

// 5. 执行优化
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData, // 可选验证集
})

// 6. 使用优化后的程序
const result = await optimizedProgram.forward(ai, { input: 'test input' })
```

### 配置选项

MiPRO v2 提供丰富配置选项：

| 选项                      | 说明                                     | 默认值  |
| ------------------------- | ---------------------------------------- | ------- |
| `numCandidates`           | 生成指令候选数                           | 5       |
| `numTrials`               | 优化尝试次数                             | 30      |
| `maxBootstrappedDemos`    | 自举演示最大数量                         | 3       |
| `maxLabeledDemos`         | 标注示例最大数量                         | 4       |
| `minibatch`               | 是否使用小批量加速评估                   | true    |
| `minibatchSize`           | 小批量大小                               | 25      |
| `earlyStoppingTrials`     | 无提升时终止尝试次数                     | 5       |
| `minImprovementThreshold` | 最小得分提升阈值                         | 0.01    |
| `programAwareProposer`    | 程序结构感知                              | true    |
| `dataAwareProposer`       | 考虑数据集特征                            | true    |
| `verbose`                 | 显示优化过程详情                          | false   |
| abort-patterns.ts | 如何中止请求示例                              |

### 优化级别

你可用 `auto` 参数快速配置优化强度：

```typescript
// 轻量优化（快，覆盖少）
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'light' })

// 中等优化（平衡）
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'medium' })

// 重度优化（慢，覆盖多）
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'heavy' })
```

### 高级示例：情感分析

```typescript
// 创建情感分析程序
const classifyProgram = new AxChainOfThought<
  { productReview: string },
  { label: string }
>(`productReview -> label:string "positive" or "negative"`)

// 配置优化器
const optimizer = new AxMiPRO({
  ai,
  program: classifyProgram,
  examples: trainingData,
  options: {
    numCandidates: 3,
    numTrials: 10,
    maxBootstrappedDemos: 2,
    maxLabeledDemos: 3,
    earlyStoppingTrials: 3,
    programAwareProposer: true,
    dataAwareProposer: true,
    verbose: true,
  },
})

// 执行优化并保存结果
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData,
})

// 保存配置
const programConfig = JSON.stringify(optimizedProgram, null, 2);
await fs.promises.writeFile("./optimized-config.json", programConfig);
console.log('> Done. Optimized program config saved to optimized-config.json');
```

## 使用已调优提示

基础 Bootstrap Few Shot 优化器和高级 MiPRO v2 优化器都会生成显著提升程序性能的 **demos**（演示）。这些示例可指导 LLM 处理类似任务。

### 什么是 Demo？

Demo 是输入-输出示例，会自动包含在提示词中，引导 LLM 学习特定任务的预期行为。

### 加载与使用 Demo

不论用哪种优化器，加载 demo 的方式一致：

```typescript
import fs from 'fs'
import { AxAI, AxGen, AxChainOfThought } from '@ax-llm/ax'

// 1. 配置 AI 服务
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
})

// 2. 创建程序（与调优时签名一致）
const program = new AxChainOfThought(`question -> answer "in short 2 or 3 words"`)

// 3. 从文件加载 demo
const demos = JSON.parse(fs.readFileSync('bootstrap-demos.json', 'utf8'))

// 4. 应用 demo 到程序
program.setDemos(demos)

// 5. 使用增强后的程序
const result = await program.forward(ai, {
  question: 'What castle did David Gregory inherit?'
})

console.log(result) // 现在表现更优
```

### 简单示例：文本分类

以下完整示例展示 demo 如何提升分类任务：

```typescript
// 创建分类程序
const classifier = new AxGen(`text -> category:class "positive, negative, neutral"`)

// 加载 Bootstrap 或 MiPRO 调优生成的 demo
const savedDemos = JSON.parse(fs.readFileSync('classification-demos.json', 'utf8'))
classifier.setDemos(savedDemos)

// 现在分类器已学习示例，效果更佳
const result = await classifier.forward(ai, {
  text: "This product exceeded my expectations!"
})

console.log(result.category) // 分类更准确
```

### Demo 的主要优势

- **提升准确率**：使用相关示例，效果明显提升
- **输出一致性**：demo 保证输出格式统一
- **降低幻觉**：示例引导模型行为
- **成本可控**：无需更大/更贵模型即可提升效果

### 最佳实践

1. **保存 Demo**：一定要保存 demo 文件，便于复用
2. **签名匹配**：加载 demo 时签名需完全一致
3. **版本管理**：将 demo 文件纳入版本管理，保证可复现
4. **定期更新**：用新数据定期调优 demo

Bootstrap Few Shot 与 MiPRO v2 生成的 demo 格式一致，加载方式通用。

## 内置函数

| 功能               | 名称                 | 描述                                      |
| ------------------ | -------------------- | ----------------------------------------- |
| JS 解释器          | AxJSInterpreter      | 在沙箱环境执行 JS 代码                    |
| Docker 沙箱        | AxDockerSession      | 在 Docker 环境中执行命令                  |
| 嵌入适配器         | AxEmbeddingAdapter   | 获取嵌入并传递给你的函数                  |

## 查看所有示例

用 `tsx` 命令运行示例，可直接运行 TypeScript 代码，也支持 `.env` 传递 AI API Key，无需写在命令行。

```shell
OPENAI_APIKEY=api-key npm run tsx ./src/examples/marketing.ts
```

| 示例                     | 描述                                             |
| ------------------------ | ------------------------------------------------ |
| customer-support.ts      | 从客户沟通中提取有价值信息                       |
| function.ts              | 单一函数调用示例                                 |
| food-search.ts           | 多步多函数调用示例                               |
| marketing.ts             | 生成简短高效的营销短信                           |
| vectordb.ts              | 分块、嵌入和搜索文本                             |
| fibonacci.ts             | 用 JS 代码解释器计算斐波那契数                   |
| summarize.ts             | 对大段文本生成简短摘要                           |
| chain-of-thought.ts      | 用 chain-of-thought 提示回答问题                 |
| rag.ts                   | 用多跳检索回答问题                               |
| rag-docs.ts              | PDF 转文本并嵌入用于 RAG 检索                    |
| react.ts                 | 函数调用与推理回答问题                           |
| agent.ts                 | Agent 框架，Agent 可调用其他 Agent、工具等       |
| streaming1.ts            | 流式校验输出字段                                 |
| streaming2.ts            | 每输出字段流式校验                               |
| streaming3.ts            | 端到端流式示例 `streamingForward()`              |
| smart-hone.ts            | 智能体在智能家居中寻找狗                         |
| multi-modal.ts           | 输入图片与文本联合处理                           |
| balancer.ts              | 按成本等平衡多 LLM                              |
| docker.ts                | 用 docker 沙箱按描述查找文件                     |
| prime.ts                 | 用字段处理器处理提示字段                         |
| simple-classify.ts       | 简单分类器分类示例                               |
| mcp-client-memory.ts     | 用 MCP 服务器实现 Agent 记忆                     |
| mcp-client-blender.ts    | 用 MCP 服务器集成 Blender                        |
| mcp-client-pipedream.ts  | 远程 MCP 集成示例                                |
| tune-bootstrap.ts        | 用 bootstrap 优化器提升提示效率                  |
| tune-mipro.ts            | 用 mipro v2 优化器提升提示效率                   |
| tune-usage.ts            | 使用优化后的提示                                 |
| telemetry.ts             | 追踪并推送 trace 到 Jaeger                       |
| openai-responses.ts      | OpenAI Responses API 示例                        |
| use-examples.ts | 用 'examples' 引导 llm 示例                        |

## 我们的目标

大模型（LLM）愈发强大，已能作为整产品的后端。但实际使用需管理大量复杂性，如提示、模型、流式、函数调用、错误修正等。我们致力于将所有复杂性封装进易用、高维护库，兼容所有 SOTA LLM，并用最新研究成果（如 DSPy）不断拓展能力。

## 如何使用本库？

### 1. 选择一个 AI

```ts
// 选择 LLM
const ai = new AxOpenAI({ apiKey: process.env.OPENAI_APIKEY } as AxOpenAIArgs)
```

### 2. 创建适用场景的提示签名

```ts
// 签名定义输入输出
const cot = new ChainOfThought(ai, `question:string -> answer:string`, { mem })
```

### 3. 执行提示程序

```ts
// 传入签名定义的输入字段
const res = await cot.forward({ question: 'Are we in a simulation?' })
```

### 4. 或直接用 LLM

```ts
const res = await ai.chat([
  { role: "system", content: "Help the customer with his questions" }
  { role: "user", content: "I'm looking for a Macbook Pro M2 With 96GB RAM?" }
]);
```

## 如何使用函数调用

### 1. 定义函数

```ts
// 定义一个或多个函数及其处理器
const functions = [
  {
    name: 'getCurrentWeather',
    description: 'get the current weather for a location',
    parameters: {
      type: 'object',
      properties: {
        location: {
          type: 'string',
          description: 'location to get weather for',
        },
        units: {
          type: 'string',
          enum: ['imperial', 'metric'],
          default: 'imperial',
          description: 'units to use',
        },
      },
      required: ['location'],
    },
    func: async (args: Readonly<{ location: string; units: string }>) => {
      return `The weather in ${args.location} is 72 degrees`
    },
  },
]
```

### 2. 将函数传给提示

```ts
const cot = new AxGen(ai, `question:string -> answer:string`, { functions })
```

## 启用调试日志

```ts
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
} as AxOpenAIArgs)
ai.setOptions({ debug: true })
```

## 联系我们

欢迎提问或加入 Discord 交流  
[twitter/dosco](https://twitter.com/dosco)

## 常见问题

### 1. LLM 找不到正确函数

请优化函数名和描述，确保说明清晰，参数描述简洁而精确。

### 2. 如何更改 LLM 配置？

创建 LLM 对象时传入配置对象即可。

```ts
const apiKey = process.env.OPENAI_APIKEY
const conf = AxOpenAIBestConfig()
const ai = new AxOpenAI({ apiKey, conf } as AxOpenAIArgs)
```

## 3. 提示太长 / 如何调整最大 Token？

```ts
const conf = axOpenAIDefaultConfig() // 或 OpenAIBestOptions()
conf.maxTokens = 2000
```

## 4. 如何更换模型（如用 GPT4）？

```ts
const conf = axOpenAIDefaultConfig() // 或 OpenAIBestOptions()
conf.model = OpenAIModel.GPT4Turbo
```

## Monorepo 小贴士

务必只在根目录运行 `npm install`，避免生成嵌套 `package-lock.json` 和未去重的 `node_modules`。

如需为包新增依赖，请用 `npm install lodash --workspace=ax`（或直接修改对应 `package.json` 后在根目录 `npm install`）。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---