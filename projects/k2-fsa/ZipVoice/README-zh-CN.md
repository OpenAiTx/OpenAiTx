
<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

## 基于流匹配的快速高质量零样本文本转语音
</div>

## 概述

ZipVoice 是一系列基于流匹配的快速高质量零样本语音合成（TTS）模型。

### 1. 主要特性

- 小巧且快速：仅有 123M 参数。

- 高质量语音克隆：在说话人相似性、可懂度和自然度方面达到业界领先性能。

- 多语言支持：支持中文和英文。

- 多模式支持：支持单说话人和对话语音生成。

### 2. 模型变体

<table>
  <thead>
    <tr>
      <th>模型名称</th>
      <th>描述</th>
      <th>论文</th>
      <th>演示</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>基础模型，支持中英文零样本单说话人语音合成。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>ZipVoice 的蒸馏版本，速度更快且性能损失极小。</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>基于 ZipVoice 构建的对话生成模型，可生成单声道双方对话语音。</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>ZipVoice-Dialog 的立体声版本，实现双声道对话生成，每位说话人分配到一个独立声道。</td>
    </tr>
  </tbody>
</table>

## 新闻

**2025/07/14**：**ZipVoice-Dialog** 和 **ZipVoice-Dialog-Stereo** 两个语音对话生成模型已发布。[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**：**OpenDialog** 数据集（6.8k 小时语音对话数据集）已发布。下载地址：[![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog)。详情请查阅 [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318)。

**2025/06/16**：**ZipVoice** 和 **ZipVoice-Distill** 已发布。[![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## 安装

### 1. 克隆 ZipVoice 仓库

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2.（可选）创建一个Python虚拟环境


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. 安装所需的软件包


```bash
pip install -r requirements.txt
```
### 4. 安装 k2 以进行训练或高效推理

**k2 是训练所必需的**，并且可以加快推理速度。不过，即使不安装 k2，你仍然可以使用 ZipVoice 的推理模式。

> **注意：** 请确保安装与你的 PyTorch 和 CUDA 版本相匹配的 k2 版本。例如，如果你使用的是 pytorch 2.5.1 和 CUDA 12.1，可以按如下方式安装 k2：


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
请参阅 https://k2-fsa.org/get-started/k2/ 获取详细信息。
中国大陆用户可参阅 https://k2-fsa.org/zh-CN/get-started/k2/。

- 检查 k2 是否已安装：


```bash
python3 -c "import k2; print(k2.__file__)"
```
## 用法

### 1. 单说话人语音生成

要使用我们预训练的 ZipVoice 或 ZipVoice-Distill 模型生成单说话人语音，请使用以下命令（所需模型将从 HuggingFace 下载）：

#### 1.1 单句推理


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` 可以是 `zipvoice` 或 `zipvoice_distill`，分别表示蒸馏前和蒸馏后的模型。
- 如果文本中出现 `<>` 或 `[]`，被其包围的字符串将被视为特殊标记。`<>` 表示中文拼音，`[]` 表示其他特殊标签。

#### 1.2 一组句子的推理

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- `test.tsv` 的每一行格式为 `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`。

### 2. 对话语音生成

#### 2.1 推理命令

要使用我们预训练的 ZipVoice-Dialogue 或 ZipVoice-Dialogue-Stereo 模型生成双人对话语音，请使用以下命令（所需模型将从 HuggingFace 下载）：


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` 可以是 `zipvoice_dialog` 或 `zipvoice_dialog_stereo`，  
    分别生成单声道和立体声对话。  

#### 2.2 输入格式  

`test.tsv` 的每一行格式为以下之一：  

(1) **合并提示格式**，其中两个说话人的音频和转录内容合并为一个提示 wav 文件：

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` 是输出 wav 文件的名称。
- `prompt_transcription` 是对话提示 wav 的转录文本，例如，“[S1] 你好。[S2] 你好吗？”
- `prompt_wav` 是提示 wav 的路径。
- `text` 是要合成的文本，例如，“[S1] 我很好。[S2] 你叫什么名字？[S1] 我叫 Eric。[S2] 嗨，Eric。”

(2) **分割提示格式**，即两位说话人的音频和转录分别存在于不同文件中：

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` 是输出 wav 文件的名称。
- `spk1_prompt_transcription` 是第一位说话者提示音频的转录内容，例如，“Hello”。
- `spk2_prompt_transcription` 是第二位说话者提示音频的转录内容，例如，“How are you?”。
- `spk1_prompt_wav` 是第一位说话者提示音频文件的路径。
- `spk2_prompt_wav` 是第二位说话者提示音频文件的路径。
- `text` 是需要合成的文本，例如，“[S1] I'm fine. [S2] What's your name? [S1] I'm Eric. [S2] Hi Eric.”

### 3 更好使用的指导：

#### 3.1 提示音频长度

我们推荐使用较短的提示音频文件（如单说话人语音生成时小于 3 秒，对话语音生成时小于 10 秒），以加快推理速度。提示过长会降低推理速度并影响语音质量。

#### 3.2 速度优化

如果推理速度不理想，可以按如下方式提升：

- **模型蒸馏与减少步数**：单说话人语音生成模型默认使用 `zipvoice` 模型以获得更好的语音质量。如果优先考虑速度，可以切换到 `zipvoice_distill` 并将 `--num-steps` 降低至最低 `4`（默认 8）。
  
- **CPU 多线程加速**：在 CPU 上运行时，可以通过 `--num-thread` 参数（如 `--num-thread 4`）增加线程数提升速度。默认使用 1 个线程。

- **CPU 使用 ONNX 加速**：在 CPU 上运行时，可以用 ONNX 模型通过 `zipvoice.bin.infer_zipvoice_onnx` 加快速度（暂未支持对话生成模型的 ONNX）。如需更快速度，还可设置 `--onnx-int8 True` 使用 INT8 量化 ONNX 模型。注意，量化模型会有一定语音质量下降。**不要在 GPU 上使用 ONNX**，因其在 GPU 上比 PyTorch 慢。

#### 3.3 内存控制

输入文本会根据标点（单说话人语音生成）或说话人切换符号（对话语音生成）拆分为多个片段。然后分批处理这些文本块。因此，模型能以几乎恒定的内存处理任意长度文本。可通过调整 `--max-duration` 参数控制内存使用。

#### 3.4 “原始”评估

默认情况下，我们会对输入（提示音频、提示转录与文本）进行预处理，以提升推理效率和表现。如果希望用精确的原始输入评估模型（如复现论文结果），可传递 `--raw-evaluation True`。

#### 3.5 短文本

对于极短文本（如一两个词）生成语音时，生成语音可能偶尔会遗漏某些发音。为解决此问题，可传递 `--speed 0.3`（0.3 为可调值）以延长生成语音的持续时间。

#### 3.6 修正中文多音字发音错误

我们使用 [pypinyin](https://github.com/mozillazg/python-pinyin) 将中文字符转换为拼音。但偶尔会错误发音 **多音字**。


要手动纠正这些发音错误，请将**纠正后的拼音**用尖括号 `< >` 括起来，并包含**声调标记**。

**示例：**

- 原文：`这把剑长三十公分`
- 纠正`长`的拼音：`这把剑<chang2>三十公分`

> **注意：** 如果需要手动指定多个拼音，请用`<>`分别括起来，例如：`这把<jian4><chang2><san1>十公分`

#### 3.7 从生成的语音中移除长静音

模型会自动检测生成语音中的静音位置和时长。语音中间有时会出现较长的静音。如果你不需要，可以传递`--remove-long-sil`参数来移除语音中间的长静音（边缘静音默认会被移除）。

#### 3.8 模型下载

如果在下载预训练模型时连接 HuggingFace 有困难，请尝试切换端点到镜像站点：`export HF_ENDPOINT=https://hf-mirror.com`。

## 训练你自己的模型

请参阅 [egs](egs) 目录，获取训练、微调和评估的示例。

## C++ 部署

请查看 [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498)，了解在 CPU 上进行 C++ 部署的解决方案。

## 讨论与交流

你可以在 [Github Issues](https://github.com/k2-fsa/ZipVoice/issues) 上直接讨论。

你也可以扫码加入微信群或关注我们的微信公众号。

| 微信群 | 微信公众号 |
| ------ | ---------- |
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