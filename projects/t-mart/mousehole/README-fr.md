# Mousehole, un Met à Jour d’IP de Seedbox pour MAM

Un service en arrière-plan pour mettre à jour l’IP d’une seedbox pour MAM et un serveur HTTP pour la gérer.

![Mousehole Demo](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/demo.webp)

Cela peut être utile si vous utilisez un hôte/VPN/seedbox pour le seed et que son adresse IP
n’est pas stable.

Fonctionnalités :

- Service en arrière-plan qui met régulièrement à jour MAM avec l’adresse IP de l’hôte.

  Avant une mise à jour, Mousehole vérifie qu’elle est réellement nécessaire en
  comparant l’adresse IP actuelle de l’hôte et l’AS avec la dernière réponse de MAM.

- Site web frontal pour gérer le service, permettant :

  - De définir votre cookie MAM
  - D’afficher les informations de statut
  - De déclencher manuellement des vérifications

- Serveur API avec points d’accès de gestion.

  Voir [API.md](https://github.com/t-mart/mousehole/blob/master/docs/API.md) pour
  les détails.

## Pour Commencer

Pour utiliser Mousehole, vous devez :

1. [Lancer le service](#running-the-service)
2. [Définir votre cookie MAM via l’interface web](#setting-your-mam-cookie)
3. [Gérer les erreurs MAM](#handling-errors) (le cas échéant)

### Lancer le service

#### Docker Compose (recommandé)


```yaml
services:
  gluetun:
    image: qmcgaw/gluetun:latest
    cap_add:
      - NET_ADMIN
    devices:
      - /dev/net/tun:/dev/net/tun
    ports:
      - "5010:5010" # Mousehole port
      - "8080:8080" # qBittorrent Web UI port
      - "6881:6881/tcp" # qBittorrent TCP torrent port
      - "6881:6881/udp" # qBittorrent UDP torrent port
    environment:
      VPN_SERVICE_PROVIDER: "your-vpn-provider"
      FIREWALL_VPN_INPUT_PORTS: "6881" # qBittorrent torrent
      # more is needed here -- see Gluetun documentation
      # https://github.com/qdm12/gluetun-wiki
      # https://github.com/qdm12/gluetun-wiki/tree/main/setup/providers
    restart: unless-stopped

  qbittorrent:
    image: lscr.io/linuxserver/qbittorrent:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
      WEBUI_PORT: 8080
      TORRENTING_PORT: 6881
    restart: unless-stopped

  mousehole:
    image: tmmrtn/mousehole:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
    volumes:
      # persist cookie data across container restarts
      - "mousehole:/srv/mousehole"
    restart: unless-stopped

volumes:
  mousehole:
```
Exemples de démarrage Docker Compose :

- ⭐ [Gluetun + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/gluetun-qb.md)
- [Wireguard + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/wireguard-qb.md)
- [Exemple sans VPN](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/non-vpn.md)

Toute configuration VPN peut être adaptée pour inclure Mousehole en tant que sidecar. Voir
[Utiliser Mousehole en tant que Sidecar avec Docker Compose](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/sidecars.md) pour
plus de détails.

#### Unraid

Voir le [Guide d’installation Unraid](https://raw.githubusercontent.com/t-mart/mousehole/master/./contrib/unraid/README.md) pour
les instructions.

#### Local

Lancer le serveur avec :



```bash
bun run start
```

### Configuration de votre cookie MAM

Une fois Mousehole en fonctionnement, accédez à son interface web à `http://<host>:5010` dans
votre navigateur. Il s'agit probablement de <http://localhost:5010> si vous l'exécutez
localement.

Lors de la première exécution (ou si le cookie est désynchronisé), vous devez
configurer manuellement le cookie de Mousehole.

En accédant à l'interface web de Mousehole, vous verrez un formulaire pour définir le
cookie -- collez votre cookie et cliquez sur le bouton "Set".

![Formulaire de cookie Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/cookie-form.png)

Si vous avez besoin d'aide pour obtenir le cookie, cliquez sur le bouton "Que dois-je entrer ici ?"
pour un tutoriel.


### Gestion des erreurs

Même avec Mousehole en marche, des problèmes peuvent survenir que Mousehole
ne peut pas corriger automatiquement. En voici quelques-uns courants :

- ["Session invalide - ASN non concordant"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/asn-mismatch.md)
- ["Session invalide - Cookie invalide"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/invalid-cookie.md)
- ["Dernier changement trop récent"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/last-change-too-recent.md)

## Tags Docker

Mousehole publie plusieurs tags d’image sur
[Docker Hub](https://hub.docker.com/r/tmmrtn/mousehole) :

- Versions SemVer (`0`, `0.1`, `0.1.11`, etc.)
- `latest`, la dernière version publiée
- `edge`, la pointe de la branche `master`
- Pull requests ciblant `master` pour tests, taguées comme `pr-<number>`

Choisissez `latest` si vous ne savez pas quoi choisir.

## Variables d'environnement

- `MOUSEHOLE_PORT` : _(Par défaut `5010`)_ Le port sur lequel le serveur HTTP écoutera.
- `MOUSEHOLE_STATE_DIR_PATH` : _(Par défaut `/srv/mousehole`)_ Le répertoire où le service stockera ses données.
- `MOUSEHOLE_USER_AGENT` : _(Par défaut `mousehole-by-timtimtim/<version>`)_ L’agent utilisateur à utiliser pour les requêtes vers MAM.
- `MOUSEHOLE_CHECK_INTERVAL_SECONDS` : _(Par défaut `300` (5 minutes))_ L’intervalle en secondes entre les vérifications.
- `MOUSEHOLE_STALE_RESPONSE_SECONDS` : _(Par défaut `86400` (1 jour))_ Le nombre de secondes après lequel une réponse MAM est considérée comme périmée. Cela garantit que Mousehole communique toujours avec MAM à intervalles réguliers et détecte les modifications hors bande du cookie.
- `TZ` : _(Par défaut `Etc/UTC`)_ Le fuseau horaire pour l’affichage des heures localisées.

## Contribution

Vous souhaitez contribuer ? Consultez les [directives de contribution](https://raw.githubusercontent.com/t-mart/mousehole/master/./CONTRIBUTING.md).

Il y a également un répertoire [`contrib`](./contrib/) avec des fonctionnalités utiles et supplémentaires.

## Liens

- [Dépôt](https://github.com/t-mart/mousehole)
- [Image Docker Hub](https://hub.docker.com/r/tmmrtn/mousehole)
- [Message sur le forum](https://www.myanonamouse.net/f/t/84712/p/p1013257)

## Développement

- Lancez le serveur de développement avec :









  ```bash
  bun run dev
  ```
- De nouvelles versions peuvent être taguées, publiées et poussées sur Docker Hub en
  modifiant simplement la version dans `package.json` et en poussant sur GitHub. Les
  workflows CI s’occuperont du reste.

## Attribution

Mouse Hole par Sergey Demushkin de
[Noun Project](https://thenounproject.com/term/mouse-hole/) (CC BY 3.0)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---