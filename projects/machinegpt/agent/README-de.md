![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

Ein leistungsstarkes, eigenständiges Python-AI-Agent-Framework, das das OpenAI Python SDK nutzt, um natürlichsprachliche Befehle zu interpretieren, Code dynamisch zu generieren und auszuführen sowie seine Laufzeitumgebung ohne Reibungsverluste zu verwalten. Es bietet automatisierte Abhängigkeitsinstallation, sichere Umgebungskonfiguration, strukturiertes Logging und eine minimalistische Plugin-Schnittstelle zur Einbettung leistungsstarker Python-Tools – alles unter der permissiven Apache 2.0-Lizenz.

## ⭐ Sternverlauf

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 Umgebungseinrichtung

### Python Virtual Environment
Vor der Einrichtung des Projekts wird empfohlen, eine virtuelle Umgebung zu erstellen. Befolgen Sie diese Schritte:

Erfahren Sie mehr über virtuelle Umgebungen: [Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

Erstellen und aktivieren Sie eine virtuelle Umgebung:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### Projekteinstellung
Für dieses Projekt wird ein OpenAI-API-Schlüssel benötigt. Um diesen bereitzustellen, erstellen Sie eine .env-Datei im Stammverzeichnis mit folgendem Inhalt:
```
OPENAI_API_KEY=
```
Alternativ können Sie die bereitgestellte .env.example-Datei kopieren und den Schlüssel aktualisieren:
```
cp .env.example .env
```

## 🧠 Start
Um den Agenten zu starten, führen Sie einfach Folgendes aus:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ Beiträge

Beiträge, Vorschläge, Fehlerberichte und Korrekturen sind willkommen!

Für neue Funktionen, Komponenten oder Erweiterungen eröffnen Sie bitte ein Issue und diskutieren Sie, bevor Sie einen PR senden.

## 💖 Dieses Projekt existiert in seinem aktuellen Zustand dank aller Menschen, die dazu beitragen
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---