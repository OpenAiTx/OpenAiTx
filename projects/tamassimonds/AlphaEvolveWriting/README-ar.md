<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">الإنجليزية</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# كتابة AlphaEvolve

![عملية كتابة AlphaEvolve](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

يمكنك العثور على الشرح الكامل [هنا](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html)

يمكنك الاطلاع على قصة نموذجية تم تقديمها في مسابقة كتابة [هنا](https://blog.reedsy.com/short-story/wo9iuy/#comments)

نظام كتابة حديث وتطوري يستخدم نماذج الذكاء الاصطناعي لتوليد وتقييم وتطوير القصص الإبداعية أو قطع الكتابة العامة من خلال مسابقات تكرارية. تم بناؤه بهندسة بايثون نظيفة ووحدوية وفقًا لمبادئ التصميم الحديثة.




## ✨ الميزات

- 🧬 **خوارزمية تطورية**: تتطور القصص من خلال بطولات مدعومة بالذكاء الاصطناعي
- 🎯 **وضعا كتابة مزدوجان**: السرد الإبداعي وتحسين الكتابة العامة
- 🏆 **نظام بطولة ELO**: تصنيف متقدم من خلال المقارنات الثنائية
- 🌐 **واجهة ويب**: أدوات تحقق بشري ومقارنة القصص
- 🔧 **قابل للتكوين**: تخصيص واسع من خلال إعدادات JSON

## 🚀 البدء السريع

### التثبيت


```bash
# Clone the repository
git clone https://github.com/your-org/alphaevolve-writing
cd alphaevolve-writing

# Install with uv (recommended)
uv sync

# Or install with pip
pip install -e .

# Configure your API keys (see Configuration section below)
```
### تشغيل Evolution


```bash
# Run 5 evolution iterations
python evolve.py 5

# Fresh start with 3 iterations
python evolve.py 3 --fresh

# Use general writing mode
python evolve.py 5 --general

# Show help
python evolve.py --help
```
## 🏗️ الهيكلية

يتبع النظام مبادئ تصميم بايثون الحديثة مع فصل واضح للاختصاصات:


```
├── src/
│   ├── core/           # Pipeline orchestration
│   │   └── pipeline.py # Main EvolutionPipeline class
│   ├── generators/     # Story generation logic
│   │   ├── story_generator.py      # Initial & next batch generators
│   │   ├── generate_response.py    # Creative writing generation
│   │   ├── generate_response_general.py # General writing generation
│   │   └── judge_response.py       # AI judging system
│   ├── rankers/        # ELO ranking system
│   │   ├── elo_rank.py            # Core ELO algorithm
│   │   └── tournament_runner.py    # Tournament management
│   └── utils/          # Utility functions
│       └── inference.py           # Multi-provider LLM interface
├── evolve.py           # Clean CLI entry point
├── pyproject.toml      # Modern Python packaging
├── config.json         # Configuration
└── web_interface/      # Web UI for validation
```
### المكونات الرئيسية

- **`EvolutionPipeline`**: المنسق الرئيسي الذي يدير دورة التطور الكاملة
- **`InitialStoryGenerator`**: ينشئ الجيل الأول من القصص من التعليمات
- **`NextBatchGenerator`**: يطور أفضل القصص إلى نسخ محسنة
- **`TournamentRunner`**: يدير بطولات ELO لترتيب القصص
- **`EloRankingSystem`**: يطبق خوارزمية ترتيب متقدمة

## 📖 كيف يعمل

يتبع النظام دورة تطور من ثلاث مراحل:

### 1. **إنشاء الدفعة الأولى**
- ينشئ عدة قصص من التعليمات الخاصة بك
- يستخدم نماذج ذكاء اصطناعي قابلة للتهيئة (GPT، Claude، Llama، إلخ)
- يخصص تقييمات ELO ابتدائية

### 2. **تشغيل بطولة ELO**
- تتنافس القصص في مقارنات ثنائية
- يقيم الحكام الآليون بناءً على معاييرك
- يتم تحديث تقييمات ELO بناءً على الفوز/الخسارة

### 3. **إنشاء الدفعة التالية**
- يتم اختيار القصص الأعلى أداءً
- يتم توليد نسخ محسنة منها
- تتكرر العملية لعدة أجيال

تؤدي هذه العملية التكرارية إلى تطوير جودة الكتابة مع مرور الوقت.

## ⚙️ الإعداد

### الإعداد الأساسي

قم بتحرير هذه الملفات الرئيسية:

- **`prompt.txt`** - موضوع/تعليمات الكتابة الخاصة بك
- **`rubric.txt`** - معايير التحكيم للتقييم
- **`config.json`** - إعدادات النظام

### إعداد مفاتيح API

يدعم النظام عدة مزودي ذكاء اصطناعي يتم ضبطهم عبر `config.json`. يربط الإعداد النماذج بالمزودين ويحدد متغيرات البيئة التي تحتوي على مفاتيح الـ API:


```json
{
  "llm_providers": {
    "openai": {
      "type": "openai",
      "base_url": "https://api.openai.com/v1",
      "api_key_env": "OPENAI_API_KEY"
    },
    "anthropic": {
      "type": "anthropic", 
      "api_key_env": "ANTHROPIC_API_KEY"
    },
    "deepinfra": {
      "type": "openai_compatible",
      "base_url": "https://api.deepinfra.com/v1/openai",
      "api_key_env": "DEEPINFRA_API_KEY"
    },
    "deepseek": {
      "type": "openai_compatible",
      "base_url": "https://api.deepseek.com/v1",
      "api_key_env": "DEEPSEEK_API_KEY"
    },
    "gemini": {
      "type": "openai_compatible",
      "api_key_env": "GEMINI_API_KEY",
      "base_url": "https://generativelanguage.googleapis.com/v1beta/openai/"
    }
  },
  "model_provider_mapping": {
    "gpt-4": "openai",
    "gpt-3.5-turbo": "openai", 
    "claude-3-sonnet-20240229": "anthropic",
    "meta-llama/Meta-Llama-3-70B-Instruct": "deepinfra",
    "deepseek-chat": "deepseek",
    "gemini-2.5-flash": "gemini"
  }
}
```
ثم قم بتعيين مفاتيح API الخاصة بك كمتغيرات بيئة:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
أنت بحاجة فقط إلى تعيين المفاتيح لمزودي الخدمة الذين تخطط لاستخدامهم. يقوم النظام تلقائيًا بتوجيه طلبات النماذج إلى المزود الصحيح بناءً على الإعدادات.

### خيارات الإعداد

يتحكم ملف `config.json` في جميع سلوكيات النظام:


```json
{
  "batch_generation": {
    "num_stories": 10,
    "model": "gpt-4",
    "initial_elo": 1500
  },
  "elo_ranking": {
    "tournament_rounds": 50,
    "judge_model": "claude-3-sonnet-20240229",
    "k_factor": 32
  },
  "next_batch_generation": {
    "top_stories_to_select": 3,
    "variants_per_story": 2,
    "include_original_stories": true
  },
  "evolution_pipeline": {
    "max_iterations": 5,
    "auto_continue_from_existing": true
  }
}
```
## 🎭 أوضاع الكتابة

### وضع الكتابة الإبداعية (الافتراضي)
- يركز على سرد القصص، وتطوير الشخصيات، وتقنيات السرد
- يستخدم استراتيجيات التوليد القائمة على المهام
- يُحسَّن من أجل الإبداع والجاذبية

### وضع الكتابة العامة (`--general`)
- يركز على الأوراق الأكاديمية، والمقالات، والتقارير، والكتابة المهنية
- يستخدم أساليب تحليلية ومنهجية
- يُحسَّن من أجل الوضوح والإقناع

## 🔧 الإعدادات المتقدمة

### تخصيص استراتيجيات التوليد

للمستخدمين المتقدمين، يمكنك تخصيص محفزات التوليد، وأنماط المؤلفين، ومجموعات المهام عبر تعديل الملفات في دليل `src/generators/`:

#### تخصيص الكتابة الإبداعية (`src/generators/generate_response.py`)

**مجموعات المهام** - تحديد الأساليب الإبداعية والأهداف:

```python
mission_sets = {
    "emotional_depth": [
        "Focus on the psychological depth of characters",
        "Explore complex emotional landscapes", 
        "Create moments of genuine human connection"
    ],
    "narrative_craft": [
        "Experiment with unique narrative structures",
        "Use vivid, sensory descriptions",
        "Create compelling story arcs"
    ],
    "dialogue_mastery": [
        "Write authentic, character-specific dialogue",
        "Use subtext and implied meaning",
        "Balance dialogue with action and description"
    ]
}
```
**أنماط المؤلف** - تقليد أساليب الكتابة المختلفة:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### تخصيص الكتابة العامة (`src/generators/generate_response_general.py`)

**مجالات التركيز الأكاديمية** - استهداف مجالات كتابة محددة:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**طرق الكتابة** - تحديد الاستراتيجيات التحليلية:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### تخصيص معايير التحكيم (`src/generators/judge_response.py`)

يمكنك تعديل معايير التحكيم ومطالبات التقييم للتركيز على جوانب محددة من جودة الكتابة:


```python
# Edit the judge_responses function to customize evaluation criteria
evaluation_criteria = [
    "Technical writing proficiency",
    "Creative originality and innovation", 
    "Emotional impact and reader engagement",
    "Structural coherence and flow",
    "Character development and authenticity"
]
```
### نصائح للإعداد المتقدم

1. **نسخ احتياطي للملفات الأصلية**: احتفظ دائمًا بنسخ من ملفات المولد الأصلية قبل إجراء أي تغييرات
2. **الاختبار التدريجي**: قم بإجراء تغييرات صغيرة واختبرها بعدة تكرارات قبل تشغيل دورات التطور الكاملة
3. **مراقبة النتائج**: استخدم واجهة الويب للتحقق من أن تخصيصاتك تحسن جودة القصة
4. **التوليف والمزج**: امزج مجموعات المهام المختلفة وأنماط المؤلفين لاستراتيجيات توليد فريدة
5. **إدارة الإصدارات**: تتبع تخصيصاتك باستخدام git للرجوع عنها عند الحاجة

تسمح لك هذه الطريقة المعيارية بضبط عملية التطور بدقة لتناسب أهدافك ومجالاتك الكتابية المحددة.

## 🌐 واجهة الويب

تحقق من نتائج التطور الخاصة بك باستخدام واجهة الويب المدمجة:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
افتح http://localhost:5000 للوصول إلى:

- **مقارنة القصص**: قراءة جنبًا إلى جنب واختيار التفضيل
- **تصنيفات ELO**: عرض الترتيب الحالي والإحصائيات
- **تتبع التطور**: التحقق من تحسن الأجيال اللاحقة
- **تصدير البيانات**: تنزيل النتائج للتحليل


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---