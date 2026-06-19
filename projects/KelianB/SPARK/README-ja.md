<p align="center">
    <h1 align="center">SPARK: 自己教師ありパーソナライズドリアルタイム単眼顔キャプチャ</h1>
    <p align="center">
        <a href="mailto://kelian.baert@gmail.com"><strong>ケリアン・バート</strong></a>
        ·
        <a href="https://sbharadwajj.github.io/"><strong>シュリシャ・バラドワジ</strong></a>
        ·
        <a href="https://www.linkedin.com/in/fabien-castan/"><strong>ファビアン・カスタン</strong></a>
        ·
        <a href="https://www.linkedin.com/in/benoitmaujean/"><strong>ブノワ・モージャン</strong></a>
        ·
        <a href="https://people.irisa.fr/Marc.Christie/"><strong>マルク・クリスティ</strong></a>
        ·
        <a href="https://vabrevaya.github.io/"><strong>ビクトリア・フェルナンデス・アブレバヤ</strong></a>
        ·
        <a href="https://boukhayma.github.io/"><strong>アドナン・ブカイマ</strong></a>
    </p>
    <p align="center">
        <a href="https://technicolor.com">テクニカラー</a> | <a href="https://is.mpg.de/">マックスプランク研究所</a> | <a href="https://www.inria.fr/en/inria-centre-rennes-university">INRIAレンヌ</a>
        <br>
        <strong>SIGGRAPH Asia 2024 会議論文</strong>
    </p>
    <p align="center">
        <a href="https://kelianb.github.io/SPARK/" style="padding-left: 0.5rem;">
            <img src="https://img.shields.io/badge/Project-Page-blue?style=flat&logo=Google%20chrome&logoColor=blue" alt="Project Page">
        </a>
        <a href="https://dl.acm.org/doi/10.1145/3680528">
            <img src="https://img.shields.io/badge/Paper-red" alt="PDF">
        </a>
        <a href="https://arxiv.org/abs/2409.07984">
            <img src="https://img.shields.io/badge/Arxiv-red" alt="arxiv PDF">
        </a>
    </p>
    <p align="center">
        <img src="https://raw.githubusercontent.com/KelianB/SPARK/main/assets/teaser.webp" width="98%" />
    </p>
</p>

## 引用

もし私たちのコードや論文がお役に立てましたら、以下のように引用してください：

```bibtex
@inproceedings{baert2024spark,
  title = {{SPARK}: Self-supervised Personalized Real-time Monocular Face Capture},
  author = {Baert, Kelian and Bharadwaj, Shrisha and Castan, Fabien and Maujean, Benoit and Christie, Marc and Abrevaya, Victoria and Boukhayma, Adnane},
  year = {2024},
  month = dec,
  booktitle = {SIGGRAPH Asia 2024 Conference Proceedings},
  articleno = {113},
  doi = {10.1145/3680528.3687704},
  isbn = {979-8-4007-1131-2/24/12},
  publisher = {Association for Computing Machinery},
  address = {New York, NY, USA},
  numpages = {12},
  url = {https://kelianb.github.io/SPARK/},
}
```

## インストール

<details>
    <summary>詳細</summary>

- [setup.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./setup.sh) を使って環境を作成します。
- [TrackerAdaptation/setup_submodules.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./TrackerAdaptation/setup_submodules.sh) を実行します。数分かかる場合があります。
- MultiFLARE から EMOCA へ FLAME をリンクします: `ln TrackerAdaptation/submodules/EMOCA/assets/FLAME/geometry/generic_model.pkl MultiFLARE/assets/flame/flame2020.pkl`
    - これは [FLAME](https://flame.is.tue.mpg.de/download.php)（2020年版）をダウンロードし、解凍して `generic_model.pkl` を `./MultiFLARE/assets/flame/flame2020.pkl` にコピーするのと同等です。
- Basel Face Model のテクスチャ空間を FLAME に適合させたものを取得します。残念ながらライセンスの関係でテクスチャ空間の配布は許可されていません。そのため、この [リポジトリ](https://github.com/TimoBolkart/BFM_to_FLAME) のツールを使ってテクスチャ空間を FLAME に変換してください。変換後のテクスチャモデルファイルを `TrackerAdaptation/submodules/EMOCA/assets/FLAME/texture/FLAME_albedo_from_BFM.npz` に置いてください。

SPARK は NVIDIA RTX A5000（24GB）または RTX A4000（16GB）GPU でテストされています。バッチサイズを減らすことでメモリの少ないGPUでもトレーニング可能です。

</details>

## データセット

独自データの前処理については [MonoFaceCompute](https://github.com/KelianB/MonoFaceCompute) リポジトリを参照してください。

## 使用方法

SPARK は二段階のアプローチです。まず、[MultiFLARE](./MultiFLARE/) を実行して複数の動画から3Dフェイスアバターを再構築します。次に、[TrackerAdaptation](./TrackerAdaptation/) を使って既存の3Dフェイストラッカーをアバターに適応させ、転移学習によりリアルタイムトラッキングを行います。

<details>
    <summary>詳細</summary>

### 1. MultiFLARE

```bash
cd MultiFLARE
python train.py --config configs/example.txt

# Export neutral mesh
python export_mesh.py --config configs/example.txt --resume 3000 --out_dir /tmp/example_mesh --tex_type albedo
```
提供されたサンプル設定ファイルから開始し、`input_dir`、`train_dir`、および `output_dir` を変更することをお勧めします。すべてのパラメータのリストについては、[arguments.py](https://raw.githubusercontent.com/KelianB/SPARK/main/./MultiFLARE/arguments.py) または `python train.py --help` の出力を参照してください。パラメータは設定ファイルまたはコマンドライン引数のいずれかで渡すことができます。

### 2. TrackerAdaptation


```bash
cd TrackerAdaptation
# DECA encoder + MultiFLARE decoder
python train.py --config configs/example_deca.txt
# EMOCA encoder + MultiFLARE decoder
python train.py --config configs/example_emoca.txt
# SMIRK encoder + MultiFLARE decoder (recommended!)
python train.py --config configs/example_smirk.txt
# EMOCA encoder + EMOCA decoder (baseline)
python train.py --config configs/example_emoca_baseline.txt

# Quantitative eval
python evaluate.py --config configs/example_smirk.txt --tracker_resume 3000 --frame_interval 5 --num_frames 64

# Visualization videos
python make_comparison_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 5 6 --n_frames 1000 --smooth_crops --framerate 24
python make_overlay_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 2 --out test_beard --texture /path/to/texture.png --n_frames 1000 --smooth_crops --framerate 24
```
</details>

## ライセンス情報

このリポジトリのコードは複数のライセンスの対象となっています。

1. **オリジナルコード**（Technicolor Group & INRIA Rennes）
   - 特に指定のない限り、本リポジトリ内のすべてのコードは[CC BY-NC-SA ライセンス](./LICENSE)の下でライセンスされています。

2. **サードパーティコード**（マックス・プランク知能システム研究所）
   - 場所：`./MultiFLARE/flame`、`./MultiFLARE/flare`、`./TrackerAdaptation/submodules`
   - これらのディレクトリにはマックス・プランク研究所のコードが含まれており、一部改変が加えられています。[MPIライセンス](./LICENSE_MPI)をよくお読みください。これは**非営利の科学研究目的**にのみ利用可能です。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---