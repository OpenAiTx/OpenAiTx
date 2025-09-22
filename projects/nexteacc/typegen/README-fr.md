# TypeGen - Outil intelligent de conversion de style de texte

TypeGen est une application moderne de conversion de style de texte propulsée par l’IA, basée sur Next.js. En intégrant l’API OpenAI, elle offre une conversion intelligente entre styles d’écriture, modèles de structure et paramètres stratégiques multidimensionnels, avec une interface interactive intuitive par glisser-déposer.

## 🎯 Fonctionnalités principales

### Conversion intelligente de texte
- **Propulsé par l’IA** : Intégration de OpenAI GPT-4o-mini pour une conversion authentique de style de texte
- **28 filtres de style** : Couvre les trois dimensions : style d’écriture, structure et stratégie de diffusion
- **Contrôle intelligent du nombre de mots** : Supporte la définition de la longueur cible, du résumé concis au développement détaillé
- **Conversion en temps réel** : Traitement API à réponse rapide pour une expérience utilisateur fluide

### Conception interactive intuitive
- **Opération par glisser-déposer** : Glissez les filtres de style dans la zone de texte pour lancer la conversion
- **Retour visuel** : Effets d’animation riches et indicateurs d’état
- **Affichage comparatif** : Disposition en double colonne avant et après conversion
- **Actions en un clic** : Copier le résultat, essayer d’autres styles, recommencer

## 🛠️ Architecture technique

### Stack frontend
- **Framework** : [Next.js](https://nextjs.org/) 15.5.0 (développé avec Turbopack)
- **Bibliothèque UI** : [React](https://reactjs.org/) 19.0.0
- **Système de styles** : [Tailwind CSS](https://tailwindcss.com/) 4.1.11
- **Bibliothèque d’animation** : [Framer Motion](https://www.framer.com/motion/) 12.23.6
- **Sécurité typée** : [TypeScript](https://www.typescriptlang.org/) 5
- **Gestionnaire de paquets** : [pnpm](https://pnpm.io/)

### Composants clés
- **Système de glisser-déposer** : Interaction professionnelle basée sur @dnd-kit/core
- **Gestion des styles** : Traitement dynamique des styles avec clsx et tailwind-merge
- **Composants UI** : Bibliothèque de composants personnalisés basée sur Radix UI

## 📂 Structure du projet

```
├── app/                           # Next.js App Router
│   ├── api/transform/route.ts     # 文本转换 API 端点
│   ├── page.tsx                   # 主应用界面
│   ├── layout.tsx                 # 根布局组件
│   └── globals.css                # 全局样式
├── components/                    # UI 组件库
│   ├── style-filter/              # 风格滤镜系统
│   │   ├── types.ts              # 类型定义
│   │   ├── filters-data.ts       # 风格数据配置
│   │   ├── filter-container.tsx  # 滤镜容器组件
│   │   └── ...                   # 动画和交互组件
│   ├── ui/                       # 基础 UI 组件
│   ├── length-control.tsx        # 字数控制滑动条
│   └── text-stats.tsx           # 文本统计显示
├── lib/                          # 业务逻辑层
│   ├── api-client.ts            # API 客户端封装
│   ├── transform-service.ts     # 转换服务核心
│   ├── openai-service.ts        # OpenAI API 集成
│   └── api-types.ts             # API 类型定义
├── public/icons/                # 风格图标资源
└── utils/                       # 工具函数
```

## 🎨 Aperçu des filtres de style

### Style d'écriture (Style)

**Journalistique / Académique / Manuel**
- Style AP
- Style APA
- Style IEEE
- Style Manuel
- Enquête

**Communautés / Culture de plateforme**
- Style 4chan
- Style Reddit
- BuzzFeed
- Style Twitter
- Légende Instagram
- Style Meme

**Fiction / Écriture créative**
- Style Hemingway

### Modèles de structure (Structure)

**Structure journal / actualités**
- Pyramide inversée
- Axé sur le titre

**Listes / fils / tutoriels**
- Listicle
- Enfilé
- Tutoriel
- À puces

**Structure académique / narrative**
- IMRaD

### Stratégies et paramètres (Strategy & Controls)
- Clickbait
- Appel à l'action  
- Optimisé pour le SEO  
- Basé sur la peur de manquer quelque chose (FOMO)  
- Utilisation intensive de hashtags  
- Chargé d'émojis  
- Indice de lisibilité Flesch-Kincaid  
- Riche en citations  
- Jargon technique  

## ⚙️ Guide de configuration  

### Configuration de l'environnement  
1. **Obtenir la clé API OpenAI**
   ```bash
   # 访问 https://platform.openai.com/account/api-keys
   # 创建新的 API 密钥
   ```
2. **Configurer les variables d'environnement**

   ```bash
   cp .env.example .env.local
   ```

   Éditez le fichier `.env.local` :
   ```bash
   OPENAI_API_KEY=sk-proj-your_api_key_here
   OPENAI_MODEL=gpt-4o-mini                    # 可选，默认值
   OPENAI_MAX_TOKENS=2000                      # 可选，默认值
   OPENAI_TEMPERATURE=0.7                      # 可选，默认值
   API_TIMEOUT=30000                           # 可选，30秒超时
   API_MAX_RETRIES=3                           # 可选，最大重试次数
   ```
### Développement local

```bash
# 安装依赖
pnpm install

# 启动开发服务器
pnpm dev

# 构建生产版本
pnpm build

# 代码检查
pnpm lint
```

## 🔧 Implémentation principale

### Gestion d'état
L'application utilise un modèle complet de machine à états pour gérer le processus de transformation :
- `idle` : état initial, en attente de saisie de texte
- `readyToTransform` : texte prêt, prêt pour la transformation
- `transforming` : transformation en cours, affichage de l'état de chargement
- `transformed` : transformation terminée, affichage de la comparaison des résultats

### Intégration API
- **Sécurité de type** : définitions complètes des types TypeScript
- **Gestion des erreurs** : gestion des erreurs en couches et messages d'erreur conviviaux
- **Optimisation des performances** : mise en cache des réponses API et déduplication des requêtes
- **Mécanisme de réessai** : réessai automatique en cas d'échec réseau

### Expérience utilisateur (bureau)
- **Opération de glisser-déposer** : animations fluides et retours visuels lors du glisser-déposer
- **Contrôle du nombre de mots** : comptage de mots en temps réel et paramétrage de la longueur cible
- **Actions sur le résultat** : copie en un clic, réessai et recommencement
- **Note sur la plateforme** : la version actuelle est uniquement destinée à une utilisation sur bureau, sans interaction sur mobile

## 🚀 Directions d'extension

- **Support multilingue** : ajout de la prise en charge de l'internationalisation
- **Traitement par lots** : prise en charge de la transformation de plusieurs textes simultanément
- **Styles personnalisés** : permettre aux utilisateurs de créer des styles personnalisés
- **Fonctionnalités collaboratives** : partage en équipe et fonction de commentaires
- **Analyse de données** : utilisation des statistiques et analyse d'efficacité


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---