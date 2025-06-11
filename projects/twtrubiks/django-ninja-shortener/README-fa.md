# Django Ninja Shortener - سرویس کوتاه‌کننده لینک شبیه Bitly

یک سرویس مدرن کوتاه‌کننده لینک ساخته‌شده با Django، Django Ninja و Tailwind CSS که طراحی آن الهام‌گرفته از Bitly است.

کاربران می‌توانند پس از ثبت‌نام و ورود، لینک‌های خود را کوتاه کنند و تعداد کلیک هر لینک کوتاه را دنبال نمایند.

این پروژه با کمک [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) توسعه یافته است. می‌توانید به [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md) مراجعه کنید.

## تصاویر محیط کاربری

صفحه کوتاه‌کننده لینک (بدون نیاز به ثبت‌نام قابل استفاده است)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

اگر ثبت‌نام کنید، می‌توانید آمار کلیک را مشاهده کنید

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ ویژگی‌های شاخص

* **احراز هویت کاربران**: پشتیبانی از ثبت‌نام، ورود و خروج کاربران.
* **ایجاد لینک کوتاه**: کاربران واردشده می‌توانند برای هر لینک بلند، یک لینک کوتاه و منحصربه‌فرد بسازند.
* **ریدایرکت لینک کوتاه**: با کلیک روی لینک کوتاه، کاربر به لینک اصلی هدایت می‌شود.
* **رهگیری تعداد کلیک**: سیستم به‌صورت خودکار تعداد کلیک هر لینک کوتاه را شمارش می‌کند.
* **داشبورد شخصی**: کاربران می‌توانند تمام لینک‌های کوتاه ساخته‌شده و آمار کلیک آن‌ها را مشاهده کنند.
* **API به‌صورت RESTful**: ارائه نقطه دسترسی API برای ساخت برنامه‌نویسی‌شده لینک کوتاه.
* **پشتیبانی از Docker**: ارائه Dockerfile و تنظیمات Docker Compose برای ساده‌سازی توسعه و استقرار.

## 🛠️ تکنولوژی‌های استفاده‌شده

* **فریم‌ورک بک‌اند**: [Django](https://github.com/twtrubiks/django-tutorial)
* **فریم‌ورک API**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **استایل‌دهی فرانت‌اند**: [Tailwind CSS](https://tailwindcss.com/) (یکپارچه با `django-tailwind`)
* **پایگاه داده**:
  * محیط توسعه: SQLite (پیش‌فرض)
  * محیط تولید: به راحتی قابل تعویض با PostgreSQL (تنظیمات در `settings.py` پیش‌بینی شده)
* **کد لینک کوتاه**: تولید با استفاده از `shortuuid`
* **تست**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **کانتینری‌سازی**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 شروع سریع (با Docker - توصیه شده)

این روش توصیه‌شده راه‌اندازی است و یکسان‌سازی محیط توسعه را تضمین می‌کند.

**مراحل راه‌اندازی:**

1. **راه‌اندازی سرویس:**

    با Docker Compose تمام سرویس‌ها را یکجا راه‌اندازی کنید.

    ```bash
    docker compose up --build
    ```

    این دستور ایمیج Docker را می‌سازد، وابستگی‌ها را نصب می‌کند، مهاجرت پایگاه داده را انجام می‌دهد و سرور توسعه را اجرا می‌کند.

2. **ساخت سوپر‌یوزر (اختیاری):**

    برای دسترسی به مدیریت Django، در یک ترمینال دیگر اجرا کنید:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **دسترسی به برنامه:**

    * **صفحه اصلی سایت**: [http://localhost:8000](http://localhost:8000)

    * **مستندات API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 توسعه محلی (بدون Docker)

اگر ترجیح می‌دهید محیط را به صورت محلی تنظیم کنید.

**پیش‌نیازها:**

* Python 3.12
* Node.js و npm (برای Tailwind CSS)

**مراحل راه‌اندازی:**

1. **ایجاد و فعال‌سازی محیط مجازی:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # در ویندوز از `venv\Scripts\activate` استفاده کنید
    ```

2. **نصب وابستگی‌های Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **نصب و تنظیم Tailwind CSS:**

    `django-tailwind` بیشتر تنظیمات را انجام می‌دهد.

    ```bash
    python manage.py tailwind install
    ```

    راهنما: [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **اجرای مهاجرت پایگاه داده:**

    ```bash
    python manage.py migrate
    ```

5. **ساخت سوپر‌یوزر (اختیاری):**

    ```bash
    python manage.py createsuperuser
    ```

6. **اجرای سرور توسعه:**

    باید همزمان سرور Django و کامپایلر Tailwind CSS را اجرا کنید.

    ```bash
    python manage.py runserver
    ```

    و در یک ترمینال دیگر:

    ```bash
    python manage.py tailwind start
    ```

7. **دسترسی به برنامه:**

    * **صفحه اصلی سایت**: [http://localhost:8000](http://localhost:8000)

    * **مستندات API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 اجرای تست‌ها

در این پروژه از `pytest` برای تست و محاسبه پوشش تست استفاده می‌شود.

برنامه تست را می‌توانید در [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md) ببینید.

* **اجرای تست با Docker:**

    ```bash
    docker compose --profile test up
    ```

    گزارش تست در `htmlcov/index.html` تولید خواهد شد.

* **اجرای تست به صورت محلی:**

    ```bash
    # مطمئن شوید وابستگی‌های توسعه نصب شده‌اند
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 نقاط دسترسی API

API راهی برنامه‌نویسی‌شده برای تعامل با سرویس کوتاه‌کننده لینک فراهم می‌کند. تمام نقاط دسترسی API زیر مسیر `/api/` قرار دارند.

توصیه می‌شود مستقیماً به **مستندات API (Swagger UI)** مراجعه کنید: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

با استفاده از [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt)، ابتدا با فراخوانی `/api/token/pair` و وارد کردن نام‌کاربری و رمزعبور، توکن خود را دریافت کنید.

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

سپس توکن را در گوشه بالا سمت راست وارد کنید تا بتوانید API را فراخوانی کنید.

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 ساختار پروژه

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # تنظیمات پروژه Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # اپلیکیشن اصلی کوتاه‌کننده لینک
│   ├── models.py         # مدل‌های پایگاه داده (Link)
│   ├── api.py            # نقاط دسترسی API با Django Ninja
│   ├── views.py          # ویوها و منطق ریدایرکت
│   └── utils.py          # ابزار تولید کد کوتاه
└── theme/                # قالب و تم Django
    ├── templates/        # قالب‌های HTML
    └── static_src/       # سورس Tailwind CSS
```

## 💡 چشم‌انداز آینده

* **انتقال به PostgreSQL**: آماده‌سازی پایگاه داده قوی‌تر برای محیط تولید (انجام شده)
* **داشبورد تحلیلی پیشرفته**: ارائه اطلاعات بیشتر درباره کلیک‌ها مانند زمان، منبع، موقعیت جغرافیایی و غیره.
* **آدرس کوتاه سفارشی**: به کاربران اجازه می‌دهد کد آدرس کوتاه را شخصی‌سازی کنند.
* **تولید QR Code**: برای هر آدرس کوتاه یک QR Code متناظر تولید می‌شود.
* **وظایف غیرهمزمان**: استفاده از Celery برای پردازش وظایف زمان‌بر، مانند تحلیل داده‌ها.

## حمایت مالی

تمامی مقالات حاصل تحقیق و تجربه شخصی من هستند، اگر برای شما مفید بوده و دوست دارید من را تشویق کنید، خوشحال می‌شوم یک فنجان قهوه مهمانم باشید :laughing:

فناوری پرداخت سبز ECPAY (نیازی به ثبت‌نام کاربری ندارد)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[پرداخت حامی مالی](http://bit.ly/2F7Jrha)

اوپی‌پِی (نیاز به ثبت‌نام کاربری دارد)

![alt tag](https://i.imgur.com/LRct9xa.png)

[پرداخت حامی مالی](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## لیست حامیان مالی

[لیست حامیان مالی](https://github.com/twtrubiks/Thank-you-for-donate)

## مجوز

مجوز MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---