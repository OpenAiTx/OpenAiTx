# AgenticSeek: Alternativa privata e locale a Manus.

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*Un'alternativa **100% locale a Manus AI**, questo assistente vocale abilitato all'IA naviga autonomamente sul web, scrive codice e pianifica attività mantenendo tutti i dati sul tuo dispositivo. Progettato per modelli di ragionamento locali, funziona interamente sull'hardware locale, garantendo completa privacy e zero dipendenza dal cloud.*

[![Visita AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Perché AgenticSeek?

* 🔒 Completamente Locale e Privato - Tutto funziona sulla tua macchina — nessun cloud, nessuna condivisione dei dati. I tuoi file, conversazioni e ricerche rimangono privati.

* 🌐 Navigazione Web Intelligente - AgenticSeek può navigare autonomamente in internet — cercare, leggere, estrarre informazioni, compilare moduli web — tutto a mani libere.

* 💻 Assistente di Codifica Autonomo - Hai bisogno di codice? Può scrivere, effettuare il debug ed eseguire programmi in Python, C, Go, Java e altro — tutto senza supervisione.

* 🧠 Selezione Intelligente dell’Agente - Tu chiedi, lui individua automaticamente l'agente migliore per il compito. Come avere un team di esperti sempre pronti ad aiutarti.

* 📋 Pianifica ed Esegue Compiti Complessi - Dalla pianificazione di viaggi a progetti complessi — può suddividere grandi attività in step e portarle a termine usando molteplici agenti IA.

* 🎙️ Voce Abilitata - Voce pulita, veloce, futuristica e riconoscimento vocale che ti permette di parlarci come se fosse la tua IA personale da un film di fantascienza. (In sviluppo)

### **Demo**

> *Puoi cercare il progetto agenticSeek, capire quali competenze sono richieste, poi aprire CV_candidates.zip e dirmi quali corrispondono meglio al progetto?*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Disclaimer: Questa demo, inclusi tutti i file che compaiono (es: CV_candidates.zip), è completamente fittizia. Non siamo una società, cerchiamo contributori open-source, non candidati.

> 🛠⚠️️ **Lavoro attivo in corso**

> 🙏 Questo progetto è iniziato come un side-project e non ha roadmap né finanziamenti. È cresciuto oltre le aspettative finendo nei GitHub Trending. Contributi, feedback e pazienza sono profondamente apprezzati.

## Prerequisiti

Prima di iniziare, assicurati di avere installato il seguente software:

*   **Git:** Per clonare il repository. [Scarica Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** Consigliamo vivamente Python versione 3.10.x. L’uso di altre versioni può causare errori di dipendenza. [Scarica Python 3.10](https://www.python.org/downloads/release/python-3100/) (scegli una versione 3.10.x).
*   **Docker Engine & Docker Compose:** Per l’esecuzione di servizi integrati come SearxNG.
    *   Installa Docker Desktop (che include Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   In alternativa, installa Docker Engine e Docker Compose separatamente su Linux: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (assicurati di installare Compose V2, ad esempio, `sudo apt-get install docker-compose-plugin`).

### 1. **Clona il repository e configura**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Modifica il contenuto del file .env

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

Aggiorna il file `.env` con i tuoi valori ove necessario:

- **SEARXNG_BASE_URL**: Lascia invariato
- **REDIS_BASE_URL**: Lascia invariato
- **WORK_DIR**: Percorso della tua cartella di lavoro sulla tua macchina locale. AgenticSeek potrà leggere e interagire con questi file.
- **OLLAMA_PORT**: Porta per il servizio Ollama.
- **LM_STUDIO_PORT**: Porta per il servizio LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Porta per eventuali servizi LLM personalizzati aggiuntivi.

**Le chiavi API sono totalmente opzionali per gli utenti che scelgono di eseguire LLM localmente, che è lo scopo principale di questo progetto. Lascia vuoto se hai hardware sufficiente**

### 3. **Avvia Docker**

Assicurati che Docker sia installato e in esecuzione sul tuo sistema. Puoi avviare Docker con i seguenti comandi:

- **Su Linux/macOS:**  
    Apri un terminale ed esegui:
    ```sh
    sudo systemctl start docker
    ```
    Oppure lancia Docker Desktop dal menu delle applicazioni se installato.

- **Su Windows:**  
    Avvia Docker Desktop dal menu Start.

Puoi verificare che Docker sia in esecuzione eseguendo:
```sh
docker info
```
Se vedi informazioni sulla tua installazione di Docker, allora è attivo correttamente.

Consulta la tabella dei [Provider Locali](#list-of-local-providers) qui sotto per un riassunto.

Prossimo passo: [Esegui AgenticSeek in locale](#start-services-and-run)

*Consulta la sezione [Risoluzione dei problemi](#troubleshooting) se hai problemi.*
*Se il tuo hardware non può eseguire LLM in locale, vedi [Configurazione per esecuzione con una API](#setup-to-run-with-an-api).*
*Per dettagli su `config.ini`, vedi [Sezione Config](#config).*

---

## Configurazione per esecuzione LLM in locale sulla tua macchina

**Requisiti hardware:**

Per eseguire LLM localmente, avrai bisogno di hardware sufficiente. Al minimo, è richiesta una GPU in grado di eseguire Magistral, Qwen o Deepseek 14B. Consulta le FAQ per raccomandazioni dettagliate su modelli/prestazioni.

**Configura il tuo provider locale**

Avvia il tuo provider locale, ad esempio con ollama:

```sh
ollama serve
```

Consulta sotto per un elenco di provider locali supportati.

**Aggiorna il config.ini**

Modifica il file config.ini per impostare provider_name su un provider supportato e provider_model su un LLM supportato dal tuo provider. Consigliamo modelli di ragionamento come *Magistral* o *Deepseek*.

Consulta le **FAQ** alla fine del README per l’hardware necessario.

```sh
[MAIN]
is_local = True # Se stai eseguendo localmente o con un provider remoto.
provider_name = ollama # oppure lm-studio, openai, ecc.
provider_model = deepseek-r1:14b # scegli un modello compatibile col tuo hardware
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # nome della tua IA
recover_last_session = True # se recuperare la sessione precedente
save_session = True # se ricordare la sessione attuale
speak = False # sintesi vocale
listen = False # riconoscimento vocale, solo per CLI, sperimentale
jarvis_personality = False # se usare una personalità tipo "Jarvis" (sperimentale)
languages = en zh # Elenco lingue, la sintesi vocale userà la prima della lista
[BROWSER]
headless_browser = True # lascia invariato a meno che usi CLI sull’host.
stealth_mode = True # Usa selenium non rilevabile per ridurre la detection del browser
```

**Attenzione**:

- Il formato del file `config.ini` non supporta commenti.
Non copiare e incollare direttamente la configurazione di esempio, poiché i commenti causeranno errori. Modifica manualmente il file `config.ini` con le impostazioni desiderate, escludendo qualsiasi commento.

- NON impostare provider_name su `openai` se usi LM-studio per eseguire LLM. Impostalo su `lm-studio`.

- Alcuni provider (es: lm-studio) richiedono che ci sia `http://` davanti all’IP. Ad esempio `http://127.0.0.1:1234`

**Elenco dei provider locali**

| Provider  | Locale? | Descrizione                                               |
|-----------|--------|-----------------------------------------------------------|
| ollama    | Sì     | Esegui LLM localmente con ollama come provider LLM        |
| lm-studio | Sì     | Esegui LLM localmente con LM studio (imposta `provider_name` su `lm-studio`)|
| openai    | Sì     |  Usa API compatibili openai (es: server llama.cpp)        |

Prossimo passo: [Avvia i servizi ed esegui AgenticSeek](#Start-services-and-Run)  

*Consulta la sezione [Risoluzione dei problemi](#troubleshooting) se hai problemi.*
*Se il tuo hardware non può eseguire LLM in locale, vedi [Configurazione per esecuzione con una API](#setup-to-run-with-an-api).*
*Per dettagli su `config.ini`, vedi [Sezione Config](#config).*

## Configurazione per esecuzione tramite API

Questa configurazione utilizza provider LLM esterni basati su cloud. Avrai bisogno di una chiave API dal servizio scelto.

**1. Scegli un provider API e ottieni una chiave API:**

Consulta l’[Elenco dei provider API](#list-of-api-providers) qui sotto. Visita i loro siti web per registrarti e ottenere una chiave API.

**2. Imposta la tua chiave API come variabile d’ambiente:**


*   **Linux/macOS:**
    Apri il terminale e usa il comando `export`. È meglio aggiungerlo al file di profilo della shell (es: `~/.bashrc`, `~/.zshrc`) per la persistenza.
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # Sostituisci PROVIDER_API_KEY con il nome della variabile specifica, es: OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Esempio per TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Prompt dei comandi (temporaneo per la sessione corrente):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (temporaneo per la sessione corrente):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **Permanente:** Cerca "variabili d'ambiente" nella barra di ricerca di Windows, clicca su "Modifica le variabili d'ambiente di sistema," poi clicca sul pulsante "Variabili d'ambiente...". Aggiungi una nuova variabile utente con il nome appropriato (es. `OPENAI_API_KEY`) e la tua chiave come valore.

*(Vedi FAQ: [Come imposto le chiavi API?](#how-do-i-set-api-keys) per maggiori dettagli).*


**3. Aggiorna `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # Oppure google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Oppure gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 ecc.
provider_server_address = # Tipicamente ignorato o può essere lasciato vuoto quando is_local = False per la maggior parte delle API
# ... altre impostazioni ...
```
*Attenzione:* Assicurati che non ci siano spazi finali nei valori di `config.ini`.

**Elenco dei fornitori API**

| Fornitore     | `provider_name` | Locale? | Descrizione                                         | Link chiave API (Esempi)                              |
|---------------|-----------------|---------|-----------------------------------------------------|--------------------------------------------------------|
| OpenAI        | `openai`        | No      | Utilizza i modelli ChatGPT tramite l'API di OpenAI. | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini | `google`        | No      | Utilizza i modelli Gemini di Google tramite AI Studio.| [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek      | `deepseek`      | No      | Utilizza i modelli Deepseek tramite la loro API.    | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face  | `huggingface`   | No      | Utilizza modelli tramite Hugging Face Inference API.| [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI    | `togetherAI`    | No      | Utilizza vari modelli open-source tramite TogetherAI API.| [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Nota:*
*   Sconsigliamo l'uso di `gpt-4o` o altri modelli OpenAI per la navigazione web complessa e la pianificazione di task poiché le attuali ottimizzazioni dei prompt sono orientate verso modelli come Deepseek.
*   Task di coding/bash potrebbero avere problemi con Gemini, in quanto potrebbe non seguire rigorosamente i prompt di formattazione ottimizzati per Deepseek.
*   Il campo `provider_server_address` in `config.ini` generalmente non viene utilizzato quando `is_local = False` poiché l'endpoint API è solitamente hardcoded nella rispettiva libreria del fornitore.

Prossimo passo: [Avvia servizi ed esegui AgenticSeek](#Start-services-and-Run)

*Consulta la sezione **Problemi noti** se hai problemi*

*Consulta la sezione **Config** per una spiegazione dettagliata del file di configurazione.*

---

## Avvia servizi ed Esegui

Per impostazione predefinita AgenticSeek viene eseguito completamente in docker.

Avvia i servizi richiesti. Questo avvierà tutti i servizi dal docker-compose.yml, inclusi:
   - searxng
   - redis (necessario per searxng)
   - frontend
   - backend (se si utilizza `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**Attenzione:** Questo passaggio scaricherà e caricherà tutte le immagini Docker, il che potrebbe richiedere fino a 30 minuti. Dopo l'avvio dei servizi, attendi che il servizio backend sia completamente operativo (dovresti vedere **backend: "GET /health HTTP/1.1" 200 OK** nel log) prima di inviare qualsiasi messaggio. I servizi backend potrebbero impiegare 5 minuti per avviarsi al primo avvio.

Vai su `http://localhost:3000/` e dovresti vedere l'interfaccia web.

*Risoluzione dei problemi di avvio servizio:* Se questi script falliscono, assicurati che Docker Engine sia in esecuzione e che Docker Compose (V2, `docker compose`) sia installato correttamente. Controlla l'output nel terminale per eventuali messaggi di errore. Vedi [FAQ: Aiuto! Ricevo un errore quando eseguo AgenticSeek o i suoi script.](#faq-troubleshooting)

**Opzionale:** Esegui su host (modalità CLI):

Per eseguire con l'interfaccia CLI devi installare il pacchetto sull'host:

```sh
./install.sh
./install.bat # windows
```

Avvia i servizi:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

Usa la CLI: `python3 cli.py`


---

## Utilizzo

Assicurati che i servizi siano attivi e funzionanti con `./start_services.sh full` e vai su `localhost:3000` per l'interfaccia web.

Puoi anche utilizzare la funzione speech to text impostando `listen = True` nel config. Solo in modalità CLI.

Per uscire, basta dire/digitare `goodbye`.

Ecco alcuni esempi di utilizzo:

> *Crea un gioco snake in python!*

> *Cerca sul web i migliori caffè a Rennes, Francia, e salva una lista di tre con i loro indirizzi in rennes_cafes.txt.*

> *Scrivi un programma Go per calcolare il fattoriale di un numero, salvalo come factorial.go nella tua workspace*

> *Cerca nella mia cartella summer_pictures tutti i file JPG, rinominali con la data odierna e salva la lista dei file rinominati in photos_list.txt*

> *Cerca online film di fantascienza popolari del 2024 e scegline tre da guardare stasera. Salva la lista in movie_night.txt.*

> *Cerca sul web gli ultimi articoli di notizie sull'IA dal 2025, seleziona tre e scrivi uno script Python per estrarre i titoli e i riassunti. Salva lo script come news_scraper.py e i riassunti in ai_news.txt in /home/projects*

> *Venerdì, cerca sul web una API gratuita per i prezzi delle azioni, registrati con supersuper7434567@gmail.com, quindi scrivi uno script Python per recuperare tramite l'API i prezzi giornalieri di Tesla e salva i risultati in stock_prices.csv*

*Nota che le capacità di compilazione moduli sono ancora sperimentali e potrebbero fallire.*



Dopo aver digitato la tua richiesta, AgenticSeek assegnerà il miglior agente per il compito.

Poiché si tratta di un prototipo iniziale, il sistema di instradamento degli agenti potrebbe non sempre assegnare l'agente giusto in base alla tua richiesta.

Pertanto, dovresti essere molto esplicito su ciò che desideri e su come l'IA potrebbe procedere; ad esempio, se vuoi che effettui una ricerca web, non dire:

`Conosci alcuni buoni paesi per viaggiare da soli?`

Invece, chiedi:

`Fai una ricerca web e scopri quali sono i migliori paesi per viaggiare da soli`

---

## **Configurazione per eseguire l'LLM sul tuo server**  

Se disponi di un computer potente o di un server che puoi utilizzare, ma vuoi usarlo dal tuo portatile, hai la possibilità di eseguire l'LLM su un server remoto utilizzando il nostro llm server personalizzato.

Sul tuo "server" che eseguirà il modello AI, ottieni l'indirizzo IP

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # ip locale
curl https://ipinfo.io/ip # ip pubblico
```

Nota: Per Windows o macOS, utilizza rispettivamente ipconfig o ifconfig per trovare l'indirizzo IP.

Clona il repository ed entra nella cartella `server/`.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Installa i requisiti specifici del server:

```sh
pip3 install -r requirements.txt
```

Esegui lo script server.

```sh
python3 app.py --provider ollama --port 3333
```

Puoi scegliere tra utilizzare `ollama` e `llamacpp` come servizio LLM.


Ora sul tuo computer personale:

Modifica il file `config.ini` per impostare `provider_name` su `server` e `provider_model` su `deepseek-r1:xxb`.
Imposta `provider_server_address` sull'indirizzo IP della macchina che eseguirà il modello.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


Prossimo passo: [Avvia servizi ed esegui AgenticSeek](#Start-services-and-Run)  

---

## Speech to Text

Attenzione: la funzione speech to text funziona solo in modalità CLI al momento.

Nota che attualmente il riconoscimento vocale funziona solo in inglese.

La funzionalità di speech-to-text è disabilitata per impostazione predefinita. Per abilitarla, imposta l'opzione listen su True nel file config.ini:

```
listen = True
```

Quando abilitata, la funzione speech-to-text ascolta una parola chiave di attivazione, che è il nome dell'agente, prima di iniziare a elaborare il tuo input. Puoi personalizzare il nome dell'agente aggiornando il valore `agent_name` nel file *config.ini*:

```
agent_name = Friday
```

Per un riconoscimento ottimale, si consiglia di utilizzare un nome inglese comune come "John" o "Emma" come nome dell'agente

Una volta che vedrai iniziare ad apparire la trascrizione, pronuncia ad alta voce il nome dell’agente per attivarlo (es. "Friday").

Pronuncia chiaramente la tua richiesta.

Termina la richiesta con una frase di conferma per segnalare al sistema di procedere. Esempi di frasi di conferma includono:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Config

Esempio di configurazione:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Esempio per Ollama; usa http://127.0.0.1:1234 per LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Elenco delle lingue per TTS e potenzialmente per l’instradamento.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Spiegazione delle impostazioni di `config.ini`:**

*   **Sezione `[MAIN]`:**
    *   `is_local`: `True` se si utilizza un provider LLM locale (Ollama, LM-Studio, server locale compatibile OpenAI) o l’opzione server self-hosted. `False` se si utilizza un’API cloud (OpenAI, Google, ecc.).
    *   `provider_name`: Specifica il provider LLM.
        *   Opzioni locali: `ollama`, `lm-studio`, `openai` (per server locali compatibili OpenAI), `server` (per il setup self-hosted).
        *   Opzioni API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: Il nome o ID specifico del modello per il provider scelto (es. `deepseekcoder:6.7b` per Ollama, `gpt-3.5-turbo` per OpenAI API, `mistralai/Mixtral-8x7B-Instruct-v0.1` per TogetherAI).
    *   `provider_server_address`: L’indirizzo del tuo provider LLM.
        *   Per provider locali: es. `http://127.0.0.1:11434` per Ollama, `http://127.0.0.1:1234` per LM-Studio.
        *   Per il tipo `server`: l’indirizzo del tuo server LLM self-hosted (es. `http://your_server_ip:3333`).
        *   Per API cloud (`is_local = False`): spesso viene ignorato o può essere lasciato vuoto, dato che l’endpoint API è solitamente gestito dalla libreria client.
    *   `agent_name`: Nome dell’assistente AI (es. Friday). Utilizzato come parola di attivazione per il riconoscimento vocale se abilitato.
    *   `recover_last_session`: `True` per tentare di ripristinare lo stato della sessione precedente, `False` per iniziare da zero.
    *   `save_session`: `True` per salvare lo stato della sessione corrente per un eventuale recupero, `False` altrimenti.
    *   `speak`: `True` per abilitare l’output vocale tramite sintesi vocale, `False` per disabilitarlo.
    *   `listen`: `True` per abilitare l’input vocale tramite riconoscimento vocale (solo modalità CLI), `False` per disabilitarlo.
    *   `work_dir`: **Cruciale:** La directory dove AgenticSeek leggerà/scriverà i file. **Assicurati che questo percorso sia valido e accessibile dal tuo sistema.**
    *   `jarvis_personality`: `True` per utilizzare un prompt di sistema più in stile "Jarvis" (sperimentale), `False` per il prompt standard.
    *   `languages`: Un elenco separato da virgole di lingue (es. `en, zh, fr`). Usato per la selezione della voce TTS (predefinita la prima) e può aiutare l’instradatore LLM. Evita troppe lingue o lingue molto simili per efficienza.
*   **Sezione `[BROWSER]`:**
    *   `headless_browser`: `True` per eseguire il browser automatizzato senza finestra visibile (consigliato per interfaccia web o uso non interattivo). `False` per mostrare la finestra del browser (utile in modalità CLI o per debug).
    *   `stealth_mode`: `True` per abilitare misure che rendono più difficile rilevare l’automazione del browser. Potrebbe richiedere l’installazione manuale di estensioni come anticaptcha.

Questa sezione riassume i tipi di provider LLM supportati. Configurali in `config.ini`.

**Provider Locali (In esecuzione sull’hardware locale):**

| Nome provider in `config.ini` | `is_local` | Descrizione                                                             | Sezione Setup                                                                 |
|-------------------------------|------------|-------------------------------------------------------------------------|-------------------------------------------------------------------------------|
| `ollama`                      | `True`     | Usa Ollama per servire LLM locali.                                      | [Setup per eseguire LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | Usa LM-Studio per servire LLM locali.                                   | [Setup per eseguire LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (per server locale)  | `True`     | Connette a un server locale che espone una API compatibile OpenAI (es. llama.cpp). | [Setup per eseguire LLM localmente](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | Connette al server LLM self-hosted AgenticSeek in esecuzione su un’altra macchina. | [Setup per eseguire LLM su proprio server](#setup-to-run-the-llm-on-your-own-server) |

**Provider API (Cloud):**

| Nome provider in `config.ini` | `is_local` | Descrizione                                        | Sezione Setup                                      |
|-------------------------------|------------|----------------------------------------------------|----------------------------------------------------|
| `openai`                      | `False`    | Usa l’API ufficiale di OpenAI (es. GPT-3.5, GPT-4). | [Setup per l'uso con API](#setup-to-run-with-an-api) |
| `google`                      | `False`    | Usa i modelli Gemini di Google tramite API.         | [Setup per l'uso con API](#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | Usa l’API ufficiale Deepseek.                       | [Setup per l'uso con API](#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | Usa l’Hugging Face Inference API.                   | [Setup per l'uso con API](#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | Usa l’API TogetherAI per vari modelli open.         | [Setup per l'uso con API](#setup-to-run-with-an-api) |

---
## Risoluzione dei problemi

Se incontri problemi, questa sezione fornisce indicazioni.

# Problemi noti

## Problemi con ChromeDriver

**Esempio di errore:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Causa:** La versione di ChromeDriver installata non è compatibile con la versione del browser Google Chrome.
*   **Soluzione:**
    1.  **Verifica versione Chrome:** Apri Google Chrome, vai su `Impostazioni > Informazioni su Chrome` per trovare la tua versione (es. "Versione 120.0.6099.110").
    2.  **Scarica la versione corrispondente di ChromeDriver:**
        *   Per versioni Chrome 115 e successive: Vai ai [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Trova il canale "stable" e scarica ChromeDriver per il tuo sistema operativo che corrisponde alla major version di Chrome.
        *   Per versioni precedenti (meno comuni): Potresti trovarle sulla pagina [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   L'immagine sotto mostra un esempio dalla pagina CfT:
            ![Scarica una versione specifica di Chromedriver dalla pagina Chrome for Testing](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **Installa ChromeDriver:**
        *   Assicurati che il file `chromedriver` scaricato (o `chromedriver.exe` su Windows) sia posizionato in una directory presente nella variabile di ambiente PATH del sistema (es. `/usr/local/bin` su Linux/macOS, o una cartella scripts personalizzata aggiunta a PATH su Windows).
        *   In alternativa, posizionalo nella directory principale del progetto `agenticSeek`.
        *   Assicurati che il driver sia eseguibile (es. `chmod +x chromedriver` su Linux/macOS).
    4.  Consulta la sezione [Installazione di ChromeDriver](#chromedriver-installation) nella guida di Installazione principale per maggiori dettagli.

Se questa sezione è incompleta o incontri altri problemi con ChromeDriver, valuta la possibilità di cercare tra le [Issue GitHub esistenti](https://github.com/Fosowl/agenticSeek/issues) o aprirne una nuova.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

Questo accade se c’è una discrepanza tra la versione del browser e quella di chromedriver.

Devi andare a scaricare l’ultima versione:

https://developer.chrome.com/docs/chromedriver/downloads

Se usi Chrome versione 115 o superiore vai su:

https://googlechromelabs.github.io/chrome-for-testing/

E scarica la versione di chromedriver corrispondente al tuo sistema operativo.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Se questa sezione è incompleta ti preghiamo di aprire una issue.

## Problemi con connection adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Nota: la porta può variare)
```

*   **Causa:** Il campo `provider_server_address` in `config.ini` per `lm-studio` (o altri server locali compatibili OpenAI) manca del prefisso `http://` o punta alla porta sbagliata.
*   **Soluzione:**
    *   Assicurati che l’indirizzo includa `http://`. LM-Studio di solito usa `http://127.0.0.1:1234`.
    *   Correggi `config.ini`: `provider_server_address = http://127.0.0.1:1234` (o la porta effettiva del tuo server LM-Studio).

## Base URL di SearxNG non fornito

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**D: Che hardware mi serve?**  

| Dimensione modello | GPU       | Commento                                                                                          |
|--------------------|-----------|---------------------------------------------------------------------------------------------------|
| 7B                 | 8GB Vram  | ⚠️ Sconsigliato. Prestazioni scarse, allucinazioni frequenti, agenti planner probabilmente falliranno. |
| 14B                | 12 GB VRAM (es. RTX 3060) | ✅ Usabile per compiti semplici. Può avere difficoltà con navigazione web e pianificazione.      |
| 32B                | 24+ GB VRAM (es. RTX 4090) | 🚀 Successo nella maggior parte dei task, può ancora avere problemi nel task planning           |
| 70B+               | 48+ GB Vram | 💪 Eccellente. Raccomandato per casi d’uso avanzati.                                             |

**D: Ottengo un errore, cosa devo fare?**  

Assicurati che il locale sia in esecuzione (`ollama serve`), che il tuo `config.ini` corrisponda al provider e che le dipendenze siano installate. Se nulla funziona sentiti libero di aprire una issue.

**D: Può davvero funzionare 100% in locale?**  

Sì, con i provider Ollama, lm-studio o server, tutto il riconoscimento vocale, LLM e sintesi vocale avvengono in locale. Le opzioni non locali (OpenAI o altre API) sono opzionali.

**D: Perché dovrei usare AgenticSeek quando ho Manus?**

A differenza di Manus, AgenticSeek dà priorità all’indipendenza dai sistemi esterni, offrendoti più controllo, privacy e risparmiando sui costi API.

**D: Chi c’è dietro il progetto?**

Il progetto è stato creato da me, insieme a due amici che sono manutentori e contributor dalla community open-source su GitHub. Siamo solo un gruppo di appassionati, non una startup né affiliati ad alcuna organizzazione.

Qualsiasi account AgenticSeek su X diverso dal mio personale (https://x.com/Martin993886460) è un’impersonificazione.

## Contribuisci

Cerchiamo sviluppatori per migliorare AgenticSeek! Dai un’occhiata alle issue aperte o alle discussioni.

[Guida al contributo](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Manutentori:

 > [Fosowl](https://github.com/Fosowl) | Fuso orario Parigi 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | Fuso orario Taipei 

 > [steveh8758](https://github.com/steveh8758) | Fuso orario Taipei 

## Ringraziamenti speciali:

 > [tcsenpai](https://github.com/tcsenpai) e [plitc](https://github.com/plitc) per l’aiuto con la dockerizzazione backend

## Sponsor:

Sponsor mensili da 5$ o più qui:
- **tatra-labs**
Certainly! Please provide the content of Part 4 of 4 that you would like me to translate into Italian.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---