<div align="center">

# AerialMegaDepth : Apprentissage de la Reconstruction Aérienne-Terrestre et de la Synthèse de Vue

[Khiem Vuong](https://www.khiemvuong.com/), [Anurag Ghosh](https://anuragxel.github.io/), [Deva Ramanan*](https://www.cs.cmu.edu/~deva), [Srinivasa Narasimhan*](https://www.cs.cmu.edu/~srinivas), [Shubham Tulsiani*](https://shubhtuls.github.io/)

**CVPR 2025**

[[`arXiv`](https://arxiv.org/abs/2504.13157)]
[[`Page du Projet`](https://aerial-megadepth.github.io/)]
[[`Visionneuse 3D Web`](https://aerial-megadepth.github.io/web-viewer/)]
[[`Bibtex`](#citation)]

</div>

## 📢 Actualités
- (5 sept. 2025) : Nous avons déplacé l'ensemble complet de données sur HuggingFace pour faciliter le téléchargement. Veuillez vous référer à [data_generation](data_generation) pour les instructions complètes.

## Table des Matières

- [Installation](#installation)
- [Démarrage Rapide](#quick-start)
- [Évaluation](#evaluation)
- [Génération de Données](#data-generation)
- [Remerciements](#acknowledgement)
- [Citation](#citation)
- [Problèmes](#issues)


## 📋 Avant de Commencer...
Selon ce qui vous intéresse :

- 🚀 **Si vous voulez télécharger des points de contrôle pré-entraînés et exécuter la démo** : vous pouvez continuer à lire ci-dessous.

- 🛠️ **Si vous souhaitez accéder ou générer vous-même le jeu de données** : veuillez vous référer à [data_generation](data_generation) pour les instructions complètes.

## Installation

Voici les instructions d'installation (suivant principalement le dépôt [MASt3R](https://github.com/naver/mast3r)). Nous suivons la configuration MASt3R car elle encapsule DUSt3R, mais les deux devraient fonctionner de manière similaire.


1. Cloner le dépôt :
```bash
git clone --recursive https://github.com/kvuong2711/aerial-megadepth.git
cd aerial-megadepth/mast3r

# If you already cloned the repository, you can update the submodules:
# git submodule update --init --recursive
```
2. Créer l'environnement et installer les dépendances :
```bash
conda create -n aerialmd python=3.11 cmake=3.14.0
conda activate aerialmd 
conda install pytorch torchvision pytorch-cuda=12.1 -c pytorch -c nvidia  # use the correct version of cuda for your system
pip install -r requirements.txt
pip install -r dust3r/requirements.txt
pip install -r dust3r/requirements_optional.txt
```
3. Optionnel, compiler les noyaux cuda pour RoPE (comme dans CroCo v2) :
```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../
```

## Démarrage rapide
Nos points de contrôle affinés sont entièrement compatibles avec la base de code originale DUSt3R/MASt3R/MASt3R-SfM - si vous les avez déjà configurés, vous pouvez simplement échanger le point de contrôle pour les scénarios aérien-sol !

### Points de contrôle

Il existe deux options pour télécharger les points de contrôle DUSt3R et MASt3R affinés sur notre jeu de données AerialMegaDepth :

1. Vous pouvez utiliser notre intégration huggingface_hub : les modèles ([aerial-dust3r](https://huggingface.co/kvuong2711/checkpoint-aerial-dust3r) ou [aerial-mast3r](https://huggingface.co/kvuong2711/checkpoint-aerial-mast3r)) seront téléchargés automatiquement.

2. Ou, téléchargez les points de contrôle manuellement (en utilisant [gdown](https://github.com/wkentaro/gdown), installez avec `pip install gdown`) :

```bash
# you are inside aerial-megadepth/mast3r
mkdir -p checkpoints/
gdown --fuzzy "https://drive.google.com/open?id=1wSGpYwWeGn99J8dVWNkfefwmWMAH7LFT" -O checkpoints/  # checkpoint-aerial-dust3r.pth
gdown --fuzzy "https://drive.google.com/open?id=1LrRNUQRQZcVzcioyYHYYx9ImypSZpUq2" -O checkpoints/  # checkpoint-aerial-mast3r.pth
```

### Inférence/Démo
Nous fournissons quelques images d'exemple dans le dossier [assets](assets) pour des tests rapides, y compris des images du [challenge ULTRRA](https://sites.google.com/view/ultrra-wacv-2025) et [Accenture-NVS1](https://arxiv.org/pdf/2503.18711).

Chaque script (par exemple, [demo_dust3r_nongradio.py](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mast3r/demo_dust3r_nongradio.py)) contient des chemins d'images prédéfinis pour démontrer des cas d'utilisation typiques. Vous pouvez modifier la variable `image_list` à l'intérieur du script pour essayer différentes paires. Vous pouvez exécuter l'inférence en utilisant les commandes suivantes :

- Code démo DUSt3R :
```bash
python demo_dust3r_nongradio.py --weights kvuong2711/checkpoint-aerial-dust3r

# or, if you downloaded the checkpoints manually:
# python demo_dust3r_nongradio.py --weights checkpoints/checkpoint-aerial-dust3r.pth
```

- Code de démonstration MASt3R :
```bash
python demo_mast3r_nongradio.py --weights kvuong2711/checkpoint-aerial-mast3r

# or, if you downloaded the checkpoints manually:
# python demo_mast3r_nongradio.py --weights checkpoints/checkpoint-aerial-mast3r.pth
```
![matching example](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/assets/figures/matches_figure.png)

## Évaluation

- [ ] **À FAIRE :** Les données d’évaluation seront bientôt publiées.

Une fois les données téléchargées, exécutez le script d’évaluation :
```bash
python eval.py \
    --weights checkpoints/checkpoint-aerial-dust3r.pth \
    --eval_data_dir data/eval_data_release
```
Ce script (adapté de [PoseDiffusion](https://github.com/facebookresearch/PoseDiffusion)) rapporte RRA et RTA à différents seuils en degrés.

## Génération des données
Pour des instructions sur la manière de télécharger et/ou de générer les données, veuillez vous référer à [data_generation](data_generation).

## Remerciements
Cette base de code s’appuie sur de nombreux excellents projets open-source, tels que [MegaDepth](https://www.cs.cornell.edu/projects/megadepth), [DUSt3R](https://github.com/naver/dust3r), [hloc](https://github.com/cvg/Hierarchical-Localization), [COLMAP](https://github.com/colmap/colmap), etc. Nous remercions les auteurs respectifs pour avoir rendu leur travail public.

## Citation
Si vous trouvez notre travail utile pour votre recherche, veuillez envisager de citer notre article :

```bibtex
@inproceedings{vuong2025aerialmegadepth,
  title={AerialMegaDepth: Learning Aerial-Ground Reconstruction and View Synthesis},
  author={Vuong, Khiem and Ghosh, Anurag and Ramanan, Deva and Narasimhan, Srinivasa and Tulsiani, Shubham},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  year={2025},
}
```

## Problèmes
Si vous avez un problème/question/suggestion, n'hésitez pas à créer un ticket ou à me contacter directement par [email](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mailto:kvuong@andrew.cmu.edu).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---