
<h2 align="center"> <a href="https://arxiv.org/abs/2412.09606">Feat2GS : Exploration des modèles fondamentaux visuels avec Gaussian Splatting</a>
</h2>

<h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2412.09606-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2412.09606) 
[![Page d'accueil](https://img.shields.io/badge/Project-Website-green.svg)](https://fanegg.github.io/Feat2GS/)  [![youtube](https://img.shields.io/badge/Video-E33122?logo=Youtube)](https://youtu.be/4fT5lzcAJqo?si=_fCSIuXNBSmov2VA)  [![Gradio](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Demo-orange)](https://huggingface.co/spaces/endless-ai/Feat2GS)  [![X](https://img.shields.io/badge/@Yue%20Chen-black?logo=X)](https://twitter.com/faneggchen)  [![Bluesky](https://img.shields.io/badge/@Yue%20Chen-white?logo=Bluesky)](https://bsky.app/profile/fanegg.bsky.social)

[Yue Chen](https://fanegg.github.io/),
[Xingyu Chen](https://rover-xingyu.github.io/),
[Anpei Chen](https://apchenstu.github.io/),
[Gerard Pons-Moll](https://virtualhumans.mpi-inf.mpg.de/),
[Yuliang Xiu](https://xiuyuliang.cn/)
</h5>

<div align="center">
Ce dépôt est l’implémentation officielle de Feat2GS, un cadre unifié pour sonder la « conscience de la texture et de la géométrie » des modèles fondamentaux visuels. La synthèse de vues inédites sert de proxy efficace pour l’évaluation 3D.
</div>
<br>

https://github.com/user-attachments/assets/07ebb8e1-6001-47bf-bf74-984b0032cc17


## Mises à jour

- [10 juillet 2025] Ajout d’une nouvelle évaluation des caractéristiques de l’encodeur et du décodeur VGGT. Voir les résultats [ici](https://raw.githubusercontent.com/fanegg/Feat2GS/main/assets/Feat2GS_Benchmark.pdf).

## Commencer

### Installation
1. Clonez Feat2GS et téléchargez le modèle pré-entraîné depuis [DUSt3R](https://github.com/naver/dust3r)/[MASt3R](https://github.com/naver/mast3r).
```bash
git clone https://github.com/fanegg/Feat2GS.git
cd Feat2GS/submodules/mast3r/
mkdir -p checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/DUSt3R/DUSt3R_ViTLarge_BaseDecoder_512_dpt.pth -P checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/MASt3R/MASt3R_ViTLarge_BaseDecoder_512_catmlpdpt_metric.pth -P checkpoints/
cd ../../
```
2. Créez l’environnement, ici nous montrons un exemple utilisant conda.

```bash
conda create -n feat2gs python=3.11 cmake=3.14.0
conda activate feat2gs
pip install "torch==2.5.1" "torchvision==0.20.1" "numpy<2" --index-url https://download.pytorch.org/whl/cu121  # use the correct version of cuda for your system
cd Feat2GS/
pip install -r requirements.txt
pip install submodules/simple-knn
```
3. Optionnel mais fortement recommandé, compiler les noyaux cuda pour RoPE (comme dans CroCo v2).

```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd submodules/mast3r/dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../../../
```

4. (Optionnel) suivez [cette instruction](https://github.com/cvlab-columbia/zero123?tab=readme-ov-file#novel-view-synthesis-1) pour installer les dépendances nécessaires à l'exploration de [Zero123](https://github.com/cvlab-columbia/zero123).

### Utilisation
1. Préparation des données (Nous fournissons nos ensembles de données d'évaluation et d'inférence : [lien](https://drive.google.com/file/d/1PLTFcvJfiPucrB-pIwfp5QG-AIHcJdjN/view?usp=drive_link))
```bash
  cd <data_root>/Feat2GS/
```

> Si vous souhaitez créer des ensembles de données personnalisés, veuillez suivre et modifier :
> ```
> build_dataset/0_create_json.py ## créer dataset_split.json pour diviser l'ensemble train/test
> build_dataset/1_create_feat2gs_dataset.py ## utiliser dataset_split.json pour créer l'ensemble de données
> ```


2. Évaluer les modèles fondamentaux visuels :

  | Étape | Description (lien vers la commande) |
  |-------|------------------------------------|
  | (1)   | [Initialisation DUSt3R & Extraction de caractéristiques](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L245-L250) |
  | (2)   | [Lecture 3DGS à partir des caractéristiques & Optimisation conjointe de la pose](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L253-L262) |
  | (3)   | [Test d'initialisation de la pose](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L265-L270) |
  | (4)   | [Rendu de la vue de test pour l'évaluation](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L273-L282) |
  | (5)   | [Métrique](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L298-L301) |
  | (Optionnel) | [Rendu vidéo avec trajectoire générée](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L304-L315) |

```bash
  # Run evaluation for all datasets, all VFM features, all probing modes
  bash scripts/run_feat2gs_eval_parallel.sh

  # (Example) Run evaluation for a single scene, DINO feature, Geometry mode
  bash scripts/run_feat2gs_eval.sh
```
> [!NOTE]
> Pour exécuter des expériences en parallèle, nous avons ajouté une fonctionnalité de **verrou GPU** pour garantir qu'une seule expérience d'évaluation s'exécute par GPU. Une fois une expérience terminée, le GPU est automatiquement déverrouillé. **Si interrompu par `Ctrl+C`, le GPU ne sera pas déverrouillé automatiquement.** Pour corriger cela, supprimez manuellement les fichiers `.lock` dans votre `LOCK_DIR`. Pour désactiver cette fonctionnalité, commentez ces lignes dans le script :
    [L4-L5](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L4-L5),
    [L9-L22](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L9-L22),
    [L223-L233](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L223-L233),
    [L330-L331](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L330-L331).

  | Config | Opération |
  |--------|-----------------|
  | GPU | Modifier dans [`<AVAILABLE_GPUS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L7) |
  | Dataset | Modifier dans [`<SCENES[$Dataset]>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L105-L111) |
  | Scène | Modifier dans [`<SCENES_$Dataset>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L31-L99) |
  | Modèle de Fondation Visuelle | Modifier dans [`<FEATURES>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L120-L162) |
  | Mode de sonde | Modifier dans [`<MODELS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L181-L188) |
  | Mode inference uniquement | Commentez les étapes (3)(4)(5) dans [`execute_command`](https://github.com/fanegg/Feat2GS/blob/main/scripts/run_feat2gs_eval_parallel.sh#L325-L327) |

```bash
  # Evaluate Visual Foundation Models on DTU dataset
  bash scripts/run_feat2gs_eval_dtu_parallel.sh

  # Run InstantSplat for evaluation
  bash scripts/run_instantsplat_eval_parallel.sh
```
3. Après l'entraînement, rendre la vidéo RGB/profondeur/normale avec la trajectoire générée.


```bash
  # If render depth/normal, set RENDER_DEPTH_NORMAL=true
  # Set type of generated trjectory by editing <TRAJ_SCENES>
  bash scripts/run_video_render.sh

  # Render video on DTU dataset
  bash scripts/run_video_render_dtu.sh
```
### 🎮 Démo interactive

#### 🚀 Démarrage rapide
1. **Images d'entrée**
* Téléchargez 2 images ou plus de la même scène sous différents angles
* Pour de meilleurs résultats, assurez-vous que les images ont un bon recouvrement

2. **Étape 1 : Initialisation DUSt3R & Extraction des caractéristiques**
* Cliquez sur "LANCER Étape 1" pour traiter vos images
* Cette étape estime le nuage de points DUSt3R initial et les poses de caméra, et extrait les caractéristiques DUSt3R pour chaque pixel

3. **Étape 2 : Lecture 3DGS à partir des caractéristiques**
* Réglez le nombre d'itérations d'entraînement, un nombre plus élevé améliore la qualité mais augmente la durée (par défaut : 2000, max : 8000)
* Cliquez sur "LANCER Étape 2" pour optimiser le modèle 3D

4. **Étape 3 : Rendu vidéo**
* Choisissez une trajectoire de caméra
* Cliquez sur "LANCER Étape 3" pour générer une vidéo de votre modèle 3D

```bash
gradio demo.py
```

#### 💡 Conseils
* Le temps de traitement dépend de la résolution et de la quantité d’images
* Pour des performances optimales, testez sur des GPU haut de gamme (A100/4090)
* Utilisez la souris pour interagir avec les modèles 3D :
  - Bouton gauche : Rotation
  - Molette : Zoom
  - Bouton droit : Déplacement


## Remerciements

Ce travail repose sur de nombreuses recherches et projets open source remarquables, un grand merci à tous les auteurs pour leur partage !

- [Gaussian-Splatting](https://github.com/graphdeco-inria/gaussian-splatting) et [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [gsplat](https://github.com/nerfstudio-project/gsplat)
- [DUSt3R](https://github.com/naver/dust3r) et [MASt3R](https://github.com/naver/mast3r)
- [InstantSplat](https://github.com/NVlabs/InstantSplat)
- [Probe3D](https://github.com/mbanani/probe3d)
- [FeatUp](https://github.com/mhamilton723/FeatUp)
- [Shape of Motion](https://github.com/vye16/shape-of-motion/)
- [Splatt3R](https://github.com/btsmart/splatt3r)
- [VGGT](https://github.com/facebookresearch/vggt)

## Citation
Si vous trouvez notre travail utile pour vos recherches, merci de penser à donner une étoile :star: et à citer l’article suivant :pencil:.

```bibTeX
@inproceedings{chen2025feat2gs,
  title={Feat2gs: Probing visual foundation models with gaussian splatting},
  author={Chen, Yue and Chen, Xingyu and Chen, Anpei and Pons-Moll, Gerard and Xiu, Yuliang},
  booktitle={Proceedings of the Computer Vision and Pattern Recognition Conference},
  pages={6348--6361},
  year={2025}
}
```

## Contact

Pour les retours, questions ou demandes de presse, veuillez contacter [Yue Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:faneggchen@gmail.com) et [Xingyu Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:roverxingyu@gmail.com).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-10

---