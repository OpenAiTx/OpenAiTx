
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

**Ubah runner GitHub Actions Anda menjadi pusat tenaga [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ dengan memangkas habis bloatware yang sudah terpasang.**

Runner GitHub Actions hanya menyediakan ruang disk sedikit untuk Nix - hanya sekitar ~20GB.
*Nothing but Nix* **secara brutal membersihkan** perangkat lunak yang tidak diperlukan, memberi Anda **65GB hingga 130GB** untuk Nix store Anda! 💪

## Penggunaan 🔧

Tambahkan action ini **sebelum** menginstal Nix di workflow Anda:

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

- Hanya mendukung runner GitHub Actions resmi **Ubuntu**
- Harus dijalankan **sebelum** Nix diinstal

## Masalah: Memberi Ruang untuk Nix Berkembang 🌱

Runner standar GitHub Actions dipenuhi dengan *"bloatware"* yang tidak akan pernah Anda gunakan dalam workflow Nix:

- 🌍 Browser web. Banyak sekali. Harus punya semuanya!
- 🐳 Gambar Docker yang memakan gigabyte ruang disk berharga
- 💻 Runtime bahasa yang tidak perlu (.NET, Ruby, PHP, Java...)
- 📦 Package manager yang hanya mengumpulkan debu digital
- 📚 Dokumentasi yang tidak akan pernah dibaca siapa pun

Bloat ini hanya menyisakan ~20GB untuk Nix store Anda - nyaris tidak cukup untuk build Nix yang serius! 😞

## Solusi: Hanya Ada Nix ️❄️

**Nothing but Nix** mengambil pendekatan "scorched-earth" pada runner GitHub Actions dan dengan tanpa ampun merebut kembali ruang disk dengan serangan dua fase:

1. **Initial Slash:** Langsung membuat volume `/nix` besar (~65GB) dengan mengklaim ruang bebas dari `/mnt`
2. **Background Rampage:** Sementara workflow Anda berjalan, kami secara kejam menghapus perangkat lunak yang tidak perlu untuk memperluas volume `/nix` Anda hingga ~130GB
   - Browser web? Tidak ada ⛔
   - Gambar Docker? Hilang 🗑️
   - Runtime bahasa? Dihancurkan 💥
   - Package manager? Dimusnahkan 💣
   - Dokumentasi? Diuapkan ️👻

Pembersihan file system ini didukung oleh `rmz` (dari proyek [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - alternatif `rm` berperforma tinggi yang membuat proses reclaim ruang jadi super cepat! ⚡
   - Jauh lebih cepat daripada `rm` standar
   - Penghapusan secara paralel untuk efisiensi maksimal
   - **Mengembalikan ruang disk dalam hitungan detik, bukan menit!** ️⏱️

Hasil akhirnya? Runner GitHub Actions dengan ruang siap Nix **65GB sampai 130GB**! 😁

### Pertumbuhan Volume Dinamis

Berbeda dengan solusi lain, **Nothing but Nix** menumbuhkan volume `/nix` Anda secara dinamis:

1. **Pembuatan Volume Awal (1-10 detik):** (*tergantung Hatchet Protocol*)
   - Membuat perangkat loop dari ruang bebas di `/mnt`
   - Mengatur filesystem BTRFS dalam konfigurasi RAID0
   - Mount dengan kompresi dan penyetelan performa
   - Menyediakan `/nix` 65GB langsung, bahkan sebelum pembersihan dimulai

2. **Perluasan Latar Belakang (30-180 detik):** (*tergantung Hatchet Protocol*)
   - Menjalankan operasi pembersihan
   - Memantau ruang yang baru dibebaskan saat bloat dihapus
   - Menambahkan disk ekspansi secara dinamis ke volume `/nix`
   - Menyeimbangkan ulang filesystem untuk menggabungkan ruang baru

Volume `/nix` secara otomatis **bertambah selama eksekusi workflow** 🎩🪄

### Pilih Senjata Anda: Hatchet Protocol 🪓

Kendalikan tingkat pemusnahan 💥 dengan input `hatchet-protocol`:

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
Ketika `nix-permission-edict` disetel ke `true`, aksi akan menjalankan `sudo chown -R "$(id --user)":"$(id --group)" /nix` setelah me-mount `/nix`.

Sekarang pergilah dan bangun sesuatu yang menakjubkan dengan semua ruang Nix store yang luar biasa itu! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---