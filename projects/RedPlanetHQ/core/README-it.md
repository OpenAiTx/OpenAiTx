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

### CORE: Il tuo Strato di Memoria Personale per le App AI

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="Badge DeepWiki" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Documentazione</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Risultati della Ricerca

La memoria CORE raggiunge una precisione media del **88,24%** sul dataset Locomo in tutti i compiti di ragionamento, superando significativamente altri fornitori di memoria. Consulta questo [blog](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/) per ulteriori informazioni.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Le domande single-hop richiedono risposte basate su una singola sessione; (2) Le domande multi-hop richiedono di sintetizzare informazioni da più sessioni diverse; (3) Le domande di conoscenza open-domain possono essere risposte integrando le informazioni fornite dal parlante con conoscenze esterne come il senso comune o fatti mondiali; (4) Le domande di ragionamento temporale possono essere risposte tramite ragionamento temporale e cattura di indizi relativi al tempo all’interno della conversazione;

## Panoramica

**Problema**

Gli sviluppatori perdono tempo a rispiegare il contesto agli strumenti AI. Superi i limiti di token su Claude? Ricominci da capo e perdi tutto. Passi da ChatGPT/Claude a Cursor? Spiega di nuovo il tuo contesto. Le tue conversazioni, decisioni e intuizioni svaniscono tra le sessioni. Con ogni nuovo strumento AI, il costo del cambio di contesto aumenta.

**Soluzione** - **CORE** (**Contextual Observation & Recall Engine**)

CORE è un layer di memoria unificato e persistente open-source per tutti i tuoi strumenti AI. Il tuo contesto ti segue da Cursor a Claude, da ChatGPT a Claude Code. Un unico knowledge graph ricorda chi ha detto cosa, quando e perché. Connettiti una volta, ricorda ovunque. Smetti di gestire il contesto e inizia a costruire.

## 🚀 CORE Self-Hosting
Vuoi eseguire CORE sulla tua infrastruttura? L’auto-hosting ti offre il pieno controllo sui tuoi dati e sul deployment.

**Prerequisiti**:

- Docker (20.10.0+) e Docker Compose (2.20.0+) installati
- Chiave API OpenAI

> **Nota sui Modelli Open-Source:** Abbiamo testato opzioni OSS come Ollama e modelli GPT, ma la loro estrazione di fatti e la qualità dei grafi non sono risultate sufficienti. Siamo attivamente alla ricerca di alternative.

### Installazione

1. Clona il repository:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Configura le variabili d'ambiente in `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. Avvia il servizio
```
docker-compose up -d
```

Una volta effettuato il deployment, puoi configurare i tuoi provider AI (OpenAI, Anthropic) e iniziare a costruire il tuo grafo di memoria.

👉 [Visualizza la guida completa per l’auto-hosting](https://docs.heysol.ai/self-hosting/docker)

Nota: Abbiamo provato modelli open-source come Ollama o GPT OSS, ma la generazione dei fatti non era soddisfacente; stiamo ancora cercando di migliorare questo aspetto e in seguito supporteremo anche i modelli OSS.

## 🚀 CORE Cloud
**Costruisci il tuo grafo di memoria unificato in 5 minuti:**

Non vuoi gestire l’infrastruttura? CORE Cloud ti permette di creare istantaneamente il tuo sistema personale di memoria: nessuna configurazione, nessun server, solo memoria che funziona.

1. **Registrati** su [core.heysol.ai](https://core.heysol.ai) e crea il tuo account
2. **Visualizza il tuo grafo di memoria** e osserva come CORE connette automaticamente i fatti tra loro
3. **Provalo** - chiedi "Cosa sai di me?" nella sezione conversazione
4. Collega i tuoi strumenti:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - coding contestualizzato
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) - coding da terminale con memoria
   - [Aggiungi Estensione Browser](https://docs.heysol.ai/providers/browser-extension) - porta la tua memoria su qualsiasi sito web
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) - aggiungi automaticamente il contesto dei progetti

## 🧩 Funzionalità Chiave

### 🧠 **Memoria Unificata e Portatile**: 
Aggiungi e richiama la tua memoria su **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS Kiro, VS Code e Roo Code** tramite MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Grafo di Conoscenza Temporale e Reificato**: 

Ricorda la storia dietro ogni fatto—traccia chi ha detto cosa, quando e perché con relazioni ricche e piena provenienza, non solo archiviazione piatta

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Estensione Browser**: 

Salva conversazioni e contenuti da ChatGPT, Grok, Gemini, Twitter, YouTube, post di blog e qualsiasi pagina web direttamente nella tua memoria CORE.

**Come utilizzare l'estensione**
1. [Scarica l'estensione](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) dal Chrome Web Store.
2. Accedi al [dashboard CORE](https://core.heysol.ai)
   - Vai su Impostazioni (in basso a sinistra)
   - Vai su API Key → Genera nuova chiave → Chiamala “estensione.”
3. Apri l'estensione, incolla la tua chiave API e salva.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Chatta con la Memoria**: 
Fai domande come "Quali sono le mie preferenze di scrittura?" e ricevi informazioni immediate dalla tua conoscenza collegata

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Sincronizzazione automatica dalle app**:

Cattura automaticamente il contesto rilevante da Linear, Slack, Notion, GitHub e altre app connesse nella tua memoria CORE

📖 **[Visualizza tutte le integrazioni](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - Elenco completo dei servizi supportati e delle loro funzionalità

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP Integration Hub**: 

Collega Linear, Slack, GitHub, Notion una sola volta a CORE—poi usa tutti i loro strumenti in Claude, Cursor, o qualsiasi client MCP con un singolo URL


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Come CORE crea memoria

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

La pipeline di ingestione di CORE ha quattro fasi progettate per catturare il contesto in evoluzione:

1. **Normalizzazione**: Collega le nuove informazioni al contesto recente, suddivide i documenti lunghi in blocchi coerenti mantenendo i riferimenti incrociati e standardizza i termini, così quando CORE estrae conoscenza, lavora con input puliti e contestualizzati invece che con testo disordinato.
2. **Estrazione**: Ricava significato dal testo normalizzato identificando entità (persone, strumenti, progetti, concetti), trasformandole in affermazioni con contesto, fonte e tempo, e mappando le relazioni. Ad esempio, “Abbiamo scritto CORE in Next.js” diventa: Entità (Core, Next.js), Affermazione (CORE è stato sviluppato usando Next.js) e Relazione (è stato sviluppato usando).
3. **Risoluzione**: Rileva contraddizioni, traccia come evolvono le preferenze e preserva molteplici prospettive con provenienza invece di sovrascriverle, così la memoria riflette il tuo percorso completo, non solo l'istantanea più recente.
4. **Integrazione nel Grafo**: Collega entità, affermazioni ed episodi in un grafo di conoscenza temporale che unisce i fatti al loro contesto e alla loro storia, trasformando dati isolati in una rete vivente di conoscenza che gli agenti possono effettivamente usare.

Il risultato: Invece di un database piatto, CORE ti offre una memoria che cresce e si evolve con te - preservando contesto, evoluzione e proprietà, così gli agenti possono davvero utilizzarla.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Come CORE richiama dalla memoria

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Quando chiedi qualcosa a CORE, non si limita a cercare testo - esplora l'intero grafo di conoscenza per trovare le risposte più utili.

1. **Ricerca**: CORE esplora la memoria da più angolazioni contemporaneamente - ricerca per parola chiave per corrispondenze esatte, ricerca semantica per idee correlate anche se espresse diversamente, e attraversamento del grafo per seguire i collegamenti tra concetti connessi.
2. **Riordinamento**: I risultati recuperati vengono riorganizzati per evidenziare quelli più rilevanti e diversi, garantendo che tu non veda solo corrispondenze ovvie ma anche connessioni più profonde.
3. **Filtraggio**: CORE applica filtri intelligenti basati su tempo, affidabilità e forza della relazione, così emergono solo le conoscenze più significative.
4. **Output**: Ricevi sia fatti (affermazioni chiare) che episodi (il contesto originale da cui provengono), così il richiamo è sempre ancorato a contesto, tempo e storia.

Il risultato: CORE non si limita a ricordare i fatti - li richiama nel contesto, tempo e storia corretti, così gli agenti possono rispondere come faresti tu.

## Documentazione

Esplora la nostra documentazione per sfruttare al meglio CORE

- [Concetti di base](https://docs.heysol.ai/concepts/memory_graph)
- [Self Hosting](https://docs.heysol.ai/self-hosting/overview)
- [Collega Core MCP con Claude](https://docs.heysol.ai/providers/claude)
- [Collega Core MCP con Cursor](https://docs.heysol.ai/providers/cursor)
- [Collega Core MCP con Claude Code](https://docs.heysol.ai/providers/claude-code)
- [Collega Core MCP con Codex](https://docs.heysol.ai/providers/codex) 

- [Concetti di base](https://docs.heysol.ai/overview)
- [Riferimento API](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Sicurezza

CORE prende la sicurezza sul serio. Implementiamo pratiche di sicurezza standard del settore per proteggere i tuoi dati:

- **Crittografia dei dati**: Tutti i dati in transito (TLS 1.3) e a riposo (AES-256)
- **Autenticazione**: OAuth 2.0 e autenticazione tramite magic link
- **Controllo degli accessi**: Isolamento basato su workspace e permessi basati sui ruoli
- **Segnalazione delle vulnerabilità**: Si prega di segnalare i problemi di sicurezza a harshith@poozle.dev

Per informazioni dettagliate sulla sicurezza, consulta la nostra [Security Policy](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Supporto

Hai domande o feedback? Siamo qui per aiutarti:

- Discord: [Unisciti al canale core-support](https://discord.gg/YGUZcvDjUa)
- Documentazione: [docs.heysol.ai](https://docs.heysol.ai)
- Email: manik@poozle.dev

## Linee guida sull'utilizzo

**Memorizzare:**

- Cronologia delle conversazioni
- Preferenze utente
- Contesto dei task
- Materiali di riferimento

**Non memorizzare:**

- Dati sensibili (PII)
- Credenziali
- Log di sistema
- Dati temporanei

## 👥 Collaboratori

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---