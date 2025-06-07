<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - دسکتاپ راه دور شما"><br>
  <a href="#raw-steps-to-build">ساخت</a> •
  <a href="#how-to-build-with-docker">داکر</a> •
  <a href="#file-structure">ساختار</a> •
  <a href="#snapshot">اسکرین‌شات</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>ما به کمک شما برای ترجمه این فایل README، <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">رابط کاربری RustDesk</a> و <a href="https://github.com/rustdesk/doc.rustdesk.com">مستندات RustDesk</a> به زبان مادری شما نیاز داریم</b>
</p>

> [!توجه]
> **سلب مسئولیت سوءاستفاده:** <br>
> توسعه‌دهندگان RustDesk هیچگونه استفاده غیراخلاقی یا غیرقانونی از این نرم‌افزار را تأیید یا حمایت نمی‌کنند. سوءاستفاده، مانند دسترسی غیرمجاز، کنترل یا نقض حریم خصوصی، کاملاً برخلاف دستورالعمل‌های ما است. نویسندگان مسئول هیچگونه سوءاستفاده از این برنامه نیستند.

با ما گفتگو کنید: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

یک نرم‌افزار دسکتاپ راه دور دیگر، نوشته‌شده با Rust. بلافاصله قابل استفاده، بدون نیاز به تنظیمات. شما کنترل کامل داده‌های خود را دارید، بدون نگرانی در مورد امنیت. می‌توانید از سرور rendezvous/relay ما استفاده کنید، [سرور خود را راه‌اندازی کنید](https://rustdesk.com/server)، یا [سرور rendezvous/relay خود را بنویسید](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk از مشارکت همه استقبال می‌کند. برای شروع، به [CONTRIBUTING.md](docs/CONTRIBUTING.md) مراجعه کنید.

[**سؤالات متداول**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**دانلود باینری**](https://github.com/rustdesk/rustdesk/releases)

[**نسخه شبانه**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="دریافت از F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="دریافت از Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## وابستگی‌ها

نسخه دسکتاپ از Flutter یا Sciter (قدیمی) برای رابط کاربری استفاده می‌کند. این راهنما فقط برای Sciter است، زیرا شروع کار با آن ساده‌تر و دوستانه‌تر است. برای ساخت نسخه Flutter به [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) ما مراجعه کنید.

لطفاً کتابخانه دینامیک Sciter را خودتان دانلود کنید.

[ویندوز](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[لینوکس](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[مک‌اواس](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## مراحل خام ساخت

- محیط توسعه Rust و محیط ساخت ++C خود را آماده کنید

- [vcpkg](https://github.com/microsoft/vcpkg) را نصب کنید و متغیر محیطی `VCPKG_ROOT` را به درستی تنظیم نمایید

  - ویندوز: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - لینوکس/مک‌اواس: vcpkg install libvpx libyuv opus aom

- اجرای `cargo run`

## [ساخت](https://rustdesk.com/docs/en/dev/build/)

## نحوه ساخت روی لینوکس

### اوبونتو ۱۸ (دبیان ۱۰)

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### openSUSE Tumbleweed

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### فدورا ۲۸ (CentOS 8)

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### آرچ (Manjaro)

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### نصب vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### رفع مشکل libvpx (برای فدورا)

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

### ساخت

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

## نحوه ساخت با داکر

ابتدا مخزن را کلون و کانتینر داکر را بسازید:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

سپس، هر بار که نیاز به ساخت برنامه دارید، دستور زیر را اجرا کنید:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

توجه داشته باشید که ساخت اولیه ممکن است طولانی‌تر باشد تا وابستگی‌ها کش شوند، اما ساخت‌های بعدی سریع‌تر خواهد بود. همچنین، اگر نیاز به تعیین آرگومان‌های مختلف برای دستور ساخت دارید، می‌توانید آنها را در انتهای دستور در جایگاه `<OPTIONAL-ARGS>` وارد کنید. برای مثال، اگر می‌خواهید نسخه release بهینه شده بسازید، دستور بالا را با `--release` اجرا کنید. فایل اجرایی حاصل در پوشه target روی سیستم شما قرار می‌گیرد و با دستور زیر قابل اجراست:

```sh
target/debug/rustdesk
```

یا اگر نسخه release را اجرا می‌کنید:

```sh
target/release/rustdesk
```

لطفاً اطمینان حاصل کنید که این دستورات را از ریشه مخزن RustDesk اجرا می‌کنید، در غیر این صورت برنامه ممکن است منابع مورد نیاز را پیدا نکند. همچنین توجه داشته باشید که سایر زیرفرمان‌های cargo مانند `install` یا `run` در حال حاضر از این طریق پشتیبانی نمی‌شوند، زیرا برنامه را درون کانتینر نصب یا اجرا می‌کنند و نه روی میزبان.

## ساختار فایل‌ها

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: کدک ویدئو، تنظیمات، پوشش tcp/udp، protobuf، توابع فایل برای انتقال فایل و برخی توابع کاربردی دیگر
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: تصویربرداری از صفحه
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: کنترل صفحه‌کلید/ماوس اختصاصی پلتفرم
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: پیاده‌سازی کپی و چسباندن فایل برای ویندوز، لینوکس و مک‌اواس.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: رابط کاربری Sciter منسوخ (غیرفعال)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: سرویس‌های صدا/کلیپ‌بورد/ورودی/ویدئو و ارتباطات شبکه
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: شروع یک اتصال همتا به همتا
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: ارتباط با [rustdesk-server](https://github.com/rustdesk/rustdesk-server)، انتظار برای اتصال مستقیم راه دور (TCP hole punching) یا اتصال relayed
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: کد اختصاصی پلتفرم
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: کد Flutter برای دسکتاپ و موبایل
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: جاوااسکریپت برای وب‌کلاینت Flutter

## اسکرین‌شات‌ها

![مدیر اتصال](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![اتصال به یک کامپیوتر ویندوزی](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![انتقال فایل](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![تونلینگ TCP](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---