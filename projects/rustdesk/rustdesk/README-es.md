<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Tu escritorio remoto"><br>
  <a href="#raw-steps-to-build">Compilar</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Estructura</a> •
  <a href="#snapshot">Instantánea</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Necesitamos tu ayuda para traducir este README, la <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">interfaz de RustDesk</a> y la <a href="https://github.com/rustdesk/doc.rustdesk.com">documentación de RustDesk</a> a tu idioma nativo</b>
</p>

> [!Caution]
> **Descargo de responsabilidad sobre el uso indebido:** <br>
> Los desarrolladores de RustDesk no aprueban ni apoyan ningún uso no ético o ilegal de este software. El uso indebido, como el acceso no autorizado, control o invasión de la privacidad, está estrictamente en contra de nuestras directrices. Los autores no son responsables de ningún uso indebido de la aplicación.

Chatea con nosotros: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Otro software de escritorio remoto, escrito en Rust. Funciona inmediatamente, sin necesidad de configuración. Tienes control total sobre tus datos, sin preocupaciones de seguridad. Puedes usar nuestro servidor de rendezvous/relay, [configurar el tuyo propio](https://rustdesk.com/server), o [escribir tu propio servidor de rendezvous/relay](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk da la bienvenida a contribuciones de todos. Consulta [CONTRIBUTING.md](docs/CONTRIBUTING.md) para empezar.

[**PREGUNTAS FRECUENTES**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**DESCARGA BINARIOS**](https://github.com/rustdesk/rustdesk/releases)

[**COMPILACIÓN NIGHTLY**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Consíguelo en F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Consíguelo en Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Dependencias

Las versiones de escritorio usan Flutter o Sciter (obsoleto) para la interfaz gráfica; este tutorial es solo para Sciter, ya que es más fácil y amigable para comenzar. Consulta nuestro [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) para compilar la versión Flutter.

Por favor, descarga la biblioteca dinámica de Sciter por tu cuenta.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Pasos básicos para compilar

- Prepara tu entorno de desarrollo Rust y entorno de compilación C++

- Instala [vcpkg](https://github.com/microsoft/vcpkg), y configura la variable de entorno `VCPKG_ROOT` correctamente

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- Ejecuta `cargo run`

## [Compilar](https://rustdesk.com/docs/en/dev/build/)

## Cómo compilar en Linux

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

### Instalar vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Arreglar libvpx (Para Fedora)

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

### Compilar

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

## Cómo compilar con Docker

Comienza clonando el repositorio y construyendo el contenedor Docker:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Luego, cada vez que necesites compilar la aplicación, ejecuta el siguiente comando:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Ten en cuenta que la primera compilación puede tardar más hasta que las dependencias se almacenen en caché, las compilaciones posteriores serán más rápidas. Además, si necesitas especificar diferentes argumentos para el comando de compilación, puedes hacerlo al final del comando en la posición `<OPCIONAL-ARGS>`. Por ejemplo, si deseas compilar una versión optimizada de release, ejecuta el comando anterior seguido de `--release`. El ejecutable resultante estará disponible en la carpeta target de tu sistema, y puede ejecutarse con:

```sh
target/debug/rustdesk
```

O, si estás ejecutando un ejecutable de release:

```sh
target/release/rustdesk
```

Asegúrate de ejecutar estos comandos desde la raíz del repositorio de RustDesk, de lo contrario la aplicación podría no encontrar los recursos requeridos. También ten en cuenta que otros subcomandos de cargo como `install` o `run` no están actualmente soportados mediante este método, ya que instalarían o ejecutarían el programa dentro del contenedor en vez de en el host.

## Estructura de archivos

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: códec de video, configuración, envoltorio tcp/udp, protobuf, funciones de sistema de archivos para transferencia de archivos y otras funciones utilitarias
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: captura de pantalla
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: control de teclado/ratón específico de la plataforma
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: implementación de copiar y pegar archivos para Windows, Linux, macOS.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: interfaz Sciter obsoleta (deprecated)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: servicios de audio/portapapeles/entrada/video y conexiones de red
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: iniciar una conexión entre pares
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: Comunicarse con [rustdesk-server](https://github.com/rustdesk/rustdesk-server), esperar por conexión directa remota (TCP hole punching) o conexión retransmitida
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: código específico de la plataforma
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: código Flutter para escritorio y móvil
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript para el cliente web Flutter

## Capturas de pantalla

![Administrador de conexiones](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Conectado a un PC con Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Transferencia de archivos](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![Túnel TCP](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---