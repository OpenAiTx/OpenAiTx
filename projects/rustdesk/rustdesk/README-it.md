<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Il tuo desktop remoto"><br>
  <a href="#raw-steps-to-build">Build</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Struttura</a> •
  <a href="#snapshot">Snapshot</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Abbiamo bisogno del tuo aiuto per tradurre questo README, la <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">UI di RustDesk</a> e la <a href="https://github.com/rustdesk/doc.rustdesk.com">documentazione di RustDesk</a> nella tua lingua madre</b>
</p>

> [!Caution]
> **Disclaimer di Uso Improprio:** <br>
> Gli sviluppatori di RustDesk non approvano né supportano alcun uso non etico o illegale di questo software. L’uso improprio, come l’accesso non autorizzato, il controllo o l’invasione della privacy, è severamente contrario alle nostre linee guida. Gli autori non sono responsabili per qualsiasi uso improprio dell’applicazione.

Chatta con noi: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Un altro software di desktop remoto, scritto in Rust. Funziona subito, senza necessità di configurazione. Hai il pieno controllo dei tuoi dati, senza preoccupazioni sulla sicurezza. Puoi usare il nostro server rendezvous/relay, [impostare il tuo](https://rustdesk.com/server), oppure [scrivere il tuo server rendezvous/relay](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk accoglie contributi da parte di tutti. Consulta [CONTRIBUTING.md](docs/CONTRIBUTING.md) per iniziare.

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**DOWNLOAD BINARI**](https://github.com/rustdesk/rustdesk/releases)

[**BUILD NIGHTLY**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Scaricalo su F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Scaricalo su Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Dipendenze

Le versioni desktop utilizzano Flutter o Sciter (deprecato) per la GUI, questa guida è solo per Sciter, poiché è più semplice e più adatta per iniziare. Consulta il nostro [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) per la build della versione Flutter.

Scarica tu stesso la libreria dinamica di Sciter.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Passaggi grezzi per la build

- Prepara il tuo ambiente di sviluppo Rust e C++

- Installa [vcpkg](https://github.com/microsoft/vcpkg) e imposta correttamente la variabile d’ambiente `VCPKG_ROOT`

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- esegui `cargo run`

## [Build](https://rustdesk.com/docs/en/dev/build/)

## Come costruire su Linux

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

### Installa vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Fix libvpx (Per Fedora)

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

## Come costruire con Docker

Inizia clonando il repository e costruendo il container Docker:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Poi, ogni volta che hai bisogno di costruire l’applicazione, esegui il seguente comando:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Nota che la prima build potrebbe richiedere più tempo prima che le dipendenze vengano memorizzate in cache, le build successive saranno più veloci. Inoltre, se hai bisogno di specificare diversi argomenti per il comando di build, puoi farlo nella posizione `<OPTIONAL-ARGS>` alla fine del comando. Ad esempio, se vuoi costruire una versione ottimizzata per il rilascio, esegui il comando sopra seguito da `--release`. L’eseguibile risultante sarà disponibile nella cartella target sul tuo sistema e può essere eseguito con:

```sh
target/debug/rustdesk
```

Oppure, se stai eseguendo un eseguibile release:

```sh
target/release/rustdesk
```

Assicurati di eseguire questi comandi dalla radice del repository RustDesk, altrimenti l’applicazione potrebbe non trovare le risorse richieste. Nota inoltre che altri sottocomandi cargo come `install` o `run` non sono attualmente supportati con questo metodo, in quanto installerebbero o eseguirebbero il programma all’interno del container invece che sull’host.

## Struttura dei file

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: codec video, configurazione, wrapper tcp/udp, protobuf, funzioni fs per il trasferimento file e altre funzioni di utilità
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: acquisizione schermo
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: controllo tastiera/mouse specifico per piattaforma
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: implementazione copia/incolla file per Windows, Linux, macOS.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: UI Sciter obsoleta (deprecata)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: servizi audio/clipboard/input/video e connessioni di rete
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: avvia una connessione peer
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: Comunica con [rustdesk-server](https://github.com/rustdesk/rustdesk-server), attende una connessione diretta remota (TCP hole punching) o una connessione relay
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: codice specifico per piattaforma
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: codice Flutter per desktop e mobile
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript per il client web Flutter

## Screenshot

![Gestore Connessioni](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Connesso a un PC Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Trasferimento File](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![Tunneling TCP](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---