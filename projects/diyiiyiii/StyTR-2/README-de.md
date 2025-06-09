# StyTr^2 : Bildstiltransfer mit Transformern (CVPR2022)
*Autoren: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

In dieser Arbeit wird ein Ansatz vorgestellt, um einen unbeeinflussten Bildstiltransfer auf Basis des Transformer-Modells zu erreichen. Im Vergleich zu aktuellen Methoden können wir den Stilisierungseffekt verbessern.
Dieses Repository ist die offizielle Implementierung von [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Ergebnispräsentation 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
Im Vergleich zu einigen modernen Algorithmen besitzt unsere Methode eine starke Fähigkeit zur Vermeidung von Inhaltsverlust und eine bessere Fähigkeit zur Merkmalsrepräsentation.  <br>


## Framework
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
Die Gesamtpipeline unseres StyTr^2-Frameworks. Wir teilen die Inhalts- und Stilbilder in Patches auf und verwenden eine lineare Projektion, um Bildsequenzen zu erhalten. Dann werden die mit CAPE angereicherten Inhaltssequenzen dem Content-Transformer-Encoder zugeführt, während die Stilsequenzen dem Style-Transformer-Encoder zugeführt werden. Nach den beiden Transformer-Encodern wird ein mehrschichtiger Transformer-Decoder verwendet, um die Inhaltssequenzen gemäß den Stilsequenzen zu stilisieren. Schließlich verwenden wir einen progressiven Upsampling-Decoder, um die stilisierten Bilder mit hoher Auflösung zu erhalten.



## Experiment
### Anforderungen
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Testen 
Vorgefertigte Modelle: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Bitte laden Sie diese herunter und legen Sie sie in den Ordner ./experiments/ ab.  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Training  
Das Stil-Datenset ist WikiArt, gesammelt von [WIKIART](https://www.wikiart.org/)  <br>  
Das Inhalts-Datenset ist COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Referenz
Wenn Sie unsere Arbeit in Ihrer Forschung verwenden, zitieren Sie bitte unser Paper mit dem folgenden BibTeX-Eintrag ~ Vielen Dank ^ . ^. Paper Link [pdf](https://arxiv.org/abs/2105.14576)<br> 
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