
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="Logo HKU" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Logo Google Cloud" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Licenza">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Classifica">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## ⚠️ Annuncio  
Si prega di notare che prima del processo di valutazione, durante il caricamento dei database tramite Docker, possono occasionalmente verificarsi errori dovuti a inconsistenze dell'ambiente (questi non interromperanno il processo ma appariranno nei log di Docker). Di conseguenza, alcuni database potrebbero non essere caricati correttamente, risultando vuoti. Questo porterà a risultati di valutazione anormalmente bassi.  
👉 Pertanto, raccomandiamo vivamente di controllare i log di Docker per eventuali errori **prima di eseguire la valutazione** e di verificare che tutti i database siano stati caricati con successo.

👉 Abbiamo aggiornato le **Linee Guida per la Sottomissione**, dove sono supportati i modelli agent personalizzati. Sentitevi liberi di consultare le nostre linee guida dettagliate per la sottomissione [qui](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Novità

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: Abbiamo rilasciato **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)**, un'implementazione basata su Google ADK con architettura modulare a 3 microservizi (agente, simulatore utente e ambiente DB). Sostituisci facilmente il tuo agente, simulatore utente o ambiente DB. Supporta l'esecuzione parallela e qualsiasi provider LLM [compatibile con LiteLlm](https://docs.litellm.ai/docs/providers). Si consiglia di utilizzare questa implementazione per la vostra ricerca.

- [2026-02-08] 🔥🔥🔥 Il nostro **[articolo Bird-Interact](https://huggingface.co/papers/2510.05318)** è stato accettato a **ICLR 2026 (Oral)**! Ci vediamo a Rio 🇧🇷!  

- [2025-11-06] 🐛 **Correzione Bug** & 🐳 **Aggiornamento Docker**: Aggiornata la versione di sqlglot alla 26.16.4 per correggere il bug che impediva al parser SQL di interpretare correttamente SQL per il simulatore utente. È possibile correggere reinstallando con `pip install sqlglot==26.16.4` nell'ambiente `bird_interact_eval`. L'immagine `bird_interact_eval` è stata aggiornata, quindi potete anche scaricarla e ricreare il container `bird_interact_eval`.

- [2025-10-21] 🐳 **Aggiornamento Docker**: Abbiamo aggiunto il docker per Full DB Env. E abbiamo caricato 3 immagini docker (Base/Full DB Env e l'ambiente di valutazione per sia `a-Interact` che `c-Interact`) su Docker Hub per facilitare la configurazione dell'ambiente. Non è necessario scaricare i dump dei DB e costruire manualmente le immagini!

- [2025-10-08] 📝 Il nostro **[articolo Bird-Interact](https://huggingface.co/papers/2510.05318)** è ora pubblicamente disponibile!  
  Presenta tutti i dettagli, la metodologia e la valutazione del nostro benchmark interattivo text-to-SQL.  
  👉 Dai un'occhiata per saperne di più sulle idee dietro [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Siamo entusiasti di annunciare il rilascio del set **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
È una sfida difficile — i migliori LLM raggiungono solo un **16.33%** di successo, con appena **10.0%** sulle sezioni `c-interact` e `a-interact`.  
👉 Per ulteriori dettagli, visita il nostro [sito del progetto](https://bird-interact.github.io/).

- [2025-08-26] 📬 Questa settimana invieremo la **Ground Truth & Test cases** alla nostra mailing list.  
Se desideri l’accesso anticipato, invia un’e-mail come indicato sul sito per un **download automatico**.  

- [2025-08-26] 💾 In aggiunta, abbiamo rilasciato una versione SQLite di **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** per facilitare la ricerca locale.  
Le versioni complete **LiveSQLBench-Base** e **-Large** arriveranno presto!

- [2025-08-22] **Bug Fix**: Nel codice Bird-Interact-Agent, abbiamo corretto un bug che, durante la valutazione della fase-2 SQL, impediva l’esecuzione corretta della SQL della fase-1, riducendo il tasso di successo della Fase-2. Questo bug colpiva solo i task in cui la sql della fase1 eseguiva operazioni sul database, ad esempio CREATE table, ecc.

## 🧸 Panoramica

BIRD-INTERACT, un benchmark interattivo text-to-SQL, **re-immagina la valutazione Text-to-SQL attraverso la lente di interazioni dinamiche**.
L’ambiente unisce una knowledge base gerarchica, documentazione di database e un simulatore utente guidato da funzioni per ricreare ambienti aziendali autentici per tutte le operazioni **CRUD**.
Offre due rigorose modalità di test: (1) **Conversational Interaction** passiva e (2) **Agentic Interaction** attiva, coprendo 600 task annotati tra cui Business Intelligence (BI), operazioni CRUD, ecc., ciascuno protetto da test case eseguibili.
Le valutazioni tipiche generano tra 1.968 e 5.496 turni di interazione tra modello e simulatore utente, mentre i modelli di ragionamento all’avanguardia attualmente risolvono solo **≈24%** e **≈18%** dei task, evidenziando la sfida del benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Due Modalità di Valutazione

BIRD-INTERACT supporta due modalità di valutazione come sopra menzionato:

   - **c-Interact**: Conversational Interaction che è una modalità passiva e il workflow è fisso. Il codice e le informazioni dettagliate sono disponibili in `bird_interact_conv`.
   - **a-Interact**: Agentic Interaction che è una modalità attiva embodied dove il workflow è dinamico e guidato dai modelli. Il codice e le informazioni dettagliate sono disponibili in `bird_interact_agent`.


### 🐣 Versione Lite

Stiamo rilasciando una versione lite di BIRD-INTERACT, `bird-interact-lite-exp`, che include 270 task reali di alta qualità specifici per PostgreSQL. È un buon punto di partenza per esperimenti rapidi.

### 🦜 Versione Completa

La versione completa di BIRD-INTERACT, `bird-interact-full`, è un benchmark completo che include 600 task per PostgreSQL. Copre una vasta gamma di operazioni SQL e query utente. La versione completa arriverà presto.

### Risultati delle Prestazioni del Modello su BIRD-INTERACT-FULL

#### 1. **Prestazioni c-Interact Text-to-SQL**
| Posizione | Nome Modello         | Ricompensa Normalizzata | Costo Medio (USD)/Task | Livello               |
|:---------:|:--------------------:|:----------------------:|:---------------------:|:---------------------:|
| 1         | Gemini-2.5-Pro       | 20.92                  | $0.04                 | 🏆 Chat Eccellente    |
| 2         | O3-Mini              | 20.27                  | $0.07                 | 🏆 Chat Eccellente    |
| 3         | Claude-Sonnet-4      | 18.35                  | $0.29                 | 💎 Chat Buono         |
| 4         | Qwen-3-Coder-480B    | 17.75                  | $0.11                 | 💎 Chat Buono         |
| 5         | Deepseek-Chat-V3.1   | 15.15                  | $0.12                 | ✨ Standard           |
| 6         | Claude-Sonnet-3.7    | 13.87                  | $0.29                 | ✨ Standard           |
| 7         | GPT-5                | 12.58                  | $0.08                 | ⚪ Base               |

#### 2. **Prestazioni a-Interact Text-to-SQL**
| Posizione | Nome Modello         | Ricompensa Normalizzata | Costo Medio (USD)/Task | Livello                      |
|:---------:|:--------------------:|:----------------------:|:---------------------:|:----------------------------:|
| 1         | GPT-5                | 25.52                  | $0.24                 | 🏆 Interazione Eccellente    |
| 2         | Claude-Sonnet-4      | 23.28                  | $0.51                 | 🏆 Interazione Eccellente    |
| 3         | Claude-Sonnet-3.7    | 17.45                  | $0.60                 | 💎 Buona Interazione         |
| 4         | Gemini-2.5-Pro       | 17.33                  | $0.22                 | 💎 Buona Interazione         |
| 5         | O3-Mini              | 16.43                  | $0.06                 | ✨ Standard                  |
| 6         | Deepseek-Chat-V3.1   | 13.47                  | $0.06                 | ✨ Standard                  |
| 7         | Qwen-3-Coder-480B    | 10.58                  | $0.07                 | ⚪ Base                      |

> \* Parametri di Budget: Budget Iniziale/Budget Pazienza Utente, misurati con la nostra valuta virtuale *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consulta [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) per maggiori dettagli.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) si riferisce alla capacità di un modello di aumentare continuamente la propria prestazione finale attraverso interazioni multi-turno. Quando questa prestazione interattiva supera la prestazione ideale del modello su un task completamente specificato e non ambiguo in un singolo turno, si dice che soddisfa la **legge ITS**. All'aumentare della pazienza dell'utente e del numero di turni, la prestazione continua a migliorare, dimostrando che il modello può sostenere una comunicazione efficace in dialoghi prolungati. Attualmente, solo claude-3-7-sonnet soddisfa la legge ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Configurazione dell'Ambiente

1. Avviare i container Docker per il database bird-interact-lite, il database bird-interact-full e l'ambiente di valutazione:
  
  > Se vuoi solo valutare su `bird-interact-lite`, puoi commentare il servizio [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) in `docker-compose.yml` per velocizzare la configurazione dell'ambiente.
  
  Avvia l'ambiente eseguendo:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Attendere alcuni minuti per l'inizializzazione del database. 
   
  Puoi monitorare l'avanzamento della costruzione tramite:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Se completato, dovresti vedere i log senza errori come:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Se hai già creato dei container e desideri ricrearli, puoi eseguire il seguente comando:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Questo avvia 3 container utilizzando immagini predefinite da Docker Hub:
   - `bird_interact_postgresql`: Database PostgreSQL per bird-interact-lite
   - `bird_interact_postgresql_full`: Database PostgreSQL per bird-interact-full
   - `bird_interact_eval`: Ambiente di valutazione per entrambi `a-Interact` e `c-Interact`.

   Ora puoi avviare l'ambiente di valutazione eseguendo il seguente comando:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (Opzionale) Costruisci l'ambiente manualmente (se vuoi creare le immagini da zero): 
   - Scarica i dump del database 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Decomprimi e rinominalo come `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Decomprimi e rinominalo come `env/postgre_table_dumps_full`.
   - Costruisci l'ambiente manualmente eseguendo `docker-compose.build.yml`.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Consigliato) Verificare che i container del database siano stati creati e siano in esecuzione correttamente.

-  Stampare i log di costruzione dei container per assicurarsi che i database siano stati creati correttamente senza errori:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Se si verificano errori, `"Si sono verificati errori durante l'importazione:"` verrà stampato nei file di log.


-  Verificare che i container del database siano in buone condizioni.
   
   Utilizzare il nostro script Python fornito per verificare i metadati del database:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Risultati attesi:
   - **bird-interact-lite**: 
     - 📈 Database Totali: 18
     - 📋 Tabelle Totali: 175
     - 🔢 Colonne Totali: 2286
     - 📈 Media di Righe per Tabella: 1.038,48
     - 💾 Dimensione Totale: 207,15 MB (circa)
   - **bird-interact-full**: 
     - 📈 Database Totali: 22
     - 📋 Tabelle Totali: 244
     - 🔢 Colonne Totali: 2011
     - 📈 Media di Righe per Tabella: 1.121,19
     - 💾 Dimensione Totale: 272,00 MB (circa)


## 📦 Dettagli del Dataset

### Descrizione del Dataset

- **Database:** Il database PostgreSQL completo può essere scaricato da [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) e [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **data:** Ogni istanza di dati contiene le seguenti parti principali:
   - `selected_database`: Il nome del database.  
   - `query`: La query utente non ambigua.  
   - `amb_user_query`: La query utente con ambiguità introdotte.
   - `user_query_ambiguity`: Le ambiguità inserite nella query utente.
   - `non_critical_ambiguity`: Le ambiguità non critiche come ordine, limite, ecc.
   - `knowledge_ambiguity`: Le ambiguità create da conoscenze esterne mascherate. 
   - `sol_sql`: La soluzione SQL di riferimento.  
   - `preprocess_sql`: Query SQL da eseguire prima della soluzione o della previsione.  
   - `clean_up_sql`: Query SQL da eseguire dopo i test per annullare le modifiche apportate al database.  
   - `test_cases`: Un insieme di casi di test per validare la SQL corretta prevista.
   - `follow_up`: Le domande di follow-up etichettate.
   - `external_knowledge`: Le conoscenze esterne correlate allo specifico task.

- **evaluation:** Il codice di valutazione è disponibile nella directory [`./evaluation`](./evaluation).
- **Curato da:** BIRD Team & Google Cloud
- **Licenza:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  e [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) per PostgreSQL; e [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) per SQLite.
### Utilizzo del Dataset

Per evitare il data leakage tramite auto-crawling, non includiamo le soluzioni GT sql e i casi di test insieme ai dati.
si prega di inviare una email a [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) con il tag `[bird-interact-lite GT&Test Cases]` oppure `[bird-interact-full GT&Test Cases]` nell’oggetto per ottenere le soluzioni ground truth e i casi di test per i dataset bird-interact-lite o bird-interact-full, che saranno inviati automaticamente.


### Unire i dati pubblici con ground truth e casi di test

Utilizzare quindi il seguente script per unire i dati pubblici con ground truth e casi di test:

Prendiamo la versione completa come esempio:
(1) Esegui:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Questo creerà un nuovo file in `/path/to/bird_interact_data.jsonl` con i dati combinati.

(2) Quindi sostituisci i dati pubblici originali con i dati combinati:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

Lo stesso vale per le altre versioni: bird-interact-lite, versione mini, ecc. Basta impostare i percorsi corretti per i dati pubblici, la ground truth e i casi di test, e poi sostituire i dati pubblici con i dati combinati.




<!-- ### Usa il Dataset da HuggingFace

Puoi scaricare il dataset da HuggingFace usando il seguente comando:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Oppure puoi utilizzare lo script fornito per scaricare la versione completa del dataset e suddividerla nei diversi dialetti.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Percorso al file JSONL di input (può essere vuoto se si desidera scaricare il dataset da HuggingFace)
  --output_folder path/to/output_dir # cartella di destinazione dei file suddivisi
```

## Struttura delle cartelle
```ultree
.
├── LICENSE
├── README.md
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
I dettagli su come eseguire **a-interact** si trovano in `./bird_interact_agent/README.md`; **c-interact** si trovano in `./bird_interact_conv/README.md`; e l'**implementazione basata su ADK** si trova in `./BIRD-Interact-ADK/README.md`.

## 📋 Elenco delle cose da fare

- [x] Rilasciare la versione lite, bird-interact-lite (270).
- [x] Rilasciare la versione conversazionale, bird-interact-conv.
- [x] Rilasciare la versione agent, bird-interact-agent.
- [x] Rilasciare la versione completa bird-interact-full (600).
- [x] Rilasciare l'implementazione basata su ADK, BIRD-Interact-ADK.
- [ ] SFT / RL di un Simulatore Utente

## Ringraziamenti
Desideriamo esprimere la nostra sincera gratitudine a **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi** e al Professor **Shinji Watanabe** per le loro fruttuose discussioni e i preziosi spunti che hanno contribuito a migliorare questo progetto.

## Creato da:
Team BIRD & Google Cloud







## Citazione

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```


## Registro delle modifiche

- [2025-11-06] 🐛 **Correzione bug** & 🐳 **Aggiornamento Docker**: Aggiornata la versione di sqlglot a 26.16.4 per risolvere il bug che impediva al parser SQL di analizzare correttamente le query SQL per il simulatore utente. È possibile risolvere questo problema reinstallando sqlglot tramite `pip install sqlglot==26.16.4` nell'ambiente `bird_interact_eval`. Anche l'immagine `bird_interact_eval` è stata aggiornata, quindi è possibile scaricarla e ricreare il container `bird_interact_eval`.
- [2025-10-21] 🐳 **Aggiornamento Docker**: Aggiunto il docker per Full DB Env. Abbiamo pubblicato 3 immagini docker (Base/Full DB Env e l'ambiente di valutazione sia per `a-Interact` che per `c-Interact`) su Docker Hub per facilitare la configurazione dell'ambiente. Non è più necessario scaricare i dump del DB e costruire manualmente le immagini! Si prega di scaricare le ultime immagini da Docker Hub e ricreare i container, ad esempio usando `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22] 🐛 **Correzione bug**: Risolto il bug per cui, durante la valutazione della SQL di fase-2, la SQL memorizzata di fase-1 non poteva essere eseguita con successo, portando a un tasso di successo inferiore per la fase-2. Questo bug riguarda solo quei task in cui la SQL di fase1 esegue alcune operazioni sul database, ad esempio CREATE table, ecc.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---