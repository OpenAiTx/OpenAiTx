# ProxyAsLocalModel

Proxy API LLM từ xa như một mô hình cục bộ. Đặc biệt hoạt động hiệu quả khi sử dụng LLM tùy chỉnh trong JetBrains AI Assistant.

Được phát triển bởi Ktor và kotlinx.serialization. Cảm ơn các tính năng không sử dụng phản xạ của chúng.

## Câu chuyện về dự án này

Hiện tại, JetBrains AI Assistant cung cấp một gói miễn phí với hạn mức rất hạn chế. Tôi đã thử sử dụng và hạn mức của tôi nhanh chóng hết.

Tôi đã mua các token API LLM khác, như Gemini và Qwen. Vì vậy, tôi bắt đầu nghĩ đến việc sử dụng chúng trong AI Assistant. Thật không may, chỉ có các mô hình cục bộ từ LM Studio và Ollama được hỗ trợ. Vì vậy, tôi bắt đầu phát triển ứng dụng proxy này, cho phép proxy API LLM bên thứ ba thành API của LM Studio và Ollama để tôi có thể sử dụng chúng trong các IDE JetBrains của mình.

Đây chỉ là một tác vụ đơn giản, vì vậy tôi bắt đầu sử dụng các SDK chính thức như các client và viết một server Ktor đơn giản cung cấp các endpoint như LM Studio và Ollama. Vấn đề xuất hiện khi tôi cố gắng phân phối nó dưới dạng native image của GraalVM. Các SDK Java chính thức sử dụng quá nhiều tính năng động, khiến cho việc biên dịch thành native image trở nên khó khăn, ngay cả khi sử dụng tracing agent. Vì vậy, tôi quyết định tự mình triển khai một client đơn giản cho API streaming chat completion bằng Ktor và kotlinx.serialization, cả hai đều không sử dụng phản xạ, có tính chức năng và kiểu DSL.

Như bạn có thể thấy, ứng dụng này được phân phối dưới dạng một fat runnable jar và native image GraalVM, giúp nó đa nền tảng và khởi động nhanh.

Việc phát triển ứng dụng này giúp tôi tự tin hơn với Kotlin/Ktor/kotlinx.serialization. Thế giới Kotlin sử dụng nhiều lập trình hàm hơn và ít phản xạ hơn, điều này khiến nó phù hợp hơn với native image của GraalVM, với thời gian khởi động nhanh hơn và sử dụng bộ nhớ ít hơn.

## Hiện tại hỗ trợ

Proxy từ: OpenAI, Claude, DashScope (Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy thành: LM Studio, Ollama.

Chỉ hỗ trợ API hoàn thành chat dạng streaming.
## Cách sử dụng

Ứng dụng này là một máy chủ proxy, được phân phối dưới dạng một file jar chạy độc lập và một image native GraalVM (Windows x64).

Chạy ứng dụng, bạn sẽ thấy một thông báo trợ giúp:

```
2025-05-02 10:43:53 INFO  Help - Có vẻ như bạn đang khởi động chương trình lần đầu tiên tại đây.
2025-05-02 10:43:53 INFO  Help - Một file cấu hình mặc định đã được tạo tại your_path\config.yml với chú thích schema.
2025-05-02 10:43:53 INFO  Config - Bộ theo dõi file cấu hình đã bắt đầu tại your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - Máy chủ LM Studio đã khởi động tại 1234
2025-05-02 10:43:53 INFO  Ollama Server - Máy chủ Ollama đã khởi động tại 11434
2025-05-02 10:43:53 INFO  Model List - Danh sách mô hình đã được tải với: []
```

Sau đó, bạn có thể chỉnh sửa file cấu hình để thiết lập máy chủ proxy của mình.

## File cấu hình

File cấu hình này sẽ tự động được tải lại khi bạn thay đổi nó. Chỉ những phần bị ảnh hưởng của máy chủ mới được cập nhật.

Khi lần đầu tạo file cấu hình, nó sẽ được tạo với chú thích schema. Điều này sẽ giúp bạn hoàn thành và kiểm tra trong trình soạn thảo của mình.
## Ví dụ tập tin cấu hình

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Đây là giá trị mặc định
  enabled: true # Đây là giá trị mặc định
  host: 0.0.0.0 # Đây là giá trị mặc định
  path: /your/path # Sẽ được thêm trước các endpoint gốc, giá trị mặc định là rỗng
ollama:
  port: 11434 # Đây là giá trị mặc định
  enabled: true # Đây là giá trị mặc định
  host: 0.0.0.0 # Đây là giá trị mặc định
  path: /your/path # Sẽ được thêm trước các endpoint gốc, giá trị mặc định là rỗng
client:
  socketTimeout: 1919810 # Long.MAX_VALUE là giá trị mặc định, tính bằng mili giây
  connectionTimeout: 1919810 # Long.MAX_VALUE là giá trị mặc định, tính bằng mili giây
  requestTimeout: 1919810 # Long.MAX_VALUE là giá trị mặc định, tính bằng mili giây
  retry: 3 # Đây là giá trị mặc định
  delayBeforeRetry: 1000 # Đây là giá trị mặc định, tính bằng mili giây

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
    modelList: # Đây là giá trị mặc định
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # Đây là giá trị mặc định
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # Đây là giá trị mặc định
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