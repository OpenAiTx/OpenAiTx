<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">Englisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Französisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Spanisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Italienisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Russisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Portugiesisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Niederländisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polnisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">Arabisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">Persisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Vietnamesisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# AI Roman-Editor

Ein auf PyQt6 basierender, KI-gestützter Roman-Editor, der professionelle Schreibwerkzeuge wie intelligente Vervollständigung, Projektmanagement und Konzeptorganisation bietet.

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
Verwendung von uv
```bash
uv venv -p 3.11
```
3. Abhängigkeiten installieren
```bash
pip install -r requirements.txt
```
Mit uv verwenden
```bash
uv sync
```


4. Programm ausführen
```bash
python -m src
```

## Hauptfunktionen

### Projektmanagement
- Hierarchische Dokumentenstruktur (Werk > Kapitel > Szene)
- Projektimport und -export (unterstützt TEXT, MARKDOWN, DOCX, PDF, HTML-Formate)
- Automatische Sicherung und Versionskontrolle
- Verwaltung mehrerer Projekte
### KI-Autovervollständigungsfunktion
- Drei Vervollständigungsmodi: Automatische Vervollständigung, Manuelle Vervollständigung (empfohlen: einmal Tab drücken zum Auslösen, nochmal Tab zum Anwenden), Deaktivierte Vervollständigung
- Drei Kontextmodi:
  - Schneller Modus: Leichtgewichtiger Kontext, schnelle Reaktion
  - Ausgewogener Modus: Mittlerer Kontext, ausgewogen zwischen Qualität und Geschwindigkeit
  - Globaler Modus: Vollständiger Projektkontext, bestes Ergebnis
- Unterstützung für verschiedene KI-Dienste: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq usw.

### Gliederungsverwaltung
- Visualisierte Gliederungsbaumstruktur
- Drag-and-Drop-Sortierung und Hierarchieanpassung
- Schnelle Dokumentnavigation
- Gliederungsanalyse und Optimierungsvorschläge

### API-Konfiguration
- Zentrales KI-Konfigurationscenter
- Voreingestellte Konfigurationen für mehrere Anbieter
- Verbindungstestfunktion
- Speichern sowie Import und Export von Konfigurationsschemata
### Intelligente Autovervollständigungs-Einstellungen
- Einstellbare Auslöseverzögerung
- Begrenzung der Vervollständigungslänge
- Konfiguration der Kontextlänge
- Unterstützung für Streaming-Antworten

### Prompt-Bearbeitung
- Mehrere integrierte Schreibvorlagen
- Benutzerdefinierte Prompt-Vorlagen
- Kategorisierte Vorlagenverwaltung
- Modusspezifische Vorlagenkonfiguration

### Benutzeroberflächenfunktionen
- Heller und dunkler Modus
- Dreispaltiges Layout (Projektbaum, Editor, Konzeptpanel)
- Einklappbare Seitenleiste
- Vollbild-Schreibmodus
- Fokusmodus (Satz, Absatz, Schreibmaschinenmodus, Zen-Modus, Immersionsmodus)

### Suchen und Ersetzen
- Gesamte Projekttextsuche
- Unterstützung für reguläre Ausdrücke
- Funktion für Batch-Ersetzungen
- Erweiterte Suchoptionen

### Konzeptmanagement
- Automatische Erkennung von Rollen, Orten und Objekten
- Verwaltung von Konzeptbeziehungen
- Tagging- und Kategoriesystem
- Schnelles Einfügen von Konzepten

## Tastenkombinationen

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---