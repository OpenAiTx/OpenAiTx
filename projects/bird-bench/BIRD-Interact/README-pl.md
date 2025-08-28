
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

## Aktualności
- [2025-08-22] **Poprawka błędu**: W kodzie Bird-Interact-Agent usunięto błąd, który powodował, że podczas oceny SQL fazy 2 zapisane SQL z fazy 1 nie mogły być wykonane poprawnie, co prowadziło do niższego wskaźnika sukcesu fazy 2. Błąd dotyczył tylko tych zadań, gdzie SQL fazy 1 wykonywał operacje na bazie danych, np. CREATE table itp.

## 🧸 Przegląd

BIRD-INTERACT, interaktywny benchmark text-to-SQL, **na nowo definiuje ocenę Text-to-SQL poprzez pryzmat dynamicznych interakcji**.
Środowisko łączy hierarchiczną bazę wiedzy, dokumentację bazy danych oraz symulator użytkownika oparty na funkcjach, aby odtworzyć autentyczne środowiska biznesowe obejmujące pełne operacje **CRUD**.
Oferuje dwa rygorystyczne tryby testowe: (1) pasywną **Interakcję Konwersacyjną** oraz (2) aktywną **Interakcję Agentową**, obejmującą 600 zadań z adnotacjami, w tym Business Intelligence (BI), operacje CRUD itd., każde chronione przez wykonywalne przypadki testowe.
Typowe oceny generują od 1 968 do 5 496 tur interakcji między modelem a symulatorem użytkownika, podczas gdy najnowocześniejsze modele rozumowania rozwiązują obecnie tylko **≈24%** i **≈18%** zadań, co podkreśla wyzwanie benchmarku.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dwa Tryby Oceny

BIRD-INTERACT obsługuje dwa tryby oceny, jak wspomniano powyżej:

   - **c-Interact**: Interakcja Konwersacyjna, czyli tryb pasywny z ustalonym przebiegiem pracy. Kod oraz szczegółowe informacje dostępne są w `bird_interact_conv`.
   - **a-Interact**: Interakcja Agentowa, czyli ucieleśniony tryb aktywny, w którym przebieg pracy jest dynamiczny i prowadzony przez modele. Kod oraz szczegółowe informacje dostępne są w `bird_interact_agent`.


### 🐣 Wersja Lite

Wydajemy wersję lite BIRD-INTERACT, `bird-interact-lite-exp`, która zawiera 270 wysokiej jakości zadań rzeczywistych, specjalnie dla PostgreSQL. To dobry punkt wyjścia do szybkich eksperymentów.

### 🦜 Wersja Pełna

Pełna wersja BIRD-INTERACT, `bird-interact-full`, to kompleksowy benchmark obejmujący 600 zadań dla PostgreSQL. Obejmuje szeroki zakres operacji SQL i zapytań użytkowników. Pełna wersja już wkrótce.

### Wyniki wydajności modeli na BIRD-INTERACT Lite

#### 1. **c-Interact** Wyniki
| Miejsce | Nazwa Modelu      | Znormalizowana nagroda | Poziom         |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Doskonały czat |
| 2    | GPT-4o             | 30.33 | 💎 Dobry czat      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Dobry czat      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standardowy     |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standardowy     |
| 6    | Qwen3              | 20.33 | ⚪ Podstawowy      |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Podstawowy      |

#### 2. **a-Interact** Wyniki
| Miejsce | Nazwa Modelu      | Parametry budżetu* | Śr. kroków/zadanie | Śr. koszt (USD)/zadanie | Znormalizowana nagroda | Poziom                 |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Doskonała interakcja  |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 Dobra interakcja      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Dobra interakcja      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standardowa           |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standardowa           |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Podstawowa            |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Podstawowa            |

> \* Parametry budżetu: Budżet początkowy/Budżet cierpliwości użytkownika, mierzony naszą wirtualną walutą *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Zobacz [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) po więcej szczegółów.

### Skalowanie czasu interakcji (ITS)

Skalowanie czasu interakcji (ITS) odnosi się do zdolności modelu do ciągłego zwiększania końcowej wydajności poprzez wieloturnowe interakcje. Gdy ta wydajność interaktywna przekracza idealizowaną wydajność modelu w pojedynczej turze dla w pełni określonego, jednoznacznego zadania, mówimy, że spełnia on **prawo ITS**. Wraz ze wzrostem cierpliwości użytkownika i liczbą tur interakcji, wydajność stale rośnie, pokazując, że model potrafi utrzymać efektywną komunikację w rozbudowanym dialogu. Obecnie tylko claude-3-7-sonnet spełnia prawo ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Szczegóły zbioru danych

### Opis zbioru danych

- **Baza danych:** Kompletną bazę danych PostgreSQL można pobrać z [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Zobacz sekcję [Quick Eval](#quick-eval) po więcej szczegółów.
- **dane:** Każda instancja danych zawiera następujące główne części:
   - `selected_database`: Nazwa bazy danych.  
   - `query`: Jednoznaczne zapytanie użytkownika.  
   - `amb_user_query`: Zapytanie użytkownika z wstrzykniętymi niejednoznacznościami.
   - `user_query_ambiguity`: Niejednoznaczności wstrzyknięte do zapytania użytkownika.
   - `non_critical_ambiguity`: Niejednoznaczności niekrytyczne, takie jak kolejność, limit itp.
   - `knowledge_ambiguity`: Niejednoznaczności powstałe przez zamaskowaną wiedzę zewnętrzną. 
   - `sol_sql`: Prawidłowe rozwiązanie SQL (ground truth).  
   - `preprocess_sql`: Zapytania SQL do wykonania przed uruchomieniem rozwiązania lub predykcji.  
   - `clean_up_sql`: Zapytania SQL do wykonania po przypadkach testowych w celu cofnięcia zmian w bazie danych.  
   - `test_cases`: Zestaw przypadków testowych walidujących przewidywane poprawione SQL.
   - `follow_up`: Oznaczone pytania uzupełniające.
   - `external_knowledge`: Wiedza zewnętrzna związana z konkretnym zadaniem.

- **ocena:** Kod oceny dostępny jest w katalogu [`./evaluation`](./evaluation).
- **Kuratorka:** Zespół BIRD & Google Cloud
- **Licencja:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Karta zbioru HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Zastosowania zbioru danych

Aby uniknąć wycieku danych przez automatyczne pobieranie, nie dołączamy rozwiązań GT SQL i przypadków testowych razem z danymi.
prosimy o kontakt mailowy [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) z tagiem `[bird-interact-lite GT&Test Cases]` w tytule, aby otrzymać pełny zestaw, który zostanie wysłany automatycznie.


<!-- ### Użycie zbioru danych z HuggingFace

Możesz pobrać zbiór danych z HuggingFace za pomocą poniższego polecenia:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
Lub możesz użyć udostępnionego skryptu, aby pobrać pełną wersję zbioru danych i podzielić go na różne dialekty.

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Ścieżka do pliku wejściowego JSONL (może być pusta, jeśli chcesz pobrać zbiór danych z HuggingFace)
  --output_folder path/to/output_dir # folder wyjściowy dla podzielonych plików
```

## Struktura folderów
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

## 📰 Aktualności

🚀 Z radością ogłaszamy wydanie zestawu **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
To trudny zestaw — najlepsze modele LLM osiągają jedynie **16,33%** skuteczności, a tylko **10,0%** w częściach `c-interact` oraz `a-interact`.  
👉 Więcej informacji znajdziesz na naszej [stronie projektu](https://bird-interact.github.io/).

📬 W tym tygodniu wysyłamy **Ground Truth & Test cases** do naszej listy mailingowej.  
Jeśli chcesz uzyskać wcześniejszy dostęp, wyślij e-mail zgodnie z instrukcją na stronie, aby uzyskać **automatyczne pobranie**.  

💾 Dodatkowo, udostępniliśmy wersję SQLite **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**, aby ułatwić lokalne badania.  
Pełne wersje **LiveSQLBench-Base** oraz **-Large** pojawią się wkrótce!

## 📋 Lista zadań

- [x] Wydanie wersji lite, bird-interact-lite (270).
- [x] Wydanie wersji konwersacyjnej, bird-interact-conv.
- [x] Wydanie wersji agentowej, bird-interact-agent.
- [x] Wydanie pełnej wersji bird-interact-full (600).
- [ ] SFT / RL symulatora użytkownika

## Stworzone przez:
Zespół BIRD & Google Cloud



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---