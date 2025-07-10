# ProxyAsLocalModel

وكيل API لنموذج LLM البعيد كنموذج محلي. يعمل بشكل خاص لاستخدام نماذج LLM المخصصة في مساعد JetBrains AI.

مدعوم من Ktor و kotlinx.serialization. شكرًا لميزاتهما الخالية من الانعكاس.

## قصة هذا المشروع

حاليًا، يوفر مساعد JetBrains AI خطة مجانية مع حصص محدودة جدًا. جربتها ونفذت حصتي بسرعة.

لقد اشتريت بالفعل رموز API لنماذج LLM أخرى، مثل Gemini و Qwen. لذلك بدأت أفكر في استخدامها في المساعد الذكي. للأسف، لا يتم دعم سوى النماذج المحلية من LM Studio و Ollama. لذا بدأت العمل على هذا التطبيق الوكيل الذي يقوم بوساطة واجهة برمجة التطبيقات LLM التابعة لجهات خارجية ليتم تقديمها كـ LM Studio و Ollama API حتى أتمكن من استخدامها في بيئات JetBrains IDEs الخاصة بي.

هذه مهمة بسيطة فقط، لذا بدأت باستخدام الحزم البرمجية الرسمية كعملاء وكتبت خادم Ktor بسيط يوفر نقاط نهاية مثل LM Studio و Ollama. ظهرت المشكلة عندما حاولت توزيعه كصورة أصلية لـ GraalVM. تستخدم الحزم البرمجية الرسمية لجافا العديد من الميزات الديناميكية، مما يجعل من الصعب تجميعها كصورة أصلية، حتى مع وكيل تتبع. لذلك قررت تنفيذ عميل بسيط لواجهة برمجة تطبيقات إكمال الدردشة المتدفقة بنفسي باستخدام Ktor و kotlinx.serialization، وكلاهما خالي من الانعكاس، وظيفي، وأسلوبه قائم على DSL.

كما ترى، يتم توزيع هذا التطبيق كملف jar قابل للتشغيل وكصورة أصلية لـ GraalVM، مما يجعله متعدد المنصات وسريع التشغيل.

منحني تطوير هذا التطبيق ثقة في Kotlin/Ktor/kotlinx.serialization. يستخدم عالم Kotlin برمجة وظيفية أكثر وانعكاسًا أقل، مما يجعله أكثر ملاءمة لصورة GraalVM الأصلية، مع بدء تشغيل أسرع واستخدام أقل للذاكرة.

## المدعوم حاليًا

الوكالة من: OpenAI، Claude، DashScope (Alibaba Qwen)، Gemini، Deepseek، Mistral، SiliconFlow.

الوكالة كـ: LM Studio، Ollama.

واجهة برمجة تطبيقات إكمال الدردشة المتدفقة فقط.
## كيفية الاستخدام

هذا التطبيق هو خادم وكيل (بروكسي)، يتم توزيعه كملف jar قابل للتشغيل بشكل مستقل وكتصوير أصلي لـ GraalVM (Windows x64).

قم بتشغيل التطبيق، وسترى رسالة مساعدة:

```
2025-05-02 10:43:53 INFO  Help - يبدو أنك تقوم بتشغيل البرنامج لأول مرة هنا.
2025-05-02 10:43:53 INFO  Help - تم إنشاء ملف الإعداد الافتراضي في your_path\config.yml مع توضيحات المخطط.
2025-05-02 10:43:53 INFO  Config - تم بدء مراقب ملف الإعدادات في your_path\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - تم بدء خادم LM Studio على المنفذ 1234
2025-05-02 10:43:53 INFO  Ollama Server - تم بدء خادم Ollama على المنفذ 11434
2025-05-02 10:43:53 INFO  Model List - تم تحميل قائمة النماذج مع: []
```

بعد ذلك يمكنك تعديل ملف الإعدادات لضبط خادم الوكيل الخاص بك.

## ملف الإعدادات

يتم إعادة تحميل ملف الإعدادات تلقائيًا عند تغييره. سيتم تحديث الأجزاء المتأثرة فقط من الخادم.

عند إنشاء ملف الإعدادات لأول مرة، سيتم إنشاؤه مع توضيحات المخطط. هذا سيوفر الإكمال والفحص في محررك.
## مثال على ملف الإعدادات

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # هذه هي القيمة الافتراضية
  enabled: true # هذه هي القيمة الافتراضية
  host: 0.0.0.0 # هذه هي القيمة الافتراضية
  path: /your/path # سيتم إضافته قبل نقاط النهاية الأصلية، القيمة الافتراضية فارغة
ollama:
  port: 11434 # هذه هي القيمة الافتراضية
  enabled: true # هذه هي القيمة الافتراضية
  host: 0.0.0.0 # هذه هي القيمة الافتراضية
  path: /your/path # سيتم إضافته قبل نقاط النهاية الأصلية، القيمة الافتراضية فارغة
client:
  socketTimeout: 1919810 # القيمة الافتراضية هي Long.MAX_VALUE، بالمللي ثانية
  connectionTimeout: 1919810 # القيمة الافتراضية هي Long.MAX_VALUE، بالمللي ثانية
  requestTimeout: 1919810 # القيمة الافتراضية هي Long.MAX_VALUE، بالمللي ثانية
  retry: 3 # هذه هي القيمة الافتراضية
  delayBeforeRetry: 1000 # هذه هي القيمة الافتراضية، بالمللي ثانية

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
    modelList: # هذه هي القيمة الافتراضية
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # هذه هي القيمة الافتراضية
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # هذه هي القيمة الافتراضية
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