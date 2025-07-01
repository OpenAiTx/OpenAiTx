# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Instalasi

```
yarn install
```

### Menjalankan

```
yarn run serve
```

### Penjelasan

```
Gantt chart yang dikembangkan berbasis vue, dapat digunakan untuk kolaborasi tim, pembagian tugas, dan skenario agile lainnya

Mendukung pengelompokan
Mendukung drag and drop
Mendukung peregangan
Mendukung persentase
Mendukung rentang waktu: hari, minggu, bulan
Saat ini hanya mendukung satu tingkat pengelompokan, untuk mengantisipasi kebutuhan pengelompokan dua tingkat atau multi-tingkat di masa depan, pada commit sebelumnya telah dilakukan refaktor sebagian kode untuk mendukung multi-level group, namun versi saat ini belum dikembangkan

Keunggulan: Pada saat melakukan drag, peregangan, pengubahan progres, data tidak diperbarui secara real-time, tetapi diperbarui setelah operasi selesai, sehingga mengurangi beban performa
             Pada saat edit, hapus, tambah, tidak dilakukan perubahan secara rekursif ke seluruh instance, hanya bagian yang berubah saja yang diubah

Sedang dalam persiapan untuk reorganisasi, menuju komponenisasi, saat ini jika ingin digunakan dalam proyek hanya perlu mengimpor `gant.vue` dari proyek ini
Metode impor dan ekspor data dalam jumlah besar sudah tersedia, tinggal copy saja!~
```

### Catatan Pembaruan

- Mendukung pengeditan
- Mendukung penghapusan
- Memperbaiki bug tidak bisa scroll vertikal (sekaligus menambah scroll dua arah secara bersamaan) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Memperbaiki bug yang disebabkan oleh elementUI
- Tentang masalah rentang waktu [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Saat ini belum bisa mengubah rentang lain melalui konfigurasi rentang, seperti menambah jam, dsb. Karena pada saat inisialisasi beberapa konfigurasi sudah dikunci, ke depannya akan diubah dan dirilis sebagai api


### Lihat Contoh

Lihat [demo](https://ggbeng1.github.io/Gantt/#/)

### Gambar Tampilan

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---