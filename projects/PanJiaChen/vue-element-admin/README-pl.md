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

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

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

## Wprowadzenie

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) to gotowe do wdrożenia rozwiązanie front-endowe dla paneli administracyjnych. Bazuje na [vue](https://github.com/vuejs/vue) i wykorzystuje zestaw UI [element-ui](https://github.com/ElemeFE/element).

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) bazuje na najnowszym stosie technologicznym vue, posiada wbudowaną obsługę i18n, typowe szablony dla aplikacji korporacyjnych i wiele świetnych funkcji. Pomaga budować duże i złożone aplikacje jednostronicowe (SPA). Wierzę, że niezależnie od Twoich potrzeb, ten projekt Ci pomoże.

- [Podgląd](https://panjiachen.github.io/vue-element-admin)

- [Dokumentacja](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [Wesprzyj](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) Użytkownicy z Chin mogą skorzystać z tego adresu do podglądu online

- Zalecany szablon bazowy: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- Desktop: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (Podziękowania: [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**Po wersji `v4.1.0+` domyślna gałąź master nie wspiera i18n. Proszę używać [gałęzi i18n](https://github.com/PanJiaChen/vue-element-admin/tree/i18n), która będzie aktualizowana razem z masterem**

**Aktualna wersja to `v4.0+` oparta na `vue-cli`. Jeśli znajdziesz problem, zgłoś [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new). Jeśli chcesz używać starszej wersji, możesz przełączyć się na [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0), która nie wymaga `vue-cli`**

**Projekt nie wspiera przeglądarek w starszych wersjach (np. IE). W razie potrzeby dodaj polyfill samodzielnie.**

## Przygotowanie

Musisz lokalnie zainstalować [node](https://nodejs.org/) oraz [git](https://git-scm.com/). Projekt oparty jest na [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios) i [element-ui](https://github.com/ElemeFE/element). Wszystkie żądania danych są symulowane przez [Mock.js](https://github.com/nuysoft/Mock).
Znajomość tych technologii bardzo ułatwi korzystanie z projektu.

[![Edytuj w CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## Sponsorzy

Zostań sponsorem i umieść swoje logo w naszym README na GitHubie z linkiem do swojej strony. [[Zostań sponsorem]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Uzyskaj backend Java dla Vue admin z 20% zniżką za 39$ używając kodu kuponu SWB0RAZPZR1M
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Szablony paneli administracyjnych stworzone w Vue, React oraz Angular.</p>

## Funkcje

```
- Logowanie / Wylogowanie

- Autoryzacja uprawnień
  - Uprawnienia do strony
  - Uprawnienia dyrektyw
  - Strona konfiguracji uprawnień
  - Logowanie dwuetapowe

- Budowa wielośrodowiskowa
  - Develop (dev)
  - sit
  - Stage Test (stage)
  - Produkcja (prod)

- Funkcje globalne
  - I18n
  - Wiele dynamicznych motywów
  - Dynamiczny sidebar (obsługuje wielopoziomowe routingi)
  - Dynamiczny breadcrumb
  - Widok tagów (Strony z zakładkami, obsługa prawego przycisku myszy)
  - Svg Sprite
  - Mock data
  - Pełny ekran (Screenfull)
  - Reagujący Sidebar

- Edytor
  - Edytor tekstu sformatowanego (Rich Text Editor)
  - Edytor Markdown
  - Edytor JSON

- Excel
  - Eksport do Excela
  - Wgrywanie Excela
  - Wizualizacja Excela
  - Eksport zip

- Tabela
  - Dynamiczna tabela
  - Tabela z przeciąganiem i upuszczaniem
  - Edytowalna tabela w linii

- Strony błędów
  - 401
  - 404

- Komponenty
  - Wgrywanie awatara
  - Powrót do góry
  - Przeciągane okno dialogowe
  - Przeciągany wybór
  - Przeciągany kanban
  - Przeciągana lista
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- Zaawansowane przykłady
- Log błędów
- Dashboard
- Strona przewodnika
- ECharts
- Schowek (Clipboard)
- Markdown do html
```

## Pierwsze kroki

```bash
# klonowanie projektu
git clone https://github.com/PanJiaChen/vue-element-admin.git

# wejście do katalogu projektu
cd vue-element-admin

# instalacja zależności
npm install

# uruchomienie trybu developerskiego
npm run dev
```

To automatycznie otworzy http://localhost:9527

## Budowanie

```bash
# budowanie dla środowiska testowego
npm run build:stage

# budowanie dla środowiska produkcyjnego
npm run build:prod
```

## Zaawansowane

```bash
# podgląd efektu środowiska produkcyjnego
npm run preview

# podgląd efektu produkcyjnego + analiza zasobów statycznych
npm run preview -- --report

# sprawdzenie formatowania kodu
npm run lint

# sprawdzenie formatowania i automatyczna naprawa
npm run lint -- --fix
```

Więcej informacji w [dokumentacji](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html)

## Changelog

Szczegółowe zmiany dla każdego wydania znajdują się w [release notes](https://github.com/PanJiaChen/vue-element-admin/releases).

## Demo online

[Podgląd](https://panjiachen.github.io/vue-element-admin)

## Wesprzyj

Jeśli projekt okazał się przydatny, możesz postawić autorowi sok :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## Wsparcie przeglądarek

Nowoczesne przeglądarki oraz Internet Explorer 10+.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | ostatnie 2 wersje | ostatnie 2 wersje | ostatnie 2 wersje |

## Licencja

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Copyright (c) 2017-present PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---