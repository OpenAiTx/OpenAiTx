# LlamaIndex Workflows

[![Модульное тестирование](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Статус покрытия](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![Участники GitHub](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Загрузки](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows — это фреймворк для оркестрации и объединения в цепочки сложных систем из шагов и событий.

## Что можно создавать с помощью Workflows?

Workflows особенно полезны, когда необходимо оркестрировать сложные многошаговые процессы, включающие AI-модели, API и принятие решений. Вот несколько примеров того, что вы можете создать:

- **AI-агенты** — создание интеллектуальных систем, способных рассуждать, принимать решения и выполнять действия в несколько шагов
- **Конвейеры обработки документов** — построение систем, которые загружают, анализируют, суммируют и направляют документы через различные этапы обработки
- **Мультимодельные AI-приложения** — координация между различными AI-моделями (LLM, компьютерное зрение и др.) для решения сложных задач
- **Ассистенты для исследований** — разработка workflow, которые могут искать, анализировать, синтезировать информацию и предоставлять комплексные ответы
- **Системы генерации контента** — создание конвейеров, которые генерируют, проверяют, редактируют и публикуют контент с возможностью согласования человеком
- **Автоматизация поддержки клиентов** — построение интеллектуальных систем маршрутизации, способных понимать, классифицировать и отвечать на запросы клиентов

Асинхронная, событийно-ориентированная архитектура облегчает создание workflow, которые могут маршрутизировать между различными возможностями, реализовывать параллельную обработку, выполнять циклы по сложным последовательностям и сохранять состояние между шагами — все функции, необходимые для того, чтобы ваши AI-приложения были готовы к промышленной эксплуатации.
## Ключевые особенности

- **async-first** - рабочие процессы построены вокруг асинхронной функциональности Python: шаги — это асинхронные функции, которые обрабатывают входящие события из очереди asyncio и отправляют новые события в другие очереди. Это также означает, что рабочие процессы лучше всего работают в ваших асинхронных приложениях, таких как FastAPI, Jupyter Notebooks и т.д.
- **ориентированность на события** - рабочие процессы состоят из шагов и событий. Организация кода вокруг событий и шагов облегчает понимание и тестирование.
- **управление состоянием** - каждый запуск рабочего процесса автономен, то есть вы можете запустить рабочий процесс, сохранить в нем информацию, сериализовать состояние рабочего процесса и возобновить его позже.
- **наблюдаемость** - рабочие процессы автоматически инструментируются для наблюдаемости, что позволяет использовать такие инструменты, как `Arize Phoenix` и `OpenTelemetry` прямо «из коробки».

## Быстрый старт

Установите пакет:

```bash
pip install llama-index-workflows
```

И создайте свой первый рабочий процесс:

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
# [необязательно] предоставьте объект контекста для рабочего процесса
ctx = Context(workflow)
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

# повторный запуск с тем же контекстом сохранит состояние
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

В приведённом выше примере
- Шаги, которые принимают `StartEvent`, будут выполнены первыми.
- Шаги, возвращающие `StopEvent`, завершат рабочий процесс.
- Промежуточные события определяются пользователем и могут использоваться для передачи информации между шагами.
- Объект `Context` также используется для обмена информацией между шагами.

Посетите [полную документацию](https://docs.llamaindex.ai/en/stable/understanding/workflows/) для получения дополнительных примеров использования `llama-index`!

## Дополнительные примеры

- [Базовый обзор функций](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Создание агента для вызова функций с помощью `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Итеративное извлечение документов с участием человека в цикле](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Наблюдаемость
  - [Введение в OpenTelemetry и инструментирование](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Связанные пакеты

- [Workflows на Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---