
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Texto a Voz Rápido y de Alta Calidad Zero-Shot con Flow Matching
</div>

## Descripción General

ZipVoice es una serie de modelos TTS de cero-shot rápidos y de alta calidad basados en flow matching.

### 1. Características clave

- Pequeño y rápido: solo 123M de parámetros.

- Clonación de voz de alta calidad: rendimiento de vanguardia en similitud de hablante, inteligibilidad y naturalidad.

- Multilingüe: soporta chino e inglés.

- Multimodo: soporta generación de habla tanto de un solo hablante como de diálogos.

### 2. Variantes del modelo

<table>
  <thead>
    <tr>
      <th>Nombre del Modelo</th>
      <th>Descripción</th>
      <th>Artículo</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>El modelo básico que soporta TTS de un solo hablante en chino e inglés con cero-shot.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Página_Demo-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>La versión destilada de ZipVoice, con velocidad mejorada y mínima degradación de rendimiento.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Un modelo de generación de diálogos basado en ZipVoice, capaz de generar diálogos hablados de dos partes en un solo canal.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Página_Demo-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>La variante estéreo de ZipVoice-Dialog, que permite la generación de diálogos en dos canales con cada hablante asignado a un canal distinto.</td>
    </tr>
  </tbody>
</table>

## Noticias

**2025/07/14**: Se lanzan **ZipVoice-Dialog** y **ZipVoice-Dialog-Stereo**, dos modelos para generación de diálogos hablados. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: Se publica el conjunto de datos **OpenDialog**, un dataset de diálogos hablados de 6.8k horas. Descárgalo en [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Consulta detalles en [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: Se lanzan **ZipVoice** y **ZipVoice-Distill**. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Instalación

### 1. Clona el repositorio de ZipVoice

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Opcional) Crear un entorno virtual de Python


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Instale los paquetes requeridos


```bash
pip install -r requirements.txt
```
### 4. Instala k2 para entrenamiento o inferencia eficiente

**k2 es necesario para el entrenamiento** y puede acelerar la inferencia. Sin embargo, aún puedes usar el modo de inferencia de ZipVoice sin instalar k2.

> **Nota:** Asegúrate de instalar la versión de k2 que coincida con tu versión de PyTorch y CUDA. Por ejemplo, si estás usando pytorch 2.5.1 y CUDA 12.1, puedes instalar k2 de la siguiente manera:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Por favor, consulte https://k2-fsa.org/get-started/k2/ para más detalles.
Los usuarios en China continental pueden consultar https://k2-fsa.org/zh-CN/get-started/k2/.

- Para comprobar la instalación de k2:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## Uso

### 1. Generación de voz de un solo hablante

Para generar voz de un solo hablante con nuestros modelos preentrenados ZipVoice o ZipVoice-Distill, utilice los siguientes comandos (los modelos necesarios se descargarán desde HuggingFace):

#### 1.1 Inferencia de una sola oración


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` puede ser `zipvoice` o `zipvoice_distill`, que son modelos antes y después de la destilación, respectivamente.
- Si aparecen `<>` o `[]` en el texto, las cadenas encerradas por ellos se tratarán como tokens especiales. `<>` denota pinyin chino y `[]` denota otras etiquetas especiales.

#### 1.2 Inferencia de una lista de oraciones

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Cada línea de `test.tsv` tiene el formato `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Generación de habla en diálogo

#### 2.1 Comando de inferencia

Para generar diálogos hablados de dos partes con nuestros modelos preentrenados ZipVoice-Dialogue o ZipVoice-Dialogue-Stereo, utilice los siguientes comandos (los modelos requeridos se descargarán desde HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` puede ser `zipvoice_dialog` o `zipvoice_dialog_stereo`,
    que generan diálogos mono y estéreo, respectivamente.

#### 2.2 Formatos de entrada

Cada línea de `test.tsv` está en uno de los siguientes formatos:

(1) **Formato de prompt combinado** donde los audios y transcripciones de los prompts de dos hablantes se combinan en un solo archivo wav de prompt:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` es el nombre del archivo wav de salida.
- `prompt_transcription` es la transcripción del archivo wav del prompt conversacional, por ejemplo, "[S1] Hola. [S2] ¿Cómo estás?"
- `prompt_wav` es la ruta al archivo wav del prompt.
- `text` es el texto a sintetizar, por ejemplo, "[S1] Estoy bien. [S2] ¿Cómo te llamas? [S1] Soy Eric. [S2] Hola Eric."

(2) **Formato de prompt dividido** donde los audios y transcripciones de dos hablantes existen en archivos separados:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` es el nombre del archivo wav de salida.
- `spk1_prompt_transcription` es la transcripción del archivo wav de indicación del primer hablante, por ejemplo, "Hola".
- `spk2_prompt_transcription` es la transcripción del archivo wav de indicación del segundo hablante, por ejemplo, "¿Cómo estás?"
- `spk1_prompt_wav` es la ruta al archivo wav de indicación del primer hablante.
- `spk2_prompt_wav` es la ruta al archivo wav de indicación del segundo hablante.
- `text` es el texto que se va a sintetizar, por ejemplo, "[S1] Estoy bien. [S2] ¿Cuál es tu nombre? [S1] Soy Eric. [S2] Hola Eric."

### 3 Guía para un mejor uso:

#### 3.1 Longitud de la indicación

Recomendamos un archivo wav de indicación corto (por ejemplo, menos de 3 segundos para generación de habla de un solo hablante, menos de 10 segundos para generación de diálogos) para una velocidad de inferencia más rápida. Una indicación muy larga ralentizará la inferencia y degradará la calidad del habla.

#### 3.2 Optimización de velocidad

Si la velocidad de inferencia no es satisfactoria, puede acelerarla de la siguiente manera:

- **Modelo destilado y menos pasos**: Para el modelo de generación de habla de un solo hablante, usamos el modelo `zipvoice` por defecto para mejor calidad de habla. Si la velocidad es una prioridad, puede cambiar a `zipvoice_distill` y reducir el parámetro `--num-steps` hasta `4` (8 por defecto).

- **Aceleración de CPU con multiproceso**: Al ejecutar en CPU, puede pasar el parámetro `--num-thread` (por ejemplo, `--num-thread 4`) para aumentar el número de hilos y acelerar la velocidad. Usamos 1 hilo por defecto.

- **Aceleración de CPU con ONNX**: Al ejecutar en CPU, puede usar modelos ONNX con `zipvoice.bin.infer_zipvoice_onnx` para mayor velocidad (aún no soporta ONNX para modelos de generación de diálogo). Para mayor velocidad, puede establecer `--onnx-int8 True` para usar un modelo ONNX cuantizado en INT8. Tenga en cuenta que el modelo cuantizado puede degradar la calidad del habla. **No use ONNX en GPU**, ya que es más lento que PyTorch en GPU.

- **Aceleración de GPU con NVIDIA TensorRT**: Para obtener un gran aumento de rendimiento en GPUs NVIDIA, primero exporte el modelo a un motor TensorRT usando zipvoice.bin.tensorrt_export. Luego, ejecute la inferencia en su conjunto de datos (por ejemplo, un conjunto de datos de Hugging Face) con zipvoice.bin.infer_zipvoice. Esto puede lograr aproximadamente el doble de rendimiento en comparación con la implementación estándar de PyTorch en GPU.

#### 3.3 Control de memoria

El texto dado se dividirá en fragmentos según la puntuación (para generación de habla de un solo hablante) o el símbolo de cambio de hablante (para generación de diálogo). Luego, los textos fragmentados se procesarán en lotes. Por lo tanto, el modelo puede procesar textos arbitrariamente largos con uso de memoria casi constante. Puede controlar el uso de memoria ajustando el parámetro `--max-duration`.

#### 3.4 Evaluación "cruda"

Por defecto, preprocesamos las entradas (archivo wav de indicación, transcripción de indicación y texto) para una inferencia eficiente y mejor rendimiento. Si desea evaluar el rendimiento "crudo" del modelo usando exactamente las entradas proporcionadas (por ejemplo, para reproducir los resultados de nuestro artículo), puede pasar `--raw-evaluation True`.

#### 3.5 Texto corto

Al generar habla para textos muy cortos (por ejemplo, una o dos palabras), el habla generada puede omitir ciertas pronunciaciones. Para resolver este problema, puede pasar `--speed 0.3` (donde 0.3 es un valor ajustable) para extender la duración del habla generada.

#### 3.6 Corrección de caracteres polifónicos chinos mal pronunciados


Utilizamos [pypinyin](https://github.com/mozillazg/python-pinyin) para convertir caracteres chinos a pinyin. Sin embargo, ocasionalmente puede pronunciar incorrectamente **caracteres polifónicos** (多音字).

Para corregir manualmente estas malas pronunciaciones, encierre el **pinyin corregido** entre signos de menor y mayor `< >` e incluya la **marca de tono**.

**Ejemplo:**

- Texto original: `这把剑长三十公分`
- Corrija el pinyin de `长`:  `这把剑<chang2>三十公分`

> **Nota:** Si desea asignar manualmente varios pinyins, encierre cada pinyin con `<>`, por ejemplo, `这把<jian4><chang2><san1>十公分`

#### 3.7 Eliminar silencios largos del habla generada

El modelo determinará automáticamente las posiciones y longitudes de los silencios en el habla generada. Ocasionalmente tiene un silencio largo en medio del discurso. Si no desea esto, puede pasar `--remove-long-sil` para eliminar silencios largos en medio de la voz generada (los silencios en los extremos se eliminarán por defecto).

#### 3.8 Descarga del modelo

Si tiene problemas para conectarse a HuggingFace al descargar los modelos preentrenados, intente cambiar el endpoint al sitio espejo: `export HF_ENDPOINT=https://hf-mirror.com`.

## Entrene su propio modelo

Consulte el directorio [egs](egs) para ejemplos de entrenamiento, ajuste fino y evaluación.

## Despliegue en producción

### Tiempo de ejecución NVIDIA Triton GPU

Para un despliegue listo para producción con alto rendimiento y escalabilidad, consulte la [integración con Triton Inference Server](runtime/nvidia_triton/) que ofrece motores TensorRT optimizados, manejo de solicitudes concurrentes y APIs gRPC/HTTP para uso empresarial.

### Despliegue en CPU

Consulte [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) para la solución de despliegue en C++ sobre CPU.

## Discusión y comunicación

Puede discutir directamente en [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

También puede escanear el código QR para unirse a nuestro grupo de wechat o seguir nuestra cuenta oficial de wechat.

| Grupo de Wechat | Cuenta Oficial de Wechat |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Citación

```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---