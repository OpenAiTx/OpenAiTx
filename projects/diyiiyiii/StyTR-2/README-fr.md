# StyTr^2 : Transfert de style d’image avec Transformers (CVPR2022)
*Auteurs : [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

Cet article propose de réaliser un transfert de style d’image impartial basé sur le modèle Transformer. Nous pouvons améliorer l’effet de stylisation par rapport aux méthodes de pointe actuelles.
Ce dépôt est l’implémentation officielle de [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Présentation des résultats 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
Comparé à certains algorithmes de pointe, notre méthode présente une forte capacité à éviter la fuite de contenu et possède une meilleure capacité de représentation des caractéristiques.  <br>

## Architecture
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
Le pipeline global de notre cadre StyTr^2. Nous divisons les images de contenu et de style en patchs, puis utilisons une projection linéaire pour obtenir des séquences d’images. Ensuite, les séquences de contenu, additionnées de CAPE, sont introduites dans l’encodeur Transformer de contenu, tandis que les séquences de style sont introduites dans l’encodeur Transformer de style. Après les deux encodeurs Transformer, un décodeur Transformer multi-couches est adopté pour styliser les séquences de contenu selon les séquences de style. Enfin, nous utilisons un décodeur de suréchantillonnage progressif pour obtenir les images stylisées en haute résolution.

## Expérience
### Prérequis
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Test 
Modèles pré-entraînés : [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Veuillez les télécharger et les placer dans le dossier ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Entraînement  
Le jeu de données de style est WikiArt, collecté depuis [WIKIART](https://www.wikiart.org/)  <br>  
Le jeu de données de contenu est COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Référence
Si vous trouvez notre travail utile dans vos recherches, veuillez citer notre article en utilisant l’entrée BibTeX suivante ~ Merci ^ . ^. Lien vers l’article [pdf](https://arxiv.org/abs/2105.14576)<br> 
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---