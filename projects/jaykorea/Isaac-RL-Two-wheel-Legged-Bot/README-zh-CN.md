# Isaac LAB for Flamingo

[![IsaacSim](https://img.shields.io/badge/IsaacSim-4.5-silver.svg)](https://docs.omniverse.nvidia.com/isaacsim/latest/overview.html)
[![IsaacLab](https://img.shields.io/badge/Lab-2.0.0-silver)](https://isaac-orbit.github.io/orbit/)
[![Python](https://img.shields.io/badge/python-3.10-blue.svg)](https://docs.python.org/3/whatsnew/3.10.html)
[![Linux platform](https://img.shields.io/badge/platform-linux--64-orange.svg)](https://releases.ubuntu.com/20.04/)
[![pre-commit](https://img.shields.io/badge/pre--commit-enabled-brightgreen?logo=pre-commit&logoColor=white)](https://pre-commit.com/)
[![License](https://img.shields.io/badge/license-MIT-yellow.svg)](https://opensource.org/license/mit)

## **✨ 新功能 - 更新 🚀**
✔️ **Flamingo rev.0.1.4**：添加了 Flamingo 最新版本。  
✔️ **Flamingo Edu v1**：添加了 Flamingo Edu 版本。  
✔️ **堆叠环境**：观测值可以通过参数进行堆叠。  
✔️ **约束管理器**：添加了 [作为终止条件的约束 (CaT)](https://arxiv.org/abs/2403.18765) 方法的实现。  
✔️ **CoRL**：基于 [rsl_rl](https://github.com/leggedrobotics/rsl_rl) 库，实现了 `off_policy_runner` 上的离策略算法。  

## Sim2Real - 零样本迁移
<table>
    <td><img src="https://github.com/user-attachments/assets/bb14612c-85c2-43ce-a7df-8b09ee4d3f69" width="800" height="400"/></td>
</table>
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/8f9f990d-e8e9-400a-82b2-1131ff73f891" width="385" height="170"/></td>
    <td><img src="https://github.com/user-attachments/assets/93c6b187-4680-435e-800a-9e6d3d570d13" width="385" height="170"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/9991ff73-5b3e-4d10-9b63-548197f18e54" width="385" height="170"/></td>
    <td><img src="https://github.com/user-attachments/assets/545fd258-1add-499a-8c62-520e113a951b" width="385" height="170"/></td>
  </tr>
</table>


## Isaac Lab Flamingo
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/0037889b-bab7-4686-a9a5-46ea9bbe6ac2" width="385" height="240"/></td>
    <td><img src="https://github.com/user-attachments/assets/16d8d025-7e57-479a-80d4-9cfef2cf9b6b" width="385" height="240"/></td>
  </tr>
</table>

## Sim 2 Sim 框架 - Lab 到 MuJoCo
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/edcc4077-e082-4fce-90a6-b10c94869aad" width="385" height="240"/></td>
    <td><img src="https://github.com/user-attachments/assets/df58b2db-00c6-4228-a953-eb605dee2797" width="385" height="240"/></td>
  </tr>
</table>

- 仿真到仿真框架可在 sim2sim_onnx 分支获取（目前正在迁移更新中）
- 你可以直接推理训练好的策略（基本上是从 isaac lab 导出为 .onnx）

## 安装
- 本仓库已在 Ubuntu 20.04 上测试，建议采用“本地安装”方式
### 1. 安装 Isaac Sim
  ```
  https://isaac-sim.github.io/IsaacLab/main/source/setup/installation/binaries_installation.html
  ```
### 2. 安装 Isaac Lab
  ```
  https://github.com/isaac-sim/IsaacLab
  ```

### 3. 安装 lab.flamingo 包
i. 克隆仓库
   ```
   git clone https://github.com/jaykorea/Isaac-RL-Two-wheel-Legged-Bot
   ```
ii. 通过运行以下命令安装 lab.flamingo pip 包
   - 在 'lab.flamingo' 根路径下运行该命令
   ```
   conda activate env_isaaclab # change to you conda env
   pip install -e .
   ```
iii. 在文件夹中解压资产（usd资产）  
   - 由于git无法正确上传“.usd”文件，您应手动在资产文件夹中解压usd文件
   ```
    path example: lab/flamingo/assets/data/Robots/Flamingo/flamingo_rev01_4_1/
   ```

## 启动脚本
### 训练 flamingo
  - 在 'lab.flamingo' 根路径下运行它
  ```
    python scripts/co_rl/train.py --task {task name} --algo ppo --num_envs 4096 --headless --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs}
  ```
### 训练示例 - 轨道速度
  ```
    python scripts/co_rl/train.py --task Isaac-Velocity-Flat-Flamingo-v1-ppo --algo ppo --num_envs 4096 --headless --num_policy_stacks 2 --num_critic_stacks 2
  ```
### play flamingo
  - 在 'lab.flamingo' 根路径上运行它
  ```
    python scripts/co_rl/play.py --task {task name} --algo ppo --num_envs 64 --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs} --load_run {folder name} --plot False
  ```
### 播放示例 - 音轨速度
  ```
    python scripts/co_rl/play.py --task Isaac-Velocity-Flat-Flamingo-Play-v1-ppo --algo ppo --num_envs 64 --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs} --load_run 2025-03-16_17-09-35 --plot False
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---