# eBAF - Firewall Iklan Berbasis eBPF
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## "Kamu Tidak Akan Mengunduh Sebuah Iklan"
### Tapi Kamu Akan Memblokirnya!

Spotify telah membangun sebuah kerajaan dengan formula sederhana: memonetisasi perhatianmu, membayar rendah para artis, dan menjual kembali waktumu sendiri sebagai fitur premium.
Di dunia mereka, pengalaman mendengarkanmu bukan milikmu. Itu adalah pasar yang dikurasi dengan cermat — telingamu adalah produknya, kesabaranmu adalah mata uangnya.

Mereka suka menyebutnya tingkat "gratis".
Tapi mari kita jujur: itu tidak gratis jika kamu membayarnya dengan waktumu.

Sementara itu, para artis yang kamu cintai — orang-orang yang karyanya membuat platform tetap hidup — sering kali hanya mendapat sepersekian sen per pemutaran. Spotify mendapatkan keuntungan besar, para pengiklan mendapatkan eksposurnya, dan para kreator? Mereka hanya mendapatkan sisa-sisa.

Ini bukan hanya soal melewati beberapa iklan yang mengganggu.
Ini tentang menolak untuk berpartisipasi dalam sistem yang mengambil untung dari eksploitasi, distraksi, dan komodifikasi perhatianmu.

#### Apa ini?
Sebuah aksi kecil perlawanan digital yang elegan: pemblokir iklan open-source yang bersih untuk Spotify yang benar-benar menghentikan gangguan — secara harfiah.

Tanpa mod mencurigakan, tanpa klien bajakan, tanpa malware yang menyamar sebagai kebebasan. Hanya satu tujuan: biarkan musik mengalun tanpa disandera oleh iklan.

Spotify tidak gratis — Anda membayarnya dengan kesabaran Anda.

Mereka membombardir Anda dengan iklan yang sama, berulang-ulang, hingga Anda menyerah dan berlangganan. Bukan karena Anda mencintai Premium. Tapi karena Anda sudah lelah. Itu bukan freemium — itu perang psikologis dengan daftar putar.

Sementara itu, para artis? Tetap dibayar rendah.
Iklannya? Lebih keras. Lebih sering. Kadang secara harfiah lebih keras.
Anda? Hanya ingin menikmati suasana.

Mereka mengambil untung dari kesabaran Anda dan pembayaran yang kurang kepada para kreator, sambil berpura-pura bahwa itu satu-satunya cara yang berkelanjutan. Spoiler: itu tidak benar. Mereka punya pilihan — tapi mereka memilih margin keuntungan daripada manusia.

Spotify ingin Anda percaya bahwa ini adalah harga akses.
Kami percaya itu adalah kebohongan.

Kami bukan pembajak. Kami bukan kriminal. Kami hanya orang-orang yang berpikir bahwa menarik garis batas itu sah-sah saja.

Proyek ini bukan tentang melewati beberapa iklan. Ini tentang menolak sistem yang mengatakan keheningan Anda bisa dijual, pengalaman Anda bisa diganggu, dan nilai Anda baru dihitung saat Anda membuka dompet.

Memblokir iklan bukan pencurian.<br>
Mencuri waktu Anda adalah.<br>
Kami bukan di sini untuk membajak. Kami di sini untuk memilih keluar.<br>
<br>
**Anda Tidak Akan Mengunduh Iklan. Tapi Anda Akan Memblokirnya.**
## Bagaimana cara kerja eBAF?

eBAF (eBPF Ad Firewall) memanfaatkan kekuatan eBPF (Extended Berkeley Packet Filter) untuk memblokir iklan yang tidak diinginkan di tingkat kernel. Berikut adalah gambaran umum tingkat tingginya:

## Bagaimana cara kerja eBAF?

eBAF (eBPF Ad Firewall) memanfaatkan eBPF (Extended Berkeley Packet Filter) untuk memblokir iklan secara efisien di tingkat kernel. Berikut adalah gambaran sederhana:

1. **Penyaringan Paket**:
   - Memeriksa paket jaringan yang masuk dan memblokir paket yang cocok dengan daftar hitam alamat IP menggunakan XDP (eXpress Data Path).

2. **Pembaruan Dinamis**:
   - Menerjemahkan nama domain menjadi alamat IP dan memperbarui daftar hitam secara dinamis agar tetap efektif terhadap perubahan server iklan.

3. **Dasbor Web**:
   - Menyediakan statistik dan pemantauan secara langsung melalui antarmuka yang ramah pengguna.

4. **Performa Tinggi**:
   - Beroperasi langsung pada tingkat antarmuka jaringan, melewati stack jaringan kernel untuk pemrosesan lebih cepat dan penggunaan sumber daya minimal.

eBAF menggabungkan efisiensi, transparansi, dan kemudahan penggunaan untuk memberikan solusi pemblokiran iklan yang kuat.
## Instalasi Sederhana (Direkomendasikan)
Pastikan git dan curl sudah terpasang
```bash
git --version
curl --version
```
### Instalasi
#### Aktifkan integrasi Spotify (Direkomendasikan)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Nonaktifkan secara eksplisit
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Uninstall
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Dev Install
Jalankan perintah berikut untuk menginstal dependensi yang diperlukan:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### Memperbaiki Error asm/types.h saat menjalankan kode eBPF
Periksa tautan saat ini
`ls -l /usr/include/asm`
Temukan tautan yang benar
`find /usr/include -name "types.h" | grep asm`
Perbaiki symbolic link
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### Membangun Proyek

Untuk membangun eBPF Adblocker, ikuti langkah-langkah berikut:

1. Clone repositori:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Bangun proyek:
   ```bash
   make
   ```

3. (Opsional) Instal secara sistem-wide:
   ```bash
   sudo make install
   ```

4. Opsi instalasi lainnya (bantuan)
    ```bash
    make help
    ````
5. UnInstall
    ```bash
    make uninstall
    ````

## Penggunaan

### Menjalankan Adblocker
    Menggunakan spotify-stable.txt sebagai Daftar Hitam default.
    Penggunaan: ebaf [OPTIONS] [INTERFACE...]
    OPSI:
    -a, --all               Jalankan pada semua antarmuka aktif
    -d, --default           Jalankan hanya pada antarmuka default (yang memiliki akses internet)
    -i, --interface IFACE   Tentukan antarmuka yang akan digunakan
    -D, --dash              Mulai dasbor web (http://localhost:8080)
    -q, --quiet             Sembunyikan output (mode senyap)
    -h, --help              Tampilkan pesan bantuan ini


### Mengonfigurasi Daftar Hitam
Edit daftar untuk menambah atau menghapus domain. Setiap domain harus berada di baris terpisah. Komentar diawali dengan `#`.

## Ucapan Terima Kasih

Terima kasih khusus kepada ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

atas penyediaan daftar blokir spotify
## ⭐️ Dukung Proyek Ini

Jika Anda merasa eBAF bermanfaat, mohon pertimbangkan untuk memberikan bintang pada repositori di GitHub! Dukungan Anda membantu meningkatkan visibilitas dan mendorong pengembangan lebih lanjut.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---