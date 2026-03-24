<div align="center">

# UniSH : Unification de la Reconstruction de Scène et Humaine en une Passe Feed-Forward


**Mengfei Li**<sup>1</sup>, **Peng Li**<sup>1</sup>, **Zheng Zhang**<sup>2</sup>, **Jiahao Lu**<sup>1</sup>, **Chengfeng Zhao**<sup>1</sup>, **Wei Xue**<sup>1</sup>,
<br>
**Qifeng Liu**<sup>1</sup>, **Sida Peng**<sup>3</sup>, **Wenxiao Zhang**<sup>1</sup>, **Wenhan Luo**<sup>1</sup>, **Yuan Liu**<sup>1†</sup>, **Yike Guo**<sup>1†</sup>

<sup>1</sup>HKUST, <sup>2</sup>BUPT, <sup>3</sup>ZJU

<br>

<a href="https://arxiv.org/abs/2601.01222" target="_blank"><img src="https://img.shields.io/badge/arXiv-Paper-b31b1b.svg" alt="arXiv"></a>
<a href="https://murphylmf.github.io/UniSH/" target="_blank"><img src="https://img.shields.io/badge/Project-Page-orange" alt="Project Page"></a>
<a href="https://huggingface.co/spaces/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Spaces-yellow" alt="Hugging Face Demo"></a>
<a href="https://huggingface.co/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue" alt="Hugging Face Model"></a>
<a href="LICENSE" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-green.svg" alt="License"></a>

</div>

---

### TL;DR
À partir d’une vidéo monoculaire en entrée, notre UniSH est capable de reconstruire conjointement la scène et l’humain en une seule passe avant, permettant une estimation efficace de la géométrie de la scène, des paramètres de la caméra et des paramètres SMPL.


<video src="static/teaser_video_final.mp4" autoplay loop muted playsinline width="100%"></video>

<img src="https://raw.githubusercontent.com/murphylmf/UniSH/main/static/teaser.svg" width="100%" style="background-color: white;">

## 🛠️ Installation

Nous fournissons une méthode d’installation **sans sudo** qui fonctionne sur la plupart des serveurs Linux (y compris sans interface graphique).

### Étape 1 : Cloner le dépôt

```bash
git clone https://github.com/murphylmf/UniSH.git
cd UniSH
```

### Étape 2 : Créer un environnement Conda
Cela installe Python, les compilateurs système et les pilotes OpenGL.

```bash
conda env create -f environment.yml
conda activate unish
```

### Étape 3 : Compiler les dépendances
Ce script compile PyTorch3D, MMCV et SAM2 à partir des sources en utilisant les compilateurs installés à l'Étape 2.

L'environnement a été testé sur **CUDA 12.1** et **CUDA 11.8**. Vous pouvez spécifier la version de CUDA en la passant comme argument au script d'installation.

```bash
# Default (Auto-detect or 12.1)
bash install.sh

# For CUDA 11.8
bash install.sh 11.8

# For CUDA 12.1
bash install.sh 12.1
```

### Étape 4 : Télécharger les modèles SMPL
Veuillez télécharger les modèles [SMPL](https://smpl.is.tue.mpg.de/) et les placer dans le dossier `body_models`.
La structure du répertoire doit être organisée comme suit :

```text
UniSH/
├── body_models/
│   └── smpl/
│       └── smpl/
│           ├── SMPL_FEMALE.pkl
│           ├── SMPL_MALE.pkl
│           └── SMPL_NEUTRAL.pkl
```

## 🚀 Démarrage rapide (Inférence)

### Exécuter l'inférence
Exécutez la commande suivante pour reconstruire la scène et l'humain à partir de la vidéo :

```bash
python inference.py --output_dir inference_results/example --video_path examples/example_video.mp4 
```

Veuillez vous référer à `inference.py` pour plus d'informations sur les paramètres supplémentaires.

## 📝 Citation

Si vous trouvez ce code utile pour vos recherches, veuillez envisager de citer notre article :

```bibtex
@misc{li2026unishunifyingscenehuman,
      title={UniSH: Unifying Scene and Human Reconstruction in a Feed-Forward Pass}, 
      author={Mengfei Li and Peng Li and Zheng Zhang and Jiahao Lu and Chengfeng Zhao and Wei Xue and Qifeng Liu and Sida Peng and Wenxiao Zhang and Wenhan Luo and Yuan Liu and Yike Guo},
      year={2026},
      eprint={2601.01222},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2601.01222}, 
}
```

## 🙏 Remerciements

Nous remercions les excellentes contributions des projets suivants :

* [GVHMR](https://github.com/zju3dv/GVHMR)
* [BEDLAM](https://bedlam.is.tue.mpg.de/)
* [SMPL](https://smpl.is.tue.mpg.de/)
* [VGGT](https://github.com/facebookresearch/vggt)
* [Pi3](https://github.com/yyfz/Pi3)
* [MoGe2](https://github.com/microsoft/moge)

## 📄 Licence
Ce projet est sous licence Apache 2.0. Voir [LICENSE](LICENSE) pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---