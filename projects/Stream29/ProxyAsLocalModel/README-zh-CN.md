# ProxyAsLocalModel

将远程 LLM API 代理为本地模型。特别适用于在 JetBrains AI Assistant 中使用自定义 LLM。

由 Ktor 和 kotlinx.serialization 提供支持。感谢它们的无反射特性。

## 项目故事

目前，JetBrains AI Assistant 提供的免费套餐配额非常有限。我试用了一下，很快就用完了配额。

我已经购买了其他 LLM API 令牌，例如 Gemini 和 Qwen。所以我开始考虑在 AI Assistant 中使用它们。不幸的是，目前只支持来自 LM Studio 和 Ollama 的本地模型。因此，我开始开发这个代理应用，将第三方 LLM API 代理为 LM Studio 和 Ollama API，这样我就可以在 JetBrains IDE 中使用它们。

这只是一个简单的任务，所以我开始使用官方 SDK 作为客户端，并编写了一个简单的 Ktor 服务器，提供与 LM Studio 和 Ollama 相同的端点。问题出现在我尝试将其分发为 GraalVM 原生镜像时。官方的 Java SDK 使用了太多动态特性，即使使用跟踪代理，也很难编译成原生镜像。所以我决定用 Ktor 和 kotlinx.serialization 自己实现一个简单的流式对话补全 API 客户端，这两者都是无反射、函数式且 DSL 风格的。

如你所见，该应用以 fat 可运行 jar 和 GraalVM 原生镜像的形式分发，使其跨平台且启动迅速。

这个应用的开发让我对 Kotlin/Ktor/kotlinx.serialization 更有信心。Kotlin 生态更多采用函数式编程，较少使用反射，这使得它更适合构建 GraalVM 原生镜像，启动更快，内存占用更少。

## 当前支持

代理来源：OpenAI、Claude、DashScope（阿里巴巴 Qwen）、Gemini、Deepseek、Mistral、SiliconFlow。

代理为：LM Studio、Ollama。

仅支持流式对话补全 API。
## 使用方法

此应用程序是一个代理服务器，以可运行的 fat jar 和 GraalVM 原生镜像（Windows x64）形式分发。

运行应用程序后，您将看到一条帮助信息：

```
2025-05-02 10:43:53 INFO  Help - 看起来您是第一次在此处启动程序。
2025-05-02 10:43:53 INFO  Help - 已在 your_path\config.yml 处创建了带有模式注释的默认配置文件。
2025-05-02 10:43:53 INFO  Config - 配置文件监听器已启动，路径为 your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio 服务器已启动，端口为 1234
2025-05-02 10:43:53 INFO  Ollama Server - Ollama 服务器已启动，端口为 11434
2025-05-02 10:43:53 INFO  Model List - 已加载模型列表：[]
```

然后您可以编辑配置文件来设置您的代理服务器。

## 配置文件

当您更改此配置文件时，系统会自动热重载。只有受影响的服务器部分会被更新。

首次生成配置文件时，将会带有模式注释创建。这将在您的编辑器中提供补全和检查功能。
## 示例配置文件

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # 这是默认值
  enabled: true # 这是默认值
  host: 0.0.0.0 # 这是默认值
  path: /your/path # 将会添加在原始端点前，默认值为空
ollama:
  port: 11434 # 这是默认值
  enabled: true # 这是默认值
  host: 0.0.0.0 # 这是默认值
  path: /your/path # 将会添加在原始端点前，默认值为空
client:
  socketTimeout: 1919810 # Long.MAX_VALUE 为默认值，单位为毫秒
  connectionTimeout: 1919810 # Long.MAX_VALUE 为默认值，单位为毫秒
  requestTimeout: 1919810 # Long.MAX_VALUE 为默认值，单位为毫秒
  retry: 3 # 这是默认值
  delayBeforeRetry: 1000 # 这是默认值，单位为毫秒

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
    modelList: # 这是默认值
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # 这是默认值
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # 这是默认值
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