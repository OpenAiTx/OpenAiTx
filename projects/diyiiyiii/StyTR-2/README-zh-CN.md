# StyTr^2 ：基于Transformer的图像风格迁移（CVPR2022）
*作者: [邓莹莹](https://diyiiyiii.github.io/), 唐帆, 潘星佳, 董伟明, 马崇阳, 徐长生*

本文提出了一种基于Transformer模型的无偏图像风格迁移方法。与现有最先进的方法相比，我们的方法能提升风格化效果。
本仓库为[SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576)的官方实现。

## 结果展示 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
与一些最先进的算法相比，我们的方法具有很强的内容泄漏防止能力，并且拥有更好的特征表达能力。<br>

## 框架
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
这是我们StyTr^2框架的整体流程。我们将内容图像和风格图像切分为patches，并通过线性投影获得图像序列。然后，将添加了CAPE的内容序列送入内容Transformer编码器，同时风格序列送入风格Transformer编码器。在两个Transformer编码器之后，采用多层Transformer解码器根据风格序列对内容序列进行风格化。最后，我们使用渐进式上采样解码器生成高分辨率的风格化图像。

## 实验
### 环境要求
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### 测试 
预训练模型: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
请下载上述模型并放入 ./experiments/ 文件夹下  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### 训练  
风格数据集为从[WIKIART](https://www.wikiart.org/)收集的WikiArt <br>  
内容数据集为COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### 参考文献
如果您在研究中觉得我们的工作有用，请使用以下BibTeX条目引用我们的论文~感谢 ^ . ^。论文链接 [pdf](https://arxiv.org/abs/2105.14576)<br> 
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---