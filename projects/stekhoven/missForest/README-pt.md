
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** é um método de imputação não paramétrico para dados tabulares de **tipos mistos** em R. Ele lida com variáveis **numéricas e categóricas** simultaneamente, treinando iterativamente florestas aleatórias para prever valores ausentes a partir dos observados. Sem suposições explícitas de modelagem, sem fatorações de matrizes—apenas fortes bases preditivas que funcionam bem imediatamente.

* Funciona com **qualquer combinação de colunas numéricas e fator**
* Captura **não linearidades** e **interações**
* Reporta o erro de imputação **out-of-bag (OOB)** (NRMSE/PFC)
* Suporta **execução paralela** (por variável ou por floresta)
* Dois backends de floresta: **[`ranger`](https://cran.r-project.org/package=ranger)** (padrão) e **[`randomForest`](https://cran.r-project.org/package=randomForest)** (legado/compatibilidade)

O pacote também inclui utilitários para medir o erro de imputação, gerar dados ausentes para experimentos e inspecionar tipos de variáveis.

---

## Instalação

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

### Escolhendo um backend

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Paralelização

Dois modos estão disponíveis via `parallelize`:

* `"variables"`: constrói florestas para diferentes variáveis em paralelo (registre um backend foreach).
* `"forests"`: paraleliza dentro da floresta de uma única variável (threads do ranger; ou sub-florestas foreach para randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## Visão geral da API

### `missForest(xmis, ...)`

Função principal de imputação.

Principais argumentos:

* `xmis` — data frame/matriz com valores ausentes (colunas devem ser `numeric` ou `factor`).
* `maxiter` — iterações máximas (padrão `10`).
* `ntree` — árvores por floresta (padrão `100`).
* `mtry` — variáveis testadas em cada divisão (padrão `sqrt(p)`).
* `nodesize` — **vetor numérico de tamanho 2**: tamanho mínimo do nó para **c(numeric, factor)**. Padrão `c(5, 1)`.
* `variablewise` — retorna erro OOB por variável se `TRUE`.
* `parallelize` — `"no"`, `"variables"` ou `"forests"`.
* `num.threads` — threads para `ranger` (ignorado pelo `randomForest`).
* `backend` — `"ranger"` (padrão) ou `"randomForest"`.
* `xtrue` — dados completos opcionais para **benchmarking** (adiciona `$error`).

Alguns mapeamentos de argumentos para `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (separado para regressão/classificação; padrão `c(5,1)`)
* `sampsize` (contagens) → `sample.fraction` (frações; geral ou por classe)
* `classwt → class.weights`
* `cutoff` tratado ajustando **probability forests** e pós-thresholding

### Utilitários

* `mixError(ximp, xmis, xtrue)` — calcula **NRMSE** (numérico) e **PFC** (fatorial) sobre entradas ausentes reais.
* `nrmse(ximp, xmis, xtrue)` — NRMSE apenas para dados contínuos.
* `prodNA(x, noNA = 0.1)` — injeta ausência MCAR em um data frame.
* `varClass(x)` — retorna `"numeric"`/`"factor"` por coluna.

---

## Dicas & melhores práticas


* Converta colunas de caracteres em fatores antes de chamar `missForest`.
* Para dados amplos, considere `parallelize = "variables"`. Para árvores profundas/caros, considere `parallelize = "forests"`.
* Defina uma semente para resultados quase reprodutíveis:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Você pode reduzir o valor de `ntree` durante a prototipagem para acelerar as iterações.

---

## Citação

Se você usar o **missForest**, por favor cite:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Você também pode citar o pacote:

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