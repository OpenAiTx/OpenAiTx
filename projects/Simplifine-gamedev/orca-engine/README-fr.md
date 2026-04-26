## Moteur Orca

Discord : https://discord.gg/bvdpdT26Tq

Basé sur Godot Engine, avec des améliorations par Simplifine.


### Quel est le piège ?
Nous intégrons un chatbot, avec un accès complet à Godot.  
Le chatbot peut :  
  - Lire/modifier/créer/supprimer des fichiers  
  - comprendre l’ensemble du projet comme contexte  
  - créer des images et maintenir la cohérence entre les images créées  
  - modifier les objets natifs de Godot, par ex. nœuds, scènes, ...

### Capacités de l’Assistant IA

Le chatbot intégré dispose d’outils complets pour le développement Godot :

#### Gestion des scènes et des nœuds
- **Opérations sur scènes** : Ouvrir, créer, sauvegarder et instancier des scènes  
- **Manipulation des nœuds** : Créer, supprimer, déplacer et renommer des nœuds dans l’arborescence de la scène  
- **Inspection des nœuds** : Obtenir les propriétés, scripts et informations hiérarchiques des nœuds  
- **Sélection des nœuds** : Travailler avec les nœuds actuellement sélectionnés dans l’éditeur  
- **Découverte des classes** : Accéder à toutes les classes de nœuds Godot disponibles et leurs capacités

#### Gestion des scripts et du code
- **Opérations sur fichiers** : Lire, écrire et modifier n’importe quel fichier du projet avec ciblage par ligne  
- **Génération de scripts** : Créer de nouveaux fichiers GDScript avec génération de code assistée par IA  
- **Édition de code** : Appliquer des modifications intelligentes aux scripts existants via des instructions en langage naturel  
- **Détection d’erreurs** : Vérifier les erreurs de compilation dans des fichiers uniques ou sur l’ensemble du projet  
- **Attachement de scripts** : Attacher et gérer les scripts sur les nœuds

#### Navigation et recherche dans le projet
- **Système de fichiers** : Parcourir les répertoires et fichiers du projet avec options de filtrage  
- **Recherche sémantique avancée** : Trouver des fichiers et du code pertinents via des requêtes en langage naturel avec **intelligence au niveau des fonctions**  
- **Suivi de dépendances multi-étapes** : Comprendre les chaînes complètes d’appels de fonctions et les flux de signaux dans votre projet  
- **Analyse graphique** : Découvrir les fichiers connectés, composants centraux du projet et relations architecturales  
- **Modes de recherche intelligents** : Sémantique (compréhension IA), mots-clés (texte exact), ou hybride (combiné)

> 🔍 **[Voir la documentation sur l’indexation avancée](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** pour des détails techniques sur la découpe au niveau des fonctions, le suivi du flux des signaux, et l’analyse des dépendances

#### Création de contenu visuel
- **Génération d’images** : Créez de nouvelles images à partir de descriptions textuelles avec différents styles artistiques
- **Édition d’images** : Modifiez des images existantes grâce à une édition assistée par IA
- **Génération de modèles 3D** : Générez des modèles 3D à partir de prompts textuels ou d’images (lorsque configuré)
- **Gestion des assets** : Enregistrez les images générées dans des chemins spécifiques du projet
- **Cohérence de style** : Maintenez une cohérence visuelle entre les assets générés

#### Physique et objets de jeu
- **Formes de collision** : Ajoutez une détection de collision aux corps physiques (rectangle, cercle, capsule)
- **Propriétés des nœuds** : Modifiez les propriétés de transformation, de physique et de gameplay
- **Appels de méthodes** : Exécutez les méthodes des nœuds avec des paramètres personnalisés

#### Système de signaux et connexions
- **Inspection des signaux** : Listez les signaux disponibles et leurs connexions
- **Gestion des connexions** : Créez et gérez les connexions de signaux entre nœuds
- **Traçage des signaux** : Déboguez le flux des signaux avec un suivi léger des événements
- **Validation des connexions** : Vérifiez l’intégrité des connexions de signaux

#### Workflow de développement
- **Support multi-modèles** : Choisissez entre GPT-5, Claude-4, Gemini-2.5 et GPT-4o
- **Assistance en temps réel** : Diffusez les réponses avec un retour d’exécution des outils
- **Récupération d’erreurs** : Basculement intelligent entre fournisseurs d’IA pour plus de fiabilité
- **Authentification** : Accès sécurisé avec OAuth (Google, GitHub, Microsoft) ou mode invité

### Système d’indexation avancé

Orca Engine dispose d’un **système d’indexation Godot de premier ordre** qui comprend votre code au **niveau des fonctions** :

- **🎯 Intelligence au niveau des fonctions** : Chaque fonction GDScript, signal et export devient une unité consultable avec des métadonnées riches
- **🔗 Suivi du flux des signaux** : Compréhension complète de l’émission → connexion → chaînes de gestionnaires de signaux dans tout votre projet  
- **🕸️ Traçage multi-sauts des dépendances** : Suivez les chaînes d’appels de fonctions (ex. Input → Controller → Physics → Animation)
- **📊 Analyse de centralité des graphes** : Identifiez les fichiers architecturaux importants et leurs rôles structurels
- **🔍 Modes de recherche intelligents** : Recherche sémantique (compréhension IA), par mots-clés (texte exact) ou hybride (combinée)

**Performance** : ~2,7× plus de segments intelligents que l’indexation traditionnelle par lignes, permettant une compréhension précise des mécaniques de jeu complexes.

> 📚 **[Approfondissement technique : indexation avancée](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** | **[Guide de configuration backend](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**

### Démarrage rapide (éditeur uniquement)

Construisez et exécutez l'éditeur. Les fonctionnalités IA se connectent par défaut à notre backend cloud. Aucune configuration de backend local n'est requise.

macOS :
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
brew install scons pkg-config python3 git
scons platform=macos target=editor dev_build=yes vulkan=no -j"$(sysctl -n hw.ncpu)"
./bin/godot.macos.editor.dev.arm64
```

Windows (PowerShell) :
```powershell
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
# If needed: scoop install python scons git   (or: choco install python scons git)
scons platform=windows target=editor dev_build=yes vulkan=no -j $env:NUMBER_OF_PROCESSORS
.\bin\godot.windows.editor.dev.x86_64.exe
```
Linux (Ubuntu/Debian) :

```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
sudo apt update
sudo apt install -y build-essential scons pkg-config libx11-dev libxcursor-dev libxinerama-dev \
  libgl1-mesa-dev libglu1-mesa-dev libasound2-dev libpulse-dev libudev-dev libxi-dev libxrandr-dev \
  python3 python3-pip git
scons platform=linuxbsd target=editor dev_build=yes vulkan=no -j"$(nproc)"
./bin/godot.linuxbsd.editor.dev.x86_64
```

Notes :  
- Aucun SDK Vulkan requis. L’éditeur utilise le moteur par défaut de la plateforme (Metal sur macOS, D3D12 sur Windows, GLES3 sur Linux). Vulkan est optionnel et n’est pas nécessaire pour construire ou exécuter l’éditeur.  
- Pour pointer l’éditeur vers un backend auto-hébergé au lieu du cloud, voir la section backend ci-dessous.  

### Backend (Déploiement local / cloud optionnel)  

- Pour le développement local ou l’auto-hébergement, suivez le **[Guide d’installation du backend](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**. Il couvre les variables d’environnement, l’exécution locale et le déploiement sur Google Cloud Run via `backend/deploy.sh`.  
- Pour des détails avancés sur l’indexation (blocs au niveau des fonctions, graphes de dépendances), voir **[backend/indexing.md](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)**.  

#### Configuration de l’environnement  

Créez un fichier `.env` dans le répertoire `backend/` avec vos clés API :

```env
# Required: AI provider for embeddings and chat
OPENAI_API_KEY=YOUR_OPENAI_API_KEY
# ANTHROPIC_API_KEY=YOUR_ANTHROPIC_API_KEY
# GOOGLE_API_KEY=YOUR_GOOGLE_API_KEY

# Required: For advanced vector search and function-level indexing
WEAVIATE_URL=https://YOUR-WEAVIATE-ENDPOINT
WEAVIATE_API_KEY=YOUR_WEAVIATE_API_KEY

# Optional: Additional configuration
FLASK_SECRET_KEY=YOUR_RANDOM_SECRET_KEY

# Development mode (set to 'false' in production)
DEV_MODE=true
```

> ⚙️ **[Voir le Guide de Configuration du Backend](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)** pour la documentation complète des variables d'environnement et les instructions de déploiement

#### Performance de l'indexation (grands projets)

L'éditeur déclenche automatiquement l'indexation côté serveur. Pour les grandes bases de code, définissez ces paramètres pour accélérer le processus (dans `backend/.env` localement ou avant d'exécuter `backend/deploy.sh` afin que Cloud Run les récupère en tant que secrets) :

```env
# Parallelism and batching
INDEX_MAX_WORKERS=32         # number of parallel file workers on the backend
EMBED_MAX_PARALLEL=12        # concurrent embedding batches (respect provider limits)
EMBED_BATCH_SIZE=256         # embeddings per batch
CHUNK_MAX_LINES=100          # larger chunks = fewer embedding calls

# Small response caches
SEARCH_CACHE_TTL=45
GRAPH_CACHE_TTL=45
```

Notes :
- Vous pouvez également passer `INDEX_MAX_WORKERS` depuis l’éditeur via l’environnement ; il est transmis au backend pour `index_project`/`index_files`.
- Lors du déploiement sur Cloud Run, assurez-vous de disposer de ressources suffisantes (par exemple, `--cpu 4`, `--memory 8Gi`, une `--concurrency` plus élevée).

### Recherche dans la documentation Godot (RAG)

Voir **[Recherche dans la documentation Godot : Indexation et requêtes](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/./godot_doc_search.md)**.

#### Résolution des problèmes

**Problèmes d’éditeur et de compilation :**
- **Erreurs de compilation** : Voir la [documentation officielle de compilation de Godot](https://docs.godotengine.org/en/stable/development/compiling/index.html) pour les problèmes spécifiques à la plateforme
- **Problèmes de dépendances Python** : Assurez-vous d’utiliser Python 3.8+ et envisagez d’utiliser un environnement virtuel
- **Outils manquants** : Les outils du chatbot n’apparaîtront qu’une fois la connexion au backend établie

**Problèmes de backend IA :**
- **Problèmes de connexion** : Vérifiez que le backend tourne sur http://localhost:8000 et que les clés API sont correctement configurées
- **Recherche ne fonctionnant pas** : Vérifiez la connexion à Weaviate (WEAVIATE_URL et WEAVIATE_API_KEY dans .env)
- **Problèmes d’indexation** : Consultez les logs d’extraction de fonctions et de suivi des dépendances

> 🔧 **[Dépannage détaillé du backend](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md#troubleshooting)** pour les problèmes de recherche vectorielle, d’indexation et de configuration API

### Licence
- Code source original de Godot Engine : Expat (MIT). Voir `LICENSE.txt`.
- Composants tiers : voir `COPYRIGHT.txt` et licences sous `thirdparty/`.
- Contributions originales de Simplifine : source disponible non commerciale. Voir `NOTICE` et `LICENSES/COMPANY-NONCOMMERCIAL.md`.

Une licence commerciale est disponible. Contact : [support@simplifine.com]

### Attribution
Ce projet est basé sur Godot Engine par les contributeurs de Godot Engine, Juan Linietsky et Ariel Manzur. Nous ne sommes pas affiliés au projet Godot.

### Marque
Ce projet est une distribution indépendante par Simplifine. « Godot » et les marques associées sont la propriété de leurs détenteurs respectifs.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---