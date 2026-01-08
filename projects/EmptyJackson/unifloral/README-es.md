<h1 align="center">🌹 Unifloral: Aprendizaje por Refuerzo Offline Unificado</h1>

<p align="center">
    <a href= "https://arxiv.org/abs/2504.11453">
        <img src="https://img.shields.io/badge/arXiv-2504.11453-b31b1b.svg" /></a>
</p>

Implementaciones unificadas y evaluación rigurosa para el aprendizaje por refuerzo offline - desarrollado por [Matthew Jackson](https://github.com/EmptyJackson), [Uljad Berdica](https://github.com/uljad), y [Jarek Liesen](https://github.com/keraJLi).

## 💡 Filosofía del Código

- ⚛️ **Archivo único**: Implementamos algoritmos como archivos Python independientes.
- 🤏 **Mínimo**: Solo editamos lo necesario entre algoritmos, facilitando las comparaciones.
- ⚡️ **Acelerado por GPU**: Usamos JAX y compilamos todo el código de entrenamiento de extremo a extremo, permitiendo entrenamientos ultrarrápidos.

Inspirado por [CORL](https://github.com/tinkoff-ai/CORL) y [CleanRL](https://github.com/vwxyzjn/cleanrl) - ¡échales un vistazo!

## 🤖 Algoritmos

Proveemos dos tipos de implementación de algoritmos:

1. **Independiente**: Cada algoritmo está implementado como un [archivo único](algorithms) con dependencias mínimas, facilitando su comprensión y modificación.
2. **Unificado**: La mayoría de los algoritmos están disponibles como configuraciones para nuestra implementación unificada [`unifloral.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/unifloral.py).

Después del entrenamiento, los resultados finales de evaluación se guardan en archivos `.npz` en [`final_returns/`](final_returns) para análisis usando nuestro protocolo de evaluación.

Todos los scripts soportan [D4RL](https://github.com/Farama-Foundation/D4RL) y usan [Weights & Biases](https://wandb.ai) para el registro, con configuraciones provistas como archivos de barrido WandB.

### Sin modelo

| Algoritmo | Independiente | Unificado | Extras |
| --- | --- | --- | --- |
| BC | [`bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/bc.py) | [`unifloral/bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/bc.yaml) | - |
| SAC-N | [`sac_n.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/sac_n.py) | [`unifloral/sac_n.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/sac_n.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| EDAC | [`edac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/edac.py) | [`unifloral/edac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/edac.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| CQL | [`cql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/cql.py) | - | [[ArXiv]](https://arxiv.org/abs/2006.04779) |
| IQL | [`iql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/iql.py) | [`unifloral/iql.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/iql.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.06169) |
| TD3-BC | [`td3_bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/td3_bc.py) | [`unifloral/td3_bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_bc.yaml) | [[ArXiv]](https://arxiv.org/abs/2106.06860) |
| ReBRAC | [`rebrac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/rebrac.py) | [`unifloral/rebrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/rebrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2305.09836) |
| TD3-AWR | - | [`unifloral/td3_awr.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_awr.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

### Basado en modelos

Implementamos un único script para el entrenamiento del modelo de dinámica: [`dynamics.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/dynamics.py), con configuración [`dynamics.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/dynamics.yaml).

| Algoritmo | Independiente | Unificado | Extras |
| --- | --- | --- | --- |
| MOPO | [`mopo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/mopo.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.13239) |
| MOReL | [`morel.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/morel.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.05951) |
| COMBO | [`combo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/combo.py) | - | [[ArXiv]](https://arxiv.org/abs/2102.08363) |
| MoBRAC | - | [`unifloral/mobrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/mobrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

Nuevos próximamente 👀

## 📊 Evaluación

Nuestro script de evaluación ([`evaluation.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/evaluation.py)) implementa el protocolo descrito en nuestro artículo, analizando el rendimiento de un bandido UCB sobre un rango de evaluaciones de políticas.

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
## 📝 ¡Cítanos!

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