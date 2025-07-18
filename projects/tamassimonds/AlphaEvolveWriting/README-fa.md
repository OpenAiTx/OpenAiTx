<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=tamassimonds&project=AlphaEvolveWriting&lang=en">انگلیسی</a>
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

# آلفاایوالو رایتینگ

![فرآیند نوشتن AlphaEvolve](https://raw.githubusercontent.com/tamassimonds/AlphaEvolveWriting/main/assets/AlphaWriteProcess.png)

شما می‌توانید توضیحات کامل را [اینجا](https://tobysimonds.com/research/2025/06/06/LLM-Self-Rewarding-copy.html) بیابید.

نمونه‌ای از داستان ارسال شده به یک مسابقه نویسندگی را [اینجا](https://blog.reedsy.com/short-story/wo9iuy/#comments) مشاهده کنید.

یک سیستم نوشتاری مدرن و تکاملی که از مدل‌های هوش مصنوعی برای تولید، ارزیابی و تکامل داستان‌ها یا متون عمومی به‌صورت رقابتی و تکراری استفاده می‌کند. ساخته شده با معماری پایتون مدولار و تمیز بر اساس اصول طراحی مدرن.




## ✨ ویژگی‌ها

- 🧬 **الگوریتم تکاملی**: داستان‌ها از طریق تورنمنت‌های مبتنی بر هوش مصنوعی تکامل می‌یابند
- 🎯 **دو حالت نگارش**: داستان‌نویسی خلاقانه و بهینه‌سازی نگارش عمومی
- 🏆 **سیستم تورنمنت ELO**: رتبه‌بندی پیشرفته با مقایسه‌های جفتی
- 🌐 **رابط وب**: ابزارهای اعتبارسنجی انسانی و مقایسه داستان
- 🔧 **قابل پیکربندی**: سفارشی‌سازی گسترده با تنظیمات JSON

## 🚀 شروع سریع

### نصب


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
### اجرای فرگشت


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
## 🏗️ معماری

سیستم از اصول طراحی مدرن پایتون با جداسازی دقیق مسئولیت‌ها پیروی می‌کند:


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
### اجزای کلیدی

- **`EvolutionPipeline`**: هماهنگ‌کننده اصلی که چرخه کامل تکامل را مدیریت می‌کند
- **`InitialStoryGenerator`**: اولین نسل داستان‌ها را از روی پرامپت‌ها ایجاد می‌کند
- **`NextBatchGenerator`**: بهترین عملکردها را به نسخه‌های بهبود یافته تکامل می‌دهد
- **`TournamentRunner`**: مدیریت تورنمنت‌های ELO برای رتبه‌بندی داستان‌ها
- **`EloRankingSystem`**: پیاده‌سازی الگوریتم رتبه‌بندی پیشرفته

## 📖 نحوه عملکرد

سیستم از یک چرخه سه‌مرحله‌ای تکامل پیروی می‌کند:

### 1. **ایجاد دسته اولیه**
- چندین داستان بر اساس پرامپت شما ایجاد می‌کند
- از مدل‌های هوش مصنوعی قابل پیکربندی (GPT، Claude، Llama و غیره) استفاده می‌کند
- به هر داستان امتیاز اولیه ELO اختصاص می‌دهد

### 2. **اجرای تورنمنت ELO**
- داستان‌ها در مقایسه‌های جفتی با هم رقابت می‌کنند
- داوران هوش مصنوعی بر اساس معیار شما ارزیابی می‌کنند
- امتیازهای ELO بر اساس برد/باخت به‌روزرسانی می‌شود

### 3. **ایجاد دسته بعدی**
- داستان‌های با عملکرد برتر انتخاب می‌شوند
- نسخه‌های بهبودیافته از آنها تولید می‌شود
- این فرایند برای نسل‌های متعدد تکرار می‌شود

این فرایند تکراری، به تدریج به تولید متون بهتر منجر می‌شود.

## ⚙️ پیکربندی

### راه‌اندازی اولیه

فایل‌های کلیدی زیر را ویرایش کنید:

- **`prompt.txt`** - پرامپت/تم نوشتاری شما
- **`rubric.txt`** - معیارهای داوری برای ارزیابی
- **`config.json`** - پیکربندی سیستم

### راه‌اندازی کلیدهای API

سیستم از چندین ارائه‌دهنده هوش مصنوعی پشتیبانی می‌کند که از طریق `config.json` پیکربندی می‌شوند. این پیکربندی مدل‌ها را به ارائه‌دهندگان نگاشت کرده و متغیرهای محیطی حاوی کلیدهای API را مشخص می‌کند:


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
سپس کلیدهای API خود را به عنوان متغیرهای محیطی تنظیم کنید:


```bash
export OPENAI_API_KEY="your-openai-key"        # For GPT models
export ANTHROPIC_API_KEY="your-anthropic-key"  # For Claude models  
export DEEPINFRA_API_KEY="your-deepinfra-key"  # For Llama models
export DEEPSEEK_API_KEY="your-deepseek-key"    # For DeepSeek models
export GEMINI_API_KEY="your-gemini-key"          # For Gemini models
```
شما فقط نیاز دارید کلیدها را برای ارائه‌دهندگانی که قصد استفاده از آن‌ها را دارید تنظیم کنید. سیستم به طور خودکار درخواست‌های مدل را بر اساس پیکربندی به ارائه‌دهنده صحیح هدایت می‌کند.

### گزینه‌های پیکربندی

فایل `config.json` تمامی رفتارهای سیستم را کنترل می‌کند:


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
## 🎭 حالت‌های نگارش

### حالت نگارش خلاقانه (پیش‌فرض)
- بر داستان‌سرایی، توسعه شخصیت و تکنیک‌های روایی تمرکز دارد
- از استراتژی‌های تولید مبتنی بر ماموریت استفاده می‌کند
- برای خلاقیت و جذب مخاطب بهینه‌سازی شده است

### حالت نگارش عمومی (`--general`)
- بر مقالات علمی، مقاله‌نویسی، گزارش‌ها و نگارش حرفه‌ای تمرکز دارد
- از رویکردهای تحلیلی و ساختاریافته بهره می‌برد
- برای وضوح و تاثیرگذاری بهینه‌سازی شده است

## 🔧 پیکربندی پیشرفته

### سفارشی‌سازی استراتژی‌های تولید

برای کاربران پیشرفته، می‌توانید اعلان‌های تولید، سبک‌های نویسنده و مجموعه ماموریت‌ها را با ویرایش فایل‌های موجود در مسیر `src/generators/` شخصی‌سازی کنید:

#### سفارشی‌سازی نگارش خلاقانه (`src/generators/generate_response.py`)

**مجموعه ماموریت‌ها** - رویکردها و اهداف خلاقانه را تعریف کنید:

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
**سبک‌های نویسنده** - تقلید رویکردهای مختلف نوشتن:

```python
author_styles = [
    "Write with the psychological insight of Virginia Woolf",
    "Adopt the sparse, powerful prose of Ernest Hemingway", 
    "Use the magical realism style of Gabriel García Márquez",
    "Employ the detailed world-building of Tolkien"
]
```
#### سفارشی‌سازی نگارش عمومی (`src/generators/generate_response_general.py`)

**حوزه‌های تمرکز علمی** - هدف‌گذاری بر حوزه‌های خاص نگارشی:

```python
academic_focuses = [
    "Rigorous analytical argument development",
    "Clear thesis statement and supporting evidence",
    "Proper academic citation and source integration",
    "Logical flow and coherent structure"
]
```
**رویکردهای نگارش** - استراتژی‌های تحلیلی را تعریف کنید:

```python
writing_approaches = [
    "Comparative analysis with multiple perspectives",
    "Problem-solution framework with evidence",
    "Cause-and-effect reasoning with examples",
    "Critical evaluation with balanced arguments"
]
```
### سفارشی‌سازی معیارهای داوری (`src/generators/judge_response.py`)

شما می‌توانید معیارهای داوری و جملات ارزیابی را تغییر دهید تا بر جنبه‌های خاصی از کیفیت نوشتار تمرکز کنید:


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
### نکات برای پیکربندی پیشرفته

1. **پشتیبان‌گیری از فایل‌های اصلی**: همیشه قبل از اعمال تغییرات، نسخه‌ای از فایل‌های اصلی ژنراتور را نگه دارید
2. **آزمایش تدریجی**: تغییرات کوچک ایجاد کنید و با چند تکرار آزمایش انجام دهید قبل از اجرای کامل چرخه‌های تکاملی
3. **پایش نتایج**: از رابط وب برای اطمینان از اینکه سفارشی‌سازی‌های شما کیفیت داستان را بهبود داده‌اند استفاده کنید
4. **ترکیب و تطبیق**: مجموعه‌های ماموریت و سبک‌های نویسنده مختلف را برای استراتژی‌های تولید منحصربه‌فرد ترکیب کنید
5. **کنترل نسخه**: سفارشی‌سازی‌های خود را با گیت دنبال کنید تا در صورت نیاز بتوانید بازگردانی کنید

این رویکرد ماژولار به شما امکان می‌دهد فرآیند تکامل را برای اهداف و حوزه‌های نوشتاری خاص خود به دقت تنظیم کنید.

## 🌐 رابط وب

نتایج تکامل خود را با رابط وب داخلی اعتبارسنجی کنید:


```bash
cd web_interface
pip install -r requirements.txt
python app.py
```
http://localhost:5000 را باز کنید تا به موارد زیر دسترسی داشته باشید:

- **مقایسه داستان‌ها**: خواندن کنار هم و انتخاب ترجیحی
- **رتبه‌بندی ELO**: مشاهده رده‌بندی‌ها و آمار فعلی
- **پیگیری تکامل**: اطمینان از بهبود نسل‌های بعدی
- **خروجی داده**: دانلود نتایج برای تحلیل


```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---