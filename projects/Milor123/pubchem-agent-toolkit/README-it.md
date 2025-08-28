
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# Server MCP PubChem avanzato per assistenti AI

🧪 Un server MCP avanzato, robusto e attento alla privacy che consente agli assistenti AI di cercare e accedere in modo intelligente alle informazioni sui composti chimici da PubChem.

Questo server MCP PubChem funge da ponte potente tra gli assistenti AI (come quelli in AnythingLLM) e il vasto database chimico di PubChem. Sfrutta il Model Context Protocol (MCP) per permettere ai modelli AI di effettuare ricerche intelligenti e resilienti di composti chimici e recuperare le loro proprietà dettagliate in modo programmatico.

---

## ✨ Caratteristiche principali

Non è solo un altro wrapper PubChem. Questo server è stato ricostruito da zero per essere estremamente robusto e intelligente:

-   **🧠 Ricerca Intelligente di Riserva**: Se una ricerca per un nome comune (come "Vitamina D") fallisce, il server esegue automaticamente una ricerca più approfondita nel database PubChem Substance per trovare il composto corretto. Questo migliora notevolmente il tasso di successo per query ambigue.
-   **🛡️ Gestione degli Errori Robusta & Ritentativi**: Il server è progettato per gestire gli errori API con eleganza. Se riceve un errore "Server Busy" da PubChem, attenderà e ritenterà automaticamente la richiesta, assicurando che le tue query abbiano successo anche sotto carico elevato.
-   **🔒 Supporto Proxy Tor Opzionale**: Hai il pieno controllo sulla tua privacy. Un semplice file `config.ini` ti consente di instradare tutte le richieste tramite la rete Tor (via SOCKS5 o proxy HTTP), evitando che il tuo indirizzo IP venga esposto. Il server è sicuro di default e **non** divulgherà mai il tuo IP se la connessione proxy fallisce.
-   **🔎 Ricerca Singola & Multipla di Composti**: Gestisce senza problemi richieste per uno o più composti in un singolo prompt.
-   **🧪 Recupero Dettagliato delle Proprietà**: Accedi a proprietà chimiche chiave come Nome IUPAC, Formula Molecolare, Peso Molecolare e, soprattutto, **Massa Monoisotopica**.

---

---

### 🚀 Nessuna installazione richiesta: Provalo live su Smithery.ai

Per chi è nuovo ai server MCP o desidera testare le capacità di questo strumento senza alcuna configurazione locale, è disponibile una versione live ospitata su Smithery.ai. Questo ti consente di chattare con l'agente direttamente nel browser.

[**<-- Esplora l'agente PubChem live su Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Come iniziare:**

1.  Fai clic sul link sopra per andare alla pagina del server.
2.  Accedi utilizzando il tuo account **GitHub** o **Google**.
3.  Clicca sul pulsante **"Esplora capacità"** per aprire l'interfaccia chat e iniziare a testare!

> **✅ Modelli consigliati per i migliori risultati**
>
> Per ottenere la massima precisione, soprattutto con numeri decimali lunghi, consigliamo vivamente l'uso di modelli potenti. I seguenti sono stati testati e funzionano eccellentemente con questo strumento:
>
> *   **Claude 3 Sonnet di Anthropic**
> *   **GPT-4 Turbo di OpenAI** (o versioni più recenti come GPT-4o)
>
> Abbiamo confermato che entrambi i modelli hanno elaborato correttamente la piena precisione dei numeri decimali restituiti dallo strumento senza alcun arrotondamento.

---

## 🚀 Avvio rapido & Installazione

Questo server è progettato per essere eseguito localmente, sia sul tuo desktop che all'interno dell'ambiente Docker di AnythingLLM.

### 1. Dipendenze

Questo progetto si basa su alcune librerie Python. Assicurati che siano installate nel tuo ambiente.

Crea un file `requirements.txt` con il seguente contenuto:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Installali usando `uv` o `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Nota: `PySocks` è necessario solo se si prevede di utilizzare la funzione proxy SOCKS5 di Tor.)*

### 2. Configurazione

Il server viene configurato tramite un file `config.ini` che viene **creato automaticamente** la prima volta che lo si esegue. Questo file apparirà nella stessa directory dello script `pubchem_server.py`.

**`config.ini` predefinito:**
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

### 3. Integrazione con AnythingLLM

Segui la documentazione ufficiale per aggiungere questo come server MCP personalizzato. L'importante è puntare il `command` al tuo eseguibile Python e allo script `pubchem_server.py`.

**Esempio per AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
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


### 3.1 Esempi di Implementazione con AnythingLLM

Ecco alcuni esempi di come interagire con l’agente. Questi test sono stati condotti utilizzando AnythingLLM Desktop, collegandosi a vari Large Language Models tramite OpenRouter.

Una scoperta fondamentale emersa dai nostri test riguarda l’importanza del modello scelto. **Sconsigliamo vivamente l’utilizzo di modelli piccoli o locali** per questo compito. I modelli più piccoli spesso faticano a interpretare correttamente i dati restituiti dallo strumento, causando errori come valori allucinati, formattazione errata o, cosa più critica, **arrotondamento dei numeri decimali**, vanificando così lo scopo di questo strumento ad alta precisione.

Per garantire l’integrità dei risultati, è sempre buona pratica verificare i dati grezzi restituiti dal MCP. Puoi imparare come farlo nella prossima sezione: [3.2 Come verificare gli output del MCP nei log](#32-come-verificare-gli-output-del-mcp-nei-log).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

D’altra parte, diversi modelli hanno dimostrato prestazioni eccellenti. Abbiamo ottenuto risultati eccezionali con **Google `Gemini 2.5 Flash lite`**. ha mostrato una precisione notevole nella gestione di numeri decimali lunghi e nella corretta formattazione della tabella finale in Markdown.

Google gemini 2.5 flash lite senza prompt e con prompt mantiene i decimali perfetti (nell’esempio usa 0.6 di temperatura)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Per questo compito specifico, il mio preferito personale è **`Gemini 2.5 Flash lite`** grazie alla sua costante accuratezza e affidabilità.

### 3.2 Come Verificare gli Output del MCP nei Log

Il modo migliore per confermare che l’agente riceva i dati corretti e che il LLM non commetta errori è controllare il file di log di debug generato dal server MCP.

Questo server è configurato per creare automaticamente un file di log in una sottocartella all’interno della directory del tuo progetto. La posizione sarà:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

All'interno di `mcp_debug.log`, troverai i dati JSON esatti che lo strumento invia al LLM *prima* che il modello li elabori. Puoi ispezionare manualmente questo JSON per verificare qualsiasi valore, specialmente numeri decimali lunghi da proprietà come `monoisotopic_mass`, assicurandoti che il LLM non abbia introdotto errori di arrotondamento o allucinazioni nella risposta finale.

---

## 📊 Utilizzo

Una volta integrato, il tuo assistente AI utilizzerà automaticamente questo strumento quando gli verranno richieste informazioni chimiche. Lo strumento principale esposto è `search_compounds_by_name`.

### Esempio di Prompt

Questo prompt dimostra la capacità dello strumento di gestire un elenco di composti con vari tipi di nomi e recuperare più proprietà.

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

L'agente chiamerà lo strumento `search_compounds_by_name`, che troverà in modo intelligente ogni composto, ne recupererà i dati e li restituirà al LLM per la formattazione.

---

## 🛠 Strumento MCP Esposto

### `search_compounds_by_name`

Cerca più composti per nome, uno alla volta, utilizzando una strategia di fallback intelligente con pause e tentativi per la massima affidabilità.

**Parametri:**
-   `names` (List[str]): Una lista di nomi di composti. Esempio: `["Aspirina", "Ibuprofene"]`

**Restituisce:** Una lista di dizionari, dove ogni dizionario contiene le informazioni del composto trovato oppure un messaggio di errore che spiega perché la ricerca non è riuscita per quel composto specifico.

---

## 🙏 Ringraziamenti

Questo progetto è stato fortemente ispirato e costruito sulla base dell'originale [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) creato da **JackKuo666**.

Sebbene questo repository non sia un fork diretto, il progetto originale è stato il punto di partenza fondamentale. Questa versione migliora il concetto originale con un'attenzione particolare a robustezza estrema, strategie di ricerca intelligenti e privacy dell'utente tramite integrazione opzionale con Tor 🧅.

Molte grazie all'autore originale per il suo fantastico lavoro e per averlo condiviso con la comunità.

---

## ⚠️ Disclaimer

Questo strumento è destinato a scopi di ricerca ed educativi. Si prega di rispettare i termini di servizio di PubChem e di utilizzare questo strumento in modo responsabile.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---