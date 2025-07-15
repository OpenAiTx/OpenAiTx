# Unitree RL Lab

[![IsaacSim](https://img.shields.io/badge/IsaacSim-4.5.0-silver.svg)](https://docs.omniverse.nvidia.com/isaacsim/latest/overview.html)
[![Isaac Lab](https://img.shields.io/badge/IsaacLab-2.0.0-silver)](https://isaac-sim.github.io/IsaacLab)
[![License](https://img.shields.io/badge/license-Apache2.0-yellow.svg)](https://opensource.org/license/apache-2-0)

## 概要

本プロジェクトは、[IsaacLab](https://github.com/isaac-sim/IsaacLab) 上に構築されたUnitreeロボット用の強化学習環境のセットを提供します。

現在、Unitreeの**Go2**、**H1**、および**G1-29dof**ロボットをサポートしています。

<div align="center">

| <div align="center"> Isaac Lab </div> | <div align="center">  Mujoco </div> |  <div align="center"> 物理環境 </div> |
|--- | --- | --- |
| [<img src="https://oss-global-cdn.unitree.com/static/d879adac250648c587d3681e90658b49_480x397.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_sim.gif) | [<img src="https://oss-global-cdn.unitree.com/static/3c88e045ab124c3ab9c761a99cb5e71f_480x397.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_mujoco.gif) | [<img src="https://oss-global-cdn.unitree.com/static/6c17c6cf52ec4e26bbfab1fbf591adb2_480x270.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_real.gif) |

</div>

## インストール

- [インストールガイド](https://isaac-sim.github.io/IsaacLab/main/source/setup/installation/index.html)に従ってIsaac Labをインストールしてください。
- Unitree RL IsaacLabのスタンドアロン環境をインストールします。

  - Isaac Labのインストールとは別に、このリポジトリをクローンまたはコピーしてください（つまり、`IsaacLab`ディレクトリの外側）：

    ```bash
    git clone https://github.com/unitreerobotics/unitree_rl_lab.git
    ```
  - Isaac LabがインストールされているPythonインタープリターを使用し、ライブラリを編集可能モードでインストールします:

    ```bash
    conda activate env_isaaclab
    python -m pip install -e source/unitree_rl_lab
    ```
- unitreeのusdファイルをダウンロードする

  - フォルダ構造を保持したまま、[unitree_model](https://huggingface.co/datasets/unitreerobotics/unitree_model/tree/main)からunitreeのusdファイルをダウンロードする
    ```bash
    git clone https://huggingface.co/datasets/unitreerobotics/unitree_model
    ```
  - `source/unitree_rl_lab/unitree_rl_lab/assets/robots/unitree.py`の`UNITREE_MODEL_DIR`を設定します。

    ```bash
    UNITREE_MODEL_DIR = "</home/user/projects/unitree_usd>"
    ```
- 次の方法で環境が正しくインストールされていることを確認します：

  - 利用可能なタスクを一覧表示します：

    ```bash
    python scripts/list_envs.py
    ```
  - タスクの実行:

    ```bash
    python scripts/rsl_rl/train.py --headless --task Unitree-G1-29dof-Velocity
    ```
  - 訓練済みエージェントによる推論:

    ```bash
    python scripts/rsl_rl/play.py --task Unitree-G1-29dof-Velocity-Play
    ```
## デプロイ

モデルのトレーニングが完了したら、Mujocoで訓練された戦略に対してsim2simを実行し、モデルの性能をテストする必要があります。  
その後、sim2realを展開します。

### セットアップ


```bash
# Install dependencies
sudo apt install -y libyaml-cpp-dev libboost-all-dev libeigen3-dev libspdlog-dev
# Install unitree_sdk2
git clone git@github.com:unitreerobotics/unitree_sdk2.git
cd unitree_sdk2
mkdir build && cd build
cmake .. -DBUILD_EXAMPLES=OFF # Install on the /usr/local directory
sudo make install
# Compile the robot_controller
cd deploy/robots/g1 # or other robots
mkdir build && cd build
cmake .. && make
```
### Sim2Sim

[unitree_mujoco](https://github.com/unitreerobotics/unitree_mujoco?tab=readme-ov-file#installation)のインストール。

- `/simulate/config.yaml` の `robot` を g1 に設定
- `domain_id` を 0 に設定
- `enable_elastic_hand` を 1 に設定
- `use_joystck` を 1 に設定。


```bash
# start simulation
cd unitree_mujoco/simulate/build
./unitree_mujoco
```
元のテキストには1行あります。翻訳も正確に1行でなければなりません。
```bash
cd unitree_rl_lab/deploy/robots/g1/build
./g1_ctrl
# 1. press [L2 + Up] to set the robot to stand up
# 2. Click the mujoco window, and then press 8 to make the robot feet touch the ground.
# 3. Press [R1 + X] to run the policy.
# 4. Click the mujoco window, and then press 9 to disable the elastic band.
```
### Sim2Real

このプログラムを使用してロボットを直接制御できますが、オンボード制御プログラムが終了していることを確認してください。


```bash
./g1_ctrl --network eth0 # eth0 is the network interface name.
```
## 謝辞

このリポジトリは、以下のオープンソースプロジェクトのサポートと貢献に基づいて構築されています。特に感謝します：

- [IsaacLab](https://github.com/isaac-sim/IsaacLab): トレーニングおよび実行コードの基盤。
- [mujoco](https://github.com/google-deepmind/mujoco.git): 強力なシミュレーション機能の提供。
- [robot_lab](https://github.com/fan-ziqi/robot_lab): プロジェクト構造と実装の一部の参照。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---