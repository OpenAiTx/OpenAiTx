
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

# PyTorchによるフローマッチング

このリポジトリには、論文 [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747) のシンプルなPyTorch実装が含まれています。

## 2次元フローマッチング例

下のgifは、単一のガウス分布からチェッカーボード分布へのマッピングを示しており、ベクトル場が可視化されています。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

そして、こちらはmoonsデータセットの別の例です。

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## はじめに

リポジトリをクローンし、Python環境をセットアップしてください。

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Python 3.12以上がインストールされていることを確認してください。
`uv`をインストールしてください：

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

次に、環境を設定します：

```bash
uv sync
```

## 条件付きフローマッチング [Lipman+ 2023]

これは元のCFM論文実装[1]です。コードの一部は[2]および[3]から適応されています。

### 2D トイデータセット

`checkerboard`や`moons`などの2D合成データセットでCFMモデルを訓練できます。`--dataset`オプションでデータセット名を指定してください。訓練パラメータはスクリプト内で事前定義されており、訓練結果の可視化は`outputs/`ディレクトリに保存されます。モデルのチェックポイントは、デフォルト設定で簡単に再現可能なため含まれていません。

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

このREADMEの冒頭にGIFとして表示されているようなベクトル場と生成サンプルは、現在 `outputs/cfm/` ディレクトリにあります。

### 画像データセット

人気の画像分類データセットでクラス条件付きCFMモデルの学習も可能です。生成されたサンプルとモデルのチェックポイントはどちらも `outputs/cfm` ディレクトリに保存されます。学習パラメータの詳細な一覧は、`uv run scripts/train_flow_matching_on_image.py --help` を実行してください。

MNISTデータセットでクラス条件付きCFMを学習するには、次のコマンドを実行します:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

トレーニング後、以下でサンプルを生成できます：

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
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
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

トレーニング結果は、ベクトル場の可視化や生成されたサンプルを含めて、`outputs/reflow/` フォルダに保存されます。

### CFMとReflowのサンプリングプロセスの比較

2次元データセットでCFMとReflowを比較するには、以下を実行してください：

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---