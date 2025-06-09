<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**O TensorZero cria um ciclo de feedback para otimizar aplicações LLM — transformando dados de produção em modelos mais inteligentes, rápidos e econômicos.**

1. Integre nosso gateway de modelos
2. Envie métricas ou feedbacks
3. Otimize prompts, modelos e estratégias de inferência
4. Observe seus LLMs melhorando ao longo do tempo

Ele fornece um **flywheel de dados e aprendizado para LLMs** ao unificar:

- [x] **Inferência:** uma API para todos os LLMs, com overhead P99 <1ms
- [x] **Observabilidade:** inferência & feedback → seu banco de dados
- [x] **Otimização:** de prompts ao fine-tuning e RL
- [x] **Avaliações:** compare prompts, modelos, estratégias de inferência
- [x] **Experimentação:** teste A/B integrado, roteamento, fallbacks

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Website</a></b>
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
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Comece Rápido (5min)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Tutorial Completo</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Guia de Deploy</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">Referência da API</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Referência de Configuração</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>O que é o TensorZero?</b></td>
    <td width="70%" valign="top">TensorZero é um framework open-source para construir aplicações LLM de nível de produção. Ele unifica um gateway LLM, observabilidade, otimização, avaliações e experimentação.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Como o TensorZero se diferencia de outros frameworks de LLM?</b></td>
    <td width="70%" valign="top">
      1. O TensorZero permite que você otimize aplicações LLM complexas com base em métricas de produção e feedback humano.<br>
      2. O TensorZero atende às necessidades de aplicações LLM em escala industrial: baixa latência, alta vazão, tipagem segura, auto-hospedado, GitOps, customizável, etc.<br>
      3. O TensorZero unifica toda a stack LLMOps, criando benefícios compostos. Por exemplo, avaliações de LLM podem ser usadas para fine-tuning de modelos junto com juízes IA.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Posso usar o TensorZero com ___?</b></td>
    <td width="70%" valign="top">Sim. Todo grande idioma de programação é suportado. Você pode usar o TensorZero com nosso cliente Python, qualquer SDK OpenAI, ou nossa API HTTP.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>O TensorZero está pronto para produção?</b></td>
    <td width="70%" valign="top">Sim. Aqui está um estudo de caso: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Automatizando Changelogs de Código em um Grande Banco com LLMs</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Quanto custa o TensorZero?</b></td>
    <td width="70%" valign="top">Nada. O TensorZero é 100% auto-hospedado e open-source. Não existem recursos pagos.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Quem está construindo o TensorZero?</b></td>
    <td width="70%" valign="top">Nossa equipe técnica inclui um ex-mantenedor do compilador Rust, pesquisadores de machine learning (Stanford, CMU, Oxford, Columbia) com milhares de citações, e o chief product officer de uma startup decacorn. Somos apoiados pelos mesmos investidores de projetos open-source líderes (ex: ClickHouse, CockroachDB) e laboratórios de IA (ex: OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>Como começo?</b></td>
    <td width="70%" valign="top">Você pode adotar o TensorZero incrementalmente. Nosso <b><a href="https://www.tensorzero.com/docs/quickstart">Comece Rápido</a></b> vai de um wrapper OpenAI puro para uma aplicação LLM pronta para produção com observabilidade e fine-tuning em apenas 5 minutos.</td>
  </tr>
</table>

---

## Funcionalidades

### 🌐 Gateway LLM

> **Integre-se ao TensorZero uma vez e acesse todos os principais provedores de LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Provedores de Modelos</b></td>
    <td width="50%" align="center" valign="middle"><b>Funcionalidades</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        O Gateway TensorZero suporta nativamente:
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
          Precisa de outro provedor?
          Seu provedor provavelmente é suportado, pois o TensorZero integra-se a <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">qualquer API compatível com OpenAI (ex: Ollama)</a></b>.
        </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        O Gateway TensorZero suporta funcionalidades avançadas como:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Retentativas & Fallbacks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Otimizações em Tempo de Inferência</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Templates e Schemas de Prompt</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Experimentação (Teste A/B)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Configuration-as-Code (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Inferência em Lote</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Inferência Multimodal (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Cache de Inferência</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Métricas & Feedback</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Workflows LLM Multi-Etapas (Episódios)</a></b></li>
        <li><em>& muito mais...</em></li>
      </ul>
      <p>
        O Gateway TensorZero é escrito em Rust 🦀 com foco em <b>performance</b> (&lt;1ms de overhead de latência p99 @ 10k QPS).
        Veja <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmarks</a></b>.<br>
      </p>
      <p>
        Você pode rodar inferências usando o <b>cliente TensorZero</b> (recomendado), o <b>cliente OpenAI</b> ou a <b>API HTTP</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Uso: Python &mdash; Cliente TensorZero (Recomendado)</b></summary>

Você pode acessar qualquer provedor usando o cliente Python do TensorZero.

1. `pip install tensorzero`
2. Opcional: Configure o TensorZero.
3. Execute a inferência:

```python
from tensorzero import TensorZeroGateway  # ou AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Experimente outros provedores facilmente: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Escreva um haicai sobre inteligência artificial.",
                }
            ]
        },
    )
```

Veja **[Comece Rápido](https://www.tensorzero.com/docs/quickstart)** para mais informações.

</details>

<details>
<summary><b>Uso: Python &mdash; Cliente OpenAI</b></summary>

Você pode acessar qualquer provedor usando o cliente Python da OpenAI com o TensorZero.

1. `pip install tensorzero`
2. Opcional: Configure o TensorZero.
3. Execute a inferência:

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
    # Experimente outros provedores facilmente: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Escreva um haicai sobre inteligência artificial.",
        }
    ],
)
```

Veja **[Início Rápido](https://www.tensorzero.com/docs/quickstart)** para mais informações.

</details>

<details>
<summary><b>Uso: JavaScript / TypeScript (Node) &mdash; Cliente OpenAI</b></summary>

Você pode acessar qualquer provedor usando o cliente OpenAI Node com o TensorZero.

1. Faça o deploy do `tensorzero/gateway` usando Docker.
   **[Instruções detalhadas →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Configure o TensorZero.
3. Execute a inferência:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Experimente outros provedores facilmente: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Escreva um haicai sobre inteligência artificial.",
    },
  ],
});
```

Veja **[Início Rápido](https://www.tensorzero.com/docs/quickstart)** para mais informações.

</details>

<details>
<summary><b>Uso: Outras Linguagens & Plataformas &mdash; API HTTP</b></summary>

O TensorZero suporta praticamente qualquer linguagem de programação ou plataforma via sua API HTTP.

1. Faça o deploy do `tensorzero/gateway` usando Docker.
   **[Instruções detalhadas →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Opcional: configure o TensorZero.
3. Execute a inferência:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Escreva um haicai sobre inteligência artificial."
        }
      ]
    }
  }'
```

Veja **[Início Rápido](https://www.tensorzero.com/docs/quickstart)** para mais informações.

</details>

<br>

### 📈 Otimização de LLM

> **Envie métricas de produção e feedback humano para otimizar facilmente seus prompts, modelos e estratégias de inferência &mdash; usando a interface ou programaticamente.**

#### Otimização de Modelo

Otimize modelos de código fechado e aberto usando fine-tuning supervisionado (SFT) e fine-tuning por preferência (DPO).

<table>
  <tr></tr> <!-- inverter ordem do destaque -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Fine-tuning Supervisionado &mdash; Interface</b></td>
    <td width="50%" align="center" valign="middle"><b>Fine-tuning por Preferência (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Otimização em Tempo de Inferência

Aumente o desempenho atualizando dinamicamente seus prompts com exemplos relevantes, combinando respostas de múltiplas inferências, e mais.

<table>
  <tr></tr> <!-- inverter ordem do destaque -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N Sampling</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N Sampling</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">Aprendizagem Dinâmica de Contexto (DICL)</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Cadeia de Pensamento (CoT)</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_Mais em breve..._

<br>

#### Otimização de Prompt

Otimize seus prompts programaticamente utilizando técnicas de otimização baseadas em pesquisas.

<table>
  <tr></tr> <!-- inverter ordem do destaque -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">Integração DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="Diagrama MIPROv2"></td>
    <td width="50%" align="center" valign="middle">
      O TensorZero vem com várias receitas de otimização, mas você também pode criar facilmente as suas próprias.
      Este exemplo mostra como otimizar uma função do TensorZero usando uma ferramenta arbitrária — aqui, o DSPy, uma biblioteca popular para engenharia de prompts automatizada.
    </td>
  </tr>
</table>

_Mais em breve..._

<br>

### 🔍 Observabilidade de LLM

> **Aproxime para depurar chamadas individuais de API, ou afaste para monitorar métricas entre modelos e prompts ao longo do tempo &mdash; tudo usando a interface open-source do TensorZero.**

<table>
  <tr></tr> <!-- inverter ordem do destaque -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Observabilidade » Inferência</b></td>
    <td width="50%" align="center" valign="middle"><b>Observabilidade » Função</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 Avaliações de LLM

> **Compare prompts, modelos e estratégias de inferência usando as Avaliações do TensorZero &mdash; com suporte para heurísticas e juízes LLM.**

<table>
  <tr></tr> <!-- inverter ordem do destaque -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Avaliação » Interface</b></td>
    <td width="50%" align="center" valign="middle"><b>Avaliação » CLI</b></td>
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

## Demonstração

> **Veja LLMs melhorando na extração de dados em tempo real com TensorZero!**
>
> **[Aprendizado dinâmico em contexto (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** é uma poderosa otimização em tempo de inferência disponível nativamente com o TensorZero.
> Ele aprimora o desempenho de LLMs incorporando automaticamente exemplos históricos relevantes no prompt, sem necessidade de ajuste fino do modelo.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## Engenharia de LLM com TensorZero

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

1. O **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** é um gateway de modelos de alto desempenho escrito em Rust 🦀 que fornece uma interface de API unificada para todos os principais provedores de LLM, permitindo integração e fallback entre plataformas de forma transparente.
2. Ele realiza inferência estruturada baseada em esquemas com overhead de latência P99 &lt;1ms (veja os **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) e possui observabilidade, experimentação e **[otimizações em tempo de inferência](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)** integradas.
3. Também coleta métricas downstream e feedbacks associados a essas inferências, com suporte de primeira classe para sistemas LLM multi-etapas.
4. Tudo é armazenado em um data warehouse ClickHouse que você controla, para análises em tempo real, escaláveis e amigáveis ao desenvolvedor.
5. Com o tempo, as **[Receitas TensorZero](https://www.tensorzero.com/docs/recipes)** aproveitam esse conjunto de dados estruturados para otimizar seus prompts e modelos: execute receitas prontas para fluxos de trabalho comuns como fine-tuning ou crie as suas próprias com total flexibilidade usando qualquer linguagem e plataforma.
6. Finalmente, os recursos de experimentação do gateway e a orquestração GitOps permitem que você itere e faça deploy com confiança, seja de um único LLM ou de milhares deles.

Nosso objetivo é ajudar engenheiros a construir, gerenciar e otimizar a próxima geração de aplicações LLM: sistemas que aprendem com experiências do mundo real.
Leia mais sobre nossa **[Visão & Roadmap](https://www.tensorzero.com/docs/vision-roadmap/)**.

## Primeiros Passos

**Comece a construir hoje.**
O **[Guia Rápido](https://www.tensorzero.com/docs/quickstart)** mostra como é fácil configurar uma aplicação LLM com o TensorZero.
Se quiser se aprofundar, o **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)** ensina como construir um chatbot simples, um copiloto de email, um sistema RAG de clima e um pipeline de extração de dados estruturados.

**Dúvidas?**
Pergunte para nós no **[Slack](https://www.tensorzero.com/slack)** ou **[Discord](https://www.tensorzero.com/discord)**.

**Usando TensorZero no trabalho?**
Envie um e-mail para **[hello@tensorzero.com](mailto:hello@tensorzero.com)** para criar um canal Slack ou Teams com sua equipe (gratuito).

**Trabalhe conosco.**
Estamos **[contratando em Nova York](https://www.tensorzero.com/jobs)**.
Também aceitamos **[contribuições open-source](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Exemplos

Estamos trabalhando em uma série de **exemplos completos e executáveis** ilustrando o ciclo de dados & aprendizado do TensorZero.

> **[Otimização de Extração de Dados (NER) com TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Este exemplo mostra como usar o TensorZero para otimizar um pipeline de extração de dados.
> Demonstramos técnicas como fine-tuning e aprendizado dinâmico em contexto (DICL).
> No final, um modelo GPT-4o Mini otimizado supera o GPT-4o nesta tarefa &mdash; a uma fração do custo e da latência &mdash; usando uma pequena quantidade de dados de treinamento.

> **[Agentic RAG — Resposta a Perguntas Multi-Hop com LLMs](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Este exemplo mostra como construir um agente de recuperação multi-hop usando o TensorZero.
> O agente pesquisa iterativamente a Wikipédia para reunir informações e decide quando tem contexto suficiente para responder uma pergunta complexa.

> **[Escrevendo Haikais para Satisfazer um Juiz com Preferências Ocultas](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> Este exemplo faz fine-tuning no GPT-4o Mini para gerar haikais personalizados para um gosto específico.
> Você verá o "ciclo de dados em uma caixa" do TensorZero em ação: melhores variantes levam a melhores dados, e melhores dados levam a melhores variantes.
> Você verá progresso refinando o LLM múltiplas vezes.

> **[Melhorando a Habilidade de Xadrez do LLM com Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Este exemplo mostra como o best-of-N sampling pode melhorar significativamente a habilidade de jogo de xadrez de um LLM, selecionando os movimentos mais promissores entre várias opções geradas.

> **[Aprimorando o Raciocínio Matemático com Receita Customizada de Engenharia Automatizada de Prompts (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> O TensorZero oferece várias receitas de otimização prontas que cobrem fluxos de trabalho comuns de engenharia de LLMs.
> Mas você também pode criar facilmente suas próprias receitas e fluxos de trabalho!
> Este exemplo mostra como otimizar uma função TensorZero usando qualquer ferramenta — neste caso, DSPy.

_& muitos outros a caminho!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---