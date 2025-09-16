# [NeurIPS 2024] MADiff: 확산 모델을 이용한 오프라인 다중 에이전트 학습

![Python 3.8](https://img.shields.io/badge/Python-3.8-blue)
![Code style](https://img.shields.io/badge/code%20style-black-000000.svg)
![MIT](https://img.shields.io/badge/license-MIT-blue)
[![arXiv](https://img.shields.io/badge/arXiv-Paper-<COLOR>.svg)](https://arxiv.org/abs/2305.17330)

이것은 NeurIPS 2024에 발표된 "MADiff: 확산 모델을 이용한 오프라인 다중 에이전트 학습"의 공식 구현체입니다.

![MADiff](/assets/images/madiff.png)

## 성능

간결함을 위해 결과의 표준 편차는 생략하였습니다. 전체 결과는 저희 [논문](https://arxiv.org/abs/2305.17330)에서 확인할 수 있습니다.

### 다중 에이전트 입자 환경 (MPE)

[OMAR 논문](https://arxiv.org/abs/2111.11188)에서 공개한 MPE 데이터셋에서의 성능입니다. 결과는 5개의 무작위 시드에 대해 평균한 값입니다.

| 데이터셋 | 작업 | BC | MA-ICQ | MA-TD3+BC | MA-CQL | OMAR | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| 전문가 | Spread | 35.0 | 104.0 | 108.3 | 98.2 | **114.9** | 95.0 | 116.7 |
| Md-Replay | Spread | 10.0 | 13.6 | 15.4 | 20.0 | **37.9** | 30.3 | 42.2 |
| 중간 | Spread | 31.6 | 29.3 | 29.3 | 34.1 | 47.9 | **64.9** | 58.2 |
| 무작위 | Spread | -0.5 | 6.3 | 9.8 | 24.0 | **34.4** | 6.9 | 4.3 |
| 전문가 | Tag | 40.0 | 113.0 | 115.2 | 93.9 | 116.2 | **120.9** | 167.6 |
| Md-Replay | Tag | 0.9 | 34.5 | 28.7 | 24.8 | 47.1 | **62.3** | 95.0 |
| 중간 | Tag | 22.5 | 63.3 | 65.1 | 61.7 | 66.7 | **77.2** | 132.9 |
| 무작위 | Tag | 1.2 | 2.2 | 5.7 | 5.0 | **11.1** | 3.2 | 10.7 |
| 전문가 | World | 33.0 | 109.5 | 110.3 | 71.9 | 110.4 | **122.6** | 174.0 |
| Md-Replay | World | 2.3 | 12.0 | 17.4 | 29.6 | 42.9 | **57.1** | 83.0 |
| 중간 | World | 25.3 | 71.9 | 73.4 | 58.6 | 74.6 | **123.5** | 158.2 |
| 무작위 | World | -2.4 | 1.0 | 2.8 | 0.6 | **5.9** | 2.0 | 8.1 |

### 다중 에이전트 무조코 (MA-Mujoco)

[off-the-grid MARL 벤치마크](https://arxiv.org/abs/2302.00521)에서 공개한 MA-Mujoco 데이터셋에서의 성능입니다. 결과는 5개의 무작위 시드에 대해 평균한 값입니다.

| 데이터셋 | 작업 | BC | MA-TD3+BC | OMAR | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| Good | 2halfcheetah | 6846 | 7025 | 1434 | **8246** | 8514 |
| Medium | 2halfcheetah | 1627 | **2561** | 1892 | 2207 | 2203 |
| Poor | 2halfcheetah | 465 | 736 | 384 | **759** | 760 |
| Good | 2ant | 2697 | 2922 | 464 | **2946** | 3069 |
| Medium | 2ant | 1145 | 744 | 799 | **1211** | 1243 |
| Poor | 2ant | 954 | **1256** | 857 | 946 | 1038 |
| Good | 4ant | 2802 | 2628 | 344 | **3080** | 3068 |
| Medium | 4ant | 1617 | **1843** | 929 | 1649 | 1871 |
| Poor | 4ant | 1033 | 1075 | 518 | **1295** | 1353 |

### 스타크래프트 멀티 에이전트 챌린지 (SMAC)

[off-the-grid MARL benchmark](https://arxiv.org/abs/2302.00521)에서 공개된 SMAC 데이터셋에서의 성능입니다. 결과는 5개의 랜덤 시드에 대해 평균한 값입니다.

| 데이터셋 | 작업 | BC | QMIX | MA-ICQ | MA-CQL | MADT | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| Good | 3m | 16.0 | 13.8 | 18.8 | **19.6** | 19.1 | 19.3 | 19.9 |
| Medium | 3m | 8.2 | 17.3 | 18.1 | **18.9** | 15.8 | 17.3 | 18.1 | 
| Poor | 3m | 4.4 | 10.0 | **14.4** | 5.8 | 4.4 | 9.6 | 9.5 | 
| Good | 2s3z | 18.2 | 5.9 | **19.6** | 19.0 | 19.3 | **19.6** | 19.7 | 
| Medium | 2s3z | 12.3 | 5.2 | 17.2 | 14.3 | 15.0 | **17.4** | 17.6 | 
| Poor | 2s3z | 6.7 | 3.8 | **12.1** | 10.1 | 7.0 | 9.8 | 10.4 |
| Good | 5m6m | 16.6 | 8.0 | 16.3 | 13.8 | 16.7 | **17.8** | 18.0 | 
| Medium | 5m6m | 12.4 | 12.0 | 15.3 | 17.0 | 16.6 | **17.3** | 18.0 | 
| Poor | 5m6m | 7.5 | **10.7** | 9.4 | 10.4 | 7.8 | 8.9 | 10.3 |
| Good | 8m | 16.7 | 4.6 | **19.6** | 11.3 | 18.4 | 19.2 | 19.8 | 
| Medium | 8m | 10.7 | 13.9 | 18.6 | 16.8 | 18.5 | **18.9** | 19.4 | 
| Poor | 8m | 5.3 | 6.0 | **10.8** | 4.6 | 4.7 | 5.1 | 5.1 |

*\* MADiff-C는 기준 방법들과의 공정한 비교를 위한 것이 아니라 MADiff-D가 전역 정보 없이 조정 격차를 채우는지 보여주기 위한 것입니다.*

## 설정

### 설치

```bash
sudo apt-get update
sudo apt-get install libssl-dev libcurl4-openssl-dev swig
conda create -n madiff python=3.8
conda activate madiff
pip install torch==1.12.1+cu113 --extra-index-url https://download.pytorch.org/whl/cu113
pip install -r requirements.txt
```
### MPE 설정

우리는 [OMAR](https://github.com/ling-pan/OMAR)의 MPE 데이터셋을 사용합니다. 데이터셋 다운로드 링크와 지침은 OMAR의 [저장소](https://github.com/ling-pan/OMAR)에서 확인할 수 있습니다. BaiduPan 다운로드 링크가 중국 외 사용자에게 불편할 수 있기 때문에, 데이터셋을 획득하기 위해 OSF에 익명 미러 [저장소](https://osf.io/jxawh/?view_only=dd3264a695af4c03bffde0350b8e8c4a)를 유지하고 있습니다.

다운로드한 데이터셋은 `diffuser/datasets/data/mpe` 경로에 위치해야 합니다.

MPE 환경을 설치하세요:


```bash
pip install -e third_party/multiagent-particle-envs
pip install -e third_party/ddpg-agent
```

### MA-Mujoco 설정

1. MA-Mujoco 설치:

    ```bash
    pip install -e third_party/multiagent_mujoco
    ```
2. 우리는 [off-the-grid MARL](https://sites.google.com/view/og-marl)에서 제공하는 MA-Mujoco 데이터셋을 사용합니다. 데이터셋을 전처리하여 궤적을 전체 에피소드로 연결하고 `.npy` 파일로 저장하여 더 쉽게 로드할 수 있도록 합니다. 원본 데이터셋은 Huggingface [저장소](https://huggingface.co/datasets/Avada11/MADiff-Datasets)에서 다운로드할 수 있습니다.

    다운로드한 데이터셋은 압축을 풀고 `diffuser/datasets/data/mamujoco` 폴더에 배치해야 합니다.

3. off-the-grid MARL을 설치하고 원본 데이터셋을 변환합니다.


    ```bash
    pip install -r ./third_party/og-marl/install_environments/requirements/mamujoco.txt
    pip install -e ./third_party/og-marl
    python scripts/transform_og_marl_dataset.py --env_name mamujoco --map_name <map> --quality <dataset>
    ```

### SMAC 설정

1. `scripts/smac.sh`를 실행하여 *StarCraftII*를 설치합니다.

2. SMAC을 설치합니다:

    ```bash
    pip install git+https://github.com/oxwhirl/smac.git
    ```
3. 우리는 [off-the-grid MARL](https://sites.google.com/view/og-marl)에서 제공하는 SMAC 데이터셋을 사용합니다. 데이터셋을 전처리하여 궤적을 전체 에피소드로 연결하고 `.npy` 파일로 저장하여 로딩을 용이하게 합니다. 원본 데이터셋은 Huggingface [저장소](https://huggingface.co/datasets/Avada11/MADiff-Datasets)에서 다운로드할 수 있습니다.

    다운로드한 데이터셋은 압축을 풀고 `diffuser/datasets/data/smac` 경로에 위치시켜야 합니다.

4. off-the-grid MARL을 설치하고 원본 데이터셋을 변환합니다.


    ```bash
    pip install -r ./third_party/og-marl/install_environments/requirements/smacv1.txt
    pip install -e ./third_party/og-marl
    python scripts/transform_og_marl_dataset.py --env_name smac --map_name <map> --quality <dataset>
    ```

## 학습 및 평가
학습을 시작하려면 다음 명령어를 실행하세요

```bash
# multi-agent particle environment
python run_experiment.py -e exp_specs/mpe/<task>/mad_mpe_<task>_attn_<dataset>.yaml  # CTCE
python run_experiment.py -e exp_specs/mpe/<task>/mad_mpe_<task>_ctde_<dataset>.yaml  # CTDE
# ma-mujoco
python run_experiment.py -e exp_specs/mamujoco/<task>/mad_mamujoco_<task>_attn_<dataset>_history.yaml  # CTCE
python run_experiment.py -e exp_specs/mamujoco/<task>/mad_mamujoco_<task>_ctde_<dataset>_history.yaml  # CTDE
# smac
python run_experiment.py -e exp_specs/smac/<map>/mad_smac_<map>_attn_<dataset>_history.yaml  # CTCE
python run_experiment.py -e exp_specs/smac/<map>/mad_smac_<map>_ctde_<dataset>_history.yaml  # CTDE
```

학습된 모델을 평가하려면 먼저 `exp_specs/eval_inv.yaml`에서 평가할 `log_dir`을 교체한 후 실행하세요
```bash
python run_experiment.py -e exp_specs/eval_inv.yaml
```

## 인용

```
@article{zhu2023madiff,
  title={MADiff: Offline Multi-agent Learning with Diffusion Models},
  author={Zhu, Zhengbang and Liu, Minghuan and Mao, Liyuan and Kang, Bingyi and Xu, Minkai and Yu, Yong and Ermon, Stefano and Zhang, Weinan},
  journal={arXiv preprint arXiv:2305.17330},
  year={2023}
}
```

## 감사의 글

이 코드베이스는 [decision-diffuser repo](https://github.com/anuragajay/decision-diffuser)와 [ILSwiss](https://github.com/Ericonaldo/ILSwiss)를 기반으로 구축되었습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---