# StyTr^2 : Transformatörlerle Görüntü Stil Transferi（CVPR2022）
*Yazarlar: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

Bu makale, transformatör modeli tabanlı önyargısız görüntü stil transferi elde etmek için önerilmiştir. Durumun en ileri yöntemleriyle karşılaştırıldığında, stilizasyon etkisini artırabiliyoruz.
Bu depo, [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576) makalesinin resmi uygulamasıdır.

## Sonuçların Sunumu 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
Bazı son teknoloji algoritmalarla karşılaştırıldığında, yöntemimiz içerik sızıntısını önlemede güçlü bir yeteneğe sahip ve daha iyi özellik gösterim kapasitesine sahiptir.  <br>


## Çerçeve
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
StyTr^2 çerçevemizin genel hattı. İçerik ve stil görsellerini parçalara ayırıyor ve doğrusal projeksiyon ile görüntü dizileri elde ediyoruz. Sonrasında CAPE eklenmiş içerik dizileri içerik transformatör kodlayıcısına, stil dizileri ise stil transformatör kodlayıcısına gönderilir. İki transformatör kodlayıcıyı takiben, çok katmanlı bir transformatör kod çözücü, içerik dizilerini stil dizilerine göre stilize etmek için kullanılır. Son olarak, yüksek çözünürlüklü stilize görüntüler elde etmek için aşamalı bir üst örnekleme kod çözücü kullanıyoruz.



## Deney
### Gereksinimler
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Test Etme 
Önceden eğitilmiş modeller: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Lütfen bunları indirip ./experiments/ klasörüne koyunuz  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Eğitim  
Stil veri kümesi [WIKIART](https://www.wikiart.org/) adresinden toplanan WikiArt'tır  <br>  
İçerik veri kümesi ise COCO2014'tür  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Referans
Çalışmamızın araştırmanızda faydalı olduğunu düşünüyorsanız, lütfen aşağıdaki BibTeX girdisini kullanarak makalemizi kaynak gösteriniz ~ Teşekkürler ^ . ^. Makale Linki [pdf](https://arxiv.org/abs/2105.14576)<br> 
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