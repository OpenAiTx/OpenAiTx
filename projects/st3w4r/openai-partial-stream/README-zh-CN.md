# 解析部分 JSON 流 - 将你的慢速 AI 应用变成引人入胜的实时应用

- 在流结束前，将**令牌流**转换为**可解析的 JSON**对象。
- 在基于**大语言模型（LLM）**的 AI 应用中实现**流式 UI**。
- 利用**OpenAI 函数调用**进行早期流处理。
- 将**JSON 流**解析为不同的**实体**。
- 通过**实时**体验吸引用户。

![json_stream_color](https://github.com/st3w4r/openai-partial-stream/assets/4228332/04c4bdfc-d991-4ad0-85fc-04eb35b106f3)

## 关注动态

- [✖️ Twitter](https://twitter.com/YanaelBarbier)
- [🧵 Threads](https://www.threads.net/@yanaelbarbier)
- [📰 博客](https://yanael.io/subscribe/)

## 安装

安装依赖：

```bash
npm install --save openai-partial-stream
```

## 简单流的使用

尽快将一个标记流转换为可解析的 JSON 对象。

```javascript
import OpenAi from "openai";
import { OpenAiHandler, StreamMode } from "openai-partial-stream";

// Set your OpenAI API key as an environment variable: OPENAI_API_KEY
const openai = new OpenAi({ apiKey: process.env.OPENAI_API_KEY });

const stream = await openai.chat.completions.create({
  messages: [{ role: "system", content: "Say hello to the world." }],
  model: "gpt-3.5-turbo", // OR "gpt-4"
  stream: true, // ENABLE STREAMING
  temperature: 1,
  functions: [
    {
      name: "say_hello",
      description: "say hello",
      parameters: {
        type: "object",
        properties: {
          sentence: {
            type: "string",
            description: "The sentence generated",
          },
        },
      },
    },
  ],
  function_call: { name: "say_hello" },
});

const openAiHandler = new OpenAiHandler(StreamMode.StreamObjectKeyValueTokens);
const entityStream = openAiHandler.process(stream);

for await (const item of entityStream) {
  console.log(item);
}
```
输出：


```js
{ index: 0, status: 'PARTIAL', data: {} }
{ index: 0, status: 'PARTIAL', data: { sentence: '' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello,' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world!' } }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hello, world!' } }
```

## 使用流和实体解析

根据模式验证数据，仅在数据有效时返回数据。

```javascript
import { z } from "zod";
import OpenAi from "openai";
import { OpenAiHandler, StreamMode, Entity } from "openai-partial-stream";

// Set your OpenAI API key as an environment variable: OPENAI_API_KEY
const openai = new OpenAi({ apiKey: process.env.OPENAI_API_KEY });

const stream = await openai.chat.completions.create({
  messages: [{ role: "system", content: "Say hello to the world." }],
  model: "gpt-3.5-turbo", // OR "gpt-4"
  stream: true, // ENABLE STREAMING
  temperature: 1,
  functions: [
    {
      name: "say_hello",
      description: "say hello",
      parameters: {
        type: "object",
        properties: {
          sentence: {
            type: "string",
            description: "The sentence generated",
          },
        },
      },
    },
  ],
  function_call: { name: "say_hello" },
});

const openAiHandler = new OpenAiHandler(StreamMode.StreamObjectKeyValueTokens);
const entityStream = openAiHandler.process(stream);

// Entity Parsing to validate the data
const HelloSchema = z.object({
  sentence: z.string().optional(),
});

const entityHello = new Entity("sentence", HelloSchema);
const helloEntityStream = entityHello.genParse(entityStream);

for await (const item of helloEntityStream) {
  console.log(item);
}
```
输出：


```js
{ index: 0, status: 'PARTIAL', data: {}, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: '' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi,' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world!' }, entity: 'sentence' }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hi, world!' }, entity: 'sentence'}
```

## 使用流和实体解析处理多个实体

```javascript
import { z } from "zod";
import OpenAi from "openai";
import { OpenAiHandler, StreamMode, Entity } from "openai-partial-stream";

// Intanciate OpenAI client with your API key
const openai = new OpenAi({
  apiKey: process.env.OPENAI_API_KEY,
});

const PostcodeSchema = z.object({
  name: z.string().optional(),
  postcode: z.string().optional(),
  population: z.number().optional(),
});

// Call the API with stream enabled and a function
const stream = await openai.chat.completions.create({
  messages: [
    {
      role: "system",
      content: "Give me 3 cities and their postcodes in California.",
    },
  ],
  model: "gpt-3.5-turbo", // OR "gpt-4"
  stream: true, // ENABLE STREAMING
  temperature: 1.1,
  functions: [
    {
      name: "set_postcode",
      description: "Set a postcode and a city",
      parameters: {
        type: "object",
        properties: {
          // The name of the entity
          postcodes: {
            type: "array",
            items: {
              type: "object",
              properties: {
                name: {
                  type: "string",
                  description: "Name of the city",
                },
                postcode: {
                  type: "string",
                  description: "The postcode of the city",
                },
                population: {
                  type: "number",
                  description: "The population of the city",
                },
              },
            },
          },
        },
      },
    },
  ],
  function_call: { name: "set_postcode" },
});

// Select the mode of the stream parser
// - StreamObjectKeyValueTokens: (REALTIME)     Stream of JSON objects, key value pairs and tokens
// - StreamObjectKeyValue:       (PROGRESSIVE)  Stream of JSON objects and key value pairs
// - StreamObject:               (ONE-BY-ONE)   Stream of JSON objects
// - NoStream:                   (ALL-TOGETHER) All the data is returned at the end of the process
const mode = StreamMode.StreamObject;

// Create an instance of the handler
const openAiHandler = new OpenAiHandler(mode);
// Process the stream
const entityStream = openAiHandler.process(stream);
// Create an entity with the schema to validate the data
const entityPostcode = new Entity("postcodes", PostcodeSchema);
// Parse the stream to an entity, using the schema to validate the data
const postcodeEntityStream = entityPostcode.genParseArray(entityStream);

// Iterate over the stream of entities
for await (const item of postcodeEntityStream) {
  if (item) {
    // Display the entity
    console.log(item);
  }
}
```
输出：


```js
{ index: 0, status: 'COMPLETED', data: { name: 'Los Angeles', postcode: '90001', population: 3971883 }, entity: 'postcodes' }
{ index: 1, status: 'COMPLETED', data: { name: 'San Francisco', postcode: '94102', population: 883305 }, entity: 'postcodes' }
{ index: 2, status: 'COMPLETED', data: { name: 'San Diego', postcode: '92101', population: 1425976 }, entity: 'postcodes'}
```

# 模式

从以下列表中选择最适合您需求的模式：

1. **无流式 (NoStream)**
2. **流式对象 (StreamObject)**
3. **流式对象键值 (StreamObjectKeyValue)**
4. **流式对象键值令牌 (StreamObjectKeyValueTokens)**

---

### 无流式 (NoStream)

结果仅在整个查询完成后返回。

| **无流式详情**                                                     |
| ----------------------------------------------------------------- |
| ✅ 单次查询检索所有数据                                           |
| ✅ 减少网络流量                                                   |
| ⚠️ 用户体验可能因等待时间延长而受到影响                           |

---

### 流式对象 (StreamObject)

为列表中的每个项目生成一个事件。项目在准备好后显示。

| **流式对象详情**                                                      |
| ------------------------------------------------------------------- |
| ✅ 每条消息对应一个完整的项目                                       |
| ✅ 消息数量较少                                                     |
| ✅ 所有必要字段一次性接收                                           |
| ⚠️ 有一定延迟：用户需等待项目完全准备好后才能更新界面               |

---

### 流式对象键值 (StreamObjectKeyValue)

对象以片段形式接收：键及其对应的值一同发送。
| **StreamObjectKeyValue 详情**                          |
| --------------------------------------------------------- |
| ✅ 用户可以与部分 UI 交互                                  |
| ✅ 支持更常规的 UI 更新                                   |
| ⚠️ 网络流量较高                                           |
| ⚠️ 由于对象不完整，强制执行键存在挑战                   |

---

### StreamObjectKeyValueTokens

键是完整接收的，而值则是分段传递直到完整。此方法提供逐令牌的 UI 更新。

| **StreamObjectKeyValueToken 详情**                               |
| ------------------------------------------------------------------- |
| ✅ 提供动态的用户体验                                               |
| ✅ 支持内容逐步消费                                               |
| ✅ 减少用户等待时间                                               |
| ⚠️ 由于值逐步到达，可能导致 UI 不一致                             |
| ⚠️ 网络流量增加                                                   |

## 演示

按键值对逐步流式传输 JSON 对象：

https://github.com/st3w4r/openai-partial-stream/assets/4228332/55643614-b92b-4b1f-9cf9-e60d6d783a0c

实时流式传输 JSON 对象：

https://github.com/st3w4r/openai-partial-stream/assets/4228332/73289d38-8526-46cf-a68c-ac80019092ab

## 参考

[npm 包](https://www.npmjs.com/package/openai-partial-stream)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---