```markdown
# Ax, DSPy สำหรับ Typescript

การทำงานกับ LLMs มีความซับซ้อนและมักจะไม่เป็นไปตามที่ต้องการ DSPy ช่วยให้การสร้างสิ่งที่ยอดเยี่ยมด้วย LLMs เป็นเรื่องง่าย เพียงแค่กำหนดอินพุตและเอาต์พุต (signature) แล้ว prompt ที่มีประสิทธิภาพจะถูกสร้างขึ้นโดยอัตโนมัติและนำไปใช้ เชื่อมต่อ signatures หลายๆ อันเข้าด้วยกันเพื่อสร้างระบบและ workflow ที่ซับซ้อนโดยใช้ LLMs

และเพื่อให้คุณนำไปใช้งานจริงได้ เรายังมีสิ่งที่จำเป็นอื่นๆ เช่น การสังเกตการณ์ (observability), สตรีมมิ่ง, รองรับมัลติโมดัล (ภาพ, เสียง ฯลฯ), การแก้ไขข้อผิดพลาด, การเรียกใช้งานฟังก์ชันหลายขั้นตอน, MCP, RAG และอื่นๆ

[![NPM Package](https://img.shields.io/npm/v/@ax-llm/ax?style=for-the-badge&color=green)](https://www.npmjs.com/package/@ax-llm/ax)
[![Discord Chat](https://dcbadge.vercel.app/api/server/DSHg3dU7dW?style=for-the-badge)](https://discord.gg/DSHg3dU7dW)
[![Twitter](https://img.shields.io/twitter/follow/dosco?style=for-the-badge&color=red)](https://twitter.com/dosco)

<!-- header -->

## ทำไมต้องใช้ Ax?

- อินเทอร์เฟซมาตรฐานสำหรับ LLM ชั้นนำทั้งหมด
- Prompt สร้างจาก signature ที่เรียบง่าย
- สตรีมมิ่งแบบ native ครบวงจร
- รองรับงบประมาณในการคิดและโทเค็นความคิด
- สร้าง Agents ที่เรียกใช้ agent อื่นได้
- มี MCP, รองรับ Model Context Protocol ในตัว
- แปลงเอกสารรูปแบบใดก็ได้เป็นข้อความ
- RAG, การ chunk อย่างชาญฉลาด, embedding, การค้นหา
- ใช้งานร่วมกับ Vercel AI SDK
- ตรวจสอบผลลัพธ์ระหว่างสตรีมมิ่ง
- รองรับ Multi-modal DSPy
- ปรับแต่ง prompt อัตโนมัติด้วย optimizer
- รองรับ OpenTelemetry / observability
- โค้ด Typescript พร้อมใช้งาน production
- น้ำหนักเบา ไม่มี dependencies

## พร้อมสำหรับ Production

- ไม่มี breaking changes (minor versions)
- มีการทดสอบครอบคลุมมาก
- รองรับ Open Telemetry `gen_ai` ในตัว
- ได้รับความนิยมใน startup หลายแห่ง

## Prompt signature คืออะไร?

<img width="860" alt="shapes at 24-03-31 00 05 55" src="https://github.com/dosco/llm-client/assets/832235/0f0306ea-1812-4a0a-9ed5-76cd908cd26b">

Prompt ที่มี type-safe ถูกสร้างจาก signature อย่างง่ายโดยอัตโนมัติ Prompt signature ประกอบด้วย
`"task description" inputField:type "field description" -> "outputField:type` แนวคิดของ prompt signature นี้อ้างอิงจากงานวิจัยในหัวข้อ "Demonstrate-Search-Predict"

คุณสามารถมี input และ output หลายฟิลด์ โดยแต่ละฟิลด์เป็นชนิด `string`, `number`, `boolean`, `date`, `datetime`, `class "class1, class2"`, `JSON` หรือ array ของชนิดเหล่านี้ เช่น `string[]` ถ้าไม่กำหนดชนิดจะเป็น `string` โดยปริยาย Suffix `?` ทำให้ฟิลด์เป็นทางเลือก (ปกติจำเป็น) และ `!` ทำให้ฟิลด์เป็น internal เหมาะสำหรับ reasoning

## Output Field Types

| Type                      | คำอธิบาย                            | การใช้งาน                 | ตัวอย่างผลลัพธ์                                      |
| ------------------------- | ------------------------------------ | ------------------------- | ----------------------------------------------------- |
| `string`                  | ลำดับอักขระ                         | `fullName:string`         | `"example"`                                           |
| `number`                  | ค่าตัวเลข                            | `price:number`            | `42`                                                  |
| `boolean`                 | ค่าจริงหรือเท็จ                      | `isEvent:boolean`         | `true`, `false`                                       |
| `date`                    | ค่าวันที่                            | `startDate:date`          | `"2023-10-01"`                                        |
| `datetime`                | วันและเวลารวมกัน                     | `createdAt:datetime`      | `"2023-10-01T12:00:00Z"`                              |
| `class "class1,class2"`   | การจัดประเภท                         | `category:class`          | `["class1", "class2", "class3"]`                      |
| `string[]`                | อาร์เรย์ของ string                   | `tags:string[]`           | `["example1", "example2"]`                            |
| `number[]`                | อาร์เรย์ของ number                   | `scores:number[]`         | `[1, 2, 3]`                                           |
| `boolean[]`               | อาร์เรย์ของ boolean                  | `permissions:boolean[]`   | `[true, false, true]`                                 |
| `date[]`                  | อาร์เรย์ของวันที่                    | `holidayDates:date[]`     | `["2023-10-01", "2023-10-02"]`                        |
| `datetime[]`              | อาร์เรย์ของวันและเวลา                | `logTimestamps:datetime[]`| `["2023-10-01T12:00:00Z", "2023-10-02T12:00:00Z"]`    |
| `class[] "class1,class2"` | หลายคลาส                             | `categories:class[]`      | `["class1", "class2", "class3"]`                      |
| `code "language"`         | โค้ดบล็อกในภาษาที่ระบุ              | `code:code "python"`      | `print('Hello, world!')`                              |

## LLMs ที่รองรับ

`Google Gemini`, `OpenAI`, `Azure OpenAI`, `Anthropic`, `X Grok`, `TogetherAI`, `Cohere`, `Mistral`, `Groq`, `DeepSeek`, `Ollama`, `Reka`, `Hugging Face`

## ติดตั้ง

```bash
npm install @ax-llm/ax
# หรือ
yarn add @ax-llm/ax
```

## ตัวอย่าง: ใช้ chain-of-thought เพื่อสรุปข้อความ

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

## ตัวอย่าง: สร้าง agent

ใช้ agent prompt (framework) เพื่อสร้าง agent ที่สามารถประสานงานกับ agent อื่นในการทำงาน Agents สร้างได้ง่ายจาก prompt signature ลองดูตัวอย่าง agent

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

## รองรับ Thinking Models

Ax รองรับโมเดลที่มีความสามารถในการคิดโดยตรง สามารถควบคุมงบโทเค็นความคิดและเข้าถึง reasoning ของโมเดล ช่วยเข้าใจ reasoning และปรับใช้โทเค็นอย่างเหมาะสม

```typescript
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY as string,
  config: {
    model: AxAIGoogleGeminiModel.Gemini25Flash,
    thinking: { includeThoughts: true },
  },
})

// หรือควบคุม budget ต่อ request
const gen = new AxChainOfThought(`question -> answer`)
const res = await gen.forward(
  ai,
  { question: 'What is quantum entanglement?' },
  { thinkingTokenBudget: 'medium' } // 'minimal', 'low', 'medium', หรือ 'high'
)

// เข้าถึง thoughts ใน response
console.log(res.thoughts) // แสดง reasoning ของโมเดล
```

## Vector DBs ที่รองรับ

Vector database สำคัญในการสร้าง workflow ของ LLM เรามี abstraction สำหรับฐานข้อมูลเวกเตอร์ยอดนิยม และฐานข้อมูลเวกเตอร์ในหน่วยความจำ

| ผู้ให้บริการ | ทดสอบแล้ว  |
| ------------ | ---------- |
| In Memory    | 🟢 100%    |
| Weaviate     | 🟢 100%    |
| Cloudflare   | 🟡 50%     |
| Pinecone     | 🟡 50%     |

```typescript
// สร้าง embedding จากข้อความโดยใช้ LLM
const ret = await this.ai.embed({ texts: 'hello world' })

// สร้าง vector db ในหน่วยความจำ
const db = new axDB('memory')

// เพิ่มข้อมูลลง vector db
await this.db.upsert({
  id: 'abc',
  table: 'products',
  values: ret.embeddings[0],
})

// ค้นหาข้อมูลที่คล้ายกันด้วย embeddings
const matches = await this.db.query({
  table: 'products',
  values: embeddings[0],
})
```

หรือใช้ `AxDBManager` ที่จัดการ chunk, embed, query ให้อัตโนมัติ

```typescript
const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query(
  'John von Neumann on human intelligence and singularity.'
)
console.log(matches)
```

## RAG Documents

ใช้งานเอกสารอย่าง PDF, DOCX, PPT, XLS ฯลฯ กับ LLM เป็นเรื่องยุ่งยาก เราทำให้ง่ายขึ้นด้วย Apache Tika ซึ่งเป็นเอนจินโอเพ่นซอร์สสำหรับประมวลผลเอกสาร

รัน Apache Tika

```shell
docker run -p 9998:9998 apache/tika
```

แปลงเอกสารเป็นข้อความและสร้าง embedding เพื่อค้นหาด้วย `AxDBManager` ที่รองรับ reranker และ query rewriter มี implementation เริ่มต้น 2 ตัว ได้แก่ `AxDefaultResultReranker` และ `AxDefaultQueryRewriter`

```typescript
const tika = new AxApacheTika()
const text = await tika.convert('/path/to/document.pdf')

const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query('Find some text')
console.log(matches)
```

## Multi-modal DSPy

เมื่อใช้โมเดลอย่าง `GPT-4o` และ `Gemini` ที่รองรับ multi-modal prompt สามารถใช้ image field ร่วมใน pipeline ได้

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

สำหรับโมเดลอย่าง `gpt-4o-audio-preview` ที่รองรับ audio สามารถใช้ audio field ได้

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

## DSPy Chat API

ได้รับแรงบันดาลใจจาก demonstration weaving ของ DSPy, Ax มี `AxMessage` สำหรับการจัดการประวัติการสนทนาอย่างไร้รอยต่อ สามารถสร้าง chatbot ที่รักษาบริบทการสนทนาได้เต็มรูปแบบด้วย prompt signature ดูตัวอย่างเพิ่มเติม

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

ประวัติการสนทนาจะถูก weave เข้าไปใน prompt อัตโนมัติ ทำให้โมเดลสามารถรักษาบริบทและตอบสนองได้อย่างต่อเนื่อง รองรับทุกฟีเจอร์ของ Ax เช่น สตรีมมิ่ง, การเรียกฟังก์ชัน, chain-of-thought reasoning

## Streaming

### Assertions

เรารองรับการ parse output fields และเรียกฟังก์ชันระหว่าง streaming ช่วยให้ fail-fast และแก้ไขข้อผิดพลาดได้ทันทีโดยไม่ต้องรอผลลัพธ์ทั้งหมด ประหยัดโทเค็นและลด latency Assertion ช่วยให้มั่นใจว่า output ตรงตามข้อกำหนด ใช้ได้กับ streaming

```typescript
// setup the prompt program
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

// add a assertion ให้แน่ใจว่าไม่มีเลข 5 ใน output field
gen.addAssert(({ next10Numbers }: Readonly<{ next10Numbers: number[] }>) => {
  return next10Numbers ? !next10Numbers.includes(5) : undefined
}, 'Numbers 5 is not allowed')

// run the program พร้อม streaming
const res = await gen.forward({ startNumber: 1 }, { stream: true })

// หรือ run แบบ end-to-end streaming
const generator = await gen.streamingForward(
  { startNumber: 1 },
  {
    stream: true,
  }
)
for await (const res of generator) {
}
```

ตัวอย่างข้างต้นช่วย validate output field แบบเต็มขณะ streaming สามารถใช้ทั้งแบบ streaming และไม่ streaming โดยจะ trigger เมื่อได้รับค่าครบ หากต้องการ validate ระหว่าง streaming จริงๆ ดูตัวอย่างด้านล่าง จะช่วยเพิ่ม performance และประหยัดโทเค็น

```typescript
// assertion ตรวจแต่ละบรรทัดต้องขึ้นต้นด้วยตัวเลขและจุด
gen.addStreamingAssert(
  'answerInPoints',
  (value: string) => {
    const re = /^\d+\./

    // แยกบรรทัด, trim, กรองบรรทัดว่าง, ตรวจ regex
    return value
      .split('\n')
      .map((x) => x.trim())
      .filter((x) => x.length > 0)
      .every((x) => re.test(x))
  },
  'Lines must start with a number and a dot. Eg: 1. This is a line.'
)

// run แบบ streaming
const res = await gen.forward(
  {
    question: 'Provide a list of optimizations to speedup LLM inference.',
  },
  { stream: true, debug: true }
)
```

### Field Processors

Field processor ใช้ประมวลผล field ใน prompt ก่อนส่งเข้า LLM

```typescript
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

const streamValue = false

const processorFunction = (value) => {
  return value.map((x) => x + 1)
}

// เพิ่ม field processor เข้าโปรแกรม
const processor = new AxFieldProcessor(
  gen,
  'next10Numbers',
  processorFunction,
  streamValue
)

const res = await gen.forward({ startNumber: 1 })
```

## Model Context Protocol (MCP)

Ax รองรับ Model Context Protocol (MCP) อย่างไร้รอยต่อ ให้ agent ของคุณเข้าถึง tools ภายนอกผ่านอินเทอร์เฟซมาตรฐาน

### การใช้ AxMCPClient

`AxMCPClient` ช่วยเชื่อมต่อกับ MCP server ใดก็ได้และใช้งานผ่าน agent ของคุณ:

```typescript
import { AxMCPClient, AxMCPStdioTransport } from '@ax-llm/ax'

// สร้าง MCP client พร้อม transport
const transport = new AxMCPStdioTransport({
  command: 'npx',
  args: ['-y', '@modelcontextprotocol/server-memory'],
})

// สร้าง client พร้อมโหมด debug
const client = new AxMCPClient(transport, { debug: true })

// เริ่มเชื่อมต่อ
await client.init()

// ใช้ฟังก์ชัน client ใน agent
const memoryAgent = new AxAgent({
  name: 'MemoryAssistant',
  description: 'An assistant with persistent memory',
  signature: 'input, userId -> response',
  functions: [client], // ใส่ client เป็น function provider
})

// หรือใช้ client กับ AxGen
const memoryGen = new AxGen('input, userId -> response', {
  functions: [client],
})
```

### การใช้ AxMCPClient กับ Remote Server

เรียก MCP server แบบ remote ได้ง่าย ตัวอย่าง การใช้ DeepWiki MCP server ถามข้อมูล repo สาธารณะบน GitHub DeepWiki MCP server อยู่ที่ `https://mcp.deepwiki.com/mcp`

```typescript
import {
  AxAgent,
  AxAI,
  AxAIOpenAIModel,
  AxMCPClient,
  AxMCPStreambleHTTPTransport,
} from '@ax-llm/ax'

// 1. เตรียม MCP transport ไป DeepWiki server
const transport = new AxMCPStreambleHTTPTransport(
  'https://mcp.deepwiki.com/mcp'
)

// 2. สร้าง MCP client
const mcpClient = new AxMCPClient(transport, { debug: false })
await mcpClient.init() // เริ่มเชื่อมต่อ

// 3. เตรียม AI model (เช่น OpenAI)
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY as string,
})

// 4. สร้าง AxAgent ที่ใช้ MCP client
const deepwikiAgent = new AxAgent<
  {
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
  functions: [mcpClient], // ใส่ MCP client ใน agent
})

// 5. ถามคำถามและเรียก agent
const result = await deepwikiAgent.forward(ai, {
  questionAboutRepo: 'What is the main purpose of this library?',
  githubRepositoryUrl: 'https://github.com/dosco/ax',
})
console.log('DeepWiki Answer:', result.answer)
```

ตัวอย่างนี้แสดงการเชื่อมต่อ MCP server สาธารณะและใช้งานกับ agent ของ Ax signature (`questionAboutRepo, githubRepositoryUrl -> answer`) เป็นตัวอย่างเท่านั้น โดยปกติจะดูฟังก์ชันและ signature จาก MCP server โดยตรง (เช่น จาก `mcp.getFunctions` หรือเอกสาร)

ดูตัวอย่างที่ซับซ้อนกว่านี้เช่น authentication และ custom header ใน remote MCP server ได้ที่ `src/examples/mcp-client-pipedream.ts`

## AI Routing และ Load Balancing

Ax มี 2 วิธีหลักในการทำงานกับ AI หลายบริการ: load balancer เพื่อความเสถียร และ router สำหรับ routing ตามโมเดล

### Load Balancer

load balancer แจกจ่าย request ไปยัง AI หลายๆ บริการตามประสิทธิภาพและสถานะ หากบริการใดล้มเหลว จะสลับอัตโนมัติ

```typescript
import { AxAI, AxBalancer } from '@ax-llm/ax'

// ตั้งค่าหลาย AI service
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

// สร้าง load balancer
const balancer = new AxBalancer([openai, ollama, gemini])

// ใช้งานเหมือน AI ปกติ - เลือกบริการที่ดีที่สุดให้อัตโนมัติ
const response = await balancer.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
})

// หรือใช้กับ AxGen
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(balancer, { question: 'Hello!' })
```

### Multi-Service Router

router ช่วยให้ใช้ AI หลายบริการผ่านอินเทอร์เฟซเดียว โดย route ตามโมเดลที่ระบุ

```typescript
import { AxAI, AxAIOpenAIModel, AxMultiServiceRouter } from '@ax-llm/ax'

// ตั้งค่า OpenAI กับรายชื่อโมเดล
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

// ตั้งค่า Gemini
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

// สร้าง router
const router = new AxMultiServiceRouter([openai, gemini, secretService])

// route ไปที่ expert model ของ OpenAI
const openaiResponse = await router.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
  model: 'expert',
})

// หรือใช้กับ AxGen
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(router, { question: 'Hello!' })
```

load balancer เหมาะกับ high availability ส่วน router เหมาะกับงานที่ต้องเลือกโมเดลเฉพาะ ทั้งสองใช้ร่วมกับฟีเจอร์ Ax เช่น streaming, function calling, chain-of-thought ได้

สามารถใช้ balancer กับ router ร่วมกันได้

## รองรับ OpenTelemetry

การ trace และสังเกตการณ์ workflow LLM สำคัญสำหรับ production OpenTelemetry เป็นมาตรฐานอุตสาหกรรม และเรารองรับ namespace `gen_ai` ดูเพิ่มที่ `src/examples/telemetry.ts`

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

## การปรับแต่ง prompt (พื้นฐาน)

คุณสามารถปรับแต่ง prompt โดยใช้โมเดลขนาดใหญ่เพื่อเพิ่มประสิทธิภาพและผลลัพธ์ที่ดีขึ้น ด้วย optimizer เช่น `AxBootstrapFewShot` และตัวอย่างจากชุดข้อมูล `HotPotQA` optimizer จะสร้าง demo ซึ่งเมื่อใช้กับ prompt จะช่วยเพิ่มประสิทธิภาพ

```typescript
// ดาวน์โหลด HotPotQA dataset จาก huggingface
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

// ตั้งค่าโปรแกรมสำหรับ tuning
const program = new AxChainOfThought<{ question: string }, { answer: string }>(
  ai,
  `question -> answer "in short 2 or 3 words"`
)

// ตั้งค่า Bootstrap Few Shot optimizer
const optimize = new AxBootstrapFewShot<
  { question: string },
  { answer: string }
>({
  program,
  examples,
})

// ตั้งค่า evaluation metric เช่น em, f1 score
const metricFn: AxMetricFn = ({ prediction, example }) =>
  emScore(prediction.answer as string, example.answer as string)

// run optimizer และอย่าลืมบันทึกผลลัพธ์
const result = await optimize.compile(metricFn);

// บันทึก demo ที่สร้างไว้
fs.writeFileSync('bootstrap-demos.json', JSON.stringify(result.demos, null, 2));
console.log('Demos saved to bootstrap-demos.json');
```

<img width="853" alt="tune-prompt" src="https://github.com/dosco/llm-client/assets/832235/f924baa7-8922-424c-9c2c-f8b2018d8d74">
```

## การปรับแต่ง prompt (ขั้นสูง, Mipro v2)

MiPRO v2 เป็น framework ขั้นสูงสำหรับ optimization prompt ที่ใช้ Bayesian optimization เพื่อค้นหา instruction, demonstration, และ example ที่ดีที่สุดสำหรับโปรแกรม LLM ของคุณโดยอัตโนมัติ

### จุดเด่น

- **Instruction optimization**: สร้างและทดสอบ instruction อัตโนมัติ
- **Few-shot example selection**: เลือก demonstration ที่เหมาะสมจาก dataset
- **Smart Bayesian optimization**: ใช้ UCB strategy สำรวจ configuration อย่างมีประสิทธิภาพ
- **Early stopping**: หยุดเมื่อไม่มี improvement เพื่อประหยัดคอมพิวต์
- **Program and data-aware**: คำนึงถึงโครงสร้างโปรแกรมและ dataset

### วิธีการทำงาน

1. สร้าง instruction candidate ต่างๆ
2. Bootstrap ตัวอย่าง few-shot จากข้อมูล
3. เลือก example จาก dataset
4. ใช้ Bayesian optimization หาค่าเหมาะสม
5. ใช้ configuration ที่ดีที่สุดกับโปรแกรม

### การใช้งานเบื้องต้น

```typescript
import { AxAI, AxChainOfThought, AxMiPRO } from '@ax-llm/ax'

// 1. ตั้งค่า AI service
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY,
})

// 2. สร้างโปรแกรม
const program = new AxChainOfThought(`input -> output`)

// 3. ตั้งค่า optimizer
const optimizer = new AxMiPRO({
  ai,
  program,
  examples: trainingData,
  options: {
    numTrials: 20,
    auto: 'medium',
  },
})

// 4. กำหนด evaluation metric
const metricFn = ({ prediction, example }) => {
  return prediction.output === example.output
}

// 5. เริ่ม optimization
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData,
})

// 6. ใช้โปรแกรมที่ปรับแต่งแล้ว
const result = await optimizedProgram.forward(ai, { input: 'test input' })
```

### ตัวเลือกการตั้งค่า

| Option                    | คำอธิบาย                                      | ค่าเริ่มต้น |
| ------------------------- | ---------------------------------------------- | ----------- |
| `numCandidates`           | จำนวน instruction candidate ที่จะสร้าง        | 5           |
| `numTrials`               | จำนวนรอบ optimization                        | 30          |
| `maxBootstrappedDemos`    | จำนวน bootstrapped demo สูงสุด                | 3           |
| `maxLabeledDemos`         | จำนวน labeled example สูงสุด                  | 4           |
| `minibatch`               | ใช้ minibatch เพื่อประเมินเร็วขึ้น            | true        |
| `minibatchSize`           | ขนาด minibatch สำหรับประเมิน                  | 25          |
| `earlyStoppingTrials`     | หยุดเมื่อไม่มี improvement หลัง N trial      | 5           |
| `minImprovementThreshold` | threshold การพัฒนาคะแนนขั้นต่ำ                | 0.01        |
| `programAwareProposer`    | ใช้โครงสร้างโปรแกรมเพื่อ proposal ที่ดีกว่า | true        |
| `dataAwareProposer`       | คำนึงถึง dataset                              | true        |
| `verbose`                 | แสดงความคืบหน้าอย่างละเอียด                  | false       |
| abort-patterns.ts | ตัวอย่างการ abort request |

### ระดับการ optimization

ตั้งค่าความเข้มข้นการ optimize ด้วย `auto` parameter:

```typescript
// light (เร็ว แต่ไม่ thorough)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'light' })

// medium (สมดุล)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'medium' })

// heavy ( thorough แต่ช้า)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'heavy' })
```

### ตัวอย่างขั้นสูง: วิเคราะห์ความรู้สึก

```typescript
// สร้างโปรแกรม sentiment analysis
const classifyProgram = new AxChainOfThought<
  { productReview: string },
  { label: string }
>(`productReview -> label:string "positive" or "negative"`)

// ตั้งค่า optimizer ขั้นสูง
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

// run optimization และบันทึกผลลัพธ์
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData,
})

// บันทึก config สำหรับใช้ต่อ
const programConfig = JSON.stringify(optimizedProgram, null, 2);
await fs.promises.writeFile("./optimized-config.json", programConfig);
console.log('> Done. Optimized program config saved to optimized-config.json');
```

## การใช้ Tuned Prompts

ทั้ง Bootstrap Few Shot optimizer และ MiPRO v2 optimizer จะสร้าง **demos** (demonstration) ที่ช่วยปรับปรุงประสิทธิภาพโปรแกรมของคุณอย่างมาก

### Demos คืออะไร?

Demos คือ input-output example ที่ถูกเพิ่มเข้า prompt อัตโนมัติ เพื่อแนะนำ LLM ให้เห็นตัวอย่างการแก้ปัญหาแบบ few-shot

### โหลดและใช้ demo

ไม่ว่าจะใช้ Bootstrap หรือ MiPRO การใช้ demo ที่สร้างเหมือนกัน:

```typescript
import fs from 'fs'
import { AxAI, AxGen, AxChainOfThought } from '@ax-llm/ax'

// 1. ตั้งค่า AI service
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
})

// 2. สร้างโปรแกรม (signature เดียวกับตอน tuning)
const program = new AxChainOfThought(`question -> answer "in short 2 or 3 words"`)

// 3. โหลด demo ที่บันทึกไว้
const demos = JSON.parse(fs.readFileSync('bootstrap-demos.json', 'utf8'))

// 4. ใส่ demo เข้าโปรแกรม
program.setDemos(demos)

// 5. ใช้โปรแกรมที่ปรับปรุงแล้ว
const result = await program.forward(ai, {
  question: 'What castle did David Gregory inherit?'
})

console.log(result) // แม่นยำขึ้นจากตัวอย่างที่เรียนรู้
```

### ตัวอย่างง่าย: Text Classification

ตัวอย่างการใช้ demo เพื่อเพิ่มประสิทธิภาพงาน classification

```typescript
// สร้างโปรแกรม classifier
const classifier = new AxGen(`text -> category:class "positive, negative, neutral"`)

// โหลด demo ที่ได้จาก tuning
const savedDemos = JSON.parse(fs.readFileSync('classification-demos.json', 'utf8'))
classifier.setDemos(savedDemos)

// classifier จะเรียนรู้จากตัวอย่างและแม่นยำขึ้น
const result = await classifier.forward(ai, {
  text: "This product exceeded my expectations!"
})

console.log(result.category) // classification แม่นยำขึ้น
```

### ข้อดีของการใช้ demo

- **แม่นยำขึ้น**: โปรแกรมทำงานดีขึ้นมากด้วยตัวอย่างที่เกี่ยวข้อง
- **ผลลัพธ์สม่ำเสมอ**: demo ช่วยให้รูปแบบ output คงที่
- **ลด Hallucination**: ตัวอย่างช่วยชี้นำโมเดลให้ตอบตามที่ควร
- **คุ้มค่า**: ได้ผลลัพธ์ดีขึ้นโดยไม่ต้องใช้โมเดลใหญ่หรือแพงกว่า

### Best Practices

1. **บันทึก demo**: บันทึก demo ลงไฟล์ไว้ใช้ซ้ำ
2. **ใช้ signature เดิม**: โหลด demo ด้วย signature เดียวกับตอน tuning
3. **ควบคุมเวอร์ชัน**: เก็บไฟล์ demo ไว้ใน version control
4. **อัปเดตสม่ำเสมอ**: tune ใหม่เป็นระยะด้วยข้อมูลใหม่

ทั้ง Bootstrap และ MiPRO v2 สร้าง demo ในรูปแบบเดียวกัน ใช้ pattern นี้ได้กับทั้งสองแบบ

## ฟังก์ชันในตัว

| Function           | Name               | คำอธิบาย                                            |
| ------------------ | ------------------ | --------------------------------------------------- |
| JS Interpreter     | AxJSInterpreter    | รัน JS ใน sandbox                                    |
| Docker Sandbox     | AxDockerSession    | รันคำสั่งในสภาพแวดล้อม docker                      |
| Embeddings Adapter | AxEmbeddingAdapter | รับ embedding และส่งต่อไปยังฟังก์ชันของคุณ          |

## ดูตัวอย่างทั้งหมด

ใช้ `tsx` รันตัวอย่างต่างๆ ช่วยให้รัน typescript ได้บน node และรองรับ `.env` สำหรับ API Key

```shell
OPENAI_APIKEY=api-key npm run tsx ./src/examples/marketing.ts
```

| Example                 | คำอธิบาย                                             |
| ----------------------- | ---------------------------------------------------- |
| customer-support.ts     | ดึงข้อมูลสำคัญจากการสื่อสารกับลูกค้า               |
| function.ts             | ตัวอย่าง function calling อย่างง่าย                  |
| food-search.ts          | ตัวอย่าง multi-step, multi-function calling         |
| marketing.ts            | สร้างข้อความ sms การตลาดสั้นๆ ที่มีประสิทธิภาพ      |
| vectordb.ts             | chunk, embed และค้นหาข้อความ                        |
| fibonacci.ts            | ใช้ interpreter JS คำนวณ fibonacci                  |
| summarize.ts            | สรุปข้อความขนาดใหญ่                                 |
| chain-of-thought.ts     | ใช้ chain-of-thought ในการตอบคำถาม                  |
| rag.ts                  | ใช้ multi-hop retrieval เพื่อตอบคำถาม               |
| rag-docs.ts             | แปลง PDF เป็นข้อความและฝังสำหรับ rag search        |
| react.ts                | ใช้ function calling และ reasoning ตอบคำถาม         |
| agent.ts                | agent framework, agent ใช้ agent อื่น/เครื่องมือได้ |
| streaming1.ts           | ตรวจสอบ output field ขณะ streaming                  |
| streaming2.ts           | ตรวจสอบ output field ทีละ field ขณะ streaming       |
| streaming3.ts           | ตัวอย่าง end-to-end streaming `streamingForward()`  |
| smart-hone.ts           | agent มองหาสุนัขในบ้านอัจฉริยะ                     |
| multi-modal.ts          | ใช้รูปภาพพร้อม input อื่น                           |
| balancer.ts             | balance หลาย llm ตาม cost ฯลฯ                       |
| docker.ts               | ใช้ docker sandbox หาไฟล์ตามคำอธิบาย                |
| prime.ts                | ใช้ field processor ประมวลผล field ใน prompt         |
| simple-classify.ts      | classifier อย่างง่าย                                 |
| mcp-client-memory.ts    | ใช้ MCP server สำหรับ memory กับ Ax                 |
| mcp-client-blender.ts   | ใช้ MCP server สำหรับ Blender กับ Ax                |
| mcp-client-pipedream.ts | ตัวอย่างเชื่อมต่อ MCP remote                        |
| tune-bootstrap.ts       | ใช้ bootstrap optimizer เพื่อเพิ่มประสิทธิภาพ prompt|
| tune-mipro.ts           | ใช้ mipro v2 optimizer เพื่อเพิ่มประสิทธิภาพ prompt|
| tune-usage.ts           | ใช้ tuned prompts ที่ปรับปรุงแล้ว                    |
| telemetry.ts            | trace และส่ง trace ไปยัง Jaeger service              |
| openai-responses.ts     | ตัวอย่างใช้ OpenAI Responses API ใหม่                |
| use-examples.ts | ตัวอย่างใช้ 'examples' เพื่อกำกับ llm |

## เป้าหมายของเรา

LLM (Large language models) ทรงพลังมากขึ้นเรื่อยๆ และสามารถเป็น backend ให้ผลิตภัณฑ์ของคุณได้ทั้งระบบ แต่ยังมีความซับซ้อนทั้งเรื่อง prompt, model, streaming, function call, error correction ฯลฯ เราต้องการรวมความซับซ้อนเหล่านี้ไว้ในไลบรารีที่บำรุงรักษาและใช้งานง่าย รองรับ LLM ที่ล้ำหน้าทุกตัว และอัปเดตความสามารถใหม่ๆ ตามงานวิจัยล่าสุด เช่น DSPy

## ใช้ไลบรารีนี้อย่างไร

### 1. เลือก AI ที่ต้องการใช้

```ts
// เลือก LLM
const ai = new AxOpenAI({ apiKey: process.env.OPENAI_APIKEY } as AxOpenAIArgs)
```

### 2. สร้าง prompt signature ตาม usecase

```ts
// signature กำหนด input/output ของ prompt program
const cot = new ChainOfThought(ai, `question:string -> answer:string`, { mem })
```

### 3. รัน prompt program ที่สร้างขึ้น

```ts
// ส่ง input ที่กำหนดใน signature
const res = await cot.forward({ question: 'Are we in a simulation?' })
```

### 4. หรือใช้ LLM โดยตรง

```ts
const res = await ai.chat([
  { role: "system", content: "Help the customer with his questions" }
  { role: "user", content: "I'm looking for a Macbook Pro M2 With 96GB RAM?" }
]);
```

## ใช้ function calling อย่างไร

### 1. กำหนดฟังก์ชัน

```ts
// กำหนดฟังก์ชันและ handler
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

### 2. ส่งฟังก์ชันเข้า prompt

```ts
const cot = new AxGen(ai, `question:string -> answer:string`, { functions })
```

## เปิด debug log

```ts
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
} as AxOpenAIArgs)
ai.setOptions({ debug: true })
```

## ติดต่อเรา

ยินดีช่วยเหลือ ติดต่อสอบถามหรือเข้าร่วม Discord [twitter/dosco](https://twitter.com/dosco)

## FAQ

### 1. LLM เลือกฟังก์ชันไม่ถูกต้อง

ตั้งชื่อและอธิบายฟังก์ชันให้ชัดเจน รวมถึงอธิบาย parameter อย่างกระชับและแม่นยำ

### 2. เปลี่ยนการตั้งค่า LLM ได้อย่างไร

ส่ง object configuration เป็นพารามิเตอร์ที่สองขณะสร้าง LLM object

```ts
const apiKey = process.env.OPENAI_APIKEY
const conf = AxOpenAIBestConfig()
const ai = new AxOpenAI({ apiKey, conf } as AxOpenAIArgs)
```

## 3. Prompt ยาวเกินไป / จะเปลี่ยน max tokens ได้ไหม

```ts
const conf = axOpenAIDefaultConfig() // หรือ OpenAIBestOptions()
conf.maxTokens = 2000
```

## 4. เปลี่ยนโมเดลอย่างไร (เช่น GPT4)

```ts
const conf = axOpenAIDefaultConfig() // หรือ OpenAIBestOptions()
conf.model = OpenAIModel.GPT4Turbo
```

## Monorepo tips & tricks

ควรติดตั้ง `npm install` เฉพาะที่ root directory เท่านั้นเพื่อป้องกันการสร้าง `package-lock.json` ซ้อนซ้อนและ node_modules ซ้ำซ้อน

ติดตั้ง dependencies ใหม่ใน package ให้ใช้ `npm install lodash --workspace=ax` (หรือแก้ไข `package.json` แล้วรัน `npm install` ที่ root)
```
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---