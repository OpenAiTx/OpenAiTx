# LlamaIndex Workflows

[![Testy jednostkowe](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Status pokrycia](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![Współtwórcy GitHub](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Pobrania](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows to framework do orkiestracji i łączenia złożonych systemów kroków i zdarzeń.

## Co można zbudować za pomocą Workflows?

Workflows sprawdza się, gdy potrzebujesz orkiestracji złożonych, wieloetapowych procesów z udziałem modeli AI, API i podejmowania decyzji. Oto kilka przykładów tego, co możesz zbudować:

- **Agenci AI** – Twórz inteligentne systemy, które potrafią rozumować, podejmować decyzje i wykonywać działania w wielu krokach
- **Potoki przetwarzania dokumentów** – Buduj systemy, które pobierają, analizują, podsumowują i przekazują dokumenty przez różne etapy przetwarzania
- **Wielomodelowe aplikacje AI** – Koordynuj współpracę różnych modeli AI (LLM, modele wizji komputerowej itd.) do rozwiązywania złożonych zadań
- **Asystenci badawczy** – Twórz workflowy, które potrafią wyszukiwać, analizować, syntetyzować informacje i udzielać kompleksowych odpowiedzi
- **Systemy generowania treści** – Twórz potoki, które generują, recenzują, edytują i publikują treści z udziałem człowieka w procesie zatwierdzania
- **Automatyzacja wsparcia klienta** – Buduj inteligentne systemy kierowania, które potrafią rozumieć, kategoryzować i odpowiadać na zapytania klientów

Asynchroniczna, zdarzeniowa architektura sprawia, że łatwo budować workflowy, które mogą kierować pomiędzy różnymi możliwościami, wdrażać wzorce przetwarzania równoległego, powtarzać złożone sekwencje i utrzymywać stan przez wiele kroków – wszystkie funkcje potrzebne do przygotowania Twoich aplikacji AI do produkcji.
## Kluczowe funkcje

- **async-first** - workflowy są oparte na funkcjonalności async Pythona – kroki to asynchroniczne funkcje przetwarzające nadchodzące zdarzenia z kolejki asyncio i emitujące nowe zdarzenia do innych kolejek. Oznacza to również, że workflowy najlepiej działają w Twoich asynchronicznych aplikacjach, takich jak FastAPI, Jupyter Notebooks itp.
- **sterowanie zdarzeniami** - workflowy składają się z kroków i zdarzeń. Organizowanie kodu wokół zdarzeń i kroków ułatwia zrozumienie oraz testowanie.
- **zarządzanie stanem** - każde uruchomienie workflowa jest samodzielne, co oznacza, że możesz uruchomić workflow, zapisać w nim informacje, zserializować stan workflowa i wznowić go później.
- **obserwowalność** - workflowy są automatycznie instrumentowane pod kątem obserwowalności, co oznacza, że możesz od razu korzystać z narzędzi takich jak `Arize Phoenix` i `OpenTelemetry`.

## Szybki start

Zainstaluj pakiet:

```bash
pip install llama-index-workflows
```

I utwórz swój pierwszy workflow:

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
# [opcjonalnie] przekaż obiekt kontekstu do workflow
ctx = Context(workflow)
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Wynik workflow:", result)

# ponowne uruchomienie z tym samym kontekstem zachowa stan
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Wynik workflow:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

W powyższym przykładzie
- Kroki akceptujące `StartEvent` zostaną uruchomione jako pierwsze.
- Kroki zwracające `StopEvent` zakończą workflow.
- Zdarzenia pośrednie są definiowane przez użytkownika i mogą być wykorzystywane do przekazywania informacji pomiędzy krokami.
- Obiekt `Context` jest również używany do dzielenia się informacjami między krokami.

Odwiedź [pełną dokumentację](https://docs.llamaindex.ai/en/stable/understanding/workflows/), aby zobaczyć więcej przykładów użycia `llama-index`!

## Więcej przykładów

- [Podstawowy przegląd funkcji](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [Budowanie agenta wywołującego funkcje z `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [Iteracyjne wydobywanie dokumentów z udziałem człowieka w pętli](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Obserwowalność
  - [OpenTelemetry + Wprowadzenie do instrumentacji](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## Powiązane pakiety

- [Workflows w Typescripcie](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---