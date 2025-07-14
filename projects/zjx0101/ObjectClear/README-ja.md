<div align="center">
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/zjx0101/ObjectClear/main/./assets/ObjectClear_logo.png" alt="ObjectClear Logo" style="height: 52px;">
    <h2>オブジェクト効果注意機構による完全なオブジェクト除去</h2>
</div>

<div>
    <a href="https://zjx0101.github.io/" target='_blank'>趙 吉新</a>&emsp;
    <a href='https://shangchenzhou.com/' target='_blank'>周 尚晨<sup>†</sup></a>&emsp;
    <a href='https://wzhouxiff.github.io' target='_blank'>王 周夏</a>&emsp;
    <a href='https://pq-yang.github.io/' target='_blank'>楊 佩青</a>&emsp;
    <a href='https://www.mmlab-ntu.com/person/ccloy/' target='_blank'>ロイ・チェン・チェンジ</a>
</div>
<div>
    南洋理工大学 S-Lab<br>
   <p><sup>†</sup>責任著者</p>
</div>


<div>
    <h4 align="center">
        <a href="https://zjx0101.github.io/projects/ObjectClear/" target='_blank'>
        <img src="https://img.shields.io/badge/🐳-Project%20Page-blue">
        </a>
        <a href="https://arxiv.org/abs/2505.22636" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2505.22636-b31b1b.svg">
        </a>
        <a href="https://huggingface.co/spaces/jixin0101/ObjectClear" target='_blank'>
        <img src="https://img.shields.io/badge/Demo-%F0%9F%A4%97%20Hugging%20Face-blue">
        </a>
        <img src="https://api.infinitescript.com/badgen/count?name=sczhou/ObjectClear&ltext=Visitors&color=3977dd">
    </h4>
</div>

<strong>ObjectClearは、対象オブジェクトとその関連効果をオブジェクト効果注意機構を活用して同時に除去しつつ、背景の一貫性を保持するオブジェクト除去モデルです。</strong>

<div style="width: 100%; text-align: center; margin:auto;">
    <img style="width:100%" src="https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/teaser.jpg">
</div>

より多くの視覚的結果については、ぜひ<a href="https://zjx0101.github.io/projects/ObjectClear/" target="_blank">プロジェクトページ</a>をご覧ください。

---
</div>


## ⭐ アップデート
- [2025.07] 推論コードとGradioデモをリリースしました。
- [2025.05] このリポジトリを作成しました。


## 🎃 概要
![overall_structure](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/ObjectClear_pipeline.png)


## 📷 OBERデータセット
![OBER_dataset_pipeline](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/OBER_pipeline.png)

OBER（オブジェクト効果除去）は、効果付きオブジェクト除去の研究を支援するために設計されたハイブリッドデータセットで、カメラ撮影データとシミュレーションデータの両方を組み合わせています。

![OBER_dataset_samples](https://raw.githubusercontent.com/zjx0101/ObjectClear/main/assets/dataset_samples.png)


## ⚙️ インストール
1. リポジトリをクローンする
    ```bash
    git clone https://github.com/zjx0101/ObjectClear.git
    cd ObjectClear
    ```
2. Conda環境の作成と依存関係のインストール

    ```bash
    # create new conda env
    conda create -n objectclear python=3.10 -y
    conda activate objectclear

    # install python dependencies
    pip3 install -r requirements.txt
    # [optional] install python dependencies for gradio demo
    pip3 install -r hugging_face/requirements.txt
    ```
## ⚡ 推論

### クイックテスト
[`inputs`](./inputs) フォルダにいくつかの例を提供しています。**各実行では、画像とそのセグメンテーションマスクを入力として使用します。** <u>セグメンテーションマスクは、[SAM2デモ](https://huggingface.co/spaces/fffiloni/SAM2-Image-Predictor) のようなインタラクティブセグメンテーションモデルから取得できます</u>。例えば、ディレクトリ構造は次のように整理できます：


```
inputs
   ├─ imgs
   │   ├─ test-sample1.jpg      # .jpg, .png, .jpeg supported
   │   ├─ test-sample2.jpg
   └─ masks
       ├─ test-sample1.png
       ├─ test-sample2.png
```
以下のコマンドを実行して試してください：

```shell
## Single image inference
python inference_objectclear.py -i inputs/imgs/test-sample1.jpg -m inputs/masks/test-sample1.png --use_fp16

## Batch inference on image folder
python inference_objectclear.py -i inputs/imgs -m inputs/masks --use_fp16
```
## 🪄 インタラクティブデモ
セグメンテーションマスクの準備を省くために、[hugging face](https://huggingface.co/spaces/jixin0101/ObjectClear)でgradioデモを用意し、[ローカルでも起動可能](./hugging_face)です。画像をドロップし、数回クリックで対象マスクを割り当て、オブジェクト除去結果を得るだけ！


```shell
cd hugging_face

# install python dependencies
pip3 install -r requirements.txt

# launch the demo
python app.py
```
## 📑 引用
私たちのリポジトリがあなたの研究に役立った場合は、ぜひ私たちの論文を引用してください:



```bibtex
@InProceedings{zhao2025ObjectClear,
    title     = {{ObjectClear}: Complete Object Removal via Object-Effect Attention},
    author    = {Zhao, Jixin and Zhou, Shangchen and Wang, Zhouxia and Yang, Peiqing and Loy, Chen Change},
    booktitle = {arXiv preprint arXiv:2505.22636},
    year      = {2025}
    }
```
## 📧 お問い合わせ
ご質問がある場合は、`jixinzhao0101@gmail.com`までお気軽にご連絡ください。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---