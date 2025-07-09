# AI-Roman-Editor

Ein auf PyQt6 basierender, KI-gestützter Romaneditor, der intelligente Vervollständigung, Projektmanagement, Konzeptorganisation und weitere professionelle Schreibwerkzeuge bietet.

## Installation

1. Projekt klonen
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Virtuelle Umgebung erstellen
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Abhängigkeiten installieren
```bash
pip install -r requirements.txt
```
4. Programm ausführen
```bash
python src/main.py
```

## Hauptfunktionen

### Projektmanagement
- Hierarchische Dokumentenstruktur (Werk > Kapitel > Szene)
- Projektimport und -export (unterstützt TEXT-, MARKDOWN-, DOCX-, PDF-, HTML-Formate)
- Automatische Sicherung und Versionskontrolle
- Mehrprojektverwaltung

### KI-Vervollständigungsfunktion
- Drei Vervollständigungsmodi: Automatische Vervollständigung, Manuelle Vervollständigung (empfohlen: einmal Tab drücken zum Auslösen, nochmal Tab zum Anwenden der Vervollständigung), Vervollständigung deaktivieren
- Drei Kontextmodi:
  - Schnellmodus: Leichtgewichtiger Kontext, schnelle Reaktion
  - Ausgewogenmodus: Mittlerer Kontext, Ausgewogenheit zwischen Qualität und Geschwindigkeit
  - Globalmodus: Vollständiger Projektkontext, bestes Ergebnis
- Unterstützung für verschiedene KI-Dienste: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq usw.
### Gliederungsverwaltung
- Visualisierte Gliederungsbaumstruktur
- Drag-and-Drop-Sortierung und Ebenenanpassung
- Schnelle Dokumentennavigation
- Gliederungsanalyse und Optimierungsvorschläge

### API-Konfiguration
- Zentrales AI-Konfigurationszentrum
- Voreingestellte Konfigurationen für mehrere Anbieter
- Verbindungstest-Funktion
- Konfigurationslösungen speichern sowie Import und Export

### Intelligente Vervollständigungseinstellungen
- Einstellbare Auslöseverzögerung
- Begrenzung der Vervollständigungslänge
- Kontextlängenkonfiguration
- Unterstützung für Streaming-Antworten

### Prompt-Editor
- Mehrere integrierte Schreibvorlagen
- Benutzerdefinierte Prompt-Vorlagen
- Vorlagenkategorieverwaltung
- Modusspezifische Vorlagenkonfiguration
### Benutzeroberflächenfunktionen
- Helles und dunkles Design
- Dreispaltiges Layout (Projektbaum, Editor, Konzept-Panel)
- Einklappbare Seitenleiste
- Vollbild-Schreibmodus
- Fokusmodus (Satz, Absatz, Schreibmaschinenmodus, Zen-Modus, Immersionsmodus)

### Suchen und Ersetzen
- Projektsuche im gesamten Text
- Unterstützung für reguläre Ausdrücke
- Funktion zum Ersetzen in großen Mengen
- Erweiterte Suchoptionen

### Konzeptverwaltung
- Automatische Erkennung von Charakteren, Orten, Objekten
- Verwaltung von Konzeptbeziehungen
- Tag- und Kategoriensystem
- Schnelles Einfügen von Konzepten

## Tastenkürzel
- `Ctrl+N`: Neues Projekt
- `Ctrl+O`: Projekt öffnen
- `Ctrl+S`: Dokument speichern
- `F11`: Vollbildmodus
- `Tab`: Manuelles Auslösen der KI-Vervollständigung (im manuellen Modus)
- `Ctrl+F`: Suchen
- `Ctrl+H`: Suchen und Ersetzen
- `Ctrl+Shift+H`: Erweiterte Suche und Ersetzen


## Systemanforderungen

- Python 3.8+
- PyQt6
- Betriebssystem: Windows, macOS, Linux

## Autor

**inliver**
- E-Mail: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---