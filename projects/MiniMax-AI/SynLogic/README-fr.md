<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

Ce dépôt contient le code et les données pour SynLogic, un cadre complet de synthèse de données de raisonnement logique qui génère des données de raisonnement diversifiées et vérifiables à grande échelle. Notre travail répond au manque critique de données d’entraînement de haute qualité pour le raisonnement logique, essentielles au développement de capacités générales de raisonnement dans les grands modèles de langage (LLMs).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Actualités
- **[2025/07/07]** :fire: Nous fournissons un guide pour utiliser les données SynLogic afin de réaliser un entraînement RL avec le framework Verl. Voir [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) pour plus de détails. 

- **[2025/06/03]** :fire: Modèles entraînés disponibles sur Hugging Face :  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Nous sommes ravis d’annoncer la publication des ressources de l’article "SynLogic : Synthétiser des données de raisonnement vérifiables à grande échelle pour l’apprentissage du raisonnement logique et au-delà"

## 📋 Présentation

**SynLogic** est un cadre de synthèse de données et un jeu de données complet qui :
- 📊 **Couvre 35 tâches variées de raisonnement logique** dont Sudoku, Jeu du 24, Chiffrement, Labyrinthe de flèches, et plus encore
- 🎯 **Permet la synthèse à difficulté contrôlable** avec des paramètres ajustables pour chaque tâche
- ✅ **Fournit des récompenses vérifiables** via une vérification basée sur des règles pour l’entraînement RL
- 🚀 **Atteint des performances SOTA** parmi les jeux de données open source, surpassant DeepSeek-R1-Distill-Qwen-32B de 6 points sur BBEH

### Fonctionnalités clés
- **Génération de données évolutive** : Synthèse illimitée avec niveaux de difficulté contrôlables
- **Couverture complète des tâches** : 35 tâches distinctes de raisonnement logique avec générateurs et vérificateurs personnalisés
- **Prêt pour le RL** : Tous les exemples peuvent être vérifiés par des règles simples, ce qui les rend idéaux pour l’apprentissage par renforcement
- **Transfert inter-domaines** : Forte généralisation vers les domaines mathématiques et de programmation

## 🚀 Démarrage rapide

### Installation
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Générer des exemples de données (exemple Labyrinthe de flèches)
```bash
# Exemple rapide avec Labyrinthe de flèches
bash games/tasks/arrow_maze/run.sh

# Ou avec des paramètres personnalisés
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Pour l’entraînement RL

Nous fournissons un guide complet pour utiliser les données SynLogic dans l’entraînement par renforcement. Consultez [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) pour des instructions détaillées sur l’intégration de SynLogic avec le framework Verl.

## :rocket: Ressources

### Jeux de données
| Nom du jeu de données | Description | Lien |
|:---------------------:|:-----------|:----:|
| **SynLogic** | Jeu de données | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Modèles


| Nom du modèle | Description | Lien |
|:-------------|:-----------|:----:|
| **SynLogic-7B** | Modèle 7B entraîné sur SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | Modèle 32B entraîné sur SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | Modèle 32B entraîné sur SynLogic, Math, Coding mélangés | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Mises à jour à venir
Nous travaillons activement à l'expansion de SynLogic avec davantage de tâches de raisonnement logique.

Suivez notre dépôt pour les dernières mises à jour et publications !

## Citation
Veuillez citer notre article si vous trouvez notre travail utile :

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---