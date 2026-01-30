
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Dokumentation](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Lizenz](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Downloads](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (Mock für zukünftige test.yaml)
[//]: # ([![Teststatus]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Eine Rust-Anwendung, die Container-Images (Docker, etc.) in Git-Repositories umwandelt. Jede Container-Schicht wird als Git-Commit dargestellt, wobei die Historie und Struktur des Original-Images erhalten bleiben.

![Demo von OCI2Git bei der Konvertierung des nginx-Images](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Funktionen

- Analysieren von Docker-Images und Extrahieren von Schichtinformationen
- Erstellen eines Git-Repositories, in dem jede Image-Schicht als Commit dargestellt wird
- Unterstützung für leere Schichten (ENV, WORKDIR, etc.) als leere Commits
- Vollständige Metadatenextraktion im Markdown-Format
- Erweiterbare Architektur zur Unterstützung verschiedener Container-Engines

## Anwendungsfälle

### Layer-Diffing
Beim Troubleshooting von Container-Problemen können Sie mit den leistungsfähigen Diff-Funktionen von Git genau feststellen, was sich zwischen zwei Schichten geändert hat. Durch Ausführen von `git diff` zwischen Commits sehen Entwickler exakt, welche Dateien hinzugefügt, geändert oder gelöscht wurden, was das Verständnis der Auswirkungen jeder Dockerfile-Anweisung erleichtert und problematische Änderungen schnell auffindbar macht.
![Beispiel für Layer-Diff](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Herkunftsnachverfolgung
Mit `git blame` können Entwickler schnell ermitteln, welche Schicht eine bestimmte Datei oder Codezeile eingeführt hat. Dies ist besonders wertvoll bei der Fehlersuche in Konfigurationsdateien oder Abhängigkeiten. Anstatt jede Schicht manuell zu prüfen, können Sie die Herkunft jeder Datei sofort bis zur Ursprungs-Schicht und der zugehörigen Dockerfile-Anweisung zurückverfolgen.

### Lebenszyklus-Verfolgung von Dateien
OCI2Git ermöglicht es, die Entwicklung einer bestimmten Datei über die gesamte Historie eines Container-Images hinweg nachzuverfolgen. Sie sehen, wann eine Datei erstmals erstellt, wie sie über die Schichten hinweg verändert und ob/wann sie schließlich entfernt wurde. Diese umfassende Ansicht hilft, die Entwicklung von Dateien nachzuvollziehen, ohne Änderungen über dutzende Schichten manuell verfolgen zu müssen.

Um die Historie einer Datei in Ihrem Container-Image nachzuverfolgen – einschließlich wann sie erstmals auftrat, geändert oder gelöscht wurde – können Sie nach der Konvertierung diese Git-Befehle verwenden:

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

OCI2Git erkennt automatisch gemeinsam genutzte Layer zwischen Images und erstellt eine Verzweigungsstruktur, die ihre gemeinsame Basis widerspiegelt. Die Git-Historie zeigt:
- Einen gemeinsamen Hauptstrang, der alle geteilten Layer enthält
- Separate Zweige, die sich nur dann unterscheiden, wenn die Images tatsächlich abweichen
- Klare Visualisierung, wo Images gemeinsame Abstammung haben und wo sie einzigartig werden
- Intelligente Duplikaterkennung: Wenn genau dasselbe Image zweimal verarbeitet wird, erkennt der Algorithmus dies vor dem finalen Metadaten-Commit und überspringt das Erstellen eines doppelten Zweigs

Dieser Ansatz ist besonders wertvoll für:
- **Analyse von Image-Familien**: Verstehen, wie verschiedene Varianten eines Images (verschiedene Versionen, Architekturen oder Konfigurationen) miteinander verwandt sind
- **Auswirkungen von Basis-Images**: Exakt sehen, wie Änderungen am Basis-Image mehrere abgeleitete Images beeinflussen
- **Optimierungsmöglichkeiten**: Gemeinsame Komponenten identifizieren, die besser über Image-Varianten hinweg genutzt werden könnten

![Multi-Image-Repository-Struktur mit gemeinsam genutzter Basis und divergierenden Zweigen](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Weitere Anwendungsfälle

- **Sicherheitsaudits**: Exakt feststellen, wann verwundbare Pakete oder Konfigurationen eingeführt wurden und sie auf bestimmte Build-Anweisungen zurückverfolgen.
- **Image-Optimierung**: Layer-Strukturen analysieren, um redundante Operationen oder große Dateien zu finden, die konsolidiert werden könnten, um die Image-Größe zu reduzieren.
- **Abhängigkeitsmanagement**: Überwachen, wann Abhängigkeiten im Verlauf der Image-Historie hinzugefügt, aktualisiert oder entfernt wurden.
- **Verbesserung des Build-Prozesses**: Layer-Zusammensetzung untersuchen, um Dockerfile-Anweisungen für besseres Caching und kleinere Image-Größe zu optimieren.
- **Vergleich zwischen Images**: Mehrere verwandte Images in Git-Repositories konvertieren und Git-Vergleichswerkzeuge verwenden, um Unterschiede und Gemeinsamkeiten zu analysieren.

## Installation

### Paketmanager

#### macOS / Linux (Homebrew)

```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Laden Sie das .deb-Paket von der [neuesten Version](https://github.com/virviil/oci2git/releases/latest) herunter und installieren Sie es:

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Vorgefertigte Binärdateien

Laden Sie die passende Binärdatei für Ihre Plattform aus der [neuesten Veröffentlichung](https://github.com/virviil/oci2git/releases/latest) herunter:

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Von Crates.io

```bash
cargo install oci2git
```

### Aus der Quelle

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
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

- Rust 2021 Edition
- Docker CLI (für Docker-Engine-Unterstützung)
- Git

## Lizenz

MIT

[dokumentation]: https://docs.rs/oci2git/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---