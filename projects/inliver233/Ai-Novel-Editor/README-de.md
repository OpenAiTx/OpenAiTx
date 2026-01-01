
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# KI-Roman-Editor

Ein KI-gestützter Romaneditor basierend auf PyQt6, bietet intelligente Vervollständigung, Projektmanagement, Konzeptorganisation und weitere professionelle Schreibwerkzeuge.

## Installation

1. Projekt klonen
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Erstellen einer virtuellen Umgebung
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
- Automatisches Backup und Versionskontrolle
- Mehrprojektverwaltung

### KI-Vervollständigungsfunktionen
- Drei Vervollständigungsmodi: Automatische Vervollständigung, manuelle Vervollständigung (empfohlen: einmal Tab drücken zum Auslösen, erneut Tab zum Anwenden), Vervollständigung deaktivieren
- Drei Kontextmodi:
  - Schnellmodus: Leichtgewichtiger Kontext, schnelle Reaktion
  - Ausgewogener Modus: Mittlerer Kontext, Balance zwischen Qualität und Geschwindigkeit
  - Globaler Modus: Vollständiger Projektkontext, bestes Ergebnis
- Unterstützung mehrerer KI-Dienste: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq usw.

### Gliederungsverwaltung
- Visualisierte Gliederungsbaumstruktur
- Drag-and-Drop-Sortierung und Hierarchieanpassung
- Schnelle Dokumentennavigation
- Gliederungsanalyse und Optimierungsvorschläge

### API-Konfiguration
- Zentrales KI-Konfigurationszentrum
- Voreingestellte Konfigurationen für mehrere Anbieter
- Verbindungstestfunktion
- Speichern sowie Import und Export von Konfigurationen

### Intelligente Vervollständigungseinstellungen
- Einstellbare Auslöseverzögerung
- Begrenzung der Vervollständigungslänge
- Konfiguration der Kontextlänge
- Unterstützung für Streaming-Antworten

### Prompt-Bearbeitung
- Integrierte verschiedene Schreibvorlagen
- Benutzerdefinierte Prompt-Vorlagen
- Vorlagen-Kategorisierung
- Modusspezifische Vorlagenkonfiguration

### Benutzeroberflächenfunktionen
- Helles und dunkles Thema
- Drei-Spalten-Layout (Projektbaum, Editor, Konzept-Panel)
- Einklappbare Seitenleiste
- Vollbild-Schreibmodus
- Fokusmodus (Satz, Absatz, Schreibmaschine, Zen-Modus, Immersionsmodus)

### Suchen und Ersetzen
- Projekweite Textsuche
- Unterstützung für reguläre Ausdrücke
- Stapelersetzungsfunktion
- Erweiterte Suchoptionen

### Konzeptverwaltung
- Automatische Erkennung von Charakteren, Orten, Objekten
- Verwaltung von Konzeptbeziehungen
- Tag- und Kategoriensystem
- Schnelle Konzept-Einfügung

## Tastenkombinationen

- `Ctrl+N`: Neues Projekt
- `Ctrl+O`: Projekt öffnen
- `Ctrl+S`: Dokument speichern
- `F11`: Vollbildmodus
- `Tab`: Manuelles Auslösen der KI-Vervollständigung (im manuellen Modus)
- `Ctrl+F`: Suchen
- `Ctrl+H`: Suchen und Ersetzen
- `Ctrl+Shift+H`: Erweitertes Suchen und Ersetzen


## Systemanforderungen

- Python 3.8+
- PyQt6
- Betriebssystem: Windows, macOS, Linux

## Autor

**inliver**
- E-Mail: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---