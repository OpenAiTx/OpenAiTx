# AgenticSeek: Private, lokale Manus-Alternative.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Eine **100% lokale Alternative zu Manus AI**, dieser sprachgesteuerte KI-Assistent durchsucht autonom das Web, schreibt Code und plant Aufgaben, während alle Daten auf Ihrem Gerät bleiben. Entwickelt für lokale Reasoning-Modelle läuft er vollständig auf Ihrer eigenen Hardware, gewährleistet vollständige Privatsphäre und keinerlei Cloud-Abhängigkeit.*

[![Visit AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Warum AgenticSeek?

* 🔒 Vollständig lokal & privat – Alles läuft auf Ihrem Computer — keine Cloud, keine Datenweitergabe. Ihre Dateien, Unterhaltungen und Suchanfragen bleiben privat.

* 🌐 Intelligentes Web-Browsing – AgenticSeek kann das Internet selbstständig durchsuchen — suchen, lesen, Informationen extrahieren, Webformulare ausfüllen — komplett freihändig.

* 💻 Autonomer Coding-Assistent – Brauchen Sie Code? Er kann Programme in Python, C, Go, Java und mehr schreiben, debuggen und ausführen — ganz ohne Aufsicht.

* 🧠 Intelligente Agenten-Auswahl – Sie fragen, er findet automatisch den besten Agenten für die Aufgabe. Wie ein Expertenteam, das bereit ist zu helfen.

* 📋 Plant & führt komplexe Aufgaben aus – Von Reiseplanung bis zu komplexen Projekten — er kann große Aufgaben in Schritte unterteilen und mit mehreren KI-Agenten erledigen.

* 🎙️ Sprachsteuerung – Klare, schnelle und futuristische Sprach-zu-Text- und Text-zu-Sprache-Funktionen, die es ermöglichen, mit ihm zu sprechen, als wäre er Ihr persönlicher KI-Assistent aus einem Sci-Fi-Film. (In Entwicklung)

### **Demo**

> *Kannst du nach dem agenticSeek-Projekt suchen, herausfinden, welche Fähigkeiten benötigt werden, dann die Datei CV_candidates.zip öffnen und mir anschließend mitteilen, welche am besten zum Projekt passen?*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Hinweis: Diese Demo sowie alle darin erscheinenden Dateien (z. B. CV_candidates.zip) sind vollständig fiktiv. Wir sind kein Unternehmen, sondern suchen Open-Source-Mitwirkende, keine Bewerber.

> 🛠⚠️️ **Aktive Entwicklung**

> 🙏 Dieses Projekt begann als Nebenprojekt und hat weder eine Roadmap noch Finanzierung. Es ist viel größer geworden als erwartet und landete in GitHub Trending. Beiträge, Feedback und Geduld sind sehr willkommen.

## Voraussetzungen

Bevor Sie beginnen, stellen Sie sicher, dass folgende Software installiert ist:

*   **Git:** Zum Klonen des Repositories. [Git herunterladen](https://git-scm.com/downloads)
*   **Python 3.10.x:** Wir empfehlen nachdrücklich die Python-Version 3.10.x zu verwenden. Andere Versionen können zu Abhängigkeitsfehlern führen. [Python 3.10 herunterladen](https://www.python.org/downloads/release/python-3100/) (Wählen Sie eine 3.10.x-Version).
*   **Docker Engine & Docker Compose:** Zum Ausführen gebündelter Dienste wie SearxNG.
    *   Installieren Sie Docker Desktop (enthält Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Alternativ können Sie Docker Engine und Docker Compose unter Linux separat installieren: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (Stellen Sie sicher, dass Compose V2 installiert ist, z. B. `sudo apt-get install docker-compose-plugin`).

### 1. **Repository klonen und Setup**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Inhalt der .env-Datei anpassen

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

Aktualisieren Sie die `.env`-Datei nach Bedarf mit Ihren eigenen Werten:

- **SEARXNG_BASE_URL**: Unverändert lassen
- **REDIS_BASE_URL**: Unverändert lassen
- **WORK_DIR**: Pfad zu Ihrem Arbeitsverzeichnis auf Ihrem lokalen Rechner. AgenticSeek kann diese Dateien lesen und mit ihnen interagieren.
- **OLLAMA_PORT**: Portnummer für den Ollama-Dienst.
- **LM_STUDIO_PORT**: Portnummer für den LM Studio-Dienst.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Port für einen zusätzlichen benutzerdefinierten LLM-Dienst.

**API-Keys sind völlig optional für Nutzer, die LLM lokal ausführen. Das ist der Hauptzweck dieses Projekts. Lassen Sie die Felder leer, wenn Sie über ausreichend Hardware verfügen.**

### 3. **Docker starten**

Stellen Sie sicher, dass Docker auf Ihrem System installiert und gestartet ist. Sie können Docker mit folgenden Befehlen starten:

- **Unter Linux/macOS:**  
    Öffnen Sie ein Terminal und führen Sie aus:
    ```sh
    sudo systemctl start docker
    ```
    Oder starten Sie Docker Desktop über das Anwendungsmenü, falls installiert.

- **Unter Windows:**  
    Starten Sie Docker Desktop über das Startmenü.

Sie können überprüfen, ob Docker läuft, indem Sie folgenden Befehl ausführen:
```sh
docker info
```
Wenn Sie Informationen zu Ihrer Docker-Installation sehen, läuft Docker korrekt.

Eine Zusammenfassung finden Sie in der Tabelle der [lokalen Anbieter](#list-of-local-providers) unten.

Nächster Schritt: [AgenticSeek lokal ausführen](#start-services-and-run)

*Siehe den Abschnitt [Fehlerbehebung](#troubleshooting), falls Sie Probleme haben.*
*Wenn Ihre Hardware keine lokalen LLMs ausführen kann, siehe [Setup zur Nutzung mit einer API](#setup-to-run-with-an-api).*
*Für detaillierte Erklärungen zu `config.ini`, siehe [Config-Abschnitt](#config).*

---

## Setup zum lokalen Ausführen von LLM auf Ihrem Rechner

**Hardware-Anforderungen:**

Um LLMs lokal auszuführen, benötigen Sie entsprechende Hardware. Mindestens eine GPU, die Magistral, Qwen oder Deepseek 14B ausführen kann, ist erforderlich. Siehe FAQ für detaillierte Modell-/Performance-Empfehlungen.

**Lokalen Anbieter einrichten**  

Starten Sie Ihren lokalen Anbieter, zum Beispiel mit ollama:

```sh
ollama serve
```

Eine Liste der unterstützten lokalen Anbieter finden Sie unten.

**config.ini aktualisieren**

Passen Sie die config.ini-Datei an, um provider_name auf einen unterstützten Anbieter und provider_model auf ein von Ihrem Anbieter unterstütztes LLM zu setzen. Wir empfehlen Reasoning-Modelle wie *Magistral* oder *Deepseek*.

Siehe **FAQ** am Ende des README für benötigte Hardware.

```sh
[MAIN]
is_local = True # Ob Sie lokal oder mit Remote-Anbieter arbeiten.
provider_name = ollama # oder lm-studio, openai, etc..
provider_model = deepseek-r1:14b # Wählen Sie ein Modell, das zu Ihrer Hardware passt
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # Name Ihrer KI
recover_last_session = True # Ob die letzte Sitzung wiederhergestellt werden soll
save_session = True # Ob die aktuelle Sitzung gespeichert werden soll
speak = False # Text zu Sprache
listen = False # Sprache zu Text, nur für CLI, experimentell
jarvis_personality = False # Ob eine „Jarvis“-ähnliche Persönlichkeit genutzt werden soll (experimentell)
languages = en zh # Liste der Sprachen, Text zu Sprache nutzt standardmäßig die erste auf der Liste
[BROWSER]
headless_browser = True # Unverändert lassen, außer bei Nutzung von CLI auf dem Host.
stealth_mode = True # Nutze undetected selenium zur Reduzierung der Browser-Erkennung
```

**Warnung**:

- Das Format der `config.ini`-Datei unterstützt keine Kommentare. 
Kopieren Sie NICHT die Beispiel-Konfiguration direkt, da Kommentare zu Fehlern führen. Passen Sie die `config.ini` manuell mit Ihren gewünschten Einstellungen an – ohne Kommentare.

- Setzen Sie *NICHT* provider_name auf `openai`, wenn Sie LM-studio zum Ausführen von LLMs verwenden. Setzen Sie es stattdessen auf `lm-studio`.

- Einige Anbieter (z. B. lm-studio) erfordern, dass Sie `http://` vor die IP-Adresse setzen. Zum Beispiel `http://127.0.0.1:1234`

**Liste lokaler Anbieter**

| Anbieter   | Lokal? | Beschreibung                                               |
|------------|--------|------------------------------------------------------------|
| ollama     | Ja     | Führen Sie LLMs lokal einfach mit ollama als LLM-Anbieter aus |
| lm-studio  | Ja     | Führen Sie LLM lokal mit LM Studio aus (setze `provider_name` auf `lm-studio`)|
| openai     | Ja     |  Nutzung einer OpenAI-kompatiblen API (z. B. llama.cpp server)  |

Nächster Schritt: [Dienste starten und AgenticSeek ausführen](#Start-services-and-Run)  

*Siehe den Abschnitt [Fehlerbehebung](#troubleshooting), falls Sie Probleme haben.*
*Wenn Ihre Hardware keine lokalen LLMs ausführen kann, siehe [Setup zur Nutzung mit einer API](#setup-to-run-with-an-api).*
*Für detaillierte Erklärungen zu `config.ini`, siehe [Config-Abschnitt](#config).*

## Setup zur Nutzung mit einer API

Dieses Setup verwendet externe, cloudbasierte LLM-Anbieter. Sie benötigen einen API-Key von Ihrem gewählten Dienst.

**1. Wählen Sie einen API-Anbieter und erhalten Sie einen API-Key:**

Siehe [Liste der API-Anbieter](#list-of-api-providers) unten. Besuchen Sie deren Websites, um sich zu registrieren und einen API-Key zu erhalten.

**2. Setzen Sie Ihren API-Key als Umgebungsvariable:**


*   **Linux/macOS:**
    Öffnen Sie Ihr Terminal und verwenden Sie den Befehl `export`. Am besten fügen Sie diesen Befehl in die Profil-Datei Ihrer Shell ein (z. B. `~/.bashrc`, `~/.zshrc`) für dauerhafte Speicherung.
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # Ersetzen Sie PROVIDER_API_KEY durch den spezifischen Variablennamen, z. B. OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Beispiel für TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Eingabeaufforderung (temporär für aktuelle Sitzung):**
    ```cmd
    set PROVIDER_API_KEY=dein_api_schlüssel_hier
    ```
*   **PowerShell (temporär für aktuelle Sitzung):**
    ```powershell
    $env:PROVIDER_API_KEY="dein_api_schlüssel_hier"
    ```
*   **Permanent:** Suche nach „Umgebungsvariablen“ in der Windows-Suchleiste, klicke auf „Systemumgebungsvariablen bearbeiten“ und dann auf die Schaltfläche „Umgebungsvariablen...“. Füge eine neue Benutzervariable mit dem passenden Namen (z. B. `OPENAI_API_KEY`) und deinem Schlüssel als Wert hinzu.

*(Siehe FAQ: [Wie setze ich API-Schlüssel?](#how-do-i-set-api-keys) für weitere Details).*


**3. Aktualisiere `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # Oder google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Oder gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 etc.
provider_server_address = # Wird typischerweise ignoriert oder kann leer bleiben, wenn is_local = False für die meisten APIs
# ... andere Einstellungen ...
```
*Warnung:* Stelle sicher, dass keine Leerzeichen am Ende der Werte in der `config.ini` stehen.

**Liste der API-Anbieter**

| Anbieter     | `provider_name` | Lokal? | Beschreibung                                      | API-Schlüssel-Link (Beispiele)                       |
|--------------|-----------------|--------|---------------------------------------------------|------------------------------------------------------|
| OpenAI       | `openai`        | Nein   | Nutzung der ChatGPT-Modelle über die OpenAI-API.  | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini| `google`        | Nein   | Nutzung der Google Gemini-Modelle via Google AI Studio. | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek     | `deepseek`      | Nein   | Nutzung von Deepseek-Modellen über deren API.      | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face | `huggingface`   | Nein   | Nutzung von Modellen der Hugging Face Inference API. | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI   | `togetherAI`    | Nein   | Nutzung verschiedener Open-Source-Modelle über TogetherAI API. | [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Hinweis:*
*   Wir raten davon ab, `gpt-4o` oder andere OpenAI-Modelle für komplexes Web-Browsing und Aufgabenplanung zu verwenden, da die aktuellen Prompt-Optimierungen auf Modelle wie Deepseek ausgerichtet sind.
*   Coding-/Bash-Aufgaben könnten mit Gemini auf Probleme stoßen, da das Modell eventuell Formatierungsanweisungen, die für Deepseek optimiert sind, nicht strikt befolgt.
*   Die `provider_server_address` in `config.ini` wird generell nicht verwendet, wenn `is_local = False`, da der API-Endpunkt in der Regel in der jeweiligen Provider-Bibliothek fest hinterlegt ist.

Nächster Schritt: [Dienste starten und AgenticSeek ausführen](#Start-services-and-Run)

*Siehe den Abschnitt **Bekannte Probleme**, falls du auf Schwierigkeiten stößt.*

*Siehe den Abschnitt **Config** für eine ausführliche Erklärung der Konfigurationsdatei.*

---

## Dienste starten und AgenticSeek ausführen

Standardmäßig läuft AgenticSeek vollständig in Docker.

Starte die benötigten Dienste. Dies startet alle Dienste aus der docker-compose.yml, einschließlich:
    - searxng
    - redis (benötigt von searxng)
    - frontend
    - backend (bei Nutzung von `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Windows
```

**Warnung:** Dieser Schritt lädt und startet alle Docker-Images, was bis zu 30 Minuten dauern kann. Warte nach dem Starten der Dienste, bis der Backend-Dienst vollständig läuft (du solltest **backend: "GET /health HTTP/1.1" 200 OK** im Log sehen), bevor du Nachrichten sendest. Das Backend kann beim ersten Start bis zu 5 Minuten benötigen.

Gehe zu `http://localhost:3000/` – dort solltest du die Weboberfläche sehen.

*Fehlerbehebung beim Dienststart:* Wenn diese Skripte fehlschlagen, stelle sicher, dass die Docker Engine läuft und Docker Compose (V2, `docker compose`) korrekt installiert ist. Überprüfe die Ausgaben im Terminal auf Fehlermeldungen. Siehe [FAQ: Hilfe! Ich erhalte einen Fehler beim Ausführen von AgenticSeek oder dessen Skripten.](#faq-troubleshooting)

**Optional:** Auf dem Host ausführen (CLI-Modus):

Um die CLI-Oberfläche zu nutzen, musst du das Paket auf dem Host installieren:

```sh
./install.sh
./install.bat # Windows
```

Dienste starten:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Windows
```

Nutze die CLI: `python3 cli.py`


---

## Nutzung

Stelle sicher, dass die Dienste mit `./start_services.sh full` laufen und öffne `localhost:3000` für die Weboberfläche.

Du kannst auch Sprache-zu-Text nutzen, indem du `listen = True` in der config aktivierst. Nur im CLI-Modus verfügbar.

Um zu beenden, sage oder tippe einfach `goodbye`.

Hier einige Anwendungsbeispiele:

> *Erstelle ein Snake-Spiel in Python!*

> *Durchsuche das Web nach den besten Cafés in Rennes, Frankreich, und speichere drei mit Adresse in rennes_cafes.txt.*

> *Schreibe ein Go-Programm, das die Fakultät einer Zahl berechnet, und speichere es als factorial.go in deinem Arbeitsbereich.*

> *Durchsuche meinen summer_pictures-Ordner nach allen JPG-Dateien, benenne sie mit dem heutigen Datum um und speichere eine Liste der umbenannten Dateien in photos_list.txt.*

> *Suche online nach beliebten Sci-Fi-Filmen aus 2024 und wähle drei für heute Abend aus. Speichere die Liste in movie_night.txt.*

> *Durchsuche das Web nach den neuesten KI-Nachrichtenartikeln aus 2025, wähle drei aus und schreibe ein Python-Skript, das deren Titel und Zusammenfassungen extrahiert. Speichere das Skript als news_scraper.py und die Zusammenfassungen in ai_news.txt im Verzeichnis /home/projects.*

> *Suche am Freitag im Web nach einer kostenlosen Aktienkurs-API, registriere dich mit supersuper7434567@gmail.com und schreibe dann ein Python-Skript, das täglich die Preise von Tesla abruft und die Ergebnisse in stock_prices.csv speichert.*

*Beachte, dass das Ausfüllen von Formularen noch experimentell ist und fehlschlagen kann.*



Nachdem du deine Anfrage eingegeben hast, weist AgenticSeek den am besten geeigneten Agenten für die Aufgabe zu.

Da dies ein frühes Prototypstadium ist, kann es sein, dass das Agenten-Routing-System nicht immer den passenden Agenten basierend auf deiner Anfrage auswählt.

Daher solltest du sehr explizit formulieren, was du möchtest und wie die KI vorgehen soll. Wenn du beispielsweise eine Websuche möchtest, sage nicht:

`Kennst du gute Länder für Solo-Reisen?`

Sondern frage:

`Führe eine Websuche durch und finde heraus, welche Länder sich am besten für Solo-Reisen eignen`

---

## **Setup zur Ausführung des LLM auf deinem eigenen Server**  

Wenn du einen leistungsfähigen Computer oder Server hast, den du nutzen möchtest, aber von deinem Laptop aus darauf zugreifen willst, kannst du das LLM auf einem entfernten Server mit unserem eigenen LLM-Server ausführen.

Auf deinem „Server“, der das KI-Modell ausführen soll, ermittle die IP-Adresse:

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # lokale IP
curl https://ipinfo.io/ip # öffentliche IP
```

Hinweis: Für Windows oder macOS nutze jeweils ipconfig oder ifconfig, um die IP-Adresse zu ermitteln.

Klonen das Repository und wechsle in den Ordner `server/`.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Installiere die spezifischen Anforderungen für den Server:

```sh
pip3 install -r requirements.txt
```

Starte das Server-Skript.

```sh
python3 app.py --provider ollama --port 3333
```

Du hast die Wahl zwischen der Nutzung von `ollama` und `llamacpp` als LLM-Service.


Nun auf deinem persönlichen Computer:

Ändere die Datei `config.ini`, setze `provider_name` auf `server` und `provider_model` auf `deepseek-r1:xxb`.
Setze `provider_server_address` auf die IP-Adresse des Rechners, der das Modell ausführt.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


Nächster Schritt: [Dienste starten und AgenticSeek ausführen](#Start-services-and-Run)  

---

## Sprache-zu-Text

Achtung: Sprache-zu-Text funktioniert derzeit nur im CLI-Modus.

Beachte, dass Sprache-zu-Text aktuell nur auf Englisch funktioniert.

Die Sprache-zu-Text-Funktion ist standardmäßig deaktiviert. Um sie zu aktivieren, setze die Option listen in der config.ini-Datei auf True:

```
listen = True
```

Wenn aktiviert, wartet die Sprache-zu-Text-Funktion auf ein Auslöse-Schlüsselwort, das der Name des Agenten ist, bevor deine Eingabe verarbeitet wird. Du kannst den Namen des Agenten anpassen, indem du den Wert `agent_name` in der *config.ini* aktualisierst:

```
agent_name = Friday
```

Für eine optimale Erkennung empfehlen wir, einen geläufigen englischen Namen wie „John“ oder „Emma“ als Agentennamen zu verwenden.

Sobald das Transkript angezeigt wird, sagen Sie den Namen des Agenten laut, um ihn zu aktivieren (z.B. „Friday“).

Sprechen Sie Ihre Anfrage deutlich aus.

Beenden Sie Ihre Anfrage mit einer Bestätigungsphrase, um das System zum Fortfahren zu veranlassen. Beispiele für Bestätigungsphrasen sind:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Config

Beispiel-Konfiguration:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Beispiel für Ollama; benutze http://127.0.0.1:1234 für LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Liste der Sprachen für TTS und ggf. Routing.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Erklärung der `config.ini`-Einstellungen**:

*   **`[MAIN]` Abschnitt:**
    *   `is_local`: `True`, wenn ein lokaler LLM-Provider verwendet wird (Ollama, LM-Studio, lokaler OpenAI-kompatibler Server) oder die selbst gehostete Server-Option. `False`, wenn eine Cloud-basierte API (OpenAI, Google, etc.) verwendet wird.
    *   `provider_name`: Gibt den LLM-Provider an.
        *   Lokale Optionen: `ollama`, `lm-studio`, `openai` (für lokale OpenAI-kompatible Server), `server` (für das selbst gehostete Server-Setup).
        *   API-Optionen: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: Der spezifische Modellname oder die ID für den gewählten Provider (z.B. `deepseekcoder:6.7b` für Ollama, `gpt-3.5-turbo` für die OpenAI-API, `mistralai/Mixtral-8x7B-Instruct-v0.1` für TogetherAI).
    *   `provider_server_address`: Die Adresse Ihres LLM-Providers.
        *   Für lokale Provider: z.B. `http://127.0.0.1:11434` für Ollama, `http://127.0.0.1:1234` für LM-Studio.
        *   Für den `server`-Provider-Typ: Die Adresse Ihres selbst gehosteten LLM-Servers (z.B. `http://your_server_ip:3333`).
        *   Für Cloud-APIs (`is_local = False`): Wird meist ignoriert oder kann leer gelassen werden, da der API-Endpunkt i.d.R. durch die Client-Bibliothek verarbeitet wird.
    *   `agent_name`: Name des KI-Assistenten (z.B. Friday). Wird als Triggerwort für Sprache-zu-Text verwendet, falls aktiviert.
    *   `recover_last_session`: `True`, um den Zustand der vorherigen Sitzung wiederherzustellen, `False` für einen Neustart.
    *   `save_session`: `True`, um den aktuellen Sitzungsstatus für eine mögliche Wiederherstellung zu speichern, sonst `False`.
    *   `speak`: `True`, um Text-zu-Sprache-Sprachausgabe zu aktivieren, `False` zum Deaktivieren.
    *   `listen`: `True`, um Sprache-zu-Text-Eingabe zu aktivieren (nur CLI-Modus), `False` zum Deaktivieren.
    *   `work_dir`: **Wichtig:** Das Verzeichnis, in dem AgenticSeek Dateien liest/schreibt. **Stellen Sie sicher, dass dieser Pfad auf Ihrem System gültig und zugänglich ist.**
    *   `jarvis_personality`: `True` für einen experimentellen, „Jarvis-ähnlichen“ Systemprompt, `False` für den Standardprompt.
    *   `languages`: Kommagetrennte Liste von Sprachen (z.B. `en, zh, fr`). Wird für die Auswahl der TTS-Stimme verwendet (Standard ist die erste) und kann dem LLM-Router helfen. Vermeiden Sie zu viele oder sehr ähnliche Sprachen für die Effizienz des Routers.
*   **`[BROWSER]` Abschnitt:**
    *   `headless_browser`: `True`, um den automatisierten Browser ohne sichtbares Fenster auszuführen (empfohlen für Web-Oberfläche oder nicht-interaktive Nutzung). `False`, um das Browserfenster anzuzeigen (nützlich für CLI-Modus oder Debugging).
    *   `stealth_mode`: `True`, um Maßnahmen zu aktivieren, die die Erkennung von Browserautomatisierung erschweren. Dies kann die manuelle Installation von Browser-Erweiterungen wie anticaptcha erfordern.

Dieser Abschnitt fasst die unterstützten LLM-Provider-Typen zusammen. Konfigurieren Sie diese in der `config.ini`.

**Lokale Provider (laufen auf Ihrer eigenen Hardware):**

| Provider-Name in `config.ini` | `is_local` | Beschreibung                                                                 | Setup-Abschnitt                                                    |
|-------------------------------|------------|-----------------------------------------------------------------------------|--------------------------------------------------------------------|
| `ollama`                      | `True`     | Nutzt Ollama zum Bereitstellen lokaler LLMs.                                | [Setup für lokalen LLM-Betrieb](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | Nutzt LM-Studio zum Bereitstellen lokaler LLMs.                             | [Setup für lokalen LLM-Betrieb](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (für lokalen Server) | `True`     | Verbindung zu lokalem Server mit OpenAI-kompatibler API (z.B. llama.cpp).   | [Setup für lokalen LLM-Betrieb](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | Verbindung zum AgenticSeek-LLM-Server auf einem anderen Rechner.             | [Setup für eigenen LLM-Server](#setup-to-run-the-llm-on-your-own-server) |

**API-Provider (Cloud-basiert):**

| Provider-Name in `config.ini` | `is_local` | Beschreibung                                      | Setup-Abschnitt                                      |
|-------------------------------|------------|--------------------------------------------------|------------------------------------------------------|
| `openai`                      | `False`    | Nutzung der offiziellen OpenAI-API (z.B. GPT-3.5, GPT-4). | [Setup für API-Betrieb](#setup-to-run-with-an-api)         |
| `google`                      | `False`    | Nutzung der Gemini-Modelle von Google via API.    | [Setup für API-Betrieb](#setup-to-run-with-an-api)         |
| `deepseek`                    | `False`    | Nutzung der offiziellen Deepseek-API.             | [Setup für API-Betrieb](#setup-to-run-with-an-api)         |
| `huggingface`                 | `False`    | Nutzung der Hugging Face Inference API.           | [Setup für API-Betrieb](#setup-to-run-with-an-api)         |
| `togetherAI`                  | `False`    | Nutzung der TogetherAI-API für verschiedene Open-Modelle. | [Setup für API-Betrieb](#setup-to-run-with-an-api)         |

---
## Fehlerbehebung

Wenn Sie auf Probleme stoßen, finden Sie in diesem Abschnitt Hilfestellungen.

# Bekannte Probleme

## ChromeDriver-Probleme

**Fehlerbeispiel:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Ursache:** Die installierte ChromeDriver-Version ist nicht kompatibel mit Ihrer Google Chrome-Version.
*   **Lösung:**
    1.  **Chrome-Version prüfen:** Öffnen Sie Google Chrome, gehen Sie zu `Einstellungen > Über Chrome`, um Ihre Version zu finden (z.B. „Version 120.0.6099.110“).
    2.  **Passenden ChromeDriver herunterladen:**
        *   Für Chrome-Versionen 115 und neuer: Gehen Sie zu den [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Finden Sie den "stable"-Kanal und laden Sie den ChromeDriver für Ihr Betriebssystem herunter, der zu Ihrer Chrome-Hauptversion passt.
        *   Für ältere Versionen (seltener): Sie finden diese ggf. auf der Seite [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   Das untenstehende Bild zeigt ein Beispiel von der CfT-Seite:
            ![Download Chromedriver specific version from Chrome for Testing page](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **ChromeDriver installieren:**
        *   Stellen Sie sicher, dass der heruntergeladene `chromedriver` (bzw. `chromedriver.exe` unter Windows) in einem Verzeichnis liegt, das in Ihrer PATH-Umgebungsvariablen aufgeführt ist (z.B. `/usr/local/bin` unter Linux/macOS oder einen eigenen Scripts-Ordner unter Windows).
        *   Alternativ können Sie ihn im Hauptverzeichnis des `agenticSeek`-Projekts ablegen.
        *   Machen Sie den Treiber ausführbar (z.B. `chmod +x chromedriver` unter Linux/macOS).
    4.  Siehe auch den Abschnitt [ChromeDriver-Installation](#chromedriver-installation) im Haupt-Installationsleitfaden für weitere Details.

Wenn dieser Abschnitt unvollständig ist oder Sie auf weitere ChromeDriver-Probleme stoßen, durchsuchen Sie bitte die bestehenden [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) oder erstellen Sie ein neues.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Dies passiert, wenn die Versionen Ihres Browsers und des Chromedrivers nicht übereinstimmen.

Sie müssen die neueste Version herunterladen:

https://developer.chrome.com/docs/chromedriver/downloads

Wenn Sie Chrome Version 115 oder neuer verwenden, gehen Sie zu:

https://googlechromelabs.github.io/chrome-for-testing/

Und laden Sie die zum Betriebssystem passende Chromedriver-Version herunter.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Wenn dieser Abschnitt unvollständig ist, erstellen Sie bitte ein Issue.

##  Probleme mit Connection Adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Hinweis: Port kann variieren)
```

*   **Ursache:** Die `provider_server_address` in der `config.ini` für `lm-studio` (oder andere lokale OpenAI-kompatible Server) fehlt das Präfix `http://` oder sie verweist auf den falschen Port.
*   **Lösung:**
    *   Stellen Sie sicher, dass die Adresse mit `http://` beginnt. LM-Studio verwendet typischerweise `http://127.0.0.1:1234`.
    *   Korrigierte `config.ini`: `provider_server_address = http://127.0.0.1:1234` (oder Ihr tatsächlicher LM-Studio-Server-Port).

## SearxNG-Basis-URL nicht angegeben

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**F: Welche Hardware benötige ich?**  

| Modellgröße | GPU      | Kommentar                                                                                         |
|-------------|----------|--------------------------------------------------------------------------------------------------|
| 7B          | 8 GB VRAM| ⚠️ Nicht empfohlen. Schlechte Performance, häufige Halluzinationen, und Planungsagenten schlagen fehl. |
| 14B         | 12 GB VRAM (z.B. RTX 3060) | ✅ Für einfache Aufgaben nutzbar. Kann bei Web-Browsing und Planung ins Straucheln geraten. |
| 32B         | 24+ GB VRAM (z.B. RTX 4090) | 🚀 Erfolgreich bei den meisten Aufgaben, könnte bei komplexer Planung an Grenzen stoßen.   |
| 70B+        | 48+ GB VRAM| 💪 Exzellent. Empfohlen für fortgeschrittene Anwendungsfälle.                                 |

**F: Ich erhalte einen Fehler – was tun?**  

Stellen Sie sicher, dass lokal ausgeführt wird (`ollama serve`), Ihre `config.ini` zum Provider passt und alle Abhängigkeiten installiert sind. Wenn nichts hilft, gerne ein Issue erstellen.

**F: Kann es wirklich 100% lokal laufen?**  

Ja, mit Ollama, lm-studio oder server-Providern laufen alle Sprachmodelle und TTS/STT-Modelle lokal. Nicht-lokale Optionen (OpenAI oder andere APIs) sind optional.

**F: Warum AgenticSeek nutzen, wenn ich Manus habe?**

Im Gegensatz zu Manus setzt AgenticSeek auf Unabhängigkeit von externen Systemen, bietet mehr Kontrolle, Privatsphäre und vermeidet API-Kosten.

**F: Wer steckt hinter dem Projekt?**

Das Projekt wurde von mir ins Leben gerufen, zusammen mit zwei Freunden, die als Maintainer und Mitwirkende aus der Open-Source-Community auf GitHub agieren. Wir sind einfach eine Gruppe engagierter Leute, kein Startup oder Unternehmen.

Jedes AgenticSeek-Konto auf X außer meinem persönlichen (https://x.com/Martin993886460) ist eine Nachahmung.

## Mitwirken

Wir suchen Entwickler, die AgenticSeek verbessern! Schau dir offene Issues oder Diskussionen an.

[Beitragsleitfaden](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Maintainer:

 > [Fosowl](https://github.com/Fosowl) | Pariser Zeit 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Taipeh Zeit 

 > [steveh8758](https://github.com/steveh8758) | Taipeh Zeit 

## Besonderer Dank:

 > [tcsenpai](https://github.com/tcsenpai) und [plitc](https://github.com/plitc) für die Unterstützung bei der Backend-Dockerisierung

## Sponsoren:

5$ oder mehr monatliche Sponsoren werden hier genannt:
- **tatra-labs**
Certainly! Please provide the content for Part 4 of 4 that you wish to have translated.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---