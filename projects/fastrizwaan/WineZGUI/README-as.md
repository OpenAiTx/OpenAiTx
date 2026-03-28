
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">হिन्दী</a>
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

#### Wine GUI (Zenity ব্যৱহাৰ কৰি) - চলাও আৰু ভাগ-বতৰা কৰক!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathub-ত ডাউনলোড কৰক' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## WineZGUI কি

WineZGUI (Wine-Zee-Goo-Eee বুলি উচ্চাৰণ কৰা হয়) হৈছে wine ৰ এটা ফ্ৰণ্টএণ্ড যিয়ে wine ব্যৱহাৰ কৰি windows গেম সহজে খেলিবলৈ সহায় কৰে। এইটো Bash script ৰ এটা সংকলন যিয়ে Wine Prefix পৰিচালনা আৰু Linux Desktop Integration যোগান ধৰে, যাৰ জৰিয়তে Zenity ব্যৱহাৰ কৰি wine গেমিংৰ অভিজ্ঞতা সহজ হয়। ই File Manager (যেনে Nautilus) ৰ পৰা Direct play (স্থাপন নোহোৱা) EXE এপ্লিকেশ্যন বা গেম দ্রুতভাৱে চলাবলৈ আৰু প্ৰতিটো Windows' EXE binary ৰ বাবে পৃথক wine prefix সৃষ্টি কৰিবলৈ অনুমতি দিয়ে।

## WineZGUI কিয়?

1. ফাইল মেনেজাৰ ৰ পৰা windows গেম বা exe ফাইল চলায়
2. সহজে এক্সেছৰ বাবে এপ্লিকেশ্যন শর্টকাট সৃষ্টি কৰে।
3. Prefix স্থাপনত নহয়, কেৱল গেম খেলাত গুৰুত্ব দিয়ে।
4. Prefix সংৰক্ষণ আৰু পুনৰুদ্ধাৰ কৰাৰ সুবিধা দিয়ে।
5. Game Bundle (prefix+game) সৃষ্টি কৰি ভাগ-বতৰা কৰিব পাৰে

## কিদৰে কাম কৰে

1. যেতিয়া এটা windows binary বা exe WineZGUI ৰ সৈতে খোলা হয়,
2. ই এটা নতুন prefix (template কপি কৰে) আৰু EXE filename সহ এটা ডেস্কটপ shortcut সৃষ্টি কৰে।
3. ব্যৱহাৰকাৰীয়ে script খুলি দিলে exe চলাই দিয়ে।
4. যদি ই এটা setup হয়, তেন্তে ই স্থাপন কৰা exe চিনাক্ত কৰে আৰু Games মেনু শিতানত shortcut সৃষ্টি কৰে।

## আন এটা ড্ৰাইভ বা ডিৰেক্টৰিত কিদৰে গেম বা প্ৰগ্ৰাম চলাব

আপোনাৰ টাৰ্মিনেল খোলক আৰু এইটো টাইপ কৰক:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### WineZGUI ইনষ্টল কৰক

WineZGUI Flathub ত Flatpak হিচাপে উপলব্ধ:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI কেৱল Desktop, Documents, Downloads, Music, Pictures, Videos ডিৰেক্টৰিতহে এক্সেছ কৰিব পাৰে। আন ঠাই বা আন মাউন্ট কৰা পাৰ্টিশ্বন বা ড্ৰাইভৰ পৰা ফাইল এক্সেছ কৰিবলৈ, আগতে উল্লেখ কৰা ডিৰেক্টৰিত (Downloads আদিত) কপি কৰক, অথবা Flatseal এপ বা এই কমাণ্ড লাইনেৰে read অনুমতি দিয়ক:  `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

মই Flatpak সংস্কৰণ ব্যৱহাৰ কৰিবলৈ বিশেষভাৱে পৰামৰ্শ দিছোঁ, কাৰণ, ডিষ্ট্ৰ’ বেচড wine (wine-staging) সদায় আপডেট হয় আৰু গেম কিছুদিনে নষ্ট হ'ব পাৰে। Flathub ৰ পৰা wine stable ব্যৱহাৰ কৰা বেছি ভাল, অথবা ডিষ্ট্ৰ' পেকেজৰ পৰা wine stable 5.0 বা 7.0 ব্যৱহাৰ কৰক।

#### [সমৰ্থিত Linux distro](https://flatpak.org/setup/) ত WineZGUI flatpak ইনষ্টল কৰক

WineZGUI মোৰ দ্বাৰা flatpak-wine হিচাপে পেকেজ কৰা হৈছে। [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) মোৰ আন flatpak এতিয়া deprecate কৰা হৈছে [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### এটা লিনাক্স চিষ্টেমত SETUP, চাওক [Requirements](https://github.com/fastrizwaan/WineZGUI#requirements)

ছেটআপটো তৎক্ষণাত হয় কাৰণ ই কেইটামান ফাইল নিৰ্দিষ্ট ডাইৰেক্টৰীত কপি কৰে।

##### সংস্কৰণ ০.৯৯.১৩

উৎস ডাউনলোড কৰক [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) অথবা ব্যৱহাৰ কৰক `git tag 0.99.13`

##### tar.gz ব্যৱহাৰ কৰি

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

##### উন্নয়ন সংস্কৰণ

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### WineZGUI আনইনষ্টল কৰক

##### Flatpak আনইনষ্টল

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### চistem আনইনষ্টল

একেই স্থাপন উৎস ডিৰেক্টৰীৰ পৰা `uninstall` চলাও

```
sudo ./setup --uninstall
```

## প্ৰয়োজনীয়তাসমূহ

`wine` - মুখ্য প্ৰগ্ৰাম

`winetricks` - wine addon script হবই লাগিব

`perl‑image‑exiftool` - এপ্লিকেচন/গেমৰ নাম উলিয়াবলৈ

`icoutils` - exe ফাইলৰ পৰা আইকন উলিয়াবলৈ

`gnome-terminal` - (ঐচ্ছিক) shell-ত prefix ডাইৰেক্টৰী এক্সেছ কৰিবলৈ

## লিনাক্স OS-ৰ বাবে প্ৰয়োজনীয়তা ইনষ্টল কৰক

### Flatpak সমৰ্থিত ডিষ্ট্ৰ'সমূহ

[flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) পাওক য'ত সকলো নিৰ্ভৰশীলতা সন্নিৱিষ্ট আছে। সেই ডিষ্ট্ৰ'সমূহৰ বাবে উপযোগী যিসবত wine পেকেজ কৰা হোৱা নাই।

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## ৰানটাইম নিৰ্ভৰশীলতা:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### ছলুছ

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### আৰ্চ লিনাক্স / এন্ডেভাৰঅএস

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### XBOX উপযুক্ত কণ্ট্ৰ'লাৰ

xbox 360 উপযুক্ত কণ্ট্ৰ'লাৰসমূহৰ বাবে kernel driver নিৰ্মাণ আৰু স্থাপন কৰক https://github.com/paroj/xpad পৰা


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---