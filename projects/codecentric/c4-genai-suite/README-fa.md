# c4 GenAI Suite

یک برنامه چت‌بات هوش مصنوعی با ادغام فراهم‌کننده زمینه مدل (MCP)، مبتنی بر Langchain و سازگار با تمامی مدل‌های بزرگ زبانی (LLM) و مدل‌های تعبیه‌سازی.

مدیران می‌توانند با افزودن افزونه‌هایی مانند خدمات RAG (تولید تقویت‌شده با بازیابی) یا سرورهای MCP، دستیارانی با قابلیت‌های مختلف ایجاد کنند. این برنامه با استفاده از فناوری‌های مدرن، از جمله React، NestJS و Python FastAPI برای سرویس REI-S ساخته شده است.

کاربران می‌توانند از طریق یک رابط کاربری آسان با دستیاران تعامل داشته باشند. بسته به پیکربندی دستیار، کاربران ممکن است بتوانند سوال بپرسند، فایل‌های خود را بارگذاری کنند یا از سایر ویژگی‌ها استفاده کنند. دستیاران برای ارائه پاسخ بر اساس افزونه‌های پیکربندی‌شده، با ارائه‌دهندگان مختلف LLM تعامل دارند. اطلاعات زمینه‌ای که توسط افزونه‌های پیکربندی‌شده فراهم می‌شود، به دستیاران اجازه می‌دهد تا به سوالات خاص دامنه پاسخ دهند و اطلاعات مرتبط ارائه دهند.

این برنامه به صورت ماژولار و قابل توسعه طراحی شده است و به کاربران اجازه می‌دهد با افزودن افزونه‌ها، دستیارانی با قابلیت‌های مختلف ایجاد کنند.

![ویدیو کوتاه پیش‌نمایش از استفاده پایه](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## ویژگی‌ها

### مدل‌های بزرگ زبانی (LLM) و مدل‌های چندوجهی

مجموعه c4 GenAI در حال حاضر از بسیاری از مدل‌ها به صورت مستقیم پشتیبانی می‌کند. و اگر مدل مورد علاقه شما در حال حاضر پشتیبانی نمی‌شود، باید به راحتی بتوانید افزونه‌ای برای پشتیبانی از آن بنویسید.

* مدل‌های سازگار با OpenAI
* مدل‌های Azure OpenAI
* مدل‌های Bedrock
* مدل‌های Google GenAI
* مدل‌های سازگار با Ollama
### تولید افزوده بر اساس بازیابی (RAG)

پکیج c4 GenAI شامل REI-S است، یک سرور برای آماده‌سازی فایل‌ها جهت استفاده توسط LLM.

* REI-S، یک سرور RAG سفارشی و یکپارچه
  * پایگاه‌های برداری
    * pgvector
    * Azure AI Search
  * مدل‌های تعبیه‌سازی
    * تعبیه‌سازی سازگار با OpenAI
    * تعبیه‌سازی Azure OpenAI
    * تعبیه‌سازی سازگار با Ollama
  * قالب‌های فایل:
    * pdf، docx، pptx، xlsx، ...
    * رونویسی صدای فایل‌های صوتی (از طریق Whisper)

### افزونه‌ها

پکیج c4 GenAI برای توسعه‌پذیری طراحی شده است. نوشتن افزونه‌ها آسان است، همچنین استفاده از یک سرور MCP از پیش موجود نیز به سادگی انجام می‌شود.

* سرورهای پروتکل زمینه مدل (MCP)
* systemprompt سفارشی
* جستجوی Bing
* ماشین حساب
## شروع به کار

### استفاده از Docker-Compose

- در ریشه پروژه دستور `docker compose up` را اجرا کنید.
- [برنامه](http://localhost:3333) را در یک مرورگر باز کنید. اطلاعات ورود پیش‌فرض، کاربر `admin@example.com` و رمز عبور `secret` است.

![ویدیو نمایش تنظیمات دستیار](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### استفاده از Helm و Kubernetes

برای استقرار در محیط‌های Kubernetes، لطفاً به [فایل README چارت Helm ما](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md) مراجعه کنید.

### راه‌اندازی دستیارها و افزونه‌ها

مجموعه c4 GenAI حول محور *دستیارها* می‌چرخد.
هر دستیار شامل مجموعه‌ای از افزونه‌ها است که مدل LLM و ابزارهایی که می‌تواند استفاده کند را تعیین می‌کند.

- در بخش مدیریت (روی نام کاربری در پایین سمت چپ کلیک کنید)، به [بخش دستیارها](http://localhost:3333/admin/assistants) بروید.
- با دکمه سبز رنگ `+` کنار عنوان بخش، یک دستیار اضافه کنید. یک نام و توضیح انتخاب کنید.
- دستیار ایجاد شده را انتخاب کرده و روی دکمه سبز `+ افزودن افزونه` کلیک کنید.
- مدل را انتخاب کرده و اطلاعات دسترسی را وارد کنید.
- از دکمه `تست` برای بررسی عملکرد استفاده کنید و سپس `ذخیره` را بزنید.

اکنون می‌توانید به [صفحه چت](http://localhost:3333/chat) (روی `c4 GenAI Suite` در بالا سمت چپ کلیک کنید) بازگردید و یک گفتگوی جدید با دستیار خود آغاز کنید.

> [!نکته]
> `docker-compose` ما شامل یک Ollama محلی است که روی CPU اجرا می‌شود. می‌توانید از آن برای تست سریع استفاده کنید، اما کند خواهد بود و احتمالاً می‌خواهید از مدل دیگری استفاده کنید. اگر می‌خواهید از آن استفاده کنید، کافی است افزونه مدل زیر را در دستیار خود ایجاد کنید.
> * افزونه: `Dev: Ollama`
> * نقطه پایانی: `http://ollama:11434`
> * مدل: `llama3.2`
### پروتکل زمینه مدل (MCP) [اختیاری]

از هر سرور MCP که یک رابط `sse` با افزونه `MCP Tools` ارائه می‌دهد استفاده کنید (یا از `mcp-tool-as-server` ما به عنوان پراکسی در جلوی یک سرور MCP مبتنی بر `stdio` بهره بگیرید).
هر سرور MCP می‌تواند به صورت جزئی به عنوان یک افزونه پیکربندی شود.

### تولید افزوده با بازیابی (RAG) / جستجوی فایل [اختیاری]

از سرور RAG ما با نام `REI-S` برای جستجوی فایل‌های ارائه‌شده توسط کاربر استفاده کنید. تنها کافی است یک افزونه `Search Files` برای دستیار پیکربندی نمایید.
این فرآیند به طور کامل در [زیرشاخه `services/reis`](services/reis/#example-configuration-in-c4) شرح داده شده است.

## مشارکت و توسعه

* برای راهنمایی‌های مربوط به مشارکت، به [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) مراجعه کنید.
* برای آشنایی توسعه‌دهندگان، [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md) را بررسی کنید.

## اجزای اصلی

این برنامه از یک **فرانت‌اند**، یک **بک‌اند** و سرویس **REI-S** تشکیل شده است.

```
┌──────────┐
│   کاربر   │
└─────┬────┘
      │ دسترسی
      ▼
┌──────────┐
│   فرانت‌اند │
└─────┬────┘
      │ دسترسی
      ▼
┌──────────┐     ┌─────────────────┐
│  بک‌اند   │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ دسترسی
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ مدل تعبیه‌سازی   │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  ذخیره‌سازی برداری │
└──────────┘     └─────────────────┘
```
### فرانت‌اند

فرانت‌اند با استفاده از React و TypeScript ساخته شده است و یک رابط کاربری کاربرپسند برای تعامل با بک‌اند و سرویس REI-S فراهم می‌کند. این بخش شامل قابلیت‌هایی برای مدیریت دستیارها، افزونه‌ها و امکانات چت می‌باشد.

> منابع: `/frontend`

### بک‌اند

بک‌اند با استفاده از NestJS و TypeScript توسعه یافته است و به عنوان لایه اصلی API برای برنامه عمل می‌کند. این بخش درخواست‌های فرانت‌اند را مدیریت کرده و با ارائه‌دهندگان llm برای تسهیل قابلیت‌های چت تعامل دارد. بک‌اند همچنین مدیریت دستیارها و افزونه‌های آن‌ها را بر عهده دارد و به کاربران اجازه می‌دهد مدل‌های مختلف هوش مصنوعی را برای چت‌های خود پیکربندی و استفاده کنند.

علاوه بر این، بک‌اند مدیریت احراز هویت کاربران را انجام داده و با سرویس REI-S برای ایندکس‌گذاری و بازیابی فایل‌ها ارتباط برقرار می‌کند.

برای ماندگاری داده‌ها، بک‌اند از پایگاه داده **PostgreSQL** استفاده می‌کند.

> منابع: `/backend`

### REI-S

REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) یک سرور مبتنی بر پایتون است که قابلیت‌های پایه RAG (تولید افزوده‌شده با بازیابی) را ارائه می‌دهد. این سرویس امکان استخراج محتوا از فایل‌ها، ایندکس‌گذاری و جستجو را فراهم می‌کند و به برنامه اجازه می‌دهد تا مجموعه داده‌های بزرگ را به طور کارآمد مدیریت نماید. سرویس REI-S به گونه‌ای طراحی شده است که به طور یکپارچه با بک‌اند کار کند و داده‌های لازم برای قابلیت‌های چت و جستجوی فایل را فراهم آورد.

REI-S از Azure AI Search و pgvector برای ذخیره‌سازی برداری پشتیبانی می‌کند و گزینه‌های منعطف و مقیاس‌پذیری برای بازیابی داده‌ها ارائه می‌دهد. این سرویس را می‌توان با استفاده از متغیرهای محیطی برای تعیین نوع فروشگاه برداری و جزئیات اتصال پیکربندی کرد.

> منابع: `/services/reis`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---