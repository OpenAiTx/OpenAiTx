
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Statut](https://img.shields.io/badge/status-actif-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![Licence](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

Une application Node.js conteneurisée qui synchronise les scrobbles de **Last.fm**, les stocke dans une base de données locale **SQLite**, et propose un tableau de bord web.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## Projet

**Your LastFM** est une application Node.js conçue pour **synchroniser automatiquement les scrobbles musicaux** depuis Last.fm. Elle conserve votre historique d’écoute dans une base de données SQLite locale et propose une interface web pour la visualisation des données.

Le projet est entièrement conteneurisé avec **Docker**, utilisant un point d’entrée automatisé pour gérer l’initialisation de la base de données et l’exécution séquentielle (synchronisation d’abord, puis lancement de l’API Web). Il utilise également **PM2** comme gestionnaire de processus à l’intérieur du conteneur afin d’assurer la disponibilité et la résilience du service web.

## Fonctionnalités
### Tableau de bord web interactif

- Interface web moderne et épurée pour visualiser votre activité musicale.

### Synchronisation automatique des scrobbles Last.fm

- Récupère et stocke périodiquement votre historique d’écoute (scrobbles) depuis Last.fm.
- Garantit que vos données sont toujours à jour sans intervention manuelle.

### Base de données locale de l’historique musical

- Conserve tous les scrobbles dans une base SQLite locale.
- Permet des requêtes rapides et un accès hors ligne à l’historique d’écoute.

### Vue des scrobbles récents

- Affiche vos morceaux les plus récents.
- Logique intelligente de remplacement d’image pour les morceaux, albums et artistes.

### Comparaison avec des amis (vue de compatibilité)

- Comparez vos goûts musicaux avec ceux de vos amis Last.fm.
- Affiche le niveau de compatibilité (Très faible → Super).
- Affiche les artistes, albums et morceaux communs les plus écoutés.
- Calcule et normalise la compatibilité à partir des données d’écoute réelles.

### Cartes musicales partageables

- Génère des images dynamiques basées sur vos données d’écoute.
- Dispositions optimisées pour les publications sur les fils d’actualité et les stories Instagram (9:16)

- Construit à l'aide de node-canvas pour le rendu d'images côté serveur.

## Prérequis

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## Installation

### Créez un fichier `.env`

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---