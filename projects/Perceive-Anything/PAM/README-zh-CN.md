<div align="center">
<h1>
感知一切：识别、解释、描述及分割图像和视频中的任何内容（PAM）
</h1>

</div>

<div align="center">

[林伟峰](), [魏新宇](), [安瑞川](), [任天河](), [陈廷伟](), [张仁睿](), [郭子宇]() <br>
[张文涛](), [张磊](), [李宏胜]() <br>
中大，港大，理大，北京大学

</div>

<p align="center">
  <a href="https://Perceive-Anything.github.io"><b>🌐 项目网站</b></a> |
  <a href="https://arxiv.org/abs/2506.05302"><b>📕 论文</b></a> |
  <a href="https://huggingface.co/Perceive-Anything/PAM-3B"><b>📥 模型下载</b></a> |
  <a href="https://huggingface.co/datasets/Perceive-Anything/PAM-data"><b>🤗 数据集</b></a> |
  <a href="#quick-start"><b>⚡快速开始</b></a> <br>
  <a href="#license"><b>📜 许可证</b></a> |
  <a href="#citation"><b>📖 引用 (BibTeX)</b></a> <br>
</p>

<p align="center">
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/teaser_img.jpg" width="95%"> <br>
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/teaser_video.jpg" width="95%"> <br>
</p>

## 新闻

<!-- **2025.06.20**: 发布Gradio演示 ([在线演示]() 和 [本地](#gradio-demo)) -->

<!-- **2025.06.05**: 评估代码，请参阅 [此链接](). -->

**2025.06.08**：模型权重（1.5B / 3B）和训练数据集已发布。请参阅 [PAM-1.5B](https://huggingface.co/Perceive-Anything/PAM-1.5B)、[PAM-3B](https://huggingface.co/Perceive-Anything/PAM-3B) 和 [数据集](https://huggingface.co/datasets/Perceive-Anything/PAM-data)。

**2025.06.08**：PAM发布，一种简单的端到端区域级视觉语言模型，用于对象分割和理解。详见 [论文](https://arxiv.org/abs/2506.05302)


## 介绍

**感知一切模型（PAM）** 是一个概念上简单高效的框架，用于图像和视频中全面的区域级视觉理解。我们的方法在SAM 2的基础上整合了大型语言模型（LLMs），实现了对象分割与多样化区域语义输出的同步生成，包括类别、标签定义、功能解释和详细描述。我们提出高效转换SAM 2丰富的视觉特征，这些特征本质上包含通用视觉、定位和语义先验，转化为LLM可理解的多模态标记。为支持稳健的多粒度理解，我们开发了专门的数据精炼和增强流程，产出高质量的[**数据集**](https://huggingface.co/datasets/Perceive-Anything/PAM-data) ，包含图像和视频区域语义标注，包括新颖的区域级流媒体视频描述数据。


<p align="center">
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/PAM_comp.jpg" width="95%"> <br>
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/PAM_arch.jpg" width="95%"> <br>
</p>

## 安装

1. 克隆此仓库并进入基础文件夹</translate-content>

```bash
git clone https://github.com/Afeng-x/PAM.git
cd PAM
```
<translate-content>
2. 安装软件包</translate-content>
```bash
### packages for base
conda create -n PAM python=3.10 -y
conda activate PAM
pip install --upgrade pip
pip install -e ".[train]"
### packages for sam2
cd sam2
pip install -e ".[notebooks]"
```
3. 安装 Flash-Attention

```bash
pip install flash-attn --no-build-isolation
### (If the method mentioned above don’t work for you, try the following one)
git clone https://github.com/Dao-AILab/flash-attention.git
cd flash-attention
python setup.py install
```
4. 下载 SAM2.1-h-large 检查点：

```bash
cd llava/model/multimodal_encoder
bash download_ckpts.sh
```
## 快速开始

- 图片：请参考[image_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/image_infer_example.ipynb)中的示例
- 视频：请参考[video_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/video_infer_example.ipynb)中的示例
- 视频流：请参考[video_stream_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/video_stream_infer_example.ipynb)中的示例

## 数据集

请访问[此链接](https://huggingface.co/datasets/Perceive-Anything/PAM-data)下载我们精炼和增强的数据注释。

**注意：** 我们不直接提供源图像。但对于每个数据集，我们会提供相关的下载链接或官方网站地址，以指导用户如何下载。[DATA_README](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/data/README.md)

<!-- ## 训练 PAM

您可以在自定义的图像、视频或两者混合数据集上训练或微调 PAM。请查看训练[README](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/training/README.md)了解如何开始。 -->

## PAM 本地 Gradio 演示
进行中 ......

<!-- ### 简单的图片 Gradio 演示

[`pam_image.py`](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/pam_image.py) - 用于在图像上绘制掩码并获取语义的交互式 Gradio 网络界面。**该演示已在 `gradio` 5.5.0 版本测试。**

### 简单的视频 Gradio 演示

[`pam_video.py`](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/pam_video.py) - 用于在视频上绘制掩码并获取语义的交互式 Gradio 网络界面。**该演示已在 `gradio` 5.5.0 版本测试。** -->

## 许可

本代码库采用[Apache 2.0](./LICENSE)许可协议。

## 致谢
我们感谢以下项目对本工作的贡献：

- [LLaVA-Next](https://github.com/LLaVA-VL/LLaVA-NeXT)
- [SAM](https://github.com/facebookresearch/segment-anything)
- [SAM 2](https://github.com/facebookresearch/sam2)

## 引用

如果您发现 PAM 对您的研究和应用有用，或在研究中使用了我们的数据集，请使用以下 BibTeX 条目。

```bibtex
@misc{lin2025perceiveanythingrecognizeexplain,
      title={Perceive Anything: Recognize, Explain, Caption, and Segment Anything in Images and Videos}, 
      author={Weifeng Lin and Xinyu Wei and Ruichuan An and Tianhe Ren and Tingwei Chen and Renrui Zhang and Ziyu Guo and Wentao Zhang and Lei Zhang and Hongsheng Li},
      year={2025},
      eprint={2506.05302},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05302}, 
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---