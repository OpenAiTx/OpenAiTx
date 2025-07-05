# Kelp

Eine UI-Bibliothek für Menschen, die HTML lieben – angetrieben von modernem CSS und Web Components.

**[Dokumentation lesen &rarr;](https://kelpui.com)**

_**Hinweis:** Kelp befindet sich derzeit in der Alpha-Entwicklung. Sie können es gerne benutzen, ausprobieren und Fehler melden, aber bitte beachten Sie, dass sich Dinge im Laufe der Zeit ändern können und werden._



## Schnellstart

Kelp funktioniert ohne jeden Build-Schritt.

[Das CDN](https://cdn.jsdelivr.net/npm/kelpui/) ist der schnellste und einfachste Weg, um loszulegen, aber Sie können [die Dateien auch von GitHub herunterladen](https://github.com/cferdinandi/kelp), wenn Sie das bevorzugen.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp verwendet semantische Versionierung. Sie können eine Haupt-, Neben- oder Patch-Version vom CDN mit der `@1.2.3`-Syntax beziehen. Alle verfügbaren Versionen finden Sie [unter Releases](https://github.com/cferdinandi/kelp/tags).



## Demo

Die mitgelieferte Datei `index.html` ist eine Kitchen-Sink-Demo von Kelp. Sie enthält jede Funktion und Komponente in einer einzigen großen Datei.

Während der Beta-Phase hat Kelp keinen Kompilierungsschritt. Die Web Components verwenden ES-Imports und erfordern einen lokalen Server zum Ausführen.

Verwenden Sie Ihren bevorzugten Server oder nutzen Sie das mitgelieferte `http-server` mit dem Befehl `npm run dev`.

```bash
npm install
npm run dev
```

Wenn Kelp sich der Version v1 nähert, wird ein Kompilierungsschritt eingeführt, damit dies nicht mehr notwendig ist.



## Tests

Kelp verwendet...

- [Playwright](https://playwright.dev) für Tests
- [Biome](https://biomejs.dev) für Linting und Formatierung
- Einen Continuous-Integration-Prozess bei Deployments und PRs

```bash
# Tests ausführen
npm run test

# Linter ausführen
npm run lint
```



## Lizenz

Kostenlos nutzbar unter der [Kelp Commons License](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). Es gibt außerdem [kommerzielle Lizenzoptionen](/license/).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---