# missForest

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** est une méthode d'imputation non paramétrique pour les données tabulaires de **type mixte** dans R. Elle gère simultanément les variables **numériques et catégorielles** en entraînant itérativement des forêts aléatoires pour prédire les valeurs manquantes à partir des valeurs observées. Aucune hypothèse de modélisation explicite, pas de factorisation de matrice—juste des bases prédictives solides qui fonctionnent bien dès le départ.

* Fonctionne avec **n'importe quelle combinaison de colonnes numériques et factorielles**
* Capture les **non-linéarités** et les **interactions**
* Fournit une estimation de l'erreur d'imputation **hors échantillon (OOB)** (NRMSE/PFC)
* Supporte l’**exécution parallèle** (par variable ou par forêt)
* Deux moteurs de forêt : **[`ranger`](https://cran.r-project.org/package=ranger)** (par défaut) et **[`randomForest`](https://cran.r-project.org/package=randomForest)** (héritage/compatibilité)

Le package inclut également des utilitaires pour mesurer l'erreur d'imputation, générer des données manquantes pour les expériences, et inspecter les types de variables.

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

### Choisir un backend

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Parallélisation

Deux modes sont disponibles via `parallelize` :

* `"variables"` : construire des forêts pour différentes variables en parallèle (enregistrer un backend foreach).
* `"forests"` : paralléliser au sein de la forêt d’une seule variable (threads ranger ; ou sous-forêts foreach pour randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```

---

## Vue d'ensemble de l'API

### `missForest(xmis, ...)`

Fonction principale d'imputation.

Arguments clés :

* `xmis` — data frame/matrice avec valeurs manquantes (les colonnes doivent être `numeric` ou `factor`).
* `maxiter` — nombre maximal d'itérations (par défaut `10`).
* `ntree` — arbres par forêt (par défaut `100`).
* `mtry` — variables essayées à chaque division (par défaut `sqrt(p)`).
* `nodesize` — **numérique de longueur 2** : taille minimale des nœuds pour **c(numérique, facteur)**. Par défaut `c(5, 1)`.
* `variablewise` — retourne l'erreur OOB par variable si `TRUE`.
* `parallelize` — `"no"`, `"variables"`, ou `"forests"`.
* `num.threads` — threads pour `ranger` (ignoré par `randomForest`).
* `backend` — `"ranger"` (par défaut) ou `"randomForest"`.
* `xtrue` — données complètes optionnelles pour **benchmark** (ajoute `$error`).

Quelques correspondances d'arguments pour `backend = "ranger"` :

* `ntree → num.trees`
* `nodesize → min.bucket` (séparément pour régression/classification ; par défaut `c(5,1)`)
* `sampsize` (comptes) → `sample.fraction` (fractions ; global ou par classe)
* `classwt → class.weights`
* `cutoff` géré en ajustant des **forêts de probabilité** puis post-seuillage

### Utilitaires

* `mixError(ximp, xmis, xtrue)` — calcule le **NRMSE** (numérique) et le **PFC** (facteur) sur les entrées manquantes réelles.
* `nrmse(ximp, xmis, xtrue)` — NRMSE pour données uniquement continues.
* `prodNA(x, noNA = 0.1)` — injecte des valeurs manquantes MCAR dans un data frame.
* `varClass(x)` — retourne `"numeric"`/`"factor"` par colonne.

---

## Conseils & bonnes pratiques

* Convertir les colonnes de caractères en facteurs avant d'appeler `missForest`.
* Pour les données larges, envisager `parallelize = "variables"`. Pour les arbres profonds/coûteux, envisager `parallelize = "forests"`.
* Définir une graine pour des résultats quasi-reproductibles :

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Vous pouvez réduire `ntree` lors du prototypage pour accélérer les itérations.

---

## Citation

Si vous utilisez **missForest**, veuillez citer :

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—imputation non paramétrique des valeurs manquantes pour des données de type mixte.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Vous pouvez également citer le package :

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