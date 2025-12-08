# missForest

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest**는 R에서 **혼합형** 표 형식 데이터에 대한 비모수적 대체법입니다. 관측된 데이터를 바탕으로 누락된 항목을 예측하기 위해 랜덤 포레스트를 반복적으로 학습시켜 **수치형과 범주형** 변수를 동시에 처리합니다. 명시적인 모델링 가정이나 행렬 분해 없이—그냥 바로 잘 작동하는 강력한 예측 기반 방법입니다.

* **수치형과 팩터 열의 어떤 조합**도 처리 가능
* **비선형성**과 **상호작용**을 포착
* **외부표본(out-of-bag, OOB)** 대체 오류(NRMSE/PFC)를 보고
* **병렬 실행** 지원 (변수별 또는 포레스트별)
* 두 가지 포레스트 백엔드: 기본은 **[`ranger`](https://cran.r-project.org/package=ranger)**, 그리고 레거시/호환용 **[`randomForest`](https://cran.r-project.org/package=randomForest)**

패키지에는 대체 오류 측정, 실험용 누락 데이터 생성, 변수 유형 검사 유틸리티도 포함되어 있습니다.

---

## 설치

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

### 백엔드 선택하기

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```
### 병렬화

`parallelize`를 통해 두 가지 모드를 사용할 수 있습니다:

* `"variables"`: 서로 다른 변수에 대해 병렬로 숲을 구축합니다 (foreach 백엔드 등록).
* `"forests"`: 단일 변수의 숲 내에서 병렬화합니다 (ranger 스레드; 또는 randomForest의 foreach 하위 숲).


```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```

---

## API 개요

### `missForest(xmis, ...)`

핵심 보간 함수.

주요 인자:

* `xmis` — 결측치가 있는 데이터 프레임/행렬 (열은 `numeric` 또는 `factor`여야 함).
* `maxiter` — 최대 반복 횟수 (기본값 `10`).
* `ntree` — 숲당 트리 수 (기본값 `100`).
* `mtry` — 각 분할 시 시도할 변수 수 (기본값 `sqrt(p)`).
* `nodesize` — **길이 2의 숫자형 벡터**: **c(numeric, factor)**에 대한 최소 노드 크기. 기본값 `c(5, 1)`.
* `variablewise` — `TRUE`일 경우 변수별 OOB 오류 반환.
* `parallelize` — `"no"`, `"variables"`, 또는 `"forests"`.
* `num.threads` — `ranger`용 스레드 수 (`randomForest`에서는 무시됨).
* `backend` — `"ranger"` (기본값) 또는 `"randomForest"`.
* `xtrue` — 선택적 완전 데이터 (벤치마킹용, `$error` 추가).

`backend = "ranger"`용 인자 매핑 일부:

* `ntree → num.trees`
* `nodesize → min.bucket` (회귀/분류 별도; 기본값 `c(5,1)`)
* `sampsize` (개수) → `sample.fraction` (비율; 전체 또는 클래스별)
* `classwt → class.weights`
* `cutoff`는 확률 숲을 적합시키고 후처리 임계값 적용으로 처리

### 유틸리티

* `mixError(ximp, xmis, xtrue)` — 진짜 결측치 위치에 대해 **NRMSE**(연속형) 및 **PFC**(범주형) 계산.
* `nrmse(ximp, xmis, xtrue)` — 연속형 데이터에 대한 NRMSE.
* `prodNA(x, noNA = 0.1)` — MCAR 결측치를 데이터 프레임에 주입.
* `varClass(x)` — 열별 `"numeric"`/`"factor"` 반환.

---

## 팁 및 모범 사례

* `missForest`를 호출하기 전에 문자형 열을 팩터로 변환하세요.
* 넓은 데이터의 경우 `parallelize = "variables"`를 고려하세요. 깊거나 비용이 많이 드는 트리의 경우 `parallelize = "forests"`를 고려하세요.
* 준재현 가능한 결과를 위해 시드를 설정하세요:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* 프로토타입 제작 시 반복 속도를 높이기 위해 `ntree` 값을 낮출 수 있습니다.

---

## 인용

**missForest**를 사용하신 경우, 다음을 인용해 주세요:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—비모수적 결측값 대체 방법, 혼합형 데이터용.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

패키지 자체도 인용할 수 있습니다:

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