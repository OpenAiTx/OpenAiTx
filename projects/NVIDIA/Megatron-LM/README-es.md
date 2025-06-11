<div align="center">

Megatron-LM & Megatron-Core
===========================
<h4>Técnicas optimizadas para GPU para entrenar modelos transformadores a gran escala</h4>

[![Documentación](https://img.shields.io/badge/docs-latest-brightgreen.svg?style=flat)](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html)
[![versión](https://img.shields.io/badge/release-0.5.0-green)](./setup.py)
[![licencia](https://img.shields.io/badge/license-OpenBSD-blue)](./LICENSE)

<div align="left">

# Últimas Noticias

- **[2024/7]** Megatron-Core v0.7 mejora la escalabilidad y la resiliencia del entrenamiento y añade soporte para entrenamiento multimodal ([blog](https://developer.nvidia.com/blog/train-generative-ai-models-more-efficiently-with-new-nvidia-megatron-core-functionalities/)). 
- **[2024/6]** Megatron-Core añadió soporte para modelos basados en Mamba. Consulta nuestro artículo [An Empirical Study of Mamba-based Language Models](https://arxiv.org/pdf/2406.07887) y [ejemplo de código](https://github.com/NVIDIA/Megatron-LM/tree/ssm/examples/mamba).
- **[2024/1 Anuncio]** NVIDIA ha liberado las capacidades principales de **Megatron-LM** en [**Megatron-Core**](https://github.com/NVIDIA/Megatron-LM/tree/main/megatron/core) en este repositorio. Megatron-Core amplía las técnicas optimizadas para GPU de Megatron-LM con más innovaciones de vanguardia a nivel de sistema, presentando APIs modulares y componibles. Explora la [introducción a Megatron-Core](#megatron-core) para más detalles.

# Tabla de Contenidos

- [Megatron-LM \& Megatron-Core](#megatron-lm--megatron-core)
- [Últimas Noticias](#últimas-noticias)
- [Tabla de Contenidos](#tabla-de-contenidos)
- [Descripción General de Megatron](#descripción-general-de-megatron)
  - [Megatron-LM](#megatron-lm)
  - [Megatron-Core](#megatron-core)
- [Velocidad de Entrenamiento y Escalabilidad](#velocidad-de-entrenamiento-y-escalabilidad)
- [Configuración](#configuración)
  - [Docker (Recomendado)](#docker-recomendado)
  - [Opciones de Instalación](#opciones-de-instalación)
    - [Instalar desde PyPI](#instalar-desde-pypi)
    - [Instalar desde Fuente](#instalar-desde-fuente)
  - [Requisitos Previos](#requisitos-previos)
  - [Descarga de Puntos de Control](#descarga-de-puntos-de-control)
- [Uso](#uso)
- [Entrenamiento](#entrenamiento)
  - [Preprocesamiento de Datos](#preprocesamiento-de-datos)
  - [Preentrenamiento de BERT](#preentrenamiento-de-bert)
  - [Preentrenamiento de GPT](#preentrenamiento-de-gpt)
  - [Preentrenamiento de T5](#preentrenamiento-de-t5)
  - [Preentrenamiento Distribuido](#preentrenamiento-distribuido)
  - [Checkpointing de Activaciones y Recomputation](#checkpointing-de-activaciones-y-recomputation)
  - [Optimizador Distribuido](#optimizador-distribuido)
  - [FlashAttention](#flashattention)
  - [Ejemplo GPT-3](#ejemplo-gpt-3)
  - [Retro e InstructRetro](#retro-e-instructretro)
  - [Modelos de Lenguaje basados en Mamba](#modelos-de-lenguaje-basados-en-mamba)
  - [Mixture of Experts](#mixture-of-experts)
- [Evaluación y Tareas](#evaluación-y-tareas)
  - [Generación de Texto con GPT](#generación-de-texto-con-gpt)
    - [Desintoxicar GPT vía Auto-generación](#desintoxicar-gpt-vía-auto-generación)
  - [Evaluación de GPT](#evaluación-de-gpt)
    - [Evaluación de Perplejidad en WikiText](#evaluación-de-perplejidad-en-wikitext)
    - [Precisión Cloze LAMBADA](#precisión-cloze-lambada)
  - [Evaluación de Tareas BERT](#evaluación-de-tareas-bert)
    - [Evaluación RACE](#evaluación-race)
    - [Evaluación MNLI](#evaluación-mnli)
  - [Inferencia y Ajuste Fino de Llama-2](#inferencia-y-ajuste-fino-de-llama-2)
- [Optimización y Despliegue de Modelos](#optimización-y-despliegue-de-modelos)
  - [Cuantización y Despliegue TensorRT-LLM](#cuantización-y-despliegue-tensorrt-llm)
- [Conjuntos de Datos](#conjuntos-de-datos)
  - [Recolección de Datos de Entrenamiento de Wikipedia](#recolección-de-datos-de-entrenamiento-de-wikipedia)
  - [Recolección de Datos Webtext GPT](#recolección-de-datos-webtext-gpt)
- [Reproducibilidad](#reproducibilidad)
- [Conversión de Puntos de Control](#conversión-de-puntos-de-control)
  - [Conversión de Clase de Modelo](#conversión-de-clase-de-modelo)
  - [Conversión de Formato de Checkpoint](#conversión-de-formato-de-checkpoint)
- [Proyectos que Usan Megatron](#proyectos-que-usan-megatron)

# Descripción General de Megatron
Este repositorio comprende dos componentes esenciales: **Megatron-LM** y **Megatron-Core**. Megatron-LM sirve como un marco orientado a la investigación que aprovecha Megatron-Core para el entrenamiento de grandes modelos de lenguaje (LLM). Por otro lado, Megatron-Core es una biblioteca de técnicas de entrenamiento optimizadas para GPU que cuenta con soporte formal de producto, incluyendo APIs versionadas y lanzamientos regulares. Puedes usar Megatron-Core junto con Megatron-LM o el [Marco Nvidia NeMo](https://docs.nvidia.com/deeplearning/nemo/user-guide/docs/en/main/nlp/nemo_megatron/mcore_customization.html) para una solución de extremo a extremo nativa en la nube. Alternativamente, puedes integrar los bloques de construcción de Megatron-Core en tu marco de entrenamiento preferido.

## Megatron-LM
Presentado por primera vez en 2019, Megatron ([1](https://arxiv.org/pdf/1909.08053.pdf), [2](https://arxiv.org/pdf/2104.04473.pdf), y [3](https://arxiv.org/pdf/2205.05198)) impulsó una ola de innovación en la comunidad de IA, permitiendo a investigadores y desarrolladores utilizar los cimientos de esta biblioteca para avanzar en los LLM. Hoy en día, muchos de los frameworks de desarrollo de LLM más populares se han inspirado y construido directamente aprovechando la biblioteca de código abierto Megatron-LM, impulsando una ola de modelos fundacionales y startups de IA. Algunos de los frameworks LLM más populares construidos sobre Megatron-LM incluyen [Colossal-AI](https://github.com/hpcaitech/ColossalAI), [HuggingFace Accelerate](https://github.com/huggingface/accelerate) y [NVIDIA NeMo Framework](https://www.nvidia.com/en-us/ai-data-science/generative-ai/nemo-framework/). Una lista de proyectos que han usado directamente Megatron se puede encontrar [aquí](#proyectos-que-usan-megatron).

## Megatron-Core
Megatron-Core es una biblioteca de código abierto basada en PyTorch que contiene técnicas optimizadas para GPU y optimizaciones de sistema de vanguardia. Estas se abstraen en APIs modulares y componibles, permitiendo total flexibilidad a desarrolladores e investigadores de modelos para entrenar transformadores personalizados a gran escala sobre la infraestructura de computación acelerada de NVIDIA. Esta biblioteca es compatible con todas las GPUs NVIDIA Tensor Core, incluyendo soporte de aceleración FP8 para [arquitecturas NVIDIA Hopper](https://www.nvidia.com/en-us/data-center/technologies/hopper-architecture/).

Megatron-Core ofrece bloques fundamentales como mecanismos de atención, bloques y capas de transformador, capas de normalización y técnicas de embedding. Funcionalidades adicionales como recomputación de activaciones y checkpointing distribuido también están integradas nativamente en la biblioteca. Todos los bloques y funcionalidades están optimizados para GPU y pueden construirse con estrategias avanzadas de paralelización para una velocidad de entrenamiento y estabilidad óptimas en la infraestructura de computación acelerada de NVIDIA. Otro componente clave de la biblioteca Megatron-Core incluye técnicas avanzadas de paralelismo de modelo (tensor, secuencia, pipeline, contexto y paralelismo experto MoE).

Megatron-Core se puede usar con [NVIDIA NeMo](https://www.nvidia.com/en-us/ai-data-science/products/nemo/), una plataforma de IA de nivel empresarial. Alternativamente, puedes explorar Megatron-Core con el bucle de entrenamiento nativo de PyTorch [aquí](https://github.com/NVIDIA/Megatron-LM/tree/main/examples). Visita la [documentación de Megatron-Core](https://docs.nvidia.com/megatron-core/developer-guide/latest/index.html) para más información.

# Velocidad de Entrenamiento y Escalabilidad
Nuestra base de código es capaz de entrenar eficientemente grandes modelos de lenguaje (es decir, modelos con cientos de miles de millones de parámetros) tanto con paralelismo de modelo como de datos. Para demostrar cómo nuestro software escala con múltiples GPUs y tamaños de modelo, consideramos modelos GPT que van desde 2 mil millones de parámetros hasta 462 mil millones de parámetros. Todos los modelos usan un tamaño de vocabulario de 131,072 y una longitud de secuencia de 4096. Variamos el tamaño oculto, el número de cabezas de atención y el número de capas para llegar a un tamaño de modelo específico. A medida que aumenta el tamaño del modelo, también incrementamos modestamente el tamaño del batch. Nuestros experimentos utilizan hasta 6144 [H100](https://www.nvidia.com/en-us/data-center/h100/) GPUs. Realizamos solapamiento de grano fino de la comunicación data-parallel (`--overlap-grad-reduce --overlap-param-gather`), tensor-parallel (`--tp-comm-overlap`) y pipeline-parallel (habilitado por defecto) con el cómputo para mejorar la escalabilidad. Los rendimientos reportados se miden para el entrenamiento de extremo a extremo e incluyen todas las operaciones, incluyendo carga de datos, pasos del optimizador, comunicación e incluso logging. Ten en cuenta que no entrenamos estos modelos hasta la convergencia.

![Tabla del modelo](images/model_table.png)

Nuestros resultados de escalado débil muestran un escalado superlineal (MFU aumenta del 41% para el modelo más pequeño considerado al 47-48% para los modelos más grandes); esto se debe a que los GEMMs más grandes tienen mayor intensidad aritmética y, en consecuencia, son más eficientes de ejecutar.

![Escalado débil](images/weak_scaling.png)

También escalamos fuertemente el modelo estándar GPT-3 (nuestra versión tiene un poco más de 175 mil millones de parámetros debido al mayor tamaño de vocabulario) de 96 GPUs H100 a 4608 GPUs, usando el mismo batch size de 1152 secuencias en todo momento. La comunicación se vuelve más expuesta a mayor escala, lo que lleva a una reducción del MFU del 47% al 42%.

![Escalado fuerte](images/strong_scaling.png)


# Configuración

## Docker (Recomendado)

Recomendamos encarecidamente usar la versión anterior del [Contenedor PyTorch NGC](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/pytorch) en lugar de la más reciente. Nuestros lanzamientos siempre se basan en el contenedor NGC del mes anterior, por lo que esto garantiza compatibilidad y estabilidad. Este contenedor viene con todas las dependencias preinstaladas con versiones compatibles y configuraciones optimizadas para GPUs NVIDIA.

```bash
# Descarga el contenedor NGC anterior (reemplaza 25.04 por la versión del mes anterior)
docker pull nvcr.io/nvidia/pytorch:25.04-py3
```

```bash
# Ejecuta el contenedor con directorios montados
docker run --gpus all -it --rm \
  -v /path/to/megatron:/workspace/megatron \
  -v /path/to/dataset:/workspace/dataset \
  -v /path/to/checkpoints:/workspace/checkpoints \
  nvcr.io/nvidia/pytorch:25.04-py3
```

## Opciones de Instalación

### Requisitos Previos

- PyTorch (versión estable más reciente)
- CUDA, cuDNN, NCCL (versiones estables más recientes)
- Soporte de FP8 en GPUs NVIDIA Hopper, Ada y Blackwell
- Para mejor rendimiento, usar generaciones de GPU NVIDIA Turing o posteriores

### Instalar desde PyPI

Para instalar la versión estable más reciente con pip:

```bash
# Instala la última versión
pip install megatron-core
```

### Instalar desde Fuente

```bash
# Clona el repositorio
git clone https://github.com/NVIDIA/Megatron-LM.git
cd Megatron-LM

# Opcionalmente, haz checkout de una versión específica
git checkout v0.11.0

# Instala en modo desarrollo
pip install -e .
```

## Descarga de Puntos de Control
Hemos proporcionado puntos de control preentrenados de [BERT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_bert_345m) y [GPT-345M](https://ngc.nvidia.com/catalog/models/nvidia:megatron_lm_345m) para evaluar o ajustar en tareas downstream. Para acceder a estos checkpoints, primero [regístrate](https://ngc.nvidia.com/signup) y [configura](https://ngc.nvidia.com/setup/installers/cli) el CLI del Registro de NVIDIA GPU Cloud (NGC). Más documentación para descargar modelos se encuentra en la [documentación de NGC](https://docs.nvidia.com/dgx/ngc-registry-cli-user-guide/index.html#topic_6_4_1).

Alternativamente, puedes descargar directamente los checkpoints usando:

<pre>
BERT-345M-uncased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_uncased/zip -O megatron_bert_345m_v0.1_uncased.zip
BERT-345M-cased: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_bert_345m/versions/v0.1_cased/zip -O megatron_bert_345m_v0.1_cased.zip
GPT-345M: wget --content-disposition https://api.ngc.nvidia.com/v2/models/nvidia/megatron_lm_345m/versions/v0.0/zip -O megatron_lm_345m_v0.0.zip
</pre>

Los modelos requieren archivos de vocabulario para funcionar. El archivo de vocabulario WordPiece de BERT puede extraerse de los modelos BERT preentrenados de Google: [uncased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-uncased-vocab.txt), [cased](https://s3.amazonaws.com/models.huggingface.co/bert/bert-large-cased-vocab.txt). El archivo de vocabulario de GPT [vocab file](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-vocab.json) y la [tabla de merges](https://s3.amazonaws.com/models.huggingface.co/bert/gpt2-merges.txt) pueden descargarse directamente.

# Uso

Después de la instalación, hay varios flujos de trabajo posibles. El más completo es:
1. Preprocesamiento de datos
2. Preentrenamiento
3. Ajuste fino (opcional para tareas zero-shot)
4. Evaluación de tareas downstream o generación de texto

Sin embargo, los pasos 1 y 2 pueden reemplazarse usando uno de los modelos preentrenados mencionados arriba.

Hemos proporcionado varios scripts para preentrenar tanto BERT como GPT en el directorio [`examples`](./examples), así como scripts para tareas downstream tanto zero-shot como fine-tuned, incluyendo evaluación MNLI, RACE, WikiText103 y LAMBADA. También hay un script para generación interactiva de texto con GPT.

# Entrenamiento
## Preprocesamiento de Datos
Los datos de entrenamiento requieren preprocesamiento. Primero, coloca tus datos en un formato json suelto, con un json por línea, cada uno conteniendo una muestra de texto. Por ejemplo:
<pre>
{"src": "www.nvidia.com", "text": "The quick brown fox", "type": "Eng", "id": "0", "title": "First Part"}
{"src": "The Internet", "text": "jumps over the lazy dog", "type": "Eng", "id": "42", "title": "Second Part"}
</pre>

El nombre del campo `text` del json puede modificarse usando el flag `--json-key` en [`preprocess_data.py`](./tools/preprocess_data.py). Los otros metadatos son opcionales y no se utilizan en el entrenamiento.

El json suelto luego se procesa a un formato binario para entrenamiento. Para convertir el json a formato mmap usa `preprocess_data.py`. Un script de ejemplo para preparar datos para entrenamiento de BERT es:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-bert \
       --vocab-file bert-vocab.txt \
       --tokenizer-type BertWordPieceLowerCase \
       --split-sentences
</pre>

La salida serán dos archivos llamados, en este caso, `my-bert_text_sentence.bin` y `my-bert_text_sentence.idx`. El `--data-path` especificado más adelante para el entrenamiento de BERT es la ruta completa y el nuevo nombre del archivo, pero sin la extensión.

Para T5 usa el mismo preprocesamiento que BERT, quizás renombrando a:
<pre>
       --output-prefix my-t5 \
</pre>
Se requieren algunas modificaciones menores para el preprocesamiento de datos de GPT, a saber, la adición de una tabla de merges, un token de fin de documento, la eliminación de la división por oraciones y un cambio en el tipo de tokenizador:
<pre>
python tools/preprocess_data.py \
       --input my-corpus.json \
       --output-prefix my-gpt2 \
       --vocab-file gpt2-vocab.json \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file gpt2-merges.txt \
       --append-eod
</pre>

Aquí los archivos de salida se llaman `my-gpt2_text_document.bin` y `my-gpt2_text_document.idx`. Como antes, en el entrenamiento de GPT, use el nombre largo sin extensión como `--data-path`.

Se describen más argumentos de línea de comandos en el archivo fuente [`preprocess_data.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/preprocess_data.py).

## Preentrenamiento de BERT

El script [`examples/bert/train_bert_340m_distributed.sh`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/bert/train_bert_340m_distributed.sh) ejecuta el preentrenamiento de BERT con 345M de parámetros en una sola GPU. El principal uso de entrenamiento en una sola GPU es para depuración, ya que la base de código y los argumentos están optimizados para entrenamiento altamente distribuido. La mayoría de los argumentos son bastante autoexplicativos. Por defecto, la tasa de aprendizaje decae linealmente sobre las iteraciones de entrenamiento comenzando en `--lr` hasta un mínimo dado por `--min-lr` a lo largo de `--lr-decay-iters` iteraciones. La fracción de iteraciones de entrenamiento utilizada para "warmup" se define con `--lr-warmup-fraction`. Aunque es entrenamiento de una sola GPU, el tamaño de lote especificado por `--micro-batch-size` es el tamaño de lote de un solo paso adelante-atrás, y el código realizará pasos de acumulación de gradiente hasta alcanzar `global-batch-size`, que es el tamaño de lote por iteración. Los datos se particionan en una proporción 949:50:1 para conjuntos de entrenamiento/validación/prueba (por defecto es 969:30:1). Esta partición ocurre en tiempo real, pero es consistente entre ejecuciones con la misma semilla aleatoria (1234 por defecto, o especificada manualmente con `--seed`). Usamos `train-iters` como el número de iteraciones de entrenamiento solicitadas. Alternativamente, se puede proporcionar `--train-samples` que es el número total de muestras a entrenar. Si esta opción está presente, entonces en lugar de proporcionar `--lr-decay-iters`, se debe proporcionar `--lr-decay-samples`.

Las opciones de logging, guardado de checkpoints y evaluación por intervalo están especificadas. Tenga en cuenta que `--data-path` ahora incluye el sufijo adicional `_text_sentence` agregado en el preprocesamiento, pero no incluye las extensiones de archivo.

Se describen más argumentos de línea de comandos en el archivo fuente [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

Para ejecutar `train_bert_340m_distributed.sh`, realice las modificaciones deseadas incluyendo la configuración de las variables de entorno para `CHECKPOINT_PATH`, `VOCAB_FILE` y `DATA_PATH`. Asegúrese de establecer estas variables a sus rutas dentro del contenedor. Luego, lance el contenedor con Megatron y los paths necesarios montados (como se explica en [Setup](#setup)) y ejecute el script de ejemplo.

## Preentrenamiento de GPT

El script `examples/gpt3/train_gpt3_175b_distributed.sh` ejecuta el preentrenamiento de GPT con 345M de parámetros en una sola GPU. Como se mencionó anteriormente, el entrenamiento en una sola GPU está destinado principalmente a fines de depuración, ya que el código está optimizado para entrenamiento distribuido.

Sigue en gran medida el mismo formato que el script de BERT anterior, con algunas diferencias notables: el esquema de tokenización utilizado es BPE (que requiere una tabla de merges y un vocabulario en formato `json`) en lugar de WordPiece, la arquitectura del modelo permite secuencias más largas (tenga en cuenta que el embedding de posición máxima debe ser mayor o igual a la longitud máxima de secuencia), y el argumento `--lr-decay-style` ha sido configurado a decaimiento coseno. Tenga en cuenta que `--data-path` ahora incluye el sufijo adicional `_text_document` agregado en el preprocesamiento, pero no incluye las extensiones de archivo.

Se describen más argumentos de línea de comandos en el archivo fuente [`arguments.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/training/arguments.py).

`train_gpt3_175b_distributed.sh` puede lanzarse de la misma manera que se describe para BERT. Configure las variables de entorno y realice cualquier otra modificación, lance el contenedor con los montajes apropiados y ejecute el script.
Más detalles en [`examples/gpt3/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/gpt3/README.md)

## Preentrenamiento de T5

Muy similar a BERT y GPT, el script `examples/t5/train_t5_220m_distributed.sh` ejecuta el preentrenamiento de T5 "base" (~220M parámetros) en una sola GPU. La diferencia principal respecto a BERT y GPT es la adición de los siguientes argumentos para acomodar la arquitectura de T5:

* `--kv-channels` establece la dimensión interna de las matrices "key" y "value" de todos los mecanismos de atención en el modelo. Para BERT y GPT esto es por defecto el tamaño oculto dividido por el número de cabezas de atención, pero puede configurarse para T5.

* `--ffn-hidden-size` establece el tamaño oculto en las redes feed-forward dentro de una capa transformer. Para BERT y GPT esto es por defecto 4 veces el tamaño oculto del transformer, pero puede configurarse para T5.

* `--encoder-seq-length` y `--decoder-seq-length` establecen la longitud de secuencia para el encoder y el decoder por separado.

Todos los demás argumentos permanecen como estaban para el preentrenamiento de BERT y GPT. Ejecute este ejemplo con los mismos pasos descritos anteriormente para los otros scripts.

Más detalles en [`examples/t5/README.md`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/t5/README.md)

## Preentrenamiento Distribuido

Los scripts `pretrain_{bert,gpt,t5}_distributed.sh` utilizan el lanzador distribuido de PyTorch para entrenamiento distribuido. De este modo, el entrenamiento multinodo puede lograrse configurando correctamente las variables de entorno. Consulte la documentación oficial de PyTorch [aquí](https://pytorch.org/docs/stable/elastic/run.html#launcher-api) para más detalles sobre estas [variables de entorno](https://pytorch.org/docs/stable/distributed.html#environment-variable-initialization). Por defecto, el entrenamiento multinodo usa el backend distribuido [nccl](https://developer.nvidia.com/nccl). Un conjunto simple de argumentos adicionales y el uso del módulo distribuido de PyTorch con el lanzador elástico `torchrun` (equivalente a `python -m torch.distributed.run`) son los únicos requisitos adicionales para adoptar el entrenamiento distribuido. Consulte cualquiera de los scripts `pretrain_{bert,gpt,t5}_distributed.sh` para más detalles.

Utilizamos dos tipos de paralelismo: paralelismo de datos y de modelo. Nuestra implementación de paralelismo de datos se encuentra en `megatron/core/distributed`, y soporta el solapamiento de la reducción de gradientes con el paso hacia atrás cuando se usa la opción de línea de comandos `--overlap-grad-reduce`.

En segundo lugar, desarrollamos un enfoque simple y eficiente de paralelismo de modelo bidimensional. Para usar la primera dimensión, paralelismo de modelo tensorial (dividir la ejecución de un solo módulo transformer entre varias GPUs, ver Sección 3 de [nuestro artículo](https://arxiv.org/pdf/1909.08053.pdf)), añada el flag `--tensor-model-parallel-size` para especificar el número de GPUs entre las cuales dividir el modelo, junto con los argumentos pasados al lanzador distribuido como se mencionó anteriormente. Para usar la segunda dimensión, paralelismo de secuencia, especifique `--sequence-parallel`, lo que también requiere que el paralelismo de modelo tensorial esté habilitado, ya que se divide entre las mismas GPUs (más detalles en la Sección 4.2.2 de [nuestro artículo](https://arxiv.org/pdf/2205.05198.pdf)).

Para usar el paralelismo de modelo en pipeline (fragmentar los módulos transformer en etapas con un número igual de módulos transformer por etapa, y luego hacer pipeline de la ejecución dividiendo el lote en microlotes más pequeños, ver la Sección 2.2 de [nuestro artículo](https://arxiv.org/pdf/2104.04473.pdf)), use el flag `--pipeline-model-parallel-size` para especificar el número de etapas en que dividir el modelo (por ejemplo, dividir un modelo con 24 capas transformer en 4 etapas significaría que cada etapa recibe 6 capas transformer).

Tenemos ejemplos de cómo usar estas dos formas diferentes de paralelismo de modelo en los scripts de ejemplo que terminan en `distributed_with_mp.sh`.

Aparte de estos pequeños cambios, el entrenamiento distribuido es idéntico al entrenamiento en una sola GPU.

La planificación de pipeline intercalado (más detalles en la Sección 2.2.2 de [nuestro artículo](https://arxiv.org/pdf/2104.04473.pdf)) puede habilitarse usando el argumento `--num-layers-per-virtual-pipeline-stage`, que controla el número de capas transformer en una etapa virtual (por defecto, con la planificación no intercalada, cada GPU ejecutará una sola etapa virtual con `NUM_LAYERS / PIPELINE_MP_SIZE` capas transformer). El número total de capas en el modelo transformer debe ser divisible por el valor de este argumento. Además, el número de microlotes en el pipeline (calculado como `GLOBAL_BATCH_SIZE / (DATA_PARALLEL_SIZE * MICRO_BATCH_SIZE)`) debe ser divisible por el `PIPELINE_MP_SIZE` al usar esta planificación (esta condición se verifica en una aserción en el código). La planificación intercalada no es compatible con pipelines de 2 etapas (`PIPELINE_MP_SIZE=2`).

## Checkpointing de Activaciones y Recomputation

Para reducir el uso de memoria GPU al entrenar un modelo grande, soportamos varias formas de checkpointing de activaciones y recomputation. En lugar de que todas las activaciones se almacenen en memoria para usarse durante la retropropagación, como era tradicional en los modelos de deep learning, solo las activaciones en ciertos "checkpoints" en el modelo se retienen (o almacenan) en memoria, y las otras activaciones se recomputan en tiempo real cuando se necesitan para backprop. Tenga en cuenta que este tipo de checkpointing, *checkpointing de activaciones*, es muy diferente del checkpointing de parámetros del modelo y estado del optimizador, que se menciona en otras partes.

Soportamos dos niveles de granularidad de recomputation: `selective` y `full`. La recomputación selectiva es la predeterminada y se recomienda en casi todos los casos. Este modo retiene en memoria las activaciones que ocupan menos espacio de almacenamiento y son más costosas de recomputar, y recomputa las activaciones que ocupan más espacio de almacenamiento pero son relativamente baratas de recomputar. Véase [nuestro artículo](https://arxiv.org/pdf/2205.05198) para detalles. Debería encontrar que este modo maximiza el rendimiento mientras minimiza la memoria requerida para almacenar activaciones. Para habilitar recomputación selectiva de activaciones simplemente use `--recompute-activations`.

Para casos donde la memoria es muy limitada, la recomputación `full` guarda solo las entradas a una capa transformer, o un grupo, o bloque, de capas transformer, y recomputa todo lo demás. Para habilitar recomputación full de activaciones use `--recompute-granularity full`. Cuando se utiliza recomputación full, hay dos métodos: `uniform` y `block`, elegidos usando el argumento `--recompute-method`.

* El método `uniform` divide uniformemente las capas transformer en grupos de capas (cada grupo de tamaño `--recompute-num-layers`) y almacena las activaciones de entrada de cada grupo en memoria. El tamaño de grupo base es 1, y en este caso, la activación de entrada de cada capa transformer se almacena. Cuando la memoria GPU es insuficiente, aumentar el número de capas por grupo reduce el uso de memoria, permitiendo entrenar un modelo más grande. Por ejemplo, cuando `--recompute-num-layers` se establece en 4, solo se almacena la activación de entrada de cada grupo de 4 capas transformer.

* El método `block` recompone las activaciones de entrada de un número específico (dado por `--recompute-num-layers`) de capas transformer individuales por etapa de pipeline y almacena las activaciones de entrada de las capas restantes en la etapa de pipeline. Reducir `--recompute-num-layers` resulta en almacenar las activaciones de entrada de más capas transformer, lo que reduce la recomputación de activaciones requerida en el backprop, mejorando así el rendimiento del entrenamiento a costa de más uso de memoria. Por ejemplo, cuando especificamos 5 capas para recomputar de 8 capas por etapa de pipeline, las activaciones de entrada solo de las primeras 5 capas transformer se recomputan en el paso de backprop, mientras que las activaciones de entrada de las últimas 3 capas se almacenan. `--recompute-num-layers` puede incrementarse gradualmente hasta que la cantidad de espacio de almacenamiento de memoria requerido sea lo suficientemente pequeña para caber en la memoria disponible, utilizando así al máximo la memoria y maximizando el rendimiento.

## Optimizador Distribuido

Uso: `--use-distributed-optimizer`. Compatible con todos los tipos de modelo y datos.

El optimizador distribuido es una técnica de ahorro de memoria, mediante la cual el estado del optimizador se distribuye uniformemente entre los ranks de paralelismo de datos (en contraste con el método tradicional de replicar el estado del optimizador en todos los ranks). Como se describe en [ZeRO: Memory Optimizations Toward Training Trillion Parameter Models](https://arxiv.org/abs/1910.02054), nuestra implementación distribuye todo el estado del optimizador que no se superpone con el estado del modelo. Por ejemplo, cuando se usan parámetros de modelo fp16, el optimizador distribuido mantiene su propia copia separada de parámetros y gradientes fp32, distribuidos entre los ranks DP. Sin embargo, al usar parámetros de modelo bf16, los gradientes principales fp32 del optimizador distribuido son los mismos que los gradientes fp32 del modelo, por lo que en este caso los gradientes no se distribuyen (aunque los parámetros principales fp32 sí se distribuyen, ya que son independientes de los parámetros bf16 del modelo).

El ahorro de memoria teórico varía dependiendo de la combinación de dtype de parámetros y gradientes del modelo. En nuestra implementación, el número teórico de bytes por parámetro es (donde 'd' es el tamaño de paralelismo de datos):

| | Optimizador no distribuido | Optimizador distribuido |
|-|-|-|
| fp16 param, fp16 grads | 20 | 4 + 16/d |
| bf16 param, fp32 grads | 18 | 6 + 12/d |
| fp32 param, fp32 grads | 16 | 8 + 8/d |

Como con el paralelismo de datos regular, el solapamiento de la reducción de gradientes (en este caso, un reduce-scatter) con el paso hacia atrás puede facilitarse usando el flag `--overlap-grad-reduce`. Además, el solapamiento del all-gather de parámetros puede solaparse con el paso hacia adelante usando `--overlap-param-gather`.

## FlashAttention

Uso: `--use-flash-attn`. Soporta dimensiones de cabeza de atención de hasta 128.

[FlashAttention](https://github.com/HazyResearch/flash-attention) es un algoritmo rápido y eficiente en memoria para calcular la atención exacta. Acelera el entrenamiento del modelo y reduce el requerimiento de memoria.

Para instalar FlashAttention:
```sh
pip install flash-attn
```

## Ejemplo de GPT-3

En `examples/gpt3/train_gpt3_175b_distributed.sh` se ha proporcionado un ejemplo de cómo configurar Megatron para entrenar [GPT-3](https://arxiv.org/abs/2005.14165) con 175 mil millones de parámetros en 1024 GPUs. El script está diseñado para [slurm](https://slurm.schedmd.com/documentation.html) con el plugin [pyxis](https://github.com/NVIDIA/pyxis) pero puede adaptarse fácilmente a cualquier otro scheduler. Usa paralelismo tensorial de 8 vías y paralelismo de pipeline de 16 vías. Con las opciones `global-batch-size 1536` y `rampup-batch-size 16 16 5859375`, el entrenamiento comenzará con un batch size global de 16 e incrementará linealmente el batch size global a 1536 sobre 5,859,375 muestras con pasos incrementales de 16. El dataset de entrenamiento puede ser un solo conjunto o múltiples conjuntos combinados con un conjunto de pesos.

Con un batch size global total de 1536 en 1024 GPUs A100, cada iteración toma alrededor de 32 segundos resultando en 138 teraFLOPs por GPU, lo que equivale al 44% del pico teórico de FLOPs.

## Retro e InstructRetro

Retro [(Borgeaud et al., 2022)](https://arxiv.org/abs/2112.04426) es un modelo de lenguaje autoregresivo solo-decodificador preentrenado con aumento por recuperación. Retro ofrece escalabilidad práctica para soportar preentrenamiento a gran escala desde cero recuperando de trillones de tokens. El preentrenamiento con recuperación proporciona un mecanismo de almacenamiento más eficiente del conocimiento factual, en comparación con almacenar el conocimiento factual implícitamente dentro de los parámetros de la red, reduciendo así en gran medida los parámetros del modelo mientras logra menor perplexity que GPT estándar. Retro también proporciona la flexibilidad de actualizar el conocimiento almacenado en los modelos de lenguaje [(Wang et al., 2023a)](https://arxiv.org/abs/2304.06762) actualizando la base de datos de recuperación sin necesidad de volver a entrenar los modelos.

InstructRetro [(Wang et al., 2023b)](https://arxiv.org/abs/2310.07713) escala aún más el tamaño de Retro a 48B, siendo el LLM preentrenado con recuperación más grande (a diciembre de 2023). El modelo base obtenido, Retro 48B, supera ampliamente a su contraparte GPT en perplexity. Con ajuste por instrucciones sobre Retro, InstructRetro muestra mejoras significativas sobre GPT ajustado por instrucciones en tareas downstream en modo zero-shot. Específicamente, la mejora promedio de InstructRetro es de 7% sobre su contraparte GPT en 8 tareas de QA de formato corto, y de 10% sobre GPT en 4 tareas de QA de formato largo desafiantes. También encontramos que se puede eliminar el encoder de la arquitectura de InstructRetro y usar directamente el decoder backbone de InstructRetro como GPT, obteniendo resultados comparables.

En este repositorio, proporcionamos una guía de reproducción de extremo a extremo para implementar Retro e InstructRetro, cubriendo
- **Construcción de la base de datos de recuperación**, que soporta miles de millones o incluso billones de tokens como base de datos de recuperación a gran escala.
- **Preentrenamiento con recuperación**, que soporta preentrenamiento desde cero y preentrenamiento a partir de un modelo GPT preentrenado (Retro-fitting).
- **Ajuste por instrucciones**, donde proporcionamos un dataset open-source de ajuste por instrucciones y la receta de entrenamiento para ajuste por instrucciones en Retro.
- **Evaluación de tareas downstream**, donde proporcionamos scripts de generación de texto y evaluación para tareas de question answering en modo zero-shot.

Consulte [tools/retro/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tools/retro/README.md) para una visión general detallada.

## Modelos de Lenguaje basados en Mamba

Consulte [examples/mamba](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/mamba) para más detalles.

<!--
## Pipeline REALM
Estamos trabajando en la implementación del sistema [REALM](https://arxiv.org/pdf/2002.08909.pdf). Las siguientes secciones (lo harán) reflejan las tres etapas de su entrenamiento. Por ahora solo está el código de ICT.
En líneas generales, se preentrenan los módulos de recuperación, luego se entrena conjuntamente el modelo de lenguaje y el recuperador, y luego se ajusta una cabeza de question answering en el modelo de lenguaje con el recuperador fijo.

### Preentrenamiento de Inverse Cloze Task (ICT)
1. Tener un corpus en formato JSON suelto con la intención de crear una colección de bloques de texto de tamaño fijo como unidades fundamentales de datos. Para un corpus como Wikipedia, esto significará múltiples oraciones por bloque pero también múltiples bloques por documento.
Ejecute `tools/preprocess_data.py` para construir uno o más datasets indexados con el argumento `--split-sentences` para hacer de las oraciones la unidad básica. Para el sistema REALM original, construimos dos datasets, uno con el título de cada documento y otro con el cuerpo.
Consulte el siguiente script:
<pre>
python preprocess_data.py \
    --input /path/to/corpus.json \
    --json-keys text title \
    --split-sentences \
    --tokenizer-type BertWordPieceLowerCase \
    --vocab-file /path/to/vocab.txt \
    --output-prefix corpus_indexed \
    --workers 5  # funciona bien para 10 núcleos de CPU. Escale según corresponda.
</pre>

2. Use una función personalizada de mapeo de muestras en lugar de `megatron/legacy/data/realm_dataset_utils.get_block_samples_mapping` si es necesario. Para ello, deberá implementar una nueva función en C++ dentro de `megatron/core/datasets/helpers.cpp`. La estructura de datos de mapeo de muestras se usa para seleccionar los datos que constituirán cada muestra de entrenamiento antes del bucle de entrenamiento.
 El mapeo de muestras es responsable de mantener todos los metadatos requeridos necesarios para construir la muestra a partir de uno o más datasets indexados. En REALM, el mapeo de muestras contiene los índices de oración inicial y final, así como el índice de documento (para encontrar el título correcto para un cuerpo) y un ID único para cada bloque.
3. Preentrene un modelo de lenguaje BERT usando `pretrain_bert.py`, con la longitud de secuencia igual al tamaño del bloque en ids de tokens. Este modelo debe entrenarse en el mismo dataset indexado que se usará para suministrar los bloques para la tarea de recuperación de información.
En REALM, este es un modelo bert base uncased entrenado con los hiperparámetros estándar.
4. Use `pretrain_ict.py` para entrenar un `ICTBertModel` que usa dos encoders basados en BERT para codificar consultas y bloques para realizar recuperación.
El siguiente script entrena el modelo ICT de REALM. Hace referencia a un modelo BERT preentrenado (paso 3) en el argumento `--bert-load`. El tamaño de lote usado en el paper es 4096, por lo que esto debería ejecutarse con un tamaño de mundo de paralelismo de datos de 32.
<pre>
python pretrain_ict.py \
    --num-layers 12 \
    --num-attention-heads 12 \
    --hidden-size 768 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-head-size 128 \
    --train-iters 100000 \
    --bert-load /path/to/pretrained_bert \
    --load checkpoints \
    --save checkpoints \
    --data-path /path/to/indexed_dataset \
    --titles-data-path /path/to/titles_indexed_dataset \
    --vocab-file /path/to/vocab.txt \
    --lr 0.0001 \
    --num-workers 2 \
    --lr-decay-style linear \
    --weight-decay 1e-2 \
    --clip-grad 1.0 \
    --lr-warmup-fraction .01 \
    --save-interval 3000 \
    --query-in-block-prob 0.1 \
    --fp16

</pre>

### Construcción de un Índice de Embeddings de Bloques
Después de haber entrenado un modelo ICT, puede ahora embeder un dataset completo de bloques creando una estructura `BlockData`. Una vez que se haya guardado, puede cargarlo y envolverlo con un `FaissMIPSIndex` para realizar búsquedas de similitud rápida, lo cual es clave en la pipeline de recuperación de información aprendida. El índice inicial puede construirse con el siguiente script, pensado para ejecutarse en una sesión interactiva. Puede aprovechar múltiples GPUs en varios nodos para indexar grandes datasets mucho más rápido.

<pre>
python tools/create_doc_index.py \
    --num-layers 12 \
    --hidden-size 768 \
    --ict-head-size 128 \
    --num-attention-heads 12 \
    --batch-size 128 \
    --seq-length 256 \
    --max-position-embeddings 256 \
    --ict-load /ruta/al/ict_preentrenado \
    --data-path /ruta/al/dataset_indexado \
    --titles-data-path /ruta/al/dataset_titulos_indexado \
    --block-data-path embedded_blocks.pkl \
    --indexer-log-interval 1000 \
    --indexer-batch-size 128 \
    --vocab-file /ruta/al/vocab.txt \
    --num-workers 2 \
    --fp16
</pre>

-->

## Mixture of Experts
MoE (Mixture of Experts) es una poderosa arquitectura LLM implementada en el marco Megatron-Core, diseñada para mejorar la eficiencia y escalabilidad de modelos de lenguaje grandes. Aprovecha el **Paralelismo de Expertos**, permitiendo que múltiples expertos se distribuyan entre diferentes trabajadores, donde cada trabajador procesa lotes distintos de muestras de entrenamiento. Este método incrementa significativamente el rendimiento computacional, permitiendo que los modelos logren métricas de alto desempeño, como 47% MFU durante entrenamiento BF16 para 8x7B en H100.

Características clave de MoE:
- **Técnicas de Paralelismo**: MoE combina varias estrategias de paralelismo, incluyendo Paralelismo de Expertos, Paralelismo de Datos, Paralelismo de Tensores, Paralelismo de Secuencias, Paralelismo de Tubería y Paralelismo de Contexto. Esta combinación permite manejar variantes de modelos más grandes de manera efectiva.
- **Enrutador y Balanceo de Carga**: El sistema emplea mecanismos de enrutamiento avanzados como el Top-K router y utiliza algoritmos de balanceo de carga para optimizar la distribución de los tokens entre los expertos.
- **Optimizaciones de Rendimiento**: Técnicas como GroupedGEMM y entrenamiento FP8 mejoran la eficiencia de los modelos MoE, especialmente cuando se emplean múltiples expertos.
- **Mecanismo de Despacho de Tokens**: MoE soporta tanto estrategias sin descarte de tokens como con descarte de tokens para gestionar eficazmente la distribución de tokens entre los expertos.

Para una visión completa de las configuraciones de entrenamiento y optimizaciones de MoE, por favor consulte el README detallado ubicado en [megatron/core/transformer/moe/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/core/transformer/moe/README.md).

# Evaluación y Tareas

Proporcionamos varios argumentos de línea de comandos, detallados en los scripts listados a continuación, para manejar varias tareas downstream de zero-shot y fine-tuning. Sin embargo, también puede ajustar su modelo desde un checkpoint preentrenado en otros corpus según lo desee. Para hacerlo, simplemente agregue la bandera `--finetune` y ajuste los archivos de entrada y parámetros de entrenamiento dentro del script original de entrenamiento. El conteo de iteraciones se reiniciará a cero y el optimizador y el estado interno serán reinicializados. Si el fine-tuning es interrumpido por cualquier motivo, asegúrese de quitar la bandera `--finetune` antes de continuar, de lo contrario el entrenamiento comenzará nuevamente desde el principio.

Dado que la evaluación requiere sustancialmente menos memoria que el entrenamiento, puede ser ventajoso fusionar un modelo entrenado en paralelo para usar en menos GPUs en tareas downstream. El siguiente script realiza esta tarea. Este ejemplo lee un modelo GPT con paralelismo de tensor de 4 vías y paralelismo de tubería de 4 vías y guarda un modelo con paralelismo de tensor de 2 vías y paralelismo de tubería de 2 vías.

<pre>
python tools/checkpoint/convert.py \
        --model-type GPT \
        --load-dir checkpoints/gpt3_tp4_pp4 \
        --save-dir checkpoints/gpt3_tp2_pp2 \
        --target-tensor-parallel-size 2 \
        --target-pipeline-parallel-size 2

</pre>

A continuación se describen varias tareas downstream tanto para modelos GPT como BERT. Se pueden ejecutar en modo distribuido y paralelo de modelos con los mismos cambios utilizados en los scripts de entrenamiento.

## Generación de Texto con GPT

Hemos incluido un servidor REST simple para usar en la generación de texto en `tools/run_text_generation_server.py`. Se ejecuta de manera similar a cómo iniciaría un trabajo de preentrenamiento, especificando un checkpoint preentrenado apropiado. También hay algunos parámetros opcionales: `temperature`, `top-k` y `top-p`. Consulte `--help` o el archivo fuente para más información. Vea [examples/inference/run_text_generation_server_345M.sh](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/inference/run_text_generation_server_345M.sh) para un ejemplo de cómo ejecutar el servidor.

Una vez que el servidor está corriendo, puede utilizar `tools/text_generation_cli.py` para consultarlo; toma como argumento el host en el que está corriendo el servidor.

<pre>
tools/text_generation_cli.py localhost:5000
</pre>

También puede usar CURL u otras herramientas para consultar el servidor directamente:

<pre>
curl 'http://localhost:5000/api' -X 'PUT' -H 'Content-Type: application/json; charset=UTF-8'  -d '{"prompts":["Hello world"], "tokens_to_generate":1}'
</pre>

Consulte [megatron/inference/text_generation_server.py](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/megatron/inference/text_generation_server.py) para más opciones de API.

### Desintoxicación de GPT vía Auto-generación
Incluimos un ejemplo en `examples/academic_paper_scripts/detxoify_lm/` para desintoxicar modelos de lenguaje aprovechando el poder generativo de los modelos de lenguaje.

Consulte [examples/academic_paper_scripts/detxoify_lm/README.md](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/examples/academic_paper_scripts/detxoify_lm/README.md) para tutoriales paso a paso sobre cómo realizar entrenamiento adaptativo al dominio y desintoxicar LM utilizando corpus auto-generados.


## Evaluación de GPT
Incluimos scripts de ejemplo para la evaluación de GPT en la métrica de perplejidad de WikiText y la precisión Cloze de LAMBADA.

### Evaluación de Perplejidad con WikiText
Para una comparación justa con trabajos previos, evaluamos la perplejidad en el [conjunto de datos de prueba WikiText-103 a nivel de palabra](https://s3.amazonaws.com/research.metamind.io/wikitext/wikitext-103-v1.zip), y calculamos apropiadamente la perplejidad dado el cambio en tokens al usar nuestro tokenizador de subpalabras.

Usamos el siguiente comando para ejecutar la evaluación WikiText-103 en un modelo de 345M parámetros.
<pre>
TASK="WIKITEXT103"

VALID_DATA=&#60;ruta wikitext&#62;.txt
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m

COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 1024 \
                  --max-position-embeddings 1024 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>


### Precisión Cloze de LAMBADA
Para calcular la precisión cloze de LAMBADA (la precisión de predecir el último token dado los tokens precedentes) utilizamos una versión des-tokenizada y procesada del [conjunto de datos LAMBADA](https://github.com/cybertronai/bflm/blob/master/lambada_test.jsonl).

Usamos el siguiente comando para ejecutar la evaluación LAMBADA en un modelo de 345M parámetros. Tenga en cuenta que la bandera `--strict-lambada` debe usarse para requerir coincidencia de palabra completa. Asegúrese de que `lambada` sea parte de la ruta del archivo.

<pre>
TASK="LAMBADA"

VALID_DATA=&#60;ruta lambada&#62;.json
VOCAB_FILE=gpt2-vocab.json
MERGE_FILE=gpt2-merges.txt
CHECKPOINT_PATH=checkpoints/gpt2_345m
COMMON_TASK_ARGS=&#60;igual a los de <a href="#wikitext-perplexity-evaluation">Evaluación de Perplejidad con WikiText</a> arriba&#62;

python tasks/main.py \
       --task $TASK \
       $COMMON_TASK_ARGS \
       --valid-data $VALID_DATA \
       --tokenizer-type GPT2BPETokenizer \
       --strict-lambada \
       --merge-file $MERGE_FILE \
       --load $CHECKPOINT_PATH \
       --micro-batch-size 8 \
       --log-interval 10 \
       --no-load-optim \
       --no-load-rng
</pre>

Más argumentos de línea de comandos se describen en el archivo fuente [`main.py`](https://raw.githubusercontent.com/NVIDIA/Megatron-LM/main/tasks/main.py)

## Evaluación de Tareas BERT
### Evaluación RACE
El siguiente script ajusta el modelo BERT para evaluación en el [conjunto de datos RACE](http://www.cs.cmu.edu/~glai1/data/race/). Los directorios `TRAIN_DATA` y `VALID_DATA` contienen el dataset RACE como archivos `.txt` separados. Tenga en cuenta que para RACE, el tamaño de batch es el número de consultas RACE a evaluar. Dado que cada consulta RACE tiene cuatro muestras, el tamaño de batch efectivo pasado al modelo será cuatro veces el tamaño especificado en la línea de comandos.

<pre>
TRAIN_DATA="data/RACE/train/middle"
VALID_DATA="data/RACE/dev/middle \
            data/RACE/dev/high"
VOCAB_FILE=bert-vocab.txt
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
CHECKPOINT_PATH=checkpoints/bert_345m_race
COMMON_TASK_ARGS="--num-layers 24 \
                  --hidden-size 1024 \
                  --num-attention-heads 16 \
                  --seq-length 512 \
                  --max-position-embeddings 512 \
                  --fp16 \
                  --vocab-file $VOCAB_FILE"

COMMON_TASK_ARGS_EXT="--train-data $TRAIN_DATA \
                      --valid-data $VALID_DATA \
                      --pretrained-checkpoint $PRETRAINED_CHECKPOINT \
                      --save-interval 10000 \
                      --save $CHECKPOINT_PATH \
                      --log-interval 100 \
                      --eval-interval 1000 \
                      --eval-iters 10 \
                      --weight-decay 1.0e-1"

python tasks/main.py \
       --task RACE \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
       --tokenizer-type BertWordPieceLowerCase \
       --epochs 3 \
       --micro-batch-size 4 \
       --lr 1.0e-5 \
       --lr-warmup-fraction 0.06
</pre>

### Evaluación MNLI
El siguiente script ajusta el modelo BERT para evaluación con el [corpus de pares de oraciones MultiNLI](https://www.nyu.edu/projects/bowman/multinli/). Debido a que las tareas de emparejamiento son bastante similares, el script puede ajustarse rápidamente para trabajar también con el conjunto de datos [Quora Question Pairs](https://www.kaggle.com/quora/question-pairs-dataset) (QQP).

<pre>

TRAIN_DATA="data/glue_data/MNLI/train.tsv"
VALID_DATA="data/glue_data/MNLI/dev_matched.tsv \
            data/glue_data/MNLI/dev_mismatched.tsv"
PRETRAINED_CHECKPOINT=checkpoints/bert_345m
VOCAB_FILE=bert-vocab.txt
CHECKPOINT_PATH=checkpoints/bert_345m_mnli
COMMON_TASK_ARGS=&#60;igual a los de <a href="#race-evaluation">Evaluación RACE</a> arriba&#62;
COMMON_TASK_ARGS_EXT=&#60;igual a los de <a href="#race-evaluation">Evaluación RACE</a> arriba&#62;

python tasks/main.py \
       --task MNLI \
       $COMMON_TASK_ARGS \
       $COMMON_TASK_ARGS_EXT \
```
   --tokenizer-type BertWordPieceLowerCase \
   --epochs 5 \
   --micro-batch-size 8 \
   --lr 5.0e-5 \
   --lr-warmup-fraction 0.065
</pre>

## Inferencia y Ajuste Fino de Llama-2

La [familia de modelos Llama-2](https://ai.meta.com/llama/) es un conjunto de modelos de código abierto preentrenados y ajustados (para chat) que han alcanzado resultados sólidos en una amplia variedad de benchmarks. Al momento de su lanzamiento, los modelos Llama-2 lograron algunos de los mejores resultados entre los modelos open-source y fueron competitivos con el modelo cerrado GPT-3.5 (ver https://arxiv.org/pdf/2307.09288.pdf).

Los checkpoints de Llama-2 pueden cargarse en Megatron para inferencia y ajuste fino. Consulta la documentación [aquí](docs/llama_mistral.md).

# Optimización y Despliegue de Modelos
La familia `GPTModel` de Megatron-Core (MCore) soporta algoritmos avanzados de cuantización e inferencia de alto rendimiento a través de TensorRT-LLM.

## Cuantización y Despliegue con TensorRT-LLM
Consulta [Optimización y Despliegue de Modelos Megatron](examples/inference/quantization/README.md) para ejemplos de `llama2` y `nemotron3`.

# Datasets
No alojamos ningún dataset para el entrenamiento de GPT o BERT, sin embargo, detallamos su recopilación para que nuestros resultados puedan ser reproducidos.

## Recolección de Datos de Entrenamiento de Wikipedia
Recomendamos seguir el proceso de extracción de datos de Wikipedia especificado por Google research: "el preprocesamiento recomendado es descargar [el último volcado](https://dumps.wikimedia.org/enwiki/latest/enwiki-latest-pages-articles.xml.bz2), extraer el texto con [WikiExtractor.py](https://github.com/attardi/wikiextractor), y luego aplicar cualquier limpieza necesaria para convertirlo en texto plano."

Recomendamos usar el argumento `--json` al utilizar WikiExtractor, que volcará los datos de Wikipedia en formato json suelto (un objeto json por línea), haciéndolo más manejable en el sistema de archivos y también fácilmente consumible por nuestro código. Recomendamos además preprocesar este dataset json con la estandarización de puntuación de nltk. Para el entrenamiento de BERT, usa la bandera `--split-sentences` en `preprocess_data.py` como se describe [arriba](#data-preprocessing) para incluir saltos de oración en el índice producido. Si deseas usar datos de Wikipedia para entrenamiento GPT, aún debes limpiarlos con nltk/spacy/ftfy, pero no utilices la bandera `--split-sentences`.

## Recolección de Datos Webtext para GPT
Utilizamos la biblioteca [OpenWebText](https://github.com/eukaryote31/openwebtext) de acceso público de [jcpeterson](https://github.com/jcpeterson/openwebtext) y el trabajo de [eukaryote31](https://github.com/eukaryote31/openwebtext) para descargar URLs. Posteriormente filtramos, limpiamos y eliminamos duplicados de todo el contenido descargado según el procedimiento descrito en nuestro directorio [openwebtext](./tools/openwebtext). Para URLs de reddit correspondientes a contenido hasta octubre de 2018, obtuvimos aproximadamente 37GB de contenido.

# Reproducibilidad
El entrenamiento con Megatron puede ser reproducible a nivel de bits; para habilitar este modo usa `--deterministic-mode`. Esto significa que la misma configuración de entrenamiento ejecutada dos veces en el mismo entorno HW y SW debería producir checkpoints de modelo, pérdidas y métricas de precisión idénticas (las métricas de tiempo de iteración pueden variar).

Actualmente hay tres optimizaciones conocidas en Megatron que rompen la reproducibilidad aunque aún producen ejecuciones de entrenamiento casi idénticas:
1. El algoritmo específico de NCCL que se utiliza durante un all-reduce (como se especifica por la variable de entorno `NCCL_ALGO`) es importante. Hemos probado los siguientes: `^NVLS`, `Tree`, `Ring`, `CollnetDirect`, `CollnetChain`. El código permite el uso de `^NVLS`, lo que deja a NCCL la elección de algoritmos no-NVLS; su elección parece ser estable.
2. Flash attention no es determinista; no utilices `--use-flash-attn`.
3. Si usas Transformer Engine, también debes establecer la variable de entorno `NVTE_ALLOW_NONDETERMINISTIC_ALGO=0`.

Además, el determinismo solo ha sido verificado en los contenedores NGC PyTorch hasta y posteriores a 23.12. Si observas no-determinismo en el entrenamiento con Megatron bajo otras circunstancias, por favor abre un issue.

# Conversión de Checkpoints

Soportamos dos formas de conversión de modelos:

1. Conversión de clase de modelo (es decir, `GPTModel` en `model.legacy` vs. `model.core`)
2. Conversión de formato de checkpoint (es decir, checkpoint distribuido vs. no distribuido)

## Conversión de clase de modelo

Megatron soporta la conversión entre diferentes clases de modelos, incluyendo clases de modelos internas (actualmente tenemos los modelos `legacy` antiguos y los modelos `core` nuevos) y clases de modelos externas (como los modelos de Meta, Huggingface, Mistral y Mixtral). Además, durante esta conversión, se puede actualizar el estado de paralelismo del modelo (es decir, cambiar el paralelismo de tensor y pipeline del modelo).

 Proporcionamos la herramienta `tools/checkpoint/convert.py` para convertir entre clases de modelos. Algunos argumentos importantes incluyen:

- `--model-type`: `GPT` o `BERT`
- `--loader`: formato del checkpoint existente. Los formatos soportados incluyen:
  - `legacy`: nuestras clases de modelos antiguas (en `megatron.legacy.model`)
  - `core`: nuestras clases de modelos nuevas (en `megatron.core.models`)
  - `llama_mistral`: para cargar modelos Llama y Mistral (soporta formatos de Meta y Huggingface)
  - `mixtral_hf`: para cargar modelos Mixtral (solo Huggingface)
- `--load-dir`: directorio para cargar el checkpoint existente
- `--saver`: `legacy` o `core` (ver descripciones bajo `--loader`)
- `--save-dir`: directorio para guardar el nuevo checkpoint
- `--target-tensor-parallel-size`: nuevo tamaño de paralelismo de tensor
- `--target-pipeline-parallel-size`: nuevo tamaño de paralelismo de pipeline

Para más detalles de los argumentos, consulta el script principal (`convert.py`), los scripts de loader (`loader_core.py`, `loader_legacy.py`, `loader_llama_mistral.py`, `loader_mixtral_hf.py`) o los scripts de saver (`saver_core.py`, `saver_legacy.py`).

Un comando de ejemplo para convertir un modelo GPT del formato antiguo (`legacy`) al nuevo formato (`core`) sería el siguiente:

```
python tools/checkpoint/convert.py \
>   --model-type GPT \
>   --loader legacy \
>   --load-dir ${LEGACY_FORMAT_DIR} \
>   --saver core \
>   --save-dir ${CORE_FORMAT_DIR} \
>   --target-tensor-parallel-size ${TP} \
>   --target-pipeline-parallel-size ${PP} \
```

Para ejemplos de conversión de modelos Llama/Mistral a Megatron, consulta [aquí](docs/llama_mistral.md).

## Conversión de formato de checkpoint

Megatron ofrece múltiples formatos de checkpoint, incluyendo:

- `torch`: Formato de checkpoint básico con lectura y escritura secuenciales, y está ligado a un estado específico de paralelismo de tensor/pipeline (estados TP/PP, respectivamente). (Aunque un checkpoint específico está ligado a un TP/PP específico, aún puede convertirse manualmente mediante el convertidor de clase de modelo descrito arriba).
- `torch_dist`: Formato de checkpoint distribuido, para lecturas y escrituras paralelas rápidas, y también es independiente del estado de paralelismo (es decir, se puede cargar el mismo checkpoint en diferentes configuraciones TP/PP).

En términos generales, `torch_dist` es el formato de checkpoint más moderno y recomendado debido a su velocidad. Sin embargo, dependiendo del caso de uso, puede ser deseable convertir entre estos dos formatos. Para hacerlo, ejecuta tu script de *entrenamiento* (por ejemplo, mediante `pretrain_gpt.py`) como normalmente lo harías, pero con dos argumentos adicionales:

- `--ckpt-convert-format ${FORMAT}`: `${FORMAT}` puede ser `torch` o `torch_dist`, como se describe arriba.
- `--ckpt-convert-save ${PATH_TO_SAVE_NEW_FORMAT}`: esta ruta debe ser diferente de tus rutas actuales de `--load`/`--save`, para evitar sobrescribir el checkpoint existente. Después de convertir, usa esta nueva ruta para tus rutas de `--load`/`--save`.

La idea general de este convertidor de formato de checkpoint es que lanza el modelo como normalmente se haría para entrenamiento, pero antes de ejecutar cualquier iteración de entrenamiento, guarda en el nuevo formato de checkpoint y luego sale. Es importante tener en cuenta que todos los demás argumentos de lanzamiento deben permanecer iguales, para que el sistema entienda el formato del checkpoint anterior.

# Proyectos que Usan Megatron
A continuación se listan algunos de los proyectos donde hemos utilizado Megatron directamente:
* [BERT and GPT Studies Using Megatron](https://arxiv.org/pdf/1909.08053.pdf)
* [BioMegatron: Larger Biomedical Domain Language Model](https://www.aclweb.org/anthology/2020.emnlp-main.379.pdf)
* [End-to-End Training of Neural Retrievers for Open-Domain Question Answering](https://arxiv.org/abs/2101.00408)
* [Large Scale Multi-Actor Generative Dialog Modeling](https://www.aclweb.org/anthology/2020.acl-main.8.pdf)
* [Local Knowledge Powered Conversational Agents](https://arxiv.org/abs/2010.10150)
* [MEGATRON-CNTRL: Controllable Story Generation with External Knowledge Using Large-Scale Language Models](https://www.aclweb.org/anthology/2020.emnlp-main.226.pdf)
* [RACE Reading Comprehension Dataset Leaderboard](http://www.qizhexie.com/data/RACE_leaderboard.html)
* [Training Question Answering Models From Synthetic Data](https://www.aclweb.org/anthology/2020.emnlp-main.468.pdf)
* [Few-shot Instruction Prompts for Pretrained Language Models to Detect Social Biases](https://arxiv.org/abs/2112.07868)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Using DeepSpeed and Megatron to Train Megatron-Turing NLG 530B, A Large-Scale Generative Language Model](https://arxiv.org/abs/2201.11990)
* [Multi-Stage Prompting for Knowledgeable Dialogue Generation](https://arxiv.org/abs/2203.08745)
* [Evaluating Parameter Efficient Learning for Generation](https://aclanthology.org/2022.emnlp-main.319.pdf)
* [Exploring the Limits of Domain-Adaptive Training for Detoxifying Large-Scale Language Models](https://arxiv.org/abs/2202.04173)
* [Shall We Pretrain Autoregressive Language Models with Retrieval? A Comprehensive Study](https://arxiv.org/abs/2304.06762)
* [InstructRetro: Instruction Tuning post Retrieval-Augmented Pretraining](https://arxiv.org/abs/2310.07713)
* [An Empirical Study of Mamba-based Language Models](https://arxiv.org/abs/2406.07887)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---