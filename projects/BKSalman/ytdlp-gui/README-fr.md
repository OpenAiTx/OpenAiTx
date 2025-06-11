# ytdlp-gui
une interface graphique pour yt-dlp écrite en Rust

- [Installation](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [autres distributions](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Compilation depuis les sources](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Configuration](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Contribution](https://github.com/BKSalman/ytdlp-gui#contribution)

# Aperçu
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Installation
## Linux

### NixOS (Flake)
vous pouvez utiliser le flake.nix dans le dépôt

dans votre `flake.nix` :
```nix
{
  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixpkgs-unstable";

    ytdlp-gui = {
      url = "github:bksalman/ytdlp-gui";
    };
  };

    outputs = { nixpkgs, ytdlp-gui, ...}:
    let
      system = "x86_64-linux";

      pkgs = import nixpkgs {
        inherit system;
        overlays = [
          ytdlp-gui.overlay
        ];
      };
    in
    {
      ...snip
```

puis vous pouvez l'ajouter comme un paquet normal, soit à votre home-manager soit à votre nixosConfiguration

### Fedora
téléchargez le paquet rpm depuis la page des releases puis installez-le avec ``sudo dnf localinstall <nom_du_paquet_rpm>``

### Ubuntu
téléchargez le paquet deb depuis la page des releases puis installez-le avec ``sudo apt install ./<nom_du_paquet_deb>``

### Arch

Disponible dans l'AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### autres distributions

#### 1- téléchargez ``yt-dlp``
soit

&nbsp; &nbsp; &nbsp; a- depuis le dépôt de votre distribution

&nbsp; &nbsp; &nbsp; b- ou téléchargez le [binaire](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp), puis déplacez-le dans votre répertoire bin, et rendez-le exécutable en lançant `chmod +x <fichier_bin>`

#### 2- téléchargez ``ffmpeg`` ou ``ffmpeg-free`` depuis les dépôts de votre distribution


#### 3- téléchargez le binaire ``ytdlp-gui`` depuis la [page des releases](https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### téléchargez simplement le fichier zip depuis la page des releases, extrayez-le dans un sous-dossier et lancez le fichier ``ytdlp-gui.exe``

# Compilation depuis les sources
pour compiler depuis les sources, vous devez avoir `cargo` et `rustc`, vous pouvez les installer via `rustup` (gestionnaire de toolchain Rust), ou depuis les dépôts de votre distribution, selon ce que vous préférez

ensuite lancez les commandes suivantes :
```bash
# clonez le dépôt dans le dossier "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# entrez dans le dossier
cd ytdlp-gui
# vous pouvez soit compiler le projet avec cette commande
cargo build
# ou le compiler en mode release pour de meilleures performances
cargo build -r
```
le binaire sera alors dans `<racine-du-projet>/target/debug/ytdlp-gui` ou `<racine-du-projet>/target/release/ytdlp-gui`

et vous pouvez soit le lancer directement :
```bash
# depuis la racine du projet
./target/release/ytdlp-gui
```

ou via cargo :
```bash
cargo r
# ou en mode release
cargo r -r
```

# Configuration

Pour la version v0.2.2+ l'application sauvegarde la configuration dans le répertoire de configuration par défaut de la plateforme/OS dans ``<config_dir>/ytdlp-gui/config.toml``

le fichier par défaut ressemble à ceci :

```toml
# Optionnel
# Ceci est le répertoire du binaire, pas le binaire lui-même
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) si non défini la commande sera `yt-dlp <app_args>`

# Optionnel
download_folder = "<some_cool_path>" # par défaut = "~/Videos"

[options]
video_resolution = "FullHD" # options : "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # options : "Mp4" "Mkv" "Webm"
audio_quality = "Good" # options : "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  options : "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Note : les options de qualité/format sont automatiquement sauvegardées lorsque vous appuyez sur le bouton de téléchargement

# Contribution
Toutes les formes de contributions sont les bienvenues, que ce soit des Pull requests, Issues (rapports de bugs/demandes d'améliorations)

Cependant, je ne serai pas toujours rapide à y répondre, ni à implémenter les demandes, car je me concentre sur d'autres choses

Mais je ferai de mon mieux 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---