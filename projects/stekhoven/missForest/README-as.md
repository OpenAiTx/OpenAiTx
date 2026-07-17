<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# মিছফৰেষ্ট

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)

[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** হৈছে R-ত **মিশ্ৰ-প্ৰকাৰ** টেবুলাৰ ডেটাৰ বাবে এটা নন-পেৰামেট্ৰিক ইম্পিউটেচন পদ্ধতি। এইয়ে **সংখ্যাত্মক আৰু শ্ৰেণীভুক্ত** ভেৰিয়েবলসমূহ একেলগে সম্বোধন কৰে, অবজাৰ্ভ কৰা মানসমূহৰ পৰা অভাব থকা মানসমূহ পূৰণ কৰিবলৈ ইটাৰেটিভলি ৰেণ্ডম ফৰেষ্ট প্ৰশিক্ষণ দিয়ে। কোনো স্পষ্ট মডেলিং অনুমান নাই, কোনো মেট্ৰিক্স ফেক্টৰাইজেচন নাই—কেৱল শক্তিশালী প্ৰেডিক্টিভ বেছলাইন যিয়ে বক্সৰ পৰা ভাল কাম কৰে।

* **সংখ্যাত্মক আৰু ফেক্টৰ কলামৰ যিকোনো মিশ্ৰণ**ৰ সৈতে কাম কৰে
* **ননলিনিয়াৰিটী** আৰু **ইন্টাৰেকশ্যন** ধৰে
* **আউট-অফ-বেগ (OOB)** ইম্পিউটেচন ত্ৰুটি (NRMSE/PFC) ৰিপ'ৰ্ট কৰে
* **পেৰালেল এক্সিকিউচন** (প্ৰতি-ভেৰিয়েবল বা প্ৰতি-ফৰেষ্ট) সমৰ্থন কৰে
* দুটা ফৰেষ্ট বেকএণ্ড: **[`ranger`](https://cran.r-project.org/package=ranger)** (ডিফল্ট) আৰু **[`randomForest`](https://cran.r-project.org/package=randomForest)** (লিগেচি/কম্পেট)

পেকেজটোত ইম্পিউটেচন ত্ৰুটি মাপিবলৈ, প্ৰয়োগৰ বাবে অভাৱ সৃষ্টি কৰিবলৈ, আৰু ভেৰিয়েবল টাইপ পৰ্যবেক্ষণ কৰিবলৈ ইউটিলিটি অন্তর্ভুক্ত আছে।

---

## স্থাপন

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

### এটা ব্যাকএণ্ড নিৰ্বাচন কৰা

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### সমান্তৰালীকৰণ

`parallelize`ৰ জৰিয়তে দুটা মোড উপলব্ধ:

* `"variables"`: ভিন্ন ভিন্ন পৰিৱৰ্তনশীলৰ বাবে বনবোৰ সমান্তৰালভাৱে নিৰ্মাণ কৰা (foreach backend ৰেজিষ্টাৰ কৰক)।
* `"forests"`: এটা পৰিৱৰ্তনশীলৰ বনটোৰ ভিতৰত সমান্তৰালীকৰণ (ranger threads; বা randomForestৰ বাবে foreach উপ-বন)।

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```

---

## API পৰ্যালোচনা

### `missForest(xmis, ...)`

মূল ইম্পিউটেচন ফাংচন।

মূল আৰ্গুমেন্টসমূহ:

* `xmis` — মিছিং ভেলিউ থকা ডাটা ফ্ৰেম/মেট্ৰিক্স (কলামসমূহ `numeric` বা `factor` হ’ব লাগিব)।
* `maxiter` — সৰ্বাধিক ইটাৰেচন (ডিফ'ল্ট `10`)।
* `ntree` — প্ৰতিটো ফৰেষ্টত গছ (ডিফ'ল্ট `100`)।
* `mtry` — প্ৰতিটো স্প্লিটত পৰীক্ষা কৰা ভেৰিয়েবল (ডিফ'ল্ট `sqrt(p)`)।
* `nodesize` — **দৈৰ্ঘ্য-২ নিউমেৰিক**: **c(numeric, factor)** ৰ বাবে ন্যূনতম নোড সাইজ। ডিফ'ল্ট `c(5, 1)`।
* `variablewise` — যদি `TRUE` হয়, প্ৰতিটো ভেৰিয়েবলৰ OOB ত্ৰুটি ৰিটাৰ্ন কৰে।
* `parallelize` — `"no"`, `"variables"`, বা `"forests"`।
* `num.threads` — `ranger` ৰ বাবে থ্ৰেড ( `randomForest` ত উপেক্ষা কৰা হয়)।
* `backend` — `"ranger"` (ডিফ'ল্ট) বা `"randomForest"`।
* `xtrue` — ঐচ্ছিক সম্পূৰ্ণ ডাটা **বেঞ্চমাৰ্কিং** ৰ বাবে ( `$error` যোগ কৰে)।

`backend = "ranger"` ৰ বাবে কিছুমান আৰ্গুমেন্ট মেপিং:

* `ntree → num.trees`
* `nodesize → min.bucket` (ৰেগ্ৰেছন/ক্লাছিফিকেশ্যনৰ বাবে পৃথক; ডিফ'ল্ট `c(5,1)`)
* `sampsize` (গণনা) → `sample.fraction` (ভগ্নাংশ; মুঠ বা প্ৰতি-ক্লাছ)
* `classwt → class.weights`
* `cutoff` হেণ্ডেল কৰা হয় **probability forests** ফিট কৰি আৰু পাছত থ্ৰেছহ'ল্ডিং কৰি

### ইউটিলিটিসমূহ

* `mixError(ximp, xmis, xtrue)` — সঁচা মিছিং এণ্ট্ৰিত **NRMSE** (নিউমেৰিক) আৰু **PFC** (ফেক্টৰ) গণনা কৰে।
* `nrmse(ximp, xmis, xtrue)` — কেৱল কণ্টিনুৱাচ ডাটাৰ বাবে NRMSE।
* `prodNA(x, noNA = 0.1)` — ডাটা ফ্ৰেমত MCAR মিছিংনেছ সংযোজন কৰে।
* `varClass(x)` — প্ৰতিটো কলামৰ বাবে `"numeric"`/`"factor"` ৰিটাৰ্ন কৰে।

---

## পৰামৰ্শ আৰু উত্তম অভ্যাসসমূহ

* `missForest` কল কৰাৰ আগতে কেলেক্টাৰ কলামসমূহক ফেক্টৰলৈ ৰূপান্তৰ কৰক।
* বহল ডেটাৰ বাবে, `parallelize = "variables"` বিবেচনা কৰক। গভীৰ/ব্যয়বহুল গছৰ বাবে, `parallelize = "forests"` বিবেচনা কৰক।
* প্ৰায়-প্ৰজননযোগ্য ফলাফলৰ বাবে এটা চিড্‌ স্থাপন কৰক:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* আপুনি প্ৰট'টাইপিংৰ সময়ত `ntree` হ্ৰাস কৰিব পাৰে যাতে পুনৰাবৃত্তি দ্ৰুত হয়।

---

## উদ্ধৃতি

আপুনি **missForest** ব্যৱহাৰ কৰিলে, অনুগ্ৰহ কৰি উদ্ধৃত কৰক:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

আপুনি পেকেজটোও উদ্ধৃত কৰিব পাৰে:

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