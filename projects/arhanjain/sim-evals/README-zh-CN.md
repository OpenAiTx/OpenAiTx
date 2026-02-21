# DROID Sim 评估

该仓库包含用于在简单的 ISAAC Sim 环境中评估 DROID 策略的脚本。

以下是 pi0-FAST-DROID 策略的示例演示：

场景 1

![场景 1](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene1.gif)

场景 2

![场景 2](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene2.gif)

场景 3

![场景 3](https://raw.githubusercontent.com/arhanjain/sim-evals/main/./docs/scene3.gif)

该仿真被调整为与在真实世界 DROID 数据集上训练的 DROID 策略实现*零次学习*，因此无需单独的仿真数据。

**注意：** 当前模拟器最适合用于使用*关节位置*动作空间（而非*关节速度控制*）训练的策略。我们下面提供了使用关节位置控制训练的 pi0-FAST-DROID 策略评估示例。


## 安装

克隆仓库
```bash
git clone --recurse-submodules git@github.com:arhanjain/sim-evals.git
cd sim-evals
```

安装 uv（参见：https://github.com/astral-sh/uv#installation）

例如（Linux/macOS）：
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

创建并激活虚拟环境
```bash
uv sync
source .venv/bin/activate
```

## 快速开始

首先，确保将模拟资源下载到此目录的根目录中
```bash
uvx hf download owhan/DROID-sim-environments --repo-type dataset --local-dir assets
```

然后，在另一个终端上，在 `localhost:8000` 启动策略服务器。  
例如，要启动一个 pi0-FAST-DROID 策略（带关节位置控制），  
请查看 [openpi](https://github.com/Physical-Intelligence/openpi) 并使用 `polaris` 配置文件  

```bash
XLA_PYTHON_CLIENT_MEM_FRACTION=0.5 uv run scripts/serve_policy.py policy:checkpoint --policy.config=pi05_droid_jointpos_polaris --policy.dir=gs://openpi-assets/checkpoints/pi05_droid_jointpos
```

**注意**：我们设置了 `XLA_PYTHON_CLIENT_MEM_FRACTION=0.5`，以避免 JAX 独占所有 GPU 内存（以防 Isaac Sim 使用相同的 GPU）。

最后，运行评估脚本：
```bash
python run_eval.py --episodes [INT] --scene [INT] --headless
```

## 最小示例

```python
env_cfg.set_scene(scene) # pass scene integer
env = gym.make("DROID", cfg=env_cfg)

obs, _ = env.reset()
obs, _ = env.reset() # need second render cycle to get correctly loaded materials
client = # Your policy of choice

max_steps = env.env.max_episode_length
for _ in tqdm(range(max_steps), desc=f"Episode"):
    action = client.infer(obs, INSTRUCTION) # calling inference on your policy
    action = torch.tensor(ret["action"])[None]
    obs, _, term, trunc, _ = env.step(action)
    if term or trunc:
        break
env.close()
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-21

---