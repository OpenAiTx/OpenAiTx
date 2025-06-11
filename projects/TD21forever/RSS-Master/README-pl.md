# RSS-Master

Dedykowane filtrowanie i selekcja źródeł RSS, wykorzystujące AI do podsumowań, streszczeń i ocen. Wersja zoptymalizowana pod kątem wydajności, wspierająca przetwarzanie asynchroniczne i równoległe podsumowania AI.

### Wstęp

Na początku września zacząłem korzystać z Inoreader + RSSHub do agregowania i subskrybowania interesujących mnie kanałów RSS, w połączeniu z czytnikiem Reeder, próbując całkowicie kontrolować źródła informacji, które codziennie do mnie trafiają. Po miesiącu, rosnąca liczba źródeł RSS i stale zwiększająca się ilość nieprzeczytanych wiadomości zaczęły powodować u mnie niepokój związany z czytaniem, więc zacząłem się zastanawiać, czy istnieje sposób na dostosowanie reguł filtrowania, najlepiej z wykorzystaniem AI do wspomagania czytania i zmniejszenia mojego obciążenia.

Inoreader posiada wbudowane filtry, ale płacenie tylko za tę funkcję wydawało mi się mało opłacalne; NewsBlur oferuje „Intelligence Trainer” do inteligentnej klasyfikacji, ale po krótkim przetestowaniu efekt był niezadowalający i nie odczułem inteligencji w krótkim czasie; Feedly ma zarówno filtrowanie, jak i funkcje AI, co brzmiało obiecująco i odpowiadało moim potrzebom, ale gdy wahałem się, czy przejść z Inoreadera na płatnego użytkownika Feedly, natknąłem się na dwa projekty:

- [Podsumowanie Hacker News za pomocą ChatGPT](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [Instrukcja użytkowania RSS-GPT](http://yinan.me/rss-gpt-manual-zh.html)

Oba projekty opierają się na wykorzystaniu GitAction do uruchomienia skryptu, który po pobraniu danych używa API OpenAI do tłumaczenia i podsumowania, następnie renderuje wynik w szablonie i publikuje na GitHub Pages. Metoda z RSS-GPT bardziej odpowiadała moim potrzebom — poprzez okresowe uruchamianie skryptu bezpośrednio pobierającego pliki XML RSS, przetwarzanie ich i publikowanie na GitHub Pages, co pozwala uzyskać link do XML, który można subskrybować w czytniku.

Mam silną potrzebę synchronizacji Inoreadera na wielu urządzeniach, a nowe źródła RSS dodawane do pliku konfiguracyjnego muszą być natychmiast synchronizowane w Inoreaderze, dlatego na bazie pomysłu [RSS-GPT](https://github.com/yinan-c/) rozszerzyłem go, tworząc RSS-Master.

### Funkcje

- **Wsparcie dla przetwarzania równoległego**: wykorzystanie asynchroniczności i puli wątków do równoległego przetwarzania źródeł RSS i podsumowań AI, co znacznie przyspiesza działanie
- **Ulepszony mechanizm cache’owania**: bardziej stabilny system cache, zapobiegający utracie danych i poprawiający wydajność przy powtórnych odczytach
- **Lepsza obsługa błędów**: pełna obsługa błędów i logowanie wszystkich operacji dla zwiększenia stabilności
- **Optymalizacja ekstrakcji treści HTML**: inteligentne wydobywanie treści artykułów, ignorowanie nieistotnych informacji, co podnosi jakość podsumowań AI
- **Wsparcie najnowszego API OpenAI**: pełna kompatybilność z najnowszą wersją API OpenAI
- **Szczegółowe statystyki**: po zakończeniu przetwarzania dostępne są statystyki czasu działania, wskaźnika sukcesów i kosztów
- **Generowanie plików opml**: oraz konwersja między opml i config.yml: `script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`
- **Własne reguły filtrowania**: obsługa reguł typu include i exclude, dla pól title i article
- **Możliwość wyboru modelu AI**: konfiguracja modelu OpenAI przez zmienne środowiskowe
- **Konfigurowalny podstawowy URL**: ustawienie bazowego URL dostępu do plików RSS, ułatwiające wdrożenie w różnych środowiskach
- **Interaktywny notatnik testowy**: Jupyter notebook do testowania funkcji

### Konfiguracja zmiennych środowiskowych

Projekt obsługuje konfigurację poniższych parametrów przez plik `.env`:

```
# Parametry wymagane
OPENAI_API_KEY=twoj_klucz_openai_tutaj

# Parametry opcjonalne
RSS_BASE_URL=https://raw.githubusercontent.com/TD21forever/RSS-Master/main/  # Bazowy URL RSS
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # Model OpenAI
LOG_LEVEL=INFO                               # Poziom logów
PARALLEL_WORKERS=5                           # Liczba równoległych wątków
```

Możesz skopiować plik `.env.example`, zmienić jego nazwę na `.env` i dostosować wartości parametrów.

### Ulepszenia wydajności

Wersja ta zawiera następujące usprawnienia wydajności w porównaniu do oryginału:

1. **Równoległe przetwarzanie źródeł RSS**: obsługa wielu kanałów RSS za pomocą `asyncio`
2. **Równoległe podsumowania AI**: wykorzystanie puli wątków do równoczesnego przetwarzania wielu artykułów
3. **Optymalizacja przetwarzania tekstu**: ulepszony algorytm ekstrakcji treści HTML, inteligentniejsze wydobycie najważniejszych informacji
4. **Bezpieczne operacje na plikach**: mechanizm bezpiecznego zapisu plików zapobiegający utracie danych przy awarii programu
5. **Optymalizacja użycia pamięci**: udoskonalone struktury danych i przepływ przetwarzania zmniejszające zużycie pamięci

### Instrukcja użytkowania

1. Sklonuj repozytorium na lokalny komputer
2. Zainstaluj zależności: `pip install -r requirements.txt`
3. Utwórz plik `.env` i ustaw klucz OpenAI API: `OPENAI_API_KEY=twoj_klucz`
4. Skonfiguruj źródła RSS w pliku `resource/config.yml`
5. Uruchom przetwarzanie poleceniem: `python main.py`

### Testowanie i debugowanie

Projekt zawiera interaktywny notatnik testowy `test.ipynb`, który pozwala na testowanie funkcji:

1. Pobieranie i parsowanie źródeł RSS
2. Funkcje filtrów
3. Podsumowania AI
4. Mechanizm cache
5. Konfiguracja bazowego URL
6. Testy wydajności

Jak używać:

```bash
# Instalacja Jupyter
pip install jupyter

# Uruchomienie notatnika
jupyter notebook test.ipynb
```

### Przykład niestandardowych reguł filtrowania

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### Zrzuty ekranu

- Funkcja podsumowań i streszczeń AI

<div style="display: flex;">
    <img src="https://qiniu.dcts.top/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://qiniu.dcts.top/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Niestandardowe filtrowanie: filtrowanie kanału „什么值得买” z dobrymi ofertami, rekomendowanie tylko niedawno potrzebnych produktów, np. napojów gazowanych

<img src="https://qiniu.dcts.top/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400; height: 400;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---