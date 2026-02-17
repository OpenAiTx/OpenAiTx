
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
Należy pamiętać, że przed rozpoczęciem procesu ewaluacji podczas ładowania baz danych przez Dockera mogą czasami wystąpić błędy wynikające z niespójności środowiska (nie przerywają one procesu, ale pojawią się w logach Dockera). W wyniku tego niektóre bazy danych mogą nie załadować się poprawnie, prowadząc do pustych baz. Spowoduje to nienaturalnie niskie wyniki ewaluacji.  
👉 Dlatego zdecydowanie zalecamy sprawdzenie logów Dockera pod kątem błędów **przed uruchomieniem ewaluacji** i upewnienie się, że wszystkie bazy danych zostały poprawnie załadowane.

👉 Zaktualizowaliśmy **Wytyczne dotyczące zgłoszeń**, gdzie wspierane są niestandardowe szablony agentów. Zachęcamy do zapoznania się ze szczegółowymi wytycznymi [tutaj](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Aktualności

- [2026-02-08] 🔥🔥🔥 Nasza **[publikacja Bird-Interact](https://huggingface.co/papers/2510.05318)** została przyjęta na **ICLR 2026 (Oral)**! Do zobaczenia w Rio 🇧🇷!  

- [2025-11-06] 🐛 **Naprawa błędu** & 🐳 **Aktualizacja Dockera**: Zaktualizowano wersję sqlglot do 26.16.4, aby naprawić błąd, przez który parser SQL nie mógł poprawnie analizować zapytań SQL dla symulatora użytkownika. Możesz to naprawić, ponownie instalując `pip install sqlglot==26.16.4` w środowisku `bird_interact_eval`. Zaktualizowano także obraz `bird_interact_eval`, więc możesz go pobrać i odtworzyć kontener `bird_interact_eval`.

- [2025-10-21] 🐳 **Aktualizacja Dockera**: Dodaliśmy obraz Dockera dla pełnego środowiska baz danych. Udostępniliśmy 3 obrazy Docker (Bazowy/Pełna Baza Danych oraz środowisko ewaluacyjne zarówno dla `a-Interact`, jak i `c-Interact`) w Docker Hub, aby ułatwić konfigurację środowiska. Nie trzeba pobierać dumpów baz i budować obrazów ręcznie!

- [2025-10-08] 📝 Nasza **[publikacja Bird-Interact](https://huggingface.co/papers/2510.05318)** jest już publicznie dostępna!  
  Przedstawia pełne szczegóły, metodologię i ewaluację naszego interaktywnego benchmarku text-to-SQL.  
  👉 Zajrzyj i dowiedz się więcej o pomysłach stojących za [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 Z radością ogłaszamy wydanie **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
To trudny zestaw — najlepsze LLMy osiągają tylko **16,33%** skuteczności, a na częściach `c-interact` i `a-interact` zaledwie **10,0%**.  
👉 Więcej szczegółów znajdziesz na naszej [stronie projektu](https://bird-interact.github.io/).

- [2025-08-26] 📬 W tym tygodniu wyślemy **Ground Truth & Test cases** na naszą listę mailingową.  
Jeśli chcesz uzyskać wcześniejszy dostęp, wyślij e-mail zgodnie z instrukcjami na stronie, aby uzyskać **automatyczne pobranie**.  

- [2025-08-26] 💾 Dodatkowo udostępniliśmy wersję SQLite **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**, ułatwiającą lokalne badania.  
Pełne wersje **LiveSQLBench-Base** oraz **-Large** pojawią się wkrótce!

- [2025-08-22] **Naprawa błędu**: W kodzie Bird-Interact-Agent naprawiliśmy błąd, przez który podczas oceny fazy 2 SQL zapisany SQL z fazy 1 nie mógł być poprawnie wykonany, co prowadziło do niższego wskaźnika sukcesu fazy 2. Błąd dotyczył tylko zadań, w których SQL z fazy 1 wykonuje operacje na bazie, np. CREATE table itd.

## 🧸 Przegląd

BIRD-INTERACT, interaktywny benchmark text-to-SQL, **na nowo definiuje ocenę Text-to-SQL przez pryzmat dynamicznych interakcji**.
Środowisko łączy hierarchiczną bazę wiedzy, dokumentację bazy danych oraz napędzany funkcjami symulator użytkownika, by odtworzyć autentyczne środowiska korporacyjne dla pełnych operacji **CRUD**.
Oferuje dwa rygorystyczne tryby testowe: (1) pasywną **Interakcję Konwersacyjną** oraz (2) aktywną **Interakcję Agentową**, obejmując 600 zadań z adnotacjami, w tym Business Intelligence (BI), operacje CRUD i inne, każde zabezpieczone wykonującymi się przypadkami testowymi.
Typowe oceny wywołują 1,968-5,496 tur interakcji między modelem a symulatorem użytkownika, podczas gdy najnowsze modele rozumowania rozwiązują obecnie tylko **≈24%** oraz **≈18%** zadań, co podkreśla wyzwanie benchmarku.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dwa Tryby Oceny

BIRD-INTERACT obsługuje dwa tryby oceny, jak wspomniano powyżej:

   - **c-Interact**: Interakcja konwersacyjna, która jest trybem pasywnym i ma ustalony przebieg. Kod oraz szczegóły znajdują się w `bird_interact_conv`.
   - **a-Interact**: Interakcja agentowa, będąca aktywnym trybem ucieleśnionym, gdzie przebieg jest dynamiczny i prowadzony przez modele. Kod oraz szczegóły dostępne są w `bird_interact_agent`.


### 🐣 Wersja Lite

Udostępniamy wersję lite BIRD-INTERACT, `bird-interact-lite-exp`, która zawiera 270 wysokiej jakości zadań rzeczywistych specjalnie dla PostgreSQL. To dobry punkt startowy do szybkich eksperymentów. 

### 🦜 Pełna Wersja

Pełna wersja BIRD-INTERACT, `bird-interact-full`, to kompleksowy benchmark zawierający 600 zadań dla PostgreSQL. Obejmuje szeroki zakres operacji SQL i zapytań użytkownika. Pełna wersja pojawi się wkrótce.

### Wyniki wydajności modeli na BIRD-INTERACT-FULL

#### 1. **c-Interact Text-to-SQL** Wydajność
| Rank | Nazwa modelu      | Normalizowana nagroda | Średni koszt (USD)/zadanie | Poziom              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 Doskonały Chat  |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 Doskonały Chat  |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 Dobry Chat      |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 Dobry Chat      |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ Standardowy      |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ Standardowy      |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ Podstawowy       |

#### 2. **a-Interact Text-to-SQL** Wyniki
| Rank | Nazwa Modelu       | Znormalizowana Nagroda | Średni Koszt (USD)/Zadanie | Poziom                      |
|:----:|:-------------------|:----------------------:|:--------------------------:|:---------------------------:|
| 1    | GPT-5              | 25.52                  | $0.24                      | 🏆 Doskonała Interakcja     |
| 2    | Claude-Sonnet-4    | 23.28                  | $0.51                      | 🏆 Doskonała Interakcja     |
| 3    | Claude-Sonnet-3.7  | 17.45                  | $0.60                      | 💎 Dobra Interakcja         |
| 4    | Gemini-2.5-Pro     | 17.33                  | $0.22                      | 💎 Dobra Interakcja         |
| 5    | O3-Mini            | 16.43                  | $0.06                      | ✨ Standardowa              |
| 6    | Deepseek-Chat-V3.1 | 13.47                  | $0.06                      | ✨ Standardowa              |
| 7    | Qwen-3-Coder-480B  | 10.58                  | $0.07                      | ⚪ Podstawowa               |

> \* Parametry budżetu: Początkowy Budżet/Budżet Cierpliwości Użytkownika, mierzony naszą wirtualną walutą *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Szczegóły w [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting).

### Skalowanie czasu interakcji (ITS)

Skalowanie czasu interakcji (ITS) odnosi się do zdolności modelu do ciągłego zwiększania końcowej wydajności poprzez wielokrotne interakcje. Gdy ta interaktywna wydajność przewyższa idealizowaną wydajność modelu w pojedynczym ruchu na w pełni określonym, jednoznacznym zadaniu, mówimy, że spełnia **prawo ITS**. Wraz ze wzrostem cierpliwości użytkownika i liczby interakcji, wyniki rosną, pokazując, że model potrafi utrzymać skuteczną komunikację w długim dialogu. Obecnie tylko claude-3-7-sonnet spełnia prawo ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Konfiguracja środowiska

1. Uruchom kontenery Dockera dla bazy bird-interact-lite, bazy bird-interact-full i środowiska ewaluacyjnego:
  
  > Jeśli chcesz tylko ewaluować na `bird-interact-lite`, możesz zakomentować [serwis `postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) w `docker-compose.yml`, aby przyspieszyć konfigurację środowiska.
  
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
     - 💾 Całkowity rozmiar: 207,15 MB (około)
   - **bird-interact-full**: 
     - 📈 Łączna liczba baz danych: 22
     - 📋 Łączna liczba tabel: 244
     - 🔢 Łączna liczba kolumn: 2011
     - 📈 Średnia liczba wierszy na tabelę: 1 121,19
     - 💾 Całkowity rozmiar: 272,00 MB (około)


## 📦 Szczegóły zbioru danych

### Opis zbioru danych

- **Baza danych:** Pełną bazę danych PostgreSQL można pobrać z [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) oraz [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **dane:** Każda instancja danych zawiera następujące główne części:
   - `selected_database`: Nazwa bazy danych.  
   - `query`: Jednoznaczne zapytanie użytkownika.  
   - `amb_user_query`: Zapytanie użytkownika z wstrzykniętymi niejednoznacznościami.
   - `user_query_ambiguity`: Niejednoznaczności wstrzyknięte do zapytania użytkownika.
   - `non_critical_ambiguity`: Niekrytyczne niejednoznaczności jak order, limit, itp.
   - `knowledge_ambiguity`: Niejednoznaczności utworzone przez zamaskowaną wiedzę zewnętrzną. 
   - `sol_sql`: Prawidłowe rozwiązanie SQL.  
   - `preprocess_sql`: Zapytania SQL do uruchomienia przed wykonaniem rozwiązania lub predykcji.  
   - `clean_up_sql`: Zapytania SQL do uruchomienia po przypadkach testowych, aby cofnąć zmiany w bazie danych.  
   - `test_cases`: Zestaw przypadków testowych do walidacji poprawności przewidywanego skorygowanego SQL.
   - `follow_up`: Oznaczone pytania uzupełniające.
   - `external_knowledge`: Wiedza zewnętrzna związana z konkretnym zadaniem.

- **ewaluacja:** Kod ewaluacyjny dostępny jest w katalogu [`./evaluation`](./evaluation).
- **Opracowane przez:** Zespół BIRD & Google Cloud
- **Licencja:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Karta zbioru danych HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  oraz [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
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
Szczegóły dotyczące uruchamiania **a-interact** można znaleźć w `./bird_interact_agent/README.md`; natomiast informacje o **c-interact** znajdują się w `./bird_interact_conv/README.md`.

## 📋 Lista zadań

- [x] Wydanie wersji lite, bird-interact-lite (270).
- [x] Wydanie wersji konwersacyjnej, bird-interact-conv.
- [x] Wydanie wersji agentowej, bird-interact-agent.
- [x] Wydanie pełnej wersji, bird-interact-full (600).
- [ ] SFT / RL oraz Symulator Użytkownika

## Podziękowania
Chcielibyśmy wyrazić naszą szczerą wdzięczność dla **Iriny Sapariny**, **Mohammadrezy Pourrezy**, **Mehdiego Bouzouiny**, **Hailonga Li**, **Jiatonga Shi** oraz profesora **Shinji Watanabe** za owocne dyskusje i cenne uwagi, które pomogły ulepszyć ten projekt.

## Autorzy:
Zespół BIRD & Google Cloud








## Dziennik zmian

- [2025-11-06] 🐛 **Poprawka błędu** & 🐳 **Aktualizacja Dockera**: Zaktualizowano wersję sqlglot do 26.16.4, aby naprawić błąd uniemożliwiający poprawną analizę SQL przez parser SQL dla symulatora użytkownika. Możesz to naprawić, ponownie instalując pakiet za pomocą `pip install sqlglot==26.16.4` w środowisku `bird_interact_eval`. Zaktualizowano również obraz `bird_interact_eval`, więc możesz go pobrać i odtworzyć kontener `bird_interact_eval`.
- [2025-10-21] 🐳 **Aktualizacja Dockera**: Dodano dockera dla pełnego środowiska bazy danych. Wysłaliśmy 3 obrazy dockera (Base/Full DB Env oraz środowisko ewaluacyjne zarówno dla `a-Interact`, jak i `c-Interact`) do Docker Hub, aby ułatwić konfigurację środowiska. Nie trzeba pobierać dumpów baz danych ani budować obrazów ręcznie! Proszę pobrać najnowsze obrazy z Docker Hub i odtworzyć kontenery, np. używając `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Poprawka błędu**: Naprawiono błąd, który powodował, że przy ewaluacji SQL fazy 2 zapisany SQL fazy 1 nie mógł być poprawnie wykonany, co prowadziło do niższego wskaźnika sukcesu w fazie 2. Błąd ten dotyczył tylko tych zadań, w których SQL fazy 1 wykonuje operacje na bazie danych, np. CREATE table itp.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---