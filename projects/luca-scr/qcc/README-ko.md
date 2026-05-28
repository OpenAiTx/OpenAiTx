# qcc

  <!-- badges: start -->
  [![CRAN\_Status\_Badge](http://www.r-pkg.org/badges/version/qcc)](https://cran.r-project.org/package=qcc)
  [![CRAN\_MonthlyDownloads](http://cranlogs.r-pkg.org/badges/qcc)](https://cran.r-project.org/package=qcc)
  [![R-CMD-check](https://github.com/luca-scr/qcc/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/luca-scr/qcc/actions/workflows/R-CMD-check.yaml)
  <!-- badges: end -->

<!-- 
# TODO: logo
<img src="https://raw.githubusercontent.com/luca-scr/qcc/master/man/figures/logo.png" align="right" width="100px " alt=""/>
-->

**품질 관리 차트 및 통계적 공정 관리**를 위한 [R](https://www.r-project.org/) 패키지입니다.

<center>
<img src="https://raw.githubusercontent.com/luca-scr/qcc/master/man/figures/qcc_ani.gif" alt="qcc animation" style="width: 70%" />
</center>
<br>

**qcc** 패키지는 통계적 공정 관리를 위한 품질 관리 도구를 제공합니다:

  - 연속형, 속성형 및 계수형 데이터를 위한 Shewhart 품질 관리 차트.
  - Cusum 및 EWMA 차트.
  - 작동 특성 곡선.
  - 공정 능력 분석.
  - 파레토 차트 및 원인-결과 차트.
  - 다변량 관리 차트.

## 설치

CRAN에서 **qcc**의 출시 버전을 설치할 수 있습니다:


``` r
install.packages("qcc")
```

또는 GitHub에서 개발 버전을 받으십시오:

``` r
# install.packages("devtools")
devtools::install_github("luca-scr/qcc", build = TRUE, build_opts = c("--no-resave-data", "--no-manual"))
```
## 사용법

주요 기능의 사용법과 몇 가지 예제는 Scrucca (2004)에 포함되어 있습니다.  
vignette *A quick tour of qcc*도 다음 명령어로 사용할 수 있습니다:  


``` r
vignette("qcc")
```
또는 패키지의 GitHub 웹페이지 <https://luca-scr.github.io/qcc/>를 통해서도 가능합니다.

## 참고문헌

Montgomery, D.C. (2009) *통계적 품질 관리 입문*, 6판. 뉴욕: John Wiley & Sons.

Scrucca, L. (2004) [qcc: 품질 관리 차트 및 통계적 공정 관리용 R 패키지](https://luca-scr.github.io//R/Rnews_2004-1-pag11-17.pdf). *R 뉴스* 4/1, 11-17.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---