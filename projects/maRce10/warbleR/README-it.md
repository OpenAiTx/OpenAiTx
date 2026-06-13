warbleR: Analisi Bioacustica Semplificata
================

🌐 **Lingue:**  
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

<!-- README.md è generato da README.Rmd. Si prega di modificare quel file -->
<!-- badge: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Stato del Progetto: Attivo Il progetto ha raggiunto uno stato stabile e utilizzabile
ed è attivamente
sviluppato.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licenza: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Download
Totali](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
copertura](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) è pensato per
facilitare l'analisi della struttura dei segnali acustici animali in
R. Gli utenti possono raccogliere registrazioni di uccelli ad accesso libero o inserire i propri
dati in un flusso di lavoro che facilita la visualizzazione spettrografica e la
misurazione dei parametri acustici.
[warbleR](https://cran.r-project.org/package=warbleR) sfrutta i
fondamentali strumenti di analisi sonora del pacchetto seewave e offre nuovi
strumenti per l'analisi della struttura acustica. Questi strumenti sono disponibili per
l'analisi batch dei segnali acustici.

Le principali caratteristiche del pacchetto sono:

- Strumenti diversificati per misurare la struttura acustica
- L'uso di cicli per applicare compiti ai segnali acustici referenziati in
  una tabella di selezione
- La produzione di immagini nella directory di lavoro con spettrogrammi per
  permettere agli utenti di organizzare i dati e verificare le analisi acustiche

Il pacchetto offre funzioni per:

- Esplorare e scaricare registrazioni da [Xeno‐Canto](https://xeno-canto.org/)
- Esplorare, organizzare e manipolare più file audio
- Rilevare segnali automaticamente (in frequenza e tempo) (ma controllare il pacchetto R
  [ohun](https://docs.ropensci.org/ohun/) per un'implementazione più completa
  e intuitiva)
- Creare spettrogrammi di registrazioni complete o singoli segnali
- Eseguire diverse misure della struttura dei segnali acustici
- Valutare la performance dei metodi di misurazione
- Catalogare i segnali
- Caratterizzare diversi livelli strutturali nei segnali acustici
- Analisi statistica della coordinazione nei duetti
- Consolidare database e tabelle di annotazione

La maggior parte delle funzioni consente la parallelizzazione dei compiti, il che
distribuisce i compiti tra diversi processori per migliorare le prestazioni computazionali
efficienza. Sono disponibili anche strumenti per valutare le prestazioni dell'analisi ad ogni
fase.

## Installazione

Installa/carica il pacchetto da CRAN come segue:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```

Per installare l'ultima versione di sviluppo da
[github](https://github.com/) sarà necessario il pacchetto R
[remotes](https://cran.r-project.org/package=remotes):

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Utilizzo

Il pacchetto include diverse vignette che spiegano le sue principali funzionalità. La
[Introduzione a
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
fornisce una panoramica delle funzionalità del pacchetto. La vignetta
[Formato dei dati di annotazione](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
offre una descrizione dettagliata del formato richiesto per le annotazioni di input.
Sono inoltre presenti altre tre [vignette del
pacchetto](https://marce10.github.io/warbleR/articles/) con esempi su
come organizzare le funzioni in un flusso di lavoro di analisi acustica.

Una descrizione completa del pacchetto (sebbene un po' datata) si può trovare
in questo [articolo
scientifico](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Altri pacchetti

I pacchetti [seewave](https://cran.r-project.org/package=seewave) e
[tuneR](https://cran.r-project.org/package=seewave) offrono una grande
varietà di funzioni per l’analisi e la manipolazione acustica. Lavorano principalmente
su oggetti wave già importati nell’ambiente R. Il
pacchetto [baRulho](https://cran.r-project.org/package=baRulho) si concentra sulla
quantificazione del degrado indotto dall’habitat dei segnali acustici con dati
di input e output simili a quelli di
[warbleR](https://cran.r-project.org/package=warbleR). Il pacchetto
[Rraven](https://cran.r-project.org/package=Rraven) facilita lo
scambio di dati tra R e il [software di analisi sonora Raven
](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) e può essere molto
utile per incorporare Raven come strumento di annotazione nel flusso di lavoro
di analisi acustica in R. Il pacchetto
[ohun](https://docs.ropensci.org/ohun/) lavora sull’individuazione automatizzata di
eventi sonori, fornendo funzioni per diagnosticare e ottimizzare le routine di
rilevamento. [dynaSpec](https://cran.r-project.org/package=seewave) consente di
creare spettrogrammi dinamici (cioè video di spettrogrammi).

## Citazione


Si prega di citare [warbleR](https://cran.r-project.org/package=warbleR) come segue:

Araya-Salas, M. e Smith-Vidaurre, G. (2017), *warbleR: un pacchetto r per
semplificare l’analisi dei segnali acustici animali*. Methods Ecol Evol. 8,
184-191.

NOTA: si prega di citare anche i pacchetti
[tuneR](https://cran.r-project.org/package=tuneR) e
[seewave](https://cran.r-project.org/package=seewave) se si utilizzano
funzioni per la creazione di spettrogrammi o la misurazione acustica



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---