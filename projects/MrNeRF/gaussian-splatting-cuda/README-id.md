# 3D Gaussian Splatting untuk Rendering Real-Time Radiance Field - Implementasi C++ dan CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

Implementasi C++ dan CUDA berkinerja tinggi dari 3D Gaussian Splatting, dibangun di atas backend rasterisasi [gsplat](https://github.com/nerfstudio-project/gsplat).

## Berita
- **[2025-06-10]**: Memperbaiki beberapa masalah. Kami mendekati metrik gsplat. Namun, masih ada sedikit ketidakcocokan.
- **[2025-06-04]**: Menambahkan strategi MCMC dengan opsi baris perintah `--max-cap` untuk mengontrol jumlah Gaussian maksimum.
- **[2025-06-03]**: Beralih ke backend Gsplat dan memperbarui lisensi.
- **[2024-05-27]**: Memperbarui ke LibTorch 2.7.0 untuk kompatibilitas dan performa lebih baik. Perubahan besar dalam manajemen status optimizer telah diatasi.
- **[2024-05-26]**: Tujuan repo ini saat ini adalah menuju lisensi permisif. Pekerjaan besar telah dilakukan untuk menggantikan rasterizer dengan implementasi gsplat.

## Metrik
Saat ini implementasi ini belum mencapai hasil setara dengan gsplat-mcmc, tetapi ini adalah pekerjaan yang sedang berlangsung.  
Hanya masalah waktu untuk memperbaiki bug. Bantuan sangat disambut :) Metrik untuk strategi mcmc adalah sebagai berikut:

| Scene    | Iterasi  | PSNR          | SSIM         | LPIPS        | Waktu per Gambar | Jumlah Gaussian |
| -------- | -------- | ------------- | ------------ | ------------ | ---------------- | --------------- |
| garden   | 30000    | 27.112114     | 0.854833     | 0.157624     | 0.304765         | 1000000         |
| bicycle  | 30000    | 25.047745     | 0.767729     | 0.254825     | 0.293618         | 1000000         |
| stump    | 30000    | 26.554749     | 0.784203     | 0.263013     | 0.296536         | 1000000         |
| bonsai   | 30000    | 32.534199     | 0.948675     | 0.246924     | 0.436188         | 1000000         |
| counter  | 30000    | 29.187017     | 0.915823     | 0.242159     | 0.441259         | 1000000         |
| kitchen  | 30000    | 31.680832     | 0.933897     | 0.154965     | 0.449078         | 1000000         |
| room     | 30000    | 32.211632     | 0.930754     | 0.273719     | 0.413519         | 1000000         |
| **rata-rata** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**     | **1000000**     |

## Komunitas & Dukungan

Bergabunglah dengan komunitas kami yang terus berkembang untuk diskusi, dukungan, dan pembaruan:  
- 💬 **[Komunitas Discord](https://discord.gg/TbxJST2BbC)** - Dapatkan bantuan, bagikan hasil, dan diskusikan pengembangan  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - Kunjungi situs web kami untuk sumber daya lebih lanjut  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - Daftar paper dan sumber daya lengkap  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - Ikuti untuk pembaruan terbaru  

## Instruksi Build dan Eksekusi

### Prasyarat Perangkat Lunak
1. **Linux** (telah diuji dengan Ubuntu 22.04) - Windows saat ini belum didukung  
2. **CMake** versi 3.24 atau lebih tinggi  
3. **CUDA** versi 11.8 atau lebih tinggi (mungkin bekerja dengan versi lebih rendah dengan konfigurasi manual)  
4. **Python** dengan header pengembangan  
5. **LibTorch 2.7.0** - Instruksi pengaturan di bawah  
6. Dependensi lain ditangani otomatis oleh CMake

### Prasyarat Perangkat Keras
1. **GPU NVIDIA** dengan dukungan CUDA  
    - Telah diuji berhasil: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - Masalah diketahui dengan RTX 3080Ti pada dataset besar (lihat #21)  
2. Kapabilitas komputasi minimum: 8.0

> Jika Anda berhasil menjalankan di perangkat keras lain, silakan bagikan pengalaman Anda di bagian Diskusi!

### Instruksi Build

```bash
# Clone repositori dengan submodule
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# Download dan setup LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Build proyek
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Proyek ini menggunakan **LibTorch 2.7.0** untuk performa dan kompatibilitas optimal:

- **Performa yang Ditingkatkan**: Optimasi dan manajemen memori yang lebih baik  
- **Stabilitas API**: API PyTorch C++ stabil terbaru  
- **Kompatibilitas CUDA**: Integrasi lebih baik dengan CUDA 11.8+  
- **Perbaikan Bug**: Masalah manajemen status optimizer telah diperbaiki  

### Upgrade dari Versi Sebelumnya
1. Unduh versi LibTorch baru menggunakan instruksi build di atas  
2. Bersihkan direktori build Anda: `rm -rf build/`  
3. Build ulang proyek  

## Dataset

Unduh dataset dari repositori asli:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

Ekstrak ke folder `data` di root proyek.

## Opsi Baris Perintah

### Opsi Inti

- **`-h, --help`**  
  Tampilkan menu bantuan

- **`-d, --data-path [PATH]`**  
  Jalur ke data pelatihan (wajib)

- **`-o, --output-path [PATH]`**  
  Jalur untuk menyimpan model terlatih (default: `./output`)

- **`-i, --iter [NUM]`**  
  Jumlah iterasi pelatihan (default: 30000)  
    - Paper menyarankan 30k, tapi 6k-7k sering memberikan hasil awal yang baik  
    - Output disimpan setiap 7k iterasi dan pada akhir pelatihan

- **`-f, --force`**  
  Paksa timpa folder output yang sudah ada

- **`-r, --resolution [NUM]`**  
  Atur resolusi untuk gambar pelatihan

### Opsi Khusus MCMC

- **`--max-cap [NUM]`**  
  Jumlah Gaussian maksimum untuk strategi MCMC (default: 1000000)  
    - Mengontrol batas atas jumlah Gaussian selama pelatihan  
    - Berguna untuk lingkungan dengan memori terbatas

### Contoh Penggunaan

Pelatihan dasar:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

Pelatihan MCMC dengan Gaussian terbatas:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## Pedoman Kontribusi

Kami menyambut kontribusi! Berikut cara memulai:

1. **Memulai**:
    - Periksa isu yang diberi label **good first issues** untuk tugas yang ramah pemula  
    - Untuk ide baru, buka diskusi atau gabung di [Discord](https://discord.gg/TbxJST2BbC)

2. **Sebelum Mengirim PR**:
    - Terapkan `clang-format` untuk konsistensi gaya kode  
    - Gunakan hook pre-commit: `cp tools/pre-commit .git/hooks/`  
    - Diskusikan dependensi baru di isu terlebih dahulu - kami berusaha meminimalkan dependensi  

## Penghargaan

Implementasi ini dibangun berdasarkan beberapa proyek utama:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: Kami menggunakan backend rasterisasi CUDA gsplat yang sangat dioptimalkan, yang memberikan peningkatan performa signifikan dan efisiensi memori lebih baik.

- **3D Gaussian Splatting Asli**: Berdasarkan karya inovatif oleh Kerbl et al.

## Sitasi

Jika Anda menggunakan perangkat lunak ini dalam penelitian Anda, harap sitasi karya asli:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## Lisensi

Lihat file LICENSE untuk detail.

---

**Terhubung dengan kami:**  
- 🌐 Situs Web: [mrnerf.com](https://mrnerf.com)  
- 📚 Paper: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [Gabung komunitas kami](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: Ikuti [@janusch_patas](https://twitter.com/janusch_patas) untuk pembaruan pengembangan

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---