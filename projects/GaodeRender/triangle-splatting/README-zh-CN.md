
<div align="center">

# 2D三角形溅射用于直接可微网格训练

[Arxiv][1] | [项目主页][4]

盛凯峰*, 周正*, 彭英亮, 王乾伟 (*同等贡献)

阿里巴巴集团阿地图

</div>

## - 项目概述

[2DTS][1]（用于直接可微网格训练的2D三角形溅射）的官方实现

我们提供了完整的2DTS训练流程，2DTS是一种可微分的3D几何表示，改编自[3DGS][2]（3D高斯溅射），将基本体从高斯体替换为三角形，同时保持模型的完全可微性。
该方法能够通过端到端的训练流程生成高视觉保真度的三角形网格。

![demo_image](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/demo_image.png)

我们的方法可应用于大规模数据集，如包含6000+图像的MatrixCity。这类数据集对现有网格重建方法具有挑战性，但我们的方法能够高效处理。
重建的网格可以直接用于现代游戏引擎，如Blender，实现重光照、阴影渲染及其他高级渲染效果。以下图片展示了基于MatrixCity数据集重建网格的重光照效果示例：

![relighting_image](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/relighting_image.png)

## - 摘要

基于3D高斯基本体的可微渲染已成为从多视图图像重建高保真3D场景的强大方法。
虽然相较于基于NeRF的方法有所改进，但该表示在渲染速度和高级渲染效果（如重光照和阴影渲染）方面，仍面临着相较于基于网格模型的挑战。
本文提出了2D三角形溅射（2DTS），一种将3D高斯基本体替换为2D三角形面片的新方法。
该表示自然形成离散的类网格结构，同时保留连续体积建模的优点。
通过向三角形基本体引入紧凑性参数，实现了对真实感网格的直接训练。
我们的实验结果表明，基于三角形的方法在其基础版本（未调节紧凑性）下，较现有高斯基方法实现了更高的保真度。
此外，我们的方法在视觉质量上优于现有网格重建方法。

## - 安装

1. 安装CUDA 12.4或更高版本（记得将环境变量`CUDA_HOME`设置为CUDA安装路径）；
2. 克隆代码库：`git clone https://github.com/GaodeRender/diff_recon.git; cd diff_recon`；
3. 创建Python 3.12的conda环境：`conda create -n 2dts python=3.12`；
   激活环境：`conda activate 2dts`；
4. 安装依赖：`pip install -r requirements.txt --no-cache-dir`；
5. 在项目根目录执行`pip install . --no-cache-dir`；

## - 使用
### 训练
执行`run_experiments.py`，通过以下命令在Mip-NeRF 360、NerfSynthetic、Tanks and Temples、DeepBlending或MatrixCity数据集上训练2DTS模型：


```bash
python run_experiments.py --type {experiment_type} --dataset_path /path/to/dataset --num_workers 0
```
`experiment_type` 可以是 `MipNerf360`、`NerfSynthetic`、`NerfSynthetic_mesh`、`TanksAndBlending` 或 `MatrixCity_mesh`。

该脚本要求预先下载数据集，且数据集路径应指向数据集的根目录。
例如，如果您想在 NerfSynthetic 数据集上训练一个网格模型，并且数据集存储在 `./data/nerf_synthetic`，您可以运行以下命令：
```bash
python run_experiments.py --type NerfSynthetic_mesh --dataset_path ./data/nerf_synthetic --num_workers 0
```
### 日志
训练日志将保存在 `./outputs` 目录中。您可以使用 TensorBoard 来可视化训练过程：

```bash
tensorboard --logdir ./outputs
```
### 渲染
我们提供了一个基于 [Viser Viewer][3] 的交互式网页查看器，用于可视化训练好的三角形点和网格。
您可以通过执行以下命令来运行查看器：

```bash
python viser_viewer.py --config /path/to/config --dataset_path /path/to/dataset --scene {scene_name}
```
例如，如果您运行了 `NerfSynthetic_mesh` 实验并想要可视化 `ship` 场景，且数据集存储在 `./data/nerf_synthetic` 中，您可以运行以下命令：
```bash
python viser_viewer.py --config config/NerfSynthetic_VanillaTS_mesh.yaml --dataset_path ./data/nerf_synthetic --scene ship
```
然后，打开您的网页浏览器并导航到 `http://localhost:8080` 以查看渲染的场景。如果您在远程服务器上运行查看器，请确保设置端口转发或直接访问服务器的IP地址。

## - 注意事项
我们提供了两种不同的训练配置：VanillaTS 和 VanillaTS_mesh。
- VanillaTS 是对原始 3DGS 方法的近似模仿，紧凑参数设置为 1.0，生成透明和漫反射三角形斑点（详情见 [2DTS][1]）。
- VanillaTS_mesh 将在训练过程中添加不透明度正则化和紧凑度调节，训练结束时将生成一个实心三角形网格。三角形网格以 `.glb` 文件形式保存在输出目录中。请注意，当训练过程中 **back_culling** 被 **禁用** 时，**网格文件将包含每个三角形的 <span style="color:red">两次</span>**，一次为正面，一次为背面。

漫反射三角形与实心三角形的区别在下图中可见：

![triangle_splatting](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./assets/triangle_splatting.png) 

## - 待办事项

1. 我们的方法假设密集点云初始化。由于稳定性问题，默认关闭了像 [3DGS][2] 中使用的密集化过程。我们正在探索新的密集化和初始化方法，欢迎在该领域的任何贡献。
2. 当前实现对每个三角形斑点使用一组不透明度和颜色/光照参数。然而，自然的扩展是支持每个顶点的颜色和不透明度，这将增强模型的表现力。我们正在开发这一扩展。

## - 许可协议

本仓库包含两种不同的许可证代码：

- 🟥 **Gaussian Splatting 研究许可** — 适用于源自原始 [Gaussian Splatting][2] 项目的组件：
  - `submodules/custom-gaussian-rasterization/`
  - `submodules/simple-knn/`
  - 这些组件仅许可用于 **非商业研究用途**。
  - 详见 [LICENSE.gausplat.md](https://raw.githubusercontent.com/GaodeRender/triangle-splatting/main/./LICENSE.gausplat.md)

- 🟩 **MIT 许可证** — 适用于仓库中的其他部分，包括：
  - `src/diff_recon/`
  - `submodules/diff-triangle-rasterization-2D/`、`submodules/diff-triangle-rasterization-3D/` 等。
  - 详见 [LICENSE](./LICENSE)

使用本仓库时，请确保遵守两种许可证的规定。

## - 引用

如果您觉得我们的工作有用，请考虑引用我们的论文：

```bibtex
@misc{sheng20252dtrianglesplattingdirect,
      title={2D Triangle Splatting for Direct Differentiable Mesh Training}, 
      author={Kaifeng Sheng and Zheng Zhou and Yingliang Peng and Qianwei Wang},
      year={2025},
      eprint={2506.18575},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.18575}, 
}
```


<!-- 参考文献 -->
[1]: https://arxiv.org/abs/2506.18575
[2]: https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/
[3]: https://github.com/nerfstudio-project/viser
[4]: https://gaoderender.github.io/triangle-splatting/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---