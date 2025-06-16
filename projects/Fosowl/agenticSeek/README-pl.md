# AgenticSeek: Prywatna, lokalna alternatywa dla Manus

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*W pełni **lokalna alternatywa dla Manus AI** – ten asystent AI z obsługą głosu autonomicznie przegląda internet, pisze kod i planuje zadania, zachowując wszystkie dane na Twoim urządzeniu. Dostosowany do lokalnych modeli rozumowania, działa całkowicie na Twoim sprzęcie, zapewniając pełną prywatność i brak zależności od chmury.*

[![Odwiedź AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### Dlaczego AgenticSeek?

* 🔒 W pełni lokalny i prywatny – Wszystko działa na Twoim komputerze — bez chmury, bez udostępniania danych. Twoje pliki, rozmowy i wyszukiwania pozostają prywatne.

* 🌐 Inteligentne przeglądanie sieci – AgenticSeek może samodzielnie przeglądać internet — wyszukiwać, czytać, wyodrębniać informacje, wypełniać formularze — wszystko bez użycia rąk.

* 💻 Autonomiczny asystent kodowania – Potrzebujesz kodu? Może pisać, debugować i uruchamiać programy w Pythonie, C, Go, Javie i innych — wszystko bez nadzoru.

* 🧠 Inteligentny wybór agenta – Zadajesz pytanie, a on sam wybiera najlepszego agenta do zadania. Jak zespół ekspertów gotowych do pomocy.

* 📋 Planuje i realizuje złożone zadania – Od planowania podróży po skomplikowane projekty — potrafi rozbić duże zadania na kroki i wykonać je, korzystając z wielu agentów AI.

* 🎙️ Obsługa głosu – Czysty, szybki, futurystyczny głos oraz zamiana mowy na tekst pozwala rozmawiać z nim jak z własnym AI z filmu science fiction. (W trakcie opracowania)

### **Demo**

> *Czy możesz wyszukać projekt agenticSeek, dowiedzieć się, jakie są wymagane umiejętności, następnie otworzyć CV_candidates.zip i powiedzieć mi, które najlepiej pasują do projektu*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

Zastrzeżenie: To demo, w tym wszystkie pojawiające się pliki (np.: CV_candidates.zip), są całkowicie fikcyjne. Nie jesteśmy korporacją, szukamy współtwórców open-source, a nie kandydatów.

> 🛠⚠️️ **Aktywnie rozwijane**

> 🙏 Ten projekt powstał jako poboczny i nie posiada żadnej mapy drogowej ani finansowania. Rozrósł się znacznie bardziej, niż się spodziewałem, kończąc na GitHub Trending. Wszelkie wkłady, opinie i cierpliwość są bardzo cenione.

## Wymagania wstępne

Przed rozpoczęciem upewnij się, że masz zainstalowane następujące oprogramowanie:

*   **Git:** Do klonowania repozytorium. [Pobierz Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** Zdecydowanie zalecamy użycie wersji Python 3.10.x. Używanie innych wersji może prowadzić do błędów zależności. [Pobierz Python 3.10](https://www.python.org/downloads/release/python-3100/) (wybierz wersję 3.10.x).
*   **Docker Engine i Docker Compose:** Do uruchamiania usług takich jak SearxNG.
    *   Zainstaluj Docker Desktop (zawiera Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   Alternatywnie, zainstaluj Docker Engine i Docker Compose oddzielnie na Linuksie: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (upewnij się, że instalujesz Compose V2, np. `sudo apt-get install docker-compose-plugin`).

### 1. **Sklonuj repozytorium i skonfiguruj**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. Zmień zawartość pliku .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

Zaktualizuj plik `.env` własnymi wartościami, jeśli to konieczne:

- **SEARXNG_BASE_URL**: Pozostaw bez zmian
- **REDIS_BASE_URL**: Pozostaw bez zmian
- **WORK_DIR**: Ścieżka do Twojego katalogu roboczego na komputerze lokalnym. AgenticSeek będzie mógł czytać i pracować na tych plikach.
- **OLLAMA_PORT**: Numer portu dla usługi Ollama.
- **LM_STUDIO_PORT**: Numer portu dla LM Studio.
- **CUSTOM_ADDITIONAL_LLM_PORT**: Port dla dodatkowej, własnej usługi LLM.

**Klucze API są całkowicie opcjonalne dla użytkowników, którzy zdecydują się uruchamiać LLM lokalnie. Jest to główny cel tego projektu. Pozostaw puste, jeśli masz wystarczająco wydajny sprzęt**

### 3. **Uruchom Docker**

Upewnij się, że Docker jest zainstalowany i działa na Twoim systemie. Możesz uruchomić Dockera następującymi poleceniami:

- **Na Linux/macOS:**  
    Otwórz terminal i wpisz:
    ```sh
    sudo systemctl start docker
    ```
    Lub uruchom Docker Desktop z menu aplikacji, jeśli jest zainstalowany.

- **Na Windows:**  
    Uruchom Docker Desktop z menu Start.

Możesz sprawdzić, czy Docker działa, wykonując:
```sh
docker info
```
Jeśli zobaczysz informacje o instalacji Dockera, wszystko działa poprawnie.

Zobacz tabelę [Dostawcy lokalni](#list-of-local-providers) poniżej podsumowanie.

Następny krok: [Uruchom AgenticSeek lokalnie](#start-services-and-run)

*Zobacz sekcję [Rozwiązywanie problemów](#troubleshooting), jeśli masz problemy.*
*Jeśli Twój sprzęt nie pozwala na lokalne uruchomienie LLM, zobacz [Konfiguracja z API](#setup-to-run-with-an-api).*
*Szczegółowe wyjaśnienia pliku `config.ini` w sekcji [Konfiguracja](#config).*

---

## Konfiguracja do lokalnego uruchamiania LLM

**Wymagania sprzętowe:**

Aby uruchamiać LLM lokalnie, potrzebujesz odpowiedniego sprzętu. Minimalnie wymagana jest karta GPU zdolna do obsługi Magistral, Qwen lub Deepseek 14B. Szczegółowe zalecenia dotyczące modeli/wydajności znajdziesz w FAQ.

**Uruchom lokalnego dostawcę**  

Uruchom swojego lokalnego dostawcę, np. ollama:

```sh
ollama serve
```

Poniżej znajdziesz listę obsługiwanych lokalnych dostawców.

**Zaktualizuj config.ini**

Zmień plik config.ini, ustawiając provider_name na obsługiwanego dostawcę oraz provider_model na model LLM obsługiwany przez dostawcę. Zalecamy modele rozumowania takie jak *Magistral* lub *Deepseek*.

Szczegóły sprzętowe znajdziesz w **FAQ** na końcu README.

```sh
[MAIN]
is_local = True # Czy uruchamiasz lokalnie lub zdalnie.
provider_name = ollama # lub lm-studio, openai, itd.
provider_model = deepseek-r1:14b # wybierz model odpowiedni do swojego sprzętu
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # nazwa Twojej AI
recover_last_session = True # czy odzyskiwać ostatnią sesję
save_session = True # czy zapamiętywać bieżącą sesję
speak = False # zamiana tekstu na mowę
listen = False # zamiana mowy na tekst, tylko CLI, eksperymentalne
jarvis_personality = False # czy używać bardziej "Jarvisowej" osobowości (eksperymentalne)
languages = en zh # Lista języków, zamiana tekstu na mowę domyślnie w pierwszym języku z listy
[BROWSER]
headless_browser = True # pozostaw bez zmian, chyba że używasz CLI na hoście
stealth_mode = True # Użyj selenium nie do wykrycia, by zmniejszyć wykrywanie przeglądarki
```

**Uwaga**:

- Plik `config.ini` nie obsługuje komentarzy.
Nie kopiuj i nie wklejaj przykładowej konfiguracji bezpośrednio, ponieważ komentarze spowodują błędy. Zamiast tego ręcznie zmodyfikuj plik `config.ini`, wpisując wybrane ustawienia bez komentarzy.

- *NIE* ustawiaj provider_name na `openai`, jeśli korzystasz z LM-studio do lokalnych LLM. Ustaw na `lm-studio`.

- Niektórzy dostawcy (np. lm-studio) wymagają dodania `http://` przed adresem IP. Przykład: `http://127.0.0.1:1234`

**Lista lokalnych dostawców**

| Dostawca     | Lokalny? | Opis                                                                 |
|--------------|----------|----------------------------------------------------------------------|
| ollama       | Tak      | Uruchamiaj LLM lokalnie z łatwością używając ollama jako dostawcy     |
| lm-studio    | Tak      | Lokalny LLM przez LM studio (ustaw `provider_name` na `lm-studio`)    |
| openai       | Tak      | Użyj kompatybilnego API openai (np. serwer llama.cpp)                 |

Następny krok: [Uruchom usługi i AgenticSeek](#Start-services-and-Run)

*Zobacz sekcję [Rozwiązywanie problemów](#troubleshooting), jeśli masz problemy.*
*Jeśli Twój sprzęt nie pozwala na lokalne uruchomienie LLM, zobacz [Konfiguracja z API](#setup-to-run-with-an-api).*
*Szczegółowe wyjaśnienia pliku `config.ini` w sekcji [Konfiguracja](#config).*

## Konfiguracja do uruchamiania przez API

To ustawienie wykorzystuje zewnętrznych, chmurowych dostawców LLM. Potrzebujesz klucza API wybranego serwisu.

**1. Wybierz dostawcę API i uzyskaj klucz:**

Zobacz [Listę dostawców API](#list-of-api-providers) poniżej. Odwiedź ich strony, zarejestruj się i pobierz klucz API.

**2. Ustaw swój klucz API jako zmienną środowiskową:**


*   **Linux/macOS:**
    Otwórz terminal i użyj polecenia `export`. Najlepiej dodać to do pliku profilu swojej powłoki (np. `~/.bashrc`, `~/.zshrc`), aby było trwałe.
    ```sh
    export PROVIDER_API_KEY="tutaj_twój_klucz_api"
    # Zamień PROVIDER_API_KEY na konkretną zmienną, np. OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    Przykład dla TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Wiersz poleceń (Tymczasowo dla bieżącej sesji):**
    ```cmd
    set PROVIDER_API_KEY=twoj_klucz_api_tutaj
    ```
*   **PowerShell (Tymczasowo dla bieżącej sesji):**
    ```powershell
    $env:PROVIDER_API_KEY="twoj_klucz_api_tutaj"
    ```
*   **Na stałe:** Wyszukaj "zmienne środowiskowe" w pasku wyszukiwania Windows, kliknij "Edytuj zmienne środowiskowe systemu", a następnie kliknij przycisk "Zmienne środowiskowe...". Dodaj nową zmienną użytkownika z odpowiednią nazwą (np. `OPENAI_API_KEY`) i Twoim kluczem jako wartością.

*(Zobacz FAQ: [Jak ustawić klucze API?](#how-do-i-set-api-keys) po więcej szczegółów).*


**3. Zaktualizuj `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # Lub google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # Lub gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 itd.
provider_server_address = # Zazwyczaj ignorowane lub można pozostawić puste, gdy is_local = False dla większości API
# ... inne ustawienia ...
```
*Uwaga:* Upewnij się, że w wartościach `config.ini` nie ma spacji na końcu linii.

**Lista dostawców API**

| Dostawca      | `provider_name` | Lokalny? | Opis                                              | Link do klucza API (przykłady)              |
|---------------|-----------------|----------|---------------------------------------------------|---------------------------------------------|
| OpenAI        | `openai`        | Nie      | Użyj modeli ChatGPT przez API OpenAI.             | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini | `google`        | Nie      | Użyj modeli Google Gemini przez Google AI Studio. | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek      | `deepseek`      | Nie      | Użyj modeli Deepseek przez ich API.               | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face  | `huggingface`   | Nie      | Użyj modeli z Hugging Face Inference API.         | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI    | `togetherAI`    | Nie      | Użyj różnych modeli open-source przez TogetherAI. | [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*Uwaga:*
*   Odradzamy używanie `gpt-4o` lub innych modeli OpenAI do złożonego przeglądania internetu i planowania zadań, ponieważ aktualne optymalizacje promptów są skierowane pod modele takie jak Deepseek.
*   Zadania związane z kodowaniem/bash mogą napotkać problemy z Gemini, gdyż może nie przestrzegać ściśle formatowania promptów zoptymalizowanych pod Deepseek.
*   `provider_server_address` w pliku `config.ini` jest zazwyczaj nieużywane, gdy `is_local = False`, ponieważ adres API jest zwykle zapisany na stałe w odpowiedniej bibliotece dostawcy.

Następny krok: [Uruchom usługi i AgenticSeek](#Start-services-and-Run)

*Zobacz sekcję **Znane problemy** jeśli napotkasz problemy*

*Zobacz sekcję **Config** po szczegółowe wyjaśnienie pliku konfiguracyjnego.*

---

## Uruchom usługi i AgenticSeek

Domyślnie AgenticSeek uruchamiany jest w całości w dockerze.

Uruchom wymagane usługi. Rozpocznie to wszystkie usługi z pliku docker-compose.yml, w tym:
    - searxng
    - redis (wymagany przez searxng)
    - frontend
    - backend (jeśli używasz `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Windows
```

**Uwaga:** Ten krok pobierze i załaduje wszystkie obrazy Dockera, co może zająć do 30 minut. Po uruchomieniu usług poczekaj, aż usługa backend będzie w pełni uruchomiona (powinieneś zobaczyć **backend: "GET /health HTTP/1.1" 200 OK** w logu), zanim wyślesz jakiekolwiek wiadomości. Usługi backend mogą potrzebować do 5 minut na pierwsze uruchomienie.

Przejdź do `http://localhost:3000/` i powinieneś zobaczyć interfejs webowy.

*Rozwiązywanie problemów z uruchomieniem usług:* Jeśli te skrypty się nie powiodą, upewnij się, że Docker Engine jest uruchomiony oraz Docker Compose (V2, `docker compose`) jest poprawnie zainstalowany. Sprawdź komunikaty o błędach w terminalu. Zobacz [FAQ: Pomoc! Wystąpił błąd podczas uruchamiania AgenticSeek lub jego skryptów.](#faq-troubleshooting)

**Opcjonalnie:** Uruchom na hoście (tryb CLI):

Aby uruchomić w interfejsie CLI musisz zainstalować pakiet na hoście:

```sh
./install.sh
./install.bat # windows
```

Uruchom usługi:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Windows
```

Użyj CLI: `python3 cli.py`


---

## Użytkowanie

Upewnij się, że usługi są uruchomione poprzez `./start_services.sh full` i przejdź do `localhost:3000` aby uzyskać dostęp do interfejsu webowego.

Możesz także użyć funkcji rozpoznawania mowy ustawiając `listen = True` w konfiguracji. Tylko w trybie CLI.

Aby zakończyć, po prostu powiedz/napisz `goodbye`.

Oto przykłady użycia:

> *Stwórz grę w węża w pythonie!*

> *Wyszukaj w internecie najlepsze kawiarnie w Rennes, Francja, i zapisz listę trzech z ich adresami w pliku rennes_cafes.txt.*

> *Napisz program w Go obliczający silnię liczby, zapisz go jako factorial.go w swoim katalogu roboczym*

> *Wyszukaj w folderze summer_pictures wszystkie pliki JPG, zmień ich nazwy na dzisiejszą datę i zapisz listę zmienionych plików w photos_list.txt*

> *Wyszukaj online popularne filmy sci-fi z 2024 i wybierz trzy do obejrzenia dziś wieczorem. Zapisz listę w movie_night.txt.*

> *Wyszukaj w internecie najnowsze artykuły o AI z 2025, wybierz trzy, i napisz skrypt w Pythonie, który pobierze ich tytuły i podsumowania. Zapisz skrypt jako news_scraper.py, a podsumowania w ai_news.txt w /home/projects*

> *W piątek wyszukaj w internecie darmowe API do notowań giełdowych, zarejestruj się jako supersuper7434567@gmail.com, potem napisz skrypt w Pythonie pobierający dzienne ceny Tesli i zapisz wyniki w stock_prices.csv*

*Zwróć uwagę, że możliwości wypełniania formularzy są nadal eksperymentalne i mogą nie działać poprawnie.*



Po wpisaniu zapytania AgenticSeek przydzieli najlepszego agenta do zadania.

Ponieważ to wczesny prototyp, system routingu agentów może nie zawsze przydzielić właściwego agenta na podstawie zapytania.

Dlatego powinieneś być bardzo precyzyjny w tym, czego oczekujesz i jak AI ma postępować — np. jeśli chcesz, by wyszukał informacje w internecie, nie pisz:

`Czy znasz jakieś dobre kraje na podróż solo?`

Zamiast tego, zapytaj:

`Wyszukaj w internecie i dowiedz się, które kraje są najlepsze do podróżowania solo`

---

## **Konfiguracja uruchomienia LLM na własnym serwerze**

Jeśli masz wydajny komputer lub serwer, z którego możesz korzystać, ale chcesz używać go z laptopa, masz możliwość uruchomienia LLM na zdalnym serwerze za pomocą naszego własnego serwera llm.

Na swoim "serwerze", który będzie uruchamiał model AI, pobierz adres IP

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # lokalny IP
curl https://ipinfo.io/ip # publiczny IP
```

Uwaga: Dla Windows lub macOS użyj odpowiednio ipconfig lub ifconfig, aby znaleźć adres IP.

Sklonuj repozytorium i wejdź do folderu `server/`.


```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

Zainstaluj wymagania serwera:

```sh
pip3 install -r requirements.txt
```

Uruchom skrypt serwera.

```sh
python3 app.py --provider ollama --port 3333
```

Masz wybór pomiędzy `ollama` i `llamacpp` jako usługą LLM.


Teraz na swoim komputerze osobistym:

Zmień plik `config.ini`, ustawiając `provider_name` na `server` oraz `provider_model` na `deepseek-r1:xxb`.
Ustaw `provider_server_address` na adres IP maszyny, która będzie uruchamiała model.

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


Następny krok: [Uruchom usługi i AgenticSeek](#Start-services-and-Run)  

---

## Rozpoznawanie mowy (Speech to Text)

Uwaga: rozpoznawanie mowy działa obecnie tylko w trybie CLI.

Pamiętaj, że obecnie rozpoznawanie mowy działa tylko w języku angielskim.

Funkcjonalność rozpoznawania mowy jest domyślnie wyłączona. Aby ją włączyć, ustaw opcję listen na True w pliku config.ini:

```
listen = True
```

Po włączeniu, funkcja rozpoznawania mowy czeka na słowo kluczowe (nazwę agenta), zanim zacznie przetwarzać Twoje polecenie. Możesz dostosować nazwę agenta, aktualizując wartość `agent_name` w pliku *config.ini*:

```
agent_name = Friday
```

Dla optymalnego rozpoznawania zalecamy użycie popularnego angielskiego imienia, takiego jak "John" lub "Emma" jako nazwy agenta

Gdy zobaczysz, że transkrypcja zaczyna się pojawiać, wypowiedz głośno imię agenta, aby go obudzić (np. "Friday").

Wypowiedz swoje zapytanie wyraźnie.

Zakończ swoją prośbę frazą potwierdzającą, aby zasygnalizować systemowi, że ma przejść dalej. Przykłady fraz potwierdzających to:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Konfiguracja

Przykładowa konfiguracja:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Przykład dla Ollama; użyj http://127.0.0.1:1234 dla LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # Lista języków dla TTS i potencjalnie routingu.
[BROWSER]
headless_browser = False
stealth_mode = False
```

**Wyjaśnienie ustawień `config.ini`**:

*   **Sekcja `[MAIN]`:**
    *   `is_local`: `True` jeśli korzystasz z lokalnego dostawcy LLM (Ollama, LM-Studio, lokalny serwer zgodny z OpenAI) lub opcji serwera self-hosted. `False` jeśli używasz API w chmurze (OpenAI, Google, itd.).
    *   `provider_name`: Określa dostawcę LLM.
        *   Opcje lokalne: `ollama`, `lm-studio`, `openai` (dla lokalnych serwerów zgodnych z OpenAI), `server` (dla własnego serwera self-hosted).
        *   Opcje API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`.
    *   `provider_model`: Konkretna nazwa lub ID modelu dla wybranego dostawcy (np. `deepseekcoder:6.7b` dla Ollama, `gpt-3.5-turbo` dla OpenAI API, `mistralai/Mixtral-8x7B-Instruct-v0.1` dla TogetherAI).
    *   `provider_server_address`: Adres twojego dostawcy LLM.
        *   Dla dostawców lokalnych: np. `http://127.0.0.1:11434` dla Ollama, `http://127.0.0.1:1234` dla LM-Studio.
        *   Dla typu `server`: Adres twojego własnego serwera LLM (np. `http://your_server_ip:3333`).
        *   Dla API w chmurze (`is_local = False`): Zazwyczaj ignorowane lub można zostawić puste, ponieważ endpoint API jest zazwyczaj obsługiwany przez bibliotekę kliencką.
    *   `agent_name`: Nazwa asystenta AI (np. Friday). Używana jako słowo wybudzające dla rozpoznawania mowy, jeśli jest włączone.
    *   `recover_last_session`: `True` aby przywrócić stan poprzedniej sesji, `False` aby rozpocząć od nowa.
    *   `save_session`: `True` aby zapisać stan bieżącej sesji do ewentualnego przywrócenia, `False` w przeciwnym wypadku.
    *   `speak`: `True` aby włączyć syntezę mowy (TTS), `False` aby wyłączyć.
    *   `listen`: `True` aby włączyć rozpoznawanie mowy (STT) w trybie CLI, `False` aby wyłączyć.
    *   `work_dir`: **Istotne:** Katalog, w którym AgenticSeek będzie czytać/zapisywać pliki. **Upewnij się, że ta ścieżka jest poprawna i dostępna na twoim systemie.**
    *   `jarvis_personality`: `True` aby użyć bardziej "Jarvisowego" prompta systemowego (eksperymentalne), `False` dla standardowego prompta.
    *   `languages`: Lista języków rozdzielona przecinkami (np. `en, zh, fr`). Używana do wyboru głosu TTS (domyślnie pierwszy) i może pomagać routerowi LLM. Unikaj zbyt wielu lub bardzo podobnych języków dla efektywności routera.
*   **Sekcja `[BROWSER]`:**
    *   `headless_browser`: `True` aby uruchomić zautomatyzowaną przeglądarkę bez widocznego okna (zalecane do interfejsu webowego lub użytku nieinteraktywnego). `False` aby pokazać okno przeglądarki (przydatne w trybie CLI lub debugowaniu).
    *   `stealth_mode`: `True` aby włączyć środki utrudniające wykrycie automatyzacji przeglądarki. Może wymagać ręcznej instalacji rozszerzeń, takich jak anticaptcha.

Ta sekcja podsumowuje obsługiwane typy dostawców LLM. Skonfiguruj je w `config.ini`.

**Dostawcy lokalni (uruchamiani na twoim sprzęcie):**

| Nazwa dostawcy w `config.ini` | `is_local` | Opis                                                                       | Sekcja konfiguracji                                                 |
|-------------------------------|------------|----------------------------------------------------------------------------|---------------------------------------------------------------------|
| `ollama`                      | `True`     | Użyj Ollama do serwowania lokalnych LLM.                                   | [Konfiguracja lokalnego LLM](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | Użyj LM-Studio do serwowania lokalnych LLM.                                | [Konfiguracja lokalnego LLM](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (dla lokalnego serwera) | `True` | Połącz z lokalnym serwerem udostępniającym API zgodne z OpenAI (np. llama.cpp). | [Konfiguracja lokalnego LLM](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | Połącz z własnym serwerem LLM AgenticSeek uruchomionym na innej maszynie.  | [Konfiguracja własnego serwera LLM](#setup-to-run-the-llm-on-your-own-server) |

**Dostawcy API (chmurowi):**

| Nazwa dostawcy w `config.ini` | `is_local` | Opis                                            | Sekcja konfiguracji                                    |
|-------------------------------|------------|--------------------------------------------------|--------------------------------------------------------|
| `openai`                      | `False`    | Użyj oficjalnego API OpenAI (np. GPT-3.5, GPT-4).| [Konfiguracja z API](#setup-to-run-with-an-api)         |
| `google`                      | `False`    | Użyj modeli Gemini Google przez API.             | [Konfiguracja z API](#setup-to-run-with-an-api)         |
| `deepseek`                    | `False`    | Użyj oficjalnego API Deepseek.                   | [Konfiguracja z API](#setup-to-run-with-an-api)         |
| `huggingface`                 | `False`    | Użyj Hugging Face Inference API.                 | [Konfiguracja z API](#setup-to-run-with-an-api)         |
| `togetherAI`                  | `False`    | Użyj API TogetherAI dla różnych modeli open.     | [Konfiguracja z API](#setup-to-run-with-an-api)         |

---
## Rozwiązywanie problemów

Jeśli napotkasz problemy, ta sekcja zawiera wskazówki.

# Znane problemy

## Problemy z ChromeDriver

**Przykład błędu:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **Przyczyna:** Zainstalowana wersja ChromeDriver jest niezgodna z wersją przeglądarki Google Chrome.
*   **Rozwiązanie:**
    1.  **Sprawdź wersję Chrome:** Otwórz Google Chrome, przejdź do `Ustawienia > O Google Chrome`, aby znaleźć wersję (np. "Wersja 120.0.6099.110").
    2.  **Pobierz pasującą wersję ChromeDriver:**
        *   Dla Chrome w wersji 115 i nowszych: Przejdź do [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/). Znajdź kanał "stable" i pobierz ChromeDriver dla swojego systemu operacyjnego, zgodny z główną wersją przeglądarki Chrome.
        *   Dla starszych wersji (rzadziej spotykane): Możesz je znaleźć na stronie [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads).
        *   Poniższy obrazek przedstawia przykład ze strony CfT:
            ![Download Chromedriver specific version from Chrome for Testing page](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **Zainstaluj ChromeDriver:**
        *   Upewnij się, że pobrany plik `chromedriver` (lub `chromedriver.exe` w Windows) znajduje się w katalogu, który jest na liście PATH w systemie (np. `/usr/local/bin` w Linux/macOS lub własny folder skryptów dodany do PATH w Windows).
        *   Alternatywnie umieść go w katalogu głównym projektu `agenticSeek`.
        *   Upewnij się, że sterownik ma prawa wykonywania (np. `chmod +x chromedriver` w Linux/macOS).
    4.  Zajrzyj do sekcji [ChromeDriver Installation](#chromedriver-installation) w głównym przewodniku instalacji po więcej szczegółów.

Jeśli ta sekcja jest niepełna lub napotkasz inne problemy z ChromeDriver, rozważ sprawdzenie istniejących [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) lub zgłoszenie nowego problemu.

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

To dzieje się, jeśli wersje przeglądarki i chromedrivera się nie zgadzają.

Musisz przejść do pobrania najnowszej wersji:

https://developer.chrome.com/docs/chromedriver/downloads

Jeśli używasz Chrome w wersji 115 lub nowszej przejdź do:

https://googlechromelabs.github.io/chrome-for-testing/

I pobierz wersję chromedrivera odpowiednią dla twojego systemu operacyjnego.

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

Jeśli ta sekcja jest niepełna, zgłoś problem.

## Problemy z connection adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Uwaga: port może być inny)
```

*   **Przyczyna:** `provider_server_address` w `config.ini` dla `lm-studio` (lub innych podobnych lokalnych serwerów zgodnych z OpenAI) nie zawiera prefiksu `http://` lub wskazuje zły port.
*   **Rozwiązanie:**
    *   Upewnij się, że adres zawiera `http://`. LM-Studio domyślnie to `http://127.0.0.1:1234`.
    *   Popraw `config.ini`: `provider_server_address = http://127.0.0.1:1234` (lub twój faktyczny port serwera LM-Studio).

## Nie podano podstawowego adresu URL SearxNG

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**Q: Jakiego sprzętu potrzebuję?**  

| Rozmiar modelu | GPU  | Komentarz                                                   |
|----------------|------|------------------------------------------------------------|
| 7B             | 8GB Vram | ⚠️ Niezalecane. Słaba wydajność, częste halucynacje, agenci planujący prawdopodobnie zawiodą. |
| 14B            | 12 GB VRAM (np. RTX 3060) | ✅ Używalny do prostych zadań. Może mieć trudności z przeglądaniem sieci i zadaniami planistycznymi. |
| 32B            | 24+ GB VRAM (np. RTX 4090) | 🚀 Sukces w większości zadań, nadal może mieć trudności z planowaniem zadań |
| 70B+           | 48+ GB Vram | 💪 Doskonały. Zalecany do zaawansowanych zastosowań.      |

**Q: Otrzymuję błąd, co mam zrobić?**  

Upewnij się, że lokalny serwer działa (`ollama serve`), twoje `config.ini` pasuje do wybranego dostawcy, a zależności są zainstalowane. Jeśli żadne nie działa, śmiało zgłoś problem.

**Q: Czy to naprawdę może działać w 100% lokalnie?**  

Tak, z dostawcami Ollama, lm-studio lub server wszystkie modele STT, LLM i TTS działają lokalnie. Opcje nielokalne (OpenAI lub inne API) są opcjonalne.

**Q: Dlaczego mam używać AgenticSeek, skoro mam Manus?**

W przeciwieństwie do Manus, AgenticSeek stawia na niezależność od zewnętrznych systemów, dając ci większą kontrolę, prywatność i brak kosztów API.

**Q: Kto stoi za projektem?**

Projekt został stworzony przeze mnie, wraz z dwoma przyjaciółmi, którzy są maintainerami i kontrybutorami z open-source na GitHubie. Jesteśmy po prostu grupą pasjonatów, a nie startupem ani organizacją.

Każde konto AgenticSeek na X poza moim osobistym kontem (https://x.com/Martin993886460) jest podszywaniem się.

## Współtwórz

Szukamy developerów do rozwoju AgenticSeek! Zajrzyj do otwartych zgłoszeń lub dyskusji.

[Przewodnik kontrybucji](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## Maintainerzy:

 > [Fosowl](https://github.com/Fosowl) | czas paryski 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | czas tajpejski 

 > [steveh8758](https://github.com/steveh8758) | czas tajpejski 

## Specjalne podziękowania:

 > [tcsenpai](https://github.com/tcsenpai) oraz [plitc](https://github.com/plitc) za pomoc w dockerowaniu backendu

## Sponsorzy:

Sponsorzy z miesięczną wpłatą 5$ lub więcej pojawią się tutaj:
- **tatra-labs**
It seems you haven't provided the text of the technical document that needs to be translated. Please provide the content you'd like translated (Part 4 of 4), and I'll proceed with the translation while preserving the original Markdown format and updating the relative paths as requested.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---