<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Twój pulpit zdalny"><br>
  <a href="#raw-steps-to-build">Kompilacja</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Struktura</a> •
  <a href="#snapshot">Zrzut ekranu</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Potrzebujemy Twojej pomocy w tłumaczeniu tego README, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">interfejsu RustDesk</a> i <a href="https://github.com/rustdesk/doc.rustdesk.com">dokumentacji RustDesk</a> na Twój język ojczysty</b>
</p>

> [!Caution]
> **Zastrzeżenie dotyczące niewłaściwego użycia:** <br>
> Twórcy RustDesk nie popierają ani nie wspierają nieetycznego lub nielegalnego wykorzystania tego oprogramowania. Nadużycia, takie jak nieautoryzowany dostęp, kontrola lub naruszenie prywatności, są surowo zabronione przez nasze wytyczne. Autorzy nie ponoszą odpowiedzialności za jakiekolwiek niewłaściwe użycie aplikacji.

Czat z nami: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Kolejne oprogramowanie do zdalnego pulpitu, napisane w Rust. Działa od razu po uruchomieniu, bez konieczności konfiguracji. Masz pełną kontrolę nad swoimi danymi, bez obaw o bezpieczeństwo. Możesz używać naszego serwera pośredniczącego/relay, [skonfigurować własny](https://rustdesk.com/server), lub [napisać własny serwer pośredniczący/relay](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk zaprasza do współpracy wszystkich. Zobacz [CONTRIBUTING.md](docs/CONTRIBUTING.md), aby dowiedzieć się jak zacząć.

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**POBIERZ BINARY**](https://github.com/rustdesk/rustdesk/releases)

[**NIGHTLY BUILD**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Wymagane zależności

Wersje desktopowe korzystają z Flutter lub Sciter (przestarzały) do GUI; ten poradnik dotyczy tylko Sciter, ponieważ jest łatwiejszy i bardziej przyjazny na start. Zobacz nasz [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) w celu kompilacji wersji Flutter.

Pobierz samodzielnie dynamiczną bibliotekę Sciter.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Surowe kroki kompilacji

- Przygotuj środowisko deweloperskie Rust oraz środowisko do budowania C++

- Zainstaluj [vcpkg](https://github.com/microsoft/vcpkg) i poprawnie ustaw zmienną środowiskową `VCPKG_ROOT`

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- uruchom `cargo run`

## [Kompilacja](https://rustdesk.com/docs/en/dev/build/)

## Jak zbudować na Linuksie

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

### Instalacja vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Naprawa libvpx (dla Fedory)

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

### Kompilacja

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

## Jak zbudować za pomocą Dockera

Rozpocznij od sklonowania repozytorium i zbudowania kontenera Dockera:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Następnie, za każdym razem gdy chcesz zbudować aplikację, uruchom następujące polecenie:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Zauważ, że pierwsza kompilacja może potrwać dłużej zanim zależności zostaną zbuforowane, kolejne kompilacje będą szybsze. Dodatkowo, jeśli chcesz określić inne argumenty polecenia kompilacji, możesz to zrobić na końcu polecenia w pozycji `<OPTIONAL-ARGS>`. Na przykład, jeśli chcesz zbudować zoptymalizowaną wersję release, uruchom powyższe polecenie z `--release`. Powstały plik wykonywalny będzie dostępny w folderze target na Twoim systemie i można go uruchomić za pomocą:

```sh
target/debug/rustdesk
```

lub, jeśli uruchamiasz wersję release:

```sh
target/release/rustdesk
```

Upewnij się, że uruchamiasz te polecenia z katalogu głównego repozytorium RustDesk, w przeciwnym razie aplikacja może nie znaleźć wymaganych zasobów. Zwróć także uwagę, że inne podkomendy cargo, takie jak `install` czy `run`, nie są obecnie wspierane tą metodą, ponieważ instalowałyby lub uruchamiały program wewnątrz kontenera zamiast na hoście.

## Struktura plików

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: kodek wideo, konfiguracja, wrapper tcp/udp, protobuf, funkcje fs dla transferu plików oraz inne funkcje pomocnicze
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: przechwytywanie ekranu
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: specyficzne dla platformy sterowanie klawiaturą/myszą
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: implementacja kopiuj-wklej plików dla Windows, Linux, macOS
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: przestarzały interfejs Sciter (deprecated)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: usługi audio/schowka/wejścia/wideo oraz połączenia sieciowe
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: uruchomienie połączenia peer
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: komunikacja z [rustdesk-server](https://github.com/rustdesk/rustdesk-server), oczekiwanie na zdalne połączenie bezpośrednie (TCP hole punching) lub przez relay
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: kod specyficzny dla platformy
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: kod Flutter dla desktop i mobile
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript dla klienta Flutter web

## Zrzuty ekranu

![Menadżer połączeń](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Połączono z komputerem Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Transfer plików](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![Tunelowanie TCP](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---