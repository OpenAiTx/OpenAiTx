
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

<!-- odznaki: start -->

[![Status CRAN](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![Pobrania CRAN RStudio ostatni miesiąc](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![Pobrania CRAN RStudio suma całkowita](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** to nieparametryczna metoda imputacji dla **danych tabelarycznych o mieszanych typach** w R. Obsługuje jednocześnie **zmienne numeryczne i kategoryczne**, iteracyjnie trenując lasy losowe do przewidywania brakujących wartości na podstawie zaobserwowanych. Brak jawnych założeń modelowych, brak faktoryzacji macierzy—tylko silne predykcyjne podstawy, które działają dobrze od razu.

* Działa z **dowolną kombinacją kolumn numerycznych i czynnikowych**
* Wychwytuje **nieliniowości** i **interakcje**
* Raportuje **błąd imputacji out-of-bag (OOB)** (NRMSE/PFC)
* Wspiera **wykonywanie równoległe** (na zmienną lub na las)
* Dwa silniki lasu: **[`ranger`](https://cran.r-project.org/package=ranger)** (domyślny) oraz **[`randomForest`](https://cran.r-project.org/package=randomForest)** (starszy/zgodność)

Pakiet zawiera także narzędzia do pomiaru błędu imputacji, generowania braków na potrzeby eksperymentów oraz inspekcji typów zmiennych.

---

## Instalacja

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

### Wybór backendu

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Równoległość

Dostępne są dwa tryby poprzez `parallelize`:

* `"variables"`: budowanie lasów dla różnych zmiennych równolegle (zarejestruj backend foreach).
* `"forests"`: równoległość w obrębie lasu pojedynczej zmiennej (wątki ranger; lub pod-lasy foreach dla randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## Przegląd API

### `missForest(xmis, ...)`

Główna funkcja imputacji.

Kluczowe argumenty:

* `xmis` — ramka danych/macierz z brakującymi wartościami (kolumny muszą być typu `numeric` lub `factor`).
* `maxiter` — maksymalna liczba iteracji (domyślnie `10`).
* `ntree` — liczba drzew w lesie (domyślnie `100`).
* `mtry` — liczba zmiennych próbowanych przy każdym podziale (domyślnie `sqrt(p)`).
* `nodesize` — **wektor długości 2 typu numerycznego**: minimalna wielkość węzła dla **c(numeric, factor)**. Domyślnie `c(5, 1)`.
* `variablewise` — zwraca błąd OOB dla każdej zmiennej, jeśli `TRUE`.
* `parallelize` — `"no"`, `"variables"` lub `"forests"`.
* `num.threads` — liczba wątków dla `ranger` (ignorowana przez `randomForest`).
* `backend` — `"ranger"` (domyślnie) lub `"randomForest"`.
* `xtrue` — opcjonalny kompletny zbiór danych do **benchmarkingu** (dodaje `$error`).

Mapowania argumentów dla `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (osobno dla regresji/klasyfikacji; domyślnie `c(5,1)`)
* `sampsize` (liczby) → `sample.fraction` (ułamki; całościowo lub dla każdej klasy)
* `classwt → class.weights`
* `cutoff` obsługiwany przez dopasowanie **probability forests** i post-thresholding

### Narzędzia pomocnicze

* `mixError(ximp, xmis, xtrue)` — oblicza **NRMSE** (numeryczne) i **PFC** (faktoryzowane) dla prawdziwych brakujących wartości.
* `nrmse(ximp, xmis, xtrue)` — NRMSE tylko dla danych ciągłych.
* `prodNA(x, noNA = 0.1)` — wprowadza brakujące wartości MCAR do ramki danych.
* `varClass(x)` — zwraca `"numeric"`/`"factor"` dla każdej kolumny.

---

## Porady i najlepsze praktyki


* Przekształć kolumny znakowe na czynniki przed wywołaniem `missForest`.
* Dla szerokich danych rozważ `parallelize = "variables"`. Dla głębokich/kosztownych drzew rozważ `parallelize = "forests"`.
* Ustaw ziarno dla quasi-powtarzalnych wyników:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Możesz obniżyć wartość `ntree` podczas prototypowania, aby przyspieszyć iterację.

---

## Cytowanie

Jeśli korzystasz z **missForest**, prosimy o cytowanie:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nieparametryczna imputacja brakujących wartości dla danych mieszanych typów.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Możesz również zacytować pakiet:

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