<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: das DataFrame (neu) gebaut für LLM-Inferenz

[![PyPI version](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Python versions](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![License](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Dokumentation**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic ist ein meinungsstarkes, von PySpark inspiriertes DataFrame-Framework von typedef.ai für den Aufbau von KI- und agentischen Anwendungen. Transformieren Sie unstrukturierte und strukturierte Daten in Erkenntnisse mit vertrauten DataFrame-Operationen, erweitert durch semantische Intelligenz. Mit erstklassiger Unterstützung für Markdown, Transkripte und semantische Operatoren sowie effizienter Batch-Inferenz über jeden Modellanbieter hinweg.
## Installation

fenic unterstützt Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### Einrichtung des LLM-Anbieters

fenic benötigt einen API-Schlüssel von mindestens einem LLM-Anbieter. Setzen Sie die entsprechende Umgebungsvariable für Ihren gewählten Anbieter:

```bash
# Für OpenAI
export OPENAI_API_KEY="Ihr-openai-api-key"

# Für Anthropic
export ANTHROPIC_API_KEY="Ihr-anthropic-api-key"

# Für Google
export GEMINI_API_KEY="your-google-api-key"
```

## Schnellstart

Der schnellste Weg, fenic kennenzulernen, ist das Durchsehen der Beispiele.

Unten findest du eine kurze Liste der Beispiele in diesem Repository:

| Beispiel                                                                | Beschreibung                                                                                                                         |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                    | Einführung in die semantische Extraktion und Klassifikation mithilfe der Kern-Operatoren von fenic durch Fehlerprotokollanalyse.    |
| [Enrichment](examples/enrichment)                                       | Mehrstufige DataFrames mit vorlagenbasierter Textextraktion, Joins und LLM-gestützten Transformationen, demonstriert durch Log-Anreicherung. |
| [Meeting Transcript Processing](examples/meeting_transcript_processing) | Native Transkript-Analyse, Pydantic-Schema-Integration und komplexe Aggregationen am Beispiel der Sitzungsanalyse.                  |
| [News Analysis](examples/news_analysis)                                 | Analysiere und extrahiere Erkenntnisse aus Nachrichtenartikeln mit semantischen Operatoren und strukturierter Datenverarbeitung.    |
| [Podcast Summarization](examples/podcast_summarization)                 | Verarbeite und fasse Podcast-Transkripte zusammen mit sprecherbezogener Analyse und Schlüsselpunktextraktion.                      |
| [Semantic Join](examples/semantic_joins)                                | Statt einfacher Fuzzy-Matches nutze fenics leistungsstarke semantische Join-Funktionalität, um Daten tabellenübergreifend abzugleichen. |
| [Named Entity Recognition](examples/named_entity_recognition)           | Extrahiere und klassifiziere benannte Entitäten aus Text mithilfe semantischer Extraktion und Klassifikation.                       |
| [Markdown Processing](examples/markdown_processing)                     | Verarbeite und transformiere Markdown-Dokumente durch strukturierte Datenextraktion und -formatierung.                              |
| [JSON Processing](examples/json_processing)                             | Verarbeite komplexe JSON-Datenstrukturen mit semantischen Operationen und Schema-Validierung.                                       |
| [Feedback Clustering](examples/feedback_clustering)                     | Gruppiere und analysiere Feedback mithilfe semantischer Ähnlichkeit und Clustering-Operationen.                                     |
| [Document Extraction](examples/document_extraction)                     | Extrahiere strukturierte Informationen aus verschiedenen Dokumentformaten mit semantischen Operatoren.                              |

(Du kannst gerne auf ein beliebiges Beispiel oben klicken, um direkt zum entsprechenden Ordner zu springen.)

## Warum fenic verwenden?

fenic ist ein meinungsstarkes, von PySpark inspiriertes DataFrame-Framework zum Aufbau produktiver KI- und agentenbasierter Anwendungen.

Im Gegensatz zu traditionellen Datenwerkzeugen, die nachträglich für LLMs angepasst wurden, ist fenics Abfrage-Engine von Grund auf mit Fokus auf Inferenz entwickelt worden.

Transformieren Sie strukturierte und unstrukturierte Daten in Erkenntnisse mit vertrauten DataFrame-Operationen, die durch semantische Intelligenz erweitert werden. Mit erstklassiger Unterstützung für Markdown, Transkripte und semantische Operatoren sowie effizientem Batch-Inferencing über jeden Modellanbieter.

fenic bringt die Zuverlässigkeit traditioneller Datenpipelines in KI-Workloads.

### Hauptfunktionen

#### Speziell für LLM-Inferenz entwickelt

- Abfrage-Engine von Grund auf für KI-Workloads konzipiert, nicht nachträglich angepasst
- Automatische Batch-Optimierung für API-Aufrufe
- Integrierte Wiederholungslogik und Ratenbegrenzung
- Tokenzählung und Kostenverfolgung

#### Semantische Operatoren als First-Class Citizens
- `semantic.analyze_sentiment` - Eingebaute Sentiment-Analyse
- `semantic.classify` - Kategorisierung von Text mit Few-Shot-Beispielen
- `semantic.extract` - Umwandlung von unstrukturiertem Text in strukturierte Daten mittels Schemata
- `semantic.group_by` - Gruppierung von Daten nach semantischer Ähnlichkeit
- `semantic.join` - Verknüpfung von DataFrames basierend auf Bedeutung, nicht nur auf Werten
- `semantic.map` - Anwendung von Transformationen in natürlicher Sprache
- `semantic.predicate` - Erstellung von Prädikaten mittels natürlicher Sprache zur Filterung von Zeilen
- `semantic.reduce` - Aggregation gruppierter Daten mit LLM-Operationen

#### Native Unterstützung unstrukturierter Daten

Geht über typische multimodale Datentypen (Audio, Bilder) hinaus, indem spezialisierte Typen für textlastige Workloads geschaffen werden:

- Markdown-Parsing und -Extraktion als erstklassiger Datentyp
- Transkriptverarbeitung (SRT, generische Formate) mit Sprecher- und Zeitstempel-Erkennung
- JSON-Manipulation mit JQ-Ausdrücken für verschachtelte Daten
- Automatische Textzerlegung mit konfigurierbarer Überlappung für lange Dokumente

#### Produktionsreife Infrastruktur
- Multi-Provider-Unterstützung (OpenAI, Anthropic, Gemini)
- Lokale und Cloud-Ausführungs-Backends
- Umfassende Fehlerbehandlung und Protokollierung
- Pydantic-Integration für Typsicherheit

#### Vertraute DataFrame-API

- PySpark-kompatible Operationen
- Faule Auswertung und Abfrageoptimierung
- SQL-Unterstützung für komplexe Abfragen
- Nahtlose Integration in bestehende Datenpipelines

### Warum DataFrames für LLM- und Agenten-Anwendungen?

KI- und agentenbasierte Anwendungen sind im Kern Pipelines und Workflows – genau dafür wurden DataFrame-APIs entwickelt. Anstatt Muster für Datenumwandlung, Filterung und Aggregation neu zu erfinden, nutzt fenic jahrzehntelang bewährte Ingenieurpraktiken.

#### Entkoppelte Architektur für bessere Agenten

fenic schafft eine klare Trennung zwischen rechenintensiven Inferenzaufgaben und Echtzeit-Agenteninteraktionen. Durch das Auslagern der Batch-Verarbeitung aus der Agenten-Laufzeitumgebung erhalten Sie:

- Vorhersehbarere und reaktionsschnellere Agenten
- Bessere Ressourcenauslastung durch gebündelte LLM-Aufrufe
- Sauberere Trennung zwischen Planung/Orchestrierung und Ausführung
#### Für alle Ingenieure entwickelt

DataFrames sind nicht nur für Datenpraktiker gedacht. Das flüssige, komponierbare API-Design macht sie für jeden Ingenieur zugänglich:

- Verknüpfen Sie Operationen auf natürliche Weise: `df.filter(...).semantic.group_by(...)`
- Mischen Sie imperative und deklarative Stile nahtlos
- Starten Sie schnell mit vertrauten Mustern aus pandas/PySpark oder SQL

## Support

Treten Sie unserer Community auf [Discord](https://discord.gg/GdqF3J7huR) bei, wo Sie sich mit anderen Nutzern vernetzen, Fragen stellen und Hilfe zu Ihren fenic-Projekten erhalten können. Unsere Community freut sich immer, neue Mitglieder willkommen zu heißen!

Wenn Sie fenic nützlich finden, überlegen Sie, uns ein ⭐ am Anfang dieses Repositories zu geben. Ihre Unterstützung hilft uns, das Framework für alle weiterzuentwickeln und zu verbessern!

## Beitrag leisten

Wir freuen uns über Beiträge jeder Art! Egal, ob Sie Code schreiben, die Dokumentation verbessern, Features testen oder neue Ideen vorschlagen möchten – Ihre Hilfe ist uns wertvoll.

Für Entwickler, die Codeänderungen einreichen möchten, empfehlen wir, zunächst ein Issue zu eröffnen, um Ihre Ideen zu besprechen, bevor Sie einen Pull Request erstellen. Das trägt dazu bei, dass die Arbeit mit der Ausrichtung des Projekts übereinstimmt und doppelte Arbeiten vermieden werden.

Bitte beachten Sie unsere [Beitragsrichtlinien](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) für detaillierte Informationen zum Entwicklungsprozess und zur Projektstruktur.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---