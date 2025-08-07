<p align="center">
  <h1 align="center">VideoScene : Distillation d’un modèle de diffusion vidéo pour générer des scènes 3D en une seule étape</h1>
  <p align="center">
    <a href="https://hanyang-21.github.io/">Hanyang Wang</a><sup>*</sup>,
    <a href="https://liuff19.github.io/">Fangfu Liu</a><sup>*</sup>,
    <a href="https://github.com/hanyang-21/VideoScene">Jiawei Chi</a>,
    <a href="https://duanyueqi.github.io/">Yueqi Duan</a>
    <br>
    <sup>*</sup>Contribution Équivalente.
    <br>
    Université Tsinghua
  </p>
  <h3 align="center">CVPR 2025 Highlight 🔥</h3>
  <h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2403.20309-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2504.01956) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://hanyang-21.github.io/VideoScene)
<a><img src='https://img.shields.io/badge/License-MIT-blue'></a>
<a href='https://mp.weixin.qq.com/s/u6OUo5mHKPG6I3yYJPMC8Q'><img src='https://img.shields.io/badge/%E5%BE%AE%E4%BF%A1-%E4%B8%AD%E6%96%87%E4%BB%8B%E7%BB%8D-green'></a>

</h5>
  <!-- <h3 align="center"><a href="https://arxiv.org/abs/">Article</a> | <a href="">Page du projet</a> | <a href="">Modèles pré-entraînés</a> </h3> -->
<!--   <div align="center">
    <a href="https://news.ycombinator.com/item?id=41222655">
      <img
        alt="Mis en avant sur Hacker News"
        src="https://hackerbadge.vercel.app/api?id=41222655&type=dark"
      />
    </a>
  </div> -->

</p>

<div align="center">
VideoScene est un modèle de diffusion vidéo en une étape qui comble le fossé entre la vidéo et la 3D.
</div>
</br>


https://github.com/user-attachments/assets/dca733b1-b78f-49ac-ae47-5d1b1e8a689b

S’appuyant sur [ReconX](https://github.com/liuff19/ReconX), VideoScene a réalisé une avancée version turbo.



## Installation

Pour commencer, clonez ce projet, créez un environnement virtuel conda utilisant Python 3.10+, et installez les dépendances :

1. Cloner VideoScene.
```bash
git clone https://github.com/hanyang-21/VideoScene
cd VideoScene
```
2. Créez l'environnement, ici nous montrons un exemple utilisant conda.

```bash
conda create -y -n videoscene python=3.10
conda activate videoscene
pip install torch==2.1.2 torchvision==0.16.2 torchaudio==2.1.2 --index-url https://download.pytorch.org/whl/cu118
pip install -r requirements.txt
```
3. Optionnel, compiler les noyaux cuda pour RoPE (comme dans CroCo v2).

```bash
# NoPoSplat relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd src/model/encoder/backbone/croco/curope/
python setup.py build_ext --inplace
cd ../../../../../..
```

## Acquisition des jeux de données

### RealEstate10K et ACID

Notre VideoScene utilise les mêmes jeux de données d'entraînement que pixelSplat. Ci-dessous, nous citons les [instructions détaillées](https://github.com/dcharatan/pixelsplat?tab=readme-ov-file#acquiring-datasets) de pixelSplat pour obtenir les jeux de données.

> pixelSplat a été entraîné en utilisant des versions des jeux de données RealEstate10k et ACID découpées en morceaux d’environ 100 Mo pour une utilisation sur des systèmes de fichiers de clusters serveurs. De petits sous-ensembles des jeux de données Real Estate 10k et ACID dans ce format peuvent être trouvés [ici](https://drive.google.com/drive/folders/1joiezNCyQK2BvWMnfwHJpm2V77c7iYGe?usp=sharing). Pour les utiliser, il suffit de les décompresser dans un dossier `datasets` nouvellement créé à la racine du projet.

> Si vous souhaitez convertir des versions téléchargées des jeux de données Real Estate 10k et ACID au format que nous utilisons, vous pouvez utiliser les [scripts ici](https://github.com/dcharatan/real_estate_10k_tools). Contactez-nous (pixelSplat) si vous souhaitez les versions complètes de nos jeux de données traités, qui pèsent environ 500 Go et 160 Go pour Real Estate 10k et ACID respectivement.

## Téléchargement des checkpoints

* téléchargez nos [poids pré-entraînés](https://wisemodel.cn/models/hanyang/VideoScene/file) (`VideoScene/checkpoints/model.safetensors` et `VideoScene/checkpoints/prompt_embeds.pt`), et sauvegardez-les dans `checkpoints`.

* pour des entrées d’images personnalisées, récupérez les modèles pré-entraînés NoPoSplat [ici](https://huggingface.co/botaoye/NoPoSplat/resolve/main/mixRe10kDl3dv_512x512.ckpt), et sauvegardez-les dans `checkpoints/noposplat`.


* pour les jeux de données RealEstate10K, récupérez les modèles pré-entraînés MVSplat [ici](https://drive.google.com/drive/folders/14_E_5R6ojOWnLSrSVLVEMHnTiKsfddjU), et sauvegardez-les dans `checkpoints/mvsplat`.

## Exécution du code

### Démonstration Gradio
Dans cette démonstration, vous pouvez exécuter VideoScene sur votre machine pour générer une vidéo avec des vues d’entrée non posées.

* sélectionnez des paires d’images représentant la même scène et cliquez sur "RUN" pour obtenir une vidéo de la scène.

```bash
python -m noposplat.src.app \
    checkpointing.load=checkpoints/noposplat/mixRe10kDl3dv_512x512.ckpt \
    test.video=checkpoints/model.safetensors

# also "bash demo.sh"
```
* la vidéo générée sera stockée dans `outputs/gradio`

### Inférence

Pour générer des vidéos sur les ensembles de données RealEstate10K, nous utilisons un modèle préentraîné [MVSplat](https://github.com/donydchen/mvsplat),

* exécutez ce qui suit :

```bash
# re10k
python -m mvsplat.src.main +experiment=re10k \
checkpointing.load=checkpoints/mvsplat/re10k.ckpt \
mode=test \
dataset/view_sampler=evaluation \
dataset.view_sampler.index_path=mvsplat/assets/evaluation_index_re10k_video.json \
test.save_video=true \
test.save_image=false \
test.compute_scores=false \
test.video=checkpoints/model.safetensors

# also "bash inference.sh"
```

* la vidéo générée sera stockée sous `outputs/test`


## BibTeX

```bibtex
@misc{wang2025videoscenedistillingvideodiffusion,
      title={VideoScene: Distilling Video Diffusion Model to Generate 3D Scenes in One Step}, 
      author={Hanyang Wang and Fangfu Liu and Jiawei Chi and Yueqi Duan},
      year={2025},
      eprint={2504.01956},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2504.01956}, 
}
```

## Remerciements

Ce projet est développé avec plusieurs dépôts fantastiques : [ReconX](https://github.com/liuff19/ReconX), [MVSplat](https://github.com/donydchen/mvsplat), [NoPoSplat](https://github.com/cvg/NoPoSplat), [CogVideo](https://github.com/THUDM/CogVideo), et [CogvideX-Interpolation](https://github.com/feizc/CogvideX-Interpolation). Un grand merci à ces projets pour leurs excellentes contributions !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---