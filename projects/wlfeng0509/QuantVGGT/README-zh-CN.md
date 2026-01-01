# Quantized Visual Geometry Grounded Transformer

[arXiv](https://arxiv.org/abs/2509.21302) | [BibTeX](#bibtex)

------

This project is the official implementation of our QuantVGGT: "Quantized Visual Geometry Grounded Transformer".

![teaser](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/teaser.png)

![overview](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/overview.png)

------

## Results

![result](https://raw.githubusercontent.com/wlfeng0509/QuantVGGT/main/imgs/result.png)

## Updates

- [October 10, 2025] Evaluation code for reproducing our camera pose estimation results on Co3D is now available.

## Quick Start

First, clone this repository to your local machine, and install the dependencies (torch, torchvision, numpy, Pillow, and huggingface_hub).

```
git clone git@github.com:wlfeng0509/QuantVGGT.git
cd QuantVGGT
pip install -r requirements.txt
```

然后下载由 [VGGT](https://github.com/facebookresearch/vggt) 提供的预训练权重，并按照 [此处](https://github.com/facebookresearch/vggt/tree/evaluation/evaluation) 准备 Co3D 数据集。

然后从 [huggingface](https://huggingface.co/wlfeng/QuantVGGT/tree/main) 下载预训练的 W4A4 量化参数，并将下载的文件夹放置在 *evaluation\outputs\w4a4* 分支下。

现在我们可以使用提供的脚本进行推理 **（记得修改脚本中的数据路径）**。

```
cd evaluation
bash test.sh
```
同样，您可以按照[此处](https://github.com/facebookresearch/vggt/tree/evaluation#detailed-usage)的指导，使用量化模型预测其他3D属性。

## 备注

* 我们的代码库大量基于[VGGT](https://github.com/facebookresearch/vggt)和[QuaRot](https://github.com/spcl/QuaRot)。感谢开源！

## BibTeX

如果您发现*QuantVGGT*对您的工作有用且有帮助，请引用本文：


```
@article{feng2025quantized,
  title={Quantized Visual Geometry Grounded Transformer},
  author={Feng, Weilun and Qin, Haotong and Wu, Mingqiang and Yang, Chuanguang and Li, Yuqi and Li, Xiangqi and An, Zhulin and Huang, Libo and Zhang, Yulun and Magno, Michele and others},
  journal={arXiv preprint arXiv:2509.21302},
  year={2025}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---