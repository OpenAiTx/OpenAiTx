<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Ваш удалённый рабочий стол"><br>
  <a href="#raw-steps-to-build">Сборка</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Структура</a> •
  <a href="#snapshot">Снимок</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Нам нужна ваша помощь с переводом этого README, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">интерфейса RustDesk</a> и <a href="https://github.com/rustdesk/doc.rustdesk.com">документации RustDesk</a> на ваш родной язык</b>
</p>

> [!Caution]
> **Отказ от ответственности при неправильном использовании:** <br>
> Разработчики RustDesk не одобряют и не поддерживают неэтичное или незаконное использование данного программного обеспечения. Злоупотребление, такое как несанкционированный доступ, контроль или вторжение в частную жизнь, строго запрещено нашими правилами. Авторы не несут ответственности за любое неправомерное использование приложения.

Общайтесь с нами: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Ещё одна программа для удалённого рабочего стола, написанная на Rust. Работает "из коробки", не требует настройки. Вы полностью контролируете свои данные, не беспокоясь о безопасности. Вы можете использовать наш сервер rendezvous/relay, [развернуть свой собственный](https://rustdesk.com/server), или [написать свой сервер rendezvous/relay](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk приветствует вклад каждого. См. [CONTRIBUTING.md](docs/CONTRIBUTING.md) для начала работы.

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**СКАЧАТЬ БИНАРНЫЕ ФАЙЛЫ**](https://github.com/rustdesk/rustdesk/releases)

[**НОЧНАЯ СБОРКА**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Зависимости

Десктопные версии используют Flutter или Sciter (устаревший) для GUI, это руководство предназначено только для Sciter, так как он проще для начала. Ознакомьтесь с нашим [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) для сборки версии на Flutter.

Пожалуйста, скачайте динамическую библиотеку Sciter самостоятельно.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Основные шаги для сборки

- Подготовьте среду разработки Rust и среду сборки C++

- Установите [vcpkg](https://github.com/microsoft/vcpkg) и корректно задайте переменную окружения `VCPKG_ROOT`

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- выполните `cargo run`

## [Сборка](https://rustdesk.com/docs/en/dev/build/)

## Как собрать на Linux

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

### Установка vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Исправление libvpx (Для Fedora)

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

### Сборка

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

## Как собрать с помощью Docker

Начните с клонирования репозитория и сборки контейнера Docker:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Затем каждый раз, когда нужно собрать приложение, выполняйте следующую команду:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Обратите внимание, что первая сборка может занять больше времени, пока не будут закешированы зависимости, последующие сборки будут быстрее. Кроме того, если вам нужно указать другие параметры для команды сборки, вы можете сделать это в конце команды в позиции `<OPTIONAL-ARGS>`. Например, если вы хотите собрать оптимизированную релизную версию, выполните команду выше с добавлением `--release`. Получившийся исполняемый файл будет доступен в папке target вашей системы и может быть запущен с помощью:

```sh
target/debug/rustdesk
```

Или, если вы запускаете релизный исполняемый файл:

```sh
target/release/rustdesk
```

Пожалуйста, убедитесь, что вы выполняете эти команды из корня репозитория RustDesk, иначе приложение может не найти необходимые ресурсы. Также обратите внимание, что другие подкоманды cargo, такие как `install` или `run`, в настоящее время не поддерживаются этим методом, так как они будут устанавливаться или запускаться внутри контейнера, а не на хосте.

## Структура файлов

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: видеокодек, конфиг, обёртка tcp/udp, protobuf, функции работы с файлами для передачи файлов и другие утилиты
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: захват экрана
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: платформенно-зависимое управление клавиатурой/мышью
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: реализация копирования и вставки файлов для Windows, Linux, macOS.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: устаревший интерфейс на Sciter (deprecated)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: сервисы аудио/буфера обмена/ввода/видео и сетевые соединения
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: запуск peer-соединения
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: взаимодействие с [rustdesk-server](https://github.com/rustdesk/rustdesk-server), ожидание прямого (TCP hole punching) или ретранслируемого соединения
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: платформенно-зависимый код
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: код Flutter для десктопа и мобильных устройств
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript для Flutter web-клиента

## Скриншоты

![Менеджер соединений](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Подключение к ПК с Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Передача файлов](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP-туннелирование](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---