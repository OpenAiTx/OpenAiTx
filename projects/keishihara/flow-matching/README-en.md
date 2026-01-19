
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

# Flow Matching in PyTorch

This repository provides a simple PyTorch implementation of the paper [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## 2D Flow Matching Example

The gif below shows the mapping of a single Gaussian distribution to a checkerboard distribution, with the vector field visualized.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

And, here is another example of moons dataset.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Getting Started

Clone the repository and set up the python environment.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Make sure you have Python 3.12+ installed.
Install `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Then, set up the environment:

```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

This is the original CFM paper implementation [1]. Some components of the code are adapted from [2] and [3].

### 2D Toy Datasets

You can train the CFM models on 2D synthetic datasets such as `checkerboard` and `moons`. Specify the dataset name using the `--dataset` option. Training parameters are predefined in the script, and visualizations of the training results are stored in the `outputs/` directory. Model checkpoints are not included as they are easily reproducible with the default settings.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

The vector fields and generated samples, like the ones displayed as GIFs at the top of this README, can now be found in the `outputs/cfm/` directory.

### Image Datasets

You can also train class-conditional CFM models on popular image classification datasets. Both the generated samples and model checkpoints will be stored in the `outputs/cfm` directory. For a detailed list of training parameters, run `uv run scripts/train_flow_matching_on_image.py --help`.

To train a class-conditional CFM on MNIST dataset, run:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

After training, you can now generate samples with:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```
Now, you should be able to see the generated samples in the `outputs/cfm/mnist/` directory.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

This is an implementation of the Reflow model (2-Rectified Flow to be specific) from the Rectified Flow paper [2].

### 2D Synthetic Data

We have implemented the Reflow on 2d synthetic datasets, same as the CFM. To train the reflow, you have to specify pretrained CFM checkpoints as reflow is a distillation model.

For example, to train on the `checkerboard` dataset with a pretrained CFM checkpoint:


```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

The training results, including vector field visualizations and generated samples, are saved under `outputs/reflow/` folder.

### Comparison of sampling process between CFM and Reflow

To compare CFM and Reflow on 2d datasets, run:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
The resulting GIFs can be found under `outputs/comparisons/` folder. Below is an example comparison of the two methods in the `checkerboard` dataset:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## References

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---