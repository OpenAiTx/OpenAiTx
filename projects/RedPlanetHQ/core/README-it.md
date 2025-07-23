<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### C.O.R.E: Il tuo cervello digitale per l’era dell’IA

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>Documentazione</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**Contextual Observation & Recall Engine**

C.O.R.E è un grafo di memoria portatile creato dalle tue interazioni con LLM e dai tuoi dati personali, rendendo tutto il tuo contesto e la cronologia dei flussi di lavoro accessibile a qualsiasi strumento IA, proprio come un cervello digitale. Questo elimina la necessità di ripetere la condivisione del contesto. L’obiettivo è fornire:

- **Memoria Unificata e Portatile**: Aggiungi e richiama il contesto senza soluzione di continuità e collega la tua memoria tra app come Claude, Cursor, Windsurf e altre.
- **Relazionale, non solo Fatti Piatti**: CORE organizza la tua conoscenza, memorizzando sia fatti che relazioni per una memoria più profonda e ricca, come un vero cervello.
- **Di Proprietà dell’Utente**: Decidi tu cosa conservare, aggiornare o eliminare e condividi la tua memoria tra gli strumenti che desideri, liberandoti dal lock-in del fornitore.

## 🎥 Video Dimostrativo

[Guarda la Demo di C.O.R.E](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Core dashboard" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  Caratteristiche Principali

- **Grafo di Memoria**: Visualizza come i tuoi fatti e preferenze sono collegati tra loro
- **Chat con la Memoria**: Fai domande sulla memoria per ottenere informazioni e comprensione immediate
- **Plug n Play**: Usa subito la memoria CORE in app come Cursor, Claude

## ☁️ Configurazione C.O.R.E Cloud

1. Iscriviti a [Core Cloud](https://core.heysol.ai) e inizia a costruire il tuo grafo di memoria.
2. Aggiungi il testo che desideri salvare in memoria. Una volta cliccato il pulsante `+ Aggiungi` il tuo grafo di memoria sarà generato.
3. [Collega Core Memory MCP con Cursor](#connecting-core-mcp-with-cursor)

## 💻 Configurazione Locale di C.O.R.E

#### Prerequisiti

1. Docker
2. Chiave API OpenAI


> **Nota:** Stiamo lavorando attivamente per migliorare il supporto ai modelli Llama. Al momento, C.O.R.E non fornisce risultati ottimali con i modelli basati su Llama, ma stiamo facendo progressi per garantire una migliore compatibilità e risultati nel prossimo futuro.
> 
#### Avvia C.O.R.E in locale

1. **Copia le Variabili d’Ambiente**

   Copia il file di esempio delle variabili d’ambiente in `.env`:


   ```bash
   cp .env.example .env
   ```
2. **Avvia l'applicazione**

   Usa Docker Compose per avviare tutti i servizi richiesti:


   ```bash
   docker-compose up
   ```
3. **Accedi all'App**

   Una volta che i container sono in esecuzione, apri il browser e vai su [http://localhost:3000](http://localhost:3000).

4. **Crea un account con Magic Link**

   - Per creare un account, clicca sul pulsante `Continua con email`

     <img width="865" height="490" alt="Crea account" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - Inserisci la tua email e clicca sul pulsante `Invia un Magic Link`

     <img width="824" height="429" alt="Inserisci email" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `Copia il magic link dai log del terminale` e aprilo nel browser

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **Crea il tuo Spazio Privato & Aggiungi Dati**

   - Nella dashboard, vai nella sezione in alto a destra -> Digita un messaggio, ad esempio, `Adoro giocare a badminton`, e clicca su `+Aggiungi`.
   - La tua memoria viene messa in coda per l'elaborazione; puoi monitorare lo stato nella sezione `Logs`.
     
     <img width="1496" height="691" alt="Core memory logs" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - Una volta completata l'elaborazione, i nodi saranno aggiunti al tuo grafo di conoscenza privato e visibili nella dashboard.
   - In seguito potrai scegliere se collegare questa memoria ad altri strumenti o mantenerla privata.

6. **Cerca nella tua Memoria**

   - Usa la funzione di ricerca della dashboard per interrogare i dati caricati nel tuo spazio privato.


## Collegare CORE MCP con Cursor

1. Apri la dashboard di CORE e vai nella sezione API per generare un nuovo token API.
2. In Cursor, vai su: Impostazioni → Strumenti & Integrazioni → Nuovo MCP Server.
3. Aggiungi il server CORE MCP utilizzando il formato di configurazione qui sotto. Assicurati di sostituire il valore di API_TOKEN con il token generato al passo 1.

   Configurazione MCP da aggiungere in Cursor


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. Vai su Impostazioni -> Regole utente -> Nuova regola -> e aggiungi la seguente regola per assicurarti che tutte le tue interazioni in chat vengano memorizzate nella memoria CORE


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## Documentazione

Esplora la nostra documentazione per ottenere il massimo da CORE
- [Concetti di Base](https://docs.heysol.ai/core/overview)
- [Riferimento API](https://docs.heysol.ai/core/local-setup)
- [Collega Core Memory MCP con Cursor](#connecting-core-mcp-with-cursor)


## 🧑‍💻 Supporto
Hai domande o feedback? Siamo qui per aiutarti:
- Discord: [Unisciti al canale core-support](https://discord.gg/YGUZcvDjUa)
- Documentazione: [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- Email: manik@poozle.dev

## Linee Guida d'Uso

**Da memorizzare:**

- Cronologia conversazioni
- Preferenze utente
- Contesto dei compiti
- Materiali di riferimento

**Da non memorizzare:**

- Dati sensibili (PII)
- Credenziali
- Log di sistema
- Dati temporanei

## 👥 Contributori

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---