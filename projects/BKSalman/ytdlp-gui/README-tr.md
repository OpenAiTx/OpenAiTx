# ytdlp-gui
Rust ile yazılmış yt-dlp için bir GUI

- [Kurulum](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [diğer dağıtımlar](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Kaynak koddan derleme](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Yapılandırma](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Katkı](https://github.com/BKSalman/ytdlp-gui#contribution)

# Önizleme
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Kurulum
## Linux

### NixOS (Flake)
depolardaki flake.nix dosyasını kullanabilirsiniz

kendi `flake.nix` dosyanızda:
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

daha sonra bunu normal bir paket olarak home-manager veya nixosConfiguration içine ekleyebilirsiniz

### Fedora
rpm paketini [releases sayfasından](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/releases) indirip ``sudo dnf localinstall <rpm_paket_ismi>`` ile kurun

### Ubuntu
deb paketini [releases sayfasından](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/releases) indirip ``sudo apt install ./<deb_paket_ismi>`` ile kurun

### Arch

AUR'da mevcut: [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### diğer dağıtımlar

#### 1- ``yt-dlp`` indirin
ya

&nbsp; &nbsp; &nbsp; a- dağıtımınızın deposundan

&nbsp; &nbsp; &nbsp; b- veya [ikili dosyayı](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp) indirip, bin dizininize taşıyın ve `chmod +x <bin_dosyası>` komutuyla çalıştırılabilir yapın

#### 2- dağıtımınızın depolarından ``ffmpeg`` veya ``ffmpeg-free`` paketini indirin


#### 3- ``ytdlp-gui`` ikili dosyasını [releases sayfasından](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/releases) indirin

## Windows
##### sadece zip dosyasını [releases sayfasından](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/releases) indirip bir alt klasöre çıkarın ve ``ytdlp-gui.exe`` dosyasını başlatın

# Kaynak koddan derleme
kaynak koddan derlemek için `cargo` ve `rustc` araçlarına ihtiyacınız var, bunları `rustup` (rust araç zinciri yöneticisi) veya dağıtımınızın depolarından kurabilirsiniz

sonrasında şu komutları çalıştırın:
```bash
# repoyu "ytdlp-gui" klasörüne klonlayın
git clone https://github.com/BKSalman/ytdlp-gui
# klasöre girin
cd ytdlp-gui
# projeyi derleyebilirsiniz
cargo build
# veya daha iyi performans için release modunda derleyin
cargo build -r
```
binary dosya ya `<proje-kökü>/target/debug/ytdlp-gui` ya da `<proje-kökü>/target/release/ytdlp-gui` konumunda olur

ve doğrudan çalıştırabilirsiniz:
```bash
# proje kökünden
./target/release/ytdlp-gui
```

veya cargo ile:
```bash
cargo r
# ya da release modu için
cargo r -r
```

# Yapılandırma

v0.2.2+ sürümler için uygulama yapılandırmayı ilgili platform/işletim sistemi için varsayılan yapılandırma dizininde ``<config_dir>/ytdlp-gui/config.toml`` dosyasında saklar

varsayılan dosya şöyle görünür:

```toml
# Opsiyonel
# Bu, bin dosyasının kendisi değil, bulunduğu dizindir
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) ayarlanmazsa komut `yt-dlp <app_args>` olur

# Opsiyonel
download_folder = "<some_cool_path>" # varsayılan = "~/Videos"

[options]
video_resolution = "FullHD" # seçenekler: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # seçenekler: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # seçenekler: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  seçenekler: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Not: kalite/format seçenekleri indirme butonuna basıldığında otomatik olarak kaydedilir

# Katkı
Her türlü katkı şekli memnuniyetle karşılanır, ister Pull request, ister Issues (hata raporu/geliştirme isteği) olsun

Ancak yanıt vermem veya istenen özellikleri uygulamam biraz gecikebilir, çünkü başka konulara odaklanıyorum

Ama elimden gelenin en iyisini yapacağım 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---