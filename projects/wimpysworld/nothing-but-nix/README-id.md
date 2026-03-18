
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Ubah runner GitHub Actions Anda menjadi mesin [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ yang tangguh dengan memangkas habis bloatware yang sudah terpasang.**

Runner GitHub Actions hadir dengan ruang disk yang sangat terbatas untuk Nix - hanya sekitar ~20GB.
*Nothing but Nix* **secara brutal membersihkan** perangkat lunak yang tidak perlu, memberi Anda **65GB hingga 130GB** untuk Nix store Anda! 💪

## Penggunaan 🔧

Tambahkan aksi ini **sebelum** menginstal Nix dalam alur kerja Anda:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Persyaratan ️✔️

- Hanya mendukung runner GitHub Actions **Ubuntu** resmi
- Harus dijalankan **sebelum** Nix diinstal
- **Runner macOS/Darwin**: Aksi ini akan dilewati secara anggun dengan peringatan jika dijalankan di macOS. Runner macOS sudah menyediakan ruang yang cukup untuk Nix dan tidak memerlukan aksi ini
- **Runner Windows**: Aksi ini akan dilewati secara anggun dengan peringatan jika dijalankan di Windows. Runner Windows memiliki tata letak sistem file dan kendala yang berbeda

## Masalah: Membuat Ruang untuk Nix Berkembang 🌱

Runner standar GitHub Actions dipenuhi dengan *"bloatware"* yang tidak akan pernah Anda gunakan dalam workflow Nix:

- 🌍 Browser web. Banyak sekali. Harus punya semuanya!
- 🐳 Gambar Docker yang menghabiskan gigabyte ruang disk yang berharga
- 💻 Runtime bahasa yang tidak diperlukan (.NET, Ruby, PHP, Java...)
- 📦 Package manager yang hanya mengumpulkan debu digital
- 📚 Dokumentasi yang tidak akan pernah dibaca

Bloat ini hanya menyisakan ~20GB untuk Nix store Anda - nyaris tidak cukup untuk build Nix yang serius! 😞

## Solusi: Hanya Nix ️❄️

**Hanya Nix** mengambil pendekatan "scorched-earth" pada runner GitHub Actions dan tanpa ampun merebut kembali ruang disk menggunakan serangan dua fase:

1. **Slash Awal:** Langsung membuat volume `/nix` besar (~65GB) dengan mengklaim ruang bebas dari `/mnt`
2. **Rampage Latar Belakang:** Sambil workflow Anda berjalan, kami secara brutal menghilangkan perangkat lunak yang tidak diperlukan untuk memperluas volume `/nix` hingga ~130GB
   - Browser web? Tidak ⛔
   - Gambar Docker? Hilang 🗑️
   - Runtime bahasa? Dihancurkan 💥
   - Package manager? Dimusnahkan 💣
   - Dokumentasi? Diuapkan ️👻

Pembersihan sistem file didukung oleh `rmz` (dari proyek [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - alternatif berkinerja tinggi untuk `rm` yang membuat perebutan ruang sangat cepat! ⚡
   - Melampaui `rm` standar satu tingkat
   - Memproses penghapusan secara paralel untuk efisiensi maksimum
   - **Merebut kembali ruang disk dalam hitungan detik, bukan menit!** ️⏱️

Hasil akhirnya? Runner GitHub Actions dengan **65GB hingga 130GB** ruang siap Nix! 😁

### Pertumbuhan Volume Dinamis
Tidak seperti solusi lain, **Nothing but Nix** memperbesar volume `/nix` Anda secara dinamis:

1. **Pembuatan Volume Awal (1-10 detik):** (*tergantung pada Protokol Hatchet*)
   - Membuat perangkat loop dari ruang kosong di `/mnt`
   - Menyiapkan sistem berkas BTRFS dengan konfigurasi RAID0
   - Melakukan mount dengan kompresi dan pengaturan performa
   - Menyediakan `/nix` 65GB secara langsung, bahkan sebelum proses purge dimulai

2. **Perluasan Latar Belakang (30-180 detik):** (*tergantung pada Protokol Hatchet*)
   - Menjalankan operasi purge
   - Memantau ruang baru yang dibebaskan ketika bloat dihilangkan
   - Menambahkan disk ekspansi secara dinamis ke volume `/nix`
   - Melakukan rebalance sistem berkas untuk menggabungkan ruang baru

Volume `/nix` secara otomatis **bertambah selama eksekusi workflow** 🎩🪄

### Pilih Senjatamu: Protokol Hatchet 🪓

Kendalikan tingkat penghancuran 💥 dengan input `hatchet-protocol`:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Perbandingan Protokol ⚖️

| Protokol | `/nix` | Deskripsi                                           | Hapus apt  | Hapus docker | Hapus snap | Sistem file yang dihapus     |
|----------|--------|-----------------------------------------------------|------------|--------------|------------|-----------------------------|
| Holster  | ~65GB  | Simpan kapak, gunakan ruang dari `/mnt`             | Tidak      | Tidak        | Tidak      | Tidak ada                   |
| Carve    | ~85GB  | Gabungkan dan ramu ruang bebas dari `/` dan `/mnt`  | Tidak      | Tidak        | Tidak      | Tidak ada                   |
| Cleave   | ~115GB | Potong paket besar secara kuat dan tegas            | Minimal    | Ya           | Ya         | `/opt` dan `/usr/local`     |
| Rampage  | ~130GB | Penghapusan brutal dan tanpa ampun terhadap bloat   | Agresif    | Ya           | Ya         | Muahahaha! 🔥🌎             |

Pilih dengan bijak:
- **Holster** saat Anda perlu semua alat runner tetap berfungsi penuh
- **Carve** untuk menjaga alat runner tetap fungsional tapi klaim semua ruang untuk Nix
- **Cleave** (*default*) demi keseimbangan ruang dan fungsi yang baik
- **Rampage** jika Anda butuh ruang Nix maksimal dan tak peduli apa yang rusak `#nix-is-life`

### Saksikan Kebengisan 🩸

Secara default, proses penghapusan berjalan diam-diam di latar belakang saat workflow Anda berlanjut. Namun jika Anda ingin menonton prosesnya secara real-time:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Kustomisasi Safe Havens 🛡️

Kendalikan berapa banyak ruang yang ingin disisakan dari pengambilan ruang Nix store dengan ukuran safe haven yang dapat dikustomisasi:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Tempat aman ini menentukan berapa banyak ruang (dalam MB) yang akan disisakan dengan murah hati selama proses reclaiming ruang:
- `root-safe-haven` default adalah 2048MB (2GB)
- `mnt-safe-haven` default adalah 1024MB (1GB)

Tingkatkan nilai-nilai ini jika Anda membutuhkan lebih banyak ruang lega di sistem file Anda, atau turunkan untuk tidak memberi ampun! 😈

### Berikan Kepemilikan Pengguna pada /nix (Nix Permission Edict) 🧑‍⚖️

Beberapa installer atau konfigurasi Nix mengharapkan direktori `/nix` dapat ditulis oleh pengguna saat ini. Secara default, `/nix` dimiliki oleh root. Jika Anda membutuhkan kepemilikan pengguna (misalnya, untuk beberapa skrip installer Nix tertentu yang tidak menggunakan `sudo` untuk semua operasi di dalam `/nix`), Anda dapat mengaktifkan `nix-permission-edict`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

Ketika `nix-permission-edict` disetel ke `true`, aksi akan menjalankan `sudo chown -R "$(id --user)":"$(id --group)" /nix` setelah melakukan mount pada `/nix`.

### Konfigurasikan Nix untuk menggunakan /nix/build

Aksi ini membuat `/nix/build` agar build derivasi Nix dapat menggunakan ruang yang sudah direklamasi. Tambahkan `build-dir` ke konfigurasi Nix Anda:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Atau dengan DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

Ini mengarahkan Nix untuk melakukan build pada volume BTRFS besar daripada direktori sementara default sistem.

## Pemecahan Masalah 🔍

### "Tidak ada ruang tersisa pada perangkat" selama build besar

Jika build Anda kehabisan ruang meskipun hanya menggunakan Nix, kemungkinan besar karena proses pembersihan latar belakang belum selesai sebelum build Anda menggunakan ruang yang tersedia. Ini biasanya mempengaruhi:

- Tes VM NixOS yang merakit image disk besar
- Build dengan banyak dependensi yang belum di-cache
- Toolchain Rust dan kompilasi besar lainnya

**Solusi:** Gunakan `witness-carnage: true` untuk memaksa pembersihan sinkron. Ini memastikan semua ruang dibersihkan *sebelum* build Anda dimulai:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

Ini menambah 30-180 detik pada penyiapan alur kerja Anda, tetapi menjamin ruang maksimum tersedia saat build Anda dimulai.

Sekarang pergi dan buat sesuatu yang menakjubkan dengan semua ruang Nix store yang luar biasa itu! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---