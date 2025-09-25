> [!WARNING]
> Un problème empêche actuellement l’obtention du `refresh_token` sur iOS. Ce problème ne vient pas de `colmsg` mais est dû à une mise à jour de l’application de messagerie. Il n’existe actuellement aucune solution complète à ce problème. Pour Android, veuillez continuer à vous référer à [ce lien](https://github.com/proshunsuke/colmsg/blob/main/doc/how_to_get_refresh_token.md#android%E3%82%A2%E3%83%97%E3%83%AA%E3%81%AE%E5%A0%B4%E5%90%88).

<div align="center">
  <h1><strong>colmsg</strong></h1>
  <img src="https://user-images.githubusercontent.com/3148511/158018437-09822a33-8767-4e03-ba90-e0f69594c493.jpeg" width="32px" alt="Logo de Sakurazaka46 Message"><img src="https://user-images.githubusercontent.com/3148511/158018441-dd7cb9eb-bf31-4938-830d-1ef293a2afba.jpg" width="32px" alt="Logo de Hinatazaka46 Message"><img src="https://user-images.githubusercontent.com/3148511/158018442-ae54e926-760d-4b47-b0a0-7255485e1f28.jpg" width="32px" alt="Logo de Nogizaka46 Message">

  Sauvegardez les messages des applications « Sakurazaka46 Message », « Hinatazaka46 Message », « Nogizaka46 Message », « Asuka Saito Message », « Mai Shiraishi Message » et « yodel » sur votre PC.

  ![demo](https://user-images.githubusercontent.com/3148511/158026220-90735546-2401-40ca-a9e6-89d2176ad3b4.gif)
</div>

## Résumé

Pour l’installation de `colmsg`, veuillez consulter [ce lien](#インストール).

**Premièrement**, veuillez obtenir le refresh_token. La méthode d’obtention est expliquée [ici](https://raw.githubusercontent.com/proshunsuke/colmsg/main/doc/how_to_get_refresh_token.md).

Une fois obtenu, exécutez ce qui suit.  
Insérez dans `<s_refresh_token>`, `<h_refresh_token>`, `<n_refresh_token>`, `<a_refresh_token>`, `<m_refresh_token>`, `<y_refresh_token>` les refresh_tokens obtenus respectivement pour « Sakurazaka46 Message », « Hinatazaka46 Message », « Nogizaka46 Message », « Asuka Saito Message », « Mai Shiraishi Message » et « yodel ».  
※ Il n’est pas nécessaire d’indiquer autre chose que les applications auxquelles vous êtes abonné.

Tous les messages de tous les membres abonnés sur toute la période seront sauvegardés.  

```shell script
colmsg --s_refresh_token <s_refresh_token> --h_refresh_token <h_refresh_token> --n_refresh_token <n_refresh_token> --a_refresh_token <a_refresh_token> --m_refresh_token <m_refresh_token> --y_refresh_token <y_refresh_token>
```

Pour Windows, veuillez remplacer le nom de l'exécutable par `colmsg.exe`.

## Caractéristiques

* ✅ Aucune nécessité de rooter l'appareil
* ✅ Compatible avec les applications Android et iOS
* ✅ Fonctionne sous Windows, macOS, Linux
* ✅ Plusieurs méthodes de sauvegarde disponibles
* ✅ Compatible avec les versions suivantes des applications
  * «櫻坂46メッセージ» : version 1.12.01.169
  * «日向坂46メッセージ» : version 2.13.01.169
  * «乃木坂46メッセージ» : version 1.8.01.169
  * «齋藤飛鳥メッセージ» : version 1.1.01.169
  * «白石麻衣メッセージ» : version 3.4.3.426
  * «yodel» : version 4.1.1.455

## Utilisation

L'utilisation de base a été expliquée dans l'aperçu.  
Cependant, comme le refresh_token est une information sensible, il n'est pas recommandé de le saisir directement dans le terminal.  
Nous recommandons donc de définir les options par défaut dans un fichier de configuration.  
Pour plus d'informations sur le fichier de configuration, consultez [ici](#configファイル).  
Dans la suite, nous supposons que le refresh_token est configuré dans le fichier de configuration.

`colmsg` propose plusieurs options permettant de choisir diverses méthodes de sauvegarde.

Pour sauvegarder les messages d'un membre spécifique

```shell script
colmsg -n 菅井友香 -n 佐々木久美
```

Si vous souhaitez enregistrer les messages d'un groupe spécifique

```shell script
colmsg -g sakurazaka
```
Si vous souhaitez enregistrer un type spécifique de message


```shell script
colmsg -k picture -k video
```

Si vous souhaitez enregistrer les messages après une date et une heure spécifiques

```shell script
colmsg -F '2020/01/01 00:00:00'
```
Les options peuvent être utilisées en combinaison. Pour une explication plus détaillée, veuillez exécuter ce qui suit pour vérifier.


```shell script
colmsg --help
```

## Spécifications détaillées

* Lorsqu'une commande est exécutée alors que plusieurs messages sont déjà enregistrés, seuls les messages postérieurs au dernier message enregistré seront récupérés et sauvegardés  
* Les messages sauvegardés seront stockés selon la structure de répertoires suivante
  * ```shell script
    colmsg/
    ├── Hinatazaka46 Première génération
    │   └── Sasaki Kumi
    │       └── 1_0_20191231235959.txt
    ├── Nogizaka46
    │   └── Akimoto Manatsu
    │       └── 2_1_20200101000000.jpg
    └── Sakurazaka46 Première génération
        └── Sugai Yūka
            ├── 3_2_20200101000001.mp4
            └── 4_3_20200101000002.mp4
    ```
* ファイル名の形式は `<シーケンス番号>_<種類>_<日付>.<拡張子>` となっています
  * シーケンス番号はメッセージの時系列を表す番号になっています。若い数字程昔のメッセージです。ファイルブラウザで辞書順に並べると保存したメッセージが時系列通りに並びます
  * 種類の数字は以下のように対応しています
    * 0: テキストメッセージ
    * 1: 画像
    * 2: 動画
    * 3: ボイス
    * 4: リンク
* 各環境毎のデフォルトの保存先は以下を実行することで確認することが出来ます
  * ```shell script
    colmsg --download-dir
    ```
* Les messages déjà sauvegardés ne seront pas écrasés

## Fichier de configuration

`colmsg` permet de spécifier des options à l'avance dans un fichier de configuration.  
Le chemin par défaut peut être vérifié en exécutant ce qui suit.

```shell script
colmsg --config-dir
```
Vous pouvez également spécifier l’emplacement du fichier de configuration dans la variable d’environnement `COLMSG_CONFIG_PATH`.

```shell script
export COLMSG_CONFIG_PATH="/path/to/colmsg.conf"
```

### Format

Ce fichier de configuration est une simple liste d’arguments en ligne de commande. En utilisant `colmsg --help`, vous pouvez consulter les options disponibles et leurs valeurs. De plus, vous pouvez ajouter des commentaires en commençant par `#`.

Exemple de fichier de configuration :

```bash
# s_refresh_tokenを指定
--s_refresh_token s_refresh_token

# h_refresh_tokenを指定
--h_refresh_token h_refresh_token

# n_refresh_tokenを指定
--n_refresh_token n_refresh_token

# a_refresh_tokenを指定
--a_refresh_token a_refresh_token

# m_refresh_tokenを指定
--m_refresh_token m_refresh_token

# y_refresh_tokenを指定
--y_refresh_token y_refresh_token

# メディアファイルだけ保存するように設定
-k picture -k video -k voice
```

## Installation

### Windows

Les fichiers exécutables précompilés pour Windows sont compressés en zip et disponibles sur la [page des releases](https://github.com/proshunsuke/colmsg/releases).  
Téléchargez-les et décompressez-les avec un logiciel comme [7-Zip](https://sevenzip.osdn.jp/).  
Après décompression, vous obtiendrez le fichier exécutable `colmsg.exe`.  
Exécutez-le dans [PowerShell](https://docs.microsoft.com/ja-jp/powershell/) ou un autre environnement similaire.

### macOS

Vous pouvez l’installer via Homebrew.

```shell script
brew tap proshunsuke/colmsg
brew install colmsg
```

### Arch Linux

Peut être installé depuis [AUR](https://aur.archlinux.org/packages/colmsg/).

```bash
yay -S colmsg
```

### Binaire

Les fichiers exécutables compilés pour différentes architectures sont disponibles sur la [page des releases](https://github.com/proshunsuke/colmsg/releases).

## Développement

`colmsg` fait appel à des API externes. Lors du développement, il est possible de mettre en place un serveur mock utilisant OpenApi.

```shell
make server/kh
make server/n46
```

Il est possible d'envoyer des requêtes au serveur de simulation en spécifiant les variables d'environnement `S_BASE_URL`, `H_BASE_URL` et `N_BASE_URL`.

```shell script
S_BASE_URL=http://localhost:8003 H_BASE_URL=http://localhost:8003 N_BASE_URL=http://localhost:8006 cargo run -- -d ~/Downloads/temp/ --help
```

## TODO

* [ ] Tests automatiques via CI
* [ ] Préparation des exemples
* [ ] Parallélisation du traitement de sauvegarde des messages
* [ ] Création d’un crate pour le client API

## Licence

`colmsg` est distribué sous les conditions de la licence MIT.

Pour plus de détails sur la licence, veuillez consulter le fichier [LICENSE](https://raw.githubusercontent.com/proshunsuke/colmsg/main/LICENSE.txt).

## Remarques importantes

Veuillez noter les points suivants dans l’article 8 (Interdictions) des conditions d’utilisation de l’application.

* (16) Accéder ou tenter d’accéder au service par des moyens autres que ceux spécifiés par notre société
* (17) Accéder ou tenter d’accéder au service à l’aide de moyens automatisés (y compris les crawlers et technologies similaires)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---