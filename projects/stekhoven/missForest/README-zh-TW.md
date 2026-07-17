<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

<!-- 徽章：開始 -->

[![CRAN 狀態](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio 鏡像下載量](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio 鏡像總下載量](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)

[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** 是一種非參數填補方法，適用於 R 中 **混合型** 表格資料。它能同時處理 **數值型與分類型** 變數，透過迭代訓練隨機森林，從已觀測到的資料預測缺失值。不需明確建模假設、不進行矩陣分解——僅以強大的預測基準直接運作並取得良好成效。

* 支援 **任意組合的數值與因子欄位**
* 捕捉 **非線性關係** 與 **互動效應**
* 回報 **袋外（OOB）** 填補誤差（NRMSE/PFC）
* 支援 **平行執行**（每變數或每森林）
* 提供兩種森林後端：**[`ranger`](https://cran.r-project.org/package=ranger)**（預設）與 **[`randomForest`](https://cran.r-project.org/package=randomForest)**（舊版／相容）

本套件亦包含測量填補誤差、產生缺失實驗資料、檢查變數型態等工具。

---

## 安裝

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

### 選擇後端

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### 平行化

可透過 `parallelize` 使用兩種模式：

* `"variables"`：為不同變數同時建立森林（需註冊 foreach 後端）。
* `"forests"`：在單一變數的森林內進行平行化（ranger 執行緒；或 randomForest 的 foreach 子森林）。

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## API 總覽

### `missForest(xmis, ...)`

核心插補函數。

主要參數：

* `xmis` — 含有缺失值的資料框/矩陣（欄必須為 `numeric` 或 `factor`）。
* `maxiter` — 最大迭代次數（預設為 `10`）。
* `ntree` — 每個森林的樹數（預設為 `100`）。
* `mtry` — 每次分裂嘗試的變數數量（預設為 `sqrt(p)`）。
* `nodesize` — **長度為 2 的數值向量**：**c(numeric, factor)** 的最小節點大小。預設為 `c(5, 1)`。
* `variablewise` — 若為 `TRUE`，則回傳每個變數的 OOB 誤差。
* `parallelize` — `"no"`、`"variables"` 或 `"forests"`。
* `num.threads` — 給 `ranger` 用的執行緒數（`randomForest` 忽略此參數）。
* `backend` — `"ranger"`（預設）或 `"randomForest"`。
* `xtrue` — 可選的完整資料供**基準測試**（會增加 `$error` 欄位）。

`backend = "ranger"` 之參數對應關係：

* `ntree → num.trees`
* `nodesize → min.bucket`（回歸/分類分開設定；預設為 `c(5,1)`）
* `sampsize`（數量）→ `sample.fraction`（比例；可為整體或分群）
* `classwt → class.weights`
* `cutoff` 以**機率森林**擬合，並於後處理門檻

### 公用工具

* `mixError(ximp, xmis, xtrue)` — 計算真實缺失項的 **NRMSE**（數值）與 **PFC**（類別）。
* `nrmse(ximp, xmis, xtrue)` — 僅連續型資料的 NRMSE。
* `prodNA(x, noNA = 0.1)` — 向資料框注入 MCAR 缺失。
* `varClass(x)` — 回傳每欄 `"numeric"`/`"factor"`。

---

## 小技巧與最佳實踐


* 在呼叫 `missForest` 前，請將字元欄位轉換為因子（factors）。
* 對於寬型資料，建議使用 `parallelize = "variables"`；對於深度/高計算量的樹，建議使用 `parallelize = "forests"`。
* 設定隨機種子以獲得準可重現的結果：

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* 在原型設計階段，可以降低 `ntree` 以加快迭代速度。

---

## 引用

如果您使用 **missForest**，請引用：

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

您也可以引用此套件：

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