
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Blog de Jimmy

Un système de blog personnel minimaliste construit avec Next.js 15+, prenant en charge la création en ligne et le déploiement statique.

## Pile technique

- **Framework** : Next.js 15+ (App Router)
- **Langage** : TypeScript
- **Style** : Tailwind CSS
- **Icônes** : Lucide Icons
- **Contenu** : Markdown + Gray Matter + Remark
- **Authentification** : GitHub OAuth
- **Déploiement** : Vercel

## Fonctionnalités

### Côté lecteur

- 📝 Rendu des articles Markdown + GFM (avec affichage des formules mathématiques)
- 🏷️ Filtrage par tags, pagination, archivage (par année/tag)
- 📚 Navigation dans la table des matières (TOC) et copie en un clic des blocs de code
- 📱 Mise en page responsive et bascule entre thème clair/sombre
- 🔥 Carte de chaleur du calendrier de création en survol (articles + essais)
- 📡 Sortie d'abonnement RSS (`/rss.xml`)

### Côté création (interface d'administration)

- 🔐 Connexion via GitHub OAuth (vérification des droits propriétaire/collaborateur)
- ✍️ Création, édition et suppression d'articles/essais en ligne
- 🆔 ID de fichier personnalisé + évitement automatique des conflits
- 👀 Trois modes d'écriture : édition / aperçu / écran partagé
- 📊 Tableau de statistiques de création (total, production hebdo/mois, tags populaires)

### Côté ingénierie

- ⚡ Sortie statique multipages (`force-static`) pour améliorer performance et stabilité
- 🧭 Sitemap et robots intégrés
- 🧩 Cache de lecture de contenu et API modulaire

## Structure du projet

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## Installation et exécution

1. Cloner le projet

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```
2. Installation des dépendances


```bash
npm install
```
3.  Exécution du serveur de développement


```bash
npm run dev
```
4. Construire la version de production


```bash
npm run build
```

## Ajouter un nouvel article

### Méthode 1 : Interface d’administration en ligne (recommandé)

1. Accédez à la page `/admin`
2. Connectez-vous avec GitHub OAuth
3. Remplissez les informations de l’article et soumettez
4. L’article sera automatiquement créé via l’API GitHub, et Vercel redéploiera automatiquement

### Méthode 2 : Ajout manuel de fichier

1. Créez un nouveau fichier Markdown dans le dossier `content/posts`
2. Format de nommage du fichier : `xxx.md`
3. Ajoutez les métadonnées en en-tête du fichier :

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Ajouter une note

1. Créez un nouveau fichier Markdown dans le répertoire `content/notes`
2. Format de nommage du fichier : `YYYY-MM-DD-title.md`
3. Ajoutez les métadonnées en tête du fichier :

```markdown
---
date: YYYY-MM-DD
---
```

## Configuration du panneau d'administration

Le panneau d'administration utilise l'authentification GitHub OAuth, seul le propriétaire du dépôt ou les collaborateurs peuvent y accéder.

### 1. Créer une application GitHub OAuth

1. Accédez à [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Cliquez sur "New OAuth App"
3. Renseignez les informations :
   - **Nom de l'application** : `Jimmy Blog Admin` (ou n'importe quel nom)
   - **URL de la page d'accueil** : `https://ton-domaine.com` (en production) ou `http://localhost:3000` (en développement local)
   - **URL de rappel d'autorisation** :
     - En production : `https://ton-domaine.com/api/auth/github/callback`
     - En développement local : `http://localhost:3000/api/auth/github/callback`
4. Cliquez sur "Register application"
5. Notez le **Client ID**
6. Cliquez sur "Generate a new client secret", notez le **Client secret**

### 2. Configurer les variables d'environnement

Ajoutez les variables d'environnement suivantes dans les paramètres de votre projet Vercel :

- `GITHUB_CLIENT_ID` : l'ID client de votre application GitHub OAuth
- `GITHUB_CLIENT_SECRET` : le secret client de votre application GitHub OAuth
- `GITHUB_OWNER` : nom d'utilisateur GitHub (par défaut : `Lily-404`, utilisé pour vérifier les autorisations utilisateur)
- `GITHUB_REPO` : nom du dépôt (par défaut : `blog`)
- `GITHUB_REDIRECT_URI` : URL de rappel OAuth (optionnelle, générée automatiquement par défaut)
- `NEXT_PUBLIC_BASE_URL` : URL de votre site web (utilisée pour générer l'URL de rappel, doit être définie en production)
  - En production : `https://www.jimmy-blog.top`
  - En développement local : `http://localhost:3000`

### 3. Configuration pour le développement local

Créez un fichier `.env.local` à la racine du projet :

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Configuration de l'environnement de production (Vercel)

Dans les paramètres du projet Vercel, assurez-vous de configurer :

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Attention** : 
- Le fichier `.env.local` a été ajouté à `.gitignore` et ne sera pas soumis à Git
- En développement local, assurez-vous que l’URL de rappel de l’application OAuth est définie sur `http://localhost:3000/api/auth/github/callback`
- **En production, il faut absolument définir `NEXT_PUBLIC_BASE_URL` sur `https://www.jimmy-blog.top`**
- L’URL de rappel OAuth App en production doit être : `https://www.jimmy-blog.top/api/auth/github/callback`

## Déploiement

Le projet est déjà configuré pour le déploiement sur Vercel, avec support du déploiement automatique. Il suffit de pousser le code sur le dépôt GitHub, Vercel va automatiquement construire et déployer.

### Avantages de l’utilisation du back-office

- ✅ Pas besoin d’environnement de développement local
- ✅ Ajouter des articles à tout moment, n’importe où
- ✅ Déclenche automatiquement le redéploiement Vercel
- ✅ Entièrement gratuit (GitHub OAuth et Vercel dans la limite gratuite)
- ✅ Sécurisé (authentification GitHub OAuth, seul le propriétaire/collaborateur du dépôt peut accéder)
- ✅ Aucune gestion de mot de passe, connexion possible avec un compte GitHub
- ✅ Prise en charge de l’édition en ligne des contenus existants (pas seulement la création)
- ✅ Gestion automatique des conflits d’ID de fichier, évite les écrasements et renommages manuels
- ✅ Statistiques de création intégrées dans le back-office, facilitant l’exploitation continue du contenu

## Analyse du projet et feuille de route future

- Document d’analyse du projet : [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Document de feuille de route Future : [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## Contribution

Issues et Pull Requests sont les bienvenus !

## Licence

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---