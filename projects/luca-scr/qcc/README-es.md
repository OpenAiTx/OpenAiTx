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

Un paquete de [R](https://www.r-project.org/) para **gráficos de control de calidad y control estadístico de procesos**.

<center>
<img src="https://raw.githubusercontent.com/luca-scr/qcc/master/man/figures/qcc_ani.gif" alt="animación qcc" style="width: 70%" />
</center>
<br>

El paquete **qcc** proporciona herramientas de control de calidad para el control estadístico de procesos:

  - Gráficos de control de calidad Shewhart para datos continuos, de atributos y de conteo.
  - Gráficos Cusum y EWMA.
  - Curvas características de operación.
  - Análisis de capacidad del proceso.
  - Gráfico de Pareto y gráfico de causa y efecto.
  - Gráficos de control multivariantes.

## Instalación

Puede instalar la versión publicada de **qcc** desde CRAN:


``` r
install.packages("qcc")
```

o la versión de desarrollo desde GitHub:

``` r
# install.packages("devtools")
devtools::install_github("luca-scr/qcc", build = TRUE, build_opts = c("--no-resave-data", "--no-manual"))
```

## Uso

El uso de las funciones principales y algunos ejemplos están incluidos en Scrucca (2004). 
El viñeta *Un recorrido rápido por qcc* también está disponible con el comando:

``` r
vignette("qcc")
```
o a través de la página web de GitHub del paquete en <https://luca-scr.github.io/qcc/>.

## Referencias

Montgomery, D.C. (2009) *Introducción al Control Estadístico de Calidad*, 6ª ed. Nueva York: John Wiley & Sons.

Scrucca, L. (2004) [qcc: un paquete R para gráficos de control de calidad y
control estadístico de procesos](https://luca-scr.github.io//R/Rnews_2004-1-pag11-17.pdf). *R News* 4/1, 11-17. 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-28

---