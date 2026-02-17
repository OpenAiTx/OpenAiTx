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

## ⚠️ اطلاعیه  
لطفاً توجه داشته باشید که قبل از شروع فرایند ارزیابی، هنگام بارگذاری پایگاه داده‌ها توسط Docker، ممکن است به علت ناسازگاری محیطی گاهی اوقات خطاهایی رخ دهد (این خطاها باعث توقف فرایند نمی‌شوند اما در لاگ‌های Docker نمایش داده می‌شوند). در نتیجه ممکن است برخی پایگاه داده‌ها به درستی بارگذاری نشوند و پایگاه داده‌های خالی ایجاد شود. این موضوع باعث می‌شود نتایج ارزیابی به طور غیرعادی پایین باشد.  
👉 بنابراین، اکیداً توصیه می‌کنیم **قبل از اجرای ارزیابی** لاگ‌های Docker را از نظر وجود خطا بررسی کرده و مطمئن شوید که همه پایگاه داده‌ها با موفقیت بارگذاری شده‌اند.

👉 ما **دستورالعمل‌های ارسال** را به‌روزرسانی کرده‌ایم که اکنون اسکافلدهای عامل سفارشی را پشتیبانی می‌کند. لطفاً جهت مشاهده دستورالعمل‌های کامل ارسال [اینجا](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true) را بررسی نمایید.

## 📰 اخبار

- [2026-02-08] 🔥🔥🔥 مقاله **[Bird-Interact](https://huggingface.co/papers/2510.05318)** ما در **ICLR 2026 (Oral)** پذیرفته شد! در ریودوژانیرو 🇧🇷 می‌بینیمتان!  

- [2025-11-06] 🐛 **رفع اشکال** و 🐳 **به‌روزرسانی Docker**: نسخه sqlglot به 26.16.4 به‌روزرسانی شد تا اشکال مربوط به عدم تحلیل صحیح SQL توسط مفسر SQL برای شبیه‌ساز کاربر رفع شود. می‌توانید با اجرای `pip install sqlglot==26.16.4` در محیط `bird_interact_eval` این مشکل را حل کنید. همچنین تصویر `bird_interact_eval` به‌روزرسانی شده و می‌توانید آن را دریافت و کانتینر `bird_interact_eval` را مجدداً ایجاد نمایید.

- [2025-10-21] 🐳 **به‌روزرسانی Docker**: داکر برای محیط Full DB اضافه شد. سه تصویر داکر (محیط پایه/محیط Full DB و محیط ارزیابی برای هر دو `a-Interact` و `c-Interact`) را در Docker Hub قرار دادیم تا راه‌اندازی محیط آسان‌تر شود. دیگر نیازی به دانلود دستی DB dumps و ساخت تصاویر نیست!

- [2025-10-08] 📝 مقاله **[Bird-Interact](https://huggingface.co/papers/2510.05318)** اکنون به طور عمومی در دسترس است!  
  این مقاله جزئیات کامل، روش‌شناسی و ارزیابی معیار تعاملی متن به SQL ما را ارائه می‌دهد.  
  👉 برای اطلاعات بیشتر درباره ایده‌های پشت [BIRD-Interact](https://bird-interact.github.io/) مراجعه کنید.

- [2025-08-26] 🚀 با افتخار اعلام می‌کنیم که مجموعه **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** منتشر شد!  
این مجموعه چالش‌برانگیز است — بهترین مدل‌های زبان بزرگ تنها به **16.33%** موفقیت دست یافته‌اند و فقط **10.0%** در بخش‌های `c-interact` و `a-interact`.  
👉 برای جزئیات بیشتر به [وبسایت پروژه](https://bird-interact.github.io/) مراجعه فرمایید.

- [2025-08-26] 📬 ما این هفته **موارد حقیقت زمین و تست** را به لیست ایمیل خود ارسال خواهیم کرد.  
اگر دسترسی زودهنگام می‌خواهید، لطفاً طبق دستور سایت ایمیل بزنید تا **دانلود خودکار** دریافت کنید.  

- [2025-08-26] 💾 در خبر دیگر، نسخه SQLite از **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** را برای پژوهش محلی آسان‌تر منتشر کردیم.  
نسخه کامل **LiveSQLBench-Base** و **-Large** به زودی ارائه خواهد شد!

- [2025-08-22] **رفع باگ**: در کد Bird-Interact-Agent، یک باگ را رفع کردیم که هنگام ارزیابی SQL مرحله دوم، SQL ذخیره شده مرحله اول اجرا نمی‌شد و باعث کاهش نرخ موفقیت مرحله دوم می‌شد. این باگ فقط روی وظایفی تاثیر داشت که SQL مرحله اول عملیاتی روی دیتابیس انجام می‌دهد، مانند CREATE table و غیره.

## 🧸 نمای کلی

BIRD-INTERACT، یک بنچمارک تعاملی تبدیل متن به SQL، **ارزیابی Text-to-SQL را از منظر تعاملات پویا بازآفرینی می‌کند**.
محیط، پایگاه دانش سلسله‌مراتبی، مستندات پایگاه داده و شبیه‌ساز کاربر مبتنی بر عملکرد را ترکیب می‌کند تا محیط‌های واقعی سازمانی را در عملیات کامل **CRUD** بازسازی کند.
دو حالت ارزیابی دقیق ارائه می‌دهد: (1) **تعامل مکالمه‌ای** غیر فعال و (2) **تعامل عاملانه** فعال، که دربرگیرنده ۶۰۰ وظیفه برچسب‌خورده شامل هوش تجاری (BI)، عملیات CRUD و غیره است، و هر یک توسط تست کیس‌های قابل اجرا محافظت می‌شوند.
ارزیابی‌های معمولی ۱,۹۶۸ تا ۵,۴۹۶ دور تعامل بین مدل و شبیه‌ساز کاربر را تحریک می‌کنند، در حالی که مدل‌های استدلال پیشرفته فقط **≈۲۴٪** و **≈۱۸٪** وظایف را حل می‌کنند که چالش بنچمارک را نشان می‌دهد.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ دو حالت ارزیابی

BIRD-INTERACT دو حالت ارزیابی را همانطور که گفته شد پشتیبانی می‌کند:

   - **c-Interact**: تعامل مکالمه‌ای که حالت غیر فعال است و جریان کار ثابت دارد. کد و اطلاعات جزئی در `bird_interact_conv` موجود است.
   - **a-Interact**: تعامل عاملانه که حالت فعال است و جریان کار توسط مدل‌ها هدایت می‌شود. کد و اطلاعات جزئی در `bird_interact_agent` موجود است.


### 🐣 نسخه سبک

نسخه سبک BIRD-INTERACT، `bird-interact-lite-exp` را منتشر می‌کنیم که شامل ۲۷۰ وظیفه واقعی با کیفیت بالا مخصوص PostgreSQL است. این نقطه شروع خوبی برای آزمایش سریع است. 

### 🦜 نسخه کامل

نسخه کامل BIRD-INTERACT، `bird-interact-full`، یک بنچمارک جامع با ۶۰۰ وظیفه برای PostgreSQL است. طیف وسیعی از عملیات SQL و پرسش‌های کاربر را پوشش می‌دهد. نسخه کامل به زودی ارائه می‌شود.

### نتایج عملکرد مدل‌ها روی BIRD-INTERACT-FULL

#### ۱. عملکرد **c-Interact Text-to-SQL**
| رتبه | نام مدل         | پاداش نرمال‌شده | هزینه متوسط (دلار)/وظیفه | سطح              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 چت عالی           |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 چت عالی           |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 چت خوب            |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 چت خوب            |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ استاندارد         |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ استاندارد         |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ پایه‌ای            |

#### 2. **عملکرد a-Interact Text-to-SQL**
| رتبه | نام مدل            | پاداش نرمال‌شده    | متوسط هزینه (دلار)/وظیفه | سطح                        |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 تعامل عالی            |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 تعامل عالی            |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 تعامل خوب             |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 تعامل خوب             |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ استاندارد             |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ استاندارد             |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ پایه‌ای               |

> \* پارامترهای بودجه: بودجه اولیه/بودجه صبر کاربر، بر حسب ارز مجازی *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. برای جزئیات بیشتر به [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) مراجعه کنید.

### مقیاس‌گذاری زمان تعامل (ITS)

مقیاس‌گذاری زمان تعامل (ITS) به توانایی یک مدل برای افزایش مستمر عملکرد نهایی خود از طریق تعاملات چندمرحله‌ای اشاره دارد. زمانی که این عملکرد تعاملی از عملکرد تک‌مرحله‌ای ایده‌آل مدل در یک وظیفه کاملاً مشخص و بدون ابهام فراتر رود، گفته می‌شود مدل از **قانون ITS** پیروی می‌کند. با افزایش صبر کاربر و تجمع تعداد تعاملات، عملکرد مدل بهبود می‌یابد، که نشان می‌دهد مدل می‌تواند ارتباط مؤثر را در گفتگوی طولانی حفظ کند. در حال حاضر، تنها claude-3-7-sonnet مطابق با قانون ITS است.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## راه‌اندازی محیط

1. کانتینرهای داکر مربوط به پایگاه داده bird-interact-lite، پایگاه داده bird-interact-full و محیط ارزیابی را اجرا کنید:
  
  > اگر فقط می‌خواهید روی `bird-interact-lite` ارزیابی انجام دهید، می‌توانید سرویس [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) را در `docker-compose.yml` کامنت کنید تا راه‌اندازی محیط سریع‌تر شود.
  
  محیط را با اجرای دستور زیر راه‌اندازی کنید: 
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   چند دقیقه منتظر بمانید تا پایگاه داده مقداردهی اولیه شود.
   
  شما می‌توانید پیشرفت ساخت را با موارد زیر پیگیری کنید:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  اگر کار تمام شده باشد، باید لاگ‌ها را بدون خطا مشاهده کنید مانند:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
اگر قبلاً کانتینر ساخته‌اید و می‌خواهید آن را دوباره بسازید، می‌توانید فرمان زیر را اجرا کنید:

  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   این دستور ۳ کانتینر را با استفاده از ایمیج‌های آماده از Docker Hub اجرا می‌کند:
   - `bird_interact_postgresql`: پایگاه داده PostgreSQL برای bird-interact-lite
   - `bird_interact_postgresql_full`: پایگاه داده PostgreSQL برای bird-interact-full
   - `bird_interact_eval`: محیط ارزیابی برای هر دو `a-Interact` و `c-Interact`.

   اکنون می‌توانید محیط ارزیابی را با اجرای دستور زیر راه‌اندازی کنید:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (اختیاری) محیط را به صورت دستی بسازید (اگر می‌خواهید تصاویر را از ابتدا بسازید): 
   - فایل‌های دامپ پایگاه داده را دانلود کنید 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). آن را از حالت فشرده خارج کرده و به نام `env/postgre_table_dumps` تغییر دهید.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). آن را از حالت فشرده خارج کرده و به نام `env/postgre_table_dumps_full` تغییر دهید.
   - محیط را با اجرای `docker-compose.build.yml` به صورت دستی بسازید.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

۳. (توصیه می‌شود) بررسی کنید که کانتینرهای پایگاه داده با موفقیت ساخته و اجرا شده‌اند.

- لاگ‌های ساخت کانتینر را چاپ کنید تا مطمئن شوید پایگاه‌های داده بدون خطا ساخته شده‌اند:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   اگر خطاهایی رخ دهند، `"خطاها در هنگام وارد کردن رخ دادند:"` در فایل‌های گزارش چاپ خواهد شد.


-  بررسی کنید که کانتینرهای پایگاه داده در وضعیت مناسبی باشند.
   
   از اسکریپت پایتون ارائه شده توسط ما برای بررسی متادیتای پایگاه داده استفاده کنید:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   نتایج مورد انتظار:
   - **bird-interact-lite**: 
     - 📈 تعداد پایگاه‌های داده: ۱۸
     - 📋 تعداد جدول‌ها: ۱۷۵
     - 🔢 تعداد ستون‌ها: ۲۲۸۶
     - 📈 میانگین تعداد ردیف‌ها در هر جدول: ۱۰۳۸.۴۸
     - 💾 کل حجم: ۲۰۷.۱۵ مگابایت (تقریباً)
   - **bird-interact-full**: 
     - 📈 تعداد پایگاه‌های داده: ۲۲
     - 📋 تعداد جدول‌ها: ۲۴۴
     - 🔢 تعداد ستون‌ها: ۲۰۱۱
     - 📈 میانگین تعداد ردیف‌ها در هر جدول: ۱۱۲۱.۱۹
     - 💾 کل حجم: ۲۷۲.۰۰ مگابایت (تقریباً)


## 📦 جزئیات دیتاست

### توضیحات دیتاست

- **پایگاه داده:** پایگاه داده کامل PostgreSQL را می‌توان از [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) و [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) دانلود کرد.
- **data:** هر نمونه داده شامل بخش‌های اصلی زیر است:
   - `selected_database`: نام پایگاه داده.  
   - `query`: پرسش کاربر بدون ابهام.  
   - `amb_user_query`: پرسش کاربر با ابهامات تزریق شده.
   - `user_query_ambiguity`: ابهاماتی که به پرسش کاربر تزریق شده‌اند.
   - `non_critical_ambiguity`: ابهامات غیر بحرانی مانند ترتیب، محدودیت و غیره.
   - `knowledge_ambiguity`: ابهاماتی که توسط مخفی‌سازی دانش‌های خارجی ایجاد شده‌اند. 
   - `sol_sql`: راه حل SQL واقعی.  
   - `preprocess_sql`: کوئری‌های SQL برای اجرا قبل از راه حل یا پیش‌بینی.  
   - `clean_up_sql`: کوئری‌های SQL برای اجرا پس از تست‌ها جهت بازگرداندن تغییرات پایگاه داده.  
   - `test_cases`: مجموعه‌ای از تست‌ها برای اعتبارسنجی SQL اصلاح شده پیش‌بینی شده.
   - `follow_up`: پرسش‌های پیگیری برچسب‌گذاری شده.
   - `external_knowledge`: دانش خارجی مرتبط با وظیفه خاص.

- **ارزیابی:** کد ارزیابی در پوشه [`./evaluation`](./evaluation) موجود است.
- **تهیه شده توسط:** تیم BIRD و Google Cloud
- **مجوز:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **کارت دیتاست HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  و [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### موارد استفاده از دیتاست

برای جلوگیری از نشت داده‌ها از طریق خزیدن خودکار، راه‌حل‌های GT و موارد تست را همراه با داده‌ها قرار نمی‌دهیم.
لطفاً برای دریافت داده‌های حقیقت پایه و موارد تست مربوط به دیتاست bird-interact-lite یا bird-interact-full، ایمیلی با عنوان `[bird-interact-lite GT&Test Cases]` یا `[bird-interact-full GT&Test Cases]` به آدرس [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) ارسال نمایید تا اطلاعات به صورت خودکار برای شما ارسال گردد.

### ترکیب داده‌های عمومی با حقیقت پایه و موارد تست

سپس از اسکریپت زیر برای ترکیب داده‌های عمومی با حقیقت پایه و موارد تست استفاده کنید:

نسخه کامل را به عنوان مثال در نظر بگیرید:
(1) اجرا کنید:

```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
این کار یک فایل جدید در مسیر `/path/to/bird_interact_data.jsonl` با داده‌های ترکیبی ایجاد خواهد کرد.

(2) سپس داده‌های عمومی اصلی را با داده‌های ترکیبی جایگزین کنید:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

برای نسخه‌های دیگر نیز همین کار را انجام دهید: bird-interact-lite، نسخه مینی و غیره. فقط مسیرهای صحیح را برای داده‌های عمومی، داده‌های حقیقت مبنا و داده‌های تست تنظیم کنید و سپس داده‌های عمومی را با داده‌های ترکیبی جایگزین نمایید.




<!-- ### استفاده از دیتاست از HuggingFace

می‌توانید دیتاست را با استفاده از دستور زیر از HuggingFace دانلود کنید:
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
جزئیات مربوط به اجرای **a-interact** را می‌توانید در `./bird_interact_agent/README.md` پیدا کنید؛ و جزئیات **c-interact** را در `./bird_interact_conv/README.md` بیابید.

## 📋 لیست کارها

- [x] انتشار نسخه سبک، bird-interact-lite (270).
- [x] انتشار نسخه مکالمه‌ای، bird-interact-conv.
- [x] انتشار نسخه عامل، bird-interact-agent.
- [x] انتشار نسخه کامل bird-interact-full (600).
- [ ] SFT / RL یک شبیه‌ساز کاربر

## تقدیر و تشکر
مایلیم از **Irina Saparina**، **Mohammadreza Pourreza**، **Mehdi Bouzouina**، **Hailong Li**، **Jiatong Shi**، و پروفسور **Shinji Watanabe** بابت بحث‌های سازنده و دیدگاه‌های ارزشمندشان که در بهبود این پروژه نقش داشتند، صمیمانه تشکر کنیم.

## ساخته شده توسط:
تیم BIRD و Google Cloud








## تغییرات

- [2025-11-06] 🐛 **رفع اشکال** و 🐳 **بروزرسانی Docker**: نسخه sqlglot به 26.16.4 بروزرسانی شد تا اشکالی که پارسر sql نمی‌تواند SQL را برای شبیه‌ساز کاربر به درستی تجزیه کند، رفع شود. می‌توانید این مشکل را با نصب مجدد توسط `pip install sqlglot==26.16.4` در محیط `bird_interact_eval` رفع کنید. تصویر `bird_interact_eval` نیز بروزرسانی شده، بنابراین می‌توانید آن را کشیده و کانتینر `bird_interact_eval` را دوباره بسازید.
- [2025-10-21] 🐳 **بروزرسانی Docker**: داکر برای محیط Full DB افزوده شد. همچنین سه تصویر داکر (پایه/محیط Full DB و محیط ارزیابی برای هر دو `a-Interact` و `c-Interact`) به Docker Hub ارسال شد تا راه‌اندازی محیط را تسهیل کند. دیگر نیازی به دانلود DB dumps و ساخت تصاویر به صورت دستی نیست! لطفاً تصاویر جدید را از Docker Hub دریافت کرده و کانتینرها را دوباره بسازید، مثلاً با استفاده از `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **رفع اشکال**: رفع اشکالی که هنگام ارزیابی SQL فاز-2، SQL ذخیره‌شده فاز-1 نمی‌تواند با موفقیت اجرا شود و باعث کاهش نرخ موفقیت فاز-2 می‌شد. این اشکال فقط بر وظایفی تأثیر می‌گذارد که SQL فاز-1 عملیات‌هایی مانند CREATE table و غیره بر روی پایگاه داده انجام می‌دهد.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---