
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

## ⚠️ Mededeling  
Let op dat vóór uw evaluatieproces, wanneer Docker de databases laadt, er af en toe fouten kunnen optreden door inconsistentie van de omgeving (deze beëindigen het proces niet, maar verschijnen in de Docker logs). Hierdoor kunnen sommige databases niet correct laden, wat leidt tot lege databases. Dit zal ertoe leiden dat de evaluatieresultaten abnormaal laag zijn.  
👉 Daarom raden we sterk aan om de Docker logs te controleren op eventuele fouten **voordat u de evaluatie start** en te verifiëren dat alle databases succesvol zijn geladen.

👉 We hebben de **Indieningsrichtlijnen** bijgewerkt, waarbij aangepaste agent scaffolds worden ondersteund. Bekijk gerust onze gedetailleerde indieningsrichtlijnen [hier](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Nieuws

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: We hebben **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)** uitgebracht, een Google ADK-gebaseerde implementatie met modulaire 3-microservices (agent, gebruikerssimulator en DB-omgeving) architectuur. Vervang eenvoudig uw eigen agent, gebruikerssimulator of DB-omgeving. Ondersteunt parallelle uitvoering en elke [LiteLlm-compatibele](https://docs.litellm.ai/docs/providers) LLM provider. Aanbevolen om deze implementatie te gebruiken voor uw onderzoek.

- [2026-02-08] 🔥🔥🔥 Ons **[Bird-Interact artikel](https://huggingface.co/papers/2510.05318)** is geaccepteerd bij **ICLR 2026 (Oral)**! Tot ziens in Rio 🇧🇷!  

- [2025-11-06] 🐛 **Bugfix** & 🐳 **Docker update**: Update de sqlglot versie naar 26.16.4 om de bug te verhelpen waarbij de sql parser de SQL niet correct kan parseren voor de gebruikerssimulator. U kunt dit oplossen door opnieuw te installeren met `pip install sqlglot==26.16.4` in de `bird_interact_eval` omgeving. Het `bird_interact_eval` image is ook bijgewerkt, dus u kunt deze ook downloaden en het `bird_interact_eval` container opnieuw aanmaken.

- [2025-10-21] 🐳 **Docker update**: We hebben de docker voor Full DB Env toegevoegd. En we hebben 3 docker images (Base/Full DB Env en de evaluatieomgeving voor zowel `a-Interact` als `c-Interact`) naar Docker Hub gepusht om de installatie van de omgeving te vergemakkelijken. Het is niet nodig om de DB dumps te downloaden en de images handmatig te bouwen!

- [2025-10-08] 📝 Ons **[Bird-Interact artikel](https://huggingface.co/papers/2510.05318)** is nu openbaar beschikbaar!  
  Het presenteert de volledige details, methodologie en evaluatie van onze interactieve tekst-naar-SQL benchmark.  
  👉 Bekijk het en leer meer over de ideeën achter [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 We zijn verheugd om de release aan te kondigen van de **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** set!  
Het is een lastige — de beste LLMs behalen slechts een **16.33%** succespercentage, met slechts **10.0%** op de `c-interact` en `a-interact` onderdelen.  
👉 Voor meer details, bezoek onze [projectwebsite](https://bird-interact.github.io/).

- [2025-08-26] 📬 We sturen deze week de **Ground Truth & Testcases** naar onze mailinglijst.  
Als je vroegtijdige toegang wilt, stuur dan een e-mail zoals aangegeven op de site voor een **automatische download**.  

- [2025-08-26] 💾 Daarnaast hebben we ook een SQLite-versie van **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** uitgebracht voor eenvoudiger lokaal onderzoek.  
De volledige **LiveSQLBench-Base** en **-Large** versies komen binnenkort!

- [2025-08-22] **Bugfix**: In de Bird-Interact-Agent code hebben we een bug opgelost waarbij bij het evalueren van fase-2 SQL de opgeslagen fase-1 SQL niet succesvol kon worden uitgevoerd, wat leidde tot een lagere slagingskans van Fase-2. Deze bug treft alleen taken waarbij de fase1 SQL bepaalde bewerkingen op de database uitvoert, zoals CREATE table, enz.

## 🧸 Overzicht

BIRD-INTERACT, een interactieve text-to-SQL benchmark, **herdefinieert Text-to-SQL evaluatie door de lens van dynamische interacties**.
De omgeving combineert een hiërarchische kennisbank, databasedocumentatie en een functiegestuurde gebruikerssimulator om authentieke bedrijfsomgevingen te recreëren over volledige **CRUD**-operaties.
Het biedt twee strenge testmodi: (1) passieve **Conversational Interaction** en (2) actieve **Agentic Interaction**, verspreid over 600 geannoteerde taken waaronder Business Intelligence (BI), CRUD-bewerkingen en meer, elk voorzien van uitvoerbare testcases.
Typische evaluaties activeren 1.968-5.496 interactierondes tussen het model en de gebruikerssimulator, terwijl state-of-the-art redeneermodellen momenteel slechts **≈24%** en **≈18%** van de taken oplossen, wat de uitdaging van de benchmark benadrukt.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Twee Evaluatiemodi

BIRD-INTERACT ondersteunt de hierboven genoemde twee evaluatiemodi:

   - **c-Interact**: Conversationele interactie, een passieve modus waarbij de workflow vastligt. De code en gedetailleerde informatie zijn te vinden in `bird_interact_conv`.
   - **a-Interact**: Agentische interactie, een belichaamde actieve modus waarbij de workflow dynamisch is en wordt geleid door modellen. De code en gedetailleerde informatie zijn te vinden in `bird_interact_agent`.


### 🐣 Lite Versie

We brengen een lite-versie van BIRD-INTERACT uit, `bird-interact-lite-exp`, die 270 hoogwaardige real-world taken bevat specifiek voor PostgreSQL. Dit is een goed startpunt voor snelle experimenten.

### 🦜 Volledige Versie

De volledige versie van BIRD-INTERACT, `bird-interact-full`, is een uitgebreide benchmark die 600 taken voor PostgreSQL omvat. Het dekt een breed scala aan SQL-bewerkingen en gebruikersvragen. De volledige versie komt binnenkort.

### Modelprestaties op BIRD-INTERACT-FULL

#### 1. **c-Interact Text-to-SQL** Prestaties
| Rang | Modelnaam          | Genormaliseerde Beloning | Gemiddelde Kosten (USD)/Taak | Niveau              |
|:----:|:-------------------|:------------------------:|:----------------------------:|:-------------------:|
| 1    | Gemini-2.5-Pro     | 20.92                    | $0.04                        | 🏆 Uitstekende Chat |
| 2    | O3-Mini            | 20.27                    | $0.07                        | 🏆 Uitstekende Chat |
| 3    | Claude-Sonnet-4    | 18.35                    | $0.29                        | 💎 Goede Chat       |
| 4    | Qwen-3-Coder-480B  | 17.75                    | $0.11                        | 💎 Goede Chat       |
| 5    | Deepseek-Chat-V3.1 | 15.15                    | $0.12                        | ✨ Standaard        |
| 6    | Claude-Sonnet-3.7  | 13.87                    | $0.29                        | ✨ Standaard        |
| 7    | GPT-5              | 12.58                    | $0.08                        | ⚪ Basis            |

#### 2. **a-Interact Text-to-SQL** Prestaties
| Rang | Modelnaam          | Genormaliseerde Beloning | Gemiddelde Kosten (USD)/Taak | Niveau                  |
|:----:|:-------------------|:------------------------:|:----------------------------:|:----------------------:|
| 1    | GPT-5              | 25.52                    | $0.24                        | 🏆 Uitstekende Interactie |
| 2    | Claude-Sonnet-4    | 23.28                    | $0.51                        | 🏆 Uitstekende Interactie |
| 3    | Claude-Sonnet-3.7  | 17.45                    | $0.60                        | 💎 Goede Interactie      |
| 4    | Gemini-2.5-Pro     | 17.33                    | $0.22                        | 💎 Goede Interactie      |
| 5    | O3-Mini            | 16.43                    | $0.06                        | ✨ Standaard             |
| 6    | Deepseek-Chat-V3.1 | 13.47                    | $0.06                        | ✨ Standaard             |
| 7    | Qwen-3-Coder-480B  | 10.58                    | $0.07                        | ⚪ Basis                 |

> \* Budget Parameters: Startbudget/Gebruikersgeduld Budget, gemeten met onze virtuele valuta *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Raadpleeg [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) voor meer details.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) verwijst naar het vermogen van een model om zijn eindprestaties continu te verbeteren via multi-turn interacties. Wanneer deze interactieve prestatie de geïdealiseerde single-turn prestatie van het model op een volledig gespecificeerde, ondubbelzinnige taak overtreft, zeggen we dat het voldoet aan de **ITS-wet**. Naarmate het gebruikersgeduld toeneemt en het aantal interactierondes stijgt, blijft de prestatie verbeteren, wat aantoont dat het model effectieve communicatie kan volhouden gedurende langdurige dialogen. Momenteel voldoet alleen claude-3-7-sonnet aan de ITS-wet.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Omgevingsinstallatie

1. Start Docker containers voor bird-interact-lite database, bird-interact-full database en evaluatieomgeving:
  
  > Als je alleen wilt evalueren op `bird-interact-lite`, kun je de [`postgresql_full` service](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) in `docker-compose.yml` uitcommentariëren om de installatie van de omgeving te versnellen.
  
  Start de omgeving door uit te voeren:
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


## 📦 Gegevensset Details

### Beschrijving van de dataset

- **Database:** De volledige PostgreSQL-database kan worden gedownload van [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) en [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **data:** Elk gegevensvoorbeeld bevat de volgende hoofdonderdelen:
   - `selected_database`: De naam van de database.  
   - `query`: De eenduidige gebruikersvraag.  
   - `amb_user_query`: De gebruikersvraag met geïnjecteerde ambiguïteiten.
   - `user_query_ambiguity`: De geïnjecteerde ambiguïteiten in de gebruikersvraag.
   - `non_critical_ambiguity`: De niet-kritische ambiguïteiten zoals volgorde, limiet, etc.
   - `knowledge_ambiguity`: De ambiguïteiten gecreëerd door gemaskeerde externe kennis. 
   - `sol_sql`: De grondwaarheid SQL-oplossing.  
   - `preprocess_sql`: SQL-queries die moeten worden uitgevoerd vóór de oplossing of voorspelling.  
   - `clean_up_sql`: SQL-queries die na de testgevallen worden uitgevoerd om eventuele wijzigingen aan de database terug te draaien.  
   - `test_cases`: Een set testgevallen om de voorspelde gecorrigeerde SQL te valideren.
   - `follow_up`: De gelabelde vervolgvragen.
   - `external_knowledge`: De externe kennis gerelateerd aan de specifieke taak.

- **evaluatie:** De evaluatiecode is beschikbaar in de [`./evaluation`](./evaluation) directory.
- **Samengesteld door:** BIRD Team & Google Cloud
- **Licentie:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  en [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) voor PostgreSQL; en [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) voor SQLite.
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
De details over het uitvoeren van **a-interact** zijn te vinden in `./bird_interact_agent/README.md`; **c-interact** is te vinden in `./bird_interact_conv/README.md`; en de **ADK-gebaseerde implementatie** is te vinden in `./BIRD-Interact-ADK/README.md`.

## 📋 Takenlijsten

- [x] Lite-versie uitbrengen, bird-interact-lite (270).
- [x] Conversationele versie uitbrengen, bird-interact-conv.
- [x] Agent-versie uitbrengen, bird-interact-agent.
- [x] Volledige versie uitbrengen, bird-interact-full (600).
- [x] ADK-gebaseerde implementatie uitbrengen, BIRD-Interact-ADK.
- [ ] SFT / RL en Gebruikerssimulator

## Dankwoord
Wij willen onze oprechte dank uitspreken aan **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, en Professor **Shinji Watanabe** voor hun vruchtbare discussies en waardevolle inzichten die hebben bijgedragen aan de verbetering van dit project.

## Gemaakt door:
BIRD Team & Google Cloud







## Citeren

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
## Wijzigingslog

- [2025-11-06] 🐛 **Bugfix** & 🐳 **Docker update**: Update de sqlglot-versie naar 26.16.4 om de bug te verhelpen waarbij de sql parser de SQL niet correct kan parseren voor de gebruikerssimulator. Je kunt dit oplossen door het opnieuw te installeren met `pip install sqlglot==26.16.4` in de `bird_interact_eval`-omgeving. Het `bird_interact_eval`-image is ook bijgewerkt, dus je kunt deze ook pullen en de `bird_interact_eval`-container opnieuw aanmaken.
- [2025-10-21] 🐳 **Docker update**: Voeg de docker toe voor Full DB Env. En we hebben 3 docker-images gepusht (Base/Full DB Env en de evaluatieomgeving voor zowel `a-Interact` als `c-Interact`) naar Docker Hub om de installatie van de omgeving te vergemakkelijken. Je hoeft de DB dumps niet te downloaden en de images niet handmatig te bouwen! Trek de nieuwste images van Docker Hub en maak de containers opnieuw aan, bijvoorbeeld met `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Bugfix**: Los de bug op waarbij tijdens de evaluatie van fase-2 SQL, de opgeslagen fase-1 SQL niet succesvol kan worden uitgevoerd, wat leidt tot een lagere succesratio van Fase-2. Deze bug treft alleen taken waarbij de fase1 sql bepaalde bewerkingen op de database uitvoert, zoals CREATE table, enz.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---