
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

Aplikasi Rust yang mengonversi image kontainer (Docker, dll.) ke repository Git, dan menghasilkan filesystem bill of materials (fsbom) dalam format YAML. Setiap layer kontainer direpresentasikan sebagai commit Git, menjaga riwayat dan struktur image asli.

![Demo OCI2Git mengonversi image nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Fitur

- Menganalisis image Docker dan mengekstrak informasi layer
- Membuat repository Git di mana setiap layer image direpresentasikan sebagai commit
- Menghasilkan filesystem bill of materials (fsbom) dalam YAML dengan daftar file per layer
- Dukungan untuk layer kosong (ENV, WORKDIR, dll.) sebagai commit kosong
- Ekstraksi metadata lengkap ke format Markdown
- Arsitektur yang dapat diperluas untuk mendukung berbagai engine kontainer

## Kasus Penggunaan

### Perbandingan Layer
Saat melakukan troubleshooting masalah kontainer, Anda dapat menggunakan kapabilitas diffing dari Git untuk mengidentifikasi perubahan antara dua layer. Dengan menjalankan `git diff` antar commit, engineer dapat melihat file mana yang ditambahkan, diubah, atau dihapus, sehingga lebih mudah memahami dampak setiap instruksi Dockerfile dan menemukan perubahan bermasalah.
![Contoh perbandingan layer](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Pelacakan Asal
Dengan menggunakan `git blame`, developer dapat dengan cepat menentukan layer mana yang memasukkan file atau baris kode tertentu. Ini sangat berguna saat mendiagnosis masalah pada file konfigurasi atau dependensi. Alih-alih memeriksa setiap layer secara manual, Anda dapat langsung melacak asal suatu file ke layer sumber dan instruksi Dockerfile yang sesuai.

### Pelacakan Siklus Hidup File
OCI2Git memungkinkan Anda menelusuri perjalanan file tertentu sepanjang riwayat image kontainer. Anda dapat melihat kapan file pertama kali dibuat, bagaimana file itu diubah di tiap layer, dan jika/kapan akhirnya dihapus. Pandangan komprehensif ini membantu memahami evolusi file tanpa harus melacak perubahan secara manual di puluhan layer.

Untuk melacak riwayat file dalam image kontainer Anda — termasuk kapan pertama kali muncul, diubah, atau dihapus — Anda dapat menggunakan perintah Git berikut setelah konversi:

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

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — Gambar OCI → Repositori Git

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

Opsi:
  `-o, --output <OUTPUT>`  Direktori output untuk repositori Git [default: ./container_repo]
  `-e, --engine <ENGINE>`  Engine kontainer yang digunakan (docker, nerdctl, tar) [default: docker]
  `-v, --verbose`          Mode verbose (-v untuk info, -vv untuk debug, -vvv untuk trace)

### `fsbom` — Daftar material filesystem

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```

Opsi:
  `-o, --output <OUTPUT>`  Jalur output untuk file YAML BOM [default: ./fsbom.yml]
  `-e, --engine <ENGINE>`  Mesin kontainer yang digunakan (docker, nerdctl, tar) [default: docker]
  `-v, --verbose`          Mode verbose (-v untuk info, -vv untuk debug, -vvv untuk trace)

Variabel Lingkungan:
  `TMPDIR`  Atur variabel lingkungan ini untuk mengubah lokasi default yang digunakan untuk pemrosesan data sementara. Ini tergantung pada platform (misal, `TMPDIR` di Unix/macOS, `TEMP` atau `TMP` di Windows).

## Contoh

### Konversi

Menggunakan mesin Docker (default):
```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```
Menggunakan tarball citra yang sudah diunduh:

```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Mesin tar mengharapkan tarball format OCI yang valid, yang biasanya dibuat dengan `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Ini akan membuat repository Git di `./ubuntu-repo` yang berisi:
- `Image.md` - Metadata lengkap tentang image dalam format Markdown
- `rootfs/` - Isi filesystem dari container

Riwayat Git mencerminkan riwayat layer container:
- Commit pertama hanya berisi file `Image.md` dengan metadata lengkap
- Setiap commit berikutnya merepresentasikan satu layer dari image asli
- Commit mencantumkan perintah Dockerfile sebagai pesan commit

### Daftar Bahan Filesystem (fsbom)

Hasilkan YAML yang mencantumkan setiap file yang ditambahkan atau diubah per layer:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```
Menggunakan tarball:

```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```
Output YAML mencantumkan setiap lapisan dengan entri-entrinya yang ditandai berdasarkan tipe (`file`, `hardlink`, `symlink`, `directory`) dan status (`n:uid:gid` untuk baru, `m:uid:gid` untuk dimodifikasi). Berkas yang dihapus (OCI whiteouts) tidak disertakan.


```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

## Struktur Repository

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---