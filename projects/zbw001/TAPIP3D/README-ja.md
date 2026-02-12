<div align="center">

# TAPIP3D: 永続的な3Dジオメトリ内の任意の点の追跡
<a href="https://arxiv.org/abs/2504.14717"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://tapip3d.github.io'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>

[Bowei Zhang](https://scholar.google.com/citations?user=tYH72AYAAAAJ)<sup>1,2</sup>*, [Lei Ke](https://www.kelei.site/)<sup>1</sup>\*, [Adam W. Harley](https://adamharley.com/)<sup>3</sup>, [Katerina Fragkiadaki](https://www.cs.cmu.edu/~katef/)<sup>1</sup>

<sup>1</sup>カーネギーメロン大学   &nbsp;  <sup>2</sup>北京大学 &nbsp;  <sup>3</sup>スタンフォード大学

**NeurIPS 2025**

\* 同等の貢献

<!-- <a href='https://huggingface.co/spaces/your-username/project'><img src='https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Live_Demo-blue'></a> -->

</div>

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/teaser1.gif" width="100%" alt="TAPIP3D overview">


---

### 🚀 ニュース
- **(2025.12.28)** 🔥 **トレーニング** と **評価** コードを更新しました！以下の新しいセクションをご覧ください。

## 概要
**TAPIP3D** は、単眼RGBおよびRGB-Dビデオシーケンスにおける長期の**フィードフォワード**3D点追跡の手法です。画像特徴を永続的なワールド座標空間に持ち上げる3D特徴クラウド表現を導入し、カメラの動きをキャンセルし、フレーム間の正確な軌跡推定を可能にします。

我々のTAPIP3Dの詳細な[ビデオ解説](https://neurips.cc/virtual/2025/loc/san-diego/poster/117634#:~:text=Within%20this%20stabilized%203D%20representation,trained%20checkpoints%20will%20be%20public.)を提供しています。

## インストール
### 依存関係のインストール

1. 環境を準備する
```bash
conda create -n tapip3d python=3.10
conda activate tapip3d

pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 "xformers>=0.0.27" --index-url https://download.pytorch.org/whl/cu124
pip install torch-scatter -f https://data.pyg.org/whl/torch-2.4.1+cu124.html
pip install -r requirements.txt
```

2. pointops2をコンパイルする

```bash
cd third_party/pointops2
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../..
```

3. megasamをコンパイルする
```bash
cd third_party/megasam/base
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../../..
```
### チェックポイントのダウンロード

TAPIP3Dモデルのチェックポイントを[こちら](https://huggingface.co/zbww/tapip3d/resolve/main/tapip3d_final.pth)から `checkpoints/tapip3d_final.pth` にダウンロードしてください。

単眼動画でTAPIP3Dを実行する場合は、MegaSAMを動かすために以下のチェックポイントを手動で準備する必要があります。

1. DepthAnything V1のチェックポイントを[こちら](https://huggingface.co/spaces/LiheYoung/Depth-Anything/resolve/main/checkpoints/depth_anything_vitl14.pth)からダウンロードし、`third_party/megasam/Depth-Anything/checkpoints/depth_anything_vitl14.pth` に配置してください。

2. RAFTのチェックポイントを[こちら](https://drive.google.com/drive/folders/1sWDsfuZ3Up38EUQt7-JDTT1HcGHuJgvT)からダウンロードし、`third_party/megasam/cvd_opt/raft-things.pth` に配置してください。

さらに、[MoGe](https://wangrc.site/MoGePage/) と [UniDepth](https://github.com/lpiccinelli-eth/UniDepth.git) のチェックポイントはデモ実行時に自動的にダウンロードされます。ネットワーク接続が利用可能であることを確認してください。

## デモの使い方

簡単なデモスクリプト `inference.py` とサンプル入力データが `demo_inputs/` ディレクトリに用意されています。

スクリプトは `.mp4` 動画ファイルまたは `.npz` ファイルのいずれかを入力として受け付けます。 `.npz` ファイルを提供する場合、以下のフォーマットに従う必要があります：

- `video`: 形状 (T, H, W, 3)、データ型: uint8
- `depths`（任意）: 形状 (T, H, W)、データ型: float32
- `intrinsics`（任意）: 形状 (T, 3, 3)、データ型: float32
- `extrinsics`（任意）: 形状 (T, 4, 4)、データ型: float32

デモ用に、スクリプトは最初のフレームで32x32のグリッド上のポイントをクエリとして使用します。

### 単眼動画での推論

`--input_path` に動画を指定すると、スクリプトはまず [MegaSAM](https://github.com/mega-sam/mega-sam) と [MoGe](https://wangrc.site/MoGePage/) を用いて深度マップとカメラパラメータを推定します。その後、モデルはこれらの入力をグローバルフレーム内で処理します。

**デモ 1**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo1.gif" width="100%" alt="Demo 1">

推論を実行するには：



```bash
python inference.py --input_path demo_inputs/sheep.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```
npzファイルが`outputs/inference/`に保存されます。結果を可視化するには：


```bash
python visualize.py <result_npz_path>
```

**Demo 2**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo2.gif" width="100%" alt="Demo 2">

```bash
python inference.py --input_path demo_inputs/pstudio.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

**既知の深度とカメラパラメータを用いた推論**

4つのキー（`rgb`、`depths`、`intrinsics`、`extrinsics`）をすべて含む`.npz`ファイルが提供されると、モデルは整列されたグローバルフレームで動作し、ワールド座標での点軌跡を生成します。  
例として1つの`.npz`ファイルを[こちら](https://huggingface.co/zbww/tapip3d/resolve/main/demo_inputs/dexycb.npz?download=true)に用意しており、`demo_inputs/`ディレクトリに置いてください。

**デモ 3**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo3.gif" width="100%" alt="Demo 3">

```bash
python inference.py --input_path demo_inputs/dexycb.npz --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

## トレーニングと評価

### 1. データセット準備
トレーニングおよび評価用のデータセット準備については、[DATASET.md](https://raw.githubusercontent.com/zbw001/TAPIP3D/main/DATASET.md) を参照してください。

### 2. トレーニング
トレーニングを開始するには、次のコマンドを実行してください：
```bash
bash scripts/train.sh
```
- `experiment_name`: **WandB** に表示される実行名。
- `experiment_id`: 一意の識別子。同じ `experiment_id` で再実行すると、**最新のチェックポイントから自動的に**トレーニングが再開されます。

### 3. 評価
チェックポイントを評価するには、次を実行してください。
```bash
bash scripts/eval.sh
```
`checkpoint`変数を`scripts/eval.sh`内で変更することで、評価するモデルを指定できます。

## 引用
このプロジェクトが役立つと感じた場合は、引用をご検討ください：

```
@article{tapip3d,
  title={TAPIP3D: Tracking Any Point in Persistent 3D Geometry},
  author={Zhang, Bowei and Ke, Lei and Harley, Adam W and Fragkiadaki, Katerina},
  journal={arXiv preprint arXiv:2504.14717},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-12

---