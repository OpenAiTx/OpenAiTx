<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero crée une boucle de rétroaction pour optimiser les applications LLM — transformant les données de production en modèles plus intelligents, plus rapides et moins coûteux.**

1. Intégrez notre passerelle de modèles
2. Envoyez des métriques ou des retours d’expérience
3. Optimisez les prompts, modèles et stratégies d’inférence
4. Observez l’amélioration de vos LLMs au fil du temps

Il fournit une **boucle de données & d’apprentissage pour les LLMs** en unifiant :

- [x] **Inférence :** une API pour tous les LLMs, avec une surcharge P99 <1ms
- [x] **Observabilité :** inférence & retours → votre base de données
- [x] **Optimisation :** des prompts au fine-tuning et RL
- [x] **Évaluations :** comparer prompts, modèles, stratégies d’inférence
- [x] **Expérimentation :** tests A/B intégrés, routage, fallbacks

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Site Web</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Docs</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Démarrage rapide (5min)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Tutoriel complet</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Guide de déploiement</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">Référence API</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Référence de configuration</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>Qu’est-ce que TensorZero ?</b></td>
    <td width="70%" valign="top">TensorZero est un framework open-source pour construire des applications LLM de niveau production. Il unifie une passerelle LLM, l’observabilité, l’optimisation, les évaluations et l’expérimentation.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>En quoi TensorZero est-il différent des autres frameworks LLM ?</b></td>
    <td width="70%" valign="top">
      1. TensorZero vous permet d’optimiser des applications LLM complexes sur la base de métriques de production et de retours humains.<br>
      2. TensorZero répond aux besoins des applications LLM à l’échelle industrielle : faible latence, haut débit, sécurité des types, auto-hébergé, GitOps, personnalisation, etc.<br>
      3. TensorZero unifie toute la stack LLMOps, créant des bénéfices cumulatifs. Par exemple, les évaluations LLM peuvent être utilisées pour affiner les modèles en parallèle des juges IA.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Puis-je utiliser TensorZero avec ___ ?</b></td>
    <td width="70%" valign="top">Oui. Tous les principaux langages de programmation sont pris en charge. Vous pouvez utiliser TensorZero avec notre client Python, n’importe quel SDK OpenAI ou notre API HTTP.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero est-il prêt pour la production ?</b></td>
    <td width="70%" valign="top">Oui. Voici une étude de cas : <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Automatisation des changelogs de code dans une grande banque avec des LLMs</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Combien coûte TensorZero ?</b></td>
    <td width="70%" valign="top">Rien. TensorZero est 100% auto-hébergé et open-source. Il n’y a aucune fonctionnalité payante.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Qui construit TensorZero ?</b></td>
    <td width="70%" valign="top">Notre équipe technique comprend un ancien mainteneur du compilateur Rust, des chercheurs en machine learning (Stanford, CMU, Oxford, Columbia) avec des milliers de citations, et le chief product officer d’une startup decacorn. Nous sommes soutenus par les mêmes investisseurs que des projets open-source majeurs (par ex. ClickHouse, CockroachDB) et des laboratoires d’IA (par ex. OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Comment démarrer ?</b></td>
    <td width="70%" valign="top">Vous pouvez adopter TensorZero de façon incrémentale. Notre <b><a href="https://www.tensorzero.com/docs/quickstart">Démarrage rapide</a></b> passe d’un simple wrapper OpenAI à une application LLM prête pour la production avec observabilité et fine-tuning en seulement 5 minutes.</td>
  </tr>
</table>

---

## Fonctionnalités

### 🌐 Passerelle LLM

> **Intégrez-vous une seule fois à TensorZero et accédez à tous les principaux fournisseurs LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Fournisseurs de modèles</b></td>
    <td width="50%" align="center" valign="middle"><b>Fonctionnalités</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        La passerelle TensorZero prend en charge nativement :
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
          Besoin d’autre chose ?
          Votre fournisseur est très probablement pris en charge, car TensorZero s’intègre avec <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">n’importe quelle API compatible OpenAI (par ex. Ollama)</a></b>.
        </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        La passerelle TensorZero prend en charge des fonctionnalités avancées comme :
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Reprises & Fallbacks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Optimisations à l’inférence</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Templates & Schémas de prompts</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Expérimentation (Tests A/B)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Configuration-as-Code (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Inférence par lot</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Inférence multimodale (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Cache d’inférence</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Métriques & Retours</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Workflows LLM multi-étapes (Épisodes)</a></b></li>
        <li><em>& bien d’autres…</em></li>
      </ul>
      <p>
        La passerelle TensorZero est écrite en Rust 🦀 pour la <b>performance</b> (&lt;1ms de latence P99 @ 10k QPS).
        Voir <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmarks</a></b>.<br>
      </p>
      <p>
        Vous pouvez effectuer l’inférence avec le <b>client TensorZero</b> (recommandé), le <b>client OpenAI</b> ou l’<b>API HTTP</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Utilisation : Python &mdash; Client TensorZero (Recommandé)</b></summary>

Vous pouvez accéder à n’importe quel fournisseur avec le client Python TensorZero.

1. `pip install tensorzero`
2. Optionnel : configurez TensorZero.
3. Lancez une inférence :

```python
from tensorzero import TensorZeroGateway  # ou AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Essayez facilement d'autres fournisseurs : "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Écris un haïku sur l’intelligence artificielle.",
                }
            ]
        },
    )
```

Voir **[Démarrage rapide](https://www.tensorzero.com/docs/quickstart)** pour plus d’informations.

</details>

<details>
<summary><b>Utilisation : Python &mdash; Client OpenAI</b></summary>

Vous pouvez accéder à n’importe quel fournisseur avec le client Python OpenAI via TensorZero.

1. `pip install tensorzero`
2. Optionnel : configurez TensorZero.
3. Lancez une inférence :

```python
from openai import OpenAI  # ou AsyncOpenAI
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
    # Essayez d'autres fournisseurs facilement : "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Écris un haïku sur l'intelligence artificielle.",
        }
    ],
)
```

Voir **[Démarrage rapide](https://www.tensorzero.com/docs/quickstart)** pour plus d'informations.

</details>

<details>
<summary><b>Utilisation : JavaScript / TypeScript (Node) &mdash; Client OpenAI</b></summary>

Vous pouvez accéder à n'importe quel fournisseur en utilisant le client OpenAI Node avec TensorZero.

1. Déployez `tensorzero/gateway` à l'aide de Docker.
   **[Instructions détaillées →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Configurez la configuration TensorZero.
3. Lancez l'inférence :

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Essayez d'autres fournisseurs facilement : "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Écris un haïku sur l'intelligence artificielle.",
    },
  ],
});
```

Voir **[Démarrage rapide](https://www.tensorzero.com/docs/quickstart)** pour plus d'informations.

</details>

<details>
<summary><b>Utilisation : Autres Langages & Plateformes &mdash; API HTTP</b></summary>

TensorZero prend en charge pratiquement tous les langages de programmation ou plateformes via son API HTTP.

1. Déployez `tensorzero/gateway` à l'aide de Docker.
   **[Instructions détaillées →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Optionnel : Configurez TensorZero.
3. Lancez l'inférence :

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Écris un haïku sur l'intelligence artificielle."
        }
      ]
    }
  }'
```

Voir **[Démarrage rapide](https://www.tensorzero.com/docs/quickstart)** pour plus d'informations.

</details>

<br>

### 📈 Optimisation LLM

> **Envoyez des métriques de production et des retours humains pour optimiser facilement vos prompts, modèles et stratégies d'inférence &mdash; via l'interface utilisateur ou par programmation.**

#### Optimisation de modèle

Optimisez les modèles propriétaires et open-source en utilisant l'ajustement supervisé (SFT) et l'ajustement par préférence (DPO).

<table>
  <tr></tr> <!-- inverser l'ordre de surbrillance -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Ajustement supervisé &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Ajustement par préférence (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Optimisation à l'inférence

Améliorez les performances en mettant à jour dynamiquement vos prompts avec des exemples pertinents, en combinant les réponses de plusieurs inférences, et plus encore.

<table>
  <tr></tr> <!-- inverser l'ordre de surbrillance -->
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

_D'autres arrivent bientôt..._

<br>

#### Optimisation de prompt

Optimisez vos prompts par programmation à l'aide de techniques d'optimisation issues de la recherche.

<table>
  <tr></tr> <!-- inverser l'ordre de surbrillance -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">Intégration DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero est fourni avec plusieurs recettes d'optimisation, mais vous pouvez également créer facilement les vôtres.
      Cet exemple montre comment optimiser une fonction TensorZero en utilisant un outil arbitraire — ici, DSPy, une bibliothèque populaire pour l'ingénierie de prompts automatisée.
    </td>
  </tr>
</table>

_D'autres arrivent bientôt..._

<br>

### 🔍 Observabilité LLM

> **Zoomez pour déboguer les appels API individuels, ou dézoomez pour surveiller les métriques à travers les modèles et prompts dans le temps &mdash; tout cela grâce à l'interface open-source de TensorZero.**

<table>
  <tr></tr> <!-- inverser l'ordre de surbrillance -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Observabilité » Inférence</b></td>
    <td width="50%" align="center" valign="middle"><b>Observabilité » Fonction</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 Évaluations LLM

> **Comparez les prompts, modèles et stratégies d'inférence à l'aide des évaluations TensorZero &mdash; avec prise en charge des heuristiques et juges LLM.**

<table>
  <tr></tr> <!-- inverser l'ordre de surbrillance -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Évaluation » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Évaluation » CLI</b></td>
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
semantic_match : 0,98 ± 0,01  
item_count : 7,15 ± 0,39</code></pre>
    </td>
  </tr>
</table>

## Démo

> **Regardez les LLMs s'améliorer en extraction de données en temps réel avec TensorZero !**
>
> **[Dynamic in-context learning (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** est une puissante optimisation au moment de l'inférence, disponible immédiatement avec TensorZero.
> Cela améliore la performance des LLM en intégrant automatiquement des exemples historiques pertinents dans le prompt, sans avoir besoin d'un ajustement du modèle.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## Ingénierie LLM avec TensorZero

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

1. La **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** est une passerelle de modèles haute performance écrite en Rust 🦀 qui offre une interface API unifiée pour tous les principaux fournisseurs de LLM, permettant une intégration et des solutions de repli multiplateformes transparentes.
2. Elle gère l'inférence structurée basée sur des schémas avec une latence P99 &lt;1ms (voir **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**), l'observabilité intégrée, l'expérimentation et les **[optimisations au moment de l'inférence](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. Elle collecte également des métriques et des retours associés à ces inférences, avec une prise en charge native des systèmes LLM multi-étapes.
4. Toutes les données sont stockées dans un entrepôt de données ClickHouse que vous contrôlez, pour une analytique en temps réel, évolutive et conviviale pour les développeurs.
5. Au fil du temps, les **[Recettes TensorZero](https://www.tensorzero.com/docs/recipes)** exploitent cet ensemble de données structuré pour optimiser vos prompts et modèles : exécutez des recettes pré-construites pour des workflows courants comme le fine-tuning, ou créez les vôtres avec une flexibilité totale, en utilisant n'importe quel langage et plateforme.
6. Enfin, les fonctionnalités d'expérimentation et l'orchestration GitOps de la passerelle vous permettent d'itérer et de déployer en toute confiance, qu'il s'agisse d'un seul LLM ou de milliers de LLMs.

Notre objectif est d'aider les ingénieurs à construire, gérer et optimiser la prochaine génération d'applications LLM : des systèmes qui apprennent de l'expérience réelle.
En savoir plus sur notre **[Vision & Feuille de route](https://www.tensorzero.com/docs/vision-roadmap/)**.

## Commencer

**Commencez à construire dès aujourd'hui.**
Le **[Démarrage rapide](https://www.tensorzero.com/docs/quickstart)** montre qu'il est facile de mettre en place une application LLM avec TensorZero.
Si vous souhaitez aller plus loin, le **[Tutoriel](https://www.tensorzero.com/docs/gateway/tutorial)** vous apprend à construire un chatbot simple, un copilote email, un système météo RAG, et un pipeline d'extraction de données structurées.

**Des questions ?**
Rejoignez-nous sur **[Slack](https://www.tensorzero.com/slack)** ou **[Discord](https://www.tensorzero.com/discord)**.

**Vous utilisez TensorZero au travail ?**
Écrivez-nous à **[hello@tensorzero.com](mailto:hello@tensorzero.com)** pour créer un canal Slack ou Teams avec votre équipe (gratuitement).

**Rejoignez-nous.**
Nous **[recrutons à New York](https://www.tensorzero.com/jobs)**.
Nous accueillons également les **[contributions open-source](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)** !

## Exemples

Nous préparons une série de **cas d'usage complets et exécutables** illustrant le flywheel de données & d'apprentissage de TensorZero.

> **[Optimisation de l'extraction de données (NER) avec TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Cet exemple montre comment utiliser TensorZero pour optimiser un pipeline d'extraction de données.
> Nous démontrons des techniques comme le fine-tuning et l'apprentissage dynamique en contexte (DICL).
> Au final, un modèle GPT-4o Mini optimisé surpasse GPT-4o sur cette tâche &mdash; pour une fraction du coût et de la latence &mdash; en utilisant une petite quantité de données d'entraînement.

> **[Agentic RAG — Questionnement multi-sauts avec LLMs](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Cet exemple montre comment construire un agent de recherche multi-sauts avec TensorZero.
> L'agent recherche de manière itérative sur Wikipédia pour rassembler des informations, et décide quand il dispose de suffisamment de contexte pour répondre à une question complexe.

> **[Générer des haïkus pour satisfaire un juge aux préférences cachées](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> Cet exemple ajuste GPT-4o Mini pour générer des haïkus adaptés à un goût particulier.
> Vous verrez le "data flywheel in a box" de TensorZero en action : de meilleures variantes produisent de meilleures données, et de meilleures données mènent à de meilleures variantes.
> Vous verrez la progression en ré-entraînant le LLM plusieurs fois.

> **[Améliorer les capacités aux échecs d'un LLM avec le Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Cet exemple montre comment le best-of-N sampling peut considérablement améliorer les performances d'un LLM aux échecs en sélectionnant les coups les plus prometteurs parmi plusieurs options générées.

> **[Améliorer le raisonnement mathématique avec une recette personnalisée pour l’ingénierie automatisée des prompts (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero propose un certain nombre de recettes d'optimisation prêtes à l'emploi pour les workflows classiques d'ingénierie LLM.
> Mais vous pouvez aussi facilement créer vos propres recettes et workflows !
> Cet exemple montre comment optimiser une fonction TensorZero à l'aide d'un outil arbitraire — ici, DSPy.

_& bien d'autres à venir !_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---