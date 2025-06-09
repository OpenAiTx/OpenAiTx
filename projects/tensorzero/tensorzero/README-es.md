<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero crea un bucle de retroalimentación para optimizar aplicaciones LLM — convirtiendo datos de producción en modelos más inteligentes, rápidos y económicos.**

1. Integra nuestra puerta de enlace de modelos
2. Envía métricas o feedback
3. Optimiza prompts, modelos y estrategias de inferencia
4. Observa cómo tus LLMs mejoran con el tiempo

Proporciona un **círculo virtuoso de datos y aprendizaje para LLMs** al unificar:

- [x] **Inferencia:** una API para todos los LLMs, con <1ms P99 de sobrecarga
- [x] **Observabilidad:** inferencia & feedback → tu base de datos
- [x] **Optimización:** desde prompts hasta ajuste fino y RL
- [x] **Evaluaciones:** compara prompts, modelos, estrategias de inferencia
- [x] **Experimentación:** A/B testing integrado, enrutamiento, fallback

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">Sitio Web</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">Documentación</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">Inicio Rápido (5min)</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">Tutorial Integral</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Guía de Despliegue</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">Referencia API</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">Referencia de Configuración</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>¿Qué es TensorZero?</b></td>
    <td width="70%" valign="top">TensorZero es un framework open-source para construir aplicaciones LLM de nivel producción. Unifica una puerta de enlace LLM, observabilidad, optimización, evaluaciones y experimentación.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>¿En qué se diferencia TensorZero de otros frameworks LLM?</b></td>
    <td width="70%" valign="top">
      1. TensorZero te permite optimizar aplicaciones LLM complejas basadas en métricas de producción y feedback humano.<br>
      2. TensorZero soporta las necesidades de aplicaciones LLM a escala industrial: baja latencia, alto rendimiento, tipado seguro, auto-hospedado, GitOps, personalización, etc.<br>
      3. TensorZero unifica toda la pila LLMOps, creando beneficios acumulativos. Por ejemplo, las evaluaciones LLM pueden utilizarse para afinar modelos junto a jueces IA.
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>¿Puedo usar TensorZero con ___?</b></td>
    <td width="70%" valign="top">Sí. Se soportan todos los lenguajes de programación principales. Puedes usar TensorZero con nuestro cliente Python, cualquier SDK de OpenAI o nuestra API HTTP.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>¿TensorZero está listo para producción?</b></td>
    <td width="70%" valign="top">Sí. Aquí tienes un caso de estudio: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">Automatización de registros de cambios de código en un gran banco con LLMs</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>¿Cuánto cuesta TensorZero?</b></td>
    <td width="70%" valign="top">Nada. TensorZero es 100% auto-hospedado y open-source. No hay funciones de pago.</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>¿Quién está desarrollando TensorZero?</b></td>
    <td width="70%" valign="top">Nuestro equipo técnico incluye un ex-mantenedor del compilador de Rust, investigadores de machine learning (Stanford, CMU, Oxford, Columbia) con miles de citas y el chief product officer de una startup decacorn. Nos respaldan los mismos inversores que los principales proyectos open-source (por ejemplo, ClickHouse, CockroachDB) y laboratorios de IA (por ejemplo, OpenAI, Anthropic).</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>¿Cómo empiezo?</b></td>
    <td width="70%" valign="top">Puedes adoptar TensorZero de manera incremental. Nuestro <b><a href="https://www.tensorzero.com/docs/quickstart">Inicio Rápido</a></b> va desde un wrapper OpenAI básico hasta una aplicación LLM lista para producción con observabilidad y ajuste fino en solo 5 minutos.</td>
  </tr>
</table>

---

## Características

### 🌐 Puerta de Enlace LLM

> **Integra con TensorZero una vez y accede a todos los principales proveedores de LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Proveedores de Modelo</b></td>
    <td width="50%" align="center" valign="middle"><b>Características</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        La puerta de enlace TensorZero soporta de forma nativa:
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
          ¿Necesitas algo más?
          Es muy probable que tu proveedor esté soportado porque TensorZero se integra con <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">cualquier API compatible con OpenAI (por ejemplo, Ollama)</a></b>.
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        La puerta de enlace TensorZero soporta funciones avanzadas como:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">Reintentos & Fallbacks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">Optimizaciones en Tiempo de Inferencia</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">Plantillas y Esquemas de Prompts</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">Experimentación (A/B Testing)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">Configuración como Código (GitOps)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">Inferencia en Lote</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">Inferencia Multimodal (VLMs)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">Cacheo de Inferencias</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">Métricas y Feedback</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">Workflows LLM Multietapa (Episodios)</a></b></li>
        <li><em>& mucho más...</em></li>
      </ul>
      <p>
        La puerta de enlace TensorZero está escrita en Rust 🦀 pensando en el <b>rendimiento</b> (<1ms p99 de latencia extra @ 10k QPS).
        Consulta los <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">Benchmarks</a></b>.<br>
      </p>
      <p>
        Puedes ejecutar inferencias usando el <b>cliente TensorZero</b> (recomendado), el <b>cliente OpenAI</b> o la <b>API HTTP</b>.
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>Uso: Python &mdash; Cliente TensorZero (Recomendado)</b></summary>

Puedes acceder a cualquier proveedor usando el cliente Python de TensorZero.

1. `pip install tensorzero`
2. Opcional: Configura el archivo de configuración de TensorZero.
3. Ejecuta una inferencia:

```python
from tensorzero import TensorZeroGateway  # o AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # Prueba otros proveedores fácilmente: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "Escribe un haiku sobre inteligencia artificial.",
                }
            ]
        },
    )
```

Consulta **[Inicio Rápido](https://www.tensorzero.com/docs/quickstart)** para más información.

</details>

<details>
<summary><b>Uso: Python &mdash; Cliente OpenAI</b></summary>

Puedes acceder a cualquier proveedor usando el cliente Python de OpenAI con TensorZero.

1. `pip install tensorzero`
2. Opcional: Configura el archivo de configuración de TensorZero.
3. Ejecuta una inferencia:

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
    # Prueba otros proveedores fácilmente: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "Escribe un haiku sobre inteligencia artificial.",
        }
    ],
)
```

Consulta **[Inicio Rápido](https://www.tensorzero.com/docs/quickstart)** para más información.

</details>

<details>
<summary><b>Uso: JavaScript / TypeScript (Node) &mdash; Cliente OpenAI</b></summary>

Puedes acceder a cualquier proveedor utilizando el cliente OpenAI Node con TensorZero.

1. Despliega `tensorzero/gateway` usando Docker.
   **[Instrucciones detalladas →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Configura la configuración de TensorZero.
3. Ejecuta la inferencia:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // Prueba otros proveedores fácilmente: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "Escribe un haiku sobre inteligencia artificial.",
    },
  ],
});
```

Consulta **[Inicio Rápido](https://www.tensorzero.com/docs/quickstart)** para más información.

</details>

<details>
<summary><b>Uso: Otros Lenguajes y Plataformas &mdash; API HTTP</b></summary>

TensorZero es compatible prácticamente con cualquier lenguaje de programación o plataforma a través de su API HTTP.

1. Despliega `tensorzero/gateway` usando Docker.
   **[Instrucciones detalladas →](https://www.tensorzero.com/docs/gateway/deployment)**
2. Opcional: Configura la configuración de TensorZero.
3. Ejecuta la inferencia:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "Escribe un haiku sobre inteligencia artificial."
        }
      ]
    }
  }'
```

Consulta **[Inicio Rápido](https://www.tensorzero.com/docs/quickstart)** para más información.

</details>

<br>

### 📈 Optimización de LLM

> **Envía métricas de producción y feedback humano para optimizar fácilmente tus prompts, modelos y estrategias de inferencia — usando la interfaz de usuario o de forma programática.**

#### Optimización de Modelos

Optimiza modelos de código cerrado y abierto usando fine-tuning supervisado (SFT) y fine-tuning por preferencia (DPO).

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Fine-tuning Supervisado &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Fine-tuning por Preferencia (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### Optimización en Tiempo de Inferencia

Mejora el rendimiento actualizando dinámicamente tus prompts con ejemplos relevantes, combinando respuestas de múltiples inferencias y más.

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

_Más próximamente..._

<br>

#### Optimización de Prompts

Optimiza tus prompts de manera programática usando técnicas de optimización basadas en investigación.

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">Integración DSPy</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero incluye varias recetas de optimización, pero también puedes crear fácilmente las tuyas propias.
      Este ejemplo muestra cómo optimizar una función de TensorZero usando una herramienta arbitraria — en este caso, DSPy, una biblioteca popular para ingeniería de prompts automatizada.
    </td>
  </tr>
</table>

_Más próximamente..._

<br>

### 🔍 Observabilidad LLM

> **Haz zoom para depurar llamadas individuales a la API, o haz zoom hacia afuera para monitorizar métricas entre modelos y prompts a lo largo del tiempo — todo usando la interfaz de usuario open-source de TensorZero.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Observabilidad » Inferencia</b></td>
    <td width="50%" align="center" valign="middle"><b>Observabilidad » Función</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 Evaluaciones LLM

> **Compara prompts, modelos y estrategias de inferencia usando TensorZero Evaluations — con soporte para heurísticas y jueces LLM.**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>Evaluación » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>Evaluación » CLI</b></td>
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
semantic_match: 0.98 ± 0.01
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## Demostración

> **¡Mira cómo los LLM mejoran en la extracción de datos en tiempo real con TensorZero!**
>
> **[Dynamic in-context learning (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** es una potente optimización en tiempo de inferencia disponible de forma predeterminada con TensorZero.
> Mejora el rendimiento de los LLM incorporando automáticamente ejemplos históricos relevantes en el prompt, sin necesidad de ajuste fino del modelo.

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## Ingeniería LLM con TensorZero

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

1. El **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** es una puerta de enlace de modelos de alto rendimiento escrita en Rust 🦀 que proporciona una interfaz API unificada para todos los principales proveedores de LLM, permitiendo una integración y conmutación entre plataformas sin problemas.
2. Maneja inferencia estructurada basada en esquemas con una sobrecarga de latencia P99 &lt;1ms (ver **[Benchmarks](https://www.tensorzero.com/docs/gateway/benchmarks)**) y observabilidad incorporada, experimentación y **[optimizaciones en tiempo de inferencia](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**.
3. También recopila métricas downstream y retroalimentación asociada a estas inferencias, con soporte de primera clase para sistemas LLM de múltiples pasos.
4. Todo se almacena en un data warehouse ClickHouse que tú controlas para obtener analíticas en tiempo real, escalables y amigables para desarrolladores.
5. Con el tiempo, **[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** aprovecha este dataset estructurado para optimizar tus prompts y modelos: ejecuta recetas preconstruidas para flujos de trabajo comunes como fine-tuning, o crea las tuyas propias con total flexibilidad usando cualquier lenguaje y plataforma.
6. Finalmente, las funciones de experimentación y la orquestación GitOps del gateway te permiten iterar y desplegar con confianza, ya sea un solo LLM o miles de LLMs.

Nuestro objetivo es ayudar a ingenieros a construir, gestionar y optimizar la próxima generación de aplicaciones LLM: sistemas que aprenden de la experiencia real.
Lee más sobre nuestra **[Visión y hoja de ruta](https://www.tensorzero.com/docs/vision-roadmap/)**.

## Comienza

**Empieza a construir hoy.**
La **[Guía Rápida](https://www.tensorzero.com/docs/quickstart)** muestra lo fácil que es configurar una aplicación LLM con TensorZero.
Si quieres profundizar, el **[Tutorial](https://www.tensorzero.com/docs/gateway/tutorial)** enseña cómo construir un chatbot simple, un copiloto de correo electrónico, un sistema RAG meteorológico y una canalización de extracción de datos estructurados.

**¿Preguntas?**
Pregúntanos en **[Slack](https://www.tensorzero.com/slack)** o **[Discord](https://www.tensorzero.com/discord)**.

**¿Usas TensorZero en el trabajo?**
Envíanos un correo a **[hello@tensorzero.com](mailto:hello@tensorzero.com)** para crear un canal de Slack o Teams con tu equipo (gratis).

**Trabaja con nosotros.**
Estamos **[contratando en NYC](https://www.tensorzero.com/jobs)**.
¡También damos la bienvenida a **[contribuciones open-source](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)**!

## Ejemplos

Estamos trabajando en una serie de **ejemplos completos y ejecutables** que ilustran el ciclo de datos y aprendizaje de TensorZero.

> **[Optimizando la extracción de datos (NER) con TensorZero](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> Este ejemplo muestra cómo usar TensorZero para optimizar una canalización de extracción de datos.
> Demostramos técnicas como fine-tuning y dynamic in-context learning (DICL).
> Al final, un modelo GPT-4o Mini optimizado supera a GPT-4o en esta tarea &mdash; a una fracción del costo y la latencia &mdash; usando una pequeña cantidad de datos de entrenamiento.

> **[Agentic RAG — Respuesta a preguntas multi-hop con LLMs](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> Este ejemplo muestra cómo construir un agente de recuperación multi-hop usando TensorZero.
> El agente busca iterativamente en Wikipedia para reunir información, y decide cuándo tiene suficiente contexto para responder una pregunta compleja.

> **[Escribiendo haikus para satisfacer a un juez con preferencias ocultas](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> Este ejemplo afina GPT-4o Mini para generar haikus adaptados a un gusto específico.
> Verás el "flywheel de datos en una caja" de TensorZero en acción: mejores variantes generan mejores datos, y mejores datos generan mejores variantes.
> Verás el progreso afinando el LLM varias veces.

> **[Mejorando la habilidad de ajedrez de los LLM con Best-of-N Sampling](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> Este ejemplo muestra cómo el muestreo best-of-N puede mejorar significativamente las habilidades de ajedrez de un LLM al seleccionar los movimientos más prometedores de entre varias opciones generadas.

> **[Mejorando el razonamiento matemático con una receta personalizada para prompt engineering automatizado (DSPy)](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero proporciona una serie de recetas de optimización preconstruidas que cubren flujos de trabajo comunes de ingeniería LLM.
> ¡Pero también puedes crear fácilmente tus propias recetas y flujos de trabajo!
> Este ejemplo muestra cómo optimizar una función de TensorZero usando cualquier herramienta — en este caso, DSPy.

_¡Y muchos más en camino!_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---