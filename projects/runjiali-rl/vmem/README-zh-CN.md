<div align="center">
<img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/title_logo.png" width="200" alt="VMem Logo"/>
<h1>VMem：基于表面元素索引视图记忆的一致交互式视频场景生成</h1>

<p align="center">ICCV 2025</p>


<a href="https://v-mem.github.io/"><img src="https://img.shields.io/badge/%F0%9F%8F%A0%20Project%20Page-gray.svg"></a>
<a href="http://arxiv.org/abs/2506.18903"><img src="https://img.shields.io/badge/%F0%9F%93%84%20arXiv-2506.18903-B31B1B.svg"></a>
<a href="https://huggingface.co/liguang0115/vmem"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Model_Card-Huggingface-orange"></a>
<a href="https://huggingface.co/spaces/liguang0115/vmem"><img src="https://img.shields.io/badge/%F0%9F%9A%80%20Gradio%20Demo-Huggingface-orange"></a>

[李润佳](https://runjiali-rl.github.io/), [Philip Torr](https://www.robots.ox.ac.uk/~phst/), [Andrea Vedaldi](https://www.robots.ox.ac.uk/~vedaldi/), [Tomas Jakab](https://www.robots.ox.ac.uk/~tomj/)
<br>
<br>
[牛津大学](https://www.robots.ox.ac.uk/~vgg/)
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/demo_teaser.gif" width="100%" alt="Teaser" style="border-radius:10px;"/>
</p>

<!-- <p align="center" border-radius="10px">
  <img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/benchmark.png" width="100%" alt="teaser_page1"/>
</p> -->

# 概述

`VMem` 是一种可插拔的图像集模型记忆机制，用于一致的场景生成。
现有方法要么依赖带有显式几何估计的图像修补，存在不准确问题；要么在基于视频的方法中使用有限的上下文窗口，导致长期一致性差。为克服这些问题，我们提出了视图表面元素记忆（VMem），将过去的视图锚定到它们观察到的表面元素（surfels）上。这使得新视图生成可以基于最相关的过去视图，而非仅仅是最近的视图，从而增强了长期场景一致性，同时降低了计算成本。


# :wrench: 安装

```bash
conda create -n vmem python=3.10
conda activate vmem
pip install -r requirements.txt
```
<translate-content>

# :rocket: 使用方法

您需要正确认证 Hugging Face 以下载我们的模型权重。设置完成后，我们的代码将在您首次运行时自动处理。您可以通过运行进行认证
</translate-content>
```bash
# This will prompt you to enter your Hugging Face credentials.
huggingface-cli login
```
一旦验证通过，访问我们的模型卡[这里](https://huggingface.co/liguang0115/vmem)并输入您的访问信息。

我们为您提供了一个与`VMem`交互的演示。只需运行


```bash
python app.py
```
<translate-content>

## :heart: 致谢
本作品基于 [CUT3R](https://github.com/CUT3R/CUT3R)、[DUSt3R](https://github.com/naver/dust3r) 和 [Stable Virtual Camera](https://github.com/stability-ai/stable-virtual-camera) 开发。感谢他们的卓越贡献。





# :books: 引用

如果您觉得本仓库有用，请考虑点个星 :star: 并引用。
</translate-content>
```
@article{li2025vmem,
  title={VMem: Consistent Interactive Video Scene Generation with Surfel-Indexed View Memory},
  author={Li, Runjia and Torr, Philip and Vedaldi, Andrea and Jakab, Tomas},
  journal={arXiv preprint arXiv:2506.18903},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---