<div align="center">
<h1>Hacia una Navegación UAV Realista con Visión-Lenguaje: Plataforma, Benchmark y Metodología</h1>

<image src="./header.png" width="70%">

<a href="https://arxiv.org/abs/2410.07087"><img src='https://img.shields.io/badge/arXiv-TRAVEL: UAV VLN Platform, Benchmark, and Methodology-red' alt='Paper PDF'></a>
<a href='https://prince687028.github.io/Travel/'><img src='https://img.shields.io/badge/Project_Page-TRAVEL-green' alt='Project Page'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV'><img src='https://img.shields.io/badge/Dataset-TRAVEL-blue'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env'><img src='https://img.shields.io/badge/Env-TRAVEL-blue'></a>

</div>

## Contenidos

- [Introducción](#introduction)
- [Dependencias](#dependencies)
- [Preparación](#prepare-the-data)
- [Uso](#usage)
- [Citación](#paper)

## Noticias
- **2025-05-22:** Lanzamos UAV-Flow, el primer benchmark en el mundo real para aprendizaje por imitación de UAV condicionado por lenguaje. (página del proyecto: https://prince687028.github.io/UAV-Flow)
- **2025-01-25:** El artículo, la página del proyecto, código, datos, entornos y modelos han sido liberados.

# Introducción

Este trabajo presenta **_HACIA UNA NAVEGACIÓN UAV REALISTA CON VISIÓN-LENGUAJE: PLATAFORMA, BENCHMARK Y METODOLOGÍA_**. Introducimos una plataforma de simulación UAV, un benchmark realista de UAV VLN guiado por asistente, y un método basado en MLLM para abordar los desafíos en la navegación UAV realista con visión-lenguaje.

# Dependencias

### Crear entorno `llamauav`

```bash
conda create -n llamauav python=3.10 -y
conda activate llamauav
pip install torch==2.0.1 torchvision==0.15.2 torchaudio==2.0.2 --index-url https://download.pytorch.org/whl/cu118
```

## Instalar el modelo LLaMA-UAV

Puede seguir [LLaMA-UAV](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#install) para instalar las dependencias llm.

### Instalar otras dependencias listadas en el archivo de requisitos

```bash
pip install -r requirement.txt
```

Además, para asegurar la compatibilidad con la API de Python de AirSim, aplique la corrección mencionada en el [problema de AirSim](https://github.com/microsoft/AirSim/issues/3333#issuecomment-827894198)

# Preparación

## Datos

Para preparar el conjunto de datos, siga las instrucciones proporcionadas en la [Sección del Conjunto de Datos](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#dataset) para construir el conjunto de datos.

## Modelo

### GroundingDINO

Descargue el modelo GroundingDINO desde el enlace [groundingdino_swint_ogc.pth](https://huggingface.co/ShilongLiu/GroundingDINO/resolve/main/groundingdino_swint_ogc.pth), y coloque el archivo en el directorio `src/model_wrapper/utils/GroundingDINO/`.

### LLaMA-UAV

Para configurar el modelo, consulte la [Configuración del Modelo](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md) detallada.

## Entornos del simulador

Descargue los entornos del simulador para varios mapas desde [aquí](https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env).

La estructura de archivos de los entornos es la siguiente:

```
├── carla_town_envs
│   ├── Town01
│   ├── Town02
│   ├── Town03
│   ├── ...
├── closeloop_envs
│   ├── Engine
│   ├── ModularEuropean
│   ├── ModularEuropean.sh
│   ├── ModularPark
│   ├── ModularPark.sh
│   ├── ...
├── extra_envs
│   ├── BrushifyUrban
│   ├── BrushifyCountryRoads
│   ├── ...
```

# Uso

1. configurar el servidor del entorno del simulador

Antes de ejecutar las simulaciones, asegúrese de que el servidor del entorno AirSim esté configurado correctamente.

> Actualice las rutas ejecutables del entorno `env_exec_path_dict` relativas a `root_path` en `AirVLNSimulatorServerTool.py`.

```bash
cd airsim_plugin
python AirVLNSimulatorServerTool.py --port 30000 --root_path /path/to/your/envs
```

2. ejecutar simulación en bucle cerrado

Una vez que el servidor del simulador esté en funcionamiento, puede ejecutar el script dagger o de evaluación.

```bash
# Dagger NYC
bash scripts/dagger_NYC.sh
# Eval
bash scripts/eval.sh
bash scripts/metrics.sh
```

# Artículo

Si encuentra útil este proyecto, por favor considere citar: [artículo](https://arxiv.org/abs/2410.07087):

```
@misc{wang2024realisticuavvisionlanguagenavigation,
      title={Towards Realistic UAV Vision-Language Navigation: Platform, Benchmark, and Methodology},
      author={Xiangyu Wang and Donglin Yang and Ziqin Wang and Hohin Kwan and Jinyu Chen and Wenjun Wu and Hongsheng Li and Yue Liao and Si Liu},
      year={2024},
      eprint={2410.07087},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2410.07087},
}
```

# Agradecimientos

Este repositorio se basa en parte en los repositorios [AirVLN](https://github.com/AirVLN/AirVLN) y [LLaMA-VID](https://github.com/dvlab-research/LLaMA-VID).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---