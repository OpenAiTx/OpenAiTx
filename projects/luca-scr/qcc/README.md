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

An [R](https://www.r-project.org/) package for **quality control charting and statistical process control**.

<center>
<img src="https://raw.githubusercontent.com/luca-scr/qcc/master/man/figures/qcc_ani.gif" alt="qcc animation" style="width: 70%" />
</center>
<br>

The **qcc** package provides quality control tools for statistical process control:

  - Shewhart quality control charts for continuous, attribute and count
    data.
  - Cusum and EWMA charts.
  - Operating characteristic curves.
  - Process capability analysis.
  - Pareto chart and cause-and-effect chart.
  - Multivariate control charts.

## Installation

You can install the released version of **qcc** from CRAN:

``` r
install.packages("qcc")
```

or the development version from GitHub:

``` r
# install.packages("devtools")
devtools::install_github("luca-scr/qcc", build = TRUE, build_opts = c("--no-resave-data", "--no-manual"))
```

## Usage

Usage of the main functions and some examples are included in Scrucca (2004). 
The vignette *A quick tour of qcc* is also available with the command:

``` r
vignette("qcc")
```

or through the GitHub web page of the package at <https://luca-scr.github.io/qcc/>.

## References

Montgomery, D.C. (2009) *Introduction to Statistical Quality Control*, 6th ed. New York: John Wiley & Sons.

Scrucca, L. (2004) [qcc: an R package for quality control charting and
statistical process control](https://luca-scr.github.io//R/Rnews_2004-1-pag11-17.pdf). *R News* 4/1, 11-17. 

