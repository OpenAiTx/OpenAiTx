## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!ATTENTION]
>
> ## Obsolète
>
> Create React App a été l’un des outils clés pour démarrer un projet React rapidement entre 2017 et 2021. Il est désormais en phase de maintenance à long terme et nous recommandons de migrer vers l’un des frameworks React documentés sur [Démarrer un nouveau projet React](https://react.dev/learn/start-a-new-react-project).
>
> Si vous suivez un tutoriel pour apprendre React, il reste pertinent de continuer, mais nous ne recommandons pas de démarrer des applications en production basées sur Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Créez des applications React sans configuration de build.

- [Créer une application](#creating-an-app) – Comment créer une nouvelle application.
- [Guide utilisateur](https://facebook.github.io/create-react-app/) – Comment développer des applications initialisées avec Create React App.

Create React App fonctionne sur macOS, Windows et Linux.<br>
Si quelque chose ne fonctionne pas, veuillez [ouvrir un ticket](https://github.com/facebook/create-react-app/issues/new).<br>
Si vous avez des questions ou besoin d'aide, veuillez demander dans [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Aperçu rapide

```sh
npx create-react-app my-app
cd my-app
npm start
```

Si vous avez précédemment installé `create-react-app` globalement via `npm install -g create-react-app`, nous vous recommandons de désinstaller le paquet avec `npm uninstall -g create-react-app` ou `yarn global remove create-react-app` pour vous assurer que npx utilise toujours la dernière version.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) est fourni avec npm 5.2+ et supérieur, voir [instructions pour les anciennes versions de npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Ensuite, ouvrez [http://localhost:3000/](http://localhost:3000/) pour voir votre application.<br>
Lorsque vous êtes prêt à déployer en production, créez un bundle minifié avec `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Démarrez immédiatement

Vous **n'avez pas** besoin d’installer ou de configurer des outils comme webpack ou Babel.<br>
Ils sont préconfigurés et masqués afin que vous puissiez vous concentrer sur le code.

Créez un projet, et vous êtes prêt.

## Créer une application

**Vous devez avoir Node 14.0.0 ou une version ultérieure sur votre machine de développement locale** (ce n’est pas requis sur le serveur). Nous recommandons d’utiliser la dernière version LTS. Vous pouvez utiliser [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) ou [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) pour changer de version de Node entre différents projets.

Pour créer une nouvelle application, vous pouvez choisir l’une des méthodes suivantes :

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) est un outil d’exécution de paquets fourni avec npm 5.2+ et supérieur, voir [instructions pour les anciennes versions de npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` est disponible à partir de npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) est disponible à partir de Yarn 0.25+_

Cela créera un dossier appelé `my-app` dans le dossier courant.<br>
Dans ce dossier, il générera la structure initiale du projet et installera les dépendances transitives :

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

Aucune configuration ou structure de dossiers complexe, uniquement les fichiers nécessaires pour construire votre application.<br>
Une fois l’installation terminée, vous pouvez ouvrir le dossier de votre projet :

```sh
cd my-app
```

Dans le projet nouvellement créé, vous pouvez exécuter certaines commandes intégrées :

### `npm start` ou `yarn start`

Lance l’application en mode développement.<br>
Ouvrez [http://localhost:3000](http://localhost:3000) pour la voir dans le navigateur.

La page se rechargera automatiquement si vous modifiez le code.<br>
Vous verrez les erreurs de build et les avertissements de lint dans la console.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` ou `yarn test`

Lance le watcher de tests en mode interactif.<br>
Par défaut, exécute les tests liés aux fichiers modifiés depuis le dernier commit.

[En savoir plus sur les tests.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` ou `yarn build`

Construit l’application pour la production dans le dossier `build`.<br>
Il bundle correctement React en mode production et optimise le build pour de meilleures performances.

Le build est minifié et les noms de fichiers incluent les hash.<br>

Votre application est prête à être déployée.

## Guide utilisateur

Vous trouverez des instructions détaillées sur l’utilisation de Create React App et de nombreux conseils dans [sa documentation](https://facebook.github.io/create-react-app/).

## Comment mettre à jour vers de nouvelles versions ?

Veuillez vous référer au [Guide utilisateur](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) pour cette information et d'autres.

## Philosophie

- **Une seule dépendance :** Il n’y a qu’une seule dépendance de build. Elle utilise webpack, Babel, ESLint, et d’autres projets remarquables, mais propose une expérience intégrée et cohérente par-dessus eux.

- **Aucune configuration requise :** Vous n’avez rien à configurer. Une configuration raisonnablement bonne pour le développement et la production est gérée pour vous afin que vous puissiez vous concentrer sur le code.

- **Pas d’enfermement :** Vous pouvez “éjecter” vers une configuration personnalisée à tout moment. Lancez une seule commande, et toutes les configurations et dépendances de build seront déplacées directement dans votre projet, pour reprendre là où vous vous étiez arrêté.

## Qu’est-ce qui est inclus ?

Votre environnement aura tout ce dont vous avez besoin pour construire une application React moderne à page unique :

- Prise en charge de React, JSX, ES6, TypeScript et Flow.
- Extensions du langage au-delà de ES6 comme l’opérateur de propagation d’objet.
- CSS autopréfixé, vous n’avez donc pas besoin de `-webkit-` ou d’autres préfixes.
- Un runner de tests unitaires rapide et interactif avec prise en charge intégrée du rapport de couverture.
- Un serveur de développement en direct qui signale les erreurs courantes.
- Un script de build pour packager JS, CSS et images pour la production, avec hash et sourcemaps.
- Un [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) orienté "offline-first" et un [manifest web app](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), répondant à tous les critères [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_Remarque : l’utilisation du service worker est optionnelle à partir de `react-scripts@2.0.0` et supérieur_)
- Mises à jour sans tracas pour les outils ci-dessus avec une seule dépendance.

Consultez [ce guide](https://github.com/nitishdayal/cra_closer_look) pour avoir un aperçu de l’intégration de ces outils.

Le compromis est que **ces outils sont préconfigurés pour fonctionner d’une manière spécifique**. Si votre projet nécessite plus de personnalisation, vous pouvez ["éjecter"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) et le personnaliser, mais vous devrez alors maintenir cette configuration.

## Alternatives populaires

Create React App est idéal pour :

- **Apprendre React** dans un environnement de développement confortable et riche en fonctionnalités.
- **Démarrer de nouvelles applications React à page unique.**
- **Créer des exemples** avec React pour vos bibliothèques et composants.

Voici quelques cas courants où vous pourriez vouloir essayer autre chose :

- Si vous souhaitez **essayer React** sans des centaines de dépendances de build transitives, envisagez [d’utiliser un fichier HTML unique ou un bac à sable en ligne](https://reactjs.org/docs/getting-started.html#try-react).

- Si vous devez **intégrer du code React dans un framework de templates côté serveur** comme Rails, Django ou Symfony, ou si vous ne construisez **pas une application à page unique**, envisagez d’utiliser [nwb](https://github.com/insin/nwb), ou [Neutrino](https://neutrino.js.org/) qui sont plus flexibles. Pour Rails, vous pouvez utiliser [Rails Webpacker](https://github.com/rails/webpacker). Pour Symfony, essayez [webpack Encore de Symfony](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Si vous devez **publier un composant React**, [nwb](https://github.com/insin/nwb) peut [le faire aussi](https://github.com/insin/nwb#react-components-and-libraries), ainsi que le [preset react-components de Neutrino](https://neutrino.js.org/packages/react-components/).

- Si vous voulez faire du **rendu côté serveur** avec React et Node.js, consultez [Next.js](https://nextjs.org/) ou [Razzle](https://github.com/jaredpalmer/razzle). Create React App est agnostique du backend et ne produit que des bundles HTML/JS/CSS statiques.

- Si votre site est **principalement statique** (par exemple, un portfolio ou un blog), envisagez d’utiliser [Gatsby](https://www.gatsbyjs.org/) ou [Next.js](https://nextjs.org/). Contrairement à Create React App, Gatsby pré-génère le site en HTML lors du build. Next.js prend en charge le rendu côté serveur et la pré-génération.

- Enfin, si vous avez besoin de **plus de personnalisation**, consultez [Neutrino](https://neutrino.js.org/) et son [preset React](https://neutrino.js.org/packages/react/).

Tous les outils ci-dessus fonctionnent avec peu ou pas de configuration.

Si vous préférez configurer le build vous-même, [suivez ce guide](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Vous cherchez quelque chose de similaire, mais pour React Native ?<br>
Consultez [Expo CLI](https://github.com/expo/expo-cli).

## Contribuer

Nous serions ravis d’avoir votre aide sur `create-react-app` ! Voir [CONTRIBUTING.md](CONTRIBUTING.md) pour plus d’informations sur ce que nous recherchons et comment commencer.

## Soutenir Create React App

Create React App est un projet maintenu par la communauté et tous les contributeurs sont bénévoles. Si vous souhaitez soutenir le développement futur de Create React App, envisagez de faire un don à notre [Open Collective](https://opencollective.com/create-react-app).

## Remerciements

Ce projet existe grâce à toutes les personnes qui [contribuent](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Merci à [Netlify](https://www.netlify.com/) pour l’hébergement de notre documentation.

## Acknowledgements

Nous sommes reconnaissants aux auteurs des projets connexes existants pour leurs idées et leur collaboration :

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Licence

Create React App est un logiciel open source [sous licence MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). Le logo Create React App est sous licence [Creative Commons Attribution 4.0 International](https://creativecommons.org/licenses/by/4.0/).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---