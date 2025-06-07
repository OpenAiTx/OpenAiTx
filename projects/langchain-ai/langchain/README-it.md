<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="Logo LangChain" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![Note di rilascio](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - Licenza](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Download](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![Grafico stelle GitHub](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Problemi aperti](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Apri in Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Apri in Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> Cerchi la libreria JS/TS? Dai un'occhiata a [LangChain.js](https://github.com/langchain-ai/langchainjs).

LangChain è un framework per la creazione di applicazioni alimentate da LLM. Ti aiuta a concatenare componenti interoperabili e integrazioni di terze parti per semplificare lo sviluppo di applicazioni AI, garantendo allo stesso tempo decisioni a prova di futuro man mano che la tecnologia sottostante si evolve.

```bash
pip install -U langchain
```

Per saperne di più su LangChain, consulta
[la documentazione](https://python.langchain.com/docs/introduction/). Se cerchi una personalizzazione più avanzata o orchestrazione di agenti, dai un'occhiata a
[LangGraph](https://langchain-ai.github.io/langgraph/), il nostro framework per la creazione di workflow di agenti controllabili.

## Perché usare LangChain?

LangChain aiuta gli sviluppatori a costruire applicazioni basate su LLM tramite un'interfaccia standard per modelli, embedding, archivi vettoriali e altro.

Usa LangChain per:
- **Arricchimento dati in tempo reale**. Collega facilmente i LLM a diverse fonti di dati e sistemi esterni/interni, sfruttando l'ampia libreria di integrazioni di LangChain con provider di modelli, strumenti, archivi vettoriali, recuperatori e altro.
- **Interoperabilità dei modelli**. Sostituisci i modelli in base agli esperimenti del tuo team di ingegneri per trovare la scelta migliore per le esigenze della tua applicazione. Man mano che l'industria evolve, adatta rapidamente — le astrazioni di LangChain ti permettono di continuare senza perdere slancio.

## Ecosistema di LangChain
Sebbene il framework LangChain possa essere utilizzato autonomamente, si integra perfettamente con qualsiasi prodotto LangChain, offrendo agli sviluppatori una suite completa di strumenti per la creazione di applicazioni LLM.

Per migliorare lo sviluppo delle tue applicazioni LLM, abbina LangChain a:

- [LangSmith](http://www.langchain.com/langsmith) - Utile per la valutazione degli agenti e l'osservabilità. Debug delle esecuzioni LLM con scarse prestazioni, valutazione delle traiettorie degli agenti, visibilità in produzione e miglioramento delle prestazioni nel tempo.
- [LangGraph](https://langchain-ai.github.io/langgraph/) - Crea agenti in grado di gestire compiti complessi in modo affidabile con LangGraph, il nostro framework di orchestrazione agenti a basso livello. LangGraph offre architettura personalizzabile, memoria a lungo termine e workflow human-in-the-loop — ed è utilizzato in produzione da aziende come LinkedIn, Uber, Klarna e GitLab.
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - Distribuisci e scala agenti facilmente con una piattaforma di deployment dedicata per workflow long running e stateful. Scopri, riutilizza, configura e condividi agenti tra i team — e itera velocemente con prototipazione visuale in
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/).

## Risorse aggiuntive
- [Tutorial](https://python.langchain.com/docs/tutorials/): Guide semplici con esempi guidati per iniziare con LangChain.
- [Guide operative](https://python.langchain.com/docs/how_to/): Snippet di codice rapidi e pratici su argomenti come chiamata di strumenti, casi d'uso RAG e altro.
- [Guide concettuali](https://python.langchain.com/docs/concepts/): Spiegazioni dei concetti chiave alla base del framework LangChain.
- [Riferimento API](https://python.langchain.com/api_reference/): Riferimento dettagliato per navigare tra i pacchetti base e le integrazioni di LangChain.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---