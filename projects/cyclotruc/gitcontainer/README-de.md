![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Verwandle jedes GitHub-Repository in einen produktionsbereiten Docker-Container mit KI-gestützter Dockerfile-Generierung.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer ist eine KI-gestützte Webanwendung, die automatisch produktionsbereite Dockerfiles generiert, indem sie GitHub-Repositories analysiert. Einfach eine GitHub-URL einfügen und ein maßgeschneidertes Dockerfile mit intelligenter Basiseimagenauswahl, Abhängigkeitsmanagement und Docker Best Practices erhalten.

## 🌟 Schneller Zugriff

Ersetze einfach `github.com` durch `gitcontainer.com` in jeder GitHub-Repository-URL, um sofort zur Dockerfile-Generierungsseite dieses Repositories zu gelangen.

Beispiel:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Funktionen

- **🔄 Sofortiger URL-Zugriff**: Einfach 'github.com' durch 'gitcontainer.com' in jeder GitHub-URL ersetzen
- **🤖 KI-gestützte Analyse**: Nutzt OpenAI GPT-4 zur Analyse der Repository-Struktur und zur Generierung intelligenter Dockerfiles
- **⚡ Echtzeit-Streaming**: Beobachte, wie die KI dein Dockerfile in Echtzeit per WebSocket-Streaming generiert
- **🎯 Intelligente Erkennung**: Erkennt automatisch Technologiestacks (Python, Node.js, Java, Go, usw.)
- **🔧 Produktionsbereit**: Generiert Dockerfiles nach Best Practices mit richtiger Sicherheit, Multi-Stage-Builds und Optimierung
- **📋 Zusätzliche Anweisungen**: Füge eigene Anforderungen für spezialisierte Umgebungen hinzu
- **📄 Docker Compose**: Schlägt automatisch ein docker-compose.yml für komplexe Anwendungen vor
- **🎨 Modernes UI**: Saubere, responsive Oberfläche mit Monaco-Editor für Syntaxhervorhebung
- **📱 Mobilfreundlich**: Funktioniert nahtlos auf Desktop- und Mobilgeräten

## 🚀 Schnellstart

### Voraussetzungen

- Python 3.9 oder höher
- Git
- OpenAI API-Schlüssel

### Installation

1. **Repository klonen:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Abhängigkeiten installieren:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Umgebungsvariablen einrichten:**
   ```bash
   # .env-Datei erstellen
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **Anwendung starten:**
   ```bash
   python app.py
   ```

5. **Browser öffnen:**
   Navigiere zu `http://localhost:8000`

## 🛠️ Funktionsweise

1. **URL-Verarbeitung**: Greife auf jedes Repository zu, indem du 'github.com' durch 'gitcontainer.com' in der URL ersetzt
2. **Repository-Klonen**: Gitcontainer klont das GitHub-Repository lokal mit Git
3. **Code-Analyse**: Nutzt [gitingest](https://github.com/cyclotruc/gitingest), um die Repository-Struktur zu analysieren und relevante Informationen zu extrahieren
4. **KI-Generierung**: Sendet die Analyse an OpenAI GPT-4 mit spezialisierten Prompts zur Dockerfile-Generierung
5. **Intelligente Optimierung**: Die KI berücksichtigt:
   - Erkennung des Technologiestacks
   - Abhängigkeitsmanagement
   - Sicherheits-Best-Practices
   - Multi-Stage-Builds, wenn sinnvoll
   - Port-Konfiguration
   - Umgebungsvariablen
   - Health-Checks

## 📁 Projektstruktur

```
cyclotruc-gitcontainer/
├── app.py                 # Hauptanwendung (FastAPI)
├── requirements.txt       # Python-Abhängigkeiten
├── .env                  # Umgebungsvariablen (diese erstellen)
├── static/               # Statische Assets (Icons, CSS)
├── templates/
│   └── index.jinja       # Haupt-HTML-Template
└── tools/                # Module mit Kernfunktionalität
    ├── __init__.py
    ├── create_container.py  # KI-Dockerfile-Generierung
    ├── git_operations.py    # Klonen von GitHub-Repositories
    └── gitingest.py        # Repository-Analyse
```
## 🔧 Konfiguration

### Umgebungsvariablen

| Variable | Beschreibung | Erforderlich |
|----------|--------------|--------------|
| `OPENAI_API_KEY` | Dein OpenAI API-Schlüssel | Ja |
| `PORT` | Server-Port (Standard: 8000) | Nein |
| `HOST` | Server-Host (Standard: 0.0.0.0) | Nein |

### Erweiterte Nutzung

Du kannst die Tools programmatisch verwenden:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Repository klonen
    clone_result = await clone_repo_tool(github_url)
    
    # Mit gitingest analysieren
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Dockerfile generieren
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Verwendung
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Anpassung

### Hinzufügen benutzerdefinierter Anweisungen

Nutze die Funktion „Zusätzliche Anweisungen“, um die Generierung anzupassen:

- `"Verwende Alpine Linux für kleinere Image-Größe"`
- `"Füge Redis und PostgreSQL hinzu"`
- `"Für Produktionseinsatz optimieren"`
- `"Entwicklungstools zum Debuggen hinzufügen"`

## 📝 Lizenz

Dieses Projekt steht unter der MIT-Lizenz – siehe die [LICENSE](LICENSE) Datei für Details.

## 🙏 Danksagungen

- **[OpenAI](https://openai.com/)** für die Bereitstellung der GPT-4 API
- **[gitingest](https://github.com/cyclotruc/gitingest)** für die Repository-Analyse-Funktionen
- **[FastAPI](https://fastapi.tiangolo.com/)** für das ausgezeichnete Web-Framework
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** für Syntax-Highlighting im Code

## 🔗 Links

- **GitHub Repository**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**: Probiere es live mit Beispiel-Repositories aus
- **Issues**: [Fehler melden oder Funktionen anfordern](https://github.com/cyclotruc/gitcontainer/issues)

---

**Erstellt mit ❤️ von [Romain Courtois](https://github.com/cyclotruc)**

*Verwandle jedes Repository in Sekunden in einen Container!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---