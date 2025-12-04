# MoE-Adapters4CL
論文「[**Mixture-of-Expertsアダプターによる視覚言語モデルの継続学習の強化**](https://arxiv.org/abs/2403.11549)」CVPR2024のコード。

## 目次
  - [概要](#Abstract)
  - [アプローチ](#Approach)
  - [インストール](#Install)
  - [データ準備](#Data-preparation)
  - [はじめに](#getting-started)
    - [モデルチェックポイント](#Model-ckpt)
    - [MTCL](#MTCL)
      - [テスト](#Test)
      - [トレーニング](#Train)
    - [CIL](#CIL)
      - [トレーニング](#Train)
  - [引用](#Citation)
  - [謝辞](#Acknowledgement)

## 概要
Continual learning can empower vision-language models to continuously acquire new knowledge, without the need for access to the entire historical dataset. However, mitigating the performance degradation in large-scale models is non-trivial due to (i) parameter shifts throughout lifelong learning and (ii) significant computational burdens associated with full-model tuning. In this work, we present a parameter-efficient continual learning framework to alleviate long-term forgetting in incremental learning with vision-language models. Our approach involves the dynamic expansion of a pre-trained CLIP model, through the integration of Mixture-of-Experts (MoE) adapters in response to new tasks. To preserve the zero-shot recognition capability of vision-language models, we further introduce a Distribution Discriminative Auto-Selector (DDAS) that automatically routes in-distribution and out-of-distribution inputs to the MoE Adapter and the original CLIP, respectively. Through extensive experiments across various settings, our proposed method consistently outperforms previous state-of-the-art approaches while concurrently reducing parameter training burdens by 60%. 
## アプローチ
___
![例の画像](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/fig/framework.png)


## インストール
```bash
conda create -n MoE_Adapters4CL python=3.9
conda activate MoE_Adapters4CL
conda install pytorch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 pytorch-cuda=11.8 -c pytorch -c nvidia
cd cil
pip install -r requirements.txt
```
## データ準備  
対象データセット: Aircraft, Caltech101, CIFAR10, CIFAR100, DTD, EuroSAT, Flowers, Food, MNIST, OxfordPet, StanfordCars, SUN397, TinyImagenet。  

Caltech101で問題がある場合は、[issue#6](https://github.com/JiazuoYu/MoE-Adapters4CL/issues/6)を参照してください。  

詳細は[ZSCL](https://github.com/Thunderbeee/ZSCL)の[datasets.md](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/mtil%2Fdatasets.md)を参照してください。素晴らしい仕事に感謝します！  
## モデルckpt  
|                  | モデル                                                               | リンク                                                                 |  
|------------------|----------------------------------------------------------------------|---------------------------------------------------------------------- |  
| full_shot_order1 | full_shot_order1_1000iters.pth                  | [Baidu Disk](https://pan.baidu.com/s/1brWYIMrv34fhdc4kC9B0_g?pwd=p3zp) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)      |  
| few_shot_order1  | few_shot_order1_1000iters.pth | [Baidu Disk](https://pan.baidu.com/s/1Z7q3tTLdRFN3zmtkj3_i4g?pwd=4edw) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)       |  
## MTCL  
### テスト段階  
例:  
1. チェックポイントをMoE-Adapters4CL/ckptに移動  
2. ```cd MoE-Adapters4CL/mtil```  
3. スクリプトを実行 ```bash srcipts/test/Full_Shot_order1.sh ```  

### トレーニング段階  
例:  
1. チェックポイントをMoE-Adapters4CL/ckptに移動  
2. ```cd MoE-Adapters4CL/mtil```  
3. スクリプトを実行 ```bash srcipts/train/train_full_shot_router11_experts22_1000iters.sh```  

## クラス増分学習  

### トレーニング段階  
例:  
1. ```cd cil```  
2. ```bash run_cifar100-2-2.sh ```  

## 引用


```
@inproceedings{yu2024boosting,
  title={Boosting continual learning of vision-language models via mixture-of-experts adapters},
  author={Yu, Jiazuo and Zhuge, Yunzhi and Zhang, Lu and Hu, Ping and Wang, Dong and Lu, Huchuan and He, You},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  pages={23219--23230},
  year={2024}
}
```
## 謝辞
本リポジトリは [wise-ft](https://github.com/mlfoundations/wise-ft)、[Continual-CLIP](https://github.com/vgthengane/Continual-CLIP/tree/master)、および [ZSCL](https://github.com/Thunderbeee/ZSCL) を基に構築されています。著者の皆様がコードを共有してくださったことに感謝します。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---