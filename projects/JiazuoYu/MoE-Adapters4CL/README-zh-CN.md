# MoE-Adapters4CL
论文代码：“[**通过混合专家适配器提升视觉语言模型的持续学习能力**](https://arxiv.org/abs/2403.11549)” CVPR2024。

## 目录
  - [摘要](#Abstract)
  - [方法](#Approach)
  - [安装](#Install)
  - [数据准备](#Data-preparation)
  - [快速开始](#getting-started)
    - [模型权重](#Model-ckpt)
    - [MTCL](#MTCL)
      - [测试](#Test)
      - [训练](#Train)
    - [CIL](#CIL)
      - [训练](#Train)
  - [引用](#Citation)
  - [致谢](#Acknowledgement)

## 摘要
Continual learning can empower vision-language models to continuously acquire new knowledge, without the need for access to the entire historical dataset. However, mitigating the performance degradation in large-scale models is non-trivial due to (i) parameter shifts throughout lifelong learning and (ii) significant computational burdens associated with full-model tuning. In this work, we present a parameter-efficient continual learning framework to alleviate long-term forgetting in incremental learning with vision-language models. Our approach involves the dynamic expansion of a pre-trained CLIP model, through the integration of Mixture-of-Experts (MoE) adapters in response to new tasks. To preserve the zero-shot recognition capability of vision-language models, we further introduce a Distribution Discriminative Auto-Selector (DDAS) that automatically routes in-distribution and out-of-distribution inputs to the MoE Adapter and the original CLIP, respectively. Through extensive experiments across various settings, our proposed method consistently outperforms previous state-of-the-art approaches while concurrently reducing parameter training burdens by 60%. 
## 方法
___
![示例图片](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/fig/framework.png)


## 安装
```bash
conda create -n MoE_Adapters4CL python=3.9
conda activate MoE_Adapters4CL
conda install pytorch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 pytorch-cuda=11.8 -c pytorch -c nvidia
cd cil
pip install -r requirements.txt
```
## 数据准备  
目标数据集：Aircraft, Caltech101, CIFAR10, CIFAR100, DTD, EuroSAT, Flowers, Food, MNIST, OxfordPet, StanfordCars, SUN397, TinyImagenet。  

如果你在使用 Caltech101 时遇到问题，可以参考 [issue#6](https://github.com/JiazuoYu/MoE-Adapters4CL/issues/6)。  

更多详情可参考 [ZSCL](https://github.com/Thunderbeee/ZSCL) 的 [datasets.md](https://raw.githubusercontent.com/JiazuoYu/MoE-Adapters4CL/MoE-Adapters/mtil%2Fdatasets.md)。非常感谢他们的出色工作！  
## 模型权重  
|                  | 模型                                                                | 链接 |
|------------------|----------------------------------------------------------------------|---------------------------------------------------------------------- |
| full_shot_order1 | full_shot_order1_1000iters.pth                  | [百度网盘](https://pan.baidu.com/s/1brWYIMrv34fhdc4kC9B0_g?pwd=p3zp) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)      |
| few_shot_order1  | few_shot_order1_1000iters.pth | [百度网盘](https://pan.baidu.com/s/1Z7q3tTLdRFN3zmtkj3_i4g?pwd=4edw) / [Google Drive](https://drive.google.com/drive/folders/1f2GB2kmBYoxzWI9E33XqPnkIKrAB2fh9?usp=sharing)       |
## MTCL  
### 测试阶段  
示例：  
1. 将权重文件移动到 MoE-Adapters4CL/ckpt  
2. ```cd MoE-Adapters4CL/mtil```  
3. 运行脚本 ```bash srcipts/test/Full_Shot_order1.sh ```  

### 训练阶段  
示例：  
1. 将权重文件移动到 MoE-Adapters4CL/ckpt  
2. ```cd MoE-Adapters4CL/mtil```  
3. 运行脚本 ```bash srcipts/train/train_full_shot_router11_experts22_1000iters.sh```  

## 类增量学习  

### 训练阶段  
示例：  
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
## 致谢
我们的代码库基于 [wise-ft](https://github.com/mlfoundations/wise-ft)、[Continual-CLIP](https://github.com/vgthengane/Continual-CLIP/tree/master) 和 [ZSCL](https://github.com/Thunderbeee/ZSCL) 构建。我们感谢作者们分享他们的代码。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-04

---