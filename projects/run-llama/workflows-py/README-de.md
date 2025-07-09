# LlamaIndex Workflows

[![Unit Testing](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Coverage Status](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub contributors](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Downloads](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows sind ein Framework zur Orchestrierung und Verkettung komplexer Systeme aus Schritten und Ereignissen.

## Was können Sie mit Workflows bauen?

Workflows sind besonders dann hilfreich, wenn Sie komplexe, mehrstufige Prozesse orchestrieren müssen, die KI-Modelle, APIs und Entscheidungsfindung einbeziehen. Hier sind einige Beispiele, was Sie bauen können:

- **KI-Agenten** – Erstellen Sie intelligente Systeme, die über mehrere Schritte hinweg schlussfolgern, Entscheidungen treffen und Aktionen ausführen können
- **Dokumentenverarbeitungspipelines** – Entwickeln Sie Systeme, die Dokumente aufnehmen, analysieren, zusammenfassen und durch verschiedene Verarbeitungsstufen leiten
- **Multi-Model-KI-Anwendungen** – Koordinieren Sie verschiedene KI-Modelle (LLMs, Vision-Modelle usw.), um komplexe Aufgaben zu lösen
- **Forschungsassistenten** – Entwickeln Sie Workflows, die Informationen suchen, analysieren, synthetisieren und umfassende Antworten liefern können
- **Systeme zur Inhaltserstellung** – Erstellen Sie Pipelines, die Inhalte generieren, prüfen, bearbeiten und mit menschlicher Freigabe veröffentlichen
- **Automatisierung des Kundensupports** – Bauen Sie intelligente Routingsysteme, die Kundenanfragen verstehen, kategorisieren und beantworten können

Die asynchrone, ereignisgesteuerte Architektur erleichtert das Erstellen von Workflows, die zwischen verschiedenen Fähigkeiten routen, parallele Verarbeitung implementieren, komplexe Sequenzen wiederholen und den Zustand über mehrere Schritte hinweg beibehalten können – all die Funktionen, die Sie benötigen, um Ihre KI-Anwendungen produktionsreif zu machen.
## Hauptmerkmale

- **async-first** – Workflows sind um die asynchrone Funktionalität von Python aufgebaut – Schritte sind asynchrone Funktionen, die eingehende Ereignisse aus einer asyncio-Warteschlange verarbeiten und neue Ereignisse an andere Warteschlangen senden. Das bedeutet auch, dass Workflows am besten in asynchronen Anwendungen wie FastAPI, Jupyter Notebooks usw. funktionieren.
- **ereignisgesteuert** – Workflows bestehen aus Schritten und Ereignissen. Die Organisation Ihres Codes rund um Ereignisse und Schritte erleichtert das Verständnis und das Testen.
- **Zustandsverwaltung** – Jeder Durchlauf eines Workflows ist in sich abgeschlossen, das heißt, Sie können einen Workflow starten, Informationen darin speichern, den Zustand eines Workflows serialisieren und ihn später fortsetzen.
- **Beobachtbarkeit** – Workflows sind automatisch für die Beobachtbarkeit instrumentiert, das bedeutet, Sie können Tools wie `Arize Phoenix` und `OpenTelemetry` direkt verwenden.

## Schnellstart

Installieren Sie das Paket:

```bash
pip install llama-index-workflows
```

Und erstellen Sie Ihren ersten Workflow:

```python
import asyncio
from pydantic import BaseModel, Field
from workflows import Context, Workflow, step
from workflows.events import Event, StartEvent, StopEvent

class MyEvent(Event):
    msg: list[str]

class RunState(BaseModel):
    num_runs: int = Field(default=0)

class MyWorkflow(Workflow):
    @step
    async def start(self, ctx: Context[RunState], ev: StartEvent) -> MyEvent:
        async with ctx.store.edit_state() as state:
            state.num_runs += 1

            return MyEvent(msg=[ev.input_msg] * state.num_runs)

    @step
    async def process(self, ctx: Context[RunState], ev: MyEvent) -> StopEvent:
        data_length = len("".join(ev.msg))
        new_msg = f"Processed {len(ev.msg)} times, data length: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```markdown
    # [optional] Geben Sie ein Kontextobjekt an den Workflow weiter
    ctx = Context(workflow)
    result = await workflow.run(input_msg="Hallo, Welt!", ctx=ctx)
    print("Workflow-Ergebnis:", result)

    # Das erneute Ausführen mit demselben Kontext behält den Zustand bei
    result = await workflow.run(input_msg="Hallo, Welt!", ctx=ctx)
    print("Workflow-Ergebnis:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

Im obigen Beispiel gilt:
- Schritte, die ein `StartEvent` akzeptieren, werden zuerst ausgeführt.
- Schritte, die ein `StopEvent` zurückgeben, beenden den Workflow.
- Zwischenereignisse sind benutzerdefiniert und können verwendet werden, um Informationen zwischen Schritten zu übergeben.
- Das `Context`-Objekt wird ebenfalls verwendet, um Informationen zwischen Schritten zu teilen.

Besuchen Sie die [vollständige Dokumentation](https://docs.llamaindex.ai/en/stable/understanding/workflows/) für weitere Beispiele zur Verwendung von `llama-index`!
```
## Weitere Beispiele

- [Grundlegende Funktionsübersicht](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Erstellung eines Function Calling Agent mit `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Iterative Dokumentenextraktion mit Mensch-in-der-Schleife](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Beobachtbarkeit
  - [OpenTelemetry + Instrumentierungseinführung](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Verwandte Pakete

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---