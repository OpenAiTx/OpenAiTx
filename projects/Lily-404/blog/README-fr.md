# Blog de Jimmy

Un système de blog personnel minimaliste construit avec Next.js 15+.

## Technologies

- **Framework** : Next.js 13+ (App Router)
- **Styles** : Tailwind CSS
- **Icônes** : Lucide Icons
- **Thème** : Support du mode sombre/clair
- **Déploiement** : Vercel

## Fonctionnalités

- 📝 Support des articles Markdown
- 🌓 Changement de thème sombre/clair
- 📱 Design responsive
- ⚡ Chargement rapide
- 📅 Affichage de la timeline des articles

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

1. Créez un nouveau fichier Markdown dans le répertoire `content/posts`
2. Format de nommage du fichier : xxx.md`
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

## 部署

项目已配置 Vercel 部署，支持自动部署。只需将代码推送到 GitHub 仓库，Vercel 会自动构建和部署。

## 贡献

欢迎提交 Issue 和 Pull Request！

## 许可证

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---