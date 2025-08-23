# SyncClipboard
[![build](https://github.com/Jeric-X/SyncClipboard/actions/workflows/build-entry.yml/badge.svg?branch=master)](https://github.com/Jeric-X/SyncClipboard/actions?query=branch%3Amaster)

中文 | [English](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/README_EN.md)  

<details>
<summary>Table des matières</summary>

- [SyncClipboard](#syncclipboard)
  - [Fonctionnalités](#功能)
  - [Serveur](#服务器)
    - [Serveur indépendant](#独立服务器)
      - [Configuration du serveur](#服务器配置)
      - [Docker](#docker)
      - [Arch Linux](#arch-linux)
    - [Serveur intégré au client](#客户端内置服务器)
    - [Serveur WebDAV](#webdav服务器)
  - [Client](#客户端)
    - [Windows](#windows)
      - [Version portable](#免安装板)
      - [Dépannage](#故常排除)
    - [macOS](#macos)
      - [Installation manuelle](#手动安装)
      - [Dépannage](#故常排除-1)
    - [Linux](#linux)
      - [Installation manuelle](#手动安装-1)
      - [Arch Linux](#arch-linux-1)
      - [Dépannage](#故常排除-2)
    - [Paramètres en ligne de commande du client bureau](#桌面客户端命令行参数)
      - [--shutdown-previous](#--shutdown-previous)
      - [--command-{command-name}](#--command-command-name)
    - [iOS](#ios)
      - [Utiliser les raccourcis](#使用快捷指令)
    - [Android](#android)
      - [Utiliser HTTP Request Shortcuts](#使用http-request-shortcuts)
      - [Utiliser Autox.js](#使用autoxjs)
      - [Utiliser SmsForwarder](#使用smsforwarder)
      - [Utiliser Tasker](#使用tasker)
    - [Description de la configuration du client](#客户端配置说明)
  - [API](#api)
    - [Obtenir/Téléverser le presse-papiers (texte)](#获取上传剪贴板文字)
    - [Obtenir/Téléverser le presse-papiers (image/fichier)](#获取上传剪贴板图片文件)
    - [SyncClipboard.json](#syncclipboardjson)
  - [Dépendances du projet](#项目依赖)

</details>

## Fonctionnalités

- Synchronisation du presse-papiers, supportant texte, images et fichiers. Architecture serveur/client, pouvant utiliser un serveur intégré au client, un serveur déployé indépendamment, ou un service cloud compatible WebDAV comme serveur  
- Optimisation du presse-papiers pour les types d’images, avec les fonctionnalités suivantes :
  - Lors de la copie d’une image depuis n’importe quelle source, possibilité de coller directement le fichier image dans le système de fichiers, et inversement
  - Après avoir copié une image depuis un navigateur, téléchargement en arrière-plan de l’image originale localement, résolvant le problème de copie des images animées depuis le navigateur (la plupart des sites nécessitent une authentification, portée limitée, supporte les images animées bilibili)
  - Lors de la copie depuis le système de fichiers d’images dans des formats récents (webp/heic, etc.), stockage dans le presse-papiers en format gif ou jpg, pour permettre un collage direct dans les zones de texte supportant les images

## Serveur
### Serveur indépendant
[SyncClipboard.Server](https://github.com/Jeric-X/SyncClipboard/releases/) supporte le fonctionnement multiplateforme, dépend de [ASP.NET Core 8.0](https://dotnet.microsoft.com/zh-cn/download/dotnet/8.0), après installation du `runtime ASP.NET Core`, lancez avec la commande suivante
```
dotnet /path/to/SyncClipboard.Server.dll --contentRoot ./
```
Le répertoire de travail doit être le même que le répertoire contenant le dll, avec des droits d'écriture. Pour modifier le répertoire de travail, copiez une version de `appsettings.json` dans le nouveau répertoire et modifiez le chemin après `--contentRoot`  

#### Configuration du serveur
Le serveur est configuré via un fichier `appsettings.json`, sous la forme suivante :
```jsonc
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Kestrel": {
    "Endpoints": {
      "http": {
        "Url": "http://*:5033"
      },
      //"https": {
      //  "Url": "https://*:5033"
      //}
    },
    //"Certificates": {
    //  "Default": {
    //    "Path": "/path/to/pem",
    //    "KeyPath": "/path/to/pem_key"
    //  }
    //}
  },
  "AppSettings": {
    "UserName": "your_username",
    "Password": "your_password"
  }
}
```
Pour activer HTTPS, veuillez décommenter les sections `https` et `Certificates`, puis définir le chemin du certificat HTTPS. Enfin, commentez ou supprimez la section `http` pour désactiver la connexion non sécurisée. Pour activer simultanément HTTP et HTTPS, définissez des numéros de port différents pour les deux `Url`.  
Les méthodes de configuration pour différents types de certificats peuvent être consultées dans la [documentation officielle Microsoft](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/endpoints?view=aspnetcore-8.0#configure-https-in-appsettingsjson)

Le nom d’utilisateur et le mot de passe peuvent être configurés via des variables d’environnement ; lorsque les variables `SYNCCLIPBOARD_USERNAME` et `SYNCCLIPBOARD_PASSWORD` ne sont pas vides, ces dernières seront prioritaires comme nom d’utilisateur et mot de passe.  

La variable d’environnement `ASPNETCORE_hostBuilder__reloadConfigOnChange` configure la détection automatique des modifications dans appsettings.json et le rechargement de la configuration. La valeur par défaut est `false`; toute valeur différente de `false` activera cette fonctionnalité.

> [!WARNING]  
> HTTP utilise une transmission en clair, il est donc recommandé d’activer HTTPS ou d’utiliser un proxy inverse configuré en HTTPS pour les serveurs déployés sur un réseau public. Si vous ne pouvez pas obtenir de certificat auprès d’une autorité de certification, il est recommandé d’utiliser l’outil open source [mkcert](https://github.com/FiloSottile/mkcert) ou d’autres méthodes pour générer un certificat auto-signé.

#### Docker

```shell
# docker
docker run -d \
  --name=syncclipboard-server \
  -p 5033:5033 \
  -e SYNCCLIPBOARD_USERNAME=your_username \
  -e SYNCCLIPBOARD_PASSWORD=your_password \
  --restart unless-stopped \
  jericx/syncclipboard-server:latest

# docker compose
curl -sL https://github.com/Jeric-X/SyncClipboard/raw/master/src/SyncClipboard.Server/docker-compose.yml
docker compose up -d
```
Pour configurer HTTPS, veuillez mapper vous-même `appsettings.json` et le fichier de certificat, le chemin dans le conteneur pour `appsettings.json` est `/app/appsettings.json`

#### Arch Linux

Peut être installé directement depuis [AUR](https://aur.archlinux.org/packages/syncclipboard-server) (maintenu par [@devome](https://github.com/devome)) :

```shell
paru -Sy syncclipboard-server
```
Le chemin du fichier de configuration est `/etc/syncclipboard/appsettings.json`. Après modification de la configuration, démarrez avec la commande `systemctl` :


```shell
sudo systemctl enable --now syncclipboard.service
```
### Serveur intégré au client

Le client de bureau (Windows/Linux/macOS) intègre une fonction serveur, configurable via une interface visuelle

### Serveur WebDAV
Vous pouvez utiliser un cloud supportant le protocole WebDAV comme serveur  
Serveurs testés :  

- [x] [Nextcloud](https://nextcloud.com/) 
- [x] [AList](https://alist.nn.ci/)
- [x] [InfiniCLOUD](https://infini-cloud.net/en/)
- [x] [aliyundrive-webdav](https://github.com/messense/aliyundrive-webdav)

## Client

Le client de bureau (Windows/Linux/macOS) synchronise automatiquement le presse-papiers lorsqu'il tourne en arrière-plan  
<details>
<summary>Afficher/Masquer la capture d'écran</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/WinUI.png)

</details>

### Windows
#### Version portable

Téléchargez sur la page [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest) le fichier zip dont le nom commence par `SyncClipboard_win_`, décompressez-le puis lancez `SyncClipboard.exe`

#### Remarques courantes
- La version minimale prise en charge est Windows 10 2004
- Sur Windows 10, les icônes de l’interface SyncClipboard peuvent apparaître incorrectement, veuillez installer la police d’icônes Microsoft [Segoe Fluent Icons](https://aka.ms/SegoeFluentIcons)

### macOS
#### Installation manuelle
Téléchargez sur la page [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest) le paquet dont le nom commence par `SyncClipboard_macos_`, double-cliquez puis glissez l’icône SyncClipboard dans le dossier Applications

#### Remarques courantes
- Si le système affiche « Impossible d’ouvrir “SyncClipboard” car le développeur ne peut pas être vérifié » :  
Dans les `Réglages` macOS -> `Confidentialité et sécurité`, cliquez sur `Ouvrir quand même`

- Message système « “SyncClipboard” est endommagé et ne peut pas être ouvert » : exécutez dans le terminal `sudo xattr -d com.apple.quarantine /Applications/SyncClipboard.app`
- Les raccourcis clavier nécessitent l’autorisation d’accessibilité, le logiciel affichera une fenêtre contextuelle pour demander l’autorisation si nécessaire

### Linux
#### Installation manuelle
Téléchargez le paquet d’installation commençant par `SyncClipboard_linux_` sur la page [Release](https://github.com/Jeric-X/SyncClipboard/releases/latest)

#### Arch Linux

Les utilisateurs d’Arch Linux peuvent installer directement depuis l’[AUR](https://aur.archlinux.org/packages/syncclipboard-desktop) (maintenu par [@devome](https://github.com/devome)) :

```shell
paru -Sy syncclipboard-desktop
```

Lancez-le depuis le menu après l'installation. Si l'exécution de la commande `syncclipboard-desktop` en ligne de commande génère une erreur, veuillez définir la variable d'environnement `LANG` sur `en_US.UTF-8` et lancer avec `LANG=en_US.UTF-8 syncclipboard-desktop`.

#### Dépannage courant
- Synchronisation du presse-papiers lente, impossible ou avec des caractères illisibles : il est recommandé d'installer `xclip` (X11) ou `wl-clipboard` (Wayland) sur le système. SyncClipboard utilise ces outils pour améliorer la stabilité lors de la récupération du presse-papiers. Vérifiez l'installation avec `xclip -version` ou `wl-paste -version`
- En cas d'échec lors de la mise à jour via les paquets `deb` ou `rpm`, supprimez d'abord l'ancienne version avant d'installer la nouvelle
- Pour les paquets `AppImage`, assurez-vous que le fichier AppImage a les permissions d'exécution
- Les raccourcis clavier peuvent ne pas fonctionner sous Wayland
- La langue n'est pas détectée automatiquement, par défaut l'anglais est utilisé, mais elle peut être modifiée dans les paramètres de SyncClipboard après le démarrage

> [!NOTE]  
> Pour une suppression complète de SyncClipboard, supprimez manuellement les fichiers de configuration et les dossiers temporaires :  
> `%AppData%\SyncClipboard\` (Windows), `~/Library/Application Support/SyncClipboard/` (macOS), `~/.config/SyncClipboard/` (Linux)

### Arguments en ligne de commande du client de bureau

#### --shutdown-previous
Ferme l'instance SyncClipboard en cours et lance une nouvelle instance

#### --command-{command-name}
Exécute la commande spécifiée, `{command-name}` est le nom de la commande. Après avoir configuré un raccourci, vous pouvez voir le nom de la commande dans le fichier de configuration. Même si le raccourci est supprimé, l’argument en ligne de commande reste valide  
Si une instance SyncClipboard est déjà en cours, aucune nouvelle instance n’est lancée, la commande est transmise à l’instance existante. Si aucune instance n’est active, la commande est exécutée immédiatement après le démarrage  
Plusieurs arguments `--command-{command-name}` peuvent être utilisés pour exécuter plusieurs commandes simultanément  

> [!NOTE]  
> Sur macOS, pour utiliser les arguments en ligne de commande, utilisez le chemin complet de l’exécutable : `/Applications/SyncClipboard.app/Contents/MacOS/SyncClipboard.Desktop.MacOS`

### iOS 
#### Utilisation de [Raccourcis](https://apps.apple.com/cn/app/%E5%BF%AB%E6%8D%B7%E6%8C%87%E4%BB%A4/id1462947752)  

- Synchronisation manuelle : importez ce [raccourci](https://www.icloud.com/shortcuts/d1b9e49556e04c2ca290590294afbd99) et déclenchez manuellement l’upload ou le téléchargement
- Synchronisation automatique : importez ce [raccourci](https://www.icloud.com/shortcuts/1ced32f011bc4d3498dca9960dc2c0d5), après exécution l’appareil synchronise automatiquement le presse-papiers en arrière-plan. Ce raccourci s’exécute indéfiniment, il faut le fermer manuellement. Vous pouvez également modifier si une notification système doit être envoyée après synchronisation et l’intervalle de requête en secondes
- Upload automatique des codes de vérification SMS, consultez le tutoriel vidéo dans cette discussion https://github.com/Jeric-X/SyncClipboard/discussions/60

### Android
#### Utilisation de [HTTP Request Shortcuts](https://github.com/Waboodoo/HTTP-Shortcuts)
Importez ce [fichier de configuration](/script/shortcuts.zip) et modifiez les `variables` `UserName`, `UserToken`, `url`. Ne terminez pas `url` par un séparateur `/`. `HTTP Request Shortcuts` permet d’utiliser les raccourcis depuis le menu déroulant, le widget, l’icône sur le bureau ou le menu de partage

<details>
<summary>Illustration de la modification de configuration après import</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android1.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android2.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android3.jpg)

</details>

#### Utilisation de [Autox.js](https://github.com/kkevsekk1/AutoX)

- Synchronisation automatique, utilisez ce [fichier js](/script/SyncAutoxJs.js). En raison des restrictions du système Android, sur les systèmes Android 10 et supérieurs, les applications ne peuvent pas lire le presse-papiers en arrière-plan, mais il est possible d’utiliser des outils basés sur les droits Root (Magisk/Xposed) pour lever la restriction d’accès en arrière-plan, tels que [Riru-ClipboardWhitelist](https://github.com/Kr328/Riru-ClipboardWhitelist), [Clipboard Whitelist](https://modules.lsposed.org/module/io.github.tehcneko.clipboardwhitelist). Sur Android 13 et plus, les applications doivent obtenir une autorisation manuelle de l’utilisateur pour accéder aux journaux système (presse-papiers), il est aussi possible d’utiliser Xposed pour autoriser automatiquement l’accès aux journaux système, comme [DisableLogRequest/禁用日志访问请求](https://github.com/QueallyTech/DisableLogRequest).
- Téléversement automatique des codes de vérification, utilisez ce [fichier js](/script/UploadVerificationCode.js). Ce script, lorsqu’il est exécuté en arrière-plan, lit toutes les notifications et téléverse les codes de vérification détectés vers le serveur.

Après avoir importé les fichiers js et modifié la configuration utilisateur au début de chaque fichier, lancez manuellement l’exécution ou configurez un déclencheur pour chaque fichier js, par exemple : au démarrage.

#### Utilisation de [SmsForwarder](https://github.com/pppscn/SmsForwarder)

- Téléversement automatique des codes de vérification, https://github.com/Jeric-X/SyncClipboard/discussions/109

#### Utilisation de [Tasker](https://tasker.joaoapps.com/)

- https://github.com/forrestgao/taskerforSyncClipboard, auteur : [forrestgao](https://github.com/forrestgao)

Tasker est un outil d’automatisation très puissant sous Android, vous pouvez créer votre propre profil en utilisant l’API SyncClipboard. Si vous pensez que votre profil est universel et souhaitez le partager, n’hésitez pas à me contacter pour l’ajouter ici.

### Instructions de configuration client

Toutes les plateformes nécessitent trois configurations indispensables (l’orthographe peut varier, mais le sens est le même) :
- user
- password
- url, format http(s)://ip (ou nom de domaine) :port. Lorsque vous utilisez un serveur WebDav, l’url doit pointer vers un dossier existant servant de répertoire de travail, par exemple `https://domain.com/dav/folder1/working%20folder`. Les caractères spéciaux doivent être encodés en URL, ne stockez pas d’autres fichiers dans ce dossier. Si vous n’utilisez pas le client bureau (Windows/Linux/macOS), créez un dossier `file` dans le répertoire de travail pour synchroniser les fichiers. Le client bureau crée automatiquement ce dossier lors de la configuration du serveur. Évitez que l’url se termine par un slash `/`, cela peut poser problème dans certains clients.

## API

L’API est basée sur WebDAV. Dans un environnement serveur autonome, définissez la variable d’environnement ASPNETCORE_ENVIRONMENT sur Development avant de lancer le serveur, ou ouvrez le serveur dans le client bureau et activez le mode diagnostic dans les paramètres.  
Accédez à `http://ip:port/swagger/index.html` pour ouvrir la page API. Voici quelques API clés :

### Récupérer/téléverser le presse-papiers (texte)

```
GET /SyncClipboard.json
PUT /SyncClipboard.json
```

### Obtenir/téléverser le presse-papiers (image/fichier)
```
GET  /SyncClipboard.json
HEAD /file/filename         // optional
GET  /file/filename

PUT /file/filename
PUT /SyncClipboard.json
```

### SyncClipboard.json
```
{
    "Type" : "Text"
    "Clipboard" : "Content",
    "File":""
}

{
    "Type": "Image", // or "File", "Group"
    "Clipboard": "hash, optional",
    "File": "filename"
}
```

## 项目依赖
[NativeNotification](https://github.com/Jeric-X/NativeNotification)  
[Magick.NET](https://github.com/dlemstra/Magick.NET)  
[.NET Community Toolkit](https://github.com/CommunityToolkit/dotnet)  
[H.NotifyIcon](https://github.com/HavenDV/H.NotifyIcon)  
[WinUIEx](https://github.com/dotMorten/WinUIEx)  
[moq](https://github.com/moq/moq)  
[Avalonia](https://avaloniaui.net/)  
[FluentAvalonia.BreadcrumbBar](https://github.com/indigo-san/FluentAvalonia.BreadcrumbBar)  
[FluentAvalonia](https://github.com/amwx/FluentAvalonia)  
[Vanara](https://github.com/dahall/Vanara)  
[Tmds.DBus](https://github.com/tmds/Tmds.DBus)  
[SharpHook](https://github.com/TolikPylypchuk/SharpHook)  
[DotNetZip.Semverd](https://github.com/haf/DotNetZip.Semverd)  
[Quartz.NET](https://github.com/quartznet/quartznet)  
[MiSans](https://hyperos.mi.com/font)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---