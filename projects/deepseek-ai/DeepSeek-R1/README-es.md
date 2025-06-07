# DeepSeek-R1
<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-R1" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/" target="_blank"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/" target="_blank"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20R1-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai" target="_blank"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5" target="_blank"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true" target="_blank"><img alt="WeChat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai" target="_blank"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE"><img alt="License"
    src="https://img.shields.io/badge/License-MIT-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/DeepSeek_R1.pdf"><b>Enlace al Artículo</b>👁️</a>
</div>

## 1. Introducción

Presentamos nuestros modelos de razonamiento de primera generación, DeepSeek-R1-Zero y DeepSeek-R1.  
DeepSeek-R1-Zero, un modelo entrenado mediante aprendizaje por refuerzo (RL) a gran escala sin ajuste fino supervisado (SFT) como paso preliminar, demostró un rendimiento notable en razonamiento.  
Con RL, DeepSeek-R1-Zero desarrolló de manera natural numerosos comportamientos de razonamiento potentes e interesantes.  
Sin embargo, DeepSeek-R1-Zero enfrenta desafíos como repetición infinita, baja legibilidad y mezcla de idiomas. Para abordar estos problemas y mejorar aún más el rendimiento en razonamiento, presentamos DeepSeek-R1, que incorpora datos de arranque en frío antes del RL.  
DeepSeek-R1 logra un rendimiento comparable a OpenAI-o1 en tareas de matemáticas, código y razonamiento.  
Para apoyar a la comunidad de investigación, hemos liberado el código fuente de DeepSeek-R1-Zero, DeepSeek-R1 y seis modelos densos destilados de DeepSeek-R1 basados en Llama y Qwen. DeepSeek-R1-Distill-Qwen-32B supera a OpenAI-o1-mini en varios benchmarks, logrando nuevos resultados de vanguardia para modelos densos.

**NOTA: Antes de ejecutar localmente los modelos de la serie DeepSeek-R1, recomendamos revisar la sección [Recomendaciones de uso](#usage-recommendations).**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. Resumen del Modelo

---

**Post-Entrenamiento: Aprendizaje por Refuerzo a Gran Escala en el Modelo Base**

-  Aplicamos directamente aprendizaje por refuerzo (RL) al modelo base sin depender del ajuste fino supervisado (SFT) como paso preliminar. Este enfoque permite que el modelo explore cadenas de pensamiento (CoT) para resolver problemas complejos, dando como resultado el desarrollo de DeepSeek-R1-Zero. DeepSeek-R1-Zero demuestra capacidades como auto-verificación, reflexión y generación de largas cadenas de pensamiento, marcando un hito significativo para la comunidad investigadora. Cabe destacar que es la primera investigación abierta que valida que las capacidades de razonamiento de los LLM pueden incentivarse únicamente mediante RL, sin necesidad de SFT. Este avance allana el camino para futuros desarrollos en esta área.

-  Presentamos nuestra pipeline para desarrollar DeepSeek-R1. La pipeline incorpora dos etapas de RL dirigidas a descubrir mejores patrones de razonamiento y alinearse con las preferencias humanas, así como dos etapas de SFT que sirven como semilla para las capacidades de razonamiento y no razonamiento del modelo.  
Creemos que la pipeline beneficiará a la industria al crear mejores modelos.

---

**Destilación: Los Modelos Más Pequeños También Pueden Ser Potentes**

-  Demostramos que los patrones de razonamiento de modelos más grandes pueden destilarse en modelos más pequeños, resultando en un mejor rendimiento comparado con los patrones de razonamiento descubiertos mediante RL en modelos pequeños. El DeepSeek-R1 open source, así como su API, beneficiará a la comunidad de investigación para destilar mejores modelos pequeños en el futuro.
-  Utilizando los datos de razonamiento generados por DeepSeek-R1, afinamos varios modelos densos que son ampliamente utilizados en la comunidad investigadora. Los resultados de la evaluación demuestran que los modelos densos destilados pequeños tienen un rendimiento excepcional en los benchmarks. Liberamos los checkpoints destilados de 1.5B, 7B, 8B, 14B, 32B y 70B basados en Qwen2.5 y la serie Llama3 para la comunidad.

## 3. Descarga de Modelos

### Modelos DeepSeek-R1

<div align="center">

| **Modelo** | **#Total de Parámetros** | **#Parámetros Activados** | **Longitud de Contexto** | **Descargar** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero y DeepSeek-R1 se entrenan a partir de DeepSeek-V3-Base.  
Para más detalles respecto a la arquitectura del modelo, por favor consulte el repositorio de [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3).

### Modelos DeepSeek-R1-Distill

<div align="center">

| **Modelo** | **Modelo Base** | **Descargar** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

Los modelos DeepSeek-R1-Distill están afinados a partir de modelos open source, utilizando muestras generadas por DeepSeek-R1.  
Hemos realizado pequeños cambios en sus configuraciones y tokenizadores. Por favor, utilice nuestra configuración para ejecutar estos modelos.

## 4. Resultados de Evaluación

### DeepSeek-R1-Evaluación
Para todos nuestros modelos, la longitud máxima de generación se establece en 32,768 tokens. Para benchmarks que requieren muestreo, utilizamos una temperatura de $0.6$, un valor top-p de $0.95$ y generamos 64 respuestas por consulta para estimar pass@1.
<div align="center">


| Categoría | Benchmark (Métrica) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|---------------------|------------------------|-------------|--------------|----------------|---------------|-------------|
| | Arquitectura | - | - | MoE | - | - | MoE |
| | # Parámetros Activados | - | - | 37B | - | - | 37B |
| | # Total de Parámetros | - | - | 671B | - | - | 671B |
| Inglés | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correcto) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Prec.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| Código | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentil) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resueltos) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Prec.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| Matemáticas | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| Chino | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correcto) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### Evaluación de Modelos Destilados

<div align="center">

| Modelo                                   | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
|------------------------------------------|------------------|-------------------|-----------------|----------------------|----------------------|-------------------|
| GPT-4o-0513                              | 9.3              | 13.4              | 74.6            | 49.9                 | 32.9                 | 759               |
| Claude-3.5-Sonnet-1022                   | 16.0             | 26.7              | 78.3            | 65.0                 | 38.9                 | 717               |
| o1-mini                                  | 63.6             | 80.0              | 90.0            | 60.0                 | 53.8                 | **1820**          |
| QwQ-32B-Preview                          | 44.0             | 60.0              | 90.6            | 54.5                 | 41.9                 | 1316              |
| DeepSeek-R1-Distill-Qwen-1.5B            | 28.9             | 52.7              | 83.9            | 33.8                 | 16.9                 | 954               |
| DeepSeek-R1-Distill-Qwen-7B              | 55.5             | 83.3              | 92.8            | 49.1                 | 37.6                 | 1189              |
| DeepSeek-R1-Distill-Qwen-14B             | 69.7             | 80.0              | 93.9            | 59.1                 | 53.1                 | 1481              |
| DeepSeek-R1-Distill-Qwen-32B             | **72.6**         | 83.3              | 94.3            | 62.1                 | 57.2                 | 1691              |
| DeepSeek-R1-Distill-Llama-8B             | 50.4             | 80.0              | 89.1            | 49.0                 | 39.6                 | 1205              |
| DeepSeek-R1-Distill-Llama-70B            | 70.0             | **86.7**          | **94.5**        | **65.2**             | **57.5**             | 1633              |

</div>


## 5. Sitio Web de Chat y Plataforma API
Puede conversar con DeepSeek-R1 en el sitio web oficial de DeepSeek: [chat.deepseek.com](https://chat.deepseek.com) y activar el botón "DeepThink".

También proveemos API compatible con OpenAI en la Plataforma DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Cómo Ejecutar Localmente

### Modelos DeepSeek-R1

Por favor, visite el repositorio [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) para obtener más información sobre cómo ejecutar DeepSeek-R1 localmente.

**NOTA: Aún no se ha soportado directamente Transformers de Hugging Face.**

### Modelos DeepSeek-R1-Distill

Los modelos DeepSeek-R1-Distill pueden ser utilizados de la misma manera que los modelos Qwen o Llama.

Por ejemplo, puede iniciar fácilmente un servicio usando [vLLM](https://github.com/vllm-project/vllm):

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

También puede iniciar un servicio fácilmente usando [SGLang](https://github.com/sgl-project/sglang):

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### Recomendaciones de Uso

**Recomendamos seguir las siguientes configuraciones al utilizar los modelos de la serie DeepSeek-R1, incluyendo la evaluación de benchmarks, para lograr el rendimiento esperado:**

1. Establezca la temperatura dentro del rango de 0.5-0.7 (0.6 recomendado) para evitar repeticiones infinitas o salidas incoherentes.
2. **Evite agregar un prompt de sistema; todas las instrucciones deben estar contenidas en el prompt del usuario.**
3. Para problemas matemáticos, es recomendable incluir una directiva en su prompt tal como: "Por favor razona paso a paso, y pon tu respuesta final dentro de \boxed{}."
4. Al evaluar el rendimiento del modelo, se recomienda realizar múltiples pruebas y promediar los resultados.

Adicionalmente, hemos observado que los modelos de la serie DeepSeek-R1 tienden a omitir el patrón de pensamiento (es decir, a emitir "\<think\>\n\n\</think\>") al responder ciertas consultas, lo que puede afectar negativamente el desempeño del modelo.  
**Para asegurar que el modelo realice un razonamiento exhaustivo, recomendamos forzar que el modelo inicie su respuesta con "\<think\>\n" al principio de cada salida.**

### Prompts Oficiales
En la web/app oficial de DeepSeek, no usamos prompts de sistema, pero diseñamos dos prompts específicos para la carga de archivos y la búsqueda web para una mejor experiencia de usuario. Además, la temperatura en la web/app es 0.6.

Para la carga de archivos, siga la plantilla para crear prompts, donde {file_name}, {file_content} y {question} son argumentos.
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

Para la búsqueda web, {search_results}, {cur_date}, y {question} son argumentos.

Para la consulta en chino, usamos el prompt:
```
search_answer_zh_template = \
'''# 以下内容是基于用户发送的消息的搜索结果:
{search_results}
在我给你的搜索结果中，每个结果都是[webpage X begin]...[webpage X end]格式的，X代表每篇文章的数字索引。请在适当的情况下在句子末尾引用上下文。请按照引用编号[citation:X]的格式在答案中对应部分引用上下文。如果一句话源自多个上下文，请列出所有相关的引用编号，例如[citation:3][citation:5]，切记不要将引用集中在最后返回引用编号，而是在答案对应部分列出。
在回答时，请注意以下几点：
- 今天是{cur_date}。
- 并非搜索结果的所有内容都与用户的问题密切相关，你需要结合问题，对搜索结果进行甄别、筛选。
- 对于列举类的问题（如列举所有航班信息），尽量将答案控制在10个要点以内，并告诉用户可以查看搜索来源、获得完整信息。优先提供信息完整、最相关的列举项；如非必要，不要主动告诉用户搜索结果未提供的内容。
- 对于创作类的问题（如写论文），请务必在正文的段落中引用对应的参考编号，例如[citation:3][citation:5]，不能只在文章末尾引用。你需要解读并概括用户的题目要求，选择合适的格式，充分利用搜索结果并抽取重要信息，生成符合用户要求、极具思想深度、富有创造力与专业性的答案。你的创作篇幅需要尽可能延长，对于每一个要点的论述要推测用户的意图，给出尽可能多角度的回答要点，且务必信息量大、论述详尽。
- 如果回答很长，请尽量结构化、分段落总结。如果需要分点作答，尽量控制在5个点以内，并合并相关的内容。
- 对于客观类的问答，如果问题的答案非常简短，可以适当补充一到两句相关信息，以丰富内容。
- 你需要根据用户要求和回答内容选择合适、美观的回答格式，确保可读性强。
- 你的回答应该综合多个相关网页来回答，不能重复引用一个网页。
- 除非用户要求，否则你回答的语言需要和用户提问的语言保持一致。

# 用户消息为：
{question}'''
```

Para consultas en inglés, usamos el prompt:
```
search_answer_en_template = \
'''# The following contents are the search results related to the user's message:
{search_results}
In the search results I provide to you, each result is formatted as [webpage X begin]...[webpage X end], where X represents the numerical index of each article. Please cite the context at the end of the relevant sentence when appropriate. Use the citation format [citation:X] in the corresponding part of your answer. If a sentence is derived from multiple contexts, list all relevant citation numbers, such as [citation:3][citation:5]. Be sure not to cluster all citations at the end; instead, include them in the corresponding parts of the answer.
When responding, please keep the following points in mind:
- Today is {cur_date}.
- Not all content in the search results is closely related to the user's question. You need to evaluate and filter the search results based on the question.
- For listing-type questions (e.g., listing all flight information), try to limit the answer to 10 key points and inform the user that they can refer to the search sources for complete information. Prioritize providing the most complete and relevant items in the list. Avoid mentioning content not provided in the search results unless necessary.
- For creative tasks (e.g., writing an essay), ensure that references are cited within the body of the text, such as [citation:3][citation:5], rather than only at the end of the text. You need to interpret and summarize the user's requirements, choose an appropriate format, fully utilize the search results, extract key information, and generate an answer that is insightful, creative, and professional. Extend the length of your response as much as possible, addressing each point in detail and from multiple perspectives, ensuring the content is rich and thorough.
- If the response is lengthy, structure it well and summarize it in paragraphs. If a point-by-point format is needed, try to limit it to 5 points and merge related content.
- For objective Q&A, if the answer is very brief, you may add one or two related sentences to enrich the content.
- Choose an appropriate and visually appealing format for your response based on the user's requirements and the content of the answer, ensuring strong readability.
- Your answer should synthesize information from multiple relevant webpages and avoid repeatedly citing the same webpage.
- Unless the user requests otherwise, your response should be in the same language as the user's question.

# The user's message is:
{question}'''
```

## 7. Licencia
Este repositorio de código y los pesos del modelo están licenciados bajo la [Licencia MIT](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE).
La serie DeepSeek-R1 soporta uso comercial, permite cualquier modificación y trabajos derivados, incluyendo, pero no limitado a, destilación para entrenar otros LLMs. Tenga en cuenta que:
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B y DeepSeek-R1-Distill-Qwen-32B derivan de la [serie Qwen-2.5](https://github.com/QwenLM/Qwen2.5), que está originalmente licenciada bajo la [Licencia Apache 2.0](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE), y ahora han sido afinados con 800k muestras curadas con DeepSeek-R1.
- DeepSeek-R1-Distill-Llama-8B deriva de Llama3.1-8B-Base y está originalmente licenciada bajo la [licencia Llama3.1](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE).
- DeepSeek-R1-Distill-Llama-70B deriva de Llama3.3-70B-Instruct y está originalmente licenciada bajo la [licencia Llama3.3](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE).

## 8. Citación
```bibtex
@misc{deepseekai2025deepseekr1incentivizingreasoningcapability,
      title={DeepSeek-R1: Incentivizing Reasoning Capability in LLMs via Reinforcement Learning}, 
      author={DeepSeek-AI},
      year={2025},
      eprint={2501.12948},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2501.12948}, 
}
```

## 9. Contacto
Si tiene alguna pregunta, por favor abra un issue o contáctenos en [service@deepseek.com](mailto:service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---