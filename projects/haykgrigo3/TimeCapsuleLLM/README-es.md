
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

*Un modelo de lenguaje entrenado **desde cero** exclusivamente con datos de ciertos lugares y períodos de tiempo para reducir el sesgo moderno y emular la voz, el vocabulario y la visión del mundo de la época.*

Imagina si un modelo de IA no solo pretendiera ser histórico, sino que realmente lo fuera.

v0 y v0.5 construidos sobre [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) Los scripts principales de entrenamiento y la arquitectura del modelo son de su autoría. 

v1 construido sobre [Phi 1.5 de Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Enlace a Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Comportamiento y Limitaciones del Modelo

### **v0**  

Las primeras pruebas muestran que el modelo responde con lenguaje y comportamiento de los años 1800.  
Ejemplo: Prompt: "Who art Henry?" y respondió "I know that man, I have did not a black, the storm."  

![Salida de ejemplo de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Sin mención de conceptos modernos  
- Vocabulario mayormente preciso de la época  
- Las oraciones son mayormente incoherentes (esperado por ~187MB de datos de entrenamiento)

### **v0.5** 

Una mejora significativa sobre v0.  
- Estilo victoriano de escritura, puntuación adecuada, oraciones mayormente gramaticales  
- Aún alta tasa de alucinación factual  
- Ruido de OCR (“Digitized by Google”) aún presente en las salidas

![Salida de ejemplo de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primer modelo en recordar y conectar un evento histórico real con una figura real del conjunto de datos.

Ejemplo: Prompt: "It was the year of our Lord 1834"  

La salida: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"  

Al principio asumí que una protesta podría haber ocurrido casualmente ese mismo año, pero mira esto: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Por qué esto importa:

Este es el primer ejemplo de uno de mis modelos conectando un año tanto con un evento histórico real como con una persona real vinculada a ese evento (Lord Palmerston). Los modelos anteriores (v0 y v0.5) podían imitar los estilos de escritura del siglo XIX pero siempre alucinaban eventos, personas y hechos. Esto muestra que el modelo está comenzando a recordar cosas del conjunto de datos.


## Planes futuros

- Hay casi 175,000 textos publicados en Londres de 1800 a 1875 en Internet Archive
- Planeo expandir el corpus y limpiarlo más para mejorar las habilidades de razonamiento
- Expandirse a diferentes regiones y períodos de tiempo para modelos históricos más variados

## Cómo usar

Este proyecto se centra principalmente en la curación de datos históricos, preparándolos para el entrenamiento y construyendo un tokenizador. No voy a cubrir el proceso completo de entrenamiento de LLM, para eso remítase a nanoGPT de Andrej Karpathy.

### Paso 1: Reunir y preparar textos históricos

- Recoge archivos .txt de libros de dominio público, documentos, etc., de tu período elegido (por ejemplo, Londres 1800-1850)
- Mantén los textos dentro de tu ventana temporal/geográfica seleccionada
- Limpia los archivos de texto usando un script o elimina manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

### Paso 2: Construir un tokenizador personalizado

- Ejecuta train_tokenizer.py o train_tokenizer_hf.py en los datos limpios.
- Esto te dará vocab.json y merges.txt
- Estos archivos definen el vocabulario y las reglas de combinación para tu modelo

### Paso 3: Entrena tu modelo

- Consulta [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento o la documentación de la arquitectura que elijas.

# FAQ

## ¿Qué es el entrenamiento temporal selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se seleccionan específicamente para caer dentro de un período histórico definido. Se realiza para modelar el lenguaje y conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual (v0.5) está entrenado exclusivamente con datos de 1800-1875, no está ajustado finamente sino entrenado desde cero, lo que resulta en una salida que refleja el estilo lingüístico y contexto histórico de ese período.

## ¿Por qué no simplemente usar ajuste fino o LoRA?

Para este proyecto estoy tratando de crear un modelo de lenguaje sin sesgos modernos. Si ajusto finamente algo como GPT-2, ya está preentrenado y esa información no se elimina. Si entreno desde cero, el modelo de lenguaje no simulará ser antiguo, simplemente lo será. El objetivo de este proyecto actualmente es crear algo que pueda razonar exclusivamente usando conocimientos de libros publicados en Londres entre 1800 y 1875.

## ¿Qué tipo de datos usaste para el entrenamiento?


Estoy utilizando libros, documentos legales, periódicos y otros escritos de Londres entre 1800 y 1875. La lista que enlacé (para v0) tiene como 200, pero para el primer entrenamiento solo usé 50 archivos de aproximadamente ~187 MB. Puedes ver una lista de los documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tamaños del conjunto de datos:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## ¿Qué tan grandes son los modelos?

V0: 16M Parámetros

V0.5 123M Parámetros

V1: 700M Parámetros

# ¿Especificaciones de entrenamiento?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 alquilada















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---