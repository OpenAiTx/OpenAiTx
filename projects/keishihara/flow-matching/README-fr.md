# Appariement de Flux dans PyTorch

Ce dépôt contient une implémentation simple en PyTorch de l'article [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Exemple d'Appariement de Flux 2D

Le gif ci-dessous montre la transformation d'une distribution gaussienne unique en une distribution en damier, avec le champ vectoriel visualisé.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_checkerboard.gif" height="400" />
</p>

Et, voici un autre exemple avec le jeu de données moons.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_moons.gif" height="400" />
</p>

## Pour Commencer

Clonez le dépôt et configurez l'environnement python.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Assurez-vous d'avoir Python 3.10+ installé.  
Pour configurer l'environnement python en utilisant `uv` :  

```bash
uv sync
source .venv/bin/activate
```

Alternativement, en utilisant `pip` :

```bash
python -m venv .venv
source .venv/bin/activate
pip install -e .
```

## Appariement de flux conditionnel [Lipman+ 2023]

Voici l’implémentation originale de l’article CFM [1]. Certains composants du code sont adaptés de [2] et [3].

### Jeux de données 2D factices

Vous pouvez entraîner les modèles CFM sur des jeux de données synthétiques 2D tels que `checkerboard` et `moons`. Spécifiez le nom du jeu de données via l’option `--dataset`. Les paramètres d’entraînement sont prédéfinis dans le script, et les visualisations des résultats d’entraînement sont stockées dans le répertoire `outputs/`. Les points de contrôle du modèle ne sont pas inclus car ils sont facilement reproductibles avec les paramètres par défaut.

```bash
python train_flow_matching_2d.py --dataset checkerboard
```

Les champs de vecteurs et les échantillons générés, comme ceux affichés en GIF en haut de ce README, se trouvent désormais dans le répertoire `outputs/cfm/`.

### Jeux de données d'images

Vous pouvez également entraîner des modèles CFM conditionnels par classe sur des jeux de données d'imagerie populaires. Les échantillons générés ainsi que les points de contrôle du modèle seront stockés dans le répertoire `outputs/cfm`. Pour une liste détaillée des paramètres d'entraînement, exécutez `python train_flow_matching_on_images.py --help`.

Pour entraîner un CFM conditionnel par classe sur le jeu de données MNIST, exécutez :

```bash
python train_flow_matching_on_image.py --do_train --dataset mnist
```
Après l'entraînement, vous pouvez désormais générer des échantillons avec :


```bash
python train_flow_matching_on_image.py --do_sample --dataset mnist
```

Now, you should be able to see the generated samples in the `outputs/cfm/mnist/` directory.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Flux Rectifié [Liu+ 2023]

Ceci est une implémentation du modèle Reflow (2-Flux Rectifié pour être précis) issu de l’article Rectified Flow [2].

### Données Synthétiques 2D

Nous avons implémenté le Reflow sur des ensembles de données synthétiques 2D, de la même manière que le CFM. Pour entraîner le reflow, vous devez spécifier des points de contrôle CFM pré-entraînés, car le reflow est un modèle de distillation.

Par exemple, pour entraîner sur l’ensemble de données `checkerboard` avec un point de contrôle CFM pré-entraîné :

```bash
python train_reflow_2d.py --dataset checkerboard --pretrained-model outputs/cfm/checkerboard/ckpt.pth
```

Les résultats de l'entraînement, y compris les visualisations du champ vectoriel et les échantillons générés, sont enregistrés dans le dossier `outputs/reflow/`.

### Comparaison du processus d'échantillonnage entre CFM et Reflow

Pour comparer CFM et Reflow sur des jeux de données 2D, exécutez :

```bash
python plot_comparison_2d.py --dataset checkerboard
```

Les GIFs résultants peuvent être trouvés dans le dossier `outputs/comparisons/`. Voici un exemple de comparaison des deux méthodes sur le jeu de données `checkerboard` :

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Références

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---