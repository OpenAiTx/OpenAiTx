# Komponen Web Gambar Fluid

Gambar yang dapat diskalakan secara cerdas ke ukuran apa pun yang diinginkan (dalam batas wajar).

![Gambar Fluid](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Sangat kecil!:** 7kb setelah dimampatkan & digzip

## Penggunaan

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

Itu saja. Ubah skala gambar sesuai keinginan, dan mereka akan bekerja sebagaimana mestinya.

## Demo

[Demo di sini](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

Sebuah playground juga tersedia untuk [mencoba dengan gambar Anda sendiri](https://voicengo.github.io/fluid-img/public).
## Instalasi

### Library Klien

```sh
npm install fluid-img
```

Kemudian impor `fluid-img` ke dalam proyek Anda, yang menyediakan dan mendaftarkan web-component:

```ts
import 'fluid-img';
```

Atau sertakan skrip dari jsdelivr atau unpkg:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- atau -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Peringatan

Komponen gambar fluid bekerja paling baik untuk penskalaan gambar secara horizontal atau vertikal dalam rentang sekitar 0,5x hingga 1,5x dari ukuran aslinya. Meskipun dapat menangani skala yang lebih besar atau lebih kecil, kualitas visual dapat menurun dengan cepat. Komponen ini tidak direkomendasikan untuk gambar di mana integritas piksel yang presisi sangat penting, seperti potret, grafik, atau gambar teknis yang detail, karena seam carving dapat menyebabkan distorsi. Sangat disarankan untuk menguji gambar Anda pada berbagai ukuran untuk memastikan gambar memenuhi ekspektasi visual Anda.

#### CORS

Karena pembatasan keamanan browser, gambar yang dimuat dari asal (domain, protokol, atau port) yang berbeda dari halaman web akan memicu kesalahan Cross-Origin Resource Sharing (CORS). Komponen ini membutuhkan akses ke data piksel mentah dari gambar, yang dibatasi oleh CORS.

Untuk menggunakan gambar dari asal yang berbeda, server yang menghosting gambar harus dikonfigurasi untuk mengirim header CORS yang sesuai (misal, `Access-Control-Allow-Origin: *` atau `Access-Control-Allow-Origin: your-domain.com`). Tanpa header ini, komponen tidak akan dapat memproses gambar.

(Sebagai informasi, untuk keperluan pengujian, gambar apa pun di imgur sudah memiliki header CORS yang diperlukan)

#### Fallback

Jika komponen gagal memuat atau memproses gambar, atau terjadi kesalahan internal, maka secara otomatis akan beralih dengan menyuntikkan tag `<img>` standar ke dalam komponen `<fluid-img>`, dengan lebar & tinggi 100%, sehingga gambar tetap dapat ditampilkan.

## Opsi

Penggunaan: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Secara default, generator `random` digunakan karena merupakan yang tercepat.

| Opsi                            | Nilai                             | Default       | Deskripsi                                                                                                             |
| ------------------------------- | --------------------------------- | ------------- | --------------------------------------------------------------------------------------------------------------------- |
| `src`                           | URL                               |               | URL dari gambar yang akan diproses.                                                                                   |
| `generator`                     | `random`, `predictive`            | `predictive`  | Generator seam carving yang digunakan. `random` lebih cepat tapi kualitasnya lebih rendah.                            |
| `scaling-axis`                  | `horizontal`, `vertical`, `auto`  | `horizontal`  | Sumbu untuk penskalaan. `auto` akan menskalakan secara horizontal atau vertikal berdasarkan perubahan rasio aspek.    |
| `mask`                          | URL                               |               | URL dari gambar mask. Area hitam pada mask memiliki energi lebih rendah dan lebih mungkin dipertahankan.              |
| `carving-priority`              | Angka (0-1, misal `0.5`)          | `1`           | Persentase penskalaan yang dilakukan dengan seam carving vs. penskalaan gambar tradisional.                           |
| `max-carve-up-seam-percentage`  | Angka (0-1, misal `0.5`)          | `0.6`         | Persentase maksimum seam yang dapat dimasukkan saat penskalaan naik. Membatasi pembuatan seam baru untuk menjaga kualitas gambar. |
| `max-carve-up-scale`            | Angka (misal `3`)                 | `3`           | Faktor pembesaran maksimum menggunakan seam carving. Di atas ini, digunakan penskalaan tradisional.                   |
| `max-carve-down-scale`          | Angka (0-1, misal `0.7`)          | `0.7`         | Persentase maksimum gambar yang dapat dihapus oleh seam carving saat penskalaan turun.                                |
### Opsi spesifik Generator

Opsi spesifik generator ditambahkan ke komponen `<fluid-img>` tetapi hanya berlaku ketika atribut
`generator` yang sesuai juga diatur

#### Opsi Generator Acak & Prediktif

| Opsi               | Nilai                  | Default | Deskripsi                                        |
| ------------------ | --------------------- | ------- | ------------------------------------------------ |
| `batch-percentage` | Angka (0-1, misal 0.1) | 0.1     | Persentase seam yang dihasilkan per batch        |
| `min-batch-size`   | Angka (misal `10`)     | 10      | Jumlah minimum seam yang dihasilkan per batch    |

## Cara kerjanya

Seam carving adalah teknik mengubah ukuran gambar yang menyadari konten, yang secara cerdas menghapus atau menambah piksel, memungkinkan gambar diubah ukurannya tanpa mendistorsi konten penting. Untuk informasi lebih lanjut, lihat [artikel Wikipedia](https://en.wikipedia.org/wiki/Seam_carving) tentang topik ini.

Secara historis, seam carving terlalu intensif secara komputasi untuk digunakan secara real-time di peramban web. Namun, keterbatasan ini dapat diatasi dengan menggunakan algoritme alternatif yang lebih ringan dan bekerja dengan baik di banyak skenario.

Ada dua implementasi dari generator seam carving:
### Random Carving

Pendekatan random seam carving meninggalkan algoritma seam carving tradisional, yang terlalu lambat untuk eksekusi secara real-time di browser.

Sebagai gantinya, metode ini menghasilkan satu set seam acak yang memberikan cakupan gambar 100% dengan menghubungkan setiap piksel dalam satu baris ke piksel tetangga di baris berikutnya. Kemudian, metode ini melakukan iterasi pada setiap seam, menghitung energinya, dan membuang sejumlah seam dengan energi terendah. Proses ini diulang hingga jumlah seam yang diinginkan tercapai. Metode ini menghasilkan hasil yang mengejutkan baik untuk banyak gambar.

### Predictive Carving

Mirip dengan random carving, metode ini menghasilkan peta energi dan membuat seam dalam batch. Metode ini juga menghasilkan peta energi minimal untuk setiap batch. Ide utamanya adalah membuat seam "baik" dan "buruk". Seam baik memiliki energi rendah dan dipertahankan. Seam buruk memasukkan piksel berenergi tinggi, sehingga dapat disaring nanti.

Dimulai dari baris pertama, metode ini menghubungkan pasangan piksel ke pasangan yang sesuai di baris berikutnya. Seam dengan energi lebih rendah dari perhitungan berjalan dihubungkan ke seam energi lebih rendah dari peta energi minimal.

Hasil akhirnya adalah satu seam yang benar-benar optimal, banyak seam "sangat baik", banyak seam "sangat buruk", dan banyak seam yang biasa saja. Kita memilih satu batch dari seam "baik", membuang sisanya, dan mengulangi prosesnya.

##

## TODO

### Prioritas Tinggi

- [x] Komponen web
- [x] Renderer yang mengambil data dari generator dan dapat diskalakan ke ukuran apa pun
- [x] Generator acak
- [x] Carving vertikal
- [x] Generator prediktif
- [ ] Web worker untuk semua generator
### Prioritas Rendah

- [x] Masking
- [ ] Pengenalan wajah

### Impian

- [ ] Ukir 2D

## Lisensi

Perangkat lunak ini dilisensikan di bawah Fluid-Img Revenue-Limited License.

**Penggunaan gratis** untuk individu dan organisasi dengan pendapatan kotor tahunan di bawah $10.000.000 USD.

**Lisensi komersial diperlukan** untuk organisasi dengan pendapatan tahunan $10 juta atau lebih. Hubungi [licensing@voice.ngo] untuk persyaratan lisensi komersial.

Lihat berkas [LICENSE](./LICENSE) untuk syarat lengkap.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---