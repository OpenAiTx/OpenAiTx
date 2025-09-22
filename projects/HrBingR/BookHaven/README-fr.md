# BookHaven

![BookHaven Accueil](https://raw.githubusercontent.com/HrBingR/BookHaven/master/./bookhaven_home.png)

## Table des Matières
1. [Ce que fait l'application](#what-the-application-does)
2. [Fonctionnalités](#features)
3. [Déploiement](#deployment)
   - [Docker](#docker)
   - [Développement](#development)
4. [Compilation de l'application](#building-the-application)
5. [Journal des modifications](#change-log)


## Ce que fait l'application
BookHaven analyse et gère votre bibliothèque locale d’ebooks EPUB, et vous permet de lire et télécharger vos ebooks sur n’importe lequel de vos appareils, avec une interface élégante, moderne et réactive.

## Fonctionnalités
- **Lire des eBooks dans le navigateur**
  Les utilisateurs peuvent accéder et lire leurs eBooks au format EPUB directement sans aucun logiciel supplémentaire.
- **Télécharger des eBooks**
  Téléchargez facilement une copie de n’importe quel eBook de la collection sur votre appareil.
- **Édition non destructive des métadonnées**
  Les modifications des métadonnées des eBooks (par exemple, titre, auteur, série) sont stockées dans la base de données, sans toucher aux fichiers EPUB originaux.
- **Analyse automatique ou manuelle de la bibliothèque**
  Une fois déployée, l’application analysera périodiquement, à un intervalle configurable, votre bibliothèque pour détecter les changements, tout en permettant aussi des analyses manuelles.
- **Page d’accueil avec tri alphabétique**
  Les livres sont triés d’abord alphabétiquement par auteur puis par série, offrant une expérience de navigation propre et intuitive.
- **Recherche puissante**
  La fonction de recherche sur la page d’accueil permet aux utilisateurs de filtrer leur bibliothèque par auteur, titre du livre ou série, facilitant la localisation rapide de contenu spécifique.
- **Filtres**
  Des filtres basiques sont disponibles pour permettre de filtrer les livres marqués comme favoris, comme terminés, ou les livres non marqués comme terminés.
- **Page auteur avec navigation intuitive**
  Une page dédiée aux auteurs organise ceux-ci en une grille alphabétique cliquable. Les utilisateurs peuvent cliquer sur une lettre pour développer la liste des auteurs, naviguer vers la page d’un auteur, et voir ses livres triés alphabétiquement par série et titres indépendants.
- **Support de CloudFlare Access**
  Possède un flag pour contourner l’écran de connexion lors de l’utilisation de CloudFlare Access. Voir `.env.example` pour les détails.
- **Support OIDC**
  Permet la configuration de l’OIDC pour l’enregistrement de nouveaux utilisateurs, ainsi que pour les utilisateurs existants.
- **Support OPDS**
  Utilisez votre lecteur ou application compatible OPDS préféré pour parcourir, télécharger et lire les livres de votre bibliothèque.
- **Téléversements**  
  Les utilisateurs peuvent désormais téléverser des ebooks directement via l'interface utilisateur, avec un formulaire post-téléversement pour corriger les métadonnées.  
- **Support RBAC de base**  
  Les administrateurs peuvent désormais attribuer aux utilisateurs différents rôles avec différents niveaux d'accès.  
- **Demandes de livres**  
  Les utilisateurs peuvent désormais demander des livres spécifiques qu'ils aimeraient voir sur le site. Les administrateurs et éditeurs peuvent consulter et traiter ces demandes une fois les livres téléversés/ajoutés.  

## Déploiement  

### Exigences  

Pour exécuter l'application, vous avez au minimum besoin de :  

- Une base de données (MySQL, SQLite, PostgreSQL)  
- Une instance Redis  

Pour un déploiement rapide et facile, le fichier `.compose.yml.example` définit déjà ces deux éléments.  

### Docker  
Suivez ces étapes pour déployer l'application avec Docker Compose :  
1. **Téléchargez les fichiers de configuration**  
Téléchargez ou clonez le dépôt pour obtenir `compose.yml.example` et `.env.example`.  

2. **Renommez les fichiers exemples**
``` bash
   mv compose.yml.example compose.yml
   mv .env.example .env
```
3. **Personnalisez le fichier `.env`**

Modifiez `.env` pour configurer les paramètres essentiels.

4. **Démarrez l'application**

Exécutez la commande suivante :
``` bash
   docker compose up -d
```
Cela démarre les conteneurs `BookHaven`, Redis et MySQL.  
5. **Accéder à l'application**  

Ouvrez votre navigateur et rendez-vous à l'URL `BASE_URL`:`APP_PORT` que vous avez configurée (par défaut `http://localhost:5000`).  

6. **Arrêter l'application**

``` bash
   docker compose down
```

### Développement
Suivez ces étapes pour déployer en développement :
1. **Cloner le dépôt** :
``` bash
   git clone https://github.com/HrBingR/BookHaven.git
   cd BookHaven
```

2. **Renommez les fichiers d'exemple** :
```bash
   mv compose.exmaple.yml compose.yml
   mv .env.example .env
```

3. **Personnalisez le fichier `.env`** :

Modifiez `.env` pour configurer les paramètres essentiels.

4. **Modifiez le fichier `compose.yml`** :

Changez :

```yaml
    epub-reader:
       image: hrbingr/bookhaven:latest
```

To:

```yaml
  epub-reader:
     build:
        context: .
        dockerfile: Dockerfile
```

5. **Construire le conteneur** :
```bash
   docker compose up --build -d
```

6. **Accéder à l'application** :

Accédez à l'application sur l'`URL_BASE` et le `PORT_APP` définis dans le fichier `.env`.

## Construction de l'application
Pour construire l'application pour la production :
1. **Construire le Frontend** :
``` bash
   cd frontend
   npm run build:dev
```
2. **Construisez l'image Docker** :

Dans le répertoire racine du projet (BookHaven), exécutez :
``` bash
   docker build -t tag:version .
```
Remplacez `tag:version` par le nom et la version d’image de votre choix (par exemple, `bookhaven:1.0.0`).

## Journal des modifications :

Pour un journal des modifications détaillé, voir [CHANGELOG](https://raw.githubusercontent.com/HrBingR/BookHaven/master/CHANGELOG.md)

- v1.0.x
  - Première version
- v1.1.0 - v1.1.1
  - Ajout du support OIDC
  - Correction d’un bug où les composants front-end OIDC s’affichaient encore avec OIDC désactivé.
- v1.2.0 - v1.2.2
  - Ajout du support pour écrire optionnellement les métadonnées dans le fichier ePub, au lieu de seulement dans la base de données.
  - Correction d’un problème où Celery détectait PERIODIC_SCAN_INTERVAL, si défini explicitement, comme une chaîne de caractères et levait une exception.
  - Correction de la logique de migration et du modèle BD qui empêchait les utilisateurs Postgres d’initialiser la base de données avec succès.
- v1.3.0 - v1.3.5
  - Ajout d’un support rudimentaire OPDS.
  - Amélioration des fonctionnalités OPDS.
  - Correction de problèmes d’interface sur la page Auteurs
  - Correction de certains problèmes UX liés au défilement sur la page d’accueil
  - Amélioration du chargement des images de couverture sur le front-end
  - Augmentation de la limite par défaut du taux d’API et rendu personnalisable
  - Implémentation d’un verrouillage pour le processus de scan afin d’assurer qu’un seul scan s’exécute à la fois
  - Amélioration de la composante BD de la logique de scan
  - Correction de l’affichage des listes d’auteurs développées sur mobile sur la page « Auteurs »
  - Mise à jour de la logique de scan - la bibliothèque sera maintenant automatiquement scannée au démarrage
- v1.4.0 - v1.4.1
  - Ajout de la fonctionnalité Upload - consultez .env.example pour savoir comment l’activer et l’utiliser
  - Mise à jour des identifiants de repli du scanner de chemins relatifs à noms de fichiers
  - Création d’une migration pour mettre à jour les identifiants de repli existants
  - Passage de gunicorn sync à gunicorn gthread pour de meilleures performances d’upload
  - Correction des imports de tâches celery pour les scans planifiés
  - Correction du masquage du bouton d’upload lorsque la fonctionnalité upload est désactivée
- v1.5.0 - v1.5.2
  - Ajout d’un contrôle d’accès basé sur les rôles (RBAC). Les administrateurs peuvent désormais attribuer aux utilisateurs différents rôles comme suit :
    - Utilisateur : Accès à toutes les fonctionnalités de base sauf les uploads, la modification des métadonnées et la gestion des utilisateurs.
    - Éditeur : Inclut l’accès aux uploads et à la modification des métadonnées.
    - Administrateur : Inclut l’accès à la gestion des autres utilisateurs.
  - Amélioration de la logique de connexion via Cloudflare Access.
  - Correction d’un bug mineur affectant des colonnes héritées qui n’avaient jamais été supprimées.
  - Rendu le script de migration plus résilient.
- v.1.6.0
  - Ajout de la fonctionnalité de demandes pour que les utilisateurs puissent demander l'ajout de nouveaux livres sur le site.

## À FAIRE :

- Mettre à jour les tests avec les dernières additions
- Explorer la prise en charge d'autres formats
- Explorer l'ajout de plus de champs de métadonnées pour l'édition

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---