# LlamaIndex Workflows

[![Unit Testing](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Coverage Status](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub contributors](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Downloads](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows es un marco para orquestar y encadenar sistemas complejos de pasos y eventos.

## ¿Qué puedes construir con Workflows?

Workflows destaca cuando necesitas orquestar procesos complejos de múltiples pasos que involucran modelos de IA, APIs y toma de decisiones. Aquí tienes algunos ejemplos de lo que puedes construir:

- **Agentes de IA** - Crea sistemas inteligentes capaces de razonar, tomar decisiones y realizar acciones a lo largo de múltiples pasos
- **Pipelines de Procesamiento de Documentos** - Construye sistemas que ingieran, analicen, resuman y enruten documentos a través de varias etapas de procesamiento
- **Aplicaciones de IA Multimodelo** - Coordina entre diferentes modelos de IA (LLMs, modelos de visión, etc.) para resolver tareas complejas
- **Asistentes de Investigación** - Desarrolla workflows que puedan buscar, analizar, sintetizar información y proporcionar respuestas completas
- **Sistemas de Generación de Contenido** - Crea pipelines que generen, revisen, editen y publiquen contenido con aprobación humana en el proceso
- **Automatización de Soporte al Cliente** - Construye sistemas inteligentes de enrutamiento capaces de entender, categorizar y responder a consultas de clientes

La arquitectura asíncrona y orientada a eventos facilita la creación de workflows que pueden enrutar entre diferentes capacidades, implementar patrones de procesamiento en paralelo, iterar sobre secuencias complejas y mantener el estado a lo largo de múltiples pasos; todas las funciones que necesitas para que tus aplicaciones de IA estén listas para producción.
## Características Clave

- **async-first** - los flujos de trabajo están construidos en torno a la funcionalidad async de Python: los pasos son funciones async que procesan eventos entrantes desde una cola de asyncio y emiten nuevos eventos a otras colas. Esto también significa que los flujos de trabajo funcionan mejor en tus aplicaciones async como FastAPI, Jupyter Notebooks, etc.
- **orientado a eventos** - los flujos de trabajo consisten en pasos y eventos. Organizar tu código en torno a eventos y pasos facilita el razonamiento y las pruebas.
- **gestión de estado** - cada ejecución de un flujo de trabajo es autocontenida, lo que significa que puedes lanzar un flujo de trabajo, guardar información dentro de él, serializar el estado de un flujo de trabajo y reanudarlo más tarde.
- **observabilidad** - los flujos de trabajo están instrumentados automáticamente para la observabilidad, lo que significa que puedes usar herramientas como `Arize Phoenix` y `OpenTelemetry` directamente sin configuración adicional.

## Inicio Rápido

Instala el paquete:

```bash
pip install llama-index-workflows
```

Y crea tu primer flujo de trabajo:

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
        new_msg = f"Procesado {len(ev.msg)} veces, longitud de datos: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```python
# [opcional] proporciona un objeto de contexto al flujo de trabajo
ctx = Context(workflow)
result = await workflow.run(input_msg="¡Hola, mundo!", ctx=ctx)
print("Resultado del flujo de trabajo:", result)

# volver a ejecutar con el mismo contexto mantendrá el estado
result = await workflow.run(input_msg="¡Hola, mundo!", ctx=ctx)
print("Resultado del flujo de trabajo:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

En el ejemplo anterior
- Los pasos que aceptan un `StartEvent` se ejecutarán primero.
- Los pasos que devuelven un `StopEvent` finalizarán el flujo de trabajo.
- Los eventos intermedios son definidos por el usuario y pueden utilizarse para pasar información entre pasos.
- El objeto `Context` también se utiliza para compartir información entre pasos.

¡Visita la [documentación completa](https://docs.llamaindex.ai/en/stable/understanding/workflows/) para más ejemplos usando `llama-index`!

## Más ejemplos

- [Recorrido de funciones básicas](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Construcción de un agente para llamadas de funciones con `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Extracción iterativa de documentos con humano en el bucle](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Observabilidad
  - [Introducción a OpenTelemetry + Instrumentación](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Paquetes relacionados

- [Workflows en Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---