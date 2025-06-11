# 实时光照场渲染的3D高斯点扩散 - C++和CUDA实现

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

基于[gsplat](https://github.com/nerfstudio-project/gsplat)光栅化后端构建的高性能C++和CUDA实现的3D高斯点扩散。

## 新闻
- **[2025-06-10]**：修复了一些问题。我们正在缩小与gsplat指标的差距，但仍有小部分不匹配。
- **[2025-06-04]**：添加了带有`--max-cap`命令行选项的MCMC策略，用于控制最大高斯数量。
- **[2025-06-03]**：切换到Gsplat后端并更新了许可证。
- **[2024-05-27]**：更新到LibTorch 2.7.0以获得更好的兼容性和性能。已解决优化器状态管理的重大变更。
- **[2024-05-26]**：本仓库当前目标是转向宽松许可证。主要工作是用gsplat实现替换光栅器。

## 指标
目前实现的效果尚未达到gsplat-mcmc的水平，但正在持续改进中。  
修复该错误只是时间问题，欢迎贡献 :) MCMC策略的指标如下：

| 场景     | 迭代次数 | PSNR          | SSIM         | LPIPS        | 单张图像时间 | 高斯数量    |
| -------- | -------- | ------------- | ------------ | ------------ | ------------ | ----------- |
| garden   | 30000    | 27.112114     | 0.854833     | 0.157624     | 0.304765     | 1000000     |
| bicycle  | 30000    | 25.047745     | 0.767729     | 0.254825     | 0.293618     | 1000000     |
| stump    | 30000    | 26.554749     | 0.784203     | 0.263013     | 0.296536     | 1000000     |
| bonsai   | 30000    | 32.534199     | 0.948675     | 0.246924     | 0.436188     | 1000000     |
| counter  | 30000    | 29.187017     | 0.915823     | 0.242159     | 0.441259     | 1000000     |
| kitchen  | 30000    | 31.680832     | 0.933897     | 0.154965     | 0.449078     | 1000000     |
| room     | 30000    | 32.211632     | 0.930754     | 0.273719     | 0.413519     | 1000000     |
| **平均** | **30000**| **29.189755** | **0.876559** | **0.227604** | **0.376423** | **1000000** |

## 社区与支持

加入我们不断壮大的社区，参与讨论、获取支持和最新动态：  
- 💬 **[Discord社区](https://discord.gg/TbxJST2BbC)** - 获取帮助、分享成果、讨论开发  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - 访问我们的网站获取更多资源  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - 详尽的论文列表和资源  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - 关注最新动态  

## 构建与运行说明

### 软件依赖
1. **Linux**（测试环境为Ubuntu 22.04）- 目前不支持Windows  
2. **CMake** 3.24及以上  
3. **CUDA** 11.8及以上（低版本需手动配置）  
4. 带开发头文件的**Python**  
5. **LibTorch 2.7.0** - 下面有设置说明  
6. 其他依赖由CMake自动处理  

### 硬件依赖
1. 支持CUDA的**NVIDIA GPU**  
    - 成功测试：RTX 4090、RTX A5000、RTX 3090Ti、A100  
    - RTX 3080Ti在大型数据集上存在已知问题（见 #21）  
2. 最低计算能力：8.0  

> 如果您在其他硬件上成功运行，请在讨论区分享您的经验！

### 构建步骤

```bash
# 克隆仓库及子模块
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# 下载并设置LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# 构建项目
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

本项目使用**LibTorch 2.7.0**以获得最佳性能和兼容性：

- **性能提升**：优化和内存管理改进  
- **API 稳定**：最新稳定的PyTorch C++ API  
- **CUDA兼容**：更好的与CUDA 11.8+集成  
- **错误修复**：解决了优化器状态管理问题  

### 从旧版本升级
1. 按照构建说明下载新版本LibTorch  
2. 清理构建目录：`rm -rf build/`  
3. 重新构建项目  

## 数据集

从原始仓库下载数据集：  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)  

解压到项目根目录的`data`文件夹中。

## 命令行选项

### 核心选项

- **`-h, --help`**  
  显示帮助菜单

- **`-d, --data-path [路径]`**  
  训练数据路径（必填）

- **`-o, --output-path [路径]`**  
  训练模型保存路径（默认：`./output`）

- **`-i, --iter [数字]`**  
  训练迭代次数（默认：30000）  
    - 论文建议30k，但6k-7k常常能得到不错的初步结果  
    - 每7k次迭代保存一次输出，训练结束时也保存

- **`-f, --force`**  
  强制覆盖已有输出文件夹

- **`-r, --resolution [数字]`**  
  设置训练图像分辨率

### MCMC专用选项

- **`--max-cap [数字]`**  
  MCMC策略最大高斯数量（默认：1000000）  
    - 控制训练过程中高斯点扩散的上限  
    - 适合内存受限环境

### 示例用法

基础训练：  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

限制高斯数量的MCMC训练：  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## 贡献指南

欢迎贡献！入门指南：

1. **开始**：  
    - 查看标记为**good first issues**的初学者友好任务  
    - 有新想法可开启讨论或加入我们的[Discord](https://discord.gg/TbxJST2BbC)

2. **提交PR前**：  
    - 使用`clang-format`统一代码风格  
    - 使用预提交钩子：`cp tools/pre-commit .git/hooks/`  
    - 新依赖请先在issue中讨论，我们尽量减少依赖

## 致谢

本实现基于以下关键项目：

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**：采用gsplat高效的CUDA光栅化后端，显著提升性能和内存效率。  
- **原始3D高斯点扩散**：基于Kerbl等人的开创性工作。

## 引用

若在研究中使用本软件，请引用原始工作：

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## 许可证

详情见LICENSE文件。

---

**联系我们：**  
- 🌐 网站：[mrnerf.com](https://mrnerf.com)  
- 📚 论文：[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord：[加入我们的社区](https://discord.gg/TbxJST2BbC)  
- 🐦 推特：关注 [@janusch_patas](https://twitter.com/janusch_patas) 获取开发更新

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---