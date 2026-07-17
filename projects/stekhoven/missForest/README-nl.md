
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# missForest

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** is een niet-parametrische imputatiemethode voor **gemengde type** tabelgegevens in R. Het verwerkt **numerieke en categorische** variabelen gelijktijdig door iteratief random forests te trainen om ontbrekende waarden te voorspellen op basis van de waargenomen gegevens. Geen expliciete modelaannames, geen matrixfactorisaties—alleen sterke voorspellende baselines die direct goed werken.

* Werkt met **elke mix van numerieke en factor kolommen**
* Vangt **nonlineariteiten** en **interacties**
* Rapporteert **out-of-bag (OOB)** imputeerfout (NRMSE/PFC)
* Ondersteunt **parallelle uitvoering** (per-variabele of per-bos)
* Twee forest backends: **[`ranger`](https://cran.r-project.org/package=ranger)** (standaard) en **[`randomForest`](https://cran.r-project.org/package=randomForest)** (legacy/compat)

Het pakket bevat ook hulpmiddelen om imputeerfouten te meten, ontbrekendheid te genereren voor experimenten, en variabeltypes te inspecteren.

---

## Installatie

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

### Een backend kiezen

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Parallelisatie

Er zijn twee modi beschikbaar via `parallelize`:

* `"variables"`: bouw bossen voor verschillende variabelen parallel (registreer een foreach-backend).
* `"forests"`: paralleliseer binnen het bos van één enkele variabele (ranger-threads; of foreach sub-bossen voor randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## API-overzicht

### `missForest(xmis, ...)`

Kernimputatiefunctie.

Belangrijkste argumenten:

* `xmis` — data frame/matrix met ontbrekende waarden (kolommen moeten `numeric` of `factor` zijn).
* `maxiter` — maximum aantal iteraties (standaard `10`).
* `ntree` — bomen per bos (standaard `100`).
* `mtry` — aantal variabelen geprobeerd bij elke splitsing (standaard `sqrt(p)`).
* `nodesize` — **length-2 numeriek**: minimale knoopgrootte voor **c(numeric, factor)**. Standaard `c(5, 1)`.
* `variablewise` — geeft per-variabele OOB-fout terug als `TRUE`.
* `parallelize` — `"no"`, `"variables"` of `"forests"`.
* `num.threads` — threads voor `ranger` (genegeerd door `randomForest`).
* `backend` — `"ranger"` (standaard) of `"randomForest"`.
* `xtrue` — optionele volledige data voor **benchmarking** (voegt `$error` toe).

Enkele argument-mappingen voor `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (apart voor regressie/classificatie; standaard `c(5,1)`)
* `sampsize` (aantallen) → `sample.fraction` (fracties; algemeen of per klasse)
* `classwt → class.weights`
* `cutoff` wordt afgehandeld door het trainen van **probability forests** en post-thresholding

### Hulpprogramma's

* `mixError(ximp, xmis, xtrue)` — berekent **NRMSE** (numeriek) en **PFC** (factor) over echte ontbrekende waarden.
* `nrmse(ximp, xmis, xtrue)` — NRMSE voor alleen continue data.
* `prodNA(x, noNA = 0.1)` — voegt MCAR-missingness toe aan een data frame.
* `varClass(x)` — retourneert `"numeric"`/`"factor"` per kolom.

---

## Tips & beste praktijken


* Zet karakterkolommen om naar factoren voordat je `missForest` aanroept.
* Voor brede data, overweeg `parallelize = "variables"`. Voor diepe/kostbare bomen, overweeg `parallelize = "forests"`.
* Stel een seed in voor quasi-reproduceerbare resultaten:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Je kunt `ntree` verlagen tijdens het prototypen om de iteratie te versnellen.

---

## Citaat

Als je **missForest** gebruikt, citeer dan:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Je kunt ook het pakket citeren:

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