# ProxyAsLocalModel

Proxy externe LLM API als lokaal model. Werkt vooral voor het gebruik van aangepaste LLM in JetBrains AI Assistant.

Aangedreven door Ktor en kotlinx.serialization. Dankzij hun no-reflex-functionaliteiten.

## Verhaal van dit project

Momenteel biedt JetBrains AI Assistant een gratis plan met zeer beperkte quota. Ik heb het uitgeprobeerd en mijn quota was snel op.

Ik heb al tokens gekocht voor andere LLM API’s, zoals Gemini en Qwen. Dus begon ik na te denken over hoe ik deze in AI Assistant kon gebruiken. Helaas worden alleen lokale modellen van LM Studio en Ollama ondersteund. Daarom begon ik te werken aan deze proxy-applicatie die externe LLM API’s proxiet als LM Studio- en Ollama-API, zodat ik ze kan gebruiken in mijn JetBrains IDE’s.

Dit is slechts een eenvoudige taak, dus begon ik de officiële SDK’s als clients te gebruiken en schreef ik een eenvoudige Ktor-server die endpoints aanbiedt als LM Studio en Ollama. Het probleem ontstond toen ik het wilde distribueren als een GraalVM native image. De officiële Java SDK’s gebruiken te veel dynamische functionaliteiten, waardoor het moeilijk is om te compileren naar een native image, zelfs met een tracing agent. Daarom besloot ik zelf een eenvoudige client te implementeren voor de streaming chat completion API met Ktor en kotlinx.serialization, die beide no-reflex, functioneel en DSL-georiënteerd zijn.

Zoals je kunt zien, wordt deze applicatie gedistribueerd als een fat runnable jar en een GraalVM native image, waardoor het cross-platform is en snel opstart.

De ontwikkeling van deze applicatie heeft mij vertrouwen gegeven in Kotlin/Ktor/kotlinx.serialization. De Kotlin-wereld gebruikt meer functioneel programmeren en minder reflectie, wat het geschikter maakt voor GraalVM native image, met snellere opstart en minder geheugengebruik.

## Momenteel ondersteund

Proxy van: OpenAI, Claude, DashScope (Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy als: LM Studio, Ollama.

Alleen streaming chat completion API.
## Hoe te gebruiken

Deze applicatie is een proxyserver, verspreid als een fat runnable jar en een GraalVM native image (Windows x64).

Start de applicatie en je ziet een helpbericht:

```
2025-05-02 10:43:53 INFO  Help - Het lijkt erop dat je het programma hier voor de eerste keer start.
2025-05-02 10:43:53 INFO  Help - Een standaard configuratiebestand is aangemaakt op your_path\config.yml met schema-annotatie.
2025-05-02 10:43:53 INFO  Config - Configuratiebestand-watcher gestart op your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio Server gestart op 1234
2025-05-02 10:43:53 INFO  Ollama Server - Ollama Server gestart op 11434
2025-05-02 10:43:53 INFO  Model List - Modellenlijst geladen met: []
```

Daarna kun je het configuratiebestand bewerken om je proxyserver in te stellen.

## Configuratiebestand

Dit configuratiebestand wordt automatisch hot-geregeld wanneer je het wijzigt. Alleen de getroffen onderdelen van de server worden bijgewerkt.

Bij het eerste aanmaken van het configuratiebestand, wordt het aangemaakt met schema-annotaties. Dit zorgt voor aanvulling en controle in je editor.
## Voorbeeld configuratiebestand

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Dit is de standaardwaarde
  enabled: true # Dit is de standaardwaarde
  host: 0.0.0.0 # Dit is de standaardwaarde
  path: /your/path # Wordt toegevoegd vóór de originele eindpunten, standaardwaarde is leeg
ollama:
  port: 11434 # Dit is de standaardwaarde
  enabled: true # Dit is de standaardwaarde
  host: 0.0.0.0 # Dit is de standaardwaarde
  path: /your/path # Wordt toegevoegd vóór de originele eindpunten, standaardwaarde is leeg
client:
  socketTimeout: 1919810 # Long.MAX_VALUE is de standaardwaarde, in milliseconden
  connectionTimeout: 1919810 # Long.MAX_VALUE is de standaardwaarde, in milliseconden
  requestTimeout: 1919810 # Long.MAX_VALUE is de standaardwaarde, in milliseconden
  retry: 3 # Dit is de standaardwaarde
  delayBeforeRetry: 1000 # Dit is de standaardwaarde, in milliseconden

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
    modelList: # Dit is de standaardwaarde
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # Dit is de standaardwaarde
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # Dit is de standaardwaarde
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