# 부분 JSON 스트림 파싱 - 느린 AI 앱을 실시간 인터랙티브 앱으로 전환하기

- **토큰 스트림**을 스트림 종료 전에 **파싱 가능한 JSON** 객체로 변환합니다.
- **LLM** 기반 AI 애플리케이션에서 **스트리밍 UI**를 구현합니다.
- 초기 스트림 처리를 위해 **OpenAI 함수 호출**을 활용합니다.
- **JSON 스트림**을 개별 **엔티티**로 파싱합니다.
- 사용자를 **실시간** 경험으로 참여시킵니다.

![json_stream_color](https://github.com/st3w4r/openai-partial-stream/assets/4228332/04c4bdfc-d991-4ad0-85fc-04eb35b106f3)

## 작업 팔로우하기

- [✖️ 트위터](https://twitter.com/YanaelBarbier)
- [🧵 쓰레드](https://www.threads.net/@yanaelbarbier)
- [📰 블로그](https://yanael.io/subscribe/)

## 설치

종속성 설치하기:

```bash
npm install --save openai-partial-stream
```

## 간단한 스트림 사용법

토큰 스트림을 가능한 한 빨리 파싱 가능한 JSON 객체로 변환합니다.

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
출력:


```js
{ index: 0, status: 'PARTIAL', data: {} }
{ index: 0, status: 'PARTIAL', data: { sentence: '' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello,' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world!' } }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hello, world!' } }
```

## 스트림 및 엔티티 파싱과 함께 사용하기

스키마에 따라 데이터를 검증하고 데이터가 유효할 때만 반환합니다.

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
출력:


```js
{ index: 0, status: 'PARTIAL', data: {}, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: '' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi,' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world!' }, entity: 'sentence' }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hi, world!' }, entity: 'sentence'}
```

## 스트림 및 여러 엔티티가 있는 엔티티 파싱 사용법

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

출력:

```js
{ index: 0, status: 'COMPLETED', data: { name: 'Los Angeles', postcode: '90001', population: 3971883 }, entity: 'postcodes' }
{ index: 1, status: 'COMPLETED', data: { name: 'San Francisco', postcode: '94102', population: 883305 }, entity: 'postcodes' }
{ index: 2, status: 'COMPLETED', data: { name: 'San Diego', postcode: '92101', population: 1425976 }, entity: 'postcodes'}
```

# 모드

아래 목록에서 귀하의 요구에 가장 적합한 모드를 선택하십시오:

1. **NoStream**
2. **StreamObject**
3. **StreamObjectKeyValue**
4. **StreamObjectKeyValueTokens**

---

### NoStream

전체 쿼리가 완료된 후에만 결과가 반환됩니다.

| **NoStream 세부사항**                                           |
| --------------------------------------------------------------- |
| ✅ 단일 쿼리로 모든 데이터를 가져옵니다                         |
| ✅ 네트워크 트래픽을 줄여줍니다                                 |
| ⚠️ 대기 시간이 길어져 사용자 경험이 저하될 수 있습니다          |

---

### StreamObject

목록의 각 항목에 대해 이벤트가 생성됩니다. 항목은 준비되는 대로 나타납니다.

| **StreamObject 세부사항**                                                               |
| ---------------------------------------------------------------------------------------- |
| ✅ 각 메시지는 완성된 항목에 해당합니다                                                  |
| ✅ 메시지 수가 적습니다                                                                  |
| ✅ 모든 필수 필드를 한 번에 받습니다                                                    |
| ⚠️ 약간의 지연: 사용자는 항목이 완전히 준비될 때까지 UI 업데이트를 기다려야 합니다       |

---

### StreamObjectKeyValue

객체는 조각으로 수신됩니다: 키와 해당 값이 함께 전송됩니다.
| **StreamObjectKeyValue 세부사항**                          |
| --------------------------------------------------------- |
| ✅ 사용자가 UI의 일부와 상호작용할 수 있음               |
| ✅ 보다 정기적인 UI 업데이트 지원                         |
| ⚠️ 네트워크 트래픽 증가                                   |
| ⚠️ 불완전한 객체로 인한 키 적용의 어려움                 |

---

### StreamObjectKeyValueTokens

키는 전체로 수신되며, 값은 완성될 때까지 조각조각 전달됩니다. 이 방법은 토큰 단위 UI 업데이트를 제공합니다.

| **StreamObjectKeyValueToken 세부사항**                               |
| ------------------------------------------------------------------- |
| ✅ 동적인 사용자 경험 제공                                         |
| ✅ 단계별 콘텐츠 소비 가능                                         |
| ✅ 사용자 대기 시간 감소                                           |
| ⚠️ 값이 점진적으로 도착함에 따른 UI 불일치 가능성                 |
| ⚠️ 증가된 네트워크 트래픽                                         |

## 데모

키-값 쌍 단위로 점진적으로 JSON 객체 스트리밍:

https://github.com/st3w4r/openai-partial-stream/assets/4228332/55643614-b92b-4b1f-9cf9-e60d6d783a0c

실시간으로 JSON 객체 스트리밍:

https://github.com/st3w4r/openai-partial-stream/assets/4228332/73289d38-8526-46cf-a68c-ac80019092ab

## 참고자료

[npm 패키지](https://www.npmjs.com/package/openai-partial-stream)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---