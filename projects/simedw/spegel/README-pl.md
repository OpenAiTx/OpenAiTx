# Spegel – Odbijaj sieć przez AI

Automatycznie przepisuje strony internetowe do markdown zoptymalizowanego pod kątem wyświetlania w terminalu.
Przeczytaj wprowadzający wpis na blogu [tutaj](https://simedw.com/2025/06/23/introducing-spegel/)

To jest proof-of-concept, mogą występować błędy, ale śmiało zgłaszaj issue lub pull request.

##  Zrzut ekranu
Czasami nie chcesz czytać całej historii czyjegoś życia, żeby dostać się do przepisu
![Przykład przepisu](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Instalacja

Wymaga Pythona 3.11+

```
pip install spegel
```
lub sklonuj repozytorium i zainstaluj w trybie edytowalnym

```bash
# Sklonuj i wejdź do katalogu
$ git clone <repo-url>
$ cd spegel

# Zainstaluj zależności i CLI
$ pip install -e .
```

## Klucze API
Spegel obecnie obsługuje tylko Gemini 2.5 Flash, aby z niego korzystać, musisz podać swój klucz API w zmiennej środowiskowej

```
GEMINI_API_KEY=...
```


## Użycie

### Uruchom przeglądarkę

```bash
spegel                # Start z ekranem powitalnym
spegel bbc.com        # Otwórz URL od razu
```

Albo równoważnie:

```bash
python -m spegel      # Start z ekranem powitalnym
python -m spegel bbc.com
```

### Podstawowe sterowanie
- `/`         – Otwórz pole do wpisania URL
- `Tab`/`Shift+Tab` – Przełączanie linków
- `Enter`     – Otwórz zaznaczony link
- `e`         – Edytuj prompt LLM dla bieżącego widoku
- `b`         – Wróć
- `q`         – Wyjdź

## Edycja ustawień

Spegel ładuje ustawienia z pliku konfiguracyjnego TOML. Możesz dostosować widoki, prompt'y i opcje UI.

**Kolejność wyszukiwania pliku konfiguracyjnego:**
1. `./.spegel.toml` (bieżący katalog)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Aby edytować ustawienia:
1. Skopiuj przykładowy plik konfiguracyjny:
   ```bash
   cp example_config.toml .spegel.toml
   # lub utwórz ~/.spegel.toml
   ```
2. Edytuj `.spegel.toml` w swoim ulubionym edytorze.

Przykładowy fragment:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transform this webpage into the perfect terminal browsing experience! ..."
```

---

Aby dowiedzieć się więcej, zobacz kod lub otwórz issue!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---