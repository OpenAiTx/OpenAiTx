# ytdlp-gui
una interfaz gráfica para yt-dlp escrita en Rust

- [Instalación](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [otras distribuciones](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Construir desde el código fuente](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Configuración](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Contribución](https://github.com/BKSalman/ytdlp-gui#contribution)

# Vista previa
![imagen](https://github.com/user-attachments/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Instalación
## Linux

### NixOS (Flake)
puedes usar el flake.nix en el repositorio

en tu `flake.nix`:
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

luego puedes añadirlo como un paquete normal, ya sea a tu home-manager o nixosConfiguration

### Fedora
descarga el paquete rpm desde la página de lanzamientos y luego instálalo con ``sudo dnf localinstall <rpm_package_name>``

### Ubuntu
descarga el paquete deb desde la página de lanzamientos y luego instálalo con ``sudo apt install ./<deb_package_name>``

### Arch

Disponible en el AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### otras distribuciones

#### 1- descarga ``yt-dlp``
puedes

&nbsp; &nbsp; &nbsp; a- desde el repositorio de tu distribución

&nbsp; &nbsp; &nbsp; b- o descargar el [binario](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp), luego muévelo a tu directorio bin, y hazlo ejecutable ejecutando `chmod +x <bin_file>`

#### 2- descarga ``ffmpeg`` o ``ffmpeg-free`` desde los repositorios de tu distribución


#### 3- descarga el binario de ``ytdlp-gui`` desde la [página de lanzamientos](https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### simplemente descarga el archivo zip desde la página de lanzamientos, extráelo en una subcarpeta y ejecuta ``ytdlp-gui.exe``

# Construir desde el código fuente
para construir desde el código fuente necesitas tener `cargo` y `rustc`, puedes instalarlos a través de `rustup` (gestor de la herramienta Rust), o desde los repositorios de tu distribución, como prefieras

después ejecuta los siguientes comandos:
```bash
# clona el repositorio en la carpeta "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# entra en la carpeta
cd ytdlp-gui
# puedes construir el proyecto usando esto
cargo build
# o construirlo en modo release para mejor rendimiento
cargo build -r
```
luego el binario estará en `<project-root>/target/debug/ytdlp-gui` o `<project-root>/target/release/ytdlp-gui`

y puedes ejecutarlo directamente:
```bash
# desde la raíz del proyecto
./target/release/ytdlp-gui
```

o usando cargo:
```bash
cargo r
# o para modo release
cargo r -r
```

# Configuración

Para la versión v0.2.2+ la aplicación guarda la configuración en el directorio de configuración predeterminado para la plataforma/SO respectivo en ``<config_dir>/ytdlp-gui/config.toml``

el archivo por defecto se ve así:

```toml
# Opcional
# Este es el directorio del binario, no el binario en sí
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) si no está configurado el comando será `yt-dlp <app_args>`

# Opcional
download_folder = "<some_cool_path>" # por defecto = "~/Videos"

[options]
video_resolution = "FullHD" # opciones: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # opciones: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # opciones: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  opciones: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Nota: las opciones de calidad/formato se guardan automáticamente al presionar el botón de descarga

# Contribución
Todas las formas de contribución son bienvenidas, ya sean Pull requests, Issues (reportes de errores/solicitudes de mejora)

Sin embargo, puede que no responda rápidamente o implemente lo solicitado, ya que estoy enfocado en otras cosas

Pero haré lo mejor posible 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---