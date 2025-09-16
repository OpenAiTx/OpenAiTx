# [NeurIPS 2024] MADiff : Apprentissage multi-agent hors ligne avec des modèles de diffusion

![Python 3.8](https://img.shields.io/badge/Python-3.8-blue)
![Code style](https://img.shields.io/badge/code%20style-black-000000.svg)
![MIT](https://img.shields.io/badge/license-MIT-blue)
[![arXiv](https://img.shields.io/badge/arXiv-Paper-<COLOR>.svg)](https://arxiv.org/abs/2305.17330)

Voici l'implémentation officielle de "MADiff : Apprentissage multi-agent hors ligne avec des modèles de diffusion" publié dans NeurIPS 2024.

![MADiff](/assets/images/madiff.png)

## Performances

Nous omettons l'écart type des résultats par souci de concision. Les résultats complets sont disponibles dans notre [article](https://arxiv.org/abs/2305.17330).

### Environnement multi-agent Particle (MPE)

Les performances sur les ensembles de données MPE publiés dans l'[article OMAR](https://arxiv.org/abs/2111.11188). Les résultats sont moyennés sur 5 graines aléatoires.

| Ensemble de données | Tâche | BC | MA-ICQ | MA-TD3+BC | MA-CQL | OMAR | MADiff-D | MADiff-C* |
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

### Mujoco multi-agent (MA-Mujoco)

Les performances sur les ensembles de données MA-Mujoco publiés dans le [benchmark MARL off-the-grid](https://arxiv.org/abs/2302.00521). Les résultats sont moyennés sur 5 graines aléatoires.

| Ensemble de données | Tâche | BC | MA-TD3+BC | OMAR | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| Bon | 2halfcheetah | 6846 | 7025 | 1434 | **8246** | 8514 |
| Moyen | 2halfcheetah | 1627 | **2561** | 1892 | 2207 | 2203 |
| Faible | 2halfcheetah | 465 | 736 | 384 | **759** | 760 |
| Bon | 2ant | 2697 | 2922 | 464 | **2946** | 3069 |
| Moyen | 2ant | 1145 | 744 | 799 | **1211** | 1243 |
| Faible | 2ant | 954 | **1256** | 857 | 946 | 1038 |
| Bon | 4ant | 2802 | 2628 | 344 | **3080** | 3068 |
| Moyen | 4ant | 1617 | **1843** | 929 | 1649 | 1871 |
| Faible | 4ant | 1033 | 1075 | 518 | **1295** | 1353 |

### Défi Multi-Agent StarCraft (SMAC)

Les performances sur les ensembles de données SMAC publiées dans [off-the-grid MARL benchmark](https://arxiv.org/abs/2302.00521). Les résultats sont moyennés sur 5 graines aléatoires.

| Ensemble de données | Tâche | BC | QMIX | MA-ICQ | MA-CQL | MADT | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| Bon | 3m | 16.0 | 13.8 | 18.8 | **19.6** | 19.1 | 19.3 | 19.9 |
| Moyen | 3m | 8.2 | 17.3 | 18.1 | **18.9** | 15.8 | 17.3 | 18.1 | 
| Faible | 3m | 4.4 | 10.0 | **14.4** | 5.8 | 4.4 | 9.6 | 9.5 | 
| Bon | 2s3z | 18.2 | 5.9 | **19.6** | 19.0 | 19.3 | **19.6** | 19.7 | 
| Moyen | 2s3z | 12.3 | 5.2 | 17.2 | 14.3 | 15.0 | **17.4** | 17.6 | 
| Faible | 2s3z | 6.7 | 3.8 | **12.1** | 10.1 | 7.0 | 9.8 | 10.4 |
| Bon | 5m6m | 16.6 | 8.0 | 16.3 | 13.8 | 16.7 | **17.8** | 18.0 | 
| Moyen | 5m6m | 12.4 | 12.0 | 15.3 | 17.0 | 16.6 | **17.3** | 18.0 | 
| Faible | 5m6m | 7.5 | **10.7** | 9.4 | 10.4 | 7.8 | 8.9 | 10.3 |
| Bon | 8m | 16.7 | 4.6 | **19.6** | 11.3 | 18.4 | 19.2 | 19.8 | 
| Moyen | 8m | 10.7 | 13.9 | 18.6 | 16.8 | 18.5 | **18.9** | 19.4 | 
| Faible | 8m | 5.3 | 6.0 | **10.8** | 4.6 | 4.7 | 5.1 | 5.1 |

*\* MADiff-C n'est pas destiné à être une comparaison équitable avec les méthodes de référence mais à montrer si MADiff-D comble le fossé pour la coordination sans information globale.*

## Configuration

### Installation

```bash
sudo apt-get update
sudo apt-get install libssl-dev libcurl4-openssl-dev swig
conda create -n madiff python=3.8
conda activate madiff
pip install torch==1.12.1+cu113 --extra-index-url https://download.pytorch.org/whl/cu113
pip install -r requirements.txt
```

### Configuration de MPE

Nous utilisons le jeu de données MPE provenant de [OMAR](https://github.com/ling-pan/OMAR). Le lien de téléchargement et les instructions du jeu de données se trouvent dans le [dépôt](https://github.com/ling-pan/OMAR) d'OMAR. Comme leurs liens de téléchargement BaiduPan peuvent être peu pratiques pour les utilisateurs non chinois, nous maintenons un miroir anonyme [dépôt](https://osf.io/jxawh/?view_only=dd3264a695af4c03bffde0350b8e8c4a) sur OSF pour obtenir le jeu de données.

Le jeu de données téléchargé doit être placé sous `diffuser/datasets/data/mpe`.

Installer l'environnement MPE :

```bash
pip install -e third_party/multiagent-particle-envs
pip install -e third_party/ddpg-agent
```

### Installation de MA-Mujoco

1. Installer MA-Mujoco :

    ```bash
    pip install -e third_party/multiagent_mujoco
    ```
2. Nous utilisons le jeu de données MA-Mujoco provenant de [off-the-grid MARL](https://sites.google.com/view/og-marl). Nous prétraitons le jeu de données pour concaténer les trajectoires en épisodes complets et les enregistrer sous forme de fichiers `.npy` pour un chargement plus facile. Le jeu de données original peut être téléchargé depuis le [dépôt](https://huggingface.co/datasets/Avada11/MADiff-Datasets) Huggingface.

    Le jeu de données téléchargé doit être décompressé et placé sous `diffuser/datasets/data/mamujoco`.

3. Installez off-the-grid MARL et transformez le jeu de données original.


    ```bash
    pip install -r ./third_party/og-marl/install_environments/requirements/mamujoco.txt
    pip install -e ./third_party/og-marl
    python scripts/transform_og_marl_dataset.py --env_name mamujoco --map_name <map> --quality <dataset>
    ```

### Configuration de SMAC

1. Exécutez `scripts/smac.sh` pour installer *StarCraftII*.

2. Installez SMAC :

    ```bash
    pip install git+https://github.com/oxwhirl/smac.git
    ```

3. Nous utilisons le jeu de données SMAC provenant de [off-the-grid MARL](https://sites.google.com/view/og-marl). Nous prétraitons le jeu de données pour concaténer les trajectoires en épisodes complets et les enregistrons au format `.npy` pour un chargement plus facile. Le jeu de données original peut être téléchargé depuis le [dépôt](https://huggingface.co/datasets/Avada11/MADiff-Datasets) Huggingface.

    Le jeu de données téléchargé doit être décompressé et placé sous `diffuser/datasets/data/smac`.

4. Installez off-the-grid MARL et transformez le jeu de données original.

    ```bash
    pip install -r ./third_party/og-marl/install_environments/requirements/smacv1.txt
    pip install -e ./third_party/og-marl
    python scripts/transform_og_marl_dataset.py --env_name smac --map_name <map> --quality <dataset>
    ```

## Entraînement et Évaluation
Pour commencer l'entraînement, exécutez les commandes suivantes

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

Pour évaluer le modèle entraîné, remplacez d'abord le `log_dir` par ceux à évaluer dans `exp_specs/eval_inv.yaml` et exécutez
```bash
python run_experiment.py -e exp_specs/eval_inv.yaml
```

## Citation

```
@article{zhu2023madiff,
  title={MADiff: Offline Multi-agent Learning with Diffusion Models},
  author={Zhu, Zhengbang and Liu, Minghuan and Mao, Liyuan and Kang, Bingyi and Xu, Minkai and Yu, Yong and Ermon, Stefano and Zhang, Weinan},
  journal={arXiv preprint arXiv:2305.17330},
  year={2023}
}
```

## Remerciements

La base de code est construite sur le [dépôt decision-diffuser](https://github.com/anuragajay/decision-diffuser) et [ILSwiss](https://github.com/Ericonaldo/ILSwiss).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---