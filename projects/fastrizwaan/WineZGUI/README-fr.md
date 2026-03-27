# WineZGUI

#### Interface graphique Wine utilisant Zenity - Jouez et partagez !

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Télécharger sur Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Qu'est-ce que WineZGUI

WineZGUI (prononcé Wine-Zee-Goo-Eee) est une interface graphique pour Wine permettant de jouer facilement à des jeux Windows avec Wine. C’est une collection de scripts Bash pour la gestion des préfixes Wine et l’intégration au bureau Linux pour une expérience de jeu sous Wine simplifiée utilisant Zenity. Il permet de lancer rapidement une application ou un jeu EXE en mode Direct play (non installé) depuis un gestionnaire de fichiers comme Nautilus et de créer un préfixe Wine séparé pour chaque binaire EXE Windows.

## Pourquoi WineZGUI ?

1. Lance des jeux Windows ou fichiers exe depuis le gestionnaire de fichiers  
2. Crée un raccourci d’application pour un accès plus facile.  
3. Se concentre sur le jeu et non sur la configuration des préfixes.  
4. Sauvegarde et restaure les préfixes pour une utilisation ultérieure.  
5. Crée des bundles de jeux pour le partage (préfixe + jeu)  

## Comment ça marche

1. Lorsqu’un binaire Windows ou exe est ouvert avec WineZGUI,  
2. Il crée un nouveau préfixe (copie le modèle) et un raccourci bureau avec le nom du fichier EXE.  
3. Lorsque l’utilisateur lance le script, l’exe est lancé.  
4. Si c’est un installateur, il détecte l’exe installé et crée des raccourcis dans la catégorie Jeux du menu.  

## Comment lancer un jeu ou un programme sur un autre disque ou répertoire

Ouvrez votre terminal et tapez ceci :

`flatpak override --user --filesystem=/chemin/vers/votre/disque io.github.fastrizwaan.WineZGUI`

### Installer WineZGUI

WineZGUI est disponible en Flatpak sur Flathub :

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Télécharger sur Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI ne peut accéder qu'aux répertoires Desktop, Documents, Downloads, Music, Pictures, Videos. Pour accéder aux fichiers d'autres emplacements ou d'autres partitions ou disques montés, copiez-les dans les répertoires mentionnés précédemment (Downloads, etc.) ou il faut une permission de lecture, qui peut être accordée via l'application Flatseal ou en utilisant la ligne de commande `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Je recommande vivement d'utiliser la version flatpak, car le wine basé sur la distribution (wine-staging) est constamment mis à jour et les jeux peuvent planter tous les quelques jours. Utiliser wine stable depuis flathub est préférable ou utiliser wine stable 5.0 ou 7.0 depuis les paquets de la distribution.

#### Installer WineZGUI flatpak sur [distros Linux supportées](https://flatpak.org/setup/)

WineZGUI est empaqueté dans flatpak-wine par ma modeste personne. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) mon autre flatpak maintenant déprécié [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### CONFIGURATION sur un système Linux, voir [Exigences](https://github.com/fastrizwaan/WineZGUI#requirements)

La configuration est instantanée car elle copie quelques fichiers dans des répertoires spécifiques.

##### Version 0.99.13

Télécharger la source [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) ou utiliser `git tag 0.99.13`

##### Utilisation de tar.gz

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
##### Version de développement


```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Désinstaller WineZGUI

##### Désinstallation Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Désinstallation du système

Exécutez `uninstall` depuis le même répertoire source d'installation

```
sudo ./setup --uninstall
```

## Exigences

`wine` - programme principal

`winetricks` - script addon indispensable pour wine

`perl‑image‑exiftool` - pour extraire le nom de l'application/jeu

`icoutils` - pour extraire l'icône du fichier exe

`gnome-terminal` - (optionnel) pour accéder au répertoire du préfixe dans le shell

## Installer les exigences pour Linux OS

### Distributions supportant Flatpak

Obtenez [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) qui inclut toutes les dépendances. Utile pour les distributions qui ne packagent pas wine.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Dépendances d'exécution :

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

#### Manettes compatibles XBOX

construire et installer les pilotes du noyau pour les manettes compatibles xbox 360 depuis https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---