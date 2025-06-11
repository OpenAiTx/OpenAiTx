# 🍡 scoop-proxy-cn

Repositori cermin proxy [Scoop](https://scoop.sh) yang cocok digunakan oleh pengguna di Tiongkok Daratan. Menyinkronkan pembaruan dari beberapa repositori `bucket` open source. Di antaranya:

- Cabang `sync` (default): Menyinkronkan aplikasi dari beberapa repositori, tetapi tidak melakukan modifikasi proxy ghproxy. **Cocok untuk skenario menggunakan versi modifikasi Scoop domestik dari gitee**
- Cabang `main`: Mengubah alamat aplikasi yang diunduh dari `github release` menjadi alamat unduhan proxy berbasis `https://ghfast.top`. **Karena alamat proxy sering berubah dan tidak stabil akibat sering gagal**

## Penggunaan

Tambahkan repositori aplikasi `spc`. Cocok digunakan bersama dengan [perpustakaan cermin Scoop domestik](https://gitee.com/scoop-installer/scoop):

```bash
# Tambahkan bucket, secara default mengambil cabang sync
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# install aplikasi
scoop install spc/<app_name>
```

Jika hanya ingin menggunakan versi resmi Scoop, lakukan langkah berikut untuk mengubah cabang langganan menjadi cabang `main`:

```bash
# Masuk ke direktori spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Jika sudah mengatur variabel lingkungan SCOOP, jalankan perintah berikut
cd "$env:SCOOP\buckets\spc"

# Beralih ke cabang main
git fetch --all
git checkout -b main origin/main
```

## Referensi Instalasi dan Konfigurasi Scoop

### Metode 1: Instalasi berbasis cermin kustom domestik (Direkomendasikan)

Karena kode sumber scoop dan aplikasi buckets sebagian besar dikelola melalui git di github, kendala akses github membuat instalasi, pembaruan, dan pengunduhan aplikasi menjadi sangat buruk pengalamannya.

Berikut adalah metode instalasi untuk [perpustakaan cermin Scoop domestik](https://gitee.com/scoop-installer/scoop).

```bash
# Ubah kebijakan eksekusi skrip, secara default setuju otomatis
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Metode 1: Jalankan perintah instalasi (default instalasi di direktori pengguna, jika ingin mengubah jalankan perintah "instalasi kustom" di bawah)
iwr -useb scoop.201704.xyz | iex


## Metode 2: Instalasi direktori kustom (ubah direktori ke lokasi yang sesuai)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Jika sudah menginstal sumber resmi, jalankan perintah berikut untuk beralih
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# Tambahkan bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Perbarui alamat repositori
scoop update
```

Scoop yang diinstal dengan metode ini telah dimodifikasi khusus, mendukung stasiun proxy kustom untuk percepatan, dan secara default menggunakan proxy `scoop.201704.xyz` untuk mengunduh aplikasi.

```bash
# Tambah proxy
scoop config URL_PROXY "https://scoop.201704.xyz"

# Hapus proxy
scoop config rm URL_PROXY
```

### Metode 2: Instalasi berbasis repositori resmi dengan proxy

Buka `PowerShell` dan jalankan perintah berikut untuk instalasi:

```bash
# instalasi
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# konfigurasi
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# tambah bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# Masuk ke direktori spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# Beralih ke cabang main
git fetch --all && git checkout -b main origin/main

# tampilkan bantuan
scoop help

# instal 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### Tentang `scoop-search`

Karena repositori `scoop-proxy-cn` menyinkronkan lebih dari `14.000` aplikasi, perintah `scoop search` resmi yang berbasis `PowerShell` sangat lambat dan hampir tidak dapat digunakan, disarankan untuk menginstal dan menggunakan alat `scoop-search` yang dikembangkan menggunakan bahasa `go`. Contoh:

```bash
scoop install scoop-search
# gunakan scoop-search
scoop-search act
```

## Masalah Umum

### Masalah gagal unduh akibat `aria2`

Saat `aria2` terpasang, scoop akan menggunakan `aria2` untuk mengunduh dengan akselerasi pembagian bagian. Namun beberapa alamat proxy tidak mendukung atau memblokir permintaan unduh bagian dari `aria2`, dalam hal ini jalankan perintah berikut untuk menonaktifkan `aria2`:

```bash
scoop config aria2-enabled false
```

### Masalah `Hash Check Failed`

Beberapa aplikasi mengonfigurasi alamat unduh versi terbaru dengan nilai hash tetap. Ketika ada versi baru, akan muncul masalah `Hash Check Failed`. Dalam kasus ini, tambahkan parameter `-s` untuk mengabaikan. Contoh:

```bash
scoop install scoop-search -s
```

### Cara menangani kegagalan update karena stasiun proxy tidak aktif

Saat menggunakan versi resmi Scoop dan berlangganan cabang `main`, proxy digunakan untuk mempercepat git repo dan alamat unduhan aplikasi. Jika stasiun proxy lama gagal, update tidak dapat dilanjutkan. Jalankan perintah berikut untuk menambahkan ulang:

```bash
# Perbarui repo scoop terlebih dahulu
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Metode 1: Perbarui repo spc bucket
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Jika lokasi buckets diubah, jalankan perintah berikut
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Metode 2: Hapus dan tambahkan ulang bucket spc
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Sinkronisasi Buckets Dari

- [ScoopInstaller/PHP](https://github.com/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://github.com/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://github.com/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://github.com/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://github.com/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://github.com/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://github.com/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://github.com/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://github.com/scoopcn/scoopcn)
- [rasa/scoops](https://github.com/rasa/scoops)
- [amorphobia/siku](https://github.com/amorphobia/siku)
- [ACooper81/scoop-apps](https://github.com/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://github.com/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://github.com/Calinou/scoop-games)
- [cderv/r-bucket](https://github.com/cderv/r-bucket)
- [chawyehsu/dorado](https://github.com/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://github.com/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://github.com/ivaquero/scoopet)
- [KNOXDEV/wsl](https://github.com/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://github.com/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://github.com/kidonng/sushi)
- [littleli/scoop-clojure](https://github.com/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://github.com/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://github.com/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://github.com/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://github.com/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://github.com/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://github.com/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://github.com/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://github.com/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://github.com/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://github.com/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://github.com/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://github.com/everyx/scoop-bucket)
- [borger/scoop-emulators](https://github.com/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://github.com/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://github.com/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://github.com/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://github.com/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://github.com/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://github.com/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://github.com/42wim/scoop-bucket)
- [akirco/aki-apps](https://github.com/akirco/aki-apps)
- [batkiz/backit](https://github.com/batkiz/backit)
- [iquiw/scoop-bucket](https://github.com/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://github.com/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://github.com/seumsc/scoop-seu)
- [cc713/ownscoop](https://github.com/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://github.com/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://github.com/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://github.com/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://github.com/starise/Scoop-Confetti)
- [dodorz/scoop](https://github.com/dodorz/scoop)
- [SayCV/scoop-cvp](https://github.com/SayCV/scoop-cvp)
- [Qv2ray/mochi](https://github.com/Qv2ray/mochi)
- [Homeland-Community/scoop](https://github.com/Homeland-Community/scoop)
- [jingyu9575/scoop-jingyu9575](https://github.com/jingyu9575/scoop-jingyu9575)
- [couleur-tweak-tips/utils](https://github.com/couleur-tweak-tips/utils)
- [wangzq/scoop-bucket](https://github.com/wangzq/scoop-bucket)
- [jonz94/scoop-sarasa-nerd-fonts](https://github.com/jonz94/scoop-sarasa-nerd-fonts)
- [NyaMisty/scoop_bucket_misty](https://github.com/NyaMisty/scoop_bucket_misty)
- [jfut/scoop-jfut](https://github.com/jfut/scoop-jfut)
- [mogeko/scoop-sysinternals](https://github.com/mogeko/scoop-sysinternals)
- [ChungZH/peach](https://github.com/ChungZH/peach)
- [DoveBoy/Apps](https://github.com/DoveBoy/Apps)
- [Velgus/Scoop-Portapps](https://github.com/Velgus/Scoop-Portapps)
- [starise/Scoop-Gaming](https://github.com/starise/Scoop-Gaming)
- [mo-san/scoop-bucket](https://github.com/mo-san/scoop-bucket)
- [brian6932/dank-scoop](https://github.com/brian6932/dank-scoop)
- [AkariiinMKII/Scoop4kariiin](https://github.com/AkariiinMKII/Scoop4kariiin)
- [littleli/Scoop-littleli](https://github.com/littleli/Scoop-littleli)
- [ChinLong/scoop-customize](https://github.com/ChinLong/scoop-customize)
- [Darkatse/Scoop-KanColle](https://github.com/Darkatse/Scoop-KanColle)
- [aliesbelik/poldi](https://github.com/aliesbelik/poldi)
- [MCOfficer/scoop-bucket](https://github.com/MCOfficer/scoop-bucket)
- [KnotUntied/scoop-fonts](https://github.com/KnotUntied/scoop-fonts)
- [beerpiss/scoop-bucket](https://github.com/beerpiss/scoop-bucket)
- [HUMORCE/nuke](https://github.com/HUMORCE/nuke)
- [AkinoKaede/maple](https://github.com/AkinoKaede/maple)
- [hulucc/bucket](https://github.com/hulucc/bucket)
- [Deide/deide-bucket](https://github.com/Deide/deide-bucket)
- [echoiron/echo-scoop](https://github.com/echoiron/echo-scoop)
- [tetradice/scoop-iyokan-jp](https://github.com/tetradice/scoop-iyokan-jp)

## Pernyataan

> [!WARNING]
> Informasi aplikasi yang terdapat di repositori ini hanya disinkronkan dari repositori pihak ketiga, belum dilakukan verifikasi satu per satu terkait ketersediaan dan keamanan, mohon lakukan verifikasi dan identifikasi sendiri saat memilih untuk menginstal. Jika terdapat pelanggaran hak cipta, silakan buat issues untuk penanganan.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---