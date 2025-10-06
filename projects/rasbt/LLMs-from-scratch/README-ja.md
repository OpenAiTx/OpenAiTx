# 大規模言語モデルを構築する（ゼロから）

このリポジトリには、GPTに似た大規模言語モデル（LLM）を開発、事前学習、微調整するためのコードが含まれており、書籍『大規模言語モデルを構築する（ゼロから）』(https://amzn.to/4fqvn0D) の公式コードリポジトリです。

<br>
<br>

<a href="https://amzn.to/4fqvn0D"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/cover.jpg?123" width="250px"></a>

<br>

『*大規模言語モデルを構築する（ゼロから）*』(http://mng.bz/orYv) では、大規模言語モデル（LLM）が内部でどのように動作しているかを、基礎から段階的にコードを書きながら学び、理解します。この本では、自分自身のLLMを作成する過程を、明確なテキスト、図解、例を用いて説明します。

本書で説明する教育目的の小規模ながら実用的なモデルのトレーニング・開発方法は、ChatGPTの背後にあるような大規模基盤モデルの作成手法を模したものです。さらに、本書には大規模な事前学習済みモデルの重みを読み込み、微調整するためのコードも含まれています。

- 公式の [ソースコードリポジトリ](https://github.com/rasbt/LLMs-from-scratch) へのリンク
- [出版社Manningの書籍ページ](http://mng.bz/orYv)
- [Amazon.comの書籍ページ](https://www.amazon.com/gp/product/1633437167)
- ISBN 9781633437166

<a href="http://mng.bz/orYv#reviews"><img src="https://sebastianraschka.com//images/LLMs-from-scratch-images/other/reviews.png" width="220px"></a>


<br>
<br>

このリポジトリのコピーをダウンロードするには、[Download ZIP](https://github.com/rasbt/LLMs-from-scratch/archive/refs/heads/main.zip) ボタンをクリックするか、ターミナルで以下のコマンドを実行してください：

```bash
git clone --depth 1 https://github.com/rasbt/LLMs-from-scratch.git
```

<br>

(If you downloaded the code bundle from the Manning website, please consider visiting the official code repository on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) for the latest updates.)

<br>
<br>


# Table of Contents

Please note that this `README.md` file is a Markdown (`.md`) file. If you have downloaded this code bundle from the Manning website and are viewing it on your local computer, I recommend using a Markdown editor or previewer for proper viewing. If you haven't installed a Markdown editor yet, [Ghostwriter](https://ghostwriter.kde.org) is a good free option.

You can alternatively view this and other files on GitHub at [https://github.com/rasbt/LLMs-from-scratch](https://github.com/rasbt/LLMs-from-scratch) in your browser, which renders Markdown automatically.

<br>
<br>


> **Tip:**
> If you're seeking guidance on installing Python and Python packages and setting up your code environment, I suggest reading the [README.md](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/setup/README.md) file located in the [setup](setup) directory.

<br>
<br>

[![Code tests Linux](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-linux-uv.yml)
[![Code tests Windows](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-windows-uv-pip.yml)
[![Code tests macOS](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml/badge.svg)](https://github.com/rasbt/LLMs-from-scratch/actions/workflows/basic-tests-macos-uv.yml)




<br>

| Chapter Title                                              | Main Code (for Quick Access)                                                                                                    | All Code + Supplementary      |
|------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------|-------------------------------|
| [Setup recommendations](setup)                             | -                                                                                                                               | -                             |
| Ch 1: Understanding Large Language Models                  | No code                                                                                                                         | -                             |
| Ch 2: Working with Text Data                               | - [ch02.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/ch02.ipynb)<br/>- [dataloader.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/dataloader.ipynb) (summary)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/01_main-chapter-code/exercise-solutions.ipynb)               | [./ch02](./ch02)            |
| Ch 3: Coding Attention Mechanisms                          | - [ch03.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/ch03.ipynb)<br/>- [multihead-attention.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/multihead-attention.ipynb) (summary) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/01_main-chapter-code/exercise-solutions.ipynb)| [./ch03](./ch03)             |
| Ch 4: Implementing a GPT Model from Scratch                | - [ch04.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/ch04.ipynb)<br/>- [gpt.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/gpt.py) (概要)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/01_main-chapter-code/exercise-solutions.ipynb) | [./ch04](./ch04)           |
| Ch 5: Pretraining on Unlabeled Data                        | - [ch05.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/ch05.ipynb)<br/>- [gpt_train.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_train.py) (概要) <br/>- [gpt_generate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/gpt_generate.py) (概要) <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/01_main-chapter-code/exercise-solutions.ipynb) | [./ch05](./ch05)              |
| Ch 6: Finetuning for Text Classification                   | - [ch06.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/ch06.ipynb)  <br/>- [gpt_class_finetune.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/gpt_class_finetune.py)  <br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch06/01_main-chapter-code/exercise-solutions.ipynb) | [./ch06](./ch06)              |
| Ch 7: Finetuning to Follow Instructions                    | - [ch07.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ch07.ipynb)<br/>- [gpt_instruction_finetuning.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/gpt_instruction_finetuning.py) (概要)<br/>- [ollama_evaluate.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/ollama_evaluate.py) (概要)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/01_main-chapter-code/exercise-solutions.ipynb) | [./ch07](./ch07)  |
| Appendix A: Introduction to PyTorch                        | - [code-part1.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part1.ipynb)<br/>- [code-part2.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/code-part2.ipynb)<br/>- [DDP-script.py](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/DDP-script.py)<br/>- [exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-A/01_main-chapter-code/exercise-solutions.ipynb) | [./appendix-A](./appendix-A) |
| Appendix B: References and Further Reading                 | コードなし                                                                                                                      | -                             |
| Appendix C: Exercise Solutions                             | コードなし                                                                                                                      | -                             |
| Appendix D: Adding Bells and Whistles to the Training Loop | - [appendix-D.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-D/01_main-chapter-code/appendix-D.ipynb)                                                          | [./appendix-D](./appendix-D)  |
| Appendix E: Parameter-efficient Finetuning with LoRA       | - [appendix-E.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/appendix-E/01_main-chapter-code/appendix-E.ipynb)                                                          | [./appendix-E](./appendix-E) |

<br>
&nbsp;

以下のメンタルモデルは、本書で扱った内容を要約しています。

<img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/mental-model.jpg" width="650px">


<br>
&nbsp;

## 前提条件

最も重要な前提条件は、Pythonプログラミングの強固な基礎です。
この知識があれば、LLMの魅力的な世界を探求し、
本書で提示される概念やコード例を理解するための準備が整います。

深層ニューラルネットワークの経験がある場合、LLMはこれらのアーキテクチャに基づいて構築されているため、
特定の概念がより馴染みやすいかもしれません。

本書はPyTorchを使用して外部のLLMライブラリを使わずにコードをゼロから実装しています。
PyTorchの熟練は必須ではありませんが、PyTorchの基本に慣れていると確実に役立ちます。
PyTorchが初めての場合は、付録Aで簡潔なPyTorch入門を提供しています。
あるいは、私の書籍[PyTorch in One Hour: From Tensors to Training Neural Networks on Multiple GPUs](https://sebastianraschka.com/teaching/pytorch-1h/)も、必須事項の学習に役立つでしょう。



<br>
&nbsp;

## ハードウェア要件

本書の主要章のコードは、一般的なノートパソコン上で合理的な時間内に実行できるよう設計されており、特殊なハードウェアは必要ありません。
このアプローチにより、広範な読者が教材に取り組むことが可能です。
さらに、コードはGPUが利用可能な場合には自動的にそれを使用します。（追加の推奨事項については、[setup](https://github.com/rasbt/LLMs-from-scratch/blob/main/setup/README.md)ドキュメントをご参照ください。）
&nbsp;
## ビデオコース

[17時間15分のコンパニオンビデオコース](https://www.manning.com/livevideo/master-and-build-large-language-models)では、本の各章を通してコードを書いていきます。コースは本の構成と対応した章とセクションに整理されており、本の代替としても、また補完的なコード実践リソースとしても利用できます。

<a href="https://www.manning.com/livevideo/master-and-build-large-language-models"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/video-screenshot.webp?123" width="350px"></a>


&nbsp;


## コンパニオンブック / 続編

[*Build A Reasoning Model (From Scratch)*](https://mng.bz/lZ5B)は単独の書籍ですが、*Build A Large Language Model (From Scratch)*の続編と考えられます。

事前学習済みモデルから始め、推論時のスケーリング、強化学習、蒸留などの異なる推論アプローチを実装し、モデルの推論能力を向上させます。

*Build A Large Language Model (From Scratch)*と同様に、[*Build A Reasoning Model (From Scratch)*](https://mng.bz/lZ5B)もこれらの手法をスクラッチから実装する実践的アプローチを取っています。

<a href="https://mng.bz/lZ5B"><img src="https://sebastianraschka.com/images/reasoning-from-scratch-images/cover.webp?123" width="120px"></a>

- Amazonリンク（未定）
- [Manningリンク](https://mng.bz/lZ5B)
- [GitHubリポジトリ](https://github.com/rasbt/reasoning-from-scratch)

<br>

&nbsp;
## 演習問題

本の各章には複数の演習問題が含まれています。解答は付録Cにまとめられており、対応するコードノートブックはこのリポジトリの各章フォルダにあります（例: [./ch02/01_main-chapter-code/exercise-solutions.ipynb](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/./ch02/01_main-chapter-code/exercise-solutions.ipynb)）。

コード演習に加えて、Manningのウェブサイトから無料でダウンロード可能な170ページのPDF、[Test Yourself On Build a Large Language Model (From Scratch)](https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch)もあります。各章につき約30問のクイズ問題と解答が含まれており、理解度を試すのに役立ちます。

<a href="https://www.manning.com/books/test-yourself-on-build-a-large-language-model-from-scratch"><img src="https://sebastianraschka.com/images/LLMs-from-scratch-images/test-yourself-cover.jpg?123" width="150px"></a>



&nbsp;

## ボーナスマテリアル

いくつかのフォルダには、興味のある読者向けのオプション資料としてボーナスが含まれています：

- **セットアップ**
  - [Python セットアップのヒント](setup/01_optional-python-setup-preferences)
  - [本書で使用する Python パッケージとライブラリのインストール](setup/02_installing-python-libraries)
  - [Docker 環境セットアップガイド](setup/03_optional-docker-environment)
- **第2章：テキストデータの取り扱い**
  - [一から作るバイトペアエンコーディング（BPE）トークナイザー](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch02/05_bpe-from-scratch/bpe-from-scratch.ipynb)
  - [さまざまなバイトペアエンコーディング（BPE）実装の比較](ch02/02_bonus_bytepair-encoder)
  - [埋め込み層と線形層の違いの理解](ch02/03_bonus_embedding-vs-matmul)
  - [シンプルな数値でのデータローダー直感](ch02/04_bonus_dataloader-intuition)
- **第3章：アテンションメカニズムのコーディング**
  - [効率的なマルチヘッドアテンション実装の比較](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/02_bonus_efficient-multihead-attention/mha-implementations.ipynb)
  - [PyTorch バッファの理解](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch03/03_understanding-buffers/understanding-buffers.ipynb)
- **第4章：GPTモデルのスクラッチ実装**
  - [FLOPS 分析](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch04/02_performance-analysis/flops-analysis.ipynb)
  - [KV キャッシュ](ch04/03_kv-cache)
- **第5章：ラベルなしデータでの事前学習：**
  - [代替の重み読み込み方法](ch05/02_alternative_weight_loading/)
  - [プロジェクト・グーテンベルクデータセットでの GPT 事前学習](ch05/03_bonus_pretraining_on_gutenberg)
  - [トレーニングループに装飾を追加する](ch05/04_learning_rate_schedulers)
  - [事前学習用ハイパーパラメータの最適化](ch05/05_bonus_hparam_tuning)
  - [事前学習済み LLM と対話するためのユーザーインターフェース構築](ch05/06_user_interface)
  - [GPT から Llama への変換](ch05/07_gpt_to_llama)
  - [Llama 3.2 をスクラッチで](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/07_gpt_to_llama/standalone-llama32.ipynb)
  - [Qwen3 Dense と Mixture-of-Experts (MoE) をスクラッチで](ch05/11_qwen3/)
  - [Gemma 3 をスクラッチで](ch05/12_gemma3/)
  - [メモリ効率の良いモデル重みの読み込み](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/08_memory_efficient_weight_loading/memory-efficient-state-dict.ipynb)
  - [Tiktoken BPE トークナイザーに新しいトークンを追加](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch05/09_extending-tokenizers/extend-tiktoken.ipynb)
  - [より速い LLM トレーニングのための PyTorch パフォーマンスヒント](ch05/10_llm-training-speed)
- **第6章：分類のためのファインチューニング**
  - [異なる層のファインチューニングや大きなモデルの追加実験](ch06/02_bonus_additional-experiments)
  - [50k IMDb 映画レビュー・データセットでの異なるモデルのファインチューニング](ch06/03_bonus_imdb-classification)
  - [GPT ベースのスパム分類器と対話するためのユーザーインターフェース構築](ch06/04_user_interface)
- **第7章：指示に従うためのファインチューニング**
  - [近似重複の検出や受動態エントリー作成のためのデータセットユーティリティ](ch07/02_dataset-utilities)
  - [OpenAI API と Ollama を使った指示応答の評価](ch07/03_model-evaluation)
  - [指示ファインチューニング用データセットの生成](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/llama3-ollama.ipynb)
  - [命令微調整用データセットの改善](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/05_dataset-generation/reflection-gpt4.ipynb)
  - [Llama 3.1 70B と Ollama を使った嗜好データセットの生成](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/create-preference-data-ollama.ipynb)
  - [LLMアラインメントのための直接嗜好最適化（DPO）](https://raw.githubusercontent.com/rasbt/LLMs-from-scratch/main/ch07/04_preference-tuning-with-dpo/dpo-from-scratch.ipynb)
  - [命令微調整済みGPTモデルと対話するためのユーザーインターフェース構築](ch07/06_user_interface)

<br>
&nbsp;

## 質問、フィードバック、およびこのリポジトリへの貢献


あらゆる種類のフィードバックを歓迎します。フィードバックは主に[Manningフォーラム](https://livebook.manning.com/forum?product=raschka&page=1)や[GitHubディスカッション](https://github.com/rasbt/LLMs-from-scratch/discussions)を通じて共有してください。同様に、質問がある場合やアイデアを他の方と共有したい場合も、遠慮なくフォーラムに投稿してください。

このリポジトリは印刷書籍に対応するコードを含んでいるため、現在のところメインチャプターのコード内容を拡張する貢献は受け付けていません。内容が物理的な書籍と異なるものになるためです。内容を一貫して保つことは、すべての方にスムーズな体験を提供するために重要です。


&nbsp;
## 引用

この書籍やコードが研究に役立った場合は、引用をご検討ください。

シカゴスタイルの引用例:

> Raschka, Sebastian. *Build A Large Language Model (From Scratch)*. Manning, 2024. ISBN: 978-1633437166.

BibTeXエントリ:

```
@book{build-llms-from-scratch-book,
  author       = {Sebastian Raschka},
  title        = {Build A Large Language Model (From Scratch)},
  publisher    = {Manning},
  year         = {2024},
  isbn         = {978-1633437166},
  url          = {https://www.manning.com/books/build-a-large-language-model-from-scratch},
  github       = {https://github.com/rasbt/LLMs-from-scratch}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-05

---