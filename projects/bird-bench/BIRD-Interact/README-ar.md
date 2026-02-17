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
يرجى ملاحظة أنه قبل بدء عملية التقييم، قد تظهر أخطاء أحيانًا أثناء تحميل Docker لقواعد البيانات بسبب عدم توافق البيئة (هذه الأخطاء لن توقف العملية لكنها ستظهر في سجلات Docker). ونتيجة لذلك، قد تفشل بعض قواعد البيانات في التحميل بشكل صحيح، مما يؤدي إلى قواعد بيانات فارغة. هذا سيؤدي إلى نتائج تقييم منخفضة بشكل غير طبيعي.  
👉 لذلك، نوصي بشدة بفحص سجلات Docker لأي أخطاء **قبل تشغيل التقييم** والتأكد من أنه تم تحميل جميع قواعد البيانات بنجاح.

👉 قمنا بتحديث **إرشادات التقديم**، حيث أصبح من الممكن دعم هياكل الوكلاء المخصصة. لا تتردد في الاطلاع على إرشادات التقديم المفصلة الخاصة بنا [هنا](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 الأخبار

- [2026-02-08] 🔥🔥🔥 تم قبول ورقتنا البحثية **[Bird-Interact](https://huggingface.co/papers/2510.05318)** في **ICLR 2026 (عرض شفهي)**! نراكم في ريو 🇧🇷!  

- [2025-11-06] 🐛 **إصلاح خطأ** و 🐳 **تحديث Docker**: تم تحديث إصدار sqlglot إلى 26.16.4 لإصلاح خطأ عدم قدرة محلل SQL على تحليل SQL بشكل صحيح لمحاكي المستخدم. يمكنك إصلاح ذلك بإعادة تثبيته عبر الأمر `pip install sqlglot==26.16.4` في بيئة `bird_interact_eval`. كما تم تحديث صورة `bird_interact_eval`، بحيث يمكنك سحبها وإعادة إنشاء الحاوية `bird_interact_eval`.

- [2025-10-21] 🐳 **تحديث Docker**: أضفنا Docker لبيئة قاعدة البيانات الكاملة. ودفعنا 3 صور Docker (الأساسية/بيئة قاعدة البيانات الكاملة وبيئة التقييم لكل من `a-Interact` و `c-Interact`) إلى Docker Hub لتسهيل إعداد البيئة. لا حاجة لتحميل ملفات تفريغ قواعد البيانات أو بناء الصور يدويًا!

- [2025-10-08] 📝 أصبحت ورقتنا البحثية **[Bird-Interact](https://huggingface.co/papers/2510.05318)** متاحة الآن للجميع!  
  تعرض الورقة التفاصيل الكاملة والمنهجية والتقييم لمعيار التحويل التفاعلي من النص إلى SQL الخاص بنا.  
  👉 اطلع عليها وتعرف على المزيد حول الأفكار وراء [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 يسعدنا الإعلان عن إصدار **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
إنها مجموعة صعبة — حيث تحقق أفضل النماذج نسبة نجاح تبلغ فقط **16.33%**، مع نسبة **10.0%** فقط في جزئي `c-interact` و `a-interact`.  
👉 لمزيد من التفاصيل، يرجى زيارة [موقع المشروع](https://bird-interact.github.io/).

- [2025-08-26] 📬 سنقوم هذا الأسبوع بإرسال **البيانات المرجعية وحالات الاختبار** إلى قائمتنا البريدية.  
إذا كنت ترغب في الوصول المبكر، يرجى إرسال بريد إلكتروني كما هو موضح في الموقع للحصول على **تنزيل تلقائي**.  

- [2025-08-26] 💾 في سياق آخر، أصدرنا أيضًا إصدار SQLite من **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** لتسهيل البحث المحلي.  
الإصداران الكاملان **LiveSQLBench-Base** و **-Large** قادمان قريبًا!

- [2025-08-22] **إصلاح خطأ**: في كود Bird-Interact-Agent، أصلحنا خطأً كان يمنع تنفيذ SQL المرحلة الثانية بنجاح إذا لم يكن بالإمكان تنفيذ SQL المرحلة الأولى المخزنة، مما أدى لانخفاض معدل نجاح المرحلة الثانية. يؤثر هذا الخطأ فقط على المهام التي تقوم فيها SQL المرحلة الأولى بعمليات على قاعدة البيانات، مثل إنشاء جدول وما إلى ذلك.

## 🧸 نظرة عامة

BIRD-INTERACT هو معيار تفاعلي لتحويل النص إلى SQL، **يعيد تصور تقييم Text-to-SQL من خلال عدسة التفاعلات الديناميكية**.
يمزج هذا النظام بين قاعدة معرفة هرمية، وتوثيق قاعدة البيانات، ومحاكي مستخدم قائم على الوظائف لإعادة إنشاء بيئات مؤسساتية واقعية تشمل جميع عمليات **CRUD**.
يوفر وضعين اختباريين صارمين: (1) **تفاعل محادثي** سلبي و (2) **تفاعل وكيل نشط**، ويشمل 600 مهمة مشروحة تتضمن استخبارات الأعمال (BI)، وعمليات CRUD وغيرها، كل منها محمي بحالات اختبار قابلة للتنفيذ.
عادةً ما تُحفز عمليات التقييم بين 1,968 و 5,496 دورة تفاعل بين النموذج ومحاكي المستخدم، بينما تحل نماذج الاستدلال المتقدمة حاليًا فقط **≈24%** و **≈18%** من المهام، مما يبرز تحدي هذا المعيار.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ وضعا التقييم

يدعم BIRD-INTERACT وضعي تقييم كما ذكر أعلاه:

   - **c-Interact**: التفاعل المحادثي، وهو وضع سلبي وسير العمل فيه ثابت. يمكن العثور على الكود والمعلومات التفصيلية في `bird_interact_conv`.
   - **a-Interact**: التفاعل الوكيلي، وهو وضع نشط متجسد حيث يكون سير العمل ديناميكيًا ويقوده النماذج. يمكن العثور على الكود والمعلومات التفصيلية في `bird_interact_agent`.


### 🐣 النسخة الخفيفة

نصدر نسخة خفيفة من BIRD-INTERACT، تحت اسم `bird-interact-lite-exp`، والتي تتضمن 270 مهمة واقعية عالية الجودة مخصصة لـ PostgreSQL. وهي نقطة انطلاق جيدة للتجارب السريعة.

### 🦜 النسخة الكاملة

النسخة الكاملة من BIRD-INTERACT، تحت اسم `bird-interact-full`، هي معيار شامل يشمل 600 مهمة لـ PostgreSQL. تغطي مجموعة واسعة من عمليات SQL واستفسارات المستخدمين. النسخة الكاملة قادمة قريبًا.

### نتائج أداء النماذج على BIRD-INTERACT-FULL

#### 1. **أداء c-Interact Text-to-SQL**
| الترتيب | اسم النموذج         | المكافأة الموحدة | متوسط التكلفة (دولار أمريكي)/مهمة | المستوى              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 دردشة ممتازة    |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 دردشة ممتازة    |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 دردشة جيدة      |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 دردشة جيدة      |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ قياسي           |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ قياسي           |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ أساسي           |

#### 2. **a-Interact Text-to-SQL** الأداء
| الترتيب | اسم النموذج           | المكافأة المعيارية | متوسط التكلفة (دولار)/مهمة | المستوى                       |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 تفاعل ممتاز            |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 تفاعل ممتاز            |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 تفاعل جيد              |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 تفاعل جيد              |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ قياسي                  |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ قياسي                  |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ أساسي                  |

> \* معلمات الميزانية: ميزانية البدء/ميزانية صبر المستخدم، مقاسة بعملتنا الافتراضية *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. راجع [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) لمزيد من التفاصيل.

### مقياس وقت التفاعل (ITS)

يشير مقياس وقت التفاعل (ITS) إلى قدرة النموذج على زيادة أدائه النهائي باستمرار من خلال تفاعلات متعددة الأدوار. عندما يتجاوز هذا الأداء التفاعلي الأداء المثالي للنموذج في مهمة محددة وواضحة من دورة واحدة، نقول أنه يحقق **قانون ITS**. مع زيادة صبر المستخدم وتراكم أدوار التفاعل، يستمر الأداء في التحسن، مما يدل على أن النموذج قادر على الحفاظ على تواصل فعال عبر حوار ممتد. حالياً، وجدنا فقط أن claude-3-7-sonnet يحقق قانون ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## إعداد البيئة

1. قم بتشغيل حاويات Docker لقواعد بيانات bird-interact-lite و bird-interact-full وبيئة التقييم:
  
  > إذا كنت ترغب فقط في التقييم على `bird-interact-lite`، يمكنك تعليق خدمة [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) في ملف `docker-compose.yml` لتسريع إعداد البيئة.
  
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
     - 💾 الحجم الكلي: 207.15 ميغابايت (تقريباً)
   - **bird-interact-full**: 
     - 📈 إجمالي قواعد البيانات: 22
     - 📋 إجمالي الجداول: 244
     - 🔢 إجمالي الأعمدة: 2011
     - 📈 متوسط الصفوف لكل جدول: 1,121.19
     - 💾 الحجم الكلي: 272.00 ميغابايت (تقريباً)


## 📦 تفاصيل مجموعة البيانات

### وصف مجموعة البيانات

- **قاعدة البيانات:** يمكن تنزيل قاعدة بيانات PostgreSQL الكاملة من [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) و [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **البيانات:** كل حالة بيانات تحتوي على الأجزاء الرئيسية التالية:
   - `selected_database`: اسم قاعدة البيانات.  
   - `query`: استعلام المستخدم غير الغامض.  
   - `amb_user_query`: استعلام المستخدم مع غموض مدسوس.
   - `user_query_ambiguity`: الغموض المدسوس في استعلام المستخدم.
   - `non_critical_ambiguity`: الغموض غير الحرج مثل الترتيب، الحد، إلخ.
   - `knowledge_ambiguity`: الغموض الناتج عن إخفاء معارف خارجية. 
   - `sol_sql`: حل SQL الصحيح (الحقيقة الأرضية).  
   - `preprocess_sql`: استعلامات SQL يتم تنفيذها قبل تنفيذ الحل أو التنبؤ.  
   - `clean_up_sql`: استعلامات SQL يتم تنفيذها بعد حالات الاختبار لإعادة أي تغييرات على قاعدة البيانات.  
   - `test_cases`: مجموعة من حالات الاختبار للتحقق من صحة استعلام SQL المصحح المتوقع.
   - `follow_up`: الأسئلة التابعة المعلّمة.
   - `external_knowledge`: المعرفة الخارجية المتعلقة بالمهمة المحددة.

- **التقييم:** كود التقييم متوفر في مجلد [`./evaluation`](./evaluation).
- **منسق بواسطة:** فريق BIRD و Google Cloud
- **الترخيص:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **بطاقة مجموعة بيانات HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  و [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
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
يمكن العثور على التفاصيل حول تشغيل **a-interact** في `./bird_interact_agent/README.md`؛ ويمكن العثور على **c-interact** في `./bird_interact_conv/README.md`.

## 📋 قوائم المهام

- [x] إصدار النسخة الخفيفة، bird-interact-lite (270).
- [x] إصدار النسخة الحوارية، bird-interact-conv.
- [x] إصدار نسخة العميل، bird-interact-agent.
- [x] إصدار النسخة الكاملة bird-interact-full (600).
- [ ] SFT / RL محاكي المستخدم

## الشكر والتقدير
نود أن نعبر عن امتناننا العميق لـ **إيرينا سابرينا**، **محمد رضا بور رضا**، **مهدي بوزوينا**، **هاي لونغ لي**، **جياتونغ شي**، والأستاذ **شينجي واتانابي** على مناقشاتهم المثمرة وأفكارهم القيّمة التي ساعدت في تحسين هذا المشروع.

## من إنشاء:
فريق BIRD & Google Cloud








## سجل التغييرات

- [2025-11-06] 🐛 **إصلاح عطل** & 🐳 **تحديث Docker**: تحديث إصدار sqlglot إلى 26.16.4 لإصلاح عطل يمنع محلل SQL من تحليل الاستعلامات بشكل صحيح لمحاكي المستخدم. يمكنك إصلاح ذلك بإعادة تثبيته عبر الأمر `pip install sqlglot==26.16.4` في بيئة `bird_interact_eval`. كما تم تحديث صورة `bird_interact_eval`، لذا يمكنك أيضاً سحبها وإعادة إنشاء حاوية `bird_interact_eval`.
- [2025-10-21] 🐳 **تحديث Docker**: إضافة دعم Docker لبيئة قاعدة البيانات الكاملة. وقمنا بدفع ثلاث صور Docker (الأساسية/بيئة قاعدة البيانات الكاملة وبيئة التقييم لكل من `a-Interact` و`c-Interact`) إلى Docker Hub لتسهيل إعداد البيئة. لا حاجة لتنزيل قواعد البيانات أو بناء الصور يدوياً! يرجى سحب أحدث الصور من Docker Hub وإعادة إنشاء الحاويات، مثلاً باستخدام `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **إصلاح عطل**: إصلاح عطل عند تقييم SQL المرحلة الثانية، حيث لا يمكن تنفيذ SQL المرحلة الأولى المخزنة بنجاح، مما يؤدي إلى انخفاض معدل النجاح في المرحلة الثانية. هذا العطل يؤثر فقط على المهام التي يقوم فيها استعلام SQL المرحلة الأولى ببعض العمليات على قاعدة البيانات، مثل CREATE table، إلخ.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---