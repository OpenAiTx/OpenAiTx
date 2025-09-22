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
يرجى ملاحظة أنه قبل عملية التقييم الخاصة بك، عند تحميل Docker لقواعد البيانات، قد تحدث أخطاء أحيانًا بسبب عدم اتساق البيئة (هذه لن تؤدي إلى إنهاء العملية بل ستظهر في سجلات Docker). ونتيجة لذلك، قد تفشل بعض قواعد البيانات في التحميل بشكل صحيح، مما يؤدي إلى قواعد بيانات فارغة. وهذا سيؤدي إلى انخفاض نتائج التقييم بشكل غير طبيعي.  
👉 لذلك، نوصي بشدة بفحص سجلات Docker لأي أخطاء **قبل تشغيل التقييم** والتحقق من أن جميع قواعد البيانات تم تحميلها بنجاح.

## 📰 الأخبار

- [2025-08-26] 🚀 يسعدنا أن نعلن عن إصدار مجموعة **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
إنها مجموعة صعبة — حيث تحقق أفضل نماذج اللغة نسبة نجاح **16.33%** فقط، مع نسبة **10.0%** فقط في أجزاء `c-interact` و`a-interact`.  
👉 لمزيد من التفاصيل، يرجى زيارة [موقع المشروع](https://bird-interact.github.io/).

- [2025-08-26] 📬 سنرسل **البيانات الحقيقية وحالات الاختبار** إلى قائمتنا البريدية هذا الأسبوع.  
إذا كنت ترغب في الوصول المبكر، يرجى إرسال بريد إلكتروني كما هو موضح في الموقع للحصول على **تنزيل تلقائي**.  

- [2025-08-26] 💾 كما قمنا أيضًا بإصدار نسخة SQLite من **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** لسهولة البحث المحلي.  
الإصدارات الكاملة من **LiveSQLBench-Base** و **-Large** قادمة قريبًا!

- [2025-08-22] **تصحيح خطأ**: في كود Bird-Interact-Agent، قمنا بإصلاح خطأ حيث عند تقييم SQL المرحلة الثانية، لا يمكن تنفيذ SQL المرحلة الأولى المخزنة بنجاح، مما أدى إلى انخفاض معدل نجاح المرحلة الثانية. يؤثر هذا الخطأ فقط على المهام التي تقوم فيها SQL المرحلة الأولى ببعض العمليات على قاعدة البيانات، مثل إنشاء جدول، إلخ.

## 🧸 نظرة عامة

BIRD-INTERACT، معيار تفاعلي لتحويل النص إلى SQL، **يعيد تصور تقييم النص إلى SQL من خلال عدسة التفاعلات الديناميكية**.
يمزج هذا النظام بين قاعدة معرفة هرمية، وتوثيق قواعد البيانات، ومحاكي مستخدم قائم على الوظائف لإعادة خلق بيئات المؤسسات الحقيقية عبر جميع عمليات **CRUD** الكاملة.
يقدم وضعين اختبار صارمين: (1) **التفاعل الحواري** السلبي و(2) **التفاعل الوكيلي** النشط، يغطيان 600 مهمة مشروحة بما في ذلك استخبارات الأعمال (BI)، وعمليات CRUD وغيرها، كل منها محمي بحالات اختبار قابلة للتنفيذ.
تتسبب التقييمات النموذجية في حدوث 1,968-5,496 دورة تفاعل بين النموذج ومحاكي المستخدم، بينما النماذج المتقدمة لحل المسائل تحل فقط **≈24%** و **≈18%** من المهام، مما يبرز تحدي المعيار المرجعي.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ وضعا تقييم

يدعم BIRD-INTERACT وضعين للتقييم كما ذُكر أعلاه:

   - **c-Interact**: التفاعل الحواري وهو وضع سلبي ويكون سير العمل فيه ثابتًا. يمكن العثور على الكود والمعلومات التفصيلية في `bird_interact_conv`.
   - **a-Interact**: التفاعل الوكيلي وهو وضع نشط متجسد حيث يكون سير العمل ديناميكيًا ويقوده النموذج. يمكن العثور على الكود والمعلومات التفصيلية في `bird_interact_agent`.


### 🐣 النسخة الخفيفة

نقوم بإطلاق النسخة الخفيفة من BIRD-INTERACT، `bird-interact-lite-exp`، والتي تتضمن 270 مهمة واقعية عالية الجودة خاصة بـ PostgreSQL. وتعد نقطة بداية جيدة للتجارب السريعة.

### 🦜 النسخة الكاملة

النسخة الكاملة من BIRD-INTERACT، `bird-interact-full`، هي معيار شامل يتضمن 600 مهمة خاصة بـ PostgreSQL. تغطي مجموعة واسعة من عمليات SQL واستفسارات المستخدمين. ستتوفر النسخة الكاملة قريبًا.

### نتائج أداء النماذج على BIRD-INTERACT Lite

#### 1. أداء **c-Interact**
| الترتيب | اسم النموذج         | المكافأة المعيارية | المستوى        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 دردشة ممتازة |
| 2    | GPT-4o             | 30.33 | 💎 دردشة جيدة      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 دردشة جيدة      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ قياسي       |
| 5    | DeepSeek-R1        | 21.74 | ✨ قياسي       |
| 6    | Qwen3              | 20.33 | ⚪ أساسي          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ أساسي          |

#### 2. أداء **a-Interact**
| الترتيب | اسم النموذج         | معلمات الميزانية* | متوسط الخطوات/مهمة | متوسط التكلفة (دولار)/مهمة | المكافأة المعيارية | المستوى            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 تفاعل ممتاز          |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 تفاعل جيد             |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 تفاعل جيد             |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ قياسي                 |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ قياسي                 |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ أساسي                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ أساسي                 |

> \* معايير الميزانية: ميزانية البدء/ميزانية صبر المستخدم، تقاس بواسطة عملتنا الافتراضية *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. راجع [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) للمزيد من التفاصيل.

### مقياس زمن التفاعل (ITS)

يشير مقياس زمن التفاعل (ITS) إلى قدرة النموذج على زيادة أدائه النهائي باستمرار من خلال التفاعلات متعددة الجولات. عندما يتجاوز هذا الأداء التفاعلي أداء النموذج المثالي في جولة واحدة على مهمة محددة بالكامل وواضحة، نقول إنه يحقق **قانون ITS**. مع زيادة صبر المستخدم وتراكم جولات التفاعل، يستمر الأداء في التحسن، مما يدل على أن النموذج قادر على الحفاظ على التواصل الفعال خلال حوار طويل المدى. حالياً، نجد فقط claude-3-7-sonnet يحقق قانون ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 تفاصيل مجموعة البيانات

### وصف مجموعة البيانات

- **قاعدة البيانات:** يمكن تنزيل قاعدة بيانات PostgreSQL الكاملة من [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). راجع قسم [التقييم السريع](#quick-eval) للمزيد من التفاصيل.
- **البيانات:** يحتوي كل عنصر بيانات على الأجزاء الرئيسية التالية:
   - `selected_database`: اسم قاعدة البيانات.  
   - `query`: استعلام المستخدم الواضح وغير الغامض.  
   - `amb_user_query`: استعلام المستخدم مع الغموض المُضاف.
   - `user_query_ambiguity`: الغموض المُضاف لاستعلام المستخدم.
   - `non_critical_ambiguity`: الغموض غير الحرج مثل الترتيب، الحد، إلخ.
   - `knowledge_ambiguity`: الغموض الناتج عن إخفاء المعرفة الخارجية. 
   - `sol_sql`: حل SQL الصحيح.  
   - `preprocess_sql`: استعلامات SQL للتنفيذ قبل تنفيذ الحل أو التوقع.  
   - `clean_up_sql`: استعلامات SQL للتنفيذ بعد الحالات الاختبارية لإعادة قاعدة البيانات إلى حالتها الأصلية.  
   - `test_cases`: مجموعة من الحالات الاختبارية للتحقق من صحة استعلام SQL المتوقع.
   - `follow_up`: الأسئلة المتابعة المعلّمة.
   - `external_knowledge`: المعرفة الخارجية المتعلقة بالمهمة المحددة.

- **التقييم:** تتوفر شفرة التقييم في دليل [`./evaluation`](./evaluation).
- **تم الإعداد بواسطة:** فريق BIRD و Google Cloud
- **الرخصة:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **بطاقة مجموعة بيانات HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### استخدامات مجموعة البيانات

لتجنب تسرب البيانات عن طريق الزحف التلقائي، لا نقوم بتضمين حلول SQL النهائية وحالات الاختبار مع البيانات.
يرجى إرسال بريد إلكتروني إلى [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) مع وضع الوسم `[bird-interact-lite GT&Test Cases]` في عنوان الرسالة للحصول على المجموعة الكاملة، والتي سيتم إرسالها تلقائيًا.


<!-- ### استخدام مجموعة البيانات من HuggingFace

يمكنك تحميل مجموعة البيانات من HuggingFace باستخدام الأمر التالي:
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
- [x] إصدار نسخة الوكيل، bird-interact-agent.
- [x] إصدار النسخة الكاملة bird-interact-full (600).
- [ ] SFT / RL لمُحاكي المستخدم

## من إنشاء:
فريق BIRD & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---