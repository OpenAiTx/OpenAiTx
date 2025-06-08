# [React](https://react.dev/) &middot; [![Licence GitHub](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![Version npm](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Exécution) Build et Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compilateur) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Bienvenus](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React est une bibliothèque JavaScript pour construire des interfaces utilisateur.

* **Déclaratif :** React rend la création d'interfaces utilisateur interactives simple et efficace. Concevez des vues simples pour chaque état de votre application, et React mettra à jour et rendra efficacement les bons composants lorsque vos données changent. Les vues déclaratives rendent votre code plus prévisible, plus facile à comprendre et à déboguer.
* **Basé sur les composants :** Construisez des composants encapsulés qui gèrent leur propre état, puis composez-les pour créer des interfaces utilisateur complexes. Comme la logique des composants est écrite en JavaScript plutôt qu'en templates, vous pouvez facilement transmettre des données riches à travers votre application et garder l’état hors du DOM.
* **Apprenez une fois, écrivez partout :** Nous ne faisons aucune supposition sur le reste de votre stack technologique, vous pouvez donc développer de nouvelles fonctionnalités dans React sans réécrire le code existant. React peut aussi être rendu côté serveur avec [Node](https://nodejs.org/en) et alimenter des applications mobiles grâce à [React Native](https://reactnative.dev/).

[Apprenez à utiliser React dans votre projet](https://react.dev/learn).

## Installation

React a été conçu pour une adoption progressive dès le départ, et **vous pouvez utiliser aussi peu ou autant de React que nécessaire** :

* Utilisez le [Démarrage Rapide](https://react.dev/learn) pour découvrir React.
* [Ajoutez React à un projet existant](https://react.dev/learn/add-react-to-an-existing-project) pour utiliser aussi peu ou autant de React que vous le souhaitez.
* [Créez une nouvelle application React](https://react.dev/learn/start-a-new-react-project) si vous recherchez une chaîne d’outils JavaScript puissante.

## Documentation

Vous pouvez trouver la documentation de React [sur le site web](https://react.dev/).

Consultez la page [Pour bien commencer](https://react.dev/learn) pour un aperçu rapide.

La documentation est divisée en plusieurs sections :

* [Démarrage rapide](https://react.dev/learn)
* [Tutoriel](https://react.dev/learn/tutorial-tic-tac-toe)
* [Penser en React](https://react.dev/learn/thinking-in-react)
* [Installation](https://react.dev/learn/installation)
* [Décrire l’UI](https://react.dev/learn/describing-the-ui)
* [Ajouter de l’interactivité](https://react.dev/learn/adding-interactivity)
* [Gestion de l’état](https://react.dev/learn/managing-state)
* [Guides avancés](https://react.dev/learn/escape-hatches)
* [Référence API](https://react.dev/reference/react)
* [Où obtenir du support](https://react.dev/community)
* [Guide de contribution](https://legacy.reactjs.org/docs/how-to-contribute.html)

Vous pouvez l’améliorer en envoyant des pull requests à [ce dépôt](https://github.com/reactjs/react.dev).

## Exemples

Nous avons plusieurs exemples [sur le site web](https://react.dev/). Voici le premier pour commencer :

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Cet exemple affichera "Hello Taylor" dans un conteneur sur la page.

Vous remarquerez que nous avons utilisé une syntaxe semblable à du HTML ; [nous l’appelons JSX](https://react.dev/learn#writing-markup-with-jsx). JSX n’est pas obligatoire pour utiliser React, mais il rend le code plus lisible et son écriture ressemble à celle de HTML.

## Contribution

L’objectif principal de ce dépôt est de continuer à faire évoluer le cœur de React, pour le rendre plus rapide et plus facile à utiliser. Le développement de React se fait ouvertement sur GitHub et nous sommes reconnaissants envers la communauté pour les corrections de bugs et les améliorations. Lisez ci-dessous pour savoir comment vous pouvez contribuer à l’amélioration de React.

### [Code de conduite](https://code.fb.com/codeofconduct)

Facebook a adopté un code de conduite auquel nous attendons des participants au projet qu’ils adhèrent. Veuillez lire [le texte complet](https://code.fb.com/codeofconduct) afin de comprendre quelles actions seront ou non tolérées.

### [Guide de contribution](https://legacy.reactjs.org/docs/how-to-contribute.html)

Lisez notre [guide de contribution](https://legacy.reactjs.org/docs/how-to-contribute.html) pour en savoir plus sur notre processus de développement, comment proposer des corrections de bugs et des améliorations, ainsi que comment construire et tester vos modifications à React.

### [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)

Pour vous aider à débuter et à vous familiariser avec notre processus de contribution, nous avons une liste de [good first issues](https://github.com/facebook/react/labels/good%20first%20issue) qui contiennent des bugs à portée relativement limitée. C’est un excellent point de départ.

### Licence

React est sous licence [MIT](./LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---