<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh adalah framework sumber terbuka yang digerakkan oleh komunitas untuk mengelola konfigurasi [zsh](https://www.zsh.org/) Anda.

Kedengarannya membosankan. Mari kita coba lagi.

**Oh My Zsh tidak akan membuat Anda menjadi developer 10x...tapi Anda mungkin akan merasa seperti itu.**

Setelah terpasang, shell terminal Anda akan menjadi bahan pembicaraan _atau uang Anda kembali!_ Dengan setiap ketikan di command prompt Anda, Anda akan memanfaatkan ratusan plugin yang kuat dan tema yang indah. Orang asing akan mendatangi Anda di kafe dan bertanya, _"luar biasa! apakah Anda semacam jenius?"_

Akhirnya, Anda akan mulai mendapatkan perhatian yang selalu Anda rasa pantas dapatkan. ...atau mungkin Anda akan menggunakan waktu yang Anda hemat untuk mulai lebih sering membersihkan gigi dengan benang. 😬

Untuk mempelajari lebih lanjut, kunjungi [ohmyz.sh](https://ohmyz.sh), ikuti [@ohmyzsh](https://x.com/ohmyzsh) di X (sebelumnya Twitter), dan bergabunglah dengan kami di [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Daftar Isi</summary>

- [Memulai](#getting-started)
  - [Kompatibilitas Sistem Operasi](#operating-system-compatibility)
  - [Prasyarat](#prerequisites)
  - [Instalasi Dasar](#basic-installation)
    - [Pemeriksaan Manual](#manual-inspection)
- [Menggunakan Oh My Zsh](#using-oh-my-zsh)
  - [Plugin](#plugins)
    - [Mengaktifkan Plugin](#enabling-plugins)
    - [Menggunakan Plugin](#using-plugins)
  - [Tema](#themes)
    - [Memilih Tema](#selecting-a-theme)
  - [FAQ](#faq)
- [Topik Lanjutan](#advanced-topics)
  - [Instalasi Lanjutan](#advanced-installation)
    - [Direktori Kustom](#custom-directory)
    - [Instalasi Tanpa Interaksi](#unattended-install)
    - [Instalasi dari Repository Fork](#installing-from-a-forked-repository)
    - [Instalasi Manual](#manual-installation)
  - [Masalah Instalasi](#installation-problems)
  - [Plugin dan Tema Kustom](#custom-plugins-and-themes)
  - [Mengaktifkan GNU ls di macOS dan freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Lewati Alias](#skip-aliases)
  - [Async git prompt](#async-git-prompt)
- [Mendapatkan Pembaruan](#getting-updates)
  - [Verbosity Pembaruan](#updates-verbosity)
  - [Pembaruan Manual](#manual-updates)
- [Mencopot Oh My Zsh](#uninstalling-oh-my-zsh)
- [Bagaimana Saya Berkontribusi pada Oh My Zsh?](#how-do-i-contribute-to-oh-my-zsh)
  - [Jangan Kirimkan Tema pada Kami](#do-not-send-us-themes)
- [Kontributor](#contributors)
- [Ikuti Kami](#follow-us)
- [Merchandise](#merchandise)
- [Lisensi](#license)
- [Tentang Planet Argon](#about-planet-argon)

</details>

## Memulai

### Kompatibilitas Sistem Operasi

| O/S            | Status |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Prasyarat

- [Zsh](https://www.zsh.org) harus diinstal (v4.3.9 atau lebih baru sudah cukup, namun kami menyarankan 5.0.8 ke atas). Jika belum terpasang (jalankan `zsh --version` untuk memastikan), lihat instruksi wiki berikut di sini: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` atau `wget` harus terpasang
- `git` harus terpasang (disarankan v2.4.11 atau lebih tinggi)

### Instalasi Dasar

Oh My Zsh dipasang dengan menjalankan salah satu perintah berikut di terminal Anda. Anda dapat menginstalnya melalui command-line dengan `curl`, `wget`, atau alat serupa lainnya.

| Metode    | Perintah                                                                                            |
| :-------- | :-------------------------------------------------------------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`     |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |

Sebagai alternatif, installer juga tersedia di luar GitHub. Menggunakan URL ini mungkin diperlukan jika Anda berada di negara seperti Tiongkok atau India (untuk ISP tertentu), yang memblokir `raw.githubusercontent.com`:

| Metode    | Perintah                                        |
| :-------- | :---------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Catatan bahwa setiap `.zshrc` sebelumnya akan diubah namanya menjadi `.zshrc.pre-oh-my-zsh`. Setelah instalasi, Anda dapat memindahkan konfigurasi yang ingin Anda pertahankan ke `.zshrc` baru._

#### Pemeriksaan Manual

Sebaiknya Anda memeriksa skrip instalasi dari proyek yang belum Anda kenal. Anda dapat melakukannya dengan mengunduh skrip instalasi terlebih dahulu, memeriksanya hingga semuanya terlihat normal, lalu menjalankannya:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Jika URL di atas mengalami timeout atau gagal, Anda mungkin harus mengganti URL menjadi `https://install.ohmyz.sh` untuk mendapatkan skripnya.

## Menggunakan Oh My Zsh

### Plugin

Oh My Zsh hadir dengan segudang plugin yang bisa Anda manfaatkan. Anda dapat melihat di direktori [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) dan/atau [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) untuk melihat apa saja yang tersedia saat ini.

#### Mengaktifkan Plugin

Setelah Anda menemukan plugin (atau beberapa) yang ingin digunakan dengan Oh My Zsh, Anda perlu mengaktifkannya di file `.zshrc`. File zshrc dapat Anda temukan di direktori `$HOME`. Buka dengan editor teks favorit Anda dan Anda akan menemukan bagian untuk mendaftarkan semua plugin yang ingin Anda muat.

```sh
vi ~/.zshrc
```

Sebagai contoh, ini mungkin terlihat seperti berikut:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Catatan bahwa plugin dipisahkan oleh spasi (spasi, tab, baris baru...). **Jangan** gunakan koma di antaranya karena akan menyebabkan error._

#### Menggunakan Plugin

Setiap plugin bawaan menyertakan **README** yang mendokumentasikannya. README ini akan menunjukkan alias (jika plugin menambahkannya) dan fitur tambahan yang disertakan dalam plugin tersebut.

### Tema

Kami akui. Di awal dunia Oh My Zsh, kami mungkin agak terlalu bersemangat soal tema. Kami kini memiliki lebih dari seratus lima puluh tema yang sudah dibundel. Sebagian besar memiliki [screenshot](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) di wiki (Kami sedang memperbarui ini!). Cek saja!

#### Memilih Tema

_Tema Robby adalah tema default. Itu bukan yang paling mewah. Itu bukan yang paling sederhana. Itu yang paling pas (untuk dia)._

Setelah Anda menemukan tema yang ingin digunakan, Anda perlu mengedit file `~/.zshrc`. Anda akan melihat variabel lingkungan (huruf besar semua) di sana yang terlihat seperti:

```sh
ZSH_THEME="robbyrussell"
```

Untuk menggunakan tema lain, cukup ubah nilainya agar sesuai dengan nama tema yang Anda inginkan. Contohnya:

```sh
ZSH_THEME="agnoster" # (ini salah satu yang mewah)
# lihat https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!CATATAN]
> Sering kali Anda melihat screenshot untuk sebuah tema zsh, lalu mencobanya dan ternyata tampilannya tidak sama di komputer Anda.
>
> Ini karena banyak tema memerlukan instalasi [Powerline Font](https://github.com/powerline/fonts) atau [Nerd Font](https://github.com/ryanoasis/nerd-fonts) agar bisa ditampilkan dengan benar. Tanpa itu, tema-tema ini akan menampilkan simbol prompt yang aneh. Lihat [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) untuk informasi lebih lanjut.
>
> Juga, harap diingat bahwa tema hanya mengontrol tampilan prompt Anda, yaitu teks yang Anda lihat sebelum atau setelah kursor, tempat Anda mengetik perintah. Tema tidak mengontrol warna jendela terminal Anda (dikenal sebagai _color scheme_) atau font terminal Anda. Ini adalah pengaturan yang dapat Anda ubah di emulator terminal Anda. Untuk informasi lebih lanjut, lihat [apa itu tema zsh](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Buka jendela terminal baru dan prompt Anda seharusnya akan terlihat seperti ini:

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Jika Anda tidak menemukan tema yang sesuai kebutuhan, silakan lihat wiki untuk [tema lainnya](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Jika Anda merasa ingin mencoba-coba, Anda bisa membiarkan komputer memilih tema secara acak setiap kali Anda membuka terminal baru.

```sh
ZSH_THEME="random" # (...semoga dapat pie... semoga pie..)
```

Dan jika Anda ingin memilih tema acak dari daftar tema favorit Anda:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Jika Anda hanya tahu tema mana yang tidak Anda suka, Anda bisa menambahkannya ke daftar yang diabaikan:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Jika Anda punya pertanyaan atau masalah lain, Anda mungkin menemukan solusinya di [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Topik Lanjutan

Jika Anda tipe yang suka ngoprek, bagian-bagian berikut mungkin cocok untuk Anda.

### Instalasi Lanjutan

Beberapa pengguna mungkin ingin menginstal Oh My Zsh secara manual, atau mengubah path default atau pengaturan lain yang diterima installer (pengaturan ini juga didokumentasikan di bagian atas skrip instalasi).

#### Direktori Kustom

Lokasi default adalah `~/.oh-my-zsh` (tersembunyi di home directory Anda, dapat diakses dengan `cd ~/.oh-my-zsh`)

Jika Anda ingin mengubah direktori instalasi dengan variabel lingkungan `ZSH`, baik dengan menjalankan `export ZSH=/your/path` sebelum instalasi, atau dengan menyetelnya sebelum akhir pipeline instalasi seperti berikut:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Instalasi Tanpa Interaksi

Jika Anda menjalankan skrip instalasi Oh My Zsh sebagai bagian dari instalasi otomatis, Anda bisa menambahkan flag `--unattended` ke skrip `install.sh`. Ini akan membuat installer tidak mengubah shell default, dan juga tidak menjalankan `zsh` setelah instalasi selesai.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Jika Anda di Tiongkok, India, atau negara lain yang memblokir `raw.githubusercontent.com`, Anda mungkin harus mengganti URL menjadi `https://install.ohmyz.sh` untuk instalasinya.

#### Instalasi dari Repository Fork

Skrip instalasi juga menerima variabel-variabel ini untuk memungkinkan instalasi dari repository lain:

- `REPO` (default: `ohmyzsh/ohmyzsh`): formatnya adalah `owner/repository`. Jika Anda mengatur variabel ini, installer akan mencari repository di `https://github.com/{owner}/{repository}`.

- `REMOTE` (default: `https://github.com/${REPO}.git`): ini adalah URL lengkap git repository clone. Anda dapat menggunakan pengaturan ini jika ingin menginstal dari fork yang bukan di GitHub (GitLab, Bitbucket...) atau jika ingin clone dengan SSH, bukan HTTPS (`git@github.com:user/project.git`).

  _CATATAN: ini tidak kompatibel dengan pengaturan variabel `REPO`. Pengaturan ini akan lebih diutamakan._

- `BRANCH` (default: `master`): Anda dapat menggunakan pengaturan ini jika ingin mengubah branch default yang akan di-checkout saat cloning repository. Ini mungkin berguna untuk menguji Pull Request, atau jika Anda ingin menggunakan branch selain `master`.

Contoh:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Instalasi Manual

##### 1. Clone Repository <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Opsional_, Backup File `~/.zshrc` Lama Anda <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Buat File Konfigurasi Zsh Baru <!-- omit in toc -->

Anda dapat membuat file konfigurasi zsh baru dengan menyalin template yang telah kami sediakan.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Ubah Shell Default Anda <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Anda harus logout dari sesi user Anda dan login kembali untuk melihat perubahan ini.

##### 5. Inisialisasi Konfigurasi Zsh Baru Anda <!-- omit in toc -->

Begitu Anda membuka jendela terminal baru, seharusnya zsh akan berjalan dengan konfigurasi Oh My Zsh.

### Masalah Instalasi

Jika Anda mengalami masalah saat instalasi, berikut beberapa solusi umum.

- Anda _mungkin_ perlu mengubah `PATH` di `~/.zshrc` jika Anda tidak dapat menemukan beberapa perintah setelah beralih ke `oh-my-zsh`.
- Jika Anda menginstal secara manual atau mengubah lokasi instalasi, periksa variabel lingkungan `ZSH` di `~/.zshrc`.

### Plugin dan Tema Kustom

Jika Anda ingin menimpa perilaku default, cukup tambahkan file baru (berakhiran `.zsh`) di direktori `custom/`.

Jika Anda memiliki banyak fungsi yang cocok digabungkan, Anda dapat meletakkannya sebagai file `XYZ.plugin.zsh` di direktori `custom/plugins/` lalu aktifkan plugin ini.

Jika Anda ingin menimpa fungsionalitas plugin yang didistribusikan dengan Oh My Zsh, buat plugin dengan nama yang sama di direktori `custom/plugins/` dan plugin ini akan dimuat menggantikan yang ada di `plugins/`.

### Mengaktifkan GNU ls di macOS dan freeBSD

<a name="enable-gnu-ls"></a>

Perilaku default di Oh My Zsh adalah menggunakan BSD `ls` di sistem macOS dan FreeBSD. Jika GNU `ls` terpasang (sebagai perintah `gls`), Anda dapat memilih untuk menggunakannya. Caranya, gunakan konfigurasi berbasis zstyle sebelum men-source `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Catatan: ini tidak kompatibel dengan `DISABLE_LS_COLORS=true`_

### Lewati Alias

<a name="remove-directories-aliases"></a>

Jika Anda ingin melewati alias default Oh My Zsh (yang didefinisikan di file `lib/*`) atau alias plugin, Anda dapat menggunakan pengaturan di bawah ini di file `~/.zshrc`, **sebelum Oh My Zsh dimuat**. Catatan bahwa ada banyak cara berbeda untuk melewati alias, tergantung kebutuhan Anda.

```sh
# Lewati semua alias, di file lib dan plugin yang diaktifkan
zstyle ':omz:*' aliases no

# Lewati semua alias di file lib
zstyle ':omz:lib:*' aliases no
# Lewati hanya alias yang didefinisikan di file lib directories.zsh
zstyle ':omz:lib:directories' aliases no

# Lewati semua alias plugin
zstyle ':omz:plugins:*' aliases no
# Lewati hanya alias dari plugin git
zstyle ':omz:plugins:git' aliases no
```

Anda dapat menggabungkan ini dengan cara lain, dengan memperhatikan bahwa scope yang lebih spesifik akan diutamakan:

```sh
# Lewati semua alias plugin, kecuali plugin git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Versi sebelumnya dari fitur ini menggunakan pengaturan berikut, yang sekarang telah dihapus:

```sh
zstyle ':omz:directories' aliases no
```

Sebagai gantinya, Anda bisa menggunakan berikut ini:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Pemberitahuan <!-- omit in toc -->

> Fitur ini saat ini dalam tahap pengujian dan dapat berubah di masa depan. Juga, belum kompatibel dengan plugin manager seperti zpm atau zinit, yang tidak men-source skrip init (`oh-my-zsh.sh`) tempat fitur ini diimplementasikan.

> Juga belum mendeteksi "alias" yang didefinisikan sebagai fungsi. Contohnya adalah fungsi `gccd`, `ggf`, atau `ggl` dari plugin git.

### Async git prompt

Fungsi prompt async adalah fitur eksperimental (termasuk mulai 3 April 2024) yang memungkinkan Oh My Zsh menampilkan informasi prompt secara asinkron. Ini dapat meningkatkan performa rendering prompt, namun mungkin tidak berjalan baik di beberapa setup. Kami berharap ini tidak menjadi masalah, tapi jika Anda mengalami masalah dengan fitur ini, Anda bisa mematikannya dengan menambahkan baris berikut di file .zshrc, sebelum Oh My Zsh dimuat:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Jika masalah Anda adalah prompt git tiba-tiba tidak muncul, Anda bisa coba memaksanya dengan pengaturan berikut sebelum `oh-my-zsh.sh` dimuat. Jika masih tidak berfungsi, silakan buka issue dengan kasus Anda.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Mendapatkan Pembaruan

Secara default, Anda akan diminta untuk memeriksa pembaruan setiap 2 minggu. Anda dapat memilih mode pembaruan lain dengan menambahkan baris di file `~/.zshrc`, **sebelum Oh My Zsh dimuat**:

1. Pembaruan otomatis tanpa konfirmasi:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Hanya menampilkan pengingat setiap beberapa hari, jika ada pembaruan tersedia:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Menonaktifkan pembaruan otomatis sepenuhnya:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

CATATAN: Anda dapat mengatur seberapa sering Oh My Zsh memeriksa pembaruan dengan pengaturan berikut:

```sh
# Ini akan memeriksa pembaruan setiap 7 hari
zstyle ':omz:update' frequency 7
# Ini akan memeriksa pembaruan setiap kali Anda membuka terminal (tidak disarankan)
zstyle ':omz:update' frequency 0
```

### Verbosity Pembaruan

Anda juga dapat membatasi verbosity pembaruan dengan pengaturan berikut:

```sh
zstyle ':omz:update' verbose default # prompt pembaruan default

zstyle ':omz:update' verbose minimal # hanya beberapa baris

zstyle ':omz:update' verbose silent # hanya error saja
```

### Pembaruan Manual

Jika Anda ingin memperbarui kapan saja (misal ada plugin baru dirilis dan Anda tidak ingin menunggu seminggu?) Anda hanya perlu menjalankan:

```sh
omz update
```

> [!CATATAN]
> Jika Anda ingin mengotomatisasi proses ini dalam skrip, Anda dapat langsung memanggil skrip `upgrade`, seperti ini:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Lihat opsi lain di [FAQ: Bagaimana cara memperbarui Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **PENGGUNAAN `omz update --unattended` TELAH DIHAPUS, KARENA ADA EFEK SAMPING**.

Ajaib! 🎉

## Mencopot Oh My Zsh

Oh My Zsh tidak untuk semua orang. Kami akan merindukan Anda, tapi kami ingin perpisahan ini mudah.

Jika Anda ingin mencopot `oh-my-zsh`, cukup jalankan `uninstall_oh_my_zsh` dari command-line. Ini akan menghapus dirinya sendiri dan mengembalikan konfigurasi `bash` atau `zsh` Anda sebelumnya.

## Bagaimana Saya Berkontribusi pada Oh My Zsh?

Sebelum Anda berpartisipasi dalam komunitas kami yang menyenangkan, silakan baca [kode etik](CODE_OF_CONDUCT.md).

Saya jauh dari seorang ahli [Zsh](https://www.zsh.org/) dan curiga masih banyak cara untuk meningkatkan – jika Anda punya ide bagaimana membuat konfigurasi lebih mudah dirawat (dan lebih cepat), jangan ragu untuk fork dan kirim pull request!

Kami juga butuh orang untuk menguji pull request. Jadi lihat [open issues](https://github.com/ohmyzsh/ohmyzsh/issues) dan bantu jika bisa.

Lihat [Contributing](CONTRIBUTING.md) untuk detail lebih lanjut.

### Jangan Kirimkan Tema pada Kami

Kami sudah (lebih dari) cukup tema untuk saat ini. Silakan tambahkan tema Anda ke halaman wiki [external themes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

## Kontributor

Oh My Zsh memiliki komunitas pengguna yang aktif dan kontributor yang luar biasa. Tanpa waktu dan bantuan dari para kontributor, proyek ini tidak akan sehebat sekarang.

Terima kasih banyak!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Ikuti Kami

Kami ada di media sosial:

- [@ohmyzsh](https://x.com/ohmyzsh) di X (sebelumnya Twitter). Jangan lupa follow.
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) hubungi kami.
- [Instagram](https://www.instagram.com/_ohmyzsh/) tag kami di postingan Anda yang menampilkan Oh My Zsh!
- [Discord](https://discord.gg/ohmyzsh) untuk ngobrol dengan kami!

## Merchandise

Kami menyediakan [stiker, kaos, dan mug kopi](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) untuk Anda tunjukkan kecintaan pada Oh My Zsh. Lagi-lagi, Anda akan jadi bahan pembicaraan!

## Lisensi

Oh My Zsh dirilis di bawah [lisensi MIT](LICENSE.txt).

## Tentang Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh dimulai oleh tim di [Planet Argon](https://www.planetargon.com/?utm_source=github), sebuah [agensi pengembangan Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github). Lihat [proyek open source kami lainnya](https://www.planetargon.com/open-source?utm_source=github).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---