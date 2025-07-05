# TeamSpeak 6 Server - Beta Release README

Bienvenue dans la version bêta du serveur TeamSpeak 6 ! Nous sommes ravis de vous accueillir alors que vous explorez la nouvelle génération de TeamSpeak. Ce document vous guidera dans vos premiers pas et mettra en avant les détails importants concernant la version bêta actuelle.

Comme il s’agit d’une version bêta, certaines fonctionnalités sont encore en développement et vous pourriez rencontrer des bugs. Vos retours sont importants et nous aideront à façonner une version finale plus stable et complète.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;À propos de TeamSpeak</h2>

Éprouvé depuis près de 25 ans, nous proposons une solution adaptée aux besoins de chacun. TeamSpeak offre la communication vocale idéale pour le jeu, l’éducation et la formation, la communication interne en entreprise, ainsi que pour rester en contact avec vos amis et votre famille. Notre priorité est de fournir une solution facile à utiliser, avec des normes de sécurité élevées, une excellente qualité vocale, ainsi qu’une faible utilisation du système et de la bande passante.

## ℹ️ Statut Bêta & Problèmes Connus
**Ceci est une version bêta. L’objectif principal est de recueillir des retours variés et d’identifier les problèmes potentiels avant le lancement de la version stable.**

**Fichiers Serveur Auto-hébergés :** Le logiciel serveur dédié pour TeamSpeak 6 est encore en développement actif et n’est pas encore totalement complet en termes de fonctionnalités. Nous nous engageons à offrir l’expérience TS6 complète pour les serveurs auto-hébergés.

**Instabilité des Fonctionnalités :** Certaines des nouvelles fonctionnalités peuvent être instables ou sujettes à modification pendant que nous continuons à les améliorer.

**Les retours sont essentiels :** Votre expérience nous est précieuse et vos retours sont cruciaux. Merci de signaler tout problème ou de partager vos suggestions sur notre [Forum Communautaire](https://community.teamspeak.com/c/teamspeak-6-server/45) ou directement ici sur [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Limitations :** Veuillez noter que **les licences de serveur TeamSpeak 3 ne sont pas compatibles** avec les serveurs TeamSpeak 6, et qu’il n’existe actuellement **aucun chemin de migration entre les deux versions**.

**Licence de Prévisualisation :** En réponse à vos retours, le serveur est désormais fourni avec une **licence de prévisualisation temporaire** de 32 slots afin d’offrir une plus grande flexibilité durant la période d’évaluation. Notez que cette licence n’est **valable que deux mois**.

De plus, il **n’est pas encore possible d’obtenir ou de mettre à niveau vers une licence plus grande pour TeamSpeak 6**.

Nous vous remercions sincèrement pour votre patience et votre compréhension pendant que nous continuons à travailler sur des solutions pour mieux répondre à vos besoins à l’avenir.

## 👇 Premiers Pas avec TS6
Pour commencer avec le client TeamSpeak 6, veuillez vous rendre sur notre page [Téléchargements](https://teamspeak.com/en/downloads/).

Pour obtenir des informations sur l’auto-hébergement, consultez le guide rapide ci-dessous. Pour les dernières mises à jour, annonces, et pour interagir avec la communauté TeamSpeak, assurez-vous de visiter notre [Forum Communautaire](https://community.teamspeak.com/) et de nous suivre sur [Twitter](https://x.com/teamspeak).

Vous ne souhaitez pas auto-héberger ou souhaitez simplement une solution plus simple pour démarrer avec TeamSpeak 6 ? Vous pouvez louer des serveurs TeamSpeak 6 officiels et fiables directement via [TeamSpeak Communities](https://www.myteamspeak.com/communities).
## ⚙️ Configuration
### Vous pouvez configurer votre serveur de trois manières principales :

1. **Arguments en ligne de commande :** Passez des options directement au lancement du serveur (ex. : ./tsserver --default-voice-port 9987). Ceci est utile pour des modifications temporaires ou pour des scripts.

2. **Variables d’environnement :** Définissez des variables d’environnement avant de démarrer le serveur. Ceci est utile pour Docker ou si vous souhaitez éviter d’encombrer la ligne de commande.

3. **Fichier de configuration YAML :** Pour une configuration persistante, il est fortement recommandé d’utiliser un fichier tsserver.yaml. Vous pouvez générer un fichier de configuration par défaut en utilisant l’option --write-config-file.

Les principaux paramètres que vous pouvez contrôler incluent les ports réseau (voix, transfert de fichiers), les connexions à la base de données (prise en charge de SQLite et MariaDB), les liaisons IP et les options de journalisation.

Pour une liste complète des options disponibles, lancez le serveur avec l’option `--help` ou consultez le fichier [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### Lancer le serveur avec les binaires
Si vous n’utilisez pas Docker, vous pouvez exécuter le serveur directement sur votre système d’exploitation.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Sur Linux :</h2>

Rendez le binaire du serveur exécutable :
```sh
chmod +x tsserver
```

Lancez le serveur depuis votre terminal, en acceptant la licence :

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Sur Windows :</h2>

Ouvrez l’invite de commandes ou PowerShell et accédez au dossier où vous avez extrait les fichiers du serveur.

Lancez l’exécutable du serveur, en acceptant la licence :
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Lancer le serveur avec Docker (recommandé) :</h2>
Docker est la manière la plus simple d’exécuter le serveur TeamSpeak 6 dans un environnement isolé et facile à gérer.

### 1. Commande simple docker run :

Pour un démarrage rapide, vous pouvez utiliser la commande docker run.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Utilisation de docker-compose.yaml (pour une installation persistante) :
C’est la méthode recommandée pour un serveur que vous souhaitez faire fonctionner en continu. Créez un fichier docker-compose.yaml :

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Port Voix
      - "30033:30033/tcp" # Transfert de fichiers
      # - "10080:10080/tcp" # Web Query
    environment:
```
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 Liens Utiles
[Site Officiel](https://teamspeak.com/en/)<br>
[Forum Communautaire](https://community.teamspeak.com)<br>
[Problèmes GitHub](https://github.com/teamspeak/teamspeak6-server/issues)<br>

Votre participation et vos retours nous aideront à façonner l’avenir de TeamSpeak ! 💙<br>
Merci de faire partie du programme bêta de TeamSpeak 6 et de contribuer à son évolution ! 🫡


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---