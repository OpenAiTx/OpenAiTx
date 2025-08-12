
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Próximamente">繁體中文 (próximamente)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Próximamente">हिन्दी (próximamente)</a> |
        | <a href="#" title="Próximamente">ไทย (próximamente)</a> |
        | <a href="#" title="Próximamente">Français (próximamente)</a>
        | <a href="#" title="Próximamente">Deutsch (próximamente)</a>
        | <a href="#" title="Próximamente">Español (próximamente)</a>
        | <a href="#" title="Próximamente">Italiano (próximamente)</a>
        | <a href="#" title="Próximamente">Русский (próximamente)</a>
        | <a href="#" title="Próximamente">Português (próximamente)</a>
        | <a href="#" title="Próximamente">Nederlands (próximamente)</a>
        | <a href="#" title="Próximamente">Polski (próximamente)</a>
        | <a href="#" title="Próximamente">العربية (próximamente)</a>
        | <a href="#" title="Próximamente">فارسی (próximamente)</a>
        | <a href="#" title="Próximamente">Türkçe (próximamente)</a>
        | <a href="#" title="Próximamente">Tiếng Việt (próximamente)</a>
        | <a href="#" title="Próximamente">Bahasa Indonesia (próximamente)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Un LLM entrenado solo con datos de ciertos períodos de tiempo para reducir el sesgo moderno.

Imagina si un modelo de IA no solo pretendiera ser histórico, sino que realmente lo fuera.

Construido sobre [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) Los scripts principales de entrenamiento y la arquitectura del modelo son obra suya.

# Objetivos del proyecto
TimeCapsule LLM es un proyecto experimental que solo será entrenado con textos escritos durante ciertos períodos de tiempo. El objetivo es simular la visión del mundo y el lenguaje de eras históricas específicas.

# Por qué el ajuste fino no es suficiente

Si solo ajustas un modelo preentrenado, tu LLM todavía conocerá conceptos modernos. Por supuesto, lograr cero sesgo moderno es difícil, pero quiero acercarme lo más posible a esto. No tener sesgo moderno requiere entrenar un modelo desde cero.

# Resultados esperados

Con suerte, cuando termine, este modelo no conocerá conceptos modernos y no podrá razonar más allá de lo que ha sido entrenado. No debería reconocer conceptos/vocabulario modernos y no debería alucinar conocimiento moderno.

# Actualizaciones de progreso

## 9 de julio de 2025

He establecido mi período de tiempo en 1800-1850 y región: Londres

He reunido una lista de textos, libros, documentos

Hasta ahora he conseguido 50 archivos txt y pronto comenzaré a entrenar NanoGPT

Actualizaré esto mientras se haga progreso

## 13 de julio de 2025

Entrené nanoGPT con 187MB de datos históricos en texto.

## 15 de julio de 2025

Empecé a descargar textos para la segunda ronda de entrenamiento. Estoy obteniendo todo del Internet Archive y he ampliado el período de tiempo a 1800-1875. Para obtener una variedad diversa de textos, puedes usar filtros de búsqueda y de tema por ubicación de publicación, período de tiempo y temas en Internet Archive.

![Filtros de búsqueda](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julio de 2025

Descargué alrededor de 500 archivos txt del Internet Archive y después de limpiarlos (solo eliminando espacios en blanco, encabezados de Gutenberg, etc.) tengo alrededor de 500MB de datos. Es un conjunto de datos pequeño pero la última vez entrené con 187MB así que debería haber al menos alguna diferencia notable en la salida después de entrenar el segundo modelo. Espero que este modelo pueda al menos producir oraciones más coherentes que tengan algo de sentido. No es una garantía por supuesto ya que sigue siendo un conjunto de datos muy pequeño, pero es más que lo que usé la última vez.

Esto debería ser posible en mi propio hardware, también es bueno porque espero ver algún tipo de mejora antes de pasar a un conjunto de datos más grande que requeriría alquilar una GPU. Pero no te preocupes, todavía planeo alquilar una GPU pronto, pero antes de hacerlo quiero asegurarme de que mi conjunto de datos esté lo más curado y limpio posible. Uno de los problemas que tengo es la limpieza, muchos de estos archivos txt tienen galimatías mezcladas. Los scripts que he usado para limpiar funcionan pero no son 100% efectivos.

Entrenaré este conjunto de datos hoy y debería tomar alrededor de 4-5 horas. Una vez que esté hecho y lo pruebe, daré actualizaciones. Gracias de nuevo a todos los que están revisando mi proyecto, incluso ha habido personas que me han dado enlaces a recursos de OCR así que ¡Gracias! Espero que más personas intenten esto y experimenten con sus propios conjuntos de datos.


## 12 de agosto de 2025

La versión 1 está completa, esta versión utiliza Phi 1.5 (700M parámetros) y está entrenada en un conjunto de datos que contiene casi 7000 textos. Las principales mejoras de este modelo son su capacidad de a veces referenciar nombres reales y eventos históricos. Las versiones 0 y 0.5 no podían hacer esto; cuando les indicaba algo como "En el año 1821", la salida eran solo alucinaciones, cosas que nunca sucedieron. Un ejemplo de esto con la Versión 1:

Mi indicación: Era el año de nuestro Señor 1834,

La salida: "Era el año de nuestro Señor 1834 y las calles de Londres estaban llenas de protestas y peticiones. La causa, como muchos recordaban, no estaba ligada al ámbito privado, sino que había sido tomada ese mismo día en el día de Lord Palmerston, el público recibirá una breve declaración de las dificultades bajo las cuales el día de la ley nos ha alcanzado. Es motivo de profundo pesar que los acontecimientos actuales en la historia del mundo sean claros, y en consecuencia serán conocidos. No es cierto que los mismos hombres que primero se establecieron en el Evangelio en Jerusalén tengan un registro tan extenso e interesante de la prosperidad y prosperidad"

Al principio supuse que podría ser una coincidencia, pero mira esto: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Actualización de Entrenamiento

Comencé a entrenar con un corpus de 435MB (108 M tokens), va bastante bien por ahora. La pérdida de entrenamiento bajó de 10.9 a 4.9 en las primeras 2800 iteraciones. Espero que tarde unas 8 o 9 horas en completarse. Publicaré otra actualización cuando termine.

## 17 de julio de 2025

El entrenamiento está terminado para el segundo modelo, mi 4060 tardó unas 8 horas y 40 minutos (3,900 iteraciones/hr) para 33,000 iteraciones (5 épocas). La pérdida final de entrenamiento fue de 3.73. Las salidas fueron sorprendentemente buenas, ahora realmente genera frases coherentes al estilo del siglo XIX.

## 28 de julio de 2025

He subido la v0.5 a Hugging Face, [Échale un vistazo](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) si quieres. Ahora puedes descargar mi repositorio y ejecutarlo localmente. Desafortunadamente nanoGPT no funciona de manera nativa con HuggingFace, así que tendrás que descargar y ejecutar el modelo localmente.

También comenzaré a curar datos para mi próxima sesión de entrenamiento, creo que necesitaré quizá 5-10x más datos para lograr capacidades de razonamiento.

## 2 de agosto de 2025

Pronto comenzaré a trabajar en la Versión 1. Necesitaré hacer la transición de la arquitectura de nanoGPT a algo más moderno. Tengo en mente varias arquitecturas LLM de código abierto, incluyendo: OpenLLaMA v3, Phi-2 y Qwen 1.5B. Y para soportar el salto a la V1, tendré que curar cuidadosamente un conjunto de datos mucho más grande y diverso. Necesitaré al menos 5GB de datos limpios de entrenamiento.

# Comportamiento y Limitaciones del Modelo V0

Las primeras indicaciones muestran al modelo respondiendo con lenguaje y comportamiento de los años 1800. Por ejemplo, le pregunté "¿Quién es Henry?" y respondió "Conozco a ese hombre, no tengo negro, la tormenta." y sí, esa frase no tiene sentido pero el LLM reconoce que estoy preguntando por una persona.

![TimeLockLLM Salida de Muestra](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

No hay mención de conceptos modernos, las salidas contienen principalmente palabras y frases de los años 1800.

Todavía necesita mucho trabajo, entrenar con 187MB no te dará un modelo que produzca texto con razonamiento complejo.

Ahora mismo produce oraciones que carecen de estructura completa y en general simplemente no tienen sentido, pero esto es normal para el tamaño de entrenamiento.

# Comportamiento y Limitaciones del Modelo V0.5

Esto es una buena mejora en comparación con el último modelo. El estilo de escritura y el vocabulario son victorianos y casi todas las oraciones son gramaticalmente correctas con la puntuación adecuada. Y nuevamente, esto está entrenado desde cero así que se apega a temas de los años 1800.

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Hay muchas alucinaciones fácticas. Muchos (como el 100%) de los detalles (fechas, eventos, figuras históricas) son inventados. Además, las oraciones realmente no tienen conexión entre sí, a veces tal vez 2 oraciones se relacionan, pero más allá de eso no lo hacen. Otro problema es que a veces aparece un pie de página perdido de “Digitized by Google”, así que la próxima vez que entrene realmente debo asegurarme de que los textos estén bien limpiados. En general estoy muy contento con los resultados, aún está lejos de ser un LLM pero definitivamente es un generador de oraciones.

Estoy aprendiendo mucho y comenzaré a averiguar qué debo mejorar en las próximas semanas. ¡Pronto subiré archivos!

# Comportamiento y Limitaciones del Modelo V1

Pronto subiré algunos ejemplos de salida y también haré comparaciones entre los 3 modelos con el mismo prompt. También subiré la V1 a huggingface como hice con mi última versión, puedes encontrar mi cuenta de huggingface aquí: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Planes Futuros

(Completado) Voy a comenzar a trabajar en la versión 0.5, en vez de entrenar usando 50 libros, entrenaré usando idealmente 500-600. Ahora mismo estoy entrenando nanoGPT usando libros de 1800-1850 y específicamente de Londres. Hay algunos desafíos como asegurarme de que los libros que encuentre no estén actualizados ni tengan interpretaciones modernas, sino libros intactos publicados dentro del período de tiempo elegido.

Quiero entrenar un nuevo modelo (v1) con un corpus mucho más grande, tal vez 5-10 veces mayor que el que usé para v0.5. Mi objetivo es ver si puedo lograr que emerjan habilidades de razonamiento solo a través de Entrenamiento Temporal Selectivo, esta será una tarea más difícil y ni siquiera estoy completamente seguro de que sea posible debido a las limitaciones de los datos históricos. En las próximas semanas intentaré curar suficientes datos para un corpus de 5-10GB. Creo que si consigo datos limpios y de alta calidad y alquilo una GPU, habrá progreso.

# Cómo Usar Este Proyecto

Este proyecto se centra principalmente en curar datos históricos, prepararlos para el entrenamiento y construir un tokenizador. No voy a cubrir el proceso completo de entrenamiento de LLM, para eso consulta nanoGPT de Andrej Karpathy.

# Paso 1: Recopilar y Preparar Textos Históricos

Recolecta archivos .txt de libros de dominio público, documentos, etc. de tu período de tiempo elegido (por ejemplo, Londres 1800-1850)

Puedes usar download_texts_improved.py para descargar libros si lo necesitas.

Limpia los archivos de texto usando un script o elimina manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

prepare_dataset.py debería funcionar bien.

# Paso 2: Construir un Tokenizador Personalizado

Ejecuta train_tokenizer.py o train_tokenizer_hf.py en los datos limpios.
Esto te dará vocab.json y merges.txt
Estos archivos definen el vocabulario y las reglas de combinación para tu modelo

# Paso 3: Entrena Tu Modelo (nanoGPT) 

Consulta [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento.

Puedes entrenar un LLM diferente si lo deseas, pero yo utilicé nanoGPT 

# FAQ

## ¿Qué es el Entrenamiento Temporal Selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se seleccionan específicamente para que pertenezcan a un período histórico determinado. Se realiza para modelar el lenguaje y el conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual que tengo (v0.5) está entrenado exclusivamente con datos de 1800-1875, no está ajustado sino entrenado desde cero, lo que resulta en una salida que refleja el estilo lingüístico y contexto histórico de ese período.

## ¿Por qué no simplemente usar fine-tuning o LoRA?

Para este proyecto quiero crear un modelo de lenguaje que no esté influenciado por sesgos modernos. Si hago fine-tuning a algo como GPT-2, ya está preentrenado y esa información no se elimina. Si entreno desde cero, el modelo de lenguaje no fingirá ser antiguo, simplemente lo será. El objetivo de este proyecto ahora es crear algo que razone exclusivamente usando conocimiento de libros londinenses publicados entre 1800 y 1850.

## ¿Qué tipo de datos usaste para el entrenamiento?

Estoy usando libros, documentos legales, periódicos y otros escritos de Londres entre 1800 y 1850. La lista que enlacé tiene como 200, pero para el primer entrenamiento utilicé solo 50 archivos de unos ~187 MB. Puedes ver una lista de los documentos en:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## ¿Qué tamaño tienen los modelos?

V0: 16M Parámetros

V0.5: 123M Parámetros

V1: 700M Parámetros

# ¿Especificaciones de entrenamiento?

#V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

#V1

GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---