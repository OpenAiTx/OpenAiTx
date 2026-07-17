
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

<!-- badges: start -->

[![Status CRAN](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![Unduhan CRAN RStudio mirror](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![Unduhan CRAN RStudio mirror](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** adalah metode imputasi nonparametrik untuk data tabular **tipe campuran** di R. Metode ini menangani variabel **numerik dan kategorikal** secara bersamaan dengan melatih random forest secara iteratif untuk memprediksi entri yang hilang dari data yang teramati. Tidak ada asumsi pemodelan eksplisit, tidak ada faktorisasi matriks—hanya baseline prediktif yang kuat dan langsung bekerja dengan baik.

* Bekerja dengan **kombinasi kolom numerik dan faktor apa pun**
* Menangkap **nonlinearitas** dan **interaksi**
* Melaporkan **galat imputasi out-of-bag (OOB)** (NRMSE/PFC)
* Mendukung **eksekusi paralel** (per variabel atau per forest)
* Dua backend forest: **[`ranger`](https://cran.r-project.org/package=ranger)** (default) dan **[`randomForest`](https://cran.r-project.org/package=randomForest)** (warisan/kompatibel)

Paket ini juga mencakup utilitas untuk mengukur galat imputasi, menghasilkan missingness untuk eksperimen, dan memeriksa tipe variabel.

---

## Instalasi

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

### Memilih backend

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Paralelisasi

Dua mode tersedia melalui `parallelize`:

* `"variables"`: membangun hutan untuk variabel berbeda secara paralel (daftarkan backend foreach).
* `"forests"`: paralelisasi di dalam hutan satu variabel (thread ranger; atau sub-hutan foreach untuk randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## Ikhtisar API

### `missForest(xmis, ...)`

Fungsi inti imputasi.

Argumen utama:

* `xmis` — data frame/matrix dengan nilai hilang (kolom harus `numeric` atau `factor`).
* `maxiter` — iterasi maksimum (default `10`).
* `ntree` — jumlah pohon per hutan (default `100`).
* `mtry` — variabel yang dicoba pada setiap split (default `sqrt(p)`).
* `nodesize` — **numeric panjang-2**: ukuran node minimum untuk **c(numeric, factor)**. Default `c(5, 1)`.
* `variablewise` — mengembalikan error OOB per variabel jika `TRUE`.
* `parallelize` — `"no"`, `"variables"`, atau `"forests"`.
* `num.threads` — jumlah thread untuk `ranger` (diabaikan oleh `randomForest`).
* `backend` — `"ranger"` (default) atau `"randomForest"`.
* `xtrue` — data lengkap opsional untuk **benchmarking** (menambah `$error`).

Beberapa pemetaan argumen untuk `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (terpisah untuk regresi/klasifikasi; default `c(5,1)`)
* `sampsize` (jumlah) → `sample.fraction` (fraksi; keseluruhan atau per kelas)
* `classwt → class.weights`
* `cutoff` ditangani dengan fitting **probability forests** dan post-thresholding

### Utilitas

* `mixError(ximp, xmis, xtrue)` — menghitung **NRMSE** (numerik) dan **PFC** (faktor) pada entri hilang yang sebenarnya.
* `nrmse(ximp, xmis, xtrue)` — NRMSE untuk data kontinu saja.
* `prodNA(x, noNA = 0.1)` — menyuntikkan missingness MCAR ke dalam data frame.
* `varClass(x)` — mengembalikan `"numeric"`/`"factor"` per kolom.

---

## Tips & praktik terbaik


* Ubah kolom karakter menjadi faktor sebelum memanggil `missForest`.
* Untuk data yang lebar, pertimbangkan `parallelize = "variables"`. Untuk pohon yang dalam/mahal, pertimbangkan `parallelize = "forests"`.
* Atur seed untuk hasil yang hampir dapat direproduksi:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Anda dapat menurunkan `ntree` selama prototyping untuk mempercepat iterasi.

---

## Sitasi

Jika Anda menggunakan **missForest**, harap sitasi:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Anda juga dapat mensitasi paketnya:

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