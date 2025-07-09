# c4 GenAI Suite

Eine KI-Chatbot-Anwendung mit Model Context Provider (MCP)-Integration, basierend auf Langchain und kompatibel mit allen gängigen Large Language Models (LLMs) und Embedding Models.

Administratoren können Assistenten mit unterschiedlichen Fähigkeiten erstellen, indem sie Erweiterungen wie RAG- (Retrieval-Augmented Generation) Dienste oder MCP-Server hinzufügen. Die Anwendung ist mit einem modernen Tech-Stack entwickelt, darunter React, NestJS und Python FastAPI für den REI-S Dienst.

Benutzer können über eine benutzerfreundliche Oberfläche mit den Assistenten interagieren. Je nach Konfiguration des Assistenten können Benutzer Fragen stellen, eigene Dateien hochladen oder andere Funktionen nutzen. Die Assistenten interagieren mit verschiedenen LLM-Anbietern, um Antworten basierend auf den konfigurierten Erweiterungen zu liefern. Kontextbezogene Informationen, die durch die konfigurierten Erweiterungen bereitgestellt werden, ermöglichen es den Assistenten, domänenspezifische Fragen zu beantworten und relevante Informationen zu liefern.

Die Anwendung ist modular und erweiterbar konzipiert, sodass Benutzer Assistenten mit unterschiedlichen Fähigkeiten durch das Hinzufügen von Erweiterungen erstellen können.

![kurzes Demovideo zur grundlegenden Nutzung](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Funktionen

### Large Language Models (LLM) und Multimodale Modelle

Die c4 GenAI Suite unterstützt bereits viele Modelle direkt. Und falls Ihr bevorzugtes Modell noch nicht unterstützt wird, sollte es einfach sein, eine Erweiterung zur Unterstützung zu schreiben.

* OpenAI-kompatible Modelle
* Azure OpenAI Modelle
* Bedrock Modelle
* Google GenAI Modelle
* Ollama-kompatible Modelle
### Retrieval Augmented Generation (RAG)

Die c4 GenAI Suite beinhaltet REI-S, einen Server zur Vorbereitung von Dateien für die Nutzung durch das LLM.

* REI-S, ein individuell integrierter RAG-Server
  * Vektorspeicher
    * pgvector
    * Azure AI Search
  * Embedding-Modelle
    * OpenAI-kompatible Embeddings
    * Azure OpenAI Embeddings
    * Ollama-kompatible Embeddings
  * Dateiformate:
    * pdf, docx, pptx, xlsx, ...
    * Audio-Datei Spracherkennung (über Whisper)

### Erweiterungen

Die c4 GenAI Suite ist auf Erweiterbarkeit ausgelegt. Das Schreiben von Erweiterungen ist einfach, ebenso wie die Nutzung eines bereits existierenden MCP-Servers.

* Model Context Protocol (MCP) Server
* Benutzerdefinierter Systemprompt
* Bing-Suche
* Taschenrechner
## Erste Schritte

### Verwendung von Docker-Compose

- Führen Sie `docker compose up` im Projektverzeichnis aus.
- Öffnen Sie die [Anwendung](http://localhost:3333) in einem Browser. Die Standard-Login-Daten sind Benutzer `admin@example.com` und Passwort `secret`.

![Video zur Assistenz-Konfiguration](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Verwendung von Helm & Kubernetes

Für die Bereitstellung in Kubernetes-Umgebungen beachten Sie bitte die [README unserer Helm-Chart](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Einrichten von Assistenten und Erweiterungen

Die c4 GenAI Suite dreht sich um *Assistenten*.
Jeder Assistent besteht aus einer Reihe von Erweiterungen, welche das LLM-Modell und die verwendbaren Tools bestimmen.

- Im Admin-Bereich (klicken Sie auf den Benutzernamen unten links), gehen Sie zum [Assistenten-Bereich](http://localhost:3333/admin/assistants).
- Fügen Sie einen Assistenten mit dem grünen `+`-Button neben dem Abschnittstitel hinzu. Wählen Sie einen Namen und eine Beschreibung.
- Wählen Sie den erstellten Assistenten aus und klicken Sie auf das grüne `+ Erweiterung hinzufügen`.
- Wählen Sie das Modell und geben Sie die Zugangsdaten ein.
- Verwenden Sie den `Testen`-Button, um zu prüfen, ob alles funktioniert, und klicken Sie auf `Speichern`.

Nun können Sie zur [Chat-Seite](http://localhost:3333/chat) zurückkehren (klicken Sie auf `c4 GenAI Suite` oben links) und eine neue Konversation mit Ihrem neuen Assistenten starten.

> [!TIPP]
> Unser `docker-compose` beinhaltet ein lokales Ollama, das auf der CPU läuft. Sie können dies für schnelles Testen verwenden. Es wird jedoch langsam sein, und Sie möchten wahrscheinlich ein anderes Modell verwenden. Wenn Sie es verwenden möchten, erstellen Sie einfach die folgende Modellerweiterung in Ihrem Assistenten.
> * Erweiterung: `Dev: Ollama`
> * Endpunkt: `http://ollama:11434`
> * Modell: `llama3.2`
### Model Context Protocol (MCP) [optional]

Verwenden Sie jeden MCP-Server, der eine `sse`-Schnittstelle mit der Erweiterung `MCP Tools` anbietet (oder nutzen Sie unser `mcp-tool-as-server` als Proxy vor einem `stdio`-MCP-Server).
Jeder MCP-Server kann im Detail als Erweiterung konfiguriert werden.

### Retrieval Augmented Generation (RAG) / Dateisuche [optional]

Verwenden Sie unseren RAG-Server `REI-S`, um von Benutzern bereitgestellte Dateien zu durchsuchen. Konfigurieren Sie einfach eine `Search Files`-Erweiterung für den Assistenten.
Dieser Prozess wird ausführlich im [Unterverzeichnis `services/reis`](services/reis/#example-configuration-in-c4) beschrieben.

## Beitrag & Entwicklung

* Siehe [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) für Richtlinien zur Mitwirkung.
* Für die Entwickler-Einführung siehe [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Hauptbausteine

Die Anwendung besteht aus einem **Frontend**, einem **Backend** und einem **REI-S**-Dienst.

```
┌──────────┐
│  Benutzer│
└─────┬────┘
      │ Zugriff
      ▼
┌──────────┐
│ Frontend │
└─────┬────┘
      │ Zugriff
      ▼
┌──────────┐     ┌─────────────────┐
│ Backend  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ Zugriff
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Embedding-Modell│
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Vektorspeicher │
└──────────┘     └─────────────────┘
```
### Frontend

Das Frontend ist mit React und TypeScript entwickelt und bietet eine benutzerfreundliche Oberfläche zur Interaktion mit dem Backend und dem REI-S-Service. Es umfasst Funktionen zur Verwaltung von Assistenten, Erweiterungen und Chat-Funktionalitäten.

> Quellen: `/frontend`

### Backend

Das Backend wurde mit NestJS und TypeScript entwickelt und dient als Haupt-API-Schicht der Anwendung. Es verarbeitet Anfragen vom Frontend und interagiert mit LLM-Anbietern, um Chat-Funktionalitäten bereitzustellen. Das Backend verwaltet außerdem Assistenten und deren Erweiterungen, sodass Benutzer verschiedene KI-Modelle für ihre Chats konfigurieren und nutzen können.

Zusätzlich verwaltet das Backend die Benutzerauthentifizierung und kommuniziert mit dem REI-S-Service zur Datei-Indizierung und -Abruf.

Für die Datenpersistenz verwendet das Backend eine **PostgreSQL**-Datenbank.

> Quellen: `/backend`

### REI-S

Der REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) ist ein auf Python basierender Server, der grundlegende RAG-Funktionen (Retrieval-Augmented Generation) bereitstellt. Er ermöglicht die Extraktion, Indizierung und Abfrage von Dateiinhalten, wodurch die Anwendung große Datensätze effizient verarbeiten kann. Der REI-S-Service ist so konzipiert, dass er nahtlos mit dem Backend zusammenarbeitet und die notwendigen Daten für Chat-Funktionalitäten und Dateisuche bereitstellt.

Der REI-S unterstützt Azure AI Search und pgvector für die Vektorspeicherung und ermöglicht so flexible und skalierbare Optionen für die Datenabfrage. Der Service kann über Umgebungsvariablen konfiguriert werden, um den Typ des Vektorspeichers und die Verbindungsdetails festzulegen.

> Quellen: `/services/reis`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---