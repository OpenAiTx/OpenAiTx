
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Documento Dettagliato] https://deepwiki.com/JetXu-LLM/llama-github

[![Versione PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Download](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licenza](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github è uno strumento potente che ti aiuta a recuperare (basato su Agentic RAG) i frammenti di codice più rilevanti, problemi e informazioni sui repository da GitHub in base alle tue richieste, trasformandoli in un prezioso contesto di conoscenza. Potenzia Chatbot LLM, Agenti AI e Auto-dev Agents per risolvere compiti di programmazione complessi. Che tu sia uno sviluppatore in cerca di soluzioni rapide o un ingegnere che implementa avanzati Auto Dev AI Agents, llama-github rende tutto facile ed efficiente.

Se ti piace questo progetto o pensi che abbia del potenziale, lasciagli una ⭐️. Il tuo supporto è la nostra più grande motivazione!

## Architettura
![Architettura di Alto Livello](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Installazione
```
pip install llama-github
```

Target attuale di runtime mantenuto: Python `3.10+`.

## Utilizzo

Ecco un semplice esempio di come usare llama-github:

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

`retrieve_context()` restituisce un elenco di dizionari di contesto. Ogni elemento contiene almeno `context` e `url`.

Per un utilizzo più avanzato ed esempi, consulta la [documentazione](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Esempi eseguibili a basso costo sono disponibili anche in [`examples/`](examples).

## Caratteristiche Principali

- **🔍 Recupero Intelligente da GitHub**: Sfrutta la potenza di llama-github per recuperare frammenti di codice altamente pertinenti, issue e informazioni sui repository da GitHub in base alle richieste dell’utente. Le nostre tecniche avanzate di recupero ti garantiscono di trovare rapidamente ed efficientemente le informazioni più rilevanti.

- **⚡ Caching del Pool di Repository**: Llama-github dispone di un innovativo meccanismo di caching del pool di repository. Memorizzando nella cache i repository (inclusi README, strutture, codice e issue) tra i thread, llama-github accelera notevolmente l’efficienza della ricerca su GitHub e riduce al minimo il consumo dei token API di GitHub.

- **🧠 Analisi delle Domande Alimentata da LLM**: Sfrutta i più avanzati modelli linguistici per analizzare le domande degli utenti e generare strategie e criteri di ricerca estremamente efficaci. Llama-github scompone in modo intelligente le query complesse, assicurando il recupero delle informazioni più rilevanti dalla vasta rete di repository di GitHub.

- **📚 Generazione di Contesto Completa**: Genera risposte ricche e contestualmente pertinenti combinando senza soluzione di continuità le informazioni recuperate da GitHub con le capacità di ragionamento dei modelli linguistici avanzati. Llama-github eccelle nella gestione di domande anche molto complesse e lunghe, fornendo risposte complete e approfondite con ampio contesto a supporto delle tue esigenze di sviluppo.

- **🚀 Eccellenza nell’Elaborazione Asincrona**: Llama-github è stato progettato da zero per sfruttare al massimo il potenziale della programmazione asincrona. Grazie a meccanismi asincroni implementati meticolosamente in tutto il codice, llama-github può gestire più richieste contemporaneamente, aumentando notevolmente le prestazioni complessive.

- **🔧 Integrazione Flessibile con LLM**: Integra facilmente llama-github con vari provider LLM, modelli di embedding, modelli di reranking o un modello chat compatibile con LangChain iniettato, per adattare le capacità della libreria alle tue specifiche esigenze.

- **🔒 Opzioni di Autenticazione Robuste**: Llama-github supporta sia token di accesso personali che autenticazione tramite GitHub App, offrendo flessibilità di integrazione in diversi contesti di sviluppo. Che tu sia uno sviluppatore singolo o lavori in un'organizzazione, llama-github ti offre meccanismi di autenticazione sicuri ed affidabili.

- **🛠️ Logging e Gestione degli Errori**: Sappiamo quanto siano importanti le operazioni fluide e la facile risoluzione dei problemi. Per questo llama-github è dotato di un sistema completo di logging e gestione degli errori. Ottieni profonde informazioni sul comportamento della libreria, diagnostica rapidamente i problemi e mantieni un flusso di lavoro di sviluppo stabile e affidabile.

## 🤖 Prova il Nostro Assistente di Revisione PR AI: LlamaPReview

Se trovi utile llama-github, potresti essere interessato anche al nostro assistente AI per la revisione delle PR su GitHub, LlamaPReview. È progettato per completare il tuo flusso di lavoro di sviluppo e migliorare ulteriormente la qualità del codice.

### Caratteristiche Principali di LlamaPReview:
- 🚀 Installazione con un clic, nessuna configurazione richiesta, esecuzione completamente automatica
- 💯 Attualmente gratuito - nessuna carta di credito o info di pagamento richiesta
- 🧠 Revisioni PR automatiche alimentate da AI con profonda comprensione del codice
- 🌐 Supporta molteplici linguaggi di programmazione

**LlamaPReview utilizza il recupero di contesto avanzato e l’analisi LLM di llama-github** per fornire revisioni del codice intelligenti e consapevoli del contesto. È come avere uno sviluppatore senior, armato del pieno contesto del tuo repository, che revisiona ogni PR automaticamente!

👉 [Installa LlamaPReview Ora](https://github.com/marketplace/llamapreview/) (Gratis)

Utilizzando llama-github per il recupero del contesto e LlamaPReview per le revisioni del codice, puoi creare un potente ambiente di sviluppo potenziato dall’IA.

## Vision e Roadmap

### Visione

La nostra visione è diventare un modulo fondamentale nel futuro delle soluzioni di sviluppo guidate dall’IA, integrandoci perfettamente con GitHub per consentire agli LLM di risolvere automaticamente compiti di codifica complessi.

![Architettura della Visione](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Roadmap

Per una panoramica storica della roadmap precedente, visita [Vision and Roadmap](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Ringraziamenti

Vorremmo esprimere la nostra gratitudine ai seguenti progetti open-source per il loro supporto e contributo:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Per aver fornito il framework di base che potenzia le capacità di prompting e processing degli LLM in llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Per aver messo a disposizione l’API s.jina.ai e modelli open source di reranker ed embedding che migliorano l’accuratezza e la rilevanza dei contesti generati in llama-github.

I loro contributi sono stati fondamentali per lo sviluppo di llama-github e consigliamo vivamente di consultare i loro progetti per soluzioni ancora più innovative.

## Contribuire

Siamo lieti di accogliere contributi a llama-github! Consulta le nostre [linee guida per i contributori](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) per ulteriori informazioni.

## Licenza

Questo progetto è concesso in licenza secondo i termini della licenza Apache 2.0. Consulta il file [LICENSE](LICENSE) per maggiori dettagli.

## Contatti

Se hai domande, suggerimenti o feedback, non esitare a contattarci all’indirizzo email di [Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Grazie per aver scelto llama-github! Speriamo che questa libreria migliori la tua esperienza nello sviluppo AI e ti aiuti a costruire potenti applicazioni con facilità.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---