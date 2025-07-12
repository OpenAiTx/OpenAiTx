# Git Smart Squash

Verschwenden Sie keine Zeit mehr mit dem manuellen Umorganisieren von Commits. Lassen Sie die KI das für Sie erledigen.

## Das Problem

Sie kennen das: 15 Commits für ein Feature, die Hälfte davon sind "fix", "typo" oder "WIP". Jetzt müssen Sie alles für das PR-Review aufräumen. Manuelles Squashen und Umschreiben ist mühsam.

## Die Lösung

Git Smart Squash analysiert Ihre Änderungen und organisiert sie in logische Commits mit passenden Nachrichten:

```bash
# Vorher: Ihr unordentlicher Branch
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# Nachher: saubere, logische Commits
* feat: JWT-Authentifizierungssystem implementieren
* test: Testabdeckung für Auth-Endpunkt hinzufügen
```

## Schnellstart

### 1. Installation

```bash
# Mit pip
pip install git-smart-squash

# Mit pipx (empfohlen für isolierte Installation)
pipx install git-smart-squash

# Mit uv (schneller Python-Paketmanager)
uv tool install git-smart-squash
```
### 2. KI einrichten

**Option A: Lokal (Kostenlos, Privat)**
```bash
# Installiere Ollama von https://ollama.com
ollama pull devstral  # Standardmodell
```

**Option B: Cloud (Bessere Ergebnisse)**
```bash
export OPENAI_API_KEY="dein-key"
export ANTHROPIC_API_KEY="dein-key"
export GEMINI_API_KEY="dein-key"
```

### 3. Ausführen

```bash
cd dein-repo
git-smart-squash
```
Das war’s. Überprüfen Sie den Plan und genehmigen Sie ihn.

## Kommandozeilenparameter

| Parameter | Beschreibung | Standardwert |
|-----------|--------------|--------------|
| `--base` | Basis-Branch zum Vergleichen | Konfigurationsdatei oder `main` |
| `--ai-provider` | Zu verwendender KI-Anbieter (openai, anthropic, local, gemini) | In den Einstellungen konfiguriert |
| `--model` | Zu verwendendes spezifisches KI-Modell (siehe empfohlene Modelle unten) | Anbieter-Standard |
| `--config` | Pfad zur benutzerdefinierten Konfigurationsdatei | `.git-smart-squash.yml` oder `~/.git-smart-squash.yml` |
| `--auto-apply` | Commit-Plan ohne Bestätigungsabfrage anwenden | `false` |
| `--instructions`, `-i` | Benutzerdefinierte Anweisungen für die KI (z.B. „Nach Funktionsbereich gruppieren“) | Keine |
| `--no-attribution` | Hinweis auf Urheberschaft in Commits deaktivieren | `false` |
| `--debug` | Debug-Logging für detaillierte Informationen aktivieren | `false` |

## Empfohlene Modelle

### Standardmodelle
- **OpenAI**: `gpt-4.1` (Standard)
- **Anthropic**: `claude-sonnet-4-20250514` (Standard)
- **Gemini**: `gemini-2.5-pro` (Standard)
- **Lokal/Ollama**: `devstral` (Standard)

### Modellauswahl
```bash
# Anderes Modell angeben
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Für lokales Ollama
git-smart-squash --ai-provider local --model llama-3.1
```

## Benutzerdefinierte Anweisungen

Mit dem Parameter `--instructions` können Sie steuern, wie Commits organisiert werden:

### Beispiele
```bash
# Ticket-Präfixe hinzufügen
git-smart-squash -i "Alle Commits mit [ABC-1234] präfixieren"

# Nach Typ trennen
git-smart-squash -i "Backend- und Frontend-Änderungen in separaten Commits halten"
```
# Commit-Anzahl begrenzen
git-smart-squash -i "Erstelle insgesamt höchstens 3 Commits"
```

### Tipps für bessere Ergebnisse
- **Sei spezifisch**: "Gruppiere Datenbankmigrationen separat" funktioniert besser als "schön organisieren"
- **Nur eine Anweisung auf einmal**: Komplexe, mehrteilige Anweisungen werden möglicherweise nur teilweise beachtet
- **Bessere Modelle verwenden**: Größere Modelle befolgen Anweisungen zuverlässiger als kleinere Modelle

## Häufige Anwendungsfälle

### "Ich muss vor dem PR-Review aufräumen"
```bash
git-smart-squash              # Zeigt Plan an und fordert zur Bestätigung auf
git-smart-squash --auto-apply # Wendet automatisch ohne Nachfrage an
```

### "Ich arbeite mit einem anderen Haupt-Branch"
```bash
git-smart-squash --base develop
```
### "Ich möchte einen bestimmten KI-Anbieter verwenden"
```bash
git-smart-squash --ai-provider openai
```

## Sicherheit

**Ihr Code ist sicher:**
- Zeigt den Plan vor Änderungen an
- Erstellt einen automatischen Backup-Branch
- Erfordert ein sauberes Arbeitsverzeichnis
- Führt niemals ein Push ohne Ihren Befehl aus

**Wenn etwas schiefgeht:**
```bash
# Backup finden
git branch | grep backup

# Wiederherstellen
git reset --hard your-branch-backup-[timestamp]
```

## KI-Anbieter

| Anbieter   | Kosten   | Datenschutz |
|------------|----------|-------------|
| **Ollama** | Kostenlos| Lokal       |
| **OpenAI** | ~0,01 $  | Cloud       |
| **Anthropic** | ~0,01 $ | Cloud     |
| **Gemini** | ~0,01 $  | Cloud       |

## Erweiterte Konfiguration (Optional)

Möchten Sie anpassen? Erstellen Sie eine Konfigurationsdatei:

**Projektspezifisch** (`.git-smart-squash.yml` in Ihrem Repository):
```yaml
ai:
  provider: openai  # Verwende OpenAI für dieses Projekt
base: develop       # Verwende develop als Basis-Branch für dieses Projekt
```
**Globale Voreinstellung** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Immer standardmäßig lokale KI verwenden
base: main          # Standard-Basis-Branch für alle Projekte
```

## Fehlerbehebung

### "Ungültiges JSON"-Fehler
Dies bedeutet meistens, dass das KI-Modell die Antwort nicht richtig formatiert hat:
- **Mit Ollama**: Wechseln Sie von `llama2` zu `mistral` oder `mixtral`
- **Lösung**: `ollama pull mistral` ausführen und erneut versuchen
- **Alternative**: Einen Cloud-Anbieter mit `--ai-provider openai` verwenden

### Modell befolgt Anweisungen nicht
Einige Modelle haben Schwierigkeiten mit komplexen Anweisungen:
- **Bessere Modelle verwenden**: `--model gpt-4-turbo` oder `--model claude-3-opus`
- **Anweisungen vereinfachen**: Eine klare Anweisung funktioniert besser als mehrere
- **Explizit sein**: "Mit [ABC-123] voranstellen" statt "Ticketnummer hinzufügen"
### "Ollama nicht gefunden"
```bash
# Installation von https://ollama.com
ollama serve
ollama pull devstral  # Standardmodell
```

### Schlechte Commit-Gruppierung
Wenn die KI zu viele Commits erstellt oder nicht gut gruppiert:
- **Unzureichendes Modell**: Verwenden Sie ein größeres Modell
- **Fügen Sie Anweisungen hinzu**: `-i "Ähnliche Änderungen gruppieren, maximal 3 Commits"`
- **Feedback geben**: Erstellen Sie ein Issue auf GitHub und teilen Sie uns mit, was passiert ist

### Installationsprobleme (Mac)
Wenn Sie kein pip haben oder isolierte Installationen bevorzugen:
```bash
# Mit pipx (empfohlen)
brew install pipx
pipx install git-smart-squash
```
### "Keine Änderungen zum Neuorganisieren"
```bash
git log --oneline main..HEAD  # Prüfen Sie, ob Sie Commits haben
git diff main                 # Prüfen Sie, ob Sie Änderungen haben
```

### Große Diffs / Token-Limits
Lokale Modelle haben ein Token-Limit von ca. 32k. Bei großen Änderungen:
- Verwenden Sie `--base` mit einem aktuelleren Commit
- Wechseln Sie zur Cloud: `--ai-provider openai`
- Teilen Sie in kleinere PRs auf

### Benötigen Sie weitere Hilfe?

Sehen Sie sich unsere [ausführliche Dokumentation](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) an oder eröffnen Sie ein Issue!

## Lizenz

MIT-Lizenz – siehe [LICENSE](LICENSE) Datei für Details.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---