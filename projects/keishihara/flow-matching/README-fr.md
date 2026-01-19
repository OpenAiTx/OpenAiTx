
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">Anglais</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Espagnol</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italien</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Portugais</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Néerlandais</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polonais</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Turc</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Vietnamien</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Indonésien</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Flow Matching avec PyTorch

Ce dépôt contient une implémentation simple sous PyTorch de l’article [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Exemple de Flow Matching 2D

Le gif ci-dessous montre le passage d’une distribution gaussienne simple à une distribution en damier, avec visualisation du champ de vecteurs.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

Et voici un autre exemple avec le jeu de données moons.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Pour commencer

Clonez le dépôt et configurez l'environnement python.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Assurez-vous d'avoir installé Python 3.12+.
Installez `uv` :

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
Ensuite, configurez l'environnement :


```bash
uv sync
```

## Appariement de flux conditionnel [Lipman+ 2023]

Voici l’implémentation originale de l’article CFM [1]. Certains composants du code sont adaptés de [2] et [3].

### Jeux de données 2D factices

Vous pouvez entraîner les modèles CFM sur des jeux de données synthétiques 2D tels que `checkerboard` et `moons`. Spécifiez le nom du jeu de données via l’option `--dataset`. Les paramètres d’entraînement sont prédéfinis dans le script, et les visualisations des résultats d’entraînement sont stockées dans le répertoire `outputs/`. Les points de contrôle du modèle ne sont pas inclus car ils sont facilement reproductibles avec les paramètres par défaut.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

Les champs de vecteurs et les échantillons générés, comme ceux affichés sous forme de GIFs en haut de ce README, se trouvent désormais dans le répertoire `outputs/cfm/`.

### Jeux de données d’images

Vous pouvez également entraîner des modèles CFM conditionnels sur la classe sur des jeux de données populaires de classification d’images. Les échantillons générés ainsi que les points de contrôle du modèle seront stockés dans le répertoire `outputs/cfm`. Pour obtenir une liste détaillée des paramètres d’entraînement, exécutez `uv run scripts/train_flow_matching_on_image.py --help`.

Pour entraîner un CFM conditionnel sur la classe sur le jeu de données MNIST, exécutez :

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```
Après l'entraînement, vous pouvez désormais générer des échantillons avec :


```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
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
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Les résultats de l'entraînement, y compris les visualisations du champ vectoriel et les échantillons générés, sont enregistrés dans le dossier `outputs/reflow/`.

### Comparaison du processus d'échantillonnage entre CFM et Reflow

Pour comparer CFM et Reflow sur des jeux de données 2D, exécutez :

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---