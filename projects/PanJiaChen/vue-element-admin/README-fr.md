<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

Anglais | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Espagnol](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## Introduction

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) est une solution front-end prête pour la production pour les interfaces d'administration. Elle est basée sur [vue](https://github.com/vuejs/vue) et utilise la boîte à outils UI [element-ui](https://github.com/ElemeFE/element).

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) est basée sur la pile de développement la plus récente de vue, elle intègre une solution i18n, des modèles typiques pour les applications d'entreprise, et de nombreuses fonctionnalités avancées. Elle vous aide à construire de grandes applications monopages complexes. Je suis convaincu que ce projet répondra à vos besoins quels qu'ils soient.

- [Aperçu](https://panjiachen.github.io/vue-element-admin)

- [Documentation](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [Faire un don](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) Les utilisateurs en Chine peuvent accéder à cette adresse pour un aperçu en ligne

- Le modèle de base recommandé : [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- Desktop : [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript : [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (Crédits : [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**À partir de la version `v4.1.0+`, la branche master par défaut ne prend plus en charge i18n. Veuillez utiliser la [branche i18n](https://github.com/PanJiaChen/vue-element-admin/tree/i18n), qui suivra les mises à jour de master**

**La version actuelle est `v4.0+` basée sur `vue-cli`. Si vous rencontrez un problème, veuillez soumettre un [ticket](https://github.com/PanJiaChen/vue-element-admin/issues/new). Si vous souhaitez utiliser l'ancienne version, vous pouvez basculer sur la branche [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0), elle ne dépend pas de `vue-cli`**

**Ce projet ne prend pas en charge les navigateurs obsolètes (ex: IE). Veuillez ajouter vous-même les polyfills nécessaires.**

## Préparation

Vous devez installer [node](https://nodejs.org/) et [git](https://git-scm.com/) localement. Le projet est basé sur [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios) et [element-ui](https://github.com/ElemeFE/element). Toutes les données de requête sont simulées avec [Mock.js](https://github.com/nuysoft/Mock).
Comprendre et apprendre ces notions à l'avance facilitera grandement l'utilisation de ce projet.

[![Edit on CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## Sponsors

Devenez sponsor et affichez votre logo dans notre README sur GitHub avec un lien vers votre site. [[Devenir sponsor]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Obtenez le backend Java pour l'admin Vue avec 20% de réduction pour 39$ en utilisant le code promo SWB0RAZPZR1M
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Modèles de tableaux de bord d'administration réalisés avec Vue, React et Angular.</p>

## Fonctionnalités

```
- Connexion / Déconnexion

- Authentification par permissions
  - Permission de page
  - Permission par directive
  - Page de configuration des permissions
  - Connexion en deux étapes

- Construction multi-environnements
  - Développement (dev)
  - sit
  - Test de préproduction (stage)
  - Production (prod)

- Fonctionnalités globales
  - I18n
  - Multiples thèmes dynamiques
  - Barre latérale dynamique (prise en charge du routage multi-niveaux)
  - Fil d’Ariane dynamique
  - Vue par tags (support du clic droit sur les onglets)
  - Sprite SVG
  - Données mock
  - Plein écran
  - Barre latérale responsive

- Éditeur
  - Éditeur de texte enrichi
  - Éditeur Markdown
  - Éditeur JSON

- Excel
  - Exporter Excel
  - Importer Excel
  - Visualisation Excel
  - Export zip

- Tableau
  - Tableau dynamique
  - Tableau glisser-déposer
  - Édition en ligne

- Page d'erreur
  - 401
  - 404

- Composants
  - Téléchargement d'avatar
  - Retour en haut
  - Dialogue glissant
  - Sélection glissante
  - Kanban glissant
  - Liste glissante
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- Exemple avancé
- Journal des erreurs
- Tableau de bord
- Page de guide
- ECharts
- Presse-papiers
- Markdown vers html
```

## Démarrage

```bash
# cloner le projet
git clone https://github.com/PanJiaChen/vue-element-admin.git

# entrer dans le répertoire du projet
cd vue-element-admin

# installer les dépendances
npm install

# développement
npm run dev
```

Ceci ouvrira automatiquement http://localhost:9527

## Compilation

```bash
# compilation pour l'environnement de test
npm run build:stage

# compilation pour l'environnement de production
npm run build:prod
```

## Avancé

```bash
# prévisualiser le rendu en environnement de production
npm run preview

# prévisualiser le rendu production + analyse des ressources statiques
npm run preview -- --report

# vérification du format du code
npm run lint

# vérification et correction automatique du format du code
npm run lint -- --fix
```

Référez-vous à la [documentation](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html) pour plus d'informations

## Journal des modifications

Les modifications détaillées de chaque version sont documentées dans les [notes de version](https://github.com/PanJiaChen/vue-element-admin/releases).

## Démo en ligne

[Aperçu](https://panjiachen.github.io/vue-element-admin)

## Faire un don

Si vous trouvez ce projet utile, vous pouvez offrir à l'auteur un verre de jus :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Offrez-moi un café](https://www.buymeacoffee.com/Pan)

## Prise en charge des navigateurs

Navigateurs modernes et Internet Explorer 10+.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | 2 dernières versions | 2 dernières versions | 2 dernières versions |

## Licence

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Copyright (c) 2017-present PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---