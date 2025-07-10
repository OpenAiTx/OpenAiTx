# ProxyAsLocalModel

Proxy API LLM distant en tant que modèle local. Fonctionne notamment pour utiliser un LLM personnalisé dans JetBrains AI Assistant.

Propulsé par Ktor et kotlinx.serialization. Merci à leurs fonctionnalités sans réflexion.

## Histoire de ce projet

Actuellement, JetBrains AI Assistant propose un plan gratuit avec des quotas très limités. J'ai essayé et mon quota s'est rapidement épuisé.

J'avais déjà acheté d'autres jetons d'API LLM, tels que Gemini et Qwen. J'ai donc commencé à réfléchir à la façon de les utiliser dans AI Assistant. Malheureusement, seuls les modèles locaux de LM Studio et Ollama sont pris en charge. J'ai donc commencé à travailler sur cette application proxy qui fait l’intermédiaire entre des API LLM tierces et les API de LM Studio et Ollama afin de pouvoir les utiliser dans mes IDE JetBrains.

C'est une tâche assez simple, j'ai donc commencé à utiliser les SDK officiels comme clients et à écrire un serveur Ktor simple qui fournit les endpoints de LM Studio et Ollama. Le problème est apparu lorsque j'ai essayé de le distribuer en tant qu'image native GraalVM. Les SDK Java officiels utilisent trop de fonctionnalités dynamiques, ce qui rend la compilation en image native difficile, même avec un agent de traçage. J'ai donc décidé d’implémenter moi-même un client simple pour l’API de complétion de chat en streaming avec Ktor et kotlinx.serialization, qui sont tous deux sans réflexion, fonctionnels et orientés DSL.

Comme vous pouvez le constater, cette application est distribuée sous forme de jar exécutable autonome et d’image native GraalVM, ce qui la rend multiplateforme et rapide au démarrage.

Le développement de cette application m'a donné confiance dans Kotlin/Ktor/kotlinx.serialization. Le monde Kotlin utilise plus de programmation fonctionnelle et moins de réflexion, ce qui le rend plus adapté à l'image native GraalVM, avec un démarrage plus rapide et une consommation mémoire réduite.

## Actuellement pris en charge

Proxy depuis : OpenAI, Claude, DashScope (Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

Proxy en tant que : LM Studio, Ollama.

API de complétion de chat en streaming uniquement.
## Comment utiliser

Cette application est un serveur proxy, distribuée sous forme de jar exécutable complet et d’une image native GraalVM (Windows x64).

Exécutez l’application, et vous verrez un message d’aide :

```
2025-05-02 10:43:53 INFO  Help - Il semble que vous démarrez le programme pour la première fois ici.
2025-05-02 10:43:53 INFO  Help - Un fichier de configuration par défaut a été créé à votre_chemin\config.yml avec annotation de schéma.
2025-05-02 10:43:53 INFO  Config - Surveillance du fichier de configuration démarrée à votre_chemin\config.yml
2025-05-02 10:43:53 INFO  LM Studio Server - Serveur LM Studio démarré sur 1234
2025-05-02 10:43:53 INFO  Ollama Server - Serveur Ollama démarré sur 11434
2025-05-02 10:43:53 INFO  Model List - Liste des modèles chargée avec : []
```

Vous pouvez ensuite éditer le fichier de configuration pour configurer votre serveur proxy.

## Fichier de configuration

Ce fichier de configuration est automatiquement rechargé à chaud lorsque vous le modifiez. Seules les parties concernées du serveur seront mises à jour.

Lors de la première génération du fichier de configuration, il sera créé avec des annotations de schéma. Cela apportera la complétion et la vérification dans votre éditeur.
## Exemple de fichier de configuration

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # Ceci est la valeur par défaut
  enabled: true # Ceci est la valeur par défaut
  host: 0.0.0.0 # Ceci est la valeur par défaut
  path: /your/path # Sera ajouté avant les points de terminaison d'origine, la valeur par défaut est vide
ollama:
  port: 11434 # Ceci est la valeur par défaut
  enabled: true # Ceci est la valeur par défaut
  host: 0.0.0.0 # Ceci est la valeur par défaut
  path: /your/path # Sera ajouté avant les points de terminaison d'origine, la valeur par défaut est vide
client:
  socketTimeout: 1919810 # Long.MAX_VALUE est la valeur par défaut, en millisecondes
  connectionTimeout: 1919810 # Long.MAX_VALUE est la valeur par défaut, en millisecondes
  requestTimeout: 1919810 # Long.MAX_VALUE est la valeur par défaut, en millisecondes
  retry: 3 # Ceci est la valeur par défaut
  delayBeforeRetry: 1000 # Ceci est la valeur par défaut, en millisecondes

apiProviders:
  OpenAI:
    type: OpenAi
    baseUrl: https://api.openai.com/v1
    apiKey: <votre_clé_api>
    modelList:
      - gpt-4o
  Claude:
    type: Claude
    apiKey: <votre_clé_api>
    modelList:
      - claude-3-7-sonnet
  Qwen:
    type: DashScope
    apiKey: <votre_clé_api>
    modelList: # Ceci est la valeur par défaut
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <votre_clé_api>
    modelList: # Ceci est la valeur par défaut
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <votre_clé_api>
    modelList: # Ceci est la valeur par défaut
      - codestral-latest
      - mistral-large
  SiliconFlow:
    type: SiliconFlow
    apiKey: <votre_clé_api>
    modelList:
      - Qwen/Qwen3-235B-A22B
      - Pro/deepseek-ai/DeepSeek-V3
      - THUDM/GLM-4-32B-0414
  OpenRouter:
    type: OpenRouter
    apiKey: <votre_clé_api>
    modelList:
      - openai/gpt-4o
  Gemini:
    type: Gemini
    apiKey: <votre_clé_api>
    modelList:
      - gemini-2.5-flash-preview-04-17
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---