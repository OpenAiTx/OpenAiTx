<div align="center">
<h1>Towards Realistic UAV Vision-Language Navigation: Platform, Benchmark, and Methodology</h1>

<image src="./header.png" width="70%">

<a href="https://arxiv.org/abs/2410.07087"><img src='https://img.shields.io/badge/arXiv-TRAVEL: UAV VLN Platform, Benchmark, and Methodology-red' alt='Paper PDF'></a>
<a href='https://prince687028.github.io/Travel/'><img src='https://img.shields.io/badge/Project_Page-TRAVEL-green' alt='Project Page'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV'><img src='https://img.shields.io/badge/Dataset-TRAVEL-blue'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env'><img src='https://img.shields.io/badge/Env-TRAVEL-blue'></a>

</div>

## Contents

- [Introduction](#introduction)
- [Dependencies](#dependencies)
- [Preparation](#prepare-the-data)
- [Usage](#usage)
- [Citation](#paper)

## News
- **2025-05-22:** We release UAV-Flow, the first real-world benchmark for language-conditioned UAV imitation learning. (project page: https://prince687028.github.io/UAV-Flow)
- **2025-01-25:** Paper, project page, code, data, envs and models are all released.

# Introduction

This work presents **_TOWARDS REALISTIC UAV VISION-LANGUAGE NAVIGATION: PLATFORM, BENCHMARK, AND METHODOLOGY_**. We introduce a UAV simulation platform, an assistant-guided realistic UAV VLN benchmark, and an MLLM-based method to address the challenges in realistic UAV vision-language navigation.

# Dependencies

### Create `llamauav` environment

```bash
conda create -n llamauav python=3.10 -y
conda activate llamauav
pip install torch==2.0.1 torchvision==0.15.2 torchaudio==2.0.2 --index-url https://download.pytorch.org/whl/cu118
```

## Install LLaMA-UAV model

You can follow [LLaMA-UAV](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#install) to install the llm dependencies.

### Install other dependencies listed in the requirements file

```bash
pip install -r requirement.txt
```

Additionally, to ensure compatibility with the AirSim Python API, apply the fix mentioned in the [AirSim issue](https://github.com/microsoft/AirSim/issues/3333#issuecomment-827894198)

# Preparation

## Data

To prepare the dataset, please follow the instructions provided in the [Dataset Section](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#dataset) to construct the dataset.

## Model

### GroundingDINO

Download the GroundingDINO model from the link [groundingdino_swint_ogc.pth](https://huggingface.co/ShilongLiu/GroundingDINO/resolve/main/groundingdino_swint_ogc.pth), and place the file in the directory `src/model_wrapper/utils/GroundingDINO/`.

### LLaMA-UAV

To set up the model, refer to to the detailed [Model Setup](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md).

## Simulator environments

Download the simulator environments for various maps from [here](https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env).

The file directory of environments is as follows:

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

# Usage

1. setup simulator env server

Before running the simulations, ensure the AirSim environment server is properly configured.

> Update the env executable paths`env_exec_path_dict` relative to `root_path` in `AirVLNSimulatorServerTool.py`.

```bash
cd airsim_plugin
python AirVLNSimulatorServerTool.py --port 30000 --root_path /path/to/your/envs
```

2. run close-loop simulation

Once the simulator server is running, you can execute the dagger or evaluation script.

```bash
# Dagger NYC
bash scripts/dagger_NYC.sh
# Eval
bash scripts/eval.sh
bash scripts/metrics.sh
```

# Paper

If you find this project useful, please consider citing: [paper](https://arxiv.org/abs/2410.07087):

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

# Acknowledgement

This repository is partly based on [AirVLN](https://github.com/AirVLN/AirVLN) and [LLaMA-VID](https://github.com/dvlab-research/LLaMA-VID) repositories.
