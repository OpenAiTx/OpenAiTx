# ARGOS — Bêta
<img align="right" width="86" height="150" src="https://github.com/SOsintOps/Argos/blob/master/multimedia/images/scribblenauts-argos.png">

> **AVERTISSEMENT : VERSION BÊTA**
> Ce script a été mis à jour pour Ubuntu 24.04 LTS et Ubuntu Budgie 24.04 LTS.
> Il est en cours de test actif. Exécutez-le toujours sur une VM propre avant de l’utiliser en production.
> Signalez tout problème en ouvrant un ticket.

Argos configure automatiquement une station de travail OSINT open-source à partir d’une machine virtuelle Ubuntu 24.04 LTS propre.

La meilleure pratique recommande d’utiliser une VM dédiée pour chaque enquête OSINT.
Ce script suit les méthodes décrites par Michael Bazzell dans [Open Source Intelligence Techniques](https://inteltechniques.com/book1.html).

## Contenu
- [Exigences](#requirements)
- [Outils](#tools)
- [Installation](#installation)
- [Journal d’installation](#installation-log)
- [À faire](#to-do)
- [Ressources](#resources)
- [Crédits](#credits)
- [Licences](#licences)
- [Historique des versions](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/VERSION_HISTORY.md)
- [Directives d’analyse OSINT](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/guidelines.md)
- [FAQ](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/faq.md)

---

## Exigences

- Ubuntu **24.04 LTS** ou **Ubuntu Budgie 24.04 LTS** (VM ou station de travail)
- N’importe quel nom d’utilisateur Linux (l’exigence précédente d’utiliser `osint` a été supprimée)
- Langue système : **Anglais**
- Connexion internet active pendant l’installation
- **Additions invité VirtualBox déjà installées** — le script ne les installe pas. Installez les Additions invité avant d’exécuter `setup.sh` pour activer le partage du presse-papiers, le glisser-déposer et le mode plein écran.

> Le script est optimisé pour VirtualBox. Le code pour VMware Tools est disponible dans les commentaires.

**Testé sur :**
- Ubuntu Budgie 24.04 LTS (VM)
- Ubuntu 24.04 LTS (VM)

**Plus pris en charge :**
- Ubuntu 22.04 LTS (certaines dépendances sont incompatibles)
- Ubuntu 20.04 LTS

---

## Outils

### OSINT

| Outil | Statut | Remarques |
|-------|--------|-----------|
| [Amass](https://github.com/owasp-amass/amass) | Actif | Énumération de sous-domaines |
| [Instaloader](https://instaloader.github.io/) | Actif | OSINT Instagram |
| [Toutatis](https://github.com/megadose/toutatis) | Limité | Nécessite l’ID de session Instagram |
| [HTTrack](https://www.httrack.com/) | Actif | Exploration et miroir web |
| [MediaInfo](https://mediaarea.net/en/MediaInfo) | Actif | Analyse des métadonnées médias |
| [ExifTool](https://exiftool.org/) | Actif | Métadonnées de documents et images |
| [EyeWitness](https://github.com/FortyNorthSecurity/EyeWitness) | Actif | Captures d’écran de sites web |
| [The Harvester](https://github.com/laramies/theHarvester) | Actif | Reconnaissance d’emails et domaines |
| [Metagoofil](https://github.com/opsdisk/metagoofil) | Actif | Métadonnées de documents publics |
| [recon-ng](https://github.com/lanmaster53/recon-ng) | Actif | Framework OSINT modulaire |
| [Sherlock](https://github.com/sherlock-project/sherlock) | Actif | Recherche de noms d’utilisateur |
| [SpiderFoot](https://github.com/smicallef/spiderfoot) | Actif | Automatisation OSINT |
| [blackbird](https://github.com/p1ngul1n0/blackbird) | Actif | Recherche avancée de noms d’utilisateur |
| [holehe](https://github.com/megadose/holehe) | Actif | OSINT email |
| [maigret](https://github.com/soxoj/maigret) | Actif | Recherche de noms d’utilisateur (fork avancé de Sherlock) |
| [Maltego](https://www.maltego.com/) | Actif | Analyse de liens (compte requis) |
| [yt-dlp](https://github.com/yt-dlp/yt-dlp) | Actif | Téléchargeur vidéo (remplace youtube-dl) |

**Outils retirés (abandonnés ou arrêtés) :**
- ~~Instalooter~~ : utiliser Instaloader
- ~~Sublist3r~~ : utiliser Amass
- ~~Photon~~ : utiliser Katana ou GoSpider
- ~~youtube-dl~~ : remplacé par yt-dlp
- ~~Moriarty-Project~~ : utiliser PhoneInfoga
- ~~Elasticsearch-Crawler~~ : utiliser Shodan CLI
- ~~Atom Editor~~ (arrêté en décembre 2022) : remplacé par VSCodium

### Outils Généraux

| Outil | Statut |
|------|--------|
| [VLC](https://www.videolan.org/vlc/) | Actif |
| [Google Earth Pro](https://www.google.com/earth/versions/#earth-pro) | Actif |
| [VSCodium](https://vscodium.com/) | Actif (remplace Atom) |
| [CherryTree](https://www.giuspen.com/cherrytree/) | Actif |
| [KeePassXC](https://keepassxc.org/) | Actif |
| [Kazam](https://launchpad.net/kazam) | Actif |
| [Audacity](https://www.audacityteam.org/) | Actif |
| [Tor Browser](https://www.torproject.org/) | Actif |
| [OpenShot](https://www.openshot.org/) | Actif |
| [Obsidian](https://obsidian.md/) | Actif (dernière version récupérée dynamiquement) |
| [Ripgrep](https://github.com/BurntSushi/ripgrep) | Actif |
| [Ressources de renseignement sur les menaces](https://github.com/pstirparo/threatintel-resources) | Actif |

---

## Installation

1. Ouvrez un terminal.

2. Installez Git s'il n'est pas déjà présent :
    ```bash
    sudo apt install -y git
    ```

3. Clonez le dépôt dans le répertoire `Téléchargements` :
    ```bash
    git clone https://github.com/SOsintOps/Argos ~/Downloads/Argos
    ```
4. Rendez le script exécutable :

    ```bash
    chmod +x ~/Downloads/Argos/setup.sh
    ```

5. Exécutez le script :
    ```bash
    ~/Downloads/Argos/setup.sh
    ```

    > Firefox n’a pas besoin d’être fermé ou ouvert manuellement. Le script initialise automatiquement le profil Firefox s’il n’a pas encore été créé.

---

## Journal d’installation

Le script génère automatiquement un fichier journal dans le répertoire Téléchargements :

```
~/Downloads/argos_install_YYYYMMDD_HHMMSS.log
```

Le journal contient la sortie complète de l'installation avec les horodatages. En cas d'erreur, le numéro de ligne exact est enregistré dans le journal.

---

## À Faire

- Ajouter PhoneInfoga en remplacement de Moriarty-Project
- Ajouter Katana ou GoSpider en remplacement de Photon
- Mettre à jour les modèles de rapports LibreOffice pour les enquêtes OSINT
- Effectuer des tests de bout en bout sur une VM Ubuntu Budgie 24.04 LTS
- Ajouter des raccourcis pour holehe, maigret autonome, et blackbird autonome

---

## Ressources

- [Site web OSIntOps](https://osintops.com/en/)
- [Présentation du projet Argos (Italien)](https://osintops.com/progetto-argos/)
- [OSInt Daily News](https://t.me/Osintlatestnews)
- [Techniques d’intelligence open source par Michael Bazzell](https://inteltechniques.com/book1.html)

---

## Crédits

- Skykn0t pour le script original OSINT_VM_Setup
- [oh6hay](https://github.com/oh6hay) pour le nom du script
- [pinkevilpimp](https://github.com/pinkevilpimp) pour le script du fond d’écran

---

## Licences

Voir les fichiers de licence inclus dans le dépôt.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---