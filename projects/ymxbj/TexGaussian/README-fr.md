<h1 align="center">TexGaussian : Génération de matériaux PBR de haute qualité via Splatting Gaussien 3D basé sur Octree</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Les matériaux Physically Based Rendering (PBR) jouent un rôle crucial dans les graphismes modernes, permettant un rendu photoréaliste sur des cartes d'environnement variées. Développer un algorithme efficace et performant, capable de générer automatiquement des matériaux PBR de haute qualité plutôt qu'une simple texture RGB pour des maillages 3D, peut considérablement simplifier la création de contenu 3D. La plupart des méthodes existantes utilisent des modèles de diffusion 2D pré-entraînés pour la synthèse d'images multi-vues, ce qui conduit souvent à une forte incohérence entre les textures générées et les maillages 3D d'entrée. Cet article présente TexGaussian, une méthode innovante qui utilise le splatting gaussien 3D aligné par octant pour une génération rapide de matériaux PBR. Concrètement, nous plaçons chaque gaussienne 3D sur le nœud feuille le plus fin de l'octree construit à partir du maillage 3D d'entrée pour rendre les images multi-vues non seulement pour la carte d'albédo mais aussi pour la rugosité et le métallique. De plus, notre modèle est entraîné de manière régressive au lieu d'un débruitage par diffusion, ce qui permet de générer le matériau PBR pour un maillage 3D en un seul passage avant. De nombreuses expériences sur des benchmarks publics démontrent que notre méthode synthétise des matériaux PBR visuellement plus agréables et fonctionne plus rapidement que les méthodes précédentes dans les scénarios inconditionnels et conditionnés par texte, tout en présentant une meilleure cohérence avec la géométrie donnée.

## 📦 Installation

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# un splatting gaussien modifié (+ profondeur, rendu alpha)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# autres dépendances
pip3 install -r requirements.txt
```

## 🤖 Modèles pré-entraînés

Nous fournissons les modèles pré-entraînés suivants :

| Modèle | Description | Paramètres | Télécharger |
| --- | --- | --- | --- |
| TexGaussian-bench | Modèle de texture RGB inconditionnel entraîné sur ShapeNet bench | 70M | [Télécharger](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Modèle de texture RGB inconditionnel entraîné sur ShapeNet car | 70M | [Télécharger](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Modèle de texture RGB inconditionnel entraîné sur ShapeNet chair | 70M | [Télécharger](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Modèle de texture RGB inconditionnel entraîné sur ShapeNet table | 70M | [Télécharger](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Modèle de matériau PBR conditionné par texte entraîné sur Objaverse | 295M | [Télécharger](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Inférence

### Matériau PBR
Pour la génération de matériau PBR conditionnée par texte, exécutez
```bash
bash inference_for_PBR_material.sh
```
Après la texturation et le baking du matériau, vous obtiendrez deux cartes : une carte d'albédo et une carte de matériau PBR. Plus précisément, la carte de matériau PBR contient trois canaux, où le canal vert représente la valeur de rugosité et le canal bleu la valeur métallique. Pour effectuer le rendu PBR des cartes de texture et de matériau générées, nous recommandons d'utiliser [ce script de rendu](https://github.com/ymxbj/BlenderToolboxPBR) écrit avec bpy.

De plus, nous recommandons à chacun d'imiter le style des textes du dataset Cap3D et de créer vos propres prompts pour de meilleurs résultats. Le dataset Cap3D peut être téléchargé [ici](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### Texture RGB
Pour la génération inconditionnelle de texture RGB, qui ne fonctionne que pour les 4 catégories spécifiques : bench, car, chair, table, exécutez
```bash
bash inference_for_RGB_texture.sh
```
Après le baking de la texture, vous obtiendrez une carte d'albédo.

## 🏋️‍♂️ Entraînement
Pour Objaverse :
```bash
bash train_for_objaverse.sh
```

Pour ShapeNet :
```bash
bash train_for_shapenet.sh
```

## 🚧 À faire
- [x] Publier le code d'entraînement et d'inférence
- [x] Publier le modèle pré-entraîné inconditionnel (albédo uniquement) sur le dataset ShapeNet
- [x] Publier le modèle pré-entraîné PBR conditionné par texte sur le dataset Objaverse
- [ ] Publier le dataset et les outils pour le dataset

## 📚 Remerciements

Ce travail s'appuie sur de nombreux travaux de recherche et projets open-source remarquables, un grand merci à tous les auteurs pour le partage !

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) et [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Citation

Si vous trouvez ce travail utile, merci de bien vouloir citer notre article :

1. Version arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. Version CVPR
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---