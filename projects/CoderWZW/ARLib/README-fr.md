# ARLib 
Un cadre open-source pour mener des attaques par empoisonnement de données sur les systèmes de recommandation, conçu pour aider les chercheurs et les praticiens. Ce dépôt est publié avec notre [article de synthèse](https://arxiv.org/abs/2406.01022) sur les attaques par empoisonnement contre les systèmes de recommandation. <br>

**Membres :** <br>
Wei Yuan, Université du Queensland, Australie, warrenyuan97@gmail.com <br>
Hao Ma, Université de Chongqing, Chine, ma_hao@cqu.edu.cn <br>
Zeao Chen, Université de Chongqing, Chine, zeao_chen@stu.cqu.edu.cn<br>
Chenyu Li, Université de Chongqing, Chine, chenyu_li@stu.cqu.edu.cn

**Créateur :** <br>
Zongwei Wang, Université de Chongqing, Chine, zongwei@cqu.edu.cn <br>

**Soutenu par :** <br>
Prof. Min Gao, Université de Chongqing, Chine, gaomin@cqu.edu.cn <br>
Centre de formation ARC pour la résilience de l'information (CIRES), Université du Queensland, Australie

<h2>Cadre</h2>

<img src="https://github.com/CoderWZW/ARLib/blob/main/img/framework.png" alt="Texte alternatif" width="80%" /><br><br>

<h2>Utilisation</h2>

1. Deux fichiers de configuration **attack_parser.py** et **recommend_parser.py** se trouvent dans le répertoire nommé conf, et vous pouvez sélectionner et configurer le modèle de recommandation et le modèle d'attaque en modifiant les fichiers de configuration. <br>
2. Exécutez main.py.


<h2>Modèles Implémentés</h2>

| **Modèle de recommandation** | **Article** |
| --- | --- |
| GMF | Yehuda et al. Matrix Factorization Techniques for Recommender Systems, IEEE Computer'09.|
| WRMF | Hu et al. Collaborative Filtering for Implicit Feedback Datasets, KDD'09. |
| NCF | He et al. Neural Collaborative Filtering, WWW'17. |
| NGCF | Wang et al. Neural Graph Collaborative Filtering, SIGIR'19. |
| LightGCN | He et al. Lightgcn: Simplifying and powering graph convolution network for recommendation, SIGIR'2020. |
| SSL4Rec | Yao et al. Self-supervised learning for large-scale item recommendations. CIKM'2021. |
| NCL | Lin et al. Improving graph collaborative filtering with neighborhood-enriched contrastive learning. WWW'2022. |
| SGL | Wu et al. Self-supervised Graph Learning for Recommendation, SIGIR'21. |
| SimGCL | Yu et al. Are Graph Augmentations Necessary? Simple Graph Contrastive Learning for Recommendation, SIGIR'22. |
| XSimGCL | Yu et al. XSimGCL: Towards extremely simple graph contrastive learning for recommendation, TKDE'23. |
| **Modèle d'attaque** | **Article** | **Cas** |
| --- | --- | --- |
| NoneAttack | N/A | Noir |
| RandomAttack | Lam et al. Shilling Recommender Systems for Fun and Profit. WWW'2004| Noir |
| BandwagonAttack | Gunes et al. Shilling Attacks against Recommender Systems: A Comprehensive Survey. Artif.Intell.Rev.'2014 | Noir |
| AUSH | Lin C et al. Attacking recommender systems with augmented user profiles. CIKM'2020. | Gris |
| LegUP | Lin C et al. Shilling Black-Box Recommender Systems by Learning to Generate Fake User Profiles. IEEE Transactions on Neural Networks and Learning Systems'2022. | Gris |
| GOAT | Wu et al. Ready for emerging threats to recommender systems? A graph convolution-based generative shilling attack. Information Sciences'2021. | Gris |
| FedRecAttack | Rong  et al. Fedrecattack: Model poisoning attack to federated recommendation. ICDE'2022. | Gris |
| A_ra | Rong et al. Poisoning Deep Learning Based Recommender Model in Federated Learning Scenarios. IJCAI'2022. | Gris |
| PGA | Li et al. Data poisoning attacks on factorization-based collaborative filtering. NIPS'2016. | Blanc |
| DL_Attack| Huang et al. Data poisoning attacks to deep learning based recommender systems. arXiv'2021| Blanc|
| PipAttack | Zhang et al. Pipattack: Poisoning federated recommender systems for manipulating item promotion. WSDM'2022. | Gris |
| RAPU | Zhang et al. Data Poisoning Attack against Recommender System Using Incomplete and Perturbed Data. KDD'2021. | Blanc |
| PoisonRec | Song et al. Poisonrec: an adaptive data poisoning framework for attacking black-box recommender systems. ICDE'2021. | Noir |
| CLeaR | Wang et al. Poisoning Attacks Against Contrastive Recommender Systems. arXiv'2023 | Blanc |
| GTA | Wang et al.  Revisiting data poisoning attacks on deep learning based recommender systems. ISCC 2023 | Noir |

<h2>Implémentez Votre Modèle</h2>


Déterminez si vous souhaitez implémenter le modèle d'attaque ou le modèle de recommandation, puis ajoutez le fichier sous le répertoire correspondant. <br>

Si vous avez une méthode d'attaque, assurez-vous：<br>
1. Si vous avez besoin d'informations sur le modèle de recommandation, puis définissez **self.recommenderGradientRequired=True**. <br>
2. Si vous avez besoin d'informations sur le modèle de recommandation en entraînement, puis définissez **self.recommenderModelRequired=True**. <br>
3. Réimplémentez la fonction **posionDataAttack()**

Si vous avez une méthode de recommandation, réimplémentez les fonctions suivantes：<br>
  * init()
  * posionDataAttack()  
  * save()
  * predict()  
  * evaluate()  
  * test()


<h2>Télécharger le Jeu de Données</h2>


```
BAIDU DISK
Link: https://pan.baidu.com/s/1Gw0SI_GZsykPQEngiMvZgA?pwd=akgm
key: akgm

Google Drive
Link: https://drive.google.com/drive/folders/1QLDickAMEuhi8mUOyAa66dicCTd40CG5?usp=sharing
```
<h2>Exigences</h2>


```
base==1.0.4
numba==0.53.1
numpy==1.18.0
scipy==1.4.1
torch==1.7.1
```

<h2>Référence</h2>

Si ce dépôt vous est utile pour vos recherches, veuillez citer notre article.

```bibtex
@article{wang2024poisoning,
  title={Attaques par empoisonnement et défenses dans les systèmes de recommandation : une revue},
  author={Wang, Zongwei et Yu, Junliang et Gao, Min et Yuan, Wei et Ye, Guanhua et Sadiq, Shazia et Yin, Hongzhi},
  journal={prépublication arXiv arXiv:2406.01022},
  year={2024}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-14

---