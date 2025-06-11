# Containerization

Paket Containerization memungkinkan aplikasi menggunakan kontainer Linux.  
Containerization ditulis dalam [Swift](https://www.swift.org) dan menggunakan [Virtualization.framework](https://developer.apple.com/documentation/virtualization) pada Apple silicon.

Containerization menyediakan API untuk:

- [Mengelola gambar OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Berinteraksi dengan registri jarak jauh](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [Membuat dan mengisi sistem file ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Berinteraksi dengan keluarga soket Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Membuat kernel Linux yang dioptimalkan untuk waktu boot cepat](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Menjalankan mesin virtual ringan dan mengelola lingkungan runtime](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Menjalankan dan berinteraksi dengan proses yang dikontainerisasi](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Menggunakan Rosetta 2 untuk menjalankan kontainer linux/amd64 pada Apple silicon.

Silakan lihat [dokumentasi API](https://apple.github.io/containerization/documentation/) untuk informasi mengenai paket Swift yang disediakan Containerization.

## Desain

Containerization menjalankan setiap kontainer Linux di dalam mesin virtual ringan sendiri. Klien dapat membuat alamat IP khusus untuk setiap kontainer guna menghilangkan kebutuhan penerusan port individual. Kontainer mencapai waktu mulai kurang dari satu detik menggunakan [konfigurasi kernel Linux](/kernel) yang dioptimalkan dan sistem file root minimal dengan sistem init ringan.

[vminitd](/vminitd) adalah sistem init kecil, yang merupakan subproyek dalam Containerization.  
`vminitd` dijalankan sebagai proses awal di dalam mesin virtual dan menyediakan API GRPC melalui vsock.  
API ini memungkinkan lingkungan runtime dikonfigurasi dan proses yang dikontainerisasi dijalankan.  
`vminitd` menyediakan I/O, sinyal, dan event ke proses pemanggil saat proses dijalankan.

## Persyaratan

Anda memerlukan Mac dengan Apple silicon untuk membangun dan menjalankan Containerization.

Untuk membangun paket Containerization, sistem Anda memerlukan salah satu dari:

- macOS 15 atau lebih baru dan Xcode 26 beta
- macOS 26 beta atau lebih baru

Aplikasi yang dibangun menggunakan paket ini akan berjalan di macOS 15 atau lebih baru, tetapi fitur berikut tidak tersedia di macOS 15:

- Jaringan kontainer non-terisolasi - dengan macOS 15, kontainer di jaringan vmnet yang sama tidak dapat saling berkomunikasi

## Contoh Penggunaan

Untuk contoh cara menggunakan beberapa perpustakaan, executable cctl adalah tempat yang baik untuk memulai. Alat ini terutama berfungsi sebagai arena percobaan API. Ini berisi perintah yang menguji beberapa fungsi inti berbagai produk, seperti:

1. [Manipulasi gambar OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Login ke registri kontainer](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Membuat blok sistem file root](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Menjalankan kontainer Linux sederhana](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Kernel Linux

Kernel Linux diperlukan untuk menjalankan mesin virtual ringan di macOS.  
Containerization menyediakan konfigurasi kernel yang dioptimalkan yang terletak di direktori [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

Direktori ini mencakup lingkungan build yang dikontainerisasi untuk memudahkan kompilasi kernel yang digunakan dengan Containerization.

Konfigurasi kernel ini merupakan set fitur minimal untuk mendukung waktu mulai cepat dan lingkungan ringan.

Meski konfigurasi ini akan bekerja untuk sebagian besar beban kerja, kami memahami bahwa beberapa membutuhkan fitur tambahan.  
Untuk mengatasi ini, Containerization menyediakan API kelas satu untuk menggunakan konfigurasi dan versi kernel berbeda per kontainer.  
Ini memungkinkan kontainer dikembangkan dan divalidasi pada berbagai versi kernel.

Lihat [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) di direktori kernel untuk instruksi cara mengompilasi kernel yang dioptimalkan.

### Kernel Pre-build

Jika Anda ingin menggunakan kernel yang sudah dibangun, kernel tersebut harus memiliki driver `VIRTIO` yang dikompilasi langsung ke kernel, bukan sebagai modul.

Proyek [Kata Containers](https://github.com/kata-containers/kata-containers) menyediakan kernel yang dioptimalkan untuk kontainer dengan semua opsi konfigurasi yang diperlukan diaktifkan, tersedia di halaman [rilisan](https://github.com/kata-containers/kata-containers/releases/).

Gambar kernel bernama `vmlinux.container` dapat ditemukan di direktori `/opt/kata/share/kata-containers/` dari artefak rilis.

## Persiapan membangun paket

Pasang Swiftly, [Swift](https://www.swift.org), dan [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Jika Anda menggunakan aplikasi terminal kustom, Anda mungkin perlu memindahkan perintah ini dari `.zprofile` ke `.zshrc` (ganti `<USERNAME>`):

```bash
# Ditambahkan oleh swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Mulai ulang aplikasi terminal. Pastikan perintah ini mengembalikan `/Users/<USERNAME>/.swiftly/bin/swift` (ganti `<USERNAME>`):

```bash
which swift
```

Jika Anda sebelumnya memasang atau menggunakan Static Linux SDK, Anda mungkin perlu menghapus versi SDK lama dari sistem (ganti `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Membangun paket

Bangun Containerization dari sumber:

```bash
make all
```

## Menguji paket

Setelah membangun, jalankan tes dasar dan integrasi:

```bash
make test integration
```

Kernel diperlukan untuk menjalankan tes integrasi.  
Jika Anda tidak memiliki kernel secara lokal, kernel default dapat diambil menggunakan target `make fetch-default-kernel`.

Pengambilan kernel default hanya perlu dilakukan setelah build awal atau setelah `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization bergantung pada versi spesifik `grpc-swift` dan `swift-protobuf`. Anda dapat memasangnya dan menghasilkan ulang interface RPC dengan:

```bash
make protos
```

## Dokumentasi

Hasilkan dokumentasi API untuk dilihat secara lokal dengan:

```bash
make docs
make serve-docs
```

Pratinjau dokumentasi dengan menjalankan di terminal lain:

```bash
open http://localhost:8000/documentation/
```

## Kontribusi

Kontribusi untuk Containerization sangat diterima dan didorong. Silakan lihat [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) untuk informasi lebih lanjut.

## Status Proyek

Versi 0.1.0 adalah rilis resmi pertama Containerization. Versi sebelumnya tidak menjamin stabilitas sumber.

Karena perpustakaan Containerization dalam pengembangan aktif, stabilitas sumber hanya dijamin dalam versi minor (misalnya antara 0.1.1 dan 0.1.2). Jika Anda tidak ingin pembaruan paket yang berpotensi memutus sumber, Anda dapat menentukan ketergantungan paket Anda menggunakan .upToNextMinorVersion(from: "0.1.0").

Versi minor paket mendatang mungkin memperkenalkan perubahan pada aturan ini sesuai kebutuhan.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---