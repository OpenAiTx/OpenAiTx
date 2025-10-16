# Téléchargeur de vidéos WeChat

Petit, simple à utiliser, compatible avec macOS et Windows.

## Mise à jour 250913

1. Ajout du bouton de téléchargement sur la page d’accueil des vidéos
<br/>
2. Ajout de la commande `uninstall`, permettant de désinstaller le certificat racine installé par cet outil
<br/>
3. Correction du problème d’écran blanc lors de l’ouverture des pages de vidéos longues

<details><summary>Cliquez pour voir plus de mises à jour</summary>

## Mise à jour 250808

1. Correction du problème de l’absence du bouton de téléchargement dans la nouvelle version de WeChat


## Mise à jour 250621

1. Optimisation de l’affichage de la « progression » lors du téléchargement
<br/>
2. Ajout de la commande `download`, permettant de télécharger et de déchiffrer les vidéos via le terminal. Pour les vidéos de plus de 1 Go, il est conseillé d’utiliser cette méthode
<br/>

```bash
# 使用方式
./wx_video_download_xx download --url "视频地址" --key 解密key --filename "文件名"
# 视频地址、文件名参数需要双引号包裹。解密key不用双引号
# 将会下载视频到 `Downloads` 目录，然后解密
```
3、Ajout du bouton « Imprimer la commande de téléchargement » dans le menu « Plus » du compte vidéo  
<br/>  
4、Correction du problème où certains messages d’erreur lors de l’installation du certificat n’étaient pas en chinois  


## Mise à jour 250514  

1、Correction du problème empêchant le téléchargement des images et vidéos  

## Mise à jour 25042501  

1、Correction du problème empêchant la lecture des vidéos téléchargées  

## Mise à jour 250425  

1、Correction du problème empêchant le téléchargement des vidéos  

## Mise à jour 250424  

1、Correction de l’incohérence du style du bouton de téléchargement  
<br/>  
2、Correction du problème où le clic sur le bouton « Plus » n’affichait pas le menu supplémentaire  
<br/>  
3、Ajout d’un message d’alerte en cas d’échec du démarrage de Windows, proposant d’exécuter en tant qu’administrateur  

## Mise à jour 250215  

1、Affichage de la progression du téléchargement dans la console, affichage du nombre d’octets téléchargés lorsque la progression est indisponible  
<br/>  
2、Ajout du téléchargement de l’image de couverture dans le menu « Plus »  
<br/>  
3、Détection automatique de l’appareil réseau actuel et configuration du proxy  
<br/>  
4、Support des paramètres en ligne de commande pour spécifier l’appareil réseau à proxyfier et le port utilisé par le programme


```bash
./wx_video_download_xxx --dev=Wi-Fi --port=1080
```
> En général, il n'est pas nécessaire de spécifier manuellement l'appareil et le numéro de port, il suffit d'exécuter ./wx_video_download_xxx

## Mise à jour 241216

1. Prise en charge du téléchargement des replays en direct
<br/>
2. Prise en charge du système macOS
<br/>
Testé et fonctionnel sur WeChat Version 3.8.9 (28564)

Instructions d'utilisation sous macOS


```bash
chmod +x ./wx_video_download_darwin_xxx
sudo ./wx_video_download_darwin_xxx
```

À ce stade, un message indiquera que le fichier ne peut pas être ouvert, il faut aller dans les paramètres système pour autoriser, puis réexécuter `sudo ./wx_video_download_darwin_xxx`.
<br/>

Lors de l'installation du certificat, une demande d'autorisation apparaîtra, il suffit d'accepter. Par la suite, il n'est plus nécessaire d'utiliser `sudo`, il suffit de double-cliquer pour exécuter
<br/>

Pour fermer le terminal `macOS`, utilisez la combinaison `Command + c`, sinon il se peut que le proxy système ne soit pas annulé, ce qui entraînerait un problème d'accès réseau
<br/>

> En cas d'impossibilité d'accès au réseau, veuillez vérifier le proxy système et l'annuler manuellement.

<br/>

## Mise à jour 241106

1. Correction du problème où les vidéos ouvertes pour la deuxième fois ou plus ne pouvaient pas être lues après téléchargement

Désormais, en cliquant sur la vidéo « Plus de recommandations » sur la page, les vidéos téléchargées peuvent être ouvertes et lues normalement.
<br>
En cas de message « Échec du déchiffrement, téléchargement arrêté », fermez toutes les pages et fenêtres vidéo. Rouvrez, puis vous pourrez télécharger.

## Mise à jour 241104

1. Support du téléchargement de vidéos en différentes qualités
<br>
2. Correction du problème où il était impossible de faire glisser la barre de progression des vidéos téléchargées
<br>
3. Correction du problème où le téléchargement commençait avant le chargement de la progression du contenu des longues vidéos, causant une lecture impossible ou incomplète
<br>
4. Correction du problème où certaines vidéos étaient à tort identifiées comme des images, empêchant le téléchargement
<br>
5. Correction du problème de chargement infini dans les salles de diffusion en direct

![Bouton de téléchargement 2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot13.png)

Pour plus de détails sur les différentes qualités de vidéo, voir les instructions d'utilisation ci-dessous.

## Mise à jour 241102

Ajouter un bouton « Télécharger la vidéo » dans le menu déroulant « Plus », compatible avec les différentes mises en page des pages de détails qui empêchent l’affichage du bouton de téléchargement.

![Bouton de téléchargement2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot10.png)

## Mise à jour 241101

Plus besoin de télécharger et d’installer manuellement le certificat.
<br>
Correction du problème d’alerte indiquant que `lib/jszip.min.js` est introuvable lors du téléchargement.

## Mise à jour 241031

Le problème de téléchargement direct sur la page est réapparu, cette fois le téléchargement se fait sous forme d’archive compressée contenant la vidéo.
C’est fonctionnel pour le moment, mais sans garantie que cela fonctionne encore à l’avenir.

Il est conseillé d’utiliser [WechatVideoSniffer2.0](https://github.com/kanadeblisst00/WechatVideoSniffer2.0) pour une meilleure stabilité.

## Mise à jour 241030

Quand le contenu du compte vidéo est plusieurs images, un bouton de téléchargement apparaît aussi. Cliquer dessus télécharge une archive compressée contenant toutes les images.

## Mise à jour 241022

Quand la vidéo est supprimée, l’état « Supprimé » n’était pas correctement affiché et restait en chargement.
Le bouton de téléchargement a été modifié pour avoir le même style que les autres boutons d’action.

## Mise à jour 241016

La version précédente ne permettait plus de télécharger, revenir au téléchargement direct sur la page fonctionne à nouveau, est-ce lié à la version du client WeChat ? Je ne suis pas sûr.
Si la version 241016 ne fonctionne pas, essayez une autre version.
Ma version WeChat actuelle est `Weixin 3.9.12.17`, le téléchargement fonctionne normalement.

## Mise à jour 241011

Il semble que le compte vidéo ait encore été modifié, il n’est plus possible de télécharger directement depuis la page. Le bouton de téléchargement copie maintenant le lien vidéo dans le presse-papiers, puis il faut ouvrir ce lien dans Chrome ou un autre navigateur pour télécharger.
J’ai aussi testé beaucoup de vidéos qui se téléchargent directement, sans chiffrement. Donc si la vidéo est chiffrée, la nouvelle version risque d’échouer.

> Le téléchargement direct sur la page est théoriquement toujours possible, mais la mise en œuvre est beaucoup plus compliquée, je l’étudierai plus tard.

</details>

## Instructions d'utilisation

Téléchargez le [fichier binaire](https://github.com/ltaoo/wx_channels_download/releases), **exécutez-le en tant qu'administrateur**, la première ouverture installera automatiquement le certificat, puis démarrera le service.

Lorsque le terminal indique « Service démarré correctement », cela signifie que vous pouvez l'utiliser.

![Utilisation normale](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot8.png)

> Si le certificat est déjà installé, l'étape d'installation du certificat sera sautée.

Ouvrez la version PC de WeChat, cliquez sur la vidéo que vous souhaitez télécharger, une fois sous la barre d'actions de la vidéo, un bouton de téléchargement apparaîtra, comme montré ci-dessous.

![Bouton de téléchargement vidéo](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot1.png)

> S'il n'apparaît pas, vérifiez dans « Plus » si le bouton « Télécharger la vidéo » est présent. <br> > ![Bouton de téléchargement 2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot10.png)

Attendez que la vidéo commence à jouer, puis mettez-la en pause, cliquez sur le bouton de téléchargement pour lancer le téléchargement. Une fois le téléchargement réussi, les fichiers téléchargés seront affichés en haut, le nom du fichier téléchargé indiquera la qualité de la vidéo à la fin.

![Téléchargement vidéo réussi](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot2.png)

Par défaut, la vidéo de la première qualité dans le menu déroulant sera téléchargée. En cliquant sur « Plus », vous pouvez télécharger des vidéos de différentes qualités, y compris la vidéo originale.

![Télécharger des vidéos de différentes qualités](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot13.png)
<br>

Les options affichées diffèrent selon la vidéo, il n'y a pas d'explication spécifique pour xWT111, concernant la résolution ou la taille, etc.
<br>
Après tests, si la vidéo originale fait 104 Mo, la plus grande taille ici est xWT111 avec 17 Mo, la plus petite est xWT98 avec 7 Mo.

![Statistiques des tailles des vidéos de différentes qualités](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot14.png)

À titre indicatif seulement.

## Questions fréquentes

1. Le service est démarré, mais après avoir ouvert les détails de la vidéo, cela charge indéfiniment et aucun log n'apparaît dans le terminal.
<br>
Essayez dans le terminal de faire `Ctrl+C`, une seule fois suffit.

2、Échec du déchiffrement, arrêt du téléchargement
<br>
Fermez toutes les pages et fenêtres vidéo. Rouvrez-les, puis vous pourrez télécharger.

## Notes de développement

Lancez d'abord le terminal en tant qu'administrateur, puis exécutez `go run main.go`.

## Emballage

# windows

```bash
go build -o wx_video_download.exe main.go
```

Après l'empaquetage, vous pouvez utiliser `upx` pour la compression, la taille peut être réduite de 17 Mo à 5 Mo.

# macOS

```bash
CGO_ENABLED=1 GOOS=darwin SDKROOT=$(xcrun --sdk macosx --show-sdk-path) go build -trimpath -ldflags="-s -w" -o wx_video_download
```

```bash
CGO_ENABLED=1 GOOS=darwin GOARCH=amd64 SDKROOT=$(xcrun --sdk macosx --show-sdk-path) go build -trimpath -ldflags="-s -w" -o wx_video_download
```

## 其他

此程序大部分参考自以下项目代码
<br>
https://github.com/kanadeblisst00/WechatVideoSniffer2.0

此程序的核心实现依赖以下库
<br>
https://github.com/qtgolang/SunnyNet

## 我的赞赏码

如果我的项目对你有所帮助，可以请我喝杯咖啡 ☕️

[![Sponsors](https://sponsorkit-iota.vercel.app/api/sponsors)](https://sponsorkit-iota.vercel.app/api/sponsors)

```text
                 本项目为开源项目
            仅用于技术交流学习和研究的目的
          请遵守法律法规,请勿用作任何非法用途
               否则造成一切后果自负
           若您下载并使用即视为您知晓并同意
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---