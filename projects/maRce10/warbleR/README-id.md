warbleR: Analisis Bioakustik yang Efisien
================

🌐 **Bahasa:**  
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

<!-- README.md dihasilkan dari README.Rmd. Silakan edit file tersebut -->
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

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="logo warbleR" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) ditujukan untuk
memfasilitasi analisis struktur sinyal akustik hewan dalam
R. Pengguna dapat mengumpulkan rekaman burung akses terbuka atau memasukkan
data mereka sendiri ke dalam alur kerja yang memudahkan visualisasi spektrogram dan
pengukuran parameter akustik.
[warbleR](https://cran.r-project.org/package=warbleR) menggunakan
alat analisis suara dasar dari paket seewave, serta menawarkan alat baru
untuk analisis struktur akustik. Alat-alat ini tersedia untuk
analisis batch sinyal akustik.

Fitur utama dari paket ini adalah:

- Beragam alat untuk mengukur struktur akustik
- Penggunaan loop untuk menerapkan tugas pada sinyal akustik yang direferensikan dalam
  tabel seleksi
- Pembuatan gambar di direktori kerja dengan spektrogram untuk
  memungkinkan pengguna mengatur data dan memverifikasi analisis akustik

Paket ini menawarkan fungsi untuk:

- Menjelajahi dan mengunduh rekaman [Xeno‐Canto](https://xeno-canto.org/)
- Menjelajahi, mengatur, dan memanipulasi beberapa file suara
- Mendeteksi sinyal secara otomatis (dalam frekuensi dan waktu) (namun cek paket R
  [ohun](https://docs.ropensci.org/ohun/) untuk implementasi yang lebih menyeluruh
  dan ramah)
- Membuat spektrogram rekaman lengkap atau sinyal individu
- Menjalankan berbagai pengukuran struktur sinyal akustik
- Mengevaluasi kinerja metode pengukuran
- Mengkatalogkan sinyal
- Mengkarakterisasi berbagai tingkat struktur dalam sinyal akustik
- Analisis statistik koordinasi duet
- Mengkonsolidasi basis data dan tabel anotasi

Sebagian besar fungsi memungkinkan paralelisasi tugas, yang
mendistribusikan tugas di antara beberapa prosesor untuk meningkatkan komputasi
efisiensi. Alat untuk mengevaluasi kinerja analisis pada setiap
langkah juga tersedia.

## Instalasi

Instal/muat paket dari CRAN sebagai berikut:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```

Untuk menginstal versi pengembangan terbaru dari
[github](https://github.com/) Anda akan membutuhkan paket R
[remotes](https://cran.r-project.org/package=remotes):

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```
## Penggunaan

Paket ini mencakup beberapa vignette yang menjelaskan fitur utamanya. 
[Intro ke
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
menyediakan gambaran umum tentang fungsi-fungsi dalam paket ini. Vignette
[Format data anotasi
](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
memberikan deskripsi rinci tentang format yang diperlukan untuk anotasi
masukan. Ada juga tiga [vignette paket](https://marce10.github.io/warbleR/articles/) tambahan dengan contoh cara
mengorganisasi fungsi dalam alur kerja analisis akustik.

Deskripsi lengkap tentang paket ini (meskipun sedikit usang) dapat ditemukan
dalam [artikel jurnal
ini](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Paket lain

Paket [seewave](https://cran.r-project.org/package=seewave) dan
[tuneR](https://cran.r-project.org/package=seewave) menyediakan banyak
fungsi untuk analisis dan manipulasi akustik. Mereka sebagian besar
bekerja pada objek wave yang sudah diimpor ke lingkungan R. Paket
[baRulho](https://cran.r-project.org/package=baRulho) berfokus pada
kuantifikasi degradasi sinyal akustik yang disebabkan oleh habitat dengan
input dan output data yang serupa dengan
[warbleR](https://cran.r-project.org/package=warbleR). Paket
[Rraven](https://cran.r-project.org/package=Rraven) memfasilitasi
pertukaran data antara R dan [perangkat lunak analisis suara Raven
](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) dan dapat sangat
berguna untuk mengintegrasikan Raven sebagai alat anotasi dalam alur kerja
analisis akustik di R. Paket
[ohun](https://docs.ropensci.org/ohun/) digunakan untuk deteksi otomatis
kejadian suara, menyediakan fungsi untuk mendiagnosis dan mengoptimalkan
rutin deteksi. [dynaSpec](https://cran.r-project.org/package=seewave)
memungkinkan untuk membuat spektrogram dinamis (yaitu video spektrogram).

## Sitasi



Silakan kutip [warbleR](https://cran.r-project.org/package=warbleR) sebagai
berikut:

Araya-Salas, M. dan Smith-Vidaurre, G. (2017), *warbleR: an r package to
streamline analysis of animal acoustic signals*. Methods Ecol Evol. 8,
184-191.

CATATAN: mohon juga kutip paket
[tuneR](https://cran.r-project.org/package=tuneR) dan
[seewave](https://cran.r-project.org/package=seewave) jika Anda
menggunakan fungsi-fungsi pembuatan spektrogram atau pengukuran akustik


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---