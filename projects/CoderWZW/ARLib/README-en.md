# ARLib 
An open-source framework for conducting data poisoning attacks on recommendation systems, designed to assist researchers and practitioners. This repo is released with our [survey paper](https://arxiv.org/abs/2406.01022) on poisoning attack against recommender system. <br>

**Members:** <br>
Wei Yuan, Queensland University, Australia, warrenyuan97@gmail.com <br>
Hao Ma, Chongqing University, China, ma_hao@cqu.edu.cn <br>
Zeao Chen, Chongqing University, China, zeao_chen@stu.cqu.edu.cn<br>
Chenyu Li, Chongqing University, China, chenyu_li@stu.cqu.edu.cn

**Creator:** <br>
Zongwei Wang, Chongqing University, China, zongwei@cqu.edu.cn <br>

**Supported by:** <br>
Prof. Min Gao, Chongqing University, China, gaomin@cqu.edu.cn <br>
ARC Training Centre for Information Resilience (CIRES), University of Queensland, Australia

<h2>Framework</h2>

<img src="https://github.com/CoderWZW/ARLib/blob/main/img/framework.png" alt="Alt text" width="80%" /><br><br>

<h2>Usage</h2>

1. Two configure files **attack_parser.py** and **recommend_parser.py** are in the directory named conf, and you can select and configure the recommendation model and attack model by modifying the configuration files. <br>
2. Run main.py.


<h2>Implemented Models</h2>

| **Recommend Model** | **Paper** |
| --- | --- |
| GMF | Yehuda et al. Matrix Factorization Techniques for Recommender Systems, IEEE Computer'09.|
| WRMF | Hu et al.Collaborative Filtering for Implicit Feedback Datasets, KDD'09. |
| NCF | He et al. Neural Collaborative Filtering, WWW'17. |
| NGCF | Wang et al. Neural Graph Collaborative Filtering, SIGIR'19. |
| LightGCN | He et al. Lightgcn: Simplifying and powering graph convolution network for recommendation, SIGIR'2020. |
| SSL4Rec | Yao et al. Self-supervised learning for large-scale item recommendations. CIKM'2021. |
| NCL | Lin et al. Improving graph collaborative filtering with neighborhood-enriched contrastive learning. WWW'2022. |
| SGL | Wu et al. Self-supervised Graph Learning for Recommendation, SIGIR'21. |
| SimGCL | Yu et al. Are Graph Augmentations Necessary? Simple Graph Contrastive Learning for Recommendation, SIGIR'22. |
| XSimGCL | Yu et al. XSimGCL: Towards extremely simple graph contrastive learning for recommendation, TKDE'23. |
| **Attack Model** | **Paper** | **Case** |
| --- | --- | --- |
| NoneAttack | N/A | Black |
| RandomAttack | Lam et al. Shilling Recommender Systems for Fun and Profit. WWW'2004| Black |
| BandwagonAttack | Gunes et al. Shilling Attacks against Recommender Systems: A Comprehensive Survey. Artif.Intell.Rev.'2014 | Black |
| AUSH | Lin C et al. Attacking recommender systems with augmented user profiles. CIKM'2020. | Gray |
| LegUP | Lin C et al. Shilling Black-Box Recommender Systems by Learning to Generate Fake User Profiles. IEEE Transactions on Neural Networks and Learning Systems'2022. | Gray |
| GOAT | Wu et al. Ready for emerging threats to recommender systems? A graph convolution-based generative shilling attack. Information Sciences'2021. | Gray |
| FedRecAttack | Rong  et al. Fedrecattack: Model poisoning attack to federated recommendation. ICDE'2022. | Gray |
| A_ra | Rong et al. Poisoning Deep Learning Based Recommender Model in Federated Learning Scenarios. IJCAI'2022. | Gray |
| PGA | Li et al. Data poisoning attacks on factorization-based collaborative filtering. NIPS'2016. | White |
| DL_Attack| Huang et al. Data poisoning attacks to deep learning based recommender systems. arXiv'2021| White|
| PipAttack | Zhang et al. Pipattack: Poisoning federated recommender systems for manipulating item promotion. WSDM'2022. | Gray |
| RAPU | Zhang et al. Data Poisoning Attack against Recommender System Using Incomplete and Perturbed Data. KDD'2021. | White |
| PoisonRec | Song et al. Poisonrec: an adaptive data poisoning framework for attacking black-box recommender systems. ICDE'2021. | Black |
| CLeaR | Wang et al. Poisoning Attacks Against Contrastive Recommender Systems. arXiv'2023 | White |
| GTA | Wang et al.  Revisiting data poisoning attacks on deep learning based recommender systems. ISCC 2023 | Black |

<h2>Implement Your Model</h2>


Determine whether you want to implement the attack model or the recommendation model, and then add the file under the corresponding directory. <br>

If you have an attack method, make sure：<br>
1. Whether you need information of the recommender model, and then set **self.recommenderGradientRequired=True**. <br>
2. Whether you need information of training recommender model, and then set **self.recommenderModelRequired=True**. <br>
3. Reimplement function **posionDataAttack()**

If you have a recommender method, reimplement the following functions：<br>
  * init()
  * posionDataAttack()  
  * save()
  * predict()  
  * evaluate()  
  * test()


<h2>Downlod Dataset</h2>


```
BAIDU DISK
Link: https://pan.baidu.com/s/1Gw0SI_GZsykPQEngiMvZgA?pwd=akgm
key: akgm

Google Drive
Link: https://drive.google.com/drive/folders/1QLDickAMEuhi8mUOyAa66dicCTd40CG5?usp=sharing
```
<h2>Requirements</h2>


```
base==1.0.4
numba==0.53.1
numpy==1.18.0
scipy==1.4.1
torch==1.7.1
```

<h2>Reference</h2>

If you find this repo helpful to your research, please cite our paper.

```bibtex
@article{wang2024poisoning,
  title={Poisoning Attacks and Defenses in Recommender Systems: A Survey},
  author={Wang, Zongwei and Yu, Junliang and Gao, Min and Yuan, Wei and Ye, Guanhua and Sadiq, Shazia and Yin, Hongzhi},
  journal={arXiv preprint arXiv:2406.01022},
  year={2024}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-14

---