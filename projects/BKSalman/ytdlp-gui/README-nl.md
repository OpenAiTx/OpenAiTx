# ytdlp-gui
een GUI voor yt-dlp geschreven in Rust

- [Installatie](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [andere distributies](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Bouwen vanuit broncode](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Configuratie](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Bijdragen](https://github.com/BKSalman/ytdlp-gui#contribution)

# Voorbeeld
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Installatie
## Linux

### NixOS (Flake)
je kunt de flake.nix in de repo gebruiken

in jouw `flake.nix`:
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

dan kun je het toevoegen als een normaal pakket, hetzij aan je home-manager of nixosConfiguration

### Fedora
download het rpm-pakket van de releases pagina en installeer het dan met ``sudo dnf localinstall <rpm_package_name>``

### Ubuntu
download het deb-pakket van de releases pagina en installeer het dan met ``sudo apt install ./<deb_package_name>``

### Arch

Beschikbaar in de AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### andere distributies

#### 1- download ``yt-dlp``
ofwel

&nbsp; &nbsp; &nbsp; a- vanuit de repo van je distributie

&nbsp; &nbsp; &nbsp; b- of download de [binary](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp), verplaats deze dan naar je bin-directory en maak hem uitvoerbaar door `chmod +x <bin_file>` uit te voeren

#### 2- download ``ffmpeg`` of ``ffmpeg-free`` uit de repo's van je distributie


#### 3- download de ``ytdlp-gui`` binary van de [releases pagina](https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### download gewoon het zip-bestand van de releases pagina, pak het uit in een submap en start de ``ytdlp-gui.exe``

# Bouwen vanuit broncode
om vanuit broncode te bouwen moet je `cargo` en `rustc` hebben, deze kun je installeren via `rustup` (rust toolchain manager), of vanuit de repo's van je distributie, wat je maar wilt

voer daarna de volgende commando's uit:
```bash
# kloon de repository naar de "ytdlp-gui" map
git clone https://github.com/BKSalman/ytdlp-gui
# ga naar de map
cd ytdlp-gui
# je kunt het project bouwen met dit commando
cargo build
# of bouw het in release mode voor betere prestaties
cargo build -r
```
dan zal de binary te vinden zijn in `<project-root>/target/debug/ytdlp-gui` of `<project-root>/target/release/ytdlp-gui`

en je kunt het direct uitvoeren:
```bash
# vanuit de project root
./target/release/ytdlp-gui
```

of met cargo:
```bash
cargo r
# of voor release mode
cargo r -r
```

# Configuratie

Voor v0.2.2+ slaat de applicatie de configuratie op in de standaard config directory voor het respectievelijke platform/OS in ``<config_dir>/ytdlp-gui/config.toml``

het standaard bestand ziet er zo uit:

```toml
# Optioneel
# Dit is de directory van de bin, niet de bin zelf
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) als dit niet is ingesteld wordt het commando `yt-dlp <app_args>`

# Optioneel
download_folder = "<some_cool_path>" # standaard = "~/Videos"

[options]
video_resolution = "FullHD" # opties: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # opties: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # opties: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  opties: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Let op: de kwaliteit/format opties worden automatisch opgeslagen bij het indrukken van de downloadknop

# Bijdragen
Alle vormen van bijdragen worden verwelkomd, of het nu Pull requests, Issues (bugrapporten/verbeteringsverzoeken) zijn

Echter ben ik mogelijk niet snel met reageren of het implementeren van de gevraagde zaken, omdat ik me op andere dingen focus

Maar ik zal mijn best doen 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---