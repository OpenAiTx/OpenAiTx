<div align="center">
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/zjx0101/ObjectClear/main/./assets/ObjectClear_logo.png" alt="ObjectClear Logo" style="height: 52px;">
    <h2>通过对象-效果注意力实现完整的对象移除</h2>
</div>

<div>
    <a href="https://zjx0101.github.io/" target='_blank'>赵吉新</a>&emsp;
    <a href='https://shangchenzhou.com/' target='_blank'>周尚辰<sup>†</sup></a>&emsp;
    <a href='https://wzhouxiff.github.io' target='_blank'>王周霞</a>&emsp;
    <a href='https://pq-yang.github.io/' target='_blank'>杨培青</a>&emsp;
    <a href='https://www.mmlab-ntu.com/person/ccloy/' target='_blank'>刘成</a>
</div>
<div>
    南洋理工大学 S-Lab<br>
   <p><sup>†</sup>通讯作者</p>
</div>


<div>
    <h4 align="center">
        <a href="https://zjx0101.github.io/projects/ObjectClear/" target='_blank'>
        <img src="https://img.shields.io/badge/🐳-项目页面-blue">
        </a>
        <a href="https://arxiv.org/abs/2505.22636" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2505.22636-b31b1b.svg">
        </a>
        <a href="https://huggingface.co/spaces/jixin0101/ObjectClear" target='_blank'>
        <img src="https://img.shields.io/badge/演示-%F0%9F%A4%97%20Hugging%20Face-blue">
        </a>
        <img src="https://api.infinitescript.com/badgen/count?name=sczhou/ObjectClear&ltext=访客&color=3977dd">
    </h4>
</div>

<strong>ObjectClear 是一个对象移除模型，能够利用对象-效果注意力联合消除目标对象及其相关效果，同时保持背景的一致性。</strong>

<div style="width: 100%; text-align: center; margin:auto;">
    <img style="width:100%" src="https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/teaser.jpg">
</div>

更多视觉结果，请访问我们的<a href="https://zjx0101.github.io/projects/ObjectClear/" target="_blank">项目页面</a>

---
</div>


## ⭐ 更新
- [2025.07] 发布推理代码和 Gradio 演示。
- [2025.05] 创建此仓库。


## 🎃 概览
![overall_structure](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/ObjectClear_pipeline.png)


## 📷 OBER 数据集
![OBER_dataset_pipeline](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/OBER_pipeline.png)

OBER（对象-效果移除）是一个混合数据集，旨在支持带效果的对象移除研究，结合了摄像机拍摄数据和模拟数据。

![OBER_dataset_samples](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/dataset_samples.png)


## ⚙️ 安装
1. 克隆仓库
    ```bash
    git clone https://github.com/zjx0101/ObjectClear.git
    cd ObjectClear
    ```
2. 创建 Conda 环境并安装依赖项

    ```bash
    # create new conda env
    conda create -n objectclear python=3.10 -y
    conda activate objectclear

    # install python dependencies
    pip3 install -r requirements.txt
    # [optional] install python dependencies for gradio demo
    pip3 install -r hugging_face/requirements.txt
    ```
## ⚡ 推理

### 快速测试
我们在[`inputs`](./inputs)文件夹中提供了一些示例。**每次运行，我们都以一张图像及其分割掩码作为输入。** <u>分割掩码可以通过交互式分割模型获得，如[SAM2演示](https://huggingface.co/spaces/fffiloni/SAM2-Image-Predictor)</u>。例如，目录结构可以安排如下：


```
inputs
   ├─ imgs
   │   ├─ test-sample1.jpg      # .jpg, .png, .jpeg supported
   │   ├─ test-sample2.jpg
   └─ masks
       ├─ test-sample1.png
       ├─ test-sample2.png
```
运行以下命令进行尝试：

```shell
## Single image inference
python inference_objectclear.py -i inputs/imgs/test-sample1.jpg -m inputs/masks/test-sample1.png --use_fp16

## Batch inference on image folder
python inference_objectclear.py -i inputs/imgs -m inputs/masks --use_fp16
```
## 🪄 交互式演示
为了免去分割掩码的准备工作，我们在 [hugging face](https://huggingface.co/spaces/jixin0101/ObjectClear) 上准备了一个 gradio 演示，也可以 [本地启动](./hugging_face)。只需拖入你的图片，点击几下分配目标掩码，即可获得物体移除结果！


```shell
cd hugging_face

# install python dependencies
pip3 install -r requirements.txt

# launch the demo
python app.py
```
## 📑 引用  
如果您发现我们的仓库对您的研究有帮助，请考虑引用我们的论文：



```bibtex
@InProceedings{zhao2025ObjectClear,
    title     = {{ObjectClear}: Complete Object Removal via Object-Effect Attention},
    author    = {Zhao, Jixin and Zhou, Shangchen and Wang, Zhouxia and Yang, Peiqing and Loy, Chen Change},
    booktitle = {arXiv preprint arXiv:2505.22636},
    year      = {2025}
    }
```
## 📧 联系方式
如果您有任何疑问，请随时通过 `jixinzhao0101@gmail.com` 与我们联系。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---