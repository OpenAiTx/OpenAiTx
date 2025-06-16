# AgenticSeek: بديل Manus محلي وخاص.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="شعار Agentic Seek">
<p>

الإنجليزية | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*بديل **محلي 100% لـ Manus AI**، هذا المساعد الذكي الصوتي قادر على تصفح الإنترنت بشكل ذاتي، وكتابة الشيفرات، وتخطيط المهام مع الحفاظ على جميع البيانات على جهازك. مصمم خصيصاً لنماذج الذكاء الاصطناعي المحلية، يعمل بالكامل على عتادك، مما يضمن خصوصية تامة وعدم الاعتماد على السحابة.*

[![زيارة AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![الرخصة](https://img.shields.io/badge/license-GPL--3.0-green) [![ديسكورد](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![تويتر](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![نجوم GitHub](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### لماذا AgenticSeek؟

* 🔒 محلي وخاص بالكامل - كل شيء يعمل على جهازك — بدون سحابة، بدون مشاركة بيانات. ملفاتك، محادثاتك، وبحثك يبقى خاصاً.

* 🌐 تصفح ويب ذكي - يمكن لـ AgenticSeek تصفح الإنترنت ذاتياً — البحث، القراءة، استخراج المعلومات، تعبئة النماذج — دون تدخل منك.

* 💻 مساعد برمجي مستقل - تحتاج إلى شيفرة؟ يمكنه كتابة، تصحيح، وتشغيل البرامج بلغة بايثون، سي، جو، جافا، وغيرها — دون إشراف.

* 🧠 اختيار ذكي للوكلاء - تسأل، وهو يحدد تلقائياً أفضل وكيل للمهمة. وكأن لديك فريق خبراء جاهز للمساعدة.

* 📋 تخطيط وتنفيذ المهام المعقدة - من تخطيط الرحلات إلى المشاريع المعقدة — يمكنه تقسيم المهام الكبيرة إلى خطوات وإنجازها باستخدام عدة وكلاء ذكاء اصطناعي.

* 🎙️ مدعوم بالصوت - تحويل صوتي سريع وحديث يتيح لك التحدث إليه كما لو أنه ذكاءك الاصطناعي الشخصي من أفلام الخيال العلمي. (قيد التنفيذ)

### **عرض توضيحي**

> *هل يمكنك البحث عن مشروع agenticSeek، معرفة المهارات المطلوبة، ثم فتح ملف CV_candidates.zip ثم إخباري أيهم الأنسب للمشروع؟*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

إخلاء مسؤولية: هذا العرض التوضيحي، بما في ذلك جميع الملفات الظاهرة (مثل: CV_candidates.zip)، كلها خيالية بالكامل. لسنا مؤسسة تجارية، نبحث عن مساهمين مفتوح المصدر وليس مرشحين.

> 🛠⚠️️ **جاري العمل بنشاط**

> 🙏 هذا المشروع بدأ كمشروع جانبي ولا يوجد له خارطة طريق أو تمويل. نما أكثر مما توقعت حتى وصل إلى قائمة الترند في GitHub. نقدر المساهمات، التغذية الراجعة، وصبركم بشدة.

## المتطلبات الأساسية

قبل البدء، تأكد من تثبيت البرامج التالية:

*   **Git:** لاستنساخ المستودع. [تحميل Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** ننصح بشدة باستخدام إصدار بايثون 3.10.x. استخدام إصدارات أخرى قد يؤدي إلى مشاكل في الاعتماديات. [تحميل Python 3.10](https://www.python.org/downloads/release/python-3100/) (اختر إصدار 3.10.x).
*   **Docker Engine و Docker Compose:** لتشغيل الخدمات المجمعة مثل SearxNG.
    *   تثبيت Docker Desktop (يشمل Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   أو يمكنك تثبيت Docker Engine وDocker Compose بشكل منفصل على لينكس: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (تأكد من تثبيت Compose V2، مثلاً: `sudo apt-get install docker-compose-plugin`).

### 1. **استنساخ المستودع والإعداد**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. تغيير محتوى ملف .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```


قم بتحديث ملف `.env` بقيمك الخاصة حسب الحاجة:

- **SEARXNG_BASE_URL**: اتركها كما هي 
- **REDIS_BASE_URL**: اتركها كما هي 
- **WORK_DIR**: مسار مجلد العمل على جهازك المحلي. سيتمكن AgenticSeek من قراءة والتفاعل مع هذه الملفات.
- **OLLAMA_PORT**: رقم المنفذ لخدمة Ollama.
- **LM_STUDIO_PORT**: رقم المنفذ لخدمة LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT**: منفذ لأي خدمة LLM إضافية مخصصة.

**مفاتيح API اختيارية تماماً للمستخدمين الذين يختارون تشغيل LLM محلياً. وهو الغرض الأساسي لهذا المشروع. اتركها فارغة إذا كان لديك عتاد كافٍ**

### 3. **تشغيل Docker**

تأكد من تثبيت Docker وتشغيله على نظامك. يمكنك بدء Docker باستخدام الأوامر التالية:

- **على Linux/macOS:**  
    افتح الطرفية ونفذ:
    ```sh
    sudo systemctl start docker
    ```
    أو شغل Docker Desktop من قائمة التطبيقات إذا كان مثبتاً.

- **على Windows:**  
    شغل Docker Desktop من قائمة البدء.

يمكنك التأكد من أن Docker يعمل بتنفيذ:
```sh
docker info
```
إذا ظهرت لك معلومات حول تثبيت Docker، فهو يعمل بشكل صحيح.

انظر جدول [المزودين المحليين](#list-of-local-providers) أدناه للملخص.

الخطوة التالية: [تشغيل AgenticSeek محلياً](#start-services-and-run)

*راجع قسم [استكشاف الأخطاء وإصلاحها](#troubleshooting) إذا واجهت مشاكل.*
*إذا كان عتادك لا يستطيع تشغيل LLMs محلياً، راجع [الإعداد للتشغيل مع API](#setup-to-run-with-an-api).*
*لشرح مفصل لـ `config.ini`، راجع [قسم الإعدادات](#config).*

---

## الإعداد لتشغيل LLM محلياً على جهازك

**متطلبات العتاد:**

لتشغيل LLMs محلياً، تحتاج إلى عتاد كافٍ. الحد الأدنى المطلوب هو GPU قادر على تشغيل Magistral أو Qwen أو Deepseek 14B. راجع الأسئلة الشائعة لمزيد من التوصيات حول النماذج/الأداء.

**إعداد المزود المحلي**  

ابدأ مزودك المحلي، مثلاً عبر ollama:

```sh
ollama serve
```

انظر أدناه قائمة المزودين المحليين المدعومين.

**تحديث config.ini**

عدل ملف config.ini ليحتوي على provider_name باسم مزود مدعوم و provider_model باسم نموذج LLM مدعوم من مزودك. ننصح بنماذج الاستدلال مثل *Magistral* أو *Deepseek*.

راجع **الأسئلة الشائعة** بنهاية README لمتطلبات العتاد.

```sh
[MAIN]
is_local = True # هل تعمل محلياً أو مع مزود عن بعد.
provider_name = ollama # أو lm-studio، openai، إلخ..
provider_model = deepseek-r1:14b # اختر نموذجاً يناسب عتادك
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # اسم الذكاء الاصطناعي الخاص بك
recover_last_session = True # استعادة الجلسة السابقة
save_session = True # حفظ الجلسة الحالية
speak = False # تحويل النص إلى كلام
listen = False # تحويل الكلام إلى نص، فقط للواجهة الطرفية، تجريبي
jarvis_personality = False # استخدام شخصية "جارفيس" (تجريبي)
languages = en zh # قائمة اللغات، الافتراضي للنطق هو أول لغة في القائمة
[BROWSER]
headless_browser = True # اتركها كما هي إلا إذا كنت تستخدم CLI على المضيف.
stealth_mode = True # استخدام selenium غير مكشوف لتقليل كشف المتصفح
```

**تحذير**:

- صيغة ملف `config.ini` لا تدعم التعليقات.
لا تقم بنسخ ولصق إعداد التكوين مباشرة، لأن التعليقات ستسبب أخطاء. بدلاً من ذلك، عدل ملف `config.ini` يدوياً حسب إعداداتك بدون أي تعليقات.

- *لا* تضع provider_name كـ `openai` إذا كنت تستخدم LM-studio لتشغيل LLMs. اجعلها `lm-studio`.

- بعض المزودين (مثلاً: lm-studio) يتطلب أن تبدأ الـ IP بـ `http://`. مثال: `http://127.0.0.1:1234`

**قائمة المزودين المحليين**

| المزود      | محلي؟ | الوصف                                                      |
|-------------|-------|------------------------------------------------------------|
| ollama      | نعم   | تشغيل LLMs محلياً بسهولة باستخدام ollama كمزود LLM         |
| lm-studio   | نعم   | تشغيل LLM محلياً مع LM studio (اجعل `provider_name` هو `lm-studio`)|
| openai      | نعم   | استخدام API متوافق مع openai (مثلاً: خادم llama.cpp)       |

الخطوة التالية: [بدء الخدمات وتشغيل AgenticSeek](#Start-services-and-Run)  

*راجع قسم [استكشاف الأخطاء وإصلاحها](#troubleshooting) إذا واجهت مشاكل.*
*إذا كان عتادك لا يستطيع تشغيل LLMs محلياً، راجع [الإعداد للتشغيل مع API](#setup-to-run-with-an-api).*
*لشرح مفصل لـ `config.ini`، راجع [قسم الإعدادات](#config).*

## الإعداد للتشغيل عبر API

هذا الإعداد يستخدم مزودي LLM السحابيين الخارجيين. ستحتاج إلى مفتاح API من مزود الخدمة الذي تختاره.

**1. اختر مزود API واحصل على مفتاح API:**

راجع [قائمة مزودي API](#list-of-api-providers) أدناه. زر مواقعهم للحصول على مفتاح API.

**2. ضع مفتاح API كمتغير بيئة:**


*   **Linux/macOS:**
    افتح الطرفية واستخدم أمر `export`. يفضل إضافته إلى ملف إعدادات الصدفة (مثل: `~/.bashrc`, `~/.zshrc`) ليستمر بعد إعادة التشغيل.
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # استبدل PROVIDER_API_KEY باسم المتغير المناسب، مثل OPENAI_API_KEY أو GOOGLE_API_KEY
    ```
    مثال لـ TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **موجه الأوامر (مؤقت للجلسة الحالية):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (مؤقت للجلسة الحالية):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **دائمًا:** ابحث عن "environment variables" في شريط بحث ويندوز، ثم اضغط "Edit the system environment variables"، ثم اضغط على زر "Environment Variables...". أضف متغير مستخدم جديد بالاسم المناسب (مثلًا، `OPENAI_API_KEY`) وضع مفتاحك كقيمة.

*(انظر الأسئلة الشائعة: [كيف أضبط مفاتيح API؟](#how-do-i-set-api-keys) للمزيد من التفاصيل).*

**3. تحديث `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # أو google، deepseek، togetherAI، huggingface
provider_model = gpt-3.5-turbo # أو gemini-1.5-flash، deepseek-chat، mistralai/Mixtral-8x7B-Instruct-v0.1 الخ.
provider_server_address = # غالبًا يتم تجاهله أو يمكن تركه فارغًا عندما is_local = False لمعظم واجهات الـ API
# ... إعدادات أخرى ...
```
*تحذير:* تأكد من عدم وجود مسافات زائدة في قيم `config.ini`.

**قائمة مزودي واجهة API**

| المزود         | `provider_name`  | محلي؟ | الوصف                                              | رابط مفتاح API (أمثلة)                               |
|----------------|------------------|--------|----------------------------------------------------|------------------------------------------------------|
| OpenAI         | `openai`         | لا     | استخدم نماذج ChatGPT عبر واجهة OpenAI API.         | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini  | `google`         | لا     | استخدم نماذج Google Gemini عبر Google AI Studio.   | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek       | `deepseek`       | لا     | استخدم نماذج Deepseek عبر واجهتهم البرمجية.        | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face   | `huggingface`    | لا     | استخدم النماذج من Hugging Face Inference API.      | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI     | `togetherAI`     | لا     | استخدم نماذج مفتوحة المصدر متنوعة عبر TogetherAI API.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*ملاحظة:*
*   ننصح بعدم استخدام `gpt-4o` أو نماذج OpenAI الأخرى للمهام المعقدة لتصفح الويب والتخطيط، حيث أن تحسينات المطالبات الحالية موجهة نحو نماذج مثل Deepseek.
*   قد تواجه مهام البرمجة/bash مشاكل مع Gemini لأنه قد لا يلتزم بدقة بتنسيق المطالبات المهيأة لـ Deepseek.
*   عادةً لا يتم استخدام `provider_server_address` في `config.ini` عندما تكون `is_local = False` لأن نقطة نهاية الـ API غالبًا ما تكون معرفة مسبقًا في مكتبة المزود.

الخطوة التالية: [بدء الخدمات وتشغيل AgenticSeek](#Start-services-and-Run)

*انظر قسم **المشاكل المعروفة** إذا واجهتك مشاكل.*

*انظر قسم **الإعدادات** لشرح تفصيلي لملف الإعداد.*

---

## بدء الخدمات والتشغيل

بشكل افتراضي، يتم تشغيل AgenticSeek بالكامل داخل Docker.

قم بتشغيل الخدمات المطلوبة. سيؤدي هذا إلى تشغيل جميع الخدمات من docker-compose.yml، بما في ذلك:
- searxng
- redis (مطلوب من searxng)
- الواجهة الأمامية
- الواجهة الخلفية (إذا كنت تستخدم `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Windows
```

**تحذير:** ستقوم هذه الخطوة بتنزيل وتحميل جميع صور Docker، وقد يستغرق ذلك حتى 30 دقيقة. بعد بدء الخدمات، يرجى الانتظار حتى تعمل خدمة الواجهة الخلفية بالكامل (يجب أن ترى **backend: "GET /health HTTP/1.1" 200 OK** في السجل) قبل إرسال أي رسائل. قد تستغرق خدمات الواجهة الخلفية حوالي 5 دقائق للتشغيل في أول مرة.

اذهب إلى `http://localhost:3000/` ويجب أن ترى واجهة الويب.

*استكشاف أخطاء بدء الخدمة:* إذا فشلت هذه السكربتات، تأكد من أن Docker Engine يعمل وأن Docker Compose (V2, `docker compose`) مثبت بشكل صحيح. تحقق من المخرجات في الطرفية لرسائل الخطأ. انظر [الأسئلة الشائعة: المساعدة! أحصل على خطأ عند تشغيل AgenticSeek أو سكربتاته.](#faq-troubleshooting)

**اختياري:** التشغيل على المضيف (وضع سطر الأوامر CLI):

لتشغيل الواجهة النصية يجب عليك تثبيت الحزمة على المضيف:

```sh
./install.sh
./install.bat # windows
```

تشغيل الخدمات:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Windows
```

استخدم CLI: `python3 cli.py`

---

## الاستخدام

تأكد من أن الخدمات تعمل باستخدام `./start_services.sh full` ثم اذهب إلى `localhost:3000` لواجهة الويب.

يمكنك أيضًا استخدام تحويل الكلام إلى نص عن طريق ضبط `listen = True` في الإعدادات. فقط في وضع CLI.

لإنهاء البرنامج، فقط قل/اكتب `goodbye`.

فيما يلي بعض أمثلة الاستخدام:

> *أنشئ لعبة الثعبان بلغة بايثون!*

> *ابحث في الويب عن أفضل المقاهي في رين، فرنسا، واحفظ قائمة بثلاثة منها مع عناوينها في rennes_cafes.txt.*

> *اكتب برنامج Go لحساب مضروب عدد واحفظه باسم factorial.go في مساحة العمل الخاصة بك*

> *ابحث في مجلد summer_pictures عن جميع ملفات JPG، أعد تسميتها بتاريخ اليوم، واحفظ قائمة الملفات المعاد تسميتها في photos_list.txt*

> *ابحث عبر الإنترنت عن أشهر أفلام الخيال العلمي لعام 2024 واختر ثلاثة لمشاهدتها الليلة. احفظ القائمة في movie_night.txt.*

> *ابحث في الويب عن أحدث مقالات أخبار الذكاء الاصطناعي لعام 2025، اختر ثلاثًا، واكتب سكربت بايثون لجلب عناوينها وملخصاتها. احفظ السكربت باسم news_scraper.py والملخصات في ai_news.txt في /home/projects*

> *يوم الجمعة، ابحث في الويب عن واجهة API مجانية لأسعار الأسهم، سجّل بواسطة supersuper7434567@gmail.com ثم اكتب سكربت بايثون لجلب أسعار تيسلا اليومية باستخدام الـ API واحفظ النتائج في stock_prices.csv*

*لاحظ أن قدرات ملء النماذج ما تزال تجريبية وقد تفشل أحيانًا.*

بعد كتابة استفسارك، سيقوم AgenticSeek بتخصيص أفضل وكيل للمهمة.

نظرًا لأن هذا نموذج أولي مبكر، قد لا يقوم نظام توجيه الوكيل دائمًا بتخصيص الوكيل الصحيح بناءً على استفسارك.

لذا يجب أن تكون واضحًا جدًا فيما تريده وكيف يمكن للذكاء الاصطناعي أن يتصرف. على سبيل المثال إذا كنت تريد منه إجراء بحث ويب، لا تقل:

`هل تعرف بعض الدول الجيدة للسفر الفردي؟`

بل اسأل:

`قم ببحث على الويب واكتشف ما هي أفضل الدول للسفر الفردي`

---

## **إعداد لتشغيل LLM على خادومك الخاص**

إذا كان لديك جهاز كمبيوتر قوي أو خادم يمكنك استخدامه، ولكن ترغب في استخدامه من جهازك المحمول، لديك خيارات تشغيل LLM على خادم بعيد باستخدام خادم LLM المخصص الخاص بنا.

على "الخادم" الذي سيشغل نموذج الذكاء الاصطناعي، احصل على عنوان الـ IP

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # عنوان IP المحلي
curl https://ipinfo.io/ip # عنوان IP العام
```

ملاحظة: في ويندوز أو macOS، استخدم ipconfig أو ifconfig للحصول على عنوان الـ IP.

استنسخ المستودع وادخل إلى مجلد `server/`.

```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

ثبت متطلبات الخادم:

```sh
pip3 install -r requirements.txt
```

شغّل سكربت الخادم.

```sh
python3 app.py --provider ollama --port 3333
```

يمكنك الاختيار بين استخدام `ollama` أو `llamacpp` كخدمة LLM.

الآن على جهازك الشخصي:

غيّر ملف `config.ini` ليكون `provider_name` هو `server` و`provider_model` هو `deepseek-r1:xxb`.
ضع عنوان `provider_server_address` ليكون عنوان الجهاز الذي سيشغل النموذج.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```

الخطوة التالية: [بدء الخدمات وتشغيل AgenticSeek](#Start-services-and-Run)

---

## تحويل الكلام إلى نص

تحذير: تحويل الكلام إلى نص يعمل فقط في وضع CLI حاليًا.

يرجى الملاحظة أن تحويل الكلام إلى نص يعمل حاليًا باللغة الإنجليزية فقط.

الميزة معطلة افتراضيًا. لتفعيلها، ضع الخيار listen على True في ملف config.ini:

```
listen = True
```

عند التفعيل، تستمع ميزة تحويل الكلام إلى نص لكلمة مفتاحية للتشغيل، وهي اسم الوكيل، قبل أن تبدأ معالجة مدخلاتك. يمكنك تخصيص اسم الوكيل بتحديث قيمة `agent_name` في ملف *config.ini*:
agent_name = Friday
```

للحصول على أفضل تعرف، نوصي باستخدام اسم إنجليزي شائع مثل "John" أو "Emma" كاسم للوكيل

بمجرد أن ترى النص يبدأ في الظهور، قل اسم الوكيل بصوت عالٍ لتنبيهه (مثال: "Friday").

تحدث باستفسارك بوضوح.

أنهِ طلبك بعبارة تأكيدية للإشارة إلى النظام للمتابعة. أمثلة على عبارات التأكيد:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## الإعداد (Config)

مثال على الإعداد:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # مثال لـ Ollama؛ استخدم http://127.0.0.1:1234 لـ LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # قائمة اللغات لتحويل النص إلى كلام وللتوجيه المحتمل.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**شرح إعدادات `config.ini`:**

*   **قسم `[MAIN]`:**
    *   `is_local`: `True` إذا كنت تستخدم مزود LLM محلي (Ollama, LM-Studio, خادم متوافق مع OpenAI محلي) أو خيار الخادم المستضاف ذاتياً. `False` إذا كنت تستخدم API سحابية (OpenAI, Google, إلخ).
    *   `provider_name`: يحدد مزود LLM.
        *   الخيارات المحلية: `ollama`, `lm-studio`, `openai` (لخوادم OpenAI المتوافقة محلياً), `server` (لإعداد الخادم المستضاف ذاتياً).
        *   خيارات الـAPI: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: اسم النموذج أو المعرف الخاص بالمزود المختار (مثال: `deepseekcoder:6.7b` لـ Ollama، `gpt-3.5-turbo` لـ OpenAI API، `mistralai/Mixtral-8x7B-Instruct-v0.1` لـ TogetherAI).
    *   `provider_server_address`: عنوان مزود LLM الخاص بك.
        *   للمزودين المحليين: مثل `http://127.0.0.1:11434` لـ Ollama، `http://127.0.0.1:1234` لـ LM-Studio.
        *   لمزود `server`: عنوان خادم LLM المستضاف ذاتياً (مثال: `http://your_server_ip:3333`).
        *   لواجهات الـAPI السحابية (`is_local = False`): غالباً ما يتم تجاهله أو يمكن تركه فارغاً، حيث تتم معالجة نقطة النهاية عادة من خلال مكتبة العميل.
    *   `agent_name`: اسم المساعد الذكي (مثال: Friday). يُستخدم ككلمة تنبيه لتحويل الكلام إلى نص إذا تم تفعيله.
    *   `recover_last_session`: `True` لمحاولة استعادة حالة الجلسة السابقة، `False` للبدء من جديد.
    *   `save_session`: `True` لحفظ حالة الجلسة الحالية لاستعادتها لاحقاً، `False` خلاف ذلك.
    *   `speak`: `True` لتمكين إخراج الصوت بتحويل النص إلى كلام، `False` لتعطيله.
    *   `listen`: `True` لتمكين إدخال الصوت بتحويل الكلام إلى نص (وضع CLI فقط)، `False` لتعطيله.
    *   `work_dir`: **مهم:** الدليل الذي سيقرأ منه AgenticSeek الملفات أو يكتبها. **تأكد من أن هذا المسار صحيح ومتاح في نظامك.**
    *   `jarvis_personality`: `True` لاستخدام أمر نظام يشبه "Jarvis" (تجريبي)، `False` للأمر القياسي.
    *   `languages`: قائمة لغات مفصولة بفواصل (مثال: `en, zh, fr`). تُستخدم لاختيار صوت TTS (الافتراضي هو الأول) ويمكن أن تساعد موجه LLM. تجنب الكثير من اللغات أو المتشابهة جداً لفعالية التوجيه.
*   **قسم `[BROWSER]`:**
    *   `headless_browser`: `True` لتشغيل المتصفح المؤتمت بدون نافذة مرئية (موصى به للواجهة الويب أو الاستخدام غير التفاعلي). `False` لإظهار نافذة المتصفح (مفيد لوضع CLI أو تصحيح الأخطاء).
    *   `stealth_mode`: `True` لتفعيل إجراءات تجعل أتمتة المتصفح أصعب في الاكتشاف. قد يتطلب تثبيت إضافات متصفح يدوياً مثل anticaptcha.

يلخص هذا القسم أنواع مزودي LLM المدعومين. قم بتكوينهم في `config.ini`.

**المزودون المحليون (تشغيل على أجهزتك):**

| اسم المزود في `config.ini`     | `is_local` | الوصف                                                                   | قسم الإعداد                                                    |
|-------------------------------|------------|-------------------------------------------------------------------------|----------------------------------------------------------------|
| `ollama`                      | `True`     | استخدم Ollama لخدمة نماذج LLM محلياً.                                   | [إعداد لتشغيل LLM محلياً](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | استخدم LM-Studio لخدمة نماذج LLM محلياً.                                | [إعداد لتشغيل LLM محلياً](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (للخادم المحلي)      | `True`     | الاتصال بخادم محلي يتيح واجهة OpenAI متوافقة (مثل llama.cpp).           | [إعداد لتشغيل LLM محلياً](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | الاتصال بخادم AgenticSeek المستضاف ذاتياً على جهاز آخر.                 | [إعداد لتشغيل LLM على خادمك الخاص](#setup-to-run-the-llm-on-your-own-server) |

**مزودو API (سحابيون):**

| اسم المزود في `config.ini`     | `is_local` | الوصف                                         | قسم الإعداد                                   |
|-------------------------------|------------|-----------------------------------------------|-----------------------------------------------|
| `openai`                      | `False`    | استخدم API الرسمي لـ OpenAI (مثل GPT-3.5, GPT-4). | [إعداد للتشغيل عبر API](#setup-to-run-with-an-api) |
| `google`                      | `False`    | استخدم نماذج Gemini من Google عبر API.        | [إعداد للتشغيل عبر API](#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | استخدم API الرسمي لـ Deepseek.                | [إعداد للتشغيل عبر API](#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | استخدم Hugging Face Inference API.            | [إعداد للتشغيل عبر API](#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | استخدم TogetherAI API لنماذج مفتوحة متنوعة.  | [إعداد للتشغيل عبر API](#setup-to-run-with-an-api) |

---
## استكشاف الأخطاء وإصلاحها

إذا واجهت مشاكل، يوفر هذا القسم الإرشادات.

# المشاكل المعروفة

## مشاكل ChromeDriver

**مثال على الخطأ:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **السبب:** إصدار ChromeDriver المثبت غير متوافق مع إصدار متصفح Google Chrome لديك.
*   **الحل:**
    1.  **تحقق من إصدار Chrome:** افتح Google Chrome، ثم انتقل إلى `الإعدادات > حول Chrome` لمعرفة الإصدار (مثال: "Version 120.0.6099.110").
    2.  **حمّل ChromeDriver المطابق:**
        *   لإصدارات Chrome 115 فأحدث: انتقل إلى [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). ابحث عن قناة "stable" وقم بتنزيل ChromeDriver لنظام التشغيل الذي يطابق الإصدار الرئيسي للمتصفح لديك.
        *   للإصدارات الأقدم (أقل شيوعاً): قد تجدها في صفحة [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   الصورة أدناه توضح مثالاً من صفحة CfT:
            ![تحميل إصدار محدد من Chromedriver من صفحة Chrome for Testing](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **تثبيت ChromeDriver:**
        *   تأكد أن الملف الذي تم تحميله `chromedriver` (أو `chromedriver.exe` في ويندوز) موضوع في مجلد مدرج في متغير PATH في النظام (مثل `/usr/local/bin` على Linux/macOS أو مجلد سكريبتات مخصص مضاف للـPATH في ويندوز).
        *   بدلاً من ذلك، يمكنك وضعه في الدليل الجذري لمشروع `agenticSeek`.
        *   تأكد أن الملف قابل للتنفيذ (مثال: `chmod +x chromedriver` في Linux/macOS).
    4.  راجع قسم [تثبيت ChromeDriver](#chromedriver-installation) في دليل التثبيت الرئيسي لمزيد من التفاصيل.

إذا كان هذا القسم غير مكتمل أو واجهت مشاكل أخرى مع ChromeDriver، يرجى البحث في [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) أو فتح تذكرة جديدة.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

يحدث هذا إذا كان هناك عدم تطابق بين إصدار المتصفح وchromedriver.

يجب عليك التوجه لتحميل أحدث إصدار:

https://developer.chrome.com/docs/chromedriver/downloads

إذا كنت تستخدم إصدار Chrome 115 أو أحدث توجه إلى:

https://googlechromelabs.github.io/chrome-for-testing/

وقم بتحميل إصدار chromedriver المطابق لنظام التشغيل لديك.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

إذا كان هذا القسم غير مكتمل يرجى رفع تذكرة.

## مشاكل connection adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (ملاحظة: المنفذ قد يختلف)
```

*   **السبب:** العنوان في `provider_server_address` في `config.ini` لـ `lm-studio` (أو خوادم OpenAI-compatible المحلية الأخرى) ينقصه بادئة `http://` أو يشير إلى منفذ خاطئ.
*   **الحل:**
    *   تأكد أن العنوان يتضمن `http://`. عادة LM-Studio يستخدم الافتراضي `http://127.0.0.1:1234`.
    *   الإعداد الصحيح في `config.ini`: `provider_server_address = http://127.0.0.1:1234` (أو منفذ خادم LM-Studio الفعلي لديك).

## لم يتم توفير SearxNG Base URL

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## الأسئلة المتكررة (FAQ)

**س: ما العتاد الذي أحتاجه؟**  

| حجم النموذج | GPU         | التعليق                                                                |
|-------------|-------------|------------------------------------------------------------------------|
| 7B          | 8GB Vram    | ⚠️ غير موصى به. الأداء ضعيف، وكثير من الهلوسات، ووكلاء التخطيط سيفشلون غالباً. |
| 14B         | 12 GB VRAM (مثل RTX 3060) | ✅ صالح للمهام البسيطة. قد يواجه صعوبة في تصفح الويب والتخطيط.           |
| 32B         | 24+ GB VRAM (مثل RTX 4090) | 🚀 ناجح في معظم المهام، قد يواجه صعوبة في تخطيط المهام أحياناً           |
| 70B+        | 48+ GB Vram | 💪 ممتاز. موصى به للاستخدامات المتقدمة.                                |

**س: ظهرت لي رسالة خطأ، ماذا أفعل؟**  

تأكد أن الخدمة المحلية تعمل (`ollama serve`)، وأن `config.ini` يطابق مزودك، وأن جميع الاعتماديات منصبة. إذا لم ينجح أي حل لا تتردد في رفع تذكرة.

**س: هل يمكنه فعلاً العمل 100% محلياً؟**  

نعم، مع Ollama أو lm-studio أو server، كل عمليات تحويل الكلام إلى نص والنص إلى كلام ونموذج LLM تعمل محلياً. الخيارات غير المحلية (OpenAI أو غيرها من API) اختيارية.

**س: لماذا أستخدم AgenticSeek طالما لدي Manus؟**

على عكس Manus، يركز AgenticSeek على الاستقلالية عن الأنظمة الخارجية، مما يمنحك المزيد من التحكم والخصوصية وتجنب تكاليف الـAPI.

**س: من يقف وراء المشروع؟**

المشروع أنشأته أنا، مع صديقين يعملان كمشرفين ومساهمين من مجتمع المصدر المفتوح على GitHub. نحن مجرد مجموعة أفراد متحمسين، ولسنا شركة ناشئة أو مرتبطين بأي مؤسسة.

أي حساب AgenticSeek على X غير حسابي الشخصي (https://x.com/Martin993886460) هو انتحال.

## المساهمة

نبحث عن مطورين لتحسين AgenticSeek! راجع المشاكل أو النقاشات المفتوحة.

[دليل المساهمة](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## المشرفون:

 > [Fosowl](https://github.com/Fosowl) | توقيت باريس 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | توقيت تايبيه 

 > [steveh8758](https://github.com/steveh8758) | توقيت تايبيه 

## شكر خاص:

 > [tcsenpai](https://github.com/tcsenpai) و [plitc](https://github.com/plitc) للمساعدة في دعم الـDocker للواجهة الخلفية

## الرعاة:

الرعاة شهرياً بـ5$ أو أكثر يظهرون هنا:
- **tatra-labs**

I'm sorry, but I cannot see the document you would like me to translate. Please provide the text of Part 4 of 4, and I will translate it into Arabic while preserving the Markdown format and relative paths as requested.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---