# ARLib 
一个用于对推荐系统进行数据投毒攻击的开源框架，旨在协助研究人员和从业者。该仓库随我们关于推荐系统投毒攻击的[调研论文](https://arxiv.org/abs/2406.01022)一起发布。<br>

**成员：** <br>
魏远，澳大利亚昆士兰大学，warrenyuan97@gmail.com <br>
马昊，中国重庆大学，ma_hao@cqu.edu.cn <br>
陈泽奥，中国重庆大学，zeao_chen@stu.cqu.edu.cn<br>
李辰宇，中国重庆大学, chenyu_li@stu.cqu.edu.cn

**创建者：** <br>
王宗伟，中国重庆大学，zongwei@cqu.edu.cn <br>

**支持单位：** <br>
高敏教授，中国重庆大学，gaomin@cqu.edu.cn <br>
澳大利亚昆士兰大学ARC信息韧性培训中心(CIRES)

<h2>框架</h2>

<img src="https://github.com/CoderWZW/ARLib/blob/main/img/framework.png" alt="Alt text" width="80%" /><br><br>

<h2>使用方法</h2>

1. 目录conf下有两个配置文件**attack_parser.py**和**recommend_parser.py**，您可以通过修改配置文件选择和配置推荐模型与攻击模型。<br>
2. 运行main.py。

<h2>已实现模型</h2>

| **推荐模型** | **论文** |
| --- | --- |
| GMF | Yehuda等人，《Matrix Factorization Techniques for Recommender Systems》，IEEE Computer'09。|
| WRMF | Hu等人，《Collaborative Filtering for Implicit Feedback Datasets》，KDD'09。 |
| NCF | He等人，《Neural Collaborative Filtering》，WWW'17。 |
| NGCF | Wang等人，《Neural Graph Collaborative Filtering》，SIGIR'19。 |
| LightGCN | He等人，《LightGCN: Simplifying and powering graph convolution network for recommendation》，SIGIR'2020。 |
| SSL4Rec | Yao等人，《Self-supervised learning for large-scale item recommendations》，CIKM'2021。 |
| NCL | Lin等人，《Improving graph collaborative filtering with neighborhood-enriched contrastive learning》，WWW'2022。 |
| SGL | Wu等人，《Self-supervised Graph Learning for Recommendation》，SIGIR'21。 |
| SimGCL | Yu等人，《Are Graph Augmentations Necessary? Simple Graph Contrastive Learning for Recommendation》，SIGIR'22。 |
| XSimGCL | Yu等人，《XSimGCL: Towards extremely simple graph contrastive learning for recommendation》，TKDE'23。 |

| **攻击模型** | **论文** | **案例** |
| --- | --- | --- |
| NoneAttack | 不适用 | 黑盒 |
| RandomAttack | Lam 等人. 《为了娱乐和利润的推荐系统刷榜攻击》. WWW'2004 | 黑盒 |
| BandwagonAttack | Gunes 等人. 《针对推荐系统的刷榜攻击：综合调查》. 人工智能综述'2014 | 黑盒 |
| AUSH | Lin C 等人. 《利用增强用户画像攻击推荐系统》. CIKM'2020. | 灰盒 |
| LegUP | Lin C 等人. 《通过学习生成假用户画像对黑盒推荐系统进行刷榜攻击》. IEEE 神经网络与学习系统汇刊'2022. | 灰盒 |
| GOAT | Wu 等人. 《准备应对推荐系统的新兴威胁？基于图卷积的生成式刷榜攻击》. 信息科学'2021. | 灰盒 |
| FedRecAttack | Rong 等人. 《Fedrecattack：联邦推荐的模型投毒攻击》. ICDE'2022. | 灰盒 |
| A_ra | Rong 等人. 《联邦学习场景下基于深度学习推荐模型的投毒攻击》. IJCAI'2022. | 灰盒 |
| PGA | Li 等人. 《基于分解的协同过滤数据投毒攻击》. NIPS'2016. | 白盒 |
| DL_Attack| Huang 等人. 《基于深度学习推荐系统的数据投毒攻击》. arXiv'2021 | 白盒 |
| PipAttack | Zhang 等人. 《Pipattack：操控商品推广的联邦推荐系统投毒攻击》. WSDM'2022. | 灰盒 |
| RAPU | Zhang 等人. 《利用不完整和扰动数据的推荐系统数据投毒攻击》. KDD'2021. | 白盒 |
| PoisonRec | Song 等人. 《Poisonrec：针对黑盒推荐系统的自适应数据投毒框架》. ICDE'2021. | 黑盒 |
| CLeaR | Wang 等人. 《对比推荐系统的投毒攻击》. arXiv'2023 | 白盒 |
| GTA | Wang 等人. 《重新审视基于深度学习推荐系统的数据投毒攻击》. ISCC 2023 | 黑盒 |

<h2>实现您的模型</h2>


确定您是想实现攻击模型还是推荐模型，然后将文件添加到相应的目录下。<br>

如果您有攻击方法，请确保：<br>
1. 是否需要推荐模型的信息，然后设置 **self.recommenderGradientRequired=True**。<br>
2. 是否需要训练推荐模型的信息，然后设置 **self.recommenderModelRequired=True**。<br>
3. 重新实现函数 **posionDataAttack()**。

如果您有推荐方法，请重新实现以下函数：<br>
  * init()
  * posionDataAttack()  
  * save()
  * predict()  
  * evaluate()  
  * test()


<h2>下载数据集</h2>


```
BAIDU DISK
Link: https://pan.baidu.com/s/1Gw0SI_GZsykPQEngiMvZgA?pwd=akgm
key: akgm

Google Drive
Link: https://drive.google.com/drive/folders/1QLDickAMEuhi8mUOyAa66dicCTd40CG5?usp=sharing
```
<h2>需求</h2>


```
base==1.0.4
numba==0.53.1
numpy==1.18.0
scipy==1.4.1
torch==1.7.1
```

<h2>参考文献</h2>

如果您发现本仓库对您的研究有帮助，请引用我们的论文。

```bibtex
@article{wang2024poisoning,
  title={推荐系统中的投毒攻击与防御：综述},
  author={王宗伟 and 余俊良 and 高敏 and 袁伟 and 叶冠华 and 萨迪克·沙齐娅 and 殷宏志},
  journal={arXiv 预印本 arXiv:2406.01022},
  year={2024}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-14

---