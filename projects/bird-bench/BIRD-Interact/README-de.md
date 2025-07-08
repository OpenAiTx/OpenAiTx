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

## 🧸 Übersicht

BIRD-INTERACT, ein interaktiver Text-zu-SQL-Benchmark, **denkt die Text-zu-SQL-Evaluierung durch die Linse dynamischer Interaktionen neu**.
Die Umgebung verbindet eine hierarchische Wissensbasis, Datenbankdokumentation und einen funktionsgesteuerten Benutzersimulator, um authentische Unternehmensumgebungen über vollständige **CRUD**-Operationen nachzubilden.
Sie bietet zwei anspruchsvolle Testmodi: (1) passiver **Konversationeller Interaktion** und (2) aktiver **Agentischer Interaktion**, mit insgesamt 600 annotierten Aufgaben einschließlich Business Intelligence (BI), CRUD-Operationen usw., jede durch ausführbare Testfälle abgesichert.
Typische Auswertungen führen zu 1.968–5.496 Interaktionsturns zwischen Modell und Benutzersimulator, während modernste Reasoning-Modelle derzeit nur **≈24%** bzw. **≈18%** der Aufgaben lösen, was die Herausforderung des Benchmarks unterstreicht.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Zwei Evaluierungsmodi

BIRD-INTERACT unterstützt wie oben erwähnt zwei Evaluierungsmodi:

   - **c-Interact**: Konversationelle Interaktion, ein passiver Modus mit festem Workflow. Der Code und detaillierte Informationen sind unter `bird_interact_conv` zu finden.
   - **a-Interact**: Agentische Interaktion, ein verkörperter aktiver Modus mit dynamischem, modellgesteuertem Workflow. Der Code und detaillierte Informationen sind unter `bird_interact_agent` zu finden.


### 🐣 Lite-Version

Wir veröffentlichen eine Lite-Version von BIRD-INTERACT, `bird-interact-lite-exp`, die 270 hochwertige, praxisnahe Aufgaben speziell für PostgreSQL enthält. Dies ist ein guter Einstiegspunkt für schnelle Experimente.

### 🦜 Vollversion

Die Vollversion von BIRD-INTERACT, `bird-interact-full`, ist ein umfassender Benchmark mit 600 Aufgaben für PostgreSQL. Sie deckt ein breites Spektrum an SQL-Operationen und Benutzeranfragen ab. Die Vollversion erscheint in Kürze.

### Modellleistungs-Ergebnisse auf BIRD-INTERACT Lite

#### 1. **c-Interact** Leistung
| Rang | Modellname         | Normalisierte Belohnung | Stufe        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Exzellenter Chat |
| 2    | GPT-4o             | 30.33 | 💎 Guter Chat      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Guter Chat      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standard        |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standard        |
| 6    | Qwen3              | 20.33 | ⚪ Basis           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Basis           |

#### 2. **a-Interact** Leistung
| Rang | Modellname         | Budgetparameter* | Ø Turns/Aufgabe | Ø Kosten (USD)/Aufgabe | Normalisierte Belohnung | Stufe                 |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Exzellente Interaktion |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Gute Interaktion       |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Gute Interaktion       |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standard               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standard               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Basis                  |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Basis                  |

> \* Budgetparameter: Startbudget/User-Geduldsbudget, gemessen in unserer virtuellen Währung *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Siehe [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) für mehr Details.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) bezeichnet die Fähigkeit eines Modells, seine Endleistung durch mehrstufige Interaktionen kontinuierlich zu steigern. Wenn diese interaktive Leistung die idealisierte Ein-Turn-Leistung des Modells bei einer vollständig spezifizierten, eindeutigen Aufgabe übersteigt, sprechen wir davon, dass das Modell das **ITS-Gesetz** erfüllt. Mit wachsender Benutzer-Geduld und zunehmender Anzahl von Interaktionsturns verbessert sich die Leistung stetig, was zeigt, dass das Modell effektive Kommunikation über längere Dialoge aufrechterhalten kann. Aktuell finden wir nur, dass claude-3-7-sonnet das ITS-Gesetz erfüllt.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Datensatzdetails

### Datensatzbeschreibung

- **Datenbank:** Die vollständige PostgreSQL-Datenbank kann von [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) heruntergeladen werden. Siehe den Abschnitt [Quick Eval](#quick-eval) für weitere Details.
- **data:** Jede Dateninstanz enthält folgende Hauptteile:
   - `selected_database`: Der Name der Datenbank.  
   - `query`: Die eindeutige Benutzeranfrage.  
   - `amb_user_query`: Die Benutzeranfrage mit eingebauten Mehrdeutigkeiten.
   - `user_query_ambiguity`: Die in die Benutzeranfrage eingebauten Mehrdeutigkeiten.
   - `non_critical_ambiguity`: Die nicht-kritischen Mehrdeutigkeiten wie Reihenfolge, Limit, etc.
   - `knowledge_ambiguity`: Die durch maskierte externe Kenntnisse entstandenen Mehrdeutigkeiten. 
   - `sol_sql`: Die Ground-Truth-SQL-Lösung.  
   - `preprocess_sql`: SQL-Abfragen, die vor Ausführung der Lösung oder Vorhersage ausgeführt werden sollen.  
   - `clean_up_sql`: SQL-Abfragen, die nach den Testfällen ausgeführt werden, um alle an der Datenbank vorgenommenen Änderungen rückgängig zu machen.  
   - `test_cases`: Eine Reihe von Testfällen zur Validierung der vorhergesagten, korrigierten SQL.
   - `follow_up`: Die gekennzeichneten Folgefragen.
   - `external_knowledge`: Das externe Wissen, das sich auf die jeweilige Aufgabe bezieht.

- **Evaluation:** Der Evaluierungscode ist im Verzeichnis [`./evaluation`](./evaluation) verfügbar.
- **Kuratiert von:** BIRD Team & Google Cloud
- **Lizenz:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Datensatzverwendung

Um Datenlecks durch automatisches Crawlen zu vermeiden, enthalten wir keine GT-SQL-Lösungen und Testfälle zusammen mit den Daten.
Bitte senden Sie eine E-Mail an [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) mit dem Betreff `[bird-interact-lite GT&Test Cases]`, um das vollständige Set zu erhalten, welches dann automatisch zugesendet wird.


<!-- ### Verwendung des Datensatzes von HuggingFace

Sie können den Datensatz von HuggingFace mit dem folgenden Befehl herunterladen:
```bash
from datasets import load_dataset
# Die Flash-Version des Datensatzes laden
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Die vollständige Version des Datensatzes laden (in Kürze verfügbar)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Oder Sie können das bereitgestellte Skript verwenden, um die vollständige Version des Datensatzes herunterzuladen und in verschiedene Dialekte aufzuteilen.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Pfad zur Eingabe-JSONL-Datei (darf leer sein, wenn Sie den Datensatz direkt von HuggingFace herunterladen möchten)
  --output_folder path/to/output_dir # Ausgabeverzeichnis der aufgeteilten Dateien
``` -->

## Ordnerstruktur
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
Die Details zum Ausführen von **a-interact** finden Sie in `./bird_interact_agent/README.md`; und **c-interact** in `./bird_interact_conv/README.md`.


## 📋 Aufgabenliste

- [x] Veröffentlichung der Lite-Version, bird-interact-lite (270).
- [x] Veröffentlichung der Konversationsversion, bird-interact-conv.
- [x] Veröffentlichung der Agentenversion, bird-interact-agent.
- [ ] Veröffentlichung der vollständigen bird-interact-full (600).
- [ ] SFT / RL und User Simulator

## Erstellt von:
BIRD Team & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---