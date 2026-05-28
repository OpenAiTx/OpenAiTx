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

[R](https://www.r-project.org/)のパッケージで、**品質管理チャートおよび統計的プロセス管理**用。

<center>
<img src="https://raw.githubusercontent.com/luca-scr/qcc/master/man/figures/qcc_ani.gif" alt="qcc animation" style="width: 70%" />
</center>
<br>

**qcc**パッケージは統計的プロセス管理のための品質管理ツールを提供します：

  - 連続、属性、およびカウントデータのシェワート品質管理チャート。
  - CusumおよびEWMAチャート。
  - 動作特性曲線。
  - プロセス能力分析。
  - パレートチャートおよび原因と結果のチャート。
  - 多変量管理チャート。

## インストール

CRANからリリース版の**qcc**をインストールできます：


``` r
install.packages("qcc")
```
GitHubからの開発バージョンの場合：


``` r
# install.packages("devtools")
devtools::install_github("luca-scr/qcc", build = TRUE, build_opts = c("--no-resave-data", "--no-manual"))
```

## 使用法

主な関数の使用法といくつかの例はScrucca (2004)に含まれています。  
ビネット *A quick tour of qcc* は次のコマンドで利用可能です：  

``` r
vignette("qcc")
```
またはパッケージのGitHubウェブページ <https://luca-scr.github.io/qcc/> から入手できます。

## 参考文献

Montgomery, D.C. (2009) *Introduction to Statistical Quality Control*, 第6版。ニューヨーク：John Wiley & Sons。

Scrucca, L. (2004) [qcc: 品質管理チャートおよび統計的工程管理のためのRパッケージ](https://luca-scr.github.io//R/Rnews_2004-1-pag11-17.pdf)。*R News* 4/1, 11-17。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---