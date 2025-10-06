
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Indonesian</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching
</div>

## Overview

ZipVoice is a series of fast and high-quality zero-shot TTS models based on flow matching.

### 1. Key features

- Small and fast: only 123M parameters.

- High-quality voice cloning: state-of-the-art performance in speaker similarity, intelligibility, and naturalness.

- Multi-lingual: support Chinese and English.

- Multi-mode: support both single-speaker and dialogue speech generation.

### 2. Model variants

<table>
  <thead>
    <tr>
      <th>Model Name</th>
      <th>Description</th>
      <th>Paper</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>The basic model supporting zero-shot single-speaker TTS in both Chinese and English.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>The distilled version of ZipVoice, featuring improved speed with minimal performance degradation.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>A dialogue generation model built on ZipVoice, capable of generating single-channel two-party spoken dialogues.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>The stereo version of ZipVoice-Dialog, supporting two-channel dialogue generation with each speaker assigned to a separate channel.</td>
    </tr>
  </tbody>
</table>

## News

**2025/07/14**: **ZipVoice-Dialog** and **ZipVoice-Dialog-Stereo**, two spoken dialogue generation models, are released. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: The **OpenDialog** dataset, a 6.8k-hour spoken dialogue dataset, is released. Download at [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). See details at [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** and **ZipVoice-Distill** are released. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Installation

### 1. Clone the ZipVoice repository

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Optional) Create a Python virtual environment


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Install the required packages


```bash
pip install -r requirements.txt
```
### 4. Install k2 for training or efficient inference

**k2 is necessary for training** and can speed up inference. Nevertheless, you can still use the inference mode of ZipVoice without installing k2.

> **Note:**  Make sure to install the k2 version that matches your PyTorch and CUDA version. For example, if you are using pytorch 2.5.1 and CUDA 12.1, you can install k2 as follows:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Please refer to https://k2-fsa.org/get-started/k2/ for details.
Users in China mainland can refer to https://k2-fsa.org/zh-CN/get-started/k2/.

- To check the k2 installation:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## Usage

### 1. Single-speaker speech generation

To generate single-speaker speech with our pre-trained ZipVoice or ZipVoice-Distill models, use the following commands (Required models will be downloaded from HuggingFace):

#### 1.1 Inference of a single sentence


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` can be either `zipvoice` or `zipvoice_distill`, representing the models before and after distillation, respectively.
- If `<>` or `[]` appear in the text, the strings enclosed within them will be treated as special tokens. `<>` represents Chinese pinyin, and `[]` represents other special tags.

#### 1.2 Inference for a list of sentences

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Each line of `test.tsv` is in the format of `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Dialogue speech generation

#### 2.1 Inference command

To generate two-party spoken dialogues with our pre-trained ZipVoice-Dialogue or ZipVoice-Dialogue-Stereo models, use the following commands (Required models will be downloaded from HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` can be `zipvoice_dialog` or `zipvoice_dialog_stereo`,
    which generate mono and stereo dialogues, respectively.

#### 2.2 Input formats

Each line of `test.tsv` is in one of the following formats:

(1) **Merged prompt format** where the audios and transcriptions of two speakers prompts are merged into one prompt wav file:


```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` is the name of the output wav file.
- `prompt_transcription` is the transcription of the conversational prompt wav, e.g, "[S1] Hello. [S2] How are you?"
- `prompt_wav` is the path to the prompt wav.
- `text` is the text to be synthesized, e.g. "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

(2) **Splitted prompt format** where the audios and transcriptions of two speakers exist in separate files:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```

- `wav_name` is the name of the output wav file.
- `spk1_prompt_transcription` is the transcription of the first speaker's prompt wav, e.g., "Hello"
- `spk2_prompt_transcription` is the transcription of the second speaker's prompt wav, e.g., "How are you?"
- `spk1_prompt_wav` is the path to the first speaker's prompt wav file.
- `spk2_prompt_wav` is the path to the second speaker's prompt wav file.
- `text` is the text to be synthesized, e.g., "[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric."

### 3 Guidance for better usage:

#### 3.1 Prompt length

We recommend a short prompt wav file (e.g., less than 3 seconds for single-speaker speech generation, less than 10 seconds for dialogue speech generation) for faster inference speed. A very long prompt will slow down inference and degrade speech quality.

#### 3.2 Speed optimization

If the inference speed is unsatisfactory, you can speed it up as follows:

- **Distill model and fewer steps**: For the single-speaker speech generation model, we use the `zipvoice` model by default for better speech quality. If faster speed is a priority, you can switch to `zipvoice_distill` and reduce the `--num-steps` to as low as `4` (default is 8).

- **CPU speedup with multi-threading**: When running on CPU, you can pass the `--num-thread` parameter (e.g., `--num-thread 4`) to increase the number of threads for faster speed. We use 1 thread by default.

- **CPU speedup with ONNX**: When running on CPU, you can use ONNX models with `zipvoice.bin.infer_zipvoice_onnx` for faster speed (ONNX for dialogue generation models is not supported yet). For even faster speed, you can further set `--onnx-int8 True` to use an INT8-quantized ONNX model. Note that the quantized model will cause some speech quality degradation. **Do not use ONNX on GPU**, as it is slower than PyTorch on GPU.

#### 3.3 Memory control

The given text will be split into chunks based on punctuation (for single-speaker speech generation) or speaker-turn symbol (for dialogue speech generation). Then, the chunked texts will be processed in batches. Therefore, the model can process arbitrarily long text with almost constant memory usage. You can control memory usage by adjusting the `--max-duration` parameter.

#### 3.4 "Raw" evaluation

By default, we preprocess inputs (prompt wav, prompt transcription, and text) for efficient inference and better performance. If you want to evaluate the model's "raw" performance using the exact provided inputs (e.g., to reproduce the results in our paper), you can pass `--raw-evaluation True`.

#### 3.5 Short text

When generating speech for very short texts (e.g., one or two words), the generated speech may sometimes omit certain pronunciations. To resolve this issue, you can pass `--speed 0.3` (where 0.3 is a tunable value) to extend the duration of the generated speech.

#### 3.6 Correcting mispronounced Chinese polyphonic characters

We use [pypinyin](https://github.com/mozillazg/python-pinyin) to convert Chinese characters to pinyin. However, it can occasionally mispronounce **polyphonic characters** (多音字).

To manually correct these mispronunciations, enclose the **corrected pinyin** in angle brackets `< >` and include the **tone mark**.

**Example:**

- Original text: `这把剑长三十公分`
- Correct the pinyin of `长`:  `这把剑<chang2>三十公分`

> **Note:** If you want to manually assign multiple pinyins, enclose each pinyin with `<>`, e.g., `这把<jian4><chang2><san1>十公分`

#### 3.7 Remove long silences from the generated speech

The model will automatically determine the positions and lengths of silences in the generated speech. Sometimes, it may produce long silences in the middle of the speech. If you do not want this, you can pass `--remove-long-sil` to remove long silences in the middle of the generated speech (edge silences will be removed by default).

#### 3.8 Model downloading

If you encounter difficulties connecting to HuggingFace when downloading the pre-trained models, try switching the endpoint to the mirror site: `export HF_ENDPOINT=https://hf-mirror.com`.

## Train Your Own Model

See the [egs](egs) directory for training, fine-tuning, and evaluation examples.

## C++ Deployment

Check [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) for the C++ deployment solution on CPU.

## Discussion & Communication

You can directly discuss on [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

You can also scan the QR code to join our WeChat group or follow our WeChat official account.

| WeChat Group | WeChat Official Account |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Citation

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