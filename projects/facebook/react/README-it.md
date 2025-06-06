# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React è una libreria JavaScript per la creazione di interfacce utente.

* **Dichiarativo:** React rende indolore la creazione di UI interattive. Progetta viste semplici per ogni stato della tua applicazione e React aggiornerà ed effettuerà il rendering in modo efficiente solo dei componenti necessari quando i tuoi dati cambiano. Le viste dichiarative rendono il tuo codice più prevedibile, semplice da capire e più facile da debuggare.
* **Basato su Componenti:** Costruisci componenti incapsulati che gestiscono il proprio stato, poi componili per creare UI complesse. Poiché la logica dei componenti è scritta in JavaScript invece che nei template, puoi facilmente passare dati complessi attraverso la tua app e mantenere lo stato fuori dal DOM.
* **Impara una volta, scrivi ovunque:** Non facciamo assunzioni sul resto del tuo stack tecnologico, così puoi sviluppare nuove funzionalità in React senza riscrivere codice esistente. React può anche effettuare il rendering sul server usando [Node](https://nodejs.org/en) e alimentare app mobile usando [React Native](https://reactnative.dev/).

[Scopri come usare React nel tuo progetto](https://react.dev/learn).

## Installazione

React è stato progettato fin dall’inizio per essere adottato gradualmente, e **puoi usare React quanto poco o quanto vuoi**:

* Usa [Guida Rapida](https://react.dev/learn) per avere un assaggio di React.
* [Aggiungi React a un progetto esistente](https://react.dev/learn/add-react-to-an-existing-project) per usare React quanto poco o quanto vuoi.
* [Crea una nuova app React](https://react.dev/learn/start-a-new-react-project) se stai cercando una toolchain JavaScript potente.

## Documentazione

Puoi trovare la documentazione di React [sul sito web](https://react.dev/).

Dai un’occhiata alla pagina [Per iniziare](https://react.dev/learn) per una panoramica rapida.

La documentazione è divisa in diverse sezioni:

* [Guida Rapida](https://react.dev/learn)
* [Tutorial](https://react.dev/learn/tutorial-tic-tac-toe)
* [Pensare in React](https://react.dev/learn/thinking-in-react)
* [Installazione](https://react.dev/learn/installation)
* [Descrivere la UI](https://react.dev/learn/describing-the-ui)
* [Aggiungere Interattività](https://react.dev/learn/adding-interactivity)
* [Gestione dello Stato](https://react.dev/learn/managing-state)
* [Guide Avanzate](https://react.dev/learn/escape-hatches)
* [Riferimento API](https://react.dev/reference/react)
* [Dove ottenere supporto](https://react.dev/community)
* [Guida al Contributo](https://legacy.reactjs.org/docs/how-to-contribute.html)

Puoi migliorarla inviando pull request a [questo repository](https://github.com/reactjs/react.dev).

## Esempi

Abbiamo diversi esempi [sul sito web](https://react.dev/). Ecco il primo per iniziare:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Questo esempio effettuerà il rendering di "Hello Taylor" in un contenitore sulla pagina.

Noterai che abbiamo usato una sintassi simile a HTML; [la chiamiamo JSX](https://react.dev/learn#writing-markup-with-jsx). JSX non è richiesta per usare React, ma rende il codice più leggibile e scriverla dà la sensazione di scrivere HTML.

## Contribuire

Lo scopo principale di questo repository è continuare a far evolvere il core di React, rendendolo più veloce e facile da usare. Lo sviluppo di React avviene pubblicamente su GitHub e siamo grati alla community per il contributo di bugfix e miglioramenti. Leggi qui sotto per scoprire come puoi partecipare al miglioramento di React.

### [Codice di Condotta](https://code.fb.com/codeofconduct)

Facebook ha adottato un Codice di Condotta al quale ci aspettiamo che i partecipanti al progetto aderiscano. Per favore leggi [il testo completo](https://code.fb.com/codeofconduct) così da capire quali azioni saranno e non saranno tollerate.

### [Guida al Contributo](https://legacy.reactjs.org/docs/how-to-contribute.html)

Leggi la nostra [guida al contributo](https://legacy.reactjs.org/docs/how-to-contribute.html) per saperne di più sul nostro processo di sviluppo, su come proporre bugfix e miglioramenti, e su come costruire e testare le tue modifiche a React.

### [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)

Per aiutarti a prendere confidenza e familiarizzare con il nostro processo di contributo, abbiamo una lista di [good first issues](https://github.com/facebook/react/labels/good%20first%20issue) che contengono bug di portata relativamente limitata. Questo è un ottimo punto di partenza.

### Licenza

React è distribuito sotto [licenza MIT](./LICENSE).

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---