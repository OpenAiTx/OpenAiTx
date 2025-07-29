
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

Imagina que un modelo de IA no solo pretende ser histórico, sino que realmente lo es.

Basado en [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT). Los scripts principales de entrenamiento y la arquitectura del modelo son obra suya.

# Objetivos del Proyecto

TimeCapsule LLM es un proyecto experimental que solo será entrenado con textos escritos durante ciertos periodos históricos. El objetivo es simular la visión del mundo y el lenguaje de épocas históricas específicas.

# Por qué el fine tuning no es suficiente

Si solo haces fine tuning a un modelo pre-entrenado, tu LLM seguirá conociendo conceptos modernos. Por supuesto, lograr cero sesgo moderno es difícil, pero quiero acercarme lo máximo posible a esto. Obtener ningún sesgo moderno requiere entrenar un modelo desde cero.

# Resultados esperados

Espero que, una vez terminado, este modelo no conozca conceptos modernos y no pueda razonar más allá de lo que ha sido entrenado. No debería reconocer conceptos/vocabulario modernos y espero que no alucine conocimientos actuales.

# Actualizaciones de Progreso

## 9 de julio de 2025

He establecido mi periodo de tiempo entre 1800-1850 y región: Londres

He reunido una lista de textos, libros y documentos

Hasta ahora he conseguido 50 archivos txt y pronto comenzaré a entrenar NanoGPT

Actualizaré esto mientras siga avanzando

## 13 de julio de 2025

Entrené nanoGPT con 187MB de datos de texto históricos.

## 15 de julio de 2025

Empecé a descargar textos para la segunda ronda de entrenamiento. Estoy obteniendo todo del Internet Archive y he ampliado el periodo a 1800-1875. Para conseguir una gama diversa de textos, puedes usar los filtros de búsqueda por ubicación de publicación, periodo y temas en Internet Archive.

![Filtros de Búsqueda](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julio de 2025

Descargué unos 500 archivos txt de Internet Archive y tras limpiarlos (solo borrando espacios en blanco, cabeceras de Gutenberg, etc.) tengo unos 500MB de datos. Es un conjunto de datos pequeño pero la última vez entrené con 187MB así que debería haber al menos alguna diferencia notable en la salida tras entrenar el segundo modelo. Espero que este modelo pueda al menos producir oraciones más coherentes que tengan sentido. No es una garantía, por supuesto, ya que sigue siendo un conjunto de datos muy pequeño, pero es más de lo que usé la vez pasada.

Esto debería poder hacerse con mi propio hardware, lo cual es bueno porque espero ver mejoras antes de pasar a un conjunto de datos más grande que requeriría alquilar una GPU. Pero no te preocupes, aún planeo alquilar una GPU pronto, pero antes quiero asegurarme de que mi conjunto de datos esté lo más curado y limpio posible. Uno de los problemas que tengo es la limpieza, muchos de estos txt tienen galimatías mezclados. Los scripts de limpieza que he usado funcionan pero no son 100% efectivos.

Voy a entrenar este conjunto de datos hoy y debería tomar unas 4-5 horas. Cuando termine y lo pruebe, daré actualizaciones. ¡Gracias de nuevo a quienes revisan mi proyecto, incluso me han pasado enlaces a recursos de OCR así que gracias! Espero que más personas prueben esto y experimenten con sus propios conjuntos de datos.

## 28 de julio de 2025

He subido la v0.5 a Hugging Face, [échale un vistazo](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) si quieres. Ahora puedes descargar mi repositorio y ejecutarlo localmente. Desafortunadamente nanoGPT no funciona de forma nativa con HuggingFace, así que tendrás que descargar y ejecutar el modelo localmente.

También comenzaré a curar datos para mi siguiente ronda de entrenamiento, creo que necesitaré quizá 5-10 veces más datos para lograr capacidades de razonamiento.

### Actualización de Entrenamiento

Comencé a entrenar con un corpus de 435MB (108 M tokens), va bastante bien por ahora. La pérdida de entrenamiento bajó de 10.9 a 4.9 en las primeras 2800 iteraciones. Espero que tome unas 8 o 9 horas completarlo. Publicaré otra actualización cuando termine.

## 17 de julio de 2025 2:13AM

El entrenamiento ha terminado para el segundo modelo, mi 4060 tardó unas 8 horas y 40 minutos (3,900 iter/h) para 33,000 iteraciones (5 épocas). La pérdida final de entrenamiento fue 3.73. Los resultados fueron sorprendentemente buenos, ahora realmente genera frases coherentes al estilo del siglo XIX.

# Comportamiento y Limitaciones del Modelo V0

Las primeras pruebas muestran que el modelo responde con lenguaje y comportamiento de los años 1800. Por ejemplo, lo estimulé con "Who art Henry?" y respondió "I know that man, I have did not a black, the storm." y sí, esa frase no tiene sentido pero el LLM reconoce que pregunto por una persona.

![Salida de Ejemplo de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

No hay mención de conceptos modernos, las salidas contienen mayormente palabras y frases propias de los años 1800.

Todavía necesita mucho trabajo, entrenar con 187MB no te dará un modelo que produzca texto con razonamiento complejo.

Por ahora produce oraciones que carecen de una estructura completa y en general no tienen sentido, pero esto es normal para el tamaño de entrenamiento.

# Comportamiento y Limitaciones del Modelo V0.5

Esto es una buena mejora comparado con el último modelo. El estilo de escritura y vocabulario es victoriano y casi cada frase es gramaticalmente correcta con la puntuación adecuada. Y nuevamente, esto se entrena desde cero, por lo que se apega a temas de los años 1800.

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Hay muchas alucinaciones fácticas. Muchos (como el 100%) de los detalles (fechas, eventos, figuras históricas) son inventados. Además, las oraciones realmente no tienen conexión entre sí, a veces tal vez 2 frases se relacionan pero más allá de eso no. Otro problema es que a veces aparece un pie de página errante de “Digitized by Google”, así que la próxima vez que entrene tengo que asegurarme de limpiar bien los textos. En general, estoy muy feliz con los resultados, todavía está lejos de ser un LLM pero definitivamente es un generador de frases.

Estoy aprendiendo mucho y empezaré a averiguar qué debo mejorar en las próximas semanas. ¡Pronto subiré archivos!

# Planes Futuros

(Completado) Voy a empezar a trabajar en la versión 0.5, en vez de entrenar usando 50 libros, entrenaré usando idealmente 500-600. Ahora mismo estoy entrenando nanoGPT usando libros de 1800-1850 y específicamente de Londres. Hay algunos desafíos como asegurarme de que los libros que encuentro no estén actualizados o tengan interpretaciones modernas, sino libros intactos publicados dentro de mi periodo elegido.

Quiero entrenar un nuevo modelo (v1) con un corpus mucho más grande, tal vez 5-10 veces mayor que el que usé para v0.5. Mi objetivo es ver si puedo lograr que emerjan habilidades de razonamiento solo con Entrenamiento Temporal Selectivo, será una tarea más difícil y ni siquiera estoy seguro de si es posible debido a las limitaciones de datos históricos. En las próximas semanas trataré de reunir suficientes datos para un corpus de 5-10GB. Creo que si consigo datos limpios y de alta calidad y alquilo una GPU, habrá progreso.

# Cómo Usar Este Proyecto

Este proyecto se centra principalmente en recopilar datos históricos, prepararlos para el entrenamiento y construir un tokenizador. No voy a cubrir el proceso completo de entrenamiento de un LLM, para eso consulta nanoGPT por Andrej Karpathy.

# Paso 1: Recopilar y Preparar Textos Históricos

Reúne archivos .txt de libros de dominio público, documentos, etc. del periodo que elijas (por ejemplo, Londres 1800-1850)

Puedes usar download_texts_improved.py para descargar libros si lo necesitas.

Limpia los archivos de texto usando un script o elimina manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

prepare_dataset.py debería funcionar bien.

# Paso 2: Construir un Tokenizador Personalizado

Ejecuta train_tokenizer.py o train_tokenizer_hf.py en los datos limpios.
Esto te dará vocab.json y merges.txt

Estos archivos definen el vocabulario y las reglas de combinación para tu modelo

# Paso 3: Entrena Tu Modelo (nanoGPT)

Consulta [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento.

Puedes entrenar otro LLM si lo deseas, pero yo usé nanoGPT

# FAQ

## ¿Qué es el Entrenamiento Temporal Selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se seleccionan específicamente para que pertenezcan a un periodo histórico concreto. Se hace para modelar el lenguaje y conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual que tengo (v0.5) está entrenado con datos exclusivamente de 1800-1875, no está afinado sino entrenado desde cero, resultando en salidas que reflejan el estilo lingüístico y contexto histórico de ese periodo.

## ¿Por qué no usar simplemente fine-tuning o LoRA?

Para este proyecto estoy intentando crear un modelo de lenguaje sin sesgo moderno. Si afino algo como GPT-2, ya está pre-entrenado y esa información no desaparecerá. Si entreno desde cero el modelo no fingirá ser antiguo, simplemente lo será. El objetivo de este proyecto por ahora es crear algo que razone exclusivamente usando conocimientos de libros de Londres publicados entre 1800 y 1850.

## ¿Qué tipo de datos usaste para entrenar?

Estoy usando libros, documentos legales, periódicos y otros escritos de Londres entre 1800 y 1850. La lista que enlacé tiene como 200 pero para el primer entrenamiento solo usé 50 archivos de unos ~187 MB. Puedes ver la lista de documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## ¿Qué tamaño tiene el modelo Versión 0?

Este modelo es muy pequeño por ahora, solo lo hago por diversión y siguiendo una regla estricta de no usar fuentes modernas. Tiene casi 16 millones de parámetros pero voy a empezar a recopilar más textos antiguos para iniciar otro entrenamiento de modelo. Daré actualizaciones en el camino.

## ¿Especificaciones de Entrenamiento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---