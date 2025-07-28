# Isaac LAB for Flamingo

[![IsaacSim](https://img.shields.io/badge/IsaacSim-4.5-silver.svg)](https://docs.omniverse.nvidia.com/isaacsim/latest/overview.html)
[![IsaacLab](https://img.shields.io/badge/Lab-2.0.0-silver)](https://isaac-orbit.github.io/orbit/)
[![Python](https://img.shields.io/badge/python-3.10-blue.svg)](https://docs.python.org/3/whatsnew/3.10.html)
[![Linux platform](https://img.shields.io/badge/platform-linux--64-orange.svg)](https://releases.ubuntu.com/20.04/)
[![pre-commit](https://img.shields.io/badge/pre--commit-enabled-brightgreen?logo=pre-commit&logoColor=white)](https://pre-commit.com/)
[![License](https://img.shields.io/badge/license-MIT-yellow.svg)](https://opensource.org/license/mit)

## **✨ 새로운 기능 - 업데이트 🚀**
✔️ **Flamingo rev.0.1.4**: 최신 버전의 Flamingo 추가.  
✔️ **Flamingo Edu v1**: Flamingo Edu 버전 추가.  
✔️ **스택 환경**: 인수와 함께 관측값을 스택할 수 있음.  
✔️ **제약 조건 관리자**: [종료 조건으로서의 제약 (CaT)](https://arxiv.org/abs/2403.18765) 방법 구현 추가.  
✔️ **CoRL**: [rsl_rl](https://github.com/leggedrobotics/rsl_rl) 라이브러리를 기반으로 오프폴리시 알고리즘이 `off_policy_runner`에 구현됨.  

## Sim2Real - 제로샷 전이
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

## Sim 2 Sim 프레임워크 - Lab에서 MuJoCo로
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/edcc4077-e082-4fce-90a6-b10c94869aad" width="385" height="240"/></td>
    <td><img src="https://github.com/user-attachments/assets/df58b2db-00c6-4228-a953-eb605dee2797" width="385" height="240"/></td>
  </tr>
</table>

- 시뮬레이션 간 프레임워크는 sim2sim_onnx 브랜치에서 사용할 수 있음 (현재 마이그레이션 업데이트 중)
- 훈련된 정책을 간단히 추론할 수 있음 (기본적으로 isaac lab에서 .onnx로 내보내기)

## 설치
- 이 저장소는 Ubuntu 20.04에서 테스트되었으며, '로컬 설치'를 권장합니다.
### 1. Isaac Sim 설치
  ```
  https://isaac-sim.github.io/IsaacLab/main/source/setup/installation/binaries_installation.html
  ```
### 2. 아이작 랩 설치
  ```
  https://github.com/isaac-sim/IsaacLab
  ```

### 3. lab.flamingo 패키지 설치
i. 저장소 복제하기
   ```
   git clone https://github.com/jaykorea/Isaac-RL-Two-wheel-Legged-Bot
   ```
ii. 아래 명령어를 실행하여 lab.flamingo pip 패키지를 설치하십시오
   - 'lab.flamingo' 루트 경로에서 실행하십시오
   ```
   conda activate env_isaaclab # change to you conda env
   pip install -e .
   ```
iii. 폴더 내 자산(usd 자산) 압축 해제  
   - git이 '.usd' 파일을 올바르게 업로드하지 않으므로, 자산 폴더 내 usd 파일을 수동으로 압축 해제해야 합니다
   ```
    path example: lab/flamingo/assets/data/Robots/Flamingo/flamingo_rev01_4_1/
   ```

## 실행 스크립트
### 플라밍고 훈련
  - 'lab.flamingo' 루트 경로에서 실행하십시오
  ```
    python scripts/co_rl/train.py --task {task name} --algo ppo --num_envs 4096 --headless --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs}
  ```
### 학습 예제 - 트랙 속도
  ```
    python scripts/co_rl/train.py --task Isaac-Velocity-Flat-Flamingo-v1-ppo --algo ppo --num_envs 4096 --headless --num_policy_stacks 2 --num_critic_stacks 2
  ```
### play flamingo
  - 'lab.flamingo' 루트 경로에서 실행하세요
  ```
    python scripts/co_rl/play.py --task {task name} --algo ppo --num_envs 64 --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs} --load_run {folder name} --plot False
  ```
### 연주 예시 - 트랙 벨로시티
  ```
    python scripts/co_rl/play.py --task Isaac-Velocity-Flat-Flamingo-Play-v1-ppo --algo ppo --num_envs 64 --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs} --load_run 2025-03-16_17-09-35 --plot False
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---