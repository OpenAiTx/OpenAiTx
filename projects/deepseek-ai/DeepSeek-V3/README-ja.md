<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## 目次

1. [はじめに](#1-はじめに)
2. [モデル概要](#2-モデル概要)
3. [モデルダウンロード](#3-モデルダウンロード)
4. [評価結果](#4-評価結果)
5. [チャットサイト & API プラットフォーム](#5-チャットサイト--api-プラットフォーム)
6. [ローカルでの実行方法](#6-ローカルでの実行方法)
7. [ライセンス](#7-ライセンス)
8. [引用方法](#8-引用方法)
9. [お問い合わせ](#9-お問い合わせ)


## 1. はじめに

DeepSeek-V3は、合計671Bパラメータの強力なMixture-of-Experts（MoE）言語モデルであり、各トークンに37Bが活性化されます。
効率的な推論とコスト効率の高い学習を実現するために、DeepSeek-V3はDeepSeek-V2で十分に検証されたMulti-head Latent Attention（MLA）およびDeepSeekMoEアーキテクチャを採用しています。
さらに、DeepSeek-V3はロードバランシングのための補助損失不要戦略を開拓し、より高い性能のためにマルチトークン予測学習目標を設定しています。
DeepSeek-V3は、14.8兆個の多様かつ高品質なトークンで事前学習され、その後、能力を最大限に引き出すために教師ありファインチューニングと強化学習ステージを経ています。
包括的な評価により、DeepSeek-V3は他のオープンソースモデルを上回り、リーディングなクローズドソースモデルに匹敵する性能を示すことが明らかになりました。
優れた性能にもかかわらず、DeepSeek-V3の全学習にはわずか2.788M H800 GPU時間しか必要ありません。
さらに、学習プロセスは非常に安定しています。
学習期間中、回復不可能な損失スパイクやロールバックは一度も発生しませんでした。
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. モデル概要

---

**アーキテクチャ: 革新的なロードバランシング戦略と学習目標**

- DeepSeek-V2の効率的なアーキテクチャを基に、ロードバランシングのための補助損失不要戦略を先駆的に導入し、ロードバランシングを強制することで生じる性能低下を最小限に抑えます。
- さらに、マルチトークン予測（MTP）目標を検討し、モデル性能に有益であることを証明しました。
    また、推論高速化のためのスペキュレイティブデコーディングにも利用可能です。

---

**事前学習: 究極の学習効率を目指して**

- FP8混合精度学習フレームワークを設計し、極めて大規模なモデルにおけるFP8学習の実現可能性と有効性を初めて実証しました。
- アルゴリズム・フレームワーク・ハードウェアの協調設計により、ノード間MoE学習の通信ボトルネックを克服し、計算と通信のほぼ完全なオーバーラップを達成しました。
  これにより学習効率が大幅に向上し、コストも削減され、追加オーバーヘッドなしにモデル規模をさらに拡大できます。
- わずか2.664M H800 GPU時間という経済的コストで、14.8TトークンでDeepSeek-V3の事前学習を完了し、現時点で最強のオープンソースベースモデルを生み出しました。事前学習後の追加学習ステージには0.1M GPU時間のみを要します。

---

**事後学習: DeepSeek-R1からの知識蒸留**

-   長いChain-of-Thought（CoT）モデル、特にDeepSeek R1シリーズの1つから標準LLM（特にDeepSeek-V3）へ推論能力を蒸留する革新的な手法を導入しました。このパイプラインはR1の検証・反省パターンをDeepSeek-V3に巧みに組み込み、その推論性能を顕著に向上させます。同時に、DeepSeek-V3の出力スタイルや長さも制御可能です。

---


## 3. モデルダウンロード

<div align="center">

| **モデル** | **合計パラメータ数** | **活性化パラメータ数** | **コンテキスト長** | **ダウンロード** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> Hugging Face上のDeepSeek-V3モデルの総サイズは685Bであり、671Bのメインモデル重みと14Bのマルチトークン予測（MTP）モジュール重みが含まれます。

最適な性能と柔軟性を確保するため、私たちはオープンソースコミュニティやハードウェアベンダーと連携し、ローカルでモデルを実行する複数の方法を提供しています。手順についてはセクション6: [ローカルでの実行方法](#6-ローカルでの実行方法)をご覧ください。

開発者向けに、メインモデル重みおよびマルチトークン予測（MTP）モジュールの詳細は [README_WEIGHTS.md](./README_WEIGHTS.md) を参照してください。なお、MTPサポートは現在コミュニティで活発に開発中です。ご意見・ご協力を歓迎します。

## 4. 評価結果
### ベースモデル
#### 標準ベンチマーク

<div align="center">


|  | ベンチマーク（指標） | #ショット | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | アーキテクチャ | - | MoE | Dense | Dense | MoE |
| | 活性化パラメータ数 | - | 21B | 72B | 405B | 37B |
| | 合計パラメータ数 | - | 236B | 72B | 405B | 671B |
| 英語 | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| コード | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| 数学 | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| 中国語 | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| 多言語 | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> 最良の結果は太字で示しています。スコアの差が0.3以内の場合は同等と見なします。DeepSeek-V3はほとんどのベンチマーク、特に数学・コーディングタスクで最高性能です。
> 詳細な評価については論文をご覧ください。

#### コンテキストウィンドウ
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

``Needle In A Haystack``（NIAH）テストでの評価結果です。DeepSeek-V3は**128K**までの全コンテキスト長で高い性能を発揮します。

### チャットモデル
#### 標準ベンチマーク（67B以上のモデル）
<div align="center">

| | **ベンチマーク（指標）** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | アーキテクチャ | MoE | MoE | Dense | Dense | - | - | MoE |
| | 活性化パラメータ数 | 21B | 21B | 72B | 405B | - | - | 37B |
| | 合計パラメータ数 | 236B | 236B | 72B | 405B | - | - | 671B |
| 英語 | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| コード | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| 数学 | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| 中国語 | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> すべてのモデルは出力長を8Kに制限した設定で評価されています。サンプル数が1000未満のベンチマークは、温度パラメータを変えて複数回テストし、堅牢な最終結果を得ています。DeepSeek-V3は最高性能のオープンソースモデルであり、最先端クローズドソースモデルとも競合する性能を示します。


####  オープンエンド生成評価

<div align="center">



| モデル | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> 英語のオープンエンド会話評価です。AlpacaEval 2.0では長さ制御付きの勝率を指標としています。


## 5. チャットサイト & API プラットフォーム
DeepSeek-V3とチャットするには公式サイト [chat.deepseek.com](https://chat.deepseek.com/sign_in) をご利用ください。

また、DeepSeekプラットフォームではOpenAI互換APIも提供しています：[platform.deepseek.com](https://platform.deepseek.com/)

## 6. ローカルでの実行方法

DeepSeek-V3は以下のハードウェアおよびオープンソースコミュニティソフトウェアを利用してローカルにデプロイできます：

1. **DeepSeek-Infer Demo**: FP8およびBF16推論用のシンプルかつ軽量なデモを提供します。
2. **SGLang**: BF16/FP8推論モードでDeepSeek-V3モデルを完全サポートし、Multi-Token Predictionは[近日公開](https://github.com/sgl-project/sglang/issues/2591)予定です。
3. **LMDeploy**: ローカル・クラウド両対応で効率的なFP8/BF16推論を実現します。
4. **TensorRT-LLM**: 現在BF16およびINT4/8量子化をサポート、FP8サポートは近日中に追加予定です。
5. **vLLM**: DeepSeek-V3モデルをFP8/BF16モードでテンソル並列・パイプライン並列に対応します。
6. **LightLLM**: 単一ノード・複数ノードの効率的なFP8/BF16デプロイをサポートします。
7. **AMD GPU**: SGLangを利用してAMD GPU上でBF16/FP8モードでDeepSeek-V3を実行可能です。
8. **Huawei Ascend NPU**: Huawei AscendデバイスでDeepSeek-V3の実行に対応します。

本フレームワークはFP8学習をネイティブに採用しているため、FP8重みのみを提供しています。BF16重みが必要な場合は、変換スクリプトで変換してください。

FP8重みをBF16に変換する例：

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Hugging Face Transformersは現時点で直接サポートされていません。

### 6.1 DeepSeek-Infer Demoでの推論（例）

#### システム要件

> [!NOTE] 
> LinuxとPython 3.10のみ対応。MacやWindowsは非対応です。

依存ライブラリ:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### モデル重み・デモコード準備

まずDeepSeek-V3 GitHubリポジトリをクローンします：

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

`inference` フォルダに移動し、`requirements.txt`記載の依存パッケージをインストールします。`conda`や`uv`等の仮想環境管理ツール推奨。

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

Hugging Faceからモデル重みをダウンロードし、`/path/to/DeepSeek-V3`に配置してください。

#### モデル重み変換

Hugging Faceのモデル重みを特定フォーマットに変換します：

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### 実行

DeepSeek-V3とチャットするには：

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

ファイルに対するバッチ推論：

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 SGLangでの推論（推奨）

[SGLang](https://github.com/sgl-project/sglang) は現在 [MLA最適化](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations)、[DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models)、FP8（W8A8）、FP8 KVキャッシュ、Torch Compileをサポートしており、オープンソースフレームワーク中で最先端のレイテンシ・スループット性能を提供します。

特に、[SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1)は**NVIDIAおよびAMD GPU**の両方でDeepSeek-V3を完全サポートし、高い汎用性と堅牢性を実現しています。

SGLangはまた[マルチノードテンソル並列](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208)にも対応し、複数のネットワーク接続されたマシンでの実行も可能です。

Multi-Token Prediction（MTP）は開発中で、進捗は[最適化計画](https://github.com/sgl-project/sglang/issues/2591)をご覧ください。

SGLangチームの起動手順はこちら：https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 LMDeployでの推論（推奨）
[LMDeploy](https://github.com/InternLM/lmdeploy)は大規模言語モデル向けに設計された柔軟かつ高性能な推論・サービングフレームワークで、DeepSeek-V3もサポートしています。オフラインパイプライン処理とオンライン展開の両方に対応し、PyTorchベースのワークフローとシームレスに統合できます。

LMDeployによるDeepSeek-V3の実行手順は以下を参照ください：https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 TRT-LLMでの推論（推奨）

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM)はDeepSeek-V3モデルに対応し、BF16やINT4/INT8などの精度オプションを提供しています。FP8サポートは近日公開予定です。DeepSeek-V3用のカスタムブランチはこちら：https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3

### 6.5 vLLMでの推論（推奨）

[vLLM](https://github.com/vllm-project/vllm) v0.6.6はNVIDIA/AMD両GPU上でFP8/BF16モードのDeepSeek-V3推論に対応しています。標準技術に加え、_パイプライン並列_を実現しており、複数マシンでの分散実行が可能です。詳細は[vLLMガイド](https://docs.vllm.ai/en/latest/serving/distributed_serving.html)を参照してください。[強化計画](https://github.com/vllm-project/vllm/issues/11539)もご覧ください。

### 6.6 LightLLMでの推論（推奨）

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1はDeepSeek-R1（FP8/BF16）の単一・複数マシンでのテンソル並列展開をサポートし、混合精度・多様な量子化モードにも対応しています。詳細は[LightLLMガイド](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html)をご覧ください。さらにLightLLMはDeepSeek-V2のPD-分離展開に対応、DeepSeek-V3への実装も進行中です。

### 6.7 AMD GPUでの推論推奨

AMDチームとの協力により、SGLangを使ったAMD GPUのDay-Oneサポートが実現し、FP8/BF16どちらも完全対応です。詳細は[SGLangガイド](#63-inference-with-lmdeploy-recommended)をご確認ください。

### 6.8 Huawei Ascend NPUでの推論推奨
Huawei Ascendコミュニティの [MindIE](https://www.hiascend.com/en/software/mindie) フレームワークがDeepSeek-V3のBF16版に対応済みです。Ascend NPUでの手順はこちらの[ガイド](https://modelers.cn/models/MindIE/deepseekv3)を参照ください。


## 7. ライセンス
このコードリポジトリは[MITライセンス](LICENSE-CODE)のもとで公開されています。DeepSeek-V3 Base/Chatモデルの利用は[モデルライセンス](LICENSE-MODEL)に準拠します。DeepSeek-V3シリーズ（BaseおよびChatを含む）は商用利用が可能です。

## 8. 引用方法
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. お問い合わせ
ご質問がある場合は、issueの提出または [service@deepseek.com](service@deepseek.com) までご連絡ください。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---