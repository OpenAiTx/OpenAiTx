# LlamaIndex Workflows

[![Tests unitaires](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Statut de la couverture](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![Contributeurs GitHub](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Téléchargements](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows est un framework pour orchestrer et enchaîner des systèmes complexes d'étapes et d'événements.

## Que pouvez-vous construire avec Workflows ?

Workflows brillent lorsque vous avez besoin d'orchestrer des processus complexes en plusieurs étapes impliquant des modèles d'IA, des API et de la prise de décision. Voici quelques exemples de ce que vous pouvez construire :

- **Agents IA** - Créez des systèmes intelligents capables de raisonner, prendre des décisions et effectuer des actions sur plusieurs étapes
- **Pipelines de traitement de documents** - Construisez des systèmes qui ingèrent, analysent, résument et dirigent les documents à travers différentes étapes de traitement
- **Applications IA multi-modèles** - Coordonnez différents modèles d'IA (LLM, modèles de vision, etc.) pour résoudre des tâches complexes
- **Assistants de recherche** - Développez des workflows capables de rechercher, analyser, synthétiser l'information et fournir des réponses complètes
- **Systèmes de génération de contenu** - Créez des pipelines qui génèrent, relisent, éditent et publient du contenu avec une validation humaine
- **Automatisation du support client** - Construisez des systèmes de routage intelligents capables de comprendre, catégoriser et répondre aux demandes des clients

L'architecture orientée événements et asynchrone facilite la création de workflows capables de s'orienter entre différentes capacités, d'implémenter des modèles de traitement parallèle, de boucler sur des séquences complexes et de maintenir un état sur plusieurs étapes – toutes les fonctionnalités dont vous avez besoin pour rendre vos applications IA prêtes pour la production.
## Fonctionnalités Clés

- **async-first** - les workflows sont conçus autour de la fonctionnalité async de Python : les étapes sont des fonctions asynchrones qui traitent les événements entrants depuis une file asyncio et émettent de nouveaux événements vers d'autres files. Cela signifie également que les workflows fonctionnent au mieux dans vos applications async comme FastAPI, Jupyter Notebooks, etc.
- **orienté événement** - les workflows sont constitués d'étapes et d'événements. Organiser votre code autour des événements et des étapes facilite la compréhension et les tests.
- **gestion d'état** - chaque exécution d'un workflow est autonome, ce qui signifie que vous pouvez lancer un workflow, sauvegarder des informations à l'intérieur, sérialiser l'état d'un workflow et le reprendre plus tard.
- **observabilité** - les workflows sont automatiquement instrumentés pour l'observabilité, ce qui signifie que vous pouvez utiliser des outils comme `Arize Phoenix` et `OpenTelemetry` dès l'installation.

## Démarrage Rapide

Installez le package :

```bash
pip install llama-index-workflows
```

Et créez votre premier workflow :

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
    # [optionnel] fournir un objet contexte au workflow
    ctx = Context(workflow)
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Résultat du workflow :", result)

    # relancer avec le même contexte conservera l'état
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("Résultat du workflow :", result)

if __name__ == "__main__":
    asyncio.run(main())
```

Dans l'exemple ci-dessus :
- Les étapes qui acceptent un `StartEvent` seront exécutées en premier.
- Les étapes qui renvoient un `StopEvent` termineront le workflow.
- Les événements intermédiaires sont définis par l'utilisateur et peuvent être utilisés pour transmettre des informations entre les étapes.
- L'objet `Context` est également utilisé pour partager des informations entre les étapes.

Consultez la [documentation complète](https://docs.llamaindex.ai/en/stable/understanding/workflows/) pour plus d'exemples utilisant `llama-index` !
## Plus d'exemples

- [Présentation des fonctionnalités de base](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Créer un agent d'appel de fonction avec `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Extraction de documents itérative avec intervention humaine](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Observabilité
  - [Introduction à OpenTelemetry + Instrumentation](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Packages associés

- [Workflows Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---