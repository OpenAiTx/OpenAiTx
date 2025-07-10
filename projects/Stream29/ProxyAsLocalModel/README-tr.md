# ProxyAsLocalModel

Uzaktaki LLM API'sini yerel model olarak proxy'le. Özellikle JetBrains AI Assistant'ta özel LLM kullanımı için çalışır.

Ktor ve kotlinx.serialization tarafından desteklenmektedir. No-reflex özellikleri sayesinde.

## Bu projenin hikayesi

Şu anda JetBrains AI Assistant, çok sınırlı kotalı ücretsiz bir plan sunuyor. Denedim ve kotam hızla tükendi.

Zaten Gemini ve Qwen gibi başka LLM API tokenları satın almıştım. Bu yüzden bunları AI Assistant'ta kullanmayı düşünmeye başladım. Ne yazık ki, yalnızca LM Studio ve Ollama'nın yerel modelleri destekleniyor. Bu nedenle, üçüncü parti LLM API'sini LM Studio ve Ollama API'si olarak proxy'leyen ve böylece JetBrains IDE'lerimde kullanabilmemi sağlayan bu proxy uygulaması üzerinde çalışmaya başladım.

Bu sadece basit bir iş, bu yüzden istemci olarak resmi SDK'ları kullanıp LM Studio ve Ollama olarak endpoint sağlayan basit bir Ktor sunucusu yazmaya başladım. Sorun, bunu GraalVM native image olarak dağıtmaya çalıştığımda ortaya çıktı. Resmi Java SDK'ları çok fazla dinamik özellik kullanıyor, bu da tracing agent ile bile native image olarak derlemeyi zorlaştırıyor. Bu yüzden, hem no-reflex, fonksiyonel ve DSL tarzında olan Ktor ve kotlinx.serialization ile streaming chat completion API için basit bir istemciyi kendim yazmaya karar verdim.

Görüldüğü üzere, bu uygulama platformlar arası ve hızlı başlatılabilen bir fat runnable jar ve GraalVM native image olarak dağıtılmaktadır.

Bu uygulamanın geliştirilmesi bana Kotlin/Ktor/kotlinx.serialization konusunda güven verdi. Kotlin dünyası daha fazla fonksiyonel programlama ve daha az refleksiyon kullanıyor, bu da onu GraalVM native image için daha uygun, daha hızlı başlatılan ve daha az bellek kullanan bir hale getiriyor.

## Şu anda desteklenenler

Proxy kaynakları: OpenAI, Claude, DashScope(Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy olarak: LM Studio, Ollama.

Sadece streaming chat completion API.
## Nasıl Kullanılır

Bu uygulama bir proxy sunucusudur ve çalıştırılabilir fat jar ile GraalVM yerel görüntüsü (Windows x64) olarak dağıtılır.

Uygulamayı çalıştırın, ardından bir yardım mesajı göreceksiniz:

```
2025-05-02 10:43:53 INFO  Help - Görünüşe göre programı burada ilk kez başlatıyorsunuz.
2025-05-02 10:43:53 INFO  Help - Varsayılan bir yapılandırma dosyası your_path\config.yml konumunda şema açıklamalarıyla oluşturuldu.
2025-05-02 10:43:53 INFO  Config - Yapılandırma dosyası izleyicisi your_path\config.yml konumunda başlatıldı
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio Sunucusu 1234 üzerinde başlatıldı
2025-05-02 10:43:53 INFO  Ollama Server - Ollama Sunucusu 11434 üzerinde başlatıldı
2025-05-02 10:43:53 INFO  Model List - Model listesi şu şekilde yüklendi: []
```

Daha sonra proxy sunucunuzu kurmak için yapılandırma dosyasını düzenleyebilirsiniz.

## Yapılandırma Dosyası

Bu yapılandırma dosyası, siz değiştirdiğinizde otomatik olarak sıcak yeniden yüklenir. Sunucunun yalnızca etkilenen bölümleri güncellenecektir.

Yapılandırma dosyası ilk oluşturulduğunda, şema açıklamaları ile birlikte gelir. Bu, editörünüzde tamamlama ve kontrol imkanı sağlar.
## Örnek yapılandırma dosyası

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Bu varsayılan değerdir
  enabled: true # Bu varsayılan değerdir
  host: 0.0.0.0 # Bu varsayılan değerdir
  path: /your/path # Orijinal uç noktalardan önce eklenecek, varsayılan değeri boştur
ollama:
  port: 11434 # Bu varsayılan değerdir
  enabled: true # Bu varsayılan değerdir
  host: 0.0.0.0 # Bu varsayılan değerdir
  path: /your/path # Orijinal uç noktalardan önce eklenecek, varsayılan değeri boştur
client:
  socketTimeout: 1919810 # Varsayılan değer Long.MAX_VALUE'dur, milisaniye cinsindendir
  connectionTimeout: 1919810 # Varsayılan değer Long.MAX_VALUE'dur, milisaniye cinsindendir
  requestTimeout: 1919810 # Varsayılan değer Long.MAX_VALUE'dur, milisaniye cinsindendir
  retry: 3 # Bu varsayılan değerdir
  delayBeforeRetry: 1000 # Bu varsayılan değerdir, milisaniye cinsindendir

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
    modelList: # Bu varsayılan değerdir
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # Bu varsayılan değerdir
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # Bu varsayılan değerdir
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