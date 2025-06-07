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

## Einführung

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) ist eine produktionsreife Frontend-Lösung für Admin-Oberflächen. Sie basiert auf [vue](https://github.com/vuejs/vue) und verwendet das UI-Toolkit [element-ui](https://github.com/ElemeFE/element).

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) basiert auf dem neuesten Entwicklungsstack von Vue und besitzt eine integrierte i18n-Lösung, typische Templates für Unternehmensanwendungen und viele großartige Funktionen. Es hilft Ihnen dabei, große und komplexe Single-Page-Anwendungen zu erstellen. Ich glaube, unabhängig von Ihren Anforderungen wird dieses Projekt Ihnen weiterhelfen.

- [Vorschau](https://panjiachen.github.io/vue-element-admin)

- [Dokumentation](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [Spenden](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) Für Benutzer in China: Online-Vorschau

- Basistemplate empfohlen: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- Desktop: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (Dank an: [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**Ab Version `v4.1.0+` unterstützt der Standard-Master-Branch kein i18n mehr. Bitte nutzen Sie den [i18n-Branch](https://github.com/PanJiaChen/vue-element-admin/tree/i18n), dieser bleibt mit dem Master-Branch aktuell.**

**Die aktuelle Version ist `v4.0+` und basiert auf `vue-cli`. Bei Problemen bitte ein [Issue](https://github.com/PanJiaChen/vue-element-admin/issues/new) erstellen. Möchten Sie die alte Version nutzen, wechseln Sie bitte zum Branch [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0), diese Version benötigt kein `vue-cli`.**

**Dieses Projekt unterstützt keine älteren Browser-Versionen (z.B. IE). Bitte fügen Sie bei Bedarf selbst Polyfills hinzu.**

## Vorbereitung

Sie müssen [node](https://nodejs.org/) und [git](https://git-scm.com/) lokal installieren. Das Projekt basiert auf [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios) und [element-ui](https://github.com/ElemeFE/element). Alle Anfragedaten werden mit [Mock.js](https://github.com/nuysoft/Mock) simuliert.
Das Vorwissen und Lernen dieser Technologien ist für die Nutzung dieses Projekts von großem Vorteil.

[![Edit on CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## Sponsoren

Werden Sie Sponsor und platzieren Sie Ihr Logo mit einem Link zu Ihrer Website in unserem README auf GitHub. [[Sponsor werden]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Erhalten Sie ein Java-Backend für das Vue-Admin mit 20% Rabatt für 39$ – Gutscheincode SWB0RAZPZR1M verwenden.
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Admin Dashboard Templates erstellt mit Vue, React und Angular.</p>

## Funktionen

```
- Login / Logout

- Berechtigungs-Authentifizierung
  - Seitenberechtigung
  - Direktivenberechtigung
  - Berechtigungskonfigurationsseite
  - Zwei-Schritt-Login

- Multi-Umgebungs-Build
  - Entwicklung (dev)
  - sit
  - Staging-Test (stage)
  - Produktion (prod)

- Globale Funktionen
  - I18n
  - Mehrere dynamische Themes
  - Dynamische Seitenleiste (unterstützt mehrstufiges Routing)
  - Dynamische Breadcrumb
  - Tags-Ansicht (Tab-Seite, unterstützt Rechtsklick)
  - SVG Sprite
  - Mock-Daten
  - Screenfull
  - Responsive Seitenleiste

- Editor
  - Rich-Text-Editor
  - Markdown-Editor
  - JSON-Editor

- Excel
  - Export nach Excel
  - Excel-Upload
  - Visualisierung in Excel
  - Export als zip

- Tabelle
  - Dynamische Tabelle
  - Drag-and-Drop-Tabelle
  - Inline-Bearbeitungstabelle

- Fehlerseite
  - 401
  - 404

- Komponenten
  - Avatar-Upload
  - Zurück nach oben
  - Drag-Dialog
  - Drag-Auswahl
  - Drag-Kanban
  - Drag-Liste
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- Erweiterte Beispiele
- Fehler-Log
- Dashboard
- Einführungsseite
- ECharts
- Zwischenablage
- Markdown zu HTML
```

## Einstieg

```bash
# Projekt klonen
git clone https://github.com/PanJiaChen/vue-element-admin.git

# In das Projektverzeichnis wechseln
cd vue-element-admin

# Abhängigkeiten installieren
npm install

# Entwicklung starten
npm run dev
```

Dies öffnet automatisch http://localhost:9527

## Build

```bash
# Build für Testumgebung
npm run build:stage

# Build für Produktionsumgebung
npm run build:prod
```

## Erweiterte Nutzung

```bash
# Vorschau der Release-Umgebung
npm run preview

# Vorschau + Analyse der statischen Ressourcen
npm run preview -- --report

# Code-Formatprüfung
npm run lint

# Code-Formatprüfung und automatische Korrektur
npm run lint -- --fix
```

Weitere Informationen finden Sie in der [Dokumentation](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html)

## Changelog

Detaillierte Änderungen jeder Version sind in den [Release Notes](https://github.com/PanJiaChen/vue-element-admin/releases) dokumentiert.

## Online-Demo

[Vorschau](https://panjiachen.github.io/vue-element-admin)

## Spenden

Wenn Sie dieses Projekt nützlich finden, können Sie dem Autor ein Glas Saft spendieren :tropical_drink:

![spenden](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## Browserunterstützung

Moderne Browser und Internet Explorer 10+.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | letzte 2 Versionen | letzte 2 Versionen | letzte 2 Versionen |

## Lizenz

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Copyright (c) 2017-heute PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---