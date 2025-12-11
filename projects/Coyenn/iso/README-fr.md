<div align="center">
  <a href="https://iso.tim.cv/" target="_blank">
    <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-dashboard-bg-image.png" alt="Capture d'écran du tableau de bord Iso" width="800" />
  </a>
</div>

<br />
<div align="center">
  <a href="https://iso.tim.cv" target="_blank">Démo</a>
  |
  <a href="https://hub.docker.com/r/coyann/iso" target="_blank">Docker</a>
  |
  <a href="https://github.com/Coyenn/iso/" target="_blank">GitHub</a>
</div>
<br />

**Iso** est un tableau de bord plug-and-play pour tous vos services auto-hébergés.
Conçu pour mon homelab personnel — désormais open source pour le vôtre.

- **Entièrement configurable** via un seul fichier `config.json`
- **Multilingue** : Anglais, Español, Français, Deutsch
- **Prêt pour les icônes** : choisissez parmi un ensemble d’icônes intégrées ou fournissez les vôtres
- **Docker-first** : exécutez partout avec une seule commande simple

## ‍️Démarrage rapide

### Docker

```bash
docker run -d \
  --name iso \
  -p 3000:3000 \
  -e AUTH_SECRET="changeme" \
  -e AUTH_PASSWORD="changeme" \
  -v ./config:/config \
  coyann/iso
```

### Docker Compose

```yaml
services:
  iso:
    image: coyann/iso:latest
    container_name: iso
    ports:
      - "3000:3000"
    environment:
      - AUTH_SECRET=changeme
      - AUTH_PASSWORD=changeme
    volumes:
      - ./config:/config
    restart: unless-stopped
```

Ouvrez http://localhost:3000 et vous êtes prêt à démarrer !

## Configuration

Iso est configuré via un seul fichier `config.json` situé dans le répertoire `/config`.

### Exemple de configuration

```json
{
  "title": "My Dashboard",
  "services": [
    {
      "order": 1,
      "icon": "tv",
      "label": "Plex",
      "href": "https://plex.example.com"
    },
    {
      "order": 2,
      "icon": "lock",
      "label": "Bitwarden",
      "href": "https://vault.example.com"
    }
  ],
  "locale": "en",
  "theme": "amethyst",
  "greetings": [],
  "pageLoadAnimation": true,
  "search": {
    "enabled": true,
    "engine": "google",
    "engineUrl": "",
    "placeholder": "Search ..."
  }
}
```

### Options de Configuration

- **title** : Titre du tableau de bord affiché dans l’en-tête
- **services** : Tableau d’objets de service avec :
  - `order` : Ordre d’affichage (nombre)
  - `icon` : Nom de l’icône dans l’ensemble intégré
  - `label` : Nom d’affichage du service
  - `href` : URL du service
- **locale** : Code de langue (`en`, `es`, `fr`, `de`)
- **theme** : Thème de couleur (par ex. `amethyst`)
- **greetings** : Messages de bienvenue personnalisés
- **pageLoadAnimation** : Activer/désactiver les animations de page
- **search** : Objet contenant les paramètres de la barre de recherche
  - `enabled` : Activer ou non la visibilité de la barre de recherche
  - `engine` : Moteur de recherche intégré (`google`, `bing`, `duckduckgo`, `startpage`, `qwant`, `searx`, ou `custom`)
  - `engineUrl` : URL du moteur de recherche personnalisé. Utilisez `[q]` comme espace réservé pour la requête.
  - `placeholder` : Texte d’espace réservé affiché dans la barre de recherche

## Variables d’Environnement

| Variable | Description | Par défaut | Obligatoire |
|----------|-------------|------------|-------------|
| `AUTH_SECRET` | Clé secrète pour l’authentification | - | Non |
| `AUTH_PASSWORD` | Mot de passe pour l’accès au tableau de bord | - | Non |
| `APP_DATA_PATH` | Chemin vers le répertoire de configuration | `/config` | Non |

## Plus de Captures d’Écran

<div style="display: flex;">
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-settings.png" alt="Capture d’écran des paramètres Iso" width="400" style="width: 49%;" />
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-login.png" alt="Capture d’écran de la connexion Iso" width="400" style="width: 49%;" />
</div>

## Développement

### Prérequis

- Nix

Ou

- Le runtime JavaScript [Bun](https://bun.sh/)

### Configuration locale

1. Clonez le dépôt :
```bash
git clone https://github.com/Coyenn/iso.git
cd iso
```

2. Installer les dépendances :
```bash
bun install
```

3. Démarrez le serveur de développement :
```bash
bun dev
```

4. Ouvrez http://localhost:3000 dans votre navigateur

## Licence

Distribué sous la licence MIT. Voir `LICENSE` pour plus d'informations.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---