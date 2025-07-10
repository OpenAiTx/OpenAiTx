# ProxyAsLocalModel

پراکسی API مدل زبان بزرگ (LLM) راه دور به عنوان مدل محلی. به ویژه برای استفاده از LLM سفارشی در JetBrains AI Assistant مناسب است.

با قدرت گرفته از Ktor و kotlinx.serialization. با تشکر از ویژگی‌های بدون بازتاب آن‌ها.

## داستان این پروژه

در حال حاضر، JetBrains AI Assistant یک پلن رایگان با سهمیه بسیار محدود ارائه می‌دهد. من امتحان کردم و سهمیه من خیلی زود تمام شد.

من قبلاً توکن‌های API مدل‌های LLM دیگر، مانند Gemini و Qwen را خریده‌ام. بنابراین شروع به فکر کردن درباره استفاده از آن‌ها در AI Assistant کردم. متاسفانه، فقط مدل‌های محلی از LM Studio و Ollama پشتیبانی می‌شوند. بنابراین شروع به کار روی این برنامه پراکسی کردم که API مدل‌های LLM شخص ثالث را به عنوان APIهای LM Studio و Ollama پراکسی می‌کند تا بتوانم از آن‌ها در IDEهای JetBrains خود استفاده کنم.

این یک کار ساده بود، بنابراین شروع به استفاده از SDKهای رسمی به عنوان کلاینت و نوشتن یک سرور ساده Ktor کردم که اندپوینت‌هایی مانند LM Studio و Ollama ارائه می‌دهد. مشکل زمانی ظاهر شد که سعی کردم آن را به عنوان یک تصویر بومی GraalVM توزیع کنم. SDKهای رسمی جاوا از ویژگی‌های پویا زیادی استفاده می‌کنند که کامپایل آن به یک تصویر بومی را حتی با عامل رهگیری دشوار می‌کند. بنابراین تصمیم گرفتم یک کلاینت ساده برای API تکمیل چت استریمینگ با Ktor و kotlinx.serialization که هر دو بدون بازتاب، فانکشنال و با سبک DSL هستند، پیاده‌سازی کنم.

همانطور که می‌بینید، این برنامه به صورت یک jar اجرایی fat و یک تصویر بومی GraalVM توزیع می‌شود که آن را چندسکویی و سریع‌الاجرا می‌کند.

توسعه این برنامه به من اعتماد به نفس در Kotlin/Ktor/kotlinx.serialization داده است. دنیای Kotlin بیشتر از برنامه‌نویسی تابعی و کمتر از بازتاب استفاده می‌کند، که آن را برای تصویر بومی GraalVM مناسب‌تر می‌کند، با راه‌اندازی سریع‌تر و مصرف حافظه کمتر.

## پشتیبانی فعلی

پراکسی از: OpenAI، Claude، DashScope (Alibaba Qwen)، Gemini، Deepseek، Mistral، SiliconFlow.

پراکسی به عنوان: LM Studio، Ollama.

فقط API تکمیل چت به صورت استریمینگ.
## نحوه استفاده

این برنامه یک سرور پروکسی است که به صورت یک فایل jar اجرایی (fat runnable jar) و یک ایمیج بومی GraalVM (ویندوز x64) توزیع شده است.

برنامه را اجرا کنید، و یک پیام راهنما مشاهده خواهید کرد:

```
2025-05-02 10:43:53 INFO  Help - به نظر می‌رسد که برای اولین بار برنامه را در اینجا اجرا می‌کنید.
2025-05-02 10:43:53 INFO  Help - یک فایل پیکربندی پیش‌فرض در your_path\config.yml با توضیحات طرح‌واره ایجاد شد.
2025-05-02 10:43:53 INFO  Config - پایشگر فایل پیکربندی در your_path\config.yml آغاز شد
2025-05-02 10:43:53 INFO  LM Studio Server - سرور LM Studio در 1234 راه‌اندازی شد
2025-05-02 10:43:53 INFO  Ollama Server - سرور Ollama در 11434 راه‌اندازی شد
2025-05-02 10:43:53 INFO  Model List - لیست مدل با: [] بارگذاری شد
```

سپس می‌توانید فایل پیکربندی را برای راه‌اندازی سرور پروکسی خود ویرایش کنید.

## فایل پیکربندی

این فایل پیکربندی به طور خودکار هنگام تغییر، به صورت داغ (hot-reload) بارگذاری مجدد می‌شود. فقط بخش‌های تأثیرپذیر سرور به‌روزرسانی خواهند شد.

هنگام تولید اولیه فایل پیکربندی، این فایل با توضیحات طرح‌واره ایجاد خواهد شد. این کار تکمیل خودکار و بررسی در ویرایشگر شما را به همراه دارد.
## نمونه فایل پیکربندی

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # این مقدار پیش‌فرض است
  enabled: true # این مقدار پیش‌فرض است
  host: 0.0.0.0 # این مقدار پیش‌فرض است
  path: /your/path # قبل از نقاط پایانی اصلی اضافه می‌شود، مقدار پیش‌فرض خالی است
ollama:
  port: 11434 # این مقدار پیش‌فرض است
  enabled: true # این مقدار پیش‌فرض است
  host: 0.0.0.0 # این مقدار پیش‌فرض است
  path: /your/path # قبل از نقاط پایانی اصلی اضافه می‌شود، مقدار پیش‌فرض خالی است
client:
  socketTimeout: 1919810 # Long.MAX_VALUE مقدار پیش‌فرض است، بر حسب میلی‌ثانیه
  connectionTimeout: 1919810 # Long.MAX_VALUE مقدار پیش‌فرض است، بر حسب میلی‌ثانیه
  requestTimeout: 1919810 # Long.MAX_VALUE مقدار پیش‌فرض است، بر حسب میلی‌ثانیه
  retry: 3 # این مقدار پیش‌فرض است
  delayBeforeRetry: 1000 # این مقدار پیش‌فرض است، بر حسب میلی‌ثانیه

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
    modelList: # این مقدار پیش‌فرض است
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # این مقدار پیش‌فرض است
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # این مقدار پیش‌فرض است
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