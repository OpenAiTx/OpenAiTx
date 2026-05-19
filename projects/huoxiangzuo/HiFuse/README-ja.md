# HiFuse
![](https://img.shields.io/github/license/huoxiangzuo/HiFuse)  
このリポジトリは[HiFuse: Hierarchical Multi-Scale Feature Fusion Network for Medical Image Classification](https://www.sciencedirect.com/science/article/pii/S1746809423009679)の公式実装です。  
著者: 霍翔左, 孙刚, 田胜伟, 王岩, 于龙, 龙军, 张文东, 李傲伦。  
コードをお楽しみいただき、より素晴らしい成果を生み出す便利さを見つけてください！

## 概要
<img width="1395" alt="figure1" src="https://user-images.githubusercontent.com/57312968/191570017-34f30c13-9d8e-4776-a118-de968aebdb19.png" width="80%">

## HFF ブロック
<img width="1424" alt="figure2s" src="https://user-images.githubusercontent.com/57312968/191570496-c62e04dc-8baf-4b01-a6ba-03c24c5a744d.png" width="70%">

## HiFuseの可視化検査
<img src="https://user-images.githubusercontent.com/57312968/191570242-4425944d-4017-45c6-a3f7-f977376766a2.png" width="75%">

## 実行方法
0. 必要条件:
* python3
* pytorch 1.10
* torchvision 0.11.1
1. トレーニング:
* 必要な画像を準備し、カテゴリごとに保存、トレーニング画像フォルダと検証画像フォルダをそれぞれ設定
* `python train.py` を実行
2. トレーニングの再開:
* `python train.py` の中の `parser.add_argument('--RESUME', type=bool, default=True)` を変更
* `python train.py` を実行
3. テスト:
* `python test.py` を実行

## TensorBoard
`tensorboard --logdir runs --port 6006` を実行してトレーニングの進行状況を表示

## 参考文献
このリポジトリの一部コードは以下から借用しています:  
* [Swin Transformer](https://github.com/microsoft/Swin-Transformer)  
* [ConvNeXt](https://github.com/facebookresearch/ConvNeXt)  
* [WZMIAOMIAO](https://github.com/WZMIAOMIAO/deep-learning-for-image-processing)

## 引用文献

もし本論文やコードがお役に立てましたら、以下の文献を引用していただけると幸いです：

```bibtex
@article{huo2024hifuse,
  title={HiFuse: Hierarchical multi-scale feature fusion network for medical image classification},
  author={Huo, Xiangzuo and Sun, Gang and Tian, Shengwei and Wang, Yan and Yu, Long and Long, Jun and Zhang, Wendong and Li, Aolun},
  journal={Biomedical Signal Processing and Control},
  volume={87},
  pages={105534},
  year={2024},
  publisher={Elsevier}
}
@article{huo2025mm,
  title={MM-HiFuse: multi-modal multi-task hierarchical feature fusion for esophagus cancer staging and differentiation classification},
  author={Huo, Xiangzuo and Tian, Shengwei and Yu, Long and Zhang, Wendong and Li, Aolun and Yang, Qimeng and Song, Jinmiao},
  journal={Complex \& Intelligent Systems},
  volume={11},
  number={1},
  pages={1--12},
  year={2025},
  publisher={Springer}
}
```

## Star History

[![Star History Chart](https://api.star-history.com/image?repos=huoxiangzuo/HiFuse&type=date&legend=top-left)](https://www.star-history.com/?repos=huoxiangzuo%2FHiFuse&type=date&legend=top-left)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---