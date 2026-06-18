# 部分JSONストリームの解析 - あなたの遅いAIアプリを魅力的なリアルタイムアプリに変える

- **トークンのストリーム**をストリーム終了前に**解析可能なJSON**オブジェクトに変換します。
- **LLM**ベースのAIアプリケーションで**ストリーミングUI**を実装します。
- 早期ストリーム処理のために**OpenAI関数呼び出し**を活用します。
- **JSONストリーム**を個別の**エンティティ**に解析します。
- ユーザーを**リアルタイム**体験で引き込みます。

![json_stream_color](https://github.com/st3w4r/openai-partial-stream/assets/4228332/04c4bdfc-d991-4ad0-85fc-04eb35b106f3)

## 進捗をフォローする

- [✖️ Twitter](https://twitter.com/YanaelBarbier)
- [🧵 Threads](https://www.threads.net/@yanaelbarbier)
- [📰 ブログ](https://yanael.io/subscribe/)

## インストール

依存関係をインストールするには：

```bash
npm install --save openai-partial-stream
```

## シンプルなストリームでの使用

トークンのストリームをできるだけ早く解析可能なJSONオブジェクトに変換します。

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
出力：


```js
{ index: 0, status: 'PARTIAL', data: {} }
{ index: 0, status: 'PARTIAL', data: { sentence: '' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello,' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world' } }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hello, world!' } }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hello, world!' } }
```

## ストリームおよびエンティティ解析での使用

スキーマに対してデータを検証し、有効な場合にのみデータを返します。

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
出力：


```js
{ index: 0, status: 'PARTIAL', data: {}, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: '' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi,' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world' }, entity: 'sentence' }
{ index: 0, status: 'PARTIAL', data: { sentence: 'Hi, world!' }, entity: 'sentence' }
{ index: 0, status: 'COMPLETED', data: { sentence: 'Hi, world!' }, entity: 'sentence'}
```

## 複数のエンティティを用いたストリームおよびエンティティ解析での使用法

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
出力:


```js
{ index: 0, status: 'COMPLETED', data: { name: 'Los Angeles', postcode: '90001', population: 3971883 }, entity: 'postcodes' }
{ index: 1, status: 'COMPLETED', data: { name: 'San Francisco', postcode: '94102', population: 883305 }, entity: 'postcodes' }
{ index: 2, status: 'COMPLETED', data: { name: 'San Diego', postcode: '92101', population: 1425976 }, entity: 'postcodes'}
```

# モード

以下のリストから、あなたの要件に最も適したモードを選択してください：

1. **NoStream**
2. **StreamObject**
3. **StreamObjectKeyValue**
4. **StreamObjectKeyValueTokens**

---

### NoStream

結果はクエリ全体が完了してから返されます。

| **NoStreamの詳細**                                               |
| --------------------------------------------------------------- |
| ✅ 単一のクエリで全データを取得                                |
| ✅ ネットワークトラフィックを削減                              |
| ⚠️ 待機時間が長くなるためユーザー体験が損なわれる可能性あり |

---

### StreamObject

リスト内の各アイテムに対してイベントが生成されます。アイテムは準備ができ次第表示されます。

| **StreamObjectの詳細**                                                           |
| -------------------------------------------------------------------------------- |
| ✅ 各メッセージは完全なアイテムに対応                                          |
| ✅ メッセージ数が少ない                                                         |
| ✅ すべての必須フィールドが一度に受信される                                    |
| ⚠️ 一部遅延あり：アイテムの準備完了までユーザーはUIの更新を待つ必要がある       |

---

### StreamObjectKeyValue

オブジェクトは断片で受信されます：キーと対応する値が一緒に送信されます。
| **StreamObjectKeyValue の詳細**                          |
| --------------------------------------------------------- |
| ✅ ユーザーはUIの一部と対話可能                            |
| ✅ より定期的なUI更新をサポート                            |
| ⚠️ ネットワークトラフィックが増加                          |
| ⚠️ 不完全なオブジェクトによるキーの強制が困難             |

---

### StreamObjectKeyValueTokens

キーは完全な状態で受信され、値は完全になるまで断片的に配信されます。この方法はトークン単位でのUI更新を可能にします。

| **StreamObjectKeyValueToken の詳細**                               |
| ------------------------------------------------------------------- |
| ✅ ダイナミックなユーザー体験を提供                               |
| ✅ コンテンツを段階的に消費可能                                   |
| ✅ ユーザーの待機時間を短縮                                       |
| ⚠️ 値が断続的に到着することでUIの不整合が発生する可能性           |
| ⚠️ ネットワークトラフィックの増加                                 |

## デモ

キーと値のペアでJSONオブジェクトを段階的にストリーム：

https://github.com/st3w4r/openai-partial-stream/assets/4228332/55643614-b92b-4b1f-9cf9-e60d6d783a0c

リアルタイムでJSONオブジェクトをストリーム：

https://github.com/st3w4r/openai-partial-stream/assets/4228332/73289d38-8526-46cf-a68c-ac80019092ab

## 参考文献

[npmパッケージ](https://www.npmjs.com/package/openai-partial-stream)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---