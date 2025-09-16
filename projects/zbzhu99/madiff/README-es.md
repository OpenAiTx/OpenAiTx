# [NeurIPS 2024] MADiff: Aprendizaje Multiagente Offline con Modelos de Difusión

![Python 3.8](https://img.shields.io/badge/Python-3.8-blue)
![Code style](https://img.shields.io/badge/code%20style-black-000000.svg)
![MIT](https://img.shields.io/badge/license-MIT-blue)
[![arXiv](https://img.shields.io/badge/arXiv-Paper-<COLOR>.svg)](https://arxiv.org/abs/2305.17330)

Esta es la implementación oficial de "MADiff: Aprendizaje Multiagente Offline con Modelos de Difusión" publicado en NeurIPS 2024.

![MADiff](/assets/images/madiff.png)

## Rendimientos

Omitimos la desviación estándar de los resultados por brevedad. Los resultados completos pueden encontrarse en nuestro [artículo](https://arxiv.org/abs/2305.17330).

### Entorno Multiagente de Partículas (MPE)

Los rendimientos en los conjuntos de datos MPE publicados en el [artículo OMAR](https://arxiv.org/abs/2111.11188). Los resultados son promediados sobre 5 semillas aleatorias.

| Conjunto de datos | Tarea | BC | MA-ICQ | MA-TD3+BC | MA-CQL | OMAR | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| Experto | Spread | 35.0 | 104.0 | 108.3 | 98.2 | **114.9** | 95.0 | 116.7 |
| Md-Replay | Spread | 10.0 | 13.6 | 15.4 | 20.0 | **37.9** | 30.3 | 42.2 |
| Medio | Spread | 31.6 | 29.3 | 29.3 | 34.1 | 47.9 | **64.9** | 58.2 |
| Aleatorio | Spread | -0.5 | 6.3 | 9.8 | 24.0 | **34.4** | 6.9 | 4.3 |
| Experto | Tag | 40.0 | 113.0 | 115.2 | 93.9 | 116.2 | **120.9** | 167.6 |
| Md-Replay | Tag | 0.9 | 34.5 | 28.7 | 24.8 | 47.1 | **62.3** | 95.0 |
| Medio | Tag | 22.5 | 63.3 | 65.1 | 61.7 | 66.7 | **77.2** | 132.9 |
| Aleatorio | Tag | 1.2 | 2.2 | 5.7 | 5.0 | **11.1** | 3.2 | 10.7 |
| Experto | World | 33.0 | 109.5 | 110.3 | 71.9 | 110.4 | **122.6** | 174.0 |
| Md-Replay | World | 2.3 | 12.0 | 17.4 | 29.6 | 42.9 | **57.1** | 83.0 |
| Medio | World | 25.3 | 71.9 | 73.4 | 58.6 | 74.6 | **123.5** | 158.2 |
| Aleatorio | World | -2.4 | 1.0 | 2.8 | 0.6 | **5.9** | 2.0 | 8.1 |

### Mujoco Multiagente (MA-Mujoco)

Los rendimientos en los conjuntos de datos MA-Mujoco publicados en el [benchmark off-the-grid MARL](https://arxiv.org/abs/2302.00521). Los resultados son promediados sobre 5 semillas aleatorias.

| Conjunto de datos | Tarea | BC | MA-TD3+BC | OMAR | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| Bueno | 2halfcheetah | 6846 | 7025 | 1434 | **8246** | 8514 |
| Medio | 2halfcheetah | 1627 | **2561** | 1892 | 2207 | 2203 |
| Pobre | 2halfcheetah | 465 | 736 | 384 | **759** | 760 |
| Bueno | 2ant | 2697 | 2922 | 464 | **2946** | 3069 |
| Medio | 2ant | 1145 | 744 | 799 | **1211** | 1243 |
| Pobre | 2ant | 954 | **1256** | 857 | 946 | 1038 |
| Bueno | 4ant | 2802 | 2628 | 344 | **3080** | 3068 |
| Medio | 4ant | 1617 | **1843** | 929 | 1649 | 1871 |
| Pobre | 4ant | 1033 | 1075 | 518 | **1295** | 1353 |

### Desafío Multiagente de StarCraft (SMAC)

Los desempeños en los conjuntos de datos SMAC publicados en [referencia MARL off-the-grid](https://arxiv.org/abs/2302.00521). Los resultados son promediados sobre 5 semillas aleatorias.

| Conjunto de datos | Tarea | BC | QMIX | MA-ICQ | MA-CQL | MADT | MADiff-D | MADiff-C* |
| :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: | :----: |
| Bueno | 3m | 16.0 | 13.8 | 18.8 | **19.6** | 19.1 | 19.3 | 19.9 |
| Medio | 3m | 8.2 | 17.3 | 18.1 | **18.9** | 15.8 | 17.3 | 18.1 | 
| Pobre | 3m | 4.4 | 10.0 | **14.4** | 5.8 | 4.4 | 9.6 | 9.5 | 
| Bueno | 2s3z | 18.2 | 5.9 | **19.6** | 19.0 | 19.3 | **19.6** | 19.7 | 
| Medio | 2s3z | 12.3 | 5.2 | 17.2 | 14.3 | 15.0 | **17.4** | 17.6 | 
| Pobre | 2s3z | 6.7 | 3.8 | **12.1** | 10.1 | 7.0 | 9.8 | 10.4 |
| Bueno | 5m6m | 16.6 | 8.0 | 16.3 | 13.8 | 16.7 | **17.8** | 18.0 | 
| Medio | 5m6m | 12.4 | 12.0 | 15.3 | 17.0 | 16.6 | **17.3** | 18.0 | 
| Pobre | 5m6m | 7.5 | **10.7** | 9.4 | 10.4 | 7.8 | 8.9 | 10.3 |
| Bueno | 8m | 16.7 | 4.6 | **19.6** | 11.3 | 18.4 | 19.2 | 19.8 | 
| Medio | 8m | 10.7 | 13.9 | 18.6 | 16.8 | 18.5 | **18.9** | 19.4 | 
| Pobre | 8m | 5.3 | 6.0 | **10.8** | 4.6 | 4.7 | 5.1 | 5.1 |

*\* MADiff-C no está destinado a ser una comparación justa con los métodos base, sino para mostrar si MADiff-D cubre la brecha para la coordinación sin información global.*

## Configuración

### Instalación

```bash
sudo apt-get update
sudo apt-get install libssl-dev libcurl4-openssl-dev swig
conda create -n madiff python=3.8
conda activate madiff
pip install torch==1.12.1+cu113 --extra-index-url https://download.pytorch.org/whl/cu113
pip install -r requirements.txt
```

### Configurar MPE

Utilizamos el conjunto de datos MPE de [OMAR](https://github.com/ling-pan/OMAR). El enlace de descarga del conjunto de datos y las instrucciones se pueden encontrar en el [repositorio](https://github.com/ling-pan/OMAR) de OMAR. Dado que sus enlaces de descarga de BaiduPan pueden ser inconvenientes para usuarios que no son chinos, mantenemos un espejo anónimo [repositorio](https://osf.io/jxawh/?view_only=dd3264a695af4c03bffde0350b8e8c4a) en OSF para adquirir el conjunto de datos.

El conjunto de datos descargado debe colocarse en `diffuser/datasets/data/mpe`.

Instalar el entorno MPE:

```bash
pip install -e third_party/multiagent-particle-envs
pip install -e third_party/ddpg-agent
```

### Configurar MA-Mujoco

1. Instalar MA-Mujoco:

    ```bash
    pip install -e third_party/multiagent_mujoco
    ```
2. Usamos el conjunto de datos MA-Mujoco de [off-the-grid MARL](https://sites.google.com/view/og-marl). Preprocesamos el conjunto de datos para concatenar trayectorias en episodios completos y guardarlos como archivos `.npy` para facilitar su carga. El conjunto de datos original se puede descargar desde el [repositorio](https://huggingface.co/datasets/Avada11/MADiff-Datasets) de Huggingface.

    El conjunto de datos descargado debe descomprimirse y colocarse en `diffuser/datasets/data/mamujoco`.

3. Instale off-the-grid MARL y transforme el conjunto de datos original.


    ```bash
    pip install -r ./third_party/og-marl/install_environments/requirements/mamujoco.txt
    pip install -e ./third_party/og-marl
    python scripts/transform_og_marl_dataset.py --env_name mamujoco --map_name <map> --quality <dataset>
    ```

### Configurar SMAC

1. Ejecute `scripts/smac.sh` para instalar *StarCraftII*.

2. Instale SMAC:

    ```bash
    pip install git+https://github.com/oxwhirl/smac.git
    ```

3. Usamos el conjunto de datos SMAC de [off-the-grid MARL](https://sites.google.com/view/og-marl). Preprocesamos el conjunto de datos para concatenar trayectorias en episodios completos y guardarlos como archivos `.npy` para facilitar la carga. El conjunto de datos original se puede descargar desde el [repositorio](https://huggingface.co/datasets/Avada11/MADiff-Datasets) de Huggingface.

    El conjunto de datos descargado debe descomprimirse y colocarse en `diffuser/datasets/data/smac`.

4. Instale off-the-grid MARL y transforme el conjunto de datos original.

    ```bash
    pip install -r ./third_party/og-marl/install_environments/requirements/smacv1.txt
    pip install -e ./third_party/og-marl
    python scripts/transform_og_marl_dataset.py --env_name smac --map_name <map> --quality <dataset>
    ```

## Entrenamiento y Evaluación
Para comenzar el entrenamiento, ejecute los siguientes comandos

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
Para evaluar el modelo entrenado, primero reemplace el `log_dir` con los que deben ser evaluados en `exp_specs/eval_inv.yaml` y ejecute

```bash
python run_experiment.py -e exp_specs/eval_inv.yaml
```

## Cita

```
@article{zhu2023madiff,
  title={MADiff: Offline Multi-agent Learning with Diffusion Models},
  author={Zhu, Zhengbang and Liu, Minghuan and Mao, Liyuan and Kang, Bingyi and Xu, Minkai and Yu, Yong and Ermon, Stefano and Zhang, Weinan},
  journal={arXiv preprint arXiv:2305.17330},
  year={2023}
}
```

## Agradecimientos

La base de código está construida sobre el repositorio [decision-diffuser](https://github.com/anuragajay/decision-diffuser) y [ILSwiss](https://github.com/Ericonaldo/ILSwiss).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---