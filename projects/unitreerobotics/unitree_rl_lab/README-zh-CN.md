# Unitree RL 实验室

[![IsaacSim](https://img.shields.io/badge/IsaacSim-4.5.0-silver.svg)](https://docs.omniverse.nvidia.com/isaacsim/latest/overview.html)
[![Isaac Lab](https://img.shields.io/badge/IsaacLab-2.0.0-silver)](https://isaac-sim.github.io/IsaacLab)
[![License](https://img.shields.io/badge/license-Apache2.0-yellow.svg)](https://opensource.org/license/apache-2-0)

## 概述

本项目提供了一套基于 [IsaacLab](https://github.com/isaac-sim/IsaacLab) 的 Unitree 机器人强化学习环境。

当前支持 Unitree **Go2**、**H1** 和 **G1-29dof** 机器人。

<div align="center">

| <div align="center"> Isaac Lab </div> | <div align="center">  Mujoco </div> |  <div align="center"> 物理实体 </div> |
|--- | --- | --- |
| [<img src="https://oss-global-cdn.unitree.com/static/d879adac250648c587d3681e90658b49_480x397.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_sim.gif) | [<img src="https://oss-global-cdn.unitree.com/static/3c88e045ab124c3ab9c761a99cb5e71f_480x397.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_mujoco.gif) | [<img src="https://oss-global-cdn.unitree.com/static/6c17c6cf52ec4e26bbfab1fbf591adb2_480x270.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_real.gif) |

</div>

## 安装

- 按照[安装指南](https://isaac-sim.github.io/IsaacLab/main/source/setup/installation/index.html)安装 Isaac Lab。
- 安装 Unitree RL IsaacLab 独立环境。

  - 将此仓库克隆或复制到 Isaac Lab 安装目录之外（即不在 `IsaacLab` 目录内）：

    ```bash
    git clone https://github.com/unitreerobotics/unitree_rl_lab.git
    ```
  - 使用已安装Isaac Lab的Python解释器，使用以下命令以可编辑模式安装该库：

    ```bash
    conda activate env_isaaclab
    python -m pip install -e source/unitree_rl_lab
    ```
- 下载 unitree usd 文件

  - 从 [unitree_model](https://huggingface.co/datasets/unitreerobotics/unitree_model/tree/main) 下载 unitree usd 文件，保持文件夹结构
    ```bash
    git clone https://huggingface.co/datasets/unitreerobotics/unitree_model
    ```
  - 在 `source/unitree_rl_lab/unitree_rl_lab/assets/robots/unitree.py` 中配置 `UNITREE_MODEL_DIR`。

    ```bash
    UNITREE_MODEL_DIR = "</home/user/projects/unitree_usd>"
    ```
- 通过以下方式验证环境是否正确安装：

  - 列出可用的任务：

    ```bash
    python scripts/list_envs.py
    ```
  - 运行任务：

    ```bash
    python scripts/rsl_rl/train.py --headless --task Unitree-G1-29dof-Velocity
    ```
  - 使用训练好的代理进行推理：

    ```bash
    python scripts/rsl_rl/play.py --task Unitree-G1-29dof-Velocity-Play
    ```
## 部署

模型训练完成后，我们需要在Mujoco中对训练好的策略进行sim2sim测试，以验证模型性能。  
然后进行sim2real部署。  

### 设置


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

安装 [unitree_mujoco](https://github.com/unitreerobotics/unitree_mujoco?tab=readme-ov-file#installation)。

- 将 `/simulate/config.yaml` 中的 `robot` 设置为 g1
- 将 `domain_id` 设置为 0
- 将 `enable_elastic_hand` 设置为 1
- 将 `use_joystck` 设置为 1。


```bash
# start simulation
cd unitree_mujoco/simulate/build
./unitree_mujoco
```
（第19部分）
```bash
cd unitree_rl_lab/deploy/robots/g1/build
./g1_ctrl
# 1. press [L2 + Up] to set the robot to stand up
# 2. Click the mujoco window, and then press 8 to make the robot feet touch the ground.
# 3. Press [R1 + X] to run the policy.
# 4. Click the mujoco window, and then press 9 to disable the elastic band.
```
### Sim2Real

您可以使用此程序直接控制机器人，但请确保板载控制程序已关闭。


```bash
./g1_ctrl --network eth0 # eth0 is the network interface name.
```
## 致谢

本仓库建立在以下开源项目的支持和贡献之上。特别感谢：

- [IsaacLab](https://github.com/isaac-sim/IsaacLab)：训练和运行代码的基础。
- [mujoco](https://github.com/google-deepmind/mujoco.git)：提供强大的仿真功能。
- [robot_lab](https://github.com/fan-ziqi/robot_lab)：项目结构和部分实现的参考。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---