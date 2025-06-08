# Mamba: Manajer Paket Lintas-Platform yang Cepat

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">bagian dari mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Manajer Paket <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Server Paket <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` adalah reimplementasi dari manajer paket conda dalam C++.

- pengunduhan data repositori dan file paket secara paralel menggunakan multi-threading
- libsolv untuk pemecahan dependensi yang jauh lebih cepat, sebuah pustaka mutakhir yang digunakan dalam manajer paket RPM milik Red Hat, Fedora, dan OpenSUSE
- bagian inti dari `mamba` diimplementasikan dalam C++ untuk efisiensi maksimum

Pada saat yang sama, `mamba` menggunakan parser baris perintah, kode instalasi dan penghapusan paket, serta rutinitas verifikasi transaksi yang sama dengan `conda` untuk menjaga kompatibilitas semaksimal mungkin.

`mamba` adalah bagian dari ekosistem [conda-forge](https://conda-forge.org/), yang juga terdiri dari `quetz`, sebuah server paket `conda` open source.

Anda dapat membaca [pengumuman blog kami](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23).

## micromamba

`micromamba` adalah versi `mamba` yang di-link secara statis.

Ini dapat diinstal sebagai executable mandiri tanpa dependensi apa pun, sehingga sangat cocok untuk pipeline CI/CD dan lingkungan terkontainerisasi.

Lihat [dokumentasi tentang `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) untuk detailnya.

## `mamba` vs. `micromamba`

`mamba` harus dipilih ketika:

- `libmambapy` atau `libmamba` digunakan oleh perangkat lunak lain dalam lingkungan yang sama.
- Skenario di mana pembaruan rutin terhadap pustaka diperlukan (terutama untuk keamanan).
- Lingkungan yang berfokus pada pengurangan penggunaan ruang disk untuk dependensi.

`micromamba` harus dipilih ketika:

- Mengandalkan satu executable yang mandiri diperlukan.
- Distribusi miniforge tidak tersedia.
- Penggunaan membutuhkan runtime minimal.

## Instalasi

Silakan merujuk ke panduan instalasi [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
dan [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) di dokumentasi.

## Fitur tambahan di Mamba dan Micromamba

`mamba` dan `micromamba` hadir dengan fitur di atas `conda` standar.

### `repoquery`

Untuk melakukan query repositori dan dependensi paket secara efisien, Anda dapat menggunakan `mamba repoquery` atau `micromamba repoquery`.

Lihat [dokumentasi repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) untuk detailnya.

### Instalasi file lock

`micromamba` dapat digunakan untuk menginstal file lock yang dihasilkan oleh [conda-lock](https://conda.github.io/conda-lock/) tanpa harus menginstal `conda-lock`.

Cukup jalankan `micromamba create` dengan opsi `-f`, berikan file lock environment yang namanya diakhiri dengan
`-lock.yml` atau `-lock.yaml`; misalnya:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (pengganti setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) adalah pengganti untuk [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) yang menggunakan `micromamba`.

Ini dapat secara signifikan mengurangi waktu setup CI Anda dengan:

- Menggunakan `micromamba`, yang memerlukan waktu sekitar 1 detik untuk instalasi.
- Men-cache unduhan paket.
- Men-cache seluruh lingkungan `conda`.

## Perbedaan dengan `conda`

Meskipun `mamba` dan `micromamba` umumnya dapat digunakan sebagai pengganti langsung untuk `conda`, terdapat beberapa perbedaan:

- `mamba` dan `micromamba` tidak mendukung revisi (untuk diskusi, lihat <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` dan `micromamba` menormalkan string `MatchSpec` ke bentuk paling sederhana, sedangkan `conda` menggunakan bentuk yang lebih verbose
  Hal ini dapat menyebabkan sedikit perbedaan pada output `conda env export` dan `mamba env export`.

## Instalasi pengembangan

Silakan merujuk ke petunjuk yang diberikan oleh [dokumentasi resmi](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## Stabilitas API dan ABI

Proyek Mamba menggunakan [penomoran versi semantik](https://semver.org/) dengan format `MAJOR.MINOR.PATCH`.
Walaupun kami berusaha menjaga stabilitas bagi pengguna, kami juga perlu melakukan perubahan besar untuk meningkatkan
Mamba dan mengurangi utang teknis.
Versi Mamba berikutnya dapat memberikan jaminan yang lebih kuat.

### `libmamba` (C++)

Kami tidak mengetahui adanya pengguna API C++, sehingga kami memberikan ruang untuk perbaikan.
Untuk `libmamba`, istilah _kompatibel mundur_ dipahami sebagai berikut:

- _ABI kompatibel mundur_ berarti Anda dapat mengganti file biner pustaka tanpa mengompilasi ulang
  kode Anda dengan header yang diperbarui.
  Perilaku yang diamati akan sama, kecuali untuk bug (yang semoga menghilang) dan performa.
- _API kompatibel mundur_ berarti Anda harus mengompilasi ulang kode Anda dengan kode versi pustaka baru,
  namun Anda tidak perlu mengubah kode Anda, cukup di-build ulang saja.
  Ini berlaku selama Anda tidak menggunakan deklarasi yang dianggap privat, misalnya
  dalam sub-namespace `detail`.
  Perilaku yang diamati akan sama, kecuali untuk bug (yang semoga menghilang) dan performa.
  Ketika deklarasi didepresiasi tetapi tidak dihapus dan masih berfungsi, kami juga menganggapnya
  kompatibel mundur, karena hanya perilaku saat kompilasi yang berubah.

Dengan pemahaman ini, `libmamba` menawarkan jaminan berikut:

- Rilis `PATCH` adalah API dan ABI kompatibel mundur;
- Rilis `MINOR` adalah API kompatibel untuk deklarasi di `mamba/api`,
  Mereka dapat memutus API di tempat lain dan ABI di mana saja;
- Rilis `MAJOR` tidak memberikan jaminan.

### `libmambapy` (Python)

Untuk `libmambapy`, istilah _API kompatibel mundur_ berarti bahwa kode Python Anda akan berfungsi sama
untuk versi `libmambapy` yang lebih baru selama Anda tidak menggunakan deklarasi yang dianggap privat,
misalnya yang diakses dengan nama yang diawali `_`.
Perilaku yang diamati akan sama, kecuali untuk bug (yang semoga menghilang) dan performa.
Ketika deklarasi didepresiasi tetapi tidak dihapus dan masih berfungsi, kami juga menganggapnya
kompatibel mundur, karena perilaku hanya dapat diamati ketika mengaktifkan Python
`DeprecationWarning`, yang biasanya hanya diaktifkan dalam pengembangan.

Dengan pemahaman ini, `libmambapy` menawarkan jaminan berikut:

- Rilis `PATCH` adalah API kompatibel mundur;
- Rilis `MINOR` adalah API kompatibel mundur;
- Rilis `MAJOR` tidak memberikan jaminan.

### `mamba` dan `micromamba` (eksekutabel)

Untuk eksekutabel, istilah _kompatibel mundur_ berlaku untuk input dan output yang dapat diprogram dan berarti
bahwa kode Anda (termasuk shell script) akan berfungsi dengan versi eksekutabel yang lebih baru tanpa
modifikasi.
Input/output yang dapat diprogram termasuk nama eksekutabel, argumen baris perintah, file konfigurasi,
variabel lingkungan, output baris perintah JSON, dan file yang dibuat.
Ini _tidak termasuk_ output yang dapat dibaca manusia dan pesan error, sehingga peringatan deprecation yang ditulis
dalam output yang dapat dibaca manusia tidak termasuk.

Dengan pemahaman ini, `mamba` dan `micromamba` menawarkan jaminan berikut:

- Rilis `PATCH` adalah kompatibel mundur;
- Rilis `MINOR` adalah kompatibel mundur;
- Rilis `MAJOR` tidak memberikan jaminan.

## Dukung kami

Hanya `mamba` dan `micromamba` versi 2.0 ke atas yang didukung dan dikembangkan secara aktif.

Branch `1.x` hanya dipelihara untuk penanganan masalah keamanan seperti CVE.

Untuk pertanyaan, Anda juga dapat bergabung bersama kami di [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
atau di [saluran Conda](https://gitter.im/conda/conda) (perlu dicatat bahwa proyek ini tidak secara resmi berafiliasi dengan `conda` atau Anaconda Inc.).

## Lisensi

Kami menggunakan model hak cipta bersama yang memungkinkan semua kontributor untuk mempertahankan hak cipta atas kontribusi mereka.

Perangkat lunak ini dilisensikan di bawah lisensi BSD-3-Clause. Lihat file [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) untuk detailnya.

---

### Pertemuan Dev Dua Mingguan

Kami mengadakan pertemuan via videoconference setiap dua minggu sekali di mana kami mendiskusikan apa yang sedang kami kerjakan dan mendapatkan masukan satu sama lain.

Siapa pun dipersilakan untuk hadir, baik untuk mendiskusikan topik tertentu maupun hanya mendengarkan.

- Waktu: Selasa [16:00 CET (Eropa)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Tempat: [Mamba jitsi](https://meet.jit.si/mamba-org)
- Catatan: [Catatan pertemuan](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---