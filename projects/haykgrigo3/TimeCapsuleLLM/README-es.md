
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (próximamente)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (próximamente)</a> |
        | <a href="#" title="Coming soon">ไทย (próximamente)</a> |
        | <a href="#" title="Coming soon">Français (próximamente)</a>
        | <a href="#" title="Coming soon">Deutsch (próximamente)</a>
        | <a href="#" title="Coming soon">Español (próximamente)</a>
        | <a href="#" title="Coming soon">Italiano (próximamente)</a>
        | <a href="#" title="Coming soon">Русский (próximamente)</a>
        | <a href="#" title="Coming soon">Português (próximamente)</a>
        | <a href="#" title="Coming soon">Nederlands (próximamente)</a>
        | <a href="#" title="Coming soon">Polski (próximamente)</a>
        | <a href="#" title="Coming soon">العربية (próximamente)</a>
        | <a href="#" title="Coming soon">فارسی (próximamente)</a>
        | <a href="#" title="Coming soon">Türkçe (próximamente)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (próximamente)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (próximamente)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Un LLM entrenado solo con datos de ciertos periodos de tiempo para reducir el sesgo moderno.

Imagina si un modelo de IA no solo pretendiera ser histórico, sino que realmente lo fuera.

Basado en [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT). Los scripts principales de entrenamiento y la arquitectura del modelo son obra suya.

# Objetivos del Proyecto

TimeCapsule LLM es un proyecto experimental que solo será entrenado con textos escritos durante ciertos periodos históricos. El objetivo es simular la cosmovisión y el lenguaje de épocas históricas específicas.

# Por qué el fine tuning no es suficiente

Si solo haces fine tuning de un modelo preentrenado, tu LLM seguirá conociendo conceptos modernos. Por supuesto, lograr cero sesgo moderno es difícil, pero quiero acercarme lo máximo posible a esto. Obtener ausencia de sesgo moderno requiere entrenar un modelo desde cero.

# Resultados esperados

Espero que, cuando esté terminado, este modelo no conozca conceptos modernos y no sea capaz de razonar más allá de lo que ha sido entrenado. No debería reconocer conceptos/vocabulario modernos y espero que no alucine conocimientos actuales.

# Actualizaciones de Progreso

## 9 de julio de 2025

He establecido mi periodo de tiempo en 1800-1850 y región: Londres

He recopilado una lista de textos, libros, documentos

Hasta ahora he conseguido 50 archivos txt y comenzaré el entrenamiento de NanoGPT pronto

Actualizaré esto mientras se siga avanzando

## 13 de julio de 2025

Entrené nanoGPT con 187MB de datos de texto históricos.

## 15 de julio de 2025

Comencé a descargar textos para la segunda ronda de entrenamiento. Estoy obteniendo todo del Internet Archive y amplié el periodo de tiempo a 1800-1875. Para obtener una gama diversa de textos, puedes usar los filtros de tema y búsqueda por lugar de publicación, periodo de tiempo y temas en Internet Archive.

![Filtros de búsqueda](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julio de 2025

Descargué alrededor de 500 archivos txt de Internet Archive y después de limpiarlos (solo eliminando espacios en blanco, cabeceras de Gutenberg, etc.) tengo alrededor de 500MB de datos. Es un conjunto de datos pequeño pero la última vez entrené con 187MB así que debería haber al menos alguna diferencia notable en la salida después de entrenar el segundo modelo. Espero que este modelo pueda al menos producir oraciones más coherentes que tengan algo de sentido. No es una garantía, por supuesto, ya que sigue siendo un conjunto de datos muy pequeño, pero es más de lo que usé la última vez.

Esto debería poder hacerse en mi propio hardware, lo cual es bueno porque espero ver alguna mejora antes de pasar a un conjunto de datos mayor, lo que requeriría alquilar una GPU. Pero no te preocupes, todavía planeo alquilar una GPU pronto, pero antes de eso quiero asegurarme de que mi conjunto de datos esté lo más curado y limpio posible. Uno de los problemas que tengo es la limpieza, muchos de estos archivos txt tienen basura mezclada. Los scripts que he usado para limpiar funcionan pero no son 100% efectivos.

Entrenaré este conjunto de datos hoy y debería tomar unas 4-5 horas. Una vez que termine y lo pruebe, daré actualizaciones. ¡Gracias nuevamente a todos los que están revisando mi proyecto, incluso ha habido personas que me han dado enlaces a recursos OCR, así que gracias! Espero que más personas prueben esto y experimenten con sus propios conjuntos de datos.


### Actualización de Entrenamiento

Comencé el entrenamiento con un corpus de 435MB (108 M tokens), va bastante bien hasta ahora. La pérdida de entrenamiento bajó de 10.9 a 4.9 en las primeras 2800 iteraciones. Espero que tome unas 8 o 9 horas completar. Publicaré otra actualización una vez que termine.

## 17 de julio de 2025

El entrenamiento terminó para el segundo modelo, mi 4060 tardó unas 8 horas y 40 minutos (3.900 iteraciones/hora) para 33.000 iteraciones (5 épocas). La pérdida final de entrenamiento fue 3.73. Los resultados fueron sorprendentemente buenos; ahora realmente genera oraciones coherentes al estilo del siglo XIX.

## 28 de julio de 2025

He subido la versión v0.5 a Hugging Face, [Échale un vistazo](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) si quieres. Ahora puedes descargar mi repositorio y ejecutarlo localmente. Desafortunadamente nanoGPT no funciona de forma nativa con HuggingFace, así que tendrás que descargar y ejecutar el modelo localmente.

También comenzaré a curar datos para mi próxima ronda de entrenamiento, creo que necesitaré quizá de 5 a 10 veces más datos para lograr capacidades de razonamiento.

## 2 de agosto de 2025

Pronto comenzaré a trabajar en la Versión 1. Necesitaré pasar de la arquitectura de nanoGPT a algo más moderno. Tengo en mente varias arquitecturas LLM de código abierto, incluidas: OpenLLaMA v3, Phi-2 y Qwen 1.5B. Y para soportar el salto a la V1, tendré que curar cuidadosamente un conjunto de datos mucho más grande y diverso. Necesitaré al menos 5GB de datos de entrenamiento limpios.

# Comportamiento y Limitaciones del Modelo V0

Los primeros prompts muestran que el modelo responde con lenguaje y comportamiento de los años 1800. Por ejemplo, le pregunté "Who art Henry?" y respondió "I know that man, I have did not a black, the storm." y sí, esa frase no tiene sentido pero el LLM reconoce que estoy preguntando por una persona.

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

No hay mención de conceptos modernos, las salidas contienen mayormente palabras y frases propias de los años 1800.

Todavía necesita mucho trabajo, entrenar con solo 187MB no te dará un modelo que produzca texto con razonamiento complejo.

Por ahora produce frases que carecen de estructura de oración completa y en general no tienen sentido, pero esto es normal para el tamaño de entrenamiento.

# Comportamiento y Limitaciones del Modelo V0.5

Esto es una mejora considerable comparado con el modelo anterior. El estilo de escritura y vocabulario es victoriano y casi todas las frases son gramaticalmente correctas con la puntuación adecuada. Y nuevamente esto está entrenado desde cero así que se apega a temas de los años 1800.

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Hay muchas alucinaciones de hechos. Muchas (como el 100%) de los detalles (fechas, eventos, personajes históricos) son inventados. Además, las frases realmente no tienen conexión entre sí, a veces tal vez 2 frases se relacionan pero más allá de eso no. Otro problema es que a veces aparece un pie de página errante de “Digitized by Google”, así que la próxima vez que entrene tengo que asegurarme de limpiar bien los textos. En general estoy muy contento con los resultados, aún está lejos de ser un LLM pero definitivamente es un generador de frases.

Estoy aprendiendo mucho y comenzaré a descubrir qué debo mejorar en las próximas semanas. ¡Pronto subiré archivos!

# Planes Próximos

(Completado) Voy a empezar a trabajar en la versión 0.5, en vez de entrenar usando 50 libros, entrenaré idealmente usando 500-600. Ahora mismo estoy entrenando nanoGPT usando libros de 1800-1850 y específicamente de Londres. Hay algunos desafíos como asegurarme de que los libros que encuentre no estén actualizados o tengan interpretaciones modernas sino que sean libros intactos publicados dentro del período que elegí.

Quiero entrenar un nuevo modelo (v1) con un corpus mucho más grande, tal vez 5-10 veces más grande que el que usé para v0.5. Mi objetivo es ver si puedo lograr que emerjan habilidades de razonamiento solo a partir del Entrenamiento Temporal Selectivo, esto será una tarea más difícil y ni siquiera estoy seguro de si es posible debido a las limitaciones de datos históricos. En las próximas semanas trataré de curar suficientes datos para un corpus de 5-10GB. Creo que si puedo obtener datos limpios y de alta calidad y alquilar una GPU, habrá progreso.

# Cómo Usar Este Proyecto

Este proyecto se centra principalmente en curar datos históricos, prepararlos para el entrenamiento y construir un tokenizador. No voy a cubrir el proceso completo de entrenamiento de LLM, para eso consulta nanoGPT de Andrej Karpathy.

# Paso 1: Reunir y Preparar Textos Históricos

Recoge archivos .txt de libros de dominio público, documentos, etc. de tu período de tiempo elegido (por ejemplo, Londres 1800-1850)

Puedes usar download_texts_improved.py para descargar libros si lo necesitas.

Limpia los archivos de texto usando un script o manualmente elimina encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

prepare_dataset.py debería funcionar bien.

# Paso 2: Construir un Tokenizador Personalizado

Ejecuta train_tokenizer.py o train_tokenizer_hf.py en los datos limpios.
Esto te dará vocab.json y merges.txt

Estos archivos definen el vocabulario y las reglas de combinación para tu modelo.

# Paso 3: Entrena tu Modelo (nanoGPT)

Consulta [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento.

Puedes entrenar un LLM diferente si lo deseas, pero yo usé nanoGPT

# Preguntas Frecuentes

## ¿Qué es el Entrenamiento Temporal Selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se curan específicamente para que pertenezcan a un período histórico concreto. Se hace para modelar el lenguaje y conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual que tengo (v0.5) está entrenado en datos exclusivamente de 1800-1875, no está ajustado sino entrenado desde cero, dando como resultado una salida que refleja el estilo lingüístico y contexto histórico de ese período.

## ¿Por qué no simplemente usar fine-tuning o LoRA?

Para este proyecto estoy tratando de crear un modelo de lenguaje que no esté sesgado por lo moderno. Si hago fine-tuning a algo como GPT-2, ya está preentrenado y esa información no se irá. Si entreno desde cero el modelo de lenguaje no va a pretender ser antiguo, simplemente lo será. El objetivo de este proyecto por ahora es crear algo que pueda razonar exclusivamente usando el conocimiento de libros de Londres publicados entre 1800 y 1850.

## ¿Qué tipo de datos usaste para el entrenamiento?

Estoy usando libros, documentos legales, periódicos y otros escritos de Londres de 1800–1850. La lista que enlacé tiene como 200, pero para el primer entrenamiento solo usé 50 archivos, unos ~187 MB. Puedes ver una lista de los documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## ¿Qué tan grande es el modelo Versión 0?

Este modelo es muy pequeño por ahora, solo lo hago por diversión y sigo una regla estricta de entrenamiento sin fuentes modernas. Tiene casi 16 millones de parámetros pero voy a empezar a reunir más textos antiguos para comenzar otro entrenamiento de modelo. Iré dando actualizaciones a medida que avance.

## ¿Especificaciones de Entrenamiento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---