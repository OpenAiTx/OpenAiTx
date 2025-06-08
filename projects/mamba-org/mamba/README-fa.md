# مامبا: مدیر بسته سریع و چندسکویی

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">بخشی از mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">مدیر بسته <a href="https://github.com/mamba-org/mamba">مامبا</a></td>
    <td align="center">سرور بسته <a href="https://github.com/mamba-org/quetz">کتز</a></td>
  </tr>
</tbody>
</table>

## مامبا

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`مامبا` پیاده‌سازی مجدد مدیر بسته کندا (conda) به زبان ++C است.

- دانلود موازی داده‌های مخزن و فایل‌های بسته با استفاده از چندریسمانی (multi-threading)
- استفاده از libsolv برای حل وابستگی‌ها با سرعت بسیار بیشتر؛ این کتابخانه مدرن در مدیر بسته RPM متعلق به Red Hat، فدورا و OpenSUSE نیز استفاده می‌شود.
- بخش‌های اصلی `مامبا` برای بیشینه کردن کارایی به زبان ++C پیاده‌سازی شده‌اند.

در عین حال، `مامبا` از همان تجزیه‌گر خط فرمان، کد نصب و حذف بسته و روال‌های تأیید تراکنش مشابه با `conda` بهره می‌برد تا بیشترین سازگاری ممکن را داشته باشد.

`مامبا` بخشی از اکوسیستم [conda-forge](https://conda-forge.org/) است که شامل `quetz`، یک سرور بسته کندا متن‌باز نیز می‌باشد.

می‌توانید [پست وبلاگ معرفی ما](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23) را مطالعه کنید.

## میکرومامبا

`micromamba` نسخه‌ای استاتیک لینک شده از `مامبا` است.

می‌توان آن را به صورت یک فایل اجرایی مستقل و بدون وابستگی نصب کرد، که آن را برای پیاده‌سازی‌های CI/CD و محیط‌های کانتینری عالی می‌سازد.

برای جزئیات، [مستندات مربوط به `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) را ببینید.

## `مامبا` در مقابل `میکرومامبا`

`مامبا` باید ترجیح داده شود وقتی:

- `libmambapy` یا `libmamba` توسط نرم‌افزارهای دیگر در همان محیط استفاده می‌شوند.
- سناریوهایی که به‌روزرسانی منظم کتابخانه‌ها (به‌ویژه برای امنیت) لازم است.
- محیط‌هایی که تمرکز بر کاهش مصرف فضای دیسک برای وابستگی‌ها دارند.

`micromamba` باید ترجیح داده شود وقتی:

- نیاز به تکیه بر یک فایل اجرایی مستقل است.
- توزیع miniforge وجود ندارد.
- استفاده به حداقل زمان اجرا نیاز دارد.

## نصب

لطفاً به راهنمای نصب [مامبا](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
و [میکرومامبا](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) در مستندات مراجعه کنید.

## ویژگی‌های اضافی در مامبا و میکرومامبا

`مامبا` و `micromamba` ویژگی‌هایی فراتر از نسخه پایه‌ای `conda` دارند.

### `repoquery`

برای جستجوی کارآمد در مخازن و بررسی وابستگی‌های بسته می‌توانید از `mamba repoquery` یا `micromamba repoquery` استفاده کنید.

برای جزئیات به [مستندات repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) مراجعه نمایید.

### نصب فایل‌های قفل (lock files)

`micromamba` می‌تواند فایل‌های قفل تولید شده توسط [conda-lock](https://conda.github.io/conda-lock/) را بدون نیاز به نصب `conda-lock` نصب کند.

کافی است از دستور `micromamba create` با گزینه `-f` و ارائه یک فایل قفل محیط با نامی که به
`-lock.yml` یا `-lock.yaml` ختم می‌شود، استفاده کنید؛ برای مثال:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (جایگزین setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) جایگزینی برای [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) است که از `micromamba` استفاده می‌کند.

این ابزار می‌تواند زمان راه‌اندازی CI شما را به طور قابل توجهی کاهش دهد از طریق:

- استفاده از `micromamba` که نصب آن حدود ۱ ثانیه طول می‌کشد.
- کش کردن دانلود بسته‌ها.
- کش کردن کل محیط‌های `conda`.

## تفاوت‌ها با `conda`

در حالی که `مامبا` و `micromamba` به طور کلی جایگزینی قطعی برای `conda` هستند، برخی تفاوت‌ها وجود دارد:

- `مامبا` و `micromamba` از قابلیت بازنگری (revisions) پشتیبانی نمی‌کنند (برای بحث‌ها، ببینید <https://github.com/mamba-org/mamba/issues/803>)
- `مامبا` و `micromamba` رشته‌های `MatchSpec` را به ساده‌ترین شکل نرمال‌سازی می‌کنند، در حالی که `conda` شکل مفصل‌تری را استفاده می‌کند.
  این موضوع می‌تواند منجر به تفاوت‌های جزئی در خروجی دستور `conda env export` و `mamba env export` شود.

## نصب توسعه‌دهنده

لطفاً به دستورالعمل‌های ارائه شده در [مستندات رسمی](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html) مراجعه کنید.

## پایداری API و ABI

پروژه مامبا از [نسخه‌بندی معنایی](https://semver.org/) به شکل `MAJOR.MINOR.PATCH` استفاده می‌کند.
در حالی که ما تلاش می‌کنیم پایداری برای کاربران را حفظ کنیم، برای بهبود مامبا و کاهش بدهی فنی، ممکن است مجبور به ایجاد تغییرات شکسته شویم.
نسخه‌های آینده مامبا ممکن است تضمین‌های قوی‌تری ارائه دهند.

### `libmamba` (++C)

ما از مصرف‌کنندگان API ++C اطلاع نداریم، بنابراین برای بهبودها دست خود را باز گذاشته‌ایم.
برای `libmamba`، اصطلاح _سازگاری معکوس_ به صورت زیر درک می‌شود:

- _سازگاری معکوس ABI_ یعنی شما می‌توانید فایل‌های باینری کتابخانه را بدون کامپایل مجدد کد خود با هدرهای به‌روزشده جایگزین کنید.
  رفتار مشاهده‌شده یکسان خواهد بود، به جز رفع باگ‌ها (امیدواریم) و عملکرد.
- _سازگاری معکوس API_ یعنی شما باید کد خود را با نسخه جدید کتابخانه مجدداً کامپایل کنید، اما لازم نیست کد خود را تغییر دهید، فقط آن را دوباره بسازید.
  این تا زمانی صدق می‌کند که شما از هیچ اعلان خصوصی (مثلاً در زیرفضاهای نام `detail`) استفاده نکرده باشید.
  رفتار مشاهده‌شده یکسان خواهد بود، به جز رفع باگ‌ها (امیدواریم) و عملکرد.
  زمانی که اعلان‌ها منسوخ اما حذف نشده و هنوز کاربردی باشند، ما آن را نیز سازگار معکوس محسوب می‌کنیم، زیرا فقط رفتار مشاهده‌شده در هنگام کامپایل تغییر می‌کند.

با این توضیحات، `libmamba` تضمین‌های زیر را ارائه می‌دهد:

- انتشارهای `PATCH` با API و ABI سازگار معکوس هستند؛
- انتشارهای `MINOR` برای اعلان‌های موجود در `mamba/api` با API سازگارند،
  ولی ممکن است در سایر بخش‌ها API و در هر کجا ABI را بشکنند؛
- انتشارهای `MAJOR` هیچ تضمینی نمی‌دهند.

### `libmambapy` (پایتون)

برای `libmambapy`، اصطلاح _سازگاری معکوس API_ یعنی کد پایتون شما همانطور که هست روی نسخه جدیدتر `libmambapy` کار می‌کند، به شرطی که از هیچ اعلان خصوصی (مثلاً با نامی که با `_` شروع می‌شود) استفاده نکرده باشید.
رفتار مشاهده‌شده یکسان خواهد بود، به جز رفع باگ‌ها (امیدواریم) و عملکرد.
زمانی که اعلان‌ها منسوخ اما حذف نشده و هنوز کاربردی باشند، ما آن را نیز سازگار معکوس محسوب می‌کنیم، چون رفتار فقط زمانی قابل مشاهده است که هشدارهای منسوخ شدن پایتون فعال شوند که معمولاً فقط در توسعه فعال است.

با این توضیحات، `libmambapy` تضمین‌های زیر را ارائه می‌دهد:

- انتشارهای `PATCH` با API سازگار معکوس هستند؛
- انتشارهای `MINOR` با API سازگار معکوس هستند؛
- انتشارهای `MAJOR` هیچ تضمینی نمی‌دهند.

### `مامبا` و `میکرومامبا` (فایل اجرایی)

برای فایل‌های اجرایی، اصطلاح _سازگاری معکوس_ به ورودی و خروجی‌های برنامه‌پذیر اطلاق می‌شود و یعنی کد شما (شامل اسکریپت‌های شل) با نسخه‌های جدیدتر فایل اجرایی بدون نیاز به تغییر کار خواهد کرد.
ورودی/خروجی‌های برنامه‌پذیر شامل نام فایل اجرایی، آرگومان‌های خط فرمان، فایل‌های پیکربندی، متغیرهای محیطی، خروجی‌های JSON خط فرمان و فایل‌های ایجاد شده است.
این تضمین _شامل نمی‌شود_ خروجی و پیام‌های خطا قابل خواندن توسط انسان، و بنابراین هشدارهای منسوخ شدن نوشته شده در خروجی متنی.

با این توضیحات، `مامبا` و `میکرومامبا` تضمین‌های زیر را ارائه می‌دهند:

- انتشارهای `PATCH` سازگار معکوس هستند؛
- انتشارهای `MINOR` سازگار معکوس هستند؛
- انتشارهای `MAJOR` هیچ تضمینی نمی‌دهند.

## حمایت از ما

تنها نسخه‌های ۲.۰ و بعد از `مامبا` و `میکرومامبا` پشتیبانی و به طور فعال توسعه داده می‌شوند.

شاخه `1.x` فقط برای رفع مسائل امنیتی مانند CVEها نگهداری می‌شود.

برای پرسش‌ها می‌توانید به [گپ QuantStack](https://gitter.im/QuantStack/Lobby)
یا [کانال Conda](https://gitter.im/conda/conda) بپیوندید (توجه داشته باشید که این پروژه به طور رسمی وابسته به `conda` یا Anaconda Inc. نیست).

## مجوز

ما از مدل حق‌نشر مشترک استفاده می‌کنیم که به همه مشارکت‌کنندگان اجازه می‌دهد حق‌نشر مشارکت‌های خود را حفظ کنند.

این نرم‌افزار تحت مجوز BSD-3-Clause منتشر شده است. برای جزئیات، فایل [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) را ببینید.

---

### جلسه توسعه دوهفتگی

ما هر دو هفته یک‌بار جلسه ویدئوکنفرانس برگزار می‌کنیم که در آن درباره کارهای انجام شده بحث و بازخورد دریافت می‌کنیم.

همه می‌توانند شرکت کنند، چه بخواهند موضوعی را مطرح کنند یا فقط شنونده باشند.

- زمان: سه‌شنبه [ساعت ۴:۰۰ بعدازظهر به وقت اروپا (CET)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- مکان: [Mamba jitsi](https://meet.jit.si/mamba-org)
- یادداشت‌ها: [Meeting notes](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---