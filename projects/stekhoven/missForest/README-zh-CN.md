# missForest

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** 是 R 中用于 **混合类型** 表格数据的非参数插补方法。它通过迭代训练随机森林，从已观测的数据中预测缺失项，能够同时处理 **数值型和分类型** 变量。无需显式建模假设，无需矩阵分解——只是强大的预测基线，开箱即用，表现优异。

* 适用于 **任意混合的数值和因子列**
* 捕捉 **非线性** 和 **交互作用**
* 报告 **袋外（OOB）** 插补误差（NRMSE/PFC）
* 支持 **并行执行**（按变量或按森林）
* 两种森林后端：**[`ranger`](https://cran.r-project.org/package=ranger)**（默认）和 **[`randomForest`](https://cran.r-project.org/package=randomForest)**（传统/兼容）

该包还包括用于衡量插补误差、生成缺失数据进行实验以及检查变量类型的实用工具。

---

## 安装

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

### 选择后端

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### 并行化

通过 `parallelize` 提供两种模式：

* `"variables"`：为不同变量并行构建森林（注册 foreach 后端）。
* `"forests"`：在单个变量的森林内进行并行（ranger 线程；或 randomForest 的 foreach 子森林）。

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```

---

## API 概述

### `missForest(xmis, ...)`

核心插补函数。

主要参数：

* `xmis` — 含缺失值的数据框/矩阵（列必须为 `numeric` 或 `factor`）。
* `maxiter` — 最大迭代次数（默认 `10`）。
* `ntree` — 每个森林的树数（默认 `100`）。
* `mtry` — 每次分裂尝试的变量数（默认 `sqrt(p)`）。
* `nodesize` — **长度为2的数值**：最小节点大小，分别用于 **c(数值型, 因子型)**。默认 `c(5, 1)`。
* `variablewise` — 若为 `TRUE`，返回每变量的 OOB 误差。
* `parallelize` — `"no"`、`"variables"` 或 `"forests"`。
* `num.threads` — `ranger` 的线程数（`randomForest` 忽略）。
* `backend` — `"ranger"`（默认）或 `"randomForest"`。
* `xtrue` — 可选的完整数据，用于**基准测试**（添加 `$error`）。

`backend = "ranger"` 的部分参数映射：

* `ntree → num.trees`
* `nodesize → min.bucket`（分别用于回归/分类；默认 `c(5,1)`）
* `sampsize`（计数）→ `sample.fraction`（比例；整体或按类别）
* `classwt → class.weights`
* `cutoff` 通过拟合**概率森林**并后置阈值处理

### 工具函数

* `mixError(ximp, xmis, xtrue)` — 计算真实缺失条目上的**NRMSE**（数值）和**PFC**（因子）。
* `nrmse(ximp, xmis, xtrue)` — 仅对连续数据计算 NRMSE。
* `prodNA(x, noNA = 0.1)` — 向数据框注入 MCAR 缺失。
* `varClass(x)` — 返回每列的 `"numeric"`/`"factor"` 类型。

---

## 使用建议与最佳实践

* 在调用 `missForest` 之前将字符列转换为因子。
* 对于宽数据，考虑使用 `parallelize = "variables"`。对于深度/计算量大的树，考虑使用 `parallelize = "forests"`。
* 设置种子以获得准可重复的结果：

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* 你可以在原型设计阶段降低 `ntree` 来加快迭代速度。

---

## 引用

如果你使用 **missForest**，请引用：

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—混合类型数据的非参数缺失值插补方法。* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

你也可以引用该包：

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