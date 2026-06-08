# configuration mpv

![logo mpv](https://raw.githubusercontent.com/mpv-player/mpv.io/master/source/images/mpv-logo-128.png)

## Vue d'ensemble

**mpv** est un lecteur multimédia libre (au sens liberté et gratuité), open-source et multiplateforme. Il prend en charge
une grande variété de formats de fichiers multimédias, de codecs audio et vidéo, et de types de sous-titres.

Ce dépôt contient mes configurations personnelles de mpv et des scripts que j’utilise et qui sont nettement meilleurs que les configurations par défaut de mpv, VLC, et MPC. Avant d’installer, veuillez prendre le temps de lire ce README en entier car les problèmes courants peuvent être facilement résolus simplement en lisant attentivement.

## Aperçu

[![preview.png](https://i.postimg.cc/8zNHHPHy/preview.png)](https://postimg.cc/VdZnsw2M)

## Installation

### Windows

Voici les étapes pour installer mpv et utiliser mes fichiers de configuration sous Windows :
* Téléchargez la dernière version 64 bits de mpv Windows build par shinchiro depuis [mpv.io/installation](https://mpv.io/installation/) ou directement depuis [ici](https://sourceforge.net/projects/mpv-player-windows/files/) et extrayez-la où vous voulez. Ceci est maintenant votre dossier mpv
* Exécutez `mpv-install.bat`, qui se trouve dans le dossier `installer`, avec les privilèges administrateur en cliquant droit et en sélectionnant Exécuter en tant qu’administrateur
* Téléchargez ce dépôt en fichier ZIP (ou vous pouvez le cloner avec git)
* Créez un dossier nommé `portable_config` (**c’est important**), situé dans le même répertoire que `mpv.exe`
* Extrayez ou copiez le contenu de ce dépôt que vous avez téléchargé dans le dossier `portable_config`
* Pour que certains scripts fonctionnent, vous devez les modifier un peu par rapport à la version publiée :
  * Pour que le script `mpv-gif.lua` fonctionne, il nécessite [FFmpeg](https://ffmpeg.org/) avec libass activé et accessible via le terminal. Consultez les [instructions d’installation](https://github.com/Scheliux/mpv-gif-generator#installation) du dépôt source du script pour plus d’infos.
  * **(Optionnel)** Par défaut, le script `mpv-gif.lua` enregistre les GIF dans `C:/Program Files/mpv/gifs`. Pour modifier cela, ouvrez `gif.conf`, qui se trouve dans le dossier `portable_config/script-opts`, avec un éditeur de texte et spécifiez le `dir`, qui est le répertoire de sortie pour les GIF, selon votre choix. Par exemple `dir="C:/Users/USERNAME/Pictures/mpv-gifs"`.
* **(Optionnel)** Créez votre propre configuration mpv. Vous pouvez le faire en modifiant mes fichiers de configuration et/ou en créant la vôtre depuis zéro ou en modifiant des configurations d’autres personnes. Consultez la section [liens utiles](#useful-links) pour des guides de configuration mpv.
* Vous êtes prêt.

### Linux

Voici les étapes pour installer mpv et utiliser mes fichiers de configuration sous Linux :

* Installez mpv et xclip (interface CLI du presse-papiers) en utilisant le gestionnaire de paquets fourni avec votre distribution Linux. xclip est nécessaire pour que les scripts [copy-time.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/copy-time.lua) et [seek-to.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/seek-to.lua) fonctionnent correctement. Le nom du paquet pour mpv et xclip peut aussi varier selon votre distribution Linux. Ici, je prendrai Arch Linux, qui utilise `pacman` comme gestionnaire de paquets, en exemple
  

  ```
  sudo pacman -S mpv xclip
  ```
  Si vous utilisez, par exemple, Fedora Linux, qui utilise `dnf` comme gestionnaire de paquets, vous pouvez installer mpv et xclip avec la commande suivante à la place.

  ```
  sudo dnf install mpv xclip
  ```
  
  Si vous utilisez d'autres distributions Linux, veuillez consulter la documentation du gestionnaire de paquets de votre distribution Linux pour savoir comment installer les paquets.

* Téléchargez ce dépôt en tant que fichier ZIP (ou vous pouvez le cloner avec git) et extrayez/copiez-le dans votre répertoire de configuration standard mpv qui est `~/.config/mpv`
* Quelques points à souligner :
  * Pour que le script `mpv-gif.lua` fonctionne, il nécessite [FFmpeg](https://ffmpeg.org/) avec libass activé et accessible via le terminal. Consultez les [instructions d'installation](https://github.com/Scheliux/mpv-gif-generator#installation) dans le dépôt source du script pour plus d'informations.
  * **(Optionnel)** Par défaut, le script `mpv-gif.lua` enregistre les GIFs dans `~/Videos/mpv-gifs`. Pour modifier cela, ouvrez `gif.conf`, situé dans le dossier `portable_config/script-opts`, avec un éditeur de texte et spécifiez le `dir`, qui est le répertoire de sortie pour les GIFs, comme vous le souhaitez. Par exemple `dir="~/Videos"`.
* **(Optionnel)** Créez votre propre configuration mpv. Vous pouvez le faire en modifiant mes fichiers de configuration et/ou en créant la vôtre à partir de zéro ou en modifiant les configurations d'autres utilisateurs. Consultez la section [liens utiles](#useful-links) pour des guides de configuration mpv.
* Vous êtes prêt.

## Scripts

Scripts provenant de sources externes :

* audio-visualizer.lua ([source](https://github.com/mfcc64/mpv-scripts#visualizerlua))\
  Visualisation audio variée. Ne fonctionne que si vous ouvrez des fichiers audio.
  
* autoload.lua ([source](https://github.com/mpv-player/mpv/blob/master/TOOLS/lua/autoload.lua))\
  Charge automatiquement les entrées de la playlist avant et après le fichier en cours de lecture, en scannant le répertoire.

* copy-timestamp.lua ([source](https://github.com/linguisticmind/mpv-scripts/tree/master/copy-timestamp))\
  Copie le timecode actuel au format HH:MM:SS.MS dans le presse-papiers. Multiplateforme (Mac, Windows, Linux).

* cycle-commands.lua ([source](https://github.com/CogentRedTester/mpv-scripts#cycle-commands))\
  Parcourt une série de commandes à chaque pression de touche. Chaque itération du cycle peut contenir autant de commandes que souhaité. Les détails de la syntaxe sont en haut du fichier.

* cycle-profile.lua ([source](https://github.com/CogentRedTester/mpv-scripts#cycle-profile))\
  Parcourt une liste de profils envoyés via un message script et affiche la description du profil dans l'OSD. Plus de détails en haut du fichier.

* modernz.lua ([source](https://github.com/Samillion/ModernZ))\
  Un remplacement moderne de l'interface OSC pour MPV qui conserve la fonctionnalité de l'OSC par défaut.

* mpv-gif.lua ([source](https://github.com/Scheliux/mpv-gif-generator))\
  Script pour générer des GIFs à partir de la lecture vidéo. Nécessite FFmpeg avec libass activé. L'exportation des GIFs avec sous-titres ne fonctionne pas correctement pour l'instant.

* playlistmanager.lua ([source](https://github.com/jonniek/mpv-playlistmanager))\
  Permet de voir et d'interagir avec votre playlist de manière intuitive.

* seek-to.lua ([source](https://github.com/dexeonify/mpv-config/blob/main/scripts/seek-to.lua))\
  Seek à un timestamp absolu spécifié via saisie clavier ou collé depuis le presse-papiers.

* sponsorblock-minimal.lua ([source](https://codeberg.org/jouni/mpv_sponsorblock_minimal))\
  Ignore les segments sponsorisés dans les vidéos YouTube.

* thumbfast.lua ([source](https://github.com/po5/thumbfast))\
  Générateur de vignettes à la volée haute performance pour mpv. **Le script n'affiche pas les vignettes lui-même**, il est conçu pour être utilisé avec un script d'interface utilisateur qui appelle thumbfast.

Les fichiers de configuration pour ces scripts se trouvent dans le dossier `script-opts`. J'ai également modifié certaines des touches par défaut de ces scripts. Pour voir mes modifications, consultez les raccourcis clavier des scripts dans `input.conf`.

## Shaders

Les shaders inclus dans le dossier `shaders` :

* ArtCNN_C4F32 ([source](https://github.com/Artoriuz/ArtCNN/blob/main/GLSL/ArtCNN_C4F32.glsl))\
  Utilisé pour la montée en résolution du luma.

* nnedi3-nns128-win8x4 ([source](https://github.com/bjin/mpv-prescalers/tree/master))\
  Utilisé pour la montée en résolution du luma.

Utilisez les shaders selon vos préférences et les capacités de votre système. Pour plus d'informations sur les shaders, consultez les ressources dans la section [liens utiles](#useful-links).

## Liens utiles

* [Tutoriel mpv](https://thewiki.moe/tutorials/mpv/) par The Wiki
* [Guide mpv.conf](https://iamscum.wordpress.com/guides/videoplayback-guide/mpv-conf/) par iamscum
* [Guide de configuration mpv pour regarder des vidéos](https://kokomins.wordpress.com/2019/10/14/mpv-config-guide/) par Kokomins
* [Re-échantillonnage mpv](https://artoriuz.github.io/blog/mpv_upscaling.html) par João Vitor Chrisóstomo

## Liens officiels

* [Page d'accueil mpv](https://mpv.io/)  
* [Wiki mpv](https://github.com/mpv-player/mpv/wiki)
* [FAQ mpv](https://github.com/mpv-player/mpv/wiki/FAQ)
* [Manuel mpv](https://mpv.io/manual/stable/)
* [Scripts utilisateurs mpv](https://github.com/mpv-player/mpv/wiki/User-Scripts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---