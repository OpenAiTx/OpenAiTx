<div align="center">
<h1>현실적인 UAV 비전-언어 내비게이션을 향하여: 플랫폼, 벤치마크 및 방법론</h1>

<image src="./header.png" width="70%">

<a href="https://arxiv.org/abs/2410.07087"><img src='https://img.shields.io/badge/arXiv-TRAVEL: UAV VLN Platform, Benchmark, and Methodology-red' alt='Paper PDF'></a>
<a href='https://prince687028.github.io/Travel/'><img src='https://img.shields.io/badge/Project_Page-TRAVEL-green' alt='Project Page'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV'><img src='https://img.shields.io/badge/Dataset-TRAVEL-blue'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env'><img src='https://img.shields.io/badge/Env-TRAVEL-blue'></a>

</div>

## 목차

- [소개](#introduction)
- [종속성](#dependencies)
- [준비](#prepare-the-data)
- [사용법](#usage)
- [인용](#paper)

## 소식
- **2025-05-22:** 언어 조건 기반 UAV 모방 학습을 위한 최초의 실제 벤치마크 UAV-Flow를 공개합니다. (프로젝트 페이지: https://prince687028.github.io/UAV-Flow)
- **2025-01-25:** 논문, 프로젝트 페이지, 코드, 데이터, 환경 및 모델 모두 공개되었습니다.

# 소개

본 연구는 **_현실적인 UAV 비전-언어 내비게이션을 향하여: 플랫폼, 벤치마크 및 방법론_**을 제시합니다. UAV 시뮬레이션 플랫폼, 보조자 안내 현실적 UAV VLN 벤치마크, 그리고 현실적인 UAV 비전-언어 내비게이션의 도전을 해결하기 위한 MLLM 기반 방법을 소개합니다.

# 종속성

### `llamauav` 환경 생성하기

```bash
conda create -n llamauav python=3.10 -y
conda activate llamauav
pip install torch==2.0.1 torchvision==0.15.2 torchaudio==2.0.2 --index-url https://download.pytorch.org/whl/cu118
```
## LLaMA-UAV 모델 설치

다음 링크 [LLaMA-UAV](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#install)를 따라 llm 종속성을 설치할 수 있습니다.

### 요구 사항 파일에 나열된 기타 종속성 설치


```bash
pip install -r requirement.txt
```
또한 AirSim Python API와의 호환성을 보장하기 위해 [AirSim 이슈](https://github.com/microsoft/AirSim/issues/3333#issuecomment-827894198)에서 언급된 수정 사항을 적용하십시오.

# 준비

## 데이터

데이터셋을 준비하려면 [데이터셋 섹션](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#dataset)에 제공된 지침을 따라 데이터셋을 구축하십시오.

## 모델

### GroundingDINO

GroundingDINO 모델을 [groundingdino_swint_ogc.pth](https://huggingface.co/ShilongLiu/GroundingDINO/resolve/main/groundingdino_swint_ogc.pth) 링크에서 다운로드하고, 파일을 `src/model_wrapper/utils/GroundingDINO/` 디렉터리에 배치하십시오.

### LLaMA-UAV

모델 설정에 대해서는 자세한 [모델 설정](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md)을 참조하십시오.

## 시뮬레이터 환경

다양한 맵에 대한 시뮬레이터 환경은 [여기](https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env)에서 다운로드하십시오.

환경 파일 디렉터리는 다음과 같습니다:


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

# 사용법

1. 시뮬레이터 환경 서버 설정

시뮬레이션을 실행하기 전에 AirSim 환경 서버가 올바르게 구성되었는지 확인하십시오.

> `AirVLNSimulatorServerTool.py`에서 `root_path`에 상대적인 env 실행 파일 경로 `env_exec_path_dict`를 업데이트하십시오.

```bash
cd airsim_plugin
python AirVLNSimulatorServerTool.py --port 30000 --root_path /path/to/your/envs
```
2. 클로즈 루프 시뮬레이션 실행

시뮬레이터 서버가 실행 중이면, dagger 또는 평가 스크립트를 실행할 수 있습니다.


```bash
# Dagger NYC
bash scripts/dagger_NYC.sh
# Eval
bash scripts/eval.sh
bash scripts/metrics.sh
```

# 논문

이 프로젝트가 유용하다면, 다음 논문을 인용해 주시기 바랍니다: [paper](https://arxiv.org/abs/2410.07087):

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

# 감사의 글

이 저장소는 부분적으로 [AirVLN](https://github.com/AirVLN/AirVLN) 및 [LLaMA-VID](https://github.com/dvlab-research/LLaMA-VID) 저장소를 기반으로 합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---