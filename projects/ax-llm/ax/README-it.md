# Ax, DSPy per Typescript

Lavorare con i LLM è complesso: non fanno sempre quello che vuoi. DSPy rende più semplice costruire soluzioni straordinarie con i LLM. Basta definire i tuoi input e output (signature) e un prompt efficiente viene generato e utilizzato automaticamente. Collega tra loro diverse signature per costruire sistemi e workflow complessi usando i LLM.

E per aiutarti davvero nell’uso in produzione, abbiamo tutto il necessario: osservabilità, streaming, supporto per altre modalità (immagini, audio, ecc.), correzione degli errori, chiamate di funzioni multi-step, MCP, RAG, ecc.

[![NPM Package](https://img.shields.io/npm/v/@ax-llm/ax?style=for-the-badge&color=green)](https://www.npmjs.com/package/@ax-llm/ax)
[![Discord Chat](https://dcbadge.vercel.app/api/server/DSHg3dU7dW?style=for-the-badge)](https://discord.gg/DSHg3dU7dW)
[![Twitter](https://img.shields.io/twitter/follow/dosco?style=for-the-badge&color=red)](https://twitter.com/dosco)

<!-- header -->

## Perché usare Ax?

- Interfaccia standard per tutti i migliori LLM
- Prompt compilati da signature semplici
- Streaming end-to-end nativo completo
- Supporto per budget di pensiero e token di ragionamento
- Costruisci Agenti che possono chiamare altri agenti
- Supporto integrato per MCP, Model Context Protocol
- Conversione di documenti di qualsiasi formato in testo
- RAG, smart chunking, embedding, interrogazione
- Funziona con Vercel AI SDK
- Validazione degli output durante lo streaming
- DSPy multi-modale supportato
- Ottimizzazione automatica dei prompt tramite optimizer
- Tracing/observabilità OpenTelemetry
- Codice Typescript pronto per la produzione
- Leggero, senza dipendenze

## Pronto per la produzione

- Nessun breaking change (versioni minori)
- Copertura di test estesa
- Supporto integrato per Open Telemetry `gen_ai`
- Ampiamente usato da startup in produzione

## Cos’è una prompt signature?

<img width="860" alt="shapes at 24-03-31 00 05 55" src="https://github.com/dosco/llm-client/assets/832235/0f0306ea-1812-4a0a-9ed5-76cd908cd26b">

Prompt efficienti e type-safe sono auto-generati da una signature semplice. Una signature di prompt è composta da
`"descrizione del task" campoInput:tipo "descrizione campo" -> "campoOutput:tipo`.
L’idea delle signature di prompt si basa sul lavoro svolto nell’articolo "Demonstrate-Search-Predict".

Puoi avere più campi di input e output, e ogni campo può essere di tipo
`string`, `number`, `boolean`, `date`, `datetime`, `class "class1, class2"`, `JSON`, o un array di uno qualsiasi di questi, ad esempio `string[]`.
Se un tipo non è definito, il default è `string`. Il suffisso `?` rende il campo opzionale (obbligatorio di default) e `!` rende il campo interno, utile per attività come il ragionamento.

## Tipi di campo Output

| Tipo                     | Descrizione                            | Uso                         | Esempio Output                                      |
| ------------------------ | -------------------------------------- | --------------------------- | --------------------------------------------------- |
| `string`                 | Sequenza di caratteri                  | `fullName:string`           | `"example"`                                         |
| `number`                 | Un valore numerico                     | `price:number`              | `42`                                                |
| `boolean`                | Valore vero o falso                    | `isEvent:boolean`           | `true`, `false`                                     |
| `date`                   | Un valore data                         | `startDate:date`            | `"2023-10-01"`                                      |
| `datetime`               | Data e ora                             | `createdAt:datetime`        | `"2023-10-01T12:00:00Z"`                            |
| `class "class1,class2"`  | Classificazione di elementi            | `category:class`            | `["class1", "class2", "class3"]`                    |
| `string[]`               | Array di stringhe                      | `tags:string[]`             | `["example1", "example2"]`                          |
| `number[]`               | Array di numeri                        | `scores:number[]`           | `[1, 2, 3]`                                         |
| `boolean[]`              | Array di valori booleani               | `permissions:boolean[]`     | `[true, false, true]`                               |
| `date[]`                 | Array di date                          | `holidayDates:date[]`       | `["2023-10-01", "2023-10-02"]`                      |
| `datetime[]`             | Array di date e ora                    | `logTimestamps:datetime[]`  | `["2023-10-01T12:00:00Z", "2023-10-02T12:00:00Z"]`  |
| `class[] "class1,class2"`| Più classi                             | `categories:class[]`        | `["class1", "class2", "class3"]`                    |
| `code "language"`        | Blocco di codice in un linguaggio      | `code:code "python"`        | `print('Hello, world!')`                            |

## LLM supportati

`Google Gemini`, `OpenAI`, `Azure OpenAI`, `Anthropic`, `X Grok`, `TogetherAI`, `Cohere`, `Mistral`, `Groq`, `DeepSeek`, `Ollama`, `Reka`, `Hugging Face`

## Installazione

```bash
npm install @ax-llm/ax
# oppure
yarn add @ax-llm/ax
```

## Esempio: Usare chain-of-thought per riassumere testo

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

## Esempio: Costruire un agente

Usa il prompt agent (framework) per costruire agenti che lavorano con altri agenti per completare task. Gli agenti sono facili da creare con le signature dei prompt. Prova l’esempio dell’agente.

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

## Supporto per modelli di pensiero

Ax offre supporto nativo per modelli con capacità di ragionamento, permettendoti di controllare il budget di token di pensiero e accedere ai pensieri del modello. Questa funzionalità aiuta a comprendere il processo di ragionamento del modello e ottimizzare l’uso dei token.

```typescript
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY as string,
  config: {
    model: AxAIGoogleGeminiModel.Gemini25Flash,
    thinking: { includeThoughts: true },
  },
})

// Oppure controlla il budget di pensiero per richiesta
const gen = new AxChainOfThought(`question -> answer`)
const res = await gen.forward(
  ai,
  { question: 'What is quantum entanglement?' },
  { thinkingTokenBudget: 'medium' } // 'minimal', 'low', 'medium', o 'high'
)

// Accedi ai pensieri nella risposta
console.log(res.thoughts) // Mostra il processo di ragionamento del modello
```

## Vector DB supportati

I database vettoriali sono fondamentali per costruire workflow con LLM. Abbiamo astrazioni pulite su popolari database vettoriali e un nostro database vettoriale in memoria.

| Provider    | Testato |
| ----------- | ------- |
| In Memory   | 🟢 100% |
| Weaviate    | 🟢 100% |
| Cloudflare  | 🟡 50%  |
| Pinecone    | 🟡 50%  |

```typescript
// Crea embeddings da testo usando un LLM
const ret = await this.ai.embed({ texts: 'hello world' })

// Crea un vector db in memoria
const db = new axDB('memory')

// Inserisci nel vector db
await this.db.upsert({
  id: 'abc',
  table: 'products',
  values: ret.embeddings[0],
})

// Interroga per elementi simili usando embeddings
const matches = await this.db.query({
  table: 'products',
  values: embeddings[0],
})
```

In alternativa puoi usare `AxDBManager` che gestisce smart chunking, embedding e query tutto per te, rendendo il processo semplicissimo.

```typescript
const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query(
  'John von Neumann on human intelligence and singularity.'
)
console.log(matches)
```

## Documenti RAG

Utilizzare documenti come PDF, DOCX, PPT, XLS, ecc. con i LLM è molto complesso. Lo rendiamo facile con Apache Tika, un motore open-source di processamento documentale.

Avvia Apache Tika

```shell
docker run -p 9998:9998 apache/tika
```

Converti documenti in testo e inseriscili per retrieval usando `AxDBManager`, che supporta anche reranker e query rewriter. Sono disponibili due implementazioni predefinite: `AxDefaultResultReranker` e `AxDefaultQueryRewriter`.

```typescript
const tika = new AxApacheTika()
const text = await tika.convert('/path/to/document.pdf')

const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query('Find some text')
console.log(matches)
```

## DSPy Multi-modale

Quando si usano modelli come `GPT-4o` e `Gemini` che supportano prompt multi-modali, supportiamo l’uso di campi immagine, e funziona con l’intera pipeline DSP.

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

Quando si usano modelli come `gpt-4o-audio-preview` che supportano prompt multi-modali con audio, supportiamo l’uso di campi audio, e funziona con l’intera pipeline DSP.

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

Ispirato al demonstration weaving di DSPy, Ax offre `AxMessage` per una gestione fluida della cronologia conversazionale. Questo ti permette di costruire chatbot e agenti conversazionali che mantengono il contesto su più turni sfruttando tutta la potenza delle signature dei prompt. Vedi l’esempio per maggiori dettagli.

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

La cronologia della conversazione viene automaticamente intrecciata nel prompt, permettendo al modello di mantenere il contesto e fornire risposte coerenti. Questo funziona con tutte le funzionalità di Ax, incluso streaming, function calling e chain-of-thought reasoning.

## Streaming

### Assert

Supportiamo il parsing dei campi di output e l’esecuzione di funzioni durante lo streaming. Questo consente fail-fast e correzione degli errori senza aspettare tutto l’output, risparmiando token e costi e riducendo la latenza. Gli assert sono un modo potente per garantire che l’output soddisfi i tuoi requisiti; funzionano anche in streaming.

```typescript
// setup del programma prompt
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

// aggiungi un assert per assicurarti che il numero 5 non sia in un campo di output
gen.addAssert(({ next10Numbers }: Readonly<{ next10Numbers: number[] }>) => {
  return next10Numbers ? !next10Numbers.includes(5) : undefined
}, 'Numbers 5 is not allowed')

// esegui il programma con streaming abilitato
const res = await gen.forward({ startNumber: 1 }, { stream: true })

// oppure esegui il programma con streaming end-to-end
const generator = await gen.streamingForward(
  { startNumber: 1 },
  {
    stream: true,
  }
)
for await (const res of generator) {
}
```

L’esempio sopra permette di validare interi campi di output mentre vengono trasmessi. Questa validazione funziona sia con che senza streaming e viene attivata quando l’intero valore del campo è disponibile. Per una vera validazione durante lo streaming, vedi l’esempio sotto. Questo migliorerà notevolmente le prestazioni e farà risparmiare token in produzione.

```typescript
// aggiungi un assert per assicurarti che tutte le righe inizino con un numero e un punto.
gen.addStreamingAssert(
  'answerInPoints',
  (value: string) => {
    const re = /^\d+\./

    // suddividi il valore per righe, rimuovi spazi, filtra righe vuote e verifica che tutte rispettino la regex
    return value
      .split('\n')
      .map((x) => x.trim())
      .filter((x) => x.length > 0)
      .every((x) => re.test(x))
  },
  'Lines must start with a number and a dot. Eg: 1. This is a line.'
)

// esegui il programma con streaming abilitato
const res = await gen.forward(
  {
    question: 'Provide a list of optimizations to speedup LLM inference.',
  },
  { stream: true, debug: true }
)
```

### Field Processor

I field processor sono un modo potente per processare i campi in un prompt. Sono utilizzati per processare i campi di un prompt prima che venga inviato al LLM.

```typescript
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

const streamValue = false

const processorFunction = (value) => {
  return value.map((x) => x + 1)
}

// Aggiungi un field processor al programma
const processor = new AxFieldProcessor(
  gen,
  'next10Numbers',
  processorFunction,
  streamValue
)

const res = await gen.forward({ startNumber: 1 })
```

## Model Context Protocol (MCP)

Ax fornisce integrazione senza soluzione di continuità con il Model Context Protocol (MCP), permettendo ai tuoi agenti di accedere a tool e risorse esterne tramite un’interfaccia standardizzata.

### Utilizzare AxMCPClient

`AxMCPClient` ti permette di connetterti a qualsiasi server compatibile MCP e usare le sue capacità all’interno dei tuoi agenti Ax:

```typescript
import { AxMCPClient, AxMCPStdioTransport } from '@ax-llm/ax'

// Inizializza un client MCP con un transport
const transport = new AxMCPStdioTransport({
  command: 'npx',
  args: ['-y', '@modelcontextprotocol/server-memory'],
})

// Crea il client con modalità debug opzionale
const client = new AxMCPClient(transport, { debug: true })

// Inizializza la connessione
await client.init()

// Usa le funzioni del client in un agente
const memoryAgent = new AxAgent({
  name: 'MemoryAssistant',
  description: 'An assistant with persistent memory',
  signature: 'input, userId -> response',
  functions: [client], // Passa il client come provider di funzioni
})

// Oppure usa il client con AxGen
const memoryGen = new AxGen('input, userId -> response', {
  functions: [client],
})
```

### Usare AxMCPClient con un server remoto

Chiamare un server MCP remoto con Ax è semplice. Ad esempio, così puoi usare il server DeepWiki MCP per porre domande su quasi qualsiasi repository pubblico GitHub. Il server DeepWiki MCP è disponibile su `https://mcp.deepwiki.com/mcp`.

```typescript
import {
  AxAgent,
  AxAI,
  AxAIOpenAIModel,
  AxMCPClient,
  AxMCPStreambleHTTPTransport,
} from '@ax-llm/ax'

// 1. Inizializza il transport MCP verso il server DeepWiki
const transport = new AxMCPStreambleHTTPTransport(
  'https://mcp.deepwiki.com/mcp'
)

// 2. Crea il client MCP
const mcpClient = new AxMCPClient(transport, { debug: false })
await mcpClient.init() // Inizializza la connessione

// 3. Inizializza il tuo modello AI (es: OpenAI)
// Assicurati che la variabile d’ambiente OPENAI_APIKEY sia impostata
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY as string,
})

// 4. Crea un AxAgent che usa il client MCP
const deepwikiAgent = new AxAgent<
  {
    // Definisci i tipi di input per chiarezza, in linea con una funzione DeepWiki
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
  functions: [mcpClient], // Fornisci il client MCP all’agente
})

// 5. Formula una domanda e chiama l’agente
const result = await deepwikiAgent.forward(ai, {
  questionAboutRepo: 'What is the main purpose of this library?',
  githubRepositoryUrl: 'https://github.com/dosco/ax', // Esempio: la libreria Ax stessa
})
console.log('DeepWiki Answer:', result.answer)
```

Questo esempio mostra come connettersi a un server MCP pubblico e usarlo all’interno di un agente Ax. La signature dell’agente (`questionAboutRepo, githubRepositoryUrl -> answer`) è un’ipotesi su come si potrebbe interagire con il servizio DeepWiki; normalmente scopriresti le funzioni disponibili e le loro signature dal server MCP stesso (ad esempio tramite una chiamata `mcp.getFunctions` se supportata, o dalla documentazione).

Per un esempio più complesso che coinvolge autenticazione e header personalizzati con un server MCP remoto, consulta il file `src/examples/mcp-client-pipedream.ts` in questo repository.

## AI Routing e Load Balancing

Ax offre due potenti modi per lavorare con più servizi AI: un load balancer per alta disponibilità e un router per routing specifico per modello.

### Load Balancer

Il load balancer distribuisce automaticamente le richieste tra più servizi AI in base a prestazioni e disponibilità. Se un servizio fallisce, passa automaticamente al successivo disponibile.

```typescript
import { AxAI, AxBalancer } from '@ax-llm/ax'

// Imposta più servizi AI
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

// Crea un load balancer con tutti i servizi
const balancer = new AxBalancer([openai, ollama, gemini])

// Usalo come un normale servizio AI - usa automaticamente il servizio migliore
const response = await balancer.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
})

// Oppure usa il balancer con AxGen
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(balancer, { question: 'Hello!' })
```

### Multi-Service Router

Il router ti consente di usare più servizi AI attraverso un’unica interfaccia, instradando automaticamente le richieste al servizio giusto in base al modello specificato.

```typescript
import { AxAI, AxAIOpenAIModel, AxMultiServiceRouter } from '@ax-llm/ax'

// Configura OpenAI con lista di modelli
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

// Configura Gemini con lista di modelli
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

// Crea un router con tutti i servizi
const router = new AxMultiServiceRouter([openai, gemini, secretService])

// Instrada verso il modello expert di OpenAI
const openaiResponse = await router.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
  model: 'expert',
})

// Oppure usa il router con AxGen
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(router, { question: 'Hello!' })
```

Il load balancer è ideale per alta disponibilità, mentre il router è perfetto quando hai bisogno di modelli specifici per compiti specifici. Entrambi possono essere usati con tutte le funzionalità di Ax come streaming, function calling e chain-of-thought prompting.

Puoi anche usare balancer e router insieme: più balancer possono essere usati col router o viceversa.

## Supporto OpenTelemetry

La capacità di tracciare e osservare il tuo workflow LLM è fondamentale per costruire workflow di produzione. OpenTelemetry è uno standard di settore, e supportiamo il nuovo namespace di attributi `gen_ai`. Consulta `src/examples/telemetry.ts` per maggiori informazioni.

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

## Ottimizzare i prompt (Base)

Puoi ottimizzare i tuoi prompt usando un modello più grande per renderli più efficienti e ottenere risultati migliori. Questo si fa usando un optimizer come `AxBootstrapFewShot` con esempi dal popolare dataset `HotPotQA`. L’optimizer genera delle dimostrazioni (`demos`) che, usate con il prompt, ne migliorano l’efficienza.

```typescript
// Scarica il dataset HotPotQA da huggingface
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

// Imposta il programma da ottimizzare
const program = new AxChainOfThought<{ question: string }, { answer: string }>(
  ai,
  `question -> answer "in short 2 or 3 words"`
)

// Imposta un optimizer Bootstrap Few Shot per ottimizzare il programma sopra
const optimize = new AxBootstrapFewShot<
  { question: string },
  { answer: string }
>({
  program,
  examples,
})

// Imposta una metrica di valutazione em, f1 score è un modo popolare di misurare la performance di retrieval.
const metricFn: AxMetricFn = ({ prediction, example }) =>
  emScore(prediction.answer as string, example.answer as string)

// Esegui l’optimizer e ricordati di salvare il risultato per uso futuro
const result = await optimize.compile(metricFn);

// Salva i demos generati su file
// import fs from 'fs'; // Assicurati di importare fs nello script reale
fs.writeFileSync('bootstrap-demos.json', JSON.stringify(result.demos, null, 2));
console.log('Demos saved to bootstrap-demos.json');
```

<img width="853" alt="tune-prompt" src="https://github.com/dosco/llm-client/assets/832235/f924baa7-8922-424c-9c2c-f8b2018d8d74">
```

## Ottimizzare i prompt (Avanzato, Mipro v2)

MiPRO v2 è un framework avanzato di ottimizzazione dei prompt che usa l’ottimizzazione bayesiana per trovare automaticamente le migliori istruzioni, dimostrazioni ed esempi per i tuoi programmi LLM. Esplorando sistematicamente diverse configurazioni di prompt, MiPRO v2 aiuta a massimizzare le performance del modello senza tuning manuale.

### Caratteristiche principali

- **Ottimizzazione delle istruzioni**: genera e testa automaticamente molteplici candidati di istruzioni
- **Selezione di esempi few-shot**: trova le dimostrazioni ottimali dal tuo dataset
- **Ottimizzazione bayesiana intelligente**: usa la strategia UCB (Upper Confidence Bound) per esplorare efficientemente le configurazioni
- **Early stopping**: interrompe l’ottimizzazione quando i miglioramenti si stabilizzano, risparmiando risorse
- **Consapevole di programma e dati**: considera la struttura del programma e le caratteristiche del dataset

### Come funziona

1. Genera diversi candidati di istruzioni
2. Bootstrap di esempi few-shot dai tuoi dati
3. Seleziona esempi etichettati direttamente dal dataset
4. Usa l’ottimizzazione bayesiana per trovare la combinazione ottimale
5. Applica la miglior configurazione al tuo programma

### Uso base

```typescript
import { AxAI, AxChainOfThought, AxMiPRO } from '@ax-llm/ax'

// 1. Imposta il tuo servizio AI
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY,
})

// 2. Crea il tuo programma
const program = new AxChainOfThought(`input -> output`)

// 3. Configura l’optimizer
const optimizer = new AxMiPRO({
  ai,
  program,
  examples: trainingData, // I tuoi esempi di training
  options: {
    numTrials: 20, // Numero di configurazioni da provare
    auto: 'medium', // Livello di ottimizzazione
  },
})

// 4. Definisci la metrica di valutazione
const metricFn = ({ prediction, example }) => {
  return prediction.output === example.output
}

// 5. Esegui l’ottimizzazione
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData, // Set di validazione opzionale
})

// 6. Usa il programma ottimizzato
const result = await optimizedProgram.forward(ai, { input: 'test input' })
```

### Opzioni di configurazione

MiPRO v2 offre opzioni di configurazione estese:

| Opzione                  | Descrizione                                      | Default |
| ------------------------ | ------------------------------------------------ | ------- |
| `numCandidates`          | Numero di istruzioni candidate da generare       | 5       |
| `numTrials`              | Numero di tentativi di ottimizzazione            | 30      |
| `maxBootstrappedDemos`   | Numero massimo di dimostrazioni bootstrappate    | 3       |
| `maxLabeledDemos`        | Numero massimo di esempi etichettati             | 4       |
| `minibatch`              | Usa minibatch per valutazione più veloce         | true    |
| `minibatchSize`          | Dimensione dei minibatch di valutazione          | 25      |
| `earlyStoppingTrials`    | Stop se nessun miglioramento dopo N tentativi    | 5       |
| `minImprovementThreshold`| Soglia minima di miglioramento                   | 0.01    |
| `programAwareProposer`   | Usa la struttura del programma per proposte      | true    |
| `dataAwareProposer`      | Considera le caratteristiche del dataset         | true    |
| `verbose`                | Mostra avanzamento dettagliato                   | false   |
| abort-patterns.ts | Esempio su come abortire richieste |

### Livelli di ottimizzazione

Puoi configurare rapidamente l’intensità dell’ottimizzazione con il parametro `auto`:

```typescript
// Ottimizzazione leggera (più veloce, meno approfondita)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'light' })

// Ottimizzazione media (bilanciata)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'medium' })

// Ottimizzazione pesante (più lenta, più approfondita)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'heavy' })
```

### Esempio avanzato: Sentiment Analysis

```typescript
// Crea il programma di sentiment analysis
const classifyProgram = new AxChainOfThought<
  { productReview: string },
  { label: string }
>(`productReview -> label:string "positive" or "negative"`)

// Configura l’optimizer con impostazioni avanzate
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

// Esegui l’ottimizzazione e salva il risultato
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData,
})

// Salva la configurazione per uso futuro
const programConfig = JSON.stringify(optimizedProgram, null, 2);
await fs.promises.writeFile("./optimized-config.json", programConfig);
console.log('> Done. Optimized program config saved to optimized-config.json');
```

## Usare i prompt ottimizzati

Sia l’optimizer Bootstrap Few Shot che il più avanzato MiPRO v2 generano **demos** (dimostrazioni) che migliorano significativamente le performance del tuo programma. Questi demos sono esempi che mostrano al LLM come gestire correttamente task simili.

### Cosa sono i Demos?

I demos sono esempi input-output che vengono automaticamente inclusi nei tuoi prompt per guidare il LLM. Agiscono come esempi few-shot, mostrando al modello il comportamento atteso per il tuo task specifico.

### Caricamento e uso dei Demos

Che tu abbia usato Bootstrap Few Shot o MiPRO v2, il processo di utilizzo dei demos generati è lo stesso:

```typescript
import fs from 'fs'
import { AxAI, AxGen, AxChainOfThought } from '@ax-llm/ax'

// 1. Imposta il servizio AI
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
})

// 2. Crea il programma (stessa signature usata durante l’ottimizzazione)
const program = new AxChainOfThought(`question -> answer "in short 2 or 3 words"`)

// 3. Carica i demos dal file salvato
const demos = JSON.parse(fs.readFileSync('bootstrap-demos.json', 'utf8'))

// 4. Applica i demos al programma
program.setDemos(demos)

// 5. Usa il programma potenziato
const result = await program.forward(ai, {
  question: 'What castle did David Gregory inherit?'
})

console.log(result) // Ora funziona meglio con gli esempi appresi
```

### Esempio semplice: Classificazione Testo

Ecco un esempio completo che mostra come i demos migliorano un task di classificazione:

```typescript
// Crea un programma di classificazione
const classifier = new AxGen(`text -> category:class "positive, negative, neutral"`)

// Carica i demos generati da Bootstrap o MiPRO tuning
const savedDemos = JSON.parse(fs.readFileSync('classification-demos.json', 'utf8'))
classifier.setDemos(savedDemos)

// Ora il classificatore ha imparato dagli esempi e funziona meglio
const result = await classifier.forward(ai, {
  text: "This product exceeded my expectations!"
})

console.log(result.category) // Classificazione più accurata
```

### Vantaggi principali dell’uso dei Demos

- **Migliore accuratezza**: i programmi funzionano molto meglio con esempi rilevanti
- **Output coerente**: i demos aiutano a mantenere formati di risposta coerenti
- **Meno allucinazioni**: gli esempi guidano il modello verso comportamenti attesi
- **Costi ridotti**: risultati migliori senza bisogno di modelli più grandi/costosi

### Best Practice

1. **Salva i tuoi demos**: salva sempre i demos generati per riutilizzarli
2. **Signature coerente**: usa la stessa signature quando carichi i demos
3. **Versiona i file**: tieni i file demos sotto version control per riproducibilità
4. **Aggiorna regolarmente**: riottimizza periodicamente con dati nuovi per migliorare i demos

Sia Bootstrap Few Shot che MiPRO v2 generano demos nello stesso formato, quindi puoi usare lo stesso schema di caricamento a prescindere dall’optimizer.

## Funzioni integrate

| Funzione            | Nome                | Descrizione                                   |
| ------------------- | ------------------- | --------------------------------------------- |
| Interprete JS       | AxJSInterpreter     | Esegue codice JS in ambiente sandbox          |
| Docker Sandbox      | AxDockerSession     | Esegue comandi in un ambiente docker          |
| Embeddings Adapter  | AxEmbeddingAdapter  | Ottieni e passa embedding alla tua funzione   |

## Guarda tutti gli esempi

Usa il comando `tsx` per eseguire gli esempi. Fa sì che node esegua codice typescript. Supporta anche l’uso di un file `.env` per passare le API Key AI invece di metterle in linea di comando.

```shell
OPENAI_APIKEY=api-key npm run tsx ./src/examples/marketing.ts
```

| Esempio                 | Descrizione                                             |
| ----------------------- | ------------------------------------------------------- |
| customer-support.ts     | Estrai dettagli preziosi dalle comunicazioni clienti    |
| function.ts             | Esempio semplice di chiamata funzione singola           |
| food-search.ts          | Esempio multi-step, multi-funzione                      |
| marketing.ts            | Genera brevi messaggi sms di marketing efficaci         |
| vectordb.ts             | Chunk, embed e ricerca testo                            |
| fibonacci.ts            | Usa l’interprete JS per calcolare la serie di Fibonacci |
| summarize.ts            | Genera un breve riassunto di un testo lungo             |
| chain-of-thought.ts     | Usa chain-of-thought prompting per rispondere           |
| rag.ts                  | Retrieval multi-hop per rispondere a domande            |
| rag-docs.ts             | Converti PDF in testo e embeddalo per ricerca rag       |
| react.ts                | Usa chiamata funzioni e ragionamento per rispondere     |
| agent.ts                | Framework agenti, possono usare altri agenti e tool     |
| streaming1.ts           | Validazione campi output durante lo streaming           |
| streaming2.ts           | Validazione per campo output durante streaming          |
| streaming3.ts           | Streaming end-to-end esempio `streamingForward()`       |
| smart-hone.ts           | Agente cerca il cane in una smart home                  |
| multi-modal.ts          | Usa un input immagine con altri input testuali          |
| balancer.ts             | Bilancia tra vari llm in base a costi, ecc              |
| docker.ts               | Usa la sandbox docker per trovare file per descrizione  |
| prime.ts                | Usa field processor per processare campi in un prompt   |
| simple-classify.ts      | Classificatore semplice                                 |
| mcp-client-memory.ts    | Esempio di uso MCP server per memoria con Ax            |
| mcp-client-blender.ts   | Esempio di uso MCP server per Blender con Ax            |
| mcp-client-pipedream.ts | Esempio di integrazione MCP remoto                      |
| tune-bootstrap.ts       | Usa bootstrap optimizer per migliorare l’efficacia      |
| tune-mipro.ts           | Usa optimizer mipro v2 per migliorare prompt            |
| tune-usage.ts           | Usa i prompt ottimizzati                                |
| telemetry.ts            | Traccia e invia trace a un servizio Jaeger              |
| openai-responses.ts     | Esempio uso OpenAI Responses API                        |
| use-examples.ts         | Esempio di uso di 'examples' per guidare il llm         |

## Il nostro obiettivo

I Large Language Model (LLM) stanno diventando molto potenti e hanno raggiunto un punto in cui possono essere il backend dell’intero prodotto. Tuttavia, resta molta complessità da gestire: prompt corretti, modelli, streaming, function call, correzione errori e molto altro. Il nostro obiettivo è incapsulare tutta questa complessità in una libreria ben mantenuta, facile da usare e compatibile con tutti i migliori LLM. Inoltre, usiamo la ricerca più avanzata per aggiungere nuove capacità come DSPy alla libreria.

## Come usare questa libreria?

### 1. Scegli un AI con cui lavorare

```ts
// Scegli un LLM
const ai = new AxOpenAI({ apiKey: process.env.OPENAI_APIKEY } as AxOpenAIArgs)
```

### 2. Crea una prompt signature secondo il tuo caso d’uso

```ts
// La signature definisce input e output del tuo programma prompt
const cot = new ChainOfThought(ai, `question:string -> answer:string`, { mem })
```

### 3. Esegui il nuovo programma prompt

```ts
// Passa i campi input definiti nella signature sopra
const res = await cot.forward({ question: 'Are we in a simulation?' })
```

### 4. Oppure se vuoi usare direttamente il LLM

```ts
const res = await ai.chat([
  { role: "system", content: "Help the customer with his questions" }
  { role: "user", content: "I'm looking for a Macbook Pro M2 With 96GB RAM?" }
]);
```

## Come si usa la function calling

### 1. Definisci le funzioni

```ts
// definisci una o più funzioni e un gestore di funzioni
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

### 2. Passa le funzioni a un prompt

```ts
const cot = new AxGen(ai, `question:string -> answer:string`, { functions })
```

## Abilita log di debug

```ts
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
} as AxOpenAIArgs)
ai.setOptions({ debug: true })
```

## Contattaci

Siamo felici di aiutare, contattaci se hai domande o unisciti al Discord  
[twitter/dosco](https://twitter.com/dosco)

## FAQ

### 1. Il LLM non trova la funzione corretta da usare

Migliora il nome e la descrizione della funzione. Sii molto chiaro su cosa fa la funzione. Assicurati che i parametri abbiano buone descrizioni. Le descrizioni possono essere brevi ma devono essere precise.

### 2. Come cambio la configurazione del LLM che sto usando?

Puoi passare un oggetto di configurazione come secondo parametro quando crei un nuovo oggetto LLM.

```ts
const apiKey = process.env.OPENAI_APIKEY
const conf = AxOpenAIBestConfig()
const ai = new AxOpenAI({ apiKey, conf } as AxOpenAIArgs)
```

## 3. Il mio prompt è troppo lungo / posso cambiare i max tokens?

```ts
const conf = axOpenAIDefaultConfig() // o OpenAIBestOptions()
conf.maxTokens = 2000
```

## 4. Come cambio il modello? (es: voglio usare GPT4)

```ts
const conf = axOpenAIDefaultConfig() // o OpenAIBestOptions()
conf.model = OpenAIModel.GPT4Turbo
```

## Suggerimenti per Monorepo

È essenziale ricordare che bisogna eseguire `npm install` solo dalla directory root. Questo evita la creazione di file `package-lock.json` annidati e previene node_modules non deduplicati.

Aggiungere nuove dipendenze nei pacchetti deve essere fatto con ad esempio  
`npm install lodash --workspace=ax` (o semplicemente modifica il `package.json` appropriato ed esegui `npm install` da root).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---