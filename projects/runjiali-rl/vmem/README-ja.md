<div align="center">
<img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/title_logo.png" width="200" alt="VMem Logo"/>
<h1>VMem: サーフェルインデックス付きビュー・メモリによる一貫したインタラクティブ動画シーン生成</h1>

<p align="center">ICCV 2025</p>


<a href="https://v-mem.github.io/"><img src="https://img.shields.io/badge/%F0%9F%8F%A0%20Project%20Page-gray.svg"></a>
<a href="http://arxiv.org/abs/2506.18903"><img src="https://img.shields.io/badge/%F0%9F%93%84%20arXiv-2506.18903-B31B1B.svg"></a>
<a href="https://huggingface.co/liguang0115/vmem"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Model_Card-Huggingface-orange"></a>
<a href="https://huggingface.co/spaces/liguang0115/vmem"><img src="https://img.shields.io/badge/%F0%9F%9A%80%20Gradio%20Demo-Huggingface-orange"></a>

[Runjia Li](https://runjiali-rl.github.io/), [Philip Torr](https://www.robots.ox.ac.uk/~phst/), [Andrea Vedaldi](https://www.robots.ox.ac.uk/~vedaldi/), [Tomas Jakab](https://www.robots.ox.ac.uk/~tomj/)
<br>
<br>
[オックスフォード大学](https://www.robots.ox.ac.uk/~vgg/)
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/demo_teaser.gif" width="100%" alt="Teaser" style="border-radius:10px;"/>
</p>

<!-- <p align="center" border-radius="10px">
  <img src="https://raw.githubusercontent.com/runjiali-rl/vmem/main/assets/benchmark.png" width="100%" alt="teaser_page1"/>
</p> -->

# 概要

`VMem` は、一貫したシーン生成のための画像セットモデルのプラグアンドプレイメモリ機構です。
既存の手法は、精度の問題を抱える明示的な幾何推定を伴うインペインティングに依存するか、動画ベースのアプローチで限定的なコンテキストウィンドウを使用し、長期的な一貫性が低下します。これらの問題を克服するために、我々は過去のビューを観測したサーフェル（表面要素）に固定するサーフェルメモリ・オブ・ビュー（VMem）を導入します。これにより、最新のビューだけでなく最も関連性の高い過去のビューを条件として新規ビュー生成が可能となり、長期的なシーンの一貫性が向上し、計算コストも削減されます。


# :wrench: インストール

```bash
conda create -n vmem python=3.10
conda activate vmem
pip install -r requirements.txt
```
<translate-content>

# :rocket: 使用方法

モデルの重みをダウンロードするには、Hugging Faceで適切に認証する必要があります。設定が完了すると、コードは初回実行時に自動的に処理します。認証は次のコマンドで行えます
</translate-content>
```bash
# This will prompt you to enter your Hugging Face credentials.
huggingface-cli login
```
認証が完了したら、当社のモデルカードの[こちら](https://huggingface.co/liguang0115/vmem)にアクセスし、アクセスのための情報を入力してください。

`VMem`と対話するためのデモを提供しています。単に実行してください。


```bash
python app.py
```
<translate-content>

## :heart: 謝辞
本研究は[ CUT3R ](https://github.com/CUT3R/CUT3R)、[ DUSt3R ](https://github.com/naver/dust3r)、および[ Stable Virtual Camera ](https://github.com/stability-ai/stable-virtual-camera)を基に構築されています。これらの素晴らしい作品に感謝します。





# :books: 引用

このリポジトリが役に立った場合は、スター :star: および引用をご検討ください。
</translate-content>
```
@article{li2025vmem,
  title={VMem: Consistent Interactive Video Scene Generation with Surfel-Indexed View Memory},
  author={Li, Runjia and Torr, Philip and Vedaldi, Andrea and Jakab, Tomas},
  journal={arXiv preprint arXiv:2506.18903},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---