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
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Flow Matchingによる高速・高品質ゼロショット音声合成
</div>

## 概要

ZipVoiceは、flow matchingに基づく高速かつ高品質なゼロショットTTS（音声合成）モデルのシリーズです。

### 1. 主な特徴

- 小型かつ高速：パラメータ数わずか123M。

- 高品質な音声クローン：話者類似性・明瞭性・自然さで最先端の性能。

- 多言語対応：中国語および英語をサポート。

- マルチモード：単一話者・対話音声生成の両方に対応。

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
      <td>中国語および英語でゼロショット単一話者TTSをサポートする基本モデル。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoiceの蒸留版。速度が向上し、性能劣化は最小限。</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoiceを基盤とした対話生成モデル。単一チャンネルで2者対話音声を生成可能。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialogのステレオ版。2チャンネル出力で、各話者を別チャンネルに割り当てた対話生成が可能。</td>
    </tr>
  </tbody>
</table>

## ニュース

**2025/07/14**: **ZipVoice-Dialog**および**ZipVoice-Dialog-Stereo**の2つの対話音声生成モデルを公開。[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: 6.8k時間の対話音声データセット**OpenDialog**を公開。ダウンロードは[![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog)、[![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog)から。詳細は[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)。

**2025/06/16**: **ZipVoice**および**ZipVoice-Distill**を公開。[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## インストール

### 1. ZipVoiceリポジトリのクローン


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


```
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
- `--model-name` は `zipvoice` または `zipvoice_distill` で、前者が蒸留前のモデル、後者が蒸留後のモデルです。  
- テキスト内に `<>` または `[]` が出現した場合、それらで囲まれた文字列は特殊トークンとして扱われます。`<>` は中国語のピンインを示し、`[]` はその他の特殊タグを示します。  
- `zipvoice.bin.infer_zipvoice_onnx` を使用すると、CPU上でONNXモデルをより高速に実行可能です。  

> **注意：** HuggingFaceへの接続に問題がある場合は、以下を試してください：  
> ```bash  
> export HF_ENDPOINT=https://hf-mirror.com  
> ```  

#### 1.2 文のリストの推論  


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
- `wav_name` は出力されるwavファイルの名前です。
- `prompt_transcription` は会話プロンプトwavの文字起こしで、例: "[S1] こんにちは。 [S2] お元気ですか？"
- `prompt_wav` はプロンプトwavへのパスです。
- `text` は合成されるテキストで、例: "[S1] 元気です。 [S2] あなたの名前は？"

(2) **分割されたプロンプト形式** では、2人の話者の音声と文字起こしが別々のファイルに存在します:


```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}'
```
- `wav_name` は出力されるwavファイルの名前です。
- `spk1_prompt_transcription` は最初の話者のプロンプトwavの書き起こしです。例:「Hello」
- `spk2_prompt_transcription` は2番目の話者のプロンプトwavの書き起こしです。例:「How are you?」
- `spk1_prompt_wav` は最初の話者のプロンプトwavファイルのパスです。
- `spk2_prompt_wav` は2番目の話者のプロンプトwavファイルのパスです。
- `text` は合成するテキストです。例:「[S1] I'm fine. [S2] What's your name?」

### 3. その他の機能

#### 3.1 中国語多音字の誤発音修正

中国語の文字をピンインに変換するために [pypinyin](https://github.com/mozillazg/python-pinyin) を使用しています。ただし、**多音字**（多音節文字）を誤って発音する場合があります。

これらの誤発音を手動で修正するには、**修正したピンイン**を山括弧 `< >` で囲み、**声調記号**も含めます。

**例:**

- 元のテキスト: `这把剑长三十公分`
- `长` のピンインを修正:  `这把剑<chang2>三十公分`

> **注意:** 複数のピンインを手動で割り当てたい場合は、それぞれのピンインを `<>` で囲みます。例: `这把<jian4><chang2><san1>十公分`

## 独自モデルの学習

トレーニング、ファインチューニング、および評価の例については [egs](egs) ディレクトリを参照してください。

## 議論とコミュニケーション

[Github Issues](https://github.com/k2-fsa/ZipVoice/issues) で直接議論できます。

また、QRコードをスキャンしてWeChatグループに参加したり、WeChat公式アカウントをフォローしたりできます。

| Wechatグループ | Wechat公式アカウント |
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
<translate-content></translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---