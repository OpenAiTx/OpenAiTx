# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React to biblioteka JavaScript do budowania interfejsów użytkownika.

* **Deklaratywność:** React sprawia, że tworzenie interaktywnych interfejsów użytkownika jest bezbolesne. Projektuj proste widoki dla każdego stanu swojej aplikacji, a React efektywnie zaktualizuje i wyrenderuje tylko odpowiednie komponenty, gdy Twoje dane się zmienią. Deklaratywne widoki sprawiają, że Twój kod jest bardziej przewidywalny, prostszy do zrozumienia i łatwiejszy do debugowania.
* **Komponentowość:** Buduj hermetyczne komponenty, które zarządzają własnym stanem, a następnie komponuj je, aby tworzyć złożone interfejsy. Ponieważ logika komponentów jest pisana w JavaScript, a nie w szablonach, możesz łatwo przekazywać bogate dane przez całą aplikację i trzymać stan poza DOM-em.
* **Naucz się raz, pisz wszędzie:** Nie zakładamy niczego o reszcie Twojego stosu technologicznego, więc możesz rozwijać nowe funkcje w React bez przepisywania istniejącego kodu. React może być także renderowany po stronie serwera przy użyciu [Node](https://nodejs.org/en) oraz napędzać aplikacje mobilne za pomocą [React Native](https://reactnative.dev/).

[Dowiedz się, jak używać React w swoim projekcie](https://react.dev/learn).

## Instalacja

React został zaprojektowany z myślą o stopniowej adopcji od samego początku, dlatego **możesz użyć tyle Reacta, ile potrzebujesz**:

* Skorzystaj z [Szybkiego Startu](https://react.dev/learn), aby zapoznać się z React.
* [Dodaj React do istniejącego projektu](https://react.dev/learn/add-react-to-an-existing-project), aby użyć tak mało lub tak dużo Reacta, jak potrzebujesz.
* [Stwórz nową aplikację React](https://react.dev/learn/start-a-new-react-project), jeśli szukasz potężnego zestawu narzędzi JavaScript.

## Dokumentacja

Dokumentację React znajdziesz [na stronie internetowej](https://react.dev/).

Zajrzyj na stronę [Pierwsze kroki](https://react.dev/learn), aby uzyskać szybki przegląd.

Dokumentacja podzielona jest na kilka sekcji:

* [Szybki Start](https://react.dev/learn)
* [Samouczek](https://react.dev/learn/tutorial-tic-tac-toe)
* [Myślenie w React](https://react.dev/learn/thinking-in-react)
* [Instalacja](https://react.dev/learn/installation)
* [Opisywanie UI](https://react.dev/learn/describing-the-ui)
* [Dodawanie interaktywności](https://react.dev/learn/adding-interactivity)
* [Zarządzanie stanem](https://react.dev/learn/managing-state)
* [Zaawansowane przewodniki](https://react.dev/learn/escape-hatches)
* [Referencja API](https://react.dev/reference/react)
* [Gdzie uzyskać wsparcie](https://react.dev/community)
* [Przewodnik dla współtwórców](https://legacy.reactjs.org/docs/how-to-contribute.html)

Możesz ją ulepszyć, wysyłając pull requesty do [tego repozytorium](https://github.com/reactjs/react.dev).

## Przykłady

Mamy kilka przykładów [na stronie internetowej](https://react.dev/). Oto pierwszy z nich, abyś mógł zacząć:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Ten przykład wyrenderuje "Hello Taylor" w kontenerze na stronie.

Zauważysz, że użyliśmy składni podobnej do HTML; [nazywamy ją JSX](https://react.dev/learn#writing-markup-with-jsx). JSX nie jest wymagany do używania React, ale sprawia, że kod jest bardziej czytelny, a jego pisanie przypomina pisanie HTML.

## Współtworzenie

Głównym celem tego repozytorium jest dalszy rozwój rdzenia React, czyniąc go szybszym i łatwiejszym w użyciu. Rozwój React odbywa się otwarcie na GitHubie, a my jesteśmy wdzięczni społeczności za zgłaszane poprawki błędów i ulepszenia. Przeczytaj poniżej, jak możesz wziąć udział w ulepszaniu React.

### [Kodeks Postępowania](https://code.fb.com/codeofconduct)

Facebook przyjął Kodeks Postępowania, którego przestrzegania oczekujemy od uczestników projektu. Przeczytaj [pełny tekst](https://code.fb.com/codeofconduct), aby dowiedzieć się, jakie działania będą, a jakie nie będą tolerowane.

### [Przewodnik dla współtwórców](https://legacy.reactjs.org/docs/how-to-contribute.html)

Przeczytaj nasz [przewodnik dla współtwórców](https://legacy.reactjs.org/docs/how-to-contribute.html), aby dowiedzieć się o naszym procesie rozwoju, jak zgłaszać poprawki i ulepszenia oraz jak budować i testować swoje zmiany w React.

### [Dobre pierwsze zgłoszenia](https://github.com/facebook/react/labels/good%20first%20issue)

Aby pomóc Ci rozpocząć i zapoznać się z naszym procesem współtworzenia, mamy listę [dobrych pierwszych zgłoszeń](https://github.com/facebook/react/labels/good%20first%20issue), które zawierają błędy o stosunkowo ograniczonym zakresie. To świetne miejsce, by zacząć.

### Licencja

React jest objęty licencją [MIT](./LICENSE).

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---