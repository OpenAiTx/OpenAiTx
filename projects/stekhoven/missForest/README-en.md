# missForest

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** is a nonparametric imputation method for **mixed-type** tabular data in R. It handles **numeric and categorical** variables simultaneously by iteratively training random forests to predict missing entries from the observed ones. No explicit modeling assumptions, no matrix factorizations—just strong predictive baselines that work well out of the box.

* Works with **any mix of numeric and factor columns**
* Captures **nonlinearities** and **interactions**
* Reports **out-of-bag (OOB)** imputation error (NRMSE/PFC)
* Supports **parallel execution** (per-variable or per-forest)
* Two forest backends: **[`ranger`](https://cran.r-project.org/package=ranger)** (default) and **[`randomForest`](https://cran.r-project.org/package=randomForest)** (legacy/compat)

The package also includes utilities to measure imputation error, generate missingness for experiments, and inspect variable types.

---

## Installation

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

### Choosing a backend

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Parallelization

Two modes are available via `parallelize`:

* `"variables"`: build forests for different variables in parallel (register a foreach backend).
* `"forests"`: parallelize within a single variable’s forest (ranger threads; or foreach sub-forests for randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```

---

## API overview

### `missForest(xmis, ...)`

Core imputation function.

Key arguments:

* `xmis` — data frame/matrix with missing values (columns must be `numeric` or `factor`).
* `maxiter` — maximum iterations (default `10`).
* `ntree` — trees per forest (default `100`).
* `mtry` — variables tried at each split (default `sqrt(p)`).
* `nodesize` — **length-2 numeric**: minimum node size for **c(numeric, factor)**. Default `c(5, 1)`.
* `variablewise` — return per-variable OOB error if `TRUE`.
* `parallelize` — `"no"`, `"variables"`, or `"forests"`.
* `num.threads` — threads for `ranger` (ignored by `randomForest`).
* `backend` — `"ranger"` (default) or `"randomForest"`.
* `xtrue` — optional complete data for **benchmarking** (adds `$error`).

Some argument mappings for `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (separately for regression/classification; default `c(5,1)`)
* `sampsize` (counts) → `sample.fraction` (fractions; overall or per-class)
* `classwt → class.weights`
* `cutoff` handled by fitting **probability forests** and post-thresholding

### Utilities

* `mixError(ximp, xmis, xtrue)` — computes **NRMSE** (numeric) and **PFC** (factor) over true missing entries.
* `nrmse(ximp, xmis, xtrue)` — NRMSE for continuous-only data.
* `prodNA(x, noNA = 0.1)` — injects MCAR missingness into a data frame.
* `varClass(x)` — returns `"numeric"`/`"factor"` per column.

---

## Tips & best practices

* Convert character columns to factors before calling `missForest`.
* For wide data, consider `parallelize = "variables"`. For deep/expensive trees, consider `parallelize = "forests"`.
* Set a seed for quasi-reproducible results:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* You can lower `ntree` during prototyping to speed up iteration.

---

## Citation

If you use **missForest**, please cite:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

You can also cite the package:

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