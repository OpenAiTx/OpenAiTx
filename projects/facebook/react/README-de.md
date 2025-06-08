# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React ist eine JavaScript-Bibliothek zur Erstellung von Benutzeroberflächen.

* **Deklarativ:** React macht es einfach, interaktive Benutzeroberflächen zu erstellen. Entwerfen Sie einfache Ansichten für jeden Zustand Ihrer Anwendung, und React aktualisiert und rendert effizient nur die richtigen Komponenten, wenn sich Ihre Daten ändern. Deklarative Ansichten machen Ihren Code vorhersehbarer, leichter verständlich und einfacher zu debuggen.
* **Komponentenbasiert:** Bauen Sie gekapselte Komponenten, die ihren eigenen Zustand verwalten, und setzen Sie sie dann zusammen, um komplexe Benutzeroberflächen zu erstellen. Da die Komponentenlogik in JavaScript statt in Templates geschrieben wird, können Sie problemlos umfangreiche Daten durch Ihre App schleusen und den Zustand außerhalb des DOM halten.
* **Einmal lernen, überall schreiben:** Wir machen keine Annahmen über den Rest Ihres Technologie-Stacks, sodass Sie neue Features in React entwickeln können, ohne bestehenden Code neu schreiben zu müssen. React kann auch auf dem Server mit [Node](https://nodejs.org/en) gerendert werden und mobile Apps mit [React Native](https://reactnative.dev/) unterstützen.

[Erfahren Sie, wie Sie React in Ihrem Projekt verwenden können](https://react.dev/learn).

## Installation

React wurde von Anfang an für eine schrittweise Einführung konzipiert, und **Sie können so wenig oder so viel React verwenden, wie Sie benötigen**:

* Verwenden Sie [Schnellstart](https://react.dev/learn), um einen ersten Eindruck von React zu bekommen.
* [Fügen Sie React zu einem bestehenden Projekt hinzu](https://react.dev/learn/add-react-to-an-existing-project), um so wenig oder so viel React zu nutzen, wie Sie möchten.
* [Erstellen Sie eine neue React-App](https://react.dev/learn/start-a-new-react-project), wenn Sie auf der Suche nach einer leistungsfähigen JavaScript-Toolchain sind.

## Dokumentation

Die React-Dokumentation finden Sie [auf der Website](https://react.dev/).

Schauen Sie sich die Seite [Erste Schritte](https://react.dev/learn) für einen schnellen Überblick an.

Die Dokumentation ist in mehrere Abschnitte unterteilt:

* [Schnellstart](https://react.dev/learn)
* [Tutorial](https://react.dev/learn/tutorial-tic-tac-toe)
* [Thinking in React](https://react.dev/learn/thinking-in-react)
* [Installation](https://react.dev/learn/installation)
* [UI beschreiben](https://react.dev/learn/describing-the-ui)
* [Interaktivität hinzufügen](https://react.dev/learn/adding-interactivity)
* [Zustandsverwaltung](https://react.dev/learn/managing-state)
* [Fortgeschrittene Anleitungen](https://react.dev/learn/escape-hatches)
* [API-Referenz](https://react.dev/reference/react)
* [Wo Sie Unterstützung erhalten](https://react.dev/community)
* [Beitragenden-Leitfaden](https://legacy.reactjs.org/docs/how-to-contribute.html)

Sie können die Dokumentation verbessern, indem Sie Pull Requests an [dieses Repository](https://github.com/reactjs/react.dev) senden.

## Beispiele

Wir haben mehrere Beispiele [auf der Website](https://react.dev/). Hier ist das erste, um Ihnen den Einstieg zu erleichtern:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Dieses Beispiel rendert „Hello Taylor“ in einen Container auf der Seite.

Sie werden feststellen, dass wir eine HTML-ähnliche Syntax verwendet haben; [wir nennen sie JSX](https://react.dev/learn#writing-markup-with-jsx). JSX ist für die Verwendung von React nicht erforderlich, aber es macht den Code lesbarer und das Schreiben fühlt sich an wie HTML.

## Mitwirken

Der Hauptzweck dieses Repositories ist es, den React-Kern weiterzuentwickeln, ihn schneller und benutzerfreundlicher zu machen. Die Entwicklung von React findet offen auf GitHub statt, und wir sind der Community dankbar für die Behebung von Fehlern und Verbesserungen. Lesen Sie weiter, um zu erfahren, wie Sie zur Verbesserung von React beitragen können.

### [Verhaltenskodex](https://code.fb.com/codeofconduct)

Facebook hat einen Verhaltenskodex angenommen, an den sich Projektbeteiligte halten sollen. Bitte lesen Sie [den vollständigen Text](https://code.fb.com/codeofconduct), damit Sie verstehen, welche Handlungen toleriert werden und welche nicht.

### [Beitragenden-Leitfaden](https://legacy.reactjs.org/docs/how-to-contribute.html)

Lesen Sie unseren [Beitragenden-Leitfaden](https://legacy.reactjs.org/docs/how-to-contribute.html), um mehr über unseren Entwicklungsprozess, das Vorschlagen von Fehlerbehebungen und Verbesserungen sowie das Bauen und Testen Ihrer Änderungen an React zu erfahren.

### [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)

Um Ihnen den Einstieg zu erleichtern und Sie mit unserem Beitragenden-Prozess vertraut zu machen, haben wir eine Liste von [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue) zusammengestellt, die Fehler mit relativ geringem Umfang enthalten. Das ist ein großartiger Ort, um zu beginnen.

### Lizenz

React ist [MIT-lizenziert](./LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---