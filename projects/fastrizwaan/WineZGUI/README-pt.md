
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Espanhol</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Turco</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Vietnamita</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Indonésio</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Interface gráfica do Wine usando Zenity - Jogue e Compartilhe!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Baixe no Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## O que é WineZGUI

WineZGUI (pronuncia-se Wine-Zee-Goo-Eee) é uma interface para o Wine voltada para jogar jogos do Windows com facilidade no Wine. É um conjunto de scripts Bash para Gerenciamento de Prefixos Wine e Integração com o Desktop Linux, proporcionando uma experiência de jogos no Wine mais fácil utilizando o Zenity. Permite o lançamento rápido de aplicativos ou jogos EXE de execução direta (não instalados) a partir do gerenciador de arquivos como o Nautilus e permite criar um prefixo Wine separado para cada binário EXE do Windows.

## Por que WineZGUI?

1. Executa jogos do Windows ou arquivos exe a partir do gerenciador de arquivos
2. Cria atalho de aplicativo para acesso facilitado.
3. Foca em jogar e não em configurar prefixos.
4. Faz backup e restaura prefixos para uso futuro.
5. Cria pacotes de jogos para compartilhamento (prefixo+jogo)

## Como funciona

1. Quando um binário do Windows ou exe é aberto com o WineZGUI,
2. Ele cria um novo prefixo (copia o modelo) e um atalho na área de trabalho com o nome do EXE.
3. Quando o usuário executa o script, o exe é iniciado.
4. Se for um instalador, detecta o exe instalado e cria atalhos no menu de Jogos.

## Como executar um jogo ou programa em outro drive ou diretório

Abra seu Terminal e digite isto:

`flatpak override --user --filesystem=/caminho/para/seu/drive io.github.fastrizwaan.WineZGUI`

### Instalar WineZGUI

WineZGUI está disponível como Flatpak no Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Baixar no Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


O Flathub WineZGUI só pode acessar os diretórios Desktop, Documents, Downloads, Music, Pictures, Videos. Para acessar arquivos de outros locais ou de outras partições ou drives montados, copie-os para os diretórios citados (Downloads etc.) ou conceda permissão de leitura, que pode ser feita pelo app Flatseal ou pelo comando `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Recomendo fortemente usar a versão flatpak, pois o wine baseado em distro (wine-staging) é atualizado constantemente e jogos podem parar de funcionar a cada poucos dias. Usar o wine estável do flathub é melhor ou use o wine estável 5.0 ou 7.0 dos pacotes da distro.

#### Instale WineZGUI flatpak em [distros Linux suportadas](https://flatpak.org/setup/)

WineZGUI é empacotado no flatpak-wine por mim mesmo. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) meu outro flatpak agora obsoleto [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### CONFIGURAÇÃO em um sistema Linux, veja [Requisitos](https://github.com/fastrizwaan/WineZGUI#requirements)

A configuração é instantânea, pois copia alguns arquivos para diretórios específicos.

##### Versão 0.99.13

Baixe o código-fonte [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) ou use `git tag 0.99.13`

##### Usando tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git tag 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### Versão de desenvolvimento

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Desinstalar o WineZGUI

##### Desinstalação do Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Desinstalação do sistema

Execute `uninstall` a partir do mesmo diretório de origem da instalação

```
sudo ./setup --uninstall
```

## Requisitos

`wine` - programa principal

`winetricks` - script complementar essencial para wine

`perl‑image‑exiftool` - para extrair o nome do aplicativo/jogo

`icoutils` - para extrair ícone do arquivo exe

`gnome-terminal` - (opcional) para acessar o diretório do prefixo no shell

## Instalar Requisitos para Sistemas Operacionais Linux

### Distribuições Suportadas pelo Flatpak

Obtenha o [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) que inclui todas as dependências. Útil para distribuições que não oferecem o wine em seus pacotes.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Dependências de Execução:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### Controladores compatíveis com XBOX

compile e instale os drivers de kernel para controladores compatíveis com xbox 360 de https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---