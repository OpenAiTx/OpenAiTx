# ytdlp-gui
GUI untuk yt-dlp yang ditulis dalam Rust

- [Instalasi](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [distribusi lain](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Bangun dari sumber](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Konfigurasi](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Kontribusi](https://github.com/BKSalman/ytdlp-gui#contribution)

# Pratinjau
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Instalasi
## Linux

### NixOS (Flake)
Anda dapat menggunakan flake.nix di repo

di `flake.nix` Anda:
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

lalu Anda bisa menambahkannya sebagai paket biasa, baik ke home-manager Anda atau nixosConfiguration

### Fedora
unduh paket rpm dari halaman rilis lalu instal dengan ``sudo dnf localinstall <rpm_package_name>``

### Ubuntu
unduh paket deb dari halaman rilis lalu instal dengan ``sudo apt install ./<deb_package_name>``

### Arch

Tersedia di AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### distribusi lain

#### 1- unduh ``yt-dlp``
baik

&nbsp; &nbsp; &nbsp; a- dari repo distribusi Anda

&nbsp; &nbsp; &nbsp; b- atau unduh [binary](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp), lalu pindahkan ke direktori bin Anda, dan buat executable dengan menjalankan `chmod +x <bin_file>`

#### 2- unduh ``ffmpeg`` atau ``ffmpeg-free`` dari repo distribusi Anda


#### 3- unduh binary ``ytdlp-gui`` dari [halaman rilis](https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### cukup unduh file zip dari halaman rilis, ekstrak di subfolder dan jalankan ``ytdlp-gui.exe``

# Bangun dari sumber
Untuk membangun dari sumber Anda perlu `cargo` dan `rustc`, Anda dapat menginstalnya melalui `rustup` (pengelola toolchain rust), atau dari repo distribusi Anda, terserah yang Anda suka

setelah itu jalankan perintah berikut:
```bash
# clone repositori ke folder "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# masuk ke folder
cd ytdlp-gui
# Anda bisa membangun proyek menggunakan ini
cargo build
# atau membangunnya dalam mode rilis untuk performa lebih baik
cargo build -r
```
lalu binary akan berada di `<project-root>/target/debug/ytdlp-gui` atau `<project-root>/target/release/ytdlp-gui`

dan Anda bisa menjalankannya langsung:
```bash
# dari root proyek
./target/release/ytdlp-gui
```

atau menggunakan cargo:
```bash
cargo r
# atau untuk mode rilis
cargo r -r
```

# Konfigurasi

Untuk v0.2.2+ aplikasi menyimpan konfigurasi di direktori config default untuk platform/OS masing-masing di ``<config_dir>/ytdlp-gui/config.toml``

file defaultnya seperti ini:

```toml
# Opsional
# Ini adalah direktori bin, bukan bin itu sendiri
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) jika tidak diatur perintahnya akan `yt-dlp <app_args>`

# Opsional
download_folder = "<some_cool_path>" # default = "~/Videos"

[options]
video_resolution = "FullHD" # opsi: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # opsi: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # opsi: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  opsi: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Catatan: opsi kualitas/format akan otomatis disimpan saat menekan tombol download

# Kontribusi
Semua bentuk kontribusi disambut, baik Pull request, Issues (laporan bug/permintaan peningkatan)

Namun, saya mungkin tidak cepat membalasnya, atau mengimplementasikan hal yang diminta, karena saya fokus pada hal lain

Tapi saya akan berusaha sebaik mungkin 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---