# StyTr^2 : Transferência de Estilo de Imagem com Transformers (CVPR2022)
*Autores: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, Xingjia Pan, Weiming Dong, Chongyang Ma, Changsheng Xu*

Este artigo propõe alcançar uma transferência de estilo de imagem imparcial baseada no modelo transformer. Podemos promover o efeito de estilização em comparação com métodos de última geração.
Este repositório é a implementação oficial de [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Apresentação dos Resultados 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
Comparado com alguns algoritmos de ponta, nosso método tem uma forte capacidade de evitar vazamento de conteúdo e apresenta melhor habilidade de representação de características.  <br>

## Estrutura
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
O fluxo geral do nosso framework StyTr^2. Separamos as imagens de conteúdo e estilo em patches e usamos uma projeção linear para obter sequências de imagens. Em seguida, as sequências de conteúdo, acrescidas de CAPE, são alimentadas no codificador transformer de conteúdo, enquanto as sequências de estilo vão para o codificador transformer de estilo. Após os dois codificadores transformer, um decodificador transformer de múltiplas camadas é utilizado para estilizar as sequências de conteúdo de acordo com as sequências de estilo. Finalmente, usamos um decodificador progressivo de upsampling para obter as imagens estilizadas em alta resolução.

## Experimento
### Requisitos
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Teste 
Modelos pré-treinados: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Por favor, faça o download deles e coloque-os na pasta ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Treinamento  
O dataset de estilo é o WikiArt, coletado de [WIKIART](https://www.wikiart.org/)  <br>  
O dataset de conteúdo é o COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Referência
Se você achar nosso trabalho útil para sua pesquisa, por favor cite nosso artigo utilizando a seguinte entrada BibTeX ~ Obrigado ^ . ^. Link do artigo [pdf](https://arxiv.org/abs/2105.14576)<br> 
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