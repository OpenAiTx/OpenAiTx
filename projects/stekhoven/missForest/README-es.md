# missForest

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** es un método de imputación no paramétrico para datos tabulares de **tipos mixtos** en R. Maneja variables **numéricas y categóricas** simultáneamente entrenando de forma iterativa bosques aleatorios para predecir entradas faltantes a partir de las observadas. Sin supuestos explícitos de modelado, sin factorizaciones de matrices—solo bases predictivas sólidas que funcionan bien desde el inicio.

* Funciona con **cualquier combinación de columnas numéricas y de factores**
* Captura **no linealidades** e **interacciones**
* Reporta el error de imputación **fuera de bolsa (OOB)** (NRMSE/PFC)
* Soporta **ejecución paralela** (por variable o por bosque)
* Dos backends de bosque: **[`ranger`](https://cran.r-project.org/package=ranger)** (predeterminado) y **[`randomForest`](https://cran.r-project.org/package=randomForest)** (legado/compatibilidad)

El paquete también incluye utilidades para medir el error de imputación, generar datos faltantes para experimentos e inspeccionar tipos de variables.

---

## Instalación

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

### Elegir un backend

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Paralelización

Dos modos están disponibles a través de `parallelize`:

* `"variables"`: construir bosques para diferentes variables en paralelo (registrar un backend foreach).
* `"forests"`: paralelizar dentro del bosque de una sola variable (hilos de ranger; o sub-bosques foreach para randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```

---

## Descripción general de la API

### `missForest(xmis, ...)`

Función principal de imputación.

Argumentos clave:

* `xmis` — marco de datos/matriz con valores faltantes (las columnas deben ser `numeric` o `factor`).
* `maxiter` — iteraciones máximas (por defecto `10`).
* `ntree` — árboles por bosque (por defecto `100`).
* `mtry` — variables probadas en cada división (por defecto `sqrt(p)`).
* `nodesize` — **numérico de longitud 2**: tamaño mínimo del nodo para **c(numérico, factor)**. Por defecto `c(5, 1)`.
* `variablewise` — devuelve error OOB por variable si es `TRUE`.
* `parallelize` — `"no"`, `"variables"` o `"forests"`.
* `num.threads` — hilos para `ranger` (ignorado por `randomForest`).
* `backend` — `"ranger"` (por defecto) o `"randomForest"`.
* `xtrue` — datos completos opcionales para **benchmarking** (añade `$error`).

Algunos mapeos de argumentos para `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (separado para regresión/clasificación; por defecto `c(5,1)`)
* `sampsize` (conteos) → `sample.fraction` (fracciones; global o por clase)
* `classwt → class.weights`
* `cutoff` manejado ajustando **bosques de probabilidad** y umbralización posterior

### Utilidades

* `mixError(ximp, xmis, xtrue)` — calcula **NRMSE** (numérico) y **PFC** (factor) sobre entradas verdaderamente faltantes.
* `nrmse(ximp, xmis, xtrue)` — NRMSE para datos solo continuos.
* `prodNA(x, noNA = 0.1)` — introduce faltantes MCAR en un marco de datos.
* `varClass(x)` — devuelve `"numeric"`/`"factor"` por columna.

---

## Consejos y mejores prácticas

* Convierta las columnas de caracteres a factores antes de llamar a `missForest`.
* Para datos anchos, considere `parallelize = "variables"`. Para árboles profundos/costosos, considere `parallelize = "forests"`.
* Establezca una semilla para resultados cuasi-reproducibles:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Puedes reducir `ntree` durante la creación de prototipos para acelerar la iteración.

---

## Cita

Si usas **missForest**, por favor cita:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—imputación no paramétrica de valores faltantes para datos de tipo mixto.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

También puedes citar el paquete:

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