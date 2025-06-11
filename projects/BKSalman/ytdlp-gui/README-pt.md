# ytdlp-gui
uma GUI para yt-dlp escrita em Rust

- [Instalação](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [outras distribuições](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Compilar a partir do código fonte](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Configuração](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Contribuição](https://github.com/BKSalman/ytdlp-gui#contribution)

# Preview
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Instalação
## Linux

### NixOS (Flake)
você pode usar o flake.nix no repositório

no seu `flake.nix`:
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

depois você pode adicioná-lo como um pacote normal, seja no seu home-manager ou na configuração do nixos

### Fedora
baixe o pacote rpm da página de releases e depois instale com ``sudo dnf localinstall <nome_do_pacote_rpm>``

### Ubuntu
baixe o pacote deb da página de releases e depois instale com ``sudo apt install ./<nome_do_pacote_deb>``

### Arch

Disponível no AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### outras distribuições

#### 1- baixe o ``yt-dlp``
ou

&nbsp; &nbsp; &nbsp; a- do repositório da sua distribuição

&nbsp; &nbsp; &nbsp; b- ou baixe o [binário](https://raw.githubusercontent.com/yt-dlp/yt-dlp/main/releases/latest/download/yt-dlp), depois mova para seu diretório bin e torne-o executável com `chmod +x <arquivo_bin>`

#### 2- baixe o ``ffmpeg`` ou ``ffmpeg-free`` dos repositórios da sua distribuição


#### 3- baixe o binário do ``ytdlp-gui`` da [página de releases](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/releases)

## Windows
##### basta baixar o arquivo zip da página de releases, extrair em uma subpasta e iniciar o ``ytdlp-gui.exe``

# Compilar a partir do código fonte
para compilar a partir do código fonte você precisa ter `cargo` e `rustc`, pode instalá-los via `rustup` (gerenciador da toolchain Rust), ou pelos repositórios da sua distribuição, como preferir

depois execute os seguintes comandos:
```bash
# clone o repositório na pasta "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# entre na pasta
cd ytdlp-gui
# você pode compilar o projeto com este comando
cargo build
# ou compilar em modo release para melhor desempenho
cargo build -r
```
então o binário estará em `<raiz-do-projeto>/target/debug/ytdlp-gui` ou `<raiz-do-projeto>/target/release/ytdlp-gui`

e você pode executá-lo diretamente:
```bash
# da raiz do projeto
./target/release/ytdlp-gui
```

ou usando cargo:
```bash
cargo r
# ou para modo release
cargo r -r
```

# Configuração

Para a versão v0.2.2+ o aplicativo salva a configuração no diretório padrão de configuração da plataforma/OS em ``<config_dir>/ytdlp-gui/config.toml``

o arquivo padrão fica assim:

```toml
# Opcional
# Este é o diretório do binário, não o binário em si
# bin_path = "<algum_caminho_legal>" # (0.2.4)

bin_dir = "<algum_caminho_legal>" # (0.2.5+) se não definido o comando será `yt-dlp <app_args>`

# Opcional
download_folder = "<algum_caminho_legal>" # padrão = "~/Videos"

[options]
video_resolution = "FullHD" # opções: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # opções: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # opções: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  opções: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Nota: as opções de qualidade/formato são salvas automaticamente ao pressionar o botão de download

# Contribuição
Todas as formas de contribuição são bem-vindas, sejam Pull requests, Issues (relatórios de bugs/pedidos de melhorias)

No entanto, posso não ser rápido para responder ou implementar as coisas solicitadas, pois estou focado em outras coisas

Mas farei o meu melhor 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---