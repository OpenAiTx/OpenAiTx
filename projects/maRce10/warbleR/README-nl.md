<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


warbleR: Versnel Bioakoestische Analyse
================

<!-- README.md is gegenereerd uit README.Rmd. Bewerk dat bestand -->
<!-- badges: start -->

[![levenscyclus](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Projectstatus: Actief Het project heeft een stabiele, bruikbare status bereikt
en wordt actief
ontwikkeld.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licentie: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Totaal
Aantal Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
dekking](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) is bedoeld om
de analyse van de structuur van dierlijke akoestische signalen in
R te vergemakkelijken. Gebruikers kunnen open-access vogelopnames verzamelen of hun eigen
gegevens invoeren in een workflow die spectrografische visualisatie en
meting van akoestische parameters mogelijk maakt.
[warbleR](https://cran.r-project.org/package=warbleR) maakt gebruik van de
fundamentele geluidsanalysetools van het seewave-pakket, en biedt nieuwe
tools voor analyse van akoestische structuur. Deze tools zijn beschikbaar voor
batchanalyse van akoestische signalen.

De belangrijkste kenmerken van het pakket zijn:

- Diverse tools voor het meten van akoestische structuur
- Het gebruik van loops om taken toe te passen op akoestische signalen die in
  een selectietabel zijn gerefereerd
- Het produceren van afbeeldingen in de werkdirectory met spectrogrammen om
  gebruikers te helpen data te organiseren en akoestische analyses te verifiëren

Het pakket biedt functies om:

- [Xeno‐Canto](https://xeno-canto.org/) opnames te verkennen en te downloaden
- Meerdere geluidsbestanden te verkennen, organiseren en manipuleren
- Signalen automatisch te detecteren (in frequentie en tijd) (maar bekijk het R
  pakket [ohun](https://docs.ropensci.org/ohun/) voor een meer grondige
  en gebruiksvriendelijke implementatie)
- Spectrogrammen te maken van volledige opnames of individuele signalen
- Voer verschillende maten van de structuur van het akoestisch signaal uit
- Evalueer de prestaties van meetmethoden
- Catalogiseer signalen
- Karakteriseer verschillende structurele niveaus in akoestische signalen
- Statistische analyse van duetcoördinatie
- Consolideer databases en annotatietabellen

De meeste functies maken parallelisatie van taken mogelijk, wat
de taken verdeelt over meerdere processoren om de computationele
efficiëntie te verbeteren. Er zijn ook tools beschikbaar om de prestaties van de analyse bij elke
stap te evalueren.

## Installatie

Installeer/laad het pakket vanaf CRAN als volgt:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```

Om de nieuwste ontwikkelingsversie te installeren vanaf
[github](https://github.com/) heeft u het R-pakket
[remotes](https://cran.r-project.org/package=remotes) nodig:

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Gebruik

Het pakket bevat verschillende vignetten die de belangrijkste functies uitleggen. De
[Intro tot
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
biedt een overzicht van de functionaliteiten van het pakket. De vignette
[Annotatie data
formaat](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
geeft een gedetailleerde beschrijving van het vereiste formaat voor invoer
annotaties. Er zijn ook drie extra [pakket
vignetten](https://marce10.github.io/warbleR/articles/) met voorbeelden over
hoe functies te organiseren in een workflow voor akoestische analyse.

Een volledige beschrijving van het pakket (hoewel enigszins verouderd) is te vinden
in dit [tijdschrift
artikel](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Andere pakketten

De pakketten [seewave](https://cran.r-project.org/package=seewave) en
[tuneR](https://cran.r-project.org/package=seewave) bieden een enorme
verscheidenheid aan functies voor akoestische analyse en manipulatie. Ze werken meestal
op wave-objecten die al zijn geïmporteerd in de R-omgeving. Het
pakket [baRulho](https://cran.r-project.org/package=baRulho) richt zich op
het kwantificeren van door habitat veroorzaakte degradatie van akoestische signalen met
gegevensinvoer en -uitvoer vergelijkbaar met die van
[warbleR](https://cran.r-project.org/package=warbleR). Het pakket
[Rraven](https://cran.r-project.org/package=Rraven) vergemakkelijkt de
uitwisseling van gegevens tussen R en [Raven geluidsanalyse
software](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) en kan erg
handig zijn om Raven als annotatie-instrument te integreren in een workflow voor
akoestische analyse in R. Het pakket
[ohun](https://docs.ropensci.org/ohun/) werkt aan automatische detectie van
geluidsevenementen en biedt functies om detectieroutines te diagnosticeren en te optimaliseren.
[dynaSpec](https://cran.r-project.org/package=seewave) maakt het
mogelijk om dynamische spectrogrammen te maken (d.w.z. spectrogramvideo's).

## Citaat

Gelieve [warbleR](https://cran.r-project.org/package=warbleR) als volgt te citeren:

Araya-Salas, M. en Smith-Vidaurre, G. (2017), *warbleR: een r-pakket om de analyse van dierlijke akoestische signalen te stroomlijnen*. Methods Ecol Evol. 8, 184-191.

OPMERKING: gelieve ook de
[tuneR](https://cran.r-project.org/package=tuneR) en
[seewave](https://cran.r-project.org/package=seewave) pakketten te citeren indien u
spectrogramma-creërende of akoestische-meetfuncties gebruikt





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---