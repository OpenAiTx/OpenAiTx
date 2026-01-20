![brlp](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/readme-brlp-v2.png)

<p align="center">
  <a href='https://www.sciencedirect.com/science/article/pii/S1361841525002816'>
    <img src='https://img.shields.io/badge/Journal-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://papers.miccai.org/miccai-2024/paper/0511_paper.pdf'>
    <img src='https://img.shields.io/badge/MICCAI-PDF-green?style=for-the-badge&logo=adobeacrobatreader&logoWidth=20&logoColor=white&color=94DD15' alt='Paper PDF'>
  </a>
  <a href='https://youtu.be/6YKz2MNM4jg?si=nkG21K4lIgLrH-pK'>
    <img src='https://img.shields.io/badge/Video-YouTube-red?style=for-the-badge&logo=youtube&logoColor=white&color=FF3737' alt='Video'>
  </a>
</p>

<h4 align="center">潜在拡散と事前知識を用いた時空間的疾患進行モデルの強化</h4>

<h4 align="center"><a href="https://lemuelpuglisi.github.io/">レミュエル・プグリジ</a>, <a href="https://profiles.ucl.ac.uk/3589">ダニエル・C・アレキサンダー</a>, <a href="https://daniravi.wixsite.com/researchblog">ダニエレ・ラヴィ</a></h4>

https://github.com/user-attachments/assets/28ad3693-5e3e-4f6e-9bbc-485424fbbee2

<p align="center">
  <a href="#installation">インストール</a> •
  <a href="#training">トレーニング</a> •
  <a href="#inference">CLIアプリケーション</a> •
  <a href="#citing">引用方法</a>
</p>


**ニュース**
* 🎉 BrLPはMICCAI 2025のメディア最優秀論文賞で準優勝を獲得しました！
* 🎉 私たちの[拡張論文](https://arxiv.org/pdf/2502.08560)がMedical Image Analysis (*IF=11.8*)に掲載決定！
* 🎉 バンダービルト大学からの[新しい論文](https://www.spiedigitallibrary.org/conference-proceedings-of-spie/13406/1340621/A-technical-assessment-of-latent-diffusion-for-Alzheimers-disease-progression/10.1117/12.3047135.short)が[BLSA](https://www.blsa.nih.gov/)データセットで私たちの結果を再現しました！
* 🆕 BrLP CLIの[簡単ガイド](https://lemuelpuglisi.github.io/blog/2024/brlp/)が公開されました！
* 🎉 BrLPはMICCAI最優秀論文賞にノミネートされ、ファイナリストに選出されました！（トップ<1%）
* 🎉 BrLPは[MICCAI 2024](https://conferences.miccai.org/2024/en/)で早期採択され、**口頭発表**に選ばれました！（トップ4%）



## 目次
- [インストール](#installation)
- [データ準備](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md)
- [トレーニング](#training)
- [事前学習モデル](#pretrained-models)
- [謝辞](#acknowledgements)
- [論文の引用](#citing)

## インストール

リポジトリをダウンロードし、プロジェクトフォルダに`cd`してから`brlp`パッケージをインストールしてください：

```console
pip install -e .
```
別の環境を使用することをお勧めします（[Anaconda](https://www.anaconda.com/)を参照）。コードはpython 3.9でテストされていますが、より新しいバージョンでも動作することが期待されます。

## データ準備

[*データ準備と研究の再現性*](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/./REPR-DATA.md)に関するドキュメントをご覧ください。このファイルは、データの整理方法およびトレーニングパイプラインを実行するために必要なCSVファイルの作成方法を案内します。

## トレーニング
![](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/pipeline.png)

BrLPのトレーニングは、後続のセクションで説明する3つの主要なフェーズがあります。補助モデルを除くすべてのトレーニングは、以下のように `tensorboard` を使用して監視できます：



```console
tensorboard --logdir runs
```



### Train the autoencoder

Follow the commands below to train the autoencoder.

```console
# Create an output and a cache directory
mkdir ae_output ae_cache

# Run the training script
python scripts/training/train_autoencoder.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   ./ae_cache \
  --output_dir  ./ae_output
```

次に、MRIデータから潜在変数を抽出します：

```console
python scripts/prepare/extract_latents.py \
  --dataset_csv /path/to/A.csv \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

`XXX` を置き換えて、お好みのオートエンコーダーチェックポイントを選択してください。

### UNetのトレーニング

以下のコマンドに従って、拡散UNetをトレーニングします。`XXX` を置き換えて、お好みのオートエンコーダーチェックポイントを選択してください。


```console
# Create an output and a cache directory:
mkdir unet_output unet_cache

# Run the training script
python scripts/training/train_diffusion_unet.py \
  --dataset_csv /path/to/A.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth
```

### ControlNetをトレーニングする

以下のコマンドに従ってControlNetをトレーニングしてください。`XXX`を選択したオートエンコーダーとUNetのチェックポイントに置き換えてください。

```console
# Create an output and a cache directory:
mkdir cnet_output cnet_cache

# Run the training script
python scripts/training/train_controlnet.py \
  --dataset_csv /path/to/B.csv \
  --cache_dir   unet_cache \
  --output_dir  unet_output \
  --aekl_ckpt   ae_output/autoencoder-ep-XXX.pth \
  --diff_ckpt   unet_output/unet-ep-XXX.pth
```

### 補助モデル

以下のコマンドに従ってDCM補助モデルを訓練してください。

```console
# Create an output directory
mkdir aux_output

# Run the training script
python scripts/training/train_aux.py \
  --dataset_csv /path/to/A.csv \
  --output_path aux_output
```

私たちは、時間経過に伴う体積変化を予測できる任意の疾患進行モデルが、BrLPの補助モデルとしても有効であることを強調します。

## 推論

当パッケージには、BrLPを推論に使用するための `brlp` コマンドが付属しています。確認してください：
```console
brlp --help
```
`--input` パラメータは、被験者の利用可能なすべてのデータを一覧にしたCSVファイルを必要とします。例については、`examples/input.example.csv` を参照してください。入力スキャンのセグメンテーションを行っていない場合、`brlp` は [SynthSeg](https://surfer.nmr.mgh.harvard.edu/fswiki/SynthSeg) を使用してこの作業を実行できますが、FreeSurfer >= 7.4 のインストールが必要です。`--confs` パラメータはモデルへのパスやLAS $m$ などの他の推論パラメータを指定します。例については `examples/confs.example.yaml` を参照してください。

プログラムの実行例は以下の通りです：

![inference-preview](https://raw.githubusercontent.com/LemuelPuglisi/BrLP/main/assets/inference.gif)


## 事前学習済みモデル

BrLP用の事前学習済みモデルをダウンロードしてください：

| モデル                  | 重みのURL                                                  |
| ---------------------- | ------------------------------------------------------------ |
| オートエンコーダー            | [リンク](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EUxUFIQtkQ1EvBqojYA5BAYByIyHbttca5Mx1cU4bC6q3A?e=sCXSUA) |
| ディフュージョンモデルUNet   | [リンク](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EQT7KJTtfmRAguf8_utWeJIBUJPsRRgPZlt94s2vNbwVFw?e=IjHnx7) |
| コントロールネット             | [リンク](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EYtVvH47dFJJnH8gtwSMA-MB8c3pm4_Z9g5F_IG1OKxW9Q?e=CzvGT4) |
| 補助モデル (DCM) | [リンク](https://studentiunict-my.sharepoint.com/:u:/g/personal/pgllml99h18c351e_studium_unict_it/EXJDQqLNCwBFkt2J6zg1kpwBS_1hAZoBfGy5AfcGOBZvHQ?e=Z05kOG) |

## 謝辞

研究プロセスの加速に貢献しているオープンソースライブラリのメンテナに感謝します。特に [MONAI](https://monai.io/) とその [GenerativeModels](https://github.com/Project-MONAI/GenerativeModels/tree/main) 拡張に特別な謝辞を捧げます。

## 引用

Medical Image Analysis:


```bib
@article{puglisi2025brain,
  title={Brain latent progression: Individual-based spatiotemporal disease progression on 3D brain MRIs via latent diffusion},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  journal={Medical Image Analysis},
  year={2025}
}
```

MICCAI 2024 論文集：

```bib
@inproceedings{puglisi2024enhancing,
  title={Enhancing spatiotemporal disease progression models via latent diffusion and prior knowledge},
  author={Puglisi, Lemuel and Alexander, Daniel C and Rav{\`\i}, Daniele},
  booktitle={International Conference on Medical Image Computing and Computer-Assisted Intervention},
  pages={173--183},
  year={2024},
  organization={Springer}
}
```


SPIE メディカルイメージング 2025 論文集: 
```bib
@inproceedings{mcmaster2025technical,
  title={A technical assessment of latent diffusion for Alzheimer's disease progression},
  author={McMaster, Elyssa and Puglisi, Lemuel and Gao, Chenyu and Krishnan, Aravind R and Saunders, Adam M and Ravi, Daniele and Beason-Held, Lori L and Resnick, Susan M and Zuo, Lianrui and Moyer, Daniel and others},
  booktitle={Medical Imaging 2025: Image Processing},
  volume={13406},
  pages={505--513},
  year={2025},
  organization={SPIE}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---