# ProxyAsLocalModel

Proxy de API LLM remota como modelo local. Funciona especialmente para utilizar LLM personalizada no JetBrains AI Assistant.

Desenvolvido com Ktor e kotlinx.serialization. Graças às suas funcionalidades sem reflexão.

## História deste projeto

Atualmente, o JetBrains AI Assistant oferece um plano gratuito com cotas muito limitadas. Experimentei e minha cota acabou rapidamente.

Já adquiri tokens de API de outros LLM, como Gemini e Qwen. Então comecei a pensar em usá-los no AI Assistant. Infelizmente, apenas modelos locais do LM Studio e Ollama são suportados. Por isso, comecei a trabalhar neste aplicativo proxy que faz a ponte entre APIs LLM de terceiros e as APIs do LM Studio e Ollama, para que eu possa usá-los nos meus IDEs da JetBrains.

Esta é uma tarefa simples, então comecei usando os SDKs oficiais como clientes e escrevi um servidor Ktor simples que fornece endpoints como LM Studio e Ollama. O problema surgiu quando tentei distribuir como uma imagem nativa do GraalVM. Os SDKs Java oficiais usam muitos recursos dinâmicos, dificultando a compilação para uma imagem nativa, mesmo usando um agente de rastreamento. Então decidi implementar um cliente simples da API de conclusão de chat em streaming por conta própria, usando Ktor e kotlinx.serialization, ambos sem reflexão, funcionais e com estilo DSL.

Como pode ver, este aplicativo é distribuído como um fat jar executável e uma imagem nativa GraalVM, o que o torna multiplataforma e rápido para iniciar.

O desenvolvimento deste aplicativo me deu confiança no Kotlin/Ktor/kotlinx.serialization. O mundo Kotlin utiliza mais programação funcional e menos reflexão, o que o torna mais adequado para imagem nativa GraalVM, com inicialização mais rápida e menor uso de memória.

## Atualmente suportado

Proxy de: OpenAI, Claude, DashScope(Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy como: LM Studio, Ollama.

Apenas API de conclusão de chat em streaming.
## Como usar

Este aplicativo é um servidor proxy, distribuído como um fat runnable jar e uma imagem nativa GraalVM (Windows x64).

Execute o aplicativo e você verá uma mensagem de ajuda:

```
2025-05-02 10:43:53 INFO  Help - Parece que você está iniciando o programa pela primeira vez aqui.
2025-05-02 10:43:53 INFO  Help - Um arquivo de configuração padrão foi criado em seu_caminho\config.yml com anotações de esquema.
2025-05-02 10:43:53 INFO  Config - Observador do arquivo de configuração iniciado em seu_caminho\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - Servidor LM Studio iniciado na porta 1234
2025-05-02 10:43:53 INFO  Ollama Server - Servidor Ollama iniciado na porta 11434
2025-05-02 10:43:53 INFO  Model List - Lista de modelos carregada com: []
```

Depois, você pode editar o arquivo de configuração para configurar seu servidor proxy.

## Arquivo de configuração

Este arquivo de configuração é automaticamente recarregado a quente quando você o altera. Apenas as partes influenciadas do servidor serão atualizadas.

Ao gerar o arquivo de configuração pela primeira vez, ele será criado com anotações de esquema. Isso proporcionará preenchimento automático e verificação em seu editor.
## Exemplo de arquivo de configuração

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Este é o valor padrão
  enabled: true # Este é o valor padrão
  host: 0.0.0.0 # Este é o valor padrão
  path: /seu/caminho # Será adicionado antes dos endpoints originais, valor padrão é vazio
ollama:
  port: 11434 # Este é o valor padrão
  enabled: true # Este é o valor padrão
  host: 0.0.0.0 # Este é o valor padrão
  path: /seu/caminho # Será adicionado antes dos endpoints originais, valor padrão é vazio
client:
  socketTimeout: 1919810 # Long.MAX_VALUE é o valor padrão, em milissegundos
  connectionTimeout: 1919810 # Long.MAX_VALUE é o valor padrão, em milissegundos
  requestTimeout: 1919810 # Long.MAX_VALUE é o valor padrão, em milissegundos
  retry: 3 # Este é o valor padrão
  delayBeforeRetry: 1000 # Este é o valor padrão, em milissegundos

apiProviders:
  OpenAI:
    type: OpenAi
    baseUrl: https://api.openai.com/v1
    apiKey: <sua_api_key>
    modelList:
      - gpt-4o
  Claude:
    type: Claude
    apiKey: <sua_api_key>
    modelList:
      - claude-3-7-sonnet
  Qwen:
    type: DashScope
    apiKey: <sua_api_key>
    modelList: # Este é o valor padrão
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <sua_api_key>
    modelList: # Este é o valor padrão
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <sua_api_key>
    modelList: # Este é o valor padrão
      - codestral-latest
      - mistral-large
  SiliconFlow:
    type: SiliconFlow
    apiKey: <sua_api_key>
    modelList:
      - Qwen/Qwen3-235B-A22B
      - Pro/deepseek-ai/DeepSeek-V3
      - THUDM/GLM-4-32B-0414
  OpenRouter:
    type: OpenRouter
    apiKey: <sua_api_key>
    modelList:
      - openai/gpt-4o
  Gemini:
    type: Gemini
    apiKey: <sua_api_key>
    modelList:
      - gemini-2.5-flash-preview-04-17
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---