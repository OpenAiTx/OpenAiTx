<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Desktop jarak jauh Anda"><br>
  <a href="#raw-steps-to-build">Build</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Struktur</a> •
  <a href="#snapshot">Snapshot</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Kami membutuhkan bantuan Anda untuk menerjemahkan README ini, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">UI RustDesk</a> dan <a href="https://github.com/rustdesk/doc.rustdesk.com">Dokumentasi RustDesk</a> ke bahasa Anda</b>
</p>

> [!Caution]
> **Penafian Penyalahgunaan:** <br>
> Pengembang RustDesk tidak mendukung atau membenarkan penggunaan perangkat lunak ini secara tidak etis atau ilegal. Penyalahgunaan, seperti akses tanpa izin, pengendalian, atau pelanggaran privasi, sangat bertentangan dengan pedoman kami. Penulis tidak bertanggung jawab atas penyalahgunaan aplikasi ini.

Obrol dengan kami: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Perangkat lunak desktop jarak jauh lainnya, ditulis dalam Rust. Berfungsi langsung tanpa konfigurasi. Anda memiliki kendali penuh atas data Anda, tanpa kekhawatiran tentang keamanan. Anda dapat menggunakan server rendezvous/relay kami, [mengatur server sendiri](https://rustdesk.com/server), atau [membuat server rendezvous/relay sendiri](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk menyambut kontribusi dari siapa saja. Lihat [CONTRIBUTING.md](docs/CONTRIBUTING.md) untuk bantuan memulai.

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**UNDUH BINARY**](https://github.com/rustdesk/rustdesk/releases)

[**NIGHTLY BUILD**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Dependensi

Versi desktop menggunakan Flutter atau Sciter (tidak direkomendasikan) untuk GUI, tutorial ini hanya untuk Sciter, karena lebih mudah dan ramah untuk memulai. Lihat [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) kami untuk membangun versi Flutter.

Silakan unduh sendiri pustaka dinamis Sciter.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Langkah membangun mentah

- Siapkan lingkungan pengembangan Rust dan lingkungan build C++

- Instal [vcpkg](https://github.com/microsoft/vcpkg), dan atur variabel lingkungan `VCPKG_ROOT` dengan benar

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- jalankan `cargo run`

## [Build](https://rustdesk.com/docs/en/dev/build/)

## Cara membangun di Linux

### Ubuntu 18 (Debian 10)

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### openSUSE Tumbleweed

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### Fedora 28 (CentOS 8)

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### Arch (Manjaro)

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### Instal vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Perbaiki libvpx (Untuk Fedora)

```sh
cd vcpkg/buildtrees/libvpx/src
cd *
./configure
sed -i 's/CFLAGS+=-I/CFLAGS+=-fPIC -I/g' Makefile
sed -i 's/CXXFLAGS+=-I/CXXFLAGS+=-fPIC -I/g' Makefile
make
cp libvpx.a $HOME/vcpkg/installed/x64-linux/lib/
cd
```

### Build

```sh
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
source $HOME/.cargo/env
git clone --recurse-submodules https://github.com/rustdesk/rustdesk
cd rustdesk
mkdir -p target/debug
wget https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so
mv libsciter-gtk.so target/debug
VCPKG_ROOT=$HOME/vcpkg cargo run
```

## Cara membangun dengan Docker

Mulailah dengan mengkloning repositori dan membangun container Docker:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Kemudian, setiap kali Anda perlu membangun aplikasi, jalankan perintah berikut:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Perlu dicatat bahwa build pertama mungkin memakan waktu lebih lama sebelum dependensi di-cache, build berikutnya akan lebih cepat. Selain itu, jika Anda perlu menentukan argumen berbeda untuk perintah build, Anda dapat menambahkannya di akhir perintah pada posisi `<OPTIONAL-ARGS>`. Misalnya, jika ingin membangun versi rilis yang dioptimalkan, Anda dapat menambahkan `--release`. File executable yang dihasilkan akan tersedia di folder target pada sistem Anda, dan dapat dijalankan dengan:

```sh
target/debug/rustdesk
```

Atau, jika Anda menjalankan executable rilis:

```sh
target/release/rustdesk
```

Pastikan Anda menjalankan perintah ini dari root repositori RustDesk, jika tidak aplikasi mungkin tidak dapat menemukan resource yang dibutuhkan. Perlu juga diperhatikan bahwa subperintah cargo lain seperti `install` atau `run` saat ini belum didukung melalui metode ini karena akan menginstal atau menjalankan program di dalam container, bukan di host.

## Struktur File

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: codec video, konfigurasi, pembungkus tcp/udp, protobuf, fungsi fs untuk transfer file, dan beberapa fungsi utilitas lainnya
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: penangkap layar
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: kontrol keyboard/mouse khusus platform
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: implementasi salin dan tempel file untuk Windows, Linux, macOS.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: UI Sciter yang sudah usang (deprecated)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: layanan audio/clipboard/input/video, dan koneksi jaringan
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: memulai koneksi peer
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: Berkomunikasi dengan [rustdesk-server](https://github.com/rustdesk/rustdesk-server), menunggu koneksi langsung jarak jauh (TCP hole punching) atau koneksi relay
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: kode khusus platform
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: kode Flutter untuk desktop dan mobile
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript untuk klien web Flutter

## Tangkapan Layar

![Connection Manager](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Terhubung ke PC Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Transfer File](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP Tunneling](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---