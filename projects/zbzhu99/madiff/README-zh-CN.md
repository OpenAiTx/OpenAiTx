# [NeurIPS 2024] MADiff：基于扩散模型的离线多智能体学习

![Python 3.8](https://img.shields.io/badge/Python-3.8-blue)
![Code style](https://img.shields.io/badge/code%20style-black-000000.svg)
![MIT](https://img.shields.io/badge/license-MIT-blue)
[![arXiv](https://img.shields.io/badge/arXiv-Paper-<COLOR>.svg)](https://arxiv.org/abs/2305.17330)

这是NeurIPS 2024发表的论文《MADiff：基于扩散模型的离线多智能体学习》的官方实现。

![MADiff](/assets/images/madiff.png)

## 性能表现

为简洁起见，我们省略了结果的标准差。完整结果请参见我们的[论文](https://arxiv.org/abs/2305.17330)。

### 多智能体粒子环境（MPE）

MPE数据集的性能来自[OMAR论文](https://arxiv.org/abs/2111.11188)发布的数据。结果是5个随机种子的平均值。

| 数据集 | 任务 | BC | MA-ICQ | MA-TD3+BC | MA-CQL | OMAR | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| Expert | Spread | 35.0 | 104.0 | 108.3 | 98.2 | **114.9** | 95.0 | 116.7 |
| Md-Replay | Spread | 10.0 | 13.6 | 15.4 | 20.0 | **37.9** | 30.3 | 42.2 |
| Medium | Spread | 31.6 | 29.3 | 29.3 | 34.1 | 47.9 | **64.9** | 58.2 |
| Random | Spread | -0.5 | 6.3 | 9.8 | 24.0 | **34.4** | 6.9 | 4.3 |
| Expert | Tag | 40.0 | 113.0 | 115.2 | 93.9 | 116.2 | **120.9** | 167.6 |
| Md-Replay | Tag | 0.9 | 34.5 | 28.7 | 24.8 | 47.1 | **62.3** | 95.0 |
| Medium | Tag | 22.5 | 63.3 | 65.1 | 61.7 | 66.7 | **77.2** | 132.9 |
| Random | Tag | 1.2 | 2.2 | 5.7 | 5.0 | **11.1** | 3.2 | 10.7 |
| Expert | World | 33.0 | 109.5 | 110.3 | 71.9 | 110.4 | **122.6** | 174.0 |
| Md-Replay | World | 2.3 | 12.0 | 17.4 | 29.6 | 42.9 | **57.1** | 83.0 |
| Medium | World | 25.3 | 71.9 | 73.4 | 58.6 | 74.6 | **123.5** | 158.2 |
| Random | World | -2.4 | 1.0 | 2.8 | 0.6 | **5.9** | 2.0 | 8.1 |

### 多智能体Mujoco（MA-Mujoco）

MA-Mujoco数据集的性能来自[off-the-grid MARL benchmark](https://arxiv.org/abs/2302.00521)发布的数据。结果是5个随机种子的平均值。

| 数据集 | 任务 | BC | MA-TD3+BC | OMAR | MADiff-D | MADiff-C* |
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

### 星际争霸多智能体挑战（SMAC）

性能基于[离网多智能体强化学习基准](https://arxiv.org/abs/2302.00521)中发布的SMAC数据集。结果为5个随机种子的平均值。

| 数据集 | 任务 | BC | QMIX | MA-ICQ | MA-CQL | MADT | MADiff-D | MADiff-C* |
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

*\* MADiff-C 并非与基线方法的公平比较，而是用于展示 MADiff-D 是否能在没有全局信息的情况下弥补协调的差距。*

## 设置

### 安装

```bash
sudo apt-get update
sudo apt-get install libssl-dev libcurl4-openssl-dev swig
conda create -n madiff python=3.8
conda activate madiff
pip install torch==1.12.1+cu113 --extra-index-url https://download.pytorch.org/whl/cu113
pip install -r requirements.txt
```

### 设置 MPE

我们使用来自 [OMAR](https://github.com/ling-pan/OMAR) 的 MPE 数据集。数据集的下载链接和说明可见 OMAR 的 [仓库](https://github.com/ling-pan/OMAR)。由于他们的百度网盘下载链接对非中国用户可能不便，我们维护了一个匿名镜像 [仓库](https://osf.io/jxawh/?view_only=dd3264a695af4c03bffde0350b8e8c4a) 在 OSF 以便获取数据集。

下载的数据集应放置于 `diffuser/datasets/data/mpe` 目录下。

安装 MPE 环境：

```bash
pip install -e third_party/multiagent-particle-envs
pip install -e third_party/ddpg-agent
```

### 安装 MA-Mujoco

1. 安装 MA-Mujoco:

    ```bash
    pip install -e third_party/multiagent_mujoco
    ```
2. 我们使用来自 [off-the-grid MARL](https://sites.google.com/view/og-marl) 的 MA-Mujoco 数据集。我们对数据集进行了预处理，将轨迹拼接成完整的回合，并保存为 `.npy` 文件以便于加载。原始数据集可以从 Huggingface 的[仓库](https://huggingface.co/datasets/Avada11/MADiff-Datasets)下载。

    下载的数据集应解压后放置在 `diffuser/datasets/data/mamujoco` 目录下。

3. 安装 off-the-grid MARL 并转换原始数据集。


    ```bash
    pip install -r ./third_party/og-marl/install_environments/requirements/mamujoco.txt
    pip install -e ./third_party/og-marl
    python scripts/transform_og_marl_dataset.py --env_name mamujoco --map_name <map> --quality <dataset>
    ```

### 设置 SMAC

1. 运行 `scripts/smac.sh` 安装 *StarCraftII*。

2. 安装 SMAC：

    ```bash
    pip install git+https://github.com/oxwhirl/smac.git
    ```

3. 我们使用来自 [off-the-grid MARL](https://sites.google.com/view/og-marl) 的 SMAC 数据集。我们预处理数据集，将轨迹拼接为完整的回合，并保存为 `.npy` 文件以便更容易加载。原始数据集可以从 Huggingface [仓库](https://huggingface.co/datasets/Avada11/MADiff-Datasets) 下载。

    下载的数据集应解压并放置在 `diffuser/datasets/data/smac` 目录下。

4. 安装 off-the-grid MARL 并转换原始数据集。

    ```bash
    pip install -r ./third_party/og-marl/install_environments/requirements/smacv1.txt
    pip install -e ./third_party/og-marl
    python scripts/transform_og_marl_dataset.py --env_name smac --map_name <map> --quality <dataset>
    ```

## 训练与评估
要开始训练，请运行以下命令

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

要评估训练好的模型，首先将 `exp_specs/eval_inv.yaml` 中的 `log_dir` 替换为需要评估的路径，然后运行
```bash
python run_experiment.py -e exp_specs/eval_inv.yaml
```

## 引用

```
@article{zhu2023madiff,
  title={MADiff: Offline Multi-agent Learning with Diffusion Models},
  author={Zhu, Zhengbang and Liu, Minghuan and Mao, Liyuan and Kang, Bingyi and Xu, Minkai and Yu, Yong and Ermon, Stefano and Zhang, Weinan},
  journal={arXiv preprint arXiv:2305.17330},
  year={2023}
}
```

## 致谢

代码库构建于 [decision-diffuser 仓库](https://github.com/anuragajay/decision-diffuser) 和 [ILSwiss](https://github.com/Ericonaldo/ILSwiss) 之上。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---