# ARLib 
Un marco de trabajo de código abierto para realizar ataques de envenenamiento de datos en sistemas de recomendación, diseñado para ayudar a investigadores y profesionales. Este repositorio se publica junto con nuestro [artículo de revisión](https://arxiv.org/abs/2406.01022) sobre ataques de envenenamiento contra sistemas de recomendación. <br>

**Miembros:** <br>
Wei Yuan, Universidad de Queensland, Australia, warrenyuan97@gmail.com <br>
Hao Ma, Universidad de Chongqing, China, ma_hao@cqu.edu.cn <br>
Zeao Chen, Universidad de Chongqing, China, zeao_chen@stu.cqu.edu.cn<br>
Chenyu Li, Universidad de Chongqing, China, chenyu_li@stu.cqu.edu.cn

**Creador:** <br>
Zongwei Wang, Universidad de Chongqing, China, zongwei@cqu.edu.cn <br>

**Apoyado por:** <br>
Prof. Min Gao, Universidad de Chongqing, China, gaomin@cqu.edu.cn <br>
Centro de Capacitación ARC para Resiliencia de la Información (CIRES), Universidad de Queensland, Australia

<h2>Marco de trabajo</h2>

<img src="https://github.com/CoderWZW/ARLib/blob/main/img/framework.png" alt="Texto alternativo" width="80%" /><br><br>

<h2>Uso</h2>

1. Dos archivos de configuración **attack_parser.py** y **recommend_parser.py** están en el directorio llamado conf, y puede seleccionar y configurar el modelo de recomendación y el modelo de ataque modificando los archivos de configuración. <br>
2. Ejecute main.py.


<h2>Modelos implementados</h2>

| **Modelo de recomendación** | **Artículo** |
| --- | --- |
| GMF | Yehuda et al. Técnicas de factorización matricial para sistemas de recomendación, IEEE Computer'09.|
| WRMF | Hu et al. Filtrado colaborativo para conjuntos de datos de retroalimentación implícita, KDD'09. |
| NCF | He et al. Filtrado colaborativo neuronal, WWW'17. |
| NGCF | Wang et al. Filtrado colaborativo en grafos neuronal, SIGIR'19. |
| LightGCN | He et al. Lightgcn: Simplificación y potenciación de redes convolucionales de grafos para recomendación, SIGIR'2020. |
| SSL4Rec | Yao et al. Aprendizaje auto-supervisado para recomendaciones de ítems a gran escala. CIKM'2021. |
| NCL | Lin et al. Mejora del filtrado colaborativo en grafos con aprendizaje contrastivo enriquecido por vecindad. WWW'2022. |
| SGL | Wu et al. Aprendizaje auto-supervisado en grafos para recomendación, SIGIR'21. |
| SimGCL | Yu et al. ¿Son necesarias las aumentaciones de grafos? Aprendizaje contrastivo simple en grafos para recomendación, SIGIR'22. |
| XSimGCL | Yu et al. XSimGCL: Hacia un aprendizaje contrastivo en grafos extremadamente simple para recomendación, TKDE'23. |
| **Modelo de Ataque** | **Artículo** | **Caso** |
| --- | --- | --- |
| NoneAttack | N/A | Negro |
| RandomAttack | Lam et al. Shilling Recommender Systems for Fun and Profit. WWW'2004 | Negro |
| BandwagonAttack | Gunes et al. Shilling Attacks against Recommender Systems: A Comprehensive Survey. Artif.Intell.Rev.'2014 | Negro |
| AUSH | Lin C et al. Attacking recommender systems with augmented user profiles. CIKM'2020. | Gris |
| LegUP | Lin C et al. Shilling Black-Box Recommender Systems by Learning to Generate Fake User Profiles. IEEE Transactions on Neural Networks and Learning Systems'2022. | Gris |
| GOAT | Wu et al. Ready for emerging threats to recommender systems? A graph convolution-based generative shilling attack. Information Sciences'2021. | Gris |
| FedRecAttack | Rong et al. Fedrecattack: Model poisoning attack to federated recommendation. ICDE'2022. | Gris |
| A_ra | Rong et al. Poisoning Deep Learning Based Recommender Model in Federated Learning Scenarios. IJCAI'2022. | Gris |
| PGA | Li et al. Data poisoning attacks on factorization-based collaborative filtering. NIPS'2016. | Blanco |
| DL_Attack | Huang et al. Data poisoning attacks to deep learning based recommender systems. arXiv'2021 | Blanco |
| PipAttack | Zhang et al. Pipattack: Poisoning federated recommender systems for manipulating item promotion. WSDM'2022. | Gris |
| RAPU | Zhang et al. Data Poisoning Attack against Recommender System Using Incomplete and Perturbed Data. KDD'2021. | Blanco |
| PoisonRec | Song et al. Poisonrec: an adaptive data poisoning framework for attacking black-box recommender systems. ICDE'2021. | Negro |
| CLeaR | Wang et al. Poisoning Attacks Against Contrastive Recommender Systems. arXiv'2023 | Blanco |
| GTA | Wang et al. Revisiting data poisoning attacks on deep learning based recommender systems. ISCC 2023 | Negro |

<h2>Implemente Su Modelo</h2>

Determine si desea implementar el modelo de ataque o el modelo de recomendación, y luego agregue el archivo bajo el directorio correspondiente. <br>

Si tiene un método de ataque, asegúrese de：<br>
1. Si necesita información del modelo recomendador, y luego configure **self.recommenderGradientRequired=True**. <br>
2. Si necesita información del modelo recomendador en entrenamiento, y luego configure **self.recommenderModelRequired=True**. <br>
3. Reimplemente la función **posionDataAttack()**

Si tiene un método recomendador, reimplemente las siguientes funciones：<br>
  * init()
  * posionDataAttack()  
  * save()
  * predict()  
  * evaluate()  
  * test()

<h2>Descargar Conjunto de Datos</h2>




```
BAIDU DISK
Link: https://pan.baidu.com/s/1Gw0SI_GZsykPQEngiMvZgA?pwd=akgm
key: akgm

Google Drive
Link: https://drive.google.com/drive/folders/1QLDickAMEuhi8mUOyAa66dicCTd40CG5?usp=sharing
```
<h2>Requisitos</h2>


```
base==1.0.4
numba==0.53.1
numpy==1.18.0
scipy==1.4.1
torch==1.7.1
```
<h2>Referencia</h2>

Si encuentra este repositorio útil para su investigación, por favor cite nuestro artículo.


```bibtex
@article{wang2024poisoning,
  title={Ataques de Envenenamiento y Defensas en Sistemas de Recomendación: Una Encuesta},
  author={Wang, Zongwei y Yu, Junliang y Gao, Min y Yuan, Wei y Ye, Guanhua y Sadiq, Shazia y Yin, Hongzhi},
  journal={arXiv preprint arXiv:2406.01022},
  year={2024}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-14

---