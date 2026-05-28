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

一个用于**质量控制图表和统计过程控制**的[R](https://www.r-project.org/)包。

<center>
<img src="https://raw.githubusercontent.com/luca-scr/qcc/master/man/figures/qcc_ani.gif" alt="qcc animation" style="width: 70%" />
</center>
<br>

**qcc**包提供了统计过程控制的质量控制工具：

  - Shewhart质量控制图，适用于连续型、属性型和计数数据。
  - Cusum和EWMA图表。
  - 操作特性曲线。
  - 过程能力分析。
  - 帕累托图和因果图。
  - 多变量控制图。

## 安装

您可以从CRAN安装发布版本的**qcc**：


``` r
install.packages("qcc")
```

或者从 GitHub 获取开发版本：

``` r
# install.packages("devtools")
devtools::install_github("luca-scr/qcc", build = TRUE, build_opts = c("--no-resave-data", "--no-manual"))
```

## 用法

主要函数的用法和一些示例包含在 Scrucca (2004) 中。
小册子 *A quick tour of qcc* 也可通过以下命令获得：

``` r
vignette("qcc")
```
或通过该软件包的 GitHub 网页 <https://luca-scr.github.io/qcc/> 获取。

## 参考文献

Montgomery, D.C. (2009) *统计质量控制导论*, 第6版。纽约：约翰·威利父子公司。

Scrucca, L. (2004) [qcc：一个用于质量控制图和统计过程控制的 R 软件包](https://luca-scr.github.io//R/Rnews_2004-1-pag11-17.pdf)。*R 新闻* 4/1, 11-17。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---