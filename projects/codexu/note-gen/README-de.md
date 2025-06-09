![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

Englisch | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Anleitung

NoteGen ist eine plattformübergreifende `Markdown`-Notizapplikation, die es sich zur Aufgabe gemacht hat, mit KI die Brücke zwischen Aufzeichnung und Schreiben zu schlagen und fragmentiertes Wissen in eine lesbare Notiz zu organisieren.

🖥️ Offizielle Dokumentation: [https://notegen.top](https://notegen.top)

💬 Trete der [WeChat/QQ-Gruppe](https://github.com/codexu/note-gen/discussions/110) bei

## Warum NoteGen wählen?

- Leichtgewichtig: [Installationspaket](https://github.com/codexu/note-gen/releases) ist **nur 20MB** groß, kostenlos ohne Werbung oder gebündelte Software.
- Plattformübergreifend: Unterstützt Mac, Windows, Linux und dank `Tauri2`-Plattformfähigkeit in Zukunft auch iOS und Android.
- Unterstützt verschiedene Aufzeichnungsarten wie `Screenshots`, `Text`, `Illustrationen`, `Dateien`, `Links` usw., um fragmentierte Aufzeichnungsbedürfnisse in verschiedensten Szenarien abzudecken.
- Native Speicherung im `Markdown(.md)`-Format, keine Anpassungen, einfach zu migrieren.
- Native Offline-Nutzung, unterstützt Echtzeit-Synchronisierung mit `GitHub, Gitee`-Privatrepositories mit Versionsverlauf und WebDAV-Synchronisierung.
- KI-gestützt: Konfigurierbar mit ChatGPT, Gemini, Ollama, LM Studio, Grok und anderen Modellen, mit Unterstützung für eigene Drittanbieter-Modellkonfiguration.
- RAG: Deine Notizen sind deine Wissensbasis. Unterstützt Embedding-Modelle und Reranking-Modelle.

## Screenshots

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Aufzeichnung:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Schreiben:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Thema:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## Von der Aufzeichnung zum Schreiben

Herkömmliche Notiz-Apps bieten in der Regel keine Aufzeichnungsfunktion. Nutzer müssen Inhalte manuell kopieren und einfügen, was die Effizienz deutlich reduziert. Bei verstreut aufgezeichneten Inhalten ist zudem ein hoher Aufwand für die Organisation notwendig.

NoteGen ist in die Seiten `Aufzeichnung` und `Schreiben` unterteilt, mit folgender Beziehung:

- Aufzeichnungen können zu Notizen organisiert und auf die Schreibseite zur vertieften Ausarbeitung übertragen werden.
- Während des Schreibens kannst du jederzeit Aufzeichnungen einfügen.

### Aufzeichnung

Die Aufzeichnungsfunktion ähnelt einem **KI-Chatbot**, aber beim Dialog kannst du ihn mit zuvor aufgezeichneten Inhalten verknüpfen, vom Gesprächsmodus in den Organisationsmodus wechseln und Aufzeichnungen zu einer lesbaren Notiz strukturieren.

Folgende Zusatzfunktionen helfen dir, effektiver aufzuzeichnen:

- **Tags** zur Unterscheidung verschiedener Aufzeichnungsszenarien.
- **Personas** mit Unterstützung für eigene Prompts zur präzisen Steuerung deines KI-Assistenten.
- **Zwischenablagen-Assistent**, der automatisch Text oder Bilder aus deiner Zwischenablage erkennt und in deine Liste aufnimmt.

### Schreiben

Der Schreibbereich ist in zwei Teile unterteilt: **Dateimanager** und **Markdown-Editor**.

**Dateimanager**

- Unterstützt die Verwaltung lokaler Markdown-Dateien und GitHub-synchronisierter Dateien.
- Unterstützt unbegrenzte Verzeichnistiefen.
- Unterstützt verschiedene Sortiermethoden.

**Markdown-Editor**

- Unterstützt WYSIWYG, Sofort-Rendering und geteilte Bildschirmvorschau.
- Unterstützt Versionskontrolle mit Verlauf und Rücksetzfunktion.
- Unterstützt KI-Unterstützung für Konversation, Fortsetzung, Überarbeitung und Übersetzung.
- Unterstützt Bild-Hosting, das Hochladen von Bildern und das Umwandeln in Markdown-Bildlinks.
- Unterstützt HTML-zu-Markdown-Konvertierung, automatisch kopierte Browser-Inhalte werden in Markdown umgewandelt.
- Unterstützt Gliederungen, mathematische Formeln, Mindmaps, Diagramme, Flussdiagramme, Gantt-Diagramme, Sequenzdiagramme, Notensysteme, Multimedia, Sprachwiedergabe, Titelanker, Code-Hervorhebung und -Kopieren, Graphviz-Rendering und PlantUML-UML-Diagramme.
- Unterstützt Echtzeit-Lokalspeicherung, verzögerte (10s ohne Bearbeitung) automatische Synchronisierung und Verlauf mit Rücksetzfunktion.

## Weitere Funktionen

- Globale Suche für schnelles Auffinden und Springen zu bestimmten Inhalten.
- Bild-Hosting-Management für komfortable Verwaltung des Bildbestands.
- Themes und Darstellung mit Unterstützung für Dunkelmodus und Erscheinungsbild-Einstellungen für Markdown, Code usw.
- Internationalisierung, aktuell verfügbar auf Chinesisch und Englisch.

## Wie benutzt man es?

### Download

Derzeit werden Mac, Windows und Linux unterstützt. Dank Tauri2-Plattformfähigkeit werden in Zukunft auch iOS und Android unterstützt.

[NoteGen herunterladen (alpha)](https://github.com/codexu/note-gen/releases)

### Erweiterung

Die Notiz-App kann direkt ohne Konfiguration genutzt werden. Für ein besseres Erlebnis bitte die Einstellungsseite öffnen und KI und Synchronisierung konfigurieren.

## Mitwirken

- [Beitragshinweise lesen](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Update-Pläne](https://github.com/codexu/note-gen/issues/46)
- [Fehler oder Verbesserungsvorschläge melden](https://github.com/codexu/note-gen/issues)
- [Diskussionen](https://github.com/codexu/note-gen/discussions)

## Mitwirkende

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Stern-Historie

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---