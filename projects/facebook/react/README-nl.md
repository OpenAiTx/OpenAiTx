# [React](https://react.dev/) &middot; [![GitHub licentie](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm versie](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React is een JavaScript-bibliotheek voor het bouwen van gebruikersinterfaces.

* **Declaratief:** React maakt het eenvoudig om interactieve UI's te creëren. Ontwerp eenvoudige weergaven voor elke toestand in je applicatie, en React werkt efficiënt bij en rendert precies de juiste componenten wanneer je data verandert. Declaratieve weergaven maken je code voorspelbaarder, eenvoudiger te begrijpen en gemakkelijker te debuggen.
* **Componentgebaseerd:** Bouw ingekapselde componenten die hun eigen toestand beheren, en combineer ze vervolgens om complexe UI's te maken. Omdat componentlogica in JavaScript wordt geschreven in plaats van in templates, kun je eenvoudig rijke data door je app sturen en de toestand buiten de DOM houden.
* **Leer één keer, schrijf overal:** We doen geen aannames over de rest van je technologiestack, dus je kunt nieuwe functies in React ontwikkelen zonder bestaande code te herschrijven. React kan ook renderen op de server met [Node](https://nodejs.org/en) en mobiele apps aandrijven met [React Native](https://reactnative.dev/).

[Leer hoe je React in je project gebruikt](https://react.dev/learn).

## Installatie

React is vanaf het begin ontworpen voor geleidelijke adoptie, en **je kunt zo weinig of zo veel React gebruiken als je nodig hebt**:

* Gebruik [Snelstart](https://react.dev/learn) om een indruk van React te krijgen.
* [Voeg React toe aan een bestaand project](https://react.dev/learn/add-react-to-an-existing-project) om zo weinig of zo veel React te gebruiken als je wilt.
* [Maak een nieuw React-project](https://react.dev/learn/start-a-new-react-project) als je op zoek bent naar een krachtige JavaScript-toolchain.

## Documentatie

Je vindt de React-documentatie [op de website](https://react.dev/).

Bekijk de pagina [Aan de slag](https://react.dev/learn) voor een snel overzicht.

De documentatie is onderverdeeld in verschillende secties:

* [Snelstart](https://react.dev/learn)
* [Tutorial](https://react.dev/learn/tutorial-tic-tac-toe)
* [Denken in React](https://react.dev/learn/thinking-in-react)
* [Installatie](https://react.dev/learn/installation)
* [De UI beschrijven](https://react.dev/learn/describing-the-ui)
* [Interactiviteit toevoegen](https://react.dev/learn/adding-interactivity)
* [Toestand beheren](https://react.dev/learn/managing-state)
* [Geavanceerde gidsen](https://react.dev/learn/escape-hatches)
* [API Referentie](https://react.dev/reference/react)
* [Waar ondersteuning te krijgen](https://react.dev/community)
* [Bijdragenhandleiding](https://legacy.reactjs.org/docs/how-to-contribute.html)

Je kunt de documentatie verbeteren door pull requests in te dienen naar [deze repository](https://github.com/reactjs/react.dev).

## Voorbeelden

We hebben verschillende voorbeelden [op de website](https://react.dev/). Hier is het eerste voorbeeld om je op weg te helpen:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Dit voorbeeld rendert "Hello Taylor" in een container op de pagina.

Je zult merken dat we een HTML-achtige syntax gebruiken; [wij noemen dit JSX](https://react.dev/learn#writing-markup-with-jsx). JSX is niet vereist om React te gebruiken, maar het maakt de code leesbaarder en schrijven voelt als het schrijven van HTML.

## Bijdragen

Het belangrijkste doel van deze repository is om de kern van React verder te ontwikkelen, zodat het sneller en gemakkelijker te gebruiken wordt. De ontwikkeling van React gebeurt openlijk op GitHub, en we zijn de community dankbaar voor het bijdragen van bugfixes en verbeteringen. Lees hieronder hoe je kunt bijdragen aan het verbeteren van React.

### [Gedragscode](https://code.fb.com/codeofconduct)

Facebook heeft een gedragscode aangenomen waarvan we verwachten dat projectdeelnemers zich eraan houden. Lees [de volledige tekst](https://code.fb.com/codeofconduct) zodat je begrijpt welke acties wel en niet worden getolereerd.

### [Bijdragenhandleiding](https://legacy.reactjs.org/docs/how-to-contribute.html)

Lees onze [bijdragenhandleiding](https://legacy.reactjs.org/docs/how-to-contribute.html) om te leren over ons ontwikkelproces, hoe je bugfixes en verbeteringen kunt voorstellen, en hoe je jouw wijzigingen aan React kunt bouwen en testen.

### [Goede eerste issues](https://github.com/facebook/react/labels/good%20first%20issue)

Om je te helpen snel te starten en vertrouwd te raken met ons bijdrageproces, hebben we een lijst met [goede eerste issues](https://github.com/facebook/react/labels/good%20first%20issue) die bugs bevatten met een relatief beperkte scope. Dit is een geweldige plek om te beginnen.

### Licentie

React is [MIT gelicentieerd](./LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---