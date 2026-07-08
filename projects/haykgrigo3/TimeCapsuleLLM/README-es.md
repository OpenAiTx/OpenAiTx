<div align="right">
  <details>
<summary>🌐 Idioma</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Un modelo de lenguaje entrenado **desde cero** exclusivamente con datos de ciertos lugares y períodos de tiempo para reducir el sesgo moderno y emular la voz, el vocabulario y la cosmovisión de la época.*

Imagina si un modelo de IA no solo pretendiera ser histórico, sino que realmente lo fuera.

v0 y v0.5 construidos sobre [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) Los scripts principales de entrenamiento y la arquitectura del modelo son de su autoría.

v1 construido sobre [Phi 1.5 de Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 construido sobre llamaforcausallm

[Enlace a Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Estado de la Investigación
Este proyecto fue iniciado y desarrollado de manera independiente.

Actualmente se lleva a cabo bajo supervisión académica, con una colaboración de investigación afiliada en Muhlenberg College y Georgia State University.

## Cita

Si utiliza este conjunto de datos o modelo en trabajos académicos, por favor cite:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Únete al Discord de Vintage LLM

Si te interesan los **modelos de lenguaje históricos**, **conjuntos de datos específicos de épocas**, o el futuro de proyectos como **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**, únete a la comunidad.

Usamos el servidor para debatir ideas, compartir avances y conectar con otros que construyen en este ámbito.

[Únete al Discord](https://discord.gg/JeWkk4z5)

## Patrocinadores

<div align="center">
  <a href="https://doloffer.com">
    <img src="https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/logo.png" width="500">
  </a>
</div>

¡Gracias a DolOffer por apoyar este proyecto!

DolOffer es una plataforma centrada en recomendaciones de productos digitales y compartir descuentos, ayudando a los usuarios a descubrir rápidamente herramientas, servicios y ofertas por tiempo limitado que valen la pena. La plataforma ofrece una variedad de servicios de suscripción populares, incluyendo YouTube Premium, Claude, ChatGPT Plus, Spotify y Apple Music, con precios desde solo el 30% del precio oficial o incluso menos.

Regístrate ahora usando este enlace exclusivo [doloffer](https://doloffer.com/en/) e ingresa el código de promoción AI8888 al recargar para disfrutar de un descuento adicional del 10%.

##  Comportamiento y Limitaciones del Modelo

### **v0**  

Las primeras pruebas muestran el modelo respondiendo con lenguaje y comportamiento de 1800. 
Ejemplo: Pregunta: "¿Quién es Henry?" y respondió "Conozco a ese hombre, no tengo negro, la tormenta."

![Salida de muestra de TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- No se mencionan conceptos modernos  
- Vocabulario mayormente acorde a la época  
- Las frases son mayormente incoherentes (esperado para datos de entrenamiento de ~187MB)

### **v0.5-london** 

Una mejora significativa respecto a v0.  
- Estilo de escritura victoriano, puntuación adecuada, frases mayormente gramaticales  
- Todavía hay una alta tasa de alucinación factual  
- El ruido de OCR (“Digitalizado por Google”) aún está presente en las salidas

![Salida de muestra de TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Primer modelo en recordar y conectar un evento histórico real con una figura concreta del conjunto de datos.

Ejemplo: Prompt: "Era el año de Nuestro Señor 1834" 

La salida: "Era el año de Nuestro Señor 1834 y las calles de Londres estaban llenas de protesta y petición. La causa, como muchos recordaron, no estaba ligada de manera privada, sino que habiéndose tomado el mismo día en el día de Lord Palmerston, el público recibirá una breve declaración de las dificultades bajo las cuales el día de la ley nos ha alcanzado. Es motivo de profundo pesar que los acontecimientos actuales en la historia del mundo sean claros y, en consecuencia, serán conocidos. No es cierto que los mismos hombres que primero se establecieron en el Evangelio en Jerusalén tuvieran un registro tan extenso e interesante de la prosperidad y la prosperidad" 

Al principio supuse que una protesta pudo haber ocurrido casualmente ese mismo año, pero mira esto: ![1834protesta](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Entrenado usando una muestra de 15GB del conjunto de datos de 90GB de v2.
Modelo entrenado solo hasta 10K pasos.

Hubo un problema con la tokenización que hace que la salida se vea así:

PROMPT:
¿Quién es Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corregido:

"¿Quién es Charles Dickens? ¿Acaso esa obra es más de su excelente e inspirador trabajo, en sus obras teatrales, en la granja de la Gran Compañía? ¿Qué me falta citar de Jack Pickett? ¿No sabes que eran una especie de galopar, o de aserrar sus pechos, o qué debía hacerse en el momento en que Jackson miraba por la ventana? ¿Cuál es el éxito de un inglés, y cuál su hijo no me ha estado descubriendo, mediante lo cual alcanzar tal peso? ¿Alguna vez hiciste un pasaje hacia el antiguo camino, o hacia una brisa de anclaje al pie de nuestro bote, que debes dejarnos? El hecho es que, ya sea que el viento se levantara desde la llanura el sábado por la noche o al mediodía, o hacia el norte, o de otra manera, nos veremos obligados a describir una barrera formidable, con los mismos efectos que la actual. En esta situación, al menos, no es exagerado decir que hemos dejado esa habitación. Creo que hay tres copias en el 'Quinientos veces', a las que referirse, como el primer número de nuestros lectores que deseen t[o]..."

### **v2mini-eval2-london**

Entrenado usando la misma muestra de 15GB utilizada para entrenar eval1.
El modelo se entrena nuevamente solo hasta 10K pasos.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Señor, — El siguiente caso es interesante para mí: — Estuve en Londres una quincena, y me afectó mucho un ataque de reumatismo. El primer ataque de reumatismo fue una semana antes de verte, y el segundo cuando te vi, y el tercero cuando te vi, y el tercero en el mismo tiempo. El segundo ataque de gota, sin embargo, no estuvo acompañado de ningún síntoma febril, pero sí de un aumento del flujo de orina, y con una descarga más copiosa de orina. El tercer ataque fue una hora después de verte, y fue sucedido por el retorno de un paroxismo de gota, y un regreso más rápido de la gota. El cuarto ataque también estuvo acompañado de fiebre, pero no siempre estuvo acompañado de síntomas febriles. El tercer ataque de gota fue una quincena después de haber estado enfermo, y el cuarto fue seguido de un paroxismo de gota. El cuarto ataque fue una quincena después de haber sido atacado, y estuvo acompañado de una sensación

### **v2-london**

Entrenado usando un conjunto de datos de 90GB (112GB tokenizado)
Entrenado hasta 182K pasos 

![Salida de muestra de TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![Salida de muestra de TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **¿Qué sigue?**

- Ha comenzado el desarrollo de TimeCapsuleLLM v3
- Ampliación del tamaño del conjunto de datos y cobertura geográfica
- Expansión más allá de Londres a otras ciudades

El trabajo se lleva a cabo en colaboración con investigadores de Muhlenberg College y Georgia State University. 


##  Conjuntos de datos

### **v2**

- 90GB (crudos) de textos de Londres 1800-1875
- 136,344 documentos
- El conjunto de datos tokenizado completo está disponible aquí: https://huggingface.co/datasets/postgrammar/london-llm-1800


### Estadísticas de Sesgo 
  ![Sesgo de pronombres](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Sesgo geográfico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Sesgo temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consulta el [informe de sesgo v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) para más información.


- 


## Cómo usar

Este proyecto se centra principalmente en la recopilación de datos históricos, su preparación para el entrenamiento y la construcción de un tokenizador. No voy a cubrir el proceso completo de entrenamiento de un LLM, para eso consulta nanoGPT de Andrej Karpathy.

### Paso 1: Reunir y preparar textos históricos 

- Reúne archivos .txt de libros de dominio público, documentos, etc. del periodo histórico elegido (por ejemplo, Londres 1800-1875) 
- Manténlos dentro de la ventana temporal/geográfica seleccionada  
- Limpia los archivos de texto usando un script o elimina manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

### Paso 2: Construir un tokenizador personalizado

- Ejecuta train_tokenizer.py o train_tokenizer_hf.py en los datos ya limpios.
- Esto te proporcionará vocab.json y merges.txt
- Estos archivos definen el vocabulario y las reglas de combinación para tu modelo

### Paso 3: Entrena tu modelo 

- Consulta [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento o la documentación de la arquitectura elegida.

# Preguntas frecuentes

## ¿Qué es el Entrenamiento Temporal Selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se seleccionan específicamente para pertenecer a un periodo histórico concreto. Se hace con el fin de modelar el lenguaje y el conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual que tengo (v0.5) está entrenado exclusivamente con datos de 1800-1875, no es un fine-tuning sino un entrenamiento desde cero, resultando en una salida que refleja el estilo lingüístico y contexto histórico de ese periodo.

## ¿Por qué no simplemente usar fine-tuning o LoRA?

Para este proyecto estoy intentando crear un modelo de lenguaje que no esté nublado por sesgos modernos. Si hago fine-tuning a algo como GPT-2, ya está preentrenado y esa información no desaparecerá. Si entreno desde cero, el modelo de lenguaje no fingirá ser antiguo, simplemente lo será. El objetivo de este proyecto en este momento es crear algo que pueda razonar exclusivamente usando conocimientos de libros de Londres publicados entre 1800 y 1875.

## ¿Qué tipo de datos usaste para el entrenamiento?

Estoy usando libros, documentos legales, periódicos y otros escritos de Londres entre 1800 y 1875. La lista que enlacé (para v0) tiene como 200, pero para el primer entrenamiento solo utilicé 50 archivos, aproximadamente ~187 MB. Puedes ver una lista de los documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tamaños de los conjuntos de datos:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (muestra de los 90GB de v2)
- v2: 90GB

## ¿Qué tan grandes son los modelos?

v0: 16M Parámetros

v0.5: 123M Parámetros

v1: 700M Parámetros

v2mini-eval1: 300M Parámetros

v2mini-eval2: 200M Parámetros

v2: 1.2B Parámetros

## Especificaciones de entrenamiento

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM alquilada

### v2mini-eval1/eval2
GPU: A100 SXM alquilada

### v2
GPU: H100 SXM alquilada

## Trabajo Relacionado

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  - LLM de 13B parámetros entrenado en 260B tokens de texto anteriores a 1930 con preguntas y respuestas. También existe una versión [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  - LLM de 1.4B parámetros entrenado en textos de 1800-1899 con preguntas y respuestas. También existe una versión de [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  - LLM de 340M parámetros entrenado en más de 28,000 textos entre 1837-1899 con preguntas y respuestas.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Una familia de LLMs de 4B parámetros basada en la arquitectura Qwen3 entrenada desde cero en 80B tokens de datos históricos hasta los cortes de conocimiento 1913,1929,1933,1939,1946.
 
- **[TypewriterLM](https://huggingface.co/typewriter-ai/typewriter-1913-7B-base)**
  - Un modelo de lenguaje histórico (LM) de 7.24B preentrenado exclusivamente en texto en inglés anterior a 1913. Creado por investigadores de la Universidad de Waterloo, Universidad de Adelaida, Universidad de Oxford y University College London. [Enlace al artículo](https://arxiv.org/abs/2606.02991)

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT es un ajuste fino de Mistral-Hermes 2 en 11,000 textos de la temprana modernidad en inglés, francés y latín, provenientes principalmente de EEBO y Gallica.

## Agradecimientos

Me gustaría agradecer al [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) por la supervisión académica, la orientación en el enfoque de la investigación y evaluación, y por la asistencia con el entrenamiento del tokenizador y la preparación del conjunto de datos para el lanzamiento de la v2. Sus comentarios y experiencia fueron fundamentales para refinar la presentación de este trabajo.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---