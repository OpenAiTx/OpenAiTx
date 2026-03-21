<div align="center">
<h1>Vers une navigation vision-langage réaliste pour UAV : Plateforme, Benchmark et Méthodologie</h1>

<image src="./header.png" width="70%">

<a href="https://arxiv.org/abs/2410.07087"><img src='https://img.shields.io/badge/arXiv-TRAVEL: UAV VLN Platform, Benchmark, and Methodology-red' alt='Paper PDF'></a>
<a href='https://prince687028.github.io/Travel/'><img src='https://img.shields.io/badge/Project_Page-TRAVEL-green' alt='Project Page'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV'><img src='https://img.shields.io/badge/Dataset-TRAVEL-blue'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env'><img src='https://img.shields.io/badge/Env-TRAVEL-blue'></a>

</div>

## Contenu

- [Introduction](#introduction)
- [Dépendances](#dependencies)
- [Préparation](#prepare-the-data)
- [Utilisation](#usage)
- [Citation](#paper)

## Actualités
- **2025-05-22 :** Nous publions UAV-Flow, le premier benchmark réel pour l'apprentissage par imitation UAV conditionné par le langage. (page du projet : https://prince687028.github.io/UAV-Flow)
- **2025-01-25 :** Article, page du projet, code, données, environnements et modèles sont tous publiés.

# Introduction

Ce travail présente **_VERS UNE NAVIGATION VISION-LANGAGE RÉALISTE POUR UAV : PLATEFORME, BENCHMARK ET MÉTHODOLOGIE_**. Nous introduisons une plateforme de simulation UAV, un benchmark VLN UAV réaliste guidé par un assistant, et une méthode basée sur MLLM pour relever les défis de la navigation vision-langage réaliste pour UAV.

# Dépendances

### Créer l'environnement `llamauav`

```bash
conda create -n llamauav python=3.10 -y
conda activate llamauav
pip install torch==2.0.1 torchvision==0.15.2 torchaudio==2.0.2 --index-url https://download.pytorch.org/whl/cu118
```

## Installer le modèle LLaMA-UAV

Vous pouvez suivre [LLaMA-UAV](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#install) pour installer les dépendances llm.

### Installer les autres dépendances listées dans le fichier requirements

```bash
pip install -r requirement.txt
```

De plus, pour garantir la compatibilité avec l'API Python AirSim, appliquez la correction mentionnée dans le [problème AirSim](https://github.com/microsoft/AirSim/issues/3333#issuecomment-827894198)

# Préparation

## Données

Pour préparer le jeu de données, veuillez suivre les instructions fournies dans la [Section Jeu de Données](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#dataset) afin de construire le jeu de données.

## Modèle

### GroundingDINO

Téléchargez le modèle GroundingDINO depuis le lien [groundingdino_swint_ogc.pth](https://huggingface.co/ShilongLiu/GroundingDINO/resolve/main/groundingdino_swint_ogc.pth), et placez le fichier dans le répertoire `src/model_wrapper/utils/GroundingDINO/`.

### LLaMA-UAV

Pour configurer le modèle, référez-vous à la [Configuration du Modèle](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md) détaillée.

## Environnements du simulateur

Téléchargez les environnements du simulateur pour diverses cartes depuis [ici](https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env).

La structure des fichiers des environnements est la suivante :

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

# Utilisation

1. configurer le serveur d'environnement du simulateur

Avant d'exécuter les simulations, assurez-vous que le serveur d'environnement AirSim est correctement configuré.

> Mettez à jour les chemins des exécutables d'environnement `env_exec_path_dict` relatifs à `root_path` dans `AirVLNSimulatorServerTool.py`.

```bash
cd airsim_plugin
python AirVLNSimulatorServerTool.py --port 30000 --root_path /path/to/your/envs
```
2. exécuter une simulation en boucle fermée

Une fois que le serveur du simulateur est en fonctionnement, vous pouvez exécuter le script dagger ou d’évaluation.


```bash
# Dagger NYC
bash scripts/dagger_NYC.sh
# Eval
bash scripts/eval.sh
bash scripts/metrics.sh
```

# Article

Si vous trouvez ce projet utile, veuillez envisager de citer : [article](https://arxiv.org/abs/2410.07087) :

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

# Remerciements

Ce dépôt est en partie basé sur les dépôts [AirVLN](https://github.com/AirVLN/AirVLN) et [LLaMA-VID](https://github.com/dvlab-research/LLaMA-VID).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---