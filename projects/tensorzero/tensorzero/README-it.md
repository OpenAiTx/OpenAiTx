<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero crea un ciclo di feedback per ottimizzare le applicazioni LLM — trasformando i dati di produzione in modelli più intelligenti, veloci ed economici.**

1. Integra il nostro gateway per modelli
2. Invia metriche o feedback
3. Ottimizza prompt, modelli e strategie di inferenza
4. Osserva i tuoi LLM migliorare nel tempo

Fornisce un **flywheel di dati & apprendimento per LLM** unificando:

- [x] **Inferenza:** una sola API per tutti i LLM, con overhead <1ms P99
- [x] **Osservabilità:** inferenza & feedback → il tuo database
- [x] **Ottimizzazione:** dai prompt al fine-tuning e RL
- [x] **Valutazioni:** confronta prompt, modelli, strategie di inferenza
- [x] **Sperimentazione:** A/B testing integrato, routing, fallback

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Sito Web</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Documentazione</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Quick Start (5min)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Tutorial Completo</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Guida al Deployment</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">Riferimento API</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Riferimento Configurazione</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>Cos'è TensorZero?</b></td>
    <td width="70%" valign="top">TensorZero è un framework open-source per costruire applicazioni LLM di livello produzione. Unifica un gateway LLM, osservabilità, ottimizzazione, valutazioni e sperimentazione.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>In cosa è diverso TensorZero dagli altri framework LLM?</b></td>
    <td width="70%" valign="top">
      1. TensorZero ti permette di ottimizzare applicazioni LLM complesse basandoti su metriche di produzione e feedback umano.<br>
      2. TensorZero supporta le esigenze di applicazioni LLM su scala industriale: bassa latenza, alto throughput, type safety, self-hosted, GitOps, personalizzazione, ecc.<br>
      3. TensorZero unifica l'intero stack LLMOps, creando benefici cumulativi. Ad esempio, le valutazioni LLM possono essere usate per il fine-tuning dei modelli insieme a giudici AI.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Posso usare TensorZero con ___?</b></td>
    <td width="70%" valign="top">Sì. Sono supportati tutti i principali linguaggi di programmazione. Puoi usare TensorZero con il nostro client Python, qualsiasi SDK OpenAI o la nostra API HTTP.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero è pronto per la produzione?</b></td>
    <td width="70%" valign="top">Sì. Ecco un case study: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Automazione dei Changelog di Codice in una Grande Banca con LLM</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Quanto costa TensorZero?</b></td>
    <td width="70%" valign="top">Niente. TensorZero è 100% self-hosted e open-source. Non ci sono funzionalità a pagamento.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Chi sviluppa TensorZero?</b></td>
    <td width="70%" valign="top">Il nostro team tecnico include un ex maintainer del compilatore Rust, ricercatori di machine learning (Stanford, CMU, Oxford, Columbia) con migliaia di citazioni, e il chief product officer di una startup decacorno. Siamo sostenuti dagli stessi investitori di progetti open-source leader (es. ClickHouse, CockroachDB) e AI lab (es. OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Come inizio?</b></td>
    <td width="70%" valign="top">Puoi adottare TensorZero in modo incrementale. La nostra <b><a href="https://www.tensorzero.com/docs/quickstart">Guida Rapida</a></b> passa da un semplice wrapper OpenAI a un'applicazione LLM pronta per la produzione con osservabilità e fine-tuning in soli 5 minuti.</td>
  </tr>
</table>

---

## Funzionalità

### 🌐 Gateway LLM

> **Integra TensorZero una sola volta e accedi a tutti i principali provider LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Provider Modelli</b></td>
    <td width="50%" align="center" valign="middle"><b>Funzionalità</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        Il Gateway TensorZero supporta nativamente:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/anthropic">Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-bedrock">AWS Bedrock</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-sagemaker">AWS SageMaker</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/azure">Azure OpenAI Service</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/deepseek">DeepSeek</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/fireworks">Fireworks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-anthropic">GCP Vertex AI Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-gemini">GCP Vertex AI Gemini</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/google-ai-studio-gemini">Google AI Studio (Gemini API)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/hyperbolic">Hyperbolic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/mistral">Mistral</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai">OpenAI</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/together">Together</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/vllm">vLLM</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/xai">xAI</a></b></li>
      </ul>
      <p>
        <em>
          Ti serve qualcos'altro?
          Il tuo provider è molto probabilmente supportato perché TensorZero si integra con <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">qualsiasi API compatibile OpenAI (es. Ollama)</a></b>.
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        Il Gateway TensorZero supporta funzionalità avanzate come:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Retry & Fallback</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Ottimizzazioni in fase di Inferenza</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Template & Schemi Prompt</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Sperimentazione (A/B Testing)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Configuration-as-Code (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Inferenza Batch</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Inferenza Multimodale (VLM)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Caching Inferenza</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Metriche & Feedback</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Workflow LLM Multi-Step (Episodi)</a></b></li>
        <li><em>& molto altro ancora...</em></li>
      </ul>
      <p>
        Il Gateway TensorZero è scritto in Rust 🦀 con <b>prestazioni</b> in mente (<1ms p99 di latenza @ 10k QPS).
        Vedi <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmark</a></b>.<br>
      </p>
      <p>
        Puoi eseguire inferenza usando il <b>client TensorZero</b> (consigliato), il <b>client OpenAI</b>, o la <b>API HTTP</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Utilizzo: Python &mdash; Client TensorZero (Consigliato)</b></summary>

Puoi accedere a qualsiasi provider usando il client Python TensorZero.

1. `pip install tensorzero`
2. Facoltativo: configura TensorZero.
3. Esegui inferenza:

```python
from tensorzero import TensorZeroGateway  # o AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Prova altri provider facilmente: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Scrivi un haiku sull'intelligenza artificiale.",
                }
            ]
        },
    )
```

Consulta **[Guida Rapida](https://www.tensorzero.com/docs/quickstart)** per maggiori informazioni.

</details>

<details>
<summary><b>Utilizzo: Python &mdash; Client OpenAI</b></summary>

Puoi accedere a qualsiasi provider usando il client OpenAI Python con TensorZero.

1. `pip install tensorzero`
2. Facoltativo: configura TensorZero.
3. Esegui inferenza:

```python
from openai import OpenAI  # o AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # Prova facilmente altri provider: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Scrivi un haiku sull'intelligenza artificiale.",
        }
    ],
)
```

Consulta **[Inizio rapido](https://www.tensorzero.com/docs/quickstart)** per ulteriori informazioni.

</details>

<details>
<summary><b>Utilizzo: JavaScript / TypeScript (Node) &mdash; OpenAI Client</b></summary>

Puoi accedere a qualsiasi provider utilizzando il client OpenAI Node con TensorZero.

1. Distribuisci `tensorzero/gateway` tramite Docker.
   **[Istruzioni dettagliate →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Configura TensorZero.
3. Esegui l'inferenza:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Prova facilmente altri provider: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Scrivi un haiku sull'intelligenza artificiale.",
    },
  ],
});
```

Consulta **[Inizio rapido](https://www.tensorzero.com/docs/quickstart)** per ulteriori informazioni.

</details>

<details>
<summary><b>Utilizzo: Altri Linguaggi & Piattaforme &mdash; HTTP API</b></summary>

TensorZero supporta praticamente qualsiasi linguaggio di programmazione o piattaforma tramite la sua HTTP API.

1. Distribuisci `tensorzero/gateway` tramite Docker.
   **[Istruzioni dettagliate →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Facoltativo: configura TensorZero.
3. Esegui l'inferenza:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Scrivi un haiku sull'intelligenza artificiale."
        }
      ]
    }
  }'
```

Consulta **[Inizio rapido](https://www.tensorzero.com/docs/quickstart)** per ulteriori informazioni.

</details>

<br>

### 📈 Ottimizzazione LLM

> **Invia metriche di produzione e feedback umano per ottimizzare facilmente i tuoi prompt, modelli e strategie di inferenza &mdash; tramite UI o programmaticamente.**

#### Ottimizzazione del Modello

Ottimizza modelli closed-source e open-source utilizzando supervised fine-tuning (SFT) e preference fine-tuning (DPO).

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Supervised Fine-tuning &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Preference Fine-tuning (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Ottimizzazione all'Inferenza

Aumenta le prestazioni aggiornando dinamicamente i tuoi prompt con esempi rilevanti, combinando le risposte da più inferenze, e altro ancora.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N Sampling</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N Sampling</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">Dynamic In-Context Learning (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Chain-of-Thought (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_Altre novità in arrivo..._

<br>

#### Ottimizzazione del Prompt

Ottimizza i tuoi prompt in modo programmatico utilizzando tecniche di ottimizzazione basate sulla ricerca.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">Integrazione DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero include diverse ricette di ottimizzazione, ma puoi anche creare facilmente le tue.
      Questo esempio mostra come ottimizzare una funzione TensorZero utilizzando uno strumento arbitrario — in questo caso, DSPy, una libreria popolare per l'automazione dell'ingegneria dei prompt.
    </td>
  </tr>
</table>

_Altre novità in arrivo..._

<br>

### 🔍 Osservabilità LLM

> **Zooma per effettuare il debug delle singole chiamate API, oppure allarga la visuale per monitorare le metriche su modelli e prompt nel tempo &mdash; tutto tramite la UI open-source di TensorZero.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Osservabilità » Inferenza</b></td>
    <td width="50%" align="center" valign="middle"><b>Osservabilità » Funzione</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 Valutazioni LLM

> **Confronta prompt, modelli e strategie di inferenza utilizzando TensorZero Evaluations &mdash; con supporto per euristiche e giudici LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Valutazione » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Valutazione » CLI</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/f4bf54e3-1b63-46c8-be12-2eaabf615699"></td>
    <td width="50%" align="left" valign="middle">
<pre><code class="language-bash">docker compose run --rm evaluations \
  --evaluation-name extract_data \
  --dataset-name hard_test_cases \
  --variant-name gpt_4o \
  --concurrency 5</code></pre>
<pre><code class="language-bash">Run ID: 01961de9-c8a4-7c60-ab8d-15491a9708e4
Number of datapoints: 100
██████████████████████████████████████ 100/100
exact_match: 0.83 ± 0.03
semantic_match: 0,98 ± 0,01  
item_count: 7,15 ± 0,39</code></pre>
    </td>
  </tr>
</table>

## Demo

> **Guarda gli LLM migliorare nell’estrazione dati in tempo reale con TensorZero!**
>
> **[Dynamic in-context learning (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** è una potente ottimizzazione in tempo di inferenza disponibile di default con TensorZero.
> Migliora le prestazioni degli LLM incorporando automaticamente esempi storici rilevanti nel prompt, senza la necessità di effettuare un fine-tuning del modello.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## LLM Engineering con TensorZero

<br>
<p align="center" >
  <a href="https://www.tensorzero.com/docs">
    <picture>
      <source media="(prefers-color-scheme: light)" srcset="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6">
      <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/e8bc699b-6378-4c2a-9cc1-6d189025e270">
      <img alt="TensorZero Flywheel" src="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6" width=720>
    </picture>
  </a>
</p>
<br>

1. Il **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** è un gateway di modelli ad alte prestazioni scritto in Rust 🦀 che fornisce un’interfaccia API unificata per tutti i principali provider LLM, consentendo un’integrazione cross-platform senza soluzione di continuità e fallback automatici.
2. Gestisce inferenze strutturate basate su schema con una latenza P99 &lt;1ms (vedi **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) e offre osservabilità integrata, sperimentazione e **[ottimizzazioni in tempo di inferenza](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. Raccoglie anche metriche a valle e feedback associati a queste inferenze, con supporto di prima classe per sistemi LLM multi-step.
4. Tutto viene archiviato in un data warehouse ClickHouse che controlli tu, per analytics in tempo reale, scalabili e adatti agli sviluppatori.
5. Nel tempo, le **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** sfruttano questo dataset strutturato per ottimizzare i tuoi prompt e modelli: esegui ricette predefinite per workflow comuni come il fine-tuning, oppure crea le tue con totale flessibilità usando qualsiasi linguaggio e piattaforma.
6. Infine, le funzionalità di sperimentazione e l’orchestrazione GitOps del gateway ti permettono di iterare e distribuire con sicurezza, sia che si tratti di un singolo LLM che di migliaia di LLM.

Il nostro obiettivo è aiutare gli ingegneri a costruire, gestire e ottimizzare la prossima generazione di applicazioni LLM: sistemi che apprendono dall’esperienza reale.
Leggi di più sulla nostra **[Visione & Roadmap](https://www.tensorzero.com/docs/vision-roadmap/)**.

## Inizia Subito

**Inizia a costruire oggi stesso.**  
La **[Guida Rapida](https://www.tensorzero.com/docs/quickstart)** mostra quanto sia facile configurare un’applicazione LLM con TensorZero.  
Se vuoi approfondire, il **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)** insegna come costruire una semplice chatbot, un copilot per email, un sistema RAG meteo e una pipeline di estrazione dati strutturati.

**Domande?**  
Chiedici su **[Slack](https://www.tensorzero.com/slack)** o **[Discord](https://www.tensorzero.com/discord)**.

**Usi TensorZero al lavoro?**  
Scrivici a **[hello@tensorzero.com](mailto:hello@tensorzero.com)** per creare un canale Slack o Teams con il tuo team (gratuito).

**Lavora con noi.**  
Stiamo **[assumendo a NYC](https://www.tensorzero.com/jobs)**.  
Accogliamo volentieri anche **[contributi open-source](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Esempi

Stiamo lavorando a una serie di **esempi completi ed eseguibili** che illustrano il ciclo di dati & apprendimento di TensorZero.

> **[Ottimizzazione dell’Estrazione Dati (NER) con TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Questo esempio mostra come usare TensorZero per ottimizzare una pipeline di estrazione dati.
> Dimostriamo tecniche come il fine-tuning e il dynamic in-context learning (DICL).
> Alla fine, un modello GPT-4o Mini ottimizzato supera GPT-4o in questo compito &mdash; a una frazione del costo e della latenza &mdash; usando una piccola quantità di dati di training.

> **[Agentic RAG — Multi-Hop Question Answering con LLM](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Questo esempio mostra come costruire un agente di retrieval multi-hop usando TensorZero.
> L’agente cerca iterativamente su Wikipedia per raccogliere informazioni e decide quando ha abbastanza contesto per rispondere a una domanda complessa.

> **[Scrivere Haiku per Soddisfare un Giudice con Preferenze Nascoste](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> Questo esempio fa fine-tuning di GPT-4o Mini per generare haiku su misura per un gusto specifico.
> Vedrai il “data flywheel in a box” di TensorZero in azione: varianti migliori portano a dati migliori, e dati migliori portano a varianti migliori.
> Vedrai i progressi effettuando il fine-tuning dell’LLM più volte.

> **[Migliorare le Abilità LLM negli Scacchi con Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Questo esempio mostra come il best-of-N sampling possa migliorare significativamente le abilità scacchistiche di un LLM selezionando le mosse più promettenti tra varie opzioni generate.

> **[Migliorare il Ragionamento Matematico con una Ricetta Personalizzata per Prompt Engineering Automatizzato (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero offre numerose ricette di ottimizzazione predefinite che coprono i workflow comuni dell’LLM engineering.
> Ma puoi anche creare facilmente le tue ricette e workflow!
> Questo esempio mostra come ottimizzare una funzione TensorZero usando uno strumento arbitrario — in questo caso, DSPy.

_& molti altri in arrivo!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---