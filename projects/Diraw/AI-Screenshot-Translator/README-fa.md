# ابزار ترجمه اسکرین‌شات با هوش مصنوعی (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# معرفی

این ابزار با استفاده از **عملیات ساده اسکرین‌شات**، تصویر را به مدل هوش مصنوعی ارسال می‌کند تا متن را شناسایی و ترجمه کند و نتیجه ترجمه را به صورت HTML تعاملی در یک پنجره مستقل نمایش می‌دهد.

این ابزار از **تعریف کلیدهای میانبر سفارشی، مدیریت نتایج در چند پنجره و اجرای در سینی سیستم** پشتیبانی می‌کند که به طور چشمگیری بهره‌وری ترجمه در کار و یادگیری روزانه را افزایش می‌دهد.

**ویژگی‌های ابزار**: ۱. ترجمه اسکرین‌شات و راه‌اندازی با کلید میانبر؛ ۲. ایجاد و ترجمه برچسب‌های تصویری قابل جابجایی و تغییر اندازه، امکان ایجاد چندین گروه از برچسب‌های ترجمه؛ ۳. امکان جابجایی بین متن اصلی و فرمول برای کپی آسان؛ ۴. رابط API سفارشی

**مشکلاتی که این ابزار حل می‌کند**: ۱. ابزارهای ترجمه رایج برای اسناد کامل، سنگین و کند هستند؛ ۲. در صورت کپی و ترجمه متون pdf، گاهی بخش فرمول‌ها به هم ریخته یا غیرقابل کپی است؛ ۳. در pdfهای اسکن‌شده تصویری، امکان کپی متن وجود ندارد

# نمایش

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# نمایش پنجره

پنجره ترجمه:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

پنجره تنظیمات:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

برای آشنایی بیشتر با گزینه‌های تنظیمات، می‌توانید به بخش داخلی نرم‌افزار یا صفحه [راهنما](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md) مراجعه کنید.

# نصب

شما می‌توانید سورس را دانلود و اجرا کنید یا به بخش [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) رفته و فایل اجرایی را دریافت نمایید.

### ۱. کلون کردن مخزن

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### ۲. ایجاد محیط مجازی و اجرا

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# برنامه به‌روزرسانی

- ~~افزودن پنجره گرافیکی برای پیکربندی API و بهینه‌سازی منطق پیکربندی دستی فایل yaml به ساخت خودکار توسط نرم‌افزار (در نسخه v0.3.0 انجام شد)~~
- افزودن سیستم ذخیره‌سازی تصویر و فرمول برای استفاده‌های بعدی (پیش‌بینی برای نسخه v0.4)
- (برای افزودن امکانات بیشتر، خوشحال می‌شویم پیشنهاد یا PR ارسال کنید)

# سایر موارد

- آیکون نرم‌افزار از [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free) گرفته شده است.
- از Gemini 2.5 Flash و DeepSeek-V3-0324 بابت کمک در یافتن باگ‌ها تشکر می‌کنیم.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---