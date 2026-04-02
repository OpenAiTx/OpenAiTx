
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
[//]: # ([![Test Status]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Eine Rust-Anwendung, die Container-Images (Docker usw.) in Git-Repositories umwandelt und ein Filesystem Bill of Materials (fsbom) im YAML-Format erstellt. Jede Containerschicht wird als ein Git-Commit abgebildet, wodurch die Historie und Struktur des Original-Images erhalten bleiben.

![Demo von OCI2Git beim Konvertieren des nginx-Images](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Funktionen

- Analysiert Docker-Images und extrahiert Schichtinformationen
- Erstellt ein Git-Repository, in dem jede Imageschicht als Commit dargestellt ist
- Generiert ein YAML-Filesystem Bill of Materials (fsbom) mit Dateiauflistungen pro Schicht
- Unterstützung für leere Schichten (ENV, WORKDIR, usw.) als leere Commits
- Vollständige Metadatenextraktion ins Markdown-Format
- Erweiterbare Architektur zur Unterstützung verschiedener Container-Engines

## Anwendungsfälle

### Layer-Vergleich
Beim Troubleshooting von Containern können Sie die leistungsfähigen Diff-Funktionen von Git nutzen, um genau zu erkennen, was sich zwischen zwei Schichten geändert hat. Mit `git diff` zwischen Commits sehen Ingenieure exakt, welche Dateien hinzugefügt, geändert oder gelöscht wurden. So lassen sich die Auswirkungen jeder Dockerfile-Anweisung und problematische Änderungen leichter nachvollziehen.
![Beispiel für Layer-Vergleich](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Herkunftsnachverfolgung
Mit `git blame` können Entwickler schnell feststellen, welche Schicht eine bestimmte Datei oder Codezeile eingeführt hat. Das ist besonders nützlich bei der Fehlersuche in Konfigurationsdateien oder Abhängigkeiten. Statt jede Schicht einzeln zu untersuchen, lässt sich der Ursprung einer Datei sofort zur entsprechenden Schicht und Dockerfile-Anweisung zurückverfolgen.

### Dateilebenszyklus-Verfolgung
OCI2Git ermöglicht es Ihnen, den Lebenszyklus einer bestimmten Datei im Verlauf des Container-Images zu verfolgen. Sie sehen, wann die Datei erstmals angelegt wurde, wie sie sich über die Schichten hinweg verändert hat und ob bzw. wann sie entfernt wurde. Diese umfassende Sicht hilft, die Entwicklung einer Datei nachzuvollziehen, ohne Änderungen über dutzende Schichten hinweg manuell nachzuverfolgen.

Um die Historie einer Datei im Container-Image zu verfolgen – einschließlich wann sie erstmals erschien, geändert oder gelöscht wurde – können Sie nach der Konvertierung diese Git-Befehle verwenden:

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

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — OCI-Image → Git-Repository

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

Optionen:
  `-o, --output <OUTPUT>`  Ausgabeverzeichnis für Git-Repository [Standard: ./container_repo]
  `-e, --engine <ENGINE>`  Zu verwendende Container-Engine (docker, nerdctl, tar) [Standard: docker]
  `-v, --verbose`          Ausführlicher Modus (-v für Info, -vv für Debug, -vvv für Trace)

### `fsbom` — Dateisystem-Bill of Materials

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```
Optionen:
  `-o, --output <OUTPUT>`  Ausgabepfad für die YAML-BOM-Datei [Standard: ./fsbom.yml]
  `-e, --engine <ENGINE>`  Zu verwendende Container-Engine (docker, nerdctl, tar) [Standard: docker]
  `-v, --verbose`          Ausführlicher Modus (-v für Info, -vv für Debug, -vvv für Trace)

Umgebungsvariablen:
  `TMPDIR`  Setzen Sie diese Umgebungsvariable, um den Standardort für die Verarbeitung von Zwischendaten zu ändern. Dies ist plattformabhängig (z. B. `TMPDIR` unter Unix/macOS, `TEMP` oder `TMP` unter Windows).

## Beispiele

### Konvertieren

Verwendung der Docker-Engine (Standard):

```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```
Verwendung eines bereits heruntergeladenen Image-Tarballs:

```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Die Tar-Engine erwartet ein gültiges OCI-Format-Tarball, das typischerweise mit `docker save` erstellt wird:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Dadurch wird ein Git-Repository in `./ubuntu-repo` erstellt, das Folgendes enthält:
- `Image.md` - Vollständige Metadaten zum Image im Markdown-Format
- `rootfs/` - Den Dateisysteminhalt aus dem Container

Der Git-Verlauf spiegelt die Layer-Historie des Containers wider:
- Der erste Commit enthält nur die Datei `Image.md` mit vollständigen Metadaten
- Jeder weitere Commit repräsentiert eine Ebene aus dem Original-Image
- Commits verwenden den Dockerfile-Befehl als Commit-Nachricht

### Filesystem Bill of Materials (fsbom)

Erstellen Sie eine YAML-Liste mit allen Dateien, die pro Layer hinzugefügt oder geändert wurden:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```

Verwendung eines Tarballs:
```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

Die Ausgabe-YAML listet jede Schicht mit ihren Einträgen, die nach Typ (`file`, `hardlink`, `symlink`, `directory`) und Status (`n:uid:gid` für neu, `m:uid:gid` für geändert) gekennzeichnet sind, auf. Gelöschte Dateien (OCI-Whiteouts) sind ausgeschlossen.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---