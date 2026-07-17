<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# मिसफॉरेस्ट

<!-- बैज: प्रारंभ -->

[![CRAN स्थिति](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio मिरर डाउनलोड्स](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio मिरर डाउनलोड्स](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-चेक](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)

[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** R में **मिश्रित प्रकार** की तालिका डेटा के लिए एक गैर-पैरामीट्रिक इम्प्यूटेशन विधि है। यह **संख्यात्मक और श्रेणीबद्ध** वेरिएबल्स को एक साथ संभालता है, जिससे यादृच्छिक वन का प्रशिक्षण करके, देखी गई प्रविष्टियों से अनुपस्थित प्रविष्टियों की भविष्यवाणी की जाती है। कोई स्पष्ट मॉडलिंग धारणा नहीं, कोई मैट्रिक्स फैक्टराइजेशन नहीं—बस मजबूत भविष्यवाणी आधार जो तुरंत अच्छे परिणाम देते हैं।

* **संख्यात्मक और फैक्टर कॉलम्स** के किसी भी मिश्रण के साथ काम करता है
* **गैर-रेखीयता** और **इंटरएक्शन** को पकड़ता है
* **आउट-ऑफ-बैग (OOB)** इम्प्यूटेशन त्रुटि (NRMSE/PFC) रिपोर्ट करता है
* **समानांतर निष्पादन** को सपोर्ट करता है (प्रति वेरिएबल या प्रति वन)
* दो वन बैकएंड: **[`ranger`](https://cran.r-project.org/package=ranger)** (डिफ़ॉल्ट) और **[`randomForest`](https://cran.r-project.org/package=randomForest)** (पुराना/अनुकूलता)

पैकेज में इम्प्यूटेशन त्रुटि मापने, प्रयोगों के लिए मिसिंगनेस उत्पन्न करने, और वेरिएबल प्रकारों का निरीक्षण करने के लिए उपयोगिताएँ भी शामिल हैं।

---

## इंस्टॉलेशन

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

### एक बैकएंड चुनना

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### समानांतरता

`parallelize` के माध्यम से दो मोड उपलब्ध हैं:

* `"variables"`: विभिन्न वेरिएबल्स के लिए फॉरेस्ट्स को समानांतर रूप से बनाएं (foreach बैकएंड रजिस्टर करें)।
* `"forests"`: एक ही वेरिएबल के फॉरेस्ट के भीतर समानांतरता (ranger थ्रेड्स; या randomForest के लिए foreach सब-फॉरेस्ट्स)।

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## API अवलोकन

### `missForest(xmis, ...)`

मुख्य इम्प्यूटेशन फंक्शन।

मुख्य आर्ग्युमेंट्स:

* `xmis` — डेटा फ्रेम/मैट्रिक्स जिसमें मिसिंग वैल्यूज हों (कॉलम `numeric` या `factor` ही होने चाहिए)।
* `maxiter` — अधिकतम इटरेशन (डिफ़ॉल्ट `10`)।
* `ntree` — प्रत्येक फॉरेस्ट में ट्री की संख्या (डिफ़ॉल्ट `100`)।
* `mtry` — प्रत्येक स्प्लिट पर आज़माए जाने वाले वेरिएबल (डिफ़ॉल्ट `sqrt(p)`)।
* `nodesize` — **लंबाई-2 न्यूमेरिक**: **c(numeric, factor)** के लिए न्यूनतम नोड साइज। डिफ़ॉल्ट `c(5, 1)`।
* `variablewise` — यदि `TRUE` तो प्रति-वेरिएबल OOB एरर लौटाता है।
* `parallelize` — `"no"`, `"variables"`, या `"forests"`।
* `num.threads` — `ranger` के लिए थ्रेड्स (`randomForest` द्वारा अनदेखा किया जाता है)।
* `backend` — `"ranger"` (डिफ़ॉल्ट) या `"randomForest"`।
* `xtrue` — **बेंचमार्किंग** के लिए वैकल्पिक पूर्ण डेटा (यह `$error` जोड़ता है)।

`backend = "ranger"` के लिए कुछ आर्ग्युमेंट मैपिंग्स:

* `ntree → num.trees`
* `nodesize → min.bucket` (रेग्रेशन/क्लासिफिकेशन के लिए अलग-अलग; डिफ़ॉल्ट `c(5,1)`)
* `sampsize` (गिनती) → `sample.fraction` (फ्रैक्शंस; ओवरऑल या प्रति-क्लास)
* `classwt → class.weights`
* `cutoff` को **probability forests** बनाकर और पोस्ट-थ्रेशोल्डिंग द्वारा संभाला जाता है

### यूटिलिटीज

* `mixError(ximp, xmis, xtrue)` — सही मिसिंग एंट्रीज़ पर **NRMSE** (न्यूमेरिक) और **PFC** (फैक्टर) की गणना करता है।
* `nrmse(ximp, xmis, xtrue)` — केवल कंटीन्युअस डेटा के लिए NRMSE।
* `prodNA(x, noNA = 0.1)` — डेटा फ्रेम में MCAR मिसिंगनेस डालता है।
* `varClass(x)` — प्रति कॉलम `"numeric"`/`"factor"` लौटाता है।

---

## सुझाव और सर्वोत्तम प्रथाएँ


* `missForest` को कॉल करने से पहले कैरेक्टर कॉलम्स को फैक्टर में बदलें।
* वाइड डेटा के लिए, `parallelize = "variables"` पर विचार करें। डीप/महंगे ट्रीज़ के लिए, `parallelize = "forests"` पर विचार करें।
* लगभग पुनरुत्पादनीय परिणामों के लिए एक बीज सेट करें:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* आप प्रोटोटाइपिंग के दौरान `ntree` को कम करके पुनरावृत्ति की गति बढ़ा सकते हैं।

---

## संदर्भ

यदि आप **missForest** का उपयोग करते हैं, तो कृपया निम्नलिखित को उद्धृत करें:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

आप इस पैकेज को भी उद्धृत कर सकते हैं:

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