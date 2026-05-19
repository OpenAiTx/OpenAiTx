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
  <a href="https://getcore.me">
    <img width="200px" alt="CORE logo" src="https://github.com/user-attachments/assets/bd4e5e79-05b8-4d40-9aff-f1cf9e5d70de" />
  </a>

# Il tuo sistema operativo AI personale.

**Avvia il tuo OS.** Osserva il tuo lavoro. Ricorda ciò che conta. Agisce attraverso i tuoi strumenti e agenti. Open source, auto-ospitato, tuo per sempre.

<p align="center">
    <a href="https://getcore.me">
        <img src="https://img.shields.io/badge/Website-getcore.me-c15e50?style=for-the-badge&logo=safari&logoColor=white" alt="Sito Web" />
    </a>
    <a href="https://docs.getcore.me">
        <img src="https://img.shields.io/badge/Docs-docs.getcore.me-22C55E?style=for-the-badge&logo=readthedocs&logoColor=white" alt="Documentazione" />
    </a>
    <a href="https://discord.gg/YGUZcvDjUa">
        <img src="https://img.shields.io/badge/Discord-community-5865F2?style=for-the-badge&logo=discord&logoColor=white" alt="Discord" />
    </a>
    <a href="https://github.com/RedPlanetHQ/core/blob/main/LICENSE">
        <img src="https://img.shields.io/badge/License-AGPL%203.0-blue?style=for-the-badge" alt="Licenza: AGPL 3.0" />
    </a>
</p>
</div>

---

## Vedilo in azione

Guarda CORE gestire due attività di coding dall'inizio alla fine:

[![CORE Demo](https://img.youtube.com/vi/7y_kt_UTYQs/maxresdefault.jpg)](https://www.youtube.com/watch?v=7y_kt_UTYQs)

---

## Che cos’è CORE

CORE è il livello operativo open-source per il lavoro AI-native.

Scrivi cosa deve essere fatto in un blocco note. CORE prende il compito, carica il contesto dalla memoria e dalle app collegate, abbozza un piano, esegue l’agente giusto tramite il gateway, gestisce i blocchi dove possibile e torna solo quando serve il giudizio umano.

Non è una chatbot da stimolare continuamente. È il livello che ricorda, coordina, agisce ed esegue l’escalation.

### L’architettura

| | |
|---|---|
| **Osserva** | Il contesto dalle tue conversazioni AI tramite MCP, oltre 50 app collegate, e su Mac, qualsiasi app a cui concedi accesso esplicito. |
| **Ricorda** | Un grafo della conoscenza che traccia non solo ciò che hai detto, ma anche cosa hai deciso, quando e perché, su ogni strumento e conversazione. |
| **Agisce** | Esegue azioni dirette nelle app collegate e delega i lavori lunghi ad agenti di coding e browser tramite il gateway. |
| **Politiche** | Flussi di approvazione, regole di escalation, piani e log di audit affinché l’autonomia resti responsabile. |

CORE decide cosa può fare in sicurezza, chiede prima di azioni sensibili e lascia una traccia che puoi revisionare.

---

## CORE in azione

### Delega un compito di coding, torna a una PR.

Dì a CORE cosa serve fare. Raccoglie contesto dal tuo repo, dalle app e dalla memoria, elabora un piano, esegue una sessione Claude Code o Codex, gestisce i blocchi dove può e riporta una PR. Tu revisioni quando ha finito.

`[ ] Risolvi la race condition nel flusso di checkout dalla issue #312`

### Svuota il backlog mentre dormi.

Imposta un’attività ricorrente per prelevare dal backlog a un orario stabilito. CORE lo gestisce mentre sei offline. Gli esiti regolari aspettano la review al mattino. Le sessioni bloccate tornano con una domanda mirata, non una scheda in stallo.

`[ ] Lavora sul backlog di stanotte a partire dalle 23:00`

### Indaga sugli alert prima che diventino interruzioni.

Imposta un’attività ricorrente per monitorare Sentry, log o qualsiasi fonte di alert. Quando qualcosa si attiva, CORE indaga, recupera trace e incidenti correlati e decide se gestire o escalare.

Un alert Sentry si attiva alle 2 di notte. CORE indaga, propone una soluzione e ti contatta su Slack per la review.

### Ricevi un brief mattutino che conosce il tuo lavoro.

Imposta un’attività ricorrente per estrarre da email, GitHub, Linear e Slack ogni mattina. CORE riassume cosa richiede attenzione, salta ciò che non serve e trasforma i follow-up in compiti automaticamente.

### Delega ovunque tu sia.

Crea compiti da Slack, WhatsApp, Telegram, email o web. Il gateway resta attivo in Docker o Railway, così CORE può lavorare anche a laptop chiuso.

---

## Cosa c’è dentro CORE

| | |
|---|---|
| **Memoria** | Tiene traccia delle tue preferenze, decisioni, obiettivi e direttive in tutti gli strumenti e conversazioni, così ogni attività parte con il contesto caricato. |
| **Attività** | Unità di lavoro singole o ricorrenti con la tua specifica, il piano di CORE, lo stato live e una chat dedicata. Ogni attività può generare sessioni di codifica o browser. |
| **Scratchpad** | Una pagina giornaliera per attività, idee e lavori in corso. Digita `[ ]` ovunque e CORE lo rileva entro 3 minuti. |
| **Connettori** | Oltre 50 app tramite un endpoint MCP, più trigger webhook per automazione proattiva. GitHub, Linear, Jira, Slack, Gmail, Calendar, Sentry, Granola, Todoist e altro. |
| **Skill** | Oltre 100 istruzioni riutilizzabili applicate automaticamente in base al contesto. Usa skill integrate o scrivi le tue per flussi di lavoro ripetibili. |
| **Gateway** | Esegue Claude Code, Codex, agenti browser e comandi locali sulla tua macchina o in Docker / Railway, così CORE continua a funzionare anche a laptop chiuso. |
| **Model agnostic** | Porta il tuo provider: Anthropic, OpenAI, o modelli open-weight. Self-host dell'intero stack per l'isolamento. |

---

## Cosa NON è CORE

| | |
|---|---|
| **Non è un wrapper RAG.** | La memoria non sono solo chunk embedded. È un grafo di conoscenza che traccia cosa hai deciso, quando e perché. |
| **Non è un costruttore di workflow.** | Niente DAG drag-and-drop. Scrivi cosa va fatto. CORE capisce il flusso di lavoro e chiede quando serve giudizio. |
| **Non è un altro Devin.** | CORE propone piani, tu approvi. CORE chiede sblocchi, tu decidi. CORE riporta PR, tu li revisioni. Gli agenti non fanno merge da soli. |
| **Non è un assistente cloud chiuso.** | CORE è open source, self-hostable, model-agnostic e progettato attorno alla tua infrastruttura. |

---

## Quickstart

Open source e self-hosted. I tuoi dati restano nella tua infrastruttura.

**Installa e avvia CORE:**

```bash
npm install -g @redplanethq/corebrain && corebrain setup
```

La procedura guidata di configurazione richiede una directory di installazione, un provider AI, una chiave API e un modello di chat. Genera le credenziali segrete, avvia lo stack e apre `http://localhost:3033`.

La maggior parte delle installazioni locali richiede alcuni minuti una volta che Docker è in esecuzione.

**Oppure distribuisci su Railway:**

[![Distribuisci su Railway](https://railway.app/button.svg)](https://railway.com/deploy/core)

**Collega un gateway** affinché CORE possa pilotare il tuo browser, eseguire agenti di codifica e accedere alle cartelle locali:

```bash
corebrain login
corebrain gateway setup
```

**Requisiti:** Docker 20.10+, Docker Compose 2.20+, 4 vCPU / 8GB RAM

[Guida completa all’auto-gestione](https://docs.getcore.me/self-hosting/setup)

> Vuoi l’app per Mac? Unisciti alla lista d’attesa su [getcore.me](https://www.getcore.me/).

---

## Benchmark

CORE raggiunge una precisione media dell’**88,24%** sul [benchmark LoCoMo](https://github.com/RedPlanetHQ/core-benchmark) su single-hop, multi-hop, open-domain e ragionamento temporale.

---

## In cosa crediamo

- La chat è un’interfaccia. Non un sistema operativo.
- L’intelligenza senza memoria è solo curiosità.
- La tua IA dovrebbe conoscerti in ogni strumento, non solo nella scheda attuale.
- Il lavoro dovrebbe passare dall’intento all’azione senza che tu sia il collante.
- L’automazione senza responsabilità è caos.

---

## Documentazione

- [**Memoria**](https://docs.getcore.me/memory/overview) - Grafo temporale della conoscenza, classificazione dei fatti, recupero guidato dall’intento
- [**Scratchpad**](https://docs.getcore.me/concepts/scratchpad) - La superficie quotidiana dove iniziano compiti e idee
- [**Task**](https://docs.getcore.me/concepts/tasks) - Piani, stato, lavoro ricorrente e contesto specifico del task
- [**Toolkit**](https://docs.getcore.me/concepts/toolkit) - Oltre 1000 azioni su più di 50 app tramite MCP
- [**Agente CORE**](https://docs.getcore.me/concepts/meta-agent) - Trigger, memoria, strumenti ed esecuzione
- [**Gateway**](https://docs.getcore.me/access-core/overview) - Accesso tramite WhatsApp, Slack, Telegram, email, web e API
- [**Skill**](https://docs.getcore.me/skills/overview) - Istruzioni riutilizzabili per flussi di lavoro ripetibili
- [**Auto-gestione**](https://docs.getcore.me/self-hosting/setup) - Guida completa al deployment
- [**Changelog**](https://docs.getcore.me/opensource/changelog) - Cosa è stato rilasciato

---

## Sicurezza

- Certificato CASA Tier 2
- TLS 1.3 in transito
- AES-256 a riposo
- I tuoi dati non vengono mai utilizzati per l'addestramento dei modelli
- Auto-hosting per completa isolamento
- [Politica di sicurezza](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)
- Vulnerabilità: harshith@poozle.dev

---

## Comunità

Stiamo costruendo CORE in modo pubblico.

Condividiamo la roadmap e le decisioni architetturali apertamente perché i problemi più difficili nella costruzione di un OS personale si risolvono meglio con le persone che lo usano. Metti una stella al repository, auto-hostalo, condividi ciò che costruisci e apri issue per ciò che è rotto o manca.

- [Discord](https://discord.gg/YGUZcvDjUa) - domande, idee, mostra-e-racconta
- [Documenti di contributo](https://docs.getcore.me/opensource/contributing) - come contribuire a CORE
- [`good-first-issue`](https://github.com/RedPlanetHQ/core/labels/good-first-issue) - inizia qui

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>

---

<div align="center">

**Auto-host il tuo OS AI personale.**

[Metti una stella a questo repo](https://github.com/RedPlanetHQ/core) · [Leggi i documenti](https://docs.getcore.me) · [Unisciti a Discord](https://discord.gg/YGUZcvDjUa)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---