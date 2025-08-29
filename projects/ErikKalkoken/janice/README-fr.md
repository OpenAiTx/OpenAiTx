# Janice

Une application de bureau pour visualiser de grands fichiers JSON.

[![GitHub Release](https://img.shields.io/github/v/release/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![Fyne](https://img.shields.io/badge/dynamic/regex?url=https%3A%2F%2Fgithub.com%2FErikKalkoken%2Fjanice%2Fblob%2Fmain%2Fgo.mod&search=fyne%5C.io%5C%2Ffyne%5C%2Fv2%20(v%5Cd*%5C.%5Cd*%5C.%5Cd*)&replace=%241&label=Fyne&cacheSeconds=https%3A%2F%2Fgithub.com%2Ffyne-io%2Ffyne)](https://github.com/fyne-io/fyne)
[![build status](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml/badge.svg)](https://github.com/ErikKalkoken/janice/actions/workflows/ci-cd.yml)
[![codecov](https://codecov.io/gh/ErikKalkoken/janice/graph/badge.svg?token=nei6PLRXrD)](https://codecov.io/gh/ErikKalkoken/janice)
[![GitHub License](https://img.shields.io/github/license/ErikKalkoken/janice)](https://github.com/ErikKalkoken/janice)
[![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/ErikKalkoken/janice/total)](https://github.com/ErikKalkoken/janice/releases)

[![download](https://github.com/user-attachments/assets/c8de336f-8c42-4501-86bb-dbc9c66db1f0)](https://github.com/ErikKalkoken/janice/releases/latest)

## Contenu

- [Description](#description)
- [Captures d'écran](#screenshots)
- [Comment exécuter](#how-to-run)
- [FAQ](#faq)
- [Attributions](#attributions)

## Description

Janice est une application de bureau pour visualiser de grands fichiers JSON. Ses fonctionnalités clés sont :

- Parcourir un document JSON sous forme d'arborescence classique
- Les fichiers JSON peuvent être ouverts via une boîte de dialogue, depuis le presse-papiers, déposés sur la fenêtre ou passés en argument de ligne de commande
- Prise en charge de la visualisation de très grands fichiers JSON (>100 Mo, >10M d'éléments)
- Recherche de clés et valeurs dans le document. Prise en charge des caractères génériques.
- Exporter des parties d'un fichier JSON vers un nouveau fichier ou vers le presse-papiers
- Copier les valeurs dans le presse-papiers
- Fichier exécutable unique, aucune installation requise
- Application de bureau fonctionnant sous Windows, Linux et macOS
- Thème sombre et clair automatique

## Captures d'écran

### Thème clair

![light](https://cdn.imgpile.com/f/0IrYBjJ_xl.png)

### Thème sombre

![dark](https://cdn.imgpile.com/f/bdQBc3q_xl.png)

## Comment exécuter

Pour exécuter Janice, téléchargez simplement la dernière version et décompressez-la sur votre ordinateur. Janice est livré sous forme d’un fichier exécutable unique pouvant être lancé directement. Vous trouverez les derniers paquets à télécharger sur la [page des releases](https://github.com/ErikKalkoken/janice/releases).

### Linux

Nous proposons deux variantes pour l’installation sur bureau Linux :

- AppImage : La variante AppImage vous permet d’exécuter l’application directement depuis l’exécutable sans nécessiter d’installation ni de droits root.
- Tarball : Le fichier tar nécessite une installation, mais permet aussi d’intégrer l’application à votre environnement de bureau. Le tarball offre également une compatibilité plus large avec différentes versions de Linux.

#### AppImage

> [!NOTE]
> L’application est distribuée au format [AppImage](https://appimage.org/), ce qui permet de l’utiliser sans installation et de la lancer sur de nombreuses distributions Linux différentes.

1. Téléchargez le dernier fichier AppImage depuis la page des releases et rendez-le exécutable.
1. Exécutez-le pour démarrer l’application.

> [!TIP]
> Si vous obtenez l’erreur suivante : `AppImages require FUSE to run.`, vous devez d’abord installer FUSE sur votre système. Il s’agit d’une bibliothèque requise par toutes les AppImages pour fonctionner. Consultez [cette page](https://docs.appimage.org/user-guide/troubleshooting/fuse.html#the-appimage-tells-me-it-needs-fuse-to-run) pour plus de détails.

#### Tarball

1. Téléchargez le dernier fichier tar depuis la page des releases
1. Décompressez le fichier tar, par exemple avec : `tar xf janice-0.12.3-linux-amd64.tar.xz`
1. Lancez `make user-install` pour installer l’application pour l’utilisateur courant ou `sudo make install` pour installer l’application sur le système

Vous devriez maintenant avoir un raccourci dans le lanceur de votre environnement de bureau pour démarrer l’application.

Pour désinstaller l’application, exécutez soit : `make user-uninstall` soit `sudo make uninstall` selon la méthode d’installation.

### Windows

1. Téléchargez le fichier zip Windows depuis la dernière release sur Github.
1. Décompressez le fichier dans un répertoire de votre choix et lancez le fichier .exe pour démarrer l'application.

### Mac OS

1. Téléchargez le fichier zip darwin depuis la dernière version sur Github pour votre plateforme respective (arm ou intel).
1. Décompressez le fichier dans un répertoire de votre choix
1. Lancez le fichier .app pour démarrer l'application.

> [!TIP]
> MacOS peut signaler incorrectement cette application comme "endommagée", car elle n'est pas signée avec un certificat Apple. Vous pouvez supprimer cette erreur en ouvrant un terminal et en exécutant la commande suivante. Pour plus d'informations, veuillez consulter [Fyne Troubleshooting](https://docs.fyne.io/faq/troubleshoot#distribution) :
>
> ```sudo xattr -r -d com.apple.quarantine Janice.app```

### Construire et exécuter depuis le dépôt

Si votre système est configuré pour construire des applications [Fyne](https://fyne.io/), vous pouvez construire et exécuter cette application directement depuis le dépôt avec la commande suivante :

```sh
go run github.com/ErikKalkoken/janice@latest
```

Pour plus d'informations sur la configuration de votre système pour Fyne, veuillez consulter : [Prise en main](https://docs.fyne.io/started/).

## FAQ

### Quelle est la plus grande taille de fichier JSON que je peux charger ?

La taille maximale du fichier JSON que vous pouvez charger sur votre ordinateur dépend principalement de la quantité de RAM dont vous disposez et du fichier JSON en question. Le principal facteur de consommation mémoire est le nombre d'éléments dans un document JSON.

Pour comparaison, nous avons réalisé un test de chargement sur l'un de nos ordinateurs portables de développeur. Il dispose de 8 Go de RAM et fonctionne sous Ubuntu 22.04 LTS. Nous avons pu charger avec succès des fichiers JSON contenant jusqu'à 45 millions d'éléments. La taille de notre fichier de test était d'environ 2,5 Go.

### Les fichiers JSON sont-ils formatés ?

Oui. Le document JSON est rendu sous forme d'arbre et les clés sont affichées par ordre alphabétique.

## Attributions

- [Icônes Json créées par LAB Design Studio - Flaticon](https://www.flaticon.com/free-icons/json)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---