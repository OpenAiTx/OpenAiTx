# Serveur de Projet Davinci Resolve

![Lint](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/lint.yml/badge.svg)
![Healthcheck](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/stack-healthcheck.yml/badge.svg)
![Docker Build](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/docker.yml/badge.svg)

Serveur de projet Resolve simple avec sauvegardes automatiques

## Table des Matières

- [Serveur de Projet Davinci Resolve](#serveur-de-projet-davinci-resolve)
  - [Table des Matières](#table-des-matières)
  - [Introduction](#introduction)
    - [Fonctionnalités](#fonctionnalités)
  - [Configuration](#configuration)
    - [Base de Données](#base-de-données)
    - [Sauvegardes](#sauvegardes)
    - [PGAdmin](#pgadmin)
    - [Emplacements des Volumes](#emplacements-des-volumes)
  - [Installation](#installation)
    - [Installation QNAP](#installation-qnap)
    - [Synology](#synology)
    - [Linux](#linux)
  - [Différentes versions de PostgreSQL](#différentes-versions-de-postgresql)
    - [Configurer un Serveur de Projet PostgreSQL 9.5 ou 11](#configurer-un-serveur-de-projet-postgresql-95-ou-11)
  - [Remerciements](#remerciements)

## Introduction

Il existe de nombreuses façons d’héberger un serveur de projet Resolve, mais chacune présente ses propres problèmes. Le serveur de projet officiel nécessite des sauvegardes manuelles, et d’autres options peuvent être compliquées pour ceux qui n’ont pas accès à une équipe informatique. Espérons que ce soit une solution plus fiable et plus simple pour les petites équipes !

### Fonctionnalités

- **Léger** - Basé sur Docker, ne nécessite donc pas une machine ou VM complète macOS ou Windows.
- **Indépendant de la plateforme** - peut être installé sur Windows, Mac, Linux, QNAP, Synology, RPi, vraiment tout ce qui peut exécuter Docker.
- **Compatible avec les fonctions de sauvegarde/restauration existantes de Resolve** - Tous les fichiers de sauvegarde utilisent la syntaxe standard de fichier \*.backup de Resolve, et peuvent être restaurés depuis l’interface de Resolve
- **Serveur PGAdmin intégré** - PGAdmin est un outil pour administrer un serveur PostgreSQL, utile pour diagnostiquer des problèmes et migrer/mettre à jour des serveurs entiers

## Configuration

Il y a quelques éléments que nous devrons modifier en haut du fichier docker-compose.yml pour configurer notre installation :

```yaml
---
version: "3.8"
x-common:
  database: &db-environment
    POSTGRES_DB: database
    POSTGRES_USER: &pg-user postgres
    POSTGRES_PASSWORD: DaVinci
    TZ: America/Chicago
    POSTGRES_LOCATION: &db-location "???:/var/lib/postgresql/data"
  backup: &backup-environment
    SCHEDULE: "@daily"
    BACKUP_KEEP_DAYS: 7
    BACKUP_KEEP_WEEKS: 4
    BACKUP_KEEP_MONTHS: 6
    BACKUP_LOCATION: &bk-location "???:/backups"
  admin: &admin-environment
    PGADMIN_DEFAULT_EMAIL: admin@admin.com
    PGADMIN_DEFAULT_PASSWORD: root
    PGADMIN_PORT: &pgadmin-port "3001:80"
```

### Base de données

Pour configurer le serveur lui-même, nous devons configurer les variables d'environnement ci-dessous :
| Variable d'environnement |Signification|
|---|---|
| POSTGRES_DB | Nom de votre base de données. Nommez-la comme vous le souhaitez. |
| POSTGRES_USER | Nom d'utilisateur que vous utiliserez pour vous connecter à votre base de données. La valeur par défaut de Resolve est "postgres" |
| POSTGRES_PASSWORD | Mot de passe que vous utiliserez pour vous connecter à votre base de données. La valeur par défaut de Resolve est "DaVinci" |
| TZ | Votre fuseau horaire, voici [une liste](https://fr.wikipedia.org/wiki/Liste_des_fuseaux_horaires)|
| POSTGRES_LOCATION | Emplacement où votre base de données sera stockée. Voir [Emplacements des volumes](#volume-locations) |

### Sauvegardes

Pour configurer les sauvegardes, nous devons configurer les variables ci-dessous :
| Variable d'environnement |Signification|
|---|---|
| SCHEDULE | Ceci est une [chaîne cron](https://www.freeformatter.com/cron-expression-generator-quartz.html) indiquant la fréquence de création des sauvegardes. Peut être "@daily", "@every 1h", etc |
| BACKUP_KEEP_DAYS | Nombre de sauvegardes journalières à conserver avant suppression. |
| BACKUP_KEEP_WEEKS | Nombre de sauvegardes hebdomadaires à conserver avant suppression. |
| BACKUP_KEEP_MONTHS | Nombre de sauvegardes mensuelles à conserver avant suppression. |
| BACKUP_LOCATION | Emplacement où vos sauvegardes seront stockées. Voir [Emplacements des volumes](#volume-locations) |

### PGAdmin

Pour configurer PGAdmin, nous devons configurer les variables ci-dessous :
| Variable d'environnement |Signification|
|---|---|
| PGADMIN_DEFAULT_EMAIL | Email utilisé pour la connexion PGAdmin. Par défaut "admin@admin.com" |
| PGADMIN_DEFAULT_PASSWORD | Mot de passe utilisé pour la connexion PGAdmin. Par défaut "root" |
| PGADMIN_PORT | Chaîne configurant le port d'exposition de PGAdmin. La syntaxe est "VOTRE_PORT:80" |

### Emplacements des volumes

L'emplacement de votre base de données et de vos sauvegardes dépend de la plateforme sur laquelle vous installez. Vous aurez besoin du chemin complet vers le dossier où vous souhaitez les stocker. Sur un NAS QNAP par exemple, si je voulais utiliser un dossier appelé "Backups" dans un dossier partagé nommé "Videos" pour mon emplacement de sauvegarde, le chemin serait `/shares/Videos/Backups/`, et ma valeur `BACKUP_LOCATION` serait la suivante :

```yaml
BACKUP_LOCATION: &bk-location "/shares/Videos/Backups/:/backups"
```

Sur Ubuntu, si je voulais utiliser un dossier nommé "database" dans le répertoire personnel de l'utilisateur nommé "johndoe" pour l'emplacement de ma base de données, le chemin serait `/home/johndoe/database/`, et la valeur de mon `POSTGRES_LOCATION` ressemblerait à ceci :

```yaml
POSTGRES_LOCATION: &db-location "johndoe/database/:/var/lib/postgresql/data"
```
Je recommande de mettre votre base de données sur un SSD, votre vitesse d'accès sera nettement plus lente sur un disque dur classique.

Une fois que vous avez configuré ces paramètres, enregistrez votre fichier docker-compose.yml modifié et passez à l'installation !

## Installation

### Installation QNAP

Installer sur un NAS QNAP est relativement simple. Une remarque, veuillez mettre les fichiers de la base de données sur un SSD. Vous m'en remercierez plus tard.

1. Si vous ne l'avez pas déjà, installez Container Station depuis le magasin d'applications QNAP.
2. Dans Container Station, cliquez sur "Créer", puis cliquez sur "Créer une application"
3. Nommez votre application comme vous le souhaitez (par ex. ResolveServer)
4. Copiez/collez votre fichier docker-compose.yml modifié, cliquez sur "Valider YAML" pour le tester, et s'il passe, cliquez sur "Créer"
5. Container Station téléchargera les fichiers nécessaires et démarrera l'application. Une fois terminé, vous devriez pouvoir connecter Resolve à l'adresse IP de votre QNAP en utilisant le nom de la base de données et les identifiants

### Synology

Voir [cette discussion](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/discussions/15#discussioncomment-4615278)

### Linux

1. Suivez les [instructions d'installation de Docker pour votre distribution Linux](https://docs.docker.com/engine/install/)
2. Installez [Docker Compose](https://docs.docker.com/compose/install/)
3. Déplacez votre fichier docker-compose.yml modifié dans un dossier sur votre machine Linux, puis naviguez vers ce dossier dans le terminal.
4. Exécutez :
   `docker-compose up -d`
5. Docker-compose téléchargera les fichiers nécessaires et démarrera l'application. Une fois terminé, vous devriez pouvoir connecter Resolve à l'adresse IP de votre instance Linux Server en utilisant le nom de la base de données et les identifiants

## Différentes versions de PostgreSQL

En général, Resolve n'est pas très tolérant aux versions de PostgreSQL incompatibles. Resolve 18 utilise PostgreSQL 13, qui est la version par défaut de ce dépôt désormais. Resolve 17 et les versions antérieures utilisent PostgreSQL 9.5. Malheureusement, la version majeure 9.5 est en fin de vie, et la version 9.5.4 en particulier comporte de nombreuses vulnérabilités qui la rendent peu sécurisée.
Comme la plupart des utilisateurs utilisent encore les identifiants par défaut de Resolve pour leur serveur, la sécurité n'est généralement pas la plus grande préoccupation, mais si vous essayez de sécuriser votre serveur de projet avec une ancienne version de Resolve, vous voudrez passer à une version supportée de PostgreSQL.

Resolve 17 et les versions antérieures utilisent encore une fonctionnalité héritée qui a été supprimée dans PostgreSQL 12, donc la dernière version majeure utilisable est la 11, qui sera maintenue jusqu'au 9 novembre 2023.

### Configuration d'un serveur PostgreSQL 9.5 ou 11

Pour configurer un serveur PostgreSQL 9.5 ou 11 au lieu de 13, il faut modifier 2 lignes dans docker_compose.yml :


```yaml
services:
  postgres:
    image: postgres:13
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:13
    ...
...
```
au suivant :


```yaml
services:
  postgres:
    image: postgres:9.5
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:9.5
    ...
...
```

## Merci

-[prodrigestivill](https://github.com/prodrigestivill/) pour son [image docker de sauvegarde PostgreSQL](https://github.com/prodrigestivill/docker-postgres-backup-local)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---