# ytdlp-gui
eine GUI für yt-dlp, geschrieben in Rust

- [Installation](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [andere Distributionen](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Vom Quellcode bauen](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Konfiguration](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Beitrag](https://github.com/BKSalman/ytdlp-gui#contribution)

# Vorschau
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Installation
## Linux

### NixOS (Flake)
Du kannst die flake.nix im Repository verwenden

in deiner `flake.nix`:
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

dann kannst du es als normales Paket hinzufügen, entweder zu deinem home-manager oder nixosConfiguration

### Fedora
Lade das rpm-Paket von der Releases-Seite herunter und installiere es mit ``sudo dnf localinstall <rpm_package_name>``

### Ubuntu
Lade das deb-Paket von der Releases-Seite herunter und installiere es mit ``sudo apt install ./<deb_package_name>``

### Arch

Verfügbar im AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### andere Distributionen

#### 1- lade ``yt-dlp`` herunter
entweder

&nbsp; &nbsp; &nbsp; a- aus dem Repo deiner Distribution

&nbsp; &nbsp; &nbsp; b- oder lade das [Binary](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp) herunter, verschiebe es dann in dein bin-Verzeichnis und mache es ausführbar mit `chmod +x <bin_file>`

#### 2- lade ``ffmpeg`` oder ``ffmpeg-free`` aus den Repos deiner Distribution


#### 3- lade das ``ytdlp-gui`` Binary von der [Releases-Seite](https://github.com/BKSalman/ytdlp-gui/releases) herunter

## Windows
##### lade einfach die Zip-Datei von der Releases-Seite herunter, entpacke sie in einem Unterordner und starte die ``ytdlp-gui.exe``

# Vom Quellcode bauen
Um vom Quellcode zu bauen, brauchst du `cargo` und `rustc`, du kannst sie über `rustup` (Rust Toolchain Manager) oder aus den Repos deiner Distribution installieren, wie es dir beliebt

Danach führe folgende Befehle aus:
```bash
# klone das Repository in den Ordner "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# wechsle in den Ordner
cd ytdlp-gui
# du kannst das Projekt entweder so bauen
cargo build
# oder im Release-Modus für bessere Performance
cargo build -r
```
Das Binary befindet sich dann entweder in `<project-root>/target/debug/ytdlp-gui` oder `<project-root>/target/release/ytdlp-gui`

und du kannst es entweder direkt ausführen:
```bash
# vom Projektstammverzeichnis
./target/release/ytdlp-gui
```

oder mit cargo:
```bash
cargo r
# oder für den Release-Modus
cargo r -r
```

# Konfiguration

Ab Version v0.2.2+ speichert die Anwendung die Konfiguration im Standard-Konfigurationsverzeichnis der jeweiligen Plattform/OS in ``<config_dir>/ytdlp-gui/config.toml``

Die Standarddatei sieht so aus:

```toml
# Optional
# Dies ist das Verzeichnis des Binaries, nicht das Binary selbst
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) wenn nicht gesetzt, ist der Befehl `yt-dlp <app_args>`

# Optional
download_folder = "<some_cool_path>" # Standard = "~/Videos"

[options]
video_resolution = "FullHD" # Optionen: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # Optionen: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # Optionen: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" # Optionen: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Hinweis: Die Qualitäts-/Formatoptionen werden automatisch gespeichert, wenn der Download-Button gedrückt wird

# Beitrag
Alle Formen von Beiträgen sind willkommen, sei es Pull Requests, Issues (Bug Reports/Feature Requests)

Allerdings könnte ich nicht schnell darauf antworten oder die gewünschten Sachen implementieren, da ich mich auf andere Dinge konzentriere

Aber ich werde mein Bestes geben 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---