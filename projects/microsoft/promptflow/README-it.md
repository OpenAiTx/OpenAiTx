# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Unisciti a noi per migliorare prompt flow partecipando alle [discussioni](https://github.com/microsoft/promptflow/discussions), aprendo [issue](https://github.com/microsoft/promptflow/issues/new/choose), inviando [PRs](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** è una suite di strumenti di sviluppo progettata per semplificare il ciclo di sviluppo end-to-end delle applicazioni AI basate su LLM, dall’ideazione, prototipazione, test, valutazione fino al deployment in produzione e al monitoraggio. Rende l’ingegnerizzazione dei prompt molto più semplice e consente di costruire applicazioni LLM di qualità produttiva.

Con prompt flow, sarai in grado di:

- **Creare e sviluppare iterativamente flow**
    - Crea [flow](https://microsoft.github.io/promptflow/concepts/concept-flows.html) eseguibili che collegano LLM, prompt, codice Python e altri [strumenti](https://microsoft.github.io/promptflow/concepts/concept-tools.html).
    - Effettua il debug e migliora i tuoi flow, in particolare [tracciando l’interazione con gli LLM](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) in modo semplice.
- **Valutare la qualità e le prestazioni del flow**
    - Valuta la qualità e le prestazioni del tuo flow con dataset più ampi.
    - Integra i test e la valutazione nel tuo sistema CI/CD per garantire la qualità del flow.
- **Ciclo di sviluppo ottimizzato per la produzione**
    - Distribuisci il tuo flow sulla piattaforma di servizio che preferisci o integralo facilmente nel codice della tua applicazione.
    - (Opzionale ma altamente consigliato) Collabora con il tuo team sfruttando la versione cloud di [Prompt flow in Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Installazione

Per iniziare rapidamente, puoi utilizzare un ambiente di sviluppo preconfigurato. **Clicca il pulsante qui sotto** per aprire il repository in GitHub Codespaces, poi continua a leggere il readme!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Se vuoi iniziare nel tuo ambiente locale, installa prima i pacchetti:

Assicurati di avere un ambiente python, si raccomanda `python>=3.9, <=3.11`.

```sh
pip install promptflow promptflow-tools
```

## Quick Start ⚡

**Crea un chatbot con prompt flow**

Esegui il comando per avviare un prompt flow da un template di chat; verrà creata una cartella chiamata `my_chatbot` e generati i file necessari al suo interno:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Configura una connessione per la tua chiave API**

Per la chiave OpenAI, crea una connessione eseguendo il comando e utilizzando il file `openai.yaml` nella cartella `my_chatbot`, che memorizza la tua chiave OpenAI (sovrascrivi chiavi e nome con --set per evitare modifiche al file yaml):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Per la chiave Azure OpenAI, crea la connessione eseguendo il comando e utilizzando il file `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Chatta con il tuo flow**

Nella cartella `my_chatbot` è presente un file `flow.dag.yaml` che descrive il flow, inclusi input/output, nodi, connessione e modello LLM, ecc.

> Nota che nel nodo `chat` stiamo utilizzando una connessione chiamata `open_ai_connection` (specificata nel campo `connection`) e il modello `gpt-35-turbo` (specificato nel campo `deployment_name`). Il campo deployment_name serve per specificare il modello OpenAI, oppure la risorsa di deployment di Azure OpenAI.

Interagisci con il tuo chatbot eseguendo: (premi `Ctrl + C` per terminare la sessione)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Valore chiave: garantire "Alta Qualità” dal prototipo alla produzione**

Esplora il nostro [**tutorial di 15 minuti**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) che ti guida attraverso ottimizzazione del prompt ➡ test di batch ➡ valutazione, tutto progettato per garantire un'alta qualità pronta per la produzione.

Prossimo passo! Continua con la sezione **Tutorial**  👇 per approfondire prompt flow.

## Tutorial 🏃‍♂️

Prompt flow è uno strumento progettato per **costruire applicazioni LLM di alta qualità**; il processo di sviluppo in prompt flow segue questi passaggi: sviluppa un flow, migliora la qualità del flow, distribuisci il flow in produzione.

### Sviluppa le tue applicazioni LLM

#### Estensione VS Code

Offriamo anche un'estensione per VS Code (un designer di flow) per un'esperienza di sviluppo flow interattiva con interfaccia grafica.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Puoi installarla dal <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">Visual Studio Marketplace</a>.

#### Approfondisci lo sviluppo dei flow

[Getting started with prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): Una guida passo passo per eseguire il tuo primo flow.

### Impara dai casi d’uso

[Tutorial: Chat with PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Un tutorial end-to-end su come costruire una chat application di alta qualità con prompt flow, includendo sviluppo del flow e valutazione con metriche.
> Altri esempi sono disponibili [qui](https://microsoft.github.io/promptflow/tutorials/index.html#samples). Accogliamo volentieri contributi di nuovi casi d’uso!

### Setup per i contributori

Se sei interessato a contribuire, inizia dalla nostra guida di setup per sviluppatori: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Prossimo passo! Continua con la sezione **Contributing**  👇 per contribuire a prompt flow.

## Contributing

Questo progetto accoglie contributi e suggerimenti. La maggior parte dei contributi richiede di accettare un Contributor License Agreement (CLA) che dichiari di avere il diritto di concedere, e di fatto concedere, i diritti di utilizzo del tuo contributo. Per dettagli, visita https://cla.opensource.microsoft.com.

Quando invii una pull request, un bot CLA determinerà automaticamente se è necessario fornire un CLA e contrassegnerà la PR in modo appropriato (ad esempio, con un controllo di stato o un commento). Segui semplicemente le istruzioni fornite dal bot. Dovrai farlo solo una volta per tutti i repository che utilizzano il nostro CLA.

Questo progetto ha adottato il [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Per ulteriori informazioni consulta le [FAQ del Codice di Condotta](https://opensource.microsoft.com/codeofconduct/faq/) o contatta [opencode@microsoft.com](mailto:opencode@microsoft.com) per domande o commenti aggiuntivi.

## Marchi

Questo progetto può contenere marchi o loghi di progetti, prodotti o servizi. L'uso autorizzato di marchi o loghi Microsoft è soggetto e deve seguire le [Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
L'uso di marchi o loghi Microsoft in versioni modificate di questo progetto non deve creare confusione o implicare la sponsorizzazione da parte di Microsoft.
Qualsiasi uso di marchi o loghi di terze parti è soggetto alle politiche delle terze parti stesse.

## Codice di Condotta

Questo progetto ha adottato il [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Per ulteriori informazioni consulta le [FAQ del Codice di Condotta](https://opensource.microsoft.com/codeofconduct/faq/)
o contatta [opencode@microsoft.com](mailto:opencode@microsoft.com)
per domande o commenti aggiuntivi.

## Raccolta Dati

Il software può raccogliere informazioni su di te e sull’uso che fai del software e inviarle a Microsoft se configurato per abilitare la telemetria.
Microsoft può utilizzare queste informazioni per fornire servizi e migliorare i propri prodotti e servizi.
Puoi attivare la telemetria come descritto nel repository.
Ci sono anche alcune funzionalità nel software che possono permettere a te e a Microsoft di raccogliere dati dagli utenti delle tue applicazioni. Se utilizzi queste funzionalità, devi rispettare la normativa vigente, incluso fornire adeguate informative agli utenti delle tue applicazioni insieme a una copia dell’informativa sulla privacy di Microsoft. La nostra informativa sulla privacy si trova su https://go.microsoft.com/fwlink/?LinkID=824704. Puoi saperne di più sulla raccolta e sull’uso dei dati nella documentazione di aiuto e nell’informativa sulla privacy. L’uso del software costituisce il tuo consenso a queste pratiche.

### Configurazione Telemetria

La raccolta telemetria è attiva per impostazione predefinita.

Per disattivarla, esegui `pf config set telemetry.enabled=false`.

## Licenza

Copyright (c) Microsoft Corporation. Tutti i diritti riservati.

Concesso in licenza secondo la licenza [MIT](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---