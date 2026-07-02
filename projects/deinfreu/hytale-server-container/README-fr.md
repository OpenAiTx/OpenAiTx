<div align="center" width="100%">

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Light.png">
  <img alt="Logo Docker Hytale Server" src="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Light.png" width="800">
</picture>

[![GitHub stars](https://img.shields.io/github/stars/deinfreu/hytale-server-container?style=for-the-badge&color=daaa3f)](https://github.com/deinfreu/hytale-server-container)
[![GitHub last commit](https://img.shields.io/github/last-commit/deinfreu/hytale-server-container?style=for-the-badge)](https://github.com/deinfreu/hytale-server-container)
[![Discord](https://img.shields.io/discord/1458149014808821965?style=for-the-badge&label=Discord&labelColor=5865F2)](https://discord.gg/M8yrdnHb32)
[![Docker Pulls](https://img.shields.io/docker/pulls/deinfreu/hytale-server?style=for-the-badge)](https://hub.docker.com/r/deinfreu/hytale-server)
[![Docker Image Size (tag)](https://img.shields.io/docker/image-size/deinfreu/hytale-server/latest-alpine-liberica?sort=date&style=for-the-badge&label=ALPINE%20LIBERICA%20SIZE)](https://hub.docker.com/layers/deinfreu/hytale-server/latest-alpine-liberica/images/)
[![GitHub license](https://img.shields.io/github/license/deinfreu/hytale-server-container?style=for-the-badge)](https://github.com/deinfreu/hytale-server-container/blob/main/LICENSE)

Déployez un serveur dédié Hytale avec une image Docker axée sur la communauté et développée par plus de 10 contributeurs. Ce projet simplifie l’auto-hébergement de Hytale avec des outils intégrés de sécurité, de réseau et de débogage. Rejoignez notre Discord actif pour un support direct et pour connecter avec d’autres propriétaires de serveurs. Que vous testiez des mods ou gériez un monde persistant, ce conteneur offre un environnement cohérent et prêt pour la production en une seule commande.

</div>

## Support & Ressources

* **Documentation :** Optimisations de performance détaillées et spécifications de sécurité sont disponibles dans les [Docs du Projet](https://hytale-server-container.com/?utm_source=github&utm_medium=social&utm_campaign=github_readme).
* **Dépannage :** Consultez la page [support](https://hytale-server-container.com/installation/support//?utm_source=github&utm_medium=social&utm_campaign=github_readme) et notre [Politique de Sécurité](https://raw.githubusercontent.com/deinfreu/hytale-server-container/main/SECURITY.md) avant de signaler des problèmes. Vous pouvez aussi visiter notre [Discord](https://discord.com/invite/2kn2T6zpaV)

## Démarrage rapide

Installez docker [CLI](https://docs.docker.com/engine/install/) sur Linux ou le [GUI](https://docs.docker.com/desktop) sur Windows, macOS et Linux

Vous pouvez lancer le conteneur en exécutant ceci dans votre CLI

```bash
docker run \
  --name hytale-server \
  -e SERVER_IP="0.0.0.0" \
  -e SERVER_PORT="5520" \
  -e PROD="FALSE" \
  -e DEBUG="FALSE" \
  -e TZ="Europe/Amsterdam" \
  -p 5520:5520/udp \
  -v "hytale-server:/home/container" \
  -v "/etc/machine-id:/etc/machine-id:ro" \
  --restart unless-stopped \
  deinfreu/hytale-server:latest
```

Alternativement, vous pouvez déployer en utilisant Docker Compose. Utilisez la configuration ci-dessous ou explorez le dossier [exemples](https://github.com/deinfreu/hytale-server-container/tree/main/examples) pour des modèles plus avancés.

```bash
services:
  hytale:
    image: deinfreu/hytale-server:latest
    container_name: hytale-server
    environment:
      SERVER_IP: "0.0.0.0"
      SERVER_PORT: "5520"
      PROD: "FALSE"
      DEBUG: "FALSE"
      TZ: "Europe/Amsterdam"
    restart: unless-stopped
    ports:
      - "5520:5520/udp"
    volumes:
      - ./data:/home/container
      - /etc/machine-id:/etc/machine-id:ro
    tty: true
    stdin_open: true
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---