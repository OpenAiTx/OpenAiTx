<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (próximamente)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (próximamente)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Un modelo de lenguaje entrenado **desde cero** exclusivamente con datos de ciertos lugares y períodos de tiempo para reducir el sesgo moderno y emular la voz, vocabulario y visión del mundo de la época.*

Imagina si un modelo de IA no solo fingiera ser histórico, sino que realmente lo fuera.

v0 y v0.5 construidos sobre [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) Los scripts de entrenamiento principales y la arquitectura del modelo son obra suya. 

v1 construido sobre [Phi 1.5 de Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Enlace a Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Comportamiento del Modelo y Limitaciones

### **v0**  

Las primeras indicaciones muestran que el modelo responde con lenguaje y comportamiento de los años 1800.
Ejemplo: Indicación: "Who art Henry?" y respondió "I know that man, I have did not a black, the storm."

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Sin mención de conceptos modernos  
- Vocabulario mayormente preciso para la época  
- Las oraciones son en su mayoría incoherentes (esperado para ~187MB de datos de entrenamiento)

### **v0.5** 

Una mejora significativa respecto a v0.  
- Estilo de escritura victoriano, puntuación adecuada, oraciones mayormente gramaticales  
- Aún alta tasa de alucinación factual  
- Ruido de OCR (“Digitized by Google”) aún presente en las salidas

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primer modelo que recuerda y conecta un evento histórico real con una figura auténtica del conjunto de datos.

Ejemplo: Indicación: "It was the year of our Lord 1834"

La salida: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

Al principio supuse que una protesta podría haber ocurrido casualmente ese mismo año, pero mira esto: ![1834protesta](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Entrenado usando una muestra de 15GB del conjunto de datos de 90GB de v2.

Modelo entrenado solo hasta 10K pasos.

Hubo un problema con la tokenización que hace que la salida se vea así:

INDICACIÓN:
¿Quién es Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corregido:

"¿Quién es Charles Dickens? ¿Hace ese trabajo más de su excelente agitación, en sus obras, en la gran granja de la Compañía? ¿Qué tengo aún que citar de Jack Pickett? ¿No sabes que eran una especie de galopar, o de serrar sus pechos, o qué se debía hacer en la época en que Jackson miraba por la ventana? ¿Cuál es el éxito de un inglés, y cuál su hijo no ha descubierto para mí, por lo que ha de lograr tal peso? ¿Alguna vez has hecho un pasaje hacia el viejo camino, o hacia una brisa de ancla al pie de nuestro bote, que debes dejarnos? El hecho es que, tanto si el viento se levanta desde la llanura el sábado por la noche o al mediodía, o hacia el norte, o de otra manera, nos veremos obligados a describir una barrera formidable, con los mismos efectos que los actuales. En esta situación, al menos, no es exagerado decir que hemos dejado esa habitación. Creo que hay tres copias en el 'Quinientos veces', a las que se debe referir, como el primer número de nuestros lectores que deseen t[o]..."

### **v2mini-eval2**

Entrenado usando la misma muestra de 15GB utilizada para entrenar eval1.
El modelo se entrena nuevamente solo hasta 10K pasos.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Señor, — El siguiente caso me resulta interesante: — Estuve en Londres dos semanas y me afectó mucho un ataque de reumatismo. El primer ataque de reumatismo fue una semana antes de verlo, y el segundo cuando lo vi, y el tercero cuando lo vi, y el tercero en el mismo tiempo. El segundo ataque de gota, sin embargo, no estuvo acompañado de ningún síntoma febril, pero sí de un aumento en el flujo de orina, y una descarga más copiosa de orina. El tercer ataque fue una hora después de verlo, y fue seguido por el regreso de un paroxismo de gota, y un retorno más rápido de la gota. El cuarto ataque también estuvo acompañado de fiebre, pero no siempre con síntomas febriles. El tercer ataque de gota fue dos semanas después de que usted estuvo enfermo, y el cuarto fue seguido por un paroxismo de gota. El cuarto ataque fue dos semanas después de que usted fue atacado, y estuvo acompañado por una sensación


##  Conjuntos de datos

### **v2**

- 90GB de textos londinenses de 1800-1875
- 136,344 documentos
- El total de 90GB aún no está disponible ya que no se ha tokenizado, pero puede encontrar una muestra de 15GB aquí: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Estadísticas de sesgo 
  ![Sesgo de pronombres](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Sesgo geográfico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Sesgo temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consulte el [informe de sesgo v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) para más información.


## Cómo usar

Este proyecto se centra principalmente en la curación de datos históricos, prepararlos para entrenamiento y construir un tokenizador. No voy a cubrir el proceso completo de entrenamiento LLM, para eso consulte nanoGPT de Andrej Karpathy.

### Paso 1: Recolectar y preparar textos históricos 

- Reúna archivos .txt de libros de dominio público, documentos, etc., de su periodo elegido (por ejemplo, Londres 1800-1850)

- Manténgalos dentro de la ventana de tiempo/lugar que haya elegido  
- Limpie los archivos de texto usando un script o elimine manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

### Paso 2: Construya un Tokenizador Personalizado

- Ejecute train_tokenizer.py o train_tokenizer_hf.py en los datos limpios.
- Esto le dará vocab.json y merges.txt
- Estos archivos definen el vocabulario y las reglas de combinación para su modelo

### Paso 3: Entrene Su Modelo 

- Consulte [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento o la documentación de la arquitectura elegida.

# FAQ

## ¿Qué es el Entrenamiento Temporal Selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se curan específicamente para que pertenezcan a un periodo histórico específico. Se hace para modelar el lenguaje y el conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual que tengo (v0.5) está entrenado exclusivamente con datos de 1800-1875, no está afinado sino entrenado desde cero, lo que resulta en una salida que refleja el estilo lingüístico y el contexto histórico de ese periodo.

## ¿Por qué no simplemente usar fine-tuning o LoRA?

Para este proyecto estoy intentando crear un modelo de lenguaje que no esté contaminado por sesgos modernos. Si hago fine-tuning a algo como GPT-2, ya está pre-entrenado y esa información no desaparecerá. Si entreno desde cero, el modelo de lenguaje no fingirá ser antiguo, simplemente lo será. El objetivo de este proyecto ahora mismo es crear algo que pueda razonar exclusivamente usando conocimiento de libros de Londres publicados entre 1800 y 1875.

## ¿Qué tipo de datos utilizó para el entrenamiento?

Estoy usando libros, documentos legales, periódicos y otros escritos de Londres entre 1800 y 1875. La lista que enlacé (para v0) tiene como 200, pero para el primer entrenamiento solo usé 50 archivos de aproximadamente ~187 MB. Puede ver una lista de los documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tamaños de los conjuntos de datos:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB

## ¿Qué tamaño tienen los modelos?

v0: 16M Parámetros

v0.5 123M Parámetros

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented





























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---