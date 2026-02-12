<div align="center">

# TAPIP3D：在持久三维几何中跟踪任意点
<a href="https://arxiv.org/abs/2504.14717"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://tapip3d.github.io'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>

[Bowei Zhang](https://scholar.google.com/citations?user=tYH72AYAAAAJ)<sup>1,2</sup>*, [Lei Ke](https://www.kelei.site/)<sup>1</sup>\*, [Adam W. Harley](https://adamharley.com/)<sup>3</sup>, [Katerina Fragkiadaki](https://www.cs.cmu.edu/~katef/)<sup>1</sup>

<sup>1</sup>卡内基梅隆大学   &nbsp;  <sup>2</sup>北京大学 &nbsp;  <sup>3</sup>斯坦福大学

**NeurIPS 2025**

\* 贡献相同

<!-- <a href='https://huggingface.co/spaces/your-username/project'><img src='https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Live_Demo-blue'></a> -->

</div>

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/teaser1.gif" width="100%" alt="TAPIP3D overview">


---

### 🚀 新闻
- **(2025.12.28)** 🔥 我们更新了**训练**和**评估**代码！请查看下面的新章节。

## 概述
**TAPIP3D** 是一种用于单目 RGB 和 RGB-D 视频序列的长期**前馈**三维点跟踪方法。它引入了一种三维特征云表示，将图像特征提升到持久的世界坐标空间，抵消相机运动，实现跨帧的精确轨迹估计。

我们提供了 TAPIP3D 的详细[视频演示](https://neurips.cc/virtual/2025/loc/san-diego/poster/117634#:~:text=Within%20this%20stabilized%203D%20representation,trained%20checkpoints%20will%20be%20public.)。

## 安装
### 安装依赖

1. 准备环境
```bash
conda create -n tapip3d python=3.10
conda activate tapip3d

pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 "xformers>=0.0.27" --index-url https://download.pytorch.org/whl/cu124
pip install torch-scatter -f https://data.pyg.org/whl/torch-2.4.1+cu124.html
pip install -r requirements.txt
```

2. 编译 pointops2

```bash
cd third_party/pointops2
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../..
```

3. 编译 megasam
```bash
cd third_party/megasam/base
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../../..
```
### 下载检查点

下载我们的 TAPIP3D 模型检查点[这里](https://huggingface.co/zbww/tapip3d/resolve/main/tapip3d_final.pth)到 `checkpoints/tapip3d_final.pth`

如果你想在单目视频上运行 TAPIP3D，你需要手动准备以下检查点以运行 MegaSAM：

1. 从[这里](https://huggingface.co/spaces/LiheYoung/Depth-Anything/resolve/main/checkpoints/depth_anything_vitl14.pth)下载 DepthAnything V1 检查点，并放置到 `third_party/megasam/Depth-Anything/checkpoints/depth_anything_vitl14.pth`

2. 从[这里](https://drive.google.com/drive/folders/1sWDsfuZ3Up38EUQt7-JDTT1HcGHuJgvT)下载 RAFT 检查点，并放置到 `third_party/megasam/cvd_opt/raft-things.pth`

此外，[MoGe](https://wangrc.site/MoGePage/) 和 [UniDepth](https://github.com/lpiccinelli-eth/UniDepth.git) 的检查点将在运行演示时自动下载。请确保你的网络连接正常。

## 演示用法

我们提供了一个简单的演示脚本 `inference.py`，以及位于 `demo_inputs/` 目录中的示例输入数据。

该脚本接受 `.mp4` 视频文件或 `.npz` 文件作为输入。如果提供 `.npz` 文件，格式应如下：

- `video`：形状为 (T, H, W, 3) 的数组，数据类型：uint8
- `depths`（可选）：形状为 (T, H, W) 的数组，数据类型：float32
- `intrinsics`（可选）：形状为 (T, 3, 3) 的数组，数据类型：float32
- `extrinsics`（可选）：形状为 (T, 4, 4) 的数组，数据类型：float32

为了演示，脚本在第一帧使用了一个 32x32 的点网格作为查询点。

### 使用单目视频推理

通过提供视频作为 `--input_path`，脚本首先运行带有 [MoGe](https://wangrc.site/MoGePage/) 的 [MegaSAM](https://github.com/mega-sam/mega-sam) 来估计深度图和相机参数。随后，模型将在全局框架内处理这些输入。

**演示 1**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo1.gif" width="100%" alt="Demo 1">

运行推理：



```bash
python inference.py --input_path demo_inputs/sheep.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

一个 npz 文件将被保存到 `outputs/inference/`。要可视化结果：

```bash
python visualize.py <result_npz_path>
```

**Demo 2**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo2.gif" width="100%" alt="Demo 2">

```bash
python inference.py --input_path demo_inputs/pstudio.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

**已知深度和相机参数的推理**

如果提供包含所有四个键（`rgb`、`depths`、`intrinsics`、`extrinsics`）的 `.npz` 文件，模型将在对齐的全局坐标系中运行，生成世界坐标下的点轨迹。  
我们在[这里](https://huggingface.co/zbww/tapip3d/resolve/main/demo_inputs/dexycb.npz?download=true)提供了一个示例 `.npz` 文件，请将其放置于 `demo_inputs/` 目录下。

**演示 3**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo3.gif" width="100%" alt="Demo 3">

```bash
python inference.py --input_path demo_inputs/dexycb.npz --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

## 训练与评估

### 1. 数据集准备
请参考 [DATASET.md](https://raw.githubusercontent.com/zbw001/TAPIP3D/main/DATASET.md) 了解训练和评估数据集的准备说明。

### 2. 训练
开始训练，请运行：
```bash
bash scripts/train.sh
```
- `experiment_name`：在**WandB**上显示的运行名称。
- `experiment_id`：唯一标识符。使用相同的`experiment_id`重新运行将**自动从最新检查点恢复**训练。

### 3. 评估
要评估一个检查点，请运行：
```bash
bash scripts/eval.sh
```
您可以通过修改 `scripts/eval.sh` 中的 `checkpoint` 变量来指定要评估的模型。

## 引用
如果您觉得本项目有用，请考虑引用：

```
@article{tapip3d,
  title={TAPIP3D: Tracking Any Point in Persistent 3D Geometry},
  author={Zhang, Bowei and Ke, Lei and Harley, Adam W and Fragkiadaki, Katerina},
  journal={arXiv preprint arXiv:2504.14717},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-12

---