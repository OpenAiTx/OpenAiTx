
<h2 align="center"> <a href="https://arxiv.org/abs/2412.09606">Feat2GS：使用高斯喷溅探测视觉基础模型</a>
</h2>

<h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2412.09606-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2412.09606) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://fanegg.github.io/Feat2GS/)  [![youtube](https://img.shields.io/badge/Video-E33122?logo=Youtube)](https://youtu.be/4fT5lzcAJqo?si=_fCSIuXNBSmov2VA)  [![Gradio](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Demo-orange)](https://huggingface.co/spaces/endless-ai/Feat2GS)  [![X](https://img.shields.io/badge/@Yue%20Chen-black?logo=X)](https://twitter.com/faneggchen)  [![Bluesky](https://img.shields.io/badge/@Yue%20Chen-white?logo=Bluesky)](https://bsky.app/profile/fanegg.bsky.social)

[Yue Chen](https://fanegg.github.io/),
[Xingyu Chen](https://rover-xingyu.github.io/),
[Anpei Chen](https://apchenstu.github.io/),
[Gerard Pons-Moll](https://virtualhumans.mpi-inf.mpg.de/),
[Yuliang Xiu](https://xiuyuliang.cn/)
</h5>

<div align="center">
本仓库是 Feat2GS 的官方实现，Feat2GS 是一个统一框架，用于探测视觉基础模型的“纹理和几何感知”。新颖视角合成作为三维评估的有效代理。
</div>
<br>

https://github.com/user-attachments/assets/07ebb8e1-6001-47bf-bf74-984b0032cc17


## 更新

- [2025年7月10日] 新增 VGGT 编码器和解码器特征的评估。结果见[这里](https://raw.githubusercontent.com/fanegg/Feat2GS/main/assets/Feat2GS_Benchmark.pdf)。

## 快速开始

### 安装
1. 克隆 Feat2GS 并从 [DUSt3R](https://github.com/naver/dust3r)/[MASt3R](https://github.com/naver/mast3r) 下载预训练模型。
```bash
git clone https://github.com/fanegg/Feat2GS.git
cd Feat2GS/submodules/mast3r/
mkdir -p checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/DUSt3R/DUSt3R_ViTLarge_BaseDecoder_512_dpt.pth -P checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/MASt3R/MASt3R_ViTLarge_BaseDecoder_512_catmlpdpt_metric.pth -P checkpoints/
cd ../../
```
2. 创建环境，这里我们展示一个使用 conda 的示例。

```bash
conda create -n feat2gs python=3.11 cmake=3.14.0
conda activate feat2gs
pip install "torch==2.5.1" "torchvision==0.20.1" "numpy<2" --index-url https://download.pytorch.org/whl/cu121  # use the correct version of cuda for your system
cd Feat2GS/
pip install -r requirements.txt
pip install submodules/simple-knn
```

3. 可选但强烈建议，为 RoPE 编译 cuda 内核（如 CroCo v2 中所示）。
```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd submodules/mast3r/dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../../../
```
4.（可选）按照[此说明](https://github.com/cvlab-columbia/zero123?tab=readme-ov-file#novel-view-synthesis-1)安装探测[Zero123](https://github.com/cvlab-columbia/zero123)的依赖项。

### 使用方法
1. 数据准备（我们提供了评估和推理数据集：[链接](https://drive.google.com/file/d/1PLTFcvJfiPucrB-pIwfp5QG-AIHcJdjN/view?usp=drive_link)）

```bash
  cd <data_root>/Feat2GS/
```

> 如果您想构建自定义数据集，请按照并编辑：
> ```
> build_dataset/0_create_json.py ## 创建 dataset_split.json 以划分训练/测试集
> build_dataset/1_create_feat2gs_dataset.py ## 使用 dataset_split.json 创建数据集
> ```


2. 评估视觉基础模型：

  | 步骤 | 描述（命令链接） |
  |------|-------------|
  | (1)  | [DUSt3R 初始化与特征提取](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L245-L250) |
  | (2)  | [从特征读取 3DGS 并联合优化姿态](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L253-L262) |
  | (3)  | [测试姿态初始化](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L265-L270) |
  | (4)  | [渲染测试视图以进行评估](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L273-L282) |
  | (5)  | [指标](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L298-L301) |
  | (可选)  | [使用生成的轨迹渲染视频](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L304-L315) |

```bash
  # Run evaluation for all datasets, all VFM features, all probing modes
  bash scripts/run_feat2gs_eval_parallel.sh

  # (Example) Run evaluation for a single scene, DINO feature, Geometry mode
  bash scripts/run_feat2gs_eval.sh
```
> [!注意]
> 为了并行运行实验，我们添加了**GPU锁**功能，确保每个GPU上只有一个评估实验在运行。实验结束后，GPU会自动解锁。**如果通过`Ctrl+C`中断，GPU不会自动解锁。**解决方法是在你的`LOCK_DIR`中手动删除`.lock`文件。要禁用此功能，请注释脚本中的以下行：
    [L4-L5](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L4-L5),
    [L9-L22](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L9-L22),
    [L223-L233](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L223-L233),
    [L330-L331](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L330-L331).

  | 配置 | 操作 |
  |--------|-----------------|
  | GPU | 在[`<AVAILABLE_GPUS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L7)中编辑 |
  | 数据集 | 在[`<SCENES[$Dataset]>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L105-L111)中编辑 |
  | 场景 | 在[`<SCENES_$Dataset>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L31-L99)中编辑 |
  | 视觉基础模型 | 在[`<FEATURES>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L120-L162)中编辑 |
  | 探测模式 | 在[`<MODELS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L181-L188)中编辑 |
  | 仅推理模式 | 注释[`execute_command`](https://github.com/fanegg/Feat2GS/blob/main/scripts/run_feat2gs_eval_parallel.sh#L325-L327)中步骤 (3)(4)(5) |

```bash
  # Evaluate Visual Foundation Models on DTU dataset
  bash scripts/run_feat2gs_eval_dtu_parallel.sh

  # Run InstantSplat for evaluation
  bash scripts/run_instantsplat_eval_parallel.sh
```
3. 训练完成后，使用生成的轨迹渲染 RGB/深度/法线视频。


```bash
  # If render depth/normal, set RENDER_DEPTH_NORMAL=true
  # Set type of generated trjectory by editing <TRAJ_SCENES>
  bash scripts/run_video_render.sh

  # Render video on DTU dataset
  bash scripts/run_video_render_dtu.sh
```
### 🎮 交互式演示

#### 🚀 快速开始
1. **输入图像**
* 上传2张或更多同一场景的不同视角图像
* 为获得最佳效果，请确保图像有良好的重叠部分

2. **步骤1：DUSt3R 初始化与特征提取**
* 点击“运行步骤1”处理您的图像
* 此步骤估计初始DUSt3R点云和相机位姿，并提取每个像素的DUSt3R特征

3. **步骤2：从特征中读取3DGS**
* 设置训练迭代次数，次数越多质量越好但时间更长（默认：2000，最大：8000）
* 点击“运行步骤2”优化3D模型

4. **步骤3：视频渲染**
* 选择相机轨迹
* 点击“运行步骤3”生成您的3D模型视频
  
```bash
gradio demo.py
```

#### 💡 小贴士
* 处理时间取决于图像分辨率和数量
* 为获得最佳性能，请在高端GPU（A100/4090）上测试
* 使用鼠标与3D模型交互：
  - 左键：旋转
  - 滚轮：缩放
  - 右键：平移


## 致谢

本工作建立在许多优秀的研究成果和开源项目基础上，感谢所有作者的分享！

- [Gaussian-Splatting](https://github.com/graphdeco-inria/gaussian-splatting) 和 [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [gsplat](https://github.com/nerfstudio-project/gsplat)
- [DUSt3R](https://github.com/naver/dust3r) 和 [MASt3R](https://github.com/naver/mast3r)
- [InstantSplat](https://github.com/NVlabs/InstantSplat)
- [Probe3D](https://github.com/mbanani/probe3d)
- [FeatUp](https://github.com/mhamilton723/FeatUp)
- [Shape of Motion](https://github.com/vye16/shape-of-motion/)
- [Splatt3R](https://github.com/btsmart/splatt3r)
- [VGGT](https://github.com/facebookresearch/vggt)

## 引用
如果您在研究中发现我们的工作有用，请考虑点赞 :star: 并引用以下论文 :pencil:。

```bibTeX
@inproceedings{chen2025feat2gs,
  title={Feat2gs: Probing visual foundation models with gaussian splatting},
  author={Chen, Yue and Chen, Xingyu and Chen, Anpei and Pons-Moll, Gerard and Xiu, Yuliang},
  booktitle={Proceedings of the Computer Vision and Pattern Recognition Conference},
  pages={6348--6361},
  year={2025}
}
```

## 联系方式

如有反馈、问题或媒体咨询，请联系 [Yue Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:faneggchen@gmail.com) 和 [Xingyu Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:roverxingyu@gmail.com)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-10

---