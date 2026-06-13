warbleR: Optimieren Sie die bioakustische Analyse
================

🌐 **Sprachen:**  
[Englisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Spanisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Französisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Portugiesisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italienisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Russisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[Chinesisch (vereinfacht)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[Chinesisch (traditionell)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[Japanisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[Koreanisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[Hindi](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[Thailändisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Niederländisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polnisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[Arabisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[Persisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Türkisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Vietnamesisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Indonesisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[Assamesisch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md wird aus README.Rmd generiert. Bitte bearbeiten Sie diese Datei -->
<!-- Abzeichen: Anfang -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Projektstatus: Aktiv Das Projekt hat einen stabilen, nutzbaren Zustand erreicht
und wird aktiv
weiterentwickelt.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Lizenz: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Gesamtzahl
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) soll
die Analyse der Struktur tierischer akustischer Signale in
R erleichtern. Benutzer können offene Vogelaufnahmen sammeln oder eigene
Daten in einen Arbeitsablauf eingeben, der die spektrographische Visualisierung und
Messung akustischer Parameter erleichtert.
[warbleR](https://cran.r-project.org/package=warbleR) verwendet die
grundlegenden Werkzeuge zur Schallanalyse aus dem seewave-Paket und bietet neue
Werkzeuge zur Analyse der akustischen Struktur. Diese Werkzeuge stehen für die
Stapelverarbeitung akustischer Signale zur Verfügung.

Die Hauptmerkmale des Pakets sind:

- Vielfältige Werkzeuge zur Messung akustischer Strukturen
- Die Verwendung von Schleifen, um Aufgaben auf akustische Signale anzuwenden, die in
  einer Auswahltabelle referenziert sind
- Das Erstellen von Bildern im Arbeitsverzeichnis mit Spektrogrammen, um Benutzern die
  Organisation von Daten und die Überprüfung akustischer Analysen zu ermöglichen

Das Paket bietet Funktionen zum:

- Erkunden und Herunterladen von [Xeno‐Canto](https://xeno-canto.org/) Aufnahmen
- Erkunden, Organisieren und Manipulieren mehrerer Audiodateien
- Automatische Erkennung von Signalen (in Frequenz und Zeit) (aber siehe das R
  Paket [ohun](https://docs.ropensci.org/ohun/) für eine umfassendere und benutzerfreundlichere Umsetzung)
- Erstellen von Spektrogrammen kompletter Aufnahmen oder einzelner Signale
- Durchführen verschiedener Messungen der akustischen Signalstruktur
- Bewertung der Leistung von Messmethoden
- Katalogisierung von Signalen
- Charakterisierung verschiedener struktureller Ebenen in akustischen Signalen
- Statistische Analyse der Duett-Koordination
- Konsolidierung von Datenbanken und Annotationstabellen

Die meisten Funktionen ermöglichen die Parallelisierung von Aufgaben, wodurch
die Aufgaben auf mehrere Prozessoren verteilt werden, um die Rechenleistung zu verbessern

Effizienz. Werkzeuge zur Bewertung der Analyseleistung in jedem Schritt sind ebenfalls verfügbar.

## Installation

Installieren/Laden Sie das Paket von CRAN wie folgt:


``` r
install.packages("warbleR")

# load package
library(warbleR)
```
Um die neueste Entwicklungsversion von
[github](https://github.com/) zu installieren, benötigen Sie das R-Paket
[remotes](https://cran.r-project.org/package=remotes):


``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Verwendung

Das Paket enthält mehrere Vignetten, die seine Hauptfunktionen erklären. Die
[Einführung in
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
bietet einen Überblick über die Funktionen des Pakets. Die Vignette
[Annotierungsdaten-
format](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
liefert eine detaillierte Beschreibung des erforderlichen Formats für die Eingabe-
Annotierungen. Es gibt außerdem drei weitere [Paket-
Vignetten](https://marce10.github.io/warbleR/articles/) mit Beispielen dazu,
wie man Funktionen in einem Workflow zur akustischen Analyse organisiert.

Eine vollständige Beschreibung des Pakets (wenn auch etwas veraltet) findet sich
in diesem [Journal-
Artikel](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Weitere Pakete

Die Pakete [seewave](https://cran.r-project.org/package=seewave) und
[tuneR](https://cran.r-project.org/package=seewave) bieten eine große
Auswahl an Funktionen zur akustischen Analyse und Bearbeitung. Sie arbeiten meist
mit Wave-Objekten, die bereits in die R-Umgebung importiert wurden. Das
Paket [baRulho](https://cran.r-project.org/package=baRulho) konzentriert sich auf
die Quantifizierung von habitatbedingter Degradierung akustischer Signale mit Daten-
Eingaben und -Ausgaben, die denen von
[warbleR](https://cran.r-project.org/package=warbleR) ähneln. Das Paket
[Rraven](https://cran.r-project.org/package=Rraven) erleichtert den
Datenaustausch zwischen R und der [Raven Sound Analysis
Software](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) und kann sehr
hilfreich sein, um Raven als Annotierungswerkzeug in den Workflow zur akustischen
Analyse in R zu integrieren. Das Paket
[ohun](https://docs.ropensci.org/ohun/) arbeitet mit der automatisierten Erkennung von
Schallereignissen und bietet Funktionen zur Diagnose und Optimierung von
Erkennungsroutinen. [dynaSpec](https://cran.r-project.org/package=seewave) erlaubt
die Erstellung dynamischer Spektrogramme (d.h. Spektrogramm-Videos).

## Zitation

Bitte zitieren Sie [warbleR](https://cran.r-project.org/package=warbleR) wie folgt:

Araya-Salas, M. und Smith-Vidaurre, G. (2017), *warbleR: ein R-Paket zur
Vereinfachung der Analyse von tierischen akustischen Signalen*. Methods Ecol Evol. 8,
184-191.

HINWEIS: Bitte zitieren Sie ebenfalls die
[tuneR](https://cran.r-project.org/package=tuneR)- und
[seewave](https://cran.r-project.org/package=seewave)-Pakete, falls Sie
Funktionen zur Erstellung von Spektrogrammen oder zur akustischen Messung verwenden



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---