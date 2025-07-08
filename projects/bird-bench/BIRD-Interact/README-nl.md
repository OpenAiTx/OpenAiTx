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

## 🧸 Overzicht

BIRD-INTERACT, een interactieve text-to-SQL benchmark, **herdefinieert Text-to-SQL evaluatie door de lens van dynamische interacties**.
De omgeving combineert een hiërarchische kennisbank, database-documentatie en een functiegestuurde gebruiker-simulator om authentieke zakelijke omgevingen na te bootsen met volledige **CRUD**-operaties.
Het biedt twee strenge testmodi: (1) passieve **Conversational Interaction** en (2) actieve **Agentic Interaction**, verspreid over 600 geannoteerde taken, waaronder Business Intelligence (BI), CRUD-operaties, enz., elk beschermd door uitvoerbare testcases.
Typische evaluaties veroorzaken 1.968-5.496 interactierondes tussen model en gebruiker-simulator, terwijl state-of-the-art redeneermodellen momenteel slechts **≈24%** en **≈18%** van de taken oplossen, wat de uitdaging van de benchmark benadrukt.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Twee evaluatiemodi

BIRD-INTERACT ondersteunt twee evaluatiemodi zoals hierboven genoemd:

   - **c-Interact**: Conversationele Interactie, een passieve modus waarbij de workflow vastligt. De code en gedetailleerde informatie zijn te vinden in `bird_interact_conv`.
   - **a-Interact**: Agentische Interactie, een belichaamde actieve modus waarbij de workflow dynamisch is en wordt geleid door modellen. De code en gedetailleerde informatie zijn te vinden in `bird_interact_agent`.


### 🐣 Lite Versie

We brengen een lite-versie van BIRD-INTERACT uit, `bird-interact-lite-exp`, met 270 hoogwaardige real-world taken specifiek voor PostgreSQL. Dit is een goed startpunt voor snelle experimentatie.

### 🦜 Volledige Versie

De volledige versie van BIRD-INTERACT, `bird-interact-full`, is een uitgebreide benchmark die 600 taken voor PostgreSQL bevat. Het dekt een breed scala aan SQL-operaties en gebruikersvragen. De volledige versie verschijnt binnenkort.

### Modelprestaties op BIRD-INTERACT Lite

#### 1. **c-Interact** Prestaties
| Rang | Modelnaam          | Genormaliseerde Beloning | Niveau        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Uitstekende Chat |
| 2    | GPT-4o             | 30.33 | 💎 Goede Chat      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Goede Chat      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standaard       |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standaard       |
| 6    | Qwen3              | 20.33 | ⚪ Basis           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Basis           |

#### 2. **a-Interact** Prestaties
| Rang | Modelnaam          | Budgetparameters* | Gem. Beurten/Taak | Gem. Kosten (USD)/Taak | Genormaliseerde Beloning | Niveau            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Uitstekende Interactie |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Goede Interactie       |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Goede Interactie       |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standaard              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standaard              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Basis                  |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Basis                  |

> \* Budgetparameters: Startbudget/Gebruiker Geduld Budget, gemeten met onze virtuele valuta *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Zie [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) voor meer details.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) verwijst naar het vermogen van een model om zijn uiteindelijke prestatie voortdurend te verhogen via multi-turn interacties. Wanneer deze interactieve prestatie de geïdealiseerde single-turn prestatie van het model op een volledig gespecificeerde, ondubbelzinnige taak overtreft, zeggen we dat het voldoet aan de **ITS-wet**. Naarmate het gebruikersgeduld toeneemt en het aantal interacties groeit, blijft de prestatie stijgen, wat aantoont dat het model effectieve communicatie over langere dialogen kan volhouden. Momenteel vinden we alleen dat claude-3-7-sonnet voldoet aan de ITS-wet.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Datasetdetails

### Datasetbeschrijving

- **Database:** De volledige PostgreSQL-database kan worden gedownload van [de Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Zie de sectie [Quick Eval](#quick-eval) voor meer details.
- **data:** Elke data-instantie bevat de volgende hoofdonderdelen:
   - `selected_database`: De naam van de database.  
   - `query`: De ondubbelzinnige gebruikersvraag.  
   - `amb_user_query`: De gebruikersvraag met toegevoegde ambiguïteiten.
   - `user_query_ambiguity`: De ambiguïteiten die in de gebruikersvraag zijn geïnjecteerd.
   - `non_critical_ambiguity`: De niet-kritieke ambiguïteiten zoals volgorde, limiet, enz.
   - `knowledge_ambiguity`: De ambiguïteiten gecreëerd door gemaskeerde externe kennis.
   - `sol_sql`: De ground truth SQL-oplossing.
   - `preprocess_sql`: SQL-query's die uitgevoerd moeten worden vóór de oplossing of voorspelling.
   - `clean_up_sql`: SQL-query's die uitgevoerd moeten worden na de testgevallen om alle wijzigingen in de database terug te draaien.
   - `test_cases`: Een set testgevallen om de voorspelde gecorrigeerde SQL te valideren.
   - `follow_up`: De gelabelde vervolgvragen.
   - `external_knowledge`: De externe kennis gerelateerd aan de specifieke taak.

- **evaluatie:** De evaluatiecode is beschikbaar in de [`./evaluation`](./evaluation) map.
- **Samengesteld door:** BIRD Team & Google Cloud
- **Licentie:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Datasetkaart:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Gebruik van de dataset

Om datalekken door automatisch crawlen te voorkomen, bevatten we geen GT-oplossing SQL's en testgevallen samen met de data.
Stuur een e-mail naar [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) met de tag `[bird-interact-lite GT&Test Cases]` in de titel voor de volledige set, die automatisch zal worden verzonden.


<!-- ### Gebruik de Dataset van HuggingFace

Je kunt de dataset downloaden van HuggingFace met het volgende commando:
```bash
from datasets import load_dataset
# Laad de flash-versie van de dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Laad de volledige versie van de dataset (binnenkort beschikbaar)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Of je kunt het meegeleverde script gebruiken om de volledige versie van de dataset te downloaden en deze op te splitsen in verschillende dialecten.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Pad naar het input JSONL-bestand (mag leeg zijn als je de dataset van HuggingFace wilt downloaden)
  --output_folder path/to/output_dir # outputmap van de gesplitste bestanden
``` -->

## Mappenstructuur
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


## 📋 Todo-lijsten

- [x] Lite-versie vrijgeven, bird-interact-lite (270).
- [x] Conversatieversie vrijgeven, bird-interact-conv.
- [x] Agentversie vrijgeven, bird-interact-agent.
- [ ] Volledige bird-interact-full (600) vrijgeven.
- [ ] SFT / RL en User Simulator

## Gemaakt door:
BIRD Team & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---