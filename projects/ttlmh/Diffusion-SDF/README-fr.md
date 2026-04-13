# Diffusion-SDF : Texte en forme via diffusion voxelisée

Créé par [Muheng Li](https://ttlmh.github.io/), [Yueqi Duan](https://duanyueqi.github.io/), [Jie Zhou](https://scholar.google.com/citations?user=6a79aPwAAAAJ&hl=en&authuser=1), et [Jiwen Lu](https://scholar.google.com/citations?user=TN8uDQoAAAAJ&hl=en&authuser=1).

![intro](https://raw.githubusercontent.com/ttlmh/Diffusion-SDF/master/media/intro.png)

We propose a new generative 3D modeling framework called **Diffusion-SDF** for the challenging task of text-to-shape synthesis. Previous approaches lack flexibility in both 3D data representation and shape generation, thereby failing to generate highly diversified 3D shapes conforming to the given text descriptions. To address this, we propose a SDF autoencoder together with the Voxelized Diffusion model to learn and generate representations for voxelized signed distance fields (SDFs) of 3D shapes. Specifically, we design a novel UinU-Net architecture that implants a local-focused inner network inside the standard U-Net architecture, which enables better reconstruction of patch-independent SDF representations. We extend our approach to further text-to-shape tasks including text-conditioned shape completion and manipulation. Experimental results show that Diffusion-SDF is capable of generating both high-quality and highly diversified 3D shapes that conform well to the given text descriptions. Diffusion-SDF has demonstrated its superiority compared to previous state-of-the-art text-to-shape approaches.

![intro](https://raw.githubusercontent.com/ttlmh/Diffusion-SDF/master/media/pipeline.gif)

[[Page du projet]](https://ttlmh.github.io/DiffusionSDF/) [[arXiv]](https://arxiv.org/abs/2212.03293)

## Code

### Installation
Pour configurer l’environnement Diffusion-SDF, vous pouvez utiliser le fichier `diffusionsdf.yml` fourni pour créer un environnement Conda. Suivez les étapes ci-dessous :
1. Clonez le dépôt :
```
git clone https://github.com/ttlmh/Diffusion-SDF.git
```
2. Créez l'environnement Conda en utilisant le fichier YAML fourni et activez-le :
```
conda env create -f diffusionsdf.yml
conda activate diffusionsdf
```

### Télécharger les modèles pré-entraînés
Téléchargez le fichier du modèle d'auto-encodeur SDF (vae_epoch-120.pth : [Baidu Disk](https://pan.baidu.com/s/1z0eh8SXSrn8tbq5epo0r6Q?pwd=f1cv) / [Google Drive](https://drive.google.com/file/d/18MxWYf6IItYOxUzdM5LiWb8dr9zSwA-2/view?usp=sharing)) et le fichier du modèle de diffusion voxelisée (voxdiff-uinu.ckpt : [Baidu Disk](https://pan.baidu.com/s/1Emu5kFVaYbuKIkdCKlghXQ?pwd=q1wv) / [Google Drive](https://drive.google.com/file/d/1yeB0dJGZvIXdF1V1DhI-fRz6CKnGbIwJ/view?usp=sharing))) via les liens ci-dessus. Placez les fichiers modèles téléchargés dans le répertoire ```./ckpt``` .

---

## Inférence

### Génération de formes à partir de texte
Pour générer des formes 3D à partir de descriptions textuelles en utilisant Diffusion-SDF, exécutez :

```
python txt2sdf.py --prompt "a revolving chair" --save_obj
```
La forme 3D générée sera enregistrée sous forme de rendus GIF et de fichiers OBJ dans le répertoire `outputs/`.

### Complétion de forme conditionnée par texte
Étant donné une forme 3D partielle/incomplète (sous forme de fichier SDF `.h5`) et une invite textuelle, Diffusion-SDF peut compléter les régions manquantes :

```bash
# Axial cut: mask out the bottom half along the Z axis
python shape_completion.py \
    --input_sdf path/to/partial.h5 \
    --prompt "a wooden chair" \
    --mask_axis z --mask_ratio 0.5

# SDF-value based masking (mask voxels with SDF >= threshold)
python shape_completion.py \
    --input_sdf path/to/shape.h5 \
    --prompt "a dining table" \
    --mask_type threshold --mask_value 0.0
```
Les résultats (rendus GIF et fichiers OBJ optionnels) sont enregistrés sous `outputs/shape_completion/`.

### Manipulation de forme conditionnée par texte
Étant donné une forme 3D existante et une invite textuelle, Diffusion-SDF modifie la forme via l'approche SDEdit — en encodant la forme dans l'espace latent, en ajoutant du bruit jusqu'à un pas de temps choisi, puis en débruitant avec la nouvelle invite textuelle :

```bash
# Moderate manipulation (50% noise strength)
python shape_manipulation.py \
    --input_sdf path/to/shape.h5 \
    --prompt "a chair with a cushion" \
    --strength 0.5

# Strong manipulation (75% noise strength — more creative freedom)
python shape_manipulation.py \
    --input_sdf path/to/shape.h5 \
    --prompt "a modern minimalist chair" \
    --strength 0.75
```
Les résultats sont enregistrés sous `outputs/shape_manipulation/`, incluant un rendu de la forme originale pour comparaison.

---

## Entraînement

### Préparation des données

L’entraînement nécessite deux éléments : des fichiers SDF voxelisés pour les formes 3D, et des légendes textuelles issues de Text2Shape.

#### Étape 0 — Télécharger ShapeNet Core v1

Inscrivez-vous et téléchargez [ShapeNet Core v1](https://shapenet.org/) puis extrayez-le quelque part (par ex. `data/ShapeNetCore.v1/`).

#### Étape 1 — Précalculer les volumes SDF 64³

ShapeNet fournit des maillages triangulaires ; l’autoencodeur et le modèle de diffusion ont besoin de champs de distance signés voxelisés sur une grille 64³, stockés sous forme de fichiers HDF5. Nous suivons la même chaîne de prétraitement que [SDFusion](https://github.com/yccyenchicheng/SDFusion) :

```bash
# Install system dependencies (Ubuntu/Debian)
sudo apt-get install freeglut3-dev libtbb-dev

# Clone SDFusion and run their SDF generation scripts
# (see SDFusion repo for the full launcher scripts)
cd preprocess
bash launch_create_sdf_shapenet.sh \
    --shapenet_root data/ShapeNetCore.v1 \
    --out_root data/ShapeNet/sdf
```
La mise en page de sortie attendue est :

```
data/ShapeNet/
  sdf/
    <synset_id>/          e.g. 03001627 (chair), 04379243 (table)
      <model_id>/
        pc_sdf_sample.h5  float32 array of shape (262144,) = 64³ SDF values
```

La clé HDF5 est `pc_sdf_sample` et le tableau est stocké à plat (262144 = 64×64×64 éléments).

#### Étape 2 — Préparer les légendes Text2Shape

[Text2Shape](http://text2shape.stanford.edu/) fournit des descriptions en langage naturel uniquement pour les **chaises** et **tables** de ShapeNet. Les autres catégories seront entraînées de manière inconditionnelle (légende vide).

```bash
# Download the caption CSV
mkdir -p data/ShapeNet/text
wget http://text2shape.stanford.edu/dataset/captions.tablechair.csv \
    -O data/ShapeNet/text/captions.tablechair.csv

# Convert to captions.json and generate train/val/test splits
python preprocess/prepare_text2shape.py --data_root data/ShapeNet
```
Cela produit :

```
data/ShapeNet/
  text/
    captions.tablechair.csv   (raw Text2Shape CSV)
    captions.json             {model_id: [caption, ...]}
  train_models.json           [model_id, ...]
  val_models.json
  test_models.json
```

Si vous disposez des fichiers JSON de la division officielle de ShapeNet, passez-les avec `--shapenet_split_dir` pour utiliser les divisions canoniques au lieu d'une division aléatoire :

```bash
python preprocess/prepare_text2shape.py \
    --data_root data/ShapeNet \
    --shapenet_split_dir data/ShapeNet/splits
```

### Étape 1 — Entraîner l'autoencodeur SDF  
Entraînez l'autoencodeur variationnel par patch qui encode des volumes SDF de 64³ en un espace latent compact de 8³ :  

```bash
# Single GPU
python train_ae.py --data_root data/ShapeNet --cat all

# Resume from a checkpoint
python train_ae.py --data_root data/ShapeNet \
    --resume ckpt/vae_epoch-120.pth --start_epoch 121

# Multi-GPU (DDP via torchrun)
torchrun --nproc_per_node=4 train_ae.py --data_root data/ShapeNet --dist_train
```

Les points de contrôle sont sauvegardés dans `./ckpt/` sous le nom `vae_epoch-{N}.pth`.

### Étape 2 — Entraîner le modèle de diffusion voxelisé
Après l'entraînement de l'AE, entraînez le modèle de diffusion 3D conditionné par texte en utilisant PyTorch Lightning :

```bash
# Single GPU
python main.py --config configs/voxdiff-uinu.yaml

# Resume from a checkpoint
python main.py --config configs/voxdiff-uinu.yaml --resume /path/to/checkpoint.ckpt

# Multi-GPU
python main.py --config configs/voxdiff-uinu.yaml --gpus 0,1,2,3
```

Les points de contrôle sont sauvegardés sous `logs/<run_name>/checkpoints/`.

## Remerciements
Notre code est basé sur [Stable-Diffusion](https://github.com/CompVis/stable-diffusion), et [AutoSDF](https://github.com/yccyenchicheng/AutoSDF).

## Citation
Si vous trouvez notre travail utile pour votre recherche, veuillez envisager de citer :

```
@inproceedings{li2023diffusionsdf,
  author={Li, Muheng and Duan, Yueqi and Zhou, Jie and Lu, Jiwen},
  title={Diffusion-SDF: Text-to-Shape via Voxelized Diffusion},
  booktitle={Proceedings of the IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
  year={2023}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-13

---