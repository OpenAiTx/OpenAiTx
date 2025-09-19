warbleR: 생물음향 분석 간소화
================

<!-- README.md는 README.Rmd에서 생성됩니다. 해당 파일을 편집하세요 -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![Dependencies](https://tinyverse.netlify.com/badge/warbleR)](https://cran.r-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licence](https://img.shields.io/badge/licence-GPL--2-blue.svg)](https://www.gnu.org/licenses/gpl-3.0.en.html)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
[![R-CMD-check](https://github.com/maRce10/warbleR/workflows/R-CMD-check/badge.svg)](https://github.com/ropensci/baRulho/actions/workflows/R-CMD-check.yaml)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR)는
R에서 동물 음향 신호 구조 분석을
용이하게 하기 위해 설계되었습니다. 사용자는 공개 접근 조류 녹음을 수집하거나 자신만의
데이터를 입력하여 스펙트로그램 시각화 및
음향 매개변수 측정을 지원하는 워크플로우에 활용할 수 있습니다.
[warbleR](https://cran.r-project.org/package=warbleR)은
seewave 패키지의 기본 음향 분석 도구를 사용하며, 음향 구조 분석을 위한 새로운
도구를 제공합니다. 이 도구들은 음향 신호의
배치 분석에 사용할 수 있습니다.

패키지의 주요 특징은 다음과 같습니다:

- 다양한 음향 구조 측정 도구
- 선택 테이블에 참조된 음향 신호에 대해 작업을 적용하는 반복문 사용
- 스펙트로그램이 포함된 이미지 생성으로 작업 디렉터리에서
  사용자가 데이터를 조직하고 음향 분석을 검증할 수 있도록 지원


이 패키지는 다음과 같은 기능을 제공합니다:

- [Xeno‐Canto](https://xeno-canto.org/) 녹음 탐색 및 다운로드
- 여러 사운드 파일 탐색, 정리 및 조작
- 신호를 자동으로 감지 (주파수 및 시간에서) (더 철저하고 친절한 구현을 위해 R 패키지 [ohun](https://docs.ropensci.org/ohun/)을 확인하세요)
- 전체 녹음 또는 개별 신호의 스펙트로그램 생성
- 다양한 음향 신호 구조 측정 실행
- 측정 방법의 성능 평가
- 신호 목록화
- 음향 신호의 다양한 구조 수준 특성화
- 듀엣 조정의 통계 분석
- 데이터베이스 및 주석 테이블 통합

대부분의 함수는 작업 병렬화를 허용하여 여러 프로세서에 작업을 분산시켜 계산 효율성을 향상시킵니다. 각 단계에서 분석 성능을 평가하는 도구도 제공됩니다.

## 설치

다음과 같이 CRAN에서 패키지를 설치/로드하세요:






``` r
install.packages("warbleR")

# load package
library(warbleR)
```
최신 개발 버전을 설치하려면  
[github](https://github.com/)에서 R 패키지  
[remotes](https://cran.r-project.org/package=remotes)가 필요합니다:  


``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```
## 사용법

이 패키지에는 주요 기능을 설명하는 여러 개의 비네트가 포함되어 있습니다.  
[warbleR 소개](https://marce10.github.io/warbleR/articles/warbleR.html)에서는 패키지 기능에 대한 개요를 제공합니다.  
비네트 [주석 데이터 형식](https://marce10.github.io/warbleR/articles/annotation_data_format.html)에서는  
입력 주석에 필요한 형식에 대해 자세히 설명합니다. 또한 음향 분석 워크플로우에서 함수들을  
조직하는 방법에 대한 예제가 포함된 세 개의 추가 [패키지 비네트](https://marce10.github.io/warbleR/articles/)도 있습니다.

패키지에 대한 전체 설명(약간 오래된 내용이지만)은  
이 [학술 논문](https://doi.org/10.1111/2041-210X.12624)에서 확인할 수 있습니다.

## 기타 패키지

[seewave](https://cran.r-project.org/package=seewave)와  
[tuneR](https://cran.r-project.org/package=seewave) 패키지는  
음향 분석과 조작을 위한 다양한 함수를 제공합니다. 이들은 주로 R 환경에 이미  
불러온 wave 객체를 대상으로 작동합니다. [baRulho](https://cran.r-project.org/package=baRulho) 패키지는  
[warbleR](https://cran.r-project.org/package=warbleR)와 유사한 데이터 입력 및 출력 형식을 사용하여  
서식지로 인한 음향 신호의 열화를 정량화하는 데 중점을 둡니다.  
[Rraven](https://cran.r-project.org/package=Rraven) 패키지는 R과  
[Raven 음향 분석 소프트웨어](https://www.ravensoundsoftware.com/) ([Cornell Lab of Ornithology](https://www.birds.cornell.edu/home))  
간의 데이터 교환을 용이하게 하며, Raven을 음향 분석 워크플로우 내에서 주석 도구로 통합하는 데 매우 유용합니다.  
[ohun](https://docs.ropensci.org/ohun/) 패키지는 음향 이벤트의 자동 탐지에 관한 작업을 수행하며,  
탐지 루틴을 진단하고 최적화하는 함수를 제공합니다.  
[dynaSpec](https://cran.r-project.org/package=seewave)는 동적 스펙트로그램(즉, 스펙트로그램 비디오)을 생성할 수 있게 합니다.

## 인용 안내













다음과 같이 [warbleR](https://cran.r-project.org/package=warbleR)를 인용해 주시기 바랍니다:

Araya-Salas, M. and Smith-Vidaurre, G. (2017), *warbleR: an r package to
streamline analysis of animal acoustic signals*. Methods Ecol Evol. 8,
184-191.

참고: 스펙트로그램 생성 또는 음향 측정 기능을 사용할 경우
[tuneR](https://cran.r-project.org/package=tuneR) 및
[seewave](https://cran.r-project.org/package=seewave) 패키지도 함께 인용해 주시기 바랍니다.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---