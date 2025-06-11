# KVzip: Compresión Agnóstica de Caché KV con Reconstrucción de Contexto

[[Artículo](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## ¿Qué hay de nuevo?
- KVzip comprime la caché KV para soportar **diversas consultas futuras**.
- [Dependiente del contexto] Logra una **reducción de 3 a 4 veces en el tamaño de la caché KV** y una **disminución de 2 veces en la latencia de decodificación**, con una degradación mínima del rendimiento.
- [Independiente del contexto] Mejora la compresión KV a nivel de cabeza estilo [DuoAttention](https://github.com/mit-han-lab/duo-attention), utilizando sólo **unas pocas pasadas hacia adelante en menos de un minuto** para la optimización de la puntuación de importancia a nivel de cabeza (100 veces más rápido).
- Ejecutar demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Benchmark en configuración agnóstica a la consulta
- Tareas: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Modelo: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Instalación
Usamos CUDA 12.1 y Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Para usar la cuantización de [QServe](https://github.com/mit-han-lab/omniserve), por favor siga [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Dataset
- Por favor descargue el dataset SCBench preprocesado desde [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Si descargó los archivos descomprimidos, simplemente mueva la carpeta scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Inicio rápido
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "Este es mi perfil básico. Mi nombre es Kim y vivo en Seúl. Mi especialidad es ciencias de la computación."
queries = ["¿Cuál es mi nombre?", "¿Vivo en Seúl?"]

kv = model.prefill(context, load_score=False)  # precarga la caché KV + puntuación de importancia
kv.prune(ratio=0.3)  # ratio de compresión, elimina el 70% del KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # inferencia eficiente
    print(q, output)
```
- Los modelos soportados están listados en [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), incluyendo **LLaMA3, Qwen2.5/3, Gemma3**.
- Configure `load_score=True` para eliminar la sobrecarga de compresión. Esto habilita la eliminación de KV independiente del contexto, con un compromiso en la relación de compresión de `ratio=0.6`.
- Después de la generación, los pares KV correspondientes a las consultas y los tokens generados se eliminan selectivamente de la caché para un procesamiento posterior. Configure `update_cache=True` para habilitar inferencia multi-turno, reteniendo todo el historial de interacción durante la inferencia. 

## Perfilando memoria y tiempo de computación
### Eliminación dependiente del contexto
```bash
python -B test.py -m [nombre_modelo] -d [nombre_datos] --kv_type evict --ratio 0.3
```
- El código anterior también compara salidas generadas con cachés KV completas versus podadas.
- Para una prueba rápida, use `-d squad`. Para pruebas de contexto largo, use `-d scbench_kv`.
  - Nombres de datos disponibles: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Nombres de modelos disponibles: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), por ejemplo, llama3.1-8b, qwen2.5-7b (o Qwen/Qwen2.5-7B-Instruct-1M).
- Adaptamos el kernel CUDA de [AdaKV](https://github.com/FFY0/AdaKV/tree/main), soportando asignación de presupuesto no uniforme por cabeza.
  - Actualmente, nuestro código carece de un kernel optimizado para Gemma3 que usa caché KV estática, por lo que el código no produce ganancias reales de eficiencia. Sin embargo, el rendimiento del modelo aún puede evaluarse usando atención reducida con submuestreo KV (`--kv_type retain`).


### Eliminación independiente del contexto (sin sobrecarga de compresión en tiempo de ejecución)
- Use el flag `--level head` con `--ratio 0.6` (recomendado).
  - Eliminamos todos los pares KV de contexto asociados a una cabeza específica mientras retenemos los pares KV del prompt del sistema y la consulta.
  - Las puntuaciones de cabeza precomputadas están disponibles para LLaMA3.1-8B y Qwen2.5-7/14B en `./utils/head_score`.
- Para calcular las puntuaciones de cabeza para otros modelos:
  ```bash
  python -B test.py -m [nombre_modelo] -d scbench_qa_eng --save_head_score
  ```
  - Los resultados se guardarán en `./utils/head_score`.
  - Si el objetivo es una tarea de codificación, recomendamos ejecutar adicionalmente el comando con `-d scbench_repoqa`. Esto permite que el modelo use las puntuaciones máximas de cabeza tanto de lenguajes naturales como de codificación, lo que mejora el rendimiento.
- Estas puntuaciones pueden integrarse perfectamente con el motor de inferencia optimizado de [DuoAttention](https://github.com/mit-han-lab/duo-attention) reemplazando sus datos de puntuación de cabeza con los nuestros.


## Evaluación
- Para generar respuestas del modelo con ratios de compresión KV desde 0.1 hasta 1.0:
    ```bash
    python -B eval.py -m [nombre_modelo] -d [nombre_datos] --kv_type retain --num 100
    ``` 
  - Los resultados se guardarán en `./results/[nombre_datos]`.
  - Los datasets soportados están listados en `data/load.py`.
- Para calcular métricas de evaluación a partir de los resultados generados:
  ```bash
  python -B -m results.parse -m [nombre_modelo] -d [nombre_datos]
  ```

## Aplicación a nuevos modelos
Para integrar KVzip en un nuevo modelo, necesitará actualizar los siguientes archivos:
- `attention/attn.py`  
  Modifique la lógica del pase hacia adelante de atención según sea necesario. En ciertos casos, también podrían requerirse actualizaciones en kvcache.py y score.py.
- `model/monkeypatch.py`  
  Implemente el parcheo específico del modelo para la integración.
- `model/template.py`   
  Defina el prompt del sistema y las plantillas de formato de chat del modelo.


## Citas
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Licencia
Licencia MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---