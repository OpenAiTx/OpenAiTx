# 地表光谱的时间嵌入用于地球表示与分析（TESSERA）[CVPR2026]
<div align="center">
    <a href="#readme-top">
        <img src="https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/banner.png" alt="Banner">
    </a>
    <br />
    <p align="center">
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">报告错误 🛠️</a> &nbsp;&nbsp;•&nbsp;&nbsp;
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">请求功能 💡</a>
    </p>
</div>

<!--  ![Version](https://img.shields.io/badge/version-alpha-red) -->
![PyPI version](https://img.shields.io/pypi/v/geotessera?label=PyPI%20version&color=blue)
![License](https://img.shields.io/badge/License-MIT-blue.svg)


# 目录

  - 了解 TESSERA
      - [介绍](#introduction)
      - [论文](#Papers)
      - [播客](https://www.satellite-image-deep-learning.com/p/tessera-a-temporal-foundation-model)
      - [演示](#presentations)
      - [许可证](#License)
  - 使用 TESSERA
      - [可接受使用政策](#AUP)
      - [访问预计算嵌入](#global-embeddings-access)
      - [创建您自己的嵌入](#creating-your-own-embeddings)
      - [下游任务](#downstream-tasks)
      - [TESSERA 用户组](#tessera-users-group)
  - 额外信息
      - [团队](#team)
      - [联系方式](#contact)
      - [引用](#citation)
      - [致谢](#acknowledgments)
      - [星标历史](#star-history)

# 了解 TESSERA
## 介绍
卫星遥感支持广泛的下游应用，包括栖息地映射、碳核算以及保护和可持续土地利用策略。然而，卫星时间序列数据庞大且常受云层干扰，使用起来具有挑战性：科学界提取可操作见解的能力往往受限于标注训练数据集的稀缺性以及处理时序数据的计算负担。我们工作的关键见解，来源于 [Dr. Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/)，是通过使用 [Barlow Twins](https://proceedings.mlr.press/v139/zbontar21a/zbontar21a.pdf) 强制对齐来自卫星时间序列两个无云随机样本的自编码器嵌入，可以得到一个代表整个时间序列（包括缺失观测）的嵌入。

这一思想是 TESSERA 的核心，TESSERA 是一个开放的基础模型，能在全球范围内以10米分辨率保存每像素的光谱-时间信号，形成128维潜在表示。它使用自监督学习来总结海量的地球观测数据。我们将其与五个多样化下游任务中的最先进任务特定模型及其他基础模型进行比较，发现 TESSERA 表现接近或优于这些基线。通过保存传统方法中通常丢失的时间物候信号，TESSERA 能够深入洞察生态系统动态、农业食品系统和环境变化检测。此外，我们的开源实现支持可重复性和可扩展性，而隐私保护设计允许研究人员保持数据主权。

据我们所知，TESSERA 在易用性、规模和精度方面前所未有：没有其他基础模型能提供分析即用的输出，且开放、提供基于像素级光谱-时间特征的全球年度10米分辨率覆盖。

以下是 TESSERA 表示图的部分可视化结果（使用前三个通道作为RGB）：

![repr_demo](https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/repr_demo.png)

## 论文
以下是与 TESSERA 相关的出版物和预印本，按时间顺序列出：
* Lisaius, M. C., Blake, A., Keshav, S., & Atzberger, C. (2024). 使用 Barlow Twins 从受云影响的遥感时间序列创建表示。IEEE 应用地球观测与遥感精选期刊, 17, 13162–13168。IEEE 应用地球观测与遥感精选期刊。https://doi.org/10.1109/JSTARS.2024.3426044

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav (2025), [TESSERA：地球表面光谱的时间嵌入表示与分析](https://arxiv.org/abs/2506.20380)，待发表，CVPR 2026。ArXiv 重印本。https://arxiv.org/abs/2506.20380

* Lisaius, M. C., Blake, A., Atzberger, C., & Keshav, S. (2026). 迈向改进的作物类型分类：适合小田块的紧凑嵌入方法。接受发表于2026年国际摄影测量与遥感学会会议论文集。国际摄影测量与遥感学会。

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav, (2026) [TESSERA 地理空间基础模型在多样环境映射任务中的应用](http://ssrn.com/abstract=6142416)，SSRN 预印本。http://ssrn.com/abstract=6142416
  
* Young, R., & Keshav, S. (2026). 带校准不确定性量化的 GEDI 生物量估计插值，arXiv 预印本。https://doi.org/10.48550/ArXiv.2601.16834
  
* Lisaius, M. C., Keshav, S., Blake, A., & Atzberger, C. (2026). 基于嵌入的塞内加尔花生盆地作物类型分类（arXiv:2601.16900）。ArXiv 预印本。https://doi.org/10.48550/arXiv.2601.16900

* Ball, J.G.C, Wicklein J.A. , Feng, Z.,  Knezevic, J.,  Jaffer, S., Atzberger, C.,  Dalponte, M., and Coomes, D. 地理空间基础模型实现温带山地森林中高效数据的树种映射，BioArxiv, https://doi.org/10.64898/2026.02.23.707022

## 演讲

* [TESSERA 在“AI for Good”研讨会中的概述](https://www.youtube.com/live/9yrpwFrwbGY)，Frank Feng，2026年1月22日
* [TESSERA：用于地球表示与分析的预计算FAIR全球像素嵌入](https://www.grss-ieee.org/event/tessera-precomputed-fair-global-pixel-embeddings-for-earth-representation-and-analysis/) IEEE GRSS 讲座，Frank Feng，2025年12月12日
* [CRI快闪演讲两页总结（PPTX）](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0)，S. Keshav，2025年10月7日
* 生态学组会议基础模型概述（PPTX），剑桥大学，DAB，James Ball，2025年10月6日
* [重点介绍生态应用的TESSERA概述演讲](https://www.dropbox.com/scl/fi/8xvanw3kk586lp1ld31kd/maryland_talk_slides.pdf?rlkey=osyhtk1kc2pcj81iel0u32lub&st=6kedpwv6&dl=0)（PDF）马里兰大学，Frank Feng，2025年10月1日
* [TESSERA概述演讲](https://www.dropbox.com/scl/fi/0rsq4wkao3c7fgwljd8ec/JCU-tesserav2.pptx?rlkey=ccutcxgwi068c09n20t1yi549&st=13if23b3&dl=0)（PPTX）詹姆斯库克大学，S. Keshav，2025年9月29日
* [TESSERA概述演讲](https://www.dropbox.com/scl/fi/1p7nabvlvie8fzyomkx7w/dab_talk_slides.pdf?rlkey=ym3d44o80mbrdkasyzct9kzi5&st=ozvwczs7&dl=0) 剑桥大学，DAB，Frank Feng，2025年5月20日
* [地球观测自监督学习](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0)（PPTX）S. Keshav，埃克塞特，2025年4月

## 许可协议


TESSERA 软件在标准 MIT 许可证下发布。嵌入和模型权重在 [CC0](https://creativecommons.org/publicdomain/zero/1.0/) 许可证下发布：本质上，它们可以自由用于商业和非商业目的。虽然我们在法律上不要求署名，  
但我们希望能够得到署名。

# 使用 TESSERA

<a id="global-embeddings-access"></a>

## 使用 GeoTessera 访问嵌入（推荐）

我们已生成了 2024 年全球 10 米分辨率的嵌入。  
这些嵌入可以下载并用于下游应用，节省大量计算时间和资源，使用  
[GeoTessera](https://github.com/ucam-eo/geotessera) 库。  
我们将逐年向后扩展覆盖范围，直到 2017 年。当前的覆盖地图如下：

<img src="https://github.com/ucam-eo/tessera-coverage-map/blob/main/map.png"> 

## TESSERA 用户组

有兴趣的用户欢迎加入我们的 [Zulip](https://eeg.zulipchat.com/login/) 讨论组。

# 创建您自己的嵌入

如果您想使用我们的软件创建自己的嵌入，请按照以下说明操作。请注意，这是一项计算挑战性较大的任务，您需要访问大量计算和存储资源。

## 硬件要求

### 1. 存储要求

运行该流程需要大量存储空间。尽管流程在处理后会清理一些中间文件，但下载的原始 Sentinel-2 和 Sentinel-1 文件仍会占用大量磁盘空间。例如，处理一个 100公里×100公里 区域的 2022 年数据以输出 TESSERA 表征图（10米分辨率）至少需要 1TB 存储空间。

### 2. 内存要求

我们使用预处理数据，最初来自 Microsoft Planetary Computer。但下一代嵌入将使用 ASF DAAC 的 OPERA。无论哪种情况，大部分地理预处理已完成。我们仍建议至少拥有 128GB 内存。

### 3. CPU 和 GPU

该流程对 CPU 和 GPU 没有严格要求，但更多的 CPU 核心和更强大的 GPU 可以显著加快推断速度。在处理 2022 年 110公里×110公里 区域时，我们的测试使用了 128 核 CPU 和一块 NVIDIA A30 GPU 进行推断（CPU 和 GPU 各负责 50% 的推断），大约用了 10 小时完成。



### 4. 操作系统

对于数据预处理流程，我们支持几乎所有的 Linux 系统。对于 Windows，我们推荐使用 WSL。目前不支持 MacOS。

对于模型推理部分，我们仅在 Linux 和 Windows WSL 上进行了测试，且运行正常。

## 数据预处理

### 概述
_**强烈建议您在运行流程前快速浏览整个教程。**_

在此步骤中，我们沿时间维度堆叠整整一年的 Sentinel-1 和 Sentinel-2 数据以生成合成影像。对于 Sentinel-2，合成影像的形状为 (T,H,W,B)，其中 T 是该年有效观测次数，B 是波段数量（我们选取了 10 个波段）。对于 Sentinel-1，我们提取了升轨和降轨数据。以升轨为例，合成影像的形状为 (T',H,W,B')，其中 T' 是该年有效升轨观测次数，B' 为 2，因为我们只获取 VV 和 VH 波段。

我们最初的数据来源是微软的 Planetary Computer：
- Sentinel-1 数据源：https://planetarycomputer.microsoft.com/dataset/sentinel-1-rtc
- Sentinel-2 数据源：https://planetarycomputer.microsoft.com/dataset/sentinel-2-l2a

新一代的嵌入将使用 ASF DAAC 的 OPERA：
- Sentinel-1 数据源：https://registry.opendata.aws/nasa-operal2rtc-s1v1/
- Sentinel-2 数据源：https://registry.opendata.aws/sentinel-2-l2a-cogs/

目前，我们的流程仅接受 TIFF 格式输入。输入 ROI TIFF 的分辨率可以变化（例如 30m），但流程将**始终以配置的 `RESOLUTION`（默认 10m）生成 Sentinel-1 和 Sentinel-2 输出**，同时保持**ROI 范围/边界不变**。TIFF 中有效的 ROI 区域值为 1，否则为 0。如果您只有 shapefile，也没问题——我们提供了 `convert_shp_to_tiff.py` 脚本。

### 下载源码

首先，创建一个空的工作目录：

```bash
mkdir tessera_project
cd tessera_project
git clone https://github.com/ucam-eo/tessera.git
```
为了简化流水线操作，建议将数据输出目录放置在与 `tessera_infer` 和 `tessera_preprocessing` 同一级别的位置：


```
tessera_project
 ┣ tessera_infer
 ┣ tessera_preprocessing
 ┣ my_data
   ┣ roi.shp (your shapefile)
   ┗ roi.tiff (we recommend generating this using convert_shp_to_tiff.py)
```

`roi.tiff` 可以使用位于 `tessera_preprocessing/convert_shp_to_tiff.py` 的 `convert_shp_to_tiff.py` 生成。使用时，只需在主函数中指定您的 shapefile 路径，它会在同一目录下输出同名的 TIFF 文件。

⚠️注意：_如果您的 ROI 较大，例如 100 公里 × 100 公里，我们强烈建议先将 TIFF 预分割成不大于 20 公里 × 20 公里的小块。然后在流水线中依次处理每个小的 TIFF 文件。过大的 ROI 可能会导致后端切片服务出现问题_

### Python 环境

我们需要一些地理处理包（幸运的是，我们不使用 GDAL，因为配置环境非常麻烦）和一些机器学习包（PyTorch，但您需要自己安装，因为每台计算机的硬件不同）。我们将一些常用包列在了 `requirements.txt`，您可以按如下方式安装：

```bash
pip install -r requirements.txt
```
注意：如果您处于受管理的环境中，您可能需要先安装一个虚拟环境（venv），使用 
```bash
python3 -m venv venv
source venv/bin/activate
```

### 脚本配置

首先，导航到 `tessera_preprocessing` 文件夹：

```bash
cd tessera_preprocessing
```

然后编辑文件 s1_s2_downloader.sh，指向 ROI TIFF 文件、输出和临时目录，以及数据源：

```bash
# === Basic Configuration ===
INPUT_TIFF="/absolute/path/to/your/data_dir/roi.tiff"
OUT_DIR="/absolute/path/to/your/data_dir"

export TEMP_DIR="/absolute/path/to/your/temp_dir"     # Temporary file directory

mkdir -p "$OUT_DIR"

# Python environment path
PYTHON_ENV="/absolute/path/to/your/python_env/bin/python"

# === Sentinel-1 & Sentinel-2 Processing Configuration ===
YEAR=2022 # Range [2017-2025]
RESOLUTION=10.0  # Output resolution (meters). ROI TIFF can be any resolution; extent is preserved.

# === Data Source Configuration ===
# mpc: Microsoft Planetary Computer (sentinel-1-rtc, sentinel-2-l2a)
# aws: AWS Open Data backends (S1=OPERA RTC-S1 via ASF/CMR + ASF Earthdata Cloud COGs, S2=Earth-search Sentinel-2 L2A COGs)
DATA_SOURCE="mpc"   # choices: mpc/aws
```

注意：`RESOLUTION` 控制输出像素大小。管道保持 ROI 边界固定，并将 ROI 掩码重新采样到输出网格。

### AWS 凭证（仅当 `DATA_SOURCE="aws"` 时需要）
Earth-search 上的 Sentinel-2 是公开的，**不需要凭证**。

Sentinel-1 OPERA RTC-S1 通过 ASF Earthdata Cloud 访问（通过 HTTPS 的 COG）。您需要 Earthdata 登录令牌：
- **创建 Earthdata 账户**：通过 [NASA Earthdata 登录](https://urs.earthdata.nasa.gov/home)。
- **批准应用程序**：注册账户后，您可以进入“应用程序”标签页，将 Alaska Satellite Facility Data Access 添加到已批准应用程序列表中。
- **通过点击“生成令牌”获取 EDL Bearer 令牌 / JWT**，并将其本地保存（不要提交）。

推荐（简单且明确）：

```bash
nano ~/.edl_bearer_token
# paste token, save+exit (Ctrl-O Enter, then Ctrl-X)
chmod 600 ~/.edl_bearer_token
```

AWS S1 下载器将使用此令牌从 ASF Earthdata Cloud 读取 COG。

如果您想获取临时 S3 凭证（高级操作；通常此管道不需要），请参阅 ASF 指南：
- `https://cumulus.asf.alaska.edu/s3credentialsREADME`

在上述配置下方，有一些额外配置，您可以根据计算机性能进行修改。

首先，给予 `s1_s2_downloader.sh` 权限：

```bash
chmod +x s1_s2_downloader.sh
```
然后，我们可以运行：


```bash
bash s1_s2_downloader.sh
```
由于网络状况，处理某些图块可能会超时。我们的脚本包含复杂的超时管理以避免这些问题。但是，有时某些图块仍可能失败。通常再次运行上述命令可以解决此问题。

如果所有 Sentinel-1 和 Sentinel-2 数据都正确生成，它们可以沿时间维度堆叠。对于这一步，我们使用两个由 Rust 生成的可执行文件，使其非常快速。你可以打开 `s1_s2_stacker.sh` 并编辑以下内容：


```bash
# === Basic Configuration ===
BASE_DIR="/absolute/path/to/your/data_dir"
OUT_DIR="${BASE_DIR}/data_processed"
DOWNSAMPLE_RATE=1
```

通常情况下，我们不会修改 `DOWNSAMPLE_RATE`，这使得它在堆叠过程中不会执行任何下采样。上述代码片段中的 `BASE_DIR` 与您在 `s1_s2_downloader.sh` 中修改的 `OUT_DIR` 是相同的。

同样，给予 `s1_s2_stacker.sh` 权限：

```bash
chmod +x s1_s2_stacker.sh
```

然后您可以执行堆叠操作：

```bash
bash s1_s2_stacker.sh
```
成功后，您将在 `/absolute/path/to/your/data_dir/data_processed` 中获得一些 `.npy` 文件。通常，这些 `.npy` 文件相当大，因此我们将把它们切分成更小、更易管理的单元。

执行：


```bash
python dpixel_retiler.py \
    --tiff_path /absolute/path/to/your/data_dir/roi.tif \
    --d_pixel_dir /absolute/path/to/your/data_dir/data_processed \
    --patch_size 500 \
    --out_dir /absolute/path/to/your/data_dir/retiled_d_pixel \
    --num_workers 16 \
    --overwrite \
    --block_size 2000
```

您可以自行更改上述的 `patch_size` 和 `block_size`。上述配置是针对形状为 (5000,5000) 且分辨率为 10m 的 TIFF 推荐的配置。

如果上述代码运行顺利，您可以在 `my_data/retiled_d_pixel` 目录下看到一些子文件夹。

## 推理

### 概述

数据预处理完成后，我们可以开始推理。在继续之前，请检查 `my_data/retiled_d_pixel` 文件夹中是否存在如下子文件夹：
```
retiled_d_pixel
 ┣ 0_3500_500_4000
 ┣ 0_4000_500_4500
 ┣ 0_4500_500_5000
 ┣ 0_5000_500_5500
 ┣ 0_5500_500_6000
 ┣ 0_6000_500_6500
```
每个子文件夹应包含以下文件：

```
0_3500_500_4000
 ┣ bands.npy
 ┣ doys.npy
 ┣ masks.npy
 ┣ roi.tiff
 ┣ sar_ascending.npy
 ┣ sar_ascending_doy.npy
 ┣ sar_descending.npy
 ┗ sar_descending_doy.npy
```

如果这些文件存在，您可以开始推理。否则，请检查第一步是否成功完成。

推理需要 PyTorch。由于每个系统的 CUDA 版本可能略有不同，我们无法像数据预处理那样提供 Docker 封装的 Python 环境。幸运的是，推理的 Python 环境比数据预处理更容易配置，因为它不使用像 GDAL 或 SNAP 这样的地理处理包。

### Pytorch 准备

如果您还没有安装 Pytorch，可以参考以下步骤。否则，您可以忽略本节。

首先，检查您的系统 CUDA 版本：

```bash
nvidia-smi
```

然后访问 https://pytorch.org/ 并根据您的 CUDA 版本选择适当的版本进行安装，例如：

```bash
pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu128
```

### 模型权重

接下来，从[Google Drive](https://drive.google.com/drive/folders/18RPptbUkCIgUfw1aMdMeOrFML_ZVMszn?usp=sharing)下载模型权重，并将`.pt`文件放置在`tessera_infer/checkpoints`目录下：

```
tessera_infer
 ┗ checkpoints
     ┗ best_model_fsdp_20250427_084307.pt
 ┗ configs
 ┗ src
```

_**请注意，上述提到的检查点是一个早期模型，原生生成 float32 嵌入。因此，该模型并不是用于在 geotessera 库中生成 int8 嵌入的模型。我们将很快将用于创建 geotessera 嵌入的特定检查点部署到完整流水线中。**_

### 配置 Bash 脚本

为了简化推理配置，我们提供了 `tessera_infer/infer_all_tiles.sh`。您只需编辑几个参数：

a. 基础数据目录：
```bash
BASE_DATA_DIR="your_data_directory"
```
这是您的数据存储文件夹，与之前 bash 中的 `BASE_DATA_DIR` 相同，例如，`/maps/usr/tessera_project/my_data`

b. Python 环境：
```bash
export PYTHON_ENV="your_python_path"
```
请在此处写出您的 Python 环境的绝对路径，例如，`/home/user/anaconda3/envs/tessera_env/bin/python`

c. CPU/GPU 分配：
```bash
CPU_GPU_SPLIT="1:1"  # Format: CPU:GPU ratio
```
该脚本支持使用 CPU 和 GPU 同时进行推理。该比例指定每个设备将处理的 `retiled_patches` 的比例。默认值为 1:1（均分）。对于仅 GPU 推理，设置为 0:1。

d. CPU 相关设置

```bash
MAX_CONCURRENT_PROCESSES_CPU=20
```
用于图块推理的最大 CPU 进程数。例如，如果设置为 20，则会同时处理 20 个图块。

```bash
AVAILABLE_CORES=$((TOTAL_CPU_CORES / 2)) # Use 50% of the cores
```
要使用的CPU核心数。如有必要，请修改此值以避免消耗过多的CPU资源！

e. GPU相关设置：
```bash
MAX_CONCURRENT_PROCESSES_GPU=1
```
推理时的最大 GPU 进程数。如果系统只有 1 个 GPU，请将此设置为 1。

```bash
GPU_BATCH_SIZE=1024  # Larger for GPU, if this takes too much memory, reduce it
```
在PyTorch推理过程中一次处理的样本数量。如果该值占用过多GPU内存或导致GPU上的OOM错误，请相应减少。

f. 其他设置
还有其他可配置参数。请根据需要进行调整。

### 开始推理

准备就绪后，导航到 `tessera_infer` 文件夹：

```bash
cd tessera_infer
```

然后给予 `infer_all_tiles.sh` 权限：

```bash
chmod +x infer_all_tiles.sh
```

然后运行它：

```bash
bash infer_all_tiles.sh
```

如果成功，您应该会看到如下日志：

```
(base) zf281@daintree:/scratch/zf281/tessera_project/tessera_infer$ bash infer_all_tiles.sh
[INFO] Total CPU cores: 256, Using: 192
[INFO] CPU:GPU split ratio = 1:1 (total: 2)

==== SETUP DIRECTORIES ====
[SUCCESS] Created necessary directories

==== SCANNING TILES ====
[INFO] Tile directory: /scratch/zf281/jovana/retiled_d_pixel
[INFO] Output directory: /scratch/zf281/jovana/representation_retiled
[SUCCESS] Found 226 tiles total
[INFO] Sample tiles:
  - 0_3500_500_4000
  - 0_4000_500_4500
  - 0_4500_500_5000
  - ...
```

同时，`tessera_infer` 文件夹中将生成一个 `logs` 文件夹，包含每个 CPU 和 GPU 进程的更详细日志。

### 拼接最终表示图

推理通常需要较长时间，具体取决于您的 ROI 大小和硬件性能。完成后，您可以在 `my_data/representation_retiled` 中找到许多 `.npy` 文件：

```
representation_retiled
 ┣ 0_3500_500_4000.npy
 ┣ 0_4000_500_4500.npy
 ┣ 0_4500_500_5000.npy
 ┣ 0_5000_500_5500.npy
 ┣ 0_5500_500_6000.npy
 ┣ 0_6000_500_6500.npy
 ┣ 0_6500_500_7000.npy
 ┣ 0_7000_500_7500.npy
 ┣ 1000_0_1500_500.npy
 ┣ 1000_1000_1500_1500.npy
 ┣ 1000_1500_1500_2000.npy
 ┣ 1000_2000_1500_2500.npy
```

最后一步是使用 `tessera_infer/stitch_tiled_representation.py` 将它们拼接在一起：

```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /path/to/d_pixel_retiled \
--representation_retiled_path /path/to/representation_retiled \
--downstream_tiff /path/to/downstream.tiff \
--out_dir /path/to/output_directory
```
例如：


```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /maps/usr/tessera_project/my_data/d_pixel_retiled \
--representation_retiled_path /maps/usr/tessera_project/my_data/representation_retiled \
--downstream_tiff /maps/usr/tessera_project/my_data/downstream.tiff \
--out_dir /maps/usr/tessera_project/my_data
```
最终，您将在 `my_data` 目录中获得一个拼接的表示图，形状为 (H,W,128)，其中 H 和 W 与您最初的 `roi.tiff` 相匹配。表示图是一个 NumPy 数组。如果您想将其转换为 TIFF 以便在 QGIS 等软件中查看，可以使用 `tessera_infer/convert_npy2tiff.py` 脚本。只需在主函数中修改为：


```python
npy_path = "/maps/usr/tessera_project/my_data/stitched_representation.npy"  # Change to the actual npy file path
ref_tiff_path = "/maps/usr/tessera_project/my_data/roi.tiff"  # Change to the actual reference tiff file path
out_dir = "/maps/usr/tessera_project/my_data/"  # Change to the actual output directory
```

## 下游任务

如果您想复现论文中的下游任务，可以访问 https://github.com/ucam-eo/tessera-downstream-task。那里提供了许多示例。

# 其他信息

## 团队

### 剑桥教职员工
* [S. Keshav](https://svr-sk818-web.cl.cam.ac.uk/keshav/wiki/index.php/Main_Page)
* [Anil Madhavapeddy](https://anil.recoil.org)
* [Sadiq Jaffer](https://toao.com)
* [David Coomes](https://www.plantsci.cam.ac.uk/directory/david-coomes)

### 博士后
* James Ball
  
### 博士生
* Madeleine Lisaius
* Zhengpeng (Frank) Feng
* Robin Young
* Jovana Knezevic

### 本科生
* Zejia Yang（第二阶段学生，与 Frank Feng 合作进行空间特征提取器的 MAE 预训练）

### 实习生
* Kenzy Soror（滑铁卢大学，与 Robin Young 合作）
* Artyom Gabtraupov（滑铁卢大学，与 Robin Young 合作）
* Gabriel Mahler（剑桥大学，与 Anil Madhavapeddy 和 Silviu Petrovan 合作，研究[刺猬栖息地及追踪](https://anil.recoil.org/ideas/hedgehog-mapping)）
* Leyu Pan（帝国理工学院，与 Frank Feng 合作，基于 OSM 生成文本嵌入）

### 合作者
* [Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/?originalSubdomain=at)，dClimate Labs
* [Andrew Blake](https://en.wikipedia.org/wiki/Andrew_Blake_(computer_scientist))，Mantle Labs

### 访问学者
* Silja Sormunnen，芬兰阿尔托大学
* Isabel Mansley（爱丁堡大学，与 David Coomes 和 Anil Madhavapeddy 合作，进行[苏格兰栖息地映射](https://anil.recoil.org/ideas/cairngorms-connect-habitats)）

## 联系方式

请将您的技术问题发送给Frank Feng（zf281@cam.ac.uk）或在我们的[Zulip论坛](https://eeg.zulipchat.com/login/)上提问。非技术性问题可发给S. Keshav教授（sk818@cam.ac.uk）。

## 引用

如果您在研究中使用了TESSERA，请引用[arXiv论文](https://arxiv.org/abs/2506.20380)：

```bibtex
@misc{feng2025tesseratemporalembeddingssurface,
      title={TESSERA: Temporal Embeddings of Surface Spectra for Earth Representation and Analysis}, 
      author={Zhengpeng Feng et al.},
      year={2025},
      eprint={2506.20380},
      archivePrefix={arXiv},
      primaryClass={cs.LG},
      url={https://arxiv.org/abs/2506.20380}, 
}
```
## 致谢
我们衷心感谢英国研究与创新署（UKRI）及剑桥大学[DAWN](https://www.hpc.cam.ac.uk/d-w-n)超级计算机团队对本项目的大力支持。我们还感谢[AMD](https://www.amd.com/en.html)、[Vultr](https://www.vultr.com/)、[Dirac高性能计算设施](https://dirac.ac.uk)、[微软AI公益实验室](https://www.microsoft.com/en-us/research/group/ai-for-good-research-lab/)、Robert Sansom博士、[dClimate](https://www.dclimate.net/)、以及在其AWS开放数据计划(https://opendata.aws/)下的[亚马逊网络服务（AWS）](https://aws.amazon.com/)的支持。本工作离不开他们的支持、计算资源和技术协助。

## Star History
[![Star History Chart](https://api.star-history.com/svg?repos=ucam-eo/tessera&type=Date)](https://www.star-history.com/#ucam-eo/tessera&Date)

## AUP

### TESSERA 使用条款与伦理指南

### 许可证

TESSERA 数据和嵌入向量在 **知识共享 0 国际许可协议 [CC-0](https://creativecommons.org/public-domain/cc0/)** 下发布。  
这意味着您可以自由：

* **共享** — 复制并以任何媒介或格式重新分发材料  
* **改编** — 重新混合、转换并基于材料进行构建，适用于任何目的，甚至商业用途

### 目的与预期用途

TESSERA 的开发旨在推动科学研究，支持环境监测、保护、可持续农业及对地球系统的理解。我们设计此工具以实现：

* 科学研究与教育  
* 环境监测与保护  
* 农业与粮食安全分析  
* 气候变化研究与适应规划  
* 可持续土地利用与资源管理  
* 造福社会与环境的公益应用

### 伦理指南

虽然 CC0 许可证允许广泛使用，我们强烈建议用户考虑其工作的伦理影响。以下伦理指南为建议性内容，不具法律强制力。我们请求用户：

**负责任地行事：**  
* 在分析特定地点时考虑隐私影响  
* 尊重受影响社区的权利与尊严  
* 注意潜在的双重用途问题

**保持透明：**

* 准确表示数据的特性（年度分辨率，10米空间分辨率）  
* 承认您应用中的局限性  
* 不得错误描述TESSERA的能力  

**支持积极影响：**  
* 考虑您的工作如何促进社会利益  
* 在适当时与受影响社区互动  
* 分享推进公共知识的发现  

### 数据特性  

用户应理解TESSERA提供：  
* **年度时间分辨率** — 数据表示年度汇总，而非实时或高频监测  
* **10米空间分辨率** — 适用于景观尺度分析  
* **光谱-时间嵌入** — 压缩表示形式，非原始影像  

请在您的工作中准确反映这些特性。  

### 社区标准  

我们鼓励负责任的使用并欢迎社区反馈。如您对潜在应用有疑虑或改进指南的建议，请联系我们。  

我们保留根据社区反馈和新出现的考虑因素更新本指南的权利，但此类更新不追溯影响数据发布时所采用的CC-0许可证。  

### 联系方式  

如有问题或反馈，请发送邮件至 sk818@cam.ac.uk  

---  

*最后更新：2026年2月25日*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---