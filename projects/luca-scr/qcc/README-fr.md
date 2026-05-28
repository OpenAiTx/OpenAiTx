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

Un package [R](https://www.r-project.org/) pour **les graphiques de contrôle qualité et le contrôle statistique des processus**.

<center>
<img src="https://raw.githubusercontent.com/luca-scr/qcc/master/man/figures/qcc_ani.gif" alt="animation qcc" style="width: 70%" />
</center>
<br>

Le package **qcc** fournit des outils de contrôle qualité pour le contrôle statistique des processus :

  - Graphiques de contrôle qualité Shewhart pour données continues, attributs et comptages.
  - Graphiques Cusum et EWMA.
  - Courbes caractéristiques de fonctionnement.
  - Analyse de la capacité du processus.
  - Diagramme de Pareto et diagramme cause-effet.
  - Graphiques de contrôle multivariés.

## Installation

Vous pouvez installer la version publiée de **qcc** depuis le CRAN :


``` r
install.packages("qcc")
```

ou la version de développement depuis GitHub :

``` r
# install.packages("devtools")
devtools::install_github("luca-scr/qcc", build = TRUE, build_opts = c("--no-resave-data", "--no-manual"))
```

## Utilisation

L'utilisation des fonctions principales et quelques exemples sont inclus dans Scrucca (2004).  
La vignette *A quick tour of qcc* est également disponible avec la commande : 

``` r
vignette("qcc")
```
ou via la page GitHub du paquet à <https://luca-scr.github.io/qcc/>.

## Références

Montgomery, D.C. (2009) *Introduction au contrôle statistique de la qualité*, 6e éd. New York : John Wiley & Sons.

Scrucca, L. (2004) [qcc : un paquet R pour les graphiques de contrôle qualité et
le contrôle statistique des processus](https://luca-scr.github.io//R/Rnews_2004-1-pag11-17.pdf). *R News* 4/1, 11-17. 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---