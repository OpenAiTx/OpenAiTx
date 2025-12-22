# ExpeRepair

**ExpeRepair** est un nouveau cadre de réparation de programmes basé sur les LLM qui accumule et réutilise continuellement les expériences de réparation historiques via un système à double mémoire. Il comprend deux composants principaux :
- **Module de Réparation de Programme** : Composé d’un Agent de Test et d’un Agent de Correctif qui gèrent en collaboration trois tâches clés — génération de tests, génération de correctifs, et validation de correctifs.
- **Module de Mémoire** : Capture les trajectoires de réparation du Module de Réparation de Programme, extrayant des démonstrations concrètes et résumant des stratégies de réparation de haut niveau. Celles-ci sont stockées dans la **mémoire épisodique** et la **mémoire sémantique**, respectivement. Lors des réparations futures, ExpeRepair récupère des démonstrations et des insights pertinents pour améliorer sa stratégie de réparation pour de nouveaux problèmes.

## 🚀 Démarrage Rapide

### Installation
```bash
git clone <repository-url>
cd ExpeRepair-v1.0
pip install -r requirements.txt
```

### Configuration de l'environnement

Définissez vos clés API en tant que variables d'environnement :
```bash
export PYTHONPATH=$PYTHONPATH:$(pwd)
# OpenAI key
export OPENAI_KEY="your-openai-key"
# Anthropic Key
export CLAUDE_KEY="your-anthropic-key"
```

Suivant [Agentless](https://arxiv.org/abs/2407.01489), ExpeRepair utilise un **format de structure de dépôt** pour localiser les fichiers suspects.  
Vous pouvez soit prétraiter les dépôts vous-même, soit télécharger les données préparées : [swebench_lite_repo_structure.zip](https://github.com/OpenAutoCoder/Agentless/releases/tag/v1.5.0).  

Après le téléchargement, décompressez et exportez son emplacement :
```bash
export PROJECT_FILE_LOC={folder which you saved}
```
Enfin, configurez le banc d'essai en suivant les instructions du [projet auto-code-rover](https://github.com/AutoCodeRoverSG/auto-code-rover#setting-up-testbed).

### Exécution de ExpeRepair sur le Benchmark Complet
1. Exécutez `run_reproduce_initial.sh` avec **tous les identifiants d’instance**.
2. Exécutez `run_localization.sh` avec **tous les identifiants d’instance**.
3. Pour les instances où la reproduction réussit (c’est-à-dire qu’un script `reproducer_X.py` valide est généré), exécutez `generate_initial.py`.
4. Pour les instances restantes, exécutez `generate_w_memory.py`, qui utilise la mémoire accumulée et continue de la mettre à jour.
5. Enfin, exécutez `validation.py` et `obtain_predictions.py` avec tous les identifiants d’instance.

### Utilisation


```bash
# reproduce the issue
bash inference/run_reproduce_initial.sh

# localize potential bug locations
bash inference/run_localization.sh

# generate candidate patches
bash inference/run_generate.sh

# validate candidate patches and select the best one
python inference/validation.py

# obtain the prediction results
python inference/obtain_predictions.py
```

## 🙏 Remerciements 

* [SWE-bench](https://www.swebench.com/)
* [auto-code-rover](https://github.com/AutoCodeRoverSG/auto-code-rover)
* [Agentless](https://github.com/OpenAutoCoder/Agentless/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---