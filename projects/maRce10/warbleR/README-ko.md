<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en">영어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN">간체중국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW">번체중국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja">일본어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi">힌디어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th">태국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr">프랑스어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de">독일어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es">스페인어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it">이탈리아어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru">러시아어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt">포르투갈어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl">네덜란드어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl">폴란드어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar">아랍어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa">페르시아어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr">터키어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi">베트남어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id">인도네시아어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as">아삼어</
      </div>
    </div>
  </details>
</div>


warbleR: 생물음향 분석의 간소화
================

<!-- README.md는 README.Rmd에서 생성됩니다. 해당 파일을 수정해 주세요 -->
<!-- 배지: 시작 -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![프로젝트 상태: Active 프로젝트가 안정적이고 사용 가능한 상태에 도달했으며
활발하게 개발되고 있습니다.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![라이선스: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_상태_배지](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![총
다운로드](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov 테스트
커버리지](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- 배지: 끝 -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR 로고" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR)는
R에서 동물 음향 신호의 구조 분석을 용이하게 하기 위해
개발되었습니다. 사용자는 오픈 액세스 조류 녹음 데이터를 수집하거나 자신의
데이터를 입력하여 스펙트로그램 시각화와
음향 매개변수 측정을 쉽게 진행할 수 있습니다.
[warbleR](https://cran.r-project.org/package=warbleR)는 seewave 패키지의
기본적인 음향 분석 도구를 활용하며, 새로운
음향 구조 분석 도구를 제공합니다. 이 도구들은
음향 신호의 일괄 분석(batch analysis)에 사용할 수 있습니다.

이 패키지의 주요 기능은 다음과 같습니다:

- 음향 구조 측정을 위한 다양한 도구 제공
- 선택 테이블에 참조된 음향 신호에 대해
  반복문을 사용하여 작업을 적용
- 작업 디렉터리 내에서 스펙트로그램 이미지를 생성하여
  사용자가 데이터를 정리하고 음향 분석을 검증할 수 있도록 함

패키지에서 제공하는 함수는 다음과 같습니다:

- [Xeno‐Canto](https://xeno-canto.org/) 녹음 탐색 및 다운로드
- 여러 음향 파일 탐색, 정리, 조작
- 신호 자동 감지(주파수 및 시간 영역) (보다 철저하고 친화적인 구현은 R 패키지 [ohun](https://docs.ropensci.org/ohun/) 참고)
- 전체 녹음 또는 개별 신호의 스펙트로그램 생성



- 다양한 음향 신호 구조 측정 방법 실행
- 측정 방법의 성능 평가
- 신호 목록화
- 음향 신호의 다양한 구조적 수준 특성화
- 이중창 조정의 통계 분석
- 데이터베이스 및 주석 테이블 통합

대부분의 기능은 작업을 병렬화할 수 있어 여러 프로세서에 작업을 분산시켜 계산 효율성을 향상시킵니다. 각 단계에서 분석 성능을 평가하는 도구도 제공됩니다.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---