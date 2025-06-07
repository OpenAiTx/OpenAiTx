<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## Tabla de Contenidos

1. [Introducción](#1-introducción)
2. [Resumen del Modelo](#2-resumen-del-modelo)
3. [Descarga del Modelo](#3-descarga-del-modelo)
4. [Resultados de Evaluación](#4-resultados-de-evaluación)
5. [Sitio Web de Chat y Plataforma API](#5-sitio-web-de-chat-y-plataforma-api)
6. [Cómo Ejecutar Localmente](#6-cómo-ejecutar-localmente)
7. [Licencia](#7-licencia)
8. [Citación](#8-citación)
9. [Contacto](#9-contacto)


## 1. Introducción

Presentamos DeepSeek-V3, un potente modelo de lenguaje Mixture-of-Experts (MoE) con 671B parámetros totales y 37B activados por cada token.  
Para lograr una inferencia eficiente y un entrenamiento rentable, DeepSeek-V3 adopta las arquitecturas Multi-head Latent Attention (MLA) y DeepSeekMoE, las cuales fueron validadas exhaustivamente en DeepSeek-V2.  
Además, DeepSeek-V3 es pionero en una estrategia de balanceo de carga sin pérdida auxiliar y establece un objetivo de entrenamiento de predicción multi-token para un rendimiento superior.  
Preentrenamos DeepSeek-V3 en 14.8 billones de tokens diversos y de alta calidad, seguido de etapas de Fine-Tuning Supervisado y Aprendizaje por Refuerzo para aprovechar al máximo sus capacidades.  
Evaluaciones exhaustivas revelan que DeepSeek-V3 supera a otros modelos open-source y alcanza un rendimiento comparable a los modelos líderes de código cerrado.  
A pesar de su excelente rendimiento, DeepSeek-V3 requiere solo 2.788M horas de GPU H800 para su entrenamiento completo.  
Además, su proceso de entrenamiento es notablemente estable.  
Durante todo el proceso de entrenamiento, no experimentamos picos de pérdida irrecuperables ni realizamos retrocesos.  
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. Resumen del Modelo

---

**Arquitectura: Estrategia Innovadora de Balanceo de Carga y Objetivo de Entrenamiento**

- Sobre la arquitectura eficiente de DeepSeek-V2, desarrollamos una estrategia de balanceo de carga sin pérdida auxiliar, que minimiza la degradación de rendimiento que surge al incentivar el balanceo de carga.
-  Investigamos un objetivo de Predicción Multi-Token (MTP) y demostramos que es beneficioso para el rendimiento del modelo.  
    También puede usarse para decodificación especulativa para acelerar la inferencia. 

---

**Preentrenamiento: Hacia la Eficiencia Máxima de Entrenamiento**

- Diseñamos un marco de entrenamiento de precisión mixta FP8 y, por primera vez, validamos la viabilidad y efectividad del entrenamiento en FP8 en un modelo de escala extremadamente grande.  
- A través del co-diseño de algoritmos, marcos y hardware, superamos el cuello de botella de comunicación en el entrenamiento MoE entre nodos, logrando casi una superposición completa entre computación y comunicación.  
  Esto mejora significativamente nuestra eficiencia de entrenamiento y reduce los costes, permitiéndonos escalar aún más el tamaño del modelo sin gastos adicionales.  
- A un costo económico de solo 2.664M horas de GPU H800, completamos el preentrenamiento de DeepSeek-V3 en 14.8T tokens, produciendo el modelo base open-source más fuerte hasta la fecha. Las etapas subsiguientes tras el preentrenamiento requieren solo 0.1M horas GPU.

---

**Post-Entrenamiento: Destilación de Conocimientos desde DeepSeek-R1**

-   Introducimos una metodología innovadora para destilar capacidades de razonamiento desde el modelo Chain-of-Thought (CoT) largo, específicamente de uno de los modelos DeepSeek R1, hacia LLMs estándar, en particular DeepSeek-V3. Nuestra canalización incorpora elegantemente los patrones de verificación y reflexión de R1 en DeepSeek-V3 y mejora notablemente su rendimiento en razonamiento. Al mismo tiempo, también mantenemos el control sobre el estilo y la longitud de salida de DeepSeek-V3.

---

## 3. Descarga del Modelo

<div align="center">

| **Modelo** | **#Parámetros Totales** | **#Parámetros Activados** | **Longitud de Contexto** | **Descarga** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTA]
> El tamaño total de los modelos DeepSeek-V3 en Hugging Face es 685B, lo que incluye 671B de los pesos del Modelo Principal y 14B de los pesos del Módulo de Predicción Multi-Token (MTP).

Para garantizar un rendimiento óptimo y flexibilidad, nos hemos asociado con comunidades open-source y proveedores de hardware para proporcionar múltiples formas de ejecutar el modelo localmente. Para una guía paso a paso, consulte la Sección 6: [Cómo Ejecutar Localmente](#6-cómo-ejecutar-localmente).

Para desarrolladores interesados en profundizar, recomendamos explorar [README_WEIGHTS.md](./README_WEIGHTS.md) para detalles sobre los pesos del Modelo Principal y los Módulos de Predicción Multi-Token (MTP). Tenga en cuenta que el soporte para MTP está actualmente en desarrollo activo dentro de la comunidad, y agradecemos sus contribuciones y comentarios.

## 4. Resultados de Evaluación
### Modelo Base
#### Benchmarks Estándar

<div align="center">


|  | Benchmark (Métrica) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | Arquitectura | - | MoE | Denso | Denso | MoE |
| | # Parámetros Activados | - | 21B | 72B | 405B | 37B |
| | # Parámetros Totales | - | 236B | 72B | 405B | 671B |
| Inglés | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Prec.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Prec.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Prec.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Prec.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Prec.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Prec.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Prec.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Prec.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Prec.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Prec.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Prec.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Código | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Prec.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Prec.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Matemáticas | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Chino | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Prec.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Prec.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Prec.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Prec.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Multilingüe | MMMLU-no-Inglés (Prec.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTA]
> Los mejores resultados se muestran en negrita. Las puntuaciones con una diferencia no superior a 0.3 se consideran del mismo nivel. DeepSeek-V3 logra el mejor rendimiento en la mayoría de los benchmarks, especialmente en tareas de matemáticas y código.
> Para más detalles de evaluación, consulte nuestro paper. 

#### Ventana de Contexto
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

Resultados de evaluación en las pruebas ``Needle In A Haystack`` (NIAH). DeepSeek-V3 rinde bien en todas las longitudes de ventana de contexto hasta **128K**. 

### Modelo de Chat
#### Benchmarks Estándar (Modelos mayores a 67B)
<div align="center">

| | **Benchmark (Métrica)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | Arquitectura | MoE | MoE | Denso | Denso | - | - | MoE |
| | # Parámetros Activados | 21B | 21B | 72B | 405B | - | - | 37B |
| | # Parámetros Totales | 236B | 236B | 72B | 405B | - | - | 671B |
| Inglés | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Estricto) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correcto) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Prec.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Prec.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Código | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentil) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resuelto) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Prec.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Prec.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Matemáticas | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Chino | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correcto) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTA]
> Todos los modelos se evalúan en una configuración que limita la longitud de salida a 8K. Los benchmarks con menos de 1000 muestras se prueban varias veces usando diferentes temperaturas para obtener resultados robustos. DeepSeek-V3 es el modelo open-source con mejor rendimiento, y también muestra un rendimiento competitivo frente a modelos de código cerrado de vanguardia.


####  Evaluación de Generación Abierta

<div align="center">



| Modelo | Arena-Hard | AlpacaEval 2.0 |
|--------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTA]
> Evaluaciones de conversación abierta en inglés. Para AlpacaEval 2.0, usamos la tasa de victoria controlada por longitud como métrica.


## 5. Sitio Web de Chat y Plataforma API

Puede chatear con DeepSeek-V3 en el sitio web oficial de DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

También proporcionamos una API compatible con OpenAI en DeepSeek Platform: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Cómo Ejecutar Localmente

DeepSeek-V3 puede desplegarse localmente utilizando el siguiente hardware y software de la comunidad open-source:

1. **DeepSeek-Infer Demo**: Ofrecemos una demo simple y ligera para inferencia FP8 y BF16.
2. **SGLang**: Soporta completamente el modelo DeepSeek-V3 en modos de inferencia BF16 y FP8, con Predicción Multi-Token [próximamente](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: Permite inferencia eficiente FP8 y BF16 para despliegue local y en la nube.
4. **TensorRT-LLM**: Actualmente soporta inferencia BF16 y cuantización INT4/8, con soporte FP8 próximamente.
5. **vLLM**: Soporta el modelo DeepSeek-V3 en modos FP8 y BF16 para paralelismo tensorial y de pipeline.
6. **LightLLM**: Permite un despliegue eficiente en uno o varios nodos para FP8 y BF16.
7. **AMD GPU**: Permite ejecutar el modelo DeepSeek-V3 en GPUs AMD a través de SGLang en modos BF16 y FP8.
8. **Huawei Ascend NPU**: Permite ejecutar DeepSeek-V3 en dispositivos Huawei Ascend.

Dado que el entrenamiento FP8 es adoptado nativamente en nuestro framework, solo proporcionamos pesos FP8. Si requiere pesos BF16 para experimentación, puede usar el script de conversión proporcionado para realizar la transformación.

Aquí un ejemplo de conversión de pesos FP8 a BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /ruta/a/pesos_fp8 --output-bf16-hf-path /ruta/a/pesos_bf16
```

> [!NOTA]
> Hugging Face Transformers aún no está directamente soportado.

### 6.1 Inferencia con DeepSeek-Infer Demo (solo ejemplo)

#### Requisitos del Sistema

> [!NOTA] 
> Solo Linux con Python 3.10. Mac y Windows no están soportados.

Dependencias:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### Preparación de Pesos del Modelo y Código Demo

Primero, clone nuestro repositorio de DeepSeek-V3 en GitHub:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

Navegue a la carpeta `inference` e instale las dependencias listadas en `requirements.txt`. La forma más fácil es usar un gestor de paquetes como `conda` o `uv` para crear un nuevo entorno virtual e instalar las dependencias.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Descargue los pesos del modelo desde Hugging Face y colóquelos en la carpeta `/ruta/a/DeepSeek-V3`.

#### Conversión de Pesos del Modelo

Convierta los pesos del modelo Hugging Face a un formato específico:

```shell
python convert.py --hf-ckpt-path /ruta/a/DeepSeek-V3 --save-path /ruta/a/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### Ejecución

Ahora puede chatear con DeepSeek-V3:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /ruta/a/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

O inferencia en lote sobre un archivo dado:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /ruta/a/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 Inferencia con SGLang (recomendado)

[SGLang](https://github.com/sgl-project/sglang) soporta actualmente [optimizaciones MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache y Torch Compile, ofreciendo latencia y rendimiento de vanguardia entre los frameworks open-source.

En particular, [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) soporta completamente la ejecución de DeepSeek-V3 tanto en **GPUs NVIDIA como AMD**, haciéndolo una solución altamente versátil y robusta.

SGLang también soporta [paralelismo tensorial multi-nodo](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208), permitiéndole ejecutar el modelo en varias máquinas conectadas en red.

La Predicción Multi-Token (MTP) está en desarrollo, y el progreso puede seguirse en el [plan de optimización](https://github.com/sgl-project/sglang/issues/2591).

Aquí las instrucciones de lanzamiento del equipo SGLang: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 Inferencia con LMDeploy (recomendado)
[LMDeploy](https://github.com/InternLM/lmdeploy), un framework flexible y de alto rendimiento para inferencia y servicio de grandes modelos de lenguaje, ahora soporta DeepSeek-V3. Ofrece procesamiento offline en pipeline y despliegue online, integrándose perfectamente con flujos de trabajo basados en PyTorch.

Para instrucciones paso a paso sobre cómo ejecutar DeepSeek-V3 con LMDeploy, consulte: https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 Inferencia con TRT-LLM (recomendado)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) ahora soporta el modelo DeepSeek-V3, ofreciendo opciones de precisión como BF16 e INT4/INT8 solo-pesos. El soporte para FP8 está en desarrollo y será lanzado próximamente. Puede acceder a la rama personalizada de TRTLLM específicamente para DeepSeek-V3 aquí: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3. 


### 6.5 Inferencia con vLLM (recomendado)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 soporta inferencia DeepSeek-V3 para modos FP8 y BF16 tanto en GPUs NVIDIA como AMD. Además de técnicas estándar, vLLM ofrece _paralelismo de pipeline_ permitiéndole ejecutar el modelo en varias máquinas conectadas en red. Para una guía detallada, consulte las [instrucciones vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html). Puede seguir el [plan de mejora](https://github.com/vllm-project/vllm/issues/11539) también.

### 6.6 Inferencia con LightLLM (recomendado)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 soporta despliegue tensorial en máquina única y multi-máquina para DeepSeek-R1 (FP8/BF16) y proporciona despliegue de precisión mixta, con más modos de cuantización integrándose continuamente. Para más detalles, consulte las [instrucciones LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html). Además, LightLLM ofrece despliegue PD-disaggregation para DeepSeek-V2, y la implementación para DeepSeek-V3 está en desarrollo.

### 6.7 Inferencia Recomendada con GPUs AMD

En colaboración con el equipo AMD, hemos logrado soporte Día-Uno para GPUs AMD usando SGLang, con compatibilidad total para precisión FP8 y BF16. Para una guía detallada, consulte las [instrucciones SGLang](#63-inferencia-con-lmdeploy-recomendado).

### 6.8 Inferencia Recomendada con NPUs Huawei Ascend
El framework [MindIE](https://www.hiascend.com/en/software/mindie) de la comunidad Huawei Ascend ha adaptado exitosamente la versión BF16 de DeepSeek-V3. Para una guía paso a paso en NPUs Ascend, siga las [instrucciones aquí](https://modelers.cn/models/MindIE/deepseekv3).


## 7. Licencia
Este repositorio de código está licenciado bajo [Licencia MIT](LICENSE-CODE). El uso de los modelos DeepSeek-V3 Base/Chat está sujeto a la [Licencia del Modelo](LICENSE-MODEL). La serie DeepSeek-V3 (incluyendo Base y Chat) soporta uso comercial.

## 8. Citación
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. Contacto
Si tiene alguna pregunta, por favor abra un issue o contáctenos en [service@deepseek.com](service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---