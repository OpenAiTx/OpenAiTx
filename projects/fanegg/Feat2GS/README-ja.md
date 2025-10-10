<h2 align="center"> <a href="https://arxiv.org/abs/2412.09606">Feat2GS: ガウススプラッティングによる視覚基盤モデルのプロービング</a>
</h2>

<h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2412.09606-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2412.09606) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://fanegg.github.io/Feat2GS/)  [![youtube](https://img.shields.io/badge/Video-E33122?logo=Youtube)](https://youtu.be/4fT5lzcAJqo?si=_fCSIuXNBSmov2VA)  [![Gradio](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Demo-orange)](https://huggingface.co/spaces/endless-ai/Feat2GS)  [![X](https://img.shields.io/badge/@Yue%20Chen-black?logo=X)](https://twitter.com/faneggchen)  [![Bluesky](https://img.shields.io/badge/@Yue%20Chen-white?logo=Bluesky)](https://bsky.app/profile/fanegg.bsky.social)

[Yue Chen](https://fanegg.github.io/),
[Xingyu Chen](https://rover-xingyu.github.io/),
[Anpei Chen](https://apchenstu.github.io/),
[Gerard Pons-Moll](https://virtualhumans.mpi-inf.mpg.de/),
[Yuliang Xiu](https://xiuyuliang.cn/)
</h5>

<div align="center">
本リポジトリは、視覚基盤モデルの「テクスチャおよびジオメトリ認識」を探る統一フレームワークであるFeat2GSの公式実装です。新規視点合成は3D評価の効果的な代理として機能します。
</div>
<br>

https://github.com/user-attachments/assets/07ebb8e1-6001-47bf-bf74-984b0032cc17


## 更新情報

- [2025年7月10日] VGGTエンコーダおよびデコーダ特徴の新評価を追加しました。結果はこちらでご覧ください。[こちら](https://raw.githubusercontent.com/fanegg/Feat2GS/main/assets/Feat2GS_Benchmark.pdf)。

## はじめに

### インストール
1. Feat2GSをクローンし、[DUSt3R](https://github.com/naver/dust3r)/[MASt3R](https://github.com/naver/mast3r)から事前学習済みモデルをダウンロードします。

```bash
git clone https://github.com/fanegg/Feat2GS.git
cd Feat2GS/submodules/mast3r/
mkdir -p checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/DUSt3R/DUSt3R_ViTLarge_BaseDecoder_512_dpt.pth -P checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/MASt3R/MASt3R_ViTLarge_BaseDecoder_512_catmlpdpt_metric.pth -P checkpoints/
cd ../../
```
2. 環境を作成します。ここではcondaを使用した例を示します。

```bash
conda create -n feat2gs python=3.11 cmake=3.14.0
conda activate feat2gs
pip install "torch==2.5.1" "torchvision==0.20.1" "numpy<2" --index-url https://download.pytorch.org/whl/cu121  # use the correct version of cuda for your system
cd Feat2GS/
pip install -r requirements.txt
pip install submodules/simple-knn
```
3. 任意ですが強く推奨されます。RoPE用のCUDAカーネルをコンパイルしてください（CroCo v2のように）。

```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd submodules/mast3r/dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../../../
```

4. （オプション）[こちらの指示](https://github.com/cvlab-columbia/zero123?tab=readme-ov-file#novel-view-synthesis-1)に従って、[Zero123](https://github.com/cvlab-columbia/zero123)のプロービング用の要件をインストールしてください。

### 使用方法
1. データ準備（評価および推論用データセットを提供しています：[リンク](https://drive.google.com/file/d/1PLTFcvJfiPucrB-pIwfp5QG-AIHcJdjN/view?usp=drive_link)）
```bash
  cd <data_root>/Feat2GS/
```

> カスタムデータセットを構築したい場合は、以下を参照して編集してください：
> ```
> build_dataset/0_create_json.py ## train/testセットを分割するためのdataset_split.jsonを作成
> build_dataset/1_create_feat2gs_dataset.py ## dataset_split.jsonを使ってデータセットを作成
> ```


2. Visual Foundation Modelsの評価：

  | ステップ | 説明（コマンドへのリンク） |
  |------|-------------|
  | (1)  | [DUSt3Rの初期化＆特徴抽出](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L245-L250) |
  | (2)  | [特徴から3DGSを読み出し＆ポーズを共同最適化](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L253-L262) |
  | (3)  | [ポーズ初期化のテスト](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L265-L270) |
  | (4)  | [評価用のテストビューをレンダリング](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L273-L282) |
  | (5)  | [評価指標](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L298-L301) |
  | (オプション)  | [生成された軌跡で動画をレンダリング](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L304-L315) |

```bash
  # Run evaluation for all datasets, all VFM features, all probing modes
  bash scripts/run_feat2gs_eval_parallel.sh

  # (Example) Run evaluation for a single scene, DINO feature, Geometry mode
  bash scripts/run_feat2gs_eval.sh
```
> [!NOTE]
> 並列で実験を実行するために、1つのGPUにつき1つの評価実験のみが実行されるようにする **GPUロック** 機能を追加しました。実験が終了するとGPUは自動的にアンロックされます。**`Ctrl+C`で中断した場合、GPUは自動的にアンロックされません。** これを修正するには、`LOCK_DIR`内の`.lock`ファイルを手動で削除してください。この機能を無効にするには、スクリプト内の以下の行をコメントアウトしてください：
    [L4-L5](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L4-L5),
    [L9-L22](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L9-L22),
    [L223-L233](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L223-L233),
    [L330-L331](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L330-L331).

  | 設定 | 操作 |
  |--------|-----------------|
  | GPU | [`<AVAILABLE_GPUS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L7) で編集 |
  | データセット | [`<SCENES[$Dataset]>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L105-L111) で編集 |
  | シーン | [`<SCENES_$Dataset>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L31-L99) で編集 |
  | ビジュアルファウンデーションモデル | [`<FEATURES>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L120-L162) で編集 |
  | プロービングモード | [`<MODELS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L181-L188) で編集 |
  | 推論専用モード | [`execute_command`](https://github.com/fanegg/Feat2GS/blob/main/scripts/run_feat2gs_eval_parallel.sh#L325-L327) のSTEP (3)(4)(5)をコメントアウト |

```bash
  # Evaluate Visual Foundation Models on DTU dataset
  bash scripts/run_feat2gs_eval_dtu_parallel.sh

  # Run InstantSplat for evaluation
  bash scripts/run_instantsplat_eval_parallel.sh
```
3. トレーニング後、生成された軌跡を用いてRGB／深度／法線ビデオをレンダリングします。


```bash
  # If render depth/normal, set RENDER_DEPTH_NORMAL=true
  # Set type of generated trjectory by editing <TRAJ_SCENES>
  bash scripts/run_video_render.sh

  # Render video on DTU dataset
  bash scripts/run_video_render_dtu.sh
```
### 🎮 インタラクティブデモ

#### 🚀 クイックスタート
1. **入力画像**
* 同じシーンを異なる視点から撮影した画像を2枚以上アップロードしてください
* 最良の結果を得るために、画像間の重なりが十分であることを確認してください

2. **ステップ1：DUSt3Rの初期化と特徴抽出**
* 「RUN Step 1」をクリックして画像を処理します
* このステップでは初期のDUSt3R点群とカメラ位置を推定し、各ピクセルのDUSt3R特徴を抽出します

3. **ステップ2：特徴から3DGSの読み出し**
* トレーニング反復回数を設定します。数が大きいほど品質は良くなりますが時間も長くなります（デフォルト：2000、最大：8000）
* 「RUN Step 2」をクリックして3Dモデルを最適化します

4. **ステップ3：ビデオレンダリング**
* カメラ軌道を選択します
* 「RUN Step 3」をクリックして3Dモデルのビデオを生成します

```bash
gradio demo.py
```

#### 💡 ヒント
* 処理時間は画像の解像度と数量に依存します
* 最適なパフォーマンスのために、高性能GPU（A100/4090）でテストしてください
* 3Dモデルとの操作にはマウスを使用します：
  - 左ボタン：回転
  - スクロールホイール：ズーム
  - 右ボタン：パン


## 謝辞

本研究は多くの素晴らしい研究成果とオープンソースプロジェクトに基づいています。共有してくださったすべての著者に感謝します！

- [Gaussian-Splatting](https://github.com/graphdeco-inria/gaussian-splatting) および [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [gsplat](https://github.com/nerfstudio-project/gsplat)
- [DUSt3R](https://github.com/naver/dust3r) および [MASt3R](https://github.com/naver/mast3r)
- [InstantSplat](https://github.com/NVlabs/InstantSplat)
- [Probe3D](https://github.com/mbanani/probe3d)
- [FeatUp](https://github.com/mhamilton723/FeatUp)
- [Shape of Motion](https://github.com/vye16/shape-of-motion/)
- [Splatt3R](https://github.com/btsmart/splatt3r)
- [VGGT](https://github.com/facebookresearch/vggt)

## 引用
本研究があなたの研究に役立った場合は、スター :star: を付け、以下の論文 :pencil: を引用していただけると幸いです。

```bibTeX
@inproceedings{chen2025feat2gs,
  title={Feat2gs: Probing visual foundation models with gaussian splatting},
  author={Chen, Yue and Chen, Xingyu and Chen, Anpei and Pons-Moll, Gerard and Xiu, Yuliang},
  booktitle={Proceedings of the Computer Vision and Pattern Recognition Conference},
  pages={6348--6361},
  year={2025}
}
```

## お問い合わせ

ご意見、ご質問、またはプレス関係のお問い合わせは、[Yue Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:faneggchen@gmail.com) および [Xingyu Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:roverxingyu@gmail.com) までご連絡ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-10

---