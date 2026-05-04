<p align="center">
  <a href="https://turborepo.com/" target="blank"><img src="https://user-images.githubusercontent.com/4060187/106504110-82f58d00-6494-11eb-87b7-a16d4f68bc5a.png" width="350" alt="Logo Turborepo" /></a>
<p>

<p align="center">
  <a href="https://vuejs.org/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/2367px-Vue.js_Logo_2.svg.png" width="88" alt="Logo Vue" /></a>
  <a href="https://nuxt.com/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Nuxt_logo.svg/1200px-Nuxt_logo.svg.png" width="105" alt="Logo Nuxt" /></a>
  <a href="https://nestjs.com/" target="blank"><img src="https://nestjs.com/img/logo-small.svg" width="88" alt="Logo Nest" /></a>
</p>


# Kit de démarrage : Projet de développement logiciel avec TurboRepo

Ce dépôt sert d’outil prêt à l’emploi et de squelette de projet permettant un démarrage rapide pour construire des applications logicielles innovantes. Il exploite des technologies et frameworks avancés tels que TurboRepo, NestJS, Vue 3 avec Vite, TypeScript et Nuxt.js pour faciliter un développement logiciel fluide et efficace.

## Table des matières
- [Fonctionnalités et Contenus](#fonctionnalités-et-contenus)
- [Prérequis](#prérequis)
- [Premiers pas](#premiers-pas)
- [Premiers pas avec Docker](#premiers-pas-avec-docker)
- [Variables d’environnement](#variables-denvironnement)
- [Volar et Visual Studio Code (Mode Takeover)](#volar-et-visual-studio-code-mode-takeover)
- [Scripts de niveau supérieur](#scripts-de-niveau-supérieur)
- [Extensions Visual Studio Code](#extensions-visual-studio-code)
- [Améliorations et rapports de bugs](#améliorations-et-rapports-de-bugs)
- [Contribution](#contribution)
- [Licence](#licence)

## Fonctionnalités et Contenus

- **TurboRepo** : Le dépôt est configuré pour fonctionner avec TurboRepo – un outil qui simplifie la gestion de multiples dépôts interconnectés au sein d’un même projet. Cela vous permet de vous concentrer sur le développement des fonctionnalités pendant que TurboRepo gère l’organisation.

- **NestJS** : Le backend de l’application est construit sur NestJS, un framework basé sur Node.js qui permet la création d’API évolutives et modulaires. Entièrement intégré avec TypeScript, NestJS offre performance et code lisible.

- **Vue 3 + Vite** : L’interface utilisateur est basée sur Vue 3, la dernière version du populaire framework JavaScript. Nous utilisons également Vite, un outil rapide et moderne pour construire des interfaces utilisateur.

- **TypeScript** : L’ensemble du projet est écrit en TypeScript, améliorant la sécurité du code et facilitant le refactoring et la maintenance.

- **Nuxt.js** : Le dépôt inclut aussi une configuration d’exemple pour Nuxt.js, un framework pour créer des applications Vue.js SSR (rendu côté serveur). Cela garantit des performances SEO et un chargement rapide du contenu.

- **Electron** : Le projet peut également être empaqueté en tant qu'application de bureau utilisant Electron, ce qui vous permet de créer des applications multiplateformes.

- **Capacitor** : Capacitor est intégré pour permettre la création d'applications mobiles natives en utilisant des technologies web.

- **Docker** : Docker est utilisé pour containeriser et gérer le déploiement de l'application.

- **Package partagé** : Le dépôt intègre un package partagé pour améliorer la réutilisabilité et la maintenabilité du code.

- **Configuration de test avec Vitest et Jest** : Le dépôt inclut une configuration pré-configurée pour les tests utilisant Vitest et Jest. Vous pouvez facilement écrire et exécuter des tests unitaires pour vos composants Vue et votre code TypeScript. Utilisez simplement la configuration de test fournie et exploitez la puissance des capacités de test rapide de Vitest ainsi que le cadre de test robuste de Jest.

## Prérequis

Il est conseillé d'installer globalement dans l'environnement de développement :

- [pnpm](https://pnpm.io/pnpm-cli)
- [nest-cli](https://docs.nestjs.com/cli/overview)

## Pour commencer

```bash

# 1. Clone the repository
git clone https://github.com/DhivinX/turbo-starter.git

# 2. Enter your newly-cloned folder
cd turbo-starter

# 3. Install the project and build packages in libs folder
pnpm install

# 4. Dev: Run web with hot reload 
pnpm dev-web # or make dev-web

# 5. Dev: Run API project with hot reload 
# Note that you need to create the .env file in the project root directory beforehand

# You should copy the .env.example file and rename it to .env
cp .env.example .env

# Then you can configure database access and other server settings
pnpm dev-api # or make dev-api

# 6. Or run API and WEB projects with hot reload parallel
pnpm dev # or make dev

```

## Prise en main de Docker

```bash

# 1. Clone the repository
git clone https://github.com/DhivinX/turbo-starter.git

# 2. Enter your newly-cloned folder
cd turbo-starter

# 3. Install the project and build packages in libs folder
pnpm install

# 4. Copy env.example to .env.local and pass wished variables:
# Change DATABASE_HOST to "postgres"
cp .env.example .env.local

# 5. Build image:
make docker-build-local

# 6. Run API and WEB projects development process with hot reload in docker container 
make docker-run-local

```

## Variables d'environnement

### .env.example

```bash
# Frontend: API server connection configuration
VITE_WEB_DEFAULT_LOCALE="en"
VITE_WEB_API_URL="http://localhost"
VITE_WEB_API_PORT=3000

# Backend public url
API_PUBLIC_URL=http://localhost:3000

# HTTP / HTTPS server config
API_HTTP_PORT=3000

# Cross-Origin Resource Sharing domain origins
# More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS
API_HTTP_CORS=["http://localhost", "http://localhost:8080", "http://localhost:8081", "http://localhost:8082", "app://localhost", "capacitor://localhost"]

# Keys required for hashing passwords and tokens
# They should be filled with random, unique strings
API_SECRETS_PWDSALT="123456"
API_SECRETS_JWT="123456"

# Database type: postgres, mysql, sqlite etc.
# More info: https://typeorm.io
DATABASE_TYPE="postgres"

# Database connection config
DATABASE_HOST="localhost"
DATABASE_PORT=5432

# Database name and user credentials
DATABASE_NAME="turbonv"
DATABASE_USER="postgres"
DATABASE_PASSWORD="root"

# Disable this in the production version of the application
# More info: https://typeorm.io/faq#how-do-i-update-a-database-schema
DATABASE_ENABLE_SYNC=true
```

## Volar et Visual Studio Code (Mode Prise de Contrôle)

`Volar` est maintenant l'extension officielle `Vue - Official`, donc le mode prise de contrôle n'est plus nécessaire à partir de la version 2.0. Veuillez activer l'extension intégrée `TypeScript and JavaScript Language Features` si vous l'aviez désactivée auparavant.

## Scripts de Niveau Supérieur

#### DÉVELOPPEMENT

* `dev` - exécute toutes les applications simultanément avec rechargement à chaud
* `dev-api` - exécute le projet API avec rechargement à chaud
* `dev-web` - exécute le projet WEB avec rechargement à chaud
* `dev-web-electron` - exécute le projet WEB dans l'application electron avec rechargement à chaud
* `dev-nuxt` - exécute l'application nuxt avec rechargement à chaud
* `dev-mobile` - exécute l'application mobile avec rechargement à chaud

#### COMPILATION

* `build` - compile tous les packages et applications
* `build-api` - compile l'application du projet API
* `build-web` - compile l'application du projet WEB
* `build-web-electron` - compile l'application electron avec le projet web
* `build-nuxt` - compile l'application nuxt
* `build-mobile` - compile l'application mobile

#### EXÉCUTION

* `start` - démarre toutes les applications
* `start-api` - démarre l'application du projet API
* `start-web` - lance un serveur web statique local qui sert les fichiers depuis dist
* `start-nuxt` - démarre l'application nuxt

#### MOBILE

* `mobile-android` - compile l'application mobile et l'ouvre dans Android Studio
* `mobile-ios` - compile l'application mobile et l'ouvre dans Xcode

#### COMMUN

* `test` - lance les tests pour tous les packages et applications
* `lint` - vérifier tous les paquets et applications avec un linter  
* `clean` - supprimer le répertoire dist de tous les paquets et applications  

## Extensions Visual Studio Code  

```json

{
  "recommendations": [
    "vue.volar",
    "dbaeumer.vscode-eslint",
    "editorconfig.editorconfig",
    "visualstudioexptteam.vscodeintellicode",
    "mikestead.dotenv",
    "firsttris.vscode-jest-runner"
  ]
}

```

### Requis

* `vue.volar` - Fonctionnalités linguistiques Vue (Volar)
* `syler.sass-indented` - Mise en évidence de la syntaxe Sass.
* `dbaeumer.vscode-eslint` - Extension ESLint pour VS Code.
* `editorconfig.editorconfig` - EditorConfig pour VS Code.

### Optionnel

* `mikestead.dotenv` - DotENV - Support de la syntaxe des fichiers dotenv
* `visualstudioexptteam.vscodeintellicode` - IntelliCode

## Améliorations et rapports de bugs

Si vous trouvez un bug, ou avez une amélioration en tête, veuillez poster des [issues](https://github.com/DhivinX/turbo-starter/issues) sur GitHub.

## Contribution

Si vous avez des idées pour améliorer ce starter ou souhaitez ajouter de nouvelles fonctionnalités, n’hésitez pas à soumettre des pull requests. Votre contribution peut aider d’autres développeurs à démarrer leurs projets encore plus rapidement !

## Licence

Ce kit de démarrage est fourni sous licence MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-04

---