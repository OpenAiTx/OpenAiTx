![brlp](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/readme-brlp-v2.png)

<p align="center">
  <a href='https://www.sciencedirect.com/science/article/pii/S1361841525002816'>
    <img src='https://img.shields.io/badge/Journal-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://papers.miccai.org/miccai-2024/paper/0511_paper.pdf'>
    <img src='https://img.shields.io/badge/MICCAI-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://youtu.be/6YKz2MNM4jg?si=nkG21K4lIgLrH-pK'>
    <img src='https://img.shields.io/badge/Video-YouTube-red?style=for-the-badge&logo=youtube&logoColor=white&color=FF3737' alt='Video'>
  </a>
</p>

<h4 align="center">Amélioration des modèles spatiotemporels de progression des maladies via la diffusion latente et les connaissances a priori</h4>

<h4 align="center"><a href="https://lemuelpuglisi.github.io/">Lemuel Puglisi</a>, <a href="https://profiles.ucl.ac.uk/3589">Daniel C. Alexander</a>, <a href="https://daniravi.wixsite.com/researchblog">Daniele Ravì</a></h4>

https://github.com/user-attachments/assets/28ad3693-5e3e-4f6e-9bbc-485424fbbee2

<p align="center">
  <a href="#installation">Installation</a> •
  <a href="#training">Entraînement</a> •
  <a href="#inference">Application CLI</a> •
  <a href="#citing">Citer</a>
</p>


**NOUVELLES**
* 🎉 BrLP a obtenu la deuxième place pour le Media Best Paper Award à MICCAI 2025 !
* 🎉 Notre [article de prolongation](https://arxiv.org/pdf/2502.08560) a été accepté pour publication dans Medical Image Analysis (*IF=11.8*)
* 🎉 Un [nouvel article](https://www.spiedigitallibrary.org/conference-proceedings-of-spie/13406/1340621/A-technical-assessment-of-latent-diffusion-for-Alzheimers-disease-progression/10.1117/12.3047135.short) de l'Université Vanderbilt a reproduit nos résultats sur le jeu de données [BLSA](https://www.blsa.nih.gov/) !
* 🆕 Le [guide court sur l'utilisation du CLI BrLP](https://lemuelpuglisi.github.io/blog/2024/brlp/) est disponible !
* 🎉 BrLP a été nommé et présélectionné pour le MICCAI Best Paper Award ! (top <1%)
* 🎉 BrLP a été accepté en avance et sélectionné pour une **présentation orale** à [MICCAI 2024](https://conferences.miccai.org/2024/en/) (top 4%) !



## Table des matières
- [Installation](#installation)
- [Préparation des données](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md)
- [Entraînement](#training)
- [Modèles préentraînés](#pretrained-models)
- [Remerciements](#acknowledgements)
- [Citation de notre travail](#citing)

## Installation

Téléchargez le dépôt, faites un `cd` dans le dossier du projet et installez le paquet `brlp` :

```console
pip install -e .
```
Nous recommandons d'utiliser un environnement séparé (voir [Anaconda](https://www.anaconda.com/)). Le code a été testé avec python 3.9, cependant nous pensons qu'il fonctionnera également avec des versions plus récentes.

## Préparation des données

Consultez notre document sur la [*Préparation des données et reproductibilité de l'étude*](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md). Ce fichier vous guidera dans l'organisation de vos données et la création des fichiers CSV nécessaires pour exécuter les pipelines d'entraînement.

## Entraînement
![](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/pipeline.png)

L'entraînement de BrLP comporte 3 phases principales qui seront décrites dans les sections suivantes. Chaque entraînement (sauf pour le modèle auxiliaire) peut être suivi à l'aide de `tensorboard` comme suit :



```console
tensorboard --logdir runs
```



### Train the autoencoder

Follow the commands below to train the autoencoder.

```console
# Create an output and a cache directory
mkdir ae_output ae_cache

# Run the training script
python scripts/training/train_autoencoder.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   ./ae_cache \
  --output_dir  ./ae_output
```

Puis extrayez les latents de vos données IRM :

```console
python scripts/prepare/extract_latents.py \
  --dataset_csv /path/to/A.csv \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

Remplacez `XXX` pour sélectionner les points de contrôle de l'autoencodeur de votre choix.

### Entraînez le UNet

Suivez les commandes ci-dessous pour entraîner le UNet de diffusion. Remplacez `XXX` pour sélectionner les points de contrôle de l'autoencodeur de votre choix.


```console
# Create an output and a cache directory:
mkdir unet_output unet_cache

# Run the training script
python scripts/training/train_diffusion_unet.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

### Entraînez le ControlNet

Suivez les commandes ci-dessous pour entraîner le ControlNet. Remplacez `XXX` pour sélectionner les points de contrôle de l'autoencodeur et de l'UNet de votre choix.

```console
# Create an output and a cache directory:
mkdir cnet_output cnet_cache

# Run the training script
python scripts/training/train_controlnet.py \
  --dataset_csv /path/to/B.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth \
  --diff_ckpt   unet_output/unet-ep-XXX.pth
```

### Modèles auxiliaires

Suivez les commandes ci-dessous pour entraîner le modèle auxiliaire DCM.

```console
# Create an output directory
mkdir aux_output

# Run the training script
python scripts/training/train_aux.py \
  --dataset_csv /path/to/A.csv \
  --output_path aux_output
```

Nous soulignons que tout modèle de progression de maladie capable de prédire les changements volumétriques au fil du temps est également viable en tant que modèle auxiliaire pour BrLP.

## Inférence

Notre package est livré avec une commande `brlp` pour utiliser BrLP pour l'inférence. Vérifiez :
```console
brlp --help
```
Le paramètre `--input` requiert un fichier CSV dans lequel vous listez toutes les données disponibles pour vos sujets. Pour un exemple, consultez `examples/input.example.csv`. Si vous n'avez pas segmenté vos scans d'entrée, `brlp` peut effectuer cette tâche pour vous en utilisant [SynthSeg](https://surfer.nmr.mgh.harvard.edu/fswiki/SynthSeg), mais cela nécessite que FreeSurfer >= 7.4 soit installé. Le paramètre `--confs` spécifie les chemins vers les modèles et autres paramètres d'inférence, tels que LAS $m$. Pour un exemple, consultez `examples/confs.example.yaml`. 

L'exécution du programme se présente ainsi :

![inference-preview](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/inference.gif)


## Modèles pré-entraînés

Téléchargez les modèles pré-entraînés pour BrLP :

| Modèle                 | URL des poids                                               |
| ---------------------- | ------------------------------------------------------------ |
| Autoencodeur           | [lien](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EUxUFIQtkQ1EvBqojYA5BAYByIyHbttca5Mx1cU4bC6q3A?e=sCXSUA) |
| Modèle de diffusion UNet | [lien](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EQT7KJTtfmRAguf8_utWeJIBUJPsRRgPZlt94s2vNbwVFw?e=IjHnx7) |
| ControlNet             | [lien](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EYtVvH47dFJJnH8gtwSMA-MB8c3pm4_Z9g5F_IG1OKxW9Q?e=CzvGT4) |
| Modèles auxiliaires (DCM) | [lien](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EXJDQqLNCwBFkt2J6zg1kpwBS_1hAZoBfGy5AfcGOBZvHQ?e=Z05kOG) |

## Remerciements

Nous remercions les mainteneurs des bibliothèques open-source pour leurs contributions à l'accélération du processus de recherche, avec une mention spéciale à [MONAI](https://monai.io/) et son extension [GenerativeModels](https://github.com/Project-MONAI/GenerativeModels/tree/main).

## Citation

Medical Image Analysis :


```bib
@article{puglisi2025brain,
  title={Brain latent progression: Individual-based spatiotemporal disease progression on 3D brain MRIs via latent diffusion},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  journal={Medical Image Analysis},
  year={2025}
}
```

Actes de MICCAI 2024 :

```bib
@inproceedings{puglisi2024enhancing,
  title={Enhancing spatiotemporal disease progression models via latent diffusion and prior knowledge},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  booktitle={International Conference on Medical Image Computing and Computer-Assisted Intervention},
  pages={173--183},
  year={2024},
  organization={Springer}
}
```
Actes de la conférence SPIE sur l’Imagerie Médicale 2025 :


```bib
@inproceedings{mcmaster2025technical,
  title={A technical assessment of latent diffusion for Alzheimer's disease progression},
  author={McMaster, Elyssa and Puglisi, Lemuel and Gao, Chenyu and Krishnan, Aravind R and Saunders, Adam M and Ravi, Daniele and Beason-Held, Lori L and Resnick, Susan M and Zuo, Lianrui and Moyer, Daniel and others},
  booktitle={Medical Imaging 2025: Image Processing},
  volume={13406},
  pages={505--513},
  year={2025},
  organization={SPIE}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---