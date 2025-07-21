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

Imagina si un modelo de IA no solo pretendiera ser histórico sino que realmente lo fuera.

Construido sobre [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) Los scripts de entrenamiento principales y la arquitectura del modelo son su trabajo.

# Objetivos del Proyecto

TimeCapsule LLM es un proyecto experimental que solo será entrenado con textos escritos durante ciertos periodos históricos. El objetivo es simular la visión del mundo y el lenguaje de épocas históricas específicas.

# Por qué el ajuste fino no es suficiente

Si solo ajustas un modelo preentrenado, tu LLM todavía conocerá conceptos modernos. Por supuesto, lograr cero sesgo moderno es difícil, pero quiero acercarme lo más posible a esto. Eliminar el sesgo moderno requiere entrenar un modelo desde cero.

# Resultados esperados

Con suerte, cuando esté terminado, este modelo no conocerá conceptos modernos y no podrá razonar más allá de lo que ha sido entrenado. No debería reconocer conceptos/vocabulario modernos y espero que no alucine conocimiento moderno.

# Actualizaciones de Progreso

## 9 de julio de 2025

He establecido mi periodo de tiempo en 1800-1850 y región: Londres

He reunido una lista de textos, libros, documentos

Hasta ahora he conseguido 50 en archivos txt y pronto comenzaré a entrenar NanoGPT

Actualizaré esto siempre que haya progreso

## 13 de julio de 2025

Entrené nanoGPT con 187 MB de datos históricos en texto.

## 15 de julio de 2025

Comencé a descargar textos para la segunda ronda de entrenamiento. Estoy obteniendo todo del Internet Archive y he ampliado el periodo de tiempo a 1800-1875. Para obtener una gama diversa de textos, puedes usar filtros de tema y búsqueda por ubicación de publicación, periodo de tiempo y temas en Internet Archive.

![Filtros de Búsqueda](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julio de 2025

Descargué alrededor de 500 archivos txt de Internet Archive y después de limpiarlos (solo eliminando espacios en blanco, encabezados de Gutenberg, etc.) tengo alrededor de 500 MB de datos. Es un conjunto de datos pequeño pero la última vez entrené con 187 MB así que debería haber al menos alguna diferencia notable en la salida después de entrenar el segundo modelo. Espero que este modelo pueda al menos producir oraciones más coherentes que tengan algo de sentido. Por supuesto, no es una garantía ya que sigue siendo un conjunto de datos muy pequeño, pero es más de lo que usé la vez pasada.

Esto debería ser posible con mi propio hardware, lo cual es bueno porque espero ver algún tipo de mejora antes de pasar a un conjunto de datos más grande que requeriría alquilar una GPU. Pero no te preocupes, todavía planeo alquilar una GPU pronto, pero antes de hacerlo quiero asegurarme de que mi conjunto de datos esté lo más curado y limpio posible. Uno de los problemas que tengo es la limpieza, muchos de estos archivos txt tienen textos sin sentido mezclados. Los scripts que he usado para limpiar funcionan pero no son 100% efectivos.

Entrenaré este conjunto de datos hoy y debería tomar alrededor de 4-5 horas. Una vez que termine y lo pruebe, daré actualizaciones. ¡Gracias de nuevo a todos los que están viendo mi proyecto, incluso ha habido personas que me han enviado enlaces a recursos de OCR así que gracias! Espero que más gente pruebe esto y experimente con sus propios conjuntos de datos.

### Actualización de Entrenamiento

Comencé a entrenar con un corpus de 435 MB (108 M de tokens), va bastante bien hasta ahora. La pérdida de entrenamiento bajó de 10.9 a 4.9 en las primeras 2800 iteraciones. Espero que tome alrededor de 8 o 9 horas completar. Publicaré otra actualización una vez que termine.

## 17 de julio de 2025 2:13AM

El entrenamiento terminó para el segundo modelo, a mi 4060 le tomó alrededor de 8 horas y 40 minutos (3,900 iteraciones/hora) para 33,000 iteraciones (5 épocas). La pérdida final de entrenamiento fue de 3.73. Las salidas fueron sorprendentemente buenas, ahora realmente genera oraciones coherentes al estilo del siglo XIX.

# Comportamiento y Limitaciones del Modelo V0

Las primeras pruebas muestran que el modelo responde con lenguaje y comportamiento de los años 1800. Por ejemplo, lo probé con "Who art Henry?" y respondió "I know that man, I have did not a black, the storm." y sí, esa oración no tiene sentido pero el LLM está reconociendo que le estoy preguntando por una persona.

![Salida de Muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

No hay mención de conceptos modernos, las salidas contienen principalmente palabras y frases de los años 1800.

Aún necesita mucho trabajo, entrenar con 187 MB no te dará un modelo que produzca texto con razonamiento complejo.

Ahora mismo produce oraciones que carecen de estructura completa y en general simplemente no tienen sentido, pero esto es normal para este tamaño de entrenamiento.

# Comportamiento y Limitaciones del Modelo V0.5

Esta es una mejora notable en comparación con el modelo anterior. El estilo de escritura y el vocabulario son victorianos y casi todas las oraciones son gramaticalmente correctas y con la puntuación adecuada. Y de nuevo, este modelo está entrenado desde cero, por lo que se ciñe a temas de los años 1800.

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Hay muchas alucinaciones factuales. Muchas (como el 100%) de los detalles (fechas, eventos, figuras históricas) son inventados. Además, las oraciones realmente no tienen conexiones entre sí, a veces tal vez 2 oraciones se relacionan, pero más allá de eso no lo hacen. Otro problema es que a veces aparece un pie de página errante de “Digitized by Google”, así que la próxima vez que entrene realmente tengo que asegurarme de limpiar bien los textos. En general, estoy muy contento con los resultados; todavía no es un LLM pero definitivamente es un generador de oraciones.

Estoy aprendiendo mucho y en las próximas semanas empezaré a averiguar qué necesito mejorar. ¡Pronto subiré archivos!

# Planes Futuros

(Completado) Voy a empezar a trabajar en la versión 0.5, en lugar de entrenar usando 50 libros, entrenaré usando idealmente 500-600. Ahora mismo estoy entrenando nanoGPT usando libros de 1800-1850 y específicamente de Londres. Hay algunos desafíos, como asegurarme de que los libros que encuentro no hayan sido actualizados o tengan interpretaciones modernas, sino libros intactos publicados dentro del periodo de tiempo que elegí.

Quiero entrenar un nuevo modelo (v1) con un corpus mucho más grande, tal vez de 5 a 10 veces mayor que el que usé para v0.5. Mi objetivo es ver si puedo lograr que emerjan habilidades de razonamiento sólo a partir del Entrenamiento Temporal Selectivo, será una tarea más difícil y ni siquiera estoy seguro de si es posible debido a las limitaciones de datos históricos. En las próximas semanas intentaré recopilar suficiente información para un corpus de 5-10GB. Creo que si puedo obtener datos limpios y de alta calidad y alquilar una GPU, habrá avances.

# Cómo Usar Este Proyecto

Este proyecto se centra principalmente en recopilar datos históricos, prepararlos para el entrenamiento y construir un tokenizador. No voy a cubrir todo el proceso de entrenamiento de un LLM; para eso, consulta nanoGPT de Andrej Karpathy.

# Paso 1: Reunir y Preparar Textos Históricos

Reúne archivos .txt de libros de dominio público, documentos, etc. del periodo de tiempo elegido (por ejemplo, Londres 1800-1850)

Puedes usar download_texts_improved.py para descargar libros si lo necesitas.

Limpia los archivos de texto usando un script o elimina manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

prepare_dataset.py debería funcionar bien.

# Paso 2: Construir un Tokenizador Personalizado

Ejecuta train_tokenizer.py o train_tokenizer_hf.py sobre los datos limpios.
Esto te dará vocab.json y merges.txt

Estos archivos definen el vocabulario y las reglas de fusión para tu modelo

# Paso 3: Entrena Tu Modelo (nanoGPT)

Consulta [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento.

Puedes entrenar un LLM diferente si quieres, pero yo usé nanoGPT

# Preguntas Frecuentes

## ¿Qué es el Entrenamiento Temporal Selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento son seleccionados específicamente para que caigan dentro de un periodo histórico concreto. Se hace para modelar el lenguaje y el conocimiento de esa época sin la influencia de conceptos modernos. Por ejemplo, el modelo que tengo ahora (v0.5) está entrenado con datos exclusivamente de 1800-1875; no está afinado, sino entrenado desde cero, lo que da como resultado una salida que refleja el estilo lingüístico y el contexto histórico de ese periodo.

## ¿Por qué no simplemente usar fine-tuning o LoRA?

Para este proyecto intento crear un modelo de lenguaje sin sesgos modernos. Si hago fine-tuning a algo como GPT-2, ya está preentrenado y esa información no se elimina. Si entreno desde cero, el modelo de lenguaje no fingirá ser antiguo, simplemente lo será. El objetivo de este proyecto ahora es crear algo que pueda razonar exclusivamente usando conocimiento de libros de Londres publicados entre 1800 y 1850.

## ¿Qué tipo de datos usaste para el entrenamiento?

Estoy usando libros, documentos legales, periódicos y otros escritos de Londres entre 1800 y 1850. La lista que enlacé tiene como 200, pero para el primer entrenamiento sólo usé 50 archivos de unos ~187 MB. Puedes ver una lista de los documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## ¿Qué tamaño tiene el modelo Versión 0?

Este modelo es muy pequeño por ahora, sólo lo hago por diversión y siguiendo una estricta regla de entrenamiento sin fuentes modernas. Tiene casi 16 millones de parámetros, pero voy a empezar a recopilar más textos antiguos para iniciar otro entrenamiento de modelo. Iré dando actualizaciones a medida que avance.

## ¿Especificaciones de entrenamiento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---