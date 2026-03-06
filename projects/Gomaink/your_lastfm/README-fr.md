[![Statut](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Licence](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Une application Node.js containerisée qui synchronise les scrobbles de **Last.fm**, les stocke dans une base de données **SQLite** locale, et propose un tableau de bord web.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## Projet

**Your LastFM** est une application Node.js conçue pour **synchroniser automatiquement les scrobbles** de musique depuis Last.fm. Elle conserve votre historique d’écoute dans une base de données SQLite locale et propose une interface web pour la visualisation des données.

Le projet est entièrement containerisé avec **Docker**, utilisant un point d’entrée automatisé pour gérer l’initialisation de la base de données et l’exécution séquentielle (synchronisation d’abord, puis lancement de l’API Web). Il utilise également **PM2** comme gestionnaire de processus à l’intérieur du container pour garantir que le service web reste actif et résilient.

## Fonctionnalités
### Tableau de bord web interactif

- Interface web propre et moderne pour visualiser votre activité musicale.

### Synchronisation automatique des scrobbles Last.fm

- Récupère et stocke périodiquement votre historique d’écoute (scrobbles) depuis Last.fm.
- Assure que vos données sont toujours à jour sans intervention manuelle.

### Base de données locale de l’historique musical

- Persiste tous les scrobbles dans une base de données SQLite locale.
- Permet des requêtes rapides et un accès hors ligne aux données d’écoute historiques.

### Vue des scrobbles récents

- Affiche vos morceaux les plus récents.
- Logique intelligente de repli d’image pour les morceaux, albums et artistes.

### Comparaison avec les amis (Vue de compatibilité)

- Comparez vos goûts musicaux avec ceux de vos amis Last.fm.
- Affiche le niveau de compatibilité (Très Faible → Super).
- Affiche les artistes, albums et morceaux les plus communs.
- Calcule et normalise la compatibilité basée sur les données d’écoute réelles.

### Cartes musicales partageables

- Génère des images dynamiques basées sur vos données d’écoute.
- Mises en page optimisées pour les publications de fil et les stories Instagram (9:16)
- Construit avec node-canvas pour le rendu d’images côté serveur.

## Prérequis

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Installation

### Créer un fichier `.env`

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm : Créez un compte API [ici](https://www.last.fm/api/account/create) pour obtenir votre clé API.

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

Dans le terminal :  
`docker compose up -d`  

Puis accédez à :
```
http://localhost:1533
```

(ou remplacez `localhost` par l'adresse IP de votre serveur)

## Licence

Ce projet est sous licence MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---