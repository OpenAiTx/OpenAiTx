# Gitleaks

```
┌─○───┐
│ │╲  │
│ │ ○ │
│ ○ ░ │
└─░───┘
```

[license]: https://raw.githubusercontent.com/gitleaks/gitleaks/master/LICENSE
[badge-license]: https://img.shields.io/github/license/gitleaks/gitleaks.svg
[go-docs-badge]: https://pkg.go.dev/badge/github.com/gitleaks/gitleaks/v8?status
[go-docs]: https://pkg.go.dev/github.com/zricethezav/gitleaks/v8
[badge-build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml/badge.svg
[build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml
[go-report-card-badge]: https://goreportcard.com/badge/github.com/gitleaks/gitleaks/v8
[go-report-card]: https://goreportcard.com/report/github.com/gitleaks/gitleaks/v8
[dockerhub]: https://hub.docker.com/r/zricethezav/gitleaks
[dockerhub-badge]: https://img.shields.io/docker/pulls/zricethezav/gitleaks.svg
[gitleaks-action]: https://github.com/gitleaks/gitleaks-action
[gitleaks-badge]: https://img.shields.io/badge/protected%20by-gitleaks-blue
[gitleaks-playground-badge]: https://img.shields.io/badge/gitleaks%20-playground-blue
[gitleaks-playground]: https://gitleaks.io/playground


[![GitHub Action Test][badge-build]][build]
[![Docker Hub][dockerhub-badge]][dockerhub]
[![Gitleaks Playground][gitleaks-playground-badge]][gitleaks-playground]
[![Gitleaks Action][gitleaks-badge]][gitleaks-action]
[![GoDoc][go-docs-badge]][go-docs]
[![GoReportCard][go-report-card-badge]][go-report-card]
[![License][badge-license]][license]


### Tritt unserem Discord bei! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks ist ein Tool zur **Erkennung** von Geheimnissen wie Passwörtern, API-Schlüsseln und Tokens in Git-Repositories, Dateien und allem anderen, was du ihm über `stdin` gibst. Wenn du mehr darüber erfahren möchtest, wie die Erkennungs-Engine funktioniert, schau dir diesen Blog an: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).


```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Fund:        "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Geheimnis:   cafebabe:deadbeef
RuleID:      sidekiq-secret
Entropie:    2.609850
Datei:       cmd/generate/config/rules/sidekiq.go
Zeile:       23
Commit:      cd5226711335c68be1e720b318b7bc3135a30eb2
Autor:       John
E-Mail:      john@users.noreply.github.com
Datum:       2022-08-03T12:31:40Z
Fingerprint: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## Erste Schritte

Gitleaks kann über Homebrew, Docker oder Go installiert werden. Gitleaks ist außerdem als Binärdatei für viele beliebte Plattformen und Betriebssysteme auf der [Releases-Seite](https://github.com/gitleaks/gitleaks/releases) verfügbar. Darüber hinaus kann Gitleaks als Pre-Commit-Hook direkt in deinem Repository oder als GitHub Action über [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action) implementiert werden.

### Installation

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Aus dem Quellcode (stelle sicher, dass `go` installiert ist)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

Sieh dir die offizielle [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action) an

```
name: gitleaks
on: [pull_request, push, workflow_dispatch]
jobs:
  scan:
    name: gitleaks
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
        with:
          fetch-depth: 0
      - uses: gitleaks/gitleaks-action@v2
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # Nur für Organisationen erforderlich, nicht für persönliche Accounts.
```

### Pre-Commit

1. Installiere pre-commit von https://pre-commit.com/#install
2. Erstelle eine `.pre-commit-config.yaml` Datei im Root-Verzeichnis deines Repositories mit folgendem Inhalt:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   für eine [native Ausführung von gitleaks](https://github.com/gitleaks/gitleaks/releases) oder verwende die [`gitleaks-docker` Pre-Commit-ID](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml) für die Ausführung von gitleaks mit den [offiziellen Docker-Images](#docker)

3. Aktualisiere die Konfiguration automatisch auf die neuesten Versionen der Repositories mit `pre-commit autoupdate`
4. Installiere mit `pre-commit install`
5. Jetzt bist du bereit!

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

Hinweis: Um den gitleaks pre-commit hook zu deaktivieren, kannst du dem Commit-Befehl `SKIP=gitleaks` voranstellen,
und gitleaks wird übersprungen

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## Verwendung

```
Verwendung:
  gitleaks [Befehl]

Verfügbare Befehle:
  dir         Verzeichnisse oder Dateien nach Geheimnissen scannen
  git         Git-Repositories nach Geheimnissen scannen
  help        Hilfe zu jedem Befehl
  stdin       Geheimnisse von stdin erkennen
  version     Gitleaks-Version anzeigen

Flags:
  -b, --baseline-path string          Pfad zur Baseline mit zu ignorierenden Problemen
  -c, --config string                 Pfad zur Konfigurationsdatei
                                      Reihenfolge der Priorität:
                                      1. --config/-c
                                      2. Umgebungsvariable GITLEAKS_CONFIG
                                      3. Umgebungsvariable GITLEAKS_CONFIG_TOML mit Dateiinhalt
                                      4. (Zielpfad)/.gitleaks.toml
                                      Wenn keine der vier Optionen verwendet wird, nutzt gitleaks die Standardkonfiguration
      --diagnostics string            Diagnostik aktivieren (kommagetrennte Liste: cpu,mem,trace). cpu=CPU-Profiling, mem=Speicherprofiling, trace=Ausführungstracing
      --diagnostics-dir string        Verzeichnis zur Speicherung der Diagnostik-Ausgabedateien (Standard: aktuelles Verzeichnis)
      --enable-rule strings           Nur bestimmte Regeln per ID aktivieren
      --exit-code int                 Exit-Code, wenn Leaks gefunden wurden (Standard 1)
  -i, --gitleaks-ignore-path string   Pfad zur .gitleaksignore-Datei oder Ordner, der eine enthält (Standard ".")
  -h, --help                          Hilfe für gitleaks
      --ignore-gitleaks-allow         gitleaks:allow-Kommentare ignorieren
  -l, --log-level string              Log-Level (trace, debug, info, warn, error, fatal) (Standard "info")
      --max-decode-depth int          Rekursives Dekodieren bis zu dieser Tiefe erlauben (Standard "0", keine Dekodierung)
      --max-archive-depth int         Scannen in verschachtelten Archiven bis zu dieser Tiefe erlauben (Standard "0", keine Archivdurchsuchung)
      --max-target-megabytes int      Größere Dateien werden übersprungen
      --no-banner                     Banner unterdrücken
      --no-color                      Farben für ausführliche Ausgaben deaktivieren
      --redact uint[=100]             Geheimnisse in Logs und stdout schwärzen. Um nur Teile des Geheimnisses zu schwärzen, gib einen Prozentwert von 0..100 an. Beispiel --redact=20 (Standard 100%)
  -f, --report-format string          Ausgabeformat (json, csv, junit, sarif, template)
  -r, --report-path string            Report-Datei
      --report-template string        Template-Datei zur Generierung des Reports (impliziert --report-format=template)
  -v, --verbose                       Zeigt ausführliche Scan-Ausgabe
      --version                       Version von gitleaks

Für weitere Informationen zu einem Befehl verwende "gitleaks [Befehl] --help".
```

### Befehle

⚠️ Mit v8.19.0 wurde eine Änderung eingeführt, die `detect` und `protect` als veraltet markiert. Diese Befehle sind weiterhin verfügbar, aber
im `--help`-Menü versteckt. Sieh dir dieses [Gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) für einfache Befehlsübersetzungen an.
Wenn du feststellst, dass v8.19.0 einen bestehenden Befehl (`detect`/`protect`) unterbrochen hat, öffne bitte ein Issue.

Es gibt drei Scan-Modi: `git`, `dir` und `stdin`.

#### Git

Mit dem Befehl `git` kannst du lokale Git-Repositories scannen. Im Hintergrund verwendet gitleaks den Befehl `git log -p`, um Patches zu scannen.
Das Verhalten von `git log -p` kann mit der Option `log-opts` angepasst werden.
Wenn du beispielsweise gitleaks auf einem Commit-Bereich ausführen möchtest, könntest du den folgenden
Befehl verwenden: `gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`. Siehe die [git log](https://git-scm.com/docs/git-log) Dokumentation für weitere Informationen.
Wenn kein Ziel als Positionsargument angegeben ist, versucht gitleaks das aktuelle Arbeitsverzeichnis als Git-Repository zu scannen.
#### Dir

Der Befehl `dir` (Aliase: `files`, `directory`) ermöglicht es, Verzeichnisse und Dateien zu scannen. Beispiel: `gitleaks dir -v pfad_zum_verzeichnis_oder_datei`.
Wenn kein Ziel als Positionsargument angegeben ist, scannt gitleaks das aktuelle Arbeitsverzeichnis.

#### Stdin

Sie können Daten auch mit dem Befehl `stdin` zu gitleaks streamen. Beispiel: `cat irgendeine_datei | gitleaks -v stdin`

### Erstellung einer Baseline

Beim Scannen großer Repositories oder Repositories mit langer Historie kann es praktisch sein, eine Baseline zu verwenden. Bei Verwendung einer Baseline ignoriert gitleaks alle alten Funde, die in der Baseline vorhanden sind. Eine Baseline kann jeder gitleaks-Bericht sein. Um einen gitleaks-Bericht zu erstellen, führen Sie gitleaks mit dem Parameter `--report-path` aus.

```
gitleaks git --report-path gitleaks-report.json # Dies speichert den Bericht in einer Datei namens gitleaks-report.json
```

Sobald eine Baseline erstellt wurde, kann sie erneut beim Ausführen des detect-Befehls angewendet werden:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Nach dem Ausführen des detect-Befehls mit dem Parameter --baseline-path enthält die Ausgabe des Berichts (findings.json) nur neue Probleme.

## Pre-Commit-Hook

Sie können Gitleaks als Pre-Commit-Hook ausführen, indem Sie das Beispielskript `pre-commit.py` in Ihr
Verzeichnis `.git/hooks/` kopieren.

## Laden der Konfiguration

Die Reihenfolge der Priorität ist:

1. `--config/-c` Option:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Umgebungsvariable `GITLEAKS_CONFIG` mit dem Dateipfad:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Umgebungsvariable `GITLEAKS_CONFIG_TOML` mit dem Dateiinhalt:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Eine `.gitleaks.toml`-Datei im Zielpfad:
      ```bash
      gitleaks git .
      ```

Wenn keine der vier Optionen verwendet wird, nutzt gitleaks die Standardkonfiguration.

## Konfiguration

Gitleaks bietet ein Konfigurationsformat, dem Sie folgen können, um eigene Regeln zur Geheimniserkennung zu schreiben:

```toml
# Titel für die gitleaks-Konfigurationsdatei.
title = "Benutzerdefinierte Gitleaks-Konfiguration"

# Grundsätzlich haben Sie zwei Optionen für Ihre benutzerdefinierte Konfiguration:
#
# 1. Definieren Sie Ihre eigene Konfiguration, Standardregeln gelten nicht
#
#    Verwenden Sie z. B. die Standardkonfiguration als Ausgangspunkt:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. Erweitern Sie eine Konfiguration, die Regeln werden überschrieben oder ergänzt
#
#    Wenn Sie eine Konfiguration erweitern, haben die erweiterten Regeln Vorrang vor den
#    Standardregeln. D. h., wenn es doppelte Regeln sowohl in der erweiterten
#    Konfiguration als auch in der Standardkonfiguration gibt, werden die erweiterten Regeln oder
#    Attribute davon die Standardregeln überschreiben.
#    Ein weiterer Punkt beim Erweitern von Konfigurationen ist, dass Sie
#    mehrere Konfigurationsdateien bis zu einer Tiefe von 2 verketten können. Allowlist-Arrays werden
#    angehängt und können Duplikate enthalten.

# useDefault und path können NICHT gleichzeitig verwendet werden. Wählen Sie eine Option.
[extend]
# useDefault erweitert die in die Binärdatei eingebaute Standard-gitleaks-Konfiguration
# Die neueste Version befindet sich unter:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# oder Sie können einen Pfad zu einer Konfiguration angeben, von der erweitert werden soll.
# Der Pfad ist relativ zu dem Verzeichnis, in dem gitleaks aufgerufen wurde,
# nicht zum Speicherort der Basiskonfiguration.
# path = "common_config.toml"
# Falls es Regeln gibt, die Sie nicht übernehmen möchten, können sie hier angegeben werden.
disabledRules = [ "generic-api-key"]

# Ein Array von Tabellen, die Informationen enthalten, um Anweisungen zu definieren,
# wie Geheimnisse erkannt werden sollen
[[rules]]
# Eindeutiger Bezeichner für diese Regel
id = "awesome-rule-1"

# Kurzbeschreibung der Regel.
description = "awesome rule 1"

# Golang-Regulärer Ausdruck zur Erkennung von Geheimnissen. Beachten Sie, dass Golangs Regex-Engine
# keine Lookaheads unterstützt.
regex = '''one-go-style-regex-for-this-rule'''

# Integer zum Extrahieren des Geheimnisses aus dem Regex-Match, wird als die Gruppe verwendet,
# deren Entropie überprüft wird, falls `entropy` gesetzt ist.
secretGroup = 3

# Float, der die minimale Shannon-Entropie angibt, die eine Regex-Gruppe haben muss, um als Geheimnis zu gelten.
entropy = 3.5

# Golang-Regulärer Ausdruck zum Abgleichen von Pfaden. Kann als eigenständige Regel oder
# in Verbindung mit einem gültigen `regex`-Eintrag verwendet werden.
path = '''a-file-path-regex'''

# Schlüsselwörter werden für das Pre-Regex-Check-Filtering verwendet. Regeln, die
# Schlüsselwörter enthalten, führen einen schnellen Zeichenkettenvergleich durch, um sicherzustellen,
# dass das/die Schlüsselwort(e) im zu scannenden Inhalt enthalten sind. Idealerweise sollten diese Werte
# Teil des Identifiers oder eindeutige Zeichenfolgen sein, die spezifisch für den Regex der Regel sind
# (eingeführt in v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Array von Zeichenfolgen, die für Metadaten- und Berichts-Zwecke verwendet werden.
tags = ["tag","another tag"]

    # ⚠️ In v8.21.0 wurde `[rules.allowlist]` durch `[[rules.allowlists]]` ersetzt.
    # Diese Änderung ist rückwärtskompatibel: Instanzen von `[rules.allowlist]` funktionieren weiterhin.
    #
    # Sie können mehrere Allowlists für eine Regel definieren, um Fehlalarme zu reduzieren.
    # Ein Fund wird ignoriert, wenn _EINE_ `[[rules.allowlists]]` übereinstimmt.
    [[rules.allowlists]]
    description = "commit A ignorieren"
    # Wenn mehrere Kriterien definiert sind, ist die Standardbedingung "OR".
    # z. B. kann dies auf |commits| ODER |paths| ODER |stopwords| zutreffen.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # Hinweis: stopwords zielt auf das extrahierte Geheimnis ab, nicht auf den gesamten Regex-Match
    # wie 'regexes'. (stopwords eingeführt in 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # Die "AND"-Bedingung kann verwendet werden, um sicherzustellen, dass alle Kriterien übereinstimmen.
    # z. B. trifft dies zu, wenn |regexes| UND |paths| erfüllt sind.
    condition = "AND"
    # Hinweis: |regexes| prüft standardmäßig das _Secret_ im Fund.
    # Zulässige Werte für |regexTarget| sind "secret" (Standard), "match" und "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Sie können eine bestimmte Regel aus der Standardkonfiguration erweitern, z. B. gitlab-pat
# falls Sie ein eigenes Token-Präfix auf Ihrer GitLab-Instanz definiert haben
[[rules]]
id = "gitlab-pat"
# alle anderen Attribute aus der Standardregel werden übernommen

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ In v8.25.0 wurde `[allowlist]` durch `[[allowlists]]` ersetzt.
#
# Globale Allowlists haben eine höhere Priorität als regelbasierte Allowlists.
# Wenn ein Commit, das im Feld `commits` unten aufgeführt ist, gefunden wird, wird dieser Commit übersprungen und es werden keine
# Geheimnisse für diesen Commit erkannt. Das gleiche gilt für regexes und paths.
[[allowlists]]
description = "globale Allowlist"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# Hinweis: (globales) regexTarget prüft standardmäßig das _Secret_ im Fund.
# Zulässige Werte für regexTarget sind "match" und "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# Hinweis: stopwords zielt auf das extrahierte Geheimnis ab, nicht auf den gesamten Regex-Match
# wie 'regexes'. (stopwords eingeführt in 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ In v8.25.0 gibt es in `[[allowlists]]` ein neues Feld namens |targetRules|.
#
# Gemeinsame Allowlists können einmal definiert und mehreren Regeln mithilfe von |targetRules| zugewiesen werden.
# Dies wird nur bei den angegebenen Regeln ausgeführt, nicht global.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Unsere Test-Assets lösen in einigen Regeln False-Positives aus."
paths = ['''tests/expected/._\.json$''']
```

Siehe die Standard-[gitleaks-Konfiguration](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) für Beispiele oder folge den [Beitragsrichtlinien](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md), wenn du zur Standardkonfiguration beitragen möchtest. Zusätzlich kannst du [diesen gitleaks Blogbeitrag](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) lesen, der fortgeschrittene Konfigurations-Setups behandelt.

### Zusätzliche Konfiguration

#### gitleaks:allow

Wenn du wissentlich ein Test-Geheimnis committest, das von gitleaks erkannt wird, kannst du einen `gitleaks:allow` Kommentar zu dieser Zeile hinzufügen, wodurch gitleaks angewiesen wird, dieses Geheimnis zu ignorieren. Beispiel:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Du kannst bestimmte Funde ignorieren, indem du eine `.gitleaksignore`-Datei im Root-Verzeichnis deines Repos erstellst. In Version v8.10.0 hat Gitleaks einen `Fingerprint`-Wert zum Gitleaks-Bericht hinzugefügt. Jeder Leak oder Fund hat einen Fingerprint, der ein Geheimnis eindeutig identifiziert. Füge diesen Fingerprint in die `.gitleaksignore`-Datei ein, um genau dieses Geheimnis zu ignorieren. Siehe die [.gitleaksignore](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) von Gitleaks als Beispiel. Hinweis: Dieses Feature ist experimentell und kann sich in Zukunft ändern.

#### Decodierung

Manchmal sind Geheimnisse kodiert, sodass sie mit einfachem Regex schwer zu finden sind. Jetzt kannst du gitleaks anweisen, kodierten Text automatisch zu finden und zu decodieren. Das Flag `--max-decode-depth` aktiviert dieses Feature (der Standardwert "0" bedeutet, dass das Feature standardmäßig deaktiviert ist).

Rekursive Decodierung wird unterstützt, da decodierter Text ebenfalls kodierten Text enthalten kann. Das Flag `--max-decode-depth` setzt das Rekursionslimit. Die Rekursion stoppt, wenn es keine neuen Segmente kodierten Texts mehr zu decodieren gibt, sodass eine sehr hohe max depth nicht zwangsläufig viele Durchläufe bedeutet. Es werden nur so viele Durchläufe wie nötig gemacht, um den Text zu decodieren. Insgesamt erhöht die Decodierung die Scan-Zeiten nur minimal.

Die Funde für kodierten Text unterscheiden sich von normalen Funden folgendermaßen:

- Der Ort zeigt die Grenzen des kodierten Texts an
  - Wenn die Regel außerhalb des kodierten Texts matched, werden die Grenzen angepasst, um dies ebenfalls einzuschließen
- Match und Secret enthalten den decodierten Wert
- Zwei Tags werden hinzugefügt: `decoded:<encoding>` und `decode-depth:<depth>`

Aktuell unterstützte Encodings:

- **percent** – Alle druckbaren ASCII Prozent-kodierten Werte
- **hex** – Alle druckbaren ASCII Hex-kodierten Werte >= 32 Zeichen
- **base64** – Alle druckbaren ASCII Base64-kodierten Werte >= 16 Zeichen

#### Archiv-Scanning

Manchmal sind Geheimnisse in Archivdateien wie ZIPs oder Tarballs verpackt und dadurch schwer zu entdecken. Jetzt kannst du gitleaks anweisen, Inhalte von Archiven automatisch zu extrahieren und zu scannen. Das Flag `--max-archive-depth` aktiviert dieses Feature für beide Scantypen `dir` und `git`. Der Standardwert "0" bedeutet, dass dieses Feature standardmäßig deaktiviert ist.

Rekursives Scannen wird unterstützt, da Archive auch weitere Archive enthalten können. Das Flag `--max-archive-depth` setzt das Rekursionslimit. Die Rekursion stoppt, wenn keine neuen Archive mehr extrahiert werden können, sodass eine sehr hohe max depth nur das Potenzial für eine tiefere Suche setzt. Es wird nur so tief gescannt, wie nötig.

Die Funde für Geheimnisse, die in einem Archiv gefunden werden, enthalten den Pfad zur Datei im Archiv. Innere Pfade werden mit `!` getrennt.

Beispielfund (gekürzt):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

Das bedeutet, ein Geheimnis wurde in Zeile 4 von `files/.env.prod` gefunden, das sich in `archives/files.tar` befindet, welches wiederum in `testdata/archives/nested.tar.gz` liegt.

Aktuell unterstützte Formate:

Die [Kompressionsformate](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats) und [Archivformate](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats), die von mholts [archives package](https://github.com/mholt/archives) unterstützt werden, sind ebenfalls unterstützt.

#### Berichte

Gitleaks bietet eingebaute Unterstützung für verschiedene Berichtsformate: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml) und [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Falls keines dieser Formate deinen Anforderungen entspricht, kannst du dein eigenes Berichtsformat mit einer [Go `text/template` .tmpl-Datei](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) und dem Flag `--report-template` erstellen. Das Template kann [erweiterte Funktionen aus der `Masterminds/sprig` Template-Bibliothek](https://masterminds.github.io/sprig/) verwenden.

Zum Beispiel bietet das folgende Template eine individuelle JSON-Ausgabe:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

Verwendung:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Sponsoren

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Exit Codes

Du kannst den Exit-Code immer mit dem Flag --exit-code setzen, wenn Leaks gefunden werden. Standard-Exit-Codes unten:

```
0 - keine Leaks vorhanden
1 - Leaks oder Fehler gefunden
126 - unbekanntes Flag
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---