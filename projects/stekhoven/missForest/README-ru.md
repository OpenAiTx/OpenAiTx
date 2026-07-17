
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

<!-- значки: начало -->

[![Статус CRAN](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![Загрузки CRAN RStudio за последний месяц](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![Общее количество загрузок CRAN RStudio](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** — непараметрический метод импутации для **смешанных типов** табличных данных в R. Он одновременно обрабатывает **числовые и категориальные** переменные, итеративно обучая случайные леса для предсказания пропущенных значений на основе имеющихся. Без явных модельных предположений, без матричных факторизаций — только сильные предсказательные базовые алгоритмы, которые хорошо работают из коробки.

* Работает с **любым сочетанием числовых и факторных столбцов**
* Учитывает **нелинейности** и **взаимодействия**
* Показывает **ошибку импутации out-of-bag (OOB)** (NRMSE/PFC)
* Поддерживает **параллельное выполнение** (по переменной или по лесу)
* Два движка леса: **[`ranger`](https://cran.r-project.org/package=ranger)** (по умолчанию) и **[`randomForest`](https://cran.r-project.org/package=randomForest)** (устаревший/совместимый)

Пакет также содержит утилиты для оценки ошибки импутации, генерации пропусков для экспериментов и анализа типов переменных.

---

## Установка

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

### Выбор серверной части

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Параллелизация

Доступны два режима через `parallelize`:

* `"variables"`: построение лесов для разных переменных параллельно (зарегистрировать backend foreach).
* `"forests"`: параллелизация внутри леса одной переменной (потоки ranger; или подлеса foreach для randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## Обзор API

### `missForest(xmis, ...)`

Основная функция импутации.

Ключевые аргументы:

* `xmis` — data frame/матрица с пропущенными значениями (столбцы должны быть `numeric` или `factor`).
* `maxiter` — максимальное количество итераций (по умолчанию `10`).
* `ntree` — количество деревьев в каждом лесу (по умолчанию `100`).
* `mtry` — количество переменных для каждого разбиения (по умолчанию `sqrt(p)`).
* `nodesize` — **числовой длины 2**: минимальный размер узла для **c(numeric, factor)**. По умолчанию `c(5, 1)`.
* `variablewise` — возвращает ошибку OOB для каждой переменной, если `TRUE`.
* `parallelize` — `"no"`, `"variables"`, или `"forests"`.
* `num.threads` — количество потоков для `ranger` (игнорируется в `randomForest`).
* `backend` — `"ranger"` (по умолчанию) или `"randomForest"`.
* `xtrue` — необязательные полные данные для **бенчмаркинга** (добавляет `$error`).

Некоторые соответствия аргументов для `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (отдельно для регрессии/классификации; по умолчанию `c(5,1)`)
* `sampsize` (количество) → `sample.fraction` (доли; общая или по классам)
* `classwt → class.weights`
* `cutoff` реализуется путем обучения **лесов вероятностей** и пост-пороговой обработки

### Утилиты

* `mixError(ximp, xmis, xtrue)` — вычисляет **NRMSE** (numeric) и **PFC** (factor) по истинно пропущенным значениям.
* `nrmse(ximp, xmis, xtrue)` — NRMSE только для непрерывных данных.
* `prodNA(x, noNA = 0.1)` — добавляет MCAR пропуски в data frame.
* `varClass(x)` — возвращает `"numeric"`/`"factor"` для каждого столбца.

---

## Советы и лучшие практики


* Преобразуйте столбцы с символами в факторы перед вызовом `missForest`.
* Для широких данных используйте `parallelize = "variables"`. Для глубоких/дорогостоящих деревьев используйте `parallelize = "forests"`.
* Установите seed для квази-воспроизводимых результатов:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Вы можете уменьшить значение `ntree` во время прототипирования для ускорения итераций.

---

## Цитирование

Если вы используете **missForest**, пожалуйста, цитируйте:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—непараметрическая импутация пропущенных значений для данных смешанного типа.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Вы также можете сослаться на пакет:

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