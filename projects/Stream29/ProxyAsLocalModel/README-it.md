# ProxyAsLocalModel

Proxy API LLM remoti come modelli locali. Funziona in particolare per l'utilizzo di LLM personalizzati in JetBrains AI Assistant.

Basato su Ktor e kotlinx.serialization. Grazie alle loro caratteristiche senza riflessione.

## Storia di questo progetto

Attualmente, JetBrains AI Assistant offre un piano gratuito con quote molto limitate. L'ho provato e la mia quota si è esaurita rapidamente.

Avevo già acquistato altri token API LLM, come Gemini e Qwen. Quindi ho iniziato a pensare di usarli in AI Assistant. Sfortunatamente, sono supportati solo i modelli locali da LM Studio e Ollama. Così ho iniziato a lavorare su questa applicazione proxy che fa da proxy alle API LLM di terze parti come se fossero API di LM Studio e Ollama, così da poterle utilizzare nei miei IDE JetBrains.

Questo è solo un compito semplice, quindi ho iniziato a utilizzare gli SDK ufficiali come client e a scrivere un semplice server Ktor che fornisce endpoint come LM Studio e Ollama. Il problema è apparso quando ho cercato di distribuirlo come immagine nativa GraalVM. Gli SDK Java ufficiali usano troppe funzionalità dinamiche, rendendo difficile la compilazione in un'immagine nativa, anche con un tracing agent. Quindi ho deciso di implementare io stesso un semplice client per l'API di completamento chat in streaming con Ktor e kotlinx.serialization, che sono entrambi senza riflessione, funzionali e in stile DSL.

Come puoi vedere, questa applicazione è distribuita come jar eseguibile fat e come immagine nativa GraalVM, il che la rende multipiattaforma e veloce all'avvio.

Lo sviluppo di questa applicazione mi ha dato fiducia in Kotlin/Ktor/kotlinx.serialization. Il mondo Kotlin utilizza più programmazione funzionale e meno riflessione, il che lo rende più adatto per immagini native GraalVM, con avvio più rapido e minore utilizzo di memoria.

## Attualmente supportato

Proxy da: OpenAI, Claude, DashScope (Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy come: LM Studio, Ollama.

Solo API di completamento chat in streaming.
## Come usare

Questa applicazione è un server proxy, distribuito come un jar eseguibile standalone e come un'immagine nativa GraalVM (Windows x64).

Esegui l'applicazione e vedrai un messaggio di aiuto:

```
2025-05-02 10:43:53 INFO  Help - Sembra che tu stia avviando il programma per la prima volta qui.
2025-05-02 10:43:53 INFO  Help - Un file di configurazione predefinito è stato creato in your_path\config.yml con annotazioni di schema.
2025-05-02 10:43:53 INFO  Config - Il watcher del file di configurazione è stato avviato in your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio Server avviato su 1234
2025-05-02 10:43:53 INFO  Ollama Server - Ollama Server avviato su 11434
2025-05-02 10:43:53 INFO  Model List - Elenco modelli caricato con: []
```

Successivamente puoi modificare il file di configurazione per impostare il tuo server proxy.

## File di configurazione

Questo file di configurazione viene automaticamente ricaricato a caldo quando lo modifichi. Solo le parti interessate del server verranno aggiornate.

Quando il file di configurazione viene generato per la prima volta, sarà creato con annotazioni di schema. Questo fornirà completamento e verifica nel tuo editor.
## Esempio di file di configurazione

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Questo è il valore predefinito
  enabled: true # Questo è il valore predefinito
  host: 0.0.0.0 # Questo è il valore predefinito
  path: /your/path # Verrà aggiunto prima degli endpoint originali, il valore predefinito è vuoto
ollama:
  port: 11434 # Questo è il valore predefinito
  enabled: true # Questo è il valore predefinito
  host: 0.0.0.0 # Questo è il valore predefinito
  path: /your/path # Verrà aggiunto prima degli endpoint originali, il valore predefinito è vuoto
client:
  socketTimeout: 1919810 # Long.MAX_VALUE è il valore predefinito, in millisecondi
  connectionTimeout: 1919810 # Long.MAX_VALUE è il valore predefinito, in millisecondi
  requestTimeout: 1919810 # Long.MAX_VALUE è il valore predefinito, in millisecondi
  retry: 3 # Questo è il valore predefinito
  delayBeforeRetry: 1000 # Questo è il valore predefinito, in millisecondi

apiProviders:
  OpenAI:
    type: OpenAi
    baseUrl: https://api.openai.com/v1
    apiKey: <your_api_key>
    modelList:
      - gpt-4o
  Claude:
    type: Claude
    apiKey: <your_api_key>
    modelList:
      - claude-3-7-sonnet
  Qwen:
    type: DashScope
    apiKey: <your_api_key>
    modelList: # Questo è il valore predefinito
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # Questo è il valore predefinito
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # Questo è il valore predefinito
      - codestral-latest
      - mistral-large
  SiliconFlow:
    type: SiliconFlow
    apiKey: <your_api_key>
    modelList:
      - Qwen/Qwen3-235B-A22B
      - Pro/deepseek-ai/DeepSeek-V3
      - THUDM/GLM-4-32B-0414
  OpenRouter:
    type: OpenRouter
    apiKey: <your_api_key>
    modelList:
      - openai/gpt-4o
  Gemini:
    type: Gemini
    apiKey: <your_api_key>
    modelList:
      - gemini-2.5-flash-preview-04-17
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---