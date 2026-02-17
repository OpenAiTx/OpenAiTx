
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">Engels</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">Japans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">Koreaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">Hindi</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">Thais</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Frans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Duits</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Spaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Italiaans</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Russisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Portugees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Pools</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">Arabisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">Perzisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Turks</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Vietnamees</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Indonesisch</a></p>
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
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Licentie">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Ranglijst">
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

## ⚠️ Mededeling  
Let op dat voordat je begint met de evaluatie, er bij het laden van de databases door Docker soms fouten kunnen optreden door inconsistenties in de omgeving (deze beëindigen het proces niet maar verschijnen wel in de Docker logs). Hierdoor kan het zijn dat sommige databases niet goed geladen worden, wat leidt tot lege databases. Dit veroorzaakt abnormaal lage evaluatieresultaten.  
👉 Daarom raden wij sterk aan om **voordat je de evaluatie uitvoert** de Docker logs te controleren op fouten en te verifiëren dat alle databases succesvol geladen zijn.

👉 We hebben de **Indieningsrichtlijnen** geüpdatet, waarin aangepaste agent-scaffolds worden ondersteund. Bekijk gerust onze gedetailleerde indieningsrichtlijnen [hier](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Nieuws

- [2026-02-08] 🔥🔥🔥 Ons **[Bird-Interact artikel](https://huggingface.co/papers/2510.05318)** is geaccepteerd voor **ICLR 2026 (Oral)**! Tot ziens in Rio 🇧🇷!  

- [2025-11-06] 🐛 **Bugfix** & 🐳 **Docker update**: Update sqlglot naar versie 26.16.4 om de bug te verhelpen waardoor de SQL-parser de SQL voor de gebruiker simulator niet correct kan parseren. Je kunt dit oplossen door `pip install sqlglot==26.16.4` uit te voeren in de `bird_interact_eval` omgeving. De `bird_interact_eval` image is ook bijgewerkt, dus je kunt deze ook downloaden en de `bird_interact_eval` container opnieuw aanmaken.

- [2025-10-21] 🐳 **Docker update**: We hebben de docker voor Full DB Env toegevoegd. En we hebben 3 docker images (Base/Full DB Env en de evaluatieomgeving voor zowel `a-Interact` als `c-Interact`) naar Docker Hub gepusht voor eenvoudigere installatie. Je hoeft de DB dumps niet meer handmatig te downloaden en de images te bouwen!

- [2025-10-08] 📝 Ons **[Bird-Interact artikel](https://huggingface.co/papers/2510.05318)** is nu openbaar beschikbaar!  
  Het bevat alle details, methodologie en evaluatie van onze interactieve text-to-SQL benchmark.  
  👉 Bekijk het en leer meer over de ideeën achter [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 We zijn verheugd om de release van de **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** set aan te kondigen!  
Het is een pittige — de beste LLM’s behalen slechts een **16.33%** slagingspercentage, met slechts **10.0%** op de `c-interact` en `a-interact` gedeeltes.  
👉 Voor meer details, bezoek onze [projectwebsite](https://bird-interact.github.io/).

- [2025-08-26] 📬 We sturen deze week de **Ground Truth & Testcases** naar onze mailinglijst.  
Als je eerder toegang wilt, stuur dan een e-mail zoals aangegeven op de site voor een **automatische download**.  

- [2025-08-26] 💾 Daarnaast hebben we ook een SQLite-versie van **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** uitgebracht voor eenvoudiger lokaal onderzoek.  
De volledige **LiveSQLBench-Base** en **-Large** versies komen binnenkort!

- [2025-08-22] **Bugfix**: In de Bird-Interact-Agent-code hebben we een bug opgelost waarbij de opgeslagen fase-1 SQL niet succesvol kon worden uitgevoerd tijdens het evalueren van fase-2 SQL, wat leidde tot een lagere slagingskans in Fase-2. Deze bug heeft alleen invloed op taken waarbij fase1 SQL bepaalde bewerkingen op de database uitvoert, zoals CREATE table, enz.

## 🧸 Overzicht

BIRD-INTERACT, een interactieve text-to-SQL benchmark, **herdefinieert Text-to-SQL-evaluatie via het perspectief van dynamische interacties**.
De omgeving combineert een hiërarchische kennisbasis, databasedocumentatie en een functiesturende gebruikerssimulator om authentieke bedrijfsomgevingen na te bootsen voor volledige **CRUD**-operaties.
Het biedt twee strenge testmodi: (1) passieve **Conversational Interaction** en (2) actieve **Agentic Interaction**, verdeeld over 600 geannoteerde taken, waaronder Business Intelligence (BI), CRUD-operaties, enz., elk beschermd door uitvoerbare testcases.
Typische evaluaties activeren 1.968-5.496 interactiebeurten tussen model en gebruikerssimulator, terwijl state-of-the-art redeneermodellen momenteel slechts **≈24%** en **≈18%** van de taken oplossen, wat de uitdaging van de benchmark onderstreept.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Twee evaluatiemodi

BIRD-INTERACT ondersteunt twee evaluatiemodi zoals hierboven vermeld:

   - **c-Interact**: Conversationele interactie, een passieve modus waarbij de workflow vastligt. De code en gedetailleerde informatie zijn te vinden in `bird_interact_conv`.
   - **a-Interact**: Agentische interactie, een actieve belichaamde modus waarbij de workflow dynamisch is en door modellen wordt geleid. De code en gedetailleerde informatie zijn te vinden in `bird_interact_agent`.


### 🐣 Lite Versie

We brengen een lite-versie van BIRD-INTERACT uit, `bird-interact-lite-exp`, die 270 hoogwaardige real-world taken bevat, specifiek voor PostgreSQL. Dit is een goed startpunt voor snelle experimenten. 

### 🦜 Volledige Versie

De volledige versie van BIRD-INTERACT, `bird-interact-full`, is een uitgebreide benchmark met 600 taken voor PostgreSQL. Het dekt een breed scala aan SQL-operaties en gebruikersvragen. De volledige versie komt binnenkort.

### Modelprestatie-resultaten op BIRD-INTERACT-FULL

#### 1. **c-Interact Text-to-SQL** Prestatie
| Rang | Modelnaam         | Genormaliseerde Beloning | Gem. Kosten (USD)/Taak | Niveau              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 Uitstekende Chat |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 Uitstekende Chat |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 Goede Chat       |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 Goede Chat       |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ Standaard         |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ Standaard         |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ Basis             |

#### 2. **a-Interact Text-to-SQL** Prestaties
| Rang | Modelnaam          | Genormaliseerde Beloning | Gem. Kosten (USD)/Taak | Niveau                  |
|:----:|:-------------------|:-----------------------:|:----------------------:|:-----------------------:|
| 1    | GPT-5              | 25.52                   | $0.24                  | 🏆 Uitstekende Interactie |
| 2    | Claude-Sonnet-4    | 23.28                   | $0.51                  | 🏆 Uitstekende Interactie |
| 3    | Claude-Sonnet-3.7  | 17.45                   | $0.60                  | 💎 Goede Interactie      |
| 4    | Gemini-2.5-Pro     | 17.33                   | $0.22                  | 💎 Goede Interactie      |
| 5    | O3-Mini            | 16.43                   | $0.06                  | ✨ Standaard             |
| 6    | Deepseek-Chat-V3.1 | 13.47                   | $0.06                  | ✨ Standaard             |
| 7    | Qwen-3-Coder-480B  | 10.58                   | $0.07                  | ⚪ Basis                 |

> \* Budgetparameters: Startbudget/Gebruikersgeduld Budget, gemeten met onze virtuele munteenheid *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Zie [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) voor meer details.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) verwijst naar het vermogen van een model om zijn uiteindelijke prestaties continu te verhogen via meer-draais interacties. Wanneer deze interactieve prestatie de geïdealiseerde single-turn prestatie van het model op een volledig gespecificeerde, ondubbelzinnige taak overtreft, zeggen we dat het voldoet aan de **ITS-wet**. Naarmate het gebruikersgeduld toeneemt en het aantal interactierondes oploopt, blijven de prestaties verbeteren, wat aantoont dat het model effectieve communicatie over langere dialogen kan volhouden. Momenteel vinden we alleen dat claude-3-7-sonnet voldoet aan de ITS-wet.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Omgevingsinstallatie

1. Start Docker containers voor bird-interact-lite database, bird-interact-full database en evaluatieomgeving:
  
  > Als je alleen wilt evalueren op `bird-interact-lite`, kun je de [`postgresql_full` service](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) in `docker-compose.yml` uitcommentariëren om de installatie van de omgeving te versnellen.
  
  Start de omgeving door het volgende uit te voeren:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Wacht enkele minuten tot de database-initialisatie is voltooid. 
   
  U kunt de voortgang van het bouwen volgen via:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Als het voltooid is, zou je de logs zonder fouten moeten zien zoals:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Als u eerder containers heeft gemaakt en deze opnieuw wilt aanmaken, kunt u het volgende commando uitvoeren:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Dit start 3 containers met vooraf gebouwde images van Docker Hub:
   - `bird_interact_postgresql`: PostgreSQL-database voor bird-interact-lite
   - `bird_interact_postgresql_full`: PostgreSQL-database voor bird-interact-full
   - `bird_interact_eval`: Evaluatie-omgeving voor zowel `a-Interact` als `c-Interact`.

   Nu kun je de evaluatie-omgeving starten door het volgende commando uit te voeren:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (Optioneel) Bouw de omgeving handmatig (als je de images vanaf nul wilt bouwen): 
   - Download de database-dumps 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Pak uit en hernoem als `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Pak uit en hernoem als `env/postgre_table_dumps_full`.
   - Bouw de omgeving handmatig door `docker-compose.build.yml` uit te voeren.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Aanbevolen) Controleer of de databasecontainers succesvol zijn gebouwd en draaien.

-  Print de container build logs om te verzekeren dat de databases zonder fouten succesvol zijn gebouwd:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Als er fouten optreden, wordt `"Er zijn fouten opgetreden tijdens het importeren:"` in de logbestanden afgedrukt.


-  Controleer of de databasecontainers in goede staat zijn.
   
   Gebruik ons meegeleverde Python-script om de databasemetadata te verifiëren:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Verwachte resultaten:
   - **bird-interact-lite**: 
     - 📈 Totaal aantal databases: 18
     - 📋 Totaal aantal tabellen: 175
     - 🔢 Totaal aantal kolommen: 2286
     - 📈 Gemiddeld aantal rijen per tabel: 1.038,48
     - 💾 Totale grootte: 207,15 MB (ongeveer)
   - **bird-interact-full**: 
     - 📈 Totaal aantal databases: 22
     - 📋 Totaal aantal tabellen: 244
     - 🔢 Totaal aantal kolommen: 2011
     - 📈 Gemiddeld aantal rijen per tabel: 1.121,19
     - 💾 Totale grootte: 272,00 MB (ongeveer)


## 📦 Dataset Details

### Beschrijving van de dataset

- **Database:** De volledige PostgreSQL-database kan worden gedownload van [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) en [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **data:** Elke gegevensinstance bevat de volgende hoofdonderdelen:
   - `selected_database`: De naam van de database.  
   - `query`: De eenduidige gebruikersquery.  
   - `amb_user_query`: De gebruikersquery met geïnjecteerde ambiguïteiten.
   - `user_query_ambiguity`: De ambiguïteiten die in de gebruikersquery zijn geïnjecteerd.
   - `non_critical_ambiguity`: De niet-kritische ambiguïteiten zoals volgorde, limiet, enz.
   - `knowledge_ambiguity`: De ambiguïteiten die ontstaan door gemaskeerde externe kennis. 
   - `sol_sql`: De SQL-oplossing als grondwaarheid.  
   - `preprocess_sql`: SQL-queries die uitgevoerd moeten worden vóór de oplossing of voorspelling.  
   - `clean_up_sql`: SQL-queries die na de testgevallen worden uitgevoerd om wijzigingen in de database terug te draaien.  
   - `test_cases`: Een reeks testgevallen om de voorspelde gecorrigeerde SQL te valideren.
   - `follow_up`: De gelabelde vervolgvragen.
   - `external_knowledge`: De externe kennis die bij de specifieke taak hoort.

- **evaluatie:** De evaluatiecode is beschikbaar in de [`./evaluation`](./evaluation) directory.
- **Samengesteld door:** BIRD Team & Google Cloud
- **Licentie:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  en [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### Gebruik van de dataset

Om datalekken door automatisch crawlen te voorkomen, nemen we geen GT-oplossing-sql’s en testgevallen samen met de data op.
stuur een e-mail naar [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) met het label `[bird-interact-lite GT&Test Cases]` of `[bird-interact-full GT&Test Cases]` in de titel voor de ground truth en testgevallen voor de bird-interact-lite of bird-interact-full dataset, welke automatisch worden verzonden.


### Combineer de openbare data met de ground truth en testgevallen

Gebruik vervolgens het volgende script om de openbare data te combineren met de ground truth en testgevallen:

Neem de volledige versie als voorbeeld:
(1) Voer uit:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Dit zal een nieuw bestand aanmaken op `/path/to/bird_interact_data.jsonl` met de gecombineerde gegevens.

(2) Vervang vervolgens de oorspronkelijke openbare gegevens door de gecombineerde gegevens:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

Hetzelfde geldt voor de andere versies: bird-interact-lite, mini versie, enz. Stel gewoon de juiste paden in voor de publieke data en de ground truth en testcases, en vervang vervolgens de publieke data door de gecombineerde data.




<!-- ### Gebruik de dataset van HuggingFace

Je kunt de dataset van HuggingFace downloaden met het volgende commando:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
Of je kunt het meegeleverde script gebruiken om de volledige versie van de dataset te downloaden en deze op te splitsen in verschillende dialecten.

```bash
cd baseline/data
python pull_data.py \
  --schema_path pad/naar/full_schema.jsonl \
  --input_path pad/naar/input.jsonl \ # Pad naar het invoer-JSONL-bestand (mag leeg zijn als je de dataset van HuggingFace wilt downloaden)
  --output_folder pad/naar/output_dir # uitvoermap van de gesplitste bestanden
```

## Mapstructuur
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
De details over het uitvoeren van **a-interact** zijn te vinden in `./bird_interact_agent/README.md`; en **c-interact** zijn te vinden in `./bird_interact_conv/README.md`.

## 📋 Takenlijsten

- [x] Lite-versie uitbrengen, bird-interact-lite (270).
- [x] Conversatieversie uitbrengen, bird-interact-conv.
- [x] Agentversie uitbrengen, bird-interact-agent.
- [x] Volledige versie uitbrengen, bird-interact-full (600).
- [ ] SFT / RL een Gebruikerssimulator

## Dankwoord
Wij willen onze oprechte dank uitspreken aan **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, en Professor **Shinji Watanabe** voor hun vruchtbare discussies en waardevolle inzichten die hebben bijgedragen aan de verbetering van dit project.

## Gemaakt door:
BIRD Team & Google Cloud








## Wijzigingslogboek

- [2025-11-06] 🐛 **Bugfix** & 🐳 **Docker-update**: Update de sqlglot-versie naar 26.16.4 om de bug op te lossen waarbij de SQL-parser de SQL niet correct kan parsen voor de gebruikerssimulator. Je kunt dit oplossen door het opnieuw te installeren met `pip install sqlglot==26.16.4` in de `bird_interact_eval` omgeving. Het `bird_interact_eval` image is ook bijgewerkt, dus je kunt deze ook ophalen en de `bird_interact_eval` container opnieuw aanmaken.
- [2025-10-21] 🐳 **Docker-update**: Voeg de docker toe voor de Full DB Env. En we hebben 3 docker images (Base/Full DB Env en de evaluatieomgeving voor zowel `a-Interact` als `c-Interact`) naar Docker Hub gepusht om het opzetten van de omgeving te vergemakkelijken. Het is niet nodig om de DB dumps te downloaden en de images handmatig te bouwen! Trek de nieuwste images van Docker Hub en maak de containers opnieuw aan, bijvoorbeeld met `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Bugfix**: Los de bug op waarbij tijdens de evaluatie van fase-2 SQL, de opgeslagen fase-1 SQL niet succesvol kan worden uitgevoerd, wat leidt tot een lager slagingspercentage van Fase-2. Deze bug heeft alleen invloed op die taken waarbij fase1 sql bewerkingen uitvoert op de database, bijv. CREATE table, enz.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---