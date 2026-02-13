# Taskosaur

<img src="https://raw.githubusercontent.com/Taskosaur/Taskosaur/main/frontend/public/taskosaur-logo.svg" alt="Logo Taskosaur" width="128">

### Gestion de projet open source avec exécution de tâches par IA conversationnelle

### 📹 Regardez Taskosaur en action

[![Démo Taskosaur - L'IA transforme des demandes simples en projets complets](https://img.youtube.com/vi/sv2lsteRKac/maxresdefault.jpg)](https://youtu.be/sv2lsteRKac)

*Cliquez pour regarder : découvrez comment fonctionne l’exécution de tâches par IA conversationnelle dans Taskosaur*

Taskosaur est une plateforme open source de gestion de projet avec une IA conversationnelle pour l’exécution des tâches intégrée à l’application. L’assistant IA gère les tâches de gestion de projet par conversation naturelle, de la création des tâches à la gestion des flux de travail directement dans l’application.

<!-- Badges -->

![Node.js](https://img.shields.io/badge/node-%3E%3D22.0.0-brightgreen.svg)
![TypeScript](https://img.shields.io/badge/typescript-%5E5.0.0-blue.svg)
![NestJS](https://img.shields.io/badge/nestjs-%5E11.0.0-red.svg)
![Next.js](https://img.shields.io/badge/nextjs-15.2.2-black.svg)
![PostgreSQL](https://img.shields.io/badge/postgresql-%3E%3D16-blue.svg)
![Redis](https://img.shields.io/badge/redis-%3E%3D7-red.svg)
![IA](https://img.shields.io/badge/AI-Powered-purple.svg)

Taskosaur combine les fonctionnalités traditionnelles de gestion de projet avec l’exécution de tâches par IA conversationnelle, vous permettant de gérer vos projets par une conversation naturelle. Au lieu de naviguer dans les menus et formulaires, vous pouvez créer des tâches, assigner du travail et gérer les flux de travail simplement en décrivant ce dont vous avez besoin.

## Fonctionnalités clés

- 🤖 **IA conversationnelle pour l’exécution des tâches** - Exécutez les tâches de projet par conversation naturelle directement dans l’application
- 💬 **Commandes en langage naturel** - « Créer un sprint avec les bugs prioritaires de la semaine dernière » s’exécute automatiquement
- 🏠 **Auto-hébergé** - Vos données restent sur votre infrastructure
- 💰 **Apportez votre propre LLM** - Utilisez votre propre clé API avec OpenAI, Anthropic, OpenRouter ou des modèles locaux
- 🔧 **Automatisation du navigateur intégrée** - L’IA navigue dans l’interface et effectue des actions directement dans l’application
- 📊 **Gestion de projet complète** - Tableaux Kanban, sprints, dépendances des tâches, suivi du temps
- 🌐 **Open source** - Disponible sous licence Business Source License (BSL)

## Table des matières

- [Fonctionnalités clés](#fonctionnalités-clés)
- [Démarrage rapide](#démarrage-rapide)
  - [Prérequis](#prerequis)
  - [Configuration Docker (Recommandée)](#configuration-docker-recommandee)
  - [Configuration Manuelle](#configuration-manuelle)
- [Développement](#developpement)
- [Structure du Projet](#structure-du-projet)
- [Déploiement](#deploiement)
- [Documentation de l'API](#documentation-de-lapi)
- [Contribution](#contribution)
- [Licence](#licence)
- [Support](#support)

## Démarrage Rapide

### Prérequis

- Node.js 22+ et npm 10+
- PostgreSQL 16+ (ou Docker)
- Redis 7+ (ou Docker)

### Configuration Docker (Recommandée)

La façon la plus rapide de commencer avec Taskosaur est d'utiliser Docker Compose :

1. **Cloner le dépôt**

   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```
2. **Configurer les variables d’environnement**

   ```bash
   cp .env.example .env
   ```
   Cela crée le fichier .env utilisé pour l'application, vous pouvez personnaliser les valeurs, si nécessaire.
   
3. **Démarrer avec Docker Compose**

   ```bash
   docker compose -f docker-compose.dev.yml up
   ```
   Cela automatiquement :
   - ✅ Démarre PostgreSQL et Redis
   - ✅ Installe toutes les dépendances
   - ✅ Génère le client Prisma
   - ✅ Exécute les migrations de la base de données
   - ✅ Remplit la base de données avec des données d'exemple
   - ✅ Démarre à la fois le backend et le frontend

4. **Accéder à l'application**
   - Frontend : http://localhost:3001
   - API Backend : http://localhost:3000
   - Documentation API : http://localhost:3000/api/docs

Voir [DOCKER_DEV_SETUP.md](https://raw.githubusercontent.com/ais1175/Taskosaur/main/DOCKER_DEV_SETUP.md) pour la documentation détaillée de Docker.

### Installation manuelle

Si vous préférez exécuter les services localement :

1. **Cloner le dépôt**


   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```

2. **Installer les dépendances**

   ```bash
   npm install
   ```

3. **Configuration de l'environnement**

   Créez un fichier `.env` à la racine du répertoire :

   ```env
   # Database Configuration
   DATABASE_URL="postgresql://taskosaur:taskosaur@localhost:5432/taskosaur"

   # Application
   NODE_ENV=development

   # Authentication & Security
   JWT_SECRET="your-jwt-secret-key-change-this"
   JWT_REFRESH_SECRET="your-refresh-secret-key-change-this-too"
   JWT_EXPIRES_IN="15m"
   JWT_REFRESH_EXPIRES_IN="7d"

   # Encryption for sensitive data
   ENCRYPTION_KEY="your-64-character-hex-encryption-key-change-this-to-random-value"

   # Redis Configuration (for Bull Queue)
   REDIS_HOST=localhost
   REDIS_PORT=6379
   REDIS_PASSWORD=

   # Email Configuration (optional, for notifications)
   SMTP_HOST=smtp.example.com
   SMTP_PORT=587
   SMTP_USER=your-email@taskosaur.com
   SMTP_PASS=your-app-password
   SMTP_FROM=noreply@taskosaur.com
   EMAIL_DOMAIN="taskosaur.com"

   # Frontend URL (for email links and CORS)
   FRONTEND_URL=http://localhost:3001
   CORS_ORIGIN="http://localhost:3001"

   # Backend API URL (for frontend to connect to backend)
   NEXT_PUBLIC_API_BASE_URL=http://localhost:3000/api

   # File Upload
   UPLOAD_DEST="./uploads"
   MAX_FILE_SIZE=10485760

   # Queue Configuration
   MAX_CONCURRENT_JOBS=5
   JOB_RETRY_ATTEMPTS=3
   ```
4. **Configurer la base de données**


   ```bash
   # Run database migrations
   npm run db:migrate

   # Seed the database (idempotent - safe to run multiple times)
   npm run db:seed

   # Or seed with admin user only
   npm run db:seed:admin
   ```

5. **Démarrer l'application**

   ```bash
   # Development mode (runs both frontend and backend)
   npm run dev

   # Or start individually
   npm run dev:frontend    # Start frontend only (port 3001)
   npm run dev:backend     # Start backend only (port 3000)
   ```

6. **Accéder à l’Application**
   - Frontend : http://localhost:3001
   - API Backend : http://localhost:3000
   - Documentation de l’API : http://localhost:3000/api/docs

## Développement

### Commandes Disponibles

Toutes les commandes s’exécutent depuis le répertoire racine :

#### Développement

```bash
npm run dev              # Start both frontend and backend concurrently
npm run dev:frontend     # Start frontend only (Next.js on port 3001)
npm run dev:backend      # Start backend only (NestJS on port 3000)
```

#### Construire

```bash
npm run build            # Build all workspaces (frontend + backend)
npm run build:frontend   # Build frontend for production
npm run build:backend    # Build backend for production
npm run build:dist       # Build complete distribution package
```

#### Opérations sur la base de données

Toutes les commandes de seed sont **idempotentes** et peuvent être exécutées plusieurs fois en toute sécurité :

```bash
npm run db:migrate         # Run database migrations
npm run db:migrate:deploy  # Deploy migrations (production)
npm run db:reset           # Reset database (deletes all data!)
npm run db:seed            # Seed database with sample data
npm run db:seed:admin      # Seed database with admin user only
npm run db:generate        # Generate Prisma client
npm run db:studio          # Open Prisma Studio (database GUI)
npm run prisma             # Run Prisma CLI commands directly
```
#### Test


```bash
npm run test               # Run all tests
npm run test:frontend      # Run frontend tests
npm run test:backend       # Run backend unit tests
npm run test:watch         # Run backend tests in watch mode
npm run test:cov           # Run backend tests with coverage
npm run test:e2e           # Run backend end-to-end tests
```

#### Qualité du code

```bash
npm run lint               # Lint all workspaces
npm run lint:frontend      # Lint frontend code
npm run lint:backend       # Lint backend code
npm run format             # Format backend code with Prettier
```

#### Nettoyage

```bash
npm run clean              # Clean all build artifacts
npm run clean:frontend     # Clean frontend build artifacts
npm run clean:backend      # Clean backend build artifacts
```

### Hooks Git

Vérifications automatiques de la qualité du code avec **Husky** :

- **Pre-commit** : Exécute les linters sur tous les espaces de travail avant chaque commit
- Garantit la qualité et la cohérence du code
- Contourner avec `--no-verify` (uniquement en cas d'urgence)

```bash
git commit -m "feat: add feature"  # Runs checks automatically
```

## Structure du projet

```
taskosaur/
├── backend/                # NestJS Backend (Port 3000)
│   ├── src/
│   │   ├── modules/       # Feature modules
│   │   ├── common/        # Shared utilities
│   │   ├── config/        # Configuration
│   │   └── gateway/       # WebSocket gateway
│   ├── prisma/            # Database schema and migrations
│   ├── public/            # Static files
│   └── uploads/           # File uploads
├── frontend/              # Next.js Frontend (Port 3001)
│   ├── src/
│   │   ├── app/          # App Router pages
│   │   ├── components/   # React components
│   │   ├── contexts/     # React contexts
│   │   ├── hooks/        # Custom hooks
│   │   ├── lib/          # Utilities
│   │   └── types/        # TypeScript types
│   └── public/           # Static assets
├── docker/               # Docker configuration
│   └── entrypoint-dev.sh # Development entrypoint script
├── scripts/              # Build and utility scripts
├── .env.example          # Environment variables template
├── docker-compose.dev.yml # Docker Compose for development
└── package.json          # Root package configuration
```

## Configuration de l'exécution des tâches d'IA conversationnelle

### Activer l'exécution des tâches d'IA conversationnelle en 3 étapes :

1. **Accédez aux paramètres de l'organisation**

   ```
   Go to Settings → Organization Settings → AI Assistant Settings
   ```

2. **Ajoutez votre clé API LLM**

   - Activez "Activer le chat IA"
   - Ajoutez votre clé API de n'importe quel fournisseur compatible :
     - **OpenRouter** (100+ modèles, options gratuites) : `https://openrouter.ai/api/v1`
     - **OpenAI** (modèles GPT) : `https://api.openai.com/v1`
     - **Anthropic** (modèles Claude) : `https://api.anthropic.com/v1`
     - **Local AI** (Ollama, etc.) : votre point de terminaison local

3. **Commencez à gérer avec l'IA**
   - Ouvrez le panneau de chat IA (icône étincelle)
   - Tapez : _"Créez un nouveau projet appelé Refonte du site avec 5 tâches"_
   - L'IA exécute automatiquement le workflow

### Comment fonctionne l'exécution des tâches avec l'IA conversationnelle

La fonction d'exécution des tâches par IA conversationnelle de Taskosaur permet une exécution des tâches directement dans l'application, réalisant des actions au lieu de simplement fournir des suggestions :

- **Exécution conversationnelle intégrée** - Discutez naturellement avec l'IA pour exécuter des tâches directement dans l'application
- **Automatisation directe via navigateur** - L'IA navigue dans votre interface et clique sur les boutons en temps réel
- **Exécution de workflows complexes** - Opérations multi-étapes gérées sans effort via la conversation
- **Actions contextuelles** - Comprend le contexte actuel de votre projet/espace de travail
- **Interface en langage naturel** - Pas de commandes à mémoriser, parlez simplement naturellement

**Exemples de commandes d'exécution des tâches par IA conversationnelle :**

```
"Set up a new marketing workspace with Q1 campaign project"
"Move all high-priority bugs to in-progress and assign to John"
"Create a sprint with tasks from last week's backlog"
"Generate a report of Sarah's completed tasks this month"
"Set up automated workflow: when task is marked done, create review subtask"
```
## Fonctionnalités

_Taskosaur est en cours de développement actif. Les fonctionnalités suivantes représentent nos capacités prévues, dont beaucoup sont déjà implémentées et d’autres en cours._

### 🤖 Capacités d’Exécution de Tâches par IA Conversationnelle

🎯 **Exécution de Tâches Conversationnelle Intégrée**

- **Interface de Chat Intégrée** : Conversez avec l’IA directement dans Taskosaur pour exécuter des tâches  
- **Exécution de Tâches via Navigateur** : L’IA navigue dans l’interface, remplit les formulaires et complète les tâches en temps réel  
- **Traitement de Flux de Travail Multi-Étapes** : Exécutez des workflows complexes avec une seule commande conversationnelle  
- **Compréhension du Contexte** : L’IA reconnaît votre espace de travail, projet et contexte d’équipe actuels  
- **Suggestions Proactives** : L’IA identifie les goulots d’étranglement et propose des améliorations par la conversation  

🧠 **Traitement du Langage Naturel**

- Comprend les requêtes complexes de gestion de projet  
- Extrait actions, paramètres et contexte des entrées conversationnelles  
- Infère les détails manquants à partir du contexte actuel  

⚡ **Exécution d’Actions**

- Automatisation du navigateur en direct et en temps réel  
- Opérations en masse sur plusieurs tâches simultanément  
- Fonctionne au sein de vos workflows existants  

🚀 **Support des Flux de Travail Projet**

- Planification de sprint avec analyse des tâches  
- Attribution des tâches basée sur la capacité de l’équipe  
- Prévision du calendrier du projet  

**Exemples d’Exécution de Tâches par IA Conversationnelle :**

- « Configure la campagne marketing du T1 : crée un espace de travail, ajoute l’équipe, configure 3 projets avec modèles standards »  
- « Analyse toutes les tâches en retard et reprogramme en fonction de la capacité et des priorités de l’équipe »  
- « Crée un workflow automatisé : bugs haute priorité → attribue au dev senior → notifie le chef d’équipe »  
- « Génère une rétrospective de sprint avec analyse de la vélocité de l’équipe et suggestions d’amélioration »  
- « Migre toutes les tâches de design de l’ancien projet vers le nouvel espace de travail avec affectations mises à jour »


### Gestion de l'Organisation

- **Architecture Multi-locataires** : Support prévu pour plusieurs organisations avec données isolées
- **Organisation des Espaces de Travail** : Regrouper les projets au sein des espaces de travail pour une meilleure organisation
- **Contrôle d’Accès Basé sur les Rôles** : Mise en place de permissions granulaires (Admin, Manager, Membre, Observateur)
- **Gestion des Équipes** : Inviter et gérer les membres d’équipe à travers les organisations

### Gestion de Projet

- **Structure de Projet Flexible** : Créer et gérer des projets avec des workflows personnalisés
- **Planification de Sprint** : Gestion agile des sprints prévue avec planification et suivi
- **Dépendances des Tâches** : Travail sur les relations entre tâches avec différents types de dépendances
- **Workflows Personnalisés** : Mise en place de workflows de statuts personnalisés selon les besoins du projet

### Gestion des Tâches

- **Types de Tâches Riches** : Support pour Tâches, Bugs, Épopées, Histoires et Sous-tâches
- **Gestion des Priorités** : Définir les priorités des tâches de la plus basse à la plus haute
- **Champs Personnalisés** : Ajouter des champs personnalisés pour capturer des données spécifiques au projet
- **Étiquettes & Tags** : Organiser les tâches avec des étiquettes personnalisables
- **Suivi du Temps** : Suivre le temps passé sur les tâches avec journalisation détaillée
- **Pièces Jointes** : Joindre fichiers et documents aux tâches
- **Commentaires & Mentions** : Collaborer via les commentaires de tâches avec @mentions
- **Observateurs de Tâches** : S’abonner aux mises à jour et notifications des tâches

### Vues Multiples

- **Tableau Kanban** : Gestion visuelle des tâches avec glisser-déposer
- **Vue Calendrier** : Visualisation prévue du planning et de la chronologie
- **Diagrammes de Gantt** : Visualisation prévue de la chronologie du projet et des dépendances
- **Vue Liste** : Liste traditionnelle des tâches sous forme de tableau
- **Tableau de Bord Analytique** : Travail en cours sur les métriques de projet, graphiques d’avancement et vélocité d’équipe

### Automatisation & Intégrations

- **Règles d’Automatisation** : Workflows d’automatisation personnalisés prévus
- **Notifications Email** : Alertes email automatisées pour les mises à jour des tâches
- **Mises à Jour en Temps Réel** : Mises à jour en direct via connexions WebSocket
- **Journal d’Activité** : Trace d’audit complète de toutes les modifications
- **Fonctionnalité de recherche** : Travail en cours pour une recherche globale à travers les projets et les tâches

### Analyse et rapports

- **Graphiques de burndown de sprint** : Suivi prévu de la progression du sprint
- **Vélocité de l'équipe** : Surveillance prévue de la performance de l'équipe dans le temps
- **Distribution des tâches** : Travail en cours sur l'allocation des tâches et l'analyse de la charge de travail
- **Rapports personnalisés** : Génération prévue de rapports spécifiques aux projets

## Démarrage rapide

### Prérequis

- Node.js 22+ et npm
- PostgreSQL 13+
- Redis 6+ (pour les tâches en arrière-plan)

### Installation

1. **Cloner le dépôt**

   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```
2. **Installer les dépendances**


   ```bash
   npm install
   ```

   Cela installera automatiquement :
   - Toutes les dépendances de l’espace de travail (frontend et backend)
   - La configuration des hooks git Husky pour la qualité du code

3. **Configuration de l’environnement**

   Créez un fichier `.env` à la racine avec la configuration suivante :

   ```env
   # Database Configuration
   DATABASE_URL="postgresql://your-db-username:your-db-password@localhost:5432/taskosaur"

   # Authentication
   JWT_SECRET="your-jwt-secret-key-change-this"
   JWT_REFRESH_SECRET="your-refresh-secret-key-change-this-too"
   JWT_EXPIRES_IN="15m"
   JWT_REFRESH_EXPIRES_IN="7d"

   # Redis Configuration (for Bull Queue)
   REDIS_HOST=localhost
   REDIS_PORT=6379
   REDIS_PASSWORD=

   # Email Configuration (for notifications)
   SMTP_HOST=smtp.gmail.com
   SMTP_PORT=587
   SMTP_USER=your-email@gmail.com
   SMTP_PASS=your-app-password
   SMTP_FROM=noreply@taskosaur.com

   # Frontend URL (for email links)
   FRONTEND_URL=http://localhost:3000

   # File Upload
   UPLOAD_DEST="./uploads"
   MAX_FILE_SIZE=10485760

   # Queue Configuration
   MAX_CONCURRENT_JOBS=5
   JOB_RETRY_ATTEMPTS=3

   # Frontend Configuration
   NEXT_PUBLIC_API_BASE_URL=http://localhost:3001/api
   ```

4. **Configurer la base de données**

   ```bash
   # Run database migrations
   npm run db:migrate

   # Seed the database with core data
   npm run db:seed
   ```

5. **Démarrer l'Application**

   ```bash
   # Development mode (with hot reload for both frontend and backend)
   npm run dev

   # Or start individually
   npm run dev:frontend    # Start frontend only
   npm run dev:backend     # Start backend only
   ```

6. **Accéder à l'Application**
   - Frontend : [http://localhost:3000](http://localhost:3000)
   - API Backend : [http://localhost:3001/api](http://localhost:3001/api)
   - Documentation API : [http://localhost:3001/api/docs](http://localhost:3001/api/docs)

## Développement

### Commandes Disponibles

Toutes les commandes sont exécutées depuis le répertoire racine. Les variables d'environnement sont automatiquement chargées depuis le fichier `.env` à la racine.

#### Développement

```bash
# Start both frontend and backend
npm run dev

# Start individually
npm run dev:frontend       # Start frontend dev server
npm run dev:backend        # Start backend dev server with hot reload
```

#### Construction

```bash
# Build all workspaces
npm run build

# Build individually
npm run build:frontend     # Build frontend for production
npm run build:backend      # Build backend for production
npm run build:dist         # Build complete distribution package
```

#### Opérations sur la base de données

```bash
npm run db:migrate         # Run database migrations
npm run db:migrate:deploy  # Deploy migrations (production)
npm run db:reset           # Reset database (deletes all data!)
npm run db:seed            # Seed database with core data
npm run db:seed:admin      # Seed database with admin user
npm run db:generate        # Generate Prisma client
npm run db:studio          # Open Prisma Studio
npm run prisma             # Run Prisma CLI commands
```

#### Testeing

```bash
npm run test               # Run all tests
npm run test:frontend      # Run frontend tests
npm run test:backend       # Run backend unit tests
npm run test:watch         # Run backend tests in watch mode
npm run test:cov           # Run backend tests with coverage
npm run test:e2e           # Run backend end-to-end tests
```

#### Qualité du code

```bash
npm run lint               # Lint all workspaces
npm run lint:frontend      # Lint frontend code
npm run lint:backend       # Lint backend code
npm run format             # Format backend code with Prettier
```

#### Nettoyage

```bash
npm run clean              # Clean all workspaces and root
npm run clean:frontend     # Clean frontend build artifacts
npm run clean:backend      # Clean backend build artifacts
```

### Qualité du code & Hooks Git

Formatage automatique du code et linting avec **Prettier**, **ESLint**, et **Husky**.

```bash
# Lint all workspaces
npm run lint                # Lint all workspaces

# Lint individually
npm run lint:frontend       # Frontend only
npm run lint:backend        # Backend only

# Format backend code
npm run format              # Format backend code with Prettier
```

**Hook de pré-commit** : Formate, analyse et valide automatiquement le code à chaque commit via Husky.

```bash
# Commits run checks automatically
git commit -m "feat: add feature"

# Bypass checks in emergencies only
git commit -m "fix: urgent hotfix" --no-verify
```

## Structure du projet

```
taskosaur/
├── backend/                 # NestJS Backend
│   ├── src/
│   │   ├── modules/        # Feature modules
│   │   ├── config/         # Configuration files
│   │   ├── gateway/        # WebSocket gateway
│   │   └── prisma/         # Database service
│   ├── prisma/             # Database schema and migrations
│   └── uploads/            # File uploads
├── frontend/               # Next.js Frontend
│   ├── src/
│   │   ├── app/           # App Router pages
│   │   ├── components/    # React components
│   │   ├── contexts/      # React contexts
│   │   ├── hooks/         # Custom hooks
│   │   ├── styles/        # CSS styles
│   │   ├── types/         # TypeScript types
│   │   └── utils/         # Utility functions
│   └── public/            # Static assets
└── README.md
```

## Déploiement

### Déploiement en Production

#### Utilisation de Docker (Recommandé)

```bash
# Clone the repository
git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
cd taskosaur

# Setup environment variables
cp .env.example .env
```

**⚠️ IMPORTANT :** Modifiez `.env` et mettez à jour avec des valeurs de production sécurisées :
- Générez des secrets forts et uniques pour `JWT_SECRET`, `JWT_REFRESH_SECRET`, `ENCRYPTION_KEY`
- Définissez des identifiants de base de données sécurisés
- Configurez vos URL de domaine (`FRONTEND_URL`, `CORS_ORIGIN`, `NEXT_PUBLIC_API_BASE_URL`)
- Configurez les paramètres SMTP pour les notifications par e-mail
- **N'utilisez jamais les valeurs d'exemple/par défaut en production**

```bash
# Build and run with Docker Compose
docker-compose -f docker-compose.prod.yml up -d
```

#### Déploiement Manuel

**Prérequis pour la Production :**

- Node.js 22+ LTS
- PostgreSQL 13+
- Redis 6+
- Proxy inverse (Nginx recommandé)

**Étapes de Déploiement :**

```bash
# From root directory
npm install

# Run database migrations
npm run db:migrate:deploy

# Generate Prisma client
npm run db:generate

# Build distribution package
npm run build:dist

# Start the application
# Backend: dist/main.js
# Frontend: dist/public/
# Serve with your preferred Node.js process manager (PM2, systemd, etc.)
```

#### Variables d'environnement pour la production

Mettez à jour votre fichier `.env` pour la production :

```env
NODE_ENV=production

# Database Configuration
DATABASE_URL="postgresql://username:password@your-db-host:5432/taskosaur"

# Authentication
JWT_SECRET="your-secure-production-jwt-secret"
JWT_REFRESH_SECRET="your-secure-production-refresh-secret"

# Redis Configuration
REDIS_HOST="your-redis-host"
REDIS_PORT=6379
REDIS_PASSWORD="your-redis-password"

# CORS Configuration
CORS_ORIGIN="https://your-domain.com"

# Frontend Configuration
NEXT_PUBLIC_API_BASE_URL=https://api.your-domain.com/api
FRONTEND_URL=https://your-domain.com
```

#### Plates-formes d’hébergement

**Plates-formes recommandées :**

- **Backend** : Railway, Render, DigitalOcean App Platform
- **Frontend** : Vercel, Netlify, Railway
- **Base de données** : Railway PostgreSQL, Supabase, AWS RDS
- **Redis** : Railway Redis, Redis Cloud, AWS ElastiCache

## Documentation API

La documentation de l’API est générée automatiquement avec Swagger :

- Développement : http://localhost:3000/api/docs
- Production : `https://api.your-domain.com/api/docs`

## Contribution

Nous accueillons les contributions ! Veuillez consulter nos [Directives de contribution](https://raw.githubusercontent.com/ais1175/Taskosaur/main/CONTRIBUTING.md) pour plus de détails.

1. Forkez le dépôt
2. Créez une branche de fonctionnalité (`git checkout -b feature/amazing-feature`)
3. Commitez vos modifications (`git commit -m 'feat: add amazing feature'`)
4. Poussez la branche (`git push origin feature/amazing-feature`)
5. Ouvrez une Pull Request

### Directives de développement

- **Style de code** : Suivez le style de code existant, les linters s’exécutent automatiquement au commit
- **TypeScript** : Utilisez un TypeScript strict avec des annotations de type appropriées
- **Tests** : Écrivez des tests pour les nouvelles fonctionnalités et corrections de bugs
- **Documentation** : Mettez à jour la documentation pour toute modification de l’API
- **Messages de commit** : Utilisez des messages de commit conventionnels (feat, fix, docs, etc.)

## Licence

Ce projet est sous licence Business Source License - voir le fichier [LICENSE](https://raw.githubusercontent.com/ais1175/Taskosaur/main/LICENSE.md) pour plus de détails.

## Remerciements

- [NestJS](https://nestjs.com/) - Framework backend
- [Next.js](https://nextjs.org/) - Framework frontend
- [Prisma](https://prisma.io/) - ORM de base de données
- [Tailwind CSS](https://tailwindcss.com/) - Framework CSS

## Support

- Email : support@taskosaur.com
- Discord : [Rejoignez notre communauté](https://discord.gg/5cpHUSxePp)
- Problèmes : [GitHub Issues](https://github.com/Taskosaur/Taskosaur/issues)
- Discussions : [GitHub Discussions](https://github.com/Taskosaur/Taskosaur/discussions)

---

Construit avec amour par l'équipe Taskosaur


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-13

---