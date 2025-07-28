
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Documento Dettagliato] https://deepwiki.com/JetXu-LLM/llama-github

[![Versione PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Download](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licenza](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github è un potente strumento che ti aiuta a recuperare (basato su Agentic RAG) i frammenti di codice, le issue e le informazioni sui repository più rilevanti da GitHub in base alle tue query, trasformandoli in un contesto di conoscenza prezioso. Potenzia Chatbot LLM, Agenti AI e Auto-dev Agent per risolvere compiti di codifica complessi. Che tu sia uno sviluppatore alla ricerca di soluzioni rapide o un ingegnere che implementa avanzati Agenti AI per Auto Dev, llama-github rende tutto semplice ed efficiente.

Se ti piace questo progetto o pensi che abbia del potenziale, lasciaci una ⭐️. Il tuo supporto è la nostra più grande motivazione!

## Architettura
![Architettura di Alto Livello](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Installazione
```
pip install llama-github
```

## Utilizzo

Ecco un semplice esempio su come utilizzare llama-github:

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```

Per un utilizzo più avanzato ed esempi, consulta la [documentazione](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Caratteristiche Principali

- **🔍 Recupero Intelligente da GitHub**: Sfrutta la potenza di llama-github per recuperare snippet di codice, issue e informazioni sui repository altamente pertinenti da GitHub in base alle richieste dell’utente. Le nostre tecniche avanzate di recupero assicurano che tu possa trovare rapidamente ed efficientemente le informazioni più rilevanti.

- **⚡ Caching del Pool di Repository**: Llama-github possiede un innovativo meccanismo di caching del pool di repository. Caching dei repository (inclusi README, strutture, codice e issue) attraverso i thread, llama-github accelera notevolmente l’efficienza del recupero delle ricerche su GitHub e minimizza il consumo di token API GitHub. Distribuisci llama-github in ambienti di produzione multi-thread con fiducia, sapendo che funzionerà al meglio e ti farà risparmiare risorse preziose.

- **🧠 Analisi delle Domande Basata su LLM**: Sfrutta modelli linguistici all’avanguardia per analizzare le domande degli utenti e generare strategie e criteri di ricerca altamente efficaci. Llama-github scompone intelligentemente query complesse, assicurando che tu possa recuperare le informazioni più pertinenti dalla vasta rete di repository di GitHub.

- **📚 Generazione di Contesto Completa**: Genera risposte ricche e contestualmente rilevanti combinando senza problemi le informazioni recuperate da GitHub con le capacità di ragionamento dei modelli linguistici avanzati. Llama-github eccelle nella gestione di domande anche molto complesse e lunghe, fornendo risposte approfondite e ricche di contesto per supportare le tue esigenze di sviluppo.

- **🚀 Eccellenza nell’Elaborazione Asincrona**: Llama-github è costruito da zero per sfruttare il pieno potenziale della programmazione asincrona. Con meccanismi asincroni implementati meticolosamente in tutto il codice, llama-github può gestire più richieste contemporaneamente, aumentando notevolmente le prestazioni complessive. Prova la differenza mentre llama-github gestisce efficientemente carichi di lavoro elevati senza compromettere velocità o qualità.

- **🔧 Integrazione Flessibile con LLM**: Integra facilmente llama-github con diversi provider LLM, modelli di embedding e modelli di reranking per adattare le capacità della libreria ai tuoi requisiti specifici. La nostra architettura estensibile ti consente di personalizzare e migliorare le funzionalità di llama-github, assicurando un’integrazione fluida con il tuo ambiente di sviluppo.

- **🔒 Opzioni di Autenticazione Robuste**: Llama-github supporta sia i token di accesso personale sia l’autenticazione tramite GitHub App, offrendoti la flessibilità per integrarlo in diversi ambienti di sviluppo. Che tu sia uno sviluppatore individuale o lavori in un contesto organizzativo, llama-github ti offre meccanismi di autenticazione sicuri e affidabili.

- **🛠️ Logging e Gestione Errori**: Comprendiamo l’importanza di un funzionamento fluido e di una facile risoluzione dei problemi. Per questo llama-github è dotato di meccanismi completi di logging e gestione degli errori. Ottieni approfondimenti dettagliati sul comportamento della libreria, diagnostica rapidamente i problemi e mantieni un workflow di sviluppo stabile e affidabile.

## 🤖 Prova il Nostro Assistant AI per la Revisione PR: LlamaPReview

Se trovi utile llama-github, potresti essere interessato anche al nostro assistente AI per la revisione di PR su GitHub, LlamaPReview. È progettato per integrare il tuo workflow di sviluppo e migliorare ulteriormente la qualità del codice.

### Caratteristiche Principali di LlamaPReview:
- 🚀 Installazione con un clic, nessuna configurazione richiesta, esecuzione completamente automatica
- 💯 Attualmente gratuito - nessuna carta di credito o pagamento richiesto
- 🧠 Recensioni PR automatiche, basate su AI, con profonda comprensione del codice
- 🌐 Supporta molteplici linguaggi di programmazione

**LlamaPReview utilizza il recupero di contesto avanzato e l’analisi LLM di llama-github** per offrire revisioni intelligenti e consapevoli del contesto. È come avere un senior developer, armato del contesto completo del tuo repository, che rivede ogni PR automaticamente!

👉 [Installa LlamaPReview Ora](https://github.com/marketplace/llamapreview/) (Gratis)

Utilizzando llama-github per il recupero del contesto e LlamaPReview per le revisioni del codice, puoi creare un potente ambiente di sviluppo potenziato dall’AI.

## Visione e Roadmap

### Visione

La nostra visione è diventare un modulo fondamentale nel futuro delle soluzioni di sviluppo guidate dall’AI, integrandoci perfettamente con GitHub per consentire agli LLM di risolvere automaticamente compiti di coding complessi.

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Roadmap

Per una panoramica dettagliata della nostra roadmap, visita il nostro [Project Roadmap](https://github.com/users/JetXu-LLM/projects/2).

## Riconoscimenti

Desideriamo esprimere la nostra gratitudine ai seguenti progetti open-source per il loro supporto e contributo:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Per aver fornito il framework di base che potenzia le capacità di prompting e processing LLM in llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Per aver offerto API s.jina.ai e modelli open source di reranking ed embedding che migliorano la precisione e la pertinenza dei contesti generati in llama-github.

I loro contributi sono stati fondamentali per lo sviluppo di llama-github e raccomandiamo vivamente di esplorare i loro progetti per altre soluzioni innovative.

## Contribuire

Accogliamo con piacere i contributi a llama-github! Consulta le nostre [linee guida per i contributi](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) per maggiori informazioni.

## Licenza

Questo progetto è rilasciato secondo i termini della licenza Apache 2.0. Consulta il file [LICENSE](LICENSE) per maggiori dettagli.

## Contatti

Se hai domande, suggerimenti o feedback, sentiti libero di contattarci a [l’email di Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Grazie per aver scelto llama-github! Speriamo che questa libreria migliori la tua esperienza di sviluppo AI e ti aiuti a costruire potenti applicazioni con facilità.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---