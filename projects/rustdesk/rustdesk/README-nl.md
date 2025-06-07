<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Uw remote desktop"><br>
  <a href="#raw-steps-to-build">Bouwen</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Structuur</a> •
  <a href="#snapshot">Snapshot</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Wij hebben uw hulp nodig om deze README, de <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">RustDesk UI</a> en de <a href="https://github.com/rustdesk/doc.rustdesk.com">RustDesk Doc</a> naar uw moedertaal te vertalen</b>
</p>

> [!Waarschuwing]
> **Disclaimer over misbruik:** <br>
> De ontwikkelaars van RustDesk keuren geen enkele onethische of illegale toepassing van deze software goed of ondersteunen deze niet. Misbruik, zoals ongeautoriseerde toegang, controle of inbreuk op de privacy, is strikt in strijd met onze richtlijnen. De auteurs zijn niet verantwoordelijk voor enig misbruik van de applicatie.

Chat met ons: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Nog een andere remote desktop software, geschreven in Rust. Werkt direct uit de doos, geen configuratie vereist. U heeft volledige controle over uw gegevens, zonder zorgen over beveiliging. U kunt onze rendezvous/relay-server gebruiken, [uw eigen server opzetten](https://rustdesk.com/server), of [uw eigen rendezvous/relay-server schrijven](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk verwelkomt bijdragen van iedereen. Zie [CONTRIBUTING.md](docs/CONTRIBUTING.md) voor hulp bij het beginnen.

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**BINARY DOWNLOAD**](https://github.com/rustdesk/rustdesk/releases)

[**NIGHTLY BUILD**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Afhankelijkheden

Desktopversies gebruiken Flutter of Sciter (verouderd) voor de GUI, deze handleiding is alleen voor Sciter, omdat het makkelijker en vriendelijker is om mee te starten. Bekijk onze [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) voor het bouwen van de Flutter-versie.

Download de Sciter-dynamische bibliotheek zelf.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Stappen om te bouwen

- Bereid uw Rust-ontwikkelomgeving en C++ build-omgeving voor

- Installeer [vcpkg](https://github.com/microsoft/vcpkg), en stel de `VCPKG_ROOT`-omgevingsvariabele correct in

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- voer `cargo run` uit

## [Bouwen](https://rustdesk.com/docs/en/dev/build/)

## Hoe te bouwen op Linux

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

### Installeer vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Fix libvpx (Voor Fedora)

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

### Bouwen

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

## Hoe te bouwen met Docker

Begin met het klonen van de repository en het bouwen van de Docker-container:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Elke keer dat u de applicatie wilt bouwen, voert u het volgende commando uit:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Let op dat de eerste build langer kan duren voordat afhankelijkheden zijn gecachet; latere builds zullen sneller gaan. Als u andere argumenten aan het build-commando moet toevoegen, kan dat op het einde van het commando in de positie `<OPTIONAL-ARGS>`. Als u bijvoorbeeld een geoptimaliseerde releaseversie wilt bouwen, voegt u `--release` toe aan het commando hierboven. Het resulterende uitvoerbare bestand is te vinden in de target-map op uw systeem en kan uitgevoerd worden met:

```sh
target/debug/rustdesk
```

Of, als u een release-uitvoerbaar bestand draait:

```sh
target/release/rustdesk
```

Zorg ervoor dat u deze commando's uitvoert vanuit de hoofdmap van de RustDesk-repository, anders kan de applicatie mogelijk niet de vereiste resources vinden. Merk ook op dat andere cargo-subcommando's zoals `install` of `run` momenteel niet ondersteund worden via deze methode, omdat deze het programma binnen de container zouden installeren of uitvoeren in plaats van op de host.

## Bestandsstructuur

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: video codec, configuratie, tcp/udp-wrapper, protobuf, fs-functies voor bestandsoverdracht, en enkele andere hulpfuncties
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: schermopname
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: platformspecifieke bediening van toetsenbord/muis
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: implementatie van kopiëren en plakken van bestanden voor Windows, Linux, macOS.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: verouderde Sciter UI (deprecated)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: audio/clipboard/input/video services en netwerkverbindingen
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: start een peerverbinding
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: Communiceert met [rustdesk-server](https://github.com/rustdesk/rustdesk-server), wacht op directe (TCP hole punching) of doorgestuurde verbinding
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: platformspecifieke code
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: Flutter-code voor desktop en mobiel
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript voor de Flutter webclient

## Screenshots

![Connection Manager](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Verbonden met een Windows-pc](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Bestandsoverdracht](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP-tunneling](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---