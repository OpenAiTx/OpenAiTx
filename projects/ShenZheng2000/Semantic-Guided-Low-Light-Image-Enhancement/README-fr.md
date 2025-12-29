# Semantic-Guided-Low-Light-Image-Enhancement
Ceci est l'implémentation officielle en Pytorch de notre article "**Apprentissage Zero-Shot Guidé par la Sémantique pour l'Amélioration d'Images/Vidéos en Basse Lumière**" 

# Mises à jour
- 2021.11.27 : La figure de l'architecture du modèle a été téléchargée.
- 2021.11.10 : Ce travail est accepté et sera présenté à [WACV 2022](https://wacv2022.thecvf.com/home).
- 2021.10.8 : Une méthode simple pour calculer les scores mPA et mIOU est disponible dans ce [dépôt](https://github.com/ShenZheng2000/DarkCityScape_mIOU_mPA)
- 2021.10.6 : Une vidéo échantillon améliorée en basse lumière au format GIF a été publiée. 
- 2021.10.5 : Une vidéo échantillon en basse lumière et son résultat amélioré sont disponibles ici : [[Basse lumière](https://www.youtube.com/watch?v=4Avy_xsczdU)]  [[Améliorée](https://www.youtube.com/watch?v=rN6Tf1E-kE8)]
- 2021.10.5 : Mon nouveau [dépôt](https://github.com/ShenZheng2000/Awesome-Low-Light-Enhancement-with-Deep-Learning) contient une collection de méthodes d'amélioration en basse lumière. J'espère que vous le trouverez utile. 
- 2021.10.4 : Le lien arxiv est disponible à http://arxiv.org/abs/2110.00970


# Résumé
Low-light images challenge both human perceptions and computer vision algorithms. It is crucial to make algorithms robust to enlighten low-light images for computational photography and computer vision applications such as real-time detection and segmentation tasks. This paper proposes a semantic-guided zero-shot low-light enhancement network which is trained in the absence of paired images, unpaired datasets, and segmentation annotation. Firstly, we design an efficient **enhancement factor extraction** network using depthwise separable convolution. Secondly, we propose a **recurrent image enhancement** network for progressively enhancing the low-light image. Finally, we introduce an **unsupervised semantic segmentation** network for preserving the semantic information. Extensive experiments on various benchmark datasets and a low-light video demonstrate that our model outperforms the previous state-of-the-art qualitatively and quantitatively. We further discuss the benefits of the proposed method for low-light detection and segmentation.

# Architecture du Modèle
Cliquez sur le lien suivant pour voir l'architecture du modèle au format pdf.

![Architecture du Modèle](https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/main_architecture.pdf)

# Résultats d'Exemple
## 1. Images Vidéo en Faible Luminosité
De gauche à droite, et de haut en bas : Sombre, Retinex [1], KinD [2], EnlightenGAN [3], Zero-DCE [4], Notre méthode.

<p float="left">
<p align="middle">
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/retinex_net.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/kind.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/enlighten_gan.png" width="250" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/zero_dce.png" width="250" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/F1Crop.png" width="250" />
</p>

## 2. Images en Faible Luminosité (Monde Réel)
De gauche à droite, et de haut en bas : Sombre, PIE [5], LIME [6], Retinex [1], MBLLEN [7], KinD [2], Zero-DCE [4], Notre méthode

<p float="left">
<p align="middle">
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Dark7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/PIE7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/LIME7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Retinex7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/mbllen7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/KinD7.jpg" width="200" />
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/ZeroDCE7.jpg" width="200" /> 
  <img src="https://raw.githubusercontent.com/ShenZheng2000/Semantic-Guided-Low-Light-Image-Enhancement/main/Samples/Ours7.jpg" width="200" />
</p>

# Démarrer

## 1. Prérequis
* CUDA 10.0
* Python 3.6+
* Pytorch 1.0+
* torchvision 0.4+
* opencv-python
* numpy
* pillow
* scikit-image

## 2. Préparer les jeux de données
### Jeu de données de test
- Téléchargez les images officielles de test depuis [BaiduYun](https://pan.baidu.com/s/1pbz0YlOmLqxnazeKrRRUQg) avec le mot de passe `8itq`. 
- Déplacez le fichier décompressé dans `data/test_data/`. 
- Vous pouvez également placer des jeux de données personnalisés ou vos propres images en basse lumière dans ce dossier pour les tests. Exemple : `data/test_data/yourDataset/`

### Jeu de données d'entraînement
- Téléchargez les images officielles d'entraînement depuis [GoogleDrive](https://drive.google.com/file/d/1GAB3uGsmAyLgtDBDONbil08vVu5wJcG3/view). 
- Déplacez le fichier décompressé dans `data/train_data/`. 

NOTE : Si vous n'avez pas de compte BaiduYun, vous pouvez télécharger à la fois le jeu de données d'entraînement et celui de test via [Google Drive](https://drive.google.com/drive/folders/1RIQsP5ap5QU7LstHPknOffQZeqht_FCh)

Après préparation, les dossiers de données devraient ressembler à ceci :
```
data/
├── test_data/
│   ├── lowCUT/
│   ├── BDD/
│   ├── Cityscapes/
│   ├── DICM/
│   ├── LIME/
│   ├── LOL/
│   ├── MEF/
│   ├── NPE/
│   └── VV/
└── train_data/
    └── ...
```

## 3. Entraînement à partir de zéro
Pour entraîner le modèle :
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights
```

Exemple (entraîner à partir de zéro) :
```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/
```

## 4. Reprendre l'entraînement

Pour reprendre l'entraînement à partir d'un point de contrôle :
```
python train.py \
  --lowlight_images_path path/to/train_images \
  --snapshots_folder path/to/save_weights \
  --load_pretrain True \
  --pretrain_dir path/to/checkpoint.pth
```
Exemple (reprendre depuis Epoch99.pth) :

```
python train.py \
  --lowlight_images_path data/train_data \
  --snapshots_folder weight/ \
  --load_pretrain True \
  --pretrain_dir weight/Epoch99.pth
```
 
## 5. Tests
**REMARQUE : Veuillez supprimer tous les fichiers readme.txt dans le dossier `data` pour éviter les erreurs d'inférence du modèle.**

Pour tester le modèle :

```
python test.py \
  --input_dir path/to/your_input_images \
  --weight_dir path/to/pretrained_model.pth \
  --test_dir path/to/output_folder 
```
Exemple :

```
python test.py \
  --input_dir data/test_data/lowCUT \
  --weight_dir weight/Epoch99.pth \
  --test_dir test_output
```

## 6. Tests sur les vidéos
Pour tester le modèle sur des vidéos (format MP4), exécutez dans le terminal :
```
bash test_video.sh
```

Il y a cinq hyperparamètres dans `demo/make_video.py` pour le test vidéo. Voir l'explication suivante.  
- `video_path` : chemin de la vidéo en faible luminosité  
- `image_lowlight_folder` : chemin des images en faible luminosité  
- `image_folder` : chemin des images améliorées  
- `save_path` : chemin de la vidéo améliorée  
- `choice` : conversion vidéo vers image, ou image vers vidéo  


# Hyperparamètres  
| Nom                  | Type  | Défaut             |  
|----------------------|-------|--------------------|  
| lowlight_images_path  | str   | data/train_data/   |          
| lr                   | float | 1e-3               |          
| weight_decay         | float | 1e-3               |            
| grad_clip_norm       | float | 0.1                |            
| num_epochs           | int   | 100                |          
| train_batch_size     | int   | 6                  |          
| val_batch_size       | int   | 8                  |           
| num_workers          | int   | 4                  |         
| display_iter         | int   | 10                 |         
| snapshot_iter        | int   | 10                 |        
| scale_factor         | int   | 1                  |         
| snapshots_folder     | str   | weight/            |         
| load_pretrain        | bool  | False              |       
| pretrain_dir         | str   | weight/Epoch99.pth |         
| num_of_SegClass      | int   | 21                 |        
| conv_type            | str   | dsc                |        
| patch_size           | int   | 4                  |        
| exp_level            | float | 0.6                |        


# Liste TODO  
- [x] Lister les hyperparamètres (importants)  
- [x] Résoudre le problème de taille d'entrée du modèle  
- [x] Télécharger les poids pré-entraînés  
- [x] Réécrire argparse d'entraînement et test dans un option.py  
- [x] Réécrire l'entraînement sous forme de classe  
- [x] Réécrire le test sous forme de classe  
- [x] Télécharger le jeu de données de test
- [x] Télécharger le lien Arxiv
- [x] Tester sur vidéo
- [x] Télécharger le BibTeX
- [x] Modifier le fichier Readme
- [x] Télécharger l’architecture du modèle
- [ ] Fournir une démo en ligne
# Autres
Veuillez contacter zhengsh@kean.edu si vous avez des questions. Ce dépôt est largement basé sur [Zero-DCE](https://github.com/Li-Chongyi/Zero-DCE). Merci de partager le code !

# Citations
Veuillez citer l’article suivant si vous trouvez ce dépôt utile.
```
@inproceedings{zheng2022semantic,
  title={Semantic-guided zero-shot learning for low-light image/video enhancement},
  author={Zheng, Shen and Gupta, Gaurav},
  booktitle={Proceedings of the IEEE/CVF Winter Conference on Applications of Computer Vision},
  pages={581--590},
  year={2022}
}
```


# Références
[1] Wei, Chen, et al. « Deep retinex decomposition for low-light enhancement. » arXiv preprint arXiv:1808.04560 (2018).

[2] Zhang, Yonghua, Jiawan Zhang, et Xiaojie Guo. « Kindling the darkness: A practical low-light image enhancer. » Proceedings of the 27th ACM international conference on multimedia. 2019.

[3] Jiang, Yifan, et al. « Enlightengan: Deep light enhancement without paired supervision. » IEEE Transactions on Image Processing 30 (2021): 2340-2349.

[4] Guo, Chunle, et al. « Zero-reference deep curve estimation for low-light image enhancement. » Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition. 2020.

[5] Fu, Xueyang, et al. « A probabilistic method for image enhancement with simultaneous illumination and reflectance estimation. » IEEE Transactions on Image Processing 24.12 (2015): 4965-4977.

[6] Guo, Xiaojie, Yu Li, et Haibin Ling. « LIME: Low-light image enhancement via illumination map estimation. » IEEE Transactions on image processing 26.2 (2016): 982-993.

[7] Lv, Feifan, et al. « MBLLEN: Low-Light Image/Video Enhancement Using CNNs. » BMVC. 2018.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---