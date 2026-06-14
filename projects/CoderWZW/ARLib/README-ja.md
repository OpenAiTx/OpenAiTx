# ARLib 
推薦システムに対するデータポイズニング攻撃を行うためのオープンソースフレームワークであり、研究者や実務者の支援を目的としています。このリポジトリは、推薦システムに対するポイズニング攻撃に関する我々の[調査論文](https://arxiv.org/abs/2406.01022)とともに公開されています。<br>

**メンバー:** <br>
Wei Yuan、オーストラリア クイーンズランド大学、warrenyuan97@gmail.com <br>
Hao Ma、中国 重慶大学、ma_hao@cqu.edu.cn <br>
Zeao Chen、中国 重慶大学、zeao_chen@stu.cqu.edu.cn<br>
Chenyu Li、中国 重慶大学、chenyu_li@stu.cqu.edu.cn

**作成者:** <br>
Zongwei Wang、中国 重慶大学、zongwei@cqu.edu.cn <br>

**支援:** <br>
Prof. Min Gao、中国 重慶大学、gaomin@cqu.edu.cn <br>
ARC Training Centre for Information Resilience (CIRES)、オーストラリア クイーンズランド大学

<h2>フレームワーク</h2>

<img src="https://github.com/CoderWZW/ARLib/blob/main/img/framework.png" alt="Alt text" width="80%" /><br><br>

<h2>使い方</h2>

1. confという名前のディレクトリにある二つの設定ファイル **attack_parser.py** と **recommend_parser.py** から、設定ファイルを編集して推薦モデルと攻撃モデルを選択および設定できます。<br>
2. main.pyを実行してください。

<h2>実装済みモデル</h2>

| **推薦モデル** | **論文** |
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

| **攻撃モデル** | **論文** | **ケース** |
| --- | --- | --- |
| NoneAttack | 該当なし | ブラック |
| RandomAttack | Lam et al. Shilling Recommender Systems for Fun and Profit. WWW'2004 | ブラック |
| BandwagonAttack | Gunes et al. Shilling Attacks against Recommender Systems: A Comprehensive Survey. Artif.Intell.Rev.'2014 | ブラック |
| AUSH | Lin C et al. Attacking recommender systems with augmented user profiles. CIKM'2020. | グレー |
| LegUP | Lin C et al. Shilling Black-Box Recommender Systems by Learning to Generate Fake User Profiles. IEEE Transactions on Neural Networks and Learning Systems'2022. | グレー |
| GOAT | Wu et al. Ready for emerging threats to recommender systems? A graph convolution-based generative shilling attack. Information Sciences'2021. | グレー |
| FedRecAttack | Rong et al. Fedrecattack: Model poisoning attack to federated recommendation. ICDE'2022. | グレー |
| A_ra | Rong et al. Poisoning Deep Learning Based Recommender Model in Federated Learning Scenarios. IJCAI'2022. | グレー |
| PGA | Li et al. Data poisoning attacks on factorization-based collaborative filtering. NIPS'2016. | ホワイト |
| DL_Attack | Huang et al. Data poisoning attacks to deep learning based recommender systems. arXiv'2021 | ホワイト |
| PipAttack | Zhang et al. Pipattack: Poisoning federated recommender systems for manipulating item promotion. WSDM'2022. | グレー |
| RAPU | Zhang et al. Data Poisoning Attack against Recommender System Using Incomplete and Perturbed Data. KDD'2021. | ホワイト |
| PoisonRec | Song et al. Poisonrec: an adaptive data poisoning framework for attacking black-box recommender systems. ICDE'2021. | ブラック |
| CLeaR | Wang et al. Poisoning Attacks Against Contrastive Recommender Systems. arXiv'2023 | ホワイト |
| GTA | Wang et al. Revisiting data poisoning attacks on deep learning based recommender systems. ISCC 2023 | ブラック |

<h2>モデルの実装</h2>

攻撃モデルを実装するか推薦モデルを実装するか決定し、対応するディレクトリにファイルを追加してください。<br>

攻撃手法がある場合は、以下を確認してください：<br>
1. 推薦モデルの情報が必要かどうかを確認し、必要であれば **self.recommenderGradientRequired=True** を設定してください。<br>
2. 推薦モデルの学習情報が必要かどうかを確認し、必要であれば **self.recommenderModelRequired=True** を設定してください。<br>
3. 関数 **posionDataAttack()** を再実装してください。

推薦手法がある場合は、以下の関数を再実装してください：<br>
  * init()
  * posionDataAttack()  
  * save()
  * predict()  
  * evaluate()  
  * test()

<h2>データセットのダウンロード</h2>




```
BAIDU DISK
Link: https://pan.baidu.com/s/1Gw0SI_GZsykPQEngiMvZgA?pwd=akgm
key: akgm

Google Drive
Link: https://drive.google.com/drive/folders/1QLDickAMEuhi8mUOyAa66dicCTd40CG5?usp=sharing
```
<h2>要件</h2>


```
base==1.0.4
numba==0.53.1
numpy==1.18.0
scipy==1.4.1
torch==1.7.1
```
<h2>参考文献</h2>

このリポジトリが研究に役立った場合は、ぜひ私たちの論文を引用してください。


```bibtex
@article{wang2024poisoning,
  title={推薦システムにおけるポイズニング攻撃と防御：調査報告},
  author={Wang, Zongwei and Yu, Junliang and Gao, Min and Yuan, Wei and Ye, Guanhua and Sadiq, Shazia and Yin, Hongzhi},
  journal={arXiv preprint arXiv:2406.01022},
  year={2024}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-14

---