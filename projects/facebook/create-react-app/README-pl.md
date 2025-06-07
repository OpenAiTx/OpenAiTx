## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!OSTROŻNIE]
>
> ## Przestarzałe
>
> Create React App był jednym z kluczowych narzędzi do uruchamiania projektów React w latach 2017-2021, obecnie znajduje się w stanie długoterminowego zamrożenia i zalecamy migrację do jednego z frameworków React opisanych na stronie [Rozpocznij nowy projekt React](https://react.dev/learn/start-a-new-react-project).
>
> Jeśli korzystasz z tutorialu, aby nauczyć się Reacta, warto kontynuować naukę, ale nie zalecamy rozpoczynania produkcyjnych aplikacji w oparciu o Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Twórz aplikacje React bez potrzeby konfiguracji procesu budowy.

- [Tworzenie aplikacji](#creating-an-app) – Jak utworzyć nową aplikację.
- [Przewodnik użytkownika](https://facebook.github.io/create-react-app/) – Jak rozwijać aplikacje utworzone za pomocą Create React App.

Create React App działa na systemach macOS, Windows i Linux.<br>
Jeśli coś nie działa, prosimy o [zgłoszenie problemu](https://github.com/facebook/create-react-app/issues/new).<br>
Jeśli masz pytania lub potrzebujesz pomocy, zapytaj na [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Szybki przegląd

```sh
npx create-react-app my-app
cd my-app
npm start
```

Jeśli wcześniej zainstalowałeś `create-react-app` globalnie poprzez `npm install -g create-react-app`, zalecamy odinstalowanie pakietu za pomocą `npm uninstall -g create-react-app` lub `yarn global remove create-react-app`, aby upewnić się, że npx zawsze używa najnowszej wersji.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) jest dostarczany z npm 5.2+ i wyższymi, zobacz [instrukcje dla starszych wersji npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Następnie otwórz [http://localhost:3000/](http://localhost:3000/), aby zobaczyć swoją aplikację.<br>
Gdy będziesz gotowy do wdrożenia produkcyjnego, utwórz zminifikowaną paczkę poleceniem `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Zacznij od razu

Nie **musisz** instalować ani konfigurować narzędzi takich jak webpack czy Babel.<br>
Są one skonfigurowane i ukryte, abyś mógł skupić się na pisaniu kodu.

Utwórz projekt i możesz od razu zaczynać.

## Tworzenie aplikacji

**Musisz mieć Node w wersji co najmniej 14.0.0 na swoim lokalnym komputerze deweloperskim** (ale nie jest to wymagane na serwerze). Zalecamy korzystanie z najnowszej wersji LTS. Możesz użyć [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) lub [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows), aby przełączać wersje Node między różnymi projektami.

Aby utworzyć nową aplikację, możesz wybrać jedną z poniższych metod:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) to narzędzie do uruchamiania pakietów, dostępne w npm 5.2+ i wyższych, zobacz [instrukcje dla starszych wersji npm](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` jest dostępne w npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) jest dostępne w Yarn 0.25+_

Zostanie utworzony katalog `my-app` w bieżącym folderze.<br>
Wewnątrz tego katalogu zostanie wygenerowana początkowa struktura projektu oraz zainstalowane zależności pośrednie:

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

Brak konfiguracji lub skomplikowanych struktur katalogów – tylko pliki potrzebne do zbudowania aplikacji.<br>
Po zakończeniu instalacji możesz otworzyć folder swojego projektu:

```sh
cd my-app
```

W nowo utworzonym projekcie możesz uruchamiać wbudowane polecenia:

### `npm start` lub `yarn start`

Uruchamia aplikację w trybie deweloperskim.<br>
Otwórz [http://localhost:3000](http://localhost:3000), aby zobaczyć ją w przeglądarce.

Strona będzie automatycznie przeładowywać się po dokonaniu zmian w kodzie.<br>
Błędy budowania i ostrzeżenia lintera zobaczysz w konsoli.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` lub `yarn test`

Uruchamia interaktywny tryb testowania.<br>
Domyślnie uruchamia testy dotyczące plików zmienionych od ostatniego commita.

[Dowiedz się więcej o testowaniu.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` lub `yarn build`

Buduje aplikację do produkcji w folderze `build`.<br>
Prawidłowo pakuje Reacta w trybie produkcyjnym i optymalizuje budowę pod najlepszą wydajność.

Budowa jest zminifikowana, a nazwy plików zawierają hashe.<br>

Twoja aplikacja jest gotowa do wdrożenia.

## Przewodnik użytkownika

Szczegółowe instrukcje dotyczące korzystania z Create React App oraz liczne wskazówki znajdziesz w [dokumentacji](https://facebook.github.io/create-react-app/).

## Jak zaktualizować do nowych wersji?

Zobacz [Przewodnik użytkownika](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) po więcej informacji na ten temat.

## Filozofia

- **Jedna zależność:** Istnieje tylko jedna zależność buildowa. Wykorzystuje webpack, Babel, ESLint i inne świetne projekty, ale zapewnia spójne, wyselekcjonowane doświadczenie na ich bazie.

- **Brak wymogu konfiguracji:** Nie musisz nic konfigurować. Rozsądna konfiguracja zarówno dla środowiska deweloperskiego, jak i produkcyjnego jest przygotowana za Ciebie, abyś mógł skupić się na pisaniu kodu.

- **Brak blokady:** W każdej chwili możesz „wyeksportować” konfigurację do własnego setupu. Wystarczy jedno polecenie, a cała konfiguracja i zależności buildowe zostaną przeniesione bezpośrednio do Twojego projektu, byś mógł kontynuować pracę w dowolny sposób.

## Co zawiera?

Twoje środowisko będzie miało wszystko, czego potrzebujesz do zbudowania nowoczesnej, jednostronicowej aplikacji React:

- Obsługa React, JSX, ES6, TypeScript i Flow.
- Dodatkowe funkcje językowe wykraczające poza ES6, np. operator spread dla obiektów.
- CSS z automatycznym dodawaniem prefiksów, dzięki czemu nie potrzebujesz `-webkit-` ani innych prefiksów.
- Szybki, interaktywny runner testów jednostkowych z wbudowanym raportowaniem pokrycia.
- Serwer deweloperski na żywo, ostrzegający o typowych błędach.
- Skrypt budujący do pakowania JS, CSS i obrazków na produkcję, z hashami i sourcemapami.
- [Service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) z podejściem offline-first oraz [manifest aplikacji webowej](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/) spełniający wszystkie kryteria [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_Uwaga: użycie service workera jest opcjonalne od `react-scripts@2.0.0` wzwyż_)
- Bezproblemowe aktualizacje powyższych narzędzi dzięki jednej zależności.

Zobacz [ten przewodnik](https://github.com/nitishdayal/cra_closer_look) po przegląd, jak te narzędzia współpracują.

Minusem jest to, że **te narzędzia są skonfigurowane do działania w określony sposób**. Jeśli Twój projekt wymaga większej personalizacji, możesz ["wyeksportować"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) konfigurację, ale wtedy będziesz musiał ją samodzielnie utrzymywać.

## Popularne alternatywy

Create React App świetnie sprawdza się do:

- **Nauki React** w wygodnym i bogatym w funkcje środowisku deweloperskim.
- **Rozpoczynania nowych, jednostronicowych aplikacji React.**
- **Tworzenia przykładów** do bibliotek i komponentów React.

Oto kilka typowych przypadków, kiedy warto rozważyć inne rozwiązania:

- Jeśli chcesz **wypróbować React** bez setek zależności narzędzi buildowych, rozważ [użycie pojedynczego pliku HTML lub internetowego sandboxa](https://reactjs.org/docs/getting-started.html#try-react).

- Jeśli musisz **zintegrować kod React z frameworkiem szablonów po stronie serwera** jak Rails, Django czy Symfony, lub **nie budujesz SPA**, rozważ użycie [nwb](https://github.com/insin/nwb) lub [Neutrino](https://neutrino.js.org/), które są bardziej elastyczne. Dla Rails możesz użyć [Rails Webpacker](https://github.com/rails/webpacker). Dla Symfony, spróbuj [Symfony's webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Jeśli chcesz **opublikować komponent React**, [nwb](https://github.com/insin/nwb) [również to potrafi](https://github.com/insin/nwb#react-components-and-libraries), podobnie jak [preset Neutrino dla komponentów React](https://neutrino.js.org/packages/react-components/).

- Jeśli zależy Ci na **renderowaniu po stronie serwera** z React i Node.js, zobacz [Next.js](https://nextjs.org/) lub [Razzle](https://github.com/jaredpalmer/razzle). Create React App jest agnostyczny względem backendu i produkuje tylko statyczne paczki HTML/JS/CSS.

- Jeśli Twoja strona jest **głównie statyczna** (np. portfolio lub blog), rozważ użycie [Gatsby](https://www.gatsbyjs.org/) lub [Next.js](https://nextjs.org/). W przeciwieństwie do Create React App, Gatsby renderuje stronę do HTML podczas budowy. Next.js obsługuje zarówno renderowanie po stronie serwera, jak i prerendering.

- Jeśli potrzebujesz **więcej personalizacji**, zobacz [Neutrino](https://neutrino.js.org/) i jego [preset React](https://neutrino.js.org/packages/react/).

Wszystkie powyższe narzędzia mogą działać przy minimalnej lub zerowej konfiguracji.

Jeśli wolisz samodzielnie konfigurować build, [postępuj według tego przewodnika](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Szukasz czegoś podobnego, ale dla React Native?<br>
Zobacz [Expo CLI](https://github.com/expo/expo-cli).

## Współtworzenie

Chętnie przyjmiemy Twoją pomoc przy `create-react-app`! Zobacz [CONTRIBUTING.md](CONTRIBUTING.md) po więcej informacji, czego szukamy i jak zacząć.

## Wspieranie Create React App

Create React App to projekt utrzymywany przez społeczność, a wszyscy współtwórcy są wolontariuszami. Jeśli chcesz wesprzeć przyszły rozwój Create React App, rozważ wsparcie finansowe na naszym [Open Collective](https://opencollective.com/create-react-app).

## Podziękowania

Projekt istnieje dzięki wszystkim osobom, które [współtworzą](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Dziękujemy [Netlify](https://www.netlify.com/) za hosting naszej dokumentacji.

## Uznania

Jesteśmy wdzięczni autorom powiązanych projektów za ich pomysły i współpracę:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Licencja

Create React App jest oprogramowaniem open source [na licencji MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). Logo Create React App jest objęte licencją [Creative Commons Attribution 4.0 International](https://creativecommons.org/licenses/by/4.0/).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---