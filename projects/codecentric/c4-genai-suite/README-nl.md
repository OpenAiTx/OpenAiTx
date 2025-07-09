# c4 GenAI Suite

Een AI-chatbotapplicatie met Model Context Provider (MCP) integratie, aangedreven door Langchain en compatibiliteit met alle grote Large Language Models (LLM's) en Embedding Modellen.

Beheerders kunnen assistenten creëren met verschillende mogelijkheden door extensies toe te voegen, zoals RAG (Retrieval-Augmented Generation) services of MCP-servers. De applicatie is gebouwd met behulp van een moderne tech stack, waaronder React, NestJS en Python FastAPI voor de REI-S service.

Gebruikers kunnen met assistenten communiceren via een gebruiksvriendelijke interface. Afhankelijk van de configuratie van de assistent kunnen gebruikers vragen stellen, hun eigen bestanden uploaden of andere functies gebruiken. De assistenten communiceren met verschillende LLM-aanbieders om antwoorden te geven op basis van de geconfigureerde extensies. Contextuele informatie, geleverd door de geconfigureerde extensies, stelt de assistenten in staat om domeinspecifieke vragen te beantwoorden en relevante informatie te geven.

De applicatie is ontworpen om modulair en uitbreidbaar te zijn, zodat gebruikers assistenten kunnen creëren met verschillende mogelijkheden door extensies toe te voegen.

![korte demovideo van basisgebruik](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Functies

### Large Language Models (LLM) en Multimodale Modellen

De c4 GenAI Suite ondersteunt al veel modellen direct. En als uw voorkeursmodel nog niet wordt ondersteund, zou het eenvoudig moeten zijn om een extensie te schrijven om deze te ondersteunen.

* OpenAI-compatibele modellen
* Azure OpenAI-modellen
* Bedrock-modellen
* Google GenAI-modellen
* Ollama-compatibele modellen
### Retrieval Augmented Generation (RAG)

De c4 GenAI Suite bevat REI-S, een server om bestanden voor te bereiden voor gebruik door het LLM.

* REI-S, een aangepast geïntegreerde RAG-server
  * Vector stores
    * pgvector
    * Azure AI Search
  * Embedding modellen
    * OpenAI-compatibele embeddings
    * Azure OpenAI embeddings
    * Ollama-compatibele embeddings
  * Bestandsformaten:
    * pdf, docx, pptx, xlsx, ...
    * audio-bestand spraaktranscriptie (via Whisper)

### Extensies

De c4 GenAI Suite is ontworpen voor uitbreidbaarheid. Het schrijven van extensies is eenvoudig, evenals het gebruik van een reeds bestaande MCP-server.

* Model Context Protocol (MCP) servers
* Aangepaste systemprompt
* Bing Search
* Rekenmachine
## Aan de slag

### Gebruik van Docker-Compose

- Voer `docker compose up` uit in de hoofdmap van het project.
- Open de [applicatie](http://localhost:3333) in een browser. De standaard inloggegevens zijn gebruiker `admin@example.com` en wachtwoord `secret`.

![video die assistentconfiguratie toont](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Gebruik van Helm & Kubernetes

Voor implementatie in Kubernetes-omgevingen, raadpleeg de [README van onze Helm Chart](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Assistenten en Extensies instellen

De c4 GenAI Suite draait om *assistenten*.
Elke assistent bestaat uit een set extensies, die bepalen welk LLM-model en welke tools hij kan gebruiken.

- Ga in het beheerdersgedeelte (klik op de gebruikersnaam linksonder) naar de [assistenten sectie](http://localhost:3333/admin/assistants).
- Voeg een assistent toe met de groene `+` knop naast de sectietitel. Kies een naam en een beschrijving.
- Selecteer de aangemaakte assistent en klik op de groene `+ Extensie toevoegen`.
- Selecteer het model en vul de inloggegevens in.
- Gebruik de knop `Test` om te controleren of alles werkt en `opslaan`.

Nu kun je terugkeren naar de [chatpagina](http://localhost:3333/chat) (klik op `c4 GenAI Suite` linksboven) en een nieuw gesprek starten met je nieuwe assistent.

> [!TIP]
> Onze `docker-compose` bevat een lokale Ollama, die op de CPU draait. Je kunt deze gebruiken voor snel testen. Maar het zal traag zijn en je wilt waarschijnlijk een ander model gebruiken. Als je het wilt gebruiken, maak dan gewoon de volgende modelextensie aan in je Assistent.
> * Extensie: `Dev: Ollama`
> * Endpoint: `http://ollama:11434`
> * Model: `llama3.2`
### Model Context Protocol (MCP) [optioneel]

Gebruik elke MCP-server die een `sse`-interface aanbiedt met de `MCP Tools`-extensie (of gebruik onze `mcp-tool-as-server` als een proxy voor een `stdio` MCP-server).
Elke MCP-server kan in detail worden geconfigureerd als een extensie.

### Retrieval Augmented Generation (RAG) / Bestanden Zoeken [optioneel]

Gebruik onze RAG-server `REI-S` om door door de gebruiker aangeleverde bestanden te zoeken. Configureer hiervoor eenvoudig een `Bestanden Zoeken`-extensie voor de assistent.
Dit proces wordt in detail beschreven in [de submap `services/reis`](services/reis/#example-configuration-in-c4).

## Bijdragen & Ontwikkeling

* Zie [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) voor richtlijnen over hoe je kunt bijdragen.
* Voor onboarding van ontwikkelaars, bekijk [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Belangrijkste Bouwstenen

De applicatie bestaat uit een **Frontend**, een **Backend** en een **REI-S**-service.

```
┌──────────┐
│   Gebruiker  │
└─────┬────┘
      │ toegang
      ▼
┌──────────┐
│ Frontend │
└─────┬────┘
      │ toegang
      ▼
┌──────────┐     ┌─────────────────┐
│ Backend  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ toegang
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Embedding Model │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Vector Store   │
└──────────┘     └─────────────────┘
```
### Frontend

De frontend is gebouwd met React en TypeScript en biedt een gebruiksvriendelijke interface voor interactie met de backend en de REI-S service. Het bevat functionaliteiten voor het beheren van assistenten, extensies en chatfuncties.

> Bronnen: `/frontend`

### Backend

De backend is ontwikkeld met NestJS en TypeScript en dient als de belangrijkste API-laag van de applicatie. Het verwerkt verzoeken van de frontend en communiceert met llm-providers om chatfuncties mogelijk te maken. De backend beheert ook assistenten en hun extensies, waardoor gebruikers verschillende AI-modellen kunnen configureren en gebruiken voor hun chats.

Daarnaast beheert de backend gebruikersauthenticatie en communiceert met de REI-S service voor het indexeren en ophalen van bestanden.

Voor gegevensopslag gebruikt de backend een **PostgreSQL**-database.

> Bronnen: `/backend`

### REI-S

De REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) is een Python-gebaseerde server die basis RAG (Retrieval-Augmented Generation) mogelijkheden biedt. Het maakt het mogelijk om bestandsinhoud te extraheren, indexeren en op te vragen, waardoor de applicatie grote datasets efficiënt kan verwerken. De REI-S service is ontworpen om naadloos samen te werken met de backend en voorziet in benodigde data voor chatfuncties en bestandszoekopdrachten.

De REI-S ondersteunt Azure AI Search en pgvector voor vectoropslag, waardoor flexibele en schaalbare dataterugvindopties mogelijk zijn. De service kan worden geconfigureerd met omgevingsvariabelen om het type vectorstore en verbindingsgegevens te specificeren.

> Bronnen: `/services/reis`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---