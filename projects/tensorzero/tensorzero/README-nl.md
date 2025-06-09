<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero creëert een feedbackloop voor het optimaliseren van LLM-toepassingen — productiegegevens worden omgezet in slimmere, snellere en goedkopere modellen.**

1. Integreer onze modelgateway
2. Stuur metrics of feedback
3. Optimaliseer prompts, modellen en inferentiestrategieën
4. Zie je LLM’s in de loop van de tijd verbeteren

Het biedt een **data & learning flywheel voor LLM’s** door het verenigen van:

- [x] **Inferentie:** één API voor alle LLM’s, met <1ms P99 overhead
- [x] **Observeerbaarheid:** inferentie & feedback → jouw database
- [x] **Optimalisatie:** van prompts tot fine-tuning en RL
- [x] **Evaluaties:** vergelijk prompts, modellen, inferentiestrategieën
- [x] **Experimentatie:** ingebouwde A/B-testen, routering, fallbacks

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Website</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Documentatie</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Snelle Start (5min)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Uitgebreide Tutorial</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Deployment Gids</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API Referentie</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Configuratie Referentie</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>Wat is TensorZero?</b></td>
    <td width="70%" valign="top">TensorZero is een open-source framework voor het bouwen van productieklare LLM-toepassingen. Het verenigt een LLM-gateway, observeerbaarheid, optimalisatie, evaluaties en experimentatie.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Hoe verschilt TensorZero van andere LLM-frameworks?</b></td>
    <td width="70%" valign="top">
      1. TensorZero stelt je in staat complexe LLM-toepassingen te optimaliseren op basis van productiemetrics en menselijke feedback.<br>
      2. TensorZero ondersteunt de behoeften van industriële LLM-toepassingen: lage latency, hoge doorvoer, typeveiligheid, self-hosted, GitOps, aanpasbaarheid, enz.<br>
      3. TensorZero verenigt de volledige LLMOps-stack, waardoor samenspelende voordelen ontstaan. Bijvoorbeeld, LLM-evaluaties kunnen worden gebruikt voor fine-tuning van modellen samen met AI-juryleden.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Kan ik TensorZero gebruiken met ___?</b></td>
    <td width="70%" valign="top">Ja. Elke grote programmeertaal wordt ondersteund. Je kunt TensorZero gebruiken met onze Python-client, elke OpenAI SDK, of onze HTTP API.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Is TensorZero geschikt voor productie?</b></td>
    <td width="70%" valign="top">Ja. Hier is een case study: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Automatiseren van code changelogs bij een grote bank met LLMs</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Wat kost TensorZero?</b></td>
    <td width="70%" valign="top">Niets. TensorZero is 100% self-hosted en open-source. Er zijn geen betaalde functies.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Wie ontwikkelt TensorZero?</b></td>
    <td width="70%" valign="top">Ons technische team bestaat uit een voormalig Rust compiler maintainer, machine learning onderzoekers (Stanford, CMU, Oxford, Columbia) met duizenden citaties, en de chief product officer van een decacorn startup. We worden gesteund door dezelfde investeerders als toonaangevende open-source projecten (zoals ClickHouse, CockroachDB) en AI-labs (zoals OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Hoe begin ik met TensorZero?</b></td>
    <td width="70%" valign="top">Je kunt TensorZero geleidelijk adopteren. Onze <b><a href="https://www.tensorzero.com/docs/quickstart">Snelle Start</a></b> gaat van een eenvoudige OpenAI-wrapper naar een productieklare LLM-toepassing met observeerbaarheid en fine-tuning in slechts 5 minuten.</td>
  </tr>
</table>

---

## Functies

### 🌐 LLM Gateway

> **Integreer één keer met TensorZero en krijg toegang tot elke grote LLM-provider.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Modelproviders</b></td>
    <td width="50%" align="center" valign="middle"><b>Functies</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        De TensorZero Gateway ondersteunt standaard:
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
          Iets anders nodig?
          Jouw provider wordt waarschijnlijk ondersteund, want TensorZero integreert met <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">elke OpenAI-compatibele API (bijvoorbeeld Ollama)</a></b>.
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        De TensorZero Gateway ondersteunt geavanceerde functies zoals:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Retries & Fallbacks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Inference-Time Optimalisaties</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Prompt Templates & Schema's</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Experimentatie (A/B Testen)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Configuratie-als-Code (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Batch Inferentie</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Multimodale Inferentie (VLM's)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Inferentie Caching</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Metrics & Feedback</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Multi-Step LLM Workflows (Episodes)</a></b></li>
        <li><em>& veel meer...</em></li>
      </ul>
      <p>
        De TensorZero Gateway is geschreven in Rust 🦀 met het oog op <b>performance</b> (&lt;1ms p99 latency overhead @ 10k QPS).
        Zie <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmarks</a></b>.<br>
      </p>
      <p>
        Je kunt inferentie uitvoeren via de <b>TensorZero client</b> (aanbevolen), de <b>OpenAI client</b> of de <b>HTTP API</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Gebruik: Python &mdash; TensorZero Client (Aanbevolen)</b></summary>

Je hebt toegang tot elke provider via de TensorZero Python-client.

1. `pip install tensorzero`
2. Optioneel: Stel de TensorZero-configuratie in.
3. Voer inferentie uit:

```python
from tensorzero import TensorZeroGateway  # of AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Probeer eenvoudig andere providers: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Schrijf een haiku over kunstmatige intelligentie.",
                }
            ]
        },
    )
```

Zie **[Snelle Start](https://www.tensorzero.com/docs/quickstart)** voor meer informatie.

</details>

<details>
<summary><b>Gebruik: Python &mdash; OpenAI Client</b></summary>

Je hebt toegang tot elke provider via de OpenAI Python-client met TensorZero.

1. `pip install tensorzero`
2. Optioneel: Stel de TensorZero-configuratie in.
3. Voer inferentie uit:

```python
from openai import OpenAI  # of AsyncOpenAI
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
    # Probeer eenvoudig andere providers: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Schrijf een haiku over kunstmatige intelligentie.",
        }
    ],
)
```

Zie **[Snelstart](https://www.tensorzero.com/docs/quickstart)** voor meer informatie.

</details>

<details>
<summary><b>Gebruik: JavaScript / TypeScript (Node) &mdash; OpenAI Client</b></summary>

Je kunt elke provider benaderen met de OpenAI Node client via TensorZero.

1. Deploy `tensorzero/gateway` met Docker.
   **[Gedetailleerde instructies →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Stel de TensorZero-configuratie in.
3. Voer inference uit:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Probeer eenvoudig andere providers: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Schrijf een haiku over kunstmatige intelligentie.",
    },
  ],
});
```

Zie **[Snelstart](https://www.tensorzero.com/docs/quickstart)** voor meer informatie.

</details>

<details>
<summary><b>Gebruik: Andere Talen & Platformen &mdash; HTTP API</b></summary>

TensorZero ondersteunt vrijwel elke programmeertaal of platform via de HTTP API.

1. Deploy `tensorzero/gateway` met Docker.
   **[Gedetailleerde instructies →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Optioneel: Stel de TensorZero-configuratie in.
3. Voer inference uit:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Schrijf een haiku over kunstmatige intelligentie."
        }
      ]
    }
  }'
```

Zie **[Snelstart](https://www.tensorzero.com/docs/quickstart)** voor meer informatie.

</details>

<br>

### 📈 LLM-optimalisatie

> **Stuur productiemetingen en menselijke feedback om eenvoudig je prompts, modellen en inferentiestrategieën te optimaliseren &mdash; via de UI of programmeerbaar.**

#### Modeloptimalisatie

Optimaliseer gesloten en open-source modellen met behulp van supervised fine-tuning (SFT) en preference fine-tuning (DPO).

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

#### Inference-tijd Optimalisatie

Verhoog de prestaties door je prompts dynamisch te updaten met relevante voorbeelden, reacties van meerdere inferenties te combineren, en meer.

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

_Meer binnenkort..._

<br>

#### Promptoptimalisatie

Optimaliseer je prompts programmeerbaar met onderzoeksgedreven optimalisatietechnieken.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy-integratie</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero wordt geleverd met verschillende optimalisatierecepten, maar je kunt ook eenvoudig je eigen maken.
      Dit voorbeeld toont hoe je een TensorZero-functie optimaliseert met een willekeurig hulpmiddel — hier DSPy, een populaire bibliotheek voor geautomatiseerde prompt engineering.
    </td>
  </tr>
</table>

_Meer binnenkort..._

<br>

### 🔍 LLM Observability

> **Zoom in om individuele API-calls te debuggen, of zoom uit om metrieken over modellen en prompts in de tijd te monitoren &mdash; allemaal met de open-source TensorZero UI.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Observability » Inference</b></td>
    <td width="50%" align="center" valign="middle"><b>Observability » Functie</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 LLM Evaluaties

> **Vergelijk prompts, modellen en inferentiestrategieën met TensorZero Evaluaties &mdash; met ondersteuning voor heuristieken en LLM-jury’s.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Evaluatie » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Evaluatie » CLI</b></td>
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
Aantal datapunten: 100
██████████████████████████████████████ 100/100
exact_match: 0.83 ± 0.03
semantic_match: 0,98 ± 0,01  
item_count: 7,15 ± 0,39</code></pre>
    </td>
  </tr>
</table>

## Demo

> **Bekijk hoe LLM's in realtime beter worden in data-extractie met TensorZero!**
>
> **[Dynamisch in-context leren (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** is een krachtige optimalisatie tijdens inferentie, standaard beschikbaar met TensorZero.
> Het verbetert de LLM-prestaties door automatisch relevante historische voorbeelden aan de prompt toe te voegen, zonder dat model-finetuning nodig is.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## LLM Engineering met TensorZero

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

1. De **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** is een high-performance modelgateway geschreven in Rust 🦀 die een uniforme API-interface biedt voor alle grote LLM-aanbieders, waardoor naadloze cross-platform integratie en fallbacks mogelijk zijn.
2. Het handelt gestructureerde schema-gebaseerde inferentie af met &lt;1ms P99 latency overhead (zie **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) en ingebouwde observability, experimentatie, en **[optimalisaties tijdens inferentie](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. Het verzamelt ook downstream-metrics en feedback die gekoppeld zijn aan deze inferenties, met eersteklas ondersteuning voor multi-step LLM-systemen.
4. Alles wordt opgeslagen in een ClickHouse datawarehouse dat je zelf beheert, voor realtime, schaalbare en ontwikkelaarsvriendelijke analytics.
5. Na verloop van tijd gebruiken **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** deze gestructureerde dataset om je prompts en modellen te optimaliseren: voer kant-en-klare recepten uit voor veelvoorkomende workflows zoals fine-tuning, of maak je eigen recepten met volledige flexibiliteit in elke taal en elk platform.
6. Tot slot maken de experimenteerfuncties van de gateway en GitOps-orchestratie het mogelijk om met vertrouwen te itereren en uit te rollen, of het nu om één LLM of duizenden LLM's gaat.

Ons doel is om engineers te helpen bij het bouwen, beheren en optimaliseren van de volgende generatie LLM-toepassingen: systemen die leren van echte ervaringen.
Lees meer over onze **[Visie & Roadmap](https://www.tensorzero.com/docs/vision-roadmap/)**.

## Aan de slag

**Begin vandaag nog met bouwen.**  
De **[Quick Start](https://www.tensorzero.com/docs/quickstart)** laat zien hoe eenvoudig het is om een LLM-toepassing op te zetten met TensorZero.  
Wil je dieper duiken? De **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)** leert je hoe je een eenvoudige chatbot, een e-mail copilot, een weer-RAG-systeem en een pipeline voor gestructureerde data-extractie bouwt.

**Vragen?**  
Stel ze op **[Slack](https://www.tensorzero.com/slack)** of **[Discord](https://www.tensorzero.com/discord)**.

**Gebruik je TensorZero op het werk?**  
Mail ons op **[hello@tensorzero.com](mailto:hello@tensorzero.com)** om gratis een Slack- of Teams-kanaal met je team op te zetten.

**Werk met ons samen.**  
We zijn **[op zoek naar mensen in NYC](https://www.tensorzero.com/jobs)**.  
We verwelkomen ook graag **[open-source bijdragen](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Voorbeelden

We werken aan een reeks **volledige uitvoerbare voorbeelden** die TensorZero's data- & leerflywheel illustreren.

> **[Data-extractie optimaliseren (NER) met TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Dit voorbeeld laat zien hoe je TensorZero gebruikt om een data-extractiepijplijn te optimaliseren.
> We demonstreren technieken zoals fine-tuning en dynamisch in-context leren (DICL).
> Uiteindelijk presteert een geoptimaliseerd GPT-4o Mini-model beter dan GPT-4o op deze taak &mdash; tegen een fractie van de kosten en latency &mdash; met een kleine hoeveelheid trainingsdata.

> **[Agentic RAG — Multi-Hop Vraagbeantwoording met LLM's](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Dit voorbeeld laat zien hoe je een multi-hop retrieval agent bouwt met TensorZero.
> De agent zoekt iteratief op Wikipedia om informatie te verzamelen, en beslist wanneer er genoeg context is om een complexe vraag te beantwoorden.

> **[Haiku's schrijven om een rechter met verborgen voorkeuren tevreden te stellen](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> In dit voorbeeld wordt GPT-4o Mini fijn afgestemd om haiku's te genereren die zijn afgestemd op een specifieke smaak.
> Je ziet TensorZero's "data flywheel in a box" in actie: betere varianten leiden tot betere data, en betere data leiden tot betere varianten.
> Je ziet vooruitgang door de LLM meerdere keren te fine-tunen.

> **[LLM Schaakkwaliteit verbeteren met Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Dit voorbeeld laat zien hoe best-of-N sampling de schaakkwaliteiten van een LLM aanzienlijk kan verbeteren door de meest veelbelovende zetten uit meerdere gegenereerde opties te selecteren.

> **[Wiskundig redeneren verbeteren met een Custom Recipe voor geautomatiseerde prompt engineering (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero biedt een aantal kant-en-klare optimalisatierecepten voor veelvoorkomende LLM engineering workflows.
> Maar je kunt ook eenvoudig je eigen recepten en workflows maken!
> Dit voorbeeld toont hoe je een TensorZero-functie optimaliseert met een willekeurige tool — hier, DSPy.

_& nog veel meer in de maak!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---