# LlamaIndex Workflows

[![Testes Unitários](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Status de Cobertura](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![Contribuidores do GitHub](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Downloads](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows são um framework para orquestrar e encadear sistemas complexos de etapas e eventos.

## O que você pode construir com Workflows?

Workflows se destacam quando você precisa orquestrar processos complexos e multi-etapas que envolvem modelos de IA, APIs e tomada de decisão. Aqui estão alguns exemplos do que você pode construir:

- **Agentes de IA** - Crie sistemas inteligentes capazes de raciocinar, tomar decisões e agir em múltiplas etapas
- **Pipelines de Processamento de Documentos** - Construa sistemas que ingerem, analisam, resumem e direcionam documentos por vários estágios de processamento
- **Aplicações de IA Multi-Modelo** - Coordene diferentes modelos de IA (LLMs, modelos de visão, etc.) para resolver tarefas complexas
- **Assistentes de Pesquisa** - Desenvolva workflows capazes de buscar, analisar, sintetizar informações e fornecer respostas abrangentes
- **Sistemas de Geração de Conteúdo** - Crie pipelines que geram, revisam, editam e publicam conteúdo com aprovação humana no processo
- **Automação de Suporte ao Cliente** - Construa sistemas inteligentes de roteamento capazes de entender, categorizar e responder a solicitações de clientes

A arquitetura assíncrona e orientada a eventos facilita a criação de workflows que podem direcionar entre diferentes capacidades, implementar padrões de processamento paralelo, iterar sobre sequências complexas e manter estado ao longo de múltiplas etapas — todos os recursos necessários para tornar suas aplicações de IA prontas para produção.
## Principais Funcionalidades

- **async-first** - os fluxos de trabalho são construídos em torno da funcionalidade assíncrona do Python - os passos são funções assíncronas que processam eventos recebidos de uma fila do asyncio e emitem novos eventos para outras filas. Isso também significa que os fluxos de trabalho funcionam melhor em aplicativos assíncronos como FastAPI, Jupyter Notebooks, etc.
- **orientado a eventos** - os fluxos de trabalho consistem em etapas e eventos. Organizar seu código em torno de eventos e etapas facilita o entendimento e os testes.
- **gerenciamento de estado** - cada execução de um fluxo de trabalho é autocontida, ou seja, você pode iniciar um fluxo de trabalho, salvar informações nele, serializar o estado de um fluxo de trabalho e retomá-lo posteriormente.
- **observabilidade** - os fluxos de trabalho são automaticamente instrumentados para observabilidade, o que significa que você pode usar ferramentas como `Arize Phoenix` e `OpenTelemetry` imediatamente.

## Início Rápido

Instale o pacote:

```bash
pip install llama-index-workflows
```

E crie seu primeiro fluxo de trabalho:

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
        new_msg = f"Processado {len(ev.msg)} vezes, tamanho dos dados: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```python
# [opcional] forneça um objeto de contexto para o fluxo de trabalho
ctx = Context(workflow)
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Resultado do fluxo de trabalho:", result)

# executar novamente com o mesmo contexto irá reter o estado
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Resultado do fluxo de trabalho:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

No exemplo acima
- Etapas que aceitam um `StartEvent` serão executadas primeiro.
- Etapas que retornam um `StopEvent` encerrarão o fluxo de trabalho.
- Eventos intermediários são definidos pelo usuário e podem ser usados para passar informações entre etapas.
- O objeto `Context` também é utilizado para compartilhar informações entre etapas.

Visite a [documentação completa](https://docs.llamaindex.ai/en/stable/understanding/workflows/) para mais exemplos usando `llama-index`!

## Mais exemplos

- [Apresentação dos Recursos Básicos](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Construindo um Agente de Chamadas de Função com `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Extração Iterativa de Documentos com Humano no Loop](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Observabilidade
  - [Introdução ao OpenTelemetry + Instrumentação](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Pacotes Relacionados

- [Workflows Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---