# Specifica del Protocollo Universale di Chiamata Strumenti (UTCP)

Questo repository contiene la documentazione ufficiale della specifica per il Protocollo Universale di Chiamata Strumenti (UTCP). UTCP è uno standard moderno, flessibile e scalabile per definire e interagire con strumenti attraverso vari protocolli di comunicazione.

## Che cos'è UTCP?

UTCP fornisce un modo standardizzato per i sistemi di intelligenza artificiale e altri client di scoprire e chiamare strumenti da diversi fornitori, indipendentemente dal protocollo sottostante utilizzato (HTTP, WebSocket, CLI, ecc.). Questa specifica definisce:

- Meccanismi di scoperta degli strumenti
- Formati di chiamata degli strumenti
- Configurazione del fornitore
- Metodi di autenticazione
- Gestione delle risposte

## Come contribuire alla specifica

Accogliamo con piacere i contributi alla specifica UTCP! Ecco come puoi contribuire:

1. **Forka il repository**: Crea un tuo fork del repository della specifica
2. **Apporta le tue modifiche**: Aggiorna o aggiungi la documentazione secondo necessità
3. **Invia una pull request**: Apri una PR con le tue modifiche per la revisione
4. **Partecipa alle discussioni**: Unisciti alla conversazione sulle modifiche proposte

Quando contribuisci, segui queste linee guida:

- Assicurati che le tue modifiche siano in linea con la visione e gli obiettivi generali di UTCP
- Rispetta la struttura e la formattazione della documentazione già stabilita
- Includi esempi quando aggiungi nuove funzionalità o concetti
- Aggiorna le sezioni rilevanti per mantenere la coerenza in tutta la documentazione

## Costruire la documentazione localmente

### Prerequisiti

Per costruire e visualizzare in anteprima il sito della documentazione localmente, avrai bisogno di:

- Ruby versione 2.5.0 o superiore
- RubyGems
- Bundler

### Configurazione

1. Clona il repository:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Installa le dipendenze:

   ```bash
   bundle install
   ```
### Esecuzione del sito di documentazione

Per costruire e servire il sito in locale:


```bash
bundle exec jekyll serve
```
Questo avvierà un server web locale su `http://localhost:4000` dove puoi visualizzare in anteprima la documentazione.

## Struttura della Documentazione

La documentazione UTCP è organizzata come segue:

- `index.md`: Homepage e introduzione a UTCP
- `docs/`
  - `introduction.md`: Introduzione dettagliata e concetti fondamentali
  - `for-tool-providers.md`: Guida per l'implementazione dei provider di strumenti
  - `for-tool-callers.md`: Guida per l'implementazione dei chiamanti di strumenti
  - `providers/`: Documentazione per ciascun tipo di provider
    - `http.md`: Provider HTTP
    - `websocket.md`: Provider WebSocket
    - `cli.md`: Provider CLI
    - `sse.md`: Provider Server-Sent Events
    - ecc.
  - `implementation.md`: Linee guida per l'implementazione e best practice

## Lavorare con la Specifica

### Modifica della Documentazione

La documentazione è scritta in formato Markdown con front matter Jekyll. Quando apporti modifiche:

1. Assicurati che il tuo Markdown segua lo stile stabilito
2. Visualizza le modifiche in anteprima in locale prima di inviare PR
3. Mantieni gli esempi aggiornati con l'ultima specifica
4. Aggiorna gli elementi di navigazione in `_config.yml` se aggiungi nuove pagine

### Organizzazione dei File

Quando aggiungi nuova documentazione:

- Inserisci la documentazione specifica del provider in `docs/providers/`
- Usa front matter coerente con l'ordinamento di navigazione appropriato
- Includi tag per migliorare la ricercabilità su GitHub Pages

## Controllo delle Versioni

La specifica UTCP segue la semantic versioning:

- Versioni maggiori (1.0, 2.0): Modifiche incompatibili al protocollo
- Versioni minori (1.1, 1.2): Nuove funzionalità aggiunte in modo retrocompatibile
- Versioni patch (1.0.1, 1.0.2): Correzioni di bug e chiarimenti retrocompatibili

## Licenza

Questa specifica è distribuita sotto la Mozilla Public License 2.0 (MPL-2.0).

## Risorse Aggiuntive

- [Organizzazione UTCP su GitHub](https://github.com/universal-tool-calling-protocol)
- [Sito UTCP](https://utcp.io)
- [Implementazioni di riferimento](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Discussioni della comunità](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---