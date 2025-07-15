# Unitree RL Lab

[![IsaacSim](https://img.shields.io/badge/IsaacSim-4.5.0-silver.svg)](https://docs.omniverse.nvidia.com/isaacsim/latest/overview.html)
[![Isaac Lab](https://img.shields.io/badge/IsaacLab-2.0.0-silver)](https://isaac-sim.github.io/IsaacLab)
[![License](https://img.shields.io/badge/license-Apache2.0-yellow.svg)](https://opensource.org/license/apache-2-0)

## 概覽

本專案提供一套基於 [IsaacLab](https://github.com/isaac-sim/IsaacLab) 建構的 Unitree 機器人強化學習環境。

目前支援 Unitree **Go2**、**H1** 以及 **G1-29dof** 機器人。

<div align="center">

| <div align="center"> Isaac Lab </div> | <div align="center">  Mujoco </div> |  <div align="center"> 實體 </div> |
|--- | --- | --- |
| [<img src="https://oss-global-cdn.unitree.com/static/d879adac250648c587d3681e90658b49_480x397.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_sim.gif) | [<img src="https://oss-global-cdn.unitree.com/static/3c88e045ab124c3ab9c761a99cb5e71f_480x397.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_mujoco.gif) | [<img src="https://oss-global-cdn.unitree.com/static/6c17c6cf52ec4e26bbfab1fbf591adb2_480x270.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_real.gif) |

</div>

## 安裝

- 請依照[安裝指南](https://isaac-sim.github.io/IsaacLab/main/source/setup/installation/index.html)安裝 Isaac Lab。
- 安裝 Unitree RL IsaacLab 獨立環境。

  - 請將此儲存庫與 Isaac Lab 安裝分開克隆或複製（即在 `IsaacLab` 目錄外）：

    ```bash
    git clone https://github.com/unitreerobotics/unitree_rl_lab.git
    ```
  - 使用已安裝 Isaac Lab 的 Python 直譯器，使用以下指令以可編輯模式安裝該函式庫：

    ```bash
    conda activate env_isaaclab
    python -m pip install -e source/unitree_rl_lab
    ```
- 下載 unitree usd 檔案

  - 從 [unitree_model](https://huggingface.co/datasets/unitreerobotics/unitree_model/tree/main) 下載 unitree usd 檔案，保持資料夾結構
    ```bash
    git clone https://huggingface.co/datasets/unitreerobotics/unitree_model
    ```
  - 在 `source/unitree_rl_lab/unitree_rl_lab/assets/robots/unitree.py` 中設定 `UNITREE_MODEL_DIR`。

    ```bash
    UNITREE_MODEL_DIR = "</home/user/projects/unitree_usd>"
    ```
- 驗證環境是否正確安裝，方法為：

  - 列出可用的任務：

    ```bash
    python scripts/list_envs.py
    ```
  - 執行任務：

    ```bash
    python scripts/rsl_rl/train.py --headless --task Unitree-G1-29dof-Velocity
    ```
  - 使用已訓練代理進行推理：

    ```bash
    python scripts/rsl_rl/play.py --task Unitree-G1-29dof-Velocity-Play
    ```
## 部署

在模型訓練完成後，我們需要在 Mujoco 中對訓練好的策略進行 sim2sim，以測試模型的性能。  
然後進行 sim2real 部署。

### 設定  


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

安裝 [unitree_mujoco](https://github.com/unitreerobotics/unitree_mujoco?tab=readme-ov-file#installation)。

- 將 `/simulate/config.yaml` 中的 `robot` 設為 g1
- 將 `domain_id` 設為 0
- 將 `enable_elastic_hand` 設為 1
- 將 `use_joystck` 設為 1。


```bash
# start simulation
cd unitree_mujoco/simulate/build
./unitree_mujoco
```
原始文本有 1 行。您的翻譯也必須正好有 1 行。
```bash
cd unitree_rl_lab/deploy/robots/g1/build
./g1_ctrl
# 1. press [L2 + Up] to set the robot to stand up
# 2. Click the mujoco window, and then press 8 to make the robot feet touch the ground.
# 3. Press [R1 + X] to run the policy.
# 4. Click the mujoco window, and then press 9 to disable the elastic band.
```
### Sim2Real

您可以使用此程式直接控制機器人，但請確保已關閉機器人上的控制程式。


```bash
./g1_ctrl --network eth0 # eth0 is the network interface name.
```
## 致謝

此儲存庫建立於以下開源專案的支持與貢獻之上。特別感謝：

- [IsaacLab](https://github.com/isaac-sim/IsaacLab)：訓練及執行程式碼的基礎。
- [mujoco](https://github.com/google-deepmind/mujoco.git)：提供強大的模擬功能。
- [robot_lab](https://github.com/fan-ziqi/robot_lab)：專案結構及部分實作的參考來源。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---