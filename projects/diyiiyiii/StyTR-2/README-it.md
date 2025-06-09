# StyTr^2 : Trasferimento di Stile delle Immagini con Transformer (CVPR2022)
*Autori: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, Xingjia Pan, Weiming Dong, Chongyang Ma, Changsheng Xu*

Questo articolo è stato proposto per ottenere un trasferimento di stile delle immagini imparziale basato sul modello transformer. Possiamo migliorare l'effetto di stilizzazione rispetto ai metodi all'avanguardia.
Questo repository è l'implementazione ufficiale di [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Presentazione dei risultati 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
Rispetto ad alcuni algoritmi all'avanguardia, il nostro metodo ha una forte capacità di evitare la perdita di contenuto e possiede una migliore capacità di rappresentazione delle caratteristiche.  <br>


## Framework
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
Il flusso generale del nostro framework StyTr^2. Suddividiamo le immagini di contenuto e di stile in patch e utilizziamo una proiezione lineare per ottenere sequenze di immagini. Quindi, le sequenze di contenuto aggiunte con CAPE vengono inserite nell'encoder transformer di contenuto, mentre le sequenze di stile vengono inserite nell'encoder transformer di stile. Dopo i due encoder transformer, viene adottato un decoder transformer multi-strato per stilizzare le sequenze di contenuto in base alle sequenze di stile. Infine, utilizziamo un decoder di upsampling progressivo per ottenere immagini stilizzate ad alta risoluzione.



## Esperimenti
### Requisiti
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Testing 
Modelli pre-addestrati: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Si prega di scaricarli e inserirli nella cartella ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Addestramento  
Il dataset di stile è WikiArt raccolto da [WIKIART](https://www.wikiart.org/)  <br>  
Il dataset di contenuto è COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Riferimenti
Se trovi utile il nostro lavoro per la tua ricerca, cita il nostro articolo utilizzando la seguente voce BibTeX ~ Grazie ^ . ^. Link all'articolo [pdf](https://arxiv.org/abs/2105.14576)<br> 
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