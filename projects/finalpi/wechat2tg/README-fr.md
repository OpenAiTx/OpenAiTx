# wechat2tg-mac

Basé sur le protocole WeChat Mac pour envoyer et recevoir des messages WeChat sur Telegram. Le service wx2tg-server n'est pas open source pour des raisons de sécurité.

## Groupe TG : [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Fonctionnalités principales

1. Réception des messages de chat individuel WeChat, des messages de groupe WeChat, des messages de comptes officiels, et des messages WeChat Work (WeCom)
2. Envoi de messages depuis Telegram à des utilisateurs WeChat, des groupes WeChat ou des comptes officiels spécifiques
3. Filtrage des messages de groupes spécifiques

## Types de messages pris en charge

### Liste des types de messages WeChat pris en charge

+ [x] Message texte
+ [x] Message WeChat Work
+ [x] Stickers WeChat
+ [x] Message image
+ [x] Message vidéo
+ [x] Appel audio/vidéo (uniquement notification)
+ [x] Message fichier
+ [x] Message lien
+ [x] Message de groupe
+ [x] Message @ dans les groupes (les @everyone et @vous seront convertis en Telegram @vous)
+ [x] Message de compte officiel
+ [x] emoji
+ [x] Message de localisation
+ [x] Message retiré
+ [x] Message vocal
+ [ ] Message de Hongbao (notification uniquement, contenu non accessible)
+ [ ] Message mini-programme

### Liste des types de messages Telegram pris en charge

+ [x] Message texte
+ [x] Stickers
+ [x] Message image
+ [x] Message vidéo
+ [x] Message fichier
+ [x] Message vocal

## Remarques

1. Ce projet est destiné uniquement à la recherche technique et à l’apprentissage. Toute utilisation illégale est interdite.
2. N’hésitez pas à soumettre un ticket (issue) pour tout problème rencontré.

## Déploiement et installation

Copiez d'abord `.env.example` en `.env`, puis configurez les variables d'environnement dans le fichier `.env`.

Copiez `app.conf.example` du projet en tant que fichier `app.conf` dans le répertoire `conf` et configurez l'adresse Redis avec celle de votre instance Redis déployée.

### docker-compose

Créez le fichier `docker-compose.yml` :

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Les fichiers stickers n'ont pas besoin d'être reconvertis après montage du dossier
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Télécharger l'image
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### Exécution

```shell
docker-compose up -d
```

#### Désactiver le mode confidentialité du bot

Désactivez le mode confidentialité du bot via BotFather. Ouvrez BotFather, saisissez `/mybots`, sélectionnez votre bot. Cliquez sur `Bot Settings` - `Group Privacy` - `Turn off`.
Si `Privacy mode is disabled for xxx` apparaît, la désactivation est réussie.

## Guide d'utilisation

### Commandes du BOT

- `/login` : Obtenir le QR code de connexion ; la première personne à envoyer la commande `/login` après le démarrage sera le propriétaire du BOT

- `/flogin` : Obtenir le QR code de l'assistant de transfert de fichiers, pour recevoir vidéos et fichiers

- `/update` : Mettre à jour l’avatar et le nom des groupes

- `/message` : Activer/désactiver la réception des messages de groupe

- `/forward` : Activer/désactiver le transfert des messages d'autres personnes ou du bot dans les groupes

- `/user` : Obtenir la liste des utilisateurs WeChat ; après avoir cliqué sur le bouton, vous pouvez créer un nouveau groupe ou associer un utilisateur (recherche par nom ou remarque, par exemple : `/user 张` pour rechercher des utilisateurs WeChat contenant « 张 »)

- `/room` : Obtenir la liste des groupes WeChat ; après avoir cliqué sur le bouton, vous pouvez créer un nouveau groupe ou associer un groupe WeChat (recherche par nom ou remarque, par exemple : `/room 外卖` pour rechercher les groupes WeChat contenant « 外卖 »)

- `/settings` : Paramètres du programme

- `/unbind` : Dissocier un groupe WeChat ou un utilisateur WeChat (uniquement en groupe)

### Description des variables d'environnement

|Nom| Obligatoire | Description                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Oui    | Token du Bot Telegram, à créer via [BotFather](https://t.me/BotFather) |
|`API_ID`| Oui    | API ID de Telegram                                          |
|`API_HASH`| Oui    | API HASH de Telegram                                        |
|`BASE_API`| Oui    | Adresse complète de l’API du conteneur wx2tg-server                            | |
|`PROXY_PROTOCOL`| Non    | Type de proxy possible (socks5,http,https)                                     |
|`PROXY_HOST`| Non    | URL du proxy                                                        |
|`PROXY_PORT`| Non    | Port du proxy                                                         |
|`PROXY_USERNAME`| Non    | Nom d'utilisateur du proxy                                                         |
|`PROXY_PASSWORD`| Non    | Mot de passe du proxy                                                          |
|`ROOM_MESSAGE`| Non    | Format d’affichage des messages de groupe WeChat dans le BOT                                              |
|`OFFICIAL_MESSAGE`| Non    | Format d’affichage des messages de comptes officiels dans le BOT                                              |
|`CONTACT_MESSAGE`| Non    | Format d’affichage des messages d’utilisateurs WeChat dans le BOT                                             |
|`ROOM_MESSAGE_GROUP`| Non    | Format d’affichage des messages de groupe WeChat dans un groupe Telegram                                                 |
|`CONTACT_MESSAGE_GROUP`| Non    | Format d’affichage des messages d’utilisateurs WeChat dans un groupe Telegram                                                |
|`OFFICIAL_MESSAGE_GROUP`| Non    | Format d’affichage des messages de comptes officiels dans un groupe Telegram                                                 |
|`CREATE_ROOM_NAME`| Non    | Format du nom du groupe lors de la création automatique d’un groupe WeChat                                           |
|`CREATE_CONTACT_NAME`| Non    | Format du nom du groupe lors de la création automatique d’un groupe de contacts WeChat                                         |
|`MESSAGE_DISPLAY`| Non    | Format d’affichage des messages textes                                                      |

 ---

### Description de la commande `/settings`

1. Affichage des emojis WeChat sous forme de lien image : si activé, les emojis reçus seront affichés comme des liens d'image

1. Synchroniser les informations du groupe au démarrage : si activé, toutes les infos de groupe seront synchronisées au lancement du programme (mise à jour des avatars et noms de groupe)

---

### Transcription vocale

1. Configurez `TENCENT_SECRET_ID` et `TENCENT_SECRET_KEY`, à obtenir sur la [console de reconnaissance vocale Tencent](https://console.cloud.tencent.com/asr). Un quota gratuit est disponible.
2. Activez la fonction de transcription automatique dans `/settings`.

---

### Obtenir `API_ID` et `API_HASH`

1. Connectez-vous sur [compte telegram](https://my.telegram.org/)

2. Cliquez sur « API development tools » et remplissez les informations de l’application (titre et court nom suffisent)

3. Cliquez sur « Create application »

---

### Personnalisation du modèle de message

Si vous souhaitez modifier le format de l’expéditeur du message, vous pouvez modifier les variables d'environnement dans le docker ou le fichier `.env`.

Placeholders disponibles pour le modèle :

`#[alias]` : Remarque du contact

`#[name]` : Surnom du contact

`#[topic]` : Nom du groupe

`#[alias_first]` : Affiche la remarque en priorité, sinon le surnom

`#[identity]` : Texte d'identité

`#[body]` : Corps du message

`#[br]` : Saut de ligne

### Comment @tout le monde

Envoyez un message commençant par `@all` pour @tout le monde, uniquement pour les messages texte.

---

## Foire aux questions


## Participation au développement

1. Forkez le projet, basculez sur la branche `wx2tg-mac-dev` ou créez-en une nouvelle. Ne poussez pas directement sur la branche principale.
2. Envoyez une Pull Request sur la branche `wx2tg-mac-dev`.


## License

[MIT](LICENSE)


## Remerciements

Merci à Jetbrains pour le soutien apporté à ce projet

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---