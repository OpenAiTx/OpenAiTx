<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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


warbleR: Vereinfachung der bioakustischen Analyse
================

<!-- README.md wird aus README.Rmd generiert. Bitte bearbeiten Sie diese Datei -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Projektstatus: Aktiv Das Projekt hat einen stabilen, nutzbaren Zustand erreicht
und wird aktiv
entwickelt.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Lizenz: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Gesamtanzahl
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov Testabdeckung](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR Logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) soll die
Analyse der Struktur tierischer akustischer Signale in R erleichtern.
Benutzer können frei zugängliche Vogelaufnahmen sammeln oder eigene
Daten in einen Workflow eingeben, der die spektrographische
Visualisierung und die Messung akustischer Parameter unterstützt.
[warbleR](https://cran.r-project.org/package=warbleR) verwendet die
grundlegenden Werkzeuge zur Klanganalyse aus dem seewave-Paket und bietet neue
Werkzeuge zur Analyse akustischer Strukturen. Diese Werkzeuge sind für die
Stapelverarbeitung akustischer Signale verfügbar.

Die Hauptfunktionen des Pakets sind:

- Verschiedene Werkzeuge zur Messung akustischer Strukturen
- Die Verwendung von Schleifen zur Anwendung von Aufgaben auf akustische Signale, die in
  einer Auswahltabelle referenziert werden
- Die Erstellung von Bildern im Arbeitsverzeichnis mit Spektrogrammen, um
  Benutzern die Organisation von Daten und die Überprüfung akustischer Analysen zu ermöglichen

Das Paket bietet Funktionen zum:

- Erkunden und Herunterladen von [Xeno‐Canto](https://xeno-canto.org/) Aufnahmen
- Erkunden, Organisieren und Bearbeiten mehrerer Audiodateien
- Automatisches Erkennen von Signalen (in Frequenz und Zeit) (aber prüfen Sie das R
  Paket [ohun](https://docs.ropensci.org/ohun/) für eine gründlichere
  und benutzerfreundlichere Implementierung)
- Erstellen von Spektrogrammen kompletter Aufnahmen oder einzelner Signale

- Führen Sie verschiedene Messungen der akustischen Signalstruktur durch
- Bewerten Sie die Leistung der Messmethoden
- Katalogisieren Sie Signale
- Charakterisieren Sie verschiedene Strukturebenen in akustischen Signalen
- Statistische Analyse der Duett-Koordination
- Konsolidieren Sie Datenbanken und Annotations-Tabellen

Die meisten Funktionen ermöglichen die Parallelisierung von Aufgaben, wodurch
die Aufgaben auf mehrere Prozessoren verteilt werden, um die Recheneffizienz
zu verbessern. Werkzeuge zur Bewertung der Analyseleistung in jedem
Schritt sind ebenfalls verfügbar.

## Installation

Installieren/Laden Sie das Paket aus CRAN wie folgt:

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---