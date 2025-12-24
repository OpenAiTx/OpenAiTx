# PyTorch中的流匹配

本仓库包含论文[Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747)的一个简单PyTorch实现。

## 2D流匹配示例

下面的gif演示了将单个高斯分布映射到棋盘分布，并可视化了向量场。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_checkerboard.gif" height="400" />
</p>

这是另一个月亮数据集的示例。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_moons.gif" height="400" />
</p>

## 快速开始

克隆仓库并设置Python环境。

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```
确保已安装 Python 3.10 及以上版本。  
使用 `uv` 设置 Python 环境：  


```bash
uv sync
source .venv/bin/activate
```
或者，使用 `pip`：


```bash
python -m venv .venv
source .venv/bin/activate
pip install -e .
```

## 条件流匹配 [Lipman+ 2023]

这是原始的CFM论文实现 [1]。代码的部分组件改编自 [2] 和 [3]。

### 2D 玩具数据集

您可以在二维合成数据集如 `checkerboard` 和 `moons` 上训练CFM模型。使用 `--dataset` 选项指定数据集名称。训练参数在脚本中预定义，训练结果的可视化存储在 `outputs/` 目录下。模型检查点未包含，因为使用默认设置可以轻松重现。

```bash
python train_flow_matching_2d.py --dataset checkerboard
```

矢量场和生成的样本，如本自述文件顶部以GIF形式展示的内容，现在可以在 `outputs/cfm/` 目录中找到。

### 图像数据集

您也可以在流行的图像分类数据集上训练类条件CFM模型。生成的样本和模型检查点都将存储在 `outputs/cfm` 目录中。有关训练参数的详细列表，请运行 `python train_flow_matching_on_images.py --help`。

要在MNIST数据集上训练类条件CFM，请运行：

```bash
python train_flow_matching_on_image.py --do_train --dataset mnist
```

训练完成后，您现在可以生成样本，命令如下： 

```bash
python train_flow_matching_on_image.py --do_sample --dataset mnist
```
现在，您应该能够在 `outputs/cfm/mnist/` 目录中看到生成的样本。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

这是 Rectified Flow 论文 [2] 中 Reflow 模型（具体是 2-Rectified Flow）的实现。

### 2D 合成数据

我们已经在 2D 合成数据集上实现了 Reflow，和 CFM 一样。要训练 Reflow，您必须指定预训练的 CFM 检查点，因为 Reflow 是一个蒸馏模型。

例如，要在带有预训练 CFM 检查点的 `checkerboard` 数据集上训练：


```bash
python train_reflow_2d.py --dataset checkerboard --pretrained-model outputs/cfm/checkerboard/ckpt.pth
```
训练结果，包括向量场可视化和生成样本，保存在 `outputs/reflow/` 文件夹下。

### CFM 与 Reflow 采样过程的比较

要在二维数据集上比较 CFM 和 Reflow，运行：


```bash
python plot_comparison_2d.py --dataset checkerboard
```
生成的 GIF 可以在 `outputs/comparisons/` 文件夹中找到。下面是 `checkerboard` 数据集中两种方法的对比示例：

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## 参考文献

- [1] Lipman, Yaron, 等人. "用于生成建模的流匹配." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, 等人. "流直且快：学习使用校正流生成和传输数据." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---