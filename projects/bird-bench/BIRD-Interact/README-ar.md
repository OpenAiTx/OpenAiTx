# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

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

## 🧸 نظرة عامة

يُعيد BIRD-INTERACT، وهو معيار تفاعلي لتحويل النص إلى SQL، **تصوّر تقييم تحويل النص إلى SQL من خلال عدسة التفاعلات الديناميكية**.
تجمع البيئة بين قاعدة معرفة هرمية، ووثائق قاعدة البيانات، ومحاكي مستخدم قائم على الوظائف لإعادة خلق بيئات المؤسسات الحقيقية عبر عمليات **CRUD** الكاملة.
يقدم وضعين اختبار صارمين: (1) **التفاعل الحواري** السلبي و(2) **التفاعل الوكيلي** النشط، تشمل 600 مهمة مشروحة بما في ذلك استخبارات الأعمال (BI)، وعمليات CRUD وغيرها، كل واحدة محمية بحالات اختبار قابلة للتنفيذ.
تؤدي التقييمات النموذجية إلى 1,968-5,496 دورة تفاعلية بين النموذج ومحاكي المستخدم، بينما تحل النماذج الحديثة المتقدمة حاليًا فقط **≈24%** و**≈18%** من المهام، مما يُبرز تحدي هذا المعيار.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ وضعا التقييم

يدعم BIRD-INTERACT وضعين للتقييم كما ذُكر أعلاه:

   - **c-Interact**: التفاعل الحواري وهو وضع سلبي وسير العمل فيه ثابت. يمكن العثور على الكود والمعلومات التفصيلية في `bird_interact_conv`.
   - **a-Interact**: التفاعل الوكيلي وهو وضع نشط متجسد حيث يكون سير العمل ديناميكيًا ويقوده النموذج. يمكن العثور على الكود والمعلومات التفصيلية في `bird_interact_agent`.


### 🐣 الإصدار الخفيف

نحن نُصدر نسخة خفيفة من BIRD-INTERACT، باسم `bird-interact-lite-exp`، والتي تتضمن 270 مهمة عالية الجودة من العالم الحقيقي مخصصة لـ PostgreSQL. هذه نقطة انطلاق جيدة للتجارب السريعة.

### 🦜 الإصدار الكامل

الإصدار الكامل من BIRD-INTERACT، باسم `bird-interact-full`، هو معيار شامل يتضمن 600 مهمة لـ PostgreSQL. يغطي مجموعة واسعة من عمليات SQL واستفسارات المستخدم. الإصدار الكامل قادم قريبًا.

### نتائج أداء النماذج على BIRD-INTERACT Lite

#### 1. أداء **c-Interact**
| الترتيب | اسم النموذج         | المكافأة الموحدة | المستوى        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 دردشة ممتازة |
| 2    | GPT-4o             | 30.33 | 💎 دردشة جيدة      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 دردشة جيدة      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ عادي       |
| 5    | DeepSeek-R1        | 21.74 | ✨ عادي       |
| 6    | Qwen3              | 20.33 | ⚪ أساسي          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ أساسي          |

#### 2. أداء **a-Interact**
| الترتيب | اسم النموذج         | معلمات الميزانية* | متوسط الدورات/مهمة | متوسط التكلفة (دولار)/مهمة | المكافأة الموحدة | المستوى            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 تفاعل ممتاز |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 تفاعل جيد      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 تفاعل جيد      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ عادي              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ عادي              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ أساسي                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ أساسي                 |

> \* معلمات الميزانية: ميزانية البدء/ميزانية صبر المستخدم، مقاسة بعملتنا الافتراضية *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. راجع [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) للمزيد من التفاصيل.

### مقياس زمن التفاعل (ITS)

يشير مقياس زمن التفاعل (ITS) إلى قدرة النموذج على زيادة أدائه النهائي باستمرار من خلال التفاعلات متعددة الدورات. عندما يتجاوز هذا الأداء التفاعلي أداء النموذج المثالي في دورة واحدة على مهمة محددة بالكامل وغير غامضة، نقول إنه يحقق **قانون ITS**. مع زيادة صبر المستخدم وتراكم دورات التفاعل، يستمر الأداء في التحسن، مما يدل على أن النموذج يمكنه الحفاظ على تواصل فعال خلال حوار طويل. حاليًا، نجد فقط أن claude-3-7-sonnet يحقق قانون ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 تفاصيل مجموعة البيانات

### وصف مجموعة البيانات

- **قاعدة البيانات:** يمكن تنزيل قاعدة بيانات PostgreSQL الكاملة من [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). تحقق من قسم [التقييم السريع](#quick-eval) لمزيد من التفاصيل.
- **البيانات:** كل عنصر بيانات يحتوي على الأجزاء الرئيسية التالية:
   - `selected_database`: اسم قاعدة البيانات.  
   - `query`: استعلام المستخدم غير الغامض.  
   - `amb_user_query`: استعلام المستخدم مع الغموض المُضاف.
   - `user_query_ambiguity`: الغموض المُضاف إلى استعلام المستخدم.
   - `non_critical_ambiguity`: الغموض غير الحرج مثل الترتيب، الحد، إلخ.
   - `knowledge_ambiguity`: الغموضات الناتجة عن إخفاء المعارف الخارجية.
   - `sol_sql`: حل SQL الصحيح (الحل الأرضي).
   - `preprocess_sql`: استعلامات SQL التي يتم تشغيلها قبل تنفيذ الحل أو التنبؤ.
   - `clean_up_sql`: استعلامات SQL التي يتم تشغيلها بعد حالات الاختبار لإرجاع أي تغييرات أجريت على قاعدة البيانات.
   - `test_cases`: مجموعة من حالات الاختبار للتحقق من صحة استعلام SQL المصحح المتوقع.
   - `follow_up`: أسئلة المتابعة الموصوفة بالعلامات.
   - `external_knowledge`: المعرفة الخارجية المتعلقة بالمهمة المحددة.

- **التقييم:** كود التقييم متوفر في دليل [`./evaluation`](./evaluation).
- **تنسيق بواسطة:** فريق BIRD و Google Cloud
- **الترخيص:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **بطاقة مجموعة بيانات HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### استخدامات مجموعة البيانات

لتجنب تسرب البيانات عن طريق الزحف التلقائي، لا نقوم بتضمين حلول SQL الصحيحة وحالات الاختبار مع البيانات.
يرجى إرسال بريد إلكتروني إلى [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) مع الوسم `[bird-interact-lite GT&Test Cases]` في العنوان للحصول على المجموعة الكاملة، وسيتم إرسالها تلقائياً.


<!-- ### استخدام مجموعة البيانات من HuggingFace

يمكنك تحميل مجموعة البيانات من HuggingFace باستخدام الأمر التالي:
```bash
from datasets import load_dataset
# تحميل النسخة السريعة من مجموعة البيانات
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# تحميل النسخة الكاملة من مجموعة البيانات (قريباً)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

أو يمكنك استخدام السكريبت المرفق لتحميل النسخة الكاملة من مجموعة البيانات وتقسيمها حسب اللهجات المختلفة.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # مسار ملف JSONL المدخل (قد يكون فارغاً إذا كنت ترغب في تحميل مجموعة البيانات من HuggingFace)
  --output_folder path/to/output_dir # مجلد إخراج الملفات المقسمة
``` -->

## هيكلية المجلدات
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
يمكن العثور على تفاصيل تشغيل **a-interact** في `./bird_interact_agent/README.md`؛ وتفاصيل **c-interact** في `./bird_interact_conv/README.md`.


## 📋 قوائم المهام

- [x] إصدار النسخة الخفيفة، bird-interact-lite (270).
- [x] إصدار النسخة الحوارية، bird-interact-conv.
- [x] إصدار النسخة الوكيل، bird-interact-agent.
- [ ] إصدار النسخة الكاملة bird-interact-full (600).
- [ ] SFT / RL ومحاكي المستخدم

## تم الإنشاء بواسطة:
فريق BIRD و Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---