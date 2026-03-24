<div align="center">

# UniSH: Unifying Scene and Human Reconstruction in a Feed-Forward Pass


**Mengfei Li**<sup>1</sup>, **Peng Li**<sup>1</sup>, **Zheng Zhang**<sup>2</sup>, **Jiahao Lu**<sup>1</sup>, **Chengfeng Zhao**<sup>1</sup>, **Wei Xue**<sup>1</sup>,
<br>
**Qifeng Liu**<sup>1</sup>, **Sida Peng**<sup>3</sup>, **Wenxiao Zhang**<sup>1</sup>, **Wenhan Luo**<sup>1</sup>, **Yuan Liu**<sup>1†</sup>, **Yike Guo**<sup>1†</sup>

<sup>1</sup>HKUST, <sup>2</sup>BUPT, <sup>3</sup>ZJU

<br>

<a href="https://arxiv.org/abs/2601.01222" target="_blank"><img src="https://img.shields.io/badge/arXiv-Paper-b31b1b.svg" alt="arXiv"></a>
<a href="https://murphylmf.github.io/UniSH/" target="_blank"><img src="https://img.shields.io/badge/Project-Page-orange" alt="Project Page"></a>
<a href="https://huggingface.co/spaces/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Spaces-yellow" alt="Hugging Face Demo"></a>
<a href="https://huggingface.co/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue" alt="Hugging Face Model"></a>
<a href="LICENSE" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-green.svg" alt="License"></a>

</div>

---

### TL;DR
Given a monocular video as input, our UniSH is capable of jointly reconstructing scene and human in a single forward pass, enabling effective estimation of scene geometry, camera parameters and SMPL parameters.


<video src="static/teaser_video_final.mp4" autoplay loop muted playsinline width="100%"></video>

<img src="https://raw.githubusercontent.com/murphylmf/UniSH/main/static/teaser.svg" width="100%" style="background-color: white;">

## 🛠️ Installation

We provide a **sudo-free** installation method that works on most Linux servers (including headless ones).

### Step 1: Clone Repository

```bash
git clone https://github.com/murphylmf/UniSH.git
cd UniSH
```

### Step 2: Create Conda Environment
This installs Python, system compilers, and OpenGL drivers.

```bash
conda env create -f environment.yml
conda activate unish
```
### Step 3: Compile Dependencies
This script compiles PyTorch3D, MMCV, and SAM2 from source using the compilers installed in Step 2.

The environment has been tested on **CUDA 12.1** and **CUDA 11.8**. You can specify the CUDA version by passing it as an argument to the installation script.


```bash
# Default (Auto-detect or 12.1)
bash install.sh

# For CUDA 11.8
bash install.sh 11.8

# For CUDA 12.1
bash install.sh 12.1
```

### Step 4: Download SMPL Models
Please download the [SMPL](https://smpl.is.tue.mpg.de/) models and place them in the `body_models` folder.
The directory structure should be organized as follows:

```text
UniSH/
├── body_models/
│   └── smpl/
│       └── smpl/
│           ├── SMPL_FEMALE.pkl
│           ├── SMPL_MALE.pkl
│           └── SMPL_NEUTRAL.pkl
```

## 🚀 Quick Start (Inference)

### Run Inference
Run the following command to reconstruct the scene and human from the video:

```bash
python inference.py --output_dir inference_results/example --video_path examples/example_video.mp4 
```

Please refer to `inference.py` for more information about additional parameters.

## 📝 Citation

If you find this code useful for your research, please consider citing our paper:

```bibtex
@misc{li2026unishunifyingscenehuman,
      title={UniSH: Unifying Scene and Human Reconstruction in a Feed-Forward Pass}, 
      author={Mengfei Li and Peng Li and Zheng Zhang and Jiahao Lu and Chengfeng Zhao and Wei Xue and Qifeng Liu and Sida Peng and Wenxiao Zhang and Wenhan Luo and Yuan Liu and Yike Guo},
      year={2026},
      eprint={2601.01222},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2601.01222}, 
}
```

## 🙏 Acknowledgements

We acknowledge the excellent contributions from the following projects:

* [GVHMR](https://github.com/zju3dv/GVHMR)
* [BEDLAM](https://bedlam.is.tue.mpg.de/)
* [SMPL](https://smpl.is.tue.mpg.de/)
* [VGGT](https://github.com/facebookresearch/vggt)
* [Pi3](https://github.com/yyfz/Pi3)
* [MoGe2](https://github.com/microsoft/moge)

## 📄 License
This project is licensed under the Apache 2.0 License. See [LICENSE](LICENSE) for details.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---