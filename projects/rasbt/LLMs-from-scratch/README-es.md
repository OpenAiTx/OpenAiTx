# Construir un Modelo de Lenguaje Grande (Desde Cero)

Este repositorio contiene el código para desarrollar, preentrenar y ajustar un LLM tipo GPT y es el repositorio oficial de código para el libro [Construir un Modelo de Lenguaje Grande (Desde Cero)](https://amzn.to/4fqvn0D).

<br>
<br>

<a href="https://amzn.to/4fqvn0D"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/cover.jpg?123" width="250px"></a>

<br>

En [*Construir un Modelo de Lenguaje Grande (Desde Cero)*](http://mng.bz/orYv), aprenderás y comprenderás cómo funcionan los modelos de lenguaje grandes (LLMs) desde adentro hacia afuera codificándolos desde cero, paso a paso. En este libro, te guiaré a través de la creación de tu propio LLM, explicando cada etapa con texto claro, diagramas y ejemplos.

El método descrito en este libro para entrenar y desarrollar tu propio modelo pequeño pero funcional con fines educativos refleja el enfoque utilizado en la creación de modelos fundamentales a gran escala como los que están detrás de ChatGPT. Además, este libro incluye código para cargar los pesos de modelos preentrenados más grandes para ajustar finamente.

- Enlace al [repositorio oficial de código fuente](https://github.com/rasbt/LLMs-from-scratch)
- [Enlace al libro en Manning (sitio web del editor)](http://mng.bz/orYv)
- [Enlace a la página del libro en Amazon.com](https://www.amazon.com/gp/product/1633437167)
- ISBN 9781633437166

<a href="http://mng.bz/orYv#reviews"><img src="https://sebastianraschka.com//images/LLMs-from-scratch-images/other/reviews.png" width="220px"></a>


<br>
<br>

Para descargar una copia de este repositorio, haz clic en el botón [Download ZIP](https://github.com/rasbt/LLMs-from-scratch/archive/refs/heads/main.zip) o ejecuta el siguiente comando en tu terminal:

```bash
git clone --depth 1 https://github.com/rasbt/LLMs-from-scratch.git
```

<br>

(If you downloaded the code bundle from the Manning website, please consider visiting the official code repository on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) for the latest updates.)

<br>
<br>


# Table of Contents

Please note that this `README.md` file is a Markdown (`.md`) file. If you have downloaded this code bundle from the Manning website and are viewing it on your local computer, I recommend using a Markdown editor or previewer for proper viewing. If you haven't installed a Markdown editor yet, [Ghostwriter](https://ghostwriter.kde.org) is a good free option.

You can alternatively view this and other files on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) in your browser, which renders Markdown automatically.

<br>
<br>


> **Tip:**
> If you're seeking guidance on installing Python and Python packages and setting up your code environment, I suggest reading the [README.md](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/setup/README.md) file located in the [setup](setup) directory.

<br>
<br>

[![Code tests Linux](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml)
[![Code tests Windows](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml)
[![Code tests macOS](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml)




<br>

| Chapter Title                                              | Main Code (for Quick Access)                                                                                                    | All Code + Supplementary      |
|------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------|-------------------------------|
| [Setup recommendations](setup)                             | -                                                                                                                               | -                             |
| Ch 1: Understanding Large Language Models                  | No code                                                                                                                         | -                             |
| Ch 2: Working with Text Data                               | - [ch02.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/ch02.ipynb)<br/>- [dataloader.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/dataloader.ipynb) (summary)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/exercise-solutions.ipynb)               | [./ch02](./ch02)            |
| Ch 3: Coding Attention Mechanisms                          | - [ch03.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/ch03.ipynb)<br/>- [multihead-attention.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/multihead-attention.ipynb) (summary) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/exercise-solutions.ipynb)| [./ch03](./ch03)             |
| Cap 4: Implementando un Modelo GPT desde Cero               | - [ch04.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/ch04.ipynb)<br/>- [gpt.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/gpt.py) (resumen)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/exercise-solutions.ipynb) | [./ch04](./ch04)           |
| Cap 5: Preentrenamiento con Datos Sin Etiquetas            | - [ch05.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/ch05.ipynb)<br/>- [gpt_train.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_train.py) (resumen) <br/>- [gpt_generate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_generate.py) (resumen) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/exercise-solutions.ipynb) | [./ch05](./ch05)              |
| Cap 6: Ajuste fino para Clasificación de Texto             | - [ch06.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/ch06.ipynb)  <br/>- [gpt_class_finetune.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/gpt_class_finetune.py)  <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/exercise-solutions.ipynb) | [./ch06](./ch06)              |
| Cap 7: Ajuste fino para Seguir Instrucciones                | - [ch07.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ch07.ipynb)<br/>- [gpt_instruction_finetuning.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/gpt_instruction_finetuning.py) (resumen)<br/>- [ollama_evaluate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ollama_evaluate.py) (resumen)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/exercise-solutions.ipynb) | [./ch07](./ch07)  |
| Apéndice A: Introducción a PyTorch                          | - [code-part1.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part1.ipynb)<br/>- [code-part2.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part2.ipynb)<br/>- [DDP-script.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/DDP-script.py)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/exercise-solutions.ipynb) | [./appendix-A](./appendix-A) |
| Apéndice B: Referencias y Lecturas Adicionales              | Sin código                                                                                                                      | -                             |
| Apéndice C: Soluciones a los Ejercicios                      | Sin código                                                                                                                      | -                             |
| Apéndice D: Añadiendo Extras al Bucle de Entrenamiento      | - [appendix-D.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-D/01_main-chapter-code/appendix-D.ipynb)                                                          | [./appendix-D](./appendix-D)  |
| Apéndice E: Ajuste fino eficiente en parámetros con LoRA    | - [appendix-E.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-E/01_main-chapter-code/appendix-E.ipynb)                                                          | [./appendix-E](./appendix-E) |

<br>
&nbsp;

El modelo mental a continuación resume los contenidos tratados en este libro.

<img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/mental-model.jpg" width="650px">


<br>
&nbsp;

## Prerrequisitos

El prerrequisito más importante es una sólida base en programación en Python.
Con este conocimiento, estarás bien preparado para explorar el fascinante mundo de los LLMs
y entender los conceptos y ejemplos de código presentados en este libro.

Si tienes algo de experiencia con redes neuronales profundas, puede que algunos conceptos te resulten más familiares, ya que los LLMs están basados en estas arquitecturas.

Este libro usa PyTorch para implementar el código desde cero sin usar librerías externas de LLMs. Aunque no es necesario ser experto en PyTorch, sí es útil estar familiarizado con sus conceptos básicos. Si eres nuevo en PyTorch, el Apéndice A ofrece una introducción concisa a PyTorch. Alternativamente, puede que mi libro, [PyTorch en Una Hora: De Tensores a Entrenar Redes Neuronales en Múltiples GPUs](https://sebastianraschka.com/teaching/pytorch-1h/), te sea útil para aprender lo esencial.



<br>
&nbsp;

## Requisitos de Hardware

El código en los capítulos principales de este libro está diseñado para ejecutarse en laptops convencionales en un tiempo razonable y no requiere hardware especializado. Este enfoque asegura que una amplia audiencia pueda interactuar con el material. Además, el código utiliza automáticamente GPUs si están disponibles. (Por favor, consulta la documentación de [configuración](https://github.com/rasbt/LLMs-from-scratch/blob/main/setup/README.md) para recomendaciones adicionales.)


&nbsp;
## Curso en Video

[Un curso en video de 17 horas y 15 minutos](https://www.manning.com/livevideo/master-and-build-large-language-models) donde programo junto a cada capítulo del libro. El curso está organizado en capítulos y secciones que reflejan la estructura del libro para que pueda usarse como una alternativa independiente al libro o como un recurso complementario para seguir el código.

<a href="https://www.manning.com/livevideo/master-and-build-large-language-models"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/video-screenshot.webp?123" width="350px"></a>


&nbsp;


## Libro Complementario / Secuela

[*Construye un Modelo de Razonamiento (Desde Cero)*](https://mng.bz/lZ5B), aunque es un libro independiente, puede considerarse como una secuela de *Construye un Gran Modelo de Lenguaje (Desde Cero)*.

Comienza con un modelo preentrenado e implementa diferentes enfoques de razonamiento, incluyendo escalado en tiempo de inferencia, aprendizaje por refuerzo y destilación, para mejorar las capacidades de razonamiento del modelo.

Similar a *Construye un Gran Modelo de Lenguaje (Desde Cero)*, [*Construye un Modelo de Razonamiento (Desde Cero)*](https://mng.bz/lZ5B) adopta un enfoque práctico implementando estos métodos desde cero.

<a href="https://mng.bz/lZ5B"><img src="https://sebastianraschka.com/images/reasoning-from-scratch-images/cover.webp?123" width="120px"></a>

- Enlace de Amazon (por confirmar)
- [Enlace de Manning](https://mng.bz/lZ5B)
- [Repositorio de GitHub](https://github.com/rasbt/reasoning-from-scratch)

<br>

&nbsp;
## Ejercicios

Cada capítulo del libro incluye varios ejercicios. Las soluciones se resumen en el Apéndice C, y los cuadernos de código correspondientes están disponibles en las carpetas principales de cada capítulo de este repositorio (por ejemplo, [./ch02/01_main-chapter-code/exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/./ch02/01_main-chapter-code/exercise-solutions.ipynb)).

Además de los ejercicios de código, puedes descargar un PDF gratuito de 170 páginas titulado [Ponte a Prueba con Construye un Gran Modelo de Lenguaje (Desde Cero)](https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch) desde el sitio web de Manning. Contiene aproximadamente 30 preguntas tipo cuestionario y soluciones por capítulo para ayudarte a evaluar tu comprensión.

<a href="https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/test-yourself-cover.jpg?123" width="150px"></a>



&nbsp;
## Material adicional

Varias carpetas contienen materiales opcionales como bono para los lectores interesados:

- **Configuración**
  - [Consejos para configurar Python](setup/01_optional-python-setup-preferences)
  - [Instalación de paquetes y bibliotecas de Python usados en este libro](setup/02_installing-python-libraries)
  - [Guía para configurar el entorno Docker](setup/03_optional-docker-environment)
- **Capítulo 2: Trabajando con datos de texto**
  - [Tokenizador Byte Pair Encoding (BPE) desde cero](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/05_bpe-from-scratch/bpe-from-scratch.ipynb)
  - [Comparación de varias implementaciones de Byte Pair Encoding (BPE)](ch02/02_bonus_bytepair-encoder)
  - [Entendiendo la diferencia entre capas de embedding y capas lineales](ch02/03_bonus_embedding-vs-matmul)
  - [Intuición sobre Dataloader con números simples](ch02/04_bonus_dataloader-intuition)
- **Capítulo 3: Codificando mecanismos de atención**
  - [Comparación de implementaciones eficientes de atención multi-cabeza](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/02_bonus_efficient-multihead-attention/mha-implementations.ipynb)
  - [Entendiendo los buffers de PyTorch](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/03_understanding-buffers/understanding-buffers.ipynb)
- **Capítulo 4: Implementando un modelo GPT desde cero**
  - [Análisis de FLOPS](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/02_performance-analysis/flops-analysis.ipynb)
  - [Cache KV](ch04/03_kv-cache)
- **Capítulo 5: Preentrenamiento con datos no etiquetados:**
  - [Métodos alternativos para cargar pesos](ch05/02_alternative_weight_loading/)
  - [Preentrenando GPT con el conjunto de datos Project Gutenberg](ch05/03_bonus_pretraining_on_gutenberg)
  - [Añadiendo mejoras al ciclo de entrenamiento](ch05/04_learning_rate_schedulers)
  - [Optimizando hiperparámetros para el preentrenamiento](ch05/05_bonus_hparam_tuning)
  - [Construyendo una interfaz de usuario para interactuar con el LLM preentrenado](ch05/06_user_interface)
  - [Convirtiendo GPT a Llama](ch05/07_gpt_to_llama)
  - [Llama 3.2 desde cero](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/07_gpt_to_llama/standalone-llama32.ipynb)
  - [Qwen3 Dense y Mixture-of-Experts (MoE) desde cero](ch05/11_qwen3/)
  - [Gemma 3 desde cero](ch05/12_gemma3/)
  - [Carga eficiente en memoria de pesos de modelos](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/08_memory_efficient_weight_loading/memory-efficient-state-dict.ipynb)
  - [Extendiendo el tokenizador BPE Tiktoken con nuevos tokens](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/09_extending-tokenizers/extend-tiktoken.ipynb)
  - [Consejos de rendimiento en PyTorch para entrenar LLMs más rápido](ch05/10_llm-training-speed)
- **Capítulo 6: Ajuste fino para clasificación**
  - [Experimentos adicionales ajustando diferentes capas y usando modelos más grandes](ch06/02_bonus_additional-experiments)
  - [Ajuste fino de diferentes modelos con el conjunto de datos de 50k reseñas de películas IMDb](ch06/03_bonus_imdb-classification)
  - [Construyendo una interfaz de usuario para interactuar con el clasificador de spam basado en GPT](ch06/04_user_interface)
- **Capítulo 7: Ajuste fino para seguir instrucciones**
  - [Utilidades de conjuntos de datos para encontrar duplicados cercanos y crear entradas en voz pasiva](ch07/02_dataset-utilities)
  - [Evaluando respuestas a instrucciones usando la API de OpenAI y Ollama](ch07/03_model-evaluation)
  - [Generando un conjunto de datos para ajuste fino de instrucciones](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/llama3-ollama.ipynb)
  - [Mejorando un Conjunto de Datos para Ajuste Fino por Instrucción](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/reflection-gpt4.ipynb)
  - [Generación de un Conjunto de Datos de Preferencias con Llama 3.1 70B y Ollama](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/create-preference-data-ollama.ipynb)
  - [Optimización Directa de Preferencias (DPO) para Alineación de LLM](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/dpo-from-scratch.ipynb)
  - [Construyendo una Interfaz de Usuario para Interactuar con el Modelo GPT Ajustado por Instrucción](ch07/06_user_interface)

<br>
&nbsp;

## Preguntas, Comentarios y Contribuciones a Este Repositorio


Agradezco todo tipo de comentarios, que es mejor compartir a través del [Foro de Manning](https://livebook.manning.com/forum?product=raschka&page=1) o [GitHub Discussions](https://github.com/rasbt/LLMs-from-scratch/discussions). Asimismo, si tienes alguna pregunta o simplemente quieres intercambiar ideas con otros, no dudes en publicarlas también en el foro.

Ten en cuenta que, dado que este repositorio contiene el código correspondiente a un libro impreso, actualmente no puedo aceptar contribuciones que extiendan el contenido del código principal de los capítulos, ya que introducirían desviaciones respecto al libro físico. Mantener la consistencia ayuda a garantizar una experiencia fluida para todos.


&nbsp;
## Citación

Si encuentras este libro o código útil para tu investigación, por favor considera citarlo.

Citación estilo Chicago:

> Raschka, Sebastian. *Build A Large Language Model (From Scratch)*. Manning, 2024. ISBN: 978-1633437166.

Entrada BibTeX:

```
@book{build-llms-from-scratch-book,
  author       = {Sebastian Raschka},
  title        = {Build A Large Language Model (From Scratch)},
  publisher    = {Manning},
  year         = {2024},
  isbn         = {978-1633437166},
  url          = {https://www.manning.com/books/build-a-large-language-model-from-scratch},
  github       = {https://github.com/rasbt/LLMs-from-scratch}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---