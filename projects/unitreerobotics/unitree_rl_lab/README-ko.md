# Unitree RL Lab

[![IsaacSim](https://img.shields.io/badge/IsaacSim-4.5.0-silver.svg)](https://docs.omniverse.nvidia.com/isaacsim/latest/overview.html)
[![Isaac Lab](https://img.shields.io/badge/IsaacLab-2.0.0-silver)](https://isaac-sim.github.io/IsaacLab)
[![License](https://img.shields.io/badge/license-Apache2.0-yellow.svg)](https://opensource.org/license/apache-2-0)

## 개요

이 프로젝트는 [IsaacLab](https://github.com/isaac-sim/IsaacLab) 위에 구축된 Unitree 로봇용 강화 학습 환경 세트를 제공합니다.

현재 Unitree **Go2**, **H1** 및 **G1-29dof** 로봇을 지원합니다.

<div align="center">

| <div align="center"> Isaac Lab </div> | <div align="center">  Mujoco </div> |  <div align="center"> Physical </div> |
|--- | --- | --- |
| [<img src="https://oss-global-cdn.unitree.com/static/d879adac250648c587d3681e90658b49_480x397.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_sim.gif) | [<img src="https://oss-global-cdn.unitree.com/static/3c88e045ab124c3ab9c761a99cb5e71f_480x397.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_mujoco.gif) | [<img src="https://oss-global-cdn.unitree.com/static/6c17c6cf52ec4e26bbfab1fbf591adb2_480x270.gif" width="240px">](https://raw.githubusercontent.com/unitreerobotics/unitree_rl_lab/main/g1_real.gif) |

</div>

## 설치

- [설치 가이드](https://isaac-sim.github.io/IsaacLab/main/source/setup/installation/index.html)를 따라 Isaac Lab을 설치하세요.
- Unitree RL IsaacLab 독립 환경을 설치하세요.

  - 이 저장소를 Isaac Lab 설치와 별도로 복제하거나 복사하세요 (즉, `IsaacLab` 디렉터리 외부에):

    ```bash
    git clone https://github.com/unitreerobotics/unitree_rl_lab.git
    ```
  - Isaac Lab이 설치된 파이썬 인터프리터를 사용하고, 편집 가능한 모드로 라이브러리를 설치하려면 다음을 사용하세요:

    ```bash
    conda activate env_isaaclab
    python -m pip install -e source/unitree_rl_lab
    ```
- unitree usd 파일 다운로드

  - 폴더 구조를 유지하며 [unitree_model](https://huggingface.co/datasets/unitreerobotics/unitree_model/tree/main)에서 unitree usd 파일 다운로드
    ```bash
    git clone https://huggingface.co/datasets/unitreerobotics/unitree_model
    ```
  - `source/unitree_rl_lab/unitree_rl_lab/assets/robots/unitree.py`에서 `UNITREE_MODEL_DIR` 구성.

    ```bash
    UNITREE_MODEL_DIR = "</home/user/projects/unitree_usd>"
    ```
- 환경이 올바르게 설치되었는지 확인하려면 다음을 수행하십시오:

  - 사용 가능한 작업 나열:

    ```bash
    python scripts/list_envs.py
    ```
  - 작업 실행:

    ```bash
    python scripts/rsl_rl/train.py --headless --task Unitree-G1-29dof-Velocity
    ```
  - 훈련된 에이전트로 추론하기:

    ```bash
    python scripts/rsl_rl/play.py --task Unitree-G1-29dof-Velocity-Play
    ```
## 배포

모델 학습이 완료된 후, 학습된 전략에 대해 Mujoco에서 sim2sim을 수행하여 모델의 성능을 테스트해야 합니다.  
그런 다음 sim2real을 배포합니다.  

### 설정


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

[unitree_mujoco](https://github.com/unitreerobotics/unitree_mujoco?tab=readme-ov-file#installation)를 설치합니다.

- `/simulate/config.yaml`에서 `robot`을 g1으로 설정합니다.
- `domain_id`를 0으로 설정합니다.
- `enable_elastic_hand`를 1로 설정합니다.
- `use_joystck`를 1로 설정합니다.


```bash
# start simulation
cd unitree_mujoco/simulate/build
./unitree_mujoco
```
원본 텍스트에는 1개의 행이 있습니다. 번역문도 정확히 1개의 행을 포함해야 합니다.
```bash
cd unitree_rl_lab/deploy/robots/g1/build
./g1_ctrl
# 1. press [L2 + Up] to set the robot to stand up
# 2. Click the mujoco window, and then press 8 to make the robot feet touch the ground.
# 3. Press [R1 + X] to run the policy.
# 4. Click the mujoco window, and then press 9 to disable the elastic band.
```
### Sim2Real

이 프로그램을 사용하여 로봇을 직접 제어할 수 있지만, 반드시 온보드 제어 프로그램이 종료되었는지 확인하십시오.


```bash
./g1_ctrl --network eth0 # eth0 is the network interface name.
```
## 감사의 글

이 저장소는 다음 오픈 소스 프로젝트들의 지원과 기여 위에 구축되었습니다. 특별한 감사의 말씀을 전합니다:

- [IsaacLab](https://github.com/isaac-sim/IsaacLab): 학습 및 실행 코드를 위한 기반.
- [mujoco](https://github.com/google-deepmind/mujoco.git): 강력한 시뮬레이션 기능 제공.
- [robot_lab](https://github.com/fan-ziqi/robot_lab): 프로젝트 구조 및 일부 구현 참고.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---