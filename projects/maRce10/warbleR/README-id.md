<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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


warbleR: Mempermudah Analisis Bioakustik
================

<!-- README.md dibuat dari README.Rmd. Silakan edit file tersebut -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Status Proyek: Aktif Proyek telah mencapai keadaan stabil, dapat digunakan
dan sedang
dikembangkan secara aktif.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Lisensi: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Unduhan](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Cakupan uji
Codecov](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="logo warbleR" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) bertujuan untuk
memfasilitasi analisis struktur sinyal akustik hewan di
R. Pengguna dapat mengumpulkan rekaman burung akses terbuka atau memasukkan
data mereka sendiri ke dalam alur kerja yang memudahkan visualisasi spektrografik dan
pengukuran parameter akustik.
[warbleR](https://cran.r-project.org/package=warbleR) memanfaatkan
alat analisis suara mendasar dari paket seewave, serta menawarkan alat baru
untuk analisis struktur akustik. Alat-alat ini tersedia untuk
analisis batch sinyal akustik.

Fitur utama dari paket ini adalah:

- Beragam alat untuk mengukur struktur akustik
- Penggunaan loop untuk menerapkan tugas pada sinyal akustik yang direferensikan dalam
  tabel seleksi
- Produksi gambar di direktori kerja dengan spektrogram untuk
  memungkinkan pengguna mengorganisasi data dan memverifikasi analisis akustik

Paket ini menawarkan fungsi untuk:

- Menjelajahi dan mengunduh rekaman [Xeno‐Canto](https://xeno-canto.org/)
- Menjelajahi, mengorganisasi, dan memanipulasi banyak file suara
- Mendeteksi sinyal secara otomatis (dalam frekuensi dan waktu) (namun cek paket R
  [ohun](https://docs.ropensci.org/ohun/) untuk implementasi yang lebih lengkap
  dan ramah)
- Membuat spektrogram dari rekaman lengkap atau sinyal individual
- Jalankan berbagai ukuran struktur sinyal akustik
- Evaluasi kinerja metode pengukuran
- Katalogkan sinyal
- Karakterisasi tingkat struktural yang berbeda dalam sinyal akustik
- Analisis statistik koordinasi duet
- Konsolidasikan basis data dan tabel anotasi

Sebagian besar fungsi memungkinkan paralelisasi tugas, yang
mendistribusikan tugas di antara beberapa prosesor untuk meningkatkan
efisiensi komputasi. Alat untuk mengevaluasi kinerja analisis pada setiap
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---