
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Dokumentasi](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Lisensi](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Unduhan](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock untuk test.yaml di masa depan)
[//]: # ([![Status Tes]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Aplikasi Rust yang mengonversi image container (Docker, dll.) menjadi repository Git. Setiap layer container direpresentasikan sebagai commit Git, menjaga riwayat dan struktur dari image asli.

![Demo OCI2Git mengonversi image nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Fitur

- Menganalisis image Docker dan mengekstrak informasi layer
- Membuat repository Git di mana setiap layer image direpresentasikan sebagai commit
- Dukungan untuk layer kosong (ENV, WORKDIR, dll.) sebagai commit kosong
- Ekstraksi metadata secara lengkap ke format Markdown
- Arsitektur yang dapat diperluas untuk mendukung berbagai engine container

## Kasus Penggunaan

### Perbandingan Layer
Saat menelusuri masalah container, Anda dapat menggunakan kemampuan diffing Git yang kuat untuk mengidentifikasi perubahan tepat antara dua layer mana pun. Dengan menjalankan `git diff` antar commit, engineer dapat melihat secara persis file mana yang ditambahkan, diubah, atau dihapus, sehingga lebih mudah memahami dampak dari setiap instruksi Dockerfile dan menemukan perubahan bermasalah.
![Contoh diff layer](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Pelacakan Asal
Dengan menggunakan `git blame`, developer dapat dengan cepat menentukan layer mana yang memperkenalkan file atau baris kode tertentu. Ini sangat berguna saat mendiagnosis masalah pada file konfigurasi atau dependensi. Alih-alih memeriksa setiap layer secara manual, Anda dapat langsung menelusuri asal file mana pun kembali ke layer sumbernya dan instruksi Dockerfile yang sesuai.

### Pelacakan Siklus Hidup File
OCI2Git memungkinkan Anda mengikuti perjalanan file tertentu sepanjang riwayat image container. Anda dapat mengamati kapan sebuah file pertama kali dibuat, bagaimana file tersebut diubah di berbagai layer, dan jika/kapan akhirnya dihapus. Pandangan komprehensif ini membantu memahami evolusi file tanpa harus melacak perubahan secara manual di puluhan layer.

Untuk melacak riwayat suatu file dalam image container Anda — termasuk kapan file itu pertama kali muncul, diubah, atau dihapus — Anda dapat menggunakan perintah Git berikut setelah konversi:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

Perintah-perintah ini memudahkan untuk melacak riwayat lengkap setiap file di seluruh lapisan kontainer tanpa kerumitan mengekstrak dan membandingkan tarball lapisan secara manual.

### Analisis Multi-Lapisan
Terkadang perbandingan yang paling mendalam didapat dari memeriksa perubahan di beberapa lapisan yang tidak berurutan. Dengan OCI2Git, Anda dapat menggunakan alat perbandingan Git untuk menganalisis bagaimana komponen berkembang sepanjang beberapa tahap build, mengidentifikasi pola yang mungkin tidak terlihat jika hanya melihat lapisan yang berdekatan.

### Eksplorasi Lapisan
Dengan menggunakan `git checkout` untuk berpindah ke commit tertentu, Anda dapat memeriksa sistem file kontainer persis seperti yang ada pada lapisan tersebut. Ini memungkinkan pengembang untuk menginspeksi keadaan file dan direktori secara tepat di setiap titik dalam proses pembuatan image, memberikan konteks yang sangat penting saat debugging atau memeriksa perilaku kontainer.
![Checkout ke commit sebelumnya](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Analisis Multi-Image

Saat bekerja dengan beberapa image kontainer yang memiliki asal usul yang sama, OCI2Git secara cerdas membuat branch hanya ketika image benar-benar bercabang. Ini memungkinkan Anda untuk menganalisis beberapa image yang terkait dalam satu repository sambil tetap menjaga riwayat umum mereka.

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git secara otomatis mendeteksi lapisan yang dibagikan antar image dan membuat struktur percabangan yang mencerminkan basis bersama mereka. Riwayat Git akan menampilkan:
- Sebuah batang utama yang berisi semua lapisan bersama
- Cabang-cabang terpisah yang hanya bercabang ketika image benar-benar berbeda
- Visualisasi yang jelas tentang di mana image memiliki leluhur yang sama vs. di mana mereka menjadi unik
- Penanganan duplikat cerdas: jika image yang sama persis diproses dua kali, algoritma akan mendeteksi ini sebelum komit metadata akhir dan melewati pembuatan cabang duplikat

Pendekatan ini sangat berharga untuk:
- **Analisis Keluarga Image**: Memahami bagaimana varian berbeda dari sebuah image (versi berbeda, arsitektur, atau konfigurasi) saling berhubungan
- **Dampak Image Dasar**: Melihat secara pasti bagaimana perubahan pada image dasar mempengaruhi banyak image turunan
- **Peluang Optimasi**: Mengidentifikasi komponen bersama yang bisa lebih dimanfaatkan di antara varian image

![Struktur repositori multi-image yang menunjukkan basis bersama dan percabangan](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Kasus Penggunaan Tambahan

- **Audit Keamanan**: Mengidentifikasi dengan tepat kapan paket atau konfigurasi rentan diperkenalkan dan menelusurinya hingga instruksi build tertentu.
- **Optimasi Image**: Menganalisis struktur layer untuk menemukan operasi redundan atau file besar yang bisa dikonsolidasikan, membantu mengurangi ukuran image.
- **Manajemen Dependensi**: Memantau kapan dependensi ditambahkan, diperbarui, atau dihapus sepanjang riwayat image.
- **Perbaikan Proses Build**: Memeriksa komposisi layer untuk mengoptimalkan instruksi Dockerfile demi caching lebih baik dan ukuran image yang lebih kecil.
- **Perbandingan Lintas-Image**: Konversi beberapa image terkait ke repositori Git dan gunakan alat perbandingan Git untuk menganalisis perbedaan dan kesamaan mereka.

## Instalasi

### Pengelola Paket

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Unduh dan instal paket .deb dari [rilis terbaru](https://github.com/virviil/oci2git/releases/latest):

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Binary yang Sudah Dibangun

Unduh binary yang sesuai untuk platform Anda dari [rilis terbaru](https://github.com/virviil/oci2git/releases/latest):

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Dari Crates.io

```bash
cargo install oci2git
```

### Dari Sumber

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Penggunaan

```bash
oci2git [OPTIONS] <IMAGE>
```

Argumen:
  `<IMAGE>`  Nama image yang akan dikonversi (misal, 'ubuntu:latest') atau path ke tarball saat menggunakan engine tar

Opsi:
  `-o, --output <o>`  Direktori output untuk repositori Git [default: ./container_repo]
  `-e, --engine <ENGINE>`  Engine container yang digunakan (docker, nerdctl, tar) [default: docker]
  `-h, --help`            Cetak informasi bantuan
  `-V, --version`         Cetak informasi versi

Variabel Lingkungan:
  `TMPDIR`  Atur variabel lingkungan ini untuk mengubah lokasi default yang digunakan untuk pemrosesan data sementara. Ini bergantung pada platform (misal, `TMPDIR` di Unix/macOS, `TEMP` atau `TMP` di Windows).

## Contoh

Menggunakan engine Docker (default):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```
Menggunakan tarball citra yang sudah diunduh:

```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Mesin tar mengharapkan tarball format OCI yang valid, yang biasanya dibuat dengan `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Ini akan membuat repositori Git di `./ubuntu-repo` yang berisi:
- `Image.md` - Metadata lengkap tentang image dalam format Markdown
- `rootfs/` - Konten filesystem dari container

Riwayat Git mencerminkan riwayat layer container:
- Commit pertama hanya berisi file `Image.md` dengan metadata lengkap
- Setiap commit berikutnya mewakili satu layer dari image asli
- Commit mencantumkan perintah Dockerfile sebagai pesan commit

## Struktur Repositori

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## Persyaratan

- Rust edisi 2021
- Docker CLI (untuk dukungan Docker engine)
- Git

## Lisensi

MIT

[dokumentasi]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---