# 公制深度视频工具箱 (MDVToolbox)

用于生成和处理公制3D深度视频的工具。

![gif_banner](https://github.com/user-attachments/assets/4d737bb3-6fb6-4135-b01e-b35528371d22)

_横幅由 3d_view_depthfile.py 创建_

## 演示

**展示视频：** https://youtu.be/nEiUloZ591Q

**电影 → 3D 转换演示：** https://www.youtube.com/watch?v=PLFjoNgkZDY

**示例立体剪辑：**
https://github.com/calledit/metric_depth_video_toolbox/releases/tag/Showcase


## 特性

### 公制深度视频生成

使用多种最先进模型将RGB视频转换为公制深度视频：

- Depth-Anything 系列（`video_metric_convert.py`）和（`videoanythingmetric_video.py`）
- MoGe  （`moge_video.py`）
- UniDepth  （`unidepth_video.py`）
- UniK3D  （`unik3d_video.py`）
- DepthPro  （`depthpro_video.py`）
- DepthCrafter  （`depthcrafter_video.py`）
- MVSAnywhere  （`video_mvsa.py`）

### 立体 / 3D 转换

- 2D 电影 → 3D（`movie_2_3D.py`）
- 由深度和RGB视频生成立体渲染（`stereo_rerender.py`）
- 视差填充和基于扩散的立体修复（`stereo_crafter_infill.py`）

### 可视化

- 实时3D查看器，用于度量深度视频（`3d_view_depthfile.py`）  
- 来自深度视频的新视角渲染（`3d_view_depthfile.py`）  

### 相机跟踪与3D重建  

- 深度辅助相机跟踪（`sam_track_video.py`）和（`align_3d_points.py`）  
- 长期点追踪（CoTracker3）（`track_points_in_video.py`）  
- 姿态提取与对齐工具  

### 导出工具  

将度量深度视频导出为标准格式以供其他工具使用：（`convert_metric_depth_video_to_other_format.py`）  

- `.ply` 点云  
- `.obj` 网格  
- Blender `.blend` 和 Alembic `.abc` 相机轨迹  
- 8位 / 16位深度图  
- 基于三角测量的深度重标定  

### 掩码与清理  

- 自动主体掩码生成（`generate_video_mask.py`）  
- 字幕/徽标修复（`apply_inpainting.sh`）  


## 文档  

| 主题 | 链接 |  
|---|---|  
初学者指南 | [`HOWTO.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO.md)  
电影→3D指南 | [`HOWTO_movie2_3d.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO_movie2_3d.md)  
完整工具参考 | [`USAGE.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/USAGE.md)  
GUI教程视频 | https://youtu.be/BE_aJCI7DHI  


## 深度视频格式  

MDVT使用**RGB编码的16位度量深度**：  

- **红色 + 绿色** = 高8位（为可见性重复）  
- **蓝色** = 低8位  
- 默认范围：**100米**  
- 分辨率：**~1.5毫米深度精度**  

未来将通过以下方式进行更高精度升级：**24位深度**或**对数编码深度**以实现远距离精度。  

---  

## 安装  

### Windows  
1. 安装 git https://git-scm.com/downloads/win  
2. 安装 miniconda https://docs.conda.io/en/latest/  
3. 从开始菜单打开 Anaconda 提示符（miniconda）  
4. 运行
```batch
git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox
windows_installer.bat
```
5. 使用 `conda activate mdvt` 激活 conda 并使用工具。一些机器学习模型不支持 Windows，但大多数核心模型如 Sterecrafter 和 depth anything 是支持的。

### Ubuntu/Debian 和 OSX

```bash


git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox

# on linux
sudo apt-get install -y libgl1
./install_mdvtoolbox.sh

#Optional (only required for some tools)
./install_mdvtoolbox.sh -megasam
./install_mdvtoolbox.sh -geometrycrafter
./install_mdvtoolbox.sh -unik3d
./install_mdvtoolbox.sh -depthpro
./install_mdvtoolbox.sh -stereocrafter
./install_mdvtoolbox.sh -madpose
./install_mdvtoolbox.sh -unidepth
./install_mdvtoolbox.sh -moge
./install_mdvtoolbox.sh -promptda

# if using headless linux you need to start a virtual x11 server
apt-get install xvfb
Xvfb :2 &
export DISPLAY=:2

# OSX (OSX only supports post processing of depth videos not generation of them. As the ML models need CUDA)
# (open3d requires python3.11 on OSX (as of 2025)))
pip3.11 install open3d numpy opencv-python

```

### 需求
需要机器学习模型的工具已在配备支持Cuda 12.4和Torch 2.5.1的nvidia 3090显卡的机器上测试，测试平台为[vast.ai](https://cloud.vast.ai/?ref_id=148636)，使用“template PyTorch (cuDNN Devel)”

### 下一步
- 目前正在等待新的稳定且精确的深度模型。

### 贡献
欢迎贡献。即使是拼写等简单的事项也非常感谢。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---