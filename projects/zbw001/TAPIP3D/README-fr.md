<div align="center">

# TAPIP3D : Suivi de Tout Point dans une Géométrie 3D Persistante
<a href="https://arxiv.org/abs/2504.14717"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://tapip3d.github.io'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Page du Projet'></a>

[Bowei Zhang](https://scholar.google.com/citations?user=tYH72AYAAAAJ)<sup>1,2</sup>*, [Lei Ke](https://www.kelei.site/)<sup>1</sup>\*, [Adam W. Harley](https://adamharley.com/)<sup>3</sup>, [Katerina Fragkiadaki](https://www.cs.cmu.edu/~katef/)<sup>1</sup>

<sup>1</sup>Carnegie Mellon University   &nbsp;  <sup>2</sup>Peking University &nbsp;  <sup>3</sup>Stanford University

**NeurIPS 2025**

\* Contribution Égale

<!-- <a href='https://huggingface.co/spaces/your-username/project'><img src='https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Live_Demo-blue'></a> -->

</div>

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/teaser1.gif" width="100%" alt="Présentation de TAPIP3D">


---

### 🚀 Actualités
- **(2025.12.28)** 🔥 Nous avons mis à jour le code de **Formation** et d'**Évaluation** ! Consultez les nouvelles sections ci-dessous.

## Vue d'ensemble
**TAPIP3D** est une méthode de suivi 3D **feed-forward** à long terme des points dans des séquences vidéo monoculaires RGB et RGB-D. Elle introduit une représentation en nuage de caractéristiques 3D qui élève les caractéristiques d’image dans un espace de coordonnées mondiales persistant, annulant le mouvement de la caméra et permettant une estimation précise des trajectoires entre les images.

Nous fournissons une [illustration vidéo détaillée](https://neurips.cc/virtual/2025/loc/san-diego/poster/117634#:~:text=Within%20this%20stabilized%203D%20representation,trained%20checkpoints%20will%20be%20public.) de notre TAPIP3D.

## Installation
### Installation des dépendances

1. Préparez l’environnement
```bash
conda create -n tapip3d python=3.10
conda activate tapip3d

pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 "xformers>=0.0.27" --index-url https://download.pytorch.org/whl/cu124
pip install torch-scatter -f https://data.pyg.org/whl/torch-2.4.1+cu124.html
pip install -r requirements.txt
```

2. Compiler pointops2

```bash
cd third_party/pointops2
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../..
```

3. Compiler megasam
```bash
cd third_party/megasam/base
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../../..
```

### Téléchargement des points de contrôle

Téléchargez notre point de contrôle du modèle TAPIP3D [ici](https://huggingface.co/zbww/tapip3d/resolve/main/tapip3d_final.pth) vers `checkpoints/tapip3d_final.pth`

Si vous souhaitez exécuter TAPIP3D sur des vidéos monoculaires, vous devez préparer manuellement les points de contrôle suivants pour exécuter MegaSAM :

1. Téléchargez le point de contrôle DepthAnything V1 depuis [ici](https://huggingface.co/spaces/LiheYoung/Depth-Anything/resolve/main/checkpoints/depth_anything_vitl14.pth) et placez-le dans `third_party/megasam/Depth-Anything/checkpoints/depth_anything_vitl14.pth`

2. Téléchargez le point de contrôle RAFT depuis [ici](https://drive.google.com/drive/folders/1sWDsfuZ3Up38EUQt7-JDTT1HcGHuJgvT) et placez-le dans `third_party/megasam/cvd_opt/raft-things.pth`

De plus, les points de contrôle de [MoGe](https://wangrc.site/MoGePage/) et [UniDepth](https://github.com/lpiccinelli-eth/UniDepth.git) seront téléchargés automatiquement lors de l'exécution de la démo. Veuillez vous assurer que votre connexion réseau est disponible.

## Utilisation de la démo

Nous fournissons un script de démo simple `inference.py`, ainsi que des données d'entrée d'exemple situées dans le répertoire `demo_inputs/`.

Le script accepte en entrée soit un fichier vidéo `.mp4`, soit un fichier `.npz`. Si vous fournissez un fichier `.npz`, il doit suivre le format suivant :

- `video` : tableau de forme (T, H, W, 3), dtype : uint8
- `depths` (optionnel) : tableau de forme (T, H, W), dtype : float32
- `intrinsics` (optionnel) : tableau de forme (T, 3, 3), dtype : float32
- `extrinsics` (optionnel) : tableau de forme (T, 4, 4), dtype : float32

À des fins de démonstration, le script utilise une grille de points 32x32 sur la première image comme requêtes.


### Inférence avec vidéo monoculaire

En fournissant une vidéo via `--input_path`, le script exécute d'abord [MegaSAM](https://github.com/mega-sam/mega-sam) avec [MoGe](https://wangrc.site/MoGePage/) pour estimer les cartes de profondeur et les paramètres de la caméra. Ensuite, le modèle traitera ces entrées dans le cadre global.

**Démo 1**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo1.gif" width="100%" alt="Démo 1">

Pour lancer l'inférence :

```bash
python inference.py --input_path demo_inputs/sheep.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

Un fichier npz sera enregistré dans `outputs/inference/`. Pour visualiser les résultats :

```bash
python visualize.py <result_npz_path>
```

**Demo 2**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo2.gif" width="100%" alt="Demo 2">

```bash
python inference.py --input_path demo_inputs/pstudio.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

**Inférence avec Profondeurs et Paramètres de Caméra Connus**

Si un fichier `.npz` contenant les quatre clés (`rgb`, `depths`, `intrinsics`, `extrinsics`) est fourni, le modèle fonctionnera dans un cadre global aligné, générant des trajectoires de points en coordonnées mondiales.
Nous fournissons un exemple de fichier `.npz` [ici](https://huggingface.co/zbww/tapip3d/resolve/main/demo_inputs/dexycb.npz?download=true) et veuillez le placer dans le répertoire `demo_inputs/`.

**Démo 3**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo3.gif" width="100%" alt="Démo 3">

```bash
python inference.py --input_path demo_inputs/dexycb.npz --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

## Entraînement et Évaluation

### 1. Préparation du Jeu de Données
Veuillez consulter [DATASET.md](https://raw.githubusercontent.com/zbw001/TAPIP3D/main/DATASET.md) pour les instructions sur la préparation des jeux de données pour l’entraînement et l’évaluation.

### 2. Entraînement
Pour commencer l’entraînement, exécutez :
```bash
bash scripts/train.sh
```
- `experiment_name` : Le nom de l'exécution affiché sur **WandB**.  
- `experiment_id` : Un identifiant unique. Relancer avec le même `experiment_id` **reprendra automatiquement** l'entraînement à partir du dernier point de contrôle.

### 3. Évaluation  
Pour évaluer un point de contrôle, exécutez :
```bash
bash scripts/eval.sh
```
Vous pouvez spécifier le modèle à évaluer en modifiant la variable `checkpoint` dans `scripts/eval.sh`.

## Citation
Si vous trouvez ce projet utile, veuillez envisager de le citer :

```
@article{tapip3d,
  title={TAPIP3D: Tracking Any Point in Persistent 3D Geometry},
  author={Zhang, Bowei and Ke, Lei and Harley, Adam W and Fragkiadaki, Katerina},
  journal={arXiv preprint arXiv:2504.14717},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-12

---