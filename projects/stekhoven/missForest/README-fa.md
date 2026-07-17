<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# missForest

<!-- نشان‌ها: شروع -->

[![وضعیت CRAN](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![دانلودهای آینه RStudio در CRAN (ماه گذشته)](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![دانلودهای کل آینه RStudio در CRAN](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)

[![تست پوشش](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![مجوز: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- نشان‌ها: پایان -->

**missForest** یک روش تخمین غیرپارامتری برای داده‌های جدولی **مختلط** در R است. این روش متغیرهای **عددی و دسته‌ای** را به طور همزمان با آموزش تکراری جنگل‌های تصادفی برای پیش‌بینی مقادیر گمشده از داده‌های مشاهده‌شده مدیریت می‌کند. بدون فرضیات مدل‌سازی صریح، بدون فاکتورگیری ماتریس—فقط خطوط پایه پیش‌بینی قوی که به طور پیش‌فرض خوب کار می‌کنند.

* با **هر ترکیبی از ستون‌های عددی و فاکتور** کار می‌کند
* **غیرخطی‌ها** و **برهم‌کنش‌ها** را ثبت می‌کند
* **خطای تخمین خارج از کیسه (OOB)** را گزارش می‌کند (NRMSE/PFC)
* از **اجرای موازی** پشتیبانی می‌کند (به ازای متغیر یا جنگل)
* دو پشتیبان جنگل: **[`ranger`](https://cran.r-project.org/package=ranger)** (پیش‌فرض) و **[`randomForest`](https://cran.r-project.org/package=randomForest)** (قدیمی/سازگار)

این بسته همچنین ابزارهایی برای اندازه‌گیری خطای تخمین، تولید فقدان داده برای آزمایش‌ها و بررسی نوع متغیرها را شامل می‌شود.

---

## نصب

```r
# CRAN (recommended)
install.packages("missForest")

# Development version (from GitHub)
# install.packages("remotes")
remotes::install_github("stekhoven/missForest")
```

---

## Quick start

```r
library(missForest)

# Example data
data(iris)

# Introduce ~20% MCAR missingness
set.seed(81)
iris_mis <- prodNA(iris, noNA = 0.20)

# Impute with default backend (ranger)
imp <- missForest(iris_mis, xtrue = iris, verbose = TRUE)

# Imputed data
head(imp$ximp)

# Estimated OOB errors (NRMSE for numeric, PFC for factors)
imp$OOBerror

# True error if xtrue was provided (for benchmarking only)
imp$error
```

### انتخاب یک بک‌اند

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### موازی‌سازی

دو حالت از طریق `parallelize` در دسترس است:

* `"variables"`: ساخت جنگل‌ها برای متغیرهای مختلف به صورت موازی (ثبت یک backend برای foreach).
* `"forests"`: موازی‌سازی درون جنگل یک متغیر (رشته‌های ranger؛ یا زیرجنگل‌های foreach برای randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## نمای کلی API

### `missForest(xmis, ...)`

تابع اصلی جای‌گذاری داده‌های گمشده.

پارامترهای کلیدی:

* `xmis` — دیتافریم/ماتریس با مقادیر گمشده (ستون‌ها باید `numeric` یا `factor` باشند).
* `maxiter` — بیشترین تعداد تکرارها (پیش‌فرض `10`).
* `ntree` — تعداد درخت در هر جنگل (پیش‌فرض `100`).
* `mtry` — تعداد متغیرهای امتحان شده در هر تقسیم (پیش‌فرض `sqrt(p)`).
* `nodesize` — **آرایه عددی طول-۲**: حداقل اندازه نود برای **c(numeric, factor)**. پیش‌فرض `c(5, 1)`.
* `variablewise` — اگر `TRUE` باشد، خطای OOB برای هر متغیر را برمی‌گرداند.
* `parallelize` — `"no"`, `"variables"`, یا `"forests"`.
* `num.threads` — تعداد رشته برای `ranger` (در `randomForest` نادیده گرفته می‌شود).
* `backend` — `"ranger"` (پیش‌فرض) یا `"randomForest"`.
* `xtrue` — داده کامل اختیاری برای **بنچمارک** (به `$error` اضافه می‌کند).

برخی نگاشت‌های پارامتر برای `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (جداگانه برای رگرسیون/طبقه‌بندی؛ پیش‌فرض `c(5,1)`)
* `sampsize` (تعداد) → `sample.fraction` (کسری؛ کلی یا هر کلاس)
* `classwt → class.weights`
* `cutoff` با برازش **جنگل‌های احتمالی** و پس از آستانه‌گذاری مدیریت می‌شود

### ابزارها

* `mixError(ximp, xmis, xtrue)` — **NRMSE** (عدد) و **PFC** (فاکتور) را برای مقادیر گمشده واقعی محاسبه می‌کند.
* `nrmse(ximp, xmis, xtrue)` — NRMSE برای داده‌های پیوسته فقط.
* `prodNA(x, noNA = 0.1)` — گمشدگی MCAR را به دیتافریم تزریق می‌کند.
* `varClass(x)` — `"numeric"`/`"factor"` را برای هر ستون برمی‌گرداند.

---

## نکات و بهترین روش‌ها


* قبل از فراخوانی `missForest`، ستون‌های کاراکتری را به فاکتور تبدیل کنید.
* برای داده‌های گسترده، گزینه `parallelize = "variables"` را در نظر بگیرید. برای درخت‌های عمیق/پرهزینه، گزینه `parallelize = "forests"` مناسب است.
* برای نتایج شبه‌قابل تکرار، یک مقدار seed تعیین کنید:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* می‌توانید مقدار `ntree` را در زمان نمونه‌سازی کاهش دهید تا سرعت تکرار افزایش یابد.

---

## ارجاع

اگر از **missForest** استفاده می‌کنید، لطفاً به این منبع ارجاع دهید:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

شما همچنین می‌توانید به بسته نرم‌افزاری ارجاع دهید:

```r
citation("missForest")
```

---

## Contributing

Issues and pull requests are welcome. Please include a minimal reproducible example when reporting bugs. For performance discussions, share small benchmarks and session info.

---

## License

GPL (≥ 2)

---

## Contact

Daniel J. Stekhoven — [stekhoven@nexus.ethz.ch](https://raw.githubusercontent.com/stekhoven/missForest/master/mailto:stekhoven@nexus.ethz.ch)

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---