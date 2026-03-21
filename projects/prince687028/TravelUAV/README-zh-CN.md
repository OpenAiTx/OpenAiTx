<div align="center">
<h1>迈向真实的无人机视觉-语言导航：平台、基准和方法论</h1>

<image src="./header.png" width="70%">

<a href="https://arxiv.org/abs/2410.07087"><img src='https://img.shields.io/badge/arXiv-TRAVEL: UAV VLN Platform, Benchmark, and Methodology-red' alt='论文 PDF'></a>
<a href='https://prince687028.github.io/Travel/'><img src='https://img.shields.io/badge/Project_Page-TRAVEL-green' alt='项目页面'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV'><img src='https://img.shields.io/badge/Dataset-TRAVEL-blue'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env'><img src='https://img.shields.io/badge/Env-TRAVEL-blue'></a>

</div>

## 目录

- [介绍](#introduction)
- [依赖](#dependencies)
- [准备](#prepare-the-data)
- [使用](#usage)
- [引用](#paper)

## 最新动态
- **2025-05-22:** 我们发布了 UAV-Flow，这是第一个面向语言条件的无人机模仿学习真实世界基准。（项目页面：https://prince687028.github.io/UAV-Flow）
- **2025-01-25:** 论文、项目页面、代码、数据、环境和模型全部发布。

# 介绍

本工作展示了 **_迈向真实的无人机视觉-语言导航：平台、基准和方法论_**。我们介绍了一个无人机仿真平台，一个助理引导的真实无人机视觉语言导航基准，以及一种基于多模态大模型（MLLM）的方法，以解决真实无人机视觉语言导航中的挑战。

# 依赖

### 创建 `llamauav` 环境

```bash
conda create -n llamauav python=3.10 -y
conda activate llamauav
pip install torch==2.0.1 torchvision==0.15.2 torchaudio==2.0.2 --index-url https://download.pytorch.org/whl/cu118
```

## 安装 LLaMA-UAV 模型

您可以按照 [LLaMA-UAV](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#install) 来安装 llm 依赖项。

### 安装 requirements 文件中列出的其他依赖项

```bash
pip install -r requirement.txt
```
另外，为确保与 AirSim Python API 的兼容性，请应用[AirSim issue](https://github.com/microsoft/AirSim/issues/3333#issuecomment-827894198)中提到的修复。

# 准备工作

## 数据

请按照[数据集部分](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#dataset)中的说明准备数据集。

## 模型

### GroundingDINO

从链接[groundingdino_swint_ogc.pth](https://huggingface.co/ShilongLiu/GroundingDINO/resolve/main/groundingdino_swint_ogc.pth)下载 GroundingDINO 模型，并将文件放置在目录 `src/model_wrapper/utils/GroundingDINO/` 中。

### LLaMA-UAV

有关模型的搭建，请参考详细的[模型设置](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md)。

## 模拟器环境

从[这里](https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env)下载不同地图的模拟器环境。

环境文件目录结构如下：


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

# 使用方法

1. 设置模拟器环境服务器

在运行仿真之前，确保AirSim环境服务器已正确配置。

> 更新`AirVLNSimulatorServerTool.py`中相对于`root_path`的环境可执行文件路径`env_exec_path_dict`。

```bash
cd airsim_plugin
python AirVLNSimulatorServerTool.py --port 30000 --root_path /path/to/your/envs
```

2. 运行闭环仿真

模拟器服务器启动后，您可以执行 dagger 或评估脚本。

```bash
# Dagger NYC
bash scripts/dagger_NYC.sh
# Eval
bash scripts/eval.sh
bash scripts/metrics.sh
```

# 论文

如果您觉得本项目有用，请考虑引用： [论文](https://arxiv.org/abs/2410.07087)：

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

# 致谢

本仓库部分基于 [AirVLN](https://github.com/AirVLN/AirVLN) 和 [LLaMA-VID](https://github.com/dvlab-research/LLaMA-VID) 仓库。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---