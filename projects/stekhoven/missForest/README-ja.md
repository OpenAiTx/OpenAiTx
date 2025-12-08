# missForest

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** は、Rにおける**混合型**表形式データの非パラメトリックな補完手法です。数値変数とカテゴリ変数を同時に扱い、観測データから欠損値を予測するランダムフォレストを反復的に学習させます。明示的なモデル仮定や行列分解は不要で、すぐに使える強力な予測ベースラインを提供します。

* **数値列と因子列の任意の組み合わせ**に対応
* **非線形性**と**相互作用**を捉える
* **アウト・オブ・バッグ（OOB）**補完誤差（NRMSE/PFC）を報告
* **並列実行**をサポート（変数単位または森林単位）
* 2つのフォレストバックエンド：**[`ranger`](https://cran.r-project.org/package=ranger)**（デフォルト）と**[`randomForest`](https://cran.r-project.org/package=randomForest)**（旧版/互換）

このパッケージには、補完誤差の測定、実験用の欠損生成、変数型の検査に役立つユーティリティも含まれています。

---

## インストール

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

### バックエンドの選択

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### 並列化

`parallelize` には2つのモードがあります：

* `"variables"`：異なる変数のために並行してフォレストを構築します（foreachバックエンドを登録）。
* `"forests"`：単一変数のフォレスト内で並列化します（rangerのスレッド、またはrandomForestのforeachサブフォレスト）。

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```

---

## API概要

### `missForest(xmis, ...)`

コアの補完関数。

主な引数:

* `xmis` — 欠損値を含むデータフレーム/マトリクス（列は `numeric` または `factor` でなければならない）。
* `maxiter` — 最大反復回数（デフォルトは `10`）。
* `ntree` — 森あたりの木の数（デフォルトは `100`）。
* `mtry` — 各分割で試す変数の数（デフォルトは `sqrt(p)`）。
* `nodesize` — **長さ2の数値ベクトル**：**c(numeric, factor)** に対する最小ノードサイズ。デフォルトは `c(5, 1)`。
* `variablewise` — `TRUE` の場合、変数ごとのOOB誤差を返す。
* `parallelize` — `"no"`、`"variables"`、または `"forests"`。
* `num.threads` — `ranger` 用のスレッド数（`randomForest` では無視される）。
* `backend` — `"ranger"`（デフォルト）または `"randomForest"`。
* `xtrue` — **ベンチマーク用**の完全なデータ（`$error` を追加）。

`backend = "ranger"` の引数対応例:

* `ntree → num.trees`
* `nodesize → min.bucket`（回帰/分類で別々に；デフォルトは `c(5,1)`）
* `sampsize`（カウント）→ `sample.fraction`（割合；全体またはクラスごと）
* `classwt → class.weights`
* `cutoff` は確率フォレストを学習し、閾値処理で対応

### ユーティリティ

* `mixError(ximp, xmis, xtrue)` — 真の欠損箇所に対する **NRMSE**（数値）と **PFC**（因子）を計算。
* `nrmse(ximp, xmis, xtrue)` — 連続値のみのデータに対するNRMSE。
* `prodNA(x, noNA = 0.1)` — データフレームにMCAR欠損を注入。
* `varClass(x)` — 列ごとに `"numeric"`/`"factor"` を返す。

---

## ヒントとベストプラクティス

* `missForest`を呼び出す前に、文字列の列を因子に変換します。
* ワイドデータの場合は`parallelize = "variables"`を検討してください。深いまたは計算コストの高い木の場合は`parallelize = "forests"`を検討してください。
* 準再現性のある結果を得るためにシードを設定します：

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* プロトタイピング中は反復を高速化するために `ntree` を下げることができます。

---

## 引用

**missForest** を使用する場合は、以下を引用してください：

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—混合型データのための非パラメトリック欠損値補完手法.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

パッケージ自体を引用することもできます：

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-08

---