
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
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

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Lizenz">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Bestenliste">
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

## ⚠️ Ankündigung  
Bitte beachten Sie, dass beim Laden der Datenbanken mit Docker gelegentlich Fehler aufgrund von Umgebungsinkonsistenzen auftreten können (diese führen nicht zum Abbruch des Prozesses, sondern erscheinen in den Docker-Logs). Dadurch kann es passieren, dass manche Datenbanken nicht korrekt geladen werden und leer bleiben. Dies führt zu ungewöhnlich niedrigen Bewertungsergebnissen.  
👉 Daher empfehlen wir dringend, die Docker-Logs **vor der Ausführung der Bewertung** auf Fehler zu überprüfen und sicherzustellen, dass alle Datenbanken erfolgreich geladen wurden.

## 📰 Neuigkeiten

- [2025-08-26] 🚀 Wir freuen uns, die Veröffentlichung des **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** Sets bekanntzugeben!  
Es ist anspruchsvoll — die besten LLMs erreichen nur eine **16,33%** Erfolgsquote, mit lediglich **10,0%** bei den `c-interact` und `a-interact` Teilen.  
👉 Für weitere Details besuchen Sie bitte unsere [Projektwebsite](https://bird-interact.github.io/).

- [2025-08-26] 📬 Wir werden diese Woche die **Ground Truth & Testfälle** an unsere Mailingliste versenden.  
Wer frühzeitig Zugriff möchte, kann eine E-Mail gemäß den Anweisungen auf der Website senden, um einen **automatischen Download** zu erhalten.  

- [2025-08-26] 💾 Außerdem haben wir eine SQLite-Version von **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** veröffentlicht, die die lokale Forschung erleichtert.  
Die vollständigen Versionen **LiveSQLBench-Base** und **-Large** folgen in Kürze!

- [2025-08-22] **Bug-Fix**: Im Bird-Interact-Agent Code haben wir einen Fehler behoben, bei dem beim Auswerten von Phase-2 SQL das gespeicherte Phase-1 SQL nicht erfolgreich ausgeführt werden konnte, was zu einer niedrigeren Erfolgsrate von Phase-2 führte. Dieser Fehler betrifft nur Aufgaben, bei denen das Phase-1 SQL Operationen auf der Datenbank ausführt, z.B. CREATE table usw.

## 🧸 Übersicht

BIRD-INTERACT, ein interaktiver Text-zu-SQL Benchmark, **überdenkt die Text-zu-SQL-Evaluierung durch die Linse dynamischer Interaktionen**.
Die Umgebung kombiniert eine hierarchische Wissensbasis, Datenbankdokumentation und einen funktionsgetriebenen Benutzersimulator, um authentische Unternehmensumgebungen für vollständige **CRUD**-Operationen nachzubilden.
Es bietet zwei strenge Testmodi: (1) passiver **Konversationeller Interaktionsmodus** und (2) aktiver **Agentischer Interaktionsmodus**, mit insgesamt 600 annotierten Aufgaben, darunter Business Intelligence (BI), CRUD-Operationen usw., wobei jede Aufgabe durch ausführbare Testfälle abgesichert ist.
Typische Bewertungen lösen 1.968–5.496 Interaktionsturns zwischen Modell und Benutzersimulator aus, während modernste Reasoning-Modelle aktuell nur **≈24 %** bzw. **≈18 %** der Aufgaben bewältigen, was die Herausforderung des Benchmarks unterstreicht.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Zwei Bewertungsmodi

BIRD-INTERACT unterstützt wie oben erwähnt zwei Bewertungsmodi:

   - **c-Interact**: Konversationelle Interaktion, ein passiver Modus mit festem Workflow. Der Code und weitere Informationen sind in `bird_interact_conv` zu finden.
   - **a-Interact**: Agentische Interaktion, ein aktiver Modus, bei dem der Workflow dynamisch ist und vom Modell gesteuert wird. Der Code und weitere Informationen sind in `bird_interact_agent` zu finden.


### 🐣 Lite-Version

Wir veröffentlichen eine Lite-Version von BIRD-INTERACT, `bird-interact-lite-exp`, die 270 hochwertige, praxisnahe Aufgaben speziell für PostgreSQL enthält. Dies ist ein guter Startpunkt für schnelle Experimente.

### 🦜 Vollversion

Die Vollversion von BIRD-INTERACT, `bird-interact-full`, ist ein umfassender Benchmark mit 600 Aufgaben für PostgreSQL. Sie deckt ein breites Spektrum an SQL-Operationen und Benutzeranfragen ab. Die Vollversion erscheint in Kürze.

### Modell-Leistungsergebnisse auf BIRD-INTERACT Lite

#### 1. **c-Interact** Leistung
| Rang | Modellname         | Normalisierte Belohnung | Level        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33,04 | 🏆 Ausgezeichneter Chat |
| 2    | GPT-4o             | 30,33 | 💎 Guter Chat      |
| 3    | Gemini-2.0-flash   | 27,41 | 💎 Guter Chat      |
| 4    | Claude-3.7-sonnet  | 26,60 | ✨ Standard       |
| 5    | DeepSeek-R1        | 21,74 | ✨ Standard       |
| 6    | Qwen3              | 20,33 | ⚪ Basic          |
| 7    | DeepSeek-V3        | 15,85 | ⚪ Basic          |

#### 2. **a-Interact** Leistung
| Rang | Modellname         | Budget-Parameter* | Durchschnittl. Schritte/Aufgabe | Durchschnittl. Kosten (USD)/Aufgabe | Normalisierte Belohnung | Level            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15,4 | $0,6668 | 29,19 | 🏆 Exzellente Interaktion |
| 2    | o3-mini            | 6/6 | 7,8  | $0,0754 | 21,07 | 💎 Gute Interaktion      |
| 3    | DeepSeek-V3        | 6/6 | 15,6 | $0,0629 | 19,19 | 💎 Gute Interaktion      |
| 4    | Qwen3              | 6/6 | 12,5 | $0,0278 | 18,74 | ✨ Standard              |
| 5    | GPT-4o             | 6/6 | 15,3 | $0,4594 | 18,37 | ✨ Standard              |
| 6    | Gemini-2.0-flash   | 6/6 | 13,2 | $0,0337 | 17,26 | ⚪ Basis                 |
| 7    | DeepSeek-R1        | 6/6 | 12,0 | $0,0931 | 17,07 | ⚪ Basis                 |

> \* Budget-Parameter: Startbudget/Benutzer-Geduldsbudget, gemessen in unserer virtuellen Währung *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Weitere Details finden Sie unter [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) bezeichnet die Fähigkeit eines Modells, seine Endleistung durch mehrfache Interaktionen kontinuierlich zu steigern. Übertrifft diese interaktive Leistung die idealisierte Einzelschritt-Leistung des Modells bei einer vollständig spezifizierten, eindeutigen Aufgabe, sagen wir, dass das Modell das **ITS-Gesetz** erfüllt. Mit zunehmender Geduld des Nutzers und einer steigenden Anzahl von Interaktionen verbessert sich die Leistung kontinuierlich, was zeigt, dass das Modell über längere Dialoge hinweg effektive Kommunikation aufrechterhalten kann. Derzeit erfüllt nur claude-3-7-sonnet das ITS-Gesetz.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Datensatzdetails

### Datensatzbeschreibung

- **Datenbank:** Die vollständige PostgreSQL-Datenbank kann von [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) heruntergeladen werden. Weitere Informationen finden Sie im Abschnitt [Quick Eval](#quick-eval).
- **Daten:** Jede Dateninstanz enthält die folgenden Hauptbestandteile:
   - `selected_database`: Name der Datenbank.  
   - `query`: Die eindeutige Benutzeranfrage.  
   - `amb_user_query`: Die Benutzeranfrage mit eingebrachten Mehrdeutigkeiten.
   - `user_query_ambiguity`: Die in die Benutzeranfrage eingebrachten Mehrdeutigkeiten.
   - `non_critical_ambiguity`: Die nicht-kritischen Mehrdeutigkeiten wie Reihenfolge, Limit, usw.
   - `knowledge_ambiguity`: Die durch ausgeblendetes externes Wissen entstandenen Mehrdeutigkeiten. 
   - `sol_sql`: Die Ground Truth SQL-Lösung.  
   - `preprocess_sql`: SQL-Abfragen, die vor der Ausführung der Lösung oder Vorhersage ausgeführt werden.  
   - `clean_up_sql`: SQL-Abfragen, die nach den Testfällen ausgeführt werden, um Änderungen an der Datenbank rückgängig zu machen.  
   - `test_cases`: Eine Reihe von Testfällen zur Validierung der vorhergesagten korrigierten SQL.
   - `follow_up`: Die gekennzeichneten Folgefragen.
   - `external_knowledge`: Das externe Wissen zum spezifischen Task.

- **Bewertung:** Der Bewertungscode ist im Verzeichnis [`./evaluation`](./evaluation) verfügbar.
- **Kuratiert von:** BIRD Team & Google Cloud
- **Lizenz:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset-Karte:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Datensatzverwendung

Um Datenlecks durch automatisches Crawlen zu vermeiden, enthalten wir keine GT-Lösungs-SQLs und Testfälle zusammen mit den Daten.
Bitte senden Sie eine E-Mail an [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) mit dem Tag `[bird-interact-lite GT&Test Cases]` im Titel, um das vollständige Set zu erhalten, das automatisch zugesendet wird.


<!-- ### Nutzung des Datensatzes von HuggingFace

Sie können den Datensatz von HuggingFace mit dem folgenden Befehl herunterladen:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
Oder Sie können das bereitgestellte Skript verwenden, um die vollständige Version des Datensatzes herunterzuladen und ihn in verschiedene Dialekte aufzuteilen.

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Pfad zur Eingabe-JSONL-Datei (kann leer sein, wenn Sie das Dataset von HuggingFace herunterladen möchten)
  --output_folder path/to/output_dir # Ausgabeverzeichnis für die gesplitteten Dateien
```

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
Die Details zum Ausführen von **a-interact** finden Sie in `./bird_interact_agent/README.md`; und **c-interact** finden Sie in `./bird_interact_conv/README.md`.

## 📋 Aufgabenliste

- [x] Veröffentlichung der Lite-Version, bird-interact-lite (270).
- [x] Veröffentlichung der Konversationsversion, bird-interact-conv.
- [x] Veröffentlichung der Agentenversion, bird-interact-agent.
- [x] Veröffentlichung der vollständigen Version bird-interact-full (600).
- [ ] SFT / RL eines Benutzersimulators

## Erstellt von:
BIRD Team & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---