# TypeScript 7

[Sie sind sich nicht sicher, worum es geht? Lesen Sie den Ankündigungsbeitrag!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Vorschau

Ein Vorschau-Build ist auf npm als `@typescript/native-preview` verfügbar.

```sh
npm install @typescript/native-preview
npx tsgo # Verwenden Sie dies wie tsc.
```

Eine Vorschau-Erweiterung für VS Code ist [im VS Code Marketplace verfügbar](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Um dies zu nutzen, fügen Sie Folgendes in Ihre VS Code-Einstellungen ein:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Wie man baut und ausführt

Dieses Repository verwendet [Go 1.24 oder höher](https://go.dev/dl/), [Rust 1.85 oder höher](https://www.rust-lang.org/tools/install), [Node.js mit npm](https://nodejs.org/) und [`hereby`](https://www.npmjs.com/package/hereby).

Für Tests und Codegenerierung enthält dieses Repository ein Git-Submodul zum Haupt-TypeScript-Repository, das auf den zu portierenden Commit verweist.
Beim Klonen sollten Sie mit Submodulen klonen:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Wenn Sie das Repository bereits geklont haben, können Sie das Submodul initialisieren mit:

```sh
git submodule update --init --recursive
```

Mit vorhandenem Submodul und `npm ci` können Sie Aufgaben über `hereby` ausführen, ähnlich wie im TypeScript-Repository:

```sh
hereby build          # Überprüfen, ob das Projekt gebaut wird
hereby test           # Alle Tests ausführen
hereby install-tools  # Zusätzliche Tools wie Linter installieren
hereby lint           # Alle Linter ausführen
hereby format         # Gesamten Code formatieren
hereby generate       # Gesamten Go-Code generieren (z.B. Diagnostik, committet ins Repository)
```

Zusätzliche Aufgaben sind in Arbeit.

`hereby` ist nicht erforderlich, um an dem Repository zu arbeiten; die regulären `go`-Tools (z.B. `go build`, `go test ./...`) funktionieren wie erwartet.
`hereby`-Aufgaben werden als Komfort für diejenigen bereitgestellt, die mit dem TypeScript-Repository vertraut sind.

### Ausführen von `tsgo`

Nach dem Ausführen von `hereby build` können Sie `built/local/tsgo` ausführen, das sich größtenteils wie `tsc` verhält.

### Ausführen des LSP-Prototyps

Um die VS Code-Erweiterung zu debuggen und auszuführen, ohne sie global zu installieren:

* Starten Sie VS Code im Repository-Arbeitsbereich (`code .`)
* Kopieren Sie `.vscode/launch.template.json` nach `.vscode/launch.json`
* <kbd>F5</kbd> (oder `Debug: Start Debugging` aus der Befehlspalette)

Dadurch wird eine neue VS Code-Instanz gestartet, die Corsa LS als Backend verwendet. Wenn alles korrekt eingerichtet ist, sollten Sie "tsgo" in der Statusleiste sehen, wenn eine TypeScript- oder JavaScript-Datei geöffnet ist:

![LSP Prototype Screenshot](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)

## Was funktioniert bisher?

Dies ist noch in Arbeit und hat noch keine vollständige Funktionsparität mit TypeScript. Es können Fehler auftreten. Bitte prüfen Sie diese Liste sorgfältig, bevor Sie ein neues Problem melden oder eine absichtliche Änderung annehmen.

| Funktion | Status | Hinweise |
|----------|--------|----------|
| Programmerstellung | fertig | Gleiche Dateien- und Modulauflösung wie TS5.8. Noch nicht alle Auflösungsmodi unterstützt. |
| Parsen/Scannen | fertig | Genau dieselben Syntaxfehler wie TS5.8 |
| Kommandozeile und `tsconfig.json`-Parsing | weitgehend fertig | Einstiegspunkt derzeit leicht abweichend |
| Typauflösung | fertig | Gleiche Typen wie TS5.8 |
| Typprüfung | fertig | Gleiche Fehler, Positionen und Meldungen wie TS5.8. Typausgabe in Fehlern kann sich unterscheiden (in Arbeit) |
| JavaScript-spezifische Inferenz und JS Doc | nicht bereit | - |
| JSX | fertig | - |
| Deklarationsausgabe | in Arbeit | Die gängigsten Features sind enthalten, aber einige Randfälle und Feature-Flags werden noch nicht behandelt |
| Ausgabe (JS Output) | in Arbeit | `target: esnext` gut unterstützt, andere Targets könnten Lücken aufweisen |
| Überwachungsmodus | Prototyp | Überwacht Dateien und baut neu, aber kein inkrementelles Rechecking |
| Build-Modus / Projekt-Referenzen | nicht bereit | - |
| Inkrementeller Build | nicht bereit | - |
| Sprachdienst (LSP) | Prototyp | Minimale Funktionalität (Fehler, Hover, Gehe zu Definition). Weitere Features folgen bald |
| API | nicht bereit | - |

Definitionen:

 * **fertig** bzw. "vermutlich fertig": Uns sind derzeit keine Defizite oder größeren offenen Punkte bekannt. Fehler dürfen gemeldet werden
 * **in Arbeit**: wird aktuell bearbeitet; einige Features können funktionieren, andere nicht. Nur Panics melden, sonst bitte nichts
 * **Prototyp**: Nur Proof-of-Concept; bitte keine Fehler melden
 * **nicht bereit**: entweder noch nicht begonnen oder so weit von bereit entfernt, dass Sie sich noch nicht damit beschäftigen sollten

## Sonstige Hinweise

Langfristig erwarten wir, dass dieses Repository und sein Inhalt in `microsoft/TypeScript` zusammengeführt werden.
Daher werden das Repository und der Issue-Tracker für typescript-go schließlich geschlossen, behandeln Sie Diskussionen/Issues entsprechend.

Eine Liste der beabsichtigten Änderungen gegenüber TypeScript 5.7 finden Sie in CHANGES.md.

## Beitrag leisten

Dieses Projekt begrüßt Beiträge und Vorschläge. Die meisten Beiträge erfordern, dass Sie einer
Contributor License Agreement (CLA) zustimmen, die erklärt, dass Sie das Recht haben und uns tatsächlich die Rechte einräumen,
Ihren Beitrag zu verwenden. Details finden Sie unter [Contributor License Agreements](https://cla.opensource.microsoft.com).

Wenn Sie einen Pull Request einreichen, ermittelt ein CLA-Bot automatisch, ob Sie eine CLA bereitstellen müssen,
und kennzeichnet den PR entsprechend (z.B. Statusprüfung, Kommentar). Folgen Sie einfach den Anweisungen
des Bots. Sie müssen dies nur einmal für alle Repos tun, die unsere CLA verwenden.

Dieses Projekt hat den [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) übernommen.
Weitere Informationen finden Sie in den [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) oder
kontaktieren Sie [opencode@microsoft.com](mailto:opencode@microsoft.com) bei weiteren Fragen oder Kommentaren.

## Marken

Dieses Projekt kann Marken oder Logos für Projekte, Produkte oder Dienstleistungen enthalten. Die autorisierte Verwendung von Microsoft-
Marken oder Logos unterliegt den [Microsoft Trademark & Brand Guidelines](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general)
und muss diesen folgen. Die Nutzung von Microsoft-Marken oder -Logos in modifizierten Versionen dieses Projekts darf nicht zur Verwirrung führen oder eine Microsoft-Patenschaft implizieren.
Die Nutzung von Marken oder Logos Dritter unterliegt den jeweiligen Richtlinien dieser Dritten.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---