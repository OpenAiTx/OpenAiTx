
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Detaildokument] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI version](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Downloads](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github ist ein leistungsfähiges Tool, das Ihnen hilft, anhand von Agentic RAG die relevantesten Code-Snippets, Issues und Repository-Informationen von GitHub zu Ihren Anfragen abzurufen und in wertvollen Wissenskontext zu verwandeln. Es befähigt LLM-Chatbots, KI-Agenten und Auto-dev-Agenten, komplexe Programmieraufgaben zu lösen. Egal, ob Sie als Entwickler schnelle Lösungen suchen oder als Ingenieur fortschrittliche Auto Dev KI-Agenten implementieren – llama-github macht es einfach und effizient.

Wenn Ihnen dieses Projekt gefällt oder Sie an sein Potenzial glauben, geben Sie ihm bitte ein ⭐️. Ihre Unterstützung ist unsere größte Motivation!

## Architektur
![High Level Architektur](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Installation
```
pip install llama-github
```

Aktuell gepflegtes Laufzeit-Ziel: Python `3.10+`.

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
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```

`retrieve_context()` gibt eine Liste von Kontext-Dictionaries zurück. Jedes Element enthält mindestens `context` und `url`.

Für weiterführende Nutzung und Beispiele siehe bitte die [Dokumentation](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Ausführbare kostengünstige Beispiele sind ebenfalls in [`examples/`](examples) verfügbar.

## Hauptfunktionen

- **🔍 Intelligente GitHub-Abfrage**: Nutze die Leistung von llama-github, um hochrelevante Code-Snippets, Issues und Repository-Informationen basierend auf Benutzeranfragen von GitHub abzurufen. Unsere fortschrittlichen Retrieval-Methoden sorgen dafür, dass du die relevantesten Informationen schnell und effizient findest.

- **⚡ Repository-Pool-Caching**: Llama-github verfügt über einen innovativen Repository-Pool-Caching-Mechanismus. Durch das Caching von Repositories (einschließlich READMEs, Strukturen, Code und Issues) über Threads hinweg beschleunigt llama-github die Effizienz der GitHub-Suchabfrage erheblich und minimiert den Verbrauch von GitHub API-Tokens.

- **🧠 LLM-gestützte Frageanalyse**: Nutze modernste Sprachmodelle, um Benutzerfragen zu analysieren und hocheffektive Suchstrategien und Kriterien zu generieren. Llama-github zerlegt komplexe Anfragen intelligent, sodass du die relevantesten Informationen aus dem umfangreichen GitHub-Repository-Netzwerk erhältst.

- **📚 Umfassende Kontextgenerierung**: Generiere reichhaltige, kontextuell relevante Antworten, indem Informationen von GitHub nahtlos mit den Schlussfolgerungsfähigkeiten fortschrittlicher Sprachmodelle kombiniert werden. Llama-github bewältigt selbst die komplexesten und längsten Fragen und liefert umfassende und aufschlussreiche Antworten inklusive ausführlichem Kontext zur Unterstützung deiner Entwicklung.

- **🚀 Herausragende asynchrone Verarbeitung**: Llama-github ist von Grund auf darauf ausgelegt, das volle Potenzial asynchroner Programmierung zu nutzen. Dank sorgfältig implementierter asynchroner Mechanismen im gesamten Code kann llama-github mehrere Anfragen gleichzeitig bearbeiten und so die Gesamtleistung deutlich steigern.

- **🔧 Flexible LLM-Integration**: Integriere llama-github mühelos mit verschiedenen LLM-Anbietern, Einbettungsmodellen, Reranking-Modellen oder einem eingespeisten, LangChain-kompatiblen Chatmodell, um die Fähigkeiten der Bibliothek an deine spezifischen Anforderungen anzupassen.

- **🔒 Robuste Authentifizierungsoptionen**: Llama-github unterstützt sowohl persönliche Zugriffstokens als auch die Authentifizierung über GitHub Apps und bietet dir somit die Flexibilität, es in verschiedene Entwicklungsumgebungen zu integrieren. Ob Einzelentwickler oder im Unternehmensumfeld – llama-github bietet sichere und zuverlässige Authentifizierung.

- **🛠️ Logging und Fehlerbehandlung**: Wir wissen, wie wichtig reibungslose Abläufe und einfaches Troubleshooting sind. Deshalb ist llama-github mit umfassenden Logging- und Fehlerbehandlungsmechanismen ausgestattet. Gewinne tiefe Einblicke in das Verhalten der Bibliothek, diagnostiziere Probleme schnell und sorge für einen stabilen und verlässlichen Entwicklungsworkflow.

## 🤖 Probiere unseren KI-gestützten PR-Review-Assistenten: LlamaPReview

Wenn dir llama-github gefällt, könnte auch unser KI-gestützter GitHub PR-Review-Assistent LlamaPReview interessant für dich sein. Er ist darauf ausgelegt, deinen Entwicklungsworkflow zu ergänzen und die Codequalität weiter zu verbessern.

### Hauptfunktionen von LlamaPReview:
- 🚀 Installation mit nur einem Klick, keine Konfiguration erforderlich, läuft vollautomatisch
- 💯 Derzeit kostenlos nutzbar – keine Kreditkarte oder Zahlungsdaten notwendig
- 🧠 KI-gestützte, automatische PR-Reviews mit tiefgehendem Codeverständnis
- 🌐 Unterstützt mehrere Programmiersprachen

**LlamaPReview nutzt die fortschrittliche Kontextabfrage und LLM-Analyse von llama-github**, um intelligente, kontextbewusste Code-Reviews zu liefern. Es ist, als hätte man einen Senior Developer, der mit dem vollen Kontext deines Repositories jede PR automatisch überprüft!

👉 [LlamaPReview jetzt installieren](https://github.com/marketplace/llamapreview/) (Kostenlos)

Durch die Nutzung von llama-github zur Kontextbeschaffung und LlamaPReview für Code-Reviews kannst du eine leistungsstarke, KI-gestützte Entwicklungsumgebung schaffen.

## Vision und Roadmap

### Vision

Unsere Vision ist es, ein zentrales Modul in der Zukunft KI-gesteuerter Entwicklungslösungen zu werden, das sich nahtlos in GitHub integriert und LLMs befähigt, komplexe Codierungsaufgaben automatisch zu lösen.

![Vision Architektur](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Roadmap

Für einen historischen Überblick über die frühere Roadmap besuchen Sie bitte [Vision und Roadmap](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Danksagungen

Wir möchten folgenden Open-Source-Projekten für ihre Unterstützung und Beiträge unseren Dank aussprechen:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Für die Bereitstellung des grundlegenden Frameworks, das die LLM-Prompting- und Verarbeitungsfunktionen in llama-github ermöglicht.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Für die Bereitstellung der s.jina.ai API sowie der Open-Source-Reranker- und Embedding-Modelle, die die Genauigkeit und Relevanz der generierten Kontexte in llama-github verbessern.

Ihre Beiträge waren maßgeblich für die Entwicklung von llama-github, und wir empfehlen Ihnen, ihre Projekte für weitere innovative Lösungen anzusehen.

## Beitrag leisten

Wir freuen uns über Beiträge zu llama-github! Weitere Informationen finden Sie in unseren [Beitragsrichtlinien](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md).

## Lizenz

Dieses Projekt steht unter den Bedingungen der Apache 2.0 Lizenz. Weitere Informationen finden Sie in der [LICENSE](LICENSE) Datei.

## Kontakt

Wenn Sie Fragen, Anregungen oder Feedback haben, wenden Sie sich gerne an [Jet Xu's E-Mail](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Vielen Dank, dass Sie sich für llama-github entschieden haben! Wir hoffen, dass diese Bibliothek Ihre KI-Entwicklungserfahrung verbessert und Ihnen hilft, leistungsstarke Anwendungen einfach zu erstellen.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---