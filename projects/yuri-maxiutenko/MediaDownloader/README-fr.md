Le projet Media Downloader
![Logo de Media Downloader](https://raw.githubusercontent.com/yuri-maxiutenko/MediaDownloader/master/MediaDownloader/Images/icon.png)
====================
Juste une petite interface utilisateur conviviale (C#/WPF, .NET) sur l'excellent utilitaire en ligne de commande de téléchargement vidéo [yt-dlp](https://github.com/yt-dlp/yt-dlp) qui permet de télécharger des vidéos en différentes qualités depuis diverses ressources internet (YouTube, Vimeo, Facebook, vous dites le nom). Le téléchargement de playlists est également pris en charge.

## Fonctionnalités principales

**Media Downloader** est capable de télécharger presque toutes les vidéos de tous les principaux fournisseurs (YouTube, Vimeo, Facebook, etc.). Donnez-lui simplement un lien et voilà ! Les liens vers des playlists fonctionnent aussi.

Actuellement, l'application prend en charge les formats de téléchargement suivants :

* Vidéo de meilleure qualité
* Vidéo MP4 de meilleure qualité
* Meilleure vidéo disponible par lien direct
* Audio seulement

De plus, **Media Downloader** prend en charge l'historique des téléchargements et conserve la liste des dossiers récemment utilisés.

Livré avec un installateur, qui inclut tout le nécessaire : l'application elle-même, [yt-dlp](https://github.com/yt-dlp/yt-dlp) et le convertisseur [FFmpeg](https://ffmpeg.org/).

L'application est installée dans le dossier AppData de l'utilisateur actuel et ne nécessite pas de droits administrateur.

Actuellement, **Media Downloader** est localisé en anglais et en russe. La langue de l'application est automatiquement sélectionnée en fonction de la locale Windows courante.

## Exigences

À partir de la version **2.1**, l'application utilise **[le Runtime Desktop .NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)**. Mais vous ne devriez pas avoir besoin de l'installer, car Media Downloader est fourni comme **[une application autonome](https://devblogs.microsoft.com/dotnet/app-trimming-in-net-5/)**.

De plus, **yt-dlp** nécessite **[le package redistribuable Microsoft Visual C++ 2010 (x86)](https://www.microsoft.com/en-us/download/details.aspx?id=5555)**.

## Captures d'écran

Téléchargement de vidéo en cours :
![Téléchargement de vidéo en cours](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210558.png?raw=true)

Téléchargement de vidéo terminé :
![Téléchargement de vidéo terminé](https://github.com/yuri-maxiutenko/MediaDownloader/blob/master/Screenshots/Annotation%202020-06-29%20210909.png?raw=true)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-21

---