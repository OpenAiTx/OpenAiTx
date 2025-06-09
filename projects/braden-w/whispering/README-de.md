<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Nahtlose Diktierung, ermöglicht durch das Whisper-Modell von OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## Über

Whispering ist eine Open-Source-Transkriptionsanwendung, die globale Sprach-zu-Text-Funktionalität bietet, mit Optionen wie Tastenkombinationen und automatischem Kopieren und Einfügen, um das Diktieren so nahtlos wie möglich zu gestalten.

Im Hintergrund wird das OpenAI-Whisper-Modell verwendet, was die Genauigkeit im Vergleich zu integrierten Diktierfunktionen deutlich erhöht.

> **Wichtiger Hinweis**: Whispering ist in erster Linie als Transkriptionstool konzipiert, nicht als Aufnahme-Tool. Für längere Aufnahmen, bei denen Zuverlässigkeit entscheidend ist, empfehle ich, eine dedizierte Aufnahme-App auf Ihrem Smartphone oder Gerät zu verwenden, die native Aufnahme-APIs nutzt. Dies gewährleistet optimale Audioqualität und Aufnahme-Stabilität.

## Demos

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Hauptfunktionen

1. **Globale Transkription**: Greifen Sie überall per globaler Tastenkombination oder mit zwei Klicks auf die Sprach-zu-Text-Funktionalität von Whisper zu.
2. **Plattformübergreifende Erfahrung**:
   - Desktop-App: Ermöglicht globale Transkription über alle Anwendungen hinweg.
   - Browser-Erweiterung: Bietet globale Transkription im Browser durch Kommunikation mit der Web-App.
3. **Chat-Integration**: Die Browser-Erweiterung fügt ChatGPT- und Claude-Webseiten eine Aufnahmetaste hinzu, sodass direkte Spracheingabe und Transkription in der Chatoberfläche möglich sind.
4. **Transkriptionsverwaltung**: Überprüfen und bearbeiten Sie Transkripte innerhalb der Whispering-App, um Genauigkeit und Klarheit sicherzustellen.
5. **Automatische Zwischenablage-Integration**: Nach der Transkription wird der Text automatisch in Ihre Zwischenablage kopiert. Eine Option zum automatischen Einfügen ist ebenfalls verfügbar.

## Wie werden meine Daten gespeichert?

Whispering speichert so viele Daten wie möglich lokal auf Ihrem Gerät, einschließlich Aufnahmen und Texttranskripten. Dieser Ansatz gewährleistet maximale Privatsphäre und Datensicherheit. Hier ist ein Überblick darüber, wie Ihre Daten verarbeitet werden:

1. **Lokale Speicherung**: Sprachaufnahmen und Transkripte werden in IndexedDB gespeichert, das als Blob-Speicher und zur Ablage aller Ihrer Daten wie Texte und Transkripte dient.

2. **Transkriptionsdienst**: Die einzigen Daten, die extern übermittelt werden, sind Ihre Aufnahmen an einen externen Transkriptionsdienst – sofern Sie einen solchen auswählen. Sie haben folgende Optionen:
   - Externe Dienste wie OpenAI oder Groq
   - Ein lokaler Transkriptionsdienst wie `faster-whisper-server`, der alles auf dem Gerät belässt

3. **Konfigurierbare Einstellungen**: Sie können den Transkriptionsdienst in den Einstellungen ändern, um maximale lokale Funktionalität sicherzustellen.

## Installation

### Web-App

Besuchen Sie [whispering.bradenwong.com](https://whispering.bradenwong.com/), wo die neueste Version des `apps/app`-Ordners auf Vercel gehostet wird.

### Chrome-Erweiterung

Installieren Sie die Chrome-Erweiterung aus dem Chrome Web Store [hier](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Desktop-App

Um die Whispering Desktop-App herunterzuladen und zu installieren, folgen Sie den Schritten für Ihr Betriebssystem:

#### Windows

1. Laden Sie das Installationspaket mit der Endung `.msi` von der [Seite mit den neuesten Releases](https://github.com/braden-w/whispering/releases) herunter.
2. Öffnen Sie die heruntergeladene `.msi`-Datei, um das Installationsprogramm zu starten.
3. Falls als unsicher gemeldet, klicken Sie auf `Weitere Informationen` -> `Trotzdem ausführen`, um mit der Installation fortzufahren.
4. Folgen Sie den Anweisungen auf dem Bildschirm, um die Installation abzuschließen.

#### macOS

Für macOS gehen Sie wie folgt vor, um Whispering zu installieren:

1. **Installationspaket herunterladen**:
   - Besuchen Sie die [Seite mit den neuesten Releases](https://github.com/braden-w/whispering/releases).
   - Wählen Sie das passende Paket:
     - Für Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Für Intel: `Whispering_x.x.x_x64.dmg`

2. **Anwendung installieren**:
   - Öffnen Sie die heruntergeladene `.dmg`-Datei.
   - Ziehen Sie die Whispering-App in den Ordner „Programme“.

3. **Whispering starten**:
   - Öffnen Sie Whispering aus dem Programme-Ordner.
   - Wenn Sie eine Warnung über einen nicht verifizierten Entwickler sehen:
     - Klicken Sie auf `Abbrechen`
     - Klicken Sie mit der rechten Maustaste auf die App im Finder und wählen Sie `Öffnen`

4. **Fehlerbehebung** (nur Apple Silicon):
   Falls die Fehlermeldung `"Whispering" ist beschädigt und kann nicht geöffnet werden` erscheint:
   - Öffnen Sie das Terminal
   - Führen Sie folgenden Befehl aus:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Versuchen Sie, die Anwendung erneut zu öffnen

Nach Abschluss dieser Schritte sollte Whispering auf Ihrem macOS-System einsatzbereit sein.

#### Linux

Für Linux stehen mehrere Installationsoptionen zur Verfügung. Wählen Sie die, die am besten zu Ihrer Umgebung passt:

1. **AppImage**:

   - Laden Sie die `.AppImage`-Datei von der [Seite mit den neuesten Releases](https://github.com/braden-w/whispering/releases) herunter.
   - Machen Sie die Datei ausführbar:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Führen Sie die AppImage aus:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEB-Paket (Debian/Ubuntu)**:
   - Laden Sie die `.deb`-Datei von der [Seite mit den neuesten Releases](https://github.com/braden-w/whispering/releases) herunter.
   - Installieren Sie das Paket mit `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Beheben Sie eventuelle Abhängigkeitsprobleme:
     ```bash
     sudo apt-get install -f
     ```

Nach der Installation ist die App einsatzbereit.

## Verwendung

### Chrome-Erweiterung

Nach der Installation der Chrome-Erweiterung finden Sie ein Whispering-Symbol in der Chrome-Erweiterungsleiste. Klicken Sie auf dieses Symbol, um die Erweiterung zu öffnen. Klicken Sie auf die Mikrofontaste, um Ihre Stimme aufzunehmen, und dann auf die quadratische Taste, wenn Sie fertig sind. Ihre Transkription erscheint im Textfeld darunter.

Um die ChatGPT- oder Claude-Funktion zu nutzen, navigieren Sie zur ChatGPT- oder Claude-Webseite. Sie sehen eine neue Aufnahmetaste in der Chatoberfläche. Klicken Sie auf diese Taste, um die Aufnahme zu starten und zu beenden; der transkribierte Text wird automatisch in das Chat-Eingabefeld eingefügt.

Um die Shortcut-Funktion zu nutzen, drücken Sie <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> oder <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (später konfigurierbar über die Chrome-Erweiterungs-Shortcuts), um die Aufnahme von jeder beliebigen Webseite aus zu starten. Die Transkription wird automatisch in Ihre Zwischenablage kopiert und in das aktuelle Eingabefeld eingefügt.

Die Chrome-Erweiterung kommuniziert mit [whispering.bradenwong.com](https://whispering.bradenwong.com) und versucht automatisch, im Hintergrund einen Tab zu erstellen, falls keiner gefunden wird. Die meisten Fehler sind auf Kommunikationsprobleme zurückzuführen, z. B. seltene Fälle, in denen der Tab in den Ruhezustand versetzt wird.

### Web-App

Die Web-App ist unter [whispering.bradenwong.com](https://whispering.bradenwong.com) erreichbar. Klicken Sie auf die Mikrofontaste, um Ihre Stimme aufzunehmen, und dann auf die quadratische Taste, wenn Sie fertig sind. Ihre Transkription erscheint im Textfeld.

### Desktop-App

Nach der Installation der Whispering Desktop-App drücken Sie <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (konfigurierbar in den Einstellungen), um von überall auf Ihrem Desktop die Aufnahme zu starten. Die Transkription wird automatisch in Ihre Zwischenablage kopiert und eingefügt, wobei beide Funktionen in den Einstellungen umschaltbar sind.

## Verwendete Technologien

#### Web und Desktop

Die Whispering-App wurde unter Verwendung folgender Technologien und Bibliotheken entwickelt:

- [Svelte 5](https://svelte.dev): Die bevorzugte UI-Reaktivitätsbibliothek.
- [SvelteKit](https://kit.svelte.dev/docs): Für Routing und statische Seitengenerierung, wird sowohl für die Website als auch für das statische Frontend der Tauri-App verwendet.
- [Tauri](https://tauri.studio/en/docs/intro/): Das Framework für die Desktop-App.
- [Effect-TS](https://github.com/Effect-TS/effect): Um etwas funktionale Programmierung einzubringen und extrem typsichere Funktionen zu schreiben, bei denen Fehler im Rückgabetyp der Funktionssignatur enthalten sind.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Eine einfache, anpassbare Toast-Bibliothek für Svelte-Anwendungen. Wird verwendet, um Fehler, die über Effect-TS nach oben gereicht werden, mit der Funktion `renderAsToast` anzuzeigen.
- [TanStack Table](https://tanstack.com/table): Für alle Datentabellen.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): Eine Low-Level-API zum Speichern großer Mengen strukturierter Daten im Browser. Synchronisiert mit Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): Die bevorzugte UI-Komponentenbibliothek.
- [TailwindCSS](https://tailwindcss.com/docs): Ein Utility-First-CSS-Framework für den schnellen Aufbau individueller Benutzeroberflächen.
- [Turborepo](https://turborepo.org/): Für Monorepo-Management, damit `apps/app` und `apps/extension` denselben Code nutzen können, was Code-Duplikate drastisch reduziert und vor allem eine zentrale Quelle der Wahrheit bietet.
- [Rust](https://www.rust-lang.org): Zur Erweiterung der Desktop-App-Funktionen, z. B. durch Nutzung des `enigo`-Crates für das automatische Einfügen.
- [Vercel](https://vercel.com/): Hosting, das für Hobbyprojekte geeignet ist und gute Turborepo-Integrationen bietet.
- [Zapsplat.com](https://www.zapsplat.com/): Eine lizenzfreie Soundeffekt-Bibliothek.

#### Erweiterung

Die Whispering Chrome-Erweiterung wurde entwickelt mit:

- [Plasmo](https://docs.plasmo.com/): Ein Framework zum Entwickeln von Chrome-Erweiterungen. Wir nutzen den [Relay-Flow](https://docs.plasmo.com/framework/messaging#relay-flow) zur Kommunikation mit der Whispering-Website.
- [Effect-TS](https://github.com/Effect-TS/effect): Um etwas funktionale Programmierung einzubringen und extrem typsichere Funktionen zu schreiben, bei denen Fehler im Rückgabetyp der Funktionssignatur enthalten sind.
- [React](https://reactjs.org): Die UI-Reaktivitätsbibliothek für die Chrome-Erweiterung, da Plasmo leider Svelte 5 nicht unterstützt.
- [ShadCN](https://github.com/shadcn): Die UI-Komponentenbibliothek für die Chrome-Erweiterung.
- [TailwindCSS](https://tailwindcss.com/docs): Ein Utility-First-CSS-Framework zum schnellen Erstellen von individuellen Benutzeroberflächen.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): Die Chrome-Erweiterungs-API.
- [Zapsplat.com](https://www.zapsplat.com/): Eine lizenzfreie Soundeffekt-Bibliothek.

## Whispering im lokalen Entwicklungsmodus ausführen

Um das Projekt auf Ihrem lokalen Rechner einzurichten, führen Sie folgende Schritte aus:

1. Klonen Sie das Repository: `git clone https://github.com/braden-w/whispering.git`
2. Wechseln Sie in das Projektverzeichnis: `cd whispering`
3. Installieren Sie die notwendigen Abhängigkeiten: `pnpm i`

Um die Whispering Desktop-App und die Website im Entwicklungsmodus zu starten:

4. Wechseln Sie in das App-Verzeichnis: `cd apps/app`
5. Starten Sie den Entwicklungsserver: `pnpm tauri dev`

Die Desktop-App sollte sich automatisch für die lokale Entwicklung öffnen. Um die Web-App zu entwickeln, öffnen Sie Ihren Browser und navigieren Sie zu `http://localhost:5173`.

Um die Whispering Chrome-Erweiterung im Entwicklungsmodus auszuführen:

4. Wechseln Sie in das Erweiterungsverzeichnis: `cd apps/extension`
5. Starten Sie den Entwicklungsserver: `pnpm dev --target=chrome-mv3`

Um die Chrome-Erweiterung zu entwickeln, laden Sie sie in Chrome, indem Sie zu `chrome://extensions` navigieren, den Entwicklermodus aktivieren und den Ordner `apps/extension/build/{platform}-{manifest-version}-dev` als entpackte Erweiterung laden.

## Erstellen Sie die ausführbare Datei selbst

Wenn Sie Bedenken bezüglich der Vertrauenswürdigkeit der Installer haben oder mehr Kontrolle wünschen, können Sie die ausführbare Datei jederzeit selbst erstellen. Dies erfordert etwas mehr Einrichtung, aber es stellt sicher, dass Sie den erwarteten Code ausführen. Das ist der Vorteil von Open-Source-Software!

### Chrome

1. Wechseln Sie in das Erweiterungsverzeichnis: `cd apps/extension`
2. Installieren Sie die notwendigen Abhängigkeiten: `pnpm i`
3. Führen Sie den Plasmo-Build aus: `pnpm plasmo build --target=chrome-mv3`
4. Das Ergebnis finden Sie unter `apps/extension/build/chrome-mv3-prod`, welches als entpackte Erweiterung in Chrome geladen werden kann.
5. Alternativ können Sie die Erweiterung für den Chrome Web Store bauen: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Wechseln Sie in das Erweiterungsverzeichnis: `cd apps/extension`
2. Installieren Sie die notwendigen Abhängigkeiten: `pnpm i`
3. Führen Sie den Plasmo-Build aus: `pnpm plasmo build --target=firefox-mv3`
4. Das Ergebnis finden Sie unter `apps/extension/build/firefox-mv3-prod`, welches als entpackte Erweiterung in Chrome geladen werden kann.
5. Alternativ können Sie die Erweiterung für den Chrome Web Store bauen: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. Wechseln Sie in das App-Verzeichnis: `cd apps/app`
2. Installieren Sie die notwendigen Abhängigkeiten: `pnpm i`
3. Führen Sie den Tauri-Build aus: `pnpm tauri build`
4. Sie finden die ausführbare Datei im Verzeichnis `apps/app/target/release`.

## Beitrag leisten

Wir freuen uns über Beiträge aus der Community! Wenn Sie zu Whispering beitragen möchten, befolgen Sie bitte diese Schritte:

1. Forken Sie das Repository.
2. Erstellen Sie einen neuen Branch für Ihr Feature oder Ihren Bugfix: `git checkout -b feature/your-feature-name` oder `git checkout -b fix/your-bugfix-name`
3. Nehmen Sie Ihre Änderungen vor und committen Sie diese mit einer aussagekräftigen Nachricht.
4. Pushen Sie Ihren Branch in Ihr geforktes Repository: `git push origin your-branch-name`
5. Erstellen Sie einen Pull Request von Ihrem geforkten Repository zum Original.

Bitte stellen Sie sicher, dass Ihr Code den etablierten Konventionen folgt und gut dokumentiert ist.

## Lizenz

Whispering wird unter der [MIT-Lizenz](https://opensource.org/licenses/MIT) veröffentlicht.

## Sponsoren

Dieses Projekt wird von den folgenden großartigen Personen und Organisationen unterstützt:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Support und Feedback

Wenn Sie auf Probleme stoßen oder Vorschläge zur Verbesserung haben, eröffnen Sie bitte ein Issue im [GitHub-Issues-Tab](https://github.com/braden-w/whispering/issues) oder kontaktieren Sie mich über [whispering@bradenwong.com](mailto:whispering@bradenwong.com). Ihr Feedback ist sehr willkommen!

Danke, dass Sie Whispering nutzen und viel Freude beim Schreiben!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---