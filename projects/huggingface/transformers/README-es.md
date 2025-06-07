<!---
Copyright 2020 The HuggingFace Team. Todos los derechos reservados.

Licenciado bajo la Licencia Apache, Versión 2.0 (la "Licencia");
no puede usar este archivo excepto en cumplimiento con la Licencia.
Puede obtener una copia de la Licencia en

    http://www.apache.org/licenses/LICENSE-2.0

A menos que la ley aplicable lo requiera o se acuerde por escrito, el software
distribuido bajo la Licencia se distribuye "TAL CUAL",
SIN GARANTÍAS NI CONDICIONES DE NINGÚN TIPO, ya sean expresas o implícitas.
Consulte la Licencia para conocer el lenguaje específico que rige los permisos y
limitaciones bajo la Licencia.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints en Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentación" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>Modelos preentrenados de última generación para inferencia y entrenamiento</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers es una biblioteca de modelos preentrenados para texto, visión por computadora, audio, video y modelos multimodales para inferencia y entrenamiento. Utiliza Transformers para ajustar modelos con tus datos, crear aplicaciones de inferencia y para casos de uso de IA generativa en múltiples modalidades.

Hay más de 500K+ [checkpoints de modelos](https://huggingface.co/models?library=transformers&sort=trending) de Transformers en el [Hugging Face Hub](https://huggingface.com/models) que puedes utilizar.

Explora el [Hub](https://huggingface.com/) hoy mismo para encontrar un modelo y utiliza Transformers para ayudarte a comenzar de inmediato.

## Instalación

Transformers funciona con Python 3.9+ [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+, y [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Crea y activa un entorno virtual con [venv](https://docs.python.org/3/library/venv.html) o [uv](https://docs.astral.sh/uv/), un gestor de paquetes y proyectos de Python rápido basado en Rust.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Instala Transformers en tu entorno virtual.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Instala Transformers desde el código fuente si deseas los últimos cambios en la biblioteca o si estás interesado en contribuir. Sin embargo, la versión *más reciente* puede no ser estable. Si encuentras algún error, no dudes en abrir un [issue](https://github.com/huggingface/transformers/issues).

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Inicio rápido

Comienza a usar Transformers de inmediato con la API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). `Pipeline` es una clase de inferencia de alto nivel que soporta tareas de texto, audio, visión y multimodales. Se encarga del preprocesamiento de la entrada y devuelve la salida apropiada.

Instancia un pipeline y especifica el modelo a usar para generación de texto. El modelo se descarga y almacena en caché para que puedas reutilizarlo fácilmente. Finalmente, pasa un texto para solicitar al modelo.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("el secreto para hornear un pastel realmente bueno es ")
[{'generated_text': 'el secreto para hornear un pastel realmente bueno es 1) usar los ingredientes correctos y 2) seguir la receta exactamente. La receta para el pastel es la siguiente: 1 taza de azúcar, 1 taza de harina, 1 taza de leche, 1 taza de mantequilla, 1 taza de huevos, 1 taza de chispas de chocolate. Si deseas hacer 2 pasteles, ¿cuánta azúcar necesitas? Para hacer 2 pasteles, necesitarás 2 tazas de azúcar.'}]
```

Para chatear con un modelo, el patrón de uso es el mismo. La única diferencia es que necesitas construir un historial de chat (la entrada para `Pipeline`) entre tú y el sistema.

> [!TIP]
> También puedes chatear con un modelo directamente desde la línea de comandos.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Eres un robot descarado y sarcástico como imaginado por Hollywood en 1986."},
    {"role": "user", "content": "Oye, ¿puedes decirme cosas divertidas para hacer en Nueva York?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Expande los ejemplos a continuación para ver cómo funciona `Pipeline` para diferentes modalidades y tareas.

<details>
<summary>Reconocimiento automático de voz</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Clasificación de imágenes</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'cacatúa de cresta azufrada, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorito', 'score': 0.00018523589824326336},
 {'label': 'loro gris africano, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'codorniz', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>Respuesta visual a preguntas</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="¿Qué hay en la imagen?",
)
[{'answer': 'estatua de la libertad'}]
```

</details>

## ¿Por qué debería usar Transformers?

1. Modelos de última generación fáciles de usar:
    - Alto rendimiento en comprensión y generación de lenguaje natural, visión por computadora, audio, video y tareas multimodales.
    - Baja barrera de entrada para investigadores, ingenieros y desarrolladores.
    - Pocas abstracciones orientadas al usuario con solo tres clases por aprender.
    - Una API unificada para usar todos nuestros modelos preentrenados.

1. Menor costo de cómputo, menor huella de carbono:
    - Comparte modelos entrenados en lugar de entrenar desde cero.
    - Reduce el tiempo de cómputo y los costos de producción.
    - Docenas de arquitecturas de modelos con más de 1M+ checkpoints preentrenados en todas las modalidades.

1. Elige el framework adecuado para cada etapa del ciclo de vida del modelo:
    - Entrena modelos de última generación en 3 líneas de código.
    - Mueve un solo modelo entre frameworks PyTorch/JAX/TF2.0 a voluntad.
    - Elige el framework adecuado para entrenamiento, evaluación y producción.

1. Personaliza fácilmente un modelo o un ejemplo según tus necesidades:
    - Proporcionamos ejemplos para cada arquitectura para reproducir los resultados publicados por sus autores originales.
    - Los internos del modelo están expuestos de la manera más consistente posible.
    - Los archivos del modelo pueden usarse independientemente de la biblioteca para experimentos rápidos.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## ¿Por qué no debería usar Transformers?

- Esta biblioteca no es una caja de herramientas modular de bloques de construcción para redes neuronales. El código en los archivos de modelo no está refactorizado con abstracciones adicionales a propósito, para que los investigadores puedan iterar rápidamente en cada uno de los modelos sin sumergirse en archivos/abstracciones adicionales.
- La API de entrenamiento está optimizada para trabajar con modelos PyTorch proporcionados por Transformers. Para bucles genéricos de machine learning, deberías usar otra biblioteca como [Accelerate](https://huggingface.co/docs/accelerate).
- Los [scripts de ejemplo]((https://github.com/huggingface/transformers/tree/main/examples)) son solo *ejemplos*. Puede que no funcionen directamente en tu caso de uso específico y necesitarás adaptar el código para que funcione.

## 100 proyectos usando Transformers

Transformers es más que una caja de herramientas para usar modelos preentrenados, es una comunidad de proyectos construidos alrededor de él y del Hugging Face Hub. Queremos que Transformers permita a desarrolladores, investigadores, estudiantes, profesores, ingenieros y a cualquier otra persona construir los proyectos de sus sueños.

Para celebrar los 100,000 estrellas de Transformers, quisimos resaltar a la comunidad con la página [awesome-transformers](./awesome-transformers.md) que lista 100 proyectos increíbles construidos con Transformers.

Si tienes o usas un proyecto que crees que debería ser parte de la lista, ¡por favor abre un PR para agregarlo!

## Modelos de ejemplo

Puedes probar la mayoría de nuestros modelos directamente en sus [páginas de modelos en el Hub](https://huggingface.co/models).

Expande cada modalidad a continuación para ver algunos modelos de ejemplo para varios casos de uso.

<details>
<summary>Audio</summary>

- Clasificación de audio con [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Reconocimiento automático de voz con [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Detección de palabras clave con [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Generación de voz a voz con [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Texto a audio con [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Texto a voz con [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Visión por computadora</summary>

- Generación automática de máscaras con [SAM](https://huggingface.co/facebook/sam-vit-base)
- Estimación de profundidad con [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Clasificación de imágenes con [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Detección de puntos clave con [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Emparejamiento de puntos clave con [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Detección de objetos con [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Estimación de pose con [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Segmentación universal con [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Clasificación de video con [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Multimodal</summary>

- Audio o texto a texto con [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Respuesta a preguntas en documentos con [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Imagen o texto a texto con [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Descripción de imágenes con [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- Comprensión de documentos basada en OCR con [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Respuesta a preguntas en tablas con [TAPAS](https://huggingface.co/google/tapas-base)
- Comprensión y generación multimodal unificada con [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Visión a texto con [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Respuesta visual a preguntas con [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Segmentación de expresiones referidas visualmente con [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>PLN (Procesamiento de Lenguaje Natural)</summary>

- Completar palabras enmascaradas con [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Reconocimiento de entidades nombradas con [Gemma](https://huggingface.co/google/gemma-2-2b)
- Respuesta a preguntas con [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Resumen con [BART](https://huggingface.co/facebook/bart-large-cnn)
- Traducción con [T5](https://huggingface.co/google-t5/t5-base)
- Generación de texto con [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Clasificación de texto con [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Citación

Ahora tenemos un [artículo](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) que puedes citar para la biblioteca 🤗 Transformers:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---