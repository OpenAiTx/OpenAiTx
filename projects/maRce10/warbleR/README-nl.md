warbleR: Stroomlijn Bioacoustische Analyse
================

🌐 **Talen:**  
[Engels](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Spaans](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Frans](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Duits](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Portugees](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiaans](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Russisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[Chinees (Vereenvoudigd)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[Chinees (Traditioneel)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[Japans](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[Koreaans](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[Hindi](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[Thais](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Nederlands](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Pools](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[Arabisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[Perzisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Turks](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Vietnamees](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Indonesisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[Assamees](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md wordt gegenereerd vanuit README.Rmd. Gelieve dat bestand te bewerken -->
<!-- badges: start -->

[![levenscyclus](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Projectstatus: Actief Het project heeft een stabiele, bruikbare staat bereikt
en wordt actief
ontwikkeld.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licentie: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Totaal
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) is bedoeld om
de analyse van de structuur van dierlijke akoestische signalen in
R te vergemakkelijken. Gebruikers kunnen open-toegankelijke vogelopnames verzamelen of hun eigen
gegevens invoeren in een workflow die spectrografische visualisatie en
meting van akoestische parameters ondersteunt.
[warbleR](https://cran.r-project.org/package=warbleR) maakt gebruik van de
fundamentele geluidsanalysetools van het seewave-pakket, en biedt nieuwe
hulpmiddelen voor de analyse van akoestische structuren. Deze tools zijn beschikbaar voor
batchanalyse van akoestische signalen.

De belangrijkste kenmerken van het pakket zijn:

- Diverse hulpmiddelen voor het meten van akoestische structuur
- Het gebruik van loops om taken toe te passen op akoestische signalen die worden vermeld in
  een selectietabel
- Het produceren van afbeeldingen in de werkdirectory met spectrogrammen om
  gebruikers te helpen data te organiseren en akoestische analyses te verifiëren

Het pakket biedt functies om:

- [Xeno‐Canto](https://xeno-canto.org/) opnames te verkennen en te downloaden
- Meerdere geluidsbestanden te verkennen, organiseren en manipuleren
- Signaleren automatisch te detecteren (in frequentie en tijd) (maar bekijk het R-
  pakket [ohun](https://docs.ropensci.org/ohun/) voor een grondigere
  en gebruiksvriendelijkere implementatie)
- Spectrogrammen te maken van volledige opnames of individuele signalen
- Verschillende maten van de structuur van akoestische signalen uit te voeren
- De prestaties van meetmethoden te evalueren
- Signaleringen te catalogiseren
- Verschillende structurele niveaus in akoestische signalen te karakteriseren
- Statistische analyse van duetcoördinatie
- Databases en annotatietabellen te consolideren

De meeste functies maken parallelisatie van taken mogelijk, waardoor
de taken over meerdere processors worden verdeeld om de rekentijd te verbeteren
efficiëntie. Hulpmiddelen om de prestaties van de analyse bij elke stap te evalueren zijn ook beschikbaar.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---