<div align="center">

# AerialMegaDepth: 空中-地上再構築とビュー合成の学習

[Khiem Vuong](https://www.khiemvuong.com/), [Anurag Ghosh](https://anuragxel.github.io/), [Deva Ramanan*](https://www.cs.cmu.edu/~deva), [Srinivasa Narasimhan*](https://www.cs.cmu.edu/~srinivas), [Shubham Tulsiani*](https://shubhtuls.github.io/)

**CVPR 2025**

[[`arXiv`](https://arxiv.org/abs/2504.13157)]
[[`プロジェクトページ`](https://aerial-megadepth.github.io/)]
[[`3Dウェブビューア`](https://aerial-megadepth.github.io/web-viewer/)]
[[`Bibtex`](#citation)]

</div>

## 📢 ニュース
- (2025年9月5日): フルデータセットをHuggingFaceに移動し、ダウンロードを容易にしました。完全な手順は[data_generation](data_generation)を参照してください。

## 目次

- [インストール](#installation)
- [クイックスタート](#quick-start)
- [評価](#evaluation)
- [データ生成](#data-generation)
- [謝辞](#acknowledgement)
- [引用](#citation)
- [問題](#issues)


## 📋 はじめに...
興味に応じて：

- 🚀 **事前学習済みチェックポイントをダウンロードしてデモを実行したい場合**：以下を読み進めてください。

- 🛠️ **データセットにアクセスまたは生成したい場合**：完全な手順については[data_generation](data_generation)を参照してください。

## インストール

以下はセットアップ手順です（主に[MASt3Rリポジトリ](https://github.com/naver/mast3r)に従っています）。DUSt3Rを包含しているためMASt3Rのセットアップに従いますが、両方ともほぼ同様に動作します。

1. リポジトリをクローンします:

```bash
git clone --recursive https://github.com/kvuong2711/aerial-megadepth.git
cd aerial-megadepth/mast3r

# If you already cloned the repository, you can update the submodules:
# git submodule update --init --recursive
```
2. 環境を作成し、依存関係をインストールする:
```bash
conda create -n aerialmd python=3.11 cmake=3.14.0
conda activate aerialmd 
conda install pytorch torchvision pytorch-cuda=12.1 -c pytorch -c nvidia  # use the correct version of cuda for your system
pip install -r requirements.txt
pip install -r dust3r/requirements.txt
pip install -r dust3r/requirements_optional.txt
```
3. 任意、RoPE用のcudaカーネルをコンパイルする（CroCo v2と同様）：
```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../
```

## クイックスタート
私たちのファインチューニング済みチェックポイントは、元のDUSt3R/MASt3R/MASt3R-SfMコードベースと完全に互換性があります。既にセットアップしている場合は、航空地上シナリオ用にチェックポイントを入れ替えるだけで使用できます！

### チェックポイント

AerialMegaDepthデータセットでファインチューニングされたDUSt3RおよびMASt3Rチェックポイントのダウンロード方法は2つあります：

1. huggingface_hub統合を使用できます：モデル（[aerial-dust3r](https://huggingface.co/kvuong2711/checkpoint-aerial-dust3r) または [aerial-mast3r](https://huggingface.co/kvuong2711/checkpoint-aerial-mast3r)）は自動的にダウンロードされます。

2. または、チェックポイントを手動でダウンロードします（[gdown](https://github.com/wkentaro/gdown)を使用、`pip install gdown`でインストール）：

```bash
# you are inside aerial-megadepth/mast3r
mkdir -p checkpoints/
gdown --fuzzy "https://drive.google.com/open?id=1wSGpYwWeGn99J8dVWNkfefwmWMAH7LFT" -O checkpoints/  # checkpoint-aerial-dust3r.pth
gdown --fuzzy "https://drive.google.com/open?id=1LrRNUQRQZcVzcioyYHYYx9ImypSZpUq2" -O checkpoints/  # checkpoint-aerial-mast3r.pth
```

### 推論／デモ
[assets](assets)フォルダには、[ULTRRA challenge](https://sites.google.com/view/ultrra-wacv-2025)や[Accenture-NVS1](https://arxiv.org/pdf/2503.18711)の画像を含む、簡単にテストできるいくつかのサンプル画像を提供しています。

各スクリプト（例：[demo_dust3r_nongradio.py](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mast3r/demo_dust3r_nongradio.py)）には、典型的な使用例を示すための事前定義された画像パスが含まれています。スクリプト内の`image_list`変数を変更して、異なるペアを試すことができます。推論は以下のコマンドで実行可能です。

- DUSt3Rデモコード：
```bash
python demo_dust3r_nongradio.py --weights kvuong2711/checkpoint-aerial-dust3r

# or, if you downloaded the checkpoints manually:
# python demo_dust3r_nongradio.py --weights checkpoints/checkpoint-aerial-dust3r.pth
```

- MASt3R デモコード:
```bash
python demo_mast3r_nongradio.py --weights kvuong2711/checkpoint-aerial-mast3r

# or, if you downloaded the checkpoints manually:
# python demo_mast3r_nongradio.py --weights checkpoints/checkpoint-aerial-mast3r.pth
```
![matching example](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/assets/figures/matches_figure.png)

## 評価

- [ ] **TODO:** 評価用データはまもなく公開されます。

データをダウンロードしたら、評価スクリプトを実行してください：
```bash
python eval.py \
    --weights checkpoints/checkpoint-aerial-dust3r.pth \
    --eval_data_dir data/eval_data_release
```
このスクリプト（[PoseDiffusion](https://github.com/facebookresearch/PoseDiffusion)から適応）は、さまざまな角度閾値でRRAおよびRTAを報告します。

## データ生成
データのダウンロードおよび/または生成方法については、[data_generation](data_generation)を参照してください。

## 謝辞
このコードベースは、[MegaDepth](https://www.cs.cornell.edu/projects/megadepth)、[DUSt3R](https://github.com/naver/dust3r)、[hloc](https://github.com/cvg/Hierarchical-Localization)、[COLMAP](https://github.com/colmap/colmap)など、多くの優れたオープンソースプロジェクトに基づいています。各作者の皆様にその成果を公開していただいたことに感謝します。

## 引用
本研究があなたの研究に役立つ場合は、ぜひ私たちの論文を引用してください：

```bibtex
@inproceedings{vuong2025aerialmegadepth,
  title={AerialMegaDepth: Learning Aerial-Ground Reconstruction and View Synthesis},
  author={Vuong, Khiem and Ghosh, Anurag and Ramanan, Deva and Narasimhan, Srinivasa and Tulsiani, Shubham},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  year={2025},
}
```

## 問題点
問題や質問、提案がある場合は、自由にイシューを作成するか、[メール](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mailto:kvuong@andrew.cmu.edu)で直接私に連絡してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---