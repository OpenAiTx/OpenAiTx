# AI Partner Chat

Un projet Claude Skills qui fait de l’IA votre partenaire de conversation personnalisé.

## Présentation du projet

AI Partner Chat offre une expérience de dialogue personnalisée et contextuelle en intégrant le profil utilisateur, le profil IA et des notes personnelles vectorisées. Cette compétence permet à l’IA de se souvenir et de faire référence à vos idées, préférences et bases de connaissances précédentes, créant ainsi une interaction plus cohérente et personnalisée.

## Fonctionnalités principales

### 🎭 Système à double profil
- **Profil utilisateur** : définit votre contexte, expertise, intérêts et préférences de communication
- **Profil IA** : personnalise le rôle de l’IA, son style de communication et son mode d’interaction

### 📝 Recherche intelligente dans les notes
- Indexation automatique de vos notes Markdown
- Recherche intelligente des historiques pertinents selon le contenu de la conversation
- Référence naturelle à vos idées et notes passées dans la conversation

### 💬 Dialogue personnalisé
- Génération de réponses personnalisées basées sur vos profils et notes
- Maintien de la cohérence contextuelle du dialogue
- Référence naturelle à vos idées comme un ami, et non de manière mécanique « selon les enregistrements »

## Cas d’utilisation

Lorsque vous avez besoin de :
- Communication personnalisée plutôt que de réponses génériques
- Réponses contextuelles où l’IA se souvient de votre contexte
- L’IA qui se souvient et fait référence à vos idées et notes précédentes
- Une expérience de dialogue continue plutôt que chaque fois un nouveau départ

## Installation et utilisation

### Installation de la compétence

Copiez ce projet dans le dossier `.claude/skills/` de votre répertoire de travail :

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Utilisation des compétences

Dans Claude Code, envoyez la commande suivante pour activer cette compétence :

```
遵循 ai-partner-chat 对话
```

L'agent IA va automatiquement :
- Lire la configuration des compétences et les instructions
- Créer la structure de répertoires nécessaire (`notes/`, `config/`, `vector_db/`, etc.)
- Initialiser selon vos besoins

### Processus d'initialisation

#### Méthode 1 : Laisser l'IA créer et configurer automatiquement

Lors de la première utilisation, dites simplement à l'IA :

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```

L'agent IA peut :
1. Analyser le contenu des notes dans le répertoire `notes/`
2. Segmenter intelligemment selon le format des notes et créer une base de données vectorielle
3. Déduire votre contexte et vos préférences à partir du contenu des notes
4. Générer et mettre à jour automatiquement `config/user-persona.md`
5. Recommander et créer `config/ai-persona.md` selon vos caractéristiques

#### Méthode 2 : Configuration manuelle du profil

Si vous souhaitez définir vous-même le profil :
1. L'agent IA crée automatiquement les fichiers de profil à partir d'un modèle dans le répertoire `config/`
2. Vous pouvez modifier manuellement ces fichiers pour personnaliser le profil
3. Puis indiquer à l'IA de procéder à la vectorisation

### Commencer la conversation

Une fois la configuration terminée, il suffit d'envoyer à chaque utilisation :

```
遵循 ai-partner-chat 对话
```

L'IA va :  
- Lire votre profil pour comprendre votre contexte  
- Récupérer les notes historiques pertinentes  
- Générer des réponses personnalisées et contextuellement adaptées  

## Structure du projet  

### Structure du package de compétences (située dans `.claude/skills/ai-partner-chat/`)  

```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Répertoire des données utilisateur (situé à la racine du projet)

L'agent IA créera la structure suivante à la racine de votre projet :

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Important** : Les données utilisateur sont séparées des packs de compétences, facilitant ainsi la sauvegarde et la migration.

## Flux de travail

1. **Chargement du profil** : Lire le profil utilisateur et le profil IA, comprendre le contexte d’interaction  
2. **Recherche de notes** : Récupérer les notes les plus pertinentes dans la base de données vectorielle selon la requête utilisateur  
3. **Construction du contexte** : Intégrer les informations du profil, les notes pertinentes et l’historique de la conversation  
4. **Génération de réponse** : Produire une réponse personnalisée et naturelle basée sur le contexte  

## Points forts

### 🤖 Agent IA découpage intelligent  
Le système analyse le format réel de chaque note et génère dynamiquement la stratégie de découpage la plus adaptée, au lieu d’utiliser un modèle prédéfini. Cela signifie que peu importe le format de vos notes, elles seront traitées de manière optimale.

### 🎯 Citations naturelles  
L’IA intègre vos informations passées de manière naturelle, comme un souvenir, sans dire maladroitement « selon les enregistrements », mais en les intégrant fluidement dans la conversation.

### 📦 Données indépendantes  
Toutes vos données (notes, profils, base vectorielle) sont stockées dans le répertoire racine du projet, facilitant la sauvegarde, la migration ou le partage entre différentes compétences.

## Bonnes pratiques

### Conception du profil  
- **Précis et clair** : Un profil vague conduit à des réponses génériques  
- **Inclure des exemples** : Montrer dans le profil IA les modes d’interaction attendus  
- **Mise à jour régulière** : Optimiser continuellement le profil selon la qualité des conversations  

### Gestion des notes  
- **Format libre** : Le système s’adapte à toute structure de note  
- **Contenu riche** : Des notes approfondies améliorent la qualité des recherches  
- **Mise à jour rapide** : Ajouter rapidement les nouvelles notes à l’index  

### Expérience de conversation  
- **Citations naturelles** : Ne citer les notes que lorsque c’est vraiment pertinent  
- **Maintenir la fluidité** : Ne pas laisser les citations interrompre le rythme naturel de la conversation  
- **Focus sur la qualité** : Prioriser les connexions significatives plutôt que la quantité  

## Maintenance et mise à jour

### Ajouter une nouvelle note
Après avoir placé la nouvelle note dans le répertoire `notes/`, informez l'IA :

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

L'agent IA analysera automatiquement les nouvelles notes et mettra à jour l'index.

### Mise à jour du profil
Vous pouvez éditer directement les fichiers de profil dans le répertoire `config/`, ou indiquer à l'IA :

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Reconstruire l'index
Lorsque la structure des notes subit un changement majeur, informez l'IA :

```
请重新初始化向量数据库
```

L’agent IA réanalysera toutes les notes et reconstruira l’index.

## Remarques

- **Première exécution** : Lors de la première création de la base de données vectorielle, l’agent IA téléchargera automatiquement le modèle d’intégration (environ 4,3 Go), veuillez patienter
- **Environnement Python** : L’agent IA créera automatiquement un environnement virtuel et installera les dépendances nécessaires
- **Stockage des données** : Toutes les données (notes, profils, base vectorielle) sont stockées à la racine du projet, et non dans le dossier du package de compétences
- **Emplacement du package** : Assurez-vous que le package de compétences se trouve dans le répertoire `.claude/skills/ai-partner-chat/`

## Plus d’informations

Pour plus de détails techniques et les instructions d’utilisation, veuillez consulter le fichier `SKILL.md`.

---

Faites de l’IA un véritable partenaire de conversation qui vous comprend, pas seulement un outil.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-18

---