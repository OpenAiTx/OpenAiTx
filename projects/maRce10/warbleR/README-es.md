<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


warbleR: Optimiza el Análisis Bioacústico
================

<!-- README.md se genera a partir de README.Rmd. Por favor edite ese archivo -->
<!-- insignias: inicio -->

[![ciclo de vida](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![estado](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Estado del proyecto: Activo El proyecto ha alcanzado un estado estable y utilizable
y está siendo desarrollado
activamente.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licencia: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total de
descargas](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Cobertura de pruebas
Codecov](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="logo warbleR" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) está diseñado para
facilitar el análisis de la estructura de señales acústicas animales en
R. Los usuarios pueden recopilar grabaciones aviares de acceso abierto o ingresar sus propios
datos en un flujo de trabajo que facilita la visualización espectrográfica y la
medición de parámetros acústicos.
[warbleR](https://cran.r-project.org/package=warbleR) utiliza las
herramientas fundamentales de análisis de sonido del paquete seewave, y ofrece nuevas
herramientas para el análisis de la estructura acústica. Estas herramientas están disponibles para
análisis por lotes de señales acústicas.

Las principales características del paquete son:

- Diversas herramientas para medir la estructura acústica
- El uso de bucles para aplicar tareas a través de señales acústicas referenciadas en
  una tabla de selección
- La producción de imágenes en el directorio de trabajo con espectrogramas para
  permitir a los usuarios organizar datos y verificar análisis acústicos

El paquete ofrece funciones para:

- Explorar y descargar grabaciones de [Xeno‐Canto](https://xeno-canto.org/)
- Explorar, organizar y manipular múltiples archivos de sonido
- Detectar señales automáticamente (en frecuencia y tiempo) (pero revisa el paquete de R
  [ohun](https://docs.ropensci.org/ohun/) para una implementación más completa
  y amigable)
- Crear espectrogramas de grabaciones completas o señales individuales
- Ejecutar diferentes medidas de la estructura de la señal acústica
- Evaluar el rendimiento de los métodos de medición
- Catalogar señales
- Caracterizar diferentes niveles estructurales en señales acústicas
- Análisis estadístico de la coordinación de duetos
- Consolidar bases de datos y tablas de anotaciones

La mayoría de las funciones permiten la paralelización de tareas, lo que
distribuye las tareas entre varios procesadores para mejorar la eficiencia
computacional. También hay disponibles herramientas para evaluar el rendimiento
del análisis en cada paso.

## Instalación

Instale/cargue el paquete desde CRAN de la siguiente manera:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```

Para instalar la última versión en desarrollo desde
[github](https://github.com/) necesitará el paquete de R
[remotes](https://cran.r-project.org/package=remotes):

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Uso

El paquete incluye varios viñetas que explican sus principales características. El
[Intro a
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
proporciona una visión general de las funcionalidades del paquete. La viñeta
[Formato de datos de
anotación](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
ofrece una descripción detallada del formato requerido para las anotaciones
de entrada. También hay tres [viñetas adicionales del
paquete](https://marce10.github.io/warbleR/articles/) con ejemplos sobre
cómo organizar funciones en un flujo de trabajo de análisis acústico.

Una descripción completa del paquete (aunque un poco desactualizada) se puede encontrar
en este [artículo de
revista](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Otros paquetes

Los paquetes [seewave](https://cran.r-project.org/package=seewave) y
[tuneR](https://cran.r-project.org/package=seewave) ofrecen una gran
variedad de funciones para el análisis y manipulación acústica. Principalmente
trabajan sobre objetos wave ya importados al entorno de R. El
paquete [baRulho](https://cran.r-project.org/package=baRulho) se enfoca en
cuantificar la degradación inducida por el hábitat en señales acústicas con entradas
y salidas de datos similares a las de
[warbleR](https://cran.r-project.org/package=warbleR). El paquete
[Rraven](https://cran.r-project.org/package=Rraven) facilita el
intercambio de datos entre R y el [software de análisis de sonido Raven
software](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) y puede ser muy
útil para incorporar Raven como la herramienta de anotación en el flujo de trabajo de análisis
acústico en R. El paquete
[ohun](https://docs.ropensci.org/ohun/) trabaja en la detección automática de
eventos sonoros, proporcionando funciones para diagnosticar y optimizar rutinas de detección.
[dynaSpec](https://cran.r-project.org/package=seewave) permite
crear espectrogramas dinámicos (es decir, videos de espectrogramas).

## Citación

Por favor cite [warbleR](https://cran.r-project.org/package=warbleR) como
sigue:

Araya-Salas, M. y Smith-Vidaurre, G. (2017), *warbleR: un paquete de r para
simplificar el análisis de señales acústicas animales*. Methods Ecol Evol. 8,
184-191.

NOTA: por favor cite también los paquetes
[tuneR](https://cran.r-project.org/package=tuneR) y
[seewave](https://cran.r-project.org/package=seewave) si
utiliza alguna función para crear espectrogramas o medir acústica


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---