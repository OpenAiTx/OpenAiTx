[![tests](https://github.com/krupkat/xpano/actions/workflows/test.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/test.yml)
[![clang-format](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml)
[![clang-tidy](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml)

# xpano

Xpano est un outil de création de panoramas mettant l’accent sur la simplicité et la facilité d’utilisation, les principales fonctionnalités comprennent :

- Détection automatique de groupes d’images pouvant être assemblées en panoramas
- Aperçu + zoom + déplacement des panoramas calculés
- Mode recadrage, remplissage automatique des bords, types de projection sélectionnables
- Ajustements de projection : tangage, lacet et roulis
- Export de panoramas en pleine résolution incluant les métadonnées exif


## Construit avec

L’application utilise l’excellente bibliothèque [OpenCV](https://opencv.org/) pour la manipulation d’images et son module de [stitching](https://docs.opencv.org/4.x/d1/d46/group__stitching.html) pour le calcul des panoramas.

Les autres dépendances incluent [imgui](https://github.com/ocornut/imgui), [SDL](https://github.com/libsdl-org/SDL), [spdlog](https://github.com/gabime/spdlog/), [Catch2](https://github.com/catchorg/Catch2), [nativefiledialog-extended](https://github.com/btzy/nativefiledialog-extended), [alpaca](https://github.com/p-ranav/alpaca), [thread-pool](https://github.com/bshoshany/thread-pool), [expected](https://github.com/TartanLlama/expected), [Exiv2](https://github.com/Exiv2/exiv2), [multiblend](https://horman.net/multiblend/), [SIMDe](https://github.com/simd-everywhere/simde) et les polices [Google Noto](https://fonts.google.com/noto).

## Démo

Découvrez la démo sur [YouTube](https://youtu.be/MyiTC3i1hK0).

![Interface principale de Xpano](https://gist.githubusercontent.com/krupkat/55ca0f085c944fb1ea2a7dc2a779f141/raw/f90afd675b1c0430db06a46984cbe5309908ddc1/1.webp)

## Installation

Installez directement depuis Flathub ou le Microsoft Store :

<a href='https://flathub.org/apps/details/cz.krupkat.Xpano'><img height='70' alt='Télécharger depuis Flathub' src='https://flathub.org/assets/badges/flathub-badge-en.png'/></a>&nbsp;&nbsp;<a href='https://apps.microsoft.com/store/detail/9PGQ5X33L0SC?launch=true&mode=full'><img height='70' alt='Télécharger depuis le Microsoft Store' src='https://get.microsoft.com/images/en-US%20dark.svg'/></a>

Obtenez des paquets supplémentaires :

- Exécutables Windows et MacOS depuis [GitHub](https://github.com/krupkat/xpano/releases)
- Paquets Ubuntu depuis mon [PPA Launchpad](https://launchpad.net/~krupkat/+archive/ubuntu/code)
- Paquets Nix depuis [nixpkgs](https://search.nixos.org/packages?channel=unstable&show=xpano)
- Archlinux AUR : [xpano-git](https://aur.archlinux.org/packages/xpano-git)

## Ligne de commande

Xpano dispose d'un support CLI de base, vous pouvez soit l'exécuter entièrement en automatique dans la ligne de commande, soit lancer l'interface graphique avec le drapeau `--gui`.

```
Xpano [<input files>] [--output=<path>] [--gui] [--help] [--version]
```

## Développement

Le projet peut être compilé en exécutant un seul script depuis le répertoire `misc/build`. Vous aurez besoin d'au moins CMake 3.21, git et d'un compilateur avec le support C++20.

### NixOS

Exécutez le script de compilation depuis la racine du dépôt :

```
nix-shell misc/build/nix/default.nix
./misc/build/build-nixos.sh
```

Problèmes possibles lors de l'exécution - [dépannage](https://gist.github.com/krupkat/cd0adbd584e2bfe154accdb393076fc3).

### MacOS

Prérequis des bibliothèques : SDL2, spdlog, catch2

Installer avec brew : `brew install sdl2 spdlog catch2`

Installer avec macports : `sudo port install libsdl2 spdlog catch2` (pour plus de détails : [#96](https://github.com/krupkat/xpano/pull/96#issuecomment-1575589249))

Exécutez le script de compilation depuis la racine du dépôt :

```
./misc/build/build-macos.sh
```

### Ubuntu 24.04

Prérequis des bibliothèques :

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev catch2
```

Exécutez le script de compilation depuis la racine du dépôt :

```
./misc/build/build-ubuntu-24.sh
```

### Ubuntu 22.04

Prérequis des bibliothèques :

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev
```

Exécutez le script de compilation depuis la racine du dépôt :

```
./misc/build/build-ubuntu-22.sh
```

### Windows

Ouvrez le profil "Developer PowerShell for VS 2022" dans Windows Terminal et exécutez le script de compilation depuis la racine du dépôt :

```
./misc/build/build-windows-latest.ps1
```

## Contributions

Les contributions sont les bienvenues, il y a quelques idées d'améliorations dans les [problèmes ouverts](https://github.com/krupkat/xpano/issues) que vous pourriez prendre en charge - si vous commencez à travailler sur l'un d'eux, veuillez ajouter un commentaire là-bas.

Veuillez consulter les [directives de contribution](https://github.com/krupkat/xpano/blob/main/CONTRIBUTING.md) pour plus de détails concernant la mise en forme et le style de codage.

## Licence

Distribué sous la licence *GPL-3.0-or-later*. Voir le texte complet de la [licence](https://github.com/krupkat/xpano/blob/main/LICENSE) pour plus d'informations.

## Contact

Tomas Krupka - [krupkat.cz](https://krupkat.cz)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---