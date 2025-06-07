<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Logo Bootstrap" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Framework front-end élégant, intuitif et puissant pour un développement web plus rapide et plus facile.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Découvrez la documentation Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Signaler un bug</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Demander une fonctionnalité</a>
  ·
  <a href="https://themes.getbootstrap.com/">Thèmes</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Notre branche par défaut est dédiée au développement de la version Bootstrap 5. Rendez-vous sur la [branche `v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev) pour consulter le readme, la documentation et le code source de Bootstrap 4.


## Table des matières

- [Démarrage rapide](#démarrage-rapide)
- [Statut](#statut)
- [Ce qui est inclus](#ce-qui-est-inclus)
- [Bugs et demandes de fonctionnalités](#bugs-et-demandes-de-fonctionnalités)
- [Documentation](#documentation)
- [Contribuer](#contribuer)
- [Communauté](#communauté)
- [Gestion des versions](#gestion-des-versions)
- [Créateurs](#créateurs)
- [Remerciements](#remerciements)
- [Droits d’auteur et licence](#droits-dauteur-et-licence)


## Démarrage rapide

Plusieurs options de démarrage rapide sont disponibles :

- [Téléchargez la dernière version](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Clonez le dépôt : `git clone https://github.com/twbs/bootstrap.git`
- Installez avec [npm](https://www.npmjs.com/) : `npm install bootstrap@v5.3.6`
- Installez avec [yarn](https://yarnpkg.com/) : `yarn add bootstrap@v5.3.6`
- Installez avec [Bun](https://bun.sh/) : `bun add bootstrap@v5.3.6`
- Installez avec [Composer](https://getcomposer.org/) : `composer require twbs/bootstrap:5.3.6`
- Installez avec [NuGet](https://www.nuget.org/) : CSS : `Install-Package bootstrap` Sass : `Install-Package bootstrap.sass`

Lisez la [page de démarrage](https://getbootstrap.com/docs/5.3/getting-started/introduction/) pour plus d’informations sur le contenu du framework, les modèles, les exemples, et plus encore.


## Statut

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#soutiens)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## Ce qui est inclus

Dans le téléchargement, vous trouverez les répertoires et fichiers suivants, regroupant logiquement les ressources communes et fournissant à la fois des variantes compilées et minifiées.

<details>
  <summary>Contenu du téléchargement</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

Nous fournissons le CSS et le JS compilés (`bootstrap.*`), ainsi que les fichiers CSS et JS compilés et minifiés (`bootstrap.min.*`). Les [source maps](https://web.dev/articles/source-maps) (`bootstrap.*.map`) sont disponibles pour une utilisation avec certains outils de développement de navigateurs. Les fichiers JS groupés (`bootstrap.bundle.js` et `bootstrap.bundle.min.js` minifié) incluent [Popper](https://popper.js.org/docs/v2/).


## Bugs et demandes de fonctionnalités

Vous avez trouvé un bug ou souhaitez proposer une fonctionnalité ? Veuillez d'abord lire les [directives relatives aux issues](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) et recherchez les issues existantes et fermées. Si votre problème ou idée n’est pas encore traité, [veuillez ouvrir une nouvelle issue](https://github.com/twbs/bootstrap/issues/new/choose).


## Documentation

La documentation de Bootstrap, incluse dans ce dépôt à la racine, est construite avec [Astro](https://astro.build/) et hébergée publiquement sur GitHub Pages à l’adresse <https://getbootstrap.com/>. La documentation peut également être exécutée en local.

La recherche dans la documentation est propulsée par [DocSearch d’Algolia](https://docsearch.algolia.com/).

### Exécuter la documentation en local

1. Exécutez `npm install` pour installer les dépendances Node.js, y compris Astro (le générateur du site).
2. Exécutez `npm run test` (ou un script npm spécifique) pour reconstruire les fichiers CSS et JavaScript distribués, ainsi que nos ressources de documentation.
3. Depuis le répertoire racine `/bootstrap`, lancez `npm run docs-serve` dans la ligne de commande.
4. Ouvrez `http://localhost:9001/` dans votre navigateur, et voilà.

En savoir plus sur l’utilisation d’Astro en lisant sa [documentation](https://docs.astro.build/en/getting-started/).

### Documentation des versions précédentes

Vous pouvez trouver la documentation de toutes nos versions précédentes sur <https://getbootstrap.com/docs/versions/>.

[Les versions précédentes](https://github.com/twbs/bootstrap/releases) et leur documentation sont également disponibles en téléchargement.


## Contribuer

Veuillez lire nos [directives de contribution](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md). Vous y trouverez des instructions pour ouvrir des issues, des standards de codage et des notes sur le développement.

De plus, si votre pull request contient des correctifs ou des fonctionnalités JavaScript, vous devez inclure des [tests unitaires pertinents](https://github.com/twbs/bootstrap/tree/main/js/tests). Tout le HTML et le CSS doivent être conformes au [Code Guide](https://github.com/mdo/code-guide), maintenu par [Mark Otto](https://github.com/mdo).

Les préférences d’éditeur sont disponibles dans le fichier [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) pour une utilisation facile dans les éditeurs de texte courants. En savoir plus et télécharger les plugins sur <https://editorconfig.org/>.


## Communauté

Tenez-vous informé du développement de Bootstrap et discutez avec les mainteneurs et les membres de la communauté.

- Suivez [@getbootstrap sur X](https://x.com/getbootstrap).
- Lisez et abonnez-vous au [Blog Officiel Bootstrap](https://blog.getbootstrap.com/).
- Posez vos questions et explorez [nos discussions GitHub](https://github.com/twbs/bootstrap/discussions).
- Discutez, posez des questions, et plus encore sur [le Discord communautaire](https://discord.gg/bZUvakRU3M) ou [le subreddit Bootstrap](https://www.reddit.com/r/bootstrap/).
- Discutez avec d’autres utilisateurs de Bootstrap sur IRC. Sur le serveur `irc.libera.chat`, dans le canal `#bootstrap`.
- De l’aide pour l’implémentation peut être trouvée sur Stack Overflow (tag [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Les développeurs devraient utiliser le mot-clé `bootstrap` pour les paquets qui modifient ou ajoutent des fonctionnalités à Bootstrap lors de la distribution via [npm](https://www.npmjs.com/browse/keyword/bootstrap) ou des mécanismes similaires afin d’optimiser la découvrabilité.


## Gestion des versions

Pour assurer la transparence de notre cycle de publication et dans le souci de maintenir la rétrocompatibilité, Bootstrap est maintenu selon [les principes du versionnage sémantique](https://semver.org/). Il peut arriver que nous fassions des erreurs, mais nous respectons ces règles autant que possible.

Consultez [la section Releases de notre projet GitHub](https://github.com/twbs/bootstrap/releases) pour les journaux de modifications de chaque version de Bootstrap. Les annonces de nouvelles versions sur [le blog officiel Bootstrap](https://blog.getbootstrap.com/) contiennent des résumés des changements les plus notables de chaque version.


## Créateurs

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Remerciements

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Merci à [BrowserStack](https://www.browserstack.com/) pour la mise à disposition de l’infrastructure permettant de tester dans de vrais navigateurs !

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Merci à [Netlify](https://www.netlify.com/) de nous fournir les Deploy Previews !


## Sponsors

Soutenez ce projet en devenant sponsor. Votre logo apparaîtra ici avec un lien vers votre site web. [[Devenir sponsor](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## Soutiens

Merci à tous nos soutiens ! 🙏 [[Devenir soutien](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Droits d’auteur et licence

Code et documentation copyright 2011-2025 les [Auteurs de Bootstrap](https://github.com/twbs/bootstrap/graphs/contributors). Code publié sous [licence MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). Documentation publiée sous [Creative Commons](https://creativecommons.org/licenses/by/3.0/).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---