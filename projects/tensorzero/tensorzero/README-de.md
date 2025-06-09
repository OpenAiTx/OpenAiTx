<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero schafft eine Feedback-Schleife zur Optimierung von LLM-Anwendungen – Produktionsdaten werden in intelligentere, schnellere und günstigere Modelle verwandelt.**

1. Integrieren Sie unser Model-Gateway
2. Senden Sie Metriken oder Feedback
3. Optimieren Sie Prompts, Modelle und Inferenzstrategien
4. Beobachten Sie, wie sich Ihre LLMs im Laufe der Zeit verbessern

TensorZero bietet ein **Daten- & Lern-Schwungrad für LLMs** durch die Vereinheitlichung von:

- [x] **Inference:** Eine API für alle LLMs, mit <1ms P99 Overhead
- [x] **Observability:** Inferenz & Feedback → Ihre Datenbank
- [x] **Optimization:** Von Prompts bis Fine-Tuning und RL
- [x] **Evaluations:** Vergleichen Sie Prompts, Modelle, Inferenzstrategien
- [x] **Experimentation:** Integriertes A/B-Testing, Routing, Fallbacks

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Website</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Dokumentation</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Schnellstart (5min)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Umfassendes Tutorial</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Deployment-Anleitung</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API-Referenz</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Konfigurationsreferenz</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>Was ist TensorZero?</b></td>
    <td width="70%" valign="top">TensorZero ist ein Open-Source-Framework zum Aufbau von produktionsreifen LLM-Anwendungen. Es vereint ein LLM-Gateway, Observability, Optimierung, Evaluationen und Experimentation.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Worin unterscheidet sich TensorZero von anderen LLM-Frameworks?</b></td>
    <td width="70%" valign="top">
      1. TensorZero ermöglicht die Optimierung komplexer LLM-Anwendungen basierend auf Produktionsmetriken und menschlichem Feedback.<br>
      2. TensorZero erfüllt die Anforderungen von LLM-Anwendungen im industriellen Maßstab: geringe Latenz, hoher Durchsatz, Typsicherheit, Self-Hosting, GitOps, Anpassbarkeit, usw.<br>
      3. TensorZero vereint den gesamten LLMOps-Stack und schafft so kumulative Vorteile. Beispielsweise können LLM-Evaluationen für das Fine-Tuning von Modellen zusammen mit KI-Judges verwendet werden.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Kann ich TensorZero mit ___ verwenden?</b></td>
    <td width="70%" valign="top">Ja. Jede gängige Programmiersprache wird unterstützt. Sie können TensorZero mit unserem Python-Client, jedem OpenAI-SDK oder unserer HTTP-API verwenden.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Ist TensorZero produktionsreif?</b></td>
    <td width="70%" valign="top">Ja. Hier ist eine Fallstudie: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Automatisierte Code-Changelogs bei einer Großbank mit LLMs</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Was kostet TensorZero?</b></td>
    <td width="70%" valign="top">Nichts. TensorZero ist 100% self-hosted und Open Source. Es gibt keine kostenpflichtigen Funktionen.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Wer entwickelt TensorZero?</b></td>
    <td width="70%" valign="top">Unser technisches Team umfasst einen ehemaligen Rust-Compiler-Maintainer, Machine-Learning-Forscher (Stanford, CMU, Oxford, Columbia) mit Tausenden von Zitierungen sowie den Chief Product Officer eines Decacorn-Startups. Wir werden von denselben Investoren unterstützt wie führende Open-Source-Projekte (z.B. ClickHouse, CockroachDB) und KI-Labore (z.B. OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Wie starte ich mit TensorZero?</b></td>
    <td width="70%" valign="top">Sie können TensorZero schrittweise einführen. Unser <b><a href="https://www.tensorzero.com/docs/quickstart">Schnellstart</a></b> führt Sie von einem einfachen OpenAI-Wrapper zu einer produktionsreifen LLM-Anwendung mit Observability und Fine-Tuning in nur 5 Minuten.</td>
  </tr>
</table>

---

## Funktionen

### 🌐 LLM-Gateway

> **Integrieren Sie TensorZero einmal und greifen Sie auf jeden wichtigen LLM-Anbieter zu.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Modellanbieter</b></td>
    <td width="50%" align="center" valign="middle"><b>Funktionen</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        Das TensorZero Gateway unterstützt nativ:
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
          Benötigen Sie etwas anderes?
          Ihr Anbieter wird höchstwahrscheinlich unterstützt, da TensorZero mit <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">jeder OpenAI-kompatiblen API (z.B. Ollama)</a></b> integriert werden kann.
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        Das TensorZero Gateway unterstützt fortgeschrittene Funktionen wie:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Retries & Fallbacks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Inferenzzeit-Optimierungen</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Prompt-Vorlagen & Schemata</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Experimentation (A/B-Testing)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Configuration-as-Code (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Batch Inference</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Multimodale Inferenz (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Inferenz-Caching</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Metriken & Feedback</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Multi-Step-LLM-Workflows (Episoden)</a></b></li>
        <li><em>& vieles mehr ...</em></li>
      </ul>
      <p>
        Das TensorZero Gateway ist in Rust 🦀 mit Fokus auf <b>Performance</b> entwickelt (&lt;1ms p99 Latenz-Overhead bei 10k QPS).
        Siehe <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmarks</a></b>.<br>
      </p>
      <p>
        Sie können Inferenz mit dem <b>TensorZero-Client</b> (empfohlen), dem <b>OpenAI-Client</b> oder der <b>HTTP API</b> durchführen.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Verwendung: Python &mdash; TensorZero Client (empfohlen)</b></summary>

Sie können auf jeden Anbieter mit dem TensorZero Python-Client zugreifen.

1. `pip install tensorzero`
2. Optional: Richten Sie die TensorZero-Konfiguration ein.
3. Führen Sie die Inferenz aus:

```python
from tensorzero import TensorZeroGateway  # oder AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Andere Anbieter können einfach ausprobiert werden: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Schreibe ein Haiku über künstliche Intelligenz.",
                }
            ]
        },
    )
```

Siehe **[Schnellstart](https://www.tensorzero.com/docs/quickstart)** für weitere Informationen.

</details>

<details>
<summary><b>Verwendung: Python &mdash; OpenAI Client</b></summary>

Sie können mit TensorZero über den OpenAI Python-Client auf jeden Anbieter zugreifen.

1. `pip install tensorzero`
2. Optional: Richten Sie die TensorZero-Konfiguration ein.
3. Führen Sie die Inferenz aus:

```python
from openai import OpenAI  # oder AsyncOpenAI
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
    # Probiere andere Anbieter einfach aus: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Schreibe ein Haiku über künstliche Intelligenz.",
        }
    ],
)
```

Siehe **[Schnellstart](https://www.tensorzero.com/docs/quickstart)** für weitere Informationen.

</details>

<details>
<summary><b>Verwendung: JavaScript / TypeScript (Node) &mdash; OpenAI Client</b></summary>

Du kannst mit TensorZero über den OpenAI Node Client auf jeden Anbieter zugreifen.

1. Deploye `tensorzero/gateway` mit Docker.
   **[Detaillierte Anweisungen →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Richte die TensorZero-Konfiguration ein.
3. Führe Inferenz aus:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Probiere andere Anbieter einfach aus: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Schreibe ein Haiku über künstliche Intelligenz.",
    },
  ],
});
```

Siehe **[Schnellstart](https://www.tensorzero.com/docs/quickstart)** für weitere Informationen.

</details>

<details>
<summary><b>Verwendung: Andere Sprachen & Plattformen &mdash; HTTP API</b></summary>

TensorZero unterstützt praktisch jede Programmiersprache oder Plattform über seine HTTP API.

1. Deploye `tensorzero/gateway` mit Docker.
   **[Detaillierte Anweisungen →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Optional: Richte die TensorZero-Konfiguration ein.
3. Führe Inferenz aus:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Schreibe ein Haiku über künstliche Intelligenz."
        }
      ]
    }
  }'
```

Siehe **[Schnellstart](https://www.tensorzero.com/docs/quickstart)** für weitere Informationen.

</details>

<br>

### 📈 LLM-Optimierung

> **Sende Produktionsmetriken und menschliches Feedback, um deine Prompts, Modelle und Inferenzstrategien ganz einfach zu optimieren &mdash; über die UI oder programmatisch.**

#### Modelloptimierung

Optimiere Closed-Source- und Open-Source-Modelle mithilfe von überwachten Fine-Tuning (SFT) und Präferenz-Fine-Tuning (DPO).

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Überwachtes Fine-Tuning &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Präferenz-Fine-Tuning (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Optimierung zur Inferenzzeit

Steigere die Leistung, indem du deine Prompts dynamisch mit relevanten Beispielen aktualisierst, Antworten aus mehreren Inferenzen kombinierst und mehr.

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

_Mehr folgt in Kürze..._

<br>

#### Prompt-Optimierung

Optimiere deine Prompts programmatisch mit forschungsbasierten Optimierungstechniken.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy-Integration</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero enthält mehrere Optimierungsrezepte, aber du kannst auch ganz einfach eigene erstellen.
      Dieses Beispiel zeigt, wie eine TensorZero-Funktion mit einem beliebigen Tool optimiert wird — hier DSPy, eine beliebte Bibliothek für automatisiertes Prompt Engineering.
    </td>
  </tr>
</table>

_Mehr folgt in Kürze..._

<br>

### 🔍 LLM-Observability

> **Zoome hinein, um einzelne API-Aufrufe zu debuggen, oder hinaus, um Metriken über Modelle und Prompts im Zeitverlauf zu überwachen &mdash; alles mit dem Open-Source-TensorZero-UI.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Observability » Inferenz</b></td>
    <td width="50%" align="center" valign="middle"><b>Observability » Funktion</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 LLM-Evaluierungen

> **Vergleiche Prompts, Modelle und Inferenzstrategien mit TensorZero Evaluations &mdash; mit Unterstützung für Heuristiken und LLM-Judges.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Evaluation » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Evaluation » CLI</b></td>
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

> **Sehen Sie in Echtzeit, wie LLMs mit TensorZero besser bei der Datenextraktion werden!**
>
> **[Dynamisches In-Context-Lernen (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** ist eine leistungsstarke Optimierung zur Inferenzzeit, die bei TensorZero direkt verfügbar ist.
> Es verbessert die Leistung von LLMs, indem automatisch relevante historische Beispiele in den Prompt integriert werden – ganz ohne Fine-Tuning des Modells.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## LLM-Engineering mit TensorZero

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

1. Das **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** ist ein leistungsstarkes Model-Gateway, geschrieben in Rust 🦀, das eine einheitliche API-Schnittstelle für alle großen LLM-Anbieter bereitstellt und so nahtlose plattformübergreifende Integration und Fallbacks ermöglicht.
2. Es verarbeitet strukturierte, schema-basierte Inferenz mit weniger als 1 ms P99-Latenz-Overhead (siehe **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) sowie integrierte Beobachtbarkeit, Experimentierung und **[Optimierungen zur Inferenzzeit](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. Es sammelt zudem Metriken und Feedback zu diesen Inferenzvorgängen mit erstklassiger Unterstützung für mehrstufige LLM-Systeme.
4. Alles wird in einem ClickHouse Data Warehouse gespeichert, das Sie selbst kontrollieren, für Echtzeit-, skalierbare und entwicklerfreundliche Analysen.
5. Im Laufe der Zeit nutzen **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** diesen strukturierten Datensatz, um Ihre Prompts und Modelle zu optimieren: Führen Sie vorgefertigte Rezepte für gängige Workflows wie Fine-Tuning aus oder erstellen Sie mit vollständiger Flexibilität eigene Rezepte in jeder Sprache und auf jeder Plattform.
6. Schließlich ermöglichen Ihnen die Experimentierfunktionen des Gateways und die GitOps-Orchestrierung, mit Zuversicht zu iterieren und zu deployen – sei es ein einzelnes LLM oder tausende LLMs.

Unser Ziel ist es, Ingenieuren dabei zu helfen, die nächste Generation von LLM-Anwendungen zu bauen, zu verwalten und zu optimieren: Systeme, die aus realen Erfahrungen lernen.  
Lesen Sie mehr über unsere **[Vision & Roadmap](https://www.tensorzero.com/docs/vision-roadmap/)**.

## Erste Schritte

**Fangen Sie noch heute an zu bauen.**  
Das **[Quick Start](https://www.tensorzero.com/docs/quickstart)** zeigt, wie einfach es ist, eine LLM-Anwendung mit TensorZero einzurichten.  
Wenn Sie tiefer eintauchen möchten, zeigt das **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)**, wie Sie einen einfachen Chatbot, einen E-Mail-Copiloten, ein Wetter-RAG-System und eine Pipeline zur strukturierten Datenextraktion bauen.

**Fragen?**  
Stellen Sie sie uns auf **[Slack](https://www.tensorzero.com/slack)** oder **[Discord](https://www.tensorzero.com/discord)**.

**Sie nutzen TensorZero beruflich?**  
Schreiben Sie uns an **[hello@tensorzero.com](mailto:hello@tensorzero.com)**, um einen Slack- oder Teams-Kanal mit Ihrem Team einzurichten (kostenlos).

**Arbeiten Sie mit uns.**  
Wir **[stellen in NYC ein](https://www.tensorzero.com/jobs)**.  
Wir freuen uns auch über **[Open-Source-Beiträge](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Beispiele

Wir arbeiten an einer Reihe von **vollständig lauffähigen Beispielen**, die das Daten- & Lern-Flywheel von TensorZero illustrieren.

> **[Optimierung der Datenextraktion (NER) mit TensorZero](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/data-extraction-ner)**
>
> Dieses Beispiel zeigt, wie Sie TensorZero nutzen, um eine Pipeline zur Datenextraktion zu optimieren.
> Wir demonstrieren Techniken wie Fine-Tuning und dynamisches In-Context-Lernen (DICL).
> Am Ende übertrifft ein optimiertes GPT-4o Mini Modell GPT-4o bei dieser Aufgabe — zu einem Bruchteil der Kosten und Latenz — mit nur einer kleinen Menge Trainingsdaten.

> **[Agentic RAG — Multi-Hop-Fragebeantwortung mit LLMs](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Dieses Beispiel zeigt, wie Sie mit TensorZero einen Multi-Hop-Retrieval-Agenten bauen.
> Der Agent durchsucht Wikipedia iterativ, um Informationen zu sammeln und entscheidet, wann er genug Kontext hat, um eine komplexe Frage zu beantworten.

> **[Haikus schreiben, um eine Jury mit versteckten Präferenzen zufriedenzustellen](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/haiku-hidden-preferences)**
>
> Dieses Beispiel finetuned GPT-4o Mini, um Haikus passend zu einem bestimmten Geschmack zu generieren.
> Sie sehen TensorZeros „Data Flywheel in a Box“ in Aktion: bessere Varianten führen zu besseren Daten, und bessere Daten führen zu besseren Varianten.
> Sie sehen den Fortschritt, indem das LLM mehrfach feinabgestimmt wird.

> **[Verbesserung der LLM-Schachfähigkeiten mit Best-of-N Sampling](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/chess-puzzles/)**
>
> Dieses Beispiel zeigt, wie Best-of-N Sampling die Schachfähigkeiten eines LLMs deutlich verbessern kann, indem aus mehreren generierten Optionen die vielversprechendsten Züge ausgewählt werden.

> **[Verbesserung mathematischer Argumentation mit einem Custom Recipe für automatisiertes Prompt-Engineering (DSPy)](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero bietet eine Reihe von vorgefertigten Optimierungs-Rezepten für gängige LLM-Engineering-Workflows.
> Aber Sie können auch ganz einfach eigene Rezepte und Workflows erstellen!
> Dieses Beispiel zeigt, wie Sie eine TensorZero-Funktion mit einem beliebigen Tool – hier DSPy – optimieren.

_& viele weitere sind in Arbeit!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---