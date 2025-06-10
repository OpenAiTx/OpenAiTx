# AI Screenshot Translator (AI Screenshot Übersetzer)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Einführung

Dieses Tool ermöglicht es, **mit einer einfachen Screenshot-Aktion** ein Bild an ein KI-Modell zu senden, um Text zu erkennen und zu übersetzen. Das Übersetzungsergebnis wird in einem interaktiven HTML-Format in einem separaten Fenster angezeigt.

Das Tool unterstützt **benutzerdefinierte Hotkey-Auslösung, Multi-Window-Ergebnisverwaltung und Ausführung im System-Tray** und steigert so erheblich die Übersetzungseffizienz bei der täglichen Arbeit und beim Lernen.

**Tool-Eigenschaften**: 1. Screenshot-Übersetzung, Start über Hotkey; 2. Übersetzungs- und Screenshot-Panels, beliebig verschiebbar und skalierbar, mehrere Übersetzungs-Panels erstellbar; 3. Bei Formeln kann auf den Originaltext umgeschaltet werden, um das Kopieren zu erleichtern; 4. Benutzerdefinierte API-Schnittstelle

**Zu lösende Probleme**: 1. Die aktuell gängigen Dokumenten-Übersetzungstools sind zu überladen; 2. Beim Kopieren von PDF-Texten zur Übersetzung sind Formeln manchmal fehlerhaft oder nicht kopierbar; 3. Bei bildbasierten PDFs kann kein Text kopiert werden

# Demo

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Fensteransicht

Übersetzungsfenster:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Konfigurationsfenster:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Eine detailliertere Einführung zu den Konfigurationsoptionen finden Sie innerhalb der Software oder online unter [Hinweis](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Installation

Sie können entweder den Quellcode herunterladen und ausführen oder im [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases)-Bereich die ausführbare Datei herunterladen.

### 1. Repository klonen

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Virtuelle Umgebung erstellen und ausführen

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Update-Plan

- ~~Neues GUI-Fenster für die API-Konfiguration, Optimierung der manuellen YAML-Konfiguration durch automatische Generierung durch die Software (v0.3.0 abgeschlossen)~~
- Neues Bild- und Formel-Speichersystem für spätere Nutzung (voraussichtlich ab v0.4)
- (Weitere Funktionen gerne als Issue einreichen oder per PR beitragen)

# Sonstiges

- Das Software-Icon stammt von [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Danke an Gemini 2.5 Flash und DeepSeek-V3-0324 für das Finden von Bugs

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---