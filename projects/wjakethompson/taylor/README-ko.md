
<!-- README.md is generated from README.Rmd. Please edit that file -->

# taylor <a href="https://taylor.wjakethompson.com"><img src="https://raw.githubusercontent.com/wjakethompson/taylor/main/man/figures/logo.png" align="right" height="138" alt="taylor website" /></a>

<!-- badges: start -->

[![Project Status: Active – The project has reached a stable, usable
state and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![lifecycle](https://img.shields.io/badge/lifecycle-stable-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![R package
version](https://www.r-pkg.org/badges/version/taylor)](https://CRAN.R-project.org/package=taylor)
[![Package
downloads](https://cranlogs.r-pkg.org/badges/grand-total/taylor)](https://cran.r-project.org/package=measr)</br>
[![R-CMD-check](https://github.com/wjakethompson/taylor/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/wjakethompson/taylor/actions/workflows/R-CMD-check.yaml)
[![codecov](https://codecov.io/gh/wjakethompson/taylor/branch/main/graph/badge.svg?token=TECvfoOYHh)](https://app.codecov.io/gh/wjakethompson/taylor)
[![Netlify
Status](https://api.netlify.com/api/v1/badges/b80199c9-57a9-4d08-87e9-4887a67d01e4/deploy-status)](https://app.netlify.com/sites/r-taylor/deploys)</br>
[![Signed
by](https://img.shields.io/badge/Keybase-Verified-brightgreen.svg)](https://keybase.io/wjakethompson)
![License](https://img.shields.io/badge/License-MIT-blue.svg)
<!-- badges: end -->

## 개요

taylor의 목표는 가사와 오디오 특성을 포함한 Taylor Swift 노래의
선별된 데이터 세트에 쉽게 접근할 수 있도록 하는 것입니다. 데이터는
[Genius](https://genius.com/artists/Taylor-swift)와 [Spotify
API](https://open.spotify.com/artist/06HL4z0CvFAxyc27GXpf02)에서 가져옵니다.

<figure>
<img src="https://media.giphy.com/media/2tg4k9pXNcGi7kZ9Pz/giphy.gif"
alt="GIF of Taylor saying “yes”" />
<figcaption aria-hidden="true">테일러가 “yes”라고 말하는 GIF</figcaption>
</figure>

## 설치

릴리스된 버전의 taylor를 다음에서 설치할 수 있습니다.
[CRAN](https://cran.r-project.org/) 와 함께:

``` r
install.packages("taylor")
```

To install the development version from [GitHub](https://github.com/)
use:

``` r
# install.packages("remotes")
remotes::install_github("wjakethompson/taylor")
```
## 예제

세 가지 주요 데이터 세트가 있습니다. 첫 번째는 `taylor_album_songs`로,
테일러 공식 스튜디오 앨범의 모든 곡에 대한 가사와 Spotify API의 오디오 특징을 포함합니다.
특히, 이는 앨범과 별도로 발매된 싱글(예: *Only the Young*, *Christmas Tree Farm* 등)과
테일러 소유의 대체 버전이 있는 비테일러 소유 앨범(예: *Fearless*는 *Fearless (Taylor’s
Version)* 대신 제외됨)을 제외합니다. 우리는 아티스트가 자신의 작품을 소유하는 것을 지원합니다.




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
`taylor_all_songs`를 사용하면 Taylor의 전체 디스코그래피에 접근할 수 있습니다.  
여기에는 `taylor_album_songs`의 모든 노래뿐만 아니라 EP, 개별 싱글, 그리고 *Taylor’s Version*으로 재발매된 앨범의 원본 버전도 포함됩니다.




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
마지막으로, Taylor의 앨범 발매 이력을 요약한 작은 데이터 세트인 `taylor_albums`가 있습니다.



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
## 행동 강령

기여는 환영합니다. 원활한 진행을 위해,
[기여 가이드](https://taylor.wjakethompson.com/CONTRIBUTING.html)를 검토해 주세요.  
taylor 프로젝트는 [기여자 행동 강령](https://taylor.wjakethompson.com/CODE_OF_CONDUCT.html)과 함께 배포됩니다.  
이 프로젝트에 기여함으로써 해당 강령을 준수하는 데 동의하는 것입니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---