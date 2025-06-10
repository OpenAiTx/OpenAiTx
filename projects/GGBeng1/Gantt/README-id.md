# Gantt

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
Mendukung stretching
Mendukung persentase
Mendukung rentang waktu: hari, minggu, bulan
Saat ini hanya mendukung pengelompokan satu tingkat, namun untuk mengantisipasi kebutuhan pengelompokan dua tingkat atau lebih di masa depan, pada commit sebelumnya telah dilakukan refactor kode untuk mendukung multi-level grouping, namun versi saat ini belum dikembangkan

Keunggulan: Saat melakukan drag, stretch, atau mengubah progress, data tidak langsung diperbarui secara real-time, tetapi diperbarui setelah operasi selesai, sehingga mengurangi beban kinerja
      Saat mengedit, menghapus, atau menambah, tidak dilakukan modifikasi rekursif secara keseluruhan pada instance, tetapi hanya pada bagian yang diubah saja

Sedang mempersiapkan penataan ulang untuk modularisasi komponen, saat ini jika ingin digunakan dalam proyek cukup mengimpor `gant.vue` dari proyek ini
Metode impor dan ekspor data massal sudah tersedia, cukup copy saja!~
```

### Catatan Pembaruan

- Mendukung edit
- Mendukung hapus
- Memperbaiki bug tidak bisa scroll vertikal (sekaligus menambah scroll dua arah) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Memperbaiki bug yang disebabkan oleh elementUI
- Mengenai masalah rentang waktu [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Saat ini belum dapat mengubah rentang waktu lain (misal, menambah jam) hanya dengan konfigurasi, karena beberapa konfigurasi sudah di-set saat inisialisasi, namun akan diubah dan dirilis sebagai api di update berikutnya

### Melihat Contoh

Lihat [demo](https://ggbeng1.github.io/Gantt/#/)

### Gambar Tampilan

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---