<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

## اخبار
- [2025-08-22] **رفع اشکال**: در کد Bird-Interact-Agent، یک اشکال رفع شد که هنگام ارزیابی SQL فاز-۲، SQL ذخیره شده از فاز-۱ نمی‌توانست به‌درستی اجرا شود و منجر به کاهش نرخ موفقیت فاز-۲ می‌شد. این اشکال فقط بر وظایفی تاثیرگذار بود که sql فاز اول عملیاتی مانند CREATE table و غیره را روی پایگاه داده انجام می‌دهد.

## 🧸 مرور کلی

BIRD-INTERACT، یک بنچمارک تعاملی متن-به-SQL، **ارزیابی Text-to-SQL را از منظر تعاملات پویا بازتصور می‌کند**.
این محیط، پایگاه دانش سلسله‌مراتبی، مستندات پایگاه داده و یک شبیه‌ساز کاربر مبتنی بر تابع را ترکیب می‌کند تا محیط‌های واقعی سازمانی را در عملیات کامل **CRUD** بازسازی کند.
دو حالت تست سختگیرانه ارائه می‌دهد: (۱) **تعامل مکالمه‌ای** منفعل و (۲) **تعامل عاملی** فعال، دربرگیرنده ۶۰۰ وظیفه حاشیه‌نویسی شده شامل هوش تجاری (BI)، عملیات CRUD و غیره، که هرکدام توسط کیس‌های تست اجرایی محافظت می‌شوند.
ارزیابی‌های معمول ۱,۹۶۸ تا ۵,۴۹۶ نوبت تعامل بین مدل و شبیه‌ساز کاربر را فعال می‌کنند، در حالی که مدل‌های استدلال پیشرفته فعلاً فقط **≈۲۴٪** و **≈۱۸٪** وظایف را حل می‌کنند که چالش‌برانگیز بودن این بنچمارک را نشان می‌دهد.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ دو حالت ارزیابی

BIRD-INTERACT از دو حالت ارزیابی که در بالا اشاره شد پشتیبانی می‌کند:

   - **c-Interact**: تعامل مکالمه‌ای که یک حالت منفعل است و فرآیند کاری آن ثابت می‌باشد. کد و اطلاعات دقیق در `bird_interact_conv` قابل مشاهده است.
   - **a-Interact**: تعامل عاملی که یک حالت فعال و مجسم است، در آن فرآیند کاری پویا بوده و توسط مدل‌ها هدایت می‌شود. کد و اطلاعات دقیق در `bird_interact_agent` قابل مشاهده است.


### 🐣 نسخه لایت

ما نسخه لایت BIRD-INTERACT با نام `bird-interact-lite-exp` را منتشر کرده‌ایم که شامل ۲۷۰ وظیفه واقعی و باکیفیت بالا مخصوص PostgreSQL است. این نسخه نقطه شروع خوبی برای آزمایش سریع محسوب می‌شود.

### 🦜 نسخه کامل

نسخه کامل BIRD-INTERACT با نام `bird-interact-full` یک بنچمارک جامع است که شامل ۶۰۰ وظیفه برای PostgreSQL می‌باشد. این نسخه دامنه وسیعی از عملیات SQL و پرس‌وجوهای کاربر را پوشش می‌دهد. نسخه کامل به زودی عرضه می‌شود.

### نتایج عملکرد مدل‌ها روی نسخه لایت BIRD-INTERACT

#### ۱. عملکرد **c-Interact**
| رتبه | نام مدل            | پاداش نرمال‌شده | سطح            |
|:------:|--------------------|:-------:|:--------------:|
| ۱    | o3-mini            | ۳۳.۰۴ | 🏆 چت عالی       |
| ۲    | GPT-4o             | ۳۰.۳۳ | 💎 چت خوب         |
| ۳    | Gemini-2.0-flash   | ۲۷.۴۱ | 💎 چت خوب         |
| ۴    | Claude-3.7-sonnet  | ۲۶.۶۰ | ✨ استاندارد      |
| ۵    | DeepSeek-R1        | ۲۱.۷۴ | ✨ استاندارد      |
| ۶    | Qwen3              | ۲۰.۳۳ | ⚪ پایه            |
| ۷    | DeepSeek-V3        | ۱۵.۸۵ | ⚪ پایه            |

#### ۲. عملکرد **a-Interact**
| رتبه | نام مدل            | پارامترهای بودجه* | متوسط گام/وظیفه | متوسط هزینه (دلار)/وظیفه | پاداش نرمال‌شده | سطح                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| ۱    | Claude-3.7-sonnet  | ۶/۶ | ۱۵.۴ | $۰.۶۶۶۸ | ۲۹.۱۹ | 🏆 تعامل عالی            |
| ۲    | o3-mini            | ۶/۶ | ۷.۸  | $۰.۰۷۵۴ | ۲۱.۰۷ | 💎 تعامل خوب             |
| ۳    | DeepSeek-V3        | ۶/۶ | ۱۵.۶ | $۰.۰۶۲۹ | ۱۹.۱۹ | 💎 تعامل خوب             |
| ۴    | Qwen3              | ۶/۶ | ۱۲.۵ | $۰.۰۲۷۸ | ۱۸.۷۴ | ✨ استاندارد             |
| ۵    | GPT-4o             | ۶/۶ | ۱۵.۳ | $۰.۴۵۹۴ | ۱۸.۳۷ | ✨ استاندارد             |
| ۶    | Gemini-2.0-flash   | ۶/۶ | ۱۳.۲ | $۰.۰۳۳۷ | ۱۷.۲۶ | ⚪ پایه                   |
| ۷    | DeepSeek-R1        | ۶/۶ | ۱۲.۰ | $۰.۰۹۳۱ | ۱۷.۰۷ | ⚪ پایه                   |

> \* پارامترهای بودجه: بودجه اولیه/بودجه صبر کاربر که با واحد ارز مجازی *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> اندازه‌گیری شده است. برای جزئیات بیشتر به [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) مراجعه کنید.

### مقیاس‌پذیری زمان تعامل (ITS)

مقیاس‌پذیری زمان تعامل (ITS) به قابلیت مدل برای افزایش مداوم عملکرد نهایی خود از طریق تعاملات چندمرحله‌ای اشاره دارد. زمانی که این عملکرد تعاملی از عملکرد ایده‌آل مدل در یک وظیفه کاملاً مشخص و بدون ابهام بالاتر رود، گفته می‌شود که مدل از **قانون ITS** پیروی می‌کند. با افزایش صبر کاربر و تجمع مراحل تعامل، عملکرد مدل ارتقا می‌یابد و نشان می‌دهد که می‌تواند ارتباط مؤثر را در گفتگوهای طولانی حفظ کند. در حال حاضر فقط مدل claude-3-7-sonnet با قانون ITS مطابقت دارد.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 جزئیات دیتاست

### توضیحات دیتاست

- **دیتابیس:** دیتابیس کامل PostgreSQL را می‌توانید از [گوگل درایو](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) دانلود کنید. برای جزئیات بیشتر بخش [ارزیابی سریع](#quick-eval) را بررسی کنید.
- **data:** هر نمونه داده شامل بخش‌های اصلی زیر است:
   - `selected_database`: نام دیتابیس.  
   - `query`: پرسش کاربر بدون ابهام.  
   - `amb_user_query`: پرسش کاربر با ابهامات تزریق شده.
   - `user_query_ambiguity`: ابهامات تزریق شده به پرسش کاربر.
   - `non_critical_ambiguity`: ابهامات غیر بحرانی مانند ترتیب، محدودیت، و غیره.
   - `knowledge_ambiguity`: ابهاماتی که توسط دانش‌های بیرونی ماسک‌شده ایجاد می‌شوند. 
   - `sol_sql`: راه‌حل SQL مرجع.  
   - `preprocess_sql`: کوئری‌های SQL که قبل از اجرای راه‌حل یا پیش‌بینی اجرا می‌شوند.  
   - `clean_up_sql`: کوئری‌های SQL که بعد از تست‌ها برای بازگرداندن تغییرات اعمال‌شده بر دیتابیس اجرا می‌شوند.  
   - `test_cases`: مجموعه‌ای از تست‌ها برای اعتبارسنجی SQL اصلاح‌شده پیش‌بینی‌شده.
   - `follow_up`: پرسش‌های پیگیری برچسب‌گذاری‌شده.
   - `external_knowledge`: دانش بیرونی مرتبط با وظیفه خاص.

- **ارزیابی:** کد ارزیابی در دایرکتوری [`./evaluation`](./evaluation) موجود است.
- **تدوین شده توسط:** تیم BIRD و Google Cloud
- **مجوز:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **کارت دیتاست HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### کاربردهای دیتاست

به منظور جلوگیری از نشت داده از طریق خزیدن خودکار، راه‌حل‌های GT SQL و تست‌ها را همراه با داده ارائه نمی‌کنیم.
لطفاً برای دریافت مجموعه کامل با عنوان `[bird-interact-lite GT&Test Cases]` به [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) ایمیل بزنید تا به صورت خودکار ارسال شود.


<!-- ### استفاده از دیتاست از HuggingFace

می‌توانید دیتاست را با دستور زیر از HuggingFace دانلود کنید:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
یا می‌توانید از اسکریپت ارائه‌شده برای دانلود نسخه کامل دیتاست استفاده کنید و آن را به لهجه‌های مختلف تقسیم کنید.

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # مسیر فایل ورودی JSONL (ممکن است خالی باشد اگر بخواهید دیتاست را از HuggingFace دانلود کنید)
  --output_folder path/to/output_dir # پوشه خروجی فایل‌های تقسیم شده
```

## ساختار پوشه‌ها
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
جزئیات مربوط به اجرای **a-interact** را می‌توانید در فایل `./bird_interact_agent/README.md` پیدا کنید؛ و اطلاعات مربوط به **c-interact** در فایل `./bird_interact_conv/README.md` موجود است.

## 📰 اخبار

🚀 با هیجان اعلام می‌کنیم که مجموعه **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** منتشر شد!  
این مجموعه بسیار دشوار است — بهترین مدل‌های زبانی تنها به نرخ موفقیت **16.33%** رسیده‌اند، و فقط **10.0%** در بخش‌های `c-interact` و `a-interact` موفق بوده‌اند.  
👉 برای جزئیات بیشتر، لطفاً به [وبسایت پروژه](https://bird-interact.github.io/) مراجعه کنید.

📬 این هفته **پاسخ‌های صحیح و موارد تست** را برای اعضای لیست ایمیل ارسال خواهیم کرد.  
اگر دسترسی زودهنگام می‌خواهید، طبق راهنمای سایت یک ایمیل ارسال کنید تا **دانلود خودکار** دریافت نمایید.  

💾 همچنین نسخه SQLite از **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** را برای پژوهش محلی آسان‌تر منتشر کردیم.  
نسخه کامل **LiveSQLBench-Base** و **-Large** به زودی منتشر می‌شود!

## 📋 فهرست کارها

- [x] انتشار نسخه سبک، bird-interact-lite (270).
- [x] انتشار نسخه مکالمه‌ای، bird-interact-conv.
- [x] انتشار نسخه عامل، bird-interact-agent.
- [x] انتشار نسخه کامل bird-interact-full (600).
- [ ] آموزش SFT / RL یک شبیه‌ساز کاربر

## ساخته شده توسط:
تیم BIRD و Google Cloud



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---