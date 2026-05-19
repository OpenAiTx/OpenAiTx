# HiFuse
![](https://img.shields.io/github/license/huoxiangzuo/HiFuse)  
本仓库为[HiFuse: 医学图像分类的层次多尺度特征融合网络](https://www.sciencedirect.com/science/article/pii/S1746809423009679)的官方实现  
作者：霍向左，孙刚，田胜伟，王岩，余龙，龙军，张文东，李奥伦。  
欢迎使用代码，助力您创作更多精彩成果！

## 概述
<img width="1395" alt="figure1" src="https://user-images.githubusercontent.com/57312968/191570017-34f30c13-9d8e-4776-a118-de968aebdb19.png" width="80%">

## HFF 模块
<img width="1424" alt="figure2s" src="https://user-images.githubusercontent.com/57312968/191570496-c62e04dc-8baf-4b01-a6ba-03c24c5a744d.png" width="70%">

## HiFuse 可视化检验
<img src="https://user-images.githubusercontent.com/57312968/191570242-4425944d-4017-45c6-a3f7-f977376766a2.png" width="75%">

## 运行
0. 环境要求：
* python3
* pytorch 1.10
* torchvision 0.11.1
1. 训练：
* 准备所需图像并按类别存放，分别建立训练图像文件夹和验证图像文件夹
* 运行 `python train.py`
2. 继续训练：
* 修改 `python train.py` 中的 `parser.add_argument('--RESUME', type=bool, default=True)`
* 运行 `python train.py`
3. 测试：
* 运行 `python test.py`

## TensorBoard
运行 `tensorboard --logdir runs --port 6006` 以查看训练进度

## 参考
本仓库部分代码借鉴自：  
* [Swin Transformer](https://github.com/microsoft/Swin-Transformer)  
* [ConvNeXt](https://github.com/facebookresearch/ConvNeXt)  
* [WZMIAOMIAO](https://github.com/WZMIAOMIAO/deep-learning-for-image-processing)

## 引用

如果您觉得我们的论文/代码有帮助，请考虑引用：

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