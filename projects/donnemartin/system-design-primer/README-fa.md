*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*

**برای [ترجمه](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md) این راهنما کمک کنید!**

# راهنمای طراحی سیستم

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## انگیزه

> یاد بگیرید چگونه سیستم‌های بزرگ‌مقیاس را طراحی کنید.
>
> برای مصاحبه طراحی سیستم آماده شوید.

### یاد بگیرید چگونه سیستم‌های بزرگ‌مقیاس را طراحی کنید

یادگیری طراحی سیستم‌های مقیاس‌پذیر به شما کمک می‌کند مهندس بهتری شوید.

طراحی سیستم موضوعی گسترده است.  **منابع فراوانی در سراسر وب** در مورد اصول طراحی سیستم وجود دارد.

این مخزن یک **مجموعه سازمان‌یافته** از منابع است تا به شما کمک کند یاد بگیرید چگونه سیستم‌ها را در مقیاس بزرگ بسازید.

### یادگیری از جامعه متن‌باز

این پروژه به صورت متن‌باز و به طور مداوم به‌روزرسانی می‌شود.

[مشارکت‌ها](#contributing) خوش‌آمدید!

### آمادگی برای مصاحبه طراحی سیستم

علاوه بر مصاحبه‌های برنامه‌نویسی، طراحی سیستم یک **جزء الزامی** در **فرآیند مصاحبه فنی** بسیاری از شرکت‌های فناوری است.

**تمرین پرسش‌های رایج مصاحبه طراحی سیستم** و **مقایسه** نتایج خود با **نمونه راه‌حل‌ها**: بحث‌ها، کد، و نمودارها.

موضوعات اضافی برای آمادگی مصاحبه:

* [راهنمای مطالعه](#study-guide)
* [چگونه به پرسش مصاحبه طراحی سیستم نزدیک شویم](#how-to-approach-a-system-design-interview-question)
* [سوالات مصاحبه طراحی سیستم، **به همراه راه‌حل‌ها**](#system-design-interview-questions-with-solutions)
* [سوالات مصاحبه طراحی شیءگرا، **به همراه راه‌حل‌ها**](#object-oriented-design-interview-questions-with-solutions)
* [سوالات اضافی مصاحبه طراحی سیستم](#additional-system-design-interview-questions)

## فلش‌کارت‌های Anki

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

دسته‌های [فلش‌کارت Anki](https://apps.ankiweb.net/) ارائه‌شده از تکرار فاصله‌دار برای حفظ مفاهیم کلیدی طراحی سیستم استفاده می‌کنند.

* [دسته طراحی سیستم](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [دسته تمرین‌های طراحی سیستم](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [دسته تمرین‌های طراحی شیءگرا](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

عالی برای استفاده در حین حرکت.

### منبع کدنویسی: چالش‌های تعاملی کدنویسی

دنبال منبعی برای آمادگی [**مصاحبه کدنویسی**](https://github.com/donnemartin/interactive-coding-challenges) هستید؟

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

مخزن خواهر [**چالش‌های تعاملی کدنویسی**](https://github.com/donnemartin/interactive-coding-challenges) را بررسی کنید که شامل یک دسته Anki اضافی است:

* [دسته کدنویسی](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## مشارکت

> از جامعه یاد بگیرید.

در ارسال pull request برای کمک کردن آزاد هستید:

* رفع خطاها
* بهبود بخش‌ها
* افزودن بخش‌های جدید
* [ترجمه](https://github.com/donnemartin/system-design-primer/issues/28)

مطالبی که نیاز به اصلاح دارند، [در حال توسعه](#under-development) قرار گرفته‌اند.

راهنمای [مشارکت](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md) را مرور کنید.

## فهرست موضوعات طراحی سیستم

> خلاصه‌ای از موضوعات مختلف طراحی سیستم، شامل مزایا و معایب. **همه چیز معامله است**.
>
> هر بخش شامل لینک‌هایی به منابع عمیق‌تر می‌باشد.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [موضوعات طراحی سیستم: از اینجا شروع کنید](#system-design-topics-start-here)
    * [مرحله ۱: ویدیوی آموزشی مقیاس‌پذیری را مرور کنید](#step-1-review-the-scalability-video-lecture)
    * [مرحله ۲: مقاله مقیاس‌پذیری را مرور کنید](#step-2-review-the-scalability-article)
    * [گام‌های بعدی](#next-steps)
* [کارایی در مقابل مقیاس‌پذیری](#performance-vs-scalability)
* [تاخیر در مقابل توان عملیاتی](#latency-vs-throughput)
* [دردسترس بودن در مقابل سازگاری](#availability-vs-consistency)
    * [قضیه CAP](#cap-theorem)
        * [CP - سازگاری و تحمل تقسیم‌بندی](#cp---consistency-and-partition-tolerance)
        * [AP - دردسترس بودن و تحمل تقسیم‌بندی](#ap---availability-and-partition-tolerance)
* [الگوهای سازگاری](#consistency-patterns)
    * [سازگاری ضعیف](#weak-consistency)
    * [سازگاری نهایی](#eventual-consistency)
    * [سازگاری قوی](#strong-consistency)
* [الگوهای دردسترس بودن](#availability-patterns)
    * [Fail-over](#fail-over)
    * [تکثیر](#replication)
    * [دردسترس بودن با اعداد](#availability-in-numbers)
* [سیستم نام دامنه](#domain-name-system)
* [شبکه تحویل محتوا](#content-delivery-network)
    * [CDNهای فشاری](#push-cdns)
    * [CDNهای کششی](#pull-cdns)
* [تعادل بار (Load balancer)](#load-balancer)
    * [فعال-غیرفعال (Active-passive)](#active-passive)
    * [فعال-فعال (Active-active)](#active-active)
    * [تعادل بار لایه ۴](#layer-4-load-balancing)
    * [تعادل بار لایه ۷](#layer-7-load-balancing)
    * [مقیاس‌پذیری افقی](#horizontal-scaling)
* [پراکسی معکوس (سرور وب)](#reverse-proxy-web-server)
    * [تفاوت تعادل بار و پراکسی معکوس](#load-balancer-vs-reverse-proxy)
* [لایه کاربردی](#application-layer)
    * [ریزسرویس‌ها (Microservices)](#microservices)
    * [کشف سرویس](#service-discovery)
* [پایگاه داده](#database)
    * [سیستم مدیریت پایگاه داده رابطه‌ای (RDBMS)](#relational-database-management-system-rdbms)
        * [تکثیر استاد-برده](#master-slave-replication)
        * [تکثیر استاد-استاد](#master-master-replication)
        * [فدراسیون](#federation)
        * [شاردینگ](#sharding)
        * [غیرنرمال‌سازی](#denormalization)
        * [بهینه‌سازی SQL](#sql-tuning)
    * [NoSQL](#nosql)
        * [ذخیره‌سازی کلید-مقدار](#key-value-store)
        * [ذخیره‌سازی سندی](#document-store)
        * [ذخیره‌سازی ستونی گسترده](#wide-column-store)
        * [پایگاه داده گرافی](#graph-database)
    * [SQL یا NoSQL](#sql-or-nosql)
* [کش (Cache)](#cache)
    * [کش سمت کلاینت](#client-caching)
    * [کش CDN](#cdn-caching)
    * [کش سرور وب](#web-server-caching)
    * [کش پایگاه داده](#database-caching)
    * [کش برنامه](#application-caching)
    * [کش در سطح پرس‌وجوی پایگاه داده](#caching-at-the-database-query-level)
    * [کش در سطح شیء](#caching-at-the-object-level)
    * [زمان به‌روزرسانی کش](#when-to-update-the-cache)
        * [کش-کناری (Cache-aside)](#cache-aside)
        * [نوشتن همزمان (Write-through)](#write-through)
        * [نوشتن در پس‌زمینه (write-back)](#write-behind-write-back)
        * [پیش‌بارگذاری (Refresh-ahead)](#refresh-ahead)
* [غیربلادرنگ بودن (Asynchronism)](#asynchronism)
    * [صف‌های پیام](#message-queues)
    * [صف‌های وظیفه](#task-queues)
    * [فشار برگشتی](#back-pressure)
* [ارتباطات](#communication)
    * [پروتکل کنترل انتقال (TCP)](#transmission-control-protocol-tcp)
    * [پروتکل دیتاگرام کاربر (UDP)](#user-datagram-protocol-udp)
    * [فراخوانی رویه از راه دور (RPC)](#remote-procedure-call-rpc)
    * [انتقال وضعیت نمایشی (REST)](#representational-state-transfer-rest)
* [امنیت](#security)
* [ضمیمه](#appendix)
    * [جدول توان‌های دو](#powers-of-two-table)
    * [اعداد تأخیر که هر برنامه‌نویسی باید بداند](#latency-numbers-every-programmer-should-know)
    * [سؤالات تکمیلی مصاحبه طراحی سیستم](#additional-system-design-interview-questions)
    * [معماری‌های دنیای واقعی](#real-world-architectures)
    * [معماری‌های شرکت‌ها](#company-architectures)
    * [وبلاگ‌های مهندسی شرکت‌ها](#company-engineering-blogs)
* [در حال توسعه](#under-development)
* [اعتبارات](#credits)
* [اطلاعات تماس](#contact-info)
* [مجوز](#license)

## راهنمای مطالعه

> موضوعات پیشنهادی برای مرور بر اساس زمان‌بندی مصاحبه شما (کوتاه‌مدت، میان‌مدت، بلندمدت).

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**س: آیا برای مصاحبه باید همه چیز اینجا را بدانم؟**

**ج: خیر، برای آمادگی مصاحبه لازم نیست همه مطالب اینجا را بدانید**.

سؤالاتی که در مصاحبه مطرح می‌شود بستگی به متغیرهایی مانند:

* میزان تجربه شما
* پیش‌زمینه فنی شما
* موقعیت‌هایی که برای آن‌ها مصاحبه می‌دهید
* شرکت‌هایی که با آن‌ها مصاحبه می‌کنید
* شانس

از داوطلبان باتجربه‌تر معمولاً انتظار می‌رود درباره طراحی سیستم بیشتر بدانند. معماران یا سرپرستان تیم ممکن است بیشتر از اعضای فردی انتظار دانش داشته باشند. شرکت‌های بزرگ فناوری احتمالاً یک یا چند مرحله مصاحبه طراحی دارند.

از گسترده شروع کنید و در برخی حوزه‌ها عمیق‌تر شوید. دانستن کمی درباره موضوعات کلیدی طراحی سیستم کمک‌کننده است. راهنمای زیر را بر اساس زمان‌بندی، تجربه، موقعیت‌های شغلی مورد مصاحبه و شرکت‌هایی که با آن‌ها مصاحبه دارید، تنظیم کنید.

* **زمان‌بندی کوتاه** - هدف خود را بر **گستردگی** موضوعات طراحی سیستم قرار دهید. با حل **تعدادی** سوال مصاحبه تمرین کنید.
* **زمان‌بندی متوسط** - هدف خود را بر **گستردگی** و **کمی عمق** در موضوعات طراحی سیستم قرار دهید. با حل **سوالات بیشتری** تمرین کنید.
* **زمان‌بندی طولانی** - هدف خود را بر **گستردگی** و **عمق بیشتر** موضوعات طراحی سیستم قرار دهید. با حل **اکثر** سوالات مصاحبه تمرین کنید.

| | کوتاه | متوسط | طولانی |
|---|---|---|---|
| مروری بر [موضوعات طراحی سیستم](#index-of-system-design-topics) داشته باشید تا دیدی کلی از نحوه کار سیستم‌ها پیدا کنید | :+1: | :+1: | :+1: |
| چند مقاله از [وبلاگ‌های مهندسی شرکت‌ها](#company-engineering-blogs) که برای آن‌ها مصاحبه می‌دهید بخوانید | :+1: | :+1: | :+1: |
| چند [معماری واقعی](#real-world-architectures) را مرور کنید | :+1: | :+1: | :+1: |
| مروری بر [چگونه به یک سوال مصاحبه طراحی سیستم نزدیک شویم](#how-to-approach-a-system-design-interview-question) داشته باشید | :+1: | :+1: | :+1: |
| سوالات [مصاحبه طراحی سیستم با راه‌حل](#system-design-interview-questions-with-solutions) را حل کنید | تعدادی | بسیاری | اکثر |
| سوالات [مصاحبه طراحی شی‌ءگرا با راه‌حل](#object-oriented-design-interview-questions-with-solutions) را حل کنید | تعدادی | بسیاری | اکثر |
| مروری بر [سوالات اضافی مصاحبه طراحی سیستم](#additional-system-design-interview-questions) داشته باشید | تعدادی | بسیاری | اکثر |

## چگونه به یک سوال مصاحبه طراحی سیستم نزدیک شویم

> چگونه یک سوال مصاحبه طراحی سیستم را حل کنیم.

مصاحبه طراحی سیستم یک **گفتگوی باز** است. انتظار می‌رود شما آن را هدایت کنید.

می‌توانید از مراحل زیر برای هدایت بحث استفاده کنید. برای تثبیت این فرایند، بخش [سوالات مصاحبه طراحی سیستم با راه‌حل](#system-design-interview-questions-with-solutions) را با استفاده از مراحل زیر تمرین کنید.

### مرحله ۱: شرح موارد استفاده، محدودیت‌ها و فرضیات

نیازمندی‌ها را جمع‌آوری و دامنه مسئله را مشخص کنید. برای شفاف‌سازی موارد استفاده و محدودیت‌ها سوال بپرسید. فرضیات را بحث کنید.

* چه کسانی قرار است از آن استفاده کنند؟
* چگونه از آن استفاده خواهند کرد؟
* چند کاربر دارد؟
* سیستم چه کاری انجام می‌دهد؟
* ورودی‌ها و خروجی‌های سیستم چیست؟
* انتظار داریم چه مقدار داده را مدیریت کنیم؟
* انتظار چند درخواست در ثانیه را داریم؟
* نسبت خواندن به نوشتن مورد انتظار چقدر است؟

### مرحله ۲: ایجاد یک طراحی سطح بالا

یک طراحی سطح بالا با تمام اجزای مهم را ترسیم کنید.

* اجزای اصلی و ارتباطات را رسم کنید
* ایده‌های خود را توجیه کنید

### مرحله ۳: طراحی اجزای اصلی

جزئیات هر جزء اصلی را بررسی کنید. برای مثال، اگر از شما خواسته شد [یک سرویس کوتاه‌کننده URL طراحی کنید](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)، بحث کنید:

* تولید و ذخیره هش از URL کامل
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) و [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * برخورد هش‌ها
    * SQL یا NoSQL
    * طرح پایگاه داده
* تبدیل URL هش شده به URL کامل
    * جستجو در پایگاه داده
* طراحی API و شی‌گرایی

### مرحله ۴: مقیاس‌دهی طراحی

گلوگاه‌ها را با توجه به محدودیت‌ها شناسایی و رفع کنید. برای مثال، آیا برای رفع مشکلات مقیاس‌پذیری به موارد زیر نیاز دارید؟

* متعادل‌کننده بار
* مقیاس افقی
* کشینگ
* قطعه‌بندی پایگاه داده

راه‌حل‌های بالقوه و مصالحه‌ها را بررسی کنید. همه چیز یک مصالحه است. گلوگاه‌ها را با استفاده از [اصول طراحی سیستم مقیاس‌پذیر](#index-of-system-design-topics) رفع کنید.

### محاسبات سرانگشتی

ممکن است از شما خواسته شود برخی برآوردها را دستی انجام دهید. به [ضمیمه](#appendix) برای منابع زیر مراجعه کنید:

* [استفاده از محاسبات سرانگشتی](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [جدول توان‌های عدد دو](#powers-of-two-table)
* [اعداد تأخیر که هر برنامه‌نویسی باید بداند](#latency-numbers-every-programmer-should-know)

### منبع(ها) و مطالعه بیشتر

برای آشنایی بیشتر با انتظارات، به لینک‌های زیر مراجعه کنید:

* [چگونه در مصاحبه طراحی سیستم موفق شویم](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [مصاحبه طراحی سیستم](http://www.hiredintech.com/system-design)
* [مقدمه‌ای بر معماری و مصاحبه‌های طراحی سیستم](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [قالب طراحی سیستم](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## سوالات مصاحبه طراحی سیستم با راه‌حل‌ها

> سوالات رایج مصاحبه طراحی سیستم با نمونه بحث‌ها، کد و نمودارها.
>
> راه‌حل‌ها به محتوای پوشه `solutions/` لینک شده‌اند.

| سوال | |
|---|---|
| طراحی Pastebin.com (یا Bit.ly) | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| طراحی تایم‌لاین و جستجوی توییتر (یا فید و جستجوی فیسبوک) | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| طراحی یک وب‌کراولر | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| طراحی Mint.com | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| طراحی ساختار داده‌ها برای یک شبکه اجتماعی | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| طراحی یک فروشگاه کلید-مقدار برای موتور جستجو | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| طراحی ویژگی رتبه‌بندی فروش آمازون بر اساس دسته‌بندی | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| طراحی سیستمی که به میلیون‌ها کاربر در AWS مقیاس‌پذیر باشد | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| افزودن سوال طراحی سیستم | [مشارکت](#contributing) |

### طراحی Pastebin.com (یا Bit.ly)

[مشاهده تمرین و راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### طراحی تایم‌لاین و جستجوی توییتر (یا فید و جستجوی فیسبوک)

[مشاهده تمرین و راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### طراحی یک وب‌کراولر

[مشاهده تمرین و راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| طراحی یک هش‌مپ | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| طراحی یک حافظه کش با سیاست کمترین استفاده اخیر | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| طراحی یک مرکز تماس | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| طراحی یک دسته کارت | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| طراحی یک پارکینگ | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| طراحی یک سرور گفت‌وگو | [راه‌حل](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| طراحی یک آرایه دایره‌ای | [مشارکت](#contributing)  |
| افزودن یک سوال طراحی شیءگرا | [مشارکت](#contributing) |

## موضوعات طراحی سیستم: از اینجا شروع کنید

تازه‌وارد به طراحی سیستم هستید؟

ابتدا باید دانش پایه‌ای از اصول رایج کسب کنید، درباره اینکه چه هستند، چگونه استفاده می‌شوند و مزایا و معایبشان یاد بگیرید.

### مرحله ۱: مرور ویدیو سخنرانی مقیاس‌پذیری

[سخنرانی مقیاس‌پذیری در دانشگاه هاروارد](https://www.youtube.com/watch?v=-W9F__D3oY4)

* موضوعات پوشش داده شده:
    * مقیاس‌پذیری عمودی
    * مقیاس‌پذیری افقی
    * کشینگ
    * تعادل بار
    * تکرار پایگاه داده
    * پارتیشن‌بندی پایگاه داده

### مرحله ۲: مرور مقاله مقیاس‌پذیری

[مقیاس‌پذیری](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* موضوعات پوشش داده شده:
    * [کلون‌ها](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [پایگاه‌های داده](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [کش‌ها](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [غیربلوکی بودن](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### گام‌های بعدی

در ادامه به بررسی مبادلات سطح بالا خواهیم پرداخت:

* **کارایی** در مقابل **قابلیت گسترش‌پذیری**
* **تاخیر** در مقابل **توان عملیاتی**
* **دردسترس بودن** در مقابل **یکپارچگی**

در نظر داشته باشید که **همه چیز یک مبادله است**.

سپس به موضوعات خاص‌تری مانند DNS، CDNها و متعادل‌کننده‌های بار خواهیم پرداخت.

## کارایی در مقابل قابلیت گسترش‌پذیری

یک سرویس زمانی **گسترش‌پذیر** است که افزایش **کارایی** آن متناسب با منابع اضافه شده باشد. معمولاً افزایش کارایی به معنی سرویس‌دهی به تعداد بیشتری کار است، اما می‌تواند به معنی پردازش واحدهای بزرگ‌تر کار نیز باشد، مانند زمانی که مجموعه داده‌ها رشد می‌کنند.<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

یک راه دیگر برای نگاه کردن به کارایی در مقابل قابلیت گسترش‌پذیری:

* اگر مشکل **کارایی** دارید، سیستم شما برای یک کاربر کند است.
* اگر مشکل **گسترش‌پذیری** دارید، سیستم شما برای یک کاربر سریع است اما تحت بار سنگین کند می‌شود.

### منابع و مطالعه بیشتر

* [واژه‌ای درباره گسترش‌پذیری](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [گسترش‌پذیری، دردسترس بودن، پایداری، الگوها](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## تاخیر در مقابل توان عملیاتی

**تاخیر** مدت زمانی است که برای انجام یک عمل یا تولید یک نتیجه صرف می‌شود.

**توان عملیاتی** تعداد چنین اعمال یا نتایج در واحد زمان است.

معمولاً باید برای **بیشترین توان عملیاتی** با **تاخیر قابل قبول** هدف‌گذاری کنید.

### منابع و مطالعه بیشتر

* [درک تفاوت تاخیر و توان عملیاتی](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## دردسترس بودن در مقابل یکپارچگی

### قضیه CAP

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>منبع: مرور دوباره قضیه CAP</a></i>
</p>

در یک سیستم کامپیوتری توزیع‌شده، شما فقط می‌توانید دو مورد از تضمین‌های زیر را پشتیبانی کنید:

* **یکپارچگی (Consistency)** - هر خوانش جدیدترین نوشتار را دریافت می‌کند یا با خطا مواجه می‌شود
* **دسترسی‌پذیری (Availability)** - هر درخواست پاسخی دریافت می‌کند، بدون تضمین اینکه شامل جدیدترین نسخه اطلاعات است
* **تحمل تقسیم‌بندی (Partition Tolerance)** - سیستم علیرغم تقسیم‌بندی‌های دلخواه به‌دلیل خرابی‌های شبکه به کار خود ادامه می‌دهد

*شبکه‌ها قابل اعتماد نیستند، بنابراین باید تحمل تقسیم‌بندی را پشتیبانی کنید. باید بین یکپارچگی و دسترسی‌پذیری در نرم‌افزار مصالحه کنید.*

#### CP - یکپارچگی و تحمل تقسیم‌بندی

منتظر ماندن برای پاسخ از گره تقسیم‌شده ممکن است منجر به خطای زمان‌بندی شود. CP گزینه خوبی است اگر نیازهای تجاری شما به خوانش و نوشتار اتمی نیاز دارد.

#### AP - دسترسی‌پذیری و تحمل تقسیم‌بندی

پاسخ‌ها نسخه‌ای از داده‌ها را که در هر گره در دسترس‌تر است بازمی‌گردانند، که ممکن است جدیدترین نباشد. نوشتارها ممکن است زمان‌بر باشند تا زمانی که تقسیم‌بندی رفع شود.

AP انتخاب خوبی است اگر نیازهای تجاری اجازه [یکپارچگی نهایی](#eventual-consistency) را بدهد یا زمانی که سیستم باید علیرغم خطاهای خارجی به کار خود ادامه دهد.

### منبع(ها) و مطالعه بیشتر

* [مرور دوباره قضیه CAP](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [مقدمه‌ای ساده درباره قضیه CAP](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [سؤالات متداول CAP](https://github.com/henryr/cap-faq)
* [قضیه CAP](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## الگوهای یکپارچگی

با وجود چندین نسخه از داده‌های یکسان، با گزینه‌هایی برای همگام‌سازی آنها روبرو هستیم تا کلاینت‌ها دید یکپارچه‌ای از داده‌ها داشته باشند. تعریف یکپارچگی را از [قضیه CAP](#cap-theorem) به یاد آورید - هر خوانش جدیدترین نوشتار را دریافت می‌کند یا با خطا مواجه می‌شود.

### یکپارچگی ضعیف

پس از یک نوشتار، خوانش‌ها ممکن است آن را ببینند یا نبینند. یک روش مبتنی بر تلاش بهترین اتخاذ می‌شود.

این رویکرد در سیستم‌هایی مانند memcached دیده می‌شود. یکپارچگی ضعیف در کاربردهای بلادرنگ مانند VoIP، چت ویدیویی، و بازی‌های چندنفره بلادرنگ خوب عمل می‌کند. برای مثال، اگر در تماس تلفنی باشید و چند ثانیه آنتن‌دهی را از دست بدهید، زمانی که دوباره اتصال برقرار شود، چیزی که در زمان قطع شدن گفته شده را نمی‌شنوید.

### سازگاری نهایی (Eventual consistency)

پس از یک عملیات نوشتن، عملیات خواندن در نهایت آن را مشاهده خواهند کرد (معمولاً در عرض چند میلی‌ثانیه). داده‌ها به صورت غیرهمزمان تکثیر می‌شوند.

این روش در سیستم‌هایی مانند DNS و ایمیل دیده می‌شود. سازگاری نهایی در سیستم‌هایی با دسترسی‌پذیری بالا به خوبی عمل می‌کند.

### سازگاری قوی (Strong consistency)

پس از یک عملیات نوشتن، عملیات خواندن آن را مشاهده خواهند کرد. داده‌ها به صورت همزمان تکثیر می‌شوند.

این روش در سیستم‌های فایل و پایگاه‌های داده رابطه‌ای (RDBMS) دیده می‌شود. سازگاری قوی در سیستم‌هایی که نیاز به تراکنش دارند به خوبی عمل می‌کند.

### منبع(ها) و مطالعه بیشتر

* [تراکنش‌ها بین مراکز داده](http://snarfed.org/transactions_across_datacenters_io.html)

## الگوهای دسترسی‌پذیری

دو الگوی مکمل برای پشتیبانی از دسترسی‌پذیری بالا وجود دارد: **سوئیچ‌پذیری (fail-over)** و **تکثیر (replication)**.

### سوئیچ‌پذیری (Fail-over)

#### فعال-غیرفعال (Active-passive)

در سوئیچ‌پذیری فعال-غیرفعال، سیگنال‌های ضربان قلب بین سرور فعال و سرور غیرفعال در حالت آماده باش ارسال می‌شود. اگر سیگنال قطع شود، سرور غیرفعال آدرس IP فعال را می‌گیرد و خدمات را ادامه می‌دهد.

طول زمان خاموشی به این بستگی دارد که آیا سرور غیرفعال از قبل در حالت آماده باش 'داغ' اجرا می‌شود یا باید از حالت آماده باش 'سرد' راه‌اندازی شود. تنها سرور فعال ترافیک را مدیریت می‌کند.

سوئیچ‌پذیری فعال-غیرفعال همچنین می‌تواند به عنوان سوئیچ‌پذیری استاد-غلام (master-slave) شناخته شود.

#### فعال-فعال (Active-active)

در حالت فعال-فعال، هر دو سرور ترافیک را مدیریت می‌کنند و بار را بین خود تقسیم می‌کنند.

اگر سرورها برای عموم قابل مشاهده باشند، DNS باید از IPهای عمومی هر دو سرور آگاه باشد. اگر سرورها داخلی باشند، منطق برنامه باید از هر دو سرور مطلع باشد.

سوئیچ‌پذیری فعال-فعال همچنین می‌تواند به عنوان سوئیچ‌پذیری استاد-استاد (master-master) شناخته شود.

### معایب: سوئیچ‌پذیری (failover)

* فِیل‌اوِر نیازمند سخت‌افزار بیشتر و پیچیدگی اضافی است.
* در صورت خرابی سیستم فعال پیش از تکثیر داده‌های جدید به سیستم غیرفعال، امکان از دست رفتن داده وجود دارد.

### تکرار (Replication)

#### ارباب-برده و ارباب-ارباب

این موضوع در بخش [پایگاه داده](#database) بیشتر مورد بحث قرار گرفته است:

* [تکرار ارباب-برده](#master-slave-replication)
* [تکرار ارباب-ارباب](#master-master-replication)

### دسترسی‌پذیری به صورت عددی

دسترسی‌پذیری معمولاً با زمان آپ‌تایم (یا داون‌تایم) به عنوان درصد زمانی که سرویس در دسترس است سنجیده می‌شود. دسترسی‌پذیری معمولاً با تعداد عدد ۹ اندازه‌گیری می‌شود--سرویسی با ۹۹.۹۹٪ دسترسی‌پذیری به عنوان چهار عدد ۹ شناخته می‌شود.

#### ۹۹.۹٪ دسترسی‌پذیری - سه عدد ۹

| مدت زمان           | داون‌تایم قابل قبول|
|---------------------|--------------------|
| داون‌تایم سالانه    | ۸ساعت ۴۵دقیقه ۵۷ثانیه|
| داون‌تایم ماهانه    | ۴۳دقیقه ۴۹.۷ثانیه  |
| داون‌تایم هفتگی     | ۱۰دقیقه ۴.۸ثانیه   |
| داون‌تایم روزانه    | ۱دقیقه ۲۶.۴ثانیه   |

#### ۹۹.۹۹٪ دسترسی‌پذیری - چهار عدد ۹

| مدت زمان           | داون‌تایم قابل قبول|
|---------------------|--------------------|
| داون‌تایم سالانه    | ۵۲دقیقه ۳۵.۷ثانیه  |
| داون‌تایم ماهانه    | ۴دقیقه ۲۳ثانیه     |
| داون‌تایم هفتگی     | ۱دقیقه ۵ثانیه      |
| داون‌تایم روزانه    | ۸.۶ثانیه           |

#### دسترسی‌پذیری موازی در مقابل ترتیبی

اگر یک سرویس از چندین مؤلفه آسیب‌پذیر در برابر خرابی تشکیل شده باشد، دسترسی‌پذیری کلی سرویس بستگی به ترتیبی یا موازی بودن مؤلفه‌ها دارد.

###### به صورت ترتیبی
در دسترس بودن کلی کاهش می‌یابد زمانی که دو مؤلفه با دسترس‌پذیری کمتر از ۱۰۰٪ به صورت متوالی قرار گرفته باشند:


```
Availability (Total) = Availability (Foo) * Availability (Bar)
```
اگر هر دو `Foo` و `Bar` هرکدام ۹۹.۹٪ دسترسی‌پذیری داشته باشند، دسترسی‌پذیری کل آن‌ها به صورت دنباله‌ای ۹۹.۸٪ خواهد بود.

###### به صورت موازی

دسترسی‌پذیری کلی زمانی افزایش می‌یابد که دو مؤلفه با دسترسی‌پذیری کمتر از ۱۰۰٪ به صورت موازی باشند:


```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
اگر هرکدام از `Foo` و `Bar` دارای دسترسی‌پذیری ۹۹.۹٪ باشند، دسترسی‌پذیری کلی آن‌ها در حالت موازی ۹۹.۹۹۹۹٪ خواهد بود.

## سامانه نام دامنه (DNS)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>منبع: ارائه امنیت DNS</a></i>
</p>

سامانه نام دامنه (DNS) یک نام دامنه مانند www.example.com را به یک آدرس IP ترجمه می‌کند.

DNS ساختاری سلسله‌مراتبی دارد و تعداد کمی سرور معتبر در بالاترین سطح آن قرار دارند. روتر یا ISP شما اطلاعاتی در مورد اینکه هنگام جستجو به کدام سرور DNS مراجعه شود، ارائه می‌دهد. سرورهای DNS سطح پایین‌تر نگاشت‌ها را کش می‌کنند که ممکن است به دلیل تأخیر در انتشار DNS، منسوخ شوند. نتایج DNS می‌تواند توسط مرورگر یا سیستم‌عامل شما برای مدت معینی که توسط [زمان حیات (TTL)](https://en.wikipedia.org/wiki/Time_to_live) تعیین می‌شود، کش شوند.

* **رکورد NS (نام سرور)** - سرورهای DNS دامنه/زیر دامنه شما را مشخص می‌کند.
* **رکورد MX (تبادل ایمیل)** - سرورهای ایمیل را برای دریافت پیام‌ها تعیین می‌کند.
* **رکورد A (آدرس)** - یک نام را به یک آدرس IP اشاره می‌دهد.
* **CNAME (نام متعارف)** - یک نام را به نام دیگر یا `CNAME` (مثلاً example.com به www.example.com) یا به یک رکورد `A` اشاره می‌دهد.

خدماتی مانند [CloudFlare](https://www.cloudflare.com/dns/) و [Route 53](https://aws.amazon.com/route53/) خدمات DNS مدیریت‌شده ارائه می‌دهند. برخی سرویس‌های DNS می‌توانند ترافیک را از روش‌های مختلف هدایت کنند:

* [چرخش دورانی وزنی](https://www.jscape.com/blog/load-balancing-algorithms)
    * جلوگیری از ارسال ترافیک به سرورهای در حال نگهداری
    * توازن بین اندازه‌های مختلف کلاستر
    * تست A/B
* [بر پایه تأخیر](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [بر پایه موقعیت جغرافیایی](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### معایب: DNS

* دسترسی به یک سرور DNS تا حدی تأخیر دارد، اگرچه این موضوع با کشینگ که در بالا توضیح داده شد، کاهش می‌یابد.
* مدیریت سرورهای DNS می‌تواند پیچیده باشد و عموماً توسط [دولت‌ها، ارائه‌دهندگان اینترنت و شرکت‌های بزرگ](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729) مدیریت می‌شود.
* خدمات DNS اخیراً مورد [حملات DDoS](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/) قرار گرفته‌اند که مانع از دسترسی کاربران به وب‌سایت‌هایی مانند توییتر بدون دانستن آدرس IP توییتر شده‌اند.

### منابع و مطالعه بیشتر

* [معماری DNS](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [ویکی‌پدیا](https://en.wikipedia.org/wiki/Domain_Name_System)
* [مقالات DNS](https://support.dnsimple.com/categories/dns/)


## شبکه تحویل محتوا

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>منبع: چرا از CDN استفاده کنیم</a></i>
</p>

شبکه تحویل محتوا (CDN) یک شبکه پراکنده جهانی از سرورهای پروکسی است که محتوا را از مکان‌هایی نزدیک‌تر به کاربر ارائه می‌دهد. معمولاً فایل‌های ثابت مانند HTML/CSS/JS، عکس‌ها و ویدئوها از CDN ارائه می‌شوند، اگرچه برخی CDNها مانند CloudFront آمازون از محتوای پویا نیز پشتیبانی می‌کنند. حل DNS سایت به مشتریان می‌گوید با کدام سرور تماس بگیرند.

ارائه محتوا از طریق CDNها می‌تواند عملکرد را به دو روش به طور قابل توجهی بهبود بخشد:

* کاربران محتوا را از دیتاسنترهای نزدیک خود دریافت می‌کنند
* سرورهای شما مجبور نیستند درخواست‌هایی که CDN پاسخ می‌دهد را سرویس دهند

### CDNهای Push

CDNهای Push محتوای جدید را هر زمان که تغییری در سرور شما رخ دهد دریافت می‌کنند. شما مسئولیت کامل ارائه محتوا را دارید، محتوا را مستقیماً به CDN آپلود می‌کنید و URLها را طوری بازنویسی می‌کنید که به CDN اشاره کنند. شما می‌توانید زمان انقضا و بروزرسانی محتوا را پیکربندی کنید. محتوا فقط زمانی که جدید یا تغییر یافته باشد آپلود می‌شود، که ترافیک را به حداقل می‌رساند اما فضای ذخیره‌سازی را به حداکثر می‌رساند.

سایت‌هایی با میزان ترافیک کم یا سایت‌هایی که محتوا به ندرت به‌روزرسانی می‌شود برای CDNهای Push مناسب هستند. محتوا فقط یک بار روی CDN قرار می‌گیرد، به جای اینکه در فواصل منظم مجدداً بارگیری شود.

### CDNهای Pull

CDNهای Pull زمانی که اولین کاربر محتوا را درخواست کند، محتوای جدید را از سرور شما دریافت می‌کنند. شما محتوا را روی سرور خود نگه می‌دارید و URLها را طوری بازنویسی می‌کنید که به CDN اشاره کنند. این باعث می‌شود اولین درخواست کندتر باشد تا زمانی که محتوا روی CDN کش شود.

یک [زمان عمر (TTL)](https://en.wikipedia.org/wiki/Time_to_live) تعیین می‌کند محتوا چه مدت کش می‌شود. CDNهای Pull فضای ذخیره‌سازی را روی CDN به حداقل می‌رسانند، اما اگر فایل‌ها منقضی شوند و قبل از تغییر مجدداً دریافت شوند، می‌توانند ترافیک تکراری ایجاد کنند.

سایت‌هایی با ترافیک سنگین برای CDNهای Pull مناسب هستند، زیرا ترافیک به طور یکنواخت‌تر پخش می‌شود و فقط محتوای اخیراً درخواست شده روی CDN باقی می‌ماند.

### معایب: CDN

* هزینه CDN بسته به میزان ترافیک می‌تواند قابل توجه باشد، اگرچه این هزینه باید با هزینه‌های اضافی عدم استفاده از CDN مقایسه شود.
* محتوا ممکن است منسوخ باشد اگر قبل از انقضای TTL بروزرسانی شود.
* CDNها نیازمند تغییر URLهای محتوای ثابت برای اشاره به CDN هستند.

### منابع و مطالعه بیشتر

* [تحویل محتوا به صورت توزیع‌شده جهانی](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [تفاوت بین CDNهای Push و Pull](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)
* [ویکی‌پدیا](https://en.wikipedia.org/wiki/Content_delivery_network)

## متعادل‌کننده بار (Load balancer)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>منبع: الگوهای طراحی سیستم مقیاس‌پذیر</a></i>
</p>

متعادل‌کننده‌های بار درخواست‌های ورودی مشتری را به منابع محاسباتی مانند سرورهای برنامه و پایگاه‌های داده توزیع می‌کنند. در هر حالت، متعادل‌کننده بار پاسخ منابع محاسباتی را به مشتری مناسب بازمی‌گرداند. متعادل‌کننده‌های بار در موارد زیر مؤثر هستند:

* جلوگیری از ارسال درخواست‌ها به سرورهای ناسالم
* جلوگیری از بارگذاری بیش از حد منابع
* کمک به حذف نقطه شکست واحد

متعادل‌کننده‌های بار می‌توانند با سخت‌افزار (گران‌قیمت) یا با نرم‌افزاری مانند HAProxy پیاده‌سازی شوند.

مزایای اضافی عبارتند از:

* **پایان‌دهی SSL** - رمزگشایی درخواست‌های ورودی و رمزگذاری پاسخ‌های سرور تا سرورهای پشتی مجبور نباشند این عملیات پرهزینه را انجام دهند
    * حذف نیاز به نصب [گواهی‌نامه‌های X.509](https://en.wikipedia.org/wiki/X.509) روی هر سرور
* **پایداری نشست (Session persistence)** - صدور کوکی و هدایت درخواست‌های یک مشتری خاص به همان نمونه اگر برنامه‌های وب جلسات را پیگیری نمی‌کنند

برای محافظت در برابر خرابی‌ها، معمولاً چندین متعادل‌کننده بار، یا به صورت [فعال-غیرفعال](#active-passive) یا [فعال-فعال](#active-active) راه‌اندازی می‌شوند.

متعادل‌کننده‌های بار می‌توانند ترافیک را بر اساس معیارهای مختلفی هدایت کنند، از جمله:

* تصادفی
* کم‌بارترین
* نشست/کوکی‌ها
* [گردش نوبتی یا گردش نوبتی وزنی](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [لایه ۴](#layer-4-load-balancing)
* [لایه ۷](#layer-7-load-balancing)

### متعادل‌سازی بار در لایه ۴

متعادل‌کننده‌های بار لایه ۴ اطلاعات موجود در [لایه انتقال](#communication) را برای تصمیم‌گیری درباره نحوه توزیع درخواست‌ها بررسی می‌کنند. معمولاً این شامل آدرس‌های IP مبدأ و مقصد و پورت‌ها در سربرگ است، اما محتوای بسته را شامل نمی‌شود. متعادل‌کننده‌های بار لایه ۴ بسته‌های شبکه را به سرور بالادستی ارسال و دریافت می‌کنند و عملیات [ترجمه آدرس شبکه (NAT)](https://www.nginx.com/resources/glossary/layer-4-load-balancing/) را انجام می‌دهند.

### متعادل‌سازی بار در لایه ۷

تعادل‌کننده‌های بار لایه ۷ به [لایه کاربرد](#communication) نگاه می‌کنند تا تصمیم بگیرند چگونه درخواست‌ها را توزیع کنند. این می‌تواند شامل محتوای هدر، پیام و کوکی‌ها باشد. تعادل‌کننده‌های بار لایه ۷ ترافیک شبکه را خاتمه می‌دهند، پیام را می‌خوانند، تصمیم تعادل بار را می‌گیرند و سپس یک اتصال به سرور منتخب باز می‌کنند. برای مثال، تعادل‌کننده بار لایه ۷ می‌تواند ترافیک ویدئو را به سرورهایی که ویدئوها را میزبانی می‌کنند هدایت کند، در حالی که ترافیک حساس‌تر صورتحساب کاربر را به سرورهایی با امنیت بیشتر هدایت کند.

در ازای انعطاف‌پذیری، تعادل بار لایه ۴ نسبت به لایه ۷ زمان و منابع محاسباتی کمتری نیاز دارد، اگرچه تأثیر عملکرد روی سخت‌افزارهای کالایی مدرن می‌تواند حداقل باشد.

### مقیاس‌بندی افقی

تعادل‌کننده‌های بار می‌توانند به مقیاس‌بندی افقی نیز کمک کنند و عملکرد و دسترس‌پذیری را بهبود بخشند. مقیاس‌بندی با استفاده از ماشین‌های کالایی مقرون به‌صرفه‌تر بوده و دسترس‌پذیری بیشتری نسبت به ارتقاء یک سرور واحد با سخت‌افزار گران‌تر دارد که به آن **مقیاس‌بندی عمودی** گفته می‌شود. همچنین استخدام نیروی کار برای سخت‌افزار کالایی آسان‌تر از سیستم‌های سازمانی خاص است.

#### معایب: مقیاس‌بندی افقی

* مقیاس‌بندی افقی پیچیدگی ایجاد می‌کند و شامل کلون کردن سرورهاست
    * سرورها باید بدون حالت باشند: نباید داده‌های مرتبط با کاربر مثل نشست‌ها یا تصاویر پروفایل را داشته باشند
    * نشست‌ها می‌توانند در یک مخزن داده مرکزی مثل [پایگاه داده](#database) (SQL، NoSQL) یا [کش](#cache) دائمی (ردیس، مم‌کش) ذخیره شوند
* سرورهای پایین‌دستی مانند کش و پایگاه داده باید اتصالات همزمان بیشتری را با افزایش سرورهای بالادستی مدیریت کنند

### معایب: تعادل‌کننده بار

* اگر تعادل‌کننده بار منابع کافی نداشته باشد یا به درستی پیکربندی نشده باشد، می‌تواند به گلوگاه عملکرد تبدیل شود.
* اضافه کردن تعادل‌کننده بار برای حذف نقطه شکست منفرد منجر به افزایش پیچیدگی می‌شود.
* یک تعادل‌کننده بار منفرد خود یک نقطه شکست منفرد است، پیکربندی چند تعادل‌کننده بار پیچیدگی را بیشتر می‌کند.

### منابع و مطالعه بیشتر

* [معماری NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [راهنمای معماری HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [مقیاس‌پذیری](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [ویکی‌پدیا](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [تعادل بار لایه ۴](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [تعادل بار لایه ۷](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [پیکربندی شنونده ELB](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## پراکسی معکوس (وب سرور)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>منبع: ویکی‌پدیا</a></i>
  <br/>
</p>
پروکسی معکوس یک وب‌سرور است که خدمات داخلی را متمرکز کرده و واسط‌های یکپارچه‌ای را به عموم ارائه می‌دهد. درخواست‌های مشتریان به سروری که قادر به پاسخگویی است ارسال می‌شود، سپس پروکسی معکوس پاسخ سرور را به مشتری بازمی‌گرداند.

مزایای اضافی شامل:

* **افزایش امنیت** - مخفی کردن اطلاعات مربوط به سرورهای پشتی، لیست سیاه کردن آی‌پی‌ها، محدود کردن تعداد اتصالات هر مشتری
* **افزایش مقیاس‌پذیری و انعطاف‌پذیری** - مشتریان فقط آی‌پی پروکسی معکوس را می‌بینند، بنابراین می‌توانید سرورها را مقیاس‌دهی یا پیکربندی آن‌ها را تغییر دهید
* **پایان‌دهی SSL** - رمزگشایی درخواست‌های ورودی و رمزگذاری پاسخ‌های سرور تا سرورهای پشتی نیازی به انجام این عملیات پرهزینه نداشته باشند
    * حذف نیاز به نصب [گواهی X.509](https://en.wikipedia.org/wiki/X.509) روی هر سرور
* **فشرده‌سازی** - فشرده‌سازی پاسخ‌های سرور
* **کشینگ** - بازگرداندن پاسخ برای درخواست‌های کش شده
* **محتوای ایستا** - ارائه مستقیم محتوای ایستا
    * HTML/CSS/JS
    * عکس‌ها
    * ویدئوها
    * غیره

### متعادل‌کننده بار در مقابل پروکسی معکوس

* استفاده از متعادل‌کننده بار زمانی مفید است که چندین سرور داشته باشید. غالباً متعادل‌کننده‌های بار ترافیک را به مجموعه‌ای از سرورهای دارای عملکرد مشابه هدایت می‌کنند.
* پروکسی‌های معکوس حتی با وجود یک وب‌سرور یا سرور برنامه نیز مفید هستند و مزایای بخش قبلی را ارائه می‌دهند.
* راهکارهایی مانند NGINX و HAProxy می‌توانند هم پروکسی معکوس لایه ۷ و هم متعادل‌سازی بار را پشتیبانی کنند.

### معایب: پروکسی معکوس

* معرفی پروکسی معکوس باعث افزایش پیچیدگی می‌شود.
* یک پروکسی معکوس واحد نقطه شکست واحد است و پیکربندی چندین پروکسی معکوس (مثلاً [failover](https://en.wikipedia.org/wiki/Failover)) پیچیدگی بیشتری ایجاد می‌کند.

### منابع و مطالعه بیشتر

* [پروکسی معکوس در مقابل متعادل‌کننده بار](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [معماری NGINX](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [راهنمای معماری HAProxy](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [ویکی‌پدیا](https://en.wikipedia.org/wiki/Reverse_proxy)

## لایه برنامه

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>

  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>منبع: مقدمه‌ای بر معماری سیستم‌ها برای مقیاس‌پذیری</a></i>
</p>

جدا کردن لایه وب از لایه برنامه (که به عنوان لایه پلتفرم نیز شناخته می‌شود) این امکان را می‌دهد تا هر دو لایه را به طور مستقل مقیاس‌بندی و پیکربندی کنید. اضافه کردن یک API جدید منجر به افزودن سرورهای برنامه بدون لزوم اضافه کردن سرورهای وب بیشتر می‌شود. اصل **مسئولیت واحد** طرفدار خدمات کوچک و مستقل است که با هم کار می‌کنند. تیم‌های کوچک با سرویس‌های کوچک می‌توانند برای رشد سریع‌تر برنامه‌ریزی تهاجمی‌تری داشته باشند.

کارگران در لایه برنامه همچنین به فعال‌سازی [غیرهمزمانی](#asynchronism) کمک می‌کنند.

### میکروسرویس‌ها

مرتبط با این بحث، [میکروسرویس‌ها](https://en.wikipedia.org/wiki/Microservices) هستند که به عنوان مجموعه‌ای از سرویس‌های کوچک، مدولار و مستقل که به طور جداگانه قابل استقرار هستند، توصیف می‌شوند. هر سرویس یک فرآیند منحصربه‌فرد را اجرا می‌کند و از طریق یک مکانیزم سبک و با تعریف دقیق با دیگر سرویس‌ها برای تحقق هدف کسب‌وکار ارتباط برقرار می‌کند. <sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

برای مثال، Pinterest می‌تواند میکروسرویس‌هایی مانند پروفایل کاربر، دنبال‌کننده، خوراک، جستجو، بارگذاری عکس و غیره داشته باشد.

### کشف سرویس

سیستم‌هایی مانند [Consul](https://www.consul.io/docs/index.html)، [Etcd](https://coreos.com/etcd/docs/latest)، و [Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) می‌توانند با ردیابی نام‌ها، آدرس‌ها و پورت‌های ثبت‌شده به سرویس‌ها در یافتن یکدیگر کمک کنند. [بررسی سلامت](https://www.consul.io/intro/getting-started/checks.html) به اعتبار سرویس کمک می‌کند و اغلب با استفاده از یک نقطه پایانی [HTTP](#hypertext-transfer-protocol-http) انجام می‌شود. هر دو Consul و Etcd دارای [ذخیره‌ساز کلید-مقدار](#key-value-store) داخلی هستند که می‌تواند برای ذخیره مقادیر پیکربندی و داده‌های مشترک دیگر مفید باشد.

### معایب: لایه برنامه

* افزودن یک لایه برنامه با سرویس‌های ضعیفاً متصل نیازمند رویکرد متفاوتی از نظر معماری، عملیات و فرآیند (در مقایسه با سیستم یکپارچه) است.
* میکروسرویس‌ها می‌توانند پیچیدگی را از نظر استقرار و عملیات افزایش دهند.

### منابع و مطالعات بیشتر

* [مقدمه‌ای بر معماری سیستم‌ها برای مقیاس‌پذیری](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [مصاحبه طراحی سیستم را بشکنید](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [معماری مبتنی بر سرویس](https://en.wikipedia.org/wiki/Service-oriented_architecture)
* [مقدمه‌ای بر Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [آنچه باید درباره ساخت میکروسرویس‌ها بدانید](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## پایگاه داده

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>منبع: مقیاس‌دهی تا اولین ۱۰ میلیون کاربر</a></i>
</p>

### سیستم مدیریت پایگاه داده رابطه‌ای (RDBMS)

یک پایگاه داده رابطه‌ای مانند SQL مجموعه‌ای از داده‌ها است که در جداول سازماندهی شده‌اند.

**ACID** مجموعه‌ای از ویژگی‌های [تراکنش‌های](https://en.wikipedia.org/wiki/Database_transaction) پایگاه داده رابطه‌ای است.

* **اتمی بودن** - هر تراکنش یا کاملاً انجام می‌شود یا اصلاً انجام نمی‌شود
* **سازگاری** - هر تراکنش پایگاه داده را از یک حالت معتبر به حالت معتبر دیگر منتقل می‌کند
* **جداسازی** - اجرای همزمان تراکنش‌ها همان نتایجی را دارد که اگر تراکنش‌ها به صورت سریالی اجرا شوند
* **ماندگاری** - پس از آنکه یک تراکنش ثبت شد، باقی خواهد ماند

تکنیک‌های زیادی برای مقیاس‌پذیری پایگاه داده رابطه‌ای وجود دارد: **تکثیر master-slave**، **تکثیر master-master**، **فدراسیون**، **شاردینگ**، **غیرنرمال‌سازی** و **تنظیم SQL**.

#### تکثیر master-slave

سرور master عملیات خواندن و نوشتن را انجام می‌دهد و نوشتن‌ها را به یک یا چند سرور slave تکثیر می‌کند؛ سرورهای slave فقط عملیات خواندن را انجام می‌دهند. slaveها می‌توانند به صورت درختی به slaveهای بیشتری تکثیر شوند. اگر master آفلاین شود، سیستم می‌تواند تا زمانی که یک slave به master ارتقا یابد یا master جدیدی فراهم شود، به صورت فقط خواندنی به کار خود ادامه دهد.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>منبع: الگوهای مقیاس‌پذیری، دسترسی‌پذیری، پایداری</a></i>
</p>

##### معایب: تکثیر master-slave

* منطق اضافی برای ارتقای یک slave به master مورد نیاز است.
* برای نکات مرتبط با **هر دو** master-slave و master-master به [معایب: تکثیر](#disadvantages-replication) مراجعه کنید.

#### تکثیر master-master

هر دو سرور master عملیات خواندن و نوشتن را انجام داده و در نوشتن‌ها با یکدیگر هماهنگ می‌شوند. اگر یکی از masterها از دسترس خارج شود، سیستم می‌تواند با حفظ هر دو عملیات خواندن و نوشتن به کار خود ادامه دهد.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>منبع: الگوهای مقیاس‌پذیری، دسترسی‌پذیری، پایداری</a></i>
</p>

##### معایب: تکثیر master-master

* به یک load balancer نیاز دارید یا باید تغییراتی در منطق برنامه خود ایجاد کنید تا محل نوشتن مشخص شود.
* بیشتر سیستم‌های master-master یا به طور ضعیف سازگارند (نقض ACID) یا دارای تأخیر بیشتر در نوشتن به دلیل همگام‌سازی هستند.
* حل تعارض بیشتر زمانی مطرح می‌شود که تعداد گره‌های نوشتن افزایش یابد و تأخیر بیشتر شود.
* برای نکاتی که مربوط به هر دو حالت **master-slave** و **master-master** هستند، به [معایب: تکرار](#disadvantages-replication) مراجعه کنید.

##### معایب: تکرار

* احتمال از دست رفتن داده وجود دارد اگر مستر قبل از اینکه داده‌ی جدید نوشته شده بتواند به گره‌های دیگر تکرار شود، از کار بیفتد.
* نوشتن‌ها برای تکرار به رپلیکای‌های خواندن بازپخش می‌شوند. اگر تعداد نوشتن‌ها زیاد باشد، رپلیکای‌های خواندن ممکن است با بازپخش نوشتن‌ها سنگین شده و نتوانند به اندازه کافی عملیات خواندن انجام دهند.
* هر چه تعداد گره‌های خواندن بیشتر باشد، باید بیشتر تکرار شود که این باعث افزایش تاخیر در تکرار می‌گردد.
* در برخی سیستم‌ها، نوشتن در مستر می‌تواند چندین رشته را برای نوشتن موازی راه‌اندازی کند، در حالی که رپلیکای‌های خواندن فقط از نوشتن ترتیبی با یک رشته پشتیبانی می‌کنند.
* تکرار سخت‌افزار بیشتر و پیچیدگی اضافی ایجاد می‌کند.

##### منابع و مطالعه بیشتر: تکرار

* [مقیاس‌پذیری، دسترسی‌پذیری، پایداری، الگوها](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [تکرار چندمستری](https://en.wikipedia.org/wiki/Multi-master_replication)

#### فدراسیون

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>منبع: مقیاس‌بندی تا اولین ۱۰ میلیون کاربر شما</a></i>
</p>

فدراسیون (یا تقسیم‌بندی عملکردی) پایگاه‌های داده را بر اساس عملکرد تقسیم می‌کند. برای مثال، به جای یک پایگاه داده یکپارچه، می‌توانید سه پایگاه داده داشته باشید: **تالارها**، **کاربران** و **محصولات** که منجر به ترافیک خواندن و نوشتن کمتر برای هر پایگاه داده و در نتیجه تاخیر کمتر در تکرار می‌شود. پایگاه‌های داده کوچک‌تر باعث می‌شود داده‌های بیشتری در حافظه جای بگیرند که به نوبه خود منجر به افزایش برخورد کش به دلیل بهبود محلی بودن کش می‌شود. با حذف یک مستر مرکزی برای ترتیب‌دهی نوشتن‌ها، می‌توانید به صورت موازی بنویسید و توان عملیاتی را افزایش دهید.

##### معایب: فدراسیون

* فدراسیون اگر طرح شما نیاز به جداول یا توابع بزرگ داشته باشد، مؤثر نیست.
* باید منطق برنامه خود را بروزرسانی کنید تا مشخص کند از کدام پایگاه داده باید خواند یا نوشت.
* پیوستن داده از دو پایگاه داده با [لینک سرور](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers) پیچیده‌تر است.
* فدراسیون سخت‌افزار بیشتر و پیچیدگی اضافی ایجاد می‌کند.

##### منابع و مطالعه بیشتر: فدراسیون

* [مقیاس‌بندی تا اولین ۱۰ میلیون کاربر شما](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### شاردینگ

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>منبع: الگوهای مقیاس‌پذیری، دسترسی‌پذیری، پایداری</a></i>
</p>

شاردینگ داده‌ها را بین پایگاه‌های داده مختلف توزیع می‌کند به طوری که هر پایگاه داده فقط می‌تواند زیرمجموعه‌ای از داده‌ها را مدیریت کند. به عنوان مثال، با افزایش تعداد کاربران در یک پایگاه داده کاربران، شاردهای بیشتری به کلاستر اضافه می‌شوند.

مشابه مزایای [فدراسیون](#federation)، شاردینگ منجر به ترافیک کمتر خواندن و نوشتن، تکرار کمتر و تعداد بیشتر اصابت کش می‌شود. اندازه ایندکس نیز کاهش می‌یابد که معمولاً عملکرد را با پرس‌وجوهای سریع‌تر بهبود می‌دهد. اگر یک شارد از کار بیفتد، سایر شاردها همچنان فعال هستند، اگرچه بهتر است نوعی تکرار داده برای جلوگیری از فقدان داده اضافه کنید. مانند فدراسیون، هیچ سرور مرکزی واحدی برای سریال‌سازی نوشتن‌ها وجود ندارد، که به شما امکان نوشتن موازی با توان عملیاتی بیشتر می‌دهد.

روش‌های رایج برای شارد کردن جدول کاربران معمولاً براساس حرف اول نام خانوادگی کاربر یا موقعیت جغرافیایی کاربر انجام می‌شود.

##### معایب: شاردینگ

* باید منطق برنامه خود را به گونه‌ای به‌روزرسانی کنید که با شاردها کار کند، که ممکن است منجر به پرس‌وجوهای SQL پیچیده شود.
* توزیع داده در یک شارد می‌تواند نامتوازن شود. برای مثال، مجموعه‌ای از کاربران پرمصرف روی یک شارد می‌تواند بار آن شارد را نسبت به سایرین افزایش دهد.
    * متعادل‌سازی مجدد پیچیدگی اضافی دارد. تابع شاردینگ مبتنی بر [هشینگ پایدار](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html) می‌تواند مقدار داده انتقال یافته را کاهش دهد.
* اتصال داده از چندین شارد پیچیده‌تر است.
* شاردینگ سخت‌افزار بیشتری و پیچیدگی بیشتری اضافه می‌کند.

##### منابع و مطالعات بیشتر: شاردینگ

* [ظهور شارد](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [معماری پایگاه داده شارد](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [هشینگ پایدار](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### دنرمال‌سازی

دنرمال‌سازی تلاش می‌کند تا عملکرد خواندن را به قیمت کاهش عملکرد نوشتن بهبود دهد. نسخه‌های تکراری از داده‌ها در چندین جدول نوشته می‌شوند تا از پیوندهای پرهزینه جلوگیری شود. برخی RDBMSها مانند [PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL) و Oracle از [نماهای مادی‌شده](https://en.wikipedia.org/wiki/Materialized_view) پشتیبانی می‌کنند که وظیفه ذخیره اطلاعات تکراری و هماهنگ نگه داشتن نسخه‌های تکراری را به عهده دارند.

زمانی که داده‌ها با تکنیک‌هایی مانند [فدراسیون](#federation) و [شاردینگ](#sharding) توزیع می‌شوند، مدیریت پیوندها بین مراکز داده پیچیدگی بیشتری ایجاد می‌کند. دنرمال‌سازی ممکن است نیاز به چنین پیوندهای پیچیده‌ای را برطرف کند.

در اکثر سیستم‌ها، تعداد خواندن‌ها بسیار بیشتر از نوشتن‌هاست؛ نسبت ۱۰۰ به ۱ یا حتی ۱۰۰۰ به ۱. یک خواندن که منجر به پیوند پایگاه داده پیچیده شود می‌تواند بسیار پرهزینه باشد و زمان قابل توجهی صرف عملیات دیسک کند.

##### معایب: دنرمال‌سازی

* داده‌ها تکرار می‌شوند.
* محدودیت‌ها می‌توانند به هماهنگ ماندن نسخه‌های تکراری اطلاعات کمک کنند، که پیچیدگی طراحی پایگاه داده را افزایش می‌دهد.
* پایگاه داده دنرمال‌شده تحت بار سنگین نوشتن ممکن است عملکردی کمتر از نسخه نرمال‌شده خود داشته باشد.

###### منابع و مطالعات بیشتر: دنرمال‌سازی

* [غیراستانداردسازی (Denormalization)](https://fa.wikipedia.org/wiki/غیراستانداردسازی)

#### بهینه‌سازی SQL

بهینه‌سازی SQL یک موضوع گسترده است و بسیاری از [کتاب‌ها](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning) به عنوان مرجع نوشته شده‌اند.

مهم است که **بنچمارک** و **پروفایل** انجام دهید تا نقاط گلوگاه را شبیه‌سازی و کشف کنید.

* **بنچمارک** - شبیه‌سازی موقعیت‌های بارگذاری بالا با ابزارهایی مانند [ab](http://httpd.apache.org/docs/2.2/programs/ab.html).
* **پروفایل** - فعال‌سازی ابزارهایی مانند [لاگ پرس‌وجوی کند](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) برای پیگیری مشکلات عملکرد.

بنچمارک و پروفایل ممکن است شما را به بهینه‌سازی‌های زیر راهنمایی کند.

##### بهبود ساختار پایگاه داده

* MySQL داده‌ها را به صورت بلوک‌های متوالی روی دیسک ذخیره می‌کند تا دسترسی سریع داشته باشید.
* از `CHAR` به جای `VARCHAR` برای فیلدهای با طول ثابت استفاده کنید.
    * `CHAR` اجازه دسترسی تصادفی سریع را می‌دهد، در حالی که در `VARCHAR` باید انتهای رشته را پیدا کنید تا به بعدی بروید.
* از `TEXT` برای بلوک‌های بزرگ متن مانند پست‌های وبلاگ استفاده کنید.  `TEXT` همچنین امکان جستجوی بولی را فراهم می‌کند.  استفاده از فیلد `TEXT` باعث ذخیره‌سازی یک اشاره‌گر روی دیسک می‌شود که برای یافتن بلوک متن استفاده می‌شود.
* از `INT` برای اعداد بزرگ تا ۲^۳۲ یا ۴ میلیارد استفاده کنید.
* برای جلوگیری از خطاهای نمایش اعشاری، از `DECIMAL` برای مقادیر پولی استفاده کنید.
* از ذخیره‌سازی `BLOB`های بزرگ خودداری کنید، و به جای آن محل دریافت شی را ذخیره نمایید.
* `VARCHAR(255)` بیشترین تعداد کاراکتری است که می‌توان با یک عدد ۸ بیتی شمارش کرد و اغلب استفاده بهینه از یک بایت را در برخی RDBMSها فراهم می‌کند.
* محدودیت `NOT NULL` را در صورت امکان تنظیم کنید تا [عملکرد جستجو را بهبود دهید](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search).

##### استفاده از ایندکس‌های مناسب

* ستون‌هایی که پرس‌وجو می‌شوند (`SELECT`, `GROUP BY`, `ORDER BY`, `JOIN`) با ایندکس‌ها سریع‌تر خواهند بود.
* ایندکس‌ها معمولاً به صورت [درخت B خودمتعادل](https://en.wikipedia.org/wiki/B-tree) نمایش داده می‌شوند که داده‌ها را مرتب نگه می‌دارد و امکان جستجو، دسترسی ترتیبی، درج و حذف را در زمان لگاریتمی فراهم می‌کند.
* قرار دادن ایندکس می‌تواند داده‌ها را در حافظه نگه دارد و نیازمند فضای بیشتر باشد.
* نوشتن داده‌ها ممکن است کندتر شود زیرا ایندکس نیز باید به‌روزرسانی شود.
* هنگام بارگذاری حجم زیاد داده، ممکن است سریع‌تر باشد که ایندکس‌ها را غیرفعال کنید، داده‌ها را بارگذاری کنید و سپس ایندکس‌ها را دوباره بسازید.

##### اجتناب از جوین‌های سنگین

* [غیراستانداردسازی](#denormalization) را زمانی که عملکرد ایجاب کند انجام دهید.

##### تقسیم‌بندی جداول

* یک جدول را با قرار دادن نقاط داغ در جدولی جداگانه تقسیم کنید تا به حفظ آن در حافظه کمک کند.

##### تنظیم کش پرس‌وجو

* در برخی موارد، [کش پرس‌وجو](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html) می‌تواند منجر به [مشکلات عملکردی](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/) شود.

##### منبع(ها) و مطالعه بیشتر: تنظیم SQL

* [نکاتی برای بهینه‌سازی پرس‌وجوهای MySQL](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [آیا دلیل خوبی وجود دارد که VARCHAR(255) اینقدر زیاد استفاده می‌شود؟](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [مقدارهای null چگونه بر عملکرد تأثیر می‌گذارند؟](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [گزارش پرس‌وجوی کند](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL مجموعه‌ای از آیتم‌های داده است که در قالب **ذخیره‌سازی کلید-مقدار**، **ذخیره‌سازی سندی**، **ستون گسترده** یا **پایگاه داده گرافی** نمایش داده می‌شوند. داده‌ها غیرنرمال‌سازی شده‌اند و پیوندها معمولاً در کد برنامه انجام می‌شوند. بیشتر پایگاه‌های NoSQL تراکنش‌های واقعی ACID ندارند و به [توافق نهایی](#eventual-consistency) گرایش دارند.

**BASE** اغلب برای توصیف ویژگی‌های پایگاه داده‌های NoSQL استفاده می‌شود. در مقایسه با [قضیه CAP](#cap-theorem)، BASE ترجیح می‌دهد قابلیت دسترسی را بر سازگاری مقدم بدارد.

* **اساساً قابل دسترسی** - سیستم قابلیت دسترسی را تضمین می‌کند.
* **حالت نرم** - وضعیت سیستم ممکن است در طول زمان حتی بدون ورودی تغییر کند.
* **توافق نهایی** - سیستم در طول زمان سازگار خواهد شد، به شرطی که سیستم در آن دوره ورودی دریافت نکند.

علاوه بر انتخاب بین [SQL یا NoSQL](#sql-or-nosql)، درک این که کدام نوع پایگاه داده NoSQL برای کاربرد(های) شما مناسب‌تر است، مفید خواهد بود. در بخش بعدی، **ذخیره‌سازی کلید-مقدار**، **ذخیره‌سازی سندی**، **ستون گسترده** و **پایگاه داده‌های گرافی** را بررسی خواهیم کرد.

#### ذخیره‌سازی کلید-مقدار

> انتزاع: جدول هش

یک ذخیره‌سازی کلید-مقدار معمولاً امکان خواندن و نوشتن O(1) را فراهم می‌کند و اغلب مبتنی بر حافظه یا SSD است. مخازن داده می‌توانند کلیدها را در [ترتیب واژه‌نامه‌ای](https://en.wikipedia.org/wiki/Lexicographical_order) نگه دارند، که بازیابی موثر محدوده کلیدها را ممکن می‌سازد. ذخیره‌سازی کلید-مقدار می‌تواند امکان ذخیره متادیتا همراه با مقدار را فراهم کند.

ذخیره‌سازی کلید-مقدار عملکرد بالایی ارائه می‌دهد و اغلب برای مدل‌های داده ساده یا داده‌هایی که به سرعت تغییر می‌کنند، مانند لایه کش حافظه‌ای استفاده می‌شود. از آنجا که تنها مجموعه محدودی از عملیات را ارائه می‌دهد، پیچیدگی در صورت نیاز به عملیات بیشتر به لایه برنامه منتقل می‌شود.

ذخیره‌سازی کلید-مقدار پایه‌ای برای سیستم‌های پیچیده‌تر مانند ذخیره‌سازی سندی و در برخی موارد پایگاه داده گرافی است.

##### منبع(ها) و مطالعه بیشتر: ذخیره‌سازی کلید-مقدار

* [پایگاه داده کلید-مقدار](https://en.wikipedia.org/wiki/Key-value_database)
* [معایب ذخیره‌سازی کلید-مقدار](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [معماری Redis](http://qnimate.com/overview-of-redis-architecture/)
* [معماری Memcached](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### پایگاه داده اسناد

> انتزاع: ذخیره‌ساز کلید-مقدار با اسناد به عنوان مقدارها

یک پایگاه داده اسنادی حول محور اسناد (XML، JSON، باینری و غیره) شکل گرفته است، جایی که یک سند تمام اطلاعات مربوط به یک شی را ذخیره می‌کند. پایگاه‌های داده اسنادی API یا زبان پرس‌وجو برای جستجو بر اساس ساختار داخلی خود سند ارائه می‌دهند. *توجه داشته باشید، بسیاری از ذخیره‌سازهای کلید-مقدار ویژگی‌هایی برای کار با فراداده مقدار ارائه می‌دهند که مرز بین این دو نوع ذخیره‌سازی را کمرنگ می‌کند.*

بر اساس پیاده‌سازی زیرین، اسناد توسط مجموعه‌ها، برچسب‌ها، فراداده یا دایرکتوری‌ها سازمان‌دهی می‌شوند. اگرچه اسناد می‌توانند سازمان‌دهی یا گروه‌بندی شوند، اما ممکن است فیلدهای اسناد کاملاً با هم متفاوت باشند.

برخی پایگاه‌های داده اسنادی مانند [MongoDB](https://www.mongodb.com/mongodb-architecture) و [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) همچنین زبان مشابه SQL برای انجام پرس‌وجوهای پیچیده ارائه می‌دهند. [DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) از هر دو مدل کلید-مقدار و سند پشتیبانی می‌کند.

پایگاه‌های داده اسنادی انعطاف‌پذیری بالایی ارائه می‌دهند و اغلب برای داده‌هایی با تغییرات گاه‌به‌گاه استفاده می‌شوند.

##### منبع(ها) و مطالعه بیشتر: پایگاه داده اسناد

* [پایگاه داده مبتنی بر سند](https://en.wikipedia.org/wiki/Document-oriented_database)
* [معماری MongoDB](https://www.mongodb.com/mongodb-architecture)
* [معماری CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [معماری Elasticsearch](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### پایگاه داده ستونی گسترده

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>منبع: SQL & NoSQL، تاریخچه‌ای مختصر</a></i>
</p>

> انتزاع: نگاشت تو در تو `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

واحد پایه داده در پایگاه داده ستونی گسترده یک ستون (جفت نام/مقدار) است. یک ستون می‌تواند در خانواده ستون‌ها (مشابه جدول SQL) گروه‌بندی شود. خانواده‌های ستون فوق، خانواده‌های ستون را بیشتر گروه‌بندی می‌کنند. شما می‌توانید هر ستون را با کلید ردیف به طور مستقل دسترسی داشته باشید و ستون‌هایی با کلید ردیف یکسان یک ردیف را تشکیل می‌دهند. هر مقدار شامل یک زمان‌سنج برای نسخه‌بندی و رفع تضاد است.

گوگل [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) را به عنوان اولین پایگاه داده ستونی گسترده معرفی کرد که بر [HBase](https://www.edureka.co/blog/hbase-architecture/) متن‌باز که در اکوسیستم Hadoop استفاده می‌شود و [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html) از فیسبوک تأثیر گذاشت. پایگاه‌هایی مانند BigTable، HBase و Cassandra کلیدها را به صورت واژه‌نامه‌ای مرتب می‌کنند که امکان بازیابی کارآمد بازه‌های انتخابی کلید را فراهم می‌کند.

پایگاه‌های داده ستونی گسترده، دسترسی‌پذیری و مقیاس‌پذیری بالایی ارائه می‌دهند. آن‌ها اغلب برای مجموعه داده‌های بسیار بزرگ استفاده می‌شوند.

##### منبع(ها) و مطالعه بیشتر: پایگاه داده ستونی گسترده

* [SQL & NoSQL، تاریخچه‌ای مختصر](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [معماری بیگ‌تیبل](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [معماری HBase](https://www.edureka.co/blog/hbase-architecture/)
* [معماری کاساندرا](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### پایگاه داده گراف

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>منبع: پایگاه داده گراف</a></i>
</p>

> انتزاع: گراف

در پایگاه داده گراف، هر گره یک رکورد است و هر یال یک رابطه بین دو گره می‌باشد. پایگاه‌های داده گراف برای نمایش روابط پیچیده با کلیدهای خارجی متعدد یا روابط چند به چند بهینه شده‌اند.

پایگاه‌های داده گراف عملکرد بالایی برای مدل‌های داده با روابط پیچیده، مانند شبکه‌های اجتماعی، ارائه می‌دهند. این نوع پایگاه داده نسبتاً جدید بوده و هنوز فراگیر نشده‌اند؛ ممکن است یافتن ابزارهای توسعه و منابع دشوارتر باشد. بسیاری از گراف‌ها فقط با [REST APIها](#representational-state-transfer-rest) قابل دسترسی هستند.

##### منبع(ها) و مطالعات بیشتر: گراف

* [پایگاه داده گراف](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### منبع(ها) و مطالعات بیشتر: NoSQL

* [توضیح اصطلاحات پایه](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [پایگاه‌های داده NoSQL: یک بررسی و راهنمای تصمیم‌گیری](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [مقیاس‌پذیری](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [معرفی NoSQL](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [الگوهای NoSQL](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL یا NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>منبع: گذر از RDBMS به NoSQL</a></i>
</p>

دلایل استفاده از **SQL**:

* داده‌های ساخت‌یافته
* طرحواره‌ی سخت‌گیرانه
* داده‌های رابطه‌ای
* نیاز به پیوندهای پیچیده
* تراکنش‌ها
* الگوهای مشخص برای مقیاس‌پذیری
* بیشتر تثبیت شده: توسعه‌دهندگان، جامعه، کد، ابزارها و غیره
* جستجوهای مبتنی بر ایندکس بسیار سریع هستند

دلایل استفاده از **NoSQL**:

* داده‌های نیمه‌ساخت‌یافته
* طرحواره‌ی پویا یا انعطاف‌پذیر
* داده‌های غیر رابطه‌ای
* عدم نیاز به پیوندهای پیچیده
* ذخیره حجم بالای داده (چندین ترابایت یا پتابایت)
* حجم کاری بسیار سنگین داده
* کارایی بسیار بالا برای عملیات ورودی/خروجی

نمونه داده‌هایی که برای NoSQL مناسب هستند:

* دریافت سریع داده‌های کلیک‌استریم و لاگ
* داده‌های جدول امتیازات یا رتبه‌بندی
* داده‌های موقت مانند سبد خرید
* جداولی که اغلب مورد دسترسی قرار می‌گیرند (جداول ‘داغ’)
* جداول متادیتا/جستجو

##### منبع(ها) و مطالعه بیشتر: SQL یا NoSQL

* [مقیاس‌پذیری تا اولین ۱۰ میلیون کاربر](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [تفاوت‌های SQL و NoSQL](https://www.sitepoint.com/sql-vs-nosql-differences/)

## کش

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>منبع: الگوهای طراحی سیستم مقیاس‌پذیر</a></i>
</p>

کشینگ باعث بهبود زمان بارگذاری صفحات شده و می‌تواند بار روی سرورها و پایگاه‌های داده شما را کاهش دهد. در این مدل، دیسپچر ابتدا بررسی می‌کند که آیا درخواست قبلاً انجام شده است یا خیر و سعی می‌کند نتیجه قبلی را پیدا کرده و بازگرداند تا از اجرای واقعی صرفه‌جویی شود.

پایگاه‌های داده معمولاً از توزیع یکنواخت خواندن و نوشتن در سراسر پارتیشن‌های خود سود می‌برند. اقلام محبوب می‌توانند این توزیع را به‌هم زده و باعث ایجاد گلوگاه شوند. قرار دادن کش جلوی پایگاه داده می‌تواند بارهای نامتعادل و جهش‌های ترافیک را جذب کند.

### کشینگ سمت کلاینت

کش‌ها می‌توانند در سمت کلاینت (سیستم‌عامل یا مرورگر)، [سمت سرور](#reverse-proxy-web-server)، یا در یک لایه کش مجزا قرار گیرند.

### کشینگ CDN

[CDNها](#content-delivery-network) نوعی کش محسوب می‌شوند.

### کشینگ وب‌سرور

[پراکسی‌های معکوس](#reverse-proxy-web-server) و کش‌هایی مانند [Varnish](https://www.varnish-cache.org/) می‌توانند محتوای ایستا و پویا را مستقیماً ارائه دهند. وب‌سرورها همچنین می‌توانند درخواست‌ها را کش کنند و پاسخ‌ها را بدون نیاز به تماس با سرورهای اپلیکیشن بازگردانند.

### کشینگ پایگاه داده

پایگاه داده شما معمولاً در پیکربندی پیش‌فرض خود سطحی از کشینگ دارد که برای یک مورد استفاده عمومی بهینه شده است. تنظیم این تنظیمات برای الگوهای استفاده خاص می‌تواند عملکرد را بیشتر افزایش دهد.

### کشینگ اپلیکیشن

کش‌های درون حافظه مانند Memcached و Redis فروشگاه‌های کلیدی-مقداری بین اپلیکیشن و ذخیره‌سازی داده‌های شما هستند. از آنجا که داده‌ها در RAM نگهداری می‌شوند، بسیار سریع‌تر از پایگاه‌های داده معمولی هستند که داده‌ها را روی دیسک ذخیره می‌کنند. RAM محدودتر از دیسک است، بنابراین الگوریتم‌های [ابطال کش](https://en.wikipedia.org/wiki/Cache_algorithms) مانند [کمترین استفاده شده اخیر (LRU)](https://en.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU)) می‌توانند به ابطال داده‌های سرد و نگه داشتن داده‌های داغ در RAM کمک کنند.

Redis ویژگی‌های اضافی زیر را دارد:

* گزینه پایداری
* ساختارهای داده داخلی مانند مجموعه‌های مرتب شده و لیست‌ها

سطوح مختلفی وجود دارد که می‌توانید کش کنید که در دو دسته کلی قرار می‌گیرند: **پرس‌وجوهای پایگاه داده** و **اشیاء**:

* سطح سطر
* سطح پرس‌وجو
* اشیاء سریالایز شده کاملاً تشکیل شده
* HTML کاملاً رندر شده

به طور کلی، بهتر است از کشینگ مبتنی بر فایل اجتناب کنید، زیرا کلون کردن و مقیاس‌پذیری خودکار را دشوار می‌کند.

### کش کردن در سطح پرس‌وجوی پایگاه داده

هر زمان که پایگاه داده را پرس‌وجو می‌کنید، پرس‌وجو را به‌عنوان یک کلید هش کرده و نتیجه را در کش ذخیره کنید. این رویکرد با مشکلات انقضا روبرو است:

* حذف نتیجه کش شده با پرس‌وجوهای پیچیده دشوار است
* اگر یک بخش از داده مانند یک سلول جدول تغییر کند، باید تمام پرس‌وجوهای کش شده‌ای که ممکن است سلول تغییر یافته را شامل شوند حذف کنید

### کش کردن در سطح شیء

داده‌های خود را به‌عنوان یک شیء ببینید، مشابه کاری که با کد برنامه انجام می‌دهید. برنامه شما مجموعه داده را از پایگاه داده گرفته و به یک نمونه کلاس یا ساختار داده‌ای تبدیل می‌کند:

* اگر داده زیرین شیء تغییر کند، شیء را از کش حذف کنید
* امکان پردازش غیرهمزمان را فراهم می‌کند: کارگرها با مصرف آخرین شیء کش شده، اشیا را می‌سازند

پیشنهادهایی برای کش کردن:

* نشست‌های کاربری
* صفحات وب کاملاً رندر شده
* جریان‌های فعالیت
* داده‌های گراف کاربر

### زمان به‌روزرسانی کش

از آنجا که می‌توانید تنها مقدار محدودی داده را در کش ذخیره کنید، باید تعیین کنید کدام استراتژی به‌روزرسانی کش برای مورد استفاده شما مناسب‌تر است.

#### کش-کناری

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>منبع: از کش تا شبکه داده در حافظه</a></i>
</p>

برنامه مسئول خواندن و نوشتن از حافظه است. کش مستقیماً با حافظه تعامل ندارد. برنامه اقدامات زیر را انجام می‌دهد:

* جستجوی ورودی در کش، در نتیجه خطای کش (cache miss)
* بارگذاری ورودی از پایگاه داده
* افزودن ورودی به کش
* بازگرداندن ورودی

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```

[Memcached](https://memcached.org/) معمولاً به این صورت استفاده می‌شود.

خواندن‌های بعدی داده‌ای که به کش افزوده شده‌اند سریع هستند. کش-کناری همچنین به عنوان بارگذاری تنبل شناخته می‌شود. فقط داده‌های درخواست‌شده کش می‌شوند که از پر شدن کش با داده‌هایی که درخواست نشده‌اند جلوگیری می‌کند.

##### معایب: کش-کناری

* هر بار از دست دادن کش منجر به سه رفت‌وآمد می‌شود که می‌تواند باعث تأخیر قابل توجهی شود.
* داده‌ها ممکن است اگر در پایگاه داده به‌روزرسانی شوند، قدیمی شوند. این مشکل با تعیین مدت زمان اعتبار (TTL) که به‌روزرسانی ورودی کش را اجبار می‌کند، یا با استفاده از نوشتن-همزمان کاهش می‌یابد.
* وقتی یک نود از کار می‌افتد، با یک نود جدید و خالی جایگزین می‌شود که تأخیر را افزایش می‌دهد.

#### نوشتن-همزمان

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>منبع: الگوهای مقیاس‌پذیری، دسترسی‌پذیری، پایداری</a></i>
</p>

برنامه از کش به عنوان منبع اصلی داده استفاده می‌کند و داده‌ها را خوانده و می‌نویسد، در حالی که کش مسئول خواندن و نوشتن در پایگاه داده است:

* برنامه ورودی را در کش اضافه/به‌روزرسانی می‌کند
* کش به طور همزمان ورودی را در منبع داده می‌نویسد
* بازگشت

کد برنامه:

```python
set_user(12345, {"foo":"bar"})
```

کد کش:

```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```
نوشتن-همزمان (Write-through) یک عملیات کلی کند است به دلیل عملیات نوشتن، اما خواندن‌های بعدی داده‌هایی که تازه نوشته شده‌اند سریع هستند. کاربران معمولاً تحمل بیشتری نسبت به تأخیر هنگام به‌روزرسانی داده‌ها نسبت به خواندن داده‌ها دارند. داده‌های موجود در کش، قدیمی نیستند.

##### معایب: نوشتن-همزمان

* زمانی که یک نود جدید به دلیل خرابی یا مقیاس‌بندی ایجاد می‌شود، نود جدید تا زمانی که ورودی در پایگاه داده به‌روزرسانی نشود، ورودی‌ها را کش نمی‌کند. استفاده همزمان از Cache-aside با نوشتن-همزمان می‌تواند این مشکل را کاهش دهد.
* بیشتر داده‌هایی که نوشته می‌شوند ممکن است هرگز خوانده نشوند، که می‌توان این مورد را با تعیین TTL کاهش داد.

#### نوشتن-پس‌زمینه (write-behind/write-back)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>منبع: الگوهای مقیاس‌پذیری، دسترسی‌پذیری، پایداری</a></i>
</p>

در نوشتن-پس‌زمینه، برنامه کاربردی اقدامات زیر را انجام می‌دهد:

* افزودن/به‌روزرسانی ورودی در کش
* نوشتن غیرهمزمان ورودی در مخزن داده، که باعث بهبود عملکرد نوشتن می‌شود

##### معایب: نوشتن-پس‌زمینه

* ممکن است از دست رفتن داده رخ دهد اگر کش قبل از رسیدن محتوای آن به مخزن داده از کار بیفتد.
* پیاده‌سازی نوشتن-پس‌زمینه پیچیده‌تر از پیاده‌سازی cache-aside یا نوشتن-همزمان است.

#### تازه‌سازی-پیشاپیش (Refresh-ahead)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>منبع: از کش تا شبکه داده درون‌حافظه‌ای</a></i>
</p>

می‌توانید کش را طوری پیکربندی کنید که هر ورودی کشی که اخیراً مورد دسترسی قرار گرفته است را قبل از انقضایش به طور خودکار تازه‌سازی کند.

تازه‌سازی-پیشاپیش می‌تواند منجر به کاهش تأخیر نسبت به خواندن-همزمان شود اگر کش بتواند به درستی پیش‌بینی کند کدام آیتم‌ها احتمالاً در آینده مورد نیاز خواهند بود.

##### معایب: تازه‌سازی-پیشاپیش


* پیش‌بینی نادرست اینکه کدام آیتم‌ها احتمالاً در آینده مورد نیاز خواهند بود می‌تواند منجر به عملکرد پایین‌تر نسبت به حالت بدون refresh-ahead شود.

### معایب: کش

* نیاز به حفظ سازگاری بین کش‌ها و منبع حقیقت مانند پایگاه داده از طریق [باطل‌سازی کش](https://en.wikipedia.org/wiki/Cache_algorithms).
* باطل‌سازی کش یک مشکل دشوار است، پیچیدگی بیشتری در ارتباط با زمان به‌روزرسانی کش وجود دارد.
* نیاز به ایجاد تغییرات در برنامه مانند افزودن Redis یا memcached.

### منابع و مطالعه بیشتر

* [از کش تا شبکه داده درون‌حافظه‌ای](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [الگوهای طراحی سیستم مقیاس‌پذیر](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [مقدمه‌ای بر معماری سیستم‌ها برای مقیاس](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [مقیاس‌پذیری، دسترسی‌پذیری، پایداری، الگوها](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [مقیاس‌پذیری](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [استراتژی‌های AWS ElastiCache](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [ویکی‌پدیا](https://en.wikipedia.org/wiki/Cache_(computing))

## غیرهمزمانی

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>منبع: مقدمه‌ای بر معماری سیستم‌ها برای مقیاس</a></i>
</p>

گردش‌کارهای غیرهمزمان به کاهش زمان درخواست برای عملیات‌های پرهزینه که در غیر این صورت به صورت درون‌خطی انجام می‌شوند کمک می‌کنند. همچنین می‌توانند با انجام کارهای زمان‌بر از پیش، مانند تجمیع دوره‌ای داده‌ها، مفید باشند.

### صف‌های پیام

صف‌های پیام، پیام‌ها را دریافت، نگهداری و تحویل می‌دهند. اگر یک عملیات برای انجام درون‌خطی خیلی کند است، می‌توانید از صف پیام با گردش کار زیر استفاده کنید:

* یک برنامه شغلی را در صف منتشر می‌کند، سپس وضعیت شغل را به کاربر اطلاع می‌دهد
* یک کارگر شغل را از صف دریافت کرده، پردازش می‌کند و سپس سیگنال تکمیل شغل را ارسال می‌کند

کاربر مسدود نمی‌شود و شغل در پس‌زمینه پردازش می‌شود. در این مدت، کلاینت ممکن است به طور اختیاری مقدار کمی پردازش انجام دهد تا به نظر برسد کار تکمیل شده است. برای مثال، اگر یک توییت ارسال شود، توییت می‌تواند فوراً در تایم‌لاین شما قرار گیرد اما ممکن است مدتی طول بکشد تا توییت شما واقعاً به همه دنبال‌کنندگان شما ارسال شود.

**[Redis](https://redis.io/)** به عنوان یک پیام‌رسان ساده مفید است اما پیام‌ها ممکن است از دست بروند.

**[RabbitMQ](https://www.rabbitmq.com/)** محبوب است اما نیاز دارد که با پروتکل 'AMQP' سازگار شوید و گره‌های خودتان را مدیریت کنید.
**[Amazon SQS](https://aws.amazon.com/sqs/)** میزبانی شده است اما ممکن است تاخیر بالایی داشته باشد و امکان تحویل دوباره پیام‌ها وجود دارد.

### صف‌های وظیفه

صف‌های وظیفه وظایف و داده‌های مرتبط با آن‌ها را دریافت می‌کنند، آن‌ها را اجرا می‌کنند و سپس نتایج را تحویل می‌دهند. این صف‌ها قابلیت زمان‌بندی دارند و می‌توانند برای اجرای کارهای محاسباتی سنگین در پس‌زمینه استفاده شوند.

**[Celery](https://docs.celeryproject.org/en/stable/)** از زمان‌بندی پشتیبانی می‌کند و عمدتاً برای پایتون مناسب است.

### فشار معکوس (Back pressure)

اگر صف‌ها به طور قابل توجهی رشد کنند، اندازه صف می‌تواند از حافظه بزرگ‌تر شود که منجر به خطاهای کش، خواندن دیسک و عملکرد کندتر می‌شود. [فشار معکوس](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) می‌تواند با محدود کردن اندازه صف کمک کند، و با این کار نرخ گذردهی بالا و زمان پاسخ مناسب برای کارهای موجود در صف حفظ می‌شود. وقتی صف پر شود، کلاینت‌ها وضعیت سرور مشغول یا کد وضعیت HTTP 503 دریافت می‌کنند تا بعداً دوباره تلاش کنند. کلاینت‌ها می‌توانند درخواست را در زمان دیگری دوباره ارسال کنند، شاید با [بازگشت نمایی](https://en.wikipedia.org/wiki/Exponential_backoff).

### معایب: غیرهمزمانی

* موارد استفاده‌ای مانند محاسبات کم‌هزینه و جریان‌های کاری بلادرنگ ممکن است برای عملیات همزمان مناسب‌تر باشند، زیرا افزودن صف‌ها می‌تواند تاخیر و پیچیدگی ایجاد کند.

### منابع و مطالعات بیشتر

* [همه چیز یک بازی اعداد است](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [اعمال فشار معکوس هنگام بار زیاد](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [قانون لیتل](https://en.wikipedia.org/wiki/Little%27s_law)
* [تفاوت صف پیام و صف وظیفه چیست؟](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## ارتباط

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>منبع: مدل ۷ لایه OSI</a></i>
</p>

### پروتکل انتقال ابرمتن (HTTP)

HTTP روشی برای کدگذاری و انتقال داده بین کلاینت و سرور است. این یک پروتکل درخواست/پاسخ است: کلاینت‌ها درخواست ارسال می‌کنند و سرورها پاسخ‌هایی با محتوای مرتبط و اطلاعات وضعیت تکمیل درخواست صادر می‌کنند. HTTP مستقل از محیط است و به درخواست‌ها و پاسخ‌ها اجازه می‌دهد از مسیرهای مختلف، روترها و سرورهای واسط که عمل بارگذاری، کش، رمزنگاری و فشرده‌سازی انجام می‌دهند، عبور کنند.

یک درخواست HTTP پایه شامل یک فعل (method) و یک منبع (endpoint) است. در زیر افعال رایج HTTP آورده شده است:

| فعل | توضیحات | ایندموتنت* | امن | قابل کش شدن |


| GET | خواندن یک منبع | بله | بله | بله |
| POST | ایجاد یک منبع یا راه‌اندازی فرایندی که داده‌ها را پردازش می‌کند | خیر | خیر | بله اگر پاسخ شامل اطلاعات تازگی باشد |
| PUT | ایجاد یا جایگزینی یک منبع | بله | خیر | خیر |
| PATCH | به‌روزرسانی جزئی یک منبع | خیر | خیر | بله اگر پاسخ شامل اطلاعات تازگی باشد |
| DELETE | حذف یک منبع | بله | خیر | خیر |

*می‌تواند چندین بار فراخوانی شود بدون نتایج متفاوت.*

HTTP یک پروتکل لایه کاربردی است که بر پروتکل‌های سطح پایین‌تر مانند **TCP** و **UDP** تکیه دارد.

#### منبع(ها) و مطالعه بیشتر: HTTP

* [HTTP چیست؟](https://www.nginx.com/resources/glossary/http/)
* [تفاوت بین HTTP و TCP](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [تفاوت بین PUT و PATCH](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### پروتکل کنترل انتقال (TCP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>منبع: چگونه یک بازی چند نفره بسازیم</a></i>
</p>

TCP یک پروتکل مبتنی بر اتصال روی یک [شبکه IP](https://en.wikipedia.org/wiki/Internet_Protocol) است. اتصال با استفاده از [دست‌دهی](https://en.wikipedia.org/wiki/Handshaking) برقرار و قطع می‌شود. تمام بسته‌هایی که ارسال می‌شوند تضمین می‌شود که به مقصد برسند، به همان ترتیب اصلی و بدون خرابی از طریق:

* شماره‌های ترتیبی و [فیلدهای بررسی مجموع](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation) برای هر بسته
* بسته‌های [تأیید دریافت](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) و ارسال مجدد خودکار

اگر فرستنده پاسخ صحیحی دریافت نکند، بسته‌ها را دوباره ارسال می‌کند. اگر چندین بار زمان‌بندی‌ها منقضی شود، اتصال قطع می‌شود. TCP همچنین [کنترل جریان](https://en.wikipedia.org/wiki/Flow_control_(data)) و [کنترل تراکم](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control) را اجرا می‌کند. این تضمین‌ها باعث تأخیر و معمولاً انتقال کمتر کارآمد نسبت به UDP می‌شوند.

برای تضمین سرعت انتقال بالا، سرورهای وب می‌توانند تعداد زیادی اتصال TCP باز نگه دارند که منجر به مصرف حافظه زیاد می‌شود. داشتن تعداد زیادی اتصال باز بین رشته‌های سرور وب و مثلاً یک سرور [memcached](https://memcached.org/) می‌تواند پرهزینه باشد. [تجمیع اتصال](https://en.wikipedia.org/wiki/Connection_pool) می‌تواند کمک کند، علاوه بر اینکه در موارد مناسب به UDP سوئیچ شود.

TCP برای برنامه‌هایی که به قابلیت اطمینان بالا نیاز دارند اما حساسیت زمانی کمتری دارند مفید است. برخی مثال‌ها شامل سرورهای وب، اطلاعات پایگاه داده، SMTP، FTP و SSH هستند.

TCP را به جای UDP استفاده کنید زمانی که:

* نیاز دارید تمام داده‌ها به‌طور کامل و سالم برسند
* می‌خواهید به طور خودکار بهترین تخمین از بهره‌برداری شبکه را داشته باشید

### پروتکل دیتاگرام کاربر (UDP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>منبع: چگونه یک بازی چندنفره بسازیم</a></i>
</p>

UDP بدون اتصال است. دیتاگرام‌ها (مشابه بسته‌ها) فقط در سطح دیتاگرام تضمین شده‌اند. دیتاگرام‌ها ممکن است خارج از ترتیب به مقصد برسند یا اصلاً نرسند. UDP کنترل تراکم را پشتیبانی نمی‌کند. بدون تضمین‌هایی که TCP ارائه می‌دهد، UDP معمولاً کارآمدتر است.

UDP می‌تواند پخش کند، دیتاگرام‌ها را به همه دستگاه‌های زیرشبکه ارسال کند. این امر با [DHCP](https://en.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol) مفید است زیرا کلاینت هنوز آدرس IP دریافت نکرده است و بنابراین راهی برای TCP جهت ارسال جریان بدون آدرس IP وجود ندارد.

UDP کمتر قابل اعتماد است اما در کاربردهای بلادرنگ مانند VoIP، چت ویدیویی، استریم و بازی‌های چندنفره بلادرنگ خوب عمل می‌کند.

زمانی از UDP به جای TCP استفاده کنید که:

* به کمترین تأخیر نیاز دارید
* داده دیرتر بدتر از از دست رفتن داده است
* می‌خواهید تصحیح خطا را خودتان پیاده‌سازی کنید

#### منبع(ها) و مطالعه بیشتر: TCP و UDP

* [شبکه برای برنامه‌نویسی بازی](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [تفاوت‌های کلیدی بین پروتکل‌های TCP و UDP](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [تفاوت بین TCP و UDP](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [پروتکل کنترل انتقال](https://en.wikipedia.org/wiki/Transmission_Control_Protocol)
* [پروتکل دیتاگرام کاربر](https://en.wikipedia.org/wiki/User_Datagram_Protocol)
* [مقیاس‌بندی مم‌کش در فیسبوک](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### فراخوانی رویه از راه دور (RPC)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>منبع: مصاحبه طراحی سیستم را حل کنید</a></i>
</p>

در RPC، یک کلاینت باعث اجرای یک رویه در فضای آدرس متفاوت، معمولاً یک سرور راه دور، می‌شود. این رویه به گونه‌ای کدنویسی شده است که گویی یک فراخوانی رویه محلی است و جزئیات نحوه ارتباط با سرور را از برنامه کلاینت انتزاع می‌کند. فراخوانی‌های راه دور معمولاً کندتر و کمتر قابل اعتمادتر از فراخوانی‌های محلی هستند، بنابراین تشخیص فراخوانی‌های RPC از فراخوانی‌های محلی مفید است. چارچوب‌های RPC محبوب شامل [Protobuf](https://developers.google.com/protocol-buffers/)، [Thrift](https://thrift.apache.org/) و [Avro](https://avro.apache.org/docs/current/) هستند.

RPC یک پروتکل درخواست-پاسخ است:

* **برنامه کلاینت** - رویه استاب کلاینت را فراخوانی می‌کند. پارامترها مانند فراخوانی یک رویه محلی روی پشته قرار می‌گیرند.
* **رویه استاب کلاینت** - شناسه رویه و آرگومان‌ها را در یک پیام درخواست بسته‌بندی (مارشال) می‌کند.
* **ماژول ارتباطی کلاینت** - سیستم‌عامل پیام را از کلاینت به سرور ارسال می‌کند.
* **ماژول ارتباطی سرور** - سیستم‌عامل بسته‌های دریافتی را به رویه استاب سرور انتقال می‌دهد.
* **رویه استاب سرور** - نتایج را بازبسته‌بندی (آنمارشال) کرده، رویه سرور مطابق با شناسه رویه را فراخوانی می‌کند و آرگومان‌های داده شده را ارسال می‌کند.
* پاسخ سرور مراحل بالا را به صورت معکوس تکرار می‌کند.

نمونه فراخوانی‌های RPC:

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```
RPC بر روی نمایش رفتارها متمرکز است. RPCها اغلب به دلایل عملکردی در ارتباطات داخلی استفاده می‌شوند، زیرا می‌توانید فراخوانی‌های بومی را متناسب با نیازهای خود سفارشی کنید.

یک کتابخانه بومی (یا SDK) را زمانی انتخاب کنید که:

* پلتفرم هدف خود را می‌دانید.
* می‌خواهید کنترل کنید که "منطق" شما چگونه در دسترس قرار می‌گیرد.
* می‌خواهید کنترل کنید که کنترل خطاها چگونه خارج از کتابخانه شما انجام شود.
* عملکرد و تجربه کاربری نهایی دغدغه اصلی شماست.

HTTP APIهایی که از **REST** پیروی می‌کنند معمولاً بیشتر برای APIهای عمومی استفاده می‌شوند.

#### معایب: RPC

* کلاینت‌های RPC به شدت به پیاده‌سازی سرویس وابسته می‌شوند.
* برای هر عملیات یا مورد استفاده جدید باید یک API جدید تعریف شود.
* دیباگ کردن RPC می‌تواند دشوار باشد.
* ممکن است نتوانید به راحتی از فناوری‌های موجود استفاده کنید؛ به عنوان مثال، ممکن است نیاز به تلاش اضافی برای اطمینان از اینکه [فراخوانی‌های RPC به درستی کش شوند](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/) بر روی سرورهای کش مانند [Squid](http://www.squid-cache.org/) باشد.

### انتقال وضعیت نمایشی (REST)

REST یک سبک معماری است که مدل کلاینت/سرور را تحمیل می‌کند، جایی که کلاینت بر روی مجموعه‌ای از منابع که توسط سرور مدیریت می‌شوند عمل می‌کند. سرور نمایش‌هایی از منابع و اقداماتی را فراهم می‌کند که می‌توانند منابع را تغییر دهند یا نمای جدیدی از منابع به دست آورند. تمام ارتباطات باید بدون حالت و قابل کش شدن باشند.

چهار ویژگی برای یک رابط RESTful وجود دارد:

* **شناسایی منابع (URI در HTTP)** - صرف‌نظر از عملیات، از همان URI استفاده کنید.
* **تغییر با نمایش‌ها (افعال در HTTP)** - از افعال، هدرها و بدنه استفاده کنید.
* **پیام خطای خودتوصیف (پاسخ وضعیت در HTTP)** - از کدهای وضعیت استفاده کنید، دوباره چرخ را اختراع نکنید.
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/) (رابط HTML برای HTTP)** - سرویس وب شما باید به طور کامل در مرورگر قابل دسترسی باشد.

نمونه فراخوانی‌های REST:


```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```
REST بر روی ارائه داده‌ها تمرکز دارد. این معماری، کمترین میزان وابستگی را بین کلاینت و سرور ایجاد می‌کند و اغلب برای APIهای عمومی HTTP استفاده می‌شود. REST از روش‌های عمومی و یکپارچه‌تری برای ارائه منابع از طریق URIها، [نمایش از طریق هدرها](https://github.com/for-GET/know-your-http-well/blob/master/headers.md)، و اعمال عملیات از طریق افعالی مانند GET، POST، PUT، DELETE و PATCH بهره می‌برد. با توجه به بی‌حالت بودن، REST برای مقیاس‌پذیری افقی و تقسیم‌بندی عالی است.

#### معایب: REST

* با توجه به اینکه REST بر ارائه داده‌ها متمرکز است، ممکن است اگر منابع به صورت طبیعی در یک سلسله‌مراتب ساده سازمان‌دهی یا قابل دسترسی نباشند، گزینه‌ی مناسبی نباشد. برای مثال، بازگرداندن تمام رکوردهای به‌روزرسانی‌شده در یک ساعت گذشته که مطابق با مجموعه‌ای از رویدادهای خاص هستند، به راحتی به عنوان یک مسیر قابل بیان نیست. در REST معمولاً این کار با ترکیبی از مسیر URI، پارامترهای کوئری، و احتمالاً بدنه درخواست انجام می‌شود.
* REST معمولاً بر تعداد کمی فعل (GET، POST، PUT، DELETE و PATCH) تکیه دارد که گاهی اوقات با نیاز شما همخوانی ندارد. به عنوان مثال، انتقال اسناد منقضی شده به پوشه آرشیو ممکن است به شکل مناسبی در این افعال قرار نگیرد.
* دریافت منابع پیچیده با سلسله‌مراتب تو در تو، نیازمند چندین رفت و برگشت بین کلاینت و سرور برای ارائه یک نما است، مثلاً دریافت محتوای یک مطلب وبلاگ و نظرات آن مطلب. برای اپلیکیشن‌های موبایل در شرایط متغیر شبکه، این رفت و برگشت‌ها بسیار نامطلوب هستند.
* با گذشت زمان، ممکن است فیلدهای بیشتری به پاسخ API افزوده شوند و کلاینت‌های قدیمی تمام داده‌های جدید را دریافت کنند، حتی آن‌هایی که به آن‌ها نیاز ندارند، که نتیجه آن افزایش حجم payload و تاخیر بیشتر است.

### مقایسه فراخوانی‌های RPC و REST

| عملیات | RPC | REST |
|---|---|---|
| ثبت‌نام    | **POST** /signup | **POST** /persons |
| استعفا    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| خواندن یک فرد | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| خواندن لیست آیتم‌های یک فرد | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| افزودن آیتم به لیست آیتم‌های یک فرد | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| به‌روزرسانی یک آیتم    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| حذف یک آیتم | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>منبع: آیا واقعاً می‌دانید چرا REST را به RPC ترجیح می‌دهید؟</a></i>
</p>

#### منابع و مطالعه بیشتر: REST و RPC

* [آیا واقعاً می‌دانید چرا REST را به RPC ترجیح می‌دهید؟](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [چه زمانی رویکردهای شبیه به RPC مناسب‌تر از REST هستند؟](http://programmers.stackexchange.com/a/181186)
* [REST در مقابل JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [افسانه‌زدایی از RPC و REST](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [معایب استفاده از REST](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [مصاحبه طراحی سیستم را ترک کنید](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [چرا REST برای استفاده داخلی و نه RPC](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## امنیت

این بخش نیاز به بروزرسانی دارد. برای [مشارکت](#contributing) اقدام کنید!

امنیت موضوعی گسترده است. مگر اینکه تجربه قابل توجهی داشته باشید، سابقه‌ای در زمینه امنیت داشته باشید، یا برای موقعیتی درخواست دهید که نیاز به دانش امنیتی دارد، احتمالاً بیش از اصول اولیه نیازی به دانستن ندارید:

* رمزنگاری داده‌ها در حالت انتقال و ذخیره‌شده.
* پاک‌سازی تمام ورودی‌های کاربر یا هر پارامتر ورودی که در معرض کاربر قرار می‌گیرد برای جلوگیری از [XSS](https://en.wikipedia.org/wiki/Cross-site_scripting) و [تزریق SQL](https://en.wikipedia.org/wiki/SQL_injection).
* استفاده از پرس‌وجوهای پارامتری برای جلوگیری از تزریق SQL.
* استفاده از اصل [کمترین سطح دسترسی](https://en.wikipedia.org/wiki/Principle_of_least_privilege).

### منبع(ها) و مطالعه بیشتر

* [چک‌لیست امنیت API](https://github.com/shieldfy/API-Security-Checklist)
* [راهنمای امنیت برای توسعه‌دهندگان](https://github.com/FallibleInc/security-guide-for-developers)
* [ده مورد برتر OWASP](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## ضمیمه

گاهی اوقات از شما خواسته می‌شود که تخمین‌های سرانگشتی انجام دهید. برای مثال، ممکن است لازم باشد تعیین کنید تولید ۱۰۰ تصویر بندانگشتی از دیسک چقدر زمان می‌برد یا یک ساختار داده چه مقدار حافظه نیاز دارد. **جدول توان‌های دو** و **اعداد تأخیر که هر برنامه‌نویسی باید بداند** منابع مفیدی هستند.

### جدول توان‌های دو


```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### منبع(ها) و مطالعه بیشتر

* [توان‌های دو](https://en.wikipedia.org/wiki/Power_of_two)

### اعداد تأخیر که هر برنامه‌نویسی باید بداند

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```
اعداد مفید بر اساس ارقام بالا:

* خواندن ترتیبی از HDD با سرعت ۳۰ مگابایت بر ثانیه
* خواندن ترتیبی از اترنت ۱ گیگابیت بر ثانیه با سرعت ۱۰۰ مگابایت بر ثانیه
* خواندن ترتیبی از SSD با سرعت ۱ گیگابایت بر ثانیه
* خواندن ترتیبی از حافظه اصلی با سرعت ۴ گیگابایت بر ثانیه
* ۶-۷ رفت و برگشت جهانی در هر ثانیه
* ۲,۰۰۰ رفت و برگشت در هر ثانیه درون یک دیتاسنتر

#### اعداد تأخیر به صورت تصویری

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### منبع(ها) و مطالعه بیشتر

* [اعداد تأخیر که هر برنامه‌نویس باید بداند - ۱](https://gist.github.com/jboner/2841832)
* [اعداد تأخیر که هر برنامه‌نویس باید بداند - ۲](https://gist.github.com/hellerbarde/2843375)
* [طراحی‌ها، درس‌ها و توصیه‌ها از ساخت سیستم‌های توزیع‌شده بزرگ](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [توصیه‌های مهندسی نرم‌افزار از ساخت سیستم‌های توزیع‌شده در مقیاس بزرگ](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### پرسش‌های تکمیلی مصاحبه طراحی سیستم

> پرسش‌های رایج مصاحبه طراحی سیستم، همراه با لینک‌هایی برای منابع حل هر یک.

| پرسش | مرجع(ها) |
|---|---|
| طراحی سرویس همگام‌سازی فایل مانند Dropbox | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| طراحی موتور جستجو مانند گوگل | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| طراحی خزنده وب مقیاس‌پذیر مانند گوگل | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| طراحی Google docs | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| طراحی فروشگاه کلید-مقدار مانند Redis | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| طراحی سیستم کش مانند Memcached | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| طراحی سیستم توصیه‌گر مانند آمازون | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| طراحی سیستم tinyurl مانند Bitly | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| طراحی اپلیکیشن چت مانند WhatsApp | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| طراحی سیستم اشتراک‌گذاری عکس مانند Instagram | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| طراحی تابع خبرخوان فیسبوک | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| طراحی تابع timeline فیسبوک | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| طراحی تابع چت فیسبوک | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |

| یک تابع جستجوی گراف مانند فیس‌بوک طراحی کنید | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| یک شبکه تحویل محتوا مانند CloudFlare طراحی کنید | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| یک سیستم موضوعات ترند مانند توییتر طراحی کنید | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| یک سیستم تولید شناسه تصادفی طراحی کنید | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| درخواست‌های برتر k را در یک بازه زمانی بازگردانید | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| یک سیستم که داده‌ها را از چندین مرکز داده ارائه می‌دهد طراحی کنید | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| یک بازی کارت چندنفره آنلاین طراحی کنید | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| یک سیستم جمع‌آوری زباله طراحی کنید | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| یک محدودکننده نرخ API طراحی کنید | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| یک بورس اوراق بهادار (مانند NASDAQ یا Binance) طراحی کنید | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang Implementation](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go Implementation](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| یک سوال طراحی سیستم اضافه کنید | [Contribute](#contributing) |

### معماری‌های واقعی دنیا

> مقالاتی درباره نحوه طراحی سیستم‌های واقعی دنیا.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>منبع: مقیاس‌پذیری تایم‌لاین توییتر</a></i>
</p>

**به جزئیات ریز در مقالات زیر تمرکز نکنید، بلکه:**

* اصول مشترک، فناوری‌های رایج و الگوها را در این مقالات شناسایی کنید
* بررسی کنید هر مولفه چه مشکلی را حل می‌کند، کجا کار می‌کند، کجا نمی‌کند
* درس‌های آموخته شده را مرور کنید

|نوع | سیستم | مرجع(ها) |
|---|---|---|
| پردازش داده | **MapReduce** - پردازش داده توزیع‌شده از گوگل | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| پردازش داده | **Spark** - پردازش داده توزیع‌شده از Databricks | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| پردازش داده | **Storm** - پردازش داده توزیع‌شده از توییتر | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| ذخیره‌سازی داده | **Bigtable** - پایگاه داده ستونی توزیع‌شده از گوگل | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| ذخیره‌سازی داده | **HBase** - پیاده‌سازی متن‌باز Bigtable | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| ذخیره‌سازی داده | **Cassandra** - پایگاه داده ستونی توزیع‌شده از فیسبوک | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666)
| ذخیره‌سازی داده | **DynamoDB** - پایگاه داده سندی از آمازون | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| ذخیره‌سازی داده | **MongoDB** - پایگاه داده سندی | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| ذخیره‌سازی داده | **Spanner** - پایگاه داده توزیع‌شده جهانی از گوگل | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| مخزن داده | **Memcached** - سیستم کش حافظه توزیع‌شده | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| مخزن داده | **Redis** - سیستم کش حافظه توزیع‌شده با پایداری و انواع داده | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| سیستم فایل | **Google File System (GFS)** - سیستم فایل توزیع‌شده | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| سیستم فایل | **Hadoop File System (HDFS)** - پیاده‌سازی متن‌باز GFS | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| متفرقه | **Chubby** - سرویس قفل برای سیستم‌های توزیع‌شده با اتصال ضعیف از گوگل | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| متفرقه | **Dapper** - زیرساخت ردیابی سیستم‌های توزیع‌شده | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| متفرقه | **Kafka** - صف پیام pub/sub از LinkedIn | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| متفرقه | **Zookeeper** - زیرساخت و سرویس‌های متمرکز برای هم‌زمان‌سازی | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | یک معماری اضافه کنید | [مشارکت کنید](#contributing) |

### معماری شرکت‌ها

| شرکت | مرجع(ها) |
|---|---|
| آمازون | [معماری آمازون](http://highscalability.com/amazon-architecture) |
| Cinchcast | [تولید ۱۵۰۰ ساعت صوت در هر روز](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [داده‌کاوی بلادرنگ با ۱۲۰،۰۰۰ توییت در ثانیه](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [چگونه Dropbox را مقیاس‌بندی کردیم](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [عملیات با ۱۰۰،۰۰۰ duh nuh nuhs در ثانیه](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| گوگل | [معماری گوگل](http://highscalability.com/google-architecture) |
| اینستاگرام | [۱۴ میلیون کاربر، ترابایت‌ها عکس](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[چه چیزی اینستاگرام را قدرت می‌دهد](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [معماری پخش زنده ویدیوی Justin.tv](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| فیسبوک | [مقیاس‌بندی memcached در فیسبوک](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: مخزن داده توزیع‌شده فیسبوک برای گراف اجتماعی](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[ذخیره‌سازی عکس فیسبوک](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[چگونه فیسبوک پخش زنده را به ۸۰۰،۰۰۰ بیننده همزمان می‌رساند](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [معماری Flickr](http://highscalability.com/flickr-architecture) |
| Mailbox | [از ۰ تا یک میلیون کاربر در ۶ هفته](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [نمای ۳۶۰ درجه از کل پشته Netflix](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix: چه اتفاقی می‌افتد وقتی پلی را فشار می‌دهید؟](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [از ۰ تا ده‌ها میلیارد بازدید صفحه در ماه](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[۱۸ میلیون بازدیدکننده، رشد ۱۰ برابری، ۱۲ کارمند](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [۵۰ میلیون کاربر ماهانه و رو به رشد](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [معماری PlentyOfFish](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [چگونه روزانه ۱.۳ میلیارد تراکنش را مدیریت می‌کنند](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [معماری Stack Overflow](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [۴۰M بازدیدکننده، ۲۰۰M بازدید پویا، ۳۰TB داده](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [۱۵ میلیارد بازدید صفحه در ماه](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| توییتر | [سریع‌تر کردن توییتر به میزان ۱۰۰۰۰ درصد](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[ذخیره‌سازی ۲۵۰ میلیون توییت در روز با MySQL](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[۱۵۰ میلیون کاربر فعال، ۳۰۰K QPS، فایرهوس ۲۲ MB/S](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[تایم‌لاین‌ها در مقیاس](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[داده‌های بزرگ و کوچک در توییتر](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[عملیات در توییتر: مقیاس‌بندی فراتر از ۱۰۰ میلیون کاربر](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[چگونه توییتر ۳۰۰۰ تصویر در ثانیه را مدیریت می‌کند](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [چگونه Uber پلتفرم بازار بلادرنگ خود را مقیاس‌بندی می‌کند](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[درس‌هایی از مقیاس‌بندی Uber تا ۲۰۰۰ مهندس، ۱۰۰۰ سرویس و ۸۰۰۰ مخزن Git](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [معماری WhatsApp که فیسبوک با ۱۹ میلیارد دلار خرید](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| یوتیوب | [مقیاس‌پذیری یوتیوب](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[معماری یوتیوب](http://highscalability.com/youtube-architecture) |

### وبلاگ‌های مهندسی شرکت‌ها

> معماری‌هایی برای شرکت‌هایی که در حال مصاحبه با آن‌ها هستید.
>
> سوالاتی که با آن‌ها مواجه می‌شوید ممکن است از همان حوزه باشند.

* [مهندسی Airbnb](http://nerds.airbnb.com/)
* [توسعه‌دهندگان Atlassian](https://developer.atlassian.com/blog/)
* [وبلاگ AWS](https://aws.amazon.com/blogs/aws/)
* [وبلاگ مهندسی Bitly](http://word.bitly.com/)
* [وبلاگ‌های Box](https://blog.box.com/blog/category/engineering)
* [وبلاگ توسعه‌دهندگان Cloudera](http://blog.cloudera.com/)
* [وبلاگ فنی Dropbox](https://tech.dropbox.com/)
* [مهندسی در Quora](https://www.quora.com/q/quoraengineering)
* [وبلاگ فنی Ebay](http://www.ebaytechblog.com/)
* [وبلاگ فنی Evernote](https://blog.evernote.com/tech/)
* [Etsy Code as Craft](http://codeascraft.com/)
* [مهندسی Facebook](https://www.facebook.com/Engineering)
* [Flickr Code](http://code.flickr.net/)
* [وبلاگ مهندسی Foursquare](http://engineering.foursquare.com/)
* [وبلاگ مهندسی GitHub](https://github.blog/category/engineering)
* [وبلاگ تحقیقات Google](http://googleresearch.blogspot.com/)
* [وبلاگ مهندسی Groupon](https://engineering.groupon.com/)
* [وبلاگ مهندسی Heroku](https://engineering.heroku.com/)
* [وبلاگ مهندسی Hubspot](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability](http://highscalability.com/)
* [مهندسی Instagram](http://instagram-engineering.tumblr.com/)
* [وبلاگ نرم‌افزار Intel](https://software.intel.com/en-us/blogs/)
* [وبلاگ فنی Jane Street](https://blogs.janestreet.com/category/ocaml/)
* [مهندسی LinkedIn](http://engineering.linkedin.com/blog)
* [مهندسی Microsoft](https://engineering.microsoft.com/)
* [مهندسی پایتون Microsoft](https://blogs.msdn.microsoft.com/pythonengineering/)
* [وبلاگ فنی Netflix](http://techblog.netflix.com/)
* [وبلاگ توسعه‌دهندگان Paypal](https://medium.com/paypal-engineering)
* [وبلاگ مهندسی Pinterest](https://medium.com/@Pinterest_Engineering)
* [وبلاگ Reddit](http://www.redditblog.com/)
* [وبلاگ مهندسی Salesforce](https://developer.salesforce.com/blogs/engineering/)
* [وبلاگ مهندسی Slack](https://slack.engineering/)
* [Spotify Labs](https://labs.spotify.com/)
* [وبلاگ مهندسی Stripe](https://stripe.com/blog/engineering)
* [وبلاگ مهندسی Twilio](http://www.twilio.com/engineering)
* [مهندسی توییتر](https://blog.twitter.com/engineering/)
* [وبلاگ مهندسی Uber](http://eng.uber.com/)
* [وبلاگ مهندسی یاهو](http://yahooeng.tumblr.com/)
* [وبلاگ مهندسی Yelp](http://engineeringblog.yelp.com/)
* [وبلاگ مهندسی Zynga](https://www.zynga.com/blogs/engineering)

#### منبع(ها) و مطالعه بیشتر

دنبال اضافه کردن یک وبلاگ هستید؟ برای جلوگیری از تکرار کار، وبلاگ شرکت خود را به مخزن زیر اضافه کنید:

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## در حال توسعه

علاقه‌مند به اضافه کردن یک بخش یا کمک به تکمیل یکی از بخش‌های در حال پیشرفت هستید؟ [مشارکت کنید](#contributing)!

* محاسبات توزیع‌شده با MapReduce
* هشینگ سازگار
* Scatter gather
* [مشارکت کنید](#contributing)

## اعتبارها

اعتبارها و منابع در سراسر این مخزن ارائه شده‌اند.

تشکر ویژه از:

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [System design cheat sheet](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [A distributed systems reading list](http://dancres.github.io/Pages/)
* [Cracking the system design interview](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## اطلاعات تماس

در صورت تمایل می‌توانید برای بحث در مورد هرگونه مشکل، سؤال یا نظر با من تماس بگیرید.

اطلاعات تماس من را می‌توانید در [صفحه گیت‌هاب](https://github.com/donnemartin) من پیدا کنید.

## مجوز

*من کد و منابع موجود در این مخزن را تحت یک مجوز متن‌باز در اختیار شما قرار می‌دهم.  از آنجا که این مخزن شخصی من است، مجوزی که برای کد و منابع دریافت می‌کنید از طرف من است و نه کارفرمای من (فیسبوک).*

    کپی‌رایت ۲۰۱۷ دون مارتین

    مجوز بین‌المللی کریتیو کامنز انتساب 4.0 (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---