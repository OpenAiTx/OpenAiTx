# Ax, DSPy für Typescript

Die Arbeit mit LLMs ist komplex – sie tun nicht immer das, was man möchte. DSPy macht es einfacher, beeindruckende Anwendungen mit LLMs zu entwickeln. Definieren Sie einfach Ihre Eingaben und Ausgaben (Signatur), und ein effizienter Prompt wird automatisch generiert und verwendet. Verbinden Sie verschiedene Signaturen, um komplexe Systeme und Workflows mit LLMs zu bauen.

Und damit Sie Ax wirklich produktiv einsetzen können, liefern wir alles Weitere mit, was Sie benötigen: Observability, Streaming, Unterstützung für weitere Modalitäten (Bilder, Audio, etc.), Fehlerkorrektur, Multi-Step-Funktionsaufrufe, MCP, RAG und vieles mehr.

[![NPM Package](https://img.shields.io/npm/v/@ax-llm/ax?style=for-the-badge&color=green)](https://www.npmjs.com/package/@ax-llm/ax)
[![Discord Chat](https://dcbadge.vercel.app/api/server/DSHg3dU7dW?style=for-the-badge)](https://discord.gg/DSHg3dU7dW)
[![Twitter](https://img.shields.io/twitter/follow/dosco?style=for-the-badge&color=red)](https://twitter.com/dosco)

<!-- header -->

## Warum Ax verwenden?

- Standardisierte Schnittstelle für alle führenden LLMs
- Prompts aus einfachen Signaturen kompiliert
- Volles, natives End-to-End-Streaming
- Unterstützung für "Thinking Budget" und "Thought Tokens"
- Baue Agenten, die andere Agenten aufrufen können
- Eingebaute MCP (Model Context Protocol) Unterstützung
- Dokumente beliebigen Formats in Text umwandeln
- RAG, intelligentes Chunking, Embedding, Abfragen
- Funktioniert mit Vercel AI SDK
- Ausgabevalidierung während des Streamings
- Multi-modales DSPy unterstützt
- Automatisches Prompt-Tuning mit Optimierern
- OpenTelemetry Tracing / Observability
- Produktionsreifer Typescript-Code
- Leichtgewichtig, keine Abhängigkeiten

## Produktionsreif

- Keine Breaking Changes (Minor Versions)
- Hohe Testabdeckung
- Eingebaute Open Telemetry `gen_ai` Unterstützung
- Wird produktiv von vielen Startups genutzt

## Was ist eine Prompt-Signatur?

<img width="860" alt="shapes at 24-03-31 00 05 55" src="https://raw.githubusercontent.com/ax-llm/ax/main/github.com/dosco/llm-client/assets/832235/0f0306ea-1812-4a0a-9ed5-76cd908cd26b">

Effiziente, typsichere Prompts werden aus einer einfachen Signatur automatisch generiert. Eine Prompt-Signatur besteht aus
`"task description" inputField:type "field description" -> "outputField:type`.
Die Idee der Prompt-Signaturen basiert auf Arbeiten aus dem Paper
"Demonstrate-Search-Predict".

Es sind mehrere Eingabe- und Ausgabefelder möglich, jedes Feld kann die Typen `string`, `number`, `boolean`, `date`, `datetime`, `class "class1, class2"`, `JSON` oder ein Array davon, z.B. `string[]`, haben. Ist kein Typ definiert, wird `string` als Standard verwendet. Das Suffix `?` macht das Feld optional (Standard: erforderlich), `!` macht das Feld intern, was z. B. für Reasoning nützlich ist.

## Ausgabefeld-Typen

| Typ                      | Beschreibung                         | Verwendung                  | Beispielausgabe                                     |
| ------------------------ | ------------------------------------ | --------------------------- | --------------------------------------------------- |
| `string`                 | Eine Zeichenkette                    | `fullName:string`           | `"example"`                                         |
| `number`                 | Ein numerischer Wert                 | `price:number`              | `42`                                                |
| `boolean`                | Wahrheitswert                        | `isEvent:boolean`           | `true`, `false`                                     |
| `date`                   | Ein Datum                            | `startDate:date`            | `"2023-10-01"`                                      |
| `datetime`               | Datum und Uhrzeit                    | `createdAt:datetime`        | `"2023-10-01T12:00:00Z"`                            |
| `class "class1,class2"`  | Klassifizierung von Items            | `category:class`            | `["class1", "class2", "class3"]`                    |
| `string[]`               | Array von Zeichenketten              | `tags:string[]`             | `["example1", "example2"]`                          |
| `number[]`               | Array von Zahlen                     | `scores:number[]`           | `[1, 2, 3]`                                         |
| `boolean[]`              | Array von Wahrheitswerten            | `permissions:boolean[]`     | `[true, false, true]`                               |
| `date[]`                 | Array von Daten                      | `holidayDates:date[]`       | `["2023-10-01", "2023-10-02"]`                      |
| `datetime[]`             | Array von Datum und Uhrzeit          | `logTimestamps:datetime[]`  | `["2023-10-01T12:00:00Z", "2023-10-02T12:00:00Z"]`  |
| `class[] "class1,class2"`| Mehrere Klassen                      | `categories:class[]`        | `["class1", "class2", "class3"]`                    |
| `code "language"`        | Codeblock in einer Sprache           | `code:code "python"`        | `print('Hello, world!')`                            |

## Unterstützte LLMs

`Google Gemini`, `OpenAI`, `Azure OpenAI`, `Anthropic`, `X Grok`, `TogetherAI`, `Cohere`, `Mistral`, `Groq`, `DeepSeek`, `Ollama`, `Reka`, `Hugging Face`

## Installation

```bash
npm install @ax-llm/ax
# oder
yarn add @ax-llm/ax
```

## Beispiel: Chain-of-Thought zum Zusammenfassen von Text

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

## Beispiel: Einen Agenten bauen

Nutzen Sie das Agent-Prompt-Framework, um Agenten zu bauen, die mit anderen Agenten zusammenarbeiten, um Aufgaben zu erledigen. Agenten sind mit Prompt-Signaturen einfach zu erstellen. Probieren Sie das Agenten-Beispiel aus.

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

## Unterstützung für Thinking Models

Ax bietet native Unterstützung für Modelle mit "Thinking"-Fähigkeiten, sodass Sie das Token-Budget für das Denken steuern und auf die Überlegungen des Modells zugreifen können. Diese Funktion hilft dabei, den Denkprozess des Modells nachzuvollziehen und den Token-Verbrauch zu optimieren.

```typescript
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY as string,
  config: {
    model: AxAIGoogleGeminiModel.Gemini25Flash,
    thinking: { includeThoughts: true },
  },
})

// Oder Thinking-Budget pro Anfrage steuern
const gen = new AxChainOfThought(`question -> answer`)
const res = await gen.forward(
  ai,
  { question: 'What is quantum entanglement?' },
  { thinkingTokenBudget: 'medium' } // 'minimal', 'low', 'medium', oder 'high'
)

// Gedanken aus der Antwort auslesen
console.log(res.thoughts) // Zeigt den Denkprozess des Modells
```

## Unterstützte Vektor-Datenbanken

Vektor-Datenbanken sind entscheidend für LLM-Workflows. Wir bieten saubere Abstraktionen über populäre Vektor-Datenbanken und eine schnelle In-Memory-Variante.

| Anbieter    | Getestet |
| ----------- | -------- |
| In Memory   | 🟢 100%  |
| Weaviate    | 🟢 100%  |
| Cloudflare  | 🟡 50%   |
| Pinecone    | 🟡 50%   |

```typescript
// Erstellen von Embeddings aus Text mit einem LLM
const ret = await this.ai.embed({ texts: 'hello world' })

// In-Memory-Vektor-DB erstellen
const db = new axDB('memory')

// In die Vektor-DB einfügen
await this.db.upsert({
  id: 'abc',
  table: 'products',
  values: ret.embeddings[0],
})

// Ähnliche Einträge mit Embeddings abfragen
const matches = await this.db.query({
  table: 'products',
  values: embeddings[0],
})
```

Alternativ können Sie den `AxDBManager` nutzen, der intelligentes Chunking, Embedding und Abfrage für Sie übernimmt.

```typescript
const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query(
  'John von Neumann on human intelligence and singularity.'
)
console.log(matches)
```

## RAG-Dokumente

Dokumente wie PDF, DOCX, PPT, XLS, etc. mit LLMs zu nutzen ist mühsam. Wir machen es mit Apache Tika, einer Open-Source-Dokumenten-Engine, einfach.

Apache Tika starten:

```shell
docker run -p 9998:9998 apache/tika
```

Dokumente zu Text konvertieren und mit dem `AxDBManager` für Retrieval einbetten. Es sind auch ein Reranker und Query-Rewriter integriert (`AxDefaultResultReranker` und `AxDefaultQueryRewriter`).

```typescript
const tika = new AxApacheTika()
const text = await tika.convert('/path/to/document.pdf')

const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query('Find some text')
console.log(matches)
```

## Multi-modal DSPy

Bei Modellen wie `GPT-4o` und `Gemini`, die Multi-Modal Prompts unterstützen, können Bildfelder verwendet werden – funktioniert mit der gesamten DSP-Pipeline.

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

Mit Modellen wie `gpt-4o-audio-preview`, die Audio unterstützen, sind auch Audiofelder möglich:

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

Inspiriert von DSPys Demonstration Weaving bietet Ax `AxMessage` für nahtloses Management des Gesprächsverlaufs. So können Sie Chatbots bauen, die den Kontext über mehrere Turns behalten und die volle Power der Prompt-Signaturen nutzen. Details siehe Beispiel.

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

Die Gesprächshistorie wird automatisch in den Prompt eingebunden, wodurch das Modell den Kontext behält und zusammenhängende Antworten gibt. Funktioniert mit allen Ax-Features wie Streaming, Funktionsaufrufen, Chain-of-Thought.

## Streaming

### Assertions

Wir unterstützen das Parsen von Ausgabefeldern und Funktionsausführung während des Streamings. Das erlaubt Fail-Fast und Fehlerkorrektur, spart Tokens, Kosten und reduziert Latenz. Assertions sind eine mächtige Methode, um die Einhaltung Ihrer Anforderungen sicherzustellen – auch beim Streaming.

```typescript
// Prompt-Programm aufsetzen
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

// Assertion hinzufügen, dass die Zahl 5 nicht enthalten sein darf
gen.addAssert(({ next10Numbers }: Readonly<{ next10Numbers: number[] }>) => {
  return next10Numbers ? !next10Numbers.includes(5) : undefined
}, 'Numbers 5 is not allowed')

// Programm mit aktiviertem Streaming ausführen
const res = await gen.forward({ startNumber: 1 }, { stream: true })

// Oder End-to-End-Streaming
const generator = await gen.streamingForward(
  { startNumber: 1 },
  {
    stream: true,
  }
)
for await (const res of generator) {
}
```

Sie können ganze Ausgabefelder während des Streamings validieren. Die Validierung wird ausgelöst, sobald das Feld komplett ist. Für echte Validierung schon während des Streamings siehe folgendes Beispiel – das steigert Performance und spart Tokens in der Produktion.

```typescript
// Assertion für jede Zeile: muss mit Zahl und Punkt beginnen
gen.addStreamingAssert(
  'answerInPoints',
  (value: string) => {
    const re = /^\d+\./

    // Zeilen splitten, trimmen, leere Zeilen filtern, alle auf Regex prüfen
    return value
      .split('\n')
      .map((x) => x.trim())
      .filter((x) => x.length > 0)
      .every((x) => re.test(x))
  },
  'Lines must start with a number and a dot. Eg: 1. This is a line.'
)

// Programm mit aktiviertem Streaming ausführen
const res = await gen.forward(
  {
    question: 'Provide a list of optimizations to speedup LLM inference.',
  },
  { stream: true, debug: true }
)
```

### Field Processors

Field Processors verarbeiten Felder in einem Prompt vor der Übergabe an das LLM.

```typescript
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

const streamValue = false

const processorFunction = (value) => {
  return value.map((x) => x + 1)
}

// Feld-Processor zum Programm hinzufügen
const processor = new AxFieldProcessor(
  gen,
  'next10Numbers',
  processorFunction,
  streamValue
)

const res = await gen.forward({ startNumber: 1 })
```

## Model Context Protocol (MCP)

Ax integriert nahtlos das Model Context Protocol (MCP), sodass Ihre Agenten externe Tools und Ressourcen über eine standardisierte Schnittstelle erreichen.

### Verwendung von AxMCPClient

Mit `AxMCPClient` können Sie sich mit jedem MCP-kompatiblen Server verbinden und dessen Funktionen in Ax-Agenten nutzen:

```typescript
import { AxMCPClient, AxMCPStdioTransport } from '@ax-llm/ax'

// MCP-Client mit Transport initialisieren
const transport = new AxMCPStdioTransport({
  command: 'npx',
  args: ['-y', '@modelcontextprotocol/server-memory'],
})

// Client mit optionalem Debug-Modus erstellen
const client = new AxMCPClient(transport, { debug: true })

// Verbindung initialisieren
await client.init()

// Funktionen des Clients im Agenten verwenden
const memoryAgent = new AxAgent({
  name: 'MemoryAssistant',
  description: 'An assistant with persistent memory',
  signature: 'input, userId -> response',
  functions: [client], // Client als Funktionsanbieter angeben
})

// Oder Client mit AxGen verwenden
const memoryGen = new AxGen('input, userId -> response', {
  functions: [client],
})
```

### AxMCPClient mit Remote-Server verwenden

Einen Remote-MCP-Server mit Ax anzusprechen ist unkompliziert. Beispiel: DeepWiki MCP-Server für Fragen zu öffentlichen GitHub-Repos (`https://mcp.deepwiki.com/mcp`).

```typescript
import {
  AxAgent,
  AxAI,
  AxAIOpenAIModel,
  AxMCPClient,
  AxMCPStreambleHTTPTransport,
} from '@ax-llm/ax'

// 1. MCP-Transport zum DeepWiki-Server initialisieren
const transport = new AxMCPStreambleHTTPTransport(
  'https://mcp.deepwiki.com/mcp'
)

// 2. MCP-Client erstellen
const mcpClient = new AxMCPClient(transport, { debug: false })
await mcpClient.init() // Verbindung initialisieren

// 3. AI-Modell initialisieren (z.B. OpenAI)
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY as string,
})

// 4. AxAgent, der den MCP-Client nutzt
const deepwikiAgent = new AxAgent<
  {
    // Input-Typen passend zur DeepWiki-Funktion
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
  functions: [mcpClient], // MCP-Client als Funktion liefern
})

// 5. Frage formulieren und Agenten aufrufen
const result = await deepwikiAgent.forward(ai, {
  questionAboutRepo: 'What is the main purpose of this library?',
  githubRepositoryUrl: 'https://github.com/dosco/ax',
})
console.log('DeepWiki Answer:', result.answer)
```

Dieses Beispiel zeigt, wie Sie einen öffentlichen MCP-Server mit einem Ax-Agenten nutzen. Die Signatur (`questionAboutRepo, githubRepositoryUrl -> answer`) ist ein Beispiel. Die verfügbaren Funktionen und Signaturen erfahren Sie vom MCP-Server selbst (z.B. via `mcp.getFunctions` oder Dokumentation).

Für komplexere Beispiele mit Authentifizierung und benutzerdefinierten Headern siehe die Datei `src/examples/mcp-client-pipedream.ts` in diesem Repository.

## AI Routing und Load Balancing

Ax bietet zwei leistungsstarke Methoden zur Nutzung mehrerer AI-Services: einen Load Balancer für hohe Verfügbarkeit und einen Router für modell-spezifisches Routing.

### Load Balancer

Der Load Balancer verteilt Anfragen automatisch auf mehrere AI-Services basierend auf Performance und Verfügbarkeit. Fällt ein Service aus, wird automatisch zum nächsten gewechselt.

```typescript
import { AxAI, AxBalancer } from '@ax-llm/ax'

// Mehrere AI-Services aufsetzen
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

// Load Balancer mit allen Services erstellen
const balancer = new AxBalancer([openai, ollama, gemini])

// Wie einen normalen AI-Service verwenden
const response = await balancer.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
})

// Oder mit AxGen verwenden
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(balancer, { question: 'Hello!' })
```

### Multi-Service Router

Der Router ermöglicht die Nutzung mehrerer AI-Services über eine Schnittstelle und routet Anfragen modellbasiert.

```typescript
import { AxAI, AxAIOpenAIModel, AxMultiServiceRouter } from '@ax-llm/ax'

// OpenAI mit Modellen
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

// Gemini mit Modellen
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

// Router mit allen Services erstellen
const router = new AxMultiServiceRouter([openai, gemini, secretService])

// Routing zu OpenAIs Expert-Modell
const openaiResponse = await router.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
  model: 'expert',
})

// Oder mit AxGen verwenden
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(router, { question: 'Hello!' })
```

Der Load Balancer ist ideal für Hochverfügbarkeit, der Router für modell-spezifische Aufgaben. Beide lassen sich mit allen Ax-Features wie Streaming, Funktionsaufrufen und Chain-of-Thought kombinieren.

Balancer und Router können auch zusammen eingesetzt werden: Mehrere Balancer mit dem Router, oder umgekehrt.

## OpenTelemetry-Unterstützung

Tracing und Observability Ihres LLM-Workflows sind zentral für den Betrieb in der Produktion. OpenTelemetry ist Standard und wir unterstützen das `gen_ai`-Attribut-Namespace. Siehe `src/examples/telemetry.ts` für mehr Informationen.

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

## Prompt-Tuning (Basic)

Optimieren Sie Ihre Prompts mit einem größeren Modell für effizientere und bessere Ergebnisse. Dies geschieht mit einem Optimierer wie `AxBootstrapFewShot` und Beispielen, z.B. aus dem `HotPotQA`-Datensatz. Der Optimierer generiert Demonstrationen (`demos`), die die Effizienz der Prompts steigern.

```typescript
// HotPotQA-Datensatz von Huggingface laden
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

// Programm zum Tuning aufsetzen
const program = new AxChainOfThought<{ question: string }, { answer: string }>(
  ai,
  `question -> answer "in short 2 or 3 words"`
)

// Bootstrap Few Shot Optimierer zum Tuning
const optimize = new AxBootstrapFewShot<
  { question: string },
  { answer: string }
>({
  program,
  examples,
})

// Evaluations-Metrik em, f1 Score ist beliebt für Retrieval-Performance
const metricFn: AxMetricFn = ({ prediction, example }) =>
  emScore(prediction.answer as string, example.answer as string)

// Optimierer ausführen und Ergebnis speichern
const result = await optimize.compile(metricFn);

// Demos in Datei speichern
// import fs from 'fs';
fs.writeFileSync('bootstrap-demos.json', JSON.stringify(result.demos, null, 2));
console.log('Demos saved to bootstrap-demos.json');
```

<img width="853" alt="tune-prompt" src="https://raw.githubusercontent.com/ax-llm/ax/main/github.com/dosco/llm-client/assets/832235/f924baa7-8922-424c-9c2c-f8b2018d8d74">
```

## Prompt-Tuning (Fortgeschritten, Mipro v2)

MiPRO v2 ist ein fortgeschrittenes Prompt-Optimierungs-Framework, das Bayes'sche Optimierung nutzt, um automatisch die besten Instruktionen, Demonstrationen und Beispiele für Ihre LLM-Programme zu finden. Durch systematisches Testen verschiedener Prompt-Konfigurationen maximiert MiPRO v2 die Modell-Performance ohne manuelles Tuning. 

### Hauptmerkmale

- **Instruktionsoptimierung**: Generiert und testet automatisch mehrere Instruktionskandidaten
- **Few-Shot-Beispielauswahl**: Findet optimale Demonstrationen aus Ihrem Datensatz
- **Bayes'sche Optimierung**: Nutzt UCB-Strategie für effiziente Exploration
- **Early Stopping**: Stoppt Optimierung, wenn Verbesserungen stagnieren
- **Programm- und datenbewusst**: Berücksichtigt Programmstruktur und Datensatz

### Funktionsweise

1. Generiert verschiedene Instruktionskandidaten
2. Bootstrapped Few-Shot-Beispiele aus Ihren Daten
3. Wählt gelabelte Beispiele direkt aus dem Datensatz
4. Findet mit Bayes'scher Optimierung die optimale Kombination
5. Setzt die beste Konfiguration im Programm ein

### Grundlegende Nutzung

```typescript
import { AxAI, AxChainOfThought, AxMiPRO } from '@ax-llm/ax'

// 1. AI-Service aufsetzen
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY,
})

// 2. Programm erstellen
const program = new AxChainOfThought(`input -> output`)

// 3. Optimierer konfigurieren
const optimizer = new AxMiPRO({
  ai,
  program,
  examples: trainingData,
  options: {
    numTrials: 20, // Anzahl Konfigurationen
    auto: 'medium',
  },
})

// 4. Evaluationsmetrik definieren
const metricFn = ({ prediction, example }) => {
  return prediction.output === example.output
}

// 5. Optimierung ausführen
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData,
})

// 6. Optimiertes Programm nutzen
const result = await optimizedProgram.forward(ai, { input: 'test input' })
```

### Konfigurationsoptionen

MiPRO v2 bietet umfangreiche Konfigurationsmöglichkeiten:

| Option                    | Beschreibung                                    | Standard |
| ------------------------- | ----------------------------------------------- | -------- |
| `numCandidates`           | Anzahl Instruktionskandidaten                   | 5        |
| `numTrials`               | Optimierungsdurchläufe                          | 30       |
| `maxBootstrappedDemos`    | Max. Anzahl bootstrapped Demos                  | 3        |
| `maxLabeledDemos`         | Max. Anzahl gelabelter Beispiele                | 4        |
| `minibatch`               | Minibatching für schnellere Auswertung          | true     |
| `minibatchSize`           | Größe der Minibatches                           | 25       |
| `earlyStoppingTrials`     | Stoppt nach N Durchläufen ohne Verbesserung     | 5        |
| `minImprovementThreshold` | Minimale Verbesserung für Score                 | 0.01     |
| `programAwareProposer`    | Programmstruktur für bessere Vorschläge nutzen  | true     |
| `dataAwareProposer`       | Berücksichtigt Datensatz-Charakteristika        | true     |
| `verbose`                 | Zeigt detaillierten Fortschritt                 | false    |
| abort-patterns.ts | Beispiel, wie Requests abgebrochen werden können      |

### Optimierungslevel

Mit dem `auto`-Parameter lässt sich die Optimierungsintensität einstellen:

```typescript
// Light (schneller, weniger gründlich)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'light' })

// Medium (ausgewogen)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'medium' })

// Heavy (langsamer, sehr gründlich)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'heavy' })
```

### Fortgeschrittenes Beispiel: Sentimentanalyse

```typescript
// Sentimentanalyse-Programm erstellen
const classifyProgram = new AxChainOfThought<
  { productReview: string },
  { label: string }
>(`productReview -> label:string "positive" or "negative"`)

// Optimierer mit erweiterten Einstellungen
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

// Optimierung ausführen und Ergebnis speichern
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData,
})

// Konfiguration für später speichern
const programConfig = JSON.stringify(optimizedProgram, null, 2);
await fs.promises.writeFile("./optimized-config.json", programConfig);
console.log('> Done. Optimized program config saved to optimized-config.json');
```

## Nutzung der getunten Prompts

Sowohl der Bootstrap Few Shot Optimierer als auch der MiPRO v2 Optimierer erzeugen **Demos** (Demonstrationen), die die Leistung Ihres Programms deutlich verbessern. Diese Demos zeigen dem LLM, wie es ähnliche Aufgaben korrekt löst.

### Was sind Demos?

Demos sind Input-Output-Beispiele, die automatisch in Ihren Prompts eingebunden werden, um dem LLM das erwartete Verhalten für Ihre Aufgabe zu zeigen.

### Laden und Nutzen von Demos

Unabhängig davon, ob Sie Bootstrap Few Shot oder MiPRO v2 verwendet haben, ist die Nutzung gleich:

```typescript
import fs from 'fs'
import { AxAI, AxGen, AxChainOfThought } from '@ax-llm/ax'

// 1. AI-Service aufsetzen
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
})

// 2. Programm mit derselben Signatur wie beim Tuning erstellen
const program = new AxChainOfThought(`question -> answer "in short 2 or 3 words"`)

// 3. Demos aus gespeicherter Datei laden
const demos = JSON.parse(fs.readFileSync('bootstrap-demos.json', 'utf8'))

// 4. Demos auf das Programm anwenden
program.setDemos(demos)

// 5. Programm nutzen
const result = await program.forward(ai, {
  question: 'What castle did David Gregory inherit?'
})

console.log(result) // Dank Beispielen bessere Leistung
```

### Einfaches Beispiel: Textklassifikation

Komplettes Beispiel, wie Demos die Klassifikation verbessern:

```typescript
// Klassifikationsprogramm erstellen
const classifier = new AxGen(`text -> category:class "positive, negative, neutral"`)

// Demos laden (Bootstrap oder MiPRO)
const savedDemos = JSON.parse(fs.readFileSync('classification-demos.json', 'utf8'))
classifier.setDemos(savedDemos)

// Klassifikator nutzt erlernte Beispiele für bessere Ergebnisse
const result = await classifier.forward(ai, {
  text: "This product exceeded my expectations!"
})

console.log(result.category) // Genauere Klassifikation
```

### Vorteile der Nutzung von Demos

- **Bessere Genauigkeit**: Programme liefern mit Beispielen deutlich bessere Ergebnisse
- **Konsistente Ausgaben**: Demos sichern konsistente Ausgabeformate
- **Weniger Halluzinationen**: Beispiele lenken das Modell auf erwartetes Verhalten
- **Kosteneffizient**: Bessere Resultate ohne größere/teurere Modelle

### Best Practices

1. **Demos speichern**: Immer in Dateien sichern für Wiederverwendung
2. **Signaturen abgleichen**: Exakt gleiche Signatur beim Laden verwenden
3. **Versionieren**: Demo-Dateien im Versionskontrollsystem halten
4. **Regelmäßig aktualisieren**: Mit neuen Daten regelmäßig neu tunen

Sowohl Bootstrap Few Shot als auch MiPRO v2 liefern Demos im gleichen Format, sodass das Laden immer gleich funktioniert.

## Eingebaute Funktionen

| Funktion            | Name               | Beschreibung                                   |
| ------------------- | ------------------ | ---------------------------------------------- |
| JS Interpreter      | AxJSInterpreter    | JS-Code in einer Sandbox ausführen             |
| Docker Sandbox      | AxDockerSession    | Kommandos in einer Docker-Umgebung ausführen   |
| Embeddings Adapter  | AxEmbeddingAdapter | Embedding abrufen und an Funktionen übergeben  |

## Alle Beispiele ansehen

Mit dem `tsx`-Kommando Beispiele ausführen. Damit kann Node direkt TypeScript ausführen. `.env`-Datei für AI-API-Keys wird unterstützt.

```shell
OPENAI_APIKEY=api-key npm run tsx ./src/examples/marketing.ts
```

| Beispiel                 | Beschreibung                                             |
| ------------------------ | -------------------------------------------------------- |
| customer-support.ts      | Extrahiert Details aus Kundennachrichten                 |
| function.ts              | Einfaches Beispiel für Funktionsaufruf                   |
| food-search.ts           | Multi-Step, Multi-Funktionsaufruf                        |
| marketing.ts             | Kurze, effektive Marketing-SMS generieren                |
| vectordb.ts              | Text chunken, embedden, durchsuchen                      |
| fibonacci.ts             | JS-Code-Interpreter für Fibonacci                        |
| summarize.ts             | Kurzzusammenfassung eines großen Textblocks              |
| chain-of-thought.ts      | Chain-of-Thought zum Beantworten von Fragen              |
| rag.ts                   | Multi-Hop-Retrieval für Fragenbeantwortung               |
| rag-docs.ts              | PDF in Text umwandeln und für Rag-Suche embedden         |
| react.ts                 | Funktionsaufruf und Reasoning für Antworten              |
| agent.ts                 | Agenten-Framework, Agenten nutzen andere Agenten, Tools  |
| streaming1.ts            | Validierung von Ausgabefeldern beim Streaming            |
| streaming2.ts            | Validierung pro Ausgabefeld beim Streaming               |
| streaming3.ts            | End-to-End Streaming Beispiel `streamingForward()`       |
| smart-hone.ts            | Agent sucht Hund im Smart Home                           |
| multi-modal.ts           | Bildinput plus weitere Textinputs                        |
| balancer.ts              | Balanciert verschiedene LLMs nach Kosten etc.            |
| docker.ts                | Docker-Sandbox sucht Dateien nach Beschreibung           |
| prime.ts                 | Field Processor für Promptfeld                           |
| simple-classify.ts       | Einfache Klassifikation                                  |
| mcp-client-memory.ts     | MCP-Server für Memory mit Ax                             |
| mcp-client-blender.ts    | MCP-Server für Blender mit Ax                            |
| mcp-client-pipedream.ts  | Integration mit Remote-MCP                               |
| tune-bootstrap.ts        | Bootstrap-Optimizer für Prompt-Effizienz                 |
| tune-mipro.ts            | MiPRO v2 Optimizer für Prompt-Effizienz                  |
| tune-usage.ts            | Optimierte Prompts nutzen                                |
| telemetry.ts             | Tracing und Jaeger-Integration                           |
| openai-responses.ts      | Nutzung der neuen OpenAI Responses API                   |
| use-examples.ts          | Verwendung von 'examples' zur Lenkung des LLM            |

## Unser Ziel

Große Sprachmodelle (LLMs) werden immer leistungsfähiger und sind mittlerweile in der Lage, das Backend Ihres gesamten Produkts zu bilden. Dennoch bleibt viel Komplexität zu bewältigen: richtige Prompts, Modelle, Streaming, Funktionsaufrufe, Fehlerkorrektur usw. Unser Ziel ist es, all diese Komplexität in einer gepflegten, einfach nutzbaren Bibliothek zu bündeln, die mit allen modernen LLMs funktioniert. Außerdem bringen wir neue Features wie DSPy aus der Forschung direkt in die Bibliothek.

## Wie benutzt man diese Bibliothek?

### 1. Wählen Sie eine KI

```ts
// LLM wählen
const ai = new AxOpenAI({ apiKey: process.env.OPENAI_APIKEY } as AxOpenAIArgs)
```

### 2. Prompt-Signatur je nach Anwendungsfall erstellen

```ts
// Die Signatur definiert Eingaben und Ausgaben des Prompt-Programms
const cot = new ChainOfThought(ai, `question:string -> answer:string`, { mem })
```

### 3. Prompt-Programm ausführen

```ts
// Die in der Signatur definierten Eingabefelder übergeben
const res = await cot.forward({ question: 'Are we in a simulation?' })
```

### 4. Oder direkt das LLM nutzen

```ts
const res = await ai.chat([
  { role: "system", content: "Help the customer with his questions" }
  { role: "user", content: "I'm looking for a Macbook Pro M2 With 96GB RAM?" }
]);
```

## Wie nutzt man Funktionsaufrufe?

### 1. Funktionen definieren

```ts
// Eine oder mehrere Funktionen und einen Handler definieren
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

### 2. Funktionen an einen Prompt übergeben

```ts
const cot = new AxGen(ai, `question:string -> answer:string`, { functions })
```

## Debug-Logs aktivieren

```ts
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
} as AxOpenAIArgs)
ai.setOptions({ debug: true })
```

## Kontakt

Wir helfen gerne weiter – bei Fragen einfach melden oder auf Discord joinen:  
[twitter/dosco](https://twitter.com/dosco)

## FAQ

### 1. Das LLM findet nicht die richtige Funktion

Verbessern Sie die Funktionsnamen und Beschreibungen. Seien Sie sehr klar, was die Funktion tut. Auch die Parameter sollten gut beschrieben sein – kurz, aber präzise.

### 2. Wie ändere ich die Konfiguration des verwendeten LLMs?

Sie können beim Erstellen eines neuen LLM-Objekts ein Konfigurationsobjekt als zweiten Parameter übergeben.

```ts
const apiKey = process.env.OPENAI_APIKEY
const conf = AxOpenAIBestConfig()
const ai = new AxOpenAI({ apiKey, conf } as AxOpenAIArgs)
```

## 3. Mein Prompt ist zu lang / Kann ich die max Tokens ändern?

```ts
const conf = axOpenAIDefaultConfig() // oder OpenAIBestOptions()
conf.maxTokens = 2000
```

## 4. Wie ändere ich das Modell? (z.B. GPT4 nutzen)

```ts
const conf = axOpenAIDefaultConfig() // oder OpenAIBestOptions()
conf.model = OpenAIModel.GPT4Turbo
```

## Monorepo-Tipps & Tricks

Führen Sie `npm install` nur im Root-Verzeichnis aus. So verhindern Sie verschachtelte `package-lock.json` und nicht deduplizierte `node_modules`.

Neue Abhängigkeiten in Packages mit  
`npm install lodash --workspace=ax`  
hinzufügen (oder `package.json` anpassen und `npm install` im Root ausführen).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---