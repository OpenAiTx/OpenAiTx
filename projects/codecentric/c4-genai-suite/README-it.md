# c4 GenAI Suite

Un'applicazione chatbot AI con integrazione Model Context Provider (MCP), alimentata da Langchain e compatibile con tutti i principali Large Language Models (LLM) e modelli di Embedding.

Gli amministratori possono creare assistenti con diverse capacità aggiungendo estensioni, come servizi RAG (Retrieval-Augmented Generation) o server MCP. L'applicazione è costruita utilizzando uno stack tecnologico moderno, tra cui React, NestJS e Python FastAPI per il servizio REI-S.

Gli utenti possono interagire con gli assistenti tramite un'interfaccia intuitiva. A seconda della configurazione dell'assistente, gli utenti possono porre domande, caricare i propri file o utilizzare altre funzionalità. Gli assistenti interagiscono con vari provider LLM per fornire risposte basate sulle estensioni configurate. Le informazioni contestuali fornite dalle estensioni configurate consentono agli assistenti di rispondere a domande specifiche del dominio e fornire informazioni rilevanti.

L'applicazione è progettata per essere modulare ed estensibile, consentendo agli utenti di creare assistenti con diverse capacità aggiungendo estensioni.

![short demo video of basic usage](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Funzionalità

### Large Language Models (LLM) e modelli multimodali

La c4 GenAI Suite supporta già molti modelli direttamente. E se il modello preferito non è ancora supportato, dovrebbe essere semplice scrivere un'estensione per aggiungere il supporto.

* Modelli compatibili con OpenAI
* Modelli Azure OpenAI
* Modelli Bedrock
* Modelli Google GenAI
* Modelli compatibili con Ollama
### Retrieval Augmented Generation (RAG)

La c4 GenAI Suite include REI-S, un server per preparare i file per il consumo da parte dell’LLM.

* REI-S, un server RAG integrato personalizzato
  * Vector stores
    * pgvector
    * Azure AI Search
  * Modelli di embedding
    * Embedding compatibili con OpenAI
    * Embedding Azure OpenAI
    * Embedding compatibili con Ollama
  * Formati di file:
    * pdf, docx, pptx, xlsx, ...
    * trascrizione vocale di file audio (tramite Whisper)

### Estensioni

La c4 GenAI Suite è progettata per l’estensibilità. Scrivere estensioni è semplice, così come utilizzare un server MCP già esistente.

* Server Model Context Protocol (MCP)
* Systemprompt personalizzato
* Bing Search
* Calcolatrice
## Per Iniziare

### Utilizzo di Docker-Compose

- Esegui `docker compose up` nella directory principale del progetto.
- Apri l'[applicazione](http://localhost:3333) in un browser. Le credenziali di accesso predefinite sono utente `admin@example.com` e password `secret`.

![video che mostra la configurazione dell'assistente](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Utilizzo di Helm & Kubernetes

Per il deployment in ambienti Kubernetes, fare riferimento al [README del nostro Helm Chart](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Configurazione di Assistenti ed Estensioni

La c4 GenAI Suite ruota intorno agli *assistenti*.
Ogni assistente è composto da un set di estensioni, che determinano il modello LLM e quali strumenti può utilizzare.

- Nell'area amministrativa (clicca sul nome utente in basso a sinistra), vai alla [sezione assistenti](http://localhost:3333/admin/assistants).
- Aggiungi un assistente con il pulsante verde `+` accanto al titolo della sezione. Scegli un nome e una descrizione.
- Seleziona l'assistente creato e clicca sul verde `+ Aggiungi Estensione`.
- Seleziona il modello e inserisci le credenziali.
- Utilizza il pulsante `Test` per verificare che funzioni e `salva`.

Ora puoi tornare alla [pagina chat](http://localhost:3333/chat) (clicca su `c4 GenAI Suite` in alto a sinistra) e iniziare una nuova conversazione con il tuo nuovo assistente.

> [!TIP]
> Il nostro `docker-compose` include un Ollama locale, che gira sulla CPU. Puoi usarlo per test veloci. Tuttavia sarà lento e probabilmente vorrai usare un altro modello. Se vuoi usarlo, crea semplicemente la seguente estensione modello nel tuo Assistente.
> * Estensione: `Dev: Ollama`
> * Endpoint: `http://ollama:11434`
> * Modello: `llama3.2`

### Protocollo Model Context (MCP) [opzionale]

Utilizza qualsiasi server MCP che offra un'interfaccia `sse` con l'Estensione `MCP Tools` (oppure utilizza il nostro `mcp-tool-as-server` come proxy davanti a un server MCP `stdio`).
Ogni server MCP può essere configurato in dettaglio come estensione.

### Retrieval Augmented Generation (RAG) / Ricerca File [opzionale]

Utilizza il nostro server RAG `REI-S` per cercare nei file forniti dall’utente. È sufficiente configurare un’estensione `Search Files` per l’assistente.
Questo processo è descritto in dettaglio nella [sottodirectory `services/reis`](services/reis/#example-configuration-in-c4).

## Contribuire & Sviluppo

* Consulta [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) per le linee guida su come contribuire.
* Per l’onboarding degli sviluppatori, consulta [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Principali Componenti

L’applicazione è composta da un **Frontend**, un **Backend** e un servizio **REI-S**.

```
┌──────────┐
│   Utente │
└─────┬────┘
      │ accesso
      ▼
┌──────────┐
│ Frontend │
└─────┬────┘
      │ accesso
      ▼
┌──────────┐     ┌──────────────────┐
│ Backend  │────►│      LLM         │
└─────┬────┘     └──────────────────┘
      │ accesso
      ▼
┌──────────┐     ┌──────────────────┐
│  REI-S   │────►│ Modello di       │
│          │     │ Embedding        │
│          │     └──────────────────┘
│          │
│          │     ┌──────────────────┐
│          │────►│ Vector Store     │
└──────────┘     └──────────────────┘
```
### Frontend

Il frontend è sviluppato con React e TypeScript, offrendo un'interfaccia utente intuitiva per interagire con il backend e il servizio REI-S. Include funzionalità per la gestione degli assistenti, delle estensioni e delle funzionalità di chat.

> Fonti: `/frontend`

### Backend

Il backend è sviluppato utilizzando NestJS e TypeScript, fungendo da principale livello API per l'applicazione. Gestisce le richieste provenienti dal frontend e interagisce con i provider llm per facilitare le funzionalità di chat. Il backend gestisce inoltre assistenti e le loro estensioni, permettendo agli utenti di configurare e utilizzare vari modelli AI per le loro chat.

Inoltre, il backend gestisce l'autenticazione degli utenti e comunica con il servizio REI-S per l'indicizzazione e il recupero dei file.

Per la persistenza dei dati, il backend utilizza un database **PostgreSQL**.

> Fonti: `/backend`

### REI-S

Il REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) è un server basato su Python che fornisce funzionalità di base RAG (Retrieval-Augmented Generation). Consente l’estrazione, l’indicizzazione e l’interrogazione dei contenuti dei file, permettendo all’applicazione di gestire grandi dataset in modo efficiente. Il servizio REI-S è progettato per funzionare in modo integrato con il backend, fornendo i dati necessari per le funzionalità di chat e la ricerca dei file.

Il REI-S supporta Azure AI Search e pgvector per l’archiviazione vettoriale, offrendo opzioni di recupero dati flessibili e scalabili. Il servizio può essere configurato tramite variabili d'ambiente per specificare il tipo di archivio vettoriale e i dettagli di connessione.

> Fonti: `/services/reis`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---