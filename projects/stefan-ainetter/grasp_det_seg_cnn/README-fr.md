# Réseau de Neurones Profond Entraînable de Bout en Bout pour la Détection de Saisie Robotique et la Segmentation Sémantique à partir de RGB

<p align="center">
<img src="https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/Network.png" width="100%"/>
<br>
<a href="https://arxiv.org/abs/2107.05287">arXiv</a>
</p>

Ce dépôt contient le code pour l'article ICRA21 "Réseau de Neurones Profond Entraînable de Bout en Bout pour la Détection de Saisie Robotique
et la Segmentation Sémantique à partir de RGB".  
Il contient le code pour l'entraînement et le test de notre méthode proposée en combinaison avec le jeu de données OCID_grasp.  

Si vous utilisez notre méthode ou l'extension du jeu de données pour votre recherche, veuillez citer :
```bibtex
@InProceedings{ainetter2021end,
  title={End-to-end Trainable Deep Neural Network for Robotic Grasp Detection and Semantic Segmentation from RGB},
  author={Ainetter, Stefan and Fraundorfer, Friedrich},
  booktitle={IEEE International Conference on Robotics and Automation (ICRA)},
  pages={13452--13458}
  year={2021}
}
```

## Exigences et configuration

Exigences principales du système :
* CUDA 10.1
* Linux avec GCC 7 ou 8
* PyTorch v1.1.0

**NOTE IMPORTANTE** : Ces exigences ne sont pas nécessairement strictes, par exemple il pourrait être possible de compiler avec des versions plus anciennes
de CUDA, ou sous Windows. Cependant, nous n'avons testé le code que dans les configurations ci-dessus et ne pouvons pas fournir de support pour d'autres configurations.

Pour installer PyTorch, veuillez vous référer à https://github.com/pytorch/pytorch#installation.

Pour installer toutes les autres dépendances avec pip :
```bash
pip install -r requirements.txt
```

### Configuration

Notre code est divisé en deux composants principaux : une bibliothèque contenant les implémentations des différents modules réseau,
algorithmes et utilitaires, et un ensemble de scripts pour entraîner / tester les réseaux.

La bibliothèque, appelée `grasp_det_seg`, peut être installée avec :
```bash
git clone https://github.com/stefan-ainetter/grasp_det_seg_cnn.git
cd grasp_det_seg_cnn
python setup.py install
```

## Modèles entraînés

Les fichiers modèles fournis sont mis à disposition sous la licence [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/).

Un modèle entraîné pour le jeu de données OCID_grasp peut être téléchargé [ici](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_pretrained).  
Téléchargez et copiez les poids téléchargés dans le dossier `ckpt_files_OCID/pretrained`.

Pour réentraîner le réseau sur OCID_grasp, vous devez télécharger les poids préentraînés sur ImageNet  
[ici](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/ImageNet_weights) et les copier  
dans le dossier `weights_pretrained`.

### Entraînement

L'entraînement comprend trois étapes principales : préparer le jeu de données, créer un fichier de configuration et exécuter le script d'entraînement.

Pour préparer le jeu de données :  
1) Téléchargez le jeu de données OCID_grasp [ici](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp).  
Décompressez le fichier `OCID_grasp.zip` téléchargé dans le dossier `DATA`.  
2) Le fichier de configuration est un simple fichier texte au format `ini`.  
La valeur par défaut de chaque paramètre de configuration, ainsi qu'une courte description de sa fonction, est disponible dans  
[grasp_det_seg/config/defaults](grasp_det_seg/config/defaults).  
**Note** que ce ne sont qu'une indication des valeurs "raisonnables" pour chaque paramètre, et ne sont pas  
destinées à reproduire les résultats de notre article.

3) Pour lancer l'entraînement :

```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 train_det_seg_OCID.py 
--log_dir=LOGDIR CONFIG DATA_DIR
```
Les journaux d'entraînement, à la fois au format texte et Tensorboard ainsi que les paramètres du réseau entraîné, seront enregistrés  
dans `LOG_DIR` (par exemple `ckpt_files_OCID`).  
Le fichier `CONFIG` contient la configuration du réseau, par exemple `grasp_det_seg/config/defaults/det_seg_OCID.ini`,  
et `DATA_DIR` pointe vers les partitions OCID_grasp précédemment téléchargées, par exemple `DATA/OCID_grasp/data_split`.  

Notez que, pour l'instant, notre code **doit** être lancé en mode "distribué" utilisant l'utilitaire `torch.distributed.launch` de PyTorch.  

### Exécution de l'inférence  

Étant donné un réseau entraîné, l'inférence peut être effectuée sur n'importe quel ensemble d'images en utilisant  
[scripts/test_det_seg_OCID.py](https://raw.githubusercontent.com/stefan-ainetter/grasp_det_seg_cnn/main/scripts/test_det_seg_OCID.py) :

```bash
cd scripts
python3 -m torch.distributed.launch --nproc_per_node=1 test_det_seg_OCID.py 
--log_dir=LOG_DIR CONFIG MODEL_PARAMS DATA_DIR OUTPUT_DIR

```
Les prédictions seront écrites dans `OUTPUT_DIR` par exemple le dossier `output`. `MODEL_PARAMS` sont des poids pré-entraînés par exemple `ckpt_files_OCID/pretrained/model_last.pth.tar`,  
`DATA_DIR` pointe vers les divisions du jeu de données utilisées par exemple `DATA/OCID_grasp/data_split`.  

## Jeu de données OCID_grasp  
Le jeu de données OCID_grasp peut être téléchargé [ici](https://cloud.tugraz.at/index.php/s/NA7icqiJ5SeNSA6?dir=/Grasp_det_seg_cnn/OCID_grasp).  
OCID_grasp comprend 1763 images RGB-D sélectionnées du jeu de données OCID, avec plus de 11,4k masques d’objets segmentés et plus de 75k candidats à la préhension annotés à la main.  
De plus, chaque objet est classé dans l’une des 31 classes d’objets.  
## Travaux connexes  
OCID_grasp est une extension du jeu de données [OCID](https://www.acin.tuwien.ac.at/en/vision-for-robotics/software-tools/object-clutter-indoor-dataset/).  
Si vous décidez d’utiliser OCID_grasp pour vos recherches, veuillez également citer l’article OCID :
```bibtex
@inproceedings{suchi2019easylabel,
  title={EasyLabel: a semi-automatic pixel-wise object annotation tool for creating robotic RGB-D datasets},
  author={Suchi, Markus and Patten, Timothy and Fischinger, David and Vincze, Markus},
  booktitle={2019 International Conference on Robotics and Automation (ICRA)},
  pages={6678--6684},
  year={2019},
  organization={IEEE}
}
```
Notre cadre est basé sur l'architecture de [Seamless Scene Segmentation](https://github.com/mapillary/seamseg) :
```bibtex
@InProceedings{Porzi_2019_CVPR,
  author = {Porzi, Lorenzo and Rota Bul\`o, Samuel and Colovic, Aleksander and Kontschieder, Peter},
  title = {Seamless Scene Segmentation},
  booktitle = {The IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
  month = {June},
  year = {2019}
}
```
---
## À propos de nos dernières recherches
### Notre article 'Segmentation d'objets consciente de la profondeur et détection de préhension pour les tâches de prélèvement robotique' a été accepté à BMVC21
Dans notre dernier travail, nous avons mis en œuvre une méthode pour la détection conjointe de préhension et la segmentation d'instances d'objets indépendantes de la classe,
qui a été publiée à BMVC21. 
Plus d'informations sont disponibles [ici](https://arxiv.org/pdf/2111.11114).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---