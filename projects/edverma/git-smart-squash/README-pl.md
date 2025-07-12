# Git Smart Squash

Przestań tracić czas na ręczne reorganizowanie commitów. Pozwól, aby AI zrobiła to za Ciebie.

## Problem

Znasz to: 15 commitów do jednej funkcji, z czego połowa to "fix", "typo" lub "WIP". Teraz musisz to uporządkować przed przeglądem PR. Ręczne squashowanie i przepisywanie jest żmudne.

## Rozwiązanie

Git Smart Squash analizuje Twoje zmiany i reorganizuje je w logiczne commity z odpowiednimi wiadomościami:

```bash
# Przed: Twój nieuporządkowany branch
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation

# Po: czyste, logiczne commity
* feat: implementacja systemu uwierzytelniania JWT
* test: dodanie pokrycia testami endpointu auth
```

## Szybki start

### 1. Instalacja

```bash
# Za pomocą pip
pip install git-smart-squash

# Za pomocą pipx (zalecane do izolowanej instalacji)
pipx install git-smart-squash

# Za pomocą uv (szybki menedżer pakietów Pythona)
uv tool install git-smart-squash
```
### 2. Skonfiguruj AI

**Opcja A: Lokalnie (Darmowe, Prywatne)**
```bash
# Zainstaluj Ollama z https://ollama.com
ollama pull devstral  # Domyślny model
```

**Opcja B: Chmura (Lepsze wyniki)**
```bash
export OPENAI_API_KEY="twój-klucz"
export ANTHROPIC_API_KEY="twój-klucz"
export GEMINI_API_KEY="twój-klucz"
```

### 3. Uruchom

```bash
cd twoje-repo
git-smart-squash
```
To wszystko. Przejrzyj plan i zatwierdź.

## Parametry linii poleceń

| Parametr | Opis | Domyślnie |
|----------|------|-----------|
| `--base` | Gałąź bazowa do porównania | Plik konfiguracyjny lub `main` |
| `--ai-provider` | Dostawca AI do użycia (openai, anthropic, local, gemini) | Skonfigurowane w ustawieniach |
| `--model` | Konkretna używana wersja modelu AI (patrz zalecane modele poniżej) | Domyślny model dostawcy |
| `--config` | Ścieżka do niestandardowego pliku konfiguracyjnego | `.git-smart-squash.yml` lub `~/.git-smart-squash.yml` |
| `--auto-apply` | Zastosuj plan commitów bez potwierdzenia | `false` |
| `--instructions`, `-i` | Własne instrukcje dla AI (np. "Grupuj według obszaru funkcjonalnego") | Brak |
| `--no-attribution` | Wyłącz komunikat atrybucji w commitach | `false` |
| `--debug` | Włącz logowanie debugowania dla szczegółowych informacji | `false` |

## Zalecane modele

### Modele domyślne
- **OpenAI**: `gpt-4.1` (domyślny)
- **Anthropic**: `claude-sonnet-4-20250514` (domyślny)
- **Gemini**: `gemini-2.5-pro` (domyślny)
- **Local/Ollama**: `devstral` (domyślny)

### Wybór modelu
```bash
# Wskaż inny model
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Dla lokalnego Ollama
git-smart-squash --ai-provider local --model llama-3.1
```

## Własne instrukcje

Parametr `--instructions` pozwala kontrolować, jak porządkowane są commity:

### Przykłady
```bash
# Dodaj prefiksy zgłoszeń
git-smart-squash -i "Prefix all commits with [ABC-1234]"

# Rozdziel według typu
git-smart-squash -i "Keep backend and frontend changes in separate commits"
```
# Ogranicz liczbę commitów
git-smart-squash -i "Utwórz maksymalnie 3 commity łącznie"
```

### Wskazówki dla lepszych rezultatów
- **Bądź precyzyjny**: "Pogrupuj migracje bazy danych osobno" działa lepiej niż "uporządkuj ładnie"
- **Jedna instrukcja naraz**: Złożone, wieloczęściowe instrukcje mogą zostać częściowo zignorowane
- **Używaj lepszych modeli**: Większe modele lepiej realizują polecenia niż mniejsze modele

## Typowe przypadki użycia

### "Muszę posprzątać przed przeglądem PR"
```bash
git-smart-squash              # Pokazuje plan i prosi o potwierdzenie
git-smart-squash --auto-apply # Automatycznie stosuje bez pytania
```

### "Pracuję z inną główną gałęzią"
```bash
git-smart-squash --base develop
```
### "Chcę użyć konkretnego dostawcy AI"
```bash
git-smart-squash --ai-provider openai
```

## Bezpieczeństwo

**Twój kod jest bezpieczny:**
- Pokazuje plan przed wprowadzeniem zmian
- Tworzy automatyczną gałąź zapasową
- Wymaga czystego katalogu roboczego
- Nigdy nie wysyła zmian bez Twojej komendy

**Jeśli coś pójdzie nie tak:**
```bash
# Znajdź kopię zapasową
git branch | grep backup

# Przywróć
git reset --hard your-branch-backup-[timestamp]
```

## Dostawcy AI

| Dostawca     | Koszt  | Prywatność |
|--------------|--------|------------|
| **Ollama**   | Darmowe| Lokalnie    |
| **OpenAI**   | ~0,01 USD | Chmura  |
| **Anthropic**| ~0,01 USD | Chmura  |
| **Gemini**   | ~0,01 USD | Chmura  |

## Zaawansowana konfiguracja (opcjonalne)

Chcesz dostosować ustawienia? Utwórz plik konfiguracyjny:

**Dla konkretnego projektu** (`.git-smart-squash.yml` w Twoim repozytorium):
```yaml
ai:
  provider: openai  # Użyj OpenAI dla tego projektu
base: develop       # Użyj develop jako głównej gałęzi dla tego projektu
```
**Global default** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Zawsze domyślnie używaj lokalnej AI
base: main          # Domyślna gałąź bazowa dla wszystkich projektów
```

## Rozwiązywanie problemów

### Błąd "Invalid JSON"
Zazwyczaj oznacza to, że model AI nie sformatował odpowiedzi poprawnie:
- **Z Ollama**: Przełącz z `llama2` na `mistral` lub `mixtral`
- **Rozwiązanie**: `ollama pull mistral`, a następnie spróbuj ponownie
- **Alternatywa**: Użyj dostawcy chmurowego z `--ai-provider openai`

### Model nie stosuje się do instrukcji
Niektóre modele mają trudności ze złożonymi instrukcjami:
- **Używaj lepszych modeli**: `--model gpt-4-turbo` lub `--model claude-3-opus`
- **Uprość instrukcje**: Jedno jasne polecenie działa lepiej niż kilka
- **Bądź precyzyjny**: "Dodaj przedrostek [ABC-123]", a nie "dodaj numer zgłoszenia"
### "Nie znaleziono Ollama"
```bash
# Zainstaluj z https://ollama.com
ollama serve
ollama pull devstral  # Domyślny model
```

### Słabe grupowanie commitów
Jeśli AI tworzy zbyt wiele commitów lub nie grupuje ich właściwie:
- **Niewystarczający model**: Użyj większego modelu
- **Dodaj instrukcje**: `-i "Grupuj powiązane zmiany, maksymalnie 3 commity"`
- **Przekaż opinię**: Utwórz zgłoszenie na GitHubie i poinformuj nas, co się stało

### Problemy z instalacją (Mac)
Jeśli nie masz pip lub preferujesz izolowane instalacje:
```bash
# Za pomocą pipx (zalecane)
brew install pipx
pipx install git-smart-squash
```
### "Brak zmian do reorganizacji"
```bash
git log --oneline main..HEAD  # Sprawdź, czy masz commity
git diff main                 # Sprawdź, czy masz zmiany
```

### Duże różnice / Limity tokenów
Modele lokalne mają limit około 32k tokenów. W przypadku dużych zmian:
- Użyj `--base` z nowszym commitem
- Przełącz się na chmurę: `--ai-provider openai`
- Podziel na mniejsze PR-y

### Potrzebujesz więcej pomocy?

Zobacz naszą [szczegółową dokumentację](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) lub otwórz zgłoszenie!

## Licencja

Licencja MIT - szczegóły w pliku [LICENSE](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---