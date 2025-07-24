# Universal Tool Calling Protocol (UTCP) Spezifikation

Dieses Repository enthält die offizielle Spezifikationsdokumentation für das Universal Tool Calling Protocol (UTCP). UTCP ist ein modernes, flexibles und skalierbares Standardprotokoll zur Definition und Interaktion mit Tools über verschiedene Kommunikationsprotokolle hinweg.

## Was ist UTCP?

UTCP bietet einen standardisierten Weg für KI-Systeme und andere Clients, Tools von verschiedenen Anbietern zu entdecken und aufzurufen, unabhängig vom zugrunde liegenden verwendeten Protokoll (HTTP, WebSocket, CLI usw.). Diese Spezifikation definiert:

- Mechanismen zur Tool-Entdeckung
- Formate für Tool-Aufrufe
- Provider-Konfiguration
- Authentifizierungsmethoden
- Antwortverarbeitung

## Beitrag zur Spezifikation

Beiträge zur UTCP-Spezifikation sind willkommen! So können Sie mitwirken:

1. **Forken Sie das Repository**: Erstellen Sie Ihren eigenen Fork des Spezifikations-Repositorys
2. **Nehmen Sie Ihre Änderungen vor**: Aktualisieren oder ergänzen Sie die Dokumentation nach Bedarf
3. **Pull Request einreichen**: Öffnen Sie einen PR mit Ihren Änderungen zur Überprüfung
4. **Beteiligen Sie sich an Diskussionen**: Nehmen Sie an Gesprächen über vorgeschlagene Änderungen teil

Bitte befolgen Sie beim Mitwirken diese Richtlinien:

- Stellen Sie sicher, dass Ihre Änderungen mit der Gesamtvision und den Zielen von UTCP übereinstimmen
- Folgen Sie der etablierten Dokumentationsstruktur und dem Format
- Fügen Sie Beispiele hinzu, wenn Sie neue Funktionen oder Konzepte einführen
- Aktualisieren Sie relevante Abschnitte, um die Konsistenz in der Dokumentation zu wahren

## Dokumentation lokal erstellen

### Voraussetzungen

Um die Dokumentationsseite lokal zu bauen und anzuzeigen, benötigen Sie:

- Ruby Version 2.5.0 oder höher
- RubyGems
- Bundler

### Einrichtung

1. Klonen Sie das Repository:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Abhängigkeiten installieren:

   ```bash
   bundle install
   ```
### Ausführen der Dokumentationsseite

Um die Seite lokal zu erstellen und bereitzustellen:


```bash
bundle exec jekyll serve
```
Dies startet einen lokalen Webserver unter `http://localhost:4000`, auf dem Sie die Dokumentation in der Vorschau anzeigen können.

## Dokumentationsstruktur

Die UTCP-Dokumentation ist wie folgt organisiert:

- `index.md`: Startseite und Einführung in UTCP
- `docs/`
  - `introduction.md`: Detaillierte Einführung und Kernkonzepte
  - `for-tool-providers.md`: Leitfaden für die Implementierung von Tool-Providern
  - `for-tool-callers.md`: Leitfaden für die Implementierung von Tool-Callern
  - `providers/`: Dokumentation für jeden Providertyp
    - `http.md`: HTTP-Provider
    - `websocket.md`: WebSocket-Provider
    - `cli.md`: CLI-Provider
    - `sse.md`: Server-Sent Events-Provider
    - usw.
  - `implementation.md`: Implementierungsrichtlinien und Best Practices

## Arbeiten mit der Spezifikation

### Änderungen an der Dokumentation

Die Dokumentation ist im Markdown-Format mit Jekyll-Front Matter verfasst. Beim Ändern:

1. Stellen Sie sicher, dass Ihr Markdown dem etablierten Stil folgt
2. Prüfen Sie Änderungen lokal in der Vorschau, bevor Sie PRs einreichen
3. Halten Sie Beispiele stets auf dem neuesten Stand der Spezifikation
4. Aktualisieren Sie Navigationseinträge in `_config.yml`, wenn Sie neue Seiten hinzufügen

### Datei-Organisation

Beim Hinzufügen neuer Dokumentation:

- Platzieren Sie provider-spezifische Dokumentation in `docs/providers/`
- Verwenden Sie konsistentes Front Matter mit angemessener Navigationsreihenfolge
- Fügen Sie Tags für eine verbesserte Auffindbarkeit auf GitHub Pages hinzu

## Versionskontrolle

Die UTCP-Spezifikation folgt dem semantischen Versionierungsschema:

- Hauptversionen (1.0, 2.0): Inkompatible Änderungen am Protokoll
- Nebenversionen (1.1, 1.2): Neue, abwärtskompatible Funktionen
- Patch-Versionen (1.0.1, 1.0.2): Abwärtskompatible Fehlerbehebungen und Klarstellungen

## Lizenz

Diese Spezifikation wird unter der Mozilla Public License 2.0 (MPL-2.0) veröffentlicht.

## Weitere Ressourcen

- [UTCP GitHub Organisation](https://github.com/universal-tool-calling-protocol)
- [UTCP Webseite](https://utcp.io)
- [Referenzimplementierungen](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Community-Diskussionen](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---