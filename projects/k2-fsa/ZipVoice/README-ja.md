<div align="center">

# ZipVoice⚡

## フローマッチングを用いた高速かつ高品質なゼロショット音声合成
</div>

## 概要

ZipVoiceは、フローマッチングに基づく高速かつ高品質なゼロショットTTSモデルのシリーズです。

### 1. 主な特徴

- 小型かつ高速：パラメータ数はわずか123M。

- 高品質な音声クローン：話者類似度、可聴性、自然さで最先端の性能。

- 多言語対応：中国語と英語をサポート。

- マルチモード対応：単一話者および対話音声生成の両方をサポート。

### 2. モデルの種類

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
      <td>ZipVoiceの蒸留版で、性能劣化を最小限に抑えつつ速度が向上。</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>ZipVoiceを基にした対話生成モデルで、単一チャンネルの二者間音声対話を生成可能。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialogのステレオ版で、各話者が異なるチャンネルに割り当てられた二チャンネル対話生成を実現。</td>
    </tr>
  </tbody>
</table>

## ニュース

**2025/07/14**: 対話音声生成モデルの**ZipVoice-Dialog**および**ZipVoice-Dialog-Stereo**をリリースしました。 [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: 6.8k時間の対話音声データセット**OpenDialog**をリリースしました。[![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog)。詳細は[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)をご覧ください。

**2025/06/16**: **ZipVoice**および**ZipVoice-Distill**をリリースしました。 [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

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
### 4. （オプション）トレーニングや効率的な推論のために k2 をインストールする

k2 はトレーニングに必要であり、推論を高速化できます。それでも、k2 をインストールせずに ZipVoice の推論モードを使用することは可能です。

> **注意：** PyTorch と CUDA のバージョンに合った k2 のバージョンを必ずインストールしてください。例えば、pytorch 2.5.1 と CUDA 12.1 を使用している場合、次のように k2 をインストールできます：


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
<translate-content>
詳細については https://k2-fsa.org/get-started/k2/ を参照してください。  
中国本土のユーザーは https://k2-fsa.org/zh-CN/get-started/k2/ を参照できます。  

## 使い方  

### 1. 単一話者の音声生成  

事前学習済みのZipVoiceまたはZipVoice-Distillモデルを使用して単一話者の音声を生成するには、以下のコマンドを使用してください（必要なモデルはHuggingFaceからダウンロードされます）：  

#### 1.1 単一文の推論  
</translate-content>
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
- `test.tsv` の各行は `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}` の形式です。

### 2. 会話音声生成

#### 2.1 推論コマンド

事前学習済みの ZipVoice-Dialogue または ZipVoice-Dialogue-Stereo モデルを使用して二者間の会話音声を生成するには、以下のコマンドを使用してください（必要なモデルは HuggingFace からダウンロードされます）：


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
- `spk1_prompt_transcription` は第一話者のプロンプトwavの文字起こし、例："Hello"
- `spk2_prompt_transcription` は第二話者のプロンプトwavの文字起こし、例："How are you?"
- `spk1_prompt_wav` は第一話者のプロンプトwavファイルのパスです。
- `spk2_prompt_wav` は第二話者のプロンプトwavファイルのパスです。
- `text` は合成するテキスト、例："[S1] I'm fine. [S2] What's your name?"

### 3. その他の機能

#### 3.1 中国語の多音字の発音訂正

中国語の漢字をピンインに変換するために[pypinyin](https://github.com/mozillazg/python-pinyin)を使用しています。しかし、多音字を誤って発音することがあります。

これらの誤った発音を手動で訂正するには、**正しいピンイン**を山括弧 `< >` で囲み、**声調記号**を含めてください。

**例：**

- 元のテキスト：`这把剑长三十公分`
- `长` のピンインを訂正：`这把剑<chang2>三十公分`

> **注意：** 複数のピンインを手動で指定したい場合は、それぞれのピンインを `<>` で囲んでください。例：`这把<jian4><chang2><san1>十公分`

## 独自モデルのトレーニング

トレーニングおよびファインチューニングの例については [egs](egs) ディレクトリを参照してください。

## 議論とコミュニケーション

[Github Issues](https://github.com/k2-fsa/ZipVoice/issues) で直接議論できます。

また、QRコードをスキャンしてWeChatグループに参加するか、WeChat公式アカウントをフォローしてください。

| Wechatグループ | Wechat公式アカウント |
| -------------- | --------------------- |
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---