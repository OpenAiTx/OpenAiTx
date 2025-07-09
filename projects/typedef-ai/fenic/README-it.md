<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: il dataframe (ri)costruito per l’inferenza LLM

[![PyPI version](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Python versions](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![License](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Documentazione**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic è un framework DataFrame ispirato a PySpark, proposto da typedef.ai, per la costruzione di applicazioni AI e agentiche. Trasforma dati strutturati e non strutturati in insight utilizzando operazioni DataFrame familiari, arricchite con intelligenza semantica. Supporto di prima classe per markdown, trascrizioni e operatori semantici, oltre a un’inferenza batch efficiente su qualsiasi provider di modelli.
## Installazione

fenic supporta Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### Configurazione del Provider LLM

fenic richiede una chiave API da almeno un provider LLM. Imposta la variabile d’ambiente appropriata per il provider scelto:

```bash
# Per OpenAI
export OPENAI_API_KEY="la-tua-openai-api-key"

# Per Anthropic
export ANTHROPIC_API_KEY="la-tua-anthropic-api-key"

# Per Google
export GEMINI_API_KEY="your-google-api-key"
```

## Avvio rapido

Il modo più veloce per imparare a usare fenic è consultare gli esempi.

Di seguito è riportato un elenco rapido degli esempi presenti in questo repository:

| Esempio                                                                 | Descrizione                                                                                                                         |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                    | Introduzione all’estrazione e classificazione semantica utilizzando gli operatori principali di fenic tramite l’analisi dei log di errore.                     |
| [Enrichment](examples/enrichment)                                       | DataFrame multi-stadio con estrazione di testo basata su template, join e trasformazioni potenziate da LLM, dimostrati tramite l’arricchimento dei log. |
| [Meeting Transcript Processing](examples/meeting_transcript_processing) | Parsing nativo delle trascrizioni, integrazione di schemi Pydantic e aggregazioni complesse mostrate tramite l’analisi delle riunioni.                    |
| [News Analysis](examples/news_analysis)                                 | Analizza ed estrai informazioni dagli articoli di notizie utilizzando operatori semantici ed elaborazione dati strutturata.                            |
| [Podcast Summarization](examples/podcast_summarization)                 | Elabora e riassumi le trascrizioni di podcast con analisi consapevole del parlante ed estrazione dei punti chiave.                                     |
| [Semantic Join](examples/semantic_joins)                                | Invece del semplice fuzzy matching, usa la potente funzionalità di join semantico di fenic per abbinare dati tra tabelle.                     |
| [Named Entity Recognition](examples/named_entity_recognition)           | Estrai e classifica entità nominate dal testo tramite estrazione e classificazione semantica.                                         |
| [Markdown Processing](examples/markdown_processing)                     | Elabora e trasforma documenti markdown con estrazione strutturata dei dati e formattazione.                                            |
| [JSON Processing](examples/json_processing)                             | Gestisci strutture dati JSON complesse con operazioni semantiche e validazione degli schemi.                                                 |
| [Feedback Clustering](examples/feedback_clustering)                     | Raggruppa e analizza i feedback utilizzando similarità semantica e operazioni di clustering.                                                     |
| [Document Extraction](examples/document_extraction)                     | Estrai informazioni strutturate da vari formati di documenti tramite operatori semantici.                                              |

(Sentiti libero di cliccare su qualsiasi esempio sopra per andare direttamente alla sua cartella.)
## Perché usare fenic?

fenic è un framework DataFrame ispirato a PySpark e orientato all’opinione, progettato per costruire applicazioni AI e agentiche di produzione.

A differenza degli strumenti di dati tradizionali adattati agli LLM, il motore di query di fenic è stato costruito da zero con l’inferenza in mente.

Trasforma dati strutturati e non strutturati in insight utilizzando operazioni DataFrame familiari, arricchite con intelligenza semantica. Con supporto di prima classe per markdown, trascrizioni e operatori semantici, oltre a un’inferenza batch efficiente su qualsiasi provider di modelli.

fenic porta l’affidabilità delle pipeline di dati tradizionali nei carichi di lavoro AI.

### Caratteristiche principali

#### Progettato appositamente per l’inferenza LLM

- Motore di query progettato da zero per carichi di lavoro AI, non adattato
- Ottimizzazione automatica dei batch per chiamate API
- Logica di retry integrata e limitazione della frequenza
- Conteggio dei token e monitoraggio dei costi

#### Operatori semantici come cittadini di prima classe
- `semantic.analyze_sentiment` - Analisi del sentiment integrata
- `semantic.classify` - Categorizzazione del testo con esempi few-shot
- `semantic.extract` - Trasforma testo non strutturato in dati strutturati tramite schemi
- `semantic.group_by` - Raggruppa dati per similarità semantica
- `semantic.join` - Unisce DataFrame in base al significato, non solo ai valori
- `semantic.map` - Applica trasformazioni in linguaggio naturale
- `semantic.predicate` - Crea predicati usando il linguaggio naturale per filtrare le righe
- `semantic.reduce` - Aggrega dati raggruppati con operazioni LLM

#### Supporto Nativo ai Dati Non Strutturati

Va oltre i tipici tipi di dati multimodali (audio, immagini) creando tipi specializzati per carichi di lavoro con molto testo:

- Parsing ed estrazione Markdown come tipo di dato di prima classe
- Elaborazione di trascrizioni (SRT, formati generici) con riconoscimento di speaker e timestamp
- Manipolazione JSON con espressioni JQ per dati annidati
- Suddivisione automatica del testo con sovrapposizione configurabile per documenti lunghi

#### Infrastruttura Pronta per la Produzione
- Supporto multi-provider (OpenAI, Anthropic, Gemini)
- Backend di esecuzione locali e cloud
- Gestione completa degli errori e logging
- Integrazione con Pydantic per la sicurezza dei tipi

#### API DataFrame Familiare

- Operazioni compatibili con PySpark
- Valutazione pigra e ottimizzazione delle query
- Supporto SQL per query complesse
- Integrazione senza soluzione di continuità con pipeline di dati esistenti

### Perché DataFrame per Applicazioni LLM e Agentiche?

Le applicazioni AI e agentiche sono fondamentalmente pipeline e flussi di lavoro - esattamente ciò per cui sono state progettate le API DataFrame. Invece di reinventare schemi per la trasformazione, il filtraggio e l’aggregazione dei dati, fenic sfrutta decenni di pratiche ingegneristiche comprovate.

#### Architettura Decoupled per Agenti Migliori

fenic crea una chiara separazione tra i compiti di inferenza pesante e le interazioni in tempo reale degli agenti. Spostando l’elaborazione batch fuori dal runtime dell’agente, si ottiene:

- Agenti più prevedibili e reattivi
- Migliore utilizzo delle risorse con chiamate LLM batch
- Separazione più pulita tra pianificazione/orchestrazione ed esecuzione
#### Progettato per Tutti gli Ingegneri

I DataFrame non sono solo per i professionisti dei dati. Il design dell’API fluida e componibile la rende accessibile a qualsiasi ingegnere:

- Collega le operazioni in modo naturale: `df.filter(...).semantic.group_by(...)`
- Mescola senza problemi stili imperativi e dichiarativi
- Inizia rapidamente con pattern familiari da pandas/PySpark o SQL

## Supporto

Unisciti alla nostra community su [Discord](https://discord.gg/GdqF3J7huR) dove puoi connetterti con altri utenti, fare domande e ricevere assistenza per i tuoi progetti fenic. La nostra community è sempre felice di accogliere nuovi arrivati!

Se trovi fenic utile, considera di lasciarci una ⭐ in cima a questo repository. Il tuo supporto ci aiuta a crescere e migliorare il framework per tutti!

## Contribuire

Accogliamo contributi di ogni tipo! Che tu sia interessato a scrivere codice, migliorare la documentazione, testare funzionalità o proporre nuove idee, il tuo aiuto è prezioso per noi.

Per gli sviluppatori che intendono inviare modifiche al codice, consigliamo di aprire prima una issue per discutere le idee prima di creare una Pull Request. Questo aiuta a garantire l’allineamento con la direzione del progetto ed evita sforzi duplicati.

Consulta le nostre [linee guida per i contributi](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) per informazioni dettagliate sul processo di sviluppo e sulla configurazione del progetto.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---