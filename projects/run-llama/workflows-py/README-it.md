# LlamaIndex Workflows

[![Unit Testing](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Coverage Status](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub contributors](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Downloads](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows è un framework per orchestrare e concatenare sistemi complessi di passaggi ed eventi.

## Cosa puoi costruire con Workflows?

Workflows dà il meglio di sé quando hai bisogno di orchestrare processi complessi e multi-step che coinvolgono modelli di intelligenza artificiale, API e processi decisionali. Ecco alcuni esempi di ciò che puoi costruire:

- **Agenti AI** - Crea sistemi intelligenti in grado di ragionare, prendere decisioni e agire attraverso molteplici passaggi
- **Pipeline di elaborazione documentale** - Costruisci sistemi che acquisiscono, analizzano, sintetizzano e instradano documenti attraverso varie fasi di elaborazione
- **Applicazioni AI multi-modello** - Coordina diversi modelli AI (LLM, modelli di visione, ecc.) per risolvere compiti complessi
- **Assistenti di ricerca** - Sviluppa workflow che possono cercare, analizzare, sintetizzare informazioni e fornire risposte complete
- **Sistemi di generazione di contenuti** - Crea pipeline che generano, revisionano, modificano e pubblicano contenuti con approvazione umana nel loop
- **Automazione del supporto clienti** - Costruisci sistemi di instradamento intelligenti in grado di comprendere, categorizzare e rispondere alle richieste dei clienti

L’architettura asincrona e guidata dagli eventi rende semplice costruire workflow in grado di instradare tra diverse capacità, implementare pattern di elaborazione parallela, eseguire cicli su sequenze complesse e mantenere lo stato attraverso più passaggi - tutte le funzionalità necessarie per rendere pronte per la produzione le tue applicazioni AI.
## Caratteristiche principali

- **async-first** - i workflow sono costruiti attorno alla funzionalità async di Python: i passaggi sono funzioni async che elaborano eventi in arrivo da una coda asyncio ed emettono nuovi eventi verso altre code. Questo significa anche che i workflow funzionano al meglio nelle tue applicazioni async come FastAPI, Jupyter Notebooks, ecc.
- **event-driven** - i workflow sono costituiti da passaggi ed eventi. Organizzare il tuo codice attorno a eventi e passaggi rende più semplice ragionare e testare.
- **gestione dello stato** - ogni esecuzione di un workflow è auto-contenuta, il che significa che puoi avviare un workflow, salvare informazioni al suo interno, serializzare lo stato di un workflow e riprenderlo successivamente.
- **osservabilità** - i workflow sono automaticamente strumentati per l’osservabilità, il che significa che puoi utilizzare strumenti come `Arize Phoenix` e `OpenTelemetry` subito, senza configurazione aggiuntiva.

## Avvio rapido

Installa il pacchetto:

```bash
pip install llama-index-workflows
```

E crea il tuo primo workflow:

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
```python
    # [opzionale] fornire un oggetto contesto al workflow
    ctx = Context(workflow)
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Risultato del workflow:", result)

    # rieseguendo con lo stesso contesto verrà mantenuto lo stato
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Risultato del workflow:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

Nell'esempio sopra
- I passi che accettano un `StartEvent` verranno eseguiti per primi.
- I passi che restituiscono un `StopEvent` termineranno il workflow.
- Gli eventi intermedi sono definiti dall'utente e possono essere usati per passare informazioni tra i passi.
- L'oggetto `Context` viene anche utilizzato per condividere informazioni tra i passi.

Visita la [documentazione completa](https://docs.llamaindex.ai/en/stable/understanding/workflows/) per altri esempi che utilizzano `llama-index`!

## Altri esempi

- [Panoramica delle funzionalità di base](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Creazione di un agente per chiamata di funzioni con `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Estrazione iterativa di documenti con supervisione umana](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Osservabilità
  - [OpenTelemetry + Introduzione all’Instrumentazione](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Pacchetti correlati

- [Workflows Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---