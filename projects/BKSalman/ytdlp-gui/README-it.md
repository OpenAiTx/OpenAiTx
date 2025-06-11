# ytdlp-gui
un'interfaccia grafica per yt-dlp scritta in Rust

- [Installazione](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [altre distribuzioni](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Compilazione da sorgente](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Configurazione](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Contributi](https://github.com/BKSalman/ytdlp-gui#contribution)

# Anteprima
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Installazione
## Linux

### NixOS (Flake)
puoi usare il flake.nix nel repository

nel tuo `flake.nix`:
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

poi puoi aggiungerlo come un pacchetto normale, sia al tuo home-manager che a nixosConfiguration

### Fedora
scarica il pacchetto rpm dalla pagina delle release e poi installalo con ``sudo dnf localinstall <nome_pacchetto_rpm>``

### Ubuntu
scarica il pacchetto deb dalla pagina delle release e poi installalo con ``sudo apt install ./<nome_pacchetto_deb>``

### Arch

Disponibile nell'AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### altre distribuzioni

#### 1- scarica ``yt-dlp``
oppure

&nbsp; &nbsp; &nbsp; a- dal repository della tua distribuzione

&nbsp; &nbsp; &nbsp; b- oppure scarica il [binario](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp), poi spostalo nella tua directory bin e rendilo eseguibile con il comando `chmod +x <file_binario>`

#### 2- scarica ``ffmpeg`` o ``ffmpeg-free`` dai repository della tua distribuzione


#### 3- scarica il binario di ``ytdlp-gui`` dalla [pagina delle release](https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### basta scaricare il file zip dalla pagina delle release, estrarlo in una sottocartella e avviare ``ytdlp-gui.exe``

# Compilazione da sorgente
per compilare da sorgente è necessario avere `cargo` e `rustc`, puoi installarli tramite `rustup` (gestore toolchain di Rust), oppure dai repository della tua distribuzione, come preferisci

dopodiché esegui i seguenti comandi:
```bash
# clona il repository nella cartella "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# entra nella cartella
cd ytdlp-gui
# puoi compilare il progetto con questo comando
cargo build
# oppure compilarlo in modalità release per prestazioni migliori
cargo build -r
```
il binario sarà quindi in `<cartella-progetto>/target/debug/ytdlp-gui` oppure in `<cartella-progetto>/target/release/ytdlp-gui`

e puoi eseguirlo direttamente:
```bash
# dalla cartella del progetto
./target/release/ytdlp-gui
```

oppure usando cargo:
```bash
cargo r
# oppure in modalità release
cargo r -r
```

# Configurazione

Dalla versione v0.2.2+ l'applicazione salva la configurazione nella cartella di configurazione predefinita per la piattaforma/SO rispettiva in ``<config_dir>/ytdlp-gui/config.toml``

il file di default è così:

```toml
# Opzionale
# Questa è la directory del binario, non il binario stesso
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) se non impostato il comando sarà `yt-dlp <app_args>`

# Opzionale
download_folder = "<some_cool_path>" # default = "~/Videos"

[options]
video_resolution = "FullHD" # opzioni: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # opzioni: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # opzioni: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  opzioni: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Nota: le opzioni di qualità/formato vengono salvate automaticamente premendo il pulsante di download

# Contributi
Tutte le forme di contributo sono benvenute, sia Pull request, Issues (segnalazioni di bug/richieste di miglioramento)

Tuttavia, potrei non rispondere rapidamente o implementare subito quanto richiesto, poiché sto concentrando la mia attenzione su altri progetti

Ma farò del mio meglio 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---