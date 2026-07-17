
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# missForest

<!-- badges: start -->

[![CRAN Status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio Mirror Downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio Mirror Downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-Check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** ist eine nichtparametrische Imputationsmethode für **gemischt-typische** tabellarische Daten in R. Sie verarbeitet **numerische und kategoriale** Variablen gleichzeitig, indem sie iterativ Random Forests trainiert, um fehlende Werte aus den beobachteten zu schätzen. Keine expliziten Modellannahmen, keine Matrixfaktorisierungen – nur starke prädiktive Baselines, die sofort funktionieren.

* Funktioniert mit **beliebigen Kombinationen aus numerischen und Faktor-Spalten**
* Erfasst **Nichtlinearitäten** und **Interaktionen**
* Gibt den **Out-of-Bag (OOB)** Imputationsfehler (NRMSE/PFC) aus
* Unterstützt **parallele Ausführung** (pro Variable oder pro Forest)
* Zwei Forest-Backends: **[`ranger`](https://cran.r-project.org/package=ranger)** (Standard) und **[`randomForest`](https://cran.r-project.org/package=randomForest)** (Legacy/Kompatibilität)

Das Paket enthält außerdem Werkzeuge zur Messung des Imputationsfehlers, zur Generierung von Missingness für Experimente und zur Inspektion von Variablentypen.

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

### Auswahl eines Backends

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Parallelisierung

Zwei Modi sind über `parallelize` verfügbar:

* `"variables"`: Erstellen Sie Wälder für verschiedene Variablen parallel (registrieren Sie ein foreach-Backend).
* `"forests"`: Parallelisierung innerhalb des Waldes einer einzelnen Variablen (ranger-Threads; oder foreach-Subwälder für randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## API-Übersicht

### `missForest(xmis, ...)`

Kern-Imputationsfunktion.

Wichtige Argumente:

* `xmis` — Datenrahmen/Matrix mit fehlenden Werten (Spalten müssen `numeric` oder `factor` sein).
* `maxiter` — maximale Iterationen (Standard `10`).
* `ntree` — Bäume pro Wald (Standard `100`).
* `mtry` — Variablen, die bei jedem Split versucht werden (Standard `sqrt(p)`).
* `nodesize` — **numeric der Länge 2**: minimale Knotengröße für **c(numeric, factor)**. Standard `c(5, 1)`.
* `variablewise` — gibt pro-Variable OOB-Fehler zurück, wenn `TRUE`.
* `parallelize` — `"no"`, `"variables"` oder `"forests"`.
* `num.threads` — Threads für `ranger` (wird von `randomForest` ignoriert).
* `backend` — `"ranger"` (Standard) oder `"randomForest"`.
* `xtrue` — optional vollständige Daten zum **Benchmarking** (fügt `$error` hinzu).

Einige Argument-Zuordnungen für `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (separat für Regression/Klassifikation; Standard `c(5,1)`)
* `sampsize` (Anzahlen) → `sample.fraction` (Bruchteile; insgesamt oder pro Klasse)
* `classwt → class.weights`
* `cutoff` wird durch Fitten von **Wahrscheinlichkeitswäldern** und anschließendes Thresholding behandelt

### Hilfsfunktionen

* `mixError(ximp, xmis, xtrue)` — berechnet **NRMSE** (numerisch) und **PFC** (Faktor) über die tatsächlich fehlenden Einträge.
* `nrmse(ximp, xmis, xtrue)` — NRMSE nur für kontinuierliche Daten.
* `prodNA(x, noNA = 0.1)` — injiziert MCAR-Missingness in einen Datenrahmen.
* `varClass(x)` — gibt `"numeric"`/`"factor"` pro Spalte zurück.

---

## Tipps & bewährte Methoden


* Wandeln Sie Zeichen-Spalten in Faktoren um, bevor Sie `missForest` aufrufen.
* Für breite Daten empfiehlt sich `parallelize = "variables"`. Für tiefe/aufwändige Bäume empfiehlt sich `parallelize = "forests"`.
* Setzen Sie einen Seed für quasi-reproduzierbare Ergebnisse:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Sie können `ntree` während der Prototypenerstellung reduzieren, um die Iteration zu beschleunigen.

---

## Zitation

Wenn Sie **missForest** verwenden, zitieren Sie bitte:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nichtparametrische Imputation fehlender Werte für gemischte Datentypen.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Sie können auch das Paket zitieren:

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