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
Un LLM entrenado solo con datos de ciertos periodos para reducir el sesgo moderno.

Imagina si un modelo de IA no solo pretendiera ser histórico, sino que realmente lo fuera.

Construido sobre [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT). Los scripts principales de entrenamiento y la arquitectura del modelo son de su autoría.

# Objetivos del Proyecto

TimeCapsule LLM es un proyecto experimental que solo será entrenado con textos escritos durante ciertos periodos históricos. El objetivo es simular la cosmovisión y el lenguaje de épocas históricas específicas.

# Por qué el fine tuning no es suficiente

Si solo haces fine tuning a un modelo preentrenado, tu LLM seguirá conociendo conceptos modernos. Por supuesto, lograr cero sesgo moderno es difícil, pero quiero acercarme lo máximo posible a esto. Lograr que no haya sesgo moderno requiere entrenar un modelo desde cero.

# Resultados esperados

Espero que, cuando esté terminado, este modelo no conozca conceptos modernos y no pueda razonar más allá de lo que ha sido entrenado. No debería reconocer vocabulario/conceptos modernos y espero que no alucine conocimientos actuales.

# Actualizaciones de Progreso

## 9 de julio de 2025

He definido mi periodo de entrenamiento en 1800-1850 y la región: Londres

He reunido una lista de textos, libros, documentos

Hasta ahora he conseguido 50 archivos txt y pronto comenzaré a entrenar NanoGPT

Actualizaré esto mientras se haga progreso

## 13 de julio de 2025

Entrené nanoGPT con 187MB de datos de texto históricos.

## 15 de julio de 2025

He comenzado a descargar textos para la segunda ronda de entrenamiento. Estoy obteniendo todo del Internet Archive y he ampliado el periodo a 1800-1875. Para obtener una gama diversa de textos, puedes usar los filtros de tema y búsqueda por ubicación de publicación, periodo y temas en Internet Archive.

![Filtros de Búsqueda](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julio de 2025

Descargué unos 500 archivos txt del Internet Archive y, tras limpiarlos (solo eliminando espacios en blanco, encabezados de Gutenberg, etc.) tengo alrededor de 500MB de datos. Es un conjunto de datos pequeño, pero la última vez entrené con 187MB, así que debería haber al menos alguna diferencia notable en la salida tras entrenar el segundo modelo. Espero que este modelo pueda al menos producir frases más coherentes que tengan cierto sentido. Por supuesto, no es garantía ya que sigue siendo un conjunto de datos muy pequeño, pero es más de lo que usé la vez pasada.

Esto debería ser posible en mi propio hardware, lo cual es bueno porque espero ver alguna mejora antes de saltar a un conjunto de datos más grande que requeriría alquilar una GPU. Pero no te preocupes, aún planeo alquilar una GPU pronto, pero antes quiero asegurarme de que mi conjunto de datos esté lo más curado y limpio posible. Uno de los problemas que tengo es la limpieza, muchos de estos archivos txt tienen basura mezclada. Los scripts que he usado para limpiar funcionan pero no son 100% efectivos.

Voy a entrenar este conjunto de datos hoy y debería tomar unas 4-5 horas. Una vez termine y lo pruebe, daré actualizaciones. ¡Gracias de nuevo a todos los que revisan mi proyecto, incluso he recibido enlaces a recursos de OCR así que gracias! Espero que más gente lo intente y experimente con sus propios conjuntos de datos.


### Actualización de Entrenamiento

Comencé a entrenar con un corpus de 435MB (108 M tokens), por ahora va bastante fluido. La pérdida de entrenamiento bajó de 10.9 a 4.9 en las primeras 2800 iteraciones. Espero que tome unas 8 o 9 horas completar. Publicaré otra actualización cuando termine.

## 17 de julio de 2025 2:13AM

El entrenamiento del segundo modelo ha terminado, mi 4060 tardó unas 8 horas y 40 minutos (3,900 iteraciones/hora) para 33,000 iteraciones (5 épocas). La pérdida final de entrenamiento fue 3.73. Las salidas fueron sorprendentemente buenas: ahora realmente genera frases coherentes al estilo del siglo XIX.

## 28 de julio de 2025

He subido la v0.5 a Hugging Face, [échale un vistazo](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) si quieres. Ahora puedes descargar mi repositorio y ejecutarlo localmente. Desafortunadamente, nanoGPT no funciona de manera nativa con HuggingFace, así que tendrás que descargar y ejecutar el modelo localmente.

Además, comenzaré a curar datos para mi próxima ronda de entrenamiento. Creo que necesitaré quizá 5-10 veces más datos para lograr capacidades de razonamiento.


# Comportamiento y Limitaciones del Modelo V0

Las primeras pruebas muestran que el modelo responde con lenguaje y comportamiento de los años 1800. Por ejemplo, lo probé con "Who art Henry?" y respondió "I know that man, I have did not a black, the storm." y sí, esa frase no tiene sentido pero el LLM está reconociendo que pregunto por una persona.


![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

No hay mención de conceptos modernos, las salidas contienen principalmente palabras y frases propias de los años 1800.

Todavía necesita mucho trabajo, entrenar con 187MB no te dará un modelo que produzca texto con razonamiento complejo.

Actualmente produce oraciones que carecen de estructura completa y en general no tienen sentido, pero esto es normal para el tamaño de entrenamiento.

# Comportamiento y Limitaciones del Modelo V0.5

Esto es una buena mejora en comparación con el último modelo. El estilo de escritura y el vocabulario son victorianos y casi todas las oraciones son gramaticalmente correctas con la puntuación adecuada. Y nuevamente, esto está entrenado desde cero, por lo que se apega a temas de los años 1800.

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Hay muchas alucinaciones fácticas. Muchos (como el 100%) de los detalles (fechas, eventos, figuras históricas) son inventados. Además, las oraciones realmente no tienen conexión entre sí, a veces tal vez 2 oraciones se relacionan pero más allá de eso no. Otro problema es que a veces aparece un pie de página errante como “Digitized by Google”, así que la próxima vez que entrene realmente tengo que asegurarme de limpiar bien los textos. En general estoy muy contento con los resultados, aún está lejos de ser un LLM pero definitivamente es un generador de oraciones.

Estoy aprendiendo mucho y en las próximas semanas empezaré a averiguar qué necesito mejorar. ¡Subiré archivos pronto!

# Planes Futuros

(Completado) Voy a empezar a trabajar en la versión 0.5, en lugar de entrenar usando 50 libros, entrenaré usando idealmente 500-600. Actualmente estoy entrenando nanoGPT usando libros de 1800-1850 y específicamente de Londres. Hay algunos desafíos como asegurar que los libros que encuentro no estén actualizados o tengan interpretaciones modernas, sino libros intactos publicados dentro del periodo de tiempo elegido.

Quiero entrenar un nuevo modelo (v1) con un corpus mucho más grande, tal vez 5-10 veces mayor que el que usé para v0.5. Mi objetivo es ver si puedo lograr que surjan habilidades de razonamiento solo con el Entrenamiento Temporal Selectivo, esto será una tarea más difícil y ni siquiera estoy completamente seguro de si es posible debido a las limitaciones de datos históricos. En las próximas semanas intentaré curar suficientes datos para un corpus de 5-10GB. Creo que si consigo datos limpios de alta calidad y alquilo una GPU, habrá progreso.

# Cómo Usar Este Proyecto

Este proyecto se enfoca principalmente en curar datos históricos, prepararlos para el entrenamiento y construir un tokenizador. No voy a cubrir el proceso completo de entrenamiento de LLM, para eso consulta nanoGPT de Andrej Karpathy.

# Paso 1: Recopila y Prepara Textos Históricos

Recopila archivos .txt de libros de dominio público, documentos, etc. de tu periodo de tiempo elegido (por ejemplo, Londres 1800-1850)

Puedes usar download_texts_improved.py para descargar libros si lo necesitas.

Limpia los archivos de texto usando un script o eliminando manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o cosas como errores de OCR.

prepare_dataset.py debería funcionar bien.

# Paso 2: Construye un Tokenizador Personalizado

Ejecuta train_tokenizer.py o train_tokenizer_hf.py sobre los datos limpios.
Esto te dará vocab.json y merges.txt

Estos archivos definen el vocabulario y las reglas de combinación para tu modelo

# Paso 3: Entrena Tu Modelo (nanoGPT)

Consulta [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento.

Puedes entrenar un LLM diferente si lo deseas, pero yo usé nanoGPT

# FAQ

## ¿Qué es el Entrenamiento Temporal Selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se curan específicamente para que pertenezcan a un periodo histórico específico. Se hace para modelar el lenguaje y el conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual que tengo ahora (v0.5) está entrenado exclusivamente con datos de 1800-1875, no está afinado sino entrenado desde cero, resultando en una salida que refleja el estilo lingüístico y contexto histórico de esa época.

## ¿Por qué no simplemente usar fine-tuning o LoRA?

Para este proyecto estoy tratando de crear un modelo de lenguaje sin sesgo moderno. Si afino algo como GPT-2, ya está preentrenado y esa información no desaparecerá. Si entreno desde cero el modelo de lenguaje no fingirá ser antiguo, simplemente lo será. El objetivo de este proyecto ahora es crear algo que pueda razonar usando exclusivamente conocimiento de libros de Londres publicados entre 1800 y 1850.

## ¿Qué tipo de datos usaste para entrenar?

Estoy usando libros, documentos legales, periódicos y otros escritos de Londres 1800-1850. La lista que enlacé tiene como 200 pero para el primer entrenamiento solo usé 50 archivos de unos ~187 MB. Puedes ver una lista de los documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## ¿Qué tan grande es el Modelo Versión 0?

Este modelo es muy pequeño ahora, solo lo hago por diversión y siguiendo una regla estricta de entrenamiento de no usar fuentes modernas. Tiene casi 16 millones de parámetros pero voy a empezar a recopilar más textos antiguos para comenzar otro entrenamiento de modelo. Iré dando actualizaciones conforme avance.

## ¿Especificaciones de entrenamiento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---