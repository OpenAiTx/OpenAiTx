# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Web-orientierter, plattformübergreifender Anwendungsstarter mit React-basierten Plugins

> [!WARNING]
> Der Launcher wird von einem einzelnen Entwickler in seiner Freizeit entwickelt.
> Änderungen können langsam, aber stetig erfolgen.
>
> Es wird wahrscheinlich Breaking Changes geben, die im [Changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md) dokumentiert werden.

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Leicht veraltete Demo

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Funktionen

- Plugin-First
  - Plugins werden in TypeScript geschrieben
  - Umfangreiche Plugin-API 
      - UI-Ansichten erstellen
      - Einmalige Befehle
      - Dynamisch eine Liste von Einmalbefehlen bereitstellen
      - Schnellen "Inline"-Inhalt direkt unter der Hauptsuchleiste basierend auf deren Wert anzeigen
      - Inhalte aus der Zwischenablage abrufen und hinzufügen
  - Plugins werden als separater Branch im Git-Repository verteilt, d. h. die Plugin-Verteilung benötigt keinen zentralen Server
  - Plugin-IDs sind einfach Git-Repository-URLs
  - [React](https://github.com/facebook/react)-basierte UI für Plugins
    - Implementiert mit eigenem React Reconciler (kein Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno ermöglicht das Sandboxing von JavaScript-Plugin-Code für mehr Sicherheit
    - Plugins müssen explizit angeben, welche Berechtigungen sie benötigen
    - Node.js wird für Plugin-Tooling verwendet, aber als Plugin-Entwickler schreiben Sie immer Code, der auf Deno läuft
- Von Anfang an plattformübergreifend konzipiert
- Befehle und Ansichten können über globale benutzerdefinierte Shortcuts ausgeführt/geöffnet werden
- Benutzerdefinierte Suchalias können Befehlen oder Ansichten zugewiesen werden
- Unterstützung für benutzerdefinierte Themes
- Eingebaute Funktionalität wird durch mitgelieferte Plugins bereitgestellt
  - Anwendungen: Zeigt installierte Anwendungen des Systems in den Suchergebnissen an
    - Plugin verfolgt auch Fenster und zugehörige Anwendungen, sodass das Öffnen einer bereits geöffneten Anwendung standardmäßig das zuvor erstellte Fenster anzeigt
      - Nicht alle Systeme werden derzeit unterstützt. Siehe [Feature Support](https://gauntlet.sh/docs/feature-support)
  - Rechner: Zeigt das Ergebnis von mathematischen Operationen direkt unter der Hauptsuchleiste an
    - Einschließlich Währungsumrechnung mit Wechselkursen
    - Betrieben von [Numbat](https://github.com/sharkdp/numbat)
- Frecency-basierte Sortierung der Suchergebnisse
   - Frecency ist eine Kombination aus Häufigkeit und Aktualität
   - Je öfter ein Element verwendet wird, desto höher erscheint es in der Ergebnisliste, aber Elemente, die früher häufig verwendet wurden, werden niedriger eingestuft als solche, die kürzlich oft verwendet wurden
   - Ergebnisse werden wortweise per Substring verglichen

##### Betriebssystem-Unterstützung

##### Offiziell
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Best-effort
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland wird noch nicht unterstützt, siehe [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Erste Schritte

### Gauntlet installieren

Siehe [Installation](https://gauntlet.sh/docs/installation)

### Globaler Shortcut

Das Hauptfenster kann über einen globalen Shortcut oder einen CLI-Befehl geöffnet werden:
- Globaler Shortcut (kann in den Einstellungen geändert werden)
  - Windows: <kbd>ALT</kbd> + <kbd>Leertaste</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Leertaste</kbd>
  - Linux Wayland
    - Globaler Shortcut wird eventuell nicht unterstützt, siehe [Feature Support](https://gauntlet.sh/docs/feature-support)
    - Bitte verwenden Sie stattdessen den CLI-Befehl und rufen Sie ihn mit dem spezifischen Ansatz des Fenstermanagers auf
  - macOS: <kbd>CMD</kbd> + <kbd>Leertaste</kbd>
- CLI-Befehl
  - `gauntlet open`

### Plugin installieren

Plugins werden in der Einstellungen-UI installiert. Verwenden Sie die Git-Repository-URL des Plugins, um es zu installieren, z. B. `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Eigenes Plugin erstellen

Siehe [Einstieg in die Plugin-Entwicklung](https://gauntlet.sh/docs/plugin-development/getting-started)

## Theming

Siehe [Theming](https://gauntlet.sh/docs/theming)

## Gauntlet bauen

Sie benötigen:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (wird nicht direkt vom Projekt verwendet, ist aber für eine Abhängigkeit erforderlich)
- Unter Linux: `libxkbcommon-dev` (Hinweis: Name kann je nach Distribution abweichen)

### Dev

Um die Dev-Version zu bauen, führen Sie aus:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
Im Dev-Modus (ohne "release"-Feature) verwendet die Anwendung ausschließlich Verzeichnisse innerhalb des Projektverzeichnisses, um Status oder Cache zu speichern. So wird eine globale Installation nicht beeinflusst.

### Not-yet-packaged

Um ein nicht-verpacktes Release-Binary zu bauen, führen Sie aus:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Packaged
Um ein betriebssystemspezifisches Paket zu bauen, führen Sie einen der folgenden Befehle aus:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Aber das Release einer neuen Version muss über GitHub Actions erfolgen.

## Mitwirken

Wenn Sie beim Aufbau von Gauntlet helfen möchten, können Sie dies auf vielfältige Weise tun, nicht nur durch Codebeiträge:
- Melden eines Bugs oder UI/UX-Problems
- Erstellen eines Plugins

Für einfache Probleme können Sie gerne ein Issue oder einen PR eröffnen und es selbst angehen. 
Für größere Änderungen kontaktieren Sie bitte die Entwickler über Discord (Einladungslink oben im README) und besprechen Sie es zuerst.

Jeder Beitrag ist willkommen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---