<div align="center">
    
<h1><a href="https://ieeexplore.ieee.org/document/10591792">Change-Agent: Hacia una interpretación y análisis interactivo integral de cambios en teledetección</a></h1>

**[Chenyang Liu](https://chen-yang-liu.github.io/), [Keyan Chen](https://kyanchen.github.io), [Haotian Zhang](https://scholar.google.com/citations?user=c7uR6NUAAAAJ), [Zipeng Qi](https://scholar.google.com/citations?user=KhMtmBsAAAAJ), [Zhengxia Zou](https://scholar.google.com.hk/citations?hl=en&user=DzwoyZsAAAAJ), y [Zhenwei Shi*✉](https://scholar.google.com.hk/citations?hl=en&user=kNhFWQIAAAAJ)**

<div align="center">
  <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/Change_Agent.png" width="400"/>
</div>
</div>

## Compártenos una :star: si te interesa este repositorio

Implementación oficial en PyTorch del artículo: "**Change-Agent: Hacia una interpretación y análisis interactivo integral de cambios en teledetección**" en [[IEEE](https://ieeexplore.ieee.org/document/10591792)]  ***(Aceptado por IEEE TGRS 2024)***

## 🥳Noticias

- 2024-06: El código está **disponible**.
- 2024-03: El artículo está **disponible**.
- 🔥 Nuestra encuesta "**Modelos de Visión-Lenguaje Temporales en Teledetección: Una Revisión Integral": [Arxiv](https://arxiv.org/abs/2412.02573) || [Github](https://github.com/Chen-Yang-Liu/Awesome-RS-Temporal-VLM)** 🔥 

## Tabla de Contenidos
- [Conjunto de datos LEVIR-MCI](#LEVIR-MCI-dataset)
- [Entrenamiento del modelo MCI](#Training-of-the-multi-level-change-interpretation-model)
- [Construcción de Change-Agent](#Construction-of-Change-Agent)
- [Citación](#Citation)

## Conjunto de datos LEVIR-MCI 
- Descarga el conjunto de datos LEVIR_MCI: [LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main) (**¡Disponible Ahora!**).
- Este conjunto de datos es una extensión de nuestro previamente establecido [conjunto LEVIR-CC](https://github.com/Chen-Yang-Liu/RSICC). Contiene imágenes bi-temporales así como diversas máscaras de detección de cambio y oraciones descriptivas. Proporciona una base de datos crucial para explorar el aprendizaje multitarea para detección de cambios y generación de leyendas de cambio.
    <br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/dataset.png" width="800"/>
    </div>
    <br>
## Entrenamiento del modelo de interpretación de cambios a múltiples niveles
La visión general del modelo MCI:
<br>
    <div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/MCI_model.png" width="800"/>
    </div>
<br>

### Preparación
    
- **Instalación del entorno**:
    <details open>
    
    **Paso 1**: Cree un entorno virtual llamado `Multi_change_env` y actívelo.
    ```python
    conda create -n Multi_change_env python=3.9
    conda activate Multi_change_env
    ```
    
    **Paso 2**: Descargue o clone el repositorio.
    ```python
    git clone https://github.com/Chen-Yang-Liu/Change-Agent.git
    cd ./Change-Agent/Multi_change
    ```
    
    **Paso 3**: Instalar dependencias.
    ```python
    pip install -r requirements.txt
    ```
    </details>

- **Descargar conjunto de datos**:
  <details open>
      
  Enlace: [LEVIR-MCI](https://huggingface.co/datasets/lcybuaa/LEVIR-MCI/tree/main). La estructura de datos de LEVIR-MCI está organizada de la siguiente manera:

    ```
    ├─/DATA_PATH_ROOT/Levir-MCI-dataset/
            ├─LevirCCcaptions.json
            ├─images
                 ├─train
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─val
                 │  ├─A
                 │  ├─B
                 │  ├─label
                 ├─test
                 │  ├─A
                 │  ├─B
                 │  ├─label
    ```
    donde la carpeta ``A`` contiene imágenes de la pre-fase, la carpeta ``B`` contiene imágenes de la post-fase, y la carpeta ``label`` contiene las máscaras de detección de cambios.
    </details>

- **Extraer archivos de texto con las descripciones de cada par de imágenes en LEVIR-MCI**:

    ```
    python preprocess_data.py
    ```
    Después de eso, puedes encontrar algunos archivos generados en `./data/LEVIR_MCI/`. 

### Entrenamiento
Asegúrate de haber realizado la preparación de datos mencionada anteriormente. Luego, comienza el entrenamiento de la siguiente manera:
```python
python train.py --train_goal 2 --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --savepath ./models_ckpt/
```

### Evaluar
```python
python test.py --data_folder /DATA_PATH_ROOT/Levir-MCI-dataset/images --checkpoint {checkpoint_PATH}
```
Recomendamos entrenar el modelo 5 veces para obtener una puntuación promedio.

### Inferencia
Ejecute la inferencia para comenzar de la siguiente manera:
```python
python predict.py --imgA_path {imgA_path} --imgB_path {imgA_path} --mask_save_path ./CDmask.png
```
Puedes modificar ``--checkpoint`` de ``Change_Perception.define_args()`` en ``predict.py``. Luego puedes usar tu propio modelo, por supuesto, también puedes descargar nuestro modelo preentrenado ``MCI_model.pth`` aquí: [[Hugging face](https://huggingface.co/lcybuaa/Change-Agent/tree/main)]. Después de eso, colócalo en `./models_ckpt/`.



## Construcción de Change-Agent
<br>
<div align="center">
      <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/overview_agent.png" width="800"/>
</div>

- **Instalación del Agente**:
    ```python
    cd ./Change-Agent/lagent-main
    pip install -e .[all]
    ```
- **Ejecutar Agente**:

    entrar en la carpeta ``Multi_change``:
    ```python
    cd ./Change-Agent/Multi_change
    ```
    (1) Ejecutar demostración de Agent Cli:
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    python try_chat.py
    ```
        
    (2) Ejecutar la demostración web del agente:
    ```bash
    # You need to install streamlit first
    # pip install streamlit
    streamlit run react_web_demo.py
    ```
    <br>
    <div align="center">
          <img src="https://raw.githubusercontent.com/Chen-Yang-Liu/Change-Agent/main/resource/web.png"/>
    </div>

## Cita
Si encuentra este artículo útil para su investigación, por favor considere citar:
```
@ARTICLE{Liu_Change_Agent,
  author={Liu, Chenyang and Chen, Keyan and Zhang, Haotian and Qi, Zipeng and Zou, Zhengxia and Shi, Zhenwei},
  journal={IEEE Transactions on Geoscience and Remote Sensing}, 
  title={Change-Agent: Toward Interactive Comprehensive Remote Sensing Change Interpretation and Analysis}, 
  year={2024},
  volume={},
  number={},
  pages={1-1},
  keywords={Remote sensing;Feature extraction;Semantics;Transformers;Roads;Earth;Task analysis;Interactive Change-Agent;change captioning;change detection;multi-task learning;large language model},
  doi={10.1109/TGRS.2024.3425815}}

```
## Agradecimientos
Gracias a el siguiente repositorio:

[RSICCformer](https://github.com/Chen-Yang-Liu/RSICC); [Chg2Cap](https://github.com/ShizhenChang/Chg2Cap); [lagent](https://github.com/InternLM/lagent)

## Licencia
Este repositorio se distribuye bajo la [Licencia MIT](https://github.com/Chen-Yang-Liu/Change-Agent/blob/main/LICENSE.txt). El código puede usarse solo con fines académicos.

## Contáctanos
Si tienes alguna otra pregunta❓, por favor contáctanos a tiempo 👬



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---