# twitch-downloader-gui

Ceci est une interface graphique pour la version en ligne de commande du superbe projet [TwitchDownloader](https://github.com/lay295/TwitchDownloader), uniquement pour Linux.  
J'ai utilisé la bibliothèque [libui-ng](https://github.com/libui-ng/libui-ng) avec quelques [patchs](https://github.com/mohad12211/libui-ng) supplémentaires.  
La bibliothèque est encore en phase alpha avancée, mais c'est un projet prometteur, simple, multiplateforme (macos peut être fait, mais je m'en soucie peu) et très intuitif.

# Aperçu

![preview](https://user-images.githubusercontent.com/51754973/167058990-a574493a-fd44-4f12-be59-185798fb93bf.gif)

# Installation

> [!IMPORTANT]
> **Ceci est juste une interface pour la CLI, vous avez toujours besoin du binaire `TwitchDownloaderCLI`. Par défaut, l'application essaiera de trouver le binaire dans votre `PATH`,  
si vous ne souhaitez pas mettre `TwitchDownloaderCLI` dans votre `PATH`, vous pouvez spécifier le chemin du binaire dans les paramètres. Assurez-vous que `TwitchDownloaderCLI` est exécutable.**

Packages disponibles pour debian, fedora et [AUR](https://aur.archlinux.org/packages/twitch-downloader-gui).

### Dépendances

- ffmpeg (nécessaire pour rendre le chat et les vods)  
- libcurl  
- TwitchDownloaderCLI (voir ci-dessous)

# Compilation

### Dépendances de compilation

- make  
- libcurl (version de développement)  
- gtk3 (version de développement, appelée libgtk-3-dev sur ubuntu)

La bibliothèque statique pour libui est dans le dépôt, mais vous pouvez utiliser votre propre version compilée et simplement la remplacer, instructions [ici](https://github.com/mohad12211/libui-ng/blob/customs/README.md#quick-building-instructions)


```
$ git clone https://github.com/mohad12211/twitch-downloader-gui.git
$ cd twitch-downloader-gui
$ make
$ make install # (if you want to install the app to your system)
$ make uninstall # (to uninstall)
```

binaire se trouve dans `build/bin`

# Inclut-il toutes les fonctionnalités ? des bugs ?

il inclut les fonctionnalités de base, il n'y a pas de file d'attente de tâches.

## Bugs...

- Vous ne pouvez télécharger que la qualité la plus élevée pour le vod (je vais le résoudre bientôt).

Veuillez signaler tout bug.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---