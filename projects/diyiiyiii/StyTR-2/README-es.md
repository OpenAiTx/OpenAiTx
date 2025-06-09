# StyTr^2 : Transferencia de Estilo de Imagen con Transformers (CVPR2022)
*Autores: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, Xingjia Pan, Weiming Dong, Chongyang Ma, Changsheng Xu*

Este artículo propone lograr una transferencia de estilo de imagen sin sesgos basada en el modelo transformer. Podemos mejorar el efecto de estilización en comparación con los métodos más avanzados.
Este repositorio es la implementación oficial de [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Presentación de Resultados 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
En comparación con algunos algoritmos de última generación, nuestro método tiene una fuerte capacidad para evitar la fuga de contenido y una mejor capacidad de representación de características.  <br>

## Marco de trabajo
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
El flujo general de nuestra estructura StyTr^2. Dividimos las imágenes de contenido y estilo en parches, y usamos una proyección lineal para obtener secuencias de imágenes. Luego, las secuencias de contenido, a las que se les añade CAPE, se introducen en el codificador transformer de contenido, mientras que las secuencias de estilo se introducen en el codificador transformer de estilo. Después de los dos codificadores transformer, se adopta un decodificador transformer de múltiples capas para estilizar las secuencias de contenido según las secuencias de estilo. Finalmente, utilizamos un decodificador de aumento progresivo de resolución para obtener las imágenes estilizadas en alta resolución.

## Experimento
### Requisitos
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Pruebas 
Modelos preentrenados: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Por favor descárguelos y colóquelos en la carpeta ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Entrenamiento  
El dataset de estilos es WikiArt recopilado de [WIKIART](https://www.wikiart.org/)  <br>  
El dataset de contenido es COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Referencia
Si encuentra útil nuestro trabajo en su investigación, por favor cite nuestro artículo usando la siguiente entrada BibTeX ~ Gracias ^ . ^. Enlace al artículo [pdf](https://arxiv.org/abs/2105.14576)<br> 
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