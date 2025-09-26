
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Python Unterstützung](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

Ein terminalbasiertes KI-Simulationsspiel.

## Verwendung

Sie können die ausführbare Anwendung von der [neuesten Veröffentlichung](https://github.com/luyiourwong/Terminara/releases/latest) herunterladen.

Die vollständige komprimierte Datei enthält die ausführbare Datei und die Standard-Welteinstellungsdatei. Sie können nur die ausführbare Datei herunterladen, wenn Sie das Spiel auf die neueste Version aktualisieren.

| Betriebssystem | Version                                           |
|----------------|--------------------------------------------------|
| Windows        | Windows 10, Windows 11                           |
| Linux          | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS          | macOS 13, macOS 14, macOS 15, macOS 26           |

<details>
<summary><strong>Manuelles Ausführen</strong></summary>

### Installation

1.  **Repository klonen:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```
2.  **Erstellen Sie eine virtuelle Umgebung:**

    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Unter Windows verwenden Sie `.venv\Scripts\activate`

3.  **Installieren Sie die Abhängigkeiten:**
    ```bash
    pip install -e .
    ```

### Startmethode 1: Verwendung des installierten Befehls (Empfohlen)
Nach der Installation starten Sie das Spiel mit:
```bash
terminara
```

### Startmethode 2: Direkte Ausführung
Plattformübergreifende Methode
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Unter Windows verwenden Sie `terminara\main.py`

Weitere Informationen finden Sie im [Contribute & Develop Guide](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## KI-Einrichtung

Nach dem Starten der Anwendung müssen Sie die KI-Einstellungen über das Hauptmenü konfigurieren.

![KI-Einstellungen](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Sie müssen die folgenden Felder ausfüllen: (OpenAI-kompatible API)
- **Host**: Die API-Endpunkt-Adresse. Lassen Sie das Feld leer, um den Standard-OpenAI-Endpunkt zu verwenden.
- **API-Schlüssel**: Ihr API-Schlüssel für den KI-Dienst.
- **Modell**: Das Modell, das Sie verwenden möchten.

Klicken Sie auf "Übernehmen", um die Einstellungen zu speichern.

### Beispiele

#### 1. [OpenAI](https://platform.openai.com/) (Standard)
- **Host**: (leer lassen)
- **API-Schlüssel**: `YOUR_OPENAI_API_KEY`
- **Modell**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API-Schlüssel**: `YOUR_GEMINI_API_KEY`
- **Modell**: `gemini-2.0-flash`

## Welten-Konfiguration

### Speicherort der Konfiguration
Die Welteneinstellungen werden im Verzeichnis `terminara/data/worlds` gespeichert. (in der Vollversion)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Eine neue Welt erstellen
Es gibt eine Beispielwelt [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Du kannst dem [Schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) folgen, um eine neue Welt zu erstellen.

## Links

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Repository](https://github.com/luyiourwong/Terminara)
- [Beitragen & Entwicklungsanleitung](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Lizenz

Dieses Projekt ist unter der [MIT-Lizenz](LICENSE) lizenziert.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---