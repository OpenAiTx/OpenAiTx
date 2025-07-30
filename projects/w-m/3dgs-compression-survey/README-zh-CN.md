# 3DGS.zip：3D高斯斑点压缩方法综述
本仓库包含了3D高斯斑点（3DGS）压缩方法的全面综述。您可以在[w-m.github.io/3dgs-compression-survey/](https://w-m.github.io/3dgs-compression-survey/)查看完整的综述表格和比较图表。

## 安装
要运行本仓库中的脚本，请确保已安装所有必要的依赖项。您可以使用以下命令安装：

`pip install -r requirements.txt`

## 构建网站
要构建网站，请使用以下命令：

`python data_extraction/build_html.py`

该脚本也会在每次推送到主分支时自动运行以重新构建网站。

## 获取结果
您可以通过运行以下命令自动获取结果：

`python data_extraction/data_extraction.py`

该脚本尝试从相关论文中获取数据并更新`results`文件夹中的表格。要添加新论文，请在`data_extraction/data_source.yaml`中创建一个条目。

## 包含您自己的结果

作者请将其每个场景的结果上传至其GitHub仓库中的指定文件夹。这样确保数据准确获取并允许进行一致且公平的比较。预期的文件夹结构为：

```
results
├── DeepBlending
│   ├── drjohnson.csv
│   └── playroom.csv
├── MipNeRF360
│   ├── bicycle.csv
│   ├── bonsai.csv
│   ├── counter.csv
│   ├── flowers.csv
│   ├── garden.csv
│   ├── kitchen.csv
│   ├── room.csv
│   ├── stump.csv
│   └── treehill.csv
├── SyntheticNeRF
│   ├── chair.csv
│   ├── drums.csv
│   ├── ficus.csv
│   ├── hotdog.csv
│   ├── lego.csv 
│   ├── materials.csv
│   ├── mic.csv
│   └── ship.csv
└── TanksAndTemples
    ├── train.csv
    └── truck.csv
```
该文件夹应包含所有用于评估您方法的数据集，并涵盖文件夹结构中指定的所有场景。

每个CSV文件应按以下结构组织：


```
Submethod,PSNR,SSIM,LPIPS,Size [Bytes],#Gaussians
Baseline,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
-SubmethodName,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx
,xx.xx,0.xxx,0.xxx,xxxxxxxx,xxxxxxxx

```
请确保PSNR结果至少保留两位小数精度，SSIM和LPIPS结果至少保留三位小数精度。鼓励作者提供完整精度的结果，这些结果将在纳入我们的调查前进行四舍五入。

在所有文件中为您的结果包含最多两个一致的子方法名称，以确保它们出现在调查表中。然后这些名称将在表中与您的方法名称连接。如果子方法说明符应与方法名称用空格分开，请确保在子方法名称前包含该空格。如果您只希望表中显示您的方法名称，可以使用“Baseline”作为这些结果的子方法名称。没有子方法名称的结果只会显示在图表中。

您可以在[这里](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/tree/main/results)查看示例。

### 重要：3DGS测试规范

作者必须遵守原始[3DGS项目](https://github.com/graphdeco-inria/gaussian-splatting)中制定的测试规范。具体包括：

- 使用MipNeRF360数据集中的所有9个场景，包括[额外场景](https://storage.googleapis.com/gresearch/refraw360/360_extra_scenes.zip)“flowers”和“treehill”。
- 在最大边长为1600像素的全分辨率下评估图像。较大的测试图像应缩小，使最长边等于1600像素（仅适用于MipNeRF360）。确保缩放与3DGS一致，后者使用标准PIL的```.resize()```方法并采用双三次重采样。
- 对于3个COLMAP数据集（Tanks and Temples、Deep Blending、MipNeRF360），每8张图像取一张作为测试。具体来说，测试图像为满足```idx % 8 == 0```的图像。
- 对于Blender数据集（SyntheticNeRF），遵循预定义的训练/评估划分。

## LaTeX表格

最新版本的调查表LaTeX文件可用于[压缩](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_compression.tex)和[致密化](https://github.com/w-m/3dgs-compression-survey/blob/main/data_extraction/latex/3dgs_table_densification.tex)。如果您想将表格中的某一行复制到您的研究中以进行比较，请随意复制。如需复制整张表格，您可能需要在LaTeX前言中添加以下宏包和定义：


```
\usepackage{booktabs}
\usepackage[table]{xcolor}
% colors for table
\definecolor{lightred}{HTML}{FF9999}
\definecolor{lightyellow}{HTML}{FFFF99}
\definecolor{lightorange}{HTML}{FFCC99}
\usepackage{makecell}
\usepackage{adjustbox}
% make text the same size even when its bold in a table
\newsavebox\CBox
\def\textBF#1{\sbox\CBox{#1}\resizebox{\wd\CBox}{\ht\CBox}{\textbf{#1}}}
```

## 引用

如果您在研究中使用我们的调查，请引用我们的工作。您可以使用以下BibTeX条目：

```bibtex
@article{3DGSzip2025,
author = {Bagdasarian, M. T. and Knoll, P. and Li, Y. and Barthel, F. and Hilsmann, A. and Eisert, P. and Morgenstern, W.},
title = {{3DGS.zip}: A {Survey} on {3D} {Gaussian} {Splatting} {Compression} {Methods}},
journal = {Computer Graphics Forum},
pages = {e70078},
year = {2025},
keywords = {CCS Concepts, • Information systems → Data compression, • Computing methodologies → Rasterization, • General and reference → Surveys and overviews},
doi = {https://doi.org/10.1111/cgf.70078},
url = {https://onlinelibrary.wiley.com/doi/abs/10.1111/cgf.70078},
eprint = {https://onlinelibrary.wiley.com/doi/pdf/10.1111/cgf.70078},
note = {\url{https://w-m.github.io/3dgs-compression-survey/}},
} 
```
## 更新日志
- 2025-04-29：文章发布，更新了 Readme 和网站上的 bibtex
- 2025-03-04：添加了 GaussianSpa 摘要（由作者提供）
- 2025-02-26：添加了 HEMGS
- 2025-02-25：添加了 GaussianSpa
- 2025-02-25：添加了 HAC++
- 2025-02-25：添加了 FCGS
- 2025-02-10：移除了 IGS，因为该出版物已撤回
- 2025-02-05：添加了 CodecGS
- 2024-11-21：添加了 ContextGS
- 2024-11-07：添加了 CompGS
- 2024-11-05：更新了包含压缩和压实方法及 3DGS 压缩基础的 [arXiv](https://arxiv.org/abs/2407.09510) 版本
- 2024-10-21：在网站上正式将“致密化”方法改名为“压实”方法，以与综述论文保持一致
- 2024-10-17：向致密化/压实方法中添加了 GaussiansPro、AtomGS 和 Taming3DGS
- 2024-10-14：向压缩方法中添加了 MesonGS
- 2024-09-30：向综述中添加了致密化方法
- 2024-09-17：更新了 Morgenstern 等人的结果，并因[测试规范混淆](https://github.com/YihangChen-ee/HAC/issues/14)恢复了 HAC 结果
- 2024-09-05：更新 Scaffold-GS MipNeRF-360 结果，包含全部 9 个场景
- 2024-08-27：向综述中添加了 IGS 方法
- 2024-08-26：向综述中添加了 gsplat 方法
- 2024-08-14：基于属性和数据集选择的自适应排名
- 2024-08-12：新增以高斯数量为横坐标的指标图
- 2024-08-08：添加复选框以选择表中显示的指标和数据集
- 2024-08-07：在综述中包含高斯数量，在表中包含每个高斯的比特数
- 2024-08-02：展示已发表论文的会议
- 2024-06-19：基于所有可用数据集的新排名计算
- 2024-06-17：包含方法排名
- 2024-06-17：综述在 [arXiv](https://arxiv.org/abs/2407.09510) 上首次发布
- 2024-06-13：添加了以模型大小为横坐标的指标图
- 2024-06-10：综述页面初稿，包含交互式表格


<!-- - 2024-08-22：发布了预训练的[压缩场景](https://github.com/fraunhoferhhi/Self-Organizing-Gaussians/releases/tag/eccv-2024-data)
- 2024-07-09：项目网站更新了摘要、贡献、见解及与同期方法的比较
- 2024-07-01：我们的工作被**ECCV 2024**接受 🥳
- 2024-06-13：训练代码发布
- 2024-05-14：压缩分数提升！论文 v2 的新结果已在[项目网站](https://fraunhoferhhi.github.io/Self-Organizing-Gaussians/)发布
- 2024-05-02：修订版[论文 v2](https://arxiv.org/pdf/2312.13299)发布于 arXiv：新增球谐压缩，更新压缩方法并取得更好结果（所有属性现均用 JPEG XL 压缩），增加更多场景的定性比较，将压缩说明和比较移至主论文，新增与“Making Gaussian Splats smaller”的比较。
- 2024-02-22：排序算法代码现已发布于 [fraunhoferhhi/PLAS](https://github.com/fraunhoferhhi/PLAS)
- 2024-02-21：不同场景的视频比较已发布于[项目网站](https://fraunhoferhhi.github.io/Self-Organizing-Gaussians/)
- 2023-12-19：预印本发布于 [arXiv](https://arxiv.org/abs/2312.13299) -->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---