
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# ترمینارا

[![پرسش از دیپ‌ویکی](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![پشتیبانی از پایتون](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

یک بازی شبیه‌سازی هوش مصنوعی مبتنی بر ترمینال.

## نحوه استفاده

شما می‌توانید برنامه اجرایی را از [آخرین نسخه منتشر شده](https://github.com/luyiourwong/Terminara/releases/latest) دانلود کنید.

فایل فشرده کامل شامل فایل اجرایی و فایل تنظیمات دنیای پیش‌فرض است. اگر بازی را به آخرین نسخه به‌روزرسانی می‌کنید، فقط می‌توانید فایل اجرایی را دانلود کنید.

| سیستم عامل | نسخه                                               |
|------------|----------------------------------------------------|
| ویندوز     | Windows 10، Windows 11                             |
| لینوکس     | (GLIBC 2.35+) Ubuntu 22.04 LTS، Ubuntu 24.04 LTS   |
| مک‌اواس     | macOS 13، macOS 14، macOS 15، macOS 26             |

<details>
<summary><strong>اجرای دستی</strong></summary>

### نصب

1.  **مخزن را کلون کنید:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **ایجاد یک محیط مجازی:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    در ویندوز، از دستور `.venv\Scripts\activate` استفاده کنید

3.  **وابستگی‌ها را نصب کنید:**
    ```bash
    pip install -e .
    ```

### روش شروع ۱: استفاده از دستور نصب‌شده (توصیه‌شده)
پس از نصب، بازی را با دستور زیر اجرا کنید:
```bash
terminara
```

### شروع روش ۲: اجرا به صورت مستقیم
روش سازگار با چند پلتفرم
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
در ویندوز، از `terminara\main.py` استفاده کنید

برای اطلاعات بیشتر، به [راهنمای مشارکت و توسعه](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md) مراجعه کنید.
</details>

## راه‌اندازی هوش مصنوعی

پس از اجرای برنامه، باید تنظیمات هوش مصنوعی را از منوی اصلی پیکربندی کنید.

![تنظیمات هوش مصنوعی](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

باید فیلدهای زیر را پر کنید: (API سازگار با OpenAI)
- **Host**: نقطه پایانی API. برای استفاده از نقطه پایانی پیش‌فرض OpenAI خالی بگذارید.
- **API Key**: کلید API شما برای سرویس هوش مصنوعی.
- **Model**: مدلی که می‌خواهید استفاده کنید.

روی "اعمال" کلیک کنید تا تنظیمات ذخیره شوند.

### مثال‌ها

#### 1. [OpenAI](https://platform.openai.com/) (پیش‌فرض)
- **Host**: (خالی بگذارید)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## راه‌اندازی جهان

### ذخیره‌سازی پیکربندی
تنظیمات جهان در پوشه `terminara/data/worlds` ذخیره می‌شوند. (در نسخه کامل)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### ایجاد یک جهان جدید
یک جهان نمونه به نام [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json) وجود دارد. شما می‌توانید با دنبال کردن [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) یک جهان جدید بسازید.

## پیوندها

- [صفحات گیت‌هاب](https://luyiourwong.github.io/Terminara)
- [مخزن گیت‌هاب](https://github.com/luyiourwong/Terminara)
- [راهنمای مشارکت و توسعه](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## مجوز

این پروژه تحت [مجوز MIT](LICENSE) منتشر شده است.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---