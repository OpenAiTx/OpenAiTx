![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# گیت‌کانتینر 🐳

**هر مخزن GitHub را با تولید داکرفایل هوشمند مبتنی بر هوش مصنوعی به یک کانتینر Docker آماده تولید تبدیل کنید.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

گیت‌کانتینر یک برنامه وب مبتنی بر هوش مصنوعی است که با تحلیل مخازن GitHub، به‌طور خودکار داکرفایل‌های آماده تولید ایجاد می‌کند. فقط کافیست یک URL گیت‌هاب را وارد کنید تا یک داکرفایل متناسب با انتخاب هوشمند تصویر پایه، مدیریت وابستگی‌ها و رعایت بهترین شیوه‌های Docker دریافت کنید.

## 🌟 دسترسی سریع

کافیست در هر URL مخزن GitHub، `github.com` را با `gitcontainer.com` جایگزین کنید تا بلافاصله به صفحه تولید داکرفایل آن مخزن دسترسی پیدا کنید.

برای مثال:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ قابلیت‌ها

- **🔄 دسترسی سریع با URL**: فقط 'github.com' را با 'gitcontainer.com' در هر URL گیت‌هاب جایگزین کنید
- **🤖 تحلیل هوشمند با هوش مصنوعی**: استفاده از OpenAI GPT-4 برای تحلیل ساختار مخزن و تولید داکرفایل هوشمند
- **⚡ پخش زنده**: مشاهده تولید داکرفایل توسط هوش مصنوعی به صورت لحظه‌ای با WebSocket
- **🎯 تشخیص هوشمند فناوری**: شناسایی خودکار تکنولوژی‌ها (پایتون، Node.js، جاوا، Go و غیره)
- **🔧 آماده تولید**: تولید داکرفایل بر اساس بهترین شیوه‌ها با امنیت مناسب، بیلد چندمرحله‌ای و بهینه‌سازی
- **📋 دستورالعمل‌های اضافی**: افزودن نیازمندی‌های سفارشی برای محیط‌های خاص
- **📄 Docker Compose**: پیشنهاد خودکار docker-compose.yml برای برنامه‌های پیچیده
- **🎨 رابط کاربری مدرن**: رابط تمیز و واکنش‌گرا با ویرایشگر Monaco برای برجسته‌سازی کد
- **📱 سازگاری با موبایل**: عملکرد روان در دسکتاپ و دستگاه‌های موبایل

## 🚀 شروع سریع

### پیش‌نیازها

- پایتون 3.9 یا بالاتر
- Git
- کلید API اوپن‌اِی‌آی

### نصب

1. **کلون کردن مخزن:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **نصب وابستگی‌ها:**
   ```bash
   pip install -r requirements.txt
   ```

3. **تنظیم متغیرهای محیطی:**
   ```bash
   # ساخت فایل .env
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **اجرای برنامه:**
   ```bash
   python app.py
   ```

5. **باز کردن مرورگر:**
   به `http://localhost:8000` مراجعه کنید

## 🛠️ نحوه عملکرد

1. **پردازش URL**: دسترسی به هر مخزن با جایگزینی 'github.com' با 'gitcontainer.com' در URL
2. **کلون کردن مخزن**: گیت‌کانتینر مخزن GitHub را با استفاده از Git به صورت محلی کلون می‌کند
3. **تحلیل کد**: با استفاده از [gitingest](https://github.com/cyclotruc/gitingest) ساختار مخزن را تحلیل و اطلاعات مرتبط را استخراج می‌کند
4. **تولید با هوش مصنوعی**: تحلیل به OpenAI GPT-4 با پرامپت‌های تخصصی برای تولید داکرفایل ارسال می‌شود
5. **بهینه‌سازی هوشمند**: هوش مصنوعی موارد زیر را در نظر می‌گیرد:
   - شناسایی فناوری‌ها
   - مدیریت وابستگی‌ها
   - بهترین شیوه‌های امنیتی
   - بیلد چندمرحله‌ای در صورت نیاز
   - پیکربندی پورت‌ها
   - متغیرهای محیطی
   - health check

## 📁 ساختار پروژه

```
cyclotruc-gitcontainer/
├── app.py                 # برنامه اصلی FastAPI
├── requirements.txt       # وابستگی‌های پایتون
├── .env                  # متغیرهای محیطی (ایجاد کنید)
├── static/               # فایل‌های استاتیک (آیکون، CSS)
├── templates/
│   └── index.jinja       # قالب اصلی HTML
└── tools/                # ماژول‌های عملکردی اصلی
    ├── __init__.py
    ├── create_container.py  # تولید داکرفایل با هوش مصنوعی
    ├── git_operations.py    # کلون مخزن GitHub
    └── gitingest.py        # تحلیل مخزن
```
## 🔧 پیکربندی

### متغیرهای محیطی

| متغیر | توضیحات | ضروری |
|----------|-------------|----------|
| `OPENAI_API_KEY` | کلید API شما برای OpenAI | بله |
| `PORT` | پورت سرور (پیش‌فرض: ۸۰۰۰) | خیر |
| `HOST` | میزبان سرور (پیش‌فرض: 0.0.0.0) | خیر |

### استفاده پیشرفته

می‌توانید ابزارها را به صورت برنامه‌نویسی استفاده کنید:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # کلون مخزن
    clone_result = await clone_repo_tool(github_url)
    
    # تحلیل با gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # تولید Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# استفاده
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 سفارشی‌سازی

### افزودن دستورالعمل‌های سفارشی

از قابلیت "دستورالعمل‌های اضافی" برای سفارشی‌سازی تولید استفاده کنید:

- `"استفاده از Alpine Linux برای کاهش حجم تصویر"`
- `"اضافه کردن Redis و PostgreSQL"`
- `"بهینه‌سازی برای استقرار در محیط تولید"`
- `"افزودن ابزارهای توسعه برای اشکال‌زدایی"`

## 📝 مجوز

این پروژه تحت مجوز MIT منتشر شده است - برای جزئیات به فایل [LICENSE](LICENSE) مراجعه کنید.

## 🙏 تقدیر و تشکر

- **[OpenAI](https://openai.com/)** برای ارائه API مدل GPT-4
- **[gitingest](https://github.com/cyclotruc/gitingest)** برای قابلیت‌های تحلیل مخزن
- **[FastAPI](https://fastapi.tiangolo.com/)** برای چارچوب وب عالی
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** برای برجسته‌سازی سینتکس کد

## 🔗 لینک‌ها

- **مخزن GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **دمو**: تست زنده با مخازن نمونه
- **مشکلات**: [گزارش باگ یا درخواست ویژگی جدید](https://github.com/cyclotruc/gitcontainer/issues)

---

**ساخته شده با ❤️ توسط [رومن کورتوا](https://github.com/cyclotruc)**

*هر مخزنی را در چند ثانیه به یک کانتینر تبدیل کنید!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---