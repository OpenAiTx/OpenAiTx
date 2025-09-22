
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
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Licencja">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Tablica wyników">
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

## ⚠️ Ogłoszenie  
Prosimy pamiętać, że przed procesem ewaluacji, podczas ładowania baz danych przez Dockera, mogą sporadycznie wystąpić błędy związane z niespójnością środowiska (nie zakończą one procesu, ale pojawią się w logach Dockera). W efekcie niektóre bazy mogą nie załadować się poprawnie, co prowadzi do pustych baz danych. Powoduje to nienormalnie niskie wyniki ewaluacji.  
👉 Dlatego zdecydowanie zalecamy sprawdzenie logów Dockera pod kątem błędów **przed uruchomieniem ewaluacji** oraz potwierdzenie, że wszystkie bazy danych zostały poprawnie załadowane.

## 📰 Aktualności

- [2025-08-26] 🚀 Z radością ogłaszamy wydanie zestawu **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
To trudny zestaw — najlepsze LLM-y osiągają tylko **16,33%** skuteczności, z zaledwie **10,0%** dla części `c-interact` i `a-interact`.  
👉 Więcej szczegółów znajdziesz na naszej [stronie projektu](https://bird-interact.github.io/).

- [2025-08-26] 📬 W tym tygodniu wyślemy **Ground Truth & Test cases** na naszą listę mailingową.  
Jeśli chcesz uzyskać wcześniejszy dostęp, wyślij mail zgodnie z instrukcją na stronie, aby uzyskać **automatyczne pobranie**.  

- [2025-08-26] 💾 Ponadto wydaliśmy wersję SQLite **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** ułatwiającą lokalne badania.  
Pełne wersje **LiveSQLBench-Base** i **-Large** pojawią się wkrótce!

- [2025-08-22] **Poprawka błędu**: W kodzie Bird-Interact-Agent naprawiliśmy błąd, który powodował, że podczas ewaluacji SQL fazy 2 zapisany SQL fazy 1 nie mógł być pomyślnie wykonany, co prowadziło do niższej skuteczności fazy 2. Błąd dotyczył tylko tych zadań, w których SQL fazy 1 wykonuje operacje na bazie danych, np. CREATE table itd.

## 🧸 Przegląd

BIRD-INTERACT, interaktywny benchmark text-to-SQL, **na nowo definiuje ewaluację Text-to-SQL poprzez pryzmat dynamicznych interakcji**.
Środowisko łączy hierarchiczną bazę wiedzy, dokumentację bazy danych oraz symulator użytkownika oparty na funkcjach, by odwzorować autentyczne środowiska biznesowe obejmujące pełne operacje **CRUD**.
Oferuje dwa rygorystyczne tryby testowania: (1) pasywną **Interakcję Konwersacyjną** oraz (2) aktywną **Interakcję Agentową**, obejmującą 600 adnotowanych zadań, w tym Business Intelligence (BI), operacje CRUD i inne, z których każde zabezpieczone jest wykonywalnymi przypadkami testowymi.
Typowe oceny wywołują od 1 968 do 5 496 tur interakcji między modelem a symulatorem użytkownika, podczas gdy najnowocześniejsze modele rozumowania rozwiązują obecnie tylko **≈24%** oraz **≈18%** zadań, co podkreśla wyzwanie, jakie stanowi ten benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dwa Tryby Oceny

BIRD-INTERACT obsługuje dwa tryby oceny, jak wspomniano powyżej:

   - **c-Interact**: Interakcja Konwersacyjna, która jest trybem pasywnym, a przepływ pracy jest stały. Kod i szczegółowe informacje można znaleźć w `bird_interact_conv`.
   - **a-Interact**: Interakcja Agentowa, która jest ucieleśnionym trybem aktywnym, gdzie przepływ pracy jest dynamiczny i prowadzony przez modele. Kod i szczegółowe informacje można znaleźć w `bird_interact_agent`.

### 🐣 Wersja Lite

Udostępniamy wersję lite BIRD-INTERACT, `bird-interact-lite-exp`, która obejmuje 270 wysokiej jakości zadań rzeczywistych specjalnie dla PostgreSQL. To dobry punkt wyjścia do szybkich eksperymentów.

### 🦜 Wersja Pełna

Pełna wersja BIRD-INTERACT, `bird-interact-full`, to kompleksowy benchmark zawierający 600 zadań dla PostgreSQL. Obejmuje szeroki zakres operacji SQL i zapytań użytkownika. Pełna wersja pojawi się wkrótce.

### Wyniki Wydajności Modeli na BIRD-INTERACT Lite

#### 1. Wydajność **c-Interact**
| Pozycja | Nazwa Modelu      | Znormalizowana Nagroda | Poziom       |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Doskonały Chat |
| 2    | GPT-4o             | 30.33 | 💎 Dobry Chat      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Dobry Chat      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standardowy     |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standardowy     |
| 6    | Qwen3              | 20.33 | ⚪ Podstawowy      |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Podstawowy      |

#### 2. Wydajność **a-Interact**
| Pozycja | Nazwa Modelu      | Parametry Budżetowe* | Średnia Liczba Kroków/Zadanie | Średni Koszt (USD)/Zadanie | Znormalizowana Nagroda | Poziom                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|

| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Doskonała Interakcja  |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 Dobra Interakcja      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Dobra Interakcja      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standard              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standard              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Podstawowy            |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Podstawowy            |

> \* Parametry budżetowe: Początkowy Budżet/Budżet Cierpliwości Użytkownika, mierzony naszą wirtualną walutą *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Więcej szczegółów znajdziesz w [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Skalowanie Czasu Interakcji (ITS)

Skalowanie Czasu Interakcji (ITS) odnosi się do zdolności modelu do ciągłego zwiększania końcowej wydajności poprzez wieloturowe interakcje. Gdy ta wydajność interaktywna przewyższa idealizowaną, jednoetapową wydajność modelu dla w pełni określonego, jednoznacznego zadania, mówimy, że spełnia on **prawo ITS**. W miarę wzrostu cierpliwości użytkownika i liczby rund interakcji, wydajność stale się poprawia, pokazując, że model może utrzymać efektywną komunikację przez dłuższą rozmowę. Obecnie tylko claude-3-7-sonnet spełnia prawo ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Szczegóły Zbioru Danych

### Opis Zbioru Danych

- **Baza danych:** Kompletną bazę PostgreSQL można pobrać z [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Szczegóły znajdziesz w sekcji [Quick Eval](#quick-eval).
- **data:** Każda instancja danych zawiera następujące główne części:
   - `selected_database`: Nazwa bazy danych.  
   - `query`: Jednoznaczne zapytanie użytkownika.  
   - `amb_user_query`: Zapytanie użytkownika z wstrzykniętymi niejednoznacznościami.
   - `user_query_ambiguity`: Niejednoznaczności wstrzyknięte do zapytania użytkownika.
   - `non_critical_ambiguity`: Niejednoznaczności niekrytyczne, takie jak kolejność, limit itp.
   - `knowledge_ambiguity`: Niejednoznaczności powstałe przez zamaskowaną wiedzę zewnętrzną. 
   - `sol_sql`: Prawidłowe rozwiązanie SQL.  
   - `preprocess_sql`: Zapytania SQL do wykonania przed uruchomieniem rozwiązania lub predykcji.  
   - `clean_up_sql`: Zapytania SQL do wykonania po testach w celu cofnięcia zmian w bazie danych.  
   - `test_cases`: Zestaw przypadków testowych weryfikujących przewidywane poprawione SQL.
   - `follow_up`: Oznaczone pytania uzupełniające.
   - `external_knowledge`: Wiedza zewnętrzna związana z konkretnym zadaniem.

- **ewaluacja:** Kod ewaluacyjny znajduje się w katalogu [`./evaluation`](./evaluation).
- **Opracowane przez:** Zespół BIRD & Google Cloud
- **Licencja:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Karta zbioru danych HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Zastosowania zbioru danych

Aby uniknąć wycieku danych przez automatyczne pobieranie, nie dołączamy rozwiązań GT SQL ani przypadków testowych do danych.
prosimy o kontakt mailowy na adres [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) z tagiem `[bird-interact-lite GT&Test Cases]` w tytule, aby otrzymać pełny zestaw, który zostanie wysłany automatycznie.


<!-- ### Użyj zbioru danych z HuggingFace

Możesz pobrać zbiór danych z HuggingFace, używając następującego polecenia:
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

## 📋 Listy rzeczy do zrobienia

- [x] Wydanie wersji lite, bird-interact-lite (270).
- [x] Wydanie wersji konwersacyjnej, bird-interact-conv.
- [x] Wydanie wersji agenta, bird-interact-agent.
- [x] Wydanie pełnej wersji, bird-interact-full (600).
- [ ] SFT / RL symulatora użytkownika

## Utworzone przez:
Zespół BIRD & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---