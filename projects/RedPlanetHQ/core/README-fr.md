<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="Logo CORE" />
  </a>

### CORE : Votre couche mémoire personnelle pour les applications IA

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="Badge DeepWiki" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Documentation</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Points forts de la recherche

La mémoire CORE atteint une précision moyenne de **88,24%** sur le jeu de données Locomo pour toutes les tâches de raisonnement, dépassant nettement les autres fournisseurs de mémoire. Consultez ce [blog](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/) pour plus d’informations.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Les questions à un seul saut nécessitent des réponses basées sur une seule session ; (2) Les questions à plusieurs sauts exigent de synthétiser des informations provenant de plusieurs sessions différentes ; (3) Les questions de connaissances en domaine ouvert peuvent être résolues en intégrant les informations fournies par l’intervenant avec des connaissances externes telles que le bon sens ou des faits mondiaux ; (4) Les questions de raisonnement temporel peuvent être résolues grâce au raisonnement temporel et à la capture d’indices liés au temps dans la conversation ;

## Aperçu

**Problème** 

Les développeurs perdent du temps à réexpliquer le contexte aux outils d’IA. Atteignez-vous la limite de jetons sur Claude ? Vous recommencez et perdez tout. Passez de ChatGPT/Claude à Cursor ? Expliquez à nouveau votre contexte. Vos conversations, décisions et idées disparaissent entre les sessions. À chaque nouvel outil d’IA, le coût du changement de contexte augmente.

**Solution** - **CORE** (**Contextual Observation & Recall Engine**)

CORE est une couche mémoire unifiée, persistante et open-source pour tous vos outils d’IA. Votre contexte vous suit de Cursor à Claude, de ChatGPT à Claude Code. Un seul graphe de connaissances retient qui a dit quoi, quand et pourquoi. Connectez-vous une fois, souvenez-vous partout. Arrêtez de gérer le contexte, commencez à construire.

## 🚀 Auto-hébergement de CORE
Vous souhaitez exécuter CORE sur votre propre infrastructure ? L’auto-hébergement vous donne un contrôle total sur vos données et votre déploiement.

**Prérequis** :

- Docker (20.10.0+) et Docker Compose (2.20.0+) installés
- Clé API OpenAI

> **Remarque sur les modèles open-source :** Nous avons testé des options OSS comme Ollama et les modèles GPT, mais leur extraction de faits et la qualité du graphe étaient insuffisantes. Nous recherchons activement d’autres options.

### Installation

1. Clonez le dépôt :
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Configurez les variables d'environnement dans `core/.env` :
```
OPENAI_API_KEY=your_openai_api_key
```
3. Démarrer le service
```
docker-compose up -d
```

Une fois déployé, vous pouvez configurer vos fournisseurs d’IA (OpenAI, Anthropic) et commencer à construire votre graphe de mémoire.

👉 [Voir le guide complet d’auto-hébergement](https://docs.heysol.ai/self-hosting/docker)

Remarque : Nous avons essayé des modèles open-source comme Ollama ou GPT OSS mais la génération de faits n’était pas satisfaisante, nous cherchons encore comment améliorer cela et nous prendrons en charge les modèles OSS par la suite.

## 🚀 CORE Cloud
**Construisez votre graphe de mémoire unifié en 5 minutes :**

Vous ne voulez pas gérer l’infrastructure ? CORE Cloud vous permet de créer instantanément votre système de mémoire personnel - pas d’installation, pas de serveurs, juste une mémoire qui fonctionne.

1. **Inscrivez-vous** sur [core.heysol.ai](https://core.heysol.ai) et créez votre compte
2. **Visualisez votre graphe de mémoire** et voyez comment CORE établit automatiquement des connexions entre les faits
3. **Testez-le** - demandez « Que sais-tu de moi ? » dans la section conversation
4. Connectez-vous à vos outils :
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - coder avec du contexte
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) - programmation en terminal avec mémoire
   - [Ajouter l’extension de navigateur](https://docs.heysol.ai/providers/browser-extension) - apportez votre mémoire sur n’importe quel site web
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) - ajoutez automatiquement le contexte de vos projets

## 🧩 Fonctionnalités clés

### 🧠 **Mémoire Unifiée et Portable** : 
Ajoutez et rappelez votre mémoire sur **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS Kiro, VS Code et Roo Code** via MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Graphe de Connaissance Temporel + Réifié** : 

Retenez l’histoire derrière chaque fait—suivez qui a dit quoi, quand et pourquoi avec des relations riches et une provenance complète, pas juste un stockage plat

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Extension de Navigateur** : 

Sauvegardez conversations et contenus de ChatGPT, Grok, Gemini, Twitter, YouTube, articles de blogs et toute page web directement dans votre mémoire CORE.

**Comment utiliser l’extension**  
1. [Téléchargez l’extension](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) depuis le Chrome Web Store.  
2. Connectez-vous au [tableau de bord CORE](https://core.heysol.ai)  
   - Allez dans Paramètres (en bas à gauche)  
   - Rendez-vous sur Clé API → Générer une nouvelle clé → Nommez-la “extension.”  
3. Ouvrez l’extension, collez votre clé API et sauvegardez.  

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a  


### 💬 **Discuter avec la mémoire** :  
Posez des questions comme « Quelles sont mes préférences d’écriture ? » et obtenez des informations instantanées depuis vos connaissances connectées  

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)  


### ⚡ **Synchronisation automatique depuis les applications** :  

Capturez automatiquement le contexte pertinent depuis Linear, Slack, Notion, GitHub et d’autres applications connectées dans votre mémoire CORE  

📖 **[Voir toutes les intégrations](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** – Liste complète des services pris en charge et de leurs fonctionnalités  

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)  


### 🔗 **Hub d’intégration MCP** :  

Connectez Linear, Slack, GitHub, Notion une seule fois à CORE—puis utilisez tous leurs outils dans Claude, Cursor ou tout client MCP via une seule URL  


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)  



## Comment CORE crée la mémoire  

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />  

Le pipeline d’ingestion de CORE comporte quatre phases conçues pour capturer le contexte évolutif :

1. **Normalisation** : Relie les nouvelles informations au contexte récent, divise les longs documents en segments cohérents tout en conservant les références croisées, et standardise les termes afin que, lorsque CORE extrait la connaissance, il travaille avec un contenu propre et contextualisé plutôt qu’avec du texte désordonné.
2. **Extraction** : Tire le sens du texte normalisé en identifiant les entités (personnes, outils, projets, concepts), les transformant en déclarations avec contexte, source et date, et en cartographiant les relations. Par exemple, « Nous avons écrit CORE en Next.js » devient : Entités (Core, Next.js), Déclaration (CORE a été développé avec Next.js), et Relation (a été développé avec).
3. **Résolution** : Détecte les contradictions, suit l’évolution des préférences, et préserve plusieurs points de vue avec provenance au lieu de les écraser, afin que la mémoire reflète l’ensemble de votre parcours et non seulement la dernière version.
4. **Intégration au graphe** : Relie les entités, déclarations et épisodes dans un graphe de connaissance temporel qui associe les faits à leur contexte et leur histoire, transformant des données isolées en un réseau vivant que les agents peuvent réellement exploiter.

Le résultat : Au lieu d’une base de données plate, CORE vous offre une mémoire qui évolue avec vous – préservant le contexte, l’évolution et la propriété afin que les agents puissent vraiment l’utiliser.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Comment CORE retrouve la mémoire

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Lorsque vous posez une question à CORE, il ne se contente pas de rechercher du texte – il explore l’ensemble de votre graphe de connaissance pour trouver les réponses les plus utiles.

1. **Recherche** : CORE parcourt la mémoire sous plusieurs angles à la fois – recherche par mots-clés pour les correspondances exactes, recherche sémantique pour les idées associées même si elles sont formulées différemment, et exploration du graphe pour suivre les liens entre concepts connectés.
2. **Reclassement** : Les résultats récupérés sont réordonnés pour mettre en avant les plus pertinents et diversifiés, afin que vous ne voyiez pas seulement les correspondances évidentes mais aussi des liens plus profonds.
3. **Filtrage** : CORE applique des filtres intelligents basés sur le temps, la fiabilité et la force des relations, afin que seules les connaissances les plus significatives soient mises en avant.
4. **Sortie** : Vous récupérez à la fois des faits (déclarations claires) et des épisodes (le contexte original dont ils proviennent), pour que le rappel soit toujours ancré dans le contexte, le temps et l’histoire.

Le résultat : CORE ne se contente pas de rappeler des faits – il les restitue dans le bon contexte, au bon moment et avec l’histoire, pour que les agents répondent comme vous vous en souviendriez.

## Documentation

Explorez notre documentation pour tirer le meilleur parti de CORE

- [Concepts de base](https://docs.heysol.ai/concepts/memory_graph)
- [Auto-hébergement](https://docs.heysol.ai/self-hosting/overview)
- [Connecter Core MCP à Claude](https://docs.heysol.ai/providers/claude)
- [Connecter Core MCP à Cursor](https://docs.heysol.ai/providers/cursor)
- [Connecter Core MCP à Claude Code](https://docs.heysol.ai/providers/claude-code)
- [Connecter Core MCP à Codex](https://docs.heysol.ai/providers/codex)

- [Concepts de base](https://docs.heysol.ai/overview)
- [Référence API](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Sécurité

CORE prend la sécurité très au sérieux. Nous mettons en œuvre des pratiques de sécurité de pointe pour protéger vos données :

- **Chiffrement des données** : Toutes les données en transit (TLS 1.3) et au repos (AES-256)
- **Authentification** : OAuth 2.0 et authentification par lien magique
- **Contrôle d’accès** : Isolation basée sur l’espace de travail et permissions basées sur les rôles
- **Signalement de vulnérabilités** : Veuillez signaler les problèmes de sécurité à harshith@poozle.dev

Pour des informations de sécurité détaillées, consultez notre [Politique de sécurité](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Support

Des questions ou des retours ? Nous sommes là pour vous aider :

- Discord : [Rejoindre le canal core-support](https://discord.gg/YGUZcvDjUa)
- Documentation : [docs.heysol.ai](https://docs.heysol.ai)
- Email : manik@poozle.dev

## Directives d’utilisation

**À conserver :**

- Historique des conversations
- Préférences utilisateur
- Contexte de la tâche
- Matériaux de référence

**À ne pas conserver :**

- Données sensibles (PII)
- Identifiants
- Journaux système
- Données temporaires

## 👥 Contributeurs

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---