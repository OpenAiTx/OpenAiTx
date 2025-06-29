![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Zamień dowolne repozytorium GitHub w gotowy do produkcji kontener Docker dzięki generowaniu Dockerfile wspieranemu przez AI.**

[![Licencja MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer to aplikacja webowa wykorzystująca AI, która automatycznie generuje gotowe do produkcji pliki Dockerfile poprzez analizę repozytoriów GitHub. Wystarczy wkleić adres URL repozytorium GitHub, aby otrzymać dopasowany Dockerfile z inteligentnym doborem obrazu bazowego, zarządzaniem zależnościami i najlepszymi praktykami Dockera.

## 🌟 Szybki dostęp

Wystarczy zamienić `github.com` na `gitcontainer.com` w dowolnym adresie repozytorium GitHub, aby natychmiast przejść do strony generowania Dockerfile dla tego repozytorium.

Na przykład:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Funkcje

- **🔄 Natychmiastowy dostęp przez URL**: Wystarczy zamienić 'github.com' na 'gitcontainer.com' w dowolnym adresie GitHub
- **🤖 Analiza wspierana przez AI**: Wykorzystuje OpenAI GPT-4 do analizy struktury repozytorium i generowania inteligentnych Dockerfile
- **⚡ Strumieniowanie w czasie rzeczywistym**: Obserwuj generowanie Dockerfile przez AI na żywo dzięki WebSocket streaming
- **🎯 Inteligentne wykrywanie**: Automatycznie wykrywa stos technologiczny (Python, Node.js, Java, Go itd.)
- **🔧 Gotowość produkcyjna**: Generuje Dockerfile zgodne z najlepszymi praktykami, z odpowiednim bezpieczeństwem, wieloetapowymi buildami i optymalizacją
- **📋 Dodatkowe instrukcje**: Dodaj własne wymagania dla specjalistycznych środowisk
- **📄 Docker Compose**: Automatycznie sugeruje docker-compose.yml dla złożonych aplikacji
- **🎨 Nowoczesny interfejs**: Czysty, responsywny interfejs z edytorem Monaco i podświetlaniem składni
- **📱 Przyjazny mobilnie**: Działa płynnie na komputerach i urządzeniach mobilnych

## 🚀 Szybki start

### Wymagania wstępne

- Python 3.9 lub wyższy
- Git
- Klucz API OpenAI

### Instalacja

1. **Sklonuj repozytorium:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Zainstaluj zależności:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Skonfiguruj zmienne środowiskowe:**
   ```bash
   # Utwórz plik .env
   echo "OPENAI_API_KEY=twoj_klucz_api_openai" > .env
   ```

4. **Uruchom aplikację:**
   ```bash
   python app.py
   ```

5. **Otwórz przeglądarkę:**
   Przejdź do `http://localhost:8000`

## 🛠️ Jak to działa

1. **Przetwarzanie URL**: Uzyskaj dostęp do dowolnego repozytorium poprzez zamianę 'github.com' na 'gitcontainer.com' w adresie URL
2. **Klonowanie repozytorium**: Gitcontainer klonuje lokalnie wybrane repozytorium GitHub za pomocą Gita
3. **Analiza kodu**: Wykorzystuje [gitingest](https://github.com/cyclotruc/gitingest) do analizy struktury repozytorium i wyodrębniania istotnych informacji
4. **Generowanie przez AI**: Wysyła analizę do OpenAI GPT-4 ze specjalistycznymi promptami do generowania Dockerfile
5. **Inteligentna optymalizacja**: AI uwzględnia:
   - Wykrywanie stosu technologicznego
   - Zarządzanie zależnościami
   - Najlepsze praktyki bezpieczeństwa
   - Wieloetapowe buildy, gdy są korzystne
   - Konfigurację portów
   - Zmienne środowiskowe
   - Health checki

## 📁 Struktura projektu

```
cyclotruc-gitcontainer/
├── app.py                 # Główna aplikacja FastAPI
├── requirements.txt       # Zależności Pythona
├── .env                  # Zmienne środowiskowe (utwórz ten plik)
├── static/               # Zasoby statyczne (ikony, CSS)
├── templates/
│   └── index.jinja       # Główny szablon HTML
└── tools/                # Moduły funkcjonalności
    ├── __init__.py
    ├── create_container.py  # Generowanie Dockerfile przez AI
    ├── git_operations.py    # Klonowanie repozytorium GitHub
    └── gitingest.py        # Analiza repozytorium
```

## 🔧 Konfiguracja

### Zmienne środowiskowe

| Zmienna | Opis | Wymagane |
|---------|------|----------|
| `OPENAI_API_KEY` | Twój klucz API OpenAI | Tak |
| `PORT` | Port serwera (domyślnie: 8000) | Nie |
| `HOST` | Host serwera (domyślnie: 0.0.0.0) | Nie |

### Zaawansowane użycie

Możesz używać narzędzi programistycznie:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Klonowanie repozytorium
    clone_result = await clone_repo_tool(github_url)
    
    # Analiza za pomocą gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Generowanie Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Użycie
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Personalizacja

### Dodawanie własnych instrukcji

Użyj funkcji "Dodatkowe instrukcje", aby dostosować generowanie:

- `"Użyj Alpine Linux dla mniejszego rozmiaru obrazu"`
- `"Dodaj Redis i PostgreSQL"`
- `"Optymalizuj pod kątem wdrożenia produkcyjnego"`
- `"Dodaj narzędzia developerskie do debugowania"`

## 📝 Licencja

Projekt jest udostępniony na licencji MIT – szczegóły w pliku [LICENSE](LICENSE).

## 🙏 Podziękowania

- **[OpenAI](https://openai.com/)** za udostępnienie API GPT-4
- **[gitingest](https://github.com/cyclotruc/gitingest)** za możliwości analizy repozytorium
- **[FastAPI](https://fastapi.tiangolo.com/)** za doskonały framework webowy
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** za podświetlanie składni kodu

## 🔗 Linki

- **Repozytorium GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**: Wypróbuj na żywo z przykładowymi repozytoriami
- **Zgłoszenia**: [Zgłoś błędy lub zaproponuj funkcje](https://github.com/cyclotruc/gitcontainer/issues)

---

**Stworzone z ❤️ przez [Romain Courtois](https://github.com/cyclotruc)**

*Zamień dowolne repozytorium w kontener w kilka sekund!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---