<h1 align="center">🌹 Unifloral: 統一オフライン強化学習</h1>

<p align="center">
    <a href= "https://arxiv.org/abs/2504.11453">
        <img src="https://img.shields.io/badge/arXiv-2504.11453-b31b1b.svg" /></a>
</p>

オフライン強化学習の統一実装と厳密な評価 - [Matthew Jackson](https://github.com/EmptyJackson)、[Uljad Berdica](https://github.com/uljad)、[Jarek Liesen](https://github.com/keraJLi)による開発。

## 💡 コード哲学

- ⚛️ **単一ファイル**: アルゴリズムはスタンドアロンのPythonファイルとして実装。
- 🤏 **最小限**: アルゴリズム間で必要な部分のみを編集し、比較を容易に。
- ⚡️ **GPU加速**: JAXを用い、全トレーニングコードをエンドツーエンドでコンパイルし、超高速トレーニングを実現。

[CORL](https://github.com/tinkoff-ai/CORL)と[CleanRL](https://github.com/vwxyzjn/cleanrl)に触発されています - 是非ご覧ください！

## 🤖 アルゴリズム

二種類のアルゴリズム実装を提供しています：

1. **スタンドアロン**: 各アルゴリズムは最小限の依存関係で[単一ファイル](algorithms)として実装され、理解・修正が容易。
2. **統一版**: ほとんどのアルゴリズムは統一実装[`unifloral.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/unifloral.py)の設定ファイルとして利用可能。

トレーニング後、最終評価結果は分析用に[`final_returns/`](final_returns)の`.npz`ファイルに保存されます。

全スクリプトは[D4RL](https://github.com/Farama-Foundation/D4RL)をサポートし、[Weights & Biases](https://wandb.ai)を用いたログ取得に対応。設定はWandBスイープファイルで提供。

### モデルフリー

| アルゴリズム | スタンドアロン | 統一版 | 補足 |
| --- | --- | --- | --- |
| BC | [`bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/bc.py) | [`unifloral/bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/bc.yaml) | - |
| SAC-N | [`sac_n.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/sac_n.py) | [`unifloral/sac_n.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/sac_n.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| EDAC | [`edac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/edac.py) | [`unifloral/edac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/edac.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| CQL | [`cql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/cql.py) | - | [[ArXiv]](https://arxiv.org/abs/2006.04779) |
| IQL | [`iql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/iql.py) | [`unifloral/iql.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/iql.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.06169) |
| TD3-BC | [`td3_bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/td3_bc.py) | [`unifloral/td3_bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_bc.yaml) | [[ArXiv]](https://arxiv.org/abs/2106.06860) |
| ReBRAC | [`rebrac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/rebrac.py) | [`unifloral/rebrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/rebrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2305.09836) |
| TD3-AWR | - | [`unifloral/td3_awr.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_awr.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

### モデルベース

ダイナミクスモデルのトレーニング用に単一のスクリプトを実装しています: [`dynamics.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/dynamics.py)、設定は [`dynamics.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/dynamics.yaml) です。

| アルゴリズム | 単独 | 統合 | 補足 |
| --- | --- | --- | --- |
| MOPO | [`mopo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/mopo.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.13239) |
| MOReL | [`morel.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/morel.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.05951) |
| COMBO | [`combo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/combo.py) | - | [[ArXiv]](https://arxiv.org/abs/2102.08363) |
| MoBRAC | - | [`unifloral/mobrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/mobrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

新しいものが近日公開予定 👀

## 📊 評価

評価スクリプト ([`evaluation.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/evaluation.py)) は、論文で説明されているプロトコルを実装しており、UCBバンディットの性能を複数のポリシー評価にわたって解析します。

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

## 📝 引用してください！
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