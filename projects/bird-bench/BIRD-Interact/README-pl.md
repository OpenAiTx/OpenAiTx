
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

## ⚠️ Ogłoszenie  
Należy pamiętać, że przed procesem ewaluacji, podczas ładowania baz danych przez Dockera, mogą sporadycznie wystąpić błędy spowodowane niespójnością środowiska (nie przerywają one procesu, ale pojawią się w logach Dockera). W rezultacie niektóre bazy danych mogą nie załadować się poprawnie, co prowadzi do pustych baz. Spowoduje to nienaturalnie niskie wyniki ewaluacji.  
👉 Dlatego zdecydowanie zalecamy sprawdzenie logów Dockera pod kątem błędów **przed uruchomieniem ewaluacji** i upewnienie się, że wszystkie bazy danych załadowały się poprawnie.

👉 Zaktualizowaliśmy **Wytyczne dotyczące zgłoszeń**, gdzie wspierane są własne szkielety agentów. Zachęcamy do zapoznania się ze szczegółowymi wytycznymi zgłoszeniowymi [tutaj](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Aktualności

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: Udostępniamy **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)**, implementację opartą na Google ADK z modułową architekturą 3-mikroserwisów (agent, symulator użytkownika i środowisko DB). Możliwość łatwej podmiany własnego agenta, symulatora lub środowiska DB. Obsługuje wykonywanie równoległe oraz dowolnego dostawcę LLM zgodnego z [LiteLlm](https://docs.litellm.ai/docs/providers). Polecamy tę implementację do badań.

- [2026-02-08] 🔥🔥🔥 Nasza **[publikacja Bird-Interact](https://huggingface.co/papers/2510.05318)** została przyjęta na **ICLR 2026 (Oral)**! Do zobaczenia w Rio 🇧🇷!  

- [2025-11-06] 🐛 **Naprawa błędu** & 🐳 **Aktualizacja Dockera**: Aktualizacja sqlglot do wersji 26.16.4 w celu naprawy błędu uniemożliwiającego parserowi SQL poprawną analizę zapytań dla symulatora użytkownika. Można to naprawić przez ponowną instalację poleceniem `pip install sqlglot==26.16.4` w środowisku `bird_interact_eval`. Obraz `bird_interact_eval` także został zaktualizowany, można go pobrać i utworzyć nowy kontener `bird_interact_eval`.

- [2025-10-21] 🐳 **Aktualizacja Dockera**: Dodaliśmy dockera dla pełnego środowiska DB. Wypchnęliśmy 3 obrazy dockerowe (Base/Full DB Env oraz środowisko ewaluacji dla `a-Interact` i `c-Interact`) na Docker Hub dla łatwiejszej konfiguracji środowiska. Nie trzeba pobierać dumpów DB i budować obrazów ręcznie!

- [2025-10-08] 📝 Nasza **[publikacja Bird-Interact](https://huggingface.co/papers/2510.05318)** jest już publicznie dostępna!  
  Prezentuje pełne szczegóły, metodologię i ocenę naszego interaktywnego benchmarku text-to-SQL.  
  👉 Sprawdź i poznaj więcej szczegółów na temat [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Z przyjemnością ogłaszamy wydanie zestawu **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
To trudny zestaw — najlepsze LLM-y osiągają tylko **16,33%** skuteczności, zaledwie **10,0%** w częściach `c-interact` i `a-interact`.  
👉 Po więcej szczegółów odwiedź naszą [stronę projektu](https://bird-interact.github.io/).

- [2025-08-26] 📬 W tym tygodniu wyślemy **Ground Truth & Test cases** na naszą listę mailingową.  
Jeśli chcesz uzyskać wcześniejszy dostęp, wyślij e-mail zgodnie z instrukcją na stronie, aby otrzymać **automatyczne pobranie**.  

- [2025-08-26] 💾 Poza tym udostępniliśmy także wersję SQLite **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** dla łatwiejszych badań lokalnych.  
Pełne wersje **LiveSQLBench-Base** oraz **-Large** pojawią się wkrótce!

- [2025-08-22] **Poprawka błędu**: W kodzie Bird-Interact-Agent naprawiliśmy błąd, przez który podczas oceny SQL fazy 2, zapisany SQL fazy 1 nie mógł zostać poprawnie wykonany, co skutkowało niższym wskaźnikiem sukcesu fazy 2. Błąd dotyczył tylko tych zadań, w których SQL fazy 1 wykonuje operacje na bazie danych, np. CREATE table itd.

## 🧸 Przegląd

BIRD-INTERACT, interaktywny benchmark text-to-SQL, **na nowo definiuje ocenę Text-to-SQL przez pryzmat dynamicznych interakcji**.
Środowisko łączy hierarchiczną bazę wiedzy, dokumentację bazy danych oraz symulator użytkownika oparty na funkcjach, aby odtworzyć autentyczne środowiska korporacyjne obejmujące pełne operacje **CRUD**.
Oferuje dwa rygorystyczne tryby testowe: (1) pasywny **Conversational Interaction** oraz (2) aktywny **Agentic Interaction**, obejmując 600 anotowanych zadań, w tym Business Intelligence (BI), operacje CRUD itd., każde chronione przez wykonywalne przypadki testowe.
Typowe ewaluacje wywołują 1 968–5 496 zwrotów interakcji pomiędzy modelem a symulatorem użytkownika, podczas gdy najnowocześniejsze modele rozumowania rozwiązują obecnie tylko **≈24%** i **≈18%** zadań, co podkreśla wyzwanie benchmarku.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dwa tryby ewaluacji

BIRD-INTERACT obsługuje dwa tryby ewaluacji opisane powyżej:

   - **c-Interact**: Conversational Interaction, czyli tryb pasywny z ustalonym przebiegiem. Kod oraz szczegółowe informacje można znaleźć w `bird_interact_conv`.
   - **a-Interact**: Agentic Interaction, czyli aktywny tryb ucieleśniony, w którym przebieg jest dynamiczny i prowadzony przez modele. Kod oraz szczegółowe informacje znajdują się w `bird_interact_agent`.


### 🐣 Wersja Lite

Udostępniamy wersję light BIRD-INTERACT, `bird-interact-lite-exp`, która zawiera 270 wysokiej jakości rzeczywistych zadań specjalnie dla PostgreSQL. To dobry punkt wyjścia do szybkich eksperymentów. 

### 🦜 Wersja pełna

Pełna wersja BIRD-INTERACT, `bird-interact-full`, to kompleksowy benchmark obejmujący 600 zadań dla PostgreSQL. Zawiera szeroki zakres operacji SQL oraz zapytań użytkownika. Pełna wersja pojawi się wkrótce.

### Wyniki wydajności modeli na BIRD-INTERACT-FULL

#### 1. **c-Interact Text-to-SQL** Wydajność
| Miejsce | Nazwa modelu         | Znormalizowana nagroda | Śr. koszt (USD)/zadanie | Poziom               |
|:-------:|:---------------------|:----------------------:|:----------------------:|:--------------------:|
| 1       | Gemini-2.5-Pro       | 20.92                  | $0.04                  | 🏆 Doskonały Chat    |
| 2       | O3-Mini              | 20.27                  | $0.07                  | 🏆 Doskonały Chat    |
| 3       | Claude-Sonnet-4      | 18.35                  | $0.29                  | 💎 Dobry Chat        |
| 4       | Qwen-3-Coder-480B    | 17.75                  | $0.11                  | 💎 Dobry Chat        |
| 5       | Deepseek-Chat-V3.1   | 15.15                  | $0.12                  | ✨ Standardowy        |
| 6       | Claude-Sonnet-3.7    | 13.87                  | $0.29                  | ✨ Standardowy        |
| 7       | GPT-5                | 12.58                  | $0.08                  | ⚪ Podstawowy         |

#### 2. **a-Interact Text-to-SQL** Wydajność
| Miejsce | Nazwa modelu         | Znormalizowana nagroda | Śr. koszt (USD)/zadanie | Poziom                       |
|:-------:|:---------------------|:----------------------:|:-----------------------:|:----------------------------:|
| 1       | GPT-5                | 25.52                  | $0.24                   | 🏆 Doskonała Interakcja      |
| 2       | Claude-Sonnet-4      | 23.28                  | $0.51                   | 🏆 Doskonała Interakcja      |
| 3       | Claude-Sonnet-3.7    | 17.45                  | $0.60                   | 💎 Dobra Interakcja          |
| 4       | Gemini-2.5-Pro       | 17.33                  | $0.22                   | 💎 Dobra Interakcja          |
| 5       | O3-Mini              | 16.43                  | $0.06                   | ✨ Standardowa                |
| 6       | Deepseek-Chat-V3.1   | 13.47                  | $0.06                   | ✨ Standardowa                |
| 7       | Qwen-3-Coder-480B    | 10.58                  | $0.07                   | ⚪ Podstawowa                 |

> \* Parametry budżetowe: Początkowy budżet/Budżet cierpliwości użytkownika, mierzony naszą wirtualną walutą *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Zobacz [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) po więcej szczegółów.

### Skalowanie czasu interakcji (ITS)

Skalowanie czasu interakcji (ITS) odnosi się do zdolności modelu do ciągłego zwiększania końcowej wydajności poprzez wieloetapowe interakcje. Gdy ta wydajność interakcyjna przekracza wyidealizowaną wydajność modelu w pojedynczym kroku na w pełni określonym, jednoznacznym zadaniu, mówimy, że spełnia on **prawo ITS**. Wraz ze wzrostem cierpliwości użytkownika i liczbą tur dialogowych wydajność stale rośnie, pokazując, że model potrafi utrzymać skuteczną komunikację podczas dłuższej rozmowy. Obecnie tylko claude-3-7-sonnet spełnia prawo ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Konfiguracja środowiska

1. Uruchom kontenery Docker dla bazy danych bird-interact-lite, bazy danych bird-interact-full oraz środowiska ewaluacyjnego:
  
  > Jeśli chcesz ocenić tylko `bird-interact-lite`, możesz zakomentować usługę [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) w `docker-compose.yml`, aby przyspieszyć konfigurację środowiska.
  
  Uruchom środowisko poleceniem:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Poczekaj kilka minut na inicjalizację bazy danych.
   
  Możesz śledzić postęp budowy za pomocą:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Jeśli zakończono, powinieneś zobaczyć logi bez błędów, takich jak:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Jeśli wcześniej utworzyłeś kontenery i chcesz je odtworzyć, możesz uruchomić następujące polecenie:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   To uruchamia 3 kontenery używając gotowych obrazów z Docker Hub:
   - `bird_interact_postgresql`: baza danych PostgreSQL dla bird-interact-lite
   - `bird_interact_postgresql_full`: baza danych PostgreSQL dla bird-interact-full
   - `bird_interact_eval`: środowisko ewaluacyjne dla `a-Interact` i `c-Interact`.

   Teraz możesz uruchomić środowisko ewaluacyjne, wykonując następujące polecenie:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (Opcjonalnie) Zbuduj środowisko ręcznie (jeśli chcesz zbudować obrazy od podstaw):
   - Pobierz zrzuty bazy danych
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Rozpakuj i zmień nazwę na `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Rozpakuj i zmień nazwę na `env/postgre_table_dumps_full`.
   - Zbuduj środowisko ręcznie uruchamiając `docker-compose.build.yml`.
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Zalecane) Sprawdź, czy kontenery baz danych zostały zbudowane i działają poprawnie.

-  Wyświetl logi budowania kontenerów, aby upewnić się, że bazy danych zostały zbudowane pomyślnie i bez błędów:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Jeśli wystąpią błędy, w plikach dziennika zostanie wydrukowane `"Wystąpiły błędy podczas importu:"`.


-  Sprawdź, czy kontenery bazy danych są w dobrym stanie.
   
   Użyj naszego dostarczonego skryptu Python, aby zweryfikować metadane bazy danych:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Oczekiwane wyniki:
   - **bird-interact-lite**: 
     - 📈 Łączna liczba baz danych: 18
     - 📋 Łączna liczba tabel: 175
     - 🔢 Łączna liczba kolumn: 2286
     - 📈 Średnia liczba wierszy na tabelę: 1 038,48
     - 💾 Całkowity rozmiar: około 207,15 MB
   - **bird-interact-full**: 
     - 📈 Łączna liczba baz danych: 22
     - 📋 Łączna liczba tabel: 244
     - 🔢 Łączna liczba kolumn: 2011
     - 📈 Średnia liczba wierszy na tabelę: 1 121,19
     - 💾 Całkowity rozmiar: około 272,00 MB


## 📦 Szczegóły zbioru danych

### Opis zbioru danych

- **Baza danych:** Pełna baza danych PostgreSQL jest dostępna do pobrania z [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) i [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **dane:** Każda instancja danych zawiera następujące główne części:
   - `selected_database`: Nazwa bazy danych.  
   - `query`: Jednoznaczne zapytanie użytkownika.  
   - `amb_user_query`: Zapytanie użytkownika z wstrzykniętymi niejednoznacznościami.
   - `user_query_ambiguity`: Niejednoznaczności wstrzyknięte do zapytania użytkownika.
   - `non_critical_ambiguity`: Niejednoznaczności niekrytyczne, takie jak sortowanie, limit itd.
   - `knowledge_ambiguity`: Niejednoznaczności stworzone przez ukrytą wiedzę zewnętrzną. 
   - `sol_sql`: Prawidłowe rozwiązanie SQL.  
   - `preprocess_sql`: Zapytania SQL do uruchomienia przed wykonaniem rozwiązania lub predykcji.  
   - `clean_up_sql`: Zapytania SQL do uruchomienia po przypadkach testowych w celu cofnięcia zmian w bazie danych.  
   - `test_cases`: Zestaw przypadków testowych do walidacji przewidywanego poprawionego SQL.
   - `follow_up`: Oznaczone pytania dodatkowe.
   - `external_knowledge`: Wiedza zewnętrzna związana z konkretnym zadaniem.

- **ocena:** Kod oceny dostępny jest w katalogu [`./evaluation`](./evaluation).
- **Kuratorzy:** Zespół BIRD & Google Cloud
- **Licencja:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Karta zbioru danych HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  oraz [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) dla PostgreSQL; oraz [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) dla SQLite.
### Zastosowania zbioru danych

Aby uniknąć wycieku danych przez automatyczne pobieranie, nie dołączamy rozwiązań GT w SQL ani przypadków testowych wraz z danymi.
prosimy o kontakt mailowy na adres [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) z tagiem `[bird-interact-lite GT&Test Cases]` lub `[bird-interact-full GT&Test Cases]` w tytule, aby otrzymać dane referencyjne oraz przypadki testowe dla zbioru bird-interact-lite lub bird-interact-full, które zostaną wysłane automatycznie.


### Połączenie danych publicznych z danymi referencyjnymi i przypadkami testowymi

Następnie użyj poniższego skryptu, aby połączyć dane publiczne z danymi referencyjnymi i przypadkami testowymi:

Weźmy wersję pełną jako przykład:
(1) Uruchom:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
To utworzy nowy plik w `/path/to/bird_interact_data.jsonl` z połączonymi danymi.

(2) Następnie zastąp oryginalne dane publiczne połączonymi danymi:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

To samo dotyczy innych wersji: bird-interact-lite, wersja mini itp. Wystarczy ustawić poprawne ścieżki do danych publicznych oraz danych referencyjnych i przypadków testowych, a następnie zastąpić dane publiczne danymi połączonymi.




<!-- ### Użyj zbioru danych z HuggingFace

Zbiór danych możesz pobrać z HuggingFace za pomocą poniższego polecenia:
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
Szczegóły dotyczące uruchamiania **a-interact** można znaleźć w `./bird_interact_agent/README.md`; **c-interact** w `./bird_interact_conv/README.md`; a **implementację opartą na ADK** w `./BIRD-Interact-ADK/README.md`.

## 📋 Listy zadań

- [x] Wydanie wersji lite, bird-interact-lite (270).
- [x] Wydanie wersji konwersacyjnej, bird-interact-conv.
- [x] Wydanie wersji agenta, bird-interact-agent.
- [x] Wydanie pełnej wersji, bird-interact-full (600).
- [x] Wydanie implementacji opartej na ADK, BIRD-Interact-ADK.
- [ ] SFT / RL i Symulator Użytkownika

## Podziękowania
Chcielibyśmy wyrazić naszą szczerą wdzięczność **Irinie Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi** oraz profesorowi **Shinji Watanabe** za owocne dyskusje i cenne uwagi, które przyczyniły się do ulepszenia tego projektu.

## Stworzone przez:
Zespół BIRD & Google Cloud







## Cytowanie

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
## Dziennik zmian

- [2025-11-06] 🐛 **Naprawa błędu** & 🐳 **Aktualizacja Dockera**: Zaktualizowano wersję sqlglot do 26.16.4, aby naprawić błąd polegający na tym, że parser SQL nie potrafił poprawnie analizować SQL dla symulatora użytkownika. Możesz to naprawić, ponownie instalując przez `pip install sqlglot==26.16.4` w środowisku `bird_interact_eval`. Obraz `bird_interact_eval` został również zaktualizowany, więc możesz także go pobrać i odtworzyć kontener `bird_interact_eval`.
- [2025-10-21] 🐳 **Aktualizacja Dockera**: Dodano docker dla Full DB Env. Wysłaliśmy 3 obrazy dockerowe (Base/Full DB Env oraz środowisko ewaluacyjne dla `a-Interact` i `c-Interact`) na Docker Hub, aby ułatwić konfigurację środowiska. Nie ma potrzeby pobierania zrzutów DB i budowania obrazów ręcznie! Pobierz najnowsze obrazy z Docker Hub i odtwórz kontenery, np. używając `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Naprawa błędu**: Naprawiono błąd, przez który przy ocenie SQL z fazy 2, zapisane SQL z fazy 1 nie mogło być wykonane pomyślnie, co prowadziło do niższego wskaźnika sukcesu fazy 2. Ten błąd dotyczył tylko tych zadań, w których SQL z fazy 1 wykonuje operacje na bazie danych, np. CREATE table itp.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---