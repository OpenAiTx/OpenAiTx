<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <h1>مهندس نرم‌افزار</h1>
  <p>
    <img src="https://img.shields.io/github/actions/workflow/status/mrshaw01/software-engineer/pre-commit.yml?branch=main&label=pre-commit&logo=pre-commit&logoColor=white" alt="pre-commit status">
  </p>

  <p>
    <img src="https://img.shields.io/github/last-commit/mrshaw01/software-engineer" alt="آخرین کامیت">
    <img src="https://img.shields.io/github/issues/mrshaw01/software-engineer" alt="ایرادات">
    <img src="https://img.shields.io/github/issues-pr/mrshaw01/software-engineer" alt="درخواست‌های pull">
  </p>
</div>

یک مجموعه گزینش‌شده و با کیفیت از منابع یادگیری که بر **پایتون** و به زودی **C/C++** متمرکز است و برای ساختن پایه‌های قوی مهندسی نرم‌افزار و درک سطح سیستمی طراحی شده است.

## ساختار مخزن

```text
.
├── python-basic/           # Essential Python syntax, data types, and operations
├── python-advanced/        # Decorators, threading, logging, JSON, and more
├── python-OOP/             # Deep dive into Python's object-oriented programming
├── cpp-basic/              # Fundamentals of C++: syntax, memory, pointers, etc.
├── cpp-advanced/           # Advanced C++: RAII, noexcept, smart pointers, RVO, etc.
├── cpp-OOP/                # Object-oriented programming in C++
├── CUDA/                   # GPU programming with CUDA (host & device code)
├── MPI/                    # Message Passing Interface programming and demos
├── docs/                   # System-level notes on performance, Python-C++ interop, mixed precision, etc.
└── README.md               # Project overview (this file)
```
## نحوه استفاده

هر پوشه شماره‌گذاری شده شامل یک فایل `README.md` است که مفاهیم را توضیح می‌دهد و همراه با فایل‌های قابل اجرا با پسوند `.py` ارائه شده است. به عنوان مثال:


```bash
cd python-advanced/08-decorators
python basic_function_decorator.py
```
برخی اسکریپت‌ها به کتابخانه‌های شخص ثالث نیاز دارند (مثلاً `numpy`، `scipy`، `torch`).

تمام کدها با **پایتون 3.7+** سازگار بوده و به گونه‌ای نوشته شده‌اند که **حداقلی، متمرکز و قابل تست** باشند.

## نکات برجسته

### پایتون

- **تسلط بر OOP**: کلاس‌ها، وراثت، متاکلاس‌ها، توصیف‌گرها (`python-OOP/`)
- **موضوعات پیشرفته**: دکوراتورها، مدیریت زمینه، کشینگ توابع، همزمانی
- **ساختارهای داده**: لیست‌ها، تاپل‌ها، دیکشنری‌ها، ست‌ها با کاربرد عملی

### ++C

- **مبانی ++C**: نحو، توابع، اشاره‌گرها، ساختارها، دامنه، شمارش‌ها (`cpp-basic/`)
- **++C مدرن**: RAII، اسمارت‌پوینترها، معنای انتقال، هم‌ترازی، RVO (`cpp-advanced/`)
- **OOP در ++C**: کلاس‌ها، تعیین‌کننده‌های دسترسی، وراثت، چندریختی، قالب‌ها

### سیستم‌ها و کارایی

- **برنامه‌نویسی CUDA**: مدل میزبان/دستگاه، اجرای کرنل، مدیریت حافظه (`CUDA/`)
- **برنامه‌نویسی MPI**: برنامه‌های توزیع‌شده عملی، عملیات ماتریسی، اجرای اعتبارسنجی (`MPI/`)
- **مستندات**: ارتباط پایتون-++C، مدیریت GIL، تنظیمات CUDA، آموزش با دقت ترکیبی (`docs/`)

## فلسفه یادگیری

- مثال‌های کوچک و ماژولار — بدون نوت‌بوک‌های شلوغ
- جداسازی واضح بین مفهوم، کد و توضیحات
- تاکید بر طراحی، عملکرد و نگهداری‌پذیری
- افزایش تدریجی دانش — ایده‌آل برای فراگیران جدی و حرفه‌ای‌ها

## تاریخچه ستاره‌ها

<a href="https://www.star-history.com/#mrshaw01/software-engineer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
 </picture>
</a>

## 🤝 مشارکت‌ها

باگ، اشتباه تایپی یا تمایل به توسعه چیزی دارید؟ یک PR باز کنید — همه مشارکت‌ها پذیرفته می‌شود.

<p align="center">
  <a href="https://github.com/mrshaw01/software-engineer/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=mrshaw01/software-engineer" />
  </a>
</p>

## 📄 مجوز

مجوز MIT — رایگان برای استفاده، تطبیق و به اشتراک‌گذاری جهت یادگیری و آموزش.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---