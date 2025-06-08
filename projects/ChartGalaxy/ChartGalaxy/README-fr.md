![ChartGalaxy Logo](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/title.png)

## Jeu de Données
> 📦 **[👉 Accédez au jeu de données complet ChartGalaxy sur Hugging Face ! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

En raison de limitations de stockage, nous incluons uniquement une collection d'exemples représentatifs.  
Ce dépôt contient le code associé à l’article "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Actualités
**2025.5** :  🎉🎉 Nous avons publié la première version de notre jeu de données, qui comprend 1 151 087 graphiques infographiques synthétiques et 104 519 graphiques réels, couvrant 75 types de graphiques et 330 variantes.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/teaser.png" style="border:none;box-shadow:none;">

![Examples image](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/examples.png)

<!-- ## 🔔 Actualités -->

## Introduction

### À propos

ChartGalaxy est un jeu de données à grande échelle composé de graphiques infographiques synthétiques et réels accompagnés de tableaux de données, supportant des applications de compréhension de graphiques infographiques, de génération de code et de génération de graphiques. Ce jeu de données répond au problème des jeux de données existants, qui se limitent principalement à des graphiques simples, sans capturer la diversité des styles de conception et des mises en page, caractéristiques essentielles des graphiques infographiques.

### Statistiques

- **Taille** : 1 255 606 graphiques infographiques (1 151 087 synthétiques + 104 519 réels)
- **Contenu** : Chaque graphique infographique est associé au tableau de données utilisé pour le créer
- **Types de graphiques** : 75 types de graphiques avec 330 variantes
- **Modèles de mise en page** : 68 modèles de mise en page

### Collecte et Création des Données

ChartGalaxy a été construit grâce à :

1. **Collecte de graphiques infographiques réels** : Les graphiques ont été collectés sur 19 sites web réputés riches en graphiques, tels que Pinterest, Visual Capitalist, Statista et Information is Beautiful.

2. **Création de graphiques infographiques synthétiques** : En suivant un processus de structuration inductive qui :
   - Identifie 75 types de graphiques (par exemple, diagrammes en barres) et 330 variantes reflétant différents styles d’éléments visuels
   - Extrait 68 modèles de mise en page définissant les relations spatiales entre les éléments
   - Génère de manière programmatique des graphiques synthétiques basés sur ces schémas

## 🎯 Applications

L’utilité de ChartGalaxy est démontrée à travers trois applications représentatives :

### 1. 🧠 Compréhension des graphiques infographiques

L’ajustement des modèles fondamentaux sur ChartGalaxy améliore les performances pour la compréhension des graphiques infographiques.

### 2. 💻 Génération de code pour graphiques infographiques

Un banc d’essai pour évaluer la génération de code LVLMs pour les graphiques infographiques. Le benchmark évalue la similarité entre les graphiques rendus par le code D3.js généré et les graphiques de référence selon deux niveaux de granularité : haut niveau (similarité visuelle globale) et bas niveau (similarité moyenne des éléments SVG fins).

#### Aperçu

Le benchmark évalue la génération de code de graphiques à deux niveaux :
- **Bas niveau** : Similarité élément par élément entre les SVG générés et de référence
- **Haut niveau** : Évaluation de la fidélité visuelle globale et de la fonctionnalité

#### Installation

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Utilisation

1. Configurez les paramètres dans `code_generation_benchmark/configs/default_config.yaml` :
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Décommentez les modèles que vous souhaitez évaluer
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. Lancez le benchmark :
   ```bash
   python main.py
   ```

#### Structure des données

Chaque dossier de graphique dans `data_root_dir` doit contenir :
- `chart.svg` : Graphique original au format SVG

Le système génèrera :
- `convert_chart.html` : Rendu HTML du graphique de référence
- `convert_chart.png` : Capture d’écran PNG du graphique de référence
- `convert_chart.json` : Structure des éléments du graphique de référence
- Sorties spécifiques aux modèles dans des sous-dossiers

#### Résultats

Les résultats sont enregistrés dans les sous-dossiers propres à chaque modèle avec :
- Rendus HTML/PNG générés
- Indicateurs d’évaluation au format JSON
- Journaux détaillés dans `log_dir`
  

### 3. 🖼️ Génération de graphiques infographiques basée sur des exemples

Une méthode basée sur des exemples qui transforme les données tabulaires fournies par l’utilisateur en un graphique infographique, en s’alignant sur la mise en page et le style visuel d’un graphique exemple donné. Des études auprès d’utilisateurs montrent que cette méthode surpasse GPT-Image-1 en termes de fidélité, d’esthétique et de créativité.


## Contact
- chartgalaxy@163.com

## Liens des Articles

### 📌 Article Principal (Ce Dépôt)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Articles Connexes

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Citation
Si vous utilisez ChartGalaxy dans vos recherches, veuillez citer :
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---