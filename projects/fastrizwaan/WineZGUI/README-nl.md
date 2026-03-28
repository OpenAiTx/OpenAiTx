
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">Vereenvoudigd Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">Traditioneel Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">Assamees</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Wine GUI met Zenity - Speel en Deel!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download op Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Wat is WineZGUI

WineZGUI (uitgesproken als Wine-Zee-Goo-Eee) is een Wine-frontend om eenvoudig Windows-games met Wine te spelen. Het is een verzameling Bash-scripts voor Wine Prefix Management en Linux Desktop-integratie voor een gemakkelijkere Wine-game-ervaring met behulp van Zenity. Het maakt het mogelijk om Direct Play (niet geïnstalleerde) EXE-applicaties of -games snel te starten vanuit een bestandsbeheerder zoals Nautilus en laat toe om een aparte Wine-prefix aan te maken voor elk Windows EXE-bestand.

## Waarom WineZGUI?

1. Voert Windows-games of exe-bestanden uit vanuit de bestandsbeheerder
2. Maakt snelkoppelingen voor eenvoudigere toegang.
3. Focus op het spelen van games en niet op het instellen van prefixes.
4. Back-up en herstel van prefixes voor later gebruik.
5. Maak Game Bundles om te delen (prefix+game)

## Hoe het werkt

1. Wanneer een Windows-binary of exe wordt geopend met WineZGUI,
2. Wordt er een nieuwe prefix aangemaakt (kopieert sjabloon) en een bureaubladsnelkoppeling gemaakt met de EXE-filename.
3. Wanneer de gebruiker het script start, wordt de exe gestart.
4. Als het een setup is, detecteert het de geïnstalleerde exe en maakt snelkoppelingen in het Games-menu aan.

## Hoe een Game of Programma uitvoeren op een andere schijf of directory

Open je Terminal en typ het volgende:

`flatpak override --user --filesystem=/pad/naar/je/schijf io.github.fastrizwaan.WineZGUI`

### WineZGUI installeren

WineZGUI is beschikbaar als Flatpak op Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download op Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI heeft alleen toegang tot de mappen Desktop, Documenten, Downloads, Muziek, Afbeeldingen, Video's. Om bestanden van andere locaties of andere aangekoppelde partities of schijven te benaderen, kopieer ze naar eerdergenoemde mappen (Downloads etc.) of geef leesrechten via de Flatseal-app of via de command line `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Ik raad sterk aan om de flatpak-versie te gebruiken, omdat distro-gebaseerde wine (wine-staging) voortdurend wordt bijgewerkt en games daardoor elke paar dagen kunnen breken. Het gebruik van wine stable van Flathub is beter, of gebruik wine stable 5.0 of 7.0 uit de distro-pakketten.

#### Installeer WineZGUI flatpak op [ondersteunde Linux-distro’s](https://flatpak.org/setup/)

WineZGUI is verpakt in flatpak-wine door ondergetekende. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) mijn andere flatpak nu verouderd [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### INSTALLATIE op een Linux-systeem, zie [Vereisten](https://github.com/fastrizwaan/WineZGUI#requirements)

Installatie is direct, aangezien er enkele bestanden naar specifieke mappen worden gekopieerd.

##### Versie 0.99.13

Download de broncode [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) of gebruik `git tag 0.99.13`

##### Gebruik van tar.gz

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

##### Ontwikkelingsversie

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### WineZGUI verwijderen

##### Flatpak deïnstalleren

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Systeem deïnstalleren

Voer `uninstall` uit vanuit dezelfde installatiemap

```
sudo ./setup --uninstall
```

## Vereisten

`wine` - hoofdprogramma

`winetricks` - verplichte wine-addon script

`perl‑image‑exiftool` - om applicatie-/spelnaam te extraheren

`icoutils` - om icoon uit exe-bestand te extraheren

`gnome-terminal` - (optioneel) om toegang te krijgen tot prefix-directory in shell

## Installeer vereisten voor Linux OS

### Flatpak-ondersteunde distributies

Haal [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) die alle afhankelijkheden bevat. Handig voor distributies die wine niet verpakken.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Runtime-afhankelijkheden:

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

#### XBOX compatibele controllers

bouw en installeer kernel drivers voor xbox 360 compatibele controllers van https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---