# c4 GenAI Suite

Aplikacja chatbot AI z integracją Model Context Provider (MCP), oparta na Langchain i kompatybilna ze wszystkimi głównymi dużymi modelami językowymi (LLM) oraz modelami osadzającymi.

Administratorzy mogą tworzyć asystentów o różnych możliwościach poprzez dodawanie rozszerzeń, takich jak usługi RAG (Retrieval-Augmented Generation) lub serwery MCP. Aplikacja jest zbudowana w oparciu o nowoczesny stos technologiczny, w tym React, NestJS oraz Python FastAPI dla usługi REI-S.

Użytkownicy mogą wchodzić w interakcje z asystentami za pomocą przyjaznego interfejsu użytkownika. W zależności od konfiguracji asystenta, użytkownicy mogą zadawać pytania, przesyłać własne pliki lub korzystać z innych funkcji. Asystenci komunikują się z różnymi dostawcami LLM, aby udzielać odpowiedzi w oparciu o skonfigurowane rozszerzenia. Informacje kontekstowe dostarczane przez skonfigurowane rozszerzenia pozwalają asystentom odpowiadać na pytania specyficzne dla danej dziedziny i dostarczać odpowiednich informacji.

Aplikacja została zaprojektowana jako modułowa i rozszerzalna, umożliwiając użytkownikom tworzenie asystentów o różnych możliwościach poprzez dodawanie rozszerzeń.

![krótki film demo z podstawowym użyciem](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Funkcje

### Duże modele językowe (LLM) i modele multimodalne

c4 GenAI Suite obsługuje już wiele modeli bezpośrednio. Jeśli jednak Twój preferowany model nie jest jeszcze obsługiwany, powinno być łatwo napisać rozszerzenie, aby go obsłużyć.

* Modele kompatybilne z OpenAI
* Modele Azure OpenAI
* Modele Bedrock
* Modele Google GenAI
* Modele kompatybilne z Ollama
### Retrieval Augmented Generation (RAG)

Pakiet c4 GenAI Suite zawiera REI-S, serwer do przygotowywania plików do wykorzystania przez LLM.

* REI-S, niestandardowy zintegrowany serwer RAG
  * Magazyny wektorowe
    * pgvector
    * Azure AI Search
  * Modele osadzania
    * Osadzania kompatybilne z OpenAI
    * Osadzania Azure OpenAI
    * Osadzania kompatybilne z Ollama
  * Format plików:
    * pdf, docx, pptx, xlsx, ...
    * transkrypcja głosu z pliku audio (przez Whisper)

### Rozszerzenia

Pakiet c4 GenAI Suite został zaprojektowany z myślą o rozszerzalności. Pisanie rozszerzeń jest łatwe, podobnie jak korzystanie z już istniejącego serwera MCP.

* Serwery Model Context Protocol (MCP)
* Niestandardowy systemprompt
* Wyszukiwanie Bing
* Kalkulator
## Pierwsze kroki

### Używanie Docker-Compose

- Uruchom `docker compose up` w katalogu głównym projektu.
- Otwórz [aplikację](http://localhost:3333) w przeglądarce. Domyślne dane logowania to użytkownik `admin@example.com` i hasło `secret`.

![wideo pokazujące konfigurację asystenta](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Używanie Helm & Kubernetes

Aby wdrożyć w środowisku Kubernetes, zapoznaj się z [README naszego Helm Chart](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Konfiguracja Asystentów i Rozszerzeń

c4 GenAI Suite opiera się na *asystentach*.
Każdy asystent składa się z zestawu rozszerzeń, które określają model LLM oraz narzędzia, z których może korzystać.

- W obszarze administracyjnym (kliknij nazwę użytkownika w lewym dolnym rogu) przejdź do [sekcji asystentów](http://localhost:3333/admin/assistants).
- Dodaj asystenta przyciskiem z zielonym `+` obok tytułu sekcji. Wybierz nazwę i opis.
- Wybierz utworzonego asystenta i kliknij zielony przycisk `+ Dodaj rozszerzenie`.
- Wybierz model i uzupełnij dane uwierzytelniające.
- Użyj przycisku `Test`, aby sprawdzić działanie, a następnie `zapisz`.

Teraz możesz wrócić do [strony czatu](http://localhost:3333/chat) (kliknij `c4 GenAI Suite` w lewym górnym rogu) i rozpocząć nową rozmowę z nowym asystentem.

> [!TIP]
> Nasz `docker-compose` zawiera lokalną instancję Ollama, która działa na CPU. Możesz użyć jej do szybkiego testowania, ale będzie wolna i prawdopodobnie będziesz chciał użyć innego modelu. Jeśli chcesz z niej skorzystać, utwórz poniższe rozszerzenie modelu w swoim Asystencie.
> * Rozszerzenie: `Dev: Ollama`
> * Endpoint: `http://ollama:11434`
> * Model: `llama3.2`

### Protokół Model Context Protocol (MCP) [opcjonalnie]

Użyj dowolnego serwera MCP oferującego interfejs `sse` z rozszerzeniem `MCP Tools` (lub użyj naszego `mcp-tool-as-server` jako proxy przed serwerem MCP korzystającym z `stdio`).
Każdy serwer MCP może być skonfigurowany szczegółowo jako rozszerzenie.

### Retrieval Augmented Generation (RAG) / Wyszukiwanie w plikach [opcjonalnie]

Użyj naszego serwera RAG `REI-S`, aby przeszukiwać pliki udostępnione przez użytkownika. Wystarczy skonfigurować rozszerzenie `Search Files` dla asystenta.
Proces ten został szczegółowo opisany w [podkatalogu `services/reis`](services/reis/#example-configuration-in-c4).

## Wkład i rozwój

* Zobacz [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md), aby zapoznać się z wytycznymi dotyczącymi wkładu.
* Dla wdrożenia programistów sprawdź [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Główne elementy aplikacji

Aplikacja składa się z **Frontendu**, **Backendu** oraz usługi **REI-S**.

```
┌──────────┐
│   Użytkownik   │
└─────┬────┘
      │ dostęp
      ▼
┌──────────┐
│ Frontend │
└─────┬────┘
      │ dostęp
      ▼
┌──────────┐     ┌─────────────────┐
│ Backend  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ dostęp
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Model osadzania │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Magazyn wektorów │
└──────────┘     └─────────────────┘
```
### Frontend

Frontend został zbudowany z użyciem React i TypeScript, zapewniając przyjazny dla użytkownika interfejs do interakcji z backendem oraz usługą REI-S. Obejmuje funkcje do zarządzania asystentami, rozszerzeniami oraz funkcjonalnościami czatu.

> Źródła: `/frontend`

### Backend

Backend został opracowany przy użyciu NestJS i TypeScript, służąc jako główna warstwa API dla aplikacji. Obsługuje żądania z frontendu oraz współpracuje z dostawcami LLM w celu realizacji funkcji czatu. Backend zarządza także asystentami i ich rozszerzeniami, umożliwiając użytkownikom konfigurowanie i wykorzystywanie różnych modeli AI w ich czatach.

Dodatkowo backend zarządza uwierzytelnianiem użytkowników oraz komunikuje się z usługą REI-S w celu indeksowania i pobierania plików.

Do trwałego przechowywania danych backend wykorzystuje bazę danych **PostgreSQL**.

> Źródła: `/backend`

### REI-S

REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) to serwer oparty na Pythonie, który zapewnia podstawowe możliwości RAG (Retrieval-Augmented Generation). Umożliwia ekstrakcję zawartości plików, indeksowanie i zapytania, pozwalając aplikacji na efektywną obsługę dużych zbiorów danych. Usługa REI-S została zaprojektowana do bezproblemowej współpracy z backendem, dostarczając niezbędnych danych do funkcjonalności czatu i wyszukiwania plików.

REI-S obsługuje Azure AI Search oraz pgvector do przechowywania wektorów, umożliwiając elastyczne i skalowalne opcje wyszukiwania danych. Usługę można skonfigurować za pomocą zmiennych środowiskowych w celu określenia typu magazynu wektorów oraz szczegółów połączenia.

> Źródła: `/services/reis`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---