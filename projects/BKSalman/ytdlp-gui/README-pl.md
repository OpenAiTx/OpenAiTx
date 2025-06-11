# ytdlp-gui
GUI dla yt-dlp napisane w Rust

- [Instalacja](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [inne dystrybucje](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Budowanie ze źródła](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Konfiguracja](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Wkład w projekt](https://github.com/BKSalman/ytdlp-gui#contribution)

# Podgląd
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Instalacja
## Linux

### NixOS (Flake)
możesz użyć pliku flake.nix z repozytorium

w swoim `flake.nix`:
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

następnie możesz dodać go jako normalny pakiet, do swojego home-manager lub konfiguracji nixosConfiguration

### Fedora
pobierz pakiet rpm ze strony z wydaniami, następnie zainstaluj go poleceniem ``sudo dnf localinstall <nazwa_pakietu_rpm>``

### Ubuntu
pobierz pakiet deb ze strony z wydaniami, następnie zainstaluj go poleceniem ``sudo apt install ./<nazwa_pakietu_deb>``

### Arch

Dostępne w AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### inne dystrybucje

#### 1- pobierz ``yt-dlp``
albo

&nbsp; &nbsp; &nbsp; a- z repozytorium Twojej dystrybucji

&nbsp; &nbsp; &nbsp; b- lub pobierz [binarkę](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp), następnie przenieś ją do katalogu bin i nadaj uprawnienia wykonywania poleceniem `chmod +x <plik_bin>`

#### 2- pobierz ``ffmpeg`` lub ``ffmpeg-free`` z repozytoriów Twojej dystrybucji


#### 3- pobierz binarkę ``ytdlp-gui`` ze [strony wydań](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### po prostu pobierz plik zip ze strony wydań, rozpakuj go w podfolderze i uruchom ``ytdlp-gui.exe``

# Budowanie ze źródła
Aby zbudować ze źródła potrzebujesz `cargo` i `rustc`, możesz je zainstalować przez `rustup` (menadżer toolchain Rust), lub z repozytoriów swojej dystrybucji, jak wolisz

następnie uruchom poniższe polecenia:
```bash
# sklonuj repozytorium do folderu "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# przejdź do folderu
cd ytdlp-gui
# możesz zbudować projekt używając tego polecenia
cargo build
# lub zbudować w trybie release dla lepszej wydajności
cargo build -r
```
binarka będzie w katalogu `<root_projektu>/target/debug/ytdlp-gui` lub `<root_projektu>/target/release/ytdlp-gui`

możesz ją uruchomić bezpośrednio:
```bash
# z katalogu głównego projektu
./target/release/ytdlp-gui
```

lub użyć cargo:
```bash
cargo r
# lub w trybie release
cargo r -r
```

# Konfiguracja

Dla wersji v0.2.2+ aplikacja zapisuje konfigurację w domyślnym katalogu konfiguracyjnym dla danej platformy/OS w ``<config_dir>/ytdlp-gui/config.toml``

domyślny plik wygląda tak:

```toml
# Opcjonalne
# To jest katalog bin, a nie sam bin
# bin_path = "<jakas_sciezka>" # (0.2.4)

bin_dir = "<jakas_sciezka>" # (0.2.5+) jeśli nie ustawione, polecenie będzie `yt-dlp <app_args>`

# Opcjonalne
download_folder = "<jakas_sciezka>" # domyślnie = "~/Videos"

[options]
video_resolution = "FullHD" # opcje: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # opcje: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # opcje: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  opcje: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Uwaga: opcje jakości/formatu są automatycznie zapisywane po naciśnięciu przycisku pobierania

# Wkład w projekt
Wszelkie formy wkładu są mile widziane, czy to Pull requesty, Issues (zgłoszenia błędów/prośby o usprawnienia)

Jednak mogę nie być szybki w odpowiadaniu na nie lub wdrażaniu żądanych funkcji, ponieważ skupiam się na innych rzeczach

Ale zrobię co w mojej mocy 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---