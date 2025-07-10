# ProxyAsLocalModel

將遠端 LLM API 代理為本地模型。特別適用於在 JetBrains AI Assistant 中使用自訂 LLM。

由 Ktor 和 kotlinx.serialization 提供技術支持。感謝它們無需反射的特性。

## 本專案的故事

目前，JetBrains AI Assistant 提供的免費方案配額非常有限。我試用了一下，很快就用完了配額。

我已經購買了其他 LLM API 令牌，例如 Gemini 和 Qwen。因此我開始思考如何在 AI Assistant 中使用它們。不幸的是，目前僅支援來自 LM Studio 和 Ollama 的本地模型。因此我開始著手開發這個代理應用程式，將第三方 LLM API 代理為 LM Studio 和 Ollama API，這樣我就能在 JetBrains IDEs 中使用它們。

這本來只是個簡單的任務，所以我開始使用官方 SDK 作為客戶端，並編寫一個簡單的 Ktor 伺服器，提供與 LM Studio 和 Ollama 相同的端點。問題出現在我嘗試將其發佈為 GraalVM 原生映像時。官方 Java SDK 使用了太多動態特性，即使使用追蹤代理，也很難編譯成原生映像。因此，我決定自己用 Ktor 和 kotlinx.serialization（兩者都無需反射、具備函式化和 DSL 風格）實現一個簡單的串流聊天補全 API 客戶端。

如你所見，這個應用程式以可執行的 fat jar 和 GraalVM 原生映像發佈，實現跨平台和快速啟動。

這個應用程式的開發讓我對 Kotlin/Ktor/kotlinx.serialization 更有信心。Kotlin 世界更多採用函式編程，較少使用反射，這讓它更適合用於 GraalVM 原生映像，啟動更快且記憶體佔用更低。

## 目前支援

代理來源：OpenAI、Claude、DashScope（阿里巴巴 Qwen）、Gemini、Deepseek、Mistral、SiliconFlow。

代理為：LM Studio、Ollama。

僅支援串流聊天補全 API。
## 如何使用

此應用程式是一個代理伺服器，以可執行的 fat jar 及 GraalVM 原生映像檔（Windows x64）發佈。

執行應用程式後，您會看到一則說明訊息：

```
2025-05-02 10:43:53 INFO  Help - 看起來您是第一次在這裡啟動程式。
2025-05-02 10:43:53 INFO  Help - 已在 your_path\config.yml 建立了預設設定檔，並附有結構註解。
2025-05-02 10:43:53 INFO  Config - 設定檔監控已啟動於 your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio 伺服器已啟動於 1234
2025-05-02 10:43:53 INFO  Ollama Server - Ollama 伺服器已啟動於 11434
2025-05-02 10:43:53 INFO  Model List - 已載入模型清單：[]
```

然後，您可以編輯設定檔來設置您的代理伺服器。

## 設定檔

當您更改此設定檔時，系統會自動熱重載。只有受影響的伺服器部分會被更新。

首次生成設定檔時，會自動帶有結構註解。這將在您的編輯器中帶來自動補全與檢查功能。
## 範例設定檔

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # 這是預設值
  enabled: true # 這是預設值
  host: 0.0.0.0 # 這是預設值
  path: /your/path # 將會加在原始端點之前，預設值為空
ollama:
  port: 11434 # 這是預設值
  enabled: true # 這是預設值
  host: 0.0.0.0 # 這是預設值
  path: /your/path # 將會加在原始端點之前，預設值為空
client:
  socketTimeout: 1919810 # 預設值為 Long.MAX_VALUE，單位為毫秒
  connectionTimeout: 1919810 # 預設值為 Long.MAX_VALUE，單位為毫秒
  requestTimeout: 1919810 # 預設值為 Long.MAX_VALUE，單位為毫秒
  retry: 3 # 這是預設值
  delayBeforeRetry: 1000 # 這是預設值，單位為毫秒

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
    modelList: # 這是預設值
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # 這是預設值
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # 這是預設值
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