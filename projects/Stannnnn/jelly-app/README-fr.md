## Jelly Music App (JMA)

Une interface musicale légère et élégante pour Jellyfin. Conçue pour être intuitive et minimaliste avec une grande attention aux détails, une application web épurée centrée sur la lecture musicale. Utilisant l'API Jellyfin, elle offre un accès fluide à votre bibliothèque musicale personnelle. [Démo](https://stannnnn.github.io/jelly-app/login?demo=1)

**Vous cherchez un lecteur vidéo ?** Découvrez [Jelly Video App](https://github.com/Stannnnn/jelly-video-app/) - la version axée sur la vidéo pour votre bibliothèque Jellyfin !

<br/>

<div>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/light-variant.webp" alt="Variante claire" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/dark-variant.webp" alt="Variante sombre" width="49%">
</div>
<br/>

<details>
  <summary>Captures d'écran supplémentaires</summary>
  <br/>
  <b>Recherche dans la barre latérale</b>
  <p>Recherchez des morceaux, artistes, albums, playlists, genres</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-light-variant.png" alt="Recherche dans la barre latérale variante claire" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-dark-variant.png" alt="Recherche dans la barre latérale variante sombre" width="49%">
  <br/>
  <br/>
  <b>Résultats de recherche</b>
  <p>Voir des résultats de recherche supplémentaires dans une fenêtre dédiée</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-light-variant.webp" alt="Résultats de recherche variante claire" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-dark-variant.webp" alt="Résultats de recherche variante sombre" width="49%">
  <br/>
  <br/>
  <b>Artistes</b>
  <p>Présente les chansons les plus jouées, albums et autres collaborations</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-light-variant.webp" alt="Artiste variante claire" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-dark-variant.webp" alt="Artiste variante sombre" width="49%">
  <br/>
  <br/>
  <b>Playlists</b>
  <p>Vue des playlists, avec sa propre liste de morceaux numérotée</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-light-variant.webp" alt="Playlist variante claire" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-dark-variant.webp" alt="Playlist variante sombre" width="49%">
</details>
### Fonctionnalités

- **Design élégant et simple :** Une interface épurée et sans encombrement qui rend la lecture de musique facile et agréable. Construit avec des outils modernes comme React pour une expérience rapide et fiable.
- **Compatible appareils :** Profitez d’une expérience fluide, semblable à une application, sur mobile et bureau, installable en tant que PWA pour un accès instantané.
- **Accès fluide à la bibliothèque :** Connectez-vous à votre serveur Jellyfin pour explorer facilement votre collection musicale personnelle.
- **Découvrez vos favoris :**
    - **Accueil :** Reprenez rapidement avec les morceaux récemment joués, vos favoris les plus écoutés et les médias nouvellement ajoutés.
    - **Artistes :** Parcourez les meilleurs morceaux, albums et collaborations pour tout artiste de votre bibliothèque.
    - **Playlists :** Visualisez les playlists avec une liste de pistes claire et numérotée pour une navigation rapide.
    - **Recherche rapide :** Trouvez facilement morceaux, artistes, albums, playlists ou genres via une recherche dans la barre latérale ou une page de résultats dédiée.
    - **Mix instantané :** Profitez de playlists sélectionnées directement depuis votre bibliothèque musicale sur une page autonome.
- **File d’attente :** Gérez et réorganisez aisément les pistes grâce à la fonctionnalité améliorée et optimisée de la file d’attente.
- **Fondu enchaîné :** Transition fluide entre les morceaux pour une expérience d’écoute immersive et continue.
- **Préchargement :** Précharge intelligemment la piste suivante à l’avance pour garantir une lecture fluide et ininterrompue sans temps de buffering.
- **Paroles synchronisées :** Appréciez vos chansons préférées d’une nouvelle manière avec une interface spectaculaire affichant les paroles parfaitement synchronisées, ligne par ligne, au fur et à mesure de l’écoute.
- **Récupération intelligente :** Met en cache votre musique efficacement pour une lecture instantanée et fluide.
- **Synchronisation hors ligne :** Téléchargez des chansons individuelles, albums complets, playlists ou artistes pour une lecture hors ligne.
    - **Synchronisation automatique :** Télécharge automatiquement les morceaux nouvellement ajoutés à toute playlist, album ou artiste déjà sauvegardé.
    - **File d’attente persistante :** Les téléchargements sont gérés via une file d’attente locale qui reprend parfaitement entre les sessions.
    - **Flux transcodés ou directs :** Supporte les téléchargements en qualité originale ou transcodée selon le débit sélectionné.
- **Support Docker :** Téléchargez et déployez l’application avec une image Docker préconstruite incluant une URL serveur Jellyfin préconfigurée pour un auto-hébergement sans accroc.

### Installation

L’application Jelly Music peut être installée en tant qu’application de bureau dédiée, disponible sur notre [page de release GitHub](https://github.com/Stannnnn/jelly-app/releases). Vous pouvez également obtenir la dernière version stable à partir de là et la déployer sur votre serveur web en plaçant le contenu du dossier archivé dans un répertoire accessible via le web.
<br/>
Elle est aussi disponible en **image docker** pour un déploiement facile, voir les détails docker ci-dessous.
<br/>
<br/>

[Yarn](https://classic.yarnpkg.com/lang/en/docs/install) (`npm i -g yarn`) est requis si vous souhaitez construire le projet ou exécuter le serveur de développement vous-même.

#### Construire depuis la source

1. Clonez le dépôt :

    ```bash
    git clone https://github.com/Stannnnn/jelly-app.git
    ```
2. Installer les dépendances :
    ```bash
    yarn
    ```
3. Construisez les fichiers de production :
    ```bash
    yarn build
    ```
4. Déployez le contenu du dossier `dist` dans un répertoire accessible via le web.

Alternativement, vous pouvez lancer le serveur de développement directement : `yarn dev` ou `yarn dev:nocache`

Si vous souhaitez utiliser un chemin de base pour l'application autre que la racine (`/`), vous devez la construire manuellement en définissant `URL_BASE_PATH` sur le chemin de base souhaité.

Laissez la configuration par défaut, ou modifiez [`config.json`](https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/config.json) selon vos besoins. Les configurations sont expliquées dans la [section Configuration de l'Application](#app-configuration).
Le fichier `config.json` peut être modifié directement dans l'application construite par la suite. Il n'est pas nécessaire de reconstruire si vous ne changez qu'une variable de configuration.

### Docker

Vous pouvez facilement héberger Jelly Music App en utilisant Docker avec l'image préconstruite depuis ghcr.io :

#### Récupérer l'image docker

```bash
docker pull ghcr.io/stannnnn/jelly-music-app:latest
```

#### Exécuter l'image docker

```bash
docker run --rm -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```

L'image Docker peut également être exécutée en arrière-plan en ajoutant l'option -d `docker run -d ...`

#### Exécuter l'image docker avec des variables de configuration

```bash
docker run --rm \
    -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
    -e LOCK_JELLYFIN_URL=false \
    -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```
<br/>

Voici les tags disponibles pour docker :

| Tag    | Description                |
| ------ | -------------------------- |
| latest | Suit la version la plus récente |
| main   | Suit la branche principale     |
| vX.X.X | Tags spécifiques à une version  |

Exemple : `ghcr.io/stannnnn/jelly-music-app:latest`

#### Construction du conteneur Docker

Vous pouvez également construire Jelly Music App en utilisant Docker.

1.  Construisez l’image Docker :


    ```bash
    docker build . --tag jelly-music-app
    ```

2.  Exécutez le conteneur Docker :

    ```bash
    docker run --rm -p 80:80 jelly-music-app:latest
    ```

    Vous pouvez également fournir la configuration en utilisant des variables d'environnement.

    ```bash
    docker run --rm \
        -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
        -e LOCK_JELLYFIN_URL=false \
        -p 80:80 jelly-music-app:latest
    ```

#### Docker Compose

Pour une gestion plus facile des conteneurs, vous pouvez utiliser Docker Compose. Un fichier `docker-compose.yaml` est fourni dans le dépôt avec des paramètres par défaut raisonnables.

1.  Copiez le fichier d'exemple d'environnement et personnalisez-le pour votre configuration :

    ```bash
    cp .env.example .env
    ```

2.  Modifiez le fichier `.env` avec l'URL de votre serveur Jellyfin et vos préférences :

    ```env
    JELLYAPP_PORT=80
    JELLYAPP_DEFAULT_URL=https://demo.jellyfin.org/stable
    JELLYAPP_LOCK_URL=true
    ```

3.  Démarrez le conteneur en utilisant Docker Compose :

    ```bash
    docker-compose up -d
    ```

Le fichier `docker-compose.yaml` utilise des variables d'environnement avec les valeurs par défaut suivantes :

- `JELLYAPP_PORT` : Port externe à exposer (par défaut : `80`)
- `JELLYAPP_DEFAULT_URL` : URL par défaut du serveur Jellyfin (par défaut : `https://demo.jellyfin.org/stable`)
- `JELLYAPP_LOCK_URL` : Verrouille le champ de saisie de l'URL Jellyfin (par défaut : `false`)

### Configuration de l'application

La configuration de l'application peut être modifiée en éditant le fichier `config.json` lors du processus de build ou dans les fichiers de release. Lors de l'utilisation de Docker, les configurations peuvent être fournies sous forme de variables d'environnement. Les options de configuration disponibles sont les suivantes :

- `DEFAULT_JELLYFIN_URL` : Définit l'URL par défaut du serveur Jellyfin chargée lors du premier accès à l'application si aucune URL n'est stockée dans le stockage local.
- `LOCK_JELLYFIN_URL` : Si défini à `true`, supprime le champ de saisie de l'URL et impose l'URL par défaut (`DEFAULT_JELLYFIN_URL`) pour toutes les connexions, idéal pour les instances auto-hébergées liées à un seul serveur.

### Contribution

Nous sommes ouverts aux pull requests, veuillez les fusionner dans la branche `develop`. Si vous avez des suggestions ou des améliorations, n'hésitez pas à ouvrir un ticket ou à soumettre une pull request. Vos contributions sont les bienvenues et appréciées !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-21

---