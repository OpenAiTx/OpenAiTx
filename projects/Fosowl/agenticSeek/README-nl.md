# AgenticSeek: Privé, Lokaal Manus-alternatief.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  Engels | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Portugees (Brazilië)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Spaans](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Een **100% lokaal alternatief voor Manus AI**, deze stemgestuurde AI-assistent doorzoekt autonoom het web, schrijft code en plant taken, terwijl alle data op je apparaat blijft. Speciaal ontworpen voor lokale redeneermodellen, draait volledig op jouw hardware, wat volledige privacy en nul cloud-afhankelijkheid garandeert.*

[![Bezoek AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![Licentie](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Waarom AgenticSeek?

* 🔒 Volledig Lokaal & Privé – Alles draait op jouw machine — geen cloud, geen datadeling. Jouw bestanden, gesprekken en zoekopdrachten blijven privé.

* 🌐 Slimme Webbrowser – AgenticSeek kan zelfstandig internetten — zoeken, lezen, info extraheren, webformulieren invullen — volledig handsfree.

* 💻 Autonome Code-assistent – Code nodig? Schrijft, debugt en voert programma's uit in Python, C, Go, Java en meer — geheel zonder toezicht.

* 🧠 Slimme Agentselectie – Jij vraagt, het kiest automatisch de beste agent voor de taak. Net alsof je een team van experts tot je beschikking hebt.

* 📋 Plant & Voert Complexe Taken Uit – Van reisplanning tot complexe projecten — het splitst grote taken op in stappen en voert deze uit met meerdere AI-agents.

* 🎙️ Stemgestuurd – Schone, snelle, futuristische spraak-naar-tekst en tekst-naar-spraak, zodat je kunt praten alsof het je persoonlijke AI uit een sciencefictionfilm is. (In ontwikkeling)

### **Demo**

> *Kun je zoeken naar het agenticSeek-project, uitzoeken welke vaardigheden vereist zijn, vervolgens het bestand CV_candidates.zip openen en me vertellen welke kandidaten het beste bij het project passen?*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Disclaimer: Deze demo, inclusief alle getoonde bestanden (bijv: CV_candidates.zip), is volledig fictief. Wij zijn geen bedrijf, we zoeken open-source bijdragers, geen kandidaten.

> 🛠⚠️️ **Actief Werk in Uitvoering**

> 🙏 Dit project begon als een zijproject en heeft geen roadmap of financiering. Het is uitgegroeid tot meer dan verwacht en eindigde zelfs in GitHub Trending. Bijdragen, feedback en geduld worden zeer gewaardeerd.

## Vereisten

Voordat je begint, zorg ervoor dat je de volgende software hebt geïnstalleerd:

*   **Git:** Voor het klonen van de repository. [Download Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** We raden sterk aan om Python versie 3.10.x te gebruiken. Andere versies kunnen afhankelijkheidsfouten veroorzaken. [Download Python 3.10](https://www.python.org/downloads/release/python-3100/) (kies een 3.10.x versie).
*   **Docker Engine & Docker Compose:** Voor het draaien van gebundelde diensten zoals SearxNG.
    *   Installeer Docker Desktop (inclusief Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Of installeer Docker Engine en Docker Compose apart op Linux: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (zorg dat je Compose V2 installeert, bijv. `sudo apt-get install docker-compose-plugin`).

### 1. **Kloon de repository en stel in**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Wijzig de inhoud van het .env-bestand

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optioneel'
DEEPSEEK_API_KEY='optioneel'
OPENROUTER_API_KEY='optioneel'
TOGETHER_API_KEY='optioneel'
GOOGLE_API_KEY='optioneel'
ANTHROPIC_API_KEY='optioneel'
```

Werk het `.env`-bestand bij met je eigen waarden waar nodig:

- **SEARXNG_BASE_URL**: Ongewijzigd laten 
- **REDIS_BASE_URL**: Ongewijzigd laten 
- **WORK_DIR**: Pad naar je werkmap op je lokale machine. AgenticSeek kan deze bestanden lezen en ermee werken.
- **OLLAMA_PORT**: Poortnummer voor de Ollama-service.
- **LM_STUDIO_PORT**: Poortnummer voor de LM Studio-service.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Poort voor elke extra custom LLM-service.

**API-sleutels zijn volledig optioneel voor gebruikers die ervoor kiezen om LLM lokaal uit te voeren. Dit is het primaire doel van dit project. Laat leeg als je over voldoende hardware beschikt**

### 3. **Start Docker**

Zorg dat Docker is geïnstalleerd en actief op je systeem. Je kunt Docker starten met de volgende commando's:

- **Op Linux/macOS:**  
    Open een terminal en voer uit:
    ```sh
    sudo systemctl start docker
    ```
    Of start Docker Desktop vanuit je applicatiemenu als deze is geïnstalleerd.

- **Op Windows:**  
    Start Docker Desktop via het Startmenu.

Je kunt controleren of Docker draait door het volgende uit te voeren:
```sh
docker info
```
Zie je informatie over je Docker-installatie, dan werkt Docker correct.

Bekijk de tabel met [Lokale Providers](#list-of-local-providers) hieronder voor een overzicht.

Volgende stap: [Voer AgenticSeek lokaal uit](#start-services-and-run)

*Kijk in de sectie [Probleemoplossing](#troubleshooting) als je problemen ondervindt.*
*Kan jouw hardware LLM's niet lokaal draaien, zie [Installatie voor gebruik met een API](#setup-to-run-with-an-api).*
*Voor gedetailleerde uitleg over `config.ini`, zie [Config Sectie](#config).*

---

## Installatie voor lokaal draaien van LLM op je eigen machine

**Hardwarevereisten:**

Om LLM's lokaal te draaien heb je voldoende hardware nodig. Minimaal is een GPU vereist die Magistral, Qwen of Deepseek 14B kan draaien. Zie de FAQ voor gedetailleerde model- en prestatieaanbevelingen.

**Stel je lokale provider in**  

Start je lokale provider, bijvoorbeeld met ollama:

```sh
ollama serve
```

Zie hieronder voor een lijst van lokaal ondersteunde providers.

**Werk de config.ini bij**

Wijzig het config.ini-bestand om provider_name in te stellen op een ondersteunde provider en provider_model op een LLM die door jouw provider wordt ondersteund. We raden redeneermodellen aan zoals *Magistral* of *Deepseek*.

Zie de **FAQ** aan het einde van de README voor benodigde hardware.

```sh
[MAIN]
is_local = True # Of je lokaal of met een externe provider draait.
provider_name = ollama # of lm-studio, openai, etc..
provider_model = deepseek-r1:14b # kies een model dat past bij je hardware
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # naam van je AI
recover_last_session = True # of je de vorige sessie herstelt
save_session = True # of je de huidige sessie onthoudt
speak = False # tekst-naar-spraak
listen = False # spraak-naar-tekst, alleen voor CLI, experimenteel
jarvis_personality = False # Of je een meer "Jarvis"-achtige persoonlijkheid gebruikt (experimenteel)
languages = en zh # De lijst van talen, tekst-naar-spraak gebruikt standaard de eerste taal in de lijst
[BROWSER]
headless_browser = True # laat ongewijzigd tenzij je CLI op host gebruikt.
stealth_mode = True # Gebruik undetected selenium om browserdetectie te verminderen
```

**Waarschuwing**:

- Het `config.ini`-bestand ondersteunt geen opmerkingen.
Kopieer en plak de voorbeeldconfiguratie niet direct, omdat opmerkingen fouten zullen veroorzaken. Wijzig het `config.ini`-bestand handmatig met je gewenste instellingen, zonder opmerkingen.

- Stel *NIET* provider_name in op `openai` als je LM-studio gebruikt voor het draaien van LLM's. Stel in op `lm-studio`.

- Sommige providers (bijv. lm-studio) vereisen dat je `http://` voor het IP-adres plaatst. Bijvoorbeeld `http://127.0.0.1:1234`

**Lijst van lokale providers**

| Provider  | Lokaal? | Beschrijving                                               |
|-----------|--------|-----------------------------------------------------------|
| ollama    | Ja     | Draai LLM's lokaal met ollama als LLM-provider            |
| lm-studio | Ja     | Draai LLM lokaal met LM studio (zet `provider_name` op `lm-studio`)|
| openai    | Ja     | Gebruik openai-compatibele API (bijv: llama.cpp server)   |

Volgende stap: [Start services en voer AgenticSeek uit](#Start-services-and-Run)  

*Kijk in de sectie [Probleemoplossing](#troubleshooting) als je problemen ondervindt.*
*Kan jouw hardware LLM's niet lokaal draaien, zie [Installatie voor gebruik met een API](#setup-to-run-with-an-api).*
*Voor gedetailleerde uitleg over `config.ini`, zie [Config Sectie](#config).*

## Installatie voor gebruik met een API

Deze installatie gebruikt externe, cloudgebaseerde LLM-providers. Je hebt een API-sleutel nodig van de gekozen dienst.

**1. Kies een API-provider en verkrijg een API-sleutel:**

Raadpleeg de [Lijst van API-providers](#list-of-api-providers) hieronder. Bezoek hun websites om je aan te melden en een API-sleutel te verkrijgen.

**2. Stel je API-sleutel in als omgevingsvariabele:**


*   **Linux/macOS:**
    Open je terminal en gebruik het `export`-commando. Voeg dit het beste toe aan je shell-profielbestand (bijv. `~/.bashrc`, `~/.zshrc`) voor blijvende werking.
    ```sh
    export PROVIDER_API_KEY="jouw_api_key_hier" 
    # Vervang PROVIDER_API_KEY door de specifieke variabelenaam, bijv. OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Voorbeeld voor TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Command Prompt (Tijdelijk voor huidige sessie):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (Tijdelijk voor huidige sessie):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **Permanent:** Zoek naar "omgevingsvariabelen" in de Windows zoekbalk, klik op "Systeemomgevingsvariabelen bewerken," en klik vervolgens op de knop "Omgevingsvariabelen...". Voeg een nieuwe gebruikersvariabele toe met de juiste naam (bijv. `OPENAI_API_KEY`) en je sleutel als waarde.

*(Zie FAQ: [Hoe stel ik API-sleutels in?](#how-do-i-set-api-keys) voor meer details).*


**3. Werk `config.ini` bij:**
```ini
[MAIN]
is_local = False
provider_name = openai # Of google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Of gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 etc.
provider_server_address = # Wordt meestal genegeerd of kan leeg worden gelaten wanneer is_local = False voor de meeste APIs
# ... overige instellingen ...
```
*Waarschuwing:* Zorg ervoor dat er geen spaties aan het einde van de waarden in `config.ini` staan.

**Lijst van API-aanbieders**

| Provider     | `provider_name` | Lokaal? | Beschrijving                                        | API Key Link (Voorbeelden)                       |
|--------------|-----------------|---------|-----------------------------------------------------|--------------------------------------------------|
| OpenAI       | `openai`        | Nee     | Gebruik ChatGPT-modellen via de API van OpenAI.     | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini| `google`        | Nee     | Gebruik Google Gemini-modellen via Google AI Studio.| [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek     | `deepseek`      | Nee     | Gebruik Deepseek-modellen via hun API.              | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face | `huggingface`   | Nee     | Gebruik modellen van de Hugging Face Inference API. | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI   | `togetherAI`    | Nee     | Gebruik diverse open-source modellen via TogetherAI API.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Opmerking:*
*   We raden af om `gpt-4o` of andere OpenAI-modellen te gebruiken voor complexe web-browsing en taakplanning, omdat de huidige prompt-optimalisaties zijn afgestemd op modellen zoals Deepseek.
*   Programmeer/bash-taken kunnen problemen ondervinden met Gemini, omdat deze mogelijk niet strikt de prompt-formattering volgt die is geoptimaliseerd voor Deepseek.
*   Het veld `provider_server_address` in `config.ini` wordt meestal niet gebruikt als `is_local = False`, omdat het API-eindpunt doorgaans is vastgelegd in de bibliotheek van de betreffende provider.

Volgende stap: [Start services en voer AgenticSeek uit](#Start-services-and-Run)

*Zie de sectie **Bekende problemen** als je problemen ondervindt*

*Zie de sectie **Config** voor een gedetailleerde uitleg van het configuratiebestand.*

---

## Start services en voer uit

Standaard wordt AgenticSeek volledig in Docker uitgevoerd.

Start de vereiste services. Dit start alle services uit het docker-compose.yml bestand, waaronder:
    - searxng
    - redis (vereist door searxng)
    - frontend
    - backend (indien `full` gebruikt)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Windows
```

**Waarschuwing:** Deze stap downloadt en laadt alle Docker-images, wat tot 30 minuten kan duren. Na het starten van de services, wacht tot de backend service volledig draait (je zou **backend: "GET /health HTTP/1.1" 200 OK** in de log moeten zien) voordat je berichten verstuurt. De backend services kunnen bij de eerste keer starten tot 5 minuten nodig hebben.

Ga naar `http://localhost:3000/` en je zou de webinterface moeten zien.

*Problemen bij het starten van services:* Als deze scripts falen, controleer dan of Docker Engine draait en Docker Compose (V2, `docker compose`) correct is geïnstalleerd. Controleer de uitvoer in de terminal op foutmeldingen. Zie [FAQ: Help! Ik krijg een foutmelding bij het uitvoeren van AgenticSeek of de scripts.](#faq-troubleshooting)

**Optioneel:** Uitvoeren op host (CLI modus):

Om de CLI-interface te gebruiken moet je het pakket op de host installeren:

```sh
./install.sh
./install.bat # windows
```

Start de services:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Windows
```

Gebruik de CLI: `python3 cli.py`


---

## Gebruik

Zorg ervoor dat de services draaien met `./start_services.sh full` en ga naar `localhost:3000` voor de webinterface.

Je kunt ook spraak naar tekst gebruiken door `listen = True` in te stellen in de config. Alleen voor CLI-modus.

Om af te sluiten, zeg of typ je gewoon `goodbye`.

Hier zijn enkele voorbeelden van gebruik:

> *Maak een slangenspel in python!*

> *Zoek op internet naar de beste cafés in Rennes, Frankrijk, en sla een lijst van drie op met hun adressen in rennes_cafes.txt.*

> *Schrijf een Go-programma om de faculteit van een getal te berekenen, sla het op als factorial.go in je werkmap*

> *Zoek in mijn map summer_pictures naar alle JPG-bestanden, hernoem ze met de datum van vandaag, en sla een lijst van hernoemde bestanden op in photos_list.txt*

> *Zoek online naar populaire sci-fi films uit 2024 en kies er drie om vanavond te kijken. Sla de lijst op in movie_night.txt.*

> *Zoek op internet naar de laatste AI-nieuwsartikelen uit 2025, selecteer er drie, en schrijf een Python-script om hun titels en samenvattingen te scrapen. Sla het script op als news_scraper.py en de samenvattingen in ai_news.txt in /home/projects*

> *Vrijdag, zoek op internet naar een gratis API voor aandelenkoersen, registreer met supersuper7434567@gmail.com, schrijf dan een Python-script om met de API dagelijks prijzen voor Tesla op te halen, en sla de resultaten op in stock_prices.csv*

*Let op dat formuliervul-mogelijkheden nog experimenteel zijn en kunnen falen.*



Nadat je je vraag hebt ingevoerd, zal AgenticSeek de beste agent voor de taak toewijzen.

Omdat dit een vroeg prototype is, zal het routeringssysteem van de agent mogelijk niet altijd de juiste agent toewijzen op basis van je vraag.

Wees daarom heel expliciet in wat je wilt en hoe de AI te werk zou moeten gaan; wil je bijvoorbeeld dat het een webzoekopdracht uitvoert, zeg dan niet:

`Ken je goede landen voor solo-reizen?`

Vraag in plaats daarvan:

`Doe een webzoekopdracht en zoek uit wat de beste landen zijn voor solo-reizen`

---

## **Setup om de LLM op je eigen server te draaien**  

Als je een krachtige computer of server hebt die je kunt gebruiken, maar je wilt deze vanaf je laptop gebruiken, heb je de mogelijkheid om de LLM op een externe server te draaien met onze aangepaste llm-server.

Op je "server" die het AI-model zal draaien, haal het ip-adres op

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # lokaal ip
curl https://ipinfo.io/ip # publiek ip
```

Opmerking: Voor Windows of macOS gebruik respectievelijk ipconfig of ifconfig om het IP-adres te vinden.

Kloon de repository en ga naar de map `server/`.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Installeer de server-specifieke vereisten:

```sh
pip3 install -r requirements.txt
```

Voer het serverscript uit.

```sh
python3 app.py --provider ollama --port 3333
```

Je kunt kiezen tussen `ollama` en `llamacpp` als LLM-service.


Nu op je persoonlijke computer:

Wijzig het `config.ini`-bestand door `provider_name` op `server` te zetten en `provider_model` op `deepseek-r1:xxb`.
Stel `provider_server_address` in op het ip-adres van de machine die het model draait.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


Volgende stap: [Start services en voer AgenticSeek uit](#Start-services-and-Run)  

---

## Spraak naar Tekst

Waarschuwing: spraak naar tekst werkt momenteel alleen in CLI-modus.

Let op: spraak naar tekst werkt momenteel alleen in het Engels.

De spraak-naar-tekst functionaliteit is standaard uitgeschakeld. Om deze in te schakelen, stel je de optie listen in op True in het config.ini-bestand:

```
listen = True
```

Wanneer ingeschakeld, luistert de spraak-naar-tekst functie naar een triggerwoord, namelijk de naam van de agent, voordat je invoer wordt verwerkt. Je kunt de naam van de agent aanpassen door de waarde van `agent_name` bij te werken in het *config.ini* bestand:

```
agent_name = Friday
```

Voor optimale herkenning raden we aan een gangbare Engelse naam te gebruiken zoals "John" of "Emma" als agentnaam.

Zodra u het transcript ziet verschijnen, zeg de naam van de agent hardop om deze te activeren (bijv. "Friday").

Spreek uw vraag duidelijk uit.

Beëindig uw verzoek met een bevestigingszin om het systeem te laten doorgaan. Voorbeelden van bevestigingszinnen zijn:
```
"doe het", "ga je gang", "uitvoeren", "start", "begin", "dank je", "zou je", "alstublieft", "oké?", "doorgaan", "verder", "doe dat", "doe het", "begrijp je?"
```

## Config

Voorbeeldconfiguratie:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Voorbeeld voor Ollama; gebruik http://127.0.0.1:1234 voor LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Lijst van talen voor TTS en eventueel routering.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Uitleg van `config.ini` Instellingen**:

*   **`[MAIN]` Sectie:**
    *   `is_local`: `True` als u een lokale LLM-provider gebruikt (Ollama, LM-Studio, lokale OpenAI-compatibele server) of de self-hosted serveroptie. `False` als u een cloudgebaseerde API gebruikt (OpenAI, Google, enz.).
    *   `provider_name`: Specificeert de LLM-provider.
        *   Lokale opties: `ollama`, `lm-studio`, `openai` (voor lokale OpenAI-compatibele servers), `server` (voor de zelfgehoste server).
        *   API-opties: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: De specifieke modelnaam of ID voor de gekozen provider (bijv. `deepseekcoder:6.7b` voor Ollama, `gpt-3.5-turbo` voor OpenAI API, `mistralai/Mixtral-8x7B-Instruct-v0.1` voor TogetherAI).
    *   `provider_server_address`: Het adres van uw LLM-provider.
        *   Voor lokale providers: bijv. `http://127.0.0.1:11434` voor Ollama, `http://127.0.0.1:1234` voor LM-Studio.
        *   Voor de `server`-provider: Het adres van uw zelfgehoste LLM-server (bijv. `http://your_server_ip:3333`).
        *   Voor cloud-API's (`is_local = False`): Dit wordt vaak genegeerd of kan leeg gelaten worden, omdat het API-eindpunt meestal door de clientbibliotheek wordt afgehandeld.
    *   `agent_name`: Naam van de AI-assistent (bijv. Friday). Wordt gebruikt als triggerwoord voor spraak-naar-tekst als dit is ingeschakeld.
    *   `recover_last_session`: `True` om te proberen de vorige sessiestatus te herstellen, `False` om opnieuw te beginnen.
    *   `save_session`: `True` om de huidige sessiestatus op te slaan voor mogelijk herstel, `False` anders.
    *   `speak`: `True` om spraakuitvoer (text-to-speech) in te schakelen, `False` om uit te schakelen.
    *   `listen`: `True` om spraak-naar-tekst-invoer (alleen CLI-modus) in te schakelen, `False` om uit te schakelen.
    *   `work_dir`: **Cruciaal:** De map waarin AgenticSeek bestanden zal lezen/schrijven. **Zorg ervoor dat dit pad geldig en toegankelijk is op uw systeem.**
    *   `jarvis_personality`: `True` voor een meer "Jarvis-achtige" systeemprompt (experimenteel), `False` voor de standaardprompt.
    *   `languages`: Een komma-gescheiden lijst met talen (bijv. `en, zh, fr`). Wordt gebruikt voor TTS-stemselectie (standaard de eerste) en kan de LLM-router helpen. Vermijd te veel of zeer vergelijkbare talen voor routerefficiëntie.
*   **`[BROWSER]` Sectie:**
    *   `headless_browser`: `True` om de geautomatiseerde browser zonder zichtbaar venster uit te voeren (aanbevolen voor webinterface of niet-interactief gebruik). `False` om het browservenster te tonen (handig voor CLI-modus of debugging).
    *   `stealth_mode`: `True` om maatregelen te activeren die browserautomatisering moeilijker te detecteren maken. Kan vereisen dat u handmatig browserextensies zoals anticaptcha installeert.


Deze sectie geeft een overzicht van de ondersteunde LLM-providertypes. Stel ze in via `config.ini`.

**Lokale Providers (Draaiend op eigen hardware):**

| Providernaam in `config.ini` | `is_local` | Beschrijving                                                                 | Setup Sectie                                                    |
|-------------------------------|------------|-----------------------------------------------------------------------------|------------------------------------------------------------------|
| `ollama`                      | `True`     | Gebruik Ollama om lokale LLM's te draaien.                                  | [Setup voor lokaal draaien van LLM](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | Gebruik LM-Studio om lokale LLM's te draaien.                               | [Setup voor lokaal draaien van LLM](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (voor lokale server) | `True`     | Verbind met een lokale server die een OpenAI-compatibele API aanbiedt (bijv. llama.cpp). | [Setup voor lokaal draaien van LLM](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | Verbind met de zelfgehoste AgenticSeek LLM-server op een andere machine.    | [Setup om de LLM op uw eigen server te draaien](#setup-to-run-the-llm-on-your-own-server) |

**API Providers (Cloud-Based):**

| Providernaam in `config.ini` | `is_local` | Beschrijving                                     | Setup Sectie                                        |
|-------------------------------|------------|--------------------------------------------------|-----------------------------------------------------|
| `openai`                      | `False`    | Gebruik de officiële API van OpenAI (bijv. GPT-3.5, GPT-4). | [Setup om te draaien met een API](#setup-to-run-with-an-api) |
| `google`                      | `False`    | Gebruik Google's Gemini-modellen via API.        | [Setup om te draaien met een API](#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | Gebruik de officiële API van Deepseek.           | [Setup om te draaien met een API](#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | Gebruik de Hugging Face Inference API.           | [Setup om te draaien met een API](#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | Gebruik TogetherAI's API voor diverse open modellen. | [Setup om te draaien met een API](#setup-to-run-with-an-api) |

---
## Problemen oplossen

Als u problemen ondervindt, biedt deze sectie hulp.

# Bekende Problemen

## ChromeDriver Problemen

**Foutvoorbeeld:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Oorzaak:** De geïnstalleerde ChromeDriver-versie is niet compatibel met de versie van uw Google Chrome-browser.
*   **Oplossing:**
    1.  **Controleer Chrome-versie:** Open Google Chrome, ga naar `Instellingen > Over Chrome` om uw versie te vinden (bijv. "Versie 120.0.6099.110").
    2.  **Download de bijpassende ChromeDriver:**
        *   Voor Chrome versies 115 en nieuwer: Ga naar de [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Zoek het "stable" kanaal en download de ChromeDriver voor uw besturingssysteem die overeenkomt met uw Chrome-hoofdversie.
        *   Voor oudere versies (minder voorkomend): Mogelijk vindt u deze op de [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads) pagina.
        *   De onderstaande afbeelding toont een voorbeeld van de CfT-pagina:
            ![Download Chromedriver specifieke versie van de Chrome for Testing pagina](./media/chromedriver_readme.png)
    3.  **Installeer ChromeDriver:**
        *   Zorg ervoor dat de gedownloade `chromedriver` (of `chromedriver.exe` op Windows) in een map staat die is opgenomen in het PATH-omgevingsvariabele van uw systeem (bijv. `/usr/local/bin` op Linux/macOS, of een aangepaste scriptsmap toegevoegd aan PATH op Windows).
        *   Of plaats hem in de hoofdmap van het `agenticSeek`-project.
        *   Zorg ervoor dat de driver uitvoerbaar is (bijv. `chmod +x chromedriver` op Linux/macOS).
    4.  Raadpleeg de sectie [ChromeDriver Installatie](#chromedriver-installation) in de hoofdinstallatiehandleiding voor meer details.

Als deze sectie onvolledig is of u andere ChromeDriver-problemen ondervindt, zoek dan bestaande [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) of maak een nieuw issue aan.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Dit gebeurt als er een mismatch is tussen uw browser- en chromedriver-versie.

U dient de nieuwste versie te downloaden:

https://developer.chrome.com/docs/chromedriver/downloads

Als u Chrome versie 115 of nieuwer gebruikt, ga naar:

https://googlechromelabs.github.io/chrome-for-testing/

En download de chromedriver-versie die overeenkomt met uw OS.

![alt text](./media/chromedriver_readme.png)

Als deze sectie onvolledig is, maak dan een issue aan.

##  connection adapters Problemen

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Let op: poort kan verschillen)
```

*   **Oorzaak:** Het `provider_server_address` in `config.ini` voor `lm-studio` (of andere vergelijkbare lokale OpenAI-compatibele servers) mist het `http://`-voorvoegsel of wijst naar de verkeerde poort.
*   **Oplossing:**
    *   Zorg ervoor dat het adres `http://` bevat. LM-Studio gebruikt typisch `http://127.0.0.1:1234`.
    *   Corrigeer `config.ini`: `provider_server_address = http://127.0.0.1:1234` (of uw daadwerkelijke LM-Studio serverpoort).

## SearxNG Base URL Niet Opgegeven

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**Q: Welke hardware heb ik nodig?**  

| Modelgrootte  | GPU  | Opmerking                                               |
|-----------|--------|-------------------------------------------------------------|
| 7B        | 8GB Vram | ⚠️ Niet aanbevolen. Slechte prestaties, frequente hallucinaties en planner agents zullen waarschijnlijk falen. |
| 14B        | 12 GB VRAM (bijv. RTX 3060) | ✅ Bruikbaar voor eenvoudige taken. Kan moeite hebben met web browsing en planningstaken. |
| 32B        | 24+ GB VRAM (bijv. RTX 4090) | 🚀 Succesvol bij de meeste taken, kan nog steeds moeite hebben met taakplanning |
| 70B+        | 48+ GB Vram | 💪 Uitstekend. Aanbevolen voor geavanceerde toepassingen. |

**Q: Ik krijg een foutmelding, wat moet ik doen?**  

Controleer of lokaal draait (`ollama serve`), uw `config.ini` overeenkomt met uw provider en alle afhankelijkheden geïnstalleerd zijn. Werkt het dan nog niet, maak gerust een issue aan.

**Q: Kan het echt 100% lokaal draaien?**  

Ja, met Ollama, lm-studio of serverproviders draaien alle spraak-naar-tekst, LLM en tekst-naar-spraak-modellen lokaal. Niet-lokale opties (OpenAI of andere API’s) zijn optioneel.

**Q: Waarom zou ik AgenticSeek gebruiken als ik Manus heb?**

In tegenstelling tot Manus, hecht AgenticSeek veel waarde aan onafhankelijkheid van externe systemen, wat u meer controle, privacy en geen API-kosten biedt.

**Q: Wie zit er achter het project?**

Het project is opgezet door mij samen met twee vrienden die als maintainers en bijdragers uit de open-source gemeenschap op GitHub fungeren. We zijn gewoon een groep gepassioneerde individuen, geen startup of onderdeel van een organisatie.

Elk AgenticSeek-account op X behalve mijn persoonlijke account (https://x.com/Martin993886460) is een imitatie.

## Bijdragen

We zoeken ontwikkelaars om AgenticSeek te verbeteren! Bekijk open issues of discussies.

[Bijdragegids](./docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Onderhouders:

 > [Fosowl](https://github.com/Fosowl) | Parijs Tijd 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Taipei Tijd 

 > [steveh8758](https://github.com/steveh8758) | Taipei Tijd 

## Speciale Dank:

 > [tcsenpai](https://github.com/tcsenpai) en [plitc](https://github.com/plitc) Voor hulp bij backend-dockerization

## Sponsors:

5$ of meer Maandelijkse sponsor verschijnt hier:
- **tatra-labs**

Sorry, but you didn't provide the content you want translated. Please provide the text of Part 4 of 4, and I'll translate it into Dutch for you, preserving the formatting and Markdown as requested.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---