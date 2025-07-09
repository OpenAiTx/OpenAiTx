<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: dataframe (na nowo) stworzony do wnioskowania LLM

[![Wersja PyPI](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Wersje Pythona](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![Licencja](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Dokumentacja**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic to opiniotwórczy, inspirowany PySpark DataFrame framework od typedef.ai do budowy aplikacji AI oraz agentowych. Przekształcaj dane nieustrukturyzowane i strukturyzowane w informacje dzięki znanym operacjom DataFrame, wzbogaconym o inteligencję semantyczną. Oferuje natywne wsparcie dla markdown, transkryptów i operatorów semantycznych oraz wydajne wnioskowanie wsadowe dla dowolnego dostawcy modeli.
## Instalacja

fenic obsługuje Pythona `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### Konfiguracja dostawcy LLM

fenic wymaga klucza API od co najmniej jednego dostawcy LLM. Ustaw odpowiednią zmienną środowiskową dla wybranego dostawcy:

```bash
# Dla OpenAI
export OPENAI_API_KEY="twój-openai-api-key"

# Dla Anthropic
export ANTHROPIC_API_KEY="twój-anthropic-api-key"

# Dla Google
export GEMINI_API_KEY="your-google-api-key"
```

## Szybki start

Najszybszym sposobem na poznanie fenic jest przejrzenie przykładów.

Poniżej znajduje się szybka lista przykładów dostępnych w tym repozytorium:

| Przykład                                                                | Opis                                                                                                                                |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                    | Wprowadzenie do ekstrakcji semantycznej i klasyfikacji przy użyciu podstawowych operatorów fenic na przykładzie analizy logów błędów. |
| [Enrichment](examples/enrichment)                                       | Wieloetapowe DataFrame’y z ekstrakcją tekstu na podstawie szablonów, łączeniem i transformacjami wspieranymi przez LLM, pokazane na przykładzie wzbogacania logów. |
| [Przetwarzanie transkryptu spotkania](examples/meeting_transcript_processing) | Natywne parsowanie transkryptów, integracja schematów Pydantic oraz złożone agregacje przedstawione na przykładzie analizy spotkania. |
| [Analiza wiadomości](examples/news_analysis)                            | Analizuj i wydobywaj wnioski z artykułów prasowych przy użyciu operatorów semantycznych i przetwarzania danych strukturalnych.      |
| [Podsumowanie podcastu](examples/podcast_summarization)                 | Przetwarzaj i podsumowuj transkrypty podcastów z analizą z uwzględnieniem mówców oraz ekstrakcją kluczowych punktów.                |
| [Łączenie semantyczne](examples/semantic_joins)                         | Zamiast prostego dopasowania rozmytego, użyj zaawansowanej funkcji łączenia semantycznego fenic do dopasowywania danych między tabelami. |
| [Rozpoznawanie nazwanych jednostek](examples/named_entity_recognition)  | Wydobywaj i klasyfikuj nazwane jednostki z tekstu przy użyciu ekstrakcji semantycznej i klasyfikacji.                               |
| [Przetwarzanie Markdown](examples/markdown_processing)                  | Przetwarzaj i transformuj dokumenty markdown poprzez strukturalną ekstrakcję danych i formatowanie.                                 |
| [Przetwarzanie JSON](examples/json_processing)                          | Obsługuj złożone struktury danych JSON z operacjami semantycznymi i walidacją schematów.                                            |
| [Grupowanie opinii](examples/feedback_clustering)                       | Grupuj i analizuj opinie przy użyciu semantycznego podobieństwa i operacji klastrowania.                                            |
| [Ekstrakcja dokumentów](examples/document_extraction)                   | Wydobywaj strukturalne informacje z różnych formatów dokumentów przy użyciu operatorów semantycznych.                               |

(Możesz kliknąć dowolny przykład powyżej, aby przejść bezpośrednio do odpowiedniego folderu.)

## Dlaczego używać fenic?

fenic to opiniotwórczy, inspirowany PySpark framework DataFrame do budowania produkcyjnych aplikacji AI i agentowych.

W przeciwieństwie do tradycyjnych narzędzi danych dostosowanych do LLM, silnik zapytań fenic został zbudowany od podstaw z myślą o wnioskowaniu.

Przekształcaj dane strukturalne i niestrukturalne w informacje za pomocą znanych operacji DataFrame, wzbogaconych o inteligencję semantyczną. Z natywną obsługą markdown, transkryptów i operatorów semantycznych oraz wydajnym wnioskowaniem wsadowym dla dowolnego dostawcy modeli.

fenic wnosi niezawodność tradycyjnych potoków danych do obciążeń AI.

### Kluczowe cechy

#### Stworzony specjalnie do wnioskowania LLM

- Silnik zapytań zaprojektowany od zera dla obciążeń AI, a nie dostosowywany
- Automatyczna optymalizacja wsadowa dla wywołań API
- Wbudowana logika ponawiania i ograniczania liczby żądań
- Zliczanie tokenów i śledzenie kosztów

#### Operatory semantyczne jako pełnoprawni uczestnicy
- `semantic.analyze_sentiment` - Wbudowana analiza sentymentu
- `semantic.classify` - Kategoryzacja tekstu z użyciem kilku przykładów (few-shot)
- `semantic.extract` - Przekształcanie nieustrukturyzowanego tekstu w dane strukturalne z użyciem schematów
- `semantic.group_by` - Grupowanie danych według podobieństwa semantycznego
- `semantic.join` - Łączenie DataFrame'ów na podstawie znaczenia, nie tylko wartości
- `semantic.map` - Stosowanie transformacji języka naturalnego
- `semantic.predicate` - Tworzenie predykatów za pomocą języka naturalnego do filtrowania wierszy
- `semantic.reduce` - Agregowanie pogrupowanych danych za pomocą operacji LLM

#### Nattywne wsparcie dla nieustrukturyzowanych danych

Wykracza poza typowe multimodalne typy danych (audio, obrazy), tworząc wyspecjalizowane typy dla obciążeń opartych głównie na tekście:

- Parsowanie i ekstrakcja Markdown jako natywny typ danych
- Przetwarzanie transkrypcji (SRT, formaty ogólne) z rozpoznawaniem mówcy i znaczników czasu
- Manipulacja JSON z użyciem wyrażeń JQ dla danych zagnieżdżonych
- Automatyczne dzielenie tekstu na fragmenty z konfigurowalną nakładką dla długich dokumentów

#### Infrastruktura gotowa do produkcji
- Wsparcie dla wielu dostawców (OpenAI, Anthropic, Gemini)
- Lokalne i chmurowe backendy wykonawcze
- Kompleksowa obsługa błędów i logowanie
- Integracja z Pydantic dla bezpieczeństwa typów

#### Znany interfejs API DataFrame

- Operacje kompatybilne z PySpark
- Leniva ewaluacja i optymalizacja zapytań
- Obsługa SQL dla złożonych zapytań
- Bezproblemowa integracja z istniejącymi potokami danych

### Dlaczego DataFrames dla aplikacji LLM i agentowych?

Aplikacje AI i agentowe to fundamentalnie potoki i przepływy pracy – dokładnie to, do czego zaprojektowano API DataFrame. Zamiast wymyślać na nowo wzorce przekształcania, filtrowania i agregacji danych, fenic wykorzystuje dekady sprawdzonych praktyk inżynieryjnych.

#### Rozdzielona architektura dla lepszych agentów

fenic tworzy wyraźny podział między wymagającymi dużych zasobów zadaniami inferencyjnymi a interakcjami agentów w czasie rzeczywistym. Przenosząc przetwarzanie wsadowe poza środowisko agenta, zyskujesz:

- Bardziej przewidywalnych i responsywnych agentów
- Lepsze wykorzystanie zasobów dzięki wsadowym wywołaniom LLM
- Czystszy podział pomiędzy planowaniem/orchestracją a wykonaniem
#### Stworzone dla wszystkich inżynierów

DataFrames nie są przeznaczone tylko dla specjalistów od danych. Przemyślany, składany interfejs API sprawia, że są dostępne dla każdego inżyniera:

- Łańcuchowe operacje w naturalny sposób: `df.filter(...).semantic.group_by(...)`
- Płynne łączenie stylów imperatywnego i deklaratywnego
- Szybki start dzięki znanym wzorcom z pandas/PySpark lub SQL

## Wsparcie

Dołącz do naszej społeczności na [Discordzie](https://discord.gg/GdqF3J7huR), gdzie możesz połączyć się z innymi użytkownikami, zadawać pytania i uzyskać pomoc przy swoich projektach fenic. Nasza społeczność zawsze chętnie wita nowych członków!

Jeśli uważasz, że fenic jest przydatny, rozważ zostawienie nam ⭐ na górze tego repozytorium. Twoje wsparcie pomaga nam rozwijać i ulepszać framework dla wszystkich!

## Współtworzenie

Serdecznie witamy wszelkie formy współpracy! Niezależnie od tego, czy chcesz pisać kod, ulepszać dokumentację, testować funkcje, czy proponować nowe pomysły — Twoja pomoc jest dla nas cenna.

Dla programistów planujących zgłaszać zmiany w kodzie zalecamy najpierw otworzyć zgłoszenie (issue), aby omówić swoje pomysły przed utworzeniem Pull Requesta. Pomaga to zapewnić zgodność z kierunkiem projektu i zapobiega dublowaniu wysiłków.

Prosimy zapoznać się z naszymi [wytycznymi dotyczącymi współtworzenia](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md), aby uzyskać szczegółowe informacje o procesie rozwoju i konfiguracji projektu.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---