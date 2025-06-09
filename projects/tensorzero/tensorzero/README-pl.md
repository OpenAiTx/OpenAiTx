<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero tworzy pętlę sprzężenia zwrotnego dla optymalizacji aplikacji LLM — zamieniając dane produkcyjne w inteligentniejsze, szybsze i tańsze modele.**

1. Zintegruj naszą bramkę modelową
2. Wysyłaj metryki lub feedback
3. Optymalizuj prompt'y, modele i strategie inferencji
4. Obserwuj, jak Twoje LLM-y poprawiają się z czasem

Zapewnia **koło zamachowe danych i uczenia dla LLM-ów** poprzez ujednolicenie:

- [x] **Inferencja:** jedno API dla wszystkich LLM-ów, z narzutem <1 ms P99
- [x] **Obserwowalność:** inferencja i feedback → Twoja baza danych
- [x] **Optymalizacja:** od promptów po fine-tuning i RL
- [x] **Ewaluacje:** porównuj prompt'y, modele, strategie inferencji
- [x] **Eksperymentowanie:** wbudowane testy A/B, routing, fallbacki

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Strona WWW</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Dokumentacja</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Szybki start (5 min)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Kompletny tutorial</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Przewodnik wdrożeniowy</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">Referencja API</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Referencja konfiguracji</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>Czym jest TensorZero?</b></td>
    <td width="70%" valign="top">TensorZero to open-source'owy framework do budowy aplikacji LLM klasy produkcyjnej. Ujednolica bramkę LLM, obserwowalność, optymalizację, ewaluacje i eksperymentowanie.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Czym TensorZero różni się od innych frameworków LLM?</b></td>
    <td width="70%" valign="top">
      1. TensorZero umożliwia optymalizację złożonych aplikacji LLM na podstawie metryk produkcyjnych i feedbacku od ludzi.<br>
      2. TensorZero wspiera potrzeby aplikacji LLM na skalę przemysłową: niskie opóźnienia, wysoką przepustowość, bezpieczeństwo typów, self-hosting, GitOps, możliwość dostosowania, itd.<br>
      3. TensorZero jednoczy cały stack LLMOps, tworząc efekt kuli śnieżnej. Na przykład ewaluacje LLM mogą być wykorzystywane do fine-tuningu modeli razem z AI judge'ami.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Czy mogę używać TensorZero z ___?</b></td>
    <td width="70%" valign="top">Tak. Wspierane są wszystkie główne języki programowania. Możesz używać TensorZero z naszym klientem Pythona, dowolnym SDK OpenAI lub przez nasze HTTP API.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Czy TensorZero jest gotowy na produkcję?</b></td>
    <td width="70%" valign="top">Tak. Przykład wdrożenia: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Automatyzacja changelogów w dużym banku za pomocą LLM-ów</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Ile kosztuje TensorZero?</b></td>
    <td width="70%" valign="top">Nic. TensorZero jest w 100% self-hosted i open-source. Nie ma płatnych funkcji.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Kto rozwija TensorZero?</b></td>
    <td width="70%" valign="top">Nasz zespół techniczny to m.in. były maintainer kompilatora Rust, badacze machine learning (Stanford, CMU, Oxford, Columbia) z tysiącami cytowań i CPO startupu typu decacorn. Wspierają nas ci sami inwestorzy co wiodące projekty open-source (np. ClickHouse, CockroachDB) i laboratoria AI (np. OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Jak zacząć?</b></td>
    <td width="70%" valign="top">Możesz wdrażać TensorZero stopniowo. Nasz <b><a href="https://www.tensorzero.com/docs/quickstart">Szybki start</a></b> prowadzi od zwykłego wrappera OpenAI do aplikacji LLM gotowej na produkcję z obserwowalnością i fine-tuningiem w 5 minut.</td>
  </tr>
</table>

---

## Funkcje

### 🌐 Bramka LLM

> **Zintegruj się z TensorZero raz i uzyskaj dostęp do wszystkich głównych dostawców LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Dostawcy modeli</b></td>
    <td width="50%" align="center" valign="middle"><b>Funkcje</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        Bramka TensorZero natywnie obsługuje:
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
          Potrzebujesz czegoś innego?
          Twój dostawca jest najpewniej wspierany, ponieważ TensorZero integruje się z <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">każdym API kompatybilnym z OpenAI (np. Ollama)</a></b>.
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        Bramka TensorZero obsługuje zaawansowane funkcje, takie jak:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Retry & Fallbacki</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Optymalizacje czasu inferencji</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Szablony promptów & Schematy</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Eksperymentowanie (A/B Testing)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Konfiguracja jako kod (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Inferencja wsadowa</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Inferencja multimodalna (VLM)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Cache'owanie inferencji</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Metryki & Feedback</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Wielokrokowe workflow LLM (Episodes)</a></b></li>
        <li><em>& wiele więcej...</em></li>
      </ul>
      <p>
        Bramka TensorZero napisana jest w Rust 🦀 z myślą o <b>wydajności</b> (&lt;1ms p99 latency overhead przy 10k QPS).
        Zobacz <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmarki</a></b>.<br>
      </p>
      <p>
        Możesz uruchamiać inferencję używając <b>klienta TensorZero</b> (zalecane), <b>klienta OpenAI</b> lub <b>HTTP API</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Użycie: Python &mdash; Klient TensorZero (zalecane)</b></summary>

Możesz uzyskać dostęp do dowolnego dostawcy za pomocą klienta TensorZero dla Pythona.

1. `pip install tensorzero`
2. Opcjonalnie: Skonfiguruj TensorZero.
3. Uruchom inferencję:

```python
from tensorzero import TensorZeroGateway  # lub AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Łatwo przetestuj innych dostawców: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Napisz haiku o sztucznej inteligencji.",
                }
            ]
        },
    )
```

Zobacz **[Szybki Start](https://www.tensorzero.com/docs/quickstart)** po więcej informacji.

</details>

<details>
<summary><b>Użycie: Python &mdash; Klient OpenAI</b></summary>

Możesz uzyskać dostęp do dowolnego dostawcy przez klienta OpenAI dla Pythona z TensorZero.

1. `pip install tensorzero`
2. Opcjonalnie: Skonfiguruj TensorZero.
3. Uruchom inferencję:

```python
from openai import OpenAI  # lub AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
```
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # Wypróbuj innych dostawców łatwo: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Napisz haiku o sztucznej inteligencji.",
        }
    ],
)
```

Zobacz **[Szybki Start](https://www.tensorzero.com/docs/quickstart)** po więcej informacji.

</details>

<details>
<summary><b>Użycie: JavaScript / TypeScript (Node) &mdash; Klient OpenAI</b></summary>

Możesz uzyskać dostęp do dowolnego dostawcy za pomocą klienta OpenAI Node z TensorZero.

1. Wdróż `tensorzero/gateway` używając Dockera.
   **[Szczegółowa instrukcja →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Skonfiguruj TensorZero.
3. Uruchom inferencję:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Wypróbuj innych dostawców łatwo: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Napisz haiku o sztucznej inteligencji.",
    },
  ],
});
```

Zobacz **[Szybki Start](https://www.tensorzero.com/docs/quickstart)** po więcej informacji.

</details>

<details>
<summary><b>Użycie: Inne języki i platformy &mdash; HTTP API</b></summary>

TensorZero obsługuje praktycznie każdy język programowania lub platformę przez API HTTP.

1. Wdróż `tensorzero/gateway` używając Dockera.
   **[Szczegółowa instrukcja →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Opcjonalnie: Skonfiguruj TensorZero.
3. Uruchom inferencję:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Napisz haiku o sztucznej inteligencji."
        }
      ]
    }
  }'
```

Zobacz **[Szybki Start](https://www.tensorzero.com/docs/quickstart)** po więcej informacji.

</details>

<br>

### 📈 Optymalizacja LLM

> **Przesyłaj metryki produkcyjne oraz feedback użytkowników, aby z łatwością optymalizować prompty, modele i strategie inferencji — przez UI lub programistycznie.**

#### Optymalizacja modelu

Optymalizuj modele zamknięto- i otwartoźródłowe poprzez nadzorowane dostrajanie (SFT) i dostrajanie preferencji (DPO).

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Dostrajanie nadzorowane &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Dostrajanie preferencji (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Optymalizacja w czasie inferencji

Zwiększ wydajność, dynamicznie aktualizując prompt z odpowiednimi przykładami, łącząc odpowiedzi z wielu inferencji i więcej.

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

_Więcej wkrótce..._

<br>

#### Optymalizacja promptów

Optymalizuj swoje prompty programistycznie, korzystając z technik opartych na badaniach naukowych.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">Integracja DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero posiada kilka gotowych przepisów optymalizacyjnych, ale możesz również łatwo tworzyć własne.
      Ten przykład pokazuje jak zoptymalizować funkcję TensorZero przy użyciu dowolnego narzędzia — tutaj DSPy, popularnej biblioteki do automatycznego inżynierii promptów.
    </td>
  </tr>
</table>

_Więcej wkrótce..._

<br>

### 🔍 Obserwowalność LLM

> **Przybliżaj, aby debugować pojedyncze wywołania API lub oddalaj, aby monitorować metryki modeli i promptów w czasie — wszystko z wykorzystaniem otwartoźródłowego UI TensorZero.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Obserwowalność » Inferencja</b></td>
    <td width="50%" align="center" valign="middle"><b>Obserwowalność » Funkcja</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 Ewaluacje LLM

> **Porównuj prompty, modele i strategie inferencji przy użyciu TensorZero Evaluations — z obsługą heurystyk i sędziów LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Ewaluacja » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Ewaluacja » CLI</b></td>
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

> **Obserwuj, jak LLM-y stają się coraz lepsze w ekstrakcji danych w czasie rzeczywistym z TensorZero!**
>
> **[Dynamiczne uczenie w kontekście (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** to potężna optymalizacja w czasie inferencji dostępna od razu z TensorZero.
> Zwiększa wydajność LLM-ów poprzez automatyczne włączanie odpowiednich historycznych przykładów do promptu, bez konieczności dostrajania modelu.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## Inżynieria LLM z TensorZero

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

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** to wysokowydajna bramka modelowa napisana w Rust 🦀, która zapewnia zunifikowany interfejs API dla wszystkich głównych dostawców LLM, umożliwiając bezproblemową integrację międzyplatformową i mechanizmy awaryjne.
2. Obsługuje inferencję opartą na strukturalnych schematach z opóźnieniem P99 poniżej 1 ms (zobacz **[Benchmarki](https://www.tensorzero.com/docs/gateway/benchmarks)**) oraz wbudowaną obserwowalność, eksperymentowanie i **[optymalizacje w czasie inferencji](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. Zbiera także metryki i informacje zwrotne związane z tymi inferencjami, z natywnym wsparciem dla wieloetapowych systemów LLM.
4. Wszystko jest przechowywane w hurtowni danych ClickHouse, którą kontrolujesz — dla analityki w czasie rzeczywistym, skalowalnej i przyjaznej deweloperom.
5. Z czasem **[Receptury TensorZero](https://www.tensorzero.com/docs/recipes)** wykorzystują ten uporządkowany zbiór danych do optymalizacji promptów i modeli: uruchamiaj gotowe receptury dla typowych zadań takich jak fine-tuning lub twórz własne z pełną elastycznością, używając dowolnego języka i platformy.
6. Na koniec funkcje eksperymentowania bramki i orkiestracja GitOps pozwalają Ci iterować i wdrażać z pewnością — niezależnie czy to pojedynczy LLM, czy tysiące modeli.

Naszym celem jest pomoc inżynierom w budowaniu, zarządzaniu i optymalizacji nowej generacji aplikacji LLM: systemów uczących się na podstawie rzeczywistych doświadczeń.  
Przeczytaj więcej o naszej **[Wizji i Planie Rozwoju](https://www.tensorzero.com/docs/vision-roadmap/)**.

## Pierwsze kroki

**Zacznij budować już dziś.**  
**[Szybki Start](https://www.tensorzero.com/docs/quickstart)** pokazuje, jak łatwo skonfigurować aplikację LLM z TensorZero.  
Jeśli chcesz zagłębić się bardziej, **[Samouczek](https://www.tensorzero.com/docs/gateway/tutorial)** nauczy Cię, jak zbudować prostego chatbota, asystenta e-mail, system pogodowy RAG oraz pipeline do ekstrakcji danych strukturalnych.

**Masz pytania?**  
Pytaj nas na **[Slacku](https://www.tensorzero.com/slack)** lub **[Discordzie](https://www.tensorzero.com/discord)**.

**Używasz TensorZero w pracy?**  
Napisz do nas na **[hello@tensorzero.com](mailto:hello@tensorzero.com)**, aby założyć kanał Slack lub Teams dla Twojego zespołu (za darmo).

**Pracuj z nami.**  
**[Rekrutujemy w NYC](https://www.tensorzero.com/jobs)**.  
Chętnie przyjmiemy także **[wkłady open-source](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Przykłady

Pracujemy nad serią **kompletnych, uruchamialnych przykładów** ilustrujących cykl danych i uczenia TensorZero.

> **[Optymalizacja ekstrakcji danych (NER) z TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Ten przykład pokazuje, jak użyć TensorZero do optymalizacji pipeline'u ekstrakcji danych.
> Pokazujemy techniki takie jak fine-tuning i dynamiczne uczenie w kontekście (DICL).
> Ostatecznie zoptymalizowany model GPT-4o Mini przewyższa GPT-4o w tym zadaniu — przy ułamku kosztu i opóźnienia — wykorzystując niewielką ilość danych treningowych.

> **[Agentowy RAG — Odpowiadanie na pytania wieloetapowe z LLM](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Ten przykład pokazuje, jak zbudować agenta wieloetapowego wyszukiwania za pomocą TensorZero.
> Agent iteracyjnie przeszukuje Wikipedię w celu zebrania informacji i decyduje, kiedy posiada wystarczający kontekst, aby odpowiedzieć na złożone pytanie.

> **[Pisanie haiku, by zadowolić sędziego o ukrytych preferencjach](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> Ten przykład dostraja GPT-4o Mini do generowania haiku dopasowanych do konkretnego gustu.
> Zobaczysz „cykl danych w pudełku” TensorZero w akcji: lepsze warianty prowadzą do lepszych danych, a lepsze dane do lepszych wariantów.
> Zobaczysz postępy dzięki wielokrotnemu fine-tuningowi LLM.

> **[Ulepszanie umiejętności szachowych LLM dzięki Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Ten przykład pokazuje, jak Best-of-N sampling może znacząco zwiększyć umiejętności gry w szachy przez LLM, wybierając najbardziej obiecujące posunięcia z wielu wygenerowanych opcji.

> **[Poprawa rozumowania matematycznego z własną recepturą do automatycznej inżynierii promptów (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero oferuje szereg gotowych receptur optymalizacyjnych obejmujących typowe procesy inżynierii LLM.
> Możesz też łatwo tworzyć własne receptury i workflow!
> Ten przykład pokazuje, jak zoptymalizować funkcję TensorZero za pomocą dowolnego narzędzia — tutaj DSPy.

_& wiele kolejnych już w drodze!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---