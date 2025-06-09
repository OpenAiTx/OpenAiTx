# StyTr^2 : Transfer stylu obrazu z wykorzystaniem Transformerów (CVPR2022)
*Autorzy: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

W tej pracy zaproponowano osiągnięcie niezależnego transferu stylu obrazu w oparciu o model transformerowy. Możemy uzyskać lepszy efekt stylizacji w porównaniu z najnowocześniejszymi metodami.
To repozytorium zawiera oficjalną implementację [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Prezentacja wyników 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
W porównaniu z niektórymi najnowocześniejszymi algorytmami, nasza metoda ma silną zdolność do unikania wycieku zawartości i lepszą zdolność reprezentacji cech.  <br>


## Framework
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
Ogólny schemat działania naszego frameworku StyTr^2. Dzielimy obrazy treści i stylu na fragmenty (patches) i używamy projekcji liniowej do uzyskania sekwencji obrazów. Następnie sekwencje treści z dodanym CAPE są przekazywane do enkodera transformera treści, natomiast sekwencje stylu są przekazywane do enkodera transformera stylu. Po obu enkoderach transformerowych stosowany jest wielowarstwowy dekoder transformerowy, który stylizuje sekwencje treści zgodnie z sekwencjami stylu. Na końcu używamy progresywnego dekodera upsamplującego do uzyskania stylizowanych obrazów w wysokiej rozdzielczości.



## Eksperyment
### Wymagania
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Testowanie 
Wytrenowane modele: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Proszę pobrać je i umieścić w folderze ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Trening  
Zbiór danych stylu to WikiArt zebrany z [WIKIART](https://www.wikiart.org/)  <br>  
Zbiór danych zawartości to COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Odniesienie
Jeśli nasza praca okaże się przydatna w Twoich badaniach, prosimy o zacytowanie naszej publikacji używając poniższego wpisu BibTeX ~ Dziękujemy ^ . ^. Link do publikacji [pdf](https://arxiv.org/abs/2105.14576)<br> 
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