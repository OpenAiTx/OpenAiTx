# Ax, DSPy para Typescript

Trabalhar com LLMs é complexo — eles nem sempre fazem o que você deseja. O DSPy facilita a construção de soluções incríveis com LLMs. Basta definir suas entradas e saídas (assinatura) e um prompt eficiente é gerado automaticamente e utilizado. Conecte várias assinaturas para construir sistemas e fluxos de trabalho complexos usando LLMs.

E para te ajudar realmente a usar isso em produção, temos tudo o que você precisa, como observabilidade, streaming, suporte a outras modalidades (imagens, áudio, etc.), correção de erros, chamadas de função multi-etapas, MCP, RAG, etc.

[![NPM Package](https://img.shields.io/npm/v/@ax-llm/ax?style=for-the-badge&color=green)](https://www.npmjs.com/package/@ax-llm/ax)
[![Discord Chat](https://dcbadge.vercel.app/api/server/DSHg3dU7dW?style=for-the-badge)](https://discord.gg/DSHg3dU7dW)
[![Twitter](https://img.shields.io/twitter/follow/dosco?style=for-the-badge&color=red)](https://twitter.com/dosco)

<!-- header -->

## Por que usar Ax?

- Interface padrão para todos os principais LLMs
- Prompts compilados a partir de assinaturas simples
- Streaming nativo de ponta a ponta
- Suporte para orçamento de pensamento e tokens de raciocínio
- Construa agentes que podem chamar outros agentes
- Suporte nativo ao MCP, Model Context Protocol
- Converta documentos de qualquer formato para texto
- RAG, chunking inteligente, embedding, consulta
- Funciona com Vercel AI SDK
- Validação de saída durante o streaming
- DSPy multimodal suportado
- Ajuste automático de prompts usando otimizadores
- Rastreamento / observabilidade OpenTelemetry
- Código Typescript pronto para produção
- Leve, sem dependências

## Pronto para Produção

- Sem mudanças incompatíveis (versões menores)
- Grande cobertura de testes
- Suporte nativo Open Telemetry `gen_ai`
- Amplamente usado por startups em produção

## O que é uma assinatura de prompt?

<img width="860" alt="shapes at 24-03-31 00 05 55" src="https://raw.githubusercontent.com/ax-llm/ax/main/githubusercontent.com/dosco/llm-client/assets/832235/0f0306ea-1812-4a0a-9ed5-76cd908cd26b">

Prompts eficientes e type-safe são gerados automaticamente a partir de uma assinatura simples. Uma assinatura de prompt é composta por uma
`"descrição da tarefa" campoEntrada:tipo "descrição do campo" -> campoSaída:tipo`.
A ideia por trás das assinaturas de prompt é baseada no trabalho feito no artigo
"Demonstrate-Search-Predict".

Você pode ter vários campos de entrada e saída, e cada campo pode ser dos tipos `string`, `number`, `boolean`, `date`, `datetime`,
`class "class1, class2"`, `JSON`, ou um array de qualquer um destes, por exemplo, `string[]`.
Quando um tipo não é definido, o padrão é `string`. O sufixo `?` torna o campo opcional (obrigatório por padrão) e `!` torna o campo interno, útil para coisas como raciocínio.

## Tipos de Campo de Saída

| Tipo                     | Descrição                             | Uso                        | Exemplo de Saída                                     |
| ------------------------ | ------------------------------------- | -------------------------- | ---------------------------------------------------- |
| `string`                 | Uma sequência de caracteres.          | `fullName:string`          | `"exemplo"`                                          |
| `number`                 | Um valor numérico.                    | `price:number`             | `42`                                                 |
| `boolean`                | Um valor verdadeiro ou falso.         | `isEvent:boolean`          | `true`, `false`                                      |
| `date`                   | Um valor de data.                     | `startDate:date`           | `"2023-10-01"`                                       |
| `datetime`               | Valor de data e hora.                 | `createdAt:datetime`       | `"2023-10-01T12:00:00Z"`                             |
| `class "class1,class2"`  | Classificação de itens.               | `category:class`           | `["class1", "class2", "class3"]`                     |
| `string[]`               | Array de strings.                     | `tags:string[]`            | `["exemplo1", "exemplo2"]`                           |
| `number[]`               | Array de números.                     | `scores:number[]`          | `[1, 2, 3]`                                          |
| `boolean[]`              | Array de valores booleanos.           | `permissions:boolean[]`    | `[true, false, true]`                                |
| `date[]`                 | Array de datas.                       | `holidayDates:date[]`      | `["2023-10-01", "2023-10-02"]`                       |
| `datetime[]`             | Array de datas e horários.            | `logTimestamps:datetime[]` | `["2023-10-01T12:00:00Z", "2023-10-02T12:00:00Z"]`   |
| `class[] "class1,class2"`| Várias classes                        | `categories:class[]`       | `["class1", "class2", "class3"]`                     |
| `code "language"`        | Bloco de código em linguagem específica| `code:code "python"`      | `print('Hello, world!')`                             |

## LLMs Suportados

`Google Gemini`, `OpenAI`, `Azure OpenAI`, `Anthropic`, `X Grok`, `TogetherAI`, `Cohere`, `Mistral`, `Groq`, `DeepSeek`, `Ollama`, `Reka`,
`Hugging Face`

## Instalação

```bash
npm install @ax-llm/ax
# ou
yarn add @ax-llm/ax
```

## Exemplo: Usando chain-of-thought para resumir texto

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

## Exemplo: Construindo um agente

Use o prompt de agente (framework) para construir agentes que trabalham com outros agentes para completar tarefas. Agentes são fáceis de criar com assinaturas de prompt. Experimente o exemplo de agente.

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

## Suporte a Modelos de Pensamento

Ax oferece suporte nativo para modelos com capacidades de pensamento, permitindo controlar o orçamento de tokens de pensamento e acessar o raciocínio do modelo. Esse recurso ajuda a entender o processo de raciocínio do modelo e otimizar o uso de tokens.

```typescript
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY as string,
  config: {
    model: AxAIGoogleGeminiModel.Gemini25Flash,
    thinking: { includeThoughts: true },
  },
})

// Ou controle o orçamento de pensamento por requisição
const gen = new AxChainOfThought(`question -> answer`)
const res = await gen.forward(
  ai,
  { question: 'What is quantum entanglement?' },
  { thinkingTokenBudget: 'medium' } // 'minimal', 'low', 'medium' ou 'high'
)

// Acesse pensamentos na resposta
console.log(res.thoughts) // Mostra o processo de raciocínio do modelo
```

## Bancos de Dados Vetoriais Suportados

Bancos de dados vetoriais são essenciais para construir fluxos de trabalho com LLM. Temos abstrações limpas sobre bancos de dados vetoriais populares e nosso próprio banco de dados vetorial em memória.

| Provedor    | Testado |
| ----------- | ------- |
| Em Memória  | 🟢 100% |
| Weaviate    | 🟢 100% |
| Cloudflare  | 🟡 50%  |
| Pinecone    | 🟡 50%  |

```typescript
// Crie embeddings de texto usando um LLM
const ret = await this.ai.embed({ texts: 'hello world' })

// Crie um banco vetorial em memória
const db = new axDB('memory')

// Insira no banco vetorial
await this.db.upsert({
  id: 'abc',
  table: 'products',
  values: ret.embeddings[0],
})

// Consulte por entradas similares usando embeddings
const matches = await this.db.query({
  table: 'products',
  values: embeddings[0],
})
```

Alternativamente, você pode usar o `AxDBManager` que gerencia chunking, embedding e consultas automaticamente, facilitando tudo.

```typescript
const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query(
  'John von Neumann on human intelligence and singularity.'
)
console.log(matches)
```

## Documentos RAG

Usar documentos como PDF, DOCX, PPT, XLS, etc., com LLMs é complicado. Facilitamos isso com o Apache Tika, um mecanismo open-source de processamento de documentos.

Inicie o Apache Tika

```shell
docker run -p 9998:9998 apache/tika
```

Converta documentos para texto e faça o embedding para recuperação usando o `AxDBManager`, que também suporta reranker e rewriter de consulta. Duas implementações padrão, `AxDefaultResultReranker` e `AxDefaultQueryRewriter`, estão disponíveis.

```typescript
const tika = new AxApacheTika()
const text = await tika.convert('/path/to/document.pdf')

const manager = new AxDBManager({ ai, db })
await manager.insert(text)

const matches = await manager.query('Find some text')
console.log(matches)
```

## DSPy Multimodal

Ao usar modelos como `GPT-4o` e `Gemini` que suportam prompts multimodais, é possível usar campos de imagem, funcionando com todo o pipeline DSP.

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

Ao usar modelos como `gpt-4o-audio-preview` que suportam prompts multimodais com áudio, também é possível usar campos de áudio, funcionando em todo o pipeline DSP.

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

## API de Chat DSPy

Inspirado pelo demonstration weaving do DSPy, Ax fornece o `AxMessage` para gerenciamento de histórico de conversas. Isso permite criar chatbots e agentes conversacionais que mantêm contexto em múltiplas interações, aproveitando todo o poder das assinaturas de prompt. Veja o exemplo para mais detalhes.

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

O histórico da conversa é automaticamente incorporado ao prompt, permitindo que o modelo mantenha o contexto e forneça respostas coerentes. Isso funciona perfeitamente com todos os recursos do Ax, incluindo streaming, chamadas de função e chain-of-thought.

## Streaming

### Asserções

Suportamos parsing de campos de saída e execução de funções durante o streaming. Isso permite falhas rápidas e correção de erros sem esperar pela saída completa, economizando tokens e reduzindo latência. Asserções são uma forma poderosa de garantir que a saída atenda seus requisitos; elas também funcionam com streaming.

```typescript
// configurar o programa de prompt
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

// adicionar uma asserção para garantir que o número 5 não está em um campo de saída
gen.addAssert(({ next10Numbers }: Readonly<{ next10Numbers: number[] }>) => {
  return next10Numbers ? !next10Numbers.includes(5) : undefined
}, 'Numbers 5 is not allowed')

// executar o programa com streaming habilitado
const res = await gen.forward({ startNumber: 1 }, { stream: true })

// ou execute o programa com streaming end-to-end
const generator = await gen.streamingForward(
  { startNumber: 1 },
  {
    stream: true,
  }
)
for await (const res of generator) {
}
```

O exemplo acima permite validar campos inteiros de saída à medida que são transmitidos. Essa validação funciona tanto com streaming quanto sem, e é acionada quando o valor do campo inteiro está disponível. Para validação real durante o streaming, veja o exemplo abaixo. Isso melhora muito o desempenho e economiza tokens em escala de produção.

```typescript
// adicionar uma asserção para garantir que todas as linhas começam com um número e um ponto
gen.addStreamingAssert(
  'answerInPoints',
  (value: string) => {
    const re = /^\d+\./

    // divide o valor em linhas, remove espaços, filtra linhas vazias e verifica se todas começam com o regex
    return value
      .split('\n')
      .map((x) => x.trim())
      .filter((x) => x.length > 0)
      .every((x) => re.test(x))
  },
  'Lines must start with a number and a dot. Eg: 1. This is a line.'
)

// execute o programa com streaming habilitado
const res = await gen.forward(
  {
    question: 'Provide a list of optimizations to speedup LLM inference.',
  },
  { stream: true, debug: true }
)
```

### Processadores de Campo

Processadores de campo são uma forma poderosa de processar campos em um prompt antes de enviá-lo ao LLM.

```typescript
const gen = new AxChainOfThought(
  ai,
  `startNumber:number -> next10Numbers:number[]`
)

const streamValue = false

const processorFunction = (value) => {
  return value.map((x) => x + 1)
}

// Adicione um processador de campo ao programa
const processor = new AxFieldProcessor(
  gen,
  'next10Numbers',
  processorFunction,
  streamValue
)

const res = await gen.forward({ startNumber: 1 })
```

## Model Context Protocol (MCP)

Ax oferece integração perfeita com o Model Context Protocol (MCP), permitindo que seus agentes acessem ferramentas externas e recursos através de uma interface padronizada.

### Usando AxMCPClient

O `AxMCPClient` permite conectar-se a qualquer servidor compatível com MCP e usar suas capacidades dentro dos agentes Ax:

```typescript
import { AxMCPClient, AxMCPStdioTransport } from '@ax-llm/ax'

// Inicialize um cliente MCP com um transporte
const transport = new AxMCPStdioTransport({
  command: 'npx',
  args: ['-y', '@modelcontextprotocol/server-memory'],
})

// Crie o cliente com modo debug opcional
const client = new AxMCPClient(transport, { debug: true })

// Inicialize a conexão
await client.init()

// Use as funções do cliente em um agente
const memoryAgent = new AxAgent({
  name: 'MemoryAssistant',
  description: 'An assistant with persistent memory',
  signature: 'input, userId -> response',
  functions: [client], // Passe o cliente como provedor de função
})

// Ou use o cliente com AxGen
const memoryGen = new AxGen('input, userId -> response', {
  functions: [client],
})
```

### Usando AxMCPClient com um Servidor Remoto

Chamar um servidor MCP remoto com Ax é simples. Por exemplo, veja como usar o servidor DeepWiki MCP para perguntar sobre qualquer repositório público do GitHub. O servidor DeepWiki MCP está disponível em `https://mcp.deepwiki.com/mcp`.

```typescript
import {
  AxAgent,
  AxAI,
  AxAIOpenAIModel,
  AxMCPClient,
  AxMCPStreambleHTTPTransport,
} from '@ax-llm/ax'

// 1. Inicialize o transporte MCP para o servidor DeepWiki
const transport = new AxMCPStreambleHTTPTransport(
  'https://mcp.deepwiki.com/mcp'
)

// 2. Crie o cliente MCP
const mcpClient = new AxMCPClient(transport, { debug: false })
await mcpClient.init() // Inicialize a conexão

// 3. Inicialize seu modelo AI (ex: OpenAI)
// Garanta que a variável de ambiente OPENAI_APIKEY esteja definida
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY as string,
})

// 4. Crie um AxAgent que usa o cliente MCP
const deepwikiAgent = new AxAgent<
  {
    // Defina tipos de entrada para clareza, combinando com uma função possível do DeepWiki
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
  functions: [mcpClient], // Forneça o cliente MCP ao agente
})

// 5. Formule uma pergunta e chame o agente
const result = await deepwikiAgent.forward(ai, {
  questionAboutRepo: 'What is the main purpose of this library?',
  githubRepositoryUrl: 'https://github.com/dosco/ax', // Exemplo: biblioteca Ax
})
console.log('DeepWiki Answer:', result.answer)
```

Este exemplo mostra como conectar-se a um servidor MCP público e usá-lo dentro de um agente Ax. A assinatura do agente (`questionAboutRepo, githubRepositoryUrl -> answer`) é uma suposição de como interagir com o serviço DeepWiki; normalmente, você descobriria as funções disponíveis e suas assinaturas diretamente do servidor MCP (ex: via chamada `mcp.getFunctions`, se suportada, ou documentação).

Para um exemplo mais complexo envolvendo autenticação e cabeçalhos customizados com um servidor MCP remoto, consulte o arquivo `src/examples/mcp-client-pipedream.ts` neste repositório.

## Roteamento de IA e Balanceamento de Carga

Ax oferece duas formas poderosas de trabalhar com múltiplos serviços de IA: um balanceador de carga para alta disponibilidade e um roteador para roteamento específico por modelo.

### Balanceador de Carga

O balanceador de carga distribui automaticamente requisições entre vários serviços de IA com base em desempenho e disponibilidade. Se um serviço falhar, ele faz failover automaticamente para o próximo disponível.

```typescript
import { AxAI, AxBalancer } from '@ax-llm/ax'

// Configure múltiplos serviços de IA
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

// Crie um balanceador com todos os serviços
const balancer = new AxBalancer([openai, ollama, gemini])

// Use como um serviço IA regular - utiliza automaticamente o melhor serviço disponível
const response = await balancer.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
})

// Ou use o balanceador com AxGen
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(balancer, { question: 'Hello!' })
```

### Roteador Multi-Serviço

O roteador permite usar múltiplos serviços de IA por uma única interface, roteando automaticamente as requisições para o serviço correto baseado no modelo especificado.

```typescript
import { AxAI, AxAIOpenAIModel, AxMultiServiceRouter } from '@ax-llm/ax'

// Configure OpenAI com lista de modelos
const openai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
  models: [
    {
      key: 'basic',
      model: AxAIOpenAIModel.GPT4OMini,
      description:
        'Modelo para tarefas muito simples como responder perguntas rápidas e curtas',
    },
    {
      key: 'medium',
      model: AxAIOpenAIModel.GPT4O,
      description:
        'Modelo para tarefas semi-complexas como resumir textos, escrever código e mais',
    },
  ],
})

// Configure Gemini com lista de modelos
const gemini = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY,
  models: [
    {
      key: 'deep-thinker',
      model: 'gemini-2.0-flash-thinking',
      description:
        'Modelo que pode pensar profundamente sobre uma tarefa, ideal para tarefas que exigem planejamento',
    },
    {
      key: 'expert',
      model: 'gemini-2.0-pro',
      description:
        'Modelo ideal para tarefas muito complexas como escrever ensaios longos, códigos complexos e mais',
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
  description: 'Modelo para tarefas sensíveis',
}

// Crie um roteador com todos os serviços
const router = new AxMultiServiceRouter([openai, gemini, secretService])

// Roteie para o modelo expert do OpenAI
const openaiResponse = await router.chat({
  chatPrompt: [{ role: 'user', content: 'Hello!' }],
  model: 'expert',
})

// Ou use o roteador com AxGen
const gen = new AxGen(`question -> answer`)
const res = await gen.forward(router, { question: 'Hello!' })
```

O balanceador é ideal para alta disponibilidade, enquanto o roteador é perfeito quando você precisa de modelos específicos para tarefas específicas. Ambos podem ser usados com qualquer recurso do Ax, como streaming, chamadas de função e prompting chain-of-thought.

Você também pode usar balanceador e roteador juntos — múltiplos balanceadores podem ser usados com o roteador ou vice-versa.

## Suporte OpenTelemetry

A habilidade de rastrear e observar seu fluxo de trabalho LLM é fundamental para construir fluxos de produção. OpenTelemetry é o padrão da indústria, e suportamos o novo namespace de atributos `gen_ai`. Confira `src/examples/telemetry.ts` para mais informações.

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

## Ajustando os Prompts (Básico)

Você pode ajustar seus prompts usando um modelo maior para ajudá-los a funcionar de forma mais eficiente e gerar melhores resultados. Isso é feito usando um otimizador como `AxBootstrapFewShot` com exemplos do popular dataset `HotPotQA`. O otimizador gera demonstrações (`demos`) que, quando usadas com o prompt, ajudam a melhorar sua eficiência.

```typescript
// Baixe o dataset HotPotQA do huggingface
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

// Configure o programa para ajustar
const program = new AxChainOfThought<{ question: string }, { answer: string }>(
  ai,
  `question -> answer "in short 2 or 3 words"`
)

// Configure um otimizador Bootstrap Few Shot para ajustar o programa acima
const optimize = new AxBootstrapFewShot<
  { question: string },
  { answer: string }
>({
  program,
  examples,
})

// Configure uma métrica de avaliação em, f1 scores são formas populares de medir performance de recuperação.
const metricFn: AxMetricFn = ({ prediction, example }) =>
  emScore(prediction.answer as string, example.answer as string)

// Execute o otimizador e lembre-se de salvar o resultado para uso posterior
const result = await optimize.compile(metricFn);

// Salve as demos geradas em um arquivo
// import fs from 'fs'; // Certifique-se de importar fs em seu script
fs.writeFileSync('bootstrap-demos.json', JSON.stringify(result.demos, null, 2));
console.log('Demos saved to bootstrap-demos.json');
```

<img width="853" alt="tune-prompt" src="https://raw.githubusercontent.com/ax-llm/ax/main/githubusercontent.com/dosco/llm-client/assets/832235/f924baa7-8922-424c-9c2c-f8b2018d8d74">

## Ajustando os Prompts (Avançado, Mipro v2)

MiPRO v2 é um framework avançado de otimização de prompts que usa otimização Bayesiana para encontrar automaticamente as melhores instruções, demonstrações e exemplos para seus programas LLM. Ao explorar sistematicamente diferentes configurações de prompt, o MiPRO v2 ajuda a maximizar a performance do modelo sem ajustes manuais.

### Principais Recursos

- **Otimização de instruções**: Gera e testa automaticamente múltiplas instruções
- **Seleção de exemplos few-shot**: Encontra demonstrações ideais no seu dataset
- **Otimização Bayesiana inteligente**: Usa UCB para explorar configurações eficientemente
- **Parada antecipada**: Interrompe a otimização quando não há melhorias
- **Ciente do programa e dos dados**: Considera estrutura do programa e características do dataset

### Como Funciona

1. Gera várias instruções candidatas
2. Bootstrapa exemplos few-shot a partir dos seus dados
3. Seleciona exemplos rotulados diretamente do seu dataset
4. Usa otimização Bayesiana para encontrar a combinação ideal
5. Aplica a melhor configuração ao seu programa

### Uso Básico

```typescript
import { AxAI, AxChainOfThought, AxMiPRO } from '@ax-llm/ax'

// 1. Configure seu serviço AI
const ai = new AxAI({
  name: 'google-gemini',
  apiKey: process.env.GOOGLE_APIKEY,
})

// 2. Crie seu programa
const program = new AxChainOfThought(`input -> output`)

// 3. Configure o otimizador
const optimizer = new AxMiPRO({
  ai,
  program,
  examples: trainingData, // Seus exemplos de treinamento
  options: {
    numTrials: 20, // Número de configurações a tentar
    auto: 'medium', // Nível de otimização
  },
})

// 4. Defina sua métrica de avaliação
const metricFn = ({ prediction, example }) => {
  return prediction.output === example.output
}

// 5. Execute a otimização
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData, // Conjunto de validação opcional
})

// 6. Use o programa otimizado
const result = await optimizedProgram.forward(ai, { input: 'test input' })
```

### Opções de Configuração

MiPRO v2 oferece opções de configuração extensivas:

| Opção                    | Descrição                                     | Padrão  |
| ------------------------ | --------------------------------------------- | ------- |
| `numCandidates`          | Número de instruções candidatas a gerar       | 5       |
| `numTrials`              | Número de tentativas de otimização            | 30      |
| `maxBootstrappedDemos`   | Máximo de demonstrações bootstrapped          | 3       |
| `maxLabeledDemos`        | Máximo de exemplos rotulados                  | 4       |
| `minibatch`              | Usa minibatches para avaliação mais rápida    | true    |
| `minibatchSize`          | Tamanho dos minibatches de avaliação          | 25      |
| `earlyStoppingTrials`    | Para se não houver melhoria após N tentativas | 5       |
| `minImprovementThreshold`| Limite mínimo de melhoria                     | 0.01    |
| `programAwareProposer`   | Usa estrutura do programa para propostas      | true    |
| `dataAwareProposer`      | Considera características do dataset          | true    |
| `verbose`                | Mostra progresso detalhado da otimização      | false   |
| abort-patterns.ts | Exemplo de como abortar requisições |

### Níveis de Otimização

Você pode configurar rapidamente a intensidade da otimização com o parâmetro `auto`:

```typescript
// Otimização leve (rápida, menos minuciosa)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'light' })

// Otimização média (balanceada)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'medium' })

// Otimização pesada (mais lenta, mais minuciosa)
const optimizedProgram = await optimizer.compile(metricFn, { auto: 'heavy' })
```

### Exemplo Avançado: Análise de Sentimento

```typescript
// Crie um programa de análise de sentimento
const classifyProgram = new AxChainOfThought<
  { productReview: string },
  { label: string }
>(`productReview -> label:string "positive" or "negative"`)

// Configure o otimizador com opções avançadas
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

// Execute a otimização e salve o resultado
const optimizedProgram = await optimizer.compile(metricFn, {
  valset: validationData,
})

// Salve a configuração para uso futuro
const programConfig = JSON.stringify(optimizedProgram, null, 2);
await fs.promises.writeFile("./optimized-config.json", programConfig);
console.log('> Done. Optimized program config saved to optimized-config.json');
```

## Usando os Prompts Ajustados

Tanto o otimizador Bootstrap Few Shot quanto o avançado MiPRO v2 geram **demos** (demonstrações) que melhoram significativamente a performance do seu programa. Essas demos são exemplos que mostram ao LLM como lidar corretamente com tarefas similares.

### O que são Demos?

Demos são exemplos de entrada-saída que são automaticamente incluídos nos seus prompts para guiar o LLM. Eles atuam como exemplos de few-shot learning, mostrando ao modelo o comportamento esperado para sua tarefa específica.

### Carregando e Usando Demos

Seja usando Bootstrap Few Shot ou MiPRO v2, o processo de uso das demos geradas é o mesmo:

```typescript
import fs from 'fs'
import { AxAI, AxGen, AxChainOfThought } from '@ax-llm/ax'

// 1. Configure seu serviço AI
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
})

// 2. Crie seu programa (mesma assinatura usada no ajuste)
const program = new AxChainOfThought(`question -> answer "in short 2 or 3 words"`)

// 3. Carregue as demos do arquivo salvo
const demos = JSON.parse(fs.readFileSync('bootstrap-demos.json', 'utf8'))

// 4. Aplique as demos ao seu programa
program.setDemos(demos)

// 5. Use seu programa aprimorado
const result = await program.forward(ai, {
  question: 'What castle did David Gregory inherit?'
})

console.log(result) // Agora com melhor desempenho usando exemplos aprendidos
```

### Exemplo Simples: Classificação de Texto

Veja um exemplo completo mostrando como demos melhoram uma tarefa de classificação:

```typescript
// Crie um programa de classificação
const classifier = new AxGen(`text -> category:class "positive, negative, neutral"`)

// Carregue demos geradas de Bootstrap ou MiPRO tuning
const savedDemos = JSON.parse(fs.readFileSync('classification-demos.json', 'utf8'))
classifier.setDemos(savedDemos)

// Agora o classificador aprendeu com exemplos e tem melhor desempenho
const result = await classifier.forward(ai, {
  text: "This product exceeded my expectations!"
})

console.log(result.category) // Classificação mais precisa
```

### Principais Benefícios do Uso de Demos

- **Maior Precisão**: Programas performam muito melhor com exemplos relevantes
- **Saída Consistente**: Demos ajudam a manter formatos de resposta consistentes
- **Reduz Alucinações**: Exemplos direcionam o modelo para comportamentos esperados
- **Custo-efetivo**: Melhores resultados sem precisar de modelos maiores/caros

### Boas Práticas

1. **Salve suas Demos**: Sempre salve demos geradas para reutilização
2. **Combine Assinaturas**: Use exatamente a mesma assinatura ao carregar demos
3. **Controle de Versão**: Mantenha arquivos de demos sob controle de versão para reprodutibilidade
4. **Atualize Regularmente**: Reajuste periodicamente com novos dados para melhorar as demos

Tanto Bootstrap Few Shot quanto MiPRO v2 geram demos no mesmo formato, então você pode usar o mesmo padrão de carregamento independentemente do otimizador.

## Funções Embutidas

| Função              | Nome                | Descrição                                     |
| ------------------- | ------------------- | --------------------------------------------- |
| Interpretador JS    | AxJSInterpreter     | Executa código JS em ambiente isolado         |
| Docker Sandbox      | AxDockerSession     | Executa comandos em ambiente Docker           |
| Adaptador de Embeddings | AxEmbeddingAdapter | Busca e passa embedding para sua função    |

## Veja todos os exemplos

Use o comando `tsx` para rodar os exemplos. Ele permite rodar código Typescript no Node. Também suporta uso de arquivo `.env` para passar as chaves da API de IA ao invés de colocar na linha de comando.

```shell
OPENAI_APIKEY=api-key npm run tsx ./src/examples/marketing.ts
```

| Exemplo                  | Descrição                                               |
| ------------------------ | ------------------------------------------------------ |
| customer-support.ts      | Extrai detalhes de comunicações com clientes           |
| function.ts              | Exemplo simples de chamada de função                   |
| food-search.ts           | Exemplo multi-etapas e multi-funções                   |
| marketing.ts             | Gera mensagens SMS de marketing curtas e eficazes      |
| vectordb.ts              | Chunk, embed e busca de texto                          |
| fibonacci.ts             | Usa interpretador JS para calcular fibonacci           |
| summarize.ts             | Gera resumo curto de um texto grande                   |
| chain-of-thought.ts      | Usa prompting chain-of-thought para responder questões |
| rag.ts                   | Usa multi-hop retrieval para responder questões        |
| rag-docs.ts              | Converte PDF em texto e faz embedding para RAG search  |
| react.ts                 | Usa chamadas de função e raciocínio para responder     |
| agent.ts                 | Framework de agentes; agentes podem usar outros agentes|
| streaming1.ts            | Validação de campos de saída durante streaming         |
| streaming2.ts            | Validação por campo durante streaming                  |
| streaming3.ts            | Exemplo de streaming end-to-end `streamingForward()`   |
| smart-hone.ts            | Agente procura cachorro em casa inteligente            |
| multi-modal.ts           | Usa imagem como entrada junto com texto                |
| balancer.ts              | Balanceia entre vários LLMs por custo, etc             |
| docker.ts                | Usa sandbox Docker para encontrar arquivos por descrição|
| prime.ts                 | Usa processadores de campo em prompt                   |
| simple-classify.ts       | Usa classificador simples para classificar itens       |
| mcp-client-memory.ts     | Exemplo de MCP server para memória com Ax              |
| mcp-client-blender.ts    | Exemplo de MCP server para Blender com Ax              |
| mcp-client-pipedream.ts  | Exemplo de integração com MCP remoto                   |
| tune-bootstrap.ts        | Usa otimizador bootstrap para eficiência de prompt     |
| tune-mipro.ts            | Usa otimizador mipro v2 para eficiência de prompt      |
| tune-usage.ts            | Usa prompts otimizados                                 |
| telemetry.ts             | Trace e envia traces para serviço Jaeger               |
| openai-responses.ts      | Exemplo usando OpenAI Responses API                    |
| use-examples.ts | Exemplo de uso de 'examples' para direcionar o llm              |

## Nosso Objetivo

Grandes modelos de linguagem (LLMs) estão cada vez mais poderosos e já podem funcionar como backend de um produto inteiro. Porém, ainda há muita complexidade a ser gerenciada, como prompts corretos, modelos, streaming, chamadas de função, correção de erros e muito mais. Nosso objetivo é empacotar toda essa complexidade em uma biblioteca bem mantida e fácil de usar, que funcione com todos os LLMs de ponta. Além disso, utilizamos as pesquisas mais recentes para adicionar novas capacidades como DSPy à biblioteca.

## Como usar esta biblioteca?

### 1. Escolha uma IA para trabalhar

```ts
// Escolha um LLM
const ai = new AxOpenAI({ apiKey: process.env.OPENAI_APIKEY } as AxOpenAIArgs)
```

### 2. Crie uma assinatura de prompt baseada no seu caso de uso

```ts
// A assinatura define as entradas e saídas do seu programa de prompt
const cot = new ChainOfThought(ai, `question:string -> answer:string`, { mem })
```

### 3. Execute este novo programa de prompt

```ts
// Passe os campos de entrada definidos na assinatura acima
const res = await cot.forward({ question: 'Are we in a simulation?' })
```

### 4. Ou se quiser usar o LLM diretamente

```ts
const res = await ai.chat([
  { role: "system", content: "Help the customer with his questions" }
  { role: "user", content: "I'm looking for a Macbook Pro M2 With 96GB RAM?" }
]);
```

## Como usar chamadas de função

### 1. Defina as funções

```ts
// defina uma ou mais funções e um handler de função
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

### 2. Passe as funções para um prompt

```ts
const cot = new AxGen(ai, `question:string -> answer:string`, { functions })
```

## Ativar logs de debug

```ts
const ai = new AxAI({
  name: 'openai',
  apiKey: process.env.OPENAI_APIKEY,
} as AxOpenAIArgs)
ai.setOptions({ debug: true })
```

## Entre em contato

Estamos felizes em ajudar! Entre em contato se tiver dúvidas ou junte-se ao Discord
[twitter/dosco](https://twitter.com/dosco)

## FAQ

### 1. O LLM não encontra a função correta

Melhore o nome e a descrição da função. Seja claro sobre o que a função faz. Além disso, garanta que os parâmetros tenham boas descrições. As descrições podem ser curtas, mas precisam ser precisas.

### 2. Como altero a configuração do LLM que estou usando?

Você pode passar um objeto de configuração como segundo parâmetro ao criar um novo objeto LLM.

```ts
const apiKey = process.env.OPENAI_APIKEY
const conf = AxOpenAIBestConfig()
const ai = new AxOpenAI({ apiKey, conf } as AxOpenAIArgs)
```

## 3. Meu prompt está muito longo / posso alterar o max tokens?

```ts
const conf = axOpenAIDefaultConfig() // ou OpenAIBestOptions()
conf.maxTokens = 2000
```

## 4. Como altero o modelo? (ex: quero usar o GPT4)

```ts
const conf = axOpenAIDefaultConfig() // ou OpenAIBestOptions()
conf.model = OpenAIModel.GPT4Turbo
```

## Dicas & truques para Monorepo

É essencial lembrar que devemos rodar `npm install` apenas no diretório raiz. Isso previne a criação de arquivos `package-lock.json` aninhados e evita `node_modules` não deduplicados.

Adicionar novas dependências em pacotes deve ser feito com, por exemplo,
`npm install lodash --workspace=ax` (ou apenas modificar o `package.json` apropriado e rodar `npm install` do root).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---