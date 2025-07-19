<div align="center">
<h1>
何でも認識：画像と動画のあらゆるものを認識、説明、キャプション付け、セグメント化（PAM）
</h1>

</div>

<div align="center">

[Weifeng Lin](), [Xinyu Wei](), [Ruichuan An](), [Tianhe Ren](), [Tingwei Chen](), [Renrui Zhang](), [Ziyu Guo]() <br>
[Wentao Zhang](), [Lei Zhang](), [Hongsheng Li]() <br>
CUHK、HKU、PolyU、北京大学

</div>

<p align="center">
  <a href="https://Perceive-Anything.github.io"><b>🌐 プロジェクトサイト</b></a> |
  <a href="https://arxiv.org/abs/2506.05302"><b>📕 論文</b></a> |
  <a href="https://huggingface.co/Perceive-Anything/PAM-3B"><b>📥 モデルダウンロード</b></a> |
  <a href="https://huggingface.co/datasets/Perceive-Anything/PAM-data"><b>🤗 データセット</b></a> |
  <a href="#quick-start"><b>⚡ クイックスタート</b></a> <br>
  <a href="#license"><b>📜 ライセンス</b></a> |
  <a href="#citation"><b>📖 引用 (BibTeX)</b></a> <br>
</p>

<p align="center">
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/teaser_img.jpg" width="95%"> <br>
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/teaser_video.jpg" width="95%"> <br>
</p>

## ニュース

<!-- **2025.06.20**: Gradioデモ公開（[オンラインデモ]() と [ローカル](#gradio-demo)） -->

<!-- **2025.06.05**: 評価コードは[こちら]()を参照してください。 -->

**2025.06.08**: モデル重み（1.5B / 3B）および学習データセットを公開しました。詳細は [PAM-1.5B](https://huggingface.co/Perceive-Anything/PAM-1.5B)、[PAM-3B](https://huggingface.co/Perceive-Anything/PAM-3B)、および [データセット](https://huggingface.co/datasets/Perceive-Anything/PAM-data)をご覧ください。

**2025.06.08**: PAMをリリースしました。これは物体セグメンテーションと理解のためのシンプルなエンドツーエンドの領域レベルVLMです。論文は[こちら](https://arxiv.org/abs/2506.05302)をご覧ください。


## はじめに

**Perceive Anything Model (PAM)** は、画像および動画の包括的な領域レベルの視覚理解のための、概念的にシンプルで効率的なフレームワークです。私たちのアプローチは、SAM 2を拡張し、大規模言語モデル（LLM）を統合することで、多様で領域特有のセマンティック出力（カテゴリ、ラベル定義、機能説明、詳細なキャプションなど）を生成しながら、同時に物体のセグメンテーションを可能にします。SAM 2の豊富な視覚特徴は、一般的なビジョン、位置特定、セマンティック事前知識を本質的に含んでいるため、これを効率的にマルチモーダルトークンに変換し、LLMが理解できるようにしています。堅牢な多粒度理解を支えるために、専用のデータ精製および拡張パイプラインを開発し、新しい領域レベルのストリーミング動画キャプションデータを含む高品質な[**データセット**](https://huggingface.co/datasets/Perceive-Anything/PAM-data)を生成しました。


<p align="center">
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/PAM_comp.jpg" width="95%"> <br>
    <img src="https://raw.githubusercontent.com/Perceive-Anything/PAM/main/assets/PAM_arch.jpg" width="95%"> <br>
</p>

## インストール

1. このリポジトリをクローンし、ベースフォルダに移動します</translate-content>

```bash
git clone https://github.com/Afeng-x/PAM.git
cd PAM
```
2. パッケージをインストールする

```bash
### packages for base
conda create -n PAM python=3.10 -y
conda activate PAM
pip install --upgrade pip
pip install -e ".[train]"
### packages for sam2
cd sam2
pip install -e ".[notebooks]"
```
3. Flash-Attentionのインストール

```bash
pip install flash-attn --no-build-isolation
### (If the method mentioned above don’t work for you, try the following one)
git clone https://github.com/Dao-AILab/flash-attention.git
cd flash-attention
python setup.py install
```
4. SAM2.1-h-large チェックポイントをダウンロードします：

```bash
cd llava/model/multimodal_encoder
bash download_ckpts.sh
```
## クイックスタート

- 画像： [image_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/image_infer_example.ipynb) の例を参照してください
- ビデオ： [video_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/video_infer_example.ipynb) の例を参照してください
- ビデオストリーム： [video_stream_infer_example.ipynb](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/./notebooks/video_stream_infer_example.ipynb) の例を参照してください

## データセット

当社の洗練された拡張データ注釈をダウンロードするには、[こちらのリンク](https://huggingface.co/datasets/Perceive-Anything/PAM-data)を参照してください。

**注意:** ソース画像は直接提供していません。ただし、各データセットについては、ユーザーがダウンロード方法を案内できるように、関連するダウンロードリンクまたは公式ウェブサイトのアドレスを提供します。 [DATA_README](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/data/README.md)

<!-- ## PAMのトレーニング

画像、ビデオ、またはその両方のカスタムデータセットでPAMをトレーニングまたはファインチューニングできます。開始方法についてはトレーニングの[README](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/training/README.md)をご確認ください。 -->

## PAMのローカルGradioデモ
進行中 ......

<!-- ### 画像用シンプルGradioデモ

[`pam_image.py`](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/pam_image.py) - 画像上でマスクを描画し意味情報を取得するためのインタラクティブなGradioウェブインターフェース。**このデモは `gradio` 5.5.0でテストされています。**

### ビデオ用シンプルGradioデモ

[`pam_video.py`](https://raw.githubusercontent.com/Perceive-Anything/PAM/main/pam_video.py) - ビデオ上でマスクを描画し意味情報を取得するためのインタラクティブなGradioウェブインターフェース。**このデモは `gradio` 5.5.0でテストされています。** -->

## ライセンス

このコードリポジトリは[Apache 2.0](./LICENSE)の下でライセンスされています。

## 謝辞
この研究に貢献してくださった以下のプロジェクトに感謝いたします：

- [LLaVA-Next](https://github.com/LLaVA-VL/LLaVA-NeXT)
- [SAM](https://github.com/facebookresearch/segment-anything)
- [SAM 2](https://github.com/facebookresearch/sam2)

## 引用

PAMがあなたの研究やアプリケーションに役立つ場合、または当社のデータセットを研究に使用する場合は、以下のBibTeXエントリをご利用ください。

```bibtex
@misc{lin2025perceiveanythingrecognizeexplain,
      title={Perceive Anything: Recognize, Explain, Caption, and Segment Anything in Images and Videos}, 
      author={Weifeng Lin and Xinyu Wei and Ruichuan An and Tianhe Ren and Tingwei Chen and Renrui Zhang and Ziyu Guo and Wentao Zhang and Lei Zhang and Hongsheng Li},
      year={2025},
      eprint={2506.05302},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05302}, 
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---