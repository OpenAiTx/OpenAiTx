
<!-- README.md 是从 README.Rmd 生成的。请编辑该文件 -->

# taylor <a href="https://taylor.wjakethompson.com"><img src="https://raw.githubusercontent.com/wjakethompson/taylor/main/man/figures/logo.png" align="right" height="138" alt="taylor 网站" /></a>

<!-- 徽章：开始 -->

[![项目状态：活跃 – 项目已达到稳定、可用状态且正在积极开发中](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![生命周期](https://img.shields.io/badge/lifecycle-stable-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![R 包版本](https://www.r-pkg.org/badges/version/taylor)](https://CRAN.R-project.org/package=taylor)
[![包下载量](https://cranlogs.r-pkg.org/badges/grand-total/taylor)](https://cran.r-project.org/package=measr)</br>
[![R-CMD-检查](https://github.com/wjakethompson/taylor/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/wjakethompson/taylor/actions/workflows/R-CMD-check.yaml)
[![代码覆盖率](https://codecov.io/gh/wjakethompson/taylor/branch/main/graph/badge.svg?token=TECvfoOYHh)](https://app.codecov.io/gh/wjakethompson/taylor)
[![Netlify 状态](https://api.netlify.com/api/v1/badges/b80199c9-57a9-4d08-87e9-4887a67d01e4/deploy-status)](https://app.netlify.com/sites/r-taylor/deploys)</br>
[![签名者](https://img.shields.io/badge/Keybase-Verified-brightgreen.svg)](https://keybase.io/wjakethompson)
![许可证](https://img.shields.io/badge/License-MIT-blue.svg)
<!-- 徽章：结束 -->

## 概述

taylor 的目标是提供便捷访问经过策划的泰勒·斯威夫特歌曲数据集，包括歌词和音频特征。数据来源于 [Genius](https://genius.com/artists/Taylor-swift) 和 [Spotify API](https://open.spotify.com/artist/06HL4z0CvFAxyc27GXpf02)。

<figure>
<img src="https://media.giphy.com/media/2tg4k9pXNcGi7kZ9Pz/giphy.gif"
alt="泰勒说“yes”的动图" />
<figcaption aria-hidden="true">泰勒说“yes”的动图</figcaption>
</figure>

## 安装

您可以从以下途径安装发布版本的 taylor









[CRAN](https://cran.r-project.org/) 包含：

``` r
install.packages("taylor")
```

To install the development version from [GitHub](https://github.com/)
use:

``` r
# install.packages("remotes")
remotes::install_github("wjakethompson/taylor")
```

## 示例

有三个主要数据集。第一个是 `taylor_album_songs`，它
包含了所有泰勒官方录音室专辑中歌曲的歌词和来自Spotify API的音频特征。
值得注意的是，这不包括单独发行的单曲
（例如，*Only the Young*、*Christmas Tree Farm*，
等），以及有泰勒拥有替代版本的非泰勒拥有的专辑
（例如，*Fearless* 被排除，优先采用 *Fearless (Taylor’s
Version)*）。我们支持艺术家拥有他们的作品。

``` r
taylor_album_songs
#> # A tibble: 240 × 29
#>    album_name   ep    album_release track_number track_name     artist featuring
#>    <chr>        <lgl> <date>               <int> <chr>          <chr>  <chr>    
#>  1 Taylor Swift FALSE 2006-10-24               1 Tim McGraw     Taylo… <NA>     
#>  2 Taylor Swift FALSE 2006-10-24               2 Picture To Bu… Taylo… <NA>     
#>  3 Taylor Swift FALSE 2006-10-24               3 Teardrops On … Taylo… <NA>     
#>  4 Taylor Swift FALSE 2006-10-24               4 A Place In Th… Taylo… <NA>     
#>  5 Taylor Swift FALSE 2006-10-24               5 Cold As You    Taylo… <NA>     
#>  6 Taylor Swift FALSE 2006-10-24               6 The Outside    Taylo… <NA>     
#>  7 Taylor Swift FALSE 2006-10-24               7 Tied Together… Taylo… <NA>     
#>  8 Taylor Swift FALSE 2006-10-24               8 Stay Beautiful Taylo… <NA>     
#>  9 Taylor Swift FALSE 2006-10-24               9 Should've Sai… Taylo… <NA>     
#> 10 Taylor Swift FALSE 2006-10-24              10 Mary's Song (… Taylo… <NA>     
#> # ℹ 230 more rows
#> # ℹ 22 more variables: bonus_track <lgl>, promotional_release <date>,
#> #   single_release <date>, track_release <date>, danceability <dbl>,
#> #   energy <dbl>, key <int>, loudness <dbl>, mode <int>, speechiness <dbl>,
#> #   acousticness <dbl>, instrumentalness <dbl>, liveness <dbl>, valence <dbl>,
#> #   tempo <dbl>, time_signature <int>, duration_ms <int>, explicit <lgl>,
#> #   key_name <chr>, mode_name <chr>, key_mode <chr>, lyrics <list>
```
你可以使用 `taylor_all_songs` 访问泰勒的全部曲目。  
这包括 `taylor_album_songs` 中的所有歌曲，以及 EP、单曲，  
以及已重新发行为 *Taylor’s Version* 的专辑原版。



``` r
taylor_all_songs
#> # A tibble: 364 × 29
#>    album_name   ep    album_release track_number track_name     artist featuring
#>    <chr>        <lgl> <date>               <int> <chr>          <chr>  <chr>    
#>  1 Taylor Swift FALSE 2006-10-24               1 Tim McGraw     Taylo… <NA>     
#>  2 Taylor Swift FALSE 2006-10-24               2 Picture To Bu… Taylo… <NA>     
#>  3 Taylor Swift FALSE 2006-10-24               3 Teardrops On … Taylo… <NA>     
#>  4 Taylor Swift FALSE 2006-10-24               4 A Place In Th… Taylo… <NA>     
#>  5 Taylor Swift FALSE 2006-10-24               5 Cold As You    Taylo… <NA>     
#>  6 Taylor Swift FALSE 2006-10-24               6 The Outside    Taylo… <NA>     
#>  7 Taylor Swift FALSE 2006-10-24               7 Tied Together… Taylo… <NA>     
#>  8 Taylor Swift FALSE 2006-10-24               8 Stay Beautiful Taylo… <NA>     
#>  9 Taylor Swift FALSE 2006-10-24               9 Should've Sai… Taylo… <NA>     
#> 10 Taylor Swift FALSE 2006-10-24              10 Mary's Song (… Taylo… <NA>     
#> # ℹ 354 more rows
#> # ℹ 22 more variables: bonus_track <lgl>, promotional_release <date>,
#> #   single_release <date>, track_release <date>, danceability <dbl>,
#> #   energy <dbl>, key <int>, loudness <dbl>, mode <int>, speechiness <dbl>,
#> #   acousticness <dbl>, instrumentalness <dbl>, liveness <dbl>, valence <dbl>,
#> #   tempo <dbl>, time_signature <int>, duration_ms <int>, explicit <lgl>,
#> #   key_name <chr>, mode_name <chr>, key_mode <chr>, lyrics <list>
```

最后，有一个小型数据集，`taylor_albums`，总结了
泰勒的专辑发行历史。

``` r
taylor_albums
#> # A tibble: 17 × 5
#>    album_name                    ep    album_release metacritic_score user_score
#>    <chr>                         <lgl> <date>                   <int>      <dbl>
#>  1 Taylor Swift                  FALSE 2006-10-24                  67        8.4
#>  2 The Taylor Swift Holiday Col… TRUE  2007-10-14                  NA       NA  
#>  3 Beautiful Eyes                TRUE  2008-07-15                  NA       NA  
#>  4 Fearless                      FALSE 2008-11-11                  73        8.4
#>  5 Speak Now                     FALSE 2010-10-25                  77        8.6
#>  6 Red                           FALSE 2012-10-22                  77        8.6
#>  7 1989                          FALSE 2014-10-27                  76        8.3
#>  8 reputation                    FALSE 2017-11-10                  71        8.3
#>  9 Lover                         FALSE 2019-08-23                  79        8.4
#> 10 folklore                      FALSE 2020-07-24                  88        9  
#> 11 evermore                      FALSE 2020-12-11                  85        8.9
#> 12 Fearless (Taylor's Version)   FALSE 2021-04-09                  82        8.9
#> 13 Red (Taylor's Version)        FALSE 2021-11-12                  91        8.9
#> 14 Midnights                     FALSE 2022-10-21                  85        8.3
#> 15 Speak Now (Taylor's Version)  FALSE 2023-07-07                  81        9.2
#> 16 1989 (Taylor's Version)       FALSE 2023-10-27                  90       NA  
#> 17 THE TORTURED POETS DEPARTMENT FALSE 2024-04-19                  76       NA
```

## 行为准则

欢迎贡献。为了确保流程顺利，请查阅
[贡献指南](https://taylor.wjakethompson.com/CONTRIBUTING.html)。请注意，
taylor 项目遵循[贡献者行为准则](https://taylor.wjakethompson.com/CODE_OF_CONDUCT.html)发布。通过
向本项目贡献，您同意遵守其条款。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---