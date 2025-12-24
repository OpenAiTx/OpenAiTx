# PyTorchにおけるフローマッチング

このリポジトリは論文[Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747)の簡単なPyTorch実装を含んでいます。

## 2Dフローマッチングの例

以下のgifは、単一のガウス分布をチェッカーボード分布にマッピングし、ベクトル場を可視化したものです。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_checkerboard.gif" height="400" />
</p>

こちらはムーンデータセットの別の例です。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_moons.gif" height="400" />
</p>

## はじめに

リポジトリをクローンし、Python環境をセットアップしてください。

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Python 3.10以上がインストールされていることを確認してください。
`uv`を使用してPython環境をセットアップするには：

```bash
uv sync
source .venv/bin/activate
```

あるいは、`pip`を使用して：

```bash
python -m venv .venv
source .venv/bin/activate
pip install -e .
```

## 条件付きフローマッチング [Lipman+ 2023]

これは元のCFM論文実装[1]です。コードの一部は[2]および[3]から適応されています。

### 2D トイデータセット

`checkerboard`や`moons`などの2D合成データセットでCFMモデルを訓練できます。`--dataset`オプションでデータセット名を指定してください。訓練パラメータはスクリプト内で事前定義されており、訓練結果の可視化は`outputs/`ディレクトリに保存されます。モデルのチェックポイントは、デフォルト設定で簡単に再現可能なため含まれていません。

```bash
python train_flow_matching_2d.py --dataset checkerboard
```

ベクトル場と生成されたサンプルは、このREADMEの上部にGIFとして表示されているもののように、現在`outputs/cfm/`ディレクトリにあります。

### 画像データセット

また、人気のある画像分類データセットでクラス条件付きCFMモデルをトレーニングすることもできます。生成されたサンプルとモデルのチェックポイントは両方とも`outputs/cfm`ディレクトリに保存されます。トレーニングパラメータの詳細なリストは`python train_flow_matching_on_images.py --help`を実行してください。

MNISTデータセットでクラス条件付きCFMをトレーニングするには、以下を実行します。

```bash
python train_flow_matching_on_image.py --do_train --dataset mnist
```

トレーニング後、以下でサンプルを生成できます：

```bash
python train_flow_matching_on_image.py --do_sample --dataset mnist
```

Now, you should be able to see the generated samples in the `outputs/cfm/mnist/` directory.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

これはRectified Flow論文[2]のReflowモデル（具体的には2-Rectified Flow）の実装です。

### 2D Synthetic Data

CFMと同様に、2次元合成データセットでReflowを実装しました。Reflowは蒸留モデルであるため、トレーニングには事前学習済みCFMチェックポイントを指定する必要があります。

例えば、事前学習済みCFMチェックポイントを使って`checkerboard`データセットでトレーニングする場合：

```bash
python train_reflow_2d.py --dataset checkerboard --pretrained-model outputs/cfm/checkerboard/ckpt.pth
```

トレーニング結果は、ベクトル場の可視化や生成されたサンプルを含めて、`outputs/reflow/` フォルダに保存されます。

### CFMとReflowのサンプリングプロセスの比較

2次元データセットでCFMとReflowを比較するには、以下を実行してください：

```bash
python plot_comparison_2d.py --dataset checkerboard
```
生成されたGIFは `outputs/comparisons/` フォルダにあります。以下は `checkerboard` データセットでの2つの手法の比較例です:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## 参考文献

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---