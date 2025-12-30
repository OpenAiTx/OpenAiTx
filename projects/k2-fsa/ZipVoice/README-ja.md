
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">イタリア語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">ロシア語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">ポルトガル語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">オランダ語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">ポーランド語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">アラビア語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">ペルシャ語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">トルコ語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">ベトナム語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">インドネシア語</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Flow Matchingによる高速・高品質ゼロショット音声合成
</div>

## 概要

ZipVoiceは、フローマッチングに基づく高速かつ高品質なゼロショットTTSモデルシリーズです。

### 1. 主な特徴

- 小型かつ高速：パラメータ数は123Mのみ。

- 高品質な音声クローン：話者類似性、可聴性、自然さで最先端の性能。

- 多言語対応：中国語と英語をサポート。

- マルチモード対応：単一話者および対話音声生成をサポート。

### 2. モデルバリエーション

<table>
  <thead>
    <tr>
      <th>モデル名</th>
      <th>説明</th>
      <th>論文</th>
      <th>デモ</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>中国語と英語のゼロショット単一話者TTSをサポートする基本モデル。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoiceの蒸留バージョンで、性能低下を最小限に抑えつつ速度を向上。</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoice上に構築された対話生成モデルで、単一チャネルの二者会話音声生成が可能。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialogのステレオバリアントであり、各話者が異なるチャンネルに割り当てられる2チャンネル対話生成を実現します。</td>
    </tr>
  </tbody>
</table>

## ニュース

**2025/07/14**: **ZipVoice-Dialog**および**ZipVoice-Dialog-Stereo**、2つの音声対話生成モデルをリリースしました。[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: **OpenDialog**データセット（6.8k時間の音声対話データセット）を公開しました。ダウンロードは[![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog)。詳細は[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)をご覧ください。

**2025/06/16**: **ZipVoice**および**ZipVoice-Distill**をリリースしました。[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## インストール

### 1. ZipVoiceリポジトリをクローンする

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. （オプション）Pythonの仮想環境を作成する


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. 必要なパッケージをインストールする


```bash
pip install -r requirements.txt
```
### 4. 学習または効率的な推論のためにk2をインストールする

**k2は学習に必要**であり、推論も高速化できます。ただし、k2をインストールしなくてもZipVoiceの推論モードは利用可能です。

> **注意:** PyTorchとCUDAのバージョンに合ったk2を必ずインストールしてください。例えば、pytorch 2.5.1とCUDA 12.1を使用している場合、以下のようにk2をインストールできます。


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
詳細については、https://k2-fsa.org/get-started/k2/ を参照してください。
中国本土のユーザーは https://k2-fsa.org/zh-CN/get-started/k2/ を参照してください。

- k2 のインストールを確認するには:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## 使用方法

### 1. 単一話者音声生成

事前学習済みのZipVoiceまたはZipVoice-Distillモデルを使用して単一話者の音声を生成するには、以下のコマンドを使用します（必要なモデルはHuggingFaceからダウンロードされます）:

#### 1.1 単一文の推論


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` は `zipvoice` または `zipvoice_distill` を指定でき、それぞれ蒸留前および蒸留後のモデルです。
- テキストに `<>` や `[]` が現れる場合、それらで囲まれた文字列は特殊トークンとして扱われます。`<>` は中国語のピンインを、`[]` はその他の特殊タグを表します。

#### 1.2 複数文の推論

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- `test.tsv` の各行は `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}` の形式になっています。

### 2. 対話音声生成

#### 2.1 推論コマンド

事前学習済みの ZipVoice-Dialogue または ZipVoice-Dialogue-Stereo モデルを使用して二者間の対話音声を生成するには、以下のコマンドを使用します（必要なモデルは HuggingFace からダウンロードされます）：


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` は `zipvoice_dialog` または `zipvoice_dialog_stereo` であり、
    それぞれモノラルおよびステレオの対話を生成します。

#### 2.2 入力フォーマット

`test.tsv` の各行は、以下のいずれかの形式です：

(1) **マージされたプロンプト形式** では、2人の話者の音声と文字起こしが1つのプロンプトwavファイルにマージされています：

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` は出力される wav ファイルの名前です。
- `prompt_transcription` は会話プロンプトの音声ファイルの書き起こしであり、例: "[S1] こんにちは。[S2] お元気ですか？"
- `prompt_wav` はプロンプト音声ファイルへのパスです。
- `text` は合成するテキストであり、例: "[S1] 元気です。[S2] お名前は？[S1] エリックです。[S2] こんにちは、エリック。"

(2) **分割プロンプト形式** では、2人の話者の音声と書き起こしが別々のファイルに存在します。

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` は出力 wav ファイルの名前です。
- `spk1_prompt_transcription` は最初の話者のプロンプト wav の書き起こし（例: "Hello"）です。
- `spk2_prompt_transcription` は二人目の話者のプロンプト wav の書き起こし（例: "How are you?"）です。
- `spk1_prompt_wav` は最初の話者のプロンプト wav ファイルのパスです。
- `spk2_prompt_wav` は二人目の話者のプロンプト wav ファイルのパスです。
- `text` は合成するテキストです。例: "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 より良い利用のためのガイダンス:

#### 3.1 プロンプトの長さ

推論速度を速めるために、短いプロンプト wav ファイル（例: 単一話者音声生成の場合 3 秒未満、対話音声生成の場合 10 秒未満）を推奨します。非常に長いプロンプトは推論を遅くし、音声品質が劣化します。

#### 3.2 スピード最適化

推論速度が不満な場合、以下の方法で高速化できます:

- **蒸留モデルとステップ数の削減**: 単一話者音声生成モデルでは、デフォルトで `zipvoice` モデルを使用して音声品質を高めています。速度を優先する場合は `zipvoice_distill` に切り替え、`--num-steps` を最小 `4`（デフォルトは 8）まで減らせます。

- **CPU のマルチスレッドによる高速化**: CPU で実行する場合、`--num-thread` パラメータ（例: `--num-thread 4`）を指定してスレッド数を増やし、高速化できます。デフォルトは 1 スレッドです。

- **ONNX による CPU 高速化**: CPU で実行する場合、`zipvoice.bin.infer_zipvoice_onnx` で ONNX モデルを利用すると高速化できます（対話生成モデルはまだ ONNX 非対応）。さらに高速化したい場合は `--onnx-int8 True` を設定し、INT8 量子化 ONNX モデルを使えます。量子化モデルは音声品質の低下を招く場合があります。**GPU で ONNX を使わないでください**。PyTorch より遅くなります。

- **NVIDIA TensorRT による GPU 高速化**: NVIDIA GPU で大幅なパフォーマンス向上のため、まず zipvoice.bin.tensorrt_export を使ってモデルを TensorRT エンジンにエクスポートします。その後、zipvoice.bin.infer_zipvoice で（例: Hugging Face データセット上で）推論を実行します。これにより標準の PyTorch GPU 実装の約 2 倍のスループットが得られます。

#### 3.3 メモリ制御

与えられたテキストは句読点（単一話者音声生成の場合）または話者交代記号（対話音声生成の場合）で分割されます。分割されたテキストはバッチ処理されるため、モデルはほぼ一定のメモリ使用量で任意の長さのテキストを処理できます。`--max-duration` パラメータでメモリ使用量を調整できます。

#### 3.4 "Raw" 評価

デフォルトでは、効率的な推論と高いパフォーマンスのため、入力（プロンプト wav、書き起こし、テキスト）を前処理します。提供された入力をそのまま使いモデルの「生」の性能を評価したい場合（例: 論文の再現）、`--raw-evaluation True` を指定できます。

#### 3.5 短いテキスト

ごく短いテキスト（例: 1～2 語）の音声生成時、生成音声が一部の発音を省略する場合があります。この場合は `--speed 0.3`（0.3 は調整可能値）を指定し、生成音声の長さを延ばすことで解決できます。

#### 3.6 中国語多音字の誤発音修正


私たちは [pypinyin](https://github.com/mozillazg/python-pinyin) を使用して中国語の漢字をピンインに変換しています。ただし、**多音字**（複数の発音を持つ漢字）を時々誤って発音することがあります。

これらの誤発音を手動で修正するには、**修正済みのピンイン**を山括弧 `< >` で囲み、**声調記号**を含めてください。

**例:**

- 元のテキスト: `这把剑长三十公分`
- `长` のピンインを修正: `这把剑<chang2>三十公分`

> **注意:** 複数のピンインを手動で割り当てたい場合は、各ピンインを `<>` で囲んでください。例: `这把<jian4><chang2><san1>十公分`

#### 3.7 生成された音声から長い無音部分を削除する

モデルは生成された音声内の無音部分の位置と長さを自動的に判断します。時折、音声の途中に長い無音が入ることがあります。これを避けたい場合は、`--remove-long-sil` を指定することで、生成された音声の途中の長い無音部分を削除できます（端の無音はデフォルトで削除されます）。

#### 3.8 モデルのダウンロード

事前学習済みモデルのダウンロード時に HuggingFace への接続に問題がある場合は、エンドポイントをミラーサイトに切り替えてください: `export HF_ENDPOINT=https://hf-mirror.com`。

## 独自モデルの学習

学習、ファインチューニング、評価の例については [egs](egs) ディレクトリを参照してください。

## 本番環境へのデプロイ

### NVIDIA Triton GPU ランタイム

高いパフォーマンスとスケーラビリティを備えた本番環境へのデプロイには、TensorRT エンジン最適化、同時リクエスト処理、企業向け gRPC/HTTP API を提供する [Triton Inference Server 連携](runtime/nvidia_triton/) をご確認ください。

### CPU デプロイ

CPU での C++ デプロイソリューションについては [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) をご覧ください。

## 議論 & コミュニケーション

[Github Issues](https://github.com/k2-fsa/ZipVoice/issues) で直接議論できます。

QRコードをスキャンして Wechat グループに参加したり、Wechat 公式アカウントをフォローすることもできます。

| Wechat グループ | Wechat 公式アカウント |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## 引用

```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---