
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

<!-- rozetler: başlangıç -->

[![CRAN durumu](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio aynası indirmeleri](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio aynası toplam indirme](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest**, R dilinde **karışık tipte** tablosal veriler için parametrik olmayan bir tamamlama yöntemidir. **Sayısal ve kategorik** değişkenleri aynı anda işler; gözlemlenenlerden eksik verileri tahmin etmek için rastgele ormanları yinelemeli olarak eğitir. Açık bir modelleme varsayımı veya matris ayrıştırması yoktur—sadece kutudan çıktığı gibi iyi çalışan güçlü kestirimsel tabanlar kullanılır.

* **Herhangi bir sayısal ve faktör sütunu karışımıyla** çalışır
* **Doğrusal olmayanlıkları** ve **etkileşimleri** yakalar
* **Çanta dışı (OOB)** tamamlama hatasını raporlar (NRMSE/PFC)
* **Paralel yürütmeyi** destekler (değişken başına veya orman başına)
* İki orman altyapısı: **[`ranger`](https://cran.r-project.org/package=ranger)** (varsayılan) ve **[`randomForest`](https://cran.r-project.org/package=randomForest)** (eski/uyumluluk)

Paket ayrıca tamamlama hatasını ölçmek, deneyler için eksiklik oluşturmak ve değişken tiplerini incelemek için yardımcı araçlar içerir.

---

## Kurulum

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

### Bir arka uç seçmek

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Paralelleştirme

`parallelize` aracılığıyla iki mod mevcuttur:

* `"variables"`: farklı değişkenler için ormanları paralel olarak oluşturur (bir foreach arka ucu kaydedin).
* `"forests"`: tek bir değişkenin ormanı içinde paralelleştirme yapar (ranger iş parçacıkları; veya randomForest için foreach alt-ormanları).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## API genel bakış

### `missForest(xmis, ...)`

Çekirdek imputasyon fonksiyonu.

Temel argümanlar:

* `xmis` — eksik değer içeren veri çerçevesi/matrisi (sütunlar `numeric` veya `factor` olmalı).
* `maxiter` — maksimum iterasyon sayısı (varsayılan `10`).
* `ntree` — orman başına ağaç sayısı (varsayılan `100`).
* `mtry` — her bölmede denenen değişken sayısı (varsayılan `sqrt(p)`).
* `nodesize` — **uzunluk-2 sayısal**: **c(numeric, factor)** için minimum düğüm boyutu. Varsayılan `c(5, 1)`.
* `variablewise` — `TRUE` ise değişken başına OOB hatası döndürür.
* `parallelize` — `"no"`, `"variables"` veya `"forests"`.
* `num.threads` — `ranger` için iş parçacığı ( `randomForest` tarafından dikkate alınmaz).
* `backend` — `"ranger"` (varsayılan) veya `"randomForest"`.
* `xtrue` — **karşılaştırma** için isteğe bağlı tam veri ( `$error` ekler).

`backend = "ranger"` için bazı argüman eşlemeleri:

* `ntree → num.trees`
* `nodesize → min.bucket` (regresyon/sınıflandırma için ayrı ayrı; varsayılan `c(5,1)`)
* `sampsize` (sayılar) → `sample.fraction` (oranlar; tümü veya sınıf başına)
* `classwt → class.weights`
* `cutoff` **olasılık ormanları** uydurularak ve eşik sonrası işlemle ele alınır

### Yardımcılar

* `mixError(ximp, xmis, xtrue)` — gerçek eksik girdilerde **NRMSE** (sayısal) ve **PFC** (faktör) hesaplar.
* `nrmse(ximp, xmis, xtrue)` — sadece sürekli veriler için NRMSE hesaplar.
* `prodNA(x, noNA = 0.1)` — bir veri çerçevesine MCAR eksiklik enjekte eder.
* `varClass(x)` — her sütun için `"numeric"`/`"factor"` döndürür.

---

## İpuçları & en iyi uygulamalar


* Karakter sütunlarını `missForest` çağırmadan önce faktöre dönüştürün.
* Geniş veri için `parallelize = "variables"` seçeneğini düşünün. Derin/pahalı ağaçlar için `parallelize = "forests"` seçeneğini düşünün.
* Yarı-tekrarlanabilir sonuçlar için bir seed belirleyin:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Prototipleme sırasında yinelemeyi hızlandırmak için `ntree` değerini düşürebilirsiniz.

---

## Atıf

**missForest** kullanıyorsanız, lütfen aşağıdaki kaynağı atıf yapın:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—karışık tipte veriler için parametrik olmayan eksik değer ataması.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Paketi de şu şekilde atıf yapabilirsiniz:

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