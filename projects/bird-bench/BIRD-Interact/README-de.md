
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

## ⚠️ Ankündigung  
Bitte beachten Sie, dass beim Laden der Datenbanken durch Docker vor Ihrem Evaluierungsprozess gelegentlich Fehler aufgrund von Inkonsistenzen in der Umgebung auftreten können (diese führen nicht zum Abbruch des Prozesses, erscheinen jedoch in den Docker-Logs). Dadurch können einige Datenbanken nicht korrekt geladen werden und bleiben leer. Dies führt zu ungewöhnlich niedrigen Evaluationsergebnissen.  
👉 Daher empfehlen wir dringend, **vor der Ausführung der Evaluation** die Docker-Logs auf Fehler zu überprüfen und sicherzustellen, dass alle Datenbanken erfolgreich geladen wurden.

👉 Wir haben die **Einreichungsrichtlinien** aktualisiert, bei denen benutzerdefinierte Agent-Scaffolds unterstützt werden. Schauen Sie sich gerne unsere detaillierten Einreichungsrichtlinien [hier](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true) an.

## 📰 Neuigkeiten

- [2026-02-08] 🔥🔥🔥 Unser **[Bird-Interact Paper](https://huggingface.co/papers/2510.05318)** wurde auf der **ICLR 2026 (Oral)** angenommen! Wir sehen uns in Rio 🇧🇷!  

- [2025-11-06] 🐛 **Bugfix** & 🐳 **Docker-Update**: Aktualisieren Sie die sqlglot-Version auf 26.16.4, um den Fehler zu beheben, bei dem der SQL-Parser SQL für den Benutzersimulator nicht korrekt parsen kann. Sie können dies beheben, indem Sie es mit `pip install sqlglot==26.16.4` in der `bird_interact_eval`-Umgebung neu installieren. Das `bird_interact_eval`-Image wurde ebenfalls aktualisiert, sodass Sie es auch neu ziehen und den `bird_interact_eval`-Container neu erstellen können.

- [2025-10-21] 🐳 **Docker-Update**: Wir haben das Docker-Image für die Full DB Env hinzugefügt. Und wir haben 3 Docker-Images (Basis/Full DB Env und die Evaluierungsumgebung für sowohl `a-Interact` als auch `c-Interact`) auf Docker Hub bereitgestellt, um die Einrichtung der Umgebung zu erleichtern. Ein manuelles Herunterladen der DB-Dumps und Erstellen der Images ist nicht mehr nötig!

- [2025-10-08] 📝 Unser **[Bird-Interact Paper](https://huggingface.co/papers/2510.05318)** ist jetzt öffentlich verfügbar!  
  Es enthält alle Details, die Methodik und die Evaluierung unseres interaktiven Text-zu-SQL-Benchmarks.  
  👉 Schauen Sie es sich an und erfahren Sie mehr über die Ideen hinter [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Wir freuen uns, die Veröffentlichung des **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**-Sets bekannt zu geben!  
Es ist eine harte Herausforderung — die besten LLMs erreichen nur eine **16.33%** Erfolgsquote, mit lediglich **10.0%** auf den `c-interact`- und `a-interact`-Teilen.  
👉 Für weitere Details besuchen Sie bitte unsere [Projektwebseite](https://bird-interact.github.io/).

- [2025-08-26] 📬 Wir werden diese Woche die **Ground Truth & Testfälle** an unsere Mailingliste versenden.  
Wenn Sie frühzeitigen Zugang möchten, senden Sie bitte eine E-Mail gemäß den Anweisungen auf der Website für einen **automatischen Download**.  

- [2025-08-26] 💾 Außerdem haben wir eine SQLite-Version von **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** veröffentlicht, um lokale Forschung zu erleichtern.  
Die vollständigen **LiveSQLBench-Base** und **-Large** Versionen erscheinen bald!

- [2025-08-22] **Bugfix**: Im Bird-Interact-Agent-Code haben wir einen Fehler behoben, bei dem beim Auswerten von Phase-2-SQL das gespeicherte Phase-1-SQL nicht erfolgreich ausgeführt werden konnte, was zu einer geringeren Erfolgsquote von Phase-2 führte. Dieser Fehler betrifft nur Aufgaben, bei denen das Phase-1-SQL einige Operationen auf der Datenbank durchführt, z. B. CREATE table usw.

## 🧸 Übersicht

BIRD-INTERACT, ein interaktives Text-to-SQL-Benchmark, **stellt die Text-to-SQL-Evaluierung durch dynamische Interaktionen neu dar**.
Die Umgebung kombiniert eine hierarchische Wissensbasis, Datenbankdokumentation und einen funktionsgetriebenen Benutzersimulator, um authentische Unternehmensumgebungen für vollständige **CRUD**-Operationen nachzubilden.
Es bietet zwei rigorose Testmodi: (1) passiv **Konversationelle Interaktion** und (2) aktiv **Agentische Interaktion**, mit insgesamt 600 annotierten Aufgaben inkl. Business Intelligence (BI), CRUD-Operationen usw., jeweils durch ausführbare Testfälle abgesichert.
Typische Bewertungen lösen 1.968-5.496 Interaktionsturns zwischen Modell und Benutzersimulator aus, während modernste Reasoning-Modelle aktuell nur **≈24 %** und **≈18 %** der Aufgaben lösen, was die Herausforderung des Benchmarks unterstreicht.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Zwei Evaluationsmodi

BIRD-INTERACT unterstützt zwei Evaluationsmodi wie oben beschrieben:

   - **c-Interact**: Konversationelle Interaktion, ein passiver Modus mit festem Ablauf. Code und Details finden Sie in `bird_interact_conv`.
   - **a-Interact**: Agentische Interaktion, ein aktiver Modus, bei dem der Ablauf dynamisch und modellgesteuert ist. Code und Details finden Sie in `bird_interact_agent`.


### 🐣 Lite-Version

Wir veröffentlichen eine Lite-Version von BIRD-INTERACT, `bird-interact-lite-exp`, mit 270 hochwertigen Aufgaben aus der Praxis speziell für PostgreSQL. Dies ist ein guter Einstieg für schnelle Experimente. 

### 🦜 Vollversion

Die Vollversion von BIRD-INTERACT, `bird-interact-full`, ist ein umfassendes Benchmark mit 600 Aufgaben für PostgreSQL. Sie deckt eine breite Palette von SQL-Operationen und Benutzeranfragen ab. Die Vollversion erscheint demnächst.

### Modellergebnisse auf BIRD-INTERACT-FULL

#### 1. **c-Interact Text-to-SQL** Leistung
| Rang | Modellname         | Normalisierte Belohnung | Durchschnittliche Kosten (USD)/Aufgabe | Level              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 Exzellenter Chat |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 Exzellenter Chat |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 Guter Chat       |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 Guter Chat       |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ Standard         |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ Standard         |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ Basic            |

#### 2. **a-Interact Text-to-SQL** Leistung
| Rang | Modellname         | Normalisierter Reward | Durchschnittliche Kosten (USD)/Aufgabe | Stufe                     |
|:----:|:-------------------|:---------------------:|:--------------------------------------:|:-------------------------:|
| 1    | GPT-5              | 25.52                 | $0.24                                  | 🏆 Exzellente Interaktion |
| 2    | Claude-Sonnet-4    | 23.28                 | $0.51                                  | 🏆 Exzellente Interaktion |
| 3    | Claude-Sonnet-3.7  | 17.45                 | $0.60                                  | 💎 Gute Interaktion       |
| 4    | Gemini-2.5-Pro     | 17.33                 | $0.22                                  | 💎 Gute Interaktion       |
| 5    | O3-Mini            | 16.43                 | $0.06                                  | ✨ Standard               |
| 6    | Deepseek-Chat-V3.1 | 13.47                 | $0.06                                  | ✨ Standard               |
| 7    | Qwen-3-Coder-480B  | 10.58                 | $0.07                                  | ⚪ Basic                  |

> \* Budget-Parameter: Startbudget/Benutzer-Geduldsbudget, gemessen in unserer virtuellen Währung *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Weitere Details finden Sie in [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) bezeichnet die Fähigkeit eines Modells, seine Endleistung durch mehrstufige Interaktionen kontinuierlich zu steigern. Wenn diese interaktive Leistung die idealisierte Einzelschritt-Leistung des Modells bei einer vollständig spezifizierten, eindeutigen Aufgabe übertrifft, sagen wir, es erfüllt das **ITS-Gesetz**. Mit wachsender Benutzer-Geduld und zunehmenden Interaktionsrunden verbessert sich die Leistung stetig, was zeigt, dass das Modell effektive Kommunikation über längere Dialoge aufrechterhalten kann. Momentan erfüllt nur claude-3-7-sonnet das ITS-Gesetz.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Umgebungseinrichtung

1. Starten Sie Docker-Container für die bird-interact-lite-Datenbank, die bird-interact-full-Datenbank und die Evaluierungsumgebung:
  
  > Wenn Sie nur auf `bird-interact-lite` evaluieren möchten, können Sie den [`postgresql_full` Service](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) in `docker-compose.yml` auskommentieren, um die Einrichtung zu beschleunigen.
  
  Starten Sie die Umgebung mit:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Warten Sie mehrere Minuten auf die Initialisierung der Datenbank.
   
  Sie können den Fortschritt des Aufbaus verfolgen durch:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Wenn abgeschlossen, sollten Sie die Protokolle ohne Fehler wie folgt sehen:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Wenn Sie zuvor Container erstellt haben und diese neu erstellen möchten, können Sie den folgenden Befehl ausführen:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Dies startet 3 Container mit vorgefertigten Images von Docker Hub:
   - `bird_interact_postgresql`: PostgreSQL-Datenbank für bird-interact-lite
   - `bird_interact_postgresql_full`: PostgreSQL-Datenbank für bird-interact-full
   - `bird_interact_eval`: Evaluierungsumgebung für sowohl `a-Interact` als auch `c-Interact`.

   Jetzt können Sie die Evaluierungsumgebung durch Ausführen des folgenden Befehls starten:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (Optional) Baue die Umgebung manuell (wenn du die Images von Grund auf neu erstellen möchtest): 
   - Lade die Datenbank-Dumps herunter 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Entpacke und benenne sie um zu `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Entpacke und benenne sie um zu `env/postgre_table_dumps_full`.
   - Baue die Umgebung manuell, indem du `docker-compose.build.yml` ausführst.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Empfohlen) Überprüfen Sie, ob die Datenbank-Container erfolgreich erstellt und ausgeführt werden.

- Drucken Sie die Container-Build-Logs aus, um sicherzustellen, dass die Datenbanken fehlerfrei erstellt wurden:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Wenn Fehler auftreten, wird `"Fehler traten während des Imports auf:"` in den Logdateien ausgegeben.


-  Überprüfen Sie, ob die Datenbank-Container in gutem Zustand sind.
   
   Verwenden Sie unser bereitgestelltes Python-Skript, um die Datenbank-Metadaten zu überprüfen:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Erwartete Ergebnisse:
   - **bird-interact-lite**: 
     - 📈 Gesamte Datenbanken: 18
     - 📋 Gesamte Tabellen: 175
     - 🔢 Gesamte Spalten: 2286
     - 📈 Durchschnittliche Zeilen pro Tabelle: 1.038,48
     - 💾 Gesamtgröße: 207,15 MB (ungefähr)
   - **bird-interact-full**: 
     - 📈 Gesamte Datenbanken: 22
     - 📋 Gesamte Tabellen: 244
     - 🔢 Gesamte Spalten: 2011
     - 📈 Durchschnittliche Zeilen pro Tabelle: 1.121,19
     - 💾 Gesamtgröße: 272,00 MB (ungefähr)


## 📦 Datensatzdetails

### Datensatzbeschreibung

- **Datenbank:** Die vollständige PostgreSQL-Datenbank kann von [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) und [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) heruntergeladen werden.
- **data:** Jede Dateninstanz enthält die folgenden Hauptteile:
   - `selected_database`: Der Name der Datenbank.  
   - `query`: Die eindeutige Benutzeranfrage.  
   - `amb_user_query`: Die Benutzeranfrage mit eingefügten Mehrdeutigkeiten.
   - `user_query_ambiguity`: Die in die Benutzeranfrage eingefügten Mehrdeutigkeiten.
   - `non_critical_ambiguity`: Die nicht-kritischen Mehrdeutigkeiten wie Reihenfolge, Limit, etc.
   - `knowledge_ambiguity`: Die durch maskiertes externes Wissen erzeugten Mehrdeutigkeiten. 
   - `sol_sql`: Die korrekte SQL-Lösung.  
   - `preprocess_sql`: SQL-Abfragen, die vor der Ausführung der Lösung oder Vorhersage ausgeführt werden.  
   - `clean_up_sql`: SQL-Abfragen, die nach den Testfällen ausgeführt werden, um alle Änderungen an der Datenbank rückgängig zu machen.  
   - `test_cases`: Eine Reihe von Testfällen zur Validierung der vorhergesagten korrigierten SQL.
   - `follow_up`: Die gekennzeichneten Folgefragen.
   - `external_knowledge`: Das externe Wissen in Bezug auf die jeweilige Aufgabe.

- **evaluation:** Der Evaluierungscode ist im Verzeichnis [`./evaluation`](./evaluation) verfügbar.
- **Kuratiert von:** BIRD Team & Google Cloud
- **Lizenz:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  und [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### Datensatzverwendung

Um Datenlecks durch automatisches Crawlen zu vermeiden, enthalten wir keine GT-Lösung-SQLs und Testfälle zusammen mit den Daten.
Bitte senden Sie eine E-Mail an [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) mit dem Tag `[bird-interact-lite GT&Test Cases]` oder `[bird-interact-full GT&Test Cases]` im Betreff, um die Ground Truth und Testfälle für den bird-interact-lite- oder bird-interact-full-Datensatz zu erhalten, die dann automatisch zugesendet werden.


### Kombinieren Sie die öffentlichen Daten mit der Ground Truth und den Testfällen

Verwenden Sie dann das folgende Skript, um die öffentlichen Daten mit der Ground Truth und den Testfällen zu kombinieren:

Nehmen Sie die Vollversion als Beispiel:
(1) Führen Sie aus:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Dadurch wird eine neue Datei unter `/path/to/bird_interact_data.jsonl` mit den zusammengeführten Daten erstellt.

(2) Ersetzen Sie dann die ursprünglichen öffentlichen Daten durch die zusammengeführten Daten:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

Dasselbe gilt für die anderen Versionen: bird-interact-lite, Mini-Version usw. Setzen Sie einfach die richtigen Pfade für die öffentlichen Daten sowie den Ground-Truth und die Testfälle und ersetzen Sie dann die öffentlichen Daten durch die kombinierten Daten.




<!-- ### Datensatz von HuggingFace verwenden

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

## 📋 Aufgabenlisten

- [x] Lite-Version veröffentlichen, bird-interact-lite (270).
- [x] Konversationsversion veröffentlichen, bird-interact-conv.
- [x] Agentenversion veröffentlichen, bird-interact-agent.
- [x] Volle Version veröffentlichen, bird-interact-full (600).
- [ ] SFT / RL eines Benutzersimulators

## Danksagung
Wir möchten unseren aufrichtigen Dank an **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi** und Professor **Shinji Watanabe** für ihre fruchtbaren Diskussionen und wertvollen Erkenntnisse aussprechen, die zur Verbesserung dieses Projekts beigetragen haben.

## Erstellt von:
BIRD Team & Google Cloud








## Änderungsprotokoll

- [2025-11-06] 🐛 **Fehlerbehebung** & 🐳 **Docker-Update**: Aktualisierung der sqlglot-Version auf 26.16.4, um den Fehler zu beheben, dass der SQL-Parser das SQL für den Benutzersimulator nicht korrekt parsen kann. Sie können dies beheben, indem Sie es erneut mit `pip install sqlglot==26.16.4` in der `bird_interact_eval`-Umgebung installieren. Das `bird_interact_eval`-Image wurde ebenfalls aktualisiert, sodass Sie es auch ziehen und den `bird_interact_eval`-Container neu erstellen können.
- [2025-10-21] 🐳 **Docker-Update**: Docker für Full DB Env hinzugefügt. Und wir haben 3 Docker-Images (Base/Full DB Env und die Evaluierungsumgebung für sowohl `a-Interact` als auch `c-Interact`) auf Docker Hub bereitgestellt, um die Einrichtung der Umgebung zu erleichtern. Es ist nicht mehr nötig, die DB-Dumps herunterzuladen und die Images manuell zu bauen! Bitte ziehen Sie die neuesten Images von Docker Hub und erstellen Sie die Container neu, z. B. mit `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Fehlerbehebung**: Behebt den Fehler, dass bei der Auswertung von Phase-2-SQL das gespeicherte Phase-1-SQL nicht erfolgreich ausgeführt werden konnte, was zu einer geringeren Erfolgsrate von Phase-2 führte. Dieser Fehler betrifft nur Aufgaben, bei denen Phase1-SQL einige Operationen an der Datenbank durchführt, z. B. CREATE table, usw.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---