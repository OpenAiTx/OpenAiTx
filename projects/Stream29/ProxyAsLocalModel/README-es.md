# ProxyAsLocalModel

Proxy API de LLM remotos como modelo local. Especialmente útil para usar LLM personalizados en JetBrains AI Assistant.

Impulsado por Ktor y kotlinx.serialization. Gracias a sus características sin reflexión.

## Historia de este proyecto

Actualmente, JetBrains AI Assistant ofrece un plan gratuito con cuotas muy limitadas. Lo probé y mi cuota se agotó rápidamente.

Ya había comprado otros tokens de API de LLM, como Gemini y Qwen. Así que empecé a pensar en usarlos en AI Assistant. Desafortunadamente, solo se admiten modelos locales de LM Studio y Ollama. Así que comencé a trabajar en esta aplicación proxy que actúa como intermediario de API de LLM de terceros como LM Studio y Ollama API para poder usarlos en mis IDEs de JetBrains.

Esta es solo una tarea sencilla, así que empecé a usar los SDKs oficiales como clientes y a escribir un servidor Ktor simple que proporcione endpoints como LM Studio y Ollama. El problema apareció cuando intenté distribuirlo como una imagen nativa de GraalVM. Los SDKs oficiales de Java usan demasiadas funciones dinámicas, lo que dificulta la compilación en una imagen nativa, incluso con un agente de rastreo. Así que decidí implementar yo mismo un cliente simple de la API de chat de completado por streaming utilizando Ktor y kotlinx.serialization, que son ambos sin reflexión, funcionales y con estilo DSL.

Como puedes ver, esta aplicación se distribuye como un jar ejecutable "fat" y una imagen nativa de GraalVM, lo que la hace multiplataforma y rápida de iniciar.

El desarrollo de esta aplicación me ha dado confianza en Kotlin/Ktor/kotlinx.serialization. El mundo Kotlin usa más programación funcional y menos reflexión, lo que lo hace más adecuado para imágenes nativas de GraalVM, con un arranque más rápido y menor uso de memoria.

## Actualmente soportado

Proxy desde: OpenAI, Claude, DashScope (Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy como: LM Studio, Ollama.

Solo API de chat de completado por streaming.
## Cómo usar

Esta aplicación es un servidor proxy, distribuido como un archivo jar ejecutable autónomo y una imagen nativa de GraalVM (Windows x64).

Ejecute la aplicación y verá un mensaje de ayuda:

```
2025-05-02 10:43:53 INFO  Help - Parece que está iniciando el programa por primera vez aquí.
2025-05-02 10:43:53 INFO  Help - Se ha creado un archivo de configuración predeterminado en your_path\config.yml con anotaciones de esquema.
2025-05-02 10:43:53 INFO  Config - El observador del archivo de configuración se inició en your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - Servidor LM Studio iniciado en 1234
2025-05-02 10:43:53 INFO  Ollama Server - Servidor Ollama iniciado en 11434
2025-05-02 10:43:53 INFO  Model List - Lista de modelos cargada con: []
```

Luego puede editar el archivo de configuración para configurar su servidor proxy.

## Archivo de configuración

Este archivo de configuración se recarga automáticamente en caliente cuando lo modifica. Solo se actualizarán las partes del servidor que se vean afectadas.

Cuando se genera por primera vez el archivo de configuración, se creará con anotaciones de esquema. Esto proporcionará autocompletado y verificación en su editor.
## Ejemplo de archivo de configuración

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Este es el valor por defecto
  enabled: true # Este es el valor por defecto
  host: 0.0.0.0 # Este es el valor por defecto
  path: /your/path # Se añadirá antes de los endpoints originales, el valor por defecto es vacío
ollama:
  port: 11434 # Este es el valor por defecto
  enabled: true # Este es el valor por defecto
  host: 0.0.0.0 # Este es el valor por defecto
  path: /your/path # Se añadirá antes de los endpoints originales, el valor por defecto es vacío
client:
  socketTimeout: 1919810 # Long.MAX_VALUE es el valor por defecto, en milisegundos
  connectionTimeout: 1919810 # Long.MAX_VALUE es el valor por defecto, en milisegundos
  requestTimeout: 1919810 # Long.MAX_VALUE es el valor por defecto, en milisegundos
  retry: 3 # Este es el valor por defecto
  delayBeforeRetry: 1000 # Este es el valor por defecto, en milisegundos

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
    modelList: # Este es el valor por defecto
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # Este es el valor por defecto
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # Este es el valor por defecto
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