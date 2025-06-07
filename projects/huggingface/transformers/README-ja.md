<!---
Copyright 2020 The HuggingFace Team. All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints on Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentation" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>最先端の事前学習済みモデルによる推論と学習</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformersは、テキスト、コンピュータビジョン、音声、ビデオ、マルチモーダルの推論と学習用の事前学習済みモデルのライブラリです。Transformersを使用することで、自分のデータでモデルをファインチューニングしたり、推論アプリケーションを構築したり、さまざまなモダリティで生成AIのユースケースに活用できます。

[Hugging Face Hub](https://huggingface.com/models) には、500,000以上のTransformers [モデルチェックポイント](https://huggingface.co/models?library=transformers&sort=trending)が用意されています。

今日から[Hub](https://huggingface.com/)を探索してモデルを見つけ、Transformersで今すぐ始めましょう。

## インストール

TransformersはPython 3.9+、[PyTorch](https://pytorch.org/get-started/locally/) 2.1+、[TensorFlow](https://www.tensorflow.org/install/pip) 2.6+、[Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+に対応しています。

[venv](https://docs.python.org/3/library/venv.html) または、高速なRustベースのPythonパッケージ・プロジェクトマネージャ [uv](https://docs.astral.sh/uv/) で仮想環境を作成・有効化します。

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

仮想環境内でTransformersをインストールします。

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

ライブラリの最新の変更を利用したい場合や、コントリビュートしたい場合は、ソースからTransformersをインストールしてください。ただし、*最新*バージョンは安定していない可能性があります。エラーが発生した場合は、[issue](https://github.com/huggingface/transformers/issues)を作成してください。

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## クイックスタート

[Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) APIを使って、すぐにTransformersを始められます。`Pipeline`は、テキスト・音声・画像・マルチモーダルのタスクをサポートする高水準の推論クラスです。入力の前処理を行い、適切な出力を返します。

パイプラインをインスタンス化し、テキスト生成に使用するモデルを指定します。モデルはダウンロード・キャッシュされるため、再利用も簡単です。最後に、プロンプトとしてテキストを渡します。

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

モデルと対話（チャット）する場合も、使用パターンは同じです。唯一の違いは、システムとあなたの間のチャット履歴（`Pipeline`への入力）を構築する必要がある点です。

> [!TIP]
> コマンドラインからモデルと直接チャットすることもできます。
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "あなたは1986年頃のハリウッド映画に出てくる、皮肉屋で機知に富んだロボットです。"},
    {"role": "user", "content": "ねえ、ニューヨークで楽しいことを教えてくれる？"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

下記の例を展開して、`Pipeline`がさまざまなモダリティやタスクでどのように機能するか確認できます。

<details>
<summary>音声認識（ASR）</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>画像分類</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>ビジュアル質問応答</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## なぜTransformersを使うべきか？

1. 使いやすく高性能な最先端モデル
    - 自然言語理解・生成、コンピュータビジョン、音声、ビデオ、マルチモーダルタスクで高いパフォーマンス
    - 研究者・エンジニア・開発者にとって導入障壁が低い
    - 学習すべきユーザー向け抽象化は3クラスのみ
    - 全事前学習済みモデル共通の統一API

1. 計算コスト削減・カーボンフットプリント低減
    - ゼロから学習せずモデルを共有
    - 計算時間・運用コストの削減
    - 全モダリティで100万以上の事前学習済みチェックポイントをもつ多数のモデルアーキテクチャ

1. モデルのライフサイクルに合わせて最適なフレームワークを選択可能
    - 3行で最先端モデルの学習
    - 1つのモデルをPyTorch/JAX/TF2.0間で自由に移動
    - 学習・評価・本番運用ごとに最適なフレームワークを選択

1. モデルやサンプルを簡単にカスタマイズ
    - 各アーキテクチャごとの再現例を用意
    - モデル内部を一貫して公開
    - モデルファイルはライブラリから独立して利用可能

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Transformersを使うべきでない理由

- このライブラリはニューラルネットのモジュール型ツールボックスではありません。モデルファイル内のコードは、意図的に追加抽象化をせず、研究者が余分な抽象化やファイルに入ることなく素早くモデルを反復開発できるようにしています。
- 学習APIはTransformersで提供されるPyTorchモデルと最適に連携するよう設計されています。一般的な機械学習ループには[Accelerate](https://huggingface.co/docs/accelerate)など他ライブラリをお使いください。
- [サンプルスクリプト]((https://github.com/huggingface/transformers/tree/main/examples))はあくまで*例*であり、あなたの用途にそのまま動作するとは限りません。必要に応じてコードを適合させてください。

## Transformers採用事例100選

Transformersは単なる事前学習済みモデル利用ツールではなく、TransformersやHugging Face Hubを中心に多くのプロジェクトが生まれるコミュニティでもあります。Transformersを通じて開発者、研究者、学生、教員、エンジニアなど、誰もが理想のプロジェクトを構築できることを目指しています。

TransformersのGitHubスター10万突破を記念し、[awesome-transformers](./awesome-transformers.md)ページにて、Transformersで構築された素晴らしいプロジェクト100選を紹介しています。

あなたが所有・利用しているプロジェクトで掲載すべきものがあれば、ぜひPRで追加してください！

## モデル例

ほとんどのモデルは[Hubのモデルページ](https://huggingface.co/models)で直接テストできます。

下記でモダリティごとに代表的なユースケース例モデルを展開できます。

<details>
<summary>音声</summary>

- [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)による音声分類
- [Moonshine](https://huggingface.co/UsefulSensors/moonshine)による自動音声認識
- [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)によるキーワードスポッティング
- [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)による音声から音声生成
- [MusicGen](https://huggingface.co/facebook/musicgen-large)によるテキストから音声生成
- [Bark](https://huggingface.co/suno/bark)によるテキストから音声変換

</details>

<details>
<summary>コンピュータビジョン</summary>

- [SAM](https://huggingface.co/facebook/sam-vit-base)による自動マスク生成
- [DepthPro](https://huggingface.co/apple/DepthPro-hf)による深度推定
- [DINO v2](https://huggingface.co/facebook/dinov2-base)による画像分類
- [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)によるキーポイント検出
- [SuperGlue](https://huggingface.co/magic-leap-community/superglue)によるキーポイントマッチング
- [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)による物体検出
- [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)による姿勢推定
- [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)によるユニバーサルセグメンテーション
- [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)による動画分類

</details>

<details>
<summary>マルチモーダル</summary>

- [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)による音声またはテキストからテキスト生成
- [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)によるドキュメント質問応答
- [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)による画像またはテキストからテキスト生成
- [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)による画像キャプショニング
- [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)によるOCRベースの文書理解
- [TAPAS](https://huggingface.co/google/tapas-base)による表質問応答
- [Emu3](https://huggingface.co/BAAI/Emu3-Gen)による統合マルチモーダル理解・生成
- [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)による画像からテキスト生成
- [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)によるビジュアル質問応答
- [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)による視覚的指示表現セグメンテーション

</details>

<details>
<summary>NLP</summary>

- [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)によるマスク単語補完
- [Gemma](https://huggingface.co/google/gemma-2-2b)による固有表現抽出
- [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)による質問応答
- [BART](https://huggingface.co/facebook/bart-large-cnn)による要約
- [T5](https://huggingface.co/google-t5/t5-base)による翻訳
- [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)によるテキスト生成
- [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)によるテキスト分類

</details>

## 論文引用

🤗 Transformersライブラリの引用用[論文](https://www.aclweb.org/anthology/2020.emnlp-demos.6/)があります:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---