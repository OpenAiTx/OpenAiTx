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

## 🧸 مروری کلی

BIRD-INTERACT، یک معیار تعاملی متن به SQL است که **ارزیابی Text-to-SQL را از منظر تعاملات پویا بازآفرینی می‌کند**.
این محیط با ترکیب یک پایگاه دانش سلسله‌مراتبی، مستندسازی پایگاه داده و شبیه‌ساز کاربر مبتنی بر تابع، محیط‌های واقعی سازمانی را در سراسر عملیات **CRUD** بازسازی می‌کند.
این معیار دو حالت تست سختگیرانه ارائه می‌دهد: (۱) **تعامل مکالمه‌ای** (غیرفعال) و (۲) **تعامل عاملی** (فعال)، که ۶۰۰ وظیفه حاشیه‌نویسی‌شده شامل هوش تجاری (BI)، عملیات CRUD و غیره را دربرمی‌گیرد و هر کدام توسط موارد تست قابل اجرا محافظت می‌شوند.
ارزیابی‌های معمولی باعث ایجاد ۱,۹۶۸ تا ۵,۴۹۶ نوبت تعامل بین مدل و شبیه‌ساز کاربر می‌شود، در حالی که مدل‌های استدلال پیشرفته فعلی تنها **≈۲۴٪** و **≈۱۸٪** از وظایف را حل می‌کنند که چالش‌برانگیز بودن این معیار را نشان می‌دهد.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ دو حالت ارزیابی

BIRD-INTERACT از دو حالت ارزیابی زیر پشتیبانی می‌کند:

   - **c-Interact**: تعامل مکالمه‌ای که حالت غیرفعال است و جریان کاری آن ثابت می‌باشد. کد و اطلاعات بیشتر در `bird_interact_conv` موجود است.
   - **a-Interact**: تعامل عاملی که حالت فعال تجسم‌یافته است و جریان کاری آن پویا و توسط مدل‌ها هدایت می‌شود. کد و اطلاعات بیشتر در `bird_interact_agent` قرار دارد.


### 🐣 نسخه سبک

ما نسخه سبک BIRD-INTERACT با نام `bird-interact-lite-exp` را منتشر کرده‌ایم که شامل ۲۷۰ وظیفه باکیفیت دنیای واقعی مخصوص PostgreSQL است. این نسخه نقطه شروع خوبی برای آزمایش سریع است.

### 🦜 نسخه کامل

نسخه کامل BIRD-INTERACT با نام `bird-interact-full`، یک معیار جامع است که شامل ۶۰۰ وظیفه برای PostgreSQL می‌باشد. این نسخه دامنه وسیعی از عملیات SQL و پرسش‌های کاربر را پوشش می‌دهد. نسخه کامل به زودی منتشر می‌شود.

### نتایج عملکرد مدل‌ها در BIRD-INTERACT Lite

#### 1. عملکرد **c-Interact**
| رتبه | نام مدل            | پاداش نرمال‌شده | سطح              |
|:------:|--------------------|:-------:|:--------------:|
| ۱    | o3-mini            | 33.04 | 🏆 چت عالی       |
| ۲    | GPT-4o             | 30.33 | 💎 چت خوب        |
| ۳    | Gemini-2.0-flash   | 27.41 | 💎 چت خوب        |
| ۴    | Claude-3.7-sonnet  | 26.60 | ✨ استاندارد     |
| ۵    | DeepSeek-R1        | 21.74 | ✨ استاندارد     |
| ۶    | Qwen3              | 20.33 | ⚪ پایه‌ای        |
| ۷    | DeepSeek-V3        | 15.85 | ⚪ پایه‌ای        |

#### 2. عملکرد **a-Interact**
| رتبه | نام مدل            | پارامترهای بودجه* | میانگین نوبت/وظیفه | میانگین هزینه (دلار)/وظیفه | پاداش نرمال‌شده | سطح                     |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| ۱    | Claude-3.7-sonnet  | ۶/۶ | ۱۵.۴ | $۰.۶۶۶۸ | ۲۹.۱۹ | 🏆 تعامل عالی            |
| ۲    | o3-mini            | ۶/۶ | ۷.۸  | $۰.۰۷۵۴ | ۲۱.۰۷ | 💎 تعامل خوب             |
| ۳    | DeepSeek-V3        | ۶/۶ | ۱۵.۶ | $۰.۰۶۲۹ | ۱۹.۱۹ | 💎 تعامل خوب             |
| ۴    | Qwen3              | ۶/۶ | ۱۲.۵ | $۰.۰۲۷۸ | ۱۸.۷۴ | ✨ استاندارد              |
| ۵    | GPT-4o             | ۶/۶ | ۱۵.۳ | $۰.۴۵۹۴ | ۱۸.۳۷ | ✨ استاندارد              |
| ۶    | Gemini-2.0-flash   | ۶/۶ | ۱۳.۲ | $۰.۰۳۳۷ | ۱۷.۲۶ | ⚪ پایه‌ای                |
| ۷    | DeepSeek-R1        | ۶/۶ | ۱۲.۰ | $۰.۰۹۳۱ | ۱۷.۰۷ | ⚪ پایه‌ای                |

> \* پارامترهای بودجه: بودجه شروع/بودجه صبر کاربر، که با ارز مجازی ما *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> اندازه‌گیری می‌شود. برای اطلاعات بیشتر به [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) مراجعه کنید.

### مقیاس‌پذیری زمان تعامل (ITS)

مقیاس‌پذیری زمان تعامل (ITS) به توانایی یک مدل برای افزایش مستمر عملکرد نهایی خود از طریق تعاملات چندنوبتی اشاره دارد. زمانی که این عملکرد تعاملی از عملکرد ایده‌آل مدل در یک نوبت و وظیفه کاملاً مشخص و بدون ابهام فراتر رود، گفته می‌شود که مدل **قانون ITS** را ارضا می‌کند. با افزایش صبر کاربر و انباشت نوبت‌های تعامل، عملکرد بهبود می‌یابد و نشان می‌دهد که مدل می‌تواند ارتباط مؤثر را در گفت‌وگوهای طولانی حفظ کند. در حال حاضر فقط مدل claude-3-7-sonnet این قانون را ارضا می‌کند.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 جزئیات دیتاست

### توضیحات دیتاست

- **پایگاه داده:** پایگاه داده کامل PostgreSQL را می‌توانید از [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) دانلود کنید. برای جزئیات بیشتر به بخش [ارزیابی سریع](#quick-eval) مراجعه نمایید.
- **داده:** هر نمونه داده شامل بخش‌های اصلی زیر است:
   - `selected_database`: نام پایگاه داده.  
   - `query`: پرسش کاربر بدون ابهام.  
   - `amb_user_query`: پرسش کاربر با ابهام‌های تزریق‌شده.
   - `user_query_ambiguity`: ابهام‌های تزریق‌شده در پرسش کاربر.
   - `non_critical_ambiguity`: ابهام‌های غیرحیاتی مانند ترتیب، محدودیت و غیره.
   - `knowledge_ambiguity`: ابهاماتی که توسط دانش‌های خارجی ماسک‌شده ایجاد می‌شوند.
   - `sol_sql`: راه‌حل SQL مرجع (ground truth).
   - `preprocess_sql`: کوئری‌های SQL که قبل از اجرای راه‌حل یا پیش‌بینی اجرا می‌شوند.
   - `clean_up_sql`: کوئری‌های SQL که پس از انجام تست‌ها اجرا می‌شوند تا هر تغییری که در پایگاه داده ایجاد شده بازگردانده شود.
   - `test_cases`: مجموعه‌ای از تست‌ها برای اعتبارسنجی SQL اصلاح‌شده پیش‌بینی‌شده.
   - `follow_up`: سوالات پیگیری برچسب‌گذاری‌شده.
   - `external_knowledge`: دانش خارجی مربوط به وظیفه مشخص.

- **ارزیابی:** کد ارزیابی در شاخه [`./evaluation`](./evaluation) موجود است.
- **تهیه‌کنندگان:** تیم BIRD و Google Cloud
- **مجوز:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **کارت دیتاست HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### موارد استفاده دیتاست

برای جلوگیری از نشت داده از طریق خزیدن خودکار، ما راه‌حل‌های sql مرجع و تست‌کیس‌ها را به همراه داده‌ها ارائه نمی‌کنیم.
لطفاً برای دریافت مجموعه کامل، با برچسب `[bird-interact-lite GT&Test Cases]` در عنوان به [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) ایمیل بزنید؛ مجموعه به صورت خودکار ارسال خواهد شد.


<!-- ### استفاده از دیتاست از HuggingFace

می‌توانید دیتاست را با دستور زیر از HuggingFace دانلود کنید:
```bash
from datasets import load_dataset
# بارگذاری نسخه فشرده دیتاست
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# بارگذاری نسخه کامل دیتاست (به زودی)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

یا می‌توانید با استفاده از اسکریپت ارائه‌شده نسخه کامل دیتاست را دانلود کرده و به لهجه‌های مختلف تقسیم کنید.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # مسیر فایل JSONL ورودی (ممکن است خالی باشد اگر بخواهید دیتاست را از HuggingFace دانلود کنید)
  --output_folder path/to/output_dir # پوشه خروجی فایل‌های تقسیم‌شده
``` -->

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
جزئیات اجرای **a-interact** در `./bird_interact_agent/README.md` و اجرای **c-interact** در `./bird_interact_conv/README.md` آمده است.


## 📋 لیست کارها

- [x] انتشار نسخه فشرده، bird-interact-lite (۲۷۰).
- [x] انتشار نسخه مکالمه‌ای، bird-interact-conv.
- [x] انتشار نسخه عامل، bird-interact-agent.
- [ ] انتشار نسخه کامل bird-interact-full (۶۰۰).
- [ ] SFT / RL و شبیه‌ساز کاربر

## تهیه‌کنندگان:
تیم BIRD و Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---