
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

## Novità
- [2025-08-22] **Correzione Bug**: Nel codice Bird-Interact-Agent, abbiamo corretto un bug che, durante la valutazione della fase-2 SQL, impediva l'esecuzione corretta del SQL della fase-1 memorizzato, causando un tasso di successo inferiore nella Fase-2. Questo bug colpisce solo quei task in cui il sql della fase1 esegue alcune operazioni sul database, ad esempio CREATE table, ecc.

## 🧸 Panoramica

BIRD-INTERACT, un benchmark interattivo text-to-SQL, **re-immagina la valutazione Text-to-SQL attraverso la lente delle interazioni dinamiche**.
L'ambiente combina una base di conoscenza gerarchica, documentazione del database e un simulatore utente guidato da funzioni per ricreare ambienti aziendali autentici su tutte le operazioni **CRUD**.
Offre due modalità di test rigorose: (1) **Interazione Conversazionale** passiva e (2) **Interazione Agentica** attiva, coprendo 600 task annotati tra cui Business Intelligence (BI), operazioni CRUD, ecc., ciascuno protetto da casi di test eseguibili.
Le valutazioni tipiche generano tra 1.968 e 5.496 turni di interazione tra modello e simulatore utente, mentre i modelli di ragionamento all'avanguardia attualmente risolvono solo **≈24%** e **≈18%** dei task, evidenziando la sfida del benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Due Modalità di Valutazione

BIRD-INTERACT supporta due modalità di valutazione come sopra descritto:

   - **c-Interact**: Interazione Conversazionale che è una modalità passiva e il flusso di lavoro è fisso. Il codice e le informazioni dettagliate sono disponibili in `bird_interact_conv`.
   - **a-Interact**: Interazione Agentica che è una modalità attiva incarnata dove il flusso di lavoro è dinamico e guidato dai modelli. Il codice e le informazioni dettagliate sono disponibili in `bird_interact_agent`.


### 🐣 Versione Lite

Stiamo rilasciando una versione lite di BIRD-INTERACT, `bird-interact-lite-exp`, che include 270 task reali di alta qualità specificamente per PostgreSQL. Questo è un buon punto di partenza per esperimenti rapidi.

### 🦜 Versione Completa

La versione completa di BIRD-INTERACT, `bird-interact-full`, è un benchmark completo che include 600 task per PostgreSQL. Copre una vasta gamma di operazioni SQL e query utente. La versione completa arriverà presto.

### Risultati delle Prestazioni dei Modelli su BIRD-INTERACT Lite

#### 1. **c-Interact** Prestazioni
| Posizione | Nome Modello       | Ricompensa Normalizzata | Livello         |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Chat Eccellente |
| 2    | GPT-4o             | 30.33 | 💎 Chat Buona      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Chat Buona      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standard        |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standard        |
| 6    | Qwen3              | 20.33 | ⚪ Base            |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Base            |

#### 2. **a-Interact** Prestazioni
| Posizione | Nome Modello       | Parametri Budget* | Media Passi/Task | Media Costo (USD)/Task | Ricompensa Normalizzata | Livello                 |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Interazione Eccellente |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Interazione Buona      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Interazione Buona      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standard               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standard               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Base                   |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Base                   |

> \* Parametri Budget: Budget Iniziale/Budget Pazienza Utente, misurati tramite la nostra valuta virtuale *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consulta [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) per maggiori dettagli.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) si riferisce alla capacità di un modello di aumentare continuamente la sua prestazione finale tramite interazioni multi-turno. Quando questa prestazione interattiva supera la prestazione idealizzata del modello in un task completamente specificato e non ambiguo, si dice che soddisfa la **legge ITS**. Con l'aumentare della pazienza dell'utente e il crescere dei turni di interazione, le prestazioni continuano a migliorare, dimostrando che il modello può mantenere una comunicazione efficace in dialoghi estesi. Attualmente, solo claude-3-7-sonnet risulta soddisfare la legge ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Dettagli del Dataset

### Descrizione del Dataset

- **Database:** Il database completo PostgreSQL può essere scaricato da [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Consulta la sezione [Quick Eval](#quick-eval) per maggiori dettagli.
- **data:** Ogni istanza di dati contiene le seguenti parti principali:
   - `selected_database`: Il nome del database.  
   - `query`: La query utente non ambigua.  
   - `amb_user_query`: La query utente con ambiguità introdotte.
   - `user_query_ambiguity`: Le ambiguità inserite nella query utente.
   - `non_critical_ambiguity`: Le ambiguità non critiche come ordine, limite, ecc.
   - `knowledge_ambiguity`: Le ambiguità create da conoscenze esterne mascherate. 
   - `sol_sql`: La soluzione SQL di riferimento.  
   - `preprocess_sql`: Query SQL da eseguire prima della soluzione o della previsione.  
   - `clean_up_sql`: Query SQL da eseguire dopo i test per ripristinare eventuali modifiche al database.  
   - `test_cases`: Un set di casi di test per validare la SQL corretta prevista.
   - `follow_up`: Le domande di follow up etichettate.
   - `external_knowledge`: La conoscenza esterna relativa al compito specifico.

- **evaluation:** Il codice di valutazione è disponibile nella directory [`./evaluation`](./evaluation).
- **Curato da:** Team BIRD & Google Cloud
- **Licenza:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Scheda HuggingFace Dataset:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Utilizzi del Dataset

Per evitare la fuoriuscita di dati tramite auto-crawling, non includiamo le soluzioni sql GT e i casi di test insieme ai dati.
per favore invia una email a [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) con il tag `[bird-interact-lite GT&Test Cases]` nel titolo per ricevere il set completo, che verrà inviato automaticamente.


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
I dettagli su come eseguire **a-interact** si trovano in `./bird_interact_agent/README.md`; quelli su **c-interact** si trovano in `./bird_interact_conv/README.md`.


## 📋 Elenco delle cose da fare

- [x] Rilasciare la versione lite, bird-interact-lite (270).
- [x] Rilasciare la versione conversazionale, bird-interact-conv.
- [x] Rilasciare la versione agent, bird-interact-agent.
- [x] Rilasciare la versione completa bird-interact-full (600).
- [ ] SFT / RL di un Simulatore Utente

## Creato da:
BIRD Team & Google Cloud


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---