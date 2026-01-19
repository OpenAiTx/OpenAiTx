
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PyTorch中的流匹配

本仓库包含了论文 [用于生成建模的流匹配](https://arxiv.org/abs/2210.02747) 的一个简单PyTorch实现。

## 2D流匹配示例

下方的动图演示了将单一高斯分布映射到棋盘格分布的过程，并可视化了矢量场。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

下面是月牙形（moons）数据集的另一个示例。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## 快速开始

克隆该仓库并配置 Python 环境。

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

确保已安装 Python 3.12 及以上版本。
安装 `uv`：

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

然后，设置环境：

```bash
uv sync
```

## 条件流匹配 [Lipman+ 2023]

这是原始的CFM论文实现 [1]。代码的部分组件改编自 [2] 和 [3]。

### 2D 玩具数据集

您可以在二维合成数据集如 `checkerboard` 和 `moons` 上训练CFM模型。使用 `--dataset` 选项指定数据集名称。训练参数在脚本中预定义，训练结果的可视化存储在 `outputs/` 目录下。模型检查点未包含，因为使用默认设置可以轻松重现。

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

现在，像本 README 顶部显示为 GIF 的那些向量场和生成样本，可以在 `outputs/cfm/` 目录下找到。

### 图像数据集

您还可以在流行的图像分类数据集上训练类别条件的 CFM 模型。生成的样本和模型检查点都将存储在 `outputs/cfm` 目录中。要获取详细的训练参数列表，请运行 `uv run scripts/train_flow_matching_on_image.py --help`。

要在 MNIST 数据集上训练类别条件的 CFM，请运行：

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

训练完成后，您现在可以生成样本，命令如下： 

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
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
uv run scripts/train_reflow_2d.py --dataset checkerboard
```
训练结果，包括向量场可视化和生成样本，保存在 `outputs/reflow/` 文件夹下。

### CFM 与 Reflow 采样过程的比较

要在二维数据集上比较 CFM 和 Reflow，运行：


```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---