# NovelWeave - Extension VSCode d’Écriture de Roman Assistée par IA

[English](#) | [简体中文](https://raw.githubusercontent.com/wordflowlab/novelweave/main/README.zh-CN.md)

> 🌟 Transformez votre expérience d’écriture de roman grâce à une assistance par IA, une méthodologie structurée et une intégration transparente dans VSCode.
>
> Basé sur la méthodologie éprouvée de [novel-writer](https://github.com/wordflowlab/novel-writer), NovelWeave apporte des outils professionnels de création de roman directement dans votre flux de travail VSCode.

## ✨ Fonctionnalités Clés

- 📝 **Méthodologie en Sept Étapes** - Flux de travail de création de roman basé sur des spécifications
- 🎨 **Interface Visuelle** - Barre latérale intuitive, panneaux webview et chat IA intégré
- 🤖 **Support Multi-IA** - Claude 4, GPT-4, Gemini Pro, et plus de 400 modèles IA
- 🧠 **Compétences d’Agent** - Système modulaire de connaissances IA pour une expertise d’écriture spécialisée
- 📊 **Gestion de Projet** - Suivi des chapitres, profils des personnages, fils d’intrigue
- 🔌 **Commandes Slash** - Support complet du système de commandes novel-writer
- ✅ **Assurance Qualité** - Suivi de l’intrigue, gestion de la chronologie, validation de la cohérence
- 🌐 **Multi-Plateforme** - Fonctionne sous Windows, macOS et Linux

## 🚀 Démarrage Rapide

### 1. Installation

Installez NovelWeave depuis le Marketplace VSCode :

```bash
# Search "NovelWeave" in VSCode Extensions
# Or install via command:
code --install-extension novelweave.novelweave
```

### 2. Créez Votre Premier Projet de Roman

1. Ouvrez VSCode et cliquez sur l'icône NovelWeave dans la barre d'activité
2. Cliquez sur "Nouveau Projet" pour initialiser un projet de roman
3. Choisissez votre modèle d'IA et configurez les paramètres
4. Commencez à écrire avec l'aide de l'IA !

### 3. Utilisez la Méthodologie en Sept Étapes

NovelWeave met en œuvre la méthodologie éprouvée de création de roman en sept étapes :

```
1. /constitution  → Establish core creative principles
2. /specify       → Define story requirements
3. /clarify       → Resolve ambiguities through Q&A
4. /plan          → Design technical implementation
5. /tasks         → Break down into actionable steps
6. /write         → Execute the actual writing
7. /analyze       → Validate quality and consistency
```

## 📚 Méthodologie en sept étapes

### Étape 1 : `/constitution` - Constitution créative

Définissez vos principes d’écriture incontournables, vos directives stylistiques et vos valeurs fondamentales qui guideront l’ensemble de votre roman.

### Étape 2 : `/specify` - Spécification de l’histoire

Comme un document de spécifications produit (PRD), définissez exactement l’histoire que vous souhaitez créer, le public cible et les critères de succès.

### Étape 3 : `/clarify` - Clarifications critiques

L’IA identifie les ambiguïtés dans votre spécification et génère jusqu’à 5 questions clés pour éliminer toute confusion avant l’écriture.

### Étape 4 : `/plan` - Plan créatif

Transformez les exigences abstraites en solutions techniques concrètes : structure des chapitres, arcs des personnages, création du monde et chronologie de l’intrigue.

### Étape 5 : `/tasks` - Décomposition des tâches

Décomposez le plan en tâches d’écriture exécutables avec des priorités claires et des dépendances définies.

### Étape 6 : `/write` - Exécution de l’écriture

Écrivez selon votre liste de tâches, en suivant vos principes de constitution et votre plan créatif.

### Étape 7 : `/analyze` - Validation complète

Validez la cohérence de l’intrigue, l’exactitude de la chronologie, le développement des personnages et le respect de vos principes créatifs.

> 📖 **Méthodologie détaillée** : En savoir plus dans la [documentation novel-writer](https://github.com/wordflowlab/novel-writer)

## 🔧 NovelWeave vs novel-writer CLI

| Fonctionnalité         | novel-writer CLI       | NovelWeave VSCode                   |
| ---------------------- | ---------------------- | ---------------------------------- |
| **Interface**          | Ligne de commande      | Interface graphique                |
| **Installation**       | `npm install -g`       | Marketplace VSCode                 |
| **Intégration IA**     | Basique                | Chat IA complet & assistance       |
| **Gestion de Projet**   | Système de fichiers    | Espace de travail VSCode + panneaux UI |
| **Commandes Slash**    | ✅                     | ✅                                     |
| **Suivi Visuel**       | ❌                     | ✅ (Intrigue, personnages, chronologie)|
| **Courbe d’Apprentissage** | Familiarité CLI requise | Interface intuitive                   |
| **Idéal Pour**         | Écrivains technophiles | Tous les écrivains, surtout utilisateurs VSCode |

**Ils fonctionnent ensemble !** Utilisez le CLI novel-writer pour l’automatisation et les scripts, tandis que NovelWeave offre l’interface visuelle et l’interaction IA.

## 🎯 Cas d’Utilisation

- **Romans Longs** - Gérer des intrigues complexes avec plus de 100 chapitres
- **Écriture de Séries Web** - Mises à jour quotidiennes régulières avec assistance IA
- **Scénarios & Scripts** - Narration structurée avec gestion des scènes
- **Fan Fiction** - Maintenir la cohérence avec le matériel source
- **Écriture Créative** - Tout projet narratif bénéficie d’une méthodologie structurée

## 📖 Fonctionnalités en Détail

### Système de Compétences Agent

Le système innovant **Agent Skills** de NovelWeave fournit à votre assistant IA des modules de connaissances spécialisés activables à la demande :

- **Compétences Intégrées** - Expertise professionnelle en écriture incluant :
    - Connaissances de genre (Romance, Mystère, Fantastique)
    - Techniques d’écriture (Dialogue, Structure de scène)
    - Assurance qualité (Vérification de cohérence, détection d’exigences)
- **Compétences de Projet** - Partagez les directives spécifiques à l’équipe dans `.agent/skills/`
- **Compétences Personnelles** - Votre propre bibliothèque de connaissances réutilisables
- **Activation Intelligente** - L’IA sélectionne automatiquement les compétences pertinentes selon la tâche
- **Compétences Personnalisées** - Créez vos propres modules d’expertise avec un Markdown simple

> 📖 **En savoir plus** : Consultez le [Guide utilisateur Agent Skills](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) pour des instructions détaillées.

### Assistant d’Écriture Propulsé par IA

- **Continuation Intelligente** - L’IA suggère les paragraphes suivants selon votre style
- **Voix des Personnages** - Maintenir la personnalité cohérente des personnages
- **Suggestions d’Intrigue** - L’IA aide à résoudre les incohérences et les problèmes de rythme
- **Analyse de Style** - Retour sur le style d’écriture et la lisibilité

### Organisation du Projet

- **Gestion des Chapitres** - Naviguer et organiser les chapitres dans la barre latérale  
- **Profils de Personnages** - Suivre le développement et les relations des personnages  
- **Création de Monde** - Gérer les décors, règles et traditions  
- **Fils Narratifs** - Visualiser et suivre plusieurs intrigues  

### Assurance Qualité

- **Vérifications de Cohérence** - Valider les traits des personnages, la chronologie et les faits  
- **Suivi de l’Intrigue** - S’assurer que tous les fils narratifs sont résolus  
- **Gestion de la Chronologie** - Validation de l’exactitude chronologique  
- **Cohérence de Style** - Maintenir votre voix d’écriture unique  

## 🆕 Nouveautés

### v0.13.0 (Dernière version)

- 🧠 **Système de Compétences d’Agent** - Architecture modulaire des connaissances IA  
    - 14 compétences professionnelles intégrées  
    - Système à trois niveaux : Extension, Projet et Compétences Personnelles  
    - Activation intelligente automatique basée sur le contexte de la tâche  
    - Interface complète pour parcourir, gérer et créer des compétences personnalisées  
- ✅ Outils d’assurance qualité améliorés  
- 📚 Documentation complète et guides des meilleures pratiques  

### v1.0

- ✅ Mise en œuvre complète de la méthodologie en sept étapes  
- ✅ Support multi-modèles IA (plus de 400 modèles)  
- ✅ Interface visuelle de gestion de projet  
- ✅ Suivi intégré des intrigues et personnages  
- ✅ Assistance d’écriture IA en temps réel  
- ✅ Compatibilité complète avec les commandes slash pour écrivain de roman  

## 💡 Meilleures Pratiques

1. **Commencez par la Constitution** - Définissez vos principes avant d’écrire  
2. **Utilisez Clarify à Profusion** - Résolvez les ambiguïtés tôt pour éviter les réécritures  
3. **Faites Confiance au Processus** - Suivez les sept étapes pour de meilleurs résultats
4. **Itérer** - Revenez aux étapes précédentes au fur et à mesure que votre histoire évolue  
5. **Suivre de manière cohérente** - Mettez à jour les suivis après chaque chapitre majeur  

## 🔗 Ressources Associées  

### Documentation  

- 📖 [Guide d'utilisation des Compétences Agent](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) - Apprenez à utiliser et créer des Compétences  
- 🛠️ [Guide du développeur des Compétences Agent](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-developer-guide.md) - Architecture technique et API  
- ✍️ [Bonnes pratiques pour écrire des Compétences](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/writing-skills-best-practices.md) - Créez des Compétences de haute qualité  

### Communauté & Outils  

- 📦 [Outil CLI novel-writer](https://github.com/wordflowlab/novel-writer) - Compagnon en ligne de commande  
- 📖 [Méthodologie en sept étapes](https://github.com/wordflowlab/novel-writer/blob/main/METHODOLOGY.md) - Guide méthodologique détaillé  
- 💬 [Discord Communautaire](#) - Rejoignez d’autres auteurs utilisant NovelWeave  
- 📺 [Tutoriels vidéo](#) - Regardez des guides pas à pas  

## 🤝 Contribution  

Nous accueillons les contributions ! Veuillez consulter notre [Guide de contribution](https://raw.githubusercontent.com/wordflowlab/novelweave/main/CONTRIBUTING.md) pour plus de détails.  

## 📄 Licence  

Licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.  

## 🙏 Remerciements  

- Construit sur l’architecture [NovelWeave](https://github.com/NovelWeave-Org/novelweave)  
- Méthodologie issue de [novel-writer](https://github.com/wordflowlab/novel-writer)  
- Inspiré par les principes de [Spec Kit](https://github.com/sublayerapp/spec-kit)  

---  

**NovelWeave** - Là où l’IA rencontre la maîtrise du storytelling ✨📚  

Fait avec ❤️ pour les écrivains du monde entier


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---