
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Status Terjemahan](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Status Build](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Status Snap](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donasi](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Sebuah Utilitas Jaringan

Penulis: Siddhartha Das

Aplikasi sederhana yang dibuat untuk elementary OS untuk memberikan informasi penting terkait jaringan. Informasi yang disajikan terbagi menjadi tab-tab berikut.<br>
1. Info Saya: Menyediakan informasi dasar dan detail untuk kartu jaringan perangkat<br>
2. Penggunaan: Menyediakan data penggunaan jaringan dalam dua tampilan - penggunaan historis dan penggunaan saat ini<br>
3. Kecepatan: Periksa kecepatan Upload dan Download serta dapatkan waktu rute ke sebuah host<br>
4. Port: Memberikan informasi tentang port aktif dan aplikasi yang menggunakannya pada perangkat lokal<br>
5. Perangkat: Memantau, memberi peringatan, dan menyediakan informasi tentang perangkat lain yang terhubung ke jaringan<br>

Periksa situs web Nutty untuk detail fitur, pintasan, panduan instalasi untuk Ubuntu dan distro lain yang didukung, dll. : <br>
https://babluboy.github.io/nutty/

## Membangun, Menguji, dan Instalasi dari Sumber

Anda akan membutuhkan dependensi berikut untuk membangun:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Dan dependensi berikut untuk menjalankan:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Terkadang vnstat tidak dijalankan saat instalasi, gunakan perintah sistem init yang sesuai untuk memulai daemon vnstat yaitu `sudo systemctl enable vnstat`

Jalankan `meson build` untuk mengonfigurasi lingkungan build dan jalankan `ninja test` untuk membangun

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

Untuk menginstal, gunakan `sudo ninja install`, lalu jalankan dengan `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```
Untuk mencopot pemasangan, masuk ke direktori build dan jalankan

```
sudo ninja uninstall
```

### Instalasi dari paket Deb

Untuk menginstal Nutty dari paket `.deb`, pastikan Anda telah menginstal semua dependensi eksekusi Nutty di atas (tidak perlu dependensi build). Kemudian jalankan perintah di bawah ini
```bash
sudo dpkg -i <deb-package-name>.deb
```

Dan untuk mencopot Nutty yang diinstal melalui paket `.deb`, jalankan
```bash
sudo apt autoremove com.github.babluboy.nutty
```

Jika Anda ingin langsung membuat paket `.deb` Nutty sendiri maka pasanglah dependensi build di atas lalu jalankan
```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---