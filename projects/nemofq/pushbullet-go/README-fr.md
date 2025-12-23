# Pushbullet Go

[![Version Chrome Web Store](https://img.shields.io/chrome-web-store/v/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Utilisateurs Chrome Web Store](https://img.shields.io/chrome-web-store/users/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Note Chrome Web Store](https://img.shields.io/chrome-web-store/rating/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

> **Note 1** : Le nom de l’extension a été changé en « Push Go » en raison de la politique du Chrome Web Store.
>
> **Note 2** : Il s’agit d’un client tiers et open-source pour l’API Pushbullet. Non affilié ni approuvé par le service.

![Pushbullet Go](https://raw.githubusercontent.com/nemofq/pushbullet-go/main/screenshots/1_popup.png)

Une extension Chrome légère pour Pushbullet qui permet de recevoir et d’envoyer des notifications directement depuis votre navigateur.

Cette extension est compatible avec Manifest V3, ce qui en fait une alternative à l’extension officielle qui ne fonctionne plus.

[![](https://developer.chrome.com/static/docs/webstore/branding/image/UV4C4ybeBTsZt43U4xis.png)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

## Fonctionnalités

Nécessite un compte [Pushbullet](https://www.pushbullet.com/). Les fonctionnalités incluent :

- Recevoir et envoyer des notifications
- Envoyer des fichiers/images par collage, glisser-déposer ou téléchargement (dans une fenêtre autonome à cause des restrictions de Chrome)
- Envoyer l’URL de la page actuelle, du texte sélectionné ou des images depuis le menu contextuel avec sélection d’appareils/personnes
- Contrôler les appareils vers lesquels envoyer en sélectionnant les appareils
- Notifications pour les notifications reçues avec boutons pour ouvrir les liens et fermer
- Ouverture automatique du lien reçu dans un nouvel onglet (désactivé par défaut, à activer dans la page des options)
- Stocke localement les 100 dernières notifications (historique complet disponible sur le site Pushbullet)
- (Nouveau) Filtre pour afficher et notifier les notifications par appareil cible
- (Nouveau) Contrôle des notifications provenant du navigateur (utile pour l’utilisation multi-navigateurs)
- (Nouveau) Miroir de notifications (nécessite l’application Pushbullet Android installée et activée dans l’application Android et dans les paramètres de Push Go)
- (Nouveau) Mode sombre (suit le système par défaut ou choix manuel)
- (Nouveau) Supporte l’i18n avec 33 langues
- (Nouveau) Compte des non lus
- (Nouveau) Partage rapide du lien de l’onglet actuel dans la popup (désactivé par défaut, à activer dans la page des options)
- (Nouveau) Lecture d’un son lors d’une notification (peut être désactivé dans la page des options)
- (Nouveau) Chiffrement de bout en bout pour le miroir de notifications
- (Nouveau) Extraction du code de vérification depuis la notification miroir (clic pour copier dans la popup)

## Installation
> **Note 3** : Nécessite Chrome 116+ pour utiliser l’API `chrome.idle` afin de maintenir la connexion au serveur WebSocket de Pushbullet.

### Recommandé

Installez directement depuis le [Chrome Web Store](https://chromewebstore.google.com/detail/push-go/dghndapbehjdbhiffbckojkhoennbofg) ou :

### Manuel

1. Téléchargez et décompressez l’extension depuis le dossier `release/`
2. Ouvrez Chrome et naviguez vers `chrome://extensions/`
3. Activez le "Mode développeur" en haut à droite
4. Cliquez sur "Charger l’extension non empaquetée" et sélectionnez le dossier `/src` décompressé

## Configuration

1. Cliquez sur l’icône de l’extension et sélectionnez "Ouvrir les paramètres"
2. Entrez le token d’accès via authentification OAuth ou manuellement (depuis [les paramètres Pushbullet](https://www.pushbullet.com/#settings/account))
3. Cliquez sur le bouton récupérer et commencez à envoyer et recevoir des notifications push !
4. Personnalisez les paramètres sur la page des options selon vos besoins

## Autorisations

Cette extension requiert les autorisations suivantes :
- **Stockage** : Pour sauvegarder vos options et l’historique des notifications localement
- **Inactivité** : Pour maintenir la connexion afin de recevoir les notifications en temps réel
- **Notifications** : Pour afficher les notifications push
- **Menus contextuels** : Pour ajouter des options dans le menu clic droit pour envoyer du contenu
- **Onglet actif** : Pour accéder à l’URL et au titre de la page actuelle pour les actions du menu contextuel et des raccourcis clavier
- **Accès hôte** : Pour communiquer avec les serveurs de l’API Pushbullet
- **Hors écran** : Pour jouer le son des notifications
- **Identité** : Pour compléter le processus OAuth

## Confidentialité

Cette extension stocke toutes les données localement et ne transmet aucune information en dehors de l’API de Pushbullet.

## Licence

Ce projet utilise la [licence AGPL-3.0](https://github.com/nemofq/pushbullet-go?tab=AGPL-3.0-1-ov-file). Si vous avez des demandes de fonctionnalités ou des retours, n’hésitez pas à créer une issue ou une pull request.

## Une dernière chose

Si vous êtes également un utilisateur iOS+Pushbullet, vous pourriez trouver ces Raccourcis utiles :

- [Envoyer vers Pushbullet](https://www.icloud.com/shortcuts/5549bbb5b06e4f0a8ccb1b6fd33e853f)
- [Récepteur Pushbullet](https://www.icloud.com/shortcuts/1f94913de21b41debe60ef43631afde2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---