<a name="readme-top"></a>
<div align="center">
  
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![Netlify Status](https://api.netlify.com/api/v1/badges/3d9506ce-9212-47ae-b686-fb932a24f940/deploy-status)](https://app.netlify.com/sites/astro-theme-cody/deploys)  

<a href='https://ko-fi.com/F1F2J3RV9' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=6' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>


  <p align="center">
    <h1>Astro Theme Cody</h1>
  <p>
    Un thème de blog minimaliste construit avec Astro. Un démarrage rapide et facile pour tous ceux qui veulent lancer leur propre blog.
  </p>
    <a href="https://astro-theme-cody.netlify.app">Voir la démo</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">Signaler un bug</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">Demander une fonctionnalité</a>
  </p>
  </p>
</div>

![demo-preview](https://github.com/kirontoo/astro-theme-cody/assets/28286622/d585dcb2-6d5f-4a68-871c-b6028cfcc27f)


## Table des matières
- [Motivation](#motivation)
- [Fonctionnalités clés](#key-features)
- [Démo](#demo)
- [Démarrage rapide](#quick-start)
- [Commandes](#commands)
- [Configurer votre site web](#configuring-your-website)
  - [Configuration du site, liens des réseaux sociaux et liens de la barre de navigation](#site-config-social-media-links-and-navbar-links)
  - [Ajouter des articles et des projets](#adding-posts-and-projects)
  - [Support multilingue](#multi-language-support)
- [Déployer](#deploy)
- [Fonctionnalités supplémentaires](#extra-funtionality)
- [Crédit](#credit)

## Motivation
Bien qu'il existe déjà de nombreux thèmes de blog, je voulais un thème qui
dégage cette ambiance terminal/dev et quelques fonctionnalités que d'autres thèmes n'avaient pas.

## Principales fonctionnalités :
- Astro v4 Rapide 🚀
- Classes utilitaires TailwindCSS
- Balises HTML accessibles et sémantiques
- Responsive & optimisé SEO
- Support multilingue
- Mode sombre / clair, utilisant Tailwind et les variables CSS
- Articles et projets épinglés
- [Intégration Astro Assets](https://docs.astro.build/en/guides/assets/) pour des images optimisées
- Articles MD & [MDX](https://docs.astro.build/en/guides/markdown-content/#mdx-only-features)
- Pagination
- Recherche dans les articles avec [PageFind](https://pagefind.app/)
- [Flux RSS automatique](https://docs.astro.build/en/guides/rss)
- [Plan du site](https://docs.astro.build/en/guides/integrations-guide/sitemap/) généré automatiquement
- Composant d’icône svg [Astro Icon](https://github.com/natemoo-re/astro-icon)
- Bouton Retour en haut

## Démo
Découvrez la démo [ici](https://astro-theme-cody.netlify.app).

## Démarrage rapide
[Créez un nouveau dépôt](https://github.com/new?template_name=astro-theme-cody&template_owner=kirontoo) à partir de ce modèle.

```
# npm 7+
npm create astro@latest -- --template kirontoo/astro-theme-cody

# pnpm
pnpm dlx create-astro --template kirontoo/astro-theme-cody
```

<p align="right">(<a href="#readme-top">retour en haut</a>)</p>


## Commandes

Toutes les commandes sont lancées depuis la racine du projet, dans un terminal :

| Commande                  | Action                                           |
| :------------------------ | :----------------------------------------------- |
| `pnpm install`             | Installe les dépendances                         |
| `pnpm run dev`             | Démarre le serveur de développement local sur `localhost:4321` |
| `pnpm run build`           | Compile votre site de production dans `./dist/` |
| `pnpm run preview`         | Prévisualise votre build localement, avant déploiement |
| `pnpm run astro ...`       | Exécute des commandes CLI comme `astro add`, `astro check` |
| `pnpm run astro -- --help` | Obtenir de l'aide sur l'utilisation de l'interface CLI Astro |

<p align="right">(<a href="#readme-top">retour en haut</a>)</p>

## Configuration de votre site web

### Configuration du site, liens des réseaux sociaux et liens de la barre de navigation
La configuration de votre site, les liens des réseaux sociaux et les liens de la barre de navigation se trouvent tous dans [`src/consts.ts`](https://github.com/kirontoo/astro-theme-cody/blob/main/src/consts.ts).
Vous pouvez y configurer le titre par défaut de votre site, la description, la langue, le profil, les liens des réseaux sociaux et les liens visibles dans la barre de navigation.

### Ajout d’articles et de projets
Ce thème utilise les [Collections de contenu](https://docs.astro.build/en/guides/content-collections/) 
pour organiser les fichiers Markdown et/ou MDX, ainsi que pour vérifier le typage des frontmatter 
avec un schéma -> `src/content/config.ts`.

Vous trouverez des exemples d’articles de blog dans `src/content/blog` et des exemples de projets dans `src/content/project`.

#### Frontmatter des articles de blog
| Propriété (* = obligatoire) | Description |
|:---------------------------| :---------- |
| title * | Titre de votre article. Limité à un maximum de 150 caractères  |
| description * | Brève description de votre article, utilisée aussi pour le SEO. Longueur maximale de 250 caractères. |
| pubDate * | Date de publication |
| updateDate | Date optionnelle indiquant quand l’article a été mis à jour. Notez que cette date sera utilisée à la place de la date de publication pour ordonner les articles si disponible.|
| heroImage | Image de couverture optionnelle pour votre article. Inclure à la fois une propriété `src` et une propriété `alt`. Voir `src/content/blog/first-post.md` pour un exemple.|
| ogImage | Image optionnelle utilisée pour le SEO. |
| tags | Utilisez des tags optionnels pour organiser vos articles en catégories ou sujets. Tous les tags seront affichés dans `votredomaine.com/tags`. |
| series | Utilisez des séries optionnelles pour organiser vos articles en une série de posts. Toutes les séries seront affichées dans `votredomaine.com/series`. |
| draft | Booléen optionnel. Empêche la publication des articles. |
| order | Valeur numérique optionnelle de 1 à 5 pour épingler certains articles en haut. Limité à seulement 5 articles épinglés. |
| hide  | Booléen optionnel. Cache un article sur la page `/blog`. Il apparaîtra toujours dans `/archive`. |

#### Frontmatter du projet

| Propriété (* = obligatoire) | Description |
|:---------------------------| :----------|
| title * | Titre de votre projet. Limité à un maximum de 150 caractères |
| description * | Brève description de votre projet, également utilisée pour le SEO. |
| pubDate * | Date de publication |
| heroImage | Image de couverture optionnelle pour votre projet. Inclure une propriété `src` et une propriété `alt`. Voir `src/pages/projects/project-1.md` pour un exemple. |
| ogImage | Image optionnelle utilisée pour le SEO. |
| stack * | Liste des technologies utilisées dans votre projet, affichée sous forme d'icônes. Ce thème utilise la bibliothèque SVG Logos, vous pouvez utiliser [icones.js.org](https://icones.js.org/collection/vscode-icons) pour trouver les icônes dont vous avez besoin. |
| platform | Lien vers le site web ou la démo |
| website | Lien vers le site web ou la démo |
| github | Lien vers votre dépôt GitHub |
| draft | Booléen optionnel. Empêche la publication des projets. |
| order | Valeur numérique optionnelle de 1 à 5 pour épingler certains projets en haut. Limité à seulement 5 projets épinglés. |

<p align="right">(<a href="#readme-top">retour en haut</a>)</p>

### Support multilingue  
Consultez le [wiki](https://github.com/kirontoo/astro-theme-cody/wiki/Set-up-multi%E2%80%90language-support) pour configurer le support multilingue pour votre blog.

## Déploiement  
Astro fournit une excellente documentation pour déployer vos sites Astro sur diverses plateformes.  
Vous pouvez la trouver [ici](https://docs.astro.build/en/guides/deploy/).

## Fonctionnalités supplémentaires  
Découvrez [Astro Recipes](https://docs.astro.build/en/recipes/) pour ajouter d’autres fonctionnalités comme un flux RSS.

## Crédits  

Ce thème est basé sur les thèmes [Astro Cactus](https://astro-theme-cactus.netlify.app) et [Hugo Risotto](https://risotto.joeroe.io).


<p align="right">(<a href="#readme-top">retour en haut</a>)</p>

[contributors-shield]: https://img.shields.io/github/contributors/kirontoo/astro-theme-cody.svg?style=for-the-badge
[contributors-url]: https://github.com/kirontoo/astro-theme-cody/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/kirontoo/astro-theme-cody.svg?style=for-the-badge
[forks-url]: https://github.com/kirontoo/astro-theme-cody/network/members
[stars-shield]: https://img.shields.io/github/stars/kirontoo/astro-theme-cody.svg?style=for-the-badge
[stars-url]: https://github.com/kirontoo/astro-theme-cody/stargazers
[issues-shield]: https://img.shields.io/github/issues/kirontoo/astro-theme-cody.svg?style=for-the-badge
[issues-url]: https://github.com/kirontoo/astro-theme-cody/issues
[license-shield]: https://img.shields.io/github/license/kirontoo/astro-theme-cody.svg?style=for-the-badge
[license-url]: https://github.com/kirontoo/astro-theme-cody/blob/master/LICENSE.txt


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---