
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">簡體中文</a>
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

## 極速且高品質的零樣本文本轉語音，採用流匹配技術
</div>

## 概述

ZipVoice 是一系列基於流匹配的快速且高品質零樣本 TTS 模型。

### 1. 主要特點

- 小巧且快速：僅有 123M 參數。

- 高品質語音克隆：在說話人相似度、可懂度和自然度上均達到最先進水平。

- 多語言：支援中文和英文。

- 多模式：支援單一說話人及對話語音生成。

### 2. 模型變體

<table>
  <thead>
    <tr>
      <th>模型名稱</th>
      <th>描述</th>
      <th>論文</th>
      <th>演示</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>基礎模型，支援中英文零樣本單說話人 TTS。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice 的蒸餾版本，速度更快且性能損失極小。</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>基於 ZipVoice 的對話生成模型，可生成單聲道雙方語音對話。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog 的立體聲變體，支援雙聲道對話生成，讓每位說話者分配至不同的聲道。</td>
    </tr>
  </tbody>
</table>

## 最新消息

**2025/07/14**：**ZipVoice-Dialog** 和 **ZipVoice-Dialog-Stereo** 兩款語音對話生成模型正式釋出。[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**：**OpenDialog** 資料集，包含 6.8k 小時語音對話資料，正式釋出。下載連結：[![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog)。詳情請見 [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)。

**2025/06/16**：**ZipVoice** 和 **ZipVoice-Distill** 模型正式釋出。[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## 安裝

### 1. 複製 ZipVoice 原始碼庫

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2.（可選）建立 Python 虛擬環境


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. 安裝所需的套件


```bash
pip install -r requirements.txt
```
### 4. 安裝 k2 以進行訓練或高效推理

**k2 是訓練所必需的**，並且可以加速推理。然而，即使不安裝 k2，你仍然可以使用 ZipVoice 的推理模式。

> **注意：** 請確保安裝與你的 PyTorch 和 CUDA 版本相符的 k2 版本。例如，如果你使用的是 pytorch 2.5.1 和 CUDA 12.1，你可以按照以下方式安裝 k2：


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
請參閱 https://k2-fsa.org/get-started/k2/ 以了解詳情。
中國大陸用戶可參考 https://k2-fsa.org/zh-CN/get-started/k2/。

- 檢查 k2 是否安裝：


```bash
python3 -c "import k2; print(k2.__file__)"
```
## 使用方式

### 1. 單一說話者語音生成

要使用我們預訓練的 ZipVoice 或 ZipVoice-Distill 模型生成單一說話者語音，請使用以下指令（所需模型將自 HuggingFace 下載）：

#### 1.1 單句推論


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` 可以是 `zipvoice` 或 `zipvoice_distill`，分別代表蒸餾前和蒸餾後的模型。
- 若文字中出現 `<>` 或 `[]`，則被括號包住的字串將被視為特殊標記。`<>` 表示中文拼音，`[]` 表示其他特殊標籤。

#### 1.2 一系列句子的推論

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- `test.tsv` 的每一行格式為 `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`。

### 2. 對話語音生成

#### 2.1 推論指令

要使用我們預訓練的 ZipVoice-Dialogue 或 ZipVoice-Dialogue-Stereo 模型生成雙方對話語音，請使用以下指令（所需模型將從 HuggingFace 下載）：


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` 可以是 `zipvoice_dialog` 或 `zipvoice_dialog_stereo`，
    分別產生單聲道和立體聲對話。

#### 2.2 輸入格式

`test.tsv` 的每一行都是以下格式之一：

(1) **合併提示格式**，其中兩位說話者的提示音訊和轉錄被合併為一個提示 wav 檔案：

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` 是輸出 wav 檔案的名稱。
- `prompt_transcription` 是對話提示 wav 的文字轉錄，例如：「[S1] 你好。 [S2] 你好嗎？」
- `prompt_wav` 是提示 wav 的路徑。
- `text` 是要合成的文字，例如：「[S1] 我很好。 [S2] 你叫什麼名字？ [S1] 我叫 Eric。 [S2] 嗨 Eric。」

(2) **分割提示格式**，其中兩位說話者的音檔和文字轉錄分別存在不同檔案中：

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` 是輸出 wav 檔案的名稱。
- `spk1_prompt_transcription` 是第一位說話者的提示 wav 音檔的文字稿，例如 "Hello"。
- `spk2_prompt_transcription` 是第二位說話者的提示 wav 音檔的文字稿，例如 "How are you?"。
- `spk1_prompt_wav` 是第一位說話者的提示 wav 音檔路徑。
- `spk2_prompt_wav` 是第二位說話者的提示 wav 音檔路徑。
- `text` 是要合成的文字，例如 "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 使用指引：

#### 3.1 提示長度

我們建議提示 wav 檔案較短（例如，單人語音生成時少於 3 秒，對話語音生成時少於 10 秒），以加快推論速度。過長的提示會降低推論速度並影響語音品質。

#### 3.2 速度優化

若推論速度不理想，可按以下方式加快：

- **模型蒸餾與減少步數**：單人語音生成模型預設使用 `zipvoice` 模型以提高語音品質。如需優先速度，可切換至 `zipvoice_distill` 並將 `--num-steps` 降至最低 `4`（預設為 8）。

- **CPU 多線程加速**：在 CPU 上運行時，可傳入 `--num-thread` 參數（如 `--num-thread 4`）以增加線程數提高速度。預設為 1 線程。

- **CPU 使用 ONNX 加速**：在 CPU 上運行時，可使用 ONNX 模型搭配 `zipvoice.bin.infer_zipvoice_onnx` 以加快速度（目前對話生成模型尚不支援 ONNX）。如需更快速度，可再設 `--onnx-int8 True` 使用 INT8 量化 ONNX 模型。請注意，量化模型會導致語音品質略微下降。**不要在 GPU 上使用 ONNX**，因為在 GPU 上會比 PyTorch 慢。

#### 3.3 記憶體控制

輸入的文字將根據標點符號（單人語音生成）或說話者切換符號（對話語音生成）分割為片段。這些片段會以批次處理，因此模型可用幾乎固定的記憶體處理任意長度的文字。可藉由調整 `--max-duration` 參數來控制記憶體用量。

#### 3.4 "原始"評估

預設會對輸入（提示 wav、提示文字稿及合成文字）進行預處理，以提高推論效率和效能。如需以完全原始輸入（例如重現論文結果）評估模型，可傳入 `--raw-evaluation True`。

#### 3.5 短文字

當為非常短的文字（如一兩個字）生成語音時，生成的語音有時會省略部分發音。為解決此問題，可傳入 `--speed 0.3`（0.3 為可調值）以延長生成語音的時長。

#### 3.6 修正中文多音字發音錯誤

我們使用 [pypinyin](https://github.com/mozillazg/python-pinyin) 轉換中文為拼音。然而，偶爾會錯誤讀出**多音字**。


要手動修正這些發音錯誤，請將**修正後的拼音**用尖括號 `< >` 括起，並包含**聲調標記**。

**範例：**

- 原文：`这把剑长三十公分`
- 修正 `长` 的拼音：`这把剑<chang2>三十公分`

> **注意：** 如果要手動指定多個拼音，請將每個拼音分別用 `<>` 括起，例如：`这把<jian4><chang2><san1>十公分`

#### 3.7 移除生成語音中的長靜音

模型會自動判斷生成語音中的靜音位置和長度。有時語音中間會出現長靜音。如果不希望如此，可以傳遞 `--remove-long-sil` 來移除生成語音中間的長靜音（邊緣靜音會預設移除）。

#### 3.8 模型下載

如果在下載預訓練模型時無法連接 HuggingFace，請嘗試將端點切換至鏡像網站：`export HF_ENDPOINT=https://hf-mirror.com`。

## 訓練您自己的模型

請參閱 [egs](egs) 目錄以獲得訓練、微調和評估的範例。

## C++ 部署

請參考 [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) 以獲得 CPU 上的 C++ 部署解決方案。

## 討論與交流

您可以直接在 [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) 上討論。

您也可以掃描二維碼加入我們的微信交流群或關注我們的微信公眾號。

| 微信交流群 | 微信公眾號 |
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