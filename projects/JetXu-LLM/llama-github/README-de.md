
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Detailierte Dokumentation] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI version](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Downloads](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github ist ein leistungsstarkes Tool, das Ihnen hilft, basierend auf Agentic RAG, die relevantesten Code-Snippets, Issues und Repository-Informationen von GitHub anhand Ihrer Anfragen abzurufen und in wertvollen Wissenskontext zu verwandeln. Es befähigt LLM-Chatbots, KI-Agenten und Auto-dev-Agenten, komplexe Programmieraufgaben zu lösen. Egal, ob Sie als Entwickler schnelle Lösungen suchen oder als Ingenieur fortschrittliche Auto Dev KI-Agenten implementieren – llama-github macht es einfach und effizient.

Wenn Ihnen dieses Projekt gefällt oder Sie sein Potenzial erkennen, geben Sie ihm bitte ein ⭐️. Ihre Unterstützung ist unsere größte Motivation!

## Architektur
![High Level Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Installation
```
pip install llama-github
```

## Verwendung

Hier ist ein einfaches Beispiel, wie man llama-github verwendet:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```

Für fortgeschrittene Nutzung und weitere Beispiele verweisen wir auf die [Dokumentation](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Hauptmerkmale

- **🔍 Intelligente GitHub-Abfrage**: Nutzen Sie die Leistung von llama-github, um hochrelevante Code-Snippets, Issues und Repository-Informationen von GitHub basierend auf Benutzeranfragen abzurufen. Unsere fortschrittlichen Abfragetechniken sorgen dafür, dass Sie die relevantesten Informationen schnell und effizient finden.

- **⚡ Repository-Pool-Caching**: Llama-github verfügt über einen innovativen Repository-Pool-Cache-Mechanismus. Durch das Caching von Repositories (inklusive READMEs, Strukturen, Code und Issues) über Threads hinweg beschleunigt llama-github die Effizienz der GitHub-Suchabfrage erheblich und minimiert den Verbrauch von GitHub-API-Tokens. Setzen Sie llama-github mit Vertrauen in Multi-Thread-Produktionsumgebungen ein, denn es arbeitet optimal und spart wertvolle Ressourcen.

- **🧠 LLM-gestützte Frageanalyse**: Nutzen Sie modernste Sprachmodelle, um Benutzerfragen zu analysieren und äußerst effektive Suchstrategien und -kriterien zu generieren. Llama-github zerlegt komplexe Anfragen intelligent, sodass Sie die relevantesten Informationen aus dem umfangreichen GitHub-Repository-Netzwerk erhalten.

- **📚 Umfassende Kontextgenerierung**: Erzeugen Sie reichhaltige, kontextuell relevante Antworten, indem Sie die aus GitHub abgerufenen Informationen nahtlos mit den Schlussfolgerungsfähigkeiten fortschrittlicher Sprachmodelle kombinieren. Llama-github meistert selbst die komplexesten und längsten Fragen und liefert umfassende, aufschlussreiche Antworten mit umfangreichem Kontext zur Unterstützung Ihrer Entwicklungsanforderungen.

- **🚀 Exzellente asynchrone Verarbeitung**: Llama-github ist von Grund auf darauf ausgelegt, das volle Potenzial asynchroner Programmierung zu nutzen. Mit sorgfältig implementierten asynchronen Mechanismen im gesamten Code kann llama-github mehrere Anfragen gleichzeitig bearbeiten und so die Gesamtleistung deutlich steigern. Erleben Sie den Unterschied, wenn llama-github große Arbeitslasten effizient verwaltet, ohne Geschwindigkeit oder Qualität zu beeinträchtigen.

- **🔧 Flexible LLM-Integration**: Integrieren Sie llama-github einfach mit verschiedenen LLM-Anbietern, Embedding-Modellen und Reranking-Modellen, um die Fähigkeiten der Bibliothek an Ihre spezifischen Anforderungen anzupassen. Unsere erweiterbare Architektur ermöglicht es Ihnen, die Funktionalität von llama-github individuell zu gestalten und zu erweitern, sodass sie sich nahtlos an Ihre Entwicklungsumgebung anpasst.

- **🔒 Robuste Authentifizierungsoptionen**: Llama-github unterstützt sowohl persönliche Zugangstokens als auch GitHub-App-Authentifizierung und bietet Ihnen so die Flexibilität, es in verschiedene Entwicklungsumgebungen zu integrieren. Egal, ob Sie als Einzelentwickler oder im Rahmen eines Teams arbeiten, llama-github bietet sichere und zuverlässige Authentifizierungsmechanismen.

- **🛠️ Logging und Fehlerbehandlung**: Wir wissen, wie wichtig reibungslose Abläufe und einfache Fehlerbehebung sind. Deshalb ist llama-github mit umfassendem Logging und durchdachten Fehlerbehandlungsmechanismen ausgestattet. Gewinnen Sie tiefe Einblicke in das Verhalten der Bibliothek, diagnostizieren Sie Probleme schnell und sorgen Sie für einen stabilen und zuverlässigen Entwicklungsworkflow.

## 🤖 Testen Sie unseren KI-gestützten PR-Review-Assistenten: LlamaPReview

Wenn Sie llama-github nützlich finden, interessiert Sie vielleicht auch unser KI-basierter GitHub PR-Review-Assistent LlamaPReview. Er ist darauf ausgelegt, Ihren Entwicklungsworkflow zu ergänzen und die Codequalität weiter zu steigern.

### Hauptmerkmale von LlamaPReview:
- 🚀 Ein-Klick-Installation, keine Konfiguration nötig, vollautomatischer Betrieb
- 💯 Aktuell kostenlos nutzbar – keine Kreditkarte oder Zahlungsdaten erforderlich
- 🧠 KI-gestützte, automatische PR-Reviews mit tiefem Codeverständnis
- 🌐 Unterstützt mehrere Programmiersprachen

**LlamaPReview nutzt die fortschrittliche Kontextabfrage und LLM-gestützte Analyse von llama-github**, um intelligente, kontextbewusste Code-Reviews bereitzustellen. Es ist, als hätte man einen Senior-Entwickler, der mit dem vollen Kontext Ihres Repositories jede PR automatisch überprüft!

👉 [Installieren Sie LlamaPReview jetzt](https://github.com/marketplace/llamapreview/) (Kostenlos)

Durch die Nutzung von llama-github zur Kontextabfrage und LlamaPReview für Code-Reviews schaffen Sie eine leistungsstarke, KI-gestützte Entwicklungsumgebung.

## Vision und Roadmap

### Vision

Unsere Vision ist es, ein zentrales Modul in der Zukunft KI-gesteuerter Entwicklungslösungen zu werden, das sich nahtlos mit GitHub integriert und LLMs befähigt, komplexe Codierungsaufgaben automatisch zu lösen.

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Roadmap

Für eine detaillierte Ansicht unserer Projekt-Roadmap besuchen Sie bitte unsere [Projekt-Roadmap](https://github.com/users/JetXu-LLM/projects/2).

## Danksagungen

Wir möchten den folgenden Open-Source-Projekten für ihre Unterstützung und Beiträge danken:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Für das Bereitstellen des Grundgerüsts, das die LLM-Prompting- und -Verarbeitungsfähigkeiten in llama-github ermöglicht.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Für die Bereitstellung der s.jina.ai-API sowie Open-Source-Reranker- und Embedding-Modelle, die die Genauigkeit und Relevanz der generierten Kontexte in llama-github verbessern.

Ihre Beiträge waren maßgeblich für die Entwicklung von llama-github, und wir empfehlen, ihre Projekte für weitere innovative Lösungen zu prüfen.

## Beitrag leisten

Wir freuen uns über Beiträge zu llama-github! Bitte lesen Sie unsere [Beitragsrichtlinien](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) für weitere Informationen.

## Lizenz

Dieses Projekt ist unter den Bedingungen der Apache-2.0-Lizenz lizenziert. Siehe die [LICENSE](LICENSE)-Datei für weitere Details.

## Kontakt

Bei Fragen, Anregungen oder Feedback erreichen Sie uns gerne per E-Mail an [Jet Xu's E-Mail](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Vielen Dank, dass Sie sich für llama-github entschieden haben! Wir hoffen, dass diese Bibliothek Ihre KI-Entwicklungserfahrung verbessert und Ihnen hilft, leistungsstarke Anwendungen mit Leichtigkeit zu erstellen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---