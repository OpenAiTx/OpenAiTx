
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Eine Rust-Anwendung, die Container-Images (Docker, etc.) in Git-Repositories umwandelt. Jede Container-Schicht wird als Git-Commit dargestellt, wodurch die Historie und Struktur des ursprünglichen Images erhalten bleiben.

![Demo von OCI2Git bei der Umwandlung des nginx-Images](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Funktionen

- Analysiere Docker-Images und extrahiere Layer-Informationen
- Erstelle ein Git-Repository, in dem jede Image-Schicht als Commit dargestellt wird
- Unterstützung für leere Layer (ENV, WORKDIR, usw.) als leere Commits
- Vollständige Metadatenextraktion im Markdown-Format
- Erweiterbare Architektur zur Unterstützung verschiedener Container-Engines

## Anwendungsfälle

### Layer-Vergleich
Beim Troubleshooting von Container-Problemen kannst du die leistungsfähigen Vergleichsfunktionen von Git nutzen, um genau zu identifizieren, was sich zwischen zwei Layern geändert hat. Durch das Ausführen von `git diff` zwischen Commits können Ingenieure genau sehen, welche Dateien hinzugefügt, geändert oder gelöscht wurden, was das Verständnis der Auswirkungen jeder Dockerfile-Anweisung erleichtert und problematische Änderungen schneller auffindbar macht.
![Beispiel für Layer-Vergleich](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Herkunftsnachverfolgung
Mit `git blame` können Entwickler schnell feststellen, welche Schicht eine bestimmte Datei oder Codezeile eingeführt hat. Das ist besonders wertvoll bei der Diagnose von Problemen mit Konfigurationsdateien oder Abhängigkeiten. Anstatt jede Schicht manuell zu inspizieren, kannst du sofort die Herkunft einer Datei bis zur Ursprungs-Schicht und der entsprechenden Dockerfile-Anweisung zurückverfolgen.

### Nachverfolgung des Datei-Lebenszyklus
OCI2Git ermöglicht es dir, die Entwicklung einer bestimmten Datei über die gesamte Historie des Container-Images hinweg zu verfolgen. Du kannst sehen, wann eine Datei erstmals erstellt wurde, wie sie in den einzelnen Layern verändert wurde und ob/wann sie schließlich entfernt wurde. Dieser umfassende Überblick hilft, die Entwicklung von Dateien zu verstehen, ohne Änderungen manuell über potenziell dutzende Layer nachverfolgen zu müssen.

Um die Historie einer Datei in deinem Container-Image zu verfolgen – einschließlich ihres ersten Auftretens, ihrer Änderungen oder Löschungen – kannst du nach der Konvertierung diese Git-Befehle verwenden:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

Diese Befehle machen es einfach, die vollständige Historie einer Datei über Container-Ebenen hinweg nachzuverfolgen, ohne die Komplexität des manuellen Extrahierens und Vergleichens von Layer-Tarballs.

### Analyse über mehrere Ebenen
Manchmal sind die aufschlussreichsten Vergleiche diejenigen, die Veränderungen über mehrere nicht aufeinanderfolgende Ebenen hinweg betrachten. Mit OCI2Git können Sie die Vergleichswerkzeuge von Git nutzen, um zu analysieren, wie sich Komponenten über mehrere Build-Stufen entwickelt haben und Muster zu erkennen, die beim Betrachten nur benachbarter Ebenen unsichtbar bleiben könnten.

### Ebenen-Erkundung
Durch die Verwendung von `git checkout`, um zu einem bestimmten Commit zu wechseln, können Sie das Container-Dateisystem genau so untersuchen, wie es in dieser Ebene existierte. Dies ermöglicht Entwicklern, den exakten Zustand von Dateien und Verzeichnissen zu jedem Zeitpunkt im Erstellungsprozess des Images zu inspizieren und liefert wertvolle Kontextinformationen beim Debuggen oder Untersuchen des Containerverhaltens.
![Checkout zu vorherigem Commit](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Analyse mehrerer Images

Wenn mit mehreren Container-Images gearbeitet wird, die eine gemeinsame Abstammung haben, erstellt OCI2Git intelligent nur dann Branches, wenn die Images tatsächlich auseinanderlaufen. So können Sie mehrere verwandte Images in einem einzigen Repository analysieren und dabei deren gemeinsame Historie bewahren.

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```

OCI2Git erkennt automatisch gemeinsam genutzte Layer zwischen Images und erstellt eine Verzweigungsstruktur, die deren gemeinsamen Ursprung widerspiegelt. Die Git-Historie zeigt:
- Einen gemeinsamen Stamm, der alle geteilten Layer enthält
- Separate Zweige, die sich nur dann unterscheiden, wenn die Images tatsächlich abweichen
- Eine klare Visualisierung, wo Images gemeinsame Vorfahren haben und wo sie einzigartig werden
- Intelligente Duplikaterkennung: Wird dasselbe Image zweimal verarbeitet, erkennt der Algorithmus dies vor dem finalen Metadaten-Commit und überspringt das Erstellen eines doppelten Zweigs

Dieser Ansatz ist besonders wertvoll für:
- **Analyse von Bildfamilien**: Verstehen, wie verschiedene Varianten eines Images (unterschiedliche Versionen, Architekturen oder Konfigurationen) miteinander verwandt sind
- **Auswirkungen von Basis-Images**: Genau sehen, wie Änderungen am Basis-Image mehrere abgeleitete Images beeinflussen
- **Optimierungsmöglichkeiten**: Gemeinsame Komponenten identifizieren, die besser über Varianten hinweg genutzt werden könnten

![Multi-Image-Repository-Struktur mit gemeinsamem Basis und sich verzweigenden Branches](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Weitere Anwendungsfälle

- **Sicherheitsaudits**: Exakt nachvollziehen, wann verwundbare Pakete oder Konfigurationen eingeführt wurden und diese auf bestimmte Build-Anweisungen zurückführen.
- **Image-Optimierung**: Layer-Strukturen analysieren, um redundante Operationen oder große Dateien zu finden, die konsolidiert werden könnten, um die Image-Größe zu reduzieren.
- **Abhängigkeitsmanagement**: Überwachen, wann Abhängigkeiten hinzugefügt, aktualisiert oder entfernt wurden, und zwar über die gesamte Image-Historie hinweg.
- **Verbesserung des Build-Prozesses**: Layer-Zusammensetzung untersuchen, um Dockerfile-Anweisungen für besseres Caching und kleinere Images zu optimieren.
- **Vergleich zwischen Images**: Mehrere verwandte Images in Git-Repositories umwandeln und die Vergleichswerkzeuge von Git nutzen, um Unterschiede und Gemeinsamkeiten zu analysieren.

## Installation

### Aus dem Quellcode

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Von Crates.io

```bash
cargo install oci2git
```

## Verwendung

```bash
oci2git [OPTIONS] <IMAGE>
```

Argumente:
  `<IMAGE>`  Name des zu konvertierenden Images (z. B. 'ubuntu:latest') oder Pfad zur Tarball-Datei bei Verwendung der Tar-Engine

Optionen:
  `-o, --output <o>`  Ausgabeverzeichnis für das Git-Repository [Standard: ./container_repo]
  `-e, --engine <ENGINE>`  Zu verwendende Container-Engine (docker, nerdctl, tar) [Standard: docker]
  `-h, --help`             Hilfeinformationen anzeigen
  `-V, --version`          Versionsinformationen anzeigen

Umgebungsvariablen:
  `TMPDIR`  Setzen Sie diese Umgebungsvariable, um den Standardort für die Verarbeitung von Zwischendaten zu ändern. Dies ist plattformabhängig (z. B. `TMPDIR` unter Unix/macOS, `TEMP` oder `TMP` unter Windows).

## Beispiele

Verwendung der Docker-Engine (Standard):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```
Verwendung eines bereits heruntergeladenen Image-Tarballs:

```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Die Tar-Engine erwartet ein gültiges OCI-Format-Tarball, das typischerweise mit `docker save` erstellt wird:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Dadurch wird ein Git-Repository in `./ubuntu-repo` erstellt, das Folgendes enthält:
- `Image.md` - Vollständige Metadaten über das Image im Markdown-Format
- `rootfs/` - Den Dateisysteminhalt aus dem Container

Die Git-Historie spiegelt die Layer-Historie des Containers wider:
- Der erste Commit enthält nur die Datei `Image.md` mit vollständigen Metadaten
- Jeder nachfolgende Commit repräsentiert einen Layer aus dem Original-Image
- Commits enthalten den Dockerfile-Befehl als Commit-Nachricht

## Repository-Struktur

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
  
## Anforderungen

- Rust Edition 2021
- Docker CLI (für Docker-Engine-Unterstützung)
- Git

## Lizenz

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---