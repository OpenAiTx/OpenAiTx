# TopicFM+ : Amélioration de la Précision et de l’Efficacité de l’Appariement de Caractéristiques Assisté par Sujet

Ce code implémente [TopicFM+](https://arxiv.org/abs/2307.00485), qui est une extension de [TopicFM](https://arxiv.org/abs/2207.00328). Pour l’implémentation de la version précédente TopicFM, veuillez consulter la branche `aaai23_ver`.

## Exigences

Toutes les expériences de cet article sont réalisées dans un environnement Ubuntu  
avec un pilote NVIDIA d’au moins la version 430.64 et CUDA 10.1.

D’abord, créez un environnement virtuel avec anaconda comme suit,

    conda create -n topicfm python=3.8 
    conda activate topicfm
    conda install pytorch==1.12.1 torchvision==0.13.1 cudatoolkit=11.3 -c pytorch
    pip install -r requirements.txt
    # utiliser pip pour installer les paquets manquants

## Préparation des Données

La méthode proposée est entraînée sur le jeu de données MegaDepth et évaluée sur les jeux MegaDepth test, ScanNet, HPatches, Aachen Day and Night (v1.1) et InLoc.  
Tous ces jeux de données sont volumineux, nous ne pouvons donc pas les inclure dans ce code.  
Les descriptions suivantes aident à télécharger ces jeux de données.

### MegaDepth

Ce jeu de données est utilisé à la fois pour l’entraînement et l’évaluation (Li et Snavely 2018).  
Pour utiliser ce jeu de données avec notre code, veuillez suivre les [instructions de LoFTR](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md).

### ScanNet  
Nous utilisons uniquement 1500 paires d’images de ScanNet (Dai et al. 2017) pour l’évaluation.  
Veuillez télécharger et préparer les [données de test](https://drive.google.com/drive/folders/1DOcOPZb3-5cWxLqn256AhwUVjBPifhuf) de ScanNet  
fournies par [LoFTR](https://github.com/zju3dv/LoFTR/blob/master/docs/TRAINING.md).

## Entraînement

Pour entraîner notre modèle, nous recommandons d’utiliser des cartes GPU autant que possible, chaque GPU devant disposer d’au moins 12 Go.  
Dans nos paramètres, nous entraînons sur 4 GPU, chacun de 12 Go.  
Veuillez configurer votre environnement matériel dans `scripts/reproduce_train/outdoor.sh`.  
Puis exécutez cette commande pour démarrer l’entraînement.


    bash scripts/reproduce_train/outdoor.sh <chemin vers le fichier de configuration d'entraînement>
    # par exemple,
    bash scripts/reproduce_train/outdoor.sh configs/megadepth_train_topicfmfast.py

 Nous avons fourni les modèles pré-entraînés, qui ont été utilisés dans l'article ([TopicFM-fast](https://drive.google.com/file/d/1DACWdszttpiCZlk4aazhu0IDWvHkLPZf/view?usp=sharing), [TopicFM+](https://drive.google.com/file/d/1RTZJYrKQ593PBJTdxi9k5C4qZ5lSXnf0/view?usp=sharing))

## Évaluation

### MegaDepth (estimation de pose relative)

    bash scripts/reproduce_test/outdoor.sh <chemin vers le fichier de configuration dans le dossier configs> <chemin vers le modèle pré-entraîné>
    # Par exemple, pour évaluer TopicFM-fast 
    bash scripts/reproduce_test/outdoor.sh configs/megadepth_test_topicfmfast.py pretrained/topicfm_fast.ckpt

### ScanNet (estimation de pose relative)

    bash scripts/reproduce_test/indoor.sh <chemin vers le fichier de configuration dans le dossier configs> <chemin vers le modèle pré-entraîné>

### HPatches, Aachen v1.1, InLoc

Pour évaluer ces jeux de données, nous avons intégré notre code à la boîte à outils image-matching-toolbox fournie par Patch2Pix.
Le code mis à jour et les évaluations détaillées sont disponibles [ici](https://github.com/TruongKhang/image-matching-toolbox). 

### Image Matching Challenge 2023

Notre méthode TopicFM+ a obtenu un classement élevé (médaille d'argent) sur le Kaggle IMC2023 [ici](https://www.kaggle.com/competitions/image-matching-challenge-2023/leaderboard?tab=public). 

### Comparaison d'efficacité

L'évaluation de l'efficacité rapportée dans l'article a été mesurée en faisant la moyenne des temps d'exécution sur 1500 paires d'images du jeu de données d'évaluation ScanNet.
La taille de l'image peut être modifiée dans `configs/data/scannet_test_topicfmfast.py`

Nous avons calculé les coûts de calcul en GFLOPs et les temps d'exécution en ms pour LoFTR, MatchFormer, QuadTree, et AspanFormer. Cependant, ce processus a nécessité une modification mineure du code de chaque méthode individuellement. Veuillez nous contacter si vous avez besoin d'évaluations pour ces méthodes.

Ici, nous fournissons la mesure du temps d'exécution pour notre méthode, TopicFM-fast

    python visualization.py --method topicfmv2 --dataset_name scannet --config_file configs/scannet_test_topicfmfast.py  --measure_time --no_viz

Rapport de temps d'exécution à la résolution d'image (640, 480) (mesuré sur NVIDIA TITAN V 32GB de mémoire)
|   Modèle     |    640 x 480   |    1200 x 896    |
|:------------|:--------------:|:----------------:|
| TopicFM-fast|     56 ms      |      346 ms      |
| TopicFM+    |     90 ms      |      388 ms      |


## Citations
Si vous trouvez ce code utile, veuillez citer les travaux suivants :

    @article{giang2024topicfm+,
      title={Topicfm+ : Amélioration de la précision et de l'efficacité de l'appariement de caractéristiques assisté par sujet},
      author={Giang, Khang Truong et Song, Soohwan et Jo, Sungho},
      journal={IEEE Transactions on Image Processing},
      year={2024},
      publisher={IEEE}
    }

ou

    @inproceedings{giang2023topicfm,
        title={TopicFM : Appariement de caractéristiques assisté par sujet, robuste et interprétable},
        author={Giang, Khang Truong et Song, Soohwan et Jo, Sungho},
        booktitle={Actes de la Conférence AAAI sur l'Intelligence Artificielle},
        volume={37},
        number={2},
        pages={2447--2455},
        year={2023}
    }

## Remerciements
Ce code est basé sur [LoFTR](https://github.com/zju3dv/LoFTR). Nous remercions les auteurs pour leur code source utile.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---