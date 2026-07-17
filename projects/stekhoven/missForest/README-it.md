
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

<!-- badge: inizio -->

[![Stato CRAN](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![Download CRAN RStudio ultimo mese](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![Download CRAN RStudio totale](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** è un metodo di imputazione non parametrico per dati tabellari **a tipi misti** in R. Gestisce **variabili numeriche e categoriche** simultaneamente, addestrando iterativamente foreste casuali per prevedere le voci mancanti da quelle osservate. Nessuna assunzione esplicita di modellizzazione, nessuna fattorizzazione di matrici—solo solide basi predittive che funzionano immediatamente.

* Funziona con **qualsiasi combinazione di colonne numeriche e fattoriali**
* Cattura **nonlinearità** e **interazioni**
* Riporta l'errore di imputazione **out-of-bag (OOB)** (NRMSE/PFC)
* Supporta **esecuzione parallela** (per variabile o per foresta)
* Due backend di foresta: **[`ranger`](https://cran.r-project.org/package=ranger)** (predefinito) e **[`randomForest`](https://cran.r-project.org/package=randomForest)** (legacy/compatibile)

Il pacchetto include anche utilità per misurare l'errore di imputazione, generare dati mancanti per esperimenti e ispezionare i tipi di variabili.

---

## Installazione

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

### Scegliere un backend

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Parallelizzazione

Sono disponibili due modalità tramite `parallelize`:

* `"variables"`: costruisce foreste per variabili diverse in parallelo (registrare un backend foreach).
* `"forests"`: parallelizza all'interno della foresta di una singola variabile (thread ranger; oppure foreach sotto-foreste per randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## Panoramica API

### `missForest(xmis, ...)`

Funzione principale di imputazione.

Argomenti chiave:

* `xmis` — data frame/matrice con valori mancanti (le colonne devono essere `numeric` o `factor`).
* `maxiter` — iterazioni massime (default `10`).
* `ntree` — alberi per foresta (default `100`).
* `mtry` — variabili provate a ogni split (default `sqrt(p)`).
* `nodesize` — **numerico di lunghezza 2**: dimensione minima nodo per **c(numeric, factor)**. Default `c(5, 1)`.
* `variablewise` — restituisce errore OOB per variabile se `TRUE`.
* `parallelize` — `"no"`, `"variables"`, o `"forests"`.
* `num.threads` — thread per `ranger` (ignorato da `randomForest`).
* `backend` — `"ranger"` (default) o `"randomForest"`.
* `xtrue` — dati completi opzionali per **benchmarking** (aggiunge `$error`).

Alcune mappature di argomenti per `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (separatamente per regressione/classificazione; default `c(5,1)`)
* `sampsize` (conteggi) → `sample.fraction` (frazioni; complessivo o per classe)
* `classwt → class.weights`
* `cutoff` gestito tramite fit di **probability forests** e post-thresholding

### Utility

* `mixError(ximp, xmis, xtrue)` — calcola **NRMSE** (numerico) e **PFC** (fattore) sulle vere entry mancanti.
* `nrmse(ximp, xmis, xtrue)` — NRMSE solo per dati continui.
* `prodNA(x, noNA = 0.1)` — inietta mancanza MCAR in un data frame.
* `varClass(x)` — restituisce `"numeric"`/`"factor"` per colonna.

---

## Suggerimenti & best practice


* Converti le colonne di tipo carattere in fattori prima di chiamare `missForest`.
* Per dati ampi, considera `parallelize = "variables"`. Per alberi profondi/costosi, considera `parallelize = "forests"`.
* Imposta un seed per risultati quasi riproducibili:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Puoi ridurre `ntree` durante la fase di prototipazione per velocizzare le iterazioni.

---

## Citazione

Se utilizzi **missForest**, cita:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Puoi anche citare il pacchetto:

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