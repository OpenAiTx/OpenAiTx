
<!-- README.md est généré à partir de README.Rmd. Veuillez modifier ce fichier -->

# taylor <a href="https://taylor.wjakethompson.com"><img src="https://raw.githubusercontent.com/wjakethompson/taylor/main/man/figures/logo.png" align="right" height="138" alt="site web taylor" /></a>

<!-- badges: start -->

[![Statut du projet : Actif – Le projet a atteint un état stable, utilisable
et est en cours de
développement.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![cycle de vie](https://img.shields.io/badge/lifecycle-stable-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![version du package
R](https://www.r-pkg.org/badges/version/taylor)](https://CRAN.R-project.org/package=taylor)
[![Téléchargements du
package](https://cranlogs.r-pkg.org/badges/grand-total/taylor)](https://cran.r-project.org/package=measr)</br>
[![R-CMD-check](https://github.com/wjakethompson/taylor/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/wjakethompson/taylor/actions/workflows/R-CMD-check.yaml)
[![codecov](https://codecov.io/gh/wjakethompson/taylor/branch/main/graph/badge.svg?token=TECvfoOYHh)](https://app.codecov.io/gh/wjakethompson/taylor)
[![Statut Netlify](https://api.netlify.com/api/v1/badges/b80199c9-57a9-4d08-87e9-4887a67d01e4/deploy-status)](https://app.netlify.com/sites/r-taylor/deploys)</br>
[![Signé
par](https://img.shields.io/badge/Keybase-Verified-brightgreen.svg)](https://keybase.io/wjakethompson)
![Licence](https://img.shields.io/badge/License-MIT-blue.svg)
<!-- badges: end -->

## Présentation

L’objectif de taylor est de fournir un accès facile à un jeu de données
sélectionné de chansons de Taylor Swift, incluant les paroles et les caractéristiques audio. Les données proviennent de [Genius](https://genius.com/artists/Taylor-swift) et de l’[API Spotify](https://open.spotify.com/artist/06HL4z0CvFAxyc27GXpf02).

<figure>
<img src="https://media.giphy.com/media/2tg4k9pXNcGi7kZ9Pz/giphy.gif"
alt="GIF de Taylor disant “oui”" />
<figcaption aria-hidden="true">GIF de Taylor disant “oui”</figcaption>
</figure>

## Installation

Vous pouvez installer la version publiée de taylor depuis



[CRAN](https://cran.r-project.org/) avec :

``` r
install.packages("taylor")
```

To install the development version from [GitHub](https://github.com/)
use:

``` r
# install.packages("remotes")
remotes::install_github("wjakethompson/taylor")
```

## Exemple

Il y a trois ensembles de données principaux. Le premier est `taylor_album_songs`, qui
comprend les paroles et les caractéristiques audio issues de l'API Spotify pour toutes les chansons des
albums officiels en studio de Taylor. Notamment, cela exclut les singles sortis
séparément d'un album (par exemple, *Only the Young*, *Christmas Tree Farm*,
etc.), ainsi que les albums non détenus par Taylor qui ont une alternative détenue par Taylor
(par exemple, *Fearless* est exclu au profit de *Fearless (Taylor’s
Version)*). Nous soutenons les artistes dans la propriété de leur œuvre.

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

Vous pouvez accéder à toute la discographie de Taylor avec `taylor_all_songs`. Cela
comprend toutes les chansons dans `taylor_album_songs` plus les EP, les singles individuels,
et les versions originales des albums qui ont été réédités
en tant que *Taylor’s Version*.

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
Enfin, il y a un petit ensemble de données, `taylor_albums`, résumant
l'historique de sortie des albums de Taylor.


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

## Code de conduite

Les contributions sont les bienvenues. Pour assurer un processus fluide, veuillez consulter le
[Guide de contribution](https://taylor.wjakethompson.com/CONTRIBUTING.html). Veuillez noter
que le projet taylor est publié avec un [Code de conduite des
contributeurs](https://taylor.wjakethompson.com/CODE_OF_CONDUCT.html). En
contribuant à ce projet, vous acceptez de respecter ses termes.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---