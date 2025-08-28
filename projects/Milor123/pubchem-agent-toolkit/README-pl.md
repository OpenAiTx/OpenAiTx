
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# Ulepszony serwer PubChem MCP dla asystentów AI

🧪 Zaawansowany, niezawodny i skoncentrowany na prywatności serwer MCP, umożliwiający asystentom AI inteligentne wyszukiwanie i dostęp do informacji o związkach chemicznych z PubChem.

Ten serwer PubChem MCP działa jako potężne łącze między asystentami AI (takimi jak w AnythingLLM) a ogromną bazą danych chemicznych PubChem. Wykorzystuje Model Context Protocol (MCP), aby umożliwić modelom AI inteligentne, odporne wyszukiwania związków chemicznych i programowe pobieranie ich szczegółowych właściwości.

---

## ✨ Kluczowe funkcje

To nie jest kolejna zwykła nakładka na PubChem. Serwer został zbudowany od podstaw, aby być wyjątkowo niezawodny i inteligentny:

-   **🧠 Inteligentne wyszukiwanie awaryjne**: Jeśli wyszukiwanie popularnej nazwy (np. "Witamina D") się nie powiedzie, serwer automatycznie przeprowadza głębsze wyszukiwanie w bazie PubChem Substance, by znaleźć właściwy związek. Znacząco zwiększa to skuteczność dla niejednoznacznych zapytań.
-   **🛡️ Solidna obsługa błędów i ponownych prób**: Serwer jest zaprojektowany do łagodnego radzenia sobie z błędami API. Jeśli napotka błąd "Server Busy" z PubChem, automatycznie poczeka i ponowi zapytanie, dzięki czemu Twoje zapytania zakończą się sukcesem nawet przy dużym obciążeniu.
-   **🔒 Opcjonalna obsługa proxy Tor**: Masz pełną kontrolę nad swoją prywatnością. Prosty plik `config.ini` pozwala na kierowanie wszystkich zapytań przez sieć Tor (przez proxy SOCKS5 lub HTTP), zapobiegając ujawnieniu Twojego adresu IP. Serwer jest domyślnie bezpieczny i **nigdy** nie ujawni Twojego IP, jeśli połączenie proxy się nie powiedzie.
-   **🔎 Wyszukiwanie pojedynczych i wielu związków**: Bezproblemowo obsługuje zapytania dotyczące jednego lub wielu związków w jednej wiadomości.
-   **🧪 Szczegółowe pobieranie właściwości**: Dostęp do kluczowych właściwości chemicznych, takich jak nazwa IUPAC, wzór cząsteczkowy, masa cząsteczkowa oraz, co najważniejsze, **masa monoisotopowa**.

---

---

### 🚀 Bez instalacji: wypróbuj na żywo w Smithery.ai

Dla osób, które są nowe w serwerach MCP lub chcą po prostu przetestować możliwości tego narzędzia bez lokalnej instalacji, dostępna jest wersja na żywo, hostowana na Smithery.ai. Umożliwia ona rozmowę z agentem bezpośrednio w przeglądarce.

[**<-- Przetestuj agenta PubChem na żywo w Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**Jak zacząć:**

1.  Kliknij powyższy link, aby przejść do strony serwera.
2.  Zaloguj się za pomocą konta **GitHub** lub **Google**.
3.  Kliknij przycisk **"Explore capabilities"**, aby otworzyć interfejs czatu i rozpocząć testowanie!

> **✅ Zalecane modele dla najlepszych wyników**
>
> Aby uzyskać najwyższą dokładność, szczególnie przy długich liczbach dziesiętnych, zdecydowanie zalecamy korzystanie z mocnych modeli. Następujące zostały przetestowane i działają doskonale z tym narzędziem:
>
> *   **Claude 3 Sonnet od Anthropic**
> *   **OpenAI GPT-4 Turbo** (lub nowsze wersje jak GPT-4o)
>
> Potwierdziliśmy, że oba modele prawidłowo przetwarzały pełną precyzję liczb dziesiętnych zwracanych przez narzędzie bez zaokrągleń.

---

## 🚀 Szybki start i instalacja

Ten serwer jest przeznaczony do uruchamiania lokalnie, na Twoim komputerze lub w środowisku Docker AnythingLLM.

### 1. Wymagane zależności

Ten projekt wymaga kilku bibliotek Pythona. Upewnij się, że są zainstalowane w Twoim środowisku.

Utwórz plik `requirements.txt` z następującą zawartością:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```

Zainstaluj je za pomocą `uv` lub `pip`:
```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(Uwaga: `PySocks` jest wymagany tylko jeśli planujesz używać funkcji proxy Tor SOCKS5.)*

### 2. Konfiguracja

Serwer jest konfigurowany za pomocą pliku `config.ini`, który jest **automatycznie tworzony** przy pierwszym uruchomieniu. Plik ten pojawi się w tym samym katalogu co skrypt `pubchem_server.py`.

**Domyślny `config.ini`:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. Integracja z AnythingLLM

Postępuj zgodnie z oficjalną dokumentacją, aby dodać to jako niestandardowy serwer MCP. Kluczowe jest wskazanie `command` na swój plik wykonywalny Pythona oraz skrypt `pubchem_server.py`.

**Przykład dla AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```


### 3.1 Przykłady implementacji z AnythingLLM

Oto kilka przykładów, jak można współpracować z agentem. Testy te zostały przeprowadzone przy użyciu AnythingLLM Desktop, łącząc się z różnymi dużymi modelami językowymi przez OpenRouter.

Kluczowym wnioskiem z naszych testów jest znaczenie wyboru modelu. **Zdecydowanie odradzamy używanie małych lub lokalnych modeli** do tego zadania. Mniejsze modele często mają trudności z poprawnym przetwarzaniem danych zwracanych przez narzędzie, co prowadzi do błędów takich jak halucynowane wartości, nieprawidłowe formatowanie, lub - co najważniejsze - **zaokrąglanie liczb dziesiętnych**, co niweczy cel tego narzędzia wysokiej precyzji.

Aby zapewnić integralność wyników, zawsze warto zweryfikować surowe dane zwracane przez MCP. Jak to zrobić, dowiesz się w następnej sekcji: [3.2 Jak zweryfikować wyniki MCP w logach](#32-jak-zweryfikowac-wyniki-mcp-w-logach).

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

Z drugiej strony, kilka modeli wykazało doskonałą wydajność. Osiągnęliśmy znakomite rezultaty z **Google `Gemini 2.5 Flash lite`**. wykazał się niezwykłą precyzją w obsłudze długich liczb dziesiętnych i poprawnym formatowaniu końcowej tabeli Markdown.

Google gemini 2.5 flash lite bez prompta i z promptem zachowuje idealne wartości dziesiętne (w przykładzie użyto temperatury 0.6)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

Do tego konkretnego zadania moim osobistym faworytem jest **`Gemini 2.5 Flash lite`** ze względu na jego konsekwentną precyzję i niezawodność.

### 3.2 Jak zweryfikować wyniki MCP w logach

Najlepszym sposobem potwierdzenia, że agent otrzymuje poprawne dane i LLM nie popełnia błędów, jest sprawdzenie pliku dziennika debugowania generowanego przez serwer MCP.

Ten serwer jest skonfigurowany do automatycznego tworzenia pliku logu w podfolderze w katalogu Twojego projektu. Lokalizacja będzie:

```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

W pliku `mcp_debug.log` znajdziesz dokładne dane JSON, które narzędzie przesyła do LLM *przed* przetworzeniem przez model. Możesz ręcznie sprawdzić ten JSON, aby zweryfikować dowolne wartości, szczególnie długie liczby dziesiętne z właściwości takich jak `monoisotopic_mass`, upewniając się, że LLM nie wprowadził żadnych błędów zaokrągleń ani halucynacji w swojej ostatecznej odpowiedzi.

---

## 📊 Użytkowanie

Po integracji Twój asystent AI automatycznie użyje tego narzędzia podczas zapytań o informacje chemiczne. Głównym udostępnionym narzędziem jest `search_compounds_by_name`.

### Przykładowa komenda

Ten przykład pokazuje możliwości narzędzia w obsłudze listy związków o różnych typach nazw i pobieraniu wielu właściwości.

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```

Agent wywoła narzędzie `search_compounds_by_name`, które inteligentnie odnajdzie każdy związek, pobierze jego dane i zwróci je do LLM w celu sformatowania.

---

## 🛠 Udostępnione narzędzie MCP

### `search_compounds_by_name`

Wyszukuje wiele związków po nazwie, jeden po drugim, stosując inteligentną strategię rezerwową z pauzami i ponownymi próbami dla maksymalnej niezawodności.

**Parametry:**
-   `names` (List[str]): Lista nazw związków. Przykład: `["Aspirin", "Ibuprofen"]`

**Zwraca:** Listę słowników, z których każdy zawiera informacje o znalezionym związku lub komunikat o błędzie wyjaśniający, dlaczego wyszukiwanie nie powiodło się dla danego związku.

---

## 🙏 Podziękowania

Ten projekt został mocno zainspirowany i zbudowany na bazie oryginalnego [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) stworzonego przez **JackKuo666**.

Chociaż to repozytorium nie jest bezpośrednim forkiem, oryginalny projekt był kluczowym punktem wyjścia. Ta wersja rozszerza pierwotną koncepcję, koncentrując się na ekstremalnej odporności, inteligentnych strategiach wyszukiwania oraz prywatności użytkownika dzięki opcjonalnej integracji z Tor 🧅.

Serdeczne podziękowania dla oryginalnego autora za fantastyczną pracę i jej udostępnienie społeczności.

---

## ⚠️ Zastrzeżenie

Narzędzie przeznaczone jest do celów badawczych i edukacyjnych. Prosimy o przestrzeganie warunków korzystania z PubChem i odpowiedzialne używanie tego narzędzia.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---