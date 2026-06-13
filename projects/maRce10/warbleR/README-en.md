warbleR: Streamline Bioacoustic Analysis
================

🌐 **Languages:**  
[English](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Español](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Français](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Português](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiano](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Русский](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文 (Simplified)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文 (Traditional)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[Japanese](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[Korean](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[Hindi](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[Thai](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Dutch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polish](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[Arabic](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[Persian](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Turkish](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Vietnamese](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Indonesian](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[Assamese](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md is generated from README.Rmd. Please edit that file -->
<!-- badges: start -->

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

[warbleR](https://cran.r-project.org/package=warbleR) is designed to
facilitate the analysis of animal acoustic signal structure in
R. Users can collect open-access bird recordings or input their own
data into a workflow that supports spectrographic visualization and
measurement of acoustic parameters.
[warbleR](https://cran.r-project.org/package=warbleR) utilizes the
core sound analysis tools from the seewave package, and provides new
tools for acoustic structure analysis. These tools are available for
batch analysis of acoustic signals.

The main features of the package are:

- A variety of tools for measuring acoustic structure
- The use of loops to apply tasks across acoustic signals referenced in
  a selection table
- The creation of images in the working directory with spectrograms to
  help users organize data and verify acoustic analyses

The package offers functions to:

- Explore and download [Xeno‐Canto](https://xeno-canto.org/) recordings
- Explore, organize, and manipulate multiple sound files
- Automatically detect signals (in frequency and time) (but see the R
  package [ohun](https://docs.ropensci.org/ohun/) for a more comprehensive
  and user-friendly implementation)
- Create spectrograms of entire recordings or individual signals
- Run various measures of acoustic signal structure
- Evaluate the performance of measurement methods
- Catalog signals
- Characterize different structural levels in acoustic signals
- Statistical analysis of duet coordination
- Consolidate databases and annotation tables

Most functions allow the parallelization of tasks, distributing the tasks among several processors to improve computational

efficiency. Tools to evaluate the performance of the analysis at each
step are also available.

## Installing

Install/load the package from CRAN as follows:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```
To install the latest developmental version from
[github](https://github.com/) you will need the R package
[remotes](https://cran.r-project.org/package=remotes):


``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Usage

The package includes several vignettes explaining its main features. The
[Intro to
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
provides an overview of the package functionalities. The vignette
[Annotation data
format](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
gives a detailed description of the required format for input
annotations. There are also three additional [package
vignettes](https://marce10.github.io/warbleR/articles/) with examples on
how to organize functions in an acoustic analysis workflow.

A full description of the package (although a bit outdated) can be found
in this [journal
article](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Other packages

The packages [seewave](https://cran.r-project.org/package=seewave) and
[tuneR](https://cran.r-project.org/package=seewave) provide a huge
variety of functions for acoustic analysis and manipulation. They mostly
work on wave objects already imported into the R environment. The
package [baRulho](https://cran.r-project.org/package=baRulho) focuses on
quantifying habitat-induced degradation of acoustic signals with data
inputs and outputs similar to those of
[warbleR](https://cran.r-project.org/package=warbleR). The package
[Rraven](https://cran.r-project.org/package=Rraven) facilitates the
exchange of data between R and [Raven sound analysis
software](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) and can be very
helpful for incorporating Raven as the annotating tool into acoustic
analysis workflow in R. The package
[ohun](https://docs.ropensci.org/ohun/) works on automated detection of
sound events, providing functions to diagnose and optimize detection
routines. [dynaSpec](https://cran.r-project.org/package=seewave) allows
to create dynamic spectrograms (i.e. spectrogram videos).

## Citation

Please cite [warbleR](https://cran.r-project.org/package=warbleR) as
follows:

Araya-Salas, M. and Smith-Vidaurre, G. (2017), *warbleR: an r package to
streamline analysis of animal acoustic signals*. Methods Ecol Evol. 8,
184-191.

NOTE: please also cite the
[tuneR](https://cran.r-project.org/package=tuneR) and
[seewave](https://cran.r-project.org/package=seewave) packages if you
use any spectrogram-creating or acoustic-measuring functions


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---