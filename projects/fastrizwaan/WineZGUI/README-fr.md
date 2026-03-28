
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Interface graphique de Wine utilisant Zenity - Jouez et partagez !

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Télécharger sur Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Qu'est-ce que WineZGUI

WineZGUI (prononcé Wine-Zee-Goo-Eee) est une interface graphique pour Wine permettant de jouer facilement à des jeux Windows avec Wine. Il s'agit d'une collection de scripts Bash pour la gestion des préfixes Wine et l'intégration au bureau Linux, afin de faciliter l'expérience de jeu sous Wine grâce à Zenity. Il permet de lancer rapidement un exécutable Direct Play (non installé) ou un jeu depuis le gestionnaire de fichiers comme Nautilus, et de créer un préfixe Wine séparé pour chaque binaire EXE de Windows.

## Pourquoi WineZGUI ?

1. Exécute les jeux Windows ou les fichiers exe depuis le gestionnaire de fichiers
2. Crée un raccourci d'application pour un accès plus facile.
3. Se concentre sur le jeu et non sur la configuration des préfixes.
4. Sauvegarde et restaure les préfixes pour une utilisation ultérieure.
5. Crée des bundles de jeu à partager (préfixe+jeu)

## Comment ça marche

1. Lorsqu'un binaire Windows ou un exe est ouvert avec WineZGUI,
2. Il crée un nouveau préfixe (copie le modèle) et un raccourci sur le bureau avec le nom du fichier EXE.
3. Lorsque l'utilisateur lance le script, l'exe est lancé.
4. S'il s'agit d'une installation, il détecte l'exe installé et crée des raccourcis dans le menu Jeux.

## Comment exécuter un jeu ou un programme sur un autre disque ou répertoire

Ouvrez votre terminal et tapez ceci :

`flatpak override --user --filesystem=/chemin/vers/votre/lecteur io.github.fastrizwaan.WineZGUI`

### Installer WineZGUI

WineZGUI est disponible sous forme de Flatpak sur Flathub :

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Télécharger sur Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Le WineZGUI de Flathub ne peut accéder qu'aux dossiers Bureau, Documents, Téléchargements, Musique, Images, Vidéos. Pour accéder à des fichiers dans d'autres emplacements ou sur d'autres partitions ou disques montés, copiez-les dans les dossiers mentionnés précédemment (Téléchargements, etc.) ou il faut accorder la permission de lecture, ce qui peut être fait via l'application Flatseal ou avec la commande `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Je recommande fortement d'utiliser la version flatpak, car la version wine des distributions (wine-staging) est fréquemment mise à jour et les jeux peuvent cesser de fonctionner tous les quelques jours. Utiliser wine stable de flathub est préférable ou bien wine stable 5.0 ou 7.0 des paquets de la distribution.

#### Installer WineZGUI flatpak sur les [distributions Linux supportées](https://flatpak.org/setup/)

WineZGUI est empaqueté dans flatpak-wine par mes soins. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) mon autre flatpak désormais obsolète [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### INSTALLATION sur un système Linux, voir [Exigences](https://github.com/fastrizwaan/WineZGUI#requirements)

L'installation est instantanée car elle copie quelques fichiers dans des répertoires spécifiques.

##### Version 0.99.13

Téléchargez la source [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) ou utilisez `git tag 0.99.13`

##### Utilisation du tar.gz

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---