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
لطفاً توجه داشته باشید که پیش از شروع فرآیند ارزیابی، هنگام بارگذاری پایگاه‌داده‌ها توسط داکر، ممکن است گاهی به دلیل ناسازگاری محیط خطاهایی رخ دهد (این خطاها فرآیند را متوقف نمی‌کنند اما در لاگ‌های داکر نمایش داده می‌شوند). در نتیجه، برخی پایگاه‌داده‌ها ممکن است به درستی بارگذاری نشوند و پایگاه‌داده‌های خالی ایجاد شوند. این موضوع باعث خواهد شد نتایج ارزیابی به طور غیرعادی پایین باشد.  
👉 بنابراین، اکیداً توصیه می‌کنیم **پیش از اجرای ارزیابی** لاگ‌های داکر را برای وجود خطا بررسی کرده و اطمینان حاصل کنید که همه پایگاه‌داده‌ها به درستی بارگذاری شده‌اند.

👉 ما **راهنمای ارسال** را به‌روزرسانی کرده‌ایم، که اکنون چارچوب‌های عامل سفارشی را پشتیبانی می‌کند. لطفاً راهنمای مفصل ارسال ما را [اینجا](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true) مطالعه فرمایید.

## 📰 اخبار

- [۲۰۲۵-۱۱-۰۶] 🐛 **رفع باگ** و 🐳 **به‌روزرسانی داکر**: نسخه sqlglot به 26.16.4 ارتقا یافت تا باگی که باعث می‌شد تجزیه‌گر SQL نتواند SQL را برای شبیه‌ساز کاربر به‌درستی تجزیه کند، رفع شود. شما می‌توانید با اجرای دستور `pip install sqlglot==26.16.4` در محیط `bird_interact_eval` این مشکل را رفع کنید. همچنین ایمیج `bird_interact_eval` نیز به‌روزرسانی شده و می‌توانید آن را مجدداً دریافت و کانتینر را بازسازی کنید.

- [۲۰۲۵-۱۰-۲۱] 🐳 **به‌روزرسانی داکر**: داکر محیط پایگاه‌داده کامل اضافه شد. همچنین سه ایمیج داکر (محیط پایه/کامل و محیط ارزیابی برای هر دو `a-Interact` و `c-Interact`) در Docker Hub قرار داده شده‌اند تا راه‌اندازی محیط راحت‌تر باشد. دیگر نیازی به دانلود دستی دامپ‌های پایگاه‌داده و ساخت ایمیج نیست!

- [۲۰۲۵-۱۰-۰۸] 📝 **[مقاله Bird-Interact](https://huggingface.co/papers/2510.05318)** ما اکنون به صورت عمومی در دسترس است!  
  در این مقاله جزئیات کامل، روش‌شناسی و ارزیابی معیار تعاملی متن به SQL شرح داده شده است.  
  👉 برای آشنایی بیشتر با ایده‌های پشت [BIRD-Interact](https://bird-interact.github.io/) آن را مطالعه فرمایید.

- [۲۰۲۵-۰۸-۲۶] 🚀 با خوشحالی اعلام می‌کنیم که مجموعه **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** منتشر شد!  
این مجموعه چالش‌برانگیز است — بهترین مدل‌های LLM تنها به **۱۶.۳۳٪** موفقیت دست یافته‌اند، با فقط **۱۰.۰٪** در بخش‌های `c-interact` و `a-interact`.  
👉 برای اطلاعات بیشتر به [وب‌سایت پروژه](https://bird-interact.github.io/) مراجعه کنید.

- [۲۰۲۵-۰۸-۲۶] 📬 این هفته **Ground Truth & Test cases** را به لیست ایمیل ارسال خواهیم کرد.  
اگر مایل به دسترسی زودهنگام هستید، طبق دستورالعمل سایت ایمیل ارسال کنید تا **دانلود خودکار** دریافت نمایید.  

- [2025-08-26] 💾 همچنین نسخه SQLite از **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** را برای تحقیقات محلی ساده‌تر منتشر کرده‌ایم.  
نسخه کامل **LiveSQLBench-Base** و **-Large** به زودی ارائه خواهند شد!

- [2025-08-22] **رفع باگ**: در کد Bird-Interact-Agent، یک اشکال را رفع کردیم که هنگام ارزیابی SQL فاز-2، اجرای موفقیت‌آمیز SQL ذخیره شده فاز-1 ممکن نبود و این موضوع باعث کاهش نرخ موفقیت فاز-2 می‌شد. این باگ فقط بر روی وظایفی تأثیر می‌گذارد که SQL فاز1 عملیاتی مانند CREATE table و غیره را روی پایگاه داده انجام می‌دهد.

## 🧸 مرور کلی

BIRD-INTERACT، یک بنچمارک تعاملی متن به SQL است که **ارزیابی Text-to-SQL را از منظر تعاملات پویا بازآفرینی می‌کند**.
این محیط با ترکیب یک پایگاه دانش سلسله‌مراتبی، مستندات پایگاه داده و شبیه‌ساز کاربر مبتنی بر عملکرد، محیط‌های واقعی سازمانی را در عملیات کامل **CRUD** بازسازی می‌کند.
دو حالت تست سختگیرانه ارائه می‌دهد: (1) **تعامل مکالمه‌ای** غیرفعال و (2) **تعامل عاملانه** فعال، شامل 600 وظیفه حاشیه‌نویسی شده مانند هوش تجاری (BI)، عملیات CRUD و غیره، که هر کدام با موارد تست اجرایی محافظت می‌شوند.
ارزیابی‌های معمول بین 1,968 تا 5,496 نوبت تعامل بین مدل و شبیه‌ساز کاربر را ایجاد می‌کنند، در حالی که مدل‌های استنتاج پیشرفته فعلاً فقط **≈24%** و **≈18%** وظایف را حل می‌کنند که چالش‌برانگیز بودن این بنچمارک را نشان می‌دهد.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ دو حالت ارزیابی

BIRD-INTERACT از دو حالت ارزیابی که در بالا ذکر شد پشتیبانی می‌کند:

   - **c-Interact**: تعامل مکالمه‌ای که حالت غیرفعال است و جریان کاری آن ثابت می‌باشد. کد و اطلاعات جزئی‌تر در `bird_interact_conv` موجود است.
   - **a-Interact**: تعامل عاملانه که حالت فعال و مجسم است و جریان کاری آن پویا بوده و توسط مدل‌ها هدایت می‌شود. کد و اطلاعات جزئی‌تر در `bird_interact_agent` موجود است.


### 🐣 نسخه سبک

نسخه سبک BIRD-INTERACT، با نام `bird-interact-lite-exp` را منتشر می‌کنیم که شامل ۲۷۰ وظیفه واقعی و باکیفیت برای PostgreSQL است. این نسخه نقطه شروع مناسبی برای آزمایش سریع می‌باشد.

### 🦜 نسخه کامل

نسخه کامل BIRD-INTERACT، با نام `bird-interact-full`، یک بنچمارک جامع شامل ۶۰۰ وظیفه برای PostgreSQL است. این نسخه دامنه گسترده‌ای از عملیات SQL و پرسش‌های کاربری را پوشش می‌دهد. نسخه کامل به زودی ارائه خواهد شد.

### نتایج عملکرد مدل‌ها بر روی BIRD-INTERACT-FULL

#### 1. **عملکرد c-Interact Text-to-SQL**
| رتبه | نام مدل            | پاداش نرمال شده   | هزینه متوسط (دلار)/وظیفه | سطح                |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 چت عالی         |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 گفتگوی عالی       |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 گفتگوی خوب         |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 گفتگوی خوب         |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ استاندارد          |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ استاندارد          |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ پایه‌ای            |

#### 2. **عملکرد a-Interact Text-to-SQL**
| رتبه | نام مدل            | پاداش نرمال‌شده    | هزینه متوسط (دلار)/وظیفه | سطح                       |
|:----:|:-------------------|:-------------------:|:-------------------------:|:-------------------------:|
| 1    | GPT-5              | 25.52               | $0.24                     | 🏆 تعامل عالی             |
| 2    | Claude-Sonnet-4    | 23.28               | $0.51                     | 🏆 تعامل عالی             |
| 3    | Claude-Sonnet-3.7  | 17.45               | $0.60                     | 💎 تعامل خوب              |
| 4    | Gemini-2.5-Pro     | 17.33               | $0.22                     | 💎 تعامل خوب              |
| 5    | O3-Mini            | 16.43               | $0.06                     | ✨ استاندارد              |
| 6    | Deepseek-Chat-V3.1 | 13.47               | $0.06                     | ✨ استاندارد              |
| 7    | Qwen-3-Coder-480B  | 10.58               | $0.07                     | ⚪ پایه‌ای                |

> \* پارامترهای بودجه: بودجه شروع/بودجه تحمل کاربر، که با ارز مجازی ما *bird-coin* سنجیده می‌شود <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. برای جزئیات بیشتر به [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) مراجعه کنید.

### مقیاس‌بندی زمان تعامل (ITS)

مقیاس‌بندی زمان تعامل (ITS) به توانایی مدل در بهبود مستمر عملکرد نهایی خود از طریق تعاملات چندمرحله‌ای اشاره دارد. زمانی که این عملکرد تعاملی از عملکرد ایده‌آل تک‌مرحله‌ای مدل در یک وظیفه کاملاً مشخص و بدون ابهام فراتر رود، می‌گوییم که مدل **قانون ITS** را ارضا می‌کند. با افزایش تحمل کاربر و جمع‌آوری دفعات تعامل، عملکرد مدل همچنان بهبود می‌یابد و نشان می‌دهد که مدل می‌تواند ارتباط مؤثری را در مکالمات طولانی مدت حفظ کند. در حال حاضر، فقط مدل claude-3-7-sonnet این قانون را ارضا می‌کند.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## راه‌اندازی محیط

1. کانتینرهای داکر برای دیتابیس bird-interact-lite، دیتابیس bird-interact-full و محیط ارزیابی را اجرا کنید:
  
  > اگر فقط می‌خواهید روی `bird-interact-lite` ارزیابی انجام دهید، می‌توانید سرویس [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) را در فایل `docker-compose.yml` کامنت کنید تا راه‌اندازی محیط سریع‌تر انجام شود.
  
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
جزئیات مربوط به اجرای **a-interact** در فایل `./bird_interact_agent/README.md` موجود است؛ و اطلاعات مربوط به **c-interact** در فایل `./bird_interact_conv/README.md` قابل دسترسی است.

## 📋 فهرست کارها

- [x] انتشار نسخه سبک، bird-interact-lite (۲۷۰).
- [x] انتشار نسخه گفتگو محور، bird-interact-conv.
- [x] انتشار نسخه عامل، bird-interact-agent.
- [x] انتشار نسخه کامل bird-interact-full (۶۰۰).
- [ ] SFT / RL یک شبیه‌ساز کاربر

## قدردانی
مایلیم مراتب سپاسگزاری صمیمانه خود را از **ایرینا ساپارینا**، **محمدرضا پوررضا**، **مهدی بوزوئینا**، **هایلونگ لی**، **جیاتونگ شی** و پروفسور **شینجی واتانابه** به خاطر بحث‌های پربار و دیدگاه‌های ارزشمندشان که موجب بهبود این پروژه شد، اعلام کنیم.

## ایجاد شده توسط:
تیم BIRD و Google Cloud








## تغییرات نسخه

- [۲۰۲۵-۱۱-۰۶] 🐛 **رفع اشکال** و 🐳 **به‌روزرسانی داکر**: به‌روزرسانی نسخه sqlglot به ۲۶.۱۶.۴ جهت رفع اشکالی که باعث می‌شد تجزیه‌گر SQL نتواند SQL را برای شبیه‌ساز کاربر به‌درستی تجزیه کند. می‌توانید این مشکل را با نصب مجدد توسط دستور `pip install sqlglot==26.16.4` در محیط `bird_interact_eval` رفع کنید. تصویر `bird_interact_eval` نیز به‌روزرسانی شده و می‌توانید آن را دریافت و کانتینر `bird_interact_eval` را مجدداً ایجاد نمایید.
- [۲۰۲۵-۱۰-۲۱] 🐳 **به‌روزرسانی داکر**: افزودن داکر برای محیط کامل پایگاه داده. همچنین سه تصویر داکر (پایه/محیط کامل پایگاه داده و محیط ارزیابی برای هر دو `a-Interact` و `c-Interact`) را در Docker Hub بارگذاری کردیم تا راه‌اندازی محیط آسان‌تر شود. دیگر نیازی به دانلود DB dumps و ساخت تصاویر به‌صورت دستی نیست! لطفاً تصاویر جدید را از Docker Hub دریافت و کانتینرها را مجدداً ایجاد کنید، به عنوان مثال با استفاده از دستور `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [۲۰۲۵-۰۸-۲۲]  🐛 **رفع اشکال**: رفع اشکالی که هنگام ارزیابی SQL فاز-۲ رخ می‌داد و باعث می‌شد SQL ذخیره شده فاز-۱ به‌درستی اجرا نشود و نرخ موفقیت فاز-۲ را کاهش دهد. این اشکال فقط بر وظایفی تأثیر می‌گذارد که در آن SQL فاز۱ عملیاتی مانند ایجاد جدول و غیره روی پایگاه داده انجام می‌دهد.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---