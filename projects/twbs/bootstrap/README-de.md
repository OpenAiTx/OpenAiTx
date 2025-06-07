<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Schlankes, intuitives und leistungsstarkes Frontend-Framework für eine schnellere und einfachere Webentwicklung.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Bootstrap-Dokumentation entdecken »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Fehler melden</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Feature anfragen</a>
  ·
  <a href="https://themes.getbootstrap.com/">Themes</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Unser Standard-Branch dient der Entwicklung des Bootstrap 5 Releases. Wechseln Sie zum [`v4-dev` Branch](https://github.com/twbs/bootstrap/tree/v4-dev), um das Readme, die Dokumentation und den Quellcode für Bootstrap 4 einzusehen.


## Inhaltsverzeichnis

- [Schnellstart](#schnellstart)
- [Status](#status)
- [Inhalt](#inhalt)
- [Fehler und Feature-Anfragen](#fehler-und-feature-anfragen)
- [Dokumentation](#dokumentation)
- [Mitwirken](#mitwirken)
- [Community](#community)
- [Versionierung](#versionierung)
- [Urheber](#urheber)
- [Dank](#dank)
- [Urheberrecht und Lizenz](#urheberrecht-und-lizenz)


## Schnellstart

Es stehen mehrere Schnellstart-Optionen zur Verfügung:

- [Laden Sie das neueste Release herunter](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Klonen Sie das Repository: `git clone https://github.com/twbs/bootstrap.git`
- Installation mit [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Installation mit [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Installation mit [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Installation mit [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Installation mit [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Lesen Sie die [Getting Started-Seite](https://getbootstrap.com/docs/5.3/getting-started/introduction/) für Informationen über den Framework-Inhalt, Vorlagen, Beispiele und mehr.


## Status

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
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## Inhalt

Im Download finden Sie die folgenden Verzeichnisse und Dateien, die gängige Ressourcen logisch gruppieren und sowohl kompilierte als auch minimierte Varianten bereitstellen.

<details>
  <summary>Download-Inhalte</summary>

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

Wir stellen kompilierte CSS- und JS-Dateien (`bootstrap.*`) sowie kompilierte und minimierte CSS- und JS-Dateien (`bootstrap.min.*`) bereit. [Source Maps](https://web.dev/articles/source-maps) (`bootstrap.*.map`) sind für die Verwendung mit den Entwicklertools bestimmter Browser verfügbar. Gebündelte JS-Dateien (`bootstrap.bundle.js` und das minimierte `bootstrap.bundle.min.js`) enthalten [Popper](https://popper.js.org/docs/v2/).


## Fehler und Feature-Anfragen

Haben Sie einen Fehler oder eine Feature-Anfrage? Bitte lesen Sie zunächst die [Richtlinien für Issues](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) und suchen Sie nach bestehenden und geschlossenen Issues. Falls Ihr Problem oder Ihre Idee noch nicht behandelt wurde, [öffnen Sie bitte ein neues Issue](https://github.com/twbs/bootstrap/issues/new/choose).


## Dokumentation

Die Bootstrap-Dokumentation, die in diesem Repo im Root-Verzeichnis enthalten ist, wird mit [Astro](https://astro.build/) erstellt und öffentlich auf GitHub Pages unter <https://getbootstrap.com/> gehostet. Die Dokumentation kann auch lokal ausgeführt werden.

Die Dokumentationssuche wird von [Algolias DocSearch](https://docsearch.algolia.com/) unterstützt.

### Dokumentation lokal ausführen

1. Führen Sie `npm install` aus, um die Node.js-Abhängigkeiten, einschließlich Astro (dem Site-Builder), zu installieren.
2. Führen Sie `npm run test` (oder ein spezifisches npm-Script) aus, um die verteilten CSS- und JavaScript-Dateien sowie unsere Dokumentations-Assets neu zu erstellen.
3. Vom Root-Verzeichnis `/bootstrap` aus führen Sie `npm run docs-serve` in der Kommandozeile aus.
4. Öffnen Sie `http://localhost:9001/` in Ihrem Browser – und voilà.

Erfahren Sie mehr über die Verwendung von Astro, indem Sie die [Dokumentation](https://docs.astro.build/en/getting-started/) lesen.

### Dokumentation für vorherige Releases

Sie finden die Dokumentation zu allen bisherigen Releases unter <https://getbootstrap.com/docs/versions/>.

[Frühere Releases](https://github.com/twbs/bootstrap/releases) und deren Dokumentation stehen ebenfalls zum Download bereit.


## Mitwirken

Bitte lesen Sie unsere [Mitwirkungsrichtlinien](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md) sorgfältig durch. Sie enthalten Anweisungen zum Erstellen von Issues, zu Programmierstandards und Hinweise zur Entwicklung.

Wenn Ihr Pull Request JavaScript-Patches oder -Features enthält, müssen [relevante Unit-Tests](https://github.com/twbs/bootstrap/tree/main/js/tests) beigefügt werden. Sämtliches HTML und CSS sollte dem [Code Guide](https://github.com/mdo/code-guide) entsprechen, der von [Mark Otto](https://github.com/mdo) gepflegt wird.

Editor-Einstellungen sind in der [Editor Config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) verfügbar, um die Nutzung in gängigen Texteditoren zu erleichtern. Weitere Informationen und Plugins finden Sie unter <https://editorconfig.org/>.


## Community

Bleiben Sie auf dem Laufenden über die Entwicklung von Bootstrap und chatten Sie mit den Projektbetreuern und anderen Community-Mitgliedern.

- Folgen Sie [@getbootstrap auf X](https://x.com/getbootstrap).
- Lesen und abonnieren Sie [den offiziellen Bootstrap Blog](https://blog.getbootstrap.com/).
- Stellen Sie Fragen und diskutieren Sie in [unseren GitHub Discussions](https://github.com/twbs/bootstrap/discussions).
- Diskutieren Sie, stellen Sie Fragen und mehr auf [dem Community-Discord](https://discord.gg/bZUvakRU3M) oder im [Bootstrap-Subreddit](https://www.reddit.com/r/bootstrap/).
- Chatten Sie mit anderen Bootstrap-Anwendern im IRC. Auf dem Server `irc.libera.chat`, im Channel `#bootstrap`.
- Hilfe zur Implementierung finden Sie auf Stack Overflow (mit dem Tag [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Entwickler sollten das Stichwort `bootstrap` für Pakete verwenden, die Funktionalitäten von Bootstrap erweitern oder ändern, wenn sie diese über [npm](https://www.npmjs.com/browse/keyword/bootstrap) oder ähnliche Mechanismen bereitstellen, um maximale Auffindbarkeit zu gewährleisten.


## Versionierung

Zur Transparenz unseres Release-Zyklus und um die Rückwärtskompatibilität zu wahren, wird Bootstrap gemäß den [Semantic Versioning Richtlinien](https://semver.org/) gepflegt. Manchmal machen wir Fehler, aber wir halten uns so gut wie möglich an diese Regeln.

Im [Releases-Bereich unseres GitHub-Projekts](https://github.com/twbs/bootstrap/releases) finden Sie Changelogs zu jeder Bootstrap-Version. Veröffentlichungsankündigungen im [offiziellen Bootstrap Blog](https://blog.getbootstrap.com/) enthalten Zusammenfassungen der wichtigsten Änderungen jeder Version.


## Urheber

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Dank

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Vielen Dank an [BrowserStack](https://www.browserstack.com/) für die Bereitstellung der Infrastruktur, die es uns ermöglicht, in echten Browsern zu testen!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Vielen Dank an [Netlify](https://www.netlify.com/) für die Bereitstellung von Deploy-Previews!


## Sponsoren

Unterstützen Sie dieses Projekt, indem Sie Sponsor werden. Ihr Logo wird hier mit einem Link zu Ihrer Website angezeigt. [[Sponsor werden](https://opencollective.com/bootstrap#sponsor)]

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


## Unterstützer

Vielen Dank an alle unsere Unterstützer! 🙏 [[Unterstützer werden](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Urheberrecht und Lizenz

Code und Dokumentation Copyright 2011–2025 die [Bootstrap-Autoren](https://github.com/twbs/bootstrap/graphs/contributors). Der Code wird unter der [MIT-Lizenz](https://github.com/twbs/bootstrap/blob/main/LICENSE) veröffentlicht. Die Dokumentation steht unter [Creative Commons](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---