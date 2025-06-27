# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Questo repository contiene Gemini CLI, uno strumento AI a riga di comando che si connette ai tuoi strumenti, comprende il tuo codice e accelera i tuoi flussi di lavoro.

Con Gemini CLI puoi:

- Interrogare e modificare grandi codebase all'interno e oltre la finestra di contesto da 1M token di Gemini.
- Generare nuove app da PDF o schizzi, utilizzando le capacità multimodali di Gemini.
- Automatizzare attività operative, come interrogare pull request o gestire rebasing complessi.
- Utilizzare strumenti e server MCP per connettere nuove funzionalità, inclusa la [generazione di media con Imagen, Veo o Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- Ancorare le tue query con lo strumento [Google Search](https://ai.google.dev/gemini-api/docs/grounding), integrato in Gemini.

## Avvio rapido

1. **Prerequisiti:** Assicurati di avere installato [Node.js versione 18](https://nodejs.org/en/download) o superiore.
2. **Esegui la CLI:** Esegui il seguente comando nel tuo terminale:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Oppure installala con:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Scegli un tema colore**
4. **Autenticazione:** Quando richiesto, accedi con il tuo account Google personale. Questo ti garantirà fino a 60 richieste modello al minuto e 1.000 richieste modello al giorno utilizzando Gemini.

Ora sei pronto per utilizzare Gemini CLI!

### Per un uso avanzato o limiti aumentati:

Se hai bisogno di utilizzare un modello specifico o richiedi una maggiore capacità di richieste, puoi usare una chiave API:

1. Genera una chiave da [Google AI Studio](https://aistudio.google.com/apikey).
2. Impostala come variabile d'ambiente nel tuo terminale. Sostituisci `YOUR_API_KEY` con la tua chiave generata.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Per altri metodi di autenticazione, inclusi account Google Workspace, consulta la guida [autenticazione](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Esempi

Una volta che la CLI è in esecuzione, puoi iniziare a interagire con Gemini dal tuo terminale.

Puoi iniziare un progetto da una nuova directory:

```sh
cd new-project/
gemini
> Scrivimi un bot Discord Gemini che risponda alle domande usando un file FAQ.md che fornirò
```

Oppure lavorare con un progetto esistente:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Dammi un riepilogo di tutte le modifiche apportate ieri
```

### Prossimi passi

- Scopri come [contribuire o costruire dal sorgente](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Esplora i **[Comandi CLI disponibili](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Se riscontri problemi, consulta la **[Guida alla risoluzione dei problemi](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Per una documentazione più completa, consulta la [documentazione completa](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Dai un'occhiata ad alcuni [task popolari](#popular-tasks) per ulteriori spunti.

### Risoluzione dei problemi

Consulta la guida [risoluzione dei problemi](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) se hai difficoltà.

## Task popolari

### Esplora una nuova codebase

Inizia facendo `cd` in una repository esistente o appena clonata ed eseguendo `gemini`.

```text
> Descrivi i principali componenti dell'architettura di questo sistema.
```

```text
> Quali meccanismi di sicurezza sono implementati?
```

### Lavora con il tuo codice esistente

```text
> Implementa una prima bozza per l'issue GitHub #123.
```

```text
> Aiutami a migrare questa codebase all'ultima versione di Java. Parti da un piano.
```

### Automatizza i tuoi flussi di lavoro

Usa i server MCP per integrare gli strumenti del tuo sistema locale con la suite di collaborazione aziendale.

```text
> Creami una presentazione che mostri la cronologia git degli ultimi 7 giorni, raggruppata per funzionalità e membro del team.
```

```text
> Crea una web app a schermo intero per un display a muro che mostri le issue GitHub con più interazioni.
```

### Interagisci con il tuo sistema

```text
> Converti tutte le immagini in questa directory in png e rinominale usando le date dai dati exif.
```

```text
> Organizza le mie fatture PDF per mese di spesa.
```

## Termini di servizio e Informativa sulla privacy

Per dettagli sui termini di servizio e sull'informativa sulla privacy applicabili all'uso di Gemini CLI, consulta i [Termini di servizio e Informativa sulla privacy](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---