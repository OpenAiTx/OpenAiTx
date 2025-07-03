# Tome - Magiczna Księga Zaklęć AI

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>magiczna aplikacja desktopowa, która oddaje moc LLM i MCP w ręce każdego</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Dołącz do nas na Discordzie" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="Licencja: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="Wydanie GitHub" /></a>
</p>

<p align="center">
    🔮 Pobierz aplikację Tome Desktop: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome to aplikacja desktopowa, która pozwala **każdemu** korzystać z magii LLM i MCP. Pobierz Tome, połącz dowolny lokalny lub zdalny LLM i podłącz go do tysięcy serwerów MCP, aby stworzyć własną magiczną księgę zaklęć zasilaną przez AI.

🫥 Chcesz, aby wszystko działało w 100% lokalnie i w 100% prywatnie? Użyj Ollama i Qwen3 wyłącznie z lokalnymi serwerami MCP, aby rzucać zaklęcia w swoim własnym kieszonkowym uniwersum. ⚡ Chcesz korzystać z najnowocześniejszych modeli w chmurze z najnowszymi zdalnymi serwerami MCP? Też możesz to mieć. Wybór należy do Ciebie!

🏗️ To jest Wersja Techniczna Preview, więc miej na uwadze, że nie wszystko jest jeszcze dopracowane. [Dołącz do nas na Discordzie](https://discord.gg/9CH6us29YA), aby dzielić się wskazówkami, trikami i zgłaszać napotkane problemy. Oznacz repozytorium gwiazdką, aby być na bieżąco z aktualizacjami i nowościami!

## 🪄 Funkcje

- 🧙 **Uproszczone, przyjazne dla początkujących doświadczenie**
  - Po prostu pobierz i zainstaluj Tome oraz podłącz wybrany przez siebie LLM
  - Bez grzebania w JSON, Dockerze, pythonie czy node
- 🤖 **Wsparcie dla modeli AI**
  - **Zdalne**: Google Gemini, OpenAI, dowolny endpoint kompatybilny z API OpenAI
  - **Lokalne**: Ollama, LM Studio, Cortex, dowolny endpoint kompatybilny z API OpenAI
- 🔮 **Zaawansowane wsparcie MCP**
  - Interfejs do instalowania, usuwania, włączania/wyłączania serwerów MCP
  - Serwery MCP npm, uvx, node, python obsługiwane od razu po instalacji
- 🏪 **Integracja z rejestrem [Smithery.ai](https://smithery.ai)**
  - Tysiące serwerów MCP dostępnych poprzez instalację jednym kliknięciem
- ✏️ **Dostosowanie okien kontekstowych i temperatury**
- 🧰 **Nattywne wsparcie dla wywołań narzędzi i modeli rozumowania**
  - Ulepszenia UI, które wyraźnie rozróżniają wywołania narzędzi i komunikaty myślowe

## Demo

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# Pierwsze Kroki

## Wymagania

- MacOS lub Windows (Linux już wkrótce!)
- Dostawca LLM według wyboru: [Ollama](https://ollama.com/) lub [klucz API Gemini](https://aistudio.google.com/app/apikey) są łatwe/darmowe
- [Pobierz najnowszą wersję Tome](https://github.com/runebookai/tome/releases)

## Szybki start

1. Zainstaluj [Tome](https://github.com/runebookai/tome/releases)
2. Podłącz preferowanego dostawcę LLM - OpenAI, Ollama i Gemini są ustawione domyślnie, ale możesz też dodać dostawców takich jak LM Studio, używając URL http://localhost:1234/v1
3. Otwórz zakładkę MCP w Tome i zainstaluj swój pierwszy [serwer MCP](https://github.com/modelcontextprotocol/servers) (Fetch to prosty na początek, po prostu wklej `uvx mcp-server-fetch` w polu serwera).
4. Rozmawiaj z modelem zasilanym MCP! Poproś go o pobranie najnowszej wiadomości z Hacker News.

# Wizja

Chcemy, aby lokalne LLM i MCP były dostępne dla każdego. Budujemy narzędzie, które pozwoli Ci być kreatywnym z LLM, niezależnie od tego, czy jesteś inżynierem, majsterkowiczem, hobbystą czy kimkolwiek pomiędzy.

## Kluczowe zasady

- **Tome jest w pierwszej kolejności lokalny:** Ty decydujesz, gdzie trafiają Twoje dane.
- **Tome jest dla wszystkich:** Nie musisz zarządzać językami programowania, menedżerami pakietów ani plikami konfiguracyjnymi json.

## Co dalej

Otrzymaliśmy mnóstwo niesamowitych opinii od czasu wydania Tome, ale mamy wielkie plany na przyszłość. Chcemy uwolnić LLM-y z ich okna czatu i mamy w planach wiele funkcji, które pomogą Wam to osiągnąć.

- Zadania zaplanowane: LLM-y powinny robić pomocne rzeczy nawet, gdy nie siedzisz przy komputerze.
- Natywne integracje: Serwery MCP to świetny sposób na dostęp do narzędzi i informacji, ale chcemy dodać jeszcze potężniejsze integracje do unikalnej interakcji z LLM.
- Kreator aplikacji: Wierzymy, że docelowo najlepsze doświadczenia nie będą w interfejsie czatu. Planujemy dodać dodatkowe narzędzia, które pozwolą Ci tworzyć zaawansowane aplikacje i przepływy pracy.
- ??? Daj nam znać, co chciałbyś zobaczyć! Dołącz do naszej społeczności przez linki poniżej, chętnie poznamy Twoją opinię.

# Społeczność

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---