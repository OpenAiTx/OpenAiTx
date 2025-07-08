# EX-4D: 基于深度水密网格的极端视角4D视频合成

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 论文](https://arxiv.org/abs/2506.05554)  |  [🎥 主页](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 代码](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 亮点

- **🎯 极端视角合成**：生成高质量4D视频，支持相机从-90°到90°的广泛运动
- **🔧 深度水密网格**：新颖的几何表示，同时建模可见与遮挡区域
- **⚡ 轻量级架构**：仅为14B视频扩散主干1%的可训练参数（140M）
- **🎭 无需多视角训练**：创新的遮罩策略，无需昂贵的多视角数据集
- **🏆 最先进性能**：在极端相机角度下优于现有方法

## 🎬 演示结果

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D将单目视频转变为可控相机的4D体验，在极端视角下也能实现物理一致的结果。*

## 🏗️ 框架概览

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

我们的框架包含三个关键组件：

1. **🔺 深度水密网格构建**：创建鲁棒的几何先验，显式建模可见与遮挡区域
2. **🎭 模拟遮罩策略**：利用单目视频，无需多视角数据集生成有效训练数据
3. **⚙️ 轻量级LoRA适配器**：高效融合几何信息与预训练视频扩散模型

## 🚀 快速开始

### 安装

```bash
# 克隆仓库
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# 创建conda环境
conda create -n ex4d python=3.10
conda activate ex4d
# 安装PyTorch（推荐2.x版本）
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# 安装Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# 安装依赖和diffsynth
pip install -e .
# 安装depthcrafter用于深度估计。（按照DepthCrafter的安装说明准备检查点文件。）
git clone https://github.com/Tencent/DepthCrafter.git
```

### 下载预训练模型
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### 示例用法
#### 1. DW-Mesh重建
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. EX-4D生成（需要48GB显存）
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>输入视频</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>输出视频</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| 方法 | FID (极端) ↓ | FVD (极端) ↓ | VBench 得分 ↑ |
|--------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (本方法)** | **55.42** | **823.61** | **0.450** | -->

### 用户研究结果

- **70.7%** 的参与者更喜欢 EX-4D 而非基线方法
- 在物理一致性和极端视角质量方面表现优异
- 随着摄像机角度变得更极端，表现显著提升


## 🎯 应用场景

- **🎮 游戏**：从 2D 画面生成沉浸式 3D 游戏电影
- **🎬 影视制作**：为后期制作生成新颖的摄像机角度
- **🥽 VR/AR**：打造自由视点视频体验
- **📱 社交媒体**：为内容创作生成动态镜头运动
- **🏢 建筑**：从多个视角可视化空间

<!-- ## 📈 基准测试 -->

<!-- ### 视角范围评估

| 范围 | 小 (0°→30°) | 大 (0°→60°) | 极端 (0°→90°) | 全部 (-90°→90°) |
|-------|----------------|----------------|------------------|-----------------|
| FID 得分 | 44.19 | 50.30 | 55.42 | - |
| 表现差距 | 优于第二名 +9.1% | 优于第二名 +8.9% | 优于第二名 +11.3% | 优于第二名 +15.5% | -->

<!-- *与各类别下第二优方法的表现差距。* -->

## ⚠️ 局限性

- **深度依赖**：表现依赖于单目深度估计的质量
- **计算成本**：高分辨率视频需要较大的计算量
- **反光表面**：对反光或透明材质存在挑战

## 🔮 未来工作
- [ ] 实时推理优化（3DGS / 4DGS）
- [ ] 支持更高分辨率（1K, 2K）
- [ ] 神经网格细化技术

## 🙏 鸣谢

我们感谢 [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) 项目，提供了基础扩散框架。

## 📚 引用

如果您觉得我们的工作有用，请引用：

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---