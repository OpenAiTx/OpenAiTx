
<!-- README.md は README.Rmd から生成されています。このファイルを編集してください -->

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

## 概要

taylor の目的は、歌詞や音声特性を含むテイラー・スウィフトの楽曲の厳選データセットに簡単にアクセスできるようにすることです。データは [Genius](https://genius.com/artists/Taylor-swift) と [Spotify API](https://open.spotify.com/artist/06HL4z0CvFAxyc27GXpf02) から取得しています。

<figure>
<img src="https://media.giphy.com/media/2tg4k9pXNcGi7kZ9Pz/giphy.gif"
alt="テイラーが「はい」と言っているGIF" />
<figcaption aria-hidden="true">テイラーが「はい」と言っているGIF</figcaption>
</figure>

## インストール

リリース版の taylor は以下からインストールできます



[CRAN](https://cran.r-project.org/) とともに:

``` r
install.packages("taylor")
```

To install the development version from [GitHub](https://github.com/)
use:

``` r
# install.packages("remotes")
remotes::install_github("wjakethompson/taylor")
```
## 例

3つの主要なデータセットがあります。最初は `taylor_album_songs` で、
これはテイラーの公式スタジオアルバムに収録されたすべての曲の歌詞と
Spotify APIからのオーディオ特徴を含みます。特に、アルバムから
別途リリースされたシングル（例：*Only the Young*、*Christmas Tree Farm*、
など）や、テイラー所有の代替版があるテイラー所有でないアルバム（例：
*Fearless* は *Fearless (Taylor’s Version)* に置き換えられています）は除外されています。
私たちはアーティストが自身の作品を所有することを支持します。


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

`taylor_all_songs` を使うと、テイラーの全ディスコグラフィにアクセスできます。これには
`taylor_album_songs` にあるすべての曲に加え、EP、個別のシングル、
および *Taylor’s Version* として再リリースされたアルバムのオリジナル版が含まれます。


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
最後に、小さなデータセットである `taylor_albums` があり、  
テイラーのアルバムリリース履歴をまとめています。


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

## 行動規範

貢献は歓迎します。円滑なプロセスを確保するために、[Contributing
Guide](https://taylor.wjakethompson.com/CONTRIBUTING.html)を必ずご確認ください。  
taylorプロジェクトは[Contributor Code of
Conduct](https://taylor.wjakethompson.com/CODE_OF_CONDUCT.html)のもとにリリースされています。  
このプロジェクトに貢献することにより、その規約に従うことに同意したものとみなされます。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---