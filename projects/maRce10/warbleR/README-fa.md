<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


واربل‌آر: ساده‌سازی تحلیل زیست‌صوتی
================

<!-- README.md از README.Rmd تولید شده است. لطفا آن فایل را ویرایش کنید -->
<!-- نشان‌ها: شروع -->

[![چرخه‌عمر](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![وضعیت](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![وضعیت پروژه: فعال پروژه به وضعیت پایدار و قابل استفاده رسیده است
و به طور فعال
در حال توسعه است.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![مجوز: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![نشان وضعیت CRAN](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![کل
دانلودها](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![پوشش تست Codecov](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- نشان‌ها: پایان -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="لوگوی warbleR" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) با هدف
تسهیل تحلیل ساختار سیگنال‌های صوتی حیوانات در
R توسعه یافته است. کاربران می‌توانند ضبط‌های پرندگان با دسترسی آزاد را جمع‌آوری کنند یا داده‌های خود را وارد گردش کاری نمایند که نمایش طیف‌نگاری و
اندازه‌گیری پارامترهای صوتی را تسهیل می‌کند.
[warbleR](https://cran.r-project.org/package=warbleR) از ابزارهای
تحلیل صدای پایه بسته seewave بهره می‌برد و ابزارهای جدیدی را برای تحلیل ساختار صوتی ارائه می‌دهد. این ابزارها برای
تحلیل دسته‌ای سیگنال‌های صوتی در دسترس هستند.

ویژگی‌های اصلی بسته عبارتند از:

- ابزارهای متنوع برای اندازه‌گیری ساختار صوتی
- استفاده از حلقه‌ها برای اعمال وظایف بر سیگنال‌های صوتی که در
  جدول انتخابی ارجاع داده شده‌اند
- تولید تصاویر در پوشه کاری با طیف‌نگارها جهت
  سازماندهی داده‌ها و اعتبارسنجی تحلیل‌های صوتی توسط کاربران

این بسته توابعی برای:

- جستجو و دانلود ضبط‌های [Xeno‐Canto](https://xeno-canto.org/)
- جستجو، سازماندهی و دستکاری چندین فایل صوتی
- شناسایی خودکار سیگنال‌ها (در فرکانس و زمان) (اما برای پیاده‌سازی جامع‌تر و کاربرپسندتر، بسته R [ohun](https://docs.ropensci.org/ohun/) را بررسی کنید)
- ایجاد طیف‌نگار از ضبط‌های کامل یا سیگنال‌های منفرد





- اجرای معیارهای مختلف ساختار سیگنال صوتی
- ارزیابی عملکرد روش‌های اندازه‌گیری
- فهرست‌بندی سیگنال‌ها
- توصیف سطوح ساختاری مختلف در سیگنال‌های صوتی
- تحلیل آماری هماهنگی دوئت
- یکپارچه‌سازی پایگاه‌های داده و جداول حاشیه‌نویسی

بیشتر توابع امکان موازی‌سازی وظایف را فراهم می‌کنند که
وظایف را بین چند پردازنده توزیع می‌کند تا کارایی محاسباتی
افزایش یابد. ابزارهایی برای ارزیابی عملکرد تحلیل در هر
مرحله نیز موجود است.

## نصب

بسته را از CRAN به صورت زیر نصب/بارگذاری کنید:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```
برای نصب جدیدترین نسخه توسعه‌ای از
[گیت‌هاب](https://github.com/) شما به بسته R با نام
[remotes](https://cran.r-project.org/package=remotes) نیاز خواهید داشت:


``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```
## استفاده

این بسته شامل چندین ویگنت است که ویژگی‌های اصلی آن را توضیح می‌دهند.
[معرفی
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
یک نمای کلی از قابلیت‌های بسته ارائه می‌دهد. ویگنت
[فرمت داده‌های
حاشیه‌نویسی](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
توصیف دقیقی از فرمت مورد نیاز برای ورودی‌های حاشیه‌نویسی ارائه می‌کند.
همچنین سه [ویگنت بسته](https://marce10.github.io/warbleR/articles/) اضافی با مثال‌هایی درباره نحوه سازماندهی توابع در یک گردش کار تحلیل صوتی وجود دارد.

یک شرح کامل از بسته (هرچند کمی قدیمی) را می‌توان در این [مقاله ژورنالی](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624) یافت.

## بسته‌های دیگر

بسته‌های [seewave](https://cran.r-project.org/package=seewave) و
[tuneR](https://cran.r-project.org/package=seewave) مجموعه وسیعی از توابع را برای تحلیل و دستکاری صوتی فراهم می‌کنند.
آنها عمدتاً روی اشیای موجی که قبلاً وارد محیط R شده‌اند کار می‌کنند.
بسته [baRulho](https://cran.r-project.org/package=baRulho) بر کمّی‌سازی تخریب سیگنال‌های صوتی ناشی از زیستگاه تمرکز دارد و ورودی و خروجی داده‌هایی مشابه با
[warbleR](https://cran.r-project.org/package=warbleR) دارد.
بسته [Rraven](https://cran.r-project.org/package=Rraven) تبادل داده بین R و [نرم‌افزار تحلیل صدای Raven](https://www.ravensoundsoftware.com/) ([آزمایشگاه پرنده‌شناسی کرنل](https://www.birds.cornell.edu/home)) را تسهیل می‌کند و می‌تواند برای وارد کردن Raven به عنوان ابزار حاشیه‌نویسی در گردش کار تحلیل صوتی در R بسیار مفید باشد.
بسته
[ohun](https://docs.ropensci.org/ohun/) بر شناسایی خودکار رویدادهای صوتی کار می‌کند و توابعی برای تشخیص و بهینه‌سازی روال‌های شناسایی ارائه می‌دهد.
[dynaSpec](https://cran.r-project.org/package=seewave) امکان ایجاد طیف‌نگاره‌های پویا (یعنی ویدیوهای طیف‌نگاره‌ای) را فراهم می‌کند.

## استناد














لطفاً [warbleR](https://cran.r-project.org/package=warbleR) را به صورت زیر ذکر کنید:

Araya-Salas, M. و Smith-Vidaurre, G. (2017)، *warbleR: یک بسته r برای ساده‌سازی تحلیل سیگنال‌های صوتی حیوانات*. Methods Ecol Evol. 8، 184-191.

توجه: لطفاً بسته‌های
[tuneR](https://cran.r-project.org/package=tuneR) و
[seewave](https://cran.r-project.org/package=seewave) را نیز ذکر کنید اگر از هرگونه تابع تولید طیف نگاره یا اندازه‌گیری صوتی استفاده می‌کنید







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---