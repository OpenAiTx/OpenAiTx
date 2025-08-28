<div align="center">

<!-- TITLE -->
# **Les Modèles de Langage par Diffusion sont des Super Apprenants de Données**

[![Static Badge](https://img.shields.io/badge/Blog-2025--08--09-darkcyan)](https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/cloudposse.svg?style=social&label=tweet)](https://x.com/NiJinjie/status/1954177095435014533)
</div>

# Points forts
- Nous avons pré-entraîné des DLMs et des modèles AR à partir de zéro jusqu’à **8 milliards de paramètres** et **480 milliards de tokens**. Les DLMs démontrent un potentiel de données > **3x** supérieur comparé aux modèles autorégressifs (AR). Notamment, un modèle de diffusion masqué de 1 milliard de paramètres atteint > **56 %** de précision sur HellaSwag et > **33 %** sur MMLU en utilisant seulement **1 milliard** de tokens, sans aucune astuce spéciale, simplement en répétant les données standard de pré-entraînement. Notez que plus de répétitions pourraient encore améliorer ses performances, car **aucun signe de rendement décroissant** n’a été observé.
- Les DLMs sont des modèles super-denses qui consomment plus de FLOPs que les modèles AR denses. L’entraînement des DLMs pour exploiter pleinement les données nécessite typiquement au moins **deux ordres de grandeur** de FLOPs supplémentaires. Lors de l’inférence, générer des séquences de 16 à 4096 tokens entraîne une augmentation des FLOPs de **16× à 4700×** comparé aux bases AR. De plus, l’attention bidirectionnelle plus expressive permise par l’objectif de diffusion permet une **modélisation bidirectionnelle des données linguistiques**, qui ne sont pas totalement causales, afin d’en extraire toute la valeur.
- Notre travail simultané, « Diffusion Beats Autoregressive in Data-Constrained Settings », contient des problèmes méthodologiques critiques pouvant conduire à des conclusions problématiques, incluant **une formulation problématique de la perte de diffusion, des métriques invalides pour la comparaison, des conditions inéquitables pour les modèles AR, et une formulation problématique de la loi d’échelle.** Tous ces points peuvent mener à des résultats et conclusions douteux.

<br>

# Le Point de Croisement
<p align="center" width="100%">
<img src="https://raw.githubusercontent.com/JinjieNi/dlms-are-super-data-learners/main/resources/imgs/1.jpg"  width="80%" height="100%">
</p>

*Figure A du blog : Comparaison des performances des modèles autorégressifs (AR) et des modèles de diffusion masqués (Diffusion) lors de répétitions sur une portion limitée de données. Tous les modèles sont entraînés sur un total de 96 milliards de tokens (y compris répétition), variant les tokens uniques de 0,5 à 96 milliards. Les modèles de diffusion exploitent mieux les données grâce à plus de répétitions sur des données uniques limitées. Plus il y a de tokens uniques, plus il faut de répétitions pour observer le point de croisement, où les exécutions avec beaucoup de tokens uniques repoussent ce point au-delà de notre portée d’observation de 96 milliards de tokens.*

<br>

# Citation
```
@misc{ni2025difflm,
title={Diffusion Language Models are Super Data Learners},
author={Jinjie Ni and the team},
year={2025},
howpublished={\url{https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac}},
note={Notion Blog},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---