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

### C.O.R.E : Votre cerveau numérique pour l’ère de l’IA

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="Badge DeepWiki" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>Documentation</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**Moteur d’Observation Contextuelle et de Rappel**

C.O.R.E est un graphe de mémoire portable construit à partir de vos interactions avec les LLM et de vos données personnelles, rendant tout votre contexte et l’historique de vos flux de travail accessibles à n’importe quel outil d’IA, comme un cerveau numérique. Cela élimine le besoin de partager sans cesse le contexte. L’objectif est de fournir :

- **Mémoire unifiée et portable** : Ajoutez et retrouvez du contexte sans effort, et reliez votre mémoire à des applications comme Claude, Cursor, Windsurf, etc.
- **Relationnel, pas seulement des faits isolés** : CORE organise votre connaissance, stockant les faits et leurs relations pour une mémoire plus riche et profonde, comme un vrai cerveau.
- **Propriété utilisateur** : Vous décidez quoi conserver, mettre à jour ou supprimer et partagez votre mémoire avec l’outil de votre choix, sans dépendance à un fournisseur.

## 🎥 Vidéo de démonstration

[Voir la démo de C.O.R.E](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Tableau de bord Core" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  Fonctionnalités principales

- **Graphe de mémoire** : Visualisez les liens entre vos faits et préférences
- **Chat avec la mémoire** : Posez des questions à la mémoire pour des réponses et une compréhension instantanées
- **Plug n Play** : Utilisez instantanément la mémoire CORE dans des applications comme Cursor, Claude

## ☁️ Configuration Cloud C.O.R.E

1. Inscrivez-vous à [Core Cloud](https://core.heysol.ai) et commencez à construire votre graphe de mémoire.
2. Ajoutez le texte que vous souhaitez enregistrer dans la mémoire. En cliquant sur le bouton `+ Ajouter`, votre graphe de mémoire sera généré.
3. [Connectez la mémoire Core MCP à Cursor](#connecting-core-mcp-with-cursor)

## 💻 Configuration locale de C.O.R.E

#### Prérequis

1. Docker
2. Clé API OpenAI


> **Remarque :** Nous travaillons activement à l’amélioration de la prise en charge des modèles Llama. À l’heure actuelle, C.O.R.E ne fournit pas de résultats optimaux avec les modèles basés sur Llama, mais nous progressons afin d’assurer une meilleure compatibilité et de meilleurs résultats prochainement.
> 
#### Exécuter C.O.R.E en local

1. **Copiez les variables d’environnement**

   Copiez le fichier d’exemple d’environnement vers `.env` :


   ```bash
   cp .env.example .env
   ```
2. **Démarrer l’application**

   Utilisez Docker Compose pour démarrer tous les services requis :


   ```bash
   docker-compose up
   ```
3. **Accéder à l'application**

   Une fois les conteneurs lancés, ouvrez votre navigateur et allez sur [http://localhost:3000](http://localhost:3000).

4. **Créer un compte avec Magic Link**

   - Pour créer un compte, cliquez sur le bouton `Continuer avec l'email`

     <img width="865" height="490" alt="Créer un compte" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - Entrez votre email et cliquez sur le bouton `Envoyer un Magic Link`

     <img width="824" height="429" alt="Entrer l'email" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `Copiez le magic link depuis les logs du terminal` et ouvrez-le dans votre navigateur

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **Créez votre espace privé et ajoutez des données**

   - Dans le tableau de bord, allez dans la section en haut à droite -> Tapez un message, par ex., `J'aime jouer au badminton`, puis cliquez sur `+Ajouter`.
   - Votre mémoire est mise en file d'attente pour traitement ; vous pouvez suivre son statut dans la section `Logs`.
     
     <img width="1496" height="691" alt="Logs mémoire principale" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - Une fois le traitement terminé, des nœuds seront ajoutés à votre graphe de connaissances privé et visibles dans le tableau de bord.
   - Vous pouvez ensuite choisir de connecter cette mémoire à d'autres outils ou de la garder privée.

6. **Recherchez dans votre mémoire**

   - Utilisez la fonctionnalité de recherche du tableau de bord pour interroger vos données ingérées dans votre espace privé.


## Connecter CORE MCP avec Cursor

1. Ouvrez le tableau de bord CORE et allez dans la section API pour générer un nouveau jeton API.
2. Dans Cursor, allez à : Paramètres → Outils & Intégrations → Nouveau serveur MCP.
3. Ajoutez le serveur CORE MCP en utilisant le format de configuration ci-dessous. Veillez à remplacer la valeur API_TOKEN par le jeton généré à l'étape 1.

   Configuration MCP à ajouter dans Cursor


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. Allez dans Paramètres -> Règles utilisateur -> Nouvelle règle -> et ajoutez la règle ci-dessous pour vous assurer que toutes vos interactions de chat sont stockées dans la mémoire CORE


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## Documentation

Explorez notre documentation pour tirer le meilleur parti de CORE
- [Concepts de base](https://docs.heysol.ai/core/overview)
- [Référence API](https://docs.heysol.ai/core/local-setup)
- [Connecter Core Memory MCP avec Cursor](#connecting-core-mcp-with-cursor)


## 🧑‍💻 Support
Vous avez des questions ou des commentaires ? Nous sommes là pour vous aider :
- Discord : [Rejoignez le canal core-support](https://discord.gg/YGUZcvDjUa)
- Documentation : [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- Email : manik@poozle.dev

## Consignes d'utilisation

**À stocker :**

- Historique des conversations
- Préférences utilisateur
- Contexte des tâches
- Documents de référence

**À ne pas stocker :**

- Données sensibles (PII)
- Identifiants
- Journaux système
- Données temporaires

## 👥 Contributeurs

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---