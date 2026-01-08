<h1 align="center">🌹 Unifloral：统一的离线强化学习</h1>

<p align="center">
    <a href= "https://arxiv.org/abs/2504.11453">
        <img src="https://img.shields.io/badge/arXiv-2504.11453-b31b1b.svg" /></a>
</p>

统一实现与严格评估离线强化学习——由[Matthew Jackson](https://github.com/EmptyJackson)、[Uljad Berdica](https://github.com/uljad)和[Jarek Liesen](https://github.com/keraJLi)构建。

## 💡 代码理念

- ⚛️ **单文件**：我们将算法实现为独立的 Python 文件。
- 🤏 **极简**：只修改算法间必要部分，便于直接比较。
- ⚡️ **GPU 加速**：使用 JAX 并对所有训练代码端到端编译，实现极速训练。

灵感来自 [CORL](https://github.com/tinkoff-ai/CORL) 和 [CleanRL](https://github.com/vwxyzjn/cleanrl) ——强烈推荐！

## 🤖 算法

我们提供两种类型的算法实现：

1. **独立实现**：每个算法作为一个[单文件](algorithms)实现，依赖最小，便于理解和修改。
2. **统一实现**：大多数算法可作为我们统一实现的配置文件 [`unifloral.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/unifloral.py)使用。

训练完成后，最终评估结果保存为 `.npz` 文件，位于 [`final_returns/`](final_returns)，便于使用我们的评估协议进行分析。

所有脚本支持 [D4RL](https://github.com/Farama-Foundation/D4RL)，并使用 [Weights & Biases](https://wandb.ai) 进行日志记录，配置文件以 WandB sweep 文件形式提供。

### 无模型方法

| 算法 | 独立实现 | 统一实现 | 附加 |
| --- | --- | --- | --- |
| BC | [`bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/bc.py) | [`unifloral/bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/bc.yaml) | - |
| SAC-N | [`sac_n.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/sac_n.py) | [`unifloral/sac_n.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/sac_n.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| EDAC | [`edac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/edac.py) | [`unifloral/edac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/edac.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| CQL | [`cql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/cql.py) | - | [[ArXiv]](https://arxiv.org/abs/2006.04779) |
| IQL | [`iql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/iql.py) | [`unifloral/iql.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/iql.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.06169) |
| TD3-BC | [`td3_bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/td3_bc.py) | [`unifloral/td3_bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_bc.yaml) | [[ArXiv]](https://arxiv.org/abs/2106.06860) |
| ReBRAC | [`rebrac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/rebrac.py) | [`unifloral/rebrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/rebrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2305.09836) |
| TD3-AWR | - | [`unifloral/td3_awr.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_awr.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

### 基于模型

我们实现了一个用于动力学模型训练的单一脚本：[`dynamics.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/dynamics.py)，配置文件为[`dynamics.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/dynamics.yaml)。

| 算法 | 独立版本 | 统一版本 | 额外资料 |
| --- | --- | --- | --- |
| MOPO | [`mopo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/mopo.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.13239) |
| MOReL | [`morel.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/morel.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.05951) |
| COMBO | [`combo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/combo.py) | - | [[ArXiv]](https://arxiv.org/abs/2102.08363) |
| MoBRAC | - | [`unifloral/mobrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/mobrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

更多新算法即将推出 👀

## 📊 评估

我们的评估脚本 ([`evaluation.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/evaluation.py)) 实现了论文中描述的协议，分析了UCB赌博机在一系列策略评估中的性能。

```python
from evaluation import load_results_dataframe, bootstrap_bandit_trials
import jax.numpy as jnp

# Load all results from the final_returns directory
df = load_results_dataframe("final_returns")

# Run bandit trials with bootstrapped confidence intervals
results = bootstrap_bandit_trials(
    returns_array=jnp.array(policy_returns),  # Shape: (num_policies, num_rollouts)
    num_subsample=8,     # Number of policies to subsample
    num_repeats=1000,    # Number of bandit trials
    max_pulls=200,       # Maximum pulls per trial
    ucb_alpha=2.0,       # UCB exploration coefficient
    n_bootstraps=1000,   # Bootstrap samples for confidence intervals
    confidence=0.95      # Confidence level
)

# Access results
pulls = results["pulls"]                      # Number of pulls at each step
means = results["estimated_bests_mean"]       # Mean score of estimated best policy
ci_low = results["estimated_bests_ci_low"]    # Lower confidence bound
ci_high = results["estimated_bests_ci_high"]  # Upper confidence bound
```

## 📝 引用我们！
```bibtex
@misc{jackson2025clean,
      title={A Clean Slate for Offline Reinforcement Learning},
      author={Matthew Thomas Jackson and Uljad Berdica and Jarek Liesen and Shimon Whiteson and Jakob Nicolaus Foerster},
      year={2025},
      eprint={2504.11453},
      archivePrefix={arXiv},
      primaryClass={cs.LG},
      url={https://arxiv.org/abs/2504.11453},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-08

---