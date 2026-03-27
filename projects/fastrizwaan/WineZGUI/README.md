# WineZGUI

#### Wine GUI using Zenity - Play and Share!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## What is WineZGUI

WineZGUI (pronounced Wine-Zee-Goo-Eee) is a wine frontend for playing windows games with wine easily. It is a collection of Bash scripts for Wine Prefix Management and Linux Desktop Integration for easier wine gaming experience using Zenity. It allows quick launching of Direct play (not installed) EXE application or game from File Manager like Nautilus and allow creating separate wine prefix for each Windows' EXE binary.

## Why WineZGUI?

1. Runs windows games or exe files from file manager
2. Creates application shortcut for easier access.
3. Focus on playing games and not setting up prefixes.
4. Backup and Restore prefixes for later use.
5. Create Game Bundles for sharing (prefix+game)

## How it works

1. When a windows binary or exe is opened with WineZGUI, 
2. It create a new prefix (copies template) and a desktop shortcut with the EXE filename.
3. When the user launches the script, the exe is launched. 
4. If it is a setup, it will detect installed exe and creates shortcuts in Games menu category.

## How to run a Game or Program on another drive or directory

Open your Terminal and type this:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### Install WineZGUI

WineZGUI is available as a Flatpak on Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI can only access Desktop, Documents, Downloads, Music, Pictures, Videos direcotories. To access files from other locations or other mounted partitions or drives, either copy them to the previously mentioned directories (Downloads etc.) or it needs read permission, which can be given using Flatseal app or using command line  `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

I highly recommend using flatpak version, because, distro based wine (wine-staging) keeps on updating and games may break every few days. Using wine stable from flathub is better or use wine stable 5.0 or 7.0 from the distro packages.

#### Install WineZGUI flatpak on [supported Linux distros](https://flatpak.org/setup/)

WineZGUI is packaged in flatpak-wine by yours truly. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) my other flatpak now deprecated [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine) 

### SETUP on a Linux system, see [Requirements](https://github.com/fastrizwaan/WineZGUI#requirements)

Setup is instant as it copies a few files to specific directories.

##### Version 0.99.13

Downoad source [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) or use `git tag 0.99.13`

##### Using tar.gz

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

##### Development version

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Uninstall WineZGUI

##### Flatpak uninstall

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### System  uninstall

Run `uninstall` from the same installation source directory

```
sudo ./setup --uninstall
```

## Requirements

`wine` - main program

`winetricks` - must have wine addon script

`perl‑image‑exiftool` - to extract application/game name

`icoutils` - to extract icon from exe file

`gnome-terminal` - (optional) to access prefix directory in shell

## Install Requirements for Linux OS

### Flatpak Supported Distros

Get [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) which includes all dependencies. Useful for distros who do not package wine.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Runtime Dependencies:

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

#### XBOX compatible controllers

build and install kernel drivers for xbox 360 compatible controllers from https://github.com/paroj/xpad
