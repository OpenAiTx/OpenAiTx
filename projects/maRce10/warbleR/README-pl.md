warbleR: Usprawnij analizę bioakustyczną
================

🌐 **Języki:**  
[English](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Español](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Français](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Português](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiano](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Русский](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文 (简体)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文 (繁體)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日本語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[한국어](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[हिन्दी](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[ไทย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Nederlands](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polski](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[العربية](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[فارسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Türkçe](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Tiếng Việt](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Bahasa Indonesia](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[অসমীয়া](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md jest generowany z README.Rmd. Proszę edytować ten plik -->
<!-- odznaki: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) ma na celu
ułatwienie analizy struktury sygnałów akustycznych zwierząt w
R. Użytkownicy mogą zbierać nagrania ptaków z otwartym dostępem lub wprowadzać własne
dane do przepływu pracy, który ułatwia wizualizację spektrograficzną oraz
pomiar parametrów akustycznych.
[warbleR](https://cran.r-project.org/package=warbleR) wykorzystuje
podstawowe narzędzia analizy dźwięku z pakietu seewave i oferuje nowe
narzędzia do analizy struktury akustycznej. Narzędzia te są dostępne do
wsadowej analizy sygnałów akustycznych.

Główne cechy pakietu to:

- Różnorodne narzędzia do pomiaru struktury akustycznej
- Wykorzystanie pętli do zastosowania zadań na sygnałach akustycznych odniesionych w
  tabeli selekcji
- Tworzenie obrazów w katalogu roboczym ze spektrogramami, aby
  umożliwić użytkownikom organizację danych i weryfikację analiz akustycznych

Pakiet oferuje funkcje do:

- Przeglądania i pobierania nagrań z [Xeno‐Canto](https://xeno-canto.org/)
- Przeglądania, organizowania i manipulowania wieloma plikami dźwiękowymi
- Automatycznego wykrywania sygnałów (w częstotliwości i czasie) (ale sprawdź pakiet R
  [ohun](https://docs.ropensci.org/ohun/) dla bardziej kompleksowej
  i przyjaznej implementacji)
- Tworzenia spektrogramów całych nagrań lub pojedynczych sygnałów
- Przeprowadzania różnych pomiarów struktury sygnału akustycznego
- Oceny skuteczności metod pomiarowych
- Katalogowania sygnałów
- Charakteryzowania różnych poziomów strukturalnych sygnałów akustycznych
- Analizy statystycznej koordynacji duetów
- Konsolidacji baz danych i tabel adnotacji

Większość funkcji umożliwia równoleglenie zadań, co
rozdziela zadania pomiędzy kilka procesorów w celu poprawy obliczeń
wydajności. Dostępne są również narzędzia do oceny wydajności analizy na każdym
etapie.

## Instalacja

Zainstaluj/załaduj pakiet z CRAN w następujący sposób:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```
Aby zainstalować najnowszą wersję rozwojową z
[github](https://github.com/) będziesz potrzebować pakietu R
[remotes](https://cran.r-project.org/package=remotes):


``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```
## Użytkowanie

Pakiet zawiera kilka winiet wyjaśniających jego główne funkcje.
[Wprowadzenie do
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
daje przegląd funkcjonalności pakietu. Winieta
[Format danych
adnotacyjnych](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
zawiera szczegółowy opis wymaganego formatu dla danych wejściowych
adnotacji. Istnieją także trzy dodatkowe [winiety
pakietu](https://marce10.github.io/warbleR/articles/) z przykładami
jak organizować funkcje w przepływie pracy analizy akustycznej.

Pełny opis pakietu (choć nieco przestarzały) znajduje się w tym [artykule
naukowym](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Inne pakiety

Pakiety [seewave](https://cran.r-project.org/package=seewave) oraz
[tuneR](https://cran.r-project.org/package=seewave) oferują ogromną
różnorodność funkcji do analizy i manipulacji dźwiękiem. Działają
głównie na obiektach falowych już zaimportowanych do środowiska R.
Pakiet [baRulho](https://cran.r-project.org/package=baRulho) skupia się
na ilościowym określaniu degradacji sygnałów akustycznych spowodowanej
środowiskiem, przy wejściach i wyjściach podobnych do tych w
[warbleR](https://cran.r-project.org/package=warbleR). Pakiet
[Rraven](https://cran.r-project.org/package=Rraven) ułatwia
wymianę danych między R a [oprogramowaniem do analizy dźwięku Raven
software](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) i może być bardzo
przydatny przy włączaniu Raven jako narzędzia adnotacyjnego do
przepływu pracy analizy akustycznej w R. Pakiet
[ohun](https://docs.ropensci.org/ohun/) służy do automatycznego
wykrywania zdarzeń dźwiękowych, oferując funkcje do diagnozowania i
optymalizacji procedur wykrywania. [dynaSpec](https://cran.r-project.org/package=seewave)
umożliwia tworzenie dynamicznych spektrogramów (czyli wideo spektrogramów).

## Cytowanie



Proszę cytować [warbleR](https://cran.r-project.org/package=warbleR) w następujący sposób:

Araya-Salas, M. i Smith-Vidaurre, G. (2017), *warbleR: pakiet r do usprawnienia analizy sygnałów akustycznych zwierząt*. Methods Ecol Evol. 8, 184-191.

UWAGA: proszę również cytować pakiety
[tuneR](https://cran.r-project.org/package=tuneR) oraz
[seewave](https://cran.r-project.org/package=seewave) jeśli
korzystasz z jakichkolwiek funkcji do tworzenia spektrogramów lub pomiarów akustycznych





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---