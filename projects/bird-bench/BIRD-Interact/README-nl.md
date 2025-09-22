
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
Let op: vóór het evaluatieproces kunnen er, wanneer Docker de databases laadt, soms fouten optreden door inconsistentie van de omgeving (deze beëindigen het proces niet, maar verschijnen in de Docker-logs). Hierdoor kunnen sommige databases niet goed worden geladen, wat leidt tot lege databases. Dit veroorzaakt abnormaal lage evaluatieresultaten.  
👉 Daarom raden wij sterk aan om vóór het uitvoeren van de evaluatie de Docker-logs te controleren op fouten en te verifiëren dat alle databases succesvol zijn geladen.

## 📰 Nieuws

- [2025-08-26] 🚀 We zijn verheugd om de release van de **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** set aan te kondigen!  
Dit is een moeilijke — de beste LLMs behalen slechts een **16,33%** succesratio, met slechts **10,0%** op de `c-interact` en `a-interact` onderdelen.  
👉 Ga voor meer details naar onze [projectwebsite](https://bird-interact.github.io/).

- [2025-08-26] 📬 We sturen deze week de **Ground Truth & Test cases** naar onze mailinglijst.  
Wil je vroege toegang, stuur dan een e-mail zoals aangegeven op de site voor een **automatische download**.  

- [2025-08-26] 💾 Daarnaast hebben we ook een SQLite-versie uitgebracht van **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** voor eenvoudiger lokaal onderzoek.  
De volledige **LiveSQLBench-Base** en **-Large** versies volgen binnenkort!

- [2025-08-22] **Bugfix**: In de Bird-Interact-Agent code hebben we een bug opgelost waarbij bij het evalueren van fase-2 SQL de opgeslagen fase-1 SQL niet succesvol kon worden uitgevoerd, wat leidde tot een lagere succesratio van fase-2. Deze bug beïnvloedt alleen taken waarbij fase1 SQL bewerkingen op de database uitvoert, zoals CREATE table, enz.

## 🧸 Overzicht

BIRD-INTERACT, een interactieve text-to-SQL benchmark, **herdefinieert Text-to-SQL evaluatie door de lens van dynamische interacties**.
De omgeving combineert een hiërarchische kennisbasis, database-documentatie en een functiegestuurde gebruikerssimulator om authentieke bedrijfsomgevingen na te bootsen over volledige **CRUD** operaties.
Het biedt twee rigoureuze testmodi: (1) passieve **Conversational Interaction** en (2) actieve **Agentic Interaction**, verspreid over 600 geannoteerde taken waaronder Business Intelligence (BI), CRUD-operaties enzovoorts, elk beveiligd met uitvoerbare testcases.
Typische evaluaties genereren 1.968-5.496 interactierondes tussen het model en de gebruikerssimulator, terwijl state-of-the-art redeneermodellen momenteel slechts **≈24%** en **≈18%** van de taken oplossen, wat de uitdaging van de benchmark benadrukt.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Twee Evaluatiemodi

BIRD-INTERACT ondersteunt twee evaluatiemodi zoals hierboven vermeld:

   - **c-Interact**: Conversationele interactie, een passieve modus waarbij de workflow vastligt. De code en gedetailleerde informatie zijn te vinden in `bird_interact_conv`.
   - **a-Interact**: Agentische interactie, een belichaamde actieve modus waarbij de workflow dynamisch is en wordt geleid door modellen. De code en gedetailleerde informatie zijn te vinden in `bird_interact_agent`.


### 🐣 Lite Versie

We brengen een lite-versie van BIRD-INTERACT uit, `bird-interact-lite-exp`, die 270 hoogwaardige real-world taken bevat, specifiek voor PostgreSQL. Dit is een goed startpunt voor snelle experimenten. 

### 🦜 Volledige Versie

De volledige versie van BIRD-INTERACT, `bird-interact-full`, is een uitgebreide benchmark die 600 taken voor PostgreSQL bevat. Het bestrijkt een breed scala aan SQL-operaties en gebruikersvragen. De volledige versie is binnenkort beschikbaar.

### Modelprestaties op BIRD-INTERACT Lite

#### 1. **c-Interact** Prestatie
| Rang | Modelnaam          | Genormaliseerde Beloning | Niveau        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Uitstekende Chat |
| 2    | GPT-4o             | 30.33 | 💎 Goede Chat      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Goede Chat      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standaard       |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standaard       |
| 6    | Qwen3              | 20.33 | ⚪ Basis           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Basis           |

#### 2. **a-Interact** Prestatie
| Rang | Modelnaam          | Budget Parameters* | Gem. Stappen/Taak | Gem. Kosten (USD)/Taak | Genormaliseerde Beloning | Niveau            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Uitstekende Interactie |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Goede Interactie      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Goede Interactie      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standaard              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standaard              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Basis                  |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Basis                  |

> \* Budgetparameters: Startbudget/Gebruikersgeduld-budget, gemeten met onze virtuele valuta *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Raadpleeg [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) voor meer details.

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) verwijst naar het vermogen van een model om zijn eindprestaties continu te verhogen door multi-turn interacties. Wanneer deze interactieve prestatie de geïdealiseerde single-turn prestatie van het model op een volledig gespecificeerde, eenduidige taak overtreft, zeggen we dat het voldoet aan de **ITS-wet**. Naarmate het gebruikersgeduld toeneemt en het aantal interactierondes stijgt, blijven de prestaties verbeteren, wat aantoont dat het model effectieve communicatie over langere dialogen kan volhouden. Momenteel vinden we alleen claude-3-7-sonnet dat voldoet aan de ITS-wet.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Datasetdetails

### Datasetbeschrijving

- **Database:** De volledige PostgreSQL-database kan worden gedownload van [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Bekijk het gedeelte [Quick Eval](#quick-eval) voor meer details.
- **data:** Elke datainstantie bevat de volgende hoofdonderdelen:
   - `selected_database`: De naam van de database.  
   - `query`: De eenduidige gebruikersvraag.  
   - `amb_user_query`: De gebruikersvraag met geïnjecteerde ambiguïteiten.
   - `user_query_ambiguity`: De ambiguïteiten die in de gebruikersvraag zijn geïnjecteerd.
   - `non_critical_ambiguity`: Niet-kritieke ambiguïteiten zoals volgorde, limiet, enz.
   - `knowledge_ambiguity`: Ambiguïteiten gecreëerd door gemaskeerde externe kennis. 
   - `sol_sql`: De grondwaarheid SQL-oplossing.  
   - `preprocess_sql`: SQL-queries die vooraf moeten worden uitgevoerd voordat de oplossing of voorspelling wordt uitgevoerd.  
   - `clean_up_sql`: SQL-queries die na de testcases worden uitgevoerd om eventuele wijzigingen in de database ongedaan te maken.  
   - `test_cases`: Een set testcases om de voorspelde gecorrigeerde SQL te valideren.
   - `follow_up`: De gelabelde vervolgvragen.
   - `external_knowledge`: De externe kennis die bij de specifieke taak hoort.

- **evaluatie:** De evaluatiecode is beschikbaar in de directory [`./evaluation`](./evaluation).
- **Samengesteld door:** BIRD Team & Google Cloud
- **Licentie:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Datasetkaart:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Gebruik van de dataset

Om datalekken door automatisch crawlen te voorkomen, bevatten we geen GT-oplossing sql's en testcases samen met de data.
stuur alstublieft een e-mail naar [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) met de tag `[bird-interact-lite GT&Test Cases]` in de titel voor de volledige set, die automatisch zal worden verstuurd.


<!-- ### Gebruik de dataset van HuggingFace

U kunt de dataset van HuggingFace downloaden met het volgende commando:
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

## 📋 Te Doen Lijsten

- [x] Lite-versie uitbrengen, bird-interact-lite (270).
- [x] Gespreksversie uitbrengen, bird-interact-conv.
- [x] Agentversie uitbrengen, bird-interact-agent.
- [x] Volledige versie uitbrengen, bird-interact-full (600).
- [ ] SFT / RL van een Gebruikerssimulator

## Gemaakt Door:
BIRD Team & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---