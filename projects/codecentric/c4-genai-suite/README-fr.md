# c4 GenAI Suite

Une application chatbot IA avec intégration du Fournisseur de Contexte de Modèle (MCP), propulsée par Langchain et compatible avec tous les principaux grands modèles de langage (LLM) et modèles d'embedding.

Les administrateurs peuvent créer des assistants dotés de différentes capacités en ajoutant des extensions, telles que des services RAG (génération augmentée par récupération) ou des serveurs MCP. L'application est construite avec une pile technologique moderne, incluant React, NestJS et Python FastAPI pour le service REI-S.

Les utilisateurs peuvent interagir avec les assistants via une interface conviviale. Selon la configuration de l'assistant, les utilisateurs peuvent poser des questions, télécharger leurs propres fichiers, ou utiliser d'autres fonctionnalités. Les assistants interagissent avec différents fournisseurs de LLM pour fournir des réponses basées sur les extensions configurées. Les informations contextuelles fournies par les extensions configurées permettent aux assistants de répondre à des questions spécifiques à un domaine et de fournir des informations pertinentes.

L'application est conçue pour être modulaire et extensible, permettant aux utilisateurs de créer des assistants dotés de différentes capacités en ajoutant des extensions.

![courte vidéo de démonstration de l'utilisation de base](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Fonctionnalités

### Grands Modèles de Langage (LLM) et Modèles Multimodaux

La c4 GenAI Suite prend déjà en charge de nombreux modèles directement. Et si votre modèle préféré n'est pas encore pris en charge, il devrait être facile d'écrire une extension pour l'ajouter.

* Modèles compatibles OpenAI
* Modèles Azure OpenAI
* Modèles Bedrock
* Modèles Google GenAI
* Modèles compatibles Ollama
### Génération Augmentée par la Recherche (RAG)

La suite c4 GenAI comprend REI-S, un serveur pour préparer les fichiers à la consommation par le LLM.

* REI-S, un serveur RAG intégré et personnalisé
  * Stockages vectoriels
    * pgvector
    * Azure AI Search
  * Modèles d’embedding
    * Embeddings compatibles OpenAI
    * Embeddings Azure OpenAI
    * Embeddings compatibles Ollama
  * Formats de fichiers :
    * pdf, docx, pptx, xlsx, ...
    * Transcription vocale de fichiers audio (via Whisper)

### Extensions

La suite c4 GenAI est conçue pour être extensible. Écrire des extensions est facile, tout comme utiliser un serveur MCP déjà existant.

* Serveurs Model Context Protocol (MCP)
* Systemprompt personnalisé
* Recherche Bing
* Calculatrice
## Démarrage

### Utilisation de Docker-Compose

- Exécutez `docker compose up` à la racine du projet.
- Ouvrez l'[application](http://localhost:3333) dans un navigateur. Les identifiants de connexion par défaut sont utilisateur `admin@example.com` et mot de passe `secret`.

![vidéo montrant la configuration de l’assistant](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Utilisation de Helm & Kubernetes

Pour le déploiement dans des environnements Kubernetes, veuillez consulter le [README de notre Helm Chart](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Configuration des assistants et des extensions

La suite c4 GenAI s'articule autour des *assistants*.
Chaque assistant se compose d'un ensemble d'extensions, qui déterminent le modèle LLM et les outils qu'il peut utiliser.

- Dans la zone d'administration (cliquez sur le nom d'utilisateur en bas à gauche), allez dans la [section assistants](http://localhost:3333/admin/assistants).
- Ajoutez un assistant avec le bouton vert `+` à côté du titre de la section. Choisissez un nom et une description.
- Sélectionnez l’assistant créé et cliquez sur le bouton vert `+ Ajouter une extension`.
- Sélectionnez le modèle et renseignez les identifiants.
- Utilisez le bouton `Tester` pour vérifier que cela fonctionne et `enregistrez`.

Vous pouvez maintenant retourner sur la [page de chat](http://localhost:3333/chat) (cliquez sur `c4 GenAI Suite` en haut à gauche) et démarrer une nouvelle conversation avec votre nouvel assistant.

> [!ASTUCE]
> Notre `docker-compose` inclut un Ollama local, qui fonctionne sur le CPU. Vous pouvez l'utiliser pour des tests rapides. Mais il sera lent et vous voudrez probablement utiliser un autre modèle. Si vous souhaitez l'utiliser, créez simplement l'extension de modèle suivante dans votre assistant.
> * Extension : `Dev: Ollama`
> * Endpoint : `http://ollama:11434`
> * Modèle : `llama3.2`

### Protocole de Contexte de Modèle (MCP) [optionnel]

Utilisez n'importe quel serveur MCP offrant une interface `sse` avec l'extension `MCP Tools` (ou utilisez notre `mcp-tool-as-server` comme proxy devant un serveur MCP `stdio`).
Chaque serveur MCP peut être configuré en détail en tant qu'extension.

### Génération Augmentée par la Recherche (RAG) / Recherche de Fichiers [optionnel]

Utilisez notre serveur RAG `REI-S` pour rechercher dans les fichiers fournis par l'utilisateur. Il suffit de configurer une extension `Search Files` pour l’assistant.
Ce processus est décrit en détail dans [le sous-répertoire `services/reis`](services/reis/#example-configuration-in-c4).

## Contribution & Développement

* Voir [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) pour les directives de contribution.
* Pour l'intégration des développeurs, consultez [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Principaux Blocs de Construction

L’application se compose d’un **Frontend**, d’un **Backend** et d’un service **REI-S**.

```
┌──────────┐
│ Utilisateur │
└─────┬────┘
      │ accès
      ▼
┌──────────┐
│ Frontend │
└─────┬────┘
      │ accès
      ▼
┌──────────┐     ┌─────────────────┐
│ Backend  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ accès
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Modèle d’Embedding │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Vector Store   │
└──────────┘     └─────────────────┘
```
### Frontend

Le frontend est construit avec React et TypeScript, offrant une interface conviviale pour interagir avec le backend et le service REI-S. Il inclut des fonctionnalités pour gérer les assistants, les extensions et les fonctions de chat.

> Sources : `/frontend`

### Backend

Le backend est développé avec NestJS et TypeScript, servant de couche principale d’API pour l’application. Il gère les requêtes du frontend et interagit avec les fournisseurs llm pour faciliter les fonctionnalités de chat. Le backend gère également les assistants et leurs extensions, permettant aux utilisateurs de configurer et d’utiliser divers modèles d’IA pour leurs discussions.

De plus, le backend gère l’authentification des utilisateurs et communique avec le service REI-S pour l’indexation et la récupération de fichiers.

Pour la persistance des données, le backend utilise une base de données **PostgreSQL**.

> Sources : `/backend`

### REI-S

Le REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) est un serveur basé sur Python qui fournit des capacités de base RAG (Retrieval-Augmented Generation). Il permet l’extraction de contenu de fichiers, l’indexation et l’interrogation, permettant à l’application de gérer efficacement de grands ensembles de données. Le service REI-S est conçu pour fonctionner de manière transparente avec le backend, fournissant les données nécessaires pour les fonctionnalités de chat et les recherches de fichiers.

Le REI-S prend en charge Azure AI Search et pgvector pour le stockage vectoriel, offrant des options de récupération de données flexibles et évolutives. Le service peut être configuré à l’aide de variables d’environnement pour spécifier le type de stockage vectoriel et les détails de connexion.

> Sources : `/services/reis`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---