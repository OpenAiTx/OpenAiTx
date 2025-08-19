
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


##  Comportamiento del modelo y limitaciones

### **v0**  

Las primeras pruebas muestran al modelo respondiendo con lenguaje y comportamiento de los años 1800.
Ejemplo: Prompt: "¿Quién es Henry?" y respondió "Conozco a ese hombre, no he hecho un negro, la tormenta."

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Sin mención de conceptos modernos  
- Mayormente vocabulario preciso de la época  
- Las oraciones son en su mayoría incoherentes (lo esperado para ~187MB de datos de entrenamiento)

### **v0.5** 

Una mejora significativa sobre v0.  
- Estilo de escritura victoriano, puntuación adecuada, oraciones mayormente gramaticales  
- Aún alta tasa de alucinación factual  
- Ruido de OCR (“Digitized by Google”) todavía presente en las salidas

![Salida de muestra de TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primer modelo en recordar y conectar un evento histórico real con una figura real del conjunto de datos.

Ejemplo: Prompt: "Era el año de nuestro Señor 1834"

La salida: "Era el año de nuestro Señor 1834 y las calles de Londres estaban llenas de protesta y petición. La causa, como muchos relataron, no estaba ligada a lo privado, sino que se había tomado el mismo día en el día de Lord Palmerston, el público recibirá una breve declaración de las dificultades bajo las cuales el día de la ley nos ha alcanzado. Es motivo de profundo pesar, que los presentes acontecimientos en la historia del mundo sean claros, y por consiguiente serán conocidos. No es cierto que los mismos hombres que primero se asentaron en el Evangelio en Jerusalén debieran tener un registro tan extenso e interesante de la prosperidad y prosperidad"

Al principio asumí que una protesta pudo haber ocurrido casualmente ese mismo año pero mira esto: ![1834protesta](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Por qué esto es importante:

Este es el primer ejemplo de uno de mis modelos conectando un año con un evento histórico real y una persona real vinculada a ese evento (Lord Palmerston). Los modelos anteriores (v0 y v0.5) podían imitar estilos de escritura del siglo XIX pero siempre alucinaban eventos, personas y hechos. Esto demuestra que el modelo está comenzando a recordar cosas del conjunto de datos

## Próximos planes
- Hay cerca de 175,000 textos publicados en Londres entre 1800-1875 en Internet Archive 
- Planeo expandir el corpus y limpiarlo más para mejorar las capacidades de razonamiento
- Ampliando a diferentes regiones y períodos para crear modelos históricos más variados


## Cómo usar

Este proyecto se enfoca principalmente en curar datos históricos, prepararlos para el entrenamiento y construir un tokenizador. No voy a cubrir el proceso completo de entrenamiento de LLM, para eso consulta nanoGPT de Andrej Karpathy.

### Paso 1: Recolecta y prepara textos históricos 

- Recopila archivos .txt de libros, documentos, etc. de dominio público de tu período elegido (por ejemplo, Londres 1800-1850) 
- Mantenlos dentro de tu ventana de tiempo/lugar elegida  
- Limpia los archivos de texto usando un script o elimina manualmente encabezados/pies de página de Project Gutenberg, anotaciones modernas o errores de OCR.

### Paso 2: Construye un tokenizador personalizado

- Ejecuta train_tokenizer.py o train_tokenizer_hf.py en los datos limpios.
- Esto te dará vocab.json y merges.txt
- Estos archivos definen el vocabulario y reglas de combinación para tu modelo

### Paso 3: Entrena tu modelo 

- Consulta [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para el proceso de entrenamiento o la documentación de la arquitectura que elijas.

# FAQ

## ¿Qué es el Entrenamiento Temporal Selectivo?

El Entrenamiento Temporal Selectivo (STT) es una metodología de aprendizaje automático donde todos los datos de entrenamiento se seleccionan específicamente para que pertenezcan a un período histórico determinado. Se realiza para modelar el lenguaje y el conocimiento de esa época sin influencia de conceptos modernos. Por ejemplo, el modelo actual que tengo (v0.5) está entrenado exclusivamente con datos de 1800-1875, no está ajustado finamente sino entrenado desde cero, lo que resulta en una salida que refleja el estilo lingüístico y el contexto histórico de ese período.

## ¿Por qué no usar fine-tuning o LoRA?

Para este proyecto intento crear un modelo de lenguaje libre de sesgos modernos. Si hago fine-tuning a algo como GPT-2, ya está preentrenado y esa información no desaparece. Si entreno desde cero el modelo no va a pretender ser antiguo, simplemente lo será. El objetivo de este proyecto por ahora es crear algo que pueda razonar exclusivamente usando conocimiento de libros de Londres publicados entre 1800 y 1875.

## ¿Qué tipo de datos usaste para el entrenamiento?

Estoy utilizando libros, documentos legales, periódicos y otros escritos de Londres entre 1800–1875. La lista que enlacé (para v0) tiene como 200, pero para el primer entrenamiento solo usé 50 archivos, aproximadamente ~187 MB. Puedes ver una lista de los documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt


Tamaños de los conjuntos de datos:
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---