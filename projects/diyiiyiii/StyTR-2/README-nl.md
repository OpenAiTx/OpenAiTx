# StyTr^2 : Beeldoverdracht van stijl met Transformers (CVPR2022)
*Auteurs: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

Dit artikel stelt een methode voor om onbevooroordeelde beeldoverdracht van stijl te bereiken op basis van het transformer-model. We kunnen het stylisatie-effect verbeteren in vergelijking met de meest geavanceerde methoden.
Deze repository is de officiële implementatie van [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Resultatenpresentatie 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
Vergeleken met enkele state-of-the-art algoritmen heeft onze methode een sterk vermogen om contentlekkage te vermijden en een betere featurerepresentatie.  <br>

## Framework
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
Het algemene schema van ons StyTr^2-framework. We splitsen de content- en stijlbeelden in patches en gebruiken een lineaire projectie om beeldsequenties te verkrijgen. Vervolgens worden de contentsequenties, waaraan CAPE is toegevoegd, gevoed aan de content-transformer-encoder, terwijl de stijlsequenties aan de stijl-transformer-encoder worden gevoed. Na de twee transformer-encoders wordt een multi-layer transformer-decoder toegepast om de contentsequenties te styliseren volgens de stijlsequenties. Ten slotte gebruiken we een progressieve upsampling-decoder om gestileerde beelden met hoge resolutie te verkrijgen.

## Experiment
### Vereisten
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Testen 
Voorgetrainde modellen: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Download deze en plaats ze in de map ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Training  
De stijl-dataset is WikiArt, verzameld van [WIKIART](https://www.wikiart.org/)  <br>  
De content-dataset is COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Referentie
Als u ons werk nuttig vindt voor uw onderzoek, citeer dan ons artikel met de volgende BibTeX-entry ~ Dank u ^ . ^. Paper Link [pdf](https://arxiv.org/abs/2105.14576)<br> 
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