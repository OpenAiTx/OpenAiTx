warbleR: 생물음향 분석의 효율화
================

🌐 **언어:**  
[English](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Español](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Français](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Português](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiano](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Русский](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文 (简体)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文 (繁體)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日本語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[한국어](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[हिन्दी](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[ไทย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Nederlands](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polski](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[العربية](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[فارسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Türkçe](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Tiếng Việt](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Bahasa Indonesia](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[অসমীয়া](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md는 README.Rmd에서 생성됩니다. 해당 파일을 수정해 주세요 -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR)는
R에서 동물 음향 신호의 구조 분석을
용이하게 하기 위해 설계되었습니다. 사용자는 오픈 액세스 조류 녹음 데이터를 수집하거나
자신의 데이터를 입력하여 스펙트로그램 시각화와
음향 파라미터 측정을 쉽게 할 수 있는 워크플로우에 넣을 수 있습니다.
[warbleR](https://cran.r-project.org/package=warbleR)는
seewave 패키지의 기본적인 음향 분석 도구를 활용하며,
음향 구조 분석을 위한 새로운 도구도 제공합니다. 이러한 도구들은
음향 신호의 배치 분석이 가능합니다.

패키지의 주요 특징은 다음과 같습니다:

- 음향 구조를 측정하는 다양한 도구 제공
- 선택 테이블에 참조된 음향 신호를 통해 작업을 적용하는 루프 사용
- 작업 디렉토리 내 스펙트로그램 이미지를 생성하여
  사용자가 데이터를 조직하고 음향 분석을 검증할 수 있도록 지원

패키지가 제공하는 함수는 다음과 같습니다:

- [Xeno‐Canto](https://xeno-canto.org/) 녹음 탐색 및 다운로드
- 여러 음향 파일 탐색, 정리 및 조작
- 신호 자동 감지(주파수 및 시간 기준) (더 완전하고 사용하기 쉬운 구현을 원한다면 R
  패키지 [ohun](https://docs.ropensci.org/ohun/)을 확인하세요)
- 전체 녹음 또는 개별 신호의 스펙트로그램 생성
- 음향 신호 구조의 다양한 측정 실행
- 측정 방법의 성능 평가
- 신호 분류
- 음향 신호 내 다양한 구조적 수준 특성화
- 듀엣 조정의 통계 분석
- 데이터베이스 및 주석 테이블 통합

대부분의 함수는 작업 병렬 처리를 지원하며, 이는 여러 프로세서에 작업을 분산시켜 계산 성능을 향상시킵니다



효율성. 각 단계에서 분석 성능을 평가하는 도구도 제공됩니다.

## 설치

CRAN에서 다음과 같이 패키지를 설치/로드하세요:


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

이 패키지는 주요 기능을 설명하는 여러 비네트(vignette)를 포함하고 있습니다.  
[warbleR 소개](https://marce10.github.io/warbleR/articles/warbleR.html)는  
패키지 기능에 대한 개요를 제공합니다. 비네트  
[주석 데이터 형식](https://marce10.github.io/warbleR/articles/annotation_data_format.html)은  
입력 주석에 필요한 형식에 대해 자세히 설명합니다. 또한  
음향 분석 워크플로우에서 함수들을 조직하는 예제를 포함한 세 개의 추가 [패키지 비네트](https://marce10.github.io/warbleR/articles/)가 있습니다.  

패키지에 대한 전체 설명(약간 오래되었지만)은  
이 [학술지 기사](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624)에서 확인할 수 있습니다.  

## 기타 패키지

[seewave](https://cran.r-project.org/package=seewave)와  
[tuneR](https://cran.r-project.org/package=seewave) 패키지는  
음향 분석과 조작을 위한 다양한 함수들을 제공합니다. 이들은 대부분  
이미 R 환경에 불러온 웨이브(wave) 객체에서 작동합니다.  
[baRulho](https://cran.r-project.org/package=baRulho) 패키지는  
음향 신호의 서식지 유도 열화를 정량화하는 데 중점을 두며,  
입력 및 출력 데이터가  
[warbleR](https://cran.r-project.org/package=warbleR)와 유사합니다.  
[Rraven](https://cran.r-project.org/package=Rraven) 패키지는  
R과 [Raven 음향 분석 소프트웨어](https://www.ravensoundsoftware.com/) ([코넬 조류 연구소](https://www.birds.cornell.edu/home)) 간의  
데이터 교환을 용이하게 하며, Raven을 음향 분석 워크플로우에서 주석 도구로  
통합하는 데 매우 유용합니다.  
[ohun](https://docs.ropensci.org/ohun/) 패키지는  
음향 이벤트의 자동 탐지 기능을 제공하며, 탐지 루틴을 진단 및 최적화하는  
함수들을 포함하고 있습니다. [dynaSpec](https://cran.r-project.org/package=seewave)는  
동적 스펙트로그램(즉, 스펙트로그램 비디오)을 생성할 수 있습니다.  

## 인용









다음과 같이 [warbleR](https://cran.r-project.org/package=warbleR)를 인용해 주십시오:

Araya-Salas, M. and Smith-Vidaurre, G. (2017), *warbleR: an r package to
streamline analysis of animal acoustic signals*. Methods Ecol Evol. 8,
184-191.

참고: 스펙트로그램 생성 또는 음향 측정 함수의 사용 시
[tuneR](https://cran.r-project.org/package=tuneR) 및
[seewave](https://cran.r-project.org/package=seewave) 패키지도
함께 인용해 주시기 바랍니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---