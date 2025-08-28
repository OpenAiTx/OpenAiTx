
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# Verbesserter PubChem MCP-Server für KI-Assistenten

🧪 Ein fortschrittlicher, robuster und datenschutzorientierter MCP-Server, der KI-Assistenten ermöglicht, intelligent nach chemischen Verbindungen in PubChem zu suchen und darauf zuzugreifen.

Dieser PubChem MCP-Server dient als leistungsstarke Schnittstelle zwischen KI-Assistenten (wie denen in AnythingLLM) und der umfangreichen chemischen Datenbank von PubChem. Er nutzt das Model Context Protocol (MCP), damit KI-Modelle intelligente, widerstandsfähige Suchanfragen nach chemischen Verbindungen durchführen und deren detaillierte Eigenschaften programmatisch abrufen können.

---

## ✨ Hauptfunktionen

Dies ist nicht einfach ein weiterer PubChem-Wrapper. Der Server wurde komplett neu entwickelt, um besonders robust und intelligent zu sein:

-   **🧠 Intelligente Fallback-Suche**: Schlägt eine Suche nach einem gebräuchlichen Namen (wie „Vitamin D“) fehl, führt der Server automatisch eine tiefere Suche in der PubChem Substance-Datenbank durch, um die richtige Verbindung zu finden. Das erhöht die Erfolgsrate bei unklaren Anfragen erheblich.
-   **🛡️ Robuste Fehlerbehandlung & Wiederholungen**: Der Server ist darauf ausgelegt, API-Fehler elegant zu bewältigen. Tritt ein „Server Busy“-Fehler von PubChem auf, wartet er automatisch und wiederholt die Anfrage, damit Ihre Suchanfragen auch bei hoher Last erfolgreich sind.
-   **🔒 Optionale Tor-Proxy-Unterstützung**: Sie haben volle Kontrolle über Ihre Privatsphäre. Eine einfache `config.ini`-Datei ermöglicht es Ihnen, alle Anfragen über das Tor-Netzwerk (per SOCKS5- oder HTTP-Proxy) zu leiten, sodass Ihre IP-Adresse nicht preisgegeben wird. Der Server ist standardmäßig sicher und wird Ihre IP **niemals** weitergeben, falls die Proxy-Verbindung fehlschlägt.
-   **🔎 Einzel- & Mehrfachverbindungssuche**: Bearbeitet nahtlos Anfragen für eine oder mehrere Verbindungen in einem einzigen Prompt.
-   **🧪 Detaillierte Eigenschaftsabfrage**: Zugriff auf wichtige chemische Eigenschaften wie IUPAC-Name, Molekülformel, Molekülgewicht und insbesondere **Monoisotopische Masse**.

---

---

### 🚀 Keine Installation erforderlich: Testen Sie es live auf Smithery.ai

Für diejenigen, die mit MCP-Servern noch nicht vertraut sind oder die Fähigkeiten dieses Tools ohne lokale Einrichtung testen möchten, steht eine Live-Version auf Smithery.ai zur Verfügung. Damit können Sie direkt im Browser mit dem Agenten chatten.

[**<-- Entdecken Sie den Live-PubChem-Agenten auf Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**So starten Sie:**

1.  Klicken Sie auf den obigen Link, um zur Server-Seite zu gelangen.
2.  Melden Sie sich mit Ihrem **GitHub**- oder **Google**-Konto an.
3.  Klicken Sie auf die Schaltfläche **"Explore capabilities"**, um die Chat-Oberfläche zu öffnen und zu testen!

> **✅ Empfohlene Modelle für beste Ergebnisse**
>
> Um die höchste Genauigkeit zu erzielen, insbesondere bei langen Dezimalzahlen, empfehlen wir nachdrücklich die Verwendung leistungsstarker Modelle. Die folgenden wurden getestet und funktionieren hervorragend mit diesem Tool:
>
> *   **Claude 3 Sonnet von Anthropic**
> *   **OpenAIs GPT-4 Turbo** (oder neuere Versionen wie GPT-4o)
>
> Wir haben bestätigt, dass beide Modelle die volle Präzision der vom Tool zurückgegebenen Dezimalzahlen korrekt verarbeitet haben, ohne jegliches Runden.

---

## 🚀 Schnellstart & Installation

Dieser Server ist dafür ausgelegt, lokal ausgeführt zu werden, entweder auf Ihrem Desktop oder innerhalb der AnythingLLM Docker-Umgebung.

### 1. Abhängigkeiten

Dieses Projekt benötigt einige Python-Bibliotheken. Stellen Sie sicher, dass sie in Ihrer Umgebung installiert sind.

Erstellen Sie eine `requirements.txt`-Datei mit folgendem Inhalt:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```
Installieren Sie sie mit `uv` oder `pip`:

```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Hinweis: `PySocks` wird nur benötigt, wenn Sie die Tor SOCKS5-Proxy-Funktion verwenden möchten.)*

### 2. Konfiguration

Der Server wird über eine `config.ini`-Datei konfiguriert, die **automatisch erstellt** wird, wenn Sie ihn das erste Mal ausführen. Diese Datei erscheint im gleichen Verzeichnis wie das Skript `pubchem_server.py`.

**Standard-`config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Integration mit AnythingLLM

Folgen Sie der offiziellen Dokumentation, um dies als benutzerdefinierten MCP-Server hinzuzufügen. Der entscheidende Punkt ist, den `command` auf Ihr Python-Programm und das Skript `pubchem_server.py` zu verweisen.

**Beispiel für AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Implementierungsbeispiele mit AnythingLLM

Hier sind einige Beispiele dafür, wie man mit dem Agenten interagiert. Diese Tests wurden mit AnythingLLM Desktop durchgeführt, wobei verschiedene Large Language Models über OpenRouter verbunden wurden.

Ein entscheidender Befund aus unseren Tests ist die Bedeutung des gewählten Modells. Wir **raten dringend davon ab, kleine oder lokale Modelle** für diese Aufgabe zu verwenden. Kleinere Modelle haben oft Schwierigkeiten, die vom Tool zurückgegebenen Daten korrekt zu parsen, was zu Fehlern wie halluzinierten Werten, falscher Formatierung oder, am kritischsten, **dem Runden von Dezimalzahlen** führt, was den Zweck dieses hochpräzisen Tools zunichtemacht.

Um die Integrität Ihrer Ergebnisse zu gewährleisten, ist es immer eine gute Praxis, die Rohdaten zu überprüfen, die vom MCP zurückgegeben werden. Wie Sie dies tun können, erfahren Sie im nächsten Abschnitt: [3.2 Überprüfung der MCP-Ausgaben in den Logs](#32-how-to-verify-mcp-outputs-in-the-logs).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

Andererseits haben mehrere Modelle eine hervorragende Leistung gezeigt. Wir erzielten herausragende Ergebnisse mit **Googles `Gemini 2.5 Flash lite`**. zeigte bemerkenswerte Präzision im Umgang mit langen Dezimalzahlen und bei der korrekten Formatierung der finalen Markdown-Tabelle.

Google Gemini 2.5 Flash lite ohne Prompt und mit Prompt behält perfekte Dezimalzahlen (im Beispiel wurde eine Temperatur von 0,6 verwendet)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Für diese spezifische Aufgabe ist mein persönlicher Favorit **`Gemini 2.5 Flash lite`**, da es durchgehend Genauigkeit und Zuverlässigkeit bietet.

### 3.2 Überprüfung der MCP-Ausgaben in den Logs

Die beste Möglichkeit, zu bestätigen, dass der Agent die richtigen Daten erhält und das LLM keine Fehler macht, besteht darin, die Debug-Logdatei zu überprüfen, die vom MCP-Server erzeugt wird.

Dieser Server ist so konfiguriert, dass er automatisch eine Logdatei in einem Unterordner Ihres Projektverzeichnisses erstellt. Der Speicherort wird sein:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

Im Inneren von `mcp_debug.log` finden Sie die exakten JSON-Daten, die das Tool an das LLM zurücksendet, *bevor* das Modell sie verarbeitet. Sie können dieses JSON manuell überprüfen, um beliebige Werte zu verifizieren, insbesondere lange Dezimalzahlen von Eigenschaften wie `monoisotopic_mass`, und sicherstellen, dass das LLM in seiner endgültigen Antwort keine Rundungsfehler oder Halluzinationen eingeführt hat.

---

## 📊 Verwendung

Nach der Integration verwendet Ihr KI-Assistent dieses Tool automatisch, wenn nach chemischen Informationen gefragt wird. Das Hauptwerkzeug, das bereitgestellt wird, ist `search_compounds_by_name`.

### Beispiel-Prompt

Dieser Prompt demonstriert die Fähigkeit des Tools, eine Liste von Verbindungen mit unterschiedlichen Namensarten zu verarbeiten und mehrere Eigenschaften abzurufen.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

Der Agent wird das Tool `search_compounds_by_name` aufrufen, das jeden Wirkstoff intelligent findet, die zugehörigen Daten abruft und sie an das LLM zur Formatierung zurückgibt.

---

## 🛠 MCP-Tool freigelegt

### `search_compounds_by_name`

Sucht nacheinander nach mehreren Wirkstoffen anhand des Namens, wobei eine intelligente Fallback-Strategie mit Pausen und Wiederholungen für maximale Zuverlässigkeit eingesetzt wird.

**Parameter:**
-   `names` (List[str]): Eine Liste von Wirkstoffnamen. Beispiel: `["Aspirin", "Ibuprofen"]`

**Rückgabe:** Eine Liste von Wörterbüchern, wobei jedes Wörterbuch entweder die gefundenen Informationen zum Wirkstoff oder eine Fehlermeldung enthält, die erklärt, warum die Suche für diesen spezifischen Wirkstoff fehlgeschlagen ist.

---

## 🙏 Danksagungen

Dieses Projekt wurde stark inspiriert von und basiert auf dem Original [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server), erstellt von **JackKuo666**.

Auch wenn dieses Repository kein direkter Fork ist, war das Originalprojekt der entscheidende Ausgangspunkt. Diese Version erweitert das ursprüngliche Konzept mit Fokus auf extreme Robustheit, intelligente Suchstrategien und den Schutz der Nutzerprivatsphäre durch optionale Tor-Integration 🧅.

Vielen Dank an den Originalautor für seine großartige Arbeit und dafür, dass er sie mit der Community geteilt hat.

---

## ⚠️ Haftungsausschluss

Dieses Tool ist für Forschungs- und Bildungszwecke gedacht. Bitte respektieren Sie die Nutzungsbedingungen von PubChem und verwenden Sie dieses Tool verantwortungsvoll.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---