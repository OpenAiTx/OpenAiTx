
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
- `wav_name` は出力される wav ファイルの名前です。
- `spk1_prompt_transcription` は最初の話者のプロンプト wav の書き起こし例です。例:「Hello」
- `spk2_prompt_transcription` は2番目の話者のプロンプト wav の書き起こし例です。例:「How are you?」
- `spk1_prompt_wav` は最初の話者のプロンプト wav ファイルのパスです。
- `spk2_prompt_wav` は2番目の話者のプロンプト wav ファイルのパスです。
- `text` は合成するテキストです。例:「[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric.」

### 3 より良い利用のためのガイダンス:

#### 3.1 プロンプトの長さ

推論速度を速くするために、短いプロンプト wav ファイル（例: 単一話者音声生成の場合は3秒未満、対話音声生成の場合は10秒未満）を推奨します。非常に長いプロンプトは推論を遅くし、音声品質を低下させます。

#### 3.2 速度最適化

推論速度が満足できない場合は、以下の方法で高速化できます。

- **蒸留モデルおよびステップ数削減**: 単一話者音声生成モデルでは、デフォルトで `zipvoice` モデルを使用し、高品質な音声生成を実現しています。速度を優先する場合は、`zipvoice_distill` に切り替え、`--num-steps` を最低 `4`（デフォルトは8）まで減らすことができます。

- **CPUのマルチスレッドによる高速化**: CPU上で動作させる場合、`--num-thread` パラメータ（例: `--num-thread 4`）を指定することで、スレッド数を増やし高速化できます。デフォルトは1スレッドです。

- **CPUでONNXによる高速化**: CPU上で動作させる場合、ONNXモデルを `zipvoice.bin.infer_zipvoice_onnx` で利用することで高速化できます（対話生成モデルはまだONNX未対応）。さらに高速化したい場合は、`--onnx-int8 True` を指定して INT8 量子化 ONNX モデルを利用できます。ただし、量子化モデルは音声品質が若干低下します。**GPU上ではONNXを使用しないでください**。GPU上ではPyTorchより遅くなります。

#### 3.3 メモリ制御

指定されたテキストは、句読点（単一話者音声生成の場合）や話者交代記号（対話音声生成の場合）で分割されます。その後、分割されたテキストがバッチ処理されます。これにより、モデルはほぼ一定のメモリ使用量で任意の長さのテキストを処理できます。`--max-duration` パラメータを調整することでメモリ使用量を制御できます。

#### 3.4 「Raw」評価

デフォルトでは、効率的な推論と性能向上のために（プロンプトwav、プロンプト書き起こし、テキスト）を前処理しています。モデルの「生」の性能を厳密に評価したい場合（例: 論文の結果を再現する場合）は、`--raw-evaluation True` を指定できます。

#### 3.5 短いテキスト

非常に短いテキスト（例: 1～2単語）の音声を生成する際、生成音声が一部の発音を省略してしまうことがあります。この問題を解決するには、`--speed 0.3`（0.3は調整可能な値）を指定して、生成音声の持続時間を延長できます。

#### 3.6 中国語の多音字の発音修正

中国語文字をピンインに変換するために [pypinyin](https://github.com/mozillazg/python-pinyin) を使用しています。ただし、**多音字**（複数の読み方がある漢字）の発音を誤ることがあります。


これらの誤発音を手動で修正するには、**修正したピンイン**を山括弧 `< >` で囲み、**声調記号**を含めてください。

**例：**

- 元のテキスト: `这把剑长三十公分`
- `长` のピンインを修正:  `这把剑<chang2>三十公分`

> **注意:** 複数のピンインを手動で割り当てたい場合は、それぞれを `<>` で囲んでください。例: `这把<jian4><chang2><san1>十公分`

#### 3.7 生成音声から長い無音部分を除去

モデルは生成された音声の無音部分の位置と長さを自動的に判定します。時折、音声の途中に長い無音が発生します。これを避けたい場合は、`--remove-long-sil` を指定することで、生成音声の途中の長い無音を除去できます（端の無音はデフォルトで除去されます）。

#### 3.8 モデルのダウンロード

事前学習済みモデルのダウンロード時に HuggingFace への接続がうまくいかない場合は、ミラーサイトへのエンドポイント切り替えをお試しください: `export HF_ENDPOINT=https://hf-mirror.com`

## 独自モデルの学習

トレーニング、ファインチューニング、評価の例については [egs](egs) ディレクトリをご覧ください。

## C++ デプロイ

CPU 上での C++ デプロイソリューションについては [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) をご確認ください。

## ディスカッション & コミュニケーション

[Github Issues](https://github.com/k2-fsa/ZipVoice/issues) で直接ディスカッションできます。

QRコードをスキャンして WeChat グループに参加したり、公式アカウントをフォローすることもできます。

| WeChat グループ | WeChat 公式アカウント |
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---