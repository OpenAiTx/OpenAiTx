# TopicFM+: Mejorando la Precisión y Eficiencia del Emparejamiento de Características Asistido por Tema
    
Este código implementa [TopicFM+](https://arxiv.org/abs/2307.00485), que es una extensión de [TopicFM](https://arxiv.org/abs/2207.00328). Para la implementación de la versión anterior TopicFM, por favor consulte la rama `aaai23_ver`.


## Requisitos

Todos los experimentos en este artículo se implementan en un entorno Ubuntu 
con un controlador NVIDIA de al menos 430.64 y CUDA 10.1.

Primero, cree un entorno virtual con anaconda como sigue,

    conda create -n topicfm python=3.8 
    conda activate topicfm
    conda install pytorch==1.12.1 torchvision==0.13.1 cudatoolkit=11.3 -c pytorch
    pip install -r requirements.txt
    # usar pip para instalar cualquier paquete que falte

## Preparación de Datos

El método propuesto se entrena en el conjunto de datos MegaDepth y se evalúa en MegaDepth test, ScanNet, HPatches, Aachen Day and Night (v1.1), y el conjunto de datos InLoc.
Todos estos conjuntos de datos son grandes, por lo que no podemos incluirlos en este código. 
Las siguientes descripciones ayudan a descargar estos conjuntos de datos. 

### MegaDepth

Este conjunto de datos se usa tanto para entrenamiento como para evaluación (Li y Snavely 2018). 
Para usar este conjunto con nuestro código, por favor siga la [instrucción de LoFTR](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md).

### ScanNet 
Solo usamos 1500 pares de imágenes de ScanNet (Dai et al. 2017) para evaluación. 
Por favor descargue y prepare los [datos de prueba](https://drive.google.com/drive/folders/1DOcOPZb3-5cWxLqn256AhwUVjBPifhuf) de ScanNet
proporcionados por [LoFTR](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md).

## Entrenamiento

Para entrenar nuestro modelo, recomendamos usar tarjetas GPU tanto como sea posible, y cada GPU debe tener al menos 12GB.
En nuestras configuraciones, entrenamos en 4 GPUs, cada una de 12GB. 
Por favor configure su entorno de hardware en `scripts/reproduce_train/outdoor.sh`.
Luego ejecute este comando para comenzar el entrenamiento.

    bash scripts/reproduce_train/outdoor.sh <ruta al archivo de configuración de entrenamiento>
    # por ejemplo,
    bash scripts/reproduce_train/outdoor.sh configs/megadepth_train_topicfmfast.py

 Proveemos los modelos preentrenados, que fueron usados en el artículo ([TopicFM-fast](https://drive.google.com/file/d/1DACWdszttpiCZlk4aazhu0IDWvHkLPZf/view?usp=sharing), [TopicFM+](https://drive.google.com/file/d/1RTZJYrKQ593PBJTdxi9k5C4qZ5lSXnf0/view?usp=sharing))

## Evaluación

### MegaDepth (estimación de pose relativa)

    bash scripts/reproduce_test/outdoor.sh <ruta al archivo de configuración en la carpeta configs> <ruta al modelo preentrenado>
    # Por ejemplo, para evaluar TopicFM-fast 
    bash scripts/reproduce_test/outdoor.sh configs/megadepth_test_topicfmfast.py pretrained/topicfm_fast.ckpt

### ScanNet (estimación de pose relativa)

    bash scripts/reproduce_test/indoor.sh <ruta al archivo de configuración en la carpeta configs> <ruta al modelo preentrenado>

### HPatches, Aachen v1.1, InLoc

Para evaluar en estos conjuntos de datos, integramos nuestro código en la caja de herramientas de coincidencia de imágenes proporcionada por Patch2Pix.
El código actualizado y evaluaciones detalladas están disponibles [aquí](https://github.com/TruongKhang/image-matching-toolbox). 

### Desafío de Coincidencia de Imágenes 2023

Nuestro método TopicFM+ logró una alta clasificación (medalla de plata) en el Kaggle IMC2023 [aquí](https://www.kaggle.com/competitions/image-matching-challenge-2023/leaderboard?tab=public). 

### Comparación de eficiencia

La evaluación de eficiencia reportada en el artículo fue medida promediando el tiempo de ejecución de 1500 pares de imágenes del conjunto de datos de evaluación ScanNet.
El tamaño de imagen puede cambiarse en `configs/data/scannet_test_topicfmfast.py`

Calculamos los costos computacionales en GFLOPs y tiempos de ejecución en ms para LoFTR, MatchFormer, QuadTree y AspanFormer. Sin embargo, este proceso requirió una modificación menor del código de cada método individualmente. Por favor contáctenos si necesita evaluaciones para esos métodos.

Aquí proporcionamos la medición del tiempo de ejecución para nuestro método, TopicFM-fast

    python visualization.py --method topicfmv2 --dataset_name scannet --config_file configs/scannet_test_topicfmfast.py  --measure_time --no_viz

Reporte de tiempo de ejecución a la resolución de imagen de (640, 480) (medido en NVIDIA TITAN V 32GB de Mem.)


|   Modelo      |    640 x 480   |    1200 x 896    |
|:--------------|:--------------:|:----------------:|
| TopicFM-fast  |     56 ms      |      346 ms      |
| TopicFM+      |     90 ms      |      388 ms      |


## Citaciones
Si encuentra este código útil, por favor cite los siguientes trabajos:

    @article{giang2024topicfm+,
      title={Topicfm+: Mejorando la precisión y eficiencia del emparejamiento de características asistido por temas},
      author={Giang, Khang Truong y Song, Soohwan y Jo, Sungho},
      journal={IEEE Transactions on Image Processing},
      year={2024},
      publisher={IEEE}
    }

o

    @inproceedings{giang2023topicfm,
        title={TopicFM: Emparejamiento de características robusto e interpretable asistido por temas},
        author={Giang, Khang Truong y Song, Soohwan y Jo, Sungho},
        booktitle={Proceedings of the AAAI Conference on Artificial Intelligence},
        volume={37},
        number={2},
        pages={2447--2455},
        year={2023}
    }

## Agradecimientos
Este código está basado en [LoFTR](https://github.com/zju3dv/LoFTR). Agradecemos a los autores por su código fuente útil.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---