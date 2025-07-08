# Spegel – Reflektiere das Web durch KI

Schreibt Webseiten automatisch in Markdown um, optimiert für die Anzeige im Terminal.
Einführenden Blogbeitrag [hier lesen](https://simedw.com/2025/06/23/introducing-spegel/)

Dies ist ein Proof-of-Concept, Fehler sind zu erwarten, aber du kannst gerne ein Issue erstellen oder einen Pull Request stellen.

## Screenshot
Manchmal möchte man nicht die ganze Lebensgeschichte von jemandem lesen, nur um an ein Rezept zu kommen
![Rezeptbeispiel](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)

## Installation

Benötigt Python 3.11+

```
pip install spegel
```
oder klone das Repository und installiere es im Editiermodus

```bash
# Klonen und Verzeichnis betreten
$ git clone <repo-url>
$ cd spegel

# Abhängigkeiten und CLI installieren
$ pip install -e .
```

## API-Schlüssel
Spegel unterstützt derzeit nur Gemini 2.5 Flash. Um es zu nutzen, musst du deinen API-Schlüssel in der Umgebung bereitstellen

```
GEMINI_API_KEY=...
```

## Verwendung

### Browser starten

```bash
spegel                # Startet mit dem Begrüßungsbildschirm
spegel bbc.com        # Öffnet sofort eine URL
```

Oder, gleichwertig:

```bash
python -m spegel      # Startet mit dem Begrüßungsbildschirm
python -m spegel bbc.com
```

### Grundlegende Steuerung
- `/`         – URL-Eingabe öffnen
- `Tab`/`Shift+Tab` – Links durchlaufen
- `Enter`     – Ausgewählten Link öffnen
- `e`         – LLM-Prompt für aktuelle Ansicht bearbeiten
- `b`         – Zurückgehen
- `q`         – Beenden

## Einstellungen bearbeiten

Spegel lädt Einstellungen aus einer TOML-Konfigurationsdatei. Du kannst Ansichten, Prompts und UI-Optionen anpassen.

**Reihenfolge der Konfigurationsdatei-Suche:**
1. `./.spegel.toml` (aktuelles Verzeichnis)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Um Einstellungen zu bearbeiten:
1. Beispielkonfiguration kopieren:
   ```bash
   cp example_config.toml .spegel.toml
   # oder erstelle ~/.spegel.toml
   ```
2. Bearbeite `.spegel.toml` in deinem bevorzugten Editor.

Beispiel-Ausschnitt:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transformiere diese Webseite in das perfekte Terminal-Browsing-Erlebnis! ..."
```

---

Für mehr Informationen sieh dir den Code an oder öffne ein Issue!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---