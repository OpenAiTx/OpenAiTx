# گانت
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## نصب

```
yarn install
```

### اجرا

```
yarn run serve
```

### توضیحات

```
نمایش نمودار گانت توسعه یافته بر اساس Vue، قابل استفاده در سناریوهای چابک مانند همکاری تیمی و تقسیم وظایف

پشتیبانی از گروه‌بندی
پشتیبانی از کشیدن و رها کردن (درگ و دراپ)
پشتیبانی از کشش (ری‌سایز)
پشتیبانی از درصد پیشرفت
پشتیبانی از بازه‌های زمانی: روز، هفته، ماه
در حال حاضر فقط گروه‌بندی یک‌سطحی نوشته شده است. به منظور جلوگیری از نیاز به گروه‌بندی دوم یا چندسطحی در آینده، در آخرین ارسال بخشی از کد بازنویسی شده تا پشتیبانی از گروه‌بندی چندسطحی فراهم شود، اما در نسخه فعلی توسعه داده نشده است.

مزایا: هنگام انجام عملیات‌هایی مانند کشیدن و رها کردن، کشش و تغییر پیشرفت، داده‌ها به صورت بلادرنگ به‌روزرسانی نمی‌شوند و پس از پایان عملیات به‌روزرسانی می‌شوند که باعث کاهش مصرف منابع می‌گردد.
در هنگام ویرایش، حذف و اضافه کردن، اصلاح به صورت بازگشتی بر کل نمونه انجام نمی‌شود و فقط بخش تغییر یافته اصلاح می‌شود.

در حال آماده‌سازی ساختار مجدد برای آماده‌سازی جهت کامپوننت‌سازی هستیم. در حال حاضر برای استفاده در پروژه فقط کافی است فایل `gant.vue` این پروژه را وارد کنید.
روش‌های واردات و صادرات داده به صورت دسته‌ای آماده شده و فقط کافی است کپی شوند!~

```

### توضیحات به‌روزرسانی

- پشتیبانی از ویرایش
- پشتیبانی از حذف
- رفع باگ عدم امکان اسکرول عمودی (افزودن اسکرول همزمان دوطرفه) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- رفع باگ ناشی از elementUI
- مورد مربوط به بازه زمانی [#5](https://github.com/GGBeng1/Gantt/issues/5)
- در حال حاضر امکان افزودن بازه‌های دیگر مانند ساعت از طریق تغییر تنظیمات بازه وجود ندارد، زیرا برخی تنظیمات در هنگام مقداردهی اولیه ثابت شده‌اند و در آینده به صورت API ارائه خواهد شد.

### مشاهده نمونه

[دمو](https://ggbeng1.github.io/Gantt/#/) را ببینید

### تصویر نمونه

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---