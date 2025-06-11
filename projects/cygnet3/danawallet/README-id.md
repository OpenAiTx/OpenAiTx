# Dana wallet

Dana adalah aplikasi flutter yang digunakan untuk menerima donasi bitcoin. Aplikasi ini menggunakan silent payments, sebuah protokol pembayaran statis baru, untuk menerima donasi sambil menjaga privasi on-chain.

## Coba Dana wallet

**Dana wallet saat ini masih dalam fase eksperimental. Kami menyarankan untuk menggunakan testnet/signet. Jika Anda benar-benar ingin mencoba wallet ini di mainnet, gunakan hanya dana yang siap Anda kehilangan. Kami tidak bertanggung jawab atas dana yang hilang.**

Kami sedang mempertimbangkan untuk merilis Dana wallet di toko aplikasi populer setelah aplikasinya lebih stabil.

Sementara itu, ada dua cara untuk mencoba Dana wallet:

- Unduh APK Dana wallet terbaru dari [halaman rilis](https://github.com/cygnet3/danawallet/releases)
- Unduh Dana wallet menggunakan [repositori F-Droid self-hosted kami](https://fdroid.silentpayments.dev/fdroid/repo)

### Unduh menggunakan F-Droid

Kami menyarankan opsi F-Droid, karena mendukung pembaruan otomatis, dan hanya perlu pengaturan sekali saja.

- Buka F-Droid di ponsel android Anda
- Masuk ke 'Settings'
- Di bagian 'My Apps', klik 'Repositories'
- Tambahkan repositori baru dengan mengklik ikon '+'
- Pindai kode QR yang ada di halaman ini: https://fdroid.silentpayments.dev/fdroid/repo

Anda sekarang telah menambahkan repositori self-hosted kami. Untuk mengunduh aplikasinya, cari 'Dana Wallet' di bagian toko aplikasi F-Droid (Anda mungkin perlu menyegarkan daftar aplikasi terlebih dahulu dengan menggeser layar toko F-Droid ke bawah).

## Membangun Dana wallet dari sumber

Berikut adalah beberapa instruksi untuk membangun Dana wallet dari sumber. Ini hanya disarankan jika Anda ingin membantu pengembangan Dana wallet.

### Membangun untuk linux (desktop)

Membangun untuk linux seharusnya tidak memerlukan usaha ekstra, cukup jalankan

```
flutter run
```

Ini mungkin juga berhasil di platform lain (macOS, Windows), tetapi kami belum mengujinya.

### Membangun untuk android

Membangun untuk perangkat android memerlukan beberapa persiapan, untuk menghasilkan binary untuk arsitektur ini.

Pertama, Anda perlu `cargo-ndk`. Anda juga mungkin perlu menambahkan toolchain yang diinginkan:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Setelah terpasang, masuk ke direktori rust dan jalankan `just build-android`.

```
cd rust
just build-android
```

Jika Anda belum menginstal `just`, Anda juga dapat menyalin perintah yang ada di `justfile`.
Ini akan menghasilkan binary.

Selanjutnya, hubungkan ponsel Anda dan aktifkan mode debugging.
Periksa apakah ponsel terhubung dengan menjalankan

```
flutter devices
```

Terakhir, untuk membangun dan memasang aplikasi di perangkat android Anda:

```
flutter run
```

## Donasi ke Dana

Anda dapat berdonasi ke Dana wallet menggunakan alamat kami:

> ₿donate@danawallet.app

atau Anda bisa menggunakan alamat silent payment berikut:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---