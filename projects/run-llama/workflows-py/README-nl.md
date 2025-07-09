# LlamaIndex Workflows

[![Unit Testing](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Coverage Status](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub contributors](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Downloads](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows zijn een framework voor het orkestreren en samenvoegen van complexe systemen van stappen en gebeurtenissen.

## Wat kun je bouwen met Workflows?

Workflows komen tot hun recht wanneer je complexe processen met meerdere stappen moet orkestreren die AI-modellen, API's en besluitvorming omvatten. Hier zijn enkele voorbeelden van wat je kunt bouwen:

- **AI Agents** - Maak intelligente systemen die kunnen redeneren, beslissingen nemen en acties uitvoeren over meerdere stappen
- **Documentverwerkingspijplijnen** - Bouw systemen die documenten inlezen, analyseren, samenvatten en routeren door verschillende verwerkingsstadia
- **Multi-model AI-toepassingen** - Coördineer tussen verschillende AI-modellen (LLM's, vision-modellen, etc.) om complexe taken op te lossen
- **Onderzoeksassistenten** - Ontwikkel workflows die informatie kunnen zoeken, analyseren, synthetiseren en uitgebreide antwoorden kunnen geven
- **Contentgeneratiesystemen** - Maak pijplijnen die content genereren, beoordelen, bewerken en publiceren met goedkeuring van mensen in de lus
- **Automatisering van klantenservice** - Bouw intelligente routersystemen die klantvragen kunnen begrijpen, categoriseren en beantwoorden

De async-first, event-driven architectuur maakt het eenvoudig om workflows te bouwen die kunnen routeren tussen verschillende capaciteiten, parallelle verwerkingspatronen implementeren, over complexe sequenties kunnen herhalen en status kunnen behouden over meerdere stappen - alle functies die je nodig hebt om je AI-toepassingen productieklaar te maken.
## Belangrijkste kenmerken

- **async-first** - workflows zijn opgebouwd rond de async-functionaliteit van Python - stappen zijn async-functies die inkomende events verwerken vanuit een asyncio-queue en nieuwe events naar andere queues sturen. Dit betekent ook dat workflows het beste werken in je async-apps zoals FastAPI, Jupyter Notebooks, enz.
- **event-driven** - workflows bestaan uit stappen en events. Je code organiseren rond events en stappen maakt het makkelijker om te begrijpen en te testen.
- **statemanagement** - elke uitvoering van een workflow is zelfvoorzienend, wat betekent dat je een workflow kunt starten, informatie erin kunt opslaan, de status van een workflow kunt serialiseren en deze later kunt hervatten.
- **observability** - workflows worden automatisch geïnstrumenteerd voor observability, wat betekent dat je tools zoals `Arize Phoenix` en `OpenTelemetry` direct kunt gebruiken.

## Snel starten

Installeer het pakket:

```bash
pip install llama-index-workflows
```

En maak je eerste workflow aan:

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
    # [optioneel] geef een contextobject aan de workflow
    ctx = Context(workflow)
    result = await workflow.run(input_msg="Hallo, wereld!", ctx=ctx)
    print("Workflowresultaat:", result)

    # opnieuw uitvoeren met dezelfde context behoudt de toestand
    result = await workflow.run(input_msg="Hallo, wereld!", ctx=ctx)
    print("Workflowresultaat:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

In het bovenstaande voorbeeld
- Stappen die een `StartEvent` accepteren, worden als eerste uitgevoerd.
- Stappen die een `StopEvent` retourneren, beëindigen de workflow.
- Intermediaire events zijn door de gebruiker gedefinieerd en kunnen worden gebruikt om informatie tussen stappen door te geven.
- Het `Context`-object wordt ook gebruikt om informatie tussen stappen te delen.

Bezoek de [volledige documentatie](https://docs.llamaindex.ai/en/stable/understanding/workflows/) voor meer voorbeelden met `llama-index`!
## Meer voorbeelden

- [Basisfuncties Overzicht](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Een Function Calling Agent bouwen met `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Mens-in-de-lus Iteratieve Documentextractie](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Observeerbaarheid
  - [OpenTelemetry + Instrumentatie Introductie](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Gerelateerde Pakketten

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---