<p align="center">
  <h1 align="center">VideoScene: 3Dシーンを一ステップで生成するビデオ拡散モデルの蒸留</h1>
  <p align="center">
    <a href="https://hanyang-21.github.io/">ハンヤン・ワン</a><sup>*</sup>,
    <a href="https://liuff19.github.io/">ファンフ・リウ</a><sup>*</sup>,
    <a href="https://github.com/hanyang-21/VideoScene">ジアウェイ・チー</a>,
    <a href="https://duanyueqi.github.io/">ユエチ・ドゥアン</a>
    <br>
    <sup>*</sup>同等の貢献。
    <br>
    清華大学
  </p>
  <h3 align="center">CVPR 2025 ハイライト 🔥</h3>
  <h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2403.20309-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2504.01956) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://hanyang-21.github.io/VideoScene)
<a><img src='https://img.shields.io/badge/License-MIT-blue'></a>
<a href='https://mp.weixin.qq.com/s/u6OUo5mHKPG6I3yYJPMC8Q'><img src='https://img.shields.io/badge/%E5%BE%AE%E4%BF%A1-%E4%B8%AD%E6%96%87%E4%BB%8B%E7%BB%8D-green'></a>

</h5>
  <!-- <h3 align="center"><a href="https://arxiv.org/abs/">論文</a> | <a href="">プロジェクトページ</a> | <a href="">事前学習済みモデル</a> </h3> -->
<!--   <div align="center">
    <a href="https://news.ycombinator.com/item?id=41222655">
      <img
        alt="Hacker Newsで特集"
        src="https://hackerbadge.vercel.app/api?id=41222655&type=dark"
      />
    </a>
  </div> -->

</p>

<div align="center">
VideoSceneは、ビデオから3Dへのギャップを埋める一ステップビデオ拡散モデルです。
</div>
</br>


https://github.com/user-attachments/assets/dca733b1-b78f-49ac-ae47-5d1b1e8a689b

[ReconX](https://github.com/liuff19/ReconX)を基に、VideoSceneはターボ版の進化を遂げました。



## インストール

始めるには、このプロジェクトをクローンし、Python 3.10+を用いたconda仮想環境を作成し、依存関係をインストールしてください。

1. VideoSceneをクローンします。
```bash
git clone https://github.com/hanyang-21/VideoScene
cd VideoScene
```
2. 環境を作成します。ここではcondaを使用した例を示します。

```bash
conda create -y -n videoscene python=3.10
conda activate videoscene
pip install torch==2.1.2 torchvision==0.16.2 torchaudio==2.1.2 --index-url https://download.pytorch.org/whl/cu118
pip install -r requirements.txt
```

3. 任意で、RoPE用のcudaカーネルをコンパイルします（CroCo v2と同様）。
```bash
# NoPoSplat relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd src/model/encoder/backbone/croco/curope/
python setup.py build_ext --inplace
cd ../../../../../..
```

## データセットの取得

### RealEstate10K と ACID

私たちの VideoScene は pixelSplat と同じトレーニングデータセットを使用しています。以下に pixelSplat の [詳細な手順](https://github.com/dcharatan/pixelsplat?tab=readme-ov-file#acquiring-datasets) を引用します。

> pixelSplat は、RealEstate10k と ACID データセットのバージョンを約100MBのチャンクに分割し、サーバークラスターのファイルシステムで使用できるようにしてトレーニングされました。RealEstate10k と ACID のこの形式の小規模サブセットは [こちら](https://drive.google.com/drive/folders/1joiezNCyQK2BvWMnfwHJpm2V77c7iYGe?usp=sharing) で見つけられます。使用するには、プロジェクトのルートディレクトリに新規作成した `datasets` フォルダに解凍してください。

> ダウンロードした RealEstate10k と ACID データセットを私たちの形式に変換したい場合は、[こちらのスクリプト](https://github.com/dcharatan/real_estate_10k_tools) を使用できます。処理済みの完全版データセット（RealEstate10k 約500GB、ACID 約160GB）が必要な場合は、私たち（pixelSplat）にお問い合わせください。

## チェックポイントのダウンロード

* 私たちの [事前学習済み重み](https://wisemodel.cn/models/hanyang/VideoScene/file)（`VideoScene/checkpoints/model.safetensors` および `VideoScene/checkpoints/prompt_embeds.pt`）をダウンロードし、`checkpoints` に保存してください。

* カスタマイズされた画像入力用に、NoPoSplat の [事前学習済みモデル](https://huggingface.co/botaoye/NoPoSplat/resolve/main/mixRe10kDl3dv_512x512.ckpt) を取得し、`checkpoints/noposplat` に保存してください。

* RealEstate10K データセット用に、MVSplat の [事前学習済みモデル](https://drive.google.com/drive/folders/14_E_5R6ojOWnLSrSVLVEMHnTiKsfddjU) を取得し、`checkpoints/mvsplat` に保存してください。

## コードの実行

### Gradio デモ
このデモでは、ローカルマシンで VideoScene を実行し、ポーズのない入力ビューから動画を生成できます。

* 同じシーンを描写する画像ペアを選択し、「RUN」を押すとそのシーンの動画が生成されます。


```bash
python -m noposplat.src.app \
    checkpointing.load=checkpoints/noposplat/mixRe10kDl3dv_512x512.ckpt \
    test.video=checkpoints/model.safetensors

# also "bash demo.sh"
```
* 生成されたビデオは `outputs/gradio` に保存されます

### 推論

RealEstate10Kデータセットでビデオを生成するために、[MVSplat](https://github.com/donydchen/mvsplat) の事前学習済みモデルを使用します、

* 以下を実行してください：

```bash
# re10k
python -m mvsplat.src.main +experiment=re10k \
checkpointing.load=checkpoints/mvsplat/re10k.ckpt \
mode=test \
dataset/view_sampler=evaluation \
dataset.view_sampler.index_path=mvsplat/assets/evaluation_index_re10k_video.json \
test.save_video=true \
test.save_image=false \
test.compute_scores=false \
test.video=checkpoints/model.safetensors

# also "bash inference.sh"
```

* 生成されたビデオは `outputs/test` に保存されます


## BibTeX

```bibtex
@misc{wang2025videoscenedistillingvideodiffusion,
      title={VideoScene: Distilling Video Diffusion Model to Generate 3D Scenes in One Step}, 
      author={Hanyang Wang and Fangfu Liu and Jiawei Chi and Yueqi Duan},
      year={2025},
      eprint={2504.01956},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2504.01956}, 
}
```

## 謝辞

本プロジェクトは、いくつかの素晴らしいリポジトリと共に開発されています: [ReconX](https://github.com/liuff19/ReconX)、[MVSplat](https://github.com/donydchen/mvsplat)、[NoPoSplat](https://github.com/cvg/NoPoSplat)、[CogVideo](https://github.com/THUDM/CogVideo)、および [CogvideX-Interpolation](https://github.com/feizc/CogvideX-Interpolation)。これらのプロジェクトの卓越した貢献に深く感謝します！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---