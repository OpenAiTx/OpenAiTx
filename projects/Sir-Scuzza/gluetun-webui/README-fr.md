# Gluetun WebUI

Une interface web légère pour surveiller et contrôler [Gluetun](https://github.com/qdm12/gluetun) — le conteneur client VPN pour Docker.

![Status: Connected](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## Fonctionnalités

- ✨ **Support Multi-VPN** — Surveillez et contrôlez jusqu’à 20 instances Gluetun simultanément
- Bannière de statut VPN en direct (connecté / en pause / déconnecté)
- IP publique de sortie, pays, région, ville et organisation
- Fournisseur VPN, protocole (WireGuard / OpenVPN), détails du serveur
- Transfert de port et statut DNS
- Contrôles Démarrer / Arrêter le VPN
- Actualisation automatique avec intervalle configurable (5s – 60s)
- Derniers 30 ticks de sondage colorés dans la barre d’historique
- Design responsive (mobile, tablette, bureau)

---

## Captures d’écran
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## Prérequis

- Docker + Docker Compose
- Gluetun en fonctionnement avec son serveur de contrôle HTTP activé (port par défaut `8000`)
- Gluetun et gluetun-webui sur le même réseau Docker

> Supporte `linux/amd64` et `linux/arm64` (fonctionne sur Mac Intel/Apple Silicon, Linux, et Windows).

---

## Démarrage rapide

### Option A1 : Instance unique (Recommandé)

Ajoutez `gluetun-webui` à votre fichier compose existant aux côtés de Gluetun :

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    # Uncomment if Gluetun auth is enabled:
    #- GLUETUN_API_KEY=yourtoken
    #- GLUETUN_USER=username
    #- GLUETUN_PASSWORD=password
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
  healthcheck:
    test: ["CMD", "wget", "-qO-", "http://localhost:3000/api/health"]
    interval: 30s
    timeout: 5s
    start_period: 10s
    retries: 3
```

### Option A2 : Instances multiples

Surveillez 2+ instances Gluetun avec des tableaux de bord séparés :

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_1_NAME=VPN - London
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1
    
    - GLUETUN_2_NAME=VPN - Amsterdam  
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2
    
    - GLUETUN_3_NAME=VPN - Singapore
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_API_KEY=token3
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
```

### Option B : Construire localement

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

Puis exécutez (l’une ou l’autre option) :

```bash
docker compose up -d
```

L'interface utilisateur est disponible à **http://localhost:3000**

---

## Configuration Réseau

Gluetun et gluetun-webui doivent être sur le même réseau Docker pour que `http://gluetun:8000` soit correctement résolu.

**Même fichier compose** — ajoutez simplement les deux services au même réseau (le plus courant) :

```yaml
services:
  gluetun:
    networks:
      - arr-stack
  gluetun-webui:
    networks:
      - arr-stack

networks:
  arr-stack:
    driver: bridge
```

**Fichiers de composition séparés** — référencez le réseau existant de Gluetun comme externe. Trouvez le nom de votre réseau avec `docker network ls` :

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## Support Multi-VPN

### Instances Multiples

gluetun-webui prend en charge la surveillance et le contrôle de **plusieurs instances Gluetun simultanément**. Chaque instance s'affiche comme un tableau de bord distinct dans une grille réactive.

**Configuration** : Utilisez des variables d'environnement numérotées :

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    # Instance 1
    - GLUETUN_1_NAME=VPN 1
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1  # optional

    # Instance 2
    - GLUETUN_2_NAME=VPN 2
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2  # optional

    # Instance 3
    - GLUETUN_3_NAME=VPN 3
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_USER=admin
    - GLUETUN_3_PASSWORD=secret  # optional (HTTP Basic auth)
```

**Pris en charge** : Jusqu'à 20 instances (via `GLUETUN_1_URL` à `GLUETUN_20_URL`)  
**Adaptatif** : 1 tableau de bord pleine largeur → 2 demi-largeur → 3 tiers-largeur → 4 quart-largeur → défilement à partir de 5+

### Compatibilité ascendante

Si aucune variable numérotée n'est configurée, retour au **mode mono-instance hérité** :

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### Authentification par instance

Chaque instance peut avoir une authentification différente :

```yaml
# Instance with API key
- GLUETUN_1_API_KEY=my-secret-token

# Instance with HTTP Basic auth
- GLUETUN_2_USER=admin
- GLUETUN_2_PASSWORD=mysecret

# Instance with no auth
- GLUETUN_3_URL=http://gluetun-3:8000  # auth optional
```

---

## Configuration

| Variable | Par défaut | Description |
|---|---|---|
| `GLUETUN_1_*` à `GLUETUN_20_*` | _(vide)_ | **Configuration multi-instance** (jusqu'à 20 instances) |
| `GLUETUN_{N}_URL` | – | URL du serveur de contrôle HTTP Gluetun pour l'instance N |
| `GLUETUN_{N}_NAME` | `Instance {N}` | Nom d'affichage pour l'instance N |
| `GLUETUN_{N}_API_KEY` | _(vide)_ | Jeton Bearer pour l'instance N (si auth activée) |
| `GLUETUN_{N}_USER` | _(vide)_ | Nom d'utilisateur pour l'auth HTTP Basic (instance N) |
| `GLUETUN_{N}_PASSWORD` | _(vide)_ | Mot de passe pour l'auth HTTP Basic (instance N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **Ancien** – une seule instance uniquement (repli si pas de vars `GLUETUN_1_*`) |
| `GLUETUN_API_KEY` | _(vide)_ | **Ancien** – Jeton Bearer pour instance unique |
| `GLUETUN_USER` | _(vide)_ | **Ancien** – Nom d'utilisateur pour auth HTTP Basic |
| `GLUETUN_PASSWORD` | _(vide)_ | **Ancien** – Mot de passe pour auth HTTP Basic |
| `PORT` | `3000` | Port sur lequel l'interface web écoute |
| `TRUST_PROXY` | `false` | Mettre à `true` si utilisé derrière un reverse proxy (nginx, Traefik, etc.) |

---

## Sécurité

- Le port est lié à `127.0.0.1` — non exposé sur le réseau
- Le conteneur s'exécute en non-root avec système de fichiers en lecture seule et capacités réduites
- Limitation de débit appliquée à toutes les routes API
- Les détails des erreurs en amont sont journalisés côté serveur uniquement — messages génériques renvoyés au navigateur

### Configuration du reverse proxy

Si vous exécutez gluetun-webui derrière un reverse proxy (nginx, Traefik, Caddy, etc.), définissez `TRUST_PROXY=true` dans vos variables d'environnement :

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```

Cela permet à l'application d'analyser correctement les en-têtes `X-Forwarded-For` et associés pour une limitation de débit et une détection IP précises. **Remarque :** N'activez cela que si vous êtes réellement derrière un proxy inverse, car cela fait confiance aux en-têtes proxy de votre proxy inverse.

### Authentification du proxy inverse

Les contrôles de démarrage/arrêt du VPN n'ont pas d'authentification intégrée. Si vous exposez l'interface utilisateur au-delà de localhost, placez-la derrière un proxy inverse avec une authentification HTTP Basic.

**Caddy** (`Caddyfile`):
```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
Générez un hash avec : `caddy hash-password`

**Nginx** (`nginx.conf`) :
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
Générez un fichier de mot de passe avec : `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik** (étiquettes Docker) :
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
Générez un hash avec : `htpasswd -nb user password`

---

## Remerciements

- **[Gluetun](https://github.com/qdm12/gluetun)** — Le conteneur client VPN pour lequel cette interface web a été conçue  
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — Excellent outil de surveillance à utiliser avec cette interface web  
- **Développement assisté par IA** — Ce projet a été réalisé avec l’aide de l’IA

---

## Licence

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---