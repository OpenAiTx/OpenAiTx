<div align="center">

# UniSH: フィードフォワードパスにおけるシーンと人体再構築の統合


**Mengfei Li**<sup>1</sup>, **Peng Li**<sup>1</sup>, **Zheng Zhang**<sup>2</sup>, **Jiahao Lu**<sup>1</sup>, **Chengfeng Zhao**<sup>1</sup>, **Wei Xue**<sup>1</sup>,
<br>
**Qifeng Liu**<sup>1</sup>, **Sida Peng**<sup>3</sup>, **Wenxiao Zhang**<sup>1</sup>, **Wenhan Luo**<sup>1</sup>, **Yuan Liu**<sup>1†</sup>, **Yike Guo**<sup>1†</sup>

<sup>1</sup>HKUST, <sup>2</sup>BUPT, <sup>3</sup>ZJU

<br>

<a href="https://arxiv.org/abs/2601.01222" target="_blank"><img src="https://img.shields.io/badge/arXiv-Paper-b31b1b.svg" alt="arXiv"></a>
<a href="https://murphylmf.github.io/UniSH/" target="_blank"><img src="https://img.shields.io/badge/Project-Page-orange" alt="Project Page"></a>
<a href="https://huggingface.co/spaces/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Spaces-yellow" alt="Hugging Face Demo"></a>
<a href="https://huggingface.co/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue" alt="Hugging Face Model"></a>
<a href="LICENSE" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-green.svg" alt="License"></a>

</div>

---

### TL;DR
単眼ビデオを入力とした場合、UniSHは単一のフォワードパスでシーンと人体を共同で再構築でき、シーンのジオメトリ、カメラパラメータ、SMPLパラメータの効果的な推定を可能にします。


<video src="static/teaser_video_final.mp4" autoplay loop muted playsinline width="100%"></video>

<img src="https://raw.githubusercontent.com/murphylmf/UniSH/main/static/teaser.svg" width="100%" style="background-color: white;">

## 🛠️ インストール

ほとんどのLinuxサーバー（ヘッドレスも含む）で動作する**sudo不要**のインストール方法を提供します。

### ステップ 1: リポジトリをクローンする

```bash
git clone https://github.com/murphylmf/UniSH.git
cd UniSH
```

### ステップ 2: Conda環境の作成
これにより、Python、システムコンパイラ、およびOpenGLドライバがインストールされます。

```bash
conda env create -f environment.yml
conda activate unish
```

### ステップ3: 依存関係のコンパイル
このスクリプトは、ステップ2でインストールしたコンパイラを使用して、PyTorch3D、MMCV、およびSAM2をソースからコンパイルします。

この環境は**CUDA 12.1**および**CUDA 11.8**でテストされています。インストールスクリプトに引数としてCUDAバージョンを指定することができます。

```bash
# Default (Auto-detect or 12.1)
bash install.sh

# For CUDA 11.8
bash install.sh 11.8

# For CUDA 12.1
bash install.sh 12.1
```

### ステップ4：SMPLモデルのダウンロード
[SMPL](https://smpl.is.tue.mpg.de/)モデルをダウンロードし、`body_models`フォルダに配置してください。
ディレクトリ構造は以下のように整理する必要があります：

```text
UniSH/
├── body_models/
│   └── smpl/
│       └── smpl/
│           ├── SMPL_FEMALE.pkl
│           ├── SMPL_MALE.pkl
│           └── SMPL_NEUTRAL.pkl
```

## 🚀 クイックスタート（推論）

### 推論の実行
次のコマンドを実行して、ビデオからシーンと人物を再構築します：

```bash
python inference.py --output_dir inference_results/example --video_path examples/example_video.mp4 
```

詳細なパラメータについては `inference.py` を参照してください。

## 📝 引用

このコードが研究に役立った場合は、私たちの論文を引用していただけると幸いです：

```bibtex
@misc{li2026unishunifyingscenehuman,
      title={UniSH: Unifying Scene and Human Reconstruction in a Feed-Forward Pass}, 
      author={Mengfei Li and Peng Li and Zheng Zhang and Jiahao Lu and Chengfeng Zhao and Wei Xue and Qifeng Liu and Sida Peng and Wenxiao Zhang and Wenhan Luo and Yuan Liu and Yike Guo},
      year={2026},
      eprint={2601.01222},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2601.01222}, 
}
```

## 🙏 謝辞

以下のプロジェクトからの優れた貢献に感謝します：

* [GVHMR](https://github.com/zju3dv/GVHMR)
* [BEDLAM](https://bedlam.is.tue.mpg.de/)
* [SMPL](https://smpl.is.tue.mpg.de/)
* [VGGT](https://github.com/facebookresearch/vggt)
* [Pi3](https://github.com/yyfz/Pi3)
* [MoGe2](https://github.com/microsoft/moge)

## 📄 ライセンス
本プロジェクトはApache 2.0ライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)をご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---