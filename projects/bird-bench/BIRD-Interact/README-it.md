# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
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

## 🧸 Panoramica

BIRD-INTERACT, un benchmark interattivo text-to-SQL, **re-immagina la valutazione Text-to-SQL attraverso la lente delle interazioni dinamiche**.
L'ambiente fonde una base di conoscenza gerarchica, documentazione del database e un simulatore utente guidato da funzioni per ricreare ambienti aziendali autentici attraverso tutte le operazioni **CRUD**.
Offre due rigorose modalità di test: (1) **Interazione Conversazionale** passiva e (2) **Interazione Agentica** attiva, coprendo 600 task annotati tra cui Business Intelligence (BI), operazioni CRUD ecc., ciascuno protetto da casi di test eseguibili.
Le valutazioni tipiche attivano 1.968-5.496 turni di interazione tra modello e simulatore utente, mentre i modelli di ragionamento allo stato dell’arte risolvono attualmente solo **≈24%** e **≈18%** dei task, evidenziando la sfida del benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Due modalità di valutazione

BIRD-INTERACT supporta due modalità di valutazione come sopra menzionato:

   - **c-Interact**: Interazione Conversazionale, che è una modalità passiva e il workflow è fisso. Il codice e le informazioni dettagliate sono disponibili in `bird_interact_conv`.
   - **a-Interact**: Interazione Agentica, una modalità attiva incarnata in cui il workflow è dinamico e guidato dai modelli. Il codice e le informazioni dettagliate sono disponibili in `bird_interact_agent`.


### 🐣 Versione Lite

Stiamo rilasciando una versione lite di BIRD-INTERACT, `bird-interact-lite-exp`, che include 270 task reali di alta qualità specifici per PostgreSQL. È un buon punto di partenza per una sperimentazione rapida.

### 🦜 Versione Completa

La versione completa di BIRD-INTERACT, `bird-interact-full`, è un benchmark completo che include 600 task per PostgreSQL. Copre un'ampia gamma di operazioni SQL e query utente. La versione completa sarà disponibile a breve.

### Risultati delle prestazioni dei modelli su BIRD-INTERACT Lite

#### 1. Prestazioni **c-Interact**
| Rank | Nome Modello       | Ricompensa Normalizzata | Livello        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Chat Eccellente |
| 2    | GPT-4o             | 30.33 | 💎 Chat Buona      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Chat Buona      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standard        |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standard        |
| 6    | Qwen3              | 20.33 | ⚪ Base            |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Base            |

#### 2. Prestazioni **a-Interact**
| Rank | Nome Modello       | Parametri di Budget* | Media Turni/Task | Costo Medio (USD)/Task | Ricompensa Normalizzata | Livello                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:----------------------:|:-------------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Interazione Eccellente |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Buona Interazione      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Buona Interazione      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standard               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standard               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Base                   |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Base                   |

> \* Parametri di Budget: Budget Iniziale/Budget di Pazienza Utente, misurato tramite la nostra valuta virtuale *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Fare riferimento a [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) per maggiori dettagli.

### Interaction-Time Scaling (ITS)

L’Interaction-Time Scaling (ITS) si riferisce alla capacità di un modello di aumentare continuamente le sue prestazioni finali tramite interazioni multi-turno. Quando questa prestazione interattiva supera la prestazione ideale del modello in una singola interazione su un task completamente specificato e non ambiguo, si dice che soddisfa la **legge ITS**. All’aumentare della pazienza dell’utente e dei turni di interazione, le prestazioni migliorano costantemente, dimostrando che il modello può sostenere una comunicazione efficace in dialoghi prolungati. Attualmente, solo claude-3-7-sonnet soddisfa la legge ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Dettagli del Dataset

### Descrizione del Dataset

- **Database:** Il database PostgreSQL completo può essere scaricato da [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Consulta la sezione [Quick Eval](#quick-eval) per maggiori dettagli.
- **data:** Ogni istanza dati contiene le seguenti parti principali:
   - `selected_database`: Il nome del database.  
   - `query`: La query utente non ambigua.  
   - `amb_user_query`: La query utente con ambiguità inserite.
   - `user_query_ambiguity`: Le ambiguità inserite nella query utente.
   - `non_critical_ambiguity`: Le ambiguità non critiche come ordine, limite, ecc.
   - `knowledge_ambiguity`: Le ambiguità create da conoscenze esterne mascherate.
   - `sol_sql`: La soluzione SQL ground truth.
   - `preprocess_sql`: Query SQL da eseguire prima della soluzione o della predizione.
   - `clean_up_sql`: Query SQL da eseguire dopo i test case per annullare eventuali modifiche apportate al database.
   - `test_cases`: Un insieme di casi di test per validare la SQL corretta predetta.
   - `follow_up`: Le domande di follow up etichettate.
   - `external_knowledge`: La conoscenza esterna relativa allo specifico task.

- **valutazione:** Il codice di valutazione è disponibile nella directory [`./evaluation`](./evaluation).
- **Curato da:** BIRD Team & Google Cloud
- **Licenza:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Scheda dataset HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Usi del Dataset

Per evitare fuga di dati tramite auto-crawling, non includiamo SQL soluzione GT e casi di test insieme ai dati.
si prega di inviare una email a [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) con il tag `[bird-interact-lite GT&Test Cases]` nel titolo per il set completo, che verrà inviato automaticamente.


<!-- ### Usa il Dataset da HuggingFace

Puoi scaricare il dataset da HuggingFace usando il seguente comando:
```bash
from datasets import load_dataset
# Carica la versione flash del dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Carica la versione completa del dataset (presto disponibile)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Oppure puoi usare lo script fornito per scaricare la versione completa del dataset e suddividerlo nei diversi dialetti.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Percorso al file JSONL di input (può essere vuoto se vuoi scaricare il dataset da HuggingFace)
  --output_folder path/to/output_dir # cartella di output dei file suddivisi
``` -->

## Struttura delle Cartelle
```ultree
.
├── LICENSE
├── README.md
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
I dettagli su come eseguire **a-interact** si trovano in `./bird_interact_agent/README.md`; e **c-interact** si trovano in `./bird_interact_conv/README.md`.


## 📋 Lista delle Cose da Fare

- [x] Rilascio versione lite, bird-interact-lite (270).
- [x] Rilascio versione conversazionale, bird-interact-conv.
- [x] Rilascio versione agent, bird-interact-agent.
- [ ] Rilascio versione completa bird-interact-full (600).
- [ ] SFT / RL e Simulatore Utente

## Creato da:
BIRD Team & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---