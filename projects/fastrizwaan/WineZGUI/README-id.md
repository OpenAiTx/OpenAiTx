
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Wine GUI menggunakan Zenity - Mainkan dan Bagikan!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Apa itu WineZGUI

WineZGUI (diucapkan Wine-Zee-Goo-Eee) adalah antarmuka depan untuk Wine yang memudahkan bermain game Windows dengan Wine. Ini adalah kumpulan skrip Bash untuk Manajemen Wine Prefix dan Integrasi Desktop Linux demi pengalaman bermain game dengan Wine yang lebih mudah menggunakan Zenity. WineZGUI memungkinkan peluncuran cepat aplikasi atau game EXE Direct play (tanpa instalasi) dari File Manager seperti Nautilus dan memungkinkan pembuatan wine prefix terpisah untuk setiap binary EXE Windows.

## Kenapa WineZGUI?

1. Menjalankan game Windows atau file exe langsung dari file manager
2. Membuat pintasan aplikasi untuk akses yang lebih mudah.
3. Fokus pada bermain game, bukan pengaturan prefix.
4. Cadangkan dan Pulihkan prefix untuk digunakan lagi nanti.
5. Buat Game Bundles untuk berbagi (prefix+game)

## Cara kerja

1. Ketika binary Windows atau exe dibuka dengan WineZGUI, 
2. WineZGUI membuat prefix baru (menyalin template) dan pintasan desktop dengan nama file EXE.
3. Saat pengguna menjalankan skrip, exe akan dijalankan.
4. Jika itu adalah setup, WineZGUI akan mendeteksi exe yang terpasang dan membuat pintasan di kategori menu Games.

## Cara menjalankan Game atau Program di drive atau direktori lain

Buka Terminal Anda dan ketik ini:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### Instalasi WineZGUI

WineZGUI tersedia sebagai Flatpak di Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


WineZGUI dari Flathub hanya dapat mengakses direktori Desktop, Documents, Downloads, Music, Pictures, Videos. Untuk mengakses file dari lokasi lain atau partisi/drive lain yang ter-mount, salin file ke direktori yang disebutkan (Downloads, dll.) atau butuh izin baca yang dapat diberikan dengan aplikasi Flatseal atau lewat command line `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Saya sangat menyarankan menggunakan versi flatpak, karena wine berbasis distro (wine-staging) sering diperbarui dan game bisa saja rusak setiap beberapa hari. Menggunakan wine stable dari flathub lebih baik, atau gunakan wine stable 5.0 atau 7.0 dari paket distro.

#### Instalasi WineZGUI flatpak pada [distro Linux yang didukung](https://flatpak.org/setup/)

WineZGUI dikemas dalam flatpak-wine oleh saya sendiri. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) flatpak saya yang lain kini deprecated [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### PERSIAPAN pada sistem Linux, lihat [Persyaratan](https://github.com/fastrizwaan/WineZGUI#requirements)

Persiapan berlangsung instan karena hanya menyalin beberapa berkas ke direktori tertentu.

##### Versi 0.99.13

Unduh sumber [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) atau gunakan `git tag 0.99.13`

##### Menggunakan tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git tag 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### Versi pengembangan

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Copot WineZGUI

##### Copot Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Sistem  uninstall

Jalankan `uninstall` dari direktori sumber instalasi yang sama

```
sudo ./setup --uninstall
```

## Persyaratan

`wine` - program utama

`winetricks` - script addon wine yang wajib dimiliki

`perl‑image‑exiftool` - untuk mengekstrak nama aplikasi/game

`icoutils` - untuk mengekstrak ikon dari file exe

`gnome-terminal` - (opsional) untuk mengakses direktori prefix di shell

## Instalasi Persyaratan untuk OS Linux

### Distro yang Mendukung Flatpak

Dapatkan [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) yang sudah termasuk semua dependensi. Berguna untuk distro yang tidak mengemas wine.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Ketergantungan Waktu Jalan:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### Kontroler kompatibel XBOX

bangun dan pasang driver kernel untuk kontroler kompatibel xbox 360 dari https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---