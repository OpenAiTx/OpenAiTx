
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
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Blog de Jimmy

Un système de blog personnel minimaliste basé sur Next.js 15+.

## Pile technologique

- **Framework** : Next.js 13+ (App Router)
- **Style** : Tailwind CSS
- **Icônes** : Lucide Icons
- **Thème** : Prise en charge du mode sombre/clair
- **Déploiement** : Vercel

## Fonctionnalités

- 📝 Prise en charge des articles Markdown
- 🌓 Changement de thème sombre/clair
- 📱 Design responsive
- ⚡ Chargement rapide
- 📅 Affichage de la chronologie des articles
- 🔐 Interface d'administration en ligne (création directe d'articles via l'API GitHub)

## Structure du projet

```
.
├── app/
│   ├── lib/           # 工具函数和数据处理
│   ├── posts/         # 博客文章
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

### Méthode 1 : Interface d'administration en ligne (recommandé)

1. Accédez à la page `/admin`
2. Connectez-vous avec le mot de passe administrateur
3. Remplissez les informations de l'article et soumettez
4. L'article sera automatiquement créé via l'API GitHub et Vercel redéploiera automatiquement

### Méthode 2 : Ajout manuel de fichier

1. Créez un nouveau fichier Markdown dans le dossier `content/posts`
2. Format de nommage du fichier : xxx.md`
3. Ajoutez les métadonnées en haut du fichier :

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

⚠️ **Remarque** : 
- Le fichier `.env.local` a été ajouté à `.gitignore` et ne sera pas soumis à Git
- Lors du développement local, assurez-vous que l’URL de rappel de l’application OAuth est définie sur `http://localhost:3000/api/auth/github/callback`
- **En production, il faut impérativement définir `NEXT_PUBLIC_BASE_URL` sur `https://www.jimmy-blog.top`**
- L’URL de rappel de l’application OAuth en production doit être définie sur : `https://www.jimmy-blog.top/api/auth/github/callback`

## Déploiement

Le projet est configuré pour le déploiement sur Vercel et prend en charge le déploiement automatique. Il suffit de pousser le code sur le dépôt GitHub, Vercel se chargera de la construction et du déploiement automatiquement.

### Avantages de l’utilisation du back-office

- ✅ Pas besoin d’environnement de développement local
- ✅ Ajout d’articles à tout moment, de n’importe où
- ✅ Déclenchement automatique d’un redéploiement sur Vercel
- ✅ Entièrement gratuit (GitHub OAuth et Vercel inclus dans les quotas gratuits)
- ✅ Sécurité (authentification GitHub OAuth, seuls les propriétaires/collaborateurs du dépôt y ont accès)
- ✅ Pas besoin de gérer des mots de passe, connexion avec le compte GitHub

## Contribution

Les Issues et Pull Requests sont les bienvenus !

## Licence

Licence MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---