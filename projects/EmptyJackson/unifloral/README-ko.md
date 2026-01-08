<h1 align="center">🌹 Unifloral: 통합 오프라인 강화학습</h1>

<p align="center">
    <a href= "https://arxiv.org/abs/2504.11453">
        <img src="https://img.shields.io/badge/arXiv-2504.11453-b31b1b.svg" /></a>
</p>

오프라인 강화학습을 위한 통합 구현 및 엄격한 평가 - [Matthew Jackson](https://github.com/EmptyJackson), [Uljad Berdica](https://github.com/uljad), [Jarek Liesen](https://github.com/keraJLi)가 제작.

## 💡 코드 철학

- ⚛️ **단일 파일**: 알고리즘을 독립적인 Python 파일로 구현합니다.
- 🤏 **최소한**: 알고리즘 간 필요한 부분만 수정하여 비교를 쉽게 합니다.
- ⚡️ **GPU 가속**: JAX를 사용하고 모든 학습 코드를 종단 간 컴파일하여 매우 빠른 학습을 가능하게 합니다.

[CORL](https://github.com/tinkoff-ai/CORL)과 [CleanRL](https://github.com/vwxyzjn/cleanrl)에서 영감을 받았습니다 - 확인해보세요!

## 🤖 알고리즘

두 가지 유형의 알고리즘 구현을 제공합니다:

1. **독립형**: 각 알고리즘은 최소한의 종속성을 가진 [단일 파일](algorithms)로 구현되어 이해 및 수정이 쉽습니다.
2. **통합형**: 대부분의 알고리즘은 통합 구현 [`unifloral.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/unifloral.py)의 설정 파일로 제공됩니다.

학습 후 최종 평가 결과는 분석을 위해 [`final_returns/`](final_returns) 폴더 내 `.npz` 파일로 저장됩니다.

모든 스크립트는 [D4RL](https://github.com/Farama-Foundation/D4RL)을 지원하며, 로깅에는 [Weights & Biases](https://wandb.ai)를 사용하며, 설정은 WandB 스윕 파일로 제공됩니다.

### 모델 프리

| 알고리즘 | 독립형 | 통합형 | 추가 정보 |
| --- | --- | --- | --- |
| BC | [`bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/bc.py) | [`unifloral/bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/bc.yaml) | - |
| SAC-N | [`sac_n.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/sac_n.py) | [`unifloral/sac_n.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/sac_n.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| EDAC | [`edac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/edac.py) | [`unifloral/edac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/edac.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| CQL | [`cql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/cql.py) | - | [[ArXiv]](https://arxiv.org/abs/2006.04779) |
| IQL | [`iql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/iql.py) | [`unifloral/iql.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/iql.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.06169) |
| TD3-BC | [`td3_bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/td3_bc.py) | [`unifloral/td3_bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_bc.yaml) | [[ArXiv]](https://arxiv.org/abs/2106.06860) |
| ReBRAC | [`rebrac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/rebrac.py) | [`unifloral/rebrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/rebrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2305.09836) |
| TD3-AWR | - | [`unifloral/td3_awr.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_awr.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |
### 모델 기반

우리는 동역학 모델 학습을 위한 단일 스크립트 [`dynamics.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/dynamics.py)를 구현했으며, 구성 파일은 [`dynamics.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/dynamics.yaml)입니다.

| 알고리즘 | 독립 실행형 | 통합형 | 추가 자료 |
| --- | --- | --- | --- |
| MOPO | [`mopo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/mopo.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.13239) |
| MOReL | [`morel.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/morel.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.05951) |
| COMBO | [`combo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/combo.py) | - | [[ArXiv]](https://arxiv.org/abs/2102.08363) |
| MoBRAC | - | [`unifloral/mobrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/mobrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

새로운 알고리즘 곧 공개 예정 👀

## 📊 평가

우리의 평가 스크립트([`evaluation.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/evaluation.py))는 논문에 기술된 프로토콜을 구현하며, 다양한 정책 평가에서 UCB 밴딧의 성능을 분석합니다.


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
## 📝 우리를 인용하세요!

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