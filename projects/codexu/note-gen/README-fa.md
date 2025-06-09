![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

انگلیسی | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## راهنما

NoteGen یک برنامه یادداشت‌برداری کراس‌پلتفرم با فرمت `Markdown` است که به کمک هوش مصنوعی، ضبط و نگارش را به هم متصل می‌کند و دانش پراکنده را به یادداشتی قابل خواندن سازماندهی می‌کند.

🖥️ مستندات رسمی: [https://notegen.top](https://notegen.top)

💬 عضویت در [گروه WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## چرا NoteGen را انتخاب کنیم؟

- سبک وزن: [بسته نصب](https://github.com/codexu/note-gen/releases) تنها **۲۰ مگابایت**، رایگان، بدون تبلیغات و نرم‌افزارهای همراه.
- کراس‌پلتفرم: پشتیبانی از Mac، Windows، Linux و به لطف قابلیت کراس‌پلتفرم `Tauri2`، در آینده از iOS و Android نیز پشتیبانی خواهد کرد.
- پشتیبانی از روش‌های مختلف ضبط شامل `عکس‌برداری از صفحه`، `متن`، `تصاویر توضیحی`، `فایل‌ها`، `لینک‌ها` و غیره، پاسخگوی نیاز ضبط پراکنده در سناریوهای مختلف.
- استفاده از فرمت بومی `Markdown(.md)` به عنوان قالب ذخیره‌سازی، بدون تغییر، آسان برای مهاجرت.
- استفاده آفلاین بومی، با پشتیبانی از همگام‌سازی لحظه‌ای با `مخازن خصوصی GitHub و Gitee` همراه با بازگشت به نسخه‌های قبلی، و همگام‌سازی WebDAV.
- تقویت‌شده با هوش مصنوعی: قابل پیکربندی با ChatGPT، Gemini، Ollama، LM Studio، Grok و سایر مدل‌ها، با پشتیبانی از پیکربندی مدل‌های شخص ثالث سفارشی.
- RAG: یادداشت‌های شما پایگاه دانش شما هستند. پشتیبانی از مدل‌های embedding و مدل‌های reranking.

## تصاویر

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

ضبط:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

نگارش:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

پوسته (تم):

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## از ضبط تا نگارش

برنامه‌های یادداشت‌برداری معمولاً قابلیت ضبط ندارند. کاربران باید محتوای مورد نظر را به صورت دستی کپی و جای‌گذاری کنند که این امر راندمان را بسیار کاهش می‌دهد. در مواجهه با محتوای ضبط‌شده پراکنده، نظم‌دهی آن نیز نیازمند زمان و انرژی زیادی است.

NoteGen به دو بخش `ضبط` و `نگارش` تقسیم شده است که رابطه آن‌ها به شرح زیر است:

- ضبط‌ها می‌توانند به یادداشت‌ها سازماندهی و به صفحه نگارش برای تدوین عمیق‌تر منتقل شوند.
- هنگام نگارش، می‌توانید هر زمان ضبط‌ها را وارد کنید.

### ضبط

قابلیت ضبط مشابه یک **چت‌بات هوش مصنوعی** است، اما هنگام گفتگو با آن می‌توانید ضبط‌های قبلی را نیز به آن مرتبط کنید و از حالت گفتگو به حالت سازماندهی تغییر وضعیت دهید تا ضبط‌ها را به یادداشتی خوانا تبدیل کنید.

امکانات کمکی زیر به ضبط مؤثرتر کمک می‌کنند:

- **برچسب‌ها** برای تمایز سناریوهای مختلف ضبط.
- **پرسوناها** با پشتیبانی از پرامپت‌های سفارشی جهت کنترل دقیق دستیار هوش مصنوعی.
- **دستیار کلیپ‌بورد** که به طور خودکار متن یا تصویر موجود در کلیپ‌بورد را تشخیص داده و به فهرست ضبط‌ها اضافه می‌کند.

### نگارش

بخش نگارش به دو قسمت تقسیم شده است: **مدیریت فایل** و **ویرایشگر Markdown**.

**مدیریت فایل**

- پشتیبانی از مدیریت فایل‌های محلی Markdown و فایل‌های همگام‌سازی شده با GitHub.
- پشتیبانی از سلسله‌مراتب نامحدود پوشه‌ها.
- پشتیبانی از روش‌های مختلف مرتب‌سازی.

**ویرایشگر Markdown**

- پشتیبانی از حالت WYSIWYG، رندر لحظه‌ای و پیش‌نمایش دو پنجره‌ای.
- پشتیبانی از کنترل نسخه با قابلیت بازگشت به نسخه‌های پیشین.
- پشتیبانی از هوش مصنوعی برای گفتگو، ادامه متن، ویرایش و ترجمه.
- پشتیبانی از بارگذاری تصویر و تبدیل آن به لینک تصویر Markdown.
- پشتیبانی از تبدیل HTML به Markdown، تبدیل خودکار محتوای کپی‌شده از مرورگر به فرمت Markdown.
- پشتیبانی از فهرست محتوا، فرمول‌های ریاضی، نقشه ذهنی، نمودار، فلوچارت، گانت چارت، نمودار توالی، خطوط حامل موسیقی، چندرسانه‌ای، خواندن صوتی، پیوند سرعنوان، برجسته‌سازی و کپی کد، رندر graphviz و دیاگرام UML با plantuml.
- پشتیبانی از ذخیره‌سازی لحظه‌ای محتوای محلی، همگام‌سازی خودکار با تأخیر (۱۰ ثانیه بعد از عدم ویرایش) و بازگشت به نسخه‌های قبلی.

## سایر امکانات

- جستجوی سراسری برای یافتن و رفتن سریع به محتوای مورد نظر.
- مدیریت میزبان تصاویر برای مدیریت آسان محتوای مخزن تصاویر.
- پوسته‌ها و ظاهر با پشتیبانی از تم تاریک و تنظیمات ظاهری برای Markdown، کد و غیره.
- پشتیبانی از بین‌المللی‌سازی، فعلاً به زبان‌های چینی و انگلیسی در دسترس است.

## چگونه استفاده کنیم؟

### دانلود

در حال حاضر از Mac، Windows و Linux پشتیبانی می‌شود. به لطف قابلیت کراس‌پلتفرم Tauri2، در آینده از iOS و Android نیز پشتیبانی خواهد شد.

[دانلود NoteGen (نسخه آلفا)](https://github.com/codexu/note-gen/releases)

### ارتقاء

برنامه یادداشت‌برداری بدون نیاز به تنظیمات قابل استفاده است. اگر تجربه بهتری می‌خواهید، لطفاً صفحه تنظیمات را باز و هوش مصنوعی و همگام‌سازی را پیکربندی کنید.

## مشارکت

- [مطالعه راهنمای مشارکت](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [برنامه‌های بروزرسانی](https://github.com/codexu/note-gen/issues/46)
- [گزارش باگ یا پیشنهاد بهبود](https://github.com/codexu/note-gen/issues)
- [بحث و گفتگو](https://github.com/codexu/note-gen/discussions)

## مشارکت‌کنندگان

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## تاریخچه ستاره‌ها

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---