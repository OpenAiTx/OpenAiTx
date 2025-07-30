# 3DGS.zip : Une enquête sur les méthodes de compression 3D Gaussian Splatting  
Ce dépôt contient une enquête complète sur les méthodes de compression 3D Gaussian Splatting (3DGS). Vous pouvez consulter le tableau complet de l’enquête et les graphiques de comparaison sur [w-m.github.io/3dgs-compression-survey/](https://w-m.github.io/3dgs-compression-survey/).  

## Installation  
Pour exécuter les scripts de ce dépôt, assurez-vous d’avoir toutes les dépendances nécessaires installées. Vous pouvez les installer avec la commande suivante :  

`pip install -r requirements.txt`  

## Construction du site  
Pour construire le site, utilisez la commande suivante :  

`python data_extraction/build_html.py`  

Ce script s’exécute également automatiquement pour reconstruire le site chaque fois que des modifications sont poussées sur la branche principale.  

## Récupération des résultats  
Vous pouvez récupérer les résultats automatiquement en exécutant :  

`python data_extraction/data_extraction.py`  

Ce script tente de récupérer les données des articles pertinents et de mettre à jour les tableaux dans le dossier `results`. Pour ajouter un nouvel article, créez une entrée dans `data_extraction/data_source.yaml`.  

## Inclusion de vos propres résultats  

Les auteurs sont priés de télécharger leurs résultats par scène dans un dossier désigné au sein de leur dépôt GitHub. Cela garantit une récupération précise des données et permet des comparaisons cohérentes et équitables. La structure de dossier attendue est :

```
results
├── DeepBlending
│   ├── drjohnson.csv
│   └── playroom.csv
├── MipNeRF360
│   ├── bicycle.csv
│   ├── bonsai.csv
│   ├── counter.csv
│   ├── flowers.csv
│   ├── garden.csv
│   ├── kitchen.csv
│   ├── room.csv
│   ├── stump.csv
│   └── treehill.csv
├── SyntheticNeRF
│   ├── chair.csv
│   ├── drums.csv
│   ├── ficus.csv
│   ├── hotdog.csv
│   ├── lego.csv 
│   ├── materials.csv
│   ├── mic.csv
│   └── ship.csv
└── TanksAndTemples
    ├── train.csv
    └── truck.csv
```
Le dossier doit inclure tous les ensembles de données sur lesquels votre méthode a été évaluée et couvrir toutes les scènes spécifiées dans la structure du dossier.

Chaque fichier CSV doit être structuré comme suit :


```
Submethod,PSNR,SSIM,LPIPS,Size [Bytes],#Gaussians
Baseline,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
-SubmethodName,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx

```
Veuillez vous assurer que les résultats PSNR sont rapportés avec une précision d'au moins deux décimales, et que les résultats SSIM et LPIPS sont rapportés avec une précision d'au moins trois décimales. Les auteurs sont encouragés à fournir les résultats avec une précision complète, car ceux-ci seront arrondis avant inclusion dans notre enquête.

Incluez jusqu'à deux noms de sous-méthodes cohérents pour vos résultats dans tous les fichiers afin de garantir leur apparition dans le tableau de l'enquête. Ces noms seront ensuite concaténés avec le nom de votre approche dans le tableau. Si le spécificateur de sous-méthode doit être séparé du nom de la méthode par un espace, veillez à inclure cet espace devant le nom de la sous-méthode. Si vous préférez que seul le nom de votre approche soit affiché dans le tableau, vous pouvez utiliser "Baseline" comme nom de sous-méthode pour ces résultats. Les résultats sans nom de sous-méthode ne seront affichés que dans les graphiques.

Vous pouvez consulter un exemple [ici](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/tree/main/results).

### Important : conventions de test 3DGS

Les auteurs doivent respecter les conventions de test établies dans le projet original [3DGS](https://github.com/graphdeco-inria/gaussian-splatting). Cela inclut notamment :

- Utiliser les 9 scènes du dataset MipNeRF360, y compris les [scènes supplémentaires](https://storage.googleapis.com/gresearch/refraw360/360_extra_scenes.zip) "flowers" et "treehill".
- Évaluer les images à résolution complète jusqu'à une longueur maximale de côté de 1600 px. Les images de test plus grandes doivent être réduites afin que la dimension la plus longue soit égale à 1600 px (applicable uniquement à MipNeRF360). Assurez-vous que le redimensionnement corresponde à celui de 3DGS, qui applique la méthode standard PIL ```.resize()``` avec un rééchantillonnage bicubique.
- Pour les 3 datasets COLMAP (Tanks and Temples, Deep Blending, MipNeRF360), utiliser chaque 8ème image pour les tests. Concrètement, les images de test sont celles où ```idx % 8 == 0```.
- Pour le dataset Blender (SyntheticNeRF), suivre la séparation prédéfinie train/éval.


## Tableau LaTeX

Les versions LaTeX à jour des tableaux de l’enquête sont disponibles pour la [compression](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_compression.tex) et la [compaction](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_densification.tex). N’hésitez pas à copier une ligne du tableau dans vos recherches si vous souhaitez comparer à l’approche. Si vous souhaitez copier le tableau entier, vous pourriez avoir besoin des packages et définitions suivants dans votre préambule LaTeX :

```
\usepackage{booktabs}
\usepackage[table]{xcolor}
% colors for table
\definecolor{lightred}{HTML}{FF9999}
\definecolor{lightyellow}{HTML}{FFFF99}
\definecolor{lightorange}{HTML}{FFCC99}
\usepackage{makecell}
\usepackage{adjustbox}
% make text the same size even when its bold in a table
\newsavebox\CBox
\def\textBF#1{\sbox\CBox{#1}\resizebox{\wd\CBox}{\ht\CBox}{\textbf{#1}}}
```

## Citation

Si vous utilisez notre enquête dans vos recherches, veuillez citer notre travail. Vous pouvez utiliser l'entrée BibTeX suivante :

```bibtex
@article{3DGSzip2025,
author = {Bagdasarian, M. T. and Knoll, P. and Li, Y. and Barthel, F. and Hilsmann, A. and Eisert, P. and Morgenstern, W.},
title = {{3DGS.zip}: A {Survey} on {3D} {Gaussian} {Splatting} {Compression} {Methods}},
journal = {Computer Graphics Forum},
pages = {e70078},
year = {2025},
keywords = {CCS Concepts, • Information systems → Data compression, • Computing methodologies → Rasterization, • General and reference → Surveys and overviews},
doi = {https://doi.org/10.1111/cgf.70078},
url = {https://onlinelibrary.wiley.com/doi/abs/10.1111/cgf.70078},
eprint = {https://onlinelibrary.wiley.com/doi/pdf/10.1111/cgf.70078},
note = {\url{https://w-m.github.io/3dgs-compression-survey/}},
} 
```
## Mises à jour
- 2025-04-29 : Article publié, mise à jour du bibtex dans le Readme et sur le site web
- 2025-03-04 : Ajout du résumé de GaussianSpa (fournie par les auteurs).
- 2025-02-26 : Ajout de HEMGS
- 2025-02-25 : Ajout de GaussianSpa
- 2025-02-25 : Ajout de HAC++
- 2025-02-25 : Ajout de FCGS
- 2025-02-10 : Suppression de IGS car la publication est retirée
- 2025-02-05 : Ajout de CodecGS
- 2024-11-21 : Ajout de ContextGS
- 2024-11-07 : Ajout de CompGS
- 2024-11-05 : Mise à jour de la version [arXiv](https://arxiv.org/abs/2407.09510) avec les méthodes de compression et de compactage ainsi que les fondamentaux de la compression 3DGS
- 2024-10-21 : Renommage officiel des méthodes de "densification" en méthodes de "compactage" sur le site pour aligner avec l'article de synthèse
- 2024-10-17 : Ajout de GaussiansPro, AtomGS et Taming3DGS aux méthodes de densification/compactage
- 2024-10-14 : Ajout de MesonGS aux méthodes de compression
- 2024-09-30 : Ajout des méthodes de densification à l’enquête
- 2024-09-17 : Mise à jour des résultats de Morgenstern et al. et retour aux résultats HAC en raison d’une [confusion sur les conventions de test](https://github.com/YihangChen-ee/HAC/issues/14)
- 2024-09-05 : Mise à jour des résultats Scaffold-GS MipNeRF-360 pour inclure les 9 scènes
- 2024-08-27 : Ajout de la méthode IGS à l’enquête
- 2024-08-26 : Ajout de la méthode gsplat à l’enquête
- 2024-08-14 : Rangs adaptatifs basés sur la sélection d’attributs et de jeux de données
- 2024-08-12 : Nouveaux graphiques montrant les métriques en fonction du nombre de Gaussiens au lieu de la taille du modèle
- 2024-08-08 : Ajout de cases à cocher pour sélectionner les métriques et jeux de données à afficher dans le tableau
- 2024-08-07 : Inclusion du nombre de Gaussiens dans l’enquête, inclusion des bits par Gaussien dans le tableau
- 2024-08-02 : Affichage des conférences des articles publiés
- 2024-06-19 : Nouveau calcul de rang avec tous les jeux de données disponibles
- 2024-06-17 : Inclusion des rangs des méthodes
- 2024-06-17 : Publication initiale de l’enquête sur [arXiv](https://arxiv.org/abs/2407.09510)
- 2024-06-13 : Ajout de graphiques des métriques en fonction de la taille du modèle
- 2024-06-10 : Première ébauche de la page d’enquête avec tableau interactif


<!-- - 2024-08-22 : Publication des scènes pré-entraînées et [compressées](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/releases/tag/eccv-2024-data)
- 2024-07-09 : Mise à jour du site du projet avec résumé, contributions, insights et comparaison aux méthodes concurrentes
- 2024-07-01 : Notre travail a été accepté à **ECCV 2024** 🥳
- 2024-06-13 : Code d’entraînement disponible
- 2024-05-14 : Scores de compression améliorés ! Nouveaux résultats pour la version 2 de l’article disponibles sur le [site du projet](https://fraunhoferhhi.github.io/Self-Organizing-Gaussians/)
- 2024-05-02 : Version révisée [article v2](https://arxiv.org/pdf/2312.13299) sur arXiv : ajout de la compression des harmoniques sphériques, mise à jour de la méthode de compression avec résultats améliorés (tous les attributs compressés avec JPEG XL désormais), ajout d’une comparaison qualitative de scènes supplémentaires, déplacement de l’explication de la compression et de la comparaison dans l’article principal, ajout d’une comparaison avec « Making Gaussian Splats smaller ».
- 2024-02-22 : Le code de l’algorithme de tri est désormais disponible sur [fraunhoferhhi/PLAS](https://github.com/fraunhoferhhi/PLAS)
- 2024-02-21 : Comparaisons vidéo pour différentes scènes disponibles sur le [site du projet](https://fraunhoferhhi.github.io/Self-Organizing-Gaussians/)
- 2023-12-19 : Prépublication disponible sur [arXiv](https://arxiv.org/abs/2312.13299) -->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---