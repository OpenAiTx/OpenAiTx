
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Aplikasi Rust yang mengonversi image kontainer (Docker, dll.) menjadi repository Git. Setiap layer kontainer diwakili sebagai commit Git, menjaga riwayat dan struktur dari image asli.

![Demo OCI2Git mengonversi image nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Fitur

- Menganalisis image Docker dan mengekstrak informasi layer
- Membuat repositori Git di mana setiap layer image direpresentasikan sebagai sebuah commit
- Mendukung layer kosong (ENV, WORKDIR, dll.) sebagai commit kosong
- Ekstraksi metadata lengkap ke format Markdown
- Arsitektur yang dapat diperluas untuk mendukung berbagai engine container

## Kasus Penggunaan

### Perbandingan Layer
Saat melakukan troubleshooting pada masalah container, Anda dapat menggunakan kemampuan diffing Git yang kuat untuk mengidentifikasi secara tepat apa yang berubah di antara dua layer. Dengan menjalankan `git diff` antar commit, engineer dapat melihat dengan jelas file mana yang ditambahkan, dimodifikasi, atau dihapus, sehingga memudahkan untuk memahami dampak dari setiap instruksi Dockerfile dan menemukan perubahan yang bermasalah.
![Contoh untuk perbandingan layer](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Pelacakan Asal
Dengan menggunakan `git blame`, developer dapat dengan cepat menentukan layer mana yang memperkenalkan sebuah file atau baris kode tertentu. Ini sangat berguna saat mendiagnosis masalah pada file konfigurasi atau dependensi. Alih-alih memeriksa setiap layer secara manual, Anda dapat langsung melacak asal-usul setiap file kembali ke layer sumbernya dan instruksi Dockerfile terkait.

### Pelacakan Siklus Hidup File
OCI2Git memungkinkan Anda mengikuti perjalanan sebuah file tertentu sepanjang sejarah image container. Anda dapat mengamati kapan file tersebut pertama kali dibuat, bagaimana ia dimodifikasi di setiap layer, dan jika/kapan akhirnya dihapus. Pandangan komprehensif ini membantu memahami evolusi file tanpa harus melacak perubahan secara manual di puluhan layer.

Untuk melacak riwayat sebuah file pada image container Anda — termasuk kapan pertama kali muncul, diubah, atau dihapus — Anda dapat menggunakan perintah Git berikut setelah konversi:

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
OCI2Git secara otomatis mendeteksi layer bersama antar image dan membuat struktur percabangan yang mencerminkan basis bersama mereka. Riwayat Git akan menunjukkan:
- Batang utama yang berisi semua layer bersama
- Cabang terpisah yang menyimpang hanya ketika image benar-benar berbeda
- Visualisasi yang jelas tentang di mana image memiliki nenek moyang bersama vs. di mana mereka menjadi unik
- Penanganan duplikat yang cerdas: jika image yang sama persis diproses dua kali, algoritma mendeteksinya sebelum komit metadata akhir dan melewati pembuatan cabang duplikat

Pendekatan ini sangat berharga untuk:
- **Analisis Keluarga Image**: Memahami bagaimana berbagai varian dari suatu image (versi berbeda, arsitektur, atau konfigurasi) saling berhubungan
- **Dampak Image Dasar**: Melihat secara tepat bagaimana perubahan pada image dasar memengaruhi banyak image turunan
- **Peluang Optimasi**: Mengidentifikasi komponen bersama yang dapat dimanfaatkan lebih baik di seluruh varian image

![Struktur repositori multi-image yang menunjukkan basis bersama dan cabang yang menyimpang](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Kasus Penggunaan Tambahan

- **Audit Keamanan**: Identifikasi secara tepat kapan paket atau konfigurasi yang rentan diperkenalkan dan telusuri kembali ke instruksi build tertentu.
- **Optimasi Image**: Analisis struktur layer untuk menemukan operasi yang redundan atau file besar yang dapat dikonsolidasikan, membantu mengurangi ukuran image.
- **Manajemen Dependensi**: Pantau kapan dependensi ditambahkan, ditingkatkan, atau dihapus sepanjang riwayat image.
- **Peningkatan Proses Build**: Periksa komposisi layer untuk mengoptimalkan instruksi Dockerfile demi caching yang lebih baik dan ukuran image yang lebih kecil.
- **Perbandingan Antar Image**: Konversi beberapa image terkait ke repositori Git dan gunakan alat perbandingan Git untuk menganalisis perbedaan dan kesamaan mereka.

## Instalasi

### Dari Sumber


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Dari Crates.io

```bash
cargo install oci2git
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

- Edisi Rust 2021
- Docker CLI (untuk dukungan mesin Docker)
- Git

## Lisensi

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---