# SongGen：一个用于文本到歌曲生成的单阶段自回归变换器

🚀🚀🚀 **SongGen：一个用于文本到歌曲生成的单阶段自回归变换器** 官方实现  
<p align="center" style="font-size: 1 em; margin-top: -1em">
<a href="https://scholar.google.com/citations?user=iELd-Q0AAAAJ">刘子涵</a>,  
<a href="https://mark12ding.github.io/">丁爽锐</a>,  
<a href="https://github.com/rookiexiong7/">张智雄</a>, 
<a href="https://lightdxy.github.io/">董晓毅</a>,  
<a href="https://panzhang0212.github.io/">张攀</a>,
<a href="https://yuhangzang.github.io/">臧宇航</a>,  
<a href="https://scholar.google.com/citations?user=sJkqsqkAAAAJ">曹宇航</a>, </br>  
<a href="http://dahua.site/">林大华</a>,  
<a href="https://myownskyw7.github.io/">王佳琦</a> 
</p>

<p align="center" style="font-size: 5 em; margin-top: 0.5em">
<a href="https://arxiv.org/abs/2502.13128"><img src="https://img.shields.io/badge/arXiv-<color>"></a>
<a href="https://github.com/LiuZH-19/SongGen"><img src="https://img.shields.io/badge/Code-red"></a>
<a href="https://liuzh-19.github.io/SongGen/"><img src="https://img.shields.io/badge/Demo-20d67c"></a>
<a href="https://huggingface.co/collections/LiuZH-19/songgen-a-single-stage-auto-regressive-transformer-for-text-6867ec21169d808034f6d252">
    <img src="https://img.shields.io/badge/HF-Collection-yellow"></a>
</p>





## 📜 新闻
🚀 [2025/7/4] 我们发布了训练代码及详细的[训练指南](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md) 。

🚀 [2025/6/30] MusicCaps 测试集现已在 [Huggingface🤗](https://huggingface.co/datasets/LiuZH-19/MusicCaps_Test_Song) 上可用于文本到歌曲的评估。

🚀 [2025/6/27] 我们发布了 SongGen 交错模式（视听）检查点，位于 [Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_interleaving_A_V)。

🎉 [2025/5/1] SongGen 被 ICML 2025 接收！

🚀 [2025/3/18] 我们发布了 SongGen 混合专业版检查点，位于 [Huggingface🤗](https://huggingface.co/LiuZH-19/SongGen_mixed_pro)。

🚀 [2025/2/19] 论文([paper](https://arxiv.org/abs/2502.13128)) 和 [演示页面](https://liuzh-19.github.io/SongGen/) 正式发布！

## 💡 亮点
- 🔥 我们推出了 SongGen，一款用于**文本到歌曲**生成的**单阶段**自回归变换器，支持通过歌词、描述文本及可选的参考声音实现多样化控制。
- 🔥 SongGen 支持**混合**及**双轨模式**以满足不同需求。我们的实验为两种模式的优化提供了**宝贵见解**。
- 🔥 通过发布**模型权重**、**代码**、**标注数据**及**预处理流程**，我们旨在为未来的歌曲生成研究建立一个简单而有效的基线。
<!-- <img align="center" src="https://raw.githubusercontent.com/LiuZH-19/SongGen/master/assets/imgs/motivation1.jpg" style="  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 50%;" /> -->

## 👨‍💻 待办事项
- [ ] 发布标注数据和预处理流程
- [x] 发布 Musiccaps 测试集
- [x] 发布 SongGen 训练代码
- [x] 发布 SongGen（交错视听）检查点
- [x] 发布 SongGen 混合专业版检查点
- [x] 发布 SongGen 推理代码 
- [x] SongGen 演示

## 🛠️ 使用说明

### 1. 安装环境和依赖
```bash
git clone https://github.com/LiuZH-19/SongGen.git
cd SongGen
# We recommend using conda to create a new environment.
conda create -n songgen_env python=3.9.18 
conda activate songgen_env
# Install CUDA >= 11.8 and PyTorch, e.g.,
pip install torch==2.3.0 torchvision==0.18.0 torchaudio==2.3.0 --index-url https://download.pytorch.org/whl/cu118
pip install flash-attn==2.6.1 --no-build-isolation
```
仅在推理模式下使用 SongGen，请使用以下命令安装：
```bash
pip install -e .
```
### 2. 下载 xcodec

从 [🤗](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/
https://huggingface.co/ZhenYe234/xcodec/blob/main/xcodec_hubert_general_audio_v2.pth) 下载 X-Codec 检查点，并将其放置在以下目录：SongGen/songgen/xcodec_wrapper/xcodec_infer/ckpts/general_more

```
xcodec_infer
    ├── ckpts
    │   └── general_more
    │       ├── config_hubert_general.yaml
    │       └── xcodec_hubert_general_audio_v2.pth

```

### 3. 运行推理

#### (1). 混合专业模式

```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenMixedForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_mixed_pro" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenMixedForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=separate) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )
audio_arr = generation.cpu().numpy().squeeze()
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```



#### (2). Interleaving A-V  (Dual-track mode)
```python
import torch
import os
from songgen import (
    VoiceBpeTokenizer,
    SongGenDualTrackForConditionalGeneration,
    SongGenProcessor
)
import soundfile as sf

ckpt_path = "LiuZH-19/SongGen_interleaving_A_V" # Path to the pretrained model
device = "cuda:0" if torch.cuda.is_available() else "cpu"
model = SongGenDualTrackForConditionalGeneration.from_pretrained(
    ckpt_path,
    attn_implementation='sdpa').to(device)
processor = SongGenProcessor(ckpt_path, device)

# Define input text and lyrics
lyrics = "..." # The lyrics text
text = "..." # The music description text
ref_voice_path = 'path/to/your/reference_audio.wav' # Path to reference audio, optional
separate= True # Whether to separate the vocal track from the reference voice audio

model_inputs = processor(text=text, lyrics=lyrics, ref_voice_path=ref_voice_path, separate=True) 
generation = model.generate(**model_inputs,
                do_sample=True,
            )

acc_array = generation[0].cpu().numpy()
vocal_array = generation[1].cpu().numpy()
min_len =min(vocal_array.shape[0], acc_array.shape[0])
acc_array = acc_array[:min_len]
vocal_array = vocal_array[:min_len]
audio_arr = vocal_array + acc_array
sf.write("songgen_out.wav", audio_arr, model.config.sampling_rate)
```
### 4. 训练

[训练文件夹](./training) 包含了训练或微调您自己的 SongGen 模型的所有信息。请参阅[训练指南](https://raw.githubusercontent.com/LiuZH-19/SongGen/master/./training/README.md)以获取逐步说明。



## ❤️ 致谢
本库基于多个开源巨头的工作，感谢他们提供的工具！

特别感谢：

- [Parler-tts](https://github.com/huggingface/parler-tts)：我们构建的代码库基础。
- [X-Codec](https://github.com/zhenye234/xcodec)：我们研究中使用的音频编解码器。
- [lp-music-caps](https://github.com/seungheondoh/lp-music-caps)：一个生成音乐字幕的项目。

我们衷心感谢一路以来得到的支持。

## ☎️ 限制与未来工作

这是一个专注于**文本到歌曲**生成的**研究工作**。由于当前训练数据集的限制，我们的模型目前仅限于生成最长30秒的英文歌曲。
然而，尽管仅用**2千小时**数据和**13亿**参数模型训练，我们的方法已展示出强大的有效性和生成连贯富有表现力歌曲的潜力。我们相信，扩大数据量和模型规模将进一步提升歌词对齐和音乐性。
话虽如此，扩展数据集既耗时又具挑战性。我们欢迎合作和讨论，共同探索改进模型和扩展其能力的新途径。
如有任何疑问或潜在合作意向，欢迎联系：刘子涵 (liuzihan@pjlab.org.cn) 和 王佳琦 (wangjiaqi@pjlab.org.cn)。

## ✒️ 引用
如果我们的工作对您的研究有所帮助，欢迎点赞 ⭐ 并引用 📝

```bibtex
@misc{liu2025songgen,
      title={SongGen: A Single Stage Auto-regressive Transformer for Text-to-Song Generation}, 
      author={Zihan Liu and Shuangrui Ding and Zhixiong Zhang and Xiaoyi Dong and Pan Zhang and Yuhang Zang and Yuhang Cao and Dahua Lin and Jiaqi Wang},
      year={2025},
      eprint={2502.13128},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2502.13128}, 
}

```







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---