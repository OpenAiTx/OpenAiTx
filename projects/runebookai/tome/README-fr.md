# Tome - Grimoire Magique d’IA

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>une application de bureau magique qui met la puissance des LLM et MCP entre les mains de tous</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Rejoignez-nous!&color=9D7CD8" alt="Rejoignez-nous sur Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="Licence : Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="Version GitHub" /></a>
</p>

<p align="center">
    🔮 Téléchargez l’application de bureau Tome : <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome est une application de bureau qui permet à **tout le monde** de maîtriser la magie des LLM et MCP. Téléchargez Tome, connectez n'importe quel LLM local ou distant et reliez-le à des milliers de serveurs MCP pour créer votre propre grimoire magique alimenté par l’IA.

🫥 Vous voulez que ce soit 100% local, 100% privé ? Utilisez Ollama et Qwen3 avec uniquement des serveurs MCP locaux pour lancer des sorts dans votre propre univers de poche. ⚡ Vous souhaitez des modèles cloud de pointe avec les derniers serveurs MCP distants ? C’est possible aussi. C’est vous qui décidez !

🏗️ Ceci est une préversion technique, donc gardez à l'esprit que tout n'est pas parfaitement abouti. [Rejoignez-nous sur Discord](https://discord.gg/9CH6us29YA) pour partager vos astuces, conseils et signaler les problèmes rencontrés. Ajoutez une étoile à ce dépôt pour suivre les mises à jour et nouveautés !

## 🪄 Fonctionnalités

- 🧙 **Expérience fluide et accessible aux débutants**
  - Téléchargez et installez simplement Tome, puis connectez le LLM de votre choix
  - Pas besoin de manipuler JSON, Docker, python ou node
- 🤖 **Prise en charge des modèles d’IA**
  - **Distant** : Google Gemini, OpenAI, tout point de terminaison compatible API OpenAI
  - **Local** : Ollama, LM Studio, Cortex, tout point de terminaison compatible API OpenAI
- 🔮 **Support MCP amélioré**
  - Interface pour installer, supprimer, activer/désactiver les serveurs MCP
  - Serveurs MCP npm, uvx, node, python pris en charge nativement
- 🏪 **Intégration au registre [Smithery.ai](https://smithery.ai)**
  - Des milliers de serveurs MCP disponibles en un clic
- ✏️ **Personnalisation des fenêtres de contexte et de la température**
- 🧰 **Prise en charge native des appels d’outils et des modèles de raisonnement**
  - Améliorations de l’interface qui distinguent clairement les appels d’outils et les messages de réflexion

## Démo

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# Démarrage

## Prérequis

- MacOS ou Windows (Linux bientôt disponible !)
- Fournisseur de LLM au choix : [Ollama](https://ollama.com/) ou [clé API Gemini](https://aistudio.google.com/app/apikey) sont faciles/gratuits
- [Téléchargez la dernière version de Tome](https://github.com/runebookai/tome/releases)

## Démarrage rapide

1. Installez [Tome](https://github.com/runebookai/tome/releases)
2. Connectez votre fournisseur LLM préféré – OpenAI, Ollama et Gemini sont préconfigurés, mais vous pouvez aussi ajouter des fournisseurs comme LM Studio en utilisant http://localhost:1234/v1 comme URL
3. Ouvrez l’onglet MCP dans Tome et installez votre premier [serveur MCP](https://github.com/modelcontextprotocol/servers) (Fetch est un bon point de départ, il suffit de coller `uvx mcp-server-fetch` dans le champ serveur).
4. Discutez avec votre modèle propulsé par MCP ! Demandez-lui de récupérer la meilleure actualité sur Hacker News.

# Vision

Nous voulons rendre les LLM locaux et MCP accessibles à tous. Nous construisons un outil qui vous permet d’être créatif avec les LLM, que vous soyez ingénieur, bricoleur, amateur ou toute autre personne.

## Principes fondamentaux

- **Tome est local avant tout :** Vous contrôlez où vont vos données.
- **Tome est pour tous :** Vous ne devriez pas avoir à gérer des langages de programmation, des gestionnaires de paquets ou des fichiers de configuration json.

## Prochaines étapes

Nous avons reçu de nombreux retours incroyables ces dernières semaines depuis la sortie de Tome, mais nous avons de grands projets pour l’avenir. Nous voulons libérer les LLM de leur boîte de dialogue, et de nombreuses fonctionnalités arrivent pour vous aider à y parvenir.

- Tâches planifiées : les LLM devraient effectuer des tâches utiles même lorsque vous n’êtes pas devant l’ordinateur.
- Intégrations natives : les serveurs MCP sont un excellent moyen d’accéder à des outils et informations, mais nous voulons ajouter des intégrations encore plus puissantes pour interagir avec les LLM de manière unique.
- Générateur d’applications : à long terme, nous pensons que les meilleures expériences ne seront pas dans une interface de chat. Nous prévoyons d’ajouter des outils supplémentaires pour vous permettre de créer des applications et des workflows puissants.
- ??? Dites-nous ce que vous aimeriez voir ! Rejoignez notre communauté via les liens ci-dessous, nous serions ravis d’avoir vos retours.

# Communauté

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---