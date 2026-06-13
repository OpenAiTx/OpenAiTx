warbleR: ساده‌سازی تحلیل صوتی زیستی  
================

🌐 **زبان‌ها:**  
[انگلیسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |  
[اسپانیایی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |  
[فرانسوی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |  
[آلمانی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |  
[پرتغالی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |  
[ایتالیایی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |  
[روسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |  
[چینی (ساده)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |  
[چینی (سنتی)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |  
[ژاپنی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |  
[کره‌ای](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |  
[هندی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |  
[تایلندی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |  
[هلندی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |  
[لهستانی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |  
[عربی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |  
[فارسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |  
[ترکی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |  
[ویتنامی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |  
[اندونزیایی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |  
[آسامی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md از README.Rmd تولید شده است. لطفاً آن فایل را ویرایش کنید -->
<!-- نشان‌ها: شروع -->

[![چرخه‌عمر](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![وضعیت](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![وضعیت پروژه: فعال پروژه به وضعیت پایدار و قابل استفاده رسیده است
و در حال توسعه فعال می‌باشد.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![مجوز: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![نشان وضعیت CRAN](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![تعداد کل
دانلودها](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![آزمون Codecov

پوشش](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- نشان‌ها: پایان -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) با هدف
تسهیل تحلیل ساختار سیگنال‌های صوتی حیوانات در
زبان R طراحی شده است. کاربران می‌توانند ضبط‌های پرندگان با دسترسی آزاد را جمع‌آوری کنند یا داده‌های خود را وارد یک جریان کاری کنند که نمایش طیف‌نگاری و
اندازه‌گیری پارامترهای صوتی را آسان می‌کند.
[warbleR](https://cran.r-project.org/package=warbleR) از ابزارهای
تحلیل صوتی پایه بسته seewave استفاده می‌کند و ابزارهای جدیدی برای تحلیل ساختار آکوستیک ارائه می‌دهد. این ابزارها برای
تحلیل دسته‌ای سیگنال‌های صوتی در دسترس هستند.

ویژگی‌های اصلی این بسته عبارتند از:

- ابزارهای متنوع برای اندازه‌گیری ساختار آکوستیک
- استفاده از حلقه‌ها برای اعمال وظایف بر روی سیگنال‌های صوتی که در
  یک جدول انتخابی مرجع داده شده‌اند
- تولید تصاویر در پوشه کاری با طیف‌نگار جهت
  سازماندهی داده‌ها توسط کاربران و صحت‌سنجی تحلیل‌های آکوستیکی

این بسته توابعی برای موارد زیر ارائه می‌دهد:

- جستجو و دانلود ضبط‌های [Xeno‐Canto](https://xeno-canto.org/)
- جستجو، سازماندهی و مدیریت چندین فایل صوتی
- شناسایی خودکار سیگنال‌ها (در فرکانس و زمان) (اما برای پیاده‌سازی کامل‌تر و کاربرپسندتر بسته R
  [ohun](https://docs.ropensci.org/ohun/) را بررسی کنید)
- ساخت طیف‌نگار از کل ضبط‌ها یا سیگنال‌های منفرد
- اجرای اندازه‌گیری‌های مختلف ساختار سیگنال صوتی
- ارزیابی عملکرد روش‌های اندازه‌گیری
- فهرست‌بندی سیگنال‌ها
- توصیف سطوح ساختاری مختلف در سیگنال‌های صوتی
- تحلیل آماری هماهنگی دوئت‌ها
- یکپارچه‌سازی پایگاه‌های داده و جداول یادداشت‌گذاری

بیشتر توابع اجازه موازی‌سازی وظایف را می‌دهند که این کار
وظایف را میان چندین پردازنده تقسیم کرده تا کارایی محاسباتی را بهبود دهد



بهره‌وری. ابزارهایی برای ارزیابی عملکرد تحلیل در هر
مرحله نیز در دسترس هستند.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---