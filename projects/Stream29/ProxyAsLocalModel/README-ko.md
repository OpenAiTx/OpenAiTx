# ProxyAsLocalModel

원격 LLM API를 로컬 모델로 프록시합니다. 특히 JetBrains AI Assistant에서 커스텀 LLM을 사용할 때 유용합니다.

Ktor와 kotlinx.serialization 기반입니다. 이들의 비-리플렉스 기능에 감사드립니다.

## 이 프로젝트의 이야기

현재 JetBrains AI Assistant는 매우 제한된 쿼터가 있는 무료 플랜을 제공합니다. 직접 사용해보니 쿼터가 금방 소진되었습니다.

저는 이미 Gemini, Qwen 등 다른 LLM API 토큰을 구매한 상태였습니다. 그래서 AI Assistant에서 이들을 사용하고 싶다는 생각이 들었습니다. 불행히도 LM Studio와 Ollama의 로컬 모델만 지원합니다. 그래서 타사 LLM API를 LM Studio와 Ollama API로 프록시하여 JetBrains IDE에서 사용할 수 있도록 이 프록시 애플리케이션 작업을 시작했습니다.

이것은 단순한 작업이기에, 공식 SDK를 클라이언트로 사용하고 LM Studio와 Ollama와 동일한 엔드포인트를 제공하는 간단한 Ktor 서버를 작성하기 시작했습니다. 그런데 이를 GraalVM 네이티브 이미지로 배포하려고 하니 문제가 발생했습니다. 공식 Java SDK는 동적 기능을 너무 많이 사용하여, 트레이싱 에이전트를 사용해도 네이티브 이미지로 컴파일하기가 어렵습니다. 그래서 직접 Ktor와 kotlinx.serialization을 사용하여 스트리밍 채팅 완성 API의 간단한 클라이언트를 구현하기로 했습니다. 이들은 모두 비-리플렉스, 함수형, 그리고 DSL 스타일입니다.

보시다시피, 이 애플리케이션은 fat runnable jar와 GraalVM 네이티브 이미지로 배포되어 크로스 플랫폼이면서 빠른 시작을 자랑합니다.

이 애플리케이션 개발을 통해 Kotlin/Ktor/kotlinx.serialization에 대한 신뢰가 생겼습니다. Kotlin 세계는 더 함수형 프로그래밍을 지향하고 리플렉션 사용이 적어, GraalVM 네이티브 이미지에 더 적합하며, 빠른 시작과 적은 메모리 사용이 가능합니다.

## 현재 지원 현황

프록시 소스: OpenAI, Claude, DashScope(Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

프록시 대상: LM Studio, Ollama.

스트리밍 채팅 완성 API만 지원합니다.
## 사용 방법

이 애플리케이션은 프록시 서버로, fat runnable jar와 GraalVM 네이티브 이미지(Windows x64)로 배포됩니다.

애플리케이션을 실행하면, 다음과 같은 도움말 메시지가 표시됩니다:

```
2025-05-02 10:43:53 INFO  Help - 프로그램을 이 위치에서 처음 시작하는 것 같습니다.
2025-05-02 10:43:53 INFO  Help - 기본 설정 파일이 your_path\config.yml에 스키마 주석과 함께 생성되었습니다.
2025-05-02 10:43:53 INFO  Config - 설정 파일 감시자가 your_path\config.yml에서 시작되었습니다.
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio 서버가 1234 포트에서 시작되었습니다.
2025-05-02 10:43:53 INFO  Ollama Server - Ollama 서버가 11434 포트에서 시작되었습니다.
2025-05-02 10:43:53 INFO  Model List - 모델 목록이 로드되었습니다: []
```

이제 설정 파일을 편집하여 프록시 서버를 구성할 수 있습니다.

## 설정 파일

이 설정 파일은 변경 시 자동으로 핫 리로드됩니다. 서버의 영향받는 부분만 업데이트됩니다.

처음 설정 파일이 생성될 때, 스키마 주석과 함께 생성됩니다. 이를 통해 에디터에서 자동 완성과 검증 기능을 사용할 수 있습니다.
## 예시 설정 파일

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # 기본값입니다
  enabled: true # 기본값입니다
  host: 0.0.0.0 # 기본값입니다
  path: /your/path # 원래 엔드포인트 앞에 추가됩니다, 기본값은 비어 있음
ollama:
  port: 11434 # 기본값입니다
  enabled: true # 기본값입니다
  host: 0.0.0.0 # 기본값입니다
  path: /your/path # 원래 엔드포인트 앞에 추가됩니다, 기본값은 비어 있음
client:
  socketTimeout: 1919810 # Long.MAX_VALUE가 기본값, 밀리초 단위
  connectionTimeout: 1919810 # Long.MAX_VALUE가 기본값, 밀리초 단위
  requestTimeout: 1919810 # Long.MAX_VALUE가 기본값, 밀리초 단위
  retry: 3 # 기본값입니다
  delayBeforeRetry: 1000 # 기본값입니다, 밀리초 단위

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
    modelList: # 기본값입니다
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # 기본값입니다
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # 기본값입니다
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