# SinGAN

[Projeto](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Materiais suplementares](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Palestra (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Implementação oficial em pytorch do artigo: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### Prêmio de melhor artigo do ICCV 2019 (Marr prize)


## Amostras aleatórias de uma *única* imagem
Com o SinGAN, você pode treinar um modelo generativo a partir de uma única imagem natural e, em seguida, gerar amostras aleatórias a partir da imagem fornecida, por exemplo:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Aplicações do SinGAN
O SinGAN também pode ser usado para uma série de tarefas de manipulação de imagens, por exemplo:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Isso é feito injetando uma imagem no modelo já treinado. Veja a seção 4 do nosso [artigo](https://arxiv.org/pdf/1905.01164.pdf) para mais detalhes.


### Citação
Se você utilizar este código em sua pesquisa, por favor cite nosso artigo:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar e Dekel, Tali e Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Código

### Instalar dependências

```
python -m pip install -r requirements.txt
```

Este código foi testado com python 3.6, torch 1.4

Atenção: o código atualmente suporta apenas torch 1.4 ou anterior devido ao esquema de otimização.

Para versões mais recentes do torch, você pode tentar este repositório: https://github.com/kligvasser/SinGAN (os resultados podem não ser necessariamente idênticos à implementação oficial).


###  Treinar
Para treinar o modelo SinGAN em sua própria imagem, coloque a imagem desejada para treino em Input/Images e execute

```
python main_train.py --input_name <input_file_name>
```

Isso também utilizará o modelo treinado resultante para gerar amostras aleatórias a partir da escala mais grosseira (n=0).

Para executar este código em uma máquina cpu, especifique `--not_cuda` ao chamar `main_train.py`

###  Amostras aleatórias
Para gerar amostras aleatórias a partir de qualquer escala inicial de geração, primeiro treine o modelo SinGAN na imagem desejada (como descrito acima), depois execute

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

atenção: para usar o modelo completo, especifique a escala inicial de geração como 0, para iniciar a geração a partir da segunda escala, especifique 1 e assim por diante.

###  Amostras aleatórias de tamanhos arbitrários
Para gerar amostras aleatórias de tamanhos arbitrários, primeiro treine o modelo SinGAN na imagem desejada (como descrito acima), depois execute

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  Animação a partir de uma única imagem

Para gerar uma animação curta a partir de uma única imagem, execute

```
python animation.py --input_name <input_file_name> 
```

Isso iniciará automaticamente uma nova fase de treinamento com modo de preenchimento de ruído.

###  Harmonização

Para harmonizar um objeto colado em uma imagem (veja exemplo na Fig. 13 do [nosso artigo](https://arxiv.org/pdf/1905.01164.pdf)), primeiro treine o modelo SinGAN na imagem de fundo desejada (como descrito acima), depois salve a imagem de referência colada de forma ingênua e sua máscara binária em "Input/Harmonization" (veja as imagens salvas como exemplo). Execute o comando

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

Observe que diferentes escalas de injeção produzirão diferentes efeitos de harmonização. A escala de injeção mais grosseira equivale a 1.

###  Edição

Para editar uma imagem (veja exemplo na Fig. 12 do [nosso artigo](https://arxiv.org/pdf/1905.01164.pdf)), primeiro treine o modelo SinGAN na imagem não editada desejada (como descrito acima), depois salve a edição ingênua como uma imagem de referência em "Input/Editing" com o mapa binário correspondente (veja as imagens salvas como exemplo). Execute o comando

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
tanto a saída mascarada quanto a não mascarada serão salvas.
Aqui também, diferentes escalas de injeção produzirão diferentes efeitos de edição. A escala de injeção mais grosseira é igual a 1.

###  Pintar para Imagem

Para transferir uma pintura para uma imagem realista (veja o exemplo na Fig. 11 em [nosso artigo](https://arxiv.org/pdf/1905.01164.pdf)), por favor, primeiro treine o modelo SinGAN na imagem desejada (conforme descrito acima), depois salve sua pintura em "Input/Paint", e execute o comando

```
python paint2image.py --input_name <nome_do_arquivo_de_imagem_de_treinamento> --ref_name <nome_do_arquivo_da_pintura> --paint_start_scale <escala_para_injetar>
```
Aqui também, diferentes escalas de injeção produzirão diferentes efeitos de edição. A escala de injeção mais grosseira é igual a 1.

Opção avançada: Especifique quantization_flag como True, para re-treinar *apenas* o nível de injeção do modelo, para obter uma versão quantizada em cores das imagens geradas aumentadas da escala anterior. Para algumas imagens, isso pode levar a resultados mais realistas.

### Super Resolução
Para super-resolver uma imagem, por favor, execute:
```
python SR.py --input_name <nome_do_arquivo_de_imagem_LR>
```
Isso irá automaticamente treinar um modelo SinGAN correspondente ao fator de upsampling 4x (se ainda não existir).
Para diferentes fatores de SR, por favor, especifique usando o parâmetro `--sr_factor` ao chamar a função.
Os resultados do SinGAN no conjunto de dados BSD100 podem ser baixados na pasta 'Downloads'.

## Dados e Funções Adicionais

### Single Image Fréchet Inception Distance (SIFID score)
Para calcular o SIFID entre imagens reais e suas respectivas amostras falsas, por favor, execute:
```
python SIFID/sifid_score.py --path2real <caminho_para_imagens_reais> --path2fake <caminho_para_imagens_falsas> 
```
Certifique-se de que o nome do arquivo de cada imagem falsa seja idêntico ao nome do arquivo da sua respectiva imagem real. As imagens devem ser salvas no formato `.jpg`.

### Resultados de Super Resolução
Os resultados de SR do SinGAN no conjunto de dados BSD100 podem ser baixados na pasta 'Downloads'.

### Estudo de Usuário
Os dados usados para o estudo de usuário podem ser encontrados na pasta Downloads.

pasta real: 50 imagens reais, escolhidas aleatoriamente do [banco de dados places](http://places.csail.mit.edu/)

pasta fake_high_variance: amostras aleatórias começando de n=N para cada uma das imagens reais

pasta fake_mid_variance: amostras aleatórias começando de n=N-1 para cada uma das imagens reais

Para mais detalhes, veja a seção 3.1 em nosso [artigo](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---