# Isaac LAB for Flamingo

[![IsaacSim](https://img.shields.io/badge/IsaacSim-4.5-silver.svg)](https://docs.omniverse.nvidia.com/isaacsim/latest/overview.html)
[![IsaacLab](https://img.shields.io/badge/Lab-2.0.0-silver)](https://isaac-orbit.github.io/orbit/)
[![Python](https://img.shields.io/badge/python-3.10-blue.svg)](https://docs.python.org/3/whatsnew/3.10.html)
[![Linux platform](https://img.shields.io/badge/platform-linux--64-orange.svg)](https://releases.ubuntu.com/20.04/)
[![pre-commit](https://img.shields.io/badge/pre--commit-enabled-brightgreen?logo=pre-commit&logoColor=white)](https://pre-commit.com/)
[![License](https://img.shields.io/badge/license-MIT-yellow.svg)](https://opensource.org/license/mit)

## **✨ 新機能 - 更新 🚀**
✔️ **Flamingo rev.0.1.4**: 最新版のFlamingoを追加。  
✔️ **Flamingo Edu v1**: Flamingo Eduバージョンを追加。  
✔️ **スタック環境**: 観測を引数でスタック可能に。  
✔️ **制約マネージャー**: [Constraints as Termination (CaT)](https://arxiv.org/abs/2403.18765) メソッドの実装を追加。  
✔️ **CoRL**: [rsl_rl](https://github.com/leggedrobotics/rsl_rl)ライブラリに基づき、オフポリシーアルゴリズムを`off_policy_runner`で実装。  

## Sim2Real - ZeroShot転送
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

## Sim 2 Sim フレームワーク - LabからMuJoCoへ
<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/edcc4077-e082-4fce-90a6-b10c94869aad" width="385" height="240"/></td>
    <td><img src="https://github.com/user-attachments/assets/df58b2db-00c6-4228-a953-eb605dee2797" width="385" height="240"/></td>
  </tr>
</table>

- シミュレーション間フレームワークはsim2sim_onnxブランチで利用可能（現在移行更新中）
- 学習済みポリシーを簡単に推論可能（基本的にIsaac Labから.onnx形式でエクスポート）

## セットアップ
- 本リポジトリはUbuntu 20.04でテスト済み、'ローカルインストール'を推奨
### 1. Isaac Simのインストール
  ```
  https://isaac-sim.github.io/IsaacLab/main/source/setup/installation/binaries_installation.html
  ```
### 2. Isaac Labのインストール
  ```
  https://github.com/isaac-sim/IsaacLab
  ```

### 3. lab.flamingo パッケージのインストール
i. リポジトリをクローンする
   ```
   git clone https://github.com/jaykorea/Isaac-RL-Two-wheel-Legged-Bot
   ```
ii. 以下のコマンドを実行して lab.flamingo の pip パッケージをインストールします  
   - 'lab.flamingo' のルートパスで実行してください
   ```
   conda activate env_isaaclab # change to you conda env
   pip install -e .
   ```
iii. フォルダ内のアセット（usdアセット）を解凍する  
   - gitは'.usd'ファイルを正しくアップロードしないため、アセットフォルダ内のusdファイルを手動で解凍する必要があります
   ```
    path example: lab/flamingo/assets/data/Robots/Flamingo/flamingo_rev01_4_1/
   ```

## 起動スクリプト
### フラミンゴのトレーニング
  - 'lab.flamingo' のルートパスで実行する
  ```
    python scripts/co_rl/train.py --task {task name} --algo ppo --num_envs 4096 --headless --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs}
  ```
### トレイン例 - 軌道速度
  ```
    python scripts/co_rl/train.py --task Isaac-Velocity-Flat-Flamingo-v1-ppo --algo ppo --num_envs 4096 --headless --num_policy_stacks 2 --num_critic_stacks 2
  ```
### フラミンゴを実行する
  - 'lab.flamingo' のルートパスで実行する
  ```
    python scripts/co_rl/play.py --task {task name} --algo ppo --num_envs 64 --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs} --load_run {folder name} --plot False
  ```
### 再生例 - トラックのベロシティー
  ```
    python scripts/co_rl/play.py --task Isaac-Velocity-Flat-Flamingo-Play-v1-ppo --algo ppo --num_envs 64 --num_policy_stacks {stack number on policy obs} --num_critic_stacks {stack number on critic obs} --load_run 2025-03-16_17-09-35 --plot False
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---