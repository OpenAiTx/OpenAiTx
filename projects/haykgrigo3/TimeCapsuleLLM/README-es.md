<div align="right">
  <details>
<summary>🌐 Idioma</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Un modelo de lenguaje entrenado **desde cero** exclusivamente con datos de ciertos lugares y períodos de tiempo para reducir el sesgo moderno y emular la voz, el vocabulario y la cosmovisión de la época.*

Imagina si un modelo de IA no solo pretendiera ser histórico, sino que realmente lo fuera.

v0 y v0.5 construidos sobre [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) Los scripts principales de entrenamiento y la arquitectura del modelo son su trabajo.

v1 construido sobre [Phi 1.5 de Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 construido sobre llamaforcausallm

[Enlace a Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Estado de la Investigación
Este proyecto fue iniciado y desarrollado de forma independiente.

Actualmente se lleva a cabo bajo supervisión académica, con una colaboración de investigación afiliada en Muhlenberg College.

## Citación

Si utilizas este conjunto de datos o modelo en trabajos académicos, por favor cita:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Comportamiento y Limitaciones del Modelo

### **v0**  

Las primeras indicaciones muestran que el modelo responde con lenguaje y comportamiento de 1800. 
Ejemplo: Indicación: "¿Quién es Henry?" y respondió "Conozco a ese hombre, no he hecho un negro, la tormenta." 

![Salida de muestra TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Sin mención de conceptos modernos  
- Vocabulario mayormente acorde a la época  
- Las oraciones son en su mayoría incoherentes (esperado para ~187MB de datos de entrenamiento)

### **v0.5** 

Una mejora significativa sobre v0.  
- Estilo de escritura victoriano, puntuación adecuada, oraciones mayormente gramaticales  
- Aún alta tasa de alucinación factual  
- Ruido OCR (“Digitalizado por Google”) aún presente en las salidas

![Salida de muestra TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primer modelo en recordar y conectar un evento histórico real con una figura real del conjunto de datos.

Ejemplo: Indicación: "Era el año de Nuestro Señor 1834" 

La salida: "Era el año de Nuestro Señor 1834 y las calles de Londres estaban llenas de protestas y peticiones. La causa, como muchos contaron, no estaba ligada en privado, sino que había ocupado el mismo día en el día de Lord Palmerston, el público recibirá una breve declaración de las dificultades bajo las cuales el día de la ley nos ha alcanzado. Es motivo de profundo pesar que los presentes acontecimientos en la historia del mundo sean claros y, en consecuencia, serán conocidos. No es cierto que los mismos hombres que primero se establecieron en el Evangelio en Jerusalén tengan un registro tan extenso e interesante de la prosperidad y prosperidad" 

Al principio asumí que una protesta pudo haber ocurrido casualmente ese año, pero mira esto: ![1834protesta](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Entrenado usando una muestra de 15GB del conjunto de datos de 90GB de v2.
Modelo entrenado solo hasta 10K pasos.

Hubo un problema con la tokenización que hace que la salida se vea así:

¿Quién es Charles Dickens?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corregido:

"¿Quién es Charles Dickens? ¿Acaso esa obra agita más de su excelente talento, en sus obras teatrales, en la gran granja de la Compañía? ¿Qué me falta citar de Jack Pickett? ¿No sabes que ellos eran una especie de galopantes, o que aserraban sus pechos, o qué se debía hacer en el momento en que Jackson miraba por la ventana? ¿Cuál es el éxito de un inglés, y cuál su hijo no me ha descubierto aún, para lograr tal peso? ¿Alguna vez atravesaste el antiguo camino, o echaste un ancla-brisa al pie de nuestro bote, que debes dejarnos? El hecho es que, ya sea que el viento se levante desde la llanura el sábado por la noche o al mediodía, o hasta el norte, o de otro modo, nos veremos obligados a describir una barrera formidable, con los mismos efectos que la actual. En esta situación, al menos, no es exagerado decir que hemos dejado esa habitación. Creo que hay tres copias en el 'Quinientos Veces,' a las que referirse, como el primer número de nuestros lectores que deseen t[o]..."

### **v2mini-eval2**

Entrenado usando la misma muestra de 15GB usada para entrenar eval1.
El modelo se entrenó nuevamente solo hasta 10K pasos.

INDICACIÓN: Charles Darwin

Charles DarwinECCEMACY. Señor, — El siguiente caso me resulta interesante: — Estuve en Londres una quincena, y me afectó mucho un ataque de reumatismo. El primer ataque de reumatismo fue una semana antes de verlo, el segundo cuando lo vi, y el tercero cuando lo vi, y el tercero en el mismo tiempo. El segundo ataque de gota, sin embargo, no fue acompañado de síntomas febriles, pero sí de un aumento del flujo urinario, y con una descarga de orina más copiosa. El tercer ataque fue una hora después de verlo, y fue sucedido por el regreso de un paroxismo de gota, y un retorno más rápido de la gota. El cuarto ataque también estuvo acompañado de fiebre, pero no siempre se acompañó de síntomas febriles. El tercer ataque de gota fue una quincena después de que usted estuvo enfermo, y el cuarto fue seguido por un paroxismo de gota. El cuarto ataque fue una quincena después de que usted fuera atacado, y estuvo acompañado de una sensación

### **v2**

Entrenado usando un conjunto de datos de 90GB (112GB tokenizado)
Entrenado hasta 182K pasos 

![Salida de muestra TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![Salida de muestra TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Conjuntos de datos

### **v2**

- 90GB (crudo) de textos de Londres de 1800-1875
- 136,344 documentos
- El conjunto de datos tokenizado completo está disponible aquí: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Estadísticas de sesgo 
  ![Sesgo de pronombre](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Sesgo geográfico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Sesgo temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consulte el [informe de sesgo de v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) para más información.


## Cómo usar

Este proyecto se centra principalmente en recopilar datos históricos, prepararlos para el entrenamiento y construir un tokenizador. No voy a cubrir el proceso completo de entrenamiento de LLM, para eso consulta nanoGPT de Andrej Karpathy.

### Paso 1: Reunir y preparar textos históricos

- Recoge archivos .txt de libros de dominio público, documentos, etc. de tu período elegido (por ejemplo, Londres 1800-1850)
- Manténlos dentro de la ventana de tiempo/lugar que hayas elegido
- Limpia los archivos de texto usando un script o elimina manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

### Paso 2: Construir un tokenizador personalizado

- Ejecuta train_tokenizer.py o train_tokenizer_hf.py en los datos limpios.
- Esto te dará vocab.json y merges.txt
- Estos archivos definen el vocabulario y reglas de combinación para tu modelo

### Paso 3: Entrena tu modelo

- Consulta [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento o la documentación de la arquitectura que elijas.

# Preguntas frecuentes

## ¿Qué es el entrenamiento temporal selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se curan específicamente para que pertenezcan a un período histórico concreto. Se realiza para modelar el lenguaje y el conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual que tengo (v0.5) está entrenado exclusivamente con datos de 1800-1875, no está afinado sino entrenado desde cero, lo que resulta en una salida que refleja el estilo lingüístico y el contexto histórico de ese período.

## ¿Por qué no usar simplemente fine-tuning o LoRA?

Para este proyecto estoy intentando crear un modelo de lenguaje que esté libre de sesgos modernos. Si hago fine-tuning a algo como GPT-2, ya está preentrenado y esa información no desaparecerá. Si lo entreno desde cero, el modelo de lenguaje no fingirá ser antiguo, simplemente lo será. El objetivo actual de este proyecto es crear algo que pueda razonar exclusivamente usando conocimiento de libros de Londres publicados entre 1800 y 1875.

## ¿Qué tipo de datos usaste para el entrenamiento?

Estoy usando libros, documentos legales, periódicos y otros escritos de Londres entre 1800 y 1875. La lista que enlacé (para v0) tiene como 200, pero para el primer entrenamiento solo usé 50 archivos, alrededor de ~187 MB. Puedes ver una lista de los documentos aquí:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tamaños de dataset:
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

## ¿Especificaciones de entrenamiento?

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

## Agradecimientos

Me gustaría agradecer a [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) por la supervisión académica, orientación en el enfoque de investigación y evaluación, y por la asistencia en el entrenamiento del tokenizador y preparación del conjunto de datos para la versión v2. Sus comentarios y experiencia fueron fundamentales para perfeccionar la presentación de este trabajo.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---