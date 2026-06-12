# Metric depth video toolbox (MDVToolbox)

Tools for Generating and working with metric 3D depth videos.

![gif_banner](https://github.com/user-attachments/assets/4d737bb3-6fb6-4135-b01e-b35528371d22)

_Banner created with 3d_view_depthfile.py_

## Demos

**Showcase video:** https://youtu.be/nEiUloZ591Q

**Movie → 3D conversion demo**: https://www.youtube.com/watch?v=PLFjoNgkZDY

**Sample stereo clips:**
https://github.com/calledit/metric_depth_video_toolbox/releases/tag/Showcase


## Features

### Metric Depth Video Generation

Convert rgb videos into metric depth videos using multiple SOTA models:

- Depth-Anything series (`video_metric_convert.py`) and (`videoanythingmetric_video.py`)
- MoGe  (`moge_video.py`)
- UniDepth  (`unidepth_video.py`)
- UniK3D  (`unik3d_video.py`)
- DepthPro  (`depthpro_video.py`)
- DepthCrafter  (`depthcrafter_video.py`)
- MVSAnywhere  (`video_mvsa.py`)

### Stereo / 3D Conversion

- 2D movies → 3D (`movie_2_3D.py`)
- Stereo rendering from depth and rgb video (`stereo_rerender.py`)
- Parallax infill & diffusion-based stereo inpainting (`stereo_crafter_infill.py`)

### Visualization

- Real-time 3D viewer for metric depth videos (`3d_view_depthfile.py`)  
- Novel-view rendering from depth video (`3d_view_depthfile.py`)  

### Camera Tracking & 3D Reconstruction  

- Depth-assisted camera tracking (`sam_track_video.py`) and (`align_3d_points.py`)  
- Long-term point tracking (CoTracker3) (`track_points_in_video.py`)  
- Pose extraction & alignment tools  

### Export Tools  

Export metric depth video to standard formats for use in other tools: (`convert_metric_depth_video_to_other_format.py`)  

- `.ply` point clouds  
- `.obj` meshes  
- Blender `.blend` & Alembic `.abc` camera tracks  
- 8-bit / 16-bit depth maps  
- Depth rescaling based on triangulation  

### Masking & Cleanup  

- Automatic main subject masking (`generate_video_mask.py`)  
- Subtitle/logo inpainting (`apply_inpainting.sh`)  


## Documentation  

| Topic | Link |  
|---|---|  
Beginner guide | [`HOWTO.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO.md)  
Movie → 3D guide | [`HOWTO_movie2_3d.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO_movie2_3d.md)  
Full tool reference | [`USAGE.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/USAGE.md)  
GUI tutorial video | https://youtu.be/BE_aJCI7DHI  


## Depth Video Format  

MDVT uses **RGB-encoded 16-bit metric depth**:  

- **Red + Green** = upper 8 bits (duplicated for visibility)  
- **Blue** = lower 8 bits  
- Default range: **100 meters**
- Resolution: **~1.5mm depth precision**

Future upgrade for more precision will be done with: **24-bit depth** or **log-encoded depth** for long-range accuracy.

---

## Installation

### Windows
1. install git https://git-scm.com/downloads/win
2. Install miniconda https://docs.conda.io/en/latest/
3. Open the Anacoda prompt(miniconda) from the start menu
4. run
```batch
git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox
windows_installer.bat
```
5. use `conda activate mdvt` to activate conda and use the tools. Some ML models are not supported on windows but the most essential ones are supported like Sterecrafter and depth anything.

### Ubuntu/Debian and OSX

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

### Requirements
The tools that require ML models have been tested on machines with NVIDIA 3090 cards that support CUDA 12.4 and Torch 2.5.1 on [vast.ai](https://cloud.vast.ai/?ref_id=148636) using "template PyTorch (cuDNN Devel)"

### Next steps
- Currently waiting for new stable and accurate depth models.

### Contributing
Is appreciated. Even for simple things like spelling.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---