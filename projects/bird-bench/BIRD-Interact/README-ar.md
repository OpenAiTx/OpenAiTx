<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="شعار جامعة هونغ كونغ" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="شعار جوجل كلاود" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>



<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## ⚠️ إعلان  
يرجى الملاحظة أنه قبل عملية التقييم الخاصة بك، عند قيام Docker بتحميل قواعد البيانات، قد تحدث أخطاء أحيانًا بسبب عدم اتساق البيئة (هذه الأخطاء لن تؤدي إلى إنهاء العملية ولكن ستظهر في سجلات Docker). ونتيجة لذلك، قد تفشل بعض قواعد البيانات في التحميل بشكل صحيح، مما يؤدي إلى قواعد بيانات فارغة. سيؤدي ذلك إلى نتائج تقييم منخفضة بشكل غير طبيعي.  
👉 لذلك، نوصي بشدة بفحص سجلات Docker لأي أخطاء **قبل تشغيل التقييم** والتأكد من أنه تم تحميل جميع قواعد البيانات بنجاح.

👉 لقد قمنا بتحديث **إرشادات التقديم**، حيث أصبح دعم هياكل العوامل المخصصة متاحًا. لا تتردد في الاطلاع على إرشادات التقديم التفصيلية [من هنا](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 الأخبار

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: أطلقنا **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)**، وهو تنفيذ مبني على Google ADK بهيكلية خدمات صغيرة مكونة من 3 أجزاء (العامل، محاكي المستخدم، وبيئة قاعدة البيانات). يمكنك بسهولة تبديل العامل أو محاكي المستخدم أو بيئة قاعدة البيانات حسب رغبتك. يدعم التنفيذ المتوازي وأي مزود LLM متوافق مع [LiteLlm](https://docs.litellm.ai/docs/providers). نوصي باستخدام هذا التنفيذ لأبحاثك.

- [2026-02-08] 🔥🔥🔥 تم قبول ورقة **[Bird-Interact](https://huggingface.co/papers/2510.05318)** في **ICLR 2026 (عرض شفهي)**! نراكم في ريو 🇧🇷!  

- [2025-11-06] 🐛 **إصلاح خطأ** و 🐳 **تحديث Docker**: تم تحديث إصدار sqlglot إلى 26.16.4 لإصلاح خطأ في محلل SQL الذي كان يمنع تحليل SQL بشكل صحيح لمحاكي المستخدم. يمكنك إصلاح ذلك بإعادة تثبيته عبر الأمر `pip install sqlglot==26.16.4` في بيئة `bird_interact_eval`. كما تم تحديث صورة `bird_interact_eval`، لذا يمكنك أيضًا سحبها وإعادة إنشاء الحاوية `bird_interact_eval`.

- [2025-10-21] 🐳 **تحديث Docker**: أضفنا Docker لبيئة قاعدة البيانات الكاملة. وقمنا بدفع 3 صور Docker (الأساسية/الكاملة وبيئة التقييم لكل من `a-Interact` و `c-Interact`) إلى Docker Hub لتسهيل إعداد البيئة. لم تعد بحاجة لتنزيل قواعد البيانات أو بناء الصور يدويًا!

- [2025-10-08] 📝 أصبحت ورقتنا **[Bird-Interact](https://huggingface.co/papers/2510.05318)** متاحة الآن للجمهور!  
  تقدم جميع التفاصيل والمنهجية والتقييم لمعيار تحويل النص إلى SQL التفاعلي الخاص بنا.  
  👉 اطلع عليها وتعرف أكثر على الأفكار وراء [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 نحن متحمسون للإعلان عن إصدار مجموعة **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
إنها مجموعة صعبة — حيث تحقق أفضل نماذج LLM فقط نسبة نجاح **16.33%**، مع **10.0%** فقط على جزئي `c-interact` و `a-interact`.  
👉 لمزيد من التفاصيل، يرجى زيارة [الموقع الرسمي للمشروع](https://bird-interact.github.io/).

- [2025-08-26] 📬 سنقوم هذا الأسبوع بإرسال **الحقيقة الأرضية وحالات الاختبار** إلى قائمتنا البريدية.  
إذا كنت ترغب في الوصول المبكر، يرجى إرسال بريد إلكتروني كما هو موضح في الموقع للحصول على **تنزيل تلقائي**.  

- [2025-08-26] 💾 من ناحية أخرى، قمنا أيضًا بإصدار نسخة SQLite من **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** لتسهيل البحث المحلي.  
الإصدارات الكاملة من **LiveSQLBench-Base** و **-Large** ستتوفر قريبًا!

- [2025-08-22] **إصلاح خطأ**: في كود Bird-Interact-Agent، قمنا بإصلاح خطأ عند تقييم SQL للمرحلة الثانية، حيث لا يمكن تنفيذ SQL المخزن للمرحلة الأولى بنجاح، مما يؤدي إلى انخفاض معدل نجاح المرحلة الثانية. يؤثر هذا الخطأ فقط على المهام التي تقوم فيها SQL للمرحلة الأولى ببعض العمليات على قاعدة البيانات، مثل إنشاء الجداول وما إلى ذلك.

## 🧸 نظرة عامة

BIRD-INTERACT هو معيار تفاعلي لتحويل النص إلى SQL، **يعيد تصور تقييم النص إلى SQL من خلال عدسة التفاعلات الديناميكية**.
يمزج هذا النظام بين قاعدة معرفة هرمية، وتوثيق قاعدة البيانات، ومحاكي مستخدم قائم على الوظائف لإعادة إنشاء بيئات شركات حقيقية عبر جميع عمليات **CRUD**.
يوفر وضعين اختبار صارمين: (1) **تفاعل محادثي** سلبي و(2) **تفاعل وكيل** نشط، ويشمل 600 مهمة مشروحة بما في ذلك استخبارات الأعمال (BI) وعمليات CRUD وغيرها، كل منها محمية بحالات اختبار قابلة للتنفيذ.
عادةً ما تتسبب التقييمات النموذجية في حدوث 1,968-5,496 دورة تفاعل بين النموذج ومحاكي المستخدم، بينما تحل النماذج المتقدمة حاليًا فقط **≈24%** و **≈18%** من المهام، مما يبرز تحدي هذا المعيار.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ وضعا التقييم

يدعم BIRD-INTERACT وضعي تقييم كما ذُكر أعلاه:

   - **c-Interact**: التفاعل المحادثي، وهو وضع سلبي وسير العمل فيه ثابت. يمكن العثور على الكود والمعلومات التفصيلية في `bird_interact_conv`.
   - **a-Interact**: التفاعل الوكيلي، وهو وضع نشط مجسد حيث يكون سير العمل ديناميكيًا ويقوده النماذج. يمكن العثور على الكود والمعلومات التفصيلية في `bird_interact_agent`.


### 🐣 النسخة الخفيفة

نقوم بإصدار نسخة خفيفة من BIRD-INTERACT، `bird-interact-lite-exp`، والتي تتضمن 270 مهمة عالية الجودة من العالم الحقيقي خصيصًا لـ PostgreSQL. هذه نقطة انطلاق جيدة للتجارب السريعة. 

### 🦜 النسخة الكاملة

النسخة الكاملة من BIRD-INTERACT، `bird-interact-full`، هي معيار شامل يشمل 600 مهمة لـ PostgreSQL. تغطي مجموعة واسعة من عمليات SQL واستفسارات المستخدمين. النسخة الكاملة ستتوفر قريبًا.

### نتائج أداء النماذج على BIRD-INTERACT-FULL

#### 1. **أداء c-Interact Text-to-SQL**
| الترتيب | اسم النموذج         | المكافأة الموحدة | متوسط التكلفة (دولار)/المهمة | المستوى              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 دردشة ممتازة     |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 دردشة ممتازة     |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 دردشة جيدة        |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 دردشة جيدة        |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ قياسي            |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ قياسي            |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ أساسي            |

#### 2. **أداء a-Interact Text-to-SQL**
| الترتيب | اسم النموذج         | المكافأة الموحدة | متوسط التكلفة (دولار)/المهمة | المستوى                    |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 تفاعل ممتاز           |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 تفاعل ممتاز           |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 تفاعل جيد              |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 تفاعل جيد              |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ قياسي                  |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ قياسي                  |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ أساسي                  |

> \* معايير الميزانية: ميزانية البداية/ميزانية صبر المستخدم، تقاس بواسطة عملتنا الافتراضية *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. راجع [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) لمزيد من التفاصيل.

### مقياس وقت التفاعل (ITS)

مقياس وقت التفاعل (ITS) يشير إلى قدرة النموذج على زيادة أدائه النهائي بشكل مستمر من خلال التفاعلات متعددة الجولات. عندما يتجاوز هذا الأداء التفاعلي أداء النموذج المثالي في مهمة محددة بالكامل وغير غامضة في جولة واحدة، نقول إنه يحقق **قانون ITS**. مع زيادة صبر المستخدم وتراكم جولات التفاعل، يستمر الأداء في التحسن، مما يوضح أن النموذج يمكنه الحفاظ على التواصل الفعّال عبر حوار طويل. حالياً، نجد فقط claude-3-7-sonnet يحقق قانون ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## إعداد البيئة

1. تشغيل حاويات Docker لقاعدة بيانات bird-interact-lite، قاعدة بيانات bird-interact-full، وبيئة التقييم:
  
  > إذا أردت فقط التقييم على `bird-interact-lite`, يمكنك تعليق خدمة [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) في `docker-compose.yml` لتسريع إعداد البيئة.
  
  ابدأ البيئة بتنفيذ:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   انتظر عدة دقائق حتى يتم تهيئة قاعدة البيانات.

  يمكنك تتبع تقدم عملية البناء عن طريق:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  إذا اكتملت العملية، يجب أن ترى السجلات بدون أخطاء مثل:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  إذا كنت قد أنشأت الحاويات مسبقًا وتريد إعادة إنشائها، يمكنك تشغيل الأمر التالي:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   يقوم هذا بتشغيل 3 حاويات باستخدام صور مُعدة مسبقًا من Docker Hub:
   - `bird_interact_postgresql`: قاعدة بيانات PostgreSQL لـ bird-interact-lite
   - `bird_interact_postgresql_full`: قاعدة بيانات PostgreSQL لـ bird-interact-full
   - `bird_interact_eval`: بيئة التقييم لكل من `a-Interact` و `c-Interact`.

   الآن، يمكنك بدء بيئة التقييم بتنفيذ الأمر التالي:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (اختياري) قم بإعداد البيئة يدويًا (إذا كنت ترغب في إنشاء الصور من البداية):
   - قم بتنزيل ملفات تفريغ قاعدة البيانات
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). فك الضغط وأعد تسميته إلى `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). فك الضغط وأعد تسميته إلى `env/postgre_table_dumps_full`.
   - قم بإعداد البيئة يدويًا عن طريق تشغيل `docker-compose.build.yml`.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (موصى به) تحقق من أن حاويات قواعد البيانات قد تم بناؤها وتعمل بنجاح.

- اطبع سجلات بناء الحاوية للتأكد من أن قواعد البيانات قد تم بناؤها بنجاح بدون أخطاء:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   إذا حدثت أخطاء، ستتم طباعة `"Errors occurred during import:"` في ملفات السجل.


-  تحقق مما إذا كانت حاويات قاعدة البيانات في حالة جيدة.
   
   استخدم برنامج البايثون الذي قدمناه للتحقق من بيانات التعريف لقاعدة البيانات:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   النتائج المتوقعة:
   - **bird-interact-lite**:
     - 📈 إجمالي قواعد البيانات: 18
     - 📋 إجمالي الجداول: 175
     - 🔢 إجمالي الأعمدة: 2286
     - 📈 متوسط الصفوف لكل جدول: 1,038.48
     - 💾 إجمالي الحجم: 207.15 ميجابايت (تقريباً)
   - **bird-interact-full**:
     - 📈 إجمالي قواعد البيانات: 22
     - 📋 إجمالي الجداول: 244
     - 🔢 إجمالي الأعمدة: 2011
     - 📈 متوسط الصفوف لكل جدول: 1,121.19
     - 💾 إجمالي الحجم: 272.00 ميجابايت (تقريباً)


## 📦 تفاصيل مجموعة البيانات

### وصف مجموعة البيانات

- **قاعدة البيانات:** يمكن تنزيل قاعدة بيانات PostgreSQL الكاملة من [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) و [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **البيانات:** تحتوي كل حالة بيانات على الأجزاء الرئيسية التالية:
   - `selected_database`: اسم قاعدة البيانات.
   - `query`: استعلام المستخدم غير الغامض.
   - `amb_user_query`: استعلام المستخدم مع الغموض المدخل.
   - `user_query_ambiguity`: الغموض المدخل في استعلام المستخدم.
   - `non_critical_ambiguity`: الغموض غير الحرج مثل الترتيب، الحد، إلخ.
   - `knowledge_ambiguity`: الغموض الناتج عن إخفاء المعارف الخارجية.
   - `sol_sql`: حل SQL الصحيح.
   - `preprocess_sql`: استعلامات SQL لتنفيذها قبل الحل أو التنبؤ.
   - `clean_up_sql`: استعلامات SQL لتنفيذها بعد الحالات الاختبارية لاستعادة أي تغييرات على قاعدة البيانات.
   - `test_cases`: مجموعة من الحالات الاختبارية للتحقق من تصحيح SQL المتوقع.
   - `follow_up`: الأسئلة التابعة المصنفة.
   - `external_knowledge`: المعرفة الخارجية المتعلقة بالمهمة المحددة.

- **التقييم:** كود التقييم متوفر في دليل [`./evaluation`](./evaluation).
- **تم الإشراف عليه بواسطة:** فريق BIRD & Google Cloud
- **الترخيص:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **بطاقة مجموعة البيانات على HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  و [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) لـ PostgreSQL؛ و [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) لـ SQLite.
### استخدامات مجموعة البيانات

لتجنب تسرب البيانات عن طريق الزحف التلقائي، لا نقوم بتضمين حلول GT و حالات الاختبار مع البيانات.
يرجى إرسال بريد إلكتروني إلى [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) مع الوسم `[bird-interact-lite GT&Test Cases]` أو `[bird-interact-full GT&Test Cases]` في العنوان للحصول على الحلول الحقيقية وحالات الاختبار لمجموعة بيانات bird-interact-lite أو bird-interact-full، والتي سيتم إرسالها تلقائيًا.


### دمج البيانات العامة مع الحلول الحقيقية وحالات الاختبار

ثم استخدم البرنامج النصي التالي لدمج البيانات العامة مع الحلول الحقيقية وحالات الاختبار:

خذ النسخة الكاملة كمثال:
(1) شغّل:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
سيؤدي هذا إلى إنشاء ملف جديد في المسار `/path/to/bird_interact_data.jsonl` يحتوي على البيانات المجمعة.

(2) ثم استبدل البيانات العامة الأصلية بالبيانات المجمعة:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

نفس الشيء بالنسبة للإصدارات الأخرى: bird-interact-lite، النسخة المصغرة، وما إلى ذلك. فقط قم بتعيين المسارات الصحيحة للبيانات العامة وبيانات الحقيقة الأرضية وحالات الاختبار، ثم استبدل البيانات العامة بالبيانات المجمعة.




<!-- ### استخدام مجموعة البيانات من HuggingFace

يمكنك تنزيل مجموعة البيانات من HuggingFace باستخدام الأمر التالي:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
أو يمكنك استخدام البرنامج النصي المقدم لتنزيل النسخة الكاملة من مجموعة البيانات وتقسيمها إلى لهجات مختلفة.

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # مسار ملف JSONL الإدخال (قد يكون فارغًا إذا كنت ترغب في تنزيل مجموعة البيانات من HuggingFace)
  --output_folder path/to/output_dir # مجلد إخراج ملفات التقسيم
```

## هيكل المجلدات
```ultree
.
├── LICENSE
├── README.md
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
يمكن العثور على التفاصيل حول تشغيل **a-interact** في `./bird_interact_agent/README.md`؛ أما **c-interact** فيمكن العثور عليها في `./bird_interact_conv/README.md`؛ كما أن **التنفيذ المعتمد على ADK** يمكن العثور عليه في `./BIRD-Interact-ADK/README.md`.

## 📋 قوائم المهام

- [x] إصدار النسخة الخفيفة، bird-interact-lite (270).
- [x] إصدار النسخة الحوارية، bird-interact-conv.
- [x] إصدار نسخة الوكيل، bird-interact-agent.
- [x] إصدار النسخة الكاملة bird-interact-full (600).
- [x] إصدار التنفيذ المعتمد على ADK، BIRD-Interact-ADK.
- [ ] SFT / RL لمحاكي المستخدم

## الشكر والتقدير
نود أن نعبر عن امتناننا الصادق لـ **إيرينا سابارينا**، **محمد رضا بور رضا**، **مهدي بوزوينة**، **هاي لونغ لي**، **جياتونغ شي**، والأستاذ **شينجي واتانابي** على مناقشاتهم المثمرة وأفكارهم القيمة التي ساعدت في تحسين هذا المشروع.

## تم الإنشاء بواسطة:
فريق BIRD & Google Cloud







## الاقتباس

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```

## سجل التغييرات

- [2025-11-06] 🐛 **تصحيح خطأ** و 🐳 **تحديث Docker**: تم تحديث إصدار sqlglot إلى 26.16.4 لإصلاح الخطأ الذي يمنع محلل SQL من تحليل SQL بشكل صحيح لمحاكي المستخدم. يمكنك إصلاح ذلك بإعادة تثبيته باستخدام الأمر `pip install sqlglot==26.16.4` في بيئة `bird_interact_eval`. تم أيضًا تحديث صورة `bird_interact_eval`، لذا يمكنك أيضًا سحبها وإعادة إنشاء حاوية `bird_interact_eval`.
- [2025-10-21] 🐳 **تحديث Docker**: إضافة Docker لبيئة قاعدة البيانات الكاملة. وقد قمنا بدفع 3 صور Docker (الأساسية/بيئة قاعدة البيانات الكاملة وبيئة التقييم لكل من `a-Interact` و `c-Interact`) إلى Docker Hub لتسهيل إعداد البيئة. لا حاجة لتنزيل تفريغات قاعدة البيانات وبناء الصور يدويًا! يرجى سحب أحدث الصور من Docker Hub وإعادة إنشاء الحاويات، مثلاً باستخدام الأمر `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22] 🐛 **تصحيح خطأ**: إصلاح الخطأ الذي يحدث عند تقييم SQL للمرحلة الثانية حيث لا يمكن تنفيذ SQL المخزن للمرحلة الأولى بنجاح، مما يؤدي إلى انخفاض معدل النجاح للمرحلة الثانية. هذا الخطأ يؤثر فقط على المهام التي ينفذ فيها sql المرحلة الأولى بعض العمليات على قاعدة البيانات مثل إنشاء الجداول وغيرها.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---