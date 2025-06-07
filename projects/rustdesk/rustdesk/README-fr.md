<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Votre bureau à distance"><br>
  <a href="#raw-steps-to-build">Compilation</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Structure</a> •
  <a href="#snapshot">Aperçu</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonésien</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Néerlandais</a>] | [<a href="docs/README-IT.md">Italien</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Portugais (Brésil)</a>] | [<a href="docs/README-EO.md">Espéranto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Danois</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Turc</a>] | [<a href="docs/README-NO.md">Norvégien</a>]<br>
  <b>Nous avons besoin de votre aide pour traduire ce README, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">l'UI de RustDesk</a> et la <a href="https://github.com/rustdesk/doc.rustdesk.com">documentation RustDesk</a> dans votre langue maternelle</b>
</p>

> [!Caution]
> **Avertissement d'utilisation abusive :** <br>
> Les développeurs de RustDesk ne cautionnent ni ne soutiennent aucun usage non éthique ou illégal de ce logiciel. Toute utilisation abusive, telle qu'un accès non autorisé, un contrôle ou une atteinte à la vie privée, est strictement contraire à nos directives. Les auteurs ne sont pas responsables de toute utilisation abusive de l'application.

Discutez avec nous : [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Encore un autre logiciel de bureau à distance, écrit en Rust. Fonctionne immédiatement, aucune configuration requise. Vous avez un contrôle total sur vos données, sans préoccupations de sécurité. Vous pouvez utiliser notre serveur de rendez-vous/relai, [installer le vôtre](https://rustdesk.com/server), ou [développer votre propre serveur de rendez-vous/relai](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk accueille les contributions de tous. Consultez [CONTRIBUTING.md](docs/CONTRIBUTING.md) pour commencer.

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**TÉLÉCHARGEMENT DES BINAIRES**](https://github.com/rustdesk/rustdesk/releases)

[**VERSION NIGHTLY**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Obtenez-le sur F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Obtenez-le sur Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Dépendances

Les versions de bureau utilisent Flutter ou Sciter (obsolète) pour l'interface graphique, ce tutoriel concerne uniquement Sciter, car il est plus simple et plus convivial pour débuter. Consultez notre [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) pour la version Flutter.

Veuillez télécharger vous-même la bibliothèque dynamique Sciter.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Étapes brutes pour la compilation

- Préparez votre environnement de développement Rust et l'environnement de compilation C++

- Installez [vcpkg](https://github.com/microsoft/vcpkg), et définissez correctement la variable d'environnement `VCPKG_ROOT`

  - Windows : vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS : vcpkg install libvpx libyuv opus aom

- Exécutez `cargo run`

## [Compilation](https://rustdesk.com/docs/en/dev/build/)

## Comment compiler sous Linux

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

### Installer vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Correction de libvpx (Pour Fedora)

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

### Compilation

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

## Comment compiler avec Docker

Commencez par cloner le dépôt et construire le conteneur Docker :

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Ensuite, chaque fois que vous souhaitez compiler l'application, exécutez la commande suivante :

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Notez que la première compilation peut prendre plus de temps, car les dépendances doivent être mises en cache. Les compilations suivantes seront plus rapides. De plus, si vous souhaitez spécifier différents arguments à la commande de compilation, vous pouvez les ajouter à la fin de la commande à la position `<OPTIONAL-ARGS>`. Par exemple, si vous souhaitez compiler une version optimisée, exécutez la commande ci-dessus suivie de `--release`. L'exécutable résultant sera disponible dans le dossier target sur votre système, et peut être exécuté avec :

```sh
target/debug/rustdesk
```

Ou, si vous exécutez l'exécutable en mode release :

```sh
target/release/rustdesk
```

Veuillez vous assurer d'exécuter ces commandes à la racine du dépôt RustDesk, sinon l'application pourrait ne pas trouver les ressources nécessaires. Notez également que d'autres sous-commandes cargo telles que `install` ou `run` ne sont pas actuellement supportées via cette méthode, car elles installeraient ou exécuteraient le programme à l'intérieur du conteneur au lieu de l'hôte.

## Structure des fichiers

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)** : codec vidéo, configuration, wrapper tcp/udp, protobuf, fonctions fs pour le transfert de fichiers, et autres fonctions utilitaires
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)** : capture d'écran
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)** : contrôle clavier/souris spécifique à la plateforme
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)** : implémentation du copier-coller de fichiers pour Windows, Linux, macOS.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)** : interface Sciter obsolète (dépréciée)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)** : services audio/presse-papiers/entrée/vidéo, et connexions réseau
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)** : démarrer une connexion peer
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)** : communication avec [rustdesk-server](https://github.com/rustdesk/rustdesk-server), attente d'une connexion directe distante (TCP hole punching) ou relayée
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)** : code spécifique à la plateforme
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)** : code Flutter pour bureau et mobile
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)** : JavaScript pour le client web Flutter

## Captures d'écran

![Gestionnaire de connexions](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Connecté à un PC Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Transfert de fichiers](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![Tunnel TCP](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---