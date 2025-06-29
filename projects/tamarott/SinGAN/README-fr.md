# SinGAN

[Projet](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Matériaux supplémentaires](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Présentation (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Implémentation officielle de SinGAN en pytorch, article : "SinGAN: Learning a Generative Model from a Single Natural Image"
#### Prix du meilleur article ICCV 2019 (Marr prize)


## Échantillons aléatoires à partir d’une *seule* image
Avec SinGAN, vous pouvez entraîner un modèle génératif à partir d’une seule image naturelle, puis générer des échantillons aléatoires à partir de l’image donnée, par exemple :

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Applications de SinGAN
SinGAN peut également être utilisé pour une série de tâches de manipulation d’images, par exemple :
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Cela se fait en injectant une image dans le modèle déjà entraîné. Voir la section 4 de notre [article](https://arxiv.org/pdf/1905.01164.pdf) pour plus de détails.


### Citation
Si vous utilisez ce code dans le cadre de vos recherches, veuillez citer notre article :

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Code

### Installer les dépendances

```
python -m pip install -r requirements.txt
```

Ce code a été testé avec python 3.6, torch 1.4

Veuillez noter : le code ne supporte actuellement que torch 1.4 ou antérieur à cause du schéma d’optimisation.

Pour les versions ultérieures de torch, vous pouvez essayer ce dépôt : https://github.com/kligvasser/SinGAN (les résultats ne seront pas nécessairement identiques à l’implémentation officielle).


### Entraînement
Pour entraîner le modèle SinGAN sur votre propre image, placez l’image d’entraînement souhaitée dans Input/Images, puis lancez

```
python main_train.py --input_name <nom_du_fichier_image>
```

Cela utilisera également le modèle entraîné pour générer des échantillons aléatoires à partir de l’échelle la plus grossière (n=0).

Pour exécuter ce code sur une machine CPU, spécifiez `--not_cuda` lors de l’appel de `main_train.py`

### Échantillons aléatoires
Pour générer des échantillons aléatoires à partir de n’importe quelle échelle de génération, veuillez d’abord entraîner le modèle SinGAN sur l’image désirée (comme décrit ci-dessus), puis lancez 

```
python random_samples.py --input_name <nom_du_fichier_image_d_entrainement> --mode random_samples --gen_start_scale <numéro_de_l_échelle_de_départ>
```

attention : pour utiliser le modèle complet, spécifiez l’échelle de génération de départ à 0, pour commencer à la deuxième échelle, spécifiez 1, et ainsi de suite. 

### Échantillons aléatoires de tailles arbitraires
Pour générer des échantillons aléatoires de tailles arbitraires, veuillez d’abord entraîner le modèle SinGAN sur l’image souhaitée (comme décrit ci-dessus), puis lancez 

```
python random_samples.py --input_name <nom_du_fichier_image_d_entrainement> --mode random_samples_arbitrary_sizes --scale_h <facteur_de_redimensionnement_horizontal> --scale_v <facteur_de_redimensionnement_vertical>
```

### Animation à partir d’une seule image

Pour générer une courte animation à partir d’une seule image, lancez

```
python animation.py --input_name <nom_du_fichier_image> 
```

Cela démarrera automatiquement une nouvelle phase d’entraînement avec un mode de padding bruit.

### Harmonisation

Pour harmoniser un objet collé dans une image (voir exemple Fig. 13 dans [notre article](https://arxiv.org/pdf/1905.01164.pdf)), veuillez d’abord entraîner le modèle SinGAN sur l’image de fond souhaitée (comme décrit ci-dessus), puis sauvegardez l’image de référence collée naïvement et son masque binaire sous "Input/Harmonization" (voir les images enregistrées pour un exemple). Exécutez la commande

```
python harmonization.py --input_name <nom_du_fichier_image_d_entrainement> --ref_name <nom_du_fichier_image_référence_collée_naïvement> --harmonization_start_scale <échelle_d_injection>

```

Veuillez noter que différentes échelles d’injection produiront des effets d’harmonisation différents. L’échelle d’injection la plus grossière est égale à 1. 

### Édition

Pour éditer une image (voir exemple Fig. 12 dans [notre article](https://arxiv.org/pdf/1905.01164.pdf)), veuillez d’abord entraîner le modèle SinGAN sur l’image non éditée souhaitée (comme décrit ci-dessus), puis sauvegardez l’édition naïve comme image de référence sous "Input/Editing" avec une carte binaire correspondante (voir les images enregistrées pour un exemple). Exécutez la commande

```
python editing.py --input_name <nom_du_fichier_image_d_entrainement> --ref_name <nom_du_fichier_image_éditée> --editing_start_scale <échelle_d_injection>
```
les sorties masquées et non masquées seront enregistrées.
Ici aussi, différentes échelles d'injection produiront des effets d’édition différents. L’échelle d’injection la plus grossière est égale à 1.

###  Paint to Image

Pour transférer une peinture en une image réaliste (voir exemple dans la Fig. 11 de [notre article](https://arxiv.org/pdf/1905.01164.pdf)), veuillez d’abord entraîner le modèle SinGAN sur l’image souhaitée (comme décrit ci-dessus), puis sauvegardez votre peinture dans "Input/Paint", et exécutez la commande suivante

```
python paint2image.py --input_name <nom_fichier_image_entraînement> --ref_name <nom_fichier_image_peinture> --paint_start_scale <échelle d’injection>
```
Ici aussi, différentes échelles d'injection produiront des effets d’édition différents. L’échelle d’injection la plus grossière est égale à 1.

Option avancée : Spécifiez quantization_flag à True, pour réentraîner *uniquement* le niveau d’injection du modèle, afin d’obtenir une version à couleurs quantifiées des images générées suréchantillonnées à partir de l’échelle précédente. Pour certaines images, cela peut conduire à des résultats plus réalistes.

### Super Résolution
Pour super-résoudre une image, exécutez :
```
python SR.py --input_name <nom_fichier_image_BF>
```
Cela entraînera automatiquement un modèle SinGAN correspondant à un facteur de suréchantillonnage 4x (si non déjà existant).
Pour différents facteurs de SR, veuillez le spécifier à l'aide du paramètre `--sr_factor` lors de l’appel de la fonction.
Les résultats de SinGAN sur le jeu de données BSD100 peuvent être téléchargés depuis le dossier 'Downloads'.

## Données et fonctions supplémentaires

### Single Image Fréchet Inception Distance (score SIFID)
Pour calculer le SIFID entre des images réelles et leurs échantillons générés correspondants, exécutez :
```
python SIFID/sifid_score.py --path2real <chemin_images_réelles> --path2fake <chemin_images_fausses> 
```  
Assurez-vous que le nom de fichier de chaque image générée soit identique à celui de son image réelle correspondante. Les images doivent être enregistrées au format `.jpg`.

### Résultats de Super Résolution
Les résultats de SR de SinGAN sur le jeu de données BSD100 peuvent être téléchargés depuis le dossier 'Downloads'.

### Étude Utilisateur
Les données utilisées pour l’étude utilisateur se trouvent dans le dossier Downloads.

dossier real : 50 images réelles, sélectionnées au hasard depuis la [base de données places](http://places.csail.mit.edu/)

dossier fake_high_variance : échantillons aléatoires à partir de n=N pour chacune des images réelles

dossier fake_mid_variance : échantillons aléatoires à partir de n=N-1 pour chacune des images réelles

Pour plus de détails, veuillez consulter la section 3.1 de notre [article](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---