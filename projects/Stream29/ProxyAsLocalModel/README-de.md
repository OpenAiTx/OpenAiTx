# ProxyAsLocalModel

Proxy-Remote-LLM-API als lokales Modell. Besonders geeignet für die Verwendung von benutzerdefinierten LLMs im JetBrains AI Assistant.

Angetrieben von Ktor und kotlinx.serialization. Dank ihrer No-Reflection-Eigenschaften.

## Geschichte dieses Projekts

Derzeit bietet der JetBrains AI Assistant einen kostenlosen Plan mit sehr begrenzten Kontingenten. Ich habe ihn ausprobiert und mein Kontingent war schnell aufgebraucht.

Ich habe bereits andere LLM-API-Tokens gekauft, wie zum Beispiel Gemini und Qwen. Daher kam mir die Idee, diese im AI Assistant zu verwenden. Leider werden nur lokale Modelle von LM Studio und Ollama unterstützt. Also begann ich mit der Entwicklung dieser Proxy-Anwendung, die Drittanbieter-LLM-APIs als LM Studio- und Ollama-API weiterleitet, sodass ich sie in meinen JetBrains-IDEs verwenden kann.

Dies ist nur eine einfache Aufgabe, daher begann ich damit, die offiziellen SDKs als Clients zu verwenden und einen einfachen Ktor-Server zu schreiben, der Endpunkte wie LM Studio und Ollama bereitstellt. Das Problem trat auf, als ich versuchte, es als GraalVM-Native-Image zu verteilen. Die offiziellen Java-SDKs nutzen zu viele dynamische Features, was die Kompilierung in ein Native-Image erschwert, selbst mit einem Tracing-Agent. Also entschied ich mich, einen einfachen Client für die Streaming-Chat-Completion-API selbst zu implementieren, mit Ktor und kotlinx.serialization, die beide ohne Reflection, funktional und DSL-basiert sind.

Wie Sie sehen können, wird diese Anwendung als Fat-Runnable-Jar und als GraalVM-Native-Image ausgeliefert, was sie plattformübergreifend und schnell startend macht.

Die Entwicklung dieser Anwendung hat mir Vertrauen in Kotlin/Ktor/kotlinx.serialization gegeben. Die Kotlin-Welt verwendet mehr funktionale Programmierung und weniger Reflection, was sie für GraalVM-Native-Images besser geeignet macht, mit schnellerem Start und geringerem Speicherverbrauch.

## Derzeit unterstützt

Proxy von: OpenAI, Claude, DashScope (Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy als: LM Studio, Ollama.

Nur Streaming-Chat-Completion-API.
## Verwendung

Diese Anwendung ist ein Proxy-Server, der als ausführbares Fat-Jar und als GraalVM-Native-Image (Windows x64) verteilt wird.

Starten Sie die Anwendung, und Sie sehen eine Hilfemeldung:

```
2025-05-02 10:43:53 INFO  Help - Es scheint, dass Sie das Programm hier zum ersten Mal starten.
2025-05-02 10:43:53 INFO  Help - Eine Standard-Konfigurationsdatei wurde unter your_path\config.yml mit Schema-Anmerkungen erstellt.
2025-05-02 10:43:53 INFO  Config - Konfigurationsdatei-Überwachung gestartet unter your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio Server gestartet auf 1234
2025-05-02 10:43:53 INFO  Ollama Server - Ollama Server gestartet auf 11434
2025-05-02 10:43:53 INFO  Model List - Modellliste geladen mit: []
```

Anschließend können Sie die Konfigurationsdatei bearbeiten, um Ihren Proxy-Server einzurichten.

## Konfigurationsdatei

Diese Konfigurationsdatei wird automatisch neu geladen, sobald Sie sie ändern. Nur die betroffenen Teile des Servers werden aktualisiert.

Bei der ersten Erstellung der Konfigurationsdatei wird diese mit Schema-Anmerkungen erstellt. Dies ermöglicht Vervollständigungen und Überprüfungen in Ihrem Editor.
## Beispiel-Konfigurationsdatei

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Dies ist der Standardwert
  enabled: true # Dies ist der Standardwert
  host: 0.0.0.0 # Dies ist der Standardwert
  path: /your/path # Wird vor den ursprünglichen Endpunkten hinzugefügt, Standardwert ist leer
ollama:
  port: 11434 # Dies ist der Standardwert
  enabled: true # Dies ist der Standardwert
  host: 0.0.0.0 # Dies ist der Standardwert
  path: /your/path # Wird vor den ursprünglichen Endpunkten hinzugefügt, Standardwert ist leer
client:
  socketTimeout: 1919810 # Long.MAX_VALUE ist der Standardwert, in Millisekunden
  connectionTimeout: 1919810 # Long.MAX_VALUE ist der Standardwert, in Millisekunden
  requestTimeout: 1919810 # Long.MAX_VALUE ist der Standardwert, in Millisekunden
  retry: 3 # Dies ist der Standardwert
  delayBeforeRetry: 1000 # Dies ist der Standardwert, in Millisekunden

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
    modelList: # Dies ist der Standardwert
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # Dies ist der Standardwert
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # Dies ist der Standardwert
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