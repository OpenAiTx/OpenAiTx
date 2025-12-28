# Mapperatorinator

尝试这个生成模型[这里](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb)，或者MaiMod[这里](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb)。观看视频展示[这里](https://youtu.be/FEr7t1L2EoA)。

Mapperatorinator 是一个多模型框架，使用频谱图输入生成适用于所有游戏模式的全功能osu!谱面，并[辅助谱面制作](#maimod-the-ai-driven-modding-tool)。
该项目的目标是从任何歌曲自动生成可排名的高质量osu!谱面，并具有高度的自定义性。

该项目基于[osuT5](https://github.com/gyataro/osuT5)和[osu-diffusion](https://github.com/OliBomby/osu-diffusion)构建。在开发过程中，我在4060 Ti和租用vast.ai上的4090实例上共耗费约2500小时GPU计算，进行了142次运行。

#### 请负责任地使用此工具。在您的谱面中务必披露AI的使用。

## 安装

以下说明允许您在本地机器上生成谱面，或者您也可以使用[Colab笔记本](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb)在云端运行。

### 1. 克隆仓库

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2.（可选）创建虚拟环境

使用 Python 3.10，较新版本可能与依赖项不兼容。

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. 安装依赖

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone)（适用于NVIDIA GPU）或[ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html)（适用于Linux上的AMD GPU）
- [PyTorch](https://pytorch.org/get-started/locally/)：确保按照入门指南安装支持GPU的 `torch` 和 `torchaudio`。选择之前安装的计算平台版本。

- 以及其余的Python依赖：

```sh
pip install -r requirements.txt
```

## Web 图形界面（推荐）

为了更友好的用户体验，建议使用 Web UI。它提供了一个图形界面，用于配置生成参数、启动进程和监控输出。

### 启动图形界面

在终端中导航到克隆的 `Mapperatorinator` 目录并运行：

```sh
python web-ui.py
```
这将启动一个本地网络服务器并自动在新窗口中打开用户界面。

### 使用图形界面

- **配置：** 使用表单字段和“浏览”按钮设置输入/输出路径。调整生成参数，如游戏模式、难度、风格（年份、制图者ID、描述符）、时间设置、特定功能（击打音效、超级时间控制）等，功能与命令行选项相同。（注：如果提供了 `beatmap_path`，界面将自动根据它确定 `audio_path` 和 `output_path`，因此这些字段可以留空）
- **开始：** 点击“开始推理”按钮开始谱面生成。
- **取消：** 可以使用“取消推理”按钮停止正在进行的进程。
- **打开输出：** 完成后，使用“打开输出文件夹”按钮快速访问生成的文件。

网页界面是对 `inference.py` 脚本的便捷封装。有关高级选项或故障排除，请参考命令行说明。

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## 命令行推理

对于偏好命令行或需要访问高级配置的用户，请按以下步骤操作。**注意：** 若需更简洁的图形界面，请参阅上文的[网页界面（推荐）](#web-ui-recommended)部分。

运行 `inference.py` 并传入参数以生成谱面。为此请使用[Hydra覆盖语法](https://hydra.cc/docs/advanced/override_grammar/basic/)。所有可用参数请参见 `configs/inference_v29.yaml`。

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```
示例：

```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## 交互式命令行界面
对于那些喜欢基于终端的工作流程但希望获得引导式设置的人来说，交互式命令行脚本是网页界面的绝佳替代方案。

### 启动命令行界面
导航到克隆的目录。您可能需要先使脚本可执行。

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### 使用命令行界面
该脚本将通过一系列提示引导您配置所有生成参数，就像网页界面一样。

它使用颜色编码界面以提高清晰度。
它提供了高级多选菜单，您可以使用方向键和空格键选择风格描述词。
在回答完所有问题后，它将显示最终命令以供您审查。
然后您可以确认直接执行，或取消并复制命令以手动使用。

## 生成技巧

- 您可以编辑 `configs/inference_v29.yaml` 并将参数添加到其中，而无需每次在终端中输入。
- 所有可用的描述词可在[这里](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags)找到。
- 始终提供一个介于2007到2023之间的年份参数。如果留空未知，模型可能会生成风格不一致的内容。
- 始终提供难度参数。如果留空未知，模型可能会生成难度不一致的内容。
- 提高 `cfg_scale` 参数可以增强 `mapper_id` 和 `descriptors` 参数的效果。
- 您可以使用 `negative_descriptors` 参数引导模型避开某些风格。此功能仅在 `cfg_scale > 1` 时有效。确保负面描述词数量与正面描述词数量相等。
- 如果您的歌曲风格与期望的谱面风格不匹配，模型可能无法遵循您的指示。例如，很难为一首平静的歌曲生成高SR、高SV的谱面。
- 如果您已经为歌曲完成了时序和Kiai时间，可以将其提供给模型以大幅提升推理速度和准确性：使用 `beatmap_path` 和 `in_context=[TIMING,KIAI]` 参数。
- 若只想重新映射谱面的一部分，请使用 `beatmap_path`、`start_time`、`end_time` 和 `add_to_beatmap=true` 参数。
- 若想生成谱面的嘉宾难度，请使用 `beatmap_path` 和 `in_context=[GD,TIMING,KIAI]` 参数。
- 若想为谱面生成击打音效，请使用 `beatmap_path` 和 `in_context=[NO_HS,TIMING,KIAI]` 参数。
- 若只想为歌曲生成时序，请使用 `super_timing=true` 和 `output_type=[TIMING]` 参数。

## MaiMod：AI驱动的谱面修改工具

MaiMod 是一个用于 osu! 谱面的修改工具，利用 Mapperatorinator 预测来发现其他自动修改工具（如 [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier)）无法检测的潜在错误和不一致。
它可以检测的问题包括：
- 不正确的对齐或节奏模式
- 不准确的时序点
- 不一致的打击物体位置或新组合点
- 奇怪的滑条形状
- 不一致的击打音效或音量

您可以在[这里](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb)试用 MaiMod，或本地运行：
要在本地运行 MaiMod，您需要先安装 Mapperatorinator。然后运行 `mai_mod.py` 脚本，使用 `beatmap_path` 参数指定您的谱面路径。
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
这将把修改建议打印到控制台，然后你可以手动将其应用到你的谱面中。  
建议按时间顺序排列，并按类别分组。  
圆圈中的第一个数值表示“惊讶度”，这是模型对该问题感到意外的程度的度量，因此你可以优先处理最重要的问题。  

模型可能会出错，特别是在低惊讶度的问题上，因此在将建议应用到谱面之前请务必仔细检查。  
主要目的是帮助你缩小潜在问题的搜索范围，这样你就不必手动检查谱面中的每一个击打物件。  

### MaiMod GUI  
要运行 MaiMod Web UI，你需要安装 Mapperatorinator。  
然后，运行 `mai_mod_ui.py` 脚本。这将启动本地 Web 服务器并自动在新窗口中打开 UI：

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## 概述

### 分词

Mapperatorinator 将 osu! 节奏地图转换为一种中间事件表示，可以直接转换为标记并从标记转换回来。
它包括击打物体、击打音效、滑条速度、新组合、定时点、kiai 时间，以及太鼓/mania 滚动速度。

以下是分词过程的一个小示例：

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

为节省词汇量，时间事件被量化到 10 毫秒间隔，位置坐标被量化到 32 像素网格点。

### 模型架构
该模型基本上是基于 [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration) 模型的封装，带有自定义输入嵌入和损失函数。
模型大小为 2.19 亿参数。
该模型被发现比 T5 在此任务上更快且更准确。

模型输入输出的高级概览如下：

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

模型使用 Mel 频谱图帧作为编码器输入，每个输入位置对应一个帧。模型解码器在每一步输出对离散、预定义事件词汇的 softmax 分布。输出是稀疏的，事件只在击打物体发生时需要，而非对每一个音频帧进行标注。

### 多任务训练格式

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

SOS 标记之前有额外的标记以便条件生成。这些标记包括游戏模式、难度、制图者 ID、年份及其他元数据。
训练期间，这些标记没有对应的标签，因此模型不会输出它们。
训练期间还存在随机概率将元数据标记替换为“未知”标记，因此推理时我们可以使用这些“未知”标记来减少需要提供给模型的元数据量。

### 无缝长序列生成

模型的上下文长度为 8.192 秒。显然，这不足以生成完整的节奏地图，因此我们必须将歌曲拆分为多个窗口，并分段生成节奏地图。
为了确保生成的节奏地图在窗口之间没有明显的接缝，我们使用 90% 的重叠并顺序生成窗口。
除第一个窗口外，每个生成窗口的解码器都会预填充上一窗口的标记，预填充长度达生成窗口的 50%。
我们使用logit处理器确保模型无法生成位于生成窗口前50%的时间标记。  
此外，生成窗口的最后40%保留给下一个窗口。任何在该范围内生成的时间标记都被视为EOS标记。  
这确保每个生成的标记至少以之前4秒的标记和3.3秒的未来音频为条件进行生成。  

为了防止长时间生成期间的偏移漂移，训练期间在解码器的时间事件中添加了随机偏移。  
这迫使模型通过监听音频中的起点来校正时间错误，进而实现持续准确的偏移。  

### 使用扩散细化坐标  

解码器生成的位置坐标被量化到32像素的网格点，因此之后我们使用扩散来去噪坐标以获得最终位置。  
为此，我们训练了一个修改版的[osu-diffusion](https://github.com/OliBomby/osu-diffusion)，该版本专门针对噪声调度的最后10%，并接受Mapperatorinator用于条件生成的更高级元数据标记。  

由于Mapperatorinator模型输出滑条的SV，滑条所需的长度固定，不受控制点路径形状影响。  
因此，我们尝试引导扩散过程创建符合所需滑条长度的坐标。  
我们通过在扩散过程的每一步后，根据所需长度和当前控制点路径重新计算滑条结束位置来实现这一点。  
这意味着扩散过程无法直接控制滑条结束位置，但仍能通过改变控制点路径来影响它们。  

### 后处理  

Mapperatorinator进行一些额外的后处理以提升生成谱面的质量：  

- 使用扩散细化位置坐标。  
- 使用模型生成的拍点细分将时间事件重新对齐到最近的拍点。  
- 对近乎完美重叠的位置进行对齐。  
- 将mania列事件转换为X坐标。  
- 为太鼓鼓点生成滑条路径。  
- 修正所需滑条长度与控制点路径长度之间的大幅差异。  

### 超级定时生成器  

超级定时生成器是一种算法，通过对整首歌曲进行20次定时推断并取平均结果，提升生成定时的精度和准确度。  
这对具有变速BPM或BPM变化的歌曲特别有用。结果几乎完美，仅偶尔有部分需要手动调整。  

## 训练  

以下说明将在您的本地机器上创建训练环境。  

### 1. 克隆仓库  

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. 创建数据集

使用 [Mapperator 控制台应用](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset) 创建您自己的数据集。它需要一个 [osu! OAuth 客户端令牌](https://osu.ppy.sh/home/account/edit) 来验证谱面并获取额外的元数据。将数据集放置在与 `Mapperatorinator` 目录相邻的 `datasets` 目录中。

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. （可选）设置 Weight & Biases 进行日志记录
在 [Weight & Biases](https://wandb.ai/site) 上创建一个账户，并从账户设置中获取您的 API 密钥。
然后设置 `WANDB_API_KEY` 环境变量，以便训练过程知道使用该密钥进行日志记录。

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. 创建 Docker 容器
您也可以在虚拟环境中进行训练，但我们建议在 WSL 上使用 Docker 以获得更好的性能。
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. 配置参数并开始训练

所有配置均位于 `./configs/train/default.yaml`。  
确保将 `train_dataset_path` 和 `test_dataset_path` 设置为您的数据集路径，以及训练/测试划分的起止地图集索引。  
该路径是相对于 Docker 容器的本地路径，因此如果您将名为 `cool_dataset` 的数据集放在了 `datasets` 目录下，则路径应为 `/workspace/datasets/cool_dataset`。

建议制作一个自定义配置文件来覆盖默认配置，这样您就有了训练配置的记录，方便复现。

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. LoRA 微调

您还可以使用 [LoRA](https://arxiv.org/abs/2106.09685) 对预训练模型进行微调，以使其适应特定风格或游戏模式。  
为此，请根据您的需求调整 `configs/train/lora.yaml`，然后运行 `lora` 训练配置：  

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```
重要的 LoRA 参数说明：
- `pretrained_path`：用于微调的基础模型路径或 Hugging Face 仓库地址。
- `r`：LoRA 矩阵的秩。数值越大模型容量越高，但内存占用也越多。
- `lora_alpha`：LoRA 更新的缩放因子。
- `total_steps`：训练总步数。根据数据集大小合理调整。
- `enable_lora`：是否使用 LoRA 进行微调，还是使用完整模型微调。

推理时，可以通过 `lora_path` 参数指定要使用的 LoRA 权重。
这可以是本地路径，也可以是 Hugging Face 仓库。

## 参见
- [Mapper 分类器](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## 致谢

特别感谢：
1. [osuT5](https://github.com/gyataro/osuT5) 作者提供的训练代码。
2. Hugging Face 团队提供的[工具](https://huggingface.co/docs/transformers/index)。
3. [Jason Won](https://github.com/jaswon) 和 [Richard Nagyfi](https://github.com/sedthh) 的思想交流。
4. [Marvin](https://github.com/minetoblend) 捐赠的训练积分。
5. osu! 社区提供的谱面。

## 相关工作

1. Syps (Nick Sypteras) 的 [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator)
2. kotritrona、jyvden、Yoyolick (Ryan Zmuda) 的 [osumapper](https://github.com/kotritrona/osumapper)
3. OliBomby (Olivier Schipper)、NiceAesth (Andrei Baciu) 的 [osu-diffusion](https://github.com/OliBomby/osu-diffusion)
4. gyataro (Xiwen Teoh) 的 [osuT5](https://github.com/gyataro/osuT5)
5. sedthh (Richard Nagyfi) 的 [Beat Learning](https://github.com/sedthh/BeatLearning)
6. jaswon (Jason Won) 的 [osu!dreamer](https://github.com/jaswon/osu-dreamer)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---