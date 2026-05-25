# Sing-box UI

**[English](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/README_EN.md) | 中文**

<div align="center">

[![Docker Image](https://img.shields.io/badge/ghcr.io-singbox__ui-blue?logo=docker)](https://github.com/SpadesA99/singbox_ui/pkgs/container/singbox_ui)
[![Build Status](https://github.com/SpadesA99/singbox_ui/actions/workflows/docker-build.yml/badge.svg)](https://github.com/SpadesA99/singbox_ui/actions)
[![GitHub Stars](https://img.shields.io/github/stars/SpadesA99/singbox_ui?style=flat&logo=github)](https://github.com/SpadesA99/singbox_ui/stargazers)
[![License](https://img.shields.io/github/license/SpadesA99/singbox_ui)](LICENSE)

**Outil moderne de gestion de configuration sing-box**

Construit sur Go 1.24 + Next.js 16, gestion de sing-box via conteneur Docker

</div>

![Capture d'écran de l'interface Sing-box UI](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/docs/zh.png)

---

## Fonctionnalités principales

### Protocoles supportés

| Protocoles entrants | Protocoles sortants | Analyse d’abonnement |
|---------|---------|---------|
| WireGuard | Tous les protocoles entrants | VMess |
| Mixte (Socks5+HTTP) | direct (connexion directe) | VLESS |
| VLESS | block (blocage) | Trojan |
| VMess | | Shadowsocks |
| Trojan | | AnyTLS |
| Shadowsocks | | Format Clash YAML |
| Hysteria2 | | |
| TUIC | | |
| Naive | | |
| ShadowTLS | | |
| AnyTLS | | |
| HTTP | | |

### Gestion des certificats TLS

- **Certificats ACME automatiques** : prise en charge de la demande et du renouvellement automatique avec Let's Encrypt  
- **Certificats manuels** : prise en charge du téléchargement de certificats personnalisés  
- **Support multi-protocoles** : protocoles TLS tels que VLESS, VMess, Trojan, Hysteria2 prennent tous en charge ACME  

### Configuration des règles de routage

- **Modèles rapides** : activation en un clic des règles courantes (blocage de publicité, connexion directe aux IP/domaines chinois, connexion directe aux IP privées)  
- **Ajout rapide de règles** : prise en charge de l’ajout rapide d’IP ou de domaines aux listes de connexion directe/proxy/blocage  
- **Mode connexion directe** : configuration automatique en mode connexion directe en l’absence de sortie proxy  

### Équilibrage de charge

- **Mode URLTest** : sortie basée sur sing-box `urltest`, sélection automatique du nœud avec la latence la plus faible  
- **Tolérance configurable** : personnalisation de la valeur de tolérance de latence (50 ms par défaut), pour éviter les changements fréquents  
- **Pool de nœuds dynamique** : sélection flexible de plusieurs nœuds depuis les abonnements pour former un groupe d’équilibrage de charge  
- **Routage intelligent** : génération automatique des règles de routage pour une distribution intelligente du trafic  

### Gestion multi-instances

- Prise en charge de la création de plusieurs instances sing-box nommées  
- Configuration, démarrage et arrêt indépendants pour chaque instance  
- Journaux de conteneur et surveillance d’état indépendants  

### Gestion VPN WireGuard

- Génération de clés Curve25519  
- Mise en cache des clés liées aux IP  
- Gestion de configuration client (génération en masse, QR code, téléchargement de configuration)  

### Sortie Cloudflare WARP

- **Inscription en un clic** : génération automatique de la paire de clés Curve25519 et appel à l’API d’inscription Cloudflare, mise en cache locale du token de l’appareil, sans configuration manuelle  
- **Lien WARP+** : prise en charge de la saisie de licence pour lier un compte WARP+ et obtenir un trafic illimité  
- **Sélection de point de terminaison** : détection réelle de poignée de main WireGuard — envoi d’un paquet d’init WG au `IP:Port` candidat, vérification de la réponse de 92 octets `MessageResponse`, tri selon le taux de perte + RTT moyen, reflétant précisément la qualité du chemin UDP (implémentation référencée [CloudflareWarpSpeedTest](https://github.com/peanut996/CloudflareWarpSpeedTest))  
- **Scan à large couverture** : 8 segments Cloudflare /24 × 54 ports UDP WARP connus, détection concurrente avec échantillonnage aléatoire, trouvant rapidement le nœud de bord le plus rapide  

### Détection de santé des nœuds

- Détection concurrente asynchrone multi-nœuds  
- Statistiques de taux de réussite en fenêtre glissante  
- Récupération des résultats de détection via API en mode polling  

### Fonctionnalités de gestion  

- Aperçu de configuration (éditeur JSON)  
- Visualisation des journaux du conteneur  
- Surveillance de l'état du conteneur  

---  

## Démarrage rapide  

### Docker Compose (recommandé)  

Créer `docker-compose.yml` :

```yaml
services:
  singbox-ui:
    image: ghcr.io/spadesa99/singbox_ui:latest
    container_name: singbox-ui
    restart: unless-stopped
    network_mode: host
    volumes:
      - /var/run/docker.sock:/var/run/docker.sock
      - ./data:/home/data
    environment:
      - DATA_DIR=/home/data
      - HOST_DATA_DIR=${PWD}/data
      - LISTEN_ADDR=127.0.0.1:7000
      - TZ=Asia/Shanghai
```

```bash
docker compose up -d
```

Accéder à http://127.0.0.1:7000

> **Note** :
> - Utilisez `network_mode: host` pour que le conteneur utilise directement le réseau de l’hôte
> - Écoute par défaut sur `127.0.0.1:7000`, accès local uniquement, personnalisable via la variable d’environnement `LISTEN_ADDR`
> - Montage du Docker Socket pour gérer le conteneur sing-box
> - `HOST_DATA_DIR` est automatiquement mappé depuis `${PWD}` pour le répertoire de données hôte, utilisé par le conteneur sing-box
> - Image sing-box v1.13.5 intégrée, chargée automatiquement au premier démarrage, pas besoin de téléchargement réseau

### Accès distant

Le service écoute par défaut uniquement sur `127.0.0.1`, il est recommandé d’accéder en toute sécurité via un tunnel SSH :

```bash
ssh -L 7000:127.0.0.1:7000 user@your-server
```

Puis, accédez à http://127.0.0.1:7000 dans votre navigateur local

> **Conseil de sécurité** : Il n’est pas recommandé de modifier `LISTEN_ADDR` en `0.0.0.0:7000` pour une exposition directe sur Internet, car le panneau de gestion n’a pas de protection par authentification. Pour un accès externe, utilisez un tunnel SSH ou configurez un proxy inverse avec authentification (par exemple Nginx + Basic Auth).

---

## Variables d’environnement

| Variable | Description | Valeur par défaut |
|----------|-------------|-------------------|
| `DATA_DIR` | Répertoire des données dans le conteneur | `/home/data` |
| `HOST_DATA_DIR` | Répertoire des données sur l’hôte (pour montage dans le conteneur sing-box) | `${PWD}/data` |
| `LISTEN_ADDR` | Adresse d’écoute du service | `127.0.0.1:7000` |
| `TZ` | Fuseau horaire | `Asia/Shanghai` |

---

## Stack technique

| Frontend | Backend |
|----------|---------|
| Next.js 16 | Go 1.24 |
| React 19 | Gin 1.11 |
| Tailwind CSS | Docker SDK |
| shadcn/ui | |

---

## Licence

[Licence MIT](LICENSE)

## Historique des étoiles

[![Graphique de l’historique des étoiles](https://api.star-history.com/svg?repos=SpadesA99/singbox_ui&type=Date)](https://star-history.com/#SpadesA99/singbox_ui&Date)

## Remerciements

- [sing-box](https://github.com/SagerNet/sing-box)
- [Next.js](https://nextjs.org/)
- [Gin](https://github.com/gin-gonic/gin)
- [shadcn/ui](https://ui.shadcn.com/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---