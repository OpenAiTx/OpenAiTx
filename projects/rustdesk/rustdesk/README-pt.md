<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Seu desktop remoto"><br>
  <a href="#raw-steps-to-build">Compilar</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">Estrutura</a> •
  <a href="#snapshot">Captura</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>Precisamos da sua ajuda para traduzir este README, a <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">UI do RustDesk</a> e a <a href="https://github.com/rustdesk/doc.rustdesk.com">Documentação do RustDesk</a> para o seu idioma nativo</b>
</p>

> [!Caution]
> **Aviso de Uso Indevido:** <br>
> Os desenvolvedores do RustDesk não apoiam ou toleram qualquer uso antiético ou ilegal deste software. O uso indevido, como acesso não autorizado, controle ou invasão de privacidade, é estritamente contra nossas diretrizes. Os autores não se responsabilizam por qualquer uso indevido da aplicação.


Converse conosco: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

Mais um software de desktop remoto, escrito em Rust. Funciona imediatamente, sem necessidade de configuração. Você tem controle total sobre seus dados, sem preocupações com segurança. Você pode usar nosso servidor de rendezvous/relay, [configurar o seu próprio](https://rustdesk.com/server), ou [escrever seu próprio servidor de rendezvous/relay](https://github.com/rustdesk/rustdesk-server-demo).

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

O RustDesk aceita contribuições de todos. Veja [CONTRIBUTING.md](docs/CONTRIBUTING.md) para ajuda sobre como começar.

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**DOWNLOAD BINÁRIO**](https://github.com/rustdesk/rustdesk/releases)

[**BUILD NIGHTLY**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## Dependências

As versões desktop usam Flutter ou Sciter (obsoleto) para a GUI, este tutorial é apenas para Sciter, pois é mais fácil e amigável para começar. Consulte nosso [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml) para compilar a versão Flutter.

Por favor, faça o download da biblioteca dinâmica do Sciter por conta própria.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## Passos brutos para compilar

- Prepare seu ambiente de desenvolvimento Rust e ambiente de compilação C++

- Instale o [vcpkg](https://github.com/microsoft/vcpkg), e defina a variável de ambiente `VCPKG_ROOT` corretamente

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- execute `cargo run`

## [Compilar](https://rustdesk.com/docs/en/dev/build/)

## Como compilar no Linux

### Ubuntu 18 (Debian 10)

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### openSUSE Tumbleweed

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### Fedora 28 (CentOS 8)

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### Arch (Manjaro)

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### Instalar vcpkg

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### Corrigir libvpx (Para Fedora)

```sh
cd vcpkg/buildtrees/libvpx/src
cd *
./configure
sed -i 's/CFLAGS+=-I/CFLAGS+=-fPIC -I/g' Makefile
sed -i 's/CXXFLAGS+=-I/CXXFLAGS+=-fPIC -I/g' Makefile
make
cp libvpx.a $HOME/vcpkg/installed/x64-linux/lib/
cd
```

### Compilar

```sh
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
source $HOME/.cargo/env
git clone --recurse-submodules https://github.com/rustdesk/rustdesk
cd rustdesk
mkdir -p target/debug
wget https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so
mv libsciter-gtk.so target/debug
VCPKG_ROOT=$HOME/vcpkg cargo run
```

## Como compilar com Docker

Comece clonando o repositório e construindo o container Docker:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

Então, cada vez que você precisar compilar a aplicação, execute o seguinte comando:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

Observe que a primeira compilação pode demorar mais até que as dependências sejam armazenadas em cache; compilações posteriores serão mais rápidas. Além disso, se precisar especificar diferentes argumentos para o comando de compilação, você pode adicioná-los ao final do comando na posição `<OPTIONAL-ARGS>`. Por exemplo, se quiser compilar uma versão otimizada para release, execute o comando acima seguido de `--release`. O executável resultante estará disponível na pasta target do seu sistema e pode ser executado com:

```sh
target/debug/rustdesk
```

Ou, se estiver executando o binário de release:

```sh
target/release/rustdesk
```

Por favor, certifique-se de estar executando esses comandos a partir da raiz do repositório RustDesk, caso contrário, o aplicativo pode não encontrar os recursos necessários. Note também que outros subcomandos do cargo como `install` ou `run` não são atualmente suportados por este método, pois instalariam ou rodariam o programa dentro do container e não no host.

## Estrutura de Arquivos

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: codec de vídeo, configuração, wrapper tcp/udp, protobuf, funções de sistema de arquivos para transferência de arquivos e outras funções utilitárias
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: captura de tela
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: controle de teclado/mouse específico da plataforma
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: implementação de copiar e colar arquivos para Windows, Linux, macOS.
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: UI Sciter obsoleta (deprecated)
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: serviços de áudio/clipboard/entrada/vídeo e conexões de rede
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: inicia uma conexão peer
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: Comunica com o [rustdesk-server](https://github.com/rustdesk/rustdesk-server), aguarda conexão direta remota (TCP hole punching) ou conexão retransmitida
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: código específico de plataforma
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: código Flutter para desktop e mobile
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: JavaScript para o cliente Flutter web

## Capturas de Tela

![Gerenciador de Conexões](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Conectado a um PC com Windows](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![Transferência de Arquivos](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![Túnel TCP](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---