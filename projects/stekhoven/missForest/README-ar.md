
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# missForest

<!-- الشارات: البداية -->

[![حالة CRAN](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![تنزيلات مرآة CRAN RStudio الشهر الماضي](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![تنزيلات مرآة CRAN RStudio الإجمالي](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![تغطية الاختبارات](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![الترخيص: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- نهاية الشارات: -->

**missForest** هي طريقة تقدير غير معلمية لقيم مفقودة للبيانات الجدولية **متعددة الأنواع** في لغة R. تتعامل مع المتغيرات **العددية والتصنيفية** في الوقت نفسه من خلال تدريب غابات عشوائية بشكل تكراري للتنبؤ بالقيم المفقودة بناءً على القيم الملحوظة. لا افتراضات نمذجة صريحة، ولا تحليلات مصفوفية—فقط خطوط أساس تنبؤية قوية تعمل مباشرة بكفاءة.

* تعمل مع **أي مزيج من الأعمدة العددية والتصنيفية**
* تلتقط **اللاخطيات** و**التفاعلات**
* تبلغ عن **خطأ التقدير خارج الحقيبة (OOB)** (NRMSE/PFC)
* تدعم **التنفيذ المتوازي** (حسب المتغير أو حسب الغابة)
* يوجد محركان للغابات: **[`ranger`](https://cran.r-project.org/package=ranger)** (افتراضي) و **[`randomForest`](https://cran.r-project.org/package=randomForest)** (قديم/متوافق)

تتضمن الحزمة أيضًا أدوات لقياس خطأ التقدير، وإنشاء فقدان البيانات للتجارب، وفحص أنواع المتغيرات.

---

## التثبيت

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

### اختيار الواجهة الخلفية

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### التوازي

يتوفر وضعان عبر `parallelize`:

* `"variables"`: بناء الغابات لمتغيرات مختلفة بالتوازي (سجل خلفية foreach).
* `"forests"`: التوازي ضمن غابة متغير واحد (خيوط ranger؛ أو غابات فرعية foreach لـ randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## نظرة عامة على واجهة برمجة التطبيقات (API)

### `missForest(xmis, ...)`

دالة الإكمال الأساسية.

المعلمات الرئيسية:

* `xmis` — إطار بيانات/مصفوفة تحتوي على قيم مفقودة (يجب أن تكون الأعمدة من النوع `numeric` أو `factor`).
* `maxiter` — الحد الأقصى لعدد التكرارات (القيمة الافتراضية `10`).
* `ntree` — عدد الأشجار في كل غابة (الافتراضي `100`).
* `mtry` — عدد المتغيرات المجربة عند كل تقسيم (الافتراضي `sqrt(p)`).
* `nodesize` — **عدد عشري من عنصرين**: الحد الأدنى لحجم العقدة لـ **c(numeric, factor)**. الافتراضي `c(5, 1)`.
* `variablewise` — يُرجع خطأ OOB لكل متغير إذا كانت قيمته `TRUE`.
* `parallelize` — `"no"` أو `"variables"` أو `"forests"`.
* `num.threads` — عدد الخيوط لـ `ranger` (يتم تجاهله في `randomForest`).
* `backend` — `"ranger"` (افتراضي) أو `"randomForest"`.
* `xtrue` — بيانات كاملة اختيارية لأغراض **المقارنة المرجعية** (تضيف `$error`).

بعض تعيينات المعاملات لـ `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (منفصل للتنبؤ والانحدار/التصنيف؛ الافتراضي `c(5,1)`)
* `sampsize` (كعدد) → `sample.fraction` (كنسبة؛ إجمالية أو لكل فئة)
* `classwt → class.weights`
* `cutoff` تتم معالجته عن طريق تركيب **غابات الاحتمالية** ثم تطبيق العتبة بعد ذلك

### الأدوات المساعدة

* `mixError(ximp, xmis, xtrue)` — يحسب **NRMSE** (للمتغيرات العددية) و **PFC** (للمتغيرات الفئوية) للقيم المفقودة الحقيقية.
* `nrmse(ximp, xmis, xtrue)` — NRMSE للبيانات العددية فقط.
* `prodNA(x, noNA = 0.1)` — يحقن فقدان عشوائي (MCAR) في إطار بيانات.
* `varClass(x)` — يُرجع `"numeric"`/`"factor"` لكل عمود.

---

## نصائح وأفضل الممارسات


* قم بتحويل أعمدة الأحرف إلى عوامل قبل استدعاء `missForest`.
* بالنسبة للبيانات الواسعة، ضع في اعتبارك استخدام `parallelize = "variables"`. بالنسبة للأشجار العميقة أو المكلفة، ضع في اعتبارك استخدام `parallelize = "forests"`.
* قم بتعيين قيمة للبذرة للحصول على نتائج شبه قابلة لإعادة الإنتاج:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* يمكنك تقليل قيمة `ntree` أثناء النمذجة الأولية لتسريع عملية التكرار.

---

## الاقتباس

إذا استخدمت **missForest**، يرجى الاقتباس من:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

يمكنك أيضًا الاستشهاد بالحزمة:

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