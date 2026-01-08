<h1 align="center">🌹 Unifloral : Apprentissage par Renforcement Hors Ligne Unifié</h1>

<p align="center">
    <a href= "https://arxiv.org/abs/2504.11453">
        <img src="https://img.shields.io/badge/arXiv-2504.11453-b31b1b.svg" /></a>
</p>

Implémentations unifiées et évaluation rigoureuse pour l'apprentissage par renforcement hors ligne - développé par [Matthew Jackson](https://github.com/EmptyJackson), [Uljad Berdica](https://github.com/uljad), et [Jarek Liesen](https://github.com/keraJLi).

## 💡 Philosophie du Code

- ⚛️ **Fichier unique** : Nous implémentons les algorithmes sous forme de fichiers Python autonomes.
- 🤏 **Minimaliste** : Nous modifions uniquement ce qui est nécessaire entre les algorithmes, facilitant les comparaisons.
- ⚡️ **Accéléré par GPU** : Nous utilisons JAX et compilons de bout en bout tout le code d'entraînement, permettant un entraînement ultra-rapide.

Inspiré par [CORL](https://github.com/tinkoff-ai/CORL) et [CleanRL](https://github.com/vwxyzjn/cleanrl) - allez les découvrir !

## 🤖 Algorithmes

Nous fournissons deux types d'implémentation d'algorithmes :

1. **Autonome** : Chaque algorithme est implémenté comme un [fichier unique](algorithms) avec des dépendances minimales, ce qui facilite la compréhension et la modification.
2. **Unifié** : La plupart des algorithmes sont disponibles sous forme de configurations pour notre implémentation unifiée [`unifloral.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/unifloral.py).

Après l'entraînement, les résultats finaux d'évaluation sont sauvegardés dans des fichiers `.npz` dans [`final_returns/`](final_returns) pour analyse selon notre protocole d'évaluation.

Tous les scripts supportent [D4RL](https://github.com/Farama-Foundation/D4RL) et utilisent [Weights & Biases](https://wandb.ai) pour la journalisation, avec des configurations fournies en fichiers WandB sweep.

### Sans modèle

| Algorithme | Autonome | Unifié | Extras |
| --- | --- | --- | --- |
| BC | [`bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/bc.py) | [`unifloral/bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/bc.yaml) | - |
| SAC-N | [`sac_n.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/sac_n.py) | [`unifloral/sac_n.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/sac_n.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| EDAC | [`edac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/edac.py) | [`unifloral/edac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/edac.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.01548) |
| CQL | [`cql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/cql.py) | - | [[ArXiv]](https://arxiv.org/abs/2006.04779) |
| IQL | [`iql.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/iql.py) | [`unifloral/iql.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/iql.yaml) | [[ArXiv]](https://arxiv.org/abs/2110.06169) |
| TD3-BC | [`td3_bc.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/td3_bc.py) | [`unifloral/td3_bc.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_bc.yaml) | [[ArXiv]](https://arxiv.org/abs/2106.06860) |
| ReBRAC | [`rebrac.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/rebrac.py) | [`unifloral/rebrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/rebrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2305.09836) |
| TD3-AWR | - | [`unifloral/td3_awr.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/td3_awr.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

### Basé sur un modèle

Nous implémentons un script unique pour l'entraînement du modèle de dynamique : [`dynamics.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/dynamics.py), avec la configuration [`dynamics.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/dynamics.yaml).

| Algorithme | Autonome | Unifié | Extras |
| --- | --- | --- | --- |
| MOPO | [`mopo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/mopo.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.13239) |
| MOReL | [`morel.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/morel.py) | - | [[ArXiv]](https://arxiv.org/abs/2005.05951) |
| COMBO | [`combo.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/algorithms/combo.py) | - | [[ArXiv]](https://arxiv.org/abs/2102.08363) |
| MoBRAC | - | [`unifloral/mobrac.yaml`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/configs/unifloral/mobrac.yaml) | [[ArXiv]](https://arxiv.org/abs/2504.11453) |

De nouvelles versions arrivent bientôt 👀

## 📊 Évaluation

Notre script d’évaluation ([`evaluation.py`](https://raw.githubusercontent.com/EmptyJackson/unifloral/main/evaluation.py)) implémente le protocole décrit dans notre article, analysant la performance d’un bandit UCB sur une série d’évaluations de politiques.

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

## 📝 Citez-nous !
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