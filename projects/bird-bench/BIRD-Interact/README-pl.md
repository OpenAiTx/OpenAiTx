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

## 🧸 Przegląd

BIRD-INTERACT, interaktywny benchmark text-to-SQL, **na nowo definiuje ewaluację Text-to-SQL poprzez pryzmat dynamicznych interakcji**.
Środowisko łączy hierarchiczną bazę wiedzy, dokumentację bazy danych oraz napędzany funkcjami symulator użytkownika, aby odtworzyć autentyczne środowiska korporacyjne obejmujące pełne operacje **CRUD**.
Oferuje dwa rygorystyczne tryby testowe: (1) pasywną **Interakcję Konwersacyjną** oraz (2) aktywną **Interakcję Agentyczną**, obejmującą 600 adnotowanych zadań, w tym Business Intelligence (BI), operacje CRUD itp., z których każde jest chronione przez wykonywalne przypadki testowe.
Typowa ewaluacja wywołuje od 1 968 do 5 496 tur interakcji między modelem a symulatorem użytkownika, podczas gdy najnowocześniejsze modele rozumowania rozwiązują obecnie tylko **≈24%** oraz **≈18%** zadań, co podkreśla wyzwania benchmarku.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dwa Tryby Ewaluacji

BIRD-INTERACT obsługuje dwa tryby ewaluacji opisane powyżej:

   - **c-Interact**: Interakcja Konwersacyjna, która jest trybem pasywnym, a workflow jest ustalony. Kod i szczegółowe informacje znajdują się w `bird_interact_conv`.
   - **a-Interact**: Interakcja Agentyczna, która jest ucieleśnionym trybem aktywnym, gdzie workflow jest dynamiczny i prowadzony przez modele. Kod i szczegółowe informacje znajdują się w `bird_interact_agent`.


### 🐣 Wersja Lite

Udostępniamy wersję lite BIRD-INTERACT, `bird-interact-lite-exp`, która zawiera 270 wysokiej jakości zadań rzeczywistych, przeznaczonych specjalnie dla PostgreSQL. To dobry punkt wyjścia do szybkich eksperymentów.

### 🦜 Wersja Pełna

Pełna wersja BIRD-INTERACT, `bird-interact-full`, to kompleksowy benchmark obejmujący 600 zadań dla PostgreSQL. Obejmuje szeroki zakres operacji SQL i zapytań użytkownika. Pełna wersja już wkrótce.

### Wyniki Wydajności Modeli na BIRD-INTERACT Lite

#### 1. Wydajność **c-Interact**
| Miejsce | Nazwa modelu      | Znormalizowana nagroda | Poziom           |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Doskonały Chat |
| 2    | GPT-4o             | 30.33 | 💎 Dobry Chat      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Dobry Chat      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standard        |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standard        |
| 6    | Qwen3              | 20.33 | ⚪ Podstawowy      |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Podstawowy      |

#### 2. Wydajność **a-Interact**
| Miejsce | Nazwa modelu      | Parametry budżetowe* | Śr. tury/zadanie | Śr. koszt (USD)/zadanie | Znormalizowana nagroda | Poziom                   |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:---------------------:|:-------------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15,4 | $0.6668 | 29.19 | 🏆 Doskonała Interakcja    |
| 2    | o3-mini            | 6/6 | 7,8  | $0.0754 | 21.07 | 💎 Dobra Interakcja        |
| 3    | DeepSeek-V3        | 6/6 | 15,6 | $0.0629 | 19.19 | 💎 Dobra Interakcja        |
| 4    | Qwen3              | 6/6 | 12,5 | $0.0278 | 18.74 | ✨ Standard                |
| 5    | GPT-4o             | 6/6 | 15,3 | $0.4594 | 18.37 | ✨ Standard                |
| 6    | Gemini-2.0-flash   | 6/6 | 13,2 | $0.0337 | 17.26 | ⚪ Podstawowy              |
| 7    | DeepSeek-R1        | 6/6 | 12,0 | $0.0931 | 17.07 | ⚪ Podstawowy              |

> \* Parametry budżetowe: Budżet początkowy/Budżet cierpliwości użytkownika, mierzony naszą wirtualną walutą *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Szczegóły w [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Skalowanie w Czasie Interakcji (ITS)

Interaction-Time Scaling (ITS) odnosi się do zdolności modelu do ciągłego zwiększania końcowej wydajności poprzez wieloturową interakcję. Gdy ta wydajność interakcyjna przewyższa idealizowaną wydajność modelu w pojedynczej turze dla w pełni określonego, jednoznacznego zadania, mówimy, że spełnia on **prawo ITS**. Wraz ze wzrostem cierpliwości użytkownika i liczby tur interakcji, wydajność stale się poprawia, co pokazuje, że model jest w stanie utrzymać efektywną komunikację podczas dłuższego dialogu. Obecnie tylko claude-3-7-sonnet spełnia prawo ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Szczegóły Zbioru Danych

### Opis Zbioru Danych

- **Baza danych:** Pełną bazę danych PostgreSQL można pobrać z [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Sprawdź sekcję [Quick Eval](#quick-eval) po więcej szczegółów.
- **data:** Każda instancja danych zawiera następujące główne części:
   - `selected_database`: Nazwa bazy danych.  
   - `query`: Jednoznaczne zapytanie użytkownika.  
   - `amb_user_query`: Zapytanie użytkownika z wstrzykniętymi niejednoznacznościami.
   - `user_query_ambiguity`: Niejednoznaczności wstrzyknięte do zapytania użytkownika.
   - `non_critical_ambiguity`: Niejednoznaczności niekrytyczne, jak kolejność, limit, itp.
   - `knowledge_ambiguity`: Niejasności powstałe na skutek zmaskowanej wiedzy zewnętrznej. 
   - `sol_sql`: Prawidłowe rozwiązanie SQL (ground truth).  
   - `preprocess_sql`: Zapytania SQL do uruchomienia przed wykonaniem rozwiązania lub predykcji.  
   - `clean_up_sql`: Zapytania SQL do uruchomienia po zakończeniu testów w celu cofnięcia wszelkich zmian w bazie danych.  
   - `test_cases`: Zestaw przypadków testowych do walidacji przewidywanego poprawionego SQL.
   - `follow_up`: Oznaczone pytania uzupełniające.
   - `external_knowledge`: Wiedza zewnętrzna związana z konkretnym zadaniem.

- **ocena:** Kod oceny znajduje się w katalogu [`./evaluation`](./evaluation).
- **Kuratorzy:** Zespół BIRD & Google Cloud
- **Licencja:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Karta Danych HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Zastosowania Zbioru Danych

Aby uniknąć wycieku danych przez automatyczne crawlowanie, nie udostępniamy wraz z danymi prawidłowych rozwiązań SQL oraz przypadków testowych.
prosimy o kontakt mailowy na [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) z tagiem `[bird-interact-lite GT&Test Cases]` w tytule, aby otrzymać pełny zestaw, który zostanie wysłany automatycznie.


<!-- ### Użycie zbioru danych z HuggingFace

Możesz pobrać zbiór danych z HuggingFace za pomocą poniższej komendy:
```bash
from datasets import load_dataset
# Załaduj wersję flash zbioru danych
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Załaduj pełną wersję zbioru danych (wkrótce dostępna)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

Lub możesz użyć dostarczonego skryptu, aby pobrać pełną wersję zbioru danych i podzielić go na różne dialekty.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Ścieżka do pliku wejściowego JSONL (może być pusta, jeśli chcesz pobrać zbiór danych z HuggingFace)
  --output_folder path/to/output_dir # folder wyjściowy dla podzielonych plików
``` -->

## Struktura Folderów
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
Szczegóły dotyczące uruchamiania **a-interact** można znaleźć w `./bird_interact_agent/README.md`; a **c-interact** w `./bird_interact_conv/README.md`.


## 📋 Lista Zadań

- [x] Wydanie wersji lite, bird-interact-lite (270).
- [x] Wydanie wersji konwersacyjnej, bird-interact-conv.
- [x] Wydanie wersji agentowej, bird-interact-agent.
- [ ] Wydanie pełnej wersji bird-interact-full (600).
- [ ] SFT / RL oraz Symulator Użytkownika

## Stworzone przez:
Zespół BIRD & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---