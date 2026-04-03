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
لطفاً توجه داشته باشید که قبل از فرآیند ارزیابی، هنگام بارگذاری پایگاه‌های داده توسط Docker، ممکن است گاهی به دلیل ناسازگاری محیط خطاهایی رخ دهد (این خطاها فرآیند را متوقف نمی‌کنند اما در لاگ‌های Docker نمایش داده می‌شوند). در نتیجه، برخی پایگاه‌های داده ممکن است به درستی بارگذاری نشوند و پایگاه‌های داده خالی ایجاد شود. این موضوع باعث خواهد شد نتایج ارزیابی به طور غیرعادی پایین باشد.  
👉 بنابراین، اکیداً توصیه می‌کنیم **پیش از اجرای ارزیابی**، لاگ‌های Docker را از نظر وجود خطا بررسی کرده و اطمینان حاصل کنید که همه پایگاه‌های داده با موفقیت بارگذاری شده‌اند.

👉 ما **راهنمای ارسال** را به‌روزرسانی کرده‌ایم که در آن اسکافولدهای عامل سفارشی نیز پشتیبانی می‌شوند. لطفاً برای مشاهده جزئیات راهنمای ارسال ما [اینجا](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true) را ببینید.

## 📰 اخبار

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: ما **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)** را منتشر کردیم، یک پیاده‌سازی مبتنی بر Google ADK با معماری ماژولار شامل ۳ میکروسرویس (عامل، شبیه‌ساز کاربر و محیط پایگاه داده). می‌توانید به سادگی عامل، شبیه‌ساز کاربر یا محیط پایگاه داده خودتان را جایگزین کنید. از اجرای موازی و هر ارائه‌دهنده LLM سازگار با [LiteLlm](https://docs.litellm.ai/docs/providers) پشتیبانی می‌کند. توصیه می‌کنیم برای تحقیقات خود از این پیاده‌سازی استفاده کنید.

- [2026-02-08] 🔥🔥🔥 مقاله **[Bird-Interact](https://huggingface.co/papers/2510.05318)** ما در **ICLR 2026 (Oral)** پذیرش شد! در ریودوژانیرو 🇧🇷 می‌بینیمتان!  

- [2025-11-06] 🐛 **رفع اشکال** و 🐳 **به‌روزرسانی Docker**: نسخه sqlglot به 26.16.4 به‌روزرسانی شد تا اشکال عدم توانایی تجزیه صحیح SQL توسط شبیه‌ساز کاربر برطرف شود. می‌توانید با اجرای `pip install sqlglot==26.16.4` در محیط `bird_interact_eval` این مشکل را برطرف کنید. تصویر `bird_interact_eval` نیز به‌روزرسانی شده است، بنابراین می‌توانید آن را دریافت و کانتینر `bird_interact_eval` را مجدداً بسازید.

- [2025-10-21] 🐳 **به‌روزرسانی Docker**: ما داکر محیط پایگاه داده کامل (Full DB Env) را اضافه کردیم. همچنین ۳ تصویر داکر (پایه/کامل و محیط ارزیابی برای هر دو `a-Interact` و `c-Interact`) را به Docker Hub ارسال کردیم تا راه‌اندازی محیط را آسان‌تر کنیم. دیگر نیازی به دانلود dump پایگاه داده و ساخت دستی تصویرها نیست!

- [2025-10-08] 📝 مقاله **[Bird-Interact](https://huggingface.co/papers/2510.05318)** اکنون به صورت عمومی در دسترس است!  
  این مقاله جزئیات کامل، روش‌شناسی و ارزیابی معیار تعاملی متن به SQL ما را ارائه می‌دهد.  
  👉 مشاهده کنید و با ایده‌های پشت [BIRD-Interact](https://bird-interact.github.io/) بیشتر آشنا شوید.

- [2025-08-26] 🚀 با هیجان اعلام می‌کنیم که مجموعه **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** منتشر شد!  
این مجموعه چالش‌برانگیز است — بهترین مدل‌های زبانی تنها به نرخ موفقیت **۱۶٫۳۳٪** و فقط **۱۰٫۰٪** در بخش‌های `c-interact` و `a-interact` رسیده‌اند.  
👉 برای جزئیات بیشتر، لطفاً به [وبسایت پروژه](https://bird-interact.github.io/) ما مراجعه کنید.

- [2025-08-26] 📬 ما این هفته **داده‌های Ground Truth و Test cases** را به لیست ایمیل خود ارسال خواهیم کرد.  
اگر دسترسی زودهنگام می‌خواهید، لطفاً طبق دستورالعمل سایت ایمیل ارسال کنید تا **دانلود خودکار** برای شما فعال شود.  

- [2025-08-26] 💾 همچنین نسخه SQLite از **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** را برای تحقیقات محلی آسان‌تر منتشر کرده‌ایم.  
نسخه‌های کامل **LiveSQLBench-Base** و **-Large** به زودی منتشر خواهند شد!

- [2025-08-22] **رفع اشکال**: در کد Bird-Interact-Agent، باگی را رفع کردیم که هنگام ارزیابی SQL فاز-۲، اجرای موفق SQL ذخیره‌شده فاز-۱ ممکن نبود و باعث کاهش نرخ موفقیت فاز-۲ می‌شد. این باگ فقط بر کارهایی تأثیر داشت که در آن‌ها SQL فاز۱ عملیاتی روی پایگاه داده انجام می‌دهد، مانند CREATE table و غیره.

## 🧸 نمای کلی

BIRD-INTERACT، یک بنچمارک تعاملی text-to-SQL است که **ارزیابی Text-to-SQL را از دریچه تعاملات پویا بازآفرینی می‌کند**.
این محیط، یک پایگاه دانش سلسله‌مراتبی، مستندات پایگاه داده و یک شبیه‌ساز کاربر مبتنی بر عملکرد را ترکیب می‌کند تا محیط‌های سازمانی واقعی را برای انجام کامل عملیات **CRUD** بازسازی کند.
دو حالت آزمایشی سخت‌گیرانه ارائه می‌دهد: (1) **تعامل مکالمه‌ای** منفعل و (2) **تعامل عاملی** فعال، که شامل ۶۰۰ تسک حاشیه‌نویسی‌شده از جمله هوش تجاری (BI)، عملیات CRUD و غیره است و هرکدام با موارد تست قابل اجرا محافظت می‌شوند.
ارزیابی‌های معمول بین ۱۹۶۸ تا ۵۴۹۶ دور تعامل بین مدل و شبیه‌ساز کاربر ایجاد می‌کند، در حالی که مدل‌های استدلال پیشرفته فعلی فقط **≈۲۴٪** و **≈۱۸٪** از تسک‌ها را حل می‌کنند که دشواری این بنچمارک را نشان می‌دهد.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ دو حالت ارزیابی

BIRD-INTERACT دو حالت ارزیابی زیر را پشتیبانی می‌کند:

   - **c-Interact**: تعامل مکالمه‌ای که حالت منفعل است و روند کاری ثابتی دارد. کد و اطلاعات جزئی در `bird_interact_conv` موجود است.
   - **a-Interact**: تعامل عاملی که حالت فعال و تجسم‌یافته است، روند کاری پویا است و توسط مدل‌ها هدایت می‌شود. کد و اطلاعات جزئی در `bird_interact_agent` موجود است.


### 🐣 نسخه سبک

ما نسخه سبک BIRD-INTERACT به نام `bird-interact-lite-exp` را منتشر کرده‌ایم که شامل ۲۷۰ تسک واقعی با کیفیت بالا ویژه PostgreSQL است. این نسخه برای آزمایش سریع نقطه شروع مناسبی است. 

### 🦜 نسخه کامل

نسخه کامل BIRD-INTERACT با نام `bird-interact-full` یک بنچمارک جامع است که شامل ۶۰۰ تسک برای PostgreSQL می‌باشد. این نسخه دامنه گسترده‌ای از عملیات SQL و پرسش‌های کاربری را پوشش می‌دهد. نسخه کامل به‌زودی منتشر خواهد شد.

### نتایج عملکرد مدل‌ها بر روی BIRD-INTERACT-FULL

#### 1. **عملکرد c-Interact Text-to-SQL**
| رتبه | نام مدل            | پاداش نرمال‌شده     | هزینه متوسط (دلار)/وظیفه | سطح                 |
|:----:|:-------------------|:--------------------:|:-------------------------:|:-------------------:|
| 1    | Gemini-2.5-Pro     | ۲۰.۹۲                | $۰.۰۴                     | 🏆 چت عالی           |
| 2    | O3-Mini            | ۲۰.۲۷                | $۰.۰۷                     | 🏆 چت عالی           |
| 3    | Claude-Sonnet-4    | ۱۸.۳۵                | $۰.۲۹                     | 💎 چت خوب            |
| 4    | Qwen-3-Coder-480B  | ۱۷.۷۵                | $۰.۱۱                     | 💎 چت خوب            |
| 5    | Deepseek-Chat-V3.1 | ۱۵.۱۵                | $۰.۱۲                     | ✨ استاندارد         |
| 6    | Claude-Sonnet-3.7  | ۱۳.۸۷                | $۰.۲۹                     | ✨ استاندارد         |
| 7    | GPT-5              | ۱۲.۵۸                | $۰.۰۸                     | ⚪ پایه‌ای            |

#### 2. **عملکرد a-Interact Text-to-SQL**
| رتبه | نام مدل            | پاداش نرمال‌شده     | هزینه متوسط (دلار)/وظیفه | سطح                       |
|:----:|:-------------------|:--------------------:|:-------------------------:|:--------------------------:|
| 1    | GPT-5              | ۲۵.۵۲                | $۰.۲۴                     | 🏆 تعامل عالی              |
| 2    | Claude-Sonnet-4    | ۲۳.۲۸                | $۰.۵۱                     | 🏆 تعامل عالی              |
| 3    | Claude-Sonnet-3.7  | ۱۷.۴۵                | $۰.۶۰                     | 💎 تعامل خوب               |
| 4    | Gemini-2.5-Pro     | ۱۷.۳۳                | $۰.۲۲                     | 💎 تعامل خوب               |
| 5    | O3-Mini            | ۱۶.۴۳                | $۰.۰۶                     | ✨ استاندارد               |
| 6    | Deepseek-Chat-V3.1 | ۱۳.۴۷                | $۰.۰۶                     | ✨ استاندارد               |
| 7    | Qwen-3-Coder-480B  | ۱۰.۵۸                | $۰.۰۷                     | ⚪ پایه‌ای                  |

> \* پارامترهای بودجه: بودجه شروع/بودجه صبر کاربر، با واحد ارز مجازی *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> اندازه‌گیری شده است. برای اطلاعات بیشتر به [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) مراجعه کنید.

### مقیاس‌گذاری زمان تعامل (ITS)

مقیاس‌گذاری زمان تعامل (ITS) به توانایی یک مدل برای افزایش مداوم عملکرد نهایی خود در تعاملات چندمرحله‌ای اشاره دارد. وقتی این عملکرد تعاملی از عملکرد ایده‌آل مدل در یک وظیفه کاملاً مشخص و بدون ابهام فراتر رود، می‌گوییم مدل از **قانون ITS** پیروی می‌کند. با افزایش صبر کاربر و تعداد نوبت‌های تعامل، عملکرد بهبود می‌یابد و نشان می‌دهد مدل می‌تواند ارتباط مؤثر را در گفتگوی طولانی حفظ کند. در حال حاضر، تنها claude-3-7-sonnet این قانون را رعایت می‌کند.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## راه‌اندازی محیط

۱. کانتینرهای Docker برای پایگاه داده bird-interact-lite، پایگاه داده bird-interact-full و محیط ارزیابی را اجرا کنید:
  
  > اگر فقط می‌خواهید روی `bird-interact-lite` ارزیابی کنید، می‌توانید سرویس [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) را در `docker-compose.yml` کامنت کنید تا راه‌اندازی محیط سریع‌تر شود.
  
  محیط را با اجرای دستور زیر شروع کنید:
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
     - 📈 تعداد کل پایگاه‌های داده: ۱۸
     - 📋 تعداد کل جداول: ۱۷۵
     - 🔢 تعداد کل ستون‌ها: ۲۲۸۶
     - 📈 میانگین تعداد ردیف در هر جدول: ۱٬۰۳۸.۴۸
     - 💾 حجم کل: ۲۰۷.۱۵ مگابایت (تقریبی)
   - **bird-interact-full**: 
     - 📈 تعداد کل پایگاه‌های داده: ۲۲
     - 📋 تعداد کل جداول: ۲۴۴
     - 🔢 تعداد کل ستون‌ها: ۲۰۱۱
     - 📈 میانگین تعداد ردیف در هر جدول: ۱٬۱۲۱.۱۹
     - 💾 حجم کل: ۲۷۲.۰۰ مگابایت (تقریبی)


## 📦 جزئیات مجموعه داده

### توضیحات مجموعه داده

- **پایگاه داده:** پایگاه داده کامل PostgreSQL را می‌توان از [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) و [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) دانلود کرد.
- **data:** هر نمونه داده شامل بخش‌های اصلی زیر است:
   - `selected_database`: نام پایگاه داده.  
   - `query`: پرسش کاربر بدون ابهام.  
   - `amb_user_query`: پرسش کاربر با ابهامات تزریق شده.
   - `user_query_ambiguity`: ابهامات تزریق شده در پرسش کاربر.
   - `non_critical_ambiguity`: ابهامات غیر بحرانی مانند ترتیب، محدودیت و غیره.
   - `knowledge_ambiguity`: ابهامات ایجاد شده توسط دانش‌های خارجی ماسک شده. 
   - `sol_sql`: راه‌حل SQL مرجع.  
   - `preprocess_sql`: کوئری‌های SQL که قبل از اجرای راه‌حل یا پیش‌بینی اجرا می‌شوند.  
   - `clean_up_sql`: کوئری‌های SQL که پس از اجرای تست برای بازگردانی تغییرات اعمال شده به پایگاه داده اجرا می‌شوند.  
   - `test_cases`: مجموعه‌ای از تست‌ها برای اعتبارسنجی SQL اصلاح شده پیش‌بینی شده.
   - `follow_up`: پرسش‌های پیگیری برچسب‌گذاری شده.
   - `external_knowledge`: دانش خارجی مرتبط با وظیفه خاص.

- **ارزیابی:** کد ارزیابی در پوشه [`./evaluation`](./evaluation) موجود است.
- **تدوین شده توسط:** تیم BIRD و Google Cloud
- **مجوز:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **کارت مجموعه داده HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  و [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) برای PostgreSQL؛ و [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) برای SQLite.
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
جزئیات مربوط به اجرای **a-interact** در `./bird_interact_agent/README.md` قابل یافت است؛ **c-interact** در `./bird_interact_conv/README.md` قابل یافت است؛ و **پیاده‌سازی مبتنی بر ADK** در `./BIRD-Interact-ADK/README.md` قابل دسترسی است.

## 📋 فهرست کارها

- [x] انتشار نسخه سبک، bird-interact-lite (270).
- [x] انتشار نسخه گفتگو محور، bird-interact-conv.
- [x] انتشار نسخه عامل، bird-interact-agent.
- [x] انتشار نسخه کامل bird-interact-full (600).
- [x] انتشار پیاده‌سازی مبتنی بر ADK، BIRD-Interact-ADK.
- [ ] SFT / RL و شبیه‌ساز کاربر

## تقدیر و تشکر
ما صمیمانه از **ایرینا ساپارینا**، **محمدرضا پوررضا**، **مهدی بوزوئینا**، **هایلونگ لی**، **جیاتونگ شی** و پروفسور **شینجی واتانابه** بابت بحث‌های سازنده و بینش‌های ارزشمندشان که به بهبود این پروژه کمک کردند، قدردانی می‌کنیم.

## ایجاد شده توسط:
تیم BIRD و Google Cloud







## استناد

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

## گزارش تغییرات

- [2025-11-06] 🐛 **رفع باگ** و 🐳 **به‌روزرسانی داکر**: نسخه sqlglot به 26.16.4 به‌روزرسانی شد تا باگ مربوط به عدم توانایی پارس صحیح SQL توسط تجزیه‌گر sql برای شبیه‌ساز کاربر رفع شود. می‌توانید این مشکل را با نصب مجدد توسط `pip install sqlglot==26.16.4` در محیط `bird_interact_eval` برطرف کنید. همچنین ایمیج `bird_interact_eval` به‌روزرسانی شده، پس می‌توانید آن را دریافت کرده و کانتینر `bird_interact_eval` را دوباره ایجاد کنید.
- [2025-10-21] 🐳 **به‌روزرسانی داکر**: داکر برای محیط کامل پایگاه داده اضافه شد. همچنین سه ایمیج داکر (پایه/محیط کامل پایگاه داده و محیط ارزیابی برای هر دو `a-Interact` و `c-Interact`) را برای تسهیل راه‌اندازی محیط روی Docker Hub قرار دادیم. دیگر نیازی به دانلود دامپ‌های پایگاه داده و ساخت دستی ایمیج‌ها نیست! کافیست آخرین ایمیج‌ها را از Docker Hub بگیرید و کانتینرها را دوباره بسازید، مثلاً با استفاده از `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **رفع باگ**: باگی رفع شد که هنگام ارزیابی SQL مرحله ۲، SQL ذخیره‌شده مرحله ۱ قابل اجرا نبود و باعث کاهش نرخ موفقیت مرحله ۲ می‌شد. این باگ فقط روی وظایفی تأثیر می‌گذاشت که SQL مرحله ۱ عملیاتی مانند CREATE table روی پایگاه داده انجام می‌داد.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---